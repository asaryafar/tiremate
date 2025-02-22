Imports CommonClass
Public Class FrmVehicleQuickAdd
    Inherits FrmBase
    Dim MyFrmEngineScreen As New FrmEngineScreen
    Friend LicenseNoTempVar As Decimal = 0
    Dim TxtCod_vehicleVar As String = ""
    Public Event AfterSave(ByVal CodLicence As String)
    Public CustomerCod As String = ""
    Public LicenceCod As String = ""
    Public Id_VehicleForShow As Decimal  '= LicenseNoTempVar
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
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents TxtCustomername As System.Windows.Forms.TextBox
    Friend WithEvents CmbState As System.Windows.Forms.ComboBox
    Friend WithEvents TXTLicenseNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtUnitNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnEngine As System.Windows.Forms.Button
    Friend WithEvents Cmbcod_color As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_make As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVin As System.Windows.Forms.TextBox
    Friend WithEvents NumYear As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Cmbcod_kind_engine As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmbcod_model As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnAddColor As System.Windows.Forms.Button
    Friend WithEvents BtnAddEngine As System.Windows.Forms.Button
    Friend WithEvents BtnAddModel As System.Windows.Forms.Button
    Friend WithEvents BtnAddMake As System.Windows.Forms.Button
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmVehicle1 As UCVehicle.DSFrmVehicle
    Friend WithEvents DAbas_zipcode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_vehicle_company As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_color As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_kind_engine As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_vehicle_model As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataViewForModel As System.Data.DataView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVehicleQuickAdd))
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCustomername = New System.Windows.Forms.TextBox
        Me.CmbState = New System.Windows.Forms.ComboBox
        Me.DsFrmVehicle1 = New UCVehicle.DSFrmVehicle
        Me.TXTLicenseNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtUnitNo = New System.Windows.Forms.TextBox
        Me.BtnEngine = New System.Windows.Forms.Button
        Me.Cmbcod_color = New System.Windows.Forms.ComboBox
        Me.Cmbcod_make = New System.Windows.Forms.ComboBox
        Me.TxtVin = New System.Windows.Forms.TextBox
        Me.NumYear = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Cmbcod_kind_engine = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cmbcod_model = New System.Windows.Forms.ComboBox
        Me.DataViewForModel = New System.Data.DataView
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnAddColor = New System.Windows.Forms.Button
        Me.BtnAddEngine = New System.Windows.Forms.Button
        Me.BtnAddModel = New System.Windows.Forms.Button
        Me.BtnAddMake = New System.Windows.Forms.Button
        Me.DAbas_zipcode = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_vehicle_company = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_color = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_kind_engine = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_vehicle_model = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.Panel9.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmVehicle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataViewForModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label50)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(318, 45)
        Me.Panel9.TabIndex = 3
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(50, 32)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(53, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(8, 32)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(9, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.Label11)
        Me.PnlSearch.Controls.Add(Me.CustomerCod1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Controls.Add(Me.TxtCustomername)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(318, 51)
        Me.PnlSearch.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(-8, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 21)
        Me.Label11.TabIndex = 331
        Me.Label11.Text = "Customer Cod"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Enabled = False
        Me.CustomerCod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CustomerCod1.Location = New System.Drawing.Point(90, 0)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(179, 21)
        Me.CustomerCod1.TabIndex = 330
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=SA;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_01"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(-1, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 329
        Me.Label4.Text = "Customer Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCustomername
        '
        Me.TxtCustomername.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCustomername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomername.Location = New System.Drawing.Point(90, 24)
        Me.TxtCustomername.Name = "TxtCustomername"
        Me.TxtCustomername.ReadOnly = True
        Me.TxtCustomername.Size = New System.Drawing.Size(221, 21)
        Me.TxtCustomername.TabIndex = 328
        Me.TxtCustomername.Text = ""
        '
        'CmbState
        '
        Me.CmbState.BackColor = System.Drawing.SystemColors.Window
        Me.CmbState.DataSource = Me.DsFrmVehicle1.bas_zipcode
        Me.CmbState.DisplayMember = "state"
        Me.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbState.ItemHeight = 13
        Me.CmbState.Location = New System.Drawing.Point(235, 118)
        Me.CmbState.Name = "CmbState"
        Me.CmbState.Size = New System.Drawing.Size(55, 21)
        Me.CmbState.TabIndex = 327
        Me.CmbState.ValueMember = "state"
        '
        'DsFrmVehicle1
        '
        Me.DsFrmVehicle1.DataSetName = "DSFrmVehicle"
        Me.DsFrmVehicle1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'TXTLicenseNo
        '
        Me.TXTLicenseNo.BackColor = System.Drawing.SystemColors.Window
        Me.TXTLicenseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTLicenseNo.Location = New System.Drawing.Point(88, 118)
        Me.TXTLicenseNo.MaxLength = 20
        Me.TXTLicenseNo.Name = "TXTLicenseNo"
        Me.TXTLicenseNo.Size = New System.Drawing.Size(110, 20)
        Me.TXTLicenseNo.TabIndex = 326
        Me.TXTLicenseNo.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 328
        Me.Label1.Text = "License No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(202, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.TabIndex = 329
        Me.Label6.Text = "State"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtUnitNo
        '
        Me.TxtUnitNo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUnitNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtUnitNo.Location = New System.Drawing.Point(88, 294)
        Me.TxtUnitNo.MaxLength = 10
        Me.TxtUnitNo.Name = "TxtUnitNo"
        Me.TxtUnitNo.Size = New System.Drawing.Size(120, 20)
        Me.TxtUnitNo.TabIndex = 451
        Me.TxtUnitNo.Text = ""
        '
        'BtnEngine
        '
        Me.BtnEngine.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEngine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnEngine.Image = CType(resources.GetObject("BtnEngine.Image"), System.Drawing.Image)
        Me.BtnEngine.Location = New System.Drawing.Point(236, 222)
        Me.BtnEngine.Name = "BtnEngine"
        Me.BtnEngine.Size = New System.Drawing.Size(23, 19)
        Me.BtnEngine.TabIndex = 457
        Me.BtnEngine.TabStop = False
        '
        'Cmbcod_color
        '
        Me.Cmbcod_color.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_color.DataSource = Me.DsFrmVehicle1.bas_color
        Me.Cmbcod_color.DisplayMember = "desc_color"
        Me.Cmbcod_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_color.ItemHeight = 13
        Me.Cmbcod_color.Location = New System.Drawing.Point(88, 246)
        Me.Cmbcod_color.Name = "Cmbcod_color"
        Me.Cmbcod_color.Size = New System.Drawing.Size(142, 21)
        Me.Cmbcod_color.TabIndex = 449
        Me.Cmbcod_color.ValueMember = "cod_color"
        '
        'Cmbcod_make
        '
        Me.Cmbcod_make.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_make.DataSource = Me.DsFrmVehicle1.bas_vehicle_company
        Me.Cmbcod_make.DisplayMember = "desc_make"
        Me.Cmbcod_make.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_make.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_make.ItemHeight = 13
        Me.Cmbcod_make.Location = New System.Drawing.Point(88, 172)
        Me.Cmbcod_make.Name = "Cmbcod_make"
        Me.Cmbcod_make.Size = New System.Drawing.Size(150, 21)
        Me.Cmbcod_make.TabIndex = 446
        Me.Cmbcod_make.ValueMember = "cod_make"
        '
        'TxtVin
        '
        Me.TxtVin.BackColor = System.Drawing.SystemColors.Window
        Me.TxtVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtVin.Location = New System.Drawing.Point(88, 270)
        Me.TxtVin.MaxLength = 17
        Me.TxtVin.Name = "TxtVin"
        Me.TxtVin.Size = New System.Drawing.Size(165, 20)
        Me.TxtVin.TabIndex = 450
        Me.TxtVin.Text = ""
        '
        'NumYear
        '
        Me.NumYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumYear.DecimalDigits = 0
        Me.NumYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumYear.FormatString = "####"
        Me.NumYear.Location = New System.Drawing.Point(88, 142)
        Me.NumYear.MaxLength = 4
        Me.NumYear.Name = "NumYear"
        Me.NumYear.Size = New System.Drawing.Size(55, 20)
        Me.NumYear.TabIndex = 445
        Me.NumYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumYear.Value = CType(0, Short)
        Me.NumYear.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Cmbcod_kind_engine
        '
        Me.Cmbcod_kind_engine.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_kind_engine.DataSource = Me.DsFrmVehicle1.inv_tab_kind_engine
        Me.Cmbcod_kind_engine.DisplayMember = "desc_kind_engine"
        Me.Cmbcod_kind_engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_kind_engine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_kind_engine.ItemHeight = 13
        Me.Cmbcod_kind_engine.Location = New System.Drawing.Point(88, 222)
        Me.Cmbcod_kind_engine.Name = "Cmbcod_kind_engine"
        Me.Cmbcod_kind_engine.Size = New System.Drawing.Size(150, 21)
        Me.Cmbcod_kind_engine.TabIndex = 448
        Me.Cmbcod_kind_engine.ValueMember = "cod_kind_engine"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(11, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 14)
        Me.Label8.TabIndex = 456
        Me.Label8.Text = "Color"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(11, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 14)
        Me.Label7.TabIndex = 455
        Me.Label7.Text = "Engine"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(11, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 454
        Me.Label5.Text = "Model"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(11, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 453
        Me.Label3.Text = "Make"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(11, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 452
        Me.Label2.Text = "Year"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbcod_model
        '
        Me.Cmbcod_model.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_model.DataSource = Me.DataViewForModel
        Me.Cmbcod_model.DisplayMember = "desc_model"
        Me.Cmbcod_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_model.ItemHeight = 13
        Me.Cmbcod_model.Location = New System.Drawing.Point(88, 198)
        Me.Cmbcod_model.Name = "Cmbcod_model"
        Me.Cmbcod_model.Size = New System.Drawing.Size(160, 21)
        Me.Cmbcod_model.TabIndex = 447
        Me.Cmbcod_model.ValueMember = "cod_model"
        '
        'DataViewForModel
        '
        Me.DataViewForModel.Table = Me.DsFrmVehicle1.bas_vehicle_model
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(11, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 14)
        Me.Label10.TabIndex = 459
        Me.Label10.Text = "Unit No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(11, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 14)
        Me.Label9.TabIndex = 458
        Me.Label9.Text = "VIN"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnAddColor
        '
        Me.BtnAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddColor.Image = CType(resources.GetObject("BtnAddColor.Image"), System.Drawing.Image)
        Me.BtnAddColor.Location = New System.Drawing.Point(16, 246)
        Me.BtnAddColor.Name = "BtnAddColor"
        Me.BtnAddColor.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddColor.TabIndex = 463
        '
        'BtnAddEngine
        '
        Me.BtnAddEngine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddEngine.Image = CType(resources.GetObject("BtnAddEngine.Image"), System.Drawing.Image)
        Me.BtnAddEngine.Location = New System.Drawing.Point(16, 222)
        Me.BtnAddEngine.Name = "BtnAddEngine"
        Me.BtnAddEngine.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddEngine.TabIndex = 462
        '
        'BtnAddModel
        '
        Me.BtnAddModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddModel.Image = CType(resources.GetObject("BtnAddModel.Image"), System.Drawing.Image)
        Me.BtnAddModel.Location = New System.Drawing.Point(16, 197)
        Me.BtnAddModel.Name = "BtnAddModel"
        Me.BtnAddModel.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddModel.TabIndex = 461
        '
        'BtnAddMake
        '
        Me.BtnAddMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddMake.Image = CType(resources.GetObject("BtnAddMake.Image"), System.Drawing.Image)
        Me.BtnAddMake.Location = New System.Drawing.Point(16, 174)
        Me.BtnAddMake.Name = "BtnAddMake"
        Me.BtnAddMake.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddMake.TabIndex = 460
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
        'DAbas_vehicle_company
        '
        Me.DAbas_vehicle_company.SelectCommand = Me.SqlCommand1
        Me.DAbas_vehicle_company.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_company", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("desc_make", "desc_make")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT desc_make, cod_make FROM bas_vehicle_company ORDER BY desc_make"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'DAbas_color
        '
        Me.DAbas_color.SelectCommand = Me.SqlCommand3
        Me.DAbas_color.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_color", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_color", "cod_color"), New System.Data.Common.DataColumnMapping("desc_color", "desc_color")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT cod_color, desc_color FROM bas_color ORDER BY desc_color"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'DAinv_tab_kind_engine
        '
        Me.DAinv_tab_kind_engine.SelectCommand = Me.SqlCommand5
        Me.DAinv_tab_kind_engine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_kind_engine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kind_engine", "cod_kind_engine"), New System.Data.Common.DataColumnMapping("desc_kind_engine", "desc_kind_engine"), New System.Data.Common.DataColumnMapping("size_liters", "size_liters"), New System.Data.Common.DataColumnMapping("size_cubic_cm", "size_cubic_cm"), New System.Data.Common.DataColumnMapping("cub_indisplacement", "cub_indisplacement"), New System.Data.Common.DataColumnMapping("fuel_type", "fuel_type"), New System.Data.Common.DataColumnMapping("fuel_delivery", "fuel_delivery"), New System.Data.Common.DataColumnMapping("aspiration", "aspiration")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT cod_kind_engine, desc_kind_engine FROM inv_tab_kind_engine ORDER BY desc_k" & _
        "ind_engine"
        Me.SqlCommand5.Connection = Me.Cnn
        '
        'DAbas_vehicle_model
        '
        Me.DAbas_vehicle_model.SelectCommand = Me.SqlCommand2
        Me.DAbas_vehicle_model.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_company", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("desc_make", "desc_make")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT cod_model, desc_model, cod_make FROM bas_vehicle_model ORDER BY desc_model" & _
        ""
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO ser_tr_vehicle (license_no_vehicle, cod_customer, cod_vehicle, cod_ki" & _
        "nd_engine, cod_color, unit_no, engin_designatoin_code, engine_vin, aa_id, creat_" & _
        "date, change_date, salvage_date, vehicle_active, vehicle_out_service, cod_quarts" & _
        ", cod_oil_type, state, notes, vin) VALUES (@license_no_vehicle, @cod_customer, @" & _
        "cod_vehicle, @cod_kind_engine, @cod_color, @unit_no, @engin_designatoin_code, @e" & _
        "ngine_vin, @aa_id, @creat_date, @change_date, @salvage_date, @vehicle_active, @v" & _
        "ehicle_out_service, @Cod_quarts, @cod_oil_type, @State, @Notes, @Vin); SELECT @@" & _
        "Identity FROM ser_tr_vehicle"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@license_no_vehicle", System.Data.SqlDbType.VarChar, 20, "license_no_vehicle"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vehicle", System.Data.SqlDbType.VarChar, 4, "cod_vehicle"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_kind_engine", System.Data.SqlDbType.VarChar, 2, "cod_kind_engine"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_color", System.Data.SqlDbType.VarChar, 3, "cod_color"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unit_no", System.Data.SqlDbType.VarChar, 10, "unit_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@engin_designatoin_code", System.Data.SqlDbType.VarChar, 10, "engin_designatoin_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@engine_vin", System.Data.SqlDbType.VarChar, 10, "engine_vin"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@aa_id", System.Data.SqlDbType.VarChar, 10, "aa_id"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@creat_date", System.Data.SqlDbType.VarChar, 10, "creat_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@change_date", System.Data.SqlDbType.VarChar, 10, "change_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salvage_date", System.Data.SqlDbType.VarChar, 10, "salvage_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vehicle_active", System.Data.SqlDbType.Bit, 1, "vehicle_active"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vehicle_out_service", System.Data.SqlDbType.Bit, 1, "vehicle_out_service"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_quarts", System.Data.SqlDbType.VarChar, 1, "cod_quarts"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_oil_type", System.Data.SqlDbType.VarChar, 2, "cod_oil_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@State", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vin", System.Data.SqlDbType.VarChar, 20, "vin"))
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmVehicleQuickAdd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(318, 324)
        Me.Controls.Add(Me.BtnAddColor)
        Me.Controls.Add(Me.BtnAddEngine)
        Me.Controls.Add(Me.BtnAddModel)
        Me.Controls.Add(Me.BtnAddMake)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtUnitNo)
        Me.Controls.Add(Me.TxtVin)
        Me.Controls.Add(Me.TXTLicenseNo)
        Me.Controls.Add(Me.BtnEngine)
        Me.Controls.Add(Me.Cmbcod_color)
        Me.Controls.Add(Me.Cmbcod_make)
        Me.Controls.Add(Me.NumYear)
        Me.Controls.Add(Me.Cmbcod_kind_engine)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cmbcod_model)
        Me.Controls.Add(Me.CmbState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmVehicleQuickAdd"
        Me.Text = "Veicle Quick add"
        Me.Panel9.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmVehicle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataViewForModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmVehicleQuickAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        Call FillDataset()
        CustomerCod1.CustomerCod = CustomerCod

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveServiceSetupTable(PubStoreNO)
        Try
            CmbState.SelectedValue = OleDbReaderForStore.Item("VEHICLE_STATE") & ""
        Catch ex As Exception
            CmbState.Text = ""
        End Try

        If CustomerCod1.CustomerCod = "" Then
            CustomerCod1.Focus()
        Else
            NumYear.Focus()
        End If
        TXTLicenseNo.Text = LicenceCod.Trim
    End Sub
    Sub FillDataset()
        DsFrmVehicle1.bas_zipcode.Clear()
        DAbas_zipcode.Fill(DsFrmVehicle1, "bas_zipcode")
        DsFrmVehicle1.bas_vehicle_company.Clear()
        DAbas_vehicle_company.Fill(DsFrmVehicle1, "bas_vehicle_company")
        DsFrmVehicle1.bas_vehicle_model.Clear()
        DAbas_vehicle_model.Fill(DsFrmVehicle1, "bas_vehicle_model")
        DsFrmVehicle1.inv_tab_kind_engine.Clear()
        DAinv_tab_kind_engine.Fill(DsFrmVehicle1, "inv_tab_kind_engine")
        DsFrmVehicle1.bas_color.Clear()
        DAbas_color.Fill(DsFrmVehicle1, "bas_color")
    End Sub

    Private Sub BtnAddMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMake.Click
        Dim ar(0) As Object
        ar(0) = "305090400" ' Vehicle Make
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_make.SelectedValue
            DsFrmVehicle1.bas_vehicle_company.Clear()
            DAbas_vehicle_company.Fill(DsFrmVehicle1, "bas_vehicle_company")
            If DsFrmVehicle1.bas_vehicle_company.Rows.Count < 1 Then
                MsgFar("Please Fill The Vehicle Company Table")
                'Call DisableAllComponet(Me)
            End If
            ''''''''''''''''''''''''''Call FillDAbas_vehicle_model()
            Cmbcod_make.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAddModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddModel.Click
        Dim ar(0) As Object
        ar(0) = "305090500" ' Vehicle Model
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_model.SelectedValue
            ''''''''''''''''''Call FillDAbas_vehicle_model()
            DsFrmVehicle1.bas_vehicle_model.Clear()
            DAbas_vehicle_model.Fill(DsFrmVehicle1, "bas_vehicle_model")

            Cmbcod_model.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAddEngine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEngine.Click
        Dim ar(0) As Object
        ar(0) = "305090700" ' Vehicle Engine
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_kind_engine.SelectedValue
            DsFrmVehicle1.inv_tab_kind_engine.Clear()
            DAinv_tab_kind_engine.Fill(DsFrmVehicle1, "inv_tab_kind_engine")
            If DsFrmVehicle1.inv_tab_kind_engine.Rows.Count < 1 Then
                MsgFar("Please Fill The Engine Kind Table")
                'Call DisableAllComponet(Me)
            End If
            Cmbcod_kind_engine.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAddColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddColor.Click
        Dim ar(0) As Object
        ar(0) = "305090600" ' Vehicle color
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_color.SelectedValue
            DsFrmVehicle1.bas_color.Clear()
            DAbas_color.Fill(DsFrmVehicle1, "bas_color")
            If DsFrmVehicle1.bas_color.Rows.Count < 1 Then
                MsgFar("Please Fill The Vehicle Color Table")
                'Call DisableAllComponet(Me)
            End If
            Cmbcod_color.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnEngine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEngine.Click
        If Cmbcod_kind_engine.Text.Trim.Length > 0 Then
            Call FitToScreen(BtnEngine, MyFrmEngineScreen)
            If Cmbcod_kind_engine.Enabled Then
                MyFrmEngineScreen.ThisFormStatus = MainModule.WorkStates.AddNew
            Else
                MyFrmEngineScreen.ThisFormStatus = MainModule.WorkStates._ReadOnly
            End If
            MyFrmEngineScreen.TxtName.Text = TXTLicenseNo.Text
            MyFrmEngineScreen.ShowDialog()
        Else
            MsgBox("Please Fill Engine Type")
        End If
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If TXTLicenseNo.Text.Trim.Length > 0 And NumYear.Text.Trim.Length = 4 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        If NumYear.Text.Trim.Length < 4 And NumYear.Text.Trim.Length > 0 Then
            MsgBox("Please Fill The Year Completely (4 Digit)")
            Exit Sub
        End If
        LicenseNoTempVar = PInsert()
        ChangeOK = IIf(LicenseNoTempVar = 0, False, True)
        If ChangeOK Then
            RaiseEvent AfterSave(TXTLicenseNo.Text)
            Id_VehicleForShow = LicenseNoTempVar
        Else
            Id_VehicleForShow = 0
        End If
        Me.Close()
    End Sub
    Friend Function PInsert() As Decimal
        PInsert = 0
        'TxtCreatedDate.Text = Now.Date
        'DteCurrentDate.Text = Now.Date

        Call GetTxtCod_vehicleVar()
        Call UpdateBeforVehicleFlag(TXTLicenseNo.Text)
        Try
            With CmdInsert
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@license_no_vehicle").Value = TXTLicenseNo.Text & ""
                .Parameters("@state").Value = IIf(IsNothing(CmbState.SelectedValue), System.DBNull.Value, CmbState.SelectedValue)
                .Parameters("@cod_customer").Value = CustomerCod1.CustomerCod & ""
                .Parameters("@cod_vehicle").Value = IIf((TxtCod_vehicleVar & "").Trim.Length > 0, TxtCod_vehicleVar, System.DBNull.Value)
                .Parameters("@cod_kind_engine").Value = ChkCombo(Cmbcod_kind_engine.SelectedValue)
                .Parameters("@cod_color").Value = ChkCombo(Cmbcod_color.SelectedValue)
                .Parameters("@engine_vin").Value = MyFrmEngineScreen.TxtEngineVin.Text & ""
                .Parameters("@unit_no").Value = TxtUnitNo.Text
                .Parameters("@cod_oil_type").Value = System.DBNull.Value
                .Parameters("@Cod_quarts").Value = System.DBNull.Value '         ChkCombo(Cmbquarts.SelectedValue)
                .Parameters("@Vin").Value = TxtVin.Text & ""
                .Parameters("@engin_designatoin_code").Value = MyFrmEngineScreen.TxtEngDesignationCode.Text & ""
                .Parameters("@aa_id").Value = MyFrmEngineScreen.TxtAAAID.Text & ""
                .Parameters("@creat_date").Value = Now.Date.ToString ' TxtCreatedDate.Text & ""
                .Parameters("@Change_Date").Value = "" ' TxtChangeDate.Text & ""
                .Parameters("@salvage_date").Value = "" 'TxtSalvagedDate.Text & ""
                .Parameters("@vehicle_out_service").Value = 1 '  IIf(ChkVehicleOutOfService.Checked, 1, 0)
                .Parameters("@Notes").Value = "" ' VehicleNoteVar & ""
                .Parameters("@vehicle_active").Value = 1
                PInsert = .ExecuteScalar
                'PInsert = TXTLicenseNo.Text
                .Connection.Close()
            End With
        Catch ex As Exception
            MsgBox("This license_no_vehicle Is Exist")
            PInsert = 0
        End Try
    End Function

    Private Sub GetTxtCod_vehicleVar()
        If Cmbcod_make.Text.Trim.Length = 0 Then
            TxtCod_vehicleVar = ""
        Else
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT cod_vehicle from bas_vehicle Where cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND cod_model=" & Qt(Cmbcod_model.SelectedValue) & " AND make_year=" & Qt(NumYear.Text)
            TxtCod_vehicleVar = CmdGeneral.ExecuteScalar()
            If IsNothing(TxtCod_vehicleVar) Then
                TxtCod_vehicleVar = MakeNewCod_Vehicle()
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Count(*) FROM bas_vehicle_model Where cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND cod_model=" & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.SelectedValue, 0))
                If CmdGeneral.ExecuteScalar() = 0 Then
                    CmdGeneral.CommandText = "INSERT INTO bas_vehicle_model (cod_make, cod_model, desc_model) values(" & Qt(Cmbcod_make.SelectedValue) & "," & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.SelectedValue, 0)) & "," & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.Text, "Model")) & ")"
                    CmdGeneral.ExecuteNonQuery()
                End If
                CmdGeneral.CommandText = "Insert Into bas_vehicle (cod_vehicle,cod_make,cod_model,make_year,options) values(" & Qt(TxtCod_vehicleVar) & "," & Qt(Cmbcod_make.SelectedValue) & "," & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.SelectedValue, 0)) & "," & Qt(NumYear.Text) & "," & Qt("0") & ")"
                CmdGeneral.ExecuteNonQuery()
            End If
            CmdGeneral.Connection.Close()
        End If
    End Sub

    Friend Function MakeNewCod_Vehicle() As String

        Dim i As Integer
        Dim ValMakeNewcod_Vehicle As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_Vehicle) as Max_cod_Vehicle from bas_vehicle"
            MakeNewCod_Vehicle = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod_Vehicle = GetVal(MakeNewCod_Vehicle, LenVehicleCod)
            If ValMakeNewcod_Vehicle = MakeNewCod_Vehicle Then
                If MakeNewCod_Vehicle < 9999 Then
                    MakeNewCod_Vehicle = ValMakeNewcod_Vehicle + 1
                Else
                    MakeNewCod_Vehicle = "A001"
                End If

            Else
                    If Val(ValMakeNewcod_Vehicle) > 0 Then
                        i = Len(ValMakeNewcod_Vehicle)
                    Else
                        i = 0
                    End If

                    Dim FirstPartVehicle As String = Mid(MakeNewCod_Vehicle, 1, Len(MakeNewCod_Vehicle) - i)

                    If ValMakeNewcod_Vehicle > 998 Then
                        FirstPartVehicle = Chr(Asc(FirstPartVehicle) + 1)
                        ValMakeNewcod_Vehicle = "000"

                    End If

                    If MakeNewCod_Vehicle.Length >= i Then
                        MakeNewCod_Vehicle = FirstPartVehicle + Getcod(Str((Int(Val(ValMakeNewcod_Vehicle)) + 1)).Trim, Len(ValMakeNewcod_Vehicle))
                    End If
                    If MakeNewCod_Vehicle.Trim.Length > LenVehicleCod Then
                        MakeNewCod_Vehicle = "A" + Getcod("1", LenVehicleCod - 1)
                    End If

                End If
        Catch ex As Exception
            MakeNewCod_Vehicle = Getcod("1", LenVehicleCod)
        End Try

    End Function
    Sub UpdateBeforVehicleFlag(ByVal TXTLicenseNo As String)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = "update  ser_tr_vehicle set vehicle_active=0 where license_no_vehicle=" & Qt(TXTLicenseNo)
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Cmbcod_make_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_make.SelectedIndexChanged
        Call FillDAbas_vehicle_model()
    End Sub

    Private Sub Cmbcod_kind_engine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_kind_engine.SelectedIndexChanged
        Call FillMyFrmEngineScreen()
    End Sub

    Private Sub FillMyFrmEngineScreen()
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
                CmdGeneralForReader.Connection.Open()
            End If
            CmdGeneralForReader.CommandText = "SELECT * FROM inv_tab_kind_engine where cod_kind_engine=" & Qt(Cmbcod_kind_engine.SelectedValue)
            SQLReader = CmdGeneralForReader.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                MyFrmEngineScreen.TxtAspiration.Text = Trim(SQLReader.Item("Aspiration") & "")
                MyFrmEngineScreen.TxtCubInDisplaceMent.Text = Trim(SQLReader.Item("cub_indisplacement") & "")
                MyFrmEngineScreen.TxtEngineType.Text = Cmbcod_kind_engine.Text
                MyFrmEngineScreen.TxtFuelDelivery.Text = Trim(SQLReader.Item("fuel_delivery") & "")
                MyFrmEngineScreen.TxtFuelType.Text = Trim(SQLReader.Item("fuel_type") & "")
                MyFrmEngineScreen.TxtSizeCubicCM.Text = Trim(SQLReader.Item("size_cubic_cm") & "")
                MyFrmEngineScreen.TxtSizeLiters.Text = Trim(SQLReader.Item("size_liters") & "")
            End If
        Catch ex As Exception
        Finally
            Try
                SQLReader.Close()
            Catch ex As Exception
            End Try
        End Try
    End Sub


    Private Sub FillDAbas_vehicle_model()
        Try
            '''''DsFrmVehicle1.bas_vehicle_model.Clear()
            '''''DAbas_vehicle_model.SelectCommand.Parameters("@cod_make").Value = Cmbcod_make.SelectedValue
            '''''DAbas_vehicle_model.Fill(DsFrmVehicle1, "bas_vehicle_model")
            If Cmbcod_make.Text.Trim.Length > 0 Then
                DataViewForModel.RowFilter = "cod_make=" & Qt(Cmbcod_make.SelectedValue)
            Else
                Cmbcod_model.SelectedValue = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TXTLicenseNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTLicenseNo.TextChanged, TxtVin.TextChanged, NumYear.TextChanged, Cmbcod_color.SelectedIndexChanged, Cmbcod_kind_engine.SelectedIndexChanged, Cmbcod_make.SelectedIndexChanged, Cmbcod_model.SelectedIndexChanged, CmbState.SelectedIndexChanged
        Call SaveButtonControl()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call PSave()
    End Sub
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        TxtCustomername.Text = CustomerCod1.CustomerDesc
    End Sub
    Private Sub CustomerCod1_NotFindCustomerCod() Handles CustomerCod1.NotFindCustomerCod
        TxtCustomername.Text = ""
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
