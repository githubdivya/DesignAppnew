Imports Microsoft.VisualBasic
Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Imports System.Net
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization
Imports System.Web.UI.WebControls
Imports System
Imports System.Web
Imports NICFrameWork.LibCommon
Imports System.Threading
Imports System.IO
Imports NICFrameWork.DataAccessLayer

Public Class SchemeGeneral

    Inherits System.Web.UI.Page

    'Accept the type of command to execute

    Public Enum CmdType
        StoredProcedure
        QueryText
    End Enum

    'Accept the type of file to save on file system

    Public Enum FileType
        ImageFile
        OtherFile
    End Enum



#Region "++++++++++++++++++++++++++++++++++ Private Variables +++++++++++++++++++++++++++++++++++++"


    Private dbConnection As New SqlConnection
    Private dbAdapter As SqlDataAdapter
    Private dbCommand As SqlCommand
    Private recordTables As DataSet = New DataSet()
    Private recordTbl As DataTable = New DataTable()

#End Region
    Protected Overrides Sub OnPreLoad(e As EventArgs)
        MyBase.OnPreLoad(e)

        If IsNothing(Session("requestHostID")) And IsNothing(ViewState("requestHostID")) Then
            Session("requestHostID") = Guid.NewGuid.ToString
            ViewState("requestHostID") = Session("requestHostID")
        ElseIf IsNothing(ViewState("requestHostID")) Then
            ViewState("requestHostID") = Session("requestHostID")
        ElseIf ViewState("requestHostID") = Session("requestHostID") Then

            Session("OldRequestId") = Session("requestHostID")

            Session("requestHostID") = Nothing
            ViewState("requestHostID") = Nothing
            Session("requestHostID") = Guid.NewGuid.ToString
            ViewState("requestHostID") = Session("requestHostID")


        Else
            Response.Redirect("~/ErrorPage.aspx")

        End If


    End Sub
    Public Sub ReplacewithOldValue()


        Session("requestHostID") = Session("OldRequestId")
        ViewState("requestHostID") = Session("requestHostID")

    End Sub


