Imports System.Web.Services
Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports System.IO

Public Class SearchAll

    Inherits System.Web.UI.Page
    Dim obj, obj1 As New WebService
    Dim ds, dsEntry As DataSet
    Dim dv1 As New DataView
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            grid()
        End If
    End Sub

    Public Sub grid()

        Dim objCRUD As New cSchemeAtoZ

        dsEntry = New DataSet
        Dim objParameter = New cParameter(dsEntry)
        objCRUD.GetDataSet(dsEntry, enmtblSchemeMast.tblSchemeMast)
        GridView2.DataSource = dsEntry.Tables("tblSchemeMast")
        GridView2.DataBind()
    End Sub
    Protected Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        If e.CommandName = "View" Then
            Dim index As Integer = GridView2.DataKeys(e.CommandArgument).Value.ToString
            Dim strpopup As String
            Session("scode") = index
            strpopup = "<script language='javascript'>varnewwin=window.open('MoreDetails.aspx');" & "</script>"
            Response.Write(strpopup)
        End If
    End Sub

    Protected Sub lnkbtn_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)
        Dim row As GridViewRow = DirectCast(lb.NamingContainer, GridViewRow)
        Dim ID As String = TryCast(row.FindControl("lblserviceurl"), Label).Text
        Dim strpopup As String
        If ID <> "" Then
            ' ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('" + ID + "','','toolbar=no,resizable=yes')</script>")
            strpopup = "<script language='javascript'>varnewwin=window.open('" + ID + "');" & "</script>"
            Response.Write(strpopup)
        End If


    End Sub

End Class