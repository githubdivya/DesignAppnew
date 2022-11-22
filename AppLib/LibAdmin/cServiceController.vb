Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexService
    Service = 0
    Document = 1
    DetailService = 2
    ServiceDocument = 3

    Errors = 4
    DetErrors = 5
    ErrCode = 6
    SeviceGroup = 7
End Enum
Public Class cServiceController
    Inherits cBLBase
    Private objService As cService
    Private objDocument As cDocument
    Private objDetailService As cDetailService
    Private objServiceDocument As cServiceDocument
    Private objErrors As cErrors

    Public Sub New()
        objService = New cService
        objDocument = New cDocument
        objDetailService = New cDetailService
        objServiceDocument = New cServiceDocument
        objErrors = New cErrors
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexService.Service
                objService.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.SeviceGroup
                objService.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.Document
                objDocument.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.DetailService
                objDetailService.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.ServiceDocument
                objServiceDocument.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.Errors
                objErrors.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.DetErrors
                objErrors.GetDataSet_Det(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.ErrCode
                objErrors.GetDataSet_code(ds, index, DBConnection, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexService.Service
                objService.Update(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.Document
                objDocument.Update(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.DetailService
                objDetailService.Update(ds, index, DBConnection, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub

    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Select Case CType(index, enmIndexService)
            Case enmIndexService.Service
                Return objService.Insert(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.Document
                objDocument.Insert(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.DetailService
                objDetailService.Insert(ds, index, DBConnection, enmwsIndex)
            Case enmIndexService.ServiceDocument
                objServiceDocument.Insert(ds, index, DBConnection, enmwsIndex)
        End Select
        Return 1
    End Function

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
End Class
