Public Class DateUtils

#Region "Public Functions"

    Public Shared Forms As New Collections.Hashtable
    ' »œÌ·  «—ÌŒ „Ì·«œÌ »Â ‘„”Ì
    Public Shared Function EnToFar(ByVal strEnglighDate As String) As String
        If Not validDate(strEnglighDate, 2) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim strYear, strMonth, strDay As String
        Dim iYear As Short
        Dim iMonth As Short
        Dim iDay As Short
        If strEnglighDate.Length = 8 Then
            iYear = CType(strEnglighDate.Substring(0, 4), Short)
            iMonth = CType(strEnglighDate.Substring(4, 2), Short)
            iDay = CType(strEnglighDate.Substring(6, 2), Short)
        Else
            iYear = CType(strEnglighDate.Substring(0, 4), Short)
            iMonth = CType(strEnglighDate.Substring(5, 2), Short)
            iDay = CType(strEnglighDate.Substring(8, 2), Short)
        End If

        jdn_persian(civil_jdn(iYear, iMonth, iDay), iYear, iMonth, iDay)

        strYear = CType(iYear, String).Trim
        If iMonth < 10 Then
            strMonth = "0" & CType(iMonth, String).Trim()
        Else
            strMonth = CType(iMonth, String).Trim()
        End If
        If iDay < 10 Then
            strDay = "0" & CType(iDay, String).Trim()
        Else
            strDay = CType(iDay, String).Trim()
        End If
        Return strYear & "/" & strMonth & "/" & strDay
    End Function

    ' »œÌ·  «—ÌŒ ‘„”Ì »Â „Ì·«œÌ
    Public Shared Function FarToEn(ByVal strPersianDate As String) As String
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim strYear, strMonth, strDay As String
        Dim iYear As Short
        Dim iMonth As Short
        Dim iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If

        jdn_civil(persian_jdn(iYear, iMonth, iDay), iYear, iMonth, iDay)

        strYear = CType(iYear, String).Trim
        If iMonth < 10 Then
            strMonth = "0" & CType(iMonth, String).Trim()
        Else
            strMonth = CType(iMonth, String).Trim()
        End If
        If iDay < 10 Then
            strDay = "0" & CType(iDay, String).Trim()
        Else
            strDay = CType(iDay, String).Trim()
        End If
        Return strYear & "/" & strMonth & "/" & strDay
    End Function

    Public Shared Function FarToEn(ByVal iYear As Short, ByVal iMonth As Short, ByVal iDay As Short) As String
        Dim strYear, strMonth, strDay As String

        jdn_civil(persian_jdn(iYear, iMonth, iDay), iYear, iMonth, iDay)

        strYear = CType(iYear, String).Trim
        If iMonth < 10 Then
            strMonth = "0" & CType(iMonth, String).Trim()
        Else
            strMonth = CType(iMonth, String).Trim()
        End If
        If iDay < 10 Then
            strDay = "0" & CType(iDay, String).Trim()
        Else
            strDay = CType(iDay, String).Trim()
        End If
        Return strYear & "/" & strMonth & "/" & strDay
    End Function

    ' «—ÌŒ —Ê“Ã«—Ì »Â ‘„”Ì
    Public Shared Function FarToDay() As String
        Dim strEnglishDate As String = DateTime.Today.ToString("yyyy/MM/dd")
        FarToDay = EnToFar(strEnglishDate)
    End Function

    ' «—ÌŒ —Ê“Ã«—Ì »Â „Ì·«œÌ
    Public Shared Function EnToDay() As String
        EnToDay = DateTime.Today.ToString("yyyy/MM/dd")
    End Function

    '«“  «—ÌŒ ‘„”Ì ﬁ”„  ”«· —« »— „Ìê—œ«‰œ
    Public Shared Function FarYear(ByVal strPersianDate As String) As Short
        FarYear = CType(strPersianDate.Substring(0, 4), Short)
    End Function

    '«“  «—ÌŒ ‘„”Ì ﬁ”„  „«Â —« »— „Ìê—œ«‰œ
    Public Shared Function FarMonth(ByVal strPersianDate As String) As Short
        FarMonth = CType(strPersianDate.Substring(5, 2), Short)
    End Function

    '«“  «—ÌŒ ‘„”Ì ﬁ”„  —Ê“ —« »— „Ìê—œ«‰œ
    Public Shared Function Farday(ByVal strPersianDate As String) As Short
        Farday = CType(strPersianDate.Substring(8, 2), Short)
    End Function

    '„‘Œ’ ò—œ‰ ”«· ò»Ì”Â ‘„”Ì
    Public Shared Function Leap_Far(ByVal iYear As Short) As Boolean
        If iYear > 0 Then
            Leap_Far = ((((((iYear - (474)) Mod 2820) + 474) + 38) * 682) Mod 2816) < 682
        Else
            Leap_Far = ((((((iYear - (473)) Mod 2820) + 474) + 38) * 682) Mod 2816) < 682
        End If
    End Function

    '„‘Œ’ ò—œ‰ ”«· ò»Ì”Â „Ì·«œÌ
    Public Shared Function Leap_En(ByVal iYear As Short) As Boolean
        Return civil_leapyear(iYear, 1)
    End Function

    '‰«„ „«ÂÂ«Ì ›«—”Ì
    Public Shared Function FarMonthName(ByVal iMonth As Short) As String
        Select Case iMonth
            Case 1
                FarMonthName = "›—Ê—œÌ‰" '"Farvardin"
            Case 2
                FarMonthName = "«—œÌ»Â‘ " '"Ordibehesht"
            Case 3
                FarMonthName = "Œ—œ«œ" '"Khordad"
            Case 4
                FarMonthName = " Ì—" '"Tir"
            Case 5
                FarMonthName = "„—œ«œ" '"Mordad"
            Case 6
                FarMonthName = "‘Â—ÌÊ—" '"Shahrivar"
            Case 7
                FarMonthName = "„Â—" '"Mehr"
            Case 8
                FarMonthName = "¬»«‰" '"Aban"
            Case 9
                FarMonthName = "¬–—" '"Azar"
            Case 10
                FarMonthName = "œÌ" '"Dey"
            Case 11
                FarMonthName = "»Â„‰" '"Bahman"
            Case 12
                FarMonthName = "«”›‰œ" '"Esfand"
            Case Else
                FarMonthName = "" '"Error"
        End Select
    End Function

    '‰«„ „«ÂÂ«Ì «‰ê·Ì”Ì
    Public Shared Function EnMonthName(ByVal iMonth As Short) As String
        Return civil_monthName(iMonth, 1)
    End Function


    ' language=1 for English Name ;language=98 for Persian Name   ‰«„ —Ê“Â«Ì ‘„”Ì
    Public Shared Function FarDayName(ByVal strPersianDate As String, Optional ByVal Language As Short = 98) As String
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear As Short
        Dim iMonth As Short
        Dim iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If

        FarDayName = weekdayname(persian_jdn(iYear, iMonth, iDay), Language)

    End Function

    '‰«„ —Ê“Â«Ì „Ì·«œÌ
    Public Shared Function EnDayName(ByVal strEnglishDate As String, Optional ByVal Language As Short = 1) As String
        If Not validDate(strEnglishDate, 2) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear As Short
        Dim iMonth As Short
        Dim iDay As Short
        If strEnglishDate.Length = 8 Then
            iYear = CType(strEnglishDate.Substring(0, 4), Short)
            iMonth = CType(strEnglishDate.Substring(4, 2), Short)
            iDay = CType(strEnglishDate.Substring(6, 2), Short)
        Else
            iYear = CType(strEnglishDate.Substring(0, 4), Short)
            iMonth = CType(strEnglishDate.Substring(5, 2), Short)
            iDay = CType(strEnglishDate.Substring(8, 2), Short)
        End If

        EnDayName = weekdayname(civil_jdn(iYear, iMonth, iDay), Language)

    End Function

    '«÷«›Â ò—œ‰ —Ê“ »Â  «—ÌŒ ‘„”Ì
    Public Shared Function FarAddDays(ByVal strPersianDate As String, ByVal Days As Short) As String
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim strYear, strMonth, strDay As String
        Dim iYear, iMonth, iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If

        jdn_persian(persian_jdn(iYear, iMonth, iDay) + Days, iYear, iMonth, iDay)

        strYear = CType(iYear, String).Trim
        If iMonth < 10 Then
            strMonth = "0" & CType(iMonth, String).Trim()
        Else
            strMonth = CType(iMonth, String).Trim()
        End If
        If iDay < 10 Then
            strDay = "0" & CType(iDay, String).Trim()
        Else
            strDay = CType(iDay, String).Trim()
        End If
        Return strYear & "/" & strMonth & "/" & strDay
    End Function

    '«Œ ·«› œÊ  «—ÌŒ ‘„”Ì
    Public Shared Function FarDiffDate(ByVal strPersianFirstDate As String, ByVal strPersianSecondDate As String) As Integer
        If Not validDate(strPersianFirstDate, 1) And Not validDate(strPersianSecondDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear1, iMonth1, iDay1, iYear2, iMonth2, iDay2 As Short
        If strPersianFirstDate.Length = 8 Then
            iYear1 = CType(strPersianFirstDate.Substring(0, 4), Short)
            iMonth1 = CType(strPersianFirstDate.Substring(4, 2), Short)
            iDay1 = CType(strPersianFirstDate.Substring(6, 2), Short)
        Else
            iYear1 = CType(strPersianFirstDate.Substring(0, 4), Short)
            iMonth1 = CType(strPersianFirstDate.Substring(5, 2), Short)
            iDay1 = CType(strPersianFirstDate.Substring(8, 2), Short)
        End If

        If strPersianSecondDate.Length = 8 Then
            iYear2 = CType(strPersianSecondDate.Substring(0, 4), Short)
            iMonth2 = CType(strPersianSecondDate.Substring(4, 2), Short)
            iDay2 = CType(strPersianSecondDate.Substring(6, 2), Short)
        Else
            iYear2 = CType(strPersianSecondDate.Substring(0, 4), Short)
            iMonth2 = CType(strPersianSecondDate.Substring(5, 2), Short)
            iDay2 = CType(strPersianSecondDate.Substring(8, 2), Short)
        End If
        Return persian_jdn(iYear1, iMonth1, iDay1) - persian_jdn(iYear2, iMonth2, iDay2)
    End Function

    '‰Ê‘ ‰  «—ÌŒ »Â Õ—Ê› «·›»«
    Public Shared Function FarDateAlphabetic(ByVal strPersianDate As String) As String
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear, iMonth, iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If
        FarDateAlphabetic = NumberToString.N2S(iDay, False) + " " + FarMonthName(iMonth) + " " + NumberToString.N2S(iYear, False)
    End Function

    '„‘Œ’ ò—œ‰ ç‰œ„Ì‰ —Ê“ ”«· ‘„”Ì
    Public Shared Function nthDaysOfYearFar(ByVal strPersianDate As String) As Short
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear, iMonth, iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If
        Return persian_jdn(iYear, iMonth, iDay) - persian_jdn(iYear, 1, 0)
    End Function

    '„‘Œ’ ò—œ‰ ç‰œ„Ì‰ —Ê“ Â› Â ‘„”Ì
    Public Shared Function FarDayOfWeek(ByVal strPersianDate As String) As Short
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear, iMonth, iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If
        Select Case dayOfWeek(persian_jdn(iYear, iMonth, iDay))
            Case 1
                FarDayOfWeek = 3
            Case 2
                FarDayOfWeek = 4
            Case 3
                FarDayOfWeek = 5
            Case 4
                FarDayOfWeek = 6
            Case 5
                FarDayOfWeek = 7
            Case 6
                FarDayOfWeek = 1
            Case 7
                FarDayOfWeek = 2
        End Select
    End Function

    Public Shared Function FarDayOfWeek(ByVal iYear As Short, ByVal iMonth As Short, ByVal iDay As Short) As Short
        Select Case dayOfWeek(persian_jdn(iYear, iMonth, iDay))
            Case 1
                FarDayOfWeek = 3
            Case 2
                FarDayOfWeek = 4
            Case 3
                FarDayOfWeek = 5
            Case 4
                FarDayOfWeek = 6
            Case 5
                FarDayOfWeek = 7
            Case 6
                FarDayOfWeek = 1
            Case 7
                FarDayOfWeek = 2
        End Select
    End Function

    '„‘Œ’ ò—œ‰ ç‰œ„Ì‰ Â› Â ”«· ‘„”Ì
    Public Shared Function FarWeekNumber(ByVal strPersianDate As String) As Short
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear, iMonth, iDay, nDay As Short
        Dim strDate As String
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If
        strDate = strPersianDate.Substring(0, 4) + "/01/01"
        nDay = nthDaysOfYearFar(strPersianDate) + FarDayOfWeek(strDate)
        FarWeekNumber = IIf((nDay Mod 7) = 0, nDay \ 7, nDay \ 7 + 1)
    End Function

    '„‘Œ’ ò—œ‰ —Ê“Â«Ì  ⁄ÿÌ·    Ã„⁄Â Â« - «Ì«„ ⁄Ìœ - ”Ì“œÂ ›—Ê—œÌ‰ -29 «”›‰œ 
    Public Shared Function FarHolidays(ByVal strPersianDate As String) As Boolean
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim iYear, iMonth, iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If
        If iMonth = 1 And (iDay = 1 Or iDay = 2 Or iDay = 3 Or iDay = 4 Or iDay = 13) Then
            FarHolidays = True
        End If
        If iMonth = 12 And iDay = 29 Then
            FarHolidays = True
        End If
        If FarDayOfWeek(strPersianDate) = 7 Then
            FarHolidays = True
        End If
    End Function

    Public Shared Function FarDayOfMonth(ByVal strPersianDate As String) As Short
        If Not validDate(strPersianDate, 1) Then
            Throw New Exception(".  «—ÌŒ «‘ »«Â «” ")
        End If
        Dim strYear, strMonth, strDay As String
        Dim iYear, iMonth, iDay As Short
        If strPersianDate.Length = 8 Then
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(4, 2), Short)
            iDay = CType(strPersianDate.Substring(6, 2), Short)
        Else
            iYear = CType(strPersianDate.Substring(0, 4), Short)
            iMonth = CType(strPersianDate.Substring(5, 2), Short)
            iDay = CType(strPersianDate.Substring(8, 2), Short)
        End If
        If iMonth <= 6 Then
            Return 31
        End If
        If iMonth <= 11 And iMonth >= 7 Then
            Return 30
        End If
        If iMonth = 12 Then
            If Leap_Far(iYear) Then
                Return 30
            Else
                Return 29
            End If
        End If
    End Function

    Public Shared Function FarDayOfMonth(ByVal iYear As Short, ByVal iMonth As Short) As Short
        If iMonth <= 6 Then
            Return 31
        End If
        If iMonth <= 11 And iMonth >= 7 Then
            Return 30
        End If
        If iMonth = 12 Then
            If Leap_Far(iYear) Then
                Return 30
            Else
                Return 29
            End If
        End If
    End Function

    'lan=1 for persian and lan=2 for English
    Public Shared Function validDate(ByVal strDate As String, ByVal Lan As Short) As Boolean
        Dim at As Integer
        Dim i As Short = 0
        Dim check(3) As Integer
        Dim start As Integer = 0
        If strDate.Trim.Length = 8 Or strDate.Trim.Length = 10 Then
            If strDate.Length = 8 Then
                If strDate.IndexOf("/") = -1 Then
                    validDate = True
                Else
                    validDate = False
                End If
            Else
                While start < strDate.Length AndAlso at > -1
                    at = strDate.IndexOf("/", start)
                    check(i) = at
                    If at = -1 Then
                        Exit While
                    End If
                    start = at + 1
                    i += 1
                    If i > 2 Then
                        validDate = False
                    End If
                End While
                If check(0) = 4 And check(1) = 7 And check(2) = -1 Then
                    validDate = True
                Else
                    validDate = False
                End If
            End If
        Else
            validDate = False
        End If
        If validDate = False Then
            Return False
        End If
        Dim iYear, iMonth, iDay As Short
        If strDate.Length = 8 Then
            iYear = CType(strDate.Substring(0, 4), Short)
            iMonth = CType(strDate.Substring(4, 2), Short)
            iDay = CType(strDate.Substring(6, 2), Short)
        Else
            iYear = CType(strDate.Substring(0, 4), Short)
            iMonth = CType(strDate.Substring(5, 2), Short)
            iDay = CType(strDate.Substring(8, 2), Short)
        End If
        If iMonth > 12 Then
            Return False
        End If
        If Lan = 1 Then
            Select Case iMonth
                Case 12
                    If Leap_Far(iYear) Then
                        If iDay > 30 Then
                            Return False
                        End If
                    Else
                        If iDay > 29 Then
                            Return False
                        End If
                    End If
                Case 7, 8, 9, 10, 11
                    If iDay > 30 Then
                        Return False
                    End If
                Case Else
                    If iDay > 31 Then
                        Return False
                    End If
            End Select
        Else
            Select Case iMonth
                Case 2
                    If Leap_En(iYear) Then
                        If iDay > 29 Then
                            Return False
                        End If
                    Else
                        If iDay > 28 Then
                            Return False
                        End If
                    End If
                Case 4, 6, 9, 11
                    If iDay > 30 Then
                        Return False
                    End If
                Case Else
                    If iDay > 31 Then
                        Return False
                    End If
            End Select
        End If
        Return True
    End Function

