Imports CommonClass
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Public Class FrmEmployeeBonus
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public EmployeeBonusHeadTempVar As Decimal = 0
    Dim PnlSearchHeight As Integer
    Public BankDepositVar As String = ""
    Dim ID_paymentVar As Decimal
    Dim Default_cash_overVar As String = ""
    Dim RowNoToAdd As Double = 25
    Private CM As CurrencyManager
    Dim WithEvents MyFrmSearchEmpoyeeBonus As FrmSearchEmpoyeeBonus
    Dim CashPaidOut_OtherReceiptFlag As Boolean = False
    Dim WithEvents MyFrmCheckScreen As UcAccount.FrmCheckScreen
    Friend Id_pay_periodVar As Int64 = 0


    Dim ThisStoreStateVar As String
    Dim ThisYearVar As String = ""
    Dim FederalTaxTableRow As DataRow
    Dim StateTaxTableRow As DataRow



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
    Friend WithEvents CmGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MSave As System.Windows.Forms.MenuItem
    Friend WithEvents MCancel As System.Windows.Forms.MenuItem
    Friend WithEvents CmdDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents CnnTemp As System.Data.SqlClient.SqlConnection
    Friend WithEvents PnlKartAmvalField As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Command2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Command21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SortByType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort32 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents DteDate_document As CalendarCombo.CalendarCombo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents LblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumCheckAmount As CalcUtils.UcCalcText
    Friend WithEvents CmbHead As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_main_employee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEmployeeBonus1 As UCPayroll.DSFrmEmployeeBonus
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbId_bank As System.Windows.Forms.ComboBox
    Friend WithEvents DAbas_banks As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PrintChecks As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnShowPayCheck As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents DApay_tab_federal_tax_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_state_tax_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumNetPAy As CalcUtils.UcCalcText
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents RdoWeekly As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployeeBonus))
        Me.CmGeneral = New System.Windows.Forms.ContextMenu
        Me.MAddNew = New System.Windows.Forms.MenuItem
        Me.MEdit = New System.Windows.Forms.MenuItem
        Me.MDelete = New System.Windows.Forms.MenuItem
        Me.MSave = New System.Windows.Forms.MenuItem
        Me.MCancel = New System.Windows.Forms.MenuItem
        Me.MFirstRecord = New System.Windows.Forms.MenuItem
        Me.MPreviousRecord = New System.Windows.Forms.MenuItem
        Me.MNextRecord = New System.Windows.Forms.MenuItem
        Me.MLastRecord = New System.Windows.Forms.MenuItem
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.CmbHead = New System.Windows.Forms.ComboBox
        Me.DsFrmEmployeeBonus1 = New UCPayroll.DSFrmEmployeeBonus
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.NumNetPAy = New CalcUtils.UcCalcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbId_bank = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumCheckAmount = New CalcUtils.UcCalcText
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.LblEmployeeName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DteDate_document = New CalendarCombo.CalendarCombo
        Me.Label13 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Sort32 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort31 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.SortByType1 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.Command2 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Command21 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.PrintChecks = New Janus.Windows.EditControls.UIButton
        Me.BtnShowPayCheck = New Janus.Windows.EditControls.UIButton
        Me.Label40 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label41 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DApay_main_employee = New System.Data.SqlClient.SqlDataAdapter
        Me.DAbas_banks = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.CmdReader = New System.Data.SqlClient.SqlCommand
        Me.CnnReader = New System.Data.SqlClient.SqlConnection
        Me.DApay_tab_federal_tax_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_state_tax_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdoMonthly = New System.Windows.Forms.RadioButton
        Me.RdoWeekly = New System.Windows.Forms.RadioButton
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmEmployeeBonus1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmGeneral
        '
        Me.CmGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MAddNew, Me.MEdit, Me.MDelete, Me.MSave, Me.MCancel, Me.MFirstRecord, Me.MPreviousRecord, Me.MNextRecord, Me.MLastRecord})
        Me.CmGeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'MAddNew
        '
        Me.MAddNew.Index = 0
        Me.MAddNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MAddNew.Text = "«ÌÃ«œ"
        '
        'MEdit
        '
        Me.MEdit.Index = 1
        Me.MEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MEdit.Text = "«’·«Õ"
        '
        'MDelete
        '
        Me.MDelete.Index = 2
        Me.MDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MDelete.Text = "Õ–›"
        '
        'MSave
        '
        Me.MSave.Enabled = False
        Me.MSave.Index = 3
        Me.MSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MSave.Text = "À» "
        '
        'MCancel
        '
        Me.MCancel.Enabled = False
        Me.MCancel.Index = 4
        Me.MCancel.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MCancel.Text = "·€Ê"
        '
        'MFirstRecord
        '
        Me.MFirstRecord.Index = 5
        Me.MFirstRecord.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV
        Me.MFirstRecord.Text = "«» œ«"
        '
        'MPreviousRecord
        '
        Me.MPreviousRecord.Index = 6
        Me.MPreviousRecord.Text = "ﬁ»·Ì"
        '
        'MNextRecord
        '
        Me.MNextRecord.Index = 7
        Me.MNextRecord.Text = "»⁄œÌ"
        '
        'MLastRecord
        '
        Me.MLastRecord.Index = 8
        Me.MLastRecord.Text = "«‰ Â«"
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM pay_main_employee WHERE (id_pay_period = @id_pay_period)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_pay_period", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_pay_period", System.Data.DataRowVersion.Original, Nothing))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_01;password=2191110"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.CmbHead)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(557, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'CmbHead
        '
        Me.CmbHead.DataSource = Me.DsFrmEmployeeBonus1.pay_main_employee
        Me.CmbHead.DisplayMember = "Expr1"
        Me.CmbHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHead.Location = New System.Drawing.Point(80, 1)
        Me.CmbHead.Name = "CmbHead"
        Me.CmbHead.Size = New System.Drawing.Size(234, 21)
        Me.CmbHead.TabIndex = 189
        Me.CmbHead.ValueMember = "id_pay_period"
        '
        'DsFrmEmployeeBonus1
        '
        Me.DsFrmEmployeeBonus1.DataSetName = "DSFrmEmployeeBonus"
        Me.DsFrmEmployeeBonus1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(5, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Employee "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(557, 115)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.NumNetPAy)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CmbId_bank)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NumCheckAmount)
        Me.Panel1.Controls.Add(Me.Employee_Cod1)
        Me.Panel1.Controls.Add(Me.LblEmployeeName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DteDate_document)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 151)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(373, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Net Pay"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumNetPAy
        '
        Me.NumNetPAy.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNetPAy.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNetPAy.DecimalDigits = 2
        Me.NumNetPAy.DefaultSendValue = False
        Me.NumNetPAy.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNetPAy.FireTabAfterEnter = True
        Me.NumNetPAy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumNetPAy.Image = CType(resources.GetObject("NumNetPAy.Image"), System.Drawing.Image)
        Me.NumNetPAy.Location = New System.Drawing.Point(428, 55)
        Me.NumNetPAy.Maxlength = 10
        Me.NumNetPAy.MinusColor = System.Drawing.Color.Empty
        Me.NumNetPAy.Name = "NumNetPAy"
        Me.NumNetPAy.ReadOnly = True
        Me.NumNetPAy.Size = New System.Drawing.Size(76, 21)
        Me.NumNetPAy.TabIndex = 6
        Me.NumNetPAy.TabStop = False
        Me.NumNetPAy.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNetPAy.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(44, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 437
        Me.Label3.Text = "Bank Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbId_bank
        '
        Me.CmbId_bank.DataSource = Me.DsFrmEmployeeBonus1.bas_banks
        Me.CmbId_bank.DisplayMember = "name_bank"
        Me.CmbId_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbId_bank.Location = New System.Drawing.Point(111, 87)
        Me.CmbId_bank.Name = "CmbId_bank"
        Me.CmbId_bank.Size = New System.Drawing.Size(243, 21)
        Me.CmbId_bank.TabIndex = 3
        Me.CmbId_bank.ValueMember = "id_bank"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 435
        Me.Label2.Text = "Commision / Bonus"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumCheckAmount
        '
        Me.NumCheckAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCheckAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCheckAmount.DecimalDigits = 2
        Me.NumCheckAmount.DefaultSendValue = False
        Me.NumCheckAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCheckAmount.FireTabAfterEnter = True
        Me.NumCheckAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumCheckAmount.Image = CType(resources.GetObject("NumCheckAmount.Image"), System.Drawing.Image)
        Me.NumCheckAmount.Location = New System.Drawing.Point(111, 58)
        Me.NumCheckAmount.Maxlength = 10
        Me.NumCheckAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumCheckAmount.Name = "NumCheckAmount"
        Me.NumCheckAmount.Size = New System.Drawing.Size(110, 22)
        Me.NumCheckAmount.TabIndex = 2
        Me.NumCheckAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCheckAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Enabled = False
        Me.Employee_Cod1.Kind_Employee = ""
        Me.Employee_Cod1.Location = New System.Drawing.Point(111, 8)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod1.TabIndex = 0
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmployeeName.Location = New System.Drawing.Point(215, 7)
        Me.LblEmployeeName.Name = "LblEmployeeName"
        Me.LblEmployeeName.Size = New System.Drawing.Size(287, 23)
        Me.LblEmployeeName.TabIndex = 422
        Me.LblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(41, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 421
        Me.Label1.Text = "Employee"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DteDate_document
        '
        Me.DteDate_document.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_document.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_document.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_document.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_document.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_document.EditableSal = True
        Me.DteDate_document.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DteDate_document.ForeColor = System.Drawing.Color.Black
        Me.DteDate_document.Image = CType(resources.GetObject("DteDate_document.Image"), System.Drawing.Image)
        Me.DteDate_document.Location = New System.Drawing.Point(111, 31)
        Me.DteDate_document.MaxValue = CType(2500, Short)
        Me.DteDate_document.MinValue = CType(1800, Short)
        Me.DteDate_document.Name = "DteDate_document"
        Me.DteDate_document.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_document.Sal_Mali = Nothing
        Me.DteDate_document.ShowButton = True
        Me.DteDate_document.Size = New System.Drawing.Size(102, 22)
        Me.DteDate_document.TabIndex = 1
        Me.DteDate_document.VisualStyle = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(0, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 21)
        Me.Label13.TabIndex = 337
        Me.Label13.Text = "Payroll Date "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Sort32
        '
        Me.Sort32.Key = "Sort3"
        Me.Sort32.Name = "Sort32"
        Me.Sort32.Text = "Order By A Customer Payements"
        '
        'Sort31
        '
        Me.Sort31.Key = "Sort3"
        Me.Sort31.Name = "Sort31"
        '
        'Sort3
        '
        Me.Sort3.Key = "SortByType"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Sort By Type"
        '
        'SortByType1
        '
        Me.SortByType1.Key = "SortByType"
        Me.SortByType1.Name = "SortByType1"
        '
        'Command2
        '
        Me.Command2.Key = "Command2"
        Me.Command2.Name = "Command2"
        Me.Command2.Text = "2222222"
        '
        'Command21
        '
        Me.Command21.Key = "Command2"
        Me.Command21.Name = "Command21"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.PrintChecks)
        Me.Panel9.Controls.Add(Me.BtnShowPayCheck)
        Me.Panel9.Controls.Add(Me.Label40)
        Me.Panel9.Controls.Add(Me.BtnFirst)
        Me.Panel9.Controls.Add(Me.Label41)
        Me.Panel9.Controls.Add(Me.BtnLast)
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label43)
        Me.Panel9.Controls.Add(Me.BtnEdit)
        Me.Panel9.Controls.Add(Me.Label50)
        Me.Panel9.Controls.Add(Me.Label51)
        Me.Panel9.Controls.Add(Me.Label52)
        Me.Panel9.Controls.Add(Me.Label53)
        Me.Panel9.Controls.Add(Me.Label54)
        Me.Panel9.Controls.Add(Me.Label55)
        Me.Panel9.Controls.Add(Me.BtnDelete)
        Me.Panel9.Controls.Add(Me.BtnNew)
        Me.Panel9.Controls.Add(Me.BtnFind)
        Me.Panel9.Controls.Add(Me.BtnNext)
        Me.Panel9.Controls.Add(Me.BtnPrev)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(557, 45)
        Me.Panel9.TabIndex = 143
        '
        'PrintChecks
        '
        Me.PrintChecks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrintChecks.Location = New System.Drawing.Point(400, 7)
        Me.PrintChecks.Name = "PrintChecks"
        Me.PrintChecks.Size = New System.Drawing.Size(65, 31)
        Me.PrintChecks.TabIndex = 436
        Me.PrintChecks.Text = "Print Checks"
        '
        'BtnShowPayCheck
        '
        Me.BtnShowPayCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnShowPayCheck.Location = New System.Drawing.Point(481, 7)
        Me.BtnShowPayCheck.Name = "BtnShowPayCheck"
        Me.BtnShowPayCheck.Size = New System.Drawing.Size(65, 31)
        Me.BtnShowPayCheck.TabIndex = 435
        Me.BtnShowPayCheck.Text = "Show PayCheck"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(3, 31)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 10)
        Me.Label40.TabIndex = 192
        Me.Label40.Text = "First"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(3, 2)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(113, 31)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(33, 10)
        Me.Label41.TabIndex = 189
        Me.Label41.Text = "Last"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(113, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(354, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(42, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(359, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(246, 31)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 10)
        Me.Label43.TabIndex = 184
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(245, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(320, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(280, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(38, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(206, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(159, 31)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 10)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(39, 31)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 10)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(76, 31)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(33, 10)
        Me.Label55.TabIndex = 171
        Me.Label55.Text = "Next"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(282, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(208, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(160, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(77, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(39, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(320, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employee_code + ' - ' + PayrollDate AS Expr1, id_pay_period FROM pay_main_" & _
        "employee WHERE (Payment_Type = '1')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DApay_main_employee
        '
        Me.DApay_main_employee.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_main_employee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_main_employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_pay_period", "id_pay_period"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("day_work", "day_work"), New System.Data.Common.DataColumnMapping("time_work_Hour", "time_work_Hour"), New System.Data.Common.DataColumnMapping("time_work_Minute", "time_work_Minute"), New System.Data.Common.DataColumnMapping("Other_Pay", "Other_Pay"), New System.Data.Common.DataColumnMapping("gross_pay", "gross_pay"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("PayrollDate", "PayrollDate"), New System.Data.Common.DataColumnMapping("PaymentFlag", "PaymentFlag"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'DAbas_banks
        '
        Me.DAbas_banks.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAbas_banks.InsertCommand = Me.SqlInsertCommand2
        Me.DAbas_banks.SelectCommand = Me.SqlSelectCommand8
        Me.DAbas_banks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        Me.DAbas_banks.UpdateCommand = Me.SqlUpdateCommand2
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
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT id_bank, name_bank FROM bas_banks"
        Me.SqlSelectCommand8.Connection = Me.Cnn
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
        'CmdReader
        '
        Me.CmdReader.Connection = Me.CnnReader
        '
        'CnnReader
        '
        Me.CnnReader.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'DApay_tab_federal_tax_dtl
        '
        Me.DApay_tab_federal_tax_dtl.SelectCommand = Me.SqlSelectCommand9
        Me.DApay_tab_federal_tax_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_federal_tax_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_federal_tax", "id_federal_tax"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("over_", "over_"), New System.Data.Common.DataColumnMapping("but_not_over", "but_not_over"), New System.Data.Common.DataColumnMapping("percent_tax", "percent_tax"), New System.Data.Common.DataColumnMapping("dollor_tax", "dollor_tax")})})
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
        'DApay_tab_state_tax_dtl
        '
        Me.DApay_tab_state_tax_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DApay_tab_state_tax_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_state_tax_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_state_tax", "id_state_tax"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("over_", "over_"), New System.Data.Common.DataColumnMapping("but_not_over", "but_not_over"), New System.Data.Common.DataColumnMapping("percent_tax", "percent_tax"), New System.Data.Common.DataColumnMapping("dollor_tax", "dollor_tax")})})
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoWeekly)
        Me.GroupBox1.Controls.Add(Me.RdoMonthly)
        Me.GroupBox1.Location = New System.Drawing.Point(377, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 34)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'RdoMonthly
        '
        Me.RdoMonthly.Checked = True
        Me.RdoMonthly.Location = New System.Drawing.Point(7, 8)
        Me.RdoMonthly.Name = "RdoMonthly"
        Me.RdoMonthly.Size = New System.Drawing.Size(64, 24)
        Me.RdoMonthly.TabIndex = 1
        Me.RdoMonthly.TabStop = True
        Me.RdoMonthly.Text = "Monthly"
        '
        'RdoWeekly
        '
        Me.RdoWeekly.Location = New System.Drawing.Point(91, 8)
        Me.RdoWeekly.Name = "RdoWeekly"
        Me.RdoWeekly.Size = New System.Drawing.Size(64, 24)
        Me.RdoWeekly.TabIndex = 1
        Me.RdoWeekly.Text = "Weekly"
        '
        'FrmEmployeeBonus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(557, 187)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmEmployeeBonus"
        Me.Text = "Employee Commission / Bonus"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmEmployeeBonus1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmReceivePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        Me.CnnReader.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_main_employee ADD Payment_Type Char(1) DEFAULT  0"
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = " Update pay_main_employee set Payment_Type='0' Where Payment_Type is null "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Call FillDataSets()
        CM = CType(Me.BindingContext(DsFrmEmployeeBonus1.pay_main_employee), CurrencyManager)

        If BankDepositVar.Trim.Length > 0 Then
            Call PAddNew()
            Employee_Cod1.Focus()
        Else
            If EmployeeBonusHeadTempVar = 0 Then
                Call PFirstRecord(False)
            Else
                CmbHead.SelectedValue = EmployeeBonusHeadTempVar
            End If
            Try
                Call FillFields(CmbHead.SelectedValue)
            Catch ex As Exception
            End Try
            Call AfterSaveOrCancel()
            Employee_Cod1.Focus()
        End If
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        LblEmployeeName.Text = Employee_Cod1.Desc_Employee
    End Sub
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        LblEmployeeName.Text = ""
    End Sub
    Private Sub FillDataSets()

        DAbas_banks.Fill(DsFrmEmployeeBonus1, "bas_banks")

        Call FillGL_debit_deposit_head()

    End Sub
    Private Sub FillGL_debit_deposit_head()
        DsFrmEmployeeBonus1.pay_main_employee.Clear()
        DApay_main_employee.Fill(DsFrmEmployeeBonus1, "pay_main_employee")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew
        CashPaidOut_OtherReceiptFlag = False
        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        EmployeeBonusHeadTempVar = CmbHead.SelectedValue
        Call ClearField()

        DteDate_document.Text = Format(Now.Date, PubDateFormat)

        Employee_Cod1.Focus()

        BtnNew.Enabled = False
        BtnFind.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PEdit()

        If CmbHead.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Try
            Call FillFields(CmbHead.SelectedValue)
        Catch ex As Exception
        End Try

        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True)
        EmployeeBonusHeadTempVar = CmbHead.SelectedValue
        Employee_Cod1.Focus()

        BtnNew.Enabled = False
        BtnFind.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PDelete()
        If CmbHead.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "DELETE FROM pay_deductin_main_dtl WHERE Id_pay_period=" & CmbHead.SelectedValue
                CmdGeneral.ExecuteScalar()

                If CmdDelete.Connection.State <> ConnectionState.Open Then
                    CmdDelete.Connection.Open()
                End If
                CmdDelete.Parameters("@id_pay_period").Value = CmbHead.SelectedValue
                CmdDelete.ExecuteNonQuery()
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                EmployeeBonusHeadTempVar = 0
                Call FillGL_debit_deposit_head()

                Call PNextRecord(False)
                If EmployeeBonusHeadTempVar = 0 Then
                    Call PPreviousRecord(False)
                End If
                If EmployeeBonusHeadTempVar = 0 Then
                    Call ClearField()
                Else
                    Call FillFields(EmployeeBonusHeadTempVar)
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            Finally
                CmdDelete.Connection.Close()
            End Try
            Call AfterSaveOrCancel()
        Else
            Employee_Cod1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Function PSave() As Boolean
        PSave = True
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT  count(*) FROM  pay_main_employee Where Payment_Type='1' AND employee_code=" & Qt(Employee_Cod1.EmployeeCod) & " AND PayrollDate=" & Qt(DteDate_document.Text)
                If CmdGeneral.ExecuteScalar > 0 Then
                    PSave = False
                    MsgBox("The Same Employee With The Same Date Exist.")
                    Exit Function
                End If

                EmployeeBonusHeadTempVar = PInsert()
                ChangeOK = IIf(EmployeeBonusHeadTempVar = 0, False, True)
                If BankDepositVar.Trim.Length > 0 Then
                    BankDepositVar = EmployeeBonusHeadTempVar
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(EmployeeBonusHeadTempVar)
        End Select
        If ChangeOK Then
            Call FillGL_debit_deposit_head()
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            CmbHead.SelectedValue = EmployeeBonusHeadTempVar
            Call FillFields(CmbHead.SelectedValue)
            CmbHead.Focus()
        End If
    End Function
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbHead.SelectedValue = EmployeeBonusHeadTempVar
        Call FillFields(CmbHead.SelectedValue)
        Call AfterSaveOrCancel()
        CmbHead.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        BtnFind.Enabled = True
        MAddNew.Enabled = True
        If CmbHead.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False
            MDelete.Enabled = False
            BtnEdit.Enabled = False
            MEdit.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnFirst.Enabled = False
            BtnLast.Enabled = False
            MPreviousRecord.Enabled = False
            MNextRecord.Enabled = False
            MFirstRecord.Enabled = False
            MLastRecord.Enabled = False
        Else
            BtnDelete.Enabled = True
            MDelete.Enabled = True
            BtnEdit.Enabled = True
            MEdit.Enabled = True
            BtnPrev.Enabled = True
            BtnNext.Enabled = True
            BtnFirst.Enabled = True
            BtnLast.Enabled = True
            MPreviousRecord.Enabled = True
            MNextRecord.Enabled = True
            MFirstRecord.Enabled = True
            MLastRecord.Enabled = True
        End If
        Call EnableField(False)
    End Sub
    Private Sub MAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAddNew.Click
        Call PAddNew()
    End Sub
    Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEdit.Click
        Call PEdit()
    End Sub
    Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDelete.Click
        Call PDelete()
    End Sub
    Private Sub MSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSave.Click
        Call PSave()
    End Sub
    Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
        Call PCancel()
    End Sub
    Private Sub TxtRefrence_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumCheckAmount.TextChanged, CmbId_bank.SelectedValueChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If Employee_Cod1.Text.Trim.Length > 0 And Mid(DteDate_document.Text, 1, 4).Trim.Length > 0 And LblEmployeeName.Text.Trim.Length > 0 Then
                BtnSave.Enabled = True
                MSave.Enabled = True
            Else
                BtnSave.Enabled = False
                MSave.Enabled = False
            End If
        End If
    End Sub
    Private Sub MFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFirstRecord.Click
        Call PFirstRecord()
    End Sub
    Private Sub MPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPreviousRecord.Click
        Call PPreviousRecord()
    End Sub
    Private Sub MNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNextRecord.Click
        Call PNextRecord()
    End Sub
    Private Sub MLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MLastRecord.Click
        Call PLastRecord()
    End Sub
    Private Sub PFirstRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CM.Position = 0
            Call FillFields(CmbHead.SelectedValue)
        End If
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CM.Position = CM.Position - 1
            Call FillFields(CmbHead.SelectedValue)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmEmployeeBonus1.pay_main_employee.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = CM.Position + 1
            Call FillFields(CmbHead.SelectedValue)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmEmployeeBonus1.pay_main_employee.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = DsFrmEmployeeBonus1.pay_main_employee.Rows.Count - 1
            Call FillFields(CmbHead.SelectedValue)
        End If
    End Sub
    Private Sub CmbHead_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbHead.SelectionChangeCommitted
        Call FillFields(CmbHead.SelectedValue)
        'Call AfterSaveOrCancel()
    End Sub
    Private Sub SetNoRecordFind()
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Private Sub ShowFilterProcPanel()
        Dim I As Integer, k As Integer
        If PnlSearch.Height = 0 Then
            k = -1
        Else
            k = 1
        End If
        Try
            For I = 1 To PnlSearchHeight
                PnlSearch.Height = PnlSearch.Height - k
                Me.Height = Me.Height - k
            Next I
        Catch
            '                    PanelSearch.Visible = Not PanelSearch.Visible
        End Try
        'Me.Height = Me.Height - (k * PnlSearchHeight)
        If PnlSearch.Height <> 0 Then
            'GRDFWG.Height = PanelKartabl.Height - SBKartabl.Height
            CmbHead.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub PPrintMasterInformation()
        'If CmbHead.Text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@refrence_no").Value = CmbHead.Text
        '    DAInspectionMaster.Fill(DsFrmInspectionMaster1, "InspectionMaster")
        '    Prn = New FrmRepView
        '    Prn.MdiParent = PubMFrmMain
        '    Orpt.SetParameterValue("CompanyName", PubCompanyName)
        '    Orpt.SetDataSource(DsFrmInspectionMaster1)
        '    Prn.CrViewer.ReportSource = Orpt
        '    Prn.Show()
        'End If
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean)
        If Status = MainModule.WorkStates.AddNew Then
            Employee_Cod1.Enabled = instatus
            DteDate_document.Enabled = instatus
        Else
            Employee_Cod1.Enabled = False
            DteDate_document.Enabled = False
        End If
        RdoMonthly.Enabled = instatus
        RdoWeekly.Enabled = instatus
        NumCheckAmount.Enabled = instatus
        CmbId_bank.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        Id_pay_periodVar = 0
        Employee_Cod1.EmployeeCod = ""
        NumCheckAmount.Text = 0
        NumNetPAy.Text = 0
        DteDate_document.Text = Format(Now.Date, PubDateFormat)
    End Sub
    Friend Function PInsert() As Decimal
        Dim thisrow As DataRow
        PInsert = 0
        Try
            PInsert = DoInsertAndUpdate(False)
            Call Calculation()
            If PInsert < 0 Then
                PInsert = 0
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = 0
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisRefrence_No As String) As Boolean
        PUpdate = True
        Try
            If DoInsertAndUpdate(True) > 0 Then
                PUpdate = True
            Else
                PUpdate = False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Private Function DoInsertAndUpdate(ByVal IsEditFlag As Boolean) As Decimal
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim tran1 As SqlClient.SqlTransaction
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1
        Try
            If Id_pay_periodVar > 0 Then
                CmdGeneral.CommandText = "Update pay_main_employee Set PayrollDate=" & Qt(DteDate_document.Text) & ",Other_Pay=" & NumCheckAmount.Text & ",gross_pay=" & NumCheckAmount.Text & " Where id_pay_period=" & Id_pay_periodVar
                CmdGeneral.ExecuteNonQuery()
            Else
                CmdGeneral.CommandText = "Insert into pay_main_employee (employee_code,PayrollDate,Payment_Type,gross_pay,Other_Pay,time_work_Hour,time_work_Minute) VALUES (" & Qt(Employee_Cod1.EmployeeCod) & "," & Qt(DteDate_document.Text) & ",'1'," & NumCheckAmount.Text & "," & NumCheckAmount.Text & ",'','') " & _
                ";Select id_pay_period from pay_main_employee where id_pay_period=@@IDENTITY"
                Id_pay_periodVar = CmdGeneral.ExecuteScalar()
            End If
            tran1.Commit()
            DoInsertAndUpdate = Id_pay_periodVar
        Catch ex As Exception
            tran1.Rollback()
            DoInsertAndUpdate = 0
            MsgBox("Can't Save Information,Try Again")
        End Try
    End Function
    Friend Function FillFields(ByVal ThisId_debit_deposit_head As Decimal) As Boolean
        FillFields = False
        If ThisId_debit_deposit_head = 0 Then
            Exit Function
        Else
            Id_pay_periodVar = ThisId_debit_deposit_head
        End If

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdReader.Connection.State <> ConnectionState.Open Then
                CmdReader.Connection.Open()
            End If
            CmdReader.CommandText = "SELECT * from pay_main_employee where id_pay_period=" & ThisId_debit_deposit_head
            SQLReader = CmdReader.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                'CmbId_bank.SelectedValue = Trim(SQLReader.Item("id_bank") & "")
                DteDate_document.Text = SQLReader.Item("PayrollDate") & ""
                Employee_Cod1.EmployeeCod = SQLReader.Item("employee_code") & ""
                NumCheckAmount.Text = SQLReader.Item("gross_pay")
                NumNetPAy.Text = CalcNetPay()
                FillFields = True
            Else
                'CmbBank.SelectedValue = 0
                DteDate_document.Text = ""
                NumCheckAmount.Text = 0
                NumNetPAy.Text = 0
                Employee_Cod1.EmployeeCod = ""
            End If
            SQLReader.Close()
            CnnReader.Close()

            Call FillGL_debit_deposit(ThisId_debit_deposit_head)
            EmployeeBonusHeadTempVar = ThisId_debit_deposit_head
        Catch ex As Exception
            MsgBox("Error in loading data")
        End Try
        Try
            CmdGeneral.Connection.Close()
        Catch ex As Exception
        End Try
        AfterSaveOrCancel()
    End Function
    Private Sub FillGL_debit_deposit(ByVal ThisId_debit_deposit_head As Decimal)
        '''DsFrmBankDeposits1.GL_debit_deposit.Clear()
        '''DsFrmBankDeposits1.GL_debit_depositForEdit.Clear()
        '''DAGL_debit_deposit.SelectCommand.Parameters("@id_debit_deposit_head").Value = ThisId_debit_deposit_head
        '''DAGL_debit_deposit.Fill(DsFrmBankDeposits1, "GL_debit_deposit")
        '''DAGL_debit_deposit.Fill(DsFrmBankDeposits1, "GL_debit_depositForEdit")
    End Sub
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call PAddNew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call PEdit()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Call PDelete()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call PSave()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call PCancel()
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Call PFirstRecord()
    End Sub
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Call PPreviousRecord()
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Call PNextRecord()
    End Sub
    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Call PLastRecord()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmSearchEmpoyeeBonus = New FrmSearchEmpoyeeBonus
        MyFrmSearchEmpoyeeBonus.ShowDialog()
    End Sub
    Private Sub MyFrmSearchEmpoyeeBonus_EmployeeBonusFind(ByVal Thisid_pay_period As Int16) Handles MyFrmSearchEmpoyeeBonus.EmployeeBonusFind
        Try
            CmbHead.SelectedValue = Thisid_pay_period
            Call FillFields(Thisid_pay_period)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PrintChecks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintChecks.Click
        Try
            MyFrmCheckScreen = New UcAccount.FrmCheckScreen
            Dim PrintCounter As Integer
            Dim ReturndIdcheck As Int64 = 0
            Dim ThisEmployee As String
            Dim ThisNetPay As Decimal = 0
            If Id_pay_periodVar = 0 Then
                If Not PSave() Then
                    Exit Sub
                End If
            End If
            If True Then 'PaymentFlag 
                ThisEmployee = Employee_Cod1.EmployeeCod
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT  id_check FROM pay_main_employee WHERE Id_pay_period=" & Id_pay_periodVar
                If Trim(CmdGeneral.ExecuteScalar & "").Length = 0 Then
                    Dim ds1 As New UcAccount.DSFrmCheckScreen
                    ReturndIdcheck = 0

                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    ThisNetPay = CalcNetPay()
                    If ThisNetPay > 0 Then
                        Dim dr As DataRow
                        dr = ds1.bank_check_dtl.NewRow
                        dr("id_check") = 0
                        dr("radif") = 1
                        dr("gl_account") = Retrieve_GLAccount("01")
                        dr("amount") = ThisNetPay
                        dr("memo_dtl") = "Net Pay"
                        ds1.bank_check_dtl.Rows.Add(dr)
                        MyFrmCheckScreen.SaveAndPrint(CmbId_bank.SelectedValue, DteDate_document.Text, ThisNetPay, ThisEmployee, ds1.bank_check_dtl, ReturndIdcheck)
                        'If ReturndIdcheck > 0 Then
                        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        '        CmdGeneral.Connection.Open()
                        '    End If
                        '    CmdGeneral.CommandText = "UPDATE pay_main_employee SET id_check = " & ReturndIdcheck & " WHERE id_pay_period=" & DsFrmPayCalculation1.employee.Rows(PrintCounter).Item("id_pay_period")
                        '    CmdGeneral.ExecuteNonQuery()
                        'End If
                    End If
                Else
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnShowPayCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowPayCheck.Click

        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.Edit Then
            If Not PSave() Then
                Exit Sub
            End If
        End If

        'CmdGeneral.CommandText = "SELECT Id_pay_period FROM pay_main_employee WHERE Payment_Type='1' AND employee_code=" & Qt(Employee_Cod1.EmployeeCod) & " AND PayrollDate=" & Qt(DteDate_document.Text)
        'Dim Id_pay_periodVar As Int32 = Val(CmdGeneral.ExecuteScalar & "")

        Call ShowPayCheck(Employee_Cod1.EmployeeCod, Id_pay_periodVar)
        Call CalcNetPay()
    End Sub
    Private Sub ShowPayCheck(ByVal ThisEmployee As String, ByVal ThisId_pay_period As Integer)

        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.Edit Then
            If Not PSave() Then
                Exit Sub
            End If
        End If

        Dim MyFrmPayCheck As New FrmPayCheck
        MyFrmPayCheck.DsFrmPayCheck1.Clear()
        Dim i As Integer

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdReader.Connection.State <> ConnectionState.Open Then
            CmdReader.Connection.Open()
        End If
        CmdReader.CommandText = "SELECT  gross_pay , Other_Pay FROM  pay_main_employee Where Id_pay_period=" & ThisId_pay_period
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
        " Where pay_deductin_main_dtl.Id_pay_period=" & ThisId_pay_period
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
        MyFrmPayCheck.PayrollDateVar = DteDate_document.Text
        MyFrmPayCheck.Id_bankVar = CmbId_bank.SelectedValue
        MyFrmPayCheck.CheckDateVar = DteDate_document.Text
        MyFrmPayCheck.Id_pay_periodVar = ThisId_pay_period

        MyFrmPayCheck.ShowDialog()
        If MyFrmPayCheck.ConfirmFlag Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Update pay_main_employee Set PaymentFlag=1 Where id_pay_period=" & ThisId_pay_period
            CmdGeneral.ExecuteNonQuery()
        End If

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
    Private Function CalcNetPay() As Decimal
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = "SELECT  isnull(gross_pay,0) FROM  pay_main_employee Where Payment_Type='1' AND employee_code=" & Qt(Employee_Cod1.EmployeeCod) & " AND PayrollDate=" & Qt(DteDate_document.Text)
            CalcNetPay = CmdGeneral.ExecuteScalar
            CmdGeneral.CommandText = "SELECT  ISNULL(SUM(pay_deductin_main_dtl.amount_deduction_employee), 0) FROM  pay_deductin_main_dtl INNER JOIN pay_main_employee ON pay_deductin_main_dtl.id_pay_period = pay_main_employee.id_pay_period WHERE Payment_Type='1' AND pay_main_employee.employee_code = " & Qt(Employee_Cod1.EmployeeCod) & " And pay_main_employee.PayrollDate = " & Qt(DteDate_document.Text)
            CalcNetPay = CalcNetPay - CmdGeneral.ExecuteScalar
        Catch ex As Exception
        End Try
    End Function
    ' *************************************************************************************
    ' *************************************************************************************
    ' in barnameh dar FrmPayCalculation ham vojood darad.taghirat dar oonja ham lahaz shavad
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
    Private Function Checkstatus() As Boolean
        Checkstatus = True
        If Mid(DteDate_document.Text, 1, 2).Trim.Length = 0 Then
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

        ThisYearVar = Mid(DteDate_document.Text, 7, 4)

    End Function
    Private Sub Calculation()
        If Not Checkstatus() Then
            Exit Sub
        End If

        Dim ErrVar As String = ""

        DsFrmEmployeeBonus1.pay_tab_federal_tax_dtl.Clear()
        DApay_tab_federal_tax_dtl.SelectCommand.Parameters("@year_tax").Value = ThisYearVar
        DApay_tab_federal_tax_dtl.Fill(DsFrmEmployeeBonus1, "pay_tab_federal_tax_dtl")

        DsFrmEmployeeBonus1.pay_tab_state_tax_dtl.Clear()
        DApay_tab_state_tax_dtl.SelectCommand.Parameters("@year_tax").Value = ThisYearVar
        DApay_tab_state_tax_dtl.SelectCommand.Parameters("@State").Value = ThisStoreStateVar
        DApay_tab_state_tax_dtl.Fill(DsFrmEmployeeBonus1, "pay_tab_state_tax_dtl")

        Dim GrossPayVar As Decimal = 0
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

        Dim PaymentFlagVar As Boolean
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT  PaymentFlag  FROM pay_main_employee Where Id_pay_period=" & Id_pay_periodVar
        Try
            PaymentFlagVar = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            PaymentFlagVar = False
        End Try

        If Not PaymentFlagVar And Id_pay_periodVar > 0 Then
            If Id_pay_periodVar > 0 Then
                CmdGeneral.CommandText = "Delete FROM pay_deductin_main_dtl Where id_pay_period=" & Id_pay_periodVar
                CmdGeneral.ExecuteNonQuery()
            End If
        End If
        If Not PaymentFlagVar Then
            GrossPayVar = NumCheckAmount.Text

            If RdoMonthly.Checked Then
                ZaribKindPeriod = 12
            ElseIf RdoWeekly.Checked Then
                ZaribKindPeriod = 52
            Else
                ZaribKindPeriod = 12
            End If
            ''''Select Case .Rows(CalculationCounter).Item("last_period")
            ''''    Case "1"
            ''''        ZaribKindPeriod = 52
            ''''    Case "2"
            ''''        ZaribKindPeriod = 26
            ''''    Case "3"
            ''''        ZaribKindPeriod = 24
            ''''    Case "4"
            ''''        ZaribKindPeriod = 12
            ''''End Select

            If GrossPayVar > 0 Then
                Dim last_statusVar As String
                CmdGeneral.CommandText = "SELECT last_status FROM employee Where employee_code=" & Qt(Employee_Cod1.EmployeeCod)
                Try
                    last_statusVar = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    last_statusVar = False
                End Try

                If SetFederalTaxRow(last_statusVar, GrossPayVar, FederalDollar_Tax) And SetStateTaxRow(last_statusVar, GrossPayVar, StateDollar_Tax) Then

                    AnnualIncomeVar = (GrossPayVar) * ZaribKindPeriod

                    Dim Allowance_FederalVar As String
                    CmdGeneral.CommandText = "SELECT Allowance_Federal FROM employee Where employee_code=" & Qt(Employee_Cod1.EmployeeCod)
                    Try
                        Allowance_FederalVar = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        Allowance_FederalVar = False
                    End Try
                    Dim Allowance_depndntsVar As String
                    CmdGeneral.CommandText = "SELECT Allowance_depndnts FROM employee Where employee_code=" & Qt(Employee_Cod1.EmployeeCod)
                    Try
                        Allowance_depndntsVar = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        Allowance_depndntsVar = False
                    End Try

                    AnnualAmountofAllowanceVar = FederalTaxTableRow.Item("withholding_allownce") * Allowance_FederalVar
                    FederalTaxAmountVar = AnnualIncomeVar - AnnualAmountofAllowanceVar
                    If FederalTaxAmountVar < 0 Then
                        FederalTaxAmountVar = 0
                    End If
                    If SetFederalTaxRow(last_statusVar, FederalTaxAmountVar, FederalDollar_Tax) Then
                        FederalTaxVar = Math.Round((((FederalTaxAmountVar - FederalTaxTableRow.Item("over_")) * FederalTaxTableRow.Item("percent_tax")) / 100) + FederalDollar_Tax, 2)
                        FederalTaxVar = Math.Round(FederalTaxVar / ZaribKindPeriod, 2)

                        SocialSecurityEmployeeTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxTableRow.Item("social_sec_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("social_sec_employee")) / 100
                        SocialSecurityEmployerTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("social_sec_wagelimit"), FederalTaxTableRow.Item("social_sec_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("social_sec_employer")) / 100

                        SocialSecurityEmployeeTaxVar = Math.Round(SocialSecurityEmployeeTaxVar / ZaribKindPeriod, 2)
                        SocialSecurityEmployerTaxVar = Math.Round(SocialSecurityEmployerTaxVar / ZaribKindPeriod, 2)

                        MedicareEmployeeTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxTableRow.Item("medi_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("medi_employee")) / 100
                        MedicareEmployerTaxVar = (IIf(AnnualIncomeVar > FederalTaxTableRow.Item("medi_wagelimit"), FederalTaxTableRow.Item("medi_wagelimit"), AnnualIncomeVar) * FederalTaxTableRow.Item("medi_employer")) / 100

                        MedicareEmployeeTaxVar = Math.Round(MedicareEmployeeTaxVar / ZaribKindPeriod, 2)
                        MedicareEmployerTaxVar = Math.Round(MedicareEmployerTaxVar / ZaribKindPeriod, 2)

                        CmdGeneral.CommandText = "SELECT isnull(sum(gross_pay),0) FROM pay_main_employee Where substring(PayrollDate,7,4)=" & Qt(Mid(DteDate_document.Text, 7, 4)) & " AND PayrollDate<>" & Qt(DteDate_document.Text) & " AND employee_code=" & Qt(Employee_Cod1.EmployeeCod)
                        EmplyeeTotalYear = CmdGeneral.ExecuteScalar()
                        If EmplyeeTotalYear < FederalTaxTableRow.Item("unemplyment_wagelimit") Then
                            If EmplyeeTotalYear + GrossPayVar > FederalTaxTableRow.Item("unemplyment_wagelimit") Then
                                UnemploymentEmployeeTaxVar = ((FederalTaxTableRow.Item("unemplyment_wagelimit") - EmplyeeTotalYear) * FederalTaxTableRow.Item("unemplyment_employee")) / 100
                                UnemploymentEmployerTaxVar = ((FederalTaxTableRow.Item("unemplyment_wagelimit") - EmplyeeTotalYear) * FederalTaxTableRow.Item("unemplyment_employer")) / 100
                            Else
                                UnemploymentEmployeeTaxVar = (GrossPayVar * FederalTaxTableRow.Item("unemplyment_employee")) / 100
                                UnemploymentEmployerTaxVar = (GrossPayVar * FederalTaxTableRow.Item("unemplyment_employer")) / 100
                            End If
                        End If

                        personal_allowance_Zarib = 1
                        Select Case last_statusVar
                            Case 1, 3, 4 'Single , MArried Joint , House Hold
                                personal_allowance_Zarib = 1
                            Case 2 ' Maried Joint
                                personal_allowance_Zarib = 2
                        End Select
                        StateTaxAmountVar = AnnualIncomeVar - StateTaxTableRow.Item("standard_deduction") - (StateTaxTableRow.Item("personal_allowance") * personal_allowance_Zarib) - (StateTaxTableRow.Item("dependent_allowance") * Allowance_depndntsVar)
                        If StateTaxAmountVar < 0 Then
                            StateTaxAmountVar = 0
                        End If

                        Call SetStateTaxRow(last_statusVar, StateTaxAmountVar, StateDollar_Tax)
                        StateTaxVar = Math.Round((((StateTaxAmountVar - StateTaxTableRow.Item("over_")) * StateTaxTableRow.Item("percent_tax")) / 100) + StateDollar_Tax, 2)

                        StateTaxVar = Math.Round(StateTaxVar / ZaribKindPeriod, 2)

                        Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "06", 0, FederalTaxVar, 0)
                        Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "07", 0, SocialSecurityEmployeeTaxVar, SocialSecurityEmployerTaxVar)
                        Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "08", 0, MedicareEmployeeTaxVar, MedicareEmployerTaxVar)
                        Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "09", 0, StateTaxVar, 0)
                        Call InsertIntopay_deductin_main_dtl(Id_pay_periodVar, "10", 0, UnemploymentEmployeeTaxVar, UnemploymentEmployerTaxVar)

                    Else
                        MsgBox("Error in Federal Tax")
                    End If
                Else
                    MsgBox("Error in Federal Or State Tax")
                End If
            End If

        End If

    End Sub
    Private Function SetFederalTaxRow(ByVal Thislast_status As String, ByVal ThisPayAmount As Decimal, ByRef ThisDollar_Tax As Decimal) As Boolean
        ThisDollar_Tax = 0
        Dim i As Integer
        With DsFrmEmployeeBonus1.pay_tab_federal_tax_dtl
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
        With DsFrmEmployeeBonus1.pay_tab_state_tax_dtl
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
                Else
                    ThisDollar_Tax = 0
                End If
            Else
                SetStateTaxRow = False
                'Print Err
            End If
        End With
    End Function
    Private Sub InsertIntopay_deductin_main_dtl(ByVal Thisid_pay_period As Decimal, ByVal Thisdeduction_type As String, ByVal Thisid_deduction As Decimal, ByVal ThisEmployeeAmount As Decimal, ByVal ThisEmployerAmount As Decimal)
        If ThisEmployeeAmount <> 0 Or ThisEmployerAmount <> 0 Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Insert into pay_deductin_main_dtl (id_pay_period,deduction_type,id_deduction,amount_deduction_employee,amount_deduction_employer) Values (" & Thisid_pay_period & "," & Qt(Thisdeduction_type) & "," & Thisid_deduction & "," & ThisEmployeeAmount & "," & ThisEmployerAmount & ")"
            CmdGeneral.ExecuteNonQuery()
        End If
    End Sub
End Class
