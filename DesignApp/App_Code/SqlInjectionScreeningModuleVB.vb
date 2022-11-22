Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports Nic.LibApp
Imports NICFrameWork.LibCommon
Imports System.Data


Public Class SqlInjectionScreeningModuleVB
    Implements IHttpModule
    'Private cinjection As sqlinjection

    Public Shared blackList As String() = {";--", "/*", "*/", "@@", "nchar", "varchar", "nvarchar",
                                            "alter", "begin", "cast", "cursor", "declare", "drop", "exec",
                                            "execute", "fetch", "kill", "open", " sys", "sysobjects", "syscolumns",
                                            "commit", "truncate", "shutdown"}
    Public Sub Dispose() Implements IHttpModule.Dispose
        'no-op
    End Sub

    Public Sub Init(ByVal app As HttpApplication) Implements IHttpModule.Init
        AddHandler app.BeginRequest, AddressOf app_BeginRequest
    End Sub

    Private Sub app_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        Dim Request As HttpRequest = TryCast(sender, HttpApplication).Context.Request
        For Each key As String In Request.QueryString

            CheckInput(Request.QueryString(key))


        Next
        For Each key As String In Request.Form

            CheckInput(Request.Form(key))


        Next
        For Each key As String In Request.Cookies

            CheckInput(Request.Cookies(key).Value)


        Next
    End Sub

    Private Sub CheckInput(ByVal parameter As String)
        For i As Integer = 0 To blackList.Length - 1
            If (parameter.IndexOf(blackList(i), StringComparison.OrdinalIgnoreCase) >= 0) Then
                'Dim dsEntry = New DataSet
                'dsEntry = New DataSet()
                'Dim sPath As String = HttpContext.Current.Request.Url.AbsolutePath
                'Dim strHostName As String

                'Dim strIPAddress As String
                'strHostName = System.Net.Dns.GetHostName()
                'strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

                'Dim objParameter As New DG_OfficeWeb.cParameter(dsEntry)
                'objParameter.CreateParameter(dsEntry, "@ip", strIPAddress, DG_OfficeWeb.enmParameterType.Input, SqlDbType.Char)
                'objParameter.CreateParameter(dsEntry, "@pageurl", sPath, DG_OfficeWeb.enmParameterType.Input, SqlDbType.Char)
                'cinjection = New sqlinjection()
                'cinjection.Update(dsEntry)
                HttpContext.Current.Response.Redirect("~/ErrorPage.aspx")
            End If
        Next
    End Sub
End Class



