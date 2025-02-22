Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchLicenseNo
    Inherits FrmBase
    Event VehicleFind(ByVal ThisVehicleID As Double, ByVal ThisCodVehicle As String, ByVal ThisVehicleMake As String, ByVal ThisVehicleModel As String, ByVal ThisVehicleVin As String, ByVal ThisVehicleYear As String)
    Friend FilterCustomerCod As String = ""
    Public CodCustomerForAddNew As String = ""
    Dim DAser_tr_vehicleOriginalSelectCommandVar As String
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnViewRowdetail As System.Windows.Forms.Button
    Friend WithEvents BtnAddNewCustomer As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DsFrmSearchLicenseNo1 As UCVehicle.DSFrmSearchLicenseNo
    Friend WithEvents NumYear As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents TXTLicenseNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtOwner As System.Windows.Forms.TextBox
    Friend WithEvents TxtMake As System.Windows.Forms.TextBox
    Friend WithEvents TxtModel As System.Windows.Forms.TextBox
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnShowAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents LblCustomer As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAser_tr_vehicle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchLicenseNo))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtModel = New System.Windows.Forms.TextBox
        Me.TxtMake = New System.Windows.Forms.TextBox
        Me.TxtOwner = New System.Windows.Forms.TextBox
        Me.TXTLicenseNo = New System.Windows.Forms.TextBox
        Me.NumYear = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmSearchLicenseNo1 = New UCVehicle.DSFrmSearchLicenseNo
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.BtnViewRowdetail = New System.Windows.Forms.Button
        Me.BtnAddNewCustomer = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.LblCustomer = New System.Windows.Forms.Label
        Me.BtnShowAll = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAser_tr_vehicle = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchLicenseNo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtModel)
        Me.Panel1.Controls.Add(Me.TxtMake)
        Me.Panel1.Controls.Add(Me.TxtOwner)
        Me.Panel1.Controls.Add(Me.TXTLicenseNo)
        Me.Panel1.Controls.Add(Me.NumYear)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 62)
        Me.Panel1.TabIndex = 1
        '
        'TxtModel
        '
        Me.TxtModel.BackColor = System.Drawing.SystemColors.Window
        Me.TxtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtModel.Location = New System.Drawing.Point(412, 35)
        Me.TxtModel.MaxLength = 50
        Me.TxtModel.Name = "TxtModel"
        Me.TxtModel.Size = New System.Drawing.Size(149, 20)
        Me.TxtModel.TabIndex = 352
        Me.TxtModel.Text = ""
        '
        'TxtMake
        '
        Me.TxtMake.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMake.Location = New System.Drawing.Point(237, 36)
        Me.TxtMake.MaxLength = 50
        Me.TxtMake.Name = "TxtMake"
        Me.TxtMake.Size = New System.Drawing.Size(119, 20)
        Me.TxtMake.TabIndex = 351
        Me.TxtMake.Text = ""
        '
        'TxtOwner
        '
        Me.TxtOwner.BackColor = System.Drawing.SystemColors.Window
        Me.TxtOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtOwner.Location = New System.Drawing.Point(237, 8)
        Me.TxtOwner.MaxLength = 50
        Me.TxtOwner.Name = "TxtOwner"
        Me.TxtOwner.Size = New System.Drawing.Size(204, 20)
        Me.TxtOwner.TabIndex = 350
        Me.TxtOwner.Text = ""
        '
        'TXTLicenseNo
        '
        Me.TXTLicenseNo.BackColor = System.Drawing.SystemColors.Window
        Me.TXTLicenseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTLicenseNo.Location = New System.Drawing.Point(69, 8)
        Me.TXTLicenseNo.MaxLength = 50
        Me.TXTLicenseNo.Name = "TXTLicenseNo"
        Me.TXTLicenseNo.Size = New System.Drawing.Size(110, 20)
        Me.TXTLicenseNo.TabIndex = 349
        Me.TXTLicenseNo.Text = ""
        '
        'NumYear
        '
        Me.NumYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumYear.DecimalDigits = 0
        Me.NumYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumYear.FormatString = "####"
        Me.NumYear.Location = New System.Drawing.Point(69, 36)
        Me.NumYear.MaxLength = 4
        Me.NumYear.Name = "NumYear"
        Me.NumYear.Size = New System.Drawing.Size(55, 20)
        Me.NumYear.TabIndex = 348
        Me.NumYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumYear.Value = CType(0, Short)
        Me.NumYear.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.YellowGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(186, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 22)
        Me.Label4.TabIndex = 347
        Me.Label4.Text = "Make"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.YellowGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(361, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Model"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(186, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 22)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Owner"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.Text = "Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label5.Text = "License No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>ser_tr_vehicle</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""id_vehicle""><Caption>id_vehicle</Caption><TypeNameEmptyStri" & _
        "ngValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>id_vehicl" & _
        "e</DataMember><EditType>NoEdit</EditType><Key>id_vehicle</Key><Position>0</Posit" & _
        "ion><Visible>False</Visible></Column0><Column1 ID=""CustomerName""><Caption>Custom" & _
        "er</Caption><DataMember>CustomerName</DataMember><Key>CustomerName</Key><Positio" & _
        "n>1</Position><Width>146</Width></Column1><Column2 ID=""license_no_vehicle""><Capt" & _
        "ion>License No</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptySt" & _
        "ringValue><EmptyStringValue /><DataMember>license_no_vehicle</DataMember><Key>li" & _
        "cense_no_vehicle</Key><Position>2</Position><Width>94</Width></Column2><Column3 " & _
        "ID=""make_year""><Caption>Year</Caption><DataMember>make_year</DataMember><Key>mak" & _
        "e_year</Key><Position>3</Position><Width>48</Width></Column3><Column4 ID=""desc_m" & _
        "ake""><Caption>Make</Caption><DataMember>desc_make</DataMember><Key>desc_make</Ke" & _
        "y><Position>4</Position></Column4><Column5 ID=""desc_model""><Caption>Model</Capti" & _
        "on><DataMember>desc_model</DataMember><Key>desc_model</Key><Position>5</Position" & _
        "><Width>140</Width></Column5><Column6 ID=""Current_Mileage""><Caption>Mileage</Cap" & _
        "tion><DataMember>Current_Mileage</DataMember><Key>Current_Mileage</Key><Position" & _
        ">6</Position><Width>53</Width></Column6><Column7 ID=""vin""><Caption>Vin</Caption>" & _
        "<DataMember>vin</DataMember><Key>vin</Key><Position>7</Position></Column7><Colum" & _
        "n8 ID=""desc_color""><Caption>Color</Caption><DataMember>desc_color</DataMember><K" & _
        "ey>desc_color</Key><Position>8</Position></Column8><Column9 ID=""cod_vehicle""><Ca" & _
        "ption>cod_vehicle</Caption><DataMember>cod_vehicle</DataMember><Key>cod_vehicle<" & _
        "/Key><Position>9</Position><Visible>False</Visible></Column9><Column10 ID=""cod_c" & _
        "ustomer""><Caption>cod_customer</Caption><DataMember>cod_customer</DataMember><Ed" & _
        "itType>NoEdit</EditType><Key>cod_customer</Key><Position>10</Position><Visible>F" & _
        "alse</Visible></Column10><Column11 ID=""complete_name""><Caption>complete_name</Ca" & _
        "ption><DataMember>complete_name</DataMember><Key>complete_name</Key><Position>11" & _
        "</Position><Visible>False</Visible></Column11><Column12 ID=""l_name""><Caption>l_n" & _
        "ame</Caption><DataMember>l_name</DataMember><Key>l_name</Key><Position>12</Posit" & _
        "ion><Visible>False</Visible></Column12><Column13 ID=""unit_no""><Caption>Unit No.<" & _
        "/Caption><DataMember>unit_no</DataMember><EditType>NoEdit</EditType><FilterEditT" & _
        "ype>TextBox</FilterEditType><Key>unit_no</Key><Position>13</Position></Column13>" & _
        "<Column14 ID=""vehicle_active""><Caption>vehicle_active</Caption><ColumnType>Check" & _
        "Box</ColumnType><DataMember>vehicle_active</DataMember><EditType>CheckBox</EditT" & _
        "ype><Key>vehicle_active</Key><Position>14</Position><Visible>False</Visible></Co" & _
        "lumn14></Columns><GroupCondition ID="""" /><Key>ser_tr_vehicle</Key></RootTable></" & _
        "GridEXLayoutData>"
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
        Me.DataView1.Table = Me.DsFrmSearchLicenseNo1.ser_tr_vehicle
        '
        'DsFrmSearchLicenseNo1
        '
        Me.DsFrmSearchLicenseNo1.DataSetName = "DSFrmSearchLicenseNo"
        Me.DsFrmSearchLicenseNo1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJIXP;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=True;initial catalog=Tiremate_01;password=sa"
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
        Me.BtnAddNewCustomer.Text = "Add New Vehicle"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label15)
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
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Pink
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(9, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 22)
        Me.Label15.TabIndex = 345
        Me.Label15.Text = "Sold"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'LblCustomer
        '
        Me.LblCustomer.BackColor = System.Drawing.SystemColors.Info
        Me.LblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomer.Location = New System.Drawing.Point(510, 4)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.Size = New System.Drawing.Size(117, 22)
        Me.LblCustomer.TabIndex = 22
        Me.LblCustomer.Text = "Customer"
        Me.LblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblCustomer.Visible = False
        '
        'BtnShowAll
        '
        Me.BtnShowAll.Location = New System.Drawing.Point(263, 4)
        Me.BtnShowAll.Name = "BtnShowAll"
        Me.BtnShowAll.Size = New System.Drawing.Size(246, 23)
        Me.BtnShowAll.TabIndex = 23
        Me.BtnShowAll.Text = "Show All"
        Me.BtnShowAll.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CASE WHEN cust_company.complete_name IS NULL OR rtrim(ltrim(cust_company.c" & _
        "omplete_name + '')) = '' THEN rtrim(ltrim(cust_trtab_main.f_name)) + ' ' + rtrim" & _
        "(ltrim(cust_trtab_main.m_name)) + ' ' + rtrim(ltrim(cust_trtab_main.l_name)) ELS" & _
        "E cust_company.complete_name END AS CustomerName, ser_tr_vehicle.id_vehicle, ser" & _
        "_tr_vehicle.license_no_vehicle, ser_tr_vehicle.vin, bas_vehicle_company.desc_mak" & _
        "e, bas_vehicle_model.desc_model, bas_vehicle.make_year, bas_color.desc_color, Vi" & _
        "ew_Ser_tr_vehicle_dtl_Current_Mileage.Current_Mileage, ser_tr_vehicle.cod_vehicl" & _
        "e, ser_tr_vehicle.cod_customer, cust_company.complete_name, cust_trtab_main.l_na" & _
        "me, ser_tr_vehicle.unit_no, ser_tr_vehicle.vehicle_active FROM ser_tr_vehicle LE" & _
        "FT OUTER JOIN View_Ser_tr_vehicle_dtl_Current_Mileage ON ser_tr_vehicle.id_vehic" & _
        "le = View_Ser_tr_vehicle_dtl_Current_Mileage.id_vehicle LEFT OUTER JOIN bas_vehi" & _
        "cle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle LEFT OUTER JOIN bas_" & _
        "vehicle_model ON bas_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehic" & _
        "le.cod_model = bas_vehicle_model.cod_model LEFT OUTER JOIN bas_vehicle_company O" & _
        "N bas_vehicle.cod_make = bas_vehicle_company.cod_make LEFT OUTER JOIN bas_color " & _
        "ON ser_tr_vehicle.cod_color = bas_color.cod_color LEFT OUTER JOIN cust_trtab_mai" & _
        "n ON ser_tr_vehicle.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
        "cust_company ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAser_tr_vehicle
        '
        Me.DAser_tr_vehicle.SelectCommand = Me.SqlSelectCommand1
        Me.DAser_tr_vehicle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ser_tr_vehicle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("license_no_vehicle", "license_no_vehicle"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_kind_engine", "cod_kind_engine"), New System.Data.Common.DataColumnMapping("cod_color", "cod_color"), New System.Data.Common.DataColumnMapping("unit_no", "unit_no"), New System.Data.Common.DataColumnMapping("engin_designatoin_code", "engin_designatoin_code"), New System.Data.Common.DataColumnMapping("engine_vin", "engine_vin"), New System.Data.Common.DataColumnMapping("aa_id", "aa_id"), New System.Data.Common.DataColumnMapping("cod_quarts", "cod_quarts"), New System.Data.Common.DataColumnMapping("cod_oil_type", "cod_oil_type"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("creat_date", "creat_date"), New System.Data.Common.DataColumnMapping("change_date", "change_date"), New System.Data.Common.DataColumnMapping("salvage_date", "salvage_date"), New System.Data.Common.DataColumnMapping("vehicle_active", "vehicle_active"), New System.Data.Common.DataColumnMapping("vehicle_out_service", "vehicle_out_service"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("vin", "vin")})})
        '
        'FrmSearchLicenseNo
        '
        Me.AcceptButton = Me.BtnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.BtnShowAll)
        Me.Controls.Add(Me.LblCustomer)
        Me.Controls.Add(Me.BtnViewRowdetail)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAddNewCustomer)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchLicenseNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Vehicle"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchLicenseNo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        Call AddConditionalFormatting()

        DAser_tr_vehicleOriginalSelectCommandVar = DAser_tr_vehicle.SelectCommand.CommandText
        If FilterCustomerCod.Trim.Length > 0 Then
            DAser_tr_vehicle.SelectCommand.CommandText = DAser_tr_vehicleOriginalSelectCommandVar & " Where ser_tr_vehicle.Cod_customer=" & Qt(FilterCustomerCod)
            BtnShowAll.Visible = True
            LblCustomer.Visible = True
            LblCustomer.Text = FilterCustomerCod
        End If
        Call FillDataSet()
    End Sub
    Private Sub ActFilter()
        Dim WhereClauseVar As String = ""
        Dim OPerand As String = " "
        If TxtOwner.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " (CustomerName like '%" & TxtOwner.Text.Trim & "%' OR complete_name like '%" & TxtOwner.Text.Trim & "%' ) "
            OPerand = " AND "
        End If
        If TXTLicenseNo.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " license_no_vehicle like '%" & TXTLicenseNo.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If TxtMake.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " Desc_Make like '%" & TxtMake.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If TxtModel.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " Desc_Model like '%" & TxtModel.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If NumYear.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " Make_Year like '%" & NumYear.Text & "%' "
            OPerand = " AND "
        End If
        DataView1.RowFilter = WhereClauseVar
    End Sub
    Private Sub FillDataSet()
        DsFrmSearchLicenseNo1.ser_tr_vehicle.Clear()
        Try
            DAser_tr_vehicle.Fill(DsFrmSearchLicenseNo1, "ser_tr_vehicle")
        Catch ex As Exception
            MsgBox("Error in loading Vehicle information")
        End Try
    End Sub
    Private Sub BtnAddNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNewCustomer.Click
        'Dim MyFrmVehicle As New FrmVehicle
        ''MyFrmVehicle.LicenceNoForQuickAdd = MyFrmVehicle.MakeNewCod_Vehicle()
        'MyFrmVehicle.QuickAddFlag = True
        'MyFrmVehicle.CustomerNoForQuickAdd = IIf(LblCustomer.Text = "Customer", "", LblCustomer.Text)
        'MyFrmVehicle.StartPosition = FormStartPosition.CenterParent
        'MyFrmVehicle.ShowDialog()
        'Call FillDataSet()
        'Try
        '    If DataView1.RowFilter.Trim.Length > 0 Then
        '        DataView1.RowFilter = DataView1.RowFilter & " AND id_vehicle=" & MyFrmVehicle.Id_VehicleForShow
        '    Else
        '        DataView1.RowFilter = "id_vehicle=" & MyFrmVehicle.Id_VehicleForShow
        '    End If
        '    GrdDetail.Row = 0
        '    GrdDetail.Col = 0
        '    GrdDetail.SelectCurrentCellText()
        '    Call GrdDetail_DoubleClick(sender, e)
        '    Me.Close()
        'Catch ex As Exception
        'End Try
        Dim MyFrmVehicle As New FrmVehicleQuickAdd
        MyFrmVehicle.CustomerCod1.Enabled = True
        MyFrmVehicle.CustomerCod = CodCustomerForAddNew
        MyFrmVehicle.ShowDialog()

        Call FillDataSet()
        Try
            If DataView1.RowFilter.Trim.Length > 0 Then
                DataView1.RowFilter = DataView1.RowFilter & " AND id_vehicle=" & MyFrmVehicle.Id_VehicleForShow
            Else
                DataView1.RowFilter = "id_vehicle=" & MyFrmVehicle.Id_VehicleForShow
            End If
            GrdDetail.Row = 0
            GrdDetail.Col = 0
            GrdDetail.SelectCurrentCellText()
            Call GrdDetail_DoubleClick(sender, e)
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call ActFilter()
    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewRowdetail.Click
        Try
            Dim MyFrmVehicle As New FrmVehicle
            MyFrmVehicle.Id_VehicleForShow = GrdDetail.GetRow.Cells(0).Value
            MyFrmVehicle.StartPosition = FormStartPosition.CenterParent
            MyFrmVehicle.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                If Trim(GrdDetail.GetRow.Cells(10).Value).ToUpper <> FilterCustomerCod.Trim.ToUpper And FilterCustomerCod.Trim.Length > 0 Then
                    MsgBox("This Vehicle is not belong to the selected customer")
                    Exit Sub
                End If
                RaiseEvent VehicleFind(GrdDetail.GetRow.Cells(0).Value, GrdDetail.GetRow.Cells(9).Value & " ", GrdDetail.GetRow.Cells(4).Value & " ", GrdDetail.GetRow.Cells(5).Value & "", GrdDetail.GetRow.Cells(7).Value & "", GrdDetail.GetRow.Cells(3).Value & "")
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
    Private Sub BtnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowAll.Click
        If BtnShowAll.Text = "Show All" Then
            DAser_tr_vehicle.SelectCommand.CommandText = DAser_tr_vehicleOriginalSelectCommandVar
            Call FillDataSet()
            BtnShowAll.Text = "Show This Customer's Vehicle"
        Else
            DAser_tr_vehicle.SelectCommand.CommandText = DAser_tr_vehicleOriginalSelectCommandVar & " Where ser_tr_vehicle.Cod_customer=" & Qt(FilterCustomerCod)
            Call FillDataSet()
            BtnShowAll.Text = "Show All"
        End If
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("vehicle_active"), ConditionOperator.Equal, False)
        fc.FormatStyle.BackColor = Color.Pink
        GrdDetail.RootTable.FormatConditions.Add(fc)
    End Sub
End Class
