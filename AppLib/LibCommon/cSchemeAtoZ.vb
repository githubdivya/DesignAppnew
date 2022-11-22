Imports NICFrameWork.DataAccessLayer
Imports System.Data.Common
Imports System.Data.SqlClient


Public Enum enmtblSchemeMast
    tblSchemeMast = 1
    SchemeDeptWise = 2
    getmoredetailfile = 3
    GistDeptWise = 4
    SchemeDeptWisedetails = 5
    VisiterCounter = 6
End Enum

Public Class cSchemeAtoZ
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            If ds.Tables.Contains("Parameter") Then
                With ds.Tables("Parameter")
                    For i = 0 To .Rows.Count - 1
                        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                    Next
                End With
            End If


            Select Case CType(index, enmtblSchemeMast)
                Case enmtblSchemeMast.tblSchemeMast
                    objDataExecuteM.getDataSet(ds, "GetSchemeAtoZ", objColCriteria, "tblSchemeMast", enumDBGroup.SchemePortal)
                Case enmtblSchemeMast.SchemeDeptWise
                    objDataExecute.getDataSet(ds, "GetSchemeAtoZ_DeptWise", objColCriteria, "Scheme", enumDBGroup.SchemePortal)
                Case enmtblSchemeMast.GistDeptWise
                    objDataExecute.getDataSet(ds, "GetGist_DeptWise", objColCriteria, "Scheme", enumDBGroup.SchemePortal)
                Case enmtblSchemeMast.getmoredetailfile
                    objDataExecuteM.getDataSet(ds, "Getfile_From_Grorderid", objColCriteria, "File", enumDBGroup.SchemePortal)
                Case enmtblSchemeMast.SchemeDeptWisedetails
                    objDataExecute.getDataSet(ds, "atoz_SchemeMISDetails", objColCriteria, "SchemeDeptWisedetails", enumDBGroup.SchemePortal)
                Case enmtblSchemeMast.VisiterCounter
                    objDataExecute.getDataSet(ds, "Updatecounter", objColCriteria, "VisiterCounter", enumDBGroup.SchemePortal)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub GetDeptSite(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            If ds.Tables.Contains("Parameter") Then
                With ds.Tables("Parameter")
                    For i = 0 To .Rows.Count - 1
                        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                    Next
                End With
            End If
            'objDataExecuteM.getDataSet(ds, "DG_SearchByCategory_Select", objColCriteria, "Search", enumDBGroup.SchemePortal)
            objDataExecuteM.getDataSet(ds, "GetDeptSite", objColCriteria, "tblSchemeMast", enumDBGroup.SchemePortal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



End Class
