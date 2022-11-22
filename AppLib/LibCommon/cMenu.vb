
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Class cMenu
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
            objDataExecute.getDataSet(ds, "COM_M_Menu_Find", objColCriteria, "Menu", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub GetDataSet_Main_menu(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            'With ds.Tables("Parameter")
            '    For i = 0 To .Rows.Count - 1
            '        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
            '    Next
            'End With
            objDataExecute.getDataSet(ds, "Com_M_Main_Menu_Select", objColCriteria, "Menu", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub GetDataSet_Sub_menu(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.getDataSet(ds, "Com_M_SubMenu_Find", objColCriteria, "SubMenu", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub GetDataSet_Sub_menu_list(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.getDataSet(ds, "Com_M_SubMenu_Select", objColCriteria, "SubMenu", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Insert_To_SubMenu_List(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            objDataExecute.getDataSet(ds, "Com_m_menu_insert", objColCriteria, "SubMenu", Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim objColCriteria As New Collection
            objColCriteria.Add(New SqlParameter("id", SqlDbType.Int, 16, ParameterDirection.Input, True, 0, 0, "id", DataRowVersion.Default, strCriteria))
            'objColCriteria.Add(New SqlParameter("id", Convert.ToInt32(strCriteria)))

            objDataExecute.Insert("COM_M_Menu_Delete", objColCriteria, "Submenu")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
