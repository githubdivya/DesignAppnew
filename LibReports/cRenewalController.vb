Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic

Public Enum enmIndexcRenewalReports
    'gu-2,en=1
    crRenWriter = 932
    crRenStampVendor = 942
    crRenArm = 912
    crRenHotel = 922
    crRenNSC = 901
    crRenMPKBY = 892
End Enum
Public Class cRenewalController
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
            Select Case CType(index, enmIndexcRenewalReports)
                Case enmIndexcRenewalReports.crRenWriter
                    objDataExecute.getDataSet(ds, "RPT_Ren_WriterLicence", objColCriteria, "RenWriterLicence", Nothing)
                Case enmIndexcRenewalReports.crRenStampVendor
                    objDataExecute.getDataSet(ds, "RPT_Ren_StampVendorLicence", objColCriteria, "RenStampVendorLicence", Nothing)
                Case enmIndexcRenewalReports.crRenArm
                    objDataExecute.getDataSet(ds, "RPT_Ren_ArmLicence", objColCriteria, "RenArmLicence", Nothing)
                Case enmIndexcRenewalReports.crRenHotel
                    objDataExecute.getDataSet(ds, "RPT_Ren_HotelLicence", objColCriteria, "RenHotelLicence", Nothing)
                Case enmIndexcRenewalReports.crRenNSC
                    objDataExecute.getDataSet(ds, "RPT_Ren_NSCAgency", objColCriteria, "RenNSCAgency", Nothing)
                Case enmIndexcRenewalReports.crRenMPKBY
                    objDataExecute.getDataSet(ds, "RPT_Ren_MPKBYAgency", objColCriteria, "RenMPKBYAgency", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
