Imports System.Data.SqlClient
Imports NICFrameWork.DataAccessLayer
Public Class cBLBase
    Private _Connection As SqlConnection
    Public objDataExecute As cDataExecute
    Public objDataExecuteM As cDataExecuteM
    Sub New()
        objDataExecute = New cDataExecute
        objDataExecuteM = New cDataExecuteM
    End Sub
End Class
