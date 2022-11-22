Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.DataAccessLayer

Public Enum enmLicenceDetailDeptWise
    LicenceDetailDeptWise = 1
    SaveRCPSACTDocs_forLicence = 2
End Enum

Public Class Licence

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
            objDataExecute.getDataSet(ds, "SelectLicenceGRDetailMaster", objColCriteria, "LicenceDetailDeptWise", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.Insert("SaveLicenceActDetailMaster", objColCriteria, "LicenceDetailDeptWise", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub add_doc(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.Insert("SaveRCPSACTDocs_forLicence", objColCriteria, "SaveRCPSACTDocs_forLicence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("DEPARTMENTLICENCEID", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "DEPARTMENTLICENCEID", DataRowVersion.Default, strCriteria))
            objDataExecute.Insert("SaveLicenceGRDetailMaster", objColCriteria, "LicenceDetailDeptWise", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function InsertDetail(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing) As Integer
        Dim i As Integer
        Try
            Dim objColCriteria As New Collection
            CreateParameterDetail(ds.Tables("Licence"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("SaveLicenceDetailDeptWise", objColCriteria, "licence", Nothing)

            i = Convert.ToInt32(IIf(objColCriteria(1).value.ToString() = 0, 0, objColCriteria(1).value.ToString()))

        Catch ex As Exception
            Throw ex
        End Try
        Return i
    End Function
    Public Function updateRCPSACT(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing) As Integer
        Dim i As Integer
        Try
            Dim objColCriteria As New Collection
            CreateParameterDetailRCPS(ds.Tables("Licence"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("SaveScRCPS_forLicence", objColCriteria, "licence", Nothing)

            i = Convert.ToInt32(IIf(objColCriteria(1).value.ToString() = 0, 0, objColCriteria(1).value.ToString()))

        Catch ex As Exception
            Throw ex
        End Try
        Return i
    End Function

    Public Overridable Sub InsertAct(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameterAct(ds.Tables("Licence"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("SaveLicenceActDetailMaster", objColCriteria, "licence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub InsertGR(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            CreateParameterGR(ds.Tables("Licence"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("SaveLicenceGRDetailMaster", objColCriteria, "licence", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)
    End Sub
    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer
    End Function
    Private Sub CreateParameterDetailRCPS(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)


            objColCriteria.Add(New SqlParameter("DepartmentLicenceID", .Item("DepartmentLicenceID")))
            objColCriteria.Add(New SqlParameter("RCPSACT", .Item("RCPSACT")))
            objColCriteria.Add(New SqlParameter("Sddays", .Item("Sddays")))
            objColCriteria.Add(New SqlParameter("Sdguj", .Item("Sdguj")))
            objColCriteria.Add(New SqlParameter("Sdeng", .Item("Sdeng")))
            objColCriteria.Add(New SqlParameter("GRAdays", .Item("GRAdays")))
            objColCriteria.Add(New SqlParameter("GRAguj", .Item("GRAguj")))
            objColCriteria.Add(New SqlParameter("GRAeng", .Item("GRAeng")))
            objColCriteria.Add(New SqlParameter("App1days", .Item("App1days")))
            objColCriteria.Add(New SqlParameter("App1guj", .Item("App1guj")))
            objColCriteria.Add(New SqlParameter("App1eng", .Item("App1eng")))
            objColCriteria.Add(New SqlParameter("App2days", .Item("App2days")))
            objColCriteria.Add(New SqlParameter("App2guj", .Item("App2guj")))
            objColCriteria.Add(New SqlParameter("App2eng", .Item("App2eng")))
        End With
    End Sub
    Private Sub CreateParameterDetail(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)

            'objColCriteria.Add(New SqlParameter("DepartmentLicenceID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 4, 0, "DepartmentLicenceID", DataRowVersion.Default, DBNull.Value))
            objColCriteria.Add(New SqlParameter("DepartmentLicenceID", .Item("DepartmentLicenceID")))
            objColCriteria.Add(New SqlParameter("DepartmentID", .Item("DepartmentID")))
            objColCriteria.Add(New SqlParameter("LicenceDetail", .Item("LicenceDetail")))
            objColCriteria.Add(New SqlParameter("NameOfRules", .Item("NameOfRules")))
            objColCriteria.Add(New SqlParameter("IssuingAuthoDesig", .Item("IssuingAuthoDesig")))
            objColCriteria.Add(New SqlParameter("RenewalAuthoDesig", .Item("RenewalAuthoDesig")))
            objColCriteria.Add(New SqlParameter("licenceTimelimit", .Item("licenceTimelimit")))
            objColCriteria.Add(New SqlParameter("RenewallicenceTimeLimit", .Item("RenewallicenceTimeLimit")))
            objColCriteria.Add(New SqlParameter("createdon", .Item("createdon")))
            objColCriteria.Add(New SqlParameter("createdby", .Item("createdby")))
            objColCriteria.Add(New SqlParameter("updatedon", .Item("updatedon")))
            objColCriteria.Add(New SqlParameter("updatedby", .Item("updatedby")))
            objColCriteria.Add(New SqlParameter("OfficeId", .Item("OfficeId")))
        End With
    End Sub
    Private Sub CreateParameterAct(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)

            objColCriteria.Add(New SqlParameter("DepartmentLicenceID", .Item("DepartmentLicenceID")))
            objColCriteria.Add(New SqlParameter("ActID", .Item("ActID")))
            objColCriteria.Add(New SqlParameter("createdon", .Item("createdon")))
            objColCriteria.Add(New SqlParameter("createdby", .Item("createdby")))
            objColCriteria.Add(New SqlParameter("updatedon", .Item("updatedon")))
            objColCriteria.Add(New SqlParameter("updatedby", .Item("updatedby")))
            objColCriteria.Add(New SqlParameter("OfficeId", .Item("OfficeId")))
        End With
    End Sub

    Private Sub CreateParameterGR(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)

            objColCriteria.Add(New SqlParameter("DepartmentLicenceID", .Item("DepartmentLicenceID")))
            objColCriteria.Add(New SqlParameter("GRID", .Item("GRID")))
            objColCriteria.Add(New SqlParameter("createdon", .Item("createdon")))
            objColCriteria.Add(New SqlParameter("createdby", .Item("createdby")))
            objColCriteria.Add(New SqlParameter("updatedon", .Item("updatedon")))
            objColCriteria.Add(New SqlParameter("updatedby", .Item("updatedby")))
            objColCriteria.Add(New SqlParameter("OfficeId", .Item("OfficeId")))
        End With
    End Sub


End Class


