Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enmIndexMisReports
    crRecipt = 1
    crReciptDistrict = 111 'district
    crReciptAttach = 11
    cAppliNo = 2
    crInward = 3
    crReceiptCollectionApplWise = 4
    crReceiptCollectionServiceWise = 5
    crOfficeServiceMap = 6
    crServiceList = 7
    crServiceAttachment = 8
    crOfficeServiceActive_Inactive = 9
    crOfficewisePending = 10



    rdlcDistrictWiseReport = 10001
    rdlcServiceWiseReport = 10002
    rdlcOfficeWiseReport = 10003
    rdlcOfficeWiseDetailReport = 10004
    rdlcOfficeServiceWiseReport = 10005
    rdlcOfficeServiceWiseDetailReport = 1006







    EBCRegister = 81
    IncomeRegister = 63
    NonCreamyLayerRegister = 82
    OBCRegister = 64
    PermResidenceRegister = 76
    RelMinorityRegister = 79
    ResidenceRegister = 66
    SCSTRegister = 65
    SeniorCitizenRegister = 77

    AffReadyInwardRegister = 85
    AffCopy_Register = 67
End Enum
Public Interface IMisController

End Interface
Public Class cMisController
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
            Select Case CType(index, enmIndexMisReports)

                Case enmIndexMisReports.rdlcDistrictWiseReport
                    objDataExecute.getDataSet(ds, "RPT_MIS_SUMMARY_DISTRICT_WISE", objColCriteria, "DistrictWiseReport", Nothing)
                Case enmIndexMisReports.crInward
                    objDataExecute.getDataSet(ds, "RPT_MIS_INWARD_SELECT", objColCriteria, "Receipt", Nothing)
                Case enmIndexMisReports.crReceiptCollectionApplWise
                    objDataExecute.getDataSet(ds, "RPT_MIS_TReceiptCollectionAppWise", objColCriteria, "Receipt", Nothing)
                Case enmIndexMisReports.crReceiptCollectionServiceWise
                    objDataExecute.getDataSet(ds, "RPT_MIS_TReceiptCollectionServiceWise", objColCriteria, "Receipt", Nothing)
                Case enmIndexMisReports.crRecipt, enmIndexMisReports.crReciptDistrict
                    objDataExecute.getDataSet(ds, "RPT_Receipt_Select", objColCriteria, "Receipt", Nothing)
                Case enmIndexMisReports.crReciptAttach
                    objDataExecute.getDataSet(ds, "RPT_Receipt_SelectAttach", objColCriteria, "ReceiptAttach", Nothing)
                Case enmIndexMisReports.cAppliNo
                    objDataExecute.getDataSet(ds, "RPT_Receipt_SelectAttach", objColCriteria, "ReceiptAttach", Nothing)


                Case enmIndexMisReports.rdlcDistrictWiseReport
                    objDataExecute.getDataSet(ds, "RPT_MIS_SUMMARY_DISTRICT_WISE", objColCriteria, "DistrictWiseReport", Nothing)
                Case enmIndexMisReports.rdlcServiceWiseReport
                    objDataExecute.getDataSet(ds, "RPT_MIS_Top_Service", objColCriteria, "ServiceWiseReport", Nothing, 0)
                Case enmIndexMisReports.rdlcOfficeWiseReport
                    objDataExecute.getDataSet(ds, "RPT_MIS_SUMMARY_OFFICE_WISE", objColCriteria, "OfficeWiseReport", Nothing, 0)
                Case enmIndexMisReports.rdlcOfficeWiseDetailReport
                    objDataExecute.getDataSet(ds, "RPT_MIS_SUMMARY_OFFICE_WISE_DETAIL", objColCriteria, "OfficeWiseDetailReport", Nothing, 0)
                Case enmIndexMisReports.rdlcOfficeServiceWiseReport
                    objDataExecute.getDataSet(ds, "RPT_MIS_SUMMARY_SERVICE_WISE", objColCriteria, "OfficeServiceWiseReport", Nothing, 0)
                Case enmIndexMisReports.rdlcOfficeServiceWiseDetailReport
                    objDataExecute.getDataSet(ds, "RPT_MIS_OFFICE_SERVICEWISE_ApplDetail", objColCriteria, "OfficeServiceWiseDetailReport", Nothing, 0)
                Case enmIndexMisReports.crServiceList
                    objDataExecute.getDataSet(ds, "RPT_MIS_ServiceList", objColCriteria, "ServiceList", Nothing)
                Case enmIndexMisReports.crServiceAttachment
                    objDataExecute.getDataSet(ds, "RPT_MIS_vDocumentAttachment_Select", objColCriteria, "ServiceAttachment", Nothing)
                Case enmIndexMisReports.crOfficeServiceActive_Inactive
                    objDataExecute.getDataSet(ds, "RPT_MIS_Service_Active_Inactive", objColCriteria, "ServiceActiveInactive", Nothing)
                Case enmIndexMisReports.crOfficewisePending
                    objDataExecute.getDataSet(ds, "RPT_MIS_OFFICEWISE_Pending", objColCriteria, "OFFICEWISE_Pending", Nothing)
                Case enmIndexMisReports.crOfficeServiceMap
                    objDataExecute.getDataSet(ds, "RPT_MIS_Office_ServiceMap", objColCriteria, "OfficeServiceMap", Nothing)
                    'Service Register
                Case enmIndexMisReports.EBCRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_EBCRegister", objColCriteria, "ds_EBCRegister", Nothing)

                Case enmIndexMisReports.IncomeRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_IncomeRegister", objColCriteria, "ds_IncomeRegister", Nothing)

                Case enmIndexMisReports.NonCreamyLayerRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_NonCreamyRegister", objColCriteria, "ds_NonCreamyLayerRegister", Nothing)
                Case enmIndexMisReports.OBCRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_OBCRegister", objColCriteria, "ds_OBCRegister", Nothing)

                Case enmIndexMisReports.PermResidenceRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_PermResidenceRegister", objColCriteria, "ds_PermResidenceRegister", Nothing)

                Case enmIndexMisReports.RelMinorityRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_RelMinorityRegister", objColCriteria, "ds_RelMinorityRegister", Nothing)
                Case enmIndexMisReports.ResidenceRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_ResidenceRegister", objColCriteria, "ds_ResidenceRegister", Nothing)
                Case enmIndexMisReports.SCSTRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_SCSTRegister", objColCriteria, "ds_SCSTRegister", Nothing)
                Case enmIndexMisReports.SeniorCitizenRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_SeniorCitizenRegister", objColCriteria, "ds_SeniorCitizenRegister", Nothing)

                Case enmIndexMisReports.AffReadyInwardRegister
                    objDataExecute.getDataSet(ds, "RPT_MIS_AFF_Ready_Register", objColCriteria, "ds_AFF_Ready_Register", Nothing)


                Case enmIndexMisReports.AffCopy_Register
                    objDataExecute.getDataSet(ds, "RPT_MIS_AFF_Copy_Register", objColCriteria, "ds_AFF_Copy_Register", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
