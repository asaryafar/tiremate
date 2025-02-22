Imports CommonClass
Public Class ClsTime
    Public Function SubtractTime(ByVal Time1 As String, ByVal Time2 As String) As String
        Time1 = Time1.Trim
        Time2 = Time2.Trim
        Dim Time1Hour As String
        Dim Time1Minute As String
        Dim Time2Hour As String
        Dim Time2Minute As String

        If Time1 < Time2 Or Time1.Length <> 5 Or Time2.Length <> 5 Then
            SubtractTime = ""
        Else

            Dim ColumnPosition As Integer
            Try
                ColumnPosition = InStr(Time1, ":")
                If ColumnPosition < 1 Then
                    Time1 = "00:00"
                Else
                    Time1Hour = Getcod(Mid(Time1, 1, ColumnPosition - 1), 2)
                    Time1Minute = Getcod(Mid(Time1, ColumnPosition + 1, 2), 2)
                End If
            Catch ex As Exception
                Time1Hour = "00"
                Time1Minute = "00"
            End Try
            Try
                ColumnPosition = InStr(Time2, ":")
                If ColumnPosition < 1 Then
                    Time2 = "00:00"
                Else
                    Time2Hour = Getcod(Mid(Time2, 1, ColumnPosition - 1), 2)
                    Time2Minute = Getcod(Mid(Time2, ColumnPosition + 1, 2), 2)
                End If
            Catch ex As Exception
                Time2Hour = "00"
                Time2Minute = "00"
            End Try
            If Time1Minute >= Time2Minute Then
                SubtractTime = Getcod((Val(Time1Hour) - Val(Time2Hour)).ToString, 2) & ":" & Getcod((Val(Time1Minute) - Val(Time2Minute)).ToString, 2)
            Else
                SubtractTime = Getcod((Val(Time1Hour) - 1 - Val(Time2Hour)).ToString, 2) & ":" & Getcod((Val(Time1Minute) + 60 - Val(Time2Minute)).ToString, 2)
            End If
        End If
    End Function
    Public Function AddTime(ByVal Time1 As String, ByVal Time2 As String) As String
        Time1 = Time1.Trim
        Time2 = Time2.Trim
        Dim Time1Hour As String
        Dim Time1Minute As String
        Dim Time2Hour As String
        Dim Time2Minute As String
        Dim TimeHourVar As Integer
        Dim TimeMinuteVar As Integer

        AddTime = ""
        Dim ColumnPosition As Integer
        Try
            ColumnPosition = InStr(Time1, ":")
            If ColumnPosition < 1 Then
                Time1 = "00:00"
            Else
                Time1Hour = Getcod(Mid(Time1, 1, ColumnPosition - 1), 2)
                Time1Minute = Getcod(Mid(Time1, ColumnPosition + 1, 2), 2)
            End If
        Catch ex As Exception
            Time1Hour = "00"
            Time1Minute = "00"
        End Try
        Try
            ColumnPosition = InStr(Time2, ":")
            If ColumnPosition < 1 Then
                Time2 = "00:00"
            Else
                Time2Hour = Getcod(Mid(Time2, 1, ColumnPosition - 1), 2)
                Time2Minute = Getcod(Mid(Time2, ColumnPosition + 1, 2), 2)
            End If
        Catch ex As Exception
            Time2Hour = "00"
            Time2Minute = "00"
        End Try

        TimeHourVar = Val(Time1Hour) + Val(Time2Hour)
        TimeMinuteVar = Val(Time1Minute) + Val(Time2Minute)
        If TimeMinuteVar >= 60 Then
            TimeHourVar = TimeHourVar + 1
            TimeMinuteVar = TimeMinuteVar - 60
        End If
        Try
            AddTime = Getcod(TimeHourVar.ToString, 2) & ":" & Getcod(TimeMinuteVar.ToString, 2)
        Catch ex As Exception
            AddTime = "00:00"
        End Try
    End Function
End Class
