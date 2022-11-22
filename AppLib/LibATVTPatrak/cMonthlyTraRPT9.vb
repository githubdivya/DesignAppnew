Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmRPT_T_MonthlyTransactionRPT9
    RPT_T_MonthlyTransactionRPT9 = 1
End Enum

Public Class cMonthlyTransactionRPT9

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
            objDataExecute.getDataSet(ds, "MonthlyTransactionRPT9_Select", objColCriteria, "MonthlyTransactionRPT9", Nothing)
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
            objDataExecute.Insert("MonthlyTransactionRPT9_Update_Lock", objColCriteria, "MonthlyTransactionRPT9", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("RPT_T_MonthlyTransactionRPT9_Delete", objColCriteria, "MonthlyTransactionRPT9", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("MonthlyTransactionRPT9"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("MonthlyTransactionRPT9_Insert", objColCriteria, "MonthlyTransactionRPT9", Nothing)
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
                    '   objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    '   objColCriteria.Add(New SqlParameter("MONTHLYTRANSACTIONRPTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "MONTHLYTRANSACTIONRPTID", DataRowVersion.Default, .Item("MONTHLYTRANSACTIONRPTID")))
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
            objColCriteria.Add(New SqlParameter("PrantOfficer", .Item("PrantOfficer")))

            objColCriteria.Add(New SqlParameter("ApprovePost_dm", .Item("ApprovePost_dm")))
            objColCriteria.Add(New SqlParameter("AllocatePost_dm", .Item("AllocatePost_dm")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_dm", .Item("UnallocatePost_dm")))

            objColCriteria.Add(New SqlParameter("ApprovePost_clerk", .Item("ApprovePost_clerk")))
            objColCriteria.Add(New SqlParameter("AllocatePost_clerk", .Item("AllocatePost_clerk")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_clerk", .Item("UnallocatePost_clerk")))

            objColCriteria.Add(New SqlParameter("PostDyEng", .Item("PostDyEng")))
            objColCriteria.Add(New SqlParameter("AllocatePost_DEE", .Item("AllocatePost_DEE")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_DEE", .Item("UnallocatePost_DEE")))

            objColCriteria.Add(New SqlParameter("PostMEng", .Item("PostMEng")))
            objColCriteria.Add(New SqlParameter("AllocatePost_AAE", .Item("AllocatePost_AAE")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_AAE", .Item("UnallocatePost_AAE")))

            objColCriteria.Add(New SqlParameter("PostDyMamlt", .Item("PostDyMamlt")))
            objColCriteria.Add(New SqlParameter("AllocatePost_TDM", .Item("AllocatePost_TDM")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_TDM", .Item("UnallocatePost_TDM")))

            objColCriteria.Add(New SqlParameter("PostDyAcc", .Item("PostDyAcc")))
            objColCriteria.Add(New SqlParameter("AllocatePost_SubActt", .Item("AllocatePost_SubActt")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_SubActt", .Item("UnallocatePost_SubActt")))

            objColCriteria.Add(New SqlParameter("PostCleark", .Item("PostCleark")))
            objColCriteria.Add(New SqlParameter("AllocatePost_Tclerk", .Item("AllocatePost_Tclerk")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_Tclerk", .Item("UnallocatePost_Tclerk")))

            objColCriteria.Add(New SqlParameter("Remark", .Item("Remark")))
            '  objColCriteria.Add(New SqlParameter("Lock", .Item("Lock")))
            objColCriteria.Add(New SqlParameter("CreatedOn", .Item("CreatedOn")))
            objColCriteria.Add(New SqlParameter("CreatedBy", .Item("CreatedBy")))
            objColCriteria.Add(New SqlParameter("UpdatedOn", .Item("UpdatedOn")))
            objColCriteria.Add(New SqlParameter("UpdatedBy", .Item("UpdatedBy")))


            objColCriteria.Add(New SqlParameter("InChargeID", .Item("InChargeID")))
            objColCriteria.Add(New SqlParameter("MacAddress", .Item("MacAddress")))
            objColCriteria.Add(New SqlParameter("IPAddress", .Item("IPAddress")))
            objColCriteria.Add(New SqlParameter("Page", .Item("Page")))
            objColCriteria.Add(New SqlParameter("RollId", .Item("RollId")))


            objColCriteria.Add(New SqlParameter("ApprovePost_Prant", .Item("ApprovePost_Prant")))
            objColCriteria.Add(New SqlParameter("AllocatePost_Prant", .Item("AllocatePost_Prant")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_Prant", .Item("UnallocatePost_Prant")))

            objColCriteria.Add(New SqlParameter("ApprovePost_ResAsst", .Item("ApprovePost_ResAsst")))
            objColCriteria.Add(New SqlParameter("AllocatePost_ResAsst", .Item("AllocatePost_ResAsst")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_ResAsst", .Item("UnallocatePost_ResAsst")))

            objColCriteria.Add(New SqlParameter("ApprovePost_CompOper", .Item("ApprovePost_CompOper")))
            objColCriteria.Add(New SqlParameter("AllocatePost_CompOper", .Item("AllocatePost_CompOper")))
            objColCriteria.Add(New SqlParameter("UnallocatePost_CompOper", .Item("UnallocatePost_CompOper")))



        End With
    End Sub
End Class
