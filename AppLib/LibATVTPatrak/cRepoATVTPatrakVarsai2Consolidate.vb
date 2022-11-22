Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmRepoATVTPatrakVarsai2Consolidate
    RepoATVTPatrakVarsai2Consolidate = 1
End Enum
Public Class cRepoATVTPatrakVarsai2Consolidate
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
            objDataExecute.getDataSet(ds, "RPT_PatrakVarsai2Consolidate", objColCriteria, "PatrakVarsai2", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class