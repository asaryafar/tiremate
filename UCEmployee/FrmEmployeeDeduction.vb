Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEmployeeDeduction
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_deduction_employee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAemployee_deduction As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEmployeeDeduction1 As UCEmployee.DSFrmEmployeeDeduction
    Friend WithEvents Cmbdeduction_cod As System.Windows.Forms.ComboBox
    Friend WithEvents Dtefrom_date_deduction As CalendarCombo.CalendarCombo
    Friend WithEvents Numamount_deduction As CalcUtils.UcCalcText
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dteto_date_deduction As CalendarCombo.CalendarCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployeeDeduction))
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
        Me.DsFrmEmployeeDeduction1 = New UCEmployee.DSFrmEmployeeDeduction
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Cmbdeduction_cod = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Dtefrom_date_deduction = New CalendarCombo.CalendarCombo
        Me.Numamount_deduction = New CalcUtils.UcCalcText
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DApay_deduction_employee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAemployee_deduction = New System.Data.SqlClient.SqlDataAdapter
        Me.Label4 = New System.Windows.Forms.Label
        Me.Dteto_date_deduction = New CalendarCombo.CalendarCombo
        Me.Panel9.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEmployeeDeduction1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GrdDetail.DataMember = "pay_deduction_employee"
        Me.GrdDetail.DataSource = Me.DsFrmEmployeeDeduction1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>pay_deduction_employee</Caption><Columns Co" & _
        "llection=""true""><Column0 ID=""id_deduction""><Caption>id_deduction</Caption><TypeN" & _
        "ameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>id_deduction</DataMember><EditType>NoEdit</EditType><Key>id_deduction</Key><P" & _
        "osition>0</Position><Visible>False</Visible></Column0><Column1 ID=""deduction_cod" & _
        """><Caption>Code</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyS" & _
        "tringValue><EmptyStringValue /><DataMember>deduction_cod</DataMember><Key>deduct" & _
        "ion_cod</Key><Position>1</Position><Width>56</Width></Column1><Column2 ID=""deduc" & _
        "tion_desc""><Caption>Desc</Caption><DataMember>deduction_desc</DataMember><Key>de" & _
        "duction_desc</Key><Position>2</Position><Width>168</Width></Column2><Column3 ID=" & _
        """from_date_deduction""><Caption>From Date</Caption><TypeNameEmptyStringValue>Syst" & _
        "em.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>from_date_de" & _
        "duction</DataMember><Key>from_date_deduction</Key><Position>3</Position><Width>8" & _
        "3</Width></Column3><Column4 ID=""to_date_deduction""><Caption>To Date</Caption><Ty" & _
        "peNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue" & _
        " /><DataMember>to_date_deduction</DataMember><Key>to_date_deduction</Key><Positi" & _
        "on>4</Position><Width>83</Width></Column4><Column5 ID=""amount_deduction""><Captio" & _
        "n>Amount</Caption><DataMember>amount_deduction</DataMember><FormatString>c</Form" & _
        "atString><Key>amount_deduction</Key><Position>5</Position><TextAlignment>Far</Te" & _
        "xtAlignment><Width>97</Width></Column5><Column6 ID=""active""><Caption>Active</Cap" & _
        "tion><ColumnType>CheckBox</ColumnType><DataMember>active</DataMember><EditType>C" & _
        "heckBox</EditType><Key>active</Key><Position>6</Position><Width>44</Width></Colu" & _
        "mn6></Columns><GroupCondition ID="""" /><Key>pay_deduction_employee</Key></RootTab" & _
        "le></GridEXLayoutData>"
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
        'DsFrmEmployeeDeduction1
        '
        Me.DsFrmEmployeeDeduction1.DataSetName = "DSFrmEmployeeDeduction"
        Me.DsFrmEmployeeDeduction1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'Cmbdeduction_cod
        '
        Me.Cmbdeduction_cod.DataSource = Me.DsFrmEmployeeDeduction1.employee_deduction
        Me.Cmbdeduction_cod.DisplayMember = "deduction_desc"
        Me.Cmbdeduction_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdeduction_cod.Location = New System.Drawing.Point(106, 258)
        Me.Cmbdeduction_cod.Name = "Cmbdeduction_cod"
        Me.Cmbdeduction_cod.Size = New System.Drawing.Size(158, 21)
        Me.Cmbdeduction_cod.TabIndex = 0
        Me.Cmbdeduction_cod.ValueMember = "deduction_cod"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Deduction Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dtefrom_date_deduction
        '
        Me.Dtefrom_date_deduction.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtefrom_date_deduction.BorderColor = System.Drawing.Color.Empty
        Me.Dtefrom_date_deduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtefrom_date_deduction.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtefrom_date_deduction.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtefrom_date_deduction.EditableSal = True
        Me.Dtefrom_date_deduction.Image = CType(resources.GetObject("Dtefrom_date_deduction.Image"), System.Drawing.Image)
        Me.Dtefrom_date_deduction.Location = New System.Drawing.Point(333, 259)
        Me.Dtefrom_date_deduction.MaxValue = CType(2500, Short)
        Me.Dtefrom_date_deduction.MinValue = CType(1800, Short)
        Me.Dtefrom_date_deduction.Name = "Dtefrom_date_deduction"
        Me.Dtefrom_date_deduction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtefrom_date_deduction.Sal_Mali = Nothing
        Me.Dtefrom_date_deduction.ShowButton = True
        Me.Dtefrom_date_deduction.Size = New System.Drawing.Size(104, 23)
        Me.Dtefrom_date_deduction.TabIndex = 1
        Me.Dtefrom_date_deduction.VisualStyle = False
        '
        'Numamount_deduction
        '
        Me.Numamount_deduction.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numamount_deduction.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numamount_deduction.DecimalDigits = 2
        Me.Numamount_deduction.DefaultSendValue = False
        Me.Numamount_deduction.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numamount_deduction.Image = CType(resources.GetObject("Numamount_deduction.Image"), System.Drawing.Image)
        Me.Numamount_deduction.Location = New System.Drawing.Point(106, 285)
        Me.Numamount_deduction.Maxlength = 10
        Me.Numamount_deduction.Name = "Numamount_deduction"
        Me.Numamount_deduction.Size = New System.Drawing.Size(83, 22)
        Me.Numamount_deduction.TabIndex = 3
        Me.Numamount_deduction.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numamount_deduction.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkActive
        '
        Me.ChkActive.BackColor = System.Drawing.SystemColors.Control
        Me.ChkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkActive.Location = New System.Drawing.Point(479, 263)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkActive.Size = New System.Drawing.Size(77, 16)
        Me.ChkActive.TabIndex = 2
        Me.ChkActive.Text = "Active"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(271, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Start Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(9, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.CmdInsert.CommandText = "INSERT INTO pay_deduction_employee (employee_code, deduction_cod, from_date_deduc" & _
        "tion, to_date_deduction, amount_deduction, active) VALUES (@employee_code, @dedu" & _
        "ction_cod, @from_date_deduction, @to_date_deduction, @amount_deduction, @active)" & _
        ""
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@from_date_deduction", System.Data.SqlDbType.VarChar, 10, "from_date_deduction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@to_date_deduction", System.Data.SqlDbType.VarChar, 10, "to_date_deduction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_deduction", System.Data.SqlDbType.Money, 8, "amount_deduction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE pay_deduction_employee SET employee_code = @employee_code, deduction_cod =" & _
        " @deduction_cod, from_date_deduction = @from_date_deduction, to_date_deduction =" & _
        " @to_date_deduction, amount_deduction = @amount_deduction, active = @active WHER" & _
        "E (id_deduction = @id_deduction)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@from_date_deduction", System.Data.SqlDbType.VarChar, 10, "from_date_deduction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@to_date_deduction", System.Data.SqlDbType.VarChar, 10, "to_date_deduction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_deduction", System.Data.SqlDbType.Money, 8, "amount_deduction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM pay_deduction_employee WHERE (id_deduction = @id_deduction)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pay_deduction_employee.id_deduction, pay_deduction_employee.deduction_cod," & _
        " pay_deduction_employee.from_date_deduction, pay_deduction_employee.to_date_dedu" & _
        "ction, pay_deduction_employee.amount_deduction, pay_deduction_employee.active, e" & _
        "mployee_deduction.deduction_desc FROM pay_deduction_employee INNER JOIN employee" & _
        "_deduction ON pay_deduction_employee.deduction_cod = employee_deduction.deductio" & _
        "n_cod WHERE (pay_deduction_employee.employee_code = @employee_code)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO pay_deduction_employee(employee_code, deduction_cod, from_date_deduct" & _
        "ion, to_date_deduction, amount_deduction, active) VALUES (@employee_code, @deduc" & _
        "tion_cod, @from_date_deduction, @to_date_deduction, @amount_deduction, @active);" & _
        " SELECT id_deduction, employee_code, deduction_cod, from_date_deduction, to_date" & _
        "_deduction, amount_deduction, active FROM pay_deduction_employee WHERE (id_deduc" & _
        "tion = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@from_date_deduction", System.Data.SqlDbType.VarChar, 10, "from_date_deduction"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@to_date_deduction", System.Data.SqlDbType.VarChar, 10, "to_date_deduction"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_deduction", System.Data.SqlDbType.Money, 8, "amount_deduction"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE pay_deduction_employee SET employee_code = @employee_code, deduction_cod =" & _
        " @deduction_cod, from_date_deduction = @from_date_deduction, to_date_deduction =" & _
        " @to_date_deduction, amount_deduction = @amount_deduction, active = @active WHER" & _
        "E (id_deduction = @Original_id_deduction) AND (active = @Original_active OR @Ori" & _
        "ginal_active IS NULL AND active IS NULL) AND (amount_deduction = @Original_amoun" & _
        "t_deduction OR @Original_amount_deduction IS NULL AND amount_deduction IS NULL) " & _
        "AND (deduction_cod = @Original_deduction_cod) AND (employee_code = @Original_emp" & _
        "loyee_code) AND (from_date_deduction = @Original_from_date_deduction) AND (to_da" & _
        "te_deduction = @Original_to_date_deduction); SELECT id_deduction, employee_code," & _
        " deduction_cod, from_date_deduction, to_date_deduction, amount_deduction, active" & _
        " FROM pay_deduction_employee WHERE (id_deduction = @id_deduction)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@from_date_deduction", System.Data.SqlDbType.VarChar, 10, "from_date_deduction"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@to_date_deduction", System.Data.SqlDbType.VarChar, 10, "to_date_deduction"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_deduction", System.Data.SqlDbType.Money, 8, "amount_deduction"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_deduction", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_deduction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_from_date_deduction", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "from_date_deduction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_to_date_deduction", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "to_date_deduction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_deduction", System.Data.SqlDbType.Int, 4, "id_deduction"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM pay_deduction_employee WHERE (id_deduction = @Original_id_deduction) " & _
        "AND (active = @Original_active OR @Original_active IS NULL AND active IS NULL) A" & _
        "ND (amount_deduction = @Original_amount_deduction OR @Original_amount_deduction " & _
        "IS NULL AND amount_deduction IS NULL) AND (deduction_cod = @Original_deduction_c" & _
        "od) AND (employee_code = @Original_employee_code) AND (from_date_deduction = @Or" & _
        "iginal_from_date_deduction) AND (to_date_deduction = @Original_to_date_deduction" & _
        ")"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_deduction", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_deduction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_from_date_deduction", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "from_date_deduction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_to_date_deduction", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "to_date_deduction", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_deduction_employee
        '
        Me.DApay_deduction_employee.DeleteCommand = Me.SqlDeleteCommand1
        Me.DApay_deduction_employee.InsertCommand = Me.SqlInsertCommand1
        Me.DApay_deduction_employee.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_deduction_employee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_deduction_employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_deduction", "id_deduction"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("deduction_cod", "deduction_cod"), New System.Data.Common.DataColumnMapping("from_date_deduction", "from_date_deduction"), New System.Data.Common.DataColumnMapping("to_date_deduction", "to_date_deduction"), New System.Data.Common.DataColumnMapping("amount_deduction", "amount_deduction"), New System.Data.Common.DataColumnMapping("active", "active")})})
        Me.DApay_deduction_employee.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT deduction_cod, deduction_desc, defult_deduction_amount, befor_tax, GL_acco" & _
        "unt, percent_gross_pay FROM employee_deduction"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO employee_deduction(deduction_cod, deduction_desc, defult_deduction_am" & _
        "ount, befor_tax, GL_account, percent_gross_pay) VALUES (@deduction_cod, @deducti" & _
        "on_desc, @defult_deduction_amount, @befor_tax, @GL_account, @percent_gross_pay);" & _
        " SELECT deduction_cod, deduction_desc, defult_deduction_amount, befor_tax, GL_ac" & _
        "count, percent_gross_pay FROM employee_deduction WHERE (deduction_cod = @deducti" & _
        "on_cod)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_desc", System.Data.SqlDbType.VarChar, 50, "deduction_desc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@defult_deduction_amount", System.Data.SqlDbType.Money, 8, "defult_deduction_amount"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@befor_tax", System.Data.SqlDbType.Bit, 1, "befor_tax"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_gross_pay", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE employee_deduction SET deduction_cod = @deduction_cod, deduction_desc = @d" & _
        "eduction_desc, defult_deduction_amount = @defult_deduction_amount, befor_tax = @" & _
        "befor_tax, GL_account = @GL_account, percent_gross_pay = @percent_gross_pay WHER" & _
        "E (deduction_cod = @Original_deduction_cod) AND (GL_account = @Original_GL_accou" & _
        "nt OR @Original_GL_account IS NULL AND GL_account IS NULL) AND (befor_tax = @Ori" & _
        "ginal_befor_tax OR @Original_befor_tax IS NULL AND befor_tax IS NULL) AND (deduc" & _
        "tion_desc = @Original_deduction_desc OR @Original_deduction_desc IS NULL AND ded" & _
        "uction_desc IS NULL) AND (defult_deduction_amount = @Original_defult_deduction_a" & _
        "mount OR @Original_defult_deduction_amount IS NULL AND defult_deduction_amount I" & _
        "S NULL) AND (percent_gross_pay = @Original_percent_gross_pay OR @Original_percen" & _
        "t_gross_pay IS NULL AND percent_gross_pay IS NULL); SELECT deduction_cod, deduct" & _
        "ion_desc, defult_deduction_amount, befor_tax, GL_account, percent_gross_pay FROM" & _
        " employee_deduction WHERE (deduction_cod = @deduction_cod)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_desc", System.Data.SqlDbType.VarChar, 50, "deduction_desc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@defult_deduction_amount", System.Data.SqlDbType.Money, 8, "defult_deduction_amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@befor_tax", System.Data.SqlDbType.Bit, 1, "befor_tax"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_gross_pay", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_befor_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "befor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_defult_deduction_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "defult_deduction_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_gross_pay", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM employee_deduction WHERE (deduction_cod = @Original_deduction_cod) AN" & _
        "D (GL_account = @Original_GL_account OR @Original_GL_account IS NULL AND GL_acco" & _
        "unt IS NULL) AND (befor_tax = @Original_befor_tax OR @Original_befor_tax IS NULL" & _
        " AND befor_tax IS NULL) AND (deduction_desc = @Original_deduction_desc OR @Origi" & _
        "nal_deduction_desc IS NULL AND deduction_desc IS NULL) AND (defult_deduction_amo" & _
        "unt = @Original_defult_deduction_amount OR @Original_defult_deduction_amount IS " & _
        "NULL AND defult_deduction_amount IS NULL) AND (percent_gross_pay = @Original_per" & _
        "cent_gross_pay OR @Original_percent_gross_pay IS NULL AND percent_gross_pay IS N" & _
        "ULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_befor_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "befor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_defult_deduction_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "defult_deduction_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_gross_pay", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAemployee_deduction
        '
        Me.DAemployee_deduction.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAemployee_deduction.InsertCommand = Me.SqlInsertCommand2
        Me.DAemployee_deduction.SelectCommand = Me.SqlSelectCommand2
        Me.DAemployee_deduction.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee_deduction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("deduction_cod", "deduction_cod"), New System.Data.Common.DataColumnMapping("deduction_desc", "deduction_desc"), New System.Data.Common.DataColumnMapping("defult_deduction_amount", "defult_deduction_amount"), New System.Data.Common.DataColumnMapping("befor_tax", "befor_tax"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("percent_gross_pay", "percent_gross_pay")})})
        Me.DAemployee_deduction.UpdateCommand = Me.SqlUpdateCommand2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(272, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dteto_date_deduction
        '
        Me.Dteto_date_deduction.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dteto_date_deduction.BorderColor = System.Drawing.Color.Empty
        Me.Dteto_date_deduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dteto_date_deduction.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dteto_date_deduction.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dteto_date_deduction.EditableSal = True
        Me.Dteto_date_deduction.Image = CType(resources.GetObject("Dteto_date_deduction.Image"), System.Drawing.Image)
        Me.Dteto_date_deduction.Location = New System.Drawing.Point(334, 286)
        Me.Dteto_date_deduction.MaxValue = CType(2500, Short)
        Me.Dteto_date_deduction.MinValue = CType(1800, Short)
        Me.Dteto_date_deduction.Name = "Dteto_date_deduction"
        Me.Dteto_date_deduction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dteto_date_deduction.Sal_Mali = Nothing
        Me.Dteto_date_deduction.ShowButton = True
        Me.Dteto_date_deduction.Size = New System.Drawing.Size(104, 23)
        Me.Dteto_date_deduction.TabIndex = 4
        Me.Dteto_date_deduction.VisualStyle = False
        '
        'FrmEmployeeDeduction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(593, 312)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Dteto_date_deduction)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkActive)
        Me.Controls.Add(Me.Numamount_deduction)
        Me.Controls.Add(Me.Dtefrom_date_deduction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmbdeduction_cod)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmEmployeeDeduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Deduction"
        Me.Panel9.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEmployeeDeduction1, System.ComponentModel.ISupportInitialize).EndInit()
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
        DsFrmEmployeeDeduction1.employee_deduction.Clear()
        DAemployee_deduction.Fill(DsFrmEmployeeDeduction1, "employee_deduction")

        Call FillDApay_deduction_employee()
    End Sub
    Private Sub FillDApay_deduction_employee()
        DsFrmEmployeeDeduction1.pay_deduction_employee.Clear()
        DApay_deduction_employee.SelectCommand.Parameters("@employee_code").Value = EmployeeCodVar
        DApay_deduction_employee.Fill(DsFrmEmployeeDeduction1, "pay_deduction_employee")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        Call EnableField(True)
        Call ClearField()

        Cmbdeduction_cod.Focus()

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
        Cmbdeduction_cod.Focus()

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
        If DsFrmEmployeeDeduction1.pay_deduction_employee.Rows.Count > 0 Then
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                Try
                    Dim Currentrow As GridEXRow = GrdDetail.GetRow
                    If CmdDelete.Connection.State <> ConnectionState.Open Then
                        CmdDelete.Connection.Open()
                    End If
                    CmdDelete.Parameters("@id_deduction").Value = Currentrow.Cells("id_deduction").Value()
                    CmdDelete.ExecuteNonQuery()
                    Call FillDApay_deduction_employee()
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
            Call FillDApay_deduction_employee()
            Call FillFields()
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Cmbdeduction_cod.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call FillFields()
        Call AfterSaveOrCancel()
        Cmbdeduction_cod.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If Cmbdeduction_cod.Text.Trim.Length = 0 Then
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
    Private Sub TxtEmployeeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkActive.CheckedChanged, Cmbdeduction_cod.SelectedIndexChanged, Dtefrom_date_deduction.TextChanged, Dteto_date_deduction.TextChanged, Numamount_deduction.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If Cmbdeduction_cod.Text.Trim.Length > 0 And Numamount_deduction.Text > 0 And Mid(Dtefrom_date_deduction.Text, 1, 4).Trim.Length > 0 Then
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
        Cmbdeduction_cod.Enabled = instatus
        Dtefrom_date_deduction.Enabled = instatus
        Dteto_date_deduction.Enabled = instatus
        ChkActive.Enabled = instatus
        Numamount_deduction.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        Numamount_deduction.Text = 0
        Dtefrom_date_deduction.Text = ""
        Dteto_date_deduction.Text = ""
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
                .Parameters("@deduction_cod").Value = Cmbdeduction_cod.SelectedValue
                .Parameters("@from_date_deduction").Value = Dtefrom_date_deduction.Text
                .Parameters("@to_date_deduction").Value = Dteto_date_deduction.Text
                .Parameters("@amount_deduction").Value = Numamount_deduction.Text
                .Parameters("@active").Value = DecodeCheckBox(ChkActive.Checked)
                .ExecuteScalar()
                PInsert = Cmbdeduction_cod.SelectedValue
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
        Dim Currentrow As GridEXRow = GrdDetail.GetRow
        Try
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@id_deduction").Value = Currentrow.Cells("id_deduction").Value()
                .Parameters("@employee_code").Value = EmployeeCodVar
                .Parameters("@deduction_cod").Value = Cmbdeduction_cod.SelectedValue
                .Parameters("@from_date_deduction").Value = Dtefrom_date_deduction.Text
                .Parameters("@to_date_deduction").Value = Dteto_date_deduction.Text
                .Parameters("@amount_deduction").Value = Numamount_deduction.Text
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
                Cmbdeduction_cod.SelectedValue = DsFrmEmployeeDeduction1.pay_deduction_employee.Rows(0).Item("deduction_cod") & ""
                Numamount_deduction.Text = DsFrmEmployeeDeduction1.pay_deduction_employee.Rows(0).Item("amount_deduction")
                Dtefrom_date_deduction.Text = DsFrmEmployeeDeduction1.pay_deduction_employee.Rows(0).Item("from_date_deduction") & ""
                Dteto_date_deduction.Text = DsFrmEmployeeDeduction1.pay_deduction_employee.Rows(0).Item("To_date_deduction") & ""
                ChkActive.Checked = DsFrmEmployeeDeduction1.pay_deduction_employee.Rows(0).Item("Active")
                FillFields = True
            Else
                Dim Currentrow As GridEXRow = GrdDetail.GetRow
                Cmbdeduction_cod.SelectedValue = Currentrow.Cells("deduction_cod").Value() & ""
                Numamount_deduction.Text = Currentrow.Cells("amount_deduction").Value()
                Dtefrom_date_deduction.Text = Currentrow.Cells("from_date_deduction").Value() & ""
                Dteto_date_deduction.Text = Currentrow.Cells("To_date_deduction").Value() & ""
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
