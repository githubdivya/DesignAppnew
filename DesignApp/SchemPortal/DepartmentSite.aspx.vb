Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports DesignApp
Imports NICFrameWork.LibCommon

Public Class DepartmentSite

    Inherits Scheme
    Dim obj, obj1 As New WebService
    Dim ds, dsEntry As DataSet
    Dim dv1 As New DataView
    Dim testdt, testdt1 As DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("MyCulture") = "gu" Then
            IMG1.Src = "./Images/DeptSite.png"  ' edited By Bhoomi SchemeListGuj.png
        Else
            IMG1.Src = "./Images/DeptSite.png" 'SchemeList.png
        End If
        If Not Page.IsPostBack Then
            grid()
        End If
    End Sub
    Public Sub grid()
        Dim objCRUD As New cSchemeAtoZ
        dsEntry = New DataSet
        Dim objParameter = New cParameter(dsEntry)
        If Not IsNothing(Session("MyCulture")) Then
            objParameter.CreateParameter(dsEntry, "@MyCulture", Session("MyCulture"))
        Else
            objParameter.CreateParameter(dsEntry, "@MyCulture", "en")
        End If
        objCRUD.GetDeptSite(dsEntry, enmtblSchemeMast.tblSchemeMast)
        GridView2.DataSource = dsEntry.Tables("tblSchemeMast")
        GridView2.DataBind()
    End Sub
    Protected Sub GridView2_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridView2.PageIndexChanging
        GridView2.PageIndex = e.NewPageIndex
        grid()
    End Sub

    Protected Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        If e.CommandName = "View" Then
            Dim index As Integer = GridView2.DataKeys(e.CommandArgument).Value.ToString
            Dim strpopup As String
            strpopup = "<script language='javascript'>varnewwin=window.open('MoreDetails.aspx?scode=" & index & " ');" & "</script>"
            Response.Write(strpopup)
        End If
    End Sub

End Class