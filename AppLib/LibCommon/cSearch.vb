Imports NICFrameWork.DataAccessLayer
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class cSearch
    Inherits cBLBase
    Public Overridable Sub SearchByCategory(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "DG_SearchByCategory_Select", objColCriteria, "Search", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub SelectTabs(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "DG_Tabs_Select", objColCriteria, "Tabs", enumDBGroup.SchemePortal)
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
            objDataExecuteM.getDataSet(ds, "Select_DeptMast", objColCriteria, "Department", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub SelectSector(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "tblSectorMast_Find", objColCriteria, "SectorMaster", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub SelectLifeEvents(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_LifeEvents", objColCriteria, "tblLifeEventsMaster", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub SearchByAll(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "SearchByAll", objColCriteria, "tblSchemeMast", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub SearchSchemeByName(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "SearchSchemeByName", objColCriteria, "tblSchemeMast", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub SelectDataPanchayatAll(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "Select_DepartmentWiseServiceDashboard_All", objColCriteria, "DepartmentServicePanchayatDBAll", enumDBGroup.CommonDBPanchayat)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
