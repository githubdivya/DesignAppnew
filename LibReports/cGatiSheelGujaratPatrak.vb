Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enumGatiSheelGujaratPatrak
    DistrictReport = 1
    DistrictDetail = 2



End Enum
Public Class cGatiSheelGujaratPatrak
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            If ds.Tables.Contains("Parameter") = True Then
                With ds.Tables("Parameter")
                    For i = 0 To .Rows.Count - 1
                        If CInt(.Rows(i).Item("PType")) = 1 Then
                            If .Rows(i).Item("DbType").ToString = "DateTime" Then
                                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, CDate(.Rows(i).Item("Pvalue"))))
                            Else
                                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                            End If
                        ElseIf IsDBNull(.Rows(i).Item("Pvalue")) Then
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                        Else
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, New System.Guid(.Rows(i).Item("Pvalue").ToString)))
                        End If
                    Next
                End With
            End If


            Select Case index

                Case enumGatiSheelGujaratPatrak.DistrictReport
                    objDataExecute.getDataSet(ds, "RPT_GatiSheelGujaratPatrak", objColCriteria, "Patrak", Nothing)
                Case enumGatiSheelGujaratPatrak.DistrictDetail
                    objDataExecute.getDataSet(ds, "RPT_GatiSheelGujaratPatrak", objColCriteria, "Patrak", Nothing)


                Case Else

            End Select


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
