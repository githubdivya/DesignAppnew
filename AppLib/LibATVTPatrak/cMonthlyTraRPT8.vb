﻿Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmRPT_T_MonthlyTransactionRPT8
    RPT_T_MonthlyTransactionRPT8 = 1
End Enum

Public Class cMonthlyTransactionRPT8

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
            objDataExecute.getDataSet(ds, "MonthlyTransactionRPT8_Select", objColCriteria, "MonthlyTransactionRPT8", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria2 As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria2.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.UpdateRec("MonthlyTransactionRPT8_Update_Lock", objColCriteria2, "MonthlyTransactionRPT8", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("RPT_T_MonthlyTransactionRPT8_Delete", objColCriteria, "MonthlyTransactionRPT8", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("MonthlyTransactionRPT8"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("MonthlyTransactionRPT8_Insert", objColCriteria, "MonthlyTransactionRPT8", Nothing)
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
                    '    objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    '  objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, .Item("MONTHLYTRANSACTIONRPTID")))

            End Select
            objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", .Item("MONTHLYTRANSACTIONRPTID")))
            objColCriteria.Add(New SqlParameter("FinancialYear", .Item("FinancialYear")))
            objColCriteria.Add(New SqlParameter("YearMonth", .Item("YearMonth")))
            objColCriteria.Add(New SqlParameter("DistrictID", .Item("DistrictID")))
            'objColCriteria.Add(New SqlParameter("PrantID", .Item("PrantID")))
            objColCriteria.Add(New SqlParameter("TalukaID", .Item("TalukaID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("DepartmentID", .Item("DepartmentID")))
            objColCriteria.Add(New SqlParameter("DesignationID", .Item("DesignationID")))
            objColCriteria.Add(New SqlParameter("DataEntryDesignationID", .Item("DataEntryDesignationID")))
            objColCriteria.Add(New SqlParameter("incomeuptoLastMonth", .Item("incomeuptoLastMonth")))
            objColCriteria.Add(New SqlParameter("ExpenditureUptoLastMonth", .Item("ExpenditureUptoLastMonth")))
            objColCriteria.Add(New SqlParameter("incomeuptoCurrentMonth", .Item("incomeuptoCurrentMonth")))
            objColCriteria.Add(New SqlParameter("ExpenditureUptoCurrentMonth", .Item("ExpenditureUptoCurrentMonth")))
            objColCriteria.Add(New SqlParameter("TotalIncome", .Item("TotalIncome")))
            objColCriteria.Add(New SqlParameter("TotalExpenditure", .Item("TotalExpenditure")))
            objColCriteria.Add(New SqlParameter("TotalSaving", .Item("TotalSaving")))
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
        End With
    End Sub
End Class
