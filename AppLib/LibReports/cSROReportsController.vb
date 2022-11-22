Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enmIndexSROReports
    FeeReceipt = 1
    FeeReceiptForApplication = 80
    DeficitFeeReceiptForApplication = 86
    MiscelleniousFeeReceiptForApplication = 87
    FeeReceiptForApplicationSub = 81
    FeeReceiptDetails = 2
    FeeReceiptOtherDetails = 3
    GanatriPatrak = 4
    GanatriPatrakSummary = 93
    Notice32 = 5
    PrintAllEndorsement = 6
    PrintAllEndorsementFees = 7
    PrintAllEndorsementParty = 8
    PrintAllEndorsementIdentifierParty = 9
    PrintAllEndorsementForm1 = 10
    PrintAllEndorsementOrder = 11
    Index2OfficeCopy = 12
    Index2OfficeCopyE = 13
    Index2OfficeCopyC = 14
    Index2OfficeCopyVillage = 94
    Index2OfficeCopyProperty = 15
    Index2Checklist = 92
    Column21 = 16
    MonthlySummary = 17
    MonthFirstLastRecord = 18
    PendingDocumentSummary = 19
    ClaimingPartyDetail = 20
    ExectingPartyDetail = 21
    TodaysDocumentsApplications = 22
    DocumentRegistrationPre = 72
    UsedStampDetails = 73
    'Admin Reports 
    AdmDayBook = 23
    AdmApplicationDayBook = 84
    AdmDayBookDetails = 24
    AdmRegistraionCashBook = 25
    AdmDeficitDutyCashBook = 26
    AdmRegistraionChallan = 27
    AdmDeficitDutyChallan = 28
    SingleDayCollection = 29
    SingleDayScanDoc = 83
    'Admin Reports
    AdmOKRegister = 30
    AdmNamunoA = 31
    AdmNamunoF = 32
    AdmRegistrationFeeRegister = 33
    AdmDeficitDutyFeeRegister = 34
    AdmSEC40Register = 35
    AdmNotice32Register = 36
    AdmWomenRegFeeRegister = 37
    AdmApplicationDayCashBook = 38
    AdmForAudit = 39
    AdmMonthlyAdminReport = 40
    'Yearly Reports
    AdmIncomeTaxRegister = 41
    AdmYearlyAdminReport = 42
    AdmYearlyTalukawiseTPDuty = 43
    AdmYearlyDetailsofDocument = 44
    AdmUsedStampDetails = 45
    AdmScanDocumentList = 46
    'Other Reports
    DocumentType = 47
    Lookup = 48
    EncumbranceCertificate = 49
    EncumbranceCertificateE = 50
    EncumbranceCertificateC = 51
    Jantry = 52
    Index2OfficeName = 53
    MarriageRegistration = 71

    'PrintAllEndorsement
    PrintAllEndorsementIT = 54
    PrintAllEndorsementSec32 = 55
    PrintAllEndorsementSec33 = 56
    PrintAllEndorsementSec88 = 57
    PrintAllEndorsementULC = 58
    PrintAllEndorsementBombayAct = 59
    PrintAllEndorsementDCPR = 60
    PrintAllEndorsementDUP = 85
    PrintAllEndorsementPlan = 61
    PrintAllEndorsementITNOTR = 62
    PrintAllEndorsementDuplicateDocument = 88
    PrintAllEndorsementPhotoIDProof = 89


    EncumbranceCertificateProperty = 63
    EncumbranceCertificateParty = 64
    EncumbranceCertificatePropertyReport = 65
    GanatriPatrak2008 = 66

    Index2PublicIssueCopy = 67
    Index2PublicIssueCopyE = 68
    Index2PublicIssueCopyC = 69
    Column21Summary = 70
    Index2ChecklistE = 90
    Index2ChecklistC = 91


    '2Page Documents
    TwoPageDoc = 74
    TwoPageDocParty = 75
    TwoPageDocSeller = 76
    TwoPageDocProperty = 77
    TwoPageDocConstruction = 78
    AppSearch = 79
    CTSPatrak = 95
    CTSPatrakE = 96
    CTSPatrakC = 97
    NamunoAE = 98
    NamunoFE = 99
    NamunoAC = 100
    NamunoFC = 101
    AdmWomenRegFeeRegisterEC = 102
    PrintAllEndorsementPOA = 103
    PrintAllEndorsementCertificate = 104
    FeeReceiptDetailsAmount = 105
    Mutation = 106
    Index2Checklist88 = 107
    Index2Checklist33 = 108
    PendingDocList = 110
    IncomeTAX114 = 111
    IncomeTAX114E = 112
    IncomeTAX114C = 113
    OldtoNewDocList = 115
    PendingDocList_Ordered = 116
    Index4 = 117
    Index4E = 118
    Index4C = 119
    GanatriPatrak_PreValuation = 120
    GanatriPatrak_PreValuation_party = 121
    GovtSearch = 122
    GovtSearchE = 123
    GovtSearchC = 124
    Col21 = 125
    Col21Summary = 126
