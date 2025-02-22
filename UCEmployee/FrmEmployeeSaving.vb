Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEmployeeSaving
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DteDate_start As CalendarCombo.CalendarCombo
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
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_saving_main As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_saving_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEmployeeSaving1 As UCEmployee.DSFrmEmployeeSaving
    Friend WithEvents Cmbsaving_cod As System.Windows.Forms.ComboBox
    Friend WithEvents NumAmount_employee As CalcUtils.UcCalcText
    Friend WithEvents Numtime_saving_removal As CalcUtils.UcCalcText
    Friend WithEvents NumAmount_employer As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployeeSaving))
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
        Me.DsFrmEmployeeSaving1 = New UCEmployee.DSFrmEmployeeSaving
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Cmbsaving_cod = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DteDate_start = New CalendarCombo.CalendarCombo
        Me.NumAmount_employee = New CalcUtils.UcCalcText
        Me.Numtime_saving_removal = New CalcUtils.UcCalcText
        Me.NumAmount_employer = New CalcUtils.UcCalcText
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
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_saving_main = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DApay_saving_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel9.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEmployeeSaving1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GrdDetail.DataMember = "pay_saving_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmEmployeeSaving1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>pay_saving_dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""id_deduction""><Caption>id_deduction</Caption><DataMember>id" & _
        "_deduction</DataMember><Key>id_deduction</Key><Position>0</Position><Visible>Fal" & _
        "se</Visible></Column0><Column1 ID=""saving_cod""><Caption>Saving Code</Caption><Ty" & _
        "peNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue" & _
        " /><DataMember>saving_cod</DataMember><Key>saving_cod</Key><Position>1</Position" & _
        "><Width>76</Width></Column1><Column2 ID=""saving_desc""><Caption>Saving Desc</Capt" & _
        "ion><DataMember>saving_desc</DataMember><Key>saving_desc</Key><Position>2</Posit" & _
        "ion><Width>135</Width></Column2><Column3 ID=""date_start""><Caption>Start Date</Ca" & _
        "ption><DataMember>date_start</DataMember><Key>date_start</Key><Position>3</Posit" & _
        "ion><Width>77</Width></Column3><Column4 ID=""amount_employee""><Caption>Employee</" & _
        "Caption><DataMember>amount_employee</DataMember><FormatString>c</FormatString><K" & _
        "ey>amount_employee</Key><Position>4</Position><TextAlignment>Far</TextAlignment>" & _
        "<Width>77</Width></Column4><Column5 ID=""amount_employer""><Caption>Employer</Capt" & _
        "ion><DataMember>amount_employer</DataMember><FormatString>c</FormatString><Key>a" & _
        "mount_employer</Key><Position>5</Position><TextAlignment>Far</TextAlignment><Wid" & _
        "th>78</Width></Column5><Column6 ID=""time_saving_removal""><Caption>T S R</Caption" & _
        "><DataMember>time_saving_removal</DataMember><FormatString>c</FormatString><Key>" & _
        "time_saving_removal</Key><Position>6</Position><TextAlignment>Far</TextAlignment" & _
        "><Width>58</Width></Column6><Column7 ID=""active""><Caption>Active</Caption><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>active</DataMember><EditType>CheckBox</Ed" & _
        "itType><Key>active</Key><Position>7</Position><Width>41</Width></Column7></Colum" & _
        "ns><GroupCondition ID="""" /><Key>pay_saving_dtl</Key></RootTable></GridEXLayoutDa" & _
        "ta>"
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
        'DsFrmEmployeeSaving1
        '
        Me.DsFrmEmployeeSaving1.DataSetName = "DSFrmEmployeeSaving"
        Me.DsFrmEmployeeSaving1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'Cmbsaving_cod
        '
        Me.Cmbsaving_cod.DataSource = Me.DsFrmEmployeeSaving1.pay_tab_saving_main
        Me.Cmbsaving_cod.DisplayMember = "saving_desc"
        Me.Cmbsaving_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbsaving_cod.Location = New System.Drawing.Point(106, 258)
        Me.Cmbsaving_cod.Name = "Cmbsaving_cod"
        Me.Cmbsaving_cod.Size = New System.Drawing.Size(131, 21)
        Me.Cmbsaving_cod.TabIndex = 0
        Me.Cmbsaving_cod.ValueMember = "saving_cod"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(26, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Saving Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DteDate_start
        '
        Me.DteDate_start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_start.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_start.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_start.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_start.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_start.EditableSal = True
        Me.DteDate_start.Image = CType(resources.GetObject("DteDate_start.Image"), System.Drawing.Image)
        Me.DteDate_start.Location = New System.Drawing.Point(301, 259)
        Me.DteDate_start.MaxValue = CType(2500, Short)
        Me.DteDate_start.MinValue = CType(1800, Short)
        Me.DteDate_start.Name = "DteDate_start"
        Me.DteDate_start.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_start.Sal_Mali = Nothing
        Me.DteDate_start.ShowButton = True
        Me.DteDate_start.Size = New System.Drawing.Size(104, 23)
        Me.DteDate_start.TabIndex = 1
        Me.DteDate_start.VisualStyle = False
        '
        'NumAmount_employee
        '
        Me.NumAmount_employee.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount_employee.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmount_employee.DecimalDigits = 2
        Me.NumAmount_employee.DefaultSendValue = False
        Me.NumAmount_employee.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmount_employee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumAmount_employee.Image = CType(resources.GetObject("NumAmount_employee.Image"), System.Drawing.Image)
        Me.NumAmount_employee.Location = New System.Drawing.Point(106, 285)
        Me.NumAmount_employee.Maxlength = 10
        Me.NumAmount_employee.MinusColor = System.Drawing.Color.Empty
        Me.NumAmount_employee.Name = "NumAmount_employee"
        Me.NumAmount_employee.Size = New System.Drawing.Size(83, 22)
        Me.NumAmount_employee.TabIndex = 3
        Me.NumAmount_employee.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmount_employee.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numtime_saving_removal
        '
        Me.Numtime_saving_removal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numtime_saving_removal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numtime_saving_removal.DecimalDigits = 2
        Me.Numtime_saving_removal.DefaultSendValue = False
        Me.Numtime_saving_removal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numtime_saving_removal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numtime_saving_removal.Image = CType(resources.GetObject("Numtime_saving_removal.Image"), System.Drawing.Image)
        Me.Numtime_saving_removal.Location = New System.Drawing.Point(504, 285)
        Me.Numtime_saving_removal.Maxlength = 10
        Me.Numtime_saving_removal.MinusColor = System.Drawing.Color.Empty
        Me.Numtime_saving_removal.Name = "Numtime_saving_removal"
        Me.Numtime_saving_removal.Size = New System.Drawing.Size(83, 22)
        Me.Numtime_saving_removal.TabIndex = 5
        Me.Numtime_saving_removal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numtime_saving_removal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumAmount_employer
        '
        Me.NumAmount_employer.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount_employer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmount_employer.DecimalDigits = 2
        Me.NumAmount_employer.DefaultSendValue = False
        Me.NumAmount_employer.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmount_employer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumAmount_employer.Image = CType(resources.GetObject("NumAmount_employer.Image"), System.Drawing.Image)
        Me.NumAmount_employer.Location = New System.Drawing.Point(301, 285)
        Me.NumAmount_employer.Maxlength = 10
        Me.NumAmount_employer.MinusColor = System.Drawing.Color.Empty
        Me.NumAmount_employer.Name = "NumAmount_employer"
        Me.NumAmount_employer.Size = New System.Drawing.Size(83, 22)
        Me.NumAmount_employer.TabIndex = 4
        Me.NumAmount_employer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmount_employer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkActive
        '
        Me.ChkActive.BackColor = System.Drawing.SystemColors.Control
        Me.ChkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkActive.Location = New System.Drawing.Point(440, 261)
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
        Me.Label2.Location = New System.Drawing.Point(235, 260)
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
        Me.Label3.Location = New System.Drawing.Point(4, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(195, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Employer Amount"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(393, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "time saving removal"
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
        Me.CmdInsert.CommandText = "INSERT INTO pay_saving_dtl (employee_code, saving_cod, date_start, amount_employe" & _
        "e, amount_employer, time_saving_removal, active) VALUES (@employee_code, @saving" & _
        "_cod, @date_start, @amount_employee, @amount_employer, @time_saving_removal, @ac" & _
        "tive)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_cod", System.Data.SqlDbType.VarChar, 2, "saving_cod"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employee", System.Data.SqlDbType.Money, 8, "amount_employee"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employer", System.Data.SqlDbType.Money, 8, "amount_employer"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_saving_removal", System.Data.SqlDbType.Money, 8, "time_saving_removal"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE pay_saving_dtl SET date_start = @date_start, amount_employee = @amount_emp" & _
        "loyee, amount_employer = @amount_employer, time_saving_removal = @time_saving_re" & _
        "moval, active = @active, employee_code = @employee_code, saving_cod = @saving_co" & _
        "d WHERE (id_deduction = @Id_Deduction)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employee", System.Data.SqlDbType.Money, 8, "amount_employee"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employer", System.Data.SqlDbType.Money, 8, "amount_employer"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_saving_removal", System.Data.SqlDbType.Money, 8, "time_saving_removal"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_cod", System.Data.SqlDbType.VarChar, 2, "saving_cod"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM pay_saving_dtl WHERE (id_deduction = @Id_Deduction)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Deduction", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_deduction", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT saving_cod, saving_desc, remark, GL_account_employee, GL_account_employer," & _
        " before_tax, percent_gross_pay_employee, percent_gross_pay_employer FROM pay_tab" & _
        "_saving_main"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO pay_tab_saving_main(saving_cod, saving_desc, remark, GL_account_emplo" & _
        "yee, GL_account_employer, before_tax, percent_gross_pay_employee, percent_gross_" & _
        "pay_employer) VALUES (@saving_cod, @saving_desc, @remark, @GL_account_employee, " & _
        "@GL_account_employer, @before_tax, @percent_gross_pay_employee, @percent_gross_p" & _
        "ay_employer); SELECT saving_cod, saving_desc, remark, GL_account_employee, GL_ac" & _
        "count_employer, before_tax, percent_gross_pay_employee, percent_gross_pay_employ" & _
        "er FROM pay_tab_saving_main WHERE (saving_cod = @saving_cod)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_cod", System.Data.SqlDbType.VarChar, 2, "saving_cod"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_desc", System.Data.SqlDbType.VarChar, 50, "saving_desc"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 200, "remark"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_employee", System.Data.SqlDbType.VarChar, 10, "GL_account_employee"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_employer", System.Data.SqlDbType.VarChar, 10, "GL_account_employer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@before_tax", System.Data.SqlDbType.Bit, 1, "before_tax"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_gross_pay_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_gross_pay_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employer", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE pay_tab_saving_main SET saving_cod = @saving_cod, saving_desc = @saving_de" & _
        "sc, remark = @remark, GL_account_employee = @GL_account_employee, GL_account_emp" & _
        "loyer = @GL_account_employer, before_tax = @before_tax, percent_gross_pay_employ" & _
        "ee = @percent_gross_pay_employee, percent_gross_pay_employer = @percent_gross_pa" & _
        "y_employer WHERE (saving_cod = @Original_saving_cod) AND (GL_account_employee = " & _
        "@Original_GL_account_employee OR @Original_GL_account_employee IS NULL AND GL_ac" & _
        "count_employee IS NULL) AND (GL_account_employer = @Original_GL_account_employer" & _
        " OR @Original_GL_account_employer IS NULL AND GL_account_employer IS NULL) AND (" & _
        "before_tax = @Original_before_tax OR @Original_before_tax IS NULL AND before_tax" & _
        " IS NULL) AND (percent_gross_pay_employee = @Original_percent_gross_pay_employee" & _
        " OR @Original_percent_gross_pay_employee IS NULL AND percent_gross_pay_employee " & _
        "IS NULL) AND (percent_gross_pay_employer = @Original_percent_gross_pay_employer " & _
        "OR @Original_percent_gross_pay_employer IS NULL AND percent_gross_pay_employer I" & _
        "S NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AND remark IS" & _
        " NULL) AND (saving_desc = @Original_saving_desc OR @Original_saving_desc IS NULL" & _
        " AND saving_desc IS NULL); SELECT saving_cod, saving_desc, remark, GL_account_em" & _
        "ployee, GL_account_employer, before_tax, percent_gross_pay_employee, percent_gro" & _
        "ss_pay_employer FROM pay_tab_saving_main WHERE (saving_cod = @saving_cod)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_cod", System.Data.SqlDbType.VarChar, 2, "saving_cod"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_desc", System.Data.SqlDbType.VarChar, 50, "saving_desc"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 200, "remark"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_employee", System.Data.SqlDbType.VarChar, 10, "GL_account_employee"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_employer", System.Data.SqlDbType.VarChar, 10, "GL_account_employer"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@before_tax", System.Data.SqlDbType.Bit, 1, "before_tax"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_gross_pay_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_gross_pay_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employer", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_saving_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saving_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_employee", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_employer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_before_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "before_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_gross_pay_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_gross_pay_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_saving_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saving_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM pay_tab_saving_main WHERE (saving_cod = @Original_saving_cod) AND (GL" & _
        "_account_employee = @Original_GL_account_employee OR @Original_GL_account_employ" & _
        "ee IS NULL AND GL_account_employee IS NULL) AND (GL_account_employer = @Original" & _
        "_GL_account_employer OR @Original_GL_account_employer IS NULL AND GL_account_emp" & _
        "loyer IS NULL) AND (before_tax = @Original_before_tax OR @Original_before_tax IS" & _
        " NULL AND before_tax IS NULL) AND (percent_gross_pay_employee = @Original_percen" & _
        "t_gross_pay_employee OR @Original_percent_gross_pay_employee IS NULL AND percent" & _
        "_gross_pay_employee IS NULL) AND (percent_gross_pay_employer = @Original_percent" & _
        "_gross_pay_employer OR @Original_percent_gross_pay_employer IS NULL AND percent_" & _
        "gross_pay_employer IS NULL) AND (remark = @Original_remark OR @Original_remark I" & _
        "S NULL AND remark IS NULL) AND (saving_desc = @Original_saving_desc OR @Original" & _
        "_saving_desc IS NULL AND saving_desc IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_saving_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saving_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_employee", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_employer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_before_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "before_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_gross_pay_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_gross_pay_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_gross_pay_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_saving_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saving_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_tab_saving_main
        '
        Me.DApay_tab_saving_main.DeleteCommand = Me.SqlDeleteCommand3
        Me.DApay_tab_saving_main.InsertCommand = Me.SqlInsertCommand3
        Me.DApay_tab_saving_main.SelectCommand = Me.SqlSelectCommand3
        Me.DApay_tab_saving_main.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_saving_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("saving_cod", "saving_cod"), New System.Data.Common.DataColumnMapping("saving_desc", "saving_desc"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("GL_account_employee", "GL_account_employee"), New System.Data.Common.DataColumnMapping("GL_account_employer", "GL_account_employer"), New System.Data.Common.DataColumnMapping("before_tax", "before_tax"), New System.Data.Common.DataColumnMapping("percent_gross_pay_employee", "percent_gross_pay_employee"), New System.Data.Common.DataColumnMapping("percent_gross_pay_employer", "percent_gross_pay_employer")})})
        Me.DApay_tab_saving_main.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pay_saving_dtl.saving_cod, pay_saving_dtl.date_start, pay_saving_dtl.amoun" & _
        "t_employee, pay_saving_dtl.amount_employer, pay_saving_dtl.time_saving_removal, " & _
        "pay_saving_dtl.active, pay_tab_saving_main.saving_desc, pay_saving_dtl.id_deduct" & _
        "ion FROM pay_saving_dtl INNER JOIN pay_tab_saving_main ON pay_saving_dtl.saving_" & _
        "cod = pay_tab_saving_main.saving_cod WHERE (pay_saving_dtl.employee_code = @empl" & _
        "oyee_code)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO pay_saving_dtl(employee_code, saving_cod, date_start, amount_employee" & _
        ", amount_employer, time_saving_removal, active) VALUES (@employee_code, @saving_" & _
        "cod, @date_start, @amount_employee, @amount_employer, @time_saving_removal, @act" & _
        "ive); SELECT employee_code, saving_cod, date_start, amount_employee, amount_empl" & _
        "oyer, time_saving_removal, active FROM pay_saving_dtl WHERE (employee_code = @em" & _
        "ployee_code) AND (saving_cod = @saving_cod)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_cod", System.Data.SqlDbType.VarChar, 2, "saving_cod"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employee", System.Data.SqlDbType.Money, 8, "amount_employee"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employer", System.Data.SqlDbType.Money, 8, "amount_employer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_saving_removal", System.Data.SqlDbType.Money, 8, "time_saving_removal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE pay_saving_dtl SET employee_code = @employee_code, saving_cod = @saving_co" & _
        "d, date_start = @date_start, amount_employee = @amount_employee, amount_employer" & _
        " = @amount_employer, time_saving_removal = @time_saving_removal, active = @activ" & _
        "e WHERE (employee_code = @Original_employee_code) AND (saving_cod = @Original_sa" & _
        "ving_cod) AND (active = @Original_active OR @Original_active IS NULL AND active " & _
        "IS NULL) AND (amount_employee = @Original_amount_employee OR @Original_amount_em" & _
        "ployee IS NULL AND amount_employee IS NULL) AND (amount_employer = @Original_amo" & _
        "unt_employer OR @Original_amount_employer IS NULL AND amount_employer IS NULL) A" & _
        "ND (date_start = @Original_date_start OR @Original_date_start IS NULL AND date_s" & _
        "tart IS NULL) AND (time_saving_removal = @Original_time_saving_removal OR @Origi" & _
        "nal_time_saving_removal IS NULL AND time_saving_removal IS NULL); SELECT employe" & _
        "e_code, saving_cod, date_start, amount_employee, amount_employer, time_saving_re" & _
        "moval, active FROM pay_saving_dtl WHERE (employee_code = @employee_code) AND (sa" & _
        "ving_cod = @saving_cod)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@saving_cod", System.Data.SqlDbType.VarChar, 2, "saving_cod"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_start", System.Data.SqlDbType.VarChar, 10, "date_start"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employee", System.Data.SqlDbType.Money, 8, "amount_employee"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_employer", System.Data.SqlDbType.Money, 8, "amount_employer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_saving_removal", System.Data.SqlDbType.Money, 8, "time_saving_removal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 1, "active"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_saving_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saving_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_employee", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_employer", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_start", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_start", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_time_saving_removal", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "time_saving_removal", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM pay_saving_dtl WHERE (employee_code = @Original_employee_code) AND (s" & _
        "aving_cod = @Original_saving_cod) AND (active = @Original_active OR @Original_ac" & _
        "tive IS NULL AND active IS NULL) AND (amount_employee = @Original_amount_employe" & _
        "e OR @Original_amount_employee IS NULL AND amount_employee IS NULL) AND (amount_" & _
        "employer = @Original_amount_employer OR @Original_amount_employer IS NULL AND am" & _
        "ount_employer IS NULL) AND (date_start = @Original_date_start OR @Original_date_" & _
        "start IS NULL AND date_start IS NULL) AND (time_saving_removal = @Original_time_" & _
        "saving_removal OR @Original_time_saving_removal IS NULL AND time_saving_removal " & _
        "IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_saving_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saving_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_employee", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_employer", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_start", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_start", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_time_saving_removal", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "time_saving_removal", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_saving_dtl
        '
        Me.DApay_saving_dtl.DeleteCommand = Me.SqlDeleteCommand1
        Me.DApay_saving_dtl.InsertCommand = Me.SqlInsertCommand1
        Me.DApay_saving_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_saving_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_saving_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("saving_cod", "saving_cod"), New System.Data.Common.DataColumnMapping("date_start", "date_start"), New System.Data.Common.DataColumnMapping("amount_employee", "amount_employee"), New System.Data.Common.DataColumnMapping("amount_employer", "amount_employer"), New System.Data.Common.DataColumnMapping("time_saving_removal", "time_saving_removal"), New System.Data.Common.DataColumnMapping("active", "active")})})
        Me.DApay_saving_dtl.UpdateCommand = Me.SqlUpdateCommand1
        '
        'FrmEmployeeSaving
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(593, 312)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkActive)
        Me.Controls.Add(Me.NumAmount_employer)
        Me.Controls.Add(Me.Numtime_saving_removal)
        Me.Controls.Add(Me.NumAmount_employee)
        Me.Controls.Add(Me.DteDate_start)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmbsaving_cod)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmEmployeeSaving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Saving"
        Me.Panel9.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEmployeeSaving1, System.ComponentModel.ISupportInitialize).EndInit()
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
        DsFrmEmployeeSaving1.pay_tab_saving_main.Clear()
        DApay_tab_saving_main.Fill(DsFrmEmployeeSaving1, "pay_tab_Saving_main")

        Call FillDApay_Saving_dtl()
    End Sub
    Private Sub FillDApay_Saving_dtl()
        DsFrmEmployeeSaving1.pay_saving_dtl.Clear()
        DApay_saving_dtl.SelectCommand.Parameters("@employee_code").Value = EmployeeCodVar
        DApay_saving_dtl.Fill(DsFrmEmployeeSaving1, "pay_Saving_dtl")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        Call EnableField(True)
        Call ClearField()

        Cmbsaving_cod.Focus()

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
        Cmbsaving_cod.Focus()

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
        If DsFrmEmployeeSaving1.pay_saving_dtl.Rows.Count > 0 Then
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
                    CmdDelete.Parameters("@ID_Deduction").Value = Currentrow.Cells(0).Value()
                    CmdDelete.ExecuteNonQuery()
                    Call FillDApay_Saving_dtl()
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
            Call FillDApay_Saving_dtl()
            Call FillFields()
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Cmbsaving_cod.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call FillFields()
        Call AfterSaveOrCancel()
        Cmbsaving_cod.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If Cmbsaving_cod.Text.Trim.Length = 0 Then
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
    Private Sub TxtEmployeeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkActive.CheckedChanged, DteDate_start.TextChanged, Cmbsaving_cod.SelectedIndexChanged, NumAmount_employee.TextChanged, Numtime_saving_removal.TextChanged, NumAmount_employer.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If Cmbsaving_cod.Text.Trim.Length > 0 And NumAmount_employee.Text > 0 And Mid(DteDate_start.Text, 1, 4).Trim.Length > 0 Then
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
        '    Cmbsaving_cod.Enabled = False
        '    DteDate_start.Enabled = False
        'Else
        '    Cmbsaving_cod.Enabled = instatus
        '    DteDate_start.Enabled = instatus
        'End If
        Cmbsaving_cod.Enabled = instatus
        DteDate_start.Enabled = instatus
        ChkActive.Enabled = instatus
        NumAmount_employee.Enabled = instatus
        NumAmount_employer.Enabled = instatus
        Numtime_saving_removal.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        NumAmount_employee.Text = 0
        NumAmount_employer.Text = 0
        Numtime_saving_removal.Text = 0
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
                .Parameters("@Saving_cod").Value = Cmbsaving_cod.SelectedValue
                .Parameters("@date_start").Value = DteDate_start.Text
                .Parameters("@Amount_employee").Value = NumAmount_employee.Text
                .Parameters("@Amount_employer").Value = NumAmount_employer.Text
                .Parameters("@time_saving_removal").Value = Numtime_saving_removal.Text
                .Parameters("@active").Value = DecodeCheckBox(ChkActive.Checked)
                .ExecuteScalar()
                PInsert = Cmbsaving_cod.SelectedValue
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
                .Parameters("@ID_Deduction").Value = Currentrow.Cells(0).Value()
                .Parameters("@employee_code").Value = EmployeeCodVar
                .Parameters("@Saving_cod").Value = Cmbsaving_cod.SelectedValue
                .Parameters("@date_start").Value = DteDate_start.Text
                .Parameters("@Amount_employee").Value = NumAmount_employee.Text
                .Parameters("@Amount_employer").Value = NumAmount_employer.Text
                .Parameters("@time_saving_removal").Value = Numtime_saving_removal.Text
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
                Cmbsaving_cod.SelectedValue = DsFrmEmployeeSaving1.pay_saving_dtl.Rows(0).Item("Saving_cod")
                NumAmount_employee.Text = DsFrmEmployeeSaving1.pay_saving_dtl.Rows(0).Item("Amount_employee")
                NumAmount_employer.Text = DsFrmEmployeeSaving1.pay_saving_dtl.Rows(0).Item("Amount_employer")
                Numtime_saving_removal.Text = DsFrmEmployeeSaving1.pay_saving_dtl.Rows(0).Item("time_saving_removal")
                DteDate_start.Text = DsFrmEmployeeSaving1.pay_saving_dtl.Rows(0).Item("Date_start")
                ChkActive.Checked = DsFrmEmployeeSaving1.pay_saving_dtl.Rows(0).Item("Active")
                FillFields = True
            Else
                Dim Currentrow As GridEXRow = GrdDetail.GetRow
                Cmbsaving_cod.SelectedValue = Currentrow.Cells("Saving_cod").Value() & ""
                NumAmount_employee.Text = Currentrow.Cells("Amount_employee").Value()
                NumAmount_employer.Text = Currentrow.Cells("Amount_employer").Value()
                Numtime_saving_removal.Text = Currentrow.Cells("time_saving_removal").Value()
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
