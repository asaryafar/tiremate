Imports CommonClass
Public Class FrmBankRegister
    Inherits FrmBase
    Dim i As Int64
    Dim j As Int64
    Dim MyfrmCheckScreen As FrmCheckScreen
    Dim MyFrmAtm As FrmATMTransaction
    Dim MyFrmAdj As FrmBankAdjusTment
    Dim MyFrmBankTransfer As UCBankAccount.FrmBankTransfer
    Dim MyFrmBankDeposit As UCBankAccount.FrmBankDeposits
    Dim clscheck1 As ClsCheck
    Dim FromDatestring As String = ""
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtBankTelephone As System.Windows.Forms.TextBox
    Friend WithEvents ChkShared As System.Windows.Forms.CheckBox
    Friend WithEvents TxtStorNo As System.Windows.Forms.TextBox
    Friend WithEvents CmbBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmdShow As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBas_Banks As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmBankRegister1 As UcAccount.DSFrmBankRegister
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdSplits As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmbSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlDebitDeposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtFromDate As CalendarCombo.CalendarCombo
    Friend WithEvents TxtToDate As CalendarCombo.CalendarCombo
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBank_Check As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_transfer_amount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBank_CheckDtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridSplit As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Da_Bank_Atm As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Da_Bank_AtmDtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmAtmTransaction1 As UcAccount.DsFrmAtmTransaction
    Friend WithEvents DaGlDebitDepositForBankRegister As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlDebitDepositForBankRegisterType3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaNewDeposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bb As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBankRegister))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.bb = New CalcUtils.UcCalcText
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdShow = New Janus.Windows.EditControls.UIButton
        Me.TxtToDate = New CalendarCombo.CalendarCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtFromDate = New CalendarCombo.CalendarCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbBankAccount = New System.Windows.Forms.ComboBox
        Me.DsFrmBankRegister1 = New UcAccount.DSFrmBankRegister
        Me.TxtStorNo = New System.Windows.Forms.TextBox
        Me.ChkShared = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtBankTelephone = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaBas_Banks = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.CmdSplits = New Janus.Windows.EditControls.UIButton
        Me.CmbSortBy = New System.Windows.Forms.ComboBox
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaGlDebitDeposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaBank_Check = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_transfer_amount = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaBank_CheckDtl = New System.Data.SqlClient.SqlDataAdapter
        Me.GridSplit = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.Da_Bank_Atm = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.Da_Bank_AtmDtl = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmAtmTransaction1 = New UcAccount.DsFrmAtmTransaction
        Me.DaGlDebitDepositForBankRegister = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGlDebitDepositForBankRegisterType3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaNewDeposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.Panel4.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmBankRegister1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmAtmTransaction1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.BtnJPrint)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.BtnFind)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(750, 56)
        Me.Panel4.TabIndex = 6
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(196, 0)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 196
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(174, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 24)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "Field  Chooser"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(108, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 24)
        Me.Label30.TabIndex = 194
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(125, 0)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 193
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(66, 35)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 10)
        Me.Label32.TabIndex = 184
        Me.Label32.Text = "Edit"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(66, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(13, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label14.Visible = False
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(13, 1)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        Me.BtnFind.Visible = False
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=SA;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_01"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.bb)
        Me.PnlSearch.Controls.Add(Me.Label7)
        Me.PnlSearch.Controls.Add(Me.CmdShow)
        Me.PnlSearch.Controls.Add(Me.TxtToDate)
        Me.PnlSearch.Controls.Add(Me.Label5)
        Me.PnlSearch.Controls.Add(Me.TxtFromDate)
        Me.PnlSearch.Controls.Add(Me.Label1)
        Me.PnlSearch.Controls.Add(Me.CmbBankAccount)
        Me.PnlSearch.Controls.Add(Me.TxtStorNo)
        Me.PnlSearch.Controls.Add(Me.ChkShared)
        Me.PnlSearch.Controls.Add(Me.Label3)
        Me.PnlSearch.Controls.Add(Me.TxtBankTelephone)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Controls.Add(Me.Label2)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 56)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(750, 56)
        Me.PnlSearch.TabIndex = 7
        '
        'bb
        '
        Me.bb.BackColor = System.Drawing.Color.Gold
        Me.bb.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.bb.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.bb.DecimalDigits = 2
        Me.bb.DefaultSendValue = False
        Me.bb.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.bb.FireTabAfterEnter = True
        Me.bb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.bb.Image = CType(resources.GetObject("bb.Image"), System.Drawing.Image)
        Me.bb.Location = New System.Drawing.Point(504, 29)
        Me.bb.Maxlength = 12
        Me.bb.MinusColor = System.Drawing.Color.Empty
        Me.bb.Name = "bb"
        Me.bb.ReadOnly = True
        Me.bb.Size = New System.Drawing.Size(120, 21)
        Me.bb.TabIndex = 42
        Me.bb.TabStop = False
        Me.bb.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.bb.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(397, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "beginning  Balance"
        '
        'CmdShow
        '
        Me.CmdShow.Location = New System.Drawing.Point(632, 29)
        Me.CmdShow.Name = "CmdShow"
        Me.CmdShow.Size = New System.Drawing.Size(113, 23)
        Me.CmdShow.TabIndex = 40
        Me.CmdShow.Text = "Display Transactions"
        '
        'TxtToDate
        '
        Me.TxtToDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtToDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtToDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtToDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtToDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtToDate.EditableSal = True
        Me.TxtToDate.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtToDate.Image = CType(resources.GetObject("TxtToDate.Image"), System.Drawing.Image)
        Me.TxtToDate.Location = New System.Drawing.Point(264, 28)
        Me.TxtToDate.MaxValue = CType(2500, Short)
        Me.TxtToDate.MinValue = CType(1800, Short)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtToDate.Sal_Mali = Nothing
        Me.TxtToDate.ShowButton = True
        Me.TxtToDate.Size = New System.Drawing.Size(119, 19)
        Me.TxtToDate.TabIndex = 39
        Me.TxtToDate.VisualStyle = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(200, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "To Date"
        '
        'TxtFromDate
        '
        Me.TxtFromDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtFromDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtFromDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtFromDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtFromDate.EditableSal = True
        Me.TxtFromDate.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFromDate.Image = CType(resources.GetObject("TxtFromDate.Image"), System.Drawing.Image)
        Me.TxtFromDate.Location = New System.Drawing.Point(72, 28)
        Me.TxtFromDate.MaxValue = CType(2500, Short)
        Me.TxtFromDate.MinValue = CType(1800, Short)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFromDate.Sal_Mali = Nothing
        Me.TxtFromDate.ShowButton = True
        Me.TxtFromDate.Size = New System.Drawing.Size(112, 19)
        Me.TxtFromDate.TabIndex = 37
        Me.TxtFromDate.VisualStyle = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "From Date"
        '
        'CmbBankAccount
        '
        Me.CmbBankAccount.DataSource = Me.DsFrmBankRegister1
        Me.CmbBankAccount.DisplayMember = "bas_banks.name_bank"
        Me.CmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBankAccount.Location = New System.Drawing.Point(72, 1)
        Me.CmbBankAccount.Name = "CmbBankAccount"
        Me.CmbBankAccount.Size = New System.Drawing.Size(200, 21)
        Me.CmbBankAccount.TabIndex = 8
        Me.CmbBankAccount.ValueMember = "bas_banks.id_bank"
        '
        'DsFrmBankRegister1
        '
        Me.DsFrmBankRegister1.DataSetName = "DSFrmBankRegister"
        Me.DsFrmBankRegister1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'TxtStorNo
        '
        Me.TxtStorNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtStorNo.Location = New System.Drawing.Point(669, 2)
        Me.TxtStorNo.Name = "TxtStorNo"
        Me.TxtStorNo.ReadOnly = True
        Me.TxtStorNo.Size = New System.Drawing.Size(72, 21)
        Me.TxtStorNo.TabIndex = 7
        Me.TxtStorNo.Text = ""
        '
        'ChkShared
        '
        Me.ChkShared.Enabled = False
        Me.ChkShared.Location = New System.Drawing.Point(469, -1)
        Me.ChkShared.Name = "ChkShared"
        Me.ChkShared.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkShared.Size = New System.Drawing.Size(74, 30)
        Me.ChkShared.TabIndex = 6
        Me.ChkShared.Text = "Share By All Store"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(554, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Only for this store no"
        '
        'TxtBankTelephone
        '
        Me.TxtBankTelephone.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtBankTelephone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsFrmBankRegister1, "bas_banks.phone_1"))
        Me.TxtBankTelephone.Location = New System.Drawing.Point(342, 0)
        Me.TxtBankTelephone.Name = "TxtBankTelephone"
        Me.TxtBankTelephone.ReadOnly = True
        Me.TxtBankTelephone.Size = New System.Drawing.Size(120, 21)
        Me.TxtBankTelephone.TabIndex = 3
        Me.TxtBankTelephone.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(281, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Telephone"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bank Name"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_bank, name_bank, share_all_store, store_no, account_no, address, zip, p" & _
        "hone_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_typ" & _
        "e_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, ex" & _
        "tension_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone" & _
        "_main_5, email, contact_name, GL_Account, start_check_no, next_check_no, default" & _
        "_bank, inactive, cod_account_type, routing_numbers, Bank_ID, Web_Page, User_ID, " & _
        "Password, Security_code, online_banking FROM bas_banks"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DaBas_Banks
        '
        Me.DaBas_Banks.SelectCommand = Me.SqlSelectCommand1
        Me.DaBas_Banks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AlternatingRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "BankRegister"
        Me.GrdDetail.DataSource = Me.DsFrmBankRegister1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>BankRegister</Caption><Columns Collection=""" & _
        "true""><Column0 ID=""Date""><Caption>Date</Caption><DataMember>Date1</DataMember><F" & _
        "ormatString>MM/dd/yyyy</FormatString><Key>Date</Key><Position>0</Position><Width" & _
        ">82</Width></Column0><Column1 ID=""Type""><Caption>Type</Caption><DataMember>Type<" & _
        "/DataMember><Key>Type</Key><Position>1</Position><Width>36</Width></Column1><Col" & _
        "umn2 ID=""Number""><Caption>Number</Caption><DataMember>Number</DataMember><Key>Nu" & _
        "mber</Key><Position>2</Position><Width>49</Width></Column2><Column3 ID=""Payee""><" & _
        "Caption>Payee</Caption><DataMember>Payee</DataMember><Key>Payee</Key><Position>3" & _
        "</Position><Width>110</Width></Column3><Column4 ID=""desc_GL_account""><Caption>Ac" & _
        "count</Caption><DataMember>desc_GL_account</DataMember><Key>desc_GL_account</Key" & _
        "><Position>4</Position><Width>133</Width></Column4><Column5 ID=""debit_amount""><C" & _
        "aption>Payment</Caption><DataMember>debit_amount</DataMember><FormatString>c</Fo" & _
        "rmatString><Key>debit_amount</Key><Position>5</Position><TextAlignment>Far</Text" & _
        "Alignment><Width>98</Width></Column5><Column6 ID=""Cleared_bank""><Caption>Clr</Ca" & _
        "ption><ColumnType>CheckBox</ColumnType><DataMember>Cleared_bank</DataMember><Edi" & _
        "tType>CheckBox</EditType><Key>Cleared_bank</Key><Position>6</Position><Width>31<" & _
        "/Width></Column6><Column7 ID=""deposit_amount""><Caption>Deposit</Caption><DataMem" & _
        "ber>deposit_amount</DataMember><FormatString>c</FormatString><Key>deposit_amount" & _
        "</Key><Position>7</Position><TextAlignment>Far</TextAlignment><Width>97</Width><" & _
        "/Column7><Column8 ID=""Balance""><Caption>Balance</Caption><DataMember>Balance</Da" & _
        "taMember><FormatString>c</FormatString><Key>Balance</Key><Position>8</Position><" & _
        "TextAlignment>Far</TextAlignment></Column8><Column9 ID=""Id_Check""><Caption>Id_Ch" & _
        "eck</Caption><DataMember>Id_Check</DataMember><Key>Id_Check</Key><Position>9</Po" & _
        "sition><Visible>False</Visible></Column9><Column10 ID=""Id_Atm""><Caption>Id_Atm</" & _
        "Caption><DataMember>Id_Atm</DataMember><Key>Id_Atm</Key><Position>10</Position><" & _
        "Visible>False</Visible></Column10><Column11 ID=""id_adjustment_no""><Caption>id_ad" & _
        "justment_no</Caption><DataMember>id_adjustment_no</DataMember><Key>id_adjustment" & _
        "_no</Key><Position>11</Position><Visible>False</Visible></Column11><Column12 ID=" & _
        """id_transfer""><Caption>id_transfer</Caption><DataMember>id_transfer</DataMember>" & _
        "<Key>id_transfer</Key><Position>12</Position><Visible>False</Visible></Column12>" & _
        "<Column13 ID=""id_debit_deposit_head""><Caption>id_debit_deposit_head</Caption><Da" & _
        "taMember>id_debit_deposit_head</DataMember><Key>id_debit_deposit_head</Key><Posi" & _
        "tion>13</Position><Visible>False</Visible></Column13></Columns><GroupCondition I" & _
        "D="""" /><Key>BankRegister</Key><UseGroupCondition>True</UseGroupCondition></RootT" & _
        "able></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.FilterRowFormatStyle.BackColor = System.Drawing.Color.Honeydew
        Me.GrdDetail.FilterRowFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Default
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 112)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.Size = New System.Drawing.Size(750, 325)
        Me.GrdDetail.TabIndex = 10
        '
        'CmdSplits
        '
        Me.CmdSplits.Location = New System.Drawing.Point(56, 441)
        Me.CmdSplits.Name = "CmdSplits"
        Me.CmdSplits.Size = New System.Drawing.Size(80, 23)
        Me.CmdSplits.TabIndex = 41
        Me.CmdSplits.Text = "Splits"
        '
        'CmbSortBy
        '
        Me.CmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSortBy.Items.AddRange(New Object() {"Date,Type,Number/Ref", "Amount Payment (largest First)", "Amount Payment(Smallest First)", "Amount Deposit (largest First)", "Amount Deposit(Smallest First)", "Number/Ref", "Type,Number/Ref", "Cleared Status"})
        Me.CmbSortBy.Location = New System.Drawing.Point(320, 441)
        Me.CmbSortBy.Name = "CmbSortBy"
        Me.CmbSortBy.Size = New System.Drawing.Size(256, 21)
        Me.CmbSortBy.TabIndex = 42
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_debit_deposit_head.id_debit_deposit_head, GL_debit_deposit_head.id_bank" & _
        ", GL_debit_deposit_head.date_doc, GL_debit_deposit_head.memo, GL_debit_deposit_h" & _
        "ead.cash_back_memo, GL_debit_deposit.type_transaction, GL_debit_deposit.ID_payme" & _
        "nt, GL_debit_deposit.id_check, GL_debit_deposit.id_transfer, GL_debit_deposit.id" & _
        "_external_cash, GL_debit_deposit.debit_amount, GL_debit_deposit.deposit_amount, " & _
        "GL_debit_deposit.GL_account, GL_debit_deposit.Cleared_bank, GL_account.desc_GL_a" & _
        "ccount, GL_debit_deposit.id_ATM, GL_debit_deposit.Memo AS Expr1, GL_debit_deposi" & _
        "t.id_adjustment_no FROM GL_debit_deposit_head INNER JOIN GL_debit_deposit ON GL_" & _
        "debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_deposit_hea" & _
        "d LEFT OUTER JOIN GL_account ON GL_debit_deposit.GL_account = GL_account.GL_acco" & _
        "unt WHERE (GL_debit_deposit_head.id_bank = @Id_Bank) AND (dbo.ChangeDate(GL_debi" & _
        "t_deposit_head.date_doc) >= @FromDate) AND (dbo.ChangeDate(GL_debit_deposit_head" & _
        ".date_doc) <= @ToDate)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaGlDebitDeposit
        '
        Me.DaGlDebitDeposit.SelectCommand = Me.SqlSelectCommand2
        Me.DaGlDebitDeposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_external_cash", "id_external_cash"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Cleared_bank", "Cleared_bank")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT bank_check.id_check, bank_check.id_bank, bank_check.no_of_check, bank_chec" & _
        "k.amount_check, bank_check.cod_vendor, bank_check.employee_code, bank_check.memo" & _
        "_check, bank_check.invoice_no, bank_check.check_status, inv_vendor.desc_vendor, " & _
        "employee.l_name +','+ employee.f_name AS l_name FROM bank_check LEFT OUTER JOIN " & _
        "employee ON bank_check.employee_code = employee.employee_code LEFT OUTER JOIN in" & _
        "v_vendor ON bank_check.cod_vendor = inv_vendor.cod_vendor WHERE (bank_check.id_c" & _
        "heck = @Id_Check) ORDER BY bank_check.id_check"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'DaBank_Check
        '
        Me.DaBank_Check.SelectCommand = Me.SqlSelectCommand3
        Me.DaBank_Check.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT ID_payment, id_service_center, refrence_no, refer_type, payment_type, paym" & _
        "ent_amount, flag_deposit_bank FROM GL_payment_deposit WHERE (ID_payment = @Id_Pa" & _
        "yment)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'DaGL_payment_deposit
        '
        Me.DaGL_payment_deposit.SelectCommand = Me.SqlSelectCommand4
        Me.DaGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id_transfer, id_bank_from_transfer, id_bank_to_transfer, date_transfer, am" & _
        "ount_transfer, memo FROM GL_transfer_amount"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_transfer_amount(id_bank_from_transfer, id_bank_to_transfer, date_t" & _
        "ransfer, amount_transfer, memo) VALUES (@id_bank_from_transfer, @id_bank_to_tran" & _
        "sfer, @date_transfer, @amount_transfer, @memo); SELECT id_transfer, id_bank_from" & _
        "_transfer, id_bank_to_transfer, date_transfer, amount_transfer, memo FROM GL_tra" & _
        "nsfer_amount WHERE (id_transfer = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_from_transfer", System.Data.SqlDbType.Int, 4, "id_bank_from_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_to_transfer", System.Data.SqlDbType.Int, 4, "id_bank_to_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_transfer", System.Data.SqlDbType.VarChar, 10, "date_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_transfer", System.Data.SqlDbType.Money, 8, "amount_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_transfer_amount SET id_bank_from_transfer = @id_bank_from_transfer, id_" & _
        "bank_to_transfer = @id_bank_to_transfer, date_transfer = @date_transfer, amount_" & _
        "transfer = @amount_transfer, memo = @memo WHERE (id_transfer = @Original_id_tran" & _
        "sfer) AND (amount_transfer = @Original_amount_transfer OR @Original_amount_trans" & _
        "fer IS NULL AND amount_transfer IS NULL) AND (date_transfer = @Original_date_tra" & _
        "nsfer OR @Original_date_transfer IS NULL AND date_transfer IS NULL) AND (id_bank" & _
        "_from_transfer = @Original_id_bank_from_transfer OR @Original_id_bank_from_trans" & _
        "fer IS NULL AND id_bank_from_transfer IS NULL) AND (id_bank_to_transfer = @Origi" & _
        "nal_id_bank_to_transfer OR @Original_id_bank_to_transfer IS NULL AND id_bank_to_" & _
        "transfer IS NULL) AND (memo = @Original_memo OR @Original_memo IS NULL AND memo " & _
        "IS NULL); SELECT id_transfer, id_bank_from_transfer, id_bank_to_transfer, date_t" & _
        "ransfer, amount_transfer, memo FROM GL_transfer_amount WHERE (id_transfer = @id_" & _
        "transfer)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_from_transfer", System.Data.SqlDbType.Int, 4, "id_bank_from_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_to_transfer", System.Data.SqlDbType.Int, 4, "id_bank_to_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_transfer", System.Data.SqlDbType.VarChar, 10, "date_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_transfer", System.Data.SqlDbType.Money, 8, "amount_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_transfer", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_from_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_from_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_to_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_to_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_transfer", System.Data.SqlDbType.Int, 4, "id_transfer"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_transfer_amount WHERE (id_transfer = @Original_id_transfer) AND (a" & _
        "mount_transfer = @Original_amount_transfer OR @Original_amount_transfer IS NULL " & _
        "AND amount_transfer IS NULL) AND (date_transfer = @Original_date_transfer OR @Or" & _
        "iginal_date_transfer IS NULL AND date_transfer IS NULL) AND (id_bank_from_transf" & _
        "er = @Original_id_bank_from_transfer OR @Original_id_bank_from_transfer IS NULL " & _
        "AND id_bank_from_transfer IS NULL) AND (id_bank_to_transfer = @Original_id_bank_" & _
        "to_transfer OR @Original_id_bank_to_transfer IS NULL AND id_bank_to_transfer IS " & _
        "NULL) AND (memo = @Original_memo OR @Original_memo IS NULL AND memo IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_transfer", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_from_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_from_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_to_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_to_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGL_transfer_amount
        '
        Me.DaGL_transfer_amount.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaGL_transfer_amount.InsertCommand = Me.SqlInsertCommand1
        Me.DaGL_transfer_amount.SelectCommand = Me.SqlSelectCommand5
        Me.DaGL_transfer_amount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_transfer_amount", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_bank_from_transfer", "id_bank_from_transfer"), New System.Data.Common.DataColumnMapping("id_bank_to_transfer", "id_bank_to_transfer"), New System.Data.Common.DataColumnMapping("date_transfer", "date_transfer"), New System.Data.Common.DataColumnMapping("amount_transfer", "amount_transfer"), New System.Data.Common.DataColumnMapping("memo", "memo")})})
        Me.DaGL_transfer_amount.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT bank_check_dtl.id_check, bank_check_dtl.radif, bank_check_dtl.GL_Account, " & _
        "bank_check_dtl.amount, bank_check_dtl.memo_dtl, GL_account.desc_GL_account FROM " & _
        "bank_check_dtl INNER JOIN GL_account ON bank_check_dtl.GL_Account = GL_account.G" & _
        "L_account WHERE (bank_check_dtl.id_check = @Id_Check)"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'DaBank_CheckDtl
        '
        Me.DaBank_CheckDtl.SelectCommand = Me.SqlSelectCommand6
        Me.DaBank_CheckDtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("memo_dtl", "memo_dtl")})})
        '
        'GridSplit
        '
        Me.GridSplit.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridSplit.AlternatingColors = True
        Me.GridSplit.DataMember = "bank_check_dtl"
        Me.GridSplit.DataSource = Me.DsFrmBankRegister1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check_dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""desc_GL_account""><Caption>Account</Caption><DataMember>desc" & _
        "_GL_account</DataMember><Key>desc_GL_account</Key><Position>0</Position><Width>1" & _
        "67</Width></Column0><Column1 ID=""amount""><Caption>Amount</Caption><DataMember>am" & _
        "ount</DataMember><FormatString>c</FormatString><Key>amount</Key><Position>1</Pos" & _
        "ition><TextAlignment>Far</TextAlignment><Width>111</Width></Column1><Column2 ID=" & _
        """memo_dtl""><Caption>Memo</Caption><DataMember>memo_dtl</DataMember><Key>memo_dtl" & _
        "</Key><Position>2</Position><Width>237</Width></Column2></Columns><GroupConditio" & _
        "n ID="""" /><Key>bank_check_dtl</Key><SortKeys Collection=""true""><SortKey0 ID=""Sor" & _
        "tKey0""><ColIndex>2</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutDat" & _
        "a>"
        Me.GridSplit.DesignTimeLayout = GridEXLayout2
        Me.GridSplit.Enabled = False
        Me.GridSplit.GroupByBoxVisible = False
        Me.GridSplit.Location = New System.Drawing.Point(120, 224)
        Me.GridSplit.Name = "GridSplit"
        Me.GridSplit.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridSplit.Size = New System.Drawing.Size(539, 121)
        Me.GridSplit.TabIndex = 43
        Me.GridSplit.Visible = False
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT bank_ATM.id_ATM, bank_ATM.id_bank, bank_ATM.date_transaction, bank_ATM.amo" & _
        "unt_ATM, bank_ATM.cod_vendor, bank_ATM.memo_address, bank_ATM.id_debit_deposit_h" & _
        "ead, bank_ATM.ChargeCredit, inv_vendor.desc_vendor FROM bank_ATM LEFT OUTER JOIN" & _
        " inv_vendor ON bank_ATM.cod_vendor = inv_vendor.cod_vendor WHERE (bank_ATM.id_AT" & _
        "M = @id_Atm) ORDER BY bank_ATM.id_ATM"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_Atm", System.Data.SqlDbType.Int, 4, "id_ATM"))
        '
        'Da_Bank_Atm
        '
        Me.Da_Bank_Atm.SelectCommand = Me.SqlSelectCommand7
        Me.Da_Bank_Atm.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_ATM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_transaction", "date_transaction"), New System.Data.Common.DataColumnMapping("amount_ATM", "amount_ATM"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("memo_address", "memo_address"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("ChargeCredit", "ChargeCredit")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT bank_ATM_dtl.id_ATM, bank_ATM_dtl.radif, bank_ATM_dtl.GL_account, bank_ATM" & _
        "_dtl.amount, bank_ATM_dtl.memo_dtl, GL_account.desc_GL_account FROM bank_ATM_dtl" & _
        " INNER JOIN GL_account ON bank_ATM_dtl.GL_account = GL_account.GL_account WHERE " & _
        "(bank_ATM_dtl.id_ATM = @Id_Atm)"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Atm", System.Data.SqlDbType.Int, 4, "id_ATM"))
        '
        'Da_Bank_AtmDtl
        '
        Me.Da_Bank_AtmDtl.SelectCommand = Me.SqlSelectCommand8
        Me.Da_Bank_AtmDtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_ATM_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("memo_dtl", "memo_dtl")})})
        '
        'DsFrmAtmTransaction1
        '
        Me.DsFrmAtmTransaction1.DataSetName = "DsFrmAtmTransaction"
        Me.DsFrmAtmTransaction1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DaGlDebitDepositForBankRegister
        '
        Me.DaGlDebitDepositForBankRegister.SelectCommand = Me.SqlCommand1
        Me.DaGlDebitDepositForBankRegister.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_external_cash", "id_external_cash"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Cleared_bank", "Cleared_bank")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_debit_deposit_head.id_bank, GL_debit_deposit_head.date_doc, SUM(GL_debi" & _
        "t_deposit.debit_amount) AS debit_amount, SUM(GL_debit_deposit.deposit_amount) AS" & _
        " deposit_amount, GL_debit_deposit.GL_account, GL_account.desc_GL_account, GL_deb" & _
        "it_deposit_head.id_debit_deposit_head, GL_debit_deposit_head.memo, GL_debit_depo" & _
        "sit.Memo AS memo2 FROM GL_debit_deposit_head INNER JOIN GL_debit_deposit ON GL_d" & _
        "ebit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_deposit_head" & _
        " LEFT OUTER JOIN GL_account ON GL_debit_deposit.GL_account = GL_account.GL_accou" & _
        "nt WHERE (GL_debit_deposit.type_transaction IN ('1', '5')) AND (dbo.ChangeDate(G" & _
        "L_debit_deposit_head.date_doc) >= @FromDate) AND (dbo.ChangeDate(GL_debit_deposi" & _
        "t_head.date_doc) <= @todate) AND (GL_debit_deposit_head.id_bank = @id_Bank) GROU" & _
        "P BY GL_debit_deposit_head.id_bank, GL_debit_deposit_head.date_doc, GL_debit_dep" & _
        "osit.GL_account, GL_account.desc_GL_account, GL_debit_deposit_head.id_debit_depo" & _
        "sit_head, GL_debit_deposit_head.memo, GL_debit_deposit.Memo, GL_debit_deposit.Me" & _
        "mo"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@todate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_Bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        '
        'DaGlDebitDepositForBankRegisterType3
        '
        Me.DaGlDebitDepositForBankRegisterType3.SelectCommand = Me.SqlCommand2
        Me.DaGlDebitDepositForBankRegisterType3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_external_cash", "id_external_cash"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Cleared_bank", "Cleared_bank")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT GL_debit_deposit_head.id_bank, SUM(GL_debit_deposit.debit_amount) AS debit" & _
        "_amount, SUM(GL_debit_deposit.deposit_amount) AS deposit_amount, GL_debit_deposi" & _
        "t_head.id_debit_deposit_head FROM GL_debit_deposit_head INNER JOIN GL_debit_depo" & _
        "sit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_d" & _
        "eposit_head LEFT OUTER JOIN GL_account ON GL_debit_deposit.GL_account = GL_accou" & _
        "nt.GL_account WHERE (GL_debit_deposit.type_transaction IN ('3')) AND (GL_debit_d" & _
        "eposit_head.id_debit_deposit_head = @id_debit_deposit_head) GROUP BY GL_debit_de" & _
        "posit_head.id_bank, GL_debit_deposit_head.id_debit_deposit_head"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        '
        'DaNewDeposit
        '
        Me.DaNewDeposit.SelectCommand = Me.SqlCommand3
        Me.DaNewDeposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_external_cash", "id_external_cash"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Cleared_bank", "Cleared_bank")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_debit_deposit_head.id_bank, GL_debit_deposit_head.date_doc, SUM(GL_debi" & _
        "t_deposit.debit_amount) AS debit_amount, View_BankNetDeposit.NetDeposit AS depos" & _
        "it_amount, GL_debit_deposit.GL_account, GL_account.desc_GL_account, GL_debit_dep" & _
        "osit_head.id_debit_deposit_head, GL_debit_deposit_head.memo FROM GL_debit_deposi" & _
        "t_head INNER JOIN GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposit_hea" & _
        "d = GL_debit_deposit.id_debit_deposit_head INNER JOIN View_BankNetDeposit ON GL_" & _
        "debit_deposit_head.id_debit_deposit_head = View_BankNetDeposit.id_debit_deposit_" & _
        "head LEFT OUTER JOIN GL_account ON GL_debit_deposit.GL_account = GL_account.GL_a" & _
        "ccount WHERE (dbo.ChangeDate(GL_debit_deposit_head.date_doc) BETWEEN @FromDate A" & _
        "ND @todate) AND (GL_debit_deposit_head.id_bank = @id_Bank) AND (GL_debit_deposit" & _
        ".type_transaction <> '3') GROUP BY GL_debit_deposit_head.id_bank, GL_debit_depos" & _
        "it_head.date_doc, GL_debit_deposit.GL_account, GL_account.desc_GL_account, GL_de" & _
        "bit_deposit_head.id_debit_deposit_head, GL_debit_deposit_head.memo, View_BankNet" & _
        "Deposit.NetDeposit"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@todate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_Bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GrdDetail
        Me.GridEXPrintDocument1.PrintHierarchical = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(750, 54)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'FrmBankRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(750, 468)
        Me.Controls.Add(Me.GridSplit)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmbSortBy)
        Me.Controls.Add(Me.CmdSplits)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmBankRegister"
        Me.Text = "Bank Register"
        Me.Panel4.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmBankRegister1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSplit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmAtmTransaction1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmBankRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        clscheck1 = New ClsCheck
        clscheck1.Connection = Cnn
        DaBas_Banks.Fill(DsFrmBankRegister1.bas_banks)
        TxtStorNo.Text = PubStoreName
        Try
            CmbBankAccount.SelectedIndex = 0
            CmdShow.Enabled = TxtFromDate.Text.Trim <> "" And TxtToDate.Text.Trim <> ""
        Catch ex As Exception
        End Try
        TxtToDate.Text = Format(Now, PubDateFormat)
        TxtFromDate.Text = Format(Now.AddMonths(-1), PubDateFormat)
        Dim d As Integer = clscheck1.FindDefaultBank
        If d <> 0 Then
            CmbBankAccount.SelectedValue = d
        End If
        BtnEdit.Enabled = False
        GrdDetail.DataMember = ""
        CmbSortBy.SelectedIndex = 0
    End Sub
    Private Sub CmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdShow.Click
        FromDatestring = Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2)

        If DsFrmBankRegister1.bas_banks.Rows.Count > 0 Then
            DsFrmBankRegister1.GL_debit_deposit.Clear()
            DsFrmBankRegister1.BankRegister.Clear()
            DaGlDebitDeposit.SelectCommand.Parameters("@FromDate").Value = "0001/01/01" 'Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2)
            DaGlDebitDeposit.SelectCommand.Parameters("@ToDate").Value = Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
            DaGlDebitDeposit.SelectCommand.Parameters("@Id_Bank").Value = CmbBankAccount.SelectedValue
            Try
                DaGlDebitDeposit.Fill(DsFrmBankRegister1.GL_debit_deposit)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            If DsFrmBankRegister1.GL_debit_deposit.Rows.Count > 0 Then
                For i = 0 To DsFrmBankRegister1.GL_debit_deposit.Rows.Count - 1
                    With DsFrmBankRegister1.GL_debit_deposit.Rows(i)
                        '1=deposit 2=check 3=cash back 4=transfer 5=external cash
                        Select Case Trim(.Item("type_transaction") & "")
                            Case "1", "3", "5" 'Deposit
                                '   Call FindAllDeposit(DsFrmBankRegister1.GL_debit_deposit.Rows(i))
                            Case "2" 'Check
                                Call FindAllChecks(DsFrmBankRegister1.GL_debit_deposit.Rows(i))
                            Case "4" 'bANK tRANSFER
                                Call FindAllBankTransfer(DsFrmBankRegister1.GL_debit_deposit.Rows(i))
                            Case "7" 'Atm
                                Call FindAllAtm(DsFrmBankRegister1.GL_debit_deposit.Rows(i))
                            Case "6" 'ADJ  
                                Call FindAllADj(DsFrmBankRegister1.GL_debit_deposit.Rows(i))
                        End Select
                    End With
                Next
            End If

            'Call FindAllDeposit2() 'beforeeeeeeeeeeeeeeeeeeee
            Try
                Cnn.Close()

            Catch ex As Exception

            End Try

            Call FindAllDeposit3()

            Dim mand1 As Decimal = 0.0
            If DsFrmBankRegister1.BankRegister.Rows.Count > 0 Then
                Try
                    For i = 0 To DsFrmBankRegister1.BankRegister.Rows.Count - 1
                        If DsFrmBankRegister1.BankRegister.Rows(i).RowState <> DataRowState.Deleted Then
                            Dim d As String = Format(CDate(DsFrmBankRegister1.BankRegister.Rows(i).Item("date1")), "yyyy/MM/dd")
                            ' If Mid(d, 7, 4) + "/" + Mid(d, 1, 2) + "/" + Mid(d, 4, 2) < Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2) Then
                            If d < Format(CDate(FromDatestring), "yyyy/MM/dd") Then
                                mand1 = mand1 + (DsFrmBankRegister1.BankRegister.Rows(i).Item("deposit_amount") - DsFrmBankRegister1.BankRegister.Rows(i).Item("debit_amount"))
                                'DsFrmBankRegister1.BankRegister.Rows(i).Delete()
                            End If
                        End If
                    Next

                    Dim dr As DataRow() = DsFrmBankRegister1.BankRegister.Select("date1 < " & "'" & Format(CDate(FromDatestring), "MM/dd/yyyy") & "'")
                    For i = 0 To dr.LongLength
                        Try
                            dr(i).Delete()
                        Catch ex As Exception
                        End Try
                    Next

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            DsFrmBankRegister1.BankRegister.AcceptChanges()
            GrdDetail.DataSource = DsFrmBankRegister1
            GrdDetail.DataMember = "BankRegister"
            GrdDetail.Refetch()
            bb.Text = mand1
            Call CalculateMandeh()
            If DsFrmBankRegister1.BankRegister.Rows.Count > 0 Then
                BtnEdit.Enabled = True
            Else
                BtnEdit.Enabled = False
            End If

        Else
            MsgFar("There is No Bank ")
        End If
    End Sub
    Sub CalculateMandeh()

        Dim Mand As Decimal = Val(bb.Text & "") ' DsFrmBankRegister1.BankRegister.Rows(0).Item("deposit_amount") - DsFrmBankRegister1.BankRegister.Rows(0).Item("debit_amount")

        If GrdDetail.RowCount >= 1 Then
            For i = 0 To GrdDetail.RowCount - 1 'DsFrmBankRegister1.BankRegister.Rows.Count - 1
                GrdDetail.Row = i

                Mand = Mand + Val(GrdDetail.GetRow.Cells(7).Value & "") - Val(GrdDetail.GetRow.Cells(5).Value & "")

                ' Mand = Mand + DsFrmBankRegister1.BankRegister.Rows(i).Item("deposit_amount") - DsFrmBankRegister1.BankRegister.Rows(i).Item("debit_amount")
                GrdDetail.GetRow.Cells(8).Value = Mand 'DsFrmBankRegister1.BankRegister.Rows(i).Item("Balance") = 
            Next
            GrdDetail.Row = 0
        End If

    End Sub
    Sub FindAllAtm(ByVal ThisRow As DataRow)

        With ThisRow
            If .Item("id_Atm") & "" <> "" Then
                DsFrmBankRegister1.bank_ATM.Clear()
                Da_Bank_Atm.SelectCommand.Parameters("@Id_Atm").Value = .Item("id_Atm")
                Try
                    Da_Bank_Atm.Fill(DsFrmBankRegister1.bank_ATM)
                Catch ex As Exception
                    MsgBox(ex.Message & "-  FindAllAtm")
                End Try
                If DsFrmBankRegister1.bank_check.Rows.Count > 0 Then
                    For j = 0 To DsFrmBankRegister1.bank_ATM.Rows.Count - 1
                        Dim dr1 As DSFrmBankRegister.BankRegisterRow = DsFrmBankRegister1.BankRegister.NewRow
                        dr1.Id_Atm = .Item("id_Atm")
                        dr1.Date1 = .Item("date_doc")
                        dr1.debit_amount = .Item("debit_amount")
                        dr1.deposit_amount = .Item("deposit_amount")
                        dr1.Memo = .Item("memo") & ""
                        dr1.Payee = .Item("memo") & ""
                        dr1.Type = "ATM"
                        dr1.Number = DsFrmBankRegister1.bank_ATM.Rows(j).Item("id_ATM") & ""
                        dr1.CustomerVendorEmployeeOther = 2
                        dr1.Payee = DsFrmBankRegister1.bank_ATM.Rows(j).Item("desc_vendor") & ""
                        dr1.CustomerVendorEmployeeOther = 2
                        'If DsFrmBankRegister1.bank_check.Rows.Count > 1 Then
                        dr1.desc_GL_account = "-Split-"

                        Da_Bank_AtmDtl.SelectCommand.Parameters(0).Value = .Item("id_Atm")
                        DsFrmBankRegister1.bank_ATM_dtl.Clear()
                        Da_Bank_AtmDtl.Fill(DsFrmBankRegister1.bank_ATM_dtl)
                        If DsFrmBankRegister1.bank_ATM_dtl.Rows.Count = 1 Then
                            dr1.desc_GL_account = DsFrmBankRegister1.bank_ATM_dtl.Rows(0).Item("desc_GL_account")
                        End If



                        dr1.CheckBankDepositBankTransaction = 1
                        DsFrmBankRegister1.BankRegister.Rows.Add(dr1)
                    Next
                End If
            End If
        End With
    End Sub
    Sub FindAllChecks(ByVal ThisRow As DataRow)
        With ThisRow
            If .Item("id_check") & "" <> "" Then
                DsFrmBankRegister1.bank_check.Clear()
                DaBank_Check.SelectCommand.Parameters("@Id_Check").Value = .Item("id_check")
                Try
                    DaBank_Check.Fill(DsFrmBankRegister1.bank_check)
                Catch ex As Exception
                    MsgBox(ex.Message & "-  FindAllChecks")
                End Try

                If DsFrmBankRegister1.bank_check.Rows.Count > 0 Then
                    For j = 0 To DsFrmBankRegister1.bank_check.Rows.Count - 1
                        Dim dr1 As DSFrmBankRegister.BankRegisterRow = DsFrmBankRegister1.BankRegister.NewRow
                        dr1.Id_Check = .Item("id_check")
                        dr1.Date1 = .Item("date_doc")
                        dr1.debit_amount = .Item("debit_amount")
                        dr1.deposit_amount = .Item("deposit_amount")
                        dr1.Memo = .Item("memo") & ""
                        dr1.Type = "CHK"
                        dr1.Number = DsFrmBankRegister1.bank_check.Rows(j).Item("no_of_check") & ""
                        dr1.CustomerVendorEmployeeOther = 4
                        If DsFrmBankRegister1.bank_check.Rows(j).Item("cod_vendor") & "" <> "" Then
                            dr1.Payee = DsFrmBankRegister1.bank_check.Rows(j).Item("desc_vendor") & ""
                            dr1.CustomerVendorEmployeeOther = 2
                        ElseIf DsFrmBankRegister1.bank_check.Rows(j).Item("employee_code") & "" <> "" Then
                            dr1.Payee = DsFrmBankRegister1.bank_check.Rows(j).Item("l_name") & ""
                            dr1.CustomerVendorEmployeeOther = 3
                        End If
                        dr1.desc_GL_account = "-Split-"

                        DaBank_CheckDtl.SelectCommand.Parameters(0).Value = .Item("id_check")
                        DsFrmBankRegister1.bank_check_dtl.Clear()
                        DaBank_CheckDtl.Fill(DsFrmBankRegister1.bank_check_dtl)
                        If DsFrmBankRegister1.bank_check_dtl.Rows.Count = 1 Then
                            dr1.desc_GL_account = DsFrmBankRegister1.bank_check_dtl.Rows(0).Item("desc_GL_account") & ""
                        End If
                        dr1.CheckBankDepositBankTransaction = 1
                        DsFrmBankRegister1.BankRegister.Rows.Add(dr1)
                    Next
                End If
            End If
        End With
    End Sub



    Sub FindAllDeposit(ByVal ThisRow As DataRow)
        With ThisRow
            'If .Item("Id_Payment") & "" <> "" Then
            DsFrmBankRegister1.GL_payment_deposit.Clear()
            DaGL_payment_deposit.SelectCommand.Parameters("@Id_Payment").Value = .Item("Id_Payment")
            DaGL_payment_deposit.Fill(DsFrmBankRegister1.GL_payment_deposit)
            If DsFrmBankRegister1.GL_payment_deposit.Rows.Count > 0 Then
                For j = 0 To DsFrmBankRegister1.GL_payment_deposit.Rows.Count - 1
                    Dim dr1 As DSFrmBankRegister.BankRegisterRow = DsFrmBankRegister1.BankRegister.NewRow
                    dr1.id_debit_deposit_head = .Item("id_debit_deposit_head")
                    dr1.Date1 = .Item("date_doc")
                    dr1.debit_amount = .Item("debit_amount")
                    dr1.deposit_amount = .Item("deposit_amount")
                    dr1.Memo = .Item("memo") & ""
                    dr1.Payee = Trim(.Item("memo") & "")
                    Dim T As String = DsFrmBankRegister1.GL_payment_deposit.Rows(j).Item("refer_type") & ""
                    If T = "1" Or T = "2" Then
                        dr1.Type = "DEP"
                    ElseIf T = "3" Then
                        dr1.Type = "CCD"
                    Else
                        dr1.Type = "Ar"
                    End If
                    dr1.Number = DsFrmBankRegister1.GL_payment_deposit.Rows(j).Item("Id_PayMent") & ""
                    dr1.CustomerVendorEmployeeOther = 4
                    dr1.Payee = "Deposit"

                    dr1.desc_GL_account = .Item("desc_GL_account") & ""
                    dr1.CheckBankDepositBankTransaction = 2
                    DsFrmBankRegister1.BankRegister.Rows.Add(dr1)
                Next
            End If
            'End If
        End With
    End Sub
    Sub findalldeposit2()
        Dim Ds1 As New DataSet

        DaGlDebitDepositForBankRegister.SelectCommand.Parameters("@FromDate").Value = Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2)
        DaGlDebitDepositForBankRegister.SelectCommand.Parameters("@ToDate").Value = Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
        DaGlDebitDepositForBankRegister.SelectCommand.Parameters("@Id_Bank").Value = CmbBankAccount.SelectedValue
        DaGlDebitDepositForBankRegister.Fill(Ds1, "t1")
        For j = 0 To Ds1.Tables("t1").Rows.Count - 1
            With Ds1.Tables("t1").Rows(j)
                Dim dr1 As DSFrmBankRegister.BankRegisterRow = DsFrmBankRegister1.BankRegister.NewRow
                dr1.id_debit_deposit_head = .Item("id_debit_deposit_head")
                dr1.Date1 = .Item("date_doc")
                dr1.debit_amount = .Item("debit_amount")
                dr1.deposit_amount = .Item("deposit_amount") - DecreaseType3("" & .Item("id_debit_deposit_head"))
                '---------------------------
                dr1.Number = "" & .Item("id_debit_deposit_head") ' Error Ds1.Tables("t1").Rows(j).Item("Id_PayMent") & ""
                dr1.CustomerVendorEmployeeOther = 4
                dr1.Payee = "Deposit"
                dr1.Type = "DEP"
                'error
                'Dim T As String = .Item("refer_type") & "" '.Item("type_transaction") & ""
                'If T = "1" Or T = "2" Then
                '    dr1.Type = "DEP"
                'ElseIf T = "3" Then
                '    dr1.Type = "CCD"
                'Else
                '    dr1.Type = "Ar"
                'End If
                'error
                dr1.desc_GL_account = .Item("desc_GL_account") & ""
                dr1.CheckBankDepositBankTransaction = 2
                DsFrmBankRegister1.BankRegister.Rows.Add(dr1)
            End With
        Next

    End Sub

    Sub FindAllDeposit3()
        Dim Ds1 As New DataSet
        DaNewDeposit.SelectCommand.Parameters("@FromDate").Value = "0001/01/01" 'Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2)
        DaNewDeposit.SelectCommand.Parameters("@ToDate").Value = Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
        DaNewDeposit.SelectCommand.Parameters("@Id_Bank").Value = CmbBankAccount.SelectedValue
        Try
            DaNewDeposit.Fill(Ds1, "t1")
        Catch ex As Exception
            MsgBox(ex.Message & "  FindAllDeposit3")
        End Try
        For j = 0 To Ds1.Tables("t1").Rows.Count - 1
            With Ds1.Tables("t1").Rows(j)
                Dim dr1 As DSFrmBankRegister.BankRegisterRow = DsFrmBankRegister1.BankRegister.NewRow
                dr1.id_debit_deposit_head = .Item("id_debit_deposit_head")
                dr1.Date1 = .Item("date_doc")
                dr1.debit_amount = 0 '.Item("debit_amount") hamid told we should not come it for cash paid out

                dr1.deposit_amount = .Item("deposit_amount") '- DecreaseType3("" & .Item("id_debit_deposit_head"))
                '---------------------------
                dr1.Number = "" & .Item("id_debit_deposit_head") ' Error Ds1.Tables("t1").Rows(j).Item("Id_PayMent") & ""
                dr1.CustomerVendorEmployeeOther = 4
                dr1.Payee = "Deposit"
                dr1.Type = "DEP"
                dr1.desc_GL_account = .Item("desc_GL_account") & ""
                dr1.CheckBankDepositBankTransaction = 2
                DsFrmBankRegister1.BankRegister.Rows.Add(dr1)
            End With
        Next
    End Sub


    'TRN
    Sub FindAllBankTransfer(ByVal ThisRow As DataRow)
        With ThisRow
            If .Item("id_transfer") & "" <> "" Then
                Dim dr1 As DSFrmBankRegister.BankRegisterRow = DsFrmBankRegister1.BankRegister.NewRow
                dr1.Date1 = .Item("date_doc")
                dr1.debit_amount = .Item("debit_amount")
                dr1.deposit_amount = .Item("deposit_amount")
                dr1.Memo = .Item("memo") & ""
                dr1.Payee = Trim(.Item("memo") & "")
                dr1.Type = "TRN"
                dr1.Number = Val(.Item("id_transfer") & "") ' DsFrmBankRegister1.GL_payment_deposit.Rows(j).Item("Id_Transfer") & ""
                dr1.id_transfer = .Item("id_transfer")
                dr1.CustomerVendorEmployeeOther = 4
                'dr1.Payee = "Bank Transfer"
                dr1.desc_GL_account = .Item("desc_GL_account") & ""
                dr1.CheckBankDepositBankTransaction = 2
                DsFrmBankRegister1.BankRegister.Rows.Add(dr1)
            End If
        End With
    End Sub
    Sub FindAllADj(ByVal ThisRow As DataRow)
        With ThisRow
            If .Item("id_adjustment_no") & "" <> "" Then
                Dim dr1 As DSFrmBankRegister.BankRegisterRow = DsFrmBankRegister1.BankRegister.NewRow
                dr1.Date1 = .Item("date_doc")
                dr1.debit_amount = .Item("debit_amount")
                dr1.deposit_amount = .Item("deposit_amount")
                dr1.Memo = .Item("memo") & ""
                dr1.Type = "ADJ"
                dr1.Number = .Item("id_adjustment_no")  'DsFrmBankRegister1.GL_payment_deposit.Rows(j).Item("id_adjustment_no") & ""
                dr1.id_adjustment_no = .Item("id_adjustment_no")
                dr1.CustomerVendorEmployeeOther = 4
                dr1.Payee = Trim(.Item(17) & "")  '"Bank Adjustments"
                dr1.desc_GL_account = .Item("desc_GL_account") & ""
                dr1.CheckBankDepositBankTransaction = 2
                DsFrmBankRegister1.BankRegister.Rows.Add(dr1)
            End If
        End With
    End Sub
    'Sort By 
    Private Sub CmbSortBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSortBy.SelectedIndexChanged
        Try
            GrdDetail.RootTable.SortKeys.Clear()
        Catch ex As Exception
        End Try
        Select Case CmbSortBy.SelectedIndex
            Case 0
                Dim s As New Janus.Windows.GridEX.GridEXSortKey
                Dim s1 As New Janus.Windows.GridEX.GridEXSortKey
                Dim s2 As New Janus.Windows.GridEX.GridEXSortKey
                s.Column = GrdDetail.RootTable.Columns(0)
                s1.Column = GrdDetail.RootTable.Columns(1)
                s1.SortOrder = Janus.Windows.GridEX.SortOrder.Descending
                s2.Column = GrdDetail.RootTable.Columns(2)
                GrdDetail.RootTable.SortKeys.Add(s)
                GrdDetail.RootTable.SortKeys.Add(s1)
                GrdDetail.RootTable.SortKeys.Add(s2)
            Case 1
                Dim s As New Janus.Windows.GridEX.GridEXSortKey
                s.Column = GrdDetail.RootTable.Columns(5)
                s.SortOrder = Janus.Windows.GridEX.SortOrder.Descending
                GrdDetail.RootTable.SortKeys.Add(s)
            Case 2
                Dim s As New Janus.Windows.GridEX.GridEXSortKey
                s.Column = GrdDetail.RootTable.Columns(5)
                s.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
                GrdDetail.RootTable.SortKeys.Add(s)

            Case 3
                Dim s As New Janus.Windows.GridEX.GridEXSortKey
                s.Column = GrdDetail.RootTable.Columns(7)
                s.SortOrder = Janus.Windows.GridEX.SortOrder.Descending
                GrdDetail.RootTable.SortKeys.Add(s)
            Case 4
                Dim s As New Janus.Windows.GridEX.GridEXSortKey
                s.Column = GrdDetail.RootTable.Columns(7)
                s.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
                GrdDetail.RootTable.SortKeys.Add(s)
            Case 5
                Dim s As New Janus.Windows.GridEX.GridEXSortKey
                s.Column = GrdDetail.RootTable.Columns(2)
                GrdDetail.RootTable.SortKeys.Add(s)

            Case 6
                Dim s1 As New Janus.Windows.GridEX.GridEXSortKey
                Dim s2 As New Janus.Windows.GridEX.GridEXSortKey
                s1.Column = GrdDetail.RootTable.Columns(1)
                s1.SortOrder = Janus.Windows.GridEX.SortOrder.Descending
                s2.Column = GrdDetail.RootTable.Columns(2)
                GrdDetail.RootTable.SortKeys.Add(s1)
                GrdDetail.RootTable.SortKeys.Add(s2)
            Case 7
                Dim s1 As New Janus.Windows.GridEX.GridEXSortKey
                s1.Column = GrdDetail.RootTable.Columns(6)
                GrdDetail.RootTable.SortKeys.Add(s1)
        End Select
        Call CalculateMandeh()
    End Sub
#Region "Show Splits "
    Sub ShowSplitsCheck(ByVal ThisIdCheck As Decimal)
        DaBank_CheckDtl.SelectCommand.Parameters(0).Value = ThisIdCheck
        DsFrmBankRegister1.bank_check_dtl.Clear()
        DaBank_CheckDtl.Fill(DsFrmBankRegister1.bank_check_dtl)
        GridSplit.DataMember = "bank_check_dtl"
        GridSplit.Visible = True
        GridSplit.Enabled = True
        GridSplit.Focus()
    End Sub

    Sub ShowSplitsATM(ByVal ThisIdAtm As Decimal)
        Da_Bank_AtmDtl.SelectCommand.Parameters(0).Value = ThisIdAtm
        DsFrmBankRegister1.bank_ATM_dtl.Clear()
        Da_Bank_AtmDtl.Fill(DsFrmBankRegister1.bank_ATM_dtl)
        GridSplit.DataMember = "bank_ATM_dtl"
        GridSplit.Visible = True
        GridSplit.Enabled = True
        GridSplit.Focus()
    End Sub

#End Region

#Region "Grid Split"
    Private Sub GridSplit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridSplit.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            GridSplit.Visible = False
            GridSplit.Enabled = False
        End If

    End Sub
    Private Sub GridSplit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSplit.Leave
        GridSplit.Visible = False
        GridSplit.Enabled = False
    End Sub
#End Region
    Private Sub CmdSplits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSplits.Click
        Try
            Select Case GrdDetail.GetRow.Cells(1).Value & ""
                Case "ATM"
                    If GrdDetail.GetRow.Cells(4).Value & "" = "-Split-" Then
                        'if cdec(
                        ShowSplitsATM(GrdDetail.GetRow.Cells(10).Value)
                    End If

                Case "CHK"
                    If GrdDetail.GetRow.Cells(4).Value & "" = "-Split-" Then
                        'if cdec(
                        ShowSplitsCheck(GrdDetail.GetRow.Cells(9).Value)
                    End If

            End Select

        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        MyfrmCheckScreen = New FrmCheckScreen
        Select Case GrdDetail.GetRow.Cells(1).Value & ""
            Case "CHK"
                If CDec("0" & GrdDetail.GetRow.Cells(9).Value) <> 0 Then
                    MyfrmCheckScreen = New FrmCheckScreen
                    MyfrmCheckScreen.LoadThis = GrdDetail.GetRow.Cells(9).Value
                    'frmbasemenu.SHOWMYFORM()
                    MyfrmCheckScreen.ShowDialog()
                    MyfrmCheckScreen = Nothing
                End If
            Case "ATM"
                MyFrmAtm = New FrmATMTransaction
                MyFrmAtm.LoadThis = GrdDetail.GetRow.Cells(10).Value
                MyFrmAtm.ShowDialog()
                MyFrmAtm = Nothing
            Case "ADJ"
                MyFrmAdj = New FrmBankAdjusTment
                With MyFrmAdj
                    .LoadThis = GrdDetail.GetRow.Cells(11).Value
                    .ShowDialog()
                    MyFrmAdj = Nothing
                End With
            Case "TRN"
                MyFrmBankTransfer = New UCBankAccount.FrmBankTransfer
                MyFrmBankTransfer.Id_TransferForShow = GrdDetail.GetRow.Cells(12).Value
                MyFrmBankTransfer.ShowDialog()
                MyFrmBankTransfer = Nothing
            Case "DEP"
                MyFrmBankDeposit = New UCBankAccount.FrmBankDeposits
                MyFrmBankDeposit.BankDepositHeadTempVar = GrdDetail.GetRow.Cells(13).Value
                MyFrmBankDeposit.ShowDialog()
                MyFrmBankDeposit = Nothing
        End Select
    End Sub
    Private Sub CmbBankAccount_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBankAccount.SelectedValueChanged
        Try
            Dim dr As DSFrmBankRegister.bas_banksRow = DsFrmBankRegister1.bas_banks.FindByid_bank(CmbBankAccount.SelectedValue)
            If Not dr Is Nothing Then
                TxtBankTelephone.Text = dr("phone_1") & ""
                ChkShared.Checked = dr.share_all_store
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub TxtFromDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtFromDate.TextChanged, TxtToDate.TextChanged
        CmdShow.Enabled = TxtFromDate.Text.Trim <> "" And TxtToDate.Text.Trim <> ""
    End Sub
    Function DecreaseType3(ByVal ThisId As Int64) As Decimal
        DecreaseType3 = 0
        Dim newds As New DataSet
        DaGlDebitDepositForBankRegisterType3.SelectCommand.Parameters(0).Value = ThisId
        DaGlDebitDepositForBankRegisterType3.Fill(newds, "t1")
        If newds.Tables("t1").Rows.Count > 0 Then
            DecreaseType3 = Val(newds.Tables("t1").Rows(0).Item("debit_amount") & "")
        End If
    End Function
    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        GrdDetail.ShowFieldChooser(Me)
    End Sub
End Class