#End Region


#Region "Constant Variables "

    'Calendar types
    Private Const Gregorian As Short = 1
    Private Const Julian As Short = 2
    Private Const Persian As Short = 98
    '
    ' Weekday Numbering styles
    Private Const weekStartsOnMonday As Short = 1
    Private Const weekStartsOnSunday As Short = 2
    Private Const weekStartsOnSaturday As Short = 3
    Private Const weekStartsOnFriday As Short = 4
    Private Const weekStartsOnThursday As Short = 5
    Private Const weekStartsOnWednesday As Short = 6
    Private Const weekStartsOnTuesday As Short = 7
    '
    ' weeknumstyles
    Private Const Jan1InWeek1 As Short = 0
    Private Const Jan4InWeek1 As Short = 1
    Private Const Jan7InWeek1 As Short = 2
    '
    ' Languages
    Private Const English As Short = 1
    Private Const Farsi As Short = Persian
    '
    'Miscellaneous public constants
    Private Const Signed As Short = -1
    Private Const UnSigned As Short = 1

#End Region


#Region "Persian Functions"

    Private Shared Function Ceil(ByRef number As Single) As Integer
        Ceil = -System.Math.Sign(number) * Int(-System.Math.Abs(number))
        ' or
        'Ceil = CInt(number + (Sgn(number) * 0.5))
    End Function

    '
    ' Determine Julian day from Persian date
    '
    Private Shared Function persian_jdn(ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short) As Integer
        Const PERSIAN_EPOCH As Integer = 1948321 ' The JDN of 1 Farvardin 1
        Dim epbase As Integer
        Dim epyear As Integer
        Dim mdays As Integer
        If iYear >= 0 Then
            epbase = iYear - 474
        Else
            epbase = iYear - 473
        End If
        epyear = 474 + (epbase Mod 2820)
        If iMonth <= 7 Then
            mdays = (CInt(iMonth) - 1) * 31
        Else
            mdays = (CInt(iMonth) - 1) * 30 + 6
        End If
        persian_jdn = CInt(iDay) + mdays + Fix(((epyear * 682) - 110) / 2816) + (epyear - 1) * 365 + Fix(epbase / 2820) * 1029983 + (PERSIAN_EPOCH - 1)
    End Function
    '
    Private Shared Sub jdn_persian(ByRef jdn As Integer, ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short)
        Dim depoch As Long
        Dim cycle As Integer
        Dim cyear As Long
        Dim ycycle As Integer
        Dim aux1, aux2 As Integer
        Dim yday As Integer
        depoch = jdn - persian_jdn(475, 1, 1)
        cycle = Fix(depoch / 1029983)
        cyear = depoch Mod 1029983

        If cyear = 1029982 Then
            ycycle = 2820
        Else
            aux1 = Fix(cyear / 366)
            aux2 = cyear Mod 366
            ycycle = Int(((2134 * aux1) + (2816 * aux2) + 2815) / 1028522) + aux1 + 1
        End If
        iYear = ycycle + (2820 * cycle) + 474
        If iYear <= 0 Then
            iYear = iYear - 1
        End If
        yday = (jdn - persian_jdn(iYear, 1, 1)) + 1
        If yday <= 186 Then
            iMonth = Ceil(yday / 31)
        Else
            iMonth = Ceil((yday - 6) / 30)
        End If
        iDay = (jdn - persian_jdn(iYear, iMonth, 1)) + 1
    End Sub

