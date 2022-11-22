Imports System.Web.SessionState
Imports System.Security.Cryptography
Imports NIC.LibApp

Public Class Global_asax
    Inherits System.Web.HttpApplication
    Private dsEntry As New DataSet

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        Dim objCRUD As New cMap
        dsEntry = New DataSet
        Dim objParameter = New cParameter(dsEntry)

        objCRUD.GetDataSet(dsEntry, enmcMap.VersionShow)
        Dim Version As String = dsEntry.Tables("VersionShow").Rows(0).Item("Version")
        Dim LastUpdatedDate As String = dsEntry.Tables("VersionShow").Rows(0).Item("Msg")
        Application("version") = Version
        Application("LastUpdatedDate") = LastUpdatedDate
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
        Dim objCRUD As New cmap
        dsEntry = New DataSet
        Dim objParameter = New cParameter(dsEntry)
        objCRUD.GetDataSet(dsEntry, enmcMap.VisiterCounter)
        Dim counter As Integer = dsEntry.Tables("VisiterCounter").Rows(0).Item("counter")
        Application("counter") = counter
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
        ' Fires at the beginning of each request
        If Request.Cookies("ASP.NET_SessionId") IsNot Nothing AndAlso Request.Cookies("ASP.NET_SessionId").Value IsNot Nothing Then
            Dim newSessionID As String = Request.Cookies("ASP.NET_SessionID").Value
            'Check the valid length of your Generated Session ID
            If newSessionID.Length <= 24 Then
                'Log the attack details here
                Response.Cookies("TriedTohack").Value = "True"
                'Response.Redirect("~/NoPermission.aspx")
                'Dim myCookies As String() = Request.Cookies.AllKeys
                'For Each cookie As String In myCookies
                '    Response.Cookies(cookie).Expires = DateTime.Now.AddDays(-1)
                'Next
                ' Application_Error(sender, e)
                'Throw New HttpException("Invalid Request")

            End If

            'Genrate Hash key for this User,Browser and machine and match with the Entered NewSessionID
            If GenerateHashKey() <> newSessionID.Substring(24) Then
                'Log the attack details here
                Response.Cookies("TriedTohack").Value = "True"
                'Dim myCookies As String() = Request.Cookies.AllKeys
                'For Each cookie As String In myCookies
                '    Response.Cookies(cookie).Expires = DateTime.Now.AddDays(-1)
                'Next

                'Throw New HttpException("Invalid Request")
                'Response.Redirect("~/NoPermission.aspx")
            End If

            'Use the default one so application will work as usual//ASP.NET_SessionId
            Request.Cookies("ASP.NET_SessionId").Value = Request.Cookies("ASP.NET_SessionId").Value.Substring(0, 24)
            'ElseIf (IsNothing(Request.Cookies("ASP.NET_SessionId"))) Then
            '    'Session.Abandon()
            '    Dim myCookies As String() = Request.Cookies.AllKeys
            '    For Each cookie As String In myCookies
            '        Response.Cookies(cookie).Expires = DateTime.Now.AddDays(-1)
            '    Next
        End If
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)


        If My.Settings.ErrorDisplay = False Then
            ' Session.Abandon()
            Response.Redirect(My.Settings.ErrorPage)
        End If
        'Response.Redirect(My.Settings.ErrorPage)
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

    Private Function GenerateHashKey() As String
        Dim myStr As New StringBuilder()
        myStr.Append(Request.Browser.Browser)
        myStr.Append(Request.Browser.Platform)
        myStr.Append(Request.Browser.MajorVersion)
        myStr.Append(Request.Browser.MinorVersion)
        'myStr.Append(Request.LogonUserIdentity.User.Value);
        Dim sha As SHA1 = New SHA1CryptoServiceProvider()
        Dim hashdata As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(myStr.ToString()))
        Return Convert.ToBase64String(hashdata)
    End Function

End Class