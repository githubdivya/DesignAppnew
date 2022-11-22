Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports DesignApp
Imports NICFrameWork.LibCommon

Partial Class SearchForm
    Inherits SchemeGeneral
    Dim obj As New Scheme
    Dim objservice As New WebService
    Dim ds As DataSet
    Dim dept, frmno, frmdesc As String
    Dim avaiId As Integer
    Dim arrContent As Byte()
    Dim dr As DataRow
    Dim objg As New SchemeGeneral
    Dim objfrm As New FormData

    Protected Sub btnsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        setparameter()
        ds = objservice.GetFRMData(Session("FRMParameter"))
        If ds.Tables(0).Rows.Count > 0 Then
            GridView1.DataSource = ds
            GridView1.DataBind()
        Else
            lblmsg.Text = "No Records Found"
            objg.ClearGridView(GridView1)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            obj.FillDept(ddldept)
            objfrm.FillAvailableFrom(ddlFrmAvai)
        End If
        lblmsg.Text = ""
    End Sub
    Public Sub setparameter()
        Dept = ddldept.SelectedValue
        frmno = txtFrmNo.Text.Trim
        frmdesc = txtdesc.Text.Trim
        avaiId = ddlFrmAvai.SelectedValue
        Session("FRMParameter") = dept & "," & frmno & "," & frmdesc & "," & avaiId
    End Sub


    Protected Sub GridView1_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles GridView1.RowEditing



        'Dim sql As String
        'sql = "Select * from tblFormsMast where FormId=" & Formid
        'Dim ds As DataSet
        'ds = SqlHelper.ExecuteDataset(getConnectionString, CommandType.Text, sql)
        'dr = ds.Tables(0).Rows(0)
        'arrContent = CType(dr.Item("Form"), Byte())

        'With HttpContext.Current.Response
        '    .ContentType = "application/pdf"
        '    .AddHeader("Content-Disposition", "inline; filename=Report.pdf")
        '    .BinaryWrite(arrContent)
        '    .End()
        'End With
    End Sub



    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        'If e.CommandName = "DownloadGuj" Then
        '    Dim id As Integer
        '    Dim rowIndex As Integer = Convert.ToInt32(e.CommandArgument)

        '    'Reference the GridView Row.
        '    Dim row As GridViewRow = GridView1.Rows(rowIndex)

        '    'Fetch value of Name.

        '    id = CInt(TryCast(row.FindControl("lblFormId"), Label).Text)

        '    'Dim Formid As Integer
        '    'Formid = Integer.Parse(GridView1.DataKeys(e.NewEditIndex).Value.ToString())
        '    ReplacewithOldValue()
        '    Session("FormId1") = id
        '    Session("Type") = 2
        '    ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewForm.aspx','','toolbar=no,resizable=yes')</script>")
        'End If
    End Sub

    Protected Sub downloadformguj_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)
        If lb.Text = "Download" Then
            Dim row As GridViewRow = DirectCast(lb.NamingContainer, GridViewRow)
            ID = CInt(TryCast(row.FindControl("lblFormId"), Label).Text)

            'Dim Formid As Integer
            'Formid = Integer.Parse(GridView1.DataKeys(e.NewEditIndex).Value.ToString())
            ReplacewithOldValue()
            Session("FormId1") = ID
            Session("Type") = 1
            ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewForm.aspx','','toolbar=no,resizable=yes')</script>")
        End If
    End Sub

    Protected Sub downloadformEng_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)
        If lb.Text = "Download" Then
            Dim row As GridViewRow = DirectCast(lb.NamingContainer, GridViewRow)
            ID = CInt(TryCast(row.FindControl("lblFormId"), Label).Text)

            'Dim Formid As Integer
            'Formid = Integer.Parse(GridView1.DataKeys(e.NewEditIndex).Value.ToString())
            ReplacewithOldValue()
            Session("FormId1") = ID
            Session("Type") = 2
            ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewForm.aspx','','toolbar=no,resizable=yes')</script>")
        End If
    End Sub
End Class
