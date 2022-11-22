Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Data
Imports NICFrameWork.LibCommon

Partial Public Class SearchImage
    Inherits System.Web.UI.Page
    'Inherits General
    Public intui As Integer = 0
    Private dsEntry As New DataSet
    Public dt, dt1, dt2, dt3 As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("MyCulture") = "en" Then
            intui = 0
        Else
            intui = 1
        End If
        If Not IsPostBack Then
            BindDataListView()
        End If

    End Sub
    'Private Sub getCollection(ByRef objParameter As cParameter, ByVal index As Int16, Optional ByVal common As Boolean = False)

    '    Dim culture As String
    '    culture = ""
    '    'Session("MyCulture").ToString()
    '    If IsNothing(objParameter) Then
    '        objParameter = New cParameter(dsEntry)

    '    End If
    '    Select Case index
    '        Case 0

    '        Case 1 'for Populate Data
    '            Dim objUserInfo As cUserInfo

    '            objUserInfo = Session("objUserInfo")
    '            If myTextBox.Text.Trim.Length > 0 Then
    '                objParameter.CreateParameter(dsEntry, "@matadata", myTextBox.Text, enmParameterType.Input, SqlDbType.Text)
    '            End If



    '    End Select
    'End Sub

    Private Sub BindDataListView()
        Dim ds As New DataSet
        Dim objCRUD As New cSearchBySector

        dsEntry = New DataSet
        Dim objParameter As New cParameter(dsEntry)

        'getCollection(objParameter, 1)
        objCRUD.GetDataSet(dsEntry, enmtblSectorMast.tblSectorMast)
        lvSchemeBySector.DataSource = dsEntry.Tables("tblSectorMast")

        lvSchemeBySector.DataBind()
    End Sub



    Private Sub lvSchemeBySector_PagePropertiesChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSchemeBySector.PagePropertiesChanged
        BindDataListView()
    End Sub
    '<WebMethod()> <Script.Services.ScriptMethod()> _
    'Public Shared Function GetCompletionList(ByVal prefixText As String, ByVal count As Integer) As String()
    '    Dim rd As SqlDataReader = Nothing
    '    Dim item As List(Of String) = New List(Of String)(count)
    '    Dim sql As String
    '    sql = "Select SectorE from tblSectorMast where SectorE like '" & prefixText & "%'"
    '    rd = SqlHelper.ExecuteReader(My.Settings.cn, CommandType.Text, sql)
    '    Dim strSector(rd.Depth) As String
    '    If rd.HasRows Then
    '        While (rd.Read())
    '            item.Add(Convert.ToString(rd.GetValue(0)))
    '        End While
    '    End If
    '    rd.Close()
    '    Return item.ToArray()
    'End Function

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        BindDataListView()
    End Sub
    Protected Sub lnkbtn_click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)

        ID = TryCast(lb.FindControl("lblid1"), Label).Text
        ReplacewithOldValue()
        Session("mode") = "sector"
        Session("Id1") = ID
        Response.Redirect("resultdata.aspx")
    End Sub

    Protected Sub LinkButton1_click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)

        ID = TryCast(lb.FindControl("lblid2"), Label).Text
        ReplacewithOldValue()
        Session("mode") = "sector"
        Session("Id1") = ID
        Response.Redirect("resultdata.aspx")
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)

        ID = TryCast(lb.FindControl("lblid3"), Label).Text
        ReplacewithOldValue()
        Session("mode") = "sector"
        Session("Id1") = ID
        Response.Redirect("resultdata.aspx")
    End Sub
    Protected Sub LinkButton3_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)

        ID = TryCast(lb.FindControl("lblid4"), Label).Text
        ReplacewithOldValue()
        Session("mode") = "sector"
        Session("Id1") = ID
        Response.Redirect("resultdata.aspx")
    End Sub
    Protected Sub LinkButton4_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)

        ID = TryCast(lb.FindControl("lblid5"), Label).Text
        ReplacewithOldValue()
        Session("mode") = "sector"
        Session("Id1") = ID
        Response.Redirect("resultdata.aspx")
    End Sub
    Protected Sub LinkButton5_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)

        ID = TryCast(lb.FindControl("lblid6"), Label).Text
        ReplacewithOldValue()
        Session("mode") = "sector"
        Session("Id1") = ID
        Response.Redirect("resultdata.aspx")
    End Sub

    Private Sub ReplacewithOldValue()

    End Sub

End Class