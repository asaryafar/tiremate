Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmVendorHistory
    Inherits FrmBase
    Dim PanelGridHeightVar As Integer
    Dim PanelColorHeightVar As Integer
    Dim FormHeightVar As Integer
    Public cod_vendorParameter As String
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
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents LblTotalAmountDue As System.Windows.Forms.Label
    Friend WithEvents LblTotalOriginalAmount As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PanelColors As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents chkOutsidePurchase As System.Windows.Forms.CheckBox
    Friend WithEvents ChkReceive As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBills As System.Windows.Forms.CheckBox
    Friend WithEvents ChkChecks As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents LblCompany As System.Windows.Forms.TextBox
    Public WithEvents LblCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DsFrmVendorHistory1 As UCVendor.DSFrmVendorHistory
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DAbank_check As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_AP_bill_Dtl_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Receive_product_Ap_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_out_purchases As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVendorHistory))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PanelGrid = New System.Windows.Forms.Panel
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmVendorHistory1 = New UCVendor.DSFrmVendorHistory
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblTotalAmountDue = New System.Windows.Forms.Label
        Me.LblTotalOriginalAmount = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.PanelColors = New System.Windows.Forms.Panel
        Me.ChkChecks = New System.Windows.Forms.CheckBox
        Me.ChkBills = New System.Windows.Forms.CheckBox
        Me.ChkReceive = New System.Windows.Forms.CheckBox
        Me.chkOutsidePurchase = New System.Windows.Forms.CheckBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblCompany = New System.Windows.Forms.TextBox
        Me.LblCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DAbank_check = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_AP_bill_Dtl_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Receive_product_Ap_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_out_purchases = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.PanelGrid.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmVendorHistory1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelColors.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.GrdDetail)
        Me.PanelGrid.Controls.Add(Me.Panel3)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelGrid.Location = New System.Drawing.Point(0, 85)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(642, 328)
        Me.PanelGrid.TabIndex = 449
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BackColor = System.Drawing.SystemColors.Control
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>VendorBalace</Caption><Columns Collection=""" & _
        "true""><Column0 ID=""Ref_No""><Caption>Ref No.</Caption><TypeNameEmptyStringValue>S" & _
        "ystem.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>Ref_No</D" & _
        "ataMember><Key>Ref_No</Key><Position>0</Position></Column0><Column1 ID=""Ref_Desc" & _
        """><Caption>Description</Caption><DataMember>Ref_Desc</DataMember><EditType>NoEdi" & _
        "t</EditType><FilterEditType>TextBox</FilterEditType><Key>Ref_Desc</Key><Position" & _
        ">1</Position><Width>238</Width></Column1><Column2 ID=""Ref_Date""><Caption>Ref Dat" & _
        "e</Caption><DataMember>Ref_Date</DataMember><Key>Ref_Date</Key><Position>2</Posi" & _
        "tion><Width>81</Width></Column2><Column3 ID=""amount""><Caption>Amount</Caption><T" & _
        "ypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><Data" & _
        "Member>amount</DataMember><FormatString>c2</FormatString><Key>amount</Key><Posit" & _
        "ion>3</Position><TextAlignment>Far</TextAlignment></Column3><Column4 ID=""due_dat" & _
        "e""><Caption>Due Date</Caption><TypeNameEmptyStringValue>System.String</TypeNameE" & _
        "mptyStringValue><EmptyStringValue /><DataMember>due_date</DataMember><Key>due_da" & _
        "te</Key><Position>4</Position><Width>79</Width></Column4><Column5 ID=""TypeOfReco" & _
        "rd""><Caption>TypeOfRecord</Caption><DataMember>TypeOfRecord</DataMember><Key>Typ" & _
        "eOfRecord</Key><Position>5</Position><Visible>False</Visible></Column5><Column6 " & _
        "ID=""Id_AP_bill_Head""><Caption>Id_AP_bill_Head</Caption><DataMember>Id_AP_bill_He" & _
        "ad</DataMember><Key>Id_AP_bill_Head</Key><Position>6</Position><Visible>False</V" & _
        "isible></Column6><Column7 ID=""SortOrder""><Caption>SortOrder</Caption><DataMember" & _
        ">SortOrder</DataMember><Key>SortOrder</Key><Position>7</Position><Visible>False<" & _
        "/Visible></Column7></Columns><GroupCondition ID="""" /><Key>VendorBalace</Key><Sor" & _
        "tKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>7</ColIndex><SortOrder" & _
        ">Descending</SortOrder></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 1)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(642, 327)
        Me.GrdDetail.TabIndex = 449
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmVendorHistory1.VendorBalace
        '
        'DsFrmVendorHistory1
        '
        Me.DsFrmVendorHistory1.DataSetName = "DSFrmVendorHistory"
        Me.DsFrmVendorHistory1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LblTotalAmountDue)
        Me.Panel3.Controls.Add(Me.LblTotalOriginalAmount)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(581, 58)
        Me.Panel3.TabIndex = 450
        Me.Panel3.Visible = False
        '
        'LblTotalAmountDue
        '
        Me.LblTotalAmountDue.BackColor = System.Drawing.SystemColors.Window
        Me.LblTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalAmountDue.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotalAmountDue.ForeColor = System.Drawing.Color.Black
        Me.LblTotalAmountDue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalAmountDue.Location = New System.Drawing.Point(292, -1)
        Me.LblTotalAmountDue.Name = "LblTotalAmountDue"
        Me.LblTotalAmountDue.Size = New System.Drawing.Size(104, 20)
        Me.LblTotalAmountDue.TabIndex = 348
        Me.LblTotalAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalOriginalAmount
        '
        Me.LblTotalOriginalAmount.BackColor = System.Drawing.SystemColors.Window
        Me.LblTotalOriginalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalOriginalAmount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotalOriginalAmount.ForeColor = System.Drawing.Color.Black
        Me.LblTotalOriginalAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalOriginalAmount.Location = New System.Drawing.Point(188, -1)
        Me.LblTotalOriginalAmount.Name = "LblTotalOriginalAmount"
        Me.LblTotalOriginalAmount.Size = New System.Drawing.Size(106, 20)
        Me.LblTotalOriginalAmount.TabIndex = 347
        Me.LblTotalOriginalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'PanelColors
        '
        Me.PanelColors.Controls.Add(Me.ChkChecks)
        Me.PanelColors.Controls.Add(Me.ChkBills)
        Me.PanelColors.Controls.Add(Me.ChkReceive)
        Me.PanelColors.Controls.Add(Me.chkOutsidePurchase)
        Me.PanelColors.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelColors.Location = New System.Drawing.Point(0, 413)
        Me.PanelColors.Name = "PanelColors"
        Me.PanelColors.Size = New System.Drawing.Size(642, 28)
        Me.PanelColors.TabIndex = 450
        '
        'ChkChecks
        '
        Me.ChkChecks.BackColor = System.Drawing.Color.LightBlue
        Me.ChkChecks.Checked = True
        Me.ChkChecks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkChecks.Location = New System.Drawing.Point(504, 4)
        Me.ChkChecks.Name = "ChkChecks"
        Me.ChkChecks.Size = New System.Drawing.Size(114, 20)
        Me.ChkChecks.TabIndex = 456
        Me.ChkChecks.Text = "Checks"
        '
        'ChkBills
        '
        Me.ChkBills.BackColor = System.Drawing.Color.LightGreen
        Me.ChkBills.Checked = True
        Me.ChkBills.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBills.Location = New System.Drawing.Point(344, 4)
        Me.ChkBills.Name = "ChkBills"
        Me.ChkBills.Size = New System.Drawing.Size(114, 20)
        Me.ChkBills.TabIndex = 455
        Me.ChkBills.Text = "Bills"
        '
        'ChkReceive
        '
        Me.ChkReceive.BackColor = System.Drawing.Color.Pink
        Me.ChkReceive.Checked = True
        Me.ChkReceive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkReceive.Location = New System.Drawing.Point(184, 4)
        Me.ChkReceive.Name = "ChkReceive"
        Me.ChkReceive.Size = New System.Drawing.Size(114, 20)
        Me.ChkReceive.TabIndex = 454
        Me.ChkReceive.Text = "Receive"
        '
        'chkOutsidePurchase
        '
        Me.chkOutsidePurchase.BackColor = System.Drawing.Color.Khaki
        Me.chkOutsidePurchase.Checked = True
        Me.chkOutsidePurchase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOutsidePurchase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkOutsidePurchase.Location = New System.Drawing.Point(24, 4)
        Me.chkOutsidePurchase.Name = "chkOutsidePurchase"
        Me.chkOutsidePurchase.Size = New System.Drawing.Size(114, 20)
        Me.chkOutsidePurchase.TabIndex = 453
        Me.chkOutsidePurchase.Text = "Outside Purchase"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(642, 49)
        Me.Panel4.TabIndex = 451
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 47)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "By double clicking the Selected row , you can see the detail."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblCompany)
        Me.Panel1.Controls.Add(Me.LblCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(7, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 36)
        Me.Panel1.TabIndex = 452
        '
        'LblCompany
        '
        Me.LblCompany.BackColor = System.Drawing.Color.Gold
        Me.LblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompany.Location = New System.Drawing.Point(256, 8)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.ReadOnly = True
        Me.LblCompany.Size = New System.Drawing.Size(326, 20)
        Me.LblCompany.TabIndex = 425
        Me.LblCompany.Text = ""
        '
        'LblCode
        '
        Me.LblCode.BackColor = System.Drawing.Color.Gold
        Me.LblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCode.Location = New System.Drawing.Point(90, 7)
        Me.LblCode.Name = "LblCode"
        Me.LblCode.ReadOnly = True
        Me.LblCode.Size = New System.Drawing.Size(81, 20)
        Me.LblCode.TabIndex = 424
        Me.LblCode.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(188, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 334
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(0, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Vendor Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DAbank_check
        '
        Me.DAbank_check.SelectCommand = Me.SqlSelectCommand2
        Me.DAbank_check.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT 4 AS TypeOfRecord, no_of_check AS Ref_No, amount_check AS amount, '' AS du" & _
        "e_date, date_of_check AS Ref_Date, address_payee AS Ref_Desc, '' AS Id_AP_bill_H" & _
        "ead, SUBSTRING(date_of_check + '', 7, 4) + SUBSTRING(date_of_check + '', 1, 2) +" & _
        " SUBSTRING(date_of_check + '', 4, 2) + no_of_check AS SortOrder FROM bank_check " & _
        "WHERE (cod_vendor = @cod_vendor)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAGL_AP_bill_Dtl_Dtl
        '
        Me.DAGL_AP_bill_Dtl_Dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_AP_bill_Dtl_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT 3 AS TypeOfRecord, GL_AP_bill_Dtl.ref_no AS Ref_No, GL_AP_bill_Dtl_Dtl.amo" & _
        "unt, GL_AP_bill_Dtl_Dtl.due_date, GL_AP_Bill_Head.Date_Bill AS Ref_Date, GL_AP_b" & _
        "ill_Dtl.Desc_Bill AS Ref_Desc, GL_AP_Bill_Head.Id_AP_bill_Head, SUBSTRING(GL_AP_" & _
        "Bill_Head.Date_Bill + '', 7, 4) + SUBSTRING(GL_AP_Bill_Head.Date_Bill + '', 1, 2" & _
        ") + SUBSTRING(GL_AP_Bill_Head.Date_Bill + '', 4, 2) + GL_AP_bill_Dtl.ref_no AS S" & _
        "ortOrder FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl" & _
        ".Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL" & _
        "_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head WHERE (GL_AP_Bill" & _
        "_Head.cod_vendor = @cod_vendor)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAInv_Receive_product_Ap_Dtl
        '
        Me.DAInv_Receive_product_Ap_Dtl.SelectCommand = Me.SqlSelectCommand4
        Me.DAInv_Receive_product_Ap_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_Ap_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT 2 AS TypeOfRecord, Inv_Receive_Products_head.id_receive_ref AS Ref_No, 'Re" & _
        "ceive Product' AS Ref_Desc, Inv_Receive_Products_head.date_receive AS Ref_Date, " & _
        "Inv_Receive_product_Ap_Dtl.amount, Inv_Receive_product_Ap_Dtl.due_date, '' AS Id" & _
        "_AP_bill_Head, SUBSTRING(Inv_Receive_Products_head.date_receive + '', 7, 4) + SU" & _
        "BSTRING(Inv_Receive_Products_head.date_receive + '', 1, 2) + SUBSTRING(Inv_Recei" & _
        "ve_Products_head.date_receive + '', 4, 2) + Inv_Receive_Products_head.id_receive" & _
        "_ref AS SortOrder FROM Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Product" & _
        "s_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head." & _
        "id_receive_ref WHERE (Inv_Receive_Products_head.cod_vendor = @cod_vendor) AND (I" & _
        "nv_Receive_Products_head.bill_credit = 1)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAservice_out_purchases
        '
        Me.DAservice_out_purchases.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_out_purchases.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value"), New System.Data.Common.DataColumnMapping("Line", "Line")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT 1 AS TypeOfRecord, service_out_purchases.id_service_center AS Ref_No, 'Out" & _
        "side Purchase' AS Ref_Desc, service_center_dtl.qty * (service_out_purchases.cost" & _
        " + service_out_purchases.fet) AS Amount, service_out_purchases.invoice_date AS R" & _
        "ef_Date, service_out_purchases.due_date, '' AS Id_AP_bill_Head, SUBSTRING(servic" & _
        "e_out_purchases.invoice_date + '', 7, 4) + SUBSTRING(service_out_purchases.invoi" & _
        "ce_date + '', 1, 2) + SUBSTRING(service_out_purchases.invoice_date + '', 4, 2) +" & _
        " service_out_purchases.id_service_center AS SortOrder FROM service_out_purchases" & _
        " INNER JOIN service_center_head ON service_out_purchases.id_service_center = ser" & _
        "vice_center_head.id_service_center INNER JOIN service_center_dtl ON service_out_" & _
        "purchases.id_service_center = service_center_dtl.id_service_center AND service_o" & _
        "ut_purchases.radif = service_center_dtl.radif WHERE (service_out_purchases.cod_v" & _
        "endor = @cod_vendor) AND (service_center_head.type_of_form = 'IN')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'FrmVendorHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(642, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.PanelColors)
        Me.Name = "FrmVendorHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendor History"
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmVendorHistory1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PanelColors.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCustomerBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PanelGridHeightVar = PanelGrid.Height
        'PanelColorHeightVar = PanelColors.Height
        'FormHeightVar = Me.Height
        'PanelGrid.Height = 0
        'PanelColors.Height = 0
        'Me.Height = FormHeightVar - PanelGridHeightVar - PanelColorHeightVar

        LblCode.Text = cod_vendorParameter

        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        Call AddConditionalFormatting()

        Call FillDataSet()

    End Sub
    Private Sub FillDataSet()

        DsFrmVendorHistory1.Clear()
        DAGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAGL_AP_bill_Dtl_Dtl.Fill(DsFrmVendorHistory1, "VendorBalace")

        DAInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAInv_Receive_product_Ap_Dtl.Fill(DsFrmVendorHistory1, "VendorBalace")

        DAservice_out_purchases.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAservice_out_purchases.Fill(DsFrmVendorHistory1, "VendorBalace")

        DAbank_check.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAbank_check.Fill(DsFrmVendorHistory1, "VendorBalace")

        DsFrmVendorHistory1.VendorBalace.DefaultView.Sort = "Ref_Date,Ref_No"

    End Sub
    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Height = FormHeightVar
        PanelGrid.Height = PanelGridHeightVar
        PanelColors.Height = PanelColorHeightVar
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 1)
        fc.FormatStyle.BackColor = Color.Khaki
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 2)
        fc.FormatStyle.BackColor = Color.Pink
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 3)
        fc.FormatStyle.BackColor = Color.LightGreen
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 4)
        fc.FormatStyle.BackColor = Color.LightBlue
        GrdDetail.RootTable.FormatConditions.Add(fc)
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        If GrdDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdDetail.GetRow
            Select Case Currentrow.Cells("TypeOfRecord").Value
                Case 1 ' Outside Purchase
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("Ref_No").Value & ""
                    MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                    MyFrmShowWorkOrder.ShowDialog()
                Case 2 ' Recieve
                    'Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    'MyFrmShowWorkOrder.TypeOfForm = "RT"
                    'MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("Ref_No").Value & ""
                    'MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                    'MyFrmShowWorkOrder.ShowDialog()
                Case 3 ' Ap Bill
                    Dim MyFrmGL_AP_bill As New FrmGL_AP_bill
                    MyFrmGL_AP_bill.Id_AP_bill_HeadForShowReadOnly = Currentrow.Cells("Id_AP_bill_Head").Value & ""
                    MyFrmGL_AP_bill.StartPosition = FormStartPosition.CenterScreen
                    MyFrmGL_AP_bill.ShowDialog()
            End Select
        End If
    End Sub
    Private Sub chkOutsidePurchase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOutsidePurchase.CheckedChanged, ChkReceive.CheckedChanged, ChkBills.CheckedChanged, ChkChecks.CheckedChanged
        DataView1.RowFilter = ""
        If Not chkOutsidePurchase.Checked Then
            DataView1.RowFilter = "TypeOfRecord<>1 "
        End If
        If Not ChkReceive.Checked Then
            DataView1.RowFilter = DataView1.RowFilter & IIf(DataView1.RowFilter.Trim.Length = 0, "", " AND ") & " TypeOfRecord<>2 "
        End If
        If Not ChkBills.Checked Then
            DataView1.RowFilter = DataView1.RowFilter & IIf(DataView1.RowFilter.Trim.Length = 0, "", " AND ") & " TypeOfRecord<>3 "
        End If
        If Not ChkChecks.Checked Then
            DataView1.RowFilter = DataView1.RowFilter & IIf(DataView1.RowFilter.Trim.Length = 0, "", " AND ") & " TypeOfRecord<>4 "
        End If
    End Sub
End Class
