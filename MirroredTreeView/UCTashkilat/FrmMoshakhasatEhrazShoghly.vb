Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmMoshakhasatEhrazShoghly
    Inherits CommonClass.FrmBase

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents CmbRaste As System.Windows.Forms.ComboBox
    Friend WithEvents LblReshteShoghli As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAtas_bas_rasteh As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents DsFrmMoshakhasatEhraz1 As UCTashkilat.DSFrmMoshakhasatEhraz
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdRasteOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents GrdRaste As Janus.Windows.GridEX.GridEX
    Friend WithEvents PnlRaste As System.Windows.Forms.Panel
    Friend WithEvents PnlReshte As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_reshteh_shoghli As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_tr_shoghlha_madrak_reshteha As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_madrak_tahsili As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdReshteMadrak As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdMadrak As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_reshteh_tahsili As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LblCodShoghl As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsMoshakhasatEhraz1 As UCTashkilat.DSFrmMoshakhasatEhraz
    Friend WithEvents DsFrmMoshakhasatEhraz1 As UCTashkilat.DSFrmMoshakhasatEhraz
    Friend WithEvents DAtas_tr_rasteh_reshteh As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_group_estekhdami As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmMoshakhasatEhrazShoghly1 As UCTashkilat.DSFrmMoshakhasatEhrazShoghly
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMoshakhasatEhrazShoghly))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PnlRaste = New System.Windows.Forms.Panel
        Me.CmdRasteOk = New Janus.Windows.EditControls.UIButton
        Me.CmbRaste = New System.Windows.Forms.ComboBox
        Me.DsFrmMoshakhasatEhrazShoghly1 = New UCTashkilat.DSFrmMoshakhasatEhrazShoghly
        Me.Label4 = New System.Windows.Forms.Label
        Me.DsFrmMoshakhasatEhraz1 = New UCTashkilat.DSFrmMoshakhasatEhraz
        Me.PnlReshte = New System.Windows.Forms.Panel
        Me.LblCodShoghl = New System.Windows.Forms.Label
        Me.LblReshteShoghli = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GrdRaste = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAtas_bas_rasteh = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_reshteh_shoghli = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_tr_shoghlha_madrak_reshteha = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_madrak_tahsili = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdMadrak = New Janus.Windows.GridEX.GridEX
        Me.GrdReshteMadrak = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_reshteh_tahsili = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DAtas_tr_rasteh_reshteh = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_group_estekhdami = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel9.SuspendLayout()
        Me.PnlRaste.SuspendLayout()
        CType(Me.DsFrmMoshakhasatEhrazShoghly1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmMoshakhasatEhraz1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlReshte.SuspendLayout()
        CType(Me.GrdRaste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdMadrak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdReshteMadrak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.Label33)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label25)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(614, 56)
        Me.Panel9.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 35)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "‘—«Ìÿ «Õ—«“ ‘€·"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(490, 41)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 11)
        Me.Label33.TabIndex = 208
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(490, 9)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 29)
        Me.BtnCancel.TabIndex = 206
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(450, 42)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 11)
        Me.Label25.TabIndex = 207
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(450, 9)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 29)
        Me.BtnSave.TabIndex = 205
        '
        'PnlRaste
        '
        Me.PnlRaste.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlRaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlRaste.Controls.Add(Me.CmdRasteOk)
        Me.PnlRaste.Controls.Add(Me.CmbRaste)
        Me.PnlRaste.Controls.Add(Me.Label4)
        Me.PnlRaste.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlRaste.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlRaste.Location = New System.Drawing.Point(0, 56)
        Me.PnlRaste.Name = "PnlRaste"
        Me.PnlRaste.Size = New System.Drawing.Size(614, 43)
        Me.PnlRaste.TabIndex = 5
        '
        'CmdRasteOk
        '
        Me.CmdRasteOk.Location = New System.Drawing.Point(96, 9)
        Me.CmdRasteOk.Name = "CmdRasteOk"
        Me.CmdRasteOk.Size = New System.Drawing.Size(40, 24)
        Me.CmdRasteOk.TabIndex = 1
        Me.CmdRasteOk.Text = " «ÌÌœ"
        '
        'CmbRaste
        '
        Me.CmbRaste.DataSource = Me.DsFrmMoshakhasatEhrazShoghly1.tas_bas_rasteh
        Me.CmbRaste.DisplayMember = "desc_rasteh"
        Me.CmbRaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRaste.Location = New System.Drawing.Point(248, 9)
        Me.CmbRaste.Name = "CmbRaste"
        Me.CmbRaste.Size = New System.Drawing.Size(159, 21)
        Me.CmbRaste.TabIndex = 0
        Me.CmbRaste.ValueMember = "code_rasteh"
        '
        'DsFrmMoshakhasatEhrazShoghly1
        '
        Me.DsFrmMoshakhasatEhrazShoghly1.DataSetName = "DSFrmMoshakhasatEhrazShoghly"
        Me.DsFrmMoshakhasatEhrazShoghly1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(440, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "—” Â Â«Ì «œ«—Ì"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DsFrmMoshakhasatEhraz1
        '
        Me.DsFrmMoshakhasatEhraz1.DataSetName = "DSFrmMoshakhasatEhraz"
        Me.DsFrmMoshakhasatEhraz1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'PnlReshte
        '
        Me.PnlReshte.BackColor = System.Drawing.Color.Yellow
        Me.PnlReshte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlReshte.Controls.Add(Me.LblCodShoghl)
        Me.PnlReshte.Controls.Add(Me.LblReshteShoghli)
        Me.PnlReshte.Controls.Add(Me.Label3)
        Me.PnlReshte.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlReshte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlReshte.Location = New System.Drawing.Point(0, 264)
        Me.PnlReshte.Name = "PnlReshte"
        Me.PnlReshte.Size = New System.Drawing.Size(614, 43)
        Me.PnlReshte.TabIndex = 7
        '
        'LblCodShoghl
        '
        Me.LblCodShoghl.Location = New System.Drawing.Point(64, 9)
        Me.LblCodShoghl.Name = "LblCodShoghl"
        Me.LblCodShoghl.Size = New System.Drawing.Size(100, 24)
        Me.LblCodShoghl.TabIndex = 190
        Me.LblCodShoghl.Visible = False
        '
        'LblReshteShoghli
        '
        Me.LblReshteShoghli.BackColor = System.Drawing.Color.Gold
        Me.LblReshteShoghli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblReshteShoghli.Location = New System.Drawing.Point(263, 9)
        Me.LblReshteShoghli.Name = "LblReshteShoghli"
        Me.LblReshteShoghli.Size = New System.Drawing.Size(144, 24)
        Me.LblReshteShoghli.TabIndex = 189
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(416, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 188
        Me.Label3.Text = "—‘ Â ‘€·Ì «‰ Œ«»Ì"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdRaste
        '
        Me.GrdRaste.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdRaste.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdRaste.DataMember = "tas_tr_rasteh_reshteh"
        Me.GrdRaste.DataSource = Me.DsFrmMoshakhasatEhrazShoghly1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Column1""><Bo" & _
        "und>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><Key>Column1</Key><Positio" & _
        "n>0</Position><Width>27</Width></Column0><Column1 ID=""Column2""><Bound>False</Bou" & _
        "nd><ButtonStyle>ButtonCell</ButtonStyle><Key>Column2</Key><Position>1</Position>" & _
        "<Width>28</Width></Column1><Column2 ID=""code_reshteh_shoghli""><Caption>òœ —‘ Â ‘" & _
        "€·Ì</Caption><DataMember>code_reshteh_shoghli</DataMember><Key>code_reshteh_shog" & _
        "hli</Key><Position>2</Position><Width>67</Width></Column2><Column3 ID=""desc_resh" & _
        "teh_shoghli""><Caption>‘—Õ —‘ Â ‘€·Ì</Caption><DataMember>code_reshteh_shoghli</D" & _
        "ataMember><EditType>NoEdit</EditType><Key>desc_reshteh_shoghli</Key><Position>3<" & _
        "/Position><Width>178</Width><DropDownIndex>1</DropDownIndex></Column3><Column4 I" & _
        "D=""code_group_estekhdami_from""><Caption>«“ ê—ÊÂ</Caption><DataMember>code_group_" & _
        "estekhdami_from</DataMember><DefaultGroupInterval>Text</DefaultGroupInterval><Ed" & _
        "itType>MultiColumnDropDown</EditType><Key>code_group_estekhdami_from</Key><Posit" & _
        "ion>4</Position><CompareTarget>Text</CompareTarget><Width>69</Width><DropDownInd" & _
        "ex>2</DropDownIndex></Column4><Column5 ID=""code_group_estekhdami_to""><Caption> «" & _
        " ê—ÊÂ</Caption><DataMember>code_group_estekhdami_to</DataMember><DefaultGroupInt" & _
        "erval>Text</DefaultGroupInterval><EditType>MultiColumnDropDown</EditType><Key>co" & _
        "de_group_estekhdami_to</Key><Position>5</Position><CompareTarget>Text</CompareTa" & _
        "rget><Width>75</Width><DropDownIndex>2</DropDownIndex></Column5><Column6 ID=""rem" & _
        "ark""><Caption> Ê÷ÌÕ« </Caption><DataMember>remark</DataMember><Key>remark</Key><" & _
        "Position>6</Position><Width>131</Width></Column6><Column7 ID=""code_rasteh""><Capt" & _
        "ion>code_rasteh</Caption><DataMember>code_rasteh</DataMember><Key>code_rasteh</K" & _
        "ey><Position>7</Position><Visible>False</Visible></Column7><Column8 ID=""code_ban" & _
        "dar""><Caption>code_bandar</Caption><DataMember>code_bandar</DataMember><Key>code" & _
        "_bandar</Key><Position>8</Position><Visible>False</Visible></Column8><Column9 ID" & _
        "=""id_rasteh_reshteh""><Caption>id_rasteh_reshteh</Caption><DataMember>id_rasteh_r" & _
        "eshteh</DataMember><Key>id_rasteh_reshteh</Key><Position>9</Position><Visible>Fa" & _
        "lse</Visible></Column9></Columns><GroupCondition ID="""" /></RootTable><DropDowns " & _
        "Collection=""true""><DropDown0><RootTable><Columns Collection=""true""><Column0 ID=""" & _
        "code_group_estekhdami""><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue>" & _
        "<EmptyStringValue /><DataMember>code_group_estekhdami</DataMember><EditType>NoEd" & _
        "it</EditType><Key>code_group_estekhdami</Key><Position>0</Position><Width>40</Wi" & _
        "dth></Column0><Column1 ID=""desc_group_reshteh_tahsili""><Caption>desc_group_resht" & _
        "eh_tahsili</Caption><DataMember>desc_group_reshteh_tahsili</DataMember><Key>desc" & _
        "_group_reshteh_tahsili</Key><Position>1</Position><Width>80</Width></Column1></C" & _
        "olumns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft San" & _
        "s Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><ColumnHeaders" & _
        ">False</ColumnHeaders><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisib" & _
        "le>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection><Key>DropDow" & _
        "nGroupEstekhdamy</Key><DisplayMember>desc_group_estekhdami</DisplayMember><Value" & _
        "Member>code_group_estekhdami</ValueMember></DropDown0><DropDown1><RootTable><Col" & _
        "umns Collection=""true""><Column0 ID=""code_reshteh_shoghli""><AllowDrag>False</Allo" & _
        "wDrag><Caption>code_reshteh_shoghli</Caption><TypeNameEmptyStringValue>NULL</Typ" & _
        "eNameEmptyStringValue><EmptyStringValue /><DataMember>code_reshteh_shoghli</Data" & _
        "Member><EditType>NoEdit</EditType><Key>code_reshteh_shoghli</Key><Position>0</Po" & _
        "sition><Selectable>False</Selectable></Column0><Column1 ID=""desc_reshteh_shoghli" & _
        """><Caption>desc_reshteh_shoghli</Caption><TypeNameEmptyStringValue>System.String" & _
        "</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>desc_reshteh_shoghli<" & _
        "/DataMember><Key>desc_reshteh_shoghli</Key><Position>1</Position></Column1></Col" & _
        "umns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans " & _
        "Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><ExpandableGroup" & _
        "s>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelec" & _
        "tion>Highlight</HideSelection><Key>DropDown1</Key><DisplayMember>desc_reshteh_sh" & _
        "oghli</DisplayMember><ValueMember>code_reshteh_shoghli</ValueMember></DropDown1>" & _
        "<DropDown2><RootTable><Columns Collection=""true""><Column0 ID=""code_group_estekhd" & _
        "ami""><Caption>code_group_estekhdami</Caption><TypeNameEmptyStringValue>NULL</Typ" & _
        "eNameEmptyStringValue><EmptyStringValue /><DataMember>code_group_estekhdami</Dat" & _
        "aMember><EditType>NoEdit</EditType><Key>code_group_estekhdami</Key><Position>0</" & _
        "Position><Visible>False</Visible></Column0><Column1 ID=""desc_group_estekhdami""><" & _
        "Caption>desc_group_estekhdami</Caption><DataMember>desc_group_estekhdami</DataMe" & _
        "mber><Key>desc_group_estekhdami</Key><Position>1</Position></Column1></Columns><" & _
        "GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans Serif," & _
        " 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><ExpandableGroups>Fals" & _
        "e</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>H" & _
        "ighlight</HideSelection><Key>DropDownGroup</Key><DisplayMember>desc_group_estekh" & _
        "dami</DisplayMember><ValueMember>code_group_estekhdami</ValueMember></DropDown2>" & _
        "</DropDowns></GridEXLayoutData>"
        Me.GrdRaste.DesignTimeLayout = GridEXLayout1
        Me.GrdRaste.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdRaste.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdRaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdRaste.GroupByBoxVisible = False
        Me.GrdRaste.Location = New System.Drawing.Point(0, 99)
        Me.GrdRaste.Name = "GrdRaste"
        Me.GrdRaste.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrdRaste.Size = New System.Drawing.Size(614, 165)
        Me.GrdRaste.TabIndex = 6
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT code_rasteh, desc_rasteh FROM tas_bas_rasteh"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=banader_02"
        '
        'DAtas_bas_rasteh
        '
        Me.DAtas_bas_rasteh.SelectCommand = Me.SqlSelectCommand1
        Me.DAtas_bas_rasteh.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_rasteh", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_rasteh", "code_rasteh"), New System.Data.Common.DataColumnMapping("desc_rasteh", "desc_rasteh")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT code_reshteh_shoghli, desc_reshteh_shoghli FROM tas_bas_reshteh_shoghli"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO tas_bas_reshteh_shoghli(desc_reshteh_shoghli) VALUES (@desc_reshteh_s" & _
        "hoghli); SELECT code_reshteh_shoghli, desc_reshteh_shoghli FROM tas_bas_reshteh_" & _
        "shoghli WHERE (code_reshteh_shoghli = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_reshteh_shoghli", System.Data.SqlDbType.VarChar, 50, "desc_reshteh_shoghli"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE tas_bas_reshteh_shoghli SET desc_reshteh_shoghli = @desc_reshteh_shoghli W" & _
        "HERE (code_reshteh_shoghli = @Original_code_reshteh_shoghli) AND (desc_reshteh_s" & _
        "hoghli = @Original_desc_reshteh_shoghli); SELECT code_reshteh_shoghli, desc_resh" & _
        "teh_shoghli FROM tas_bas_reshteh_shoghli WHERE (code_reshteh_shoghli = @code_res" & _
        "hteh_shoghli)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_reshteh_shoghli", System.Data.SqlDbType.VarChar, 50, "desc_reshteh_shoghli"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_shoghli", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_reshteh_shoghli", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_reshteh_shoghli", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_shoghli"))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM tas_bas_reshteh_shoghli WHERE (code_reshteh_shoghli = @Original_code_" & _
        "reshteh_shoghli) AND (desc_reshteh_shoghli = @Original_desc_reshteh_shoghli)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_shoghli", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_reshteh_shoghli", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_reshteh_shoghli", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_bas_reshteh_shoghli
        '
        Me.DAtas_bas_reshteh_shoghli.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAtas_bas_reshteh_shoghli.InsertCommand = Me.SqlInsertCommand4
        Me.DAtas_bas_reshteh_shoghli.SelectCommand = Me.SqlSelectCommand4
        Me.DAtas_bas_reshteh_shoghli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_reshteh_shoghli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_reshteh_shoghli", "code_reshteh_shoghli"), New System.Data.Common.DataColumnMapping("desc_reshteh_shoghli", "desc_reshteh_shoghli")})})
        Me.DAtas_bas_reshteh_shoghli.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT tas_tr_shoghlha_madrak_reshteha.code_madrak_tahsili, tas_tr_shoghlha_madra" & _
        "k_reshteha.code_reshteh_tahsili, tas_tr_shoghlha_madrak_reshteha.remark, tas_tr_" & _
        "shoghlha_madrak_reshteha.code_bandar, tas_tr_shoghlha_madrak_reshteha.code_marka" & _
        "z, tas_bas_reshteh_tahsili.desc_reshteh_tahsili, 0 AS flag FROM tas_tr_shoghlha_" & _
        "madrak_reshteha INNER JOIN tas_bas_reshteh_tahsili ON tas_tr_shoghlha_madrak_res" & _
        "hteha.code_reshteh_tahsili = tas_bas_reshteh_tahsili.code_reshteh_tahsili WHERE " & _
        "(tas_tr_shoghlha_madrak_reshteha.id_rasteh_reshteh = @id_rasteh_reshteh) ORDER B" & _
        "Y tas_tr_shoghlha_madrak_reshteha.code_reshteh_tahsili"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rasteh_reshteh", System.Data.SqlDbType.SmallInt, 2, "id_rasteh_reshteh"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO tas_tr_shoghlha_madrak_reshteha (code_madrak_tahsili, code_reshteh_ta" & _
        "hsili, remark, code_bandar, id_rasteh_reshteh) VALUES (@code_madrak_tahsili, @co" & _
        "de_reshteh_tahsili, @remark, @code_bandar, @id_rasteh_reshteh)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_madrak_tahsili", System.Data.SqlDbType.SmallInt, 2, "code_madrak_tahsili"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_tahsili"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rasteh_reshteh", System.Data.SqlDbType.SmallInt, 2, "id_rasteh_reshteh"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE tas_tr_shoghlha_madrak_reshteha SET remark = @remark WHERE (code_madrak_ta" & _
        "hsili = @code_madrak_tahsili) AND (code_reshteh_tahsili = @code_reshteh_tahsili)" & _
        " AND (id_rasteh_reshteh = @id_rasteh_reshteh)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_madrak_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_madrak_tahsili", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rasteh_reshteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_rasteh_reshteh", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM tas_tr_shoghlha_madrak_reshteha WHERE (code_madrak_tahsili = @code_ma" & _
        "drak_tahsili) AND (code_reshteh_tahsili = @code_reshteh_tahsili) AND (id_rasteh_" & _
        "reshteh = @id_rasteh_reshteh)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_madrak_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_madrak_tahsili", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rasteh_reshteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_rasteh_reshteh", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_tr_shoghlha_madrak_reshteha
        '
        Me.DAtas_tr_shoghlha_madrak_reshteha.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAtas_tr_shoghlha_madrak_reshteha.InsertCommand = Me.SqlInsertCommand2
        Me.DAtas_tr_shoghlha_madrak_reshteha.SelectCommand = Me.SqlSelectCommand2
        Me.DAtas_tr_shoghlha_madrak_reshteha.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_tr_shoghlha_madrak_reshteha", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_madrak_tahsili", "code_madrak_tahsili"), New System.Data.Common.DataColumnMapping("code_reshteh_tahsili", "code_reshteh_tahsili"), New System.Data.Common.DataColumnMapping("code_reshteh_shoghli", "code_reshteh_shoghli"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar"), New System.Data.Common.DataColumnMapping("code_markaz", "code_markaz")})})
        Me.DAtas_tr_shoghlha_madrak_reshteha.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT code_madrak_tahsili, desc_madrak_tahsili FROM tas_bas_madrak_tahsili"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        '
        'DAtas_bas_madrak_tahsili
        '
        Me.DAtas_bas_madrak_tahsili.SelectCommand = Me.SqlSelectCommand8
        Me.DAtas_bas_madrak_tahsili.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_madrak_tahsili", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_madrak_tahsili", "code_madrak_tahsili"), New System.Data.Common.DataColumnMapping("desc_madrak_tahsili", "desc_madrak_tahsili")})})
        '
        'GrdMadrak
        '
        Me.GrdMadrak.AllowColumnDrag = False
        Me.GrdMadrak.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Capti" & _
        "on>flag</Caption><ColumnType>CheckBox</ColumnType><DataMember>flag</DataMember><" & _
        "EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><Width>30</Widt" & _
        "h></Column0><Column1 ID=""code_madrak_tahsili""><Caption>code_madrak_tahsili</Capt" & _
        "ion><DataMember>code_madrak_tahsili</DataMember><Key>code_madrak_tahsili</Key><P" & _
        "osition>1</Position><Visible>False</Visible></Column1><Column2 ID=""desc_madrak_t" & _
        "ahsili""><Caption>desc_madrak_tahsili</Caption><DataMember>desc_madrak_tahsili</D" & _
        "ataMember><EditType>NoEdit</EditType><Key>desc_madrak_tahsili</Key><Position>2</" & _
        "Position><Width>72</Width></Column2></Columns><GroupCondition ID="""" /></RootTabl" & _
        "e></GridEXLayoutData>"
        Me.GrdMadrak.DesignTimeLayout = GridEXLayout2
        Me.GrdMadrak.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdMadrak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdMadrak.GridLines = Janus.Windows.GridEX.GridLines.None
        Me.GrdMadrak.GroupByBoxVisible = False
        Me.GrdMadrak.Location = New System.Drawing.Point(176, 328)
        Me.GrdMadrak.Name = "GrdMadrak"
        Me.GrdMadrak.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrdMadrak.Size = New System.Drawing.Size(128, 88)
        Me.GrdMadrak.TabIndex = 10
        Me.GrdMadrak.Visible = False
        '
        'GrdReshteMadrak
        '
        Me.GrdReshteMadrak.AllowColumnDrag = False
        Me.GrdReshteMadrak.DataMember = "DtGrdReshteMadrak"
        Me.GrdReshteMadrak.DataSource = Me.DsFrmMoshakhasatEhrazShoghly1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Col1""><Allow" & _
        "Drag>False</AllowDrag><AllowSize>False</AllowSize><AllowSort>False</AllowSort><B" & _
        "ound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><Key>Col1</Key><Position>" & _
        "0</Position><Width>25</Width></Column0><Column1 ID=""Col2""><AllowDrag>False</Allo" & _
        "wDrag><AllowSize>False</AllowSize><AllowSort>False</AllowSort><Bound>False</Boun" & _
        "d><ButtonStyle>ButtonCell</ButtonStyle><Key>Col2</Key><Position>1</Position><Wid" & _
        "th>29</Width></Column1><Column2 ID=""code_reshteh_tahsili""><AllowDrag>False</Allo" & _
        "wDrag><AllowSize>False</AllowSize><Caption>òœ —‘ Â</Caption><DataMember>code_res" & _
        "hteh_tahsili</DataMember><Key>code_reshteh_tahsili</Key><Position>2</Position><W" & _
        "idth>65</Width></Column2><Column3 ID=""desc_reshteh_tahsili""><AllowDrag>False</Al" & _
        "lowDrag><AllowSize>False</AllowSize><Caption>‘—Õ —‘ Â  Õ’Ì·Ì</Caption><DataMembe" & _
        "r>desc_reshteh_tahsili</DataMember><EditType>NoEdit</EditType><Key>desc_reshteh_" & _
        "tahsili</Key><Position>3</Position><Width>189</Width></Column3><Column4 ID=""cod_" & _
        "madrak""><AllowDrag>False</AllowDrag><AllowSize>False</AllowSize><AllowSort>False" & _
        "</AllowSort><Bound>False</Bound><Caption>„œ—ò  Õ’Ì·Ì</Caption><Key>cod_madrak</K" & _
        "ey><Position>4</Position><Width>128</Width></Column4><Column5 ID=""remark""><Capti" & _
        "on> Ê÷ÌÕ« </Caption><DataMember>remark</DataMember><Key>remark</Key><Position>5<" & _
        "/Position><Width>146</Width></Column5></Columns><GroupCondition ID="""" /><RowHead" & _
        "erWidth>16</RowHeaderWidth><RowHeight>16</RowHeight></RootTable></GridEXLayoutDa" & _
        "ta>"
        Me.GrdReshteMadrak.DesignTimeLayout = GridEXLayout3
        Me.GrdReshteMadrak.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdReshteMadrak.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdReshteMadrak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdReshteMadrak.GroupByBoxVisible = False
        Me.GrdReshteMadrak.Location = New System.Drawing.Point(0, 307)
        Me.GrdReshteMadrak.Name = "GrdReshteMadrak"
        Me.GrdReshteMadrak.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrdReshteMadrak.Size = New System.Drawing.Size(614, 261)
        Me.GrdReshteMadrak.TabIndex = 11
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT code_reshteh_tahsili, desc_reshteh_tahsili FROM tas_bas_reshteh_tahsili"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DAtas_bas_reshteh_tahsili
        '
        Me.DAtas_bas_reshteh_tahsili.SelectCommand = Me.SqlSelectCommand6
        Me.DAtas_bas_reshteh_tahsili.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_reshteh_tahsili", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_reshteh_tahsili", "code_reshteh_tahsili"), New System.Data.Common.DataColumnMapping("desc_reshteh_tahsili", "desc_reshteh_tahsili")})})
        '
        'CmdGeneral
        '
        Me.CmdGeneral.CommandText = "SELECT tas_tr_groupreshtehtahsili_reshtehtahsili.code_group_reshteh_tahsili, tas_" & _
        "tr_groupreshtehtahsili_reshtehtahsili.code_reshteh_tahsili, tas_bas_reshteh_tahs" & _
        "ili.desc_reshteh_tahsili FROM tas_tr_groupreshtehtahsili_reshtehtahsili INNER JO" & _
        "IN tas_bas_reshteh_tahsili ON tas_tr_groupreshtehtahsili_reshtehtahsili.code_res" & _
        "hteh_tahsili = tas_bas_reshteh_tahsili.code_reshteh_tahsili"
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DAtas_tr_rasteh_reshteh
        '
        Me.DAtas_tr_rasteh_reshteh.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAtas_tr_rasteh_reshteh.InsertCommand = Me.SqlInsertCommand1
        Me.DAtas_tr_rasteh_reshteh.SelectCommand = Me.SqlSelectCommand5
        Me.DAtas_tr_rasteh_reshteh.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_tr_rasteh_reshteh", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_rasteh_reshteh", "id_rasteh_reshteh"), New System.Data.Common.DataColumnMapping("code_rasteh", "code_rasteh"), New System.Data.Common.DataColumnMapping("code_reshteh_shoghli", "code_reshteh_shoghli"), New System.Data.Common.DataColumnMapping("code_group_estekhdami_from", "code_group_estekhdami_from"), New System.Data.Common.DataColumnMapping("code_group_estekhdami_to", "code_group_estekhdami_to"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar"), New System.Data.Common.DataColumnMapping("code_markaz", "code_markaz")})})
        Me.DAtas_tr_rasteh_reshteh.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM tas_tr_rasteh_reshteh WHERE (id_rasteh_reshteh = @Original_id_rasteh_" & _
        "reshteh) AND (code_bandar = @Original_code_bandar) AND (code_group_estekhdami_fr" & _
        "om = @Original_code_group_estekhdami_from OR @Original_code_group_estekhdami_fro" & _
        "m IS NULL AND code_group_estekhdami_from IS NULL) AND (code_group_estekhdami_to " & _
        "= @Original_code_group_estekhdami_to OR @Original_code_group_estekhdami_to IS NU" & _
        "LL AND code_group_estekhdami_to IS NULL) AND (code_markaz = @Original_code_marka" & _
        "z OR @Original_code_markaz IS NULL AND code_markaz IS NULL) AND (code_rasteh = @" & _
        "Original_code_rasteh) AND (code_reshteh_shoghli = @Original_code_reshteh_shoghli" & _
        ") AND (remark = @Original_remark OR @Original_remark IS NULL AND remark IS NULL)" & _
        ""
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_rasteh_reshteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_rasteh_reshteh", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_bandar", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_bandar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_group_estekhdami_from", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_estekhdami_from", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_group_estekhdami_to", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_estekhdami_to", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_markaz", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_markaz", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_rasteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_rasteh", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_shoghli", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO tas_tr_rasteh_reshteh(code_rasteh, code_reshteh_shoghli, code_group_e" & _
        "stekhdami_from, code_group_estekhdami_to, remark, code_bandar, code_markaz) VALU" & _
        "ES (@code_rasteh, @code_reshteh_shoghli, @code_group_estekhdami_from, @code_grou" & _
        "p_estekhdami_to, @remark, @code_bandar, @code_markaz); SELECT id_rasteh_reshteh," & _
        " code_rasteh, code_reshteh_shoghli, code_group_estekhdami_from, code_group_estek" & _
        "hdami_to, remark, code_bandar, code_markaz FROM tas_tr_rasteh_reshteh WHERE (id_" & _
        "rasteh_reshteh = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_rasteh", System.Data.SqlDbType.SmallInt, 2, "code_rasteh"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_shoghli"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_estekhdami_from", System.Data.SqlDbType.VarChar, 2, "code_group_estekhdami_from"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_estekhdami_to", System.Data.SqlDbType.VarChar, 2, "code_group_estekhdami_to"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 100, "remark"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.SmallInt, 2, "code_bandar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.SmallInt, 2, "code_markaz"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id_rasteh_reshteh, code_rasteh, code_reshteh_shoghli, remark, code_bandar," & _
        " code_group_estekhdami_from, code_group_estekhdami_to FROM tas_tr_rasteh_reshteh" & _
        " WHERE (code_rasteh = @code_rasteh)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_rasteh", System.Data.SqlDbType.SmallInt, 2, "code_rasteh"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE tas_tr_rasteh_reshteh SET code_rasteh = @code_rasteh, code_reshteh_shoghli" & _
        " = @code_reshteh_shoghli, code_group_estekhdami_from = @code_group_estekhdami_fr" & _
        "om, code_group_estekhdami_to = @code_group_estekhdami_to, remark = @remark, code" & _
        "_bandar = @code_bandar, code_markaz = @code_markaz WHERE (id_rasteh_reshteh = @O" & _
        "riginal_id_rasteh_reshteh) AND (code_bandar = @Original_code_bandar) AND (code_g" & _
        "roup_estekhdami_from = @Original_code_group_estekhdami_from OR @Original_code_gr" & _
        "oup_estekhdami_from IS NULL AND code_group_estekhdami_from IS NULL) AND (code_gr" & _
        "oup_estekhdami_to = @Original_code_group_estekhdami_to OR @Original_code_group_e" & _
        "stekhdami_to IS NULL AND code_group_estekhdami_to IS NULL) AND (code_markaz = @O" & _
        "riginal_code_markaz OR @Original_code_markaz IS NULL AND code_markaz IS NULL) AN" & _
        "D (code_rasteh = @Original_code_rasteh) AND (code_reshteh_shoghli = @Original_co" & _
        "de_reshteh_shoghli) AND (remark = @Original_remark OR @Original_remark IS NULL A" & _
        "ND remark IS NULL); SELECT id_rasteh_reshteh, code_rasteh, code_reshteh_shoghli," & _
        " code_group_estekhdami_from, code_group_estekhdami_to, remark, code_bandar, code" & _
        "_markaz FROM tas_tr_rasteh_reshteh WHERE (id_rasteh_reshteh = @id_rasteh_reshteh" & _
        ")"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_rasteh", System.Data.SqlDbType.SmallInt, 2, "code_rasteh"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_shoghli"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_estekhdami_from", System.Data.SqlDbType.VarChar, 2, "code_group_estekhdami_from"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_estekhdami_to", System.Data.SqlDbType.VarChar, 2, "code_group_estekhdami_to"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 100, "remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.SmallInt, 2, "code_bandar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.SmallInt, 2, "code_markaz"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_rasteh_reshteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_rasteh_reshteh", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_bandar", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_bandar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_group_estekhdami_from", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_estekhdami_from", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_group_estekhdami_to", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_estekhdami_to", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_markaz", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_markaz", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_rasteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_rasteh", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_shoghli", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rasteh_reshteh", System.Data.SqlDbType.SmallInt, 2, "id_rasteh_reshteh"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT desc_group_estekhdami, code_group_estekhdami FROM tas_bas_group_estekhdami" & _
        ""
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO tas_bas_group_estekhdami(code_group_estekhdami, desc_group_estekhdami" & _
        ", remark, adad_mabna, code_bandar, code_markaz, useradd, dateadd) VALUES (@code_" & _
        "group_estekhdami, @desc_group_estekhdami, @remark, @adad_mabna, @code_bandar, @c" & _
        "ode_markaz, @useradd, @dateadd); SELECT code_group_estekhdami, desc_group_estekh" & _
        "dami, remark, adad_mabna, code_bandar, code_markaz, useradd, dateadd FROM tas_ba" & _
        "s_group_estekhdami WHERE (code_group_estekhdami = @code_group_estekhdami)"
        Me.SqlInsertCommand5.Connection = Me.Cnn
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_estekhdami", System.Data.SqlDbType.VarChar, 2, "code_group_estekhdami"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_group_estekhdami", System.Data.SqlDbType.VarChar, 50, "desc_group_estekhdami"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adad_mabna", System.Data.SqlDbType.SmallInt, 2, "adad_mabna"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.VarChar, 2, "code_markaz"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@useradd", System.Data.SqlDbType.Int, 4, "useradd"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateadd", System.Data.SqlDbType.DateTime, 8, "dateadd"))
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE tas_bas_group_estekhdami SET code_group_estekhdami = @code_group_estekhdam" & _
        "i, desc_group_estekhdami = @desc_group_estekhdami, remark = @remark, adad_mabna " & _
        "= @adad_mabna, code_bandar = @code_bandar, code_markaz = @code_markaz, useradd =" & _
        " @useradd, dateadd = @dateadd WHERE (code_group_estekhdami = @Original_code_grou" & _
        "p_estekhdami) AND (adad_mabna = @Original_adad_mabna) AND (code_bandar = @Origin" & _
        "al_code_bandar OR @Original_code_bandar IS NULL AND code_bandar IS NULL) AND (co" & _
        "de_markaz = @Original_code_markaz OR @Original_code_markaz IS NULL AND code_mark" & _
        "az IS NULL) AND (dateadd = @Original_dateadd OR @Original_dateadd IS NULL AND da" & _
        "teadd IS NULL) AND (desc_group_estekhdami = @Original_desc_group_estekhdami) AND" & _
        " (remark = @Original_remark OR @Original_remark IS NULL AND remark IS NULL) AND " & _
        "(useradd = @Original_useradd OR @Original_useradd IS NULL AND useradd IS NULL); " & _
        "SELECT code_group_estekhdami, desc_group_estekhdami, remark, adad_mabna, code_ba" & _
        "ndar, code_markaz, useradd, dateadd FROM tas_bas_group_estekhdami WHERE (code_gr" & _
        "oup_estekhdami = @code_group_estekhdami)"
        Me.SqlUpdateCommand5.Connection = Me.Cnn
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_estekhdami", System.Data.SqlDbType.VarChar, 2, "code_group_estekhdami"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_group_estekhdami", System.Data.SqlDbType.VarChar, 50, "desc_group_estekhdami"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adad_mabna", System.Data.SqlDbType.SmallInt, 2, "adad_mabna"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.VarChar, 2, "code_markaz"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@useradd", System.Data.SqlDbType.Int, 4, "useradd"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateadd", System.Data.SqlDbType.DateTime, 8, "dateadd"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_group_estekhdami", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_estekhdami", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adad_mabna", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adad_mabna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_bandar", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_bandar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_markaz", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_markaz", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dateadd", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dateadd", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_group_estekhdami", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_group_estekhdami", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_useradd", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "useradd", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM tas_bas_group_estekhdami WHERE (code_group_estekhdami = @Original_cod" & _
        "e_group_estekhdami) AND (adad_mabna = @Original_adad_mabna) AND (code_bandar = @" & _
        "Original_code_bandar OR @Original_code_bandar IS NULL AND code_bandar IS NULL) A" & _
        "ND (code_markaz = @Original_code_markaz OR @Original_code_markaz IS NULL AND cod" & _
        "e_markaz IS NULL) AND (dateadd = @Original_dateadd OR @Original_dateadd IS NULL " & _
        "AND dateadd IS NULL) AND (desc_group_estekhdami = @Original_desc_group_estekhdam" & _
        "i) AND (remark = @Original_remark OR @Original_remark IS NULL AND remark IS NULL" & _
        ") AND (useradd = @Original_useradd OR @Original_useradd IS NULL AND useradd IS N" & _
        "ULL)"
        Me.SqlDeleteCommand5.Connection = Me.Cnn
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_group_estekhdami", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_estekhdami", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adad_mabna", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adad_mabna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_bandar", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_bandar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_markaz", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_markaz", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dateadd", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dateadd", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_group_estekhdami", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_group_estekhdami", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_useradd", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "useradd", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_bas_group_estekhdami
        '
        Me.DAtas_bas_group_estekhdami.DeleteCommand = Me.SqlDeleteCommand5
        Me.DAtas_bas_group_estekhdami.InsertCommand = Me.SqlInsertCommand5
        Me.DAtas_bas_group_estekhdami.SelectCommand = Me.SqlSelectCommand7
        Me.DAtas_bas_group_estekhdami.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_group_estekhdami", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_group_estekhdami", "code_group_estekhdami"), New System.Data.Common.DataColumnMapping("desc_group_estekhdami", "desc_group_estekhdami"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("adad_mabna", "adad_mabna"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar"), New System.Data.Common.DataColumnMapping("code_markaz", "code_markaz"), New System.Data.Common.DataColumnMapping("useradd", "useradd"), New System.Data.Common.DataColumnMapping("dateadd", "dateadd")})})
        Me.DAtas_bas_group_estekhdami.UpdateCommand = Me.SqlUpdateCommand5
        '
        'FrmMoshakhasatEhrazShoghly
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(614, 564)
        Me.Controls.Add(Me.GrdMadrak)
        Me.Controls.Add(Me.GrdReshteMadrak)
        Me.Controls.Add(Me.PnlReshte)
        Me.Controls.Add(Me.GrdRaste)
        Me.Controls.Add(Me.PnlRaste)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmMoshakhasatEhrazShoghly"
        Me.Panel9.ResumeLayout(False)
        Me.PnlRaste.ResumeLayout(False)
        CType(Me.DsFrmMoshakhasatEhrazShoghly1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmMoshakhasatEhraz1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlReshte.ResumeLayout(False)
        CType(Me.GrdRaste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdMadrak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdReshteMadrak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormStatus As Status = Status.CmbRasteFocus

    Enum Status
        CmbRasteFocus = 1
        GrdRasteFocus = 2
        GrdMadrakFocus = 3
    End Enum
    Private Sub FrmMoshakhasatEhrazShoghly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        Call FillDataset()
        Call EnableDisable(1)
        GrdRaste.RootTable.Columns("code_bandar").DefaultValue = PubBandarNO

    End Sub
    Private Sub FillDataset()

        DAtas_bas_rasteh.Fill(DsFrmMoshakhasatEhrazShoghly1)


        DAtas_bas_group_estekhdami.Fill(DsFrmMoshakhasatEhrazShoghly1)

        DAtas_bas_reshteh_shoghli.Fill(DsFrmMoshakhasatEhrazShoghly1)


        DAtas_bas_madrak_tahsili.Fill(DsFrmMoshakhasatEhrazShoghly1)

        DAtas_bas_reshteh_tahsili.Fill(DsFrmMoshakhasatEhrazShoghly1)

        'GrdRaste.DropDowns("DropDownGroupEstekhdamy").SetDataBinding(DsFrmMoshakhasatEhrazShoghly1, "tas_bas_group_estekhdami")
        GrdRaste.DropDowns("DropDown1").SetDataBinding(DsFrmMoshakhasatEhrazShoghly1, "tas_bas_reshteh_shoghli")
        GrdRaste.DropDowns("DropDownGroup").SetDataBinding(DsFrmMoshakhasatEhrazShoghly1, "tas_bas_group_estekhdami")
        
        'GrdReshteMadrak.DropDowns("Drop").SetDataBinding(DsFrmMoshakhasatEhrazShoghly1, "tas_bas_reshteh_shoghli")
        'GrdMadrak.DropDowns("DropMadrak").SetDataBinding(DsFrmMoshakhasatEhrazShoghly1, "tas_bas_madrak_tahsili")


    End Sub

    Private Sub MakeAllGroupOfDtGrdMadrak()
        Dim CodReshte As String
        If DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.Count > 0 Then
            CodReshte = DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(0).code_reshteh_tahsili
        End If
        For i As Integer = 0 To DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.Count - 1
            If DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_reshteh_tahsili <> CodReshte Or i = 0 Then

                Call MakeAGroupOfDtGrdMadraka(DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_reshteh_tahsili)

                CodReshte = DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_reshteh_tahsili
                Dim dr1 As DataRow
                dr1 = DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.NewDtGrdReshteMadrakRow
                dr1("code_reshteh_tahsili") = DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_reshteh_tahsili
                dr1("desc_reshteh_tahsili") = DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).desc_reshteh_tahsili & ""
                dr1("remark") = DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).remark

                DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.AddDtGrdReshteMadrakRow(dr1)
            End If
        Next
        For i As Integer = 0 To DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.Count - 1
            DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.FindBycode_madrak_tahsilicode_reshteh_tahsili(DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_madrak_tahsili, DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_reshteh_tahsili).flag = True
        Next
        Dim count As Integer = DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_tahsili.Count - DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Count + 4
        For i As Integer = 0 To count
            Dim dr As DataRow
            dr = DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.NewDtGrdReshteMadrakRow
            dr("desc_reshteh_tahsili") = ""
            dr("code_reshteh_tahsili") = ""
            dr("remark") = ""
            DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.AddDtGrdReshteMadrakRow(dr)
        Next
        'If DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.Count > 0 Then
        '    Call MakeGrdComboMadrakForEachRow(DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(0).code_reshteh_tahsili)
        'End If
    End Sub
    Private Sub MakeAGroupOfDtGrdMadraka(ByVal CodReshte As String)
        If Not (DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.FindBycode_madrak_tahsilicode_reshteh_tahsili(DsFrmMoshakhasatEhrazShoghly1.tas_bas_madrak_tahsili(0).code_madrak_tahsili, CodReshte) Is Nothing) Then
            Exit Sub
        End If

        For j As Integer = 0 To DsFrmMoshakhasatEhrazShoghly1.tas_bas_madrak_tahsili.Count - 1
            Dim dr As DataRow
            dr = DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.NewDtGrdMadrakRow
            dr("code_madrak_tahsili") = DsFrmMoshakhasatEhrazShoghly1.tas_bas_madrak_tahsili(j).code_madrak_tahsili
            dr("code_reshteh_tahsili") = CodReshte
            dr("desc_madrak_tahsili") = DsFrmMoshakhasatEhrazShoghly1.tas_bas_madrak_tahsili(j).desc_madrak_tahsili
            dr("flag") = False
            DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.AddDtGrdMadrakRow(dr)
        Next
    End Sub
    Private Sub MakeGrdComboMadrakForEachRow(ByVal CodReshteh As String)
        Dim dr() As DataRow
        dr = DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.Select("code_reshteh_tahsili = " & Qt(CodReshteh))
        GrdMadrak.DataSource = dr
        GrdMadrak.Visible = True
    End Sub
    Private Sub EnableDisable(ByVal State As Byte)
        Select Case State
            Case 1 '''form load
                FormStatus = Status.CmbRasteFocus
                GrdReshteMadrak.Enabled = False
                GrdRaste.Enabled = False
                PnlReshte.Enabled = False
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
            Case 2 ''CmdRasteOk  click
                FormStatus = Status.GrdRasteFocus
                PnlRaste.Enabled = False
                GrdRaste.Enabled = True
                BtnSave.Enabled = True
                BtnCancel.Enabled = True
            Case 3 '''Btn On Grid click
                FormStatus = Status.GrdMadrakFocus
                GrdRaste.Enabled = False
                GrdReshteMadrak.Enabled = True
            Case 4 '''cancel GrdRaste
                FormStatus = Status.CmbRasteFocus
                PnlRaste.Enabled = True
                GrdRaste.Enabled = False
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
            Case 5 '''Cancel GrdReshteMadrak
                FormStatus = Status.GrdRasteFocus
                GrdRaste.Enabled = True
                GrdReshteMadrak.Enabled = False
                GrdMadrak.Visible = False


        End Select
    End Sub
    Public Function SaveGrdRaste() As Boolean
        Dim c1 As New FrmWhatDoForMenu
        c1.ShowFarMsg("¬Ì«  „«„  €ÌÌ—«  À»  ‘Êœø")
        If c1.DialogResult = DialogResult.OK Then
            Try
                DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.AcceptChanges()
                DAtas_tr_rasteh_reshteh.Update(DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh)
                SaveGrdRaste = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            SaveGrdRaste = False
        End If
    End Function
    Private Sub SaveGrdReshteMadrak()
        Dim dr() As DataRow
        Dim c1 As New FrmWhatDoForMenu
        c1.ShowFarMsg("¬Ì«  „«„  €ÌÌ—«  À»  ‘Êœø")
        If c1.DialogResult = DialogResult.OK Then
            For i As Integer = 0 To DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.Count - 1
                dr = DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select(" code_reshteh_tahsili = " & Qt(DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_reshteh_tahsili))
                If Not (dr.Length = 0) Then
                    If DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).flag = True Then
                        If Not (DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.FindBycode_madrak_tahsilicode_reshteh_tahsiLI(DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_madrak_tahsili, DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_reshteh_tahsili) Is Nothing) Then
                            DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.FindBycode_madrak_tahsilicode_reshteh_tahsili(DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_madrak_tahsili, DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_reshteh_tahsili).flag = True
                            If DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.FindBycode_madrak_tahsilicode_reshteh_tahsili(DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_madrak_tahsili, DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_reshteh_tahsili).remark <> dr(0).Item("remark") Then
                                Call Updateshoghlha_madrak_reshteha(DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_madrak_tahsili, DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_reshteh_tahsili, LblCodShoghl.Text, dr(0).Item("remark"))
                            End If

                        Else
                            Call Insertshoghlha_madrak_reshteha(DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_madrak_tahsili, DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak(i).code_reshteh_tahsili, LblCodShoghl.Text, dr(0).Item("remark"))
                        End If
                    End If

                End If
            Next
        Else
        End If
        For i As Integer = 0 To DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.Count - 1
            If DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).flag = False Then
                Call Deleteshoghlha_madrak_reshteha(DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_madrak_tahsili, DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha(i).code_reshteh_tahsili, LblCodShoghl.Text)

            End If
        Next
        DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Clear()
        DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.Clear()
        DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.Clear()

        DAtas_tr_shoghlha_madrak_reshteha.SelectCommand.Parameters("@id_rasteh_reshteh").Value = LblCodShoghl.Text
        DAtas_tr_shoghlha_madrak_reshteha.Fill(DsFrmMoshakhasatEhrazShoghly1)

        Call MakeAllGroupOfDtGrdMadrak()

    End Sub
    Private Sub Insertshoghlha_madrak_reshteha(ByVal Madrak As String, ByVal ReshteTahsili As String, ByVal ReshteShoghli As String, ByVal remark As String)

        If DAtas_tr_shoghlha_madrak_reshteha.InsertCommand.Connection.State <> ConnectionState.Open Then
            DAtas_tr_shoghlha_madrak_reshteha.InsertCommand.Connection.Open()
        End If
        With DAtas_tr_shoghlha_madrak_reshteha.InsertCommand
            .Parameters("@code_madrak_tahsili").Value = Madrak
            .Parameters("@code_reshteh_tahsili").Value = ReshteTahsili
            .Parameters("@id_rasteh_reshteh").Value = ReshteShoghli
            .Parameters("@remark").Value = remark
            .Parameters("@code_bandar").Value = PubBandarNO
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            .Connection.Close()
        End With


    End Sub
    Private Sub Updateshoghlha_madrak_reshteha(ByVal Madrak As String, ByVal ReshteTahsili As String, ByVal ReshteShoghli As String, ByVal remark As String)
        If DAtas_tr_shoghlha_madrak_reshteha.UpdateCommand.Connection.State <> ConnectionState.Open Then
            DAtas_tr_shoghlha_madrak_reshteha.UpdateCommand.Connection.Open()
        End If
        With DAtas_tr_shoghlha_madrak_reshteha.UpdateCommand
            .Parameters("@code_madrak_tahsili").Value = Madrak
            .Parameters("@code_reshteh_tahsili").Value = ReshteTahsili
            .Parameters("@id_rasteh_reshteh").Value = ReshteShoghli
            .Parameters("@remark").Value = remark
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            .Connection.Close()
        End With
    End Sub
    Private Sub Deleteshoghlha_madrak_reshteha(ByVal Madrak As String, ByVal ReshteTahsili As String, ByVal ReshteShoghli As String)
        If DAtas_tr_shoghlha_madrak_reshteha.DeleteCommand.Connection.State <> ConnectionState.Open Then
            DAtas_tr_shoghlha_madrak_reshteha.DeleteCommand.Connection.Open()
        End If
        With DAtas_tr_shoghlha_madrak_reshteha.DeleteCommand
            .Parameters("@code_madrak_tahsili").Value = Madrak
            .Parameters("@code_reshteh_tahsili").Value = ReshteTahsili
            .Parameters("@id_rasteh_reshteh").Value = ReshteShoghli
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            .Connection.Close()
        End With
    End Sub

    Private Sub CmdRasteOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRasteOk.Click
        If CmbRaste.Text = "" Then
            MsgFar("«» œ« —” Â „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.Clear()
            DAtas_tr_rasteh_reshteh.SelectCommand.Parameters("@code_rasteh").Value = CmbRaste.SelectedValue
            Try
                DAtas_tr_rasteh_reshteh.Fill(DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


            GrdRaste.RootTable.Columns("code_rasteh").DefaultValue = CmbRaste.SelectedValue
            Call EnableDisable(2)
            GrdRaste.SetDataBinding(DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.DefaultView, "")

            'Dim count As Integer = DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_shoghli.Count - DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.Count + 2
            'For i As Integer = 0 To count
            '    Dim dr As DataRow
            '    dr = DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.Newtas_tr_rasteh_reshtehRow
            '    dr("desc_reshteh_tahsili") = ""
            '    dr("code_reshteh_tahsili") = ""
            '    dr("remark") = ""
            '    DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.Addtas_tr_rasteh_reshtehRow(dr)
            'Next
        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If FormStatus = Status.GrdRasteFocus Then
            Call SaveGrdRaste()
        ElseIf FormStatus = Status.GrdMadrakFocus Then
            Call SaveGrdReshteMadrak()

        End If

    End Sub

    Private Sub GrdRaste_SelectionChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdRaste.SelectionChanged
        Dim Currentrow As GridEXRow = GrdRaste.GetRow
        If Currentrow.RowIndex < 0 Then
            LblReshteShoghli.Text = ""
        Else
            LblReshteShoghli.Text = Currentrow.Cells("desc_reshteh_shoghli").Text
        End If
    End Sub

    Private Sub GrdRaste_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdRaste.ColumnButtonClick
        Dim Currentrow As GridEXRow = GrdRaste.GetRow
        Dim CodShoghl As String = Currentrow.Cells("id_rasteh_reshteh").Value
        If e.Column.Index = 0 Then
            If Currentrow.RowIndex < 0 Then
            Else
                Call EnableDisable(3)
                DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.DefaultView.RowStateFilter = DataViewRowState.Added
                If DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.DefaultView.Count > 0 Then

                    If SaveGrdRaste() Then
                        DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.Clear()
                        DAtas_tr_rasteh_reshteh.SelectCommand.Parameters("@code_rasteh").Value = CmbRaste.SelectedValue

                        DAtas_tr_rasteh_reshteh.Fill(DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh)
                        GrdRaste.RootTable.Columns("code_rasteh").DefaultValue = CmbRaste.SelectedValue
                    Else
                        DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.RejectChanges()
                    End If
                Else
                    DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Clear()
                    DsFrmMoshakhasatEhrazShoghly1.DtGrdMadrak.Clear()
                    DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha.Clear()

                    DAtas_tr_shoghlha_madrak_reshteha.SelectCommand.Parameters("@id_rasteh_reshteh").Value = CodShoghl
                    DAtas_tr_shoghlha_madrak_reshteha.Fill(DsFrmMoshakhasatEhrazShoghly1.tas_tr_shoghlha_madrak_reshteha)
                    LblCodShoghl.Text = CodShoghl
                    GrdReshteMadrak.Col = 1

                    Call MakeAllGroupOfDtGrdMadrak()
                End If

                DsFrmMoshakhasatEhrazShoghly1.tas_tr_rasteh_reshteh.DefaultView.RowStateFilter = DataViewRowState.CurrentRows


            End If
        ElseIf e.Column.Index = 1 Then
            Dim f As New FrmFind
            f.KindForm = FrmFind.KindFind.FindReshteShoghli
            f.ShowDialog()
            If f.Id <> "x" Then
                Currentrow.Cells("code_reshteh_shoghli").Text = f.Id
                Currentrow.Cells("desc_reshteh_shoghli").Value = f.Id
                DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_shoghli.AcceptChanges()
            End If


        End If
        'End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If FormStatus = Status.GrdRasteFocus Then
            Call EnableDisable(4)
        Else
            If FormStatus = Status.GrdMadrakFocus Then
                Call EnableDisable(5)
            End If
        End If

    End Sub

    Private Sub GrdRaste_DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdRaste.DeletingRecords
        Dim c1 As New FrmWhatDoForMenu
        c1.ShowFarMsg("¬Ì« «Ì‰ —òÊ—œ Õ–› ‘Êœø")
        If c1.DialogResult = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub



    Private Sub GrdReshteMadrak_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrdReshteMadrak.SelectionChanged
        If GrdReshteMadrak.CurrentColumn Is Nothing Then
            GrdMadrak.Visible = False
            Exit Sub
        End If

        Dim Currentrow As GridEXRow = GrdReshteMadrak.GetRow

        If Currentrow.Cells("code_reshteh_tahsili").Value = "" Then
            'If GrdReshteMadrak.CurrentColumn.Index = 4 Then
            '    MsgFar("«» œ« òœ —‘ Â —« Ê«—œ ò‰Ìœ")
            GrdMadrak.Visible = False
            'End If
        Else
            If Currentrow.RowIndex < 0 Then

                'GrdMadrak.Top = 317
                'If DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select("code_reshteh_tahsili = " & Currentrow.Cells("code_reshteh_tahsili").Value) Is Nothing Then
                '    Call MakeAGroupOfDtGrdMadraka(Currentrow.Cells("code_reshteh_tahsili").Value)
                '    Call MakeGrdComboMadrakForEachRow(Currentrow.Cells("code_reshteh_tahsili").Value)
                'Else
                '    MsgFar("«Ì‰ òœ —‘ Â  ò—«—Ì «” ")

                'End If

            Else
                Call MakeAGroupOfDtGrdMadraka(Currentrow.Cells("code_reshteh_tahsili").Value)
                Call MakeGrdComboMadrakForEachRow(Currentrow.Cells("code_reshteh_tahsili").Value)
                'GrdMadrak.Top = 328 + (Currentrow.Position * 16)

            End If
        End If


        'Else
        'GrdMadrak.Visible = False
        'End If



    End Sub

    Private Sub GrdReshteMadrak_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdReshteMadrak.DoubleClick

    End Sub

    Private Sub GrdReshteMadrak_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GrdReshteMadrak.EditingCell
        If Not (GrdReshteMadrak.CurrentColumn Is Nothing) Then
            If e.Column.Index <> 4 Then
                GrdMadrak.Visible = False
                Exit Sub
            Else

                Dim Currentrow As GridEXRow = GrdReshteMadrak.GetRow

                If Currentrow.Cells("code_reshteh_tahsili").Value = "" Then
                    If GrdReshteMadrak.CurrentColumn.Index = 4 Then
                        MsgFar("«» œ« òœ —‘ Â —« Ê«—œ ò‰Ìœ")
                        GrdMadrak.Visible = False

                    End If
                Else
                    If Currentrow.RowIndex < 0 Then

                        'GrdMadrak.Top = 317
                        'If DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select("code_reshteh_tahsili = " & Currentrow.Cells("code_reshteh_tahsili").Value) Is Nothing Then
                        '    Call MakeAGroupOfDtGrdMadraka(Currentrow.Cells("code_reshteh_tahsili").Value)
                        '    Call MakeGrdComboMadrakForEachRow(Currentrow.Cells("code_reshteh_tahsili").Value)
                        'Else
                        '    MsgFar("«Ì‰ òœ —‘ Â  ò—«—Ì «” ")

                        'End If

                    Else
                        Call MakeAGroupOfDtGrdMadraka(Currentrow.Cells("code_reshteh_tahsili").Value)
                        Call MakeGrdComboMadrakForEachRow(Currentrow.Cells("code_reshteh_tahsili").Value)
                        'GrdMadrak.Top = 328 + (Currentrow.Position * 16)
                        '''''''''''''
                        Dim PntForm As Point
                        Dim PntLocation As Point
                        Dim OControl As Control
                        Dim SizeForm As Size
                        OControl = GrdReshteMadrak

                        SizeForm.Width = GrdMadrak.Width
                        SizeForm.Height = GrdMadrak.Height
                        PntLocation.X = OControl.Location.X '+ oControl.Size.Width - sizeForm.Width
                        PntLocation.Y = OControl.Location.Y + 2 + ((e.Column.GridEX.Row() + 2) * GrdReshteMadrak.RootTable.RowHeight) + 6 - SizeForm.Height
                        'PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2 + ((e.Column.GridEX.Row() + 2) * GrdReshteMadrak.RootTable.RowHeight) - OControl.Size.Height - 1

                        PntForm = OControl.Parent.PointToScreen(PntLocation)
                        If PntForm.Y + SizeForm.Height > Me.Height Then
                            PntForm.Y = PntForm.Y - SizeForm.Height - GrdReshteMadrak.RootTable.RowHeight
                        End If
                        If (PntForm.X < 0) Then PntForm.X = 0
                        'GrdMadrak.SetDesktopLocatio(PntForm.X, PntForm.Y)
                        'GrdMadrak.Left = PntForm.X
                        GrdMadrak.Top = PntForm.Y
                        '''''''''

                        GrdMadrak.Focus()
                        e.Cancel = True
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub GrdReshteMadrak_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GrdReshteMadrak.UpdatingCell
        If e.Column.Index <> 4 Then
            GrdMadrak.Visible = False
        End If
        If e.Column.Index = 2 Then
            If e.Value <> "" Then
                'If Not (DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select("code_reshteh_tahsili = " & Qt(e.Value)) Is Nothing) Then
                '    MsgFar("«Ì‰ òœ —‘ Â  ò—«—Ì «” ")
                '    e.Cancel = True

                'Else
                If CStr(e.Value).Trim = "" Then
                    Exit Sub
                End If
                If DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_tahsili.FindBycode_reshteh_tahsili(e.Value) Is Nothing Then
                    MsgFar("«Ì‰ òœ —‘ Â ÊÃÊœ ‰œ«—œ")
                    e.Cancel = True
                Else

                    'Dim dr() As DataRow
                    'dr = DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select("code_reshteh_tahsili = " & Qt(e.Value))

                    'For i As Integer = 0 To dr.Length - 1
                    '    dr(i).Item("desc_reshteh_tahsili") = DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_tahsili.FindBycode_reshteh_tahsili(e.Value).desc_reshteh_tahsili
                    'Next

                    Dim Currentrow As GridEXRow = GrdReshteMadrak.GetRow
                    If Not (Currentrow.RowIndex < 0) Then
                        Currentrow.Cells("desc_reshteh_tahsili").Value = DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_tahsili.FindBycode_reshteh_tahsili(e.Value).desc_reshteh_tahsili
                    End If
                    DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.AcceptChanges()

                End If
                'End If

            End If
        End If


    End Sub

    Private Sub GrdReshteMadrak_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdReshteMadrak.ColumnButtonClick
        Dim Currentrow As GridEXRow = GrdReshteMadrak.GetRow
        'If Currentrow.RowIndex < 0 Then
        'Else
        If e.Column.Index = 1 Then

            Dim f As New FrmFind
            f.KindForm = FrmFind.KindFind.FindReshteTahsili
            f.ShowDialog()
            If f.Id <> "x" Then
                Currentrow.Cells("code_reshteh_tahsili").Value = f.Id
                Currentrow.Cells("desc_reshteh_tahsili").Value = DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_tahsili.FindBycode_reshteh_tahsili(f.Id).desc_reshteh_tahsili
                DsFrmMoshakhasatEhrazShoghly1.tas_bas_reshteh_shoghli.AcceptChanges()

            End If



            Call MakeAllGroupOfDtGrdMadrak()
        ElseIf e.Column.Index = 0 Then
            If Currentrow.RowIndex < 0 Then
            Else

                Dim f As New FrmFind
                f.KindForm = FrmFind.KindFind.FindGroupReshteTahsili
                f.ShowDialog()
                If f.Id <> "x" Then
                    CmdGeneral.CommandText = "SELECT     tas_tr_groupreshtehtahsili_reshtehtahsili.code_reshteh_tahsili, " & _
                       " tas_bas_reshteh_tahsili.desc_reshteh_tahsili " & _
                       " FROM         tas_tr_groupreshtehtahsili_reshtehtahsili INNER JOIN " & _
                       " tas_bas_reshteh_tahsili ON tas_tr_groupreshtehtahsili_reshtehtahsili.code_reshteh_tahsili = tas_bas_reshteh_tahsili.code_reshteh_tahsili " & _
                       " where  tas_tr_groupreshtehtahsili_reshtehtahsili.code_group_reshteh_tahsili = " & Qt(f.Id)


                    Dim SqlReader As System.Data.SqlClient.SqlDataReader
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    SqlReader = CmdGeneral.ExecuteReader
                    Dim dr1() As DataRow

                    While SqlReader.Read
                        dr1 = DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select("code_reshteh_tahsili = " & Qt(SqlReader.Item("code_reshteh_tahsili")))
                        If dr1.Length = 0 Then
                            For i As Integer = 0 To DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Count - 1
                                If DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak(i).code_reshteh_tahsili = "" Then
                                    DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak(i).code_reshteh_tahsili = SqlReader.Item("code_reshteh_tahsili")
                                    DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak(i).desc_reshteh_tahsili = SqlReader.Item("desc_reshteh_tahsili")
                                    Exit For

                                End If
                            Next
                            'Dim dr As DataRow
                            'dr = DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.NewDtGrdReshteMadrakRow
                            'dr("code_reshteh_tahsili") = SqlReader.Item("code_reshteh_tahsili")
                            'dr("desc_reshteh_tahsili") = SqlReader.Item("desc_reshteh_tahsili")
                            'dr("remark") = ""
                            'DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.AddDtGrdReshteMadrakRow(dr)
                        End If
                    End While
                    CmdGeneral.Connection.Close()
                    DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select("", "code_reshteh_tahsili")



                End If
            End If


        End If
        'End If
    End Sub


    Private Sub GrdReshteMadrak_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdReshteMadrak.UpdatingRecord
        'For i As Integer = 0 To DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Count - 1

        '    e.Cancel = True
        'Next
        Dim Currentrow As GridEXRow = GrdReshteMadrak.GetRow
        Dim dr() As DataRow
        dr = DsFrmMoshakhasatEhrazShoghly1.DtGrdReshteMadrak.Select("code_reshteh_tahsili = " & Qt(Currentrow.Cells("code_reshteh_tahsili").Text))
        If dr.Length > 0 Then
            e.Cancel = True
        End If



    End Sub

    Private Sub GrdRaste_Error(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ErrorEventArgs) Handles GrdRaste.Error
        e.DisplayErrorMessage = False


    End Sub
    'Private Sub FitGrdMadrakOnGrid()
    '    Dim PntForm As Point
    '    Dim PntLocation As Point
    '    Dim OControl As Control
    '    Dim SizeForm As Size
    '    OControl = GrdReshteMadrak

    '    SizeForm.Width = GrdMadrak.Width
    '    SizeForm.Height = GrdMadrak.Height
    '    PntLocation.X = OControl.Location.X '+ oControl.Size.Width - sizeForm.Width
    '    PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2 + ((e.Column.GridEX.Row() + 2) * GrdDetail.RootTable.RowHeight) - OControl.Size.Height - 1


    '    PntForm = OControl.Parent.PointToScreen(PntLocation)
    '    If PntForm.Y + SizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
    '        PntForm.Y = PntForm.Y - SizeForm.Height - GrdReshteMadrak.RootTable.RowHeight
    '    End If
    '    If (PntForm.X < 0) Then PntForm.X = 0
    '    'GrdMadrak.SetDesktopLocatio(PntForm.X, PntForm.Y)
    '    GrdMadrak.Left = PntForm.X
    '    'GrdMadrak.Top = PntForm.Y
    'End Sub
   

    Private Sub GrdMadrak_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdMadrak.FormattingRow

    End Sub
End Class
