Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Class Cast
    Inherits cBLBase

    Private _Code As Integer
    Public Property Code() As Integer
        Get
            Return _Code
        End Get
        Set(ByVal value As Integer)
            _Code = value
        End Set
    End Property

    Private _DescGuj As String
    Public Property DescGuj() As String
        Get
            Return _DescGuj
        End Get
        Set(ByVal value As String)
            If CStr(value).Length <= 255 Then
                _DescGuj = value.Replace("'", " ")
            Else
                Throw New Exception("Length Exceeded for DescGuj.")
            End If
        End Set
    End Property

    Private _DescEng As String
    Public Property DescEng() As String
        Get
            Return _DescEng
        End Get
        Set(ByVal value As String)
            If CStr(value).Length <= 250 Then
                _DescEng = value.Replace("'", " ")
            Else
                Throw New Exception("Length Exceeded for DescEng.")
            End If
        End Set
    End Property

    Private _GovtNO As String
    Public Property GovtNO() As String
        Get
            Return _GovtNO
        End Get
        Set(ByVal value As String)
            If CStr(value).Length <= 250 Then
                _GovtNO = value.Replace("'", " ")
            Else
                Throw New Exception("Length Exceeded for GovtNO.")
            End If
        End Set
    End Property

    Private _CasteType As Integer
    Public Property CasteType() As Integer
        Get
            Return _CasteType
        End Get
        Set(ByVal value As Integer)
            _CasteType = value
        End Set
    End Property

    Private _CreatedOn As Nullable(Of Date) = Nothing
    Public Property CreatedOn() As Nullable(Of Date)
        Get
            Return _CreatedOn
        End Get
        Set(ByVal value As Nullable(Of Date))
            _CreatedOn = value
        End Set
    End Property

    Private _CreatedBy As Integer
    Public Property CreatedBy() As Integer
        Get
            Return _CreatedBy
        End Get
        Set(ByVal value As Integer)
            _CreatedBy = value
        End Set
    End Property

    Private _UpdatedOn As Nullable(Of Date) = Nothing
    Public Property UpdatedOn() As Nullable(Of Date)
        Get
            Return _UpdatedOn
        End Get
        Set(ByVal value As Nullable(Of Date))
            _UpdatedOn = value
        End Set
    End Property

    Private _UpdatedBy As Integer
    Public Property UpdatedBy() As Integer
        Get
            Return _UpdatedBy
        End Get
        Set(ByVal value As Integer)
            _UpdatedBy = value
        End Set
    End Property

    Public Function Insert() As Integer
        Dim strSql As String
        Dim result As Integer = 0
        strSql = "COM_M_Caste_Insert"
        Dim SqlParam(8) As SqlParameter
        Try
            SqlParam(0) = New SqlParameter("@CODE", Me.Code)
            SqlParam(1) = New SqlParameter("@DESCGUJ", Me.DescGuj)
            SqlParam(2) = New SqlParameter("@DESCENG", Me.DescEng)
            SqlParam(3) = New SqlParameter("@GOVTNO", Me.GovtNO)
            SqlParam(4) = New SqlParameter("@CASTETYPE", Me.CasteType)
            SqlParam(5) = New SqlParameter("@CREATEDON", Me.CreatedOn)
            SqlParam(6) = New SqlParameter("@CREATEDBY", Me.CreatedBy)
            SqlParam(7) = New SqlParameter("@UPDATEDON", Me.UpdatedOn)
            SqlParam(8) = New SqlParameter("@UPDATEDBY", Me.UpdatedBy)

            objDataExecute.Insert("COM_M_Caste_Update", SqlParam, "Caste", Nothing)
        Catch ex As SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function

    Public Function Delete(ByVal id As Integer) As Integer
        Dim strSql As String
        Dim result As Integer = 0
        strSql = "COM_M_Caste_Delete"
        Dim SqlParam(0) As SqlParameter
        Try
            SqlParam(0) = New SqlParameter("@CODE", id)

            Dim objSQL As New SQLHelper()
            result = objSQL.ExecuteNonQuery(strSql, SqlParam)
            objSQL = Nothing
        Catch ex As SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function

    Public Function Update() As Integer
        Dim strSql As String
        Dim result As Integer = 0
        strSql = "COM_M_Caste_Update"
        Dim SqlParam(8) As SqlParameter
        Try
            SqlParam(0) = New SqlParameter("@CODE", Me.Code)
            SqlParam(1) = New SqlParameter("@DESCGUJ", Me.DescGuj)
            SqlParam(2) = New SqlParameter("@DESCENG", Me.DescEng)
            SqlParam(3) = New SqlParameter("@GOVTNO", Me.GovtNO)
            SqlParam(4) = New SqlParameter("@CASTETYPE", Me.CasteType)
            SqlParam(5) = New SqlParameter("@CREATEDON", Me.CreatedOn)
            SqlParam(6) = New SqlParameter("@CREATEDBY", Me.CreatedBy)
            SqlParam(7) = New SqlParameter("@UPDATEDON", Me.UpdatedOn)
            SqlParam(8) = New SqlParameter("@UPDATEDBY", Me.UpdatedBy)

            Dim objSQL As New SQLHelper()
            result = objSQL.ExecuteNonQuery(strSql, SqlParam)
            objSQL = Nothing
        Catch ex As SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function

    Public Function Find(ByVal id As Integer) As COM_M_Caste
        Dim strSql As String
        strSql = "COM_M_Caste_Find"
        Dim obj As COM_M_Caste
        Dim reader As SqlDataReader
        Dim SqlParam(0) As SqlParameter
        SqlParam(0) = New SqlParameter("@CODE", id)
        Try
            Dim objSQL As New SQLHelper()
            reader = objSQL.ExecuteReader(strSql, SqlParam)
            If (reader.HasRows) Then
                While (reader.Read())
                    obj = New COM_M_Caste()
                    obj.Code = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Code")))
                    obj.Code = Convert.ToString(reader.GetValue(reader.GetOrdinal("Code")))
                    obj.DescGuj = Convert.ToString(reader.GetValue(reader.GetOrdinal("DescGuj")))
                    obj.DescEng = Convert.ToString(reader.GetValue(reader.GetOrdinal("DescEng")))
                    obj.GovtNO = Convert.ToString(reader.GetValue(reader.GetOrdinal("GovtNO")))
                    obj.CasteType = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CasteType")))
                    obj.CasteType = Convert.ToString(reader.GetValue(reader.GetOrdinal("CasteType")))
                    obj.CreatedOn = Convert.ToString(reader.GetValue(reader.GetOrdinal("CreatedOn")))
                    obj.CreatedBy = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CreatedBy")))
                    obj.CreatedBy = Convert.ToString(reader.GetValue(reader.GetOrdinal("CreatedBy")))
                    obj.UpdatedOn = Convert.ToString(reader.GetValue(reader.GetOrdinal("UpdatedOn")))
                    obj.UpdatedBy = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("UpdatedBy")))
                    obj.UpdatedBy = Convert.ToString(reader.GetValue(reader.GetOrdinal("UpdatedBy")))
                End While
            End If
            If (Not reader.IsClosed) Then
                reader.Close()
            End If
        Catch ex As SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function

    Public Function List() As List(Of COM_M_Caste)
        Dim strSql As String
        strSql = "COM_M_Caste_Select"
        Dim lst As New List(Of COM_M_Caste)
        Dim reader As SqlDataReader
        Try
            Dim objSQL As New SQLHelper()
            reader = objSQL.ExecuteReader(strSql)
            If (reader.HasRows) Then
                While (reader.Read())
                    Dim obj As New COM_M_Caste()
                    obj.Code = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Code")))
                    obj.Code = Convert.ToString(reader.GetValue(reader.GetOrdinal("Code")))
                    obj.DescGuj = Convert.ToString(reader.GetValue(reader.GetOrdinal("DescGuj")))
                    obj.DescEng = Convert.ToString(reader.GetValue(reader.GetOrdinal("DescEng")))
                    obj.GovtNO = Convert.ToString(reader.GetValue(reader.GetOrdinal("GovtNO")))
                    obj.CasteType = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CasteType")))
                    obj.CasteType = Convert.ToString(reader.GetValue(reader.GetOrdinal("CasteType")))
                    obj.CreatedOn = Convert.ToString(reader.GetValue(reader.GetOrdinal("CreatedOn")))
                    obj.CreatedBy = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CreatedBy")))
                    obj.CreatedBy = Convert.ToString(reader.GetValue(reader.GetOrdinal("CreatedBy")))
                    obj.UpdatedOn = Convert.ToString(reader.GetValue(reader.GetOrdinal("UpdatedOn")))
                    obj.UpdatedBy = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("UpdatedBy")))
                    obj.UpdatedBy = Convert.ToString(reader.GetValue(reader.GetOrdinal("UpdatedBy")))
                    lst.Add(obj)
                End While
            End If
            If (Not reader.IsClosed) Then
                reader.Close()
            End If
        Catch ex As SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        Return lst
    End Function

End Class




