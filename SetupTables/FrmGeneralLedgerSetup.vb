Imports CommonClass
Public Class FrmGeneralLedgerSetup
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CnnMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdGeneralForMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmGeneralLedgerSetup1 As SetupTables.DSFrmGeneralLedgerSetup
    Friend WithEvents Cmbdefault_cash_over As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbdefault_undepositive As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbdefault_depositive As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbdefault_sales_tax As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbdefault_bad_dept As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbdefault_return As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbdefault_inventory_adjment As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDefault_discount_for_sales As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbDefault_discount_for_Purchases As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbdefault_traded_item As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGeneralLedgerSetup))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CnnMDB = New System.Data.OleDb.OleDbConnection
        Me.CmdGeneralForMDB = New System.Data.OleDb.OleDbCommand
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Cmbdefault_traded_item = New System.Windows.Forms.ComboBox
        Me.DsFrmGeneralLedgerSetup1 = New SetupTables.DSFrmGeneralLedgerSetup
        Me.Label10 = New System.Windows.Forms.Label
        Me.CmbDefault_discount_for_Purchases = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbDefault_discount_for_sales = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cmbdefault_return = New System.Windows.Forms.ComboBox
        Me.Cmbdefault_bad_dept = New System.Windows.Forms.ComboBox
        Me.Cmbdefault_inventory_adjment = New System.Windows.Forms.ComboBox
        Me.Cmbdefault_sales_tax = New System.Windows.Forms.ComboBox
        Me.Cmbdefault_undepositive = New System.Windows.Forms.ComboBox
        Me.Cmbdefault_cash_over = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Cmbdefault_depositive = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DsFrmGeneralLedgerSetup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(454, 62)
        Me.Panel1.TabIndex = 365
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(154, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(296, 58)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "General Ledger Setup"
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
        'CmdGeneralForMDB
        '
        Me.CmdGeneralForMDB.Connection = Me.CnnMDB
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.SystemColors.Info
        Me.BtnOk.Enabled = False
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.Location = New System.Drawing.Point(362, 359)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(73, 27)
        Me.BtnOk.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.SystemColors.Info
        Me.BtnExit.Enabled = False
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(22, 359)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(73, 27)
        Me.BtnExit.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(446, 285)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Cmbdefault_traded_item)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.CmbDefault_discount_for_Purchases)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.CmbDefault_discount_for_sales)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Cmbdefault_return)
        Me.TabPage1.Controls.Add(Me.Cmbdefault_bad_dept)
        Me.TabPage1.Controls.Add(Me.Cmbdefault_inventory_adjment)
        Me.TabPage1.Controls.Add(Me.Cmbdefault_sales_tax)
        Me.TabPage1.Controls.Add(Me.Cmbdefault_undepositive)
        Me.TabPage1.Controls.Add(Me.Cmbdefault_cash_over)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Cmbdefault_depositive)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(438, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Defaults"
        '
        'Cmbdefault_traded_item
        '
        Me.Cmbdefault_traded_item.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account9
        Me.Cmbdefault_traded_item.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_traded_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_traded_item.Location = New System.Drawing.Point(234, 231)
        Me.Cmbdefault_traded_item.Name = "Cmbdefault_traded_item"
        Me.Cmbdefault_traded_item.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_traded_item.TabIndex = 374
        Me.Cmbdefault_traded_item.ValueMember = "GL_account"
        '
        'DsFrmGeneralLedgerSetup1
        '
        Me.DsFrmGeneralLedgerSetup1.DataSetName = "DSFrmGeneralLedgerSetup"
        Me.DsFrmGeneralLedgerSetup1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(13, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 19)
        Me.Label10.TabIndex = 375
        Me.Label10.Text = "Traded Item Account No"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDefault_discount_for_Purchases
        '
        Me.CmbDefault_discount_for_Purchases.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account8
        Me.CmbDefault_discount_for_Purchases.DisplayMember = "desc_GL_account"
        Me.CmbDefault_discount_for_Purchases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_discount_for_Purchases.Location = New System.Drawing.Point(234, 206)
        Me.CmbDefault_discount_for_Purchases.Name = "CmbDefault_discount_for_Purchases"
        Me.CmbDefault_discount_for_Purchases.Size = New System.Drawing.Size(185, 21)
        Me.CmbDefault_discount_for_Purchases.TabIndex = 372
        Me.CmbDefault_discount_for_Purchases.ValueMember = "GL_account"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(13, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 19)
        Me.Label9.TabIndex = 373
        Me.Label9.Text = "Discount For purchases Account No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDefault_discount_for_sales
        '
        Me.CmbDefault_discount_for_sales.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account7
        Me.CmbDefault_discount_for_sales.DisplayMember = "desc_GL_account"
        Me.CmbDefault_discount_for_sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_discount_for_sales.Location = New System.Drawing.Point(234, 182)
        Me.CmbDefault_discount_for_sales.Name = "CmbDefault_discount_for_sales"
        Me.CmbDefault_discount_for_sales.Size = New System.Drawing.Size(185, 21)
        Me.CmbDefault_discount_for_sales.TabIndex = 370
        Me.CmbDefault_discount_for_sales.ValueMember = "GL_account"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(13, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 19)
        Me.Label4.TabIndex = 371
        Me.Label4.Text = "Discount For Sales Account No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbdefault_return
        '
        Me.Cmbdefault_return.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account6
        Me.Cmbdefault_return.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_return.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_return.Location = New System.Drawing.Point(234, 157)
        Me.Cmbdefault_return.Name = "Cmbdefault_return"
        Me.Cmbdefault_return.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_return.TabIndex = 6
        Me.Cmbdefault_return.ValueMember = "GL_account"
        '
        'Cmbdefault_bad_dept
        '
        Me.Cmbdefault_bad_dept.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account5
        Me.Cmbdefault_bad_dept.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_bad_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_bad_dept.Location = New System.Drawing.Point(234, 132)
        Me.Cmbdefault_bad_dept.Name = "Cmbdefault_bad_dept"
        Me.Cmbdefault_bad_dept.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_bad_dept.TabIndex = 5
        Me.Cmbdefault_bad_dept.ValueMember = "GL_account"
        '
        'Cmbdefault_inventory_adjment
        '
        Me.Cmbdefault_inventory_adjment.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account4
        Me.Cmbdefault_inventory_adjment.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_inventory_adjment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_inventory_adjment.Location = New System.Drawing.Point(234, 107)
        Me.Cmbdefault_inventory_adjment.Name = "Cmbdefault_inventory_adjment"
        Me.Cmbdefault_inventory_adjment.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_inventory_adjment.TabIndex = 4
        Me.Cmbdefault_inventory_adjment.ValueMember = "GL_account"
        '
        'Cmbdefault_sales_tax
        '
        Me.Cmbdefault_sales_tax.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account3
        Me.Cmbdefault_sales_tax.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_sales_tax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_sales_tax.Location = New System.Drawing.Point(234, 82)
        Me.Cmbdefault_sales_tax.Name = "Cmbdefault_sales_tax"
        Me.Cmbdefault_sales_tax.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_sales_tax.TabIndex = 3
        Me.Cmbdefault_sales_tax.ValueMember = "GL_account"
        '
        'Cmbdefault_undepositive
        '
        Me.Cmbdefault_undepositive.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account1
        Me.Cmbdefault_undepositive.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_undepositive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_undepositive.Location = New System.Drawing.Point(234, 32)
        Me.Cmbdefault_undepositive.Name = "Cmbdefault_undepositive"
        Me.Cmbdefault_undepositive.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_undepositive.TabIndex = 1
        Me.Cmbdefault_undepositive.ValueMember = "GL_account"
        '
        'Cmbdefault_cash_over
        '
        Me.Cmbdefault_cash_over.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account
        Me.Cmbdefault_cash_over.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_cash_over.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_cash_over.Location = New System.Drawing.Point(234, 7)
        Me.Cmbdefault_cash_over.Name = "Cmbdefault_cash_over"
        Me.Cmbdefault_cash_over.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_cash_over.TabIndex = 0
        Me.Cmbdefault_cash_over.ValueMember = "GL_account"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(13, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 19)
        Me.Label8.TabIndex = 369
        Me.Label8.Text = "Returns Account No"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(13, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 19)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Bad Debt Account No"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(13, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 19)
        Me.Label5.TabIndex = 367
        Me.Label5.Text = "Inventory Adjmnt Account No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 19)
        Me.Label3.TabIndex = 365
        Me.Label3.Text = "Sales Tax Payable Account No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 20)
        Me.Label2.TabIndex = 364
        Me.Label2.Text = "Deposits On Hand Account No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "Undeposited Fund Account No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(13, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(216, 20)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "Cash Over/Short Account No"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbdefault_depositive
        '
        Me.Cmbdefault_depositive.DataSource = Me.DsFrmGeneralLedgerSetup1.GL_account2
        Me.Cmbdefault_depositive.DisplayMember = "desc_GL_account"
        Me.Cmbdefault_depositive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdefault_depositive.Location = New System.Drawing.Point(234, 57)
        Me.Cmbdefault_depositive.Name = "Cmbdefault_depositive"
        Me.Cmbdefault_depositive.Size = New System.Drawing.Size(185, 21)
        Me.Cmbdefault_depositive.TabIndex = 2
        Me.Cmbdefault_depositive.ValueMember = "GL_account"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(438, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rules"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABI;packet size=4096;user id=sa;initial catalog=TireMate_01;per" & _
        "sist security info=True;password=110"
        '
        'DAGL_account
        '
        Me.DAGL_account.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_account.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_account.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        Me.DAGL_account.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_account WHERE (GL_account = @Original_GL_account) AND (GL_account_" & _
        "master = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND " & _
        "GL_account_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @" & _
        "Original_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_acco" & _
        "unt = @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group" & _
        "_GL_account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL " & _
        "AND remark IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_account(GL_account, desc_GL_account, GL_account_master, group_GL_a" & _
        "ccount, remark) VALUES (@GL_account, @desc_GL_account, @GL_account_master, @grou" & _
        "p_GL_account, @remark); SELECT GL_account, desc_GL_account, GL_account_master, g" & _
        "roup_GL_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account, desc_GL_account FROM GL_account"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_account SET GL_account = @GL_account, desc_GL_account = @desc_GL_accoun" & _
        "t, GL_account_master = @GL_account_master, group_GL_account = @group_GL_account," & _
        " remark = @remark WHERE (GL_account = @Original_GL_account) AND (GL_account_mast" & _
        "er = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND GL_a" & _
        "ccount_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @Orig" & _
        "inal_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_account " & _
        "= @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group_GL_" & _
        "account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AND " & _
        "remark IS NULL); SELECT GL_account, desc_GL_account, GL_account_master, group_GL" & _
        "_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmGeneralLedgerSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(454, 389)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmGeneralLedgerSetup"
        Me.Text = "General Ledger Setup"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DsFrmGeneralLedgerSetup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmGeneralLedgerSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables

        DsFrmGeneralLedgerSetup1.GL_account.Clear()
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account1")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account2")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account3")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account4")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account5")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account6")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account7")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account8")
        DAGL_account.Fill(DsFrmGeneralLedgerSetup1, "GL_account9")

        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveGeneralLedgerSetupTable()
        Cmbdefault_bad_dept.SelectedValue = OleDbReader.Item("default_bad_dept") & ""
        Cmbdefault_cash_over.SelectedValue = OleDbReader.Item("default_cash_over") & ""
        Cmbdefault_depositive.SelectedValue = OleDbReader.Item("default_depositive") & ""
        Cmbdefault_inventory_adjment.SelectedValue = OleDbReader.Item("default_inventory_adjment") & ""
        Cmbdefault_return.SelectedValue = OleDbReader.Item("default_return") & ""
        Cmbdefault_sales_tax.SelectedValue = OleDbReader.Item("default_sales_tax") & ""
        Cmbdefault_undepositive.SelectedValue = OleDbReader.Item("default_undepositive") & ""
        CmbDefault_discount_for_sales.SelectedValue = OleDbReader.Item("default_discount_for_sales") & ""
        CmbDefault_discount_for_Purchases.SelectedValue = OleDbReader.Item("default_discount_for_purchases") & ""
        Cmbdefault_traded_item.SelectedValue = OleDbReader.Item("default_traded_item") & ""

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
    Private Sub Cmbdefault_bad_dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbdefault_bad_dept.SelectedIndexChanged, Cmbdefault_cash_over.SelectedIndexChanged, Cmbdefault_depositive.SelectedIndexChanged, Cmbdefault_bad_dept.SelectedIndexChanged, Cmbdefault_inventory_adjment.SelectedIndexChanged, Cmbdefault_return.SelectedIndexChanged, Cmbdefault_return.SelectedIndexChanged, Cmbdefault_sales_tax.SelectedIndexChanged, Cmbdefault_undepositive.SelectedIndexChanged, CmbDefault_discount_for_sales.SelectedIndexChanged, CmbDefault_discount_for_Purchases.SelectedIndexChanged, Cmbdefault_traded_item.SelectedIndexChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Then
            BtnOk.Enabled = True
        End If
    End Sub
    Private Sub FrmGeneralLedgerSetup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
        CmdGeneralForMDB.CommandText = "Update General_Ledger_Setup SET default_bad_dept=" & Qt(Cmbdefault_bad_dept.SelectedValue) & ",default_cash_over=" & Qt(Cmbdefault_cash_over.SelectedValue) & ",default_depositive=" & Qt(Cmbdefault_depositive.SelectedValue) & ",default_inventory_adjment=" & Qt(Cmbdefault_inventory_adjment.SelectedValue) & ",default_return=" & Qt(Cmbdefault_return.SelectedValue) & ",default_sales_tax=" & Qt(Cmbdefault_sales_tax.SelectedValue) & ",default_undepositive=" & Qt(Cmbdefault_undepositive.SelectedValue) & ",Default_discount_for_sales=" & Qt(CmbDefault_discount_for_sales.SelectedValue) & ",Default_discount_for_Purchases=" & Qt(CmbDefault_discount_for_Purchases.SelectedValue) & ",default_traded_item=" & Qt(Cmbdefault_traded_item.SelectedValue)
        CmdGeneralForMDB.ExecuteNonQuery()
        CmdGeneralForMDB.Connection.Close()
    End Sub
End Class
