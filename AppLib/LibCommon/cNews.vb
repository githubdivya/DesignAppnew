
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmnews
    news = 1
    Insert = 2
    news_homepage = 3
End Enum

Public Class cNews
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

            Select Case CType(index, enmnews)

                Case enmnews.news
                    objDataExecute.getDataSet(ds, "COM_M_Newsservice_Select", objColCriteria, "NewsTable", Nothing)
                Case enmnews.news_homepage
                    objDataExecuteM.getDataSet(ds, "COM_M_New_homepage_Select", objColCriteria, "NewsHomepage", enumDBGroup.CommonDBSimpleMode)

                Case Else
                    objDataExecute.getDataSet(ds, "COM_M_News_Select", objColCriteria, "News", Nothing)
            End Select

            'Select Case CType(index, enmnews)

            'Case enmnews.news
            '    objDataExecute.getDataSet(ds, "COM_M_Newsservice_Select", objColCriteria, "News", Nothing)
            'Case 
            ' objDataExecute.getDataSet(ds, "COM_M_News_Select", objColCriteria, "News", Nothing)
            'End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overridable Sub GetDataSetForExists(ByRef ds As DataTable, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            With ds
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
            Select Case CType(index, enmnews)

                Case enmnews.news
                    objDataExecute.getDataTable(ds, "COM_M_Newsservice_Select", objColCriteria, "NewsTable", Nothing)

            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("NewsId", strCriteria))
        objDataExecute.Insert("COM_M_News_Delete", objColCriteria, "News", Nothing)
    End Sub

    Public Overridable Sub DeleteAllNews(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        'objColCriteria.Add(New SqlParameter("NewsId", strCriteria))
        objDataExecute.Insert("COM_M_Newsservices_Delete", objColCriteria, "NewsTable", Nothing)
    End Sub
    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        ' Select CType(index, enmnews)

        'Case enmnews.news
        '    CreateParameterservice(Tables("NewsTable"), objColCriteria, enmParameterMode.Insert)
        '    objDataExecute.Insert("COM_M_Newsservice_Insert", objColCriteria, "NewsTable", Nothing)
        'Case 
        CreateParameter(ds.Tables("News"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("COM_M_News_Insert", objColCriteria, "News", Nothing)
        ' End Select


    End Sub

    Public Overridable Sub InsertNews(ByVal dt As DataTable, ByVal index1 As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria1 As New Collection
        Select Case CType(index1, enmnews)

            Case enmnews.news
                CreateParameterservice(dt, objColCriteria1, enmnews.Insert)
                objDataExecute.Insert("COM_M_Newsservice_Insert", objColCriteria1, "NewsTable", Nothing)

        End Select


    End Sub
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            objColCriteria.Add(New SqlParameter("NewsId", .Item("NewsId")))
            objColCriteria.Add(New SqlParameter("News", .Item("News")))
            objColCriteria.Add(New SqlParameter("New_Image", .Item("New_Image")))
            objColCriteria.Add(New SqlParameter("StatusId", .Item("StatusId")))
        End With
    End Sub
    Private Sub CreateParameterservice(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmnews)
        With dt.Rows(0)
            ' objColCriteria.Add(New SqlParameter("NewsId", .Item("NewsId")))
            objColCriteria.Add(New SqlParameter("NewsTitle", .Item("NewsTitle")))
            objColCriteria.Add(New SqlParameter("NewsUrl", .Item("NewsUrl")))
            objColCriteria.Add(New SqlParameter("IsActive", .Item("IsActive")))
        End With
    End Sub
End Class
