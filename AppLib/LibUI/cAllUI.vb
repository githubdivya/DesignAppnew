Imports NIC.LibApp
Imports NICFrameWork.LibCommon
Imports System.Data.SqlClient
Public Class cAllUI
    Private objService As Object
    Public Sub New(ByVal ApplicationMode As enmApplicationMode)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService = New cLocationController
            Case enmApplicationMode.Online
                objService = New AppWS.WebServiceSoapClient
                ' objService.EnableDecompression = True
        End Select
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, ByVal ApplicationMode As enmApplicationMode, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.GetDataSet(ds, index, )
            Case enmApplicationMode.Online
                objService.GetDataSet(ds, index, enmwsIndex)
        End Select

    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, ByVal ApplicationMode As enmApplicationMode, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.update(ds, index, )
            Case enmApplicationMode.Online
                objService.update(ds, index, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub Delete(ByRef ds As DataSet, ByVal strCriteria As String, ByVal ApplicationMode As enmApplicationMode, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.Delete(ds, strCriteria, index, )
            Case enmApplicationMode.Online
                objService.Delete(ds, strCriteria, index, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub FindDataSet(ByRef ds As DataSet, ByVal ApplicationMode As enmApplicationMode, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.FindDataSet(ds, index, )
            Case enmApplicationMode.Online
                objService.FindDataSet(ds, index, enmwsIndex)
        End Select

    End Sub
    Public Overridable Sub Insert(ByRef ds As DataSet, ByVal index As Integer, ByVal ApplicationMode As enmApplicationMode, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.insert(ds, index, )
            Case enmApplicationMode.Online
                objService.insert(ds, index, enmwsIndex)
        End Select
    End Sub
    Public Function InsertReturn(ByRef ds As DataSet, ByVal index As Integer, ByVal ApplicationMode As enmApplicationMode, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Dim FinalResult As String = ""
        Select Case ApplicationMode
            Case enmApplicationMode.Offline
                objService.InsertReturn(ds, index, )
            Case enmApplicationMode.Online
                FinalResult = objService.InsertReturn(ds, index, enmwsIndex)
        End Select
        Return FinalResult
    End Function
    Public Function SendSMS(ByVal key As String, ByVal mobileno As String, ByVal strsms As String) As String
        Dim FinalResult As String
        FinalResult = objService.SendSMS(key, mobileno, strsms)
        Return FinalResult
    End Function
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub
    Public Overridable Function GetLastRec(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing) As Integer

    End Function
End Class