#Region "++++++++++++++ Public procedures and functions for Database operations +++++++++++++++++"


    ' This is constructor of the class initialize the Connection String
    Public Sub New()
        Dim objcn As New Cn
        dbConnection.ConnectionString = objcn.NewConnectionString(enumDBGroup.SchemePortal)

    End Sub
    Public Function getConnectionString() As String
        Dim objcn As New Cn

        Return objcn.NewConnectionString(enumDBGroup.SchemePortal)
    End Function


    'This function fill records for the specified no of records from the specified start index
    Public Function FillRecords(ByVal StartIndex As Integer, ByVal NoOfRecords As Integer, ByVal CommandName As String, ByVal CommandIs As CmdType) As DataTable
        Try
            dbAdapter = New SqlDataAdapter()
            dbCommand = New SqlCommand()
            dbCommand.Connection = dbConnection
            dbCommand.CommandText = CommandName
            dbCommand.CommandType = IIf(CommandIs = CmdType.StoredProcedure, CommandType.StoredProcedure, CommandType.Text)
            dbConnection.Open()
            dbAdapter.Fill(StartIndex, NoOfRecords, recordTbl)
        Catch ex As Exception
            Throw ex
        Finally
            dbConnection.Close()
        End Try

        Return recordTbl
    End Function





    'This function fill records for the specified no of records from the specified start index
    Public Function FillRecords(ByVal StartIndex As Integer, ByVal NoOfRecords As Integer, ByVal CommandName As String, ByVal CommandIs As CmdType, ByRef ParamArr As SqlParameter()) As DataTable
        Try
            For index As Integer = 0 To ParamArr.Length - 1
                dbCommand.Parameters.Add(ParamArr.GetValue(index))
            Next

            dbAdapter = New SqlDataAdapter()
            dbCommand = New SqlCommand()
            dbCommand.Connection = dbConnection
            dbCommand.CommandText = CommandName
            dbCommand.CommandType = IIf(CommandIs = CmdType.StoredProcedure, CommandType.StoredProcedure, CommandType.Text)
            dbConnection.Open()
            dbAdapter.Fill(StartIndex, NoOfRecords, recordTbl)
        Catch ex As Exception
            Throw ex
        Finally
            dbConnection.Close()
        End Try
        Return recordTbl
    End Function





    ' This function return data table with record for specified command
    Public Function FillRecords(ByVal CommandName As String, ByVal CommandIs As CmdType) As DataTable
        If CommandIs = CmdType.StoredProcedure Then
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.StoredProcedure, CommandName)
        Else
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.Text, CommandName)
        End If
        Return IIf(recordTables.Tables.Count > 0, recordTables.Tables(0), recordTbl)
    End Function


    Public Sub FillDropDownOfficeType(ByRef DDControl As DropDownList, ByRef RecordTable As DataTable)
        If RecordTable.Rows.Count > 0 Then
            Dim DynColumn As New DataColumn()
            With DynColumn
                .ColumnName = "Office"
                .DataType = System.Type.GetType("System.String")
                .Expression = "OfficeTYpeId+','+OfficeTypeAt+','+DeptId"
            End With
            RecordTable.Columns.Add(DynColumn)
            DDControl.DataTextField = "OfficeType"
            DDControl.DataValueField = "Office"
            DDControl.DataSource = RecordTable.DefaultView
            DDControl.DataBind()
            '  DDControl.Items.Insert(0, " --- Select ---")
            DDControl.Items.Insert(0, New ListItem("Select", 0))
        Else
            DDControl.Items.Add(New ListItem(" --- No Records Found ---", "0"))
        End If
    End Sub


    ' This function return data table with record for specified command for passed parameter criteria
    Public Function FillRecords(ByVal CommandName As String, ByVal CommandIs As CmdType, ByRef ParamArr As SqlParameter()) As DataTable
        If CommandIs = CmdType.StoredProcedure Then
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.StoredProcedure, CommandName, ParamArr)
        Else
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.Text, CommandName, ParamArr)
        End If
        Return IIf(recordTables.Tables.Count > 0, recordTables.Tables(0), recordTbl)
    End Function

    ' This function return data table with record for specified command for passed parameter criteria
    Public Function FillRecords1(ByVal CommandName As String, ByVal CommandIs As CmdType, ByRef ParamArr As SqlParameter()) As DataSet
        If CommandIs = CmdType.StoredProcedure Then
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.StoredProcedure, CommandName, ParamArr)
        Else
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.Text, CommandName, ParamArr)
        End If
        If recordTables.Tables(0).Columns.Count > 0 Then
            Return recordTables
        Else
            Return Nothing
        End If

    End Function



    ' This function return single record row if exits else return record which is set nothing
    Public Function GetRecordRow(ByVal CommandName As String, ByVal CommandIs As CmdType) As DataRow
        If CommandIs = CmdType.StoredProcedure Then
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.StoredProcedure, CommandName)
        Else
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.Text, CommandName)
        End If

        Dim Record As DataRow = Nothing
        If recordTables.Tables.Count > 0 AndAlso recordTables.Tables(0).Rows.Count > 0 Then
            Record = recordTables.Tables(0).Rows(0)
        End If
        Return Record
    End Function





    ' This function return single record row if exits else return record which is set nothing for the specified parameters
    Public Function GetRecordRow(ByVal CommandName As String, ByVal CommandIs As CmdType, ByRef ParamArr As SqlParameter()) As DataRow
        If CommandIs = CmdType.StoredProcedure Then
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.StoredProcedure, CommandName, ParamArr)
        Else
            recordTables = SqlHelper.ExecuteDataset(dbConnection, CommandType.Text, CommandName, ParamArr)
        End If

        Dim Record As DataRow = Nothing
        If recordTables.Tables.Count > 0 AndAlso recordTables.Tables(0).Rows.Count > 0 Then
            Record = recordTables.Tables(0).Rows(0)
        End If
        Return Record
    End Function


    ' This function execute specified command and return No of records affected (Generally used for Insert, Update, Delete)
    Public Function ExecuteCmd(ByVal CommandName As String, ByVal CommandIs As CmdType) As Integer
        If CommandIs = CmdType.StoredProcedure Then
            Return SqlHelper.ExecuteNonQuery(dbConnection, CommandType.StoredProcedure, CommandName)
        Else
            Return SqlHelper.ExecuteNonQuery(dbConnection, CommandType.Text, CommandName)
        End If
    End Function


    ' This function execute specified command and return No of records affected (Generally used for Insert, Update, Delete)
    Public Function ExecuteCmd(ByVal CommandName As String, ByVal CommandIs As CmdType, ByVal ParamArr As SqlParameter()) As Integer
        If CommandIs = CmdType.StoredProcedure Then
            Return SqlHelper.ExecuteNonQuery(dbConnection, CommandType.StoredProcedure, CommandName, ParamArr)
        Else
            Return SqlHelper.ExecuteNonQuery(dbConnection, CommandType.Text, CommandName, ParamArr)
        End If
    End Function





    ' This function check and returns if the specified command has any result row
    Public Function HasRecord(ByVal CommandName As String, ByVal CommandIs As CmdType) As Boolean
        Dim dtReader As SqlDataReader = Nothing
        If CommandIs = CmdType.StoredProcedure Then
            dtReader = SqlHelper.ExecuteReader(dbConnection, CommandType.StoredProcedure, CommandName)
        Else
            dtReader = SqlHelper.ExecuteReader(dbConnection, CommandType.StoredProcedure, CommandName)
        End If
        Return dtReader.HasRows
    End Function





    ' This function check and returns if the specified command has any result row
    Public Function HasRecord(ByVal CommandName As String, ByVal CommandIs As CmdType, ByRef ParamArr As SqlParameter()) As Boolean
        Dim dtReader As SqlDataReader = Nothing
        If CommandIs = CmdType.StoredProcedure Then
            dtReader = SqlHelper.ExecuteReader(dbConnection, CommandType.StoredProcedure, CommandName, ParamArr)
        Else
            dtReader = SqlHelper.ExecuteReader(dbConnection, CommandType.StoredProcedure, CommandName, ParamArr)
        End If
        Return dtReader.HasRows
    End Function





    ' This function execute command that return generic any type of scalar value
    Public Function ReturnValue(ByVal CommandName As String, ByVal CommandIs As CmdType) As Object
        If CommandIs = CmdType.StoredProcedure Then
            Return SqlHelper.ExecuteScalar(dbConnection, CommandType.StoredProcedure, CommandName)
        Else
            Return SqlHelper.ExecuteScalar(dbConnection, CommandType.Text, CommandName)
        End If
    End Function




    ' This function execute command that return generic any type of scalar value
    Public Function ReturnValue(ByVal CommandName As String, ByVal CommandIs As CmdType, ByRef ParamArr As SqlParameter()) As Object
        If CommandIs = CmdType.StoredProcedure Then
            Return SqlHelper.ExecuteScalar(dbConnection, CommandType.StoredProcedure, CommandName, ParamArr)
        Else
            Return SqlHelper.ExecuteScalar(dbConnection, CommandType.Text, CommandName, ParamArr)
        End If
    End Function


