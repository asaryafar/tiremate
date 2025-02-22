Public Class ComboBoxEnter
    Inherits Janus.Windows.EditControls.UIComboBox

    Private Sub ComboBoxEnter_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

End Class
