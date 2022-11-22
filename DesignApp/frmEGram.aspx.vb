Imports NICFrameWork.LibCommon
Imports NIC.LibApp

Public Class frmEGram1
    Inherits cBaseForm

    Private dsEntry As DataSet
    Private dsEntry1 As DataSet
    Private objcrud As cDashBoard
    Private objcrud1 As cDashBoard

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindCount()
            MergeServiceList()
            MergeGramPanchayat()
        End If

    End Sub

    Private Sub BindCount()
        dsEntry = New DataSet
        Dim objParameter As New cParameter(dsEntry)
        objcrud = New cDashBoard
        objcrud1 = New cDashBoard
        objcrud.GetDataSet(dsEntry, enmDashboard.Select_counteGramDashboard)
        If (dsEntry.Tables("Select_counteGramDashboard").Rows.Count > 0) Then
            With dsEntry.Tables("Select_counteGramDashboard").Rows(0)
                lbltotalservices.Text = Convert.ToString(dsEntry.Tables("Select_counteGramDashboard").Rows(0)("TotalService"))
                lbltotalgram.Text = Convert.ToString(dsEntry.Tables("Select_counteGramDashboard").Rows(0)("TotalGramPanchayat"))
                'lbltotalappl.Text = Convert.ToString(dsEntry.Tables("Select_counteGramDashboard").Rows(0)("TotalApplication"))
            End With
        End If
        objcrud1.GetDataSet(dsEntry, enmDashboard.Select_counteGramDashboard_rcps)
        If (dsEntry.Tables("Select_counteGramDashboard_rcps").Rows.Count > 0) Then
            With dsEntry.Tables("Select_counteGramDashboard_rcps").Rows(0)

                'lbltotalappl.Text = Convert.ToString(dsEntry.Tables("Select_counteGramDashboard_rcps").Rows(0)("TotalApplication"))
            End With
        End If
        lblTotalCount.Text = (Convert.ToInt32(dsEntry.Tables("Select_counteGramDashboard").Rows(0)("TotalApplication")) + Convert.ToInt32(dsEntry.Tables("Select_counteGramDashboard_rcps").Rows(0)("TotalApplication"))).ToString()
    End Sub

    'Private Sub BindServiceList()
    '    dsEntry = New DataSet
    '    objcrud = New cDashBoard
    '    Dim objParameter As New cParameter(dsEntry)
    '    objParameter.CreateParameter(dsEntry, "@Top10", 1)
    '    objcrud.Select_ServiceList_PanchayatDB(dsEntry, enmDashboard.Select_ServiceList_PanchayatDB)
    '    If dsEntry.Tables("Top_Service").Rows.Count > 0 Then
    '        dlServiceList.DataSource = dsEntry.Tables("Top_Service")
    '        dlServiceList.DataBind()
    '    End If
    'End Sub

    'Private Sub BindTopGramPanchayat()
    '    dsEntry = New DataSet
    '    objcrud = New cDashBoard
    '    Dim objParameter As New cParameter(dsEntry)
    '    objParameter.CreateParameter(dsEntry, "@Top10", 1)
    '    objcrud.Select_GramPanchyat_PanchayatDB(dsEntry, enmDashboard.Select_GramPanchyat_PanchayatDB)
    '    If dsEntry.Tables("Top_GramPanchayat").Rows.Count > 0 Then
    '        dlTopGramPanchayat.DataSource = dsEntry.Tables("Top_GramPanchayat")
    '        dlTopGramPanchayat.DataBind()
    '    End If
    'End Sub

    Private Sub MergeServiceList()
        dsEntry = New DataSet
        objcrud = New cDashBoard
        objcrud1 = New cDashBoard
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim objParameter As New cParameter(dsEntry)
        objcrud.Select_ServiceList_PanchayatDB(dsEntry, enmDashboard.Select_ServiceList_PanchayatDB)
        If dsEntry.Tables("Top_Service").Rows.Count > 0 Then
            dt1 = dsEntry.Tables("Top_Service")
        End If
        objcrud1.Select_ServiceList_RCPSDB(dsEntry, enmDashboard.Select_ServiceList_RCPSDB)
        If dsEntry.Tables("Top_Service").Rows.Count > 0 Then
            dt2 = dsEntry.Tables("Top_Service")
        End If
        dt1.Merge(dt2, True)
        dt1.AcceptChanges()
        Dim ServiceGroups = dt1.AsEnumerable().GroupBy(Function(row) row.Field(Of Int32)("ServiceId"))
        Dim tableResult = dt1.Clone()
        For Each grp In ServiceGroups
            tableResult.Rows.Add(grp.Key, grp.First().Field(Of String)("ServiceNameE"),
                                 grp.First().Field(Of String)("ServiceNameG"),
                                 grp.First().Field(Of String)("ServiceImage"),
                                 grp.Sum(Function(row) row.Field(Of Int32)("ApplicationCount")))
        Next
        tableResult.DefaultView.Sort = "ApplicationCount DESC"
        tableResult = tableResult.DefaultView.ToTable()
        dlServiceList.DataSource = tableResult.AsEnumerable().Skip(0).Take(10).CopyToDataTable()
        dlServiceList.DataBind()
    End Sub

    Private Sub MergeGramPanchayat()
        dsEntry = New DataSet
        objcrud = New cDashBoard
        objcrud1 = New cDashBoard
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim objParameter As New cParameter(dsEntry)
        objcrud.Select_GramPanchyat_PanchayatDB(dsEntry, enmDashboard.Select_ServiceList_PanchayatDB)
        If dsEntry.Tables("Top_GramPanchayat").Rows.Count > 0 Then
            dt1 = dsEntry.Tables("Top_GramPanchayat")
        End If
        objcrud1.Select_GramPanchyat_RCPSDB(dsEntry, enmDashboard.Select_ServiceList_RCPSDB)
        If dsEntry.Tables("Top_GramPanchayat").Rows.Count > 0 Then
            dt2 = dsEntry.Tables("Top_GramPanchayat")
        End If
        dt1.Merge(dt2, True)
        dt1.AcceptChanges()
        Dim ServiceGroups = dt1.AsEnumerable().GroupBy(Function(row) row.Field(Of Int32)("OfficeId"))
        Dim tableResult = dt1.Clone()
        For Each grp In ServiceGroups
            tableResult.Rows.Add(grp.Key, grp.First().Field(Of String)("OfficeNameE"),
                                 grp.First().Field(Of String)("OfficeNameG"),
                                 grp.Sum(Function(row) row.Field(Of Int32)("ApplicationCount")))
        Next
        tableResult.DefaultView.Sort = "ApplicationCount DESC"
        tableResult = tableResult.DefaultView.ToTable()
        dlTopGramPanchayat.DataSource = tableResult.AsEnumerable().Skip(0).Take(10).CopyToDataTable()
        dlTopGramPanchayat.DataBind()
    End Sub


    'Private Sub BulkImportData()
    '    dsEntry = New DataSet
    '    objcrud = New cDashBoard
    '    Dim objParameter As New cParameter(dsEntry)
    '    objcrud.Select_GramPanchyat_PanchayatDB(dsEntry, enmDashboard.Select_GramPanchyat_PanchayatDB)
    '    If dsEntry.Tables("Top_GramPanchayat").Rows.Count > 0 Then
    '        objcrud.BulkImportDemo(dsEntry, "@OfficeDetail", dsEntry.Tables("Top_GramPanchayat"))
    '    End If
    'End Sub

    Protected Sub lnkService_Click(sender As Object, e As EventArgs)
        Dim url As String = "DepartmentWiseServiceCount.aspx"
        Dim s As String = "window.open('" & url + "', 'popup_window', 'width=800,height=400,left=200,top=200,resizable=yes');"
        ClientScript.RegisterStartupScript(Me.GetType(), "script", s, True)
    End Sub
    Protected Sub lnkgram_Click(sender As Object, e As EventArgs)
        Dim url As String = "FrmGrampanchayatCount.aspx"
        Dim s As String = "window.open('" & url + "', 'popup_window', 'width=800,height=400,left=200,top=200,resizable=yes');"
        ClientScript.RegisterStartupScript(Me.GetType(), "script", s, True)
    End Sub
End Class