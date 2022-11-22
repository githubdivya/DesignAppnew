Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer

Public Class cOffice
    Inherits cBLBase

    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        If ds.Tables.Contains("Parameter") = True Then
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    If CInt(.Rows(i).Item("PType")) = 1 Then
                        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                    Else
                        If .Rows(i).Item("Pvalue").ToString.Trim = "-1" Then
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                        Else
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, "ReceiptNo", DataRowVersion.Default, New System.Guid(.Rows(i).Item("Pvalue").ToString)))
                        End If
                    End If
                Next
            End With
        End If
        objDataExecute.getDataSet(ds, "COM_M_office_Select", objColCriteria, "OfficeMast", Nothing)
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim i As Integer
        Dim objColCriteria As New Collection
        'CreateParameter(ds.Tables("OfficeMast"), objColCriteria, enmParameterMode.Update)
        If ds.Tables.Contains("Parameter") = True Then
            With ds.Tables("Parameter")
                For i = 0 To .Rows.Count - 1
                    If CInt(.Rows(i).Item("PType")) = 1 Then
                        objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                    Else
                        If .Rows(i).Item("Pvalue").ToString.Trim = "-1" Then
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, DBNull.Value))
                        Else
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, "ReceiptNo", DataRowVersion.Default, New System.Guid(.Rows(i).Item("Pvalue").ToString)))
                        End If
                    End If
                Next
            End With
        End If
        objDataExecute.UpdateRec("COM_M_office_Update", objColCriteria, "OfficeMast", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)

    End Sub

    Public Overridable Sub Insert(ByVal ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)

        '' DataSet that will hold the returned results	
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("OfficeMast"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("COM_M_office_Insert", objColCriteria, "OfficeMast", Nothing)
        With ds.Tables("OfficeMast").Rows(0)
            .Item("intOfficeId") = CType(objColCriteria(1), SqlParameter).Value
        End With
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    objColCriteria.Add(New SqlParameter("intOfficeId", SqlDbType.Int, 8, ParameterDirection.InputOutput, True, 8, 0, "intOfficeId", DataRowVersion.Default, .Item("intOfficeId")))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("intOfficeId", SqlDbType.Int, 8, ParameterDirection.Input, False, 8, 0, "intOfficeId", DataRowVersion.Default, .Item("intOfficeId")))
            End Select
            objColCriteria.Add(New SqlParameter("intDeptId", .Item("intDeptId")))
            objColCriteria.Add(New SqlParameter("oldOfficeId", .Item("oldOfficeId")))
            objColCriteria.Add(New SqlParameter("intParentOfficeId", .Item("intParentOfficeId")))
            objColCriteria.Add(New SqlParameter("intDepthId", .Item("intDepthId")))
            objColCriteria.Add(New SqlParameter("strPathString", .Item("strPathString")))
            objColCriteria.Add(New SqlParameter("strOfficeName_E", .Item("strOfficeName_E")))

            objColCriteria.Add(New SqlParameter("strOfficeName_G", .Item("strOfficeName_G")))
            objColCriteria.Add(New SqlParameter("strOfficeNameShort", .Item("strOfficeNameShort")))
            objColCriteria.Add(New SqlParameter("strOfficeName_S", .Item("strOfficeName_S")))
            objColCriteria.Add(New SqlParameter("strAddress1", .Item("strAddress1")))
            objColCriteria.Add(New SqlParameter("strAddress2", .Item("strAddress2")))

            objColCriteria.Add(New SqlParameter("intDistId", .Item("intDistId")))
            objColCriteria.Add(New SqlParameter("intTalukaId", .Item("intTalukaId")))
            objColCriteria.Add(New SqlParameter("intTownId", .Item("intTownId")))
            objColCriteria.Add(New SqlParameter("strPincode", .Item("strPincode")))
            objColCriteria.Add(New SqlParameter("strhod", .Item("strhod")))
            objColCriteria.Add(New SqlParameter("strdesignation", .Item("strdesignation")))
            objColCriteria.Add(New SqlParameter("strPhone", .Item("strPhone")))
            objColCriteria.Add(New SqlParameter("strSTDCode", .Item("strSTDCode")))

            objColCriteria.Add(New SqlParameter("strFax", .Item("strFax")))
            objColCriteria.Add(New SqlParameter("strEmail", .Item("strEmail")))
            objColCriteria.Add(New SqlParameter("strGSWANNo", .Item("strGSWANNo")))
            objColCriteria.Add(New SqlParameter("bIsActive", .Item("bIsActive")))
            objColCriteria.Add(New SqlParameter("intOfficeType", .Item("intOfficeType")))

            objColCriteria.Add(New SqlParameter("intAreaType", .Item("intAreaType")))
            objColCriteria.Add(New SqlParameter("intTreasureCode", .Item("intTreasureCode")))
            objColCriteria.Add(New SqlParameter("intTreasuresubCode", .Item("intTreasuresubCode")))
            objColCriteria.Add(New SqlParameter("intCardexNo", .Item("intCardexNo")))
            objColCriteria.Add(New SqlParameter("bIsDeleted", .Item("bIsDeleted")))
        End With
    End Sub

End Class
