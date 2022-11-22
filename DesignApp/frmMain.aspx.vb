Imports NIC.LibApp
Imports LibReports
Imports NICFrameWork.LibCommon

Public Class frmMain
    Inherits cBaseForm
    Private dsEntry As DataSet
    Private objcmap As cMap
    Private dt As DataTable
    Private dtlink As DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dsEntry = New DataSet
        objcmap = New cMap
        Session("txtMainSearch") = String.Empty
        If Not IsPostBack Then


            If Request.QueryString("Cul") IsNot Nothing AndAlso Request.QueryString("Cul") = "gu-IN" Then
                Session("MyCulture") = Request.QueryString("Cul").ToString
                Response.Redirect("frmMain.aspx")

            End If
            'If (Request.QueryString("Lat") IsNot Nothing And Request.QueryString("lng") IsNot Nothing) Then
            '    BindMapForMobile(Request.QueryString("Lat"), Request.QueryString("lng"))
            'Else
            '    Bind_City()
            '    If Request.Cookies("Preferences") Is Nothing Then
            '        Dim lbllocation1 As Label = DirectCast(Master.FindControl("lbllocation"), Label)

            '        If (lbllocation1.Text IsNot Nothing And lbllocation1.Text = String.Empty) Then
            '            'ModalPopupselectCity.Show()
            '            lbllocation1.Text = "Sabarmati"

            '            'added on 28-12-2016
            '            Dim Str As New StringBuilder
            '            'Str.Append(" <script>")
            '            'lblOfficeName.Text = "Mamlatdar Sabarmati"
            '            'lblOfficecontactno.Text = "મામલતદાર કચેરી સાબરમતી"
            '            'lblofficeFaxno.Text = ""
            '            'lblofficeEmail.Text = ""

            '            Str.Append("function initMap() {")
            '            Str.Append("var myLatLng = {lat: " + Convert.ToString(23.065833) + ", lng:  " + Convert.ToString(72.581709) + "};")

            '            Str.Append(" var map = new google.maps.Map(document.getElementById('map'), {")
            '            Str.Append(" zoom: 14,")
            '            Str.Append("center: myLatLng")
            '            Str.Append("});")
            '            Str.Append("var marker;")

            '            Dim i As Integer
            '            'For i = 0 To dr.Count - 1
            '            Str.Append("myLatLng = { lat: " + Convert.ToString(23.065833) + ", lng: " + Convert.ToString(72.581709) + " };")
            '            Str.Append("marker = new google.maps.Marker({")
            '            Str.Append("position: myLatLng,")
            '            Str.Append("map:    map,")
            '            Str.Append("Title: '" + Convert.ToString("Mamlatdar Sabarmati") + "'")
            '            Str.Append("});")
            '            'Next
            '            Str.Append("}")


            '            Dim gc As New HtmlGenericControl

            '            gc.TagName = "script"
            '            gc.Attributes.Add("type", "text/javascript")
            '            gc.InnerHtml = Str.ToString()

            '            Page.Header.Controls.Add(gc)

            '            Dim gc1 As New HtmlGenericControl

            '            gc1.TagName = "script"
            '            gc1.Attributes.Add("type", "text/javascript")
            '            gc1.Attributes.Add("src", "https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap")
            '            Page.Controls.Add(gc1)



            '            'end added




            '        End If
            '    Else
            '        selectcity()
            '    End If
            'End If
        End If


        ' Bind_Msg() 'get news from webservice
        Bind_News()  'get news from database
    End Sub

    'Public Sub call1()
    '    ModalPopupselectCity.Show()
    'End Sub

    <System.Web.Script.Services.ScriptMethod(), _
    System.Web.Services.WebMethod()> _
    Public Shared Function GetSearchCityList(ByVal prefixText As String, ByVal count As Integer) As List(Of String)
        Dim Ds As New DataSet
        Dim objParameter As New cParameter(Ds)
        Dim objcmap As New cMap
        objParameter.CreateParameter(Ds, "@Flag", 1)
        objParameter.CreateParameter(Ds, "@prefixText", prefixText)
        objcmap.GetDataSet(Ds, enmcMap.get_lat_lng)
        Dim CityValue As List(Of String) = New List(Of String)
        Dim i As Integer
        For i = 0 To Ds.Tables("City").Rows.Count - 1
            If (HttpContext.Current.Session("MyCulture") = "en-GB") Then
                CityValue.Add(Convert.ToString(Ds.Tables("City").Rows(i)("CityName")))
            Else
                CityValue.Add(Convert.ToString(Ds.Tables("City").Rows(i)("CityNameG")))
            End If
        Next
        Return CityValue
    End Function

    Protected Sub lnk_Click(sender As Object, e As EventArgs)
        Dim lnk As LinkButton
        lnk = CType(sender, LinkButton)
        Dim Ds As DataSet
        Ds = CType(ViewState("City"), DataSet)
        Dim dr As DataRow()
        Dim cookie As HttpCookie = Request.Cookies("Preferences")
        If cookie Is Nothing Then
            cookie = New HttpCookie("Preferences")
            cookie("Name") = lnk.Text.ToString()
            cookie.Expires = DateTime.Now.AddMonths(1)
            Response.Cookies.Add(cookie)
            If (Session("MyCulture") = "en-GB") Then
                dr = Ds.Tables("City1").Select("CityName='" & lnk.Text.ToString() & "'")
                Session("City") = lnk.Text
            Else
                If Ds.Tables("City1").Columns.Contains("CityNameG") Then
                    dr = Ds.Tables("City1").Select("CityNameG='" & lnk.Text.ToString() & "'")
                    Session("City") = lnk.Text
                Else
                    dr = Ds.Tables("City1").Select("CityName='" & lnk.Text.ToString() & "'")
                    Session("City") = lnk.Text
                End If

            End If
        Else
            If (Session("MyCulture") = "en-GB") Then
                If Ds.Tables("City1").Columns.Contains("CityNameG") Then
                    dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "' OR CityNameG='" & cookie("Name") & "'")
                    Session("City") = cookie("Name")
                Else
                    dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")
                    Session("City") = cookie("Name")
                End If

            Else
                If Ds.Tables("City1").Columns.Contains("CityNameG") Then
                    dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "' OR CityNameG='" & cookie("Name") & "'")
                    Session("City") = cookie("Name")
                Else
                    dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")
                    Session("City") = cookie("Name")
                End If

            End If
        End If
        If dr.Length <= 0 Then
            Exit Sub
        End If
        '  Dim lbllocationbutton As LinkButton = DirectCast(Master.FindControl("lnkchangecity"), LinkButton)
        'dr = Ds.Tables("City1").Select("CityName='" & lnk.Text.ToString() & "'")
        'Session("City") = lnk.Text.ToString()
        '  Dim lbllocation1 As Label = DirectCast(Master.FindControl("lbllocation"), Label)
        '  lbllocation1.Text = Convert.ToString(lnk.Text.ToString())
        '  lbllocationbutton.Visible = True
        'Me.MasterPageFile.GetType.InvokeMember("BindLocation", System.Reflection.BindingFlags.InvokeMethod, Nothing, Me.Page, Nothing)
        Dim Str As New StringBuilder
        'Str.Append(" <script>")
        'lblOfficeName.Text = Convert.ToString(dr(0).Item("OfficeName_E"))
        'lblofficeAddress.Text = IIf(Convert.ToString(dr(0).Item("Office_Address")) = "", " ", Convert.ToString(dr(0).Item("Office_Address")))
        'lblOfficecontactno.Text = IIf(Convert.ToString(dr(0).Item("Office_ContactNo")) = "", " ", Convert.ToString(dr(0).Item("Office_ContactNo")))
        'lblofficeFaxno.Text = IIf(Convert.ToString(dr(0).Item("Office_FaxNo")) = "", " ", Convert.ToString(dr(0).Item("Office_FaxNo")))
        'lblofficeEmail.Text = IIf(Convert.ToString(dr(0).Item("Office_EmailID")) = "", " ", Convert.ToString(dr(0).Item("Office_EmailID")))

        Str.Append("function initMap() {")
        Str.Append("var myLatLng = {lat: " + Convert.ToString(dr(0).Item("lat")) + ", lng:  " + Convert.ToString(dr(0).Item("lng")) + "};")

        Str.Append(" var map = new google.maps.Map(document.getElementById('map'), {")
        Str.Append(" zoom: 14,")
        Str.Append("center: myLatLng")
        Str.Append("});")
        Str.Append("var marker;")

        Dim i As Integer
        For i = 0 To dr.Count - 1
            Str.Append("myLatLng = { lat: " + Convert.ToString(dr(i).Item("lat")) + ", lng: " + Convert.ToString(dr(i).Item("lng")) + " };")
            Str.Append("marker = new google.maps.Marker({")
            Str.Append("position: myLatLng,")
            Str.Append("map:    map,")
            Str.Append("Title: '" + Convert.ToString(dr(0).Item("OfficeName_E")) + "'")
            Str.Append("});")
        Next
        Str.Append("}")


        Dim gc As New HtmlGenericControl

        gc.TagName = "script"
        gc.Attributes.Add("type", "text/javascript")
        gc.InnerHtml = Str.ToString()

        Page.Header.Controls.Add(gc)

        Dim gc1 As New HtmlGenericControl

        gc1.TagName = "script"
        gc1.Attributes.Add("type", "text/javascript")
        gc1.Attributes.Add("src", "https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap")
        Page.Controls.Add(gc1)

        ' <script async defer
        'src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap"></script>

        ModalPopupselectCity.Hide()
    End Sub
    Protected Sub BindMapForMobile(lat As String, lng As String)
        Try
            Dim objParameter As New cParameter(dsEntry)
            objParameter.CreateParameter(dsEntry, "@Flag", 3)
            objParameter.CreateParameter(dsEntry, "@lat", lat)
            objParameter.CreateParameter(dsEntry, "@lng", lng)
            objcmap.GetDataSet(dsEntry, enmcMap.get_lat_lng)
            'Dim dr As DataRow

            'dr = dsEntry.Tables("City").Rows(0)

            'If (dsEntry.Tables("City").Rows(0) IsNot Nothing) Then

            '    '    Dim lbllocation1 As Label = DirectCast(Master.FindControl("lbllocation"), Label)
            '    '   lbllocation1.Text = Convert.ToString(dsEntry.Tables("City").Rows(0)("CityName"))
            '    '   Session("City") = Convert.ToString(dsEntry.Tables("City").Rows(0)("CityName"))
            '    'Me.MasterPageFile.GetType.InvokeMember("BindLocation", System.Reflection.BindingFlags.InvokeMethod, Nothing, Me.Page, Nothing)
            '    Dim Str As New StringBuilder
            '    'Str.Append(" <script>")
            '    'lblOfficeName.Text = Convert.ToString(dsEntry.Tables("City").Rows(0)("OfficeName_E"))
            '    'lblofficeAddress.Text = IIf(Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_Address")) = "", " ", Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_Address")))
            '    'lblOfficecontactno.Text = IIf(Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_ContactNo")) = "", " ", Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_ContactNo")))
            '    'lblofficeFaxno.Text = IIf(Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_FaxNo")) = "", " ", Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_FaxNo")))
            '    'lblofficeEmail.Text = IIf(Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_EmailID")) = "", " ", Convert.ToString(dsEntry.Tables("City").Rows(0)("Office_EmailID")))

            '    Str.Append("function initMap() {")
            '    Str.Append("var myLatLng = {lat: " + Convert.ToString(dsEntry.Tables("City").Rows(0)("lat")) + ", lng:  " + Convert.ToString(dsEntry.Tables("City").Rows(0)("lng")) + "};")

            '    Str.Append(" var map = new google.maps.Map(document.getElementById('map'), {")
            '    Str.Append(" zoom: 14,")
            '    Str.Append("center: myLatLng")
            '    Str.Append("});")
            '    Str.Append("var marker;")



            '    Str.Append("myLatLng = { lat: " + Convert.ToString(dsEntry.Tables("City").Rows(0)("lat")) + ", lng: " + Convert.ToString(dsEntry.Tables("City").Rows(0)("lng")) + " };")
            '    Str.Append("marker = new google.maps.Marker({")
            '    Str.Append("position: myLatLng,")
            '    Str.Append("map:    map,")
            '    Str.Append("Title: '" + Convert.ToString(dsEntry.Tables("City").Rows(0)("OfficeName_E")) + "'")
            '    Str.Append("});")

            '    Str.Append("}")


            '    Dim gc As New HtmlGenericControl

            '    gc.TagName = "script"
            '    gc.Attributes.Add("type", "text/javascript")
            '    gc.InnerHtml = Str.ToString()

            '    Page.Header.Controls.Add(gc)

            '    Dim gc1 As New HtmlGenericControl

            '    gc1.TagName = "script"
            '    gc1.Attributes.Add("type", "text/javascript")
            '    gc1.Attributes.Add("src", "https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap")
            '    Page.Controls.Add(gc1)

            'End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnSearchmain_Click(sender As Object, e As EventArgs) Handles btnSearchmain.ServerClick
        If (Convert.ToString(txtsearch.Value) <> String.Empty) Then
            Session("txtMainSearch") = txtsearch.Value
            Response.Redirect("~/Citizen/CitizenService.aspx")
        End If

    End Sub
    Protected Sub Bind_City()
        Try
            Dim objParameter As New cParameter(dsEntry)
            If (txtSearchCity.Text.Trim <> String.Empty) Then
                objParameter.CreateParameter(dsEntry, "@Flag", 2)
                objParameter.CreateParameter(dsEntry, "@prefixText", txtSearchCity.Text.Trim)

            End If

            objcmap.GetDataSet(dsEntry, enmcMap.get_lat_lng)
            ViewState("City") = dsEntry
            dlCity.DataSource = dsEntry.Tables("City")
            dlCity.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub btnSearchGo_Click(sender As Object, e As EventArgs) Handles btnSearchGo.Click

        If (txtSearchCity.Text <> "") Then
            '  selectcity()
        Else
            ModalPopupselectCity.Show()
        End If



    End Sub


    'Public Sub selectcity()
    '    Dim Ds As DataSet
    '    Ds = CType(ViewState("City"), DataSet)

    '    Dim dr As DataRow()


    '    Dim cookie As HttpCookie = Request.Cookies("Preferences")
    '    If cookie Is Nothing Then
    '        cookie = New HttpCookie("Preferences")
    '        cookie("Name") = txtSearchCity.Text
    '        cookie.Expires = DateTime.Now.AddMonths(1)
    '        Response.Cookies.Add(cookie)

    '        If (Session("MyCulture") = "en-GB") Then
    '            dr = Ds.Tables("City1").Select("CityName='" & txtSearchCity.Text & "'")
    '            Session("City") = txtSearchCity.Text
    '        Else
    '            If (Ds.Tables("City1").Columns.Contains("CityNameG")) Then
    '                dr = Ds.Tables("City1").Select("CityNameG='" & txtSearchCity.Text & "'")
    '                Session("City") = txtSearchCity.Text
    '            Else
    '                dr = Ds.Tables("City1").Select("CityName='" & txtSearchCity.Text & "'")
    '                Session("City") = txtSearchCity.Text
    '            End If

    '        End If

    '    Else
    '        If (Session("MyCulture") = "en-GB") Then
    '            If (Ds.Tables("City1").Columns.Contains("CityNameG")) Then
    '                dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "' OR CityNameG='" & cookie("Name") & "'")
    '                Session("City") = cookie("Name")
    '            Else
    '                dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")
    '                Session("City") = cookie("Name")
    '            End If
    '            ' dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")

    '        Else
    '            If (Ds.Tables("City1").Columns.Contains("CityNameG")) Then
    '                dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "' OR CityNameG='" & cookie("Name") & "'")
    '                Session("City") = cookie("Name")
    '            Else
    '                dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")
    '                Session("City") = cookie("Name")
    '            End If
    '            ' dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")

    '        End If
    '    End If

    '    If (dr.Length <= 0) Then
    '        Exit Sub
    '    End If
    '    'If (dr.Count > 0) Then
    '    '    Dim lbllocationbutton As LinkButton = DirectCast(Master.FindControl("lnkchangecity"), LinkButton)

    '    '    Dim lbllocation1 As Label = DirectCast(Master.FindControl("lbllocation"), Label)
    '    '    lbllocationbutton.Visible = True
    '    '    lbllocation1.Text = Convert.ToString(txtSearchCity.Text.ToString())
    '    '    'Me.MasterPageFile.GetType.InvokeMember("BindLocation", System.Reflection.BindingFlags.InvokeMethod, Nothing, Me.Page, Nothing)
    '    '    Dim Str As New StringBuilder
    '    '    'Str.Append(" <script>")
    '    '    'lblOfficeName.Text = Convert.ToString(dr(0).Item("OfficeName_E"))
    '    '    'lblofficeAddress.Text = IIf(Convert.ToString(dr(0).Item("Office_Address")) = "", " ", Convert.ToString(dr(0).Item("Office_Address")))
    '    '    'lblOfficecontactno.Text = IIf(Convert.ToString(dr(0).Item("Office_ContactNo")) = "", " ", Convert.ToString(dr(0).Item("Office_ContactNo")))
    '    '    'lblofficeFaxno.Text = IIf(Convert.ToString(dr(0).Item("Office_FaxNo")) = "", " ", Convert.ToString(dr(0).Item("Office_FaxNo")))
    '    '    'lblofficeEmail.Text = IIf(Convert.ToString(dr(0).Item("Office_EmailID")) = "", " ", Convert.ToString(dr(0).Item("Office_EmailID")))

    '    '    Str.Append("function initMap() {")
    '    '    Str.Append("var myLatLng = {lat: " + Convert.ToString(dr(0).Item("lat")) + ", lng:  " + Convert.ToString(dr(0).Item("lng")) + "};")

    '    '    Str.Append(" var map = new google.maps.Map(document.getElementById('map'), {")
    '    '    Str.Append(" zoom: 14,")
    '    '    Str.Append("center: myLatLng")
    '    '    Str.Append("});")
    '    '    Str.Append("var marker;")

    '    '    Dim i As Integer
    '    '    For i = 0 To dr.Count - 1
    '    '        Str.Append("myLatLng = { lat: " + Convert.ToString(dr(i).Item("lat")) + ", lng: " + Convert.ToString(dr(i).Item("lng")) + " };")
    '    '        Str.Append("marker = new google.maps.Marker({")
    '    '        Str.Append("position: myLatLng,")
    '    '        Str.Append("map:    map,")
    '    '        Str.Append("Title: '" + Convert.ToString(dr(0).Item("OfficeName_E")) + "'")
    '    '        Str.Append("});")
    '    '    Next
    '    '    Str.Append("}")


    '    '    Dim gc As New HtmlGenericControl

    '    '    gc.TagName = "script"
    '    '    gc.Attributes.Add("type", "text/javascript")
    '    '    gc.InnerHtml = Str.ToString()

    '    '    Page.Header.Controls.Add(gc)

    '    '    Dim gc1 As New HtmlGenericControl

    '    '    gc1.TagName = "script"
    '    '    gc1.Attributes.Add("type", "text/javascript")
    '    '    gc1.Attributes.Add("src", "https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap")
    '    '    Page.Controls.Add(gc1)

    '    '    ' <script async defer
    '    '    'src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap"></script>

    '    '    ModalPopupselectCity.Hide()
    '    'Else
    '    '    Bind_City()
    '    '    ModalPopupselectCity.Show()
    '    'End If
    'End Sub

    'Protected Sub Bind_Msg()
    '    Try


    '        Dim objServicePressRelase As New DigitalGujaratPressRelease.DigitalGujaratSoapClient


    '        Dim Press As String
    '        Press = objServicePressRelase.LatestPressReleases()


    '        Dim ds As New DataSet
    '        Dim xmldoc As New System.Xml.XmlDocument
    '        xmldoc.LoadXml(Press)
    '        For i As Integer = 0 To xmldoc.ChildNodes(0).ChildNodes.Count - 1
    '            Dim newLi As New HtmlGenericControl
    '            newLi.ID = "ctrlLi" & i
    '            newLi.TagName = "li"
    '            'c = i Mod 8
    '            'c += 1
    '            'newLi.Attributes.Add("class", "s" + c.ToString)
    '            PressGroup.Controls.Add(newLi)
    '            Dim newA As New HtmlGenericControl
    '            newA.ID = "ctrlai" & i
    '            newA.TagName = "a"
    '            newA.InnerText = xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText
    '            newA.Attributes.Add("href", xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(2).InnerText)
    '            'newA.Attributes.Add("text", xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText)
    '            newA.Attributes.Add("target", "_blank")

    '            newLi.Controls.Add(newA)
    '        Next
    '    Catch ex As Exception
    '        '  Throw ex
    '        ex.Message.ToString()

    '    End Try

    'End Sub
    Protected Sub Bind_News()
        Try
            'Dim dtexists As New DataTable
            ' Dim objParameter As New cParameter(Ds)
            Dim objcmap As New cNews
            ' objParameter.CreateParameter(Ds, "@Flag", 1)
            ' objParameter.CreateParameter(Ds, "@prefixText", prefixText)
            'objcmap.GetDataSetForExists(dtexists, enmnews.news)

            'If dtexists.Rows.Count > 0 Then
            '    objcmap.DeleteAllNews("NewsTable", enmnews.news)
            'End If


            'Dim objServicePressRelase As New DigitalGujaratPressRelease.DigitalGujaratSoapClient

            'Dim Press As String
            'Press = objServicePressRelase.LatestPressReleases()

            'Dim drEntryPage As DataRow
            'dt = New DataTable
            ''Dim objParameter As New cParameter(dt, "NewsTable")
            'getTableColumn(dt, "NewsTable")

            'Dim ds As New DataSet
            'Dim xmldoc As New System.Xml.XmlDocument
            'xmldoc.LoadXml(Press)
            'For i As Integer = 0 To xmldoc.ChildNodes(0).ChildNodes.Count - 1
            '    Dim newLi As New HtmlGenericControl
            '    newLi.ID = "ctrlLi" & i
            '    newLi.TagName = "li"
            '    'c = i Mod 8
            '    'c += 1
            '    'newLi.Attributes.Add("class", "s" + c.ToString)
            '    PressGroup.Controls.Add(newLi)
            '    Dim newA As New HtmlGenericControl
            '    newA.ID = "ctrlai" & i
            '    newA.TagName = "a"
            '    newA.InnerText = xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText
            '    newA.Attributes.Add("href", xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(2).InnerText)
            '    'newA.Attributes.Add("text", xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText)
            '    newA.Attributes.Add("target", "_blank")


            '    Dim urlvar As String
            '    urlvar = xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(2).InnerText
            '    ' For inew As Integer = 0 To xmldoc.ChildNodes(1).ChildNodes.Count - 1


            '    'Dim objParameter As New cParameter(dsEntry, "NewsTable")
            '    'getTableColumn(dsEntry, "NewsTable")

            '    ' dt = New DataTable

            '    Dim drEntryPage As DataRow
            '    dt = New DataTable
            '    'Dim objParameter As New cParameter(dt, "NewsTable")
            '    getTableColumn(dt, "NewsTable")

            '    drEntryPage = dt.NewRow()
            '    With drEntryPage

            '        .Item("NewsTitle") = newA.InnerText

            '        .Item("NewsUrl") = urlvar

            '        .Item("IsActive") = True
            '    End With
            '    dt.Rows.Add(drEntryPage)
            '    Dim obj As New cNews
            '    obj.InsertNews(dt, enmnews.news)

            '    ' newLi.Controls.Add(newA)
            '    ' newLi.Controls.Add(newA)
            '    'Next
            'Next


            ' dtlink = New DataTable

            ' objcmap.GetDataSetForExists(dtlink, enmnews.news)

            dsEntry = New DataSet
            Dim objParameter As New cParameter(dsEntry)

            objcmap.GetDataSet(dsEntry, enmnews.news)

            'For Each drOutput As DataRow In dtlink.Rows
            '    Dim li As New HtmlGenericControl("li")
            '    'PressGroup.Controls.Add(li)
            '    Dim anchor As New HtmlGenericControl("a")
            '    anchor.Attributes.Add("href", "#")
            '    anchor.InnerText = Convert.ToString(drOutput("NewsTitle"))
            '    li.Controls.Add(anchor)
            Dim ul As New HtmlGenericControl("ul")

            'dtlink = New DataTable

            'objcmap.GetDataSetForExists(dtlink, enmnews.news)

            ' Dim ili As New HtmlGenericControl("li")
            For Each drOutputList As DataRow In dsEntry.Tables("newstable").Rows
                Dim ili As New HtmlGenericControl("li")

                ' ili.Controls.Clear()
                '            if (listItem != null)
                'this.hide.style.Add("display", "none");

                'ul.Controls.Add(ili)
                'PressGroup.Controls.Add(ili)
                Dim ianchor As New HtmlGenericControl("a")
                For Each dcOutputList As DataColumn In dsEntry.Tables("newstable").Columns
                    If dcOutputList.ColumnName.Contains("NewsUrl") Then
                        ul.Controls.Add(ili)
                        ianchor.Attributes.Add("href", Convert.ToString(drOutputList("NewsUrl")))
                        ianchor.Attributes.Add("target", "_blank")
                    End If
                Next
                ianchor.InnerText = Convert.ToString(drOutputList("NewsTitle"))

                'ianchor.Style.Add("list-style", "none")

                'ianchor.Attributes.Remove("ctl00_ContentPlaceHolder1_ctrlLi0")
                'ianchor.Attributes.Remove("ctl00_ContentPlaceHolder1_ctrlLi1")
                ili.Controls.Add(ianchor)

                PressGroup.Controls.Add(ili)

            Next


        Catch ex As Exception
            '  Throw ex
            ex.Message.ToString()

        End Try

    End Sub

    Private Sub getTableColumn(ByRef ds As DataTable, ByVal strTableName As String)
        With ds.Columns
            .Add("NewsId", System.Type.GetType("System.Int64"))
            .Add("NewsTitle", System.Type.GetType("System.String"))
            .Add("NewsUrl", System.Type.GetType("System.String"))
            .Add("IsActive", System.Type.GetType("System.Boolean"))

        End With
    End Sub

End Class