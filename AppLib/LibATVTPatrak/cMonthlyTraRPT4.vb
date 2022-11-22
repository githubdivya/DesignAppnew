Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmMonthlyTraRPT4
    RPT_T_MonthlyTransactionRPT4 = 1
End Enum

Public Class cMonthlyTraRPT4

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
            objDataExecute.getDataSet(ds, "MonthlyTransactionRPT4_Select", objColCriteria, "MonthlyTransactionRPT4", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.Insert("RPT_T_MonthlyTransactionRPT4_Update_lock", objColCriteria, "RPT_T_MonthlyTransactionRPT4", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("RPT_T_MonthlyTransactionRPT4_Delete", objColCriteria, "RPT_T_MonthlyTransactionRPT4", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("MonthlyTransactionRPT4"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("MonthlyTransactionRPT4_Insert", objColCriteria, "MonthlyTransactionRPT4", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
    End Sub
    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    '  objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    ' objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, .Item("MONTHLYTRANSACTIONRPTID")))
            End Select
            objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", .Item("MONTHLYTRANSACTIONRPTID")))
            objColCriteria.Add(New SqlParameter("FinancialYear", .Item("FinancialYear")))
            objColCriteria.Add(New SqlParameter("YearMonth", .Item("YearMonth")))
            objColCriteria.Add(New SqlParameter("DistrictID", .Item("DistrictID")))
            objColCriteria.Add(New SqlParameter("PrantID", .Item("PrantID")))
            objColCriteria.Add(New SqlParameter("TalukaID", .Item("TalukaID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))

            objColCriteria.Add(New SqlParameter("AllocationID", .Item("AllocationID")))
            objColCriteria.Add(New SqlParameter("AllocationName", .Item("AllocationName")))
           
            objColCriteria.Add(New SqlParameter("AllocatedGrant", .Item("AllocatedGrant")))
            objColCriteria.Add(New SqlParameter("ApprovedWork", .Item("ApprovedWork")))
            objColCriteria.Add(New SqlParameter("ApprovedGrant", .Item("ApprovedGrant")))
            objColCriteria.Add(New SqlParameter("ReceivedGrant", .Item("ReceivedGrant")))

            objColCriteria.Add(New SqlParameter("UptoLastMonthusedgrant", .Item("UptoLastMonthusedgrant")))
            objColCriteria.Add(New SqlParameter("Currentmonthusedgrant", .Item("Currentmonthusedgrant")))
            objColCriteria.Add(New SqlParameter("ExpenturePercentage", .Item("ExpenturePercentage")))
            objColCriteria.Add(New SqlParameter("RemainingBalance", .Item("RemainingBalance")))

            objColCriteria.Add(New SqlParameter("UptoLastmonthOnHandWork", .Item("UptoLastmonthOnHandWork")))
            objColCriteria.Add(New SqlParameter("CurrentMonthOnHandwork", .Item("CurrentMonthOnHandwork")))
            objColCriteria.Add(New SqlParameter("TotalOnHandwork", .Item("TotalOnHandwork")))
          
            objColCriteria.Add(New SqlParameter("UptoLastmonthCompltedwork", .Item("UptoLastmonthCompltedwork")))
            objColCriteria.Add(New SqlParameter("Currenmonthcompletedwork", .Item("Currenmonthcompletedwork")))
            objColCriteria.Add(New SqlParameter("TotCompletedwork", .Item("TotCompletedwork")))
            objColCriteria.Add(New SqlParameter("NoofWorkComplCert", .Item("NoofWorkComplCert")))
          
            objColCriteria.Add(New SqlParameter("UptolastWorkInProgress", .Item("UptolastWorkInProgress")))
            objColCriteria.Add(New SqlParameter("CurrentmonthWorklInProgress", .Item("CurrentmonthWorklInProgress")))
            objColCriteria.Add(New SqlParameter("NotStartedWork", .Item("NotStartedWork")))
            objColCriteria.Add(New SqlParameter("Rejectedwork", .Item("Rejectedwork")))
            objColCriteria.Add(New SqlParameter("Totalwork", .Item("Totalwork")))

            objColCriteria.Add(New SqlParameter("Remark", .Item("Remark")))

            objColCriteria.Add(New SqlParameter("CreatedOn", .Item("CreatedOn")))
            objColCriteria.Add(New SqlParameter("CreatedBy", .Item("CreatedBy")))
            objColCriteria.Add(New SqlParameter("UpdatedOn", .Item("UpdatedOn")))
            objColCriteria.Add(New SqlParameter("UpdatedBy", .Item("UpdatedBy")))


            objColCriteria.Add(New SqlParameter("InChargeID", .Item("InChargeID")))
            objColCriteria.Add(New SqlParameter("MacAddress", .Item("MacAddress")))
            objColCriteria.Add(New SqlParameter("IPAddress", .Item("IPAddress")))
            objColCriteria.Add(New SqlParameter("Page", .Item("Page")))
            objColCriteria.Add(New SqlParameter("RollId", .Item("RollId")))

            objColCriteria.Add(New SqlParameter("TotalUsedGrant", .Item("TotalUsedGrant")))
            objColCriteria.Add(New SqlParameter("CompletedWorkPercent", .Item("CompletedWorkPercent")))

        End With
    End Sub
End Class