#End Region



#Region "++++++++++++++++ Functions and Procedures dealing with Web Controls ++++++++++++++++++++"


    ' This procedure fill the passed drop down control from the specified data table with spcified Text and Value fields
    Public Sub FillDropDown(ByRef DDControl As DropDownList, ByRef RecordTable As DataTable, ByVal TxtField As String, ByVal ValField As String)
        With DDControl
            .Items.Clear()
            .DataSource = RecordTable
            .DataTextField = TxtField
            .DataValueField = ValField
            .DataBind()
        End With

        If DDControl.Items.Count <= 0 Then
            Dim item As New ListItem("--- No Record Found ---", "0")
            DDControl.Items.Insert(0, item)
        End If
        DDControl.SelectedIndex = 0
    End Sub





    ' This procedure fill the passed drop down control from the specified data table with spcified Text 
    ' and Value fields and add first field with specified string with it value 0 and make it selected
    Public Sub FillDropDown(ByRef DDControl As DropDownList, ByRef RecordTable As DataTable, ByVal TxtField As String, ByVal ValField As String, ByVal ZeroIndexText As String)
        With DDControl
            .Items.Clear()
            .DataSource = RecordTable
            .DataTextField = TxtField
            .DataValueField = ValField
            .DataBind()
        End With

        If DDControl.Items.Count <= 0 Then
            Dim item As New ListItem("--- No Record Found ---", "0")
            DDControl.Items.Insert(0, item)
        Else
            Dim item As New ListItem(ZeroIndexText, "0")
            DDControl.Items.Insert(0, item)
        End If
        'DDControl.SelectedValue = 0
    End Sub
    Public Sub FillDropDown2(ByRef DDControl As DropDownList, ByRef RecordTable As DataTable, ByVal TxtField As String, ByVal ValField As String)
        With DDControl
            .Items.Clear()
            .DataSource = RecordTable
            .DataTextField = TxtField
            .DataValueField = ValField
            '.SelectedIndex = 0
            .DataBind()
        End With

        If DDControl.Items.Count <= 0 Then
            Dim item As New ListItem("--- No Record Found ---", "0")
            DDControl.Items.Insert(0, item)
        Else
            'Dim item As New ListItem(ZeroIndexText, "0")
            'DDControl.Items.Insert(0, item)
        End If
        'DDControl.SelectedValue = "C01C02C03C04C05C06C07C08"
    End Sub
    'This procedure fill the passed drop down control from the specified data table with specified text
    'and value fields and also passed  selected value for the dropdown if needed

    Public Sub FillDropDown1(ByRef DDControl As DropDownList, ByRef RecordTable As DataTable)

        Dim DynColumn As New DataColumn()
        With DynColumn
            .ColumnName = "Range"
            .DataType = System.Type.GetType("System.String")
            .Expression = "MinRange+' To '+MaxRange"
        End With
        RecordTable.Columns.Add(DynColumn)

        DDControl.DataTextField = "Range"
        DDControl.DataValueField = "IncomeGRId"
        DDControl.DataSource = RecordTable.DefaultView
        DDControl.DataBind()
        Dim item As New ListItem("--- Any Income ---", "1")
        DDControl.Items.Insert(0, item)

        'With DDControl
        '    .Items.Clear()
        '    .DataSource = RecordTable
        '    .DataTextField = TxtField
        '    .DataValueField = ValField
        '    If selecteditem <> 0 Then
        '        .SelectedValue = selecteditem
        '    End If
        '    .DataBind()
        'End With

        If DDControl.Items.Count <= 0 Then
            Dim item1 As New ListItem("--- No Record Found ---", "0")
            DDControl.Items.Insert(0, item1)
            'Else
            '    Dim item As New ListItem(ZeroIndexText, "0")
            '    DDControl.Items.Insert(0, item)
        End If
        'DDControl.SelectedIndex = 0
    End Sub
    ' This procedure add a single value to specified drop down list with specified display text
    Public Sub AddSingleDDValue(ByRef DDControl As DropDownList, ByVal DisplayText As String)
        Dim item As New ListItem(DisplayText, "0")
        With DDControl
            .Items.Clear()
            .Items.Insert(0, item)
            .SelectedIndex = 0
        End With
    End Sub




    ' This procedure creates a numeric drop down list for the values specified
    Public Sub FillNumericDDValues(ByRef DDControl As DropDownList, ByVal StartValue As Integer, ByVal MaxValue As Integer, ByVal ValueGap As Integer)
        For Indexvalue As Integer = StartValue To MaxValue Step ValueGap
            Dim lstItem As New ListItem(Indexvalue.ToString(), Indexvalue.ToString())
            DDControl.Items.Add(lstItem)
        Next
    End Sub




    ' This procedure clear the grid view control data
    Public Sub ClearGridView(ByRef GVControl As GridView)
        Dim tblTemp As New DataTable()
        GVControl.DataSource = tblTemp
        GVControl.DataBind()
    End Sub
    Protected Overrides Sub InitializeCulture()

        'retrieve culture information from session
        Dim culture As String = Convert.ToString(Session("MyCulture"))
        'Dim culture As String = Convert.ToString(Request.QueryString((Session("MyCulture"))))
        'check whether a culture is stored in the session
        If (culture.Length > 0) Then
            culture = culture
        End If
        'set culture to current thread
        System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture)
        System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo(culture)

        'call base class
        'Me.InitializeCulture()
    End Sub

