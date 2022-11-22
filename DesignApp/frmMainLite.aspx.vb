Imports NIC.LibApp

Imports NICFrameWork.LibCommon
Public Class frmMainLite
    Inherits cBaseForm
    Private objcmap As cMap

    Private ds As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            fillcount()
            Links()
        End If

    End Sub

    Protected Sub lnklogin_Click(sender As Object, e As EventArgs) Handles lnklogin.Click
        Response.Redirect(My.Settings.LoginURL)
    End Sub
    Protected Sub lnkregistation_Click(sender As Object, e As EventArgs) Handles lnkregistation.Click
        Response.Redirect(My.Settings.RegistrationURL)
    End Sub

    Private Sub fillcount()
        ds = New DataSet

        'getCollection(objParameter, 15)
        Dim objParameter As New cParameter(ds)
        Dim objcmap As New cTReceipt_Citizen
        Dim display As String = ""
        objcmap.GetDataSet(ds, enmTReceiptCitizen.ShowCount)
        Dim count As List(Of String) = New List(Of String)
        Dim i As Integer
        For i = 0 To ds.Tables("Receipt").Rows.Count - 1

            display += "<div class='swiper-slide' style='width: 24px;'><span class='count'>"

            display += " " + ds.Tables("Receipt").Rows(i)("countgroup").ToString() + ""
            display += "</span> <span class='countTitle'>" + ds.Tables("Receipt").Rows(i)("Group_Name").ToString() + "</span></div>"
            ltcount.Text = display

        Next


    End Sub
    Private Sub Links()
        ds = New DataSet

        'getCollection(objParameter, 15)
        Dim objParameter As New cParameter(ds)
        Dim objcmap As New cTReceipt_Citizen
        Dim display As String = ""
        objcmap.GetDataSet(ds, enmTReceiptCitizen.ShowLink)
        Dim i As Integer
        For i = 0 To ds.Tables("Receipt").Rows.Count - 1

            display += "<li><a runat='server' href='" + ds.Tables("Receipt").Rows(i)("Link").ToString() + "'"
            display += ">'" + ds.Tables("Receipt").Rows(i)("Linkname").ToString() + "'</a></li>"
            ltLink.Text = display

        Next



    End Sub
End Class