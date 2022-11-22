Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmRPT_m_Committee
    RPT_m_Committee = 1
    RPT_m_Committee_select = 2
    RPT_m_Committee_Find = 3
End Enum

Public Class cRPT_m_Committee

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
            Select Case CType(index, enmRPT_m_Committee)
                Case enmRPT_m_Committee.RPT_m_Committee_select
                    objDataExecute.getDataSet(ds, "RPT_m_Committee_Select", objColCriteria, "RPT_m_Committee", Nothing)
                Case enmRPT_m_Committee.RPT_m_Committee_Find
                    objDataExecute.getDataSet(ds, "RPT_m_Committee_Find", objColCriteria, "RPT_m_Committee", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("RPT_m_Committee"), objColCriteria, enmParameterMode.Update)
            objDataExecute.UpdateRec("RPT_m_Committee_Update", objColCriteria, "RPT_m_Committee", Nothing)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("COMMITTEEID", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "COMMITTEEID", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("RPT_m_Committee_Delete", objColCriteria, "RPT_m_Committee", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            Dim retval As Int32 = 0
            CreateParameter(ds.Tables("RPT_m_Committee"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("RPT_m_Committee_Insert", objColCriteria, "RPT_m_Committee", Nothing)
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
                    '   objColCriteria.Add(New SqlParameter("COMMITTEEID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "COMMITTEEID", DataRowVersion.Default, DBNull.Value))
                    objColCriteria.Add(New SqlParameter("retval", SqlDbType.Int, 4, ParameterDirection.Output, False, 4, 0, "retval", DataRowVersion.Default, .Item("retval")))
                Case enmParameterMode.Update
                    '   objColCriteria.Add(New SqlParameter("COMMITTEEID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "COMMITTEEID", DataRowVersion.Default, .Item("COMMITTEEID")))
                    objColCriteria.Add(New SqlParameter("COMMITTEEID", .Item("COMMITTEEID")))
            End Select

            objColCriteria.Add(New SqlParameter("CommitteeName", .Item("CommitteeName")))
            objColCriteria.Add(New SqlParameter("SrNo", .Item("SrNo")))
            objColCriteria.Add(New SqlParameter("DepartmentID", .Item("DepartmentID")))
            objColCriteria.Add(New SqlParameter("OfficeType", .Item("OfficeType")))
            objColCriteria.Add(New SqlParameter("DesignationID", .Item("DesignationID")))

            objColCriteria.Add(New SqlParameter("EntryDepartmentID", .Item("EntryDepartmentID")))
            objColCriteria.Add(New SqlParameter("EntryOfficeType", .Item("EntryOfficeType")))
            objColCriteria.Add(New SqlParameter("DataEntryDesignationID", .Item("DataEntryDesignationID")))

            objColCriteria.Add(New SqlParameter("DistrictID", .Item("DistrictID")))
            objColCriteria.Add(New SqlParameter("TalukaID", .Item("TalukaID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))

            objColCriteria.Add(New SqlParameter("CreatedBy", .Item("CreatedBy")))

        End With
    End Sub
End Class
