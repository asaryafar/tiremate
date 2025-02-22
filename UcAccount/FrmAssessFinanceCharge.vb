' DONT DELETE THIS COMMENT
'alter table gl_account_adjustment_dtl_dtl drop constraint FK_GL_account_adjustment_dtl_dtl_GL_account_adjustment_dtl
'go
'alter table gl_account_adjustment_dtl  drop constraint FK_GL_account_adjustment_dtl_service_center_head
'go
'alter table gl_account_adjustment_dtl  drop constraint PK_GL_account_adjustment_dtl
'go
'alter table GL_payment_deposit drop constraint FK_GL_payment_deposit_GL_account_adjustment_head
'go
'alter table gl_account_adjustment_dtl  drop constraint FK_GL_account_adjustment_dtl_GL_account_adjustment_head
'go
'alter table gl_account_adjustment_head drop constraint  PK_GL_account_adjustment_head
'go
'alter table gl_account_adjustment_dtl_dtl  alter column refrence_no_due char(8)
'go
'alter table gl_account_adjustment_dtl  alter column refrence_no char(8)
'go
'alter table gl_account_adjustment_head  alter column refrence_no char(8)






'/---------------------------

'ALTER TABLE [dbo].[GL_account_adjustment_dtl] WITH NOCHECK ADD 
'	CONSTRAINT [PK_GL_account_adjustment_dtl] PRIMARY KEY  CLUSTERED 
'	(
'		[refrence_no],
'		[id_service_center]
'	)  ON [PRIMARY] 
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_dtl_dtl] WITH NOCHECK ADD 
'	CONSTRAINT [PK_GL_account_adjustment_dtl_dtl] PRIMARY KEY  CLUSTERED 
'	(
'		[IDGL_account_adjustment_dtl]
'	)  ON [PRIMARY] 
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_head] WITH NOCHECK ADD 
'	CONSTRAINT [PK_GL_account_adjustment_head] PRIMARY KEY  CLUSTERED 
'	(
'		[refrence_no]
'	)  ON [PRIMARY] 
'GO

'ALTER TABLE [dbo].[GL_payment_deposit] WITH NOCHECK ADD 
'	CONSTRAINT [PK_GL_payment_deposit] PRIMARY KEY  CLUSTERED 
'	(
'		[ID_payment]
'	)  ON [PRIMARY] 
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_dtl] ADD 
'	CONSTRAINT [DF__GL_accoun__Old_A__6EB71AF2] DEFAULT (0) FOR [Old_Amount_adjustment]
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_dtl_dtl] ADD 
'	CONSTRAINT [DF__GL_accoun__Old_A__7AB2DD83] DEFAULT (0) FOR [Old_Amount_adjustment]
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_head] ADD 
'	CONSTRAINT [DF_GL_account_adjustment_head_finance_charge_flag_1] DEFAULT (0) FOR [finance_charge_flag],
'	CONSTRAINT [DF__GL_accoun__Old_A__6DC2F6B9] DEFAULT (0) FOR [Old_Amount_adjustment]
'GO

'ALTER TABLE [dbo].[GL_payment_deposit] ADD 
'	CONSTRAINT [DF_GL_payment_deposit_payment_amount] DEFAULT (0) FOR [payment_amount],
'	CONSTRAINT [DF_GL_payment_deposit_flag_deposit_bank] DEFAULT (0) FOR [flag_deposit_bank],
'	CONSTRAINT [DF__GL_paymen__Paid___7A67F969] DEFAULT (0) FOR [Paid_amount],
'	CONSTRAINT [DF__GL_paymen__Disco__7B5C1DA2] DEFAULT (0) FOR [Discount]
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_dtl] ADD 
'	CONSTRAINT [FK_GL_account_adjustment_dtl_GL_account_adjustment_head] FOREIGN KEY 
'	(
'		[refrence_no]
'	) REFERENCES [dbo].[GL_account_adjustment_head] (
'		[refrence_no]
'	) ON DELETE CASCADE  ON UPDATE CASCADE ,
'	CONSTRAINT [FK_GL_account_adjustment_dtl_service_center_head] FOREIGN KEY 
'	(
'		[id_service_center]
'	) REFERENCES [dbo].[service_center_head] (
'		[id_service_center]
'	)
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_dtl_dtl] ADD 
'	CONSTRAINT [FK_GL_account_adjustment_dtl_dtl_GL_account_adjustment_dtl] FOREIGN KEY 
'	(
'		[refrence_no_due],
'		[id_service_center_due]
'	) REFERENCES [dbo].[GL_account_adjustment_dtl] (
'		[refrence_no],
'		[id_service_center]
'	) ON DELETE CASCADE 
'GO

'ALTER TABLE [dbo].[GL_account_adjustment_head] ADD 
'	CONSTRAINT [FK_GL_account_adjustment_head_cust_trtab_main] FOREIGN KEY 
'	(
'		[cod_customer]
'	) REFERENCES [dbo].[cust_trtab_main] (
'		[cod_customer]
'	) ON UPDATE CASCADE ,
'	CONSTRAINT [FK_GL_account_adjustment_head_Gl_receive_payment] FOREIGN KEY 
'	(
'		[Gl_receive_payment_Refrence_no]
'	) REFERENCES [dbo].[Gl_receive_payment] (
'		[refrence_no]
'	) ON DELETE CASCADE 
'GO

'ALTER TABLE [dbo].[GL_payment_deposit] ADD 
'	CONSTRAINT [FK_GL_payment_deposit_GL_account_adjustment_head] FOREIGN KEY 
'	(
'		[refrence_no_Adjustment]
'	) REFERENCES [dbo].[GL_account_adjustment_head] (
'		[refrence_no]
'	),
'	CONSTRAINT [FK_GL_payment_deposit_GL_payment_AR] FOREIGN KEY 
'	(
'		[ID_payment]
'	) REFERENCES [dbo].[GL_payment_AR] (
'		[ID_payment]
'	),
'	CONSTRAINT [FK_GL_payment_deposit_GL_payment_cash] FOREIGN KEY 
'	(
'		[ID_payment]
'	) REFERENCES [dbo].[GL_payment_cash] (
'		[ID_payment]
'	),
'	CONSTRAINT [FK_GL_payment_deposit_GL_payment_check] FOREIGN KEY 
'	(
'		[ID_payment]
'	) REFERENCES [dbo].[GL_payment_check] (
'		[ID_payment]
'	),
'	CONSTRAINT [FK_GL_payment_deposit_Gl_receive_payment] FOREIGN KEY 
'	(
'		[refrence_no]
'	) REFERENCES [dbo].[Gl_receive_payment] (
'		[refrence_no]
'	) ON DELETE CASCADE  ON UPDATE CASCADE ,
'	CONSTRAINT [FK_GL_payment_deposit_service_center_head] FOREIGN KEY 
'	(
'		[id_service_center]
'	) REFERENCES [dbo].[service_center_head] (
'		[id_service_center]
'	)
'GO

'alter table [dbo].[GL_payment_deposit] nocheck constraint [FK_GL_payment_deposit_GL_payment_AR]
'GO

'alter table [dbo].[GL_payment_deposit] nocheck constraint [FK_GL_payment_deposit_GL_payment_cash]
'GO

