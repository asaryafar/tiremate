Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEmployeeLoan
    Inherits FrmBase
    Friend Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public EmployeeCodVar As String = ""
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
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DApay_loan_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEmployeeLoan1 As UCEmployee.DSFrmEmployeeLoan
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_loan_main As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cmbloan_cod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DteDate_start As CalendarCombo.CalendarCombo
    Friend WithEvents NumAmount_loan As CalcUtils.UcCalcText
    Friend WithEvents Numtime_costus_pay As CalcUtils.UcCalcText
    Friend WithEvents NumCostus As CalcUtils.UcCalcText
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents CmGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MSave As System.Windows.Forms.MenuItem
    Friend WithEvents MCancel As System.Windows.Forms.MenuItem
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents CmdInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdate As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdDelete As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployeeLoan))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEmployeeLoan1 = New UCEmployee.DSFrmEmployeeLoan
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DApay_loan_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Cmbloan_cod = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_loan_main = New System.Data.SqlClient.SqlDataAdapter
        Me.DteDate_start = New CalendarCombo.CalendarCombo
        Me.NumAmount_loan = New CalcUtils.UcCalcText
        Me.Numtime_costus_pay = New CalcUtils.UcCalcText
        Me.NumCostus = New CalcUtils.UcCalcText
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Panel9.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEmployeeLoan1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label43)
        Me.Panel9.Controls.Add(Me.BtnEdit)
        Me.Panel9.Controls.Add(Me.Label50)
        Me.Panel9.Controls.Add(Me.Label51)
        Me.Panel9.Controls.Add(Me.Label52)
        Me.Panel9.Controls.Add(Me.BtnDelete)
        Me.Panel9.Controls.Add(Me.BtnNew)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(593, 45)
        Me.Panel9.TabIndex = 6
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(170, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(173, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(48, 31)
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
        Me.BtnEdit.Location = New System.Drawing.Point(45, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(129, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(87, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(4, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(87, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(5, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(129, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "pay_loan_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmEmployeeLoan1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>pay_loan_dtl</Caption><Columns Collection=""" & _
        "true""><Column0 ID=""id_deduction""><Caption>id_deduction</Caption><DataMember>id_d" & _
        "eduction</DataMember><Key>id_deduction</Key><Position>0</Position><Visible>False" & _
        "</Visible></Column0><Column1 ID=""loan_cod""><Caption>loan Code</Caption><TypeName" & _
        "EmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Da" & _
        "taMember>loan_cod</DataMember><Key>loan_cod</Key><Position>1</Position><Width>61" & _
        "</Width></Column1><Column2 ID=""loan_desc""><Caption>loan Desc</Caption><DataMembe" & _
        "r>loan_desc</DataMember><Key>loan_desc</Key><Position>2</Position><Width>125</Wi" & _
        "dth></Column2><Column3 ID=""date_start""><Caption>Loan Date</Caption><TypeNameEmpt" & _
        "yStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMe" & _
        "mber>date_start</DataMember><Key>date_start</Key><Position>3</Position><Width>78" & _
        "</Width></Column3><Column4 ID=""amount_loan""><Caption>Amount loan</Caption><DataM" & _
        "ember>amount_loan</DataMember><FormatString>c</FormatString><Key>amount_loan</Ke" & _
        "y><Position>4</Position><TextAlignment>Far</TextAlignment><Width>81</Width></Col" & _
        "umn4><Column5 ID=""costus""><Caption>Payment</Caption><DataMember>costus</DataMemb" & _
        "er><FormatString>c</FormatString><Key>costus</Key><Position>5</Position><TextAli" & _
        "gnment>Far</TextAlignment><Width>68</Width></Column5><Column6 ID=""time_costus_pa" & _
        "y""><Caption>No of Payments</Caption><DataMember>time_costus_pay</DataMember><Key" & _
        ">time_costus_pay</Key><Position>6</Position><Width>89</Width></Column6><Column7 " & _
        "ID=""active""><Caption>Active</Caption><ColumnType>CheckBox</ColumnType><DataMembe" & _
        "r>active</DataMember><EditType>CheckBox</EditType><Key>active</Key><Position>7</" & _
        "Position><Width>42</Width></Column7></Columns><GroupCondition ID="""" /><Key>pay_l" & _
        "oan_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(3, 47)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(586, 205)
        Me.GrdDetail.TabIndex = 7
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmEmployeeLoan1
        '
        Me.DsFrmEmployeeLoan1.DataSetName = "DSFrmEmployeeLoan"
        Me.DsFrmEmployeeLoan1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pay_loan_dtl.employee_code, pay_loan_dtl.loan_cod, pay_loan_dtl.date_start" & _
        ", pay_loan_dtl.amount_loan, pay_loan_dtl.costus, pay_loan_dtl.time_costus_pay, p" & _
        "ay_loan_dtl.active, pay_tab_loan_main.loan_desc, pay_loan_dtl.id_deduction FROM " & _
        "pay_loan_dtl INNER JOIN pay_tab_loan_main ON pay_loan_dtl.loan_cod = pay_tab_loa" & _
        "n_main.loan_cod WHERE (pay_loan_dtl.employee_code = @employee_code)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO pay_loan_dtl(employee_code, loan_cod, date_start, amount_loan, costus" & _
        ", time_costus_pay, active) VALUES (@employee_code, @loan_cod, @date_start, @amou" & _
        "nt_loan, @costus, @time_costus_pay, @active); SELECT employee_code, loan_cod, da" & _
        "te_start, amount_loan, costus, time_costus_pay, active FROM pay_loan_dtl WHERE (" & _
        "date_start = @date_start) AND (employee_code = @employee_code) AND (loan_cod = @" & _
        "loan_cod)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_cod", System.Data.SqlDbType.VarChar, 2, "loan_cod"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_loan", System.Data.SqlDbType.Money, 8, "amount_loan"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costus", System.Data.SqlDbType.Money, 8, "costus"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_costus_pay", System.Data.SqlDbType.SmallInt, 2, "time_costus_pay"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE pay_loan_dtl SET employee_code = @employee_code, loan_cod = @loan_cod, dat" & _
        "e_start = @date_start, amount_loan = @amount_loan, costus = @costus, time_costus" & _
        "_pay = @time_costus_pay, active = @active WHERE (date_start = @Original_date_sta" & _
        "rt) AND (employee_code = @Original_employee_code) AND (loan_cod = @Original_loan" & _
        "_cod) AND (active = @Original_active OR @Original_active IS NULL AND active IS N" & _
        "ULL) AND (amount_loan = @Original_amount_loan OR @Original_amount_loan IS NULL A" & _
        "ND amount_loan IS NULL) AND (costus = @Original_costus OR @Original_costus IS NU" & _
        "LL AND costus IS NULL) AND (time_costus_pay = @Original_time_costus_pay OR @Orig" & _
        "inal_time_costus_pay IS NULL AND time_costus_pay IS NULL); SELECT employee_code," & _
        " loan_cod, date_start, amount_loan, costus, time_costus_pay, active FROM pay_loa" & _
        "n_dtl WHERE (date_start = @date_start) AND (employee_code = @employee_code) AND " & _
        "(loan_cod = @loan_cod)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_cod", System.Data.SqlDbType.VarChar, 2, "loan_cod"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_loan", System.Data.SqlDbType.Money, 8, "amount_loan"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costus", System.Data.SqlDbType.Money, 8, "costus"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_costus_pay", System.Data.SqlDbType.SmallInt, 2, "time_costus_pay"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_start", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_start", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_loan_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "loan_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_loan", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_loan", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_costus", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "costus", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_time_costus_pay", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "time_costus_pay", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM pay_loan_dtl WHERE (date_start = @Original_date_start) AND (employee_" & _
        "code = @Original_employee_code) AND (loan_cod = @Original_loan_cod) AND (active " & _
        "= @Original_active OR @Original_active IS NULL AND active IS NULL) AND (amount_l" & _
        "oan = @Original_amount_loan OR @Original_amount_loan IS NULL AND amount_loan IS " & _
        "NULL) AND (costus = @Original_costus OR @Original_costus IS NULL AND costus IS N" & _
        "ULL) AND (time_costus_pay = @Original_time_costus_pay OR @Original_time_costus_p" & _
        "ay IS NULL AND time_costus_pay IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_start", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_start", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_loan_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "loan_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_loan", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_loan", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_costus", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "costus", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_time_costus_pay", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "time_costus_pay", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_loan_dtl
        '
        Me.DApay_loan_dtl.DeleteCommand = Me.SqlDeleteCommand1
        Me.DApay_loan_dtl.InsertCommand = Me.SqlInsertCommand1
        Me.DApay_loan_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_loan_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_loan_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("loan_cod", "loan_cod"), New System.Data.Common.DataColumnMapping("date_start", "date_start"), New System.Data.Common.DataColumnMapping("amount_loan", "amount_loan"), New System.Data.Common.DataColumnMapping("costus", "costus"), New System.Data.Common.DataColumnMapping("time_costus_pay", "time_costus_pay"), New System.Data.Common.DataColumnMapping("active", "active")})})
        Me.DApay_loan_dtl.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Cmbloan_cod
        '
        Me.Cmbloan_cod.DataSource = Me.DsFrmEmployeeLoan1.pay_tab_loan_main
        Me.Cmbloan_cod.DisplayMember = "loan_desc"
        Me.Cmbloan_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbloan_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbloan_cod.Location = New System.Drawing.Point(88, 258)
        Me.Cmbloan_cod.Name = "Cmbloan_cod"
        Me.Cmbloan_cod.Size = New System.Drawing.Size(144, 21)
        Me.Cmbloan_cod.TabIndex = 0
        Me.Cmbloan_cod.ValueMember = "loan_cod"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Loan Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT loan_cod, loan_desc, max_amount, GL_account, before_tax FROM pay_tab_loan_" & _
        "main"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO pay_tab_loan_main(loan_cod, loan_desc, max_amount, GL_account, before" & _
        "_tax) VALUES (@loan_cod, @loan_desc, @max_amount, @GL_account, @before_tax); SEL" & _
        "ECT loan_cod, loan_desc, max_amount, GL_account, before_tax FROM pay_tab_loan_ma" & _
        "in WHERE (loan_cod = @loan_cod)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_cod", System.Data.SqlDbType.VarChar, 2, "loan_cod"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_desc", System.Data.SqlDbType.VarChar, 50, "loan_desc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_amount", System.Data.SqlDbType.Money, 8, "max_amount"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@before_tax", System.Data.SqlDbType.Bit, 1, "before_tax"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE pay_tab_loan_main SET loan_cod = @loan_cod, loan_desc = @loan_desc, max_am" & _
        "ount = @max_amount, GL_account = @GL_account, before_tax = @before_tax WHERE (lo" & _
        "an_cod = @Original_loan_cod) AND (GL_account = @Original_GL_account OR @Original" & _
        "_GL_account IS NULL AND GL_account IS NULL) AND (before_tax = @Original_before_t" & _
        "ax OR @Original_before_tax IS NULL AND before_tax IS NULL) AND (loan_desc = @Ori" & _
        "ginal_loan_desc OR @Original_loan_desc IS NULL AND loan_desc IS NULL) AND (max_a" & _
        "mount = @Original_max_amount OR @Original_max_amount IS NULL AND max_amount IS N" & _
        "ULL); SELECT loan_cod, loan_desc, max_amount, GL_account, before_tax FROM pay_ta" & _
        "b_loan_main WHERE (loan_cod = @loan_cod)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_cod", System.Data.SqlDbType.VarChar, 2, "loan_cod"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_desc", System.Data.SqlDbType.VarChar, 50, "loan_desc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_amount", System.Data.SqlDbType.Money, 8, "max_amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@before_tax", System.Data.SqlDbType.Bit, 1, "before_tax"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_loan_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "loan_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_before_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "before_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_loan_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "loan_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_amount", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM pay_tab_loan_main WHERE (loan_cod = @Original_loan_cod) AND (GL_accou" & _
        "nt = @Original_GL_account OR @Original_GL_account IS NULL AND GL_account IS NULL" & _
        ") AND (before_tax = @Original_before_tax OR @Original_before_tax IS NULL AND bef" & _
        "ore_tax IS NULL) AND (loan_desc = @Original_loan_desc OR @Original_loan_desc IS " & _
        "NULL AND loan_desc IS NULL) AND (max_amount = @Original_max_amount OR @Original_" & _
        "max_amount IS NULL AND max_amount IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_loan_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "loan_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_before_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "before_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_loan_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "loan_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_amount", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_tab_loan_main
        '
        Me.DApay_tab_loan_main.DeleteCommand = Me.SqlDeleteCommand2
        Me.DApay_tab_loan_main.InsertCommand = Me.SqlInsertCommand2
        Me.DApay_tab_loan_main.SelectCommand = Me.SqlSelectCommand2
        Me.DApay_tab_loan_main.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_loan_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("loan_cod", "loan_cod"), New System.Data.Common.DataColumnMapping("loan_desc", "loan_desc"), New System.Data.Common.DataColumnMapping("max_amount", "max_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("before_tax", "before_tax")})})
        Me.DApay_tab_loan_main.UpdateCommand = Me.SqlUpdateCommand2
        '
        'DteDate_start
        '
        Me.DteDate_start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_start.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_start.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_start.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_start.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_start.EditableSal = True
        Me.DteDate_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteDate_start.Image = CType(resources.GetObject("DteDate_start.Image"), System.Drawing.Image)
        Me.DteDate_start.Location = New System.Drawing.Point(301, 259)
        Me.DteDate_start.MaxValue = CType(2500, Short)
        Me.DteDate_start.MinValue = CType(1800, Short)
        Me.DteDate_start.Name = "DteDate_start"
        Me.DteDate_start.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_start.Sal_Mali = Nothing
        Me.DteDate_start.ShowButton = True
        Me.DteDate_start.Size = New System.Drawing.Size(108, 23)
        Me.DteDate_start.TabIndex = 1
        Me.DteDate_start.VisualStyle = False
        '
        'NumAmount_loan
        '
        Me.NumAmount_loan.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount_loan.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmount_loan.DecimalDigits = 2
        Me.NumAmount_loan.DefaultSendValue = False
        Me.NumAmount_loan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumAmount_loan.Image = CType(resources.GetObject("NumAmount_loan.Image"), System.Drawing.Image)
        Me.NumAmount_loan.Location = New System.Drawing.Point(88, 285)
        Me.NumAmount_loan.Maxlength = 10
        Me.NumAmount_loan.Name = "NumAmount_loan"
        Me.NumAmount_loan.Size = New System.Drawing.Size(83, 22)
        Me.NumAmount_loan.TabIndex = 3
        Me.NumAmount_loan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmount_loan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numtime_costus_pay
        '
        Me.Numtime_costus_pay.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numtime_costus_pay.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numtime_costus_pay.DecimalDigits = 0
        Me.Numtime_costus_pay.DefaultSendValue = False
        Me.Numtime_costus_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numtime_costus_pay.Image = CType(resources.GetObject("Numtime_costus_pay.Image"), System.Drawing.Image)
        Me.Numtime_costus_pay.Location = New System.Drawing.Point(491, 285)
        Me.Numtime_costus_pay.Maxlength = 2
        Me.Numtime_costus_pay.Name = "Numtime_costus_pay"
        Me.Numtime_costus_pay.Size = New System.Drawing.Size(55, 22)
        Me.Numtime_costus_pay.TabIndex = 5
        Me.Numtime_costus_pay.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numtime_costus_pay.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumCostus
        '
        Me.NumCostus.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCostus.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCostus.DecimalDigits = 2
        Me.NumCostus.DefaultSendValue = False
        Me.NumCostus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumCostus.Image = CType(resources.GetObject("NumCostus.Image"), System.Drawing.Image)
        Me.NumCostus.Location = New System.Drawing.Point(301, 285)
        Me.NumCostus.Maxlength = 10
        Me.NumCostus.Name = "NumCostus"
        Me.NumCostus.Size = New System.Drawing.Size(83, 22)
        Me.NumCostus.TabIndex = 4
        Me.NumCostus.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCostus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkActive
        '
        Me.ChkActive.BackColor = System.Drawing.SystemColors.Control
        Me.ChkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkActive.Location = New System.Drawing.Point(427, 261)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkActive.Size = New System.Drawing.Size(77, 16)
        Me.ChkActive.TabIndex = 2
        Me.ChkActive.Text = "Active"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(239, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Loan Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(11, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Loan Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(220, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Loan Payment"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(399, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "No of Payments"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.MAddNew.Text = "ÇíÌÇÏ"
        '
        'MEdit
        '
        Me.MEdit.Index = 1
        Me.MEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MEdit.Text = "ÇÕáÇÍ"
        '
        'MDelete
        '
        Me.MDelete.Index = 2
        Me.MDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MDelete.Text = "ÍÐÝ"
        '
        'MSave
        '
        Me.MSave.Enabled = False
        Me.MSave.Index = 3
        Me.MSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MSave.Text = "ËÈÊ"
        '
        'MCancel
        '
        Me.MCancel.Enabled = False
        Me.MCancel.Index = 4
        Me.MCancel.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MCancel.Text = "áÛæ"
        '
        'MFirstRecord
        '
        Me.MFirstRecord.Index = 5
        Me.MFirstRecord.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV
        Me.MFirstRecord.Text = "ÇÈÊÏÇ"
        '
        'MPreviousRecord
        '
        Me.MPreviousRecord.Index = 6
        Me.MPreviousRecord.Text = "ÞÈáí"
        '
        'MNextRecord
        '
        Me.MNextRecord.Index = 7
        Me.MNextRecord.Text = "ÈÚÏí"
        '
        'MLastRecord
        '
        Me.MLastRecord.Index = 8
        Me.MLastRecord.Text = "ÇäÊåÇ"
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO pay_loan_dtl (employee_code, loan_cod, date_start, amount_loan, costu" & _
        "s, time_costus_pay, active) VALUES (@employee_code, @loan_cod, @date_start, @amo" & _
        "unt_loan, @costus, @time_costus_pay, @active)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_cod", System.Data.SqlDbType.VarChar, 2, "loan_cod"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_loan", System.Data.SqlDbType.Money, 8, "amount_loan"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costus", System.Data.SqlDbType.Money, 8, "costus"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_costus_pay", System.Data.SqlDbType.SmallInt, 2, "time_costus_pay"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE pay_loan_dtl SET amount_loan = @amount_loan, costus = @costus, time_costus" & _
        "_pay = @time_costus_pay, active = @active, employee_code = @employee_code, loan_" & _
        "cod = @loan_cod, date_start = @date_start WHERE (id_deduction = @id_deduction)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_loan", System.Data.SqlDbType.Money, 8, "amount_loan"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@costus", System.Data.SqlDbType.Money, 8, "costus"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_costus_pay", System.Data.SqlDbType.SmallInt, 2, "time_costus_pay"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@loan_cod", System.Data.SqlDbType.VarChar, 2, "loan_cod"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM pay_loan_dtl WHERE (id_deduction = @id_deduction)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmEmployeeLoan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(593, 312)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkActive)
        Me.Controls.Add(Me.NumCostus)
        Me.Controls.Add(Me.Numtime_costus_pay)
        Me.Controls.Add(Me.NumAmount_loan)
        Me.Controls.Add(Me.DteDate_start)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmbloan_cod)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmEmployeeLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Loan"
        Me.Panel9.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEmployeeLoan1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEmployeeLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString

        Call FillDataSets()

        Call FillFields()
        Call AfterSaveOrCancel()
    End Sub
    Private Sub FillDataSets()
        DsFrmEmployeeLoan1.pay_tab_loan_main.Clear()
        DApay_tab_loan_main.Fill(DsFrmEmployeeLoan1, "pay_tab_loan_main")

        Call FillDApay_loan_dtl()
    End Sub
    Private Sub FillDApay_loan_dtl()
        DsFrmEmployeeLoan1.pay_loan_dtl.Clear()
        DApay_loan_dtl.SelectCommand.Parameters("@employee_code").Value = EmployeeCodVar
        DApay_loan_dtl.Fill(DsFrmEmployeeLoan1, "pay_loan_dtl")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        Call EnableField(True)
        Call ClearField()

        Cmbloan_cod.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PEdit()
        Status = MainModule.WorkStates.Edit

        EnableField(True)
        Cmbloan_cod.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PDelete()
        If DsFrmEmployeeLoan1.pay_loan_dtl.Rows.Count > 0 Then
            Dim Currentrow As GridEXRow = GrdDetail.GetRow
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                Try
                    If CmdDelete.Connection.State <> ConnectionState.Open Then
                        CmdDelete.Connection.Open()
                    End If
                    CmdDelete.Parameters("@Id_Deduction").Value = Currentrow.Cells(0).Value()
                    CmdDelete.ExecuteNonQuery()
                    Call FillDApay_loan_dtl()
                    Call FillFields()
                Catch ex As System.Data.SqlClient.SqlException
                    Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                    Call PubErrHandle(myErrors.Item(0).Number)
                Finally
                    CmdDelete.Connection.Close()
                End Try
                Call AfterSaveOrCancel()
            End If
            Status = MainModule.WorkStates._ReadOnly
        End If
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                ChangeOK = IIf(PInsert().Trim.Length = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate()
        End Select
        If ChangeOK Then
            Call FillDApay_loan_dtl()
            Call FillFields()
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Cmbloan_cod.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call FillFields()
        Call AfterSaveOrCancel()
        Cmbloan_cod.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If Cmbloan_cod.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False
            MDelete.Enabled = False
            BtnEdit.Enabled = False
            MEdit.Enabled = False
            MPreviousRecord.Enabled = False
            MNextRecord.Enabled = False
            MFirstRecord.Enabled = False
            MLastRecord.Enabled = False
        Else
            BtnDelete.Enabled = True
            MDelete.Enabled = True
            BtnEdit.Enabled = True
            MEdit.Enabled = True
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
    Private Sub TxtEmployeeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumAmount_loan.TextChanged, NumCostus.TextChanged, Numtime_costus_pay.TextChanged, Cmbloan_cod.SelectedIndexChanged, ChkActive.CheckedChanged, DteDate_start.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If Cmbloan_cod.Text.Trim.Length > 0 And NumAmount_loan.Text > 0 And Mid(DteDate_start.Text, 1, 4).Trim.Length > 0 Then
                BtnSave.Enabled = True
                MSave.Enabled = True
            Else
                BtnSave.Enabled = False
                MSave.Enabled = False
            End If
        End If
    End Sub
    Private Sub SetNoRecordFind()
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean)
        'If Status = MainModule.WorkStates.Edit Then
        '    Cmbloan_cod.Enabled = False
        '    DteDate_start.Enabled = False
        'Else
        '    Cmbloan_cod.Enabled = instatus
        '    DteDate_start.Enabled = instatus
        'End If
        Cmbloan_cod.Enabled = instatus
        DteDate_start.Enabled = instatus
        ChkActive.Enabled = instatus
        NumAmount_loan.Enabled = instatus
        NumCostus.Enabled = instatus
        Numtime_costus_pay.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        NumAmount_loan.Text = 0
        NumCostus.Text = 0
        Numtime_costus_pay.Text = 0
        DteDate_start.Text = ""
        ChkActive.Checked = True
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            With CmdInsert
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@employee_code").Value = EmployeeCodVar
                .Parameters("@loan_cod").Value = Cmbloan_cod.SelectedValue
                .Parameters("@date_start").Value = DteDate_start.Text
                .Parameters("@amount_loan").Value = NumAmount_loan.Text
                .Parameters("@costus").Value = NumCostus.Text
                .Parameters("@time_costus_pay").Value = Numtime_costus_pay.Text
                .Parameters("@active").Value = DecodeCheckBox(ChkActive.Checked)
                .ExecuteScalar()
                PInsert = Cmbloan_cod.SelectedValue
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate() As Boolean
        PUpdate = True
        Try
            Dim Currentrow As GridEXRow = GrdDetail.GetRow
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@Id_Deduction").Value = Currentrow.Cells(0).Value()
                .Parameters("@employee_code").Value = EmployeeCodVar
                .Parameters("@loan_cod").Value = Cmbloan_cod.SelectedValue
                .Parameters("@date_start").Value = DteDate_start.Text
                .Parameters("@amount_loan").Value = NumAmount_loan.Text
                .Parameters("@costus").Value = NumCostus.Text
                .Parameters("@time_costus_pay").Value = Numtime_costus_pay.Text
                .Parameters("@active").Value = DecodeCheckBox(ChkActive.Checked)
                .ExecuteScalar()
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(Optional ByVal FirstRecord As Boolean = False) As Boolean
        FillFields = False
        Try
            If FirstRecord Then
                Cmbloan_cod.SelectedValue = DsFrmEmployeeLoan1.pay_loan_dtl.Rows(0).Item("loan_cod")
                NumAmount_loan.Text = DsFrmEmployeeLoan1.pay_loan_dtl.Rows(0).Item("Amount_loan")
                NumCostus.Text = DsFrmEmployeeLoan1.pay_loan_dtl.Rows(0).Item("Costus")
                Numtime_costus_pay.Text = DsFrmEmployeeLoan1.pay_loan_dtl.Rows(0).Item("time_costus_pay")
                DteDate_start.Text = DsFrmEmployeeLoan1.pay_loan_dtl.Rows(0).Item("Date_start")
                ChkActive.Checked = DsFrmEmployeeLoan1.pay_loan_dtl.Rows(0).Item("Active")
                FillFields = True
            Else
                Dim Currentrow As GridEXRow = GrdDetail.GetRow
                Cmbloan_cod.SelectedValue = Currentrow.Cells("loan_cod").Value() & ""
                NumAmount_loan.Text = Currentrow.Cells("Amount_loan").Value()
                NumCostus.Text = Currentrow.Cells("Costus").Value()
                Numtime_costus_pay.Text = Currentrow.Cells("time_costus_pay").Value()
                DteDate_start.Text = Currentrow.Cells("Date_start").Value() & ""
                ChkActive.Checked = Currentrow.Cells("Active").Value()
                FillFields = True
            End If
        Catch ex As Exception
            Call ClearField()
        End Try
    End Function
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
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Call FillFields()
    End Sub
End Class
