
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Class cScanningDoc
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                If IsDBNull(.Rows(i).Item("Pvalue")) Then
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                Else
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                End If
            Next
        End With
        objDataExecute.getDataSet(ds, "M_ScanDocumentProof_Select", objColCriteria, "ScanDocumentProof", Nothing)
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("ScanDocumentProof"), objColCriteria, enmParameterMode.Update)
        objDataExecute.UpdateRec("M_ScanDocumentProof_Update", objColCriteria, "ScanDocumentProof", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("ScanDocumentID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input, True, 0, 0, "ScanDocumentID", DataRowVersion.Default, New System.Guid(strCriteria)))
        objDataExecute.DeleteRec("M_ScanDocumentProof_Delete", objColCriteria, Nothing)
    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("ScanDocument"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("M_ScanDocumentProof_Insert", objColCriteria, "ScanDocumentProof", Nothing)
    End Sub

    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("RegisterDocumentID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, "RegisterDocumentID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("RegisterDocumentID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, False, 0, 0, "RegisterDocumentID", DataRowVersion.Default, .Item("RegisterDocumentID")))
            End Select
            objColCriteria.Add(New SqlParameter("UserID", .Item("UserID")))
            objColCriteria.Add(New SqlParameter("RoleID", .Item("RoleID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("ScanSupPgs", .Item("ScanSupPgs")))
            objColCriteria.Add(New SqlParameter("TotalScanSupPage", .Item("TotalScanSupPage")))
        End With
    End Sub
End Class


