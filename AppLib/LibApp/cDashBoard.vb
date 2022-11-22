Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmDashboard
    Select_counteGramDashboard = 1
    Select_counteGramDashboard_rcps = 5
    Select_Departments = 2
    Select_GridDataForCivil = 3
    Select_GridDataForPanchayat = 4
    Select_ServiceList_PanchayatDB = 6
    Select_GramPanchyat_PanchayatDB = 7
    Select_ServiceList_RCPSDB = 8
    Select_GramPanchyat_RCPSDB = 9
    Select_DepartmentWiseServiceDashboard = 10
    FrmGrampanchayatCount = 11

End Enum
Public Class cDashBoard
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
            Select Case CType(index, enmDashboard)

                Case enmDashboard.Select_counteGramDashboard
                    objDataExecuteM.getDataSet(ds, "Select_counteGramDashboard", objColCriteria, "Select_counteGramDashboard", enumDBGroup.PanchayatDB)
                Case enmDashboard.Select_counteGramDashboard_rcps
                    objDataExecuteM.getDataSet(ds, "Select_counteGramDashboard_rcps", objColCriteria, "Select_counteGramDashboard_rcps", enumDBGroup.RCPSDB)

            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub GetGridDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            Select Case CType(index, enmDashboard)

                Case enmDashboard.Select_GridDataForCivil
                    objDataExecuteM.getDataSet(ds, "RPT_MIS_SUMMARY_SERVICE_WISE_WCD_GP_Dashboard", objColCriteria, "RPT_MIS_SUMMARY_SERVICE_WISE_WCD_GP", enumDBGroup.PanchayatDB)
                Case enmDashboard.Select_GridDataForPanchayat
                    objDataExecuteM.getDataSet(ds, "RPT_MIS_SUMMARY_SERVICE_WISE_Egram_Dashboard", objColCriteria, "RPT_MIS_SUMMARY_SERVICE_WISE_Egram", enumDBGroup.RCPSDB)

            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub SelectDepartment(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_Departments", objColCriteria, "Department", enumDBGroup.PanchayatDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub SelectDepartment_RCPS(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_Departments_rcps", objColCriteria, "Department_rcps", enumDBGroup.RCPSDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Select_ServiceList_PanchayatDB(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_TopService", objColCriteria, "Top_Service", enumDBGroup.PanchayatDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Select_GramPanchyat_PanchayatDB(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_TopGramPanchayat", objColCriteria, "Top_GramPanchayat", enumDBGroup.PanchayatDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Select_ServiceList_RCPSDB(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_TopService", objColCriteria, "Top_Service", enumDBGroup.RCPSDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Select_GramPanchyat_RCPSDB(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_TopGramPanchayat", objColCriteria, "Top_GramPanchayat", enumDBGroup.RCPSDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Select_DepartmentWiseServiceDashboardPanchayat(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_DepartmentWiseServiceDashboard", objColCriteria, "DepartmentServicePanchayatDB", enumDBGroup.PanchayatDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub FrmGrampanchayatCount(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Grampanchayatcount", objColCriteria, "Grampanchayatcount", enumDBGroup.PanchayatDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Select_DepartmentWiseServiceDashboardRCPSDB(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_DepartmentWiseServiceDashboard", objColCriteria, "DepartmentServiceRCPSDB", enumDBGroup.RCPSDB)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Overridable Sub RCPSDBServiceWiseCount(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
    '    Dim i As Integer
    '    Dim objColCriteria As New Collection
    '    With ds.Tables("Parameter")
    '        For i = 0 To .Rows.Count - 1
    '            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
    '        Next
    '    End With
    '    objDataExecuteM.getDataSet(ds, "CON_MIS_EGRAM", objColCriteria, "T_Receipt", enumDBGroup.RCPSDB)
    'End Sub

    'Public Overridable Sub PanchayatDBServiceWiseCount(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
    '    Dim i As Integer
    '    Dim objColCriteria As New Collection
    '    With ds.Tables("Parameter")
    '        For i = 0 To .Rows.Count - 1
    '            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
    '        Next
    '    End With
    '    objDataExecuteM.getDataSet(ds, "CON_MIS_EGRAM", objColCriteria, "T_ReceiptPanchayatDB", enumDBGroup.PanchayatDB)
    'End Sub

    'Public Overridable Sub GramPanchayatDBServiceWiseCount(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
    '    Dim i As Integer
    '    Dim objColCriteria As New Collection
    '    With ds.Tables("Parameter")
    '        For i = 0 To .Rows.Count - 1
    '            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
    '        Next
    '    End With
    '    objDataExecuteM.getDataSet(ds, "CON_MIS_EGRAM", objColCriteria, "T_ReceiptGramPanchayatDB", enumDBGroup.GramPanchayatDB)
    'End Sub

    'Public Overridable Sub PanchayatDBOtherServiceCount(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
    '    Dim i As Integer
    '    Dim objColCriteria As New Collection
    '    With ds.Tables("Parameter")
    '        For i = 0 To .Rows.Count - 1
    '            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
    '        Next
    '    End With
    '    objDataExecuteM.getDataSet(ds, "CON_MIS_EGRAM_otherapp", objColCriteria, "T_ReceiptOther", enumDBGroup.PanchayatDB)
    'End Sub

    'Public Overridable Sub InsertTopGramPanchayat(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
    '    Dim i As Integer
    '    Dim objColCriteria As New Collection
    '    With ds.Tables("Parameter")
    '        For i = 0 To .Rows.Count - 1
    '            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
    '        Next
    '    End With
    '    objDataExecuteM.Insert("Insert_Top_GramPanchayat", objColCriteria, "Top_GramPanchayat", enumDBGroup.PanchayatDB)
    'End Sub

    'Public Overridable Sub InsertTopServices(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
    '    Dim i As Integer
    '    Dim objColCriteria As New Collection
    '    With ds.Tables("Parameter")
    '        For i = 0 To .Rows.Count - 1
    '            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
    '        Next
    '    End With
    '    objDataExecuteM.Insert("Insert _TopServices", objColCriteria, "Top_Service", enumDBGroup.PanchayatDB)
    'End Sub

    'Public Overridable Sub BulkImportDemo(ByRef ds As DataSet, ByVal ParamenterName As String, ByVal ParameterTable As DataTable, Optional ByVal PType As enmParameterType = enmParameterType.Input, Optional ByVal DBType As SqlDbType = SqlDbType.Int)

    '    objDataExecuteM.BulkInsert("SP_BulkImportDemo", ParamenterName, ParameterTable, enumDBGroup.PanchayatDB)
    'End Sub

End Class
