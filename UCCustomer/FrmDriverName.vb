Imports CommonClass
Public Class FrmDriverName
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtdriver_name1 As System.Windows.Forms.TextBox
    Public WithEvents txtdriver_name2 As System.Windows.Forms.TextBox
    Public WithEvents txtdriver_name3 As System.Windows.Forms.TextBox
    Public WithEvents txtdriver_name4 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDriverName))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdriver_name1 = New System.Windows.Forms.TextBox
        Me.txtdriver_name2 = New System.Windows.Forms.TextBox
        Me.txtdriver_name3 = New System.Windows.Forms.TextBox
        Me.txtdriver_name4 = New System.Windows.Forms.TextBox
        Me.Panel9.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(118, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "Driver's Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.PictureBox2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(322, 49)
        Me.Panel9.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 47)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Driver Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(246, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 197
        Me.PictureBox2.TabStop = False
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.YellowGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.TxtName)
        Me.PnlSearch.Controls.Add(Me.Label3)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 49)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(322, 29)
        Me.PnlSearch.TabIndex = 337
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName.Location = New System.Drawing.Point(85, 2)
        Me.TxtName.MaxLength = 50
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(228, 21)
        Me.TxtName.TabIndex = 331
        Me.TxtName.TabStop = False
        Me.TxtName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(1, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "Customer Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdriver_name1
        '
        Me.txtdriver_name1.Location = New System.Drawing.Point(15, 105)
        Me.txtdriver_name1.MaxLength = 25
        Me.txtdriver_name1.Name = "txtdriver_name1"
        Me.txtdriver_name1.Size = New System.Drawing.Size(292, 21)
        Me.txtdriver_name1.TabIndex = 0
        Me.txtdriver_name1.Text = ""
        '
        'txtdriver_name2
        '
        Me.txtdriver_name2.Location = New System.Drawing.Point(15, 140)
        Me.txtdriver_name2.MaxLength = 25
        Me.txtdriver_name2.Name = "txtdriver_name2"
        Me.txtdriver_name2.Size = New System.Drawing.Size(292, 21)
        Me.txtdriver_name2.TabIndex = 1
        Me.txtdriver_name2.Text = ""
        '
        'txtdriver_name3
        '
        Me.txtdriver_name3.Location = New System.Drawing.Point(15, 175)
        Me.txtdriver_name3.MaxLength = 25
        Me.txtdriver_name3.Name = "txtdriver_name3"
        Me.txtdriver_name3.Size = New System.Drawing.Size(292, 21)
        Me.txtdriver_name3.TabIndex = 2
        Me.txtdriver_name3.Text = ""
        '
        'txtdriver_name4
        '
        Me.txtdriver_name4.Location = New System.Drawing.Point(15, 210)
        Me.txtdriver_name4.MaxLength = 25
        Me.txtdriver_name4.Name = "txtdriver_name4"
        Me.txtdriver_name4.Size = New System.Drawing.Size(292, 21)
        Me.txtdriver_name4.TabIndex = 3
        Me.txtdriver_name4.Text = ""
        '
        'FrmDriverName
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(322, 242)
        Me.Controls.Add(Me.txtdriver_name4)
        Me.Controls.Add(Me.txtdriver_name3)
        Me.Controls.Add(Me.txtdriver_name2)
        Me.Controls.Add(Me.txtdriver_name1)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "FrmDriverName"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Driver Name Screen"
        Me.Panel9.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmChangeServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            Call DisableEnableAll(False)
        Else
            Call DisableEnableAll(True)
        End If
    End Sub
    Private Sub DisableEnableAll(ByVal InStatus As Boolean)
        txtdriver_name1.Enabled = InStatus
        txtdriver_name2.Enabled = InStatus
        txtdriver_name3.Enabled = InStatus
        txtdriver_name4.Enabled = InStatus
    End Sub
End Class
