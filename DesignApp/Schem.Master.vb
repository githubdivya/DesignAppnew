Imports NIC.LibApp
Imports LibReports
Public Class Schem

    Inherits System.Web.UI.MasterPage
    Private dsEntry As DataSet
    Private objcmap As cMap

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dsEntry = New DataSet
        objcmap = New cMap
        lblCount.Text = Application("counter").ToString()
        lblVersion.Text = Application("version").ToString()
        lblLastUpdated.Text = Application("LastUpdatedDate").ToString()

        If IsNothing(Session("MyCulture")) Then
            Session("MyCulture") = "en-GB"
        ElseIf Session("MyCulture") = "en-GB" Then

            btnLangEnglish.Attributes.Add("class", "active")
        ElseIf Session("MyCulture") = "gu-IN" Then

            btnLangGujarati.Attributes.Add("class", "active")
        End If

    End Sub

    Protected Sub btnLangEnglish_Click(sender As Object, e As EventArgs) Handles btnLangEnglish.Click
        Session("MyCulture") = "en-GB"
        'btnLangEnglish.Attributes.Add("class", "active")
        Context.Server.Transfer(Context.Request.Path)

    End Sub

    Protected Sub btnLangGujarati_Click(sender As Object, e As EventArgs) Handles btnLangGujarati.Click
        Session("MyCulture") = "gu-IN"
        'btnLangGujarati.Attributes.Add("class", "active")
        Context.Server.Transfer(Context.Request.Path)
    End Sub
End Class