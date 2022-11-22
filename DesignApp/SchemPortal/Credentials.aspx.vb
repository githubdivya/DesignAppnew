Imports System.Data
Imports System.Threading
Imports System.Environment
Imports DesignApp

Partial Class Credentials
    Inherits Scheme
    Dim obj As New WebService
    Dim ds As New DataSet
    Dim Sector, Category, Reli, SocEco, Age, AppTo, AppArea, ScBFT As Integer
    Dim Caste, Profession, Education As String
    Dim Income, FamIncome As Decimal
    Dim gen As String

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'Dim ds As DataSet
        SetParameter()
        Session("mode") = "wide"
        Response.Redirect("ResultData.aspx")

        'Dim scriptString As String = String.Empty

        'scriptString += "<script language=javascript>"

        'scriptString += "window.showModalDialog('ResultData.aspx','MyWindow','dialogWidth:700px');"

        'scriptString += "</script>"

        'Response.Write(scriptString)

        'Response.Redirect("<Script> Window.showModalDialog('ResultData.aspx','MyWindow','dialogWidth:700px');")
        'btnSubmit.Attributes.Add("OnClick", "window.showModalDialog('ResultData.aspx','MyWindow','dialogWidth:700px');")
        'ds = obj.GetData(Session("Parameter"))

        'If Not ds Is Nothing Then
        '    GridView1.DataSource = ds
        '    GridView1.DataBind()
        'Else
        '    Label1.Text = "No Records Found"
        'End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        ClearGridView(GridView1)
        If Not Page.IsPostBack Then
            BindCombo()
        End If
    End Sub

    Public Sub SetParameter()
        Sector = ddlSector.SelectedValue
        Category = ddlCategory.SelectedValue
        Reli = ddlReligion.SelectedValue
        Caste = ddlCaste.SelectedValue
        SocEco = ddlSocioStd.SelectedValue
        If txtAge.Text <> "" Then
            Age = txtAge.Text.Trim
        Else
            Age = 0
        End If
        gen = ddlGender.SelectedValue
        Profession = ddlProfession.SelectedValue
        Education = ddlEducation.SelectedValue
        AppTo = ddlScAppTo.SelectedValue
        AppArea = ddlScAppArea.SelectedValue
        ScBFT = ddlBFType.SelectedValue

        If txtIncome.Text.Trim <> "" Then
            Income = CDec(txtIncome.Text.Trim)
        Else
            Income = 0.0
        End If
        If txtFamIncome.Text.Trim <> "" Then
            FamIncome = CDec(txtFamIncome.Text.Trim)
        Else
            FamIncome = 0.0
        End If
        Session("Parameter") = Sector & "," & Category & "," & Reli & "," & Caste & "," & SocEco & "," & gen & "," & Age & "," & Income & "," & FamIncome & "," & Profession & "," & Education & "," & AppTo & "," & AppArea & "," & ScBFT
    End Sub
    Public Sub SetParameterexact()
        Sector = ddlSector.SelectedValue
        Category = ddlCategory.SelectedValue
        Reli = ddlReligion.SelectedValue
        Caste = ddlCaste.SelectedValue
        SocEco = ddlSocioStd.SelectedValue
        If txtAge.Text <> "" Then
            Age = txtAge.Text.Trim
        Else
            Age = 0
        End If
        'Dim str As Integer
        gen = ddlGender.SelectedValue
        'If str = 0 Then
        '    gen = "0"
        'ElseIf str = 1 Then
        '    gen = "M"
        'ElseIf str = 2 Then
        '    gen = "F"
        'ElseIf str = 3 Then
        '    gen = "MW"
        'ElseIf str = 4 Then
        '    gen = "FW"
        'ElseIf str = 5 Then
        '    gen = "FO"
        'End If


        Profession = ddlProfession.SelectedValue
        Education = ddlEducation.SelectedValue
        AppTo = ddlScAppTo.SelectedValue
        AppArea = ddlScAppArea.SelectedValue
        ScBFT = ddlBFType.SelectedValue

        If txtIncome.Text.Trim <> "" Then
            Income = CDec(txtIncome.Text.Trim)
        Else
            Income = 0.0
        End If
        If txtFamIncome.Text.Trim <> "" Then
            FamIncome = CDec(txtFamIncome.Text.Trim)
        Else
            FamIncome = 0.0
        End If
        Session("Parameter") = Sector & "," & Category & "," & Reli & "," & Caste & "," & SocEco & "," & gen & "," & Age & "," & Income & "," & FamIncome & "," & Profession & "," & Education & "," & AppTo & "," & AppArea & "," & ScBFT
    End Sub
    Public Sub BindCombo()
        FillSector(ddlSector)
        FillScCategory(ddlCategory)
        FillOccupation(ddlProfession)
        FillEducation(ddlEducation)
        FillSocioEco(ddlSocioStd)
        FillCaste1(ddlCaste)
        FillScAppTo(ddlScAppTo)
        FillReligion(ddlReligion)
        FillScAppArea(ddlScAppArea)
        FillBFType(ddlBFType)
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExact.Click
        SetParameterexact()
        Session("mode") = "exact"
        Response.Redirect("ResultData.aspx")
    End Sub

    Protected Sub btnnormal_Click(sender As Object, e As EventArgs) Handles btnnormal.Click
        SetParameterexact()
        Session("mode") = "normal"
        Response.Redirect("ResultData.aspx")
    End Sub
End Class
