Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enmIndexAffidaviteReports
    crAffIncome = 832
    crAffIncomeStamp = 833
    crAffIncomeNonCry = 1202
    crAffIncomeNonCryStamp = 1203
    crAffWidowHelp = 842
    crAffWidowHelpStamp = 843
    crAffReady = 852
    crAffReadyStamp = 853
    crAffReadyStampEn = 854
    crAffReadyEn = 851
    crAffRation = 862
    crAffRationStamp = 863
    crAffSolvancy = 952
    crAffSolvancyStamp = 953
    crAffRatCardComp = 962
    crAffRatCardCompStamp = 963
    crAffNameChange = 972
    crAffNameChangeStamp = 973
    crAffLoan = 982
    crAffLoanStamp = 983
    crAffLeavingCerti = 992
    crAffLeavingCertiStamp = 993
    crAffHouse = 1002
    crAffHouseStamp = 1003
    crAffCaste = 872
    crAffCasteStamp = 873
    crBDateCh = 1012
    crBDateChStamp = 1013
    crAffRatCardDupli = 3372
    crAffRatCardDupliSub = 33721
    crAffRatCardDupliStamp = 3373
    crAffRatCardDupliStampSub = 33731
End Enum
Public Interface IAffidaviteController

End Interface
Public Class cAffidaviteController
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
            Select Case CType(index, enmIndexAffidaviteReports)
                Case enmIndexAffidaviteReports.crAffWidowHelp
                    objDataExecute.getDataSet(ds, "RPT_AFF_WidowHelp", objColCriteria, "AffWidowHelp", Nothing)
                Case enmIndexAffidaviteReports.crAffWidowHelpStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_WidowHelp", objColCriteria, "AffWidowHelpStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffIncome
                    objDataExecute.getDataSet(ds, "RPT_AFF_Income", objColCriteria, "AffIncome", Nothing)
                Case enmIndexAffidaviteReports.crAffIncomeStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_Income", objColCriteria, "AffIncomeStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffIncomeNonCry
                    objDataExecute.getDataSet(ds, "RPT_AFF_Income_NonCry", objColCriteria, "AffIncomeNonCry", Nothing)
                Case enmIndexAffidaviteReports.crAffIncomeNonCryStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_Income_NonCry", objColCriteria, "AffIncomeNonCryStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffReady
                    objDataExecute.getDataSet(ds, "RPT_AFF_Ready", objColCriteria, "AffReady", Nothing)
                Case enmIndexAffidaviteReports.crAffReadyEn
                    objDataExecute.getDataSet(ds, "RPT_AFF_Ready", objColCriteria, "AffReady", Nothing)
                Case enmIndexAffidaviteReports.crAffReadyStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_Ready", objColCriteria, "AffReady", Nothing)
                Case enmIndexAffidaviteReports.crAffReadyStampEn
                    objDataExecute.getDataSet(ds, "RPT_AFF_Ready", objColCriteria, "AffReady", Nothing)
                Case enmIndexAffidaviteReports.crAffRation
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCard", objColCriteria, "AffRation", Nothing)
                Case enmIndexAffidaviteReports.crAffRationStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCard", objColCriteria, "AffRationStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffSolvancy
                    objDataExecute.getDataSet(ds, "RPT_AFF_Solvancy", objColCriteria, "AffSolvancy", Nothing)
                Case enmIndexAffidaviteReports.crAffSolvancyStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_Solvancy", objColCriteria, "AffSolvancyStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffRatCardComp
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCardComp", objColCriteria, "AffRatCardComp", Nothing)
                Case enmIndexAffidaviteReports.crAffRatCardCompStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCardComp", objColCriteria, "AffRatCardCompStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffNameChange
                    objDataExecute.getDataSet(ds, "RPT_AFF_NameChange", objColCriteria, "AffNameChange", Nothing)
                Case enmIndexAffidaviteReports.crAffNameChangeStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_NameChange", objColCriteria, "AffNameChangeStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffLoan
                    objDataExecute.getDataSet(ds, "RPT_AFF_Loan", objColCriteria, "AffLoan", Nothing)
                Case enmIndexAffidaviteReports.crAffLoanStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_Loan", objColCriteria, "AffLoanStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffLeavingCerti
                    objDataExecute.getDataSet(ds, "RPT_AFF_LeavingCerti", objColCriteria, "AffLeavingCerti", Nothing)
                Case enmIndexAffidaviteReports.crAffLeavingCertiStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_LeavingCerti", objColCriteria, "AffLeavingCertiStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffHouse
                    objDataExecute.getDataSet(ds, "RPT_AFF_House", objColCriteria, "AffHouse", Nothing)
                Case enmIndexAffidaviteReports.crAffHouseStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_House", objColCriteria, "AffHouseStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffCaste
                    objDataExecute.getDataSet(ds, "RPT_AFF_Caste", objColCriteria, "AffCaste", Nothing)
                Case enmIndexAffidaviteReports.crAffCasteStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_Caste", objColCriteria, "AffCasteStamp", Nothing)


                Case enmIndexAffidaviteReports.crAffRatCardDupli
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCardDupli", objColCriteria, "AffRatCardDupli", Nothing)
                Case enmIndexAffidaviteReports.crAffRatCardDupliSub
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCardDupliDetailSelect", objColCriteria, "AffRatCardDupliSub", Nothing)
                Case enmIndexAffidaviteReports.crAffRatCardDupliStamp
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCardDupli", objColCriteria, "AffRatCardDupliStamp", Nothing)
                Case enmIndexAffidaviteReports.crAffRatCardDupliStampSub
                    objDataExecute.getDataSet(ds, "RPT_AFF_RatCardDupliDetailSelect", objColCriteria, "AffRatCardDupliStampSub", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
  

End Class
