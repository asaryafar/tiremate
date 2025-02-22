Public Class IntegerUpDownEnter
    Inherits Janus.Windows.GridEX.EditControls.IntegerUpDown

    Private Sub TextBoxEnter_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

End Class
