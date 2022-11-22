Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports LibReports
Imports System.IO
Public Class ServiceDescription
    Inherits cBaseForm
    Private dsEntry As DataSet
    Private objDropDown As cDropDown
    Private objCRUDLookup As cLookup
    Private objCRUD As cTReceipt_Citizen

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dsEntry = New DataSet
        objDropDown = New cDropDown
        objCRUDLookup = New cLookup
        objCRUD = New cTReceipt_Citizen

        If Request.QueryString("ServiceID") IsNot Nothing Then
            If Not IsNothing(Session("ServiceID")) OrElse Request.QueryString("ServiceID").ToString.Trim = "63" Or
               Request.QueryString("ServiceID").ToString.Trim = "64" Or
               Request.QueryString("ServiceID").ToString.Trim = "66" Or
               Request.QueryString("ServiceID").ToString.Trim = "82" Or
               Request.QueryString("ServiceID").ToString.Trim = "362" Or
               Request.QueryString("ServiceID").ToString.Trim = "66" Or
               Request.QueryString("ServiceID").ToString.Trim = "71" Or
               Request.QueryString("ServiceID").ToString.Trim = "77" Or
               Request.QueryString("ServiceID").ToString.Trim = "79" Or
               Request.QueryString("ServiceID").ToString.Trim = "309" Or
               Request.QueryString("ServiceID").ToString.Trim = "310" Or
               Request.QueryString("ServiceID").ToString.Trim = "307" Or
               Request.QueryString("ServiceID").ToString.Trim = "311" Or
               Request.QueryString("ServiceID").ToString.Trim = "308" Or
                Request.QueryString("ServiceID").ToString.Trim = "311" Or
               Request.QueryString("ServiceID").ToString.Trim = "606" Or
               Request.QueryString("ServiceID").ToString.Trim = "605" Then

                If Request.QueryString("ServiceID") IsNot Nothing Then
                    Session("ServiceID") = Request.QueryString("ServiceID").ToString
                End If


                dsEntry = New DataSet
                Dim objParameter As New cParameter(dsEntry)
                objParameter.CreateParameter(dsEntry, "@ServiceID", Session("ServiceID"), enmParameterType.Input, SqlDbType.Int)
                objParameter.CreateParameter(dsEntry, "@Flag", 14, enmParameterType.Input, SqlDbType.Int)
                objDropDown.GetDataSet(dsEntry, enmDropDown.Service)
                If dsEntry.Tables("vService").Rows.Count > 0 Then
                    If Session("MyCulture") = "en-GB" Then
                        Session("ServiceName") = dsEntry.Tables("vService").Rows(0).Item("ServiceNameGU").ToString
                    Else
                        Session("ServiceName") = dsEntry.Tables("vService").Rows(0).Item("ServiceName").ToString
                    End If
                End If


            Else
                Response.Redirect("~/Citizen/CitizenService.aspx")
            End If
        End If
        If Session("ServiceID") Is Nothing Then
            Response.Redirect("~/Citizen/CitizenService.aspx")
        Else


            'bindmenu()
            bindinstruction()
            getProof()
            If Not IsPostBack Then
                If IsNothing(Session("path")) Then
                Else
                    If Session("path").ToString.Trim <> "" Or Session("path").ToString.Trim <> String.Empty Then
                        Session("path") = Request.UrlReferrer.ToString
                    End If
                End If
            End If
        End If
        If Session("ServiceName").ToString.Trim <> "" Then
            servicename.Text = Session("ServiceName").ToString.Trim
        End If
        If Session("ServiceID").ToString.Trim = "523" Or Session("ServiceID").ToString.Trim = "524" Or Session("ServiceID").ToString.Trim = "525" Then
            download.Visible = False
        End If
    End Sub
    Private Sub getProof()
        dsEntry = New DataSet
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@ServiceID", Session("ServiceID").ToString, enmParameterType.Input, SqlDbType.Int)
        objParameter.CreateParameter(dsEntry, "@CultureInfo", Session("MyCulture").ToString, enmParameterType.Input, SqlDbType.Int)
        objDropDown.GetDataSet(dsEntry, enmDropDown.AttachDocumentGroupOnservice)

        If (dsEntry.Tables("AttachDocument1").Rows.Count > 0) Then
            lstAttachmentService.DataSource = dsEntry.Tables("AttachDocument1")

            divattachment.Visible = True
            If Session("MyCulture") = "en-GB" Then
                lstAttachmentService.DataTextField = "DocumentName"
                lstAttachmentService.DataValueField = "DocumentName"
            Else
                lstAttachmentService.DataTextField = "DocumentName_g"
                lstAttachmentService.DataValueField = "DocumentName_g"
            End If
            lstAttachmentService.DataBind()

        End If

        Grv_Proof_Group.DataSource = dsEntry.Tables("AttachDocument")
        Grv_Proof_Group.DataBind()

        'If Session("MyCulture") = "en-GB" Then
        '    lstAttachmentResidence.DataTextField = "DocumentName"
        '    lstAttachmentResidence.DataValueField = "DocumentName"
        'Else
        '    lstAttachmentResidence.DataTextField = "DocumentName_g"
        '    lstAttachmentResidence.DataValueField = "DocumentName_g"
        'End If

        'lstAttachmentResidence.DataBind()

        'lstAttachmentIdentity.DataSource = dsEntry.Tables("DocumentMaster1")
        'If Session("MyCulture") = "en-GB" Then
        '    lstAttachmentIdentity.DataTextField = "DocumentName"
        '    lstAttachmentIdentity.DataValueField = "DocumentName"
        'Else
        '    lstAttachmentIdentity.DataTextField = "DocumentName_g"
        '    lstAttachmentIdentity.DataValueField = "DocumentName_g"
        'End If

        'lstAttachmentIdentity.DataBind()


    End Sub
    Protected Sub Grv_Proof_Group_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles Grv_Proof_Group.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Then


            Dim blList As BulletedList = e.Row.FindControl("lstAttachmentGroup")
            dsEntry = New DataSet
            objCRUD = New cTReceipt_Citizen
            Dim objParameter1 As New cParameter(dsEntry)
            objParameter1 = New cParameter(dsEntry)
            objParameter1.CreateParameter(dsEntry, "@ServiceID", Session("ServiceID"), enmParameterType.Input, SqlDbType.Int)
            objParameter1.CreateParameter(dsEntry, "@CultureInfo", Session("MyCulture"))
            objParameter1.CreateParameter(dsEntry, "@AttachmentGroup", Grv_Proof_Group.DataKeys(e.Row.RowIndex).Values(0), enmParameterType.Input, SqlDbType.Int)

            objCRUD.GetDataSet(dsEntry, enmTReceiptCitizen.GetDocumentListForAttachGroup)

            blList.DataSource = dsEntry.Tables("Attchment")
            If Session("MyCulture") = "en-GB" Then
                blList.DataValueField = "DocumentID"
                blList.DataTextField = "DocumentName"
            Else
                blList.DataValueField = "DocumentID"
                blList.DataTextField = "DocumentName_g"
            End If
            blList.DataBind()


        End If
    End Sub

    Protected Sub bindmenu()
        dsEntry = New DataSet
        Session("Client_ServiceGroupID") = Nothing
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@ServiceID", Session("ServiceID").ToString)
        objDropDown.GetDataSet(dsEntry, enmDropDown.ServiceDescription)
        Dim i As Integer = 0

        If dsEntry.Tables("ServiceDescription").Rows.Count > 0 Then
            If Session("MyCulture") = "en-GB" Then
                servicename.Text = dsEntry.Tables("ServiceDescription").Rows(i).Item("ServiceName").ToString
                Session("ServiceName") = dsEntry.Tables("ServiceDescription").Rows(i).Item("ServiceName").ToString
                d1.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("Provision_E").ToString
                d2.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("WhoShouldApply_E").ToString
                d3.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("AuthorityToDispose_E").ToString
                d4.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("LimitForDisposal_E").ToString
                Session("ServiceURL") = dsEntry.Tables("ServiceDescription").Rows(i).Item("url").ToString
            Else
                servicename.Text = dsEntry.Tables("ServiceDescription").Rows(i).Item("ServiceNameGU").ToString
                Session("ServiceName") = dsEntry.Tables("ServiceDescription").Rows(i).Item("ServiceNameGU").ToString
                d1.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("Provision_G").ToString
                d2.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("WhoShouldApply_G").ToString
                d3.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("AuthorityToDispose_G").ToString
                d4.InnerText = dsEntry.Tables("ServiceDescription").Rows(i).Item("LimitForDisposal_G").ToString
                Session("ServiceURL") = dsEntry.Tables("ServiceDescription").Rows(i).Item("url").ToString
            End If

        End If
    End Sub
    Protected Sub bindinstruction()
        dsEntry = New DataSet
        Session("Client_ServiceGroupID") = Nothing
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@ServiceID", Session("ServiceID").ToString)
        objDropDown.GetDataSet(dsEntry, enmDropDown.ServiceInstruction)
        Dim i As Integer = 0
        If dsEntry.Tables("ServiceInstruction").Rows.Count > 0 Then
            For i = 0 To dsEntry.Tables("ServiceInstruction").Rows.Count - 1
                Dim newLi As New HtmlGenericControl
                newLi.ID = "ctrlLi" & i
                newLi.TagName = "li"
                newLi.Attributes.Add("style", "display: block; padding: 10px")
                ServiceGroup.Controls.Add(newLi)

                'Dim hh4 As New HtmlGenericControl
                'hh4.TagName = "h4"
                'If Session("MyCulture") = "en-GB" Then
                '    hh4.InnerText = dsEntry.Tables("ServiceInstruction").Rows(i).Item("InstructionEN").ToString
                'Else
                '    hh4.InnerText = dsEntry.Tables("ServiceInstruction").Rows(i).Item("InstructionGU").ToString
                'End If


                Dim lk As New Label()
                lk.Attributes.Add("class", "control-label")
                If Session("MyCulture") = "en-GB" Then
                    lk.Text = dsEntry.Tables("ServiceInstruction").Rows(i).Item("InstructionEN").ToString
                Else
                    lk.Text = dsEntry.Tables("ServiceInstruction").Rows(i).Item("InstructionGU").ToString

                End If
                newLi.Controls.Add(lk)

            Next
        End If
    End Sub
    Protected Sub saveURL()
        dsEntry = New DataSet
        Session("Client_ServiceGroupID") = Nothing
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@ServiceID", Session("ServiceID").ToString)
        objDropDown.GetDataSet(dsEntry, enmDropDown.ServiceDescription)
        Dim i As Integer = 0

        If dsEntry.Tables("ServiceDescription").Rows.Count > 0 Then
            Session("ServiceURL") = dsEntry.Tables("ServiceDescription").Rows(i).Item("url").ToString
        End If
    End Sub
    Protected Sub apply_Click(sender As Object, e As EventArgs) Handles apply.Click
        If Session("ServiceID") = 701 Then
            saveURL()
            Response.Redirect(Session("ServiceURL"))
        Else
            Response.Redirect(My.Settings.service_url.ToString + "?ServiceID=" + Session("ServiceID") + "&Cul=" + Session("MyCulture"))
        End If

    End Sub

    Protected Sub download_Click(sender As Object, e As EventArgs) Handles download.Click
        Dim url As String = My.Settings.dounload_url.ToString + "s" + Session("ServiceID") + ".pdf"
        ClientScript.RegisterStartupScript(GetType(String), "", "<script>window.open('" + url + "','','toolbar=no,resizable=yes,scrollbars=yes')</script>")
        ' Response.Redirect(My.Settings.dounload_url.ToString + "s" + Session("ServiceID") + ".pdf")
    End Sub

    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs)
        Response.Redirect(Session("path"))
    End Sub
End Class