#End Region


#Region "Civil Functions"

    Private Shared Sub jdn_civil(ByRef jdn As Integer, ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short)

        Dim l As Integer
        Dim k As Integer
        Dim n As Integer
        Dim i As Integer
        Dim j As Integer

        If (jdn > 2299160) Then
            l = jdn + 68569
            n = ((4 * l) \ 146097)
            l = l - ((146097 * n + 3) \ 4)
            i = ((4000 * (l + 1)) \ 1461001)
            l = l - ((1461 * i) \ 4) + 31
            j = ((80 * l) \ 2447)
            iDay = l - ((2447 * j) \ 80)
            l = (j \ 11)
            iMonth = j + 2 - 12 * l
            iYear = 100 * (n - 49) + i + l
        Else
            Call jdn_julian(jdn, iYear, iMonth, iDay)
        End If

    End Sub

    Private Shared Function civil_weekNumber(ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short, Optional ByRef DaynumStyle As Short = 1, Optional ByRef WeeknumStyle As Short = 1, Optional ByRef CalendarStyle As Short = Gregorian) As Short
        Dim markday As Integer
        Dim firstmarkday As Integer

        Select Case WeeknumStyle
            Case Jan1InWeek1
                civil_weekNumber = (civil_jdn(iYear, iMonth, iDay, CalendarStyle) - civil_jdn(iYear, 1, 1, CalendarStyle) + dayOfWeek(civil_jdn(iYear, 1, 1, CalendarStyle), DaynumStyle) + 6) \ 7
            Case Jan4InWeek1, Jan7InWeek1
                markday = civil_jdn(iYear, iMonth, iDay, CalendarStyle) - dayOfWeek(civil_jdn(iYear, iMonth, iDay, CalendarStyle), DaynumStyle) + 1 + (WeeknumStyle * 3)
                If markday > civil_jdn(iYear, 12, 31, CalendarStyle) Then
                    'this week's markday is next iYear, so we're already in week 1.
                    civil_weekNumber = 1
                Else
                    If markday < civil_jdn(iYear, 1, 1, CalendarStyle) Then
                        'We're still is last iYear's last week.
                        civil_weekNumber = civil_weekNumber(iYear - 1, 12, 31, DaynumStyle, WeeknumStyle)
                    Else
                        'This is a normal week in the middle of the iYear.
                        'Count the weeks between this week's markday and
                        'the first markday of the iYear, divide it by seven
                        'and add 1. That's it!
                        firstmarkday = civil_jdn(iYear, 1, 1 + (WeeknumStyle * 3), CalendarStyle) - dayOfWeek(civil_jdn(iYear, 1, 1 + (WeeknumStyle * 3), CalendarStyle), DaynumStyle) + 1 + (WeeknumStyle * 3)
                        civil_weekNumber = (markday - firstmarkday) \ 7 + 1
                    End If
                End If
            Case Else
                civil_weekNumber = 0
        End Select
    End Function

    Private Shared Sub civil_normDate(ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short, Optional ByRef CalendarType As Short = Gregorian)
        Dim monLength As Short

        If (iMonth > 12) Then
            iYear = iYear + (iMonth \ 12)
            iMonth = iMonth Mod 12
        ElseIf (iMonth < 1) Then
            iYear = iYear + (iMonth \ 12) - 1
            iMonth = 12 + (iMonth Mod 12)
        End If

        monLength = civil_daysInMonth(iYear, iMonth, CalendarType)
        While (iDay > monLength)
            If (iMonth = 12) Then
                iMonth = 1
                iYear = iYear + 1
            Else
                iMonth = iMonth + 1
            End If
            iDay = iDay - monLength
            monLength = civil_daysInMonth(iYear, iMonth, CalendarType)
        End While

        While (iDay < 1)
            If (iMonth = 1) Then
                iMonth = 12
                iYear = iYear - 1
            Else
                iMonth = iMonth - 1
            End If
            iDay = iDay + civil_daysInMonth(iYear, iMonth, CalendarType)
        End While
    End Sub

    Private Shared Function civil_monthName(ByRef iMonth As Short, Optional ByRef Language As Short = 1) As String
        Dim Jan As String
        Dim Feb As String
        Dim Mar As String
        Dim Apr As String
        Dim May As String
        Dim Jun As String
        Dim Jul As String
        Dim Aug As String
        Dim Sep As String
        Dim Oct As String
        Dim Nov As String
        Dim Dec As String


        Jan = "January"
        Feb = "February"
        Mar = "March"
        Apr = "April"
        May = "May"
        Jun = "June"
        Jul = "July"
        Aug = "August"
        Sep = "September"
        Oct = "October"
        Nov = "November"
        Dec = "December"

        Select Case iMonth
            Case 1
                civil_monthName = Jan
            Case 2
                civil_monthName = Feb
            Case 3
                civil_monthName = Mar
            Case 4
                civil_monthName = Apr
            Case 5
                civil_monthName = May
            Case 6
                civil_monthName = Jun
            Case 7
                civil_monthName = Jul
            Case 8
                civil_monthName = Aug
            Case 9
                civil_monthName = Sep
            Case 10
                civil_monthName = Oct
            Case 11
                civil_monthName = Nov
            Case 12
                civil_monthName = Dec
            Case Else
                civil_monthName = "Error"
        End Select
    End Function

    Private Shared Function civil_leapyear(ByRef iYear As Short, Optional ByRef CalendarType As Short = Gregorian) As Boolean

        If CalendarType <> Gregorian Or iYear < 1582 Then
            ' Julian calendar
            civil_leapyear = ((iYear Mod 4) = 0)
        Else
            ' Gregorian calendar
            civil_leapyear = ((iYear Mod 4) = 0) Xor ((iYear Mod 100) = 0) Xor ((iYear Mod 400) = 0)
        End If

    End Function

    Private Shared Function civil_jdn(ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short, Optional ByRef CalendarType As Short = Gregorian) As Integer
        Dim lYear As Integer
        Dim lMonth As Integer
        Dim lDay As Integer

        If CalendarType = Gregorian And ((iYear > 1582) Or ((iYear = 1582) And (iMonth > 10)) Or ((iYear = 1582) And (iMonth = 10) And (iDay > 14))) Then
            lYear = CInt(iYear)
            lMonth = CInt(iMonth)
            lDay = CInt(iDay)
            civil_jdn = ((1461 * (lYear + 4800 + ((lMonth - 14) \ 12))) \ 4) + ((367 * (lMonth - 2 - 12 * (((lMonth - 14) \ 12)))) \ 12) - ((3 * (((lYear + 4900 + ((lMonth - 14) \ 12)) \ 100))) \ 4) + lDay - 32075
        Else
            civil_jdn = julian_jdn(iYear, iMonth, iDay)
        End If

    End Function

    Private Shared Function civil_daysInMonth(ByRef iYear As Short, ByRef iMonth As Short, Optional ByRef CalendarType As Short = Gregorian) As Short
        Select Case iMonth
            Case 2 ' February
                If civil_leapyear(iYear, CalendarType) Then
                    civil_daysInMonth = 29
                Else
                    civil_daysInMonth = 28
                End If
            Case 4, 6, 9, 11 ' April, June, September or November
                civil_daysInMonth = 30
            Case Else ' Other values.
                civil_daysInMonth = 31
        End Select
    End Function

