Public Class ClsNumberOperation
    Public Function ConvertToNumericString(ByVal dblBum As Decimal) As String
        Dim strNum As String
        Dim bytlen As Byte
        Dim strFarsi(9, 4) As String
        Dim bytCounter As Byte
        Dim strOutput As String
        Dim bytCountNum As Byte
        Dim bytThFlag As Byte
        Dim bytMiFlag As Byte
        Dim bytBiFlag As Byte
        Dim dblValF As Double
        'strNum = Trim(Str(Abs(Round(dblBum.))))
        strNum = Trim(dblBum)
        bytlen = Len(strNum)
        If bytlen > 18 Then
            ConvertToNumericString = "xxx"
        End If

        strFarsi(1, 1) = "Ìﬂ"
        strFarsi(2, 1) = "œÊ"
        strFarsi(3, 1) = "”Â"
        strFarsi(4, 1) = "çÂ«—"
        strFarsi(5, 1) = "Å‰Ã"
        strFarsi(6, 1) = "‘‘"
        strFarsi(7, 1) = "Â› "
        strFarsi(8, 1) = "Â‘ "
        strFarsi(9, 1) = "‰Â"
        strFarsi(1, 2) = "œÂ"
        strFarsi(2, 2) = "»Ì” "
        strFarsi(3, 2) = "”Ì"
        strFarsi(4, 2) = "çÂ·"
        strFarsi(5, 2) = "Å‰Ã«Â"
        strFarsi(6, 2) = "‘’ "
        strFarsi(7, 2) = "Â› «œ"
        strFarsi(8, 2) = "Â‘ «œ"
        strFarsi(9, 2) = "‰Êœ"
        strFarsi(1, 3) = "Ìﬂ’œ"
        strFarsi(2, 3) = "œÊÌ” "
        strFarsi(3, 3) = "”Ì’œ"
        strFarsi(4, 3) = "çÂ«—’œ"
        strFarsi(5, 3) = "Å«‰’œ"
        strFarsi(6, 3) = "‘‘’œ"
        strFarsi(7, 3) = "Â› ’œ"
        strFarsi(8, 3) = "Â‘ ’œ"
        strFarsi(9, 3) = "‰Â’œ"
        strFarsi(1, 4) = "Ì«“œÂ"
        strFarsi(2, 4) = "œÊ«“œÂ"
        strFarsi(3, 4) = "”Ì“œÂ"
        strFarsi(4, 4) = "ÃÂ«—œÂ"
        strFarsi(5, 4) = "Å«‰“œÂ"
        strFarsi(6, 4) = "‘«‰“œÂ"
        strFarsi(7, 4) = "Â›œÂ"
        strFarsi(8, 4) = "ÂÃœÂ"
        strFarsi(9, 4) = "‰Ê“œÂ"
        bytCounter = 1
        strOutput = ""
        bytThFlag = 0
        bytMiFlag = 0
        bytBiFlag = 0
        Do While bytCounter <= bytlen
            dblValF = Val(Mid(strNum, bytlen - bytCounter + 1, 1))
            strOutput = IIf(bytCounter = 4, " Â“«—", "") + strOutput
            strOutput = IIf(bytCounter = 7, " „Ì·ÌÊ‰", "") + strOutput
            strOutput = IIf(bytCounter = 10, " „Ì·Ì«—œ", "") + strOutput
            strOutput = IIf(bytCounter = 13, "  —Ì·ÌÊ‰", "") + strOutput
            If bytCounter = 4 Or bytCounter = 5 Or bytCounter = 6 Then
                bytThFlag = dblValF + bytThFlag
                If Mid(Right(strNum, 5), 1, 1) = 1 Then bytThFlag = 1
            End If
            If bytThFlag = 0 And bytCounter = 7 Then
                strOutput = Left(strOutput, InStr(strOutput, "Â“«—") - 2) + Right(strOutput, Len(strOutput) - InStr(strOutput, "Â“«—") - 3)
            End If
            If bytCounter = 7 Or bytCounter = 8 Or bytCounter = 9 Then
                bytMiFlag = dblValF + bytMiFlag
            End If
            If bytMiFlag = 0 And bytCounter = 10 Then
                strOutput = Left(strOutput, InStr(strOutput, "„Ì·ÌÊ‰") - 2) + Right(strOutput, Len(strOutput) - InStr(strOutput, "„Ì·ÌÊ‰") - 5)
            End If
            If bytCounter = 10 Or bytCounter = 11 Or bytCounter = 12 Then
                bytBiFlag = dblValF + bytBiFlag
            End If
            If bytBiFlag = 0 And bytCounter = 13 Then
                strOutput = Left(strOutput, InStr(strOutput, "„Ì·Ì«—œ") - 2) + Right(strOutput, Len(strOutput) - InStr(strOutput, "„Ì·Ì«—œ") - 6)
            End If
            bytCountNum = IIf(bytCounter Mod 3 = 0, 3, bytCounter Mod 3)
            If bytCounter < bytlen And bytCountNum = 1 Then

                If Val(Mid(strNum, bytlen - bytCounter, 1)) = 1 Then
                    If dblValF <> 0 Then
                        strOutput = strFarsi(dblValF, 4) + strOutput
                    Else
                        strOutput = IIf(bytCounter + 1 < bytlen, " Ê œÂ", "œÂ") + strOutput
                    End If
                    bytCounter = bytCounter + 1
                Else
                    If dblValF <> 0 Then
                        strOutput = strFarsi(dblValF, bytCountNum) + strOutput
                    End If
                End If
            Else
                If dblValF <> 0 Then
                    strOutput = strFarsi(dblValF, bytCountNum) + strOutput
                End If
            End If
            If bytCounter < bytlen And dblValF <> 0 Then
                strOutput = " Ê " + strOutput
            End If
            bytCounter = bytCounter + 1
        Loop
        ConvertToNumericString = strOutput
    End Function
    Public Function RemoveKama(ByVal text1 As String) As String
        Dim str() As String
        Dim i As Integer
        str = text1.Split(",")
        '_Number = Join(str, "")
        'RemoveKama = _Number
        RemoveKama = Join(str, "")
    End Function



    Public Function SeparatorNumber(ByVal ThisText As String) As String
        Dim tmpLen As Integer
        Dim i As Integer
        Dim DotPosition As Integer
        Dim NumberValueDisplay As String
        DotPosition = InStr(ThisText, ".")
        If DotPosition > 0 Then
            NumberValueDisplay = ThisText.Substring(0, DotPosition - 1)
        Else
            NumberValueDisplay = ThisText
        End If
        If ThisText.Length > 3 Then
            tmpLen = NumberValueDisplay.Length
            While tmpLen > 3
                tmpLen = tmpLen - 3
                NumberValueDisplay = NumberValueDisplay.Insert(tmpLen, ",")
                i = i + 1
            End While
        End If
        DotPosition = InStr(ThisText, ".")
        If DotPosition > 0 Then
            SeparatorNumber = NumberValueDisplay + ThisText.Substring(DotPosition - 1)
        Else
            SeparatorNumber = NumberValueDisplay
        End If
    End Function
End Class
