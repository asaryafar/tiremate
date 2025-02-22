Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmFederalTax
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public Id_TransferForShow As Decimal = 0
    Friend Id_federal_taxTempVar As Decimal = 0
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
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmFederalTax1 As UCPayroll.DSFrmFederalTax
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee_tab_status As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_federal_tax_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cmbstat_code As System.Windows.Forms.ComboBox
    Friend WithEvents Numyear_tax As CalcUtils.UcCalcText
    Friend WithEvents Numsocial_sec_employee As CalcUtils.UcCalcText
    Friend WithEvents Nummedi_employer As CalcUtils.UcCalcText
    Friend WithEvents Numunemplyment_wagelimit As CalcUtils.UcCalcText
    Friend WithEvents Numwithholding_allownce As CalcUtils.UcCalcText
    Friend WithEvents DApay_tab_federal_tax_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Nummedi_wagelimit As CalcUtils.UcCalcText
    Friend WithEvents Numsocial_sec_wagelimit As CalcUtils.UcCalcText
    Friend WithEvents Numunemplyment_employer As CalcUtils.UcCalcText
    Friend WithEvents Numsocial_sec_employer As CalcUtils.UcCalcText
    Friend WithEvents Numunemplyment_employee As CalcUtils.UcCalcText
    Friend WithEvents Nummedi_employee As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFederalTax))
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
        Me.DsFrmFederalTax1 = New UCPayroll.DSFrmFederalTax
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.Numunemplyment_wagelimit = New CalcUtils.UcCalcText
        Me.Nummedi_wagelimit = New CalcUtils.UcCalcText
        Me.Numsocial_sec_wagelimit = New CalcUtils.UcCalcText
        Me.Numunemplyment_employer = New CalcUtils.UcCalcText
        Me.Nummedi_employer = New CalcUtils.UcCalcText
        Me.Numsocial_sec_employer = New CalcUtils.UcCalcText
        Me.Numunemplyment_employee = New CalcUtils.UcCalcText
        Me.Nummedi_employee = New CalcUtils.UcCalcText
        Me.Numsocial_sec_employee = New CalcUtils.UcCalcText
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Numwithholding_allownce = New CalcUtils.UcCalcText
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
        Me.DApay_tab_federal_tax_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee_tab_status = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_federal_tax_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmFederalTax1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlSearch.Size = New System.Drawing.Size(605, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'CmbYear_Status
        '
        Me.CmbYear_Status.DataSource = Me.DsFrmFederalTax1.pay_tab_federal_tax_head
        Me.CmbYear_Status.DisplayMember = "year_Status"
        Me.CmbYear_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYear_Status.Location = New System.Drawing.Point(76, 1)
        Me.CmbYear_Status.Name = "CmbYear_Status"
        Me.CmbYear_Status.Size = New System.Drawing.Size(159, 21)
        Me.CmbYear_Status.TabIndex = 189
        Me.CmbYear_Status.ValueMember = "Id_Federal_Tax"
        '
        'DsFrmFederalTax1
        '
        Me.DsFrmFederalTax1.DataSetName = "DSFrmFederalTax"
        Me.DsFrmFederalTax1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        Me.PnlKartAmvalField.Controls.Add(Me.GridEX1)
        Me.PnlKartAmvalField.Controls.Add(Me.Numunemplyment_wagelimit)
        Me.PnlKartAmvalField.Controls.Add(Me.Nummedi_wagelimit)
        Me.PnlKartAmvalField.Controls.Add(Me.Numsocial_sec_wagelimit)
        Me.PnlKartAmvalField.Controls.Add(Me.Numunemplyment_employer)
        Me.PnlKartAmvalField.Controls.Add(Me.Nummedi_employer)
        Me.PnlKartAmvalField.Controls.Add(Me.Numsocial_sec_employer)
        Me.PnlKartAmvalField.Controls.Add(Me.Numunemplyment_employee)
        Me.PnlKartAmvalField.Controls.Add(Me.Nummedi_employee)
        Me.PnlKartAmvalField.Controls.Add(Me.Numsocial_sec_employee)
        Me.PnlKartAmvalField.Controls.Add(Me.Label10)
        Me.PnlKartAmvalField.Controls.Add(Me.Label9)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Numwithholding_allownce)
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
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(605, 313)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "pay_tab_federal_tax_dtl"
        Me.GridEX1.DataSource = Me.DsFrmFederalTax1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>pay_tab_federal_tax_dtl</Caption><Columns C" & _
        "ollection=""true""><Column0 ID=""radif""><Caption>radif</Caption><TypeNameEmptyStrin" & _
        "gValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>radif</Dat" & _
        "aMember><Key>radif</Key><Position>0</Position><Visible>False</Visible><Width>50<" & _
        "/Width></Column0><Column1 ID=""over_""><Caption>Over</Caption><DataMember>over_</D" & _
        "ataMember><FormatString>c</FormatString><Key>over_</Key><Position>1</Position><T" & _
        "extAlignment>Far</TextAlignment><Width>108</Width></Column1><Column2 ID=""but_not" & _
        "_over""><Caption>But Not Over</Caption><DataMember>but_not_over</DataMember><Form" & _
        "atString>c</FormatString><Key>but_not_over</Key><Position>2</Position><TextAlign" & _
        "ment>Far</TextAlignment><Width>116</Width></Column2><Column3 ID=""percent_tax""><C" & _
        "aption>Percent Tax</Caption><DataMember>percent_tax</DataMember><FormatString>##" & _
        ".##</FormatString><Key>percent_tax</Key><Position>3</Position><TextAlignment>Far" & _
        "</TextAlignment><Width>115</Width></Column3><Column4 ID=""dollor_tax""><Caption>Do" & _
        "llor Tax</Caption><DataMember>dollor_tax</DataMember><FormatString>c</FormatStri" & _
        "ng><Key>dollor_tax</Key><Position>4</Position><TextAlignment>Far</TextAlignment>" & _
        "<Width>127</Width></Column4><Column5 ID=""Id_Federal_Tax""><Caption>Id_Federal_Tax" & _
        "</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringV" & _
        "alue /><DataMember>Id_Federal_Tax</DataMember><Key>Id_Federal_Tax</Key><Position" & _
        ">5</Position><Visible>False</Visible></Column5></Columns><GroupCondition ID="""" /" & _
        "><Key>pay_tab_federal_tax_dtl</Key><SortKeys Collection=""true""><SortKey0 ID=""Sor" & _
        "tKey0""><ColIndex>0</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutDat" & _
        "a>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEX1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(54, 110)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(497, 200)
        Me.GridEX1.TabIndex = 377
        '
        'Numunemplyment_wagelimit
        '
        Me.Numunemplyment_wagelimit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numunemplyment_wagelimit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numunemplyment_wagelimit.DecimalDigits = 2
        Me.Numunemplyment_wagelimit.DefaultSendValue = False
        Me.Numunemplyment_wagelimit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numunemplyment_wagelimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numunemplyment_wagelimit.Image = CType(resources.GetObject("Numunemplyment_wagelimit.Image"), System.Drawing.Image)
        Me.Numunemplyment_wagelimit.Location = New System.Drawing.Point(511, 82)
        Me.Numunemplyment_wagelimit.Maxlength = 10
        Me.Numunemplyment_wagelimit.MinusColor = System.Drawing.Color.Empty
        Me.Numunemplyment_wagelimit.Name = "Numunemplyment_wagelimit"
        Me.Numunemplyment_wagelimit.Size = New System.Drawing.Size(87, 22)
        Me.Numunemplyment_wagelimit.TabIndex = 14
        Me.Numunemplyment_wagelimit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numunemplyment_wagelimit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Nummedi_wagelimit
        '
        Me.Nummedi_wagelimit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Nummedi_wagelimit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Nummedi_wagelimit.DecimalDigits = 2
        Me.Nummedi_wagelimit.DefaultSendValue = False
        Me.Nummedi_wagelimit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Nummedi_wagelimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Nummedi_wagelimit.Image = CType(resources.GetObject("Nummedi_wagelimit.Image"), System.Drawing.Image)
        Me.Nummedi_wagelimit.Location = New System.Drawing.Point(511, 55)
        Me.Nummedi_wagelimit.Maxlength = 10
        Me.Nummedi_wagelimit.MinusColor = System.Drawing.Color.Empty
        Me.Nummedi_wagelimit.Name = "Nummedi_wagelimit"
        Me.Nummedi_wagelimit.Size = New System.Drawing.Size(87, 22)
        Me.Nummedi_wagelimit.TabIndex = 11
        Me.Nummedi_wagelimit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Nummedi_wagelimit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numsocial_sec_wagelimit
        '
        Me.Numsocial_sec_wagelimit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numsocial_sec_wagelimit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numsocial_sec_wagelimit.DecimalDigits = 2
        Me.Numsocial_sec_wagelimit.DefaultSendValue = False
        Me.Numsocial_sec_wagelimit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numsocial_sec_wagelimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numsocial_sec_wagelimit.Image = CType(resources.GetObject("Numsocial_sec_wagelimit.Image"), System.Drawing.Image)
        Me.Numsocial_sec_wagelimit.Location = New System.Drawing.Point(511, 29)
        Me.Numsocial_sec_wagelimit.Maxlength = 10
        Me.Numsocial_sec_wagelimit.MinusColor = System.Drawing.Color.Empty
        Me.Numsocial_sec_wagelimit.Name = "Numsocial_sec_wagelimit"
        Me.Numsocial_sec_wagelimit.Size = New System.Drawing.Size(87, 22)
        Me.Numsocial_sec_wagelimit.TabIndex = 8
        Me.Numsocial_sec_wagelimit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numsocial_sec_wagelimit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numunemplyment_employer
        '
        Me.Numunemplyment_employer.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numunemplyment_employer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Numunemplyment_employer.DecimalDigits = 2
        Me.Numunemplyment_employer.DefaultSendValue = False
        Me.Numunemplyment_employer.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numunemplyment_employer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numunemplyment_employer.Image = CType(resources.GetObject("Numunemplyment_employer.Image"), System.Drawing.Image)
        Me.Numunemplyment_employer.Location = New System.Drawing.Point(445, 83)
        Me.Numunemplyment_employer.Maxlength = 6
        Me.Numunemplyment_employer.MinusColor = System.Drawing.Color.Empty
        Me.Numunemplyment_employer.Name = "Numunemplyment_employer"
        Me.Numunemplyment_employer.Size = New System.Drawing.Size(61, 21)
        Me.Numunemplyment_employer.TabIndex = 13
        Me.Numunemplyment_employer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numunemplyment_employer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Nummedi_employer
        '
        Me.Nummedi_employer.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Nummedi_employer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Nummedi_employer.DecimalDigits = 2
        Me.Nummedi_employer.DefaultSendValue = False
        Me.Nummedi_employer.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Nummedi_employer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Nummedi_employer.Image = CType(resources.GetObject("Nummedi_employer.Image"), System.Drawing.Image)
        Me.Nummedi_employer.Location = New System.Drawing.Point(445, 56)
        Me.Nummedi_employer.Maxlength = 6
        Me.Nummedi_employer.MinusColor = System.Drawing.Color.Empty
        Me.Nummedi_employer.Name = "Nummedi_employer"
        Me.Nummedi_employer.Size = New System.Drawing.Size(61, 21)
        Me.Nummedi_employer.TabIndex = 10
        Me.Nummedi_employer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Nummedi_employer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numsocial_sec_employer
        '
        Me.Numsocial_sec_employer.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numsocial_sec_employer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Numsocial_sec_employer.DecimalDigits = 2
        Me.Numsocial_sec_employer.DefaultSendValue = False
        Me.Numsocial_sec_employer.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numsocial_sec_employer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numsocial_sec_employer.Image = CType(resources.GetObject("Numsocial_sec_employer.Image"), System.Drawing.Image)
        Me.Numsocial_sec_employer.Location = New System.Drawing.Point(445, 30)
        Me.Numsocial_sec_employer.Maxlength = 6
        Me.Numsocial_sec_employer.MinusColor = System.Drawing.Color.Empty
        Me.Numsocial_sec_employer.Name = "Numsocial_sec_employer"
        Me.Numsocial_sec_employer.Size = New System.Drawing.Size(61, 21)
        Me.Numsocial_sec_employer.TabIndex = 7
        Me.Numsocial_sec_employer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numsocial_sec_employer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numunemplyment_employee
        '
        Me.Numunemplyment_employee.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numunemplyment_employee.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Numunemplyment_employee.DecimalDigits = 2
        Me.Numunemplyment_employee.DefaultSendValue = False
        Me.Numunemplyment_employee.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numunemplyment_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numunemplyment_employee.Image = CType(resources.GetObject("Numunemplyment_employee.Image"), System.Drawing.Image)
        Me.Numunemplyment_employee.Location = New System.Drawing.Point(380, 83)
        Me.Numunemplyment_employee.Maxlength = 6
        Me.Numunemplyment_employee.MinusColor = System.Drawing.Color.Empty
        Me.Numunemplyment_employee.Name = "Numunemplyment_employee"
        Me.Numunemplyment_employee.Size = New System.Drawing.Size(61, 21)
        Me.Numunemplyment_employee.TabIndex = 12
        Me.Numunemplyment_employee.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numunemplyment_employee.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Nummedi_employee
        '
        Me.Nummedi_employee.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Nummedi_employee.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Nummedi_employee.DecimalDigits = 2
        Me.Nummedi_employee.DefaultSendValue = False
        Me.Nummedi_employee.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Nummedi_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Nummedi_employee.Image = CType(resources.GetObject("Nummedi_employee.Image"), System.Drawing.Image)
        Me.Nummedi_employee.Location = New System.Drawing.Point(380, 56)
        Me.Nummedi_employee.Maxlength = 6
        Me.Nummedi_employee.MinusColor = System.Drawing.Color.Empty
        Me.Nummedi_employee.Name = "Nummedi_employee"
        Me.Nummedi_employee.Size = New System.Drawing.Size(61, 21)
        Me.Nummedi_employee.TabIndex = 9
        Me.Nummedi_employee.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Nummedi_employee.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numsocial_sec_employee
        '
        Me.Numsocial_sec_employee.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numsocial_sec_employee.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Numsocial_sec_employee.DecimalDigits = 2
        Me.Numsocial_sec_employee.DefaultSendValue = False
        Me.Numsocial_sec_employee.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numsocial_sec_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numsocial_sec_employee.Image = CType(resources.GetObject("Numsocial_sec_employee.Image"), System.Drawing.Image)
        Me.Numsocial_sec_employee.Location = New System.Drawing.Point(380, 30)
        Me.Numsocial_sec_employee.Maxlength = 6
        Me.Numsocial_sec_employee.MinusColor = System.Drawing.Color.Empty
        Me.Numsocial_sec_employee.Name = "Numsocial_sec_employee"
        Me.Numsocial_sec_employee.Size = New System.Drawing.Size(61, 21)
        Me.Numsocial_sec_employee.TabIndex = 3
        Me.Numsocial_sec_employee.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numsocial_sec_employee.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(516, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 19)
        Me.Label10.TabIndex = 366
        Me.Label10.Text = "Wage Limit"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(446, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 365
        Me.Label9.Text = "Employer%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(378, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 19)
        Me.Label7.TabIndex = 364
        Me.Label7.Text = "Employee%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(228, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 21)
        Me.Label6.TabIndex = 363
        Me.Label6.Text = "Federal Unemployment Tax"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(229, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 21)
        Me.Label5.TabIndex = 362
        Me.Label5.Text = "Medicare Tax Rate"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Numwithholding_allownce
        '
        Me.Numwithholding_allownce.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numwithholding_allownce.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numwithholding_allownce.DecimalDigits = 2
        Me.Numwithholding_allownce.DefaultSendValue = False
        Me.Numwithholding_allownce.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numwithholding_allownce.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Numwithholding_allownce.Image = CType(resources.GetObject("Numwithholding_allownce.Image"), System.Drawing.Image)
        Me.Numwithholding_allownce.Location = New System.Drawing.Point(120, 79)
        Me.Numwithholding_allownce.Maxlength = 10
        Me.Numwithholding_allownce.MinusColor = System.Drawing.Color.Empty
        Me.Numwithholding_allownce.Name = "Numwithholding_allownce"
        Me.Numwithholding_allownce.Size = New System.Drawing.Size(95, 22)
        Me.Numwithholding_allownce.TabIndex = 2
        Me.Numwithholding_allownce.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numwithholding_allownce.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.Numyear_tax.Location = New System.Drawing.Point(119, 10)
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
        Me.Cmbstat_code.DataSource = Me.DsFrmFederalTax1.Employee_tab_status
        Me.Cmbstat_code.DisplayMember = "stat_desc"
        Me.Cmbstat_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbstat_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbstat_code.Location = New System.Drawing.Point(119, 44)
        Me.Cmbstat_code.Name = "Cmbstat_code"
        Me.Cmbstat_code.Size = New System.Drawing.Size(108, 21)
        Me.Cmbstat_code.TabIndex = 1
        Me.Cmbstat_code.ValueMember = "stat_code"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(-4, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 21)
        Me.Label3.TabIndex = 358
        Me.Label3.Text = "Withholding Allowance"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(-5, 43)
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
        Me.Label1.Location = New System.Drawing.Point(-5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 21)
        Me.Label1.TabIndex = 356
        Me.Label1.Text = "Calendar Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(230, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 21)
        Me.Label8.TabIndex = 355
        Me.Label8.Text = "Social Security Tax Rate"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(223, 0)
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
        Me.Panel9.Size = New System.Drawing.Size(605, 45)
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
        'DApay_tab_federal_tax_head
        '
        Me.DApay_tab_federal_tax_head.DeleteCommand = Me.SqlCommand1
        Me.DApay_tab_federal_tax_head.InsertCommand = Me.SqlCommand2
        Me.DApay_tab_federal_tax_head.SelectCommand = Me.SqlCommand3
        Me.DApay_tab_federal_tax_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_federal_tax_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("year_tax", "year_tax"), New System.Data.Common.DataColumnMapping("stat_code", "stat_code"), New System.Data.Common.DataColumnMapping("withholding_allownce", "withholding_allownce"), New System.Data.Common.DataColumnMapping("social_sec_employee", "social_sec_employee"), New System.Data.Common.DataColumnMapping("social_sec_employer", "social_sec_employer"), New System.Data.Common.DataColumnMapping("social_sec_wagelimit", "social_sec_wagelimit"), New System.Data.Common.DataColumnMapping("medi_employee", "medi_employee"), New System.Data.Common.DataColumnMapping("medi_employer", "medi_employer"), New System.Data.Common.DataColumnMapping("medi_wagelimit", "medi_wagelimit"), New System.Data.Common.DataColumnMapping("unemplyment_employee", "unemplyment_employee"), New System.Data.Common.DataColumnMapping("unemplyment_employer", "unemplyment_employer"), New System.Data.Common.DataColumnMapping("unemplyment_wagelimit", "unemplyment_wagelimit")})})
        Me.DApay_tab_federal_tax_head.UpdateCommand = Me.SqlCommand4
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM pay_tab_federal_tax_head WHERE (stat_code = @Original_stat_code) AND " & _
        "(year_tax = @Original_year_tax) AND (medi_employee = @Original_medi_employee OR " & _
        "@Original_medi_employee IS NULL AND medi_employee IS NULL) AND (medi_employer = " & _
        "@Original_medi_employer OR @Original_medi_employer IS NULL AND medi_employer IS " & _
        "NULL) AND (medi_wagelimit = @Original_medi_wagelimit OR @Original_medi_wagelimit" & _
        " IS NULL AND medi_wagelimit IS NULL) AND (social_sec_employee = @Original_social" & _
        "_sec_employee OR @Original_social_sec_employee IS NULL AND social_sec_employee I" & _
        "S NULL) AND (social_sec_employer = @Original_social_sec_employer OR @Original_so" & _
        "cial_sec_employer IS NULL AND social_sec_employer IS NULL) AND (social_sec_wagel" & _
        "imit = @Original_social_sec_wagelimit OR @Original_social_sec_wagelimit IS NULL " & _
        "AND social_sec_wagelimit IS NULL) AND (unemplyment_employee = @Original_unemplym" & _
        "ent_employee OR @Original_unemplyment_employee IS NULL AND unemplyment_employee " & _
        "IS NULL) AND (unemplyment_employer = @Original_unemplyment_employer OR @Original" & _
        "_unemplyment_employer IS NULL AND unemplyment_employer IS NULL) AND (unemplyment" & _
        "_wagelimit = @Original_unemplyment_wagelimit OR @Original_unemplyment_wagelimit " & _
        "IS NULL AND unemplyment_wagelimit IS NULL) AND (withholding_allownce = @Original" & _
        "_withholding_allownce OR @Original_withholding_allownce IS NULL AND withholding_" & _
        "allownce IS NULL)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_stat_code", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "stat_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_year_tax", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "year_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_medi_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_medi_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_medi_wagelimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "medi_wagelimit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_sec_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_sec_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_sec_wagelimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_sec_wagelimit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_unemplyment_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_unemplyment_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_unemplyment_wagelimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "unemplyment_wagelimit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_withholding_allownce", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "withholding_allownce", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO pay_tab_federal_tax_head(year_tax, stat_code, withholding_allownce, s" & _
        "ocial_sec_employee, social_sec_employer, social_sec_wagelimit, medi_employee, me" & _
        "di_employer, medi_wagelimit, unemplyment_employee, unemplyment_employer, unemply" & _
        "ment_wagelimit) VALUES (@year_tax, @stat_code, @withholding_allownce, @social_se" & _
        "c_employee, @social_sec_employer, @social_sec_wagelimit, @medi_employee, @medi_e" & _
        "mployer, @medi_wagelimit, @unemplyment_employee, @unemplyment_employer, @unemply" & _
        "ment_wagelimit); SELECT year_tax, stat_code, withholding_allownce, social_sec_em" & _
        "ployee, social_sec_employer, social_sec_wagelimit, medi_employee, medi_employer," & _
        " medi_wagelimit, unemplyment_employee, unemplyment_employer, unemplyment_wagelim" & _
        "it FROM pay_tab_federal_tax_head WHERE (stat_code = @stat_code) AND (year_tax = " & _
        "@year_tax)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@year_tax", System.Data.SqlDbType.VarChar, 4, "year_tax"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@stat_code", System.Data.SqlDbType.VarChar, 1, "stat_code"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@withholding_allownce", System.Data.SqlDbType.Money, 8, "withholding_allownce"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_sec_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_sec_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employer", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_sec_wagelimit", System.Data.SqlDbType.Money, 8, "social_sec_wagelimit"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@medi_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@medi_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employer", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@medi_wagelimit", System.Data.SqlDbType.Money, 8, "medi_wagelimit"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unemplyment_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unemplyment_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employer", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unemplyment_wagelimit", System.Data.SqlDbType.Money, 8, "unemplyment_wagelimit"))
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT pay_tab_federal_tax_head.year_tax + ' - ' + Employee_tab_status.stat_desc " & _
        "AS year_Status, pay_tab_federal_tax_head.Id_Federal_Tax FROM pay_tab_federal_tax" & _
        "_head INNER JOIN Employee_tab_status ON pay_tab_federal_tax_head.stat_code = Emp" & _
        "loyee_tab_status.stat_code ORDER BY pay_tab_federal_tax_head.year_tax + ' - ' + " & _
        "Employee_tab_status.stat_desc"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE pay_tab_federal_tax_head SET year_tax = @year_tax, stat_code = @stat_code," & _
        " withholding_allownce = @withholding_allownce, social_sec_employee = @social_sec" & _
        "_employee, social_sec_employer = @social_sec_employer, social_sec_wagelimit = @s" & _
        "ocial_sec_wagelimit, medi_employee = @medi_employee, medi_employer = @medi_emplo" & _
        "yer, medi_wagelimit = @medi_wagelimit, unemplyment_employee = @unemplyment_emplo" & _
        "yee, unemplyment_employer = @unemplyment_employer, unemplyment_wagelimit = @unem" & _
        "plyment_wagelimit WHERE (stat_code = @Original_stat_code) AND (year_tax = @Origi" & _
        "nal_year_tax) AND (medi_employee = @Original_medi_employee OR @Original_medi_emp" & _
        "loyee IS NULL AND medi_employee IS NULL) AND (medi_employer = @Original_medi_emp" & _
        "loyer OR @Original_medi_employer IS NULL AND medi_employer IS NULL) AND (medi_wa" & _
        "gelimit = @Original_medi_wagelimit OR @Original_medi_wagelimit IS NULL AND medi_" & _
        "wagelimit IS NULL) AND (social_sec_employee = @Original_social_sec_employee OR @" & _
        "Original_social_sec_employee IS NULL AND social_sec_employee IS NULL) AND (socia" & _
        "l_sec_employer = @Original_social_sec_employer OR @Original_social_sec_employer " & _
        "IS NULL AND social_sec_employer IS NULL) AND (social_sec_wagelimit = @Original_s" & _
        "ocial_sec_wagelimit OR @Original_social_sec_wagelimit IS NULL AND social_sec_wag" & _
        "elimit IS NULL) AND (unemplyment_employee = @Original_unemplyment_employee OR @O" & _
        "riginal_unemplyment_employee IS NULL AND unemplyment_employee IS NULL) AND (unem" & _
        "plyment_employer = @Original_unemplyment_employer OR @Original_unemplyment_emplo" & _
        "yer IS NULL AND unemplyment_employer IS NULL) AND (unemplyment_wagelimit = @Orig" & _
        "inal_unemplyment_wagelimit OR @Original_unemplyment_wagelimit IS NULL AND unempl" & _
        "yment_wagelimit IS NULL) AND (withholding_allownce = @Original_withholding_allow" & _
        "nce OR @Original_withholding_allownce IS NULL AND withholding_allownce IS NULL);" & _
        " SELECT year_tax, stat_code, withholding_allownce, social_sec_employee, social_s" & _
        "ec_employer, social_sec_wagelimit, medi_employee, medi_employer, medi_wagelimit," & _
        " unemplyment_employee, unemplyment_employer, unemplyment_wagelimit FROM pay_tab_" & _
        "federal_tax_head WHERE (stat_code = @stat_code) AND (year_tax = @year_tax)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@year_tax", System.Data.SqlDbType.VarChar, 4, "year_tax"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@stat_code", System.Data.SqlDbType.VarChar, 1, "stat_code"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@withholding_allownce", System.Data.SqlDbType.Money, 8, "withholding_allownce"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_sec_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_sec_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employer", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_sec_wagelimit", System.Data.SqlDbType.Money, 8, "social_sec_wagelimit"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@medi_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@medi_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employer", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@medi_wagelimit", System.Data.SqlDbType.Money, 8, "medi_wagelimit"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unemplyment_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employee", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unemplyment_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employer", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unemplyment_wagelimit", System.Data.SqlDbType.Money, 8, "unemplyment_wagelimit"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_stat_code", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "stat_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_year_tax", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "year_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_medi_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_medi_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "medi_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_medi_wagelimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "medi_wagelimit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_sec_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_sec_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "social_sec_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_sec_wagelimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_sec_wagelimit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_unemplyment_employee", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_unemplyment_employer", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "unemplyment_employer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_unemplyment_wagelimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "unemplyment_wagelimit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_withholding_allownce", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "withholding_allownce", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT stat_code, stat_desc FROM Employee_tab_status"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Employee_tab_status(stat_code, stat_desc) VALUES (@stat_code, @stat_d" & _
        "esc); SELECT stat_code, stat_desc FROM Employee_tab_status WHERE (stat_code = @s" & _
        "tat_code)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@stat_code", System.Data.SqlDbType.VarChar, 1, "stat_code"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@stat_desc", System.Data.SqlDbType.VarChar, 50, "stat_desc"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Employee_tab_status SET stat_code = @stat_code, stat_desc = @stat_desc WHE" & _
        "RE (stat_code = @Original_stat_code) AND (stat_desc = @Original_stat_desc OR @Or" & _
        "iginal_stat_desc IS NULL AND stat_desc IS NULL); SELECT stat_code, stat_desc FRO" & _
        "M Employee_tab_status WHERE (stat_code = @stat_code)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@stat_code", System.Data.SqlDbType.VarChar, 1, "stat_code"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@stat_desc", System.Data.SqlDbType.VarChar, 50, "stat_desc"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_stat_code", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "stat_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_stat_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "stat_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Employee_tab_status WHERE (stat_code = @Original_stat_code) AND (stat" & _
        "_desc = @Original_stat_desc OR @Original_stat_desc IS NULL AND stat_desc IS NULL" & _
        ")"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_stat_code", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "stat_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_stat_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "stat_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAEmployee_tab_status
        '
        Me.DAEmployee_tab_status.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAEmployee_tab_status.InsertCommand = Me.SqlInsertCommand3
        Me.DAEmployee_tab_status.SelectCommand = Me.SqlSelectCommand3
        Me.DAEmployee_tab_status.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employee_tab_status", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("stat_code", "stat_code"), New System.Data.Common.DataColumnMapping("stat_desc", "stat_desc")})})
        Me.DAEmployee_tab_status.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT radif, over_, but_not_over, percent_tax, dollor_tax FROM pay_tab_federal_t" & _
        "ax_dtl WHERE (Id_Federal_Tax = @Id_Federal_Tax)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Federal_Tax", System.Data.SqlDbType.Int, 4, "Id_Federal_Tax"))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO pay_tab_federal_tax_dtl(radif, over_, but_not_over, percent_tax, doll" & _
        "or_tax, Id_Federal_Tax) VALUES (@radif, @over_, @but_not_over, @percent_tax, @do" & _
        "llor_tax, @Id_Federal_Tax); SELECT radif, over_, but_not_over, percent_tax, doll" & _
        "or_tax, Id_Federal_Tax FROM pay_tab_federal_tax_dtl WHERE (Id_Federal_Tax = @Id_" & _
        "Federal_Tax) AND (radif = @radif)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@over_", System.Data.SqlDbType.Money, 8, "over_"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@but_not_over", System.Data.SqlDbType.Money, 8, "but_not_over"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dollor_tax", System.Data.SqlDbType.Money, 8, "dollor_tax"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Federal_Tax", System.Data.SqlDbType.Int, 4, "Id_Federal_Tax"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE pay_tab_federal_tax_dtl SET radif = @radif, over_ = @over_, but_not_over =" & _
        " @but_not_over, percent_tax = @percent_tax, dollor_tax = @dollor_tax, Id_Federal" & _
        "_Tax = @Id_Federal_Tax WHERE (Id_Federal_Tax = @Original_Id_Federal_Tax) AND (ra" & _
        "dif = @Original_radif) AND (but_not_over = @Original_but_not_over OR @Original_b" & _
        "ut_not_over IS NULL AND but_not_over IS NULL) AND (dollor_tax = @Original_dollor" & _
        "_tax OR @Original_dollor_tax IS NULL AND dollor_tax IS NULL) AND (over_ = @Origi" & _
        "nal_over_ OR @Original_over_ IS NULL AND over_ IS NULL) AND (percent_tax = @Orig" & _
        "inal_percent_tax OR @Original_percent_tax IS NULL AND percent_tax IS NULL); SELE" & _
        "CT radif, over_, but_not_over, percent_tax, dollor_tax, Id_Federal_Tax FROM pay_" & _
        "tab_federal_tax_dtl WHERE (Id_Federal_Tax = @Id_Federal_Tax) AND (radif = @radif" & _
        ")"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@over_", System.Data.SqlDbType.Money, 8, "over_"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@but_not_over", System.Data.SqlDbType.Money, 8, "but_not_over"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dollor_tax", System.Data.SqlDbType.Money, 8, "dollor_tax"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Federal_Tax", System.Data.SqlDbType.Int, 4, "Id_Federal_Tax"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Federal_Tax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Federal_Tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_but_not_over", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "but_not_over", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dollor_tax", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dollor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_over_", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "over_", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM pay_tab_federal_tax_dtl WHERE (Id_Federal_Tax = @Original_Id_Federal_" & _
        "Tax) AND (radif = @Original_radif) AND (but_not_over = @Original_but_not_over OR" & _
        " @Original_but_not_over IS NULL AND but_not_over IS NULL) AND (dollor_tax = @Ori" & _
        "ginal_dollor_tax OR @Original_dollor_tax IS NULL AND dollor_tax IS NULL) AND (ov" & _
        "er_ = @Original_over_ OR @Original_over_ IS NULL AND over_ IS NULL) AND (percent" & _
        "_tax = @Original_percent_tax OR @Original_percent_tax IS NULL AND percent_tax IS" & _
        " NULL)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Federal_Tax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Federal_Tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_but_not_over", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "but_not_over", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dollor_tax", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dollor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_over_", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "over_", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_percent_tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "percent_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_tab_federal_tax_dtl
        '
        Me.DApay_tab_federal_tax_dtl.DeleteCommand = Me.SqlDeleteCommand4
        Me.DApay_tab_federal_tax_dtl.InsertCommand = Me.SqlInsertCommand4
        Me.DApay_tab_federal_tax_dtl.SelectCommand = Me.SqlSelectCommand4
        Me.DApay_tab_federal_tax_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_federal_tax_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("over_", "over_"), New System.Data.Common.DataColumnMapping("but_not_over", "but_not_over"), New System.Data.Common.DataColumnMapping("percent_tax", "percent_tax"), New System.Data.Common.DataColumnMapping("dollor_tax", "dollor_tax"), New System.Data.Common.DataColumnMapping("Id_Federal_Tax", "Id_Federal_Tax")})})
        Me.DApay_tab_federal_tax_dtl.UpdateCommand = Me.SqlUpdateCommand4
        '
        'FrmFederalTax
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(605, 385)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmFederalTax"
        Me.Text = "Federal Tax"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmFederalTax1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CM = CType(Me.BindingContext(DsFrmFederalTax1.pay_tab_federal_tax_head), CurrencyManager)
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
        DsFrmFederalTax1.pay_tab_federal_tax_head.Clear()
        DApay_tab_federal_tax_head.Fill(DsFrmFederalTax1, "pay_tab_federal_tax_head")

        DsFrmFederalTax1.Employee_tab_status.Clear()
        DAEmployee_tab_status.Fill(DsFrmFederalTax1, "Employee_tab_status")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        Try
            Id_federal_taxTempVar = CmbYear_Status.SelectedValue
        Catch ex As Exception
            Id_federal_taxTempVar = 0
        End Try

        Call ClearField()

        Dim IFirstCount As Integer = DsFrmFederalTax1.pay_tab_federal_tax_dtl.Rows.Count()
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
            Id_federal_taxTempVar = CmbYear_Status.SelectedValue
        Catch ex As Exception
            Id_federal_taxTempVar = 0
        End Try

        Dim IFirstCount As Integer = DsFrmFederalTax1.pay_tab_federal_tax_dtl.Rows.Count()
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
                Dim ThisId_Federal_Tax As Decimal = CmbYear_Status.SelectedValue
                CmdGeneral.CommandText = "Delete From pay_tab_federal_tax_head Where Id_Federal_Tax=" & ThisId_Federal_Tax
                CmdGeneral.ExecuteNonQuery()
                DsFrmFederalTax1.pay_tab_federal_tax_head.Clear()
                DApay_tab_federal_tax_head.Fill(DsFrmFederalTax1, "pay_tab_federal_tax_head")
                Call PNextRecord(False)
                If Id_federal_taxTempVar = 0 Then
                    Call PPreviousRecord(False)
                    If Id_federal_taxTempVar = 0 Then
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
                Id_federal_taxTempVar = PInsert()
                ChangeOK = IIf(Id_federal_taxTempVar = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(Id_federal_taxTempVar)
        End Select
        If ChangeOK Then
            DsFrmFederalTax1.pay_tab_federal_tax_head.Clear()
            DApay_tab_federal_tax_head.Fill(DsFrmFederalTax1, "pay_tab_federal_tax_head")
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            CmbYear_Status.SelectedValue = Id_federal_taxTempVar
            CmbYear_Status.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbYear_Status.SelectedValue = Id_federal_taxTempVar
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
    Private Sub Numyear_tax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Numyear_tax.TextChanged, Nummedi_employer.TextChanged, Numsocial_sec_employee.TextChanged, Numunemplyment_wagelimit.TextChanged, Numwithholding_allownce.TextChanged, Cmbstat_code.SelectedIndexChanged, Nummedi_wagelimit.TextChanged, Numsocial_sec_wagelimit.TextChanged, Numunemplyment_employer.TextChanged, Numsocial_sec_employer.TextChanged, Numunemplyment_employee.TextChanged, Nummedi_employee.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub GridEX1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.CurrentCellChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If Cmbstat_code.Text.Trim.Length > 0 And Numyear_tax.Text >= 1990 And Numyear_tax.Text <= 2060 Then
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
        If CM.Position = DsFrmFederalTax1.pay_tab_federal_tax_head.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = CM.Position + 1
            Call FillFields(CmbYear_Status.SelectedValue)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmFederalTax1.pay_tab_federal_tax_head.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = DsFrmFederalTax1.pay_tab_federal_tax_head.Rows.Count - 1
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
        Else
            Cmbstat_code.Enabled = False
            Numyear_tax.Enabled = False
        End If
        GridEX1.Enabled = instatus
        Nummedi_employee.Enabled = instatus
        Nummedi_employer.Enabled = instatus
        Nummedi_wagelimit.Enabled = instatus
        Numsocial_sec_employee.Enabled = instatus
        Numsocial_sec_employer.Enabled = instatus
        Numsocial_sec_wagelimit.Enabled = instatus
        Numunemplyment_employee.Enabled = instatus
        Numunemplyment_employer.Enabled = instatus
        Numunemplyment_wagelimit.Enabled = instatus
        Numwithholding_allownce.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        Numyear_tax.Text = 0
        Nummedi_employee.Text = 0
        Nummedi_employer.Text = 0
        Nummedi_wagelimit.Text = 0
        Numsocial_sec_employee.Text = 0
        Numsocial_sec_employer.Text = 0
        Numsocial_sec_wagelimit.Text = 0
        Numunemplyment_employee.Text = 0
        Numunemplyment_employer.Text = 0
        Numunemplyment_wagelimit.Text = 0
        Numwithholding_allownce.Text = 0
        DsFrmFederalTax1.pay_tab_federal_tax_dtl.Clear()
    End Sub
    Friend Function PInsert() As Decimal
        Dim thisrow As DataRow
        PInsert = 0
        Dim Id_federal_taxTemp As Decimal
        Dim GL_accountTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "INSERT INTO pay_tab_federal_tax_head " & _
                                     "(year_tax, stat_code, withholding_allownce, social_sec_employee, social_sec_employer, social_sec_wagelimit, medi_employee, medi_employer,medi_wagelimit, unemplyment_employee, unemplyment_employer, unemplyment_wagelimit) " & _
                                     "VALUES (" & Numyear_tax.Text & "," & Qt(Cmbstat_code.SelectedValue) & "," & Numwithholding_allownce.Text & "," & Numsocial_sec_employee.Text & "," & Numsocial_sec_employer.Text & "," & Numsocial_sec_wagelimit.Text & "," & Nummedi_employee.Text & "," & Nummedi_employer.Text & "," & Nummedi_wagelimit.Text & "," & Numunemplyment_employee.Text & "," & Numunemplyment_employer.Text & "," & Numunemplyment_wagelimit.Text & "); " _
                                   & "Select id_federal_tax FROM pay_tab_federal_tax_head WHERE (id_federal_tax = @@IDENTITY)"
            Id_federal_taxTemp = CmdGeneral.ExecuteScalar()
            Call SaveDetail(Id_federal_taxTemp)
            PInsert = Id_federal_taxTemp
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = 0
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisId_Federal_Tax As Decimal) As Boolean
        PUpdate = True
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Update pay_tab_federal_tax_head Set " & _
                                     "Withholding_allownce=" & Numwithholding_allownce.Text & ", social_sec_employee=" & Numsocial_sec_employee.Text & ", social_sec_employer=" & Numsocial_sec_employer.Text & ", social_sec_wagelimit=" & Numsocial_sec_wagelimit.Text & ", medi_employee=" & Nummedi_employee.Text & ", medi_employer=" & Nummedi_employer.Text & ",medi_wagelimit=" & Nummedi_wagelimit.Text & ", unemplyment_employee=" & Numunemplyment_employee.Text & ", unemplyment_employer=" & Numunemplyment_employer.Text & ", unemplyment_wagelimit=" & Numunemplyment_wagelimit.Text & " Where Id_Federal_Tax=" & ThisId_Federal_Tax
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "Delete From pay_tab_federal_tax_dtl  Where Id_Federal_Tax=" & ThisId_Federal_Tax
            CmdGeneral.ExecuteNonQuery()
            Call SaveDetail(ThisId_Federal_Tax)
            PUpdate = True
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Private Sub SaveDetail(ByVal ThisId_federal_taxTemp As Decimal)
        Dim i As Integer
        Dim RowCounter As Integer = 1
        With DsFrmFederalTax1.pay_tab_federal_tax_dtl()
            For i = 0 To .Count - 1
                If .Rows(i).Item("over_") + .Rows(i).Item("but_not_over") > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO pay_tab_federal_tax_dtl " & _
                                             "(radif, over_, but_not_over, percent_tax, dollor_tax, Id_Federal_Tax)" & _
                                             "VALUES (" & RowCounter & "," & .Rows(i).Item("over_") & "," & .Rows(i).Item("but_not_over") & "," & .Rows(i).Item("percent_tax") & "," & .Rows(i).Item("dollor_tax") & "," & ThisId_federal_taxTemp & ")"
                    CmdGeneral.ExecuteNonQuery()
                    RowCounter = RowCounter + 1
                End If
            Next
        End With
    End Sub
    Friend Function FillFields(ByVal ThisId_Federal_Tax As String) As Boolean
        FillFields = False
        If ThisId_Federal_Tax = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from  pay_tab_federal_tax_head where Id_Federal_Tax=" & ThisId_Federal_Tax
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                Cmbstat_code.SelectedValue = SQLReader.Item("stat_code") & ""
                Numyear_tax.Text = SQLReader.Item("year_tax") & ""
                Nummedi_employee.Text = SQLReader.Item("medi_employee")
                Nummedi_employer.Text = SQLReader.Item("medi_employer")
                Nummedi_wagelimit.Text = SQLReader.Item("medi_wagelimit")
                Numsocial_sec_employee.Text = SQLReader.Item("social_sec_employee")
                Numsocial_sec_employer.Text = SQLReader.Item("social_sec_employer")
                Numsocial_sec_wagelimit.Text = SQLReader.Item("social_sec_wagelimit")
                Numunemplyment_employee.Text = SQLReader.Item("unemplyment_employee")
                Numunemplyment_employer.Text = SQLReader.Item("unemplyment_employer")
                Numunemplyment_wagelimit.Text = SQLReader.Item("unemplyment_wagelimit")
                Numwithholding_allownce.Text = SQLReader.Item("withholding_allownce")
                SQLReader.Close()
                DsFrmFederalTax1.pay_tab_federal_tax_dtl.Clear()
                DApay_tab_federal_tax_dtl.SelectCommand.Parameters("@Id_Federal_Tax").Value = ThisId_Federal_Tax
                DApay_tab_federal_tax_dtl.Fill(DsFrmFederalTax1, "pay_tab_federal_tax_dtl")
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
    Private Sub AddEmptyRecordToDetail(ByVal ThisId_Federal_Tax As String, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmFederalTax1.pay_tab_federal_tax_dtl.NewRow
        dr("radif") = ThisRadif
        dr("over_") = 0
        dr("but_not_over") = 0
        dr("percent_tax") = 0
        dr("dollor_tax") = 0
        DsFrmFederalTax1.pay_tab_federal_tax_dtl.Rows.Add(dr)
    End Sub
End Class
