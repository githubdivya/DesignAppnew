Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Class cUser
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
        objDataExecute.getDataSet(ds, "COM_UserMast_Select", objColCriteria, "UserMast", Nothing)
    End Sub
    Public Overridable Sub GetDataSet1(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
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
        objDataExecute.getDataSet(ds, "User_Master_Find", objColCriteria, "UserMast", Nothing)
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("UserMast"), objColCriteria, enmParameterMode.Update)
        objDataExecute.UpdateRec("COM_UserMast_Update", objColCriteria, "UserMast", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)

        '' DataSet that will hold the returned results	
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("UserMast"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("COM_UserMast_Insert", objColCriteria, "UserMast", Nothing)
        With ds.Tables("UserMast").Rows(0)
            .Item("UserID") = CType(objColCriteria(1), SqlParameter).Value
        End With
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("UserID", SqlDbType.Int, 8, ParameterDirection.InputOutput, True, 8, 0, "UserID", DataRowVersion.Default, .Item("UserID")))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("UserID", SqlDbType.Int, 8, ParameterDirection.Input, False, 8, 0, "UserID", DataRowVersion.Default, .Item("UserID")))
            End Select
            objColCriteria.Add(New SqlParameter("UserName", .Item("UserName")))
            objColCriteria.Add(New SqlParameter("Password", .Item("Password")))
            objColCriteria.Add(New SqlParameter("Active", .Item("Active")))
            objColCriteria.Add(New SqlParameter("Description", .Item("Description")))
            objColCriteria.Add(New SqlParameter("intEmpID", .Item("intEmpID")))
            objColCriteria.Add(New SqlParameter("Empcode", .Item("Empcode")))
            objColCriteria.Add(New SqlParameter("EmpName", .Item("EmpName")))
            objColCriteria.Add(New SqlParameter("EmpType", .Item("EmpType")))
            objColCriteria.Add(New SqlParameter("EmpMobileNo", .Item("EmpMobileNo")))
            objColCriteria.Add(New SqlParameter("EmpMailID", .Item("EmpMailID")))
            objColCriteria.Add(New SqlParameter("Flag", "1"))
        End With
    End Sub

End Class
