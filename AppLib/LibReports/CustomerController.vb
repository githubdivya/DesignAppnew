Imports NICFrameWork.BusinessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Imports System.Globalization
Imports Microsoft.VisualBasic
Public Enum enmIndexCustomer
    Customer = 1
End Enum
Public Interface ICustomerController
End Interface
Public Class cCustomerController
    Inherits cBLBase

    Public Overridable Sub GetDataSet(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Try
            Dim i As Integer
            Dim objColCriteria As New Collection
            If ds.Tables.Contains("Parameter") = True Then
                With ds.Tables("Parameter")
                    For i = 0 To .Rows.Count - 1
                        If CInt(.Rows(i).Item("PType")) = 1 Then
                            If .Rows(i).Item("DbType").ToString = "DateTime" Then
                                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, CDate(.Rows(i).Item("Pvalue"))))
                            Else
                                objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                            End If
                        ElseIf IsDBNull(.Rows(i).Item("Pvalue")) Then
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, .Rows(i).Item("Pvalue")))
                        Else
                            objColCriteria.Add(New SqlParameter(.Rows(i).Item("PName").ToString, New System.Guid(.Rows(i).Item("Pvalue").ToString)))
                        End If
                    Next
                End With
            End If
            Select Case CType(index, enmIndexSROReports)
                Case enmIndexCustomer.Customer
                    objDataExecute.getDataSet(ds, "GPS_T_CustomerDetails_Select", objColCriteria, "CustomerDetails", Nothing)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overridable Sub DataNavigate(ByRef ds As DataSet, ByVal currentRecNo As Integer, ByVal objColCriteria As Collection, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Update(ByRef ds As DataSet, Optional ByVal index As Object = 0, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("CustomerDetails"), objColCriteria, enmParameterMode.Update)
        objDataExecute.UpdateRec("GPS_T_CustomerDetails_Update", objColCriteria, "CustomerDetails", Nothing)
    End Sub

    Public Overridable Sub Delete(ByVal strCriteria As String, Optional ByVal objColCriteria As Collection = Nothing, Optional ByVal index As Object = 0)

    End Sub

    Public Overridable Sub Insert(ByRef ds As DataSet, ByVal index As Object, Optional ByVal enmwsIndex As Int16 = Nothing)
        Dim objColCriteria As New Collection
        CreateParameter(ds.Tables("CustomerDetails"), objColCriteria, enmParameterMode.Insert)
        objDataExecute.Insert("GPS_T_CustomerDetails_Insert", objColCriteria, "CustomerDetails", Nothing)
    End Sub

    Public Overridable Function GetLastRec(ByVal objColCriteria As Collection, Optional ByVal index As Object = 0) As Integer

    End Function
    Private Sub CreateParameter(ByRef dt As DataTable, ByRef objColCriteria As Collection, ByVal ParameterMode As enmParameterMode)
        With dt.Rows(0)
            Select Case ParameterMode
                Case enmParameterMode.Insert
                    '   objColCriteria.Add(New SqlParameter("ApplicationID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, True, 0, 0, "ApplicationID", DataRowVersion.Default, DBNull.Value))
                Case enmParameterMode.Update
                    objColCriteria.Add(New SqlParameter("ApplicationID", SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput, False, 0, 0, "ApplicationID", DataRowVersion.Default, .Item("ApplicationID")))
                    objColCriteria.Add(New SqlParameter("VerifyCount", .Item("VerifyCount")))
                    objColCriteria.Add(New SqlParameter("UpdatedOn", .Item("UpdatedOn")))
            End Select
            objColCriteria.Add(New SqlParameter("TokenNo", .Item("TokenNo")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Id", .Item("CST_Cust_Id")))
            objColCriteria.Add(New SqlParameter("CST_Cust_By", .Item("CST_Cust_By")))
            objColCriteria.Add(New SqlParameter("CST_Cust_OperatorHashKey", .Item("CST_Cust_OperatorHashKey")))
            objColCriteria.Add(New SqlParameter("CST_Cust_ServiceHaskKey", .Item("CST_Cust_ServiceHaskKey")))
            objColCriteria.Add(New SqlParameter("CST_Cust_HashKey", .Item("CST_Cust_HashKey")))
            objColCriteria.Add(New SqlParameter("CST_Cust_No", .Item("CST_Cust_No")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Name", .Item("CST_Cust_Name")))
            objColCriteria.Add(New SqlParameter("CST_Cust_FName", .Item("CST_Cust_FName")))
            objColCriteria.Add(New SqlParameter("CST_Cust_LName", .Item("CST_Cust_LName")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Address", .Item("CST_Cust_Address")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Pincode", .Item("CST_Cust_Pincode")))
            objColCriteria.Add(New SqlParameter("CST_Cust_District", .Item("CST_Cust_District")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Taluka", .Item("CST_Cust_Taluka")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Telephone", .Item("CST_Cust_Telephone")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Mobile", .Item("CST_Cust_Mobile")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Email", .Item("CST_Cust_Email")))
            objColCriteria.Add(New SqlParameter("CST_Cust_DocumSubmited", .Item("CST_Cust_DocumSubmited")))
            objColCriteria.Add(New SqlParameter("CST_Cust_Date", .Item("CST_Cust_Date")))
        End With
    End Sub
End Class
