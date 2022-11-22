Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.adminDataAccessLayer
Public Class cLinkdb
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_M_VillageLink_BISAG_Select", objColCriteria, "COM_M_VillageLink", Nothing)


    End Sub
    Public Overridable Sub GetDataSetRation1(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_M_VillageLink_Ration_Select", objColCriteria, "COM_M_VillageLink", Nothing)


    End Sub
    Public Overridable Sub GetDataSetLRC(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_M_VillageLink_LRC_Select", objColCriteria, "LRCVillage", Nothing)
    End Sub
    Public Overridable Sub GetDataSetRation(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With

        'objDataExecute.getDataSet(ds, "COM_M_VillageLink_Ration_Select", objColCriteria, "RationVillage",Nothing)
        objDataExecute.getDataSet(ds, "COM_M_VillageLink_Ration_1_Select", objColCriteria, "RationVillage", Nothing)
    End Sub

    Public Overridable Sub GetDataSetLRCDescr(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_M_VillageLink_LRC_Select_Descr", objColCriteria, "LRCVillage", Nothing)
    End Sub
    Public Overridable Sub GetDataSetRatoinDescr(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_M_VillageLink_Ration_Select_Descr", objColCriteria, "RationVillage", Nothing)
    End Sub

    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("Pvalue").ToString.Trim = "-1" Then
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                Else
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                End If
            Next
        End With

        Dim param As SqlParameter
        Dim cmd As New SqlClient.SqlCommand("COM_M_VillageLinkdb_Update", Nothing)
        cmd.CommandType = CommandType.StoredProcedure
        If Not objColCriteria Is Nothing Then
            For Each param In objColCriteria
                cmd.Parameters.Add(CType(param, SqlParameter))
            Next
        End If
        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
    End Sub

    Public Overridable Sub UpdateRation(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("Pvalue").ToString.Trim = "-1" Then
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                Else
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                End If
            Next
        End With

        Dim param As SqlParameter
        Dim cmd As New SqlClient.SqlCommand("COM_M_VillageLinkdbRation_Update", Nothing)
        cmd.CommandType = CommandType.StoredProcedure
        If Not objColCriteria Is Nothing Then
            For Each param In objColCriteria
                cmd.Parameters.Add(CType(param, SqlParameter))
            Next
        End If
        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub


    'Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
    'Dim i As Integer
    'Dim objColCriteria As New Collection
    'objColCriteria.Add(New SqlParameter("OfficeChannelID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "OfficeChannelID", DataRowVersion.Default, DBNull.Value))
    'With ds.Tables("Parameter")
    '    For i = 0 To .Rows.Count - 1
    '        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
    '    Next
    'End With
    'objDataExecute.Insert("COM_M_OfficeChannel_Insert", objColCriteria, "COM_M_OfficeChannel",Nothing)
    'Return CType(objColCriteria.Item(1), SqlParameter).Value
    ' End Function


    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
    End Function

End Class
