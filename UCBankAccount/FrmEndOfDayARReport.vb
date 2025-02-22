Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayARReport
    Inherits FrmBase
    Public FromDateVar As String
    Public ToDateVar As String
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BtnSendToExcell As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_adjustment_dtlCharge As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAGL_account_adjustment_dtlCredit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmEndOfDayARReport1 As UCBankAccount.DSFrmEndOfDayARReport
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DAInvoices As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_AR As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayARReport))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.DsFrmEndOfDayARReport1 = New UCBankAccount.DSFrmEndOfDayARReport
        Me.Cnn = New System.Data.SqlClient.SqlConnection
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
        Me.BtnSendToExcell = New System.Windows.Forms.Button
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.DAInvoices = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_dtlCharge = New System.Data.SqlClient.SqlDataAdapter
        Me.DAGL_account_adjustment_dtlCredit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DAGL_payment_AR = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsFrmEndOfDayARReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsFrmEndOfDayARReport1
        '
        Me.DsFrmEndOfDayARReport1.DataSetName = "DSFrmEndOfDayARReport"
        Me.DsFrmEndOfDayARReport1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_03"
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
        Me.Panel4.Controls.Add(Me.BtnSendToExcell)
        Me.Panel4.Controls.Add(Me.BtnJPrint)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(716, 64)
        Me.Panel4.TabIndex = 4
        '
        'BtnDeselect
        '
        Me.BtnDeselect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(403, 4)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 221
        Me.BtnDeselect.Visible = False
        '
        'BtnFchooser
        '
        Me.BtnFchooser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(661, 4)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 220
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(653, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(394, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "Deselect All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'BtnSelect
        '
        Me.BtnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(403, 4)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 217
        Me.BtnSelect.Visible = False
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(609, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 216
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(557, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 215
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(504, 38)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 214
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label29.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(447, 38)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 213
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label28.Visible = False
        '
        'BtnSendToExcell
        '
        Me.BtnSendToExcell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSendToExcell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSendToExcell.Image = CType(resources.GetObject("BtnSendToExcell.Image"), System.Drawing.Image)
        Me.BtnSendToExcell.Location = New System.Drawing.Point(611, 4)
        Me.BtnSendToExcell.Name = "BtnSendToExcell"
        Me.BtnSendToExcell.Size = New System.Drawing.Size(33, 27)
        Me.BtnSendToExcell.TabIndex = 212
        '
        'BtnJPrint
        '
        Me.BtnJPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(559, 4)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 211
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(506, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 210
        Me.BtnPrint.Visible = False
        '
        'BtnPreview
        '
        Me.BtnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(455, 4)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 209
        Me.BtnPreview.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 62)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "End Of Day"
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
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(88, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        '
        'DAInvoices
        '
        Me.DAInvoices.SelectCommand = Me.SqlSelectCommand1
        Me.DAInvoices.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_AR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("AR_due_date", "AR_due_date")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, ser" & _
        "vice_center_head.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_" & _
        "name + ' ' + cust_trtab_main.l_name AS fullname, cust_company.abbreviation_name," & _
        " service_center_head.Total, ISNULL(GL_payment_deposit.payment_amount, 0) AS Char" & _
        "ge, 0 AS Credit FROM GL_payment_AR INNER JOIN GL_payment_deposit ON GL_payment_A" & _
        "R.ID_payment = GL_payment_deposit.ID_payment INNER JOIN service_center_head ON G" & _
        "L_payment_deposit.id_service_center = service_center_head.id_service_center LEFT" & _
        " OUTER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_mai" & _
        "n.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cus" & _
        "t_company.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account_adjustment_dtl.refrence_no AS id_service_center, ISNULL(GL_acco" & _
        "unt_adjustment_dtl.amount_adjustment, 0) AS Total, ISNULL(GL_account_adjustment_" & _
        "dtl.amount_adjustment, 0) AS Charge, 0 AS Credit, cust_trtab_main.f_name + ' ' +" & _
        " cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cust_company" & _
        ".abbreviation_name, GL_account_adjustment_head.date_adjustment AS date_refer, 1 " & _
        "AS flag, '' AS memo, GL_account_adjustment_head.cod_customer FROM GL_account_adj" & _
        "ustment_dtl INNER JOIN GL_account_adjustment_head ON GL_account_adjustment_dtl.r" & _
        "efrence_no = GL_account_adjustment_head.refrence_no INNER JOIN service_center_he" & _
        "ad ON GL_account_adjustment_dtl.id_service_center = service_center_head.id_servi" & _
        "ce_center INNER JOIN cust_trtab_main ON GL_account_adjustment_head.cod_customer " & _
        "= cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.c" & _
        "od_company = cust_company.cod_company"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_account_adjustment_dtlCharge
        '
        Me.DAGL_account_adjustment_dtlCharge.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account_adjustment_dtlCharge.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment")})})
        '
        'DAGL_account_adjustment_dtlCredit
        '
        Me.DAGL_account_adjustment_dtlCredit.SelectCommand = Me.SqlCommand1
        Me.DAGL_account_adjustment_dtlCredit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_account_adjustment_dtl.refrence_no AS id_service_center, ISNULL(GL_acco" & _
        "unt_adjustment_dtl.amount_adjustment, 0) AS Total, 0 AS Charge, - ISNULL(GL_acco" & _
        "unt_adjustment_dtl.amount_adjustment, 0) AS Credit, cust_trtab_main.f_name + ' '" & _
        " + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cust_compa" & _
        "ny.abbreviation_name, GL_account_adjustment_head.date_adjustment AS date_refer, " & _
        "GL_account_adjustment_head.cod_customer FROM GL_account_adjustment_dtl INNER JOI" & _
        "N GL_account_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_accou" & _
        "nt_adjustment_head.refrence_no INNER JOIN service_center_head ON GL_account_adju" & _
        "stment_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
        "cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod" & _
        "_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_com" & _
        "pany.cod_company"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayARReport1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Ref. No</Caption><TypeNameE" & _
        "mptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Dat" & _
        "aMember>id_service_center</DataMember><Key>id_service_center</Key><Position>0</P" & _
        "osition><Width>65</Width></Column0><Column1 ID=""date_refer""><Caption>Date</Capti" & _
        "on><DataMember>date_refer</DataMember><Key>date_refer</Key><Position>1</Position" & _
        "><Width>76</Width></Column1><Column2 ID=""cod_customer""><Caption>Customer</Captio" & _
        "n><DataMember>cod_customer</DataMember><Key>cod_customer</Key><Position>2</Posit" & _
        "ion><Width>66</Width></Column2><Column3 ID=""fullname""><Caption>Name</Caption><Da" & _
        "taMember>fullname</DataMember><EditType>NoEdit</EditType><Key>fullname</Key><Pos" & _
        "ition>3</Position><Width>112</Width></Column3><Column4 ID=""abbreviation_name""><C" & _
        "aption>Company</Caption><DataMember>abbreviation_name</DataMember><Key>abbreviat" & _
        "ion_name</Key><Position>4</Position><Width>135</Width></Column4><Column5 ID=""Tot" & _
        "al""><AggregateFunction>Sum</AggregateFunction><Caption>Total</Caption><DataMembe" & _
        "r>Total</DataMember><FormatString>c</FormatString><Key>Total</Key><Position>5</P" & _
        "osition><TextAlignment>Far</TextAlignment><Width>94</Width><TotalFormatString>c2" & _
        "</TotalFormatString></Column5><Column6 ID=""Charge""><AggregateFunction>Sum</Aggre" & _
        "gateFunction><Caption>Charge</Caption><DataMember>Charge</DataMember><FormatStri" & _
        "ng>c</FormatString><Key>Charge</Key><Position>6</Position><TextAlignment>Far</Te" & _
        "xtAlignment><Width>86</Width><TotalFormatString>c2</TotalFormatString></Column6>" & _
        "<Column7 ID=""Credit""><AggregateFunction>Sum</AggregateFunction><Caption>Credit</" & _
        "Caption><DataMember>Credit</DataMember><EditType>NoEdit</EditType><FormatString>" & _
        "c</FormatString><Key>Credit</Key><Position>7</Position><TextAlignment>Far</TextA" & _
        "lignment><Width>89</Width><TotalFormatString>c2</TotalFormatString></Column7><Co" & _
        "lumn8 ID=""memo""><Caption>Memo</Caption><DataMember>memo</DataMember><EditType>No" & _
        "Edit</EditType><Key>memo</Key><Position>8</Position></Column8><Column9 ID=""flag""" & _
        "><Caption>flag</Caption><DataMember>flag</DataMember><EditType>NoEdit</EditType>" & _
        "<Key>flag</Key><Position>9</Position><Visible>False</Visible></Column9></Columns" & _
        "><GroupCondition ID="""" /><Key>service_center_dtl</Key></RootTable></GridEXLayout" & _
        "Data>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 64)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(716, 340)
        Me.GridEX1.TabIndex = 5
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DAGL_payment_AR
        '
        Me.DAGL_payment_AR.SelectCommand = Me.SqlCommand2
        Me.DAGL_payment_AR.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_AR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("AR_due_date", "AR_due_date")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT Gl_receive_payment.refrence_no AS id_service_center, Gl_receive_payment.da" & _
        "te_receive_payment AS date_refer, Gl_receive_payment.cod_customer, cust_trtab_ma" & _
        "in.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS fulln" & _
        "ame, cust_company.abbreviation_name, 0 AS Charge, ISNULL(Gl_receive_payment.amou" & _
        "nt_receive, 0) AS Credit, Gl_receive_payment.amount_receive FROM Gl_receive_paym" & _
        "ent LEFT OUTER JOIN cust_trtab_main ON Gl_receive_payment.cod_customer = cust_tr" & _
        "tab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_compan" & _
        "y = cust_company.cod_company"
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'FrmEndOfDayARReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(716, 404)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = True
        Me.Name = "FrmEndOfDayARReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "End Of Day AR Report"
        CType(Me.DsFrmEndOfDayARReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        DAInvoices.SelectCommand.CommandText = DAInvoices.SelectCommand.CommandText & " Where dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) & " AND (service_center_head.type_of_form='IN' ) "
        DAInvoices.Fill(DsFrmEndOfDayARReport1.service_center_dtl)

        DAGL_account_adjustment_dtlCharge.SelectCommand.CommandText = DAGL_account_adjustment_dtlCharge.SelectCommand.CommandText & " Where dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) & " AND (GL_account_adjustment_dtl.amount_adjustment>0 ) "
        DAGL_account_adjustment_dtlCharge.Fill(DsFrmEndOfDayARReport1.service_center_dtl)

        DAGL_account_adjustment_dtlCredit.SelectCommand.CommandText = DAGL_account_adjustment_dtlCredit.SelectCommand.CommandText & " Where dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) & " AND (GL_account_adjustment_dtl.amount_adjustment<0 ) "
        DAGL_account_adjustment_dtlCredit.Fill(DsFrmEndOfDayARReport1.service_center_dtl)

        DAGL_payment_AR.SelectCommand.CommandText = DAGL_payment_AR.SelectCommand.CommandText & " Where dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) ' & " AND (service_center_head.type_of_form='IN' ) "
        DAGL_payment_AR.Fill(DsFrmEndOfDayARReport1.service_center_dtl)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Me.GridEX1.ShowFieldChooser(Me)
    End Sub
    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        GridEXPrintDocument1.GridEX = GridEX1
        GridEXPrintDocument1.PageHeaderCenter = Me.Text & vbCrLf
        GridEXPrintDocument1.PageHeaderLeft = PubStoreName & vbCrLf
        GridEXPrintDocument1.PageHeaderRight = "From : " & FromDateVar & vbCrLf & "To : " & ToDateVar
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Dim x As Integer = 0
    Private Sub GridEXPrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles GridEXPrintDocument1.PrintPage
        x = x + 1
        GridEXPrintDocument1.PageFooterRight = x & " / " & GridEXPrintDocument1.TotalPages
    End Sub
    Private Sub GridEXPrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GridEXPrintDocument1.EndPrint
        x = 0
    End Sub
    Private Sub BtnSendToExcell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendToExcell.Click
        Dim FileName As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = "report.CSV"
        Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GridEX1)
    End Sub
    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        For i As Integer = 0 To DsFrmEndOfDayARReport1.service_center_dtl.Count - 1
            DsFrmEndOfDayARReport1.service_center_dtl(i).flag = False
        Next
        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        For i As Integer = 0 To DsFrmEndOfDayARReport1.service_center_dtl.Count - 1
            DsFrmEndOfDayARReport1.service_center_dtl(i).flag = True
        Next
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        'Call pprintDetail("print")
    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        'Call pprintDetail("preview")
    End Sub
    Private Sub pprintDetail(ByVal type As String)

        'Dim rpt As New RepCusSaleDetail
        'Dim prn As New FrmRepView
        'Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        'OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        'rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        'rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("STORENO") & "")

        'rpt.SetParameterValue("pardate", Format(Now(), "Long Date"))
        'rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        'rpt.SetParameterValue("Parrepname", "Customer Sales Report In Detail")
        'rpt.SetParameterValue("Parfilter", StrFilter)

        'rpt.SetDataSource(DsFrmprint1)
        'Select Case type
        '    Case "print"
        '        Try
        '            rpt.PrintToPrinter(1, True, 0, 0)
        '        Catch ex As Exception

        '        End Try
        '    Case "preview"
        '        prn.CrViewer.ReportSource = rpt
        '        prn.ShowDialog()
        'End Select
    End Sub

End Class
