Imports System.Data.Common
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon
Imports NICFrameWork.DataAccessLayer
Public Enum enmcMap
    get_lat_lng = 1
    VisiterCounter = 2
    VersionShow = 3
    District = 4
    Taluka = 5
    Office_Details_show = 6
End Enum
Public Class cMap
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
            Select Case CType(index, enmcMap)

                Case enmcMap.get_lat_lng
                    objDataExecute.getDataSet(ds, "Get_Taluka_List_Lat_lqn", objColCriteria, "City", Nothing)
                Case enmcMap.VisiterCounter
                    objDataExecuteM.getDataSet(ds, "Updatecounter", objColCriteria, "VisiterCounter", enumDBGroup.CommonDBSimpleMode)
                Case enmcMap.VersionShow
                    objDataExecuteM.getDataSet(ds, "Last_UpdatedWebsite_Version", objColCriteria, "VersionShow", enumDBGroup.CommonDBSimpleMode)

                Case enmcMap.District
                    objDataExecute.getDataSet(ds, "COM_M_District_Select", objColCriteria, "District", Nothing)

                Case enmcMap.Taluka
                    objDataExecute.getDataSet(ds, "COM_M_Taluka_Select", objColCriteria, "Taluka", Nothing)

                Case enmcMap.Office_Details_show
                    objDataExecute.getDataSet(ds, "Office_Details_show", objColCriteria, "Office_Details_show", Nothing)

            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
