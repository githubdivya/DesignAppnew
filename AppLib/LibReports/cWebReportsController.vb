Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enmIndexWebReports
    ''' <summary>
    ''' Start Index from 1000 for web
    ''' </summary>
    ''' <remarks></remarks>
    OfficeInfo = 1000
    UserInfo = 1001
    SingleDayCollection = 1002
    OfficeCollection = 1003
    OfficeDutyCollection = 1004
    Mutation = 1005
    IncomeTax = 1006
End Enum
Public Interface IcWebReportsController

End Interface
Public Class cWebReportsController
    Inherits cBLBase

    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            If ds.Tables.Contains("Parameter") = True Then
                With ds.Tables("Parameter")
                    For i = 0 To .Rows.Count - 1
                        If CInt(.Rows(i).Item("PType")) = 1 Then
                            If .Rows(i).Item("DbType").ToString = "DateTime" Then
                                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, CDate(.Rows(i).Item("Pvalue"))))
                            Else
                                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                            End If
                        ElseIf IsDBNull(.Rows(i).Item("Pvalue")) Then
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                        Else
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, New System.Guid(.Rows(i).Item("Pvalue").ToString)))
                        End If
                    Next
                End With
            End If
            Select Case CType(index, enmIndexWebReports)
                Case enmIndexWebReports.OfficeInfo
                    objDataExecute.getDataSet(ds, "RPT_OfficeInfo", objColCriteria, "OfficeInfo", Nothing)
                Case enmIndexWebReports.UserInfo
                    objDataExecute.getDataSet(ds, "RPT_OfficeWiseUserList", objColCriteria, "OfficeWiseUserList", Nothing)
                Case enmIndexWebReports.SingleDayCollection
                    objDataExecute.getDataSet(ds, "RPT_SingleDayCollectionOfficeWise", objColCriteria, "SingleDayCollectionOfficeWise", Nothing)
                Case enmIndexWebReports.OfficeCollection
                    objDataExecute.getDataSet(ds, "RPT_OfficeCollection", objColCriteria, "OfficeCollection", Nothing)
                Case enmIndexWebReports.OfficeDutyCollection
                    objDataExecute.getDataSet(ds, "RPT_OfficewiseDutyCollection", objColCriteria, "OfficewiseDutyCollection", Nothing)
                Case enmIndexWebReports.OfficeDutyCollection
                    objDataExecute.getDataSet(ds, "RPT_OfficewiseDutyCollection", objColCriteria, "OfficewiseDutyCollection", Nothing)
                Case enmIndexWebReports.Mutation
                    objDataExecute.getDataSet(ds, "RPT_Mutation", objColCriteria, "Mutation", Nothing)
                Case enmIndexWebReports.IncomeTax
                    objDataExecute.getDataSet(ds, "RPT_IncomeTax", objColCriteria, "IncomeTax", Nothing)

            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal objColCriteria As Collection = Nothing, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Insert(ByRef ds As DataSet, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function

End Class

