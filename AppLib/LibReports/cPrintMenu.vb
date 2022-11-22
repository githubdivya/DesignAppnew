﻿Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmPrintMenu
    PrintMenu = 1
    ApplnoYr = 2
    Detail = 3
End Enum
Public Class cPrintMenu
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
            Select Case CType(index, enmPrintMenu)
                Case enmPrintMenu.PrintMenu
                    objDataExecute.getDataSet(ds, "T_Print", objColCriteria, "Receipt", Nothing)
                Case enmPrintMenu.ApplnoYr
                    objDataExecute.getDataSet(ds, "T_Receipt_SelectApplnoYr", objColCriteria, "Receipt", Nothing)
                Case enmPrintMenu.Detail
                    objDataExecute.getDataSet(ds, "T_Receipt_Print_Find", objColCriteria, "Receipt", Nothing)

            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
  
End Class
