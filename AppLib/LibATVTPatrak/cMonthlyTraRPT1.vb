﻿Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmMonthlyTraRPT1
    MonthlyTransactionRPT1 = 1
End Enum

Public Class cMonthlyTraRPT1

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
            '  objDataExecute.getDataSet(ds, "RPT_T_MonthlyTransactionRPT1_Select", objColCriteria, "MonthlyTraRPT1", Nothing)
            Select Case CType(index, enmMonthlyTraRPT1)
                Case enmMonthlyTraRPT1.MonthlyTransactionRPT1
                    objDataExecute.getDataSet(ds, "MonthlyTransactionRPT1_Select", objColCriteria, "MonthlyTransactionRPT1", Nothing)
            End Select
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
            objDataExecute.Insert("RPT_T_MonthlyTransactionRPT1_Update_lock", objColCriteria, "RPT_T_MonthlyTransactionRPT1", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("FINANCIALYEAR", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "FINANCIALYEAR", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("RPT_T_MonthlyTransactionRPT1_Delete", objColCriteria, "RPT_T_MonthlyTransactionRPT1", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("MonthlyTransactionRPT1"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("MonthlyTransactionRPT1_Insert", objColCriteria, "MonthlyTransactionRPT1", Nothing)
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
                    'objColCriteria.Add(New SqlParameter("FINANCIALYEAR", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "FINANCIALYEAR", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    '  objColCriteria.Add(New SqlParameter("FINANCIALYEAR", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "FINANCIALYEAR", DataRowVersion.Default, .Item("FINANCIALYEAR")))
            End Select
            objColCriteria.Add(New SqlParameter("FINANCIALYEAR", .Item("FINANCIALYEAR")))
            objColCriteria.Add(New SqlParameter("YearMonth", .Item("YearMonth")))
            objColCriteria.Add(New SqlParameter("DistrictID", .Item("DistrictID")))
            objColCriteria.Add(New SqlParameter("TalukaID", .Item("TalukaID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("DepartmentID", .Item("DepartmentID")))
            objColCriteria.Add(New SqlParameter("DesignationID", .Item("DesignationID")))
            objColCriteria.Add(New SqlParameter("DataEntryDesignationID", .Item("DataEntryDesignationID")))
            objColCriteria.Add(New SqlParameter("SrNo", .Item("SrNo")))
            objColCriteria.Add(New SqlParameter("SubSrNo", .Item("SubSrNo")))
            objColCriteria.Add(New SqlParameter("ServiceID", .Item("ServiceID")))
            objColCriteria.Add(New SqlParameter("PhysicalTarget", .Item("PhysicalTarget")))
            objColCriteria.Add(New SqlParameter("FinancialTarget", .Item("FinancialTarget")))
            objColCriteria.Add(New SqlParameter("PhyLastMonth", .Item("PhyLastMonth")))
            objColCriteria.Add(New SqlParameter("PhyCurrntMonth", .Item("PhyCurrntMonth")))
            objColCriteria.Add(New SqlParameter("PhyTotal", .Item("PhyTotal")))
            objColCriteria.Add(New SqlParameter("FinLastMonth", .Item("FinLastMonth")))
            objColCriteria.Add(New SqlParameter("FinCurrentMonth", .Item("FinCurrentMonth")))
            objColCriteria.Add(New SqlParameter("FinTotal", .Item("FinTotal")))
            objColCriteria.Add(New SqlParameter("Remark", .Item("Remark")))

            objColCriteria.Add(New SqlParameter("CreatedOn", .Item("CreatedOn")))
            objColCriteria.Add(New SqlParameter("CreatedBy", .Item("CreatedBy")))
            objColCriteria.Add(New SqlParameter("UpdatedOn", .Item("UpdatedOn")))
            objColCriteria.Add(New SqlParameter("UpdatedBy", .Item("UpdatedBy")))

            objColCriteria.Add(New SqlParameter("MonthlyTransactionRPTID", .Item("MonthlyTransactionRPTID")))



            objColCriteria.Add(New SqlParameter("InChargeID", .Item("InChargeID")))
            objColCriteria.Add(New SqlParameter("MacAddress", .Item("MacAddress")))
            objColCriteria.Add(New SqlParameter("IPAddress", .Item("IPAddress")))
            objColCriteria.Add(New SqlParameter("Page", .Item("Page")))
            objColCriteria.Add(New SqlParameter("RollId", .Item("RollId")))

            objColCriteria.Add(New SqlParameter("PhyAchvmnt", .Item("PhyAchvmnt")))
            objColCriteria.Add(New SqlParameter("FinAchvmnt", .Item("FinAchvmnt")))

            objColCriteria.Add(New SqlParameter("SubDeptId", .Item("SubDeptId")))
        End With
    End Sub
End Class
