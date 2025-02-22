Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmApPayment
    Inherits FrmBase
    Dim WithEvents myfrmsearch As FrmSearchApPayment
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
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnFax As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Daservice_out_purchases As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_AP_bill_Dtl_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmApPayment1 As UcAccount.DSFrmApPayment
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_AP_payment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInv_Receive_product_Ap_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_AP_paymentEdit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Daservice_out_purchasesEdit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_AP_bill_Dtl_DtlEdit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInv_Receive_product_Ap_DtlEdit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdCalculate As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaDate As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbDate As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblSumAmountDue As System.Windows.Forms.Label
    Friend WithEvents LblSumPayment As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblVendorName As System.Windows.Forms.Label
    Friend WithEvents ChkPayByCreadit As System.Windows.Forms.CheckBox
    Friend WithEvents LblCreadit As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DaViewGlGL_vendor_credit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmApPayment))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlHead = New System.Windows.Forms.Panel
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnFax = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmApPayment1 = New UcAccount.DSFrmApPayment
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Daservice_out_purchases = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_AP_bill_Dtl_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_AP_payment = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaInv_Receive_product_Ap_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_AP_paymentEdit = New System.Data.SqlClient.SqlDataAdapter
        Me.Daservice_out_purchasesEdit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaInv_Receive_product_Ap_DtlEdit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_AP_bill_Dtl_DtlEdit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.CmdCalculate = New System.Windows.Forms.Button
        Me.CmbDate = New System.Windows.Forms.ComboBox
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaDate = New System.Data.SqlClient.SqlDataAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblSumAmountDue = New System.Windows.Forms.Label
        Me.LblSumPayment = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmdExit = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblVendorName = New System.Windows.Forms.Label
        Me.ChkPayByCreadit = New System.Windows.Forms.CheckBox
        Me.DaViewGlGL_vendor_credit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.LblCreadit = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PnlHead.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmApPayment1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHead.Controls.Add(Me.Label31)
        Me.PnlHead.Controls.Add(Me.Label30)
        Me.PnlHead.Controls.Add(Me.Label29)
        Me.PnlHead.Controls.Add(Me.Label28)
        Me.PnlHead.Controls.Add(Me.BtnEmail)
        Me.PnlHead.Controls.Add(Me.BtnFax)
        Me.PnlHead.Controls.Add(Me.BtnPrint)
        Me.PnlHead.Controls.Add(Me.BtnPreview)
        Me.PnlHead.Controls.Add(Me.Label42)
        Me.PnlHead.Controls.Add(Me.BtnCancel)
        Me.PnlHead.Controls.Add(Me.Label43)
        Me.PnlHead.Controls.Add(Me.BtnEdit)
        Me.PnlHead.Controls.Add(Me.Label50)
        Me.PnlHead.Controls.Add(Me.Label52)
        Me.PnlHead.Controls.Add(Me.Label53)
        Me.PnlHead.Controls.Add(Me.BtnNew)
        Me.PnlHead.Controls.Add(Me.BtnFind)
        Me.PnlHead.Controls.Add(Me.BtnSave)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(0, 0)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(814, 45)
        Me.PnlHead.TabIndex = 144
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(325, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 10)
        Me.Label31.TabIndex = 204
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(293, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 10)
        Me.Label30.TabIndex = 203
        Me.Label30.Text = "Fax"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(253, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(211, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 201
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(325, 0)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 200
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(293, 0)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 199
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(253, 0)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 198
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(219, 0)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 197
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(176, 32)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(42, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(176, 0)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(96, 32)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 10)
        Me.Label43.TabIndex = 184
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(96, 0)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(136, 32)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(56, 32)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(8, 32)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 10)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(56, 0)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(8, 0)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(136, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(68, 49)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(118, 24)
        Me.Vendor_Cod1.TabIndex = 345
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(8, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 21)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "Vendor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GridRecord"
        Me.GrdDetail.DataSource = Me.DsFrmApPayment1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Invoices</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Check""><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><" & _
        "EmptyStringValue /><ColumnType>CheckBox</ColumnType><DataMember>CheckFlag</DataM" & _
        "ember><EditType>CheckBox</EditType><Key>Check</Key><Position>0</Position><Width>" & _
        "31</Width><CellStyle><BackColor>Info</BackColor></CellStyle></Column0><Column1 I" & _
        "D=""Date""><Caption>Date</Caption><DataMember>Date</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>Date</Key><Position>1</Posi" & _
        "tion><Width>84</Width></Column1><Column2 ID=""Refrenceno""><Caption>Refrence no</C" & _
        "aption><DataMember>Refrenceno</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>Refrenceno</Key><Position>2</Position></Column" & _
        "2><Column3 ID=""OriginalAmount""><Caption>Original Amount</Caption><DataMember>Ori" & _
        "ginalAmount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><FormatString>c2</FormatString><InputMask>Currency2</InputMask><Key>O" & _
        "riginalAmount</Key><MaskPrompt>&#x0;</MaskPrompt><Position>3</Position><Width>93" & _
        "</Width></Column3><Column4 ID=""PaiedBefore""><Caption>Amount Paid</Caption><DataM" & _
        "ember>PaiedBefore</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><FormatString>c2</FormatString><InputMask>Currency2</InputMask>" & _
        "<Key>PaiedBefore</Key><Position>4</Position></Column4><Column5 ID=""AmountDue""><C" & _
        "aption>Amount Due</Caption><DataMember>AmountDue</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><" & _
        "InputMask>Currency2</InputMask><Key>AmountDue</Key><MaskPrompt>&#x0;</MaskPrompt" & _
        "><Position>5</Position><Width>92</Width></Column5><Column6 ID=""DueDate""><Caption" & _
        ">Due Date</Caption><DataMember>DueDate</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>DueDate</Key><Position>6</Position></" & _
        "Column6><Column7 ID=""Payment""><Caption>Payment</Caption><DataMember>AmountPay</D" & _
        "ataMember><FormatString>c2</FormatString><Key>Payment</Key><MaskPrompt>&#x0;</Ma" & _
        "skPrompt><Position>7</Position><Width>85</Width><CellStyle><BackColor>Info</Back" & _
        "Color></CellStyle></Column7><Column8 ID=""ID_AP_payment""><Caption>ID_AP_payment</" & _
        "Caption><DataMember>ID_AP_payment</DataMember><Key>ID_AP_payment</Key><Position>" & _
        "8</Position><Selectable>False</Selectable><Visible>False</Visible></Column8><Col" & _
        "umn9 ID=""Radif""><Caption>Radif</Caption><DataMember>Radif</DataMember><Key>Radif" & _
        "</Key><Position>9</Position><Selectable>False</Selectable><Visible>False</Visibl" & _
        "e></Column9><Column10 ID=""Remark""><Caption>Remark</Caption><DataMember>Remark</D" & _
        "ataMember><Key>Remark</Key><Position>10</Position></Column10><Column11 ID=""Paied" & _
        "Before2""><Caption>PaiedBefore2</Caption><DataMember>PaiedBefore2</DataMember><Ke" & _
        "y>PaiedBefore2</Key><Position>11</Position><Visible>False</Visible></Column11></" & _
        "Columns><GroupCondition ID="""" /><Key>Invoices</Key></RootTable></GridEXLayoutDat" & _
        "a>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(4, 112)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(804, 328)
        Me.GrdDetail.TabIndex = 349
        '
        'DsFrmApPayment1
        '
        Me.DsFrmApPayment1.DataSetName = "DSFrmApPayment"
        Me.DsFrmApPayment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT service_out_purchases.radif, service_out_purchases.cost AS amount, service" & _
        "_out_purchases.due_date, service_out_purchases.id_service_center, service_center" & _
        "_head.date_refer AS DateTransaction, View_AllUnPaidService_out_purchase.sumorigi" & _
        "nalamount, View_AllUnPaidService_out_purchase.sumpayment FROM service_out_purcha" & _
        "ses INNER JOIN service_center_head ON service_out_purchases.id_service_center = " & _
        "service_center_head.id_service_center INNER JOIN View_AllUnPaidService_out_purch" & _
        "ase ON service_out_purchases.id_service_center = View_AllUnPaidService_out_purch" & _
        "ase.id_service_center AND service_out_purchases.radif = View_AllUnPaidService_ou" & _
        "t_purchase.radif WHERE (service_out_purchases.cod_vendor = @cod_vendor) AND ((se" & _
        "rvice_out_purchases.id_service_center + STR(service_out_purchases.radif)) IN (SE" & _
        "LECT id_service_center + str(radif) FROM View_AllUnPaidService_out_purchase)) AN" & _
        "D (dbo.ChangeDate(service_center_head.date_refer) <= @ThisDate) AND (service_cen" & _
        "ter_head.type_of_form = 'IN') AND (View_AllUnPaidService_out_purchase.sumorigina" & _
        "lamount <> View_AllUnPaidService_out_purchase.sumpayment)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'Daservice_out_purchases
        '
        Me.Daservice_out_purchases.SelectCommand = Me.SqlSelectCommand2
        Me.Daservice_out_purchases.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value"), New System.Data.Common.DataColumnMapping("Line", "Line")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl, " & _
        "GL_AP_bill_Dtl_Dtl.amount, GL_AP_bill_Dtl_Dtl.due_date, GL_AP_Bill_Head.Date_Bil" & _
        "l AS DateTransaction, GL_AP_Bill_Head.Id_AP_bill_Head, View_AllUnPaidGl_Ap_Bill_" & _
        "Dtl_Dtl.sumpayment, View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount FROM GL_A" & _
        "P_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = " & _
        "GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP" & _
        "_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN View_AllUnPaidGl_Ap_Bill" & _
        "_Dtl_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = View_AllUnPaidGl_Ap_Bill_Dtl" & _
        "_Dtl.Id_AP_bill_dtl_dtl WHERE (GL_AP_Bill_Head.cod_vendor = @cod_vendor) AND (GL" & _
        "_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl IN (SELECT id_ap_bill_dtl_dtl FROM View_AllU" & _
        "nPaidGl_Ap_Bill_Dtl_Dtl)) AND (dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill) <= @thi" & _
        "sDate) AND (View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount <> View_AllUnPaid" & _
        "Gl_Ap_Bill_Dtl_Dtl.sumpayment)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@thisDate", System.Data.SqlDbType.VarChar))
        '
        'DaGL_AP_bill_Dtl_Dtl
        '
        Me.DaGL_AP_bill_Dtl_Dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DaGL_AP_bill_Dtl_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT ID_AP_payment, Id_AP_bill_dtl_dtl, ID_Inv_Receive_product_Ap_Dtl, id_servi" & _
        "ce_center, radif, amount_pay, remark, date_prepare, id_check, radif1 FROM GL_AP_" & _
        "payment"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO GL_AP_payment(Id_AP_bill_dtl_dtl, ID_Inv_Receive_product_Ap_Dtl, id_s" & _
        "ervice_center, radif, amount_pay, remark, date_prepare, id_check, radif1) VALUES" & _
        " (@Id_AP_bill_dtl_dtl, @ID_Inv_Receive_product_Ap_Dtl, @id_service_center, @radi" & _
        "f, @amount_pay, @remark, @date_prepare, @id_check, @radif1); SELECT ID_AP_paymen" & _
        "t, Id_AP_bill_dtl_dtl, ID_Inv_Receive_product_Ap_Dtl, id_service_center, radif, " & _
        "amount_pay, remark, date_prepare, id_check, radif1 FROM GL_AP_payment WHERE (ID_" & _
        "AP_payment = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, "Id_AP_bill_dtl_dtl"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, "ID_Inv_Receive_product_Ap_Dtl"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_pay", System.Data.SqlDbType.Money, 8, "amount_pay"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 50, "remark"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_prepare", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif1", System.Data.SqlDbType.SmallInt, 2, "radif1"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE GL_AP_payment SET Id_AP_bill_dtl_dtl = @Id_AP_bill_dtl_dtl, ID_Inv_Receive" & _
        "_product_Ap_Dtl = @ID_Inv_Receive_product_Ap_Dtl, id_service_center = @id_servic" & _
        "e_center, radif = @radif, amount_pay = @amount_pay, remark = @remark, date_prepa" & _
        "re = @date_prepare, id_check = @id_check, radif1 = @radif1 WHERE (ID_AP_payment " & _
        "= @Original_ID_AP_payment) AND (ID_Inv_Receive_product_Ap_Dtl = @Original_ID_Inv" & _
        "_Receive_product_Ap_Dtl OR @Original_ID_Inv_Receive_product_Ap_Dtl IS NULL AND I" & _
        "D_Inv_Receive_product_Ap_Dtl IS NULL) AND (Id_AP_bill_dtl_dtl = @Original_Id_AP_" & _
        "bill_dtl_dtl OR @Original_Id_AP_bill_dtl_dtl IS NULL AND Id_AP_bill_dtl_dtl IS N" & _
        "ULL) AND (amount_pay = @Original_amount_pay) AND (date_prepare = @Original_date_" & _
        "prepare) AND (id_check = @Original_id_check OR @Original_id_check IS NULL AND id" & _
        "_check IS NULL) AND (id_service_center = @Original_id_service_center OR @Origina" & _
        "l_id_service_center IS NULL AND id_service_center IS NULL) AND (radif = @Origina" & _
        "l_radif OR @Original_radif IS NULL AND radif IS NULL) AND (radif1 = @Original_ra" & _
        "dif1 OR @Original_radif1 IS NULL AND radif1 IS NULL) AND (remark = @Original_rem" & _
        "ark OR @Original_remark IS NULL AND remark IS NULL); SELECT ID_AP_payment, Id_AP" & _
        "_bill_dtl_dtl, ID_Inv_Receive_product_Ap_Dtl, id_service_center, radif, amount_p" & _
        "ay, remark, date_prepare, id_check, radif1 FROM GL_AP_payment WHERE (ID_AP_payme" & _
        "nt = @ID_AP_payment)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, "Id_AP_bill_dtl_dtl"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, "ID_Inv_Receive_product_Ap_Dtl"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_pay", System.Data.SqlDbType.Money, 8, "amount_pay"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 50, "remark"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_prepare", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif1", System.Data.SqlDbType.SmallInt, 2, "radif1"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_AP_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_AP_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Inv_Receive_product_Ap_Dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AP_bill_dtl_dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_pay", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_pay", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_prepare", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_prepare", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_AP_payment", System.Data.SqlDbType.Int, 4, "ID_AP_payment"))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM GL_AP_payment WHERE (ID_AP_payment = @Original_ID_AP_payment) AND (ID" & _
        "_Inv_Receive_product_Ap_Dtl = @Original_ID_Inv_Receive_product_Ap_Dtl OR @Origin" & _
        "al_ID_Inv_Receive_product_Ap_Dtl IS NULL AND ID_Inv_Receive_product_Ap_Dtl IS NU" & _
        "LL) AND (Id_AP_bill_dtl_dtl = @Original_Id_AP_bill_dtl_dtl OR @Original_Id_AP_bi" & _
        "ll_dtl_dtl IS NULL AND Id_AP_bill_dtl_dtl IS NULL) AND (amount_pay = @Original_a" & _
        "mount_pay) AND (date_prepare = @Original_date_prepare) AND (id_check = @Original" & _
        "_id_check OR @Original_id_check IS NULL AND id_check IS NULL) AND (id_service_ce" & _
        "nter = @Original_id_service_center OR @Original_id_service_center IS NULL AND id" & _
        "_service_center IS NULL) AND (radif = @Original_radif OR @Original_radif IS NULL" & _
        " AND radif IS NULL) AND (radif1 = @Original_radif1 OR @Original_radif1 IS NULL A" & _
        "ND radif1 IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AN" & _
        "D remark IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_AP_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_AP_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Inv_Receive_product_Ap_Dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AP_bill_dtl_dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_pay", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_pay", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_prepare", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_prepare", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGL_AP_payment
        '
        Me.DaGL_AP_payment.DeleteCommand = Me.SqlDeleteCommand3
        Me.DaGL_AP_payment.InsertCommand = Me.SqlInsertCommand3
        Me.DaGL_AP_payment.SelectCommand = Me.SqlSelectCommand4
        Me.DaGL_AP_payment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        Me.DaGL_AP_payment.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl, Inv_Receive_prod" & _
        "uct_Ap_Dtl.id_receive_ref, Inv_Receive_product_Ap_Dtl.amount, Inv_Receive_produc" & _
        "t_Ap_Dtl.due_date, Inv_Receive_Products_head.date_receive AS DateTransaction, Vi" & _
        "ew_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount, View_AllUnPaidReceive_prod" & _
        "uct_ap_Dtl.sumpayment FROM Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Pro" & _
        "ducts_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_h" & _
        "ead.id_receive_ref INNER JOIN View_AllUnPaidReceive_product_ap_Dtl ON Inv_Receiv" & _
        "e_Products_head.id_receive_ref = View_AllUnPaidReceive_product_ap_Dtl.id_receive" & _
        "_ref AND Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = View_AllUnPa" & _
        "idReceive_product_ap_Dtl.ID_Inv_Receive_product_Ap_Dtl WHERE (Inv_Receive_Produc" & _
        "ts_head.cod_vendor = @cod_vendor) AND (Inv_Receive_product_Ap_Dtl.id_receive_ref" & _
        " IN (SELECT id_receive_ref FROM View_AllUnPaidReceive_product_ap_Dtl)) AND (dbo." & _
        "ChangeDate(Inv_Receive_Products_head.date_receive) <= @thisDate) AND (View_AllUn" & _
        "PaidReceive_product_ap_Dtl.sumoriginalamount <> View_AllUnPaidReceive_product_ap" & _
        "_Dtl.sumpayment)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@thisDate", System.Data.SqlDbType.VarChar))
        '
        'DaInv_Receive_product_Ap_Dtl
        '
        Me.DaInv_Receive_product_Ap_Dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DaInv_Receive_product_Ap_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_Ap_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_AP_payment.ID_AP_payment, GL_AP_payment.Id_AP_bill_dtl_dtl, GL_AP_payme" & _
        "nt.ID_Inv_Receive_product_Ap_Dtl, GL_AP_payment.id_service_center, GL_AP_payment" & _
        ".radif, GL_AP_payment.amount_pay, GL_AP_payment.remark, GL_AP_payment.date_prepa" & _
        "re, GL_AP_payment.id_check, GL_AP_payment.radif1, Inv_Receive_Products_head.id_r" & _
        "eceive_ref, GL_AP_bill_Dtl.Id_AP_bill_Head FROM GL_AP_bill_Dtl INNER JOIN GL_AP_" & _
        "bill_Dtl_Dtl ON GL_AP_bill_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dt" & _
        "l RIGHT OUTER JOIN GL_AP_payment ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_A" & _
        "P_payment.Id_AP_bill_dtl_dtl LEFT OUTER JOIN Inv_Receive_Products_head INNER JOI" & _
        "N Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_R" & _
        "eceive_product_Ap_Dtl.id_receive_ref ON GL_AP_payment.ID_Inv_Receive_product_Ap_" & _
        "Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO GL_AP_payment(Id_AP_bill_dtl_dtl, ID_Inv_Receive_product_Ap_Dtl, id_s" & _
        "ervice_center, radif, amount_pay, remark, date_prepare, id_check, radif1) VALUES" & _
        " (@Id_AP_bill_dtl_dtl, @ID_Inv_Receive_product_Ap_Dtl, @id_service_center, @radi" & _
        "f, @amount_pay, @remark, @date_prepare, @id_check, @radif1); SELECT ID_AP_paymen" & _
        "t, Id_AP_bill_dtl_dtl, ID_Inv_Receive_product_Ap_Dtl, id_service_center, radif, " & _
        "amount_pay, remark, date_prepare, id_check, radif1 FROM GL_AP_payment WHERE (ID_" & _
        "AP_payment = @@IDENTITY)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, "Id_AP_bill_dtl_dtl"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, "ID_Inv_Receive_product_Ap_Dtl"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_pay", System.Data.SqlDbType.Money, 8, "amount_pay"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 50, "remark"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_prepare", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif1", System.Data.SqlDbType.SmallInt, 2, "radif1"))
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE GL_AP_payment SET Id_AP_bill_dtl_dtl = @Id_AP_bill_dtl_dtl, ID_Inv_Receive" & _
        "_product_Ap_Dtl = @ID_Inv_Receive_product_Ap_Dtl, id_service_center = @id_servic" & _
        "e_center, radif = @radif, amount_pay = @amount_pay, remark = @remark, date_prepa" & _
        "re = @date_prepare, id_check = @id_check, radif1 = @radif1 WHERE (ID_AP_payment " & _
        "= @Original_ID_AP_payment) AND (ID_Inv_Receive_product_Ap_Dtl = @Original_ID_Inv" & _
        "_Receive_product_Ap_Dtl OR @Original_ID_Inv_Receive_product_Ap_Dtl IS NULL AND I" & _
        "D_Inv_Receive_product_Ap_Dtl IS NULL) AND (Id_AP_bill_dtl_dtl = @Original_Id_AP_" & _
        "bill_dtl_dtl OR @Original_Id_AP_bill_dtl_dtl IS NULL AND Id_AP_bill_dtl_dtl IS N" & _
        "ULL) AND (amount_pay = @Original_amount_pay) AND (date_prepare = @Original_date_" & _
        "prepare) AND (id_check = @Original_id_check OR @Original_id_check IS NULL AND id" & _
        "_check IS NULL) AND (id_service_center = @Original_id_service_center OR @Origina" & _
        "l_id_service_center IS NULL AND id_service_center IS NULL) AND (radif = @Origina" & _
        "l_radif OR @Original_radif IS NULL AND radif IS NULL) AND (radif1 = @Original_ra" & _
        "dif1 OR @Original_radif1 IS NULL AND radif1 IS NULL) AND (remark = @Original_rem" & _
        "ark OR @Original_remark IS NULL AND remark IS NULL); SELECT ID_AP_payment, Id_AP" & _
        "_bill_dtl_dtl, ID_Inv_Receive_product_Ap_Dtl, id_service_center, radif, amount_p" & _
        "ay, remark, date_prepare, id_check, radif1 FROM GL_AP_payment WHERE (ID_AP_payme" & _
        "nt = @ID_AP_payment)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, "Id_AP_bill_dtl_dtl"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, "ID_Inv_Receive_product_Ap_Dtl"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_pay", System.Data.SqlDbType.Money, 8, "amount_pay"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 50, "remark"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_prepare", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif1", System.Data.SqlDbType.SmallInt, 2, "radif1"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_AP_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_AP_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Inv_Receive_product_Ap_Dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AP_bill_dtl_dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_pay", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_pay", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_prepare", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_prepare", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_AP_payment", System.Data.SqlDbType.Int, 4, "ID_AP_payment"))
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM GL_AP_payment WHERE (ID_AP_payment = @Original_ID_AP_payment) AND (ID" & _
        "_Inv_Receive_product_Ap_Dtl = @Original_ID_Inv_Receive_product_Ap_Dtl OR @Origin" & _
        "al_ID_Inv_Receive_product_Ap_Dtl IS NULL AND ID_Inv_Receive_product_Ap_Dtl IS NU" & _
        "LL) AND (Id_AP_bill_dtl_dtl = @Original_Id_AP_bill_dtl_dtl OR @Original_Id_AP_bi" & _
        "ll_dtl_dtl IS NULL AND Id_AP_bill_dtl_dtl IS NULL) AND (amount_pay = @Original_a" & _
        "mount_pay) AND (date_prepare = @Original_date_prepare) AND (id_check = @Original" & _
        "_id_check OR @Original_id_check IS NULL AND id_check IS NULL) AND (id_service_ce" & _
        "nter = @Original_id_service_center OR @Original_id_service_center IS NULL AND id" & _
        "_service_center IS NULL) AND (radif = @Original_radif OR @Original_radif IS NULL" & _
        " AND radif IS NULL) AND (radif1 = @Original_radif1 OR @Original_radif1 IS NULL A" & _
        "ND radif1 IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AN" & _
        "D remark IS NULL)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_AP_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_AP_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Inv_Receive_product_Ap_Dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AP_bill_dtl_dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_pay", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_pay", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_prepare", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_prepare", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGL_AP_paymentEdit
        '
        Me.DaGL_AP_paymentEdit.DeleteCommand = Me.SqlCommand1
        Me.DaGL_AP_paymentEdit.InsertCommand = Me.SqlCommand2
        Me.DaGL_AP_paymentEdit.SelectCommand = Me.SqlCommand3
        Me.DaGL_AP_paymentEdit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        Me.DaGL_AP_paymentEdit.UpdateCommand = Me.SqlCommand4
        '
        'Daservice_out_purchasesEdit
        '
        Me.Daservice_out_purchasesEdit.SelectCommand = Me.SqlCommand5
        Me.Daservice_out_purchasesEdit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value"), New System.Data.Common.DataColumnMapping("Line", "Line")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT service_out_purchases.radif, service_out_purchases.cost AS amount, service" & _
        "_out_purchases.due_date, service_out_purchases.id_service_center, service_center" & _
        "_head.date_refer AS DateTransaction, View_AllUnPaidService_out_purchase.sumorigi" & _
        "nalamount, View_AllUnPaidService_out_purchase.sumpayment, GL_AP_payment.amount_p" & _
        "ay, GL_AP_payment.remark, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_c" & _
        "redit FROM service_out_purchases INNER JOIN service_center_head ON service_out_p" & _
        "urchases.id_service_center = service_center_head.id_service_center INNER JOIN Vi" & _
        "ew_AllUnPaidService_out_purchase ON service_out_purchases.id_service_center = Vi" & _
        "ew_AllUnPaidService_out_purchase.id_service_center AND service_out_purchases.rad" & _
        "if = View_AllUnPaidService_out_purchase.radif INNER JOIN GL_AP_payment ON servic" & _
        "e_out_purchases.id_service_center = GL_AP_payment.id_service_center AND service_" & _
        "out_purchases.radif = GL_AP_payment.radif WHERE (service_out_purchases.cod_vendo" & _
        "r = @cod_vendor) AND ((service_out_purchases.id_service_center + STR(service_out" & _
        "_purchases.radif)) IN (SELECT id_service_center + str(radif) FROM View_AllUnPaid" & _
        "Service_out_purchase)) AND (service_center_head.type_of_form = 'IN') AND (dbo.Ch" & _
        "angeDate(GL_AP_payment.date_prepare) = @ThisDate) AND (GL_AP_payment.amount_pay " & _
        "> 0) AND (GL_AP_payment.id_check IS NULL)"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'DaInv_Receive_product_Ap_DtlEdit
        '
        Me.DaInv_Receive_product_Ap_DtlEdit.SelectCommand = Me.SqlCommand6
        Me.DaInv_Receive_product_Ap_DtlEdit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_Ap_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "SELECT Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl, Inv_Receive_prod" & _
        "uct_Ap_Dtl.id_receive_ref, Inv_Receive_product_Ap_Dtl.amount, Inv_Receive_produc" & _
        "t_Ap_Dtl.due_date, Inv_Receive_Products_head.date_receive AS DateTransaction, Vi" & _
        "ew_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount, View_AllUnPaidReceive_prod" & _
        "uct_ap_Dtl.sumpayment, GL_AP_payment.amount_pay, GL_AP_payment.remark, GL_AP_pay" & _
        "ment.ID_AP_payment, GL_AP_payment.id_vendor_credit FROM Inv_Receive_product_Ap_D" & _
        "tl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive" & _
        "_ref = Inv_Receive_Products_head.id_receive_ref INNER JOIN View_AllUnPaidReceive" & _
        "_product_ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = View_AllUnPaidRece" & _
        "ive_product_ap_Dtl.id_receive_ref AND Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_" & _
        "product_Ap_Dtl = View_AllUnPaidReceive_product_ap_Dtl.ID_Inv_Receive_product_Ap_" & _
        "Dtl INNER JOIN GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_produc" & _
        "t_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl WHERE (Inv_Receive_Produc" & _
        "ts_head.cod_vendor = @cod_vendor) AND (Inv_Receive_product_Ap_Dtl.id_receive_ref" & _
        " IN (SELECT id_receive_ref FROM View_AllUnPaidReceive_product_ap_Dtl)) AND (dbo." & _
        "ChangeDate(GL_AP_payment.date_prepare) = @thisDate) AND (GL_AP_payment.amount_pa" & _
        "y > 0) AND (GL_AP_payment.id_check IS NULL)"
        Me.SqlCommand6.Connection = Me.Cnn
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@thisDate", System.Data.SqlDbType.VarChar))
        '
        'DaGL_AP_bill_Dtl_DtlEdit
        '
        Me.DaGL_AP_bill_Dtl_DtlEdit.SelectCommand = Me.SqlCommand7
        Me.DaGL_AP_bill_Dtl_DtlEdit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "SELECT GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl, " & _
        "GL_AP_bill_Dtl_Dtl.amount, GL_AP_bill_Dtl_Dtl.due_date, GL_AP_Bill_Head.Date_Bil" & _
        "l AS DateTransaction, GL_AP_Bill_Head.Id_AP_bill_Head, View_AllUnPaidGl_Ap_Bill_" & _
        "Dtl_Dtl.sumpayment, View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount, GL_AP_pa" & _
        "yment.amount_pay, GL_AP_payment.remark, GL_AP_payment.ID_AP_payment, GL_AP_payme" & _
        "nt.id_vendor_credit FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_b" & _
        "ill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill" & _
        "_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER " & _
        "JOIN View_AllUnPaidGl_Ap_Bill_Dtl_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl =" & _
        " View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.Id_AP_bill_dtl_dtl INNER JOIN GL_AP_payment ON" & _
        " GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_AP_payment.Id_AP_bill_dtl_dtl WHERE " & _
        "(GL_AP_Bill_Head.cod_vendor = @cod_vendor) AND (GL_AP_bill_Dtl_Dtl.Id_AP_bill_dt" & _
        "l_dtl IN (SELECT id_ap_bill_dtl_dtl FROM View_AllUnPaidGl_Ap_Bill_Dtl_Dtl)) AND " & _
        "(dbo.ChangeDate(GL_AP_payment.date_prepare) <= @thisDate) AND (GL_AP_payment.amo" & _
        "unt_pay > 0) AND (GL_AP_payment.id_check IS NULL)"
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@thisDate", System.Data.SqlDbType.VarChar))
        '
        'CmdCalculate
        '
        Me.CmdCalculate.Location = New System.Drawing.Point(192, 79)
        Me.CmdCalculate.Name = "CmdCalculate"
        Me.CmdCalculate.Size = New System.Drawing.Size(88, 23)
        Me.CmdCalculate.TabIndex = 350
        Me.CmdCalculate.Text = "Calculate"
        '
        'CmbDate
        '
        Me.CmbDate.DataSource = Me.DsFrmApPayment1.GlDate
        Me.CmbDate.DisplayMember = "date_prepare"
        Me.CmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDate.Location = New System.Drawing.Point(68, 81)
        Me.CmbDate.Name = "CmbDate"
        Me.CmbDate.Size = New System.Drawing.Size(120, 21)
        Me.CmbDate.TabIndex = 351
        Me.CmbDate.ValueMember = "date_prepare"
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT DISTINCT * FROM (SELECT DISTINCT GL_AP_payment.date_prepare FROM GL_AP_pay" & _
        "ment INNER JOIN service_out_purchases ON GL_AP_payment.id_service_center = servi" & _
        "ce_out_purchases.id_service_center AND GL_AP_payment.radif = service_out_purchas" & _
        "es.radif WHERE cod_vendor = @Cod_Vendor UNION SELECT DISTINCT GL_AP_payment.date" & _
        "_prepare FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_payment ON GL_AP_bill_Dtl_Dtl." & _
        "Id_AP_bill_dtl_dtl = GL_AP_payment.Id_AP_bill_dtl_dtl INNER JOIN GL_AP_bill_Dtl " & _
        "ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
        "GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_H" & _
        "ead WHERE cod_vendor = @Cod_Vendor UNION SELECT DISTINCT GL_AP_payment.date_prep" & _
        "are FROM GL_AP_payment INNER JOIN Inv_Receive_product_Ap_Dtl ON GL_AP_payment.ID" & _
        "_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_" & _
        "Ap_Dtl INNER JOIN Inv_Receive_product_dtl ON Inv_Receive_product_Ap_Dtl.id_recei" & _
        "ve_ref = Inv_Receive_product_dtl.id_receive_ref INNER JOIN Inv_Receive_Products_" & _
        "head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id" & _
        "_receive_ref AND Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_h" & _
        "ead.id_receive_ref WHERE cod_vendor = @Cod_Vendor) delive"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Vendor", System.Data.SqlDbType.NVarChar))
        '
        'DaDate
        '
        Me.DaDate.SelectCommand = Me.SqlSelectCommand5
        Me.DaDate.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GlDate", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "Amount Due"
        '
        'LblSumAmountDue
        '
        Me.LblSumAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSumAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblSumAmountDue.ForeColor = System.Drawing.Color.Black
        Me.LblSumAmountDue.Location = New System.Drawing.Point(89, 445)
        Me.LblSumAmountDue.Name = "LblSumAmountDue"
        Me.LblSumAmountDue.Size = New System.Drawing.Size(127, 23)
        Me.LblSumAmountDue.TabIndex = 353
        '
        'LblSumPayment
        '
        Me.LblSumPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSumPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblSumPayment.ForeColor = System.Drawing.Color.Black
        Me.LblSumPayment.Location = New System.Drawing.Point(300, 445)
        Me.LblSumPayment.Name = "LblSumPayment"
        Me.LblSumPayment.Size = New System.Drawing.Size(115, 23)
        Me.LblSumPayment.TabIndex = 355
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(224, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 354
        Me.Label4.Text = "Payment"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(720, 456)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(88, 23)
        Me.CmdExit.TabIndex = 356
        Me.CmdExit.Text = "Exit"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(8, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblVendorName
        '
        Me.LblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVendorName.Location = New System.Drawing.Point(191, 48)
        Me.LblVendorName.Name = "LblVendorName"
        Me.LblVendorName.Size = New System.Drawing.Size(281, 24)
        Me.LblVendorName.TabIndex = 358
        '
        'ChkPayByCreadit
        '
        Me.ChkPayByCreadit.Location = New System.Drawing.Point(488, 48)
        Me.ChkPayByCreadit.Name = "ChkPayByCreadit"
        Me.ChkPayByCreadit.Size = New System.Drawing.Size(112, 24)
        Me.ChkPayByCreadit.TabIndex = 359
        Me.ChkPayByCreadit.Text = "Apply Credit"
        '
        'DaViewGlGL_vendor_credit
        '
        Me.DaViewGlGL_vendor_credit.InsertCommand = Me.SqlInsertCommand1
        Me.DaViewGlGL_vendor_credit.SelectCommand = Me.SqlSelectCommand6
        Me.DaViewGlGL_vendor_credit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_GL_vendor_creditReminder", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("SumCreadit", "SumCreadit"), New System.Data.Common.DataColumnMapping("SumPayment", "SumPayment"), New System.Data.Common.DataColumnMapping("Reminder", "Reminder"), New System.Data.Common.DataColumnMapping("id_vendor_credit", "id_vendor_credit")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO View_GL_vendor_creditReminder(cod_vendor, SumCreadit, SumPayment, Rem" & _
        "inder, id_vendor_credit) VALUES (@cod_vendor, @SumCreadit, @SumPayment, @Reminde" & _
        "r, @id_vendor_credit); SELECT cod_vendor, SumCreadit, SumPayment, Reminder, id_v" & _
        "endor_credit FROM View_GL_vendor_creditReminder"
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SumCreadit", System.Data.SqlDbType.Money, 8, "SumCreadit"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SumPayment", System.Data.SqlDbType.Money, 8, "SumPayment"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Reminder", System.Data.SqlDbType.Money, 8, "Reminder"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vendor_credit", System.Data.SqlDbType.Int, 4, "id_vendor_credit"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_vendor, SumCreadit, SumPayment, Reminder, id_vendor_credit FROM View_G" & _
        "L_vendor_creditReminder WHERE (cod_vendor = @ThisVendor)"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisVendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'LblCreadit
        '
        Me.LblCreadit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCreadit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCreadit.ForeColor = System.Drawing.Color.Black
        Me.LblCreadit.Location = New System.Drawing.Point(696, 71)
        Me.LblCreadit.Name = "LblCreadit"
        Me.LblCreadit.Size = New System.Drawing.Size(115, 23)
        Me.LblCreadit.TabIndex = 360
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(600, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 361
        Me.Label5.Text = "Credit Amount"
        '
        'FrmApPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(814, 484)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblCreadit)
        Me.Controls.Add(Me.ChkPayByCreadit)
        Me.Controls.Add(Me.LblVendorName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.LblSumPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblSumAmountDue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbDate)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Vendor_Cod1)
        Me.Controls.Add(Me.PnlHead)
        Me.Name = "FrmApPayment"
        Me.Text = "Payment"
        Me.PnlHead.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmApPayment1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmApPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        Call EnableDisableField(False)
        'Call PFirstRecord(False)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Ploadall()
    End Sub

#Region "AdNewEditSave"
    Sub Psave()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew
                Call psaveaddnew()
            Case MainModule.WorkStates.Edit
                Call psaveEdit()
        End Select
        Call PCancel()

    End Sub
    Sub psaveedit()
        Dim i As Integer = 0
        Dim tran1 As SqlClient.SqlTransaction
        If CmdGeneral.Connection.State = ConnectionState.Closed Then
            CmdGeneral.Connection.Open()
        End If
        tran1 = Cnn.BeginTransaction
        CmdGeneral.Transaction = tran1
        Try
            For i = 0 To DsFrmApPayment1.GridRecord.Rows.Count - 1
                With DsFrmApPayment1.GridRecord.Rows(i)
                    CmdGeneral.CommandText = "update GL_AP_payment set amount_pay = " & .Item("AmountPay") & ", remark =" & Qt(.Item("remark")) & " where ID_AP_payment= " & .Item("ID_AP_paymentEdit")
                    CmdGeneral.ExecuteNonQuery()

                End With
            Next
            tran1.Commit()
        Catch ex As Exception
            tran1.Rollback()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub psaveaddnew()
        Dim i As Integer = 0
        Dim tran1 As SqlClient.SqlTransaction
        If CmdGeneral.Connection.State = ConnectionState.Closed Then
            CmdGeneral.Connection.Open()
        End If
        tran1 = Cnn.BeginTransaction
        CmdGeneral.Transaction = tran1
        Try
            For i = 0 To DsFrmApPayment1.GridRecord.Rows.Count - 1
                With DsFrmApPayment1.GridRecord.Rows(i)
                    If .Item("AmountPay") <> 0 Then
                        Dim Id_AP_bill_dtl_dtl As Object = "Null"
                        Dim ID_Inv_Receive_product_Ap_Dtl As Object = "Null"
                        Dim id_service_center As Object = "Null"
                        Dim id_vendor_credit As Object = "NULL"
                        Dim Radif As Object = "Null"
                        Select Case .Item("RefrenceType")
                            Case "BL"
                                Id_AP_bill_dtl_dtl = .Item("Id_AP_bill_dtl_dtl")
                            Case "RR"
                                ID_Inv_Receive_product_Ap_Dtl = .Item("ID_Inv_Receive_product_Ap_Dtl")
                            Case "OP"
                                id_service_center = .Item("Refrenceno")
                                Radif = .Item("Radif")
                            Case Else
                                MsgBox("error")
                        End Select
                        If Val("" & .Item("id_vendor_credit")) <> 0 Then
                            id_vendor_credit = .Item("id_vendor_credit")
                        End If
                        If .Item("AmountPay") <= .Item("Amountdue") Then
                            CmdGeneral.CommandText = "insert into GL_AP_payment (date_prepare,Id_AP_bill_dtl_dtl,ID_Inv_Receive_product_Ap_Dtl,id_service_center,radif,amount_pay,remark,id_vendor_credit) values (" & Qt(Format(Now.Date, PubDateFormat)) & "," & Id_AP_bill_dtl_dtl & "," & ID_Inv_Receive_product_Ap_Dtl & "," & Qt(id_service_center) & "," & Radif & "," & .Item("AmountPay") & "," & Qt(.Item("remark")) & " , " & id_vendor_credit & " )"
                            CmdGeneral.ExecuteNonQuery()

                        End If
                    End If
                End With
            Next
            tran1.Commit()
        Catch ex As Exception
            tran1.Rollback()
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub Paddnew()
        ThisFormStatus = MainModule.WorkStates.AddNew
        Call EnableDisableField(True)
        Call EnableDisableBtn()
        Call ClearAllField()
        CmbDate.Enabled = False
        Vendor_Cod1.Focus()
    End Sub
    Sub PDelete()
        CmdGeneral.CommandText = "Delete from GL_AP_payment where ID_AP_payment = " & ""       'TxtRefrence_no.Text.Trim
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        ' If TxtRefrence_no.Text.Trim.Length > 0 Then
        ThisFormStatus = MainModule.WorkStates.Delete
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            '    Dim TxtRefTemp As String = TxtRefrence_no.Text
            ' If ClsRRP.DeleteThis(TxtRef.Text) Then
            Try
                CmdGeneral.ExecuteNonQuery()
               
            Catch ex As Exception

            End Try

        Else
        End If
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        '  End If
    End Sub

    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        Vendor_Cod1.Enabled = InStatus
        CmbDate.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        ChkPayByCreadit.Enabled = InStatus
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            '  TxtToDate.Enabled = InStatus
        Else
            ' TxtToDate.Enabled = False
        End If
    End Sub
    Private Sub EnableDisableBtn()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew, MainModule.WorkStates.Edit
                BtnEdit.Enabled = False
                BtnFind.Enabled = False
                BtnNew.Enabled = False
                BtnCancel.Enabled = True
                BtnSave.Enabled = False
                'BtnPreview.Enabled = False
                'BtnPrint.Enabled = False
            Case MainModule.WorkStates._ReadOnly
                BtnEdit.Enabled = True
                BtnNew.Enabled = True
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
                BtnFind.Enabled = True
                BtnPreview.Enabled = True
                BtnPrint.Enabled = True


        End Select
    End Sub
    Private Sub EnableDisableSave()
        Dim RowDetails As DataRow() = DsFrmApPayment1.GridRecord.Select("AmountPay > 0")
        If Vendor_Cod1.Text <> "" And RowDetails.Length > 0 Then
            If ChkPayByCreadit.Checked = True Then
                If Val("" & LblSumPayment.Text) <= Val("" & LblCreadit.Text) Then
                    BtnSave.Enabled = True
                    BtnPrint.Enabled = True
                Else
                    BtnSave.Enabled = False
                    BtnPrint.Enabled = False
                End If
            Else
                BtnSave.Enabled = True
                BtnPrint.Enabled = True
            End If

            ' BtnPreview.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Sub ClearAllField()
        DsFrmApPayment1.Clear()
        Vendor_Cod1.Text = ""
        LblCreadit.Text = ""
        LblSumPayment.Text = ""
        LblSumAmountDue.Text = ""
        'TxtToDate.Text = ""
    End Sub
#End Region
   
    Private Sub GrdDetail_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.RecordUpdated
        Call EnableDisableSave()
    End Sub
    Private Sub Vendor_Cod1_NotFindVendorCod() Handles Vendor_Cod1.NotFindVendorCod
        DsFrmApPayment1.GlDate.Clear()
        LblVendorName.Text = ""
        '        MsgFar("No Vendor Find")
        '       Vendor_Cod1.Focus()
        Call EnableDisableSave()
    End Sub

    Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            Dim ThisTableIDVar As Integer = CurrentRow.Cells("ID_AP_payment").Value
            Select Case e.Column.Index
                Case 0
                    If CurrentRow.Cells(0).Value = True Then
                        DsFrmApPayment1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 0
                        CurrentRow.Cells(7).Value = 0
                    Else
                        DsFrmApPayment1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 1
                        DsFrmApPayment1.GridRecord.Rows.Find(ThisTableIDVar).Item("AmountPay") = Math.Round(Val("" & CurrentRow.Cells(5).Value))
                        GrdDetail.UpdateData()
                        GrdDetail.Col = 7
                    End If
                End Select
        End If
        Call ClaculateSum()
    End Sub

#Region "Previos-Last-Frist"
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try

            If CmdGeneral.Connection.State = ConnectionState.Closed Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = " select  top 1 ID_AP_payment from GL_AP_payment ORDER BY id_check asc"


            ' If TxtRef.Text.Trim.Length > 0 Then
            Dim TXTRef_NoTmp As String = CmdGeneral.ExecuteScalar() & ""
            'If TXTRef_NoTmp = TxtRefrence_no.Text And TxtRefrence_no.Text.Trim & "" <> "" Then
            '    If ShowMsgFlag Then MsgFar("First Record")
            'Else
            Call LoadIt(TXTRef_NoTmp)
            '    End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub PLastRecord(Optional ByVal ShowMsgFlag As Boolean = True)
    '    Try

    '        If CmdGeneral.Connection.State = ConnectionState.Closed Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        CmdGeneral.CommandText = " select  top 1 ID_AP_payment from GL_AP_payment ORDER BY id_check desc"

    '        If TxtRefrence_no.Text.Trim.Length > 0 Then
    '            Dim TXTRef_NoTmp As String = CmdGeneral.ExecuteScalar() & ""
    '            If TXTRef_NoTmp = TxtRefrence_no.Text Then
    '                If ShowMsgFlag Then MsgFar("Last Record")
    '            Else
    '                Call LoadIt(TXTRef_NoTmp)
    '            End If
    '        Else
    '            MsgFar("There is no Row in Database")
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub PPreviousRecord(Optional ByVal ShowMsgFlag As Boolean = True)
    '    Try
    '        If CmdGeneral.Connection.State = ConnectionState.Closed Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        CmdGeneral.CommandText = " select  top 1 ID_AP_payment from GL_AP_payment WHERE ID_AP_payment >" & TxtRefrence_no.Text.Trim

    '        If TxtRefrence_no.Text.Trim.Length > 0 Then
    '            Dim TXTRef_NoTmp As String = CmdGeneral.ExecuteScalar() & ""
    '            If TXTRef_NoTmp.Trim = TxtRefrence_no.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
    '                If ShowMsgFlag Then MsgFar("First Record")
    '            Else
    '                Call LoadIt(TXTRef_NoTmp)
    '            End If
    '        Else
    '            MsgFar("There is no Row in Database")
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub PNextRecord(Optional ByVal ShowMsgFlag As Boolean = True)
    '    Try
    '        If CmdGeneral.Connection.State = ConnectionState.Closed Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        CmdGeneral.CommandText = " select  top 1 ID_AP_payment from GL_AP_payment WHERE ID_AP_payment <" & TxtRefrence_no.Text.Trim

    '        If TxtRefrence_no.Text.Trim.Length > 0 Then
    '            Dim TXTRef_NoTmp As String = CmdGeneral.ExecuteScalar() & ""
    '            If TXTRef_NoTmp.Trim = TxtRefrence_no.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
    '                If ShowMsgFlag Then MsgFar("Last Record")
    '            Else
    '                Call LoadIt(TXTRef_NoTmp)
    '            End If
    '        Else
    '            MsgFar("There is no Row in Database")
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Sub PCancel()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        Call ClearAllField()
        CmdCalculate.Enabled = False
        LblSumAmountDue.Text = ""
        LblSumPayment.Text = ""
        'Call PLastRecord()
        'Call LoadIt(TxtRef.Text)
    End Sub
    Sub pedit()
        '        Call LoadIt(TxtRefrence_no.Text)
        ThisFormStatus = MainModule.WorkStates.Edit
        Call EnableDisableField(True)
        Call EnableDisableBtn()
        Vendor_Cod1.Focus()
    End Sub
#End Region

    Private Sub LoadIt(ByVal ThisDate As String)
        'DsFrmReceiveReturnProduct1.Clear()
        DsFrmApPayment1.GridRecord.Clear()
        DsFrmApPayment1.GL_AP_bill_Dtl_Dtl.Clear()
        DsFrmApPayment1.Inv_Receive_product_Ap_Dtl.Clear()
        DsFrmApPayment1.service_out_purchases.Clear()

        If ThisDate <> "" Then
            Dim i As Integer = 0
            Dim FromDate As String = Mid(ThisDate, 7, 4) + "/" + Mid(ThisDate, 1, 2) + "/" + Mid(ThisDate, 4, 2)
            DaInv_Receive_product_Ap_DtlEdit.SelectCommand.Parameters("@cod_vendor").Value = Vendor_Cod1.Text
            DaInv_Receive_product_Ap_DtlEdit.SelectCommand.Parameters("@ThisDate").Value = FromDate
            DaInv_Receive_product_Ap_DtlEdit.Fill(DsFrmApPayment1)

            Daservice_out_purchasesEdit.SelectCommand.Parameters("@cod_vendor").Value = Vendor_Cod1.Text
            Daservice_out_purchasesEdit.SelectCommand.Parameters("@ThisDate").Value = FromDate
            Daservice_out_purchasesEdit.Fill(DsFrmApPayment1)

            DaGL_AP_bill_Dtl_DtlEdit.SelectCommand.Parameters("@cod_vendor").Value = Vendor_Cod1.Text
            DaGL_AP_bill_Dtl_DtlEdit.SelectCommand.Parameters("@ThisDate").Value = FromDate
            DaGL_AP_bill_Dtl_DtlEdit.Fill(DsFrmApPayment1)
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If

            '        DaGL_AP_payment.Fill(DsFrmApPayment1)
            Dim FLg1 As Boolean = False
            If ChkPayByCreadit.Checked = True Then
                FLg1 = True
            End If
            Dim flagadd As Boolean = True
            DsFrmApPayment1.GridRecord.Clear()
            For i = 0 To DsFrmApPayment1.GL_AP_bill_Dtl_Dtl.Rows.Count - 1
                With DsFrmApPayment1.GL_AP_bill_Dtl_Dtl.Rows(i)
                    If FLg1 Then
                        If Val("" & .Item("id_vendor_credit")) <> 0 Then
                            flagadd = True
                        Else
                            flagadd = False
                        End If
                    Else
                        If Val("" & .Item("id_vendor_credit")) <> 0 Then
                            flagadd = False
                        Else
                            flagadd = True
                        End If

                    End If
                    If flagadd Then
                        Dim dr1 As DataRow = DsFrmApPayment1.GridRecord.NewGridRecordRow
                        dr1("ID_AP_paymentEdit") = .Item("ID_AP_payment")
                        dr1("Date") = .Item("DateTransaction")
                        dr1("Refrenceno") = .Item("Id_AP_bill_dtl")
                        dr1("Id_AP_bill_dtl_dtl") = .Item("Id_AP_bill_dtl_dtl")
                        dr1("Radif") = -1
                        dr1("RefrenceType") = "BL"
                        dr1("PaiedBefore") = .Item("sumpayment")
                        dr1("PaiedBefore2") = .Item("sumpayment")
                        dr1("OriginalAmount") = .Item("amount")
                        dr1("AmountDue") = .Item("sumoriginalamount") - (.Item("sumpayment") - .Item("Amount_pay"))
                        dr1("AmountPay") = Math.Round(.Item("Amount_pay"), 2)
                        dr1("DueDate") = .Item("due_date")
                        dr1("Remark") = .Item("Remark")
                        dr1("CheckFlag") = False
                        DsFrmApPayment1.GridRecord.AddGridRecordRow(dr1)
                    End If
                End With
            Next


            For i = 0 To DsFrmApPayment1.Inv_Receive_product_Ap_Dtl.Rows.Count - 1
                With DsFrmApPayment1.Inv_Receive_product_Ap_Dtl.Rows(i)
                    If FLg1 Then
                        If Val("" & .Item("id_vendor_credit")) <> 0 Then
                            flagadd = True
                        Else
                            flagadd = False
                        End If
                    Else
                        If Val("" & .Item("id_vendor_credit")) <> 0 Then
                            flagadd = False
                        Else
                            flagadd = True
                        End If

                    End If
                    If flagadd Then
                        Dim dr1 As DataRow = DsFrmApPayment1.GridRecord.NewGridRecordRow
                        dr1("ID_AP_paymentEdit") = .Item("ID_AP_payment")
                        dr1("Date") = .Item("DateTransaction")
                        dr1("Refrenceno") = .Item("id_receive_ref")
                        DR1("ID_Inv_Receive_product_Ap_Dtl") = .Item("ID_Inv_Receive_product_Ap_Dtl")
                        dr1("Radif") = -1
                        dr1("RefrenceType") = "RR"
                        dr1("PaiedBefore") = .Item("sumpayment")
                        dr1("PaiedBefore2") = .Item("sumpayment")
                        dr1("OriginalAmount") = .Item("amount")
                        dr1("AmountDue") = .Item("sumoriginalamount") - (.Item("sumpayment") - .Item("Amount_pay"))
                        dr1("AmountPay") = Math.Round(.Item("Amount_pay"), 2)

                        dr1("DueDate") = .Item("due_date")
                        dr1("Remark") = .Item("Remark")
                        dr1("CheckFlag") = False
                        DsFrmApPayment1.GridRecord.AddGridRecordRow(dr1)
                    End If
                End With
            Next

            For i = 0 To DsFrmApPayment1.service_out_purchases.Rows.Count - 1
                With DsFrmApPayment1.service_out_purchases.Rows(i)
                    If FLg1 Then
                        If Val("" & .Item("id_vendor_credit")) <> 0 Then
                            flagadd = True
                        Else
                            flagadd = False
                        End If
                    Else
                        If Val("" & .Item("id_vendor_credit")) <> 0 Then
                            flagadd = False
                        Else
                            flagadd = True
                        End If

                    End If
                    If flagadd Then
                        Dim dr1 As DataRow = DsFrmApPayment1.GridRecord.NewGridRecordRow
                        dr1("ID_AP_paymentEdit") = .Item("ID_AP_payment")
                        dr1("Date") = .Item("DateTransaction")
                        dr1("Refrenceno") = .Item("id_service_center")
                        dr1("Radif") = .Item("Radif")
                        dr1("RefrenceType") = "OP"
                        dr1("PaiedBefore") = .Item("sumpayment") '- .Item("Amount_pay")
                        dr1("PaiedBefore2") = .Item("sumpayment")
                        dr1("OriginalAmount") = .Item("amount")
                        dr1("AmountDue") = .Item("sumoriginalamount") - (.Item("sumpayment") - .Item("Amount_pay"))
                        dr1("AmountPay") = Math.Round(.Item("Amount_pay"), 2)
                        dr1("DueDate") = .Item("due_date")
                        dr1("Remark") = .Item("Remark")
                        dr1("CheckFlag") = False
                        DsFrmApPayment1.GridRecord.AddGridRecordRow(dr1)
                    End If
                End With
            Next
        End If
        Call ClaculateSum()

        If ChkPayByCreadit.Checked = True Then
            DsFrmApPayment1.View_GL_vendor_creditReminder.Clear()
            DaViewGlGL_vendor_credit.SelectCommand.Parameters("@ThisVendor").Value = Vendor_Cod1.Text
            DaViewGlGL_vendor_credit.Fill(DsFrmApPayment1.View_GL_vendor_creditReminder)
            If DsFrmApPayment1.View_GL_vendor_creditReminder.Rows.Count > 0 Then
                Dim id As Decimal = DsFrmApPayment1.View_GL_vendor_creditReminder.Rows(0).Item("id_vendor_credit")
                Dim reminder As Decimal = DsFrmApPayment1.View_GL_vendor_creditReminder.Rows(0).Item("Reminder")
                LblCreadit.Text = CDec(Math.Round(reminder + Val("" & LblSumPayment.Text), 2))
                'dim a = math.Round(a,
            Else
                LblCreadit.Text = Math.Round(CDec(Val("" & LblSumPayment.Text)), 2)
            End If
        End If
        If DsFrmApPayment1.GridRecord.Rows.Count = 0 Then
            MsgFar("All Row Is Paied")
        End If
    End Sub


    Sub Ploadall()
        Dim i As Integer = 0
        Dim FromDate As String = "9999/99/99"   ' Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
        DsFrmApPayment1.Clear()
        DaInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@cod_vendor").Value = Vendor_Cod1.Text
        DaInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@ThisDate").Value = FromDate
        DaInv_Receive_product_Ap_Dtl.Fill(DsFrmApPayment1)

        Daservice_out_purchases.SelectCommand.Parameters("@cod_vendor").Value = Vendor_Cod1.Text
        Daservice_out_purchases.SelectCommand.Parameters("@ThisDate").Value = FromDate
        Daservice_out_purchases.Fill(DsFrmApPayment1)

        DaGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@cod_vendor").Value = Vendor_Cod1.Text
        DaGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@ThisDate").Value = FromDate
        DaGL_AP_bill_Dtl_Dtl.Fill(DsFrmApPayment1)

        '        DaGL_AP_payment.Fill(DsFrmApPayment1)

        Dim today As String = Format(Now.Date, PubDateFormat)
        DsFrmApPayment1.GridRecord.Clear()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        For i = 0 To DsFrmApPayment1.GL_AP_bill_Dtl_Dtl.Rows.Count - 1
            Dim dr1 As DataRow = DsFrmApPayment1.GridRecord.NewGridRecordRow
            With DsFrmApPayment1.GL_AP_bill_Dtl_Dtl.Rows(i)
                CmdGeneral.CommandText = "Select top 1 Id_AP_bill_dtl_dtl from GL_AP_payment where Id_AP_bill_dtl_dtl =" & .Item("Id_AP_bill_dtl_dtl") & " and date_prepare=" & Qt(today) & " and id_check is null"
                If (CmdGeneral.ExecuteScalar & "") = "" Then
                    dr1("Date") = .Item("DateTransaction")
                    dr1("Refrenceno") = .Item("Id_AP_bill_Dtl")
                    dr1("Id_AP_bill_dtl_dtl") = .Item("Id_AP_bill_dtl_dtl")
                    dr1("Radif") = -1
                    dr1("RefrenceType") = "BL"
                    dr1("PaiedBefore") = .Item("sumpayment")
                    dr1("OriginalAmount") = .Item("amount")
                    dr1("AmountDue") = .Item("sumoriginalamount") - .Item("sumpayment")
                    dr1("AmountPay") = 0
                    dr1("DueDate") = .Item("due_date")
                    dr1("Remark") = ""
                    dr1("CheckFlag") = False
                    DsFrmApPayment1.GridRecord.AddGridRecordRow(dr1)

                End If
          End With
        Next


        For i = 0 To DsFrmApPayment1.Inv_Receive_product_Ap_Dtl.Rows.Count - 1
            Dim dr1 As DataRow = DsFrmApPayment1.GridRecord.NewGridRecordRow
            With DsFrmApPayment1.Inv_Receive_product_Ap_Dtl.Rows(i)
                CmdGeneral.CommandText = "Select top 1 ID_Inv_Receive_product_Ap_Dtl from GL_AP_payment where ID_Inv_Receive_product_Ap_Dtl =" & .Item("ID_Inv_Receive_product_Ap_Dtl") & " and date_prepare=" & Qt(today) & " and id_check is null"
                '    If today <> .Item("due_date") Then
                If (CmdGeneral.ExecuteScalar & "") = "" Then
                    dr1("Date") = .Item("DateTransaction")
                    dr1("Refrenceno") = .Item("id_receive_ref")
                    DR1("ID_Inv_Receive_product_Ap_Dtl") = .Item("ID_Inv_Receive_product_Ap_Dtl")
                    dr1("Radif") = -1
                    dr1("RefrenceType") = "RR"
                    dr1("PaiedBefore") = .Item("sumpayment")
                    dr1("OriginalAmount") = .Item("amount")
                    dr1("AmountDue") = .Item("sumoriginalamount") - .Item("sumpayment")
                    dr1("AmountPay") = 0
                    dr1("DueDate") = .Item("due_date")
                    dr1("Remark") = ""
                    dr1("CheckFlag") = False
                    DsFrmApPayment1.GridRecord.AddGridRecordRow(dr1)
                End If
            End With
        Next


        For i = 0 To DsFrmApPayment1.service_out_purchases.Rows.Count - 1
            Dim dr1 As DataRow = DsFrmApPayment1.GridRecord.NewGridRecordRow
            With DsFrmApPayment1.service_out_purchases.Rows(i)
                CmdGeneral.CommandText = "Select top 1  id_service_center  from GL_AP_payment where id_service_center =" & Qt(.Item("id_service_center")) & " and radif =" & .Item("Radif") & " and date_prepare=" & Qt(today) & " and id_check is null"
                '    If today <> .Item("due_date") Then
                If (CmdGeneral.ExecuteScalar & "") = "" Then
                    dr1("Date") = .Item("DateTransaction")
                    dr1("Refrenceno") = .Item("id_service_center")
                    dr1("Radif") = .Item("Radif")
                    dr1("RefrenceType") = "OP"
                    dr1("PaiedBefore") = .Item("sumpayment")
                    dr1("OriginalAmount") = .Item("amount")
                    dr1("AmountDue") = .Item("sumoriginalamount") - .Item("sumpayment")
                    dr1("AmountPay") = 0
                    dr1("DueDate") = .Item("due_date")
                    dr1("Remark") = ""
                    dr1("CheckFlag") = False
                    DsFrmApPayment1.GridRecord.AddGridRecordRow(dr1)
                End If
            End With
        Next

        If ChkPayByCreadit.Checked = True Then
            DsFrmApPayment1.View_GL_vendor_creditReminder.Clear()
            DaViewGlGL_vendor_credit.SelectCommand.Parameters("@ThisVendor").Value = Vendor_Cod1.Text
            DaViewGlGL_vendor_credit.Fill(DsFrmApPayment1.View_GL_vendor_creditReminder)
            '--------------------------------------------'
            If DsFrmApPayment1.View_GL_vendor_creditReminder.Rows.Count > 0 Then
                Dim id As Decimal = DsFrmApPayment1.View_GL_vendor_creditReminder.Rows(0).Item("id_vendor_credit")
                Dim reminder As Decimal = DsFrmApPayment1.View_GL_vendor_creditReminder.Rows(0).Item("Reminder")
                LblCreadit.Text = reminder
                Dim j As Int64 = 0
                For j = 0 To DsFrmApPayment1.GridRecord.Rows.Count - 1
                    With DsFrmApPayment1.GridRecord.Rows(j)
                        If .Item("AmountDue") <= reminder Then
                            .Item("AmountPay") = .Item("AmountDue")
                            reminder = reminder - .Item("AmountDue")
                            .Item("id_vendor_credit") = id
                        Else
                            If reminder > 0 Then
                                .Item("AmountPay") = reminder
                                .Item("id_vendor_credit") = id
                                reminder = 0
                            End If
                        End If
                    End With
                Next
            Else
                'MsgFar(" No Creadit Find ")
                '        Call PCancel()
            End If
        End If
        Call ClaculateSum()
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call Paddnew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call pedit()
    End Sub

    Private Sub CmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCalculate.Click
        'DsFrmApPayment1.Clear()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew
                Call Ploadall()
            Case MainModule.WorkStates.Edit
                'DaDate.Fill(DsFrmApPayment1)
                If DsFrmApPayment1.GlDate.Rows.Count > 0 Then
                    Call LoadIt(CmbDate.Text)
                End If
        End Select
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call Psave()
    End Sub

    Private Sub Vendor_Cod1_FindVendorCod() Handles Vendor_Cod1.FindVendorCod
        Try
            DsFrmApPayment1.GlDate.Clear()
            CmdCalculate.Enabled = True
            LblVendorName.Text = Vendor_Cod1.Desc_Vendor & ""
            If ThisFormStatus = MainModule.WorkStates.Edit Then
                DaDate.SelectCommand.Parameters(0).Value = Vendor_Cod1.Text
                DaDate.Fill(DsFrmApPayment1.GlDate)
                If DsFrmApPayment1.GlDate.Rows.Count > 0 Then
                    CmbDate.Enabled = True
                    CmbDate.Focus()
                Else
                    CmbDate.Enabled = False
                    CmdCalculate.Enabled = False
                    MsgFar("No row to Edit ")
                End If
            Else
                CmbDate.Enabled = False
                CmdCalculate.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call PCancel()
    End Sub
    Private Sub Vendor_Cod1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Vendor_Cod1.TextChanged
        DsFrmApPayment1.Clear()
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Sub ClaculateSum()
        Dim i As Integer = 0
        Dim amount1 As Decimal = 0
        Dim payment1 As Decimal = 0
        For i = 0 To DsFrmApPayment1.GridRecord.Rows.Count - 1
            With DsFrmApPayment1.GridRecord.Rows(i)
                amount1 = amount1 + Val("" & .Item("AmountDue"))
                payment1 = payment1 + Val("" & .Item("AmountPay"))
            End With
            LblSumAmountDue.Text = Math.Round(amount1, 2)
            LblSumPayment.Text = Math.Round(payment1, 2)
        Next
    End Sub
    Private Sub GrdDetail_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellUpdated
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        If Val("" & CurrentRow.Cells(7).Value) > Val("" & CurrentRow.Cells(5).Value) Then
            CurrentRow.Cells(7).Value = Math.Round(Val("" & CurrentRow.Cells(5).Value), 2)
        End If
        GrdDetail.Col = 7
        GrdDetail.UpdateData()
        ClaculateSum()
    End Sub

    Private Sub myfrmsearch_FindPaymentCodDate(ByVal ThiDate As String, ByVal ThidVendorCod As String) Handles myfrmsearch.FindPaymentCodDate
        If ThiDate.Trim <> "" And ThidVendorCod.Trim <> "" Then
            Call pedit()
            Vendor_Cod1.Text = ThidVendorCod
            CmbDate.SelectedIndex = CmbDate.FindString(ThiDate.Trim)
            Dim e As System.EventArgs
            CmdCalculate_Click(Me, e)
            GrdDetail.Focus()
        End If
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        myfrmsearch = New FrmSearchApPayment
        myfrmsearch.ShowDialog()
    End Sub

    Private Sub GrdDetail_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdDetail.FormattingRow

    End Sub
End Class

