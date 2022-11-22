Imports NIC.LibApp
Imports LibReports
Imports NICFrameWork.LibCommon
Imports System.Net

Public Class frmNews
    Inherits System.Web.UI.Page
    Private dtlink As DataTable
    Private dt As DataTable
    Private dsEntry As DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim hostname As String = Dns.GetHostName()
        Dim strIPCheck As String = My.Settings.IP
        Dim strotherIP As String = My.Settings.IP1
        Dim ipaddress As String = CType(Dns.GetHostByName(hostname).AddressList.GetValue(0), IPAddress).ToString
        Dim id As String = Request.QueryString("ID")
        ' Response.Write(strIPCheck & "-" & ipaddress)
        If (strIPCheck = ipaddress Or strotherIP = ipaddress) And id = "adigitalGNRabcdt" Then
            Bind_News()
        End If

    End Sub
    Protected Sub Bind_News()
        Try

            Dim dtexists As New DataTable
            Dim objcmap As New cNews
            ' objcmap.GetDataSetForExists(dtexists, enmnews.news)

            dsEntry = New DataSet
            Dim objParameter As New cParameter(dsEntry)

            objcmap.GetDataSet(dsEntry, enmnews.news)


            If dtexists.Rows.Count > 0 Then
                objcmap.DeleteAllNews("NewsTable", enmnews.news)
            End If
            Dim objServicePressRelase As New DigitalGujaratPressRelease.DigitalGujaratSoapClient

            Dim Press As String
            Press = objServicePressRelase.LatestPressReleases()
            ' Response.Write(Press)

            Dim ds As New DataSet
            Dim xmldoc As New System.Xml.XmlDocument
            xmldoc.LoadXml(Press)
            For i As Integer = 0 To xmldoc.ChildNodes(0).ChildNodes.Count - 1
                Dim newLi As New HtmlGenericControl
                newLi.ID = "ctrlLi" & i
                newLi.TagName = "li"
                Dim newA As New HtmlGenericControl
                newA.ID = "ctrlai" & i
                newA.TagName = "a"
                newA.InnerText = xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText
                newA.Attributes.Add("href", xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(2).InnerText)
                newA.Attributes.Add("target", "_blank")
                Dim urlvar As String
                urlvar = xmldoc.ChildNodes(0).ChildNodes(i).ChildNodes(2).InnerText

                Dim drEntryPage As DataRow
                dt = New DataTable
                getTableColumn(dt, "NewsTable")

                drEntryPage = dt.NewRow()
                With drEntryPage

                    .Item("NewsTitle") = newA.InnerText

                    .Item("NewsUrl") = urlvar

                    .Item("IsActive") = True
                End With
                dt.Rows.Add(drEntryPage)
                Dim obj As New cNews
                obj.InsertNews(dt, enmnews.news)
                'Response.Write("test 11" + i)
            Next

        Catch ex As Exception
            ex.Message.ToString()
            ' Response.Write(ex.Message.ToString())
        End Try
    End Sub
    Private Sub getTableColumn(ByRef ds As DataTable, ByVal strTableName As String)
        With ds.Columns
            .Add("NewsId", System.Type.GetType("System.Int64"))
            .Add("NewsTitle", System.Type.GetType("System.String"))
            .Add("NewsUrl", System.Type.GetType("System.String"))
            .Add("IsActive", System.Type.GetType("System.Boolean"))
        End With
    End Sub
End Class