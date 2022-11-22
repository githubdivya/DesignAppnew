Imports DesignApp

Public Class SearchDeaprtment
    Inherits Scheme
    Dim mode As String
    Dim Id1 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'mode = Request.QueryString("mode")
        mode = Session("mode")
        lblexe.Text = ""
        If Not Page.IsPostBack Then
            Redirectpage(mode)

            If Session("MyCulture") = "gu" Then
                lbldept.Text = Me.GetLocalResourceObject("lbldept")
                lblSecor.Text = Me.GetLocalResourceObject("lblSector")
                lblscappto.Text = Me.GetLocalResourceObject("lblscappto")
                lblcaste.Text = Me.GetLocalResourceObject("lblcaste")
                lblScArea.Text = Me.GetLocalResourceObject("lblScArea")
                lblscbenefit.Text = Me.GetLocalResourceObject("lblscbenefit")
                lblsctarget.Text = Me.GetLocalResourceObject("lblsctarget")
                lblowned.Text = Me.GetLocalResourceObject("lblowned")
                lblkeyword.Text = Me.GetLocalResourceObject("lblkeyword")
            End If
        End If

    End Sub
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Search(mode)
    End Sub
    Public Sub Redirectpage(ByVal mode As String)
        If mode = "Department" Then
            MultiView1.SetActiveView(vDept)
            FillDept(ddldept)
        ElseIf mode = "Sector" Then
            MultiView1.SetActiveView(vSector)
            FillSector(ddlsector)
        ElseIf mode = "Beneficiary" Then
            MultiView1.SetActiveView(vscappto)
            FillScAppTo(ddlScappto)
        ElseIf mode = "Category" Then
            MultiView1.SetActiveView(vcaste)
            FillCaste(ddlcaste)
        ElseIf mode = "Applicable" Then
            MultiView1.SetActiveView(vScArea)
            FillScAppArea(ddlScAppArea)
        ElseIf mode = "Benefit" Then
            MultiView1.SetActiveView(VscBenefit)
            FillBFType(ddlScBenefit)
        ElseIf mode = "Scheme" Then
            MultiView1.SetActiveView(VscTarget)
        ElseIf mode = "Owned" Then
            MultiView1.SetActiveView(VscOwned)
            FillScCategory(ddlOwned)
        ElseIf mode = "Keyword" Then
            MultiView1.SetActiveView(Vkeyword)
        End If
    End Sub
    Public Sub Search(ByVal mode As String)
        If mode = "Department" Then
            Session("Id1") = ddldept.SelectedValue
            Id1 = ddldept.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Sector" Then
            Session("Id1") = ddlsector.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Beneficiary" Then
            Session("Id1") = ddlScappto.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Category" Then
            Session("Id1") = ddlcaste.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Applicable" Then
            Session("Id1") = ddlScAppArea.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Benefit" Then
            Session("Id1") = ddlScBenefit.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Scheme" Then
            Session("Id1") = ddlTarget.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Owned" Then
            Session("Id1") = ddlOwned.SelectedValue
            Response.Redirect("ResultData.aspx")
        ElseIf mode = "Keyword" Then
            If txtSearchKeyword.Text.Trim <> "" Then
                Session("Id1") = txtSearchKeyword.Text.Trim
                Response.Redirect("ResultData.aspx")
            Else
                lblexe.Text = "Please Enter Keyword for search"
            End If
        End If
    End Sub

End Class