Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Class cShortKeys
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        If ds.Tables.Contains("Parameter") = True Then
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    If CInt(.Rows(i).Item("PType")) = 1 Then
                        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                    Else
                        If .Rows(i).Item("Pvalue").ToString.Trim = "-1" Then
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                        Else
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, "ReceiptNo", DataRowVersion.Default, New System.Guid(.Rows(i).Item("Pvalue").ToString)))
                        End If
                    End If
                Next
            End With
        End If
        objDataExecute.getDataSet(ds, "COM_D_ShortKeys_Select", objColCriteria, "ShortKeys", Nothing)
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        For i As Integer = 0 To ds.Tables("ShortKeys").Rows.Count - 1
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("ShortKeys"), i, objColCriteria, enmParameterMode.Update)
            objDataExecute.UpdateRec("COM_D_ShortKeys_Update", objColCriteria, "ShortKeys", Nothing)
        Next
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)

        '' DataSet that will hold the returned results	
        For i As Integer = 0 To ds.Tables("ShortKeys").Rows.Count - 1
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("ShortKeys"), i, objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("COM_D_ShortKeys_Insert", objColCriteria, "ShortKeys", Nothing)
        Next
        'With ds.Tables("ShortKeys").Rows(0)
        '    .Item("ShortKeysID") = CType(objColCriteria(1), SqlParameter).Value
        'End With
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByVal index As Integer, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(index)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("ShortKeysID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 16, 0, "ShortKeysID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("ShortKeysID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input, False, 16, 0, "ShortKeysID", DataRowVersion.Default, .Item("ShortKeysID")))
            End Select
            objColCriteria.Add(New SqlParameter("ShortKeyCode", .Item("ShortKeyCode")))
            'objColCriteria.Add(New SqlParameter("Password", .Item("Password")))
            objColCriteria.Add(New SqlParameter("ShortKeyDesc", .Item("ShortKeyDesc")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("RefUserID", .Item("RefUserID")))
            objColCriteria.Add(New SqlParameter("RoleID", .Item("RoleID")))
        End With
    End Sub
End Class
