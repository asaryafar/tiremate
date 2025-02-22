Public Class FrmExit
    Inherits CommonClass.FrmBase
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
    Friend WithEvents BtnRight As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnLeft As Janus.Windows.EditControls.UIButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmExit))
        Me.BtnRight = New Janus.Windows.EditControls.UIButton
        Me.BtnLeft = New Janus.Windows.EditControls.UIButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'BtnRight
        '
        Me.BtnRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnRight.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnRight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnRight.Location = New System.Drawing.Point(138, 100)
        Me.BtnRight.Name = "BtnRight"
        Me.BtnRight.Size = New System.Drawing.Size(89, 27)
        Me.BtnRight.TabIndex = 3
        Me.BtnRight.Text = "OK"
        '
        'BtnLeft
        '
        Me.BtnLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnLeft.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLeft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnLeft.Location = New System.Drawing.Point(6, 100)
        Me.BtnLeft.Name = "BtnLeft"
        Me.BtnLeft.Size = New System.Drawing.Size(89, 27)
        Me.BtnLeft.TabIndex = 2
        Me.BtnLeft.Text = "Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FrmExit
        '
        Me.AcceptButton = Me.BtnRight
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.BtnLeft
        Me.ClientSize = New System.Drawing.Size(232, 133)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnRight)
        Me.Controls.Add(Me.BtnLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exit"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BtnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRight.Click
        End
    End Sub
    Private Sub BtnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLeft.Click
        Me.Close()
    End Sub
End Class
