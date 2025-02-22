Imports CommonClass
Public Class FrmTaraz
    Inherits CommonClass.FrmBase
    Public ManA_Bed As Decimal, ManA_Bes As Decimal, Jari_Bed As Decimal, Jari_Bes As Decimal
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
    Friend DSFrmJournal1 As DSFrmJournal
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTo As CalendarCombo.CalendarCombo
    Friend WithEvents DateFrom As CalendarCombo.CalendarCombo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents GlAccount2 As UCGl_Account.GlAccount
    Friend WithEvents GlAccount1 As UCGl_Account.GlAccount
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdtaraz As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaGeneralJournalMandeh As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaGeneralJournalGardesh As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlAccount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EightColumn As System.Windows.Forms.RadioButton
    Friend WithEvents FourColumn As System.Windows.Forms.RadioButton
    Friend WithEvents TwoColumn As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTaraz))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.DSFrmJournal1 = New UcAccount.DSFrmJournal
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DateTo = New CalendarCombo.CalendarCombo
        Me.DateFrom = New CalendarCombo.CalendarCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblTo = New System.Windows.Forms.Label
        Me.LblFrom = New System.Windows.Forms.Label
        Me.GlAccount2 = New UCGl_Account.GlAccount
        Me.GlAccount1 = New UCGl_Account.GlAccount
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdtaraz = New Janus.Windows.GridEX.GridEX
        Me.DaGeneralJournalMandeh = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaGeneralJournalGardesh = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaGlAccount = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.EightColumn = New System.Windows.Forms.RadioButton
        Me.FourColumn = New System.Windows.Forms.RadioButton
        Me.TwoColumn = New System.Windows.Forms.RadioButton
        CType(Me.DSFrmJournal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdtaraz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSFrmJournal1
        '
        Me.DSFrmJournal1.DataSetName = "DSFrmJournal"
        Me.DSFrmJournal1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(103, 182)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 11
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(7, 182)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 10
        Me.CmdOk.Text = "Ok"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(622, 56)
        Me.Panel4.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(356, 54)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Balance Sheet"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTo)
        Me.Panel1.Controls.Add(Me.DateFrom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblTo)
        Me.Panel1.Controls.Add(Me.LblFrom)
        Me.Panel1.Controls.Add(Me.GlAccount2)
        Me.Panel1.Controls.Add(Me.GlAccount1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-9, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 112)
        Me.Panel1.TabIndex = 9
        '
        'DateTo
        '
        Me.DateTo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateTo.BorderColor = System.Drawing.Color.Empty
        Me.DateTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateTo.ButtonBackColor = System.Drawing.Color.Empty
        Me.DateTo.ButtonForeColor = System.Drawing.Color.Empty
        Me.DateTo.EditableSal = True
        Me.DateTo.Image = CType(resources.GetObject("DateTo.Image"), System.Drawing.Image)
        Me.DateTo.Location = New System.Drawing.Point(512, 72)
        Me.DateTo.MaxValue = CType(2500, Short)
        Me.DateTo.MinValue = CType(1800, Short)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTo.Sal_Mali = Nothing
        Me.DateTo.ShowButton = True
        Me.DateTo.Size = New System.Drawing.Size(112, 23)
        Me.DateTo.TabIndex = 3
        Me.DateTo.VisualStyle = False
        '
        'DateFrom
        '
        Me.DateFrom.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateFrom.BorderColor = System.Drawing.Color.Empty
        Me.DateFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateFrom.ButtonBackColor = System.Drawing.Color.Empty
        Me.DateFrom.ButtonForeColor = System.Drawing.Color.Empty
        Me.DateFrom.EditableSal = True
        Me.DateFrom.Image = CType(resources.GetObject("DateFrom.Image"), System.Drawing.Image)
        Me.DateFrom.Location = New System.Drawing.Point(88, 72)
        Me.DateFrom.MaxValue = CType(2500, Short)
        Me.DateFrom.MinValue = CType(1800, Short)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateFrom.Sal_Mali = Nothing
        Me.DateFrom.ShowButton = True
        Me.DateFrom.Size = New System.Drawing.Size(120, 23)
        Me.DateFrom.TabIndex = 2
        Me.DateFrom.VisualStyle = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(456, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "To Date"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "From Date"
        '
        'LblTo
        '
        Me.LblTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTo.Location = New System.Drawing.Point(224, 40)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(400, 23)
        Me.LblTo.TabIndex = 7
        '
        'LblFrom
        '
        Me.LblFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFrom.Location = New System.Drawing.Point(224, 8)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(400, 23)
        Me.LblFrom.TabIndex = 6
        '
        'GlAccount2
        '
        Me.GlAccount2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GlAccount2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GlAccount2.Cod_Gl = ""
        Me.GlAccount2.Connection = Me.Cnn
        Me.GlAccount2.Location = New System.Drawing.Point(88, 40)
        Me.GlAccount2.Name = "GlAccount2"
        Me.GlAccount2.NotExitIfNotFound = False
        Me.GlAccount2.ReleaseIfNotFoundEmployeeCod = False
        Me.GlAccount2.Size = New System.Drawing.Size(120, 20)
        Me.GlAccount2.TabIndex = 1
        '
        'GlAccount1
        '
        Me.GlAccount1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GlAccount1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GlAccount1.Cod_Gl = ""
        Me.GlAccount1.Connection = Me.Cnn
        Me.GlAccount1.Location = New System.Drawing.Point(88, 8)
        Me.GlAccount1.Name = "GlAccount1"
        Me.GlAccount1.NotExitIfNotFound = False
        Me.GlAccount1.ReleaseIfNotFoundEmployeeCod = False
        Me.GlAccount1.Size = New System.Drawing.Size(120, 20)
        Me.GlAccount1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To Account"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From Account"
        '
        'grdtaraz
        '
        Me.grdtaraz.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.grdtaraz.AlternatingColors = True
        Me.grdtaraz.AlternatingRowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.grdtaraz.BackColor = System.Drawing.SystemColors.Control
        Me.grdtaraz.BlendColor = System.Drawing.SystemColors.Control
        Me.grdtaraz.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D
        Me.grdtaraz.DataMember = "TarazKol"
        Me.grdtaraz.DataSource = Me.DSFrmJournal1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Column1""><Bo" & _
        "und>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><EditType>NoEdit</EditType" & _
        "><Key>Column1</Key><Position>0</Position><Width>26</Width></Column0><Column1 ID=" & _
        """Gl_Account""><Caption>Gl Account</Caption><TypeNameEmptyStringValue>System.Strin" & _
        "g</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>GL_account</DataMemb" & _
        "er><Key>Gl_Account</Key><Position>1</Position><Width>78</Width></Column1><Column" & _
        "2 ID=""desc_GL_account""><Caption>GL Name</Caption><TypeNameEmptyStringValue>Syste" & _
        "m.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>desc_GL_accou" & _
        "nt</DataMember><Key>desc_GL_account</Key><Position>2</Position><Width>143</Width" & _
        "></Column2><Column3 ID=""ManA_Bed""><AggregateFunction>Sum</AggregateFunction><Cap" & _
        "tion>Begin Balance Debit</Caption><DataMember>ManA_Bed</DataMember><FormatString" & _
        ">###,###,###,###,###</FormatString><Key>ManA_Bed</Key><MaskPrompt>&#x0;</MaskPro" & _
        "mpt><Position>3</Position><TextAlignment>Near</TextAlignment><Width>118</Width><" & _
        "TotalFormatString>###,###,###,###,###</TotalFormatString><DefaultValue>0</Defaul" & _
        "tValue><CellStyle><ForeColor>Maroon</ForeColor></CellStyle></Column3><Column4 ID" & _
        "=""ManA_Bes""><AggregateFunction>Sum</AggregateFunction><Caption>Begin Balance Cre" & _
        "dit</Caption><DataMember>ManA_Bes</DataMember><FormatString>###,###,###,###,###<" & _
        "/FormatString><Key>ManA_Bes</Key><Position>4</Position><TextAlignment>Near</Text" & _
        "Alignment><Width>113</Width><TotalFormatString>###,###,###,###,###</TotalFormatS" & _
        "tring><CellStyle><ForeColor>Navy</ForeColor></CellStyle></Column4><Column5 ID=""J" & _
        "ari_bed""><AggregateFunction>Sum</AggregateFunction><Caption>Trans Balance Debit<" & _
        "/Caption><DataMember>Jari_bed</DataMember><FormatString>###,###,###,###,###</For" & _
        "matString><Key>Jari_bed</Key><Position>5</Position><TextAlignment>Near</TextAlig" & _
        "nment><Width>96</Width><TotalFormatString>###,###,###,###,###</TotalFormatString" & _
        "><CellStyle><ForeColor>Maroon</ForeColor></CellStyle></Column5><Column6 ID=""Jari" & _
        "_Bes""><AggregateFunction>Sum</AggregateFunction><Caption>Trans Balance Credit</C" & _
        "aption><DataMember>Jari_Bes</DataMember><FormatString>###,###,###,###,###</Forma" & _
        "tString><Key>Jari_Bes</Key><Position>6</Position><TextAlignment>Near</TextAlignm" & _
        "ent><Width>101</Width><TotalFormatString>###,###,###,###,###</TotalFormatString>" & _
        "<CellStyle><ForeColor>Navy</ForeColor></CellStyle></Column6><Column7 ID=""Jam_Bed" & _
        """><AggregateFunction>Sum</AggregateFunction><Caption>Sub Debit</Caption><DataMem" & _
        "ber>Jam_Bed</DataMember><FormatString>###,###,###,###,###</FormatString><Key>Jam" & _
        "_Bed</Key><Position>7</Position><TextAlignment>Near</TextAlignment><Width>113</W" & _
        "idth><TotalFormatString>###,###,###,###,###</TotalFormatString><CellStyle><ForeC" & _
        "olor>Maroon</ForeColor></CellStyle></Column7><Column8 ID=""Jam_Bes""><AggregateFun" & _
        "ction>Sum</AggregateFunction><Caption>Sum Credit</Caption><DataMember>Jam_Bes</D" & _
        "ataMember><FormatString>###,###,###,###,###</FormatString><Key>Jam_Bes</Key><Pos" & _
        "ition>8</Position><TextAlignment>Near</TextAlignment><Width>105</Width><TotalFor" & _
        "matString>###,###,###,###,###</TotalFormatString><CellStyle><ForeColor>Navy</For" & _
        "eColor></CellStyle></Column8><Column9 ID=""Man_Bed""><AggregateFunction>Sum</Aggre" & _
        "gateFunction><Caption>Ending Balance Debit</Caption><DataMember>Man_Bed</DataMem" & _
        "ber><FormatString>###,###,###,###,###</FormatString><Key>Man_Bed</Key><Position>" & _
        "9</Position><TextAlignment>Near</TextAlignment><Width>110</Width><TotalFormatStr" & _
        "ing>###,###,###,###,###</TotalFormatString><CellStyle><ForeColor>Maroon</ForeCol" & _
        "or></CellStyle></Column9><Column10 ID=""Man_Bes""><AggregateFunction>Sum</Aggregat" & _
        "eFunction><Caption>Ending Balance Credit</Caption><DataMember>Man_Bes</DataMembe" & _
        "r><FormatString>###,###,###,###,###</FormatString><Key>Man_Bes</Key><Position>10" & _
        "</Position><TextAlignment>Near</TextAlignment><Width>93</Width><TotalFormatStrin" & _
        "g>###,###,###,###,###</TotalFormatString><CellStyle><ForeColor>Navy</ForeColor><" & _
        "/CellStyle></Column10></Columns><ColumnSetHeaderLines>2</ColumnSetHeaderLines><G" & _
        "ridLineColor>Black</GridLineColor><GroupCondition ID="""" /><HeaderLines>2</Header" & _
        "Lines><Key>TarazTaf</Key></RootTable></GridEXLayoutData>"
        Me.grdtaraz.DesignTimeLayout = GridEXLayout1
        Me.grdtaraz.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.grdtaraz.GridLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.grdtaraz.GridLines = Janus.Windows.GridEX.GridLines.Vertical
        Me.grdtaraz.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdtaraz.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.grdtaraz.HasEditorsControlStyle = True
        Me.grdtaraz.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.grdtaraz.Hierarchical = True
        Me.grdtaraz.Location = New System.Drawing.Point(4, 208)
        Me.grdtaraz.Name = "grdtaraz"
        Me.grdtaraz.RecordNavigator = True
        Me.grdtaraz.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.grdtaraz.Size = New System.Drawing.Size(609, 233)
        Me.grdtaraz.TabIndex = 13
        Me.grdtaraz.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdtaraz.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.grdtaraz.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        Me.grdtaraz.TreeLineColor = System.Drawing.Color.DarkRed
        '
        'DaGeneralJournalMandeh
        '
        Me.DaGeneralJournalMandeh.SelectCommand = Me.SqlSelectCommand1
        Me.DaGeneralJournalMandeh.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GeneralJournal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("GL_journal_date", "GL_journal_date"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_picture", "GL_picture"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("GL_journal_amount_debit", "GL_journal_amount_debit"), New System.Data.Common.DataColumnMapping("GL_journal_amount_credit", "GL_journal_amount_credit"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_journal_dtl.GL_account, SUM(GL_journal_dtl.GL_journal_amount_debit) AS " & _
        "Sum_Bed, SUM(GL_journal_dtl.GL_journal_amount_credit) AS Sum_Bes, GL_account.des" & _
        "c_GL_account FROM GL_journal_head INNER JOIN GL_journal_dtl ON GL_journal_head.i" & _
        "d_GL_journal = GL_journal_dtl.id_GL_journal INNER JOIN GL_account ON GL_journal_" & _
        "dtl.GL_account = GL_account.GL_account WHERE (GL_account.GL_account >= @FromGl) " & _
        "AND (GL_account.GL_account <= @ToGl) AND (SUBSTRING(GL_journal_head.GL_journal_d" & _
        "ate, 7, 4) + '/' + SUBSTRING(GL_journal_head.GL_journal_date, 1, 2) + '/' + SUBS" & _
        "TRING(GL_journal_head.GL_journal_date, 4, 2) < @FromDate) GROUP BY GL_journal_he" & _
        "ad.id_GL_journal, GL_journal_head.GL_journal_date, GL_journal_dtl.radif, GL_jour" & _
        "nal_dtl.GL_account, GL_account.desc_GL_account ORDER BY GL_journal_head.GL_journ" & _
        "al_date, GL_journal_head.id_GL_journal, GL_journal_dtl.radif"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;initial catalog=TireMate_01;per" & _
        "sist security info=True;password=5332"
        '
        'DaGeneralJournalGardesh
        '
        Me.DaGeneralJournalGardesh.SelectCommand = Me.SqlCommand1
        Me.DaGeneralJournalGardesh.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GeneralJournal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("GL_journal_date", "GL_journal_date"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_picture", "GL_picture"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("GL_journal_amount_debit", "GL_journal_amount_debit"), New System.Data.Common.DataColumnMapping("GL_journal_amount_credit", "GL_journal_amount_credit"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_journal_dtl.GL_account, SUM(GL_journal_dtl.GL_journal_amount_debit) AS " & _
        "Sum_Bed, SUM(GL_journal_dtl.GL_journal_amount_credit) AS Sum_Bes, GL_account.des" & _
        "c_GL_account FROM GL_journal_head INNER JOIN GL_journal_dtl ON GL_journal_head.i" & _
        "d_GL_journal = GL_journal_dtl.id_GL_journal INNER JOIN GL_account ON GL_journal_" & _
        "dtl.GL_account = GL_account.GL_account WHERE (GL_account.GL_account >= @FromGl) " & _
        "AND (GL_account.GL_account <= @ToGl) GROUP BY GL_journal_head.id_GL_journal, GL_" & _
        "journal_head.GL_journal_date, GL_journal_dtl.radif, GL_journal_dtl.GL_account, G" & _
        "L_account.desc_GL_account, SUBSTRING(GL_journal_head.GL_journal_date, 7, 4) + '/" & _
        "' + SUBSTRING(GL_journal_head.GL_journal_date, 1, 2) + '/' + SUBSTRING(GL_journa" & _
        "l_head.GL_journal_date, 4, 2) HAVING (SUBSTRING(GL_journal_head.GL_journal_date," & _
        " 7, 4) + '/' + SUBSTRING(GL_journal_head.GL_journal_date, 1, 2) + '/' + SUBSTRIN" & _
        "G(GL_journal_head.GL_journal_date, 4, 2) >= @FromDate) AND (SUBSTRING(GL_journal" & _
        "_head.GL_journal_date, 7, 4) + '/' + SUBSTRING(GL_journal_head.GL_journal_date, " & _
        "1, 2) + '/' + SUBSTRING(GL_journal_head.GL_journal_date, 4, 2) <= @ToDate) ORDER" & _
        " BY GL_journal_head.GL_journal_date, GL_journal_head.id_GL_journal, GL_journal_d" & _
        "tl.radif"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account, desc_GL_account, GL_account_master, group_GL_account, remark F" & _
        "ROM GL_account WHERE (GL_account >= @FromGl) AND (GL_account <= @ToGl)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        '
        'DaGlAccount
        '
        Me.DaGlAccount.SelectCommand = Me.SqlSelectCommand2
        Me.DaGlAccount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EightColumn)
        Me.Panel2.Controls.Add(Me.FourColumn)
        Me.Panel2.Controls.Add(Me.TwoColumn)
        Me.Panel2.Location = New System.Drawing.Point(188, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(433, 23)
        Me.Panel2.TabIndex = 206
        '
        'EightColumn
        '
        Me.EightColumn.Checked = True
        Me.EightColumn.Location = New System.Drawing.Point(2, 0)
        Me.EightColumn.Name = "EightColumn"
        Me.EightColumn.TabIndex = 2
        Me.EightColumn.TabStop = True
        Me.EightColumn.Text = "Eight Column"
        '
        'FourColumn
        '
        Me.FourColumn.Location = New System.Drawing.Point(112, 0)
        Me.FourColumn.Name = "FourColumn"
        Me.FourColumn.TabIndex = 1
        Me.FourColumn.Text = "Four Column"
        '
        'TwoColumn
        '
        Me.TwoColumn.Location = New System.Drawing.Point(225, 0)
        Me.TwoColumn.Name = "TwoColumn"
        Me.TwoColumn.TabIndex = 0
        Me.TwoColumn.Text = "Two Column"
        '
        'FrmTaraz
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(622, 452)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grdtaraz)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmTaraz"
        Me.Text = "Balance Sheet"
        CType(Me.DSFrmJournal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdtaraz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTaraz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DateTo.Text = Format(Now, PubDateFormat)
        DateFrom.Text = Format(Now.AddMonths(-1), PubDateFormat)
    End Sub
    Private Sub GlAccount1_FindGlCod() Handles GlAccount1.FindGlCod
        LblFrom.Text = GlAccount1.Desc_Gl
    End Sub
    Private Sub GlAccount2_FindGlCod() Handles GlAccount2.FindGlCod
        LblTo.Text = GlAccount2.Desc_Gl
    End Sub
    Private Sub GlAccount1_NotFindGlCod() Handles GlAccount1.NotFindGlCod
        LblFrom.Text = ""
    End Sub
    Private Sub GlAccount2_NotFindGlCod() Handles GlAccount2.NotFindGlCod
        LblTo.Text = ""
    End Sub
    Private Sub GlAccount1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GlAccount1.TextChanged, GlAccount2.TextChanged, DateTo.TextChanged, DateFrom.TextChanged
        Call EnableDisableField()
    End Sub
    Sub EnableDisableField()
        If GlAccount1.Cod_Gl.Trim & "" <> "" And GlAccount2.Cod_Gl.Trim & "" <> "" And DateFrom.Text.Trim & "" <> "" And DateTo.Text.Trim & "" <> "" Then
            CmdOk.Enabled = True
        Else
            CmdOk.Enabled = False
        End If
        If GlAccount1.Cod_Gl.Trim & "" = "" Then
            LblFrom.Text = ""
        End If
        If GlAccount2.Cod_Gl.Trim & "" = "" Then
            LblTo.Text = ""
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Dim DsGl As New DataSet
        Dim TmpDs As New DataSet
        DSFrmJournal1.TarazKol.Clear()
        DaGlAccount.SelectCommand.Parameters("@FromGl").Value = GlAccount1.Cod_Gl
        DaGlAccount.SelectCommand.Parameters("@ToGl").Value = GlAccount2.Cod_Gl
        DaGlAccount.Fill(DsGl)
        Dim i As Integer
        If DsGl.Tables(0).Rows.Count > 0 Then
            For i = 0 To DsGl.Tables(0).Rows.Count - 1
                Try
                    'for i=0 to 
                    Call ClearData()
                    TmpDs.Clear()
                    DaGeneralJournalMandeh.SelectCommand.Parameters("@FromGl").Value = DsGl.Tables(0).Rows(i).Item("GL_account")
                    DaGeneralJournalMandeh.SelectCommand.Parameters("@ToGl").Value = DsGl.Tables(0).Rows(i).Item("GL_account")
                    DaGeneralJournalMandeh.SelectCommand.Parameters("@FromDate").Value = DateFrom.Text.Substring(6, 4) + "/" + DateFrom.Text.Substring(0, 2) + "/" + DateFrom.Text.Substring(3, 2)
                    DaGeneralJournalMandeh.Fill(TmpDs)
                    With TmpDs.Tables(0)
                        If .Rows.Count > 0 Then
                            ManA_Bed = CDec("0" & .Rows(0).Item("Sum_bed"))
                            ManA_Bes = CDec("0" & .Rows(0).Item("Sum_bes"))
                        Else
                            ManA_Bed = 0
                            ManA_Bes = 0
                        End If
                    End With
                    Dim Thisgl As String = ""
                    Dim ThisglDesc As String = ""
                    If TmpDs.Tables(0).Rows.Count > 0 Then
                        Thisgl = TmpDs.Tables(0).Rows(0).Item("GL_account")
                        ThisglDesc = TmpDs.Tables(0).Rows(0).Item("desc_GL_account")
                    End If
                    '-----------------------------------ãÍÇÓÈå ÌÇÑí ÈÏå˜ÇÑ íÇ ÈÓÊÇä˜ÇÑ
                    TmpDs.Clear()
                    DaGeneralJournalGardesh.SelectCommand.Parameters("@FromGl").Value = DsGl.Tables(0).Rows(i).Item("GL_account")
                    DaGeneralJournalGardesh.SelectCommand.Parameters("@ToGl").Value = DsGl.Tables(0).Rows(i).Item("GL_account")
                    DaGeneralJournalGardesh.SelectCommand.Parameters("@FromDate").Value = DateFrom.Text.Substring(6, 4) + "/" + DateFrom.Text.Substring(0, 2) + "/" + DateFrom.Text.Substring(3, 2)
                    DaGeneralJournalGardesh.SelectCommand.Parameters("@ToDate").Value = DateTo.Text.Substring(6, 4) + "/" + DateTo.Text.Substring(0, 2) + "/" + DateTo.Text.Substring(3, 2)
                    DaGeneralJournalGardesh.Fill(TmpDs)
                    With TmpDs.Tables(0)
                        If .Rows.Count > 0 Then
                            Jari_Bed = CDec("0" & .Rows(0).Item("Sum_bed"))
                            Jari_Bes = CDec("0" & .Rows(0).Item("Sum_bes"))
                        Else
                            Jari_Bed = 0
                            Jari_Bes = 0
                        End If
                    End With
                    If TmpDs.Tables(0).Rows.Count > 0 Then
                        Thisgl = TmpDs.Tables(0).Rows(0).Item("GL_account")
                        ThisglDesc = TmpDs.Tables(0).Rows(0).Item("desc_GL_account")
                    End If
                    If Thisgl <> "" Then
                        Dim NewRow As DataRow = DSFrmJournal1.TarazKol.NewRow
                        NewRow("GL_account") = Thisgl
                        NewRow("desc_GL_account") = ThisglDesc
                        NewRow("ManA_Bed") = ManA_Bed
                        NewRow("ManA_Bes") = ManA_Bes
                        NewRow("Jari_Bed") = Jari_Bed
                        NewRow("Jari_Bes") = Jari_Bes
                        NewRow("Jam_Bed") = ManA_Bed + Jari_Bed
                        NewRow("Jam_Bes") = ManA_Bes + Jari_Bes
                        Dim Mand As Decimal = (ManA_Bed + Jari_Bed) - (ManA_Bes + Jari_Bes)
                        Select Case Mand
                            Case 0
                                NewRow("Man_Bed") = 0
                                NewRow("Man_Bes") = 0
                            Case Is > 0
                                NewRow("Man_Bed") = Mand
                                NewRow("Man_Bes") = 0
                            Case Is < 0
                                NewRow("Man_Bed") = 0
                                NewRow("Man_Bes") = Mand * -1
                        End Select
                        DSFrmJournal1.TarazKol.Rows.Add(NewRow)
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Next
        End If
        grdtaraz.Refresh()
        grdtaraz.Refetch()

    End Sub
    Sub ClearData()
        ManA_Bed = 0
        ManA_Bes = 0
        Jari_Bed = 0
        Jari_Bes = 0
    End Sub
    Private Sub GridtARAZ_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdtaraz.ColumnButtonClick
        If grdtaraz.GetRow.Cells(1).Value <> 0 Then
            Dim MyFrm As New UcAccount.FrmGeneralJournal
            MyFrm.Cnn.ConnectionString = PConnectionString
            MyFrm.DateFrom.Text = DateFrom.Text
            MyFrm.DateTo.Text = DateTo.Text
            MyFrm.GlAccount1.Connection = Me.Cnn
            MyFrm.GlAccount2.Connection = Me.Cnn
            MyFrm.GlAccount1.Cod_Gl = grdtaraz.GetRow.Cells(1).Value
            MyFrm.GlAccount2.Cod_Gl = grdtaraz.GetRow.Cells(1).Value
            'MyFrm.LblFrom = MyFrm.GlAccount2.Desc_Gl

            MyFrm.Calculate()
            MyFrm.ShowDialog()
        End If
    End Sub

    Private Sub FourColumn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FourColumn.CheckedChanged, EightColumn.CheckedChanged, TwoColumn.CheckedChanged
        Call ColumnSet()
    End Sub
    Sub ColumnSet()
        Dim i As Integer = 0
        For i = 3 To 10
            grdtaraz.RootTable.Columns(i).Visible = False
        Next

        If TwoColumn.Checked = True Then
            grdtaraz.RootTable.Columns(9).Visible = True
            grdtaraz.RootTable.Columns(10).Visible = True
        End If
        If FourColumn.Checked = True Then
            grdtaraz.RootTable.Columns(10).Visible = True
            grdtaraz.RootTable.Columns(9).Visible = True
            grdtaraz.RootTable.Columns(8).Visible = True
            grdtaraz.RootTable.Columns(7).Visible = True
        End If
        If EightColumn.Checked = True Then
            grdtaraz.RootTable.Columns(10).Visible = True
            grdtaraz.RootTable.Columns(9).Visible = True
            grdtaraz.RootTable.Columns(8).Visible = True
            grdtaraz.RootTable.Columns(7).Visible = True
            grdtaraz.RootTable.Columns(6).Visible = True
            grdtaraz.RootTable.Columns(5).Visible = True
            grdtaraz.RootTable.Columns(4).Visible = True
            grdtaraz.RootTable.Columns(3).Visible = True
        End If
    End Sub

End Class
