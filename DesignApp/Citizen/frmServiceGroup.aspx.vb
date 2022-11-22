Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports LibReports
Imports System.IO
Public Class frmServiceGroup
    Inherits cBaseForm
    Private dsEntry As DataSet
    Private objDropDown As cDropDown
    Private objCRUDLookup As cLookup

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dsEntry = New DataSet
        objDropDown = New cDropDown
        objCRUDLookup = New cLookup
        bindmenu()
        If Not IsPostBack Then
            Session("path") = Request.UrlReferrer.ToString
            bindservicegroup()
        End If
    End Sub
    Protected Sub bindservicegroup()
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", 3)
        objDropDown.GetDataSet(dsEntry, enmDropDown.ServiceGroup)
        If dsEntry.Tables("vService").Rows.Count > 0 Then
            service_group.DataSource = dsEntry.Tables("vService")
            service_group.Items.Clear()
            service_group.DataTextField = "ServiceGroupName"
            service_group.DataValueField = "ServiceGroupID"
            service_group.DataBind()
            service_group.Items.Insert(0, New ListItem("Select", 0))
        End If
    End Sub
    Protected Sub bindmenu()
        dsEntry = New DataSet
        If ViewState("keyword") Is Nothing Then
            Dim objParameter As New cParameter(dsEntry)
            objParameter.CreateParameter(dsEntry, "@Flag", 11)
            objDropDown.GetDataSet(dsEntry, enmDropDown.Service)
            ServiceGroup.Controls.Clear()
            ServiceSearch.Controls.Clear()
            Dim i As Integer = 0
            Dim c As Integer = 0
            Dim count As Integer = 5
            If dsEntry.Tables("vService").Rows.Count > 0 Then
                For i = 0 To dsEntry.Tables("vService").Rows.Count - 1
                    Dim newLi As New HtmlGenericControl
                    newLi.TagName = "li"
                    c = i Mod 8
                    c += 1
                    newLi.Attributes.Add("class", "s" + c.ToString)
                    ServiceGroup.Controls.Add(newLi)
                    Dim lk As New LinkButton()
                    lk.CommandArgument = dsEntry.Tables("vService").Rows(i).Item("ServiceID").ToString
                    If Session("MyCulture") = "en-GB" Then
                        lk.Text = dsEntry.Tables("vService").Rows(i).Item("ServiceNameGU").ToString
                    Else
                        lk.Text = dsEntry.Tables("vService").Rows(i).Item("ServiceName").ToString
                    End If
                    AddHandler lk.Click, AddressOf sercicelk_Click
                    newLi.Controls.Add(lk)
                    Dim lb2 As New LinkButton()
                Next
            End If
        Else
            Dim keyword As String = txtkeyword.Text
            dsEntry = New DataSet
            Dim objParameter As New cParameter(dsEntry)
            If ViewState("ServiceGroupID") Is Nothing Then
                objParameter.CreateParameter(dsEntry, "Flag", 8)
                objParameter.CreateParameter(dsEntry, "keyword", ViewState("keyword"))
            Else
                objParameter.CreateParameter(dsEntry, "Flag", 12)
                objParameter.CreateParameter(dsEntry, "@ServiceGroupID", ViewState("ServiceGroupID").ToString)
            End If
            objDropDown.GetDataSet(dsEntry, enmDropDown.Service)
            ServiceGroup.Controls.Clear()
            ServiceSearch.Controls.Clear()
            Dim i As Integer = 0
            Dim c As Integer = 0
            If dsEntry.Tables("vService").Rows.Count > 0 Then
                For i = 0 To dsEntry.Tables("vService").Rows.Count - 1
                    Dim newLi1 As New HtmlGenericControl
                    newLi1.TagName = "li"
                    c = i Mod 8
                    c += 1
                    newLi1.Attributes.Add("class", "s" + c.ToString)
                    ServiceSearch.Controls.Add(newLi1)
                    Dim lk1 As New LinkButton()
                    lk1.CommandArgument = dsEntry.Tables("vService").Rows(i).Item("ServiceID").ToString
                    If Session("MyCulture") = "en-GB" Then
                        lk1.Text = dsEntry.Tables("vService").Rows(i).Item("ServiceNameGU").ToString
                    Else
                        lk1.Text = dsEntry.Tables("vService").Rows(i).Item("ServiceName").ToString
                    End If
                    AddHandler lk1.Click, AddressOf sercicelk_Click
                    newLi1.Controls.Add(lk1)
                Next
            End If
        End If
    End Sub
    Protected Sub lnkservice_Click(sender As Object, e As EventArgs)
        Dim lnk As LinkButton
        lnk = CType(sender, LinkButton)
        Session("ServiceGroupID") = lnk.CommandArgument
        Response.Redirect("frmcertificates.aspx")
    End Sub

    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs)
        Response.Redirect(Session("path"))
    End Sub

    Protected Sub go_Click(sender As Object, e As EventArgs) Handles go.Click
        ViewState("keyword") = txtkeyword.Text
        ViewState("ServiceGroupID") = Nothing
        bindmenu()
        service_group.SelectedValue = 0
    End Sub
    Protected Sub sercicelk_Click(sender As Object, e As EventArgs)
        Dim lnk As LinkButton
        lnk = CType(sender, LinkButton)
        Session("ServiceID") = lnk.CommandArgument
        Response.Redirect("ServiceDescription.aspx")
    End Sub

    Protected Sub service_group_SelectedIndexChanged(sender As Object, e As EventArgs) Handles service_group.SelectedIndexChanged
        ViewState("ServiceGroupID") = service_group.SelectedValue
        ViewState("keyword") = 1.ToString
        bindmenu()
        txtkeyword.Text = ""
    End Sub
End Class