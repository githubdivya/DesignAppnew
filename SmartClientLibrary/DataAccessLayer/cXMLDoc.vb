'**************************************************************************************************************************
'* Library ID 		: LIBFWPL008
'* Name                     Date            Description
'* ---------------	        -----------     ---------------
'* Harshad Prajapati         05-Jul-2006    Read Information From XML File
'**************************************************************************************************************************
Imports System.Configuration
<Serializable()> Public Class cXMLDoc
    Public Shared Function getDSN(ByVal objXMLDoc As System.Xml.XmlDocument, Optional ByVal strTagName As String = "ConnectionString") As String
        Try
            Return readElementByTagname(objXMLDoc, strTagName)
        Catch exc As Exception
            Throw exc
        End Try
    End Function
    Public Shared Function readElementByTagname(ByVal objXMLDoc As System.Xml.XmlDocument, ByVal strTagName As String) As String
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLNode As Xml.XmlNode

        Try
            objXMLNodeList = objXMLDoc.GetElementsByTagName(strTagName)

            If (objXMLNodeList Is Nothing) Then
                Return ""
            End If

            objXMLNode = objXMLNodeList.Item(0)

            If ((Not objXMLNode.InnerText Is Nothing) AndAlso (objXMLNode.InnerText <> "")) Then
                Return objXMLNode.InnerText
            Else
                Return ""
            End If
        Catch exc As Exception
            Throw exc
        End Try
    End Function

    Public Shared Function getXMLFileObject() As System.Xml.XmlDocument
        Dim strAppSettingsFileName As String
        Try
            Dim objXMLDoc As System.Xml.XmlDocument
            strAppSettingsFileName = My.Application.Info.DirectoryPath & "\Data\configuration.xml"
            objXMLDoc = New System.Xml.XmlDocument
            If (strAppSettingsFileName <> "") Then
                Try
                    objXMLDoc.Load(strAppSettingsFileName)
                Catch ex As Exception
                    Throw ex
                End Try
            End If
            Return objXMLDoc
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
