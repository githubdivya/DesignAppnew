Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.adminDataAccessLayer
Public Enum enmIndexOfficeSMSMap
    OfficeSMSMap = 1
End Enum

Public Class cOfficeSMSMap
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With

        objDataExecute.getDataSet(ds, "OfficeSMSMap_Select", objColCriteria, "OfficeSMSMap", Nothing)
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
        objDataExecute.UpdateRec("OfficeSMSMap_Update", objColCriteria, "OfficeSMSMap", Nothing)
    End Sub
   
    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Dim i As Integer
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("OfficeSMSMapID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "OfficeSMSMapID", DataRowVersion.Default, DBNull.Value))
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.Insert("OfficeSMSMap_Insert", objColCriteria, "OfficeSMSMap", Nothing)
        Return CType(objColCriteria.Item(1), SqlParameter).Value
    End Function

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
End Class
