Public Class EmailAddress
    Inherits RegEmailAndWeb

    Public Sub New()
        MyBase.New()


        InitializeComponent()

        Me.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$"
        Me.ErrorMessage = "abc@microsoft.com ¬œ—” Å”  «·ò —Ê‰ÌòÌ »«Ì” Ì »Â «Ì‰ ’Ê—  »«‘œ"

    End Sub
#Region " Windows Form Designer generated code "
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region


  
End Class
