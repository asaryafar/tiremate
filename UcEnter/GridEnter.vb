Public Class GridEnter
    Inherits DataGrid
    Dim e As System.EventArgs
    Public Event EnterRowGrid(ByVal sender As Object, ByVal e As System.EventArgs)
    Protected Overrides Function processcmdkey(ByRef msg As System.Windows.Forms.Message, ByVal KeyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            RaiseEvent EnterRowGrid(Me, e)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, KeyData)
    End Function
End Class
