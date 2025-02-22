Imports CommonClass
Public Class FrmSearchEmployeeCode
    Inherits FrmBase
    Event EmployeeFind(ByVal ThisEmployeeCode As String, ByVal ThisEmployeeDesc As String)
    Public KindEmployee As String
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnViewRowdetail As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSearchEmployeeCode1 As UCEmployee.DSFrmSearchEmployeeCode
    Friend WithEvents ChkUsePunchClock As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchEmployeeCode))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtFirstName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtLastName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmSearchEmployeeCode1 = New UCEmployee.DSFrmSearchEmployeeCode
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.BtnViewRowdetail = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.ChkUsePunchClock = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchEmployeeCode1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PhoneNo1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtFirstName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtLastName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 62)
        Me.Panel1.TabIndex = 1
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(574, 11)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 346
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(574, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 345
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhoneNo1
        '
        Me.PhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNo1.Location = New System.Drawing.Point(438, 7)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(94, 22)
        Me.PhoneNo1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(391, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 22)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Phone"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(69, 36)
        Me.TxtFirstName.MaxLength = 20
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(245, 20)
        Me.TxtFirstName.TabIndex = 3
        Me.TxtFirstName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(69, 7)
        Me.TxtLastName.MaxLength = 20
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(245, 20)
        Me.TxtLastName.TabIndex = 0
        Me.TxtLastName.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Last Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>employee</Caption><Columns Collection=""true" & _
        """><Column0 ID=""employee_code""><Caption>Employee</Caption><TypeNameEmptyStringVal" & _
        "ue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>emplo" & _
        "yee_code</DataMember><Key>employee_code</Key><Position>0</Position></Column0><Co" & _
        "lumn1 ID=""f_name""><Caption>First name</Caption><DataMember>f_name</DataMember><K" & _
        "ey>f_name</Key><Position>1</Position></Column1><Column2 ID=""m_name""><Caption>Mid" & _
        "dle</Caption><DataMember>m_name</DataMember><Key>m_name</Key><Position>2</Positi" & _
        "on><Width>74</Width></Column2><Column3 ID=""l_name""><Caption>Last Name</Caption><" & _
        "DataMember>l_name</DataMember><Key>l_name</Key><Position>3</Position><Width>115<" & _
        "/Width></Column3><Column4 ID=""address""><Caption>Address</Caption><DataMember>add" & _
        "ress</DataMember><Key>address</Key><Position>4</Position><Width>186</Width></Col" & _
        "umn4><Column5 ID=""zipcode""><Caption>Zip</Caption><DataMember>zipcode</DataMember" & _
        "><Key>zipcode</Key><Position>5</Position><Width>59</Width></Column5><Column6 ID=" & _
        """technecian""><Caption>Technecian</Caption><ColumnType>CheckBox</ColumnType><Data" & _
        "Member>technecian</DataMember><EditType>CheckBox</EditType><Key>technecian</Key>" & _
        "<Position>6</Position><Width>71</Width></Column6><Column7 ID=""SalesPerson""><Capt" & _
        "ion>Sales Person</Caption><ColumnType>CheckBox</ColumnType><DataMember>SalesPers" & _
        "on</DataMember><EditType>CheckBox</EditType><Key>SalesPerson</Key><Position>7</P" & _
        "osition><Width>80</Width></Column7><Column8 ID=""social_security_no""><Caption>Soc" & _
        "ial Security</Caption><DataMember>social_security_no</DataMember><Key>social_sec" & _
        "urity_no</Key><Position>8</Position></Column8><Column9 ID=""cod_position""><Captio" & _
        "n>Position</Caption><DataMember>cod_position</DataMember><Key>cod_position</Key>" & _
        "<Position>9</Position></Column9><Column10 ID=""cod_deparment""><Caption>Deparment<" & _
        "/Caption><DataMember>cod_deparment</DataMember><Key>cod_deparment</Key><Position" & _
        ">10</Position></Column10><Column11 ID=""phone_1""><Caption>phone</Caption><DataMem" & _
        "ber>phone_1</DataMember><Key>phone_1</Key><Position>11</Position></Column11><Col" & _
        "umn12 ID=""phone_main_1""><Caption>phone_main_1</Caption><ColumnType>CheckBox</Col" & _
        "umnType><DataMember>phone_main_1</DataMember><EditType>CheckBox</EditType><Key>p" & _
        "hone_main_1</Key><Position>12</Position><Visible>False</Visible></Column12><Colu" & _
        "mn13 ID=""phone_2""><Caption>phone_2</Caption><DataMember>phone_2</DataMember><Key" & _
        ">phone_2</Key><Position>13</Position><Visible>False</Visible></Column13><Column1" & _
        "4 ID=""extension_2""><Caption>extension_2</Caption><DataMember>extension_2</DataMe" & _
        "mber><Key>extension_2</Key><Position>14</Position><Visible>False</Visible></Colu" & _
        "mn14><Column15 ID=""phone_type_2""><Caption>phone_type_2</Caption><DataMember>phon" & _
        "e_type_2</DataMember><Key>phone_type_2</Key><Position>15</Position><Visible>Fals" & _
        "e</Visible></Column15><Column16 ID=""phone_main_2""><Caption>phone_main_2</Caption" & _
        "><ColumnType>CheckBox</ColumnType><DataMember>phone_main_2</DataMember><EditType" & _
        ">CheckBox</EditType><Key>phone_main_2</Key><Position>16</Position><Visible>False" & _
        "</Visible></Column16><Column17 ID=""phone_3""><Caption>phone_3</Caption><DataMembe" & _
        "r>phone_3</DataMember><Key>phone_3</Key><Position>17</Position><Visible>False</V" & _
        "isible></Column17><Column18 ID=""extension_3""><Caption>extension_3</Caption><Data" & _
        "Member>extension_3</DataMember><Key>extension_3</Key><Position>18</Position><Vis" & _
        "ible>False</Visible></Column18><Column19 ID=""phone_type_3""><Caption>phone_type_3" & _
        "</Caption><DataMember>phone_type_3</DataMember><Key>phone_type_3</Key><Position>" & _
        "19</Position><Visible>False</Visible></Column19><Column20 ID=""phone_main_3""><Cap" & _
        "tion>phone_main_3</Caption><ColumnType>CheckBox</ColumnType><DataMember>phone_ma" & _
        "in_3</DataMember><EditType>CheckBox</EditType><Key>phone_main_3</Key><Position>2" & _
        "0</Position><Visible>False</Visible></Column20><Column21 ID=""phone_4""><Caption>p" & _
        "hone_4</Caption><DataMember>phone_4</DataMember><Key>phone_4</Key><Position>21</" & _
        "Position><Visible>False</Visible></Column21><Column22 ID=""extension_4""><Caption>" & _
        "extension_4</Caption><DataMember>extension_4</DataMember><Key>extension_4</Key><" & _
        "Position>22</Position><Visible>False</Visible></Column22><Column23 ID=""phone_typ" & _
        "e_4""><Caption>phone_type_4</Caption><DataMember>phone_type_4</DataMember><Key>ph" & _
        "one_type_4</Key><Position>23</Position><Visible>False</Visible></Column23><Colum" & _
        "n24 ID=""phone_main_4""><Caption>phone_main_4</Caption><ColumnType>CheckBox</Colum" & _
        "nType><DataMember>phone_main_4</DataMember><EditType>CheckBox</EditType><Key>pho" & _
        "ne_main_4</Key><Position>24</Position><Visible>False</Visible></Column24><Column" & _
        "25 ID=""phone_5""><Caption>phone_5</Caption><DataMember>phone_5</DataMember><Key>p" & _
        "hone_5</Key><Position>25</Position><Visible>False</Visible></Column25><Column26 " & _
        "ID=""extension_5""><Caption>extension_5</Caption><DataMember>extension_5</DataMemb" & _
        "er><Key>extension_5</Key><Position>26</Position><Visible>False</Visible></Column" & _
        "26><Column27 ID=""email""><Caption>Email</Caption><DataMember>email</DataMember><K" & _
        "ey>email</Key><Position>27</Position></Column27><Column28 ID=""notes""><Caption>No" & _
        "tes</Caption><DataMember>notes</DataMember><Key>notes</Key><Position>28</Positio" & _
        "n></Column28><Column29 ID=""pic""><AllowGroup>False</AllowGroup><AllowSort>False</" & _
        "AllowSort><Caption>Picture</Caption><ColumnType>BoundImage</ColumnType><DataMemb" & _
        "er>pic</DataMember><EditType>NoEdit</EditType><Key>pic</Key><Position>29</Positi" & _
        "on></Column29><Column30 ID=""birthday_date""><Caption>Birthday</Caption><DataMembe" & _
        "r>birthday_date</DataMember><Key>birthday_date</Key><Position>30</Position><Widt" & _
        "h>78</Width></Column30><Column31 ID=""hired_date""><Caption>Hired Date</Caption><D" & _
        "ataMember>hired_date</DataMember><Key>hired_date</Key><Position>31</Position><Wi" & _
        "dth>89</Width></Column31><Column32 ID=""last_reiew_date""><Caption>Last Review</Ca" & _
        "ption><DataMember>last_reiew_date</DataMember><Key>last_reiew_date</Key><Positio" & _
        "n>32</Position><Width>92</Width></Column32><Column33 ID=""terminate_date""><Captio" & _
        "n>Terminate Date</Caption><DataMember>terminate_date</DataMember><Key>terminate_" & _
        "date</Key><Position>33</Position><Width>87</Width></Column33><Column34 ID=""tempo" & _
        "rary_inactive""><Caption>Inactive</Caption><ColumnType>CheckBox</ColumnType><Data" & _
        "Member>temporary_inactive</DataMember><EditType>CheckBox</EditType><Key>temporar" & _
        "y_inactive</Key><Position>34</Position><Width>52</Width></Column34><Column35 ID=" & _
        """last_basis""><Caption>last_basis</Caption><DataMember>last_basis</DataMember><Ke" & _
        "y>last_basis</Key><Position>35</Position><Visible>False</Visible></Column35><Col" & _
        "umn36 ID=""last_period""><Caption>last_period</Caption><DataMember>last_period</Da" & _
        "taMember><Key>last_period</Key><Position>36</Position><Visible>False</Visible></" & _
        "Column36><Column37 ID=""last_status""><Caption>Status</Caption><DataMember>last_st" & _
        "atus</DataMember><Key>last_status</Key><Position>37</Position></Column37><Column" & _
        "38 ID=""last_salary""><Caption>Salary</Caption><DataMember>last_salary</DataMember" & _
        "><FormatString>c2</FormatString><Key>last_salary</Key><Position>38</Position><Te" & _
        "xtAlignment>Far</TextAlignment><Width>89</Width></Column38><Column39 ID=""last_ho" & _
        "urly""><Caption>Hourly Rate</Caption><DataMember>last_hourly</DataMember><FormatS" & _
        "tring>c2</FormatString><Key>last_hourly</Key><Position>39</Position><TextAlignme" & _
        "nt>Far</TextAlignment><Width>89</Width></Column39><Column40 ID=""Terminated""><Cap" & _
        "tion>Terminated</Caption><ColumnType>CheckBox</ColumnType><DataMember>Terminated" & _
        "</DataMember><EditType>CheckBox</EditType><Key>Terminated</Key><Position>40</Pos" & _
        "ition><Width>68</Width></Column40><Column41 ID=""last_overtime""><Caption>last_ove" & _
        "rtime</Caption><DataMember>last_overtime</DataMember><FormatString>c</FormatStri" & _
        "ng><Key>last_overtime</Key><Position>41</Position><TextAlignment>Far</TextAlignm" & _
        "ent><Visible>False</Visible></Column41><Column42 ID=""Last_raise_date""><Caption>L" & _
        "ast_raise_date</Caption><DataMember>Last_raise_date</DataMember><Key>Last_raise_" & _
        "date</Key><Position>42</Position><Visible>False</Visible></Column42><Column43 ID" & _
        "=""Allowance_Federal""><Caption>Allowance_Federal</Caption><DataMember>Allowance_F" & _
        "ederal</DataMember><Key>Allowance_Federal</Key><Position>43</Position><Visible>F" & _
        "alse</Visible></Column43><Column44 ID=""Allowance_state""><Caption>Allowance_state" & _
        "</Caption><DataMember>Allowance_state</DataMember><Key>Allowance_state</Key><Pos" & _
        "ition>44</Position><Visible>False</Visible></Column44><Column45 ID=""Allowance_de" & _
        "pndnts""><Caption>Allowance_depndnts</Caption><DataMember>Allowance_depndnts</Dat" & _
        "aMember><Key>Allowance_depndnts</Key><Position>45</Position><Visible>False</Visi" & _
        "ble></Column45><Column46 ID=""extension_1""><Caption>extension_1</Caption><DataMem" & _
        "ber>extension_1</DataMember><Key>extension_1</Key><Position>46</Position><Visibl" & _
        "e>False</Visible></Column46><Column47 ID=""phone_type_1""><Caption>phone_type_1</C" & _
        "aption><DataMember>phone_type_1</DataMember><Key>phone_type_1</Key><Position>47<" & _
        "/Position><Visible>False</Visible></Column47><Column48 ID=""phone_main_5""><Captio" & _
        "n>phone_main_5</Caption><ColumnType>CheckBox</ColumnType><DataMember>phone_main_" & _
        "5</DataMember><EditType>CheckBox</EditType><Key>phone_main_5</Key><Position>48</" & _
        "Position><Visible>False</Visible></Column48><Column49 ID=""phone_type_5""><Caption" & _
        ">phone_type_5</Caption><DataMember>phone_type_5</DataMember><Key>phone_type_5</K" & _
        "ey><Position>49</Position><Visible>False</Visible></Column49><Column50 ID=""Store" & _
        "No""><Caption>StoreNo</Caption><DataMember>StoreNo</DataMember><Key>StoreNo</Key>" & _
        "<Position>50</Position><Visible>False</Visible></Column50><Column51 ID=""UsePuchC" & _
        "lock""><Caption>UsePuchClock</Caption><ColumnType>CheckBox</ColumnType><DataMembe" & _
        "r>UsePuchClock</DataMember><EditType>CheckBox</EditType><Key>UsePuchClock</Key><" & _
        "Position>51</Position><Visible>False</Visible></Column51></Columns><GroupConditi" & _
        "on ID="""" /><Key>employee</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 95)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(629, 260)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmSearchEmployeeCode1.employee
        '
        'DsFrmSearchEmployeeCode1
        '
        Me.DsFrmSearchEmployeeCode1.DataSetName = "DSFrmSearchEmployeeCode"
        Me.DsFrmSearchEmployeeCode1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'BtnViewRowdetail
        '
        Me.BtnViewRowdetail.Image = CType(resources.GetObject("BtnViewRowdetail.Image"), System.Drawing.Image)
        Me.BtnViewRowdetail.Location = New System.Drawing.Point(29, 4)
        Me.BtnViewRowdetail.Name = "BtnViewRowdetail"
        Me.BtnViewRowdetail.Size = New System.Drawing.Size(24, 24)
        Me.BtnViewRowdetail.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 33)
        Me.Panel2.TabIndex = 21
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(447, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(543, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employee_code, f_name, m_name, l_name, address, zipcode, technecian, Sales" & _
        "Person, social_security_no, cod_position, cod_deparment, phone_1, extension_1, p" & _
        "hone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, pho" & _
        "ne_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type_" & _
        "4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, notes," & _
        " pic, birthday_date, hired_date, last_reiew_date, terminate_date, temporary_inac" & _
        "tive, last_basis, last_period, last_status, last_salary, last_hourly, last_overt" & _
        "ime, Last_raise_date, Allowance_Federal, Allowance_state, Allowance_depndnts, Te" & _
        "rminated, StoreNo, UsePunchClock FROM employee"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand1
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("SalesPerson", "SalesPerson"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        '
        'ChkUsePunchClock
        '
        Me.ChkUsePunchClock.BackColor = System.Drawing.SystemColors.Control
        Me.ChkUsePunchClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkUsePunchClock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkUsePunchClock.Location = New System.Drawing.Point(366, 7)
        Me.ChkUsePunchClock.Name = "ChkUsePunchClock"
        Me.ChkUsePunchClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUsePunchClock.Size = New System.Drawing.Size(123, 18)
        Me.ChkUsePunchClock.TabIndex = 418
        Me.ChkUsePunchClock.Text = "Use Punch Clock"
        '
        'FrmSearchEmployeeCode
        '
        Me.AcceptButton = Me.BtnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.ChkUsePunchClock)
        Me.Controls.Add(Me.BtnViewRowdetail)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchEmployeeCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Employee"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchEmployeeCode1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchEmployeeCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        TxtLastName.Text = ""
        PhoneNo1.Text = ""
        TxtFirstName.Text = ""
        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()
        DsFrmSearchEmployeeCode1.employee.Clear()
        DAEmployee.Fill(DsFrmSearchEmployeeCode1, "Employee")
        Select Case KindEmployee
            Case "0"
                ChkUsePunchClock.Checked = True
                DataView1.RowFilter = " UsePunchClock=1 "
                Dim i As Integer
                For i = 5 To 51
                    GrdDetail.RootTable.Columns(i).Visible = False
                Next
            Case "2"
                DataView1.RowFilter = " SalesPerson=1 "
            Case "3"
                DataView1.RowFilter = " technecian=1"
            Case Else
                DataView1.RowFilter = " "
        End Select
    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewRowdetail.Click
        Try
            Dim MyFrmEmployee As New UCEmployee.FrmEmployee
            MyFrmEmployee.EmployeeCodTempVar = GrdDetail.GetRow.Cells(0).Value
            MyFrmEmployee.StartPosition = FormStartPosition.CenterParent
            MyFrmEmployee.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent EmployeeFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & " " & GrdDetail.GetRow.Cells(2).Value & " " & GrdDetail.GetRow.Cells(3).Value)
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub ActFilter()
        Dim WhereClauseVar As String = ""
        Dim OPerand As String = " "
        If TxtFirstName.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " f_name like '%" & TxtFirstName.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If TxtLastName.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " l_name like '%" & TxtLastName.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If Mid(PhoneNo1.Text, 1, 1).Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & "( phone_1 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_2 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_3 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_4 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_5 like '%" & PhoneNo1.Text.Trim & "%' ) "
            OPerand = " AND "
        End If
        If ChkUsePunchClock.Checked Then
            WhereClauseVar = WhereClauseVar & OPerand & " UsePunchClock=1 "
            OPerand = " AND "
        End If
        DataView1.RowFilter = WhereClauseVar
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call ActFilter()
    End Sub
    Private Sub ChkUsePunchClock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkUsePunchClock.CheckedChanged
        Call ActFilter()
    End Sub
End Class
