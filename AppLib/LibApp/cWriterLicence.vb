
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmWriterLicence
    WriterLicence = 1
End Enum

Public Class cWriterLicence

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
            objDataExecute.getDataSet(ds, "Ren_T_WriterLicence_Select", objColCriteria, "WriterLicence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub FindDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.getDataSet(ds, "Ren_T_WriterLicence_Find", objColCriteria, "WriterLicence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("WriterLicence"), objColCriteria, enmParameterMode.Update)
            objDataExecute.Insert("Ren_T_WriterLicence_Update", objColCriteria, "WriterLicence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("ApplId", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "ApplId", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("Ren_T_WriterLicence_Delete", objColCriteria, "WriterLicence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("WriterLicence"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("Ren_T_WriterLicence_Insert", objColCriteria, "WriterLicence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
    End Sub
    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("Applno", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "Applno", DataRowVersion.Default, .Item("Applno")))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("Applno", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "Applno", DataRowVersion.Default, .Item("Applno")))
            End Select
            objColCriteria.Add(New SqlParameter("districtid", .Item("districtid")))
            objColCriteria.Add(New SqlParameter("talukaid", .Item("talukaid")))
            'objColCriteria.Add(New SqlParameter("villageID", .Item("villageID")))
            objColCriteria.Add(New SqlParameter("OfficeId", .Item("OfficeId")))
            objColCriteria.Add(New SqlParameter("ServiceId", .Item("ServiceId")))
            objColCriteria.Add(New SqlParameter("ApplYear", .Item("ApplYear")))
            objColCriteria.Add(New SqlParameter("ApplDate", .Item("ApplDate")))
            objColCriteria.Add(New SqlParameter("Salute", .Item("Salute")))
            objColCriteria.Add(New SqlParameter("Surname", .Item("Surname")))
            objColCriteria.Add(New SqlParameter("Name", .Item("Name")))
            objColCriteria.Add(New SqlParameter("LastName", .Item("LastName")))
            objColCriteria.Add(New SqlParameter("Address", .Item("Address")))
            objColCriteria.Add(New SqlParameter("FatherName", .Item("FatherName")))
            objColCriteria.Add(New SqlParameter("ApplTalukaID", .Item("ApplTalukaID")))
            objColCriteria.Add(New SqlParameter("ApplDistrictID", .Item("ApplDistrictID")))
            objColCriteria.Add(New SqlParameter("ApplVillageID", .Item("ApplVillageID")))
          
            objColCriteria.Add(New SqlParameter("ChalanAmount", .Item("ChalanAmount")))
            objColCriteria.Add(New SqlParameter("AffidavitNo", .Item("AffidavitNo")))
            objColCriteria.Add(New SqlParameter("LicenceNo", .Item("LicenceNo")))
            objColCriteria.Add(New SqlParameter("LicenceExpDate", .Item("LicenceExpDate")))
            objColCriteria.Add(New SqlParameter("LicenceValidFromYr", .Item("LicenceValidFromYr")))
            objColCriteria.Add(New SqlParameter("LicenceValidToYr", .Item("LicenceValidToYr")))
            objColCriteria.Add(New SqlParameter("LicenceRenFromYr", .Item("LicenceRenFromYr")))
            objColCriteria.Add(New SqlParameter("LicenceRenToYr", .Item("LicenceRenToYr")))

            objColCriteria.Add(New SqlParameter("attachement", .Item("attachement")))
            objColCriteria.Add(New SqlParameter("userID", .Item("userID")))
            objColCriteria.Add(New SqlParameter("rollID", .Item("rollID")))
            objColCriteria.Add(New SqlParameter("CertificateID", .Item("CertificateID")))

            objColCriteria.Add(New SqlParameter("id_Proof_EPIC_no", .Item("id_Proof_EPIC_no")))
            objColCriteria.Add(New SqlParameter("id_Proof_EPIC_no_verify", .Item("id_Proof_EPIC_no_verify")))
            objColCriteria.Add(New SqlParameter("BPL_NO", .Item("BPL_NO")))
            objColCriteria.Add(New SqlParameter("BPL_NO_verify", .Item("BPL_NO_verify")))
            objColCriteria.Add(New SqlParameter("G_REGNO", .Item("G_REGNO")))
            objColCriteria.Add(New SqlParameter("G_REGNO_verify", .Item("G_REGNO_verify")))

            objColCriteria.Add(New SqlParameter("InChargeID", .Item("InChargeID")))
            objColCriteria.Add(New SqlParameter("MacAddress", .Item("MacAddress")))
            objColCriteria.Add(New SqlParameter("IPAddress", .Item("IPAddress")))
            objColCriteria.Add(New SqlParameter("Page", .Item("Page")))
            objColCriteria.Add(New SqlParameter("Remarks", .Item("Remarks")))
            objColCriteria.Add(New SqlParameter("EncryptionKey", .Item("EncryptionKey")))
        End With
    End Sub
End Class
