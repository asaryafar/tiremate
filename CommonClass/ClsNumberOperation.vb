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

        strFarsi(1, 1) = "��"
        strFarsi(2, 1) = "��"
        strFarsi(3, 1) = "��"
        strFarsi(4, 1) = "����"
        strFarsi(5, 1) = "���"
        strFarsi(6, 1) = "��"
        strFarsi(7, 1) = "���"
        strFarsi(8, 1) = "���"
        strFarsi(9, 1) = "��"
        strFarsi(1, 2) = "��"
        strFarsi(2, 2) = "����"
        strFarsi(3, 2) = "��"
        strFarsi(4, 2) = "���"
        strFarsi(5, 2) = "�����"
        strFarsi(6, 2) = "���"
        strFarsi(7, 2) = "�����"
        strFarsi(8, 2) = "�����"
        strFarsi(9, 2) = "���"
        strFarsi(1, 3) = "����"
        strFarsi(2, 3) = "�����"
        strFarsi(3, 3) = "����"
        strFarsi(4, 3) = "������"
        strFarsi(5, 3) = "�����"
        strFarsi(6, 3) = "����"
        strFarsi(7, 3) = "�����"
        strFarsi(8, 3) = "�����"
        strFarsi(9, 3) = "����"
        strFarsi(1, 4) = "�����"
        strFarsi(2, 4) = "������"
        strFarsi(3, 4) = "�����"
        strFarsi(4, 4) = "������"
        strFarsi(5, 4) = "������"
        strFarsi(6, 4) = "������"
        strFarsi(7, 4) = "����"
        strFarsi(8, 4) = "����"
        strFarsi(9, 4) = "�����"
        bytCounter = 1
        strOutput = ""
        bytThFlag = 0
        bytMiFlag = 0
        bytBiFlag = 0
        Do While bytCounter <= bytlen
            dblValF = Val(Mid(strNum, bytlen - bytCounter + 1, 1))
            strOutput = IIf(bytCounter = 4, " ����", "") + strOutput
            strOutput = IIf(bytCounter = 7, " ������", "") + strOutput
            strOutput = IIf(bytCounter = 10, " �������", "") + strOutput
            strOutput = IIf(bytCounter = 13, " �������", "") + strOutput
            If bytCounter = 4 Or bytCounter = 5 Or bytCounter = 6 Then
                bytThFlag = dblValF + bytThFlag
                If Mid(Right(strNum, 5), 1, 1) = 1 Then bytThFlag = 1
            End If
            If bytThFlag = 0 And bytCounter = 7 Then
                strOutput = Left(strOutput, InStr(strOutput, "����") - 2) + Right(strOutput, Len(strOutput) - InStr(strOutput, "����") - 3)
            End If
            If bytCounter = 7 Or bytCounter = 8 Or bytCounter = 9 Then
                bytMiFlag = dblValF + bytMiFlag
            End If
            If bytMiFlag = 0 And bytCounter = 10 Then
                strOutput = Left(strOutput, InStr(strOutput, "������") - 2) + Right(strOutput, Len(strOutput) - InStr(strOutput, "������") - 5)
            End If
            If bytCounter = 10 Or bytCounter = 11 Or bytCounter = 12 Then
                bytBiFlag = dblValF + bytBiFlag
            End If
            If bytBiFlag = 0 And bytCounter = 13 Then
                strOutput = Left(strOutput, InStr(strOutput, "�������") - 2) + Right(strOutput, Len(strOutput) - InStr(strOutput, "�������") - 6)
            End If
            bytCountNum = IIf(bytCounter Mod 3 = 0, 3, bytCounter Mod 3)
            If bytCounter < bytlen And bytCountNum = 1 Then

                If Val(Mid(strNum, bytlen - bytCounter, 1)) = 1 Then
                    If dblValF <> 0 Then
                        strOutput = strFarsi(dblValF, 4) + strOutput
                    Else
                        strOutput = IIf(bytCounter + 1 < bytlen, " � ��", "��") + strOutput
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
                strOutput = " � " + strOutput
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
