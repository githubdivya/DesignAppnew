Imports System.Data.SqlClient
Imports NICFrameWork.DataAccessLayer
Public Class cBLBaseReadOnly
    Private _Connection As SqlConnection
    Public objDataExecute As cDataExecuteReadOnly
    Sub New()
        objDataExecute = New cDataExecuteReadOnly
    End Sub
End Class