End Enum
Public Interface IFeesReceiptController

End Interface
Public Class cSROReportsController
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
            Select Case CType(index, enmIndexSROReports)
                Case enmIndexSROReports.FeeReceipt
                    objDataExecute.getDataSet(ds, "RPT_FeeReceipt", objColCriteria, "FeeReceipt", Nothing)
                Case enmIndexSROReports.FeeReceiptDetailsAmount
                    objDataExecute.getDataSet(ds, "RPT_FeeReceiptDetailsforAmount", objColCriteria, "FeeReceiptAmount", Nothing)
                Case enmIndexSROReports.DeficitFeeReceiptForApplication
                    objDataExecute.getDataSet(ds, "RPT_DeficitFeeReceiptforApplication", objColCriteria, "DFeeReceiptforApplication", Nothing)
                Case enmIndexSROReports.MiscelleniousFeeReceiptForApplication
                    objDataExecute.getDataSet(ds, "RPT_MiscellaneousFeeReceiptforApplication", objColCriteria, "MFeeReceiptforApplication", Nothing)
                Case enmIndexSROReports.FeeReceiptForApplication
                    objDataExecute.getDataSet(ds, "RPT_FeeReceiptforApplication", objColCriteria, "FeeReceiptforApplication", Nothing)
                Case enmIndexSROReports.FeeReceiptForApplicationSub
                    objDataExecute.getDataSet(ds, "RPT_FeeReceiptforApplicationSub", objColCriteria, "FeeReceiptforApplicationSub", Nothing)
                Case enmIndexSROReports.FeeReceiptDetails
                    objDataExecute.getDataSet(ds, "RPT_FeeReceiptDetails", objColCriteria, "FeeReceiptDetails", Nothing)
                Case enmIndexSROReports.FeeReceiptOtherDetails
                    objDataExecute.getDataSet(ds, "RPT_FeeReceiptDetails", objColCriteria, "FeeReceiptOtherDetails", Nothing)
                Case enmIndexSROReports.GanatriPatrakSummary
                    objDataExecute.getDataSet(ds, "RPT_GanatriPatrak", objColCriteria, "GanatriPatrakSummary", Nothing)
                Case enmIndexSROReports.GanatriPatrak2008
                    objDataExecute.getDataSet(ds, "RPT_GanatriPatrak2008", objColCriteria, "GanatriPatrak", Nothing)
                Case enmIndexSROReports.Notice32
                    objDataExecute.getDataSet(ds, "RPT_GanatriPatrak32", objColCriteria, "Notice32", Nothing)
                    'PrintAllEndorsement
                Case enmIndexSROReports.PrintAllEndorsement
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsement", objColCriteria, "PrintAllEndorsement", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementFees
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementFees", objColCriteria, "PrintAllEndorsementFees", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementParty
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementParty", objColCriteria, "PrintAllEndorsementParty", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementIdentifierParty
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementIdentifierParty", objColCriteria, "PrintAllEndorsementIdentifierParty", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementForm1
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementForm1", objColCriteria, "PrintAllEndorsementForm1", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementOrder
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementOrder", objColCriteria, "PrintAllEndorsementOrder", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementIT
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementIT", objColCriteria, "PrintAllEndorsementIT", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementITNOTR
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementIT", objColCriteria, "PrintAllEndorsementITNOTR", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementSec32
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementSec32", objColCriteria, "PrintAllEndorsementSec32", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementSec33
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementPartySec33", objColCriteria, "PrintAllEndorsementPartySec33", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementSec88
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementPartySec88", objColCriteria, "PrintAllEndorsementPartySec88", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementULC
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementULC", objColCriteria, "PrintAllEndorsementULC", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementBombayAct
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementBombayAct", objColCriteria, "PrintAllEndorsementBombayAct", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementDCPR
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementDCPR", objColCriteria, "PrintAllEndorsementDCPR", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementDUP
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementDUP", objColCriteria, "PrintAllEndorsementDUP", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementPlan
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementPlan", objColCriteria, "PrintAllEndorsementPlan", Nothing)
                Case enmIndexSROReports.UsedStampDetails
                    objDataExecute.getDataSet(ds, "RPT_UsedStampDetails", objColCriteria, "UsedStampDetails", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementDuplicateDocument
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementDuplicateDocument", objColCriteria, "PrintAllEndorsementDuplicateDocument", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementPhotoIDProof
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementPhotoIDProof", objColCriteria, "PrintAllEndorsementPhotoIDProof", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementPOA
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementPOA", objColCriteria, "PrintAllEndorsementPOA", Nothing)
                Case enmIndexSROReports.PrintAllEndorsementCertificate
                    objDataExecute.getDataSet(ds, "RPT_PrintAllEndorsementCertificate", objColCriteria, "PrintAllEndorsementCertificate", Nothing)

                Case enmIndexSROReports.Index2OfficeCopy
                    objDataExecute.getDataSet(ds, "RPT_Index2Office", objColCriteria, "Index2OfficeCopy", Nothing)
                Case enmIndexSROReports.Index2OfficeCopyE
                    objDataExecute.getDataSet(ds, "RPT_Index2OfficeEC", objColCriteria, "Index2OfficeCopyE", Nothing)
                Case enmIndexSROReports.Index2OfficeCopyC
                    objDataExecute.getDataSet(ds, "RPT_Index2OfficeEC", objColCriteria, "Index2OfficeCopyC", Nothing)
                Case enmIndexSROReports.Index2OfficeCopyVillage
                    objDataExecute.getDataSet(ds, "RPT_Index2OfficeVillage", objColCriteria, "Index2OfficeCopyVllage", Nothing)
                Case enmIndexSROReports.Index2Checklist
                    objDataExecute.getDataSet(ds, "RPT_Index2Checklisting", objColCriteria, "Index2Checklist", Nothing)

                Case enmIndexSROReports.Index2ChecklistC
                    objDataExecute.getDataSet(ds, "RPT_Index2ChecklistEC", objColCriteria, "Index2ChecklistC", Nothing)
                Case enmIndexSROReports.Index2ChecklistE
                    objDataExecute.getDataSet(ds, "RPT_Index2ChecklistEC", objColCriteria, "Index2ChecklistE", Nothing)

                Case enmIndexSROReports.Index2Checklist88
                    objDataExecute.getDataSet(ds, "RPT_Sec33_88EC", objColCriteria, "Index2Checklist33E", Nothing)
                Case enmIndexSROReports.Index2Checklist33
                    objDataExecute.getDataSet(ds, "RPT_Sec33_88EC", objColCriteria, "Index2Checklist33C", Nothing)


                Case enmIndexSROReports.Column21
                    objDataExecute.getDataSet(ds, "RPT_Column21", objColCriteria, "Column21", Nothing)
                Case enmIndexSROReports.MonthlySummary
                    objDataExecute.getDataSet(ds, "RPT_MonthlySummary", objColCriteria, "MonthlySummary", Nothing)
                Case enmIndexSROReports.MonthFirstLastRecord
                    objDataExecute.getDataSet(ds, "RPT_MonthFirstLastRecord", objColCriteria, "MonthFirstLastRecord", Nothing)
                Case enmIndexSROReports.PendingDocumentSummary
                    objDataExecute.getDataSet(ds, "RPT_PendingDocumentSummary", objColCriteria, "PendingDocumentSummary", Nothing)
                Case enmIndexSROReports.ExectingPartyDetail
                    objDataExecute.getDataSet(ds, "RPT_PartyDetail", objColCriteria, "ExectingPartyDetail", Nothing)
                Case enmIndexSROReports.ClaimingPartyDetail
                    objDataExecute.getDataSet(ds, "RPT_PartyDetail", objColCriteria, "ClaimingPartyDetail", Nothing)
                    'Daily 
                Case enmIndexSROReports.TodaysDocumentsApplications
                    objDataExecute.getDataSet(ds, "RPT_TodaysDocumentsApplications", objColCriteria, "TodaysDocumentsApplications", Nothing)
                Case enmIndexSROReports.AdmDayBook
                    objDataExecute.getDataSet(ds, "RPT_AdmDayBook", objColCriteria, "AdmDayBook", Nothing)
                Case enmIndexSROReports.AdmDayBookDetails
                    objDataExecute.getDataSet(ds, "RPT_AdmDayBookDetails", objColCriteria, "AdmDayBookDetails", Nothing)
                Case enmIndexSROReports.AdmRegistraionCashBook
                    objDataExecute.getDataSet(ds, "RPT_AdmRegistraionCashBook", objColCriteria, "AdmRegistraionCashBook", Nothing)
                Case enmIndexSROReports.AdmDeficitDutyCashBook
                    objDataExecute.getDataSet(ds, "RPT_AdmDeficitDutyCashBook", objColCriteria, "AdmDeficitDutyCashBook", Nothing)
                Case enmIndexSROReports.AdmDeficitDutyChallan
                    objDataExecute.getDataSet(ds, "RPT_AdmDeficitDutyChallan", objColCriteria, "RPT_AdmDeficitDutyChallan", Nothing)
                Case enmIndexSROReports.SingleDayCollection
                    objDataExecute.getDataSet(ds, "RPT_SingleDayCollection", objColCriteria, "SingleDayCollection", Nothing)
                Case enmIndexSROReports.AdmRegistraionChallan
                    objDataExecute.getDataSet(ds, "RPT_AdmRegChallan", objColCriteria, "RPT_AdmRegChallan", Nothing)
                Case enmIndexSROReports.AdmApplicationDayBook
                    objDataExecute.getDataSet(ds, "RPT_AdmApplicationDayBook", objColCriteria, "AdmApplicationDayBook", Nothing)
                    'Monthly
                Case enmIndexSROReports.AdmNamunoA
                    objDataExecute.getDataSet(ds, "RPT_NamunoAF", objColCriteria, "AdmNamunoA", Nothing)
                Case enmIndexSROReports.AdmNamunoF
                    objDataExecute.getDataSet(ds, "RPT_NamunoAF", objColCriteria, "AdmNamunoF", Nothing)

                Case enmIndexSROReports.NamunoAE
                    objDataExecute.getDataSet(ds, "RPT_NamunoAFEC", objColCriteria, "NamunoAE", Nothing)
                Case enmIndexSROReports.NamunoAC
                    objDataExecute.getDataSet(ds, "RPT_NamunoAFEC", objColCriteria, "NamunoAC", Nothing)
                Case enmIndexSROReports.NamunoFE
                    objDataExecute.getDataSet(ds, "RPT_NamunoAFEC", objColCriteria, "NamunoFE", Nothing)
                Case enmIndexSROReports.NamunoFC
                    objDataExecute.getDataSet(ds, "RPT_NamunoAFEC", objColCriteria, "NamunoFC", Nothing)


                Case enmIndexSROReports.AdmDeficitDutyFeeRegister
                    objDataExecute.getDataSet(ds, "RPT_AdmDeficitDutyFeeRegister", objColCriteria, "AdmDeficitDutyFeeRegister", Nothing)
                Case enmIndexSROReports.AdmSEC40Register
                    objDataExecute.getDataSet(ds, "RPT_SEC40Register", objColCriteria, "AdmSEC40Register", Nothing)
                Case enmIndexSROReports.AdmOKRegister
                    objDataExecute.getDataSet(ds, "RPT_OKRegister", objColCriteria, "AdmOKRegister", Nothing)
                Case enmIndexSROReports.AdmNotice32Register
                    objDataExecute.getDataSet(ds, "RPT_Notice32Register", objColCriteria, "AdmNotice32Register", Nothing)
                Case enmIndexSROReports.AdmWomenRegFeeRegister
                    objDataExecute.getDataSet(ds, "RPT_AdmWomenRegFeeRegister", objColCriteria, "AdmWomenRegFeeRegister", Nothing)
                Case enmIndexSROReports.AdmWomenRegFeeRegisterEC
                    objDataExecute.getDataSet(ds, "RPT_AdmWomenRegFeeRegisterEC", objColCriteria, "AdmWomenRegFeeRegisterEC", Nothing)
                Case enmIndexSROReports.AdmDeficitDutyCashBook
                    objDataExecute.getDataSet(ds, "RPT_AdmDeficitDutyCashBook", objColCriteria, "AdmDeficitDutyCashBook", Nothing)
                Case enmIndexSROReports.AdmForAudit
                    objDataExecute.getDataSet(ds, "RPT_AdmForAudit", objColCriteria, "AdmForAudit", Nothing)
                Case enmIndexSROReports.AdmMonthlyAdminReport
                    objDataExecute.getDataSet(ds, "RPT_AdmMonthlyAdminReport", objColCriteria, "AdmMonthlyAdminReport", Nothing)
                Case enmIndexSROReports.AdmRegistrationFeeRegister
                    objDataExecute.getDataSet(ds, "RPT_RegistrationFeeRegister", objColCriteria, "AdmRegistrationFeeRegister", Nothing)
                    'Yearly
                Case enmIndexSROReports.AdmIncomeTaxRegister
                    objDataExecute.getDataSet(ds, "RPT_AdmIncomeTaxRegister", objColCriteria, "AdmIncomeTaxRegister", Nothing)
                Case enmIndexSROReports.AdmYearlyAdminReport
                    objDataExecute.getDataSet(ds, "RPT_AdmYearlyAdminReport", objColCriteria, "AdmYearlyAdminReport", Nothing)
                Case enmIndexSROReports.AdmYearlyTalukawiseTPDuty
                    objDataExecute.getDataSet(ds, "RPT_AdmYearlyTalukawiseTPDuty", objColCriteria, "AdmYearlyTalukawiseTPDuty", Nothing)
                Case enmIndexSROReports.AdmYearlyDetailsofDocument
                    objDataExecute.getDataSet(ds, "RPT_AdmYearlyDetailsofDocument", objColCriteria, "AdmYearlyDetailsofDocument", Nothing)
                Case enmIndexSROReports.AdmUsedStampDetails
                    objDataExecute.getDataSet(ds, "RPT_AdmUsedStampDetails", objColCriteria, "AdmUsedStampDetails", Nothing)
                Case enmIndexSROReports.AdmScanDocumentList
                    objDataExecute.getDataSet(ds, "RPT_AdmScanDocumentList", objColCriteria, "AdmScanDocumentList", Nothing)
                    'Other Reports
                Case enmIndexSROReports.Lookup
                    objDataExecute.getDataSet(ds, "RPT_Lookup", objColCriteria, "Lookup", Nothing)
                Case enmIndexSROReports.DocumentType
                    objDataExecute.getDataSet(ds, "RPT_DocumentType", objColCriteria, "DocumentType", Nothing)
                Case enmIndexSROReports.MarriageRegistration
                    objDataExecute.getDataSet(ds, "RPT_Marriage_Registration", objColCriteria, "MarriageRegistration", Nothing)
                    'for GP 
                Case enmIndexSROReports.EncumbranceCertificate
                    objDataExecute.getDataSet(ds, "RPT_EncumbranceCertificate", objColCriteria, "EncumbranceCertificate", Nothing)
                Case enmIndexSROReports.EncumbranceCertificateE
                    objDataExecute.getDataSet(ds, "RPT_EncumbranceCertificateEC", objColCriteria, "EncumbranceCertificateE", Nothing)
                Case enmIndexSROReports.EncumbranceCertificateC
                    objDataExecute.getDataSet(ds, "RPT_EncumbranceCertificateEC", objColCriteria, "EncumbranceCertificateC", Nothing)
                Case enmIndexSROReports.Jantry
                    objDataExecute.getDataSet(ds, "REG_M_Jantry_Rate", objColCriteria, "Jantry", Nothing)
                Case enmIndexSROReports.Index2OfficeName
                    objDataExecute.getDataSet(ds, "COM_M_OfficeMast_Select", objColCriteria, "Index2OfficeName", Nothing)
                Case enmIndexSROReports.Index2OfficeCopy
                    objDataExecute.getDataSet(ds, "RPT_Index2Office", objColCriteria, "Index2OfficeCopy", Nothing)
                Case enmIndexSROReports.Index2OfficeCopyE
                    objDataExecute.getDataSet(ds, "RPT_Index2OfficeEC", objColCriteria, "Index2OfficeCopyE", Nothing)
                Case enmIndexSROReports.Index2OfficeCopyC
                    objDataExecute.getDataSet(ds, "RPT_Index2OfficeEC", objColCriteria, "Index2OfficeCopyC", Nothing)
                Case enmIndexSROReports.Index2OfficeCopyProperty
                    objDataExecute.getDataSet(ds, "RPT_Index2OfficeCopyProperty", objColCriteria, "Index2OfficeCopyProperty", Nothing)

                Case enmIndexSROReports.EncumbranceCertificateProperty
                    objDataExecute.getDataSet(ds, "WS_gECparameter", objColCriteria, "EncumbranceCertificateProperty", Nothing)
                Case enmIndexSROReports.EncumbranceCertificateParty
                    objDataExecute.getDataSet(ds, "WS_gECparameterParty", objColCriteria, "EncumbranceCertificateParty", Nothing)
                Case enmIndexSROReports.EncumbranceCertificatePropertyReport
                    objDataExecute.getDataSet(ds, "RPT_EncumbranceCertificateProperty", objColCriteria, "EncumbranceCertificatePropertyReport", Nothing)


                Case enmIndexSROReports.Index2PublicIssueCopy
                    objDataExecute.getDataSet(ds, "RPT_Index2PublicIssue", objColCriteria, "Index2PublicIssueCopy", Nothing)

                Case enmIndexSROReports.Index2PublicIssueCopyE
                    objDataExecute.getDataSet(ds, "RPT_Index2PublicIssueEC", objColCriteria, "Index2PublicIssueE", Nothing)

                Case enmIndexSROReports.Index2PublicIssueCopyC
                    objDataExecute.getDataSet(ds, "RPT_Index2PublicIssueEC", objColCriteria, "Index2PublicIssueC", Nothing)

                Case enmIndexSROReports.AppSearch
                    objDataExecute.getDataSet(ds, "RPT_Index2PublicIssue", objColCriteria, "AppSearch", Nothing)
                    '2Page Doc
                Case enmIndexSROReports.TwoPageDoc
                    objDataExecute.getDataSet(ds, "RPT_2PageDocument", objColCriteria, "2PageDocument", Nothing)
                Case enmIndexSROReports.TwoPageDocParty
                    objDataExecute.getDataSet(ds, "RPT_2PageDocParty", objColCriteria, "2PageDocParty", Nothing)
                Case enmIndexSROReports.TwoPageDocSeller
                    objDataExecute.getDataSet(ds, "RPT_2PageDocPartySeller", objColCriteria, "2PageDocPartySeller", Nothing)
                Case enmIndexSROReports.TwoPageDocProperty
                    objDataExecute.getDataSet(ds, "RPT_2PageDocProperty", objColCriteria, "2PageDocProperty", Nothing)
                Case enmIndexSROReports.TwoPageDocConstruction
                    objDataExecute.getDataSet(ds, "RPT_2PageDocConstructon", objColCriteria, "2PageDocConstructon", Nothing)
                Case enmIndexSROReports.SingleDayScanDoc
                    objDataExecute.getDataSet(ds, "RPT_SingleDayScanDoc", objColCriteria, "SingleDayScanDoc", Nothing)

                Case enmIndexSROReports.CTSPatrak
                    objDataExecute.getDataSet(ds, "RPT_CTSPatrak", objColCriteria, "CTSPatrak", Nothing)
                Case enmIndexSROReports.CTSPatrakC
                    objDataExecute.getDataSet(ds, "RPT_CTSPatrakEC", objColCriteria, "CTSPatrakC", Nothing)
                Case enmIndexSROReports.CTSPatrakE
                    objDataExecute.getDataSet(ds, "RPT_CTSPatrakEC", objColCriteria, "CTSPatrakE", Nothing)
                Case enmIndexSROReports.Mutation
                    objDataExecute.getDataSet(ds, "RPT_Mutation", objColCriteria, "Mutation", Nothing)
                Case enmIndexSROReports.PendingDocList
                    objDataExecute.getDataSet(ds, "RPT_PendingDocList", objColCriteria, "PendingDocList", Nothing)


                Case enmIndexSROReports.IncomeTAX114
                    objDataExecute.getDataSet(ds, "RPT_IncomeTAX114B", objColCriteria, "IncomeTAX114", Nothing)
                Case enmIndexSROReports.IncomeTAX114E
                    objDataExecute.getDataSet(ds, "RPT_IncomeTAX114BEC", objColCriteria, "IncomeTAX114E", Nothing)
                Case enmIndexSROReports.IncomeTAX114C
                    objDataExecute.getDataSet(ds, "RPT_IncomeTAX114BEC", objColCriteria, "IncomeTAX114C", Nothing)


                Case enmIndexSROReports.OldtoNewDocList
                    objDataExecute.getDataSet(ds, "RPT_OLDtoNEW__DocList", objColCriteria, "OldtoNewDocList", Nothing)
                Case enmIndexSROReports.PendingDocList_Ordered
                    objDataExecute.getDataSet(ds, "RPT_CurrentYearOrder_DocList", objColCriteria, "PendingDocList_Ordered", Nothing)

                Case enmIndexSROReports.Index4
                    objDataExecute.getDataSet(ds, "RPT_Index4", objColCriteria, "Index4", Nothing)
                Case enmIndexSROReports.Index4E
                    objDataExecute.getDataSet(ds, "RPT_Index4EC", objColCriteria, "Index4E", Nothing)
                Case enmIndexSROReports.Index4C
                    objDataExecute.getDataSet(ds, "RPT_Index4EC", objColCriteria, "Index4C", Nothing)

                Case enmIndexSROReports.GanatriPatrak_PreValuation
                    objDataExecute.getDataSet(ds, "RPT_GanatriPatrak_PreValuation", objColCriteria, "GanatriPatrak_PreValuation", Nothing)
                Case enmIndexSROReports.GanatriPatrak_PreValuation_party
                    objDataExecute.getDataSet(ds, "RPT_GanatriPatrak_PreValuation_Party", objColCriteria, "GanatriPatrak_PreValuation_party", Nothing)

                Case enmIndexSROReports.GovtSearch
                    objDataExecute.getDataSet(ds, "RPT_GovtSearch", objColCriteria, "GovtSearch", Nothing)
                Case enmIndexSROReports.GovtSearchE
                    objDataExecute.getDataSet(ds, "RPT_GovtSearchEC", objColCriteria, "GovtSearchE", Nothing)
                Case enmIndexSROReports.GovtSearchC
                    objDataExecute.getDataSet(ds, "RPT_GovtSearchEC", objColCriteria, "GovtSearchC", Nothing)

                Case enmIndexSROReports.Col21
                    objDataExecute.getDataSet(ds, "Column21_Select", objColCriteria, "Col21", Nothing)
                Case enmIndexSROReports.Col21Summary
                    objDataExecute.getDataSet(ds, "Column21_Select", objColCriteria, "Col21Summary", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal objColCriteria As Collection = Nothing, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Insert(ByRef ds As DataSet, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function

End Class
