Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.adminDataAccessLayer
Public Class cPostInfo
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_M_PostInfo_Select", objColCriteria, "COM_M_PostInfo", Nothing)
    End Sub
    Public Overridable Sub GetDataSet1(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_M_PostInfo_Select1", objColCriteria, "COM_M_PostInfo", Nothing)
    End Sub

    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("Pvalue").ToString.Trim = "-1" Then
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                Else
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                End If
            Next
        End With
        objDataExecute.UpdateRec("COM_M_PostInfo_Update", objColCriteria, "COM_M_PostInfo", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)

        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("PostID", strCriteria))

        objDataExecute.DeleteRec("COM_M_PostInfo_delete", objColCriteria, Nothing)
    End Sub

    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Dim i As Integer
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("PostID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "PostID", DataRowVersion.Default, DBNull.Value))
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.Insert("COM_M_PostInfo_Insert", objColCriteria, "COM_M_PostInfo", Nothing)
        Return CType(objColCriteria.Item(1), SqlParameter).Value
    End Function

End Class
