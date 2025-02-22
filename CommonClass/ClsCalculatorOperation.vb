Public Class ClsCalculatorOperation
    Public Function MToSh(ByVal datDate As Date) As String
        'Tanks of barzi
        Dim intYear As Integer
        Dim intDay As Integer
        Dim bytMonth As Byte
        Dim strMLen As String
        Dim intDays As Integer
        Dim bytEbteda As Byte
        Dim intYy As Integer
        Dim bytMm As Byte
        Dim intDd As Integer
        Dim strRooz As String
        Dim strMah As String
        Dim strSal As String
        Dim bytMonthTemp As Byte

        intYear = Year(datDate)
        bytMonth = Month(datDate)
        intDay = Day(datDate)

        If (intYear - 96) Mod 4 <> 0 Then
            strMLen = "312831303130313130313031"
        Else
            strMLen = "312931303130313130313031"
        End If
        If bytMonth < 4 Then
            'If (bytMonth = 3 And intDay > 20 And intYear < 1996) Or (intYear >= 1996 And (intYear - 97) Mod 4 < 3 And intDay > 20 And bytMonth = 3) Or (intYear < 1996 And (intYear - 97) Mod 4 > 0 And intDay >= 20 And bytMonth = 3) Then
            If (intYear >= 1996 And bytMonth = 3 And intYear Mod 4 = 0 And intDay <= 19) Or _
                (intYear >= 1996 And bytMonth < 3 And intYear Mod 4 = 0) Or _
                (intYear >= 1996 And bytMonth = 3 And intYear Mod 4 <> 0 And intDay <= 20) Or _
                (intYear >= 1996 And bytMonth < 3 And intYear Mod 4 <> 0) Or _
                (intYear < 1996 And bytMonth = 3 And intDay <= 20) Or _
                (intYear < 1996 And bytMonth < 3) Then
                intYy = intYear - 622
            Else
                intYy = intYear - 621
            End If
        Else
            intYy = intYear - 621
        End If
        intDays = intDay
        bytEbteda = 1
        bytMonthTemp = bytMonth
        Do While bytMonth > 1
            intDays = intDays + Val(Mid(strMLen, bytEbteda, 2))
            bytMonth = bytMonth - 1
            bytEbteda = bytEbteda + 2
        Loop
        'If (intYear > 1996 And (intYear - 95) Mod 4 <> 0) Or (intYear = 1996) Or ((intYear - 96) Mod 4 <> 0 And intYear < 1996) Then
        If (intYear >= 1996 And (intYear - 97) Mod 4 = 0 And intDay <= 20 And bytMonthTemp = 3) Or _
            (intYear >= 1996 And (intYear - 97) Mod 4 = 0 And bytMonthTemp < 3) Or _
            (intYear < 1996 And (intYear) Mod 4 = 0) Then
            intDays = (intDays + 285) Mod 366
        Else
            intDays = (intDays + 285) Mod 365
        End If
        If intDays > 185 Then
            bytMm = Int((intDays - 186) / 30) + 7
            If (intYear >= 1996 And (intYear - 97) Mod 4 = 0 And intDay <= 20 And bytMonthTemp = 3) Or _
                (intYear >= 1996 And (intYear - 97) Mod 4 = 0 And bytMonthTemp < 3) Then
                intDd = (intDays - 184) Mod 30
            Else
                intDd = (intDays - 185) Mod 30
            End If
            If intDd = 0 Then intDd = 30
        Else
            bytMm = Int(intDays / 31) + 1
            intDd = (intDays Mod 31) + 1
        End If
        strMah = Trim(Str(bytMm))
        strRooz = Trim(Str(intDd))
        strSal = Trim(Str(intYy))
        If Len(strMah) = 1 Then strMah = "0" + strMah
        If Len(strRooz) = 1 Then strRooz = "0" + strRooz
        MToSh = strSal + "/" + strMah + "/" + strRooz
        MToSh = Right(MToSh, 10)
    End Function

    Public Function DLToF(ByVal dat_date As String) As String
        Dim d_year As Integer
        Dim d_mont As Integer
        Dim d_days As Integer
        d_days = Val(Right(dat_date, 2))
        d_mont = Val(Mid(dat_date, 6, 2))
        d_year = Val(Mid(dat_date, 1, 4))
        Dim Day As String = DayString(d_days)
        Dim Month As String = MonthString(d_mont)
        DLToF = +" " + Month + " " + Day
    End Function
    Private Function MonthString(ByVal ThisMonth As Integer) As String
        Dim d As String
        Select Case d
            Case 1
                d = "ÝÑæÑÏíä"
            Case 2
                d = "ÇÑÏíÈåÔÊ"
            Case 3
                d = "ÎÑÏÇÏ"
            Case 4
                d = "ÊíÑ"
            Case 5
                d = "ãÑÏÇÏ"
            Case 6
                d = "ÔåÑíæÑ"
            Case 7
                d = "ãåÑ"
            Case 8
                d = "ÂÈÇä"
            Case 9
                d = "ÂÐÑ"
            Case 10
                d = "Ïí"
            Case 11
                d = "Èåãä"
            Case 12
                d = "ÇÓÝäÏ"
        End Select
        d = MonthString
    End Function
    Private Function DayString(ByVal Thisday As Integer)
        Dim d As String
        Select Case Thisday
            Case 1
                d = "íßã"
            Case 2
                d = "Ïæã"
            Case 3
                d = "Óæã"
            Case 4
                d = "åÇÑã"
            Case 5
                d = "äÌã"
            Case 6
                d = "ÔÔã"
            Case 7
                d = "åÝÊã"
            Case 8
                d = "åÔÊã"
            Case 9
                d = "äåã"
            Case 10
                d = "Ïåã"
            Case 11
                d = "íÇÒÏåã"
            Case 12
                d = "ÏæÇÒÏåã"
            Case 13
                d = "ÓíÒÏåã"
            Case 14
                d = "åÇÑÏåã"
            Case 15
                d = "ÇäÒÏåã"
            Case 16
                d = "ÔÇäÒÏåã"
            Case 17
                d = "åÝÏåã"
            Case 18
                d = "åÌÏåã"
            Case 19
                d = "äæÒÏåã"
            Case 20
                d = "ÈíÓÊã"
            Case 21
                d = "ÈíÓÊ æ íßã"
            Case 22
                d = "ÈíÓÊ æ Ïæã"
            Case 23
                d = "ÈíÓÊ æ Óæã"
            Case 24
                d = "ÈíÓÊ æ åÇÑã"
            Case 25
                d = "ÈíÓÊ æ ÊÌã"
            Case 26
                d = "ÈíÓÊ æ ÔÔã"
            Case 27
                d = "ÈíÓÊ æ åÝÊã"
            Case 28
                d = "ÈíÓÊ æ åÔÊã"
            Case 29
                d = "ÈíÓÊ æ äåã"
            Case 30
                d = "Óí Çã"
            Case 31
                d = "Óí æ íßã"
        End Select
        DayString = d
    End Function
End Class
