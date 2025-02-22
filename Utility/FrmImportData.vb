Public Class FrmImportData
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents BtnBrand As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtBrandPath As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnBrand = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtBrandPath = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BtnBrand
        '
        Me.BtnBrand.Location = New System.Drawing.Point(144, 72)
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.TabIndex = 0
        Me.BtnBrand.Text = "Brand"
        '
        'txtBrandPath
        '
        Me.txtBrandPath.Location = New System.Drawing.Point(224, 72)
        Me.txtBrandPath.Name = "txtBrandPath"
        Me.txtBrandPath.Size = New System.Drawing.Size(184, 20)
        Me.txtBrandPath.TabIndex = 1
        Me.txtBrandPath.Text = ""
        '
        'FrmImportData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(846, 721)
        Me.Controls.Add(Me.txtBrandPath)
        Me.Controls.Add(Me.BtnBrand)
        Me.Name = "FrmImportData"
        Me.Text = "Import Data"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BtnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrand.Click
        ' ??? ???? ???? ????
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtBrandPath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
End Class
