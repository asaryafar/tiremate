Imports CommonClass
Imports Janus.Windows.GridEX

Public Class FrmPrint
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
    Friend WithEvents DsFrmprint1 As ReportCustomer.DSFrmprint
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
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDAUserId As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DADetail As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DASummery As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAList As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdList As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrint))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DADetail = New System.Data.SqlClient.SqlDataAdapter
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.DsFrmprint1 = New ReportCustomer.DSFrmprint
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
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDAUserId = New System.Data.OleDb.OleDbDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DASummery = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdSummery = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAList = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdList = New Janus.Windows.GridEX.GridEX
        CType(Me.DsFrmprint1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_ma" & _
        "in.m_name + ' ' + cust_trtab_main.l_name AS name, cust_company.complete_name, se" & _
        "rvice_center_head.date_refer, service_center_head.id_service_center, service_cen" & _
        "ter_head.Total, ser_tr_vehicle.license_no_vehicle, service_center_head.add_user," & _
        " cust_tab_type.desc_type, cust_tab_source.desc_source, cust_tab_class.desc_class" & _
        ", cust_tab_territory.desc_territory, 1 AS flag, cust_tab_type.cod_type, cust_tab" & _
        "_source.cod_source, cust_tab_class.cod_class, cust_tab_territory.cod_territory, " & _
        "cust_trtab_main.cod_sales_rep FROM cust_trtab_main LEFT OUTER JOIN cust_tab_clas" & _
        "s ON cust_trtab_main.cod_class = cust_tab_class.cod_class RIGHT OUTER JOIN servi" & _
        "ce_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_custome" & _
        "r LEFT OUTER JOIN ser_tr_vehicle ON service_center_head.id_vehicle = ser_tr_vehi" & _
        "cle.id_vehicle LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cus" & _
        "t_company.cod_company LEFT OUTER JOIN employee ON cust_trtab_main.cod_sales_rep " & _
        "= employee.employee_code LEFT OUTER JOIN cust_tab_type ON cust_trtab_main.cod_ty" & _
        "pe = cust_tab_type.cod_type LEFT OUTER JOIN cust_tab_territory ON cust_trtab_mai" & _
        "n.cod_territory = cust_tab_territory.cod_territory LEFT OUTER JOIN cust_tab_sour" & _
        "ce ON cust_trtab_main.cod_source = cust_tab_source.cod_source WHERE (service_cen" & _
        "ter_head.type_of_form = 'IN')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=ARMANDEHserver;persis" & _
        "t security info=True;initial catalog=TireMate_05"
        '
        'DADetail
        '
        Me.DADetail.SelectCommand = Me.SqlSelectCommand1
        Me.DADetail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value"), New System.Data.Common.DataColumnMapping("Line", "Line")})})
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""F:\TireMate.mdb"";Mode=Share Deny None;Jet OLEDB:Engin" & _
        "e Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB" & _
        ":SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Wi" & _
        "thout Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create Sys" & _
        "tem Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Je" & _
        "t OLEDB:Global Bulk Transactions=1"
        '
        'DsFrmprint1
        '
        Me.DsFrmprint1.DataSetName = "DSFrmprint"
        Me.DsFrmprint1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        Me.Panel4.Size = New System.Drawing.Size(608, 64)
        Me.Panel4.TabIndex = 5
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
        'GrdDetail
        '
        Me.GrdDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.DataMember = "Detail"
        Me.GrdDetail.DataSource = Me.DsFrmprint1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>23</Width></Column0><Column1 ID" & _
        "=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_cust" & _
        "omer</Key><Position>1</Position><Width>77</Width></Column1><Column2 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>f_name</Key><Position>2</Pos" & _
        "ition><Width>87</Width></Column2><Column3 ID=""name""><Caption>Last Name</Caption>" & _
        "<DataMember>name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>name</Key><Position>3</Position><Width>96</Width></Column3>" & _
        "<Column4 ID=""complete_name""><Caption>Company</Caption><DataMember>complete_name<" & _
        "/DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><" & _
        "Key>complete_name</Key><Position>4</Position><Width>137</Width></Column4><Column" & _
        "5 ID=""date_refer""><Caption>Date</Caption><DataMember>date_refer</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>MM/" & _
        "dd/yyyy</FormatString><Key>date_refer</Key><Position>5</Position><Width>70</Widt" & _
        "h></Column5><Column6 ID=""id_service_center""><AggregateFunction>Count</AggregateF" & _
        "unction><Caption>Ref. No</Caption><DataMember>id_service_center</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>id_service_c" & _
        "enter</Key><Position>6</Position><Width>77</Width><TotalFormatMode>UseStringForm" & _
        "at</TotalFormatMode><TotalFormatString>({0} Invoices)</TotalFormatString></Colum" & _
        "n6><Column7 ID=""Total""><AggregateFunction>Sum</AggregateFunction><Caption>Amount" & _
        "</Caption><DataMember>Total</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><FormatString>C2</FormatString><Key>Total</Key><Posit" & _
        "ion>7</Position><TextAlignment>Far</TextAlignment><Width>77</Width><TotalFormatS" & _
        "tring>C2</TotalFormatString></Column7><Column8 ID=""Ext_Cost""><AggregateFunction>" & _
        "Sum</AggregateFunction><Caption>Cost</Caption><DataMember>Ext_Cost</DataMember><" & _
        "EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>" & _
        "c2</FormatString><Key>Ext_Cost</Key><Position>8</Position><Width>76</Width><Tota" & _
        "lFormatString>c2</TotalFormatString></Column8><Column9 ID=""license_no_vehicle""><" & _
        "Caption>Vehicle</Caption><DataMember>license_no_vehicle</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>TextBox</FilterEditType><Key>license_no_vehicle</" & _
        "Key><Position>9</Position><Width>68</Width></Column9><Column10 ID=""add_user""><Ca" & _
        "ption>Written By</Caption><DataMember>add_user</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>add_user</Key><Position>10</P" & _
        "osition><Width>69</Width></Column10><Column11 ID=""desc_type""><Caption>Type</Capt" & _
        "ion><DataMember>desc_type</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><Key>desc_type</Key><Position>11</Position><Width>75</W" & _
        "idth></Column11><Column12 ID=""desc_source""><Caption>Source</Caption><DataMember>" & _
        "desc_source</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><Key>desc_source</Key><Position>12</Position><Width>82</Width></Colum" & _
        "n12><Column13 ID=""desc_class""><Caption>Class</Caption><DataMember>desc_class</Da" & _
        "taMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key" & _
        ">desc_class</Key><Position>13</Position><Width>83</Width></Column13><Column14 ID" & _
        "=""desc_territory""><Caption>Territory</Caption><DataMember>desc_territory</DataMe" & _
        "mber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>des" & _
        "c_territory</Key><Position>14</Position><Width>87</Width></Column14></Columns><G" & _
        "roupCondition ID="""" /><Groups Collection=""true""><Group0 ID=""Group0""><ColIndex>1<" & _
        "/ColIndex></Group0></Groups></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(610, 304)
        Me.GrdDetail.TabIndex = 6
        Me.GrdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(111, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GrdDetail
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Users.UserId, Users.UserLogin FROM (Users INNER JOIN UserGroup ON Users.Us" & _
        "erGroupId = UserGroup.UserGroupId) WHERE (Users.UserActiveFalg <> 0) AND (UserGr" & _
        "oup.GroupActiveFlag <> 0)"
        Me.OleDbSelectCommand1.Connection = Me.CnnUserMDB
        '
        'OleDAUserId
        '
        Me.OleDAUserId.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDAUserId.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserName", "UserName")})})
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
        'DASummery
        '
        Me.DASummery.SelectCommand = Me.SqlSelectCommand2
        Me.DASummery.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form")})})
        '
        'GrdSummery
        '
        Me.GrdSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSummery.DataMember = "Summery"
        Me.GrdSummery.DataSource = Me.DsFrmprint1
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
        "5 ID=""amount""><AggregateFunction>Sum</AggregateFunction><Caption>Amount</Caption" & _
        "><DataMember>amount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><FormatString>c2</FormatString><Key>amount</Key><Position>5</" & _
        "Position><TextAlignment>Far</TextAlignment><Width>125</Width><TotalFormatString>" & _
        "C2</TotalFormatString></Column5><Column6 ID=""NoInvoice""><AggregateFunction>Sum</" & _
        "AggregateFunction><Caption>No Of Invoice</Caption><DataMember>NoInvoice</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>NoIn" & _
        "voice</Key><Position>6</Position><Width>86</Width></Column6><Column7 ID=""Ext_Cos" & _
        "t""><AggregateFunction>Sum</AggregateFunction><Caption>Cost</Caption><DataMember>" & _
        "Ext_Cost</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><FormatString>c2</FormatString><Key>Ext_Cost</Key><Position>7</Position>" & _
        "<TextAlignment>Far</TextAlignment><TotalFormatString>c2</TotalFormatString></Col" & _
        "umn7></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdSummery.DesignTimeLayout = GridEXLayout2
        Me.GrdSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdSummery.Name = "GrdSummery"
        Me.GrdSummery.Size = New System.Drawing.Size(610, 304)
        Me.GrdSummery.TabIndex = 7
        Me.GrdSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
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
        'DAList
        '
        Me.DAList.SelectCommand = Me.SqlSelectCommand3
        Me.DAList.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'GrdList
        '
        Me.GrdList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdList.DataMember = "List"
        Me.GrdList.DataSource = Me.DsFrmprint1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
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
        "h>84</Width></Column9><Column10 ID=""LastVisit""><Caption>Last Visit</Caption><Dat" & _
        "aMember>LastVisit</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>LastVisit</Key><Pos" & _
        "ition>10</Position><Width>76</Width></Column10><Column11 ID=""desc_type""><Caption" & _
        ">Type</Caption><DataMember>desc_type</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><Key>desc_type</Key><Position>11</Position><" & _
        "Width>40</Width></Column11><Column12 ID=""desc_source""><Caption>Source</Caption><" & _
        "DataMember>desc_source</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><Key>desc_source</Key><Position>12</Position><Width>47</Wi" & _
        "dth></Column12><Column13 ID=""desc_class""><Caption>Class</Caption><DataMember>des" & _
        "c_class</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>desc_class</Key><Position>13</Position><Width>50</Width></Column13><" & _
        "Column14 ID=""desc_territory""><Caption>Territory</Caption><DataMember>desc_territ" & _
        "ory</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>desc_territory</Key><Position>14</Position><Width>53</Width></Column14><" & _
        "Column15 ID=""cod_price""><Caption>Price Level</Caption><DataMember>cod_price</Dat" & _
        "aMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>" & _
        "cod_price</Key><Position>15</Position></Column15><Column16 ID=""email""><Caption>E" & _
        "mail</Caption><DataMember>email</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>TextBox</FilterEditType><Key>email</Key><Position>16</Position></Column16" & _
        "></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdList.DesignTimeLayout = GridEXLayout3
        Me.GrdList.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdList.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdList.Location = New System.Drawing.Point(0, 64)
        Me.GrdList.Name = "GrdList"
        Me.GrdList.Size = New System.Drawing.Size(610, 304)
        Me.GrdList.TabIndex = 8
        '
        'FrmPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 364)
        Me.Controls.Add(Me.GrdList)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdSummery)
        Me.Controls.Add(Me.GrdDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "FrmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DsFrmprint1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        customerSaleDetail = 1
        customerSaleSummery = 2
        CustomerListing = 3
    End Enum
    Public KindOfReport As KindReport
    Public StrWhere As String
    Public StrFilter As String
    Public DSMain As New DataSet
    Public FCus As Boolean
    Public FType As Boolean
    Public FSource As Boolean
    Public FTer As Boolean
    Public FClass As Boolean
    Public FSale As Boolean
    Public Date1 As String
    Public Date2 As String
    Dim ComName As String = SystemInformation.ComputerName

    Private Sub FrmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        'CnnReader.ConnectionString = PConnectionString
  
        CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        Select Case KindOfReport
            Case KindReport.customerSaleDetail
                Call FillCusDetail()
                If Date1.Trim.Length > 0 Then
                    GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
                Else
                    GridEXPrintDocument1.PageHeaderCenter = Me.Text
                End If
                GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")

            Case KindReport.customerSaleSummery
                Call FillCusSummery()
                If Date1.Trim.Length > 0 Then
                    GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
                Else
                    GridEXPrintDocument1.PageHeaderCenter = Me.Text
                End If
                GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")

            Case KindReport.CustomerListing
                Call FillCusList()
                GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End Select
      
    End Sub
    Private Sub FillCusDetail()
        'Dim st As String
        'st = IIf(FCus, ",0 as FLAGCUST ", ",1 as FLAGCUST ")
        'st = st & IIf(FType, ", 0 as flagtype ", ", 1 as flagtype")
        'st = st & IIf(FSource, ", 0 as flagsource ", ", 1 as flagsource")
        'st = st & IIf(FClass, ", 0 as flagclass ", ", 1 as flagclass")
        'st = st & IIf(FTer, ", 0 as flagter ", ", 1 as flagter")
        'st = st & IIf(FSale, ", 0 as flagsale ", ", 1 as flagsale")

        OleDAUserId.Fill(DsFrmprint1.Users)
        ''add order name by fatraji
        'DADetail.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '              " cust_company.complete_name, service_center_head.date_refer, service_center_head.id_service_center, service_center_head.Total,  " & _
        '              " ser_tr_vehicle.license_no_vehicle, service_center_head.add_user, cust_tab_type.desc_type, cust_tab_source.desc_source,  " & _
        '              " cust_tab_class.desc_class, cust_tab_territory.desc_territory, 1 AS flag, cust_tab_type.cod_type, cust_tab_source.cod_source,  " & _
        '              " cust_tab_class.cod_class, cust_tab_territory.cod_territory, cust_trtab_main.cod_sales_rep ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        '              " , SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0) + ISNULL(service_center_dtl.fet, 0))) AS Ext_Cost " & _
        '              " FROM         service_center_head INNER JOIN " & _
        '              " service_center_dtl ON service_center_dtl.id_service_center = service_center_head.id_service_center  LEFT OUTER JOIN " & _
        '              " inv_item_cost_transaction ON service_center_dtl.cod_select = inv_item_cost_transaction.item_no LEFT OUTER JOIN " & _
        '              " cust_trtab_main LEFT OUTER JOIN " & _
        '              " cust_tab_class ON cust_trtab_main.cod_class = cust_tab_class.cod_class ON  " & _
        '              " service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
        '              " ser_tr_vehicle ON service_center_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN " & _
        '              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
        '              " employee ON cust_trtab_main.cod_sales_rep = employee.employee_code LEFT OUTER JOIN " & _
        '              " cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
        '              " cust_tab_territory ON cust_trtab_main.cod_territory = cust_tab_territory.cod_territory LEFT OUTER JOIN " & _
        '              " cust_tab_source ON cust_tab_source.cod_source = cust_trtab_main.cod_source " & _
        '              " WHERE     (service_center_head.type_of_form = 'IN') " & IIf(StrWhere.Length > 0, " and " & StrWhere, "") & _
        '              " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name, " & _
        '              " service_center_head.date_refer, service_center_head.id_service_center, service_center_head.Total, ser_tr_vehicle.license_no_vehicle,  " & _
        '              " service_center_head.add_user, cust_tab_type.desc_type, cust_tab_source.desc_source, cust_tab_class.desc_class, cust_tab_territory.desc_territory,  " & _
        '              " cust_tab_type.cod_type, cust_tab_source.cod_source, cust_tab_class.cod_class, cust_tab_territory.cod_territory, cust_trtab_main.cod_sales_rep "
        '' (inv_item_cost_transaction.last_flag = 1) and 

        DADetail.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
"                       cust_company.complete_name, service_center_head.date_refer, service_center_head.id_service_center, service_center_head.Total,  " & _
"                       ser_tr_vehicle.license_no_vehicle, service_center_head.add_user, cust_tab_type.desc_type, cust_tab_source.desc_source,  " & _
"                       cust_tab_class.desc_class, cust_tab_territory.desc_territory, 1 AS flag, cust_tab_type.cod_type, cust_tab_source.cod_source,  " & _
"                       cust_tab_class.cod_class, cust_tab_territory.cod_territory, cust_trtab_main.cod_sales_rep, CASE WHEN cust_company.complete_name IS NULL  " & _
"                       THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
"                       + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, " & _
"                        ( isnull((SELECT     SUM(ISNULL(ROUND(service_center_dtl.qty,2), 0) * (ISNULL(ROUND(inv_item_cost_transaction.cost,2), 0) + ISNULL(ROUND(service_center_dtl.fet,2), 0))) " & _
"                              FROM         service_center_dtl LEFT OUTER JOIN " & _
"                                                    inv_item_cost_transaction ON service_center_dtl.cod_select = inv_item_cost_transaction.item_no " & _
"                              WHERE    service_center_dtl.type_select <> 'O' and (inv_item_cost_transaction.last_flag = 1) AND service_center_dtl.id_service_center = service_center_head.id_service_center),0) + " & _
"   isnull((SELECT     ISNULL(SUM(ROUND((ROUND(service_out_purchases.cost, 2) + ROUND(service_center_dtl.fet, 2)) * service_center_dtl.qty, 2)), 0) " & _
                             " FROM         service_center_dtl INNER JOIN  " & _
         " service_out_purchases ON service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
        " service_center_dtl.radif = service_out_purchases.radif " & _
                             " WHERE     service_center_dtl.id_service_center = service_center_head.id_service_center),0)) - isnull(( SELECT  SUM(qty * (price + fet)) FROM   dbo.service_center_dtl   WHERE     (type_select = 'T') and service_center_dtl.id_service_center = service_center_head.id_service_center ),0)  AS Ext_Cost " & _
" FROM         service_center_head LEFT OUTER JOIN " & _
"                       cust_trtab_main LEFT OUTER JOIN " & _
"                       cust_tab_class ON cust_trtab_main.cod_class = cust_tab_class.cod_class ON  " & _
"                       service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
"                       ser_tr_vehicle ON service_center_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN " & _
"                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
"                       employee ON cust_trtab_main.cod_sales_rep = employee.employee_code LEFT OUTER JOIN " & _
"                       cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
"                       cust_tab_territory ON cust_trtab_main.cod_territory = cust_tab_territory.cod_territory LEFT OUTER JOIN " & _
"                       cust_tab_source ON cust_tab_source.cod_source = cust_trtab_main.cod_source " & _
" WHERE   (service_center_head.type_of_form = 'IN') and       service_center_head.id_service_center  not in (SELECT      id_service_center " & _
                 "       FROM service_center_dtl " & _
                 " WHERE     (type_select = 'B')) " & IIf(StrWhere.Length > 0, " and " & StrWhere, "") & _
" GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name,  " & _
"                       service_center_head.date_refer, service_center_head.id_service_center, service_center_head.Total, ser_tr_vehicle.license_no_vehicle,  " & _
"                       service_center_head.add_user, cust_tab_type.desc_type, cust_tab_source.desc_source, cust_tab_class.desc_class, cust_tab_territory.desc_territory,  " & _
 "                       cust_tab_type.cod_type, cust_tab_source.cod_source, cust_tab_class.cod_class, cust_tab_territory.cod_territory, cust_trtab_main.cod_sales_rep,cust_trtab_main.cod_price "


        DADetail.Fill(DsFrmprint1.Detail)
        Dim str As String
        For i As Integer = 0 To DsFrmprint1.Detail.Rows.Count - 1
            If DsFrmprint1.Users.FindByUserId(DsFrmprint1.Detail(i).add_user) Is Nothing Then
                str = ""
            Else
                str = DsFrmprint1.Users.FindByUserId(DsFrmprint1.Detail(i).add_user).UserLogin
            End If
            DsFrmprint1.Detail(i).add_user = str
        Next
        GrdDetail.BringToFront()

        'If FCus Then
        '    For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
        '        If DSMain.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmprint1.Detail(i).cod_customer)).Length > 0 Then
        '            DsFrmprint1.Detail(i).FLAGCUST = 1
        '        End If
        '    Next

        'End If
        'If FType Then
        '    For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
        '        If DSMain.Tables("type").Select("flag=1 and cod = " & Qt(DsFrmprint1.Detail(i).cod_type)).Length > 0 Then
        '            DsFrmprint1.Detail(i).FlagType = 1
        '        End If
        '    Next
        'End If
        'If FSource Then
        '    For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
        '        If DSMain.Tables("source").Select("flag=1 and cod = " & Qt(DsFrmprint1.Detail(i).cod_source)).Length > 0 Then
        '            DsFrmprint1.Detail(i).Flagsource = 1
        '        End If
        '    Next
        'End If
        'If FClass Then
        '    For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
        '        If DSMain.Tables("clas").Select("flag=1 and cod = " & Qt(DsFrmprint1.Detail(i).cod_class)).Length > 0 Then
        '            DsFrmprint1.Detail(i).FlagClass = 1
        '        End If
        '    Next
        'End If
        'If FTer Then
        '    For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
        '        If DSMain.Tables("territory").Select("flag=1 and cod = " & Qt(DsFrmprint1.Detail(i).cod_territory)).Length > 0 Then
        '            DsFrmprint1.Detail(i).flagTer = 1
        '        End If
        '    Next
        'End If
        'If FSale Then
        '    For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
        '        If DSMain.Tables("employee").Select("flag=1 and cod = " & Qt(DsFrmprint1.Detail(i).cod_sales_rep)).Length > 0 Then
        '            DsFrmprint1.Detail(i).FlagSale = 1
        '        End If
        '    Next
        'End If

        'DsFrmprint1.Detail.DefaultView.RowFilter = " FlagSale = true and  flagTer = true and  FlagClass = true and Flagsource = true and  FlagType= true and FLAGCUST = true  "
        GrdDetail.SetDataBinding(DsFrmprint1.Detail, "")

    End Sub
    Private Sub FillCusSummery()
        'Dim st As String
        'st = IIf(FCus, ",0 as FLAGCUST ", ",1 as FLAGCUST ")
        'st = st & IIf(FType, ", 0 as flagtype ", ", 1 as flagtype")
        'st = st & IIf(FSource, ", 0 as flagsource ", ", 1 as flagsource")
        'st = st & IIf(FClass, ", 0 as flagclass ", ", 1 as flagclass")
        'st = st & IIf(FTer, ", 0 as flagter ", ", 1 as flagter")
        'st = st & IIf(FSale, ", 0 as flagsale ", ", 1 as flagsale")
        ' ordername by faraji
        'DASummery.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
        '              " cust_company.complete_name, SUM(service_center_head.Total) AS amount, COUNT(service_center_head.id_service_center) AS NoInvoice, " & _
        '              " 1 AS flag , cust_trtab_main.cod_type,cust_trtab_main.cod_source, " & _
        '              " cust_trtab_main.cod_class, cust_trtab_main.cod_territory, cust_trtab_main.cod_sales_rep ,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
        '              " ,ROUND(SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0) + ISNULL(service_center_dtl.fet, 0))), 2) AS Ext_Cost " & _
        '              " FROM         service_center_head INNER JOIN " & _
        '              " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer INNER JOIN " & _
        '              " service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center INNER JOIN " & _
        '              " inv_item_cost_transaction ON service_center_dtl.cod_select = inv_item_cost_transaction.item_no LEFT OUTER JOIN " & _
        '              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '              " WHERE     (service_center_head.type_of_form = 'IN') " & IIf(StrWhere.Length > 0, "and " & StrWhere, "") & _
        '              " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name, " & _
        '              " service_center_head.type_of_form , cust_trtab_main.cod_type,cust_trtab_main.cod_source, " & _
        '              " cust_trtab_main.cod_class, cust_trtab_main.cod_territory, cust_trtab_main.cod_sales_rep  "

        '        DASummery.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        '                    "  cust_company.complete_name, SUM(service_center_head.Total) AS amount, COUNT(service_center_head.id_service_center) AS NoInvoice, 1 AS flag,  " & _
        '                    "  cust_trtab_main.cod_type, cust_trtab_main.cod_source, cust_trtab_main.cod_class, cust_trtab_main.cod_territory, cust_trtab_main.cod_sales_rep,  " & _
        '                    "  CASE WHEN cust_company.complete_name IS NULL  " & _
        '                    "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        '                    "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, " & _
        '                    "     isnull( (SELECT     ROUND(SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0) + ISNULL(service_center_dtl.fet, 0))), 2) " & _
        '                    "         FROM         service_center_dtl INNER JOIN " & _
        '                    "                               service_center_head h ON service_center_dtl.id_service_center = h.id_service_center LEFT OUTER JOIN " & _
        '                    "                               inv_item_cost_transaction ON service_center_dtl.cod_select = inv_item_cost_transaction.item_no " & _
        '                    "         WHERE   service_center_dtl.type_select <> 'O' AND   (h.type_of_form = 'IN') AND (inv_item_cost_transaction.last_flag = 1) and  h.cod_customer = cust_trtab_main.cod_customer) ,0) + ISNULL " & _
        '"                           ((SELECT     ISNULL(SUM(ROUND((ROUND(service_out_purchases.cost, 2) + ROUND(service_center_dtl.fet, 2)) * service_center_dtl.qty, 2)), 0) " & _
        '"                               FROM          service_center_dtl INNER JOIN " & _
        '"                                                      service_out_purchases ON service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
        '"                                                      service_center_dtl.radif = service_out_purchases.radif INNER JOIN " & _
        '"                                                      service_center_head h ON service_center_dtl.id_service_center = h.id_service_center " & _
        '"                               WHERE     (h.type_of_form = 'IN') AND  h.cod_customer = cust_trtab_main.cod_customer), 0)  AS Ext_Cost " & _
        '                 " FROM         service_center_head INNER JOIN " & _
        '                    "  cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
        '                    "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '                 " WHERE     (service_center_head.type_of_form = 'IN') and   service_center_head.id_service_center  not in (SELECT      id_service_center " & _
        '                 "       FROM service_center_dtl " & _
        '                 " WHERE     (type_select = 'B'))  " & IIf(StrWhere.Length > 0, "and " & StrWhere, "") & _
        '                 " GROUP BY cust_trtab_main.cod_customer, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.complete_name,  " & _
        '                    "  service_center_head.type_of_form, cust_trtab_main.cod_type, cust_trtab_main.cod_source, cust_trtab_main.cod_class, cust_trtab_main.cod_territory,  " & _
        '                    "  cust_trtab_main.cod_sales_rep "

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
            " GROUP BY cod_customer, name, complete_name, OrderName,f_name "


        DASummery.Fill(DsFrmprint1.Summery)

        'If FCus Then
        '    For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
        '        If DSMain.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmprint1.Summery(i).cod_customer)).Length > 0 Then
        '            DsFrmprint1.Summery(i).FLAGCUST = 1
        '        End If
        '    Next

        'End If
        'If FType Then
        '    For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
        '        If DSMain.Tables("type").Select("flag=1 and cod = " & Qt(DsFrmprint1.Summery(i).cod_type)).Length > 0 Then
        '            DsFrmprint1.Summery(i).FlagType = 1
        '        End If
        '    Next
        'End If
        'If FSource Then
        '    For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
        '        If DSMain.Tables("source").Select("flag=1 and cod = " & Qt(DsFrmprint1.Summery(i).cod_source)).Length > 0 Then
        '            DsFrmprint1.Summery(i).Flagsource = 1
        '        End If
        '    Next
        'End If
        'If FClass Then
        '    For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
        '        If DSMain.Tables("clas").Select("flag=1 and cod = " & Qt(DsFrmprint1.Summery(i).cod_class)).Length > 0 Then
        '            DsFrmprint1.Summery(i).FlagClass = 1
        '        End If
        '    Next
        'End If
        'If FTer Then
        '    For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
        '        If DSMain.Tables("territory").Select("flag=1 and cod = " & Qt(DsFrmprint1.Summery(i).cod_territory)).Length > 0 Then
        '            DsFrmprint1.Summery(i).flagTer = 1
        '        End If
        '    Next
        'End If
        'If FSale Then
        '    For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
        '        If DSMain.Tables("employee").Select("flag=1 and cod = " & Qt(DsFrmprint1.Summery(i).cod_sales_rep)).Length > 0 Then
        '            DsFrmprint1.Summery(i).FlagSale = 1
        '        End If
        '    Next
        'End If


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
        GrdSummery.SetDataBinding(DsFrmprint1.Summery, "")


        GrdSummery.BringToFront()

    End Sub
    Private Sub FillCusList()

        'Dim st As String
        'st = IIf(FCus, ",0 as FLAGCUST ", ",1 as FLAGCUST ")
        'st = st & IIf(FType, ", 0 as flagtype ", ", 1 as flagtype")
        'st = st & IIf(FSource, ", 0 as flagsource ", ", 1 as flagsource")
        'st = st & IIf(FClass, ", 0 as flagclass ", ", 1 as flagclass")
        'st = st & IIf(FTer, ", 0 as flagter ", ", 1 as flagter")
        'st = st & IIf(FSale, ", 0 as flagsale ", ", 1 as flagsale")
        'by faraji changed
        DAList.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name , cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, " & _
                      " cust_company.complete_name, bas_zipcode.city, cust_trtab_main.zip, " & _
                      " CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
                      " = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1, Since.CustSince, last.LastVisit, cust_tab_type.desc_type,  " & _
                      " cust_tab_source.desc_source, cust_tab_class.desc_class, cust_tab_territory.desc_territory, 1 AS flag " & _
                      " ,cust_trtab_main.address,CASE WHEN cust_company.complete_name IS NULL THEN 'zzzzzzz' ELSE cust_company.complete_name END + ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName " & _
                      ",cust_trtab_main.cod_price ,cust_trtab_main.email" & _
                      " FROM         cust_trtab_main LEFT OUTER JOIN " & _
                      " cust_tab_class ON cust_trtab_main.cod_class = cust_tab_class.cod_class LEFT OUTER JOIN " & _
                      " bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode LEFT OUTER JOIN " & _
                      " cust_tab_territory ON cust_trtab_main.cod_territory = cust_tab_territory.cod_territory LEFT OUTER JOIN " & _
                      " cust_tab_source ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN " & _
                      " cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
                      " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
                      " (SELECT      dbo.changedatetonormal(MAX(dbo.changedate(Date_Refer))) AS LastVisit, service_center_head.cod_customer " & _
                      " FROM service_center_head " & _
                      " WHERE     type_of_form = 'IN' " & _
                      " GROUP BY service_center_head.cod_customer) last ON cust_trtab_main.cod_customer = last.cod_customer LEFT OUTER JOIN " & _
                       " (SELECT       dbo.changedatetonormal(MIN(dbo.changedate(Date_Refer)))  AS CustSince, service_center_head.cod_customer " & _
                       " FROM service_center_head " & _
                          " WHERE     type_of_form = 'IN' " & _
                          " GROUP BY service_center_head.cod_customer) Since ON cust_trtab_main.cod_customer = Since.cod_customer " & IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "") & _
                      " ORDER BY OrderName "



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If
        Try
            DAList.Fill(DsFrmprint1.List)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



        'If FCus Then
        '    For i As Integer = 0 To DsFrmprint1.List.Count - 1
        '        If DSMain.Tables("customer").Select("flag=1 and cod = " & Qt(DsFrmprint1.List(i).customer_no)).Length > 0 Then
        '            DsFrmprint1.List(i).FLAGCUST = 1
        '        End If
        '    Next

        'End If
        'If FType Then
        '    For i As Integer = 0 To DsFrmprint1.List.Count - 1
        '        If DSMain.Tables("type").Select("flag=1 and cod = " & Qt(DsFrmprint1.List(i).cod_type)).Length > 0 Then
        '            DsFrmprint1.List(i).FlagType = 1
        '        End If
        '    Next
        'End If
        'If FSource Then
        '    For i As Integer = 0 To DsFrmprint1.List.Count - 1
        '        If DSMain.Tables("source").Select("flag=1 and cod = " & Qt(DsFrmprint1.List(i).cod_source)).Length > 0 Then
        '            DsFrmprint1.List(i).Flagsource = 1
        '        End If
        '    Next
        'End If
        'If FClass Then
        '    For i As Integer = 0 To DsFrmprint1.List.Count - 1
        '        If DSMain.Tables("clas").Select("flag=1 and cod = " & Qt(DsFrmprint1.List(i).cod_class)).Length > 0 Then
        '            DsFrmprint1.List(i).FlagClass = 1
        '        End If
        '    Next
        'End If
        'If FTer Then
        '    For i As Integer = 0 To DsFrmprint1.List.Count - 1
        '        If DSMain.Tables("territory").Select("flag=1 and cod = " & Qt(DsFrmprint1.List(i).cod_territory)).Length > 0 Then
        '            DsFrmprint1.List(i).flagTer = 1
        '        End If
        '    Next
        'End If
        'If FSale Then
        '    For i As Integer = 0 To DsFrmprint1.List.Count - 1
        '        If DSMain.Tables("employee").Select("flag=1 and cod = " & Qt(DsFrmprint1.List(i).cod_sales_rep)).Length > 0 Then
        '            DsFrmprint1.List(i).FlagSale = 1
        '        End If
        '    Next
        'End If

        'For i As Integer = 0 To DsFrmprint1.List.Count - 1
        '    DsFrmprint1.List(i).item("OrderName") = IIf(DsFrmprint1.List(i).item("complete_name") & "" = "", "zzzzz", DsFrmprint1.List(i).item("complete_name") & "") & DsFrmprint1.List(i).item("OrderName") & "" & DsFrmprint1.List(i).item("customer_no") & ""
        'Next


        'DsFrmprint1.List.DefaultView.RowFilter = " FlagSale = true and  flagTer = true and  FlagClass = true and Flagsource = true and  FlagType= true and FLAGCUST = true  "
        GrdList.SetDataBinding(DsFrmprint1.List, "")

        GrdList.BringToFront()
    End Sub
    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case KindOfReport
            Case KindReport.customerSaleDetail
                Me.GrdDetail.ShowFieldChooser(Me)
            Case KindReport.customerSaleSummery
                Me.GrdSummery.ShowFieldChooser(Me)
            Case KindReport.CustomerListing
                Me.GrdList.ShowFieldChooser(Me)

        End Select

    End Sub

    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        Select Case KindOfReport
            Case KindReport.customerSaleDetail
                GridEXPrintDocument1.GridEX = GrdDetail
            Case KindReport.customerSaleSummery
                GridEXPrintDocument1.GridEX = GrdSummery
            Case KindReport.CustomerListing
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
            Case KindReport.customerSaleDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdDetail)
            Case KindReport.customerSaleSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdSummery)
            Case KindReport.CustomerListing
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdList)

        End Select

    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case KindOfReport
            Case KindReport.customerSaleDetail
                For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
                    DsFrmprint1.Detail(i).flag = False
                Next
            Case KindReport.customerSaleSummery
                For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
                    DsFrmprint1.Summery(i).flag = False
                Next
            Case KindReport.CustomerListing
                For i As Integer = 0 To DsFrmprint1.List.Count - 1
                    DsFrmprint1.List(i).flag = False
                Next
        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case KindOfReport
            Case KindReport.customerSaleDetail
                For i As Integer = 0 To DsFrmprint1.Detail.Count - 1
                    DsFrmprint1.Detail(i).flag = True
                Next
            Case KindReport.customerSaleSummery
                For i As Integer = 0 To DsFrmprint1.Summery.Count - 1
                    DsFrmprint1.Summery(i).flag = True
                Next
            Case KindReport.CustomerListing
                For i As Integer = 0 To DsFrmprint1.List.Count - 1
                    DsFrmprint1.List(i).flag = True
                Next

        End Select
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Select Case KindOfReport
            Case KindReport.customerSaleDetail
                Call pprintDetail("print")
            Case KindReport.customerSaleSummery
                Call pprintSummery("print")
            Case KindReport.CustomerListing
                Call pprintList("print")

        End Select

    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Select Case KindOfReport
            Case KindReport.customerSaleDetail
                Call pprintDetail("priv")
            Case KindReport.customerSaleSummery
                Call pprintSummery("priv")
            Case KindReport.CustomerListing
                Call pprintList("priv")

        End Select

    End Sub
    Private Sub pprintDetail(ByVal type As String)

        Dim rpt As New RepCusSaleDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(),  "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", "Customer Sales Report In Detail")
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmprint1)
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
    Private Sub pprintSummery(ByVal type As String)

        Dim rpt As New RepCusSaleSummery
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(),  "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", "Customer Sales Report In Summery")
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmprint1)
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
    Private Sub pprintList(ByVal type As String)
        Dim rpt As New RepCusListing
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(),  "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", " Customer Listing Report ")
        rpt.SetParameterValue("Parfilter", StrFilter)
        rpt.SetDataSource(DsFrmprint1)

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


    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        If GrdDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdDetail.GetRow

            Select Case Mid(Currentrow.Cells("id_service_center").Value, 1, 2)
                Case "IN"
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
                    MyFrmShowWorkOrder.Show()
                Case "RT"
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "RT"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
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
End Class
