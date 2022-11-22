Imports System.Web.Services
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports System.Web.UI.WebControls
Imports NIC.LibApp

Partial Public Class frmMain1
    Inherits cBaseForm
    Dim obj As New WebService
    Dim ds As New DataSet
    Private dsEntry As DataSet
    Private dsEntry1 As DataSet
    Private objcrud As cDashBoard
    Private objcrud1 As cDashBoard
    Dim dt1 As New DataSet
    Dim dt2 As New DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            BindCount()
            myInput.Text = String.Empty
            If Request.QueryString("Cul") IsNot Nothing AndAlso Request.QueryString("Cul") = "gu-IN" Then
                Session("MyCulture") = Request.QueryString("Cul").ToString
                Response.Redirect("frmMain1.aspx")

            End If
            Bind_News()
        End If

    End Sub
    Private Sub BindCount()

        dsEntry = New DataSet

        objcrud = New cDashBoard
        objcrud1 = New cDashBoard
        Dim dt11 As New DataTable
        Dim dt2 As New DataTable
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
        objcrud.Select_ServiceList_PanchayatDB(dsEntry, enmDashboard.Select_ServiceList_PanchayatDB)
        If dsEntry.Tables("Top_Service").Rows.Count > 0 Then
            ' dt1 = dsEntry.Tables("Top_Service")
            dt11 = dsEntry.Tables("Top_Service")
        End If
        objcrud1.Select_ServiceList_RCPSDB(dsEntry, enmDashboard.Select_ServiceList_RCPSDB)
        If dsEntry.Tables("Top_Service").Rows.Count > 0 Then
            ' dt2 = dsEntry.Tables("Top_Service")
            dt2 = dsEntry.Tables("Top_Service")
        End If
        dt11.Merge(dt2, True)
        dt11.AcceptChanges()
        Dim ServiceGroups = dt11.AsEnumerable().GroupBy(Function(row) row.Field(Of Int32)("ServiceId"))
        Dim tableResult = dt11.Clone()
        For Each grp In ServiceGroups
            tableResult.Rows.Add(grp.Key, grp.First().Field(Of String)("ServiceNameE"),
                                                                  grp.First().Field(Of String)("ServiceImage"),
                                 grp.Sum(Function(row) row.Field(Of Int32)("ApplicationCount")))

        Next
        tableResult.DefaultView.Sort = "ApplicationCount DESC"
        tableResult = tableResult.DefaultView.ToTable()
        Dim dt1 = New DataSet()   ' The dataset where you want to add your table
        Dim dt As DataTable = tableResult   ' Get the table from your storage
        Dim dsOld = dt.DataSet        ' Retrieve the DataSet where the table has been originally added
        If dsOld IsNot Nothing Then
            dsOld.Tables.Remove(dt.TableName)  ' Remove the table from its dataset tables collection
        End If
        dt1.Tables.Add(dt)

        If (dt1.Tables("Top_Service").Rows.Count > 0) Then
            div1.Visible = True
            div2.Visible = True
            div3.Visible = True
            div4.Visible = True
            div5.Visible = True
            div6.Visible = True
            div7.Visible = True
            div8.Visible = True
            div9.Visible = True
            div10.Visible = True
            With dt1.Tables("Top_Service").Rows(0)
                imagefirst.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(0)("ServiceImage")
                lblfirst.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(0)("ServiceNameE"))
                ' lblfirstcount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(0)("ApplicationCount")) + ")"
                imagesecond.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(1)("ServiceImage")
                lblsecond.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(1)("ServiceNameE"))
                '  lblsecondcount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(1)("ApplicationCount")) + ")"
                imagethird.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(2)("ServiceImage")
                lblthird.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(2)("ServiceNameE"))
                ' lblthirdcount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(2)("ApplicationCount")) + ")"
                imageforth.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(3)("ServiceImage")
                lblfour.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(3)("ServiceNameE"))
                '  lblfourcount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(3)("ApplicationCount")) + ")"
                imagefifth.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(4)("ServiceImage")
                lblfive.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(4)("ServiceNameE"))
                ' lblfivecount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(4)("ApplicationCount")) + ")"
                imagesix.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(5)("ServiceImage")
                lblsix.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(5)("ServiceNameE"))
                ' lblsixcount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(5)("ApplicationCount")) + ")"
                imageseven.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(6)("ServiceImage")
                lblseven.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(6)("ServiceNameE"))
                ' lblsevencount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(6)("ApplicationCount")) + ")"
                imageeight.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(7)("ServiceImage")
                lbleight.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(7)("ServiceNameE"))
                ' lbleightcount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(7)("ApplicationCount")) + ")"
                imagenine.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(8)("ServiceImage")
                lblnine.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(8)("ServiceNameE"))
                'lblninecount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(8)("ApplicationCount")) + ")"
                imageten.ImageUrl = "~\frmMain1\images\flaticons\" + dt1.Tables("Top_Service").Rows(9)("ServiceImage")
                lblten.Text = Convert.ToString(dt1.Tables("Top_Service").Rows(9)("ServiceNameE"))
                'lbltencount.Text = "(" + Convert.ToString(dt1.Tables("Top_Service").Rows(9)("ApplicationCount")) + ")"
            End With
        Else
            div1.Visible = False
            div2.Visible = False
            div3.Visible = False
            div4.Visible = False
            div5.Visible = False
            div6.Visible = False
            div7.Visible = False
            div8.Visible = False
            div9.Visible = False
            div10.Visible = False
        End If

    End Sub
    <WebMethod()> <Script.Services.ScriptMethod()> _
    Public Shared Function GetCompletionList(ByVal prefixText As String, ByVal count As Integer) As String()
        Dim dsentry = New DataSet
        Dim objsearch = New cSearch
        Dim objparameter As New cParameter(dsentry)
        objparameter.CreateParameter(dsentry, "@keyword", prefixText, enmParameterType.Input, SqlDbType.Text)
        objparameter.CreateParameter(dsentry, "@count", count, enmParameterType.Input, SqlDbType.Int)
        objsearch.SearchByAll(dsentry)
        Dim item As List(Of String) = New List(Of String)(count)
        If dsentry.Tables("tblschememast").Rows.Count > 0 Then
            Dim i As Integer = 0
            While i < dsentry.Tables("tblschememast").Rows.Count
                item.Add(dsentry.Tables("tblschememast").Rows(i)("SchemeName").ToString())
                i += 1
            End While
            'For index = 0 To dsentry.Tables("tblschememast").Rows.Count
            '    item.Add(dsentry.Tables("tblschememast").Rows(index)("SchemeName").ToString())
            '    item.Add(dsentry.Tables("tblschememast").Rows(index)("SchemeCode").ToString())
            'Next
            Return item.ToArray()
        Else
            Return Nothing
        End If
    End Function

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs)
        Dim dsentry = New DataSet
        Dim objsearch = New cSearch
        Dim objparameter As New cParameter(dsentry)
        objparameter.CreateParameter(dsentry, "@schemname", myInput.Text.Trim(), enmParameterType.Input, SqlDbType.Text)
        objparameter.CreateParameter(dsentry, "@flag", 0, enmParameterType.Input, SqlDbType.Int)
        objsearch.SearchSchemeByName(dsentry)
        If dsentry.Tables("tblschememast").Rows.Count > 0 Then
            Session("scode") = Convert.ToInt32(dsentry.Tables("tblschememast").Rows(0)("SchemeCode"))
            Dim strpopup As String
            strpopup = "<script>window.open('SchemPortal/MoreDetails.aspx');" & "</script>"
            Response.Write(strpopup)
        Else
            Response.Write("<script>alert('No Result Found')</script>")
        End If
    End Sub
    Private Sub Bind_News()
        Try
            dsEntry = New DataSet
            Dim objParameter As New cParameter(dsEntry)
            Dim ObjNews As New cNews

            objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
            ObjNews.GetDataSet(dsEntry, enmnews.news_homepage)

            If (dsEntry.Tables("NewsHomepage").Rows.Count > 0) Then
                Dim ObjTable As New Table
                For i = 0 To dsEntry.Tables("NewsHomepage").Rows.Count - 1

                    Dim ObjTableRow As New TableRow
                    Dim ObjTableCell1 As New TableCell
                    Dim ObjTableCell2 As New TableCell
                    'Dim ObjImage As New Image
                    Dim Objlabel As New Label




                    ObjTableCell1.VerticalAlign = VerticalAlign.Top
                    ObjTableCell2.VerticalAlign = VerticalAlign.Top
                    'ObjImage.ImageUrl = "Images/new-icon.gif"
                    Objlabel.Text = dsEntry.Tables("NewsHomepage").Rows(i)("News").ToString()
                    'If (dsEntry.Tables("NewsHomepage").Rows(i)("New_Image").ToString() = "True") Then
                    '    ObjTableCell1.Controls.Add(ObjImage)
                    'End If
                    ObjTableCell2.Controls.Add(Objlabel)
                    ObjTableRow.Controls.Add(ObjTableCell1)
                    ObjTableRow.Controls.Add(ObjTableCell2)

                    ObjTable.Controls.Add(ObjTableRow)

                Next
                phnews.Controls.Add(ObjTable)
            End If


        Catch ex As Exception
            Exit Sub
        End Try


    End Sub
End Class
