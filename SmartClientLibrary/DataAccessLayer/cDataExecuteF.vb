Imports System.Data.SqlClient

Public Class cDataExecuteF
    Private _Connection As SqlConnection
    Public Sub New()
    End Sub
    Public Function getdbgroup(ByVal DBGroup As enumDBGroup, ByVal FinancalYear As Integer) As Integer
        Dim s As enumDBGroup
        s = CType([Enum].Parse(GetType(enumDBGroup), "PostMatric" + FinancalYear.ToString()), enumDBGroup)


        Return s
    End Function
    Public Function getDataSet(ByVal cmdText As String, ByVal DBGroup As enumDBGroup, ByVal FinancalYear As Integer) As DataSet
        Try

            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            End If

            Dim cmd As New System.Data.SqlClient.SqlDataAdapter(cmdText, _Connection)
            Dim dsDataSet As New DataSet
            cmd.Fill(dsDataSet)
            Return dsDataSet
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Function


    Public Sub getDataSet(ByRef dsDataSet As DataSet, ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, ByVal DBGroup As enumDBGroup, ByVal FinancalYear As Integer, Optional ByVal intConnectionTime As Integer = -1)
        Try

            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            End If
            If dsDataSet.Tables.Contains(databaseTableName) Then
                dsDataSet.Tables.Remove(databaseTableName)
            End If
            Dim param As SqlParameter
            Dim DA As New SqlDataAdapter
            DA.SelectCommand = New SqlCommand(storedProcedure, _Connection)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            If intConnectionTime <> -1 Then
                DA.SelectCommand.CommandTimeout = intConnectionTime
            End If
            If Not SPParamCollection Is Nothing Then
                For Each param In SPParamCollection
                    DA.SelectCommand.Parameters.Add(CType(param, SqlParameter))
                Next
            End If
            DA.Fill(dsDataSet, databaseTableName)
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Sub
    Public Sub getDataSetNew(ByRef dsDataSet As DataSet, ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, ByVal FinancalYear As Integer, Optional ByVal DBGroup As enumDBGroup = enumDBGroup.RCPSDB, Optional ByVal intConnectionTime As Integer = -1)
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            End If
            If dsDataSet.Tables.Contains(databaseTableName) Then
                dsDataSet.Tables.Remove(databaseTableName)
            End If
            Dim param As SqlParameter
            Dim DA As New SqlDataAdapter
            DA.SelectCommand = New SqlCommand(storedProcedure, _Connection)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            If intConnectionTime <> -1 Then
                DA.SelectCommand.CommandTimeout = intConnectionTime
            End If
            If Not SPParamCollection Is Nothing Then
                For Each param In SPParamCollection
                    DA.SelectCommand.Parameters.Add(CType(param, SqlParameter))
                Next
            End If
            DA.Fill(dsDataSet, databaseTableName)
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Sub

    Public Function Insert(ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, ByVal DBGroup As enumDBGroup, ByVal FinancalYear As Integer) As SqlParameterCollection
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            End If
            Dim param As SqlParameter
            Dim cmd As New SqlClient.SqlCommand(storedProcedure, _Connection)
            cmd.CommandType = CommandType.StoredProcedure
            If Not SPParamCollection Is Nothing Then
                For Each param In SPParamCollection
                    cmd.Parameters.Add(CType(param, SqlParameter))
                Next
            End If
            cmd.ExecuteNonQuery()
            Return cmd.Parameters
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Function
    Public Function Insert(ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, ByVal DBGroup As enumDBGroup, ByVal FinancalYear As Integer, Optional ByVal intConnectionTime As Integer = -1) As SqlParameterCollection
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(getdbgroup(DBGroup, FinancalYear))
                _Connection.Open()
            End If
            Dim param As SqlParameter
            Dim cmd As New SqlClient.SqlCommand(storedProcedure, _Connection)
            cmd.CommandType = CommandType.StoredProcedure
            If Not SPParamCollection Is Nothing Then
                For Each param In SPParamCollection
                    cmd.Parameters.Add(CType(param, SqlParameter))
                Next
            End If
            cmd.ExecuteNonQuery()
            Return cmd.Parameters
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Function







End Class
