Imports DesignApp
Imports System.Data
Imports System.Threading
Imports System.Threading.Thread
Imports NICFrameWork.LibCommon

Public Class SearchLicencePermit
    Inherits Scheme
    Dim ds As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds = New DataSet
        If Not IsPostBack Then
            FillDept(ddlDept)

            bind()

        End If

    End Sub
    Public Sub bind()
        Dim obj As Licence
        obj = New Licence
        Dim licenceid As Integer = 0


        Dim objParameter As New cParameter(ds)
        getCollection(objParameter, 1)
        obj.GetDataSet(ds, 0)

        GridView1.DataSource = ds.Tables("LicenceDetailDeptWise")
        GridView1.DataBind()
    End Sub
    Private Sub getCollection(ByRef objParameter As cParameter, ByVal index As Int16, Optional ByVal common As Boolean = False)
        If IsNothing(objParameter) Then
            objParameter = New cParameter(ds)
        End If

        Select Case index
            Case 1

                objParameter.CreateParameter(ds, "@deptID", ddlDept.SelectedValue, enmParameterType.Input, SqlDbType.Int)



        End Select

    End Sub

    'Public Sub chkActBind()
    '    Try


    '        Dim dt As New DataTable
    '        dt = FillAct()
    '        chkAct.Items.Clear()
    '        chkAct.DataSource = dt
    '        chkAct.DataTextField = dt.Columns(1).ToString
    '        chkAct.DataValueField = dt.Columns(0).ToString
    '        chkAct.DataBind()


    '    Catch ex As Exception
    '        lblexe.Text = ex.Message
    '    End Try
    'End Sub
    'Public Sub chkGRBind()
    '    Try


    '        Dim dt As New DataTable
    '        dt = FillGR()
    '        chkGR.Items.Clear()
    '        chkGR.DataSource = dt
    '        chkGR.DataTextField = dt.Columns("GRName").ToString
    '        chkGR.DataValueField = dt.Columns("GROrderId").ToString
    '        chkGR.DataBind()

    '    Catch ex As Exception
    '        lblexe.Text = ex.Message
    '    End Try
    'End Sub

    'Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    If ddlDept.SelectedValue > 0 And txtLicenceName.Text.Trim.Length > 0 Then
    '        Dim obj As Licence
    '        obj = New Licence
    '        Dim licenceid As Integer = 0
    '        Dim ds As DataSet
    '        ds = New DataSet
    '        Dim drEntryPage As DataRow
    '        Dim objParameter As New cParameter(ds, "Licence")
    '        getTableColumn(ds, "Licence")
    '        ds.Tables("Licence").Rows.Clear()
    '        drEntryPage = ds.Tables("Licence").NewRow()
    '        SetValue(drEntryPage)
    '        ds.Tables("Licence").Rows.Add(drEntryPage)
    '        licenceid = obj.InsertDetail(ds, 0)
    '        If licenceid > 0 Then
    '            If chkAct.Items.Count > 0 Then
    '                For Each Items As ListItem In chkAct.Items
    '                    If Items.Selected = True Then
    '                        Dim dsact As DataSet
    '                        dsact = New DataSet
    '                        Dim drEntryPageact As DataRow
    '                        Dim objParameteract As New cParameter(dsact, "Licence")
    '                        getTableColumnAct(dsact, "Licence")
    '                        dsact.Tables("Licence").Rows.Clear()
    '                        drEntryPageact = dsact.Tables("Licence").NewRow()
    '                        SetValueAct(drEntryPageact, Items.Value, licenceid)
    '                        dsact.Tables("Licence").Rows.Add(drEntryPageact)
    '                        obj.InsertAct(dsact, 0)
    '                    End If


    '                Next
    '            End If
    '            If chkGR.Items.Count > 0 Then
    '                For Each Items As ListItem In chkGR.Items
    '                    If Items.Selected = True Then
    '                        Dim dsgr As DataSet
    '                        dsgr = New DataSet
    '                        Dim drEntryPagegr As DataRow
    '                        Dim objParameteract As New cParameter(dsgr, "Licence")
    '                        getTableColumnGR(dsgr, "Licence")
    '                        dsgr.Tables("Licence").Rows.Clear()
    '                        drEntryPagegr = dsgr.Tables("Licence").NewRow()
    '                        SetValueGR(drEntryPagegr, Items.Value, licenceid)
    '                        dsgr.Tables("Licence").Rows.Add(drEntryPagegr)
    '                        obj.InsertGR(dsgr, 0)
    '                    End If


    '                Next
    '            End If

    '        End If

    '    Else
    '        If ddlDept.SelectedValue = 0 Then
    '        ElseIf txtLicenceName.Text.Trim.Length = 0 Then


    '        End If
    '    End If

    '    lblexe.Text = "Data Added or Changed Successfully"

    'End Sub

    'Protected Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    'End Sub

    'Private Sub getTableColumn(ByRef ds As DataSet, ByVal strTableName As String)
    '    With ds.Tables(strTableName).Columns

    '        .Add("DepartmentID", System.Type.GetType("System.Int32"))
    '        .Add("LicenceDetail", System.Type.GetType("System.String"))
    '        .Add("NameOfRules", System.Type.GetType("System.String"))
    '        .Add("IssuingAuthoDesig", System.Type.GetType("System.String"))
    '        .Add("RenewalAuthoDesig", System.Type.GetType("System.String"))
    '        .Add("licenceTimelimit", System.Type.GetType("System.Int32"))
    '        .Add("RenewallicenceTimeLimit", System.Type.GetType("System.Int32"))
    '        .Add("createdon", System.Type.GetType("System.String"))
    '        .Add("createdby", System.Type.GetType("System.Int32"))
    '        .Add("updatedon", System.Type.GetType("System.String"))
    '        .Add("updatedby", System.Type.GetType("System.Int32"))
    '    End With
    'End Sub
    'Private Sub SetValue(ByRef drEntryPage As DataRow)
    '    Dim objUserInfo As cUserInfo
    '    objUserInfo = CType(Session("objUserInfo"), cUserInfo)
    '    With drEntryPage

    '        .Item("DepartmentID") = ddlDept.SelectedValue
    '        .Item("LicenceDetail") = txtLicenceName.Text.Trim
    '        .Item("NameOfRules") = txtNameOfRules.Text.Trim
    '        .Item("IssuingAuthoDesig") = txtIssuingDesig.Text.Trim
    '        .Item("RenewalAuthoDesig") = txtRenewalDesig.Text.Trim
    '        .Item("licenceTimelimit") = txtIssueValid.Text.Trim
    '        .Item("RenewallicenceTimeLimit") = txtRenewalValid.Text.Trim
    '        .Item("createdby") = objUserInfo.UserID
    '        .Item("updatedby") = objUserInfo.UserID
    '    End With
    'End Sub

    'Private Sub getTableColumnAct(ByRef ds As DataSet, ByVal strTableName As String)
    '    With ds.Tables(strTableName).Columns

    '        .Add("DepartmentLicenceID", System.Type.GetType("System.Int32"))
    '        .Add("ActID", System.Type.GetType("System.Int16"))
    '        .Add("createdon", System.Type.GetType("System.String"))
    '        .Add("createdby", System.Type.GetType("System.Int32"))
    '        .Add("updatedon", System.Type.GetType("System.String"))
    '        .Add("updatedby", System.Type.GetType("System.Int32"))
    '    End With
    'End Sub
    'Private Sub SetValueAct(ByRef drEntryPage As DataRow, ByVal id As Integer, ByRef lid As Integer)
    '    Dim objUserInfo As cUserInfo
    '    objUserInfo = CType(Session("objUserInfo"), cUserInfo)
    '    With drEntryPage


    '        .Item("DepartmentLicenceID") = lid
    '        .Item("ActID") = id
    '        .Item("createdby") = objUserInfo.UserID
    '        .Item("updatedby") = objUserInfo.UserID
    '    End With
    'End Sub


    'Private Sub getTableColumnGR(ByRef ds As DataSet, ByVal strTableName As String)
    '    With ds.Tables(strTableName).Columns

    '        .Add("DepartmentLicenceID", System.Type.GetType("System.Int32"))
    '        .Add("GRID", System.Type.GetType("System.Int64"))
    '        .Add("createdon", System.Type.GetType("System.String"))
    '        .Add("createdby", System.Type.GetType("System.Int32"))
    '        .Add("updatedon", System.Type.GetType("System.String"))
    '        .Add("updatedby", System.Type.GetType("System.Int32"))
    '    End With
    'End Sub
    'Private Sub SetValueGR(ByRef drEntryPage As DataRow, ByVal id As Integer, ByRef lid As Integer)
    '    Dim objUserInfo As cUserInfo
    '    objUserInfo = CType(Session("objUserInfo"), cUserInfo)
    '    With drEntryPage

    '        .Item("DepartmentLicenceID") = lid
    '        .Item("GRID") = id
    '        .Item("createdby") = objUserInfo.UserID
    '        .Item("updatedby") = objUserInfo.UserID
    '    End With
    'End Sub

    Protected Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        bind()
    End Sub

End Class