Module Module1
    'Option Explicit
    '*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
    '*    Numbers to Money Words Conversion.
    '*    Modified by Robert M. Watson  Aug, 2002
    '*----------------------------------------------------------------------------
    '*    To use in an existing project:
    '*      - Create a text box, txtInput, and a label called lblDispString.
    '*      - Add the two Const variables, Const GcstrDollar and Const GcstrDollars
    '*      to your declarations.
    '*      - Add the function NumToString_Dollar to your procedural code.
    '*      - Ignore the cmdEnd_Click sub
    '*      - Perform the same work that appears in the cmdCalc_Click sub.
    '*    To use as written:
    '*      - Make a form with a text box, txtInput; a label called lblDispString;
    '*      a button called cmdCalc; and another button called cmdEnd.
    '*      - Paste ALL of this code into the form.
    '*----------------------------------------------------------------------------
    '*      The main workings of this code were sent to the IT Toolbox forum
    '*      for Visual Basic back in 2001, by a very helpful Indonesian fellow.
    '*      Unfortunately, I do not remember his name, or I would gladly give
    '*      him credit for his contribution!
    '*      I modified the code slightly to write correct business English,
    '*      depending on the amount.  I also allowed for negative amounts to be
    '*      converted to a positive number before conversion. My code is marked
    '*      so that the reader will know that most of the credit for this code
    '*      goes to the Unknown Indonesian.  May he never have an abend or a
    '*      Blue Screen of Death!
    '*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
    Const GcstrDollar As String = "Dollar and "         '* RW mod
    Const GcstrDollars As String = "Dollars and "       '* RW mod
    Function NumToString_Dollar(ByVal valStr As String) As String

        Static Ones(9) As String, Teens(9) As String
        Static Tens(9) As String, Thousands(4) As String
        Dim buff As String, tmpBuff As String, tmpStr As String
        Dim tmpVar As Double, Col As Integer, aDigit As Integer
        Dim I As Integer, allZeros As Integer
        Dim strCurrency As String



        Ones(0) = "zero"
        Ones(1) = "one"
        Ones(2) = "two"
        Ones(3) = "three"
        Ones(4) = "four"
        Ones(5) = "five"
        Ones(6) = "six"
        Ones(7) = "seven"
        Ones(8) = "eight"
        Ones(9) = "nine"

        Teens(0) = "ten"
        Teens(1) = "eleven"
        Teens(2) = "twelve"
        Teens(3) = "thirteen"
        Teens(4) = "fourteen"
        Teens(5) = "fifteen"
        Teens(6) = "sixteen"
        Teens(7) = "seventeen"
        Teens(8) = "eighteen"
        Teens(9) = "nineteen"

        Tens(0) = ""
        Tens(1) = "ten"
        Tens(2) = "twenty"
        Tens(3) = "thirty"
        Tens(4) = "fourty"
        Tens(5) = "fifty"
        Tens(6) = "sixty"
        Tens(7) = "seventy"
        Tens(8) = "eighty"
        Tens(9) = "ninety"

        Thousands(0) = ""
        Thousands(1) = "thousand"
        Thousands(2) = "million"
        Thousands(3) = "billion"
        Thousands(4) = "trillion"


        On Error GoTo NumToStringError

        tmpVar = CDbl(valStr)

        '*-->  RW's modifications
        If tmpVar < 0 Then
            tmpVar = tmpVar * -1    '*-- Change from negative to positive
        End If

        Select Case tmpVar
            Case Is < 1
                strCurrency = GcstrDollars     '*-- Pennies   0.87 : literal should read "Zero Dollars and 87/100"
            Case Is < 2
                strCurrency = GcstrDollar      '*-- Single dollar 1.05: literal should be singular. "One Dollar and 05/100"
            Case Else
                strCurrency = GcstrDollars     '*-- Two or more dollars  2.10: literal is plural "Two Dollars and..."
        End Select
        '*--< End RW's mods

        buff = strCurrency & Format((tmpVar - Int(tmpVar)) * 100, "00") & "/100"

        '--- change to string type
        tmpStr = CStr(Int(tmpVar))

        For I = Len(tmpStr) To 1 Step -1
            aDigit = Val(Mid$(tmpStr, I, 1))
            Col = (Len(tmpStr) - I) + 1

            Select Case (Col Mod 3)
                Case 1
                    allZeros = False
                    If I = 1 Then
                        tmpBuff = Ones(aDigit) & " "
                    ElseIf Mid$(tmpStr, I - 1, 1) = "1" Then
                        tmpBuff = Teens(aDigit) & " "
                        I = I - 1
                    ElseIf aDigit > 0 Then
                        tmpBuff = Ones(aDigit) & " "
                    Else
                        allZeros = True
                        If I > 1 Then
                            If Mid$(tmpStr, I - 1, 1) <> "0" Then
                                allZeros = False
                            End If
                        End If
                        If I > 2 Then
                            If Mid$(tmpStr, I - 2, 1) <> "0" Then
                                allZeros = False
                            End If
                        End If
                        tmpBuff = ""
                    End If
                    If allZeros = False And Col > 1 Then
                        tmpBuff = tmpBuff & Thousands(Col / 3) & " "
                    End If
                    buff = tmpBuff & buff
                Case 2
                    If aDigit > 0 Then
                        buff = Tens(aDigit) & " " & buff
                    End If
                Case 0
                    If aDigit > 0 Then
                        buff = Ones(aDigit) & " hundred " & buff
                    End If
            End Select
        Next I

        If Len(buff) > 0 Then buff = UCase$(Left$(buff, 1)) & Mid$(buff, 2)

EndNumToString:
        NumToString_Dollar = StrConv(buff, vbProperCase)
        Exit Function
NumToStringError:
        buff = "<<Error>>"
        Resume EndNumToString

    End Function

    'Private Sub cmdCalc_Click()
    '    Dim strInput$

    '    strInput = Trim(txtInput.Text)
    '    lblDispString = NumToString_Dollar(strInput)
    'End Sub

    'Private Sub cmdEnd_Click()
    '    End
    'End Sub


End Module
