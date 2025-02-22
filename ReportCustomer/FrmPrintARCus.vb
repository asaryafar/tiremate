Imports CommonClass
Imports Janus.Windows.GridEX

Public Class FrmPrintARCus
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents DsFrmPrintARCus1 As ReportCustomer.DSFrmPrintARCus
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACusChargeDetail As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACusChargeSummery As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdCusChargeSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdCusChargeDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GrdCusPaymentDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdCusPaymentSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdcusLedgerDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents DsFrmARCusReport1 As ReportCustomer.DSFrmARCusReport
    Friend WithEvents GrdPastDueDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdPastDueSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAViewCusBalense As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdSPFindDueDate As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdAging As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAForCommand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdAging As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdC1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdC2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdC3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdC4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdC5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdcusLedgerSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents RdoPortrait As System.Windows.Forms.RadioButton
    Friend WithEvents RdoLandScape As System.Windows.Forms.RadioButton
    Friend WithEvents PanelPrint As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrintARCus))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout5 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout6 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout7 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout8 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout9 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DACusChargeDetail = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PanelPrint = New System.Windows.Forms.Panel
        Me.RdoLandScape = New System.Windows.Forms.RadioButton
        Me.RdoPortrait = New System.Windows.Forms.RadioButton
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
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.GrdCusChargeDetail = New Janus.Windows.GridEX.GridEX
        Me.DACusChargeSummery = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GrdCusChargeSummery = New Janus.Windows.GridEX.GridEX
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GrdCusPaymentDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPrintARCus1 = New ReportCustomer.DSFrmPrintARCus
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.GrdCusPaymentSummery = New Janus.Windows.GridEX.GridEX
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.GrdcusLedgerDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmARCusReport1 = New ReportCustomer.DSFrmARCusReport
        Me.GrdPastDueDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdPastDueSummery = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAViewCusBalense = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdSPFindDueDate = New System.Data.SqlClient.SqlCommand
        Me.CmdAging = New System.Data.SqlClient.SqlCommand
        Me.DAForCommand = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.GrdAging = New Janus.Windows.GridEX.GridEX
        Me.CmdC1 = New System.Data.SqlClient.SqlCommand
        Me.CmdC2 = New System.Data.SqlClient.SqlCommand
        Me.CmdC3 = New System.Data.SqlClient.SqlCommand
        Me.CmdC4 = New System.Data.SqlClient.SqlCommand
        Me.CmdC5 = New System.Data.SqlClient.SqlCommand
        Me.GrdcusLedgerSummery = New Janus.Windows.GridEX.GridEX
        Me.Panel4.SuspendLayout()
        Me.PanelPrint.SuspendLayout()
        CType(Me.GrdCusChargeDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCusChargeSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCusPaymentDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPrintARCus1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCusPaymentSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdcusLedgerDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmARCusReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPastDueDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPastDueSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdAging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdcusLedgerSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_02"
        '
        'DACusChargeDetail
        '
        Me.DACusChargeDetail.SelectCommand = Me.SqlSelectCommand1
        Me.DACusChargeDetail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("complete_name", "complete_name"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("name", "name"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("payment2", "payment2"), New System.Data.Common.DataColumnMapping("adjustment", "adjustment"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("days_past", "days_past"), New System.Data.Common.DataColumnMapping("ar_term", "ar_term"), New System.Data.Common.DataColumnMapping("payment_amount1", "payment_amount1"), New System.Data.Common.DataColumnMapping("flag", "flag"), New System.Data.Common.DataColumnMapping("FlagShow", "FlagShow"), New System.Data.Common.DataColumnMapping("OrderName", "OrderName")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.cod_customer, cust_company.complete_name, service_center_h" & _
        "ead.date_refer, service_center_head.id_service_center, ROUND(ISNULL(service_cent" & _
        "er_head.Total, 0), 2) AS Total, ISNULL(cust_trtab_main.f_name, '') AS f_name, IS" & _
        "NULL(cust_trtab_main.m_name, '') + ' ' + ISNULL(cust_trtab_main.l_name, '') AS n" & _
        "ame, View_Total_Balance_ForEach_ARDue.TotalArBalanceAmount AS payment_amount, 0 " & _
        "AS payment2, 0 AS adjustment, View_Total_Balance_ForEach_ARDue.AR_due_date AS du" & _
        "e_date, DATEDIFF(day, View_Total_Balance_ForEach_ARDue.AR_due_date, GETDATE()) A" & _
        "S days_past, GL_payment_AR.AR_terms AS ar_term, 0 AS payment_amount, 1 AS flag, " & _
        "1 AS FlagShow, CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE " & _
        "cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LT" & _
        "RIM(RTRIM(cust_trtab_main.m_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) " & _
        "+ cust_trtab_main.cod_customer AS OrderName FROM service_center_head INNER JOIN " & _
        "cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_custom" & _
        "er INNER JOIN View_Total_Balance_ForEach_ARDue ON service_center_head.id_service" & _
        "_center = View_Total_Balance_ForEach_ARDue.id_service_center INNER JOIN GL_payme" & _
        "nt_AR ON View_Total_Balance_ForEach_ARDue.ID_payment = GL_payment_AR.ID_payment " & _
        "LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_c" & _
        "ompany WHERE (cust_trtab_main.AR_charge = 1) AND (service_center_head.type_of_fo" & _
        "rm = 'IN')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
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
        Me.Panel4.Controls.Add(Me.PanelPrint)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(648, 64)
        Me.Panel4.TabIndex = 6
        '
        'PanelPrint
        '
        Me.PanelPrint.Controls.Add(Me.RdoLandScape)
        Me.PanelPrint.Controls.Add(Me.RdoPortrait)
        Me.PanelPrint.Location = New System.Drawing.Point(512, 2)
        Me.PanelPrint.Name = "PanelPrint"
        Me.PanelPrint.Size = New System.Drawing.Size(76, 57)
        Me.PanelPrint.TabIndex = 194
        Me.PanelPrint.Visible = False
        '
        'RdoLandScape
        '
        Me.RdoLandScape.Location = New System.Drawing.Point(1, 30)
        Me.RdoLandScape.Name = "RdoLandScape"
        Me.RdoLandScape.Size = New System.Drawing.Size(79, 24)
        Me.RdoLandScape.TabIndex = 1
        Me.RdoLandScape.Text = "LandScape"
        '
        'RdoPortrait
        '
        Me.RdoPortrait.Checked = True
        Me.RdoPortrait.Location = New System.Drawing.Point(1, 7)
        Me.RdoPortrait.Name = "RdoPortrait"
        Me.RdoPortrait.Size = New System.Drawing.Size(79, 24)
        Me.RdoPortrait.TabIndex = 0
        Me.RdoPortrait.TabStop = True
        Me.RdoPortrait.Text = "Portrait"
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(260, 5)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 193
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(518, 5)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(510, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(251, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Deselect All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(260, 5)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 183
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(466, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(414, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(361, 39)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(304, 39)
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
        Me.BtnEmail.Location = New System.Drawing.Point(468, 5)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(416, 5)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(363, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(312, 5)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the Customer That you want to print"
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
        'CmdGeneral
        '
        Me.CmdGeneral.CommandText = "SELECT DATEDIFF(d, GL_payment_AR.AR_due_date, GETDATE()) AS day, GL_payment_AR.AR" & _
        "_due_date, GL_payment_AR.AR_terms, GL_payment_deposit.id_service_center, GL_paym" & _
        "ent_deposit.payment_amount FROM GL_payment_AR LEFT OUTER JOIN GL_payment_deposit" & _
        " ON GL_payment_AR.ID_payment = GL_payment_deposit.ID_payment WHERE (GL_payment_d" & _
        "eposit.refer_type = '1') AND (DATEDIFF(d, GETDATE(), GL_payment_AR.AR_due_date) " & _
        "< 0) ORDER BY GL_payment_deposit.id_service_center, DATEDIFF(d, GETDATE(), GL_pa" & _
        "yment_AR.AR_due_date) DESC"
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'GrdCusChargeDetail
        '
        Me.GrdCusChargeDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>20</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>76</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition></Column2><Column3 ID=""name""><Caption>Last Name</Caption><DataMember>name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>name</Key><Position>3</Position></Column3><Column4 ID=""complete_name""><Capti" & _
        "on>Company</Caption><DataMember>complete_name</DataMember><EditType>NoEdit</Edit" & _
        "Type><FilterEditType>TextBox</FilterEditType><Key>complete_name</Key><Position>4" & _
        "</Position></Column4><Column5 ID=""date_refer""><Caption>Date</Caption><DataMember" & _
        ">date_refer</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><FormatString>MM/dd/yyyy</FormatString><Key>date_refer</Key><Position" & _
        ">5</Position><Width>66</Width></Column5><Column6 ID=""id_service_center""><Caption" & _
        ">Ref No.</Caption><DataMember>id_service_center</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>id_service_center</Key><Posi" & _
        "tion>6</Position><Width>78</Width></Column6><Column7 ID=""Total""><AggregateFuncti" & _
        "on>Sum</AggregateFunction><Caption>Orig. Amount</Caption><DataMember>Total</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Forma" & _
        "tString>c2</FormatString><Key>Total</Key><Position>7</Position><TextAlignment>Fa" & _
        "r</TextAlignment><TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=" & _
        """payment_amount""><AggregateFunction>Sum</AggregateFunction><Caption>Amount Due</" & _
        "Caption><DataMember>payment_amount</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>payment_am" & _
        "ount</Key><Position>8</Position><TextAlignment>Far</TextAlignment><TotalFormatSt" & _
        "ring>c2</TotalFormatString></Column8><Column9 ID=""Due_Date""><Caption>Due Date</C" & _
        "aption><DataMember>Due_Date</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>Due_Date<" & _
        "/Key><Position>9</Position><Width>82</Width></Column9><Column10 ID=""days_past""><" & _
        "Caption>days past Due</Caption><DataMember>days_past</DataMember><EditType>NoEdi" & _
        "t</EditType><FilterEditType>TextBox</FilterEditType><Key>days_past</Key><Positio" & _
        "n>10</Position><Width>93</Width></Column10><Column11 ID=""ar_term""><Caption>AR Te" & _
        "rm</Caption><DataMember>ar_term</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>TextBox</FilterEditType><Key>ar_term</Key><Position>11</Position><Width>8" & _
        "9</Width></Column11><Column12 ID=""FlagShow""><Caption>FlagShow</Caption><ColumnTy" & _
        "pe>CheckBox</ColumnType><DataMember>FlagShow</DataMember><EditType>CheckBox</Edi" & _
        "tType><Key>FlagShow</Key><Position>12</Position><Visible>False</Visible></Column" & _
        "12><Column13 ID=""OrderName""><Caption>OrderName</Caption><DataMember>OrderName</D" & _
        "ataMember><Key>OrderName</Key><Position>13</Position><Visible>False</Visible></C" & _
        "olumn13></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group0 ID=""" & _
        "Group0""><ColIndex>1</ColIndex></Group0></Groups><FilterCondition><ColumnIndex>12" & _
        "</ColumnIndex><Value1>True</Value1></FilterCondition></RootTable></GridEXLayoutD" & _
        "ata>"
        Me.GrdCusChargeDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdCusChargeDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCusChargeDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCusChargeDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCusChargeDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCusChargeDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdCusChargeDetail.Name = "GrdCusChargeDetail"
        Me.GrdCusChargeDetail.Size = New System.Drawing.Size(650, 312)
        Me.GrdCusChargeDetail.TabIndex = 7
        Me.GrdCusChargeDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DACusChargeSummery
        '
        Me.DACusChargeSummery.SelectCommand = Me.SqlSelectCommand2
        Me.DACusChargeSummery.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("complete_name", "complete_name"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_na" & _
        "me + ' ' + cust_trtab_main.l_name AS name, cust_company.complete_name + '' AS co" & _
        "mplete_name, COUNT(service_center_head.id_service_center) AS NoInvoice, SUM(ROUN" & _
        "D(ISNULL(service_center_head.Total, 0), 2)) AS total, SUM(ROUND(ISNULL(View_Tota" & _
        "l_Balance_ForEach_ARDue.TotalArBalanceAmount, 0), 2)) AS payment4, 0 AS payment2" & _
        ", 0 AS adjustment, 0 AS payment_amount, 1 AS flag FROM cust_trtab_main INNER JOI" & _
        "N service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_" & _
        "customer INNER JOIN View_Total_Balance_ForEach_ARDue ON service_center_head.id_s" & _
        "ervice_center = View_Total_Balance_ForEach_ARDue.id_service_center LEFT OUTER JO" & _
        "IN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHERE " & _
        "(cust_trtab_main.AR_charge = 1) AND (service_center_head.type_of_form = 'IN') GR" & _
        "OUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_n" & _
        "ame, cust_trtab_main.l_name, cust_company.complete_name, View_Total_Balance_ForE" & _
        "ach_ARDue.TotalArBalanceAmount"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'GrdCusChargeSummery
        '
        Me.GrdCusChargeSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>26</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position></Column1><Column2 ID=""f_name""><Caption>First Na" & _
        "me</Caption><DataMember>f_name</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Position></Column2><" & _
        "Column3 ID=""name""><Caption>Last Name</Caption><DataMember>name</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name</Key><Po" & _
        "sition>3</Position><Width>106</Width></Column3><Column4 ID=""complete_name""><Capt" & _
        "ion>Company</Caption><DataMember>complete_name</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>complete_name</Key><Position>" & _
        "4</Position><Width>133</Width></Column4><Column5 ID=""total""><AggregateFunction>S" & _
        "um</AggregateFunction><Caption>Orig. Amount</Caption><DataMember>total</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStr" & _
        "ing>c2</FormatString><Key>total</Key><Position>5</Position><TextAlignment>Far</T" & _
        "extAlignment><Width>88</Width><TotalFormatString>c2</TotalFormatString></Column5" & _
        "><Column6 ID=""payment_amount""><AggregateFunction>Sum</AggregateFunction><Caption" & _
        ">Amount Due</Caption><DataMember>payment_amount</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><K" & _
        "ey>payment_amount</Key><Position>6</Position><TextAlignment>Far</TextAlignment><" & _
        "Width>91</Width><TotalFormatString>C2</TotalFormatString></Column6><Column7 ID=""" & _
        "NoInvoice""><AggregateFunction>Sum</AggregateFunction><Caption>NoInvoice</Caption" & _
        "><DataMember>NoInvoice</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><Key>NoInvoice</Key><Position>7</Position><Visible>False</" & _
        "Visible><TotalFormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>({0" & _
        "} Invoices)</TotalFormatString></Column7><Column8 ID=""OrderName""><Caption>OrderN" & _
        "ame</Caption><DataMember>OrderName</DataMember><Key>OrderName</Key><Position>8</" & _
        "Position><Visible>False</Visible></Column8></Columns><GroupCondition ID="""" /><So" & _
        "rtKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex></SortKey" & _
        "0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdCusChargeSummery.DesignTimeLayout = GridEXLayout2
        Me.GrdCusChargeSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCusChargeSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCusChargeSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCusChargeSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCusChargeSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdCusChargeSummery.Name = "GrdCusChargeSummery"
        Me.GrdCusChargeSummery.Size = New System.Drawing.Size(650, 312)
        Me.GrdCusChargeSummery.TabIndex = 8
        Me.GrdCusChargeSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
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
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(44, 58)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GrdCusPaymentDetail
        '
        Me.GrdCusPaymentDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCusPaymentDetail.DataSource = Me.DsFrmPrintARCus1.DetailPaySum
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><ChildTables Collection=""true""><Table0 ID=""Table1""><" & _
        "Columns Collection=""true""><Column0 ID=""id_service_center""><Caption>Inv Aplied</C" & _
        "aption><DataMember>id_service_center</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><Key>id_service_center</Key><Position>0</Pos" & _
        "ition></Column0><Column1 ID=""payment_amount""><AggregateFunction>Sum</AggregateFu" & _
        "nction><Caption>Aplied Amt</Caption><DataMember>payment_amount</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</" & _
        "FormatString><Key>payment_amount</Key><Position>1</Position><TextAlignment>Far</" & _
        "TextAlignment><TotalFormatString>c2</TotalFormatString></Column1></Columns><Data" & _
        "Member>DetailPaySumDetailPayDtl</DataMember><GroupCondition ID="""" /><Key>Table1<" & _
        "/Key></Table0></ChildTables><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>23</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>68</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition></Column2><Column3 ID=""name""><Caption>Last Name</Caption><DataMember>name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>name</Key><Position>3</Position><Width>96</Width></Column3><Column4 ID=""comp" & _
        "lete_name""><Caption>Company</Caption><DataMember>complete_name</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_name" & _
        "</Key><Position>4</Position><Width>114</Width></Column4><Column5 ID=""date_receiv" & _
        "e_payment""><Caption>Date</Caption><DataMember>date_receive_payment</DataMember><" & _
        "EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>" & _
        "MM/dd/yyyy</FormatString><Key>date_receive_payment</Key><Position>5</Position><W" & _
        "idth>69</Width></Column5><Column6 ID=""refrence_no""><AggregateFunction>Count</Agg" & _
        "regateFunction><Caption>Ref No.</Caption><DataMember>refrence_no</DataMember><Ed" & _
        "itType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>refrence_no" & _
        "</Key><Position>6</Position><Width>78</Width><TotalFormatMode>UseStringFormat</T" & _
        "otalFormatMode><TotalFormatString>( {0} Payment)</TotalFormatString></Column6><C" & _
        "olumn7 ID=""amount_receive""><AggregateFunction>Sum</AggregateFunction><Caption>Pa" & _
        "y Amount</Caption><DataMember>amount_receive</DataMember><EditType>NoEdit</EditT" & _
        "ype><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>" & _
        "amount_receive</Key><Position>7</Position><TextAlignment>Far</TextAlignment><Wid" & _
        "th>96</Width><TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=""pmt" & _
        "_method""><Caption>Pay method</Caption><DataMember>pmt_method</DataMember><EditTy" & _
        "pe>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>pmt_method</Key" & _
        "><Position>8</Position><Width>83</Width></Column8><Column9 ID=""other""><Aggregate" & _
        "Function>Sum</AggregateFunction><Caption>Other Store Paid</Caption><DataMember>o" & _
        "ther</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditT" & _
        "ype><FormatString>c2</FormatString><Key>other</Key><Position>9</Position><TextAl" & _
        "ignment>Far</TextAlignment><Width>96</Width><TotalFormatString>c2</TotalFormatSt" & _
        "ring></Column9><Column10 ID=""OrderName""><Caption>OrderName</Caption><DataMember>" & _
        "OrderName</DataMember><Key>OrderName</Key><Position>10</Position><Visible>False<" & _
        "/Visible></Column10><Column11 ID=""overpay""><AggregateFunction>Sum</AggregateFunc" & _
        "tion><Caption>Over Payment</Caption><DataMember>overpay</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatS" & _
        "tring><Key>overpay</Key><Position>11</Position><TextAlignment>Far</TextAlignment" & _
        "><TotalFormatString>c2</TotalFormatString></Column11></Columns><GroupCondition I" & _
        "D="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>10</ColInde" & _
        "x></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdCusPaymentDetail.DesignTimeLayout = GridEXLayout3
        Me.GrdCusPaymentDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCusPaymentDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCusPaymentDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCusPaymentDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCusPaymentDetail.Hierarchical = True
        Me.GrdCusPaymentDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdCusPaymentDetail.Name = "GrdCusPaymentDetail"
        Me.GrdCusPaymentDetail.Size = New System.Drawing.Size(650, 312)
        Me.GrdCusPaymentDetail.TabIndex = 9
        Me.GrdCusPaymentDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmPrintARCus1
        '
        Me.DsFrmPrintARCus1.DataSetName = "DsFrmPrintARCus"
        Me.DsFrmPrintARCus1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand10
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("name", "name"), New System.Data.Common.DataColumnMapping("complete_name", "complete_name"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_ma" & _
        "in.m_name + ' ' + cust_trtab_main.l_name AS name, cust_company.complete_name, 0 " & _
        "AS payment4, 0 AS payment2, 0 AS adjustment, 0 AS payment_amount, 1 AS flag, cus" & _
        "t_trtab_main.phone_1 FROM cust_trtab_main INNER JOIN service_center_head ON cust" & _
        "_trtab_main.cod_customer = service_center_head.cod_customer LEFT OUTER JOIN cust" & _
        "_company ON cust_trtab_main.cod_company = cust_company.cod_company WHERE (cust_t" & _
        "rtab_main.AR_charge = 1) GROUP BY cust_trtab_main.cod_customer, cust_trtab_main." & _
        "f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_na" & _
        "me, cust_trtab_main.phone_1"
        Me.SqlSelectCommand10.Connection = Me.Cnn
        '
        'GrdCusPaymentSummery
        '
        Me.GrdCusPaymentSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>18</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>64</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition></Column2><Column3 ID=""name""><Caption>Last Name</Caption><DataMember>name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>name</Key><Position>3</Position><Width>114</Width></Column3><Column4 ID=""com" & _
        "plete_name""><Caption>Company</Caption><DataMember>complete_name</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_nam" & _
        "e</Key><Position>4</Position><Width>117</Width></Column4><Column5 ID=""AMOUNT""><A" & _
        "ggregateFunction>Sum</AggregateFunction><Caption>Pay Amount</Caption><DataMember" & _
        ">AMOUNT</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><FormatString>c2</FormatString><Key>AMOUNT</Key><Position>5</Position><Te" & _
        "xtAlignment>Far</TextAlignment><Width>78</Width><TotalFormatString>c2</TotalForm" & _
        "atString></Column5><Column6 ID=""NoPay""><AggregateFunction>Sum</AggregateFunction" & _
        "><Caption>No Of Payments</Caption><DataMember>NoPay</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><Key>NoPay</Key><Position>6</" & _
        "Position><TextAlignment>Far</TextAlignment><Width>92</Width><TotalFormatString>#" & _
        "#####</TotalFormatString></Column6><Column7 ID=""other""><AggregateFunction>Sum</A" & _
        "ggregateFunction><Caption>Other Store Paid</Caption><DataMember>other</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStri" & _
        "ng>c2</FormatString><Key>other</Key><Position>7</Position><TextAlignment>Far</Te" & _
        "xtAlignment><Width>97</Width><TotalFormatString>c2</TotalFormatString></Column7>" & _
        "<Column8 ID=""OrderName""><Caption>OrderName</Caption><DataMember>OrderName</DataM" & _
        "ember><Key>OrderName</Key><Position>8</Position><Visible>False</Visible></Column" & _
        "8><Column9 ID=""overpay""><AggregateFunction>Sum</AggregateFunction><Caption>Over " & _
        "Payment</Caption><DataMember>overpay</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>overpay<" & _
        "/Key><Position>9</Position><TextAlignment>Far</TextAlignment><TotalFormatString>" & _
        "c2</TotalFormatString></Column9></Columns><GroupCondition ID="""" /><SortKeys Coll" & _
        "ection=""true""><SortKey0 ID=""SortKey0""><ColIndex>8</ColIndex></SortKey0></SortKey" & _
        "s></RootTable></GridEXLayoutData>"
        Me.GrdCusPaymentSummery.DesignTimeLayout = GridEXLayout4
        Me.GrdCusPaymentSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCusPaymentSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCusPaymentSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCusPaymentSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdCusPaymentSummery.Name = "GrdCusPaymentSummery"
        Me.GrdCusPaymentSummery.Size = New System.Drawing.Size(650, 312)
        Me.GrdCusPaymentSummery.TabIndex = 10
        Me.GrdCusPaymentSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand11
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT FROM GL_payment_deposit INNER JOIN service_center_head ON GL_payment_depos" & _
        "it.id_service_center = service_center_head.id_service_center"
        Me.SqlSelectCommand11.Connection = Me.Cnn
        '
        'GrdcusLedgerDetail
        '
        Me.GrdcusLedgerDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout5.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>20</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>76</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition></Column2><Column3 ID=""name""><Caption>Last Name</Caption><DataMember>name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>name</Key><Position>3</Position><Width>111</Width></Column3><Column4 ID=""com" & _
        "plete_name""><Caption>Company</Caption><DataMember>complete_name</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_nam" & _
        "e</Key><Position>4</Position><Width>140</Width></Column4><Column5 ID=""date""><Cap" & _
        "tion>Date</Caption><DataMember>date</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>d" & _
        "ate</Key><Position>5</Position><Width>71</Width></Column5><Column6 ID=""Ref. No"">" & _
        "<Caption>Ref. No</Caption><DataMember>id</DataMember><EditType>NoEdit</EditType>" & _
        "<FilterEditType>TextBox</FilterEditType><Key>Ref. No</Key><Position>6</Position>" & _
        "<Width>77</Width></Column6><Column7 ID=""charge""><AggregateFunction>Sum</Aggregat" & _
        "eFunction><Caption>Charges</Caption><DataMember>charge</DataMember><EditType>NoE" & _
        "dit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatSt" & _
        "ring><Key>charge</Key><Position>7</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>78</Width><TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=""c" & _
        "redit""><AggregateFunction>Sum</AggregateFunction><Caption>Credits</Caption><Data" & _
        "Member>credit</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fi" & _
        "lterEditType><FormatString>c2</FormatString><Key>credit</Key><Position>8</Positi" & _
        "on><TextAlignment>Far</TextAlignment><Width>80</Width><TotalFormatString>c2</Tot" & _
        "alFormatString></Column8><Column9 ID=""adj""><AggregateFunction>Sum</AggregateFunc" & _
        "tion><Caption>adjustments</Caption><DataMember>adj</DataMember><EditType>NoEdit<" & _
        "/EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString" & _
        "><Key>adj</Key><Position>9</Position><TextAlignment>Far</TextAlignment><Width>91" & _
        "</Width><TotalFormatString>C2</TotalFormatString></Column9><Column10 ID=""Balance" & _
        """><AggregateFunction>Sum</AggregateFunction><Caption>Balance</Caption><DataMembe" & _
        "r>Balance</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><FormatString>c2</FormatString><Key>Balance</Key><Position>10</Position" & _
        "><TotalFormatString>c2</TotalFormatString></Column10><Column11 ID=""due""><Caption" & _
        ">Due Date</Caption><DataMember>due</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>du" & _
        "e</Key><Position>11</Position><Width>77</Width></Column11><Column12 ID=""OrderDat" & _
        "e""><Caption>OrderDate</Caption><DataMember>OrderDate</DataMember><Key>OrderDate<" & _
        "/Key><Position>12</Position><Visible>False</Visible></Column12><Column13 ID=""dow" & _
        "n""><AggregateFunction>Sum</AggregateFunction><Caption>Down Payment</Caption><Dat" & _
        "aMember>down</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fil" & _
        "terEditType><FormatString>c2</FormatString><Key>down</Key><Position>13</Position" & _
        "><TextAlignment>Far</TextAlignment><Width>87</Width><TotalFormatString>c2</Total" & _
        "FormatString></Column13><Column14 ID=""OVERPAID""><AggregateFunction>Sum</Aggregat" & _
        "eFunction><Caption>Over Payment</Caption><DataMember>OVERPAID</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</F" & _
        "ormatString><Key>OVERPAID</Key><Position>14</Position><TextAlignment>Far</TextAl" & _
        "ignment><Width>81</Width><TotalFormatString>c2</TotalFormatString></Column14><Co" & _
        "lumn15 ID=""other""><AggregateFunction>Sum</AggregateFunction><Caption>Other Store" & _
        " Paid</Caption><DataMember>other</DataMember><EditType>NoEdit</EditType><FilterE" & _
        "ditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>other</Key><" & _
        "Position>15</Position><TextAlignment>Far</TextAlignment><Width>90</Width><TotalF" & _
        "ormatString>c2</TotalFormatString></Column15><Column16 ID=""OrderName""><Caption>O" & _
        "rderName</Caption><DataMember>OrderName</DataMember><Key>OrderName</Key><Positio" & _
        "n>16</Position><Visible>False</Visible></Column16></Columns><GroupCondition ID=""" & _
        """ /><Groups Collection=""true""><Group0 ID=""Group0""><ColIndex>1</ColIndex></Group0" & _
        "></Groups><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>16</ColI" & _
        "ndex></SortKey0><SortKey1 ID=""SortKey1""><ColIndex>12</ColIndex></SortKey1></Sort" & _
        "Keys></RootTable></GridEXLayoutData>"
        Me.GrdcusLedgerDetail.DesignTimeLayout = GridEXLayout5
        Me.GrdcusLedgerDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdcusLedgerDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdcusLedgerDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdcusLedgerDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdcusLedgerDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdcusLedgerDetail.Name = "GrdcusLedgerDetail"
        Me.GrdcusLedgerDetail.Size = New System.Drawing.Size(650, 312)
        Me.GrdcusLedgerDetail.TabIndex = 11
        Me.GrdcusLedgerDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmARCusReport1
        '
        Me.DsFrmARCusReport1.DataSetName = "DSFrmARCusReport"
        Me.DsFrmARCusReport1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GrdPastDueDetail
        '
        Me.GrdPastDueDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout6.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>22</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>82</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition></Column2><Column3 ID=""name""><Caption>Last Name</Caption><DataMember>name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>name</Key><Position>3</Position><Width>102</Width></Column3><Column4 ID=""com" & _
        "plete_name""><Caption>Company</Caption><DataMember>complete_name</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_nam" & _
        "e</Key><Position>4</Position></Column4><Column5 ID=""date_refer""><Caption>Date</C" & _
        "aption><DataMember>date_refer</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>date_re" & _
        "fer</Key><Position>5</Position><Width>75</Width></Column5><Column6 ID=""id_servic" & _
        "e_center""><AggregateFunction>Count</AggregateFunction><Caption>Ref. No</Caption>" & _
        "<DataMember>id_service_center</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>id_service_center</Key><Position>6</Position><" & _
        "Width>78</Width><TotalFormatMode>UseStringFormat</TotalFormatMode><TotalFormatSt" & _
        "ring>({0} Invoices)</TotalFormatString></Column6><Column7 ID=""payment4""><Aggrega" & _
        "teFunction>Sum</AggregateFunction><Caption>Amount Due</Caption><DataMember>payme" & _
        "nt_amount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><FormatString>c2</FormatString><Key>payment4</Key><LineAlignment>Far</L" & _
        "ineAlignment><Position>7</Position><TextAlignment>Far</TextAlignment><Width>85</" & _
        "Width><TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=""days_past""" & _
        "><Caption>Days Past Due</Caption><DataMember>days_past</DataMember><EditType>NoE" & _
        "dit</EditType><FilterEditType>TextBox</FilterEditType><Key>days_past</Key><Posit" & _
        "ion>8</Position><Width>93</Width></Column8><Column9 ID=""phone_1""><Caption>Home P" & _
        "hone</Caption><DataMember>phone_1</DataMember><EditType>NoEdit</EditType><Filter" & _
        "EditType>TextBox</FilterEditType><Key>phone_1</Key><Position>9</Position><Width>" & _
        "88</Width></Column9><Column10 ID=""phone_2""><Caption>Work Phone</Caption><DataMem" & _
        "ber>phone_2</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><Key>phone_2</Key><Position>10</Position></Column10><Column11 ID=""cus" & _
        "t_notes""><Caption>Note</Caption><DataMember>cust_notes</DataMember><EditType>NoE" & _
        "dit</EditType><FilterEditType>TextBox</FilterEditType><Key>cust_notes</Key><Posi" & _
        "tion>11</Position></Column11><Column12 ID=""OrderName""><Caption>OrderName</Captio" & _
        "n><DataMember>OrderName</DataMember><Key>OrderName</Key><Position>12</Position><" & _
        "Visible>False</Visible></Column12></Columns><GroupCondition ID="""" /><Groups Coll" & _
        "ection=""true""><Group0 ID=""Group0""><ColIndex>1</ColIndex></Group0></Groups><SortK" & _
        "eys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>12</ColIndex></SortKey0>" & _
        "</SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdPastDueDetail.DesignTimeLayout = GridEXLayout6
        Me.GrdPastDueDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPastDueDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdPastDueDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdPastDueDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdPastDueDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdPastDueDetail.Name = "GrdPastDueDetail"
        Me.GrdPastDueDetail.Size = New System.Drawing.Size(650, 312)
        Me.GrdPastDueDetail.TabIndex = 13
        '
        'GrdPastDueSummery
        '
        Me.GrdPastDueSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout7.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>22</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>70</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition></Column2><Column3 ID=""name""><Caption>Last Name</Caption><DataMember>name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>name</Key><Position>3</Position><Width>94</Width></Column3><Column4 ID=""comp" & _
        "lete_name""><Caption>Company</Caption><DataMember>complete_name</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_name" & _
        "</Key><Position>4</Position><Width>119</Width></Column4><Column5 ID=""payment4""><" & _
        "AggregateFunction>Sum</AggregateFunction><Caption>Amount Due</Caption><DataMembe" & _
        "r>payment_amount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><FormatString>c2</FormatString><Key>payment4</Key><Position>5</P" & _
        "osition><TextAlignment>Far</TextAlignment><Width>85</Width><TotalFormatString>c2" & _
        "</TotalFormatString></Column5><Column6 ID=""phone_1""><Caption>Main Phone</Caption" & _
        "><DataMember>phone_1</DataMember><EditType>NoEdit</EditType><FilterEditType>Text" & _
        "Box</FilterEditType><Key>phone_1</Key><Position>6</Position><Width>79</Width></C" & _
        "olumn6><Column7 ID=""last_pay""><Caption>Last Payment Date</Caption><DataMember>la" & _
        "st_pay</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><FormatString>MM/dd/yyyy</FormatString><Key>last_pay</Key><Position>7</Pos" & _
        "ition><Width>105</Width></Column7><Column8 ID=""amount_receive""><AggregateFunctio" & _
        "n>Sum</AggregateFunction><Caption>Last Payment Amount</Caption><DataMember>amoun" & _
        "t_receive</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><FormatString>c2</FormatString><Key>amount_receive</Key><Position>8</Po" & _
        "sition><TextAlignment>Far</TextAlignment><TotalFormatString>c2</TotalFormatStrin" & _
        "g></Column8><Column9 ID=""OrderName""><Caption>OrderName</Caption><DataMember>Orde" & _
        "rName</DataMember><Key>OrderName</Key><Position>9</Position><Visible>False</Visi" & _
        "ble></Column9></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><Sor" & _
        "tKey0 ID=""SortKey0""><ColIndex>9</ColIndex></SortKey0></SortKeys></RootTable></Gr" & _
        "idEXLayoutData>"
        Me.GrdPastDueSummery.DesignTimeLayout = GridEXLayout7
        Me.GrdPastDueSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPastDueSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdPastDueSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdPastDueSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdPastDueSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdPastDueSummery.Name = "GrdPastDueSummery"
        Me.GrdPastDueSummery.Size = New System.Drawing.Size(650, 312)
        Me.GrdPastDueSummery.TabIndex = 14
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_customer, BalanceAmount FROM View_Customer_Balance"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO View_Customer_Balance(cod_customer, BalanceAmount) VALUES (@cod_custo" & _
        "mer, @BalanceAmount); SELECT cod_customer, BalanceAmount FROM View_Customer_Bala" & _
        "nce"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BalanceAmount", System.Data.SqlDbType.Float, 8, "BalanceAmount"))
        '
        'DAViewCusBalense
        '
        Me.DAViewCusBalense.InsertCommand = Me.SqlInsertCommand2
        Me.DAViewCusBalense.SelectCommand = Me.SqlSelectCommand3
        Me.DAViewCusBalense.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_Customer_Balance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'CmdSPFindDueDate
        '
        Me.CmdSPFindDueDate.CommandText = "SELECT DueAllInvoice_1.id_service_center, DueAllInvoice_1.payment_amount, DueAllI" & _
        "nvoice_1.AR_due_date, DueAllInvoice_1.AR_terms, DueAllInvoice_1.cod_customer FRO" & _
        "M DueAllInvoice() DueAllInvoice_1 INNER JOIN GL_payment_AR ON DueAllInvoice_1.ID" & _
        "_payment = GL_payment_AR.ID_payment WHERE (DueAllInvoice_1.ID_payment IS NOT NUL" & _
        "L) AND (GL_payment_AR.Cancel_flag IS NULL OR GL_payment_AR.Cancel_flag = 0) ORDE" & _
        "R BY DueAllInvoice_1.ID_payment"
        Me.CmdSPFindDueDate.Connection = Me.Cnn
        '
        'CmdAging
        '
        Me.CmdAging.CommandText = "SELECT SUM(CASE WHEN DATEDIFF(day, GETDATE(), DueAllInvoice_1.AR_due_date) > 0 TH" & _
        "EN DueAllInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c1, SUM(CASE W" & _
        "HEN DATEDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) BETWEEN 1 AND 30 THEN " & _
        "DueAllInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c2, SUM(CASE WHEN" & _
        " DATEDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) BETWEEN 31 AND 60 THEN Du" & _
        "eAllInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c3, SUM(CASE WHEN D" & _
        "ATEDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) BETWEEN 61 AND 90 THEN DueA" & _
        "llInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c4, SUM(CASE WHEN DAT" & _
        "EDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) > 90 THEN DueAllInvoice_1.pay" & _
        "ment_amount ELSE cast('0' AS money) END) AS c5, DueAllInvoice_1.cod_customer FRO" & _
        "M DueAllInvoice() DueAllInvoice_1 INNER JOIN GL_payment_AR ON DueAllInvoice_1.ID" & _
        "_payment = GL_payment_AR.ID_payment WHERE (DueAllInvoice_1.ID_payment IS NOT NUL" & _
        "L) AND (GL_payment_AR.Cancel_flag IS NULL OR GL_payment_AR.Cancel_flag = 0) GROU" & _
        "P BY DueAllInvoice_1.cod_customer ORDER BY DueAllInvoice_1.cod_customer"
        Me.CmdAging.Connection = Me.Cnn
        '
        'DAForCommand
        '
        Me.DAForCommand.SelectCommand = Me.SqlSelectCommand4
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_ma" & _
        "in.m_name + ' ' + cust_trtab_main.l_name AS name, View_Customer_Balance.BalanceA" & _
        "mount, service_center_head.credit, cust_company.complete_name FROM cust_trtab_ma" & _
        "in INNER JOIN View_Customer_Balance ON cust_trtab_main.cod_customer = View_Custo" & _
        "mer_Balance.cod_customer LEFT OUTER JOIN (SELECT SUM(GL_payment_deposit.payment_" & _
        "amount) AS credit, service_center_head.cod_customer FROM GL_payment_deposit INNE" & _
        "R JOIN service_center_head ON GL_payment_deposit.id_service_center = service_cen" & _
        "ter_head.id_service_center WHERE (GL_payment_deposit.refer_type = '1') GROUP BY " & _
        "service_center_head.cod_customer) service_center_head ON cust_trtab_main.cod_cus" & _
        "tomer = service_center_head.cod_customer LEFT OUTER JOIN cust_company ON cust_tr" & _
        "tab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'GrdAging
        '
        Me.GrdAging.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout8.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>19</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>71</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition><Width>90</Width></Column2><Column3 ID=""name""><Caption>Last Name</Caption>" & _
        "<DataMember>name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>name</Key><Position>3</Position><Width>88</Width></Column3>" & _
        "<Column4 ID=""complete_name""><AggregateFunction>Sum</AggregateFunction><Caption>C" & _
        "ompany</Caption><DataMember>complete_name</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><Key>complete_name</Key><Position>4</Po" & _
        "sition><Width>107</Width></Column4><Column5 ID=""BalanceAmount""><AggregateFunctio" & _
        "n>Sum</AggregateFunction><Caption>Balance</Caption><DataMember>BalanceAmount</Da" & _
        "taMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><For" & _
        "matString>c2</FormatString><Key>BalanceAmount</Key><Position>5</Position><TextAl" & _
        "ignment>Far</TextAlignment><Width>74</Width></Column5><Column6 ID=""credit""><Aggr" & _
        "egateFunction>Sum</AggregateFunction><Caption>Credit</Caption><DataMember>credit" & _
        "</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType>" & _
        "<FormatString>c2</FormatString><Key>credit</Key><Position>6</Position><TextAlign" & _
        "ment>Far</TextAlignment><Width>71</Width><TotalFormatString>c2</TotalFormatStrin" & _
        "g></Column6><Column7 ID=""Charge""><AggregateFunction>Sum</AggregateFunction><Capt" & _
        "ion>Charge</Caption><DataMember>Charge</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Charge" & _
        "</Key><Position>7</Position><TextAlignment>Far</TextAlignment><Width>74</Width><" & _
        "TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=""c1""><AggregateFun" & _
        "ction>Sum</AggregateFunction><Caption>Not Due Yet</Caption><DataMember>c1</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Format" & _
        "String>c2</FormatString><Key>c1</Key><Position>8</Position><TextAlignment>Far</T" & _
        "extAlignment><Width>84</Width></Column8><Column9 ID=""c2""><AggregateFunction>Sum<" & _
        "/AggregateFunction><Caption>1-30 Days</Caption><DataMember>c2</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</F" & _
        "ormatString><Key>c2</Key><Position>9</Position><TextAlignment>Far</TextAlignment" & _
        "><Width>85</Width></Column9><Column10 ID=""c3""><AggregateFunction>Sum</AggregateF" & _
        "unction><Caption>31-60 Days</Caption><DataMember>c3</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStrin" & _
        "g><Key>c3</Key><Position>10</Position><TextAlignment>Far</TextAlignment><Width>8" & _
        "5</Width></Column10><Column11 ID=""c4""><AggregateFunction>Sum</AggregateFunction>" & _
        "<Caption>61-90 Days</Caption><DataMember>c4</DataMember><EditType>NoEdit</EditTy" & _
        "pe><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>c" & _
        "4</Key><Position>11</Position><TextAlignment>Far</TextAlignment><Width>83</Width" & _
        "></Column11><Column12 ID=""c5""><AggregateFunction>Sum</AggregateFunction><Caption" & _
        ">Over 90 Days</Caption><DataMember>c5</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>c5</Key" & _
        "><Position>12</Position><TextAlignment>Far</TextAlignment><Width>92</Width></Col" & _
        "umn12></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdAging.DesignTimeLayout = GridEXLayout8
        Me.GrdAging.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdAging.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdAging.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdAging.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdAging.Location = New System.Drawing.Point(0, 64)
        Me.GrdAging.Name = "GrdAging"
        Me.GrdAging.Size = New System.Drawing.Size(650, 312)
        Me.GrdAging.TabIndex = 15
        Me.GrdAging.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'CmdC1
        '
        Me.CmdC1.CommandText = "dbo.[SP_CustomerAgingNotDueYet]"
        Me.CmdC1.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdC1.Connection = Me.Cnn
        Me.CmdC1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdC1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag", System.Data.SqlDbType.VarChar, 1))
        '
        'CmdC2
        '
        Me.CmdC2.CommandText = "dbo.[SP_CustomerAging1to30]"
        Me.CmdC2.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdC2.Connection = Me.Cnn
        Me.CmdC2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdC2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag", System.Data.SqlDbType.VarChar, 1))
        '
        'CmdC3
        '
        Me.CmdC3.CommandText = "dbo.[SP_CustomerAging31to60]"
        Me.CmdC3.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdC3.Connection = Me.Cnn
        Me.CmdC3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdC3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag", System.Data.SqlDbType.VarChar, 1))
        '
        'CmdC4
        '
        Me.CmdC4.CommandText = "dbo.[SP_CustomerAging61to90]"
        Me.CmdC4.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdC4.Connection = Me.Cnn
        Me.CmdC4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdC4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag", System.Data.SqlDbType.VarChar, 1))
        '
        'CmdC5
        '
        Me.CmdC5.CommandText = "dbo.[SP_CustomerAgingOver90]"
        Me.CmdC5.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdC5.Connection = Me.Cnn
        Me.CmdC5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdC5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        Me.CmdC5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag", System.Data.SqlDbType.VarChar, 1))
        '
        'GrdcusLedgerSummery
        '
        Me.GrdcusLedgerSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout9.LayoutString = "<GridEXLayoutData><RootTable><Caption>CusARLedgerSummery</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMember>flag" & _
        "</DataMember><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><" & _
        "Width>20</Width></Column0><Column1 ID=""cod_customer""><Caption>Customer</Caption>" & _
        "<TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringVa" & _
        "lue /><DataMember>cod_customer</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>cod_customer</Key><Position>1</Position><Widt" & _
        "h>78</Width></Column1><Column2 ID=""f_name""><Caption>First Name</Caption><DataMem" & _
        "ber>f_name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><Key>f_name</Key><Position>2</Position></Column2><Column3 ID=""name""><C" & _
        "aption>Last Name</Caption><DataMember>name</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><Key>name</Key><Position>3</Position><" & _
        "/Column3><Column4 ID=""complete_name""><Caption>Company</Caption><DataMember>compl" & _
        "ete_name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><Key>complete_name</Key><Position>4</Position><Width>121</Width></Column" & _
        "4><Column5 ID=""charge""><AggregateFunction>Sum</AggregateFunction><Caption>Charge" & _
        "s</Caption><DataMember>charge</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><FormatString>c2</FormatString><Key>charge</Key><Po" & _
        "sition>5</Position><TextAlignment>Far</TextAlignment><Width>81</Width><TotalForm" & _
        "atString>c2</TotalFormatString></Column5><Column6 ID=""credit""><AggregateFunction" & _
        ">Sum</AggregateFunction><Caption>Credits</Caption><DataMember>credit</DataMember" & _
        "><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStrin" & _
        "g>c2</FormatString><Key>credit</Key><Position>6</Position><TextAlignment>Far</Te" & _
        "xtAlignment><Width>79</Width><TotalFormatString>c2</TotalFormatString></Column6>" & _
        "<Column7 ID=""adj""><AggregateFunction>Sum</AggregateFunction><Caption>Adjustments" & _
        "</Caption><DataMember>adj</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><FormatString>c2</FormatString><Key>adj</Key><Position>" & _
        "7</Position><TextAlignment>Far</TextAlignment><Width>88</Width><TotalFormatStrin" & _
        "g>c2</TotalFormatString></Column7><Column8 ID=""Balance""><AggregateFunction>Sum</" & _
        "AggregateFunction><Caption>Balance</Caption><DataMember>Balance</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2<" & _
        "/FormatString><Key>Balance</Key><Position>8</Position><Width>83</Width><TotalFor" & _
        "matString>c2</TotalFormatString></Column8><Column9 ID=""down""><AggregateFunction>" & _
        "Sum</AggregateFunction><Caption>Down Payment</Caption><DataMember>Down</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStr" & _
        "ing>c2</FormatString><Key>down</Key><Position>9</Position><TextAlignment>Far</Te" & _
        "xtAlignment><Width>131</Width><TotalFormatString>c2</TotalFormatString></Column9" & _
        "><Column10 ID=""OVERPAID""><AggregateFunction>Sum</AggregateFunction><Caption>Over" & _
        " Payment</Caption><DataMember>OVERPAID</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>OVERPA" & _
        "ID</Key><Position>10</Position><TextAlignment>Far</TextAlignment><Width>129</Wid" & _
        "th><TotalFormatString>c2</TotalFormatString></Column10><Column11 ID=""Other""><Agg" & _
        "regateFunction>Sum</AggregateFunction><Caption>Other Store Paymant</Caption><Dat" & _
        "aMember>Other</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fi" & _
        "lterEditType><FormatString>c2</FormatString><Key>Other</Key><Position>11</Positi" & _
        "on><TextAlignment>Far</TextAlignment><Width>139</Width><TotalFormatString>c2</To" & _
        "talFormatString></Column11><Column12 ID=""OrderName""><Caption>OrderName</Caption>" & _
        "<DataMember>OrderName</DataMember><Key>OrderName</Key><Position>12</Position><Vi" & _
        "sible>False</Visible></Column12></Columns><GroupCondition ID="""" /><Key>CusARLedg" & _
        "erSummery</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>12<" & _
        "/ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdcusLedgerSummery.DesignTimeLayout = GridEXLayout9
        Me.GrdcusLedgerSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdcusLedgerSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdcusLedgerSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdcusLedgerSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdcusLedgerSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdcusLedgerSummery.Name = "GrdcusLedgerSummery"
        Me.GrdcusLedgerSummery.Size = New System.Drawing.Size(650, 312)
        Me.GrdcusLedgerSummery.TabIndex = 12
        Me.GrdcusLedgerSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'FrmPrintARCus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 372)
        Me.Controls.Add(Me.GrdAging)
        Me.Controls.Add(Me.GrdPastDueDetail)
        Me.Controls.Add(Me.GrdCusPaymentDetail)
        Me.Controls.Add(Me.GrdcusLedgerSummery)
        Me.Controls.Add(Me.GrdcusLedgerDetail)
        Me.Controls.Add(Me.GrdCusPaymentSummery)
        Me.Controls.Add(Me.GrdPastDueSummery)
        Me.Controls.Add(Me.GrdCusChargeDetail)
        Me.Controls.Add(Me.GrdCusChargeSummery)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "FrmPrintARCus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        Me.PanelPrint.ResumeLayout(False)
        CType(Me.GrdCusChargeDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCusChargeSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCusPaymentDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPrintARCus1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCusPaymentSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdcusLedgerDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmARCusReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPastDueDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPastDueSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdAging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdcusLedgerSummery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        customerARChargeDetail = 1
        customerARChargeSummery = 2
        CustomerARPaymentDetail = 3
        CustomerARPaymentSummery = 4
        CustomerARLedgerDetail = 5
        CustomerARLedgerSummery = 6
        CustomerDuePastDetail = 7
        CustomerDuePastSummery = 8
        CustomerAgingDetail = 9
        CustomerAgingSummery = 10
    End Enum
    'Public Event ProcessForm()
    Public KindOfReport As KindReport
    Public Date1 As String
    Public Date2 As String
    Public StrWhere As String
    Public StrFilter As String
    Public RdoSelect As Byte
    Public RdoStr As String
    Public FilterLeft As String
    Public DSCus As New DataSet

    Private Sub FrmPrintARCus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        'CnnReader.ConnectionString = PConnectionString
        Select Case KindOfReport
            Case KindReport.customerARChargeDetail
                Call FillCusChargeDetail()

            Case KindReport.customerARChargeSummery
                Call FillARCusChargeSummery()

            Case KindReport.CustomerARPaymentDetail
                Call FillARCusPayDetail()

            Case KindReport.CustomerARPaymentSummery
                Call FillARCusPaySummery()

            Case KindReport.CustomerARLedgerDetail
                'RaiseEvent ProcessForm()
                Call FillARLedgerDetail()
            Case KindReport.CustomerARLedgerSummery
                Call FillARLedgerSummery()

            Case KindReport.CustomerDuePastDetail
                Call FillDuePastDetail()

            Case KindReport.CustomerDuePastSummery
                Call FillDuePastSummery()

            Case KindReport.CustomerAgingDetail
                Call FillAgingDetail2()

                BtnJPrint.Top = 5
                BtnJPrint.Left = 587
                Label30.Top = 36
                Label30.Left = 587
                PanelPrint.Visible = True
                BtnFchooser.Top = 5
                BtnFchooser.Left = 416
                Label3.Top = 36
                Label3.Left = 414

            Case KindReport.CustomerAgingSummery
                Call FillAgingSummery2()

        End Select
        If Date1 Is Nothing Then
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        Else

            If Date1.Trim.Length > 0 Then
                GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
            Else
                GridEXPrintDocument1.PageHeaderCenter = Me.Text
            End If
        End If
        GridEXPrintDocument1.PageHeaderLeft = FilterLeft

        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")

    End Sub

    Private Sub FillCusChargeDetail()


        DACusChargeDetail.SelectCommand.CommandText = DACusChargeDetail.SelectCommand.CommandText & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & " ORDER BY  cust_trtab_main.cod_customer,dbo.ChangeDate(service_center_head.date_refer)"

        DsFrmPrintARCus1.Clear()
        DACusChargeDetail.Fill(DsFrmPrintARCus1.CusChargeDetail)

        If DsFrmPrintARCus1.CusChargeDetail.Count = 0 Then
            Exit Sub
        End If



        '''''due
        'DAGeneral.SelectCommand.CommandText = "SELECT     GL_payment_deposit.id_service_center AS id, ROUND(ISNULL(SUM(GL_payment_deposit.payment_amount), 0), 2) AS pay, " & _
        '              " GL_payment_AR.AR_due_date AS due, SUM(ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2)) AS paid, DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) AS days, GL_payment_AR.AR_terms as ARTerm " & _
        '              " FROM         GL_payment_deposit INNER JOIN " & _
        '              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
        '              " WHERE     (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4')  " & _
        '              "  AND (GL_payment_AR.Cancel_flag = '0') AND (GL_payment_deposit.payment_amount - GL_payment_deposit.Paid_amount <> 0) " & _
        '              " GROUP BY GL_payment_deposit.id_service_center, GL_payment_AR.AR_due_date, GL_payment_AR.AR_terms "

        'DsFrmPrintARCus1.PastDue.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)



        'For i As Integer = 0 To DsFrmPrintARCus1.PastDue.Count - 1
        '    Try
        '        If DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past <> "0" Then

        '            If DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past < DsFrmPrintARCus1.PastDue(i).days Then
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).Due_Date = DsFrmPrintARCus1.PastDue(i).due
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = DsFrmPrintARCus1.PastDue(i).ARTerm

        '            End If
        '        Else
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).due_date = DsFrmPrintARCus1.PastDue(i).due
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = DsFrmPrintARCus1.PastDue(i).ARTerm
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = DsFrmPrintARCus1.PastDue(i).ARTerm
        '        End If

        '    Catch ex As Exception

        '    End Try

        'Next

        '''''adj+

        'DAGeneral.SelectCommand.CommandText = " SELECT     GL_account_adjustment_dtl.id_service_center as id, GL_account_adjustment_head.date_adjustment AS due, " & _
        '              " SUM(ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)) AS pay, 0 AS paid,DATEDIFF(day, GL_account_adjustment_head.date_adjustment, GETDATE()) AS days " & _
        '              " FROM         GL_account_adjustment_head INNER JOIN " & _
        '              " GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no " & _
        '              " WHERE     (GL_account_adjustment_head.amount_adjustment > 0)  " & _
        '               " GROUP BY   GL_account_adjustment_dtl.id_service_center,date_adjustment "

        'DsFrmPrintARCus1.PastDue.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)


        'For i As Integer = 0 To DsFrmPrintARCus1.PastDue.Count - 1
        '    Try
        '        If DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past <> "0" Then
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount + DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)
        '        Else
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).due_date = DsFrmPrintARCus1.PastDue(i).due
        '            'DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = SQLReader("AR_terms")
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days
        '            DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount + DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)

        '        End If

        '    Catch ex As Exception

        '    End Try

        'Next



        '''''adj-

        'DAGeneral.SelectCommand.CommandText = "SELECT     GL_account_adjustment_dtl.id_service_center as id, GL_payment_AR.AR_due_date AS due, " & _
        '              " SUM(ROUND(ISNULL(GL_account_adjustment_dtl.amount_adjustment, 0), 2)) AS pay,0 as paid, DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) AS days,GL_account_adjustment_dtl.refrence_no as id2 " & _
        '              " FROM         service_center_head INNER JOIN " & _
        '              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '              " GL_account_adjustment_dtl ON service_center_head.id_service_center = GL_account_adjustment_dtl.id_service_center INNER JOIN " & _
        '              " GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_head.refrence_no " & _
        '              " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND  " & _
        '              " (GL_account_adjustment_head.amount_adjustment < 0)  " & _
        '              " GROUP BY GL_payment_AR.AR_due_date, GL_account_adjustment_dtl.id_service_center, GL_account_adjustment_dtl.refrence_no " & _
        '              " ORDER BY GL_account_adjustment_dtl.refrence_no,GL_account_adjustment_dtl.id_service_center,DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) DESC"

        'DsFrmPrintARCus1.PastDue.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)
        'Dim Id As String = ""
        'Dim Id2 As String = ""

        'For i As Integer = 0 To DsFrmPrintARCus1.PastDue.Count - 1
        '    If DsFrmPrintARCus1.PastDue(i).id <> Id And DsFrmPrintARCus1.PastDue(i).id2 <> Id2 Then
        '        Id = DsFrmPrintARCus1.PastDue(i).id
        '        Id2 = DsFrmPrintARCus1.PastDue(i).id2
        '        Try
        '            If DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past <> "0" Then
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount + DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)
        '            Else
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).due_date = DsFrmPrintARCus1.PastDue(i).due
        '                'DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = SQLReader("AR_terms")
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days
        '                DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusChargeDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount + DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)

        '            End If

        '        Catch ex As Exception

        '        End Try
        '    End If


        'Next

        GrdCusChargeDetail.SetDataBinding(DsFrmPrintARCus1.CusChargeDetail, "")

        DsFrmPrintARCus1.CusChargeDetail.AcceptChanges()
        GrdCusChargeDetail.BringToFront()



    End Sub
    Private Sub FillARCusChargeSummery()
        Dim st As String
        st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")


        'DACusChargeSummery.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '    " cust_company.complete_name+'' as complete_name, COUNT(service_center_head.id_service_center) AS NoInvoice, SUM(ROUND(ISNULL(service_center_head.Total, 0), 2)) AS total, " & _
        '    " 0 AS payment4, 0 AS payment2, 0 AS adjustment, 0 AS payment_amount, 1 AS flag " & _
        '    " FROM         cust_trtab_main INNER JOIN " & _
        '    " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer LEFT OUTER JOIN " & _
        '    " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '    " WHERE  (service_center_head.type_of_form = 'IN') AND  (cust_trtab_main.AR_charge = 1) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '    " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name  "
        DACusChargeSummery.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                        " cust_company.complete_name + '' AS complete_name, COUNT(service_center_head.id_service_center) AS NoInvoice,  " & _
            " SUM(ROUND(ISNULL(service_center_head.Total, 0), 2)) AS total, 0 AS payment4, 0 AS payment2, 0 AS adjustment, SUM(ROUND(ISNULL(View_Total_Balance_ForEach_ARDue.TotalArBalanceAmount, " & _
            " 0), 2)) AS payment_amount, 1 AS flag " & st & _
            "  ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
            " FROM         cust_trtab_main INNER JOIN " & _
            " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
            " View_Total_Balance_ForEach_ARDue ON  " & _
            " service_center_head.id_service_center = View_Total_Balance_ForEach_ARDue.id_service_center LEFT OUTER JOIN " & _
            " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
            " WHERE     (cust_trtab_main.AR_charge = 1) AND (service_center_head.type_of_form = 'IN') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
            " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name "

        DsFrmPrintARCus1.Clear()
        DACusChargeSummery.Fill(DsFrmPrintARCus1.CusChargeSummery)
        If DsFrmPrintARCus1.CusChargeSummery.Count = 0 Then
            Exit Sub
        End If

        'DAGeneral.SelectCommand.CommandText = "SELECT     service_center_head.cod_customer as id, ROUND(ISNULL(SUM(GL_payment_deposit.payment_amount), 0), 2) AS pay, " & _
        '                    " GL_payment_AR.AR_due_date AS due,SUM(ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2)) AS paid, DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
        '                    " FROM         service_center_head INNER JOIN " & _
        '                    " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '                    " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
        '                   " WHERE     (service_center_head.type_of_form = 'IN') AND  " & _
        '                   " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & _
        '                   " GROUP BY service_center_head.cod_customer, GL_payment_AR.AR_due_date "

        'DsFrmPrintARCus1.AgingDetail.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)

        'DAGeneral.SelectCommand.CommandText = " SELECT  cod_customer as id,   date_adjustment AS due,  SUM(ROUND(ISNULL(amount_adjustment, 0), 2)) AS pay,0 as paid " & _
        '             " ,DATEDIFF(day, date_adjustment, GETDATE()) AS days  " & _
        '             " FROM         GL_account_adjustment_head " & _
        '             " GROUP BY  cod_customer,date_adjustment "

        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)



        'For I As Integer = 0 To DsFrmPrintARCus1.PastDue.Count - 1
        '    Try
        '        DsFrmPrintARCus1.CusChargeSummery.FindBycod_customer(DsFrmPrintARCus1.PastDue(I).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusChargeSummery.FindBycod_customer(DsFrmPrintARCus1.PastDue(I).id).payment_amount + DsFrmPrintARCus1.PastDue(I).pay - DsFrmPrintARCus1.PastDue(I).paid, 2)
        '    Catch ex As Exception

        '    End Try
        'Next







        'DsFrmPrintARCus1.CusChargeSummery.DefaultView.RowFilter = " FlagShow = true  "
        GrdCusChargeSummery.SetDataBinding(DsFrmPrintARCus1.CusChargeSummery, "")

        DsFrmPrintARCus1.CusChargeSummery.AcceptChanges()
        GrdCusChargeSummery.BringToFront()

    End Sub


    Private Sub FillARCusPayDetail()
        'Dim st As String
        'st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")

        '''' Gl_receive_payment.amount_over be jaye other be onvane over payment gharar girad
        'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '        " cust_company.complete_name+'' as complete_name, Gl_receive_payment.date_receive_payment, Gl_receive_payment.refrence_no,ROUND(ISNULL( Gl_receive_payment.amount_receive, 0), 2) as amount_receive,  " & _
        '        " GL_payment_deposit.payment_amount, GL_payment_deposit.id_service_center, GL_payment_deposit.ID_payment, cust_company.cod_company, " & _
        '        " CASE Gl_receive_payment.pmt_method WHEN 1 THEN 'Cash' WHEN 2 THEN 'CHECK' WHEN 3 THEN 'Credit' END AS pmt_method, 1 AS flag,ROUND(ISNULL( Gl_receive_payment.OtherStoreAmount, 0), 2) as other " & st & _
        '        " ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName,ROUND(ISNULL( Gl_receive_payment.amount_over, 0), 2) as overpay " & _
        '        " FROM         cust_trtab_main INNER JOIN " & _
        '        " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '        " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '        " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
        '        " GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
        '        " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '        " WHERE (cust_trtab_main.AR_charge = 1)   " & IIf(Date1.Trim.Length = 0, "", " AND dbo.ChangeDate(Gl_receive_payment.date_receive_payment) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2))) & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        'DAGeneral.Fill(DsFrmPrintARCus1.CusARPayment)



        DAGeneral.SelectCommand.CommandText = " SELECT DISTINCT  " & _
                    "    cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                    "    cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment, Gl_receive_payment.refrence_no,  " & _
                    "  ROUND(ISNULL(Gl_receive_payment.amount_receive, 0), 2) AS amount_receive, cust_company.cod_company,  " & _
                    "  CASE Gl_receive_payment.pmt_method WHEN 1 THEN 'Cash' WHEN 2 THEN 'CHECK' WHEN 3 THEN 'Credit' END AS pmt_method, 1 AS flag,  " & _
                    "  ROUND(ISNULL(Gl_receive_payment.OtherStoreAmount, 0), 2) AS other, 1 AS FlagShow, CASE WHEN cust_company.complete_name IS NULL  " & _
                    "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                    "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, ROUND(ISNULL(Gl_receive_payment.amount_over, 0), " & _
                    "   2) AS overpay " & _
                    " FROM       cust_trtab_main INNER JOIN " & _
                    "    service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
                    "    GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
                    "    Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
                    "    GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
                    "    cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                    " WHERE (cust_trtab_main.AR_charge = 1)   " & IIf(Date1.Trim.Length = 0, "", " AND dbo.ChangeDate(Gl_receive_payment.date_receive_payment) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2))) & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                    " ORDER BY Gl_receive_payment.refrence_no "
        DAGeneral.Fill(DsFrmPrintARCus1.DetailPaySum)


        DAGeneral.SelectCommand.CommandText = " SELECT     ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS payment_amount, GL_payment_deposit.id_service_center,  " & _
                    "    GL_payment_deposit.ID_payment, Gl_receive_payment.refrence_no " & _
                    " FROM         cust_trtab_main INNER JOIN " & _
                    "    service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
                    "    GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
                    "    Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
                    "    GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
                    " WHERE (cust_trtab_main.AR_charge = 1)   " & IIf(Date1.Trim.Length = 0, "", " AND dbo.ChangeDate(Gl_receive_payment.date_receive_payment) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2))) & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                    " ORDER BY GL_payment_deposit.id_service_center "

        DAGeneral.Fill(DsFrmPrintARCus1.DetailPayDtl)
        'If Not (DSCus.Tables("customer") Is Nothing) Then
        '    For i As Integer = 0 To DsFrmPrintARCus1.CusARPayment.Count - 1
        '        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.CusARPayment(i).cod_customer)).Length > 0 Then
        '            DsFrmPrintARCus1.CusARPayment(i).FlagShow = 1
        '        End If
        '    Next
        'Else
        '    For i As Integer = 0 To DsFrmPrintARCus1.CusARPayment.Count - 1
        '        DsFrmPrintARCus1.CusARPayment(i).FlagShow = 1
        '    Next
        'End If

        'DsFrmPrintARCus1.CusARPayment.DefaultView.RowFilter = " FlagShow = true  "
        'GrdCusPaymentDetail.SetDataBinding(DsFrmPrintARCus1.CusARPayment.DefaultView, "")
        'GrdCusPaymentDetail.SetDataBinding(DsFrmPrintARCus1.CusARPaymen, "")
        GrdCusPaymentDetail.ExpandRecords(GrdCusPaymentDetail.RootTable.ChildTables(0))
        GrdCusPaymentDetail.BringToFront()

    End Sub
    Private Sub FillARCusPaySummery()
        Dim st As String
        st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")

        'DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '              " cust_company.complete_name+'' as complete_name, SUM(ROUND(ISNULL(Gl_receive_payment.amount_receive, 0), 2)) AS AMOUNT, COUNT(Gl_receive_payment.refrence_no) AS NoPay,1 as flag ,SUM(ROUND(ISNULL( Gl_receive_payment.OtherStoreAmount, 0), 2)) as other " & st & _
        '              " ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName,SUM(ROUND(ISNULL( Gl_receive_payment.amount_over, 0), 2)) as overpay " & _
        '              " FROM          cust_trtab_main INNER JOIN " & _
        '              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '              " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
        '              " GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
        '              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '              " WHERE (cust_trtab_main.AR_charge = 1) " & IIf(Date1.Trim.Length = 0, "", " AND dbo.ChangeDate(Gl_receive_payment.date_receive_payment) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2))) & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '              " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name "

        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                       " cust_company.complete_name + '' AS complete_name, SUM(ROUND(ISNULL(Gl_receive_payment.amount_receive, 0), 2)) AS AMOUNT,  " & _
                       " COUNT(Gl_receive_payment.refrence_no) AS NoPay, 1 AS flag, SUM(ROUND(ISNULL(Gl_receive_payment.OtherStoreAmount, 0), 2)) AS other,  " & _
                       " CASE WHEN cust_company.complete_name IS NULL  " & _
                       " THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                       " + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName,  " & _
                       " SUM(ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2)) AS overpay " & _
                       " FROM         cust_trtab_main INNER JOIN " & _
                       " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
                       " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                        " WHERE (cust_trtab_main.AR_charge = 1) " & IIf(Date1.Trim.Length = 0, "", " AND dbo.ChangeDate(Gl_receive_payment.date_receive_payment) between " & Qt(ChangeDateToYYYYMMDD(Date1)) & " and " & Qt(ChangeDateToYYYYMMDD(Date2))) & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                       " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name " & _
                       " ORDER BY OrderName "

        DAGeneral.Fill(DsFrmPrintARCus1.CusARPaymentSummery)

        'If Not (DSCus.Tables("customer") Is Nothing) Then
        '    For i As Integer = 0 To DsFrmPrintARCus1.CusARPaymentSummery.Count - 1
        '        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.CusARPaymentSummery(i).cod_customer)).Length > 0 Then
        '            DsFrmPrintARCus1.CusARPaymentSummery(i).FlagShow = 1
        '        End If
        '    Next
        '    'Else
        '    '    For i As Integer = 0 To DsFrmPrintARCus1.CusARPaymentSummery.Count - 1
        '    '        DsFrmPrintARCus1.CusARPaymentSummery(i).FlagShow = 1
        '    '    Next
        'End If

        'DsFrmPrintARCus1.CusARPaymentSummery.DefaultView.RowFilter = " FlagShow = true  "
        'GrdCusPaymentSummery.SetDataBinding(DsFrmPrintARCus1.CusARPaymentSummery.DefaultView, "")
        GrdCusPaymentSummery.SetDataBinding(DsFrmPrintARCus1.CusARPaymentSummery, "")
        GrdCusPaymentSummery.BringToFront()
    End Sub
    Private Sub FillARLedgerDetail()
        '''Dim st As String
        '''st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")

        ''''DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        ''''        " cust_company.complete_name+'' as complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id, " & _
        ''''        " service_center_head.Total AS charge, 0 AS credit,'' AS due, 1 AS flag " & st & _
        ''''        " FROM         cust_trtab_main INNER JOIN " & _
        ''''        " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer LEFT OUTER JOIN " & _
        ''''        " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''''        " WHERE     (service_center_head.type_of_form = 'IN') and (service_center_head.id_service_center in( SELECT     dbo.service_center_head.id_service_center " & _
        ''''        " FROM         service_center_head INNER JOIN " & _
        ''''        " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center " & _
        ''''        " where GL_payment_deposit.refer_type='1' and  GL_payment_deposit.payment_type ='4')) and cust_trtab_main.AR_charge = '1'" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        '''DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '''              " cust_company.complete_name+'' as complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2)  as charge, 0 AS credit,0 as adj,  GL_payment_AR.AR_due_date AS due, 1 AS flag, dbo.changedate(service_center_head.date_refer) AS OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,0 as ShowEmptyLine ,ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2) as Paid_amount " & st & _
        '''              " ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        '''              " FROM         cust_trtab_main INNER JOIN " & _
        '''              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '''              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '''              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        '''              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '''       " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
        '''       " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        '''DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)
        ''''If CmdGeneral.Connection.State = ConnectionState.Closed Then
        ''''    CmdGeneral.Connection.Open()
        ''''End If
        ''''Dim SQLReader As System.Data.SqlClient.SqlDataReader
        ''''SQLReader = CmdGeneral.ExecuteReader
        ''''If SQLReader.HasRows Then
        ''''    Do While SQLReader.Read()
        ''''        Try
        ''''            If DsFrmPrintARCus1.CusARLedgerDetail.FindByid(SQLReader.Item("id_service_center")).due = "" Then
        ''''                DsFrmPrintARCus1.CusARLedgerDetail.FindByid(SQLReader.Item("id_service_center")).due = SQLReader("AR_due_date")
        ''''            End If
        ''''        Catch ex As Exception
        ''''        End Try
        ''''    Loop
        ''''End If
        ''''CmdGeneral.Connection.Close()






        ''Try
        ''    DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        ''    "   cust_company.complete_name + '' AS complete_name, GL_account_adjustment_head.date_adjustment AS date,  " & _
        ''    " GL_account_adjustment_head.refrence_no AS id, 0 AS charge, 0 AS credit, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)  " & _
        ''    "  AS adj, '' AS due, 1 AS flag, dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        ''    "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ''    "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        ''    "  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other " & _
        ''    "  FROM         cust_trtab_main INNER JOIN " & _
        ''    "  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
        ''    "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''    " where  cust_trtab_main.AR_charge = '1'" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        ''    " union " & _
        ''    " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        ''    " cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id,  " & _
        ''    "  0 AS charge, 0 AS credit, 0 AS adj, '' AS due,  1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  CASE WHEN cust_company.complete_name IS NULL  " & _
        ''    "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ''    "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        ''    "  ,  0 AS Paid_amount,  0 AS Down, ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2) AS OVERPAID, 0 AS Other " & _
        ''    " FROM         cust_trtab_main INNER JOIN " & _
        ''    " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
        ''    " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''    " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        ''    DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)
        ''Catch ex As Exception

        ''    DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        ''                "   cust_company.complete_name + '' AS complete_name, GL_account_adjustment_head.date_adjustment AS date,  " & _
        ''                " GL_account_adjustment_head.refrence_no AS id, 0 AS charge, 0 AS credit, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)  " & _
        ''                "  AS adj, '' AS due, 1 AS flag, dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        ''                "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ''                "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        ''                "  ,0 as Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other " & _
        ''                "  FROM         cust_trtab_main INNER JOIN " & _
        ''                "  GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
        ''                "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''                " where  cust_trtab_main.AR_charge = '1' and ( dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) " & Mid(StrWhere, 50, StrWhere.Length - 45) & _
        ''                " union " & _
        ''                " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        ''                " cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id,  " & _
        ''                "  0 AS charge, 0 AS credit, 0 AS adj, '' AS due,  1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  CASE WHEN cust_company.complete_name IS NULL  " & _
        ''                "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ''                "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        ''                "  ,  0 AS Paid_amount,  0 AS Down, ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2) AS OVERPAID, 0 AS Other " & _
        ''                " FROM         cust_trtab_main INNER JOIN " & _
        ''                " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
        ''                " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''                " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1')  and ( dbo.ChangeDate(Gl_receive_payment.date_receive_payment) " & Mid(StrWhere, 50, StrWhere.Length - 45)


        ''    DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)
        ''End Try



        '''DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '''             " cust_company.complete_name+'' as complete_name, GL_account_adjustment_head.date_adjustment AS date, GL_account_adjustment_head.refrence_no AS id, 0 AS charge, " & _
        '''             " 0 AS credit, ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2) AS adj, '' AS due, 1 AS flag, dbo.changedate(GL_account_adjustment_head.date_adjustment) AS OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,0 as ShowEmptyLine " & st & _
        '''             " FROM         cust_trtab_main INNER JOIN " & _
        '''             " GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
        '''             " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '''             " where  cust_trtab_main.AR_charge = '1'" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        '''Try
        '''    'change by ketabi = kari nakardam , vali in chera injooooorie ????????
        '''    DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)

        '''Catch ex As Exception
        '''    DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '''                 " cust_company.complete_name+'' as complete_name, GL_account_adjustment_head.date_adjustment AS date, GL_account_adjustment_head.refrence_no AS id, 0 AS charge, " & _
        '''                 " 0 AS credit,ROUND(ISNULL( GL_account_adjustment_head.amount_adjustment, 0), 2) AS adj, '' AS due, 1 AS flag, dbo.changedate(GL_account_adjustment_head.date_adjustment) AS OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,0 as ShowEmptyLine " & st & _
        '''                 " FROM         cust_trtab_main INNER JOIN " & _
        '''                 " GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer LEFT OUTER JOIN " & _
        '''                 " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '''                 " where  cust_trtab_main.AR_charge = '1' and ( dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) " & Mid(StrWhere, 50, StrWhere.Length - 45)
        '''    DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)
        '''End Try


        '''DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        '''                      " cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id, " & _
        '''                      " 0 AS charge, 0 AS credit,0 as adj, 1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  " & _
        '''                      " LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name))  " & _
        '''                      " AS OrderName, 0 AS ShowEmptyLine, 0 AS Paid_amount, ROUND(ISNULL(Gl_receive_payment.amount_over,0),2) AS OVERPAID " & st & _
        '''                      " FROM         cust_trtab_main INNER JOIN " & _
        '''                      " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
        '''                      " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '''                      " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")
        '''Try
        '''    DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)

        '''Catch ex As Exception
        '''    DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        '''                         " cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, Gl_receive_payment.refrence_no AS id, " & _
        '''                         " 0 AS charge, 0 AS credit,0 as adj, 1 AS flag, dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate,  " & _
        '''                         " LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name))  " & _
        '''                         " AS OrderName, 0 AS ShowEmptyLine, 0 AS Paid_amount,ROUND(ISNULL( Gl_receive_payment.amount_over,0),2) AS OVERPAID " & st & _
        '''                         " FROM         cust_trtab_main INNER JOIN " & _
        '''                         " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer LEFT OUTER JOIN " & _
        '''                         " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '''                         " WHERE(Gl_receive_payment.amount_over > 0) and (cust_trtab_main.AR_charge = '1')  and ( dbo.ChangeDate(Gl_receive_payment.date_receive_payment) " & Mid(StrWhere, 50, StrWhere.Length - 45)

        '''    DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)
        '''End Try


        ''DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        ''"   cust_company.complete_name + '' AS complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,  " & _
        ''"   ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS charge, 0 AS credit, 0 AS adj, GL_payment_AR.AR_due_date AS due, 1 AS flag,  " & _
        ''"  dbo.ChangeDate(service_center_head.date_refer) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        ''"  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ''"  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, ROUND(ISNULL(GL_payment_deposit.Paid_amount,  " & _
        ''"  0), 2) AS Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other " & _
        ''"  FROM         cust_trtab_main INNER JOIN " & _
        ''"  service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        ''"  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        ''"  GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        ''"  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''" WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
        '' " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '' " union " & _
        '' " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '' "  cust_company.complete_name + '' AS complete_name, Gl_receive_payment.date_receive_payment AS date, GL_payment_deposit.refrence_no AS id,  " & _
        '' "  0 AS charge, ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS credit, 0 AS adj, '' AS due, 1 AS flag,  " & _
        '' "  dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        '' "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        '' "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, 0 AS Paid_amount, 0 AS Down, 0 AS OVERPAID,  " & _
        '' "  0 AS Other " & _
        '' " FROM         cust_trtab_main INNER JOIN " & _
        '' " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '' " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '' " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND  " & _
        '' "  GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
        '' "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '' " WHERE     (GL_payment_deposit.refer_type = '2')  and cust_trtab_main.AR_charge = '1' " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")



        '''DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '''              " cust_company.complete_name+'' as complete_name, Gl_receive_payment.date_receive_payment AS date, GL_payment_deposit.refrence_no AS id, 0 AS charge,  " & _
        '''              " ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS credit,0 as adj, '' AS due, 1 AS flag, dbo.changedate(Gl_receive_payment.date_receive_payment) AS OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,0 as ShowEmptyLine " & st & _
        '''              " FROM         cust_trtab_main INNER JOIN " & _
        '''              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '''              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '''              " Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer AND " & _
        '''              " GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no LEFT OUTER JOIN " & _
        '''              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '''              " WHERE     (GL_payment_deposit.refer_type = '2')  and cust_trtab_main.AR_charge = '1' " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        ''DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)




        '''DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '''             " cust_company.complete_name+'' as complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,0 as charge, 0 AS credit,0 as adj,ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) as Other,  GL_payment_AR.AR_due_date AS due, 1 AS flag, dbo.changedate(service_center_head.date_refer) AS OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,0 as ShowEmptyLine ,ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2) as Paid_amount " & st & _
        '''       " FROM         cust_trtab_main INNER JOIN " & _
        '''              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '''              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '''              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        '''              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '''       " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
        '''       " (GL_payment_deposit.refer_type = '3')  " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")




        ''DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        ''              " cust_company.complete_name + '' AS complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,  " & _
        ''              " 0 AS charge, 0 AS credit,0 as adj, 1 AS flag, dbo.ChangeDate(service_center_head.date_refer) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        ''              "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ''              "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName,   " & _
        ''              " 0 AS Paid_amount, ROUND(ISNULL(GL_Paid_received.amount,0),2) AS down, 0 AS OVERPAID, 0 AS Other " & _
        ''              " FROM         cust_trtab_main INNER JOIN" & _
        ''              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        ''              " GL_Paid_received ON cust_trtab_main.cod_customer = GL_Paid_received.customer_code AND  " & _
        ''              " service_center_head.id_service_center = GL_Paid_received.id_service_center LEFT OUTER JOIN " & _
        ''              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''              " WHERE     (GL_Paid_received.tran_type = '4')  and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        ''DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)



        ''DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        ''            " cust_company.complete_name+'' as complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,0  as charge, 0 AS credit,0 as adj,  1 AS flag, dbo.changedate(service_center_head.date_refer) AS OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,0 as ShowEmptyLine ,ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2) as Paid_amount,ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) as other " & _
        ''         " FROM         cust_trtab_main INNER JOIN " & _
        ''            " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        ''            " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
        ''            " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''            " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
        ''            " (GL_payment_deposit.refer_type = '3') and (cust_trtab_main.AR_charge = '1') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        ''DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerDetail)





        '''If Not (DSCus.Tables("customer") Is Nothing) Then
        '''    For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerDetail.Count - 1
        '''        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.CusARLedgerDetail(i).cod_customer)).Length > 0 Then
        '''            DsFrmPrintARCus1.CusARLedgerDetail(i).FlagShow = 1
        '''        End If
        '''    Next
        '''    'Else
        '''    '    For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerDetail.Count - 1
        '''    '        DsFrmPrintARCus1.CusARLedgerDetail(i).FlagShow = 1
        '''    '    Next

        '''End If

        '''If DsFrmPrintARCus1.CusARLedgerDetail.Count > 0 Then
        '''    For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerDetail.Count - 1
        '''        DsFrmPrintARCus1.CusARLedgerDetail(i).OrderName = IIf(Trim(DsFrmPrintARCus1.CusARLedgerDetail(i).Item("complete_name") & "").Length = 0, "zzzzz", DsFrmPrintARCus1.CusARLedgerDetail(i).item("complete_name") & "") & DsFrmPrintARCus1.CusARLedgerDetail(i).OrderName & "" & DsFrmPrintARCus1.CusARLedgerDetail(i).cod_customer
        '''        ''' ketabi : baraye in ke Adj null nabashad
        '''        If Val(DsFrmPrintARCus1.CusARLedgerDetail(i).item("adj") & "") = 0 Then
        '''            DsFrmPrintARCus1.CusARLedgerDetail(i).item("adj") = 0
        '''        End If
        '''    Next
        '''End If

        '''If DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Count > 0 Then
        '''    DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Sort = "OrderName,OrderDate"
        '''    Dim OldCustomerCode As String = DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Item(0).Item("cod_customer")
        '''    For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Count - 1
        '''        If OldCustomerCode = DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Item(i).Item("cod_customer") Then
        '''            DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Item(i).Item("ShowEmptyLine") = 0
        '''        Else
        '''            OldCustomerCode = DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Item(i).Item("cod_customer")
        '''            DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Item(i - 1).Item("ShowEmptyLine") = 1
        '''        End If
        '''    Next
        '''End If

        '''DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.Sort = ""
        '''DsFrmPrintARCus1.CusARLedgerDetail.DefaultView.RowFilter = " FlagShow = true  "
        '''For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerDetail1.Count
        '''    Dim dr As New  DataRow = DsFrmPrintARCus1.CusARLedgerDetail1(i)
        '''    DsFrmPrintARCus1.CusARLedgerDetail.AddCusARLedgerDetailRow(dr)
        '''Next
        GridEXPrintDocument1.PageHeaderCenter = Me.Text
        GrdcusLedgerDetail.SetDataBinding(DSCus.Tables("CusARLedgerDetail"), "")
        'GrdcusLedgerDetail.SetDataBinding(DsFrmPrintARCus1.CusARLedgerDetail, "")

        GrdcusLedgerDetail.BringToFront()
    End Sub
    Private Sub FillARLedgerSummery()

        'Dim st As String
        'st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")

        'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '            " cust_company.complete_name+'' as complete_name, 0 AS adj,0 AS credit, SUM(ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2))  as charge, 1 AS flag,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName " & st & _
        '      " FROM         cust_trtab_main INNER JOIN " & _
        '             " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '             " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '             " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        '             " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '      " WHERE     (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
        '      " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '      " GROUP BY  cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name  "

        'DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerSummery)


        'If DsFrmPrintARCus1.CusARLedgerSummery.Count = 0 Then
        '    Exit Sub
        'End If


        'For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerSummery.Count - 1
        '    DsFrmPrintARCus1.CusARLedgerSummery(i).OrderName = IIf(Trim(DsFrmPrintARCus1.CusARLedgerSummery(i).item("complete_name") & "").Length = 0, "zzzzz", DsFrmPrintARCus1.CusARLedgerSummery(i).item("complete_name") & "") & DsFrmPrintARCus1.CusARLedgerSummery(i).OrderName & DsFrmPrintARCus1.CusARLedgerSummery(i).cod_customer
        'Next

        ''change by ketabie 86/03/08 CmdGeneral.CommandText = " SELECT    sum(GL_payment_deposit.payment_amount)  as payment2,  cust_trtab_main.cod_customer as id " & _
        ''       " FROM         cust_trtab_main INNER JOIN " & _
        ''       " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        ''       " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        ''       " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment  " & _
        ''       " GROUP BY  cust_trtab_main.cod_customer "

        'CmdGeneral.CommandText = " SELECT    SUM(ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2))  as payment2,  cust_trtab_main.cod_customer as id " & _
        '       " FROM         cust_trtab_main INNER JOIN " & _
        '       " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '       " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center " & _
        '       " WHERE     (GL_payment_deposit.refer_type = '2')  and cust_trtab_main.AR_charge = '1' " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '       " GROUP BY  cust_trtab_main.cod_customer "

        '''DAAcount_AdjSummery.Fill(DsFrmPrintARCus1.Adjustment)
        ''DAGeneral.Fill(DsFrmPrintARCus1.Deposit2)

        'If CmdGeneral.Connection.State = ConnectionState.Closed Then
        '    CmdGeneral.Connection.Open()
        'End If
        'Dim SQLReader As System.Data.SqlClient.SqlDataReader
        'SQLReader = CmdGeneral.ExecuteReader
        'If SQLReader.HasRows Then
        '    Do While SQLReader.Read()
        '        Try
        '            DsFrmPrintARCus1.CusARLedgerSummery.FindBycod_customer(SQLReader.Item("id")).credit = SQLReader.Item("payment2")
        '        Catch ex As Exception
        '        End Try
        '    Loop
        'End If
        'CmdGeneral.Connection.Close()


        'CmdGeneral.CommandText = " SELECT     cust_trtab_main.cod_customer as id , SUM(ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)) AS adj " & _
        '      " FROM         cust_trtab_main INNER JOIN " & _
        '      " GL_account_adjustment_head ON cust_trtab_main.cod_customer = GL_account_adjustment_head.cod_customer  " & _
        '      " where  cust_trtab_main.AR_charge = '1' " & _
        '      " GROUP BY  cust_trtab_main.cod_customer "

        '''DAAcount_AdjSummery.Fill(DsFrmPrintARCus1.Adjustment)
        ''DAGeneral.Fill(DsFrmPrintARCus1.Deposit2)

        'If CmdGeneral.Connection.State = ConnectionState.Closed Then
        '    CmdGeneral.Connection.Open()
        'End If
        'SQLReader = CmdGeneral.ExecuteReader
        'If SQLReader.HasRows Then
        '    Do While SQLReader.Read()
        '        Try
        '            '   Change by ketabi  86/03/08  DsFrmPrintARCus1.CusARLedgerSummery.FindBycod_customer(SQLReader.Item("id")).credit = SQLReader.Item("adj")
        '            DsFrmPrintARCus1.CusARLedgerSummery.FindBycod_customer(SQLReader.Item("id")).adj = SQLReader.Item("adj")
        '        Catch ex As Exception
        '        End Try
        '    Loop
        'End If


        ''For i As Integer = 0 To DsFrmPrintARCus1.Deposit2.Count - 1
        ''    Try
        ''        DsFrmPrintARCus1.CusARLedgerSummery.FindBycod_customer(DsFrmPrintARCus1.Deposit2(i).id).credit = DsFrmPrintARCus1.Deposit2(i).payment2
        ''    Catch ex As Exception
        ''    End Try
        ''Next
        ''For i As Integer = 0 To DsFrmPrintARCus1.Adjustment.Count - 1
        ''    Try
        ''        DsFrmPrintARCus1.CusARLedgerSummery.FindBycod_customer(DsFrmPrintARCus1.Adjustment(i).id).adj = DsFrmPrintARCus1.Adjustment(i).adjustment
        ''    Catch ex As Exception
        ''    End Try
        ''Next

        'If Not (DSCus.Tables("customer") Is Nothing) Then
        '    For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerSummery.Count - 1
        '        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.CusARLedgerSummery(i).cod_customer)).Length > 0 Then
        '            DsFrmPrintARCus1.CusARLedgerSummery(i).FlagShow = 1
        '        End If
        '    Next
        '    'Else
        '    '    For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerSummery.Count - 1
        '    '        DsFrmPrintARCus1.CusARLedgerSummery(i).FlagShow = 1
        '    '    Next
        'End If
        'DsFrmPrintARCus1.CusARLedgerSummery.AcceptChanges()

        '   DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '          "  cust_company.complete_name + '' AS complete_name, sum(View_Customer_Total_Charge_Credit_adj.Adjustment) AS adj,  " & _
        '         "  sum(View_Customer_Total_Charge_Credit_adj.Credit) AS credit, sum(View_Customer_Total_Charge_Credit_adj.Charge) AS charge, 1 AS flag,  " & _
        '        "  LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name))  " & _
        '       "  AS OrderName, sum(View_Customer_Total_Charge_Credit_adj.DownPayment) as down, sum(View_Customer_Total_Charge_Credit_adj.OverPayment) as OVERPAID,  " & _
        '      "   sum(View_Customer_Total_Charge_Credit_adj.OtherStore) as other " & _
        '     " ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        '    " , SUM(View_Customer_Total_Charge_Credit_adj.Charge) - SUM(View_Customer_Total_Charge_Credit_adj.Credit) + SUM(View_Customer_Total_Charge_Credit_adj.Adjustment) AS Balance " & _
        '   "  FROM         View_Customer_Total_Charge_Credit_adj INNER JOIN " & _
        ''  "  cust_trtab_main ON View_Customer_Total_Charge_Credit_adj.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
        '"   cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '       "  WHERE    ( (View_Customer_Total_Charge_Credit_adj.Adjustment <> 0) AND (cust_trtab_main.AR_charge = '1') OR " & _
        '      " (View_Customer_Total_Charge_Credit_adj.Charge <> 0) AND (cust_trtab_main.AR_charge = '1') OR " & _
        '     "  (View_Customer_Total_Charge_Credit_adj.Credit <> 0) AND (cust_trtab_main.AR_charge = '1')) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '    "  GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name "

        'DAGeneral.Fill(DsFrmPrintARCus1.CusARLedgerSummery)

        'For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerSummery.Count - 1
        '    DsFrmPrintARCus1.CusARLedgerSummery(i).OrderName = IIf(Trim(DsFrmPrintARCus1.CusARLedgerSummery(i).Item("complete_name") & "").Length = 0, "zzzzz", DsFrmPrintARCus1.CusARLedgerSummery(i).Item("complete_name") & "") & DsFrmPrintARCus1.CusARLedgerSummery(i).OrderName & DsFrmPrintARCus1.CusARLedgerSummery(i).cod_customer
        'Next
        'For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerSummery.Count - 1
        '    DsFrmPrintARCus1.CusARLedgerSummery(i).Balance = (DsFrmPrintARCus1.CusARLedgerSummery(i).charge - DsFrmPrintARCus1.CusARLedgerSummery(i).credit) + DsFrmPrintARCus1.CusARLedgerSummery(i).adj
        'Next




        DsFrmARCusReport1.CusARLedgerSummery.Clear()

        Try
            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
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

            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
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

            DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
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


        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name ,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
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


        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
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
        DsFrmARCusReport1.CusARLedgerSummery.DefaultView.RowFilter = " FlagShow = true  "
        ' GrdcusLedgerSummery.SetDataBinding(DsFrmPrintARCus1.CusARLedgerSummery, "")
        GrdcusLedgerSummery.SetDataBinding(DsFrmARCusReport1.CusARLedgerSummery.DefaultView, "")
        GrdcusLedgerSummery.BringToFront()

    End Sub
    Private Sub FillDuePastDetail()

        'Dim st As String
        'st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")

        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, ROUND(ISNULL(service_center_head.Total, 0), 2) AS Total,  " & _
                  " cust_trtab_main.f_name ,cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                  " cust_company.complete_name + '' AS complete_name, service_center_head.date_refer, service_center_head.id_service_center,  " & _
                  " CASE WHEN phone_type_1 = 1 THEN phone_1 WHEN phone_type_2 = 1 THEN phone_2 WHEN phone_type_3 = 1 THEN phone_3 WHEN phone_type_4  " & _
                  " = 1 THEN phone_4 WHEN phone_type_5 = 1 THEN phone_5 ELSE '' END AS phone_1,  " & _
                  " CASE WHEN phone_type_1 = 2 THEN phone_1 WHEN phone_type_2 = 2 THEN phone_2 WHEN phone_type_3 = 2 THEN phone_3 WHEN  phone_type_4 " & _
                  " = 2 THEN phone_4 WHEN phone_type_5 = 2 THEN phone_5 ELSE '' END AS phone_2, cust_trtab_main.cust_notes, 0 AS payment4, 0 AS   payment2, 0 AS adjustment, " & _
                  " View_Total_Balance_ForEach_ARDue.AR_due_date AS due_date, DATEDIFF(day,View_Total_Balance_ForEach_ARDue.AR_due_date,GETDATE()) " & _
                  " AS days_past, 0 AS ar_term, View_Total_Balance_ForEach_ARDue.TotalArBalanceAmount AS payment_amount, 1 AS flag " & _
                  " ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                  " FROM         service_center_head INNER JOIN " & _
                  "  cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer INNER JOIN " & _
                  " View_Total_Balance_ForEach_ARDue ON  " & _
                  " service_center_head.id_service_center = View_Total_Balance_ForEach_ARDue.id_service_center LEFT OUTER JOIN " & _
                  " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                  " WHERE   (service_center_head.type_of_form = 'IN') and  DATEDIFF(day,View_Total_Balance_ForEach_ARDue.AR_due_date,GETDATE())>0 " & _
                  " and View_Total_Balance_ForEach_ARDue.TotalArBalanceAmount > 0 " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                  " order by OrderName "

        DAGeneral.Fill(DsFrmPrintARCus1.CusDuePastDetail)

        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, ROUND(ISNULL(service_center_head.Total, 0), 2) AS Total, " & _
        " cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        " cust_company.complete_name + '' AS complete_name, service_center_head.date_refer,  View_Adjustment_Balance.refrence_no_due AS id_service_center,  " & _
                  " CASE WHEN phone_type_1 = 1 THEN phone_1 WHEN phone_type_2 = 1 THEN phone_2 WHEN phone_type_3 = 1 THEN phone_3 WHEN phone_type_4 " & _
                  " = 1 THEN phone_4 WHEN phone_type_5 = 1 THEN phone_5 ELSE '' END AS phone_1,  " & _
                  " CASE WHEN phone_type_1 = 2 THEN phone_1 WHEN phone_type_2 = 2 THEN phone_2 WHEN phone_type_3 = 2 THEN phone_3 WHEN phone_type_4 " & _
                  " = 2 THEN phone_4 WHEN phone_type_5 = 2 THEN phone_5 ELSE '' END AS phone_2, cust_trtab_main.cust_notes, 0 AS payment4, 0 AS payment2,  " & _
                  " 0 AS adjustment, View_Adjustment_Balance.AR_due_date AS due_date, DATEDIFF(day, View_Adjustment_Balance.AR_due_date, GETDATE())  " & _
                  " AS days_past, 0 AS ar_term, View_Adjustment_Balance.BalanceAmount AS payment_amount, 1 AS flag,  " & _
                  " CASE WHEN cust_company.complete_name IS NULL  " & _
                  " THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                  " + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                  " FROM         service_center_head INNER JOIN " & _
                  " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer INNER JOIN " & _
                  " View_Adjustment_Balance ON service_center_head.id_service_center = View_Adjustment_Balance.id_service_center_due LEFT OUTER JOIN " & _
                  " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                  " WHERE     (service_center_head.type_of_form = 'INz') AND (View_Adjustment_Balance.BalanceAmount > 0) AND (DATEDIFF(day,  " & _
                  " View_Adjustment_Balance.AR_due_date, GETDATE()) > 0) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                  " ORDER BY OrderName "

        DAGeneral.Fill(DsFrmPrintARCus1.CusDuePastDetail)
        'DAGeneral.SelectCommand.CommandText = "  SELECT     cust_trtab_main.cod_customer, ROUND(ISNULL(service_center_head.Total, 0), 2), " & _
        '          "cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, cust_company.complete_name+'' as complete_name, " & _
        '          " service_center_head.date_refer, service_center_head.id_service_center, CASE WHEN phone_type_1 = 1 THEN phone_1 WHEN phone_type_2 = 1 " & _
        '          " THEN phone_2 WHEN phone_type_3 = 1 THEN phone_3 WHEN phone_type_4 = 1" & _
        '          " THEN phone_4 WHEN phone_type_5 = 1 THEN phone_5 ELSE '' END AS phone_1, " & _
        '          " CASE WHEN phone_type_1 = 2 THEN phone_1 WHEN phone_type_2 = 2 THEN phone_2 WHEN phone_type_3 = 2 THEN phone_3 WHEN phone_type_4= 2 " & _
        '          " THEN phone_4 WHEN phone_type_5 = 2 THEN phone_5 ELSE '' END AS phone_2, " & _
        '          " cust_trtab_main.cust_notes, 0 AS payment4, 0 AS payment2, 0 AS adjustment, 0 AS due_date, 0 AS days_past, 0 AS ar_term, 0 AS payment_amount,1 AS flag " & st & _
        '          " FROM         service_center_head INNER JOIN " & _
        '          " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
        '         " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '         " WHERE   (service_center_head.type_of_form = 'IN') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")
        'DAGeneral.Fill(DsFrmPrintARCus1.CusDuePastDetail)






        '''''due
        'DAGeneral.SelectCommand.CommandText = "SELECT     GL_payment_deposit.id_service_center AS id, SUM(ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2)) AS pay, " & _
        '              " GL_payment_AR.AR_due_date AS due, SUM(ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2)) AS paid, DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
        '              " FROM       service_center_head INNER JOIN " & _
        '            " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '             " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '            " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer " & _
        '            " WHERE     (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND (DATEDIFF(day, GL_payment_AR.AR_due_date,  " & _
        '              " GETDATE()) > 0) AND (GL_payment_deposit.payment_amount - GL_payment_deposit.Paid_amount <> 0) AND (GL_payment_AR.Cancel_flag = '0') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '              " GROUP BY GL_payment_deposit.id_service_center, GL_payment_AR.AR_due_date "

        'DsFrmPrintARCus1.PastDue.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)

        '''''adj+

        'DAGeneral.SelectCommand.CommandText = " SELECT     GL_account_adjustment_dtl.id_service_center as id, GL_account_adjustment_head.date_adjustment AS due, " & _
        '              " SUM(ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)) AS pay, 0 AS paid,DATEDIFF(day, GL_account_adjustment_head.date_adjustment, GETDATE()) AS days " & _
        '              " FROM         GL_account_adjustment_head INNER JOIN " & _
        '              " GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no  INNER JOIN " & _
        '              " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '              " WHERE     (GL_account_adjustment_head.amount_adjustment > 0) and  DATEDIFF(day, GL_account_adjustment_head.date_adjustment, GETDATE()) > 0  " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '               " GROUP BY   GL_account_adjustment_dtl.id_service_center,date_adjustment "

        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)
        '''''adj-

        ''DAGeneral.SelectCommand.CommandText = "SELECT     GL_account_adjustment_dtl.id_service_center as id, GL_payment_AR.AR_due_date AS due, " & _
        ''              " ROUND(ISNULL(SUM(GL_account_adjustment_dtl.amount_adjustment), 0), 2) AS pay,0 as paid, DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
        ''              " FROM         service_center_head INNER JOIN " & _
        ''              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        ''              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        ''              " GL_account_adjustment_dtl ON service_center_head.id_service_center = GL_account_adjustment_dtl.id_service_center INNER JOIN " & _
        ''              " GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_head.refrence_no " & _
        ''              " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND  " & _
        ''              " (GL_account_adjustment_head.amount_adjustment < 0) AND (DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) > 0) " & _
        ''              " GROUP BY GL_payment_AR.AR_due_date, GL_account_adjustment_dtl.id_service_center " & _
        ''          " ORDER BY GL_account_adjustment_dtl.id_service_center,DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) DESC"


        ''DAGeneral.Fill(DsFrmPrintARCus1.PastDue)

        'For i As Integer = 0 To DsFrmPrintARCus1.PastDue.Count - 1
        '    Try
        '        If DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past <> "0" Then
        '            If DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past < DsFrmPrintARCus1.PastDue(i).days Then
        '                DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).due_date = DsFrmPrintARCus1.PastDue(i).due
        '                'DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = SQLReader("AR_terms")
        '                DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days
        '            End If
        '        Else
        '            DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).due_date = DsFrmPrintARCus1.PastDue(i).due
        '            'DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = SQLReader("AR_terms")
        '            DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days

        '        End If
        '        DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount + DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)
        '    Catch ex As Exception

        '    End Try

        'Next


        'DAGeneral.SelectCommand.CommandText = "SELECT     GL_account_adjustment_dtl.id_service_center as id, GL_payment_AR.AR_due_date AS due, " & _
        '             " SUM(ROUND(ISNULL(GL_account_adjustment_dtl.amount_adjustment, 0), 2)) AS pay,0 as paid, DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) AS days, GL_account_adjustment_dtl.refrence_no as id2 " & _
        '             " from      service_center_head INNER JOIN " & _
        '             "  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '              " GL_account_adjustment_dtl ON service_center_head.id_service_center = GL_account_adjustment_dtl.id_service_center INNER JOIN  " & _
        '              " GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_head.refrence_no INNER JOIN " & _
        '              " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '               " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND  " & _
        '             " (GL_account_adjustment_head.amount_adjustment < 0) AND (DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) > 0) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '             " GROUP BY GL_payment_AR.AR_due_date, GL_account_adjustment_dtl.id_service_center, GL_account_adjustment_dtl.refrence_no " & _
        '         " ORDER BY GL_account_adjustment_dtl.refrence_no ,GL_account_adjustment_dtl.id_service_center,DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) DESC"


        'DsFrmPrintARCus1.PastDue.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)

        'Dim Id As String = ""
        'Dim Id2 As String = ""

        'For i As Integer = 0 To DsFrmPrintARCus1.PastDue.Count - 1
        '    If DsFrmPrintARCus1.PastDue(i).id <> Id And DsFrmPrintARCus1.PastDue(i).id2 <> Id2 Then
        '        Id = DsFrmPrintARCus1.PastDue(i).id
        '        Id2 = DsFrmPrintARCus1.PastDue(i).id2
        '        Try

        '            If DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past <> "0" Then
        '                If DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past < DsFrmPrintARCus1.PastDue(i).days Then
        '                    DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).due_date = DsFrmPrintARCus1.PastDue(i).due
        '                    'DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = SQLReader("AR_terms")
        '                    DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days
        '                End If
        '            Else
        '                DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).due_date = DsFrmPrintARCus1.PastDue(i).due
        '                'DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).ar_term = SQLReader("AR_terms")
        '                DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).days_past = DsFrmPrintARCus1.PastDue(i).days

        '            End If
        '            DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusDuePastDetail.FindByid_service_center(DsFrmPrintARCus1.PastDue(i).id).payment_amount + DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)
        '        Catch ex As Exception

        '        End Try

        '    End If

        'Next



        'For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastDetail.Count - 1
        '    'change by ketabi If Not (DsFrmPrintARCus1.CusDuePastDetail(i).days_past < 0) Then
        '    If DsFrmPrintARCus1.CusDuePastDetail(i).payment_amount = 0 Then
        '        DsFrmPrintARCus1.CusDuePastDetail(i).Delete()
        '    End If
        'Next
        DsFrmPrintARCus1.CusDuePastDetail.AcceptChanges()
        'If Not (DSCus.Tables("customer") Is Nothing) Then
        '    For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastDetail.Count - 1
        '        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.CusDuePastDetail(i).cod_customer)).Length > 0 Then
        '            DsFrmPrintARCus1.CusDuePastDetail(i).FlagShow = 1
        '        End If
        '    Next
        '    'Else
        '    '    For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastDetail.Count - 1
        '    '        DsFrmPrintARCus1.CusDuePastDetail(i).FlagShow = 1
        '    '    Next
        'End If

        'DsFrmPrintARCus1.CusDuePastDetail.DefaultView.RowFilter = " FlagShow = true  "
        GrdPastDueDetail.SetDataBinding(DsFrmPrintARCus1.CusDuePastDetail, "")


        GrdPastDueDetail.BringToFront()

    End Sub
    Private Sub FillDuePastSummery()

        'Dim st As String
        'st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")
        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                  "  cust_company.complete_name + '' AS complete_name, 0 AS payment4, 0 AS payment2, 0 AS adjustment,  " & _
                  " SUM(ROUND(ISNULL(View_Total_Balance_ForEach_ARDue.TotalArBalanceAmount, 0), 2)) AS payment_amount, 1 AS flag,  " & _
                  "  CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
                  " = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1 " & _
                  " ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                  "  FROM            cust_trtab_main INNER JOIN " & _
                  " View_Total_Balance_ForEach_ARDue ON cust_trtab_main.cod_customer = View_Total_Balance_ForEach_ARDue.cod_customer LEFT OUTER JOIN " & _
                  " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                  "  WHERE   (DATEDIFF(day, View_Total_Balance_ForEach_ARDue.AR_due_date, GETDATE()) > 0) AND  " & _
                  "  (View_Total_Balance_ForEach_ARDue.TotalArBalanceAmount > 0) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                  "  GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name,  " & _
                  "  cust_trtab_main.phone_main_1, cust_trtab_main.phone_1, cust_trtab_main.phone_main_2, cust_trtab_main.phone_2, cust_trtab_main.phone_main_3, " & _
                  " cust_trtab_main.phone_3, cust_trtab_main.phone_main_4, cust_trtab_main.phone_4, cust_trtab_main.phone_main_5, cust_trtab_main.phone_5 " & _
                  " order by OrderName "

        DAGeneral.Fill(DsFrmPrintARCus1.CusDuePastSummery)

        'DAGeneral.SelectCommand.CommandText = "SELECT   cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '          " cust_company.complete_name+'' as complete_name, 0 AS payment4, 0 AS payment2, 0 AS adjustment, 0 AS payment_amount, 1 AS flag,CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
        '          " = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1 " & st & _
        '          " FROM         cust_trtab_main INNER JOIN " & _
        '          " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer LEFT OUTER JOIN " & _
        '          " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '          " WHERE (service_center_head.type_of_form = 'IN') " & IIf(StrWhere.Trim.Length > 0, " And " & StrWhere, "") & _
        '          " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name,  " & _
        '          " phone_main_1, phone_1,phone_main_2 , phone_2 , phone_main_3 , phone_3 , phone_main_4, phone_4,phone_main_5, phone_5 "

        'DAGeneral.Fill(DsFrmPrintARCus1.CusDuePastSummery)



        'DAGeneral.SelectCommand.CommandText = "SELECT     service_center_head.cod_customer as id, ROUND(ISNULL(SUM(GL_payment_deposit.payment_amount), 0), 2) AS pay, " & _
        '             " GL_payment_AR.AR_due_date AS due,SUM(ROUND(ISNULL( GL_payment_deposit.Paid_amount, 0), 2)) AS paid, DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
        '             " FROM       service_center_head INNER JOIN " & _
        '            " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '             " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '            " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer " & _
        '            " WHERE     (service_center_head.type_of_form = 'IN') AND  " & _
        '            " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') and  DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) > 0" & IIf(StrWhere.Trim.Length > 0, " And " & StrWhere, "") & _
        '            " GROUP BY service_center_head.cod_customer, GL_payment_AR.AR_due_date "

        'DsFrmPrintARCus1.AgingDetail.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)

        'DAGeneral.SelectCommand.CommandText = " SELECT  GL_account_adjustment_head.cod_customer as id,   GL_account_adjustment_head.date_adjustment AS due, SUM(ROUND(ISNULL( GL_account_adjustment_head.amount_adjustment , 0), 2))AS pay,0 as paid " & _
        '             " ,DATEDIFF(day, GL_account_adjustment_head.date_adjustment, GETDATE()) AS days  " & _
        '              " FROM         GL_account_adjustment_head INNER JOIN " & _
        '              " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '             " where GL_account_adjustment_head.amount_adjustment > 0  and DATEDIFF(day, date_adjustment, GETDATE()) > 0 " & IIf(StrWhere.Trim.Length > 0, " And " & StrWhere, "") & _
        '             " GROUP BY  GL_account_adjustment_head.cod_customer,GL_account_adjustment_head.date_adjustment "

        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)


        'DAGeneral.SelectCommand.CommandText = "SELECT   DISTINCT  service_center_head.cod_customer as id,  GL_account_adjustment_head.refrence_no AS due,ROUND(ISNULL( GL_account_adjustment_dtl.amount_adjustment, 0), 2) AS pay,0 as paid ,service_center_head.id_service_center as id2 " & _
        '                      " from      service_center_head INNER JOIN " & _
        '             "  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '              " GL_account_adjustment_dtl ON service_center_head.id_service_center = GL_account_adjustment_dtl.id_service_center INNER JOIN  " & _
        '              " GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_head.refrence_no INNER JOIN " & _
        '              " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '              " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') and GL_account_adjustment_head.amount_adjustment < 0 " & _
        '              " and DATEDIFF(day, GL_payment_AR.AR_due_date, GETDATE()) > 0 " & IIf(StrWhere.Trim.Length > 0, " And " & StrWhere, "")

        'DAGeneral.Fill(DsFrmPrintARCus1.PastDue)


        'For I As Integer = 0 To DsFrmPrintARCus1.PastDue.Count - 1
        '    Try
        '        DsFrmPrintARCus1.CusDuePastSummery.FindBycod_customer(DsFrmPrintARCus1.PastDue(i).id).payment_amount = Math.Round(DsFrmPrintARCus1.CusDuePastSummery.FindBycod_customer(DsFrmPrintARCus1.PastDue(i).id).payment_amount + DsFrmPrintARCus1.PastDue(i).pay - DsFrmPrintARCus1.PastDue(i).paid, 2)
        '    Catch ex As Exception

        '    End Try

        'Next





        'For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastSummery.Count - 1
        '    'DsFrmPrintARCus1.CusDuePastSummery(i).debt = DsFrmPrintARCus1.CusDuePastSummery(i).payment4 - DsFrmPrintARCus1.CusDuePastSummery(i).payment2
        '    ' change by ketabi If Not (DsFrmPrintARCus1.CusDuePastSummery(i).payment_amount > 0) Then
        '    If (DsFrmPrintARCus1.CusDuePastSummery(i).payment_amount = 0) Then
        '        DsFrmPrintARCus1.CusDuePastSummery(i).Delete()
        '    End If
        'Next

        'DsFrmPrintARCus1.CusDuePastSummery.AcceptChanges()


        CmdGeneral.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                   " cust_company.complete_name + '' AS complete_name, 0 AS payment4, 0 AS payment2, 0 AS adjustment, " & _
                   " SUM(ROUND(ISNULL(View_Adjustment_Balance.BalanceAmount, 0), 2)) AS payment_amount, 1 AS flag,  " & _
                   " CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
                   "  = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1, CASE WHEN cust_company.complete_name IS NULL  " & _
                   "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                   " + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                   " FROM         cust_trtab_main INNER JOIN " & _
                   "  View_Adjustment_Balance ON cust_trtab_main.cod_customer = View_Adjustment_Balance.cod_customer LEFT OUTER JOIN " & _
                   "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                   " WHERE     (View_Adjustment_Balance.BalanceAmount > 0) AND (DATEDIFF(day, View_Adjustment_Balance.AR_due_date, GETDATE()) > 0) " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
                   " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name,  " & _
                   "  cust_trtab_main.phone_main_1, cust_trtab_main.phone_1, cust_trtab_main.phone_main_2, cust_trtab_main.phone_2, cust_trtab_main.phone_main_3,  " & _
                   "  cust_trtab_main.phone_3, cust_trtab_main.phone_main_4, cust_trtab_main.phone_4, cust_trtab_main.phone_main_5, cust_trtab_main.phone_5 " & _
                   " ORDER BY OrderName "

        If CmdGeneral.Connection.State = ConnectionState.Closed Then
            CmdGeneral.Connection.Open()
        End If
        Dim SQLReader1 As System.Data.SqlClient.SqlDataReader = CmdGeneral.ExecuteReader
        If SQLReader1.HasRows Then
            Do While SQLReader1.Read()
                Try
                    DsFrmPrintARCus1.CusDuePastSummery.FindBycod_customer(SQLReader1.Item("cod_customer")).payment_amount = DsFrmPrintARCus1.CusDuePastSummery.FindBycod_customer(SQLReader1.Item("cod_customer")).payment_amount + SQLReader1("payment_amount")
                Catch ex As Exception
                    Dim dr As DataRow = DsFrmPrintARCus1.CusDuePastSummery.NewCusDuePastSummeryRow
                    dr("cod_customer") = SQLReader1.Item("cod_customer")
                    dr("name") = SQLReader1.Item("name")
                    dr("f_name") = SQLReader1.Item("f_name")
                    dr("complete_name") = SQLReader1.Item("complete_name")
                    dr("payment_amount") = SQLReader1.Item("payment_amount")
                    dr("flag") = SQLReader1.Item("flag")
                    dr("phone_1") = SQLReader1.Item("phone_1")
                    dr("OrderName") = SQLReader1.Item("OrderName")
                    DsFrmPrintARCus1.CusDuePastSummery.AddCusDuePastSummeryRow(dr)
                End Try
            Loop
        End If

        CmdGeneral.Connection.Close()

        CmdGeneral.CommandText = "SELECT     cod_customer AS id, date_receive_payment, amount_receive " & _
           " FROM Gl_receive_payment " & _
           " GROUP BY cod_customer, date_receive_payment ,amount_receive" & _
           " ORDER BY cod_customer, dbo.ChangeDate(date_receive_payment)  "
        If CmdGeneral.Connection.State = ConnectionState.Closed Then
            CmdGeneral.Connection.Open()
        End If

        Dim SQLReader As System.Data.SqlClient.SqlDataReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.CusDuePastSummery.FindBycod_customer(SQLReader.Item("id")).last_pay = SQLReader("date_receive_payment")
                    DsFrmPrintARCus1.CusDuePastSummery.FindBycod_customer(SQLReader.Item("id")).amount_receive = SQLReader("amount_receive")
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdGeneral.Connection.Close()
        DsFrmPrintARCus1.CusDuePastSummery.AcceptChanges()
        'If Not (DSCus.Tables("customer") Is Nothing) Then
        '    For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastSummery.Count - 1
        '        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.CusDuePastSummery(i).cod_customer)).Length > 0 Then
        '            DsFrmPrintARCus1.CusDuePastSummery(i).FlagShow = 1
        '        End If
        '    Next
        '    'Else
        '    '    For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastSummery.Count - 1
        '    '        DsFrmPrintARCus1.CusDuePastSummery(i).FlagShow = 1
        '    '    Next
        'End If

        'DsFrmPrintARCus1.CusDuePastSummery.DefaultView.RowFilter = " FlagShow = true  "
        GrdPastDueSummery.SetDataBinding(DsFrmPrintARCus1.CusDuePastSummery, "")


        GrdPastDueSummery.BringToFront()
    End Sub
    Private Sub FillAgingDetail2()


        'Dim st As String
        'st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")


        DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , ltrim(rtrim(cust_trtab_main.m_name)) + ' ' + cust_trtab_main.l_name AS name   " & _
                                              " ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName  ," & _
                                        " View_Customer_Balance.BalanceAmount,  0 as credit ,ROUND(ISNULL(service_center_head.credit, 0), 2) as charge ,cust_company.complete_name+'' as complete_name,1 as flag " & _
                                        " FROM         cust_trtab_main INNER JOIN " & _
                                            " View_Customer_Balance ON cust_trtab_main.cod_customer = View_Customer_Balance.cod_customer LEFT OUTER JOIN " & _
                                                " (SELECT     SUM(GL_payment_deposit.payment_amount) AS credit, service_center_head.cod_customer " & _
                                                    " FROM         GL_payment_deposit INNER JOIN " & _
                                                        " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                                                    " WHERE     (GL_payment_deposit.refer_type = '1') " & _
                                                    " GROUP BY service_center_head.cod_customer) service_center_head ON  " & _
                                            " cust_trtab_main.cod_customer = service_center_head.cod_customer LEFT OUTER JOIN " & _
                                            " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                                            " where (cust_trtab_main.AR_charge = 1) and View_Customer_Balance.BalanceAmount <> 0 and service_center_head.credit <> 0 " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        DAGeneral.Fill(DsFrmPrintARCus1.Aging)


        If CmdC1.Connection.State = ConnectionState.Closed Then
            CmdC1.Connection.Open()
        End If
        CmdC1.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC1.Parameters("@Flag").Value = "1"

        Dim SQLReader As System.Data.SqlClient.SqlDataReader

        SQLReader = CmdC1.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging.FindBycod_customer(SQLReader.Item("COD_CUSTOMER")).c1 = SQLReader("BalanceAmount")
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC1.Connection.Close()
        '''''''''''''''''''
        If CmdC2.Connection.State = ConnectionState.Closed Then
            CmdC2.Connection.Open()
        End If
        CmdC2.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC2.Parameters("@Flag").Value = "1"

        SQLReader = CmdC2.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging.FindBycod_customer(SQLReader.Item("COD_CUSTOMER")).c2 = SQLReader("BalanceAmount")
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC2.Connection.Close()
        ''''''''''''''
        If CmdC3.Connection.State = ConnectionState.Closed Then
            CmdC3.Connection.Open()
        End If
        CmdC3.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC3.Parameters("@Flag").Value = "1"

        SQLReader = CmdC3.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging.FindBycod_customer(SQLReader.Item("COD_CUSTOMER")).c3 = SQLReader("BalanceAmount")
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC3.Connection.Close()
        ''''''''
        If CmdC4.Connection.State = ConnectionState.Closed Then
            CmdC4.Connection.Open()
        End If
        CmdC4.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC4.Parameters("@Flag").Value = "1"
        SQLReader = CmdC4.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging.FindBycod_customer(SQLReader.Item("COD_CUSTOMER")).c4 = SQLReader("BalanceAmount")
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC4.Connection.Close()
        '''''''''''
        If CmdC5.Connection.State = ConnectionState.Closed Then
            CmdC5.Connection.Open()
        End If
        CmdC5.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC5.Parameters("@Flag").Value = "1"

        SQLReader = CmdC5.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging.FindBycod_customer(SQLReader.Item("COD_CUSTOMER")).c5 = SQLReader("BalanceAmount")
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC5.Connection.Close()


        For i As Int16 = 0 To DsFrmPrintARCus1.Aging.Count - 1
            DsFrmPrintARCus1.Aging(i).credit = DsFrmPrintARCus1.Aging(i).charge - DsFrmPrintARCus1.Aging(i).BalanceAmount
        Next

        'DAGeneral.SelectCommand.CommandText = "SELECT     service_center_head.cod_customer, ROUND(ISNULL(SUM(GL_payment_deposit.payment_amount), 0), 2) AS pay, " & _
        '             " GL_payment_AR.AR_due_date AS due,SUM(ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2)) AS paid " & _
        '            " FROM       service_center_head INNER JOIN " & _
        '            " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '             " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '            " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer " & _
        '             " WHERE     (service_center_head.type_of_form = 'IN') AND  " & _
        '            " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " And " & StrWhere, "") & _
        '            " GROUP BY service_center_head.cod_customer, GL_payment_AR.AR_due_date "

        'DsFrmPrintARCus1.AgingDetail.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.AgingDetail)

        'DAGeneral.SelectCommand.CommandText = " SELECT  GL_account_adjustment_head.cod_customer,   GL_account_adjustment_head.date_adjustment AS due,  SUM(ROUND(ISNULL(GL_account_adjustment_head.amount_adjustment, 0), 2)) AS pay,0 as paid " & _
        '              " FROM         GL_account_adjustment_head INNER JOIN " & _
        '              " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '              " where GL_account_adjustment_head.amount_adjustment > 0  " & IIf(StrWhere.Trim.Length > 0, " And " & StrWhere, "") & _
        '     " GROUP BY  GL_account_adjustment_head.cod_customer,GL_account_adjustment_head.date_adjustment "

        'DAGeneral.Fill(DsFrmPrintARCus1.AgingDetail)


        'For i As Int16 = 0 To DsFrmPrintARCus1.Aging.Count - 1
        '    DsFrmPrintARCus1.AgingDetail.DefaultView.RowFilter = "cod_customer = " & Qt(DsFrmPrintARCus1.Aging(i).cod_customer)
        '    For j As Integer = 0 To DsFrmPrintARCus1.AgingDetail.DefaultView.Count - 1

        '        Select Case DateDiff(DateInterval.Day, DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("due"), Now())
        '            Case Is < 1
        '                DsFrmPrintARCus1.Aging(i).c1 = DsFrmPrintARCus1.Aging(i).c1 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay") - DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("paid")

        '            Case Is < 31
        '                DsFrmPrintARCus1.Aging(i).c2 = DsFrmPrintARCus1.Aging(i).c2 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay") - DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("paid")

        '            Case Is < 61
        '                DsFrmPrintARCus1.Aging(i).c3 = DsFrmPrintARCus1.Aging(i).c3 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay") - DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("paid")

        '            Case Is < 91
        '                DsFrmPrintARCus1.Aging(i).c4 = DsFrmPrintARCus1.Aging(i).c4 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay") - DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("paid")

        '            Case Else
        '                DsFrmPrintARCus1.Aging(i).c5 = DsFrmPrintARCus1.Aging(i).c5 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay") - DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("paid")
        '        End Select

        '    Next

        '    'DsFrmPrintARCus1.Aging(i).credit = DsFrmPrintARCus1.Aging(i).charge - DsFrmPrintARCus1.Aging(i).BalanceAmount
        'Next



        'DAGeneral.SelectCommand.CommandText = "SELECT    service_center_head.cod_customer,  GL_payment_AR.AR_due_date AS due, ROUND(ISNULL(GL_account_adjustment_dtl.amount_adjustment, 0), 2) AS pay " & _
        '             " , GL_account_adjustment_dtl.refrence_no as id1 , GL_account_adjustment_dtl.id_service_center  as id2 " & _
        '             " from      service_center_head INNER JOIN " & _
        '             "  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '             " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '             " GL_account_adjustment_dtl ON service_center_head.id_service_center = GL_account_adjustment_dtl.id_service_center INNER JOIN  " & _
        '             " GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_head.refrence_no INNER JOIN " & _
        '             " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '             " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') and GL_account_adjustment_head.amount_adjustment < 0 " & IIf(StrWhere.Trim.Length > 0, " And " & StrWhere, "") & _
        '             " order by  GL_account_adjustment_dtl.refrence_no , GL_account_adjustment_dtl.id_service_center   "



        'DsFrmPrintARCus1.AgingDetail.Clear()

        'DAGeneral.Fill(DsFrmPrintARCus1.AgingDetail)

        'Dim ID1 As String = ""
        'Dim ID2 As String = ""


        'For i As Int16 = 0 To DsFrmPrintARCus1.Aging.Count - 1

        '    DsFrmPrintARCus1.AgingDetail.DefaultView.RowFilter = "cod_customer = " & Qt(DsFrmPrintARCus1.Aging(i).cod_customer)
        '    For j As Integer = 0 To DsFrmPrintARCus1.AgingDetail.DefaultView.Count - 1
        '        If DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("id2") <> ID2 And DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("id1") <> ID1 Then
        '            ID2 = DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("id2")
        '            ID1 = DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("id1")
        '            Select Case DateDiff(DateInterval.Day, DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("due"), Now())
        '                Case Is < 1
        '                    DsFrmPrintARCus1.Aging(i).c1 = Math.Round(DsFrmPrintARCus1.Aging(i).c1 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay"), 2)

        '                Case Is < 31
        '                    DsFrmPrintARCus1.Aging(i).c2 = Math.Round(DsFrmPrintARCus1.Aging(i).c1 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay"), 2)

        '                Case Is < 61
        '                    DsFrmPrintARCus1.Aging(i).c3 = Math.Round(DsFrmPrintARCus1.Aging(i).c1 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay"), 2)

        '                Case Is < 91
        '                    DsFrmPrintARCus1.Aging(i).c4 = Math.Round(DsFrmPrintARCus1.Aging(i).c1 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay"), 2)

        '                Case Else
        '                    DsFrmPrintARCus1.Aging(i).c5 = Math.Round(DsFrmPrintARCus1.Aging(i).c1 + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay"), 2)

        '            End Select
        '            If DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay") > 0 Then
        '                DsFrmPrintARCus1.Aging(i).charge = DsFrmPrintARCus1.Aging(i).charge + DsFrmPrintARCus1.AgingDetail.DefaultView(j).Item("pay")
        '            End If
        '        End If


        '    Next
        '    DsFrmPrintARCus1.Aging(i).credit = DsFrmPrintARCus1.Aging(i).charge - DsFrmPrintARCus1.Aging(i).BalanceAmount

        'Next

        'If Not (DSCus.Tables("customer") Is Nothing) Then
        '    For i As Integer = 0 To DsFrmPrintARCus1.Aging.Count - 1
        '        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.Aging(i).cod_customer)).Length > 0 Then
        '            DsFrmPrintARCus1.Aging(i).FlagShow = 1
        '        End If
        '    Next
        'End If
        'DsFrmPrintARCus1.Aging.DefaultView.RowFilter = " FlagShow = true  "
        GrdAging.SetDataBinding(DsFrmPrintARCus1.Aging, "")


        DsFrmPrintARCus1.Aging.AcceptChanges()

        GrdAging.BringToFront()
    End Sub

    Private Sub FillAgingSummery2()


        'Dim st As String
        'st = IIf(Not (DSCus.Tables("customer") Is Nothing), ",0 as FlagShow ", ",1 as FlagShow ")

        DAGeneral.SelectCommand.CommandText = "SELECT 1 as cod_customer,SUM(ROUND(ISNULL( View_Customer_Balance.BalanceAmount, 0), 2)) as BalanceAmount, 0 as credit,SUM(ROUND(ISNULL(service_center_head.credit, 0), 2)) as charge, 1 as flag " & _
                         " FROM         cust_trtab_main INNER JOIN " & _
                             " View_Customer_Balance ON cust_trtab_main.cod_customer = View_Customer_Balance.cod_customer LEFT OUTER JOIN " & _
                                 " (SELECT     SUM(GL_payment_deposit.payment_amount) AS credit, service_center_head.cod_customer " & _
                                    " FROM         GL_payment_deposit INNER JOIN " & _
                                         " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                                    " WHERE     (GL_payment_deposit.refer_type = '1') " & _
                                    " GROUP BY service_center_head.cod_customer) service_center_head ON  " & _
                             " cust_trtab_main.cod_customer = service_center_head.cod_customer  " & _
                            " where  (cust_trtab_main.AR_charge = 1) AND (View_Customer_Balance.BalanceAmount <> 0) AND (service_center_head.credit <> 0) " & IIf(StrWhere.Trim.Length > 0, " and  " & StrWhere, "")

        DAGeneral.Fill(DsFrmPrintARCus1.Aging)

        DsFrmPrintARCus1.Aging(0).c1 = 0
        DsFrmPrintARCus1.Aging(0).c2 = 0
        DsFrmPrintARCus1.Aging(0).c3 = 0
        DsFrmPrintARCus1.Aging(0).c4 = 0
        DsFrmPrintARCus1.Aging(0).c5 = 0

        If CmdC1.Connection.State = ConnectionState.Closed Then
            CmdC1.Connection.Open()
        End If

        CmdC1.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC1.Parameters("@Flag").Value = "1"

        Dim SQLReader As System.Data.SqlClient.SqlDataReader

        SQLReader = CmdC1.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging(0).c1 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + SQLReader("BalanceAmount"), 2)
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC1.Connection.Close()
        '''''''''''''''''''
        If CmdC2.Connection.State = ConnectionState.Closed Then
            CmdC2.Connection.Open()
        End If
        CmdC2.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC2.Parameters("@Flag").Value = "1"

        SQLReader = CmdC2.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging(0).c2 = Math.Round(DsFrmPrintARCus1.Aging(0).c2 + SQLReader("BalanceAmount"), 2)
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC2.Connection.Close()
        ''''''''''''''
        If CmdC3.Connection.State = ConnectionState.Closed Then
            CmdC3.Connection.Open()
        End If
        CmdC3.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC3.Parameters("@Flag").Value = "1"

        SQLReader = CmdC3.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging(0).c3 = Math.Round(DsFrmPrintARCus1.Aging(0).c3 + SQLReader("BalanceAmount"), 2)
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC3.Connection.Close()
        ''''''''
        If CmdC4.Connection.State = ConnectionState.Closed Then
            CmdC4.Connection.Open()
        End If
        CmdC4.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC4.Parameters("@Flag").Value = "1"
        SQLReader = CmdC4.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging(0).c4 = Math.Round(DsFrmPrintARCus1.Aging(0).c4 + SQLReader("BalanceAmount"), 2)
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC4.Connection.Close()
        '''''''''''
        If CmdC5.Connection.State = ConnectionState.Closed Then
            CmdC5.Connection.Open()
        End If
        CmdC5.Parameters("@ThisDate").Value = Format(Now(), "yyyy/MM/dd")
        CmdC5.Parameters("@Flag").Value = "1"

        SQLReader = CmdC5.ExecuteReader
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Try
                    DsFrmPrintARCus1.Aging(0).c5 = Math.Round(DsFrmPrintARCus1.Aging(0).c5 + SQLReader("BalanceAmount"), 2)
                Catch ex As Exception
                End Try
            Loop
        End If

        CmdC5.Connection.Close()



        'DAGeneral.SelectCommand.CommandText = "SELECT      1  AS cod_customer, SUM(ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2)) AS pay, " & _
        '             " GL_payment_AR.AR_due_date AS due, SUM(ROUND(ISNULL(GL_payment_deposit.Paid_amount, 0), 2)) AS paid " & _
        '             " FROM       service_center_head INNER JOIN " & _
        '            " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '             " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '            " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer " & _
        '            " WHERE     (service_center_head.type_of_form = 'IN') AND  " & _
        '            " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " and  " & StrWhere, "") & _
        '            " GROUP BY  GL_payment_AR.AR_due_date "

        'DsFrmPrintARCus1.AgingDetail.Clear()
        'DAGeneral.Fill(DsFrmPrintARCus1.AgingDetail)

        'DAGeneral.SelectCommand.CommandText = " SELECT   1  AS cod_customer,   date_adjustment AS due,  SUM(ROUND(ISNULL(amount_adjustment, 0), 2)) AS pay,0 as paid " & _
        '             " FROM         GL_account_adjustment_head INNER JOIN " & _
        '              " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '             " where amount_adjustment > 0  " & IIf(StrWhere.Trim.Length > 0, " and  " & StrWhere, "") & _
        '             " GROUP BY  date_adjustment "

        'DAGeneral.Fill(DsFrmPrintARCus1.AgingDetail)




        'For j As Integer = 0 To DsFrmPrintARCus1.AgingDetail.Count - 1

        '    Select Case DateDiff(DateInterval.Day, DsFrmPrintARCus1.AgingDetail(j).Item("due"), Now())
        '        Case Is < 1
        '            DsFrmPrintARCus1.Aging(0).c1 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay") - DsFrmPrintARCus1.AgingDetail(j).Item("paid"))

        '        Case Is < 31
        '            DsFrmPrintARCus1.Aging(0).c2 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay") - DsFrmPrintARCus1.AgingDetail(j).Item("paid"))

        '        Case Is < 61
        '            DsFrmPrintARCus1.Aging(0).c3 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay") - DsFrmPrintARCus1.AgingDetail(j).Item("paid"))

        '        Case Is < 91
        '            DsFrmPrintARCus1.Aging(0).c4 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay") - DsFrmPrintARCus1.AgingDetail(j).Item("paid"))

        '        Case Else
        '            DsFrmPrintARCus1.Aging(0).c5 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay") - DsFrmPrintARCus1.AgingDetail(j).Item("paid"))
        '    End Select
        'Next

        DsFrmPrintARCus1.Aging(0).credit = DsFrmPrintARCus1.Aging(0).charge - DsFrmPrintARCus1.Aging(0).BalanceAmount



        'DAGeneral.SelectCommand.CommandText = "SELECT   1  AS cod_customer,  GL_payment_AR.AR_due_date AS due, SUM(ROUND(ISNULL(GL_account_adjustment_dtl.amount_adjustment, 0), 2)) AS pay " & _
        '              " , GL_account_adjustment_dtl.refrence_no as id1, GL_account_adjustment_dtl.id_service_center as id2 " & _
        '              " from      service_center_head INNER JOIN " & _
        '             "  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN " & _
        '              " GL_account_adjustment_dtl ON service_center_head.id_service_center = GL_account_adjustment_dtl.id_service_center INNER JOIN  " & _
        '              " GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_head.refrence_no INNER JOIN " & _
        '              " cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer " & _
        '              " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') and GL_account_adjustment_head.amount_adjustment < 0 " & IIf(StrWhere.Trim.Length > 0, " and  " & StrWhere, "") & _
        '              " GROUP BY   GL_payment_AR.AR_due_date , GL_account_adjustment_dtl.refrence_no, GL_account_adjustment_dtl.id_service_center " & _
        '              " order by  GL_account_adjustment_dtl.refrence_no , GL_account_adjustment_dtl.id_service_center   "

        'DsFrmPrintARCus1.AgingDetail.Clear()

        'DAGeneral.Fill(DsFrmPrintARCus1.AgingDetail)


        'Dim ID1 As String = ""
        'Dim ID2 As String = ""

        'For j As Integer = 0 To DsFrmPrintARCus1.AgingDetail.Count - 1
        '    If DsFrmPrintARCus1.AgingDetail(j).Item("id2") <> ID2 And DsFrmPrintARCus1.AgingDetail(j).Item("id1") <> ID1 Then
        '        ID2 = DsFrmPrintARCus1.AgingDetail(j).Item("id2")
        '        ID1 = DsFrmPrintARCus1.AgingDetail(j).Item("id1")
        '        Select Case DateDiff(DateInterval.Day, DsFrmPrintARCus1.AgingDetail(j).Item("due"), Now())
        '            Case Is < 1
        '                DsFrmPrintARCus1.Aging(0).c1 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay"), 2)
        '            Case Is < 31
        '                DsFrmPrintARCus1.Aging(0).c2 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay"), 2)

        '            Case Is < 61
        '                DsFrmPrintARCus1.Aging(0).c3 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay"), 2)

        '            Case Is < 91
        '                DsFrmPrintARCus1.Aging(0).c4 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay"), 2)

        '            Case Else
        '                DsFrmPrintARCus1.Aging(0).c5 = Math.Round(DsFrmPrintARCus1.Aging(0).c1 + DsFrmPrintARCus1.AgingDetail(j).Item("pay"), 2)

        '        End Select
        '    End If


        'Next


        GrdAging.RootTable.Columns(1).Visible = False
        GrdAging.RootTable.Columns(2).Visible = False
        GrdAging.RootTable.Columns(3).Visible = False
        GrdAging.RootTable.Columns(4).Visible = False
        GrdAging.TotalRow = InheritableBoolean.False



        'If Not (DSCus.Tables("customer") Is Nothing) Then
        '    For i As Integer = 0 To DsFrmPrintARCus1.Aging.Count - 1
        '        If DSCus.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmPrintARCus1.Aging(i).cod_customer)).Length > 0 Then
        '            DsFrmPrintARCus1.Aging(i).FlagShow = 1
        '        End If
        '    Next
        'End If

        DsFrmPrintARCus1.Aging.AcceptChanges()
        'DsFrmPrintARCus1.Aging.DefaultView.RowFilter = " FlagShow = true  "
        GrdAging.SetDataBinding(DsFrmPrintARCus1.Aging, "")

        GrdAging.BringToFront()
    End Sub



    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case KindOfReport
            Case KindReport.customerARChargeDetail
                Me.GrdCusChargeDetail.ShowFieldChooser(Me)
            Case KindReport.customerARChargeSummery
                Me.GrdCusChargeSummery.ShowFieldChooser(Me)
            Case KindReport.CustomerARPaymentDetail
                Me.GrdCusPaymentDetail.ShowFieldChooser(Me)
            Case KindReport.CustomerARPaymentSummery
                Me.GrdCusPaymentSummery.ShowFieldChooser(Me)
            Case KindReport.CustomerARLedgerDetail
                Me.GrdcusLedgerDetail.ShowFieldChooser(Me)
            Case KindReport.CustomerARLedgerSummery
                Me.GrdcusLedgerSummery.ShowFieldChooser(Me)
            Case KindReport.CustomerDuePastDetail
                Me.GrdPastDueDetail.ShowFieldChooser(Me)
            Case KindReport.CustomerDuePastSummery
                Me.GrdPastDueSummery.ShowFieldChooser(Me)
            Case KindReport.CustomerAgingDetail
                Me.GrdAging.ShowFieldChooser(Me)
            Case KindReport.CustomerAgingSummery
                Me.GrdAging.ShowFieldChooser(Me)
        End Select

    End Sub


    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        Select Case KindOfReport
            Case KindReport.customerARChargeDetail
                GridEXPrintDocument1.GridEX = GrdCusChargeDetail
            Case KindReport.customerARChargeSummery
                GridEXPrintDocument1.GridEX = GrdCusChargeSummery
            Case KindReport.CustomerARPaymentDetail
                GridEXPrintDocument1.PrintHierarchical = True
                GridEXPrintDocument1.GridEX = GrdCusPaymentDetail
            Case KindReport.CustomerARPaymentSummery
                GridEXPrintDocument1.GridEX = GrdCusPaymentSummery
            Case KindReport.CustomerARLedgerDetail
                GridEXPrintDocument1.GridEX = GrdcusLedgerDetail
            Case KindReport.CustomerARLedgerSummery
                GridEXPrintDocument1.GridEX = GrdcusLedgerSummery
            Case KindReport.CustomerDuePastDetail
                GridEXPrintDocument1.GridEX = GrdPastDueDetail
            Case KindReport.CustomerDuePastSummery
                GridEXPrintDocument1.GridEX = GrdPastDueSummery
            Case KindReport.CustomerAgingDetail
                GridEXPrintDocument1.GridEX = GrdAging
            Case KindReport.CustomerAgingSummery
                GridEXPrintDocument1.GridEX = GrdAging
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

        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = filter1
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
            Case KindReport.customerARChargeDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCusChargeDetail)
            Case KindReport.customerARChargeSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCusChargeSummery)
            Case KindReport.CustomerARPaymentDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCusPaymentDetail)
            Case KindReport.CustomerARPaymentSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCusPaymentSummery)
            Case KindReport.CustomerARLedgerDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdcusLedgerDetail)
            Case KindReport.CustomerARLedgerSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdcusLedgerSummery)
            Case KindReport.CustomerDuePastDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdPastDueDetail)
            Case KindReport.CustomerDuePastSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdPastDueSummery)
            Case KindReport.CustomerAgingDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdAging)
            Case KindReport.CustomerAgingSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdAging)

        End Select

    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case KindOfReport
            Case KindReport.customerARChargeDetail
                For i As Integer = 0 To DsFrmPrintARCus1.CusChargeDetail.Count - 1
                    DsFrmPrintARCus1.CusChargeDetail(i).flag = False
                Next
            Case KindReport.customerARChargeSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusChargeSummery.Count - 1
                    DsFrmPrintARCus1.CusChargeSummery(i).flag = False
                Next
            Case KindReport.CustomerARPaymentDetail
                For i As Integer = 0 To DsFrmPrintARCus1.DetailPaySum.Count - 1
                    DsFrmPrintARCus1.DetailPaySum(i).flag = False
                Next
            Case KindReport.CustomerARPaymentSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusARPaymentSummery.Count - 1
                    DsFrmPrintARCus1.CusARPaymentSummery(i).flag = False
                Next
            Case KindReport.CustomerARLedgerDetail
                For i As Integer = 0 To DSCus.Tables("CusARLedgerDetail").Rows.Count - 1
                    DSCus.Tables("CusARLedgerDetail").Rows(i).item("flag") = False
                Next
            Case KindReport.CustomerARLedgerSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerSummery.Count - 1
                    DsFrmPrintARCus1.CusARLedgerSummery(i).flag = False
                Next
            Case KindReport.CustomerDuePastDetail
                For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastDetail.Count - 1
                    DsFrmPrintARCus1.CusDuePastDetail(i).flag = False
                Next
            Case KindReport.CustomerDuePastSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastSummery.Count - 1
                    DsFrmPrintARCus1.CusDuePastSummery(i).flag = False
                Next
            Case KindReport.CustomerAgingDetail
                For i As Integer = 0 To DsFrmPrintARCus1.Aging.Count - 1
                    DsFrmPrintARCus1.Aging(i).flag = False
                Next
            Case KindReport.CustomerAgingSummery
                For i As Integer = 0 To DsFrmPrintARCus1.Aging.Count - 1
                    DsFrmPrintARCus1.Aging(i).flag = False
                Next
        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case KindOfReport
            Case KindReport.customerARChargeDetail
                For i As Integer = 0 To DsFrmPrintARCus1.CusChargeDetail.Count - 1
                    DsFrmPrintARCus1.CusChargeDetail(i).flag = True
                Next
            Case KindReport.customerARChargeSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusChargeSummery.Count - 1
                    DsFrmPrintARCus1.CusChargeSummery(i).flag = True
                Next
            Case KindReport.CustomerARPaymentDetail
                For i As Integer = 0 To DsFrmPrintARCus1.DetailPaySum.Count - 1
                    DsFrmPrintARCus1.DetailPaySum(i).flag = True
                Next
            Case KindReport.CustomerARPaymentSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusARPaymentSummery.Count - 1
                    DsFrmPrintARCus1.CusARPaymentSummery(i).flag = True
                Next
            Case KindReport.CustomerARLedgerDetail
                For i As Integer = 0 To DSCus.Tables("CusARLedgerDetail").Rows.Count - 1
                    DSCus.Tables("CusARLedgerDetail").Rows(i).item("flag") = True
                Next
            Case KindReport.CustomerARLedgerSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusARLedgerSummery.Count - 1
                    DsFrmPrintARCus1.CusARLedgerSummery(i).flag = True
                Next
            Case KindReport.CustomerDuePastDetail
                For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastDetail.Count - 1
                    DsFrmPrintARCus1.CusDuePastDetail(i).flag = True
                Next
            Case KindReport.CustomerDuePastSummery
                For i As Integer = 0 To DsFrmPrintARCus1.CusDuePastSummery.Count - 1
                    DsFrmPrintARCus1.CusDuePastSummery(i).flag = True
                Next
            Case KindReport.CustomerAgingDetail
                For i As Integer = 0 To DsFrmPrintARCus1.Aging.Count - 1
                    DsFrmPrintARCus1.Aging(i).flag = True
                Next
            Case KindReport.CustomerAgingSummery
                For i As Integer = 0 To DsFrmPrintARCus1.Aging.Count - 1
                    DsFrmPrintARCus1.Aging(i).flag = True
                Next
        End Select

        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub



    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Select Case KindOfReport
            Case KindReport.customerARChargeDetail
                Call pprint1("print")
            Case KindReport.customerARChargeSummery
                Call pprint2("print")
            Case KindReport.CustomerARPaymentDetail
                Call pprint3("print")
            Case KindReport.CustomerARPaymentSummery
                Call pprint4("print")
            Case KindReport.CustomerARLedgerDetail
                Call pprint5("print")
            Case KindReport.CustomerARLedgerSummery
                Call pprint6("print")
            Case KindReport.CustomerDuePastDetail
                Call pprint7("print")
            Case KindReport.CustomerDuePastSummery
                Call pprint8("print")

        End Select
    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Select Case KindOfReport
            Case KindReport.customerARChargeDetail
                Call pprint1("priv")
            Case KindReport.customerARChargeSummery
                Call pprint2("priv")
            Case KindReport.CustomerARPaymentDetail
                Call pprint3("priv")
            Case KindReport.CustomerARPaymentSummery
                Call pprint4("priv")
            Case KindReport.CustomerARLedgerDetail
                Call pprint5("priv")
            Case KindReport.CustomerARLedgerSummery
                Call pprint6("priv")
            Case KindReport.CustomerDuePastDetail
                Call pprint7("priv")
            Case KindReport.CustomerDuePastSummery
                Call pprint8("priv")
        End Select
    End Sub
    Private Sub pprint1(ByVal type As String)

        Dim rpt As New RepChargeDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintARCus1)
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
    Private Sub pprint2(ByVal type As String)

        Dim rpt As New RepChargeSummery
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintARCus1)
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
    Private Sub pprint3(ByVal type As String)

        Dim rpt As New RepPaymentDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintARCus1.DetailPaySum)
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
    Private Sub pprint4(ByVal type As String)

        Dim rpt As New RepPaymentSummery
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintARCus1)
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
    Private Sub pprint5(ByVal type As String)

        Dim rpt As New RepLedgerDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DSCus.Tables("CusARLedgerDetail"))
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
    Private Sub pprint6(ByVal type As String)

        Dim rpt As New RepLedgerSummery
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintARCus1)
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
    Private Sub pprint7(ByVal type As String)

        Dim rpt As New RepPastDueDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintARCus1)
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
    Private Sub pprint8(ByVal type As String)

        Dim rpt As New RepPastDueSummery
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintARCus1)
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


    Private Sub GrdCusChargeDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdCusChargeDetail.DoubleClick
        If GrdCusChargeDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdCusChargeDetail.GetRow

            Select Case Mid(Currentrow.Cells("id_service_center").Value, 1, 2)
                Case "IN"
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
                    MyFrmShowWorkOrder.Show()

                Case Else
                    Exit Sub
            End Select

        End If
    End Sub

    Private Sub GrdCusPaymentDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdCusPaymentDetail.DoubleClick
        'If GrdCusPaymentDetail.RowCount > 0 Then
        '    Dim Currentrow As GridEXRow = GrdCusPaymentDetail.GetRow
        '    Select Case Mid(Currentrow.Cells("id_service_center").Value, 1, 2)
        '        Case "IN"
        '            Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
        '            MyFrmShowWorkOrder.TypeOfForm = "IN"
        '            MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
        '            MyFrmShowWorkOrder.Show()
        '        Case Else
        '            Exit Sub
        '    End Select
        'End If
    End Sub

    Private Sub GrdPastDueDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdPastDueDetail.DoubleClick
        If GrdPastDueDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdPastDueDetail.GetRow
            Select Case Mid(Currentrow.Cells("id_service_center").Value, 1, 2)
                Case "IN"
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
                    MyFrmShowWorkOrder.Show()
                Case Else
                    Exit Sub
            End Select
        End If
    End Sub

    Private Sub GrdcusLedgerDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdcusLedgerDetail.DoubleClick
        If GrdcusLedgerDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdcusLedgerDetail.GetRow
            Select Case Mid(Currentrow.Cells("Ref. No").Value, 1, 2)
                Case "IN"
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("Ref. No").Value & ""
                    MyFrmShowWorkOrder.Show()
                Case Else
                    Exit Sub
            End Select
        End If
    End Sub
    Dim x As Integer = 0
    Private Sub GridEXPrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles GridEXPrintDocument1.PrintPage
        x = x + 1
        GridEXPrintDocument1.PageFooterRight = x
    End Sub
    Private Sub GridEXPrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GridEXPrintDocument1.EndPrint
        x = 0
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub RdoPortrait_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoPortrait.CheckedChanged
        If RdoLandScape.Checked Then
            GridEXPrintDocument1.DefaultPageSettings.Landscape = True
        Else
            GridEXPrintDocument1.DefaultPageSettings.Landscape = False
        End If
    End Sub

    
End Class
