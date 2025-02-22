Public Module MainModuleHesabdari
    Public Sub ShowThisForm(ByVal ThisForm As Windows.Forms.Form, ByVal Me1 As Object)
        ThisForm.TopLevel = False
        ThisForm.Parent = Me1
        ThisForm.Show()
        ThisForm.BringToFront()
    End Sub

End Module
