Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmStateTax
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public Id_TransferForShow As Decimal = 0
    Friend Id_State_taxTempVar As Decimal = 0
    Dim PnlSearchHeight As Integer
    Private CM As CurrencyManager
    Dim RowNoToAdd As Double = 10
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
    Friend WithEvents CmbYear_Status As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee_tab_status As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cmbstat_code As System.Windows.Forms.ComboBox
    Friend WithEvents Numyear_tax As CalcUtils.UcCalcText
    Friend WithEvents CmbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DAbas_zipcode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmStateTax1 As UCPayroll.DSFrmStateTax
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_state_tax_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Numdependent_allowance As CalcUtils.UcCalcText
    Friend WithEvents Numpersonal_allowance As CalcUtils.UcCalcText
    Friend WithEvents Numstandard_deduction As CalcUtils.UcCalcText
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_state_tax_dtl As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmStateTax))
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
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.CmbYear_Status = New System.Windows.Forms.ComboBox
        Me.DsFrmStateTax1 = New UCPayroll.DSFrmStateTax
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.CmbState = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.Numdependent_allowance = New CalcUtils.UcCalcText
        Me.Numpersonal_allowance = New CalcUtils.UcCalcText
        Me.Label5 = New System.Windows.Forms.Label
        Me.Numstandard_deduction = New CalcUtils.UcCalcText
        Me.Numyear_tax = New CalcUtils.UcCalcText
        Me.Cmbstat_code = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Sort32 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort31 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.SortByType1 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.Command2 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Command21 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Panel9 = New System.Windows.Forms.Panel
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
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee_tab_status = New System.Data.SqlClient.SqlDataAdapter
        Me.DAbas_zipcode = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_state_tax_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_state_tax_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmStateTax1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
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
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.CmbYear_Status)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(514, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'CmbYear_Status
        '
        Me.CmbYear_Status.DataSource = Me.DsFrmStateTax1.pay_tab_state_tax_head
        Me.CmbYear_Status.DisplayMember = "year_Status"
        Me.CmbYear_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYear_Status.Location = New System.Drawing.Point(76, 1)
        Me.CmbYear_Status.Name = "CmbYear_Status"
        Me.CmbYear_Status.Size = New System.Drawing.Size(159, 21)
        Me.CmbYear_Status.TabIndex = 189
        Me.CmbYear_Status.ValueMember = "Id_State_Tax"
        '
        'DsFrmStateTax1
        '
        Me.DsFrmStateTax1.DataSetName = "DSFrmStateTax"
        Me.DsFrmStateTax1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Year - Status"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.CmbState)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Controls.Add(Me.GridEX1)
        Me.PnlKartAmvalField.Controls.Add(Me.Numdependent_allowance)
        Me.PnlKartAmvalField.Controls.Add(Me.Numpersonal_allowance)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Numstandard_deduction)
        Me.PnlKartAmvalField.Controls.Add(Me.Numyear_tax)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbstat_code)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(514, 297)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'CmbState
        '
        Me.CmbState.BackColor = System.Drawing.SystemColors.Window
        Me.CmbState.DataSource = Me.DsFrmStateTax1.bas_zipcode
        Me.CmbState.DisplayMember = "state"
        Me.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbState.ItemHeight = 13
        Me.CmbState.Location = New System.Drawing.Point(423, 6)
        Me.CmbState.Name = "CmbState"
        Me.CmbState.Size = New System.Drawing.Size(53, 21)
        Me.CmbState.TabIndex = 378
        Me.CmbState.ValueMember = "state"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(384, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 14)
        Me.Label6.TabIndex = 379
        Me.Label6.Text = "State"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "pay_tab_state_tax_dtl"
        Me.GridEX1.DataSource = Me.DsFrmStateTax1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>pay_tab_state_tax_dtl</Caption><Columns Col" & _
        "lection=""true""><Column0 ID=""over_""><Caption>Over</Caption><DataMember>over_</Dat" & _
        "aMember><FormatString>c</FormatString><Key>over_</Key><Position>0</Position><Tex" & _
        "tAlignment>Far</TextAlignment></Column0><Column1 ID=""but_not_over""><Caption>But " & _
        "Not Over</Caption><DataMember>but_not_over</DataMember><FormatString>c</FormatSt" & _
        "ring><Key>but_not_over</Key><Position>1</Position><TextAlignment>Far</TextAlignm" & _
        "ent></Column1><Column2 ID=""percent_tax""><Caption>Percent Tax</Caption><DataMembe" & _
        "r>percent_tax</DataMember><FormatString>##.##</FormatString><Key>percent_tax</Ke" & _
        "y><Position>2</Position><TextAlignment>Far</TextAlignment></Column2><Column3 ID=" & _
        """dollor_tax""><Caption>Dollar Tax</Caption><DataMember>dollor_tax</DataMember><Fo" & _
        "rmatString>c</FormatString><Key>dollor_tax</Key><Position>3</Position><TextAlign" & _
        "ment>Far</TextAlignment></Column3><Column4 ID=""radif""><Caption>radif</Caption><T" & _
        "ypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><Data" & _
        "Member>radif</DataMember><Key>radif</Key><Position>4</Position><Visible>False</V" & _
        "isible></Column4><Column5 ID=""Id_State_Tax""><Caption>Id_State_Tax</Caption><Type" & _
        "NameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMem" & _
        "ber>Id_State_Tax</DataMember><Key>Id_State_Tax</Key><Position>5</Position><Visib" & _
        "le>False</Visible></Column5></Columns><GroupCondition ID="""" /><Key>pay_tab_state" & _
        "_tax_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEX1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(40, 93)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(434, 200)
        Me.GridEX1.TabIndex = 377
        '
        'Numdependent_allowance
        '
        Me.Numdependent_allowance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numdependent_allowance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numdependent_allowance.DecimalDigits = 2
        Me.Numdependent_allowance.DefaultSendValue = False
        Me.Numdependent_allowance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numdependent_allowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numdependent_allowance.Image = CType(resources.GetObject("Numdependent_allowance.Image"), System.Drawing.Image)
        Me.Numdependent_allowance.Location = New System.Drawing.Point(422, 63)
        Me.Numdependent_allowance.Maxlength = 10
        Me.Numdependent_allowance.MinusColor = System.Drawing.Color.Empty
        Me.Numdependent_allowance.Name = "Numdependent_allowance"
        Me.Numdependent_allowance.Size = New System.Drawing.Size(87, 22)
        Me.Numdependent_allowance.TabIndex = 14
        Me.Numdependent_allowance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numdependent_allowance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numpersonal_allowance
        '
        Me.Numpersonal_allowance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numpersonal_allowance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numpersonal_allowance.DecimalDigits = 2
        Me.Numpersonal_allowance.DefaultSendValue = False
        Me.Numpersonal_allowance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numpersonal_allowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numpersonal_allowance.Image = CType(resources.GetObject("Numpersonal_allowance.Image"), System.Drawing.Image)
        Me.Numpersonal_allowance.Location = New System.Drawing.Point(422, 35)
        Me.Numpersonal_allowance.Maxlength = 10
        Me.Numpersonal_allowance.MinusColor = System.Drawing.Color.Empty
        Me.Numpersonal_allowance.Name = "Numpersonal_allowance"
        Me.Numpersonal_allowance.Size = New System.Drawing.Size(87, 22)
        Me.Numpersonal_allowance.TabIndex = 11
        Me.Numpersonal_allowance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numpersonal_allowance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(272, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 21)
        Me.Label5.TabIndex = 362
        Me.Label5.Text = "Dependent Allowance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Numstandard_deduction
        '
        Me.Numstandard_deduction.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numstandard_deduction.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numstandard_deduction.DecimalDigits = 2
        Me.Numstandard_deduction.DefaultSendValue = False
        Me.Numstandard_deduction.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numstandard_deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numstandard_deduction.Image = CType(resources.GetObject("Numstandard_deduction.Image"), System.Drawing.Image)
        Me.Numstandard_deduction.Location = New System.Drawing.Point(120, 63)
        Me.Numstandard_deduction.Maxlength = 10
        Me.Numstandard_deduction.MinusColor = System.Drawing.Color.Empty
        Me.Numstandard_deduction.Name = "Numstandard_deduction"
        Me.Numstandard_deduction.Size = New System.Drawing.Size(95, 22)
        Me.Numstandard_deduction.TabIndex = 2
        Me.Numstandard_deduction.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numstandard_deduction.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numyear_tax
        '
        Me.Numyear_tax.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numyear_tax.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Numyear_tax.DecimalDigits = 0
        Me.Numyear_tax.DefaultSendValue = False
        Me.Numyear_tax.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numyear_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numyear_tax.Image = CType(resources.GetObject("Numyear_tax.Image"), System.Drawing.Image)
        Me.Numyear_tax.Location = New System.Drawing.Point(119, 7)
        Me.Numyear_tax.Maxlength = 4
        Me.Numyear_tax.MinusColor = System.Drawing.Color.Empty
        Me.Numyear_tax.Name = "Numyear_tax"
        Me.Numyear_tax.Size = New System.Drawing.Size(53, 21)
        Me.Numyear_tax.TabIndex = 0
        Me.Numyear_tax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numyear_tax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Cmbstat_code
        '
        Me.Cmbstat_code.DataSource = Me.DsFrmStateTax1.Employee_tab_status
        Me.Cmbstat_code.DisplayMember = "stat_desc"
        Me.Cmbstat_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbstat_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbstat_code.Location = New System.Drawing.Point(119, 34)
        Me.Cmbstat_code.Name = "Cmbstat_code"
        Me.Cmbstat_code.Size = New System.Drawing.Size(108, 21)
        Me.Cmbstat_code.TabIndex = 1
        Me.Cmbstat_code.ValueMember = "stat_code"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(-4, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 358
        Me.Label3.Text = "Standard Deduction"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(-9, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 357
        Me.Label2.Text = "Status"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(-2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 356
        Me.Label1.Text = "Calendar Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(270, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 21)
        Me.Label8.TabIndex = 355
        Me.Label8.Text = "Personal Allowance"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(194, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 21)
        Me.Label11.TabIndex = 367
        Me.Label11.Text = "Annual Payroll Period"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel9.Size = New System.Drawing.Size(514, 45)
        Me.Panel9.TabIndex = 143
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
        Me.Label42.Location = New System.Drawing.Point(358, 31)
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
        Me.Label51.Location = New System.Drawing.Point(282, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(38, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(207, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(162, 31)
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
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT stat_code, stat_desc FROM Employee_tab_status"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAEmployee_tab_status
        '
        Me.DAEmployee_tab_status.SelectCommand = Me.SqlSelectCommand3
        Me.DAEmployee_tab_status.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employee_tab_status", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("stat_code", "stat_code"), New System.Data.Common.DataColumnMapping("stat_desc", "stat_desc")})})
        '
        'DAbas_zipcode
        '
        Me.DAbas_zipcode.SelectCommand = Me.SqlCommand8
        Me.DAbas_zipcode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_zipcode", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("county", "county"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("ariacode", "ariacode"), New System.Data.Common.DataColumnMapping("fips_code", "fips_code"), New System.Data.Common.DataColumnMapping("time_zone", "time_zone"), New System.Data.Common.DataColumnMapping("dst", "dst")})})
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "SELECT DISTINCT state FROM bas_zipcode"
        Me.SqlCommand8.Connection = Me.Cnn
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT pay_tab_state_tax_head.year_tax + ' - ' + Employee_tab_status.stat_desc AS" & _
        " year_Status, pay_tab_state_tax_head.Id_State_Tax FROM pay_tab_state_tax_head IN" & _
        "NER JOIN Employee_tab_status ON pay_tab_state_tax_head.stat_code = Employee_tab_" & _
        "status.stat_code ORDER BY pay_tab_state_tax_head.year_tax + ' - ' + Employee_tab" & _
        "_status.stat_desc"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DApay_tab_state_tax_head
        '
        Me.DApay_tab_state_tax_head.SelectCommand = Me.SqlSelectCommand6
        Me.DApay_tab_state_tax_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_state_tax_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("year_tax", "year_tax"), New System.Data.Common.DataColumnMapping("stat_code", "stat_code"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("standard_deduction", "standard_deduction"), New System.Data.Common.DataColumnMapping("personal_allowance", "personal_allowance"), New System.Data.Common.DataColumnMapping("dependent_allowance", "dependent_allowance"), New System.Data.Common.DataColumnMapping("Id_State_Tax", "Id_State_Tax")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT over_, but_not_over, percent_tax, radif, dollor_tax FROM pay_tab_state_tax" & _
        "_dtl WHERE (id_state_tax = @Id_State_Tax)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_State_Tax", System.Data.SqlDbType.Int, 4, "id_state_tax"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO pay_tab_state_tax_dtl(id_state_tax, radif, over_, but_not_over, perce" & _
        "nt_tax, dollor_tax) VALUES (@id_state_tax, @radif, @over_, @but_not_over, @perce" & _
        "nt_tax, @dollor_tax); SELECT id_state_tax, radif, over_, but_not_over, percent_t" & _
        "ax, dollor_tax FROM pay_tab_state_tax_dtl WHERE (id_state_tax = @id_state_tax) A" & _
        "ND (radif = @radif)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_state_tax", System.Data.SqlDbType.Int, 4, "id_state_tax"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@over_", System.Data.SqlDbType.Money, 8, "over_"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@but_not_over", System.Data.SqlDbType.Money, 8, "but_not_over"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dollor_tax", System.Data.SqlDbType.Money, 8, "dollor_tax"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE pay_tab_state_tax_dtl SET id_state_tax = @id_state_tax, radif = @radif, ov" & _
        "er_ = @over_, but_not_over = @but_not_over, percent_tax = @percent_tax, dollor_t" & _
        "ax = @dollor_tax WHERE (id_state_tax = @Original_id_state_tax) AND (radif = @Ori" & _
        "ginal_radif) AND (but_not_over = @Original_but_not_over OR @Original_but_not_ove" & _
        "r IS NULL AND but_not_over IS NULL) AND (dollor_tax = @Original_dollor_tax OR @O" & _
        "riginal_dollor_tax IS NULL AND dollor_tax IS NULL) AND (over_ = @Original_over_ " & _
        "OR @Original_over_ IS NULL AND over_ IS NULL) AND (percent_tax = @Original_perce" & _
        "nt_tax OR @Original_percent_tax IS NULL AND percent_tax IS NULL); SELECT id_stat" & _
        "e_tax, radif, over_, but_not_over, percent_tax, dollor_tax FROM pay_tab_state_ta" & _
        "x_dtl WHERE (id_state_tax = @id_state_tax) AND (radif = @radif)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_state_tax", System.Data.SqlDbType.Int, 4, "id_state_tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@over_", System.Data.SqlDbType.Money, 8, "over_"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@but_not_over", System.Data.SqlDbType.Money, 8, "but_not_over"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dollor_tax", System.Data.SqlDbType.Money, 8, "dollor_tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_state_tax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_state_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_but_not_over", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "but_not_over", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dollor_tax", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dollor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_over_", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "over_", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM pay_tab_state_tax_dtl WHERE (id_state_tax = @Original_id_state_tax) A" & _
        "ND (radif = @Original_radif) AND (but_not_over = @Original_but_not_over OR @Orig" & _
        "inal_but_not_over IS NULL AND but_not_over IS NULL) AND (dollor_tax = @Original_" & _
        "dollor_tax OR @Original_dollor_tax IS NULL AND dollor_tax IS NULL) AND (over_ = " & _
        "@Original_over_ OR @Original_over_ IS NULL AND over_ IS NULL) AND (percent_tax =" & _
        " @Original_percent_tax OR @Original_percent_tax IS NULL AND percent_tax IS NULL)" & _
        ""
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_state_tax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_state_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_but_not_over", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "but_not_over", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dollor_tax", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dollor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_over_", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "over_", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_tab_state_tax_dtl
        '
        Me.DApay_tab_state_tax_dtl.DeleteCommand = Me.SqlDeleteCommand1
        Me.DApay_tab_state_tax_dtl.InsertCommand = Me.SqlInsertCommand1
        Me.DApay_tab_state_tax_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_tab_state_tax_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_state_tax_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_state_tax", "id_state_tax"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("over_", "over_"), New System.Data.Common.DataColumnMapping("but_not_over", "but_not_over"), New System.Data.Common.DataColumnMapping("percent_tax", "percent_tax"), New System.Data.Common.DataColumnMapping("dollor_tax", "dollor_tax")})})
        Me.DApay_tab_state_tax_dtl.UpdateCommand = Me.SqlUpdateCommand1
        '
        'FrmStateTax
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(514, 369)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmStateTax"
        Me.Text = "State Tax"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmStateTax1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmReceivePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        Call FillDataSets()
        CM = CType(Me.BindingContext(DsFrmStateTax1.pay_tab_state_tax_head), CurrencyManager)
        If Id_TransferForShow > 0 Then
            CmbYear_Status.SelectedValue = Id_TransferForShow
        Else
            Call PFirstRecord(False)
            Try
                Call FillFields(CmbYear_Status.SelectedValue)
            Catch ex As Exception
            End Try
        End If
        Call AfterSaveOrCancel()
        CmbYear_Status.Focus()
    End Sub
    Private Sub FillDataSets()
        DsFrmStateTax1.Employee_tab_status.Clear()
        DAEmployee_tab_status.Fill(DsFrmStateTax1, "Employee_tab_status")

        DsFrmStateTax1.bas_zipcode.Clear()
        DAbas_zipcode.Fill(DsFrmStateTax1, "bas_zipcode")

        DsFrmStateTax1.pay_tab_state_tax_head.Clear()
        DApay_tab_state_tax_head.Fill(DsFrmStateTax1, "pay_tab_State_tax_head")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        Try
            Id_State_taxTempVar = CmbYear_Status.SelectedValue
        Catch ex As Exception
            Id_State_taxTempVar = 0
        End Try

        Call ClearField()

        Dim IFirstCount As Integer = DsFrmStateTax1.pay_tab_state_tax_dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
            Call AddEmptyRecordToDetail(0, AddEmptyRecordToDetailCount)
        Next

        Numyear_tax.Focus()

        BtnNew.Enabled = False
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
        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True)
        Try
            Id_State_taxTempVar = CmbYear_Status.SelectedValue
        Catch ex As Exception
            Id_State_taxTempVar = 0
        End Try

        Dim IFirstCount As Integer = DsFrmStateTax1.pay_tab_state_tax_dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
            Call AddEmptyRecordToDetail(0, AddEmptyRecordToDetailCount)
        Next

        Numyear_tax.Focus()

        BtnNew.Enabled = False
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
        If CmbYear_Status.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim IdGL_debit_deposit_headTemp As Decimal
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Dim ThisId_State_Tax As Decimal = CmbYear_Status.SelectedValue
                CmdGeneral.CommandText = "Delete From pay_tab_State_tax_head Where Id_State_Tax=" & ThisId_State_Tax
                CmdGeneral.ExecuteNonQuery()
                DsFrmStateTax1.pay_tab_state_tax_head.Clear()
                DApay_tab_state_tax_head.Fill(DsFrmStateTax1, "pay_tab_State_tax_head")
                Call PNextRecord(False)
                If Id_State_taxTempVar = 0 Then
                    Call PPreviousRecord(False)
                    If Id_State_taxTempVar = 0 Then
                        Call ClearField()
                    End If
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            End Try
            Call AfterSaveOrCancel()
        Else
            CmbYear_Status.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                Id_State_taxTempVar = PInsert()
                ChangeOK = IIf(Id_State_taxTempVar = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(Id_State_taxTempVar)
        End Select
        If ChangeOK Then
            DsFrmStateTax1.pay_tab_state_tax_head.Clear()
            DApay_tab_state_tax_head.Fill(DsFrmStateTax1, "pay_tab_State_tax_head")
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            CmbYear_Status.SelectedValue = Id_State_taxTempVar
            CmbYear_Status.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbYear_Status.SelectedValue = Id_State_taxTempVar
        Call FillFields(CmbYear_Status.SelectedValue)
        Call AfterSaveOrCancel()
        CmbYear_Status.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If CmbYear_Status.Text.Trim.Length = 0 Then
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
    Private Sub Numyear_tax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Numyear_tax.TextChanged, Numdependent_allowance.TextChanged, Numpersonal_allowance.TextChanged, Numstandard_deduction.TextChanged, Cmbstat_code.SelectedIndexChanged, CmbState.SelectedIndexChanged
        Call SaveButtonControl()
    End Sub
    Private Sub GridEX1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.CurrentCellChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If Cmbstat_code.Text.Trim.Length > 0 And CmbState.Text.Trim.Length > 0 And Numyear_tax.Text >= 1990 And Numyear_tax.Text <= 2060 Then
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
            Call FillFields(CmbYear_Status.SelectedValue)
        End If
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CM.Position = CM.Position - 1
            Call FillFields(CmbYear_Status.SelectedValue)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmStateTax1.pay_tab_state_tax_head.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = CM.Position + 1
            Call FillFields(CmbYear_Status.SelectedValue)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmStateTax1.pay_tab_state_tax_head.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = DsFrmStateTax1.pay_tab_state_tax_head.Rows.Count - 1
            Call FillFields(CmbYear_Status.SelectedValue)
        End If
    End Sub
    Private Sub CmbYear_Status_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbYear_Status.SelectionChangeCommitted
        Call FillFields(CmbYear_Status.SelectedValue)
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
            CmbYear_Status.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub PPrintMasterInformation()
        'If CmbGL_accountHead.Text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@refrence_no").Value = CmbGL_accountHead.Text
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
            Cmbstat_code.Enabled = instatus
            Numyear_tax.Enabled = instatus
            CmbState.Enabled = instatus
        Else
            Cmbstat_code.Enabled = False
            Numyear_tax.Enabled = False
            CmbState.Enabled = False
        End If
        GridEX1.Enabled = instatus
        Numdependent_allowance.Enabled = instatus
        Numpersonal_allowance.Enabled = instatus
        Numstandard_deduction.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        Try
            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
            CmbState.SelectedValue = OleDbReaderForStore.Item("State") & ""
            OleDbReaderForStore.Close()
        Catch ex As Exception
        End Try
        Numyear_tax.Text = 0
        Numdependent_allowance.Text = 0
        Numpersonal_allowance.Text = 0
        Numstandard_deduction.Text = 0
        DsFrmStateTax1.pay_tab_state_tax_dtl.Clear()
    End Sub
    Friend Function PInsert() As Decimal
        Dim thisrow As DataRow
        PInsert = 0
        Dim Id_State_taxTemp As Decimal
        Dim GL_accountTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "INSERT INTO pay_tab_State_tax_head " & _
                                     "(year_tax, stat_code, state, standard_deduction, personal_allowance, dependent_allowance) " & _
                                     "VALUES (" & Numyear_tax.Text & "," & Qt(Cmbstat_code.SelectedValue) & "," & Qt(CmbState.SelectedValue) & "," & Numstandard_deduction.Text & "," & Numpersonal_allowance.Text & "," & Numdependent_allowance.Text & ")" & _
                                     "Select id_State_tax FROM pay_tab_State_tax_head WHERE (id_State_tax = @@IDENTITY)"
            Id_State_taxTemp = CmdGeneral.ExecuteScalar()
            Call SaveDetail(Id_State_taxTemp)
            PInsert = Id_State_taxTemp
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = 0
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisId_State_Tax As Decimal) As Boolean
        PUpdate = True
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Update pay_tab_State_tax_head Set " & _
                                     "standard_deduction=" & Numstandard_deduction.Text & ", personal_allowance=" & Numpersonal_allowance.Text & ", dependent_allowance=" & Numdependent_allowance.Text & " Where Id_State_Tax=" & ThisId_State_Tax
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "Delete From pay_tab_State_tax_dtl Where Id_State_Tax=" & ThisId_State_Tax
            CmdGeneral.ExecuteNonQuery()
            Call SaveDetail(ThisId_State_Tax)
            PUpdate = True
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Private Sub SaveDetail(ByVal ThisId_State_taxTemp As Decimal)
        Dim i As Integer
        Dim RowCounter As Integer = 1
        With DsFrmStateTax1.pay_tab_state_tax_dtl()
            For i = 0 To .Count - 1
                If .Rows(i).Item("over_") + .Rows(i).Item("but_not_over") > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO pay_tab_State_tax_dtl " & _
                                             "(radif, over_, but_not_over, percent_tax, dollor_tax, Id_State_Tax)" & _
                                             "VALUES (" & RowCounter & "," & .Rows(i).Item("over_") & "," & .Rows(i).Item("but_not_over") & "," & .Rows(i).Item("percent_tax") & "," & .Rows(i).Item("dollor_tax") & "," & ThisId_State_taxTemp & ")"
                    CmdGeneral.ExecuteNonQuery()
                    RowCounter = RowCounter + 1
                End If
            Next
        End With
    End Sub
    Friend Function FillFields(ByVal ThisId_State_Tax As String) As Boolean
        FillFields = False
        If ThisId_State_Tax = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from  pay_tab_State_tax_head where Id_State_Tax=" & ThisId_State_Tax
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                Cmbstat_code.SelectedValue = SQLReader.Item("stat_code") & ""
                CmbState.SelectedValue = SQLReader.Item("state") & ""
                Numyear_tax.Text = SQLReader.Item("year_tax") & ""
                Numdependent_allowance.Text = SQLReader.Item("dependent_allowance")
                Numpersonal_allowance.Text = SQLReader.Item("personal_allowance")
                Numstandard_deduction.Text = SQLReader.Item("standard_deduction")
                SQLReader.Close()
                DsFrmStateTax1.pay_tab_state_tax_dtl.Clear()
                DApay_tab_state_tax_dtl.SelectCommand.Parameters("@Id_State_Tax").Value = ThisId_State_Tax
                DApay_tab_state_tax_dtl.Fill(DsFrmStateTax1, "pay_tab_State_tax_dtl")
                FillFields = True
            Else
                SQLReader.Close()
                Call ClearField()
            End If
        Catch ex As Exception
            MsgBox("Error in loading data")
        End Try
        Try
            CmdGeneral.Connection.Close()
        Catch ex As Exception
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
    'Private Sub TxtRefrence_no_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) ha
    '    Try
    '        MyClsReceivePayment.Connection = Cnn
    '    Catch ex As Exception
    '    End Try
    '    If MyClsReceivePayment.FindDesc(TxtRefrence_no.Text) Then
    '        MsgBox("This Code Is Exist.Please Try With a New Code")
    '        TxtRefrence_no.Clear()
    '        TxtRefrence_no.Focus()
    '    End If
    'End Sub
    Private Sub AddEmptyRecordToDetail(ByVal ThisId_State_Tax As String, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmStateTax1.pay_tab_state_tax_dtl.NewRow
        dr("radif") = ThisRadif
        dr("over_") = 0
        dr("but_not_over") = 0
        dr("percent_tax") = 0
        dr("dollor_tax") = 0
        DsFrmStateTax1.pay_tab_state_tax_dtl.Rows.Add(dr)
    End Sub
End Class