#End Region

    Public Function unnullD(ByVal obj As Object) As Nullable(Of Date)
        If IsDBNull(obj) Then
            Return Nothing
        End If
        Return CDate(obj)

    End Function

#Region "++++++++++++++++++ Miscelleneous Operations Functions and Procedures ++++++++++++++++++++"



    ' This functin get Unique file name for the posted file in File upload control
    Public Function GetUniqueFileName(ByRef PostedFile As HttpPostedFile) As String
        Dim fileName As String = String.Empty
        If Not String.IsNullOrEmpty(PostedFile.FileName.Trim()) Then
            Dim fileNameArr As String() = PostedFile.FileName.Trim().Split("\")
            fileName = "F" & Now.Second.ToString() & Now.Millisecond.ToString() & fileNameArr.GetValue(fileNameArr.Length - 1).ToString().Substring(0, 2)
        End If
        Return fileName
    End Function





    ' This function save posted file to file system after checking specified constraint if specified any
    Public Function SavePostedFile(ByRef PostedFile As HttpPostedFile, ByVal PathPlusFileName As String, ByVal flType As FileType, ByVal Width As Integer, ByVal Height As Integer) As String
        If flType = FileType.ImageFile Then
            Dim fileNameArr As String() = PostedFile.FileName.Trim().Split(".")
            Dim extension As String = fileNameArr.GetValue(1).ToString().ToLower()

            If Not (extension = "gif" OrElse extension = "jpg" OrElse extension = "jpeg" OrElse extension = "png" OrElse extension = "bmp") Then
                Return "Invalid Image File"
            End If

            If Width > 0 OrElse Height > 0 Then
                Dim btMap As System.Drawing.Bitmap = New System.Drawing.Bitmap(PostedFile.InputStream)
                If Not (btMap.Width = Width And btMap.Height = Height) Then
                    Return "Image Size constraint fail to match"
                End If
            End If
        End If

        PostedFile.SaveAs(PathPlusFileName)
        Return String.Empty
    End Function




    ' This function encrypt the password passed and return binary password
    Public Function EncryptPassword(ByVal Password As String) As Byte()
        Dim md5C As New MD5CryptoServiceProvider()
        Dim encoder As New UTF8Encoding
        Return md5C.ComputeHash(encoder.GetBytes(Password))
    End Function




    ' This function interchange data and month place to resolve (DD/MM/YYYY and MM/DD/YYYY)
    Public Function InterchangeDateMonth(ByVal DateString As String) As String
        Dim dtArr As String() = DateString.Trim().Split("/")
        Return dtArr.GetValue(1).ToString() & "/" & dtArr.GetValue(0).ToString() & "/" & dtArr.GetValue(2).ToString()
    End Function



    'This function returns session array
    Protected Function RetrunAnArray() As String()
        RetrunAnArray = Split(Session("Auth"), ",")
        Return RetrunAnArray

    End Function
    Public Function RetrunAnArray(ByRef Str As String) As String()
        If Str <> "" Then
            RetrunAnArray = Split(Str, ",")
            Return RetrunAnArray
        Else
            Return Nothing
        End If
    End Function

#End Region


End Class
