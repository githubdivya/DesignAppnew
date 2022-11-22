Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmWeeklyTraGatiSheelPatrak1
    GatiSheelPatrak1 = 1
    GatiSheelPatrak2 = 2

End Enum
Public Class cWeeklyTraGatiSheelPatrak1
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

            Select Case index
                Case enmWeeklyTraGatiSheelPatrak1.GatiSheelPatrak1
                    objDataExecute.getDataSet(ds, "WeeklyReportGatiSheelPatrak1_Select", objColCriteria, "patrak1", Nothing)
                Case enmWeeklyTraGatiSheelPatrak1.GatiSheelPatrak2
                    objDataExecute.getDataSet(ds, "WeeklyReportGatiSheelPatrak2_Select", objColCriteria, "patrak2", Nothing)
                Case Else

            End Select


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection


            Select Case index
                Case enmWeeklyTraGatiSheelPatrak1.GatiSheelPatrak1

                    CreateParameter(ds.Tables("patrak1"), objColCriteria, enmParameterMode.Insert, index)

                    objDataExecute.Insert("WeeklyReportGatiSheelPatrak1_Insert", objColCriteria, "patrak1", Nothing)
                Case enmWeeklyTraGatiSheelPatrak1.GatiSheelPatrak2
                    CreateParameter(ds.Tables("patrak2"), objColCriteria, enmParameterMode.Insert, index)
                    objDataExecute.Insert("WeeklyReportGatiSheelPatrak2_Insert", objColCriteria, "patrak2", Nothing)
                Case Else

            End Select


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode, ByVal index As Object)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    '    objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    '  objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, .Item("MONTHLYTRANSACTIONRPTID")))

            End Select
            objColCriteria.Add(New SqlParameter("@WeeklyTransactionRPTID", .Item("WeeklyTransactionRPTID")))
            objColCriteria.Add(New SqlParameter("@DistrictID", .Item("DistrictID")))

            objColCriteria.Add(New SqlParameter("@OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("@serviceid", .Item("ServiceID")))
            objColCriteria.Add(New SqlParameter("@DepartmentID", .Item("DepartmentID")))
            objColCriteria.Add(New SqlParameter("@DesignationID", .Item("DesignationID")))
            objColCriteria.Add(New SqlParameter("@DataEntryDesignationID", .Item("DataEntryDesignationID")))

            objColCriteria.Add(New SqlParameter("@YearMonth", .Item("YearMonth")))
            objColCriteria.Add(New SqlParameter("@week", .Item("week")))
            objColCriteria.Add(New SqlParameter("@CreatedBy", .Item("CreatedBy")))
            objColCriteria.Add(New SqlParameter("@InChargeID", .Item("InChargeID")))
            objColCriteria.Add(New SqlParameter("@MacAddress", .Item("MacAddress")))
            objColCriteria.Add(New SqlParameter("@IPAddress", .Item("IPAddress")))
            objColCriteria.Add(New SqlParameter("@Page", .Item("Page")))
            objColCriteria.Add(New SqlParameter("@ROLLID", .Item("RollId")))

            Select Case index
                Case enmWeeklyTraGatiSheelPatrak1.GatiSheelPatrak1
                    objColCriteria.Add(New SqlParameter("@AchTillLastWeek", .Item("AchTillLastWeek")))
                    objColCriteria.Add(New SqlParameter("@AchInWeek", .Item("AchInWeek")))
                    objColCriteria.Add(New SqlParameter("@CummulativeAch", .Item("CummulativeAch")))
                    objColCriteria.Add(New SqlParameter("@percentCover", .Item("percentCover")))
                Case enmWeeklyTraGatiSheelPatrak1.GatiSheelPatrak2
                    objColCriteria.Add(New SqlParameter("@SubActivityUnderTaken", .Item("SubActivityUnderTaken")))
                    objColCriteria.Add(New SqlParameter("@TangibleOutcome", .Item("TangibleOutcome")))
                    objColCriteria.Add(New SqlParameter("@ProposedActivity", .Item("ProposedActivity")))

            End Select
        End With
    End Sub
    Public Overridable Sub update(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        'Try
        '    Dim objColCriteria As New Collection
        '    CreateParameter(ds.Tables("PatrakVarsai2Consolidate"), objColCriteria, enmParameterMode.Insert)
        '    objDataExecute.Insert("PatrakVarsai2Consolidate_Insert", objColCriteria, "PatrakVarsai2Consolidate", Nothing)
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub
End Class
