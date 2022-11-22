Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports System.Data.SqlClient
Public Interface IFeesReceipt

End Interface
Public Class cFeesReceiptUI
    Private objService As Object
    Public Sub New(ByVal ApplicationMode As enmApplicationMode)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService = New cFeesReceiptController
            Case enmApplicationMode.Online
                objService = New AppWS.ServiceSoapClient
                objService.EnableDecompression = True
        End Select
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, ByVal ApplicationMode As enmApplicationMode, Optional ByVal index As Object = 0)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.GetDataSet(ds, index, )
            Case enmApplicationMode.Online
                objService.GetDataSet(ds, index, enmWebService.FeesReceipt)
        End Select

    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, ByVal ApplicationMode As enmApplicationMode, Optional ByVal index As Object = 0)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.update(ds, index, )
            Case enmApplicationMode.Online
                objService.update(ds, index, enmWebService.FeesReceipt)
        End Select
    End Sub

    Public Overridable Sub Delete(ByRef ds As DataSet, ByVal strCriteria As String, ByVal ApplicationMode As enmApplicationMode, Optional ByVal index As Object = 0)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.Delete(ds, strCriteria, index, )
            Case enmApplicationMode.Online
                objService.Delete(ds, strCriteria, index, enmWebService.FeesReceipt)
        End Select
    End Sub
    Public Overridable Sub Insert(ByRef ds As DataSet, ByVal index As Integer, ByVal ApplicationMode As enmApplicationMode, Optional ByRef DBConnection As SqlConnection = Nothing)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.insert(ds, index, )
            Case enmApplicationMode.Online
                objService.insert(ds, index, enmWebService.FeesReceipt)
        End Select
    End Sub
    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
End Class
