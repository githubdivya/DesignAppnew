Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports LibReports
Imports System.IO
Public Class frmcertificates
    Inherits cBaseForm
    Private dsEntry As DataSet
    Private objDropDown As cDropDown
    Private objCRUDLookup As cLookup
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("ServiceGroupID") Is Nothing Then
            Response.Redirect("~/frmServiceGroup.aspx")
        Else
            dsEntry = New DataSet
            objDropDown = New cDropDown
            objCRUDLookup = New cLookup
            bindmenu()
            If Not IsPostBack Then
                Session("path") = Request.UrlReferrer.ToString
            End If
        End If
    End Sub
    Protected Sub bindmenu()
        dsEntry = New DataSet
        Session("Client_ServiceGroupID") = Nothing
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@ServiceGroupID", Session("ServiceGroupID").ToString)
        objDropDown.GetDataSet(dsEntry, enmDropDown.Service)
        Dim i As Integer = 0
        Dim c As Integer = 0
        If dsEntry.Tables("vService").Rows.Count > 0 Then
            For i = 0 To dsEntry.Tables("vService").Rows.Count - 1
                Dim newLi As New HtmlGenericControl
                newLi.ID = "ctrlLi" & i
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
                AddHandler lk.Click, AddressOf lnkservice_Click
                newLi.Controls.Add(lk)
                Dim lb2 As New LinkButton()
            Next
        End If
    End Sub
    Protected Sub lnkservice_Click(sender As Object, e As EventArgs)
        Dim lnk As LinkButton
        lnk = CType(sender, LinkButton)
        Session("ServiceID") = lnk.CommandArgument
        Response.Redirect("ServiceDescription.aspx")
        'Select Case lnk.CommandArgument
        '    Case 2
        '        Response.Redirect("frmApplyForService.aspx")
        '    Case 8
        '        Response.Redirect("frmShowRationCardServices.aspx")
        'End Select
    End Sub

    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs)
        Response.Redirect(Session("path"))
    End Sub
End Class