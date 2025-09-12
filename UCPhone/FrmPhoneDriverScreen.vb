Imports CommonClass
Public Class FrmPhoneDriverScreen
    Inherits FrmBase
    Public Event PhoneScreenAfterClose()
    Public UcPhoneNo1Var As String
    Public UcPhoneNo2Var As String
    Public UcPhoneNo3Var As String
    Public UcPhoneNo4Var As String
    Public UcPhoneNo5Var As String
    Public RdoMain1Var As Boolean
    Public RdoMain2Var As Boolean
    Public RdoMain3Var As Boolean
    Public RdoMain4Var As Boolean
    Public RdoMain5Var As Boolean

    Public UcDriverName1 As String
    Public UcDriverName2 As String
    Public UcDriverName3 As String
    Public UcDriverName4 As String
    Public UcDriverName5 As String

    Public Changed As Boolean
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents UcPhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents UcPhoneNo2 As UCPhone.PhoneNo
    Friend WithEvents UcPhoneNo3 As UCPhone.PhoneNo
    Friend WithEvents UcPhoneNo4 As UCPhone.PhoneNo
    Friend WithEvents UcPhoneNo5 As UCPhone.PhoneNo
    Friend WithEvents RdoMain1 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoMain2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoMain3 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoMain4 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoMain5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtdriver_name4 As System.Windows.Forms.TextBox
    Public WithEvents txtdriver_name3 As System.Windows.Forms.TextBox
    Public WithEvents txtdriver_name2 As System.Windows.Forms.TextBox
    Public WithEvents txtdriver_name1 As System.Windows.Forms.TextBox
    Public WithEvents txtdriver_name5 As System.Windows.Forms.TextBox
    Public WithEvents DsFrmPhoneScreen1 As UCPhone.DSFrmPhoneScreen
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPhoneDriverScreen))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.UcPhoneNo1 = New UCPhone.PhoneNo
        Me.UcPhoneNo2 = New UCPhone.PhoneNo
        Me.UcPhoneNo3 = New UCPhone.PhoneNo
        Me.UcPhoneNo4 = New UCPhone.PhoneNo
        Me.UcPhoneNo5 = New UCPhone.PhoneNo
        Me.RdoMain1 = New System.Windows.Forms.RadioButton
        Me.RdoMain2 = New System.Windows.Forms.RadioButton
        Me.RdoMain3 = New System.Windows.Forms.RadioButton
        Me.RdoMain4 = New System.Windows.Forms.RadioButton
        Me.RdoMain5 = New System.Windows.Forms.RadioButton
        Me.txtdriver_name4 = New System.Windows.Forms.TextBox
        Me.txtdriver_name3 = New System.Windows.Forms.TextBox
        Me.txtdriver_name2 = New System.Windows.Forms.TextBox
        Me.txtdriver_name1 = New System.Windows.Forms.TextBox
        Me.txtdriver_name5 = New System.Windows.Forms.TextBox
        Me.DsFrmPhoneScreen1 = New UCPhone.DSFrmPhoneScreen
        Me.Panel9.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmPhoneScreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(26, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "Phone No"
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
        Me.Panel9.Size = New System.Drawing.Size(322, 45)
        Me.Panel9.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 43)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Phone no"
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
        Me.PictureBox2.Size = New System.Drawing.Size(74, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 197
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(111, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 14)
        Me.Label2.TabIndex = 334
        Me.Label2.Text = "Driver Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(287, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 336
        Me.Label4.Text = "Main"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.YellowGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.TxtName)
        Me.PnlSearch.Controls.Add(Me.Label3)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(322, 27)
        Me.PnlSearch.TabIndex = 337
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName.Location = New System.Drawing.Point(45, 2)
        Me.TxtName.MaxLength = 50
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(257, 21)
        Me.TxtName.TabIndex = 331
        Me.TxtName.TabStop = False
        Me.TxtName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(7, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcPhoneNo1
        '
        Me.UcPhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo1.Location = New System.Drawing.Point(6, 96)
        Me.UcPhoneNo1.Name = "UcPhoneNo1"
        Me.UcPhoneNo1.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo1.TabIndex = 0
        '
        'UcPhoneNo2
        '
        Me.UcPhoneNo2.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo2.Location = New System.Drawing.Point(6, 122)
        Me.UcPhoneNo2.Name = "UcPhoneNo2"
        Me.UcPhoneNo2.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo2.TabIndex = 3
        '
        'UcPhoneNo3
        '
        Me.UcPhoneNo3.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo3.Location = New System.Drawing.Point(6, 147)
        Me.UcPhoneNo3.Name = "UcPhoneNo3"
        Me.UcPhoneNo3.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo3.TabIndex = 6
        '
        'UcPhoneNo4
        '
        Me.UcPhoneNo4.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo4.Location = New System.Drawing.Point(6, 172)
        Me.UcPhoneNo4.Name = "UcPhoneNo4"
        Me.UcPhoneNo4.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo4.TabIndex = 9
        '
        'UcPhoneNo5
        '
        Me.UcPhoneNo5.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo5.Location = New System.Drawing.Point(6, 199)
        Me.UcPhoneNo5.Name = "UcPhoneNo5"
        Me.UcPhoneNo5.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo5.TabIndex = 12
        '
        'RdoMain1
        '
        Me.RdoMain1.Checked = True
        Me.RdoMain1.Location = New System.Drawing.Point(298, 95)
        Me.RdoMain1.Name = "RdoMain1"
        Me.RdoMain1.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain1.TabIndex = 2
        Me.RdoMain1.TabStop = True
        '
        'RdoMain2
        '
        Me.RdoMain2.Location = New System.Drawing.Point(298, 121)
        Me.RdoMain2.Name = "RdoMain2"
        Me.RdoMain2.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain2.TabIndex = 5
        '
        'RdoMain3
        '
        Me.RdoMain3.Location = New System.Drawing.Point(298, 146)
        Me.RdoMain3.Name = "RdoMain3"
        Me.RdoMain3.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain3.TabIndex = 8
        '
        'RdoMain4
        '
        Me.RdoMain4.Location = New System.Drawing.Point(298, 171)
        Me.RdoMain4.Name = "RdoMain4"
        Me.RdoMain4.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain4.TabIndex = 11
        '
        'RdoMain5
        '
        Me.RdoMain5.Location = New System.Drawing.Point(298, 198)
        Me.RdoMain5.Name = "RdoMain5"
        Me.RdoMain5.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain5.TabIndex = 14
        '
        'txtdriver_name4
        '
        Me.txtdriver_name4.Location = New System.Drawing.Point(105, 170)
        Me.txtdriver_name4.MaxLength = 25
        Me.txtdriver_name4.Name = "txtdriver_name4"
        Me.txtdriver_name4.Size = New System.Drawing.Size(187, 20)
        Me.txtdriver_name4.TabIndex = 10
        Me.txtdriver_name4.Text = ""
        '
        'txtdriver_name3
        '
        Me.txtdriver_name3.Location = New System.Drawing.Point(105, 145)
        Me.txtdriver_name3.MaxLength = 25
        Me.txtdriver_name3.Name = "txtdriver_name3"
        Me.txtdriver_name3.Size = New System.Drawing.Size(187, 20)
        Me.txtdriver_name3.TabIndex = 7
        Me.txtdriver_name3.Text = ""
        '
        'txtdriver_name2
        '
        Me.txtdriver_name2.Location = New System.Drawing.Point(105, 120)
        Me.txtdriver_name2.MaxLength = 25
        Me.txtdriver_name2.Name = "txtdriver_name2"
        Me.txtdriver_name2.Size = New System.Drawing.Size(187, 20)
        Me.txtdriver_name2.TabIndex = 4
        Me.txtdriver_name2.Text = ""
        '
        'txtdriver_name1
        '
        Me.txtdriver_name1.Location = New System.Drawing.Point(105, 94)
        Me.txtdriver_name1.MaxLength = 25
        Me.txtdriver_name1.Name = "txtdriver_name1"
        Me.txtdriver_name1.Size = New System.Drawing.Size(187, 20)
        Me.txtdriver_name1.TabIndex = 1
        Me.txtdriver_name1.Text = ""
        '
        'txtdriver_name5
        '
        Me.txtdriver_name5.Location = New System.Drawing.Point(107, 197)
        Me.txtdriver_name5.MaxLength = 25
        Me.txtdriver_name5.Name = "txtdriver_name5"
        Me.txtdriver_name5.Size = New System.Drawing.Size(187, 20)
        Me.txtdriver_name5.TabIndex = 13
        Me.txtdriver_name5.Text = ""
        '
        'DsFrmPhoneScreen1
        '
        Me.DsFrmPhoneScreen1.DataSetName = "DSFrmPhoneScreen"
        Me.DsFrmPhoneScreen1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'FrmPhoneDriverScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(322, 224)
        Me.Controls.Add(Me.txtdriver_name5)
        Me.Controls.Add(Me.txtdriver_name4)
        Me.Controls.Add(Me.txtdriver_name3)
        Me.Controls.Add(Me.txtdriver_name2)
        Me.Controls.Add(Me.txtdriver_name1)
        Me.Controls.Add(Me.RdoMain5)
        Me.Controls.Add(Me.RdoMain4)
        Me.Controls.Add(Me.RdoMain3)
        Me.Controls.Add(Me.RdoMain2)
        Me.Controls.Add(Me.RdoMain1)
        Me.Controls.Add(Me.UcPhoneNo5)
        Me.Controls.Add(Me.UcPhoneNo4)
        Me.Controls.Add(Me.UcPhoneNo3)
        Me.Controls.Add(Me.UcPhoneNo2)
        Me.Controls.Add(Me.UcPhoneNo1)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "FrmPhoneDriverScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Phone Screen"
        Me.Panel9.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmPhoneScreen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPhoneDriverScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            Call DisableEnableAll(False)
        Else
            Call DisableEnableAll(True)
        End If
        UcPhoneNo1.Text = UcPhoneNo1Var
        UcPhoneNo2.Text = UcPhoneNo2Var
        UcPhoneNo3.Text = UcPhoneNo3Var
        UcPhoneNo4.Text = UcPhoneNo4Var
        UcPhoneNo5.Text = UcPhoneNo5Var
        RdoMain1.Checked = RdoMain1Var
        RdoMain2.Checked = RdoMain2Var
        RdoMain3.Checked = RdoMain3Var
        RdoMain4.Checked = RdoMain4Var
        RdoMain5.Checked = RdoMain5Var
        txtdriver_name1.Text = UcDriverName1
        txtdriver_name2.Text = UcDriverName2
        txtdriver_name3.Text = UcDriverName3
        txtdriver_name4.Text = UcDriverName4
        txtdriver_name5.Text = UcDriverName5

    End Sub
    Private Sub DisableEnableAll(ByVal InStatus As Boolean)
        UcPhoneNo1.Enabled = InStatus
        UcPhoneNo2.Enabled = InStatus
        UcPhoneNo3.Enabled = InStatus
        UcPhoneNo4.Enabled = InStatus
        UcPhoneNo5.Enabled = InStatus
        RdoMain1.Enabled = InStatus
        RdoMain2.Enabled = InStatus
        RdoMain3.Enabled = InStatus
        RdoMain4.Enabled = InStatus
        RdoMain5.Enabled = InStatus
        txtdriver_name1.Enabled = InStatus
        txtdriver_name2.Enabled = InStatus
        txtdriver_name3.Enabled = InStatus
        txtdriver_name4.Enabled = InStatus
        txtdriver_name5.Enabled = InStatus

    End Sub
    Private Sub FrmPhoneDriverScreen_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing


        If (UcPhoneNo1Var = UcPhoneNo1.Text And UcPhoneNo2Var = UcPhoneNo2.Text And UcPhoneNo3Var = UcPhoneNo3.Text And UcPhoneNo4Var = UcPhoneNo4.Text And UcPhoneNo5Var = UcPhoneNo5.Text And RdoMain1Var = RdoMain1.Checked And RdoMain2Var = RdoMain2.Checked And RdoMain3Var = RdoMain3.Checked And RdoMain4Var = RdoMain4.Checked And RdoMain5Var = RdoMain5.Checked And UcDriverName1 = txtdriver_name1.Text And UcDriverName2 = txtdriver_name2.Text And UcDriverName3 = txtdriver_name3.Text And UcDriverName4 = txtdriver_name4.Text And UcDriverName5 = txtdriver_name5.Text) Then
            Changed = False
        Else
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "OK"
            c1.ShowFarMsg("Some Thing Change in This Form. Do you want to Submit it?")
            If c1.DialogResult = DialogResult.OK Then
                Changed = True
            Else
                Changed = False

            End If
        End If



        UcPhoneNo1Var = UcPhoneNo1.Text
        UcPhoneNo2Var = UcPhoneNo2.Text
        UcPhoneNo3Var = UcPhoneNo3.Text
        UcPhoneNo4Var = UcPhoneNo4.Text
        UcPhoneNo5Var = UcPhoneNo5.Text
        RdoMain1Var = RdoMain1.Checked
        RdoMain2Var = RdoMain2.Checked
        RdoMain3Var = RdoMain3.Checked
        RdoMain4Var = RdoMain4.Checked
        RdoMain5Var = RdoMain5.Checked
        UcDriverName1 = txtdriver_name1.Text
        UcDriverName2 = txtdriver_name2.Text
        UcDriverName3 = txtdriver_name3.Text
        UcDriverName4 = txtdriver_name4.Text
        UcDriverName5 = txtdriver_name5.Text

        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            RaiseEvent PhoneScreenAfterClose()
        End If
    End Sub

End Class
