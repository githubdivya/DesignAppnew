Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmIndexLinkDB
    Linkdb = 0
    Link_LRC_DB = 1
    LRC_ADD_Vill = 2
    LinkdbRation = 3
    Link_Ration_DB = 4
    Ration_ADD_Vill = 5
End Enum
Public Class cLinkdbcontroller
    Inherits cBLBase
    Private objLinkdb As cLinkdb
    Public Sub New()
        objLinkdb = New cLinkdb
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexLinkDB.Linkdb
                objLinkdb.GetDataSet(ds, index, DBConnection, enmwsIndex)
            Case enmIndexLinkDB.Link_LRC_DB
                objLinkdb.GetDataSetLRC(ds, index, DBConnection, enmwsIndex)
            Case enmIndexLinkDB.Link_Ration_DB
                objLinkdb.GetDataSetRation(ds, index, DBConnection, enmwsIndex)
            Case enmIndexLinkDB.LRC_ADD_Vill
                objLinkdb.GetDataSetLRCDescr(ds, index, DBConnection, enmwsIndex)
            Case enmIndexLinkDB.Ration_ADD_Vill
                objLinkdb.GetDataSetRatoinDescr(ds, index, DBConnection, enmwsIndex)
            Case enmIndexLinkDB.LinkdbRation
                objLinkdb.GetDataSetRation1(ds, index, DBConnection, enmwsIndex)
        End Select
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Select Case CType(index, enmIndexService)
            Case enmIndexLinkDB.Linkdb
                objLinkdb.Update(ds, index, DBConnection, enmwsIndex)
            Case enmIndexLinkDB.LinkdbRation
                objLinkdb.UpdateRation(ds, index, DBConnection, enmwsIndex)
        End Select
    End Sub

    ' Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
    'Select Case CType(index, enmIndexService)
    '    Case enmIndexLinkDB.Linkdb
    '        Return objLinkdb.Insert(ds, index, DBConnection, enmwsIndex)

    'End Select
    'Return 1
    ' End Function

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
End Class
