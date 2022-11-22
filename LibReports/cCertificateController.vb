Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enmIndexcCertificateReports
    ' IncomeCerti = 1
    ' CrySeniorCiti = 2

    'For Receipt
    crRecipt = 1
    crReciptAttach = 11
    cAppliNo = 2
    'For Receipt


    cryOBCen = 641
    cryOBCSuben = 6411
    cryOBC = 642
    cryOBCSub = 6421

    crySCST = 652
    crySCSTSub = 6521
    crySCST_en = 651
    crySCSTSub_en = 6511

    CryResienen = 661
    cryResidenceSub_en = 6611
    CryResi = 662
    cryResidenceSub = 6621

    cryPermResidence_en_new = 761
    cryPermResidenceSub_en = 7611
    cryResiPerm = 762
    cryPermResidenceSub = 7621

    'CrySeniorCiti_en_idcard = 771
    'CrySeniorCitySub_en = 7711
    'CrySeniorCiti = 772
    'CrySeniorCitySub = 7721
    CrySeniorCiti_en_idcard = 773
    ' CrySeniorCitySub_en = 7731
    CrySeniorCiti = 772
    CrySeniorCitySub = 7721
    CrySeniorCiti_en = 771
    CrySeniorCitySub_en = 7711

    IncomeCerti_En = 631
    IncomeCertiSub_En = 6311
    IncomeCerti = 632
    IncomeCertiSub = 6321

    cryCharacter = 782
    cryCharacterSub = 7821

    cryNonCremCerti_New = 821
    cryNonCremCertiSub_en = 8211
    cryNonCremCerti_guj_new = 822
    cryNonCremCertiSub = 8221

    cryReligiousMinority = 792
    cryReligiousMinority_Sub = 7921

    cryEBCerti = 812
    CryEBCSub = 8121

    cryFarmerCert = 192
    CryFarmerSub = 1921

    CrySolvancy_New = 1022
    crySolvancySub = 10221

    CryNominee = 712
    cryNomineeDetail = 7121
    cryNomineeSub = 7122

    cryWidow = 802
    cryWidowSub = 8021

    cryOldAge = 682
    cryOldAgeSub = 6821


    IncomeCerti_EnP = 3071
    IncomeCertiSub_EnP = 30711
    IncomeCertiP = 3072
    IncomeCertiSubP = 30721

    cryReligiousMinorityP = 3082
    cryReligiousMinority_SubP = 30821

    cryEBCertiP = 3092
    CryEBCSubP = 30921

    cryWidowP = 3102
    cryWidowSubP = 31021

    crySCSTP = 3112
    crySCSTSubP = 31121
    crySCST_enP = 3111
    crySCSTSub_enP = 31111

    NRemarriage = 3322
    NRemarriage_Sub = 33221

    cryDivorce = 3312
    cryDivorcesub = 33121

    cryOBCenP = 3361
    cryOBCSubenP = 33611
    cryOBCP = 3362
    cryOBCSubP = 33621

    Rationcard_delete = 1112
    RationcardMemb_delete = 11121

    Rationcard_Add = 1102
    RationcardMemb_Add = 11021

    Rationcard_Split_new = 522
    RationcardMemb_Split = 5221

    cryCast_Buddh_en = 3531
    cryCast_Buddh_Sub_en = 35311

End Enum
Public Interface IcCertificateController

