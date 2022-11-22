Imports System.Data
Imports System.Data.SqlClient
Imports NICFrameWork.LibCommon

Partial Class Admin_ViewForm
    Inherits SchemeGeneral
    Public Scode, buttonmode, FormId1, type As Integer
    Dim obj As New FormData
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Scode = Session("Scode")
        type = Session("Type")
        FormId1 = Session("FormId1")
        readfile()
    End Sub
    Public Sub readfile()
        Dim row As Data.DataRow = Nothing
        Dim row1 As Data.DataRow = Nothing
        If Not Session("Scode") Is Nothing Then

            Scode = Session("Scode")
            type = Session("Type")
            row = obj.LoadForm(Scode)

            'Edited By Bhoomi
            If Not row Is Nothing And type = 3 Then
                Dim bytImage1 As Byte()
                If IsDBNull(row.Item("Service_Details")) Then
                    bytImage1 = Nothing
                Else
                    bytImage1 = CType(row.Item("Service_Details"), Byte())
                    ReplacewithOldValue()
                    If Not bytImage1 Is Nothing Then
                        With HttpContext.Current.Response
                            .ContentType = "application/pdf"
                            .AddHeader("Content-Disposition", "inline; filename=Report.pdf")
                            .BinaryWrite(bytImage1)
                            .End()
                        End With
                    End If
                End If
            End If


            If Not row Is Nothing And type = 1 Then
                Dim bytImage As Byte()
                If IsDBNull(row.Item("Form")) Then
                    bytImage = Nothing
                Else
                    bytImage = CType(row.Item("Form"), Byte())
                End If
                ReplacewithOldValue()
                If Not bytImage Is Nothing Then
                    With HttpContext.Current.Response
                        .ContentType = "application/pdf"
                        .AddHeader("Content-Disposition", "inline; filename=Report.pdf")
                        .BinaryWrite(bytImage)
                        .End()
                    End With
                End If
            End If

            If Not row Is Nothing And type = 2 Then
                Dim bytImage1 As Byte()
                If IsDBNull(row.Item("Form_eng")) Then
                    bytImage1 = Nothing
                Else
                    bytImage1 = CType(row.Item("Form_eng"), Byte())
                    ReplacewithOldValue()
                    If Not bytImage1 Is Nothing Then
                        With HttpContext.Current.Response
                            .ContentType = "application/pdf"
                            .AddHeader("Content-Disposition", "inline; filename=Report.pdf")
                            .BinaryWrite(bytImage1)
                            .End()
                        End With
                    End If
                End If
            End If
        Else

            ' type = Request.QueryString("Type")
            row1 = obj.LoadForm_data(FormId1)
            If Not row1 Is Nothing And type = 2 Then
                Dim bytImage1 As Byte()
                If IsDBNull(row1.Item("Form_eng")) Then
                    bytImage1 = Nothing
                Else
                    bytImage1 = CType(row1.Item("Form_eng"), Byte())
                    ReplacewithOldValue()
                    If Not bytImage1 Is Nothing Then
                        With HttpContext.Current.Response
                            .ContentType = "application/pdf"
                            .AddHeader("Content-Disposition", "inline; filename=Report.pdf")
                            .BinaryWrite(bytImage1)
                            .End()
                        End With
                    End If
                End If
            End If
        End If
    End Sub
End Class
