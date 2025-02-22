
Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmPrintVendor
    Inherits CommonClass.FrmBase

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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAUnPaidDetail As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DsFrmPrintVendor1 As ReportEmployee.DSFrmPrintVendor
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GrdUnPaidDtl As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdUnPaidSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACash As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdCash As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdCreditDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdCreditSummary As Janus.Windows.GridEX.GridEX
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdInventoryPurchasesDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdInventoryPurchasesSummary As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdOutsidePurchasesSummary As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdOutsidePurchasesDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdPayment As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdVendorList As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdVendorBill As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrintVendor))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout5 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout6 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout7 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout8 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout9 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout10 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout11 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout12 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAUnPaidDetail = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.DsFrmPrintVendor1 = New ReportEmployee.DSFrmPrintVendor
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GrdUnPaidDtl = New Janus.Windows.GridEX.GridEX
        Me.GrdUnPaidSummery = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DACash = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdCash = New Janus.Windows.GridEX.GridEX
        Me.GrdCreditDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdCreditSummary = New Janus.Windows.GridEX.GridEX
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GrdInventoryPurchasesDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdInventoryPurchasesSummary = New Janus.Windows.GridEX.GridEX
        Me.GrdOutsidePurchasesSummary = New Janus.Windows.GridEX.GridEX
        Me.GrdOutsidePurchasesDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdPayment = New Janus.Windows.GridEX.GridEX
        Me.GrdVendorList = New Janus.Windows.GridEX.GridEX
        Me.GrdVendorBill = New Janus.Windows.GridEX.GridEX
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmPrintVendor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdUnPaidDtl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdUnPaidSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCreditDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCreditSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdInventoryPurchasesDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdInventoryPurchasesSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdOutsidePurchasesSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdOutsidePurchasesDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVendorBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_ve" & _
        "ndor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer, ISNULL(SUM(GL_" & _
        "AP_payment.amount_pay), 0) AS pay, GL_AP_Bill_Head.Date_Bill AS DATE, GL_AP_bill" & _
        "_Dtl_Dtl.due_date AS due, ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2) AS orig" & _
        "inal, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay, ROUND(ISNULL(GL_AP_bill_D" & _
        "tl_Dtl.amount, 0), 2) - ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS AmountDue, G" & _
        "L_AP_bill_Dtl.ref_no AS ref, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl AS store, GL_" & _
        "tab_ap_term.desc_ap_term AS ap, ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2) AS " & _
        "disco FROM inv_buyer RIGHT OUTER JOIN inv_tab_vendor_type RIGHT OUTER JOIN GL_AP" & _
        "_payment RIGHT OUTER JOIN GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_" & _
        "bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bil" & _
        "l_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER" & _
        " JOIN inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON GL_AP_" & _
        "payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl LEFT OUTER JO" & _
        "IN GL_tab_ap_term ON GL_AP_bill_Dtl.AR_terms = GL_tab_ap_term.ap_term LEFT OUTER" & _
        " JOIN inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.cla" & _
        "ss_vendor ON inv_tab_vendor_type.vendor_type = inv_vendor.vendor_type ON inv_buy" & _
        "er.buyer_id = inv_vendor.buyer_id GROUP BY inv_vendor.cod_vendor, inv_vendor.des" & _
        "c_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class," & _
        " inv_buyer.desc_buyer, GL_tab_ap_term.desc_ap_term, GL_AP_Bill_Head.Date_Bill, G" & _
        "L_AP_bill_Dtl_Dtl.due_date, GL_AP_bill_Dtl_Dtl.amount, GL_AP_bill_Dtl.ref_no, GL" & _
        "_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, GL_AP_bill_Dtl.Discount"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=armandehxp;persi" & _
        "st security info=True;initial catalog=TireMate_01"
        '
        'DAUnPaidDetail
        '
        Me.DAUnPaidDetail.SelectCommand = Me.SqlSelectCommand1
        Me.DAUnPaidDetail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("www", "www"), New System.Data.Common.DataColumnMapping("contact1", "contact1"), New System.Data.Common.DataColumnMapping("contact2", "contact2"), New System.Data.Common.DataColumnMapping("federal_tax_id", "federal_tax_id"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("ap_terms", "ap_terms"), New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("vendor_since", "vendor_since"), New System.Data.Common.DataColumnMapping("f_1099", "f_1099"), New System.Data.Common.DataColumnMapping("on_hold", "on_hold"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("remit_to_company", "remit_to_company"), New System.Data.Common.DataColumnMapping("remit_to_address", "remit_to_address"), New System.Data.Common.DataColumnMapping("remit_to_zipcode", "remit_to_zipcode")})})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnDeselect)
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BtnSelect)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnEmail)
        Me.Panel4.Controls.Add(Me.BtnJPrint)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(632, 64)
        Me.Panel4.TabIndex = 10
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(325, 5)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 193
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(583, 5)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(575, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(0, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 0)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Deselect All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(325, 5)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 183
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(531, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(479, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(426, 39)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(369, 39)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(533, 5)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(481, 5)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(428, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(377, 5)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Use 'Field Chooser' To select columns for printing then click on 'Grid Print' to " & _
        "print"
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
        Me.PictureBox2.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'DsFrmPrintVendor1
        '
        Me.DsFrmPrintVendor1.DataSetName = "DSFrmPrintVendor"
        Me.DsFrmPrintVendor1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridEXPrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(802, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GrdUnPaidDtl
        '
        Me.GrdUnPaidDtl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdUnPaidDtl.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdUnPaidDtl.DataMember = "UnpaidDetail"
        Me.GrdUnPaidDtl.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>25</Width></Column0><Column1 ID" & _
        "=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>desc_vendor</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc" & _
        "_vendor</Key><Position>1</Position><TextAlignment>Near</TextAlignment><Visible>F" & _
        "alse</Visible><Width>116</Width></Column1><Column2 ID=""ref""><Caption>Vendor Ref." & _
        "</Caption><DataMember>ref</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><Key>ref</Key><Position>2</Position><TextAlignment>Near" & _
        "</TextAlignment><Width>87</Width></Column2><Column3 ID=""date""><Caption>Date</Cap" & _
        "tion><DataMember>date</DataMember><EditType>NoEdit</EditType><FilterEditType>Tex" & _
        "tBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><InputMask>MM/dd/yyy" & _
        "y</InputMask><Key>date</Key><Position>3</Position><TextAlignment>Center</TextAli" & _
        "gnment><Width>80</Width></Column3><Column4 ID=""AP""><Caption>AP Term</Caption><Da" & _
        "taMember>AP</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><Key>AP</Key><Position>4</Position><TextAlignment>Center</TextAlignme" & _
        "nt><Width>67</Width></Column4><Column5 ID=""Original""><AggregateFunction>Sum</Agg" & _
        "regateFunction><Caption>Original Amount</Caption><DataMember>Original</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStri" & _
        "ng>c2</FormatString><Key>Original</Key><Position>5</Position><TextAlignment>Far<" & _
        "/TextAlignment><Width>95</Width><TotalFormatString>c2</TotalFormatString></Colum" & _
        "n5><Column6 ID=""pay""><AggregateFunction>Sum</AggregateFunction><Caption>Amount P" & _
        "aid</Caption><DataMember>pay</DataMember><EditType>NoEdit</EditType><FilterEditT" & _
        "ype>TextBox</FilterEditType><FormatString>c2</FormatString><Key>pay</Key><Positi" & _
        "on>6</Position><TextAlignment>Far</TextAlignment><Width>88</Width><TotalFormatSt" & _
        "ring>c2</TotalFormatString></Column6><Column7 ID=""Disco""><AggregateFunction>Sum<" & _
        "/AggregateFunction><Caption>Discount</Caption><DataMember>Disco</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2<" & _
        "/FormatString><Key>Disco</Key><Position>7</Position><TextAlignment>Far</TextAlig" & _
        "nment><Width>72</Width><TotalFormatString>c2</TotalFormatString></Column7><Colum" & _
        "n8 ID=""AmountDue""><AggregateFunction>Sum</AggregateFunction><Caption>Amount Due<" & _
        "/Caption><DataMember>AmountDue</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>AmountDue</Key" & _
        "><Position>8</Position><TextAlignment>Far</TextAlignment><Width>76</Width><Total" & _
        "FormatString>c2</TotalFormatString></Column8><Column9 ID=""due""><Caption>Due Date" & _
        "</Caption><DataMember>due</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><InputMask>MM/dd" & _
        "/yyyy</InputMask><Key>due</Key><Position>9</Position><TextAlignment>Center</Text" & _
        "Alignment><Width>70</Width></Column9><Column10 ID=""cod_vendor""><Caption>Vendor</" & _
        "Caption><DataMember>cod_vendor</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>cod_vendor</Key><Position>10</Position><TextA" & _
        "lignment>Center</TextAlignment><Width>71</Width></Column10><Column11 ID=""store"">" & _
        "<Caption>Store Ref.</Caption><DataMember>store</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>store</Key><Position>11</Posi" & _
        "tion><TextAlignment>Near</TextAlignment><Width>89</Width></Column11><Column12 ID" & _
        "=""desc_vendor_type""><Caption>Type</Caption><DataMember>desc_vendor_type</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc" & _
        "_vendor_type</Key><Position>12</Position><TextAlignment>Near</TextAlignment><Wid" & _
        "th>91</Width></Column12><Column13 ID=""desc_class""><Caption>Class</Caption><DataM" & _
        "ember>desc_class</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>desc_class</Key><Position>13</Position><TextAlignment>Near<" & _
        "/TextAlignment><Width>77</Width></Column13><Column14 ID=""desc_buyer""><Caption>Bu" & _
        "yer</Caption><DataMember>desc_buyer</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><Key>desc_buyer</Key><Position>14</Position><" & _
        "TextAlignment>Near</TextAlignment><Width>70</Width></Column14><Column15 ID=""Orde" & _
        "rDate""><Caption>OrderDate</Caption><DataMember>OrderDate</DataMember><Key>OrderD" & _
        "ate</Key><Position>15</Position><Visible>False</Visible></Column15></Columns><Gr" & _
        "oupCondition ID="""" /><Groups Collection=""true""><Group0 ID=""Group0""><ColIndex>1</" & _
        "ColIndex></Group0></Groups><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><" & _
        "ColIndex>11</ColIndex></SortKey0><SortKey1 ID=""SortKey1""><ColIndex>15</ColIndex>" & _
        "</SortKey1></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdUnPaidDtl.DesignTimeLayout = GridEXLayout1
        Me.GrdUnPaidDtl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdUnPaidDtl.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdUnPaidDtl.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdUnPaidDtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdUnPaidDtl.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdUnPaidDtl.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdUnPaidDtl.Location = New System.Drawing.Point(0, 64)
        Me.GrdUnPaidDtl.Name = "GrdUnPaidDtl"
        Me.GrdUnPaidDtl.Size = New System.Drawing.Size(634, 338)
        Me.GrdUnPaidDtl.TabIndex = 11
        Me.GrdUnPaidDtl.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdUnPaidSummery
        '
        Me.GrdUnPaidSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdUnPaidSummery.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdUnPaidSummery.DataMember = "UnpaidSummery"
        Me.GrdUnPaidSummery.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>25</Width></Column0><Column1 ID" & _
        "=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>desc_vendor</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc" & _
        "_vendor</Key><Position>1</Position><TextAlignment>Near</TextAlignment><Visible>F" & _
        "alse</Visible><Width>116</Width></Column1><Column2 ID=""Original""><AggregateFunct" & _
        "ion>Sum</AggregateFunction><Caption>Orig. Amount</Caption><DataMember>Original</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><F" & _
        "ormatString>c2</FormatString><Key>Original</Key><Position>2</Position><TextAlign" & _
        "ment>Far</TextAlignment><Width>90</Width><TotalFormatString>c2</TotalFormatStrin" & _
        "g></Column2><Column3 ID=""pay""><AggregateFunction>Sum</AggregateFunction><Caption" & _
        ">Amount Paid</Caption><DataMember>pay</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>pay</Ke" & _
        "y><Position>3</Position><TextAlignment>Far</TextAlignment><Width>90</Width><Tota" & _
        "lFormatString>c2</TotalFormatString></Column3><Column4 ID=""disco""><AggregateFunc" & _
        "tion>Sum</AggregateFunction><Caption>Discount</Caption><DataMember>disco</DataMe" & _
        "mber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatS" & _
        "tring>c2</FormatString><Key>disco</Key><Position>4</Position><TextAlignment>Far<" & _
        "/TextAlignment><Width>86</Width><TotalFormatString>c2</TotalFormatString></Colum" & _
        "n4><Column5 ID=""AmountDue""><AggregateFunction>Sum</AggregateFunction><Caption>Am" & _
        "ount Due</Caption><DataMember>AmountDue</DataMember><EditType>NoEdit</EditType><" & _
        "FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Amoun" & _
        "tDue</Key><Position>5</Position><TextAlignment>Far</TextAlignment><Width>88</Wid" & _
        "th><TotalFormatString>c2</TotalFormatString></Column5><Column6 ID=""due""><Caption" & _
        ">Due Date</Caption><DataMember>due</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>du" & _
        "e</Key><Position>6</Position><Width>80</Width><TotalFormatString>c2</TotalFormat" & _
        "String></Column6></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Gr" & _
        "oup0 ID=""Group0""><ColIndex>1</ColIndex></Group0></Groups><SortKeys Collection=""t" & _
        "rue""><SortKey0 ID=""SortKey0""><ColIndex>6</ColIndex></SortKey0></SortKeys></RootT" & _
        "able></GridEXLayoutData>"
        Me.GrdUnPaidSummery.DesignTimeLayout = GridEXLayout2
        Me.GrdUnPaidSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdUnPaidSummery.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdUnPaidSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdUnPaidSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdUnPaidSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdUnPaidSummery.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdUnPaidSummery.Location = New System.Drawing.Point(-1, 64)
        Me.GrdUnPaidSummery.Name = "GrdUnPaidSummery"
        Me.GrdUnPaidSummery.Size = New System.Drawing.Size(634, 338)
        Me.GrdUnPaidSummery.TabIndex = 12
        Me.GrdUnPaidSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_vendor, desc_vendor, Original, pay, AmountDue, disco, due, CASE WHEN D" & _
        "ATEDIFF(day, due, { fn NOW() }) > 0 THEN AmountDue ELSE 0 END AS PastDue, CASE W" & _
        "HEN DATEDIFF(day, { fn NOW() }, due) < 10 AND DATEDIFF(day, { fn NOW() }, due) >" & _
        "= 0 THEN AmountDue ELSE 0 END AS Remain10Day, CASE WHEN DATEDIFF(day, { fn NOW()" & _
        " }, due) < 30 AND DATEDIFF(day, { fn NOW() }, due) >= 10 THEN AmountDue ELSE 0 E" & _
        "ND AS Remain30Day, CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 60 AND DATEDIFF(" & _
        "day, { fn NOW() }, due) >= 30 THEN AmountDue ELSE 0 END AS Remain60Day, CASE WHE" & _
        "N DATEDIFF(day, { fn NOW() }, due) < 90 AND DATEDIFF(day, { fn NOW() }, due) >= " & _
        "60 THEN AmountDue ELSE 0 END AS Remain90Day, CASE WHEN DATEDIFF(day, { fn NOW() " & _
        "}, due) > 90 THEN AmountDue ELSE 0 END AS Over90Day, ref FROM View_UnPaid_Vendor" & _
        "_ss"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DACash
        '
        Me.DACash.SelectCommand = Me.SqlSelectCommand3
        Me.DACash.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_group", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("desc_group_account", "desc_group_account")})})
        '
        'GrdCash
        '
        Me.GrdCash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCash.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCash.DataMember = "CashDetail"
        Me.GrdCash.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>25</Width></Column0><Column1 ID" & _
        "=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>desc_vendor</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc" & _
        "_vendor</Key><Position>1</Position><TextAlignment>Near</TextAlignment><Visible>F" & _
        "alse</Visible><Width>116</Width></Column1><Column2 ID=""ref""><Caption>Vendor Ref." & _
        "</Caption><DataMember>ref</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><Key>ref</Key><Position>2</Position><TextAlignment>Near" & _
        "</TextAlignment><Width>87</Width></Column2><Column3 ID=""Original""><AggregateFunc" & _
        "tion>Sum</AggregateFunction><Caption>Original Amount</Caption><DataMember>Origin" & _
        "al</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><FormatString>c2</FormatString><Key>Original</Key><Position>3</Position><TextA" & _
        "lignment>Far</TextAlignment><Width>96</Width><TotalFormatString>c2</TotalFormatS" & _
        "tring></Column3><Column4 ID=""AmountDue""><AggregateFunction>Sum</AggregateFunctio" & _
        "n><Caption>Amount Due</Caption><DataMember>AmountDue</DataMember><EditType>NoEdi" & _
        "t</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStri" & _
        "ng><Key>AmountDue</Key><Position>4</Position><TextAlignment>Far</TextAlignment><" & _
        "Width>83</Width><TotalFormatString>c2</TotalFormatString></Column4><Column5 ID=""" & _
        "due""><Caption>Due Date</Caption><DataMember>due</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatS" & _
        "tring><Key>due</Key><Position>5</Position><TextAlignment>Center</TextAlignment><" & _
        "Width>72</Width></Column5><Column6 ID=""PastDue""><AggregateFunction>Sum</Aggregat" & _
        "eFunction><Caption>Past Due</Caption><DataMember>PastDue</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</Format" & _
        "String><Key>PastDue</Key><Position>6</Position><TextAlignment>Far</TextAlignment" & _
        "><Width>75</Width><TotalFormatString>c2</TotalFormatString></Column6><Column7 ID" & _
        "=""Remain10Day""><AggregateFunction>Sum</AggregateFunction><Caption>Due&lt;10 Days" & _
        "</Caption><DataMember>Remain10Day</DataMember><EditType>NoEdit</EditType><Filter" & _
        "EditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Remain10Day" & _
        "</Key><Position>7</Position><TextAlignment>Far</TextAlignment><Width>86</Width><" & _
        "TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=""Remain30Day""><Agg" & _
        "regateFunction>Sum</AggregateFunction><Caption>&lt;30 Days</Caption><DataMember>" & _
        "Remain30Day</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><FormatString>c2</FormatString><Key>Remain30Day</Key><Position>8</Pos" & _
        "ition><TextAlignment>Far</TextAlignment><Width>85</Width><TotalFormatString>c2</" & _
        "TotalFormatString></Column8><Column9 ID=""Remain60Day""><AggregateFunction>Sum</Ag" & _
        "gregateFunction><Caption>&lt;60 Days</Caption><DataMember>Remain60Day</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStri" & _
        "ng>c2</FormatString><Key>Remain60Day</Key><Position>9</Position><TextAlignment>F" & _
        "ar</TextAlignment><Width>79</Width><TotalFormatString>c2</TotalFormatString></Co" & _
        "lumn9><Column10 ID=""Remain90Day""><AggregateFunction>Sum</AggregateFunction><Capt" & _
        "ion>&lt;90 Days</Caption><DataMember>Remain90Day</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><" & _
        "Key>Remain90Day</Key><Position>10</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>74</Width><TotalFormatString>c2</TotalFormatString></Column10><Column11 ID=" & _
        """Over90Day""><AggregateFunction>Sum</AggregateFunction><Caption>90 and More</Capt" & _
        "ion><DataMember>Over90Day</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><FormatString>c2</FormatString><Key>Over90Day</Key><Pos" & _
        "ition>11</Position><TextAlignment>Far</TextAlignment><Width>80</Width><TotalForm" & _
        "atString>c2</TotalFormatString></Column11><Column12 ID=""cod_vendor""><Caption>Ven" & _
        "dore</Caption><DataMember>cod_vendor</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>cod_vend" & _
        "or</Key><Position>12</Position><TextAlignment>Far</TextAlignment><Width>62</Widt" & _
        "h></Column12></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group0" & _
        " ID=""Group0""><ColIndex>1</ColIndex></Group0></Groups><SortKeys Collection=""true""" & _
        "><SortKey0 ID=""SortKey0""><ColIndex>2</ColIndex></SortKey0></SortKeys></RootTable" & _
        "></GridEXLayoutData>"
        Me.GrdCash.DesignTimeLayout = GridEXLayout3
        Me.GrdCash.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCash.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdCash.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCash.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCash.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdCash.Location = New System.Drawing.Point(-1, 64)
        Me.GrdCash.Name = "GrdCash"
        Me.GrdCash.Size = New System.Drawing.Size(634, 338)
        Me.GrdCash.TabIndex = 13
        Me.GrdCash.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdCreditDetail
        '
        Me.GrdCreditDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCreditDetail.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCreditDetail.DataMember = "CreditDetail"
        Me.GrdCreditDetail.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>25</Width></Column0><Column1 ID" & _
        "=""ref""><Caption>Vendor Ref.</Caption><DataMember>ref_no</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>TextBox</FilterEditType><Key>ref</Key><Position>1" & _
        "</Position><TextAlignment>Near</TextAlignment><Width>87</Width></Column1><Column" & _
        "2 ID=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>desc_vendor</Dat" & _
        "aMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>" & _
        "desc_vendor</Key><Position>2</Position><TextAlignment>Near</TextAlignment><Visib" & _
        "le>False</Visible><Width>152</Width></Column2><Column3 ID=""cod_vendor""><Caption>" & _
        "Vendor</Caption><DataMember>cod_vendor</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>cod_vendor</Key><Position>3</Position" & _
        "><TextAlignment>Center</TextAlignment><Width>59</Width></Column3><Column4 ID=""da" & _
        "te""><Caption>Date</Caption><DataMember>date_credit</DataMember><EditType>NoEdit<" & _
        "/EditType><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</Form" & _
        "atString><Key>date</Key><Position>4</Position><TextAlignment>Center</TextAlignme" & _
        "nt><Width>75</Width></Column4><Column5 ID=""amount_credit""><AggregateFunction>Sum" & _
        "</AggregateFunction><Caption>Credit Amount</Caption><DataMember>amount_credit</D" & _
        "ataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Fo" & _
        "rmatString>c2</FormatString><Key>amount_credit</Key><Position>5</Position><TextA" & _
        "lignment>Far</TextAlignment><Width>86</Width><TotalFormatString>c2</TotalFormatS" & _
        "tring></Column5><Column6 ID=""due""><Caption>Due Date</Caption><DataMember>due_dat" & _
        "e</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType" & _
        "><FormatString>MM/dd/yyyy</FormatString><Key>due</Key><Position>6</Position><Tex" & _
        "tAlignment>Center</TextAlignment><Width>71</Width></Column6><Column7 ID=""id_vend" & _
        "or_credit""><Caption>Ref No.</Caption><DataMember>id_vendor_credit</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>id_vendor_" & _
        "credit</Key><Position>7</Position><Width>90</Width></Column7><Column8 ID=""Remark" & _
        """><Caption>Remark</Caption><DataMember>Remark</DataMember><EditType>NoEdit</Edit" & _
        "Type><FilterEditType>TextBox</FilterEditType><Key>Remark</Key><Position>8</Posit" & _
        "ion></Column8></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group" & _
        "0 ID=""Group0""><ColIndex>2</ColIndex></Group0></Groups><SortKeys Collection=""true" & _
        """><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex></SortKey0></SortKeys></RootTabl" & _
        "e></GridEXLayoutData>"
        Me.GrdCreditDetail.DesignTimeLayout = GridEXLayout4
        Me.GrdCreditDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCreditDetail.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdCreditDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCreditDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCreditDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCreditDetail.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdCreditDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdCreditDetail.Name = "GrdCreditDetail"
        Me.GrdCreditDetail.Size = New System.Drawing.Size(634, 338)
        Me.GrdCreditDetail.TabIndex = 15
        Me.GrdCreditDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdCreditSummary
        '
        Me.GrdCreditSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCreditSummary.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCreditSummary.DataMember = "CreditSummary"
        Me.GrdCreditSummary.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout5.LayoutString = "<GridEXLayoutData><RootTable><Caption>CreditSummary</Caption><Columns Collection=" & _
        """true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMember>flag</Dat" & _
        "aMember><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><Width" & _
        ">26</Width></Column0><Column1 ID=""cod_vendor""><Caption>Vendor</Caption><TypeName" & _
        "EmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Da" & _
        "taMember>cod_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>cod_vendor</Key><Position>1</Position><Width>78</Width><" & _
        "/Column1><Column2 ID=""desc_vendor""><Caption>Vendor Name</Caption><DataMember>des" & _
        "c_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><Key>desc_vendor</Key><Position>2</Position><Width>305</Width></Column2>" & _
        "<Column3 ID=""amount_credit""><AggregateFunction>Sum</AggregateFunction><Caption>C" & _
        "redit Amount</Caption><DataMember>amount_credit</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><K" & _
        "ey>amount_credit</Key><Position>3</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>116</Width><TotalFormatString>c2</TotalFormatString></Column3></Columns><Gr" & _
        "oupCondition ID="""" /><Key>CreditSummary</Key></RootTable></GridEXLayoutData>"
        Me.GrdCreditSummary.DesignTimeLayout = GridEXLayout5
        Me.GrdCreditSummary.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCreditSummary.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdCreditSummary.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCreditSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCreditSummary.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCreditSummary.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdCreditSummary.Location = New System.Drawing.Point(0, 64)
        Me.GrdCreditSummary.Name = "GrdCreditSummary"
        Me.GrdCreditSummary.Size = New System.Drawing.Size(634, 338)
        Me.GrdCreditSummary.TabIndex = 16
        Me.GrdCreditSummary.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_Head", "Id_AP_bill_Head"), New System.Data.Common.DataColumnMapping("ref_no", "ref_no"), New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT service_out_purchases.id_service_center, service_center_dtl.cod_select AS " & _
        "ItemNo, service_center_dtl.desc_radif AS ItemDesc, service_center_dtl.qty, servi" & _
        "ce_center_dtl.qty * (service_center_dtl.price + service_center_dtl.fet) AS ExtPr" & _
        "ice, service_center_dtl.qty * service_out_purchases.cost AS ExtCost, service_out" & _
        "_purchases.po_no, service_out_purchases.cod_vendor, inv_vendor.desc_vendor, serv" & _
        "ice_out_purchases.invoice_no AS VendorRef FROM service_out_purchases INNER JOIN " & _
        "service_center_dtl ON service_out_purchases.id_service_center = service_center_d" & _
        "tl.id_service_center AND service_out_purchases.radif = service_center_dtl.radif " & _
        "INNER JOIN service_center_head ON service_center_dtl.id_service_center = service" & _
        "_center_head.id_service_center INNER JOIN inv_vendor ON service_out_purchases.co" & _
        "d_vendor = inv_vendor.cod_vendor"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'GrdInventoryPurchasesDetail
        '
        Me.GrdInventoryPurchasesDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdInventoryPurchasesDetail.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdInventoryPurchasesDetail.DataMember = "InventoryPurchasesDetail"
        Me.GrdInventoryPurchasesDetail.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout6.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>25</Width></Column0><Column1 ID" & _
        "=""cod_vendor""><Caption>Vendor</Caption><DataMember>cod_vendor</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_vendor</Ke" & _
        "y><Position>1</Position><Width>82</Width></Column1><Column2 ID=""desc_vendor""><Ca" & _
        "ption>Vendor Company</Caption><DataMember>desc_vendor</DataMember><EditType>NoEd" & _
        "it</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_vendor</Key><Posi" & _
        "tion>2</Position><TextAlignment>Near</TextAlignment><Visible>False</Visible><Wid" & _
        "th>152</Width></Column2><Column3 ID=""ref""><Caption>Ref. No</Caption><DataMember>" & _
        "id_receive_ref</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</F" & _
        "ilterEditType><Key>ref</Key><Position>3</Position><TextAlignment>Near</TextAlign" & _
        "ment><Width>87</Width></Column3><Column4 ID=""date""><Caption>Receipt Date</Captio" & _
        "n><DataMember>receipt_bill_date</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>date<" & _
        "/Key><Position>4</Position><TextAlignment>Center</TextAlignment><Width>78</Width" & _
        "></Column4><Column5 ID=""TotalQty""><AggregateFunction>Sum</AggregateFunction><Cap" & _
        "tion>Qty</Caption><DataMember>TotalQty</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>TotalQty</Key><Position>5</Position><" & _
        "TextAlignment>Far</TextAlignment><Width>66</Width></Column5><Column6 ID=""amount_" & _
        "credit""><AggregateFunction>Sum</AggregateFunction><Caption>Amount</Caption><Data" & _
        "Member>TotalPrice</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><FormatString>c2</FormatString><Key>amount_credit</Key><Positio" & _
        "n>6</Position><TextAlignment>Far</TextAlignment><Width>86</Width><TotalFormatStr" & _
        "ing>c2</TotalFormatString></Column6><Column7 ID=""vendor_ref_no""><Caption>Vendor " & _
        "Ref</Caption><DataMember>vendor_ref_no</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>vendor_ref_no</Key><Position>7</Posit" & _
        "ion><Width>78</Width></Column7><Column8 ID=""receipt_bill_date""><Caption>Bill Dat" & _
        "e</Caption><DataMember>date_receive</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>r" & _
        "eceipt_bill_date</Key><Position>8</Position><Width>83</Width></Column8></Columns" & _
        "><GroupCondition ID="""" /><Groups Collection=""true""><Group0 ID=""Group0""><ColIndex" & _
        ">2</ColIndex></Group0></Groups><SortKeys Collection=""true""><SortKey0 ID=""SortKey" & _
        "0""><ColIndex>1</ColIndex></SortKey0><SortKey1 ID=""SortKey1""><ColIndex>3</ColInde" & _
        "x></SortKey1></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdInventoryPurchasesDetail.DesignTimeLayout = GridEXLayout6
        Me.GrdInventoryPurchasesDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdInventoryPurchasesDetail.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdInventoryPurchasesDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdInventoryPurchasesDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdInventoryPurchasesDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdInventoryPurchasesDetail.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdInventoryPurchasesDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdInventoryPurchasesDetail.Name = "GrdInventoryPurchasesDetail"
        Me.GrdInventoryPurchasesDetail.Size = New System.Drawing.Size(634, 338)
        Me.GrdInventoryPurchasesDetail.TabIndex = 17
        Me.GrdInventoryPurchasesDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdInventoryPurchasesSummary
        '
        Me.GrdInventoryPurchasesSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdInventoryPurchasesSummary.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdInventoryPurchasesSummary.DataMember = "InventoryPurchasesSummary"
        Me.GrdInventoryPurchasesSummary.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout7.LayoutString = "<GridEXLayoutData><RootTable><Caption>CreditSummary</Caption><Columns Collection=" & _
        """true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMember>flag</Dat" & _
        "aMember><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><Width" & _
        ">26</Width></Column0><Column1 ID=""cod_vendor""><Caption>Vendor</Caption><TypeName" & _
        "EmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Da" & _
        "taMember>cod_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>cod_vendor</Key><Position>1</Position><Width>78</Width><" & _
        "/Column1><Column2 ID=""desc_vendor""><Caption>Vendor Name</Caption><DataMember>des" & _
        "c_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><Key>desc_vendor</Key><Position>2</Position><Width>305</Width></Column2>" & _
        "<Column3 ID=""TotalQty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty</C" & _
        "aption><DataMember>TotalQty</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><Key>TotalQty</Key><Position>3</Position><TextAlignme" & _
        "nt>Far</TextAlignment><Width>92</Width></Column3><Column4 ID=""amount_credit""><Ag" & _
        "gregateFunction>Sum</AggregateFunction><Caption>Amount</Caption><DataMember>Tota" & _
        "lPrice</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><FormatString>c2</FormatString><Key>amount_credit</Key><Position>4</Positi" & _
        "on><TextAlignment>Far</TextAlignment><Width>116</Width><TotalFormatString>c2</To" & _
        "talFormatString></Column4></Columns><GroupCondition ID="""" /><Key>CreditSummary</" & _
        "Key></RootTable></GridEXLayoutData>"
        Me.GrdInventoryPurchasesSummary.DesignTimeLayout = GridEXLayout7
        Me.GrdInventoryPurchasesSummary.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdInventoryPurchasesSummary.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdInventoryPurchasesSummary.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdInventoryPurchasesSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdInventoryPurchasesSummary.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdInventoryPurchasesSummary.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdInventoryPurchasesSummary.Location = New System.Drawing.Point(0, 64)
        Me.GrdInventoryPurchasesSummary.Name = "GrdInventoryPurchasesSummary"
        Me.GrdInventoryPurchasesSummary.Size = New System.Drawing.Size(634, 338)
        Me.GrdInventoryPurchasesSummary.TabIndex = 18
        Me.GrdInventoryPurchasesSummary.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdOutsidePurchasesSummary
        '
        Me.GrdOutsidePurchasesSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdOutsidePurchasesSummary.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdOutsidePurchasesSummary.DataMember = "OutsidePurchasesSummary"
        Me.GrdOutsidePurchasesSummary.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout8.LayoutString = "<GridEXLayoutData><RootTable><Caption>CreditSummary</Caption><Columns Collection=" & _
        """true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMember>flag</Dat" & _
        "aMember><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><Width" & _
        ">26</Width></Column0><Column1 ID=""cod_vendor""><Caption>Vendor</Caption><TypeName" & _
        "EmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Da" & _
        "taMember>cod_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>cod_vendor</Key><Position>1</Position><Width>74</Width><" & _
        "/Column1><Column2 ID=""desc_vendor""><Caption>Vendor Name</Caption><DataMember>des" & _
        "c_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><Key>desc_vendor</Key><Position>2</Position><Width>209</Width></Column2>" & _
        "<Column3 ID=""qty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty</Captio" & _
        "n><DataMember>qty</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>qty</Key><Position>3</Position><TextAlignment>Far</TextAli" & _
        "gnment><Width>56</Width></Column3><Column4 ID=""ExtPrice""><AggregateFunction>Sum<" & _
        "/AggregateFunction><Caption>ExtPrice</Caption><DataMember>ExtPrice</DataMember><" & _
        "EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>" & _
        "c2</FormatString><Key>ExtPrice</Key><Position>4</Position><TextAlignment>Far</Te" & _
        "xtAlignment><Width>82</Width><TotalFormatString>c2</TotalFormatString></Column4>" & _
        "<Column5 ID=""ExtCost""><AggregateFunction>Sum</AggregateFunction><Caption>ExtCost" & _
        "</Caption><DataMember>ExtCost</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><FormatString>c2</FormatString><Key>ExtCost</Key><P" & _
        "osition>5</Position><TextAlignment>Far</TextAlignment><Width>79</Width><TotalFor" & _
        "matString>c2</TotalFormatString></Column5></Columns><GroupCondition ID="""" /><Key" & _
        ">CreditSummary</Key></RootTable></GridEXLayoutData>"
        Me.GrdOutsidePurchasesSummary.DesignTimeLayout = GridEXLayout8
        Me.GrdOutsidePurchasesSummary.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdOutsidePurchasesSummary.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdOutsidePurchasesSummary.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdOutsidePurchasesSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdOutsidePurchasesSummary.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdOutsidePurchasesSummary.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdOutsidePurchasesSummary.Location = New System.Drawing.Point(0, 64)
        Me.GrdOutsidePurchasesSummary.Name = "GrdOutsidePurchasesSummary"
        Me.GrdOutsidePurchasesSummary.Size = New System.Drawing.Size(634, 338)
        Me.GrdOutsidePurchasesSummary.TabIndex = 19
        Me.GrdOutsidePurchasesSummary.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdOutsidePurchasesDetail
        '
        Me.GrdOutsidePurchasesDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdOutsidePurchasesDetail.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdOutsidePurchasesDetail.DataMember = "OutsidePurchasesDetail"
        Me.GrdOutsidePurchasesDetail.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout9.LayoutString = "<GridEXLayoutData><RootTable><Caption>OutsidePurchases</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMember>flag</" & _
        "DataMember><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><Wi" & _
        "dth>28</Width></Column0><Column1 ID=""desc_vendor""><Caption>Vendor Company</Capti" & _
        "on><DataMember>desc_vendor</DataMember><EditType>NoEdit</EditType><FilterEditTyp" & _
        "e>TextBox</FilterEditType><Key>desc_vendor</Key><Position>1</Position><Visible>F" & _
        "alse</Visible></Column1><Column2 ID=""id_service_center""><Caption>Ref. No</Captio" & _
        "n><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyString" & _
        "Value /><DataMember>id_service_center</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><Key>id_service_center</Key><Position>2</Po" & _
        "sition><Width>78</Width></Column2><Column3 ID=""ItemNo""><Caption>Item No</Caption" & _
        "><DataMember>ItemNo</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>ItemNo</Key><Position>3</Position><Width>75</Width></Col" & _
        "umn3><Column4 ID=""ItemDesc""><Caption>Description</Caption><DataMember>ItemDesc</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><K" & _
        "ey>ItemDesc</Key><Position>4</Position><Width>125</Width></Column4><Column5 ID=""" & _
        "qty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty</Caption><TypeNameEm" & _
        "ptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>qt" & _
        "y</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType" & _
        "><Key>qty</Key><Position>5</Position><TextAlignment>Far</TextAlignment><Width>37" & _
        "</Width></Column5><Column6 ID=""ExtPrice""><AggregateFunction>Sum</AggregateFuncti" & _
        "on><Caption>Ext. Price</Caption><DataMember>ExtPrice</DataMember><EditType>NoEdi" & _
        "t</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStri" & _
        "ng><Key>ExtPrice</Key><Position>6</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>75</Width><TotalFormatString>c2</TotalFormatString></Column6><Column7 ID=""E" & _
        "xtCost""><AggregateFunction>Sum</AggregateFunction><Caption>Ext. Cost</Caption><D" & _
        "ataMember>ExtCost</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><FormatString>c2</FormatString><Key>ExtCost</Key><Position>7</P" & _
        "osition><TextAlignment>Far</TextAlignment><Width>73</Width><TotalFormatString>c2" & _
        "</TotalFormatString></Column7><Column8 ID=""po_no""><Caption>Store PO</Caption><Da" & _
        "taMember>po_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</F" & _
        "ilterEditType><Key>po_no</Key><Position>8</Position><Width>70</Width></Column8><" & _
        "Column9 ID=""cod_vendor""><Caption>Vendor</Caption><DataMember>cod_vendor</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_" & _
        "vendor</Key><Position>9</Position><Width>71</Width></Column9><Column10 ID=""Vendo" & _
        "rRef""><Caption>Vendor Ref</Caption><DataMember>VendorRef</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>VendorRef</Key><Pos" & _
        "ition>10</Position><Width>88</Width></Column10><Column11 ID=""Line""><Caption>Line" & _
        "</Caption><DataMember>Line</DataMember><EditType>NoEdit</EditType><FilterEditTyp" & _
        "e>DropDownList</FilterEditType><Key>Line</Key><Position>11</Position></Column11>" & _
        "</Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group0 ID=""Group0"">" & _
        "<ColIndex>1</ColIndex></Group0></Groups><Key>OutsidePurchases</Key><SortKeys Col" & _
        "lection=""true""><SortKey0 ID=""SortKey0""><ColIndex>9</ColIndex></SortKey0></SortKe" & _
        "ys></RootTable></GridEXLayoutData>"
        Me.GrdOutsidePurchasesDetail.DesignTimeLayout = GridEXLayout9
        Me.GrdOutsidePurchasesDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdOutsidePurchasesDetail.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdOutsidePurchasesDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdOutsidePurchasesDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdOutsidePurchasesDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdOutsidePurchasesDetail.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdOutsidePurchasesDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdOutsidePurchasesDetail.Name = "GrdOutsidePurchasesDetail"
        Me.GrdOutsidePurchasesDetail.Size = New System.Drawing.Size(634, 338)
        Me.GrdOutsidePurchasesDetail.TabIndex = 20
        Me.GrdOutsidePurchasesDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdPayment
        '
        Me.GrdPayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPayment.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPayment.DataMember = "PaymentDtl"
        Me.GrdPayment.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout10.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>18</Width></Column0><Column1 ID" & _
        "=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>desc_vendor</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc" & _
        "_vendor</Key><Position>1</Position><TextAlignment>Near</TextAlignment><Visible>F" & _
        "alse</Visible><Width>116</Width></Column1><Column2 ID=""no_of_check""><Caption>Che" & _
        "ch No.</Caption><DataMember>no_of_check</DataMember><EditType>NoEdit</EditType><" & _
        "FilterEditType>TextBox</FilterEditType><Key>no_of_check</Key><Position>2</Positi" & _
        "on><Visible>False</Visible><Width>77</Width></Column2><Column3 ID=""ref""><Caption" & _
        ">Vendor Ref.</Caption><DataMember>ref</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><Key>ref</Key><Position>3</Position><TextAl" & _
        "ignment>Near</TextAlignment><Width>87</Width></Column3><Column4 ID=""date""><Capti" & _
        "on>Ref. Date</Caption><DataMember>date</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Ke" & _
        "y>date</Key><Position>4</Position><TextAlignment>Center</TextAlignment><Width>80" & _
        "</Width></Column4><Column5 ID=""Original""><AggregateFunction>Sum</AggregateFuncti" & _
        "on><Caption>Original Amount</Caption><DataMember>Original</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</Forma" & _
        "tString><Key>Original</Key><Position>5</Position><TextAlignment>Far</TextAlignme" & _
        "nt><Width>95</Width><TotalFormatString>c2</TotalFormatString></Column5><Column6 " & _
        "ID=""date_of_check""><Caption>Check Date</Caption><DataMember>date_of_check</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Format" & _
        "String>MM/dd/yyyy</FormatString><Key>date_of_check</Key><Position>6</Position></" & _
        "Column6><Column7 ID=""pay""><AggregateFunction>Sum</AggregateFunction><Caption>Amo" & _
        "unt Paid</Caption><DataMember>pay</DataMember><EditType>NoEdit</EditType><Filter" & _
        "EditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>pay</Key><P" & _
        "osition>7</Position><TextAlignment>Far</TextAlignment><Width>88</Width><TotalFor" & _
        "matString>c2</TotalFormatString></Column7><Column8 ID=""store""><Caption>Store Ref" & _
        ".</Caption><DataMember>store</DataMember><EditType>NoEdit</EditType><FilterEditT" & _
        "ype>TextBox</FilterEditType><Key>store</Key><Position>8</Position><TextAlignment" & _
        ">Near</TextAlignment><Width>89</Width></Column8><Column9 ID=""name_bank""><Caption" & _
        ">Bank</Caption><DataMember>name_bank</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><Key>name_bank</Key><Position>9</Position></" & _
        "Column9></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group0 ID=""" & _
        "Group0""><ColIndex>1</ColIndex></Group0><Group1 ID=""Group1""><ColIndex>2</ColIndex" & _
        "></Group1></Groups><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex" & _
        ">3</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdPayment.DesignTimeLayout = GridEXLayout10
        Me.GrdPayment.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPayment.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdPayment.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdPayment.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdPayment.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdPayment.Location = New System.Drawing.Point(0, 60)
        Me.GrdPayment.Name = "GrdPayment"
        Me.GrdPayment.Size = New System.Drawing.Size(634, 338)
        Me.GrdPayment.TabIndex = 21
        Me.GrdPayment.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdVendorList
        '
        Me.GrdVendorList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdVendorList.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdVendorList.DataMember = "VendorList"
        Me.GrdVendorList.DataSource = Me.DsFrmPrintVendor1
        GridEXLayout11.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>25</Width></Column0><Column1 ID" & _
        "=""cod_vendor""><Caption>Vendor</Caption><DataMember>cod_vendor</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_vendor</Ke" & _
        "y><Position>1</Position><TextAlignment>Center</TextAlignment><Width>66</Width></" & _
        "Column1><Column2 ID=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>d" & _
        "esc_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><Key>desc_vendor</Key><Position>2</Position><TextAlignment>Near</TextA" & _
        "lignment><Width>127</Width></Column2><Column3 ID=""address""><Caption>Address</Cap" & _
        "tion><DataMember>address</DataMember><EditType>NoEdit</EditType><Key>address</Ke" & _
        "y><Position>3</Position><Width>275</Width></Column3><Column4 ID=""city""><Caption>" & _
        "City</Caption><DataMember>city</DataMember><EditType>NoEdit</EditType><Key>city<" & _
        "/Key><Position>4</Position><Width>71</Width></Column4><Column5 ID=""state""><Capti" & _
        "on>State</Caption><DataMember>state</DataMember><EditType>NoEdit</EditType><Key>" & _
        "state</Key><Position>5</Position><Width>59</Width></Column5><Column6 ID=""zipcode" & _
        """><Caption>Zip</Caption><DataMember>zipcode</DataMember><EditType>NoEdit</EditTy" & _
        "pe><Key>zipcode</Key><Position>6</Position><Width>70</Width></Column6><Column7 I" & _
        "D=""phone""><Caption>Phone</Caption><DataMember>phone</DataMember><EditType>NoEdit" & _
        "</EditType><Key>phone</Key><Position>7</Position><Width>82</Width></Column7><Col" & _
        "umn8 ID=""AP""><Caption>AP Term</Caption><DataMember>ap_terms</DataMember><EditTyp" & _
        "e>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>AP</Key><Positio" & _
        "n>8</Position><TextAlignment>Center</TextAlignment><Width>67</Width></Column8><C" & _
        "olumn9 ID=""desc_vendor_type""><Caption>Type</Caption><DataMember>desc_vendor_type" & _
        "</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType>" & _
        "<Key>desc_vendor_type</Key><Position>9</Position><TextAlignment>Near</TextAlignm" & _
        "ent><Width>87</Width></Column9><Column10 ID=""desc_class""><Caption>Class</Caption" & _
        "><DataMember>desc_class</DataMember><EditType>NoEdit</EditType><FilterEditType>T" & _
        "extBox</FilterEditType><Key>desc_class</Key><Position>10</Position><TextAlignmen" & _
        "t>Near</TextAlignment><Width>70</Width></Column10><Column11 ID=""email""><Caption>" & _
        "Email</Caption><DataMember>email</DataMember><EditType>NoEdit</EditType><Key>ema" & _
        "il</Key><Position>11</Position></Column11></Columns><GroupCondition ID="""" /></Ro" & _
        "otTable></GridEXLayoutData>"
        Me.GrdVendorList.DesignTimeLayout = GridEXLayout11
        Me.GrdVendorList.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdVendorList.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdVendorList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdVendorList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdVendorList.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdVendorList.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdVendorList.Location = New System.Drawing.Point(0, 64)
        Me.GrdVendorList.Name = "GrdVendorList"
        Me.GrdVendorList.Size = New System.Drawing.Size(634, 338)
        Me.GrdVendorList.TabIndex = 22
        Me.GrdVendorList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdVendorBill
        '
        Me.GrdVendorBill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdVendorBill.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdVendorBill.DataSource = Me.DsFrmPrintVendor1.Vendor_bill
        GridEXLayout12.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>25</Width></Column0><Column1 ID" & _
        "=""cod_vendor""><Caption>Vendor</Caption><DataMember>cod_vendor</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_vendor</Ke" & _
        "y><Position>1</Position><TextAlignment>Center</TextAlignment><Width>66</Width></" & _
        "Column1><Column2 ID=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>d" & _
        "esc_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><Key>desc_vendor</Key><Position>2</Position><TextAlignment>Near</TextA" & _
        "lignment><Visible>False</Visible><Width>127</Width></Column2><Column3 ID=""Id_AP_" & _
        "bill_Head""><Caption>Ref No.</Caption><DataMember>Id_AP_bill_Head</DataMember><Ed" & _
        "itType>NoEdit</EditType><Key>Id_AP_bill_Head</Key><Position>3</Position><Width>7" & _
        "9</Width></Column3><Column4 ID=""ref_no""><Caption>Vendor Ref.</Caption><DataMembe" & _
        "r>ref_no</DataMember><EditType>NoEdit</EditType><Key>ref_no</Key><Position>4</Po" & _
        "sition><Width>86</Width></Column4><Column5 ID=""Ref_date""><Caption>Date</Caption>" & _
        "<DataMember>Ref_date</DataMember><EditType>NoEdit</EditType><FormatString>MM/dd/" & _
        "yyyy</FormatString><Key>Ref_date</Key><Position>5</Position><Width>81</Width></C" & _
        "olumn5><Column6 ID=""Amount""><AggregateFunction>Sum</AggregateFunction><Caption>A" & _
        "mount</Caption><DataMember>Amount</DataMember><EditType>NoEdit</EditType><Format" & _
        "String>c2</FormatString><Key>Amount</Key><Position>6</Position><TextAlignment>Fa" & _
        "r</TextAlignment><Width>86</Width><TotalFormatString>c2</TotalFormatString></Col" & _
        "umn6><Column7 ID=""AR_terms""><Caption>AP Terms</Caption><DataMember>AR_terms</Dat" & _
        "aMember><EditType>NoEdit</EditType><Key>AR_terms</Key><Position>7</Position><Wid" & _
        "th>89</Width></Column7><Column8 ID=""Min_due_date""><Caption>Due Date</Caption><Da" & _
        "taMember>Min_due_date</DataMember><EditType>NoEdit</EditType><FormatString>MM/dd" & _
        "/yyyy</FormatString><Key>Min_due_date</Key><Position>8</Position><Width>87</Widt" & _
        "h></Column8><Column9 ID=""disco""><AggregateFunction>Sum</AggregateFunction><Capti" & _
        "on>Discount</Caption><DataMember>disco</DataMember><EditType>NoEdit</EditType><F" & _
        "ormatString>c2</FormatString><Key>disco</Key><Position>9</Position><TextAlignmen" & _
        "t>Far</TextAlignment><Width>83</Width><TotalFormatString>c2</TotalFormatString><" & _
        "/Column9></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group0 ID=" & _
        """Group0""><ColIndex>2</ColIndex></Group0></Groups></RootTable></GridEXLayoutData>" & _
        ""
        Me.GrdVendorBill.DesignTimeLayout = GridEXLayout12
        Me.GrdVendorBill.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdVendorBill.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.Default
        Me.GrdVendorBill.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdVendorBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdVendorBill.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdVendorBill.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdVendorBill.Location = New System.Drawing.Point(0, 64)
        Me.GrdVendorBill.Name = "GrdVendorBill"
        Me.GrdVendorBill.Size = New System.Drawing.Size(634, 338)
        Me.GrdVendorBill.TabIndex = 23
        Me.GrdVendorBill.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmPrintVendor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 398)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdVendorBill)
        Me.Controls.Add(Me.GrdUnPaidDtl)
        Me.Controls.Add(Me.GrdVendorList)
        Me.Controls.Add(Me.GrdUnPaidSummery)
        Me.Controls.Add(Me.GrdCash)
        Me.Controls.Add(Me.GrdPayment)
        Me.Controls.Add(Me.GrdOutsidePurchasesSummary)
        Me.Controls.Add(Me.GrdInventoryPurchasesSummary)
        Me.Controls.Add(Me.GrdInventoryPurchasesDetail)
        Me.Controls.Add(Me.GrdCreditDetail)
        Me.Controls.Add(Me.GrdCreditSummary)
        Me.Controls.Add(Me.GrdOutsidePurchasesDetail)
        Me.MaximizeBox = True
        Me.Name = "FrmPrintVendor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmPrintVendor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdUnPaidDtl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdUnPaidSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCreditDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCreditSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdInventoryPurchasesDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdInventoryPurchasesSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdOutsidePurchasesSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdOutsidePurchasesDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVendorBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        UnpaidDetail = 1
        UnpaidSummery = 2
        CashDetail = 3
        CashSummery = 4
        CreditDetail = 5
        CreditSummary = 6
        InventoryPurchasesDetail = 7
        InventoryPurchasesSummary = 8
        OutsidePurchasesDetail = 9
        OutsidePurchasesSummary = 10
        Payment = 11
        VendorList = 12
        vendorBillDtl = 13
        VendorBillSum = 14
        OutsidePurchaseCore = 15
    End Enum
    Public KindOfReport As KindReport
    Public StrWhere As String
    Public StrFilter As String
    Public Date1 As String
    Public Date2 As String
    Dim ComName As String = SystemInformation.ComputerName
    Private Sub FrmPrintVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString

        execit(" CREATE VIEW dbo.View_AllUnPaidReceive_product_ap_Dtl as " & _
                     "   SELECT     dbo.Inv_Receive_product_Ap_Dtl.amount AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment, " & _
                     " dbo.Inv_Receive_Products_head.id_receive_ref, dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl,  " & _
"                       dbo.Inv_Receive_Products_head.cod_vendor, dbo.Inv_Receive_product_Ap_Dtl.due_date, " & _
"                           (SELECT     SUM(ROUND(Inv_Receive_product_dtl.qty, 2) * (ROUND(Inv_Receive_product_dtl.cost, 2) + ROUND(Inv_Receive_product_dtl.fet, 2)))  " & _
"                                                    - Inv_Receive_Products_head.Discount AS sumrec " & _
"                              FROM         Inv_Receive_Products_head INNER JOIN " & _
"                                                    Inv_Receive_product_dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_dtl.id_receive_ref " & _
"                              WHERE     (Inv_Receive_Products_head.id_receive_ref = dbo.Inv_Receive_Products_head.id_receive_ref) " & _
"                              GROUP BY Inv_Receive_Products_head.Discount) AS MainSumOriginalAmount " & _
" FROM         dbo.Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                       dbo.Inv_Receive_Products_head ON  " & _
"                       dbo.Inv_Receive_product_Ap_Dtl.id_receive_ref = dbo.Inv_Receive_Products_head.id_receive_ref LEFT OUTER JOIN " & _
"                       dbo.GL_AP_payment ON  " & _
"                       dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
" GROUP BY dbo.Inv_Receive_Products_head.id_receive_ref, dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl,  " & _
"                       dbo.Inv_Receive_product_Ap_Dtl.amount, dbo.Inv_Receive_Products_head.cod_vendor, dbo.Inv_Receive_product_Ap_Dtl.due_date " & _
                       "  ", CmdGeneral, False, True, "View_AllUnPaidReceive_product_ap_Dtl")



        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                FillUnPaidDetail()
            Case KindReport.UnpaidSummery
                FillUnPaidSummery()
            Case KindReport.CashDetail
                FillCashDetail()
            Case KindReport.CashSummery
                FillCashSummery()
            Case KindReport.CreditDetail
                FillCreditDetail()
            Case KindReport.CreditSummary
                FillCreditSummery()
            Case KindReport.InventoryPurchasesDetail
                FillInventoryPurchasesDetail()
            Case KindReport.InventoryPurchasesSummary
                FillInventoryPurchasesSummary()
            Case KindReport.OutsidePurchasesDetail
                FillOutsidePurchasesDetail()
            Case KindReport.OutsidePurchasesSummary
                FillOutsidePurchasesSummary()
            Case KindReport.Payment
                FillVendorPayment()
            Case KindReport.VendorList
                FillVendorList()
            Case KindReport.vendorBillDtl
                FillVendorBillDetail()
            Case KindReport.VendorBillSum
                FillVendorBillSummery()
            Case KindReport.OutsidePurchaseCore
                FillOutSidePurchaseCore()
        End Select

        If Date1.Trim.Length > 0 Then
            GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
        Else
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End If
        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
       
    End Sub



    Sub execit(ByVal thisst As String, ByRef thiscmd As System.Data.SqlClient.SqlCommand, Optional ByVal showerror As Boolean = False, Optional ByVal IsViewFlag As Boolean = False, Optional ByVal ViewName As String = "")
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        If IsViewFlag Then
            Try
                CmdGeneral.CommandText = " drop view [dbo].[" & ViewName.Trim & "]"
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
        End If
        Try
            thiscmd.CommandText = thisst
            thiscmd.ExecuteNonQuery()
        Catch ex As Exception
            If showerror Then
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub
    Private Sub FillUnPaidDetail()

        'DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
        '        "  service_out_purchases.invoice_date AS date, service_out_purchases.due_date AS due, ROUND(ISNULL(service_out_purchases.cost, 0), 2)  " & _
        '        "  AS Original, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay, ROUND(ROUND(ISNULL(service_out_purchases.cost, 0), 2)  " & _
        '        "  - ISNULL(SUM(GL_AP_payment.amount_pay), 0), 2) AS AmountDue, service_out_purchases.invoice_no AS ref,  " & _
        '        "  service_out_purchases.id_service_center AS store,'' as AP, 1 as flag " & _
        '        " FROM         GL_AP_payment RIGHT OUTER JOIN " & _
        '        "  inv_vendor INNER JOIN " & _
        '        "  service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
        '        "  GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND  " & _
        '        "  GL_AP_payment.radif = service_out_purchases.radif LEFT OUTER JOIN " & _
        '        "  inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor LEFT OUTER JOIN " & _
        '        "  inv_tab_vendor_type ON inv_vendor.vendor_type = inv_tab_vendor_type.vendor_type LEFT OUTER JOIN " & _
        '        "  inv_buyer ON inv_vendor.buyer_id = inv_buyer.buyer_id " & _
        '        "  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
        '        IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
        '        "  GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class,  " & _
        '        "  inv_buyer.desc_buyer, service_out_purchases.invoice_date, service_out_purchases.due_date, service_out_purchases.cost,  " & _
        '        "  service_out_purchases.invoice_no, service_out_purchases.id_service_center " & _
        '        " having  (ROUND(ROUND(ISNULL(service_out_purchases.cost, 0), 2)  - ISNULL(SUM(GL_AP_payment.amount_pay), 0), 2)) > 0 "

        'DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
        '        "  service_out_purchases.invoice_date AS date, service_out_purchases.due_date AS due, (ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.Qty, 0), 2))   " & _
        '        "  AS Original, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay, ROUND((ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.Qty, 0), 2))  " & _
        '        "  - ISNULL(SUM(GL_AP_payment.amount_pay), 0), 2) AS AmountDue, service_out_purchases.invoice_no AS ref,  " & _
        '        "  service_out_purchases.id_service_center AS store,'' as AP, 1 as flag " & _
        '        "  FROM service_center_dtl INNER JOIN " & _
        '        "  inv_vendor INNER JOIN " & _
        '        "  service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
        '        "  service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
        '        "  service_center_dtl.radif = service_out_purchases.radif LEFT OUTER JOIN " & _
        '        "  GL_AP_payment ON service_out_purchases.id_service_center = GL_AP_payment.id_service_center AND  " & _
        '        "  service_out_purchases.radif = GL_AP_payment.radif LEFT OUTER JOIN " & _
        '        "  inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor LEFT OUTER JOIN " & _
        '        "  inv_tab_vendor_type ON inv_vendor.vendor_type = inv_tab_vendor_type.vendor_type LEFT OUTER JOIN " & _
        '        "  inv_buyer ON inv_vendor.buyer_id = inv_buyer.buyer_id " & _
        '        "  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
        '        IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
        '        "  GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class,  " & _
        '        "  inv_buyer.desc_buyer, service_out_purchases.invoice_date, service_out_purchases.due_date, service_out_purchases.cost,  " & _
        '        "  service_out_purchases.invoice_no, service_out_purchases.id_service_center,service_center_dtl.qty " & _
        '        " having  (ROUND(ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.qty, 0), 2)  - ISNULL(SUM(GL_AP_payment.amount_pay), 0), 2)) > 0 "

        'DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
        '        "  service_out_purchases.invoice_date AS date, Service_out_purchases_Dtl.Due_Date AS due, ROUND(ISNULL(Service_out_purchases_Dtl.Cost,0), 2)   " & _
        '        "  AS Original, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay, ROUND(ROUND(ISNULL(Service_out_purchases_Dtl.Cost,0), 2)  " & _
        '        "  - ISNULL(SUM(GL_AP_payment.amount_pay), 0), 2) AS AmountDue, service_out_purchases.invoice_no AS ref,  " & _
        '        "  service_out_purchases.id_service_center AS store,service_out_purchases.AR_terms as AP, 1 as flag, dbo.ChangeDate(Service_out_purchases_Dtl.Due_Date) as OrderDate " & _
        '        " FROM         service_center_dtl INNER JOIN " & _
        '        " inv_vendor INNER JOIN " & _
        '        " service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
        '        " service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
        '        " service_center_dtl.radif = service_out_purchases.radif INNER JOIN " & _
        '        " Service_out_purchases_Dtl ON service_out_purchases.id_service_center = Service_out_purchases_Dtl.id_service_center AND  " & _
        '        " service_out_purchases.radif = Service_out_purchases_Dtl.radif LEFT OUTER JOIN " & _
        '        " GL_AP_payment ON service_out_purchases.id_service_center = GL_AP_payment.id_service_center AND  " & _
        '        " service_out_purchases.radif = GL_AP_payment.radif LEFT OUTER JOIN " & _
        '        " inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor LEFT OUTER JOIN " & _
        '        " inv_tab_vendor_type ON inv_vendor.vendor_type = inv_tab_vendor_type.vendor_type LEFT OUTER JOIN " & _
        '        " inv_buyer ON inv_vendor.buyer_id = inv_buyer.buyer_id " & _
        '        "  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
        '        IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
        '        "  GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class,  " & _
        '        "  inv_buyer.desc_buyer, service_out_purchases.invoice_date, Service_out_purchases_Dtl.Due_Date, Service_out_purchases_Dtl.Cost, Service_out_purchases.Cost,  " & _
        '        "  service_out_purchases.invoice_no, service_out_purchases.id_service_center,service_center_dtl.qty,service_out_purchases.AR_terms,service_center_dtl.qty,Service_out_purchases_Dtl.IDService_out_purchases_dtl " & _
        '        " having  (ROUND(ROUND(ISNULL(Service_out_purchases_Dtl.Cost, 0), 2)  - ISNULL(SUM(GL_AP_payment.amount_pay), 0), 2)) > 0 " & _
        '        " ORDER BY inv_vendor.desc_vendor,service_out_purchases.id_service_center, dbo.ChangeDate(Service_out_purchases_Dtl.Due_Date)"

        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
"                       service_out_purchases.invoice_date AS date, View_AllUnPaidService_out_purchase.Due_Date AS due,  " & _
"                       View_AllUnPaidService_out_purchase.Cost AS Original, View_AllUnPaidService_out_purchase.sumpayment AS pay,  " & _
"                       View_AllUnPaidService_out_purchase.Cost  - View_AllUnPaidService_out_purchase.sumpayment AS AmountDue,  " & _
"                       service_out_purchases.invoice_no AS ref, service_out_purchases.id_service_center AS store, service_out_purchases.AR_terms AS AP, 0 AS disco, 1 AS flag,dbo.ChangeDate(View_AllUnPaidService_out_purchase.Due_Date) as OrderDate " & _
" FROM         inv_tab_vendor_class RIGHT OUTER JOIN " & _
"                       inv_buyer RIGHT OUTER JOIN " & _
"                       service_out_purchases INNER JOIN " & _
"                       service_center_head ON service_out_purchases.id_service_center = service_center_head.id_service_center INNER JOIN " & _
"                       inv_vendor ON service_out_purchases.cod_vendor = inv_vendor.cod_vendor INNER JOIN " & _
"                       View_AllUnPaidService_out_purchase ON service_out_purchases.id_service_center = View_AllUnPaidService_out_purchase.id_service_center AND  " & _
"                       service_out_purchases.radif = View_AllUnPaidService_out_purchase.radif LEFT OUTER JOIN " & _
"                       inv_tab_vendor_type ON inv_vendor.vendor_type = inv_tab_vendor_type.vendor_type ON inv_buyer.buyer_id = inv_vendor.buyer_id ON  " & _
"                       inv_tab_vendor_class.class_vendor = inv_vendor.class_vendor " & _
" WHERE     (service_out_purchases.PaidFlag = 0) AND (View_AllUnPaidService_out_purchase.Cost <> View_AllUnPaidService_out_purchase.sumpayment) AND  " & _
"                       (service_center_head.type_of_form = 'IN') AND ((service_out_purchases.id_service_center + STR(service_out_purchases.radif)) IN " & _
"                           (SELECT     id_service_center + str(radif) " & _
"                              FROM         View_AllUnPaidService_out_purchase))  " & _
   IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
" ORDER BY inv_vendor.desc_vendor, service_out_purchases.id_service_center, dbo.ChangeDate(View_AllUnPaidService_out_purchase.Due_Date) "

        DAUnPaidDetail.Fill(DsFrmPrintVendor1.UnpaidDetail)




        'DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
        '        "  Inv_Receive_Products_head.receipt_bill_date AS date, Inv_Receive_product_Ap_Dtl.due_date AS due,  " & _
        '        "  ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2) AS Original, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay,  " & _
        '        "  ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2) - ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS AmountDue,  " & _
        '        "  Inv_Receive_Products_head.vendor_ref_no AS ref, Inv_Receive_Products_head.id_receive_ref AS store, Inv_Receive_Products_head.ap_term AS ap,  " & _
        '        "  Inv_Receive_Products_head.Discount AS disco,1 as flag ,dbo.ChangeDate(Inv_Receive_product_Ap_Dtl.due_date) as OrderDate" & _
        '        " FROM         GL_AP_payment RIGHT OUTER JOIN " & _
        '        " inv_vendor INNER JOIN " & _
        '        " Inv_Receive_Products_head ON inv_vendor.cod_vendor = Inv_Receive_Products_head.cod_vendor INNER JOIN " & _
        '        " Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref INNER JOIN " & _
        '        " View_RecieveReturnTotal ON Inv_Receive_Products_head.id_receive_ref = View_RecieveReturnTotal.id_receive_ref ON  " & _
        '        " GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl LEFT OUTER JOIN " & _
        '        " inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor LEFT OUTER JOIN " & _
        '        " inv_tab_vendor_type ON inv_vendor.vendor_type = inv_tab_vendor_type.vendor_type LEFT OUTER JOIN " & _
        '        " inv_buyer ON inv_vendor.buyer_id = inv_buyer.buyer_id " & _
        '        IIf(StrWhere.Trim.Length > 0, " WHERE  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
        '        " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class,  " & _
        '        "   inv_buyer.desc_buyer, Inv_Receive_Products_head.receipt_bill_date, Inv_Receive_product_Ap_Dtl.due_date, Inv_Receive_product_Ap_Dtl.amount, " & _
        '        "  Inv_Receive_Products_head.vendor_ref_no, Inv_Receive_Products_head.id_receive_ref, Inv_Receive_Products_head.ap_term,  " & _
        '        "  Inv_Receive_Products_head.Discount, View_RecieveReturnTotal.TotalPrice " & _
        '        " HAVING (ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2) - ISNULL(SUM(GL_AP_payment.amount_pay), 0)) > 0  " & _
        '        "ORDER BY inv_vendor.desc_vendor,Inv_Receive_Products_head.id_receive_ref, dbo.ChangeDate(Inv_Receive_product_Ap_Dtl.due_date) "



        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
"                       Inv_Receive_Products_head.receipt_bill_date AS DATE, Inv_Receive_product_Ap_Dtl.due_date AS due,  " & _
"                       View_AllUnPaidReceive_product_ap_Dtl.MainSumOriginalAmount AS Original, View_AllUnPaidReceive_product_ap_Dtl.sumpayment AS pay,  " & _
"                       View_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount - View_AllUnPaidReceive_product_ap_Dtl.sumpayment AS AmountDue,  " & _
"                       Inv_Receive_Products_head.vendor_ref_no AS ref, Inv_Receive_Products_head.id_receive_ref AS store, Inv_Receive_Products_head.ap_term AS ap,  " & _
"                       Inv_Receive_Products_head.Discount AS disco, 1 AS flag,dbo.ChangeDate(Inv_Receive_product_Ap_Dtl.due_date) as OrderDate " & _
" FROM         Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                       Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref INNER JOIN " & _
"                       View_AllUnPaidReceive_product_ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = View_AllUnPaidReceive_product_ap_Dtl.id_receive_ref AND " & _
"        Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = View_AllUnPaidReceive_product_ap_Dtl.ID_Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                       inv_vendor ON Inv_Receive_Products_head.cod_vendor = inv_vendor.cod_vendor LEFT OUTER JOIN" & _
"                       inv_tab_vendor_type ON inv_vendor.vendor_type = inv_tab_vendor_type.vendor_type LEFT OUTER JOIN " & _
"                       inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor LEFT OUTER JOIN " & _
"                       inv_buyer ON inv_vendor.buyer_id = inv_buyer.buyer_id " & _
" WHERE     (Inv_Receive_product_Ap_Dtl.id_receive_ref IN " & _
"                           (SELECT     id_receive_ref " & _
"                              FROM         View_AllUnPaidReceive_product_ap_Dtl)) AND  " & _
"                       (View_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount <> View_AllUnPaidReceive_product_ap_Dtl.sumpayment) AND  " & _
"                       (NOT (Inv_Receive_product_Ap_Dtl.due_date IS NULL)) AND (LTRIM(RTRIM(Inv_Receive_product_Ap_Dtl.due_date)) <> '') " & _
  IIf(StrWhere.Trim.Length > 0, " and  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and " & " dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
 " ORDER BY inv_vendor.desc_vendor,Inv_Receive_Products_head.id_receive_ref, dbo.ChangeDate(Inv_Receive_product_Ap_Dtl.due_date) "

        DAUnPaidDetail.Fill(DsFrmPrintVendor1.UnpaidDetail)

        'DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
        '        "   GL_AP_Bill_Head.Date_Bill AS DATE, GL_AP_bill_Dtl_Dtl.due_date AS due,  " & _
        '        " ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2) AS original, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay,  " & _
        '        "  ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2) - ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS AmountDue, GL_AP_bill_Dtl.ref_no AS ref,  " & _
        '        "  GL_AP_bill_Dtl.Id_AP_bill_Head AS store, GL_AP_bill_Dtl.AR_terms AS ap, ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2) AS disco,1 as flag,dbo.ChangeDate(GL_AP_bill_Dtl_Dtl.due_date) as OrderDate " & _
        '        " FROM         inv_buyer RIGHT OUTER JOIN " & _
        '        "  inv_tab_vendor_type RIGHT OUTER JOIN " & _
        '        "  GL_AP_payment RIGHT OUTER JOIN " & _
        '        "  GL_AP_bill_Dtl_Dtl INNER JOIN " & _
        '        "  GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
        '        " GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
        '        "  inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON  " & _
        '        "  GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl LEFT OUTER JOIN " & _
        '        "  inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor ON  " & _
        '        " inv_tab_vendor_type.vendor_type = inv_vendor.vendor_type ON inv_buyer.buyer_id = inv_vendor.buyer_id " & _
        '        IIf(StrWhere.Trim.Length > 0, " Where  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
        '        " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class,  " & _
        '        " inv_buyer.desc_buyer, GL_AP_Bill_Head.Date_Bill, GL_AP_bill_Dtl_Dtl.due_date, GL_AP_bill_Dtl_Dtl.amount,  " & _
        '        " GL_AP_bill_Dtl.ref_no,GL_AP_bill_Dtl.Id_AP_bill_Head, GL_AP_bill_Dtl.Discount, GL_AP_bill_Dtl.AR_terms,GL_AP_bill_Dtl.amount " & _
        '        " having ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2) - ISNULL(SUM(GL_AP_payment.amount_pay), 0) > 0 " & _
        '        " ORDER BY inv_vendor.desc_vendor,GL_AP_bill_Dtl.Id_AP_bill_Head, dbo.ChangeDate(GL_AP_bill_Dtl_Dtl.due_date)"


        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_buyer.desc_buyer,  " & _
        "                       case when len(ltrim(rtrim(GL_AP_Bill_Head.Date_Bill)))=10 then GL_AP_Bill_Head.Date_Bill else null end AS date, case when len(ltrim(rtrim(GL_AP_bill_Dtl_Dtl.due_date)))=10 then GL_AP_bill_Dtl_Dtl.due_date else null end AS due, ROUND(ISNULL(GL_AP_bill_Dtl.amount, 0)  " & _
        "                       - ISNULL(GL_AP_bill_Dtl.Discount, 0), 2) AS original, ROUND(ISNULL(View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment, 0), 2) AS pay,  " & _
        "                       ROUND(ISNULL(View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount, 0) - ISNULL(View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment, 0), 2)  " & _
        "                       AS AmountDue, GL_AP_bill_Dtl.ref_no AS ref, GL_AP_bill_Dtl.Id_AP_bill_Head AS store, GL_AP_bill_Dtl.AR_terms AS ap,  " & _
        "                       ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2) AS disco, 1 AS flag ,dbo.ChangeDate(GL_AP_bill_Dtl_Dtl.due_date) as OrderDate" & _
         " FROM         GL_AP_bill_Dtl_Dtl INNER JOIN " & _
        "                       GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
        "                       GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
        "                       View_AllUnPaidGl_Ap_Bill_Dtl_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.Id_AP_bill_dtl_dtl INNER JOIN " & _
        "                       inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor LEFT OUTER JOIN " & _
        "                       inv_buyer ON inv_vendor.buyer_id = inv_buyer.buyer_id LEFT OUTER JOIN  " & _
        "                       inv_tab_vendor_type ON inv_vendor.vendor_type = inv_tab_vendor_type.vendor_type LEFT OUTER JOIN " & _
        "                       inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor " & _
         " WHERE   (GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl IN " & _
        "                           (SELECT     id_ap_bill_dtl_dtl " & _
        "                              FROM         View_AllUnPaidGl_Ap_Bill_Dtl_Dtl)) AND  " & _
        "                       (View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount <> View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment) AND  " & _
        "                       (NOT (GL_AP_bill_Dtl_Dtl.due_date IS NULL)) " & _
         IIf(StrWhere.Trim.Length > 0, " and  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and " & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
        " ORDER BY inv_vendor.desc_vendor,GL_AP_bill_Dtl.Id_AP_bill_Head, dbo.ChangeDate(GL_AP_bill_Dtl_Dtl.due_date)"

        DAUnPaidDetail.Fill(DsFrmPrintVendor1.UnpaidDetail)

        GrdUnPaidDtl.BringToFront()
    End Sub
    Private Sub FillUnPaidSummery()
        Dim CmdGeneral As New SqlClient.SqlCommand("", Cnn)
        Dim sselect As String
        Try
            'CmdGeneral.CommandText = " CREATE VIEW dbo.View_UnPaid_Vendor_" & ComName & _
            '       " AS " & _
            '       " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2)) AS Original,  " & _
            '       "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2))  " & _
            '       "   - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(Inv_Receive_Products_head.Discount, 0), 2))  " & _
            '       " AS disco,Inv_Receive_product_Ap_Dtl.due_date AS due " & _
            '       " FROM         inv_vendor INNER JOIN " & _
            '       "  Inv_Receive_Products_head ON inv_vendor.cod_vendor = Inv_Receive_Products_head.cod_vendor INNER JOIN " & _
            '       "  Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref LEFT OUTER JOIN " & _
            '       "  GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
            '        IIf(StrWhere.Trim.Length > 0, " Where " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
            '       " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,Inv_Receive_product_Ap_Dtl.due_date " & _
            '       " UNION " & _
            '       " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2)) AS Original,   " & _
            '       "     SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2))  " & _
            '       " - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2)) AS disco, GL_AP_bill_Dtl_Dtl.due_date  as due " & _
            '       " FROM         GL_AP_payment RIGHT OUTER JOIN " & _
            '       "  GL_AP_bill_Dtl_Dtl INNER JOIN " & _
            '        " GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
            '       "  GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
            '       "  inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON  " & _
            '       "  GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl " & _
            '        IIf(StrWhere.Trim.Length > 0, " where  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
            '       " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_bill_Dtl_Dtl.due_date  " & _
            '       " UNION " & _
            '       " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(service_out_purchases.cost, 0), 2)) AS Original,  " & _
            '       "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(service_out_purchases.cost, 0), 2))  " & _
            '       "  - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, 0 AS disco,service_out_purchases.due_date as due " & _
            '       " FROM         GL_AP_payment RIGHT OUTER JOIN " & _
            '       "  inv_vendor INNER JOIN " & _
            '       "  service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
            '       "  GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND GL_AP_payment.radif = service_out_purchases.radif " & _
            '       "  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
            '       IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
            '       " GROUP  BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,service_out_purchases.due_date "

            sselect = " CREATE VIEW dbo.View_UnPaid_Vendor_" & ComName & _
       " AS " & _
       " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, View_AllUnPaidService_out_purchase.sumoriginalamount AS Original,  " & _
"                       SUM(ROUND(ISNULL(View_AllUnPaidService_out_purchase.sumpayment, 0), 2)) AS pay,  " & _
"                       SUM(ROUND(ISNULL(View_AllUnPaidService_out_purchase.Cost - View_AllUnPaidService_out_purchase.sumpayment, 0), 2)) AS AmountDue,  " & _
"                       0 AS disco, View_AllUnPaidService_out_purchase.Due_Date  AS due,View_AllUnPaidService_out_purchase.id_service_center as id1,View_AllUnPaidService_out_purchase.radif  as id2" & _
" FROM         View_AllUnPaidService_out_purchase INNER JOIN " & _
"                       service_out_purchases INNER JOIN " & _
"                       service_center_head ON service_out_purchases.id_service_center = service_center_head.id_service_center INNER JOIN " & _
"                       inv_vendor ON service_out_purchases.cod_vendor = inv_vendor.cod_vendor ON  " & _
"                       View_AllUnPaidService_out_purchase.id_service_center = service_out_purchases.id_service_center AND  " & _
"                       View_AllUnPaidService_out_purchase.radif = service_out_purchases.radif " & _
" WHERE     (service_out_purchases.PaidFlag = 0) AND (View_AllUnPaidService_out_purchase.Cost <> View_AllUnPaidService_out_purchase.sumpayment) AND  " & _
"                       (service_center_head.type_of_form = 'IN') AND ((service_out_purchases.id_service_center + STR(service_out_purchases.radif)) IN " & _
"                           (SELECT     id_service_center + str(radif) " & _
"                              FROM         View_AllUnPaidService_out_purchase)) " & _
IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
" GROUP BY View_AllUnPaidService_out_purchase.Due_Date, inv_vendor.cod_vendor, inv_vendor.desc_vendor,  " & _
"                       View_AllUnPaidService_out_purchase.sumoriginalamount, View_AllUnPaidService_out_purchase.id_service_center,View_AllUnPaidService_out_purchase.radif  " & _
" union " & _
" SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, View_AllUnPaidReceive_product_ap_Dtl.MainSumOriginalAmount AS Original,  " & _
"                       SUM(ROUND(ISNULL(View_AllUnPaidReceive_product_ap_Dtl.sumpayment, 0), 2)) AS pay,  " & _
"                       SUM(ROUND(ISNULL(View_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount - View_AllUnPaidReceive_product_ap_Dtl.sumpayment, 0), 2))  " & _
"                       AS AmountDue, Inv_Receive_Products_head.Discount AS disco, Inv_Receive_product_Ap_Dtl.due_date AS due ,View_AllUnPaidReceive_product_ap_Dtl.id_receive_ref as id1, View_AllUnPaidReceive_product_ap_Dtl.ID_Inv_Receive_product_Ap_Dtl as id2" & _
" FROM         Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                       Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref INNER JOIN " & _
"                       View_AllUnPaidReceive_product_ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = View_AllUnPaidReceive_product_ap_Dtl.id_receive_ref AND  " & _
"                      Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = View_AllUnPaidReceive_product_ap_Dtl.ID_Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                       inv_vendor ON Inv_Receive_Products_head.cod_vendor = inv_vendor.cod_vendor " & _
" WHERE     (Inv_Receive_product_Ap_Dtl.id_receive_ref IN " & _
"                          (SELECT     id_receive_ref " & _
"                              FROM         View_AllUnPaidReceive_product_ap_Dtl)) AND  " & _
"                       (View_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount <> View_AllUnPaidReceive_product_ap_Dtl.sumpayment) AND  " & _
"                       (NOT (Inv_Receive_product_Ap_Dtl.due_date IS NULL)) AND (LTRIM(RTRIM(Inv_Receive_product_Ap_Dtl.due_date)) <> '') " & _
 IIf(StrWhere.Trim.Length > 0, " AND " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
" GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, View_AllUnPaidReceive_product_ap_Dtl.MainSumOriginalAmount,  " & _
"                       Inv_Receive_Products_head.due_date, Inv_Receive_Products_head.Discount, Inv_Receive_product_Ap_Dtl.due_date,View_AllUnPaidReceive_product_ap_Dtl.id_receive_ref, View_AllUnPaidReceive_product_ap_Dtl.ID_Inv_Receive_product_Ap_Dtl " & _
" union " & _
" SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, ROUND(ISNULL(GL_AP_bill_Dtl.amount, 0) - ISNULL(GL_AP_bill_Dtl.Discount, 0), 2) AS Original,  " & _
"                       SUM(ROUND(ISNULL(View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment, 0), 2)) AS pay,  " & _
"                       SUM(ROUND(ISNULL(View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount, 0) - ISNULL(View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment, 0), 2))  " & _
"                       AS AmountDue, ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2) AS disco, GL_AP_bill_Dtl_Dtl.due_date AS due,GL_AP_Bill_Head.Id_AP_bill_Head as id1, View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.Id_AP_bill_dtl_dtl as id2 " & _
" FROM         GL_AP_bill_Dtl_Dtl INNER JOIN " & _
"                       GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
"                       GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
"                       View_AllUnPaidGl_Ap_Bill_Dtl_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.Id_AP_bill_dtl_dtl INNER JOIN " & _
"                       inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor " & _
" WHERE     (GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl IN " & _
"                          (SELECT     id_ap_bill_dtl_dtl" & _
"                              FROM         View_AllUnPaidGl_Ap_Bill_Dtl_Dtl)) AND  " & _
"                       (View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount <> View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment) AND  " & _
"                       (NOT (GL_AP_bill_Dtl_Dtl.due_date IS NULL)) " & _
IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND " & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
" GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_bill_Dtl.amount, GL_AP_bill_Dtl.Discount, GL_AP_bill_Dtl.Discount,  " & _
"                       GL_AP_bill_Dtl_Dtl.due_date ,GL_AP_Bill_Head.Id_AP_bill_Head, View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.Id_AP_bill_dtl_dtl"


            '" SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2)) AS Original,  " & _
            '"  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2))  " & _
            '"   - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(Inv_Receive_Products_head.Discount, 0), 2))  " & _
            '" AS disco,Inv_Receive_product_Ap_Dtl.due_date AS due " & _
            '" FROM         inv_vendor INNER JOIN " & _
            '"  Inv_Receive_Products_head ON inv_vendor.cod_vendor = Inv_Receive_Products_head.cod_vendor INNER JOIN " & _
            '"  Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref LEFT OUTER JOIN " & _
            '"  GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
            ' IIf(StrWhere.Trim.Length > 0, " Where " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
            '" GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,Inv_Receive_product_Ap_Dtl.due_date " & _
            '" UNION " & _
            '" SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2)) AS Original,   " & _
            '"     SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2))  " & _
            '" - SUM(ROUND(ISN  ULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2)) AS disco, GL_AP_bill_Dtl_Dtl.due_date  as due " & _
            '" FROM         GL_AP_payment RIGHT OUTER JOIN " & _
            '"  GL_AP_bill_Dtl_Dtl INNER JOIN " & _
            ' " GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
            '"  GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
            '"  inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON  " & _
            '"  GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl " & _
            ' IIf(StrWhere.Trim.Length > 0, " where  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
            '" GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_bill_Dtl_Dtl.due_date  " & _
            '" UNION " & _
            '" SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.qty, 0), 2)) AS Original,  " & _
            '"  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.qty, 0), 2))  " & _
            '"  - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, 0 AS disco,service_out_purchases.due_date as due " & _
            '"  FROM  service_center_dtl INNER JOIN " & _
            '"  inv_vendor INNER JOIN " & _
            '"  service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
            '"  service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
            '"  service_center_dtl.radif = service_out_purchases.radif LEFT OUTER JOIN " & _
            '"  GL_AP_payment ON service_out_purchases.id_service_center = GL_AP_payment.id_service_center AND  " & _
            '"  service_out_purchases.radif = GL_AP_payment.radif " & _
            '"  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
            'IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
            '" GROUP  BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,service_out_purchases.due_date "

            CmdGeneral.CommandText = sselect

            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CmdGeneral.CommandText = " drop view [dbo].[View_UnPaid_Vendor_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
            CmdGeneral.CommandText = sselect

            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()

            Cnn.Close()
        End Try

        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     SUM(ROUND(ISNULL(Original, 0), 2)) AS Original, SUM(ROUND(ISNULL(pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(AmountDue, 0), 2)) AS AmountDue,  " & _
                " SUM(ROUND(ISNULL(disco, 0), 2)) AS disco, cod_vendor, desc_vendor, case when len(ltrim(rtrim(due)))=10 then due else null end as due,1 as flag " & _
                " FROM         View_UnPaid_Vendor_" & ComName & _
                " GROUP BY cod_vendor, desc_vendor, due " '& _
        '" HAVING      (SUM(ROUND(ISNULL(AmountDue, 0), 2)) > 0) "

        DAUnPaidDetail.Fill(DsFrmPrintVendor1.UnpaidSummery)


        Try
            CmdGeneral.CommandText = " drop view [dbo].[View_UnPaid_Vendor_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try

        GrdUnPaidSummery.BringToFront()
    End Sub
    Private Sub FillCashDetail()
        Dim CmdGeneral As New SqlClient.SqlCommand("", Cnn)

        CmdGeneral.CommandText = " CREATE VIEW dbo.View_Cash_Vendor_" & ComName & _
                               " AS " & _
                               " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount , 0), 2)) AS Original,  " & _
                               "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2))  " & _
                               " - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(Inv_Receive_Products_head.Discount, 0), 2)) " & _
                               " AS disco, Inv_Receive_product_Ap_Dtl.due_date AS due, Inv_Receive_Products_head.vendor_ref_no AS ref " & _
                               " FROM         inv_vendor INNER JOIN " & _
                               "  Inv_Receive_Products_head ON inv_vendor.cod_vendor = Inv_Receive_Products_head.cod_vendor INNER JOIN " & _
                               "  Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref LEFT OUTER JOIN " & _
                               "  GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
                                IIf(StrWhere.Trim.Length > 0, " Where " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                               " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, Inv_Receive_product_Ap_Dtl.due_date, Inv_Receive_Products_head.vendor_ref_no " & _
                               " UNION " & _
                               " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2)) AS Original,  " & _
                               "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2))  " & _
                               "  - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2)) AS disco,  " & _
                               "  GL_AP_bill_Dtl_Dtl.due_date AS due, GL_AP_bill_Dtl.ref_no AS ref " & _
                               " FROM         GL_AP_payment RIGHT OUTER JOIN " & _
                               "  GL_AP_bill_Dtl_Dtl INNER JOIN " & _
                               "  GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
                               "  GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
                               "  inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON  " & _
                               "  GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl " & _
                                IIf(StrWhere.Trim.Length > 0, " where  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                               " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_bill_Dtl_Dtl.due_date, GL_AP_bill_Dtl.ref_no " & _
                               " UNION " & _
                               " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(service_out_purchases.cost* service_center_dtl.qty, 0), 2)) AS Original,  " & _
                               "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(service_out_purchases.cost* service_center_dtl.qty, 0), 2))  " & _
                               "  - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, 0 AS disco, service_out_purchases.due_date AS due,  " & _
                               "  service_out_purchases.invoice_no AS ref " & _
                               " FROM         service_center_dtl INNER JOIN " & _
                               " inv_vendor INNER JOIN " & _
                               " service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
                               " service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
                               " service_center_dtl.radif = service_out_purchases.radif LEFT OUTER JOIN " & _
                               " GL_AP_payment ON service_out_purchases.id_service_center = GL_AP_payment.id_service_center AND  " & _
                               " service_out_purchases.radif = GL_AP_payment.radif " & _
                               "  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
                               IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                               " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, service_out_purchases.due_date, service_out_purchases.invoice_no "
        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try

        DACash.SelectCommand.CommandText = " SELECT     cod_vendor, desc_vendor, Original, pay, AmountDue, disco, case when len(ltrim(rtrim(due)))=10 then due else null end as due, CASE WHEN DATEDIFF(day, due, { fn NOW() })  " & _
                "  > 0 THEN AmountDue ELSE 0 END AS PastDue, CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 10 AND DATEDIFF(day, { fn NOW() }, due)  " & _
                "  >= 0 THEN AmountDue ELSE 0 END AS Remain10Day, CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 30 AND DATEDIFF(day, { fn NOW() }, due)  " & _
                "  >= 10 THEN AmountDue ELSE 0 END AS Remain30Day, CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 60 AND DATEDIFF(day, { fn NOW() }, due)  " & _
                "  >= 30 THEN AmountDue ELSE 0 END AS Remain60Day, CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 90 AND DATEDIFF(day, { fn NOW() }, due)  " & _
                "  >= 60 THEN AmountDue ELSE 0 END AS Remain90Day, CASE WHEN DATEDIFF(day, { fn NOW() }, due)  " & _
                "  > 90 THEN AmountDue ELSE 0 END AS Over90Day, ref,1 as flag " & _
                " FROM         View_Cash_Vendor_" & ComName & _
                " where AmountDue > 0 " & _
                " ORDER BY ref "

        Try
            DACash.Fill(DsFrmPrintVendor1.CashDetail)
            CmdGeneral.CommandText = " drop view [dbo].[View_Cash_Vendor_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try
        GrdCash.BringToFront()

    End Sub
    Private Sub FillCashSummery()
        Dim CmdGeneral As New SqlClient.SqlCommand("", Cnn)
        Try
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Cash_Summery_Vendor_" & ComName & _
                   " AS " & _
                   " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2)) AS Original,  " & _
                   "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2))  " & _
                   "   - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(Inv_Receive_Products_head.Discount, 0), 2))  " & _
                   " AS disco,Inv_Receive_product_Ap_Dtl.due_date AS due " & _
                   " FROM         inv_vendor INNER JOIN " & _
                   "  Inv_Receive_Products_head ON inv_vendor.cod_vendor = Inv_Receive_Products_head.cod_vendor INNER JOIN " & _
                   "  Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref LEFT OUTER JOIN " & _
                   "  GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
                    IIf(StrWhere.Trim.Length > 0, " Where " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                   " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,Inv_Receive_product_Ap_Dtl.due_date " & _
                   " UNION " & _
                   " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2)) AS Original,   " & _
                   "     SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2))  " & _
                   " - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2)) AS disco, GL_AP_bill_Dtl_Dtl.due_date  as due " & _
                   " FROM         GL_AP_payment RIGHT OUTER JOIN " & _
                   "  GL_AP_bill_Dtl_Dtl INNER JOIN " & _
                    " GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
                   "  GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
                   "  inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON  " & _
                   "  GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl " & _
                    IIf(StrWhere.Trim.Length > 0, " where  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                   " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_bill_Dtl_Dtl.due_date  " & _
                   " UNION " & _
                   " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.qty, 0), 2)) AS Original,  " & _
                   "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.qty, 0), 2))  " & _
                   "  - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, 0 AS disco,service_out_purchases.due_date as due " & _
                   " FROM         service_center_dtl INNER JOIN " & _
                   " inv_vendor INNER JOIN " & _
                   " service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
                   " service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
                   " service_center_dtl.radif = service_out_purchases.radif LEFT OUTER JOIN " & _
                   " GL_AP_payment ON service_out_purchases.id_service_center = GL_AP_payment.id_service_center AND  " & _
                   " service_out_purchases.radif = GL_AP_payment.radif " & _
                   "  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
                   IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                   " GROUP  BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,service_out_purchases.due_date "

            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception
            Try
                CmdGeneral.CommandText = " drop view [dbo].[View_Cash_Summery_Vendor_" & ComName & "] "
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()
            Catch ex1 As Exception
            End Try

            Try
                CmdGeneral.CommandText = " CREATE VIEW dbo.View_Cash_Summery_Vendor_" & ComName & _
       " AS " & _
       " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2)) AS Original,  " & _
       "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(Inv_Receive_product_Ap_Dtl.amount, 0), 2))  " & _
       "   - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(Inv_Receive_Products_head.Discount, 0), 2))  " & _
       " AS disco,Inv_Receive_product_Ap_Dtl.due_date AS due " & _
       " FROM         inv_vendor INNER JOIN " & _
       "  Inv_Receive_Products_head ON inv_vendor.cod_vendor = Inv_Receive_Products_head.cod_vendor INNER JOIN " & _
       "  Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref LEFT OUTER JOIN " & _
       "  GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
        IIf(StrWhere.Trim.Length > 0, " Where " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
       " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,Inv_Receive_product_Ap_Dtl.due_date " & _
       " UNION " & _
       " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2)) AS Original,   " & _
       "     SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(GL_AP_bill_Dtl_Dtl.amount, 0), 2))  " & _
       " - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2)) AS disco, GL_AP_bill_Dtl_Dtl.due_date  as due " & _
       " FROM         GL_AP_payment RIGHT OUTER JOIN " & _
       "  GL_AP_bill_Dtl_Dtl INNER JOIN " & _
        " GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
       "  GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
       "  inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON  " & _
       "  GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl " & _
        IIf(StrWhere.Trim.Length > 0, " where  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, IIf(StrWhere.Trim.Length > 0, " and ", " where") & " dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
       " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_bill_Dtl_Dtl.due_date  " & _
       " UNION " & _
       " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, SUM(ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.qty, 0), 2)) AS Original,  " & _
       "  SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS pay, SUM(ROUND(ISNULL(service_out_purchases.cost * service_center_dtl.qty, 0), 2))  " & _
       "  - SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS AmountDue, 0 AS disco,service_out_purchases.due_date as due " & _
       " FROM         service_center_dtl INNER JOIN " & _
       " inv_vendor INNER JOIN " & _
       " service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
       " service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
       " service_center_dtl.radif = service_out_purchases.radif LEFT OUTER JOIN " & _
       " GL_AP_payment ON service_out_purchases.id_service_center = GL_AP_payment.id_service_center AND  " & _
       " service_out_purchases.radif = GL_AP_payment.radif " & _
       "  WHERE     (service_out_purchases.id_service_center LIKE 'IN%')" & _
       IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " AND  dbo.ChangeDate(service_out_purchases.invoice_date) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
       " GROUP  BY inv_vendor.cod_vendor, inv_vendor.desc_vendor,service_out_purchases.due_date "

                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()
            Catch ex2 As Exception

            End Try

        End Try


        DACash.SelectCommand.CommandText = " SELECT     cod_vendor, desc_vendor, case when len(ltrim(rtrim(due)))=10 then due else null end as due,  " & _
                       " CASE WHEN DATEDIFF(day, due, { fn NOW() }) > 0 THEN SUM(ROUND(ISNULL(AmountDue, 0), 2)) ELSE 0 END AS PastDue,  " & _
                       " CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 10 AND DATEDIFF(day, { fn NOW() }, due) >= 0 THEN SUM(ROUND(ISNULL(AmountDue, 0), 2))  " & _
                       " ELSE 0 END AS Remain10Day, CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 30 AND DATEDIFF(day, { fn NOW() }, due)  " & _
                       " >= 10 THEN SUM(ROUND(ISNULL(AmountDue, 0), 2)) ELSE 0 END AS Remain30Day, CASE WHEN DATEDIFF(day, { fn NOW() }, due) < 60 AND  " & _
                       " DATEDIFF(day, { fn NOW() }, due) >= 30 THEN SUM(ROUND(ISNULL(AmountDue, 0), 2)) ELSE 0 END AS Remain60Day, CASE WHEN DATEDIFF(day,  " & _
                       " { fn NOW() }, due) < 90 AND DATEDIFF(day, { fn NOW() }, due) >= 60 THEN SUM(ROUND(ISNULL(AmountDue, 0), 2)) ELSE 0 END AS Remain90Day, " & _
                       " CASE WHEN DATEDIFF(day, { fn NOW() }, due) > 90 THEN SUM(ROUND(ISNULL(AmountDue, 0), 2)) ELSE 0 END AS Over90Day ,1 as flag" & _
                    " FROM         View_Cash_Summery_Vendor_" & ComName & _
                    " where AmountDue >0  " & _
                    " GROUP BY cod_vendor, desc_vendor, due " & _
                    " ORDER BY cod_vendor "

        DACash.Fill(DsFrmPrintVendor1.CashDetail)

        Try
            CmdGeneral.CommandText = " drop view [dbo].[View_Cash_Summery_Vendor_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try

        GrdCash.RootTable.Columns(2).Visible = False
        GrdCash.RootTable.Columns(3).Visible = False
        GrdCash.RootTable.Columns(4).Visible = False
        GrdCash.RootTable.Columns(5).Visible = False

        GrdCash.BringToFront()
    End Sub
    Private Sub FillCreditDetail()
        DAGeneral.SelectCommand.CommandText = " SELECT     ROUND(GL_vendor_credit.amount_credit, 2) AS amount_credit, GL_vendor_credit.cod_vendor, inv_vendor.desc_vendor,case when len(ltrim(rtrim(GL_vendor_credit.date_credit)))=10 then GL_vendor_credit.date_credit else GL_vendor_credit.date_credit end  as date_credit," & _
                       " GL_vendor_credit.Remark, case when len(ltrim(rtrim(GL_vendor_credit.due_date)))=10 then GL_vendor_credit.due_date else null end  as due_date, GL_vendor_credit.id_vendor_credit, GL_vendor_credit.ref_no,1 as flag " & _
                       " FROM   GL_vendor_credit LEFT OUTER JOIN " & _
                       " inv_vendor ON GL_vendor_credit.cod_vendor = inv_vendor.cod_vendor " & _
                       "  WHERE  1=1 " & _
                IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(GL_vendor_credit.date_credit) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "")

        DAGeneral.Fill(DsFrmPrintVendor1.CreditDetail)
        GrdCreditDetail.BringToFront()

    End Sub
    Private Sub FillCreditSummery()
        DAGeneral.SelectCommand.CommandText = " SELECT     SUM(ROUND(GL_vendor_credit.amount_credit, 2)) AS amount_credit, GL_vendor_credit.cod_vendor, inv_vendor.desc_vendor ,1 as Flag  " & _
                    " FROM  GL_vendor_credit LEFT OUTER JOIN inv_vendor ON GL_vendor_credit.cod_vendor = inv_vendor.cod_vendor " & _
                    " Where 1=1 " & _
                    IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(GL_vendor_credit.date_credit) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                    " GROUP BY GL_vendor_credit.cod_vendor, inv_vendor.desc_vendor "

        DAGeneral.Fill(DsFrmPrintVendor1.CreditSummary)
        GrdCreditSummary.BringToFront()
    End Sub
    Private Sub FillInventoryPurchasesDetail()
        DAGeneral.SelectCommand.CommandText = " SELECT     inv_vendor.desc_vendor, Inv_Receive_Products_head.cod_vendor, Inv_Receive_Products_head.id_receive_ref, " & _
                       "                      Inv_Receive_Products_head.date_receive, Inv_Receive_Products_head.vendor_ref_no, Inv_Receive_Products_head.po_no, " & _
                       "                      CASE Inv_Receive_Products_head.bill_credit WHEN '1' Then View_RecieveReturnTotal.TotalPrice Else -1 * View_RecieveReturnTotal.TotalPrice END AS TotalPrice, " & _
                       "   CASE Inv_Receive_Products_head.bill_credit WHEN '1' Then View_RecieveReturnTotal.TotalQty Else -1 * View_RecieveReturnTotal.TotalQty END AS TotalQty, " & _
                       "   CASE WHEN ltrim(rtrim(Inv_Receive_Products_head.receipt_bill_date)) <> '' THEN Inv_Receive_Products_head.receipt_bill_date ELSE NULL END AS receipt_bill_date,1 as flag " & _
                       " FROM         Inv_Receive_Products_head INNER JOIN " & _
                       "                      View_RecieveReturnTotal ON Inv_Receive_Products_head.id_receive_ref = View_RecieveReturnTotal.id_receive_ref INNER JOIN " & _
                       "                      inv_vendor ON Inv_Receive_Products_head.cod_vendor = inv_vendor.cod_vendor " & _
                       "  WHERE  1=1 " & _
                IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "")

        DAGeneral.Fill(DsFrmPrintVendor1.InventoryPurchasesDetail)
        GrdInventoryPurchasesDetail.BringToFront()
    End Sub
    Private Sub FillInventoryPurchasesSummary()
        DAGeneral.SelectCommand.CommandText = "SELECT     SUM(CASE Inv_Receive_Products_head.bill_credit WHEN '1' THEN View_RecieveReturnTotal.TotalPrice ELSE - 1 * View_RecieveReturnTotal.TotalPrice END) AS TotalPrice, " & _
                       " SUM(CASE Inv_Receive_Products_head.bill_credit WHEN '1' THEN View_RecieveReturnTotal.TotalQty ELSE - 1 * View_RecieveReturnTotal.TotalQty END) " & _
                       " AS TotalQty, inv_vendor.desc_vendor, Inv_Receive_Products_head.cod_vendor,1 as flag " & _
                       " FROM         Inv_Receive_Products_head INNER JOIN " & _
                       " View_RecieveReturnTotal ON Inv_Receive_Products_head.id_receive_ref = View_RecieveReturnTotal.id_receive_ref INNER JOIN " & _
                       " inv_vendor ON Inv_Receive_Products_head.cod_vendor = inv_vendor.cod_vendor " & _
                       "  WHERE  1=1 " & _
                IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                       " GROUP BY inv_vendor.desc_vendor, Inv_Receive_Products_head.cod_vendor "

        DAGeneral.Fill(DsFrmPrintVendor1.InventoryPurchasesSummary)
        GrdInventoryPurchasesSummary.BringToFront()
    End Sub
    Private Sub FillOutsidePurchasesDetail()
        DAGeneral.SelectCommand.CommandText = " SELECT     service_out_purchases.id_service_center, service_center_dtl.cod_select AS ItemNo, service_center_dtl.desc_radif AS ItemDesc,  " & _
                       " service_center_dtl.qty, service_center_dtl.qty * (service_center_dtl.price + service_center_dtl.fet) AS ExtPrice,  " & _
                       " service_center_dtl.qty * service_out_purchases.cost AS ExtCost, service_out_purchases.po_no, service_out_purchases.cod_vendor,  " & _
                       " inv_vendor.desc_vendor, service_out_purchases.invoice_no AS VendorRef,1 as flag,service_out_purchases.Line " & _
                       " FROM         service_out_purchases INNER JOIN " & _
                       " service_center_dtl ON service_out_purchases.id_service_center = service_center_dtl.id_service_center AND  " & _
                       " service_out_purchases.radif = service_center_dtl.radif INNER JOIN " & _
                       " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                       " inv_vendor ON service_out_purchases.cod_vendor = inv_vendor.cod_vendor " & _
                       "  WHERE service_center_head.type_of_form='IN'  " & _
                IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_center_head.date_refer) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "")

        DAGeneral.Fill(DsFrmPrintVendor1.OutsidePurchasesDetail)
        GrdOutsidePurchasesDetail.BringToFront()
    End Sub
    Private Sub FillOutsidePurchasesSummary()
        DAGeneral.SelectCommand.CommandText = " SELECT  sum(service_center_dtl.qty) as qty, sum(service_center_dtl.qty * (service_center_dtl.price + service_center_dtl.fet)) AS ExtPrice,  " & _
                       " sum(service_center_dtl.qty * service_out_purchases.cost) AS ExtCost,   " & _
                       " service_out_purchases.cod_vendor,inv_vendor.desc_vendor,1 as flag " & _
                       " FROM         service_out_purchases INNER JOIN " & _
                       " service_center_dtl ON service_out_purchases.id_service_center = service_center_dtl.id_service_center AND  " & _
                       " service_out_purchases.radif = service_center_dtl.radif INNER JOIN " & _
                       " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                       " inv_vendor ON service_out_purchases.cod_vendor = inv_vendor.cod_vendor " & _
                       "  WHERE service_center_head.type_of_form='IN'  " & _
                IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_center_head.date_refer) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                       " Group by service_out_purchases.cod_vendor,inv_vendor.desc_vendor "
        DAGeneral.Fill(DsFrmPrintVendor1.OutsidePurchasesSummary)
        GrdOutsidePurchasesSummary.BringToFront()
    End Sub
    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                For i As Integer = 0 To DsFrmPrintVendor1.UnpaidDetail.Count - 1
                    DsFrmPrintVendor1.UnpaidDetail(i).flag = False
                Next
            Case KindReport.UnpaidSummery
                For i As Integer = 0 To DsFrmPrintVendor1.UnpaidSummery.Count - 1
                    DsFrmPrintVendor1.UnpaidSummery(i).flag = False
                Next
            Case KindReport.CreditDetail
                For i As Integer = 0 To DsFrmPrintVendor1.CreditDetail.Count - 1
                    DsFrmPrintVendor1.CreditDetail(i).flag = False
                Next
            Case KindReport.CreditSummary
                For i As Integer = 0 To DsFrmPrintVendor1.CreditSummary.Count - 1
                    DsFrmPrintVendor1.CreditSummary(i).flag = False
                Next
            Case KindReport.InventoryPurchasesDetail
                For i As Integer = 0 To DsFrmPrintVendor1.InventoryPurchasesDetail.Count - 1
                    DsFrmPrintVendor1.InventoryPurchasesDetail(i).flag = False
                Next
            Case KindReport.InventoryPurchasesSummary
                For i As Integer = 0 To DsFrmPrintVendor1.InventoryPurchasesSummary.Count - 1
                    DsFrmPrintVendor1.InventoryPurchasesSummary(i).flag = False
                Next
            Case KindReport.OutsidePurchasesDetail, KindReport.OutsidePurchaseCore
                For i As Integer = 0 To DsFrmPrintVendor1.OutsidePurchasesDetail.Count - 1
                    DsFrmPrintVendor1.OutsidePurchasesDetail(i).flag = False
                Next
            Case KindReport.OutsidePurchasesSummary
                For i As Integer = 0 To DsFrmPrintVendor1.OutsidePurchasesSummary.Count - 1
                    DsFrmPrintVendor1.OutsidePurchasesSummary(i).flag = False
                Next
            Case KindReport.Payment
                For i As Integer = 0 To DsFrmPrintVendor1.PaymentDtl.Count - 1
                    DsFrmPrintVendor1.PaymentDtl(i).flag = False
                Next
            Case KindReport.VendorList
                For i As Integer = 0 To DsFrmPrintVendor1.VendorList.Count - 1
                    DsFrmPrintVendor1.VendorList(i).flag = False
                Next
            Case KindReport.vendorBillDtl, KindReport.VendorBillSum
                For i As Integer = 0 To DsFrmPrintVendor1.Vendor_bill.Count - 1
                    DsFrmPrintVendor1.Vendor_bill(i).flag = False
                Next
        End Select
        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                For i As Integer = 0 To DsFrmPrintVendor1.UnpaidDetail.Count - 1
                    DsFrmPrintVendor1.UnpaidDetail(i).flag = True
                Next
            Case KindReport.UnpaidSummery
                For i As Integer = 0 To DsFrmPrintVendor1.UnpaidSummery.Count - 1
                    DsFrmPrintVendor1.UnpaidSummery(i).flag = True
                Next
            Case KindReport.CreditDetail
                For i As Integer = 0 To DsFrmPrintVendor1.CreditDetail.Count - 1
                    DsFrmPrintVendor1.CreditDetail(i).flag = True
                Next
            Case KindReport.CreditSummary
                For i As Integer = 0 To DsFrmPrintVendor1.CreditSummary.Count - 1
                    DsFrmPrintVendor1.CreditSummary(i).flag = True
                Next
            Case KindReport.InventoryPurchasesDetail
                For i As Integer = 0 To DsFrmPrintVendor1.InventoryPurchasesDetail.Count - 1
                    DsFrmPrintVendor1.InventoryPurchasesDetail(i).flag = True
                Next
            Case KindReport.InventoryPurchasesSummary
                For i As Integer = 0 To DsFrmPrintVendor1.InventoryPurchasesSummary.Count - 1
                    DsFrmPrintVendor1.InventoryPurchasesSummary(i).flag = True
                Next
            Case KindReport.OutsidePurchasesDetail, KindReport.OutsidePurchaseCore
                For i As Integer = 0 To DsFrmPrintVendor1.OutsidePurchasesDetail.Count - 1
                    DsFrmPrintVendor1.OutsidePurchasesDetail(i).flag = True
                Next
            Case KindReport.OutsidePurchasesSummary
                For i As Integer = 0 To DsFrmPrintVendor1.OutsidePurchasesSummary.Count - 1
                    DsFrmPrintVendor1.OutsidePurchasesSummary(i).flag = True
                Next
            Case KindReport.Payment
                For i As Integer = 0 To DsFrmPrintVendor1.PaymentDtl.Count - 1
                    DsFrmPrintVendor1.PaymentDtl(i).flag = True
                Next
            Case KindReport.VendorList
                For i As Integer = 0 To DsFrmPrintVendor1.VendorList.Count - 1
                    DsFrmPrintVendor1.VendorList(i).flag = True
                Next
            Case KindReport.vendorBillDtl, KindReport.VendorBillSum
                For i As Integer = 0 To DsFrmPrintVendor1.Vendor_bill.Count - 1
                    DsFrmPrintVendor1.Vendor_bill(i).flag = True
                Next
        End Select
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub
    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                GridEXPrintDocument1.GridEX = GrdUnPaidDtl
                GridEXPrintDocument1.PrintHierarchical = True
            Case KindReport.UnpaidSummery
                GridEXPrintDocument1.GridEX = GrdUnPaidSummery
            Case KindReport.CreditDetail
                GridEXPrintDocument1.GridEX = GrdCreditDetail
            Case KindReport.CreditSummary
                GridEXPrintDocument1.GridEX = GrdCreditSummary
            Case KindReport.InventoryPurchasesDetail
                GridEXPrintDocument1.GridEX = GrdInventoryPurchasesDetail
            Case KindReport.InventoryPurchasesSummary
                GridEXPrintDocument1.GridEX = GrdInventoryPurchasesSummary
            Case KindReport.OutsidePurchasesDetail, KindReport.OutsidePurchaseCore
                GridEXPrintDocument1.GridEX = GrdOutsidePurchasesDetail
            Case KindReport.OutsidePurchasesSummary
                GridEXPrintDocument1.GridEX = GrdOutsidePurchasesSummary
            Case KindReport.Payment
                GridEXPrintDocument1.GridEX = GrdPayment
            Case KindReport.VendorList
                GridEXPrintDocument1.GridEX = GrdVendorList
            Case KindReport.vendorBillDtl, KindReport.VendorBillSum
                GridEXPrintDocument1.GridEX = GrdVendorBill
            Case KindReport.CashDetail, KindReport.CashSummery
                GridEXPrintDocument1.GridEX = GrdCash
        End Select
        Dim filter As GridEXFilterCondition
        Dim filter1 As GridEXFilterCondition = GridEXPrintDocument1.GridEX.RootTable.FilterCondition
        filter = New GridEXFilterCondition(GridEXPrintDocument1.GridEX.RootTable.Columns("flag"), ConditionOperator.Equal, True)
        'filter1 = GridEXPrintDocument1.GridEX.RootTable.FilterCondition
        If filter1 Is Nothing Then
            filter1 = New GridEXFilterCondition
        End If
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = Nothing
        filter1.AddCondition(LogicalOperator.And, filter)
        Try
            GridEXPrintDocument1.GridEX.RootTable.FilterCondition = filter1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        GridEXPrintDocument1.GridEX.RootTable.Columns("flag").Visible = False

        PrintPreviewDialog1.ShowDialog()
        'Grd1.RemoveFilters()
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = Nothing
        filter1.RemoveCondition(filter)
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = filter1
        GridEXPrintDocument1.GridEX.RootTable.Columns("flag").Visible = True
    End Sub

    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim FileName As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = "report.CSV"
        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdUnPaidDtl)
            Case KindReport.UnpaidSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdUnPaidSummery)
            Case KindReport.CreditDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCreditDetail)
            Case KindReport.CreditSummary
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCreditSummary)
            Case KindReport.Payment
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdPayment)
            Case KindReport.VendorList
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdVendorList)
            Case KindReport.vendorBillDtl, KindReport.VendorBillSum
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdVendorBill)
            Case KindReport.OutsidePurchaseCore, KindReport.OutsidePurchasesDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdOutsidePurchasesDetail)
        End Select
    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                Me.GrdUnPaidDtl.ShowFieldChooser(Me)
            Case KindReport.UnpaidSummery
                Me.GrdUnPaidSummery.ShowFieldChooser(Me)
            Case KindReport.CreditDetail
                Me.GrdCreditDetail.ShowFieldChooser(Me)
            Case KindReport.CreditSummary
                Me.GrdCreditSummary.ShowFieldChooser(Me)
            Case KindReport.Payment
                Me.GrdPayment.ShowFieldChooser(Me)
            Case KindReport.VendorList
                Me.GrdVendorList.ShowFieldChooser(Me)
            Case KindReport.InventoryPurchasesDetail
                Me.GrdInventoryPurchasesDetail.ShowFieldChooser(Me)
            Case KindReport.InventoryPurchasesSummary
                Me.GrdInventoryPurchasesSummary.ShowFieldChooser(Me)
            Case KindReport.OutsidePurchasesDetail, KindReport.OutsidePurchaseCore
                Me.GrdOutsidePurchasesDetail.ShowFieldChooser(Me)
            Case KindReport.OutsidePurchasesSummary
                Me.GrdOutsidePurchasesSummary.ShowFieldChooser(Me)
            Case KindReport.CashDetail
                Me.GrdCash.ShowFieldChooser(Me)
            Case KindReport.CashSummery
                Me.GrdCash.ShowFieldChooser(Me)
            Case KindReport.vendorBillDtl, KindReport.VendorBillSum
                Me.GrdVendorBill.ShowFieldChooser(Me)

        End Select
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                Call printUnpaidDetail("print")
            Case KindReport.UnpaidSummery
                printUnpaidSummery("print")
            Case KindReport.CashDetail
                printCashDetail("print")
                'Case KindReport.CreditDetail
                '    printCreditDetail("print")
                'Case KindReport.CreditSummary
                '    printCreditSummary("print")
        End Select
    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Select Case KindOfReport
            Case KindReport.UnpaidDetail
                Call printUnpaidDetail("priv")
            Case KindReport.UnpaidSummery
                printUnpaidSummery("priv")
            Case KindReport.CashDetail
                printCashDetail("priv")
                'Case KindReport.CreditDetail
                '    printCreditDetail("priv")
                'Case KindReport.CashSummery
                '    printCreditSummary("priv")
        End Select
    End Sub
    Private Sub printUnpaidDetail(ByVal type As String)

        Dim rpt As New RepUnPaidDtl
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintVendor1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub printUnpaidSummery(ByVal type As String)

        Dim rpt As New RepUnpaidSummery
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintVendor1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub printCashDetail(ByVal type As String)

        Dim rpt As New RepCashDtl
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintVendor1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub


    Private Sub FillVendorPayment()


        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, case when len(ltrim(rtrim(service_out_purchases.invoice_date)))=10 then service_out_purchases.invoice_date else null end AS date, ROUND(ISNULL(service_out_purchases.cost, 0)  " & _
                       " * service_center_dtl.qty, 2) AS Original, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay, service_out_purchases.invoice_no AS ref,  " & _
                       " service_out_purchases.id_service_center AS store, case when len(ltrim(rtrim(bank_check.date_of_check)))=10 then bank_check.date_of_check else null end   as date_of_check, bank_check.no_of_check, 1 AS flag,bas_banks.name_bank " & _
                       " FROM         bank_check INNER JOIN " & _
                       " GL_AP_payment ON bank_check.id_check = GL_AP_payment.id_check  INNER JOIN " & _
                       " bas_banks ON bank_check.id_bank = bas_banks.id_bank RIGHT OUTER JOIN " & _
                       " service_center_dtl INNER JOIN " & _
                       " inv_vendor INNER JOIN " & _
                       " service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_vendor ON  " & _
                       " service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
                       " service_center_dtl.radif = service_out_purchases.radif INNER JOIN " & _
                       " Service_out_purchases_Dtl ON service_out_purchases.id_service_center = Service_out_purchases_Dtl.id_service_center AND  " & _
                       " service_out_purchases.radif = Service_out_purchases_Dtl.radif ON  " & _
                       " GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND GL_AP_payment.radif = service_out_purchases.radif " & _
                       " WHERE     (service_out_purchases.id_service_center LIKE 'IN%') AND (GL_AP_payment.amount_pay > 0) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                        IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_out_purchases.invoice_date ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                       " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, service_out_purchases.invoice_date, Service_out_purchases_Dtl.Due_Date,  " & _
                       " Service_out_purchases_Dtl.Cost, service_out_purchases.cost, service_out_purchases.invoice_no, service_out_purchases.id_service_center,  " & _
                       " service_center_dtl.qty, service_out_purchases.AR_terms, service_center_dtl.qty, bank_check.date_of_check, bank_check.no_of_check  , bas_banks.name_bank"

        DAUnPaidDetail.Fill(DsFrmPrintVendor1.PaymentDtl)

        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, case when len(ltrim(rtrim(Inv_Receive_Products_head.receipt_bill_date)))=10 then Inv_Receive_Products_head.receipt_bill_date else null end AS date,  " & _
                       " ROUND(ISNULL(View_RecieveReturnTotal.TotalPrice, 0), 2) AS Original, ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay,  " & _
                       " Inv_Receive_Products_head.vendor_ref_no AS ref, Inv_Receive_Products_head.id_receive_ref AS store, case when len(ltrim(rtrim(bank_check.date_of_check)))=10 then bank_check.date_of_check else null end   as date_of_check,  " & _
                       " bank_check.no_of_check, 1 AS flag,bas_banks.name_bank " & _
                       " FROM         GL_AP_payment INNER JOIN " & _
                       " bank_check ON GL_AP_payment.id_check = bank_check.id_check  INNER JOIN " & _
                       " bas_banks ON bank_check.id_bank = bas_banks.id_bank RIGHT OUTER JOIN " & _
                       " inv_vendor INNER JOIN " & _
                       " Inv_Receive_Products_head ON inv_vendor.cod_vendor = Inv_Receive_Products_head.cod_vendor INNER JOIN " & _
                       " Inv_Receive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref INNER JOIN " & _
                       " View_RecieveReturnTotal ON Inv_Receive_Products_head.id_receive_ref = View_RecieveReturnTotal.id_receive_ref ON  " & _
                       " GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl " & _
                       " WHERE     (GL_AP_payment.amount_pay > 0) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                       IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(Inv_Receive_Products_head.receipt_bill_date ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                       " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, Inv_Receive_Products_head.receipt_bill_date, Inv_Receive_Products_head.vendor_ref_no,  " & _
                       " Inv_Receive_Products_head.id_receive_ref, bank_check.date_of_check, bank_check.no_of_check, View_RecieveReturnTotal.TotalPrice,bas_banks.name_bank "

        DAUnPaidDetail.Fill(DsFrmPrintVendor1.PaymentDtl)

        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, case when len(ltrim(rtrim(GL_AP_Bill_Head.Date_Bill)))=10 then GL_AP_Bill_Head.Date_Bill else null end AS date, ROUND(ISNULL(GL_AP_bill_Dtl.amount, 0), 2) AS Original,  " & _
                       " ISNULL(SUM(GL_AP_payment.amount_pay), 0) AS pay, GL_AP_bill_Dtl.ref_no AS ref, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl AS store,  " & _
                       " case when len(ltrim(rtrim(bank_check.date_of_check)))=10 then bank_check.date_of_check else null end   as date_of_check, bank_check.no_of_check, 1 AS flag,bas_banks.name_bank " & _
                      " FROM         GL_AP_payment INNER JOIN " & _
                       " bank_check ON GL_AP_payment.id_check = bank_check.id_check  INNER JOIN " & _
                       " bas_banks ON bank_check.id_bank = bas_banks.id_bank  RIGHT OUTER JOIN " & _
                       " GL_AP_bill_Dtl_Dtl INNER JOIN " & _
                       " GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
                       " GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
                       " inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor ON  " & _
                       " GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl " & _
                       " WHERE     (GL_AP_payment.amount_pay > 0) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                       IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                       " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_Bill_Head.Date_Bill, GL_AP_bill_Dtl.ref_no, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl,  " & _
                       " bank_check.date_of_check, bank_check.no_of_check, GL_AP_payment.amount_pay, GL_AP_bill_Dtl.amount,bas_banks.name_bank "




        DAUnPaidDetail.Fill(DsFrmPrintVendor1.PaymentDtl)

        GrdPayment.BringToFront()
    End Sub

    Private Sub FillVendorList()




        DAUnPaidDetail.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vendor_type.desc_vendor_type, inv_tab_vendor_class.desc_class, inv_vendor.address,  " & _
                       " bas_zipcode.city, bas_zipcode.state, bas_zipcode.zipcode,  " & _
                       " CASE WHEN inv_vendor.phone_main_1 = 1 THEN inv_vendor.phone_1 WHEN inv_vendor.phone_main_2 = 1 THEN inv_vendor.phone_2 WHEN inv_vendor.phone_main_3 " & _
                       "  = 1 THEN inv_vendor.phone_3 WHEN inv_vendor.phone_main_4 = 1 THEN inv_vendor.phone_4 WHEN inv_vendor.phone_main_5 = 1 THEN inv_vendor.phone_5 " & _
                       "  END AS phone, inv_vendor.ap_terms, inv_vendor.email,1 as flag " & _
                       " FROM         inv_tab_vendor_type RIGHT OUTER JOIN " & _
                       " inv_vendor LEFT OUTER JOIN " & _
                       " bas_zipcode ON inv_vendor.zipcode = bas_zipcode.zipcode LEFT OUTER JOIN " & _
                       " inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_vendor ON " & _
                       " inv_tab_vendor_type.vendor_type = inv_vendor.vendor_type "





        DAUnPaidDetail.Fill(DsFrmPrintVendor1.VendorList)
        GrdVendorList.BringToFront()

    End Sub
    Private Sub FillVendorBillDetail()
        DAGeneral.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_Bill_Head.Id_AP_bill_Head, GL_AP_bill_Dtl.ref_no,case when len(ltrim(rtrim(GL_AP_bill_Dtl.Ref_date)))=10 then GL_AP_bill_Dtl.Ref_date else null  end  as Ref_date, " & _
                       " ROUND(ISNULL(GL_AP_bill_Dtl.amount, 0), 2) AS Amount, GL_AP_bill_Dtl.AR_terms,case when len(ltrim(rtrim(View_AP_Bill_Dtl_Min_due_date.Min_due_date))) = 10 then View_AP_Bill_Dtl_Min_due_date.Min_due_date else null end   as Min_due_date,  " & _
                       " ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2) AS disco,1 as flag " & _
                       " FROM         GL_AP_bill_Dtl INNER JOIN " & _
                       " GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
                       " inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor INNER JOIN " & _
                       " View_AP_Bill_Dtl_Min_due_date ON GL_AP_bill_Dtl.Id_AP_bill_dtl = View_AP_Bill_Dtl_Min_due_date.Id_AP_bill_dtl " & _
                       " where 1=1 " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                       " ORDER BY inv_vendor.desc_vendor,GL_AP_Bill_Head.Id_AP_bill_Head, GL_AP_bill_Dtl.ref_no "

        DAGeneral.Fill(DsFrmPrintVendor1.Vendor_bill)
        GrdVendorBill.BringToFront()

    End Sub
    Private Sub FillVendorBillSummery()


        'DAGeneral.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_Bill_Head.Id_AP_bill_Head, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.amount, 0), 2))  " & _
        '               " AS Amount, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2)) AS disco,1 as flag " & _
        '               " FROM         GL_AP_bill_Dtl INNER JOIN " & _
        '               " GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
        '               " inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor " & _
        '               " where 1=1 " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
        '               " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_Bill_Head.Id_AP_bill_Head " & _
        '               " ORDER BY inv_vendor.desc_vendor,GL_AP_Bill_Head.Id_AP_bill_Head "

        DAGeneral.SelectCommand.CommandText = " SELECT     inv_vendor.cod_vendor,'' as Id_AP_bill_Head, inv_vendor.desc_vendor,  SUM(ROUND(ISNULL(GL_AP_bill_Dtl.amount, 0), 2))  " & _
                   " AS Amount, SUM(ROUND(ISNULL(GL_AP_bill_Dtl.Discount, 0), 2)) AS disco,1 as flag " & _
                   " FROM         GL_AP_bill_Dtl INNER JOIN " & _
                   " GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
                   " inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor " & _
                   " where 1=1 " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill ) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "") & _
                   " GROUP BY inv_vendor.cod_vendor, inv_vendor.desc_vendor, GL_AP_Bill_Head.Id_AP_bill_Head " & _
                   " ORDER BY inv_vendor.desc_vendor "




        DAGeneral.Fill(DsFrmPrintVendor1.Vendor_bill)

        GrdVendorBill.RootTable.Columns.RemoveAt(8)
        GrdVendorBill.RootTable.Columns.RemoveAt(7)
        GrdVendorBill.RootTable.Columns.RemoveAt(5)
        GrdVendorBill.RootTable.Columns.RemoveAt(4)
        GrdVendorBill.RootTable.Columns.RemoveAt(3)

        GrdVendorBill.RootTable.Groups.RemoveAt(0)

        'GrdVendorBill.RootTable.Columns(4).Visible = False
        'GrdVendorBill.RootTable.Columns(5).Visible = False
        'GrdVendorBill.RootTable.Columns(7).Visible = False
        'GrdVendorBill.RootTable.Columns(8).Visible = False
        GrdVendorBill.BringToFront()
    End Sub
    Private Sub FillOutSidePurchaseCore()
        DAGeneral.SelectCommand.CommandText = " SELECT     service_out_purchases.id_service_center, service_center_dtl.cod_select AS ItemNo, service_center_dtl.desc_radif AS ItemDesc,  " & _
                            " service_center_dtl.qty, service_out_purchases.core_value AS ExtPrice,  " & _
                            " service_center_dtl.qty * service_out_purchases.cost AS ExtCost, service_out_purchases.po_no, service_out_purchases.cod_vendor,  " & _
                            " inv_vendor.desc_vendor, service_out_purchases.invoice_no AS VendorRef,1 as flag,service_out_purchases.Line " & _
                            " FROM         service_out_purchases INNER JOIN " & _
                            " service_center_dtl ON service_out_purchases.id_service_center = service_center_dtl.id_service_center AND  " & _
                            " service_out_purchases.radif = service_center_dtl.radif INNER JOIN " & _
                            " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                            " inv_vendor ON service_out_purchases.cod_vendor = inv_vendor.cod_vendor " & _
                            "  WHERE (service_center_head.type_of_form='IN') AND (service_out_purchases.tracking_core = 1) " & _
                     IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "") & IIf(Date1.Trim.Length > 0, " and  dbo.ChangeDate(service_center_head.date_refer) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2)), "")

        DAGeneral.Fill(DsFrmPrintVendor1.OutsidePurchasesDetail)
        GrdOutsidePurchasesDetail.RootTable.Columns(6).Caption = "Core Value"
        GrdOutsidePurchasesDetail.RootTable.Columns(7).Visible = False
        GrdOutsidePurchasesDetail.BringToFront()
    End Sub
    Dim x As Integer = 0
    Private Sub GridEXPrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles GridEXPrintDocument1.PrintPage
        x = x + 1
        GridEXPrintDocument1.PageFooterRight = x
    End Sub
    Private Sub GridEXPrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GridEXPrintDocument1.EndPrint
        x = 0
    End Sub
    Private Sub GrdUnPaidDtl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdUnPaidDtl.DoubleClick
        Try
            If GrdUnPaidDtl.RowCount > 0 And KindOfReport = KindReport.UnpaidDetail Then
                Dim Currentrow As GridEXRow = GrdUnPaidDtl.GetRow
                Select Case Mid(Currentrow.Cells("store").Value & "", 1, 2).ToUpper
                    Case "IN" ' Service Center
                        Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                        MyFrmShowWorkOrder.TypeOfForm = "IN"
                        MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("store").Value & ""
                        MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                        MyFrmShowWorkOrder.Show()
                    Case "IR" ' Recieve
                        Dim MyFrmReceiveReturnProduct As New UcReceiveReturnProduct.FrmReceiveReturnProduct
                        MyFrmReceiveReturnProduct.ShowPnlHead = False
                        MyFrmReceiveReturnProduct.CodReceiveReturnProduct = Currentrow.Cells("store").Value & ""
                        MyFrmReceiveReturnProduct.BillCredit = 1
                        MyFrmReceiveReturnProduct.StartPosition = FormStartPosition.CenterScreen
                        MyFrmReceiveReturnProduct.ShowDialog()
                    Case Else ' Ap Bill
                        Dim CmdGeneral As New SqlClient.SqlCommand("", Cnn)
                        If Cnn.State <> ConnectionState.Open Then
                            Cnn.Open()
                        End If
                        CmdGeneral.CommandText = "SELECT Top 1 GL_AP_bill_Dtl.Id_AP_bill_Head FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl Where Id_AP_bill_dtl_dtl=" & Currentrow.Cells("store").Value
                        Dim ID_HeadVar As String = CmdGeneral.ExecuteScalar() & ""
                        Dim MyFrmGL_AP_bill As New UCVendor.FrmGL_AP_bill
                        MyFrmGL_AP_bill.Id_AP_bill_HeadForShowReadOnly = ID_HeadVar & ""
                        MyFrmGL_AP_bill.StartPosition = FormStartPosition.CenterScreen
                        MyFrmGL_AP_bill.ShowDialog()
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub




End Class
