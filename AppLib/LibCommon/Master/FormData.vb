Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports System.Web.UI.WebControls
Imports System
Imports System.Web
Imports NICFrameWork.LibCommon

Public Class FormData
    Inherits SchemeGeneral
#Region "++++++++++++++++++Memeber Variable+++++++++++++++++"
    Private mSchemeCode As Integer = 0
    Private mFormId As Int64 = 0
    Private mDeptid As Int16 = 0
    Private mfrmdesc As String = String.Empty
    Private mavaiId As Integer = 0
    Private mform As Byte() = Nothing
    Private mFormName As String = String.Empty
    Private mformeng As Byte() = Nothing
    Private mServiceDetails As Byte() = Nothing
    Private mFormtype As Char = ""
    Private mScUrl As String = String.Empty
    Private mAppUrl As String = String.Empty
    Private mLicenceId As Integer

#End Region
#Region "++++++++++++++++++Property++++++++++++++++++++++++++"
    Public Property SchemeCode() As Integer
        Get
            Return mSchemeCode
        End Get
        Set(ByVal value As Integer)
            mSchemeCode = value
        End Set
    End Property
    Public Property LicenceId() As Integer
        Get
            Return mLicenceId
        End Get
        Set(ByVal value As Integer)
            mLicenceId = value
        End Set
    End Property
    Public Property FormId() As Int64
        Get
            Return mFormId
        End Get
        Set(ByVal value As Int64)
            mFormId = value
        End Set
    End Property
    Public Property DeptID() As Int16
        Get
            Return mDeptid
        End Get
        Set(ByVal value As Int16)
            mDeptid = value
        End Set
    End Property
    Public Property FormDesc() As String
        Get
            Return mfrmdesc
        End Get
        Set(ByVal value As String)
            mfrmdesc = value
        End Set
    End Property
    Public Property AvailableId() As Integer
        Get
            Return mavaiId
        End Get
        Set(ByVal value As Integer)
            mavaiId = value
        End Set
    End Property
    Public Property Frm() As Byte()
        Get
            Return mform
        End Get
        Set(ByVal value As Byte())
            mform = value
        End Set
    End Property
    Public Property FrmEng() As Byte()
        Get
            Return mformeng
        End Get
        Set(ByVal value As Byte())
            mformeng = value
        End Set
    End Property

    'Public Property ServiceDetails() As String
    '    Get
    '        Return mServiceDetails
    '    End Get
    '    Set(ByVal value As String)
    '        mServiceDetails = value
    '    End Set
    'End Property
    Public Property ServiceDetails() As Byte()
        Get
            Return mServiceDetails
        End Get
        Set(ByVal value As Byte())
            mServiceDetails = value
        End Set
    End Property
    Public Property ScUrl() As String
        Get
            Return mScUrl
        End Get
        Set(ByVal value As String)
            mScUrl = value
        End Set
    End Property
    Public Property AppUrl() As String
        Get
            Return mAppUrl
        End Get
        Set(ByVal value As String)
            mAppUrl = value
        End Set
    End Property
    Public Property FormName() As String
        Get
            Return mFormName
        End Get
        Set(ByVal value As String)
            mFormName = value
        End Set
    End Property
    Public Property FormType() As Char
        Get
            Return mFormtype
        End Get
        Set(ByVal value As Char)
            mFormtype = value
        End Set
    End Property
