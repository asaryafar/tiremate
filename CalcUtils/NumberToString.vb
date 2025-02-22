Public Class NumberToString

#Region "Field"

    Private Shared Yekan As String() = {"’›—", "Ìò", "œÊ", "”Â", "çÂ«—", "Å‰Ã", "‘‘", "Â› ", "Â‘ ", "‰Â", "œÂ", "Ì«“œÂ", "œÊ«“œÂ", "”Ì“œÂ", "çÂ«—œÂ", "Å«‰“œÂ", "‘«‰“œÂ", "Â›œÂ", "ÂÃœÂ", "‰Ê“œÂ"}
    Private Shared Dahgan As String() = {"", "œÂ", "»Ì” ", "”Ì", "çÂ·", "Å‰Ã«Â", "‘’ ", "Â› «œ", "Â‘ «œ", "‰Êœ", ""}
    Private Shared Sadgan As String() = {"", "’œ", "œÊÌ” ", "”Ì’œ", "çÂ«—’œ", "Å«‰’œ", "‘‘’œ", "Â› ’œ", "Â‘ ’œ", "‰Â’œ"}
    Private Shared Hezar As String() = {"", " Â“«—", " „Ì·ÌÊ‰", " „Ì·Ì«—œ", "  —Ì·ÌÊ‰", "  —Ì·Ì«—œ"}
    Private Const va As String = " Ê "

#End Region

#Region "Shared Methods"

    Public Shared Function N2S(ByVal lDigit As Long, Optional ByVal Currency As Boolean = False) As Object
        If Currency Then
            Return DtoS(lDigit) & " —Ì«·"
        End If
        Return DtoS(lDigit)
    End Function

    Private Shared Function DtoS(ByVal lDigit As Long) As String
        If (lDigit < 20) Then
            Return Yekan(lDigit)
        End If
        Dim TempArray As String() = New String(6) {}
        Dim AlphaDigit As String = ""
        Dim strDigit As String = lDigit.ToString
        Do While ((strDigit.Length Mod 3) <> 0)
            strDigit = "0" & strDigit
        Loop
        Dim LenNum As Short = CType(strDigit.Length, Short)
        Dim num1 As Short = 3
        Do While (num1 <= LenNum)
            TempArray(num1 / 3 - 1) = strDigit.Substring((strDigit.Length - num1), 3)
            num1 = CType((num1 + 3), Short)
        Loop
        num1 = 6
        Do While True
            If (Val(TempArray(num1)) <> 0) Then
                Dim strTemp As String = ""
                Dim Sad As Byte = CType(Val(TempArray(num1).Substring(2, 1)), Byte)
                Dim Dah As Byte = CType(Val(TempArray(num1).Substring(1, 1)), Byte)
                Dim Yek As Byte = CType(Val(TempArray(num1).Substring(0, 1)), Byte)
                If Yek > 0 And (Dah > 0 Or Sad > 0) Then
                    strTemp = strTemp & Sadgan(Yek) & va
                Else
                    strTemp = (strTemp & Sadgan(Yek))
                End If
                If Dah = 1 And Sad > 0 Then
                    strTemp = strTemp & Yekan(((Dah * 10) + Sad))
                End If
                If Dah > 1 And Sad > 0 Then
                    strTemp = (strTemp & Dahgan(Dah) & va & Yekan(Sad))
                End If
                If (Dah >= 1) And (Sad = 0) Then
                    strTemp = (strTemp & Dahgan(Dah))
                End If
                If (Dah = 0) And (Sad > 0) Then
                    strTemp = (strTemp & Yekan(Sad))
                End If
                AlphaDigit = AlphaDigit & strTemp & Hezar(num1)
                If (num1 > 0) Then
                    AlphaDigit = AlphaDigit & va
                End If
            End If
            num1 = CType((num1 - 1), Short)
            If (num1 < 0) Then
                Return AlphaDigit
            End If
        Loop
    End Function

#End Region

End Class

