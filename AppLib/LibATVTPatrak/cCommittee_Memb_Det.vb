Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmCommittee_Memb_Det
    Committee_Memb_Det = 1
End Enum

Public Class cCommittee_Memb_Det

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
            objDataExecute.getDataSet(ds, "Committee_Memb_Det_Select", objColCriteria, "Committee_Memb_Det", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("Committee_Memb_Det"), objColCriteria, enmParameterMode.Update)
            objDataExecute.UpdateRec("Committee_Memb_Det_Update", objColCriteria, "Committee_Memb_Det", Nothing)
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
            CreateParameter(ds.Tables("Committee_Memb_Det"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("Committee_Memb_Det_Insert", objColCriteria, "Committee_Memb_Det", Nothing)
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
                    '   objColCriteria.Add(New SqlParameter("COMMITTEEID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "COMMITTEEID", DataRowVersion.Default, DBNull.Value))
                    'objColCriteria.Add(New SqlParameter("retval", SqlDbType.Int, 4, ParameterDirection.Output, False, 4, 0, "retval", DataRowVersion.Default, .Item("retval")))
                Case enmParameterMode.Update
                    '   objColCriteria.Add(New SqlParameter("COMMITTEEID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "COMMITTEEID", DataRowVersion.Default, .Item("COMMITTEEID")))
                    objColCriteria.Add(New SqlParameter("MemberId", .Item("MemberId")))
                    objColCriteria.Add(New SqlParameter("OldCommId", .Item("OldCommId")))
            End Select

            objColCriteria.Add(New SqlParameter("CommitteeID", .Item("CommitteeID")))
            objColCriteria.Add(New SqlParameter("MemberName", .Item("MemberName")))
            objColCriteria.Add(New SqlParameter("Designation", .Item("Designation")))

            objColCriteria.Add(New SqlParameter("AppointmentOrderDet", .Item("AppointmentOrderDet")))
            objColCriteria.Add(New SqlParameter("AppointmentOrderdate", .Item("AppointmentOrderdate")))

            objColCriteria.Add(New SqlParameter("CreatedBy", .Item("CreatedBy")))


            objColCriteria.Add(New SqlParameter("DistrictID", .Item("DistrictID")))
            objColCriteria.Add(New SqlParameter("TalukaID", .Item("TalukaID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))

            objColCriteria.Add(New SqlParameter("Status", .Item("Status")))

        End With
    End Sub
End Class