#End Region


#Region "Common Functions"

    Private Shared Function dayOfWeek(ByVal jdn As Integer, Optional ByVal style As Short = 1) As Short
        dayOfWeek = ((jdn + style - 1) Mod 7) + 1
    End Function

    Private Shared Function weekdayname(ByRef jdn As Integer, Optional ByRef Language As Short = 1) As String

        Dim Monday As String
        Dim Tuesday As String
        Dim Wednesday As String
        Dim Thursday As String
        Dim Friday As String
        Dim Saturday As String
        Dim Sunday As String

        Select Case Language
            Case Farsi
                Monday = "œÊ‘‰»Â" '"Doshanbeh"
                Tuesday = "”Â ‘‰»Â" '"Seshanbeh"
                Wednesday = "çÂ«—‘‰»Â" '"Chaharshanbeh"
                Thursday = "Å‰Ã ‘‰»Â" '"Panjshanbeh"
                Friday = "Ã„⁄Â" '"Jomeh"
                Saturday = "‘‰»Â" '"Shanbeh" ' First day of the week in Persian Calendar
                Sunday = "Ìò‘‰»Â" '"Yekshanbeh"
            Case Else
                Monday = "Monday"
                Tuesday = "Tuesday"
                Wednesday = "Wednesday"
                Thursday = "Thursday"
                Friday = "Friday"
                Saturday = "Saturday"
                Sunday = "Sunday"
        End Select

        Select Case dayOfWeek(jdn, 1)
            Case 1
                weekdayname = Monday
            Case 2
                weekdayname = Tuesday
            Case 3
                weekdayname = Wednesday
            Case 4
                weekdayname = Thursday
            Case 5
                weekdayname = Friday
            Case 6
                weekdayname = Saturday
            Case Else
                weekdayname = Sunday
        End Select
    End Function

    Private Shared Function nthWeekdayOfMonth(ByRef iYear As Short, ByRef iMonth As Short, ByRef WantedWeekday As Short, ByRef n As Short, Optional ByRef CalendarType As Short = Gregorian) As Short
        Dim monthLength As Short
        Select Case n
            Case 1 To 4
                nthWeekdayOfMonth = 1 + ((WantedWeekday - dayOfWeek(civil_jdn(iYear, iMonth, 1, CalendarType)) + 7) Mod 7) + ((n - 1) * 7)
            Case -1, 5
                monthLength = civil_daysInMonth(iYear, iMonth, CalendarType)
                nthWeekdayOfMonth = monthLength - ((dayOfWeek(civil_jdn(iYear, iMonth, monthLength, CalendarType)) - WantedWeekday + 7) Mod 7)
            Case Else
                nthWeekdayOfMonth = 0
        End Select
    End Function

#End Region


#Region "Julian Functions"

    Private Shared Sub jdn_julian(ByRef jdn As Integer, ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short)
        Dim l As Integer
        Dim k As Integer
        Dim n As Integer
        Dim i As Integer
        Dim j As Integer

        j = jdn + 1402
        k = ((j - 1) \ 1461)
        l = j - 1461 * k
        n = ((l - 1) \ 365) - (l \ 1461)
        i = l - 365 * n + 30
        j = ((80 * i) \ 2447)
        iDay = i - ((2447 * j) \ 80)
        i = (j \ 11)
        iMonth = j + 2 - 12 * i
        iYear = 4 * k + n + i - 4716

    End Sub

    Private Shared Function julian_jdn(ByRef iYear As Short, ByRef iMonth As Short, ByRef iDay As Short) As Integer
        Dim lYear As Integer
        Dim lMonth As Integer
        Dim lDay As Integer

        lYear = CInt(iYear)
        lMonth = CInt(iMonth)
        lDay = CInt(iDay)

        julian_jdn = 367 * lYear - ((7 * (lYear + 5001 + ((lMonth - 9) \ 7))) \ 4) + ((275 * lMonth) \ 9) + lDay + 1729777

    End Function

#End Region

End Class
