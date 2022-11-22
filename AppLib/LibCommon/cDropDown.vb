Imports NICFrameWork.DataAccessLayer
Imports System.Data.Common
Imports System.Data.SqlClient
Public Enum enmDropDown

    Service = 1
    ServiceGroup = 2
    DocumentAttachment = 3
    COM_M_RegBranch = 4
    COM_M_RegTable = 5
    ServiceFees = 6
    COM_M_FinancialYr = 7

    Report = 8
    Serviceid = 9
    Department = 10
    Designation_Find = 11

    FinYear_Select = 12
    Office_Select = 13
    Desig_TargEntry_Find = 14
    Srno_Find = 15
    Month_Select = 16
    OfficeType_Select = 17

    Sector_Select = 18
    Relation_Find = 19

    Rationcard_ddl = 20

    Designation = 21
    MainPoint = 22
    Activity = 23
    Week = 24

    AttachDocument = 25
    AttachDocumentGroup = 26
    ServiceDescription = 27
    ServiceInstruction = 28
    AttachDocumentGroupOnservice = 29
End Enum
Public Class cDropDown
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
            Select Case CType(index, enmDropDown)

                Case enmDropDown.Service
                    objDataExecute.getDataSet(ds, "vService_Select", objColCriteria, "vService", Nothing)
                Case enmDropDown.ServiceGroup
                    objDataExecute.getDataSet(ds, "ServiceGroupName_Select", objColCriteria, "vService", Nothing)
                Case enmDropDown.ServiceFees
                    objDataExecute.getDataSet(ds, "vService_Find_Select", objColCriteria, "vService", Nothing)
                Case enmDropDown.DocumentAttachment
                    objDataExecute.getDataSet(ds, "vDocumentAttachment_Select", objColCriteria, "DocumentMaster", Nothing)
                Case enmDropDown.COM_M_RegBranch
                    objDataExecute.getDataSet(ds, "COM_M_RegBranch_Select", objColCriteria, "COM_M_RegBranch", Nothing)
                Case enmDropDown.COM_M_RegTable
                    objDataExecute.getDataSet(ds, "COM_M_RegTable_Select", objColCriteria, "COM_M_RegTable", Nothing)
                Case enmDropDown.COM_M_FinancialYr
                    objDataExecute.getDataSet(ds, "COM_M_FinancialYr_Select", objColCriteria, "COM_M_RegTable", Nothing)

                Case enmDropDown.Report
                    objDataExecute.getDataSet(ds, "Report_Select", objColCriteria, "Reports", Nothing)
                Case enmDropDown.Serviceid
                    objDataExecute.getDataSet(ds, "Service_Select", objColCriteria, "Services", Nothing)
                Case enmDropDown.Department
                    objDataExecute.getDataSet(ds, "Department_Select", objColCriteria, "Departments", Nothing)
                Case enmDropDown.Designation_Find
                    objDataExecute.getDataSet(ds, "Designation_Find", objColCriteria, "Designation", Nothing)

                Case enmDropDown.FinYear_Select
                    objDataExecute.getDataSet(ds, "FinYear_Select", objColCriteria, "FinYear", Nothing)
                Case enmDropDown.Office_Select
                    objDataExecute.getDataSet(ds, "Office_Select", objColCriteria, "Office", Nothing)
                Case enmDropDown.Desig_TargEntry_Find
                    objDataExecute.getDataSet(ds, "Desig_TargEntry_Find", objColCriteria, "Designation", Nothing)
                Case enmDropDown.Srno_Find
                    objDataExecute.getDataSet(ds, "Srno_Find", objColCriteria, "Srno", Nothing)
                Case enmDropDown.Month_Select
                    objDataExecute.getDataSet(ds, "COM_D_Lookup_Select", objColCriteria, "Lookup", Nothing)
                Case enmDropDown.OfficeType_Select
                    objDataExecute.getDataSet(ds, "OfficeType_Select", objColCriteria, "OfficeType", Nothing)

                Case enmDropDown.Sector_Select
                    objDataExecute.getDataSet(ds, "Sector_Select", objColCriteria, "Sector", Nothing)
                Case enmDropDown.Relation_Find
                    objDataExecute.getDataSet(ds, "COM_M_Relation_Find", objColCriteria, "Relation", Nothing)
                Case enmDropDown.Rationcard_ddl
                    objDataExecute.getDataSet(ds, "COM_Rationcard_ddl", objColCriteria, "Rationcard_ddl", Nothing)

                Case enmDropDown.Designation
                    objDataExecute.getDataSet(ds, "Designation_Select", objColCriteria, "Designation", Nothing)

                Case enmDropDown.MainPoint
                    objDataExecute.getDataSet(ds, "MainPoint_select", objColCriteria, "MainPoint", Nothing)
                Case enmDropDown.Activity
                    objDataExecute.getDataSet(ds, "MainPoint_select", objColCriteria, "MainPoint", Nothing)
                Case enmDropDown.Week
                    objDataExecute.getDataSet(ds, "MainPoint_select", objColCriteria, "MainPoint", Nothing)
                Case enmDropDown.AttachDocument
                    objDataExecute.getDataSet(ds, "Attach_Document_Select", objColCriteria, "AttachDocument", Nothing)
                Case enmDropDown.AttachDocumentGroup
                    objDataExecute.getDataSet(ds, "Attach_DocumentGroup_Select", objColCriteria, "AttachDocument", Nothing)
                Case enmDropDown.ServiceDescription
                    objDataExecute.getDataSet(ds, "vService_Description", objColCriteria, "ServiceDescription", Nothing)
                Case enmDropDown.ServiceInstruction
                    objDataExecute.getDataSet(ds, "vService_Instruction", objColCriteria, "ServiceInstruction", Nothing)
                Case enmDropDown.AttachDocumentGroupOnservice
                    objDataExecute.getDataSet(ds, "GetAttchmentGroupOnService", objColCriteria, "AttachDocument", Nothing)

            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
