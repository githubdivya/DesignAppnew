
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Enum enmConfig
    Config = 1
End Enum

Public Class cConfig

    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.getDataSet(ds, "Com_M_Config_Select", objColCriteria, "Config", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub FindDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.getDataSet(ds, "Com_M_Config_Find", objColCriteria, "Config", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("Config"), objColCriteria, enmParameterMode.Update)
            objDataExecute.Insert("Com_M_Config_Update", objColCriteria, "Config", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)

            objColCriteria.Add(New SqlParameter("UserId", .Item("UserId")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("OpeningTime", .Item("OpeningTime")))
            objColCriteria.Add(New SqlParameter("ClosingTime", .Item("ClosingTime")))
            objColCriteria.Add(New SqlParameter("ScanPath", .Item("ScanPath")))
            objColCriteria.Add(New SqlParameter("BackupPath", .Item("BackupPath")))
            objColCriteria.Add(New SqlParameter("OfficeName_E", .Item("OfficeName_E")))
            objColCriteria.Add(New SqlParameter("OfficeName_G", .Item("OfficeName_G")))
            objColCriteria.Add(New SqlParameter("OfficeNameShort_E", .Item("OfficeNameShort_E")))
            objColCriteria.Add(New SqlParameter("OfficeNameShort_G", .Item("OfficeNameShort_G")))
            objColCriteria.Add(New SqlParameter("strAddress1", .Item("strAddress1")))
            objColCriteria.Add(New SqlParameter("strAddress2", .Item("strAddress2")))
            objColCriteria.Add(New SqlParameter("strPincode", .Item("strPincode")))

        End With
    End Sub
End Class
