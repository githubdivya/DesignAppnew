
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmTReceiptCitizen
    TReceipt = 1
    Receiptddl = 2
    TReceiptFindfrm63 = 8
    TReceiptFind = 4
    TReceiptPending = 5
    TReceiptCertiID = 6
    TReceipt_Remarks = 7
    TReceiptPendingatOperaterWihQuery = 8
    TReceiptFindCitizen = 10
    Citizen_Document_Attachment_List = 11
    Citizen_Document_On_Attach_Group = 12
    Donwload_File = 13
    Citizen_Document_Attachment_List_Office = 14
    Citizen_Document_On_Attach_Group_Office = 15
    Donwload_File_Office = 16
    Document_Upload_Citizen = 17
    GetAlreadyUploadDocumentProof_Residence = 18
    GetAlreadyUploadDocumentProof_Indentity = 19
    Download_File_Select_sign = 20
    Donwload_File_Signed = 21
    GetDocumentListForAttachGroup = 22
    GetAlreadyUploadDocumentProof_AttGrp = 23
    ShowCount = 25
    ShowLink = 26

End Enum
Public Class cTReceipt_Citizen
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            Select Case CType(index, enmTReceiptCitizen)
                Case enmTReceiptCitizen.ShowCount
                    objDataExecute.getDataSet(ds, "ShowCountinDesignApp", objColCriteria, "Receipt", Nothing)
                Case enmTReceiptCitizen.ShowLink
                    objDataExecute.getDataSet(ds, "ShowLinkinDesignApp", objColCriteria, "Receipt", Nothing)

                Case enmTReceiptCitizen.Receiptddl
                    objDataExecute.getDataSet(ds, "T_Receipt_SelectApplno_citizen", objColCriteria, "Receipt", Nothing)
                Case enmTReceiptCitizen.TReceiptFindCitizen
                    objDataExecute.getDataSet(ds, "T_Receipt_Find_Citizen", objColCriteria, "Receipt", Nothing)
                Case enmTReceiptCitizen.TReceiptPending
                    objDataExecute.getDataSet(ds, "T_Receipt_Pending_Citizen", objColCriteria, "Receipt", Nothing)
                Case enmTReceiptCitizen.TReceiptCertiID
                    objDataExecute.getDataSet(ds, "T_Receipt_CertiID_Find", objColCriteria, "Receipt", Nothing)
                Case enmTReceiptCitizen.TReceipt_Remarks
                    objDataExecute.getDataSet(ds, "T_Receipt_Remarks_Find", objColCriteria, "Receipt", Nothing)
                Case enmTReceiptCitizen.TReceiptPendingatOperaterWihQuery
                    objDataExecute.getDataSet(ds, "T_Receipt_Pending_Operater_With_Query", objColCriteria, "Receipt", Nothing)
                Case enmTReceiptCitizen.Citizen_Document_Attachment_List
                    objDataExecute.getDataSet(ds, "Citizen_Servicewise_Attachment_List", objColCriteria, "AttachmentList", Nothing)
                Case enmTReceiptCitizen.Citizen_Document_On_Attach_Group
                    objDataExecute.getDataSet(ds, "Citizen_ServicewiseDocument_On_Attach_Group", objColCriteria, "AttachmentList", Nothing)
                Case enmTReceiptCitizen.Donwload_File
                    objDataExecute.getDataSet(ds, "Download_File_Select", objColCriteria, "Download", Nothing)
                Case enmTReceiptCitizen.Donwload_File_Signed
                    objDataExecute.getDataSet(ds, "Download_File_Select_afterSign", objColCriteria, "Download_Signed", Nothing)
                Case enmTReceiptCitizen.Citizen_Document_Attachment_List_Office
                    objDataExecute.getDataSet(ds, "Citizen_Servicewise_Attachment_List_Office", objColCriteria, "AttachmentList", Nothing)
                Case enmTReceiptCitizen.Citizen_Document_On_Attach_Group_Office
                    objDataExecute.getDataSet(ds, "Citizen_ServicewiseDocument_On_Attach_Group_Office", objColCriteria, "AttachmentList", Nothing)
                Case enmTReceiptCitizen.Donwload_File_Office
                    objDataExecute.getDataSet(ds, "Download_File_Select", objColCriteria, "Download", Nothing)
                Case enmTReceiptCitizen.Document_Upload_Citizen
                    objDataExecute.getDataSet(ds, "Document_Upload_Citizen_Select", objColCriteria, "Document_Upload", Nothing)
                Case enmTReceiptCitizen.GetAlreadyUploadDocumentProof_Residence
                    objDataExecute.getDataSet(ds, "GetAlreadyUploadDocumentProof_Residence_Citizen", objColCriteria, "Document_Upload", Nothing)
                Case enmTReceiptCitizen.GetAlreadyUploadDocumentProof_Indentity
                    objDataExecute.getDataSet(ds, "GetAlreadyUploadDocumentProof_Indentity_Citizen", objColCriteria, "Document_Upload", Nothing)
                Case enmTReceiptCitizen.Download_File_Select_sign
                    objDataExecute.getDataSet(ds, "Download_File_Select_sign", objColCriteria, "Download", Nothing)
                Case enmTReceiptCitizen.GetDocumentListForAttachGroup
                    objDataExecute.getDataSet(ds, "GetDocumentListForAttachGroup", objColCriteria, "Attchment", Nothing)
                Case enmTReceiptCitizen.GetAlreadyUploadDocumentProof_AttGrp
                    objDataExecute.getDataSet(ds, "GetAlreadyUploadDocumentProof_AttGrp_Citizen", objColCriteria, "Document_Upload", Nothing)


            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        'Try
        '    Dim objColCriteria As New Collection
        '    CreateParameter(ds.Tables("T_Receipt"), objColCriteria, enmParameterMode.Update)
        '    objDataExecute.Insert("T_Receipt_Update", objColCriteria, "T_Receipt", Nothing)
        'Catch ex As Exception
        '    Throw ex
        'End Try
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.Insert("Update_Close_Status", objColCriteria, "T_Receipt", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Upload_Document(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

        Try
            Dim objColCriteria As New Collection
            CreateParameter_Document(ds.Tables("Citizen_Document"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("T_Attachment_Uploaded_Document_Insert_Citizen", objColCriteria, "Citizen_Document", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Upload_Document_Citizen(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

        Try
            Dim objColCriteria As New Collection
            CreateParameter_Document_Upload_Citizen(ds.Tables("Citizen_Document"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("Citizen_Document_Upload_Insert", objColCriteria, "Citizen_Document", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Upload_Document_Office(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

        Try
            Dim objColCriteria As New Collection
            CreateParameter_Document_Office(ds.Tables("Citizen_Document"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("T_Attachment_Uploaded_Document_Insert_Citizen", objColCriteria, "Citizen_Document", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub UpdateClose(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.Insert("Update_Close_Status", objColCriteria, "T_Receipt", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Delete_Citizen_Upload_Document(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.Insert("Document_Upload_Citizen_Delete", objColCriteria, "T_Receipt", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("DISTRICTID", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "DISTRICTID", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("T_Receipt_Delete", objColCriteria, "T_Receipt", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Try
            Dim result As Integer = 0
            Dim AppliID As String = ""
            Dim FinalResult As String = ""
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("T_Receipt_Citizen"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("T_Receipt_Insert_Citizen", objColCriteria, "T_Receipt_Citizen", Nothing)

            result = objColCriteria(1).Value
            AppliID = objColCriteria(2).Value()
            FinalResult = result & "#" & AppliID
            Return FinalResult
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Overridable Sub Update_Citizen_Details(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("T_Receipt_Citizen"), objColCriteria, enmParameterMode.Update)
            objDataExecute.Insert("T_Receipt_Update_Citizen", objColCriteria, "T_Receipt_Citizen", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub CreateParameter_Document(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            objColCriteria.Add(New SqlParameter("ServiceID", .Item("ServiceID")))
            objColCriteria.Add(New SqlParameter("Citizen_UserID", .Item("Citizen_UserID")))
            objColCriteria.Add(New SqlParameter("CertificateID", .Item("CertificateID")))
            objColCriteria.Add(New SqlParameter("AttachementGroupID", .Item("AttachementGroupID")))
            objColCriteria.Add(New SqlParameter("DocumentID", .Item("DocumentID")))
            objColCriteria.Add(New SqlParameter("SelectFromDB", .Item("SelectFromDB")))
            objColCriteria.Add(New SqlParameter("DcoumentType", .Item("DcoumentType")))
            objColCriteria.Add(New SqlParameter("DocumentNumber", .Item("DocumentNumber")))
            objColCriteria.Add(New SqlParameter("IsVerify", .Item("IsVerify")))
            If IsDBNull(.Item("File")) = False Then
                objColCriteria.Add(New SqlParameter("File", .Item("File")))
            End If
            objColCriteria.Add(New SqlParameter("IsDeleted", .Item("IsDeleted")))

        End With
    End Sub

    Private Sub CreateParameter_Document_Upload_Citizen(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)

            objColCriteria.Add(New SqlParameter("Citizen_UserID", .Item("Citizen_UserID")))
            objColCriteria.Add(New SqlParameter("DocumentID", .Item("DocumentID")))
            objColCriteria.Add(New SqlParameter("DocumentType", .Item("DocumentType")))
            objColCriteria.Add(New SqlParameter("DocumentNumber", .Item("DocumentNumber")))
            If IsDBNull(.Item("File")) = False Then
                objColCriteria.Add(New SqlParameter("DocumentUploadedFile", .Item("File")))
            End If

        End With
    End Sub

    Private Sub CreateParameter_Document_Office(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            objColCriteria.Add(New SqlParameter("ServiceID", .Item("ServiceID")))
            objColCriteria.Add(New SqlParameter("Office_UserID", .Item("Office_UserID")))
            objColCriteria.Add(New SqlParameter("CertificateID", .Item("CertificateID")))
            objColCriteria.Add(New SqlParameter("AttachementGroupID", .Item("AttachementGroupID")))
            objColCriteria.Add(New SqlParameter("DocumentID", .Item("DocumentID")))
            objColCriteria.Add(New SqlParameter("SelectFromDB", .Item("SelectFromDB")))
            objColCriteria.Add(New SqlParameter("DcoumentType", .Item("DcoumentType")))
            objColCriteria.Add(New SqlParameter("DocumentNumber", .Item("DocumentNumber")))
            objColCriteria.Add(New SqlParameter("IsVerify", .Item("IsVerify")))
            If IsDBNull(.Item("File")) = False Then
                objColCriteria.Add(New SqlParameter("File", .Item("File")))
            End If

        End With
    End Sub

    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("APPLNO", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "APPLNO", DataRowVersion.Default, DBNull.Value))
                    objColCriteria.Add(New SqlParameter("CertificateID", SqlDbType.VarChar, 38, ParameterDirection.InputOutput, True, 38, 0, "CertificateID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    'objColCriteria.Add(New SqlParameter("APPLNO", SqlDbType.Int, 4, ParameterDirection.Input, False, 4, 0, "APPLNO", DataRowVersion.Default, .Item("APPLNO")))
                    objColCriteria.Add(New SqlParameter("ApplNo", .Item("ApplNo")))
                    objColCriteria.Add(New SqlParameter("Salute", .Item("Salute")))
                    objColCriteria.Add(New SqlParameter("ApplName", .Item("ApplName")))
                    objColCriteria.Add(New SqlParameter("ApplSurName", .Item("ApplSurName")))
                    objColCriteria.Add(New SqlParameter("ApplFatherName", .Item("ApplFatherName")))
                    objColCriteria.Add(New SqlParameter("Appladdress", .Item("Appladdress")))
                    objColCriteria.Add(New SqlParameter("AppldistrictID", .Item("AppldistrictID")))
                    objColCriteria.Add(New SqlParameter("Appltalukaid", .Item("Appltalukaid")))
                    objColCriteria.Add(New SqlParameter("ApplvillageID", .Item("ApplvillageID")))
                    objColCriteria.Add(New SqlParameter("applMobileNo", .Item("applMobileNo")))
                    objColCriteria.Add(New SqlParameter("applEmailAdd", .Item("applEmailAdd")))
                    objColCriteria.Add(New SqlParameter("CertificateID", .Item("CertificateID")))
                    objColCriteria.Add(New SqlParameter("attachement", .Item("attachement")))
            End Select

            objColCriteria.Add(New SqlParameter("ServiceID", .Item("ServiceID")))
            objColCriteria.Add(New SqlParameter("serviceType", .Item("serviceType")))
            objColCriteria.Add(New SqlParameter("ApplYear", .Item("ApplYear")))
            objColCriteria.Add(New SqlParameter("ApplDate", .Item("ApplDate")))
            objColCriteria.Add(New SqlParameter("DisposalDays", .Item("DisposalDays")))
            objColCriteria.Add(New SqlParameter("DisposalDate", .Item("DisposalDate")))
            objColCriteria.Add(New SqlParameter("ApplFee", .Item("ApplFee")))
            objColCriteria.Add(New SqlParameter("CertificateEngGuj", .Item("CertificateEngGuj")))
            objColCriteria.Add(New SqlParameter("CitizenID", .Item("CitizenID")))
            objColCriteria.Add(New SqlParameter("ApplStatus", .Item("ApplStatus")))
            objColCriteria.Add(New SqlParameter("userID", .Item("userID")))
            objColCriteria.Add(New SqlParameter("rollID", .Item("rollID")))
            objColCriteria.Add(New SqlParameter("MacAddress", .Item("MacAddress")))
            objColCriteria.Add(New SqlParameter("IPAddress", .Item("IPAddress")))
            objColCriteria.Add(New SqlParameter("Page", .Item("Page")))
            objColCriteria.Add(New SqlParameter("EncryptionKey", .Item("EncryptionKey")))


        End With
    End Sub
    Public Overridable Sub Upload_Document_Citizen_Signed(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

        Try
            Dim objColCriteria As New Collection
            CreateParameter_Document_Upload_Citizen_Signed(ds.Tables("Citizen_Document"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("Citizen_Document_Upload_Insert_Signed", objColCriteria, "Citizen_Document", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CreateParameter_Document_Upload_Citizen_Signed(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)

            objColCriteria.Add(New SqlParameter("Citizen_UserID", .Item("Citizen_UserID")))
            objColCriteria.Add(New SqlParameter("DocumentID", .Item("DocumentID")))
            'objColCriteria.Add(New SqlParameter("DocumentType", .Item("DocumentType")))
            'objColCriteria.Add(New SqlParameter("DocumentNumber", .Item("DocumentNumber")))
            If IsDBNull(.Item("File")) = False Then
                objColCriteria.Add(New SqlParameter("DocumentUploadedFile", .Item("File")))
            End If

        End With
    End Sub

End Class
