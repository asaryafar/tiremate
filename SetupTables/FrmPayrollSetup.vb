Imports CommonClass
Public Class FrmPayrollSetup
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NumDEFAULT_MEDI_LIMITED As CalcUtils.UcCalcText
    Friend WithEvents NumDEFAULT_FICA_LIMITED As CalcUtils.UcCalcText
    Friend WithEvents CmdGeneralForMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmPayrollSetup1 As SetupTables.DSFrmPayrollSetup
    Friend WithEvents CmbDEFAULT_MEDI_LIABILITY As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_FICA_EXPENSE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_MADI_EXPENSE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_LOCAL_TAX As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_STATE_TAX As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_FEDERAL_WITHHOLDING As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_FICA_LIABILITY As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_EMPLOYER_FICA As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_EMPLOYEE_FICA As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_EMPLOYER_MEDI As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_EMPLOYEE_MEDI As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_GARNISHMENT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_PAYROLL_BANK As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbPaymentDay As System.Windows.Forms.ComboBox
    Friend WithEvents Numaaaa As CalcUtils.UcCalcText
    Friend WithEvents Label18 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPayrollSetup))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CmbPaymentDay = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbDEFAULT_FICA_LIABILITY = New System.Windows.Forms.ComboBox
        Me.DsFrmPayrollSetup1 = New SetupTables.DSFrmPayrollSetup
        Me.CmbDEFAULT_GARNISHMENT = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_EMPLOYEE_MEDI = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_EMPLOYER_MEDI = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_EMPLOYEE_FICA = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_EMPLOYER_FICA = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_STATE_TAX = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_LOCAL_TAX = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_MADI_EXPENSE = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_FICA_EXPENSE = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_MEDI_LIABILITY = New System.Windows.Forms.ComboBox
        Me.CmbDEFAULT_PAYROLL_BANK = New System.Windows.Forms.ComboBox
        Me.NumDEFAULT_MEDI_LIMITED = New CalcUtils.UcCalcText
        Me.NumDEFAULT_FICA_LIMITED = New CalcUtils.UcCalcText
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CmdGeneralForMDB = New System.Data.OleDb.OleDbCommand
        Me.CnnMDB = New System.Data.OleDb.OleDbConnection
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Numaaaa = New CalcUtils.UcCalcText
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DsFrmPayrollSetup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(579, 62)
        Me.Panel1.TabIndex = 365
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(95, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(480, 58)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Payroll Setup"
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
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.SystemColors.Info
        Me.BtnOk.Enabled = False
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.Location = New System.Drawing.Point(485, 309)
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
        Me.BtnExit.Location = New System.Drawing.Point(20, 309)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(73, 27)
        Me.BtnExit.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(574, 234)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CmbPaymentDay)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_FICA_LIABILITY)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_GARNISHMENT)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_EMPLOYEE_MEDI)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_EMPLOYER_MEDI)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_EMPLOYEE_FICA)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_EMPLOYER_FICA)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_FEDERAL_WITHHOLDING)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_STATE_TAX)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_LOCAL_TAX)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_MADI_EXPENSE)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_FICA_EXPENSE)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_MEDI_LIABILITY)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_PAYROLL_BANK)
        Me.TabPage1.Controls.Add(Me.NumDEFAULT_MEDI_LIMITED)
        Me.TabPage1.Controls.Add(Me.NumDEFAULT_FICA_LIMITED)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(566, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Defaults"
        '
        'CmbPaymentDay
        '
        Me.CmbPaymentDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPaymentDay.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.CmbPaymentDay.Location = New System.Drawing.Point(442, 184)
        Me.CmbPaymentDay.Name = "CmbPaymentDay"
        Me.CmbPaymentDay.Size = New System.Drawing.Size(120, 21)
        Me.CmbPaymentDay.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(292, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 19)
        Me.Label9.TabIndex = 394
        Me.Label9.Text = "Payment Day"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEFAULT_FICA_LIABILITY
        '
        Me.CmbDEFAULT_FICA_LIABILITY.DataSource = Me.DsFrmPayrollSetup1.GL_account1
        Me.CmbDEFAULT_FICA_LIABILITY.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_FICA_LIABILITY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_FICA_LIABILITY.Location = New System.Drawing.Point(170, 32)
        Me.CmbDEFAULT_FICA_LIABILITY.Name = "CmbDEFAULT_FICA_LIABILITY"
        Me.CmbDEFAULT_FICA_LIABILITY.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_FICA_LIABILITY.TabIndex = 1
        Me.CmbDEFAULT_FICA_LIABILITY.ValueMember = "GL_account"
        '
        'DsFrmPayrollSetup1
        '
        Me.DsFrmPayrollSetup1.DataSetName = "DSFrmPayrollSetup"
        Me.DsFrmPayrollSetup1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbDEFAULT_GARNISHMENT
        '
        Me.CmbDEFAULT_GARNISHMENT.DataSource = Me.DsFrmPayrollSetup1.GL_account12
        Me.CmbDEFAULT_GARNISHMENT.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_GARNISHMENT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_GARNISHMENT.Location = New System.Drawing.Point(442, 109)
        Me.CmbDEFAULT_GARNISHMENT.Name = "CmbDEFAULT_GARNISHMENT"
        Me.CmbDEFAULT_GARNISHMENT.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_GARNISHMENT.TabIndex = 12
        Me.CmbDEFAULT_GARNISHMENT.ValueMember = "GL_account"
        '
        'CmbDEFAULT_EMPLOYEE_MEDI
        '
        Me.CmbDEFAULT_EMPLOYEE_MEDI.DataSource = Me.DsFrmPayrollSetup1.GL_account11
        Me.CmbDEFAULT_EMPLOYEE_MEDI.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_EMPLOYEE_MEDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_EMPLOYEE_MEDI.Location = New System.Drawing.Point(442, 84)
        Me.CmbDEFAULT_EMPLOYEE_MEDI.Name = "CmbDEFAULT_EMPLOYEE_MEDI"
        Me.CmbDEFAULT_EMPLOYEE_MEDI.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_EMPLOYEE_MEDI.TabIndex = 11
        Me.CmbDEFAULT_EMPLOYEE_MEDI.ValueMember = "GL_account"
        '
        'CmbDEFAULT_EMPLOYER_MEDI
        '
        Me.CmbDEFAULT_EMPLOYER_MEDI.DataSource = Me.DsFrmPayrollSetup1.GL_account10
        Me.CmbDEFAULT_EMPLOYER_MEDI.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_EMPLOYER_MEDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_EMPLOYER_MEDI.Location = New System.Drawing.Point(442, 58)
        Me.CmbDEFAULT_EMPLOYER_MEDI.Name = "CmbDEFAULT_EMPLOYER_MEDI"
        Me.CmbDEFAULT_EMPLOYER_MEDI.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_EMPLOYER_MEDI.TabIndex = 10
        Me.CmbDEFAULT_EMPLOYER_MEDI.ValueMember = "GL_account"
        '
        'CmbDEFAULT_EMPLOYEE_FICA
        '
        Me.CmbDEFAULT_EMPLOYEE_FICA.DataSource = Me.DsFrmPayrollSetup1.GL_account9
        Me.CmbDEFAULT_EMPLOYEE_FICA.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_EMPLOYEE_FICA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_EMPLOYEE_FICA.Location = New System.Drawing.Point(442, 32)
        Me.CmbDEFAULT_EMPLOYEE_FICA.Name = "CmbDEFAULT_EMPLOYEE_FICA"
        Me.CmbDEFAULT_EMPLOYEE_FICA.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_EMPLOYEE_FICA.TabIndex = 9
        Me.CmbDEFAULT_EMPLOYEE_FICA.ValueMember = "GL_account"
        '
        'CmbDEFAULT_EMPLOYER_FICA
        '
        Me.CmbDEFAULT_EMPLOYER_FICA.DataSource = Me.DsFrmPayrollSetup1.GL_account8
        Me.CmbDEFAULT_EMPLOYER_FICA.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_EMPLOYER_FICA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_EMPLOYER_FICA.Location = New System.Drawing.Point(442, 7)
        Me.CmbDEFAULT_EMPLOYER_FICA.Name = "CmbDEFAULT_EMPLOYER_FICA"
        Me.CmbDEFAULT_EMPLOYER_FICA.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_EMPLOYER_FICA.TabIndex = 8
        Me.CmbDEFAULT_EMPLOYER_FICA.ValueMember = "GL_account"
        '
        'CmbDEFAULT_FEDERAL_WITHHOLDING
        '
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.DataSource = Me.DsFrmPayrollSetup1.GL_account7
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.Location = New System.Drawing.Point(170, 186)
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.Name = "CmbDEFAULT_FEDERAL_WITHHOLDING"
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.TabIndex = 7
        Me.CmbDEFAULT_FEDERAL_WITHHOLDING.ValueMember = "GL_account"
        '
        'CmbDEFAULT_STATE_TAX
        '
        Me.CmbDEFAULT_STATE_TAX.DataSource = Me.DsFrmPayrollSetup1.GL_account6
        Me.CmbDEFAULT_STATE_TAX.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_STATE_TAX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_STATE_TAX.Location = New System.Drawing.Point(170, 161)
        Me.CmbDEFAULT_STATE_TAX.Name = "CmbDEFAULT_STATE_TAX"
        Me.CmbDEFAULT_STATE_TAX.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_STATE_TAX.TabIndex = 6
        Me.CmbDEFAULT_STATE_TAX.ValueMember = "GL_account"
        '
        'CmbDEFAULT_LOCAL_TAX
        '
        Me.CmbDEFAULT_LOCAL_TAX.DataSource = Me.DsFrmPayrollSetup1.GL_account5
        Me.CmbDEFAULT_LOCAL_TAX.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_LOCAL_TAX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_LOCAL_TAX.Location = New System.Drawing.Point(170, 135)
        Me.CmbDEFAULT_LOCAL_TAX.Name = "CmbDEFAULT_LOCAL_TAX"
        Me.CmbDEFAULT_LOCAL_TAX.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_LOCAL_TAX.TabIndex = 5
        Me.CmbDEFAULT_LOCAL_TAX.ValueMember = "GL_account"
        '
        'CmbDEFAULT_MADI_EXPENSE
        '
        Me.CmbDEFAULT_MADI_EXPENSE.DataSource = Me.DsFrmPayrollSetup1.GL_account4
        Me.CmbDEFAULT_MADI_EXPENSE.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_MADI_EXPENSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_MADI_EXPENSE.Location = New System.Drawing.Point(170, 110)
        Me.CmbDEFAULT_MADI_EXPENSE.Name = "CmbDEFAULT_MADI_EXPENSE"
        Me.CmbDEFAULT_MADI_EXPENSE.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_MADI_EXPENSE.TabIndex = 4
        Me.CmbDEFAULT_MADI_EXPENSE.ValueMember = "GL_account"
        '
        'CmbDEFAULT_FICA_EXPENSE
        '
        Me.CmbDEFAULT_FICA_EXPENSE.DataSource = Me.DsFrmPayrollSetup1.GL_account3
        Me.CmbDEFAULT_FICA_EXPENSE.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_FICA_EXPENSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_FICA_EXPENSE.Location = New System.Drawing.Point(170, 84)
        Me.CmbDEFAULT_FICA_EXPENSE.Name = "CmbDEFAULT_FICA_EXPENSE"
        Me.CmbDEFAULT_FICA_EXPENSE.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_FICA_EXPENSE.TabIndex = 3
        Me.CmbDEFAULT_FICA_EXPENSE.ValueMember = "GL_account"
        '
        'CmbDEFAULT_MEDI_LIABILITY
        '
        Me.CmbDEFAULT_MEDI_LIABILITY.DataSource = Me.DsFrmPayrollSetup1.GL_account2
        Me.CmbDEFAULT_MEDI_LIABILITY.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_MEDI_LIABILITY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_MEDI_LIABILITY.Location = New System.Drawing.Point(170, 58)
        Me.CmbDEFAULT_MEDI_LIABILITY.Name = "CmbDEFAULT_MEDI_LIABILITY"
        Me.CmbDEFAULT_MEDI_LIABILITY.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_MEDI_LIABILITY.TabIndex = 2
        Me.CmbDEFAULT_MEDI_LIABILITY.ValueMember = "GL_account"
        '
        'CmbDEFAULT_PAYROLL_BANK
        '
        Me.CmbDEFAULT_PAYROLL_BANK.DataSource = Me.DsFrmPayrollSetup1.GL_account
        Me.CmbDEFAULT_PAYROLL_BANK.DisplayMember = "desc_GL_account"
        Me.CmbDEFAULT_PAYROLL_BANK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_PAYROLL_BANK.Location = New System.Drawing.Point(170, 6)
        Me.CmbDEFAULT_PAYROLL_BANK.Name = "CmbDEFAULT_PAYROLL_BANK"
        Me.CmbDEFAULT_PAYROLL_BANK.Size = New System.Drawing.Size(120, 21)
        Me.CmbDEFAULT_PAYROLL_BANK.TabIndex = 0
        Me.CmbDEFAULT_PAYROLL_BANK.ValueMember = "GL_account"
        '
        'NumDEFAULT_MEDI_LIMITED
        '
        Me.NumDEFAULT_MEDI_LIMITED.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDEFAULT_MEDI_LIMITED.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDEFAULT_MEDI_LIMITED.DecimalDigits = 0
        Me.NumDEFAULT_MEDI_LIMITED.DefaultSendValue = False
        Me.NumDEFAULT_MEDI_LIMITED.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDEFAULT_MEDI_LIMITED.FireTabAfterEnter = True
        Me.NumDEFAULT_MEDI_LIMITED.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDEFAULT_MEDI_LIMITED.Image = CType(resources.GetObject("NumDEFAULT_MEDI_LIMITED.Image"), System.Drawing.Image)
        Me.NumDEFAULT_MEDI_LIMITED.Location = New System.Drawing.Point(442, 158)
        Me.NumDEFAULT_MEDI_LIMITED.Maxlength = 8
        Me.NumDEFAULT_MEDI_LIMITED.MinusColor = System.Drawing.Color.Empty
        Me.NumDEFAULT_MEDI_LIMITED.Name = "NumDEFAULT_MEDI_LIMITED"
        Me.NumDEFAULT_MEDI_LIMITED.Size = New System.Drawing.Size(120, 22)
        Me.NumDEFAULT_MEDI_LIMITED.TabIndex = 14
        Me.NumDEFAULT_MEDI_LIMITED.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDEFAULT_MEDI_LIMITED.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDEFAULT_FICA_LIMITED
        '
        Me.NumDEFAULT_FICA_LIMITED.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDEFAULT_FICA_LIMITED.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDEFAULT_FICA_LIMITED.DecimalDigits = 0
        Me.NumDEFAULT_FICA_LIMITED.DefaultSendValue = False
        Me.NumDEFAULT_FICA_LIMITED.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDEFAULT_FICA_LIMITED.FireTabAfterEnter = True
        Me.NumDEFAULT_FICA_LIMITED.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDEFAULT_FICA_LIMITED.Image = CType(resources.GetObject("NumDEFAULT_FICA_LIMITED.Image"), System.Drawing.Image)
        Me.NumDEFAULT_FICA_LIMITED.Location = New System.Drawing.Point(442, 133)
        Me.NumDEFAULT_FICA_LIMITED.Maxlength = 8
        Me.NumDEFAULT_FICA_LIMITED.MinusColor = System.Drawing.Color.Empty
        Me.NumDEFAULT_FICA_LIMITED.Name = "NumDEFAULT_FICA_LIMITED"
        Me.NumDEFAULT_FICA_LIMITED.Size = New System.Drawing.Size(120, 22)
        Me.NumDEFAULT_FICA_LIMITED.TabIndex = 13
        Me.NumDEFAULT_FICA_LIMITED.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDEFAULT_FICA_LIMITED.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(288, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 19)
        Me.Label10.TabIndex = 392
        Me.Label10.Text = "MEDI Limit $"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(289, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 19)
        Me.Label11.TabIndex = 391
        Me.Label11.Text = "FICA Limit $"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(291, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 19)
        Me.Label13.TabIndex = 390
        Me.Label13.Text = "Garnishment Account No"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(291, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 19)
        Me.Label14.TabIndex = 389
        Me.Label14.Text = "Employee MEDI Account No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(285, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 19)
        Me.Label15.TabIndex = 388
        Me.Label15.Text = "Employer MEDI Account No"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(286, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 20)
        Me.Label16.TabIndex = 386
        Me.Label16.Text = "Employee FICA Account No"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(287, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 20)
        Me.Label17.TabIndex = 384
        Me.Label17.Text = "Employer FICA Account No"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(1, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 19)
        Me.Label4.TabIndex = 381
        Me.Label4.Text = "Federal Withholding Account No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(0, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 19)
        Me.Label8.TabIndex = 369
        Me.Label8.Text = "State Tax Liability Account No"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(-1, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 19)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Local Tax Liability Account No"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(-3, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 19)
        Me.Label5.TabIndex = 367
        Me.Label5.Text = "MEDI Expense Account No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(-3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 19)
        Me.Label3.TabIndex = 365
        Me.Label3.Text = "FICA Expense Account No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(-8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 20)
        Me.Label2.TabIndex = 364
        Me.Label2.Text = "MEDI Liability Account No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(-6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 20)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "FICA Liability Account No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(-8, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 20)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "Payroll Bank Account No"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Numaaaa)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(566, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rules"
        '
        'CmdGeneralForMDB
        '
        Me.CmdGeneralForMDB.Connection = Me.CnnMDB
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
        'Numaaaa
        '
        Me.Numaaaa.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numaaaa.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numaaaa.DecimalDigits = 2
        Me.Numaaaa.DefaultSendValue = False
        Me.Numaaaa.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numaaaa.FireTabAfterEnter = True
        Me.Numaaaa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numaaaa.Image = CType(resources.GetObject("Numaaaa.Image"), System.Drawing.Image)
        Me.Numaaaa.Location = New System.Drawing.Point(121, 9)
        Me.Numaaaa.Maxlength = 10
        Me.Numaaaa.MinusColor = System.Drawing.Color.Empty
        Me.Numaaaa.Name = "Numaaaa"
        Me.Numaaaa.Size = New System.Drawing.Size(110, 22)
        Me.Numaaaa.TabIndex = 430
        Me.Numaaaa.TabStop = False
        Me.Numaaaa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numaaaa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(10, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 19)
        Me.Label18.TabIndex = 431
        Me.Label18.Text = "Wage Limit"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmPayrollSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(579, 339)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPayrollSetup"
        Me.Text = "Payroll Setup"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DsFrmPayrollSetup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPayrollSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables

        DsFrmPayrollSetup1.Clear()
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account1")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account2")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account3")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account4")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account5")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account6")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account7")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account8")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account9")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account10")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account11")
        DAGL_account.Fill(DsFrmPayrollSetup1, "GL_account12")

        DsFrmPayrollSetup1.GL_account.AddGL_accountRow("", "")
        DsFrmPayrollSetup1.GL_account1.AddGL_account1Row("", "")
        DsFrmPayrollSetup1.GL_account2.AddGL_account2Row("", "")
        DsFrmPayrollSetup1.GL_account3.AddGL_account3Row("", "")
        DsFrmPayrollSetup1.GL_account4.AddGL_account4Row("", "")
        DsFrmPayrollSetup1.GL_account5.AddGL_account5Row("", "")
        DsFrmPayrollSetup1.GL_account6.AddGL_account6Row("", "")
        DsFrmPayrollSetup1.GL_account7.AddGL_account7Row("", "")
        DsFrmPayrollSetup1.GL_account8.AddGL_account8Row("", "")
        DsFrmPayrollSetup1.GL_account9.AddGL_account9Row("", "")
        DsFrmPayrollSetup1.GL_account10.AddGL_account10Row("", "")
        DsFrmPayrollSetup1.GL_account11.AddGL_account11Row("", "")
        DsFrmPayrollSetup1.GL_account12.AddGL_account12Row("", "")


        If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDB.Connection.Open()
        End If
        Try
            CmdGeneralForMDB.CommandText = "ALTER TABLE Payroll_setup ADD aaaaa Number "
            CmdGeneralForMDB.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrievePayrollSetupTable()

        Try
            CmbDEFAULT_EMPLOYEE_FICA.SelectedValue = OleDbReader.Item("DEFAULT_EMPLOYEE_FICA") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_EMPLOYEE_MEDI.SelectedValue = OleDbReader.Item("DEFAULT_EMPLOYEE_MEDI") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_EMPLOYER_FICA.SelectedValue = OleDbReader.Item("DEFAULT_EMPLOYER_FICA") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_EMPLOYER_MEDI.SelectedValue = OleDbReader.Item("DEFAULT_EMPLOYER_MEDI") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_FEDERAL_WITHHOLDING.SelectedValue = OleDbReader.Item("DEFAULT_FEDERAL_WITHHOLDING") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_FICA_EXPENSE.SelectedValue = OleDbReader.Item("DEFAULT_FICA_EXPENSE") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_FICA_LIABILITY.SelectedValue = OleDbReader.Item("DEFAULT_FICA_LIABILITY") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_GARNISHMENT.SelectedValue = OleDbReader.Item("DEFAULT_GARNISHMENT") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_LOCAL_TAX.SelectedValue = OleDbReader.Item("DEFAULT_LOCAL_TAX") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_MADI_EXPENSE.SelectedValue = OleDbReader.Item("DEFAULT_MADI_EXPENSE") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_MEDI_LIABILITY.SelectedValue = OleDbReader.Item("DEFAULT_MEDI_LIABILITY") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_PAYROLL_BANK.SelectedValue = OleDbReader.Item("DEFAULT_PAYROLL_BANK") & ""
        Catch ex As Exception
        End Try
        Try
            CmbDEFAULT_STATE_TAX.SelectedValue = OleDbReader.Item("DEFAULT_STATE_TAX") & ""
        Catch ex As Exception
        End Try
        Try
            NumDEFAULT_FICA_LIMITED.Text = OleDbReader.Item("DEFAULT_FICA_LIMITED")
        Catch ex As Exception
        End Try
        Try
            NumDEFAULT_MEDI_LIMITED.Text = OleDbReader.Item("DEFAULT_MEDI_LIMITED")
        Catch ex As Exception
        End Try
        Try
            CmbPaymentDay.Text = OleDbReader.Item("DEFAULT_PaymentDay") & ""
        Catch ex As Exception
        End Try

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
    Private Sub TxtDEFAULT_EMPLOYEE_FICA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDEFAULT_EMPLOYEE_FICA.SelectedIndexChanged, CmbDEFAULT_EMPLOYEE_MEDI.SelectedIndexChanged, CmbDEFAULT_EMPLOYER_FICA.SelectedIndexChanged, CmbDEFAULT_EMPLOYER_MEDI.SelectedIndexChanged, CmbDEFAULT_FEDERAL_WITHHOLDING.SelectedIndexChanged, CmbDEFAULT_FICA_EXPENSE.SelectedIndexChanged, CmbDEFAULT_FICA_LIABILITY.SelectedIndexChanged, CmbDEFAULT_GARNISHMENT.SelectedIndexChanged, CmbDEFAULT_LOCAL_TAX.SelectedIndexChanged, CmbDEFAULT_MADI_EXPENSE.SelectedIndexChanged, CmbDEFAULT_MEDI_LIABILITY.SelectedIndexChanged, CmbDEFAULT_PAYROLL_BANK.SelectedIndexChanged, CmbDEFAULT_STATE_TAX.SelectedIndexChanged, NumDEFAULT_FICA_LIMITED.TextChanged, NumDEFAULT_MEDI_LIMITED.TextChanged, CmbPaymentDay.SelectedIndexChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Then
            BtnOk.Enabled = True
        End If
    End Sub
    Private Sub FrmPayrollSetup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
        CmdGeneralForMDB.CommandText = "Update Payroll_Setup SET DEFAULT_EMPLOYEE_FICA=" & Qt(CmbDEFAULT_EMPLOYEE_FICA.SelectedValue) & ",DEFAULT_EMPLOYEE_MEDI=" & Qt(CmbDEFAULT_EMPLOYEE_MEDI.SelectedValue) & ",DEFAULT_EMPLOYER_FICA=" & Qt(CmbDEFAULT_EMPLOYER_FICA.SelectedValue) & ",DEFAULT_EMPLOYER_MEDI=" & Qt(CmbDEFAULT_EMPLOYER_MEDI.SelectedValue) & ",DEFAULT_FEDERAL_WITHHOLDING=" & Qt(CmbDEFAULT_FEDERAL_WITHHOLDING.SelectedValue) & ",DEFAULT_FICA_EXPENSE=" & Qt(CmbDEFAULT_FICA_EXPENSE.SelectedValue) & ",DEFAULT_FICA_LIABILITY=" & Qt(CmbDEFAULT_FICA_LIABILITY.SelectedValue) & ",DEFAULT_GARNISHMENT=" & Qt(CmbDEFAULT_GARNISHMENT.SelectedValue) & ",DEFAULT_LOCAL_TAX=" & Qt(CmbDEFAULT_LOCAL_TAX.SelectedValue) & ",DEFAULT_MADI_EXPENSE=" & Qt(CmbDEFAULT_MADI_EXPENSE.SelectedValue) & ",DEFAULT_MEDI_LIABILITY=" & Qt(CmbDEFAULT_MEDI_LIABILITY.SelectedValue) & ",DEFAULT_PAYROLL_BANK=" & Qt(CmbDEFAULT_PAYROLL_BANK.SelectedValue) & ",DEFAULT_STATE_TAX=" & Qt(CmbDEFAULT_STATE_TAX.SelectedValue) & ",DEFAULT_FICA_LIMITED=" & NumDEFAULT_FICA_LIMITED.Text & ",DEFAULT_MEDI_LIMITED=" & NumDEFAULT_MEDI_LIMITED.Text & ",DEFAULT_PaymentDay=" & Qt(CmbPaymentDay.Text)
        CmdGeneralForMDB.ExecuteNonQuery()
        CmdGeneralForMDB.Connection.Close()
    End Sub
End Class
