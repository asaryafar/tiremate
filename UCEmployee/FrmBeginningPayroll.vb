Imports CommonClass
Public Class FrmBeginningPayroll
    Inherits FrmBase
    Public EmployeeCodeVar As String
    Public Status As WorkStates = MainModule.WorkStates._ReadOnly
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
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents LblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmBeginningPayroll1 As UCEmployee.DSFrmBeginningPayroll
    Friend WithEvents NumGrossPay As CalcUtils.UcCalcText
    Friend WithEvents NumFICA As CalcUtils.UcCalcText
    Friend WithEvents NUMMedicare As CalcUtils.UcCalcText
    Friend WithEvents NUMFederalWH As CalcUtils.UcCalcText
    Friend WithEvents NumStateWH As CalcUtils.UcCalcText
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents NumYear As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblEmployeeCode As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBeginningPayroll))
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.LblEmployeeName = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.NumGrossPay = New CalcUtils.UcCalcText
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumFICA = New CalcUtils.UcCalcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.NUMMedicare = New CalcUtils.UcCalcText
        Me.Label4 = New System.Windows.Forms.Label
        Me.NUMFederalWH = New CalcUtils.UcCalcText
        Me.Label6 = New System.Windows.Forms.Label
        Me.NumStateWH = New CalcUtils.UcCalcText
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsFrmBeginningPayroll1 = New UCEmployee.DSFrmBeginningPayroll
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.NumYear = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblEmployeeCode = New System.Windows.Forms.Label
        Me.PnlSearch.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmBeginningPayroll1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.LblEmployeeCode)
        Me.PnlSearch.Controls.Add(Me.Label5)
        Me.PnlSearch.Controls.Add(Me.Employee_Cod1)
        Me.PnlSearch.Controls.Add(Me.LblEmployeeName)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 58)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(465, 36)
        Me.PnlSearch.TabIndex = 424
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Enabled = False
        Me.Employee_Cod1.Kind_Employee = ""
        Me.Employee_Cod1.Location = New System.Drawing.Point(204, 5)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod1.TabIndex = 0
        Me.Employee_Cod1.Visible = False
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_01;password=2191110"
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmployeeName.Location = New System.Drawing.Point(148, 4)
        Me.LblEmployeeName.Name = "LblEmployeeName"
        Me.LblEmployeeName.Size = New System.Drawing.Size(304, 23)
        Me.LblEmployeeName.TabIndex = 425
        Me.LblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(4, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 424
        Me.Label5.Text = "Employee"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumGrossPay
        '
        Me.NumGrossPay.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumGrossPay.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumGrossPay.DecimalDigits = 2
        Me.NumGrossPay.DefaultSendValue = False
        Me.NumGrossPay.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumGrossPay.FireTabAfterEnter = True
        Me.NumGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumGrossPay.Image = CType(resources.GetObject("NumGrossPay.Image"), System.Drawing.Image)
        Me.NumGrossPay.Location = New System.Drawing.Point(133, 128)
        Me.NumGrossPay.Maxlength = 10
        Me.NumGrossPay.MinusColor = System.Drawing.Color.Empty
        Me.NumGrossPay.Name = "NumGrossPay"
        Me.NumGrossPay.Size = New System.Drawing.Size(110, 22)
        Me.NumGrossPay.TabIndex = 1
        Me.NumGrossPay.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumGrossPay.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(21, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 429
        Me.Label2.Text = "Gross Pay"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumFICA
        '
        Me.NumFICA.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumFICA.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumFICA.DecimalDigits = 2
        Me.NumFICA.DefaultSendValue = False
        Me.NumFICA.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumFICA.FireTabAfterEnter = True
        Me.NumFICA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumFICA.Image = CType(resources.GetObject("NumFICA.Image"), System.Drawing.Image)
        Me.NumFICA.Location = New System.Drawing.Point(133, 157)
        Me.NumFICA.Maxlength = 10
        Me.NumFICA.MinusColor = System.Drawing.Color.Empty
        Me.NumFICA.Name = "NumFICA"
        Me.NumFICA.Size = New System.Drawing.Size(110, 22)
        Me.NumFICA.TabIndex = 2
        Me.NumFICA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumFICA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(21, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 431
        Me.Label3.Text = "FICA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NUMMedicare
        '
        Me.NUMMedicare.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NUMMedicare.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NUMMedicare.DecimalDigits = 2
        Me.NUMMedicare.DefaultSendValue = False
        Me.NUMMedicare.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NUMMedicare.FireTabAfterEnter = True
        Me.NUMMedicare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NUMMedicare.Image = CType(resources.GetObject("NUMMedicare.Image"), System.Drawing.Image)
        Me.NUMMedicare.Location = New System.Drawing.Point(133, 186)
        Me.NUMMedicare.Maxlength = 10
        Me.NUMMedicare.MinusColor = System.Drawing.Color.Empty
        Me.NUMMedicare.Name = "NUMMedicare"
        Me.NUMMedicare.Size = New System.Drawing.Size(110, 22)
        Me.NUMMedicare.TabIndex = 3
        Me.NUMMedicare.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NUMMedicare.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(20, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 433
        Me.Label4.Text = "Medicare"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NUMFederalWH
        '
        Me.NUMFederalWH.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NUMFederalWH.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NUMFederalWH.DecimalDigits = 2
        Me.NUMFederalWH.DefaultSendValue = False
        Me.NUMFederalWH.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NUMFederalWH.FireTabAfterEnter = True
        Me.NUMFederalWH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NUMFederalWH.Image = CType(resources.GetObject("NUMFederalWH.Image"), System.Drawing.Image)
        Me.NUMFederalWH.Location = New System.Drawing.Point(133, 215)
        Me.NUMFederalWH.Maxlength = 10
        Me.NUMFederalWH.MinusColor = System.Drawing.Color.Empty
        Me.NUMFederalWH.Name = "NUMFederalWH"
        Me.NUMFederalWH.Size = New System.Drawing.Size(110, 22)
        Me.NUMFederalWH.TabIndex = 4
        Me.NUMFederalWH.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NUMFederalWH.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(21, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 435
        Me.Label6.Text = "Federal W/H"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumStateWH
        '
        Me.NumStateWH.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumStateWH.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumStateWH.DecimalDigits = 2
        Me.NumStateWH.DefaultSendValue = False
        Me.NumStateWH.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumStateWH.FireTabAfterEnter = True
        Me.NumStateWH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumStateWH.Image = CType(resources.GetObject("NumStateWH.Image"), System.Drawing.Image)
        Me.NumStateWH.Location = New System.Drawing.Point(133, 244)
        Me.NumStateWH.Maxlength = 10
        Me.NumStateWH.MinusColor = System.Drawing.Color.Empty
        Me.NumStateWH.Name = "NumStateWH"
        Me.NumStateWH.Size = New System.Drawing.Size(110, 22)
        Me.NumStateWH.TabIndex = 5
        Me.NumStateWH.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumStateWH.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(22, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 437
        Me.Label7.Text = "State W/H"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(465, 58)
        Me.Panel4.TabIndex = 443
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Location = New System.Drawing.Point(64, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(408, 56)
        Me.Label12.TabIndex = 207
        Me.Label12.Text = "This screen is used to record employee earnings prior to using Tiremate Payroll"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(28, 281)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(99, 23)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(338, 281)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(99, 23)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "Save"
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand1
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
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
        'DsFrmBeginningPayroll1
        '
        Me.DsFrmBeginningPayroll1.DataSetName = "DSFrmBeginningPayroll"
        Me.DsFrmBeginningPayroll1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'NumYear
        '
        Me.NumYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumYear.DecimalDigits = 0
        Me.NumYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumYear.FormatString = "####"
        Me.NumYear.Location = New System.Drawing.Point(133, 101)
        Me.NumYear.MaxLength = 4
        Me.NumYear.Name = "NumYear"
        Me.NumYear.Size = New System.Drawing.Size(55, 20)
        Me.NumYear.TabIndex = 0
        Me.NumYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumYear.Value = CType(0, Short)
        Me.NumYear.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(60, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 446
        Me.Label1.Text = "Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmployeeCode
        '
        Me.LblEmployeeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmployeeCode.Location = New System.Drawing.Point(66, 4)
        Me.LblEmployeeCode.Name = "LblEmployeeCode"
        Me.LblEmployeeCode.Size = New System.Drawing.Size(80, 23)
        Me.LblEmployeeCode.TabIndex = 426
        Me.LblEmployeeCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmBeginningPayroll
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(465, 311)
        Me.Controls.Add(Me.NumYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.NumStateWH)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NUMFederalWH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NUMMedicare)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumFICA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumGrossPay)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmBeginningPayroll"
        Me.Text = "Employee Beginning Payroll Amounts"
        Me.PnlSearch.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmBeginningPayroll1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmBeginningPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Employee_Cod1.EmployeeCod = EmployeeCodeVar
        LblEmployeeCode.Text = EmployeeCodeVar

        Dim DateVar As String = "01/00/" & NumYear.Text
        Dim Id_pay_periodVar As Int64
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT top 1 Id_pay_period from pay_main_employee WHERE employee_code=" & Qt(EmployeeCodeVar) & " AND substring(PayrollDate,1,5)='01/00'"
        Try
            Id_pay_periodVar = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Id_pay_periodVar = 0
        End Try

        If Id_pay_periodVar > 0 Then
            CmdGeneral.CommandText = "SELECT substring(PayrollDate,7,10) from pay_main_employee WHERE id_pay_period=" & Id_pay_periodVar
            Try
                NumYear.Text = CmdGeneral.ExecuteScalar
            Catch ex As Exception
                NumYear.Text = "2008"
            End Try

            CmdGeneral.CommandText = "SELECT gross_pay from pay_main_employee WHERE id_pay_period=" & Id_pay_periodVar
            CmdGeneral.ExecuteScalar()
            Try
                NumGrossPay.Text = CmdGeneral.ExecuteScalar()
            Catch ex As Exception
                NumGrossPay.Text = 0
            End Try

            CmdGeneral.CommandText = "SELECT amount_deduction_employee from pay_deductin_main_dtl where id_pay_period=" & Id_pay_periodVar & " AND deduction_type='07'"
            CmdGeneral.ExecuteScalar()
            Try
                NumFICA.Text = CmdGeneral.ExecuteScalar()
            Catch ex As Exception
                NumFICA.Text = 0
            End Try

            CmdGeneral.CommandText = "SELECT amount_deduction_employee from pay_deductin_main_dtl where id_pay_period=" & Id_pay_periodVar & " AND deduction_type='06'"
            CmdGeneral.ExecuteScalar()
            Try
                NUMFederalWH.Text = CmdGeneral.ExecuteScalar()
            Catch ex As Exception
                NUMFederalWH.Text = 0
            End Try

            CmdGeneral.CommandText = "SELECT amount_deduction_employee from pay_deductin_main_dtl where id_pay_period=" & Id_pay_periodVar & " AND deduction_type='08'"
            CmdGeneral.ExecuteScalar()
            Try
                NUMMedicare.Text = CmdGeneral.ExecuteScalar()
            Catch ex As Exception
                NUMMedicare.Text = 0
            End Try

            CmdGeneral.CommandText = "SELECT amount_deduction_employee from pay_deductin_main_dtl where id_pay_period=" & Id_pay_periodVar & " AND deduction_type='09'"
            CmdGeneral.ExecuteScalar()
            Try
                NumStateWH.Text = CmdGeneral.ExecuteScalar()
            Catch ex As Exception
                NumStateWH.Text = 0
            End Try
        End If

        If Status <> MainModule.WorkStates._ReadOnly Then
            BtnSave.Enabled = True
            BtnCancel.Enabled = True
            NUMFederalWH.Enabled = True
            NumFICA.Enabled = True
            NumGrossPay.Enabled = True
            NUMMedicare.Enabled = True
            NumStateWH.Enabled = True
            NumYear.Enabled = True
        Else
            BtnSave.Enabled = False
            BtnCancel.Enabled = True
            NUMFederalWH.Enabled = False
            NumFICA.Enabled = False
            NumGrossPay.Enabled = False
            NUMMedicare.Enabled = False
            NumStateWH.Enabled = False
            NumYear.Enabled = False
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If NumYear.Text.Trim.Length <> 4 Or NumYear.Text < "2000" Or NumYear.Text > "2050" Then
            MsgBox("Please Enter valid YEAR")
            Exit Sub
        End If
        Dim DateVar As String = "01/00/" & NumYear.Text
        Dim Id_pay_periodVar As Int64
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Id_pay_period from pay_main_employee where employee_code=" & Qt(EmployeeCodeVar) & " AND PayrollDate=" & Qt(MakeDateCorrect(DateVar))
        Try
            Id_pay_periodVar = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Id_pay_periodVar = 0
        End Try
        If Id_pay_periodVar = 0 Then
            CmdGeneral.CommandText = "Insert into pay_main_employee (employee_code,PayrollDate) VALUES (" & Qt(EmployeeCodeVar) & "," & Qt(MakeDateCorrect(DateVar)) & ") " & _
             ";Select id_pay_period from pay_main_employee where id_pay_period=@@IDENTITY"
            Id_pay_periodVar = CmdGeneral.ExecuteScalar()
        End If
        CmdGeneral.CommandText = "Update pay_main_employee SET Gross_Pay=" & NumGrossPay.Text & " where id_pay_period=" & Id_pay_periodVar
        CmdGeneral.ExecuteNonQuery()

        CmdGeneral.CommandText = "Delete From pay_deductin_main_dtl where id_pay_period=" & Id_pay_periodVar
        CmdGeneral.ExecuteNonQuery()

        ' 07 = FICA
        CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Id_pay_periodVar & ",'07','0'," & NumFICA.Text & ",0)"
        CmdGeneral.ExecuteNonQuery()
        ' 06 = Federal Tax
        CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Id_pay_periodVar & ",'06','0'," & NUMFederalWH.Text & ",0)"
        CmdGeneral.ExecuteNonQuery()
        ' 08 = medicare
        CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Id_pay_periodVar & ",'08','0'," & NUMMedicare.Text & ",0)"
        CmdGeneral.ExecuteNonQuery()
        ' 09 = State
        CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Id_pay_periodVar & ",'09','0'," & NumStateWH.Text & ",0)"
        CmdGeneral.ExecuteNonQuery()

        '' deductions = ?
        'CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Id_pay_periodVar & ",'01','0'," & NumDeductions.Text & ",0)"
        'CmdGeneral.ExecuteNonQuery()
        '' NetPay = ?
        'CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Id_pay_periodVar & ",'01','0'," & NumNetPay.Text & ",0)"
        'CmdGeneral.ExecuteNonQuery()

        Me.Close()

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        LblEmployeeName.Text = Employee_Cod1.Desc_Employee
    End Sub
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        LblEmployeeName.Text = ""
    End Sub
End Class
