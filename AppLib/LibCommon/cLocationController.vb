Imports NICFrameWork.DataAccessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexLocation
    District = 1
    Taluka = 2
    Village = 3
    State = 4
    Gram_panchayat = 5
End Enum
Public Class cLocationController
    Inherits cBLBase
    Private objDistrict As cLocationDistrict
    Private objTaluka As cLocationTaluka
    Private objVillage As cLocationVillage
    Private objState As cLocationState
    Private objGarm_panch As cGram_panchayat

    Private Sub objclass(ByVal index As Object)
        Select Case CType(index, enmIndexLocation)
            Case enmIndexLocation.District
                objDistrict = New cLocationDistrict
            Case enmIndexLocation.Taluka
                objTaluka = New cLocationTaluka
            Case enmIndexLocation.Village
                objVillage = New cLocationVillage
            Case enmIndexLocation.Gram_panchayat
                objGarm_panch = New cGram_panchayat
            Case enmIndexLocation.State
                objState = New cLocationState
        End Select
    End Sub

    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexLocation)
            Case enmIndexLocation.District
                objDistrict.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexLocation.Taluka
                objTaluka.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexLocation.Village
                objVillage.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexLocation.Gram_panchayat
                objGarm_panch.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexLocation.State
                objState.GetDataSet(ds, index, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
        objclass(index)
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexLocation)
            Case enmIndexLocation.District
                objDistrict.Update(ds, index, enmwsIndex)
            Case enmIndexLocation.Taluka
                objTaluka.Update(ds, index, enmwsIndex)
            Case enmIndexLocation.Village
                objVillage.Update(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexLocation)
            Case enmIndexLocation.District
                objDistrict.Delete(strCriteria, index, enmwsIndex)
            Case enmIndexLocation.Taluka
                objTaluka.Delete(strCriteria, index, enmwsIndex)
            Case enmIndexLocation.Village
                objVillage.Delete(strCriteria, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexLocation)
            Case enmIndexLocation.District
                objDistrict.Insert(ds, index, enmwsIndex)
            Case enmIndexLocation.Taluka
                objTaluka.Insert(ds, index, enmwsIndex)
            Case enmIndexLocation.Village
                objVillage.Insert(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
        objclass(index)
    End Function
End Class

