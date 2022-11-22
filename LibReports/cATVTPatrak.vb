Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enmIndexATVTPatrak
    ATVTPatrak1 = 1
    ATVTPatrak2 = 2
    ATVTPatrak3 = 3
    ATVTPatrak4 = 4
    ATVTPatrak5 = 5
    ATVTPatrak6 = 6
    ATVTPatrak7 = 7
    ATVTPatrak8 = 8
    ATVTPatrak9 = 9
    ATVTPatrak10 = 10
    ATVTPatrakSubReportCommittee = 11
    ATVTPatrak123Summery = 12
    ATVTAchivement = 13
    ATVTPatrakTargetSummery_Dist = 14
    ATVTPatrakTargetSummery_Taluka = 15
    ATVTPatrakTargetSummeryByTaluka = 16
    ATVTPatrakTargetSummeryByPrant = 17
    ATVTPatrakTargetSummeryServices = 18
    RepoATVTPatrakVarsai1 = 19
    RepoATVTPatrakVarsai2 = 20
    RepoATVTPatrakVarsai3 = 21
    RepoATVTPatrakVarsaiTaluka1 = 22
    RepoATVTPatrakVarsaiTaluka2 = 23
    RepoATVTPatrakVarsaiTaluka3 = 24
    RepoATVTPatrakVarsai2Consolidate = 25
    RepoATVTPatrakVarsai2ConsolidateTaluka = 26
    RepoGatiSheelPatarak1 = 27
    RepoGatiSheelPatarak2 = 28

End Enum
Public Class cATVTPatrak
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
            Select Case CType(index, enmIndexATVTPatrak)

                Case enmIndexATVTPatrak.ATVTPatrak1
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak1", objColCriteria, "ATVT_Patrak1", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak2
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak2", objColCriteria, "ATVT_Patrak2", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak3
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak3", objColCriteria, "ATVT_Patrak3", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak4
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak4", objColCriteria, "ATVT_Patrak4", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak5
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak5", objColCriteria, "ATVT_Patrak5", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak6
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak6", objColCriteria, "ATVT_Patrak6", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak7
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak7", objColCriteria, "ATVT_Patrak7", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak8
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak8", objColCriteria, "ATVT_Patrak8", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak9
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak9", objColCriteria, "ATVT_Patrak9", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak10
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak10", objColCriteria, "ATVT_Patrak10", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrakSubReportCommittee
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patark6_Sub_Committee", objColCriteria, "ATVT_Patrak6_SubReport", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrak123Summery
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak123_summery", objColCriteria, "Summery_ATVT_Patark123", Nothing)
                Case enmIndexATVTPatrak.ATVTAchivement
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak_Achivement", objColCriteria, "ATVT_Achivement", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrakTargetSummery_Dist
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak_Target_Summery_Dist", objColCriteria, "ATVT_Target_Summery", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrakTargetSummery_Taluka
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak_Target_Summery_Taluka", objColCriteria, "ATVT_Target_Summery", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrakTargetSummeryByTaluka
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak_Target_SummeryByTaluka", objColCriteria, "ATVT_Target_Summery", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrakTargetSummeryByPrant
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak_Target_SummeryByPrant", objColCriteria, "ATVT_Target_Summery", Nothing)
                Case enmIndexATVTPatrak.ATVTPatrakTargetSummeryServices
                    objDataExecute.getDataSet(ds, "RDLC_ATVT_Patrak_Target_Summery_Service", objColCriteria, "ATVT_Target_Summery", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsai1
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai1", objColCriteria, "PatrakVarsai1", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsai2
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai2", objColCriteria, "PatrakVarsai2", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsai3
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai3", objColCriteria, "PatrakVarsai3", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsaiTaluka1
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai1", objColCriteria, "PatrakVarsai1", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsaiTaluka2
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai2", objColCriteria, "PatrakVarsai2", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsaiTaluka3
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai3", objColCriteria, "PatrakVarsai3", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsai2Consolidate
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai2Consolidate", objColCriteria, "PatrakVarsai2", Nothing)
                Case enmIndexATVTPatrak.RepoATVTPatrakVarsai2ConsolidateTaluka
                    objDataExecute.getDataSet(ds, "RPT_PatrakVarsai2Consolidate", objColCriteria, "PatrakVarsai2", Nothing)
                Case enmIndexATVTPatrak.RepoGatiSheelPatarak1
                    objDataExecute.getDataSet(ds, "RDLC_GatisheelPatarak1 ", objColCriteria, "GatisheelPatarak1", Nothing)
                Case enmIndexATVTPatrak.RepoGatiSheelPatarak2
                    objDataExecute.getDataSet(ds, "RDLC_GatisheelPatarak2", objColCriteria, "GatisheelPatarak2", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
