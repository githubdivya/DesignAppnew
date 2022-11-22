Imports System.Math
Imports System.Globalization
Imports System.IO
Imports NICFrameWork.LibCommon
'Public Enum enmCheck
'    CCharName = 1
'    CCharAddress = 2
'    CString = 3
'    CStringLength = 4
'    CEmail = 5
'    CInteger = 6
'    CDecimal = 7
'    CRange = 8
'    CDateT = 9
'    CDDL = 10
'    CMinMax = 11
'    Aprovaltext = 12
'    CCharNameblank = 13
'    MobileNo = 14
'    cAadhaarNo = 15
'    CDOB = 16
'End Enum
'Public Enum enmSSORole
'    DistrictReport = 49
'    DepartmentReport = 50
'    StateReport = 51
'End Enum
Public Enum enmName
    VM1 = 1
    VM2 = 2
    VM3 = 3
    VM4 = 4

    VM6 = 6
    VM7 = 7

    VM9 = 9
    VM10 = 10
    VM11 = 11

    VM12 = 12

    VM13 = 13

    VM14 = 14

    VM15 = 15

    VM16 = 16

    VM17 = 17

    VM18 = 18

    VM19 = 19

End Enum




Public Class cGlobal
    Public Shared Function GETVMname(ByVal index As Int32) As String
        Dim result As String = "Not Found"
        Select Case CType(index, enmName)
            Case enmName.VM1 'blank 

                result = "DigitalGujarat-Narmada"

            Case enmName.VM2 'blank 

                result = "DigitalGujarat-Aji"

            Case enmName.VM3 'blank 

                result = "DigitalGujarat-Machchu"

            Case enmName.VM4 'blank 

                result = "DigitalGujarat-Rupen"

            Case enmName.VM6 'blank 

                result = "DigitalGujarat-Tapti"

            Case enmName.VM7 'blank 

                result = "DigitalGujarat-Mahi"

            Case enmName.VM9 'blank 

                result = "DigitalGujarat-Kankawati"

            Case enmName.VM10 'blank 

                result = "DigitalGujarat-Ghelo"

            Case enmName.VM11
                result = "DigitalGujarat-Alpha"

            Case enmName.VM12
                result = "DigitalGujarat-Beta"

            Case enmName.VM13
                result = "DigitalGujarat-Gamma"


            Case enmName.VM14
                result = "DigitalGujarat-Sigma"

            Case enmName.VM15
                result = "DigitalGujarat-Delta"

            Case enmName.VM16
                result = "DigitalGujarat-Theta"

            Case enmName.VM17
                result = "DigitalGujarat-Phi"

            Case enmName.VM18
                result = "DigitalGujarat-Yota"

            Case enmName.VM19
                result = "DigitalGujarat-Zeta"

        End Select
        Return result
    End Function
    'Public Shared Function CheckBadCharacters(ByVal value As Object) As Boolean

    '    Dim s As String = Convert.ToString(value).ToString
    '    Dim badchar() As String = {" select ", " drop ", " update ", " insert ", " grant ", " alter ", " revoke ", " union ", " truncate ", " delete ", "<", ">", ";", "xp_", "*", "#", "%", "^", "&", "|", "$", "'", "@", """", ":", "?", "(", ")", "+", "_", "!", "\", "\n", "\r", "[", "]", "{", "}"}
    '    For Each chr As String In badchar
    '        If s.ToLower().IndexOf(chr) <> -1 Then
    '            Return False
    '        End If
    '    Next
    '    Return True

    'End Function
    'Public Shared Function CheckBadCharactersForName(ByVal value As Object) As Boolean

    '    Dim s As String = Convert.ToString(value).ToString
    '    Dim badchar() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " select ", " drop ", " update ", " insert ", " grant ", " alter ", " revoke ", " union ", " truncate ", " delete ", "-", ".", "<", ">", ";", "xp_", "*", "#", "%", "^", "&", "|", "$", "'", "@", """", ":", "?", "(", ")", "+", ",", "_", "!", "\", "\n", "\r", "[", "]", "{", "}"}
    '    For Each chr As String In badchar
    '        If s.ToLower().IndexOf(chr) <> -1 Then
    '            Return False
    '        End If
    '    Next
    '    Return True

    'End Function

    'Public Shared Function CheckBadCharactersForAddress(ByVal value As Object) As Boolean

    '    Dim s As String = Convert.ToString(value).ToString
    '    Dim badchar() As String = {" select ", " drop ", " update ", " insert ", " grant ", " alter ", " revoke ", " union ", " truncate ", " delete ", "<", ">", ";", "xp_", "*", "#", "%", "^", "&", "|", "$", "'", "@", """", ":", "?", "(", ")", "+", "_", "!", "\n", "\r", "[", "]", "{", "}"}
    '    For Each chr As String In badchar
    '        If s.ToLower().IndexOf(chr) <> -1 Then
    '            Return False
    '        End If
    '    Next
    '    Return True

    'End Function

    'Public Shared Function CheckBadCharactersForAproval(ByVal value As Object) As Boolean

    '    Dim s As String = Convert.ToString(value).ToString
    '    Dim badchar() As String = {" select ", " drop ", " update ", " insert ", " grant ", " alter ", " revoke ", " union ", " truncate ", " delete ", "<", ">", ";", "xp_", "*", "#", "%", "^", "&", "|", "$", "'", "@", """", ":", "?", "+", "_", "!", "\n", "\r", "[", "]", "{", "}"}
    '    For Each chr As String In badchar
    '        If s.ToLower().IndexOf(chr) <> -1 Then
    '            Return False
    '        End If
    '    Next
    '    Return True

    'End Function
    'Public Shared Function CheckBadCharactersForEmail(ByVal value As Object) As Boolean

    '    Dim s As String = Convert.ToString(value).ToString
    '    Dim badchar() As String = {" select ", " drop ", " update ", " insert ", " grant ", " alter ", " revoke ", " union ", " truncate ", " delete ", "<", ">", ";", "xp_", "*", "#", "%", "^", "&", "|", "$", "'", """", ":", "?", "(", ")", "+", " ", "/", ",", "-", "!", "\n", "\r", "[", "]", "{", "}"}
    '    For Each chr As String In badchar
    '        If s.ToLower().IndexOf(chr) <> -1 Then
    '            Return False
    '        End If
    '    Next
    '    Return True

    'End Function
    'Public Shared Function checkAdharNo(ByVal strAdhar As String) As Boolean

    '    'Dim Verhoeff As New cVerhoeff
    '    Dim flag As Boolean = cVerhoeff.validateVerhoeff(strAdhar)
    '    Return flag
    'End Function
    'Public Shared Function IsValidValue(ByVal index As Integer, ByRef PG As System.Web.UI.Page, ByRef Obj As Object, ByVal Msg As String, Optional ByVal FrmValue As Integer = 0, Optional ByVal ToValue As Integer = 0) As Boolean
    '    Select Case CType(index, enmCheck)
    '        Case enmCheck.CCharNameblank 'blank 
    '            If Obj.Text.Trim = "" Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CCharName 'Alphanumeric check for Name
    '            If Obj.Text.Trim = "" Or CheckBadCharactersForName(Obj.Text.ToString) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CCharAddress 'String special characters check Address
    '            Msg = Msg & " સ્પેશિયલ અક્ષર લખવાની  નહીં   જેમ કે <%<>()&+-;!>,.-* વગેરે."
    '            If Obj.Text.Length > FrmValue Or CheckBadCharactersForAddress(Obj.Text.ToString) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CString 'String special characters check
    '            Msg = Msg & " સ્પેશિયલ અક્ષર લખવાની  નહીં   જેમ કે <%<>()&+-;!>,.-* વગેરે."
    '            If CheckBadCharactersForAddress(Obj.Text.ToString) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CStringLength 'String length check along with special characters
    '            Msg = Msg & " સ્પેશિયલ અક્ષર લખવાની  નહીં   જેમ કે <%<>()&+-;!>,.-* વગેરે."
    '            If Obj.Text.Length > FrmValue Or CheckBadCharactersForAddress(Obj.Text.ToString) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CEmail 'Email Special Charactrers
    '            If CheckBadCharactersForEmail(Obj.Text.ToString) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CInteger  'Integer check
    '            Dim Tmp As Integer
    '            If Integer.TryParse(Obj.Text.Trim, Tmp) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CDecimal 'Decimal check
    '            Dim Tmp As Double
    '            If Double.TryParse(Obj.Text.Trim, Tmp) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.cAadhaarNo
    '            'Decimal check
    '            Dim Tmp As Double
    '            If Double.TryParse(Obj.Text.Trim, Tmp) = False Or Obj.Text.Trim.ToString.Length <> 12 Or checkAdharNo(Obj.Text.Trim) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CRange 'Value range check
    '            Dim Tmp As Long
    '            If Long.TryParse(Obj.Text.Trim, Tmp) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '            If (Not (Val(Obj.Text.Trim) >= FrmValue And Val(Obj.Text.Trim) <= ToValue)) Or Obj.Text.Trim = "" Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CMinMax 'Numeric check with min and max length values
    '            Dim Tmp As Long
    '            If Long.TryParse(Obj.Text.Trim, Tmp) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '            If Not (Tmp.ToString().Length >= FrmValue And Tmp.ToString().Length <= ToValue) Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CDateT 'Date check
    '            Dim pattern As String = "dd/MM/yyyy"

    '            Dim parsedDate As Date
    '            If DateTime.TryParseExact(Obj.Text.Trim, pattern, Nothing, DateTimeStyles.None, parsedDate) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CDOB  'Date check
    '            Dim pattern As String = "dd/MM/yyyy"

    '            Dim parsedDate As Date
    '            If DateTime.TryParseExact(Obj.Text.Trim, pattern, Nothing, DateTimeStyles.None, parsedDate) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If

    '            If DateDiff(DateInterval.Day, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), Convert.ToDateTime(Obj.Text.ToString().Trim())) > 0 Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.CDDL  'Combobox  check
    '            If Obj.SelectedIndex = 0 Or Obj.Text.Trim = "" Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.Aprovaltext
    '            Msg = Msg & " સ્પેશિયલ અક્ષર લખવાની  નહીં   જેમ કે <%<>&+-;!>,.-* વગેરે."
    '            If CheckBadCharactersForAddress(Obj.Text.ToString) = False Then
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If
    '        Case enmCheck.MobileNo


    '            If IsNumeric(Obj.Text.Trim) = False Then

    '                Msg = Msg & " સ્પેશિયલ અક્ષર લખવાની  નહીં   જેમ કે <%<>&+-;!>,.-* વગેરે."
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            ElseIf Obj.Text.ToString.Length <> 10 Then
    '                Msg = Msg & "ફોન નંબર 10 અંકો હોવા જ જોઈએ."
    '                PG.ClientScript.RegisterStartupScript(GetType(String), "PopupScript", "<script>alert('" & Msg & "')</script>")
    '                Obj.Focus()
    '                IsValidValue = False
    '                Exit Function
    '            End If

    '    End Select
    '    IsValidValue = True
    'End Function
    'Public Shared Function hexstringToutf8(ByVal value As String) As String
    '    'hex to unicode
    '    Dim hexString As String = value.Trim
    '    Dim encoding As New System.Text.UTF8Encoding()
    '    Dim dBytes As Byte() = StringToByteArray(hexString)

    '    'To get the UTF8 value of the hex string
    '    Dim utf8result As String = System.Text.Encoding.UTF8.GetString(dBytes)
    '    Return utf8result
    'End Function
    'Public Shared Function StringToByteArray(hex As String) As Byte()
    '    Dim NumberChars As Integer = hex.Length / 2
    '    Dim bytes As Byte() = New Byte(NumberChars - 1) {}
    '    Using sr = New StringReader(hex)
    '        For i As Integer = 0 To NumberChars - 1
    '            bytes(i) = Convert.ToByte(New String(New Char(1) {CChar(ChrW(sr.Read())), CChar(ChrW(sr.Read()))}), 16)
    '        Next
    '    End Using
    '    Return bytes
    'End Function
    'Public Shared Function EmailValidation(ByVal value As Object) As Boolean
    '    'Dim mail as String = "YYY@imail.com";
    '    'Dim expression as String= @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +@"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +@"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"

    '    '   Match Match = Regex.Match(Mail, expression, RegexOptions.IgnoreCase)
    '    '   If (Match.Success) Then
    '    '           Response.Write("VALID EMAIL");
    '    '   Else
    '    '            Response.Write("INVALID EMAIL");
    '    '       return;

    '    Dim mail As [String] = value
    '    'Dim expression As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" + "0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" + "[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
    '    Dim expression As String = "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
    '            "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"

    '    Dim match As Match = Regex.Match(mail, expression, RegexOptions.IgnoreCase)
    '    If match.Success Then
    '        Return True
    '    Else
    '        Return False
    '    End If


    'End Function


    ''Public Shared Function GetVMName(ByVal N As Integer, ByRef StrWord As String)
    ''    StrWord = Net.Dns.GetHostName
    ''    Select Case (N)
    ''        Case 1
    ''            StrWord.Contains("VM-1").ErrorToString = "Narmada"
    ''        Case 2
    ''            StrWord = StrWord & " બે"
    ''        Case 3
    ''            StrWord = StrWord & " ત્રણ"
    ''        Case 4
    ''            StrWord = StrWord & " ચાર"
    ''        Case 5
    ''            StrWord = StrWord & " પાંચ"
    ''        Case 6
    ''            StrWord = StrWord & " છ"
    ''        Case 7
    ''            StrWord = StrWord & " સાત"
    ''        Case 8
    ''            StrWord = StrWord & " આંઠ"
    ''        Case 9
    ''            StrWord = StrWord & " નવ"
    ''        Case 10
    ''            StrWord = StrWord & " દસ"
    ''        Case 11
    ''            StrWord = StrWord & " અગિયાર"
    ''        Case 12
    ''            StrWord = StrWord & " બાર"
    ''        Case 13
    ''            StrWord = StrWord & " તેર"
    ''        Case 14
    ''            StrWord = StrWord & " ચૌદ"
    ''        Case 15
    ''            StrWord = StrWord & " પંદર"
    ''        Case 16
    ''            StrWord = StrWord & " સોળ"
    ''        Case 17
    ''            StrWord = StrWord & " સત્તર"
    ''        Case 18
    ''            StrWord = StrWord & " અઢાર"
    ''        Case 19
    ''            StrWord = StrWord & " ઓગણિસ"
    ''        Case 20
    ''            StrWord = StrWord & " વીસ"
    ''        Case 21
    ''            StrWord = StrWord & " ઍકવીસ"
    ''        Case 22
    ''            StrWord = StrWord & " બાવીસ"
    ''        Case 23
    ''            StrWord = StrWord & " તેવીસ"
    ''        Case 24
    ''            StrWord = StrWord & " ચૌવીસ"
    ''        Case 25
    ''            StrWord = StrWord & " પચ્ચીસ"
    ''        Case 26
    ''            StrWord = StrWord & " છવ્વીસ"
    ''        Case 27
    ''            StrWord = StrWord & " સત્તાવીસ"
    ''        Case 28
    ''            StrWord = StrWord & " અઠ્ઠાવીસ"
    ''        Case 29
    ''            StrWord = StrWord & " ઑગણત્રીસ"
    ''        Case 30
    ''            StrWord = StrWord & " ત્રીસ"
    ''        Case 31
    ''            StrWord = StrWord & " ઍકત્રીસ"
    ''        Case 32
    ''            StrWord = StrWord & " બત્રીસ"
    ''        Case 33
    ''            StrWord = StrWord & " તૅત્રીસ"
    ''        Case 34
    ''            StrWord = StrWord & " ચોત્રીસ"
    ''        Case 35
    ''            StrWord = StrWord & " પાંત્રીસ"
    ''        Case 36
    ''            StrWord = StrWord & " છત્રીસ"
    ''        Case 37
    ''            StrWord = StrWord & " સાડત્રીસ"
    ''        Case 38
    ''            StrWord = StrWord & " આડત્રીસ"
    ''        Case 39
    ''            StrWord = StrWord & " ઓગણચાલીસ"
    ''        Case 40
    ''            StrWord = StrWord & " ચાલીસ"
    ''        Case 41
    ''            StrWord = StrWord & " ઍકતાલીસ"
    ''        Case 42
    ''            StrWord = StrWord & " બૅતાલીસ"
    ''        Case 43
    ''            StrWord = StrWord & " તૅતાલીસ"
    ''        Case 44
    ''            StrWord = StrWord & " ચુમ્માંલીસ"
    ''        Case 45
    ''            StrWord = StrWord & " પિસ્તાલીસ"
    ''        Case 46
    ''            StrWord = StrWord & " છૅતાલીસ"
    ''        Case 47
    ''            StrWord = StrWord & " સુડતાલીસ"
    ''        Case 48
    ''            StrWord = StrWord & " અડતાલીસ"
    ''        Case 49
    ''            StrWord = StrWord & " ઑગનપચાંસ"
    ''        Case 50
    ''            StrWord = StrWord & " પચાંસ"
    ''        Case 51
    ''            StrWord = StrWord & " ઍંકાવન"
    ''        Case 52
    ''            StrWord = StrWord & " બાવન"
    ''        Case 53
    ''            StrWord = StrWord & " ત્રૅપન"
    ''        Case 54
    ''            StrWord = StrWord & " ચૌપન"
    ''        Case 55
    ''            StrWord = StrWord & " પંચાવન"
    ''        Case 56
    ''            StrWord = StrWord & " છપ્પન"
    ''        Case 57
    ''            StrWord = StrWord & " સત્તાવન"
    ''        Case 58
    ''            StrWord = StrWord & " અઠ્ઠાવન"
    ''        Case 59
    ''            StrWord = StrWord & " ઓગણસાઈઠ"
    ''        Case 60
    ''            StrWord = StrWord & " સાઈઠ"
    ''        Case 61
    ''            StrWord = StrWord & " ઍકસાંઠ"
    ''        Case 62
    ''            StrWord = StrWord & " બાસાંઠ"
    ''        Case 63
    ''            StrWord = StrWord & " ત્રૅસાંઠ"
    ''        Case 64
    ''            StrWord = StrWord & " ચોસાંઠ"
    ''        Case 65
    ''            StrWord = StrWord & " પાસાંઠ"
    ''        Case 66
    ''            StrWord = StrWord & " છાસાંઠ"
    ''        Case 67
    ''            StrWord = StrWord & " સડસાંઠ"
    ''        Case 68
    ''            StrWord = StrWord & " અડસાંઠ"
    ''        Case 69
    ''            StrWord = StrWord & " ઑગનસીંત્તૅર"
    ''        Case 70
    ''            StrWord = StrWord & " સીંત્તૅર"
    ''        Case 71
    ''            StrWord = StrWord & " ઍકોત્તૅર"
    ''        Case 72
    ''            StrWord = StrWord & " બોત્તૅર"
    ''        Case 73
    ''            StrWord = StrWord & " તોત્તૅર"
    ''        Case 74
    ''            StrWord = StrWord & " ચુમ્મોત્તૅર"
    ''        Case 75
    ''            StrWord = StrWord & " પંચોત્તૅર"
    ''        Case 76
    ''            StrWord = StrWord & " છોત્તૅર"
    ''        Case 77
    ''            StrWord = StrWord & " સત્તયોત્તૅર"
    ''        Case 78
    ''            StrWord = StrWord & " અઠીયોત્તૅર"
    ''        Case 79
    ''            StrWord = StrWord & " અગણ્યાએશી"
    ''        Case 80
    ''            StrWord = StrWord & " ઍંશી"
    ''        Case 81
    ''            StrWord = StrWord & " ઍકાશી"
    ''        Case 82
    ''            StrWord = StrWord & " બ્યાશી"
    ''        Case 83
    ''            StrWord = StrWord & " ત્યાશી"
    ''        Case 84
    ''            StrWord = StrWord & " ચોર્યાશી"
    ''        Case 85
    ''            StrWord = StrWord & " પંચાશી"
    ''        Case 86
    ''            StrWord = StrWord & " છ્યાશી"
    ''        Case 87
    ''            StrWord = StrWord & " સત્યાશી"
    ''        Case 88
    ''            StrWord = StrWord & " અઠ્યાશી"
    ''        Case 89
    ''            StrWord = StrWord & " નવ્યાશી"
    ''        Case 90
    ''            StrWord = StrWord & " નૅવું"
    ''        Case 91
    ''            StrWord = StrWord & " ઍકાણું"
    ''        Case 92
    ''            StrWord = StrWord & " બાણું"
    ''        Case 93
    ''            StrWord = StrWord & " ત્રાણું"
    ''        Case 94
    ''            StrWord = StrWord & " ચોરાણું"
    ''        Case 95
    ''            StrWord = StrWord & " પંચાણું"
    ''        Case 96
    ''            StrWord = StrWord & " છન્નું"
    ''        Case 97
    ''            StrWord = StrWord & " સત્તાણું"
    ''        Case 98
    ''            StrWord = StrWord & " અઠ્ઠાણું"
    ''        Case 99
    ''            StrWord = StrWord & " નવ્વાણું"
    ''    End Select
    ''End Function




End Class

