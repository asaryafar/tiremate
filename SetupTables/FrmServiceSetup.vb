Imports CommonClass
Public Class FrmServiceSetup
    Inherits FrmBase
    Friend Status As WorkStates = MainModule.WorkStates.Edit
    Dim StoreNoVar As String
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CmbStores As System.Windows.Forms.ComboBox
    Friend WithEvents LblShortName As System.Windows.Forms.Label
    Friend WithEvents LblStoreName As System.Windows.Forms.Label
    Friend WithEvents CnnMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CHKCUSTOMER_ACCEPT_CHECK As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKCUSTOMER_TAXABLE As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKCUSTOMER_CHARGE As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbCUSTOMER_PRICE_LEVEL As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCUSTOMER_TERRITORY As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCUSTOMER_CLASS As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCUSTOMER_SOURCE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCUSTOMER_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVEHICLE_QUARTS As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVEHICLE_OIL_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVEHICLE_VEHICLE_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVEHICLE_STATE As System.Windows.Forms.ComboBox
    Friend WithEvents CHKSERVICE_REMINDER As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKSERVICE_SCHEDULE As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKSERVICE_CHARGE_SHOP_SUPPLY As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKSERVICE_REQUIRE_TECHNISIAN As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKSERVICE_TAXABLE As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbSERVICE_CATEGORY As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSERVICE_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVENDOR_BUYER As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVENDOR_CLASS As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVENDOR_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVENDOR_AP_TERM As System.Windows.Forms.ComboBox
    Friend WithEvents NumOUTSIDE_PURCHASES_MARKUP As CalcUtils.UcCalcText
    Friend WithEvents CmbOUTSIDE_PURCHASES_LINE As System.Windows.Forms.ComboBox
    Friend WithEvents NumSEVICE_REMINDER_THANK_UP_DAY As CalcUtils.UcCalcText
    Friend WithEvents NumSEVICE_REMINDER_THANK_UP_DOLLAR As CalcUtils.UcCalcText
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_source As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_class As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_territory As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmServiceSetup1 As SetupTables.DSFrmServiceSetup
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_zipcode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_vehicle_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_oil_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_quarts As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_service_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_service_category As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_line As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_buyer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_vendor_class As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_vendor_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LblVendorName As System.Windows.Forms.Label
    Friend WithEvents NUMShop_Supply_on_Labor As CalcUtils.UcCalcText
    Friend WithEvents NUMShop_Supply_on_Parts As CalcUtils.UcCalcText
    Friend WithEvents CHKShop_Supply_on_Labor_Flag As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKShop_Supply_on_Parts_Flag As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CHKItemDescriptionEditFlag As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKServiceDescriptionEditFlag As Janus.Windows.EditControls.UICheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmServiceSetup))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneralForMDB = New System.Data.OleDb.OleDbCommand
        Me.CnnMDB = New System.Data.OleDb.OleDbConnection
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CHKCUSTOMER_ACCEPT_CHECK = New Janus.Windows.EditControls.UICheckBox
        Me.CHKCUSTOMER_TAXABLE = New Janus.Windows.EditControls.UICheckBox
        Me.CHKCUSTOMER_CHARGE = New Janus.Windows.EditControls.UICheckBox
        Me.CmbCUSTOMER_PRICE_LEVEL = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbCUSTOMER_TERRITORY = New System.Windows.Forms.ComboBox
        Me.DsFrmServiceSetup1 = New SetupTables.DSFrmServiceSetup
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbCUSTOMER_CLASS = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbCUSTOMER_SOURCE = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbCUSTOMER_TYPE = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.NUMShop_Supply_on_Parts = New CalcUtils.UcCalcText
        Me.CHKShop_Supply_on_Parts_Flag = New Janus.Windows.EditControls.UICheckBox
        Me.NUMShop_Supply_on_Labor = New CalcUtils.UcCalcText
        Me.CHKSERVICE_REMINDER = New Janus.Windows.EditControls.UICheckBox
        Me.CHKSERVICE_SCHEDULE = New Janus.Windows.EditControls.UICheckBox
        Me.CHKSERVICE_CHARGE_SHOP_SUPPLY = New Janus.Windows.EditControls.UICheckBox
        Me.CHKSERVICE_REQUIRE_TECHNISIAN = New Janus.Windows.EditControls.UICheckBox
        Me.CHKSERVICE_TAXABLE = New Janus.Windows.EditControls.UICheckBox
        Me.CmbSERVICE_CATEGORY = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbSERVICE_TYPE = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CHKShop_Supply_on_Labor_Flag = New Janus.Windows.EditControls.UICheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CmbVEHICLE_QUARTS = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbVEHICLE_OIL_TYPE = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbVEHICLE_VEHICLE_TYPE = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbVEHICLE_STATE = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.CmbVENDOR_BUYER = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.CmbVENDOR_CLASS = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CmbVENDOR_TYPE = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CmbVENDOR_AP_TERM = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.LblVendorName = New System.Windows.Forms.Label
        Me.NumOUTSIDE_PURCHASES_MARKUP = New CalcUtils.UcCalcText
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.CmbOUTSIDE_PURCHASES_LINE = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Label20 = New System.Windows.Forms.Label
        Me.NumSEVICE_REMINDER_THANK_UP_DAY = New CalcUtils.UcCalcText
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR = New CalcUtils.UcCalcText
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblShortName = New System.Windows.Forms.Label
        Me.LblStoreName = New System.Windows.Forms.Label
        Me.CmbStores = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_source = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_class = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_territory = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_zipcode = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_vehicle_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_oil_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_quarts = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_service_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_service_category = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_line = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand14 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_buyer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand15 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_vendor_class = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand16 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_vendor_type = New System.Data.SqlClient.SqlDataAdapter
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.CHKItemDescriptionEditFlag = New Janus.Windows.EditControls.UICheckBox
        Me.CHKServiceDescriptionEditFlag = New Janus.Windows.EditControls.UICheckBox
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DsFrmServiceSetup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 67)
        Me.Panel1.TabIndex = 365
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(86, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(512, 63)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Service Setup"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'CmdGeneralForMDB
        '
        Me.CmdGeneralForMDB.Connection = Me.CnnMDB
        '
        'CnnMDB
        '
        Me.CnnMDB.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\TireMate\TireMatesetu" & _
        "p.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Pr" & _
        "ovider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;" & _
        "Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet O" & _
        "LEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;J" & _
        "et OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Da" & _
        "tabase=False"
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.SystemColors.Info
        Me.BtnOk.Enabled = False
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.Location = New System.Drawing.Point(510, 336)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(73, 29)
        Me.BtnOk.TabIndex = 2
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.SystemColors.Info
        Me.BtnExit.Enabled = False
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(20, 336)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(73, 29)
        Me.BtnExit.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(4, 99)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(594, 231)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CHKCUSTOMER_ACCEPT_CHECK)
        Me.TabPage1.Controls.Add(Me.CHKCUSTOMER_TAXABLE)
        Me.TabPage1.Controls.Add(Me.CHKCUSTOMER_CHARGE)
        Me.TabPage1.Controls.Add(Me.CmbCUSTOMER_PRICE_LEVEL)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CmbCUSTOMER_TERRITORY)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CmbCUSTOMER_CLASS)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CmbCUSTOMER_SOURCE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CmbCUSTOMER_TYPE)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(586, 205)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customers"
        '
        'CHKCUSTOMER_ACCEPT_CHECK
        '
        Me.CHKCUSTOMER_ACCEPT_CHECK.Location = New System.Drawing.Point(-10, 179)
        Me.CHKCUSTOMER_ACCEPT_CHECK.Name = "CHKCUSTOMER_ACCEPT_CHECK"
        Me.CHKCUSTOMER_ACCEPT_CHECK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKCUSTOMER_ACCEPT_CHECK.Size = New System.Drawing.Size(106, 23)
        Me.CHKCUSTOMER_ACCEPT_CHECK.TabIndex = 7
        Me.CHKCUSTOMER_ACCEPT_CHECK.Text = "Accept Check"
        '
        'CHKCUSTOMER_TAXABLE
        '
        Me.CHKCUSTOMER_TAXABLE.Location = New System.Drawing.Point(-10, 153)
        Me.CHKCUSTOMER_TAXABLE.Name = "CHKCUSTOMER_TAXABLE"
        Me.CHKCUSTOMER_TAXABLE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKCUSTOMER_TAXABLE.Size = New System.Drawing.Size(106, 23)
        Me.CHKCUSTOMER_TAXABLE.TabIndex = 6
        Me.CHKCUSTOMER_TAXABLE.Text = "Taxable"
        '
        'CHKCUSTOMER_CHARGE
        '
        Me.CHKCUSTOMER_CHARGE.Location = New System.Drawing.Point(-10, 129)
        Me.CHKCUSTOMER_CHARGE.Name = "CHKCUSTOMER_CHARGE"
        Me.CHKCUSTOMER_CHARGE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKCUSTOMER_CHARGE.Size = New System.Drawing.Size(106, 23)
        Me.CHKCUSTOMER_CHARGE.TabIndex = 5
        Me.CHKCUSTOMER_CHARGE.Text = "Charge"
        '
        'CmbCUSTOMER_PRICE_LEVEL
        '
        Me.CmbCUSTOMER_PRICE_LEVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCUSTOMER_PRICE_LEVEL.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.CmbCUSTOMER_PRICE_LEVEL.Location = New System.Drawing.Point(82, 103)
        Me.CmbCUSTOMER_PRICE_LEVEL.Name = "CmbCUSTOMER_PRICE_LEVEL"
        Me.CmbCUSTOMER_PRICE_LEVEL.Size = New System.Drawing.Size(50, 21)
        Me.CmbCUSTOMER_PRICE_LEVEL.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(1, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 375
        Me.Label5.Text = "Price Level"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCUSTOMER_TERRITORY
        '
        Me.CmbCUSTOMER_TERRITORY.DataSource = Me.DsFrmServiceSetup1.cust_tab_territory
        Me.CmbCUSTOMER_TERRITORY.DisplayMember = "desc_territory"
        Me.CmbCUSTOMER_TERRITORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCUSTOMER_TERRITORY.Location = New System.Drawing.Point(82, 79)
        Me.CmbCUSTOMER_TERRITORY.Name = "CmbCUSTOMER_TERRITORY"
        Me.CmbCUSTOMER_TERRITORY.Size = New System.Drawing.Size(180, 21)
        Me.CmbCUSTOMER_TERRITORY.TabIndex = 3
        Me.CmbCUSTOMER_TERRITORY.ValueMember = "cod_territory"
        '
        'DsFrmServiceSetup1
        '
        Me.DsFrmServiceSetup1.DataSetName = "DSFrmServiceSetup"
        Me.DsFrmServiceSetup1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(1, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 373
        Me.Label3.Text = "Territory"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCUSTOMER_CLASS
        '
        Me.CmbCUSTOMER_CLASS.DataSource = Me.DsFrmServiceSetup1.cust_tab_class
        Me.CmbCUSTOMER_CLASS.DisplayMember = "desc_class"
        Me.CmbCUSTOMER_CLASS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCUSTOMER_CLASS.Location = New System.Drawing.Point(82, 55)
        Me.CmbCUSTOMER_CLASS.Name = "CmbCUSTOMER_CLASS"
        Me.CmbCUSTOMER_CLASS.Size = New System.Drawing.Size(180, 21)
        Me.CmbCUSTOMER_CLASS.TabIndex = 2
        Me.CmbCUSTOMER_CLASS.ValueMember = "cod_class"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(1, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 371
        Me.Label2.Text = "Class"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCUSTOMER_SOURCE
        '
        Me.CmbCUSTOMER_SOURCE.DataSource = Me.DsFrmServiceSetup1.cust_tab_source
        Me.CmbCUSTOMER_SOURCE.DisplayMember = "desc_source"
        Me.CmbCUSTOMER_SOURCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCUSTOMER_SOURCE.Location = New System.Drawing.Point(82, 31)
        Me.CmbCUSTOMER_SOURCE.Name = "CmbCUSTOMER_SOURCE"
        Me.CmbCUSTOMER_SOURCE.Size = New System.Drawing.Size(180, 21)
        Me.CmbCUSTOMER_SOURCE.TabIndex = 1
        Me.CmbCUSTOMER_SOURCE.ValueMember = "cod_source"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(1, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 369
        Me.Label1.Text = "Source"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCUSTOMER_TYPE
        '
        Me.CmbCUSTOMER_TYPE.DataSource = Me.DsFrmServiceSetup1.cust_tab_type
        Me.CmbCUSTOMER_TYPE.DisplayMember = "desc_type"
        Me.CmbCUSTOMER_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCUSTOMER_TYPE.Location = New System.Drawing.Point(82, 7)
        Me.CmbCUSTOMER_TYPE.Name = "CmbCUSTOMER_TYPE"
        Me.CmbCUSTOMER_TYPE.Size = New System.Drawing.Size(180, 21)
        Me.CmbCUSTOMER_TYPE.TabIndex = 0
        Me.CmbCUSTOMER_TYPE.ValueMember = "cod_type"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(1, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 21)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CHKServiceDescriptionEditFlag)
        Me.TabPage3.Controls.Add(Me.CHKItemDescriptionEditFlag)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.NUMShop_Supply_on_Parts)
        Me.TabPage3.Controls.Add(Me.CHKShop_Supply_on_Parts_Flag)
        Me.TabPage3.Controls.Add(Me.NUMShop_Supply_on_Labor)
        Me.TabPage3.Controls.Add(Me.CHKSERVICE_REMINDER)
        Me.TabPage3.Controls.Add(Me.CHKSERVICE_SCHEDULE)
        Me.TabPage3.Controls.Add(Me.CHKSERVICE_CHARGE_SHOP_SUPPLY)
        Me.TabPage3.Controls.Add(Me.CHKSERVICE_REQUIRE_TECHNISIAN)
        Me.TabPage3.Controls.Add(Me.CHKSERVICE_TAXABLE)
        Me.TabPage3.Controls.Add(Me.CmbSERVICE_CATEGORY)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.CmbSERVICE_TYPE)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.CHKShop_Supply_on_Labor_Flag)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(586, 205)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Services"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(478, 83)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(19, 21)
        Me.Label26.TabIndex = 382
        Me.Label26.Text = "%"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(478, 58)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 21)
        Me.Label25.TabIndex = 381
        Me.Label25.Text = "%"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NUMShop_Supply_on_Parts
        '
        Me.NUMShop_Supply_on_Parts.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NUMShop_Supply_on_Parts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NUMShop_Supply_on_Parts.DecimalDigits = 1
        Me.NUMShop_Supply_on_Parts.DefaultSendValue = False
        Me.NUMShop_Supply_on_Parts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NUMShop_Supply_on_Parts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NUMShop_Supply_on_Parts.Image = CType(resources.GetObject("NUMShop_Supply_on_Parts.Image"), System.Drawing.Image)
        Me.NUMShop_Supply_on_Parts.Location = New System.Drawing.Point(411, 82)
        Me.NUMShop_Supply_on_Parts.Maxlength = 5
        Me.NUMShop_Supply_on_Parts.MinusColor = System.Drawing.Color.Empty
        Me.NUMShop_Supply_on_Parts.Name = "NUMShop_Supply_on_Parts"
        Me.NUMShop_Supply_on_Parts.Size = New System.Drawing.Size(61, 22)
        Me.NUMShop_Supply_on_Parts.TabIndex = 10
        Me.NUMShop_Supply_on_Parts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NUMShop_Supply_on_Parts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CHKShop_Supply_on_Parts_Flag
        '
        Me.CHKShop_Supply_on_Parts_Flag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CHKShop_Supply_on_Parts_Flag.Location = New System.Drawing.Point(277, 82)
        Me.CHKShop_Supply_on_Parts_Flag.Name = "CHKShop_Supply_on_Parts_Flag"
        Me.CHKShop_Supply_on_Parts_Flag.Size = New System.Drawing.Size(140, 23)
        Me.CHKShop_Supply_on_Parts_Flag.TabIndex = 9
        Me.CHKShop_Supply_on_Parts_Flag.Text = "Shop Supply on Parts"
        '
        'NUMShop_Supply_on_Labor
        '
        Me.NUMShop_Supply_on_Labor.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NUMShop_Supply_on_Labor.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NUMShop_Supply_on_Labor.DecimalDigits = 1
        Me.NUMShop_Supply_on_Labor.DefaultSendValue = False
        Me.NUMShop_Supply_on_Labor.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NUMShop_Supply_on_Labor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NUMShop_Supply_on_Labor.Image = CType(resources.GetObject("NUMShop_Supply_on_Labor.Image"), System.Drawing.Image)
        Me.NUMShop_Supply_on_Labor.Location = New System.Drawing.Point(411, 56)
        Me.NUMShop_Supply_on_Labor.Maxlength = 5
        Me.NUMShop_Supply_on_Labor.MinusColor = System.Drawing.Color.Empty
        Me.NUMShop_Supply_on_Labor.Name = "NUMShop_Supply_on_Labor"
        Me.NUMShop_Supply_on_Labor.Size = New System.Drawing.Size(61, 22)
        Me.NUMShop_Supply_on_Labor.TabIndex = 8
        Me.NUMShop_Supply_on_Labor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NUMShop_Supply_on_Labor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CHKSERVICE_REMINDER
        '
        Me.CHKSERVICE_REMINDER.Location = New System.Drawing.Point(5, 160)
        Me.CHKSERVICE_REMINDER.Name = "CHKSERVICE_REMINDER"
        Me.CHKSERVICE_REMINDER.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKSERVICE_REMINDER.Size = New System.Drawing.Size(123, 23)
        Me.CHKSERVICE_REMINDER.TabIndex = 6
        Me.CHKSERVICE_REMINDER.Text = "Reminder"
        '
        'CHKSERVICE_SCHEDULE
        '
        Me.CHKSERVICE_SCHEDULE.Location = New System.Drawing.Point(5, 134)
        Me.CHKSERVICE_SCHEDULE.Name = "CHKSERVICE_SCHEDULE"
        Me.CHKSERVICE_SCHEDULE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKSERVICE_SCHEDULE.Size = New System.Drawing.Size(123, 23)
        Me.CHKSERVICE_SCHEDULE.TabIndex = 5
        Me.CHKSERVICE_SCHEDULE.Text = "Schedule"
        '
        'CHKSERVICE_CHARGE_SHOP_SUPPLY
        '
        Me.CHKSERVICE_CHARGE_SHOP_SUPPLY.Location = New System.Drawing.Point(5, 108)
        Me.CHKSERVICE_CHARGE_SHOP_SUPPLY.Name = "CHKSERVICE_CHARGE_SHOP_SUPPLY"
        Me.CHKSERVICE_CHARGE_SHOP_SUPPLY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKSERVICE_CHARGE_SHOP_SUPPLY.Size = New System.Drawing.Size(123, 23)
        Me.CHKSERVICE_CHARGE_SHOP_SUPPLY.TabIndex = 4
        Me.CHKSERVICE_CHARGE_SHOP_SUPPLY.Text = "Charge Shop Supply"
        '
        'CHKSERVICE_REQUIRE_TECHNISIAN
        '
        Me.CHKSERVICE_REQUIRE_TECHNISIAN.Location = New System.Drawing.Point(5, 82)
        Me.CHKSERVICE_REQUIRE_TECHNISIAN.Name = "CHKSERVICE_REQUIRE_TECHNISIAN"
        Me.CHKSERVICE_REQUIRE_TECHNISIAN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKSERVICE_REQUIRE_TECHNISIAN.Size = New System.Drawing.Size(123, 23)
        Me.CHKSERVICE_REQUIRE_TECHNISIAN.TabIndex = 3
        Me.CHKSERVICE_REQUIRE_TECHNISIAN.Text = "Require Technician"
        '
        'CHKSERVICE_TAXABLE
        '
        Me.CHKSERVICE_TAXABLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CHKSERVICE_TAXABLE.Location = New System.Drawing.Point(5, 56)
        Me.CHKSERVICE_TAXABLE.Name = "CHKSERVICE_TAXABLE"
        Me.CHKSERVICE_TAXABLE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKSERVICE_TAXABLE.Size = New System.Drawing.Size(123, 23)
        Me.CHKSERVICE_TAXABLE.TabIndex = 2
        Me.CHKSERVICE_TAXABLE.Text = "Taxable"
        '
        'CmbSERVICE_CATEGORY
        '
        Me.CmbSERVICE_CATEGORY.DataSource = Me.DsFrmServiceSetup1.inv_tab_service_category
        Me.CmbSERVICE_CATEGORY.DisplayMember = "desc_srvice_category"
        Me.CmbSERVICE_CATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSERVICE_CATEGORY.Location = New System.Drawing.Point(113, 30)
        Me.CmbSERVICE_CATEGORY.Name = "CmbSERVICE_CATEGORY"
        Me.CmbSERVICE_CATEGORY.Size = New System.Drawing.Size(180, 21)
        Me.CmbSERVICE_CATEGORY.TabIndex = 1
        Me.CmbSERVICE_CATEGORY.ValueMember = "service_category"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(32, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 380
        Me.Label4.Text = "Category"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbSERVICE_TYPE
        '
        Me.CmbSERVICE_TYPE.DataSource = Me.DsFrmServiceSetup1.inv_tab_service_type
        Me.CmbSERVICE_TYPE.DisplayMember = "service_type_desc"
        Me.CmbSERVICE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSERVICE_TYPE.Location = New System.Drawing.Point(113, 6)
        Me.CmbSERVICE_TYPE.Name = "CmbSERVICE_TYPE"
        Me.CmbSERVICE_TYPE.Size = New System.Drawing.Size(180, 21)
        Me.CmbSERVICE_TYPE.TabIndex = 0
        Me.CmbSERVICE_TYPE.ValueMember = "service_type"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(32, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 21)
        Me.Label11.TabIndex = 378
        Me.Label11.Text = "Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CHKShop_Supply_on_Labor_Flag
        '
        Me.CHKShop_Supply_on_Labor_Flag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CHKShop_Supply_on_Labor_Flag.Location = New System.Drawing.Point(277, 56)
        Me.CHKShop_Supply_on_Labor_Flag.Name = "CHKShop_Supply_on_Labor_Flag"
        Me.CHKShop_Supply_on_Labor_Flag.Size = New System.Drawing.Size(140, 23)
        Me.CHKShop_Supply_on_Labor_Flag.TabIndex = 7
        Me.CHKShop_Supply_on_Labor_Flag.Text = "Shop Supply on Labor"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CmbVEHICLE_QUARTS)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.CmbVEHICLE_OIL_TYPE)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.CmbVEHICLE_VEHICLE_TYPE)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.CmbVEHICLE_STATE)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(586, 205)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vehicles"
        '
        'CmbVEHICLE_QUARTS
        '
        Me.CmbVEHICLE_QUARTS.DataSource = Me.DsFrmServiceSetup1.inv_tab_quarts
        Me.CmbVEHICLE_QUARTS.DisplayMember = "desc_quarts"
        Me.CmbVEHICLE_QUARTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVEHICLE_QUARTS.Location = New System.Drawing.Point(88, 79)
        Me.CmbVEHICLE_QUARTS.Name = "CmbVEHICLE_QUARTS"
        Me.CmbVEHICLE_QUARTS.Size = New System.Drawing.Size(180, 21)
        Me.CmbVEHICLE_QUARTS.TabIndex = 3
        Me.CmbVEHICLE_QUARTS.ValueMember = "cod_quarts"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(7, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 381
        Me.Label7.Text = "Quarts"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbVEHICLE_OIL_TYPE
        '
        Me.CmbVEHICLE_OIL_TYPE.DataSource = Me.DsFrmServiceSetup1.inv_tab_oil_type
        Me.CmbVEHICLE_OIL_TYPE.DisplayMember = "desc_oil_type"
        Me.CmbVEHICLE_OIL_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVEHICLE_OIL_TYPE.Location = New System.Drawing.Point(88, 55)
        Me.CmbVEHICLE_OIL_TYPE.Name = "CmbVEHICLE_OIL_TYPE"
        Me.CmbVEHICLE_OIL_TYPE.Size = New System.Drawing.Size(180, 21)
        Me.CmbVEHICLE_OIL_TYPE.TabIndex = 2
        Me.CmbVEHICLE_OIL_TYPE.ValueMember = "cod_oil_type"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(7, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 21)
        Me.Label8.TabIndex = 379
        Me.Label8.Text = "Oil Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbVEHICLE_VEHICLE_TYPE
        '
        Me.CmbVEHICLE_VEHICLE_TYPE.DataSource = Me.DsFrmServiceSetup1.inv_tab_vehicle_type
        Me.CmbVEHICLE_VEHICLE_TYPE.DisplayMember = "desc_vehicle_type"
        Me.CmbVEHICLE_VEHICLE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVEHICLE_VEHICLE_TYPE.Location = New System.Drawing.Point(88, 31)
        Me.CmbVEHICLE_VEHICLE_TYPE.Name = "CmbVEHICLE_VEHICLE_TYPE"
        Me.CmbVEHICLE_VEHICLE_TYPE.Size = New System.Drawing.Size(180, 21)
        Me.CmbVEHICLE_VEHICLE_TYPE.TabIndex = 1
        Me.CmbVEHICLE_VEHICLE_TYPE.ValueMember = "cod_vehicle_type"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(7, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 21)
        Me.Label9.TabIndex = 377
        Me.Label9.Text = "Vehicle Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbVEHICLE_STATE
        '
        Me.CmbVEHICLE_STATE.DataSource = Me.DsFrmServiceSetup1.bas_zipcode
        Me.CmbVEHICLE_STATE.DisplayMember = "state"
        Me.CmbVEHICLE_STATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVEHICLE_STATE.Location = New System.Drawing.Point(88, 7)
        Me.CmbVEHICLE_STATE.Name = "CmbVEHICLE_STATE"
        Me.CmbVEHICLE_STATE.Size = New System.Drawing.Size(55, 21)
        Me.CmbVEHICLE_STATE.TabIndex = 0
        Me.CmbVEHICLE_STATE.ValueMember = "state"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(7, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 21)
        Me.Label10.TabIndex = 375
        Me.Label10.Text = "State"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CmbVENDOR_BUYER)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.CmbVENDOR_CLASS)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.CmbVENDOR_TYPE)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.CmbVENDOR_AP_TERM)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(586, 205)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Vendors"
        '
        'CmbVENDOR_BUYER
        '
        Me.CmbVENDOR_BUYER.DataSource = Me.DsFrmServiceSetup1.inv_buyer
        Me.CmbVENDOR_BUYER.DisplayMember = "desc_buyer"
        Me.CmbVENDOR_BUYER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVENDOR_BUYER.Location = New System.Drawing.Point(88, 80)
        Me.CmbVENDOR_BUYER.Name = "CmbVENDOR_BUYER"
        Me.CmbVENDOR_BUYER.Size = New System.Drawing.Size(180, 21)
        Me.CmbVENDOR_BUYER.TabIndex = 3
        Me.CmbVENDOR_BUYER.ValueMember = "buyer_id"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(8, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 21)
        Me.Label13.TabIndex = 381
        Me.Label13.Text = "Buyer"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbVENDOR_CLASS
        '
        Me.CmbVENDOR_CLASS.DataSource = Me.DsFrmServiceSetup1.inv_tab_vendor_class
        Me.CmbVENDOR_CLASS.DisplayMember = "desc_class"
        Me.CmbVENDOR_CLASS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVENDOR_CLASS.Location = New System.Drawing.Point(88, 56)
        Me.CmbVENDOR_CLASS.Name = "CmbVENDOR_CLASS"
        Me.CmbVENDOR_CLASS.Size = New System.Drawing.Size(180, 21)
        Me.CmbVENDOR_CLASS.TabIndex = 2
        Me.CmbVENDOR_CLASS.ValueMember = "class_vendor"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(8, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 21)
        Me.Label14.TabIndex = 379
        Me.Label14.Text = "Class"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbVENDOR_TYPE
        '
        Me.CmbVENDOR_TYPE.DataSource = Me.DsFrmServiceSetup1.inv_tab_vendor_type
        Me.CmbVENDOR_TYPE.DisplayMember = "desc_vendor_type"
        Me.CmbVENDOR_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVENDOR_TYPE.Location = New System.Drawing.Point(88, 32)
        Me.CmbVENDOR_TYPE.Name = "CmbVENDOR_TYPE"
        Me.CmbVENDOR_TYPE.Size = New System.Drawing.Size(180, 21)
        Me.CmbVENDOR_TYPE.TabIndex = 1
        Me.CmbVENDOR_TYPE.ValueMember = "vendor_type"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(8, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 21)
        Me.Label15.TabIndex = 377
        Me.Label15.Text = "Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbVENDOR_AP_TERM
        '
        Me.CmbVENDOR_AP_TERM.DataSource = Me.DsFrmServiceSetup1.GL_TAB_AR_TERM
        Me.CmbVENDOR_AP_TERM.DisplayMember = "AR_terms"
        Me.CmbVENDOR_AP_TERM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVENDOR_AP_TERM.Location = New System.Drawing.Point(88, 8)
        Me.CmbVENDOR_AP_TERM.Name = "CmbVENDOR_AP_TERM"
        Me.CmbVENDOR_AP_TERM.Size = New System.Drawing.Size(180, 21)
        Me.CmbVENDOR_AP_TERM.TabIndex = 0
        Me.CmbVENDOR_AP_TERM.ValueMember = "AR_terms"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(8, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 375
        Me.Label16.Text = "AP Terms"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.LblVendorName)
        Me.TabPage5.Controls.Add(Me.NumOUTSIDE_PURCHASES_MARKUP)
        Me.TabPage5.Controls.Add(Me.Vendor_Cod1)
        Me.TabPage5.Controls.Add(Me.CmbOUTSIDE_PURCHASES_LINE)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(586, 205)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Outside Purchases"
        '
        'LblVendorName
        '
        Me.LblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVendorName.Location = New System.Drawing.Point(197, 41)
        Me.LblVendorName.Name = "LblVendorName"
        Me.LblVendorName.Size = New System.Drawing.Size(368, 22)
        Me.LblVendorName.TabIndex = 374
        '
        'NumOUTSIDE_PURCHASES_MARKUP
        '
        Me.NumOUTSIDE_PURCHASES_MARKUP.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumOUTSIDE_PURCHASES_MARKUP.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumOUTSIDE_PURCHASES_MARKUP.DecimalDigits = 2
        Me.NumOUTSIDE_PURCHASES_MARKUP.DefaultSendValue = False
        Me.NumOUTSIDE_PURCHASES_MARKUP.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumOUTSIDE_PURCHASES_MARKUP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumOUTSIDE_PURCHASES_MARKUP.Image = CType(resources.GetObject("NumOUTSIDE_PURCHASES_MARKUP.Image"), System.Drawing.Image)
        Me.NumOUTSIDE_PURCHASES_MARKUP.Location = New System.Drawing.Point(93, 12)
        Me.NumOUTSIDE_PURCHASES_MARKUP.Maxlength = 6
        Me.NumOUTSIDE_PURCHASES_MARKUP.MinusColor = System.Drawing.Color.Empty
        Me.NumOUTSIDE_PURCHASES_MARKUP.Name = "NumOUTSIDE_PURCHASES_MARKUP"
        Me.NumOUTSIDE_PURCHASES_MARKUP.Size = New System.Drawing.Size(120, 22)
        Me.NumOUTSIDE_PURCHASES_MARKUP.TabIndex = 0
        Me.NumOUTSIDE_PURCHASES_MARKUP.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumOUTSIDE_PURCHASES_MARKUP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(94, 41)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Vendor_Cod1.TabIndex = 1
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'CmbOUTSIDE_PURCHASES_LINE
        '
        Me.CmbOUTSIDE_PURCHASES_LINE.DataSource = Me.DsFrmServiceSetup1.inv_tab_line
        Me.CmbOUTSIDE_PURCHASES_LINE.DisplayMember = "line"
        Me.CmbOUTSIDE_PURCHASES_LINE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOUTSIDE_PURCHASES_LINE.Location = New System.Drawing.Point(94, 68)
        Me.CmbOUTSIDE_PURCHASES_LINE.Name = "CmbOUTSIDE_PURCHASES_LINE"
        Me.CmbOUTSIDE_PURCHASES_LINE.Size = New System.Drawing.Size(177, 21)
        Me.CmbOUTSIDE_PURCHASES_LINE.TabIndex = 2
        Me.CmbOUTSIDE_PURCHASES_LINE.ValueMember = "line"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(18, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 21)
        Me.Label22.TabIndex = 373
        Me.Label22.Text = "Line"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(12, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 21)
        Me.Label23.TabIndex = 372
        Me.Label23.Text = "Markup %"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(13, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 21)
        Me.Label24.TabIndex = 371
        Me.Label24.Text = "Vendor"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Controls.Add(Me.NumSEVICE_REMINDER_THANK_UP_DAY)
        Me.TabPage6.Controls.Add(Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR)
        Me.TabPage6.Controls.Add(Me.Label18)
        Me.TabPage6.Controls.Add(Me.Label19)
        Me.TabPage6.Controls.Add(Me.Label21)
        Me.TabPage6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(586, 205)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Service Reminders"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(384, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 21)
        Me.Label20.TabIndex = 376
        Me.Label20.Text = "$"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumSEVICE_REMINDER_THANK_UP_DAY
        '
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.DecimalDigits = 0
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.DefaultSendValue = False
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.Image = CType(resources.GetObject("NumSEVICE_REMINDER_THANK_UP_DAY.Image"), System.Drawing.Image)
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.Location = New System.Drawing.Point(320, 44)
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.Maxlength = 3
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.MinusColor = System.Drawing.Color.Empty
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.Name = "NumSEVICE_REMINDER_THANK_UP_DAY"
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.Size = New System.Drawing.Size(61, 22)
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.TabIndex = 1
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSEVICE_REMINDER_THANK_UP_DAY.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumSEVICE_REMINDER_THANK_UP_DOLLAR
        '
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.DecimalDigits = 0
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.DefaultSendValue = False
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.Image = CType(resources.GetObject("NumSEVICE_REMINDER_THANK_UP_DOLLAR.Image"), System.Drawing.Image)
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.Location = New System.Drawing.Point(320, 12)
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.Maxlength = 3
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.MinusColor = System.Drawing.Color.Empty
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.Name = "NumSEVICE_REMINDER_THANK_UP_DOLLAR"
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.Size = New System.Drawing.Size(61, 22)
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.TabIndex = 0
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSEVICE_REMINDER_THANK_UP_DOLLAR.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(7, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(314, 21)
        Me.Label18.TabIndex = 375
        Me.Label18.Text = "Send Inactive customers cards if date of last visit is more than"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(31, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(287, 21)
        Me.Label19.TabIndex = 374
        Me.Label19.Text = "Send Thank you for new customers who spend mor than"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(381, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 21)
        Me.Label21.TabIndex = 377
        Me.Label21.Text = "Days"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.LblShortName)
        Me.Panel3.Controls.Add(Me.LblStoreName)
        Me.Panel3.Controls.Add(Me.CmbStores)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 29)
        Me.Panel3.TabIndex = 0
        '
        'LblShortName
        '
        Me.LblShortName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblShortName.Location = New System.Drawing.Point(457, 1)
        Me.LblShortName.Name = "LblShortName"
        Me.LblShortName.Size = New System.Drawing.Size(133, 23)
        Me.LblShortName.TabIndex = 384
        Me.LblShortName.Text = "LblShortName"
        Me.LblShortName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStoreName
        '
        Me.LblStoreName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreName.Location = New System.Drawing.Point(110, 1)
        Me.LblStoreName.Name = "LblStoreName"
        Me.LblStoreName.Size = New System.Drawing.Size(344, 23)
        Me.LblStoreName.TabIndex = 383
        Me.LblStoreName.Text = "LblCompanyName"
        Me.LblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbStores
        '
        Me.CmbStores.DataSource = Me.DsFrmServiceSetup1.STORE_SETUP
        Me.CmbStores.DisplayMember = "STORENO"
        Me.CmbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStores.Location = New System.Drawing.Point(54, 2)
        Me.CmbStores.Name = "CmbStores"
        Me.CmbStores.Size = New System.Drawing.Size(53, 21)
        Me.CmbStores.TabIndex = 0
        Me.CmbStores.TabStop = False
        Me.CmbStores.ValueMember = "STORENO"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(3, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 21)
        Me.Label17.TabIndex = 381
        Me.Label17.Text = "Store No"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Me.OleDbSelectCommand1.Connection = Me.CnnMDB
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_type, desc_type FROM cust_tab_type"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cust_tab_type(cod_type, desc_type) VALUES (@cod_type, @desc_type); SE" & _
        "LECT cod_type, desc_type FROM cust_tab_type WHERE (cod_type = @cod_type)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_type", System.Data.SqlDbType.VarChar, 50, "desc_type"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cust_tab_type SET cod_type = @cod_type, desc_type = @desc_type WHERE (cod_" & _
        "type = @Original_cod_type) AND (desc_type = @Original_desc_type OR @Original_des" & _
        "c_type IS NULL AND desc_type IS NULL); SELECT cod_type, desc_type FROM cust_tab_" & _
        "type WHERE (cod_type = @cod_type)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_type", System.Data.SqlDbType.VarChar, 50, "desc_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cust_tab_type WHERE (cod_type = @Original_cod_type) AND (desc_type = " & _
        "@Original_desc_type OR @Original_desc_type IS NULL AND desc_type IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAcust_tab_type
        '
        Me.DAcust_tab_type.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAcust_tab_type.InsertCommand = Me.SqlInsertCommand1
        Me.DAcust_tab_type.SelectCommand = Me.SqlSelectCommand1
        Me.DAcust_tab_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("desc_type", "desc_type")})})
        Me.DAcust_tab_type.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_source, desc_source FROM cust_tab_source"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO cust_tab_source(cod_source, desc_source) VALUES (@cod_source, @desc_s" & _
        "ource); SELECT cod_source, desc_source FROM cust_tab_source WHERE (cod_source = " & _
        "@cod_source)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_source", System.Data.SqlDbType.VarChar, 10, "desc_source"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE cust_tab_source SET cod_source = @cod_source, desc_source = @desc_source W" & _
        "HERE (cod_source = @Original_cod_source) AND (desc_source = @Original_desc_sourc" & _
        "e OR @Original_desc_source IS NULL AND desc_source IS NULL); SELECT cod_source, " & _
        "desc_source FROM cust_tab_source WHERE (cod_source = @cod_source)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_source", System.Data.SqlDbType.VarChar, 10, "desc_source"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_source", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_source", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM cust_tab_source WHERE (cod_source = @Original_cod_source) AND (desc_s" & _
        "ource = @Original_desc_source OR @Original_desc_source IS NULL AND desc_source I" & _
        "S NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_source", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_source", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAcust_tab_source
        '
        Me.DAcust_tab_source.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAcust_tab_source.InsertCommand = Me.SqlInsertCommand2
        Me.DAcust_tab_source.SelectCommand = Me.SqlSelectCommand2
        Me.DAcust_tab_source.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_source", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("desc_source", "desc_source")})})
        Me.DAcust_tab_source.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_class, desc_class FROM cust_tab_class"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO cust_tab_class(cod_class, desc_class) VALUES (@cod_class, @desc_class" & _
        "); SELECT cod_class, desc_class FROM cust_tab_class WHERE (cod_class = @cod_clas" & _
        "s)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE cust_tab_class SET cod_class = @cod_class, desc_class = @desc_class WHERE " & _
        "(cod_class = @Original_cod_class) AND (desc_class = @Original_desc_class OR @Ori" & _
        "ginal_desc_class IS NULL AND desc_class IS NULL); SELECT cod_class, desc_class F" & _
        "ROM cust_tab_class WHERE (cod_class = @cod_class)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM cust_tab_class WHERE (cod_class = @Original_cod_class) AND (desc_clas" & _
        "s = @Original_desc_class OR @Original_desc_class IS NULL AND desc_class IS NULL)" & _
        ""
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAcust_tab_class
        '
        Me.DAcust_tab_class.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAcust_tab_class.InsertCommand = Me.SqlInsertCommand3
        Me.DAcust_tab_class.SelectCommand = Me.SqlSelectCommand3
        Me.DAcust_tab_class.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        Me.DAcust_tab_class.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_territory, desc_territory FROM cust_tab_territory"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO cust_tab_territory(cod_territory, desc_territory) VALUES (@cod_territ" & _
        "ory, @desc_territory); SELECT cod_territory, desc_territory FROM cust_tab_territ" & _
        "ory WHERE (cod_territory = @cod_territory)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_territory", System.Data.SqlDbType.VarChar, 50, "desc_territory"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE cust_tab_territory SET cod_territory = @cod_territory, desc_territory = @d" & _
        "esc_territory WHERE (cod_territory = @Original_cod_territory) AND (desc_territor" & _
        "y = @Original_desc_territory OR @Original_desc_territory IS NULL AND desc_territ" & _
        "ory IS NULL); SELECT cod_territory, desc_territory FROM cust_tab_territory WHERE" & _
        " (cod_territory = @cod_territory)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_territory", System.Data.SqlDbType.VarChar, 50, "desc_territory"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_territory", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_territory", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM cust_tab_territory WHERE (cod_territory = @Original_cod_territory) AN" & _
        "D (desc_territory = @Original_desc_territory OR @Original_desc_territory IS NULL" & _
        " AND desc_territory IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_territory", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_territory", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAcust_tab_territory
        '
        Me.DAcust_tab_territory.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAcust_tab_territory.InsertCommand = Me.SqlInsertCommand4
        Me.DAcust_tab_territory.SelectCommand = Me.SqlSelectCommand4
        Me.DAcust_tab_territory.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_territory", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_territory", "desc_territory")})})
        Me.DAcust_tab_territory.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT DISTINCT state FROM bas_zipcode"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO bas_zipcode(zipcode, city, county, state, ariacode, fips_code, time_z" & _
        "one, dst) VALUES (@zipcode, @city, @county, @state, @ariacode, @fips_code, @time" & _
        "_zone, @dst); SELECT zipcode, city, county, state, ariacode, fips_code, time_zon" & _
        "e, dst FROM bas_zipcode WHERE (zipcode = @zipcode)"
        Me.SqlInsertCommand6.Connection = Me.Cnn
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 30, "city"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@county", System.Data.SqlDbType.VarChar, 30, "county"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ariacode", System.Data.SqlDbType.VarChar, 3, "ariacode"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fips_code", System.Data.SqlDbType.VarChar, 5, "fips_code"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_zone", System.Data.SqlDbType.VarChar, 6, "time_zone"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dst", System.Data.SqlDbType.VarChar, 1, "dst"))
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE bas_zipcode SET zipcode = @zipcode, city = @city, county = @county, state " & _
        "= @state, ariacode = @ariacode, fips_code = @fips_code, time_zone = @time_zone, " & _
        "dst = @dst WHERE (zipcode = @Original_zipcode) AND (ariacode = @Original_ariacod" & _
        "e OR @Original_ariacode IS NULL AND ariacode IS NULL) AND (city = @Original_city" & _
        " OR @Original_city IS NULL AND city IS NULL) AND (county = @Original_county OR @" & _
        "Original_county IS NULL AND county IS NULL) AND (dst = @Original_dst OR @Origina" & _
        "l_dst IS NULL AND dst IS NULL) AND (fips_code = @Original_fips_code OR @Original" & _
        "_fips_code IS NULL AND fips_code IS NULL) AND (state = @Original_state OR @Origi" & _
        "nal_state IS NULL AND state IS NULL) AND (time_zone = @Original_time_zone OR @Or" & _
        "iginal_time_zone IS NULL AND time_zone IS NULL); SELECT zipcode, city, county, s" & _
        "tate, ariacode, fips_code, time_zone, dst FROM bas_zipcode WHERE (zipcode = @zip" & _
        "code)"
        Me.SqlUpdateCommand6.Connection = Me.Cnn
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 30, "city"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@county", System.Data.SqlDbType.VarChar, 30, "county"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ariacode", System.Data.SqlDbType.VarChar, 3, "ariacode"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fips_code", System.Data.SqlDbType.VarChar, 5, "fips_code"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@time_zone", System.Data.SqlDbType.VarChar, 6, "time_zone"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dst", System.Data.SqlDbType.VarChar, 1, "dst"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ariacode", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ariacode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "city", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_county", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "county", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dst", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dst", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fips_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fips_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "state", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_time_zone", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "time_zone", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM bas_zipcode WHERE (zipcode = @Original_zipcode) AND (ariacode = @Orig" & _
        "inal_ariacode OR @Original_ariacode IS NULL AND ariacode IS NULL) AND (city = @O" & _
        "riginal_city OR @Original_city IS NULL AND city IS NULL) AND (county = @Original" & _
        "_county OR @Original_county IS NULL AND county IS NULL) AND (dst = @Original_dst" & _
        " OR @Original_dst IS NULL AND dst IS NULL) AND (fips_code = @Original_fips_code " & _
        "OR @Original_fips_code IS NULL AND fips_code IS NULL) AND (state = @Original_sta" & _
        "te OR @Original_state IS NULL AND state IS NULL) AND (time_zone = @Original_time" & _
        "_zone OR @Original_time_zone IS NULL AND time_zone IS NULL)"
        Me.SqlDeleteCommand6.Connection = Me.Cnn
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ariacode", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ariacode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "city", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_county", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "county", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dst", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dst", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fips_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fips_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "state", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_time_zone", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "time_zone", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_zipcode
        '
        Me.DAbas_zipcode.DeleteCommand = Me.SqlDeleteCommand6
        Me.DAbas_zipcode.InsertCommand = Me.SqlInsertCommand6
        Me.DAbas_zipcode.SelectCommand = Me.SqlSelectCommand6
        Me.DAbas_zipcode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_zipcode", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("county", "county"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("ariacode", "ariacode"), New System.Data.Common.DataColumnMapping("fips_code", "fips_code"), New System.Data.Common.DataColumnMapping("time_zone", "time_zone"), New System.Data.Common.DataColumnMapping("dst", "dst")})})
        Me.DAbas_zipcode.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cod_vehicle_type, desc_vehicle_type FROM inv_tab_vehicle_type"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'DAinv_tab_vehicle_type
        '
        Me.DAinv_tab_vehicle_type.SelectCommand = Me.SqlSelectCommand7
        Me.DAinv_tab_vehicle_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vehicle_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle_type", "cod_vehicle_type"), New System.Data.Common.DataColumnMapping("desc_vehicle_type", "desc_vehicle_type")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT cod_oil_type, desc_oil_type FROM inv_tab_oil_type"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO inv_tab_oil_type(cod_oil_type, desc_oil_type) VALUES (@cod_oil_type, " & _
        "@desc_oil_type); SELECT cod_oil_type, desc_oil_type FROM inv_tab_oil_type WHERE " & _
        "(cod_oil_type = @cod_oil_type)"
        Me.SqlInsertCommand8.Connection = Me.Cnn
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_oil_type", System.Data.SqlDbType.VarChar, 2, "cod_oil_type"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_oil_type", System.Data.SqlDbType.VarChar, 50, "desc_oil_type"))
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE inv_tab_oil_type SET cod_oil_type = @cod_oil_type, desc_oil_type = @desc_o" & _
        "il_type WHERE (cod_oil_type = @Original_cod_oil_type) AND (desc_oil_type = @Orig" & _
        "inal_desc_oil_type OR @Original_desc_oil_type IS NULL AND desc_oil_type IS NULL)" & _
        "; SELECT cod_oil_type, desc_oil_type FROM inv_tab_oil_type WHERE (cod_oil_type =" & _
        " @cod_oil_type)"
        Me.SqlUpdateCommand8.Connection = Me.Cnn
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_oil_type", System.Data.SqlDbType.VarChar, 2, "cod_oil_type"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_oil_type", System.Data.SqlDbType.VarChar, 50, "desc_oil_type"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_oil_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_oil_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_oil_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_oil_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM inv_tab_oil_type WHERE (cod_oil_type = @Original_cod_oil_type) AND (d" & _
        "esc_oil_type = @Original_desc_oil_type OR @Original_desc_oil_type IS NULL AND de" & _
        "sc_oil_type IS NULL)"
        Me.SqlDeleteCommand8.Connection = Me.Cnn
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_oil_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_oil_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_oil_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_oil_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_oil_type
        '
        Me.DAinv_tab_oil_type.DeleteCommand = Me.SqlDeleteCommand8
        Me.DAinv_tab_oil_type.InsertCommand = Me.SqlInsertCommand8
        Me.DAinv_tab_oil_type.SelectCommand = Me.SqlSelectCommand8
        Me.DAinv_tab_oil_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_oil_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_oil_type", "cod_oil_type"), New System.Data.Common.DataColumnMapping("desc_oil_type", "desc_oil_type")})})
        Me.DAinv_tab_oil_type.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT cod_quarts, desc_quarts FROM inv_tab_quarts"
        Me.SqlSelectCommand9.Connection = Me.Cnn
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = "INSERT INTO inv_tab_quarts(cod_quarts, desc_quarts) VALUES (@cod_quarts, @desc_qu" & _
        "arts); SELECT cod_quarts, desc_quarts FROM inv_tab_quarts WHERE (cod_quarts = @c" & _
        "od_quarts)"
        Me.SqlInsertCommand9.Connection = Me.Cnn
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quarts", System.Data.SqlDbType.VarChar, 1, "cod_quarts"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_quarts", System.Data.SqlDbType.VarChar, 50, "desc_quarts"))
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = "UPDATE inv_tab_quarts SET cod_quarts = @cod_quarts, desc_quarts = @desc_quarts WH" & _
        "ERE (cod_quarts = @Original_cod_quarts) AND (desc_quarts = @Original_desc_quarts" & _
        " OR @Original_desc_quarts IS NULL AND desc_quarts IS NULL); SELECT cod_quarts, d" & _
        "esc_quarts FROM inv_tab_quarts WHERE (cod_quarts = @cod_quarts)"
        Me.SqlUpdateCommand9.Connection = Me.Cnn
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quarts", System.Data.SqlDbType.VarChar, 1, "cod_quarts"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_quarts", System.Data.SqlDbType.VarChar, 50, "desc_quarts"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quarts", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quarts", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_quarts", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_quarts", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = "DELETE FROM inv_tab_quarts WHERE (cod_quarts = @Original_cod_quarts) AND (desc_qu" & _
        "arts = @Original_desc_quarts OR @Original_desc_quarts IS NULL AND desc_quarts IS" & _
        " NULL)"
        Me.SqlDeleteCommand9.Connection = Me.Cnn
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quarts", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quarts", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_quarts", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_quarts", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_quarts
        '
        Me.DAinv_tab_quarts.DeleteCommand = Me.SqlDeleteCommand9
        Me.DAinv_tab_quarts.InsertCommand = Me.SqlInsertCommand9
        Me.DAinv_tab_quarts.SelectCommand = Me.SqlSelectCommand9
        Me.DAinv_tab_quarts.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_quarts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quarts", "cod_quarts"), New System.Data.Common.DataColumnMapping("desc_quarts", "desc_quarts")})})
        Me.DAinv_tab_quarts.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT service_type, service_type_desc, asset_GL_account, cost_goods_GL_account, " & _
        "income_GL_account, return_GL_account FROM inv_tab_service_type"
        Me.SqlSelectCommand10.Connection = Me.Cnn
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = "INSERT INTO inv_tab_service_type(service_type, service_type_desc, asset_GL_accoun" & _
        "t, cost_goods_GL_account, income_GL_account, return_GL_account) VALUES (@service" & _
        "_type, @service_type_desc, @asset_GL_account, @cost_goods_GL_account, @income_GL" & _
        "_account, @return_GL_account); SELECT service_type, service_type_desc, asset_GL_" & _
        "account, cost_goods_GL_account, income_GL_account, return_GL_account FROM inv_ta" & _
        "b_service_type WHERE (service_type = @service_type)"
        Me.SqlInsertCommand10.Connection = Me.Cnn
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type_desc", System.Data.SqlDbType.VarChar, 50, "service_type_desc"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@asset_GL_account", System.Data.SqlDbType.VarChar, 10, "asset_GL_account"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, "cost_goods_GL_account"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@income_GL_account", System.Data.SqlDbType.VarChar, 10, "income_GL_account"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@return_GL_account", System.Data.SqlDbType.VarChar, 10, "return_GL_account"))
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = "UPDATE inv_tab_service_type SET service_type = @service_type, service_type_desc =" & _
        " @service_type_desc, asset_GL_account = @asset_GL_account, cost_goods_GL_account" & _
        " = @cost_goods_GL_account, income_GL_account = @income_GL_account, return_GL_acc" & _
        "ount = @return_GL_account WHERE (service_type = @Original_service_type) AND (ass" & _
        "et_GL_account = @Original_asset_GL_account OR @Original_asset_GL_account IS NULL" & _
        " AND asset_GL_account IS NULL) AND (cost_goods_GL_account = @Original_cost_goods" & _
        "_GL_account OR @Original_cost_goods_GL_account IS NULL AND cost_goods_GL_account" & _
        " IS NULL) AND (income_GL_account = @Original_income_GL_account OR @Original_inco" & _
        "me_GL_account IS NULL AND income_GL_account IS NULL) AND (return_GL_account = @O" & _
        "riginal_return_GL_account OR @Original_return_GL_account IS NULL AND return_GL_a" & _
        "ccount IS NULL) AND (service_type_desc = @Original_service_type_desc OR @Origina" & _
        "l_service_type_desc IS NULL AND service_type_desc IS NULL); SELECT service_type," & _
        " service_type_desc, asset_GL_account, cost_goods_GL_account, income_GL_account, " & _
        "return_GL_account FROM inv_tab_service_type WHERE (service_type = @service_type)" & _
        ""
        Me.SqlUpdateCommand10.Connection = Me.Cnn
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type_desc", System.Data.SqlDbType.VarChar, 50, "service_type_desc"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@asset_GL_account", System.Data.SqlDbType.VarChar, 10, "asset_GL_account"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, "cost_goods_GL_account"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@income_GL_account", System.Data.SqlDbType.VarChar, 10, "income_GL_account"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@return_GL_account", System.Data.SqlDbType.VarChar, 10, "return_GL_account"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_asset_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "asset_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost_goods_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_income_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "income_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_return_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "return_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand10
        '
        Me.SqlDeleteCommand10.CommandText = "DELETE FROM inv_tab_service_type WHERE (service_type = @Original_service_type) AN" & _
        "D (asset_GL_account = @Original_asset_GL_account OR @Original_asset_GL_account I" & _
        "S NULL AND asset_GL_account IS NULL) AND (cost_goods_GL_account = @Original_cost" & _
        "_goods_GL_account OR @Original_cost_goods_GL_account IS NULL AND cost_goods_GL_a" & _
        "ccount IS NULL) AND (income_GL_account = @Original_income_GL_account OR @Origina" & _
        "l_income_GL_account IS NULL AND income_GL_account IS NULL) AND (return_GL_accoun" & _
        "t = @Original_return_GL_account OR @Original_return_GL_account IS NULL AND retur" & _
        "n_GL_account IS NULL) AND (service_type_desc = @Original_service_type_desc OR @O" & _
        "riginal_service_type_desc IS NULL AND service_type_desc IS NULL)"
        Me.SqlDeleteCommand10.Connection = Me.Cnn
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_asset_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "asset_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost_goods_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_income_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "income_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_return_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "return_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_service_type
        '
        Me.DAinv_tab_service_type.DeleteCommand = Me.SqlDeleteCommand10
        Me.DAinv_tab_service_type.InsertCommand = Me.SqlInsertCommand10
        Me.DAinv_tab_service_type.SelectCommand = Me.SqlSelectCommand10
        Me.DAinv_tab_service_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_service_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_type_desc", "service_type_desc"), New System.Data.Common.DataColumnMapping("asset_GL_account", "asset_GL_account"), New System.Data.Common.DataColumnMapping("cost_goods_GL_account", "cost_goods_GL_account"), New System.Data.Common.DataColumnMapping("income_GL_account", "income_GL_account"), New System.Data.Common.DataColumnMapping("return_GL_account", "return_GL_account")})})
        Me.DAinv_tab_service_type.UpdateCommand = Me.SqlUpdateCommand10
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT service_category, desc_srvice_category FROM inv_tab_service_category"
        Me.SqlSelectCommand11.Connection = Me.Cnn
        '
        'SqlInsertCommand11
        '
        Me.SqlInsertCommand11.CommandText = "INSERT INTO inv_tab_service_category(service_category, desc_srvice_category) VALU" & _
        "ES (@service_category, @desc_srvice_category); SELECT service_category, desc_srv" & _
        "ice_category FROM inv_tab_service_category WHERE (service_category = @service_ca" & _
        "tegory)"
        Me.SqlInsertCommand11.Connection = Me.Cnn
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_srvice_category", System.Data.SqlDbType.VarChar, 50, "desc_srvice_category"))
        '
        'SqlUpdateCommand11
        '
        Me.SqlUpdateCommand11.CommandText = "UPDATE inv_tab_service_category SET service_category = @service_category, desc_sr" & _
        "vice_category = @desc_srvice_category WHERE (service_category = @Original_servic" & _
        "e_category) AND (desc_srvice_category = @Original_desc_srvice_category OR @Origi" & _
        "nal_desc_srvice_category IS NULL AND desc_srvice_category IS NULL); SELECT servi" & _
        "ce_category, desc_srvice_category FROM inv_tab_service_category WHERE (service_c" & _
        "ategory = @service_category)"
        Me.SqlUpdateCommand11.Connection = Me.Cnn
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_srvice_category", System.Data.SqlDbType.VarChar, 50, "desc_srvice_category"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_category", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_category", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_srvice_category", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_srvice_category", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand11
        '
        Me.SqlDeleteCommand11.CommandText = "DELETE FROM inv_tab_service_category WHERE (service_category = @Original_service_" & _
        "category) AND (desc_srvice_category = @Original_desc_srvice_category OR @Origina" & _
        "l_desc_srvice_category IS NULL AND desc_srvice_category IS NULL)"
        Me.SqlDeleteCommand11.Connection = Me.Cnn
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_category", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_category", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_srvice_category", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_srvice_category", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_service_category
        '
        Me.DAinv_tab_service_category.DeleteCommand = Me.SqlDeleteCommand11
        Me.DAinv_tab_service_category.InsertCommand = Me.SqlInsertCommand11
        Me.DAinv_tab_service_category.SelectCommand = Me.SqlSelectCommand11
        Me.DAinv_tab_service_category.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_service_category", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("desc_srvice_category", "desc_srvice_category")})})
        Me.DAinv_tab_service_category.UpdateCommand = Me.SqlUpdateCommand11
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT cod_brand, style, line, features, benefits, treadwear, traction, temperatu" & _
        "re, limit_warranty, construction, remark, image_remark, tread_life, wet_traction" & _
        ", quiet_ride, handling, winter_traction, nud_traction, overall_score, dry_tracti" & _
        "on, ride_comfort FROM inv_tab_line"
        Me.SqlSelectCommand12.Connection = Me.Cnn
        '
        'DAinv_tab_line
        '
        Me.DAinv_tab_line.SelectCommand = Me.SqlSelectCommand12
        Me.DAinv_tab_line.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("features", "features"), New System.Data.Common.DataColumnMapping("benefits", "benefits"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("limit_warranty", "limit_warranty"), New System.Data.Common.DataColumnMapping("construction", "construction"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark"), New System.Data.Common.DataColumnMapping("tread_life", "tread_life"), New System.Data.Common.DataColumnMapping("wet_traction", "wet_traction"), New System.Data.Common.DataColumnMapping("quiet_ride", "quiet_ride"), New System.Data.Common.DataColumnMapping("handling", "handling"), New System.Data.Common.DataColumnMapping("winter_traction", "winter_traction"), New System.Data.Common.DataColumnMapping("nud_traction", "nud_traction"), New System.Data.Common.DataColumnMapping("overall_score", "overall_score"), New System.Data.Common.DataColumnMapping("dry_traction", "dry_traction"), New System.Data.Common.DataColumnMapping("ride_comfort", "ride_comfort")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT buyer_id, desc_buyer FROM inv_buyer"
        Me.SqlSelectCommand14.Connection = Me.Cnn
        '
        'SqlInsertCommand14
        '
        Me.SqlInsertCommand14.CommandText = "INSERT INTO inv_buyer(buyer_id, desc_buyer) VALUES (@buyer_id, @desc_buyer); SELE" & _
        "CT buyer_id, desc_buyer FROM inv_buyer WHERE (buyer_id = @buyer_id)"
        Me.SqlInsertCommand14.Connection = Me.Cnn
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_buyer", System.Data.SqlDbType.VarChar, 50, "desc_buyer"))
        '
        'SqlUpdateCommand14
        '
        Me.SqlUpdateCommand14.CommandText = "UPDATE inv_buyer SET buyer_id = @buyer_id, desc_buyer = @desc_buyer WHERE (buyer_" & _
        "id = @Original_buyer_id) AND (desc_buyer = @Original_desc_buyer OR @Original_des" & _
        "c_buyer IS NULL AND desc_buyer IS NULL); SELECT buyer_id, desc_buyer FROM inv_bu" & _
        "yer WHERE (buyer_id = @buyer_id)"
        Me.SqlUpdateCommand14.Connection = Me.Cnn
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_buyer", System.Data.SqlDbType.VarChar, 50, "desc_buyer"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_buyer_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "buyer_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_buyer", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_buyer", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand14
        '
        Me.SqlDeleteCommand14.CommandText = "DELETE FROM inv_buyer WHERE (buyer_id = @Original_buyer_id) AND (desc_buyer = @Or" & _
        "iginal_desc_buyer OR @Original_desc_buyer IS NULL AND desc_buyer IS NULL)"
        Me.SqlDeleteCommand14.Connection = Me.Cnn
        Me.SqlDeleteCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_buyer_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "buyer_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_buyer", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_buyer", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_buyer
        '
        Me.DAinv_buyer.DeleteCommand = Me.SqlDeleteCommand14
        Me.DAinv_buyer.InsertCommand = Me.SqlInsertCommand14
        Me.DAinv_buyer.SelectCommand = Me.SqlSelectCommand14
        Me.DAinv_buyer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_buyer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("desc_buyer", "desc_buyer")})})
        Me.DAinv_buyer.UpdateCommand = Me.SqlUpdateCommand14
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT class_vendor, desc_class FROM inv_tab_vendor_class"
        Me.SqlSelectCommand15.Connection = Me.Cnn
        '
        'SqlInsertCommand15
        '
        Me.SqlInsertCommand15.CommandText = "INSERT INTO inv_tab_vendor_class(class_vendor, desc_class) VALUES (@class_vendor," & _
        " @desc_class); SELECT class_vendor, desc_class FROM inv_tab_vendor_class WHERE (" & _
        "class_vendor = @class_vendor)"
        Me.SqlInsertCommand15.Connection = Me.Cnn
        Me.SqlInsertCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.SqlInsertCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        '
        'SqlUpdateCommand15
        '
        Me.SqlUpdateCommand15.CommandText = "UPDATE inv_tab_vendor_class SET class_vendor = @class_vendor, desc_class = @desc_" & _
        "class WHERE (class_vendor = @Original_class_vendor) AND (desc_class = @Original_" & _
        "desc_class OR @Original_desc_class IS NULL AND desc_class IS NULL); SELECT class" & _
        "_vendor, desc_class FROM inv_tab_vendor_class WHERE (class_vendor = @class_vendo" & _
        "r)"
        Me.SqlUpdateCommand15.Connection = Me.Cnn
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand15
        '
        Me.SqlDeleteCommand15.CommandText = "DELETE FROM inv_tab_vendor_class WHERE (class_vendor = @Original_class_vendor) AN" & _
        "D (desc_class = @Original_desc_class OR @Original_desc_class IS NULL AND desc_cl" & _
        "ass IS NULL)"
        Me.SqlDeleteCommand15.Connection = Me.Cnn
        Me.SqlDeleteCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_vendor_class
        '
        Me.DAinv_tab_vendor_class.DeleteCommand = Me.SqlDeleteCommand15
        Me.DAinv_tab_vendor_class.InsertCommand = Me.SqlInsertCommand15
        Me.DAinv_tab_vendor_class.SelectCommand = Me.SqlSelectCommand15
        Me.DAinv_tab_vendor_class.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        Me.DAinv_tab_vendor_class.UpdateCommand = Me.SqlUpdateCommand15
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = "SELECT vendor_type, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type" & _
        ""
        Me.SqlSelectCommand16.Connection = Me.Cnn
        '
        'SqlInsertCommand16
        '
        Me.SqlInsertCommand16.CommandText = "INSERT INTO inv_tab_vendor_type(vendor_type, desc_vendor_type, GL_expense_account" & _
        ") VALUES (@vendor_type, @desc_vendor_type, @GL_expense_account); SELECT vendor_t" & _
        "ype, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type WHERE (vendor" & _
        "_type = @vendor_type)"
        Me.SqlInsertCommand16.Connection = Me.Cnn
        Me.SqlInsertCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlInsertCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor_type", System.Data.SqlDbType.VarChar, 50, "desc_vendor_type"))
        Me.SqlInsertCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        '
        'SqlUpdateCommand16
        '
        Me.SqlUpdateCommand16.CommandText = "UPDATE inv_tab_vendor_type SET vendor_type = @vendor_type, desc_vendor_type = @de" & _
        "sc_vendor_type, GL_expense_account = @GL_expense_account WHERE (vendor_type = @O" & _
        "riginal_vendor_type) AND (GL_expense_account = @Original_GL_expense_account OR @" & _
        "Original_GL_expense_account IS NULL AND GL_expense_account IS NULL) AND (desc_ve" & _
        "ndor_type = @Original_desc_vendor_type OR @Original_desc_vendor_type IS NULL AND" & _
        " desc_vendor_type IS NULL); SELECT vendor_type, desc_vendor_type, GL_expense_acc" & _
        "ount FROM inv_tab_vendor_type WHERE (vendor_type = @vendor_type)"
        Me.SqlUpdateCommand16.Connection = Me.Cnn
        Me.SqlUpdateCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlUpdateCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor_type", System.Data.SqlDbType.VarChar, 50, "desc_vendor_type"))
        Me.SqlUpdateCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        Me.SqlUpdateCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand16
        '
        Me.SqlDeleteCommand16.CommandText = "DELETE FROM inv_tab_vendor_type WHERE (vendor_type = @Original_vendor_type) AND (" & _
        "GL_expense_account = @Original_GL_expense_account OR @Original_GL_expense_accoun" & _
        "t IS NULL AND GL_expense_account IS NULL) AND (desc_vendor_type = @Original_desc" & _
        "_vendor_type OR @Original_desc_vendor_type IS NULL AND desc_vendor_type IS NULL)" & _
        ""
        Me.SqlDeleteCommand16.Connection = Me.Cnn
        Me.SqlDeleteCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_vendor_type
        '
        Me.DAinv_tab_vendor_type.DeleteCommand = Me.SqlDeleteCommand16
        Me.DAinv_tab_vendor_type.InsertCommand = Me.SqlInsertCommand16
        Me.DAinv_tab_vendor_type.SelectCommand = Me.SqlSelectCommand16
        Me.DAinv_tab_vendor_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("desc_vendor_type", "desc_vendor_type"), New System.Data.Common.DataColumnMapping("GL_expense_account", "GL_expense_account")})})
        Me.DAinv_tab_vendor_type.UpdateCommand = Me.SqlUpdateCommand16
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.DeleteCommand = Me.SqlCommand1
        Me.DAGL_TAB_AR_TERM.InsertCommand = Me.SqlCommand2
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlCommand3
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        Me.DAGL_TAB_AR_TERM.UpdateCommand = Me.SqlCommand4
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM GL_TAB_AR_TERM WHERE (AR_terms = @Original_AR_terms) AND (DD_DISCOUNT" & _
        "_PERCENTAGE = @Original_DD_DISCOUNT_PERCENTAGE OR @Original_DD_DISCOUNT_PERCENTA" & _
        "GE IS NULL AND DD_DISCOUNT_PERCENTAGE IS NULL) AND (DD_IF_ISSUED_WITHIN_DAYS = @" & _
        "Original_DD_IF_ISSUED_WITHIN_DAYS OR @Original_DD_IF_ISSUED_WITHIN_DAYS IS NULL " & _
        "AND DD_IF_ISSUED_WITHIN_DAYS IS NULL) AND (DD_IF_PAY_WITHIN_DAYS = @Original_DD_" & _
        "IF_PAY_WITHIN_DAYS OR @Original_DD_IF_PAY_WITHIN_DAYS IS NULL AND DD_IF_PAY_WITH" & _
        "IN_DAYS IS NULL) AND (DD_NET_DUE_BEFORE = @Original_DD_NET_DUE_BEFORE OR @Origin" & _
        "al_DD_NET_DUE_BEFORE IS NULL AND DD_NET_DUE_BEFORE IS NULL) AND (KIND_AR = @Orig" & _
        "inal_KIND_AR OR @Original_KIND_AR IS NULL AND KIND_AR IS NULL) AND (MP_BEFORE_DA" & _
        "Y = @Original_MP_BEFORE_DAY OR @Original_MP_BEFORE_DAY IS NULL AND MP_BEFORE_DAY" & _
        " IS NULL) AND (MP_NO_OF_PAYMENT = @Original_MP_NO_OF_PAYMENT OR @Original_MP_NO_" & _
        "OF_PAYMENT IS NULL AND MP_NO_OF_PAYMENT IS NULL) AND (ST_DISCOUNT_PERCENTAGE = @" & _
        "Original_ST_DISCOUNT_PERCENTAGE OR @Original_ST_DISCOUNT_PERCENTAGE IS NULL AND " & _
        "ST_DISCOUNT_PERCENTAGE IS NULL) AND (ST_IF_PAY_WITHIN_DAYS = @Original_ST_IF_PAY" & _
        "_WITHIN_DAYS OR @Original_ST_IF_PAY_WITHIN_DAYS IS NULL AND ST_IF_PAY_WITHIN_DAY" & _
        "S IS NULL) AND (ST_NET_DUE_IN = @Original_ST_NET_DUE_IN OR @Original_ST_NET_DUE_" & _
        "IN IS NULL AND ST_NET_DUE_IN IS NULL)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO GL_TAB_AR_TERM(AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTA" & _
        "GE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCO" & _
        "UNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY) VALUES (" & _
        "@AR_terms, @KIND_AR, @ST_NET_DUE_IN, @ST_DISCOUNT_PERCENTAGE, @ST_IF_PAY_WITHIN_" & _
        "DAYS, @DD_NET_DUE_BEFORE, @DD_IF_ISSUED_WITHIN_DAYS, @DD_DISCOUNT_PERCENTAGE, @D" & _
        "D_IF_PAY_WITHIN_DAYS, @MP_NO_OF_PAYMENT, @MP_BEFORE_DAY); SELECT AR_terms, KIND_" & _
        "AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEF" & _
        "ORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP" & _
        "_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms = @AR_terms)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN" & _
        "_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_I" & _
        "F_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE GL_TAB_AR_TERM SET AR_terms = @AR_terms, KIND_AR = @KIND_AR, ST_NET_DUE_IN" & _
        " = @ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE = @ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_W" & _
        "ITHIN_DAYS = @ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE = @DD_NET_DUE_BEFORE, DD_" & _
        "IF_ISSUED_WITHIN_DAYS = @DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE = @DD_" & _
        "DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS = @DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PA" & _
        "YMENT = @MP_NO_OF_PAYMENT, MP_BEFORE_DAY = @MP_BEFORE_DAY WHERE (AR_terms = @Ori" & _
        "ginal_AR_terms) AND (DD_DISCOUNT_PERCENTAGE = @Original_DD_DISCOUNT_PERCENTAGE O" & _
        "R @Original_DD_DISCOUNT_PERCENTAGE IS NULL AND DD_DISCOUNT_PERCENTAGE IS NULL) A" & _
        "ND (DD_IF_ISSUED_WITHIN_DAYS = @Original_DD_IF_ISSUED_WITHIN_DAYS OR @Original_D" & _
        "D_IF_ISSUED_WITHIN_DAYS IS NULL AND DD_IF_ISSUED_WITHIN_DAYS IS NULL) AND (DD_IF" & _
        "_PAY_WITHIN_DAYS = @Original_DD_IF_PAY_WITHIN_DAYS OR @Original_DD_IF_PAY_WITHIN" & _
        "_DAYS IS NULL AND DD_IF_PAY_WITHIN_DAYS IS NULL) AND (DD_NET_DUE_BEFORE = @Origi" & _
        "nal_DD_NET_DUE_BEFORE OR @Original_DD_NET_DUE_BEFORE IS NULL AND DD_NET_DUE_BEFO" & _
        "RE IS NULL) AND (KIND_AR = @Original_KIND_AR OR @Original_KIND_AR IS NULL AND KI" & _
        "ND_AR IS NULL) AND (MP_BEFORE_DAY = @Original_MP_BEFORE_DAY OR @Original_MP_BEFO" & _
        "RE_DAY IS NULL AND MP_BEFORE_DAY IS NULL) AND (MP_NO_OF_PAYMENT = @Original_MP_N" & _
        "O_OF_PAYMENT OR @Original_MP_NO_OF_PAYMENT IS NULL AND MP_NO_OF_PAYMENT IS NULL)" & _
        " AND (ST_DISCOUNT_PERCENTAGE = @Original_ST_DISCOUNT_PERCENTAGE OR @Original_ST_" & _
        "DISCOUNT_PERCENTAGE IS NULL AND ST_DISCOUNT_PERCENTAGE IS NULL) AND (ST_IF_PAY_W" & _
        "ITHIN_DAYS = @Original_ST_IF_PAY_WITHIN_DAYS OR @Original_ST_IF_PAY_WITHIN_DAYS " & _
        "IS NULL AND ST_IF_PAY_WITHIN_DAYS IS NULL) AND (ST_NET_DUE_IN = @Original_ST_NET" & _
        "_DUE_IN OR @Original_ST_NET_DUE_IN IS NULL AND ST_NET_DUE_IN IS NULL); SELECT AR" & _
        "_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, D" & _
        "D_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WI" & _
        "THIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms =" & _
        " @AR_terms)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'CHKItemDescriptionEditFlag
        '
        Me.CHKItemDescriptionEditFlag.Location = New System.Drawing.Point(276, 134)
        Me.CHKItemDescriptionEditFlag.Name = "CHKItemDescriptionEditFlag"
        Me.CHKItemDescriptionEditFlag.Size = New System.Drawing.Size(199, 23)
        Me.CHKItemDescriptionEditFlag.TabIndex = 383
        Me.CHKItemDescriptionEditFlag.Text = "Item Description Edit"
        '
        'CHKServiceDescriptionEditFlag
        '
        Me.CHKServiceDescriptionEditFlag.Location = New System.Drawing.Point(276, 160)
        Me.CHKServiceDescriptionEditFlag.Name = "CHKServiceDescriptionEditFlag"
        Me.CHKServiceDescriptionEditFlag.Size = New System.Drawing.Size(199, 23)
        Me.CHKServiceDescriptionEditFlag.TabIndex = 384
        Me.CHKServiceDescriptionEditFlag.Text = "Service Description Edit"
        '
        'FrmServiceSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(602, 369)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmServiceSetup"
        Me.Text = "Service Setup"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DsFrmServiceSetup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmServiceSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables

        DsFrmServiceSetup1.Clear()
        If Cnn.State <> ConnectionState.Open Then
            Cnn.Open()
        End If
        DAbas_zipcode.Fill(DsFrmServiceSetup1, "bas_zipcode")
        DAcust_tab_class.Fill(DsFrmServiceSetup1, "cust_tab_class")
        DAcust_tab_source.Fill(DsFrmServiceSetup1, "cust_tab_source")
        DAcust_tab_territory.Fill(DsFrmServiceSetup1, "cust_tab_territory")
        DAcust_tab_type.Fill(DsFrmServiceSetup1, "cust_tab_type")
        DAGL_TAB_AR_TERM.Fill(DsFrmServiceSetup1, "GL_TAB_AR_TERM")
        DAinv_buyer.Fill(DsFrmServiceSetup1, "inv_buyer")
        DAinv_tab_line.Fill(DsFrmServiceSetup1, "inv_tab_line")
        DAinv_tab_oil_type.Fill(DsFrmServiceSetup1, "inv_tab_oil_type")
        DAinv_tab_quarts.Fill(DsFrmServiceSetup1, "inv_tab_quarts")
        DAinv_tab_service_category.Fill(DsFrmServiceSetup1, "inv_tab_service_category")
        DAinv_tab_service_type.Fill(DsFrmServiceSetup1, "inv_tab_service_type")
        DAinv_tab_vehicle_type.Fill(DsFrmServiceSetup1, "inv_tab_vehicle_type")
        DAinv_tab_vendor_class.Fill(DsFrmServiceSetup1, "inv_tab_vendor_class")
        DAinv_tab_vendor_type.Fill(DsFrmServiceSetup1, "inv_tab_vendor_type")

        If CnnMDB.State <> ConnectionState.Open Then
            CnnMDB.Open()
        End If
        DASTORE_SETUP.Fill(DsFrmServiceSetup1, "STORE_SETUP")

        CmbStores.SelectedValue = PubStoreNO
        Call SayStoreName()
        Call FillFields()

        BtnOk.Enabled = False
        BtnExit.Enabled = True
    End Sub
    Private Sub FillFields()
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveServiceSetupTable(CmbStores.SelectedValue)
        StoreNoVar = OleDbReader.Item("StoreNo")
        NumOUTSIDE_PURCHASES_MARKUP.Text = OleDbReader.Item("OUTSIDE_PURCHASES_MARKUP")
        NumSEVICE_REMINDER_THANK_UP_DAY.Text = OleDbReader.Item("SEVICE_REMINDER_THANK_UP_DAY")
        NumSEVICE_REMINDER_THANK_UP_DOLLAR.Text = OleDbReader.Item("SEVICE_REMINDER_THANK_UP_DOLLAR")
        Try
            NUMShop_Supply_on_Labor.Text = OleDbReader.Item("Shop_Supply_on_Labor")
        Catch ex As Exception
            NUMShop_Supply_on_Labor.Text = 0
        End Try
        Try
            NUMShop_Supply_on_Parts.Text = OleDbReader.Item("Shop_Supply_on_Parts")
        Catch ex As Exception
            NUMShop_Supply_on_Parts.Text = 0
        End Try
        Try
            CHKShop_Supply_on_Labor_Flag.Checked = OleDbReader.Item("Shop_Supply_on_Labor_Flag")
        Catch ex As Exception
            CHKShop_Supply_on_Labor_Flag.Checked = False
        End Try
        Try
            CHKShop_Supply_on_Parts_Flag.Checked = OleDbReader.Item("Shop_Supply_on_Parts_Flag")
        Catch ex As Exception
            CHKShop_Supply_on_Parts_Flag.Checked = False
        End Try

        CHKCUSTOMER_ACCEPT_CHECK.Checked = OleDbReader.Item("CUSTOMER_ACCEPT_CHECK")
        CHKCUSTOMER_CHARGE.Checked = OleDbReader.Item("CUSTOMER_CHARGE")
        CHKCUSTOMER_TAXABLE.Checked = OleDbReader.Item("CUSTOMER_TAXABLE")
        CHKSERVICE_CHARGE_SHOP_SUPPLY.Checked = OleDbReader.Item("SERVICE_CHARGE_SHOP_SUPPLY")
        CHKSERVICE_REMINDER.Checked = OleDbReader.Item("SERVICE_REMINDER")
        CHKSERVICE_REQUIRE_TECHNISIAN.Checked = OleDbReader.Item("SERVICE_REQUIRE_TECHNISIAN")
        CHKSERVICE_SCHEDULE.Checked = OleDbReader.Item("SERVICE_SCHEDULE")
        CHKSERVICE_TAXABLE.Checked = OleDbReader.Item("SERVICE_TAXABLE")
        Try
            CHKItemDescriptionEditFlag.Checked = OleDbReader.Item("ItemDescriptionEditFlag")
        Catch ex As Exception
            CHKItemDescriptionEditFlag.Checked = False
        End Try
        Try
            CHKServiceDescriptionEditFlag.Checked = OleDbReader.Item("ServiceDescriptionEditFlag")
        Catch ex As Exception
            CHKServiceDescriptionEditFlag.Checked = False
        End Try

        Try
            CmbCUSTOMER_CLASS.SelectedValue = OleDbReader.Item("CUSTOMER_CLASS")
        Catch ex As Exception
            CmbCUSTOMER_CLASS.SelectedValue = Nothing
        End Try

        Try
            CmbCUSTOMER_PRICE_LEVEL.Text = OleDbReader.Item("CUSTOMER_PRICE_LEVEL")
        Catch ex As Exception
            CmbCUSTOMER_PRICE_LEVEL.Text = "1"
        End Try

        Try
            CmbCUSTOMER_SOURCE.SelectedValue = OleDbReader.Item("CUSTOMER_SOURCE")
        Catch ex As Exception
            CmbCUSTOMER_SOURCE.SelectedValue = Nothing
        End Try

        Try
            CmbCUSTOMER_TERRITORY.SelectedValue = OleDbReader.Item("CUSTOMER_TERRITORY")
        Catch ex As Exception
            CmbCUSTOMER_TERRITORY.SelectedValue = Nothing
        End Try

        Try
            CmbCUSTOMER_TYPE.SelectedValue = OleDbReader.Item("CUSTOMER_TYPE")
        Catch ex As Exception
            CmbCUSTOMER_TYPE.SelectedValue = Nothing
        End Try

        Try
            CmbOUTSIDE_PURCHASES_LINE.SelectedValue = OleDbReader.Item("OUTSIDE_PURCHASES_LINE")
        Catch ex As Exception
            CmbOUTSIDE_PURCHASES_LINE.SelectedValue = Nothing
        End Try

        Try
            CmbSERVICE_CATEGORY.SelectedValue = OleDbReader.Item("SERVICE_CATEGORY")
        Catch ex As Exception
            CmbSERVICE_CATEGORY.SelectedValue = Nothing
        End Try

        Try
            CmbSERVICE_TYPE.SelectedValue = OleDbReader.Item("SERVICE_TYPE")
        Catch ex As Exception
            CmbSERVICE_TYPE.SelectedValue = Nothing
        End Try

        Try
            CmbVEHICLE_OIL_TYPE.SelectedValue = OleDbReader.Item("VEHICLE_OIL_TYPE")
        Catch ex As Exception
            CmbVEHICLE_OIL_TYPE.SelectedValue = Nothing
        End Try

        Try
            CmbVEHICLE_QUARTS.SelectedValue = OleDbReader.Item("VEHICLE_QUARTS")
        Catch ex As Exception
            CmbVEHICLE_QUARTS.SelectedValue = Nothing
        End Try

        Try
            CmbVEHICLE_STATE.SelectedValue = OleDbReader.Item("VEHICLE_STATE")
        Catch ex As Exception
            CmbVEHICLE_STATE.SelectedValue = Nothing
        End Try

        Try
            CmbVEHICLE_VEHICLE_TYPE.SelectedValue = OleDbReader.Item("VEHICLE_VEHICLE_TYPE")
        Catch ex As Exception
            CmbVEHICLE_VEHICLE_TYPE.SelectedValue = Nothing
        End Try

        Try
            CmbVENDOR_AP_TERM.SelectedValue = OleDbReader.Item("VENDOR_AP_TERM")
        Catch ex As Exception
            CmbVENDOR_AP_TERM.SelectedValue = Nothing
        End Try

        Try
            CmbVENDOR_BUYER.SelectedValue = OleDbReader.Item("VENDOR_BUYER")
        Catch ex As Exception
            CmbVENDOR_BUYER.SelectedValue = Nothing
        End Try

        Try
            CmbVENDOR_CLASS.SelectedValue = OleDbReader.Item("VENDOR_CLASS")
        Catch ex As Exception
            CmbVENDOR_CLASS.SelectedValue = Nothing
        End Try
        Try
            CmbVENDOR_TYPE.SelectedValue = OleDbReader.Item("VENDOR_TYPE")
        Catch ex As Exception
            CmbVENDOR_TYPE.SelectedValue = Nothing
        End Try

        Vendor_Cod1.Text = OleDbReader.Item("OUTSIDE_PURCHASES_VENDOR") & ""
        OleDbReader.Close()
        BtnOk.Enabled = False
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Call SaveData()
        BtnOk.Enabled = False
    End Sub
    Private Sub NumOUTSIDE_PURCHASES_MARKUP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumOUTSIDE_PURCHASES_MARKUP.TextChanged, NumSEVICE_REMINDER_THANK_UP_DAY.TextChanged, NumSEVICE_REMINDER_THANK_UP_DOLLAR.TextChanged, CmbCUSTOMER_CLASS.SelectedIndexChanged, CmbCUSTOMER_PRICE_LEVEL.SelectedIndexChanged, CmbCUSTOMER_SOURCE.SelectedIndexChanged, CmbCUSTOMER_TERRITORY.SelectedIndexChanged, CmbCUSTOMER_TYPE.SelectedIndexChanged, CmbOUTSIDE_PURCHASES_LINE.SelectedIndexChanged, CmbSERVICE_CATEGORY.SelectedIndexChanged, CmbSERVICE_TYPE.SelectedIndexChanged, CmbVEHICLE_OIL_TYPE.SelectedIndexChanged, CmbVEHICLE_QUARTS.SelectedIndexChanged, CmbVEHICLE_STATE.SelectedIndexChanged, CmbVEHICLE_VEHICLE_TYPE.SelectedIndexChanged, CmbVENDOR_AP_TERM.SelectedIndexChanged, CmbVENDOR_BUYER.SelectedIndexChanged, CmbVENDOR_CLASS.SelectedIndexChanged, CmbVENDOR_TYPE.SelectedIndexChanged, CHKCUSTOMER_ACCEPT_CHECK.CheckedChanged, CHKCUSTOMER_CHARGE.CheckedChanged, CHKCUSTOMER_TAXABLE.CheckedChanged, CHKSERVICE_CHARGE_SHOP_SUPPLY.CheckedChanged, CHKSERVICE_REMINDER.CheckedChanged, CHKSERVICE_REQUIRE_TECHNISIAN.CheckedChanged, CHKSERVICE_SCHEDULE.CheckedChanged, CHKSERVICE_TAXABLE.CheckedChanged, LblVendorName.TextChanged, CHKShop_Supply_on_Labor_Flag.CheckedChanged, CHKShop_Supply_on_Parts_Flag.CheckedChanged, CHKItemDescriptionEditFlag.CheckedChanged, CHKServiceDescriptionEditFlag.CheckedChanged, NUMShop_Supply_on_Labor.TextChanged, NUMShop_Supply_on_Parts.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Then
            BtnOk.Enabled = True
        End If
    End Sub
    Private Sub SaveData()
        If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDB.Connection.Open()
        End If
        CmdGeneralForMDB.CommandText = "Update SERVICE_SETUP SET OUTSIDE_PURCHASES_MARKUP=" & NumOUTSIDE_PURCHASES_MARKUP.Text & ",SEVICE_REMINDER_THANK_UP_DAY=" & NumSEVICE_REMINDER_THANK_UP_DAY.Text & ",SEVICE_REMINDER_THANK_UP_DOLLAR=" & NumSEVICE_REMINDER_THANK_UP_DOLLAR.Text & ",CUSTOMER_ACCEPT_CHECK=" & CHKCUSTOMER_ACCEPT_CHECK.Checked & ",CUSTOMER_CHARGE=" & CHKCUSTOMER_CHARGE.Checked & ",CUSTOMER_TAXABLE=" & CHKCUSTOMER_TAXABLE.Checked & ",SERVICE_CHARGE_SHOP_SUPPLY=" & CHKSERVICE_CHARGE_SHOP_SUPPLY.Checked & ",SERVICE_REMINDER=" & CHKSERVICE_REMINDER.Checked & ",SERVICE_REQUIRE_TECHNISIAN=" & CHKSERVICE_REQUIRE_TECHNISIAN.Checked & ",SERVICE_SCHEDULE=" & CHKSERVICE_SCHEDULE.Checked & ",SERVICE_TAXABLE=" & CHKSERVICE_TAXABLE.Checked & ",ItemDescriptionEditFlag=" & CHKItemDescriptionEditFlag.Checked & ",ServiceDescriptionEditFlag=" & CHKServiceDescriptionEditFlag.Checked & ",CUSTOMER_CLASS=" & Qt(CmbCUSTOMER_CLASS.SelectedValue & "") & ",CUSTOMER_PRICE_LEVEL=" & Qt(CmbCUSTOMER_PRICE_LEVEL.Text & "") & ",CUSTOMER_SOURCE=" & Qt(CmbCUSTOMER_SOURCE.SelectedValue & "") & ",CUSTOMER_TERRITORY=" & Qt(CmbCUSTOMER_TERRITORY.SelectedValue & "") & ",CUSTOMER_TYPE=" & Qt(CmbCUSTOMER_TYPE.SelectedValue & "") & ",OUTSIDE_PURCHASES_LINE=" & Qt(CmbOUTSIDE_PURCHASES_LINE.SelectedValue & "") & ",SERVICE_CATEGORY=" & Qt(CmbSERVICE_CATEGORY.SelectedValue & "") & ",SERVICE_TYPE=" & Qt(CmbSERVICE_TYPE.SelectedValue & "") & ",VEHICLE_OIL_TYPE=" & Qt(CmbVEHICLE_OIL_TYPE.SelectedValue & "") & ",VEHICLE_QUARTS=" & Qt(CmbVEHICLE_QUARTS.SelectedValue & "") & ",VEHICLE_STATE=" & Qt(CmbVEHICLE_STATE.SelectedValue & "") & ",VEHICLE_VEHICLE_TYPE=" & Qt(CmbVEHICLE_VEHICLE_TYPE.SelectedValue & "") & ",VENDOR_AP_TERM=" & Qt(CmbVENDOR_AP_TERM.SelectedValue & "") & ",VENDOR_BUYER=" & Qt(CmbVENDOR_BUYER.SelectedValue & "") & ",VENDOR_CLASS=" & Qt(CmbVENDOR_CLASS.SelectedValue & "") & ",VENDOR_TYPE=" & Qt(CmbVENDOR_TYPE.SelectedValue & "") & ",OUTSIDE_PURCHASES_VENDOR=" & Qt(Vendor_Cod1.Text) & ",Shop_Supply_on_Labor=" & NUMShop_Supply_on_Labor.Text & ",Shop_Supply_on_Parts=" & NUMShop_Supply_on_Parts.Text & ",Shop_Supply_on_Labor_Flag=" & CHKShop_Supply_on_Labor_Flag.Checked & ",Shop_Supply_on_Parts_Flag=" & CHKShop_Supply_on_Parts_Flag.Checked & " Where StoreNo=" & Qt(StoreNoVar)
        CmdGeneralForMDB.ExecuteNonQuery()
        CmdGeneralForMDB.Connection.Close()
    End Sub
    Private Sub FrmServiceSetup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Call CheckSaveInformationBeforeChangeStore()
    End Sub
    Private Sub CheckSaveInformationBeforeChangeStore()
        If BtnOk.Enabled Then
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Exit"
            c1.BtnRightText = "Save"
            c1.ShowFarMsg("Do tou want save data?")
            If c1.DialogResult = DialogResult.OK Then
                Call SaveData()
            End If
        End If
    End Sub
    Private Sub CmbStores_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbStores.SelectionChangeCommitted
        If CmbStores.SelectedValue <> StoreNoVar Then
            Call CheckSaveInformationBeforeChangeStore()
            Call FillFields()
            Call SayStoreName()
        End If
    End Sub
    Private Sub SayStoreName()
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(CmbStores.SelectedValue)
        CmbStores.SelectedValue = OleDbReaderForStore.Item("Storeno") & ""
        LblStoreName.Text = OleDbReaderForStore.Item("StoreName") & ""
        LblShortName.Text = OleDbReaderForStore.Item("ShortName") & ""
        OleDbReaderForStore.Close()
    End Sub
    Private Sub Vendor_Cod1_NotFindVendorCod() Handles Vendor_Cod1.NotFindVendorCod
        LblVendorName.Text = ""
    End Sub
    Private Sub Vendor_Cod1_FindVendorCod() Handles Vendor_Cod1.FindVendorCod
        LblVendorName.Text = Vendor_Cod1.Desc_Vendor
    End Sub
End Class
