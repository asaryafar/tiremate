Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmPrintTraffic
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
    Friend WithEvents GrdList As Janus.Windows.GridEX.GridEX
    Friend WithEvents DAList As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmPrintTraffic1 As ReportEmployee.DSFrmPrintTraffic
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DASummery As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAStore As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdStore As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrintTraffic))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
        Me.GrdList = New Janus.Windows.GridEX.GridEX
        Me.DAList = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DsFrmPrintTraffic1 = New ReportEmployee.DSFrmPrintTraffic
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.DASummery = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GrdSummery = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAStore = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdStore = New Janus.Windows.GridEX.GridEX
        Me.Panel4.SuspendLayout()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPrintTraffic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdStore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(700, 64)
        Me.Panel4.TabIndex = 8
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(284, 5)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 193
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(542, 5)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(534, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(275, 36)
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
        Me.BtnSelect.Location = New System.Drawing.Point(284, 5)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 183
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(490, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(438, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(385, 39)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(328, 39)
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
        Me.BtnEmail.Location = New System.Drawing.Point(492, 5)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(440, 5)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(387, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(336, 5)
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
        'GrdList
        '
        Me.GrdList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdList.DataMember = "List"
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>13</Width></Column0><Column1 ID" & _
        "=""customer_no""><AggregateFunction>Count</AggregateFunction><Caption>Customer</Ca" & _
        "ption><DataMember>customer_no</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>customer_no</Key><Position>1</Position><Width>" & _
        "61</Width><TotalFormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>N" & _
        "o Of Customers  : {0}</TotalFormatString></Column1><Column2 ID=""f_name""><Caption" & _
        ">First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</EditType><" & _
        "FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Position><W" & _
        "idth>78</Width></Column2><Column3 ID=""name""><Caption>Last Name</Caption><DataMem" & _
        "ber>name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><Key>name</Key><Position>3</Position><Width>85</Width></Column3><Column4" & _
        " ID=""complete_name""><Caption>Company</Caption><DataMember>complete_name</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>comp" & _
        "lete_name</Key><Position>4</Position><Width>151</Width></Column4><Column5 ID=""ci" & _
        "ty""><Caption>City</Caption><DataMember>city</DataMember><EditType>NoEdit</EditTy" & _
        "pe><FilterEditType>TextBox</FilterEditType><Key>city</Key><Position>5</Position>" & _
        "<Width>83</Width></Column5><Column6 ID=""zip""><Caption>zip</Caption><DataMember>z" & _
        "ip</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><Key>zip</Key><Position>6</Position><Width>50</Width></Column6><Column7 ID=""ph" & _
        "one_1""><Caption>Main Phone</Caption><DataMember>phone_1</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>TextBox</FilterEditType><Key>phone_1</Key><Positi" & _
        "on>7</Position><Width>79</Width></Column7><Column8 ID=""address""><Caption>Address" & _
        "</Caption><DataMember>address</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>address</Key><Position>8</Position></Column8><" & _
        "Column9 ID=""CustSince""><Caption>Cust. Since</Caption><DataMember>CustSince</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Forma" & _
        "tString>MM/dd/yyyy</FormatString><Key>CustSince</Key><Position>9</Position><Widt" & _
        "h>84</Width></Column9><Column10 ID=""desc_type""><Caption>Type</Caption><DataMembe" & _
        "r>desc_type</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><Key>desc_type</Key><Position>10</Position><Width>40</Width></Column1" & _
        "0><Column11 ID=""desc_source""><Caption>Source</Caption><DataMember>desc_source</D" & _
        "ataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Ke" & _
        "y>desc_source</Key><Position>11</Position><Width>47</Width></Column11></Columns>" & _
        "<GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><Col" & _
        "Index>9</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdList.DesignTimeLayout = GridEXLayout1
        Me.GrdList.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdList.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdList.Location = New System.Drawing.Point(2, 65)
        Me.GrdList.Name = "GrdList"
        Me.GrdList.RecordNavigator = True
        Me.GrdList.Size = New System.Drawing.Size(700, 344)
        Me.GrdList.TabIndex = 9
        '
        'DAList
        '
        Me.DAList.SelectCommand = Me.SqlSelectCommand3
        Me.DAList.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name + ' ' " & _
        "+ cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, cust_company.co" & _
        "mplete_name, bas_zipcode.city, cust_trtab_main.zip, CASE WHEN phone_main_1 = 1 T" & _
        "HEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_" & _
        "3 WHEN phone_main_4 = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS p" & _
        "hone_1, Since.CustSince, last.LastVisit, cust_tab_type.desc_type, cust_tab_sourc" & _
        "e.desc_source, cust_tab_class.desc_class, cust_tab_territory.desc_territory, 1 A" & _
        "S flag FROM cust_trtab_main LEFT OUTER JOIN cust_tab_class ON cust_trtab_main.co" & _
        "d_class = cust_tab_class.cod_class LEFT OUTER JOIN bas_zipcode ON cust_trtab_mai" & _
        "n.zip = bas_zipcode.zipcode LEFT OUTER JOIN cust_tab_territory ON cust_trtab_mai" & _
        "n.cod_territory = cust_tab_territory.cod_territory LEFT OUTER JOIN cust_tab_sour" & _
        "ce ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN cu" & _
        "st_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN" & _
        " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUT" & _
        "ER JOIN (SELECT MAX(Date_Refer) AS LastVisit, service_center_head.cod_customer F" & _
        "ROM service_center_head WHERE type_of_form = 'IN' GROUP BY service_center_head.c" & _
        "od_customer) last ON cust_trtab_main.cod_customer = last.cod_customer LEFT OUTER" & _
        " JOIN (SELECT MAX(Date_Refer) AS CustSince, service_center_head.cod_customer FRO" & _
        "M service_center_head WHERE type_of_form = 'IN' GROUP BY service_center_head.cod" & _
        "_customer) Since ON cust_trtab_main.cod_customer = Since.cod_customer"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_01"
        '
        'DsFrmPrintTraffic1
        '
        Me.DsFrmPrintTraffic1.DataSetName = "DSFrmPrintTraffic"
        Me.DsFrmPrintTraffic1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(315, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        '
        'DASummery
        '
        Me.DASummery.SelectCommand = Me.SqlSelectCommand2
        Me.DASummery.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_ma" & _
        "in.m_name + ' ' + cust_trtab_main.l_name AS name, cust_company.complete_name, SU" & _
        "M(service_center_head.Total) AS amount, COUNT(service_center_head.id_service_cen" & _
        "ter) AS NoInvoice, 1 AS flag FROM service_center_head INNER JOIN cust_trtab_main" & _
        " ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER J" & _
        "OIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHERE" & _
        " (service_center_head.type_of_form = 'IN') GROUP BY cust_trtab_main.cod_customer" & _
        ", cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_c" & _
        "ompany.complete_name, service_center_head.type_of_form"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'GrdSummery
        '
        Me.GrdSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSummery.DataMember = "Summery"
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>26</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>98</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition><Width>84</Width></Column2><Column3 ID=""name""><Caption>Last Name</Caption>" & _
        "<DataMember>name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>name</Key><Position>3</Position><Width>98</Width></Column3>" & _
        "<Column4 ID=""complete_name""><Caption>Company</Caption><DataMember>complete_name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>complete_name</Key><Position>4</Position><Width>146</Width></Column4><Column" & _
        "5 ID=""NoInvoice""><AggregateFunction>Sum</AggregateFunction><Caption>No Of Invoic" & _
        "e</Caption><DataMember>NoInvoice</DataMember><EditType>NoEdit</EditType><FilterE" & _
        "ditType>TextBox</FilterEditType><Key>NoInvoice</Key><Position>5</Position><Width" & _
        ">86</Width></Column5><Column6 ID=""amount""><AggregateFunction>Sum</AggregateFunct" & _
        "ion><Caption>Amount</Caption><DataMember>amount</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><K" & _
        "ey>amount</Key><Position>6</Position><TextAlignment>Far</TextAlignment><Width>12" & _
        "5</Width><TotalFormatString>C2</TotalFormatString></Column6><Column7 ID=""Ext_Cos" & _
        "t""><AggregateFunction>Sum</AggregateFunction><Caption>Cost</Caption><DataMember>" & _
        "Ext_Cost</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><FormatString>c2</FormatString><Key>Ext_Cost</Key><Position>7</Position>" & _
        "<TextAlignment>Far</TextAlignment><TotalFormatString>c2</TotalFormatString></Col" & _
        "umn7></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdSummery.DesignTimeLayout = GridEXLayout2
        Me.GrdSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdSummery.Location = New System.Drawing.Point(-1, 65)
        Me.GrdSummery.Name = "GrdSummery"
        Me.GrdSummery.Size = New System.Drawing.Size(701, 344)
        Me.GrdSummery.TabIndex = 10
        Me.GrdSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.date_refer AS date, ISNULL(SUM(service_center_dtl.qty)" & _
        ", 0) AS qty, ISNULL(SUM(service_center_dtl.price), 0) AS unit_price, ISNULL(SUM(" & _
        "service_center_dtl.fet), 0) AS fet, SUM(ISNULL(service_center_dtl.qty, 0) * (ISN" & _
        "ULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_pr" & _
        "ice, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.c" & _
        "ost, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_cost, 1 AS flag, SUM(ISNULL" & _
        "(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0) + ISNULL(serv" & _
        "ice_center_dtl.fet, 0))) - SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_i" & _
        "tem_cost_transaction.cost, 0) + ISNULL(service_center_dtl.fet, 0))) AS Gross, (S" & _
        "UM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0) + IS" & _
        "NULL(service_center_dtl.fet, 0))) - SUM(ISNULL(service_center_dtl.qty, 0) * (ISN" & _
        "ULL(inv_item_cost_transaction.cost, 0) + ISNULL(service_center_dtl.fet, 0)))) / " & _
        "SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, " & _
        "0) + ISNULL(service_center_dtl.fet, 0))) * 100 AS GrossDarsad, COUNT(service_cen" & _
        "ter_head.id_service_center) AS NoInvoice FROM service_center_dtl INNER JOIN serv" & _
        "ice_center_head ON service_center_dtl.id_service_center = service_center_head.id" & _
        "_service_center LEFT OUTER JOIN inv_item INNER JOIN inv_item_cost_transaction ON" & _
        " inv_item.item_no = inv_item_cost_transaction.item_no ON service_center_dtl.cod_" & _
        "select = inv_item.item_no WHERE (service_center_head.type_of_form = 'IN') AND (d" & _
        "bo.ChangeDate(service_center_head.date_refer) BETWEEN '2009/01/01' AND '2010/12/" & _
        "28') GROUP BY service_center_head.date_refer"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAStore
        '
        Me.DAStore.SelectCommand = Me.SqlSelectCommand1
        Me.DAStore.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'GrdStore
        '
        Me.GrdStore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdStore.DataSource = Me.DsFrmPrintTraffic1.StoreTraffic
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>24</Width></Column0><Column1 ID" & _
        "=""date_refer""><Caption>Date</Caption><DataMember>date_refer</DataMember><EditTyp" & _
        "e>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/y" & _
        "yyy</FormatString><Key>date_refer</Key><Position>1</Position><Width>87</Width></" & _
        "Column1><Column2 ID=""NoInvoice""><AggregateFunction>Sum</AggregateFunction><Capti" & _
        "on>No of Invoices</Caption><DataMember>NoInvoice</DataMember><EditType>NoEdit</E" & _
        "ditType><Key>NoInvoice</Key><Position>2</Position></Column2><Column3 ID=""price"">" & _
        "<AggregateFunction>Sum</AggregateFunction><Caption>Sales</Caption><DataMember>pr" & _
        "ice</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><FormatString>c2</FormatString><Key>price</Key><Position>3</Position><TextAli" & _
        "gnment>Far</TextAlignment><TotalFormatString>c2</TotalFormatString></Column3><Co" & _
        "lumn4 ID=""cost""><AggregateFunction>Sum</AggregateFunction><Caption>Cost</Caption" & _
        "><DataMember>cost</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><FormatString>c2</FormatString><Key>cost</Key><Position>4</Posi" & _
        "tion><TextAlignment>Far</TextAlignment><TotalFormatString>c2</TotalFormatString>" & _
        "</Column4><Column5 ID=""Gross""><AggregateFunction>Sum</AggregateFunction><Caption" & _
        ">Gross Profit</Caption><DataMember>Gross</DataMember><EditType>NoEdit</EditType>" & _
        "<FormatString>c2</FormatString><Key>Gross</Key><Position>5</Position><TotalForma" & _
        "tString>c2</TotalFormatString></Column5><Column6 ID=""GrossDarsad""><AggregateFunc" & _
        "tion>Average</AggregateFunction><Caption>Gross Profit %</Caption><DataMember>Gro" & _
        "ssDarsad</DataMember><EditType>NoEdit</EditType><FormatString>###.## %</FormatSt" & _
        "ring><Key>GrossDarsad</Key><Position>6</Position><TotalFormatString>###.## %</To" & _
        "talFormatString></Column6></Columns><GroupCondition ID="""" /><SortKeys Collection" & _
        "=""true""><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex></SortKey0></SortKeys></Ro" & _
        "otTable></GridEXLayoutData>"
        Me.GrdStore.DesignTimeLayout = GridEXLayout3
        Me.GrdStore.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdStore.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdStore.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdStore.Location = New System.Drawing.Point(-1, 65)
        Me.GrdStore.Name = "GrdStore"
        Me.GrdStore.Size = New System.Drawing.Size(701, 344)
        Me.GrdStore.TabIndex = 11
        Me.GrdStore.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'FrmPrintTraffic
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(700, 408)
        Me.Controls.Add(Me.GrdStore)
        Me.Controls.Add(Me.GrdSummery)
        Me.Controls.Add(Me.GrdList)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = True
        Me.Name = "FrmPrintTraffic"
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPrintTraffic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdStore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        NewCustomerList = 1


        InactiveCusList = 2

        FrequencyAnalysisList = 3

        StoreTrafficAnalysis = 4

    End Enum
    Public SpendAmount As Integer
    Public CountInvoice As Integer
    Public KindOfReport As KindReport
    Public StrWhere As String
    Public StrFilter As String
    Public DSMain As New DataSet
    Public FEmp As Boolean
    Public Fpos As Boolean
    Public Date1 As String
    Public Date2 As String
    Dim ComName As String = SystemInformation.ComputerName
    Private Sub FrmPrintTraffic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        'CnnReader.ConnectionString = PConnectionString

        ' CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        Select Case KindOfReport
            Case KindReport.NewCustomerList
                Call FillNewCusList()
                If Date1.Trim.Length > 0 Then
                    GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
                Else
                    GridEXPrintDocument1.PageHeaderCenter = Me.Text
                End If
                GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")

            Case KindReport.InactiveCusList
                Call FillInactiveCus()
                If Date1.Trim.Length > 0 Then
                    GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & vbNewLine & Me.Text()
                Else
                    GridEXPrintDocument1.PageHeaderCenter = Me.Text
                End If
                GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")

            Case KindOfReport.FrequencyAnalysisList
                Call FillCusSummery()
                If Date1.Trim.Length > 0 Then
                    GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
                Else
                    GridEXPrintDocument1.PageHeaderCenter = Me.Text
                End If
                GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
            Case KindReport.StoreTrafficAnalysis
                Call FillStoreTraffic()
                If Date1.Trim.Length > 0 Then
                    GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & vbNewLine & Me.Text()
                Else
                    GridEXPrintDocument1.PageHeaderCenter = Me.Text
                End If
                GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")

        End Select

    End Sub
    Private Sub FillNewCusList()

        DAList.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
"                       cust_company.complete_name, bas_zipcode.city, cust_trtab_main.zip,  " & _
"                       CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
"                        = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1, Since.CustSince, cust_tab_type.desc_type,  " & _
"                       cust_tab_source.desc_source, 1 AS flag, cust_trtab_main.address " & _
" FROM         cust_trtab_main LEFT OUTER JOIN " & _
"                       bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode LEFT OUTER JOIN " & _
"                       cust_tab_source ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN " & _
"                       cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
"                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
"                           (SELECT     dbo.changedatetonormal(MIN(dbo.changedate(Date_Refer))) AS CustSince, service_center_head.cod_customer " & _
"                              FROM         service_center_head " & _
"                              WHERE     type_of_form = 'IN' " & _
"                              GROUP BY service_center_head.cod_customer) Since ON cust_trtab_main.cod_customer = Since.cod_customer " & IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "")



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If
        Try
            DAList.Fill(DsFrmPrintTraffic1.List)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        GrdList.SetDataBinding(DsFrmPrintTraffic1.List, "")

        GrdList.BringToFront()
    End Sub
    Private Sub FillInactiveCus()

        DAList.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
"                       cust_company.complete_name, bas_zipcode.city, cust_trtab_main.zip,  " & _
"                       CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
"                        = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1,last.LastVisit as CustSince, cust_tab_type.desc_type,  " & _
"                       cust_tab_source.desc_source, 1 AS flag, cust_trtab_main.address " & _
" FROM         cust_trtab_main LEFT OUTER JOIN " & _
"                       bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode LEFT OUTER JOIN " & _
"                       cust_tab_source ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN " & _
"                       cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
"                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
"                           (SELECT     dbo.changedatetonormal(MAX(dbo.changedate(Date_Refer))) AS LastVisit, service_center_head.cod_customer " & _
"                              FROM         service_center_head " & _
"                              WHERE     type_of_form = 'IN' " & _
"                              GROUP BY service_center_head.cod_customer) last ON cust_trtab_main.cod_customer = last.cod_customer " & IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "")



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If
        Try
            DAList.Fill(DsFrmPrintTraffic1.List)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        GrdList.RootTable.Columns(9).Caption = "Last Visit"
        GrdList.SetDataBinding(DsFrmPrintTraffic1.List, "")

        GrdList.BringToFront()
    End Sub
    Private Sub FillCusSummery()

        Dim sView As String = " CREATE VIEW dbo.View_CustSale_" & ComName & _
                  " AS " & _
                  " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        "                       cust_company.complete_name,  service_center_head.id_service_center, service_center_head.Total,  " & _
        "                       CASE WHEN cust_company.complete_name IS NULL  " & _
        "                       THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        "                       + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, ISNULL " & _
        "                          ((SELECT     ROUND(SUM(ISNULL(ROUND(service_center_dtl.qty,2), 0) * (ISNULL(ROUND(inv_item_cost_transaction.cost,2), 0) + ISNULL(ROUND(service_center_dtl.fet,2), 0))), 2) " & _
        "                               FROM          service_center_dtl LEFT OUTER JOIN " & _
        "                                                      inv_item_cost_transaction ON service_center_dtl.cod_select = inv_item_cost_transaction.item_no " & _
        "                               WHERE      service_center_dtl.type_select <> 'O' AND (inv_item_cost_transaction.last_flag = 1) AND  " & _
        "                                                      service_center_dtl.id_service_center = service_center_head.id_service_center), 0) + ISNULL " & _
        "                           ((SELECT     ISNULL(SUM(ROUND((ROUND(service_out_purchases.cost, 2) + ROUND(service_center_dtl.fet, 2)) * service_center_dtl.qty, 2)), 0) " & _
        "                               FROM          service_center_dtl INNER JOIN " & _
        "                                                      service_out_purchases ON service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
        "                                                      service_center_dtl.radif = service_out_purchases.radif " & _
        "                               WHERE      service_center_dtl.id_service_center = service_center_head.id_service_center), 0) - isnull(( SELECT  SUM(qty * (price + fet)) FROM   dbo.service_center_dtl   WHERE     (type_select = 'T') and service_center_dtl.id_service_center = service_center_head.id_service_center ),0)  AS Ext_Cost " & _
        " FROM         service_center_head LEFT OUTER JOIN " & _
        "                       cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
        "                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
      " WHERE   (service_center_head.type_of_form = 'IN') and       service_center_head.id_service_center  not in (SELECT      id_service_center " & _
                 "       FROM service_center_dtl " & _
                 " WHERE     (type_select = 'B')) " & IIf(StrWhere.Length > 0, " and " & StrWhere, "") & _
        " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name,  " & _
        "                       service_center_head.id_service_center, service_center_head.Total "

        Dim CmdGeneral As New SqlClient.SqlCommand(sView, Cnn)

        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If

            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

            Try
                CmdGeneral.CommandText = " drop view [dbo].[View_CustSale_" & ComName & "] "
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()

                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.CommandText = sView
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()
            Catch ex1 As Exception

            End Try

        End Try



        DASummery.SelectCommand.CommandText = " SELECT     cod_customer,f_name, name, complete_name, COUNT(id_service_center) AS NoInvoice,1 as flag, SUM(ROUND(ISNULL(Total, 0), 2)) AS amount, OrderName, " & _
                      " SUM(ROUND(ISNULL(Ext_Cost, 0), 2)) AS Ext_Cost " & _
             " FROM  View_CustSale_" & ComName & _
            " GROUP BY cod_customer, name, complete_name, OrderName,f_name " & _
        " HAVING      (COUNT(id_service_center) > " & CountInvoice & ") AND (SUM(ROUND(ISNULL(Total, 0), 2)) > " & SpendAmount & ")"


        DASummery.Fill(DsFrmPrintTraffic1.Summery)



        Try
            CmdGeneral.CommandText = " drop view [dbo].[View_CustSale_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try


        'DsFrmprint1.Summery.DefaultView.RowFilter = " FlagSale = true and  flagTer = true and  FlagClass = true and Flagsource = true and  FlagType= true and FLAGCUST = true  "
        GrdSummery.SetDataBinding(DsFrmPrintTraffic1.Summery, "")


        GrdSummery.BringToFront()

    End Sub
    Private Sub FillStoreTraffic()
        '        DAList.SelectCommand.CommandText = " SELECT     service_center_head.date_refer AS date, ISNULL(SUM(service_center_dtl.qty), 0) AS qty, ISNULL(SUM(service_center_dtl.price), 0) AS unit_price,  " & _
        '"                       ISNULL(SUM(service_center_dtl.fet), 0) AS fet, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  " & _
        '"                       + ISNULL(service_center_dtl.fet, 0))) AS ext_price, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0)  " & _
        '"                       + ISNULL(service_center_dtl.fet, 0))) AS ext_cost, 1 AS flag, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  " & _
        '"                       + ISNULL(service_center_dtl.fet, 0))) - SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0)  " & _
        '"                       + ISNULL(service_center_dtl.fet, 0))) AS Gross, (SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  " & _
        '"                       + ISNULL(service_center_dtl.fet, 0))) - SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0)  " & _
        '"                       + ISNULL(service_center_dtl.fet, 0)))) / SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0)  " & _
        '"                       + ISNULL(service_center_dtl.fet, 0))) * 100 AS GrossDarsad, COUNT(service_center_head.id_service_center) AS NoInvoice " & _
        '" FROM         inv_item_cost_transaction INNER JOIN " & _
        '"                       inv_item INNER JOIN " & _
        '"                       service_center_dtl INNER JOIN " & _
        '"                       service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center ON  " & _
        '"                       inv_item.item_no = service_center_dtl.cod_select ON inv_item_cost_transaction.item_no = inv_item.item_no " & _
        '" WHERE     (service_center_head.type_of_form = 'IN')  " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & _
        '" GROUP BY service_center_head.date_refer "



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If

        Dim sView As String = " CREATE VIEW dbo.View_CustStore_" & ComName & _
                " AS " & _
               " SELECT     service_center_head.date_refer, ISNULL(ROUND(SUM(ROUND(service_center_dtl.qty * (ROUND(inv_item_cost_transaction.cost, 2)  " & _
"                       + ROUND(inv_item_cost_transaction.delivery, 2) + ROUND(inv_item_cost_transaction.frieght, 2) + ROUND(service_center_dtl.fet, 2)), 2)), 2), 0)   AS cost " & _
", SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  + ISNULL(service_center_dtl.fet, 0))) AS price " & _
"FROM         service_center_dtl INNER JOIN " & _
"                       service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
"                       inv_item_cost_transaction ON service_center_dtl.cod_select = inv_item_cost_transaction.item_no " & _
" WHERE     (service_center_dtl.type_select = 'I') AND (service_center_head.type_of_form = 'IN') OR " & _
"                       (service_center_dtl.type_select = 'A') AND (service_center_head.type_of_form = 'IN') AND (inv_item_cost_transaction.last_flag = 1) " & _
" GROUP BY service_center_head.date_refer " & _
" UNION " & _
" SELECT     service_center_head.date_refer, ISNULL(SUM(ROUND(ROUND(inv_tab_labor_service.cost, 2) * service_center_dtl.qty, 2)), 0) AS cost " & _
" , SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  + ISNULL(service_center_dtl.fet, 0))) AS price " & _
" FROM         service_center_dtl INNER JOIN " & _
"                       service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN " & _
"                       inv_tab_labor_service ON service_center_dtl.cod_select = inv_tab_labor_service.cod_service " & _
" WHERE     (service_center_dtl.type_select = 'L' OR " & _
"                       service_center_dtl.type_select = 'S' OR " & _
"                       service_center_dtl.type_select = 'F') AND (service_center_head.type_of_form = 'IN') " & _
" GROUP BY service_center_head.date_refer " & _
" UNION " & _
" SELECT     service_center_head.date_refer, ISNULL(SUM(ROUND((ROUND(service_out_purchases.cost, 2) + ROUND(service_out_purchases.fet, 2))  " & _
"                       * service_center_dtl.qty, 2)), 0) AS cost , SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  + ISNULL(service_center_dtl.fet, 0))) AS price " & _
" FROM         service_center_dtl INNER JOIN " & _
"                       service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
"                       service_out_purchases ON service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
"                       service_center_dtl.radif = service_out_purchases.radif " & _
" WHERE     (service_center_dtl.type_select = 'O') AND (service_center_head.type_of_form = 'IN') " & _
" GROUP BY service_center_head.date_refer " & _
" UNION " & _
" SELECT     service_center_head.date_refer, - ISNULL(ROUND(SUM(service_center_dtl.qty * (ROUND(service_center_dtl.price, 2) + ROUND(service_center_dtl.fet, " & _
"                        2))), 2), 0) AS cost ,  SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  + ISNULL(service_center_dtl.fet, 0))) AS price " & _
" FROM         service_center_dtl INNER JOIN " & _
"                       service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center " & _
" WHERE     (service_center_dtl.type_select = 'T') AND (service_center_head.type_of_form = 'IN') " & _
" GROUP BY service_center_dtl.qty, service_center_head.date_refer "

        Dim CmdGeneral As New SqlClient.SqlCommand(sView, Cnn)

        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If

            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

            Try
                CmdGeneral.CommandText = " drop view [dbo].[View_CustStore_" & ComName & "] "
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()

                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.CommandText = sView
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()
            Catch ex1 As Exception

            End Try

        End Try



        '        DAList.SelectCommand.CommandText = " SELECT     date_refer, SUM(NoInvoice) AS NoInvoice, SUM(price) AS price, SUM(cost) AS cost,1 as flag, SUM(price) - SUM(cost) AS gross, (SUM(price) - SUM(cost))  / SUM(price) AS GrossDarsad " & _
        '" FROM         View_CustStore_" & ComName & _
        ' IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "") & _
        '" GROUP BY date_refer " 

        '''''' ******** NoInvoice adad dorost nadasht majboor shodam az dakhel view daresh biaram
        DAList.SelectCommand.CommandText = " SELECT     View_CustStore_" & ComName & ".date_refer,service_center_head.NoInvoice, SUM(View_CustStore_" & ComName & ".price) AS price,  " & _
"                       SUM(View_CustStore_" & ComName & ".cost) AS cost, 1 AS flag, SUM(View_CustStore_" & ComName & ".price) - SUM(View_CustStore_" & ComName & ".cost) AS gross, " & _
"                       (SUM(View_CustStore_" & ComName & ".price) - SUM(View_CustStore_" & ComName & ".cost)) / SUM(View_CustStore_" & ComName & ".price) AS GrossDarsad " & _
" FROM        View_CustStore_" & ComName & " INNER JOIN " & _
"                           (SELECT     COUNT(id_service_center) AS NoInvoice, date_refer " & _
"                              FROM         service_center_head " & _
"                              WHERE     (type_of_form = 'IN') " & _
"                              GROUP BY date_refer) service_center_head ON View_CustStore_" & ComName & ".date_refer = service_center_head.date_refer " & _
  IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "") & _
        " GROUP BY View_CustStore_" & ComName & ".date_refer,service_center_head.NoInvoice "

        Try
            DAList.Fill(DsFrmPrintTraffic1.StoreTraffic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            CmdGeneral.CommandText = " drop view [dbo].[View_CustStore_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try
        '  GrdList.SetDataBinding(DsFrmPrintTraffic1.List, "")

        GrdStore.BringToFront()
    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case KindOfReport
            Case KindReport.StoreTrafficAnalysis
                Me.GrdStore.ShowFieldChooser(Me)
            Case KindReport.FrequencyAnalysisList
                Me.GrdSummery.ShowFieldChooser(Me)
            Case KindReport.NewCustomerList, KindReport.InactiveCusList
                Me.GrdList.ShowFieldChooser(Me)

        End Select

    End Sub

    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        Select Case KindOfReport
            Case KindReport.StoreTrafficAnalysis
                GridEXPrintDocument1.GridEX = GrdStore
                'Case KindReport.customerSaleSummery
                '    GridEXPrintDocument1.GridEX = GrdSummery
            Case KindReport.NewCustomerList, KindReport.InactiveCusList
                GridEXPrintDocument1.GridEX = GrdList
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
            Case KindReport.StoreTrafficAnalysis
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdStore)
            Case KindReport.FrequencyAnalysisList
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdSummery)
            Case KindReport.NewCustomerList, KindReport.InactiveCusList
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdList)

        End Select

    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case KindOfReport
            Case KindReport.StoreTrafficAnalysis
                For i As Integer = 0 To DsFrmPrintTraffic1.StoreTraffic.Count - 1
                    DsFrmPrintTraffic1.StoreTraffic(i).flag = False
                Next
            Case KindReport.FrequencyAnalysisList
                For i As Integer = 0 To DsFrmPrintTraffic1.Summery.Count - 1
                    DsFrmPrintTraffic1.Summery(i).flag = False
                Next
            Case KindReport.NewCustomerList, KindReport.InactiveCusList
                For i As Integer = 0 To DsFrmPrintTraffic1.List.Count - 1
                    DsFrmPrintTraffic1.List(i).flag = False
                Next
        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case KindOfReport
            Case KindReport.StoreTrafficAnalysis
                For i As Integer = 0 To DsFrmPrintTraffic1.StoreTraffic.Count - 1
                    DsFrmPrintTraffic1.StoreTraffic(i).flag = True
                Next
            Case KindReport.FrequencyAnalysisList
                For i As Integer = 0 To DsFrmPrintTraffic1.Summery.Count - 1
                    DsFrmPrintTraffic1.Summery(i).flag = True
                Next
            Case KindReport.NewCustomerList
                For i As Integer = 0 To DsFrmPrintTraffic1.List.Count - 1
                    DsFrmPrintTraffic1.List(i).flag = True
                Next

        End Select
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub
    Dim x As Integer = 0
    Private Sub GridEXPrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles GridEXPrintDocument1.PrintPage
        x = x + 1
        GridEXPrintDocument1.PageFooterRight = x
    End Sub
    Private Sub GridEXPrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GridEXPrintDocument1.EndPrint
        x = 0
    End Sub
End Class
