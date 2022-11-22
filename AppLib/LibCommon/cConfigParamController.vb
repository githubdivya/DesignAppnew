Imports NICFrameWork.DataAccessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexConfigParam
    ConfigParam = 1
End Enum
Public Class cConfigParamController
    Inherits cBLBase
    Private objConfigParam As cConfigParam
    Public Sub New()
        objConfigParam = New cConfigParam
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexConfigParam.ConfigParam
                objConfigParam.GetDataSet(ds, index, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexConfigParam.ConfigParam
                objConfigParam.Update(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Delete(ByRef ds As DataSet, ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexConfigParam.ConfigParam
                objConfigParam.Delete(strCriteria, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexDevice)
            Case enmIndexConfigParam.ConfigParam
                objConfigParam.Insert(ds, index, enmwsIndex)
        End Select
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
End Class

