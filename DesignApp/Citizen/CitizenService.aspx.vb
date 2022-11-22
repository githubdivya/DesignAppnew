Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports LibReports
Imports System.IO
Public Class CitizenService
    Inherits cBaseForm
    Private dsEntry As DataSet
    Private objDropDown As cDropDown
    Private objCRUDLookup As cLookup

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dsEntry = New DataSet
        objDropDown = New cDropDown
        objCRUDLookup = New cLookup

        If Not IsPostBack Then
            lblservicecount.Text = Convert.ToString(My.Settings.ServiceCount)
            If (Convert.ToString(Session("txtMainSearch")) <> String.Empty) Then
                ViewState("keyword") = Convert.ToString(Session("txtMainSearch"))
                txtsearch.Text = Convert.ToString(Session("txtMainSearch"))
                Session("txtMainSearch") = String.Empty
            Else
                ViewState("keyword") = String.Empty
            End If
            bindservicegroup()
            If Not (Request.QueryString("id") Is Nothing) Then
                ID = Request.QueryString("id").ToString
                service_group.SelectedValue = 30
                ViewState("ServiceGroupID") = service_group.SelectedValue
                ViewState("keyword") = 1.ToString

            End If
        End If
        fillservice()

    End Sub
    Protected Sub bindservicegroup()
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", 3)
        objDropDown.GetDataSet(dsEntry, enmDropDown.ServiceGroup)
        If dsEntry.Tables("vService").Rows.Count > 0 Then
            service_group.DataSource = dsEntry.Tables("vService")
            service_group.Items.Clear()
            If Session("MyCulture") = "en-GB" Then
                service_group.DataTextField = "ServiceGroupName"
            Else
                service_group.DataTextField = "ServiceGroupName_g"
            End If
            service_group.DataValueField = "ServiceGroupID"
            service_group.DataBind()
            service_group.Items.Insert(0, New ListItem("Select", 0))
        End If
    End Sub
    Protected Sub fillservice()
        Dim cssFile As New Literal()
        Dim objParameter As New cParameter(dsEntry)
        If ViewState("keyword") = String.Empty Or ViewState("keyword") Is Nothing Then
            objParameter = New cParameter(dsEntry)
            
            objParameter.CreateParameter(dsEntry, "@Flag", 11)
            objDropDown.GetDataSet(dsEntry, enmDropDown.Service)
            service_list.Controls.Clear()
            Dim i As Integer = 0
            If dsEntry.Tables("vService").Rows.Count > 0 Then
                For i = 0 To dsEntry.Tables("vService").Rows.Count - 1
                    Dim newLi As New HtmlGenericControl
                    newLi.TagName = "div"
                    newLi.Attributes.Add("class", "col-md-4 col-sm-6")
                    service_list.Controls.Add(newLi)
                    Dim lk As New LinkButton()
                    lk.CommandArgument = dsEntry.Tables("vService").Rows(i).Item("ServiceID").ToString
                    lk.Text = dsEntry.Tables("vService").Rows(i).Item("ServiceName").ToString
                    'AddHandler lk.Click, AddressOf sercicelk_Click
                    newLi.Controls.Add(lk)
                    Dim newLi1 As New HtmlGenericControl
                    newLi1.TagName = "div"
                    newLi1.Attributes.Add("class", "serviceList")
                    lk.Controls.Add(newLi1)

                    Dim newLi2 As New HtmlGenericControl
                    newLi2.TagName = "div"
                    newLi2.Attributes.Add("class", "serviceName")
                    newLi1.Controls.Add(newLi2)

                    Dim newLi3 As New HtmlGenericControl
                    newLi3.TagName = "div"
                    newLi3.Attributes.Add("class", "serviceDetail")
                    newLi1.Controls.Add(newLi3)
                    Dim css As String
                    Dim strImage As String = "../images/" + dsEntry.Tables("vService").Rows(i).Item("image_path").ToString.Trim
                    '"../images/ration.png"
                    Dim strImagehover As String = "../images/" + dsEntry.Tables("vService").Rows(i).Item("hoverimage_path").ToString
                    '"../images/ration_hover.png"
                    css = "<style type='text/css'>" _
                        + ".onlineService .serviceList .serviceDetail .detailDes.service_image" + i.ToString + " {background:url('" + strImage + "') no-repeat left top; padding:30px 0px 31px 85px;}" _
                        + ".onlineService .serviceList:hover .serviceDetail .detailDes.service_image" + i.ToString + "{background:url('" + strImagehover + "') no-repeat left top; padding:30px 0px 31px 85px;}" _
                        + "</style>"
                    Page.Header.Controls.Add(New LiteralControl(css))
                    Dim hh4 As New HtmlGenericControl
                    hh4.TagName = "h3"
                    If Session("MyCulture") = "en-GB" Then
                        hh4.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceName").ToString
                    Else
                        hh4.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceNameGU").ToString
                    End If

                    newLi2.Controls.Add(hh4)
                    Dim serviceDetail As New HtmlGenericControl
                    serviceDetail.TagName = "div"
                    serviceDetail.Attributes.Add("class", "detailDes service_image" + i.ToString)

                    If Session("MyCulture") = "en-GB" Then
                        serviceDetail.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceDescription").ToString
                    Else
                        serviceDetail.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceDescriptionGU").ToString
                    End If
                    newLi3.Controls.Add(serviceDetail)
                    AddHandler lk.Click, AddressOf sercicelk_Click
                Next
            End If
        Else
            Dim keyword As String = txtsearch.Text
            dsEntry = New DataSet
            objParameter = New cParameter(dsEntry)
            If ViewState("ServiceGroupID") Is Nothing Then
                objParameter.CreateParameter(dsEntry, "Flag", 8)
                objParameter.CreateParameter(dsEntry, "keyword", Convert.ToString(ViewState("keyword")).Trim())
            Else
                objParameter.CreateParameter(dsEntry, "Flag", 12)
                objParameter.CreateParameter(dsEntry, "@ServiceGroupID", ViewState("ServiceGroupID").ToString)
            End If
            objDropDown.GetDataSet(dsEntry, enmDropDown.Service)
            Dim i As Integer = 0
            Dim c As Integer = 0
            Dim count As Integer = 5
            service_list.Controls.Clear()
            If dsEntry.Tables("vService").Rows.Count > 0 Then
                For i = 0 To dsEntry.Tables("vService").Rows.Count - 1
                    Dim newLi As New HtmlGenericControl
                    newLi.TagName = "div"
                    newLi.Attributes.Add("class", "col-md-4 col-sm-6")
                    service_list.Controls.Add(newLi)
                    Dim lk As New LinkButton()
                    lk.CommandArgument = dsEntry.Tables("vService").Rows(i).Item("ServiceID").ToString
                    lk.Text = ""
                    'AddHandler lk.Click, AddressOf sercicelk_Click
                    newLi.Controls.Add(lk)
                    Dim newLi1 As New HtmlGenericControl
                    newLi1.TagName = "div"
                    newLi1.Attributes.Add("class", "serviceList")
                    lk.Controls.Add(newLi1)

                    Dim newLi2 As New HtmlGenericControl
                    newLi2.TagName = "div"
                    newLi2.Attributes.Add("class", "serviceName")
                    newLi1.Controls.Add(newLi2)

                    Dim newLi3 As New HtmlGenericControl
                    newLi3.TagName = "div"
                    newLi3.Attributes.Add("class", "serviceDetail")
                    newLi1.Controls.Add(newLi3)
                    Dim css As String
                    Dim strImage As String = "../images/" + dsEntry.Tables("vService").Rows(i).Item("image_path").ToString.Trim
                    '"../images/ration.png"
                    Dim strImagehover As String = "../images/" + dsEntry.Tables("vService").Rows(i).Item("hoverimage_path").ToString
                    '"../images/ration_hover.png"
                    css = "<style type='text/css'>" _
                        + ".onlineService .serviceList .serviceDetail .detailDes.service_image" + i.ToString + "{background:url('" + strImage + "') no-repeat left top; padding:30px 0px 31px 85px;}" _
                        + ".onlineService .serviceList:hover .serviceDetail .detailDes.service_image" + i.ToString + "{background:url('" + strImagehover + "') no-repeat left top; padding:30px 0px 31px 85px;}" _
                        + "</style>"
                    Page.Header.Controls.Add(New LiteralControl(css))
                    Dim hh4 As New HtmlGenericControl
                    hh4.TagName = "h3"
                    If Session("MyCulture") = "en-GB" Then
                        hh4.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceName").ToString
                    Else
                        hh4.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceNameGU").ToString
                    End If

                    newLi2.Controls.Add(hh4)
                    Dim serviceDetail As New HtmlGenericControl
                    serviceDetail.TagName = "div"
                    serviceDetail.Attributes.Add("class", "detailDes service_image" + i.ToString)

                    If Session("MyCulture") = "en-GB" Then
                        serviceDetail.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceDescription").ToString
                    Else
                        serviceDetail.InnerText = dsEntry.Tables("vService").Rows(i).Item("ServiceDescriptionGU").ToString
                    End If
                    newLi3.Controls.Add(serviceDetail)
                    AddHandler lk.Click, AddressOf sercicelk_Click
                Next
            End If
        End If
    End Sub
    Private Sub go_ServerClick(sender As Object, e As EventArgs) Handles go.ServerClick
        ViewState("keyword") = txtsearch.Text
        ViewState("ServiceGroupID") = Nothing
        service_group.SelectedValue = 0
        fillservice()
    End Sub
    Protected Sub service_group_SelectedIndexChanged(sender As Object, e As EventArgs) Handles service_group.SelectedIndexChanged
        ViewState("ServiceGroupID") = service_group.SelectedValue
        ViewState("keyword") = 1.ToString
        txtsearch.Text = ""
        fillservice()
    End Sub
    Protected Sub sercicelk_Click(sender As Object, e As EventArgs)
        Dim lnk As LinkButton
        lnk = CType(sender, LinkButton)
        Session("ServiceID") = lnk.CommandArgument
        Session("ServiceName") = lnk.Text.Trim
        Response.Redirect("ServiceDescription.aspx")
    End Sub
End Class