Public Class ClsPrintGrid
    Friend WithEvents GrdPrint As New Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrnPreview As New System.Windows.Forms.PrintPreviewDialog
    Public Sub PrintThisGrid(ByRef ThisGrid As Janus.Windows.GridEX.GridEX)
        GrdPrint.GridEX = ThisGrid
        PrnPreview.Document = Me.GrdPrint
        PrnPreview.ShowDialog()
    End Sub
End Class
