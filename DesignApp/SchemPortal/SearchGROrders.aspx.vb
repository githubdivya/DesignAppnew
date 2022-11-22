Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports System.IO
Imports DesignApp
Imports NICFrameWork.LibCommon


Public Class SearchGROrders
    Inherits SchemeGeneral
    Dim obj As New Scheme
    Dim dept, grno, grdesc, MyCulture As String
    Public fromdate As Nullable(Of Date)
    Public to_date As Nullable(Of Date)
    Dim objservice As New WebService
    Dim ds As DataSet
    Dim arrContent As Byte()
    Dim dr As DataRow
    Dim obj1 As New SchemeGeneral

    Protected Sub btnsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        setparameter()
        If Not IsNothing(Session("MyCulture")) Then
            MyCulture = Session("MyCulture")
        Else
            MyCulture = "en"
        End If
        ds = objservice.GetGRData(Session("GRParameter"), MyCulture)
        If Not ds Is Nothing Then
            GridView1.DataSource = ds
            GridView1.DataBind()
        Else
            lblmsg.Text = "No Records Found"
            obj1.ClearGridView(GridView1)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            obj.FillDept(ddldept)
        End If
        lblmsg.Text = ""
    End Sub
    Public Sub setparameter()
        dept = ddldept.SelectedValue
        grno = txtGR.Text.Trim
        grdesc = txtdesc.Text.Trim

        If (txtFromDate.Text <> "") Then
            fromdate = Date.ParseExact(txtFromDate.Text.Trim, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        Else
            fromdate = Nothing
        End If

        If txtToDate.Text <> "" Then
            to_date = Date.ParseExact(txtToDate.Text.Trim, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        Else
            to_date = Nothing
        End If

        Session("GRParameter") = dept & "," & grno & "," & grdesc & "," & fromdate & "," & to_date
    End Sub


    Sub DisplayDownloadDialog(ByVal ds As DataSet)
        'Dim objFileInfo As System.IO.FileInfo
        'Try
        '    If Not System.IO.File.Exists(path) Then
        '        Exit Sub
        '    End If
        '    objFileInfo = New System.IO.FileInfo(path)
        '    Response.Clear()
        '    Response.AddHeader("Content-Disposition", "attachment; filename=" & objFileInfo.Name)
        '    Response.AddHeader("Content-Length", objFileInfo.Length.ToString())
        '    Response.ContentType = "application/octet-stream"
        '    Response.WriteFile(objFileInfo.FullName)
        'Catch ex As Exception
        '    Throw
        'Finally
        '    Response.End()
        'End Try
        'dr = ds.Tables(0).Rows(0)
        'Dim s1 As System.IO.MemoryStream = 
        'With HttpContext.Current.Response
        '    .ContentType = "application/pdf"
        '    .AddHeader("Content-Disposition", "inline; filename=Report.pdf")
        '    .BinaryWrite(s1.ToArray)
        '    .End()
        'End With
    End Sub

    Protected Sub GridView1_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles GridView1.RowEditing
        'Dim grorderid As Integer
        'grorderid = Integer.Parse(GridView1.DataKeys(e.NewEditIndex).Value.ToString())




        'Dim sql As String
        'sql = "Select * from tblGrOrders where GrOrderId=" & grorderid
        'Dim ds As DataSet
        'ds = SqlHelper.ExecuteDataset(getConnectionString, CommandType.Text, sql)
        'dr = ds.Tables(0).Rows(0)
        'arrContent = CType(dr.Item("GrOrder"), Byte())
        ''Dim f As MemoryStream = ar
        'With HttpContext.Current.Response
        '    .ContentType = "application/pdf"
        '    .AddHeader("Content-Disposition", "inline; filename=Report.pdf")
        '    .BinaryWrite(arrContent)
        '    .End()
        'End With

        'Dim conType As String = dr.Item("GrOrder").ToString()

        'Response.ContentType = conType

        'Response.OutputStream.Write(arrContent, 0, dr.Item("imgLength"))

        'Response.End()


        'Response.Redirect("SendLDetail.aspx?buttonmode=resend&loaninfoid=" & grorderid)
    End Sub
    'Public Function getConnectionString() As String
    '    Return System.Configuration.ConfigurationManager.ConnectionStrings("ConnStr").ConnectionString
    'End Function

    Protected Sub downloadgrguj_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)
        If lb.Text = "Download" Then
            Dim row As GridViewRow = DirectCast(lb.NamingContainer, GridViewRow)
            ID = CInt(TryCast(row.FindControl("lblGROrderId"), Label).Text)


            ReplacewithOldValue()
            Session("GROrderId1") = ID
            Session("Type") = 1
            ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewGROrders.aspx','','toolbar=no,resizable=yes')</script>")
        End If
    End Sub

    Protected Sub downloadgreng_Click(sender As Object, e As EventArgs)
        Dim lb As LinkButton = DirectCast(sender, LinkButton)
        If lb.Text = "Download" Then
            Dim row As GridViewRow = DirectCast(lb.NamingContainer, GridViewRow)
            ID = CInt(TryCast(row.FindControl("lblGROrderId"), Label).Text)


            ReplacewithOldValue()
            Session("GROrderId1") = ID
            Session("Type") = 2
            ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewGROrders.aspx','','toolbar=no,resizable=yes')</script>")
        End If
    End Sub

End Class