End Interface
Public Class cCertificateController
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
            Select Case CType(index, enmIndexcCertificateReports)

                Case enmIndexcCertificateReports.crRecipt
                    objDataExecute.getDataSet(ds, "RPT_Receipt_Select", objColCriteria, "Receipt", Nothing)
                Case enmIndexcCertificateReports.crReciptAttach
                    objDataExecute.getDataSet(ds, "RPT_Receipt_SelectAttach", objColCriteria, "ReceiptAttach", Nothing)
                Case enmIndexcCertificateReports.cAppliNo
                    objDataExecute.getDataSet(ds, "RPT_Receipt_SelectAttach", objColCriteria, "ReceiptAttach", Nothing)

                Case enmIndexcCertificateReports.cryOBCen
                    objDataExecute.getDataSet(ds, "RPT_OBCSelect", objColCriteria, "OBC", Nothing)
                Case enmIndexcCertificateReports.cryOBCSuben
                    objDataExecute.getDataSet(ds, "RPT_OBCSelectAttach", objColCriteria, "OBCSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryOBC
                    objDataExecute.getDataSet(ds, "RPT_OBCSelect", objColCriteria, "OBC", Nothing)
                Case enmIndexcCertificateReports.cryOBCSub
                    objDataExecute.getDataSet(ds, "RPT_OBCSelectAttach", objColCriteria, "OBCSelectAttach", Nothing)
                Case enmIndexcCertificateReports.cryOBCenP
                    objDataExecute.getDataSet(ds, "RPT_OBCSelect", objColCriteria, "OBC", Nothing)
                Case enmIndexcCertificateReports.cryOBCSubenP
                    objDataExecute.getDataSet(ds, "RPT_OBCSelectAttach", objColCriteria, "OBCSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryOBCP
                    objDataExecute.getDataSet(ds, "RPT_OBCSelect", objColCriteria, "OBC", Nothing)
                Case enmIndexcCertificateReports.cryOBCSubP
                    objDataExecute.getDataSet(ds, "RPT_OBCSelectAttach", objColCriteria, "OBCSelectAttach", Nothing)

                Case enmIndexcCertificateReports.crySCST
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelect", objColCriteria, "SCST", Nothing)
                Case enmIndexcCertificateReports.crySCSTSub
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelectAttach", objColCriteria, "SCSTSelectAttach", Nothing)

                Case enmIndexcCertificateReports.crySCST_en
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelect", objColCriteria, "SCST", Nothing)
                Case enmIndexcCertificateReports.crySCSTSub_en
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelectAttach", objColCriteria, "SCSTSelectAttach", Nothing)


                Case enmIndexcCertificateReports.crySCSTP
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelect", objColCriteria, "SCST", Nothing)
                Case enmIndexcCertificateReports.crySCSTSubP
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelectAttach", objColCriteria, "SCSTSelectAttach", Nothing)

                Case enmIndexcCertificateReports.crySCST_enP
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelect", objColCriteria, "SCST", Nothing)
                Case enmIndexcCertificateReports.crySCSTSub_enP
                    objDataExecute.getDataSet(ds, "RPT_SCSTSelectAttach", objColCriteria, "SCSTSelectAttach", Nothing)

                Case enmIndexcCertificateReports.CryResienen
                    objDataExecute.getDataSet(ds, "RPT_ResidenceSelect", objColCriteria, "Residence", Nothing)
                Case enmIndexcCertificateReports.cryResidenceSub_en
                    objDataExecute.getDataSet(ds, "RPT_ResidenceSelectAttach", objColCriteria, "RPT_ResidenceSelectAttach", Nothing)

                Case enmIndexcCertificateReports.CryResi
                    objDataExecute.getDataSet(ds, "RPT_ResidenceSelect", objColCriteria, "Residence", Nothing)
                Case enmIndexcCertificateReports.cryResidenceSub
                    objDataExecute.getDataSet(ds, "RPT_ResidenceSelectAttach", objColCriteria, "RPT_ResidenceSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryPermResidence_en_new
                    objDataExecute.getDataSet(ds, "RPT_PermResidenceSelect", objColCriteria, "PermResidence", Nothing)
                Case enmIndexcCertificateReports.cryPermResidenceSub_en
                    objDataExecute.getDataSet(ds, "RPT_PermResidenceSelectAttach", objColCriteria, "RPT_PermResidenceSelectAttach", Nothing)

                Case enmIndexcCertificateReports.CryResiPerm
                    objDataExecute.getDataSet(ds, "RPT_PermResidenceSelect", objColCriteria, "PermResidence", Nothing)
                Case enmIndexcCertificateReports.cryPermResidenceSub
                    objDataExecute.getDataSet(ds, "RPT_PermResidenceSelectAttach", objColCriteria, "RPT_PermResidenceSelectAttach", Nothing)

                Case enmIndexcCertificateReports.CrySeniorCiti_en_idcard
                    objDataExecute.getDataSet(ds, "RPT_SrCitizenSelect", objColCriteria, "SrCitizen", Nothing)
                Case enmIndexcCertificateReports.CrySeniorCiti_en
                    objDataExecute.getDataSet(ds, "RPT_SrCitizenSelect", objColCriteria, "SrCitizen", Nothing)
                Case enmIndexcCertificateReports.CrySeniorCitySub_en
                    objDataExecute.getDataSet(ds, "RPT_SrCitizenSelectAttach", objColCriteria, "RPT_SrCitizenSelectAttach", Nothing)

                Case enmIndexcCertificateReports.CrySeniorCiti
                    objDataExecute.getDataSet(ds, "RPT_SrCitizenSelect", objColCriteria, "SrCitizen", Nothing)
                Case enmIndexcCertificateReports.CrySeniorCitySub
                    objDataExecute.getDataSet(ds, "RPT_SrCitizenSelectAttach", objColCriteria, "RPT_SrCitizenSelectAttach", Nothing)

                Case enmIndexcCertificateReports.IncomeCerti_En
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelect", objColCriteria, "Income", Nothing)
                Case enmIndexcCertificateReports.IncomeCertiSub_En
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelectAttach", objColCriteria, "RPT_IncomeSelectAttach", Nothing)
                Case enmIndexcCertificateReports.IncomeCerti_EnP
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelect", objColCriteria, "Income", Nothing)
                Case enmIndexcCertificateReports.IncomeCertiSub_EnP
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelectAttach", objColCriteria, "RPT_IncomeSelectAttach", Nothing)

                Case enmIndexcCertificateReports.IncomeCerti
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelect", objColCriteria, "Income", Nothing)
                Case enmIndexcCertificateReports.IncomeCertiSub
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelectAttach", objColCriteria, "RPT_IncomeSelectAttach", Nothing)
                Case enmIndexcCertificateReports.IncomeCertiP
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelect", objColCriteria, "Income", Nothing)
                Case enmIndexcCertificateReports.IncomeCertiSubP
                    objDataExecute.getDataSet(ds, "RPT_IncomeSelectAttach", objColCriteria, "RPT_IncomeSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryCharacter
                    objDataExecute.getDataSet(ds, "RPT_CharacterSelect", objColCriteria, "Character", Nothing)
                Case enmIndexcCertificateReports.cryCharacterSub
                    objDataExecute.getDataSet(ds, "RPT_CharacterSelectAttach", objColCriteria, "RPT_CharacterSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryNonCremCerti_New
                    objDataExecute.getDataSet(ds, "RPT_Non_CremSelect", objColCriteria, "Non_CreamyLayer", Nothing)
                Case enmIndexcCertificateReports.cryNonCremCertiSub_en
                    objDataExecute.getDataSet(ds, "RPT_Non_CremSelectAttach", objColCriteria, "RPT_Non_CremSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryNonCremCerti_guj_new
                    objDataExecute.getDataSet(ds, "RPT_Non_CremSelect", objColCriteria, "Non_CreamyLayer", Nothing)
                Case enmIndexcCertificateReports.cryNonCremCertiSub
                    objDataExecute.getDataSet(ds, "RPT_Non_CremSelectAttach", objColCriteria, "RPT_Non_CremSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryReligiousMinority
                    objDataExecute.getDataSet(ds, "RPT_ReligMinoritySelect", objColCriteria, "ReligiousMinority", Nothing)
                Case enmIndexcCertificateReports.cryReligiousMinority_Sub
                    objDataExecute.getDataSet(ds, "RPT_ReligMinoritySelectAttach", objColCriteria, "RPT_ReligMinoritySelectAttach", Nothing)
                Case enmIndexcCertificateReports.cryReligiousMinorityP
                    objDataExecute.getDataSet(ds, "RPT_ReligMinoritySelect", objColCriteria, "ReligiousMinority", Nothing)
                Case enmIndexcCertificateReports.cryReligiousMinority_SubP
                    objDataExecute.getDataSet(ds, "RPT_ReligMinoritySelectAttach", objColCriteria, "RPT_ReligMinoritySelectAttach", Nothing)


                Case enmIndexcCertificateReports.cryEBCerti
                    objDataExecute.getDataSet(ds, "RPT_EBCSelect", objColCriteria, "EBC", Nothing)
                Case enmIndexcCertificateReports.CryEBCSub
                    objDataExecute.getDataSet(ds, "RPT_EBCSelectAttach", objColCriteria, "RPT_EBCSelectAttach", Nothing)
                Case enmIndexcCertificateReports.cryEBCertiP
                    objDataExecute.getDataSet(ds, "RPT_EBCSelect", objColCriteria, "EBC", Nothing)
                Case enmIndexcCertificateReports.CryEBCSubP
                    objDataExecute.getDataSet(ds, "RPT_EBCSelectAttach", objColCriteria, "RPT_EBCSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryFarmerCert
                    objDataExecute.getDataSet(ds, "RPT_FarmerSelect", objColCriteria, "Farmer", Nothing)
                Case enmIndexcCertificateReports.CryFarmerSub
                    objDataExecute.getDataSet(ds, "RPT_FarmerSelectAttach", objColCriteria, "RPT_FarmerSelectAttach", Nothing)

                Case enmIndexcCertificateReports.CrySolvancy_New
                    objDataExecute.getDataSet(ds, "RPT_SolvancySelect", objColCriteria, "Solvancy", Nothing)
                Case enmIndexcCertificateReports.crySolvancySub
                    objDataExecute.getDataSet(ds, "RPT_SolvancySelectAttach", objColCriteria, "RPT_SolvancySelectAttach", Nothing)

                Case enmIndexcCertificateReports.CryNominee
                    objDataExecute.getDataSet(ds, "RPT_NomineeSelect", objColCriteria, "Nominee", Nothing)
                Case enmIndexcCertificateReports.cryNomineeDetail
                    objDataExecute.getDataSet(ds, "RPT_NomineedDetailESelect", objColCriteria, "RPT_NomineedDetailESelect", Nothing)
                Case enmIndexcCertificateReports.cryNomineeSub
                    objDataExecute.getDataSet(ds, "RPT_NomineeSelectAttach", objColCriteria, "RPT_NomineeSelectAttach", Nothing)
                Case enmIndexcCertificateReports.cryWidow
                    objDataExecute.getDataSet(ds, "RPT_WidowSelect", objColCriteria, "Widow", Nothing)
                Case enmIndexcCertificateReports.cryWidowSub
                    objDataExecute.getDataSet(ds, "RPT_WidowAttach", objColCriteria, "RPT_WidowAttach", Nothing)
                Case enmIndexcCertificateReports.cryWidowP
                    objDataExecute.getDataSet(ds, "RPT_WidowSelect", objColCriteria, "Widow", Nothing)
                Case enmIndexcCertificateReports.cryWidowSubP
                    objDataExecute.getDataSet(ds, "RPT_WidowAttach", objColCriteria, "RPT_WidowAttach", Nothing)

                Case enmIndexcCertificateReports.cryOldAge
                    objDataExecute.getDataSet(ds, "RPT_OldAge", objColCriteria, "OldAge", Nothing)
                Case enmIndexcCertificateReports.cryOldAgeSub
                    objDataExecute.getDataSet(ds, "RPT_OldAgeSelectAttach", objColCriteria, "RPT_OldAgeSelectAttach", Nothing)
                Case enmIndexcCertificateReports.NRemarriage
                    objDataExecute.getDataSet(ds, "RPT_NRemarriage", objColCriteria, "NRemarriage", Nothing)
                Case enmIndexcCertificateReports.NRemarriage_Sub
                    objDataExecute.getDataSet(ds, "RPT_NRemarriageSelectAttach", objColCriteria, "RPT_NRemarriageSelectAttach", Nothing)

                Case enmIndexcCertificateReports.cryDivorce
                    objDataExecute.getDataSet(ds, "RPT_DivorceSelect", objColCriteria, "Divorce", Nothing)
                Case enmIndexcCertificateReports.cryDivorcesub
                    objDataExecute.getDataSet(ds, "RPT_DivorceSelectAttach", objColCriteria, "RPT_DivorceSelectAttach", Nothing)


                Case enmIndexcCertificateReports.Rationcard_delete
                    objDataExecute.getDataSet(ds, "RPT_RationCard_Delete", objColCriteria, "Rationcard", Nothing)
                Case enmIndexcCertificateReports.RationcardMemb_delete
                    objDataExecute.getDataSet(ds, "RPT_RationcardMemDetails_Delete", objColCriteria, "Rationcard_Attach", Nothing)

                Case enmIndexcCertificateReports.Rationcard_Add
                    objDataExecute.getDataSet(ds, "RPT_RationCard_Add", objColCriteria, "Rationcard", Nothing)
                Case enmIndexcCertificateReports.RationcardMemb_Add
                    objDataExecute.getDataSet(ds, "RPT_RationcardMemDetails_Add", objColCriteria, "Rationcard_Attach", Nothing)

                Case enmIndexcCertificateReports.Rationcard_Split_new
                    objDataExecute.getDataSet(ds, "RPT_Rationcard_Split", objColCriteria, "Rationcard", Nothing)
                Case enmIndexcCertificateReports.RationcardMemb_Split
                    objDataExecute.getDataSet(ds, "RPT_RationcardMemDetails_Split", objColCriteria, "Rationcard_Attach", Nothing)

                Case enmIndexcCertificateReports.cryCast_Buddh_en
                    objDataExecute.getDataSet(ds, "RPT_Cast_BuddhSelect", objColCriteria, "Cast_Buddh", Nothing)
                Case enmIndexcCertificateReports.cryCast_Buddh_Sub_en
                    objDataExecute.getDataSet(ds, "RPT_Cast_BuddhSelectAttach", objColCriteria, "RPT_Cast_BuddhSelectAttach", Nothing)


            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
