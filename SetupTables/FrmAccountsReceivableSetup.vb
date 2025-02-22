Imports CommonClass
Public Class FrmAccountsReceivableSetup
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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumDefault_annual_finance_charge As CalcUtils.UcCalcText
    Friend WithEvents CHKDefault_FIN_CHARGE As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKDefault_SEND_COPY As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKDefault_statements As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbDefault_AR_terms As System.Windows.Forms.ComboBox
    Friend WithEvents NumDefault_minimum_finance_charge As CalcUtils.UcCalcText
    Friend WithEvents NumDefault_Late_Payment_Fee As CalcUtils.UcCalcText
    Friend WithEvents CHKRULES_WARN_OVER_CREDIT As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES_USE_CREDIT_LIMITED As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKSTATEMENT_PRINT_LOGO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKSTATEMENT_PRINT_ADDRESS As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKSTATEMENT_PRINT_NAME As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents NUMRULES_CREDIT_LIMITED As CalcUtils.UcCalcText
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmAccountsReceivableSetup1 As SetupTables.DSFrmAccountsReceivableSetup
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents CHKRULES_WARN_PAST As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbDefault_AR_GL_account As System.Windows.Forms.ComboBox
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmbDefault_AR_Employee_GL_Account As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDefault_AR_cash_receipts_GL_Account As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDefault_AR_cash_discount_GL_account As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDefault_Finance_Charge_GL_Account As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CHKRULES_NO_SERVICE_PAST As Janus.Windows.EditControls.UICheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAccountsReceivableSetup))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CnnMDB = New System.Data.OleDb.OleDbConnection
        Me.CmdGeneralForMDB = New System.Data.OleDb.OleDbCommand
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CmbDefault_Finance_Charge_GL_Account = New System.Windows.Forms.ComboBox
        Me.DsFrmAccountsReceivableSetup1 = New SetupTables.DSFrmAccountsReceivableSetup
        Me.CmbDefault_AR_cash_discount_GL_account = New System.Windows.Forms.ComboBox
        Me.CmbDefault_AR_cash_receipts_GL_Account = New System.Windows.Forms.ComboBox
        Me.CmbDefault_AR_Employee_GL_Account = New System.Windows.Forms.ComboBox
        Me.CmbDefault_AR_GL_account = New System.Windows.Forms.ComboBox
        Me.NumDefault_Late_Payment_Fee = New CalcUtils.UcCalcText
        Me.NumDefault_minimum_finance_charge = New CalcUtils.UcCalcText
        Me.NumDefault_annual_finance_charge = New CalcUtils.UcCalcText
        Me.CHKDefault_FIN_CHARGE = New Janus.Windows.EditControls.UICheckBox
        Me.CHKDefault_SEND_COPY = New Janus.Windows.EditControls.UICheckBox
        Me.CHKDefault_statements = New Janus.Windows.EditControls.UICheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbDefault_AR_terms = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CHKRULES_NO_SERVICE_PAST = New Janus.Windows.EditControls.UICheckBox
        Me.NUMRULES_CREDIT_LIMITED = New CalcUtils.UcCalcText
        Me.CHKRULES_WARN_OVER_CREDIT = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES_USE_CREDIT_LIMITED = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES_WARN_PAST = New Janus.Windows.EditControls.UICheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CHKSTATEMENT_PRINT_LOGO = New Janus.Windows.EditControls.UICheckBox
        Me.CHKSTATEMENT_PRINT_ADDRESS = New Janus.Windows.EditControls.UICheckBox
        Me.CHKSTATEMENT_PRINT_NAME = New Janus.Windows.EditControls.UICheckBox
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DsFrmAccountsReceivableSetup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(672, 62)
        Me.Panel1.TabIndex = 365
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(172, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(496, 58)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Accounts Receivable Setup"
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
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.SystemColors.Info
        Me.BtnOk.Enabled = False
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.Location = New System.Drawing.Point(571, 287)
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
        Me.BtnExit.Location = New System.Drawing.Point(23, 287)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(73, 27)
        Me.BtnExit.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(663, 217)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CmbDefault_Finance_Charge_GL_Account)
        Me.TabPage1.Controls.Add(Me.CmbDefault_AR_cash_discount_GL_account)
        Me.TabPage1.Controls.Add(Me.CmbDefault_AR_cash_receipts_GL_Account)
        Me.TabPage1.Controls.Add(Me.CmbDefault_AR_Employee_GL_Account)
        Me.TabPage1.Controls.Add(Me.CmbDefault_AR_GL_account)
        Me.TabPage1.Controls.Add(Me.NumDefault_Late_Payment_Fee)
        Me.TabPage1.Controls.Add(Me.NumDefault_minimum_finance_charge)
        Me.TabPage1.Controls.Add(Me.NumDefault_annual_finance_charge)
        Me.TabPage1.Controls.Add(Me.CHKDefault_FIN_CHARGE)
        Me.TabPage1.Controls.Add(Me.CHKDefault_SEND_COPY)
        Me.TabPage1.Controls.Add(Me.CHKDefault_statements)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CmbDefault_AR_terms)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(655, 191)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Defaults"
        '
        'CmbDefault_Finance_Charge_GL_Account
        '
        Me.CmbDefault_Finance_Charge_GL_Account.DataSource = Me.DsFrmAccountsReceivableSetup1.GL_account4
        Me.CmbDefault_Finance_Charge_GL_Account.DisplayMember = "desc_GL_account"
        Me.CmbDefault_Finance_Charge_GL_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_Finance_Charge_GL_Account.Location = New System.Drawing.Point(167, 116)
        Me.CmbDefault_Finance_Charge_GL_Account.Name = "CmbDefault_Finance_Charge_GL_Account"
        Me.CmbDefault_Finance_Charge_GL_Account.Size = New System.Drawing.Size(221, 21)
        Me.CmbDefault_Finance_Charge_GL_Account.TabIndex = 380
        Me.CmbDefault_Finance_Charge_GL_Account.ValueMember = "GL_account"
        '
        'DsFrmAccountsReceivableSetup1
        '
        Me.DsFrmAccountsReceivableSetup1.DataSetName = "DSFrmAccountsReceivableSetup"
        Me.DsFrmAccountsReceivableSetup1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbDefault_AR_cash_discount_GL_account
        '
        Me.CmbDefault_AR_cash_discount_GL_account.DataSource = Me.DsFrmAccountsReceivableSetup1.GL_account3
        Me.CmbDefault_AR_cash_discount_GL_account.DisplayMember = "desc_GL_account"
        Me.CmbDefault_AR_cash_discount_GL_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_AR_cash_discount_GL_account.Location = New System.Drawing.Point(167, 91)
        Me.CmbDefault_AR_cash_discount_GL_account.Name = "CmbDefault_AR_cash_discount_GL_account"
        Me.CmbDefault_AR_cash_discount_GL_account.Size = New System.Drawing.Size(221, 21)
        Me.CmbDefault_AR_cash_discount_GL_account.TabIndex = 379
        Me.CmbDefault_AR_cash_discount_GL_account.ValueMember = "GL_account"
        '
        'CmbDefault_AR_cash_receipts_GL_Account
        '
        Me.CmbDefault_AR_cash_receipts_GL_Account.DataSource = Me.DsFrmAccountsReceivableSetup1.GL_account2
        Me.CmbDefault_AR_cash_receipts_GL_Account.DisplayMember = "desc_GL_account"
        Me.CmbDefault_AR_cash_receipts_GL_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_AR_cash_receipts_GL_Account.Location = New System.Drawing.Point(167, 66)
        Me.CmbDefault_AR_cash_receipts_GL_Account.Name = "CmbDefault_AR_cash_receipts_GL_Account"
        Me.CmbDefault_AR_cash_receipts_GL_Account.Size = New System.Drawing.Size(221, 21)
        Me.CmbDefault_AR_cash_receipts_GL_Account.TabIndex = 378
        Me.CmbDefault_AR_cash_receipts_GL_Account.ValueMember = "GL_account"
        '
        'CmbDefault_AR_Employee_GL_Account
        '
        Me.CmbDefault_AR_Employee_GL_Account.DataSource = Me.DsFrmAccountsReceivableSetup1.GL_account1
        Me.CmbDefault_AR_Employee_GL_Account.DisplayMember = "desc_GL_account"
        Me.CmbDefault_AR_Employee_GL_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_AR_Employee_GL_Account.Location = New System.Drawing.Point(167, 41)
        Me.CmbDefault_AR_Employee_GL_Account.Name = "CmbDefault_AR_Employee_GL_Account"
        Me.CmbDefault_AR_Employee_GL_Account.Size = New System.Drawing.Size(221, 21)
        Me.CmbDefault_AR_Employee_GL_Account.TabIndex = 377
        Me.CmbDefault_AR_Employee_GL_Account.ValueMember = "GL_account"
        '
        'CmbDefault_AR_GL_account
        '
        Me.CmbDefault_AR_GL_account.DataSource = Me.DsFrmAccountsReceivableSetup1.GL_account
        Me.CmbDefault_AR_GL_account.DisplayMember = "desc_GL_account"
        Me.CmbDefault_AR_GL_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_AR_GL_account.Location = New System.Drawing.Point(167, 16)
        Me.CmbDefault_AR_GL_account.Name = "CmbDefault_AR_GL_account"
        Me.CmbDefault_AR_GL_account.Size = New System.Drawing.Size(221, 21)
        Me.CmbDefault_AR_GL_account.TabIndex = 376
        Me.CmbDefault_AR_GL_account.ValueMember = "GL_account"
        '
        'NumDefault_Late_Payment_Fee
        '
        Me.NumDefault_Late_Payment_Fee.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDefault_Late_Payment_Fee.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDefault_Late_Payment_Fee.DecimalDigits = 2
        Me.NumDefault_Late_Payment_Fee.DefaultSendValue = False
        Me.NumDefault_Late_Payment_Fee.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDefault_Late_Payment_Fee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumDefault_Late_Payment_Fee.Image = CType(resources.GetObject("NumDefault_Late_Payment_Fee.Image"), System.Drawing.Image)
        Me.NumDefault_Late_Payment_Fee.Location = New System.Drawing.Point(533, 42)
        Me.NumDefault_Late_Payment_Fee.Maxlength = 10
        Me.NumDefault_Late_Payment_Fee.MinusColor = System.Drawing.Color.Empty
        Me.NumDefault_Late_Payment_Fee.Name = "NumDefault_Late_Payment_Fee"
        Me.NumDefault_Late_Payment_Fee.Size = New System.Drawing.Size(120, 22)
        Me.NumDefault_Late_Payment_Fee.TabIndex = 8
        Me.NumDefault_Late_Payment_Fee.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDefault_Late_Payment_Fee.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDefault_minimum_finance_charge
        '
        Me.NumDefault_minimum_finance_charge.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDefault_minimum_finance_charge.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDefault_minimum_finance_charge.DecimalDigits = 2
        Me.NumDefault_minimum_finance_charge.DefaultSendValue = False
        Me.NumDefault_minimum_finance_charge.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDefault_minimum_finance_charge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumDefault_minimum_finance_charge.Image = CType(resources.GetObject("NumDefault_minimum_finance_charge.Image"), System.Drawing.Image)
        Me.NumDefault_minimum_finance_charge.Location = New System.Drawing.Point(533, 15)
        Me.NumDefault_minimum_finance_charge.Maxlength = 10
        Me.NumDefault_minimum_finance_charge.MinusColor = System.Drawing.Color.Empty
        Me.NumDefault_minimum_finance_charge.Name = "NumDefault_minimum_finance_charge"
        Me.NumDefault_minimum_finance_charge.Size = New System.Drawing.Size(120, 22)
        Me.NumDefault_minimum_finance_charge.TabIndex = 7
        Me.NumDefault_minimum_finance_charge.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDefault_minimum_finance_charge.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDefault_annual_finance_charge
        '
        Me.NumDefault_annual_finance_charge.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDefault_annual_finance_charge.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDefault_annual_finance_charge.DecimalDigits = 2
        Me.NumDefault_annual_finance_charge.DefaultSendValue = False
        Me.NumDefault_annual_finance_charge.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDefault_annual_finance_charge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumDefault_annual_finance_charge.Image = CType(resources.GetObject("NumDefault_annual_finance_charge.Image"), System.Drawing.Image)
        Me.NumDefault_annual_finance_charge.Location = New System.Drawing.Point(167, 141)
        Me.NumDefault_annual_finance_charge.Maxlength = 6
        Me.NumDefault_annual_finance_charge.MinusColor = System.Drawing.Color.Empty
        Me.NumDefault_annual_finance_charge.Name = "NumDefault_annual_finance_charge"
        Me.NumDefault_annual_finance_charge.Size = New System.Drawing.Size(120, 22)
        Me.NumDefault_annual_finance_charge.TabIndex = 5
        Me.NumDefault_annual_finance_charge.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDefault_annual_finance_charge.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CHKDefault_FIN_CHARGE
        '
        Me.CHKDefault_FIN_CHARGE.Location = New System.Drawing.Point(428, 117)
        Me.CHKDefault_FIN_CHARGE.Name = "CHKDefault_FIN_CHARGE"
        Me.CHKDefault_FIN_CHARGE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKDefault_FIN_CHARGE.Size = New System.Drawing.Size(119, 21)
        Me.CHKDefault_FIN_CHARGE.TabIndex = 11
        Me.CHKDefault_FIN_CHARGE.Text = "Fin. Charges"
        '
        'CHKDefault_SEND_COPY
        '
        Me.CHKDefault_SEND_COPY.Location = New System.Drawing.Point(428, 94)
        Me.CHKDefault_SEND_COPY.Name = "CHKDefault_SEND_COPY"
        Me.CHKDefault_SEND_COPY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKDefault_SEND_COPY.Size = New System.Drawing.Size(119, 21)
        Me.CHKDefault_SEND_COPY.TabIndex = 10
        Me.CHKDefault_SEND_COPY.Text = "Send Copies"
        '
        'CHKDefault_statements
        '
        Me.CHKDefault_statements.Location = New System.Drawing.Point(428, 69)
        Me.CHKDefault_statements.Name = "CHKDefault_statements"
        Me.CHKDefault_statements.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKDefault_statements.Size = New System.Drawing.Size(119, 21)
        Me.CHKDefault_statements.TabIndex = 9
        Me.CHKDefault_statements.Text = "Statement"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(5, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 20)
        Me.Label8.TabIndex = 369
        Me.Label8.Text = "AR Terms"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(4, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 20)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Annual Finance Charge %"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(5, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 367
        Me.Label5.Text = "Finance Charge Account No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDefault_AR_terms
        '
        Me.CmbDefault_AR_terms.DataSource = Me.DsFrmAccountsReceivableSetup1.GL_TAB_AR_TERM
        Me.CmbDefault_AR_terms.DisplayMember = "AR_terms"
        Me.CmbDefault_AR_terms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDefault_AR_terms.Location = New System.Drawing.Point(167, 166)
        Me.CmbDefault_AR_terms.Name = "CmbDefault_AR_terms"
        Me.CmbDefault_AR_terms.Size = New System.Drawing.Size(224, 21)
        Me.CmbDefault_AR_terms.TabIndex = 6
        Me.CmbDefault_AR_terms.ValueMember = "AR_terms"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(5, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 365
        Me.Label3.Text = "A/R Discount Account No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(0, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 19)
        Me.Label2.TabIndex = 364
        Me.Label2.Text = "A/R Cash Receipts Account No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(-1, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 19)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "A/R Employee GL Account No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(-1, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 19)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "A/R Trade GL Account No"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(403, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 19)
        Me.Label10.TabIndex = 375
        Me.Label10.Text = "Late Payment Fee $"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(387, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 19)
        Me.Label9.TabIndex = 373
        Me.Label9.Text = "Minimum Finance Charge $"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CHKRULES_NO_SERVICE_PAST)
        Me.TabPage2.Controls.Add(Me.NUMRULES_CREDIT_LIMITED)
        Me.TabPage2.Controls.Add(Me.CHKRULES_WARN_OVER_CREDIT)
        Me.TabPage2.Controls.Add(Me.CHKRULES_USE_CREDIT_LIMITED)
        Me.TabPage2.Controls.Add(Me.CHKRULES_WARN_PAST)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(655, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rules"
        '
        'CHKRULES_NO_SERVICE_PAST
        '
        Me.CHKRULES_NO_SERVICE_PAST.Location = New System.Drawing.Point(21, 33)
        Me.CHKRULES_NO_SERVICE_PAST.Name = "CHKRULES_NO_SERVICE_PAST"
        Me.CHKRULES_NO_SERVICE_PAST.Size = New System.Drawing.Size(321, 22)
        Me.CHKRULES_NO_SERVICE_PAST.TabIndex = 1
        Me.CHKRULES_NO_SERVICE_PAST.Text = "No Service Offered if Customer is past due  over 90 days"
        '
        'NUMRULES_CREDIT_LIMITED
        '
        Me.NUMRULES_CREDIT_LIMITED.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NUMRULES_CREDIT_LIMITED.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NUMRULES_CREDIT_LIMITED.DecimalDigits = 2
        Me.NUMRULES_CREDIT_LIMITED.DefaultSendValue = False
        Me.NUMRULES_CREDIT_LIMITED.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NUMRULES_CREDIT_LIMITED.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NUMRULES_CREDIT_LIMITED.Image = CType(resources.GetObject("NUMRULES_CREDIT_LIMITED.Image"), System.Drawing.Image)
        Me.NUMRULES_CREDIT_LIMITED.Location = New System.Drawing.Point(120, 112)
        Me.NUMRULES_CREDIT_LIMITED.Maxlength = 10
        Me.NUMRULES_CREDIT_LIMITED.MinusColor = System.Drawing.Color.Empty
        Me.NUMRULES_CREDIT_LIMITED.Name = "NUMRULES_CREDIT_LIMITED"
        Me.NUMRULES_CREDIT_LIMITED.Size = New System.Drawing.Size(120, 22)
        Me.NUMRULES_CREDIT_LIMITED.TabIndex = 4
        Me.NUMRULES_CREDIT_LIMITED.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NUMRULES_CREDIT_LIMITED.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CHKRULES_WARN_OVER_CREDIT
        '
        Me.CHKRULES_WARN_OVER_CREDIT.Location = New System.Drawing.Point(21, 84)
        Me.CHKRULES_WARN_OVER_CREDIT.Name = "CHKRULES_WARN_OVER_CREDIT"
        Me.CHKRULES_WARN_OVER_CREDIT.Size = New System.Drawing.Size(293, 22)
        Me.CHKRULES_WARN_OVER_CREDIT.TabIndex = 3
        Me.CHKRULES_WARN_OVER_CREDIT.Text = "No Service Offered if Customer is over credit limit"
        '
        'CHKRULES_USE_CREDIT_LIMITED
        '
        Me.CHKRULES_USE_CREDIT_LIMITED.Location = New System.Drawing.Point(21, 58)
        Me.CHKRULES_USE_CREDIT_LIMITED.Name = "CHKRULES_USE_CREDIT_LIMITED"
        Me.CHKRULES_USE_CREDIT_LIMITED.Size = New System.Drawing.Size(246, 22)
        Me.CHKRULES_USE_CREDIT_LIMITED.TabIndex = 2
        Me.CHKRULES_USE_CREDIT_LIMITED.Text = "Use Credit Limit Functions"
        '
        'CHKRULES_WARN_PAST
        '
        Me.CHKRULES_WARN_PAST.Location = New System.Drawing.Point(21, 9)
        Me.CHKRULES_WARN_PAST.Name = "CHKRULES_WARN_PAST"
        Me.CHKRULES_WARN_PAST.Size = New System.Drawing.Size(246, 22)
        Me.CHKRULES_WARN_PAST.TabIndex = 0
        Me.CHKRULES_WARN_PAST.Text = "Warn if Customer is past due  over 90 days"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(17, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 380
        Me.Label4.Text = "Default Credit Limit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CHKSTATEMENT_PRINT_LOGO)
        Me.TabPage3.Controls.Add(Me.CHKSTATEMENT_PRINT_ADDRESS)
        Me.TabPage3.Controls.Add(Me.CHKSTATEMENT_PRINT_NAME)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(655, 191)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Statements"
        '
        'CHKSTATEMENT_PRINT_LOGO
        '
        Me.CHKSTATEMENT_PRINT_LOGO.Location = New System.Drawing.Point(21, 63)
        Me.CHKSTATEMENT_PRINT_LOGO.Name = "CHKSTATEMENT_PRINT_LOGO"
        Me.CHKSTATEMENT_PRINT_LOGO.Size = New System.Drawing.Size(246, 21)
        Me.CHKSTATEMENT_PRINT_LOGO.TabIndex = 2
        Me.CHKSTATEMENT_PRINT_LOGO.Text = "Print Company Logo On Statements"
        '
        'CHKSTATEMENT_PRINT_ADDRESS
        '
        Me.CHKSTATEMENT_PRINT_ADDRESS.Location = New System.Drawing.Point(21, 37)
        Me.CHKSTATEMENT_PRINT_ADDRESS.Name = "CHKSTATEMENT_PRINT_ADDRESS"
        Me.CHKSTATEMENT_PRINT_ADDRESS.Size = New System.Drawing.Size(246, 21)
        Me.CHKSTATEMENT_PRINT_ADDRESS.TabIndex = 1
        Me.CHKSTATEMENT_PRINT_ADDRESS.Text = "Print Company Address On Statements"
        '
        'CHKSTATEMENT_PRINT_NAME
        '
        Me.CHKSTATEMENT_PRINT_NAME.Location = New System.Drawing.Point(21, 11)
        Me.CHKSTATEMENT_PRINT_NAME.Name = "CHKSTATEMENT_PRINT_NAME"
        Me.CHKSTATEMENT_PRINT_NAME.Size = New System.Drawing.Size(246, 21)
        Me.CHKSTATEMENT_PRINT_NAME.TabIndex = 0
        Me.CHKSTATEMENT_PRINT_NAME.Text = "Print Company Name On Statements"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=KETABIE;persist se" & _
        "curity info=True;initial catalog=TireMate_01;password=sa"
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN" & _
        "_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_I" & _
        "F_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        '
        'FrmAccountsReceivableSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 317)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmAccountsReceivableSetup"
        Me.Text = "Accounts Receivable Setup"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DsFrmAccountsReceivableSetup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmAccountsReceivableSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables

        If Cnn.State <> ConnectionState.Open Then
            Cnn.Open()
        End If
        DsFrmAccountsReceivableSetup1.GL_TAB_AR_TERM.Clear()
        DAGL_TAB_AR_TERM.Fill(DsFrmAccountsReceivableSetup1, "GL_TAB_AR_TERM")
        DsFrmAccountsReceivableSetup1.GL_account.Clear()
        DAGL_account.Fill(DsFrmAccountsReceivableSetup1, "GL_account")
        DAGL_account.Fill(DsFrmAccountsReceivableSetup1, "GL_account1")
        DAGL_account.Fill(DsFrmAccountsReceivableSetup1, "GL_account2")
        DAGL_account.Fill(DsFrmAccountsReceivableSetup1, "GL_account3")
        DAGL_account.Fill(DsFrmAccountsReceivableSetup1, "GL_account4")

        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveAccountsReceivableSetupTable()
        Try
            CmbDefault_AR_cash_discount_GL_account.SelectedValue = OleDbReader.Item("Default_AR_cash_discount_GL_account") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDefault_AR_cash_receipts_GL_Account.SelectedValue = OleDbReader.Item("Default_AR_cash_receipts_GL_Account") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDefault_AR_Employee_GL_Account.SelectedValue = OleDbReader.Item("Default_AR_Employee_GL_Account") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDefault_AR_GL_account.SelectedValue = OleDbReader.Item("Default_AR_GL_account") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDefault_Finance_Charge_GL_Account.SelectedValue = OleDbReader.Item("Default_Finance_Charge_GL_Account") & ""
        Catch ex As Exception
        End Try
        NumDefault_annual_finance_charge.Text = OleDbReader.Item("Default_annual_finance_charge")
        NumDefault_Late_Payment_Fee.Text = OleDbReader.Item("Default_Late_Payment_Fee")
        NumDefault_minimum_finance_charge.Text = OleDbReader.Item("Default_minimum_finance_charge")
        NUMRULES_CREDIT_LIMITED.Text = OleDbReader.Item("RULES_CREDIT_LIMITED")
        CHKDefault_FIN_CHARGE.Checked = OleDbReader.Item("Default_FIN_CHARGE")
        CHKDefault_SEND_COPY.Checked = OleDbReader.Item("Default_SEND_COPY")
        CHKDefault_statements.Checked = OleDbReader.Item("Default_statements")
        CHKRULES_USE_CREDIT_LIMITED.Checked = OleDbReader.Item("RULES_USE_CREDIT_LIMITED")
        CHKRULES_NO_SERVICE_PAST.Checked = OleDbReader.Item("RULES_NO_SERVICE_PAST")
        CHKRULES_WARN_OVER_CREDIT.Checked = OleDbReader.Item("RULES_WARN_OVER_CREDIT")
        CHKRULES_WARN_PAST.Checked = OleDbReader.Item("RULES_WARN_PAST")
        CHKSTATEMENT_PRINT_ADDRESS.Checked = OleDbReader.Item("STATEMENT_PRINT_ADDRESS")
        CHKSTATEMENT_PRINT_LOGO.Checked = OleDbReader.Item("STATEMENT_PRINT_LOGO")
        CHKSTATEMENT_PRINT_NAME.Checked = OleDbReader.Item("STATEMENT_PRINT_NAME")
        Try
            CmbDefault_AR_terms.SelectedValue = OleDbReader.Item("Default_AR_terms") & ""
        Catch ex As Exception
        End Try

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
    Private Sub TxtDefault_AR_cash_discount_GL_account_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDefault_AR_terms.SelectedIndexChanged, CHKDefault_FIN_CHARGE.CheckedChanged, CHKDefault_SEND_COPY.CheckedChanged, CHKRULES_NO_SERVICE_PAST.CheckedChanged, CHKDefault_statements.CheckedChanged, CHKRULES_USE_CREDIT_LIMITED.CheckedChanged, CHKRULES_WARN_OVER_CREDIT.CheckedChanged, CHKRULES_WARN_PAST.CheckedChanged, CHKSTATEMENT_PRINT_ADDRESS.CheckedChanged, CHKSTATEMENT_PRINT_LOGO.CheckedChanged, CHKSTATEMENT_PRINT_NAME.CheckedChanged, CmbDefault_AR_cash_discount_GL_account.SelectedIndexChanged, CmbDefault_AR_cash_receipts_GL_Account.SelectedIndexChanged, CmbDefault_AR_Employee_GL_Account.SelectedIndexChanged, CmbDefault_AR_GL_account.SelectedIndexChanged, CmbDefault_Finance_Charge_GL_Account.SelectedIndexChanged, NumDefault_annual_finance_charge.TextChanged, NumDefault_Late_Payment_Fee.TextChanged, NumDefault_minimum_finance_charge.TextChanged, NUMRULES_CREDIT_LIMITED.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Then
            BtnOk.Enabled = True
        End If
    End Sub
    Private Sub FrmAccountsReceivableSetup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
        If CHKRULES_USE_CREDIT_LIMITED.Checked And NUMRULES_CREDIT_LIMITED.Numbervalue <= 0 Then
            MsgBox("You checked 'Use Credit Limit Functions' checkbox.Please set 'Default Credit Limit Value'")
            BtnOk.Enabled = True
            Exit Sub
        End If
        If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDB.Connection.Open()
        End If
        CmdGeneralForMDB.CommandText = "Update Accounts_Receivable_Setup SET Default_AR_cash_discount_GL_account=" & Qt(CmbDefault_AR_cash_discount_GL_account.SelectedValue) & ",Default_AR_cash_receipts_GL_Account=" & Qt(CmbDefault_AR_cash_receipts_GL_Account.SelectedValue) & ",Default_AR_Employee_GL_Account=" & Qt(CmbDefault_AR_Employee_GL_Account.SelectedValue) & ",Default_AR_GL_account=" & Qt(CmbDefault_AR_GL_account.SelectedValue) & ",Default_Finance_Charge_GL_Account=" & Qt(CmbDefault_Finance_Charge_GL_Account.SelectedValue) & ",Default_annual_finance_charge=" & NumDefault_annual_finance_charge.Text & ",Default_Late_Payment_Fee=" & NumDefault_Late_Payment_Fee.Text & ",Default_minimum_finance_charge=" & NumDefault_minimum_finance_charge.Text & ",RULES_CREDIT_LIMITED=" & NUMRULES_CREDIT_LIMITED.Text & ",Default_FIN_CHARGE=" & DecodeCheckBox(CHKDefault_FIN_CHARGE.Checked) & ",Default_SEND_COPY=" & DecodeCheckBox(CHKDefault_SEND_COPY.Checked) & ",Default_statements=" & DecodeCheckBox(CHKDefault_statements.Checked) & ",RULES_USE_CREDIT_LIMITED=" & DecodeCheckBox(CHKRULES_USE_CREDIT_LIMITED.Checked) & ",RULES_NO_SERVICE_PAST=" & DecodeCheckBox(CHKRULES_NO_SERVICE_PAST.Checked) & ",RULES_WARN_OVER_CREDIT=" & DecodeCheckBox(CHKRULES_WARN_OVER_CREDIT.Checked) & ",RULES_WARN_PAST=" & DecodeCheckBox(CHKRULES_WARN_PAST.Checked) & ",STATEMENT_PRINT_ADDRESS=" & DecodeCheckBox(CHKSTATEMENT_PRINT_ADDRESS.Checked) & ",STATEMENT_PRINT_LOGO=" & DecodeCheckBox(CHKSTATEMENT_PRINT_LOGO.Checked) & ",STATEMENT_PRINT_NAME=" & DecodeCheckBox(CHKSTATEMENT_PRINT_NAME.Checked) & ",Default_AR_terms=" & IIf(IsNothing(CmbDefault_AR_terms.SelectedValue), System.DBNull.Value, Qt(CmbDefault_AR_terms.SelectedValue))
        CmdGeneralForMDB.ExecuteNonQuery()
        CmdGeneralForMDB.Connection.Close()
    End Sub
End Class
