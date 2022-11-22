Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmReportMaster
    ReportMaster = 1
End Enum

Public Class cReportMaster
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
            objDataExecute.getDataSet(ds, "RPT_M_ReportMaster_Find", objColCriteria, "ReportMaster", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("ReportMaster"), objColCriteria, enmParameterMode.Update)
            objDataExecute.UpdateRec("T_ReportMaster_Update", objColCriteria, "ReportMaster", Nothing)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("Applno", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "Applno", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("T_ReportMaster_Delete", objColCriteria, "ReportMaster", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            Dim retval As Int32 = 0
            CreateParameter(ds.Tables("ReportMaster"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("RPT_M_ReportMaster_Insert", objColCriteria, "ReportMaster", Nothing)
            retval = objColCriteria(1).Value
            Return retval
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
    End Sub
    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    'objColCriteria.Add(New SqlParameter("ApplNo", .Item("Applno")))
                    objColCriteria.Add(New SqlParameter("retval", SqlDbType.Int, 4, ParameterDirection.Output, False, 4, 0, "retval", DataRowVersion.Default, .Item("retval")))
                Case enmParameterMode.Update
                    'objColCriteria.Add(New SqlParameter("ApplNo", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "ApplNo", DataRowVersion.Default, .Item("ApplNo")))
                    '  objColCriteria.Add(New SqlParameter("ApplNo", .Item("ApplNo")))
            End Select

            objColCriteria.Add(New SqlParameter("SrNo", .Item("SrNo")))
            objColCriteria.Add(New SqlParameter("SubSrNo", .Item("SubSrNo")))

            objColCriteria.Add(New SqlParameter("ReportID", .Item("ReportID")))
            objColCriteria.Add(New SqlParameter("ReportName", .Item("ReportName")))

            objColCriteria.Add(New SqlParameter("DepartmentID", .Item("DepartmentID")))
            objColCriteria.Add(New SqlParameter("OfficeType", .Item("OfficeType")))
            objColCriteria.Add(New SqlParameter("DesignationID", .Item("DesignationID")))
            objColCriteria.Add(New SqlParameter("DataEntryDesignationID", .Item("DataEntryDesignationID")))

            objColCriteria.Add(New SqlParameter("ServiceID", .Item("ServiceID")))

            objColCriteria.Add(New SqlParameter("CreatedOn", .Item("CreatedOn")))
            objColCriteria.Add(New SqlParameter("CreatedBy", .Item("CreatedBy")))

            objColCriteria.Add(New SqlParameter("UpdatedOn", .Item("UpdatedOn")))
            objColCriteria.Add(New SqlParameter("UpdatedBy", .Item("UpdatedBy")))

            objColCriteria.Add(New SqlParameter("EntryDepartmentID", .Item("EntryDepartmentID")))
            objColCriteria.Add(New SqlParameter("EntryOfficeType", .Item("EntryOfficeType")))

            objColCriteria.Add(New SqlParameter("ReportMasterID", .Item("ReportMasterID")))

            objColCriteria.Add(New SqlParameter("SubDeptId", .Item("SubDeptId")))

        End With
    End Sub
End Class