#End Region
#Region "++++++++++++++++++Procedures & Functions+++++++++++++"
    Public Sub FillAvailableFrom(ByRef DDControl As DropDownList)
        FillDropDown(DDControl, FillAvailableFrom(), "AvaiFromE", "AvailableId", "--- Select ---")
    End Sub
    Public Function FillAvailableFrom() As Data.DataTable

        Return FillRecords("GetAvaiFrom", CmdType.StoredProcedure, Nothing)

    End Function
    Public Sub Add()
        Dim param As SqlParameter() = New SqlParameter(11) {}
        SetParameter(param)
        ExecuteCmd("SaveFrmMast", CmdType.StoredProcedure, param)
    End Sub
    Public Sub Add1()
        Dim param As SqlParameter() = New SqlParameter(9) {}
        SetParameter1(param)
        ExecuteCmd("saveFrmLicenceMast", CmdType.StoredProcedure, param)
    End Sub


    Public Sub Add_Doc(ByVal b As Byte(), doctype As String, schemecode As String)
        Dim param As SqlParameter() = New SqlParameter(3) {}
        param(0) = New SqlParameter("@doc", SqlDbType.Image)
        param(1) = New SqlParameter("@doctype", doctype)
        param(2) = New SqlParameter("@schemecode", schemecode)

        param(0).Value = b
        param(1).Value = doctype
        param(2).Value = schemecode



        ExecuteCmd("SaveFrmDocs", CmdType.StoredProcedure, param)
    End Sub
    Public Sub AddDoc(ByVal b As Byte(), doctype As String, LicenceId As String)
        Dim param As SqlParameter() = New SqlParameter(3) {}
        param(0) = New SqlParameter("@doc", SqlDbType.Image)
        param(1) = New SqlParameter("@doctype", doctype)
        param(2) = New SqlParameter("@Id", LicenceId)

        param(0).Value = b
        param(1).Value = doctype
        param(2).Value = LicenceId



        ExecuteCmd("SaveFrmDocs_Licence", CmdType.StoredProcedure, param)
    End Sub
    Public Sub Update(ByVal FormId As Integer)
        Dim param(11) As SqlParameter
        SetParameter(param)
        param(11) = New SqlParameter("@FormId", FormId)
        ExecuteCmd("SaveFrmMast", CmdType.StoredProcedure, param)
    End Sub
    Public Function FillGrid() As Data.DataTable

        Return FillRecords("GetFormsMastData", CmdType.StoredProcedure)
    End Function

    Public Sub Delete(ByVal FormId As Integer)
        Dim param As SqlParameter() = New SqlParameter(0) {}
        param(0) = New SqlParameter("@FormId", FormId)
        ExecuteCmd("DeleteFrmMast", CmdType.StoredProcedure, param)
    End Sub
    Public Function LoadForm(ByVal SchemeCode As Integer) As Data.DataRow

        Dim param(1) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@SchemeCode", SchemeCode)
        Return GetRecordRow("GetFormData", CmdType.StoredProcedure, param)
    End Function
    Public Function LoadForm_Licence(ByVal LicenceId As Integer) As Data.DataRow

        Dim param(1) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@Id", LicenceId)
        Return GetRecordRow("GetFormData_Licence", CmdType.StoredProcedure, param)
    End Function
    Public Function LoadForm_data(ByVal FormId As Integer) As Data.DataRow

        Dim param(1) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@FormId", FormId)
        Return GetRecordRow("GetFormDataByid", CmdType.StoredProcedure, param)
    End Function
    Public Function IsExistform(ByVal FormName As String) As Boolean

        Dim param(2) As SqlClient.SqlParameter
        Dim i As Integer
        param(0) = New SqlClient.SqlParameter("FormName", FormName)
        i = ReturnValue("GetFormMastByName", CommandType.StoredProcedure, param)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub SetParameter(ByRef param As SqlParameter())
        param(0) = New SqlParameter("@SchemeCode", mSchemeCode)

        param(1) = New SqlParameter("@DeptId", mDeptid)
        param(2) = New SqlParameter("@FrmDesc", mfrmdesc)
        param(3) = New SqlParameter("@Form", SqlDbType.Image)
        param(4) = New SqlParameter("@FormName", mFormName)
        param(5) = New SqlParameter("@Form_eng", SqlDbType.Image)
        param(6) = New SqlParameter("@Form_Type", SqlDbType.Char, 1)
        param(7) = New SqlParameter("@AvailableId", mavaiId)
        param(8) = New SqlParameter("@ServiceDetails", SqlDbType.Image)
        param(9) = New SqlParameter("@ScUrl", mScUrl)
        param(10) = New SqlParameter("@AppUrl", mAppUrl)

        param(3).Value = mform
        param(5).Value = mformeng
        param(6).Value = mFormtype
        param(8).Value = mServiceDetails
    End Sub

    Public Sub SetParameter_(ByRef param As SqlParameter())
        param(0) = New SqlParameter("@doc", mSchemeCode)
        param(1) = New SqlParameter("@doctype", mDeptid)
        param(2) = New SqlParameter("@schemecode", mfrmdesc)

        param(3).Value = mform
        param(5).Value = mformeng
        param(6).Value = mFormtype
        param(8).Value = mServiceDetails
    End Sub

    Public Sub SetParameter1(ByRef param As SqlParameter())
        param(0) = New SqlParameter("@Id", mLicenceId)
        param(1) = New SqlParameter("@DeptId", mDeptid)
        param(2) = New SqlParameter("@FrmDesc", mfrmdesc)
        param(3) = New SqlParameter("@Form", SqlDbType.Image)
        param(4) = New SqlParameter("@FormName", mFormName)
        param(5) = New SqlParameter("@Form_eng", SqlDbType.Image)
        param(6) = New SqlParameter("@Form_Type", SqlDbType.Char, 1)
        param(7) = New SqlParameter("@ServiceDetails", SqlDbType.Image)
        param(8) = New SqlParameter("@AppUrl", mAppUrl)
        param(9) = New SqlParameter("@ScUrl", mScUrl)

        param(3).Value = mform
        param(5).Value = mformeng
        param(6).Value = mFormtype
        param(7).Value = mServiceDetails
    End Sub
#End Region
End Class
