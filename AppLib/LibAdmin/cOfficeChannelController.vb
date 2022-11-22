Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexOfficeChannel
    OfficeChannel = 0
    OfficeChannelDetails = 1
    OfficeChannelDistrict = 2
    OfficeChannelAppletAuthority = 3
End Enum
Public Class cOfficeChannelController
    Inherits cBLBase
    Private objOfficeChannel As cOfficeChannel
    Private objOfficeChannelDetails As cOfficeChannelDetails
    Public Sub New()
        objOfficeChannel = New cOfficeChannel
        objOfficeChannelDetails = New cOfficeChannelDetails
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                objOfficeChannel.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelDetails
                objOfficeChannelDetails.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelAppletAuthority
                objOfficeChannel.GetDataSet(ds, index, DBConnection, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                objOfficeChannel.Update(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelAppletAuthority
                objOfficeChannel.Update(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelDetails
                objOfficeChannelDetails.Update(ds, index, DBConnection, enmwsIndex)
            Case (enmIndexOfficeChannel.OfficeChannelDistrict)
                objOfficeChannel.Update(ds, index, DBConnection, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannelDetails
                objOfficeChannelDetails.Delete(strCriteria, index, DBConnection, enmwsIndex)
        End Select
    End Sub

    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                Return objOfficeChannel.Insert(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelDetails
                Return objOfficeChannelDetails.Insert(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelAppletAuthority
                objOfficeChannel.Update(ds, index, DBConnection, enmwsIndex)
        End Select
        Return 1
    End Function

    Public Overridable Function InsertBulk(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                Return objOfficeChannel.InsertBulk(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelAppletAuthority
                Return objOfficeChannel.InsertBulk(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelDistrict
                Return objOfficeChannel.InsertBulk(ds, index, DBConnection, enmwsIndex)
        End Select
        Return 1
    End Function

    Public Overridable Sub DeleteBulk(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing, Optional ByVal strInt As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannelDetails
                objOfficeChannelDetails.Delete(strCriteria, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannel
                objOfficeChannel.DeleteBulk(strCriteria, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeChannel.OfficeChannelDistrict
                objOfficeChannel.DeleteBulk(strCriteria, index, DBConnection, enmwsIndex, strInt)
            Case enmIndexOfficeChannel.OfficeChannelAppletAuthority
                objOfficeChannel.DeleteBulk(strCriteria, index, DBConnection, enmwsIndex)
        End Select
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
End Class
