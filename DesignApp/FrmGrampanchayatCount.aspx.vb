Imports NICFrameWork.LibCommon
Imports NIC.LibApp
Public Class FrmGrampanchayatCount
    Inherits cBaseForm

    Private dsEntry As DataSet
    Private objcrud As cDashBoard
    Private objcrud1 As cDashBoard

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindGrid()
        End If
        If IsNothing(Session("MyCulture")) Then
            Session("MyCulture") = "en-GB"
        End If
    End Sub
    Private Sub BindGrid()
        dsEntry = New DataSet
        objcrud = New cDashBoard
        objcrud1 = New cDashBoard
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
        objcrud.FrmGrampanchayatCount(dsEntry, enmDashboard.FrmGrampanchayatCount)
        If (dsEntry.Tables("Grampanchayatcount") IsNot Nothing AndAlso dsEntry.Tables("Grampanchayatcount").Rows.Count > 0) Then
            'If dsEntry.Tables("Grampanchayatcount").Rows.Count > 0 Then
            dt1 = dsEntry.Tables("Grampanchayatcount")
        End If

        dt1.Merge(dt2, True)
        dt1.AcceptChanges()
        dt1.DefaultView.Sort = "DistrictName"
        dt1 = dt1.DefaultView.ToTable()
        gvFrmGrampanchayatCount.DataSource = dt1
        gvFrmGrampanchayatCount.DataBind()
    End Sub
    Protected Sub RequestLanguageChange_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGujarati.Click
        Dim senderLink As LinkButton = sender
        Session("MyCulture") = senderLink.CommandArgument
        Server.Transfer(Request.Path)
    End Sub
End Class