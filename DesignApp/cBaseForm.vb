Option Explicit On
Option Strict On
Imports System.Configuration
Imports System.Web.Caching
Imports System.Web.UI.WebControls
Imports System.Management
Imports System.Net.NetworkInformation

Public Enum enmLanguage
    Gu = 1
    En = 2
End Enum
Public Class cBaseForm
    Inherits System.Web.UI.Page
    Private _ListScreenPageSize As Int16 = 10
    Private _EntryScreenPageSize As Int16 = 5
    Private _pageCount As Int16 = 10
    Private _intPageIndex As Integer = 0
    Public PageType As Int16
    Public refreshState As Boolean
    Private _isRefresh As Boolean
    Private Sub cBaseForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'If Not IsNothing(Session("NavigationInfo")) Then
            '    objNavigationInfo = CType(Session("NavigationInfo"), cNavigationInfo)
            'End If

            '_ConnString = My.Settings.cn

            'CreateConnection(_ConnString)
            '  Session("objAppliInfo") = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Overridable Sub SetGridLayout(ByRef dgControl As DataGrid, Optional ByVal isListScreen As Boolean = False)
        With dgControl
            If isListScreen Then
                .PageSize = _ListScreenPageSize
            Else
                .PageSize = _EntryScreenPageSize
            End If
            .PagerStyle.PageButtonCount = _pageCount
            .PagerStyle.Mode = PagerMode.NumericPages
            .PagerStyle.Position = PagerPosition.Bottom
            '.CurrentPageIndex = _intPageIndex
        End With
    End Sub
    Sub languagechanged(Optional ByVal Language As Object = 0)
        Try

            Dim culture As String = Convert.ToString(Session("MyCulture"))
            If (culture.Length > 0) Then
                culture = culture
            End If
            Select Case CType(Language, enmLanguage)
                Case enmLanguage.Gu
                    System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture)
                Case enmLanguage.En
                    System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Overrides Sub InitializeCulture()
        Try

            If IsNothing(Session("MyCulture")) Then
                Session("MyCulture") = "en-GB"
            End If
            Dim culture As String = Convert.ToString(Session("MyCulture"))
            If (culture.Length > 0) Then
                culture = culture
                System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture)
            End If

        Catch ex As Exception
            Throw ex
        End Try
        ''retrieve culture information from session
        'Dim culture As String = Convert.ToString(Session("MyCulture"))
        ''Dim culture As String = Convert.ToString(Request.QueryString((Session("MyCulture"))))
        ''check whether a culture is stored in the session
        'If (culture.Length > 0) Then
        '    culture = culture
        'End If
        ''set culture to current thread
        'System.Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.CreateSpecificCulture(culture)
        'System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(culture)

        ''call base class
        ''Me.InitializeCulture()
    End Sub
    Public Sub InitializeCulture_Other()
        InitializeCulture()

        ''retrieve culture information from session
        'Dim culture As String = Convert.ToString(Session("MyCulture"))
        ''Dim culture As String = Convert.ToString(Request.QueryString((Session("MyCulture"))))
        ''check whether a culture is stored in the session
        'If (culture.Length > 0) Then
        '    culture = culture
        'End If
        ''set culture to current thread
        'System.Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.CreateSpecificCulture(culture)
        'System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(culture)

        ''call base class
        ''Me.InitializeCulture()
    End Sub
    Public ReadOnly Property IsRefresh() As Boolean
        Get
            Return _isRefresh
        End Get
    End Property

    Protected Overrides Sub LoadViewState(ByVal savedState As Object)
        Dim allStates() As Object = CType(savedState, Object())
        MyBase.LoadViewState(allStates(0))
        refreshState = CType(allStates(1), Boolean)
        _isRefresh = refreshState = CType(Session("__ISREFRESH"), Boolean)
    End Sub

    Protected Overrides Function SaveViewState() As Object
        Session("__ISREFRESH") = refreshState
        Dim allStates() As Object = New Object(2) {}
        allStates(0) = MyBase.SaveViewState()
        allStates(1) = Not refreshState
        Return allStates
    End Function
    Public Function Get_MacAddress() As String
        Dim txtMacAddress As String = ""
        Try
            Dim nic As NetworkInterface = Nothing
            Dim mac_Address As String = ""

            For Each nic In NetworkInterface.GetAllNetworkInterfaces

                mac_Address = nic.GetPhysicalAddress().ToString
                If mac_Address <> "" Then
                    txtMacAddress = mac_Address
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return txtMacAddress
    End Function
    ' Private IP As IPEndPoint()
    'Public Function ValueSepR(ByVal RawString As String, ByVal SepChar As String) As String
    '    If InStr(1, RawString, SepChar) <> 0 Then
    '        ValueSepR = Microsoft.VisualBasic.Right(RawString, Len(RawString) - InStr(1, RawString, SepChar))
    '    Else
    '        ValueSepR = RawString
    '    End If
    'End Function
    'Public Function Get_MacAddress() As String
    '    Dim txtMacAddress As String = ""
    '    Try
    '        Dim dirResults As String
    '        Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
    '        Dim proc As New System.Diagnostics.Process()
    '        psi.FileName = "nbtstat"
    '        psi.RedirectStandardInput = False
    '        psi.RedirectStandardOutput = True
    '        psi.Arguments = "-A " & Request.UserHostAddress
    '        psi.UseShellExecute = False
    '        proc = System.Diagnostics.Process.Start(psi)
    '        Dim x As Integer = -1
    '        Do Until x > -1
    '            If dirResults <> Nothing Then
    '                x = dirResults.Trim.ToLower.IndexOf("mac address", 0)
    '                If x > -1 Then
    '                    Exit Do
    '                End If
    '            End If
    '            dirResults = proc.StandardOutput.ReadLine
    '        Loop
    '        proc.WaitForExit()
    '        txtMacAddress = ValueSepR(dirResults.Trim, "=").Trim

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    Return txtMacAddress
    'End Function
End Class
