Public Class JanusCalendarComboEnter
    Inherits Janus.Windows.CalendarCombo.CalendarCombo

    Private Sub JanusCalendarComboEnter_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
