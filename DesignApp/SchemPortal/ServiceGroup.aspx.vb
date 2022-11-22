Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports System.IO

Public Class ServiceGroup
    Inherits System.Web.UI.Page
    Private dsEntry As DataSet
    Private objsearch As cSearch

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            FillTabs()
            multiview.ActiveViewIndex = 1
            FillLifeEvents()
        End If
    End Sub

    Private Sub FillTabs()
        dsEntry = New DataSet
        objsearch = New cSearch
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
        objsearch.SelectTabs(dsEntry)
        If dsEntry.Tables("Tabs").Rows.Count > 0 Then
            dltabs.DataSource = dsEntry.Tables("Tabs")
            dltabs.DataBind()
        End If
    End Sub

    Protected Sub dltabs_ItemCommand(source As Object, e As DataListCommandEventArgs)
        If e.CommandName = "redirect" Then

            Dim tabid As String = e.CommandArgument.ToString()
            If tabid = 1 Then
                multiview.ActiveViewIndex = 0
            ElseIf tabid = 2 Then
                multiview.ActiveViewIndex = 1
                FillLifeEvents()
            ElseIf tabid = 3 Then
                multiview.ActiveViewIndex = 2
                FillDepartment()
            ElseIf tabid = 4 Then
                multiview.ActiveViewIndex = 3
                FillSector()
            ElseIf tabid = 5 Then
                multiview.ActiveViewIndex = 3
                'FillSector()
                FillServices()
            Else
                multiview.ActiveViewIndex = 0
            End If
        Else
        End If
    End Sub

    Protected Sub dldepartment_ItemCommand(source As Object, e As DataListCommandEventArgs)
        If e.CommandName = "redirect" Then
            If e.CommandName = "redirect" Then
                Dim departmentId As String = e.CommandArgument.ToString()
                Session("departmentid") = departmentId
                hfDepartmentId.Value = departmentId
                Session("mode") = "dept"
                Response.Redirect("ResultData.aspx")
            End If
        End If
    End Sub

    Protected Sub dlsector_ItemCommand(source As Object, e As DataListCommandEventArgs)
        If e.CommandName = "redirect" Then
            If e.CommandName = "redirect" Then
                Dim sectorId As String = e.CommandArgument.ToString()
                Session("Id1") = sectorId
                hfSectorId.Value = sectorId
                Session("departmentid") = ""
                Session("mode") = "sector"
                Response.Redirect("ResultData.aspx")
            End If
        End If
        'If e.CommandName = "redirect" Then
        '    If e.CommandName = "redirect" Then
        '        Dim ServiceID As String = e.CommandArgument.ToString()
        '        Dim DeptID As HiddenField = (CType(e.Item.FindControl("hfDeptID"), HiddenField))
        '        Session("Id1") = ServiceID
        '        hfSectorId.Value = ServiceID
        '        Dim hfDeptID As Integer = DeptID.Value
        '        Session("departmentid") = hfDeptID
        '        Session("mode") = "Service"
        '        Response.Redirect("ResultData.aspx")
        '    End If
        'End If
    End Sub

    Protected Sub dlLifeEvents_ItemCommand(source As Object, e As DataListCommandEventArgs)
        If e.CommandName = "redirect" Then
            Dim eventid As String = e.CommandArgument.ToString()
            Session("eventid") = eventid
            Session("mode") = "event"
            Response.Redirect("ResultData.aspx")
        End If
    End Sub
    Private Sub FillServices()
        dsEntry = New DataSet
        objsearch = New cSearch

        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
        objsearch.SelectDataPanchayatAll(dsEntry)

        If dsEntry.Tables("DepartmentServicePanchayatDBAll").Rows.Count > 0 Then
            dlsector.DataSource = dsEntry.Tables("DepartmentServicePanchayatDBAll")
            dlsector.DataBind()
        End If

        'objsearch1.SelectData(dsEntry, enmDashboard.Select_ServiceList_RCPSDB)
        'If dsEntry.Tables("DepartmentServiceRCPSDB").Rows.Count > 0 Then
        '    dt2 = dsEntry.Tables("DepartmentServiceRCPSDB")
        'End If
        'dt1.Merge(dt2, True)
        'dt1.AcceptChanges()
        'dt1.DefaultView.Sort = "DepartmentNameE ASC"
        'dt1 = dt1.DefaultView.ToTable()

    End Sub
    Private Sub FillLifeEvents()
        dsEntry = New DataSet
        objsearch = New cSearch
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
        objsearch.SelectLifeEvents(dsEntry)
        If dsEntry.Tables("tblLifeEventsMaster").Rows.Count > 0 Then
            dlLifeEvents.DataSource = dsEntry.Tables("tblLifeEventsMaster")
            dlLifeEvents.DataBind()
        End If
    End Sub

    Private Sub FillDepartment()
        dsEntry = New DataSet
        objsearch = New cSearch
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
        objsearch.SelectDepartment(dsEntry)
        If dsEntry.Tables("Department").Rows.Count > 0 Then
            dldepartment.DataSource = dsEntry.Tables("Department")
            dldepartment.DataBind()
        End If
    End Sub

    Private Sub FillSector()
        dsEntry = New DataSet
        objsearch = New cSearch
        Dim objParameter As New cParameter(dsEntry)
        objParameter.CreateParameter(dsEntry, "@Flag", Session("MyCulture").ToString())
        objsearch.SelectSector(dsEntry)
        If dsEntry.Tables("SectorMaster").Rows.Count > 0 Then
            dlsector.DataSource = dsEntry.Tables("SectorMaster")
            dlsector.DataBind()
        End If
    End Sub

    Public ReadOnly Property DepartmentId As Integer
        Get
            Return hfDepartmentId.Value
        End Get
    End Property
    Public ReadOnly Property SectorId As Integer
        Get
            Return hfSectorId.Value
        End Get
    End Property



End Class