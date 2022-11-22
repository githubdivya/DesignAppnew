Imports System.Data.SqlClient
Imports System.data
Public Enum enmParameterType
    Input = 1
    OutPut = 2
End Enum
Public Class cParameter
    Private strDBTableName As String = "Parameter"
    Sub New(ByRef ds As DataSet)
        If ds.Tables.Contains(strDBTableName) Then
            ds.Tables.Remove(strDBTableName)
        End If
        Dim objdsTable As New System.Data.DataTable
        objdsTable.TableName = "Parameter"
        objdsTable.Columns.Add("PName")
        objdsTable.Columns.Add("PValue")
        objdsTable.Columns.Add("PType")
        objdsTable.Columns.Add("DBType")
        ds.Tables.Add(objdsTable)
    End Sub
    Public Function CreateParameter(ByRef ds As DataSet, ByRef strPname As String, ByVal strValue As String, Optional ByVal PType As enmParameterType = enmParameterType.Input, Optional ByVal DBType As SqlDbType = SqlDbType.Int) As Data.DataSet
        Dim objRow As System.Data.DataRow
        objRow = ds.Tables("Parameter").NewRow
        objRow.Item(0) = strPname
        objRow.Item(1) = strValue
        objRow.Item(2) = CInt(PType)
        objRow.Item(3) = DBType
        ds.Tables("Parameter").Rows.Add(objRow)
        Return ds
    End Function

End Class
