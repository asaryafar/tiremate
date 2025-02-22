Imports CommonClass
Public Class FrmCompanySetup
    Inherits FrmBase
    Friend Status As WorkStates = MainModule.WorkStates.Edit
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CnnMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents TXTName As System.Windows.Forms.TextBox
    Friend WithEvents TxtMotto As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtFEDERAL_TAX_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtSTATE_TAX_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtSALES_TAX_ID As System.Windows.Forms.TextBox
    Friend WithEvents WebSiteAddress1 As EmailAndWebAddress.WebSiteAddress
    Friend WithEvents EmailAddress1 As EmailAndWebAddress.EmailAddress
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents TxtSt As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TXTCity As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureButton1 As UCPicture.PictureButton
    Friend WithEvents CmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents PhoneNo2 As UCPhone.PhoneNo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents DsFrmCompanySetup1 As SetupTables.DSFrmCompanySetup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCompanySetup))
        Me.Label12 = New System.Windows.Forms.Label
        Me.TXTName = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CnnMDB = New System.Data.OleDb.OleDbConnection
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtMotto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtFEDERAL_TAX_ID = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtSTATE_TAX_ID = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtSALES_TAX_ID = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.WebSiteAddress1 = New EmailAndWebAddress.WebSiteAddress
        Me.EmailAddress1 = New EmailAndWebAddress.EmailAddress
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.TxtSt = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TXTCity = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PictureButton1 = New UCPicture.PictureButton
        Me.CmbMonth = New System.Windows.Forms.ComboBox
        Me.DsFrmCompanySetup1 = New SetupTables.DSFrmCompanySetup
        Me.CmdGeneralForMDB = New System.Data.OleDb.OleDbCommand
        Me.PhoneNo2 = New UCPhone.PhoneNo
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmCompanySetup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(4, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 19)
        Me.Label12.TabIndex = 358
        Me.Label12.Text = "Company"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTName
        '
        Me.TXTName.BackColor = System.Drawing.SystemColors.Window
        Me.TXTName.Location = New System.Drawing.Point(141, 67)
        Me.TXTName.MaxLength = 50
        Me.TXTName.Name = "TXTName"
        Me.TXTName.Size = New System.Drawing.Size(354, 20)
        Me.TXTName.TabIndex = 0
        Me.TXTName.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 62)
        Me.Panel1.TabIndex = 365
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(83, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(416, 58)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Company Setup "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'CnnMDB
        '
        Me.CnnMDB.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\TireMate\TireMatesetu" & _
        "p.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Pr" & _
        "ovider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;" & _
        "Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet O" & _
        "LEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;J" & _
        "et OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Da" & _
        "tabase=False"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(4, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Phone"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtMotto
        '
        Me.TxtMotto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMotto.Location = New System.Drawing.Point(141, 155)
        Me.TxtMotto.MaxLength = 100
        Me.TxtMotto.Name = "TxtMotto"
        Me.TxtMotto.Size = New System.Drawing.Size(354, 20)
        Me.TxtMotto.TabIndex = 5
        Me.TxtMotto.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(4, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 371
        Me.Label3.Text = "Sale Motto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(4, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 373
        Me.Label4.Text = "Email"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(4, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 19)
        Me.Label5.TabIndex = 375
        Me.Label5.Text = "Web Page"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAddress.Location = New System.Drawing.Point(141, 91)
        Me.TxtAddress.MaxLength = 100
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(354, 20)
        Me.TxtAddress.TabIndex = 1
        Me.TxtAddress.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(4, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 19)
        Me.Label7.TabIndex = 377
        Me.Label7.Text = "Address"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFEDERAL_TAX_ID
        '
        Me.TxtFEDERAL_TAX_ID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFEDERAL_TAX_ID.Location = New System.Drawing.Point(141, 268)
        Me.TxtFEDERAL_TAX_ID.MaxLength = 20
        Me.TxtFEDERAL_TAX_ID.Name = "TxtFEDERAL_TAX_ID"
        Me.TxtFEDERAL_TAX_ID.Size = New System.Drawing.Size(234, 20)
        Me.TxtFEDERAL_TAX_ID.TabIndex = 10
        Me.TxtFEDERAL_TAX_ID.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(4, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 20)
        Me.Label8.TabIndex = 379
        Me.Label8.Text = "Federal Tax ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(4, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 19)
        Me.Label9.TabIndex = 381
        Me.Label9.Text = "Fiscal Year Starts in"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(4, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 19)
        Me.Label10.TabIndex = 383
        Me.Label10.Text = "Company Logo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSTATE_TAX_ID
        '
        Me.TxtSTATE_TAX_ID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSTATE_TAX_ID.Location = New System.Drawing.Point(141, 291)
        Me.TxtSTATE_TAX_ID.MaxLength = 20
        Me.TxtSTATE_TAX_ID.Name = "TxtSTATE_TAX_ID"
        Me.TxtSTATE_TAX_ID.Size = New System.Drawing.Size(234, 20)
        Me.TxtSTATE_TAX_ID.TabIndex = 11
        Me.TxtSTATE_TAX_ID.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(4, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 19)
        Me.Label11.TabIndex = 385
        Me.Label11.Text = "States Tax ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSALES_TAX_ID
        '
        Me.TxtSALES_TAX_ID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSALES_TAX_ID.Location = New System.Drawing.Point(141, 313)
        Me.TxtSALES_TAX_ID.MaxLength = 20
        Me.TxtSALES_TAX_ID.Name = "TxtSALES_TAX_ID"
        Me.TxtSALES_TAX_ID.Size = New System.Drawing.Size(234, 20)
        Me.TxtSALES_TAX_ID.TabIndex = 12
        Me.TxtSALES_TAX_ID.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(4, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 19)
        Me.Label13.TabIndex = 387
        Me.Label13.Text = "Sales Tax ID"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WebSiteAddress1
        '
        Me.WebSiteAddress1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.WebSiteAddress1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.WebSiteAddress1.ErrorColor = System.Drawing.Color.Red
        Me.WebSiteAddress1.ErrorMessage = "www.microsoft.com ÂÏÑÓ æÈ ÓÇíÊ ÈÇíÓÊí Èå Çíä ÕæÑÊ ÈÇÔÏ"
        Me.WebSiteAddress1.Location = New System.Drawing.Point(141, 200)
        Me.WebSiteAddress1.Name = "WebSiteAddress1"
        Me.WebSiteAddress1.Size = New System.Drawing.Size(286, 20)
        Me.WebSiteAddress1.TabIndex = 7
        Me.WebSiteAddress1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.WebSiteAddress1.ValidationExpression = "([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"
        '
        'EmailAddress1
        '
        Me.EmailAddress1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.EmailAddress1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.EmailAddress1.ErrorColor = System.Drawing.Color.Red
        Me.EmailAddress1.ErrorMessage = "abc@microsoft.com ÂÏÑÓ ÓÊ Çá˜ÊÑæäí˜í ÈÇíÓÊí Èå Çíä ÕæÑÊ ÈÇÔÏ"
        Me.EmailAddress1.Location = New System.Drawing.Point(141, 177)
        Me.EmailAddress1.MaxLength = 50
        Me.EmailAddress1.Name = "EmailAddress1"
        Me.EmailAddress1.Size = New System.Drawing.Size(286, 20)
        Me.EmailAddress1.TabIndex = 6
        Me.EmailAddress1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.EmailAddress1.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0" & _
        "-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-" & _
        "9][0-9]|[1-9][0-9]|[0-9])\])$"
        '
        'PhoneNo1
        '
        Me.PhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNo1.Location = New System.Drawing.Point(141, 136)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(94, 16)
        Me.PhoneNo1.TabIndex = 3
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Location = New System.Drawing.Point(305, 114)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(59, 20)
        Me.ZipCode1.TabIndex = 2
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'TxtSt
        '
        Me.TxtSt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSt.Location = New System.Drawing.Point(272, 114)
        Me.TxtSt.MaxLength = 20
        Me.TxtSt.Name = "TxtSt"
        Me.TxtSt.ReadOnly = True
        Me.TxtSt.Size = New System.Drawing.Size(33, 20)
        Me.TxtSt.TabIndex = 394
        Me.TxtSt.TabStop = False
        Me.TxtSt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TXTCity
        '
        Me.TXTCity.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTCity.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTCity.Location = New System.Drawing.Point(141, 114)
        Me.TXTCity.MaxLength = 5
        Me.TXTCity.Name = "TXTCity"
        Me.TXTCity.ReadOnly = True
        Me.TXTCity.Size = New System.Drawing.Size(131, 20)
        Me.TXTCity.TabIndex = 393
        Me.TXTCity.TabStop = False
        Me.TXTCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(54, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 20)
        Me.Label15.TabIndex = 395
        Me.Label15.Text = "City, St. ZIP"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureButton1
        '
        Me.PictureButton1.Location = New System.Drawing.Point(141, 222)
        Me.PictureButton1.MyPicture = Nothing
        Me.PictureButton1.Name = "PictureButton1"
        Me.PictureButton1.Size = New System.Drawing.Size(79, 21)
        Me.PictureButton1.TabIndex = 8
        '
        'CmbMonth
        '
        Me.CmbMonth.DataSource = Me.DsFrmCompanySetup1.Month
        Me.CmbMonth.DisplayMember = "MonthName"
        Me.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMonth.Location = New System.Drawing.Point(141, 247)
        Me.CmbMonth.Name = "CmbMonth"
        Me.CmbMonth.Size = New System.Drawing.Size(144, 21)
        Me.CmbMonth.TabIndex = 9
        Me.CmbMonth.ValueMember = "MonthId"
        '
        'DsFrmCompanySetup1
        '
        Me.DsFrmCompanySetup1.DataSetName = "DSFrmCompanySetup"
        Me.DsFrmCompanySetup1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdGeneralForMDB
        '
        Me.CmdGeneralForMDB.Connection = Me.CnnMDB
        '
        'PhoneNo2
        '
        Me.PhoneNo2.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNo2.Location = New System.Drawing.Point(272, 136)
        Me.PhoneNo2.Name = "PhoneNo2"
        Me.PhoneNo2.Size = New System.Drawing.Size(94, 16)
        Me.PhoneNo2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(246, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 19)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Fax"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.SystemColors.Info
        Me.BtnOk.Enabled = False
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.Location = New System.Drawing.Point(409, 339)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(73, 27)
        Me.BtnOk.TabIndex = 399
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.Info
        Me.BtnExit.Enabled = False
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(21, 339)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(73, 27)
        Me.BtnExit.TabIndex = 400
        '
        'FrmCompanySetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(503, 371)
        Me.Controls.Add(Me.CmbMonth)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PhoneNo2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureButton1)
        Me.Controls.Add(Me.ZipCode1)
        Me.Controls.Add(Me.TxtSt)
        Me.Controls.Add(Me.TXTCity)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PhoneNo1)
        Me.Controls.Add(Me.EmailAddress1)
        Me.Controls.Add(Me.WebSiteAddress1)
        Me.Controls.Add(Me.TxtSALES_TAX_ID)
        Me.Controls.Add(Me.TxtSTATE_TAX_ID)
        Me.Controls.Add(Me.TxtFEDERAL_TAX_ID)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtMotto)
        Me.Controls.Add(Me.TXTName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Name = "FrmCompanySetup"
        Me.Text = "Company Setup "
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsFrmCompanySetup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCompanySetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables
        Dim i As Integer
        For i = 1 To 12
            DsFrmCompanySetup1.Month.AddMonthRow(MonthName(i), i)
        Next

        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveCompanySetupTable()
        TxtAddress.Text = OleDbReader.Item("Address") & ""
        TxtFEDERAL_TAX_ID.Text = OleDbReader.Item("FEDERAL_TAX_ID") & ""
        TxtMotto.Text = OleDbReader.Item("Motto") & ""
        TXTName.Text = OleDbReader.Item("Name") & ""
        TxtSALES_TAX_ID.Text = OleDbReader.Item("SALES_TAX_ID") & ""
        TxtSTATE_TAX_ID.Text = OleDbReader.Item("STATE_TAX_ID") & ""

        Try
            CmbMonth.SelectedValue = OleDbReader.Item("FISCAL_MONTH")
        Catch ex As Exception
            CmbMonth.SelectedValue = 1
        End Try

        ZipCode1.Text = OleDbReader.Item("ZIP_CODE") & ""

        PhoneNo1.Text = OleDbReader.Item("PHONE") & ""
        PhoneNo2.Text = OleDbReader.Item("Fax") & ""

        EmailAddress1.Text = OleDbReader.Item("EMAIL") & ""
        WebSiteAddress1.Text = OleDbReader.Item("WEBPAGE") & ""

        Try
            PictureButton1.MyPicture = OleDbReader.Item("LOGO")
        Catch ex As Exception
            PictureButton1.MyPicture = Nothing
        End Try

        OleDbReader.Close()
        CmdGeneralForMDB.Connection.Close()
        BtnOk.Enabled = False
        BtnExit.Enabled = True
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Call SaveData()
        BtnOk.Enabled = False
    End Sub
    Private Sub TXTManagerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged, TxtFEDERAL_TAX_ID.TextChanged, TxtMotto.TextChanged, TXTName.TextChanged, TxtSALES_TAX_ID.TextChanged, TxtSTATE_TAX_ID.TextChanged, WebSiteAddress1.TextChanged, ZipCode1.TextChanged, EmailAddress1.TextChanged, PhoneNo1.TextChanged, PhoneNo2.TextChanged, CmbMonth.SelectedIndexChanged
        Call SaveButtonControl()
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        TXTCity.Text = ZipCode1.City
        TxtSt.Text = ZipCode1.State
    End Sub
    Private Sub ZipCode1_NotFindZipCode() Handles ZipCode1.NotFindZipCode
        TXTCity.Text = ""
        TxtSt.Text = ""
    End Sub
    Private Sub PictureButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureButton1.Click
        PictureButton1.status = Status
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Then
            If TXTName.Text.Trim.Length > 0 Then
                BtnOk.Enabled = True
            Else
                BtnOk.Enabled = False
            End If
        End If
    End Sub
    Private Sub FrmCompanySetup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If BtnOk.Enabled Then
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Exit"
            c1.BtnRightText = "Save"
            c1.ShowFarMsg("Do tou want save data?")
            If c1.DialogResult = DialogResult.OK Then
                Call SaveData()
            End If
        End If
    End Sub
    Private Sub SaveData()
        If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDB.Connection.Open()
        End If
        CmdGeneralForMDB.CommandText = "Update COMPANY_SETUP SET Name=" & Qt(TXTName.Text) & ",Address=" & Qt(TxtAddress.Text) & ",Zip_Code=" & Qt(ZipCode1.Text) & ",Phone=" & Qt(PhoneNo1.Text) & ",Fax=" & Qt(PhoneNo2.Text) & ",Motto=" & Qt(TxtMotto.Text) & ",Email=" & Qt(EmailAddress1.Text) & ",Webpage=" & Qt(WebSiteAddress1.Text) & ",Fiscal_month=" & CmbMonth.SelectedValue & ",FEDERAL_TAX_ID=" & Qt(TxtFEDERAL_TAX_ID.Text) & ",STATE_TAX_ID=" & Qt(TxtSTATE_TAX_ID.Text) & ",SALES_TAX_ID=" & Qt(TxtSALES_TAX_ID.Text)
        CmdGeneralForMDB.ExecuteNonQuery()
        CmdGeneralForMDB.Connection.Close()
        PictureButton1.SavePicture(Cnn, "COMPANY_SETUP", "LOGO", "", CnnMDB)
    End Sub
End Class
