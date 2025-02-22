Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmPayCalculation
    Inherits FrmBase
    Dim FederalTaxTableRow As DataRow
    Dim StateTaxTableRow As DataRow
    Dim ThisStoreStateVar As String
    Dim ThisYearVar As String = ""
    Dim MaxTimeOfWorkInWeek As Integer = 40
    Dim OverTimeZarib As Decimal = 1.4
    Dim StartDateVar As Integer = 3
    Dim MonthlyPersonFlag As String = "1=2"
    Dim DAEmployeeSelectCommandVar As String
    Dim FlagForShowAllPayCheck As Boolean
    Dim TotalEmployeeCounter As Integer = 0
    Dim TotalEmployeeActiveCounter As Integer = 0
    Dim TotalEmployeeCalculatedCounter As Integer = 0
    Dim SubtractFromGrosspayForCalculateTax As Decimal = 0
    Friend Id_pay_periodVar As Int64
    Dim WithEvents MyFrmCheckScreen As UcAccount.FrmCheckScreen
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
    Friend WithEvents UiProgressBar1 As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnStartCalc As Janus.Windows.EditControls.UIButton
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmPayCalculation1 As UCPayroll.DSFrmPayCalculation
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAPay_loan_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_deduction_employee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_saving_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DApay_Garnishment_employee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_federal_tax_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_state_tax_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_banks As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbId_bank As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DteCheckDate As CalendarCombo.CalendarCombo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblLastCalculatedDate As System.Windows.Forms.Label
    Friend WithEvents DApay_advance_employee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployeeCombo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnShowPayCheck As Janus.Windows.EditControls.UIButton
    Friend WithEvents CnnReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmbWeeks As System.Windows.Forms.ComboBox
    Friend WithEvents BtnShowAllPayCheck As Janus.Windows.EditControls.UIButton
    Friend WithEvents DAEmployeeOld As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCalculationErrors As System.Windows.Forms.TextBox
    Friend WithEvents CmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DAYears As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_main_employee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BtnSelectAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnDeselectAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RdoPeriod1 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoPeriod2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoPeriod3 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoPeriod4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PrintChecks As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnFish As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPayCalculation))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.UiProgressBar1 = New Janus.Windows.EditControls.UIProgressBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LblLastCalculatedDate = New System.Windows.Forms.Label
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.BtnStartCalc = New Janus.Windows.EditControls.UIButton
        Me.DsFrmPayCalculation1 = New UCPayroll.DSFrmPayCalculation
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAPay_loan_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DApay_Garnishment_employee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DApay_deduction_employee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DApay_saving_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_federal_tax_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_state_tax_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_banks = New System.Data.SqlClient.SqlDataAdapter
        Me.CmbId_bank = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DteCheckDate = New CalendarCombo.CalendarCombo
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DApay_advance_employee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployeeCombo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.BtnShowPayCheck = New Janus.Windows.EditControls.UIButton
        Me.CnnReader = New System.Data.SqlClient.SqlConnection
        Me.CmdReader = New System.Data.SqlClient.SqlCommand
        Me.TxtCalculationErrors = New System.Windows.Forms.TextBox
        Me.CmbWeeks = New System.Windows.Forms.ComboBox
        Me.BtnShowAllPayCheck = New Janus.Windows.EditControls.UIButton
        Me.DAEmployeeOld = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbYear = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DAYears = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DApay_main_employee = New System.Data.SqlClient.SqlDataAdapter
        Me.BtnSelectAll = New Janus.Windows.EditControls.UIButton
        Me.BtnDeselectAll = New Janus.Windows.EditControls.UIButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RdoPeriod4 = New System.Windows.Forms.RadioButton
        Me.RdoPeriod3 = New System.Windows.Forms.RadioButton
        Me.RdoPeriod2 = New System.Windows.Forms.RadioButton
        Me.RdoPeriod1 = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.PrintChecks = New Janus.Windows.EditControls.UIButton
        Me.BtnFish = New Janus.Windows.EditControls.UIButton
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmPayCalculation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiProgressBar1
        '
        Me.UiProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UiProgressBar1.Location = New System.Drawing.Point(9, 402)
        Me.UiProgressBar1.Name = "UiProgressBar1"
        Me.UiProgressBar1.Size = New System.Drawing.Size(684, 21)
        Me.UiProgressBar1.TabIndex = 0
        Me.UiProgressBar1.Text = "UiProgressBar1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LblLastCalculatedDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 54)
        Me.Panel1.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 21)
        Me.Label4.TabIndex = 388
        Me.Label4.Text = " Last Calculated Date "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 50)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Pay Calculation"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(611, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'LblLastCalculatedDate
        '
        Me.LblLastCalculatedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastCalculatedDate.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.LblLastCalculatedDate.Location = New System.Drawing.Point(381, 15)
        Me.LblLastCalculatedDate.Name = "LblLastCalculatedDate"
        Me.LblLastCalculatedDate.TabIndex = 389
        Me.LblLastCalculatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Location = New System.Drawing.Point(15, 425)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(61, 31)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        '
        'BtnStartCalc
        '
        Me.BtnStartCalc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnStartCalc.Location = New System.Drawing.Point(584, 425)
        Me.BtnStartCalc.Name = "BtnStartCalc"
        Me.BtnStartCalc.Size = New System.Drawing.Size(90, 31)
        Me.BtnStartCalc.TabIndex = 5
        Me.BtnStartCalc.Text = "Start Calculation"
        '
        'DsFrmPayCalculation1
        '
        Me.DsFrmPayCalculation1.DataSetName = "DSFrmPayCalculation"
        Me.DsFrmPayCalculation1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_01;password=2191110"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employee_code, '' AS PayrollDate, last_period, last_basis, 0 AS gross_pay," & _
        " 0 AS Other_Pay, l_name + ' ' + m_name + ' ' + f_name AS EmployeeFullName, CASE " & _
        "employee.last_basis WHEN '1' THEN employee.last_hourly ELSE employee.last_salary" & _
        " END AS salary, Terminated AS FlagPardakht, last_overtime, last_status, Allowanc" & _
        "e_Federal, Allowance_state, Allowance_depndnts, 0 AS id_pay_period, 0 AS Payment" & _
        "Flag, 0 AS time_work_Hour, 0 AS time_work_Minute, '' AS action_time FROM employe" & _
        "e"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand1
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT pay_loan_dtl.employee_code, pay_loan_dtl.loan_cod, pay_loan_dtl.date_start" & _
        ", pay_loan_dtl.amount_loan, pay_loan_dtl.costus, pay_loan_dtl.time_costus_pay, p" & _
        "ay_tab_loan_main.before_tax, pay_tab_loan_main.loan_desc, pay_loan_dtl.id_deduct" & _
        "ion, pay_loan_dtl.active FROM pay_loan_dtl INNER JOIN pay_tab_loan_main ON pay_l" & _
        "oan_dtl.loan_cod = pay_tab_loan_main.loan_cod WHERE (pay_loan_dtl.active = 1) AN" & _
        "D (pay_loan_dtl.employee_code = @employee_code)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'DAPay_loan_dtl
        '
        Me.DAPay_loan_dtl.SelectCommand = Me.SqlSelectCommand4
        Me.DAPay_loan_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_loan_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("loan_cod", "loan_cod"), New System.Data.Common.DataColumnMapping("date_start", "date_start"), New System.Data.Common.DataColumnMapping("amount_loan", "amount_loan"), New System.Data.Common.DataColumnMapping("costus", "costus"), New System.Data.Common.DataColumnMapping("time_costus_pay", "time_costus_pay"), New System.Data.Common.DataColumnMapping("active", "active")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id_deduction, employee_code, date_start, remark, amount_garnishment, activ" & _
        "e, ISNULL(BeforeTax, 0) AS BeforeTax FROM pay_Garnishment_employee WHERE (employ" & _
        "ee_code = @employee_code)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'DApay_Garnishment_employee
        '
        Me.DApay_Garnishment_employee.SelectCommand = Me.SqlSelectCommand5
        Me.DApay_Garnishment_employee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_Garnishment_employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_deduction", "id_deduction"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("date_start", "date_start"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("amount_garnishment", "amount_garnishment"), New System.Data.Common.DataColumnMapping("active", "active")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT pay_deduction_employee.id_deduction, pay_deduction_employee.employee_code," & _
        " pay_deduction_employee.deduction_cod, pay_deduction_employee.from_date_deductio" & _
        "n, pay_deduction_employee.to_date_deduction, pay_deduction_employee.amount_deduc" & _
        "tion, pay_deduction_employee.active, employee_deduction.deduction_desc, employee" & _
        "_deduction.befor_tax, employee_deduction.percent_gross_pay FROM pay_deduction_em" & _
        "ployee INNER JOIN employee_deduction ON pay_deduction_employee.deduction_cod = e" & _
        "mployee_deduction.deduction_cod WHERE (pay_deduction_employee.active = 1) AND (p" & _
        "ay_deduction_employee.employee_code = @employee_code)"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'DApay_deduction_employee
        '
        Me.DApay_deduction_employee.SelectCommand = Me.SqlSelectCommand6
        Me.DApay_deduction_employee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_deduction_employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_deduction", "id_deduction"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("deduction_cod", "deduction_cod"), New System.Data.Common.DataColumnMapping("from_date_deduction", "from_date_deduction"), New System.Data.Common.DataColumnMapping("to_date_deduction", "to_date_deduction"), New System.Data.Common.DataColumnMapping("amount_deduction", "amount_deduction"), New System.Data.Common.DataColumnMapping("active", "active")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT pay_saving_dtl.id_deduction, pay_saving_dtl.employee_code, pay_saving_dtl." & _
        "saving_cod, pay_saving_dtl.date_start, pay_saving_dtl.amount_employee, pay_savin" & _
        "g_dtl.amount_employer, pay_saving_dtl.time_saving_removal, pay_saving_dtl.active" & _
        ", pay_tab_saving_main.saving_desc, pay_tab_saving_main.before_tax, pay_tab_savin" & _
        "g_main.percent_gross_pay_employee, pay_tab_saving_main.percent_gross_pay_employe" & _
        "r FROM pay_saving_dtl INNER JOIN pay_tab_saving_main ON pay_saving_dtl.saving_co" & _
        "d = pay_tab_saving_main.saving_cod WHERE (pay_saving_dtl.active = 1) AND (pay_sa" & _
        "ving_dtl.employee_code = @employee_code)"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'DApay_saving_dtl
        '
        Me.DApay_saving_dtl.SelectCommand = Me.SqlSelectCommand7
        Me.DApay_saving_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_saving_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_deduction", "id_deduction"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("saving_cod", "saving_cod"), New System.Data.Common.DataColumnMapping("date_start", "date_start"), New System.Data.Common.DataColumnMapping("amount_employee", "amount_employee"), New System.Data.Common.DataColumnMapping("amount_employer", "amount_employer"), New System.Data.Common.DataColumnMapping("time_saving_removal", "time_saving_removal"), New System.Data.Common.DataColumnMapping("active", "active")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT pay_tab_federal_tax_dtl.radif, pay_tab_federal_tax_dtl.over_, pay_tab_fede" & _
        "ral_tax_dtl.but_not_over, pay_tab_federal_tax_dtl.percent_tax, pay_tab_federal_t" & _
        "ax_dtl.dollor_tax, pay_tab_federal_tax_dtl.id_federal_tax, pay_tab_federal_tax_h" & _
        "ead.withholding_allownce, pay_tab_federal_tax_head.social_sec_employee, pay_tab_" & _
        "federal_tax_head.social_sec_employer, pay_tab_federal_tax_head.social_sec_wageli" & _
        "mit, pay_tab_federal_tax_head.medi_employee, pay_tab_federal_tax_head.medi_emplo" & _
        "yer, pay_tab_federal_tax_head.medi_wagelimit, pay_tab_federal_tax_head.unemplyme" & _
        "nt_employee, pay_tab_federal_tax_head.unemplyment_employer, pay_tab_federal_tax_" & _
        "head.unemplyment_wagelimit, pay_tab_federal_tax_head.stat_code FROM pay_tab_fede" & _
        "ral_tax_dtl INNER JOIN pay_tab_federal_tax_head ON pay_tab_federal_tax_dtl.id_fe" & _
        "deral_tax = pay_tab_federal_tax_head.id_federal_tax WHERE (pay_tab_federal_tax_h" & _
        "ead.year_tax = @year_tax) ORDER BY pay_tab_federal_tax_dtl.id_federal_tax, pay_t" & _
        "ab_federal_tax_dtl.radif"
        Me.SqlSelectCommand9.Connection = Me.Cnn
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@year_tax", System.Data.SqlDbType.VarChar, 4, "year_tax"))
        '
        'DApay_tab_federal_tax_dtl
        '
        Me.DApay_tab_federal_tax_dtl.SelectCommand = Me.SqlSelectCommand9
        Me.DApay_tab_federal_tax_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_federal_tax_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_federal_tax", "id_federal_tax"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("over_", "over_"), New System.Data.Common.DataColumnMapping("but_not_over", "but_not_over"), New System.Data.Common.DataColumnMapping("percent_tax", "percent_tax"), New System.Data.Common.DataColumnMapping("dollor_tax", "dollor_tax")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT pay_tab_state_tax_dtl.radif, pay_tab_state_tax_dtl.over_, pay_tab_state_ta" & _
        "x_dtl.but_not_over, pay_tab_state_tax_dtl.percent_tax, pay_tab_state_tax_dtl.id_" & _
        "state_tax, pay_tab_state_tax_head.standard_deduction, pay_tab_state_tax_head.per" & _
        "sonal_allowance, pay_tab_state_tax_head.dependent_allowance, pay_tab_state_tax_h" & _
        "ead.stat_code, pay_tab_state_tax_dtl.dollor_tax FROM pay_tab_state_tax_dtl INNER" & _
        " JOIN pay_tab_state_tax_head ON pay_tab_state_tax_dtl.id_state_tax = pay_tab_sta" & _
        "te_tax_head.id_state_tax WHERE (pay_tab_state_tax_head.year_tax = @year_tax) AND" & _
        " (pay_tab_state_tax_head.state = @state)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@year_tax", System.Data.SqlDbType.VarChar, 4, "year_tax"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2, "state"))
        '
        'DApay_tab_state_tax_dtl
        '
        Me.DApay_tab_state_tax_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DApay_tab_state_tax_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_state_tax_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_state_tax", "id_state_tax"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("over_", "over_"), New System.Data.Common.DataColumnMapping("but_not_over", "but_not_over"), New System.Data.Common.DataColumnMapping("percent_tax", "percent_tax"), New System.Data.Common.DataColumnMapping("dollor_tax", "dollor_tax")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT id_bank, name_bank FROM bas_banks"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bas_banks(name_bank, share_all_store, store_no, account_no, address, " & _
        "zip, phone_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, pho" & _
        "ne_type_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone" & _
        "_4, extension_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5," & _
        " phone_main_5, email, contact_name, GL_Account, start_check_no, next_check_no, d" & _
        "efault_bank, inactive, cod_account_type, routing_numbers, Bank_ID, Web_Page, Use" & _
        "r_ID, Password, Security_code, online_banking) VALUES (@name_bank, @share_all_st" & _
        "ore, @store_no, @account_no, @address, @zip, @phone_1, @extension_1, @phone_type" & _
        "_1, @phone_main_1, @phone_2, @extension_2, @phone_type_2, @phone_main_2, @phone_" & _
        "3, @extension_3, @phone_type_3, @phone_main_3, @phone_4, @extension_4, @phone_ty" & _
        "pe_4, @phone_main_4, @phone_5, @extension_5, @phone_type_5, @phone_main_5, @emai" & _
        "l, @contact_name, @GL_Account, @start_check_no, @next_check_no, @default_bank, @" & _
        "inactive, @cod_account_type, @routing_numbers, @Bank_ID, @Web_Page, @User_ID, @P" & _
        "assword, @Security_code, @online_banking); SELECT id_bank, name_bank, share_all_" & _
        "store, store_no, account_no, address, zip, phone_1, extension_1, phone_type_1, p" & _
        "hone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_3, extensio" & _
        "n_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, phone_main_" & _
        "4, phone_5, extension_5, phone_type_5, phone_main_5, email, contact_name, GL_Acc" & _
        "ount, start_check_no, next_check_no, default_bank, inactive, cod_account_type, r" & _
        "outing_numbers, Bank_ID, Web_Page, User_ID, Password, Security_code, online_bank" & _
        "ing FROM bas_banks WHERE (id_bank = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@name_bank", System.Data.SqlDbType.VarChar, 50, "name_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@share_all_store", System.Data.SqlDbType.Bit, 1, "share_all_store"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_no", System.Data.SqlDbType.VarChar, 2, "store_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@account_no", System.Data.SqlDbType.VarChar, 25, "account_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 100, "email"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact_name", System.Data.SqlDbType.VarChar, 50, "contact_name"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_check_no", System.Data.SqlDbType.VarChar, 20, "start_check_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@next_check_no", System.Data.SqlDbType.VarChar, 20, "next_check_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@default_bank", System.Data.SqlDbType.Bit, 1, "default_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_account_type", System.Data.SqlDbType.VarChar, 1, "cod_account_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@routing_numbers", System.Data.SqlDbType.VarChar, 25, "routing_numbers"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank_ID", System.Data.SqlDbType.VarChar, 25, "Bank_ID"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Web_Page", System.Data.SqlDbType.VarChar, 100, "Web_Page"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User_ID", System.Data.SqlDbType.VarChar, 25, "User_ID"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 25, "Password"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Security_code", System.Data.SqlDbType.VarChar, 25, "Security_code"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@online_banking", System.Data.SqlDbType.Bit, 1, "online_banking"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bas_banks SET name_bank = @name_bank, share_all_store = @share_all_store, " & _
        "store_no = @store_no, account_no = @account_no, address = @address, zip = @zip, " & _
        "phone_1 = @phone_1, extension_1 = @extension_1, phone_type_1 = @phone_type_1, ph" & _
        "one_main_1 = @phone_main_1, phone_2 = @phone_2, extension_2 = @extension_2, phon" & _
        "e_type_2 = @phone_type_2, phone_main_2 = @phone_main_2, phone_3 = @phone_3, exte" & _
        "nsion_3 = @extension_3, phone_type_3 = @phone_type_3, phone_main_3 = @phone_main" & _
        "_3, phone_4 = @phone_4, extension_4 = @extension_4, phone_type_4 = @phone_type_4" & _
        ", phone_main_4 = @phone_main_4, phone_5 = @phone_5, extension_5 = @extension_5, " & _
        "phone_type_5 = @phone_type_5, phone_main_5 = @phone_main_5, email = @email, cont" & _
        "act_name = @contact_name, GL_Account = @GL_Account, start_check_no = @start_chec" & _
        "k_no, next_check_no = @next_check_no, default_bank = @default_bank, inactive = @" & _
        "inactive, cod_account_type = @cod_account_type, routing_numbers = @routing_numbe" & _
        "rs, Bank_ID = @Bank_ID, Web_Page = @Web_Page, User_ID = @User_ID, Password = @Pa" & _
        "ssword, Security_code = @Security_code, online_banking = @online_banking WHERE (" & _
        "id_bank = @Original_id_bank) AND (Bank_ID = @Original_Bank_ID OR @Original_Bank_" & _
        "ID IS NULL AND Bank_ID IS NULL) AND (GL_Account = @Original_GL_Account OR @Origi" & _
        "nal_GL_Account IS NULL AND GL_Account IS NULL) AND (Password = @Original_Passwor" & _
        "d OR @Original_Password IS NULL AND Password IS NULL) AND (Security_code = @Orig" & _
        "inal_Security_code OR @Original_Security_code IS NULL AND Security_code IS NULL)" & _
        " AND (User_ID = @Original_User_ID OR @Original_User_ID IS NULL AND User_ID IS NU" & _
        "LL) AND (Web_Page = @Original_Web_Page OR @Original_Web_Page IS NULL AND Web_Pag" & _
        "e IS NULL) AND (account_no = @Original_account_no OR @Original_account_no IS NUL" & _
        "L AND account_no IS NULL) AND (address = @Original_address OR @Original_address " & _
        "IS NULL AND address IS NULL) AND (cod_account_type = @Original_cod_account_type " & _
        "OR @Original_cod_account_type IS NULL AND cod_account_type IS NULL) AND (contact" & _
        "_name = @Original_contact_name OR @Original_contact_name IS NULL AND contact_nam" & _
        "e IS NULL) AND (default_bank = @Original_default_bank OR @Original_default_bank " & _
        "IS NULL AND default_bank IS NULL) AND (email = @Original_email OR @Original_emai" & _
        "l IS NULL AND email IS NULL) AND (extension_1 = @Original_extension_1 OR @Origin" & _
        "al_extension_1 IS NULL AND extension_1 IS NULL) AND (extension_2 = @Original_ext" & _
        "ension_2 OR @Original_extension_2 IS NULL AND extension_2 IS NULL) AND (extensio" & _
        "n_3 = @Original_extension_3 OR @Original_extension_3 IS NULL AND extension_3 IS " & _
        "NULL) AND (extension_4 = @Original_extension_4 OR @Original_extension_4 IS NULL " & _
        "AND extension_4 IS NULL) AND (extension_5 = @Original_extension_5 OR @Original_e" & _
        "xtension_5 IS NULL AND extension_5 IS NULL) AND (inactive = @Original_inactive O" & _
        "R @Original_inactive IS NULL AND inactive IS NULL) AND (name_bank = @Original_na" & _
        "me_bank OR @Original_name_bank IS NULL AND name_bank IS NULL) AND (next_check_no" & _
        " = @Original_next_check_no OR @Original_next_check_no IS NULL AND next_check_no " & _
        "IS NULL) AND (online_banking = @Original_online_banking OR @Original_online_bank" & _
        "ing IS NULL AND online_banking IS NULL) AND (phone_1 = @Original_phone_1 OR @Ori" & _
        "ginal_phone_1 IS NULL AND phone_1 IS NULL) AND (phone_2 = @Original_phone_2 OR @" & _
        "Original_phone_2 IS NULL AND phone_2 IS NULL) AND (phone_3 = @Original_phone_3 O" & _
        "R @Original_phone_3 IS NULL AND phone_3 IS NULL) AND (phone_4 = @Original_phone_" & _
        "4 OR @Original_phone_4 IS NULL AND phone_4 IS NULL) AND (phone_5 = @Original_pho" & _
        "ne_5 OR @Original_phone_5 IS NULL AND phone_5 IS NULL) AND (phone_main_1 = @Orig" & _
        "inal_phone_main_1 OR @Original_phone_main_1 IS NULL AND phone_main_1 IS NULL) AN" & _
        "D (phone_main_2 = @Original_phone_main_2 OR @Original_phone_main_2 IS NULL AND p" & _
        "hone_main_2 IS NULL) AND (phone_main_3 = @Original_phone_main_3 OR @Original_pho" & _
        "ne_main_3 IS NULL AND phone_main_3 IS NULL) AND (phone_main_4 = @Original_phone_" & _
        "main_4 OR @Original_phone_main_4 IS NULL AND phone_main_4 IS NULL) AND (phone_ma" & _
        "in_5 = @Original_phone_main_5 OR @Original_phone_main_5 IS NULL AND phone_main_5" & _
        " IS NULL) AND (phone_type_1 = @Original_phone_type_1 OR @Original_phone_type_1 I" & _
        "S NULL AND phone_type_1 IS NULL) AND (phone_type_2 = @Original_phone_type_2 OR @" & _
        "Original_phone_type_2 IS NULL AND phone_type_2 IS NULL) AND (phone_type_3 = @Ori" & _
        "ginal_phone_type_3 OR @Original_phone_type_3 IS NULL AND phone_type_3 IS NULL) A" & _
        "ND (phone_type_4 = @Original_phone_type_4 OR @Original_phone_type_4 IS NULL AND " & _
        "phone_type_4 IS NULL) AND (phone_type_5 = @Original_phone_type_5 OR @Original_ph" & _
        "one_type_5 IS NULL AND phone_type_5 IS NULL) AND (routing_numbers = @Original_ro" & _
        "uting_numbers OR @Original_routing_numbers IS NULL AND routing_numbers IS NULL) " & _
        "AND (share_all_store = @Original_share_all_store OR @Original_share_all_store IS" & _
        " NULL AND share_all_store IS NULL) AND (start_check_no = @Original_start_check_n" & _
        "o OR @Original_start_check_no IS NULL AND start_check_no IS NULL) AND (store_no " & _
        "= @Original_store_no OR @Original_store_no IS NULL AND store_no IS NULL) AND (zi" & _
        "p = @Original_zip OR @Original_zip IS NULL AND zip IS NULL); SELECT id_bank, nam" & _
        "e_bank, share_all_store, store_no, account_no, address, zip, phone_1, extension_" & _
        "1, phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2," & _
        " phone_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_t" & _
        "ype_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, co" & _
        "ntact_name, GL_Account, start_check_no, next_check_no, default_bank, inactive, c" & _
        "od_account_type, routing_numbers, Bank_ID, Web_Page, User_ID, Password, Security" & _
        "_code, online_banking FROM bas_banks WHERE (id_bank = @id_bank)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@name_bank", System.Data.SqlDbType.VarChar, 50, "name_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@share_all_store", System.Data.SqlDbType.Bit, 1, "share_all_store"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_no", System.Data.SqlDbType.VarChar, 2, "store_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@account_no", System.Data.SqlDbType.VarChar, 25, "account_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 100, "email"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact_name", System.Data.SqlDbType.VarChar, 50, "contact_name"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_check_no", System.Data.SqlDbType.VarChar, 20, "start_check_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@next_check_no", System.Data.SqlDbType.VarChar, 20, "next_check_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@default_bank", System.Data.SqlDbType.Bit, 1, "default_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_account_type", System.Data.SqlDbType.VarChar, 1, "cod_account_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@routing_numbers", System.Data.SqlDbType.VarChar, 25, "routing_numbers"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank_ID", System.Data.SqlDbType.VarChar, 25, "Bank_ID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Web_Page", System.Data.SqlDbType.VarChar, 100, "Web_Page"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User_ID", System.Data.SqlDbType.VarChar, 25, "User_ID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 25, "Password"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Security_code", System.Data.SqlDbType.VarChar, 25, "Security_code"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@online_banking", System.Data.SqlDbType.Bit, 1, "online_banking"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bank_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Security_code", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Security_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_User_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Web_Page", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Web_Page", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_account_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "account_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_account_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_account_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contact_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contact_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_default_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "default_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_name_bank", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "name_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_next_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "next_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_online_banking", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "online_banking", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_routing_numbers", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "routing_numbers", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_share_all_store", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "share_all_store", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_start_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "start_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_no", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bas_banks WHERE (id_bank = @Original_id_bank) AND (Bank_ID = @Origina" & _
        "l_Bank_ID OR @Original_Bank_ID IS NULL AND Bank_ID IS NULL) AND (GL_Account = @O" & _
        "riginal_GL_Account OR @Original_GL_Account IS NULL AND GL_Account IS NULL) AND (" & _
        "Password = @Original_Password OR @Original_Password IS NULL AND Password IS NULL" & _
        ") AND (Security_code = @Original_Security_code OR @Original_Security_code IS NUL" & _
        "L AND Security_code IS NULL) AND (User_ID = @Original_User_ID OR @Original_User_" & _
        "ID IS NULL AND User_ID IS NULL) AND (Web_Page = @Original_Web_Page OR @Original_" & _
        "Web_Page IS NULL AND Web_Page IS NULL) AND (account_no = @Original_account_no OR" & _
        " @Original_account_no IS NULL AND account_no IS NULL) AND (address = @Original_a" & _
        "ddress OR @Original_address IS NULL AND address IS NULL) AND (cod_account_type =" & _
        " @Original_cod_account_type OR @Original_cod_account_type IS NULL AND cod_accoun" & _
        "t_type IS NULL) AND (contact_name = @Original_contact_name OR @Original_contact_" & _
        "name IS NULL AND contact_name IS NULL) AND (default_bank = @Original_default_ban" & _
        "k OR @Original_default_bank IS NULL AND default_bank IS NULL) AND (email = @Orig" & _
        "inal_email OR @Original_email IS NULL AND email IS NULL) AND (extension_1 = @Ori" & _
        "ginal_extension_1 OR @Original_extension_1 IS NULL AND extension_1 IS NULL) AND " & _
        "(extension_2 = @Original_extension_2 OR @Original_extension_2 IS NULL AND extens" & _
        "ion_2 IS NULL) AND (extension_3 = @Original_extension_3 OR @Original_extension_3" & _
        " IS NULL AND extension_3 IS NULL) AND (extension_4 = @Original_extension_4 OR @O" & _
        "riginal_extension_4 IS NULL AND extension_4 IS NULL) AND (extension_5 = @Origina" & _
        "l_extension_5 OR @Original_extension_5 IS NULL AND extension_5 IS NULL) AND (ina" & _
        "ctive = @Original_inactive OR @Original_inactive IS NULL AND inactive IS NULL) A" & _
        "ND (name_bank = @Original_name_bank OR @Original_name_bank IS NULL AND name_bank" & _
        " IS NULL) AND (next_check_no = @Original_next_check_no OR @Original_next_check_n" & _
        "o IS NULL AND next_check_no IS NULL) AND (online_banking = @Original_online_bank" & _
        "ing OR @Original_online_banking IS NULL AND online_banking IS NULL) AND (phone_1" & _
        " = @Original_phone_1 OR @Original_phone_1 IS NULL AND phone_1 IS NULL) AND (phon" & _
        "e_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AND phone_2 IS NULL) AND (p" & _
        "hone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL AND phone_3 IS NULL) AND" & _
        " (phone_4 = @Original_phone_4 OR @Original_phone_4 IS NULL AND phone_4 IS NULL) " & _
        "AND (phone_5 = @Original_phone_5 OR @Original_phone_5 IS NULL AND phone_5 IS NUL" & _
        "L) AND (phone_main_1 = @Original_phone_main_1 OR @Original_phone_main_1 IS NULL " & _
        "AND phone_main_1 IS NULL) AND (phone_main_2 = @Original_phone_main_2 OR @Origina" & _
        "l_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (phone_main_3 = @Original_p" & _
        "hone_main_3 OR @Original_phone_main_3 IS NULL AND phone_main_3 IS NULL) AND (pho" & _
        "ne_main_4 = @Original_phone_main_4 OR @Original_phone_main_4 IS NULL AND phone_m" & _
        "ain_4 IS NULL) AND (phone_main_5 = @Original_phone_main_5 OR @Original_phone_mai" & _
        "n_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1 = @Original_phone_type_1" & _
        " OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NULL) AND (phone_type_2 =" & _
        " @Original_phone_type_2 OR @Original_phone_type_2 IS NULL AND phone_type_2 IS NU" & _
        "LL) AND (phone_type_3 = @Original_phone_type_3 OR @Original_phone_type_3 IS NULL" & _
        " AND phone_type_3 IS NULL) AND (phone_type_4 = @Original_phone_type_4 OR @Origin" & _
        "al_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (phone_type_5 = @Original_" & _
        "phone_type_5 OR @Original_phone_type_5 IS NULL AND phone_type_5 IS NULL) AND (ro" & _
        "uting_numbers = @Original_routing_numbers OR @Original_routing_numbers IS NULL A" & _
        "ND routing_numbers IS NULL) AND (share_all_store = @Original_share_all_store OR " & _
        "@Original_share_all_store IS NULL AND share_all_store IS NULL) AND (start_check_" & _
        "no = @Original_start_check_no OR @Original_start_check_no IS NULL AND start_chec" & _
        "k_no IS NULL) AND (store_no = @Original_store_no OR @Original_store_no IS NULL A" & _
        "ND store_no IS NULL) AND (zip = @Original_zip OR @Original_zip IS NULL AND zip I" & _
        "S NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bank_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Security_code", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Security_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_User_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Web_Page", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Web_Page", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_account_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "account_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_account_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_account_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contact_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contact_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_default_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "default_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_name_bank", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "name_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_next_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "next_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_online_banking", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "online_banking", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_routing_numbers", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "routing_numbers", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_share_all_store", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "share_all_store", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_start_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "start_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_no", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_banks
        '
        Me.DAbas_banks.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAbas_banks.InsertCommand = Me.SqlInsertCommand2
        Me.DAbas_banks.SelectCommand = Me.SqlSelectCommand8
        Me.DAbas_banks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        Me.DAbas_banks.UpdateCommand = Me.SqlUpdateCommand2
        '
        'CmbId_bank
        '
        Me.CmbId_bank.DataSource = Me.DsFrmPayCalculation1.bas_banks
        Me.CmbId_bank.DisplayMember = "name_bank"
        Me.CmbId_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbId_bank.Location = New System.Drawing.Point(69, 60)
        Me.CmbId_bank.Name = "CmbId_bank"
        Me.CmbId_bank.Size = New System.Drawing.Size(207, 21)
        Me.CmbId_bank.TabIndex = 0
        Me.CmbId_bank.ValueMember = "id_bank"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(4, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 387
        Me.Label3.Text = "Bank Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(232, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 390
        Me.Label1.Text = "Payroll Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(278, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 392
        Me.Label2.Text = "Check Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DteCheckDate
        '
        Me.DteCheckDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteCheckDate.BorderColor = System.Drawing.Color.Empty
        Me.DteCheckDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteCheckDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteCheckDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteCheckDate.EditableSal = True
        Me.DteCheckDate.Image = CType(resources.GetObject("DteCheckDate.Image"), System.Drawing.Image)
        Me.DteCheckDate.Location = New System.Drawing.Point(347, 59)
        Me.DteCheckDate.MaxValue = CType(2500, Short)
        Me.DteCheckDate.MinValue = CType(1800, Short)
        Me.DteCheckDate.Name = "DteCheckDate"
        Me.DteCheckDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteCheckDate.Sal_Mali = Nothing
        Me.DteCheckDate.ShowButton = True
        Me.DteCheckDate.Size = New System.Drawing.Size(107, 23)
        Me.DteCheckDate.TabIndex = 1
        Me.DteCheckDate.VisualStyle = False
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DApay_advance_employee
        '
        Me.DApay_advance_employee.SelectCommand = Me.SqlCommand1
        Me.DApay_advance_employee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_advance_employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_deduction", "id_deduction"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("pay_date", "pay_date"), New System.Data.Common.DataColumnMapping("pay_amount", "pay_amount"), New System.Data.Common.DataColumnMapping("active", "active")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT id_deduction, employee_code, pay_date, pay_amount, active FROM pay_advance" & _
        "_employee WHERE (employee_code = @employee_code)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'DAEmployeeCombo
        '
        Me.DAEmployeeCombo.SelectCommand = Me.SqlCommand2
        Me.DAEmployeeCombo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT employee_code, l_name + ' ' + m_name + ' ' + f_name AS EmployeeFullName FR" & _
        "OM employee"
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "employee"
        Me.GridEX1.DataSource = Me.DsFrmPayCalculation1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>employee</Caption><Columns Collection=""true" & _
        """><Column0 ID=""FlagPardakht""><ColumnType>CheckBox</ColumnType><DataMember>FlagPa" & _
        "rdakht</DataMember><EditType>CheckBox</EditType><Key>FlagPardakht</Key><Position" & _
        ">0</Position><Width>18</Width><CellStyle><BackColor>255, 255, 192</BackColor></C" & _
        "ellStyle></Column0><Column1 ID=""employee_code""><Caption>Employee</Caption><DataM" & _
        "ember>employee_code</DataMember><DefaultGroupInterval>Text</DefaultGroupInterval" & _
        "><EditType>NoEdit</EditType><Key>employee_code</Key><Position>1</Position><Compa" & _
        "reTarget>Text</CompareTarget><Width>159</Width><DropDownIndex>0</DropDownIndex><" & _
        "/Column1><Column2 ID=""last_period""><Caption>Period</Caption><DataMember>last_per" & _
        "iod</DataMember><DefaultGroupInterval>Text</DefaultGroupInterval><EditType>NoEdi" & _
        "t</EditType><Key>last_period</Key><Position>2</Position><CompareTarget>Text</Com" & _
        "pareTarget><Width>72</Width><DropDownIndex>2</DropDownIndex></Column2><Column3 I" & _
        "D=""last_basis""><Caption>Basis</Caption><DataMember>last_basis</DataMember><Defau" & _
        "ltGroupInterval>Text</DefaultGroupInterval><EditType>NoEdit</EditType><Key>last_" & _
        "basis</Key><Position>3</Position><CompareTarget>Text</CompareTarget><Width>68</W" & _
        "idth><DropDownIndex>1</DropDownIndex></Column3><Column4 ID=""Rate""><Caption>Rate<" & _
        "/Caption><DataMember>salary</DataMember><EditType>NoEdit</EditType><FormatString" & _
        ">c2</FormatString><Key>Rate</Key><Position>4</Position><TextAlignment>Far</TextA" & _
        "lignment><Width>59</Width></Column4><Column5 ID=""time_work""><Caption>Hours</Capt" & _
        "ion><DataMember>time_work</DataMember><EditType>NoEdit</EditType><Key>time_work<" & _
        "/Key><Position>5</Position><Width>44</Width></Column5><Column6 ID=""MaxPayrollDat" & _
        "e""><Caption>Last Pay Date</Caption><DataMember>MaxPayrollDate</DataMember><EditT" & _
        "ype>NoEdit</EditType><Key>MaxPayrollDate</Key><Position>6</Position><Width>81</W" & _
        "idth></Column6><Column7 ID=""Other_Pay""><Caption>Comm/Other</Caption><DataMember>" & _
        "Other_Pay</DataMember><FormatString>c2</FormatString><Key>Other_Pay</Key><Positi" & _
        "on>7</Position><TextAlignment>Far</TextAlignment><Width>75</Width></Column7><Col" & _
        "umn8 ID=""gross_pay""><Caption>Gross Pay</Caption><DataMember>gross_pay</DataMembe" & _
        "r><EditType>NoEdit</EditType><FormatString>c2</FormatString><Key>gross_pay</Key>" & _
        "<Position>8</Position><TextAlignment>Far</TextAlignment><Width>68</Width></Colum" & _
        "n8><Column9 ID=""action_time_hour""><Caption>action_time_hour</Caption><DataMember" & _
        ">action_time_hour</DataMember><EditType>NoEdit</EditType><Key>action_time_hour</" & _
        "Key><Position>9</Position><Visible>False</Visible></Column9><Column10 ID=""action" & _
        "_time_minute""><Caption>action_time_minute</Caption><DataMember>action_time_minut" & _
        "e</DataMember><EditType>NoEdit</EditType><Key>action_time_minute</Key><Position>" & _
        "10</Position><Visible>False</Visible></Column10><Column11 ID=""id_pay_period""><Ca" & _
        "ption>id_pay_period</Caption><DataMember>id_pay_period</DataMember><EditType>NoE" & _
        "dit</EditType><Key>id_pay_period</Key><Position>11</Position><Visible>False</Vis" & _
        "ible></Column11><Column12 ID=""PaymentFlag""><Caption>OK</Caption><ColumnType>Chec" & _
        "kBox</ColumnType><DataMember>PaymentFlag</DataMember><EditType>NoEdit</EditType>" & _
        "<Key>PaymentFlag</Key><Position>12</Position><Width>26</Width></Column12></Colum" & _
        "ns><GroupCondition ID="""" /><Key>employee</Key></RootTable><DropDowns Collection=" & _
        """true""><DropDown0><RootTable><Columns Collection=""true""><Column0 ID=""EmployeeFul" & _
        "lName""><Caption>EmployeeFullName</Caption><DataMember>EmployeeFullName</DataMemb" & _
        "er><Key>EmployeeFullName</Key><Position>0</Position><Width>300</Width></Column0>" & _
        "</Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft " & _
        "Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><Expandable" & _
        "Groups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><Hide" & _
        "Selection>Highlight</HideSelection><Key>EmployeeCombo</Key><DisplayMember>Employ" & _
        "eeFullName</DisplayMember><ValueMember>employee_code</ValueMember></DropDown0><D" & _
        "ropDown1><RootTable><Columns Collection=""true""><Column0 ID=""Desc""><Caption>Desc<" & _
        "/Caption><DataMember>Desc</DataMember><Key>Desc</Key><Position>0</Position></Col" & _
        "umn0></Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Micro" & _
        "soft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><Expan" & _
        "dableGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible>" & _
        "<HideSelection>Highlight</HideSelection><Key>Last_BasisCombo</Key><DisplayMember" & _
        ">Desc</DisplayMember><ValueMember>Code</ValueMember></DropDown1><DropDown2><Root" & _
        "Table><Columns Collection=""true""><Column0 ID=""Desc""><Caption>Desc</Caption><Data" & _
        "Member>Desc</DataMember><Key>Desc</Key><Position>0</Position></Column0></Columns" & _
        "><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans Seri" & _
        "f, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><ExpandableGroups>Fa" & _
        "lse</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection" & _
        ">Highlight</HideSelection><Key>Last_PeriodCombo</Key><DisplayMember>Desc</Displa" & _
        "yMember><ValueMember>Code</ValueMember></DropDown2></DropDowns></GridEXLayoutDat" & _
        "a>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(2, 115)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(694, 168)
        Me.GridEX1.TabIndex = 4
        '
        'BtnShowPayCheck
        '
        Me.BtnShowPayCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnShowPayCheck.Location = New System.Drawing.Point(478, 425)
        Me.BtnShowPayCheck.Name = "BtnShowPayCheck"
        Me.BtnShowPayCheck.Size = New System.Drawing.Size(90, 31)
        Me.BtnShowPayCheck.TabIndex = 6
        Me.BtnShowPayCheck.Text = "Show PayCheck"
        '
        'CnnReader
        '
        Me.CnnReader.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'CmdReader
        '
        Me.CmdReader.Connection = Me.CnnReader
        '
        'TxtCalculationErrors
        '
        Me.TxtCalculationErrors.Location = New System.Drawing.Point(9, 305)
        Me.TxtCalculationErrors.Multiline = True
        Me.TxtCalculationErrors.Name = "TxtCalculationErrors"
        Me.TxtCalculationErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCalculationErrors.Size = New System.Drawing.Size(684, 94)
        Me.TxtCalculationErrors.TabIndex = 395
        Me.TxtCalculationErrors.Text = ""
        '
        'CmbWeeks
        '
        Me.CmbWeeks.DataSource = Me.DsFrmPayCalculation1.YearWeeks
        Me.CmbWeeks.DisplayMember = "Desc"
        Me.CmbWeeks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWeeks.Location = New System.Drawing.Point(303, 90)
        Me.CmbWeeks.Name = "CmbWeeks"
        Me.CmbWeeks.Size = New System.Drawing.Size(201, 21)
        Me.CmbWeeks.TabIndex = 3
        Me.CmbWeeks.ValueMember = "WeekNo"
        '
        'BtnShowAllPayCheck
        '
        Me.BtnShowAllPayCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnShowAllPayCheck.Location = New System.Drawing.Point(372, 425)
        Me.BtnShowAllPayCheck.Name = "BtnShowAllPayCheck"
        Me.BtnShowAllPayCheck.Size = New System.Drawing.Size(90, 31)
        Me.BtnShowAllPayCheck.TabIndex = 7
        Me.BtnShowAllPayCheck.Text = "Show All PayChecks"
        '
        'DAEmployeeOld
        '
        Me.DAEmployeeOld.SelectCommand = Me.SqlCommand3
        Me.DAEmployeeOld.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT employee.employee_code, ISNULL(pay_main_employee.PayrollDate, '') AS Payro" & _
        "llDate, employee.last_period, employee.last_basis, ISNULL(pay_main_employee.gros" & _
        "s_pay, 0) AS gross_pay, ISNULL(pay_main_employee.Other_Pay, 0) AS Other_Pay, emp" & _
        "loyee.l_name + ' ' + employee.m_name + ' ' + employee.f_name AS EmployeeFullName" & _
        ", CASE employee.last_basis WHEN '1' THEN employee.last_hourly ELSE employee.last" & _
        "_salary END AS salary, employee.Terminated AS FlagPardakht, employee.last_overti" & _
        "me, employee.last_status, employee.Allowance_Federal, employee.Allowance_state, " & _
        "employee.Allowance_depndnts, ISNULL(pay_main_employee.id_pay_period, 0) AS id_pa" & _
        "y_period, ISNULL(pay_main_employee.PaymentFlag, 0) AS PaymentFlag, ISNULL(SUM(CA" & _
        "ST(pay_main_employee.time_work_Hour AS integer)) + ROUND(SUM(CAST(pay_main_emplo" & _
        "yee.time_work_Minute AS integer)) / 60, 0), 0) AS action_time_hour, ISNULL(SUM(C" & _
        "AST(pay_main_employee.time_work_Minute AS integer)), 0) AS action_time_minute, R" & _
        "TRIM(LTRIM(CAST(SUM(CAST(pay_main_employee.time_work_Hour AS integer)) + ROUND(S" & _
        "UM(CAST(pay_main_employee.time_work_Minute AS integer)) / 60, 0) AS char))) + ':" & _
        "' + RTRIM(LTRIM(CAST(SUM(CAST(pay_main_employee.time_work_Minute AS integer)) AS" & _
        " char))) AS action_time FROM employee LEFT OUTER JOIN pay_main_employee ON emplo" & _
        "yee.employee_code = pay_main_employee.employee_code"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(294, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 21)
        Me.Label5.TabIndex = 398
        Me.Label5.Text = "Calculation Errors"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbYear
        '
        Me.CmbYear.DataSource = Me.DsFrmPayCalculation1.Years
        Me.CmbYear.DisplayMember = "YearNo"
        Me.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYear.Location = New System.Drawing.Point(153, 89)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(85, 21)
        Me.CmbYear.TabIndex = 2
        Me.CmbYear.ValueMember = "YearNo"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(118, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 400
        Me.Label7.Text = "Year"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DAYears
        '
        Me.DAYears.SelectCommand = Me.SqlCommand4
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT DISTINCT SUBSTRING(action_date, 7, 4) AS YearNo FROM pay_punch_employee_in" & _
        "_out ORDER BY SUBSTRING(action_date, 7, 4) DESC"
        Me.SqlCommand4.Connection = Me.Cnn
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT pay_main_employee.id_pay_period, pay_main_employee.employee_code, ISNULL(p" & _
        "ay_main_employee.day_work, 0) AS day_work, ISNULL(pay_main_employee.time_work_Ho" & _
        "ur, 0) AS time_work_Hour, ISNULL(pay_main_employee.time_work_Minute, 0) AS time_" & _
        "work_Minute, ISNULL(pay_main_employee.Other_Pay, 0) AS Other_Pay, ISNULL(pay_mai" & _
        "n_employee.gross_pay, 0) AS gross_pay, pay_main_employee.id_check, pay_main_empl" & _
        "oyee.PaymentFlag, pay_main_employee.id_GL_journal, View_Employee_Max_PayrollDate" & _
        ".Max_PayrollDate AS Max_PayrollDate, bank_check.no_of_check, employee.f_name + '" & _
        " ' + employee.m_name + ' ' + employee.l_name AS FullName, bank_check.date_of_che" & _
        "ck FROM pay_main_employee INNER JOIN employee ON pay_main_employee.employee_code" & _
        " = employee.employee_code LEFT OUTER JOIN bank_check ON pay_main_employee.id_che" & _
        "ck = bank_check.id_check LEFT OUTER JOIN View_Employee_Max_PayrollDate ON pay_ma" & _
        "in_employee.employee_code = View_Employee_Max_PayrollDate.employee_code WHERE (p" & _
        "ay_main_employee.PayrollDate = @PayrollDate) AND (pay_main_employee.Payment_Type" & _
        " = '0')"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PayrollDate", System.Data.SqlDbType.VarChar, 10, "PayrollDate"))
        '
        'DApay_main_employee
        '
        Me.DApay_main_employee.SelectCommand = Me.SqlSelectCommand3
        Me.DApay_main_employee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_main_employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_pay_period", "id_pay_period"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("day_work", "day_work"), New System.Data.Common.DataColumnMapping("time_work_Hour", "time_work_Hour"), New System.Data.Common.DataColumnMapping("time_work_Minute", "time_work_Minute"), New System.Data.Common.DataColumnMapping("Other_Pay", "Other_Pay"), New System.Data.Common.DataColumnMapping("gross_pay", "gross_pay"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("PayrollDate", "PayrollDate"), New System.Data.Common.DataColumnMapping("PaymentFlag", "PaymentFlag"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectAll.Location = New System.Drawing.Point(5, 84)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.Size = New System.Drawing.Size(53, 28)
        Me.BtnSelectAll.TabIndex = 401
        Me.BtnSelectAll.Text = "Select All"
        '
        'BtnDeselectAll
        '
        Me.BtnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDeselectAll.Location = New System.Drawing.Point(60, 84)
        Me.BtnDeselectAll.Name = "BtnDeselectAll"
        Me.BtnDeselectAll.Size = New System.Drawing.Size(53, 28)
        Me.BtnDeselectAll.TabIndex = 402
        Me.BtnDeselectAll.Text = "Deselect All"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RdoPeriod4)
        Me.Panel2.Controls.Add(Me.RdoPeriod3)
        Me.Panel2.Controls.Add(Me.RdoPeriod2)
        Me.Panel2.Controls.Add(Me.RdoPeriod1)
        Me.Panel2.Location = New System.Drawing.Point(509, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 46)
        Me.Panel2.TabIndex = 404
        '
        'RdoPeriod4
        '
        Me.RdoPeriod4.Location = New System.Drawing.Point(106, 21)
        Me.RdoPeriod4.Name = "RdoPeriod4"
        Me.RdoPeriod4.Size = New System.Drawing.Size(64, 24)
        Me.RdoPeriod4.TabIndex = 3
        Me.RdoPeriod4.Text = "Monthly"
        '
        'RdoPeriod3
        '
        Me.RdoPeriod3.Location = New System.Drawing.Point(4, 21)
        Me.RdoPeriod3.Name = "RdoPeriod3"
        Me.RdoPeriod3.Size = New System.Drawing.Size(92, 24)
        Me.RdoPeriod3.TabIndex = 2
        Me.RdoPeriod3.Text = "Semi-Monthly"
        '
        'RdoPeriod2
        '
        Me.RdoPeriod2.Location = New System.Drawing.Point(106, 0)
        Me.RdoPeriod2.Name = "RdoPeriod2"
        Me.RdoPeriod2.Size = New System.Drawing.Size(76, 24)
        Me.RdoPeriod2.TabIndex = 1
        Me.RdoPeriod2.Text = "Bi-Weekly"
        '
        'RdoPeriod1
        '
        Me.RdoPeriod1.Location = New System.Drawing.Point(4, 0)
        Me.RdoPeriod1.Name = "RdoPeriod1"
        Me.RdoPeriod1.Size = New System.Drawing.Size(64, 24)
        Me.RdoPeriod1.TabIndex = 0
        Me.RdoPeriod1.Text = "Weekly"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(579, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 21)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "Period :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintChecks
        '
        Me.PrintChecks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrintChecks.Location = New System.Drawing.Point(266, 425)
        Me.PrintChecks.Name = "PrintChecks"
        Me.PrintChecks.Size = New System.Drawing.Size(90, 31)
        Me.PrintChecks.TabIndex = 406
        Me.PrintChecks.Text = "Print Checks"
        '
        'BtnFish
        '
        Me.BtnFish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFish.Location = New System.Drawing.Point(160, 425)
        Me.BtnFish.Name = "BtnFish"
        Me.BtnFish.Size = New System.Drawing.Size(90, 31)
        Me.BtnFish.TabIndex = 407
        Me.BtnFish.Text = "Print Stub"
        '
        'FrmPayCalculation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(703, 460)
        Me.Controls.Add(Me.CmbYear)
        Me.Controls.Add(Me.CmbWeeks)
        Me.Controls.Add(Me.BtnFish)
        Me.Controls.Add(Me.PrintChecks)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnDeselectAll)
        Me.Controls.Add(Me.BtnSelectAll)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnShowAllPayCheck)
        Me.Controls.Add(Me.TxtCalculationErrors)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.BtnShowPayCheck)
        Me.Controls.Add(Me.DteCheckDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbId_bank)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UiProgressBar1)
        Me.Controls.Add(Me.BtnStartCalc)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPayCalculation"
        Me.Text = "Pay Calculation"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsFrmPayCalculation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPayCalculation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        CnnReader.ConnectionString = PConnectionString

        DAEmployeeSelectCommandVar = DAEmployee.SelectCommand.CommandText

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Max(PayRollDate) from pay_main_employee Where Payment_Type='0'"
        Dim LastPayrollDate As String = ""
        LastPayrollDate = CmdGeneral.ExecuteScalar & ""
        LblLastCalculatedDate.Text = LastPayrollDate

        DteCheckDate.Text = Format(Now.Date, PubDateFormat)

        DAYears.Fill(DsFrmPayCalculation1.Years)

        RdoPeriod1.Checked = True

        DAbas_banks.Fill(DsFrmPayCalculation1, "bas_banks")
        DAEmployeeCombo.Fill(DsFrmPayCalculation1, "EmployeeCombo")

        DsFrmPayCalculation1.Last_BasisCombo.AddLast_BasisComboRow("1", "Hourly")
        DsFrmPayCalculation1.Last_BasisCombo.AddLast_BasisComboRow("2", "Salary")
        DsFrmPayCalculation1.Last_BasisCombo.AddLast_BasisComboRow("3", "Commission")
        DsFrmPayCalculation1.Last_BasisCombo.AddLast_BasisComboRow("4", "Piece Work")

        DsFrmPayCalculation1.Last_PeriodCombo.AddLast_PeriodComboRow("1", "Weekly")
        DsFrmPayCalculation1.Last_PeriodCombo.AddLast_PeriodComboRow("2", "Bi-Weekly")
        DsFrmPayCalculation1.Last_PeriodCombo.AddLast_PeriodComboRow("3", "SemiMonthly")
        DsFrmPayCalculation1.Last_PeriodCombo.AddLast_PeriodComboRow("4", "Monthly")

        GridEX1.DropDowns("EmployeeCombo").SetDataBinding(DsFrmPayCalculation1, "EmployeeCombo")
        GridEX1.DropDowns("Last_BasisCombo").SetDataBinding(DsFrmPayCalculation1, "Last_BasisCombo")
        GridEX1.DropDowns("Last_PeriodCombo").SetDataBinding(DsFrmPayCalculation1, "Last_PeriodCombo")

        If LastPayrollDate.Trim.Length > 0 Then
            Call FillDataSet(CDate(LastPayrollDate))
        End If

        CmbId_bank.Focus()
    End Sub
    Private Sub FillDataSet(ByVal StartDate As Date)
        Dim SQLReader As System.Data.SqlClient.SqlDataReader

        If StartDate.AddDays(7).Month = StartDate.AddDays(14).Month Then
            MonthlyPersonFlag = "1=2"
        Else
            MonthlyPersonFlag = "1=1"
        End If

        'DteCheckDate.Text = MakeDateCorrect(CStr(StartDate.AddDays(7)))

        DsFrmPayCalculation1.employee.Clear()
        DAEmployee.SelectCommand.CommandText = DAEmployeeSelectCommandVar & " Where Terminated=0 AND temporary_inactive=0 "
        If RdoPeriod1.Checked Then
            DAEmployee.SelectCommand.CommandText = DAEmployee.SelectCommand.CommandText & " AND last_period=1 "
        ElseIf RdoPeriod2.Checked() Then
            DAEmployee.SelectCommand.CommandText = DAEmployee.SelectCommand.CommandText & " AND last_period=2 "
        ElseIf RdoPeriod3.Checked() Then
            DAEmployee.SelectCommand.CommandText = DAEmployee.SelectCommand.CommandText & " AND last_period=3 "
        ElseIf RdoPeriod4.Checked() Then
            DAEmployee.SelectCommand.CommandText = DAEmployee.SelectCommand.CommandText & " AND last_period=4 "
        End If
        DAEmployee.Fill(DsFrmPayCalculation1, "employee")

        DsFrmPayCalculation1.pay_main_employee.Clear()
        DApay_main_employee.SelectCommand.Parameters("@PayrollDate").Value = MakeDateCorrect(CmbWeeks.SelectedValue)
        DApay_main_employee.Fill(DsFrmPayCalculation1.pay_main_employee)

        Dim i As Integer
        Dim EmployeeRecCountTemp As Integer = DsFrmPayCalculation1.employee.Rows.Count
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        CmdGeneral.CommandText = "Select Count(*) From Employee "
        TotalEmployeeCounter = CmdGeneral.ExecuteScalar
        TotalEmployeeActiveCounter = EmployeeRecCountTemp

        Dim MaxDateTempVar As String
        If CmdReader.Connection.State <> ConnectionState.Open Then
            CmdReader.Connection.Open()
        End If
        For i = 0 To EmployeeRecCountTemp - 1
            Dim dr As DataRow
            dr = DsFrmPayCalculation1.pay_main_employee.FindByemployee_code(DsFrmPayCalculation1.employee.Rows(i).Item("employee_code"))
            If Not IsNothing(dr) Then
                DsFrmPayCalculation1.employee.Rows(i).Item("FlagPardakht") = 1
                DsFrmPayCalculation1.employee.Rows(i).Item("Gross_Pay") = dr("Gross_Pay")
                DsFrmPayCalculation1.employee.Rows(i).Item("Other_Pay") = dr("Other_Pay")
                DsFrmPayCalculation1.employee.Rows(i).Item("MaxPayrollDate") = dr("Max_PayrollDate")
                DsFrmPayCalculation1.employee.Rows(i).Item("id_pay_period") = dr("id_pay_period")
                DsFrmPayCalculation1.employee.Rows(i).Item("PaymentFlag") = dr("PaymentFlag")
                DsFrmPayCalculation1.employee.Rows(i).Item("time_work_Hour") = dr("time_work_Hour")
                DsFrmPayCalculation1.employee.Rows(i).Item("time_work_Minute") = dr("time_work_Minute")
                DsFrmPayCalculation1.employee.Rows(i).Item("action_time") = Getcod(dr("time_work_Hour"), 2) + ":" + Getcod(dr("time_work_Minute"), 2)
                DsFrmPayCalculation1.employee.Rows(i).Item("no_of_check") = dr("no_of_check") & ""
                DsFrmPayCalculation1.employee.Rows(i).Item("date_of_check") = dr("date_of_check") & ""
            Else
                DsFrmPayCalculation1.employee.Rows(i).Item("Gross_Pay") = 0
                DsFrmPayCalculation1.employee.Rows(i).Item("Other_Pay") = 0
                DsFrmPayCalculation1.employee.Rows(i).Item("no_of_check") = ""
                DsFrmPayCalculation1.employee.Rows(i).Item("date_of_check") = ""
                CmdGeneral.CommandText = "SELECT Max_PayrollDate FROM View_Employee_Max_PayrollDate Where employee_code=" & Qt(DsFrmPayCalculation1.employee.Rows(i).Item("employee_code"))
                MaxDateTempVar = CmdGeneral.ExecuteScalar & ""
                If Mid(MaxDateTempVar, 1, 2).Trim.Length > 0 Then
                    DsFrmPayCalculation1.employee.Rows(i).Item("MaxPayrollDate") = MaxDateTempVar
                End If
            End If

            CmdReader.CommandText = "SELECT " & _
                " ISNULL(SUM(CAST(action_time_hour AS integer)), 0) AS action_time_hour , " & _
                " ISNULL(SUM(CAST(action_time_minute AS integer)), 0) AS action_time_minute " & _
                " FROM pay_employee_timesheet Where employee_code=" & Qt(DsFrmPayCalculation1.employee.Rows(i).Item("employee_code"))
            Select Case DsFrmPayCalculation1.employee.Rows(i).Item("last_period")
                Case "1"
                    CmdReader.CommandText = CmdReader.CommandText & " AND dbo.ChangeDate(timesheet_date)>= " & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CmbWeeks.SelectedValue))) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CStr(CDate(CmbWeeks.SelectedValue).AddDays(6)))))
                Case "2"
                    CmdReader.CommandText = CmdReader.CommandText & " AND dbo.ChangeDate(timesheet_date)>= " & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CmbWeeks.SelectedValue))) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CStr(CDate(CmbWeeks.SelectedValue).AddDays(13)))))
                Case "3"
                    CmdReader.CommandText = CmdReader.CommandText & " AND dbo.ChangeDate(timesheet_date)>= " & Qt(ChangeDateToYYYYMMDD(CmbWeeks.SelectedValue)) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CStr(CDate(CmbWeeks.SelectedValue).AddDays(15)))))
                Case "4"
                    CmdReader.CommandText = CmdReader.CommandText & " AND dbo.ChangeDate(timesheet_date)>= " & Qt(ChangeDateToYYYYMMDD(CmbWeeks.SelectedValue)) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(Mid(ChangeDateToYYYYMMDD(CmbWeeks.SelectedValue), 1, 8) & "31")
                Case Else
                    CmdReader.CommandText = CmdReader.CommandText & " AND 1=2"
            End Select
            SQLReader = CmdReader.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                DsFrmPayCalculation1.employee.Rows(i).Item("time_work_Hour") = SQLReader.Item("action_time_Hour") + (SQLReader.Item("action_time_minute") \ 60)
                DsFrmPayCalculation1.employee.Rows(i).Item("time_work_minute") = SQLReader.Item("action_time_minute") - ((SQLReader.Item("action_time_minute") \ 60) * 60)
                DsFrmPayCalculation1.employee.Rows(i).Item("time_work") = Trim(DsFrmPayCalculation1.employee.Rows(i).Item("time_work_Hour")) + ":" + Getcod(Trim(DsFrmPayCalculation1.employee.Rows(i).Item("time_work_minute")), 2)
            End If
            SQLReader.Close()

        Next

        'DAEmployee.SelectCommand.CommandText = DAEmployee.SelectCommand.CommandText & " GROUP BY employee.employee_code, pay_main_employee.PayrollDate, employee.last_period, employee.last_basis, pay_main_employee.gross_pay, " & _
        '              " pay_main_employee.Other_Pay, employee.l_name + ' ' + employee.m_name + ' ' + employee.f_name,  " & _
        '              " CASE employee.last_basis WHEN '1' THEN employee.last_hourly ELSE employee.last_salary END, employee.Terminated, employee.last_overtime,  " & _
        '              " employee.last_status, employee.Allowance_Federal, employee.Allowance_state, employee.Allowance_depndnts, pay_main_employee.id_pay_period,pay_main_employee.PaymentFlag"
        'DAEmployee.Fill(DsFrmPayCalculation1, "employee")
        'Call SetFlagForPardakht()
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Function Checkstatus() As Boolean
        Checkstatus = True
        If Mid(MakeDateCorrect(CmbWeeks.SelectedValue), 1, 2).Trim.Length = 0 Then
            MsgBox("please Select The Payroll Date")
            Checkstatus = False
            Exit Function
        End If

        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveStoreSetupTable(PubStoreNO)
        ThisStoreStateVar = OleDbReader.Item("State") & ""
        If ThisStoreStateVar.Trim.Length = 0 Then
            MsgBox("Please Check the State Of Store Setup")
            Checkstatus = False
            Exit Function
        End If

        ThisYearVar = Mid(MakeDateCorrect(CmbWeeks.SelectedValue), 7, 4)

    End Function
    Private Sub BtnStartCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStartCalc.Click
        Dim ThisRowGrid As GridEXRow = GridEX1.GetRow
        BtnStartCalc.Enabled = False
        If Not Checkstatus() Then
            BtnStartCalc.Enabled = True
            Exit Sub
        End If

        TxtCalculationErrors.Clear()

        DsFrmPayCalculation1.pay_tab_federal_tax_dtl.Clear()
        DApay_tab_federal_tax_dtl.SelectCommand.Parameters("@year_tax").Value = ThisYearVar
        DApay_tab_federal_tax_dtl.Fill(DsFrmPayCalculation1, "pay_tab_federal_tax_dtl")

        DsFrmPayCalculation1.pay_tab_state_tax_dtl.Clear()
        DApay_tab_state_tax_dtl.SelectCommand.Parameters("@year_tax").Value = ThisYearVar
        DApay_tab_state_tax_dtl.SelectCommand.Parameters("@State").Value = ThisStoreStateVar
        DApay_tab_state_tax_dtl.Fill(DsFrmPayCalculation1, "pay_tab_state_tax_dtl")

        UiProgressBar1.Value = 0
        UiProgressBar1.Minimum = 0
        UiProgressBar1.Maximum = DsFrmPayCalculation1.employee.Rows.Count
        Id_pay_periodVar = 0
        Dim CalculationCounter As Integer = 0
        Dim GrossPayVar As Decimal = 0
        Dim OverPayVar As Decimal = 0
        Dim AnnualIncomeVar As Decimal = 0
        Dim AnnualAmountofAllowanceVar As Decimal = 0
        Dim FederalTaxAmountVar As Decimal = 0
        Dim FederalTaxVar As Decimal = 0
        Dim SocialSecurityEmployeeTaxVar As Decimal = 0
        Dim SocialSecurityEmployerTaxVar As Decimal = 0
        Dim MedicareEmployeeTaxVar As Decimal = 0
        Dim MedicareEmployerTaxVar As Decimal = 0
        Dim UnemploymentEmployeeTaxVar As Decimal = 0
        Dim UnemploymentEmployerTaxVar As Decimal = 0
        Dim StateTaxAmountVar As Decimal = 0
        Dim StateTaxVar As Decimal = 0
        Dim ZaribKindPeriod As Decimal = 0
        Dim FederalDollar_Tax As Decimal = 0
        Dim StateDollar_Tax As Decimal = 0
        Dim EmplyeeTotalYear As Decimal = 0
        Dim personal_allowance_Zarib As Integer = 1
        TotalEmployeeCalculatedCounter = 0
        With DsFrmPayCalculation1.employee
            For CalculationCounter = 0 To .Rows.Count - 1
                UiProgressBar1.Value = UiProgressBar1.Value + 1
                Application.DoEvents()
                If .Rows(CalculationCounter).RowState <> DataRowState.Deleted Then
                    If Not .Rows(CalculationCounter).Item("PaymentFlag") And CDec(.Rows(CalculationCounter).Item("id_pay_period") & "0") > 0 Then
                        If .Rows(CalculationCounter).Item("id_pay_period") > 0 Then
                            CmdGeneral.CommandText = "Delete FROM pay_deductin_main_dtl Where id_pay_period=" & .Rows(CalculationCounter).Item("id_pay_period")
                            CmdGeneral.ExecuteNonQuery()
                        End If
                    End If
                    If .Rows(CalculationCounter).Item("FlagPardakht") And Not .Rows(CalculationCounter).Item("PaymentFlag") Then
                        GrossPayVar = .Rows(CalculationCounter).Item("Salary")
                        Select Case .Rows(CalculationCounter).Item("last_period")
                            Case "1"
                                ZaribKindPeriod = 52
                            Case "2"
                                ZaribKindPeriod = 26
                            Case "3"
                                ZaribKindPeriod = 24
                            Case "4"
                                ZaribKindPeriod = 12
                        End Select

                        OverPayVar = 0
                        Select Case .Rows(CalculationCounter).Item("last_basis")
                            Case "1"
                                If .Rows(CalculationCounter).Item("time_work_Hour") >= MaxTimeOfWorkInWeek Then
                                    GrossPayVar = .Rows(CalculationCounter).Item("Salary") * MaxTimeOfWorkInWeek
                                    OverPayVar = .Rows(CalculationCounter).Item("last_overtime") * (.Rows(CalculationCounter).Item("time_work_Hour") - MaxTimeOfWorkInWeek)
                                    OverPayVar = OverPayVar + Math.Round(((.Rows(CalculationCounter).Item("last_overtime") * .Rows(CalculationCounter).Item("time_work_minute")) / 60), 2)
                                Else
                                    GrossPayVar = .Rows(CalculationCounter).Item("Salary") * .Rows(CalculationCounter).Item("time_work_Hour")
                                    GrossPayVar = GrossPayVar + Math.Round(((.Rows(CalculationCounter).Item("Salary") * .Rows(CalculationCounter).Item("time_work_minute")) / 60), 2)
                                End If
                            Case "2"
                                'Nothing
                            Case "3"
                                '??????????????
                            Case "4"
                                '??????????????
                        End Select
                        GrossPayVar = GrossPayVar + OverPayVar + .Rows(CalculationCounter).Item("Other_Pay")

                        'AnnualIncomeVar = GrossPayVar * ZaribKindPeriod

                        If GrossPayVar > 0 Then

                            If SetFederalTaxRow(.Rows(CalculationCounter).Item("last_status"), 1, FederalDollar_Tax) And SetStateTaxRow(.Rows(CalculationCounter).Item("last_status"), 1, StateDollar_Tax) Then

                                If .Rows(CalculationCounter).Item("Id_pay_period") > 0 Then
                                    Id_pay_periodVar = .Rows(CalculationCounter).Item("Id_pay_period")
                                Else
                                    CmdGeneral.CommandText = "Insert into pay_main_employee (employee_code,PayrollDate,Payment_Type) VALUES (" & Qt(.Rows(CalculationCounter).Item("employee_code")) & "," & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & ",'0') " & _
                                    ";Select id_pay_period from pay_main_employee where id_pay_period=@@IDENTITY"
                                    Id_pay_periodVar = CmdGeneral.ExecuteScalar()
                                End If

                                SubtractFromGrosspayForCalculateTax = 0
                                CalcLoan(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                CalcSaving(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                CalcAdvance(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                CalcDeduction(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                CalcGarnishment(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)

                                AnnualIncomeVar = (GrossPayVar - SubtractFromGrosspayForCalculateTax) * ZaribKindPeriod

                                AnnualAmountofAllowanceVar = FederalTaxTableRow.Item("withholding_allownce") * .Rows(CalculationCounter).Item("Allowance_Federal")
                                FederalTaxAmountVar = AnnualIncomeVar - AnnualAmountofAllowanceVar
                                If FederalTaxAmountVar < 0 Then
                                    FederalTaxAmountVar = 0
                                End If
                                If SetFederalTaxRow(.Rows(CalculationCounter).Item("last_status"), FederalTaxAmountVar, FederalDollar_Tax) Then
                                    FederalTaxVar = Math.Round((((FederalTaxAmountVar - FederalTaxTableRow.Item("over_")) * FederalTaxTableRow.Item("percent_tax")) / 100) + FederalDollar_Tax, 2)
                                    FederalTaxVar = Math.Round(FederalTaxVar / ZaribKindPeriod, 2)

                                    'SocialSecurityEmployeeTaxVar = (IIf(FederalTaxAmountVar > FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxAmountVar) * FederalTaxTableRow.Item("social_sec_employee")) / 100
                                    'SocialSecurityEmployerTaxVar = (IIf(FederalTaxAmountVar > FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxAmountVar) * FederalTaxTableRow.Item("social_sec_employer")) / 100
                                    SocialSecurityEmployeeTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxTableRow.Item("social_sec_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("social_sec_employee")) / 100
                                    SocialSecurityEmployerTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxTableRow.Item("social_sec_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("social_sec_employer")) / 100

                                    SocialSecurityEmployeeTaxVar = Math.Round(SocialSecurityEmployeeTaxVar / ZaribKindPeriod, 2)
                                    SocialSecurityEmployerTaxVar = Math.Round(SocialSecurityEmployerTaxVar / ZaribKindPeriod, 2)

                                    'MedicareEmployeeTaxVar = (IIf(FederalTaxAmountVar > FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxAmountVar) * FederalTaxTableRow.Item("medi_employee")) / 100
                                    'MedicareEmployerTaxVar = (IIf(FederalTaxAmountVar > FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxAmountVar) * FederalTaxTableRow.Item("medi_employer")) / 100
                                    MedicareEmployeeTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxTableRow.Item("medi_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("medi_employee")) / 100
                                    MedicareEmployerTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxTableRow.Item("medi_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("medi_employer")) / 100

                                    MedicareEmployeeTaxVar = Math.Round(MedicareEmployeeTaxVar / ZaribKindPeriod, 2)
                                    MedicareEmployerTaxVar = Math.Round(MedicareEmployerTaxVar / ZaribKindPeriod, 2)

                                    CmdGeneral.CommandText = "SELECT isnull(sum(gross_pay),0) FROM pay_main_employee Where substring(PayrollDate,7,4)=" & Qt(CmbYear.Text) & " AND PayrollDate<>" & Qt(CmbWeeks.SelectedValue) & " AND employee_code=" & Qt(DsFrmPayCalculation1.employee.Rows(CalculationCounter).Item("employee_code"))
                                    EmplyeeTotalYear = CmdGeneral.ExecuteScalar()
                                    If EmplyeeTotalYear < FederalTaxTableRow.Item("unemplyment_wagelimit") Then
                                        If EmplyeeTotalYear + GrossPayVar > FederalTaxTableRow.Item("unemplyment_wagelimit") Then
                                            UnemploymentEmployeeTaxVar = ((FederalTaxTableRow.Item("unemplyment_wagelimit") - EmplyeeTotalYear) * FederalTaxTableRow.Item("unemplyment_employee")) / 100
                                            UnemploymentEmployerTaxVar = ((FederalTaxTableRow.Item("unemplyment_wagelimit") - EmplyeeTotalYear) * FederalTaxTableRow.Item("unemplyment_employer")) / 100
                                        Else
                                            UnemploymentEmployeeTaxVar = (GrossPayVar * FederalTaxTableRow.Item("unemplyment_employee")) / 100
                                            UnemploymentEmployerTaxVar = (GrossPayVar * FederalTaxTableRow.Item("unemplyment_employer")) / 100
                                        End If
                                        '''UnemploymentEmployeeTaxVar = Math.Round(UnemploymentEmployeeTaxVar / ZaribKindPeriod, 2)
                                        '''UnemploymentEmployerTaxVar = Math.Round(UnemploymentEmployeeTaxVar / ZaribKindPeriod, 2)
                                    End If

                                    personal_allowance_Zarib = 1
                                    Select Case .Rows(CalculationCounter).Item("last_status")
                                        Case 1, 3, 4 'Single , MArried Joint , House Hold
                                            personal_allowance_Zarib = 1
                                        Case 2 ' Maried Joint
                                            personal_allowance_Zarib = 2
                                    End Select
                                    StateTaxAmountVar = AnnualIncomeVar - StateTaxTableRow.Item("standard_deduction") - (StateTaxTableRow.Item("personal_allowance") * personal_allowance_Zarib) - (StateTaxTableRow.Item("dependent_allowance") * .Rows(CalculationCounter).Item("Allowance_depndnts"))
                                    If StateTaxAmountVar < 0 Then
                                        StateTaxAmountVar = 0
                                    End If

                                    Call SetStateTaxRow(.Rows(CalculationCounter).Item("last_status"), StateTaxAmountVar, StateDollar_Tax)
                                    StateTaxVar = Math.Round((((StateTaxAmountVar - StateTaxTableRow.Item("over_")) * StateTaxTableRow.Item("percent_tax")) / 100) + StateDollar_Tax, 2)

                                    StateTaxVar = Math.Round(StateTaxVar / ZaribKindPeriod, 2)

                                    'If .Rows(CalculationCounter).Item("Id_pay_period") > 0 Then
                                    '    Id_pay_periodVar = .Rows(CalculationCounter).Item("Id_pay_period")
                                    'Else
                                    '    CmdGeneral.CommandText = "Insert into pay_main_employee (employee_code,PayrollDate) VALUES (" & Qt(.Rows(CalculationCounter).Item("employee_code")) & "," & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & ") " & _
                                    '    ";Select id_pay_period from pay_main_employee where id_pay_period=@@IDENTITY"
                                    '    Id_pay_periodVar = CmdGeneral.ExecuteScalar()
                                    'End If
                                    'SubtractFromGrosspayForCalculateTax = 0
                                    'CalcLoan(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                    'CalcSaving(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                    'CalcAdvance(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                    'CalcDeduction(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)
                                    'CalcGarnishment(.Rows(CalculationCounter).Item("employee_code"), Id_pay_periodVar)

                                    Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "06", 0, FederalTaxVar, 0)
                                    Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "07", 0, SocialSecurityEmployeeTaxVar, SocialSecurityEmployerTaxVar)
                                    Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "08", 0, MedicareEmployeeTaxVar, MedicareEmployerTaxVar)
                                    Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "09", 0, StateTaxVar, 0)
                                    Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "10", 0, UnemploymentEmployeeTaxVar, UnemploymentEmployerTaxVar)

                                    CmdGeneral.CommandText = "Update pay_main_employee Set PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & ",gross_pay=" & Math.Round(GrossPayVar, 2) & ",Other_Pay=" & .Rows(CalculationCounter).Item("Other_Pay") & ",time_work_Hour=" & Qt(.Rows(CalculationCounter).Item("time_work_Hour")) & ",time_work_Minute=" & Qt(.Rows(CalculationCounter).Item("time_work_Minute")) & " Where id_pay_period=" & Id_pay_periodVar
                                    CmdGeneral.ExecuteNonQuery()

                                    TotalEmployeeCalculatedCounter = TotalEmployeeCalculatedCounter + 1

                                Else
                                    TxtCalculationErrors.Text = TxtCalculationErrors.Text & "Error in Federal Tax" & vbCrLf
                                End If
                            Else
                                TxtCalculationErrors.Text = TxtCalculationErrors.Text & "Error in Federal Or State Tax" & vbCrLf
                            End If
                        End If

                    End If
                End If
            Next
        End With
        TxtCalculationErrors.Text = TxtCalculationErrors.Text & "Total Employee            : " & Str(TotalEmployeeCounter) & vbCrLf
        TxtCalculationErrors.Text = TxtCalculationErrors.Text & "Total Active Employee     : " & Str(TotalEmployeeActiveCounter) & vbCrLf
        TxtCalculationErrors.Text = TxtCalculationErrors.Text & "Total Calculated Employee : " & Str(TotalEmployeeCalculatedCounter) & vbCrLf
        Call FillDataSet(MakeDateCorrect(CmbWeeks.SelectedValue))
        MsgBox("Calculation Finished")
        BtnStartCalc.Enabled = True
    End Sub
    Private Function SetFederalTaxRow(ByVal Thislast_status As String, ByVal ThisPayAmount As Decimal, ByRef ThisDollar_Tax As Decimal) As Boolean
        ThisDollar_Tax = 0
        Dim i As Integer
        With DsFrmPayCalculation1.pay_tab_federal_tax_dtl
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("stat_code") = Thislast_status And ThisPayAmount >= .Rows(i).Item("over_") And ThisPayAmount < .Rows(i).Item("but_not_over") Then
                    Exit For
                End If
            Next
            If i < .Rows.Count Then
                FederalTaxTableRow = .Rows(i)
                SetFederalTaxRow = True
                If i > 0 Then
                    If .Rows(i - 1).Item("stat_code") = Thislast_status Then
                        ThisDollar_Tax = .Rows(i - 1).Item("Dollor_Tax")
                    Else
                        ThisDollar_Tax = 0
                    End If
                Else
                    ThisDollar_Tax = 0
                End If
            Else
                SetFederalTaxRow = False
                'Print Err
            End If
        End With
    End Function
    Private Function SetStateTaxRow(ByVal Thislast_status As String, ByVal ThisPayAmount As Decimal, ByRef ThisDollar_Tax As Decimal) As Boolean
        ThisDollar_Tax = 0
        Dim i As Integer
        With DsFrmPayCalculation1.pay_tab_state_tax_dtl
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("stat_code") = Thislast_status And ThisPayAmount >= .Rows(i).Item("over_") And ThisPayAmount < .Rows(i).Item("but_not_over") Then
                    Exit For
                End If
            Next
            If i < .Rows.Count Then
                StateTaxTableRow = .Rows(i)
                SetStateTaxRow = True
                If i > 0 Then
                    If .Rows(i - 1).Item("stat_code") = Thislast_status Then
                        ThisDollar_Tax = .Rows(i - 1).Item("Dollor_Tax")
                    Else
                        ThisDollar_Tax = 0
                    End If
                End If
            Else
                SetStateTaxRow = False
                'Print Err
            End If
        End With
    End Function
    Private Sub CalcLoan(ByVal ThisEmployeeCode As String, ByVal Thisid_pay_period As Decimal)
        DsFrmPayCalculation1.pay_loan_dtl.Clear()
        DAPay_loan_dtl.SelectCommand.Parameters("@employee_code").Value = ThisEmployeeCode
        DAPay_loan_dtl.Fill(DsFrmPayCalculation1.pay_loan_dtl)
        If DsFrmPayCalculation1.pay_loan_dtl.Rows.Count > 0 Then
            Dim CalcLoanCounter As Integer
            For CalcLoanCounter = 0 To DsFrmPayCalculation1.pay_loan_dtl.Rows.Count - 1
                '01=loan 02=saving 03=advance 04=garnishment 05=other deduction 06=Federal tax 07=Social security 08=Medicare Tax 09=State Tax 10=unemployment_tax
                Call InsertIntopay_deductin_main_dtl(Thisid_pay_period, "01", DsFrmPayCalculation1.pay_loan_dtl.Rows(CalcLoanCounter).Item("id_deduction"), DsFrmPayCalculation1.pay_loan_dtl.Rows(CalcLoanCounter).Item("costus"), 0)
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Update pay_loan_dtl Set time_costus_pay=time_costus_pay+1 Where id_deduction=" & Qt(DsFrmPayCalculation1.pay_loan_dtl.Rows(CalcLoanCounter).Item("id_deduction"))
                CmdGeneral.ExecuteNonQuery()
                If DsFrmPayCalculation1.pay_loan_dtl.Rows(CalcLoanCounter).Item("before_tax") Then
                    SubtractFromGrosspayForCalculateTax = SubtractFromGrosspayForCalculateTax + DsFrmPayCalculation1.pay_loan_dtl.Rows(CalcLoanCounter).Item("costus")
                End If
            Next
        End If
    End Sub
    Private Sub CalcSaving(ByVal ThisEmployeeCode As String, ByVal Thisid_pay_period As Decimal)
        DsFrmPayCalculation1.pay_saving_dtl.Clear()
        DApay_saving_dtl.SelectCommand.Parameters("@employee_code").Value = ThisEmployeeCode
        DApay_saving_dtl.Fill(DsFrmPayCalculation1.pay_saving_dtl)
        If DsFrmPayCalculation1.pay_saving_dtl.Rows.Count > 0 Then
            Dim CalcSavingCounter As Integer
            For CalcSavingCounter = 0 To DsFrmPayCalculation1.pay_saving_dtl.Rows.Count - 1
                Call InsertIntopay_deductin_main_dtl(Thisid_pay_period, "02", DsFrmPayCalculation1.pay_saving_dtl.Rows(CalcSavingCounter).Item("id_deduction"), DsFrmPayCalculation1.pay_saving_dtl.Rows(CalcSavingCounter).Item("amount_employee"), DsFrmPayCalculation1.pay_saving_dtl.Rows(CalcSavingCounter).Item("amount_employer"))
                If DsFrmPayCalculation1.pay_saving_dtl.Rows(CalcSavingCounter).Item("before_tax") Then
                    SubtractFromGrosspayForCalculateTax = SubtractFromGrosspayForCalculateTax + DsFrmPayCalculation1.pay_saving_dtl.Rows(CalcSavingCounter).Item("amount_employee")
                End If
            Next
        End If
    End Sub
    Private Sub CalcAdvance(ByVal ThisEmployeeCode As String, ByVal Thisid_pay_period As Decimal)
        DsFrmPayCalculation1.pay_advance_employee.Clear()
        DApay_advance_employee.SelectCommand.Parameters("@employee_code").Value = ThisEmployeeCode
        DApay_advance_employee.Fill(DsFrmPayCalculation1.pay_advance_employee)
        If DsFrmPayCalculation1.pay_advance_employee.Rows.Count > 0 Then
            Call InsertIntopay_deductin_main_dtl(Thisid_pay_period, "03", DsFrmPayCalculation1.pay_advance_employee.Rows(0).Item("id_deduction"), DsFrmPayCalculation1.pay_advance_employee.Rows(0).Item("amount_deduction"), 0)
        End If





    End Sub
    Private Sub CalcDeduction(ByVal ThisEmployeeCode As String, ByVal Thisid_pay_period As Decimal)
        DsFrmPayCalculation1.pay_deduction_employee.Clear()
        DApay_deduction_employee.SelectCommand.Parameters("@employee_code").Value = ThisEmployeeCode
        DApay_deduction_employee.Fill(DsFrmPayCalculation1.pay_deduction_employee)
        If DsFrmPayCalculation1.pay_deduction_employee.Rows.Count > 0 Then
            Dim CalcLoanCounter As Integer
            For CalcLoanCounter = 0 To DsFrmPayCalculation1.pay_deduction_employee.Rows.Count - 1
                Call InsertIntopay_deductin_main_dtl(Thisid_pay_period, "05", DsFrmPayCalculation1.pay_deduction_employee.Rows(CalcLoanCounter).Item("id_deduction"), DsFrmPayCalculation1.pay_deduction_employee.Rows(CalcLoanCounter).Item("amount_deduction"), 0)
                If DsFrmPayCalculation1.pay_deduction_employee.Rows(CalcLoanCounter).Item("befor_tax") Then
                    SubtractFromGrosspayForCalculateTax = SubtractFromGrosspayForCalculateTax + DsFrmPayCalculation1.pay_deduction_employee.Rows(CalcLoanCounter).Item("amount_deduction")
                End If
            Next
        End If
    End Sub
    Private Sub CalcGarnishment(ByVal ThisEmployeeCode As String, ByVal Thisid_pay_period As Decimal)
        DsFrmPayCalculation1.pay_Garnishment_employee.Clear()
        DApay_Garnishment_employee.SelectCommand.Parameters("@employee_code").Value = ThisEmployeeCode
        DApay_Garnishment_employee.Fill(DsFrmPayCalculation1.pay_Garnishment_employee)
        If DsFrmPayCalculation1.pay_Garnishment_employee.Rows.Count > 0 Then
            Dim CalcGarnishmentCounter As Integer
            For CalcGarnishmentCounter = 0 To DsFrmPayCalculation1.pay_Garnishment_employee.Rows.Count - 1
                Call InsertIntopay_deductin_main_dtl(Thisid_pay_period, "04", DsFrmPayCalculation1.pay_Garnishment_employee.Rows(CalcGarnishmentCounter).Item("id_deduction"), DsFrmPayCalculation1.pay_Garnishment_employee.Rows(CalcGarnishmentCounter).Item("amount_garnishment"), 0)
                If DsFrmPayCalculation1.pay_Garnishment_employee.Rows(CalcGarnishmentCounter).Item("beforetax") Then
                    SubtractFromGrosspayForCalculateTax = SubtractFromGrosspayForCalculateTax + DsFrmPayCalculation1.pay_Garnishment_employee.Rows(CalcGarnishmentCounter).Item("amount_garnishment")
                End If
            Next
        End If
    End Sub
    Private Sub InsertIntopay_deductin_main_dtl(ByVal Thisid_pay_period As Decimal, ByVal Thisdeduction_type As String, ByVal Thisid_deduction As Decimal, ByVal ThisEmployeeAmount As Decimal, ByVal ThisEmployerAmount As Decimal)
        If ThisEmployeeAmount <> 0 Or ThisEmployerAmount <> 0 Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Thisid_pay_period & "," & Qt(Thisdeduction_type) & "," & Thisid_deduction & "," & ThisEmployeeAmount & "," & ThisEmployerAmount & ")"
            CmdGeneral.ExecuteNonQuery()
        End If
    End Sub
    ' *************************************************************************************
    ' *************************************************************************************
    ' in barnameh dar FrmEmployeeBonus ham vojood darad.taghirat dar oonja ham lahaz shavad
    ' *************************************************************************************
    ' *************************************************************************************
    Private Function Retrieve_deductin_Desc(ByVal Thisdeduction_type As Decimal, ByVal Thisdeduction_Id As Decimal) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        '01=loan 02=saving 03=advance 04=garnishment 05=other deduction 06=Federal tax 07=Social security 08=Medicare Tax 09=State Tax 10=unemployment_tax
        Retrieve_deductin_Desc = ""
        Select Case Thisdeduction_type
            Case "01"
                CmdGeneral.CommandText = "SELECT loan_desc FROM pay_loan_dtl INNER JOIN pay_tab_loan_main ON pay_loan_dtl.loan_cod = pay_tab_loan_main.loan_cod " & _
                " Where id_deduction=" & Thisdeduction_Id
                Retrieve_deductin_Desc = CmdGeneral.ExecuteScalar & ""
            Case "02"
                CmdGeneral.CommandText = "SELECT saving_desc FROM pay_saving_dtl INNER JOIN pay_tab_saving_main ON pay_saving_dtl.saving_cod = pay_tab_saving_main.saving_cod " & _
                " Where id_deduction=" & Thisdeduction_Id
                Retrieve_deductin_Desc = CmdGeneral.ExecuteScalar & ""
            Case "03"
                Retrieve_deductin_Desc = "Advance"
            Case "04"
                CmdGeneral.CommandText = "SELECT remark FROM pay_Garnishment_employee " & _
                " Where id_deduction=" & Thisdeduction_Id
                Retrieve_deductin_Desc = CmdGeneral.ExecuteScalar & ""
            Case "05"
                CmdGeneral.CommandText = "SELECT employee_deduction.deduction_desc FROM pay_deduction_employee INNER JOIN employee_deduction ON pay_deduction_employee.deduction_cod = employee_deduction.deduction_cod " & _
                " Where id_deduction=" & Thisdeduction_Id
                Retrieve_deductin_Desc = CmdGeneral.ExecuteScalar & ""
            Case "06"
                Retrieve_deductin_Desc = "Federal tax"
            Case "07"
                Retrieve_deductin_Desc = "Social security (FICA)"
            Case "08"
                Retrieve_deductin_Desc = "Medicare (MEDI)"
            Case "09"
                Retrieve_deductin_Desc = "State Tax"
            Case "10"
                Retrieve_deductin_Desc = "Unemployment Tax"
        End Select
    End Function
    Private Sub CmbWeeks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbWeeks.SelectedIndexChanged
        Call FillDataSet(MakeDateCorrect(CmbWeeks.SelectedValue))
    End Sub
    Private Sub BtnShowAllPayCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowAllPayCheck.Click
        Dim PayCheckCounter As Integer
        FlagForShowAllPayCheck = True
        For PayCheckCounter = 0 To DsFrmPayCalculation1.employee.Rows.Count - 1
            If DsFrmPayCalculation1.employee.Rows(PayCheckCounter).RowState <> DataRowState.Deleted Then
                If DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("gross_pay") > 0 Then
                    Call ShowPayCheck(DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("employee_code"), DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("id_pay_period"))
                    If Not FlagForShowAllPayCheck Then
                        Exit For
                    End If
                End If
            End If
        Next
        Call FillDataSet(MakeDateCorrect(CmbWeeks.SelectedValue))
    End Sub
    Private Sub BtnShowPayCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowPayCheck.Click
        Dim ThisRowGrid As GridEXRow = GridEX1.GetRow
        Call ShowPayCheck(ThisRowGrid.Cells("employee_code").Value, ThisRowGrid.Cells("id_pay_period").Value)
        Call FillDataSet(MakeDateCorrect(CmbWeeks.SelectedValue))
    End Sub
    Private Sub ShowPayCheck(ByVal ThisEmployee As String, ByVal ThisId_pay_period As Integer)
        Dim MyFrmPayCheck As New FrmPayCheck
        MyFrmPayCheck.DsFrmPayCheck1.Clear()
        Dim i As Integer

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdReader.Connection.State <> ConnectionState.Open Then
            CmdReader.Connection.Open()
        End If
        CmdReader.CommandText = "SELECT  gross_pay , Other_Pay " & _
        " FROM  pay_main_employee where employee_code=" & Qt(ThisEmployee) & " AND PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & " AND pay_main_employee.Payment_Type='0' "
        SQLReader = CmdReader.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            MyFrmPayCheck.DsFrmPayCheck1.PayCheckEmployee.AddPayCheckEmployeeRow("Gross Pay", SQLReader.Item("gross_pay"), 1)
            MyFrmPayCheck.DsFrmPayCheck1.PayCheckEmployee.AddPayCheckEmployeeRow("Bonus/Commission", SQLReader.Item("Other_Pay"), 0)
        End If
        SQLReader.Close()

        CmdReader.CommandText = "SELECT  pay_deductin_main_dtl.id_pay_period, pay_deductin_main_dtl.deduction_type, pay_deductin_main_dtl.id_deduction,pay_deductin_main_dtl.amount_deduction_employee,pay_deductin_main_dtl.amount_deduction_employer " & _
        " FROM pay_deductin_main_dtl INNER JOIN " & _
        " pay_main_employee ON pay_deductin_main_dtl.id_pay_period = pay_main_employee.id_pay_period " & _
        " where employee_code=" & Qt(ThisEmployee) & " AND PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & " AND pay_main_employee.Payment_Type='0' "
        SQLReader = CmdReader.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                If SQLReader.Item("deduction_type") = "06" Or SQLReader.Item("deduction_type") = "07" Or SQLReader.Item("deduction_type") = "08" Or SQLReader.Item("deduction_type") = "09" Or SQLReader.Item("deduction_type") = "10" Then
                    MyFrmPayCheck.DsFrmPayCheck1.PayCheckEmployeeForChange.AddPayCheckEmployeeForChangeRow(Retrieve_deductin_Desc(SQLReader.Item("deduction_type"), SQLReader.Item("id_deduction")), SQLReader.Item("amount_deduction_employee"), -1, SQLReader.Item("id_pay_period"), SQLReader.Item("id_deduction"), SQLReader.Item("deduction_type"))
                Else
                    MyFrmPayCheck.DsFrmPayCheck1.PayCheckEmployee.AddPayCheckEmployeeRow(Retrieve_deductin_Desc(SQLReader.Item("deduction_type"), SQLReader.Item("id_deduction")), SQLReader.Item("amount_deduction_employee"), -1)
                End If
                If SQLReader.Item("amount_deduction_employer") <> 0 Then
                    MyFrmPayCheck.DsFrmPayCheck1.PayCheckEmployer.AddPayCheckEmployerRow(Retrieve_deductin_Desc(SQLReader.Item("deduction_type"), SQLReader.Item("id_deduction")), SQLReader.Item("amount_deduction_employer"))
                End If
            Loop
        End If
        SQLReader.Close()

        MyFrmPayCheck.EmplyeeCodeVar = ThisEmployee
        MyFrmPayCheck.PayrollDateVar = MakeDateCorrect(CmbWeeks.SelectedValue)
        MyFrmPayCheck.Id_bankVar = CmbId_bank.SelectedValue
        MyFrmPayCheck.CheckDateVar = DteCheckDate.Text
        MyFrmPayCheck.Id_pay_periodVar = ThisId_pay_period

        MyFrmPayCheck.ShowDialog()
        If MyFrmPayCheck.ConfirmFlag Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Update pay_main_employee Set PaymentFlag=1 Where id_pay_period=" & ThisId_pay_period
            CmdGeneral.ExecuteNonQuery()
        End If
        FlagForShowAllPayCheck = MyFrmPayCheck.CountinueFlag
    End Sub
    Private Sub CmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbYear.SelectedIndexChanged
        Call FillWeeks()
        Call FillDataSet(DsFrmPayCalculation1.YearWeeks.Rows(0).Item("WeekNo"))
        'GridEX1.AllowEdit = InheritableBoolean.False
        'Call SetBtnEnable(True)
    End Sub
    Private Sub FillWeeks()
        Try
            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrievePayrollSetupTable()
            If Trim(OleDbReaderForStore.Item("DEFAULT_PaymentDay") & "").Length > 0 Then
                Select Case Trim(OleDbReaderForStore.Item("DEFAULT_PaymentDay") & "").ToUpper
                    Case "Sunday".ToUpper
                        StartDateVar = 2
                    Case "Monday".ToUpper
                        StartDateVar = 1
                    Case "Tuesday".ToUpper
                        StartDateVar = 0
                    Case "Wednesday".ToUpper
                        StartDateVar = -1
                    Case "Thursday".ToUpper
                        StartDateVar = -2
                    Case "Friday".ToUpper
                        StartDateVar = -3
                    Case "Saturday".ToUpper
                        StartDateVar = -4
                End Select
            Else
                StartDateVar = 0
            End If

            DsFrmPayCalculation1.YearWeeks.Clear()
            If RdoPeriod1.Checked Then
                Dim FirstDayOfYearVar As String = "01/01/" & PSalMali
                If Trim(CmbYear.Text & "").Length > 0 Then
                    FirstDayOfYearVar = "01/01/" & CmbYear.Text.Trim
                End If
                Dim FirstDayOfFirstWeekOfYearVar As Integer = 0

                If CDate(FirstDayOfYearVar).DayOfWeek() > StartDateVar Then
                    FirstDayOfFirstWeekOfYearVar = CDate(FirstDayOfYearVar).DayOfWeek() - StartDateVar
                Else
                    FirstDayOfFirstWeekOfYearVar = StartDateVar - CDate(FirstDayOfYearVar).DayOfWeek()
                End If
                If FirstDayOfFirstWeekOfYearVar >= 7 Then
                    FirstDayOfFirstWeekOfYearVar = FirstDayOfFirstWeekOfYearVar - 7
                End If
                Dim i As Integer
                For i = 0 To 51
                    DsFrmPayCalculation1.YearWeeks.AddYearWeeksRow(CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7)).Date), Str(i + 1) & " - " & CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7)).Date) & " TO " & CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7) + 6).Date))
                Next
            ElseIf RdoPeriod2.Checked() Then
                Dim FirstDayOfYearVar As String = "01/01/" & PSalMali
                If Trim(CmbYear.Text & "").Length > 0 Then
                    FirstDayOfYearVar = "01/01/" & CmbYear.Text.Trim
                End If
                Dim FirstDayOfFirstWeekOfYearVar As Integer = 0

                If CDate(FirstDayOfYearVar).DayOfWeek() > StartDateVar Then
                    FirstDayOfFirstWeekOfYearVar = CDate(FirstDayOfYearVar).DayOfWeek() - StartDateVar
                Else
                    FirstDayOfFirstWeekOfYearVar = StartDateVar - CDate(FirstDayOfYearVar).DayOfWeek()
                End If
                If FirstDayOfFirstWeekOfYearVar >= 13 Then
                    FirstDayOfFirstWeekOfYearVar = FirstDayOfFirstWeekOfYearVar - 13
                End If

                Dim i As Integer
                For i = 0 To 51 Step 2
                    DsFrmPayCalculation1.YearWeeks.AddYearWeeksRow(CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7)).Date), Str((i + 2) / 2) & " - " & CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7)).Date) & " TO " & CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7) + 13).Date))
                Next
            ElseIf RdoPeriod3.Checked() Then
                Dim FirstDayOfYearVar As String = "01/01/" & PSalMali
                If Trim(CmbYear.Text & "").Length > 0 Then
                    FirstDayOfYearVar = "01/01/" & CmbYear.Text.Trim
                End If
                Dim FirstDayOfFirstWeekOfYearVar As Integer = 0
                Dim i As Integer
                For i = 1 To 12
                    DsFrmPayCalculation1.YearWeeks.AddYearWeeksRow(Getcod(i, 2) & "/01/" & CmbYear.Text.Trim, MonthName(i) & " - First Half")
                    DsFrmPayCalculation1.YearWeeks.AddYearWeeksRow(Getcod(i, 2) & "/16/" & CmbYear.Text.Trim, MonthName(i) & " - Second Half")
                Next
            ElseIf RdoPeriod4.Checked() Then
                Dim i As Integer
                Dim a As Date
                For i = 1 To 12
                    'DsFrmPayCalculation1.YearWeeks.AddYearWeeksRow(Getcod(i, 2) & "/" & a.DaysInMonth(Int(CmbYear.Text), i) & "/" & CmbYear.Text.Trim, MonthName(i))
                    DsFrmPayCalculation1.YearWeeks.AddYearWeeksRow(Getcod(i, 2) & "/01/" & CmbYear.Text.Trim, MonthName(i))
                Next
            End If
        Catch ex As Exception
            MsgBox("EEEERRRRRRRRRROOOOOOOOOORRRRRRRRR")
        End Try
    End Sub
    Private Sub BtnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectAll.Click
        Dim i As Integer
        For i = 0 To DsFrmPayCalculation1.employee.Rows.Count - 1
            DsFrmPayCalculation1.employee.Rows(i).Item("FlagPardakht") = 1
        Next
    End Sub
    Private Sub BtnDeselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselectAll.Click
        Dim i As Integer
        For i = 0 To DsFrmPayCalculation1.employee.Rows.Count - 1
            DsFrmPayCalculation1.employee.Rows(i).Item("FlagPardakht") = 0
        Next
    End Sub
    Private Sub RdoPeriod1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoPeriod1.CheckedChanged, RdoPeriod2.CheckedChanged, RdoPeriod3.CheckedChanged, RdoPeriod4.CheckedChanged
        Call FillWeeks()
        If CmbWeeks.Text.Trim.Length > 0 Then
            Call FillDataSet(MakeDateCorrect(CmbWeeks.SelectedValue))
        End If
        'If RdoPeriod1.Checked Then
        'ElseIf RdoPeriod2.Checked() Then
        'ElseIf RdoPeriod3.Checked() Then
        'ElseIf RdoPeriod4.Checked() Then
        'End If
    End Sub
    Private Sub PrintChecks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintChecks.Click
        Try
            MyFrmCheckScreen = New UcAccount.FrmCheckScreen
            Dim PrintCounter As Integer
            Dim ReturndIdcheck As Int64 = 0
            Dim ThisEmployee As String
            Dim ThisNetPay As Decimal = 0
            For PrintCounter = 0 To DsFrmPayCalculation1.employee.Rows.Count - 1
                Id_pay_periodVar = DsFrmPayCalculation1.employee.Rows(PrintCounter).Item("Id_pay_period")
                If DsFrmPayCalculation1.employee.Rows(PrintCounter).Item("PaymentFlag") Then
                    ThisEmployee = DsFrmPayCalculation1.employee.Rows(PrintCounter).Item("employee_code")
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "SELECT  id_check FROM pay_main_employee WHERE employee_code=" & Qt(ThisEmployee) & " AND PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & " AND pay_main_employee.Payment_Type='0' "
                    If Trim(CmdGeneral.ExecuteScalar & "").Length = 0 Then
                        Dim ds1 As New UcAccount.DSFrmCheckScreen
                        'Dim Dt1 As DSFrmCheckScreen.bank_check_dtlDataTable
                        ReturndIdcheck = 0

                        If CmdGeneral.Connection.State <> ConnectionState.Open Then
                            CmdGeneral.Connection.Open()
                        End If
                        CmdGeneral.CommandText = "SELECT  isnull(gross_pay,0) FROM  pay_main_employee where employee_code=" & Qt(ThisEmployee) & " AND PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & " AND pay_main_employee.Payment_Type='0' "
                        ThisNetPay = CmdGeneral.ExecuteScalar
                        CmdGeneral.CommandText = "SELECT  ISNULL(SUM(pay_deductin_main_dtl.amount_deduction_employee), 0) FROM  pay_deductin_main_dtl INNER JOIN pay_main_employee ON pay_deductin_main_dtl.id_pay_period = pay_main_employee.id_pay_period WHERE  pay_main_employee.employee_code = " & Qt(ThisEmployee) & " And pay_main_employee.PayrollDate = " & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & " AND pay_main_employee.Payment_Type='0' "
                        ThisNetPay = ThisNetPay - CmdGeneral.ExecuteScalar
                        If ThisNetPay > 0 Then
                            Dim dr As DataRow
                            dr = ds1.bank_check_dtl.NewRow
                            dr("id_check") = 0
                            dr("radif") = 1
                            dr("gl_account") = Retrieve_GLAccount("01")
                            dr("amount") = ThisNetPay ' SQLReader.Item("gross_pay")
                            dr("memo_dtl") = "Net Pay"
                            ds1.bank_check_dtl.Rows.Add(dr)
                            MyFrmCheckScreen.SaveAndPrint(CmbId_bank.SelectedValue, DteCheckDate.Text, ThisNetPay, ThisEmployee, ds1.bank_check_dtl, ReturndIdcheck)
                            'If ReturndIdcheck > 0 Then
                            '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                            '        CmdGeneral.Connection.Open()
                            '    End If
                            '    CmdGeneral.CommandText = "UPDATE pay_main_employee SET id_check = " & ReturndIdcheck & " WHERE id_pay_period=" & DsFrmPayCalculation1.employee.Rows(PrintCounter).Item("id_pay_period")
                            '    CmdGeneral.ExecuteNonQuery()
                            'End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnFish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFish.Click
        Call pprint("PRINT")
        'Call pprint("PREVIEW")
    End Sub
    Private Sub pprint(ByVal PrintType As String)

        Dim PayCheckCounter As Integer
        FlagForShowAllPayCheck = True
        Dim ThisEmployee As String
        Dim NetPayVar As Double = 0
        Dim TotalNetPayVar As Double = 0
        Dim TotalGrossPayvar As Double = 0
        For PayCheckCounter = 0 To DsFrmPayCalculation1.employee.Rows.Count - 1
            If DsFrmPayCalculation1.employee.Rows(PayCheckCounter).RowState <> DataRowState.Deleted Then
                If DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("gross_pay") > 0 Then
                    ThisEmployee = DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("employee_code")
                    'DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("id_pay_period"))

                    Dim rpt As New RepFish
                    Dim prn As New FrmRepView

                    Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
                    OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
                    rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
                    OleDbReaderForStore.Close()

                    rpt.SetParameterValue("ParFromDateToDate", CmbWeeks.Text.Trim & "")
                    rpt.SetParameterValue("ParHoursWorked", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("time_work") & "")
                    rpt.SetParameterValue("ParEmployee", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("employee_code") & "")
                    rpt.SetParameterValue("ParName", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("EmployeeFullName") & "")
                    rpt.SetParameterValue("ParCheckNo", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("no_of_check") & "")
                    rpt.SetParameterValue("ParCheckDate", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("date_of_check") & "")
                    rpt.SetParameterValue("ParRegularPay", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("Gross_Pay") - DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("Other_Pay"))
                    rpt.SetParameterValue("ParCommission", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("Other_Pay"))
                    rpt.SetParameterValue("ParGrossPay", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("Gross_Pay"))

                    CmdReader.CommandText = "SELECT  isnull(SUM(ISNULL(day_work, 0)),0) AS day_work, SUM(ISNULL(cast(time_work_Hour as integer), 0)) AS time_work_Hour, SUM(ISNULL(cast(time_work_Minute as integer), 0)) " & _
                    " AS time_work_Minute, isnull(SUM(ISNULL(Other_Pay, 0)),0) AS Other_Pay, isnull(SUM(ISNULL(gross_pay, 0)),0) AS gross_pay " & _
                    " FROM pay_main_employee  " & _
                    " WHERE pay_main_employee.employee_code=" & Qt(ThisEmployee) & " AND dbo.changedate(pay_main_employee.PayrollDate)<=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CmbWeeks.SelectedValue))) & " AND substring(dbo.changedate(pay_main_employee.PayrollDate),1,4)=" & Qt(CmbYear.Text)
                    Dim SQLReader As System.Data.SqlClient.SqlDataReader
                    SQLReader = CmdReader.ExecuteReader
                    If SQLReader.HasRows Then
                        SQLReader.Read()
                        Dim TimeWorkTotalHour As Integer
                        Dim TimeWorkTotalMinute As Integer

                        TimeWorkTotalHour = Int(SQLReader.Item("time_work_Hour") & "") + (Int(SQLReader.Item("time_work_Minute") & "") \ 60)
                        TimeWorkTotalMinute = Int(SQLReader.Item("time_work_Minute") & "") - ((Int(SQLReader.Item("time_work_Minute") & "") \ 60) * 60)
                        rpt.SetParameterValue("ParHoursWorkedTotal", TimeWorkTotalHour.ToString.Trim + ":" + Getcod(TimeWorkTotalMinute.ToString.Trim, 2) & "")
                        rpt.SetParameterValue("ParRegularPayTotal", SQLReader.Item("Gross_Pay") - SQLReader.Item("Other_Pay"))
                        rpt.SetParameterValue("ParCommissionTotal", SQLReader.Item("Other_Pay"))
                        rpt.SetParameterValue("ParGrossPayTotal", SQLReader.Item("Gross_Pay"))
                        TotalGrossPayvar = SQLReader.Item("Gross_Pay")
                    Else
                        rpt.SetParameterValue("ParHoursWorkedTotal", "")
                        rpt.SetParameterValue("ParRegularPayTotal", 0)
                        rpt.SetParameterValue("ParCommissionTotal", 0)
                        rpt.SetParameterValue("ParGrossPayTotal", 0)
                    End If
                    SQLReader.Close()

                    rpt.SetParameterValue("Par11", 0)
                    rpt.SetParameterValue("Par12", 0)
                    rpt.SetParameterValue("Par13", 0)
                    rpt.SetParameterValue("Par14", 0)
                    rpt.SetParameterValue("Par15", 0)
                    rpt.SetParameterValue("Par21", 0)
                    rpt.SetParameterValue("Par22", 0)
                    rpt.SetParameterValue("Par23", 0)
                    rpt.SetParameterValue("Par24", 0)
                    rpt.SetParameterValue("Par25", 0)
                    rpt.SetParameterValue("Par31", 0)
                    rpt.SetParameterValue("Par32", 0)
                    rpt.SetParameterValue("Par33", 0)
                    rpt.SetParameterValue("Par34", 0)
                    rpt.SetParameterValue("Par35", 0)
                    rpt.SetParameterValue("Par41", 0)
                    rpt.SetParameterValue("Par42", 0)
                    rpt.SetParameterValue("Par43", 0)
                    rpt.SetParameterValue("Par44", 0)
                    rpt.SetParameterValue("Par45", 0)


                    'CmdReader.CommandText = "SELECT  pay_deductin_main_dtl.id_pay_period, pay_deductin_main_dtl.deduction_type, pay_deductin_main_dtl.id_deduction,pay_deductin_main_dtl.amount_deduction_employee,pay_deductin_main_dtl.amount_deduction_employer " & _
                    '" FROM pay_deductin_main_dtl INNER JOIN " & _
                    '" pay_main_employee ON pay_deductin_main_dtl.id_pay_period = pay_main_employee.id_pay_period " & _
                    '" where employee_code=" & Qt(ThisEmployee) & " AND PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue))

                    CmdReader.CommandText = "SELECT  pay_deductin_main_dtl.deduction_type, sum(pay_deductin_main_dtl.amount_deduction_employee) as amount_deduction_employee,sum(pay_deductin_main_dtl.amount_deduction_employer) as amount_deduction_employer " & _
                    " FROM pay_deductin_main_dtl INNER JOIN " & _
                    " pay_main_employee ON pay_deductin_main_dtl.id_pay_period = pay_main_employee.id_pay_period " & _
                    " where employee_code=" & Qt(ThisEmployee) & " AND PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & " AND pay_main_employee.Payment_Type='0' " & _
                    " Group by pay_deductin_main_dtl.deduction_type "
                    SQLReader = CmdReader.ExecuteReader
                    If SQLReader.HasRows Then
                        Do While SQLReader.Read()
                            If SQLReader.Item("amount_deduction_employee") <> 0 Then
                                Select Case SQLReader.Item("deduction_type")
                                    Case "01"
                                        rpt.SetParameterValue("Par33", SQLReader.Item("amount_deduction_employee"))
                                    Case "02"
                                        rpt.SetParameterValue("Par32", SQLReader.Item("amount_deduction_employee"))
                                    Case "03"
                                        'rpt.SetParameterValue("Par??", SQLReader.Item("amount_deduction_employee"))
                                    Case "04"
                                        rpt.SetParameterValue("Par34", SQLReader.Item("amount_deduction_employee"))
                                    Case "05"
                                        rpt.SetParameterValue("Par31", SQLReader.Item("amount_deduction_employee"))
                                    Case "06"
                                        rpt.SetParameterValue("Par11", SQLReader.Item("amount_deduction_employee"))
                                    Case "07"
                                        rpt.SetParameterValue("Par12", SQLReader.Item("amount_deduction_employee"))
                                    Case "08"
                                        rpt.SetParameterValue("Par13", SQLReader.Item("amount_deduction_employee"))
                                    Case "09"
                                        rpt.SetParameterValue("Par14", SQLReader.Item("amount_deduction_employee"))
                                    Case "10"
                                        rpt.SetParameterValue("Par15", SQLReader.Item("amount_deduction_employee"))
                                End Select
                            End If
                        Loop
                    End If
                    SQLReader.Close()

                    CmdReader.CommandText = "SELECT  pay_deductin_main_dtl.deduction_type,isnull(sum(pay_deductin_main_dtl.amount_deduction_employee),0) as amount_deduction_employee,isnull(sum(pay_deductin_main_dtl.amount_deduction_employer),0) as amount_deduction_employer FROM pay_deductin_main_dtl INNER JOIN pay_main_employee ON pay_deductin_main_dtl.id_pay_period = pay_main_employee.id_pay_period " & _
                    " WHERE pay_main_employee.employee_code=" & Qt(ThisEmployee) & " AND dbo.changedate(pay_main_employee.PayrollDate)<=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CmbWeeks.SelectedValue))) & " AND substring(dbo.changedate(pay_main_employee.PayrollDate),1,4)=" & Qt(CmbYear.Text) & " " & _
                    " Group by pay_deductin_main_dtl.deduction_type "
                    SQLReader = CmdReader.ExecuteReader
                    If SQLReader.HasRows Then
                        Do While SQLReader.Read()
                            If SQLReader.Item("amount_deduction_employee") <> 0 Then
                                Select Case SQLReader.Item("deduction_type")
                                    Case "01"
                                        rpt.SetParameterValue("Par43", SQLReader.Item("amount_deduction_employee"))
                                    Case "02"
                                        rpt.SetParameterValue("Par42", SQLReader.Item("amount_deduction_employee"))
                                    Case "03"
                                        'rpt.SetParameterValue("Par??", SQLReader.Item("amount_deduction_employee"))
                                    Case "04"
                                        rpt.SetParameterValue("Par44", SQLReader.Item("amount_deduction_employee"))
                                    Case "05"
                                        rpt.SetParameterValue("Par41", SQLReader.Item("amount_deduction_employee"))
                                    Case "06"
                                        rpt.SetParameterValue("Par21", SQLReader.Item("amount_deduction_employee"))
                                    Case "07"
                                        rpt.SetParameterValue("Par22", SQLReader.Item("amount_deduction_employee"))
                                    Case "08"
                                        rpt.SetParameterValue("Par23", SQLReader.Item("amount_deduction_employee"))
                                    Case "09"
                                        rpt.SetParameterValue("Par24", SQLReader.Item("amount_deduction_employee"))
                                    Case "10"
                                        rpt.SetParameterValue("Par25", SQLReader.Item("amount_deduction_employee"))
                                End Select
                            End If
                        Loop
                    End If
                    SQLReader.Close()

                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "SELECT NetPay FROM View_EmployeeNetPay Where employee_code=" & Qt(DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("employee_code") & "") & " AND PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue))
                    Try
                        NetPayVar = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        NetPayVar = 0
                    End Try
                    CmdGeneral.CommandText = "SELECT Sum(NetPay) FROM View_EmployeeNetPay Where employee_code=" & Qt(DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("employee_code") & "") & " AND " & _
                                            " dbo.changedate(PayrollDate)<=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CmbWeeks.SelectedValue))) & " AND substring(dbo.changedate(PayrollDate),1,4)=" & Qt(CmbYear.Text)
                    Try
                        TotalNetPayVar = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        TotalNetPayVar = 0
                    End Try
                    rpt.SetParameterValue("Par35", DsFrmPayCalculation1.employee.Rows(PayCheckCounter).Item("Gross_Pay") - NetPayVar)
                    rpt.SetParameterValue("Par45", TotalGrossPayvar - TotalNetPayVar)
                    rpt.SetParameterValue("ParNetPay", NetPayVar)
                    rpt.SetParameterValue("ParNetPayTotal", TotalNetPayVar)


                    rpt.SetParameterValue("ParOtherDeductionDesc1", "")
                    rpt.SetParameterValue("ParOtherDeductionPrice1", 0)
                    rpt.SetParameterValue("ParOtherDeductionDesc2", "")
                    rpt.SetParameterValue("ParOtherDeductionPrice2", 0)
                    rpt.SetParameterValue("ParOtherDeductionDesc3", "")
                    rpt.SetParameterValue("ParOtherDeductionPrice3", 0)
                    rpt.SetParameterValue("ParOtherDeductionDesc4", "")
                    rpt.SetParameterValue("ParOtherDeductionPrice4", 0)
                    rpt.SetParameterValue("ParOtherDeductionDesc5", "")
                    rpt.SetParameterValue("ParOtherDeductionPrice5", 0)

                    If CmdReader.Connection.State <> ConnectionState.Open Then
                        CmdReader.Connection.Open()
                    End If
                    CmdReader.CommandText = "SELECT     pay_deductin_main_dtl.amount_deduction_employee, employee_deduction.deduction_desc  FROM  pay_deduction_employee INNER JOIN " & _
                    " employee_deduction ON pay_deduction_employee.deduction_cod = employee_deduction.deduction_cod INNER JOIN pay_deductin_main_dtl INNER JOIN pay_main_employee ON pay_deductin_main_dtl.id_pay_period = pay_main_employee.id_pay_period ON pay_deduction_employee.id_deduction = pay_deductin_main_dtl.id_deduction " & _
                    " where pay_main_employee.employee_code=" & Qt(ThisEmployee) & " AND pay_main_employee.PayrollDate=" & Qt(MakeDateCorrect(CmbWeeks.SelectedValue)) & " " & " AND pay_main_employee.Payment_Type='0' " & _
                    " AND pay_deductin_main_dtl.deduction_type = '05' "
                    SQLReader = CmdReader.ExecuteReader
                    If SQLReader.HasRows Then
                        Dim i As Integer
                        For i = 1 To 5
                            If SQLReader.Read Then
                                Select Case i
                                    Case 1
                                        rpt.SetParameterValue("ParOtherDeductionDesc1", SQLReader.Item("deduction_desc") & "")
                                        rpt.SetParameterValue("ParOtherDeductionPrice1", SQLReader.Item("amount_deduction_employee"))
                                    Case 2
                                        rpt.SetParameterValue("ParOtherDeductionDesc2", SQLReader.Item("deduction_desc") & "")
                                        rpt.SetParameterValue("ParOtherDeductionPrice2", SQLReader.Item("amount_deduction_employee"))
                                    Case 3
                                        rpt.SetParameterValue("ParOtherDeductionDesc3", SQLReader.Item("deduction_desc") & "")
                                        rpt.SetParameterValue("ParOtherDeductionPrice3", SQLReader.Item("amount_deduction_employee"))
                                    Case 4
                                        rpt.SetParameterValue("ParOtherDeductionDesc4", SQLReader.Item("deduction_desc") & "")
                                        rpt.SetParameterValue("ParOtherDeductionPrice4", SQLReader.Item("amount_deduction_employee"))
                                    Case 5
                                        rpt.SetParameterValue("ParOtherDeductionDesc5", SQLReader.Item("deduction_desc") & "")
                                        rpt.SetParameterValue("ParOtherDeductionPrice5", SQLReader.Item("amount_deduction_employee"))
                                End Select
                            Else
                                Exit For
                            End If
                        Next
                    End If
                    SQLReader.Close()

                    'rpt.SetDataSource(DsFrmPayCalculation1)
                    Select Case PrintType.ToUpper
                        Case "print".ToUpper
                            rpt.PrintToPrinter(1, True, 0, 0)
                        Case "preview".ToUpper
                            prn.CrViewer.ReportSource = rpt
                            prn.ShowDialog()
                    End Select
                End If
            End If
        Next

    End Sub
    Private Sub MyFrmCheckScreen_AfterSaveAnEmployee(ByVal ThisIdCheck As Long) Handles MyFrmCheckScreen.AfterSaveAnEmployee
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "UPDATE pay_main_employee SET id_check = " & ThisIdCheck & " WHERE id_pay_period=" & Id_pay_periodVar
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
