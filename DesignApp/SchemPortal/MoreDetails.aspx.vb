Imports System.Data
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon

Partial Class MoreDetails
    Inherits Scheme
    ' Inherits cBaseForm
    Dim scode As Integer
    Dim mode As Integer
    Dim ds, dsEntry As DataSet
    Public ds1, ds4, ds5 As DataSet
    Dim ds2 As DataSet
    Dim ds3 As DataSet
    Dim distid, MyCulture As String
    Public dt, dt1, dt2, dt3, dt4, dt5 As New DataTable
    Dim obj, obj1, obj2, obj3, obj4, obj5 As New WebService
    Public temp As DataTable = Nothing

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsNothing(Session("MyCulture")) Then
            MyCulture = Session("MyCulture")
        Else
            MyCulture = "en"
        End If
        If Not Page.IsPostBack Then

            Try
                scode = Integer.Parse(Session("scode"))
            Catch
                Response.Redirect("~/SchemPortal/ServiceGroup.aspx")
            End Try

            FillDistrict(ddlDistrict)
            ds = obj.GetDetail(scode, MyCulture)
            ds1 = obj1.GetScAppArea(scode, MyCulture, 0)
            ds4 = obj4.GetScAppArea(scode, MyCulture, 1)
            ds5 = obj5.GetScAppArea(scode, MyCulture, 2)
            ds2 = obj2.GetAttachement(scode, MyCulture)
            ds3 = obj3.GetScOfficeDetail(scode)
            dt = ds.Tables(0)
            'dt1 = ds1.Tables(0)
            dt2 = ds2.Tables(0)
            'dt4 = ds4.Tables(0)
            'dt5 = ds5.Tables(0)
            Session("dt") = dt
            'Session("dt1") = dt1
            Session("dt2") = dt2
            'Session("dt4") = dt4
            'Session("dt5") = dt5
            If Not ds1 Is Nothing Then
                dt1 = ds1.Tables(0)
                Session("dt1") = dt1
            Else
                dt1 = Nothing
                Session("dt1") = Nothing
            End If
            If Not ds3 Is Nothing Then
                dt3 = ds3.Tables(0)
                Session("dt3") = dt3
            Else
                dt3 = Nothing
                Session("dt3") = Nothing
            End If
            If Not ds4 Is Nothing Then
                dt4 = ds4.Tables(0)
                Session("dt4") = dt4
            Else
                dt4 = Nothing
                Session("dt4") = Nothing
            End If
            If Not ds5 Is Nothing Then
                dt5 = ds5.Tables(0)
                Session("dt5") = dt5
            Else
                dt5 = Nothing
                Session("dt5") = Nothing
            End If
            If ds.Tables.Contains("Table1") AndAlso ds.Tables("Table1").Rows.Count > 0 Then
                GRdetails.Visible = True
                binddocs(ds.Tables("Table1"))
            Else
                GRdetails.Visible = False
            End If

            'If IsDBNull(dt.Rows(0).Item("RCPSACT").ToString) Or (dt.Rows(0).Item("RCPSACT").ToString = True) Then
            'If IsDBNull(dt.Rows(0).Item("RCPSACT").ToString) OrElse IsNothing(dt.Rows(0).Item("RCPSACT").ToString) OrElse dt.Rows(0).Item("RCPSACT").ToString.Length = 0 Then
            '    RCPSHead.Visible = False
            '    RCPS.Visible = False
            'Else

            '    RCPSHead.Visible = True
            '    RCPS.Visible = True
            'End If

        End If
    End Sub
    Public Sub binddocs(ByRef dt As DataTable)
        Gv_Docs.DataSource = ds.Tables("Table1")
        Gv_Docs.DataBind()

    End Sub
    Public Sub bind()
        scode = Integer.Parse(Session("scode"))
        FillDistrict(ddlDistrict)
        ds = obj.GetDetail(scode, MyCulture)
        ds1 = obj1.GetScAppArea(scode, MyCulture, 0)
        ds4 = obj1.GetScAppArea(scode, MyCulture, 1)
        ds5 = obj1.GetScAppArea(scode, MyCulture, 2)
        ds2 = obj2.GetAttachement(scode, MyCulture)
        ds3 = obj3.GetScOfficeDetail(scode)
        dt = ds.Tables(0)
        dt1 = ds1.Tables(0)
        dt2 = ds2.Tables(0)
        dt4 = ds4.Tables(0)
        dt5 = ds5.Tables(0)
        Session("dt") = dt
        Session("dt1") = dt1
        Session("dt2") = dt2
        'Session("dt4") = dt4
        'Session("dt5") = dt5
        If Not ds3 Is Nothing Then
            dt3 = ds3.Tables(0)
            Session("dt3") = dt3
        Else
            dt3 = Nothing
            Session("dt3") = Nothing
        End If
        If Not ds4 Is Nothing Then
            dt4 = ds4.Tables(0)
            Session("dt4") = dt4
        Else
            dt4 = Nothing
            Session("dt4") = Nothing
        End If
        If Not ds5 Is Nothing Then
            dt5 = ds5.Tables(0)
            Session("dt5") = dt5
        Else
            dt5 = Nothing
            Session("dt5") = Nothing
        End If

        If ds.Tables.Contains("Table1") AndAlso ds.Tables("Table1").Rows.Count > 0 Then
            GRdetails.Visible = True
            binddocs(ds.Tables("Table1"))
        Else
            GRdetails.Visible = False
        End If


    End Sub
    Public Sub gv_rowcommand(sender As Object, e As GridViewCommandEventArgs) Handles Gv_Docs.RowCommand
        If e.CommandName = "DownloadGuj" Then
            Dim id As Integer
            Dim rowIndex As Integer = Convert.ToInt32(e.CommandArgument)

            'Reference the GridView Row.
            Dim row As GridViewRow = Gv_Docs.Rows(rowIndex)

            'Fetch value of Name.

            id = CInt(TryCast(row.FindControl("lblid"), Label).Text)
            If id > 0 Then
                Dim obj As cSchemeAtoZ
                obj = New cSchemeAtoZ
                Dim dsentry As DataSet
                dsentry = New DataSet
                Dim objParameter As New cParameter(dsentry)
                objParameter.CreateParameter(dsentry, "@Grorderid", id, enmParameterType.Input, SqlDbType.Int)
                objParameter.CreateParameter(dsentry, "@lng", "Guj", enmParameterType.Input, SqlDbType.Text)
                obj.GetDataset(dsentry, 3)
                If dsentry.Tables.Contains("File") AndAlso dsentry.Tables("File").Rows.Count > 0 AndAlso Not IsDBNull(dsentry.Tables("File").Rows(0).Item("DownloadFile")) Then
                    ReplacewithOldValue()
                    With dsentry.Tables("File").Rows(0)
                        Dim a As Byte() = IIf(IsDBNull(.Item("DownloadFile")), {}, .Item("DownloadFile"))

                        With HttpContext.Current.Response
                            .ContentType = "application/pdf"
                            .AddHeader("Content-Disposition", "attachment; filename=Gujarati.pdf")
                            .BinaryWrite(a)
                            .End()
                        End With
                    End With
                Else
                    Response.Write("<script>alert('Document not Found')</script>>")
                    'lblexe.Text = "Document not Found"
                End If

            End If

        End If
        If e.CommandName = "DownloadEng" Then
            Dim id As Integer
            Dim rowIndex As Integer = Convert.ToInt32(e.CommandArgument)

            'Reference the GridView Row.
            Dim row As GridViewRow = Gv_Docs.Rows(rowIndex)

            'Fetch value of Name.

            id = CInt(TryCast(row.FindControl("lblid"), Label).Text)
            If id > 0 Then
                Dim obj As cSchemeatoz
                obj = New cSchemeatoz
                Dim dsentry As DataSet
                dsentry = New DataSet
                Dim objParameter As New cParameter(dsentry)
                objParameter.CreateParameter(dsentry, "@Grorderid", id, enmParameterType.Input, SqlDbType.Int)
                objParameter.CreateParameter(dsentry, "@lng", "Eng", enmParameterType.Input, SqlDbType.Text)
                obj.GetDataSet(dsentry, 3)
                If dsentry.Tables.Contains("File") AndAlso dsentry.Tables("File").Rows.Count > 0 AndAlso Not IsDBNull(dsentry.Tables("File").Rows(0).Item("DownloadFile")) Then
                    ReplacewithOldValue()
                    With dsentry.Tables("File").Rows(0)
                        Dim a As Byte() = IIf(IsDBNull(.Item("DownloadFile")), {}, .Item("DownloadFile"))

                        With HttpContext.Current.Response
                            .ContentType = "application/pdf"
                            .AddHeader("Content-Disposition", "attachment; filename=English.pdf")
                            .BinaryWrite(a)
                            .End()
                        End With
                    End With
                Else
                    Response.Write("<script>alert('Document not Found')</script>>")
                    'lblexe.Text = "Document not Found"
                End If
            End If

        End If
        bind()
    End Sub
    Protected Sub ddlDistrict_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlDistrict.SelectedIndexChanged

        dt3 = Session("dt3")
        Session("dv") = dt3.DefaultView
        dt = Session("dt")
        dt1 = Session("dt1")
        dt2 = Session("dt2")
        temp = filterdataresult()
    End Sub
    Public Function filterdataresult() As DataTable
        distid = ddlDistrict.SelectedValue
        If distid <> "0" Then
            Dim final As String = String.Empty
            Dim dv As New DataView
            dv = Session("dv")
            If ((final = String.Empty) And (distid <> 0)) Then
                final = " DistCd = '" + distid + "'"
            End If
            dv.RowFilter = final
            temp = DataViewAsDataTable(dv)
            Return temp
        Else
            temp = Nothing
            Return temp
        End If
    End Function
    Public Function DataViewAsDataTable(ByVal dv As DataView) As DataTable
        Dim dtnew As DataTable
        Dim drv As DataRowView
        dtnew = dv.Table.Clone()
        For Each drv In dv
            dtnew.ImportRow(drv.Row)
        Next
        Return dtnew
    End Function
    Protected Sub RequestLanguageChange_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGujarati.Click
        ReplacewithOldValue()
        Dim senderLink As LinkButton = sender
        'store requested language as new culture in the session
        Session("MyCulture") = senderLink.CommandArgument
        'reload last requested page with new culture
        Server.Transfer(Request.Path)
    End Sub

