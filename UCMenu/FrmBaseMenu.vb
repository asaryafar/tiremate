Imports CommonClass
Public Class FrmBaseMenu
    Inherits FrmBase
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBaseMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(515, 369)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FrmBaseMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(515, 369)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBaseMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Private Sub FrmBasemenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.Left = ((PubScreenResolutionX - Me.Width - PubButtonBarWidth) / 2) + PubButtonBarWidth
    '    Me.Top = ((PubScreenResolutionY - Me.Height - 47) / 2)
    '    BtnExit.Left = Me.Width - BtnExit.Width - 20
    '    BtnExit.Top = Me.Height - BtnExit.Height - 20
    'End Sub
    Public Sub SHOWMYFORM(ByVal ThisForm As Form)
        ThisForm.TopLevel = False
        ThisForm.MdiParent = Me.MdiParent
        ThisForm.StartPosition = FormStartPosition.Manual
        ThisForm.Top = 1
        ThisForm.Left = 1
        'If PubButtonBarWidth + ThisForm.Width > PubScreenResolutionX Then
        '    ThisForm.Left = PubScreenResolutionX - ThisForm.Width
        'Else
        '    ThisForm.Left = PubButtonBarWidth
        'End If
        Try
            ThisForm.Show()
            ThisForm.BringToFront()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
