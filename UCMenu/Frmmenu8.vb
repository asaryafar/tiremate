Public Class Frmmenu8
    Inherits FrmBaseMenu
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
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmmenu8))
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnExit.Location = New System.Drawing.Point(493, 306)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(64, 43)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(72, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(243, 97)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button3"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(78, 176)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Button4"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(335, 87)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Button5"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(332, 157)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Button6"
        '
        'Frmmenu8
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 376)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmmenu8"
        Me.Text = "Form3"
        Me.Controls.SetChildIndex(Me.BtnExit, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.Controls.SetChildIndex(Me.Button5, 0)
        Me.Controls.SetChildIndex(Me.Button6, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ThisFrmName As New Report.FrmRepItem
        ThisFrmName.TypeOfForm = 1
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ThisFrmName As New Report.FrmRepItem
        ThisFrmName.TypeOfForm = 2
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ThisFrmName As New Report.FrmRepItem
        ThisFrmName.TypeOfForm = 3
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ThisFrmName As New Report.FrmRepItem
        ThisFrmName.TypeOfForm = 4
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim ThisFrmName As New Report.FrmRepItem
        ThisFrmName.TypeOfForm = 5
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim ThisFrmName As New Report.FrmRepItem
        ThisFrmName.TypeOfForm = 6
        SHOWMYFORM(ThisFrmName)
    End Sub
End Class
