Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Web
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Imports System.Data.SqlClient
Imports NICFrameWork.DataAccessLayer
'Imports LibSchemePortal

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
'<System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService
    Inherits System.Web.Services.WebService
    Private dsEntry As New DataSet
    <WebMethod()> _
    Public Function GetByDept(ByVal id As Integer, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(2) {}
        param1(0) = New SqlParameter("@DeptId", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetByDeptData", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> <Script.Services.ScriptMethod()> _
    Public Function FillSector(ByVal prefixText As String, ByVal count As Integer) As String()

        Dim rd As SqlDataReader = Nothing
        Dim item As List(Of String) = New List(Of String)(count)
        Dim sql As String
        sql = "Select SectorE from tblSectorMast where SectorE like '" & prefixText & "%'"
        rd = SqlHelper.ExecuteReader(getConnectionString(), CommandType.Text, sql)
        Dim strSector(rd.Depth) As String
        If rd.HasRows Then
            While (rd.Read())
                item.Add(Convert.ToString(rd.GetValue(0)))
            End While
        End If
        rd.Close()
        'rd.NextResult()
        'End While

        Return item.ToArray()
    End Function
    <WebMethod()> _
    Public Function GetByscheme(ByVal id As Integer, ByVal DeptID As Integer, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(3) {}
        param1(0) = New SqlParameter("@SchemeCode", id)
        param1(1) = New SqlParameter("@DeptID", DeptID)
        param1(2) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetBySchemeData", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetBySector(ByVal id As Integer, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(2) {}
        param1(0) = New SqlParameter("@SectorId", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetBySectorData", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If
    End Function
    <WebMethod()> _
    Public Function GetBySectorfrm1(ByVal id As Integer, ByVal MyCulture As String, ByVal flag As Integer) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(3) {}
        param1(0) = New SqlParameter("@SectorId", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        param1(2) = New SqlParameter("@flag", flag)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetBySectorData", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If
    End Function
    <WebMethod()> _
    Public Function GetByEvent(ByVal id As Integer, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(2) {}
        param1(0) = New SqlParameter("@eventid", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetByEvent", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If
    End Function

    <WebMethod()> <Script.Services.ScriptMethod()> _
    Public Function SearchByAll(ByVal Keyword As String, ByVal count As Integer) As String()
        Dim item As List(Of String) = New List(Of String)(count)
        Dim param1 As SqlParameter() = New SqlParameter(1) {}
        param1(0) = New SqlParameter("@Keyword", Keyword)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "SearchByAll", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To i <= ds1.Tables(0).Rows.Count
                item.Add(ds1.Tables(0).Rows(i)("SchemeName"))
            Next

            Return item.ToArray()
        Else
            Return Nothing
        End If
    End Function

    <WebMethod()> _
    Public Function GetBySchemeArea(ByVal id As Integer, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(2) {}
        param1(0) = New SqlParameter("@AreaCode", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetBySchemeArea", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetBySchemeAppTo(ByVal id As Integer, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(2) {}
        param1(0) = New SqlParameter("@SchemeAppToId", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetBySchemeAppTo", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetByCaste(ByVal id As String, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(2) {}
        param1(0) = New SqlParameter("@CasteCd", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetByCaste", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetByKeyword(ByVal id As String, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(1) {}
        param1(0) = New SqlParameter("@SubSector", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetByKeyword", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetByRCPSACT(ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(1) {}
        ' param1(0) = New SqlParameter("@RCPSACT", id)
        param1(0) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetByRCPSACT", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetGRData(ByVal str As String, ByVal MyCulture As String) As DataSet
        Dim sa() As String
        Dim fromdate As Nullable(Of Date)
        Dim todate As Nullable(Of Date)
        sa = RetrunAnArray(str)
        Dim param As SqlParameter() = New SqlParameter(6) {}
        param(0) = New SqlParameter("@DeptId", CInt(sa(0)))
        param(1) = New SqlParameter("@GROrderNumber", sa(1))
        param(2) = New SqlParameter("@GRDesc", sa(2))
        If sa(3) <> "" Then
            fromdate = FormatDateTime(CDate(sa(3)), DateFormat.ShortDate)
        Else
            fromdate = Nothing
        End If
        If sa(4) <> "" Then
            todate = FormatDateTime(CDate(sa(4)), DateFormat.ShortDate)
        Else
            todate = Nothing
        End If
        param(3) = New SqlParameter("@fromdate", fromdate)
        param(4) = New SqlParameter("@todate", todate)
        param(5) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "SearchGR", param)
        Return ds
    End Function
    <WebMethod()> _
    Public Function GetFRMData(ByVal str As String) As DataSet
        Dim sa() As String
        sa = RetrunAnArray(str)
        Dim param As SqlParameter() = New SqlParameter(5) {}
        param(0) = New SqlParameter("@DeptId", CInt(sa(0)))
        param(1) = New SqlParameter("@FormName", sa(1))
        param(2) = New SqlParameter("@FrmDesc", sa(2))
        param(3) = New SqlParameter("@AvaiId", CInt(sa(3)))
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "SearchFrm", param)
        Return ds
    End Function

    <WebMethod()> _
    Public Function GetData(ByVal str As String) As DataSet
        Dim sa() As String

        sa = RetrunAnArray(str)
        Dim param As SqlParameter() = New SqlParameter(14) {}
        param(0) = New SqlParameter("@SectorId", CInt(sa(0)))
        param(1) = New SqlParameter("@CatId", CInt(sa(1)))
        param(2) = New SqlParameter("@ReligionId", sa(2))
        param(3) = New SqlParameter("@CasteCd", sa(3))
        param(4) = New SqlParameter("@SocioEcoId", CInt(sa(4)))
        param(5) = New SqlParameter("@Gender", sa(5))
        param(6) = New SqlParameter("@Age", CInt(sa(6)))
        param(7) = New SqlParameter("@Income", CDec(sa(7)))
        param(8) = New SqlParameter("@FamIncome", CDec(sa(8)))
        param(9) = New SqlParameter("@Occup_cd", sa(9))
        param(10) = New SqlParameter("@Edu_cd", sa(10))
        param(11) = New SqlParameter("@SchemeAppToId", CInt(sa(11)))
        param(12) = New SqlParameter("@AreaCode", CInt(sa(12)))
        param(13) = New SqlParameter("@SchemeBFTId", CInt(sa(13)))


        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "StoredProcedure1", param)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds
        Else
            Return Nothing
        End If

    End Function
    '<WebMethod()> _
    'Public Function GetFilter(ByVal dv As Object) As DataView

    'End Function
    <WebMethod()> _
    Public Function GetData1(ByVal str As String, ByVal MyCulture As String) As DataSet
        Dim sa() As String

        sa = RetrunAnArray(str)
        Dim param As SqlParameter() = New SqlParameter(14) {}
        param(0) = New SqlParameter("@SectorId", CInt(sa(0)))
        param(1) = New SqlParameter("@CatId", CInt(sa(1)))
        param(2) = New SqlParameter("@ReligionId", sa(2))
        param(3) = New SqlParameter("@CasteCd", sa(3))
        param(4) = New SqlParameter("@SocioEcoId", CInt(sa(4)))
        param(5) = New SqlParameter("@Gender", sa(5))
        param(6) = New SqlParameter("@Age", CInt(sa(6)))
        param(7) = New SqlParameter("@Income", CDec(sa(7)))
        param(8) = New SqlParameter("@FamIncome", CDec(sa(8)))
        param(9) = New SqlParameter("@Occup_cd", sa(9))
        param(10) = New SqlParameter("@Edu_cd", sa(10))
        param(11) = New SqlParameter("@SchemeAppToId", CInt(sa(11)))
        param(12) = New SqlParameter("@AreaCode", CInt(sa(12)))
        param(13) = New SqlParameter("@SchemeBFTId", CInt(sa(13)))
        param(14) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "NormalSearch", param)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetNormalSearch(ByVal str As String, ByVal MyCulture As String) As DataSet
        Dim sa() As String

        sa = RetrunAnArray(str)
        Dim param As SqlParameter() = New SqlParameter(14) {}
        param(0) = New SqlParameter("@SectorId", CInt(sa(0)))
        param(1) = New SqlParameter("@CatId", CInt(sa(1)))
        param(2) = New SqlParameter("@ReligionId", sa(2))
        param(3) = New SqlParameter("@CasteCd", sa(3))
        param(4) = New SqlParameter("@SocioEcoId", CInt(sa(4)))
        param(5) = New SqlParameter("@Gender", sa(5))
        param(6) = New SqlParameter("@Age", CInt(sa(6)))
        param(7) = New SqlParameter("@Income", CDec(sa(7)))
        param(8) = New SqlParameter("@FamIncome", CDec(sa(8)))
        param(9) = New SqlParameter("@Occup_cd", sa(9))
        param(10) = New SqlParameter("@Edu_cd", sa(10))
        param(11) = New SqlParameter("@SchemeAppToId", CInt(sa(11)))
        param(12) = New SqlParameter("@AreaCode", CInt(sa(12)))
        param(13) = New SqlParameter("@SchemeBFTId", CInt(sa(13)))
        param(14) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "ExactSearch", param)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetFilterData(ByVal str As String) As DataSet
        Dim sa() As String
        Dim i As Integer
        Dim swhere As String = "Select distinct SchemeCode from Finalview where"
        sa = RetrunAnArray(str)

        Dim param As SqlParameter() = New SqlParameter(5) {}
        param(0) = New SqlParameter("@DeptId", CInt(sa(0)))
        param(1) = New SqlParameter("@SectorId", CInt(sa(1)))
        param(2) = New SqlParameter("@Gender", sa(2))
        param(3) = New SqlParameter("@CasteCd", sa(3))
        param(4) = New SqlParameter("@AreaCode", CInt(sa(4)))

        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "FilterData", param)

        Dim dt As DataTable = ds.Tables(0)
        Dim sid As String = String.Empty
        Dim count As Integer = dt.Rows.Count - 1
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1

                If i = count Then
                    sid = sid & dt.Rows(i).Item("SchemeCode").ToString
                Else
                    sid = sid & dt.Rows(i).Item("SchemeCode").ToString & ","
                End If
            Next
            ' Dim newsql As String = "Select SchemeCode,SchemeName,GistOfScheme from tblSchemeMast where SchemeCode In (" & sid & ")"
            Dim newsql As String = "Select  a.SchemeCode as SchemeCode,a.SchemeName as SchemeName,a.GistOfScheme as GistOfScheme,a.DeptId as DeptId ,a.SectorId as SectorId,a.Gender as Gender,tblCasteMast.CasteCd,tblSchemeAppArea.AreaCode from tblSchemeMast a  LEFT OUTER JOIN tblCasteMast ON a.CasteId = tblCasteMast.CasteId LEFT OUTER JOIN tblSchemeAppArea ON a.SchemeCode = tblSchemeAppArea.SchemeCode where a.SchemeCode In (" & sid & ")"
            Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.Text, newsql)
            If ds1.Tables(0).Rows.Count > 0 Then
                Return ds1
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function
    Public Function getConnectionString() As String
        Dim objcn As New Cn

        Return objcn.NewConnectionString(enumDBGroup.SchemePortal)
    End Function
    Public Function RetrunAnArray(ByRef Str As String) As String()
        If Str <> "" Then
            RetrunAnArray = Split(Str, ",")
            Return RetrunAnArray
        Else
            Return Nothing
        End If
    End Function

    <WebMethod()> _
    Public Function GetDetail(ByVal SchemeCode As Integer, ByRef MyCulture As String) As DataSet
        Dim sql As String = ""
        Dim param(1) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("SchemeCode", SchemeCode)
        param(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetDetails", param)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds
        Else
            Return Nothing
        End If
    End Function

    <WebMethod()> _
    Public Function GetScAppArea(ByVal SchemeCode As Integer, ByRef MyCulture As String, ByVal flag As Integer) As DataSet
        Dim param(2) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@SchemeCode", SchemeCode)
        param(1) = New SqlParameter("@MyCulture", MyCulture)
        param(2) = New SqlParameter("@flag", flag)
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetScAppArea", param)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds
        Else
            Return Nothing
        End If
    End Function
    <WebMethod()> _
    Public Function GetAttachement(ByVal SchemeCode As Integer, ByRef MyCulture As String) As DataSet
        Dim param(1) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@SchemeCode", SchemeCode)
        param(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetAttachement", param)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds
        Else
            Return Nothing
        End If
    End Function
    <WebMethod()> _
    Public Function GetByBenefit(ByVal id As String, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(1) {}
        param1(0) = New SqlParameter("@SchemeBFTId", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetBySchemeBenefit", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetByOwned(ByVal id As String, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(1) {}
        param1(0) = New SqlParameter("@CatId", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetByOwned", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetByTarget(ByVal id As String, ByVal MyCulture As String) As DataSet
        Dim param1 As SqlParameter() = New SqlParameter(1) {}
        param1(0) = New SqlParameter("@SchemeTargetArea", id)
        param1(1) = New SqlParameter("@MyCulture", MyCulture)
        Dim ds1 As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetByTarget", param1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Return ds1
        Else
            Return Nothing
        End If

    End Function
    <WebMethod()> _
    Public Function GetScOfficeDetail(ByVal id As String) As DataSet
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@SchemeCode", id)
        Dim ds As DataSet = SqlHelper.ExecuteDataset(getConnectionString(), CommandType.StoredProcedure, "GetScOfficeDetail", param)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds
        Else
            Return Nothing
        End If
    End Function

    'Private Sub getCollection(ByRef objParameter As cParameter, ByVal index As Int16, Optional ByVal common As Boolean = False)

    '    Dim culture As String
    '    culture = ""
    '    'Session("MyCulture").ToString()
    '    If IsNothing(objParameter) Then
    '        objParameter = New cParameter(dsEntry)

    '    End If
    '    Select Case index
    '        Case 0

    '        Case 1 'for Populate Data
    '            Dim objUserInfo As cUserInfo

    '            objUserInfo = Session("objUserInfo")
    '            'If myTextBox.Text.Trim.Length > 0 Then
    '            objParameter.CreateParameter(dsEntry, "@matadata", sid.String, enmParameterType.Input, SqlDbType.Text)
    '            ' End If



    '    End Select
    'End Sub
End Class