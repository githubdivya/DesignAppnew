Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.adminDataAccessLayer
Public Class cOfficeChannel
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
         Select CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                objDataExecute.getDataSet(ds, "COM_M_OfficeChannel_Select", objColCriteria, "COM_M_OfficeChannel", Nothing)
            Case enmIndexOfficeChannel.OfficeChannelAppletAuthority
                objDataExecute.getDataSet(ds, "COM_M_OfficeChannelAppletAuthority_Select", objColCriteria, "COM_M_OfficeChannel", Nothing)
        End Select

    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("Pvalue").ToString.Trim = "-999" Then
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                Else
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                End If
            Next
        End With
        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                objDataExecute.UpdateRec("COM_M_OfficeChannel_Update", objColCriteria, "COM_M_OfficeChannel", Nothing)
            Case enmIndexOfficeChannel.OfficeChannelAppletAuthority
                objDataExecute.UpdateRec("COM_M_OfficeChannelAppletAuthoriy_Update", objColCriteria, "COM_M_OfficeChannel", Nothing)
            Case enmIndexOfficeChannel.OfficeChannelDistrict
                objDataExecute.UpdateRec("COM_M_OfficeChannel_Update_bulkD", objColCriteria, "COM_M_OfficeChannel", Nothing)
        End Select

    End Sub
    Public Overridable Sub DeleteBulk(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing, Optional ByVal strInt As Int16 = Nothing)
        Dim objColCriteria As New Collection

        Select Case CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                objColCriteria.Add(New SqlParameter("InuptServiceID", strCriteria))
                objDataExecute.DeleteRec("COM_M_OfficeChannel_delete_bulk", objColCriteria, Nothing)
            Case enmIndexOfficeChannel.OfficeChannelDistrict
                objColCriteria.Add(New SqlParameter("InuptServiceID", strCriteria))
                objColCriteria.Add(New SqlParameter("InputServiceOfficeID", strInt))
                objDataExecute.DeleteRec("COM_M_OfficeChannel_delete_bulkD", objColCriteria, Nothing)
        End Select

    End Sub
    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Dim i As Integer
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("OfficeChannelID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "OfficeChannelID", DataRowVersion.Default, DBNull.Value))
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With
        objDataExecute.Insert("COM_M_OfficeChannel_Insert", objColCriteria, "COM_M_OfficeChannel", Nothing)
        Return CType(objColCriteria.Item(1), SqlParameter).Value
    End Function


    Public Overridable Function InsertBulk(ByVal ds As DataSet, ByVal index As Object, Optional ByRef DBConnection As SqlConnection = Nothing, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Dim i As Integer
        Dim objColCriteria As New Collection
        '  objColCriteria.Add(New SqlParameter("InuptServiceID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 4, 0, "InuptServiceID", DataRowVersion.Default, DBNull.Value))
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            Next
        End With

         Select CType(index, enmIndexService)
            Case enmIndexOfficeChannel.OfficeChannel
                objDataExecute.Insert("COM_M_OfficeChannel_Insert_Bulk", objColCriteria, "COM_M_OfficeChannel", Nothing)
            Case enmIndexOfficeChannel.OfficeChannelDistrict
                objDataExecute.Insert("COM_M_OfficeChannel_Insert_BulkD", objColCriteria, "COM_M_OfficeChannel", Nothing)
        End Select

        Return CType(objColCriteria.Item(1), SqlParameter).Value
    End Function
    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
End Class
