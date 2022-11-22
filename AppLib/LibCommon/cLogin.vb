
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer


Public Enum enmlogin
    District_ddl = 1
    Taluka_ddl = 2
    UserDetails = 3
    Citizen_Profile = 4
    Citizen_Applied_Service = 5
    Citizen_Applied_Service_PrintRequestForm = 6
    Citizen_Applied_Service_PrintCertificate = 7
    Citizen_Applied_Service_GrivenceOnApplied = 8
End Enum
Public Class cLogin
    Inherits cBLBase
    Public Overridable Function Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing) As String
        Try
            Dim result As String = ""
            Dim objColCriteria As New Collection
            CreateParameter(ds.Tables("LoginDetails"), objColCriteria, enmParameterMode.Insert)
            objDataExecute.Insert("com_m_citizenDetail_Insert", objColCriteria, "LoginDetails", Nothing)
            result = objColCriteria(1).Value
            Return result
            'test
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Overridable Sub Update_Profile(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim result As String = ""
            Dim objColCriteria As New Collection
            CreateParameter_UpdateProfile(ds.Tables("LoginDetails"), objColCriteria, enmParameterMode.Update)
            objDataExecute.Insert("com_m_citizenDetail_UpdateProfile", objColCriteria, "LoginDetails", Nothing)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CreateParameter_UpdateProfile(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            objColCriteria.Add(New SqlParameter("Citizen_UserID", .Item("Citizen_UserID")))
            objColCriteria.Add(New SqlParameter("firstname", .Item("firstname")))
            objColCriteria.Add(New SqlParameter("middlename", .Item("middlename")))
            objColCriteria.Add(New SqlParameter("lastname", .Item("lastname")))
            objColCriteria.Add(New SqlParameter("firstnameGuj", .Item("firstnameGuj")))
            objColCriteria.Add(New SqlParameter("middlenameGuj", .Item("middlenameGuj")))
            objColCriteria.Add(New SqlParameter("lastnameGuj", .Item("lastnameGuj")))
            objColCriteria.Add(New SqlParameter("OrganizationName_e", .Item("OrganizationName_e")))
            objColCriteria.Add(New SqlParameter("RationCardNo", .Item("RationCardNo")))
            objColCriteria.Add(New SqlParameter("VoterCardNo", .Item("VoterCardNo")))
            objColCriteria.Add(New SqlParameter("Gender", .Item("Gender")))
            objColCriteria.Add(New SqlParameter("DOB", .Item("DOB")))
            objColCriteria.Add(New SqlParameter("MobileNo", .Item("MobileNo")))
            objColCriteria.Add(New SqlParameter("DistrictID", .Item("DistrictID")))
            objColCriteria.Add(New SqlParameter("talukaid", .Item("TalukaId")))
            objColCriteria.Add(New SqlParameter("Address", .Item("Address")))
            objColCriteria.Add(New SqlParameter("PermanentAddress", .Item("PermanentAddress")))
            objColCriteria.Add(New SqlParameter("CitizenOrganization", .Item("CitizenOrganization")))
            objColCriteria.Add(New SqlParameter("FatherFullName", .Item("FatherFullName")))
            objColCriteria.Add(New SqlParameter("RuralUrban", .Item("RuralUrban")))
            objColCriteria.Add(New SqlParameter("GramPanchayatID", .Item("GramPanchayatID")))
            objColCriteria.Add(New SqlParameter("VillageID", .Item("VillageID")))
            objColCriteria.Add(New SqlParameter("OrganizationName_G", .Item("OrganizationName_G")))
            objColCriteria.Add(New SqlParameter("AadhaarNo", .Item("AadhaarNo")))
            objColCriteria.Add(New SqlParameter("Citizen_Photo", .Item("Citizen_Photo")))

        End With
    End Sub

    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            objColCriteria.Add(New SqlParameter("msg", SqlDbType.VarChar, 38, ParameterDirection.InputOutput, True, 38, 0, "msg", DataRowVersion.Default, DBNull.Value))
            objColCriteria.Add(New SqlParameter("firstname", .Item("firstname")))
            objColCriteria.Add(New SqlParameter("middlename", .Item("middlename")))
            objColCriteria.Add(New SqlParameter("lastname", .Item("lastname")))
            objColCriteria.Add(New SqlParameter("firstnameGuj", .Item("firstnameGuj")))
            objColCriteria.Add(New SqlParameter("middlenameGuj", .Item("middlenameGuj")))
            objColCriteria.Add(New SqlParameter("lastnameGuj", .Item("lastnameGuj")))
            objColCriteria.Add(New SqlParameter("OrganizationName_e", .Item("OrganizationName_e")))
            objColCriteria.Add(New SqlParameter("RationCardNo", .Item("RationCardNo")))
            objColCriteria.Add(New SqlParameter("VoterCardNo", .Item("VoterCardNo")))
            objColCriteria.Add(New SqlParameter("Gender", .Item("Gender")))

            objColCriteria.Add(New SqlParameter("DOB", .Item("DOB")))
            objColCriteria.Add(New SqlParameter("MobileNo", .Item("MobileNo")))

            objColCriteria.Add(New SqlParameter("DistrictID", .Item("DistrictID")))
            objColCriteria.Add(New SqlParameter("talukaid", .Item("TalukaId")))
            objColCriteria.Add(New SqlParameter("Address", .Item("Address")))
            objColCriteria.Add(New SqlParameter("CitizenOrganization", .Item("CitizenOrganization")))
            objColCriteria.Add(New SqlParameter("FatherFullName", .Item("FatherFullName")))
            objColCriteria.Add(New SqlParameter("RuralUrban", .Item("RuralUrban")))
            objColCriteria.Add(New SqlParameter("GramPanchayatID", .Item("GramPanchayatID")))
            objColCriteria.Add(New SqlParameter("VillageID", .Item("VillageID")))
            objColCriteria.Add(New SqlParameter("OrganizationName_G", .Item("OrganizationName_G")))
            objColCriteria.Add(New SqlParameter("AadhaarNo", .Item("AadhaarNo")))
            objColCriteria.Add(New SqlParameter("EmailId", .Item("EmailId")))

            objColCriteria.Add(New SqlParameter("Password", .Item("Password")))
            objColCriteria.Add(New SqlParameter("ConfirmPassword", .Item("ConfirmPassword")))
            objColCriteria.Add(New SqlParameter("Citizen_Photo", .Item("Citizen_Photo")))
            objColCriteria.Add(New SqlParameter("PermanentAddress", .Item("PermanentAddress")))
        End With
    End Sub
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            Select Case CType(index, enmDropDown)
                Case enmlogin.District_ddl
                    objDataExecute.getDataSet(ds, "COM_M_District_Select", objColCriteria, "District_ddl", Nothing)

                Case enmlogin.Taluka_ddl
                    objDataExecute.getDataSet(ds, "COM_M_Taluka_select", objColCriteria, "Taluka_ddl", Nothing)
                Case enmlogin.UserDetails
                    objDataExecute.getDataSet(ds, "Get_CitizenLogin_pwd", objColCriteria, "CitizenLogin", Nothing)

                Case enmlogin.Citizen_Profile
                    objDataExecute.getDataSet(ds, "com_m_citizenDetail_Select", objColCriteria, "CitizenProfile", Nothing)
                Case enmlogin.Citizen_Applied_Service
                    objDataExecute.getDataSet(ds, "Citizen_ApplyService_List", objColCriteria, "Citizen", Nothing)
                Case enmlogin.Citizen_Applied_Service_PrintRequestForm
                    objDataExecute.getDataSet(ds, "Citizen_ApplyService_List_PrintRequestForm", objColCriteria, "Citizen", Nothing)
                Case enmlogin.Citizen_Applied_Service_PrintCertificate
                    objDataExecute.getDataSet(ds, "Citizen_ApplyService_List_PrintCertificate", objColCriteria, "Citizen", Nothing)
                Case enmlogin.Citizen_Applied_Service_GrivenceOnApplied
                    objDataExecute.getDataSet(ds, "Citizen_ApplyService_List_GrivenceOnApplied", objColCriteria, "Citizen", Nothing)


            End Select

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
            objDataExecute.UpdateRec("Change_ClientLogin_Password", objColCriteria, "CitizenLogin", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
