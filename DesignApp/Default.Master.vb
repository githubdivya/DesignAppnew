'Imports System.Security.Cryptography
Imports NIC.LibApp
Imports LibReports

Public Class _Default
    Inherits System.Web.UI.MasterPage
    Private dsEntry As DataSet
    Private objcmap As cMap

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dsEntry = New DataSet
        objcmap = New cMap
        lblCount.Text = Application("counter").ToString()
        lblVersion.Text = Application("version").ToString()
        lblLastUpdated.Text = Application("LastUpdatedDate").ToString()
        'Dim hostname = Net.Dns.GetHostName
        'Me.Page.Title = hostname
        Dim strHostName As String = ""
        strHostName = (Net.Dns.GetHostName.ToUpper.Replace("DIGIGUJ-VM", "")).Trim
        If Net.Dns.GetHostName.ToUpper.Contains("WEB") = True Then
            strHostName = (Net.Dns.GetHostName.ToUpper.Replace("CLD-DGUJ-WEB", "")).Trim
            strHostName = CType(strHostName, Int32) + 10

        End If
        If IsNumeric(strHostName) Then
            strHostName = cGlobal.GETVMname(CType(strHostName, Int32))
        End If

        'Net.Dns.GetHostName.Replace("DigiGuj", enmName.GETVMname)
        'Dim hostname As String = cGlobal.GETVMname(CType(Net.Dns.GetHostName.ToUpper.Replace("DIGIGUJ-VM", "").Trim, Int32)) 'Net.Dns.GetHostName.Replace("DigiGuj", enmName.GETVMname)
        Me.Page.Title = strHostName
        If Not IsPostBack Then

            If IsNothing(Session("MyCulture")) Then
                Session("MyCulture") = "en-GB"
            ElseIf Session("MyCulture") = "en-GB" Then

                en.Attributes.Add("class", "active")
            ElseIf Session("MyCulture") = "gu-IN" Then

                gu.Attributes.Add("class", "active")
            End If
            'BindLocation()
            'If (Session("City") <> Nothing) Then
            '    If (Session("City").ToString <> "") Then
            '        lbllocation.Text = Session("City")
            '    End If
            'End If
            '  Bind_City()

        End If

        'If Session("hostID") <> GenerateHashKey() Then
        '    Response.Redirect("~/ErrorPage.aspx")
        'End If
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
    '    If (dr.Count > 0) Then
    '        ' Dim lbllocationbutton As LinkButton = DirectCast(Master.FindControl("lnkchangecity"), LinkButton)

    '        ' Dim lbllocation1 As Label = DirectCast(Master.FindControl("lbllocation"), Label)
    '        ' lbllocationbutton.Visible = True
    '        '  lbllocation1.Text = Convert.ToString(txtSearchCity.Text.ToString())
    '        'Me.MasterPageFile.GetType.InvokeMember("BindLocation", System.Reflection.BindingFlags.InvokeMethod, Nothing, Me.Page, Nothing)
    '        Dim Str As New StringBuilder
    '        'Str.Append(" <script>")
    '        'lblOfficeName.Text = Convert.ToString(dr(0).Item("OfficeName_E"))
    '        'lblofficeAddress.Text = IIf(Convert.ToString(dr(0).Item("Office_Address")) = "", " ", Convert.ToString(dr(0).Item("Office_Address")))
    '        'lblOfficecontactno.Text = IIf(Convert.ToString(dr(0).Item("Office_ContactNo")) = "", " ", Convert.ToString(dr(0).Item("Office_ContactNo")))
    '        'lblofficeFaxno.Text = IIf(Convert.ToString(dr(0).Item("Office_FaxNo")) = "", " ", Convert.ToString(dr(0).Item("Office_FaxNo")))
    '        'lblofficeEmail.Text = IIf(Convert.ToString(dr(0).Item("Office_EmailID")) = "", " ", Convert.ToString(dr(0).Item("Office_EmailID")))

    '        '    Str.Append("function initMap() {")
    '        '    Str.Append("var myLatLng = {lat: " + Convert.ToString(dr(0).Item("lat")) + ", lng:  " + Convert.ToString(dr(0).Item("lng")) + "};")

    '        '    Str.Append(" var map = new google.maps.Map(document.getElementById('map'), {")
    '        '    Str.Append(" zoom: 14,")
    '        '    Str.Append("center: myLatLng")
    '        '    Str.Append("});")
    '        '    Str.Append("var marker;")

    '        '    Dim i As Integer
    '        '    For i = 0 To dr.Count - 1
    '        '        Str.Append("myLatLng = { lat: " + Convert.ToString(dr(i).Item("lat")) + ", lng: " + Convert.ToString(dr(i).Item("lng")) + " };")
    '        '        Str.Append("marker = new google.maps.Marker({")
    '        '        Str.Append("position: myLatLng,")
    '        '        Str.Append("map:    map,")
    '        '        Str.Append("Title: '" + Convert.ToString(dr(0).Item("OfficeName_E")) + "'")
    '        '        Str.Append("});")
    '        '    Next
    '        '    Str.Append("}")


    '        '    Dim gc As New HtmlGenericControl

    '        '    gc.TagName = "script"
    '        '    gc.Attributes.Add("type", "text/javascript")
    '        '    gc.InnerHtml = Str.ToString()

    '        '    Page.Header.Controls.Add(gc)

    '        '    Dim gc1 As New HtmlGenericControl

    '        '    gc1.TagName = "script"
    '        '    gc1.Attributes.Add("type", "text/javascript")
    '        '    gc1.Attributes.Add("src", "https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap")
    '        '    Page.Controls.Add(gc1)

    '        '    ' <script async defer
    '        '    'src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap"></script>

    '        '    ' ModalPopupselectCity.Hide()
    '        'Else
    '        '    Bind_City()
    '        '    ' ModalPopupselectCity.Show()
    '        'End If
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

    'Private Function GenerateHashKey() As String
    '    Dim myStr As New StringBuilder()
    '    myStr.Append(Request.Browser.Browser)
    '    myStr.Append(Request.Browser.Platform)
    '    myStr.Append(Request.Browser.MajorVersion)
    '    myStr.Append(Request.Browser.MinorVersion)
    '    myStr.Append(Request.UserHostAddress)
    '    'myStr.Append(Request.LogonUserIdentity.User.Value);
    '    Dim sha As SHA1 = New SHA1CryptoServiceProvider()
    '    Dim hashdata As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(myStr.ToString()))
    '    Return Convert.ToBase64String(hashdata)
    'End Function

    'Public Sub BindLocation()
    '    If Request.Cookies("Preferences") Is Nothing Then

    '    Else
    '        lbllocation.Text = Convert.ToString(Session("City"))
    '    End If


    'End Sub




    Protected Sub en_Click(sender As Object, e As EventArgs) Handles en.Click

        Session("MyCulture") = "en-GB"

        Context.Server.Transfer(Context.Request.Path)
    End Sub

    Protected Sub gu_Click(sender As Object, e As EventArgs) Handles gu.Click
        Session("MyCulture") = "gu-IN"

        Context.Server.Transfer(Context.Request.Path)
    End Sub

    Protected Sub lnkchangecity_Click(sender As Object, e As EventArgs) Handles lnkchangecity.Click
        Response.Redirect("~/DisplayOffice.aspx")

        '  Response.Cookies("Preferences").Expires = Now
        ' Response.Redirect("~/frmMain.aspx")

        ' TryCast(ContentPlaceHolder1.Page, frmMain).call1()

        '  ModalPopupselectCity.Show()
        ' Page_Load(sender, e)
    End Sub

    Protected Sub lnk_Click(sender As Object, e As EventArgs)
        'Dim lnk As LinkButton
        'lnk = CType(sender, LinkButton)
        'Dim Ds As DataSet
        'Ds = CType(ViewState("City"), DataSet)
        'Dim dr As DataRow()
        'Dim cookie As HttpCookie = Request.Cookies("Preferences")
        'If cookie Is Nothing Then
        '    cookie = New HttpCookie("Preferences")
        '    cookie("Name") = lnk.Text.ToString()
        '    cookie.Expires = DateTime.Now.AddMonths(1)
        '    Response.Cookies.Add(cookie)
        '    If (Session("MyCulture") = "en-GB") Then
        '        dr = Ds.Tables("City1").Select("CityName='" & lnk.Text.ToString() & "'")
        '        Session("City") = lnk.Text
        '    Else
        '        If Ds.Tables("City1").Columns.Contains("CityNameG") Then
        '            dr = Ds.Tables("City1").Select("CityNameG='" & lnk.Text.ToString() & "'")
        '            Session("City") = lnk.Text
        '        Else
        '            dr = Ds.Tables("City1").Select("CityName='" & lnk.Text.ToString() & "'")
        '            Session("City") = lnk.Text
        '        End If

        '    End If
        'Else
        '    If (Session("MyCulture") = "en-GB") Then
        '        If Ds.Tables("City1").Columns.Contains("CityNameG") Then
        '            dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "' OR CityNameG='" & cookie("Name") & "'")
        '            Session("City") = cookie("Name")
        '        Else
        '            dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")
        '            Session("City") = cookie("Name")
        '        End If

        '    Else
        '        If Ds.Tables("City1").Columns.Contains("CityNameG") Then
        '            dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "' OR CityNameG='" & cookie("Name") & "'")
        '            Session("City") = cookie("Name")
        '        Else
        '            dr = Ds.Tables("City1").Select("CityName='" & cookie("Name") & "'")
        '            Session("City") = cookie("Name")
        '        End If

        '    End If
        'End If
        'If dr.Length <= 0 Then
        '    Exit Sub
        'End If
        '' Dim lbllocationbutton As LinkButton = DirectCast(Master.FindControl("lnkchangecity"), LinkButton)
        ''dr = Ds.Tables("City1").Select("CityName='" & lnk.Text.ToString() & "'")
        ''Session("City") = lnk.Text.ToString()
        ''  Dim lbllocation1 As Label = DirectCast(Master.FindControl("lbllocation"), Label)
        'lbllocation.Text = Convert.ToString(lnk.Text.ToString())
        'lnkchangecity.Visible = True
        ''Me.MasterPageFile.GetType.InvokeMember("BindLocation", System.Reflection.BindingFlags.InvokeMethod, Nothing, Me.Page, Nothing)
        'Dim Str As New StringBuilder
        ''Str.Append(" <script>")


        'Dim lblOfficeName As Label = DirectCast(ContentPlaceHolder1.FindControl("lblOfficeName"), Label)
        'Dim lblofficeAddress As Label = DirectCast(ContentPlaceHolder1.FindControl("lblofficeAddress"), Label)
        'Dim lblOfficecontactno As Label = DirectCast(ContentPlaceHolder1.FindControl("lblOfficecontactno"), Label)
        'Dim lblofficeFaxno As Label = DirectCast(ContentPlaceHolder1.FindControl("lblofficeFaxno"), Label)
        'Dim lblofficeEmail As Label = DirectCast(ContentPlaceHolder1.FindControl("lblofficeEmail"), Label)

        'lblOfficeName.Text = Convert.ToString(dr(0).Item("OfficeName_E"))
        'lblofficeAddress.Text = IIf(Convert.ToString(dr(0).Item("Office_Address")) = "", " ", Convert.ToString(dr(0).Item("Office_Address")))
        'lblOfficecontactno.Text = IIf(Convert.ToString(dr(0).Item("Office_ContactNo")) = "", " ", Convert.ToString(dr(0).Item("Office_ContactNo")))
        'lblofficeFaxno.Text = IIf(Convert.ToString(dr(0).Item("Office_FaxNo")) = "", " ", Convert.ToString(dr(0).Item("Office_FaxNo")))
        'lblofficeEmail.Text = IIf(Convert.ToString(dr(0).Item("Office_EmailID")) = "", " ", Convert.ToString(dr(0).Item("Office_EmailID")))

        'Str.Append("function initMap() {")
        'Str.Append("var myLatLng = {lat: " + Convert.ToString(dr(0).Item("lat")) + ", lng:  " + Convert.ToString(dr(0).Item("lng")) + "};")

        'Str.Append(" var map = new google.maps.Map(document.getElementById('map'), {")
        'Str.Append(" zoom: 14,")
        'Str.Append("center: myLatLng")
        'Str.Append("});")
        'Str.Append("var marker;")

        'Dim i As Integer
        'For i = 0 To dr.Count - 1
        '    Str.Append("myLatLng = { lat: " + Convert.ToString(dr(i).Item("lat")) + ", lng: " + Convert.ToString(dr(i).Item("lng")) + " };")
        '    Str.Append("marker = new google.maps.Marker({")
        '    Str.Append("position: myLatLng,")
        '    Str.Append("map:    map,")
        '    Str.Append("Title: '" + Convert.ToString(dr(0).Item("OfficeName_E")) + "'")
        '    Str.Append("});")
        'Next
        'Str.Append("}")


        'Dim gc As New HtmlGenericControl

        'gc.TagName = "script"
        'gc.Attributes.Add("type", "text/javascript")
        'gc.InnerHtml = Str.ToString()

        'Page.Header.Controls.Add(gc)

        'Dim gc1 As New HtmlGenericControl

        'gc1.TagName = "script"
        'gc1.Attributes.Add("type", "text/javascript")
        'gc1.Attributes.Add("src", "https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap")
        'Page.Controls.Add(gc1)

        '' <script async defer
        ''src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBHYj1wMBJv3WQ8_8fA9IPvWHMutxbgYzk&signed_in=true&callback=initMap"></script>

        'ModalPopupselectCity.Hide()

        'code added on 07-01-2016

        Dim lnk As LinkButton
        lnk = CType(sender, LinkButton)
        Dim item = DirectCast(lnk.NamingContainer, DataListItem)
        Dim hiddenCompanyID = DirectCast(item.FindControl("dlOfficeID"), HiddenField)
        Dim Ds As DataSet
        Ds = New DataSet
        Dim objParameter As New cParameter(Ds)
        objParameter.CreateParameter(Ds, "@Flag", 4)
        objParameter.CreateParameter(Ds, "@OfficeID", hiddenCompanyID.Value, enmParameterType.Input, SqlDbType.Char)
        objcmap.GetDataSet(Ds, enmcMap.get_lat_lng)


        'Ds = CType(ViewState("City"), DataSet)
        Dim dr As DataRow
        Dim cookie As HttpCookie = Request.Cookies("Preferences")
        If cookie Is Nothing Then
            cookie = New HttpCookie("Preferences")
            cookie("Name") = lnk.Text.ToString()
            cookie.Expires = DateTime.Now.AddMonths(1)
            Response.Cookies.Add(cookie)
            If (Session("MyCulture") = "en-GB") Then
                dr = Ds.Tables("City").Rows(0)
                Session("City") = lnk.Text
            Else
                If Ds.Tables("City").Columns.Contains("CityNameG") Then
                    dr = Ds.Tables("City").Rows(0)
                    Session("City") = lnk.Text
                Else
                    dr = Ds.Tables("City").Rows(0)
                    Session("City") = lnk.Text
                End If

            End If
        Else
            If (Session("MyCulture") = "en-GB") Then
                If Ds.Tables("City").Columns.Contains("CityName") Then
                    dr = Ds.Tables("City").Rows(0)

                    Session("City") = dr.Item("CityName")


                Else
                    dr = Ds.Tables("City").Rows(0)
                    Session("City") = dr.Item("CityNameG")
                End If

            Else
                If Ds.Tables("City").Columns.Contains("CityNameG") Then
                    dr = Ds.Tables("City").Rows(0)
                    Session("City") = dr.Item("CityNameG")
                Else
                    dr = Ds.Tables("City").Rows(0)
                    Session("City") = dr.Item("CityName")
                End If

            End If
        End If

        If IsNothing(dr) Then
            Exit Sub
        End If
        ' Dim lbllocationbutton As LinkButton = DirectCast(Master.FindControl("lnkchangecity"), LinkButton)
        'dr = Ds.Tables("City1").Select("CityName='" & lnk.Text.ToString() & "'")
        'Session("City") = lnk.Text.ToString()
        '  Dim lbllocation1 As Label = DirectCast(Master.FindControl("lbllocation"), Label)
        'lbllocation.Text = Convert.ToString(lnk.Text.ToString())
        'lnkchangecity.Visible = True
        'Me.MasterPageFile.GetType.InvokeMember("BindLocation", System.Reflection.BindingFlags.InvokeMethod, Nothing, Me.Page, Nothing)
        Dim Str As New StringBuilder
        'Str.Append(" <script>")


        Dim lblOfficeName As Label = DirectCast(ContentPlaceHolder1.FindControl("lblOfficeName"), Label)
        Dim lblofficeAddress As Label = DirectCast(ContentPlaceHolder1.FindControl("lblofficeAddress"), Label)
        Dim lblOfficecontactno As Label = DirectCast(ContentPlaceHolder1.FindControl("lblOfficecontactno"), Label)
        Dim lblofficeFaxno As Label = DirectCast(ContentPlaceHolder1.FindControl("lblofficeFaxno"), Label)
        Dim lblofficeEmail As Label = DirectCast(ContentPlaceHolder1.FindControl("lblofficeEmail"), Label)

        lblOfficeName.Text = Convert.ToString(dr.Item("OfficeName_E"))
        lblofficeAddress.Text = IIf(Convert.ToString(dr.Item("Office_Address")) = "", " ", Convert.ToString(dr.Item("Office_Address")))
        lblOfficecontactno.Text = IIf(Convert.ToString(dr.Item("Office_ContactNo")) = "", " ", Convert.ToString(dr.Item("Office_ContactNo")))
        lblofficeFaxno.Text = IIf(Convert.ToString(dr.Item("Office_FaxNo")) = "", " ", Convert.ToString(dr.Item("Office_FaxNo")))
        lblofficeEmail.Text = IIf(Convert.ToString(dr.Item("Office_EmailID")) = "", " ", Convert.ToString(dr.Item("Office_EmailID")))

        Str.Append("function initMap() {")
        Str.Append("var myLatLng = {lat: " + Convert.ToString(dr.Item("lat")) + ", lng:  " + Convert.ToString(dr.Item("lng")) + "};")

        Str.Append(" var map = new google.maps.Map(document.getElementById('map'), {")
        Str.Append(" zoom: 14,")
        Str.Append("center: myLatLng")
        Str.Append("});")
        Str.Append("var marker;")

        Dim i As Integer = 0

        Str.Append("myLatLng = { lat: " + Convert.ToString(dr.Item("lat")) + ", lng: " + Convert.ToString(dr.Item("lng")) + " };")
        Str.Append("marker = new google.maps.Marker({")
        Str.Append("position: myLatLng,")
        Str.Append("map:    map,")
        Str.Append("Title: '" + Convert.ToString(dr.Item("OfficeName_E")) + "'")
        Str.Append("});")

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

        'ModalPopupselectCity.Hide()
        '

        'end of code



    End Sub
    Protected Sub lnklogin_Click(sender As Object, e As EventArgs) Handles lnklogin.Click
        Response.Redirect(My.Settings.LoginURL)
    End Sub
End Class