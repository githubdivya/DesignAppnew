Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports DesignApp
Imports NICFrameWork.LibCommon

Public Class ResultData
    Inherits Scheme
    Dim obj, obj1 As New WebService
    Dim ds, ds1, dsEntry As DataSet
    Dim mode, id2 As String
    Dim dept, sector, AppTo, MyCulture As String
    Dim Gender1, Caste As String
    Dim dv1 As New DataView
    Dim testdt, testdt1 As DataTable
    Public flag As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mode = Session("mode")
        id2 = Session("Id1")
        Label1.Text = String.Empty
        If Not Page.IsPostBack Then
            LifeEvent.Visible = False
            bindcombo()
            grid(mode)
        End If
    End Sub
    Public Function DistinctRows(ByVal dt As DataTable, ByVal keyfield As String) As DataTable
        Dim newTable As DataTable = dt.Clone
        Dim keyval As Int32 = 0
        Dim dv As DataView = dt.DefaultView
        dv.Sort = keyfield
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                If Not dr.Item(keyfield) = keyval Then
                    newTable.ImportRow(dr)
                    keyval = dr.Item(keyfield)
                End If
            Next
        Else
            newTable = dt.Clone
        End If
        Return newTable
    End Function

    Public Sub grid(ByVal mode As String)
        If Not IsNothing(Session("MyCulture")) Then
            MyCulture = Session("MyCulture")
        Else
            MyCulture = "en"
        End If

        If mode = "dept" Then
            ddldept.ClearSelection()
            ddldept.Items.FindByValue((Session("departmentid"))).Selected = True
            ds = obj.GetByDept(Integer.Parse(Session("departmentid")), MyCulture)
            If Not ds Is Nothing Then
                testdt = ds.Tables(0)
                Session("dv") = testdt.DefaultView
                testdt1 = DistinctRows(testdt, "SchemeCode")
                dv1 = testdt1.DefaultView
                GridView2.DataSource = ds
                GridView2.DataBind()
            Else
                Label1.Text = "No Records Found"
            End If
        ElseIf mode = "sector" Then
            ddlSector.ClearSelection()
            ddlSector.Items.FindByValue((Session("Id1"))).Selected = True
            ds = obj.GetBySectorfrm1(Integer.Parse(Session("Id1")), MyCulture, 1)
            If Not ds Is Nothing Then
                testdt = ds.Tables(0)
                Session("dv") = testdt.DefaultView
                testdt1 = DistinctRows(testdt, "SchemeCode")
                dv1 = testdt1.DefaultView
                GridView2.DataSource = ds
                GridView2.DataBind()
            Else
                Label1.Text = "No Records Found"
            End If
        ElseIf mode = "event" Then
            LifeEvent.Visible = True
            ddlEvent.ClearSelection()
            ddlEvent.Items.FindByValue((Session("eventid"))).Selected = True
            ds = obj.GetByEvent(Integer.Parse(Session("eventid")), MyCulture)
            If Not ds Is Nothing Then
                testdt = ds.Tables(0)
                Session("dv") = testdt.DefaultView
                testdt1 = DistinctRows(testdt, "SchemeCode")
                dv1 = testdt1.DefaultView
                GridView2.DataSource = ds
                GridView2.DataBind()
            Else
                Label1.Text = "No Records Found"
            End If
        ElseIf mode = "Service" Then
            ddldept.ClearSelection()
            ddldept.Items.FindByValue(Session("departmentid")).Selected = True
            ds = obj.GetByscheme(Integer.Parse(Session("Id1")), Session("departmentid"), MyCulture)
            If Not ds Is Nothing Then
                testdt = ds.Tables(0)
                Session("dv") = testdt.DefaultView
                testdt1 = DistinctRows(testdt, "SchemeCode")
                dv1 = testdt1.DefaultView
                GridView2.DataSource = ds
                GridView2.DataBind()
            Else
                Label1.Text = "No Records Found"
            End If
        Else
            Label1.Text = "No Records Found"
        End If

    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        filterdataresult()
        If flag = False Then
            flag = True
            ViewState("flag") = flag
        End If
    End Sub

    Public Sub bindcombo()
        FillDeptFrm1(ddldept, Session("MyCulture").ToString())
        FillSectorfrm1(ddlSector, Session("MyCulture").ToString())
        FillCaste1frm1(ddlCaste, Session("MyCulture").ToString())
        FillScAppArea(ddlScApp)
        FillGenderfrm1(ddlGender, Session("MyCulture").ToString())
        FillLifeEvents(ddlEvent)
    End Sub

    Public Sub filterdataresult()
        dept = ddldept.SelectedValue
        sector = ddlSector.SelectedValue
        Gender1 = ddlGender.SelectedValue.ToString()
        Caste = ddlCaste.SelectedValue
        AppTo = ddlScApp.SelectedValue

        Dim objCRUD As New cSchemeAtoZ
        dsEntry = New DataSet
        Dim objParameter = New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@MyCulture", Session("MyCulture"))
        objParameter.CreateParameter(dsEntry, "@deptid", ddldept.SelectedValue, enmParameterType.Input, SqlDbType.Int)
        objParameter.CreateParameter(dsEntry, "@sectorid", ddlSector.SelectedValue, enmParameterType.Input, SqlDbType.Int)
        objParameter.CreateParameter(dsEntry, "@Gender", Gender1, enmParameterType.Input, SqlDbType.Char)
        objParameter.CreateParameter(dsEntry, "@Caste", Caste, enmParameterType.Input, SqlDbType.VarChar)
        objParameter.CreateParameter(dsEntry, "@AppTo", ddlScApp.SelectedValue, enmParameterType.Input, SqlDbType.Int)
        objParameter.CreateParameter(dsEntry, "@eventId", ddlEvent.SelectedValue, enmParameterType.Input, SqlDbType.Int)
        objParameter.CreateParameter(dsEntry, "@flag", 1, enmParameterType.Input, SqlDbType.Int)
        objCRUD.GetDataSet(dsEntry, enmtblSchemeMast.tblSchemeMast)

        If dsEntry.Tables.Contains("tblSchemeMast") Then
            If dsEntry.Tables("tblSchemeMast").Rows.Count > 0 Then
                GridView2.DataSource = dsEntry.Tables("tblSchemeMast")
                GridView2.DataBind()
            Else
                Label1.Text = "No Records Found"
                ClearGridView(GridView2)
            End If


        Else
            Label1.Text = "No Records Found"
            ClearGridView(GridView2)
        End If

    End Sub

    Public Function DataViewAsDataTable(ByVal dv As DataView) As DataTable
        Dim dtnew As DataTable
        Dim drv As DataRowView
        dtnew = dv.Table.Clone()
        For Each drv In dv
            dtnew.ImportRow(drv.Row)
        Next
        Return dtnew
    End Function

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("ServiceGroup.aspx")
    End Sub

    Protected Sub GridView2_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView2.PageIndexChanging

        If ViewState("flag") = True Then
            GridView2.PageIndex = e.NewPageIndex
            filterdataresult()
        Else
            GridView2.PageIndex = e.NewPageIndex
            grid(mode)
        End If
    End Sub

    Protected Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs) Handles GridView2.RowCommand
        If e.CommandName = "View" Then


            'Integer.Parse(e.CommandArgument.ToString()) 
            Dim page As Integer = GridView2.PageSize
            Dim index As Integer = Convert.ToInt32(e.CommandArgument) Mod page
            Dim selectedRow As GridViewRow = GridView2.Rows(index)
            ReplacewithOldValue()
            Dim i As Integer = CType(selectedRow.FindControl("lblSchemeCode"), Label).Text
            Dim strpopup As String
            Session("scode") = i
            strpopup = "<script language='javascript'>varnewwin=window.open('MoreDetails.aspx');" & "</script>"
            Response.Write(strpopup)
        End If
    End Sub

    Protected Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Session("dv") = Nothing
        'Session("mode") = Nothing
        'Session("Id1") = Nothing
        ddldept.SelectedValue = Nothing
        ddlSector.SelectedValue = Nothing
        ddlCaste.SelectedValue = Nothing
        ddlScApp.SelectedValue = Nothing
        ddlGender.SelectedValue = Nothing

        Label1.Text = Nothing
        GridView2.DataSource = Nothing
        GridView2.DataBind()
    End Sub

End Class