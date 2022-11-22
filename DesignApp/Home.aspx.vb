Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myCookies As String() = Request.Cookies.AllKeys
        For Each cookie As String In myCookies
            Response.Cookies(cookie).Expires = DateTime.Now.AddDays(-1)
        Next
    End Sub
    Protected Sub Unnamed1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles language.SelectedIndexChanged

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("~/Citizen/frmServiceGroup.aspx")
    End Sub
End Class