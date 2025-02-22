Imports CommonClass
Public Class FrmCustomer_Quick_Add
    Inherits FrmBase
    Dim i As Integer
    Public Cod_customerVar As String = ""
    Dim AreaCodVar As String
    Public IsCancelForExitFlag As Boolean = False
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txtcod_customer As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Txtf_name As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Txtaddress As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtSt As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CmbSalesRep As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPriceLevel As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSalesTax As System.Windows.Forms.ComboBox
    Friend WithEvents CmbARTerms As System.Windows.Forms.ComboBox
    Friend WithEvents ChkTaxable As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkCharge As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbTerritory As System.Windows.Forms.ComboBox
    Friend WithEvents CmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSource As System.Windows.Forms.ComboBox
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_trtab_main As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_source As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_class As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_territory As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TXTL_name As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TXTCity As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TXTM_name As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents DsFrmCustomer_Quick_Add1 As DSUCCustomer
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_sales_tax As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TXTEMail As EmailAndWebAddress.EmailAddress
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents TXTDriver_Name As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents CompanyName1 As UCCompany.CompanyName
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DteCustomer_Birth_Date As CalendarCombo.CalendarCombo
    Friend WithEvents Label49 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCustomer_Quick_Add))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Txtcod_customer = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXTL_name = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChkCharge = New Janus.Windows.EditControls.UICheckBox
        Me.ChkTaxable = New Janus.Windows.EditControls.UICheckBox
        Me.CmbARTerms = New System.Windows.Forms.ComboBox
        Me.DsFrmCustomer_Quick_Add1 = New UCCustomer.DSUCCustomer
        Me.CmbSalesTax = New System.Windows.Forms.ComboBox
        Me.CmbPriceLevel = New System.Windows.Forms.ComboBox
        Me.CmbSalesRep = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmbTerritory = New System.Windows.Forms.ComboBox
        Me.CmbClass = New System.Windows.Forms.ComboBox
        Me.CmbSource = New System.Windows.Forms.ComboBox
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Txtf_name = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Txtaddress = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TXTCity = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TXTM_name = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TXTDriver_Name = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtSt = New Janus.Windows.GridEX.EditControls.EditBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_trtab_main = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_source = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_class = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_territory = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_sales_tax = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.TXTEMail = New EmailAndWebAddress.EmailAddress
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.CompanyName1 = New UCCompany.CompanyName
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DteCustomer_Birth_Date = New CalendarCombo.CalendarCombo
        Me.Label49 = New System.Windows.Forms.Label
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsFrmCustomer_Quick_Add1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(467, 45)
        Me.Panel4.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(385, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 187
        Me.PictureBox2.TabStop = False
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(69, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 10)
        Me.Label33.TabIndex = 186
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(73, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(20, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(19, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 0
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txtcod_customer)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 43)
        Me.Panel1.TabIndex = 1
        '
        'Txtcod_customer
        '
        Me.Txtcod_customer.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Txtcod_customer.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Txtcod_customer.Enabled = False
        Me.Txtcod_customer.Location = New System.Drawing.Point(64, 11)
        Me.Txtcod_customer.MaxLength = 10
        Me.Txtcod_customer.Name = "Txtcod_customer"
        Me.Txtcod_customer.Size = New System.Drawing.Size(129, 20)
        Me.Txtcod_customer.TabIndex = 0
        Me.Txtcod_customer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 22)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Customer"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "First Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTL_name
        '
        Me.TXTL_name.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTL_name.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTL_name.Enabled = False
        Me.TXTL_name.Location = New System.Drawing.Point(327, 95)
        Me.TXTL_name.MaxLength = 50
        Me.TXTL_name.Name = "TXTL_name"
        Me.TXTL_name.Size = New System.Drawing.Size(137, 20)
        Me.TXTL_name.TabIndex = 4
        Me.TXTL_name.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(10, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Company"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(10, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(-4, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "City , St. , Zip"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(289, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 22)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Driver"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(288, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Email"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(286, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 21)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Phone"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Location = New System.Drawing.Point(294, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 21)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Last"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(191, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 21)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "M.I."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ChkCharge)
        Me.GroupBox1.Controls.Add(Me.ChkTaxable)
        Me.GroupBox1.Controls.Add(Me.CmbARTerms)
        Me.GroupBox1.Controls.Add(Me.CmbSalesTax)
        Me.GroupBox1.Controls.Add(Me.CmbPriceLevel)
        Me.GroupBox1.Controls.Add(Me.CmbSalesRep)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 111)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'ChkCharge
        '
        Me.ChkCharge.BackColor = System.Drawing.Color.Transparent
        Me.ChkCharge.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkCharge.Location = New System.Drawing.Point(196, 84)
        Me.ChkCharge.Name = "ChkCharge"
        Me.ChkCharge.Size = New System.Drawing.Size(64, 19)
        Me.ChkCharge.TabIndex = 5
        Me.ChkCharge.Text = "Charge"
        '
        'ChkTaxable
        '
        Me.ChkTaxable.BackColor = System.Drawing.Color.Transparent
        Me.ChkTaxable.Checked = True
        Me.ChkTaxable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTaxable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkTaxable.Location = New System.Drawing.Point(196, 61)
        Me.ChkTaxable.Name = "ChkTaxable"
        Me.ChkTaxable.Size = New System.Drawing.Size(64, 19)
        Me.ChkTaxable.TabIndex = 4
        Me.ChkTaxable.Text = "Taxable"
        '
        'CmbARTerms
        '
        Me.CmbARTerms.DataSource = Me.DsFrmCustomer_Quick_Add1.GL_TAB_AR_TERM
        Me.CmbARTerms.DisplayMember = "AR_terms"
        Me.CmbARTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbARTerms.Enabled = False
        Me.CmbARTerms.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbARTerms.ItemHeight = 13
        Me.CmbARTerms.Location = New System.Drawing.Point(65, 82)
        Me.CmbARTerms.Name = "CmbARTerms"
        Me.CmbARTerms.Size = New System.Drawing.Size(127, 21)
        Me.CmbARTerms.TabIndex = 3
        Me.CmbARTerms.ValueMember = "AR_terms"
        '
        'DsFrmCustomer_Quick_Add1
        '
        Me.DsFrmCustomer_Quick_Add1.DataSetName = "DSFrmCustomer_Quick_Add"
        Me.DsFrmCustomer_Quick_Add1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbSalesTax
        '
        Me.CmbSalesTax.DataSource = Me.DsFrmCustomer_Quick_Add1.cust_sales_tax
        Me.CmbSalesTax.DisplayMember = "desc_sales_tax"
        Me.CmbSalesTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSalesTax.Enabled = False
        Me.CmbSalesTax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbSalesTax.ItemHeight = 13
        Me.CmbSalesTax.Location = New System.Drawing.Point(65, 60)
        Me.CmbSalesTax.Name = "CmbSalesTax"
        Me.CmbSalesTax.Size = New System.Drawing.Size(127, 21)
        Me.CmbSalesTax.TabIndex = 2
        Me.CmbSalesTax.ValueMember = "cod_sales_tax"
        '
        'CmbPriceLevel
        '
        Me.CmbPriceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPriceLevel.Enabled = False
        Me.CmbPriceLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbPriceLevel.ItemHeight = 13
        Me.CmbPriceLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.CmbPriceLevel.Location = New System.Drawing.Point(65, 39)
        Me.CmbPriceLevel.Name = "CmbPriceLevel"
        Me.CmbPriceLevel.Size = New System.Drawing.Size(47, 21)
        Me.CmbPriceLevel.TabIndex = 1
        '
        'CmbSalesRep
        '
        Me.CmbSalesRep.DataSource = Me.DsFrmCustomer_Quick_Add1.employee
        Me.CmbSalesRep.DisplayMember = "employee_name"
        Me.CmbSalesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSalesRep.Enabled = False
        Me.CmbSalesRep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbSalesRep.ItemHeight = 13
        Me.CmbSalesRep.Location = New System.Drawing.Point(65, 18)
        Me.CmbSalesRep.Name = "CmbSalesRep"
        Me.CmbSalesRep.Size = New System.Drawing.Size(189, 21)
        Me.CmbSalesRep.TabIndex = 0
        Me.CmbSalesRep.ValueMember = "employee_code"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(1, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 21)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Price Level"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(0, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 22)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Sales Tax"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(0, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "AR Terms"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(-1, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Sales Rep"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CmbTerritory)
        Me.GroupBox2.Controls.Add(Me.CmbClass)
        Me.GroupBox2.Controls.Add(Me.CmbSource)
        Me.GroupBox2.Controls.Add(Me.CmbType)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 111)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'CmbTerritory
        '
        Me.CmbTerritory.DataSource = Me.DsFrmCustomer_Quick_Add1.cust_tab_territory
        Me.CmbTerritory.DisplayMember = "desc_territory"
        Me.CmbTerritory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTerritory.Enabled = False
        Me.CmbTerritory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbTerritory.ItemHeight = 13
        Me.CmbTerritory.Location = New System.Drawing.Point(60, 82)
        Me.CmbTerritory.Name = "CmbTerritory"
        Me.CmbTerritory.Size = New System.Drawing.Size(127, 21)
        Me.CmbTerritory.TabIndex = 3
        Me.CmbTerritory.ValueMember = "cod_territory"
        '
        'CmbClass
        '
        Me.CmbClass.DataSource = Me.DsFrmCustomer_Quick_Add1.cust_tab_class
        Me.CmbClass.DisplayMember = "desc_class"
        Me.CmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClass.Enabled = False
        Me.CmbClass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbClass.ItemHeight = 13
        Me.CmbClass.Location = New System.Drawing.Point(60, 60)
        Me.CmbClass.Name = "CmbClass"
        Me.CmbClass.Size = New System.Drawing.Size(127, 21)
        Me.CmbClass.TabIndex = 2
        Me.CmbClass.ValueMember = "cod_class"
        '
        'CmbSource
        '
        Me.CmbSource.DataSource = Me.DsFrmCustomer_Quick_Add1.cust_tab_source
        Me.CmbSource.DisplayMember = "desc_source"
        Me.CmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSource.Enabled = False
        Me.CmbSource.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbSource.ItemHeight = 13
        Me.CmbSource.Location = New System.Drawing.Point(60, 39)
        Me.CmbSource.Name = "CmbSource"
        Me.CmbSource.Size = New System.Drawing.Size(127, 21)
        Me.CmbSource.TabIndex = 1
        Me.CmbSource.ValueMember = "cod_source"
        '
        'CmbType
        '
        Me.CmbType.DataSource = Me.DsFrmCustomer_Quick_Add1.cust_tab_type
        Me.CmbType.DisplayMember = "desc_type"
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.Enabled = False
        Me.CmbType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbType.ItemHeight = 13
        Me.CmbType.Location = New System.Drawing.Point(60, 18)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(127, 21)
        Me.CmbType.TabIndex = 0
        Me.CmbType.ValueMember = "cod_type"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Location = New System.Drawing.Point(-7, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 21)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Source"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Location = New System.Drawing.Point(-7, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 22)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Class"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Location = New System.Drawing.Point(-6, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 21)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Territory"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Location = New System.Drawing.Point(-7, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 21)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Type"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtf_name
        '
        Me.Txtf_name.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Txtf_name.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Txtf_name.Enabled = False
        Me.Txtf_name.Location = New System.Drawing.Point(77, 95)
        Me.Txtf_name.MaxLength = 20
        Me.Txtf_name.Name = "Txtf_name"
        Me.Txtf_name.Size = New System.Drawing.Size(114, 20)
        Me.Txtf_name.TabIndex = 2
        Me.Txtf_name.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Txtaddress
        '
        Me.Txtaddress.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Txtaddress.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Txtaddress.Enabled = False
        Me.Txtaddress.Location = New System.Drawing.Point(77, 150)
        Me.Txtaddress.MaxLength = 100
        Me.Txtaddress.Name = "Txtaddress"
        Me.Txtaddress.Size = New System.Drawing.Size(387, 20)
        Me.Txtaddress.TabIndex = 7
        Me.Txtaddress.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TXTCity
        '
        Me.TXTCity.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTCity.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTCity.Location = New System.Drawing.Point(77, 175)
        Me.TXTCity.MaxLength = 50
        Me.TXTCity.Name = "TXTCity"
        Me.TXTCity.ReadOnly = True
        Me.TXTCity.Size = New System.Drawing.Size(106, 20)
        Me.TXTCity.TabIndex = 8
        Me.TXTCity.TabStop = False
        Me.TXTCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TXTM_name
        '
        Me.TXTM_name.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTM_name.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTM_name.Enabled = False
        Me.TXTM_name.Location = New System.Drawing.Point(219, 96)
        Me.TXTM_name.MaxLength = 15
        Me.TXTM_name.Name = "TXTM_name"
        Me.TXTM_name.Size = New System.Drawing.Size(72, 20)
        Me.TXTM_name.TabIndex = 3
        Me.TXTM_name.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TXTDriver_Name
        '
        Me.TXTDriver_Name.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTDriver_Name.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTDriver_Name.Enabled = False
        Me.TXTDriver_Name.Location = New System.Drawing.Point(327, 202)
        Me.TXTDriver_Name.MaxLength = 25
        Me.TXTDriver_Name.Name = "TXTDriver_Name"
        Me.TXTDriver_Name.Size = New System.Drawing.Size(136, 20)
        Me.TXTDriver_Name.TabIndex = 13
        Me.TXTDriver_Name.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtSt
        '
        Me.TxtSt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSt.Location = New System.Drawing.Point(182, 175)
        Me.TxtSt.MaxLength = 20
        Me.TxtSt.Name = "TxtSt"
        Me.TxtSt.ReadOnly = True
        Me.TxtSt.Size = New System.Drawing.Size(40, 20)
        Me.TxtSt.TabIndex = 11
        Me.TxtSt.TabStop = False
        Me.TxtSt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.*, cust_company.complete_name FROM cust_trtab_main INNER J" & _
        "OIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHERE" & _
        " (cust_trtab_main.cod_customer = @cod_customer)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAcust_trtab_main
        '
        Me.DAcust_trtab_main.SelectCommand = Me.SqlSelectCommand1
        Me.DAcust_trtab_main.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_main", "phone_main"), New System.Data.Common.DataColumnMapping("phone_work", "phone_work"), New System.Data.Common.DataColumnMapping("phone_cell", "phone_cell"), New System.Data.Common.DataColumnMapping("phone_other", "phone_other"), New System.Data.Common.DataColumnMapping("cod_city", "cod_city"), New System.Data.Common.DataColumnMapping("st", "st"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_type, desc_type FROM cust_tab_type"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAcust_tab_type
        '
        Me.DAcust_tab_type.SelectCommand = Me.SqlSelectCommand2
        Me.DAcust_tab_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("desc_type", "desc_type")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_source, desc_source FROM cust_tab_source"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAcust_tab_source
        '
        Me.DAcust_tab_source.SelectCommand = Me.SqlSelectCommand3
        Me.DAcust_tab_source.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_source", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("desc_source", "desc_source")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_class, desc_class FROM cust_tab_class"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAcust_tab_class
        '
        Me.DAcust_tab_class.SelectCommand = Me.SqlSelectCommand5
        Me.DAcust_tab_class.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_territory, desc_territory FROM cust_tab_territory"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DAcust_tab_territory
        '
        Me.DAcust_tab_territory.SelectCommand = Me.SqlSelectCommand6
        Me.DAcust_tab_territory.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_territory", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_territory", "desc_territory")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_sales_tax, desc_sales_tax FROM cust_sales_tax"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAcust_sales_tax
        '
        Me.DAcust_sales_tax.SelectCommand = Me.SqlSelectCommand4
        Me.DAcust_sales_tax.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_sales_tax", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("desc_sales_tax", "desc_sales_tax")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT employee_code, f_name + ' ' + m_name + ' ' + l_name AS employee_name FROM " & _
        "employee"
        Me.SqlSelectCommand9.Connection = Me.Cnn
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand9
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_main", "phone_main"), New System.Data.Common.DataColumnMapping("phone_work", "phone_work"), New System.Data.Common.DataColumnMapping("phone_cell", "phone_cell"), New System.Data.Common.DataColumnMapping("phome_other", "phome_other"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("deduction_cod1", "deduction_cod1"), New System.Data.Common.DataColumnMapping("deduction_amount1", "deduction_amount1"), New System.Data.Common.DataColumnMapping("deduction_cod2", "deduction_cod2"), New System.Data.Common.DataColumnMapping("deduction_amount2", "deduction_amount2"), New System.Data.Common.DataColumnMapping("deduction_cod3", "deduction_cod3"), New System.Data.Common.DataColumnMapping("deduction_amount3", "deduction_amount3"), New System.Data.Common.DataColumnMapping("deduction_cod4", "deduction_cod4"), New System.Data.Common.DataColumnMapping("deduction_amount4", "deduction_amount4"), New System.Data.Common.DataColumnMapping("deduction_cod5", "deduction_cod5"), New System.Data.Common.DataColumnMapping("deduction_amount5", "deduction_amount5"), New System.Data.Common.DataColumnMapping("deduction_cod6", "deduction_cod6"), New System.Data.Common.DataColumnMapping("deduction_amount6", "deduction_amount6")})})
        '
        'TXTEMail
        '
        Me.TXTEMail.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTEMail.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTEMail.ErrorColor = System.Drawing.Color.Red
        Me.TXTEMail.ErrorMessage = "abc@microsoft.com ÂÏÑÓ ÓÊ Çá˜ÊÑæäí˜í ÈÇíÓÊí Èå Çíä ÕæÑÊ ÈÇÔÏ"
        Me.TXTEMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TXTEMail.Location = New System.Drawing.Point(327, 174)
        Me.TXTEMail.MaxLength = 30
        Me.TXTEMail.Name = "TXTEMail"
        Me.TXTEMail.Size = New System.Drawing.Size(136, 21)
        Me.TXTEMail.TabIndex = 9
        Me.TXTEMail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TXTEMail.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0" & _
        "-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-" & _
        "9][0-9]|[1-9][0-9]|[0-9])\])$"
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Location = New System.Drawing.Point(221, 175)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(59, 20)
        Me.ZipCode1.TabIndex = 12
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'CompanyName1
        '
        Me.CompanyName1.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D
        Me.CompanyName1.CompanyCod = ""
        Me.CompanyName1.CompanyCodForFind = ""
        Me.CompanyName1.CompanyComplete_Name = ""
        Me.CompanyName1.Connection = Me.Cnn
        Me.CompanyName1.Location = New System.Drawing.Point(76, 123)
        Me.CompanyName1.Name = "CompanyName1"
        Me.CompanyName1.NotExitIfNotFound = False
        Me.CompanyName1.ReleaseIfNotFoundCompanyName = False
        Me.CompanyName1.Size = New System.Drawing.Size(211, 21)
        Me.CompanyName1.TabIndex = 5
        '
        'PhoneNo1
        '
        Me.PhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNo1.Location = New System.Drawing.Point(327, 123)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(94, 21)
        Me.PhoneNo1.TabIndex = 6
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAGL_TAB_AR_TERM.InsertCommand = Me.SqlInsertCommand2
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlCommand1
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        Me.DAGL_TAB_AR_TERM.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM GL_TAB_AR_TERM WHERE (AR_terms = @Original_AR_terms) AND (DD_DISCOUNT" & _
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
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO GL_TAB_AR_TERM(AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTA" & _
        "GE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCO" & _
        "UNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY) VALUES (" & _
        "@AR_terms, @KIND_AR, @ST_NET_DUE_IN, @ST_DISCOUNT_PERCENTAGE, @ST_IF_PAY_WITHIN_" & _
        "DAYS, @DD_NET_DUE_BEFORE, @DD_IF_ISSUED_WITHIN_DAYS, @DD_DISCOUNT_PERCENTAGE, @D" & _
        "D_IF_PAY_WITHIN_DAYS, @MP_NO_OF_PAYMENT, @MP_BEFORE_DAY); SELECT AR_terms, KIND_" & _
        "AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEF" & _
        "ORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP" & _
        "_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms = @AR_terms)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN" & _
        "_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_I" & _
        "F_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE GL_TAB_AR_TERM SET AR_terms = @AR_terms, KIND_AR = @KIND_AR, ST_NET_DUE_IN" & _
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
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'DteCustomer_Birth_Date
        '
        Me.DteCustomer_Birth_Date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteCustomer_Birth_Date.BorderColor = System.Drawing.Color.Empty
        Me.DteCustomer_Birth_Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteCustomer_Birth_Date.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteCustomer_Birth_Date.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteCustomer_Birth_Date.EditableSal = True
        Me.DteCustomer_Birth_Date.Image = CType(resources.GetObject("DteCustomer_Birth_Date.Image"), System.Drawing.Image)
        Me.DteCustomer_Birth_Date.Location = New System.Drawing.Point(77, 200)
        Me.DteCustomer_Birth_Date.MaxValue = CType(2500, Short)
        Me.DteCustomer_Birth_Date.MinValue = CType(1800, Short)
        Me.DteCustomer_Birth_Date.Name = "DteCustomer_Birth_Date"
        Me.DteCustomer_Birth_Date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteCustomer_Birth_Date.Sal_Mali = Nothing
        Me.DteCustomer_Birth_Date.ShowButton = True
        Me.DteCustomer_Birth_Date.Size = New System.Drawing.Size(102, 23)
        Me.DteCustomer_Birth_Date.TabIndex = 10
        Me.DteCustomer_Birth_Date.VisualStyle = False
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(-17, 200)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 21)
        Me.Label49.TabIndex = 452
        Me.Label49.Text = "Birth Date"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCustomer_Quick_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(467, 337)
        Me.Controls.Add(Me.DteCustomer_Birth_Date)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.PhoneNo1)
        Me.Controls.Add(Me.CompanyName1)
        Me.Controls.Add(Me.ZipCode1)
        Me.Controls.Add(Me.TXTEMail)
        Me.Controls.Add(Me.TxtSt)
        Me.Controls.Add(Me.TXTDriver_Name)
        Me.Controls.Add(Me.TXTM_name)
        Me.Controls.Add(Me.TXTCity)
        Me.Controls.Add(Me.Txtaddress)
        Me.Controls.Add(Me.Txtf_name)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTL_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmCustomer_Quick_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Customer Quick Add"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsFrmCustomer_Quick_Add1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCustomer_Quick_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Cnn.State = ConnectionState.Closed Then
            Cnn.ConnectionString = PConnectionString
        End If
        Call FillDataAdabtors()
        Call EnableDisableField(True)
        Call ClearAllField()
        ThisFormStatus = MainModule.WorkStates.AddNew
        If Cod_customerVar.Trim.Length > 0 Then
            Txtcod_customer.Text = Cod_customerVar
        Else
            Txtcod_customer.Text = MakeNewcod_customer()
        End If

        Call SetDefaults()

        Txtf_name.Focus()
    End Sub
    Public Function MakeNewcod_customer() As String
        Dim i As Integer
        Dim ValMakeNewcod_customer As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_customer) as Max_cod from cust_trtab_main where substring(cod_customer,1,1)='C' AND substring(cod_customer,2,1) IN ('0','1','2','3','4','5','6','7','8','9') "
            MakeNewcod_customer = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod_customer = GetVal(MakeNewcod_customer, LenCustomerCod)
            If Val(ValMakeNewcod_customer) > 0 Then
                i = Len(ValMakeNewcod_customer)
            Else
                i = 0
            End If
            If MakeNewcod_customer.Length > i Then
                MakeNewcod_customer = Mid(MakeNewcod_customer, 1, Len(MakeNewcod_customer) - i) + Getcod(Str((Int(Val(ValMakeNewcod_customer)) + 1)).Trim, Len(ValMakeNewcod_customer))
            End If
            If MakeNewcod_customer.Trim.Length > LenCustomerCod Then
                MakeNewcod_customer = "C000001"
            End If
        Catch ex As Exception
            MakeNewcod_customer = "C000001"
        Finally
            'CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Function MakeNewcod_company() As String
        Dim i As Integer
        Dim ValMakeNewcod_company As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_company) as Max_cod_company from cust_company  where substring(cod_company,1,1)='C'"
            MakeNewcod_company = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod_company = GetVal(MakeNewcod_company, LenCompanyCod)
            If ValMakeNewcod_company > 0 Then
                i = Len(ValMakeNewcod_company)
            Else
                i = 0
            End If
            If MakeNewcod_company.Length >= i Then
                MakeNewcod_company = Mid(MakeNewcod_company, 1, Len(MakeNewcod_company) - i) + Getcod(Str((Int(Val(ValMakeNewcod_company)) + 1)).Trim, Len(ValMakeNewcod_company))
            End If
            If MakeNewcod_company.Trim.Length > LenCompanyCod Then
                MakeNewcod_company = "C0001"
            End If
        Catch ex As Exception
            MakeNewcod_company = "C0001"
        Finally
            'CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Sub FillDataAdabtors()
        DsFrmCustomer_Quick_Add1.cust_sales_tax.Clear()
        DAcust_sales_tax.Fill(DsFrmCustomer_Quick_Add1.cust_sales_tax)

        DsFrmCustomer_Quick_Add1.GL_TAB_AR_TERM.Clear()
        DAGL_TAB_AR_TERM.Fill(DsFrmCustomer_Quick_Add1.GL_TAB_AR_TERM)

        DsFrmCustomer_Quick_Add1.cust_tab_class.Clear()
        DAcust_tab_class.Fill(DsFrmCustomer_Quick_Add1.cust_tab_class)

        DsFrmCustomer_Quick_Add1.cust_tab_source.Clear()
        DAcust_tab_source.Fill(DsFrmCustomer_Quick_Add1.cust_tab_source)

        DsFrmCustomer_Quick_Add1.cust_tab_territory.Clear()
        DAcust_tab_territory.Fill(DsFrmCustomer_Quick_Add1.cust_tab_territory)

        DsFrmCustomer_Quick_Add1.cust_tab_type.Clear()
        DAcust_tab_type.Fill(DsFrmCustomer_Quick_Add1.cust_tab_type)

        DsFrmCustomer_Quick_Add1.employee.Clear()
        DAEmployee.Fill(DsFrmCustomer_Quick_Add1.employee)

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call psave()
    End Sub
    Private Function CheckIsExist() As Boolean
        CheckIsExist = False
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select count(*) as countVar from cust_trtab_main where cod_customer=" & Qt(Txtcod_customer.Text)
        If CmdGeneral.ExecuteScalar = 1 Then
            CheckIsExist = True
            MsgFar("This Code is duplicate")
        End If
    End Function
    Private Sub psave(Optional ByVal ThisChangeStatus As Boolean = True)
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            If CheckIsExist() Then
                Exit Sub
            End If
            Try
                Call AddNewCompany()
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Insert Into cust_trtab_main (cod_customer,address,cod_company,Driver_Name1,email,f_name,l_name,m_name,phone_1,phone_main_1,phone_type_1,AR_Term,cod_class,cod_price,cod_sales_tax,cod_source,cod_territory,cod_type,AR_charge,Taxable,zip,AR_accept_check,AR_statement,AR_finance_charge,PrintstatementDetailFlag,Customer_Birth_Date) Values(" & Qt(Txtcod_customer.Text) & "," & Qt(Txtaddress.Text) & "," & IIf(Trim(CompanyName1.CompanyCod).Length = 0, "Null", Qt(CompanyName1.CompanyCod)) & "," & Qt(TXTDriver_Name.Text) & "," & Qt(TXTEMail.Text) & "," & Qt(Txtf_name.Text) & "," & Qt(TXTL_name.Text) & "," & Qt(TXTM_name.Text) & "," & Qt(PhoneNo1.Text) & ",1,0," & IIf(ChkCharge.Checked, Qt(CmbARTerms.SelectedValue), "NULL") & "," & Qt(CmbClass.SelectedValue) & "," & Qt(CmbPriceLevel.Text) & "," & IIf(ChkTaxable.Checked, Qt(CmbSalesTax.SelectedValue), "NULL") & "," & Qt(CmbSource.SelectedValue) & "," & Qt(CmbTerritory.SelectedValue) & "," & Qt(CmbType.SelectedValue) & "," & IIf(ChkCharge.Checked, 1, 0) & "," & IIf(ChkTaxable.Checked, 1, 0) & "," & IIf(ZipCode1.Text.Trim.Length > 0, Qt(ZipCode1.Text), "NULL") & ",1," & IIf(ChkCharge.Checked, 1, 0) & "," & IIf(ChkCharge.Checked, 1, 0) & ",1," & Qt(DteCustomer_Birth_Date.Text) & ")"
                CmdGeneral.ExecuteNonQuery()

                BtnSave.Enabled = False
                Cod_customerVar = Txtcod_customer.Text
                Me.Close()
            Catch ex As Exception
                MsgFar("Cannot Save This Customer Code")
            Finally
                'CmdGeneral.Connection.Close()
            End Try
        End If
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmCustomer_Quick_Add1.cust_trtab_main
            If .Rows.Count > 0 Then
                CmbARTerms.SelectedValue = IIf(IsDBNull(.Rows(0).Item("AR_term")), vbNullString, .Rows(0).Item("AR_term"))
                CmbClass.SelectedValue = .Rows(0).Item("cod_class") & ""
                CmbPriceLevel.Text = .Rows(0).Item("cod_price") & ""
                CmbSalesRep.SelectedValue = .Rows(0).Item("Cod_Sales_Rep") & ""
                CmbSalesTax.SelectedValue = IIf(IsDBNull(.Rows(0).Item("cod_sales_tax")), vbNullString, .Rows(0).Item("cod_sales_tax"))
                CmbSource.SelectedValue = .Rows(0).Item("cod_source") & ""
                CmbTerritory.SelectedValue = .Rows(0).Item("cod_territory") & ""
                CmbType.SelectedValue = .Rows(0).Item("cod_type") & ""
                Txtaddress.Text = .Rows(0).Item("address") & ""
                DteCustomer_Birth_Date.Text = .Rows(0).Item("Customer_Birth_Date") & ""
                CompanyName1.CompanyCodForFind = .Rows(0).Item("cod_company") & ""
                TXTDriver_Name.Text = .Rows(0).Item("Driver_Name") & ""
                TXTEMail.Text = .Rows(0).Item("EMail") & ""
                Txtf_name.Text = .Rows(0).Item("f_name") & ""
                TXTL_name.Text = .Rows(0).Item("L_name") & ""
                TXTM_name.Text = .Rows(0).Item("M_name") & ""
                PhoneNo1.Text = .Rows(0).Item("phone_1") & ""
                ZipCode1.Text = .Rows(0).Item("zip") & ""
                ChkCharge.Checked = .Rows(0).Item("AR_charge") & ""
                ChkTaxable.Checked = IIf(CmbSalesTax.SelectedValue >= 0, True, False)
            End If
        End With
    End Sub
    Private Sub ClearAllField()
        Txtaddress.Clear()
        TXTCity.Clear()
        CompanyName1.CompanyComplete_Name = ""
        TXTDriver_Name.Clear()
        TXTEMail.Clear()
        Txtf_name.Clear()
        TXTL_name.Clear()
        TXTM_name.Clear()
        PhoneNo1.Text = ""
        TxtSt.Clear()
        ZipCode1.Text = ""
    End Sub
    Private Sub SetDefaults()
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        Try
            AreaCodVar = OleDbReaderForStore.Item("AREACODE") & ""
        Catch ex As Exception
            AreaCodVar = ""
        End Try
        Try
            CmbSalesTax.SelectedValue = OleDbReaderForStore.Item("SALES_TAX") & ""
        Catch ex As Exception
        End Try
        Try
            CmbSalesRep.SelectedValue = OleDbReaderForStore.Item("SALESPERSON")
        Catch ex As Exception
        End Try
        OleDbReaderForStore.Close()

        Dim OleDbReaderForServiceSetup As System.Data.OleDb.OleDbDataReader
        OleDbReaderForServiceSetup = RetrieveServiceSetupTable(PubStoreNO)
        Try
            CmbType.SelectedValue = OleDbReaderForServiceSetup.Item("CUSTOMER_TYPE") & ""
        Catch ex As Exception
        End Try
        If CmbType.Text.Trim.Length = 0 Then
            CmbType.SelectedValue = 0
        End If

        Try
            CmbSource.SelectedValue = OleDbReaderForServiceSetup.Item("CUSTOMER_SOURCE") & ""
        Catch ex As Exception
        End Try
        If CmbSource.Text.Trim.Length = 0 Then
            CmbSource.SelectedValue = 0
        End If

        Try
            CmbClass.SelectedValue = OleDbReaderForServiceSetup.Item("CUSTOMER_CLASS") & ""
        Catch ex As Exception
        End Try
        If CmbClass.Text.Trim.Length = 0 Then
            CmbClass.SelectedValue = 0
        End If

        Try
            CmbTerritory.SelectedValue = OleDbReaderForServiceSetup.Item("CUSTOMER_TERRITORY") & ""
        Catch ex As Exception
        End Try
        If CmbTerritory.Text.Trim.Length = 0 Then
            CmbTerritory.SelectedValue = 0
        End If

        Try
            CmbPriceLevel.Text = OleDbReaderForServiceSetup.Item("CUSTOMER_PRICE_LEVEL") & ""  ' 1
        Catch ex As Exception
            CmbPriceLevel.Text = 1
        End Try
        Try
            ChkTaxable.Checked = OleDbReaderForServiceSetup.Item("CUSTOMER_TAXABLE") ' True
        Catch ex As Exception
            ChkTaxable.Checked = True
        End Try
        Try
            ChkCharge.Checked = OleDbReaderForServiceSetup.Item("CUSTOMER_CHARGE") ' True
        Catch ex As Exception
            ChkCharge.Checked = True
        End Try
        OleDbReaderForServiceSetup.Close()

        Dim OleDbReaderForAccountsReceivable As System.Data.OleDb.OleDbDataReader
        OleDbReaderForAccountsReceivable = RetrieveAccountsReceivableSetupTable()
        Try
            CmbARTerms.SelectedValue = OleDbReaderForAccountsReceivable.Item("Default_AR_terms")
        Catch ex As Exception
            CmbARTerms.Text = ""
        End Try
        OleDbReaderForAccountsReceivable.Close()
    End Sub
    Private Sub EnableDisableSave()

        'And CmbClass.Text.Trim.Length > 0 _
        'And CmbPriceLevel.Text.Trim.Length > 0 _
        'And CmbSalesRep.Text.Trim.Length > 0 _
        'And CmbSource.Text.Trim.Length > 0 _
        'And CmbTerritory.Text.Trim.Length > 0 _
        'And CmbType.Text.Trim.Length > 0 _

        If ThisFormStatus <> MainModule.WorkStates._ReadOnly _
           And Txtcod_customer.Text.Trim.Length > 0 _
           And (CmbSalesTax.Text.Trim.Length > 0 Or Not ChkTaxable.Checked) _
           And (CmbARTerms.Text.Trim.Length > 0 Or Not ChkCharge.Checked) _
           And ((Txtf_name.Text.Trim.Length > 0 And TXTL_name.Text.Trim.Length > 0) Or (CompanyName1.Text.Trim.Length > 0)) _
            Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            Txtcod_customer.Enabled = False
        Else
            Txtcod_customer.Enabled = InStatus
        End If
        CmbARTerms.Enabled = InStatus
        CmbClass.Enabled = InStatus
        CmbPriceLevel.Enabled = InStatus
        CmbSalesRep.Enabled = InStatus
        CmbSource.Enabled = InStatus
        CmbTerritory.Enabled = InStatus
        CmbType.Enabled = InStatus
        Txtaddress.Enabled = InStatus
        DteCustomer_Birth_Date.Enabled = InStatus
        CompanyName1.Enabled = InStatus
        TXTDriver_Name.Enabled = InStatus
        TXTEMail.Enabled = InStatus
        Txtf_name.Enabled = InStatus
        TXTL_name.Enabled = InStatus
        TXTM_name.Enabled = InStatus
        PhoneNo1.Enabled = InStatus
        ZipCode1.Enabled = InStatus
        ChkCharge.Enabled = InStatus
        ChkTaxable.Enabled = InStatus
        Call CheckTaxEnable()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If IsCancelForExitFlag Then
            'Cod_customerVar = Txtcod_customer.Text
            Cod_customerVar = ""
            Me.Close()
        End If
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        BtnSave.Enabled = False
    End Sub
    Private Sub Txtcod_customer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcod_customer.TextChanged, Txtaddress.TextChanged, TXTDriver_Name.TextChanged, TXTEMail.BackColorChanged, Txtf_name.TextChanged, TXTL_name.TextChanged, TXTM_name.TextChanged, ZipCode1.TextChanged, CmbARTerms.SelectedIndexChanged, CmbClass.SelectedIndexChanged, CmbPriceLevel.SelectedIndexChanged, CmbSalesRep.SelectedIndexChanged, CmbSalesTax.SelectedIndexChanged, CmbSource.SelectedIndexChanged, CmbTerritory.SelectedIndexChanged, CmbType.SelectedIndexChanged, ChkCharge.CheckedChanged, PhoneNo1.TextChanged, DteCustomer_Birth_Date.Leave
        Call EnableDisableSave()
    End Sub
    Private Sub ChkTaxable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTaxable.CheckedChanged
        Call EnableDisableSave()
        CheckTaxEnable()
    End Sub
    Private Sub CheckTaxEnable()
        If ChkTaxable.Checked Then
            CmbSalesTax.Enabled = ChkTaxable.Enabled
        Else
            CmbSalesTax.Enabled = False
        End If
    End Sub
    Private Sub LoadAWotkOrder(ByVal ThisCod_customer As String)
        DsFrmCustomer_Quick_Add1.cust_trtab_main.Clear()
        DAcust_trtab_main.SelectCommand.Parameters("@Cod_customer").Value = ThisCod_customer
        DAcust_trtab_main.Fill(DsFrmCustomer_Quick_Add1.cust_trtab_main)
        Call ClearAllField()
        Call FillDataInScreen()
    End Sub
    Private Sub Txtcod_customer_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txtcod_customer.Validating
        If CheckIsExist() Then
            Txtcod_customer.Clear()
            e.Cancel = True
        End If
    End Sub
    Private Sub FrmCustomer_Quick_Add_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If BtnSave.Enabled Then
            MsgFar("Please Save OR Cancel The Information")
            e.Cancel = True
        End If
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        TXTCity.Text = ZipCode1.City
        TxtSt.Text = ZipCode1.State
    End Sub
    Private Sub ZipCode1_NotFindZipCode() Handles ZipCode1.NotFindZipCode
        TXTCity.Text = ""
        TxtSt.Text = ""
    End Sub
    Private Sub Txtf_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtf_name.LostFocus
        If TXTDriver_Name.Text.Trim.Length = 0 Then
            TXTDriver_Name.Text = Txtf_name.Text.Trim
        End If
    End Sub
    Private Sub AddNewCompany()
        Dim ThisCodCompanyVar As String = CompanyName1.CompanyCod
        If CompanyName1.Text.Trim.Length > 0 And CompanyName1.CompanyCod.Trim.Length = 0 Then
            ThisCodCompanyVar = MakeNewcod_company()
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Insert Into cust_company (cod_company,abbreviation_name,complete_name,address,zip_code,remark) Values(" & Qt(ThisCodCompanyVar) & "," & Qt(Mid(CompanyName1.Text, 1, 25)) & "," & Qt(CompanyName1.Text) & "," & Qt(Txtaddress.Text) & "," & IIf(ZipCode1.Text.Trim.Length > 0, Qt(ZipCode1.Text), "NULL") & ",'This Compnay Was Created In Customer Quick Add Form.')"
                CmdGeneral.ExecuteNonQuery()
                CompanyName1.CompanyCod = ThisCodCompanyVar
            Catch ex As Exception
                MsgFar("Can not insert company in company table")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub PhoneNo1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneNo1.GotFocus
        If Mid(PhoneNo1.Text, 1, 3).Trim.Length = 0 Then
            PhoneNo1.Text = AreaCodVar
        End If
    End Sub
End Class
