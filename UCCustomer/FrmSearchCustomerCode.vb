Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchCustomerCode
    Inherits FrmBase
    Event CustomerFind(ByVal ThisCustomerCode As String, ByVal ThisCustomerDesc As String)
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnViewRowdetail As System.Windows.Forms.Button
    Friend WithEvents BtnAddNewCustomer As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_trtab_main As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmFindServiceRecords1 As UCCustomer.DSFrmFindServiceRecords
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DataView1 As System.Data.DataView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchCustomerCode))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.TxtCustomerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtLastName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmFindServiceRecords1 = New UCCustomer.DSFrmFindServiceRecords
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.BtnViewRowdetail = New System.Windows.Forms.Button
        Me.BtnAddNewCustomer = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_trtab_main = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmFindServiceRecords1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PhoneNo1)
        Me.Panel1.Controls.Add(Me.TxtCustomerNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCompany)
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
        'TxtCustomerNo
        '
        Me.TxtCustomerNo.Location = New System.Drawing.Point(438, 36)
        Me.TxtCustomerNo.MaxLength = 20
        Me.TxtCustomerNo.Name = "TxtCustomerNo"
        Me.TxtCustomerNo.Size = New System.Drawing.Size(94, 20)
        Me.TxtCustomerNo.TabIndex = 4
        Me.TxtCustomerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.YellowGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(364, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Customer No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(364, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 22)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Phone"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCompany
        '
        Me.TxtCompany.Location = New System.Drawing.Point(69, 36)
        Me.TxtCompany.MaxLength = 20
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(245, 20)
        Me.TxtCompany.TabIndex = 3
        Me.TxtCompany.Text = ""
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
        Me.Label1.Text = "Company"
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
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>cust_trtab_main</Caption><Columns Collectio" & _
        "n=""true""><Column0 ID=""cod_customer""><Caption>Customer</Caption><TypeNameEmptyStr" & _
        "ingValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember" & _
        ">cod_customer</DataMember><Key>cod_customer</Key><Position>0</Position><Width>74" & _
        "</Width></Column0><Column1 ID=""l_name""><Caption>Last Name</Caption><DataMember>l" & _
        "_name</DataMember><Key>l_name</Key><Position>1</Position><Width>90</Width></Colu" & _
        "mn1><Column2 ID=""m_name""><Caption>m_name</Caption><DataMember>m_name</DataMember" & _
        "><Key>m_name</Key><Position>2</Position><Visible>False</Visible></Column2><Colum" & _
        "n3 ID=""f_name""><Caption>First Name</Caption><DataMember>f_name</DataMember><Key>" & _
        "f_name</Key><Position>3</Position><Width>86</Width></Column3><Column4 ID=""cod_co" & _
        "mpany""><Caption>Company</Caption><DataMember>complete_name</DataMember><Key>cod_" & _
        "company</Key><Position>4</Position><Width>149</Width></Column4><Column5 ID=""phon" & _
        "e_1""><Caption>Phone</Caption><DataMember>phone_1</DataMember><Key>phone_1</Key><" & _
        "Position>5</Position><Width>87</Width></Column5><Column6 ID=""Customer_Birth_Date" & _
        """><Caption>Birth Date</Caption><DataMember>Customer_Birth_Date</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Customer_Birt" & _
        "h_Date</Key><Position>6</Position><Width>70</Width></Column6><Column7 ID=""addres" & _
        "s""><Caption>Address</Caption><DataMember>address</DataMember><Key>address</Key><" & _
        "Position>7</Position><Width>176</Width></Column7><Column8 ID=""zip""><Caption>City" & _
        "</Caption><DataMember>city</DataMember><Key>zip</Key><Position>8</Position><Widt" & _
        "h>74</Width></Column8><Column9 ID=""Customer_No""><Caption>Customer No</Caption><D" & _
        "ataMember>vip_code</DataMember><Key>Customer_No</Key><Position>9</Position><Widt" & _
        "h>76</Width></Column9><Column10 ID=""AR_charge""><Caption>Charge</Caption><ColumnT" & _
        "ype>CheckBox</ColumnType><DataMember>AR_charge</DataMember><EditType>CheckBox</E" & _
        "ditType><Key>AR_charge</Key><Position>10</Position><Width>46</Width></Column10><" & _
        "Column11 ID=""desc_type""><Caption>Type</Caption><DataMember>desc_type</DataMember" & _
        "><Key>desc_type</Key><Position>11</Position><Width>55</Width></Column11><Column1" & _
        "2 ID=""MaxDate_Refer""><Caption>Last Visit</Caption><DataMember>MaxDate_Refer</Dat" & _
        "aMember><Key>MaxDate_Refer</Key><Position>12</Position><Width>64</Width></Column" & _
        "12></Columns><GroupCondition ID="""" /><Key>cust_trtab_main</Key></RootTable></Gri" & _
        "dEXLayoutData>"
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
        Me.DataView1.Table = Me.DsFrmFindServiceRecords1.cust_trtab_main
        '
        'DsFrmFindServiceRecords1
        '
        Me.DsFrmFindServiceRecords1.DataSetName = "DSFrmFindServiceRecords"
        Me.DsFrmFindServiceRecords1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'BtnViewRowdetail
        '
        Me.BtnViewRowdetail.Image = CType(resources.GetObject("BtnViewRowdetail.Image"), System.Drawing.Image)
        Me.BtnViewRowdetail.Location = New System.Drawing.Point(155, 4)
        Me.BtnViewRowdetail.Name = "BtnViewRowdetail"
        Me.BtnViewRowdetail.Size = New System.Drawing.Size(24, 24)
        Me.BtnViewRowdetail.TabIndex = 6
        '
        'BtnAddNewCustomer
        '
        Me.BtnAddNewCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnAddNewCustomer.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNewCustomer.Location = New System.Drawing.Point(6, 4)
        Me.BtnAddNewCustomer.Name = "BtnAddNewCustomer"
        Me.BtnAddNewCustomer.Size = New System.Drawing.Size(134, 23)
        Me.BtnAddNewCustomer.TabIndex = 3
        Me.BtnAddNewCustomer.Text = "Add New Customer"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.vip_code, cust_trtab_main.co" & _
        "d_company, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_nam" & _
        "e, cust_trtab_main.address, cust_trtab_main.phone_1, cust_trtab_main.extension_1" & _
        ", cust_trtab_main.phone_type_1, cust_trtab_main.phone_main_1, cust_trtab_main.ph" & _
        "one_2, cust_trtab_main.extension_2, cust_trtab_main.phone_type_2, cust_trtab_mai" & _
        "n.phone_main_2, cust_trtab_main.phone_3, cust_trtab_main.extension_3, cust_trtab" & _
        "_main.phone_type_3, cust_trtab_main.phone_main_3, cust_trtab_main.phone_4, cust_" & _
        "trtab_main.extension_4, cust_trtab_main.phone_type_4, cust_trtab_main.phone_main" & _
        "_4, cust_trtab_main.phone_5, cust_trtab_main.extension_5, cust_trtab_main.phone_" & _
        "type_5, cust_trtab_main.phone_main_5, cust_trtab_main.driver_name1, cust_trtab_m" & _
        "ain.driver_name2, cust_trtab_main.driver_name3, cust_trtab_main.driver_name4, cu" & _
        "st_trtab_main.DriverLicense, cust_trtab_main.zip, cust_trtab_main.email, cust_tr" & _
        "tab_main.cod_sales_rep, cust_trtab_main.social_security_no, cust_trtab_main.cust" & _
        "_exempt_tax, cust_trtab_main.scrap_check, cust_trtab_main.scrap_value, cust_trta" & _
        "b_main.credit_card_no, cust_trtab_main.expiration_credit_date, cust_trtab_main.c" & _
        "redit_limited, cust_trtab_main.AR_charge, cust_trtab_main.AR_term, cust_trtab_ma" & _
        "in.cod_sales_tax, cust_trtab_main.cod_price, cust_trtab_main.discount, cust_trta" & _
        "b_main.cod_type, cust_trtab_main.cod_source, cust_trtab_main.cod_class, cust_trt" & _
        "ab_main.cod_territory, cust_trtab_main.desc_sales_report, cust_trtab_main.user_i" & _
        "d, cust_trtab_main.user_password, cust_trtab_main.AR_statement, cust_trtab_main." & _
        "AR_send_copy, cust_trtab_main.AR_finance_charge, cust_trtab_main.AR_require_PO, " & _
        "cust_trtab_main.AR_credit_hold, cust_trtab_main.AR_accept_check, cust_trtab_main" & _
        ".cust_notes, cust_trtab_main.Taxable, cust_trtab_main.inactive, cust_trtab_main." & _
        "customer_no, bas_zipcode.city, cust_tab_type.desc_type, View_service_center_head" & _
        "_MaxDate_Refer.MAXdate_refer, cust_company.complete_name, cust_trtab_main.Custom" & _
        "er_Birth_Date FROM cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trtab_ma" & _
        "in.cod_company = cust_company.cod_company LEFT OUTER JOIN bas_zipcode ON cust_tr" & _
        "tab_main.zip = bas_zipcode.zipcode LEFT OUTER JOIN View_service_center_head_MaxD" & _
        "ate_Refer ON cust_trtab_main.cod_customer = View_service_center_head_MaxDate_Ref" & _
        "er.cod_customer LEFT OUTER JOIN cust_tab_type ON cust_trtab_main.cod_type = cust" & _
        "_tab_type.cod_type"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAcust_trtab_main
        '
        Me.DAcust_trtab_main.SelectCommand = Me.SqlSelectCommand1
        Me.DAcust_trtab_main.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
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
        'FrmSearchCustomerCode
        '
        Me.AcceptButton = Me.BtnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.BtnViewRowdetail)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAddNewCustomer)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchCustomerCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Customer"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmFindServiceRecords1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        TxtLastName.Text = ""
        PhoneNo1.Text = ""
        TxtCompany.Text = ""
        TxtCustomerNo.Text = ""
        Call FillDataSet()
        Call AddConditionalFormatting()
    End Sub
    Private Sub ActFilter()
        Dim WhereClauseVar As String = ""
        Dim OPerand As String = " "
        If TxtLastName.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " l_name like '%" & TxtLastName.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If PhoneNo1.Text.Trim.Length > 2 Then
            WhereClauseVar = WhereClauseVar & OPerand & "( phone_1 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_2 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_3 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_4 like '%" & PhoneNo1.Text.Trim & "%' OR  phone_5 like '%" & PhoneNo1.Text.Trim & "%' ) "
            OPerand = " AND "
        End If
        If TxtCompany.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " complete_name like '%" & TxtCompany.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If TxtCustomerNo.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " cod_customer like '%" & TxtCustomerNo.Text.Trim & "%' OR vip_code like '%" & TxtCustomerNo.Text.Trim & "%' "
            OPerand = " AND "
        End If
        DataView1.RowFilter = WhereClauseVar
    End Sub
    Private Sub FillDataSet()
        DsFrmFindServiceRecords1.cust_trtab_main.Clear()
        DAcust_trtab_main.Fill(DsFrmFindServiceRecords1, "cust_trtab_main")
        DataView1.RowFilter = ""
    End Sub
    Private Sub BtnAddNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNewCustomer.Click
        Dim MyFrmCustomer_Quick_Add As New UCCustomer.FrmCustomer_Quick_Add
        MyFrmCustomer_Quick_Add.StartPosition = FormStartPosition.CenterParent
        MyFrmCustomer_Quick_Add.Cod_customerVar = MyFrmCustomer_Quick_Add.MakeNewcod_customer()
        MyFrmCustomer_Quick_Add.IsCancelForExitFlag = True
        MyFrmCustomer_Quick_Add.ShowDialog()
        Call FillDataSet()
        'If MyFrmCustomer_Quick_Add.Txtcod_customer.Text.Trim.Length > 0 Then
        If MyFrmCustomer_Quick_Add.Cod_customerVar.Trim.Length > 0 Then
            RaiseEvent CustomerFind(MyFrmCustomer_Quick_Add.Txtcod_customer.Text & "", MyFrmCustomer_Quick_Add.TXTL_name.Text & " " & MyFrmCustomer_Quick_Add.TXTM_name.Text & " " & MyFrmCustomer_Quick_Add.Txtf_name.Text)
            Me.Close()
        Else
            Call FillDataSet()
        End If

    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call ActFilter()
    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewRowdetail.Click
        Try
            Dim MyFrmCustomer As New UCCustomer.FrmCustomer
            MyFrmCustomer.CustomerCodTempVar = GrdDetail.GetRow.Cells(0).Value
            MyFrmCustomer.StartPosition = FormStartPosition.CenterParent
            MyFrmCustomer.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent CustomerFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(3).Value & " " & GrdDetail.GetRow.Cells(2).Value & " " & GrdDetail.GetRow.Cells(1).Value)
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
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("AR_charge"), ConditionOperator.Equal, True)
        fc.FormatStyle.BackColor = Color.Yellow
        GrdDetail.RootTable.FormatConditions.Add(fc)
    End Sub
End Class
