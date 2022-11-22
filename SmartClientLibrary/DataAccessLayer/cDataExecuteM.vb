Imports System.Data.SqlClient


Public Enum enumDBGroup
    RCPSOfficeDB = 11
    RCPSCitizenDB = 22
    RCPSAdminDB = 33
    RCPSLogDB = 44
    RCPSPhotoDB = 55
    RCPSFileDB = 66
    RCPSArchivalDB = 77
    RCPSDB = 88
    RCPSDisposeDB = 99
    RCPSSMS = 111
    SJED = 112
    CitizenLogin = 113
    RCPSCitizenDBTran = 114
    Postbefor = 115
    PostMatric20182019 = 116
    PostMatric20172018 = 117
    SchemePortal = 222
    PanchayatDB = 118
    GramPanchayatDB = 333
    CommonDBSimpleMode = 121
    CommonDBPanchayat = 122
End Enum



Public Class cDataExecuteM
    Private _Connection As SqlConnection
    Public Sub New()
    End Sub
    Public Function getDataSet(ByVal cmdText As String, ByVal DBGroup As enumDBGroup) As DataSet
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
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

    Public Sub getDataSet(ByRef dsDataSet As DataSet, ByVal storedProcedure As String, ByVal startRecord As Integer, ByVal maxRecords As Integer, ByVal CurrentRec As Integer, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal ConnectionString As String = Nothing)
        Try
            If ConnectionString = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
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
    Public Sub getDataSet(ByRef dsDataSet As DataSet, ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, ByVal DBGroup As enumDBGroup, Optional ByVal intConnectionTime As Integer = -1)
        Try

            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
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
    Public Sub getDataSetNew(ByRef dsDataSet As DataSet, ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, Optional ByVal DBGroup As enumDBGroup = enumDBGroup.RCPSDB, Optional ByVal intConnectionTime As Integer = -1)
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
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

    Public Function Insert(ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal databaseTableName As String, ByVal DBGroup As enumDBGroup) As SqlParameterCollection
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
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

    Public Function BulkInsert(ByVal storedProcedure As String, ByVal ParameterName As String, ByVal ParameterTable As DataTable, ByVal DBGroup As enumDBGroup) As SqlParameterCollection
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.Open()
            End If
            Dim cmd As New SqlClient.SqlCommand(storedProcedure, _Connection)
            cmd.CommandType = CommandType.StoredProcedure
            Dim myparam As SqlParameter = cmd.Parameters.Add(ParameterName, SqlDbType.Structured)
            myparam.Value = ParameterTable
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
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
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
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
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
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(ConnectionString)
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
    Public Sub DeleteRec(ByVal storedProcedure As String, ByVal SPParamCollection As Collection, ByVal DBGroup As enumDBGroup)
        Try
            If DBGroup = Nothing Then
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
                _Connection.Open()
            Else
                _Connection = New SqlConnection
                Dim objcn As New Cn
                _Connection.ConnectionString = objcn.NewConnectionString(DBGroup)
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
