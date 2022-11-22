Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexOfficeType
    OfficeType = 0
    OfficeTypeChannelDetails = 1
    OfficeMast = 2
End Enum
Public Class cOfficeTypeController
    Inherits cBLBase
    Private objOfficeType As cOfficeType
    Private objOfficeMast As cOfficeMast
    Public Sub New()
        objOfficeType = New cOfficeType
        objOfficeMast = New cOfficeMast

    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeType.OfficeType
                objOfficeType.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeType.OfficeTypeChannelDetails
                objOfficeType.GetDataSet1(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeType.OfficeMast
                objOfficeMast.GetDataSet(ds, index, DBConnection, enmwsIndex)

        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeType.OfficeType
                objOfficeType.Update(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeType.OfficeMast
                objOfficeMast.Update(ds, index, DBConnection, enmwsIndex)
        End Select

    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub

    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeType.OfficeType
                Return objOfficeType.Insert(ds, index, DBConnection, enmwsIndex)
            Case enmIndexOfficeType.OfficeMast
                Return objOfficeMast.Insert(ds, index, DBConnection, enmwsIndex)
        End Select

        Return 1
    End Function

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function

End Class
