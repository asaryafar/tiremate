Imports CommonClass
Public Class FrmPhoneScreen
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
    Public CmbType1Var As String
    Public CmbType2Var As String
    Public CmbType3Var As String
    Public CmbType4Var As String
    Public CmbType5Var As String
    Public NumExt1Var As String
    Public NumExt2Var As String
    Public NumExt3Var As String
    Public NumExt4Var As String
    Public NumExt5Var As String
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
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Public WithEvents DsFrmPhoneScreen1 As DSFrmPhoneScreen
    Friend WithEvents CmbType1 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbType2 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbType3 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbType4 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbType5 As System.Windows.Forms.ComboBox
    Friend WithEvents NumExt1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents NumExt2 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents NumExt3 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents NumExt4 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents NumExt5 As Janus.Windows.GridEX.EditControls.EditBox
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPhoneScreen))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltype = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumExt1 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.CmbType1 = New System.Windows.Forms.ComboBox
        Me.DsFrmPhoneScreen1 = New UCPhone.DSFrmPhoneScreen
        Me.CmbType2 = New System.Windows.Forms.ComboBox
        Me.NumExt2 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.CmbType3 = New System.Windows.Forms.ComboBox
        Me.NumExt3 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.CmbType4 = New System.Windows.Forms.ComboBox
        Me.NumExt4 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.CmbType5 = New System.Windows.Forms.ComboBox
        Me.NumExt5 = New Janus.Windows.GridEX.EditControls.EditBox
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
        Me.Panel9.SuspendLayout()
        CType(Me.DsFrmPhoneScreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSearch.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 334
        Me.Label2.Text = "Ext."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltype
        '
        Me.lbltype.BackColor = System.Drawing.Color.Transparent
        Me.lbltype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbltype.Location = New System.Drawing.Point(185, 79)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(38, 14)
        Me.lbltype.TabIndex = 335
        Me.lbltype.Text = "Type"
        Me.lbltype.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'NumExt1
        '
        Me.NumExt1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumExt1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumExt1.Location = New System.Drawing.Point(108, 96)
        Me.NumExt1.MaxLength = 4
        Me.NumExt1.Name = "NumExt1"
        Me.NumExt1.Size = New System.Drawing.Size(34, 20)
        Me.NumExt1.TabIndex = 1
        Me.NumExt1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbType1
        '
        Me.CmbType1.BackColor = System.Drawing.SystemColors.Window
        Me.CmbType1.DataSource = Me.DsFrmPhoneScreen1.bas_tab_phone_type1
        Me.CmbType1.DisplayMember = "desc_type_phone"
        Me.CmbType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbType1.ItemHeight = 13
        Me.CmbType1.Location = New System.Drawing.Point(151, 96)
        Me.CmbType1.Name = "CmbType1"
        Me.CmbType1.Size = New System.Drawing.Size(136, 21)
        Me.CmbType1.TabIndex = 2
        Me.CmbType1.ValueMember = "cod_type_phone"
        '
        'DsFrmPhoneScreen1
        '
        Me.DsFrmPhoneScreen1.DataSetName = "DSFrmPhoneScreen"
        Me.DsFrmPhoneScreen1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbType2
        '
        Me.CmbType2.BackColor = System.Drawing.SystemColors.Window
        Me.CmbType2.DataSource = Me.DsFrmPhoneScreen1.bas_tab_phone_type2
        Me.CmbType2.DisplayMember = "desc_type_phone"
        Me.CmbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbType2.ItemHeight = 13
        Me.CmbType2.Location = New System.Drawing.Point(151, 122)
        Me.CmbType2.Name = "CmbType2"
        Me.CmbType2.Size = New System.Drawing.Size(136, 21)
        Me.CmbType2.TabIndex = 6
        Me.CmbType2.ValueMember = "cod_type_phone"
        '
        'NumExt2
        '
        Me.NumExt2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumExt2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumExt2.Location = New System.Drawing.Point(108, 122)
        Me.NumExt2.MaxLength = 4
        Me.NumExt2.Name = "NumExt2"
        Me.NumExt2.Size = New System.Drawing.Size(34, 20)
        Me.NumExt2.TabIndex = 5
        Me.NumExt2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbType3
        '
        Me.CmbType3.BackColor = System.Drawing.SystemColors.Window
        Me.CmbType3.DataSource = Me.DsFrmPhoneScreen1.bas_tab_phone_type3
        Me.CmbType3.DisplayMember = "desc_type_phone"
        Me.CmbType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbType3.ItemHeight = 13
        Me.CmbType3.Location = New System.Drawing.Point(151, 147)
        Me.CmbType3.Name = "CmbType3"
        Me.CmbType3.Size = New System.Drawing.Size(136, 21)
        Me.CmbType3.TabIndex = 10
        Me.CmbType3.ValueMember = "cod_type_phone"
        '
        'NumExt3
        '
        Me.NumExt3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumExt3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumExt3.Location = New System.Drawing.Point(108, 147)
        Me.NumExt3.MaxLength = 4
        Me.NumExt3.Name = "NumExt3"
        Me.NumExt3.Size = New System.Drawing.Size(34, 20)
        Me.NumExt3.TabIndex = 9
        Me.NumExt3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbType4
        '
        Me.CmbType4.BackColor = System.Drawing.SystemColors.Window
        Me.CmbType4.DataSource = Me.DsFrmPhoneScreen1.bas_tab_phone_type4
        Me.CmbType4.DisplayMember = "desc_type_phone"
        Me.CmbType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbType4.ItemHeight = 13
        Me.CmbType4.Location = New System.Drawing.Point(151, 172)
        Me.CmbType4.Name = "CmbType4"
        Me.CmbType4.Size = New System.Drawing.Size(136, 21)
        Me.CmbType4.TabIndex = 14
        Me.CmbType4.ValueMember = "cod_type_phone"
        '
        'NumExt4
        '
        Me.NumExt4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumExt4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumExt4.Location = New System.Drawing.Point(108, 172)
        Me.NumExt4.MaxLength = 4
        Me.NumExt4.Name = "NumExt4"
        Me.NumExt4.Size = New System.Drawing.Size(34, 20)
        Me.NumExt4.TabIndex = 13
        Me.NumExt4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbType5
        '
        Me.CmbType5.BackColor = System.Drawing.SystemColors.Window
        Me.CmbType5.DataSource = Me.DsFrmPhoneScreen1.bas_tab_phone_type5
        Me.CmbType5.DisplayMember = "desc_type_phone"
        Me.CmbType5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbType5.ItemHeight = 13
        Me.CmbType5.Location = New System.Drawing.Point(151, 199)
        Me.CmbType5.Name = "CmbType5"
        Me.CmbType5.Size = New System.Drawing.Size(136, 21)
        Me.CmbType5.TabIndex = 18
        Me.CmbType5.ValueMember = "cod_type_phone"
        '
        'NumExt5
        '
        Me.NumExt5.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumExt5.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumExt5.Location = New System.Drawing.Point(108, 199)
        Me.NumExt5.MaxLength = 4
        Me.NumExt5.Name = "NumExt5"
        Me.NumExt5.Size = New System.Drawing.Size(34, 20)
        Me.NumExt5.TabIndex = 17
        Me.NumExt5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
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
        Me.UcPhoneNo2.TabIndex = 4
        '
        'UcPhoneNo3
        '
        Me.UcPhoneNo3.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo3.Location = New System.Drawing.Point(6, 147)
        Me.UcPhoneNo3.Name = "UcPhoneNo3"
        Me.UcPhoneNo3.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo3.TabIndex = 8
        '
        'UcPhoneNo4
        '
        Me.UcPhoneNo4.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo4.Location = New System.Drawing.Point(6, 172)
        Me.UcPhoneNo4.Name = "UcPhoneNo4"
        Me.UcPhoneNo4.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo4.TabIndex = 12
        '
        'UcPhoneNo5
        '
        Me.UcPhoneNo5.BackColor = System.Drawing.SystemColors.Window
        Me.UcPhoneNo5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPhoneNo5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcPhoneNo5.Location = New System.Drawing.Point(6, 199)
        Me.UcPhoneNo5.Name = "UcPhoneNo5"
        Me.UcPhoneNo5.Size = New System.Drawing.Size(94, 16)
        Me.UcPhoneNo5.TabIndex = 16
        '
        'RdoMain1
        '
        Me.RdoMain1.Checked = True
        Me.RdoMain1.Location = New System.Drawing.Point(298, 97)
        Me.RdoMain1.Name = "RdoMain1"
        Me.RdoMain1.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain1.TabIndex = 338
        Me.RdoMain1.TabStop = True
        '
        'RdoMain2
        '
        Me.RdoMain2.Location = New System.Drawing.Point(298, 123)
        Me.RdoMain2.Name = "RdoMain2"
        Me.RdoMain2.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain2.TabIndex = 339
        '
        'RdoMain3
        '
        Me.RdoMain3.Location = New System.Drawing.Point(298, 149)
        Me.RdoMain3.Name = "RdoMain3"
        Me.RdoMain3.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain3.TabIndex = 340
        '
        'RdoMain4
        '
        Me.RdoMain4.Location = New System.Drawing.Point(298, 175)
        Me.RdoMain4.Name = "RdoMain4"
        Me.RdoMain4.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain4.TabIndex = 341
        '
        'RdoMain5
        '
        Me.RdoMain5.Location = New System.Drawing.Point(298, 201)
        Me.RdoMain5.Name = "RdoMain5"
        Me.RdoMain5.Size = New System.Drawing.Size(13, 18)
        Me.RdoMain5.TabIndex = 342
        '
        'FrmPhoneScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(322, 224)
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
        Me.Controls.Add(Me.CmbType5)
        Me.Controls.Add(Me.NumExt5)
        Me.Controls.Add(Me.CmbType4)
        Me.Controls.Add(Me.NumExt4)
        Me.Controls.Add(Me.CmbType3)
        Me.Controls.Add(Me.NumExt3)
        Me.Controls.Add(Me.CmbType2)
        Me.Controls.Add(Me.NumExt2)
        Me.Controls.Add(Me.CmbType1)
        Me.Controls.Add(Me.NumExt1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "FrmPhoneScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Phone Screen"
        Me.Panel9.ResumeLayout(False)
        CType(Me.DsFrmPhoneScreen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPhoneScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        NumExt1.Text = NumExt1Var
        NumExt2.Text = NumExt2Var
        NumExt3.Text = NumExt3Var
        NumExt4.Text = NumExt4Var
        NumExt5.Text = NumExt5Var
        CmbType1.SelectedValue = CmbType1Var
        CmbType2.SelectedValue = CmbType2Var
        CmbType3.SelectedValue = CmbType3Var
        CmbType4.SelectedValue = CmbType4Var
        CmbType5.SelectedValue = CmbType5Var
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
        CmbType1.Enabled = InStatus
        CmbType2.Enabled = InStatus
        CmbType3.Enabled = InStatus
        CmbType4.Enabled = InStatus
        CmbType5.Enabled = InStatus
        NumExt1.Enabled = InStatus
        NumExt2.Enabled = InStatus
        NumExt3.Enabled = InStatus
        NumExt4.Enabled = InStatus
        NumExt5.Enabled = InStatus
    End Sub
    Private Sub FrmPhoneScreen_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
        NumExt1Var = NumExt1.Text
        NumExt2Var = NumExt2.Text
        NumExt3Var = NumExt3.Text
        NumExt4Var = NumExt4.Text
        NumExt5Var = NumExt5.Text
        CmbType1Var = CmbType1.SelectedValue
        CmbType2Var = CmbType2.SelectedValue
        CmbType3Var = CmbType3.SelectedValue
        CmbType4Var = CmbType4.SelectedValue
        CmbType5Var = CmbType5.SelectedValue
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            RaiseEvent PhoneScreenAfterClose()
        End If
    End Sub
    Private Sub NumExt1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumExt1.GotFocus
        NumExt1.SelectionStart = 0
        NumExt1.SelectionLength = NumExt1.MaxLength
    End Sub
    Private Sub NumExt2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumExt2.GotFocus
        NumExt2.SelectionStart = 0
        NumExt2.SelectionLength = NumExt2.MaxLength
    End Sub
    Private Sub NumExt3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumExt3.GotFocus
        NumExt3.SelectionStart = 0
        NumExt3.SelectionLength = NumExt3.MaxLength
    End Sub
    Private Sub NumExt4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumExt4.GotFocus
        NumExt4.SelectionStart = 0
        NumExt4.SelectionLength = NumExt4.MaxLength
    End Sub
    Private Sub NumExt5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumExt5.GotFocus
        NumExt5.SelectionStart = 0
        NumExt5.SelectionLength = NumExt5.MaxLength
    End Sub
End Class
