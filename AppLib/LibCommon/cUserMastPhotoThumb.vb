﻿Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Class cUserMastPhotoThumb
    Inherits cBLBase
    Private _ServerConnectionString = My.Settings.ServerConnectionString
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        With ds.Tables("Parameter")
            For i = 0 To .Rows.Count - 1
                If IsDBNull(.Rows(i).Item("Pvalue")) Then
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                Else
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                End If
            Next
        End With
        objDataExecute.getDataSet(ds, "COM_UserMastPhotoThumb_Select", objColCriteria, "UserMastPhotoThumb", Nothing)
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("UserMastPhotoThumb"), objColCriteria, enmParameterMode.Update)
        objDataExecute.UpdateRec("COM_UserMastPhotoThumb_Update", objColCriteria, "UserMastPhotoThumb", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("PhotoThumbID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input, True, 0, 0, "PhotoThumbID", DataRowVersion.Default, New System.Guid(strCriteria)))
        objDataExecute.Insert("COM_UserMastPhotoThumb_Delete", objColCriteria, "UserMastPhotoThumb", Nothing)

    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("UserMastPhotoThumb"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("COM_UserMastPhotoThumb_Insert", objColCriteria, "UserMastPhotoThumb", Nothing)
        With ds.Tables("UserMastPhotoThumb").Rows(0)
            .Item("PhotoThumbID") = CType(objColCriteria(1), SqlParameter).Value
        End With
    End Sub

    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("PhotoThumbID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, "PhotoThumbID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("PhotoThumbID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, False, 0, 0, "PhotoThumbID", DataRowVersion.Default, .Item("PhotoThumbID")))
            End Select
            objColCriteria.Add(New SqlParameter("UserID", .Item("UserID")))
            objColCriteria.Add(New SqlParameter("RoleID", .Item("RoleID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("ThumbRowData", .Item("ThumbRowData")))
            objColCriteria.Add(New SqlParameter("ThumbTextData", .Item("ThumbTextData")))
            objColCriteria.Add(New SqlParameter("PhotoThumbType", .Item("PhotoThumbType")))
            If Not IsDBNull(dt.Rows(0).Item("Thumb")) Then
                objColCriteria.Add(New SqlParameter("Thumb", .Item("Thumb")))
                ' objColCriteria.Add(New SqlParameter("ANSI378", .Item("ANSI378")))
            End If
            '    objColCriteria.Add(New SqlParameter("Photo", SqlDbType.Image, 8000, ParameterDirection.Input, True, 0, 0, "Photo", DataRowVersion.Default, .Item("Photo")))
            ' objColCriteria.Add(New SqlParameter("Thumb", SqlDbType.Image, 8000, ParameterDirection.Input, True, 0, 0, "Thumb", DataRowVersion.Default, .Item("Thumb")))
        End With
    End Sub
End Class


