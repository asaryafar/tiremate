Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayCashReport
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
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
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
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_center_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayCashReport1 As UCBankAccount.DSFrmEndOfDayCashReport
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_Paid_receivedPaid As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAGL_Paid_receivedReceived As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGl_receive_payment As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayCashReport))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayCashReport1 = New UCBankAccount.DSFrmEndOfDayCashReport
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
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_Paid_receivedPaid = New System.Data.SqlClient.SqlDataAdapter
        Me.DAGL_Paid_receivedReceived = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGl_receive_payment = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayCashReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.AutoEdit = True
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayCashReport1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMember>fla" & _
        "g</DataMember><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position>" & _
        "<Visible>False</Visible><Width>34</Width></Column0><Column1 ID=""id_service_cente" & _
        "r""><Caption>Ref. No</Caption><DataMember>id_service_center</DataMember><EditType" & _
        ">NoEdit</EditType><Key>id_service_center</Key><Position>1</Position><Width>66</W" & _
        "idth></Column1><Column2 ID=""date_refer""><Caption>Date</Caption><DataMember>date_" & _
        "refer</DataMember><EditType>NoEdit</EditType><Key>date_refer</Key><Position>2</P" & _
        "osition><Width>75</Width></Column2><Column3 ID=""cod_customer""><Caption>Customer<" & _
        "/Caption><DataMember>cod_customer</DataMember><EditType>NoEdit</EditType><Key>co" & _
        "d_customer</Key><Position>3</Position><Width>69</Width></Column3><Column4 ID=""fu" & _
        "llname""><Caption>Name</Caption><DataMember>fullname</DataMember><EditType>NoEdit" & _
        "</EditType><Key>fullname</Key><Position>4</Position><Width>125</Width></Column4>" & _
        "<Column5 ID=""abbreviation_name""><Caption>Company</Caption><DataMember>abbreviati" & _
        "on_name</DataMember><EditType>NoEdit</EditType><Key>abbreviation_name</Key><Posi" & _
        "tion>5</Position><Width>137</Width></Column5><Column6 ID=""Total""><AggregateFunct" & _
        "ion>Sum</AggregateFunction><Caption>Total</Caption><DataMember>Total</DataMember" & _
        "><EditType>NoEdit</EditType><FormatString>c2</FormatString><Key>Total</Key><Posi" & _
        "tion>6</Position><TextAlignment>Far</TextAlignment><Width>103</Width><TotalForma" & _
        "tString>c2</TotalFormatString></Column6><Column7 ID=""Cash_Amount""><AggregateFunc" & _
        "tion>Sum</AggregateFunction><Caption>Cash Amount</Caption><DataMember>Cash_Amoun" & _
        "t</DataMember><EditType>NoEdit</EditType><FormatString>c2</FormatString><Key>Cas" & _
        "h_Amount</Key><Position>7</Position><TextAlignment>Far</TextAlignment><Width>87<" & _
        "/Width><TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=""CheckAmou" & _
        "nt""><AggregateFunction>Sum</AggregateFunction><Caption>Check Amount</Caption><Da" & _
        "taMember>CheckAmount</DataMember><EditType>NoEdit</EditType><FormatString>c2</Fo" & _
        "rmatString><Key>CheckAmount</Key><Position>8</Position><TextAlignment>Far</TextA" & _
        "lignment><Width>86</Width><TotalFormatString>c2</TotalFormatString></Column8><Co" & _
        "lumn9 ID=""Credit_Amount""><AggregateFunction>Sum</AggregateFunction><Caption>C.Ca" & _
        "rd Amt.</Caption><DataMember>Credit_Amount</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FormatString>c2</FormatString><Key>Credit_Amount</Key><Position>9</Position><" & _
        "TextAlignment>Far</TextAlignment><Width>88</Width><TotalFormatString>c2</TotalFo" & _
        "rmatString></Column9><Column10 ID=""cc_type_desc""><Caption>C.C. Type</Caption><Da" & _
        "taMember>cc_type_desc</DataMember><EditType>NoEdit</EditType><Key>cc_type_desc</" & _
        "Key><Position>10</Position><Width>115</Width></Column10><Column11 ID=""check_no"">" & _
        "<Caption>Check No</Caption><DataMember>check_no</DataMember><EditType>NoEdit</Ed" & _
        "itType><Key>check_no</Key><Position>11</Position><Width>75</Width></Column11></C" & _
        "olumns><GroupCondition ID="""" /><Key>service_center_head</Key></RootTable></GridE" & _
        "XLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 64)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(716, 340)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        '
        'DsFrmEndOfDayCashReport1
        '
        Me.DsFrmEndOfDayCashReport1.DataSetName = "DSFrmEndOfDayCashReport"
        Me.DsFrmEndOfDayCashReport1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=tiremate_01"
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
        Me.Label1.Text = "End Of Day Cash Report"
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
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(214, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT service_center_head.id_service_center, service_center_head.Total, cust_trt" & _
        "ab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS " & _
        "fullname, cust_company.abbreviation_name, service_center_head.cod_customer, serv" & _
        "ice_center_head.date_refer, ISNULL(View_Invoice_Cash.payment_amount, 0) AS Cash_" & _
        "Amount, ISNULL(View_Invoice_Check.payment_amount, 0) AS CheckAmount, ISNULL(View" & _
        "_Invoice_Check.check_no, '') AS check_no, ISNULL(View_Invoice_credit.payment_amo" & _
        "unt, 0) AS Credit_Amount, ISNULL(View_Invoice_credit.cc_type_desc, '') AS cc_typ" & _
        "e_desc, 1 AS flag FROM View_Invoice_Cash RIGHT OUTER JOIN service_center_head ON" & _
        " View_Invoice_Cash.id_service_center = service_center_head.id_service_center LEF" & _
        "T OUTER JOIN View_Invoice_Check ON service_center_head.id_service_center = View_" & _
        "Invoice_Check.id_service_center LEFT OUTER JOIN View_Invoice_credit ON service_c" & _
        "enter_head.id_service_center = View_Invoice_credit.id_service_center LEFT OUTER " & _
        "JOIN cust_company RIGHT OUTER JOIN cust_trtab_main ON cust_company.cod_company =" & _
        " cust_trtab_main.cod_company ON service_center_head.cod_customer = cust_trtab_ma" & _
        "in.cod_customer"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAservice_center_head
        '
        Me.DAservice_center_head.SelectCommand = Me.SqlSelectCommand3
        Me.DAservice_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_Paid_received.refrence_code, GL_Paid_received.refrence_code AS id_servi" & _
        "ce_center, GL_Paid_received.action_date AS date_refer, GL_Paid_received.customer" & _
        "_code, GL_Paid_received.amount AS Total, cust_trtab_main.f_name + ' ' + cust_trt" & _
        "ab_main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cust_company.abbrevia" & _
        "tion_name, CASE WHEN OtherReceipType = '1' THEN - amount ELSE 0 END AS Cash_Amou" & _
        "nt, CASE WHEN OtherReceipType = '2' THEN - amount ELSE 0 END AS CheckAmount FROM" & _
        " GL_Paid_received INNER JOIN cust_trtab_main ON GL_Paid_received.customer_code =" & _
        " cust_trtab_main.cod_customer INNER JOIN cust_company ON cust_trtab_main.cod_com" & _
        "pany = cust_company.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAGL_Paid_receivedPaid
        '
        Me.DAGL_Paid_receivedPaid.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_Paid_receivedPaid.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("Id_GL_journal", "Id_GL_journal"), New System.Data.Common.DataColumnMapping("OtherReceipType", "OtherReceipType"), New System.Data.Common.DataColumnMapping("Id_debit_deposit_head", "Id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center")})})
        '
        'DAGL_Paid_receivedReceived
        '
        Me.DAGL_Paid_receivedReceived.SelectCommand = Me.SqlCommand1
        Me.DAGL_Paid_receivedReceived.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("Id_GL_journal", "Id_GL_journal"), New System.Data.Common.DataColumnMapping("OtherReceipType", "OtherReceipType"), New System.Data.Common.DataColumnMapping("Id_debit_deposit_head", "Id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_Paid_received.refrence_code, GL_Paid_received.refrence_code AS id_servi" & _
        "ce_center, GL_Paid_received.action_date AS date_refer, GL_Paid_received.customer" & _
        "_code, GL_Paid_received.amount AS Total, cust_trtab_main.f_name + ' ' + cust_trt" & _
        "ab_main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cust_company.abbrevia" & _
        "tion_name, CASE WHEN OtherReceipType = '1' THEN amount ELSE 0 END AS Cash_Amount" & _
        ", CASE WHEN OtherReceipType = '2' THEN amount ELSE 0 END AS CheckAmount FROM GL_" & _
        "Paid_received INNER JOIN cust_trtab_main ON GL_Paid_received.customer_code = cus" & _
        "t_trtab_main.cod_customer INNER JOIN cust_company ON cust_trtab_main.cod_company" & _
        " = cust_company.cod_company"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Gl_receive_payment.refrence_no AS id_service_center, cust_trtab_main.f_nam" & _
        "e + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cus" & _
        "t_company.abbreviation_name, Gl_receive_payment.date_receive_payment AS date_ref" & _
        "er, Gl_receive_payment.cod_customer, Gl_receive_payment.amount_receive AS total," & _
        " bas_cc_type.cc_type_desc, Gl_receive_payment.check_no, CASE WHEN Gl_receive_pay" & _
        "ment.pmt_method = '1' THEN Gl_receive_payment.amount_receive ELSE 0 END AS Cash_" & _
        "Amount, CASE WHEN Gl_receive_payment.pmt_method = '2' THEN Gl_receive_payment.am" & _
        "ount_receive ELSE 0 END AS CheckAmount, CASE WHEN Gl_receive_payment.pmt_method " & _
        "= '3' THEN Gl_receive_payment.amount_receive ELSE 0 END AS Credit_Amount FROM Gl" & _
        "_receive_payment LEFT OUTER JOIN cust_trtab_main ON Gl_receive_payment.cod_custo" & _
        "mer = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_ma" & _
        "in.cod_company = cust_company.cod_company LEFT OUTER JOIN bas_cc_type ON Gl_rece" & _
        "ive_payment.cc_type = bas_cc_type.cc_type"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGl_receive_payment
        '
        Me.DAGl_receive_payment.SelectCommand = Me.SqlSelectCommand2
        Me.DAGl_receive_payment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Gl_receive_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_receive", "amount_receive"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("pmt_method", "pmt_method"), New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_no", "cc_no"), New System.Data.Common.DataColumnMapping("Gl_account", "Gl_account"), New System.Data.Common.DataColumnMapping("date_receive_payment", "date_receive_payment"), New System.Data.Common.DataColumnMapping("check_no", "check_no"), New System.Data.Common.DataColumnMapping("expir_date_year", "expir_date_year"), New System.Data.Common.DataColumnMapping("expir_date_month", "expir_date_month")})})
        '
        'FrmEndOfDayCashReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(716, 404)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.MaximizeBox = True
        Me.Name = "FrmEndOfDayCashReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "End Of Day Cash Report"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayCashReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        Dim OriginalSelectCommand As String

        DAservice_center_head.SelectCommand.CommandText = DAservice_center_head.SelectCommand.CommandText & " Where dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) & " AND (service_center_head.type_of_form = 'IN' OR service_center_head.type_of_form = 'RT') AND (service_center_head.id_service_center IN (SELECT     id_service_center FROM         GL_payment_deposit WHERE     (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '1' OR dbo.GL_payment_deposit.payment_type = '2' OR dbo.GL_payment_deposit.payment_type = '3'))) "
        DAservice_center_head.Fill(DsFrmEndOfDayCashReport1.service_center_dtl)

        DAGL_Paid_receivedPaid.SelectCommand.CommandText = DAGL_Paid_receivedPaid.SelectCommand.CommandText & " Where GL_Paid_received.tran_type='1' AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAGL_Paid_receivedPaid.Fill(DsFrmEndOfDayCashReport1.service_center_dtl)

        DAGL_Paid_receivedReceived.SelectCommand.CommandText = DAGL_Paid_receivedReceived.SelectCommand.CommandText & " Where GL_Paid_received.tran_type='2' AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAGL_Paid_receivedReceived.Fill(DsFrmEndOfDayCashReport1.service_center_dtl)

        DAGl_receive_payment.SelectCommand.CommandText = DAGl_receive_payment.SelectCommand.CommandText & " Where dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAGl_receive_payment.Fill(DsFrmEndOfDayCashReport1.service_center_dtl)

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
        For i As Integer = 0 To DsFrmEndOfDayCashReport1.service_center_dtl.Count - 1
            DsFrmEndOfDayCashReport1.service_center_dtl(i).flag = False
        Next
        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        For i As Integer = 0 To DsFrmEndOfDayCashReport1.service_center_dtl.Count - 1
            DsFrmEndOfDayCashReport1.service_center_dtl(i).flag = True
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
