Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Class cFunctionMasrter
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
        objDataExecute.getDataSet(ds, "COM_FuncMast_Select", objColCriteria, "FunctionMap", Nothing)
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("FunctionMap"), objColCriteria, enmParameterMode.Update)
        objDataExecute.UpdateRec("COM_FuncMast_Update", objColCriteria, "FunctionMap", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)

        '' DataSet that will hold the returned results	
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("FunctionMap"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("COM_FuncMast_Insert", objColCriteria, "FunctionMap", Nothing)
        With ds.Tables("FunctionMap").Rows(0)
            .Item("FunctionMap") = CType(objColCriteria(1), SqlParameter).Value
        End With
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("UserFunctionID", SqlDbType.Int, 8, ParameterDirection.InputOutput, True, 8, 0, "UserFunctionID", DataRowVersion.Default, .Item("UserFunctionID")))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("UserFunctionID", SqlDbType.Int, 8, ParameterDirection.Input, False, 8, 0, "UserFunctionID", DataRowVersion.Default, .Item("UserFunctionID")))
            End Select
            objColCriteria.Add(New SqlParameter("RefUserID", .Item("RefUserID")))
            objColCriteria.Add(New SqlParameter("Password", .Item("Password")))
            objColCriteria.Add(New SqlParameter("FuncID", .Item("FuncID")))
            objColCriteria.Add(New SqlParameter("UserID", .Item("UserID")))
            objColCriteria.Add(New SqlParameter("RoleID", .Item("RoleID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
        End With
    End Sub

End Class
