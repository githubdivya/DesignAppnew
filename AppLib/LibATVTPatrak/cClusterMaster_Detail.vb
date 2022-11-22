Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmCOM_M_ClusterMasterdetail
    COM_D_ClusterMaster = 1
End Enum

Public Class cClusterMaster_Detail
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
            objDataExecute.getDataSet(ds, "COM_D_ClusterMaster_Select", objColCriteria, "ClusterMaster_Detail", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("ClusterMaster_Detail"), objColCriteria, enmParameterMode.Update)
            objDataExecute.UpdateRec("COM_D_ClusterMaster_Update", objColCriteria, "ClusterMaster_Detail", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
    Public Overridable Sub Delete(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.Insert("COM_D_ClusterMaster_Delete", objColCriteria, "ClusterMaster_Detail", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            Dim retval As Int32 = 0
            CreateParameter(ds.Tables("ClusterMaster_Detail"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("COM_D_ClusterMaster_Insert", objColCriteria, "ClusterMaster_Detail", Nothing)
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
                    objColCriteria.Add(New SqlParameter("retval", SqlDbType.Int, 4, ParameterDirection.Output, False, 4, 0, "retval", DataRowVersion.Default, .Item("retval")))
                    ' objColCriteria.Add(New SqlParameter("DISTRICTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "DISTRICTID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    '   objColCriteria.Add(New SqlParameter("DISTRICTID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "DISTRICTID", DataRowVersion.Default, .Item("DISTRICTID")))
            End Select

            objColCriteria.Add(New SqlParameter("DistrictId", .Item("DistrictId")))
            objColCriteria.Add(New SqlParameter("TalukaID", .Item("TalukaID")))
            objColCriteria.Add(New SqlParameter("OfficeId", .Item("OfficeId")))
            objColCriteria.Add(New SqlParameter("ClusterID", .Item("ClusterID")))
            objColCriteria.Add(New SqlParameter("VillageId", .Item("VillageId")))
            objColCriteria.Add(New SqlParameter("VillageName", .Item("VillageName")))
            objColCriteria.Add(New SqlParameter("UserId", .Item("UserId")))
        End With
    End Sub
End Class


