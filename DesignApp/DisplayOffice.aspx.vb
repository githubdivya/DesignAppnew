Imports NIC.LibApp
Imports LibReports
Imports NICFrameWork.LibCommon



Public Class DisplayOffice
    Inherits cBaseForm
    Private dsEntry As DataSet
    Private objcmap As cMap

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            fillDistrict()
            fillTaluka()
        End If
    End Sub



    Private Sub fillDistrict()
        dsEntry = New DataSet

        Dim objParameter As New cParameter(dsEntry)
        objcmap = New cMap
        objcmap.GetDataSet(dsEntry, enmcMap.District)
        ddlDistrict.DataSource = dsEntry.Tables("District")
        ddlDistrict.Items.Clear()
        ddlDistrict.DataTextField = "DistrictName"
        ddlDistrict.DataValueField = "DistrictID"
        ddlDistrict.DataBind()
        ddlDistrict.SelectedValue = 0
        ddlDistrict.Items.Insert(0, New ListItem("<--All-->", 0))
    End Sub

    Private Sub fillTaluka()
        dsEntry = New DataSet
        Dim objParameter As New cParameter(dsEntry)
        objcmap = New cMap
        objParameter.CreateParameter(dsEntry, "@DistrictID", ddlDistrict.selectedvalue, enmParameterType.Input, SqlDbType.Text)
        objcmap.GetDataSet(dsEntry, enmcMap.Taluka)
        ddlCity.DataSource = dsEntry.Tables("Taluka")
        ddlCity.Items.Clear()
        ddlCity.DataTextField = "TalukaName"
        ddlCity.DataValueField = "TalukaID"
        ddlCity.DataBind()
        ddlCity.Items.Insert(0, New ListItem("<--All-->", 0))
    End Sub

    Protected Sub ddlDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDistrict.SelectedIndexChanged
        filltaluka()
    End Sub

    Protected Sub BindDataGrid()

       
        dsEntry = New DataSet()
        Dim objparameter As New cParameter(dsEntry)

        objParameter.CreateParameter(dsEntry, "@DistrictID", ddlDistrict.selectedvalue, enmParameterType.Input, SqlDbType.Text)
        objParameter.CreateParameter(dsEntry, "@city", ddlcity.selectedvalue, enmParameterType.Input, SqlDbType.Text)

        objcmap = New cmap
        objcmap.GetDataSet(dsEntry, enmcMap.Office_Details_show)
        gv_Office.DataSource = dsEntry.Tables("Office_Details_show")
        gv_Office.DataBind()




    End Sub

    Protected Sub btnShowReport_Click(sender As Object, e As EventArgs) Handles btnShowReport.Click
        BindDataGrid()
    End Sub
End Class