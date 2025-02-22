Imports CommonClass
Public Class FrmARCusReport
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents PanelTypeCus As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents PanelCus As System.Windows.Forms.Panel
    Friend WithEvents BtnCus As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllCus As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents DACustomer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmARCusReport1 As ReportCustomer.DSFrmARCusReport
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DA1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents NumericEditBox1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents PanelCharge As System.Windows.Forms.GroupBox
    Friend WithEvents UcCalcPastDue As CalcUtils.UcCalcText
    Friend WithEvents CalendarPayment As CalendarCombo.CalendarCombo
    Friend WithEvents ChkLastpayment As System.Windows.Forms.CheckBox
    Friend WithEvents CalendarActivity As CalendarCombo.CalendarCombo
    Friend WithEvents UcCalcBalance As CalcUtils.UcCalcText
    Friend WithEvents ChkBalance As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPastAmount As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPastDays As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLastActivity As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdSPFindDueDate As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmARCusReport))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.PanelInnerDate = New System.Windows.Forms.Panel
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkDate = New System.Windows.Forms.CheckBox
        Me.PanelTypeCus = New System.Windows.Forms.GroupBox
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.PanelCus = New System.Windows.Forms.Panel
        Me.BtnCus = New System.Windows.Forms.Button
        Me.RdoSelectedCus = New System.Windows.Forms.RadioButton
        Me.RdoAllCus = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.DACustomer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DsFrmARCusReport1 = New ReportCustomer.DSFrmARCusReport
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DA1 = New System.Data.SqlClient.SqlDataAdapter
        Me.NumericEditBox1 = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.UcCalcPastDue = New CalcUtils.UcCalcText
        Me.CalendarPayment = New CalendarCombo.CalendarCombo
        Me.PanelCharge = New System.Windows.Forms.GroupBox
        Me.UcCalcBalance = New CalcUtils.UcCalcText
        Me.CalendarActivity = New CalendarCombo.CalendarCombo
        Me.ChkBalance = New System.Windows.Forms.CheckBox
        Me.ChkPastAmount = New System.Windows.Forms.CheckBox
        Me.ChkPastDays = New System.Windows.Forms.CheckBox
        Me.ChkLastActivity = New System.Windows.Forms.CheckBox
        Me.ChkLastpayment = New System.Windows.Forms.CheckBox
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdSPFindDueDate = New System.Data.SqlClient.SqlCommand
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelInnerDate.SuspendLayout()
        Me.PanelTypeCus.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.PanelCus.SuspendLayout()
        CType(Me.DsFrmARCusReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCharge.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(502, 48)
        Me.Panel4.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(262, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range and any desired options followed by OK  to print the report"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 48)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(502, 48)
        Me.PanelDate.TabIndex = 0
        Me.PanelDate.TabStop = False
        '
        'PanelInnerDate
        '
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelInnerDate.Controls.Add(Me.Label2)
        Me.PanelInnerDate.Controls.Add(Me.Label3)
        Me.PanelInnerDate.Location = New System.Drawing.Point(152, 16)
        Me.PanelInnerDate.Name = "PanelInnerDate"
        Me.PanelInnerDate.Size = New System.Drawing.Size(320, 24)
        Me.PanelInnerDate.TabIndex = 6
        '
        'CalendarCombo1
        '
        Me.CalendarCombo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo1.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo1.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.EditableSal = True
        Me.CalendarCombo1.Image = CType(resources.GetObject("CalendarCombo1.Image"), System.Drawing.Image)
        Me.CalendarCombo1.Location = New System.Drawing.Point(48, 0)
        Me.CalendarCombo1.MaxValue = CType(2500, Short)
        Me.CalendarCombo1.MinValue = CType(1800, Short)
        Me.CalendarCombo1.Name = "CalendarCombo1"
        Me.CalendarCombo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo1.Sal_Mali = Nothing
        Me.CalendarCombo1.ShowButton = True
        Me.CalendarCombo1.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo1.TabIndex = 0
        Me.CalendarCombo1.VisualStyle = False
        '
        'CalendarCombo2
        '
        Me.CalendarCombo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo2.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo2.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.EditableSal = True
        Me.CalendarCombo2.Image = CType(resources.GetObject("CalendarCombo2.Image"), System.Drawing.Image)
        Me.CalendarCombo2.Location = New System.Drawing.Point(192, 0)
        Me.CalendarCombo2.MaxValue = CType(2500, Short)
        Me.CalendarCombo2.MinValue = CType(1800, Short)
        Me.CalendarCombo2.Name = "CalendarCombo2"
        Me.CalendarCombo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo2.Sal_Mali = Nothing
        Me.CalendarCombo2.ShowButton = True
        Me.CalendarCombo2.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo2.TabIndex = 1
        Me.CalendarCombo2.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(160, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'ChkDate
        '
        Me.ChkDate.Location = New System.Drawing.Point(40, 16)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.TabIndex = 5
        Me.ChkDate.Text = "All Dates"
        '
        'PanelTypeCus
        '
        Me.PanelTypeCus.Controls.Add(Me.PanelDetail)
        Me.PanelTypeCus.Controls.Add(Me.PanelCus)
        Me.PanelTypeCus.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeCus.Location = New System.Drawing.Point(0, 96)
        Me.PanelTypeCus.Name = "PanelTypeCus"
        Me.PanelTypeCus.Size = New System.Drawing.Size(502, 88)
        Me.PanelTypeCus.TabIndex = 1
        Me.PanelTypeCus.TabStop = False
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoSummery)
        Me.PanelDetail.Controls.Add(Me.RdoDetail)
        Me.PanelDetail.Location = New System.Drawing.Point(408, 16)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(80, 64)
        Me.PanelDetail.TabIndex = 8
        '
        'RdoSummery
        '
        Me.RdoSummery.Location = New System.Drawing.Point(8, 32)
        Me.RdoSummery.Name = "RdoSummery"
        Me.RdoSummery.Size = New System.Drawing.Size(72, 24)
        Me.RdoSummery.TabIndex = 1
        Me.RdoSummery.Text = "Summary"
        '
        'RdoDetail
        '
        Me.RdoDetail.Checked = True
        Me.RdoDetail.Location = New System.Drawing.Point(8, 8)
        Me.RdoDetail.Name = "RdoDetail"
        Me.RdoDetail.Size = New System.Drawing.Size(72, 24)
        Me.RdoDetail.TabIndex = 0
        Me.RdoDetail.TabStop = True
        Me.RdoDetail.Text = "Detail"
        '
        'PanelCus
        '
        Me.PanelCus.Controls.Add(Me.BtnCus)
        Me.PanelCus.Controls.Add(Me.RdoSelectedCus)
        Me.PanelCus.Controls.Add(Me.RdoAllCus)
        Me.PanelCus.Controls.Add(Me.Label4)
        Me.PanelCus.Location = New System.Drawing.Point(24, 24)
        Me.PanelCus.Name = "PanelCus"
        Me.PanelCus.Size = New System.Drawing.Size(376, 48)
        Me.PanelCus.TabIndex = 6
        '
        'BtnCus
        '
        Me.BtnCus.Enabled = False
        Me.BtnCus.Location = New System.Drawing.Point(272, 16)
        Me.BtnCus.Name = "BtnCus"
        Me.BtnCus.TabIndex = 2
        Me.BtnCus.Text = "Choose..."
        '
        'RdoSelectedCus
        '
        Me.RdoSelectedCus.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedCus.Name = "RdoSelectedCus"
        Me.RdoSelectedCus.Size = New System.Drawing.Size(128, 24)
        Me.RdoSelectedCus.TabIndex = 1
        Me.RdoSelectedCus.Text = "Selected Customers"
        '
        'RdoAllCus
        '
        Me.RdoAllCus.Checked = True
        Me.RdoAllCus.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllCus.Name = "RdoAllCus"
        Me.RdoAllCus.TabIndex = 0
        Me.RdoAllCus.TabStop = True
        Me.RdoAllCus.Text = "All Customers"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "For Customers"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(258, 349)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 29)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Location = New System.Drawing.Point(106, 351)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 27)
        Me.BtnOk.TabIndex = 3
        Me.BtnOk.Text = "OK"
        '
        'DACustomer
        '
        Me.DACustomer.SelectCommand = Me.SqlSelectCommand2
        Me.DACustomer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT DISTINCT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust" & _
        "_trtab_main.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main L" & _
        "EFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_co" & _
        "mpany WHERE (cust_trtab_main.AR_charge = 1)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=Tiremate_01"
        '
        'DsFrmARCusReport1
        '
        Me.DsFrmARCusReport1.DataSetName = "DSFrmARCusReport"
        Me.DsFrmARCusReport1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.cod_customer, cust_company.complete_name, service_center_h" & _
        "ead.date_refer, service_center_head.id_service_center, service_center_head.Total" & _
        ", cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main." & _
        "l_name AS name, pay4.payment4, pay2.payment2, GL_account_adjustment_dtl.adjustme" & _
        "nt, 0 AS due_date, 0 AS asdays_past, 0 AS ar_term, 0 AS payment_amount, 0 AS fla" & _
        "g FROM (SELECT SUM(amount_adjustment) AS adjustment, id_service_center FROM GL_a" & _
        "ccount_adjustment_dtl GROUP BY id_service_center) GL_account_adjustment_dtl RIGH" & _
        "T OUTER JOIN (SELECT SUM(GL_payment_deposit.payment_amount) AS payment2, service" & _
        "_center_head.id_service_center FROM service_center_head INNER JOIN GL_payment_de" & _
        "posit ON service_center_head.id_service_center = GL_payment_deposit.id_service_c" & _
        "enter WHERE (GL_payment_deposit.refer_type = 2) AND (service_center_head.type_of" & _
        "_form = 'IN') GROUP BY service_center_head.id_service_center) pay2 RIGHT OUTER J" & _
        "OIN service_center_head INNER JOIN cust_trtab_main ON service_center_head.cod_cu" & _
        "stomer = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab" & _
        "_main.cod_company = cust_company.cod_company LEFT OUTER JOIN (SELECT SUM(GL_paym" & _
        "ent_deposit.payment_amount) AS payment4, service_center_head.id_service_center F" & _
        "ROM service_center_head INNER JOIN GL_payment_deposit ON service_center_head.id_" & _
        "service_center = GL_payment_deposit.id_service_center WHERE (GL_payment_deposit." & _
        "payment_type = 4) AND (GL_payment_deposit.refer_type = 1) AND (service_center_he" & _
        "ad.type_of_form = 'IN') GROUP BY service_center_head.id_service_center) pay4 ON " & _
        "service_center_head.id_service_center = pay4.id_service_center ON pay2.id_servic" & _
        "e_center = service_center_head.id_service_center ON GL_account_adjustment_dtl.id" & _
        "_service_center = service_center_head.id_service_center WHERE (cust_trtab_main.A" & _
        "R_charge = 1)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DA1
        '
        Me.DA1.SelectCommand = Me.SqlSelectCommand1
        Me.DA1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center")})})
        '
        'NumericEditBox1
        '
        Me.NumericEditBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumericEditBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumericEditBox1.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumericEditBox1.DecimalDigits = 0
        Me.NumericEditBox1.Enabled = False
        Me.NumericEditBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumericEditBox1.Location = New System.Drawing.Point(288, 66)
        Me.NumericEditBox1.MaxLength = 4
        Me.NumericEditBox1.Name = "NumericEditBox1"
        Me.NumericEditBox1.Size = New System.Drawing.Size(110, 20)
        Me.NumericEditBox1.TabIndex = 5
        Me.NumericEditBox1.Text = "0"
        Me.NumericEditBox1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumericEditBox1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcCalcPastDue
        '
        Me.UcCalcPastDue.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.UcCalcPastDue.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.UcCalcPastDue.DecimalDigits = 2
        Me.UcCalcPastDue.DefaultSendValue = False
        Me.UcCalcPastDue.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.UcCalcPastDue.Enabled = False
        Me.UcCalcPastDue.FireTabAfterEnter = True
        Me.UcCalcPastDue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcCalcPastDue.ForeColor = System.Drawing.Color.Black
        Me.UcCalcPastDue.Image = CType(resources.GetObject("UcCalcPastDue.Image"), System.Drawing.Image)
        Me.UcCalcPastDue.Location = New System.Drawing.Point(288, 88)
        Me.UcCalcPastDue.Maxlength = 10
        Me.UcCalcPastDue.MinusColor = System.Drawing.Color.Empty
        Me.UcCalcPastDue.Name = "UcCalcPastDue"
        Me.UcCalcPastDue.Size = New System.Drawing.Size(110, 22)
        Me.UcCalcPastDue.TabIndex = 7
        Me.UcCalcPastDue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.UcCalcPastDue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CalendarPayment
        '
        Me.CalendarPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarPayment.BorderColor = System.Drawing.Color.Empty
        Me.CalendarPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarPayment.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarPayment.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarPayment.EditableSal = True
        Me.CalendarPayment.Enabled = False
        Me.CalendarPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CalendarPayment.ForeColor = System.Drawing.Color.Black
        Me.CalendarPayment.Image = CType(resources.GetObject("CalendarPayment.Image"), System.Drawing.Image)
        Me.CalendarPayment.Location = New System.Drawing.Point(288, 16)
        Me.CalendarPayment.MaxValue = CType(2500, Short)
        Me.CalendarPayment.MinValue = CType(1800, Short)
        Me.CalendarPayment.Name = "CalendarPayment"
        Me.CalendarPayment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarPayment.Sal_Mali = Nothing
        Me.CalendarPayment.ShowButton = True
        Me.CalendarPayment.Size = New System.Drawing.Size(110, 23)
        Me.CalendarPayment.TabIndex = 1
        Me.CalendarPayment.VisualStyle = False
        '
        'PanelCharge
        '
        Me.PanelCharge.Controls.Add(Me.UcCalcBalance)
        Me.PanelCharge.Controls.Add(Me.CalendarActivity)
        Me.PanelCharge.Controls.Add(Me.NumericEditBox1)
        Me.PanelCharge.Controls.Add(Me.UcCalcPastDue)
        Me.PanelCharge.Controls.Add(Me.CalendarPayment)
        Me.PanelCharge.Controls.Add(Me.ChkBalance)
        Me.PanelCharge.Controls.Add(Me.ChkPastAmount)
        Me.PanelCharge.Controls.Add(Me.ChkPastDays)
        Me.PanelCharge.Controls.Add(Me.ChkLastActivity)
        Me.PanelCharge.Controls.Add(Me.ChkLastpayment)
        Me.PanelCharge.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelCharge.ForeColor = System.Drawing.Color.Black
        Me.PanelCharge.Location = New System.Drawing.Point(0, 184)
        Me.PanelCharge.Name = "PanelCharge"
        Me.PanelCharge.Size = New System.Drawing.Size(502, 154)
        Me.PanelCharge.TabIndex = 2
        Me.PanelCharge.TabStop = False
        '
        'UcCalcBalance
        '
        Me.UcCalcBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.UcCalcBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.UcCalcBalance.DecimalDigits = 2
        Me.UcCalcBalance.DefaultSendValue = False
        Me.UcCalcBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.UcCalcBalance.Enabled = False
        Me.UcCalcBalance.FireTabAfterEnter = True
        Me.UcCalcBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcCalcBalance.ForeColor = System.Drawing.Color.Black
        Me.UcCalcBalance.Image = CType(resources.GetObject("UcCalcBalance.Image"), System.Drawing.Image)
        Me.UcCalcBalance.Location = New System.Drawing.Point(288, 112)
        Me.UcCalcBalance.Maxlength = 10
        Me.UcCalcBalance.MinusColor = System.Drawing.Color.Empty
        Me.UcCalcBalance.Name = "UcCalcBalance"
        Me.UcCalcBalance.Size = New System.Drawing.Size(110, 22)
        Me.UcCalcBalance.TabIndex = 9
        Me.UcCalcBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.UcCalcBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CalendarActivity
        '
        Me.CalendarActivity.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarActivity.BorderColor = System.Drawing.Color.Empty
        Me.CalendarActivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarActivity.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarActivity.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarActivity.EditableSal = True
        Me.CalendarActivity.Enabled = False
        Me.CalendarActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CalendarActivity.ForeColor = System.Drawing.Color.Black
        Me.CalendarActivity.Image = CType(resources.GetObject("CalendarActivity.Image"), System.Drawing.Image)
        Me.CalendarActivity.Location = New System.Drawing.Point(288, 40)
        Me.CalendarActivity.MaxValue = CType(2500, Short)
        Me.CalendarActivity.MinValue = CType(1800, Short)
        Me.CalendarActivity.Name = "CalendarActivity"
        Me.CalendarActivity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarActivity.Sal_Mali = Nothing
        Me.CalendarActivity.ShowButton = True
        Me.CalendarActivity.Size = New System.Drawing.Size(110, 23)
        Me.CalendarActivity.TabIndex = 3
        Me.CalendarActivity.VisualStyle = False
        '
        'ChkBalance
        '
        Me.ChkBalance.Location = New System.Drawing.Point(24, 112)
        Me.ChkBalance.Name = "ChkBalance"
        Me.ChkBalance.Size = New System.Drawing.Size(208, 24)
        Me.ChkBalance.TabIndex = 8
        Me.ChkBalance.Text = "Balance Over This Amount"
        '
        'ChkPastAmount
        '
        Me.ChkPastAmount.Location = New System.Drawing.Point(24, 88)
        Me.ChkPastAmount.Name = "ChkPastAmount"
        Me.ChkPastAmount.Size = New System.Drawing.Size(208, 24)
        Me.ChkPastAmount.TabIndex = 6
        Me.ChkPastAmount.Text = "Past Due Amount Over This Amount"
        '
        'ChkPastDays
        '
        Me.ChkPastDays.Location = New System.Drawing.Point(24, 64)
        Me.ChkPastDays.Name = "ChkPastDays"
        Me.ChkPastDays.Size = New System.Drawing.Size(210, 24)
        Me.ChkPastDays.TabIndex = 4
        Me.ChkPastDays.Text = "Past Due Days Over This Many Days"
        '
        'ChkLastActivity
        '
        Me.ChkLastActivity.Location = New System.Drawing.Point(24, 40)
        Me.ChkLastActivity.Name = "ChkLastActivity"
        Me.ChkLastActivity.Size = New System.Drawing.Size(208, 24)
        Me.ChkLastActivity.TabIndex = 2
        Me.ChkLastActivity.Text = "No Activity Since This Date"
        '
        'ChkLastpayment
        '
        Me.ChkLastpayment.Location = New System.Drawing.Point(24, 16)
        Me.ChkLastpayment.Name = "ChkLastpayment"
        Me.ChkLastpayment.Size = New System.Drawing.Size(208, 24)
        Me.ChkLastpayment.TabIndex = 0
        Me.ChkLastpayment.Text = "No Payment Since This Date"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_payment_deposit.id_service_center, MIN(DATEDIFF(d, GL_payment_AR.AR_due" & _
        "_date, GETDATE())) AS day, GL_payment_AR.AR_due_date FROM GL_payment_AR INNER JO" & _
        "IN GL_payment_deposit ON GL_payment_AR.ID_payment = GL_payment_deposit.ID_paymen" & _
        "t WHERE (GL_payment_deposit.refer_type = '1') AND (DATEDIFF(d, GL_payment_AR.AR_" & _
        "due_date, GETDATE()) > 0) GROUP BY GL_payment_deposit.id_service_center, GL_paym" & _
        "ent_AR.AR_due_date"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_AR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("day", "day"), New System.Data.Common.DataColumnMapping("AR_due_date", "AR_due_date")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_customer FROM cust_trtab_main WHERE (cod_customer NOT IN (SELECT servi" & _
        "ce_center_head.cod_customer FROM GL_payment_deposit INNER JOIN service_center_he" & _
        "ad ON GL_payment_deposit.id_service_center = service_center_head.id_service_cent" & _
        "er INNER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_" & _
        "payment.refrence_no WHERE (GL_payment_deposit.refer_type = 2) AND (Gl_receive_pa" & _
        "yment.date_receive_payment > @date))) AND (AR_charge = 1) AND (cod_customer NOT " & _
        "IN (SELECT cod_customer FROM service_center_head WHERE (date_refer > @date)))"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand4
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_customer, BalanceAmount FROM View_Customer_Balance"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO View_Customer_Balance(cod_customer, BalanceAmount) VALUES (@cod_custo" & _
        "mer, @BalanceAmount); SELECT cod_customer, BalanceAmount FROM View_Customer_Bala" & _
        "nce"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BalanceAmount", System.Data.SqlDbType.Float, 8, "BalanceAmount"))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_Customer_Balance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'CmdSPFindDueDate
        '
        Me.CmdSPFindDueDate.CommandText = "SELECT DueAllInvoice_1.id_service_center, DueAllInvoice_1.payment_amount, DueAllI" & _
        "nvoice_1.AR_due_date, DueAllInvoice_1.AR_terms, DueAllInvoice_1.cod_customer FRO" & _
        "M DueAllInvoice() DueAllInvoice_1 INNER JOIN GL_payment_AR ON DueAllInvoice_1.ID" & _
        "_payment = GL_payment_AR.ID_payment WHERE (DueAllInvoice_1.ID_payment IS NOT NUL" & _
        "L) AND (GL_payment_AR.Cancel_flag IS NULL OR GL_payment_AR.Cancel_flag = 0)"
        Me.CmdSPFindDueDate.Connection = Me.Cnn
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 329)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Please Wait"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'FrmARCusReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(502, 398)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PanelCharge)
        Me.Controls.Add(Me.PanelTypeCus)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmARCusReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelInnerDate.ResumeLayout(False)
        Me.PanelTypeCus.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelCus.ResumeLayout(False)
        CType(Me.DsFrmARCusReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCharge.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        CustomerARCharge = 1
        CustomerARPayment = 2
        CustomerARLedger = 3
        CustomerPastDue = 4
        CustomerAging = 5
    End Enum


    Public Property KindOfReport() As String
        Get
            Return MKindOfReport
        End Get
        Set(ByVal Value As String)
            MKindOfReport = Value
        End Set
    End Property
    Dim MKindOfReport As KindReport
    Dim StrCustomer As String
    Dim StrDate As String
    Dim StrChk1 As String
    Dim StrChk2 As String
    Dim StrChk3 As String
    Dim StrChk4 As String
    Dim StrChk5 As String
    Dim ComName As String = SystemInformation.ComputerName

    Private Sub FrmARCusReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali
        CalendarPayment.Text = Format(Now(), "MM/dd/yyyy")
        CalendarActivity.Text = Format(Now(), "MM/dd/yyyy")
        Call FillTextForm()
    End Sub

    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub
    Private Sub RdoAllCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllCus.CheckedChanged
        If RdoAllCus.Checked Then
            BtnCus.Enabled = False
        Else
            BtnCus.Enabled = True
        End If
    End Sub
    Private Sub BtnCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCus.Click
        BtnCus.Enabled = False
        Dim f As New FrmSelect
        If DsFrmARCusReport1.customer.Count = 0 Then
            DACustomer.Fill(DsFrmARCusReport1.customer)
        End If
        f.Text = "  Select Customer"
        f.TypeOfForm = FrmSelect.KindForm.customer
        f.DSMAIN = DsFrmARCusReport1
        f.ShowDialog()
        BtnCus.Enabled = True
    End Sub
    Private Function ControlSelect() As Boolean
        ControlSelect = True
        Dim i As Integer
        Dim flagControl As Boolean = False
        If RdoSelectedCus.Checked Then
            'For i = 0 To DsFrmARCusReport1.customer.Count - 1
            '    If DsFrmARCusReport1.customer(i).flag Then
            '        StrCustomer = StrCustomer & " cust_trtab_main.cod_customer = " & Qt(DsFrmARCusReport1.customer(i).cod) & " or "
            '    End If
            'Next
            'If StrCustomer.Trim.Length > 0 Then
            '    StrCustomer = Mid(StrCustomer, 1, StrCustomer.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select customer that you want")
            '    Exit Function
            'End If
            If DsFrmARCusReport1.customer.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select customer that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Cust_" & ComName & "(cod_customer char(10))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Cust_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmARCusReport1.customer.Count - 1
                    If DsFrmARCusReport1.customer(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO cust_" & ComName & " (cod_customer ) VALUES (" & Qt(DsFrmARCusReport1.customer(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrCustomer = " cust_trtab_main.cod_customer in (select cod_customer from cust_" & ComName & ") "
            End If
        End If

        StrDate = ""
        If MKindOfReport = KindReport.CustomerARLedger And RdoSummery.Checked Then
            ChkDate.Checked = True
        End If
        
        If Not (ChkDate.Checked) Then
            If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
                ControlSelect = False
                MsgBox("First Date Must Be Leaster Than Second Time")
                Exit Function
            Else
                StrDate = " dbo.ChangeDate(service_center_head.date_refer)  between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
            End If
        End If
        If MKindOfReport = KindReport.CustomerARPayment Then
            StrDate = ""
        End If
        If Not (FillDatasetOfCheckBox()) Then
            ControlSelect = False
        End If
    End Function

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If ControlSelect() Then
            Dim f As New FrmPrintARCus
            f.StrWhere = ""
            f.StrFilter = ""
            f.Date1 = ""
            f.Date2 = ""
            If Not (ChkDate.Checked) Then
                If MKindOfReport <> KindReport.CustomerAging And MKindOfReport <> KindReport.CustomerPastDue Then
                    If MKindOfReport <> KindReport.CustomerARPayment Then
                        f.StrFilter = f.StrFilter & "Date, "
                        f.StrWhere = f.StrWhere & " (" & StrDate & ") and "

                        f.Date1 = CalendarCombo1.Text
                        f.Date2 = CalendarCombo2.Text

                    Else
                        f.Date1 = CalendarCombo1.Text
                        f.Date2 = CalendarCombo2.Text
                    End If
                End If
            End If
            If RdoSelectedCus.Checked Then
                f.StrFilter = f.StrFilter & "Customer, "
                f.StrWhere = f.StrWhere & " (" & StrCustomer & ") and "
                'f.DSCus = DsFrmARCusReport1
            End If
            If ChkLastpayment.Checked Then
                f.StrFilter = f.StrFilter & "Customer, "
                f.StrWhere = f.StrWhere & " (" & StrChk1 & ") and "
            End If
            If ChkLastActivity.Checked Then
                f.StrFilter = f.StrFilter & "Customer, "
                f.StrWhere = f.StrWhere & " (" & StrChk2 & ") and "
            End If

            If ChkPastDays.Checked Then
                f.StrFilter = f.StrFilter & "Customer, "
                f.StrWhere = f.StrWhere & " (" & StrChk3 & ") and "
            End If
            If ChkPastAmount.Checked Then
                f.StrFilter = f.StrFilter & "Customer, "
                f.StrWhere = f.StrWhere & " (" & StrChk4 & ") and "
            End If


            If ChkBalance.Checked Then
                f.StrFilter = f.StrFilter & "Customer, "
                f.StrWhere = f.StrWhere & " (" & StrChk5 & ") and "
            End If


            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
            Select Case MKindOfReport
                Case KindReport.CustomerARCharge
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintARCus.KindReport.customerARChargeDetail
                    Else
                        f.KindOfReport = FrmPrintARCus.KindReport.customerARChargeSummery
                    End If

                Case KindReport.CustomerARPayment
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerARPaymentDetail
                    Else
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerARPaymentSummery
                    End If
                Case KindReport.CustomerARLedger

                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerARLedgerDetail
                        FillARLedgerDetail(f.StrWhere)
                        f.DSCus = DsFrmARCusReport1

                    Else
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerARLedgerSummery
                        ' FillARLedgerSummery(f.StrWhere)
                        'f.DSCus = DsFrmARCusReport1

                    End If
                Case KindReport.CustomerPastDue
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerDuePastDetail
                    Else
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerDuePastSummery
                    End If
                Case KindReport.CustomerAging

                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerAgingDetail
                    Else
                        f.KindOfReport = FrmPrintARCus.KindReport.CustomerAgingSummery
                    End If
            End Select
            If RdoDetail.Checked Then
                f.Text = Me.Text & " In Detail"
            Else
                f.Text = Me.Text & " In Summary"
            End If
            f.FilterLeft = IIf(ChkLastpayment.Checked, " No Payment Since " & CalendarPayment.Text & vbNewLine, "") & _
                IIf(ChkLastActivity.Checked, " No Activity Since This Date " & CalendarActivity.Text & vbNewLine, "") & _
                IIf(ChkPastDays.Checked, " Past Due Days Over " & NumericEditBox1.Text & " days" & vbNewLine, "") & _
                IIf(ChkPastAmount.Checked, " Past Due Amount Over " & UcCalcPastDue.Text & vbNewLine, "") & _
                IIf(ChkBalance.Checked, " Balance Over " & UcCalcBalance.Text, "")


            f.ShowDialog()
            If RdoSelectedCus.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Cust_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
        End If

    End Sub

    Private Sub FillTextForm()
        Select Case MKindOfReport
            Case KindReport.CustomerARCharge
                Me.Text = "   Customer AR Charge Report"
            Case KindReport.CustomerARPayment
                Me.Text = "   AR Customer Payment Report"
            Case KindReport.CustomerARLedger
                Me.Text = "  Customer AR Ledger Report"
                ChkDate.Checked = True
                ChkBalance.Checked = True
                RdoSummery.Checked = True
            Case KindReport.CustomerPastDue
                Me.Text = "    Past Due Customers Report"
            Case KindReport.CustomerAging
                PanelCharge.Visible = False
                ChkDate.Checked = True
                Me.Size = New System.Drawing.Size(512, 295)
                Me.Text = "    Customer Aging Report "
        End Select
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()

    End Sub

    Private Sub ChkLastpayment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLastpayment.CheckedChanged
        If ChkLastpayment.Checked Then
            CalendarPayment.Enabled = True
        Else
            CalendarPayment.Enabled = False
            CalendarPayment.Text = Format(Now(), "MM/dd/yyyy")
        End If

    End Sub

    Private Sub ChkLastActivity_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLastActivity.CheckedChanged
        If ChkLastActivity.Checked Then
            CalendarActivity.Enabled = True
        Else
            CalendarActivity.Enabled = False
            CalendarActivity.Text = Format(Now(), "MM/dd/yyyy")
        End If
    End Sub

    Private Sub ChkPastDays_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPastDays.CheckedChanged
        If ChkPastDays.Checked Then
            NumericEditBox1.Enabled = True
        Else
            NumericEditBox1.Enabled = False
            NumericEditBox1.Text = 0
        End If
    End Sub

    Private Sub ChkPastAmount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPastAmount.CheckedChanged
        If ChkPastAmount.Checked Then
            UcCalcPastDue.Enabled = True
        Else
            UcCalcPastDue.Enabled = False
            UcCalcPastDue.Text = 0

        End If
    End Sub

    Private Sub ChkBalance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBalance.CheckedChanged
        If ChkBalance.Checked Then
            UcCalcBalance.Enabled = True
        Else
            UcCalcBalance.Enabled = False
            UcCalcBalance.Text = 0

        End If
    End Sub
    Private Function FillDatasetOfCheckBox() As Boolean
        FillDatasetOfCheckBox = True
        StrChk1 = ""
        StrChk2 = ""
        StrChk3 = ""
        StrChk4 = ""
        StrChk5 = ""
        ''''''chk1

        If ChkLastpayment.Checked Then
            If CalendarPayment.Text = "" Then
                MsgBox(" Set Date First")
                FillDatasetOfCheckBox = False
                Exit Function
            Else

                StrChk1 = " cust_trtab_main.cod_customer NOT IN " & _
                                          " (SELECT     service_center_head.cod_customer " & _
                                          " FROM         GL_payment_deposit INNER JOIN " & _
                                          " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                                          " Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
                                          " WHERE     (GL_payment_deposit.refer_type = 2) AND (dbo.ChangeDate( Gl_receive_payment.date_receive_payment) > " & Qt(ChangeDateToYYYYMMDD(CalendarPayment.Text)) & "))"

            End If
        End If
        '''''''''chk2
        If ChkLastActivity.Checked Then
            If CalendarActivity.Text = "" Then
                MsgBox(" Set Date First")
                FillDatasetOfCheckBox = False
                Exit Function
            Else

                StrChk2 = " cust_trtab_main.cod_customer NOT IN " & _
                                     " (SELECT     service_center_head.cod_customer " & _
                                     " FROM         GL_payment_deposit INNER JOIN " & _
                                     " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                                     " Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
                                     " WHERE     (GL_payment_deposit.refer_type = 2) AND ( dbo.ChangeDate(Gl_receive_payment.date_receive_payment) > " & Qt(ChangeDateToYYYYMMDD(CalendarActivity.Text)) & "))) AND (AR_charge = 1)AND  " & _
                                     " (cust_trtab_main.cod_customer NOT IN " & _
                                     " (SELECT     cod_customer " & _
                                     " FROM service_center_head " & _
                                     " WHERE     ( dbo.ChangeDate( date_refer) > " & Qt(ChangeDateToYYYYMMDD(CalendarActivity.Text)) & "))"


            End If
        End If


        If ChkPastDays.Checked Then

            If NumericEditBox1.Text = "" Then
                MsgBox(" Set Number Of Day First")
                FillDatasetOfCheckBox = False
                Exit Function
            Else

                StrChk3 = " cust_trtab_main.cod_customer IN (SELECT     cod_customer " & _
                    " FROM dbo.View_Total_Balance_ForEach_ARDue " & _
                    " WHERE   (TotalArBalanceAmount > 0) and  (DATEDIFF(day, AR_due_date, getdate() ) > " & NumericEditBox1.Text & ")  " & _
                    " union SELECT     cod_customer " & _
                    " FROM    dbo.View_Adjustment_Balance " & _
                    " WHERE   ( BalanceAmount > 0) and (DATEDIFF(day, AR_due_date, getdate() ) > " & NumericEditBox1.Text & "))"

            End If
        End If
        ''''chk4
        If ChkPastAmount.Checked Then

            If UcCalcPastDue.Text = "" Then
                MsgBox(" Set Amount First")
                FillDatasetOfCheckBox = False
                Exit Function
            Else

                StrChk4 = " cust_trtab_main.cod_customer IN (SELECT     cod_customer " & _
                       "  FROM         cust_trtab_main A " & _
                       " WHERE     (SELECT     isnull(SUM(round(dbo.GL_payment_deposit.payment_amount, 2) - round(dbo.GL_payment_deposit.paid_amount, 2)), 0) " & _
                       " AS Customer_AR_Bedehy1 " & _
                       "   FROM         dbo.service_center_head INNER JOIN " & _
                       " dbo.GL_payment_deposit ON  dbo.service_center_head.id_service_center = dbo.GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
                       " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                       " WHERE       (DATEDIFF(day, dbo.GL_payment_AR.AR_due_date, getdate()) > 0) AND (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND " & _
                       "  (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND  " & _
                       "  A.cod_customer = dbo.service_center_head.cod_customer) + " & _
                       "  (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2 " & _
                       " FROM         dbo.GL_account_adjustment_head " & _
                       " WHERE       (DATEDIFF(day, dbo.GL_account_adjustment_head.date_adjustment, getdate()) > 0) AND  A.cod_customer = GL_account_adjustment_head.cod_customer AND amount_adjustment > 0) +  " & _
                       " (SELECT     isnull(SUM(round(isnull(GL_account_adjustment_dtl.amount_adjustment, 0), 2)), 0) AS Customer_AR_Pardakht1 " & _
                       "   FROM         GL_account_adjustment_dtl INNER JOIN " & _
                      " service_center_head ON GL_account_adjustment_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      "   GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_head.refrence_no LEFT OUTER JOIN " & _
                       " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
                       "  GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                       "  WHERE     (DATEDIFF(day, dbo.GL_payment_AR.AR_due_date, getdate()) > 0) AND  " & _
                       "  A.cod_customer = GL_account_adjustment_head.cod_customer AND GL_account_adjustment_dtl.amount_adjustment < 0) > " & UcCalcPastDue.Text & ") "

            End If
        End If



        ''''''''''''''chk5
        If ChkBalance.Checked Then
            If UcCalcBalance.Text = "" Then
                MsgBox(" Set Amount First")
                FillDatasetOfCheckBox = False
                Exit Function
            Else
                'CmdGeneral.CommandText = " SELECT     cod_customer " & _
                '        " FROM         View_Customer_Balance " & _
                '     " WHERE     BalanceAmount <= " & Qt(UcCalcBalance.Text)

                'If CmdGeneral.Connection.State = ConnectionState.Closed Then
                '    CmdGeneral.Connection.Open()
                'End If
                'Dim SQLReader As System.Data.SqlClient.SqlDataReader
                'SQLReader = CmdGeneral.ExecuteReader
                'If SQLReader.HasRows Then
                '    Do While SQLReader.Read()
                '        StrChk5 = StrChk5 & " cust_trtab_main.cod_customer = " & Qt(SQLReader("cod_customer")) & " or "
                '    Loop
                '    StrChk5 = Mid(StrChk5, 1, StrChk5.Length - 3)
                '    CmdGeneral.Connection.Close()
                'Else
                '    CmdGeneral.Connection.Close()
                '    FillDatasetOfCheckBox = False
                '    MsgBox(" No AR Customer With More Than This Balance ")
                '    Exit Function
                'End If

                ' StrChk5 = " cust_trtab_main.cod_customer  IN  (SELECT     cod_customer " & _
                '     " FROM         View_Customer_Balance " & _
                '    " WHERE     BalanceAmount > cast(" & Qt(UcCalcBalance.Text) & " as money) ) "

                StrChk5 = " cust_trtab_main.cod_customer  IN  (SELECT     cod_customer " & _
                    " FROM        dbo.View_Total_Balance_ForEach_ARDue " & _
                    " WHERE      (ISNULL(AR_Amount, 0) - (ISNULL(AR_Amount, 0) - ISNULL(BalanceAmount, 0)) + ISNULL(AR_Adj_Amount, 0) ) > cast(" & Qt(UcCalcBalance.Text) & " as money) ) "


            End If
        End If

    End Function

    'Private Sub pp() Handles f.ProcessForm
    '    f.
    'End Sub


    'Private Sub RdoSummery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoSummery.CheckedChanged
    '    If RdoSummery.Checked Then
    '        ChkDate.Checked = True
    '    Else
    '        ChkDate.Checked = False
    '    End If

    'End Sub

    Private Function FillARLedgerDetail(ByVal StrWhere As String)
        Label1.Visible = True
        Dim DS As New DataSet
        Dim DT As New DataTable
        DS.Tables.Add(DT)

        DsFrmARCusReport1.CusARLedgerDetail.Clear()

        Try
            'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
            '"   cust_company.complete_name + '' AS complete_name, GL_account_adjustment_head.date_adjustment AS date,  " & _
            '" GL_account_adjustment_head.refrence_no AS id, 0 AS charge, 0 AS credit, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)  " & _
            '"  AS adj, '' AS due, 1 AS flag, dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
            '"  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
            '"  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
            '"  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2) as Balance " & _
            '"  FROM         cust_trtab_main INNER JOIN " & _
            '"  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
            '"  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
            '"  where  cust_trtab_main.AR_charge = '1'" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")
            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name ,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                       "   cust_company.complete_name + '' AS complete_name, GL_account_adjustment_head.date_adjustment AS date,  " & _
                       " GL_account_adjustment_head.refrence_no AS id, 0 AS charge, 0 AS credit, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)  " & _
                       "  AS adj,  1 AS flag, dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
                       "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                       "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                       "  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2) as Balance " & _
                       "  FROM         cust_trtab_main INNER JOIN " & _
                       "  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
                       "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                       "  where  cust_trtab_main.AR_charge = '1'" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)

            'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
            '" cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id,  " & _
            '"  0 AS charge, 0 AS credit, 0 AS adj, '' AS due,  1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  CASE WHEN cust_company.complete_name IS NULL  " & _
            '"  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
            '"  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
            '"  ,  0 AS Paid_amount,  0 AS Down, ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2) AS OVERPAID, 0 AS Other,0 as Balance " & _
            '" FROM         cust_trtab_main INNER JOIN " & _
            '" Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
            '" cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
            '" WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")
            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                       " cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id,  " & _
                       "  0 AS charge, 0 AS credit, 0 AS adj,   1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  CASE WHEN cust_company.complete_name IS NULL  " & _
                       "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                       "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                       "  ,  0 AS Paid_amount,  0 AS Down, ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2) AS OVERPAID, 0 AS Other,0 as Balance " & _
                       " FROM         cust_trtab_main INNER JOIN " & _
                       " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
                       " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                       " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

            ' DAGeneral.Fill(DS.Tables(0))
            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)
        Catch ex As Exception

            'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
            '            "   cust_company.complete_name + '' AS complete_name, GL_account_adjustment_head.date_adjustment AS date,  " & _
            '            " GL_account_adjustment_head.refrence_no AS id, 0 AS charge, 0 AS credit, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)  " & _
            '            "  AS adj, '' AS due, 1 AS flag, dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
            '            "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
            '            "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
            '            "  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2) as Balance " & _
            '            "  FROM         cust_trtab_main INNER JOIN " & _
            '            "  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
            '            "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
            '            " where  cust_trtab_main.AR_charge = '1' and ( dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) " & Mid(StrWhere, 50, StrWhere.Length - 45)
            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                       "   cust_company.complete_name + '' AS complete_name, GL_account_adjustment_head.date_adjustment AS date,  " & _
                       " GL_account_adjustment_head.refrence_no AS id, 0 AS charge, 0 AS credit, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)  " & _
                       "  AS adj,  1 AS flag, dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
                       "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                       "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                       "  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2) as Balance " & _
                       "  FROM         cust_trtab_main INNER JOIN " & _
                       "  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
                       "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                       " where  cust_trtab_main.AR_charge = '1' and ( dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) " & Mid(StrWhere, 50, StrWhere.Length - 45)

           
            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)

            'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
            '            " cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id,  " & _
            '            "  0 AS charge, 0 AS credit, 0 AS adj, '' AS due,  1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  CASE WHEN cust_company.complete_name IS NULL  " & _
            '            "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
            '            "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
            '            "  ,  0 AS Paid_amount,  0 AS Down, ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2) AS OVERPAID, 0 AS Other,0 as Balance " & _
            '            " FROM         cust_trtab_main INNER JOIN " & _
            '            " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
            '            " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
            '            " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1')  and ( dbo.ChangeDate(Gl_receive_payment.date_receive_payment) " & Mid(StrWhere, 50, StrWhere.Length - 45)
            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                        " cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id,  " & _
                        "  0 AS charge, 0 AS credit, 0 AS adj,   1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  CASE WHEN cust_company.complete_name IS NULL  " & _
                        "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                        "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                        "  ,  0 AS Paid_amount,  0 AS Down, ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2) AS OVERPAID, 0 AS Other,0 as Balance " & _
                        " FROM         cust_trtab_main INNER JOIN " & _
                        " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
                        " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                        " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1')  and ( dbo.ChangeDate(Gl_receive_payment.date_receive_payment) " & Mid(StrWhere, 50, StrWhere.Length - 45)



            'DAGeneral.Fill(DS.Tables(0))
            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)
        End Try


        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        "   cust_company.complete_name + '' AS complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,  " & _
        "   ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS charge, 0 AS credit, 0 AS adj, GL_payment_AR.AR_due_date AS due, 1 AS flag,  " & _
        "  dbo.ChangeDate(service_center_head.date_refer) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, ROUND(ISNULL(GL_payment_deposit.Paid_amount,  " & _
        "  0), 2) AS Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other ,ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) as Balance" & _
        "  FROM         cust_trtab_main INNER JOIN " & _
        "  service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        "  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        "  GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
         " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)

        'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        ' "  cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, GL_payment_deposit.refrence_no AS id,  " & _
        ' "  0 AS charge, ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS credit, 0 AS adj, '' AS due, 1 AS flag,  " & _
        ' "  dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        ' "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ' "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, 0 AS Paid_amount, 0 AS Down, 0 AS OVERPAID,  " & _
        ' "  0 AS Other ,ROUND(ISNULL(-GL_payment_deposit.payment_amount, 0), 2) AS Balance" & _
        ' " FROM         cust_trtab_main INNER JOIN " & _
        ' " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        ' " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        ' " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
        ' "  GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
        ' "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ' " WHERE     (GL_payment_deposit.refer_type = '2')  and cust_trtab_main.AR_charge = '1' " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")
        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name ,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        "  cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, GL_payment_deposit.refrence_no AS id,  " & _
        "  0 AS charge, ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS credit, 0 AS adj, 1 AS flag,  " & _
        "  dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, 0 AS Paid_amount, 0 AS Down, 0 AS OVERPAID,  " & _
        "  0 AS Other ,ROUND(ISNULL(-GL_payment_deposit.payment_amount, 0), 2) AS Balance" & _
        " FROM         cust_trtab_main INNER JOIN " & _
        " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
        "  GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
        "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        " WHERE     (GL_payment_deposit.refer_type = '2')  and cust_trtab_main.AR_charge = '1' " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")


        'DAGeneral.Fill(DS.Tables(0))
        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)




        DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name ,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
                      " cust_company.complete_name + '' AS complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,  " & _
                      " 0 AS charge, 0 AS credit,0 as adj, 1 AS flag, dbo.ChangeDate(service_center_head.date_refer) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
                      "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                      "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName,   " & _
                      " 0 AS Paid_amount, ROUND(ISNULL(GL_Paid_received.amount,0),2) AS down, 0 AS OVERPAID, 0 AS Other ,0 as Balance" & _
                      " FROM         cust_trtab_main INNER JOIN" & _
                      " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
                      " GL_Paid_received ON cust_trtab_main.cod_customer = GL_Paid_received.customer_code AND  " & _
                      " service_center_head.id_service_center = GL_Paid_received.id_service_center LEFT OUTER JOIN " & _
                      " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                      " WHERE     (GL_Paid_received.tran_type = '4')  and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        'DAGeneral.Fill(DS.Tables(0))
        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)


        DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
                    " cust_company.complete_name+'' as complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,0  as charge, 0 AS credit,0 as adj,  1 AS flag, dbo.changedate(service_center_head.date_refer) AS OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2) as Paid_amount,ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) as other ,0 as Balance" & _
                 " FROM         cust_trtab_main INNER JOIN " & _
                    " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
                    " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
                    " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                    " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
                    " (GL_payment_deposit.refer_type = '3') and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        'DAGeneral.Fill(DS.Tables(0))

        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerDetail)

        Label1.Visible = False

        'FillARLedgerDetail = DS


    End Function

    Private Function FillARLedgerSummery(ByVal StrWhere As String)
        Label1.Visible = True
        Dim DS As New DataSet
        Dim DT As New DataTable
        DS.Tables.Add(DT)

        DsFrmARCusReport1.CusARLedgerSummery.Clear()

        Try
            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
            "   cust_company.complete_name + '' AS complete_name,    0 AS charge, 0 AS credit,SUM( ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2))   AS adj, 1 AS flag, CASE WHEN cust_company.complete_name IS NULL  " & _
            "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
            "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
            "  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other, SUM(ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)) as Balance ,0 as FCalc,0 as FlagShow" & _
            "  FROM         cust_trtab_main INNER JOIN " & _
            "  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
            "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
            "  where  cust_trtab_main.AR_charge = '1'" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"

            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)

            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name ,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
            " cust_company.complete_name + '' AS complete_name,    0 AS charge, 0 AS credit, 0 AS adj,  1 AS flag,  CASE WHEN cust_company.complete_name IS NULL  " & _
            "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
            "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
            "  ,  0 AS Paid_amount,  0 AS Down, SUM(ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2)) AS OVERPAID, 0 AS Other,0 as Balance,0 as FCalc,0 as FlagShow " & _
            " FROM         cust_trtab_main INNER JOIN " & _
            " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
            " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
            " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"

            ' DAGeneral.Fill(DHS.Tables(0))
            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)
        Catch ex As Exception

            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name ,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                        "   cust_company.complete_name + '' AS complete_name,   0 AS charge, 0 AS credit, SUM(ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2))  " & _
                        "  AS adj, 1 AS flag,CASE WHEN cust_company.complete_name IS NULL  " & _
                        "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                        "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                        "  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other, SUM(ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)) as Balance,0 as FCalc,0 as FlagShow " & _
                        "  FROM         cust_trtab_main INNER JOIN " & _
                        "  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
                        "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                        " where  cust_trtab_main.AR_charge = '1' and ( dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) " & Mid(StrWhere, 50, StrWhere.Length - 45) & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"

            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)

            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                        " cust_company.complete_name + '' AS complete_name, 0 AS charge, 0 AS credit, 0 AS adj,  1 AS flag,  CASE WHEN cust_company.complete_name IS NULL  " & _
                        "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                        "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                        "  ,  0 AS Paid_amount,  0 AS Down, SUM(ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2)) AS OVERPAID, 0 AS Other,0 as Balance,0 as FCalc,0 as FlagShow " & _
                        " FROM         cust_trtab_main INNER JOIN " & _
                        " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
                        " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                        " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1')  and ( dbo.ChangeDate(Gl_receive_payment.date_receive_payment) " & Mid(StrWhere, 50, StrWhere.Length - 45) & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"


            'DAGeneral.Fill(DS.Tables(0))
            DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)
        End Try


        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        "   cust_company.complete_name + '' AS complete_name, SUM( ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2)) AS charge, 0 AS credit, 0 AS adj, 1 AS flag, CASE WHEN cust_company.complete_name IS NULL  " & _
        "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, 0 AS Down, 0 AS OVERPAID, 0 AS Other ,SUM(ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2)) as Balance,0 as FCalc,0 as FlagShow" & _
        "  FROM         cust_trtab_main INNER JOIN " & _
        "  service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        "  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        "  GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
         " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"

        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)


        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
         "  cust_company.complete_name + '' AS complete_name,   0 AS charge, SUM(ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2)) AS credit, 0 AS adj,  1 AS flag,   CASE WHEN cust_company.complete_name IS NULL  " & _
         "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
         "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, 0 AS Paid_amount, 0 AS Down, 0 AS OVERPAID,  " & _
         "  0 AS Other ,SUM(ROUND(ISNULL(-GL_payment_deposit.payment_amount, 0), 2)) AS Balance,0 as FCalc,0 as FlagShow" & _
         " FROM         cust_trtab_main INNER JOIN " & _
         " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
         " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
         " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
         "  GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
         "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
         " WHERE     (GL_payment_deposit.refer_type = '2')  and cust_trtab_main.AR_charge = '1' " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"

        'DAGeneral.Fill(DS.Tables(0))
        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)




        DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
                      " cust_company.complete_name + '' AS complete_name,   0 AS charge, 0 AS credit,0 as adj, 1 AS flag,  CASE WHEN cust_company.complete_name IS NULL  " & _
                      "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                      "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName,   " & _
                      " 0 AS Paid_amount, SUM(ROUND(ISNULL(GL_Paid_received.amount,0),2)) AS down, 0 AS OVERPAID, 0 AS Other ,0 as Balance,0 as FCalc,0 as FlagShow" & _
                      " FROM         cust_trtab_main INNER JOIN" & _
                      " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
                      " GL_Paid_received ON cust_trtab_main.cod_customer = GL_Paid_received.customer_code AND  " & _
                      " service_center_head.id_service_center = GL_Paid_received.id_service_center LEFT OUTER JOIN " & _
                      " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                      " WHERE     (GL_Paid_received.tran_type = '4')  and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"

        'DAGeneral.Fill(DS.Tables(0))
        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)


        DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
                    " cust_company.complete_name+'' as complete_name, 0  as charge, 0 AS credit,0 as adj,  1 AS flag, ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName, SUM(ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2)) as Paid_amount,SUM(ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2)) as other ,0 as Balance,0 as FCalc,0 as FlagShow" & _
                    " FROM         cust_trtab_main INNER JOIN " & _
                    " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
                    " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
                    " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                    " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
                    " (GL_payment_deposit.refer_type = '3') and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name"

        'DAGeneral.Fill(DS.Tables(0))

        DAGeneral.Fill(DsFrmARCusReport1.CusARLedgerSummery)
        Dim R As Integer

        For i As Integer = 0 To DsFrmARCusReport1.CusARLedgerSummery.Count - 1
            DsFrmARCusReport1.CusARLedgerSummery.DefaultView.RowFilter = " cod_customer = '" & DsFrmARCusReport1.CusARLedgerSummery(i).cod_customer & "'"
            R = DsFrmARCusReport1.CusARLedgerSummery.DefaultView.Count
            If R > 0 And DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("FCalc") = False Then
                DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("FCalc") = True
                DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("FlagShow") = True

                If R > 1 Then
                    For j As Integer = 1 To R - 1
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("charge") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("charge") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("charge")
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("credit") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("credit") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("credit")
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("adj") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("adj") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("adj")
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Balance") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Balance") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("Balance")
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("OVERPAID") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("OVERPAID") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("OVERPAID")
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Down") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Down") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("Down")
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Other") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Other") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("Other")
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("FCalc") = True
                        DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("FlagShow") = False

                        ' DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Paid_amount") = DsFrmARCusReport1.CusARLedgerSummery.DefaultView(0).Item("Paid_amount") + DsFrmARCusReport1.CusARLedgerSummery.DefaultView(j).Item("Paid_amount")

                    Next
                End If
            End If



        Next

        Label1.Visible = False

        'FillARLedgerDetail = DS


    End Function

    Private Sub PanelCharge_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelCharge.Enter

    End Sub
End Class
