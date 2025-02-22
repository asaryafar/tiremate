Public Class WebSiteAddress
    Inherits RegEmailAndWeb
    Public Sub New()
        MyBase.New()

        InitializeComponent()
        Me.ValidationExpression = "([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"
        Me.ErrorMessage = "www.microsoft.com ¬œ—” Ê» ”«Ì  »«Ì” Ì »Â «Ì‰ ’Ê—  »«‘œ"

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
