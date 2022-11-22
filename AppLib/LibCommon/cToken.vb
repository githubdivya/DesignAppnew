Public Class cToken
    Public Function Tokencheck(ByVal TokenID As String, ByVal Salt As String) As Boolean
        Dim passPhrase As String = "atvt" & Salt       ' can be any string
        Dim initVector As String = "#1B2c3D4e5F6g7H8" ' must be 16 bytes
        Dim rijndaelKey As New RijndaelEnhanced(passPhrase, initVector)
        Dim plainText As String = rijndaelKey.Decrypt(TokenID)
        If plainText = "ATVT#GRCC" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function newToken(ByVal Salt As String) As String
        Dim passPhrase As String = "atvt" & Salt       ' can be any string
        Dim initVector As String = "#1B2c3D4e5F6g7H8" ' must be 16 bytes
        Dim rijndaelKey As New RijndaelEnhanced(passPhrase, initVector)
        Return rijndaelKey.Encrypt("ATVT#GRCC")
    End Function
End Class
