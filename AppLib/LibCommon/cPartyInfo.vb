
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Class cPartyInfo
    Inherits cBLBase
    Private _ServerConnectionString = My.Settings.ServerConnectionString
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                If CInt(.Rows(i).Item("PType")) = 1 Then
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Else
                    If .Rows(i).Item("Pvalue").ToString.Trim = "-1" Then
                        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                    Else
                        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, .Rows(i).Item("PName").ToString, DataRowVersion.Default, New System.Guid(.Rows(i).Item("Pvalue").ToString)))
                    End If
                End If
            Next
        End With
        objDataExecute.getDataSet(ds, "M_PhotoThumb_SelectECParty", objColCriteria, "partyInfo", Nothing)
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("PhotoThumb"), objColCriteria, enmParameterMode.Update)
        objDataExecute.Insert("M_PhotoThumb_Update", objColCriteria, "PhotoThumb", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("PhotoThumbID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input, True, 0, 0, "PhotoThumbID", DataRowVersion.Default, New System.Guid(strCriteria)))
        objDataExecute.Insert("M_PhotoThumb_Delete", objColCriteria, "PhotoThumb", Nothing)

    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("PhotoThumb"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("M_PhotoThumb_Insert", objColCriteria, "PhotoThumb", Nothing)
        With ds.Tables("PhotoThumb").Rows(0)
            .Item("PhotoThumbID") = CType(objColCriteria(1), SqlParameter).Value
        End With
    End Sub

    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        'With dt.Rows(0)
        '    Select Case ParameterMode
        '        Case enmParameterMode.Insert
        '            objColCriteria.Add(New SqlParameter("PhotoThumbID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, "PhotoThumbID", DataRowVersion.Default, DBNull.Value))
        '        Case enmParameterMode.Update
        '            objColCriteria.Add(New SqlParameter("PhotoThumbID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, False, 0, 0, "PhotoThumbID", DataRowVersion.Default, .Item("PhotoThumbID")))
        '    End Select
        '    objColCriteria.Add(New SqlParameter("UserID", .Item("UserID")))
        '    objColCriteria.Add(New SqlParameter("RoleID", .Item("RoleID")))
        '    objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
        '    objColCriteria.Add(New SqlParameter("SrNo", .Item("SrNo")))
        '    objColCriteria.Add(New SqlParameter("DocumentID", .Item("DocumentID")))
        '    objColCriteria.Add(New SqlParameter("DocumentRefID", .Item("DocumentRefID")))
        '    objColCriteria.Add(New SqlParameter("Photo", .Item("Photo")))
        '    objColCriteria.Add(New SqlParameter("Thumb", .Item("Thumb")))
        'End With
    End Sub
End Class