'alter table [dbo].[GL_payment_deposit] nocheck constraint [FK_GL_payment_deposit_GL_payment_check]
'GO
'go
Imports CommonClass
Public Class FrmAssessFinanceCharge
    Inherits FrmBase
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaPardakt As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBedehi As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsAssessFinanceCharge1 As UcAccount.DsAssessFinanceCharge
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGLaccountadjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TxtAssessDate As CalendarCombo.CalendarCombo
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents BtnMarkAll As System.Windows.Forms.Button
    Friend WithEvents BtnUnmarkAll As System.Windows.Forms.Button
    Friend WithEvents CmdInsertIntoGLaccountadjustmenthead As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsertIntoGLaccountadjustmentDtl As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents Pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaView_Total_Balance_ForEach_ARDue As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPositiveAdjustment As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAssessFinanceCharge))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.TxtAssessDate = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChkPrint = New System.Windows.Forms.CheckBox
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsAssessFinanceCharge1 = New UcAccount.DsAssessFinanceCharge
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaPardakt = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaBedehi = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGLaccountadjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.BtnMarkAll = New System.Windows.Forms.Button
        Me.BtnUnmarkAll = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.BtnCalculate = New System.Windows.Forms.Button
        Me.CmdInsertIntoGLaccountadjustmenthead = New System.Data.SqlClient.SqlCommand
        Me.CmdInsertIntoGLaccountadjustmentDtl = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Pb1 = New System.Windows.Forms.ProgressBar
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaView_Total_Balance_ForEach_ARDue = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaPositiveAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAssessFinanceCharge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(766, 56)
        Me.Panel4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 32)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "To Calculate Finance Charges Select 'Assesment Date ' and then click on Assess Fi" & _
        "nance Charges Button"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(728, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(680, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 201
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(728, 0)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 200
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(688, 0)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 199
        '
        'TxtAssessDate
        '
        Me.TxtAssessDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAssessDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtAssessDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAssessDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtAssessDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtAssessDate.EditableSal = True
        Me.TxtAssessDate.Image = CType(resources.GetObject("TxtAssessDate.Image"), System.Drawing.Image)
        Me.TxtAssessDate.Location = New System.Drawing.Point(118, 72)
        Me.TxtAssessDate.MaxValue = CType(2500, Short)
        Me.TxtAssessDate.MinValue = CType(1800, Short)
        Me.TxtAssessDate.Name = "TxtAssessDate"
        Me.TxtAssessDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAssessDate.Sal_Mali = Nothing
        Me.TxtAssessDate.ShowButton = True
        Me.TxtAssessDate.Size = New System.Drawing.Size(120, 23)
        Me.TxtAssessDate.TabIndex = 8
        Me.TxtAssessDate.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Assessment date"
        '
        'ChkPrint
        '
        Me.ChkPrint.Location = New System.Drawing.Point(448, 72)
        Me.ChkPrint.Name = "ChkPrint"
        Me.ChkPrint.Size = New System.Drawing.Size(248, 24)
        Me.ChkPrint.TabIndex = 10
        Me.ChkPrint.Text = "Mark Account Adjustments ""To be printed """
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.AutoEdit = True
        Me.GridEX1.DataMember = "assess"
        Me.GridEX1.DataSource = Me.DsAssessFinanceCharge1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>True</AllowEdit><Caption>assess</Caption>" & _
        "<ChildTables Collection=""true""><Table0 ID=""assessAssessDtl""><Caption>assessAsses" & _
        "sDtl</Caption><Columns Collection=""true""><Column0 ID=""id_service_center""><Captio" & _
        "n>Invoice No</Caption><DataMember>id_service_center</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><Key>id_service_center</Key><" & _
        "Position>0</Position></Column0><Column1 ID=""FinanceCharge""><Caption>Finance Char" & _
        "ge</Caption><DataMember>FinanceCharge</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><FormatString>c</FormatString><Key>FinanceC" & _
        "harge</Key><Position>1</Position><TextAlignment>Far</TextAlignment></Column1></C" & _
        "olumns><DataMember>assessAssessDtl</DataMember><GroupCondition ID="""" /><Key>asse" & _
        "ssAssessDtl</Key></Table0></ChildTables><Columns Collection=""true""><Column0 ID=""" & _
        "Assess""><ColumnType>CheckBox</ColumnType><DataMember>Assess</DataMember><EditTyp" & _
        "e>CheckBox</EditType><Key>Assess</Key><Position>0</Position><Width>28</Width></C" & _
        "olumn0><Column1 ID=""LastFinanceCharge""><Caption>LastFinanceCharge</Caption><Type" & _
        "NameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /" & _
        "><DataMember>LastFinanceCharge</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>LastFinanceCharge</Key><Position>1</Position>" & _
        "<Selectable>False</Selectable><Width>109</Width></Column1><Column2 ID=""Customer " & _
        "Name""><Caption>Customer Name</Caption><TypeNameEmptyStringValue>System.String</T" & _
        "ypeNameEmptyStringValue><EmptyStringValue /><DataMember>CustomerName</DataMember" & _
        "><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Custome" & _
        "r Name</Key><Position>2</Position><Selectable>False</Selectable><Width>176</Widt" & _
        "h></Column2><Column3 ID=""Company""><Caption>Company</Caption><DataMember>Company<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>Company</Key><Position>3</Position><Selectable>False</Selectable><Width>181<" & _
        "/Width></Column3><Column4 ID=""PastDueAmount""><Caption>PastDueAmount</Caption><Da" & _
        "taMember>PastDueAmount</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><FormatString>c</FormatString><Key>PastDueAmount</Key><Pos" & _
        "ition>4</Position><Selectable>False</Selectable><TextAlignment>Far</TextAlignmen" & _
        "t><Width>113</Width></Column4><Column5 ID=""FinanceCharge""><Caption>FinanceCharge" & _
        "</Caption><DataMember>FinanceCharge</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><FormatString>c</FormatString><Key>FinanceCha" & _
        "rge</Key><Position>5</Position><Selectable>False</Selectable><TextAlignment>Far<" & _
        "/TextAlignment><Width>105</Width></Column5></Columns><GroupCondition ID="""" /><Ke" & _
        "y>assess</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(8, 112)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(752, 336)
        Me.GridEX1.TabIndex = 11
        '
        'DsAssessFinanceCharge1
        '
        Me.DsAssessFinanceCharge1.DataSetName = "DsAssessFinanceCharge"
        Me.DsAssessFinanceCharge1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=False;initial catalog=Tiremate_01"
        '
        'DaPardakt
        '
        Me.DaPardakt.SelectCommand = Me.SqlSelectCommand2
        Me.DaPardakt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Pardakt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Pardakt", "Pardakt"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Gl_receive_payment.date_receive_payment AS datepardakht, GL_payment_deposi" & _
        "t.refrence_no, GL_payment_deposit.id_service_center, GL_payment_deposit_Detail.I" & _
        "D_payment_due, GL_payment_deposit_Detail.ID_payment_Paid, GL_payment_deposit.pay" & _
        "ment_amount, cust_trtab_main.cod_customer FROM Gl_receive_payment INNER JOIN GL_" & _
        "payment_deposit ON Gl_receive_payment.refrence_no = GL_payment_deposit.refrence_" & _
        "no INNER JOIN GL_payment_deposit_Detail ON Gl_receive_payment.refrence_no = GL_p" & _
        "ayment_deposit_Detail.refrence_no AND GL_payment_deposit.ID_payment = GL_payment" & _
        "_deposit_Detail.ID_payment_Paid INNER JOIN cust_trtab_main ON Gl_receive_payment" & _
        ".cod_customer = cust_trtab_main.cod_customer WHERE (GL_payment_deposit.refer_typ" & _
        "e = '2') AND (dbo.ChangeDate(Gl_receive_payment.date_receive_payment) <= @ThisDa" & _
        "te) AND (cust_trtab_main.AR_finance_charge = 1) ORDER BY GL_payment_deposit_Deta" & _
        "il.ID_payment_due"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'DaBedehi
        '
        Me.DaBedehi.SelectCommand = Me.SqlCommand3
        Me.DaBedehi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("AR_due_date", "AR_due_date"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"), New System.Data.Common.DataColumnMapping("company", "company")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_payment_deposit.payment_amount, GL_payment_AR.AR_due_date, service_cent" & _
        "er_head.cod_customer, service_center_head.id_service_center, GL_payment_deposit." & _
        "ID_payment, GL_payment_deposit.payment_type, CASE cust_trtab_main.cod_customer W" & _
        "HEN NULL THEN RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRIM(LTRIM(cust_trta" & _
        "b_main.m_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) ELSE RTRIM(LTRIM(cu" & _
        "st_trtab_main.l_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.m_name)) + ' ' + RTRI" & _
        "M(LTRIM(cust_trtab_main.f_name)) END AS CustomerName, cust_company.complete_name" & _
        " AS company FROM cust_trtab_main INNER JOIN service_center_head ON cust_trtab_ma" & _
        "in.cod_customer = service_center_head.cod_customer LEFT OUTER JOIN cust_company " & _
        "ON cust_trtab_main.cod_company = cust_company.cod_company RIGHT OUTER JOIN GL_pa" & _
        "yment_AR LEFT OUTER JOIN GL_payment_deposit ON GL_payment_AR.ID_payment = GL_pay" & _
        "ment_deposit.ID_payment ON service_center_head.id_service_center = GL_payment_de" & _
        "posit.id_service_center WHERE (GL_payment_deposit.refer_type = '1') AND (GL_paym" & _
        "ent_deposit.payment_type = '4') AND (service_center_head.type_of_form = 'IN') AN" & _
        "D (GL_payment_deposit.id_service_center NOT IN (SELECT dbo.service_center_head.i" & _
        "d_service_center_before FROM service_center_head WHERE dbo.service_center_head.i" & _
        "d_service_center_before IS NOT NULL)) AND (dbo.ChangeDate(GL_payment_AR.AR_due_d" & _
        "ate) <= @ThisDate) AND (GL_payment_AR.Cancel_flag = 0) AND (cust_trtab_main.AR_f" & _
        "inance_charge = 1)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account_adjustment_head.cod_customer, SUM(GL_account_adjustment_dtl.amo" & _
        "unt_adjustment) AS Sumamount_adjustment, GL_account_adjustment_dtl.id_service_ce" & _
        "nter FROM GL_account_adjustment_head INNER JOIN GL_account_adjustment_dtl ON GL_" & _
        "account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no INNE" & _
        "R JOIN cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_m" & _
        "ain.cod_customer WHERE (dbo.ChangeDate(GL_account_adjustment_head.date_adjustmen" & _
        "t) <= @ThisDate) AND (GL_account_adjustment_head.finance_charge_flag = 0 OR GL_a" & _
        "ccount_adjustment_head.finance_charge_flag IS NULL) AND (cust_trtab_main.AR_fina" & _
        "nce_charge = 1) GROUP BY GL_account_adjustment_head.cod_customer, GL_account_adj" & _
        "ustment_dtl.id_service_center"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'DaGLaccountadjustment
        '
        Me.DaGLaccountadjustment.SelectCommand = Me.SqlSelectCommand1
        Me.DaGLaccountadjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Gl_receive_payment_Refrence_no", "Gl_receive_payment_Refrence_no")})})
        '
        'BtnMarkAll
        '
        Me.BtnMarkAll.Location = New System.Drawing.Point(16, 454)
        Me.BtnMarkAll.Name = "BtnMarkAll"
        Me.BtnMarkAll.TabIndex = 12
        Me.BtnMarkAll.Text = "Mark All"
        '
        'BtnUnmarkAll
        '
        Me.BtnUnmarkAll.Location = New System.Drawing.Point(96, 454)
        Me.BtnUnmarkAll.Name = "BtnUnmarkAll"
        Me.BtnUnmarkAll.TabIndex = 13
        Me.BtnUnmarkAll.Text = "UnMark All"
        '
        'CmdSave
        '
        Me.CmdSave.Location = New System.Drawing.Point(238, 454)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(122, 23)
        Me.CmdSave.TabIndex = 15
        Me.CmdSave.Text = "Save Charges"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(680, 454)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Cancel"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(248, 72)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(160, 23)
        Me.BtnCalculate.TabIndex = 17
        Me.BtnCalculate.Text = "Assess Finance Charges"
        '
        'CmdInsertIntoGLaccountadjustmenthead
        '
        Me.CmdInsertIntoGLaccountadjustmenthead.CommandText = "INSERT INTO GL_account_adjustment_head (refrence_no, cod_customer, amount_adjustm" & _
        "ent, date_adjustment, Remark, GL_account, id_GL_journal, Gl_receive_payment_Refr" & _
        "ence_no, Finance_Charge_Flag) VALUES (@refrence_no, @cod_customer, @amount_adjus" & _
        "tment, @date_adjustment, @Remark, @GL_account, @id_GL_journal, @Gl_receive_payme" & _
        "nt_Refrence_no, @Finance_Charge_Flag)"
        Me.CmdInsertIntoGLaccountadjustmenthead.Connection = Me.Cnn
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_adjustment", System.Data.SqlDbType.Money, 8, "amount_adjustment"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remark", System.Data.SqlDbType.VarChar, 100, "Remark"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_receive_payment_Refrence_no", System.Data.SqlDbType.VarChar, 8, "Gl_receive_payment_Refrence_no"))
        Me.CmdInsertIntoGLaccountadjustmenthead.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Finance_Charge_Flag", System.Data.SqlDbType.Bit, 1, "Finance_Charge_Flag"))
        '
        'CmdInsertIntoGLaccountadjustmentDtl
        '
        Me.CmdInsertIntoGLaccountadjustmentDtl.CommandText = "INSERT INTO GL_account_adjustment_dtl (refrence_no, id_service_center, amount_adj" & _
        "ustment) VALUES (@refrence_no, @id_service_center, @amount_adjustment)"
        Me.CmdInsertIntoGLaccountadjustmentDtl.Connection = Me.Cnn
        Me.CmdInsertIntoGLaccountadjustmentDtl.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.CmdInsertIntoGLaccountadjustmentDtl.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.CmdInsertIntoGLaccountadjustmentDtl.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_adjustment", System.Data.SqlDbType.Money, 8, "amount_adjustment"))
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Pb1
        '
        Me.Pb1.Location = New System.Drawing.Point(17, 482)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Size = New System.Drawing.Size(743, 16)
        Me.Pb1.TabIndex = 18
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT View_Total_Balance_ForEach_ARDue.id_service_center, View_Total_Balance_For" & _
        "Each_ARDue.ID_payment, View_Total_Balance_ForEach_ARDue.BalanceAmount, View_Tota" & _
        "l_Balance_ForEach_ARDue.AR_Adj_Amount, View_Total_Balance_ForEach_ARDue.TotalArB" & _
        "alanceAmount, GL_payment_AR.AR_due_date, CASE cust_trtab_main.cod_customer WHEN " & _
        "NULL THEN RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRIM(LTRIM(cust_trtab_ma" & _
        "in.m_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) ELSE RTRIM(LTRIM(cust_t" & _
        "rtab_main.l_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.m_name)) + ' ' + RTRIM(LT" & _
        "RIM(cust_trtab_main.f_name)) END AS CustomerName, cust_company.complete_name AS " & _
        "company, cust_trtab_main.cod_customer FROM cust_company RIGHT OUTER JOIN cust_tr" & _
        "tab_main INNER JOIN View_Total_Balance_ForEach_ARDue INNER JOIN service_center_h" & _
        "ead ON View_Total_Balance_ForEach_ARDue.id_service_center = service_center_head." & _
        "id_service_center INNER JOIN GL_payment_AR ON View_Total_Balance_ForEach_ARDue.I" & _
        "D_payment = GL_payment_AR.ID_payment ON cust_trtab_main.cod_customer = service_c" & _
        "enter_head.cod_customer ON cust_company.cod_company = cust_trtab_main.cod_compan" & _
        "y WHERE (View_Total_Balance_ForEach_ARDue.TotalArBalanceAmount > 0) AND (dbo.Cha" & _
        "ngeDate(GL_payment_AR.AR_due_date) <= @ThisDate) AND (service_center_head.type_o" & _
        "f_form = 'IN') AND (cust_trtab_main.AR_finance_charge = 1) ORDER BY cust_trtab_m" & _
        "ain.cod_customer"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO View_Total_Balance_ForEach_ARDue(id_service_center, ID_payment, Balan" & _
        "ceAmount, AR_Adj_Amount, TotalArBalanceAmount) VALUES (@id_service_center, @ID_p" & _
        "ayment, @BalanceAmount, @AR_Adj_Amount, @TotalArBalanceAmount); SELECT id_servic" & _
        "e_center, ID_payment, BalanceAmount, AR_Adj_Amount, TotalArBalanceAmount FROM Vi" & _
        "ew_Total_Balance_ForEach_ARDue"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BalanceAmount", System.Data.SqlDbType.Money, 8, "BalanceAmount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_Adj_Amount", System.Data.SqlDbType.Money, 8, "AR_Adj_Amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalArBalanceAmount", System.Data.SqlDbType.Money, 8, "TotalArBalanceAmount"))
        '
        'DaView_Total_Balance_ForEach_ARDue
        '
        Me.DaView_Total_Balance_ForEach_ARDue.InsertCommand = Me.SqlInsertCommand1
        Me.DaView_Total_Balance_ForEach_ARDue.SelectCommand = Me.SqlSelectCommand3
        Me.DaView_Total_Balance_ForEach_ARDue.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_Total_Balance_ForEach_ARDue", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount"), New System.Data.Common.DataColumnMapping("AR_Adj_Amount", "AR_Adj_Amount"), New System.Data.Common.DataColumnMapping("TotalArBalanceAmount", "TotalArBalanceAmount")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CASE cust_trtab_main.cod_customer WHEN NULL THEN RTRIM(LTRIM(cust_trtab_ma" & _
        "in.l_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.m_name)) + ' ' + RTRIM(LTRIM(cus" & _
        "t_trtab_main.f_name)) ELSE RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRIM(LT" & _
        "RIM(cust_trtab_main.m_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) END AS" & _
        " CustomerName, cust_company.complete_name AS company, GL_account_adjustment_dtl." & _
        "refrence_no + '/' + GL_account_adjustment_dtl.id_service_center AS id_service_ce" & _
        "nter, GL_account_adjustment_head.date_adjustment AS AR_due_date, ISNULL(View_Adj" & _
        "ustment_Balance.BalanceAmount, 0) AS TotalArBalanceAmount, GL_account_adjustment" & _
        "_head.cod_customer FROM GL_account_adjustment_dtl INNER JOIN cust_trtab_main INN" & _
        "ER JOIN GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_" & _
        "adjustment_head.cod_customer ON GL_account_adjustment_dtl.refrence_no = GL_accou" & _
        "nt_adjustment_head.refrence_no LEFT OUTER JOIN View_Adjustment_Balance ON GL_acc" & _
        "ount_adjustment_dtl.refrence_no = View_Adjustment_Balance.refrence_no_due LEFT O" & _
        "UTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company" & _
        " WHERE (dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) <= @ThisDate)" & _
        " AND (GL_account_adjustment_head.finance_charge_flag = 0) AND (ISNULL(View_Adjus" & _
        "tment_Balance.BalanceAmount, 0) > 0) ORDER BY cust_trtab_main.cod_customer"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'DaPositiveAdjustment
        '
        Me.DaPositiveAdjustment.SelectCommand = Me.SqlSelectCommand4
        Me.DaPositiveAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_quarts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quarts", "cod_quarts"), New System.Data.Common.DataColumnMapping("desc_quarts", "desc_quarts")})})
        '
        'FrmAssessFinanceCharge
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(766, 500)
        Me.Controls.Add(Me.Pb1)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.BtnUnmarkAll)
        Me.Controls.Add(Me.BtnMarkAll)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.ChkPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAssessDate)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmAssessFinanceCharge"
        Me.Text = "Assess Finance Charge "
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAssessFinanceCharge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds1 As New DataSet
    Dim DsTmp As New DataSet
    Dim FinanceChargePercentage As Double
    Dim FinanceChargeAmmount As Decimal
    Dim FinanceChargeAccount As String = ""
    Public FinanceChargeDate As String = ""
    Private Sub FrmAssessFinanceCharge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '--------------------------------------------
        Cnn.ConnectionString = PConnectionString
        TxtAssessDate.Text = Format(Now.Date, PubDateFormat)
        Pb1.Visible = False
        If FinanceChargeDate <> "" Then
            TxtAssessDate.Text = FinanceChargeDate
            'Call FillAll()
            Call FillAll2()
        End If
        '---------------------------------------------------
    End Sub
    '----------------------------
    Sub FindAllAdjustMent()
        Try
            DsAssessFinanceCharge1.GL_account_adjustment_head.Clear()
        Catch ex As Exception
        End Try
        DaGLaccountadjustment.SelectCommand.Parameters("@ThisDate").Value = Mid(TxtAssessDate.Text, 7, 4) + "/" + Mid(TxtAssessDate.Text, 1, 2) + "/" + Mid(TxtAssessDate.Text, 4, 2)
        DaGLaccountadjustment.Fill(DsAssessFinanceCharge1.GL_account_adjustment_head)
    End Sub

    Sub FindAllPardakt()
        Try
            DsAssessFinanceCharge1.Pardakt.Clear()
        Catch ex As Exception
        End Try
        DaPardakt.SelectCommand.Parameters("@ThisDate").Value = Mid(TxtAssessDate.Text, 7, 4) + "/" + Mid(TxtAssessDate.Text, 1, 2) + "/" + Mid(TxtAssessDate.Text, 4, 2)
        DaPardakt.Fill(DsAssessFinanceCharge1.Pardakt)
    End Sub
    '----------------------------
    Sub FindAllBedehi()
        Try
            DsAssessFinanceCharge1.Bedehi.Clear()
        Catch ex As Exception
        End Try
        DaBedehi.SelectCommand.Parameters("@ThisDate").Value = Mid(TxtAssessDate.Text, 7, 4) + "/" + Mid(TxtAssessDate.Text, 1, 2) + "/" + Mid(TxtAssessDate.Text, 4, 2)
        Try
            DaBedehi.Fill(DsAssessFinanceCharge1.Bedehi)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub FillAll2()
        ds1.Clear()
        Dim _Cod_Customer As String = ""
        Dim MinimumFinanaceCharge As Decimal = 0
        DsAssessFinanceCharge1.GL_account_adjustment_head.Clear()
        DsAssessFinanceCharge1.AssessDtl.Clear()
        DsAssessFinanceCharge1.assess.Clear()
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader = RetrieveAccountsReceivableSetupTable()
        FinanceChargePercentage = CDec(OleDbReader.Item("Default_annual_finance_charge") / 100)
        If FinanceChargePercentage = 0 Then
            MsgBox("Default_annual_finance_charge is 0 and all finance charge will be 0 please correct mdb file")
            FinanceChargePercentage = 0.1
        End If
        FinanceChargeAmmount = FinanceChargePercentage / 365
        FinanceChargeAccount = OleDbReader.Item("Default_Finance_Charge_GL_Account")
        MinimumFinanaceCharge = Val("0" & OleDbReader.Item("Default_minimum_finance_charge"))
        '------------------------------------------
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim FromDate As Date
        Dim ToDate As Date
        Dim _FinanceChargeDay As Integer = 0
        Dim IN_FinanceCharge As Decimal = 0
        Dim _FinanceCharge As Double
        Dim FlgAdd As Boolean = False
        Dim codcustomer As String = ""
        DaView_Total_Balance_ForEach_ARDue.SelectCommand.Parameters("@ThisDate").Value = Mid(TxtAssessDate.Text, 7, 4) + "/" + Mid(TxtAssessDate.Text, 1, 2) + "/" + Mid(TxtAssessDate.Text, 4, 2)
        DaPositiveAdjustment.SelectCommand.Parameters("@ThisDate").Value = Mid(TxtAssessDate.Text, 7, 4) + "/" + Mid(TxtAssessDate.Text, 1, 2) + "/" + Mid(TxtAssessDate.Text, 4, 2)
        Try
            DaView_Total_Balance_ForEach_ARDue.Fill(ds1, "t1")
            DaPositiveAdjustment.Fill(ds1, "t1")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'GridEX1.DataSource = ds1
        'GridEX1.DataMember = "t1"
        'GridEX1.Refetch()
        'GridEX1.Visible = True

        Dim t1 As DataTable = ds1.Tables("t1")
        For i = 0 To t1.Rows.Count - 1
            With t1.Rows(i)
                codcustomer = (.Item("Cod_Customer") & "")
                If codcustomer.Trim.ToUpper = "PRICLE" Then
                    'MsgBox("!")
                End If
                Dim dr1 As DsAssessFinanceCharge.assessRow = DsAssessFinanceCharge1.assess.FindBycod_customer(codcustomer)
                If dr1 Is Nothing Then
                    dr1 = DsAssessFinanceCharge1.assess.NewassessRow()
                    dr1.PastDueAmount = 0
                    FlgAdd = True
                Else
                    FlgAdd = False
                End If
                FromDate = CDate(.Item("AR_due_date"))
                ToDate = TxtAssessDate.Text
                dr1.Assess = True
                Dim d2 As Date = BeginDateOfCalculate(.Item("cod_customer"), FromDate)
                ' Find Max Date GL_account_adjustment_head
                If d2 > FromDate Then
                    FromDate = d2
                End If
                dr1.LastFinanceCharge = Format(FromDate, PubDateFormat)
                dr1.cod_customer = codcustomer
                dr1.CustomerName = Trim(.Item("CustomerName") & "")
                dr1.Company = Trim(.Item("Company") & "")

                'dr1.FinanceCharge = 0
                ' Dim _Mandeh As Double = MandehForThis(DsAssessFinanceCharge1.Bedehi.Rows(i))
                dr1.PastDueAmount = Math.Round(Val(dr1.PastDueAmount & ""), 2) + Math.Round(Val(.Item("TotalArBalanceAmount") & ""), 2) 'MandehForThis(DsAssessFinanceCharge1.Bedehi.Rows(i))   'Val(.Item("payment_amount") & "")
                _FinanceChargeDay = DateDiff(DateInterval.Day, FromDate, ToDate)

                IN_FinanceCharge = Math.Round(FinanceChargePercentage * _FinanceChargeDay * Val(.Item("TotalArBalanceAmount") & "") / 365, 2)
                _FinanceCharge = Math.Round(Val(dr1("FinanceCharge") & "") + IN_FinanceCharge, 2)
                dr1.FinanceCharge = _FinanceCharge
                If _FinanceChargeDay > 0 Then
                    dr1.FinanceChargeDay = Val(dr1("FinanceChargeDay") & "") + _FinanceChargeDay
                    If FlgAdd And _FinanceCharge > 0 Then
                        DsAssessFinanceCharge1.assess.AddassessRow(dr1)
                    End If
                End If
                ' Write in Detail
                FlgAdd = False
                Dim dr2 As DsAssessFinanceCharge.AssessDtlRow '= DsAssessFinanceCharge1.AssessDtl.FindBycod_customerid_service_center(.Item("Cod_Customer"), .Item("id_service_center"))
                dr2 = DsAssessFinanceCharge1.AssessDtl.FindBycod_customerid_service_center(codcustomer, .Item("id_Service_center"))
                If dr2 Is Nothing Then   'Math.Round((FinanceChargeAmmount * _FinanceChargeDay * Val(.Item("TotalArBalanceAmount") & "")), 2) > 0 Then
                    If IN_FinanceCharge > 0 Then
                        dr2 = DsAssessFinanceCharge1.AssessDtl.NewAssessDtlRow()
                        dr2.FinanceCharge = 0
                        FlgAdd = True
                        dr2.cod_customer = codcustomer
                        dr2.id_service_center = .Item("id_Service_center")
                        dr2.FinanceCharge = IN_FinanceCharge
                        Try
                            DsAssessFinanceCharge1.AssessDtl.AddAssessDtlRow(dr2)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    dr2.FinanceCharge = IN_FinanceCharge + dr2.FinanceCharge

                End If
            End With
        Next
        For i = 0 To DsAssessFinanceCharge1.assess.Rows.Count - 1
            With DsAssessFinanceCharge1.assess.Rows(i)
                If .Item("FinanceCharge") < MinimumFinanaceCharge Then
                    Dim mandeh As Decimal = MinimumFinanaceCharge - .Item("FinanceCharge")
                    .Item("FinanceCharge") = MinimumFinanaceCharge
                    Dim dr() As DataRow = DsAssessFinanceCharge1.AssessDtl.Select("cod_customer= " & Qt(.Item("cod_customer")))
                    If dr.Length > 0 Then
                        dr(0).Item("FinanceCharge") = dr(0).Item("FinanceCharge") + mandeh
                    End If
                End If
            End With

        Next



    End Sub

    Sub FillAll()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim _Cod_Customer As String = ""
        Dim _Pardakt As Decimal = 0
        Dim MinimumFinanaceCharge As Decimal = 0
        DsAssessFinanceCharge1.GL_account_adjustment_head.Clear()
        DsAssessFinanceCharge1.AssessDtl.Clear()
        DsAssessFinanceCharge1.assess.Clear()
        DsAssessFinanceCharge1.Bedehi.Clear()
        DsAssessFinanceCharge1.Pardakt.Clear()
        '-------------------
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader = RetrieveAccountsReceivableSetupTable()
        FinanceChargePercentage = CDec(OleDbReader.Item("Default_annual_finance_charge") / 100)
        FinanceChargeAmmount = FinanceChargePercentage / 365
        FinanceChargeAccount = OleDbReader.Item("Default_Finance_Charge_GL_Account")
        MinimumFinanaceCharge = Val("0" & OleDbReader.Item("Default_minimum_finance_charge"))
        Call FindAllBedehi()
        Call FindAllPardakt()
        Call FindAllAdjustMent()

        '-˜ã ˜ÑÏä ÑÏÇÎÊåÇ ÇÒ ÈÏåíåÇ
        'For i = 0 To DsAssessFinanceCharge1.Pardakt.Rows.Count - 1
        '    _Cod_Customer = DsAssessFinanceCharge1.Pardakt.Rows(i).Item("cod_customer")
        '    _Pardakt = DsAssessFinanceCharge1.Pardakt.Rows(i).Item("Pardakt")
        '    Dim d1 As DataRow() = DsAssessFinanceCharge1.Bedehi.Select("Cod_customer =" & Qt(_Cod_Customer))
        '    For j = 0 To d1.LongLength
        '        If d1(j).Item("payment_amount") > 0 Then
        '            If _Pardakt - d1(j).Item("payment_amount") >= 0 Then
        '                _Pardakt = _Pardakt - d1(j).Item("payment_amount")
        '                d1(j).Item("payment_amount") = 0
        '            Else
        '                d1(j).Item("payment_amount") = d1(j).Item("payment_amount") - _Pardakt
        '            End If
        '        End If
        '    Next
        'Next
        '-˜ã ˜ÑÏä ÑÏÇÎÊåÇ ÇÒ ÈÏåíåÇ
        'End
        '--------------------------------------------------
        Dim FromDate As Date
        Dim ToDate As Date
        Dim _FinanceChargeDay As Integer = 0
        Dim _FinanceCharge As Double
        Dim FlgAdd As Boolean = False
        Dim codcustomer As String = ""
        For i = 0 To DsAssessFinanceCharge1.Bedehi.Rows.Count - 1
            Try
                With DsAssessFinanceCharge1.Bedehi.Rows(i)
                    codcustomer = (.Item("Cod_Customer") & "")
                    Dim dr1 As DsAssessFinanceCharge.assessRow = DsAssessFinanceCharge1.assess.FindBycod_customer(codcustomer)
                    If dr1 Is Nothing Then
                        dr1 = DsAssessFinanceCharge1.assess.NewassessRow()
                        dr1.PastDueAmount = 0
                        FlgAdd = True
                    Else
                        FlgAdd = False
                    End If
                    FromDate = CDate(.Item("AR_due_date"))   'CType(.Item("AR_due_date"), Date)
                    ToDate = TxtAssessDate.Text               'Format(CType(.Item("AR_due_date"), Date), "yyyy/MM/dd")
                    dr1.Assess = True
                    Dim d2 As Date = BeginDateOfCalculate(.Item("cod_customer"), FromDate)
                    ' Find Max Date GL_account_adjustment_head
                    If d2 > FromDate Then
                        FromDate = d2
                    End If
                    'If d2 <> "" Then
                    '    If Mid(d2, 7, 4) + "/" + Mid(d2, 1, 2) + "/" + Mid(d2, 4, 2) > Mid(FromDate, 7, 4) + "/" + Mid(FromDate, 1, 2) + "/" + Mid(FromDate, 4, 2) Then
                    '        FromDate = CDate(d2)
                    '    End If
                    'End If
                    dr1.LastFinanceCharge = Format(FromDate, PubDateFormat)
                    dr1.cod_customer = codcustomer
                    dr1.CustomerName = Trim(.Item("CustomerName") & "")
                    dr1.Company = Trim(.Item("Company") & "")

                    'dr1.FinanceCharge = 0
                    Dim _Mandeh As Double = MandehForThis(DsAssessFinanceCharge1.Bedehi.Rows(i))
                    dr1.PastDueAmount = Val(dr1.PastDueAmount & "") + _Mandeh  'MandehForThis(DsAssessFinanceCharge1.Bedehi.Rows(i))   'Val(.Item("payment_amount") & "")
                    _FinanceChargeDay = DateDiff(DateInterval.Day, FromDate, ToDate)
                    _FinanceCharge = Math.Round(Val(dr1("FinanceCharge") & "") + FinanceChargeAmmount * _FinanceChargeDay * _Mandeh, 2)  'Val(.Item("payment_amount") & "")
                    If _FinanceCharge > MinimumFinanaceCharge Then
                        dr1.FinanceCharge = _FinanceCharge 'Val(dr1.FinanceCharge & "") + FinanceChargeAmmount * _FinanceChargeDay * Val(.Item("payment_amount") & "")
                    Else
                        If _FinanceCharge > 0 Then
                            dr1.FinanceCharge = MinimumFinanaceCharge
                        End If
                    End If
                    If _FinanceChargeDay > 0 Then
                        dr1.FinanceChargeDay = Val(dr1("FinanceChargeDay") & "") + _FinanceChargeDay
                        If FlgAdd And _FinanceCharge > 0 Then
                            DsAssessFinanceCharge1.assess.AddassessRow(dr1)
                        End If
                    End If
                    ' Write in Detail
                    FlgAdd = False
                    Dim dr2 As DsAssessFinanceCharge.AssessDtlRow '= DsAssessFinanceCharge1.AssessDtl.FindBycod_customerid_service_center(.Item("Cod_Customer"), .Item("id_service_center"))
                    dr2 = DsAssessFinanceCharge1.AssessDtl.FindBycod_customerid_service_center(codcustomer, .Item("id_Service_center"))
                    If dr2 Is Nothing Then
                        dr2 = DsAssessFinanceCharge1.AssessDtl.NewAssessDtlRow()
                        dr2.FinanceCharge = 0
                        FlgAdd = True
                    End If

                    dr2.cod_customer = codcustomer
                    dr2.id_service_center = .Item("id_Service_center")
                    _FinanceCharge = Math.Round(dr2.FinanceCharge + (FinanceChargeAmmount * _FinanceChargeDay * _Mandeh), 2)
                    If _FinanceCharge > MinimumFinanaceCharge Then
                        dr2.FinanceCharge = _FinanceCharge
                    Else
                        If _FinanceCharge > 0 Then
                            dr2.FinanceCharge = MinimumFinanaceCharge
                        End If
                    End If
                    'dr2.FinanceCharge = dr2.FinanceCharge + (FinanceChargeAmmount * _FinanceChargeDay * _Mandeh)
                    If FlgAdd And (FinanceChargeAmmount * _FinanceChargeDay * _Mandeh) > 0 Then
                        Try
                            DsAssessFinanceCharge1.AssessDtl.AddAssessDtlRow(dr2)
                        Catch ex As Exception
                            ' MsgBox(EX.ToString + codcustomer)
                        End Try

                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub
    Function MandehForThis(ByVal thisrow As DsAssessFinanceCharge.BedehiRow) As Decimal
        MandehForThis = 0
        Dim adjustment As Decimal = 0
        Try
            adjustment = DsAssessFinanceCharge1.GL_account_adjustment_head.FindBycod_customerid_service_center(thisrow.cod_customer, thisrow.id_service_center).Sumamount_adjustment()
        Catch ex As Exception
            adjustment = 0
        End Try
        MandehForThis = Val(thisrow.payment_amount & "") - Val(DsAssessFinanceCharge1.Pardakt.Compute("sum(payment_amount)", " id_payment_Due =" & thisrow.ID_payment) & "") + adjustment
        If MandehForThis < 0 Then
            MandehForThis = 0
        End If
    End Function
    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        'Call FillAll()
        Call FillAll2()
    End Sub
    Private Sub BtnMarkall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarkAll.Click
        Dim i As Integer = 0
        For i = 0 To DsAssessFinanceCharge1.assess.Rows.Count - 1
            DsAssessFinanceCharge1.assess.Rows(i).Item("Assess") = 1
        Next
        GridEX1.Refetch()
    End Sub
    Private Sub BtnUnmarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnmarkAll.Click
        Dim i As Integer = 0
        For i = 0 To DsAssessFinanceCharge1.assess.Rows.Count - 1
            DsAssessFinanceCharge1.assess.Rows(i).Item("Assess") = False
        Next
        GridEX1.Refetch()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim AskForPrint As New FrmWhatDoForMenu
        AskForPrint.BtnLeftText = "No"
        AskForPrint.BtnRightText = "Yes"
        AskForPrint.Text = "Finance Charges Print"
        AskForPrint.ShowFarMsg("Would you like to print these Finance Charges?")
        If AskForPrint.DialogResult = DialogResult.OK Then
            Call pprint("priv")
        End If
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Ok"
        c1.Text = "Finance Charges Warning"
        c1.ShowFarMsg("This Operation Will add finance charges to the customer balance")
        '-------------------------------------- 
        If c1.DialogResult = DialogResult.OK Then
            Try
                Pb1.Visible = True
                'Pb1.Maximum = DsAssessFinanceCharge1.Bedehi.Rows.Count + 1
                'For i = 0 To DsAssessFinanceCharge1.Bedehi.Rows.Count - 1
                Pb1.Maximum = DsAssessFinanceCharge1.assess.Rows.Count + 1
                For i = 0 To DsAssessFinanceCharge1.assess.Rows.Count - 1
                    Pb1.Value = i
                    'Dim dr6 As DataRow = DsAssessFinanceCharge1.assess.FindBycod_customer(DsAssessFinanceCharge1.Bedehi.Rows(i).Item("Cod_Customer"))
                    Dim dr6 As DataRow = DsAssessFinanceCharge1.assess.Rows(i)
                    If Not dr6 Is Nothing Then
                        If dr6("Assess") = True Then
                            With DsAssessFinanceCharge1.assess.Rows(i)
                                ';If .Item("Assess") = True Then

                                Dim Reference_no As String = MakeNewReferenceNo()
                                If Reference_no.ToUpper <> "Error".ToUpper Then
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@refrence_no").Value = Reference_no 'last
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@cod_customer").Value = .Item("Cod_customer") 'last
                                    Dim dr3 As DsAssessFinanceCharge.assessRow = DsAssessFinanceCharge1.assess.FindBycod_customer(.Item("Cod_customer"))
                                    If Not dr3 Is Nothing Then 'ÌãÚ ˜á Invoice For Each Customer
                                        CmdInsertIntoGLaccountadjustmenthead.Parameters("@amount_adjustment").Value = dr3.FinanceCharge
                                    Else
                                        CmdInsertIntoGLaccountadjustmenthead.Parameters("@amount_adjustment").Value = -1 'Error
                                    End If
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@date_adjustment").Value = TxtAssessDate.Text
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@Remark").Value = "Finance Charge" 'last
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@GL_account").Value = FinanceChargeAccount & "" 'last
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@id_GL_journal").Value = System.DBNull.Value 'last
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@Gl_receive_payment_Refrence_no").Value = System.DBNull.Value
                                    'CmdInsertIntoGLaccountadjustmenthead.Parameters("@amount_adjustment").Value = DsAssessFinanceCharge1.assess.FindBycod_customer(DsAssessFinanceCharge1.Bedehi.Rows(i).Item("Cod_Customer")).FinanceCharge
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@amount_adjustment").Value = DsAssessFinanceCharge1.assess.Rows(i).Item("FinanceCharge")
                                    CmdInsertIntoGLaccountadjustmenthead.Parameters("@Finance_Charge_Flag").Value = 1
                                    If CmdInsertIntoGLaccountadjustmenthead.Connection.State <> ConnectionState.Open Then
                                        CmdInsertIntoGLaccountadjustmenthead.Connection.Open()
                                    End If
                                    Try
                                        CmdInsertIntoGLaccountadjustmenthead.ExecuteNonQuery()
                                    Catch ex As Exception
                                        MsgFar("Error In Save Please Try Again")
                                    End Try
                                    CmdInsertIntoGLaccountadjustmenthead.Connection.Close()
                                    Dim Dr4 As DataRow() = DsAssessFinanceCharge1.AssessDtl.Select("cod_customer =" & Qt(.Item("Cod_Customer")))
                                    For j = 0 To Dr4.LongLength - 1
                                        'INSERT INTO GL_account_adjustment_dtl (refrence_no, id_service_center, amount_adjustment) VALUES (@refrence_no, @id_service_center, @amount_adjustment)
                                        Dim InvoceNo1 As String = Findid_service_center(Dr4(j).Item("id_service_center"))
                                        CmdGeneral.CommandText = " Select top 1 id_service_center  from GL_account_adjustment_dtl where refrence_no = " & Qt(Reference_no) & " and  id_service_center=" & Qt(InvoceNo1)
                                        If CmdGeneral.Connection.State <> ConnectionState.Open Then
                                            CmdGeneral.Connection.Open()
                                        End If

                                        If CmdGeneral.ExecuteScalar() & "" <> "" Then
                                            CmdGeneral.CommandText = " update GL_account_adjustment_dtl set amount_adjustment = amount_adjustment + " & Dr4(j).Item("FinanceCharge") & " where  refrence_no = " & Qt(Reference_no) & " And id_service_center = " & Qt(InvoceNo1)
                                            CmdGeneral.ExecuteNonQuery()
                                        Else

                                            CmdInsertIntoGLaccountadjustmentDtl.Parameters("@refrence_no").Value = Reference_no
                                            CmdInsertIntoGLaccountadjustmentDtl.Parameters("@id_service_center").Value = InvoceNo1 ' Findid_service_center(Dr4(j).Item("id_service_center"))
                                            CmdInsertIntoGLaccountadjustmentDtl.Parameters("@amount_adjustment").Value = Dr4(j).Item("FinanceCharge")
                                            If CmdInsertIntoGLaccountadjustmentDtl.Connection.State <> ConnectionState.Open Then
                                                CmdInsertIntoGLaccountadjustmentDtl.Connection.Open()
                                            End If
                                            CmdInsertIntoGLaccountadjustmentDtl.ExecuteNonQuery()

                                        End If

                                        Try

                                            'Dtl_Dtl
                                            Dim _TopId As Decimal = 0
                                            CmdGeneral.CommandText = "SELECT  top 1   ID_payment   FROM GL_payment_deposit   WHERE   (payment_type = '4') AND (refer_type = '1') AND (id_service_center= " & Qt(InvoceNo1) & ")"
                                            _TopId = CmdGeneral.ExecuteScalar
                                            Dim wherecond As String = " refrence_no_due = " & Qt(Reference_no) & " and id_service_center_due = " & Qt(InvoceNo1) & " and  id_payment = " & _TopId & " and IDGL_account_adjustment_dtl_Due  is null"
                                            CmdGeneral.CommandText = " select top 1 refrence_no_due from  GL_account_adjustment_dtl_dtl where " + wherecond
                                            If CmdGeneral.ExecuteScalar & "" <> "" Then
                                                CmdGeneral.CommandText = " Update GL_account_adjustment_dtl_dtl set amount_adjustment = amount_adjustment + " & Dr4(j).Item("FinanceCharge") & " Where " & wherecond
                                            Else
                                                CmdGeneral.CommandText = "Insert Into GL_account_adjustment_dtl_dtl  (refrence_no_due,id_service_center_due,ID_payment,IDGL_account_adjustment_dtl_Due,amount_adjustment) values (" & _
                                                                                    Qt(Reference_no) & " , " & Qt(InvoceNo1) & " , " & _TopId & ", null ," & Dr4(j).Item("FinanceCharge") & " )"
                                            End If

                                            CmdGeneral.ExecuteNonQuery()
                                        Catch ex As Exception

                                        End Try

                                        CmdInsertIntoGLaccountadjustmentDtl.Connection.Close()
                                    Next
                                Else
                                    MsgFar("Error In Make New Adjustment No")
                                End If

                            End With
                        End If
                    End If
                Next
                DsAssessFinanceCharge1.Clear()
                TxtAssessDate.Focus()
                Pb1.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Function MakeNewReferenceNo() As String


        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(Refrence_No) as Max_cod from GL_account_adjustment_head WHERE substring(Refrence_No,1,2)='AA'"
            MakeNewReferenceNo = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewReferenceNo, LenAccountAdjustmentReferenceNo)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewReferenceNo.Length >= i Then
                MakeNewReferenceNo = Mid(MakeNewReferenceNo, 1, Len(MakeNewReferenceNo) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewReferenceNo.Trim.Length > LenAccountAdjustmentReferenceNo Then
                MakeNewReferenceNo = "AA000001"
            End If
        Catch ex As Exception
            MakeNewReferenceNo = "AA000001"
        Finally
            CmdGeneral.Connection.Close()
        End Try




        'Dim i As Integer
        'Dim ValMakeNewcod As String
        'Try
        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '        CmdGeneral.Connection.Open()
        '    End If
        '    CmdGeneral.CommandText = "Select Max(Refrence_No) as Max_cod from GL_account_adjustment_head WHERE substring(Refrence_No,1,2)='AA'"
        '    MakeNewReferenceNo = Trim(CmdGeneral.ExecuteScalar & "")
        '    ValMakeNewcod = Val(GetVal(MakeNewReferenceNo, LenAccountAdjustmentReferenceNo))
        '    If ValMakeNewcod > 0 Then
        '        i = Len(ValMakeNewcod)
        '    Else
        '        i = 0
        '    End If
        '    If MakeNewReferenceNo.Length >= i Then
        '        MakeNewReferenceNo = Mid(MakeNewReferenceNo, 1, Len(MakeNewReferenceNo) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
        '    End If
        '    If MakeNewReferenceNo.Trim.Length > LenAccountAdjustmentReferenceNo Then
        '        MakeNewReferenceNo = "AA000001"
        '    End If
        'Catch ex As Exception
        '    MakeNewReferenceNo = "Error"
        'Finally
        '    CmdGeneral.Connection.Close()
        'End Try
    End Function
    Private Function BeginDateOfCalculate(ByVal Cod_Customer As String, ByVal FromDate As Date) As Date
        Dim i As Integer
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max( dbo.changedate(date_adjustment)) as Max_Date from GL_account_adjustment_head WHERE   Finance_Charge_Flag=1 and cod_customer=" & Qt(Cod_Customer)
            BeginDateOfCalculate = Format(CDate(CmdGeneral.ExecuteScalar & ""), PubDateFormat)
        Catch ex As Exception
            BeginDateOfCalculate = FromDate
        Finally
            CmdGeneral.Connection.Close()
        End Try
        Return BeginDateOfCalculate
    End Function

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("priv")
    End Sub

    Private Sub pprint(ByVal type As String)

        Dim rpt As New RepAssessFinanceCharge
        Dim prn As New FrmRepView

        rpt.SetParameterValue("Parstorename", PubCompanyName & "")
        rpt.SetParameterValue("Parstorno", PubStoreName & "")

        rpt.SetParameterValue("pardate", Format(Now(), PubDateFormat))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", "Finance Charge Report")
        rpt.SetDataSource(DsAssessFinanceCharge1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("print")
    End Sub


    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
        If Mid(GridEX1.GetRow.Cells(0).Value & "", 1, 2) = "IN" Then
            MyFrmShowWorkOrder.TypeOfForm = "IN"
            MyFrmShowWorkOrder.TxtRef.Text = GridEX1.GetRow.Cells(0).Value & ""
            MyFrmShowWorkOrder.Show()
        End If
    End Sub
    Private Sub TxtAssessDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAssessDate.Leave
        DsAssessFinanceCharge1.AssessDtl.Clear()
        DsAssessFinanceCharge1.assess.Clear()
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GridEX1.Visible = Not GridEX1.Visible
        Call FillAll()
    End Sub
    Function Findid_service_center(ByVal thisstring As String) As String
        Findid_service_center = thisstring
        Dim tmp1 As Integer = thisstring.IndexOf("/")
        If tmp1 > 0 Then
            Findid_service_center = thisstring.Substring(tmp1 + 1, thisstring.Length - tmp1 - 1)
        End If
    End Function
End Class
