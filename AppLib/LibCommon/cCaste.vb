
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmCaste
    Cast = 1
    CastSCST = 2
    CastOBC = 3
End Enum
Public Class cCaste

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
            Select Case CType(index, enmCaste)
                Case enmCaste.Cast
                    objDataExecute.getDataSet(ds, "COM_M_Caste_Select", objColCriteria, "Caste", Nothing)
                Case enmCaste.CastSCST
                    objDataExecute.getDataSet(ds, "COM_M_Caste_SC_ST_Find", objColCriteria, "Caste", Nothing)
                Case enmCaste.CastOBC
                    objDataExecute.getDataSet(ds, "COM_M_Caste_OBC_Select", objColCriteria, "Caste", Nothing)
                Case Else
                    objDataExecute.getDataSet(ds, "COM_M_Caste_Select", objColCriteria, "Caste", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub GetDataSet_SCST(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.getDataSet(ds, "COM_M_Caste_SC_ST_Find", objColCriteria, "Caste", Nothing)
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
            objDataExecute.Insert("COM_M_Caste_Update", objColCriteria, "Caste", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("code", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "code", DataRowVersion.Default, strCriteria))

            objDataExecute.Insert("COM_M_Caste_Delete", objColCriteria, "Caste", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try

            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("Caste"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("COM_M_Caste_Insert", objColCriteria, "Caste", Nothing)
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
                    objColCriteria.Add(New SqlParameter("Code", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "Code", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("Code", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "Code", DataRowVersion.Default, .Item("Code")))
            End Select
            ' objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("UserID", .Item("UserID")))
            '  objColCriteria.Add(New SqlParameter("RoleID", .Item("RoleID")))
            objColCriteria.Add(New SqlParameter("DescGuj", .Item("DescGuj")))
            objColCriteria.Add(New SqlParameter("DescEng", .Item("DescEng")))
            objColCriteria.Add(New SqlParameter("GovtNO", .Item("GovtNO")))
            objColCriteria.Add(New SqlParameter("CasteType", .Item("CasteType")))

            objColCriteria.Add(New SqlParameter("id_Proof_EPIC_no", .Item("id_Proof_EPIC_no")))
            objColCriteria.Add(New SqlParameter("id_Proof_EPIC_no_verify", .Item("id_Proof_EPIC_no_verify")))

            objColCriteria.Add(New SqlParameter("BPL_NO", .Item("BPL_NO")))
            objColCriteria.Add(New SqlParameter("BPL_NO_verify", .Item("BPL_NO_verify")))

            objColCriteria.Add(New SqlParameter("G_REGNO", .Item("G_REGNO")))
            objColCriteria.Add(New SqlParameter("G_REGNO_verify", .Item("G_REGNO_verify")))

            objColCriteria.Add(New SqlParameter("InChargeID", .Item("InChargeID")))
            objColCriteria.Add(New SqlParameter("MacAddress", .Item("MacAddress")))
            objColCriteria.Add(New SqlParameter("IPAddress", .Item("IPAddress")))
            objColCriteria.Add(New SqlParameter("Page", .Item("Page")))
            objColCriteria.Add(New SqlParameter("Remarks", .Item("Remarks")))


        End With
    End Sub
End Class




