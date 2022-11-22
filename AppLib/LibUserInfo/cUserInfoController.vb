Imports NICFrameWork.DataAccessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexUserInfo
    User = 0
    Role = 1
    RoleFunctionRights = 2
    UserRoleMap = 3
    FunctionMap = 4
    FunctionMasrter = 5
    ShortKeys = 6
    Attandence = 7
    RoleFunctionMap = 8
    UserPhotoThumb = 9
    office = 10
    Config = 11

End Enum
Public Interface IFeesReceiptController

End Interface
Public Class cUserInfoController
    Inherits cBLBase
    Private objUser As cUser
    Private objRole As cRole
    Private objRoleFunctionRights As cRoleFunctionRights
    Private objUserRoleMap As cUserRoleMap
    Private objFunctionMap As cFunctionMap
    Private objShortKeys As cShortKeys
    Private objAttandence As cAttandence
    Private objRoleFunctionMap As cRoleFunction
    Private objUserPhotoThumb As cUserPhotoThumb
    Private objOffice As cOffice
    Private objConfig As cConfig


    Private Sub objclass(ByVal index As Object)
        Select Case CType(index, enmIndexUserInfo)
            Case enmIndexUserInfo.office
                objOffice = New cOffice
            Case enmIndexUserInfo.User
                objUser = New cUser
            Case enmIndexUserInfo.Role
                objRole = New cRole
            Case enmIndexUserInfo.RoleFunctionRights
                objRoleFunctionRights = New cRoleFunctionRights
            Case enmIndexUserInfo.UserRoleMap
                objUserRoleMap = New cUserRoleMap
            Case enmIndexUserInfo.FunctionMap
                objFunctionMap = New cFunctionMap
            Case enmIndexUserInfo.ShortKeys
                objShortKeys = New cShortKeys
            Case enmIndexUserInfo.Attandence
                objAttandence = New cAttandence
            Case enmIndexUserInfo.RoleFunctionMap
                objRoleFunctionMap = New cRoleFunction
            Case enmIndexUserInfo.UserPhotoThumb
                objUserPhotoThumb = New cUserPhotoThumb
            Case enmIndexUserInfo.Config
                objConfig = New cConfig
        End Select
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexUserInfo)
            Case enmIndexUserInfo.User
                objUser.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.office
                objOffice.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Role
                objRole.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.RoleFunctionRights

            Case enmIndexUserInfo.UserRoleMap
                objUserRoleMap.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.FunctionMap
                objFunctionMap.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.ShortKeys
                objShortKeys.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Attandence
                objAttandence.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.RoleFunctionMap
                objRoleFunctionMap.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.UserPhotoThumb
                objUserPhotoThumb.GetDataSet(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Config
                objConfig.GetDataSet(ds, index, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
        objclass(index)
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexUserInfo)
            Case enmIndexUserInfo.User
                objUser.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Role
                objRole.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.RoleFunctionRights

            Case enmIndexUserInfo.FunctionMap
                objFunctionMap.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.ShortKeys
                objShortKeys.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.RoleFunctionMap
                objRoleFunctionMap.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.UserPhotoThumb
                objUserPhotoThumb.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.office
                objOffice.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.UserRoleMap
                objUserRoleMap.Update(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Config
                objConfig.Update(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        objclass(index)
        Select Case CType(index, enmIndexUserInfo)
            Case enmIndexUserInfo.User
                objUser.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Role
                objRole.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.RoleFunctionRights

            Case enmIndexUserInfo.FunctionMap
                objFunctionMap.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.ShortKeys
                objShortKeys.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Attandence
                objAttandence.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.RoleFunctionMap
                objRoleFunctionMap.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.UserPhotoThumb
                objUserPhotoThumb.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.office
                objOffice.Insert(ds, index, enmwsIndex)
            Case enmIndexUserInfo.Config
                objConfig.Insert(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
        objclass(index)
    End Function

End Class