#Region "RCPS"
    'Protected Sub RCPSguj_Click(sender As Object, e As EventArgs) Handles RCPSguj.Click
    '    Try


    '        scode = Integer.Parse(Session("scode"))
    '        Dim a As Byte() = LoadRCPSDoc(scode, "guj")
    '        If a.Length > 0 Then
    '            ReplacewithOldValue()
    '            With HttpContext.Current.Response
    '                .ContentType = "application/pdf"
    '                .AddHeader("Content-Disposition", "attachment; filename=RCPSGuj.pdf")
    '                .BinaryWrite(a)
    '                .End()
    '            End With
    '        Else
    '            lblexe.Text = "Document not Found"
    '            bind()
    '            'Response.Write("<script>alert('Document not Found')</script>")
    '        End If
    '    Catch ex As Exception
    '        'lblexe.Text = ex.Message
    '    End Try
    'End Sub

    'Protected Sub RCPSeng_Click(sender As Object, e As EventArgs) Handles RCPSeng.Click
    '    Try


    '        scode = Integer.Parse(Session("scode"))
    '        Dim a As Byte() = LoadRCPSDoc(scode, "eng")
    '        If a.Length > 0 Then
    '            ReplacewithOldValue()
    '            With HttpContext.Current.Response
    '                .ContentType = "application/pdf"
    '                .AddHeader("Content-Disposition", "attachment; filename=RCPSEng.pdf")
    '                .BinaryWrite(a)
    '                .End()
    '            End With
    '        Else
    '            lblexe.Text = "Document not Found"
    '            bind()
    '        End If
    '    Catch ex As Exception
    '        ' lblexe.Text = ex.Message
    '    End Try
    'End Sub
#End Region

    Protected Sub downloadformguj_Click(sender As Object, e As EventArgs) Handles downloadformguj.Click
        ReplacewithOldValue()
        Session("Scode") = Session("scode")
        Session("Type") = 1
        ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewForm.aspx','','toolbar=no,resizable=yes')</script>")
        bind()
    End Sub

    Protected Sub downloadformeng_Click(sender As Object, e As EventArgs) Handles downloadformeng.Click
        ReplacewithOldValue()
        Session("Scode") = Session("scode")
        Session("Type") = 2
        ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewForm.aspx','','toolbar=no,resizable=yes')</script>")
        bind()
    End Sub

    Protected Sub downloadforminst_Click(sender As Object, e As EventArgs) Handles downloadforminst.Click
        ReplacewithOldValue()
        Session("Scode") = Session("scode")
        Session("Type") = 3
        ClientScript.RegisterStartupScript(Me.GetType, "", "<script>window.open('ViewForm.aspx','','toolbar=no,resizable=yes')</script>")
        bind()
    End Sub
End Class
