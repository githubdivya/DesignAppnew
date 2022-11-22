Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.adminDataAccessLayer
Public Enum enmIndexDataLog
    DataLog = 1
End Enum

Public Class cDataLog
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With

        objDataExecute.getDataSet(ds, "COM_T_AuditApplication_Select", objColCriteria, "DataLog", Nothing)
    End Sub

End Class
