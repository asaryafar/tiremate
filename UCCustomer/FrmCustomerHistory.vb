Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmCustomerHistory
    Inherits FrmBase
    Public Cod_customerParameter As String
    Dim FilterTypeVar As String = ""
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnViewRowdetail As System.Windows.Forms.Button
    Friend WithEvents BtnAllTransactions As System.Windows.Forms.Button
    Friend WithEvents BtnInvoices As System.Windows.Forms.Button
    Friend WithEvents BtnRecOnAccounts As System.Windows.Forms.Button
    Public WithEvents LblCompany As System.Windows.Forms.TextBox
    Public WithEvents LblName As System.Windows.Forms.TextBox
    Friend WithEvents DsFrmCustomerHistory1 As UCCustomer.DSFrmCustomerHistory
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAservice_center_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents DaUsers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCustomerHistory))
        Me.BtnAllTransactions = New System.Windows.Forms.Button
        Me.BtnInvoices = New System.Windows.Forms.Button
        Me.BtnRecOnAccounts = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblCompany = New System.Windows.Forms.TextBox
        Me.LblName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmCustomerHistory1 = New UCCustomer.DSFrmCustomerHistory
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.BtnViewRowdetail = New System.Windows.Forms.Button
        Me.DAservice_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.DaUsers = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmCustomerHistory1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAllTransactions
        '
        Me.BtnAllTransactions.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAllTransactions.Location = New System.Drawing.Point(6, 48)
        Me.BtnAllTransactions.Name = "BtnAllTransactions"
        Me.BtnAllTransactions.Size = New System.Drawing.Size(112, 23)
        Me.BtnAllTransactions.TabIndex = 3
        Me.BtnAllTransactions.Text = "All Transactions"
        '
        'BtnInvoices
        '
        Me.BtnInvoices.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInvoices.Location = New System.Drawing.Point(127, 48)
        Me.BtnInvoices.Name = "BtnInvoices"
        Me.BtnInvoices.Size = New System.Drawing.Size(112, 23)
        Me.BtnInvoices.TabIndex = 4
        Me.BtnInvoices.Text = "Invoices"
        '
        'BtnRecOnAccounts
        '
        Me.BtnRecOnAccounts.BackColor = System.Drawing.SystemColors.Control
        Me.BtnRecOnAccounts.Location = New System.Drawing.Point(248, 48)
        Me.BtnRecOnAccounts.Name = "BtnRecOnAccounts"
        Me.BtnRecOnAccounts.Size = New System.Drawing.Size(112, 23)
        Me.BtnRecOnAccounts.TabIndex = 5
        Me.BtnRecOnAccounts.Text = "Rec. On Accounts"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblCompany)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 31)
        Me.Panel1.TabIndex = 1
        '
        'LblCompany
        '
        Me.LblCompany.BackColor = System.Drawing.Color.Gold
        Me.LblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompany.Location = New System.Drawing.Point(355, 4)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.ReadOnly = True
        Me.LblCompany.Size = New System.Drawing.Size(252, 20)
        Me.LblCompany.TabIndex = 425
        Me.LblCompany.Text = ""
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.Gold
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblName.Location = New System.Drawing.Point(48, 4)
        Me.LblName.Name = "LblName"
        Me.LblName.ReadOnly = True
        Me.LblName.Size = New System.Drawing.Size(240, 20)
        Me.LblName.TabIndex = 424
        Me.LblName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(290, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Company"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = Nothing
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""Column1""><ButtonStyle>ButtonCell</ButtonStyle><ColumnT" & _
        "ype>Image</ColumnType><EditType>NoEdit</EditType><Key>Column1</Key><Position>0</" & _
        "Position><Width>19</Width></Column0><Column1 ID=""license_no_vehicle""><Caption>Li" & _
        "cense No</Caption><DataMember>license_no_vehicle</DataMember><Key>license_no_veh" & _
        "icle</Key><Position>1</Position><Width>79</Width></Column1><Column2 ID=""id_servi" & _
        "ce_center""><Caption>Ref. No</Caption><TypeNameEmptyStringValue>System.String</Ty" & _
        "peNameEmptyStringValue><EmptyStringValue /><DataMember>id_service_center</DataMe" & _
        "mber><Key>id_service_center</Key><Position>2</Position><Width>66</Width></Column" & _
        "2><Column3 ID=""date_refer""><Caption>Date</Caption><DataMember>date_refer</DataMe" & _
        "mber><Key>date_refer</Key><Position>3</Position><Width>67</Width></Column3><Colu" & _
        "mn4 ID=""Total""><Caption>Amount</Caption><DataMember>Total</DataMember><FormatStr" & _
        "ing>C2</FormatString><Key>Total</Key><Position>4</Position><TextAlignment>Far</T" & _
        "extAlignment><Width>59</Width></Column4><Column5 ID=""desc_make""><Caption>Make</C" & _
        "aption><DataMember>desc_make</DataMember><Key>desc_make</Key><Position>5</Positi" & _
        "on><Width>82</Width></Column5><Column6 ID=""desc_model""><Caption>Model</Caption><" & _
        "DataMember>desc_model</DataMember><Key>desc_model</Key><Position>6</Position><Wi" & _
        "dth>85</Width></Column6><Column7 ID=""current_mileage""><Caption>Mileage</Caption>" & _
        "<DataMember>current_mileage</DataMember><Key>current_mileage</Key><Position>7</P" & _
        "osition><Width>50</Width></Column7><Column8 ID=""add_user""><Caption>By</Caption><" & _
        "DataMember>add_user</DataMember><DefaultGroupInterval>Text</DefaultGroupInterval" & _
        "><EditType>MultiColumnCombo</EditType><Key>add_user</Key><Position>8</Position><" & _
        "CompareTarget>Text</CompareTarget><Width>91</Width><DropDownIndex>0</DropDownInd" & _
        "ex></Column8><Column9 ID=""type_of_form""><Caption>type_of_form</Caption><DataMemb" & _
        "er>type_of_form</DataMember><Key>type_of_form</Key><Position>9</Position><Visibl" & _
        "e>False</Visible></Column9><Column10 ID=""OrderDate""><Caption>OrderDate</Caption>" & _
        "<DataMember>OrderDate</DataMember><Key>OrderDate</Key><Position>10</Position><Vi" & _
        "sible>False</Visible></Column10></Columns><GroupCondition ID="""" /><Key>service_c" & _
        "enter_head</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>10" & _
        "</ColIndex></SortKey0></SortKeys></RootTable><DropDowns Collection=""true""><DropD" & _
        "own0><RootTable><Columns Collection=""true""><Column0 ID=""UserId""><Caption>UserId<" & _
        "/Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringVa" & _
        "lue /><DataMember>UserId</DataMember><Key>UserId</Key><Position>0</Position></Co" & _
        "lumn0><Column1 ID=""UserLogin""><Caption>UserLogin</Caption><DataMember>UserLogin<" & _
        "/DataMember><Key>UserLogin</Key><Position>1</Position></Column1></Columns><Group" & _
        "Condition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans Serif, 8.25" & _
        "pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><ExpandableGroups>False</Ex" & _
        "pandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highli" & _
        "ght</HideSelection><Key>DropDown1</Key><DisplayMember>UserLogin</DisplayMember><" & _
        "ValueMember>UserId</ValueMember></DropDown0></DropDowns></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupByBoxFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 105)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(640, 330)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmCustomerHistory1.service_center_head
        '
        'DsFrmCustomerHistory1
        '
        Me.DsFrmCustomerHistory1.DataSetName = "DSFrmCustomerHistory"
        Me.DsFrmCustomerHistory1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_02;password=2191110"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.l_name, cust_trtab_main.f_name, ser_tr_vehicle.license_no_" & _
        "vehicle, bas_vehicle_model.desc_model, cust_company.complete_name, cust_trtab_ma" & _
        "in.phone_1, service_center_head.add_user, cust_trtab_main.vip_code, 'RA' AS type" & _
        "_of_form, GL_payment_deposit.payment_amount AS Total, Gl_receive_payment.date_re" & _
        "ceive_payment AS date_refer, GL_payment_deposit.refrence_no AS id_service_center" & _
        ", bas_vehicle_company.desc_make, ser_tr_vehicle_dtl.current_mileage, dbo.ChangeD" & _
        "ate(Gl_receive_payment.date_receive_payment) AS OrderDate FROM GL_payment_deposi" & _
        "t LEFT OUTER JOIN bas_vehicle_model RIGHT OUTER JOIN ser_tr_vehicle RIGHT OUTER " & _
        "JOIN service_center_head ON ser_tr_vehicle.id_vehicle = service_center_head.id_v" & _
        "ehicle LEFT OUTER JOIN bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.c" & _
        "od_vehicle ON bas_vehicle_model.cod_make = bas_vehicle.cod_make AND bas_vehicle_" & _
        "model.cod_model = bas_vehicle.cod_model LEFT OUTER JOIN cust_trtab_main ON servi" & _
        "ce_center_head.cod_customer = cust_trtab_main.cod_customer RIGHT OUTER JOIN cust" & _
        "_company ON cust_trtab_main.cod_company = cust_company.cod_company ON GL_payment" & _
        "_deposit.id_service_center = service_center_head.id_service_center LEFT OUTER JO" & _
        "IN bas_vehicle_company ON bas_vehicle_model.cod_make = bas_vehicle_company.cod_m" & _
        "ake LEFT OUTER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_re" & _
        "ceive_payment.refrence_no FULL OUTER JOIN ser_tr_vehicle_dtl ON service_center_h" & _
        "ead.id_service_center = ser_tr_vehicle_dtl.id_service_center WHERE (GL_payment_d" & _
        "eposit.refer_type = '2') AND (Gl_receive_payment.cod_customer = @Cod_customer)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        '
        'BtnViewRowdetail
        '
        Me.BtnViewRowdetail.Image = CType(resources.GetObject("BtnViewRowdetail.Image"), System.Drawing.Image)
        Me.BtnViewRowdetail.Location = New System.Drawing.Point(369, 48)
        Me.BtnViewRowdetail.Name = "BtnViewRowdetail"
        Me.BtnViewRowdetail.Size = New System.Drawing.Size(24, 24)
        Me.BtnViewRowdetail.TabIndex = 23
        '
        'DAservice_center_head
        '
        Me.DAservice_center_head.SelectCommand = Me.SqlCommand1
        Me.DAservice_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, cus" & _
        "t_trtab_main.l_name, cust_trtab_main.f_name, ser_tr_vehicle.license_no_vehicle, " & _
        "bas_vehicle_model.desc_model, cust_company.complete_name, cust_trtab_main.phone_" & _
        "1, service_center_head.add_user, cust_trtab_main.vip_code, service_center_head.T" & _
        "otal, service_center_head.type_of_form, bas_vehicle_company.desc_make, ser_tr_ve" & _
        "hicle_dtl.current_mileage, dbo.ChangeDate(service_center_head.date_refer) AS Ord" & _
        "erDate FROM service_center_head LEFT OUTER JOIN ser_tr_vehicle ON service_center" & _
        "_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN bas_vehicle ON ser_" & _
        "tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle LEFT OUTER JOIN bas_vehicle_mod" & _
        "el ON bas_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehicle.cod_mode" & _
        "l = bas_vehicle_model.cod_model LEFT OUTER JOIN bas_vehicle_company ON bas_vehic" & _
        "le_model.cod_make = bas_vehicle_company.cod_make LEFT OUTER JOIN cust_company LE" & _
        "FT OUTER JOIN cust_trtab_main ON cust_company.cod_company = cust_trtab_main.cod_" & _
        "company ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT " & _
        "OUTER JOIN ser_tr_vehicle_dtl ON service_center_head.id_service_center = ser_tr_" & _
        "vehicle_dtl.id_service_center WHERE (service_center_head.cod_customer = @cod_cus" & _
        "tomer) AND (service_center_head.type_of_form = 'IN' OR service_center_head.type_" & _
        "of_form = 'RT')"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cust_trtab_main.l_name, cust_trtab_main.f_name, ser_tr_vehicle.license_no_" & _
        "vehicle, bas_vehicle_model.desc_model, cust_company.complete_name, cust_trtab_ma" & _
        "in.phone_1, cust_trtab_main.vip_code, 'AA' AS type_of_form, GL_account_adjustmen" & _
        "t_dtl.amount_adjustment AS Total, GL_account_adjustment_head.date_adjustment AS " & _
        "date_refer, GL_account_adjustment_head.refrence_no AS id_service_center, dbo.Cha" & _
        "ngeDate(GL_account_adjustment_head.date_adjustment) AS OrderDate FROM bas_vehicl" & _
        "e RIGHT OUTER JOIN GL_account_adjustment_head INNER JOIN GL_account_adjustment_d" & _
        "tl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrenc" & _
        "e_no LEFT OUTER JOIN ser_tr_vehicle LEFT OUTER JOIN service_center_head ON ser_t" & _
        "r_vehicle.cod_customer = service_center_head.cod_customer AND ser_tr_vehicle.id_" & _
        "vehicle = service_center_head.id_vehicle ON GL_account_adjustment_dtl.id_service" & _
        "_center = service_center_head.id_service_center ON bas_vehicle.cod_vehicle = ser" & _
        "_tr_vehicle.cod_vehicle LEFT OUTER JOIN bas_vehicle_model ON bas_vehicle.cod_mak" & _
        "e = bas_vehicle_model.cod_make AND bas_vehicle.cod_model = bas_vehicle_model.cod" & _
        "_model FULL OUTER JOIN cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trta" & _
        "b_main.cod_company = cust_company.cod_company ON GL_account_adjustment_head.cod_" & _
        "customer = cust_trtab_main.cod_customer WHERE (GL_account_adjustment_head.cod_cu" & _
        "stomer = @Cod_customer)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAGL_account_adjustment_head
        '
        Me.DAGL_account_adjustment_head.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(640, 45)
        Me.Panel4.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(64, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 43)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "By double clicking the Selected row , you can see the detail."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMate.mdb;Persist Sec" & _
        "urity Info=True;Jet OLEDB:Database Password=5332"
        '
        'DaUsers
        '
        Me.DaUsers.SelectCommand = Me.OleDbSelectCommand2
        Me.DaUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DefaultStoreNo", "DefaultStoreNo"), New System.Data.Common.DataColumnMapping("DefaultYear", "DefaultYear"), New System.Data.Common.DataColumnMapping("UserActiveFalg", "UserActiveFalg"), New System.Data.Common.DataColumnMapping("UserFamily", "UserFamily"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserLogin", "UserLogin"), New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("UserPassword", "UserPassword")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Users.UserId, Users.UserLogin FROM (Users INNER JOIN UserGroup ON Users.Us" & _
        "erGroupId = UserGroup.UserGroupId) WHERE (Users.UserActiveFalg <> 0) AND (UserGr" & _
        "oup.GroupActiveFlag <> 0)"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
        '
        'FrmCustomerHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 435)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnViewRowdetail)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRecOnAccounts)
        Me.Controls.Add(Me.BtnInvoices)
        Me.Controls.Add(Me.BtnAllTransactions)
        Me.Name = "FrmCustomerHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer History"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmCustomerHistory1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        Cnn.ConnectionString = PConnectionString

        GrdDetail.DropDowns("DropDown1").SetDataBinding(DsFrmCustomerHistory1, "Users")

        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()
        DsFrmCustomerHistory1.Users.Clear()
        DaUsers.Fill(DsFrmCustomerHistory1, "Users")

        DsFrmCustomerHistory1.service_center_head.Clear()

        DAservice_center_head.SelectCommand.Parameters("@cod_customer").Value = Cod_customerParameter
        DAservice_center_head.Fill(DsFrmCustomerHistory1, "service_center_head")

        DAGL_payment_deposit.SelectCommand.Parameters("@cod_customer").Value = Cod_customerParameter
        DAGL_payment_deposit.Fill(DsFrmCustomerHistory1, "service_center_head")

        DAGL_account_adjustment_head.SelectCommand.Parameters("@cod_customer").Value = Cod_customerParameter
        DAGL_account_adjustment_head.Fill(DsFrmCustomerHistory1, "service_center_head")

    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewRowdetail.Click
        Call ShowDetail()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowDetail()
    End Sub
    Private Sub BtnAllTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAllTransactions.Click
        FilterTypeVar = ""
        MakeFiltering()
    End Sub
    Private Sub BtnInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoices.Click
        FilterTypeVar = "type_of_form='IN'"
        MakeFiltering()
    End Sub
    Private Sub BtnRecOnAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRecOnAccounts.Click
        FilterTypeVar = "type_of_form='RA'"
        MakeFiltering()
    End Sub
    Private Sub MakeFiltering()
        DataView1.RowFilter = FilterTypeVar
    End Sub
    Private Sub ShowDetail()
        Dim Currentrow As GridEXRow = GrdDetail.GetRow
        Try
            Select Case Currentrow.Cells("type_of_form").Value & ""
                Case "IN", "RT"
                    If GrdDetail.RowCount > 0 Then
                        Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                        MyFrmShowWorkOrder.TypeOfForm = Currentrow.Cells("type_of_form").Value ' IN or RT
                        MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
                        MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                        MyFrmShowWorkOrder.Show()
                    End If
                Case "RA"
                    Dim MyFrmReceivePayment As New FrmReceivePayment
                    MyFrmReceivePayment.Refrence_NoForShowReadOnly = Currentrow.Cells("id_service_center").Value & ""
                    MyFrmReceivePayment.StartPosition = FormStartPosition.CenterScreen
                    MyFrmReceivePayment.ShowDialog()
                Case "AA"
                    Dim MyFrmShowAccountAdjustment As New WorkOrderUtility.FrmShowAccountAdjustment
                    MyFrmShowAccountAdjustment.Refrence_NoVar = Currentrow.Cells("id_service_center").Value & ""
                    MyFrmShowAccountAdjustment.StartPosition = FormStartPosition.CenterScreen
                    MyFrmShowAccountAdjustment.ShowDialog()
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Call ShowDetail()
    End Sub
End Class
