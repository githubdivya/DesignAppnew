Imports NICFrameWork.DataAccessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexDevice
    PhotoThumb = 1
    Scanning = 2
    Archival = 4
    partyInfo = 5
    UserMastPhotoThumb = 6
    ScanningDoc = 7
End Enum
Public Class cDeviceController
    Inherits cBLBase
    Private objPhotoThumb As cPhotoThumb
    Private objScanning As cScanning
    Private objArchival As cArchival
    Private objpartyInfo As cPartyInfo
    Private objUserMastPhotoThumb As cUserMastPhotoThumb
    Private objScanningDoc As cScanningDoc


    Private Sub objclass(ByVal index As Object)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexDevice.PhotoThumb
                objPhotoThumb = New cPhotoThumb
            Case enmIndexDevice.Scanning
                objScanning = New cScanning
            Case enmIndexDevice.Archival
                objArchival = New cArchival
            Case enmIndexDevice.partyInfo
                objpartyInfo = New cPartyInfo
            Case enmIndexDevice.UserMastPhotoThumb
                objUserMastPhotoThumb = New cUserMastPhotoThumb
            Case enmIndexDevice.ScanningDoc
                objScanningDoc = New cScanningDoc
        End Select
    End Sub

    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexDevice.PhotoThumb
                objPhotoThumb.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexDevice.Scanning
                objScanning.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexDevice.Archival
                objArchival.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexDevice.partyInfo
                objpartyInfo.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexDevice.UserMastPhotoThumb
                objUserMastPhotoThumb.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexDevice.ScanningDoc
                objScanningDoc.GetDataSet(ds, index, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
        objclass(index)
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexDevice.PhotoThumb
                objPhotoThumb.Update(ds, index, enmwsIndex)
            Case enmIndexDevice.Scanning
                objScanning.Update(ds, index, enmwsIndex)
            Case enmIndexDevice.Archival
                objArchival.Update(ds, index, enmwsIndex)
            Case enmIndexDevice.UserMastPhotoThumb
                objUserMastPhotoThumb.Update(ds, index, enmwsIndex)
            Case enmIndexDevice.ScanningDoc
                objScanningDoc.Update(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Delete(ByRef ds As DataSet, ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexDevice.PhotoThumb
                objPhotoThumb.Delete(strCriteria, index, enmwsIndex)
            Case enmIndexDevice.Scanning
                objScanning.Delete(strCriteria, index, enmwsIndex)
            Case enmIndexDevice.Archival
                objArchival.Delete(strCriteria, index, enmwsIndex)
            Case enmIndexDevice.UserMastPhotoThumb
                objUserMastPhotoThumb.Delete(strCriteria, index, enmwsIndex)
            Case enmIndexDevice.ScanningDoc
                objScanningDoc.Delete(strCriteria, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexDevice.PhotoThumb
                objPhotoThumb.Insert(ds, index, enmwsIndex)
            Case enmIndexDevice.Scanning
                objScanning.Insert(ds, index, enmwsIndex)
            Case enmIndexDevice.Archival
                objArchival.Insert(ds, index, enmwsIndex)
            Case enmIndexDevice.UserMastPhotoThumb
                objUserMastPhotoThumb.Insert(ds, index, enmwsIndex)
            Case enmIndexDevice.ScanningDoc
                objScanningDoc.Insert(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
        objclass(index)
    End Function
End Class

