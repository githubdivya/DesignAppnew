
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmIndexLookup
    DLookup = 0
    MLookup = 1
    DLookupFees = 2
    Dlookup_Son_Dua = 3
    Dlookupreligion = 4
End Enum

Public Class cLookup
    Inherits cBLBase
    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        If ds.Tables.Contains("Parameter") = True Then
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                Next
            End With
        End If
        Select Case CType(index, enmIndexLookup)
            Case enmIndexLookup.DLookup
                objDataExecute.getDataSet(ds, "COM_D_Lookup_Select", objColCriteria, "Lookup", Nothing)
            Case enmIndexLookup.DLookupFees
                objDataExecute.getDataSet(ds, "COM_D_LookupFees_Select", objColCriteria, "Lookup", Nothing)
            Case enmIndexLookup.MLookup
                objDataExecute.getDataSet(ds, "COM_M_Lookup_Select", objColCriteria, "MLookup", Nothing)
            Case enmIndexLookup.Dlookup_Son_Dua
                objDataExecute.getDataSet(ds, "COM_D_Lookup_Select_Son_Dau", objColCriteria, "Lookup", Nothing)
            Case enmIndexLookup.Dlookupreligion
                objDataExecute.getDataSet(ds, "COM_D_Lookup_Select_Religion", objColCriteria, "Lookup", Nothing)
        End Select
    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("Lookup"), objColCriteria, enmParameterMode.Update)
        objDataExecute.UpdateRec("COM_D_Lookup_Update", objColCriteria, "Lookup", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        objColCriteria.Add(New SqlParameter("LookupID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input, True, 0, 0, "LookupID", DataRowVersion.Default, New System.Guid(strCriteria)))
        objDataExecute.Insert("COM_D_Lookup_Delete", objColCriteria, "Lookup", Nothing)
    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("Lookup"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("COM_D_Lookup_Insert", objColCriteria, "Lookup", Nothing)
    End Sub

    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("LookupID", SqlDbType.Int, 4, ParameterDirection.InputOutput, True, 0, 0, "LookupID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("LookupID", SqlDbType.Int, 4, ParameterDirection.InputOutput, False, 0, 0, "LookupID", DataRowVersion.Default, .Item("LookupID")))
            End Select
            objColCriteria.Add(New SqlParameter("UserID", .Item("UserID")))
            objColCriteria.Add(New SqlParameter("RoleID", .Item("RoleID")))
            objColCriteria.Add(New SqlParameter("OfficeID", .Item("OfficeID")))
            objColCriteria.Add(New SqlParameter("LookCode", .Item("LookCode")))
            objColCriteria.Add(New SqlParameter("LookDescEn", .Item("LookDescEn")))
            objColCriteria.Add(New SqlParameter("LookDescGu", .Item("LookDescGu")))
            objColCriteria.Add(New SqlParameter("Val1", .Item("Val1")))
            objColCriteria.Add(New SqlParameter("Val2", .Item("Val2")))
            objColCriteria.Add(New SqlParameter("Isfixed", .Item("Isfixed")))
        End With
    End Sub
End Class
