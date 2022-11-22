Imports System.Data.SqlClient
Public Class cDataExecute
    Private _Connection As SqlConnection
    Public Sub New()
    End Sub
    Public Function getDataSet(ByVal cmdText As String, Optional ByVal ConnectionString As String = Nothing) As DataSet
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
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
    'Public Function getDataSet(ByVal cmdText As String, Optional ByVal ConnectionString As String = Nothing, Optional ByVal ConnectionTime As Integer = -1) As DataSet
    '    Try
    '        If ConnectionString = Nothing Then
    '            _Connection = New SqlConnection
    '            _Connection.ConnectionString = My.Settings.rcps_cn
    '            _Connection.Open()
    '        End If

    '        Dim cmd As New SqlCommand
    '        cmd.CommandText = cmdText
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = _Connection
    '        If ConnectionTime <> -1 Then
    '            cmd.CommandTimeout = ConnectionTime
    '        End If
    '        Dim da As New System.Data.SqlClient.SqlDataAdapter()
    '        Dim dsDataSet As New DataSet
    '        da.SelectCommand = cmd
    '        da.Fill(dsDataSet)
    '        Return dsDataSet
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        _Connection.Dispose()
    '    End Try
    'End Function
    Public Sub getDataSet(ByRef dsDataSet As DataSet, ByVal storedProcedure As String, ByVal startRecord As Integer, ByVal maxRecords As Integer, ByVal CurrentRec As Integer, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing)
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
                _Connection.Open()
            End If
            If dsDataSet.Tables.Contains(databaseTableName) Then
                dsDataSet.Tables.Remove(databaseTableName)
            End If
            If startRecord = -1 Then
                startRecord = 0
                maxRecords = 0
            End If
            Dim param As SqlParameter
            Dim DA As New SqlDataAdapter
            DA.SelectCommand = New SqlCommand(storedProcedure, _Connection)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            If Not SPParamCollection Is Nothing Then
                For Each param In SPParamCollection
                    DA.SelectCommand.Parameters.Add(CType(param, SqlParameter))
                Next
            End If
            DA.Fill(dsDataSet, startRecord, maxRecords, databaseTableName)

        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Sub
    Public Sub getDataSet(ByRef dsDataSet As DataSet, ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing, Optional ByVal intConnectionTime As Integer = -1)
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
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

    Public Sub getDataTable(ByRef dsDataSet As DataTable, ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing, Optional ByVal intConnectionTime As Integer = -1)
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
                _Connection.Open()
            End If
            'If dsDataSet.Columns.Contains(databaseTableName) Then
            '    dsDataSet.Remove(databaseTableName)
            'End If
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
            DA.Fill(dsDataSet)
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Sub
    Public Function Insert(ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing) As SqlParameterCollection
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
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

    Public Function BulkCopy(ByVal ds As DataSet, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing) As Integer
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
                _Connection.Open()
            End If
            Dim trans As SqlTransaction = Nothing
            trans = _Connection.BeginTransaction

            Dim sqlSQLServerBulkCopy As New SqlBulkCopy(_Connection, SqlBulkCopyOptions.KeepNulls, trans)
            sqlSQLServerBulkCopy.BatchSize = ds.Tables("FeeDetails").Rows.Count
            sqlSQLServerBulkCopy.DestinationTableName = databaseTableName

            'Dim J As Integer
            'For J = 0 To ds.Tables(databaseTableName).Columns.Count - 1
            '    With ds.Tables(databaseTableName).Columns(J)
            '        ' objColCriteria.Add(New SqlParameter("@" & .ColumnName.ToString, ds.Tables("PH_ID_APL").Rows(0).Item(J)))
            '        sqlSQLServerBulkCopy.ColumnMappings.Add(.ColumnName.ToString, .ColumnName.ToString)
            '    End With
            'Next
            If ds.Tables("FeeDetails").Rows.Count > 0 Then
                'Dim sqlSQLServerBulkCopy As New SqlBulkCopy(rcps_cn, SqlBulkCopyOptions.KeepNulls, trans)
                'sqlSQLServerBulkCopy.BatchSize = ds.Tables("FeeDetails").Rows.Count
                'sqlSQLServerBulkCopy.DestinationTableName = "REG_D_FeeDetails"

                sqlSQLServerBulkCopy.ColumnMappings.Add("RoleID", "RoleID")
                sqlSQLServerBulkCopy.ColumnMappings.Add("OfficeID", "OfficeID")
                sqlSQLServerBulkCopy.ColumnMappings.Add("DocumentNo", "DocumentNo")
                sqlSQLServerBulkCopy.ColumnMappings.Add("DocumentYear", "DocumentYear")
                sqlSQLServerBulkCopy.ColumnMappings.Add("FeesType", "FeesType")
                sqlSQLServerBulkCopy.ColumnMappings.Add("Amount", "Amount")
                sqlSQLServerBulkCopy.ColumnMappings.Add("FeesID", "FeesID")
                sqlSQLServerBulkCopy.ColumnMappings.Add("DocApp", "DocApp")
                'sqlSQLServerBulkCopy.ColumnMappings.Add("UpdatedOn", "UpdatedOn")
                sqlSQLServerBulkCopy.ColumnMappings.Add("UserID", "CreatedBy")
                ' sqlSQLServerBulkCopy.WriteToServer(ds.Tables("FeeDetails"))
                'sqlSQLServerBulkCopy.Close()
                ''end F7ax
            End If
            sqlSQLServerBulkCopy.WriteToServer(ds.Tables("FeeDetails"))
            sqlSQLServerBulkCopy.Close()
            trans.Commit()
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
        Return 1
    End Function

    Public Sub UpdateRec(ByVal storedProcedure As String, ByVal ds As DataSet, ByVal batchSize As Int32, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing)
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
                _Connection.Open()
            End If
            Dim param As SqlParameter

            Dim adapter As New SqlClient.SqlDataAdapter

            Dim objColCriteria As New Collection


            adapter.UpdateCommand = New SqlCommand(storedProcedure, _Connection)
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure

            For Each param In SPParamCollection
                adapter.InsertCommand.Parameters.Add(CType(param, SqlParameter))
            Next
            adapter.UpdateCommand.UpdatedRowSource = _
            UpdateRowSource.None

            'adapter.UpdateBatchSize = batchSize
            Dim cbilder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
            adapter.Update(ds.Tables(databaseTableName))

        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Sub
    Public Sub UpdateRec(ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing)
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
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
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Sub
    Public Sub DeleteRec(ByVal storedProcedure As String, ByVal SPParamCollection As Collection, Optional ByVal ConnectionString As String = Nothing)
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                _Connection.ConnectionString = My.Settings.rcps_cn
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
        Catch ex As Exception
            Throw ex
        Finally
            _Connection.Dispose()
        End Try
    End Sub

End Class
