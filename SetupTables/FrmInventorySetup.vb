Imports CommonClass
Public Class FrmInventorySetup
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CmbStores As System.Windows.Forms.ComboBox
    Friend WithEvents CHKRULES_ALLOW_WITHOUT_COST As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES_ALLOW_NEGATIVE As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES_SHOW_QUANTITY As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents TxtPRICE_LEVEL_DESC5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPRICE_LEVEL_DESC4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPRICE_LEVEL_DESC3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPRICE_LEVEL_DESC2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPRICE_LEVEL_DESC1 As System.Windows.Forms.TextBox
    Friend WithEvents CmbDEFAULT_PRICE_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEFAULT_ITEM_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CHKTaxable As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbRULES_ITEM_COST_MOTHOD As System.Windows.Forms.ComboBox
    Friend WithEvents NUMRULES_MAX_STOCK As CalcUtils.UcCalcText
    Friend WithEvents NUMRULES_MIN_STOCK As CalcUtils.UcCalcText
    Friend WithEvents NumDEFAULT_FRIEGHT As CalcUtils.UcCalcText
    Friend WithEvents NumDEFAULT_DELIVERY As CalcUtils.UcCalcText
    Friend WithEvents TxtPRICE_LEVEL_DESC6 As System.Windows.Forms.TextBox
    Friend WithEvents DAinv_tab_type_item As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmInventorySetup1 As SetupTables.DSFrmInventorySetup
    Friend WithEvents LblShortName As System.Windows.Forms.Label
    Friend WithEvents LblStoreName As System.Windows.Forms.Label
    Friend WithEvents CnnMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_price_code As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInventorySetup))
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
        Me.NumDEFAULT_FRIEGHT = New CalcUtils.UcCalcText
        Me.NumDEFAULT_DELIVERY = New CalcUtils.UcCalcText
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.CmbDEFAULT_PRICE_CODE = New System.Windows.Forms.ComboBox
        Me.DsFrmInventorySetup1 = New SetupTables.DSFrmInventorySetup
        Me.CmbDEFAULT_ITEM_TYPE = New System.Windows.Forms.ComboBox
        Me.CHKTaxable = New Janus.Windows.EditControls.UICheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.NUMRULES_MIN_STOCK = New CalcUtils.UcCalcText
        Me.NUMRULES_MAX_STOCK = New CalcUtils.UcCalcText
        Me.CmbRULES_ITEM_COST_MOTHOD = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CHKRULES_ALLOW_WITHOUT_COST = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES_ALLOW_NEGATIVE = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES_SHOW_QUANTITY = New Janus.Windows.EditControls.UICheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TxtPRICE_LEVEL_DESC6 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtPRICE_LEVEL_DESC5 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtPRICE_LEVEL_DESC4 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtPRICE_LEVEL_DESC3 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtPRICE_LEVEL_DESC2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtPRICE_LEVEL_DESC1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_type_item = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblShortName = New System.Windows.Forms.Label
        Me.LblStoreName = New System.Windows.Forms.Label
        Me.CmbStores = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_price_code = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DsFrmInventorySetup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.Label6.Text = "Inventory Setup"
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
        Me.BtnOk.Location = New System.Drawing.Point(510, 308)
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
        Me.BtnExit.Location = New System.Drawing.Point(20, 308)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(73, 29)
        Me.BtnExit.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 99)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(594, 204)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NumDEFAULT_FRIEGHT)
        Me.TabPage1.Controls.Add(Me.NumDEFAULT_DELIVERY)
        Me.TabPage1.Controls.Add(Me.Vendor_Cod1)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_PRICE_CODE)
        Me.TabPage1.Controls.Add(Me.CmbDEFAULT_ITEM_TYPE)
        Me.TabPage1.Controls.Add(Me.CHKTaxable)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(586, 178)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Defaults"
        '
        'NumDEFAULT_FRIEGHT
        '
        Me.NumDEFAULT_FRIEGHT.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDEFAULT_FRIEGHT.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDEFAULT_FRIEGHT.DecimalDigits = 0
        Me.NumDEFAULT_FRIEGHT.DefaultSendValue = False
        Me.NumDEFAULT_FRIEGHT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDEFAULT_FRIEGHT.Image = CType(resources.GetObject("NumDEFAULT_FRIEGHT.Image"), System.Drawing.Image)
        Me.NumDEFAULT_FRIEGHT.Location = New System.Drawing.Point(86, 101)
        Me.NumDEFAULT_FRIEGHT.Maxlength = 30
        Me.NumDEFAULT_FRIEGHT.Name = "NumDEFAULT_FRIEGHT"
        Me.NumDEFAULT_FRIEGHT.Size = New System.Drawing.Size(120, 22)
        Me.NumDEFAULT_FRIEGHT.TabIndex = 4
        Me.NumDEFAULT_FRIEGHT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDEFAULT_FRIEGHT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDEFAULT_DELIVERY
        '
        Me.NumDEFAULT_DELIVERY.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDEFAULT_DELIVERY.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDEFAULT_DELIVERY.DecimalDigits = 0
        Me.NumDEFAULT_DELIVERY.DefaultSendValue = False
        Me.NumDEFAULT_DELIVERY.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDEFAULT_DELIVERY.Image = CType(resources.GetObject("NumDEFAULT_DELIVERY.Image"), System.Drawing.Image)
        Me.NumDEFAULT_DELIVERY.Location = New System.Drawing.Point(86, 71)
        Me.NumDEFAULT_DELIVERY.Maxlength = 30
        Me.NumDEFAULT_DELIVERY.Name = "NumDEFAULT_DELIVERY"
        Me.NumDEFAULT_DELIVERY.Size = New System.Drawing.Size(120, 22)
        Me.NumDEFAULT_DELIVERY.TabIndex = 3
        Me.NumDEFAULT_DELIVERY.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDEFAULT_DELIVERY.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(86, 43)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Vendor_Cod1.TabIndex = 2
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'CmbDEFAULT_PRICE_CODE
        '
        Me.CmbDEFAULT_PRICE_CODE.DataSource = Me.DsFrmInventorySetup1.inv_price_code
        Me.CmbDEFAULT_PRICE_CODE.DisplayMember = "desc_price_code"
        Me.CmbDEFAULT_PRICE_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_PRICE_CODE.Location = New System.Drawing.Point(86, 133)
        Me.CmbDEFAULT_PRICE_CODE.Name = "CmbDEFAULT_PRICE_CODE"
        Me.CmbDEFAULT_PRICE_CODE.Size = New System.Drawing.Size(242, 21)
        Me.CmbDEFAULT_PRICE_CODE.TabIndex = 5
        Me.CmbDEFAULT_PRICE_CODE.ValueMember = "price_code"
        '
        'DsFrmInventorySetup1
        '
        Me.DsFrmInventorySetup1.DataSetName = "DSFrmInventorySetup"
        Me.DsFrmInventorySetup1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbDEFAULT_ITEM_TYPE
        '
        Me.CmbDEFAULT_ITEM_TYPE.DataSource = Me.DsFrmInventorySetup1.inv_tab_type_item
        Me.CmbDEFAULT_ITEM_TYPE.DisplayMember = "desc_item_type"
        Me.CmbDEFAULT_ITEM_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEFAULT_ITEM_TYPE.Location = New System.Drawing.Point(86, 13)
        Me.CmbDEFAULT_ITEM_TYPE.Name = "CmbDEFAULT_ITEM_TYPE"
        Me.CmbDEFAULT_ITEM_TYPE.Size = New System.Drawing.Size(190, 21)
        Me.CmbDEFAULT_ITEM_TYPE.TabIndex = 0
        Me.CmbDEFAULT_ITEM_TYPE.ValueMember = "cod_item_type"
        '
        'CHKTaxable
        '
        Me.CHKTaxable.Location = New System.Drawing.Point(281, 12)
        Me.CHKTaxable.Name = "CHKTaxable"
        Me.CHKTaxable.Size = New System.Drawing.Size(61, 23)
        Me.CHKTaxable.TabIndex = 1
        Me.CHKTaxable.Text = "Taxable"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(10, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 367
        Me.Label5.Text = "Price Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 365
        Me.Label3.Text = "Freight"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(5, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 364
        Me.Label2.Text = "Delivery"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(5, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "Vendor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(5, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 21)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "Item Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NUMRULES_MIN_STOCK)
        Me.TabPage2.Controls.Add(Me.NUMRULES_MAX_STOCK)
        Me.TabPage2.Controls.Add(Me.CmbRULES_ITEM_COST_MOTHOD)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.CHKRULES_ALLOW_WITHOUT_COST)
        Me.TabPage2.Controls.Add(Me.CHKRULES_ALLOW_NEGATIVE)
        Me.TabPage2.Controls.Add(Me.CHKRULES_SHOW_QUANTITY)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(586, 178)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rules"
        '
        'NUMRULES_MIN_STOCK
        '
        Me.NUMRULES_MIN_STOCK.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NUMRULES_MIN_STOCK.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NUMRULES_MIN_STOCK.DecimalDigits = 0
        Me.NUMRULES_MIN_STOCK.DefaultSendValue = False
        Me.NUMRULES_MIN_STOCK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NUMRULES_MIN_STOCK.Image = CType(resources.GetObject("NUMRULES_MIN_STOCK.Image"), System.Drawing.Image)
        Me.NUMRULES_MIN_STOCK.Location = New System.Drawing.Point(107, 64)
        Me.NUMRULES_MIN_STOCK.Maxlength = 30
        Me.NUMRULES_MIN_STOCK.Name = "NUMRULES_MIN_STOCK"
        Me.NUMRULES_MIN_STOCK.Size = New System.Drawing.Size(120, 22)
        Me.NUMRULES_MIN_STOCK.TabIndex = 2
        Me.NUMRULES_MIN_STOCK.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NUMRULES_MIN_STOCK.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NUMRULES_MAX_STOCK
        '
        Me.NUMRULES_MAX_STOCK.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NUMRULES_MAX_STOCK.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NUMRULES_MAX_STOCK.DecimalDigits = 0
        Me.NUMRULES_MAX_STOCK.DefaultSendValue = False
        Me.NUMRULES_MAX_STOCK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NUMRULES_MAX_STOCK.Image = CType(resources.GetObject("NUMRULES_MAX_STOCK.Image"), System.Drawing.Image)
        Me.NUMRULES_MAX_STOCK.Location = New System.Drawing.Point(107, 37)
        Me.NUMRULES_MAX_STOCK.Maxlength = 30
        Me.NUMRULES_MAX_STOCK.Name = "NUMRULES_MAX_STOCK"
        Me.NUMRULES_MAX_STOCK.Size = New System.Drawing.Size(120, 22)
        Me.NUMRULES_MAX_STOCK.TabIndex = 1
        Me.NUMRULES_MAX_STOCK.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NUMRULES_MAX_STOCK.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CmbRULES_ITEM_COST_MOTHOD
        '
        Me.CmbRULES_ITEM_COST_MOTHOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRULES_ITEM_COST_MOTHOD.Items.AddRange(New Object() {"Average Cost"})
        Me.CmbRULES_ITEM_COST_MOTHOD.Location = New System.Drawing.Point(107, 11)
        Me.CmbRULES_ITEM_COST_MOTHOD.Name = "CmbRULES_ITEM_COST_MOTHOD"
        Me.CmbRULES_ITEM_COST_MOTHOD.Size = New System.Drawing.Size(144, 21)
        Me.CmbRULES_ITEM_COST_MOTHOD.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(8, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 21)
        Me.Label8.TabIndex = 388
        Me.Label8.Text = "Min in-stock days"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(7, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 387
        Me.Label9.Text = "Max in-stock days"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(7, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 21)
        Me.Label10.TabIndex = 385
        Me.Label10.Text = "Item Cost Method"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CHKRULES_ALLOW_WITHOUT_COST
        '
        Me.CHKRULES_ALLOW_WITHOUT_COST.Location = New System.Drawing.Point(14, 149)
        Me.CHKRULES_ALLOW_WITHOUT_COST.Name = "CHKRULES_ALLOW_WITHOUT_COST"
        Me.CHKRULES_ALLOW_WITHOUT_COST.Size = New System.Drawing.Size(290, 23)
        Me.CHKRULES_ALLOW_WITHOUT_COST.TabIndex = 5
        Me.CHKRULES_ALLOW_WITHOUT_COST.Text = "Do not allow items without cost"
        '
        'CHKRULES_ALLOW_NEGATIVE
        '
        Me.CHKRULES_ALLOW_NEGATIVE.Location = New System.Drawing.Point(14, 121)
        Me.CHKRULES_ALLOW_NEGATIVE.Name = "CHKRULES_ALLOW_NEGATIVE"
        Me.CHKRULES_ALLOW_NEGATIVE.Size = New System.Drawing.Size(290, 23)
        Me.CHKRULES_ALLOW_NEGATIVE.TabIndex = 4
        Me.CHKRULES_ALLOW_NEGATIVE.Text = "Do not allow negative quantity on hand"
        '
        'CHKRULES_SHOW_QUANTITY
        '
        Me.CHKRULES_SHOW_QUANTITY.Location = New System.Drawing.Point(14, 93)
        Me.CHKRULES_SHOW_QUANTITY.Name = "CHKRULES_SHOW_QUANTITY"
        Me.CHKRULES_SHOW_QUANTITY.Size = New System.Drawing.Size(290, 23)
        Me.CHKRULES_SHOW_QUANTITY.TabIndex = 3
        Me.CHKRULES_SHOW_QUANTITY.Text = "Do not show quantity on hand on stock  count reports"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TxtPRICE_LEVEL_DESC6)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.TxtPRICE_LEVEL_DESC5)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.TxtPRICE_LEVEL_DESC4)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TxtPRICE_LEVEL_DESC3)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TxtPRICE_LEVEL_DESC2)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TxtPRICE_LEVEL_DESC1)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(586, 178)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Price Levels"
        '
        'TxtPRICE_LEVEL_DESC6
        '
        Me.TxtPRICE_LEVEL_DESC6.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPRICE_LEVEL_DESC6.Location = New System.Drawing.Point(103, 145)
        Me.TxtPRICE_LEVEL_DESC6.MaxLength = 25
        Me.TxtPRICE_LEVEL_DESC6.Name = "TxtPRICE_LEVEL_DESC6"
        Me.TxtPRICE_LEVEL_DESC6.Size = New System.Drawing.Size(186, 20)
        Me.TxtPRICE_LEVEL_DESC6.TabIndex = 5
        Me.TxtPRICE_LEVEL_DESC6.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(3, 145)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 21)
        Me.Label16.TabIndex = 376
        Me.Label16.Text = "Price Level 6"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPRICE_LEVEL_DESC5
        '
        Me.TxtPRICE_LEVEL_DESC5.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPRICE_LEVEL_DESC5.Location = New System.Drawing.Point(103, 118)
        Me.TxtPRICE_LEVEL_DESC5.MaxLength = 25
        Me.TxtPRICE_LEVEL_DESC5.Name = "TxtPRICE_LEVEL_DESC5"
        Me.TxtPRICE_LEVEL_DESC5.Size = New System.Drawing.Size(186, 20)
        Me.TxtPRICE_LEVEL_DESC5.TabIndex = 4
        Me.TxtPRICE_LEVEL_DESC5.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(3, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 21)
        Me.Label15.TabIndex = 374
        Me.Label15.Text = "Price Level 5"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPRICE_LEVEL_DESC4
        '
        Me.TxtPRICE_LEVEL_DESC4.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPRICE_LEVEL_DESC4.Location = New System.Drawing.Point(103, 91)
        Me.TxtPRICE_LEVEL_DESC4.MaxLength = 25
        Me.TxtPRICE_LEVEL_DESC4.Name = "TxtPRICE_LEVEL_DESC4"
        Me.TxtPRICE_LEVEL_DESC4.Size = New System.Drawing.Size(186, 20)
        Me.TxtPRICE_LEVEL_DESC4.TabIndex = 3
        Me.TxtPRICE_LEVEL_DESC4.Text = ""
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(3, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 21)
        Me.Label14.TabIndex = 372
        Me.Label14.Text = "Price Level 4"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPRICE_LEVEL_DESC3
        '
        Me.TxtPRICE_LEVEL_DESC3.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPRICE_LEVEL_DESC3.Location = New System.Drawing.Point(103, 64)
        Me.TxtPRICE_LEVEL_DESC3.MaxLength = 25
        Me.TxtPRICE_LEVEL_DESC3.Name = "TxtPRICE_LEVEL_DESC3"
        Me.TxtPRICE_LEVEL_DESC3.Size = New System.Drawing.Size(186, 20)
        Me.TxtPRICE_LEVEL_DESC3.TabIndex = 2
        Me.TxtPRICE_LEVEL_DESC3.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(3, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 21)
        Me.Label13.TabIndex = 370
        Me.Label13.Text = "Price Level 3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPRICE_LEVEL_DESC2
        '
        Me.TxtPRICE_LEVEL_DESC2.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPRICE_LEVEL_DESC2.Location = New System.Drawing.Point(103, 37)
        Me.TxtPRICE_LEVEL_DESC2.MaxLength = 25
        Me.TxtPRICE_LEVEL_DESC2.Name = "TxtPRICE_LEVEL_DESC2"
        Me.TxtPRICE_LEVEL_DESC2.Size = New System.Drawing.Size(186, 20)
        Me.TxtPRICE_LEVEL_DESC2.TabIndex = 1
        Me.TxtPRICE_LEVEL_DESC2.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(3, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 21)
        Me.Label11.TabIndex = 368
        Me.Label11.Text = "Price Level 2"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPRICE_LEVEL_DESC1
        '
        Me.TxtPRICE_LEVEL_DESC1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPRICE_LEVEL_DESC1.Location = New System.Drawing.Point(103, 10)
        Me.TxtPRICE_LEVEL_DESC1.MaxLength = 25
        Me.TxtPRICE_LEVEL_DESC1.Name = "TxtPRICE_LEVEL_DESC1"
        Me.TxtPRICE_LEVEL_DESC1.Size = New System.Drawing.Size(186, 20)
        Me.TxtPRICE_LEVEL_DESC1.TabIndex = 0
        Me.TxtPRICE_LEVEL_DESC1.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Price Level 1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_item_type, desc_item_type, GL_account FROM inv_tab_type_item"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAinv_tab_type_item
        '
        Me.DAinv_tab_type_item.SelectCommand = Me.SqlSelectCommand1
        Me.DAinv_tab_type_item.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_type_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item_type", "desc_item_type"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account")})})
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
        Me.LblShortName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.LblStoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblStoreName.Location = New System.Drawing.Point(110, 1)
        Me.LblStoreName.Name = "LblStoreName"
        Me.LblStoreName.Size = New System.Drawing.Size(344, 23)
        Me.LblStoreName.TabIndex = 383
        Me.LblStoreName.Text = "LblCompanyName"
        Me.LblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbStores
        '
        Me.CmbStores.DataSource = Me.DsFrmInventorySetup1.STORE_SETUP
        Me.CmbStores.DisplayMember = "STORENO"
        Me.CmbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT price_code, desc_price_code, price1_c_l_a_p, price1_operator, price1_d_per" & _
        "sent, price1_amount, price1_odd_price, price1_price_level, price2_c_l_a_p, price" & _
        "2_operator, price2_d_persent, price2_amount, price2_odd_price, price2_price_leve" & _
        "l, price3_c_l_a_p, price3_operator, price3_d_persent, price3_amount, price3_odd_" & _
        "price, price3_price_level, price4_c_l_a_p, price4_operator, price4_d_persent, pr" & _
        "ice4_amount, price4_odd_price, price4_price_level, price5_c_l_a_p, price5_operat" & _
        "or, price5_d_persent, price5_amount, price5_odd_price, price5_price_level, price" & _
        "6_c_l_a_p, price6_operator, price6_d_persent, price6_amount, price6_odd_price, p" & _
        "rice6_price_level, special_notice FROM inv_price_code"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_price_code(price_code, desc_price_code, price1_c_l_a_p, price1_op" & _
        "erator, price1_d_persent, price1_amount, price1_odd_price, price1_price_level, p" & _
        "rice2_c_l_a_p, price2_operator, price2_d_persent, price2_amount, price2_odd_pric" & _
        "e, price2_price_level, price3_c_l_a_p, price3_operator, price3_d_persent, price3" & _
        "_amount, price3_odd_price, price3_price_level, price4_c_l_a_p, price4_operator, " & _
        "price4_d_persent, price4_amount, price4_odd_price, price4_price_level, price5_c_" & _
        "l_a_p, price5_operator, price5_d_persent, price5_amount, price5_odd_price, price" & _
        "5_price_level, price6_c_l_a_p, price6_operator, price6_d_persent, price6_amount," & _
        " price6_odd_price, price6_price_level, special_notice) VALUES (@price_code, @des" & _
        "c_price_code, @price1_c_l_a_p, @price1_operator, @price1_d_persent, @price1_amou" & _
        "nt, @price1_odd_price, @price1_price_level, @price2_c_l_a_p, @price2_operator, @" & _
        "price2_d_persent, @price2_amount, @price2_odd_price, @price2_price_level, @price" & _
        "3_c_l_a_p, @price3_operator, @price3_d_persent, @price3_amount, @price3_odd_pric" & _
        "e, @price3_price_level, @price4_c_l_a_p, @price4_operator, @price4_d_persent, @p" & _
        "rice4_amount, @price4_odd_price, @price4_price_level, @price5_c_l_a_p, @price5_o" & _
        "perator, @price5_d_persent, @price5_amount, @price5_odd_price, @price5_price_lev" & _
        "el, @price6_c_l_a_p, @price6_operator, @price6_d_persent, @price6_amount, @price" & _
        "6_odd_price, @price6_price_level, @special_notice); SELECT price_code, desc_pric" & _
        "e_code, price1_c_l_a_p, price1_operator, price1_d_persent, price1_amount, price1" & _
        "_odd_price, price1_price_level, price2_c_l_a_p, price2_operator, price2_d_persen" & _
        "t, price2_amount, price2_odd_price, price2_price_level, price3_c_l_a_p, price3_o" & _
        "perator, price3_d_persent, price3_amount, price3_odd_price, price3_price_level, " & _
        "price4_c_l_a_p, price4_operator, price4_d_persent, price4_amount, price4_odd_pri" & _
        "ce, price4_price_level, price5_c_l_a_p, price5_operator, price5_d_persent, price" & _
        "5_amount, price5_odd_price, price5_price_level, price6_c_l_a_p, price6_operator," & _
        " price6_d_persent, price6_amount, price6_odd_price, price6_price_level, special_" & _
        "notice FROM inv_price_code WHERE (price_code = @price_code)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_price_code SET price_code = @price_code, desc_price_code = @desc_price" & _
        "_code, price1_c_l_a_p = @price1_c_l_a_p, price1_operator = @price1_operator, pri" & _
        "ce1_d_persent = @price1_d_persent, price1_amount = @price1_amount, price1_odd_pr" & _
        "ice = @price1_odd_price, price1_price_level = @price1_price_level, price2_c_l_a_" & _
        "p = @price2_c_l_a_p, price2_operator = @price2_operator, price2_d_persent = @pri" & _
        "ce2_d_persent, price2_amount = @price2_amount, price2_odd_price = @price2_odd_pr" & _
        "ice, price2_price_level = @price2_price_level, price3_c_l_a_p = @price3_c_l_a_p," & _
        " price3_operator = @price3_operator, price3_d_persent = @price3_d_persent, price" & _
        "3_amount = @price3_amount, price3_odd_price = @price3_odd_price, price3_price_le" & _
        "vel = @price3_price_level, price4_c_l_a_p = @price4_c_l_a_p, price4_operator = @" & _
        "price4_operator, price4_d_persent = @price4_d_persent, price4_amount = @price4_a" & _
        "mount, price4_odd_price = @price4_odd_price, price4_price_level = @price4_price_" & _
        "level, price5_c_l_a_p = @price5_c_l_a_p, price5_operator = @price5_operator, pri" & _
        "ce5_d_persent = @price5_d_persent, price5_amount = @price5_amount, price5_odd_pr" & _
        "ice = @price5_odd_price, price5_price_level = @price5_price_level, price6_c_l_a_" & _
        "p = @price6_c_l_a_p, price6_operator = @price6_operator, price6_d_persent = @pri" & _
        "ce6_d_persent, price6_amount = @price6_amount, price6_odd_price = @price6_odd_pr" & _
        "ice, price6_price_level = @price6_price_level, special_notice = @special_notice " & _
        "WHERE (price_code = @Original_price_code) AND (desc_price_code = @Original_desc_" & _
        "price_code OR @Original_desc_price_code IS NULL AND desc_price_code IS NULL) AND" & _
        " (price1_amount = @Original_price1_amount OR @Original_price1_amount IS NULL AND" & _
        " price1_amount IS NULL) AND (price1_c_l_a_p = @Original_price1_c_l_a_p OR @Origi" & _
        "nal_price1_c_l_a_p IS NULL AND price1_c_l_a_p IS NULL) AND (price1_d_persent = @" & _
        "Original_price1_d_persent OR @Original_price1_d_persent IS NULL AND price1_d_per" & _
        "sent IS NULL) AND (price1_odd_price = @Original_price1_odd_price OR @Original_pr" & _
        "ice1_odd_price IS NULL AND price1_odd_price IS NULL) AND (price1_operator = @Ori" & _
        "ginal_price1_operator OR @Original_price1_operator IS NULL AND price1_operator I" & _
        "S NULL) AND (price1_price_level = @Original_price1_price_level OR @Original_pric" & _
        "e1_price_level IS NULL AND price1_price_level IS NULL) AND (price2_amount = @Ori" & _
        "ginal_price2_amount OR @Original_price2_amount IS NULL AND price2_amount IS NULL" & _
        ") AND (price2_c_l_a_p = @Original_price2_c_l_a_p OR @Original_price2_c_l_a_p IS " & _
        "NULL AND price2_c_l_a_p IS NULL) AND (price2_d_persent = @Original_price2_d_pers" & _
        "ent OR @Original_price2_d_persent IS NULL AND price2_d_persent IS NULL) AND (pri" & _
        "ce2_odd_price = @Original_price2_odd_price OR @Original_price2_odd_price IS NULL" & _
        " AND price2_odd_price IS NULL) AND (price2_operator = @Original_price2_operator " & _
        "OR @Original_price2_operator IS NULL AND price2_operator IS NULL) AND (price2_pr" & _
        "ice_level = @Original_price2_price_level OR @Original_price2_price_level IS NULL" & _
        " AND price2_price_level IS NULL) AND (price3_amount = @Original_price3_amount OR" & _
        " @Original_price3_amount IS NULL AND price3_amount IS NULL) AND (price3_c_l_a_p " & _
        "= @Original_price3_c_l_a_p OR @Original_price3_c_l_a_p IS NULL AND price3_c_l_a_" & _
        "p IS NULL) AND (price3_d_persent = @Original_price3_d_persent OR @Original_price" & _
        "3_d_persent IS NULL AND price3_d_persent IS NULL) AND (price3_odd_price = @Origi" & _
        "nal_price3_odd_price OR @Original_price3_odd_price IS NULL AND price3_odd_price " & _
        "IS NULL) AND (price3_operator = @Original_price3_operator OR @Original_price3_op" & _
        "erator IS NULL AND price3_operator IS NULL) AND (price3_price_level = @Original_" & _
        "price3_price_level OR @Original_price3_price_level IS NULL AND price3_price_leve" & _
        "l IS NULL) AND (price4_amount = @Original_price4_amount OR @Original_price4_amou" & _
        "nt IS NULL AND price4_amount IS NULL) AND (price4_c_l_a_p = @Original_price4_c_l" & _
        "_a_p OR @Original_price4_c_l_a_p IS NULL AND price4_c_l_a_p IS NULL) AND (price4" & _
        "_d_persent = @Original_price4_d_persent OR @Original_price4_d_persent IS NULL AN" & _
        "D price4_d_persent IS NULL) AND (price4_odd_price = @Original_price4_odd_price O" & _
        "R @Original_price4_odd_price IS NULL AND price4_odd_price IS NULL) AND (price4_o" & _
        "perator = @Original_price4_operator OR @Original_price4_operator IS NULL AND pri" & _
        "ce4_operator IS NULL) AND (price4_price_level = @Original_price4_price_level OR " & _
        "@Original_price4_price_level IS NULL AND price4_price_level IS NULL) AND (price5" & _
        "_amount = @Original_price5_amount OR @Original_price5_amount IS NULL AND price5_" & _
        "amount IS NULL) AND (price5_c_l_a_p = @Original_price5_c_l_a_p OR @Original_pric" & _
        "e5_c_l_a_p IS NULL AND price5_c_l_a_p IS NULL) AND (price5_d_persent = @Original" & _
        "_price5_d_persent OR @Original_price5_d_persent IS NULL AND price5_d_persent IS " & _
        "NULL) AND (price5_odd_price = @Original_price5_odd_price OR @Original_price5_odd" & _
        "_price IS NULL AND price5_odd_price IS NULL) AND (price5_operator = @Original_pr" & _
        "ice5_operator OR @Original_price5_operator IS NULL AND price5_operator IS NULL) " & _
        "AND (price5_price_level = @Original_price5_price_level OR @Original_price5_price" & _
        "_level IS NULL AND price5_price_level IS NULL) AND (price6_amount = @Original_pr" & _
        "ice6_amount OR @Original_price6_amount IS NULL AND price6_amount IS NULL) AND (p" & _
        "rice6_c_l_a_p = @Original_price6_c_l_a_p OR @Original_price6_c_l_a_p IS NULL AND" & _
        " price6_c_l_a_p IS NULL) AND (price6_d_persent = @Original_price6_d_persent OR @" & _
        "Original_price6_d_persent IS NULL AND price6_d_persent IS NULL) AND (price6_odd_" & _
        "price = @Original_price6_odd_price OR @Original_price6_odd_price IS NULL AND pri" & _
        "ce6_odd_price IS NULL) AND (price6_operator = @Original_price6_operator OR @Orig" & _
        "inal_price6_operator IS NULL AND price6_operator IS NULL) AND (price6_price_leve" & _
        "l = @Original_price6_price_level OR @Original_price6_price_level IS NULL AND pri" & _
        "ce6_price_level IS NULL) AND (special_notice = @Original_special_notice OR @Orig" & _
        "inal_special_notice IS NULL AND special_notice IS NULL); SELECT price_code, desc" & _
        "_price_code, price1_c_l_a_p, price1_operator, price1_d_persent, price1_amount, p" & _
        "rice1_odd_price, price1_price_level, price2_c_l_a_p, price2_operator, price2_d_p" & _
        "ersent, price2_amount, price2_odd_price, price2_price_level, price3_c_l_a_p, pri" & _
        "ce3_operator, price3_d_persent, price3_amount, price3_odd_price, price3_price_le" & _
        "vel, price4_c_l_a_p, price4_operator, price4_d_persent, price4_amount, price4_od" & _
        "d_price, price4_price_level, price5_c_l_a_p, price5_operator, price5_d_persent, " & _
        "price5_amount, price5_odd_price, price5_price_level, price6_c_l_a_p, price6_oper" & _
        "ator, price6_d_persent, price6_amount, price6_odd_price, price6_price_level, spe" & _
        "cial_notice FROM inv_price_code WHERE (price_code = @price_code)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_price_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_price_code WHERE (price_code = @Original_price_code) AND (desc_pr" & _
        "ice_code = @Original_desc_price_code OR @Original_desc_price_code IS NULL AND de" & _
        "sc_price_code IS NULL) AND (price1_amount = @Original_price1_amount OR @Original" & _
        "_price1_amount IS NULL AND price1_amount IS NULL) AND (price1_c_l_a_p = @Origina" & _
        "l_price1_c_l_a_p OR @Original_price1_c_l_a_p IS NULL AND price1_c_l_a_p IS NULL)" & _
        " AND (price1_d_persent = @Original_price1_d_persent OR @Original_price1_d_persen" & _
        "t IS NULL AND price1_d_persent IS NULL) AND (price1_odd_price = @Original_price1" & _
        "_odd_price OR @Original_price1_odd_price IS NULL AND price1_odd_price IS NULL) A" & _
        "ND (price1_operator = @Original_price1_operator OR @Original_price1_operator IS " & _
        "NULL AND price1_operator IS NULL) AND (price1_price_level = @Original_price1_pri" & _
        "ce_level OR @Original_price1_price_level IS NULL AND price1_price_level IS NULL)" & _
        " AND (price2_amount = @Original_price2_amount OR @Original_price2_amount IS NULL" & _
        " AND price2_amount IS NULL) AND (price2_c_l_a_p = @Original_price2_c_l_a_p OR @O" & _
        "riginal_price2_c_l_a_p IS NULL AND price2_c_l_a_p IS NULL) AND (price2_d_persent" & _
        " = @Original_price2_d_persent OR @Original_price2_d_persent IS NULL AND price2_d" & _
        "_persent IS NULL) AND (price2_odd_price = @Original_price2_odd_price OR @Origina" & _
        "l_price2_odd_price IS NULL AND price2_odd_price IS NULL) AND (price2_operator = " & _
        "@Original_price2_operator OR @Original_price2_operator IS NULL AND price2_operat" & _
        "or IS NULL) AND (price2_price_level = @Original_price2_price_level OR @Original_" & _
        "price2_price_level IS NULL AND price2_price_level IS NULL) AND (price3_amount = " & _
        "@Original_price3_amount OR @Original_price3_amount IS NULL AND price3_amount IS " & _
        "NULL) AND (price3_c_l_a_p = @Original_price3_c_l_a_p OR @Original_price3_c_l_a_p" & _
        " IS NULL AND price3_c_l_a_p IS NULL) AND (price3_d_persent = @Original_price3_d_" & _
        "persent OR @Original_price3_d_persent IS NULL AND price3_d_persent IS NULL) AND " & _
        "(price3_odd_price = @Original_price3_odd_price OR @Original_price3_odd_price IS " & _
        "NULL AND price3_odd_price IS NULL) AND (price3_operator = @Original_price3_opera" & _
        "tor OR @Original_price3_operator IS NULL AND price3_operator IS NULL) AND (price" & _
        "3_price_level = @Original_price3_price_level OR @Original_price3_price_level IS " & _
        "NULL AND price3_price_level IS NULL) AND (price4_amount = @Original_price4_amoun" & _
        "t OR @Original_price4_amount IS NULL AND price4_amount IS NULL) AND (price4_c_l_" & _
        "a_p = @Original_price4_c_l_a_p OR @Original_price4_c_l_a_p IS NULL AND price4_c_" & _
        "l_a_p IS NULL) AND (price4_d_persent = @Original_price4_d_persent OR @Original_p" & _
        "rice4_d_persent IS NULL AND price4_d_persent IS NULL) AND (price4_odd_price = @O" & _
        "riginal_price4_odd_price OR @Original_price4_odd_price IS NULL AND price4_odd_pr" & _
        "ice IS NULL) AND (price4_operator = @Original_price4_operator OR @Original_price" & _
        "4_operator IS NULL AND price4_operator IS NULL) AND (price4_price_level = @Origi" & _
        "nal_price4_price_level OR @Original_price4_price_level IS NULL AND price4_price_" & _
        "level IS NULL) AND (price5_amount = @Original_price5_amount OR @Original_price5_" & _
        "amount IS NULL AND price5_amount IS NULL) AND (price5_c_l_a_p = @Original_price5" & _
        "_c_l_a_p OR @Original_price5_c_l_a_p IS NULL AND price5_c_l_a_p IS NULL) AND (pr" & _
        "ice5_d_persent = @Original_price5_d_persent OR @Original_price5_d_persent IS NUL" & _
        "L AND price5_d_persent IS NULL) AND (price5_odd_price = @Original_price5_odd_pri" & _
        "ce OR @Original_price5_odd_price IS NULL AND price5_odd_price IS NULL) AND (pric" & _
        "e5_operator = @Original_price5_operator OR @Original_price5_operator IS NULL AND" & _
        " price5_operator IS NULL) AND (price5_price_level = @Original_price5_price_level" & _
        " OR @Original_price5_price_level IS NULL AND price5_price_level IS NULL) AND (pr" & _
        "ice6_amount = @Original_price6_amount OR @Original_price6_amount IS NULL AND pri" & _
        "ce6_amount IS NULL) AND (price6_c_l_a_p = @Original_price6_c_l_a_p OR @Original_" & _
        "price6_c_l_a_p IS NULL AND price6_c_l_a_p IS NULL) AND (price6_d_persent = @Orig" & _
        "inal_price6_d_persent OR @Original_price6_d_persent IS NULL AND price6_d_persent" & _
        " IS NULL) AND (price6_odd_price = @Original_price6_odd_price OR @Original_price6" & _
        "_odd_price IS NULL AND price6_odd_price IS NULL) AND (price6_operator = @Origina" & _
        "l_price6_operator OR @Original_price6_operator IS NULL AND price6_operator IS NU" & _
        "LL) AND (price6_price_level = @Original_price6_price_level OR @Original_price6_p" & _
        "rice_level IS NULL AND price6_price_level IS NULL) AND (special_notice = @Origin" & _
        "al_special_notice OR @Original_special_notice IS NULL AND special_notice IS NULL" & _
        ")"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_price_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_price_code
        '
        Me.DAinv_price_code.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAinv_price_code.InsertCommand = Me.SqlInsertCommand1
        Me.DAinv_price_code.SelectCommand = Me.SqlSelectCommand3
        Me.DAinv_price_code.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_price_code", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("price_code", "price_code"), New System.Data.Common.DataColumnMapping("desc_price_code", "desc_price_code"), New System.Data.Common.DataColumnMapping("price1_c_l_a_p", "price1_c_l_a_p"), New System.Data.Common.DataColumnMapping("price1_operator", "price1_operator"), New System.Data.Common.DataColumnMapping("price1_d_persent", "price1_d_persent"), New System.Data.Common.DataColumnMapping("price1_amount", "price1_amount"), New System.Data.Common.DataColumnMapping("price1_odd_price", "price1_odd_price"), New System.Data.Common.DataColumnMapping("price1_price_level", "price1_price_level"), New System.Data.Common.DataColumnMapping("price2_c_l_a_p", "price2_c_l_a_p"), New System.Data.Common.DataColumnMapping("price2_operator", "price2_operator"), New System.Data.Common.DataColumnMapping("price2_d_persent", "price2_d_persent"), New System.Data.Common.DataColumnMapping("price2_amount", "price2_amount"), New System.Data.Common.DataColumnMapping("price2_odd_price", "price2_odd_price"), New System.Data.Common.DataColumnMapping("price2_price_level", "price2_price_level"), New System.Data.Common.DataColumnMapping("price3_c_l_a_p", "price3_c_l_a_p"), New System.Data.Common.DataColumnMapping("price3_operator", "price3_operator"), New System.Data.Common.DataColumnMapping("price3_d_persent", "price3_d_persent"), New System.Data.Common.DataColumnMapping("price3_amount", "price3_amount"), New System.Data.Common.DataColumnMapping("price3_odd_price", "price3_odd_price"), New System.Data.Common.DataColumnMapping("price3_price_level", "price3_price_level"), New System.Data.Common.DataColumnMapping("price4_c_l_a_p", "price4_c_l_a_p"), New System.Data.Common.DataColumnMapping("price4_operator", "price4_operator"), New System.Data.Common.DataColumnMapping("price4_d_persent", "price4_d_persent"), New System.Data.Common.DataColumnMapping("price4_amount", "price4_amount"), New System.Data.Common.DataColumnMapping("price4_odd_price", "price4_odd_price"), New System.Data.Common.DataColumnMapping("price4_price_level", "price4_price_level"), New System.Data.Common.DataColumnMapping("price5_c_l_a_p", "price5_c_l_a_p"), New System.Data.Common.DataColumnMapping("price5_operator", "price5_operator"), New System.Data.Common.DataColumnMapping("price5_d_persent", "price5_d_persent"), New System.Data.Common.DataColumnMapping("price5_amount", "price5_amount"), New System.Data.Common.DataColumnMapping("price5_odd_price", "price5_odd_price"), New System.Data.Common.DataColumnMapping("price5_price_level", "price5_price_level"), New System.Data.Common.DataColumnMapping("price6_c_l_a_p", "price6_c_l_a_p"), New System.Data.Common.DataColumnMapping("price6_operator", "price6_operator"), New System.Data.Common.DataColumnMapping("price6_d_persent", "price6_d_persent"), New System.Data.Common.DataColumnMapping("price6_amount", "price6_amount"), New System.Data.Common.DataColumnMapping("price6_odd_price", "price6_odd_price"), New System.Data.Common.DataColumnMapping("price6_price_level", "price6_price_level"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        Me.DAinv_price_code.UpdateCommand = Me.SqlUpdateCommand1
        '
        'FrmInventorySetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(602, 341)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmInventorySetup"
        Me.Text = "Inventory Setup"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DsFrmInventorySetup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmInventorySetupScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables

        DsFrmInventorySetup1.Clear()
        If Cnn.State <> ConnectionState.Open Then
            Cnn.Open()
        End If
        DAinv_tab_type_item.Fill(DsFrmInventorySetup1, "inv_tab_type_item")
        DAinv_price_code.Fill(DsFrmInventorySetup1, "inv_price_code")

        If CnnMDB.State <> ConnectionState.Open Then
            CnnMDB.Open()
        End If
        DASTORE_SETUP.Fill(DsFrmInventorySetup1, "STORE_SETUP")

        Call SayStoreName()

        Call FillFields()

        BtnOk.Enabled = False
        BtnExit.Enabled = True
    End Sub
    Private Sub FillFields()
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveInventorySetupTable(CmbStores.SelectedValue)
        StoreNoVar = OleDbReader.Item("StoreNo")
        TxtPRICE_LEVEL_DESC1.Text = OleDbReader.Item("PRICE_LEVEL_DESC1") & ""
        TxtPRICE_LEVEL_DESC2.Text = OleDbReader.Item("PRICE_LEVEL_DESC2") & ""
        TxtPRICE_LEVEL_DESC3.Text = OleDbReader.Item("PRICE_LEVEL_DESC3") & ""
        TxtPRICE_LEVEL_DESC4.Text = OleDbReader.Item("PRICE_LEVEL_DESC4") & ""
        TxtPRICE_LEVEL_DESC5.Text = OleDbReader.Item("PRICE_LEVEL_DESC5") & ""
        TxtPRICE_LEVEL_DESC6.Text = OleDbReader.Item("PRICE_LEVEL_DESC6") & ""
        NumDEFAULT_DELIVERY.Text = OleDbReader.Item("DEFAULT_DELIVERY")
        NumDEFAULT_FRIEGHT.Text = OleDbReader.Item("DEFAULT_FRIEGHT")
        NUMRULES_MAX_STOCK.Text = OleDbReader.Item("RULES_MAX_STOCK")
        NUMRULES_MIN_STOCK.Text = OleDbReader.Item("RULES_MIN_STOCK")
        CHKRULES_ALLOW_NEGATIVE.Checked = OleDbReader.Item("RULES_ALLOW_NEGATIVE")
        CHKRULES_ALLOW_WITHOUT_COST.Checked = OleDbReader.Item("RULES_ALLOW_WITHOUT_COST")
        CHKRULES_SHOW_QUANTITY.Checked = OleDbReader.Item("RULES_SHOW_QUANTITY")
        CHKTaxable.Checked = OleDbReader.Item("Taxable")
        Try
            CmbDEFAULT_ITEM_TYPE.SelectedValue = OleDbReader.Item("DEFAULT_ITEM_TYPE")
        Catch ex As Exception
            CmbDEFAULT_ITEM_TYPE.SelectedValue = Nothing
        End Try
        Try
            CmbDEFAULT_PRICE_CODE.SelectedValue = OleDbReader.Item("DEFAULT_PRICE_CODE")
        Catch ex As Exception
            CmbDEFAULT_PRICE_CODE.SelectedValue = Nothing
        End Try
        Try
            'CmbRULES_ITEM_COST_MOTHOD.SelectedValue = OleDbReader.Item("RULES_ITEM_COST_MOTHOD")
            CmbRULES_ITEM_COST_MOTHOD.Text = "Average Cost"
        Catch ex As Exception
        End Try
        Vendor_Cod1.Text = OleDbReader.Item("DEFAULT_COD_VENDOR") & ""
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
    Private Sub TxtPRICE_LEVEL_DESC1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPRICE_LEVEL_DESC1.TextChanged, TxtPRICE_LEVEL_DESC2.TextChanged, TxtPRICE_LEVEL_DESC3.TextChanged, TxtPRICE_LEVEL_DESC4.TextChanged, TxtPRICE_LEVEL_DESC5.TextChanged, TxtPRICE_LEVEL_DESC6.TextChanged, Vendor_Cod1.TextChanged, CmbDEFAULT_ITEM_TYPE.SelectedIndexChanged, CmbDEFAULT_PRICE_CODE.SelectedIndexChanged, CmbRULES_ITEM_COST_MOTHOD.SelectedIndexChanged, CHKRULES_ALLOW_NEGATIVE.CheckedChanged, CHKRULES_ALLOW_WITHOUT_COST.CheckedChanged, CHKRULES_SHOW_QUANTITY.CheckedChanged, CHKTaxable.CheckedChanged, NumDEFAULT_DELIVERY.TextChanged, NumDEFAULT_FRIEGHT.TextChanged, NUMRULES_MAX_STOCK.TextChanged, NUMRULES_MIN_STOCK.TextChanged
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
        CmdGeneralForMDB.CommandText = "Update INVENTORY_SETUP SET PRICE_LEVEL_DESC1=" & Qt(TxtPRICE_LEVEL_DESC1.Text) & ",PRICE_LEVEL_DESC2=" & Qt(TxtPRICE_LEVEL_DESC2.Text) & ",PRICE_LEVEL_DESC3=" & Qt(TxtPRICE_LEVEL_DESC3.Text) & ",PRICE_LEVEL_DESC4=" & Qt(TxtPRICE_LEVEL_DESC4.Text) & ",PRICE_LEVEL_DESC5=" & Qt(TxtPRICE_LEVEL_DESC5.Text) & ",PRICE_LEVEL_DESC6=" & Qt(TxtPRICE_LEVEL_DESC6.Text) & ",DEFAULT_ITEM_TYPE=" & IIf(IsNothing(CmbDEFAULT_ITEM_TYPE.SelectedValue), System.DBNull.Value, Qt(CmbDEFAULT_ITEM_TYPE.SelectedValue)) & ",DEFAULT_PRICE_CODE=" & IIf(IsNothing(CmbDEFAULT_PRICE_CODE.SelectedValue), System.DBNull.Value, Qt(CmbDEFAULT_PRICE_CODE.SelectedValue)) & ",RULES_ITEM_COST_MOTHOD='1',RULES_ALLOW_NEGATIVE=" & DecodeCheckBox(CHKRULES_ALLOW_NEGATIVE.Checked) & ",RULES_ALLOW_WITHOUT_COST=" & DecodeCheckBox(CHKRULES_ALLOW_WITHOUT_COST.Checked) & ",RULES_SHOW_QUANTITY=" & DecodeCheckBox(CHKRULES_SHOW_QUANTITY.Checked) & ",Taxable=" & DecodeCheckBox(CHKTaxable.Checked) & ",DEFAULT_DELIVERY=" & NumDEFAULT_DELIVERY.Text & ",DEFAULT_FRIEGHT=" & NumDEFAULT_FRIEGHT.Text & ",RULES_MAX_STOCK=" & NUMRULES_MAX_STOCK.Text & ",RULES_MIN_STOCK=" & NUMRULES_MIN_STOCK.Text & ",DEFAULT_COD_VENDOR=" & Qt(Vendor_Cod1.Text) & " Where StoreNo=" & Qt(StoreNoVar)
        Try
            CmdGeneralForMDB.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        CmdGeneralForMDB.Connection.Close()
        Call InitSystemSetupTable()
    End Sub
    Private Sub FrmInventorySetupScreen_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
End Class
