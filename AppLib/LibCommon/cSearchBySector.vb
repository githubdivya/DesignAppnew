Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.DataAccessLayer

Public Enum enmtblSectorMast
    tblSectorMast = 1
End Enum

Public Class cSearchBySector
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
            objDataExecuteM.getDataSet(ds, "tblSectorMast_Find", objColCriteria, "tblSectorMast", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub GetBySector(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecuteM.getDataSet(ds, "GetSectorMast", objColCriteria, "tblSectorMast", enumDBGroup.SchemePortal)
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
            objDataExecuteM.Insert("tblSectorMast_Update", objColCriteria, "tblSectorMast", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("SECTORID", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "SECTORID", DataRowVersion.Default, strCriteria))
            objDataExecuteM.Insert("tblSectorMast_Delete", objColCriteria, "tblSectorMast", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("tblSectorMast"), objColCriteria, enmParameterMode.Insert)
            objDataExecuteM.Insert("tblSectorMast_Insert", objColCriteria, "tblSectorMast", enumDBGroup.SchemePortal)
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
                    objColCriteria.Add(New SqlParameter("SECTORID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "SECTORID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("SECTORID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "SECTORID", DataRowVersion.Default, .Item("SECTORID")))
            End Select
            objColCriteria.Add(New SqlParameter("Sector", .Item("Sector")))
            objColCriteria.Add(New SqlParameter("SectorE", .Item("SectorE")))
            objColCriteria.Add(New SqlParameter("SectorImage", .Item("SectorImage")))
            objColCriteria.Add(New SqlParameter("SectorImageName", .Item("SectorImageName")))
            objColCriteria.Add(New SqlParameter("MataData", .Item("MataData")))
        End With
    End Sub
End Class
