Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmIndexMarriageRegistration
    MarriageStatus = 1

End Enum
Public Class cMarriageStatus
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        If ds.Tables.Contains("Parameter") = True Then
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
        End If
        Select Case CType(index, enmIndexMarriageRegistration)
            Case enmIndexMarriageRegistration.MarriageStatus
                objDataExecute.getDataSet(ds, "Cer_T_MarriageStatus_Select", objColCriteria, "Marriagestatus", Nothing)

        End Select
    End Sub
End Class
