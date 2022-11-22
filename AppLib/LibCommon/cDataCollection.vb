Imports System.Data.SqlClient

Public Class cDataCollection
    Inherits System.Data.Common.DbParameter
    Private _DbType As System.Data.DbType
    Private _Direction As System.Data.ParameterDirection
    Private _IsNullable As Boolean
    Private _ParameterName As String
    Private _Size As Integer
    Private _SourceColumn As String
    Private _SourceColumnNullMapping As Boolean
    Private _SourceVersion As System.Data.DataRowVersion
    Private _Value As Object
    Public Sub New(ByVal myDbType As System.Data.DbType, ByVal myDirection As System.Data.ParameterDirection)
        DbType = myDbType
        Direction = myDirection
    End Sub
   
    Public Overrides Property DbType() As System.Data.DbType
        Get
            Return _DbType
        End Get
        Set(ByVal value As System.Data.DbType)
            _DbType = value
        End Set
    End Property

    Public Overrides Property Direction() As System.Data.ParameterDirection
        Get
            Return _Direction
        End Get
        Set(ByVal value As System.Data.ParameterDirection)
            _Direction = value
        End Set
    End Property

    Public Overrides Property IsNullable() As Boolean
        Get
            Return _IsNullable
        End Get
        Set(ByVal value As Boolean)
            _IsNullable = value
        End Set
    End Property

    Public Overrides Property ParameterName() As String
        Get
            Return _ParameterName
        End Get
        Set(ByVal value As String)
            _ParameterName = value
        End Set
    End Property

    Public Overrides Sub ResetDbType()

    End Sub

    Public Overrides Property Size() As Integer
        Get
            Return _Size
        End Get
        Set(ByVal value As Integer)
            _Size = value
        End Set
    End Property

    Public Overrides Property SourceColumn() As String
        Get
            Return _SourceColumn
        End Get
        Set(ByVal value As String)
            _SourceColumn = value
        End Set
    End Property

    Public Overrides Property SourceColumnNullMapping() As Boolean
        Get
            Return _SourceColumnNullMapping
        End Get
        Set(ByVal value As Boolean)
            _SourceColumnNullMapping = value
        End Set
    End Property

    Public Overrides Property SourceVersion() As System.Data.DataRowVersion
        Get
            Return _SourceVersion
        End Get
        Set(ByVal value As System.Data.DataRowVersion)
            _SourceVersion = value
        End Set
    End Property

    Public Overrides Property Value() As Object
        Get
            Return _Value
        End Get
        Set(ByVal value As Object)
            _Value = value
        End Set
    End Property
End Class
