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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAservice_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmPrint1 As ReportEmployee.DSFrmPrint
    Friend WithEvents GrdTechnicianDtl As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_center_Summery As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdTechnicianSummer As Janus.Windows.GridEX.GridEX
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents CmbChild As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdSale As Janus.Windows.GridEX.GridEX
    Friend WithEvents OleDAUserId As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents GrdPayroll As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrint))
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdTechnicianDtl = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPrint1 = New ReportEmployee.DSFrmPrint
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.CmbChild = New Janus.Windows.EditControls.UIButton
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_Summery = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdTechnicianSummer = New Janus.Windows.GridEX.GridEX
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdSale = New Janus.Windows.GridEX.GridEX
        Me.OleDAUserId = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.GrdPayroll = New Janus.Windows.GridEX.GridEX
        CType(Me.GrdTechnicianDtl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPrint1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GrdTechnicianSummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdTechnicianDtl
        '
        Me.GrdTechnicianDtl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdTechnicianDtl.DataMember = "service_center_dtl_Header"
        Me.GrdTechnicianDtl.DataSource = Me.DsFrmPrint1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><ChildTables Collection=""true""><Table0 ID=""Table1""><" & _
        "Columns Collection=""true""><Column0 ID=""cod_select""><Caption>Item</Caption><DataM" & _
        "ember>cod_select</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>cod_select</Key><Position>0</Position><Width>69</Width></Co" & _
        "lumn0><Column1 ID=""desc_radif""><Caption>Description</Caption><DataMember>desc_ra" & _
        "dif</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>desc_radif</Key><Position>1</Position></Column1><Column2 ID=""id_service_" & _
        "center""><Caption>Ref. No</Caption><DataMember>id_service_center</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>id_service_c" & _
        "enter</Key><Position>2</Position><Width>77</Width></Column2><Column3 ID=""date_re" & _
        "fer""><Caption>Date</Caption><DataMember>date_refer</DataMember><EditType>NoEdit<" & _
        "/EditType><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</Form" & _
        "atString><Key>date_refer</Key><Position>3</Position><Width>68</Width></Column3><" & _
        "Column4 ID=""qty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty</Caption" & _
        "><DataMember>qty</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><FormatString>#######.##</FormatString><Key>qty</Key><Position>4" & _
        "</Position><TextAlignment>Far</TextAlignment><Width>54</Width></Column4><Column5" & _
        " ID=""ext_cost""><AggregateFunction>Sum</AggregateFunction><Caption>Ext. Cost</Cap" & _
        "tion><DataMember>ext_cost</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><FormatString>c2</FormatString><Key>ext_cost</Key><Posi" & _
        "tion>5</Position><TextAlignment>Far</TextAlignment><Width>81</Width><TotalFormat" & _
        "String>c2</TotalFormatString></Column5><Column6 ID=""ext_Price""><AggregateFunctio" & _
        "n>Sum</AggregateFunction><Caption>Ext. Price</Caption><DataMember>ext_Price</Dat" & _
        "aMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Form" & _
        "atString>c2</FormatString><Key>ext_Price</Key><Position>6</Position><TextAlignme" & _
        "nt>Far</TextAlignment><Width>82</Width><TotalFormatString>c2</TotalFormatString>" & _
        "</Column6><Column7 ID=""gross""><AggregateFunction>Sum</AggregateFunction><Caption" & _
        ">Gross Profit</Caption><DataMember>gross</DataMember><EditType>NoEdit</EditType>" & _
        "<FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>gros" & _
        "s</Key><Position>7</Position><TextAlignment>Far</TextAlignment><TotalFormatStrin" & _
        "g>c2</TotalFormatString></Column7><Column8 ID=""svc""><Caption>Svc Type</Caption><" & _
        "DataMember>svc</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</F" & _
        "ilterEditType><Key>svc</Key><Position>8</Position><Width>88</Width></Column8><Co" & _
        "lumn9 ID=""cat""><Caption>Category</Caption><DataMember>cat</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cat</Key><Position" & _
        ">9</Position><Width>85</Width></Column9><Column10 ID=""type""><Caption>Item Type</" & _
        "Caption><DataMember>type</DataMember><EditType>NoEdit</EditType><FilterEditType>" & _
        "TextBox</FilterEditType><Key>type</Key><Position>10</Position><Width>92</Width><" & _
        "/Column10><Column11 ID=""line""><Caption>line</Caption><DataMember>line</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>line</" & _
        "Key><Position>11</Position><Width>81</Width></Column11></Columns><DataMember>ser" & _
        "vice_center_dtl_Headerservice_center_dtl</DataMember><GroupCondition ID="""" /><Gr" & _
        "oups Collection=""true""><Group0 ID=""Group0""><ColIndex>10</ColIndex></Group0><Grou" & _
        "p1 ID=""Group1""><ColIndex>8</ColIndex></Group1></Groups><GroupTotals>Always</Grou" & _
        "pTotals><Key>Table1</Key><TotalRow>True</TotalRow></Table0></ChildTables><Column" & _
        "s Collection=""true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMem" & _
        "ber>flag</DataMember><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Po" & _
        "sition><Width>22</Width></Column0><Column1 ID=""cod_technician""><Caption>Code</Ca" & _
        "ption><DataMember>cod_technician</DataMember><Key>cod_technician</Key><Position>" & _
        "1</Position><Width>67</Width></Column1><Column2 ID=""name""><Caption>Employee Name" & _
        "</Caption><DataMember>name</DataMember><EditType>NoEdit</EditType><FilterEditTyp" & _
        "e>TextBox</FilterEditType><Key>name</Key><Position>2</Position></Column2><Column" & _
        "3 ID=""qty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty</Caption><Data" & _
        "Member>qty</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><FormatString>#######.##</FormatString><Key>qty</Key><Position>3</Posi" & _
        "tion><TextAlignment>Far</TextAlignment><Width>86</Width></Column3><Column4 ID=""e" & _
        "xt_cost""><AggregateFunction>Sum</AggregateFunction><Caption>Ext Cost</Caption><D" & _
        "ataMember>ext_cost</DataMember><EditType>NoEdit</EditType><FormatString>c2</Form" & _
        "atString><Key>ext_cost</Key><Position>4</Position><TextAlignment>Far</TextAlignm" & _
        "ent><Width>88</Width><TotalFormatString>c2</TotalFormatString></Column4><Column5" & _
        " ID=""ext_Price""><AggregateFunction>Sum</AggregateFunction><Caption>Ext Price</Ca" & _
        "ption><DataMember>ext_Price</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><FormatString>c2</FormatString><Key>ext_Price</Key><P" & _
        "osition>5</Position><TextAlignment>Far</TextAlignment><Width>90</Width><TotalFor" & _
        "matString>c2</TotalFormatString></Column5><Column6 ID=""gross""><AggregateFunction" & _
        ">Sum</AggregateFunction><Caption>Gross Profit</Caption><DataMember>gross</DataMe" & _
        "mber><EditType>NoEdit</EditType><FormatString>c2</FormatString><Key>gross</Key><" & _
        "Position>6</Position><TextAlignment>Far</TextAlignment><Width>88</Width><TotalFo" & _
        "rmatString>c2</TotalFormatString></Column6></Columns><GroupCondition ID="""" /><Gr" & _
        "oupTotals>Always</GroupTotals><TotalRow>True</TotalRow></RootTable></GridEXLayou" & _
        "tData>"
        Me.GrdTechnicianDtl.DesignTimeLayout = GridEXLayout1
        Me.GrdTechnicianDtl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdTechnicianDtl.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdTechnicianDtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdTechnicianDtl.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdTechnicianDtl.Hierarchical = True
        Me.GrdTechnicianDtl.Location = New System.Drawing.Point(0, 64)
        Me.GrdTechnicianDtl.Name = "GrdTechnicianDtl"
        Me.GrdTechnicianDtl.Size = New System.Drawing.Size(698, 320)
        Me.GrdTechnicianDtl.TabIndex = 9
        '
        'DsFrmPrint1
        '
        Me.DsFrmPrint1.DataSetName = "DSFrmPrint"
        Me.DsFrmPrint1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CmbChild)
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
        Me.Panel4.Size = New System.Drawing.Size(694, 64)
        Me.Panel4.TabIndex = 8
        '
        'CmbChild
        '
        Me.CmbChild.Location = New System.Drawing.Point(262, 5)
        Me.CmbChild.Name = "CmbChild"
        Me.CmbChild.Size = New System.Drawing.Size(50, 27)
        Me.CmbChild.TabIndex = 195
        Me.CmbChild.Text = "Expand"
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
        Me.Label2.Location = New System.Drawing.Point(316, 36)
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
        Me.Label1.Size = New System.Drawing.Size(192, 62)
        Me.Label1.TabIndex = 3
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
        Me.PictureBox2.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_dtl.cod_technician, service_center_dtl.cod_select, service_" & _
        "center_dtl.desc_radif, service_center_dtl.id_service_center, service_center_head" & _
        ".date_refer, ISNULL(service_center_dtl.qty, 0) AS qty, ROUND(ISNULL(inv_tab_labo" & _
        "r_service_price.price_rate, 0), 2) AS cost, ROUND(ISNULL(service_center_dtl.pric" & _
        "e, 0), 2) AS price, inv_tab_service_type.service_type_desc AS svc, inv_tab_servi" & _
        "ce_category.desc_srvice_category AS cat, '' AS type, '' AS line, 0 AS ext_Price," & _
        " ISNULL(service_center_dtl.fet, 0) AS fet FROM inv_tab_labor_service_price RIGHT" & _
        " OUTER JOIN service_center_dtl INNER JOIN employee ON service_center_dtl.cod_tec" & _
        "hnician = employee.employee_code INNER JOIN service_center_head ON service_cente" & _
        "r_dtl.id_service_center = service_center_head.id_service_center INNER JOIN inv_t" & _
        "ab_labor_service ON service_center_dtl.cod_select = inv_tab_labor_service.cod_se" & _
        "rvice LEFT OUTER JOIN inv_tab_service_category ON inv_tab_labor_service.service_" & _
        "category = inv_tab_service_category.service_category LEFT OUTER JOIN inv_tab_ser" & _
        "vice_type ON inv_tab_labor_service.service_type = inv_tab_service_type.service_t" & _
        "ype ON inv_tab_labor_service_price.cod_service = inv_tab_labor_service.cod_servi" & _
        "ce"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=TireMate_05"
        '
        'DAservice_center_dtl
        '
        Me.DAservice_center_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT employee.f_name + ' ' + employee.l_name AS name, ISNULL(SUM(service_center" & _
        "_dtl.qty), 0) AS qty, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_ce" & _
        "nter_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_price, service_c" & _
        "enter_dtl.cod_technician, employee.cod_position FROM service_center_dtl INNER JO" & _
        "IN service_center_head ON service_center_dtl.id_service_center = service_center_" & _
        "head.id_service_center INNER JOIN employee ON service_center_dtl.cod_technician " & _
        "= employee.employee_code WHERE (service_center_head.type_of_form = 'IN' OR servi" & _
        "ce_center_head.type_of_form = 'RT') AND (service_center_dtl.cod_technician IS NO" & _
        "T NULL) GROUP BY employee.f_name, employee.l_name, service_center_dtl.cod_techni" & _
        "cian, employee.cod_position"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAservice_center_Summery
        '
        Me.DAservice_center_Summery.SelectCommand = Me.SqlSelectCommand2
        Me.DAservice_center_Summery.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'GrdTechnicianSummer
        '
        Me.GrdTechnicianSummer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdTechnicianSummer.DataMember = "PerformanceSummery"
        Me.GrdTechnicianSummer.DataSource = Me.DsFrmPrint1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>22</Width></Column0><Column1 ID" & _
        "=""name""><Caption>Employee Name</Caption><DataMember>name</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name</Key><Position" & _
        ">1</Position><Width>202</Width></Column1><Column2 ID=""price_Tire""><AggregateFunc" & _
        "tion>Sum</AggregateFunction><Caption>Tires &amp; AutoParts</Caption><DataMember>" & _
        "price_Tire</DataMember><EditType>NoEdit</EditType><FormatString>c2</FormatString" & _
        "><Key>price_Tire</Key><Position>2</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>103</Width><TotalFormatString>c2</TotalFormatString></Column2><Column3 ID=""" & _
        "price_Label""><AggregateFunction>Sum</AggregateFunction><Caption>Labor</Caption><" & _
        "DataMember>price_Label</DataMember><EditType>NoEdit</EditType><FormatString>c2</" & _
        "FormatString><Key>price_Label</Key><Position>3</Position><TextAlignment>Far</Tex" & _
        "tAlignment><Width>91</Width><TotalFormatString>c2</TotalFormatString></Column3><" & _
        "Column4 ID=""price_Fees""><AggregateFunction>Sum</AggregateFunction><Caption>Fees<" & _
        "/Caption><DataMember>price_Fees</DataMember><EditType>NoEdit</EditType><FormatSt" & _
        "ring>c2</FormatString><Key>price_Fees</Key><Position>4</Position><TextAlignment>" & _
        "Far</TextAlignment><Width>84</Width><TotalFormatString>c2</TotalFormatString></C" & _
        "olumn4><Column5 ID=""price_Out""><AggregateFunction>Sum</AggregateFunction><Captio" & _
        "n>Outside Purchases</Caption><DataMember>price_Out</DataMember><EditType>NoEdit<" & _
        "/EditType><FormatString>c2</FormatString><Key>price_Out</Key><Position>5</Positi" & _
        "on><TextAlignment>Far</TextAlignment><Width>110</Width><TotalFormatString>c2</To" & _
        "talFormatString></Column5></Columns><GroupCondition ID="""" /></RootTable></GridEX" & _
        "LayoutData>"
        Me.GrdTechnicianSummer.DesignTimeLayout = GridEXLayout2
        Me.GrdTechnicianSummer.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdTechnicianSummer.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdTechnicianSummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdTechnicianSummer.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdTechnicianSummer.Location = New System.Drawing.Point(-2, 64)
        Me.GrdTechnicianSummer.Name = "GrdTechnicianSummer"
        Me.GrdTechnicianSummer.Size = New System.Drawing.Size(698, 320)
        Me.GrdTechnicianSummer.TabIndex = 10
        Me.GrdTechnicianSummer.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
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
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(130, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_type_phone, desc_type_phone FROM bas_tab_phone_type"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand3
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_tab_phone_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type_phone", "cod_type_phone"), New System.Data.Common.DataColumnMapping("desc_type_phone", "desc_type_phone")})})
        '
        'GrdSale
        '
        Me.GrdSale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSale.DataMember = "SaleDetail"
        Me.GrdSale.DataSource = Me.DsFrmPrint1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""Add_user_Name""><Caption>Employee Name</Caption><DataMember>Add_user_Name</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>A" & _
        "dd_user_Name</Key><Position>1</Position><Visible>False</Visible><Width>96</Width" & _
        "></Column1><Column2 ID=""id_service_center""><AggregateFunction>Count</AggregateFu" & _
        "nction><Caption>Ref. No</Caption><DataMember>id_service_center</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>id_service_ce" & _
        "nter</Key><Position>2</Position><Width>78</Width></Column2><Column3 ID=""date_ref" & _
        "er""><Caption>Date</Caption><DataMember>date_refer</DataMember><EditType>NoEdit</" & _
        "EditType><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</Forma" & _
        "tString><Key>date_refer</Key><Position>3</Position><Width>72</Width></Column3><C" & _
        "olumn4 ID=""price_Tire""><AggregateFunction>Sum</AggregateFunction><Caption>Parts<" & _
        "/Caption><DataMember>price_Tire</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>price_Tire</K" & _
        "ey><Position>4</Position><TextAlignment>Far</TextAlignment><Width>86</Width><Tot" & _
        "alFormatString>c2</TotalFormatString></Column4><Column5 ID=""price_Label""><Aggreg" & _
        "ateFunction>Sum</AggregateFunction><Caption>Labor</Caption><DataMember>price_Lab" & _
        "el</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><FormatString>c2</FormatString><Key>price_Label</Key><Position>5</Position><Te" & _
        "xtAlignment>Far</TextAlignment><Width>87</Width><TotalFormatString>c2</TotalForm" & _
        "atString></Column5><Column6 ID=""price_Fees""><AggregateFunction>Sum</AggregateFun" & _
        "ction><Caption>Fees</Caption><DataMember>price_Fees</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStrin" & _
        "g><Key>price_Fees</Key><Position>6</Position><TextAlignment>Far</TextAlignment><" & _
        "Width>91</Width><TotalFormatString>c2</TotalFormatString></Column6><Column7 ID=""" & _
        "Fet""><AggregateFunction>Sum</AggregateFunction><Caption>Fet</Caption><DataMember" & _
        ">Fet</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditT" & _
        "ype><FormatString>c2</FormatString><Key>Fet</Key><Position>7</Position><TextAlig" & _
        "nment>Far</TextAlignment><Width>80</Width><TotalFormatString>c2</TotalFormatStri" & _
        "ng></Column7><Column8 ID=""Price_subtotal""><AggregateFunction>Sum</AggregateFunct" & _
        "ion><Caption>Subtotal</Caption><DataMember>Price_subtotal</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</Forma" & _
        "tString><Key>Price_subtotal</Key><Position>8</Position><TextAlignment>Far</TextA" & _
        "lignment><Width>88</Width><TotalFormatString>c2</TotalFormatString></Column8><Co" & _
        "lumn9 ID=""tax""><AggregateFunction>Sum</AggregateFunction><Caption>Sales Tax</Cap" & _
        "tion><DataMember>tax</DataMember><EditType>NoEdit</EditType><FilterEditType>Text" & _
        "Box</FilterEditType><FormatString>c2</FormatString><Key>tax</Key><Position>9</Po" & _
        "sition><TextAlignment>Far</TextAlignment><Width>86</Width><TotalFormatString>c2<" & _
        "/TotalFormatString></Column9><Column10 ID=""discount""><AggregateFunction>Sum</Agg" & _
        "regateFunction><Caption>Discount</Caption><DataMember>discount</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</" & _
        "FormatString><Key>discount</Key><Position>10</Position><TextAlignment>Far</TextA" & _
        "lignment><Width>86</Width><TotalFormatString>c2</TotalFormatString></Column10><C" & _
        "olumn11 ID=""total""><AggregateFunction>Sum</AggregateFunction><Caption>Total</Cap" & _
        "tion><DataMember>total</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><FormatString>c2</FormatString><Key>total</Key><Position>1" & _
        "1</Position><TextAlignment>Far</TextAlignment><Width>83</Width><TotalFormatStrin" & _
        "g>c2</TotalFormatString></Column11><Column12 ID=""Name_customer""><Caption>Custome" & _
        "r</Caption><DataMember>Name_customer</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><Key>Name_customer</Key><Position>12</Positi" & _
        "on><Width>109</Width></Column12><Column13 ID=""license_no_vehicle""><Caption>Vehic" & _
        "le</Caption><DataMember>license_no_vehicle</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><Key>license_no_vehicle</Key><Position" & _
        ">13</Position><Width>109</Width></Column13></Columns><GroupCondition ID="""" /><Gr" & _
        "oups Collection=""true""><Group0 ID=""Group0""><ColIndex>1</ColIndex></Group0></Grou" & _
        "ps></RootTable></GridEXLayoutData>"
        Me.GrdSale.DesignTimeLayout = GridEXLayout3
        Me.GrdSale.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSale.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdSale.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdSale.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdSale.Location = New System.Drawing.Point(-2, 64)
        Me.GrdSale.Name = "GrdSale"
        Me.GrdSale.Size = New System.Drawing.Size(698, 320)
        Me.GrdSale.TabIndex = 11
        Me.GrdSale.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'OleDAUserId
        '
        Me.OleDAUserId.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDAUserId.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserName", "UserName")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Users.UserId, Users.UserLogin FROM (Users INNER JOIN UserGroup ON Users.Us" & _
        "erGroupId = UserGroup.UserGroupId) WHERE (Users.UserActiveFalg <> 0) AND (UserGr" & _
        "oup.GroupActiveFlag <> 0)"
        Me.OleDbSelectCommand1.Connection = Me.CnnUserMDB
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
        'GrdPayroll
        '
        Me.GrdPayroll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPayroll.DataMember = "Payroll"
        Me.GrdPayroll.DataSource = Me.DsFrmPrint1
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""name""><Caption>Employee Name</Caption><DataMember>name</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name</Key><Position" & _
        ">1</Position><Visible>False</Visible></Column1><Column2 ID=""PayrollDate""><Captio" & _
        "n>Payroll Date</Caption><DataMember>PayrollDate</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatS" & _
        "tring><Key>PayrollDate</Key><Position>2</Position><Width>88</Width></Column2><Co" & _
        "lumn3 ID=""gross_pay""><AggregateFunction>Sum</AggregateFunction><Caption>Gross Pa" & _
        "y</Caption><DataMember>gross_pay</DataMember><EditType>NoEdit</EditType><FilterE" & _
        "ditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>gross_pay</K" & _
        "ey><Position>3</Position><TextAlignment>Far</TextAlignment><Width>71</Width><Tot" & _
        "alFormatString>c2</TotalFormatString></Column3><Column4 ID=""NetPay""><AggregateFu" & _
        "nction>Sum</AggregateFunction><Caption>Net Pay</Caption><DataMember>NetPay</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Forma" & _
        "tString>c2</FormatString><Key>NetPay</Key><Position>4</Position><TextAlignment>F" & _
        "ar</TextAlignment><Width>76</Width><TotalFormatString>c2</TotalFormatString></Co" & _
        "lumn4><Column5 ID=""Federal""><AggregateFunction>Sum</AggregateFunction><Caption>F" & _
        "ederal Tax</Caption><DataMember>Federal</DataMember><EditType>NoEdit</EditType><" & _
        "FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Feder" & _
        "al</Key><Position>5</Position><TextAlignment>Far</TextAlignment><Width>71</Width" & _
        "><TotalFormatString>c2</TotalFormatString></Column5><Column6 ID=""Social""><Aggreg" & _
        "ateFunction>Sum</AggregateFunction><Caption>Social security</Caption><DataMember" & _
        ">Social</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><FormatString>c2</FormatString><Key>Social</Key><Position>6</Position><Te" & _
        "xtAlignment>Far</TextAlignment><TotalFormatString>c2</TotalFormatString></Column" & _
        "6><Column7 ID=""Medicare""><AggregateFunction>Sum</AggregateFunction><Caption>Medi" & _
        "care</Caption><DataMember>Medicare</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Medicare</" & _
        "Key><Position>7</Position><TextAlignment>Far</TextAlignment><TotalFormatString>c" & _
        "2</TotalFormatString></Column7><Column8 ID=""StateTax""><AggregateFunction>Sum</Ag" & _
        "gregateFunction><Caption>StateTax</Caption><DataMember>StateTax</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2<" & _
        "/FormatString><Key>StateTax</Key><Position>8</Position><TextAlignment>Far</TextA" & _
        "lignment><TotalFormatString>c2</TotalFormatString></Column8><Column9 ID=""UnEmpTa" & _
        "x""><AggregateFunction>Sum</AggregateFunction><Caption>UnEmployed Tax</Caption><D" & _
        "ataMember>UnEmpTax</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBo" & _
        "x</FilterEditType><FormatString>c2</FormatString><Key>UnEmpTax</Key><Position>9<" & _
        "/Position><TextAlignment>Far</TextAlignment><Visible>False</Visible><TotalFormat" & _
        "String>c2</TotalFormatString></Column9><Column10 ID=""saving""><AggregateFunction>" & _
        "Sum</AggregateFunction><Caption>Savings</Caption><DataMember>saving</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString" & _
        ">c2</FormatString><Key>saving</Key><Position>10</Position><TextAlignment>Far</Te" & _
        "xtAlignment><TotalFormatString>c2</TotalFormatString></Column10><Column11 ID=""lo" & _
        "an""><AggregateFunction>Sum</AggregateFunction><Caption>Loans</Caption><DataMembe" & _
        "r>loan</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><FormatString>c2</FormatString><Key>loan</Key><Position>11</Position><Text" & _
        "Alignment>Far</TextAlignment><TotalFormatString>c2</TotalFormatString></Column11" & _
        "><Column12 ID=""Gurnish""><AggregateFunction>Sum</AggregateFunction><Caption>Garni" & _
        "shments</Caption><DataMember>Gurnish</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Gurnish<" & _
        "/Key><Position>12</Position><TextAlignment>Far</TextAlignment><TotalFormatString" & _
        ">c2</TotalFormatString></Column12><Column13 ID=""Other""><AggregateFunction>Sum</A" & _
        "ggregateFunction><Caption>Other Deductions</Caption><DataMember>Other</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStri" & _
        "ng>c2</FormatString><Key>Other</Key><Position>13</Position><TextAlignment>Far</T" & _
        "extAlignment><TotalFormatString>c2</TotalFormatString></Column13><Column14 ID=""n" & _
        "o_of_check""><Caption>Check No.</Caption><DataMember>no_of_check</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>no_of_check<" & _
        "/Key><Position>14</Position></Column14></Columns><GroupCondition ID="""" /><Groups" & _
        " Collection=""true""><Group0 ID=""Group0""><ColIndex>1</ColIndex></Group0></Groups><" & _
        "SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>2</ColIndex></SortK" & _
        "ey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdPayroll.DesignTimeLayout = GridEXLayout4
        Me.GrdPayroll.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPayroll.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdPayroll.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdPayroll.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdPayroll.Location = New System.Drawing.Point(-2, 64)
        Me.GrdPayroll.Name = "GrdPayroll"
        Me.GrdPayroll.Size = New System.Drawing.Size(698, 320)
        Me.GrdPayroll.TabIndex = 12
        Me.GrdPayroll.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'FrmPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(694, 380)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdPayroll)
        Me.Controls.Add(Me.GrdSale)
        Me.Controls.Add(Me.GrdTechnicianSummer)
        Me.Controls.Add(Me.GrdTechnicianDtl)
        Me.MaximizeBox = True
        Me.Name = "FrmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Technician Performance Report"
        CType(Me.GrdTechnicianDtl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPrint1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdTechnicianSummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        TechnicianDetail = 1
        TechnicianSummery = 2
        SaleDetail = 3
        SaleSummery = 4
        PayrollDetail = 5
        PAyrollSummery = 6

    End Enum
    Public KindOfReport As KindReport
    Public StrWhere As String
    Public StrFilter As String
    Public DSMain As New DataSet
    Public FEmp As Boolean
    Public Fpos As Boolean
    Public Date1 As String
    Public Date2 As String
    Dim ComName As String = SystemInformation.ComputerName

    Private Sub FrmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()

        Cnn.ConnectionString = PConnectionString
        CnnUserMDB.ConnectionString = PConnectionStringForUserMdb

        Select Case KindOfReport
            Case KindReport.TechnicianDetail
                Call FillTechnicianDetail()
            Case KindReport.TechnicianSummery
                CmbChild.Visible = False
                Call FillTechnicianSummery()
            Case KindReport.SaleDetail
                CmbChild.Visible = False
                FillSaleDetail()
            Case KindReport.SaleSummery
                CmbChild.Visible = False
                FillSaleSummery()
            Case KindReport.PayrollDetail
                CmbChild.Visible = False
                PayrollDetail()
            Case KindReport.PAyrollSummery
                CmbChild.Visible = False
                PayrollSummery()
        End Select
        If Date1.Trim.Length > 0 Then
            GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
        Else
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End If
        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
    End Sub
    Private Sub FillTechnicianDetail()
        Dim i As Integer
        'Dim st As String
        'st = IIf(FEmp, ",0 as Femp ", ",1 as Femp ")
        'st = st & IIf(Fpos, ", 0 as fPos ", ", 1 as fPos")
        DAservice_center_dtl.SelectCommand.CommandText = " SELECT     service_center_dtl.cod_technician, employee.f_name + ' ' + employee.l_name AS name, SUM(ROUND(ISNULL(service_center_dtl.qty, 0), 2)) AS qty, " & _
            " SUM(ROUND(ISNULL(service_center_dtl.price, 0), 2)) AS price, 1 AS flag, ISNULL(SUM(service_center_dtl.qty), 0) AS qty, SUM(ISNULL(service_center_dtl.qty, 0) " & _
            "* (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_price" & _
            " FROM         service_center_dtl INNER JOIN " & _
            " employee ON service_center_dtl.cod_technician = employee.employee_code INNER JOIN " & _
            " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center " & _
            " WHERE     (service_center_head.type_of_form = 'IN' OR " & _
            " service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select IN ('I', 'O', 'L', 'S','F'))  AND (service_center_dtl.cod_technician IS NOT NULL) " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
            " GROUP BY employee.f_name, employee.l_name, service_center_dtl.cod_technician "


        DAservice_center_dtl.Fill(DsFrmPrint1.service_center_dtl_Header)



        DAservice_center_dtl.SelectCommand.CommandText = "SELECT     service_center_dtl.cod_technician, service_center_dtl.cod_select, service_center_dtl.desc_radif, service_center_dtl.id_service_center, " & _
            " service_center_head.date_refer, ISNULL(service_center_dtl.qty, 0) AS qty, ROUND(ISNULL(inv_item_cost_transaction.cost, 0), 2) AS cost,  " & _
            " ROUND(ISNULL(service_center_dtl.price, 0), 2) AS price, '' AS svc, '' AS cat, inv_tab_type_item.desc_item_type AS type, inv_tab_line.line,  " & _
            " 0 AS ext_Price, ISNULL(service_center_dtl.fet, 0) AS fet " & _
            " FROM         inv_item_cost_transaction RIGHT OUTER JOIN " & _
            " service_center_dtl INNER JOIN " & _
            " employee ON service_center_dtl.cod_technician = employee.employee_code INNER JOIN " & _
            " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
            " inv_item ON service_center_dtl.cod_select = inv_item.item_no LEFT OUTER JOIN  " & _
            " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type LEFT OUTER JOIN " & _
            " inv_tab_line ON inv_item.line = inv_tab_line.line ON inv_item_cost_transaction.item_no = inv_item.item_no " & _
            " WHERE    (service_center_dtl.type_select = 'I') and   (service_center_head.type_of_form = 'IN' OR " & _
            " service_center_head.type_of_form = 'RT') AND (service_center_dtl.cod_technician IS NOT NULL) " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere)

        DAservice_center_dtl.Fill(DsFrmPrint1.service_center_dtl)



        DAservice_center_dtl.SelectCommand.CommandText = " SELECT     service_center_dtl.cod_technician, service_center_dtl.cod_select, service_center_dtl.desc_radif, service_center_dtl.id_service_center,  " & _
            "   service_center_head.date_refer, ISNULL(service_center_dtl.qty, 0) AS qty,0 as cost, ROUND(ISNULL(service_center_dtl.price, 0), 2) AS price,  " & _
            "  inv_tab_service_type.service_type_desc AS svc, inv_tab_service_category.desc_srvice_category AS cat, '' AS type, '' AS line, 0 AS ext_Price,  " & _
            " ISNULL(service_center_dtl.fet, 0) AS fet " & _
            " FROM         service_center_dtl INNER JOIN " & _
            "   employee ON service_center_dtl.cod_technician = employee.employee_code INNER JOIN " & _
            "   service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
            "  inv_tab_labor_service ON service_center_dtl.cod_select = inv_tab_labor_service.cod_service LEFT OUTER JOIN " & _
            " inv_tab_service_category ON inv_tab_labor_service.service_category = inv_tab_service_category.service_category LEFT OUTER JOIN " & _
            " inv_tab_service_type ON inv_tab_labor_service.service_type = inv_tab_service_type.service_type " & _
            " WHERE   (service_center_dtl.type_select IN('S','L','F')) and    (service_center_head.type_of_form = 'IN' OR " & _
            " service_center_head.type_of_form = 'RT') AND (service_center_dtl.cod_technician IS NOT NULL) " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere)

        DAservice_center_dtl.Fill(DsFrmPrint1.service_center_dtl)




        DAservice_center_dtl.SelectCommand.CommandText = " SELECT     service_center_dtl.cod_technician, service_center_dtl.cod_select, service_center_dtl.desc_radif, service_center_dtl.id_service_center,  " & _
            " service_center_head.date_refer, ISNULL(service_center_dtl.qty, 0) AS qty, ROUND(ISNULL(service_out_purchases.cost, 0), 2) AS cost,  " & _
            " ROUND(ISNULL(service_center_dtl.price, 0), 2) AS price, '' AS type, '' AS line, 0 AS ext_Price, ISNULL(service_center_dtl.fet, 0) AS fet " & _
            " FROM         service_center_dtl INNER JOIN " & _
            " employee ON service_center_dtl.cod_technician = employee.employee_code INNER JOIN " & _
            " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
            " service_out_purchases ON service_center_dtl.id_service_center = service_out_purchases.id_service_center AND " & _
            " service_center_dtl.radif = service_out_purchases.radif " & _
            " WHERE    (service_center_head.type_of_form = 'IN' OR " & _
            " service_center_head.type_of_form = 'RT') and (service_center_dtl.type_select = 'O') " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere)

        DAservice_center_dtl.Fill(DsFrmPrint1.service_center_dtl)

        For i = 0 To DsFrmPrint1.service_center_dtl.Count - 1
            DsFrmPrint1.service_center_dtl(i).ext_cost = DsFrmPrint1.service_center_dtl(i).qty * (DsFrmPrint1.service_center_dtl(i).cost + DsFrmPrint1.service_center_dtl(i).fet)
            DsFrmPrint1.service_center_dtl(i).ext_Price = DsFrmPrint1.service_center_dtl(i).qty * (DsFrmPrint1.service_center_dtl(i).price + DsFrmPrint1.service_center_dtl(i).fet)
            DsFrmPrint1.service_center_dtl(i).gross = DsFrmPrint1.service_center_dtl(i).ext_Price - DsFrmPrint1.service_center_dtl(i).ext_cost
        Next

        'If FEmp Then
        '    For i = 0 To DsFrmPrint1.service_center_dtl.Count - 1
        '        If DSMain.Tables("employee").Select("flag=1 and cod = " & Qt(DsFrmPrint1.service_center_dtl(i).cod_technician)).Length > 0 Then
        '            DsFrmPrint1.service_center_dtl(i).fEmp = 1
        '        End If
        '    Next
        'End If

        'If Fpos Then
        '    For i = 0 To DsFrmPrint1.service_center_dtl.Count - 1
        '        If DSMain.Tables("employee_position").Select("flag=1 and cod = " & Qt(DsFrmPrint1.service_center_dtl(i).cod_position)).Length > 0 Then
        '            DsFrmPrint1.service_center_dtl(i).fPos = 1
        '        End If
        '    Next
        'End If

        'DsFrmPrint1.service_center_dtl.DefaultView.RowFilter = " Fpos = true and  femp = true "
        'GrdTechnicianDtl.SetDataBinding(DsFrmPrint1.service_center_dtl.DefaultView, "")
        Dim j As Integer
        For i = 0 To DsFrmPrint1.service_center_dtl_Header.Rows.Count - 1
            Dim dr() As DataRow = DsFrmPrint1.service_center_dtl.Select(" cod_technician = " & Qt(DsFrmPrint1.service_center_dtl_Header(i).cod_technician))
            For j = 0 To dr.Length - 1
                DsFrmPrint1.service_center_dtl_Header(i).ext_cost = DsFrmPrint1.service_center_dtl_Header(i).ext_cost + dr(j).Item("ext_cost")
                DsFrmPrint1.service_center_dtl_Header(i).gross = DsFrmPrint1.service_center_dtl_Header(i).gross + dr(j).Item("gross")
            Next
        Next

            GrdTechnicianDtl.BringToFront()
            GridEXPrintDocument1.PrintHierarchical = True

    End Sub
    Private Sub FillTechnicianSummery()
        Dim i As Integer
        'Dim st As String
        'st = IIf(FEmp, ",0 as Femp ", ",1 as Femp ")
        'st = st & IIf(Fpos, ", 0 as fPos ", ", 1 as fPos")

        'DAservice_center_Summery.SelectCommand.CommandText = "SELECT     employee.f_name + ' ' + employee.l_name AS name, ISNULL(SUM(service_center_dtl.qty), 0) AS qty, SUM(ISNULL(service_center_dtl.qty, 0) " & _
        '              "* (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_price,1 as flag, service_center_dtl.cod_technician, " & _
        '          " employee.cod_position " & _
        '         " FROM         service_center_dtl INNER JOIN " & _
        '              " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
        '              " employee ON service_center_dtl.cod_technician = employee.employee_code " & _
        '              " WHERE     (service_center_head.type_of_form = 'IN' OR " & _
        '              " service_center_head.type_of_form = 'RT') AND (service_center_dtl.cod_technician IS NOT NULL) " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
        '            " GROUP BY employee.f_name, employee.l_name, service_center_dtl.cod_technician, employee.cod_position "

        'DAservice_center_Summery.Fill(DsFrmPrint1.service_center_head)
        DAservice_center_Summery.SelectCommand.CommandText = " SELECT     employee.f_name + ' ' + employee.l_name AS name, " & _
                    "  SUM(CASE WHEN (service_center_dtl.type_select = 'I') THEN ISNULL(service_center_dtl.qty, 0)  END * (CASE WHEN (service_center_dtl.type_select = 'I') THEN ISNULL(service_center_dtl.price, 0) END + CASE WHEN (service_center_dtl.type_select = 'I') THEN ISNULL(service_center_dtl.fet, 0) END)) AS price_Tire,  " & _
                    "  SUM(CASE WHEN (type_select = 'L' OR type_select = 'S') THEN ISNULL(service_center_dtl.qty, 0) END * (CASE WHEN (type_select = 'L' OR type_select = 'S') THEN ISNULL(service_center_dtl.price, 0) END + CASE WHEN (type_select = 'L' OR type_select = 'S') THEN ISNULL(service_center_dtl.fet, 0) END)) AS price_Label, " & _
                    "  SUM(CASE WHEN (service_center_dtl.type_select = 'F')  THEN ISNULL(service_center_dtl.qty, 0) END * (CASE WHEN (service_center_dtl.type_select = 'F') THEN ISNULL(service_center_dtl.price, 0)  END + CASE WHEN (service_center_dtl.type_select = 'F') THEN ISNULL(service_center_dtl.fet, 0) END)) AS price_Fees,  " & _
                    "   SUM(CASE WHEN (service_center_dtl.type_select = 'O') THEN ISNULL(service_center_dtl.qty, 0) END * (CASE WHEN (service_center_dtl.type_select = 'O') THEN ISNULL(service_center_dtl.price, 0)  END + CASE WHEN (service_center_dtl.type_select = 'O') THEN ISNULL(service_center_dtl.fet, 0) END)) AS price_Out,  " & _
                    " 1 AS flag, service_center_dtl.cod_technician " & _
                    " FROM         service_center_dtl INNER JOIN " & _
                    " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                    " employee ON service_center_dtl.cod_technician = employee.employee_code " & _
                    " WHERE     (service_center_head.type_of_form = 'IN' OR " & _
                    " service_center_head.type_of_form = 'RT') AND (service_center_dtl.cod_technician IS NOT NULL)  " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                    " GROUP BY employee.f_name, employee.l_name, service_center_dtl.cod_technician "

        DAservice_center_Summery.Fill(DsFrmPrint1.PerformanceSummery)
        'If FEmp Then
        '    For i = 0 To DsFrmPrint1.service_center_head.Count - 1
        '        If DSMain.Tables("employee").Select("flag=1 and cod = " & Qt(DsFrmPrint1.service_center_head(i).cod_technician)).Length > 0 Then
        '            DsFrmPrint1.service_center_head(i).FEmp = 1
        '        End If
        '    Next
        'End If

        'If Fpos Then
        '    For i = 0 To DsFrmPrint1.service_center_head.Count - 1
        '        If DSMain.Tables("employee_position").Select("flag=1 and cod = " & Qt(DsFrmPrint1.service_center_head(i).cod_position)).Length > 0 Then
        '            DsFrmPrint1.service_center_head(i).fpos = 1
        '        End If
        '    Next
        'End If

        'DsFrmPrint1.service_center_head.DefaultView.RowFilter = " Fpos = true and  femp = true "
        'GrdTechnicianSummer.SetDataBinding(DsFrmPrint1.service_center_head.DefaultView, "")
        GrdTechnicianSummer.BringToFront()


    End Sub
    Private Sub FillSaleDetail()
        OleDAUserId.Fill(DsFrmPrint1.Users)

        DAGeneral.SelectCommand.CommandText = " SELECT     service_center_head.add_user, service_center_head.id_service_center, service_center_head.date_refer,  " & _
                               " SUM(CASE WHEN (service_center_dtl.type_select = 'I' OR " & _
                               " service_center_dtl.type_select = 'O') THEN ISNULL(service_center_dtl.qty, 0) ELSE 0 END * (ISNULL(service_center_dtl.price, 0)  " & _
                               " + ISNULL(service_center_dtl.fet, 0))) AS price_Tire, SUM(CASE WHEN (type_select = 'L' OR " & _
                               " type_select = 'S') THEN ISNULL(service_center_dtl.qty, 0) ELSE 0 END * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0)))  " & _
                               " AS price_Label, SUM(CASE WHEN (service_center_dtl.type_select = 'F') THEN ISNULL(service_center_dtl.qty, 0)  " & _
                               " ELSE 0 END * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS price_Fees, 1 AS flag, SUM(ISNULL(service_center_dtl.qty,  " & _
                               " 0) * ISNULL(service_center_dtl.fet, 0)) AS Fet, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  " & _
                               " + ISNULL(service_center_dtl.fet, 0))) AS Price_subtotal, ISNULL(service_center_head.tax, 0) AS tax, ISNULL(service_center_head.discount, 0)  " & _
                               " AS discount, ISNULL(service_center_head.Total, 0) AS total, ISNULL(cust_trtab_main.f_name, '') + ' ' + ISNULL(cust_trtab_main.m_name, '')  " & _
                               " + ' ' + ISNULL(cust_trtab_main.l_name, '') AS Name_customer, ser_tr_vehicle.license_no_vehicle " & _
                               " FROM         service_center_dtl INNER JOIN " & _
                               " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                               " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
                               " ser_tr_vehicle ON service_center_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN " & _
                               " employee ON service_center_dtl.cod_technician = employee.employee_code " & _
                               " WHERE     (service_center_head.type_of_form = 'IN' )  " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
        " GROUP BY service_center_head.add_user, service_center_head.id_service_center, service_center_head.date_refer, service_center_head.tax,  " & _
        " service_center_head.discount, service_center_head.Total, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, " & _
        " ser_tr_vehicle.license_no_vehicle " & _
        " ORDER BY dbo.ChangeDate(service_center_head.date_refer), service_center_head.id_service_center "


        DAGeneral.Fill(DsFrmPrint1.SaleDetail)

        Dim str As String
        For i As Integer = 0 To DsFrmPrint1.SaleDetail.Rows.Count - 1
            If DsFrmPrint1.Users.FindByUserId(DsFrmPrint1.SaleDetail(i).add_user) Is Nothing Then
                str = ""
            Else
                str = DsFrmPrint1.Users.FindByUserId(DsFrmPrint1.SaleDetail(i).add_user).UserLogin
            End If
            DsFrmPrint1.SaleDetail(i).Add_user_Name = str
        Next

        GrdSale.BringToFront()

    End Sub
    Private Sub FillSaleSummery()
        OleDAUserId.Fill(DsFrmPrint1.Users)

        Dim CmdGeneral As New SqlClient.SqlCommand("", Cnn)

        CmdGeneral.CommandText = " CREATE VIEW dbo.View_SalesPerson_" & ComName & _
                  " AS " & _
                  " SELECT     service_center_head.add_user, service_center_head.id_service_center, service_center_head.date_refer,  " & _
                  " SUM(CASE WHEN (service_center_dtl.type_select = 'I' OR " & _
                  " service_center_dtl.type_select = 'O') THEN ISNULL(service_center_dtl.qty, 0) ELSE 0 END * (ISNULL(service_center_dtl.price, 0)  " & _
                  " + ISNULL(service_center_dtl.fet, 0))) AS price_Tire, SUM(CASE WHEN (type_select = 'L' OR " & _
                  " type_select = 'S') THEN ISNULL(service_center_dtl.qty, 0) ELSE 0 END * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0)))  " & _
                  " AS price_Label, SUM(CASE WHEN (service_center_dtl.type_select = 'F') THEN ISNULL(service_center_dtl.qty, 0)  " & _
                  " ELSE 0 END * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS price_Fees,  SUM(ISNULL(service_center_dtl.qty,  " & _
                  " 0) * ISNULL(service_center_dtl.fet, 0)) AS Fet, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  " & _
                  " + ISNULL(service_center_dtl.fet, 0))) AS Price_subtotal, ISNULL(service_center_head.tax, 0) AS tax, ISNULL(service_center_head.discount, 0)  " & _
                  " AS discount, ISNULL(service_center_head.Total, 0) AS total, ISNULL(cust_trtab_main.f_name, '') + ' ' + ISNULL(cust_trtab_main.m_name, '')  " & _
                  " + ' ' + ISNULL(cust_trtab_main.l_name, '') AS Name_customer, ser_tr_vehicle.license_no_vehicle " & _
                  " FROM         service_center_dtl INNER JOIN " & _
                  " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                  " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
                  " ser_tr_vehicle ON service_center_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN " & _
                  " employee ON service_center_dtl.cod_technician = employee.employee_code " & _
                  " WHERE     (service_center_head.type_of_form = 'IN' )  " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                " GROUP BY service_center_head.add_user, service_center_head.id_service_center, service_center_head.date_refer, service_center_head.tax,  " & _
                " service_center_head.discount, service_center_head.Total, cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, " & _
                " ser_tr_vehicle.license_no_vehicle "
        ', employee.employee_code, employee.cod_position " & _
        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If

            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

            Try
                Dim CmdGeneral1 As New SqlClient.SqlCommand(" drop view [dbo].[View_SalesPerson_" & ComName & "] ", Cnn)
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral1.ExecuteNonQuery()
                Cnn.Close()

                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()
            Catch ex1 As Exception

            End Try

        End Try


        'DAGeneral.SelectCommand.CommandText = " SELECT     service_center_head.add_user,'' as id_service_center, service_center_head.date_refer, SUM(CASE WHEN (service_center_dtl.type_select = 'I' OR " & _
        '                "  service_center_dtl.type_select = 'O') THEN ISNULL(service_center_dtl.qty, 0) ELSE 0 END * (ISNULL(service_center_dtl.price, 0)  " & _
        '                "  + ISNULL(service_center_dtl.fet, 0))) AS price_Tire, SUM(CASE WHEN (type_select = 'L' OR " & _
        '                "  type_select = 'S') THEN ISNULL(service_center_dtl.qty, 0) ELSE 0 END * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0)))  " & _
        '                "  AS price_Label, SUM(CASE WHEN (service_center_dtl.type_select = 'F') THEN ISNULL(service_center_dtl.qty, 0)  " & _
        '                "  ELSE 0 END * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS price_Fees, 1 AS flag, SUM(ISNULL(service_center_dtl.qty,  " & _
        '                "  0) * ISNULL(service_center_dtl.fet, 0)) AS Fet, SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0)  " & _
        '                "  + ISNULL(service_center_dtl.fet, 0))) AS Price_subtotal, SUM(ROUND(ISNULL(service_center_head.tax, 0), 2)) AS tax,  " & _
        '                "  SUM(ROUND(ISNULL(service_center_head.discount, 0), 2)) AS discount, SUM(ROUND(ISNULL(service_center_head.Total, 0), 2)) AS total,'' as Name_customer, '' as license_no_vehicle " & _
        '                " FROM         service_center_dtl INNER JOIN " & _
        '                "  service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN " & _
        '                "  employee ON service_center_dtl.cod_technician = employee.employee_code " & _
        '                " WHERE     (service_center_head.type_of_form = 'IN') " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
        '                " GROUP BY service_center_head.add_user, service_center_head.date_refer " & _
        '                " ORDER BY dbo.ChangeDate(service_center_head.date_refer) "

        'DAGeneral.SelectCommand.CommandText = " SELECT     add_user, '' AS id_service_center, date_refer, " & _
        '               "   (SELECT     SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) " & _
        '               "      FROM         service_center_dtl INNER JOIN " & _
        '               "                            service_center_head h ON service_center_dtl.id_service_center = h.id_service_center INNER JOIN " & _
        '               "                            employee ON service_center_dtl.cod_technician = employee.employee_code " & _
        '               "      WHERE     (h.type_of_form = 'IN') AND service_center_head.add_user = h.add_user AND service_center_head.date_refer = h.date_refer AND  " & _
        '               "                            (service_center_dtl.type_select = 'I' OR " & _
        '               "                            service_center_dtl.type_select = 'O')" & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & ") AS price_Tire, " & _
        '               "   (SELECT     SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) " & _
        '               "      FROM         service_center_dtl INNER JOIN " & _
        '               "                            service_center_head h ON service_center_dtl.id_service_center = h.id_service_center INNER JOIN " & _
        '               "                            employee ON service_center_dtl.cod_technician = employee.employee_code " & _
        '               "      WHERE     (h.type_of_form = 'IN') AND service_center_head.add_user = h.add_user AND service_center_head.date_refer = h.date_refer AND  " & _
        '               "                           (service_center_dtl.type_select = 'L' OR " & _
        '               "                            service_center_dtl.type_select = 'S')" & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & ") AS price_Label, " & _
        '               "   (SELECT     SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) " & _
        '               "      FROM         service_center_dtl INNER JOIN " & _
        '               "                            service_center_head h ON service_center_dtl.id_service_center = h.id_service_center INNER JOIN " & _
        '               "                            employee ON service_center_dtl.cod_technician = employee.employee_code " & _
        '               "      WHERE     (h.type_of_form = 'IN') AND service_center_head.add_user = h.add_user AND service_center_head.date_refer = h.date_refer AND  " & _
        '               "                            (service_center_dtl.type_select = 'F')" & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & ") AS price_Fees, 1 AS flag, " & _
        '               "   (SELECT     SUM(ISNULL(service_center_dtl.qty, 0) * (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) " & _
        '               "      FROM         service_center_dtl INNER JOIN " & _
        '               "                            service_center_head h ON service_center_dtl.id_service_center = h.id_service_center INNER JOIN " & _
        '               "                            employee ON service_center_dtl.cod_technician = employee.employee_code " & _
        '               "      WHERE     (h.type_of_form = 'IN') AND service_center_head.add_user = h.add_user AND service_center_head.date_refer = h.date_refer " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & " )  " & _
        '      "                       AS Price_subtotal, SUM(DISTINCT ROUND(ISNULL(tax, 0), 2)) AS tax, SUM(DISTINCT ROUND(ISNULL(discount, 0), 2)) AS discount,  " & _
        '      "                       SUM(DISTINCT ROUND(ISNULL(Total, 0), 2)) AS total, '' AS Name_customer, '' AS license_no_vehicle " & _
        '      " FROM         service_center_head " & _
        '      " WHERE     (type_of_form = 'IN')  " & _
        '      " GROUP BY add_user, date_refer " & _
        '      " ORDER BY dbo.ChangeDate(date_refer) "

        DAGeneral.SelectCommand.CommandText = "SELECT     add_user, date_refer, '' AS id_service_center, SUM(price_Tire) AS price_Tire, SUM(price_Label) AS price_Label, SUM(price_Fees) AS price_Fees, " & _
                      " 1 AS flag, SUM(Fet) AS Fet, SUM(Price_subtotal) AS Price_subtotal, SUM(tax) AS tax, SUM(discount) AS ASdiscount, SUM(total) AS total,  " & _
                      " '' AS Name_customer, '' AS license_no_vehicle " & _
                      " FROM    View_SalesPerson_" & ComName & _
                      " GROUP BY add_user, date_refer "


        DAGeneral.Fill(DsFrmPrint1.SaleDetail)

        Dim str As String
        For i As Integer = 0 To DsFrmPrint1.SaleDetail.Rows.Count - 1
            If DsFrmPrint1.Users.FindByUserId(DsFrmPrint1.SaleDetail(i).add_user) Is Nothing Then
                str = ""
            Else
                str = DsFrmPrint1.Users.FindByUserId(DsFrmPrint1.SaleDetail(i).add_user).UserLogin
            End If
            DsFrmPrint1.SaleDetail(i).Add_user_Name = str
        Next
        GrdSale.RootTable.Columns.RemoveAt(13)
        GrdSale.RootTable.Columns.RemoveAt(12)
        GrdSale.RootTable.Columns.RemoveAt(2)

        Try
            CmdGeneral.CommandText = " drop view [dbo].[View_SalesPerson_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try


        GrdSale.BringToFront()
    End Sub
    Private Sub PayrollDetail()

        Dim CmdGeneral As New SqlClient.SqlCommand("", Cnn)
        'CmdGeneral.CommandText = " CREATE VIEW dbo.View_PayrollEmployee_" & ComName & _
        '          " AS " & _
        '           " SELECT DISTINCT  employee.employee_code, employee.l_name + ' ' + employee.m_name + ' ' +  employee.f_name AS name, pay_main_employee.PayrollDate, " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '01' THEN pay_deductin_main_dtl.amount_deduction_employee END AS loan,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '02' THEN pay_deductin_main_dtl.amount_deduction_employee END AS saving,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '03' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Advance,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '04' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Gurnish,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '05' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Other,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '06' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Federal,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '07' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Social,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '08' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Medicare,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '09' THEN pay_deductin_main_dtl.amount_deduction_employee END AS StateTax,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '10' THEN pay_deductin_main_dtl.amount_deduction_employee END AS UnEmpTax,  " & _
        '                "    pay_main_employee.gross_pay, pay_deductin_main_dtl.deduction_type, pay_deductin_main_dtl.amount_deduction_employee,  " & _
        '                "    View_EmployeeNetPay.NetPay, bank_check.no_of_check" & _
        '        " FROM         pay_main_employee INNER JOIN " & _
        '                "    employee ON pay_main_employee.employee_code = employee.employee_code INNER JOIN " & _
        '                "    pay_deductin_main_dtl ON pay_main_employee.id_pay_period = pay_deductin_main_dtl.id_pay_period INNER JOIN " & _
        '                "    bank_check ON pay_main_employee.id_check = bank_check.id_check INNER JOIN " & _
        '                "    View_EmployeeNetPay ON pay_main_employee.PayrollDate = View_EmployeeNetPay.PayrollDate AND  " & _
        '                "    pay_main_employee.employee_code = View_EmployeeNetPay.employee_code " & _
        '       " WHERE     (pay_deductin_main_dtl.amount_deduction_employee > 0) " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere)

        CmdGeneral.CommandText = " CREATE VIEW dbo.View_PayrollEmployee_" & ComName & _
                  " AS " & _
            " SELECT     SUM(ROUND(ISNULL(loan, 0), 2)) AS loan, SUM(ROUND(ISNULL(saving, 0), 2)) AS saving, SUM(ROUND(ISNULL(Advance, 0), 2)) AS Advance,  " & _
            "  SUM(ROUND(ISNULL(Gurnish, 0), 2)) AS Gurnish, SUM(ROUND(ISNULL(Other, 0), 2)) AS Other, SUM(ROUND(ISNULL(Federal, 0), 2)) AS Federal,  " & _
            "  SUM(ROUND(ISNULL(Social, 0), 2)) AS Social, SUM(ROUND(ISNULL(Medicare, 0), 2)) AS Medicare, SUM(ROUND(ISNULL(StateTax, 0), 2))  " & _
            "  AS StateTax, SUM(ROUND(ISNULL(UnEmpTax, 0), 2)) AS UnEmpTax, id_pay_period " & _
            " FROM ( SELECT     CASE pay_deductin_main_dtl.deduction_type WHEN '01' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS loan,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '02' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS saving,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '03' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Advance,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '04' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Gurnish,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '05' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Other,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '06' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Federal,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '07' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Social,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '08' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Medicare,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '09' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS StateTax,  " & _
                        "   CASE pay_deductin_main_dtl.deduction_type WHEN '10' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS UnEmpTax,  " & _
                        "   id_pay_period " & _
                   " FROM         dbo.pay_deductin_main_dtl " & _
                   " WHERE     (amount_deduction_employee > 0) " & _
                   " GROUP BY deduction_type, id_pay_period ) aa " & _
           " GROUP BY id_pay_period "

        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If

            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

            Try
                Dim CmdGeneral1 As New SqlClient.SqlCommand(" drop view [dbo].[View_PayrollEmployee_" & ComName & "] ", Cnn)
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral1.ExecuteNonQuery()
                Cnn.Close()

                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()
            Catch ex1 As Exception

            End Try

        End Try




        'DAGeneral.SelectCommand.CommandText = " SELECT     name, PayrollDate, SUM(ROUND(ISNULL(loan, 0), 2)) AS loan, SUM(ROUND(ISNULL(saving, 0), 2)) AS saving, SUM(ROUND(ISNULL(Advance, 0), 2))  " & _
        '"                       AS Advance, SUM(ROUND(ISNULL(Gurnish, 0), 2)) AS Gurnish, SUM(ROUND(ISNULL(Other, 0), 2)) AS Other, SUM(ROUND(ISNULL(Federal, 0), 2))  " & _
        '"                       AS Federal, SUM(ROUND(ISNULL(Social, 0), 2)) AS Social, SUM(ROUND(ISNULL(Medicare, 0), 2)) AS Medicare, SUM(ROUND(ISNULL(StateTax, 0), 2))  " & _
        '"                       AS StateTax, SUM(ROUND(ISNULL(UnEmpTax, 0), 2)) AS UnEmpTax, SUM(ROUND(ISNULL(gross_pay, 0), 2)) AS gross_pay,  " & _
        '"                       SUM(ROUND(ISNULL(NetPay, 0), 2)) AS NetPay, no_of_check ,1 as flag" & _
        '" FROM       dbo.View_PayrollEmployee_" & ComName & _
        '" GROUP BY name, PayrollDate, no_of_check " & _
        '" ORDER BY name, dbo.ChangeDate(PayrollDate) "
        'DAGeneral.SelectCommand.CommandText = " SELECT     dbo.employee.employee_code, dbo.employee.l_name + ' ' + dbo.employee.m_name + ' ' +  dbo.employee.f_name AS name,  " & _
        '                        "    dbo.pay_main_employee.PayrollDate, aaaa.loan, aaaa.saving, aaaa.Advance, aaaa.Gurnish, aaaa.Other, aaaa.Federal,  " & _
        '                        "    aaaa.Social, aaaa.Medicare, aaaa.StateTax, aaaa.UnEmpTax, dbo.pay_main_employee.gross_pay,  " & _
        '                        "    dbo.View_EmployeeNetPay.NetPay, dbo.bank_check.no_of_check " & _
        '            " FROM         dbo.pay_main_employee INNER JOIN " & _
        '                        "   dbo.employee ON dbo.pay_main_employee.employee_code = dbo.employee.employee_code INNER JOIN " & _
        '                        "    dbo.bank_check ON dbo.pay_main_employee.id_check = dbo.bank_check.id_check INNER JOIN " & _
        '                        "   dbo.View_EmployeeNetPay ON dbo.pay_main_employee.PayrollDate = dbo.View_EmployeeNetPay.PayrollDate AND " & _
        '                        "    dbo.pay_main_employee.employee_code = dbo.View_EmployeeNetPay.employee_code INNER JOIN " & _
        '                        "  dbo.View_PayrollEmployee_" & ComName & " aaaa ON dbo.pay_main_employee.id_pay_period = aaaa.id_pay_period " & _
        '        IIf(StrWhere.Trim.Length = 0, "", " WHERE" & StrWhere)
        ''''
        '''net pay az rooye view bood hala khodam mohasebeh mikonam(chon duplicate mishod)

        DAGeneral.SelectCommand.CommandText = " SELECT     employee.employee_code, employee.l_name + ' ' + employee.m_name + ' ' + employee.f_name AS name, pay_main_employee.PayrollDate,  " & _
"                       aaaa.loan, aaaa.saving, aaaa.Advance, aaaa.Gurnish, aaaa.Other, aaaa.Federal, aaaa.Social, aaaa.Medicare, aaaa.StateTax, aaaa.UnEmpTax,  " & _
"                       pay_main_employee.gross_pay, ISNULL(pay_main_employee.gross_pay, 0) - " & _
"                           (SELECT     ISNULL(SUM(pay_deductin_main_dtl.amount_deduction_employee), 0) " & _
"                              FROM         pay_deductin_main_dtl " & _
"                              WHERE     pay_deductin_main_dtl.id_pay_period = dbo.pay_main_employee.id_pay_period) AS NetPay, bank_check.no_of_check,  " & _
"                       aaaa.id_pay_period ,1 as flag" & _
" FROM         pay_main_employee INNER JOIN " & _
"                       employee ON pay_main_employee.employee_code = employee.employee_code INNER JOIN " & _
"                       bank_check ON pay_main_employee.id_check = bank_check.id_check INNER JOIN " & _
"                      dbo.View_PayrollEmployee_" & ComName & " aaaa  ON pay_main_employee.id_pay_period = aaaa.id_pay_period " & _
                      IIf(StrWhere.Trim.Length = 0, "", " WHERE" & StrWhere)


        Try
            DAGeneral.Fill(DsFrmPrint1.Payroll)
        Catch ex As Exception

        End Try



        Try
            CmdGeneral.CommandText = " drop view [dbo].[View_PayrollEmployee_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try
        GrdPayroll.BringToFront()
    End Sub
    Private Sub PayrollSummery()

        Dim CmdGeneral As New SqlClient.SqlCommand("", Cnn)
        'CmdGeneral.CommandText = " CREATE VIEW dbo.View_PayrollEmployee_" & ComName & _
        '          " AS " & _
        '           " SELECT DISTINCT  employee.employee_code, employee.l_name + ' ' + employee.m_name + ' ' +  employee.f_name AS name, pay_main_employee.PayrollDate, " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '01' THEN pay_deductin_main_dtl.amount_deduction_employee END AS loan,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '02' THEN pay_deductin_main_dtl.amount_deduction_employee END AS saving,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '03' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Advance,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '04' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Gurnish,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '05' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Other,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '06' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Federal,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '07' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Social,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '08' THEN pay_deductin_main_dtl.amount_deduction_employee END AS Medicare,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '09' THEN pay_deductin_main_dtl.amount_deduction_employee END AS StateTax,  " & _
        '                "    CASE pay_deductin_main_dtl.deduction_type WHEN '10' THEN pay_deductin_main_dtl.amount_deduction_employee END AS UnEmpTax,  " & _
        '                "    pay_main_employee.gross_pay, pay_deductin_main_dtl.deduction_type, pay_deductin_main_dtl.amount_deduction_employee,  " & _
        '                "    View_EmployeeNetPay.NetPay, bank_check.no_of_check" & _
        '        " FROM         pay_main_employee INNER JOIN " & _
        '                "    employee ON pay_main_employee.employee_code = employee.employee_code INNER JOIN " & _
        '                "    pay_deductin_main_dtl ON pay_main_employee.id_pay_period = pay_deductin_main_dtl.id_pay_period INNER JOIN " & _
        '                "    bank_check ON pay_main_employee.id_check = bank_check.id_check INNER JOIN " & _
        '                "    View_EmployeeNetPay ON pay_main_employee.PayrollDate = View_EmployeeNetPay.PayrollDate AND  " & _
        '                "    pay_main_employee.employee_code = View_EmployeeNetPay.employee_code " & _
        '       " WHERE     (pay_deductin_main_dtl.amount_deduction_employee > 0) " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere)

        CmdGeneral.CommandText = " CREATE VIEW dbo.View_PayrollEmployee_" & ComName & _
               " AS " & _
         " SELECT     SUM(ROUND(ISNULL(loan, 0), 2)) AS loan, SUM(ROUND(ISNULL(saving, 0), 2)) AS saving, SUM(ROUND(ISNULL(Advance, 0), 2)) AS Advance,  " & _
         "  SUM(ROUND(ISNULL(Gurnish, 0), 2)) AS Gurnish, SUM(ROUND(ISNULL(Other, 0), 2)) AS Other, SUM(ROUND(ISNULL(Federal, 0), 2)) AS Federal,  " & _
         "  SUM(ROUND(ISNULL(Social, 0), 2)) AS Social, SUM(ROUND(ISNULL(Medicare, 0), 2)) AS Medicare, SUM(ROUND(ISNULL(StateTax, 0), 2))  " & _
         "  AS StateTax, SUM(ROUND(ISNULL(UnEmpTax, 0), 2)) AS UnEmpTax,SUM(ROUND(ISNULL(amount_deduction_employee, 0), 2))  as amount_deduction_employee, id_pay_period " & _
         " FROM ( SELECT     CASE pay_deductin_main_dtl.deduction_type WHEN '01' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS loan,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '02' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS saving,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '03' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Advance,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '04' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Gurnish,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '05' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Other,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '06' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Federal,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '07' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Social,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '08' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS Medicare,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '09' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS StateTax,  " & _
                     "   CASE pay_deductin_main_dtl.deduction_type WHEN '10' THEN SUM(pay_deductin_main_dtl.amount_deduction_employee) END AS UnEmpTax,  " & _
                     "  sum( pay_deductin_main_dtl.amount_deduction_employee) as  amount_deduction_employee,id_pay_period " & _
                " FROM         dbo.pay_deductin_main_dtl " & _
                " WHERE     (amount_deduction_employee > 0) " & _
                " GROUP BY deduction_type, id_pay_period ) aa " & _
        " GROUP BY id_pay_period "

        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If

            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

            Try
                Dim CmdGeneral1 As New SqlClient.SqlCommand(" drop view [dbo].[View_PayrollEmployee_" & ComName & "] ", Cnn)
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral1.ExecuteNonQuery()
                Cnn.Close()

                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                Cnn.Close()
            Catch ex1 As Exception

            End Try

        End Try



        'DAGeneral.SelectCommand.CommandText = " SELECT     name, '' as PayrollDate, SUM(ROUND(ISNULL(loan, 0), 2)) AS loan, SUM(ROUND(ISNULL(saving, 0), 2)) AS saving, SUM(ROUND(ISNULL(Advance, 0), 2))  " & _
        '"                       AS Advance, SUM(ROUND(ISNULL(Gurnish, 0), 2)) AS Gurnish, SUM(ROUND(ISNULL(Other, 0), 2)) AS Other, SUM(ROUND(ISNULL(Federal, 0), 2))  " & _
        '"                       AS Federal, SUM(ROUND(ISNULL(Social, 0), 2)) AS Social, SUM(ROUND(ISNULL(Medicare, 0), 2)) AS Medicare, SUM(ROUND(ISNULL(StateTax, 0), 2))  " & _
        '"                       AS StateTax, SUM(ROUND(ISNULL(UnEmpTax, 0), 2)) AS UnEmpTax, SUM(ROUND(ISNULL(gross_pay, 0), 2)) AS gross_pay,  " & _
        '"                       SUM(ROUND(ISNULL(NetPay, 0), 2)) AS NetPay,'' as  no_of_check ,1 as flag" & _
        '" FROM       dbo.View_PayrollEmployee_" & ComName & _
        '" GROUP BY name " & _
        '" ORDER BY name "
        'DAGeneral.SelectCommand.CommandText = " SELECT     dbo.employee.employee_code, dbo.employee.l_name + ' ' + dbo.employee.m_name + ' ' + dbo.employee.f_name AS name,null as PayrollDate, SUM(aaaa.loan)  " & _
        '                "    AS loan, SUM(aaaa.saving) AS saving, SUM(aaaa.Advance) AS Advance, SUM(aaaa.Gurnish) AS Gurnish, SUM(aaaa.Other) AS Other,  " & _
        '                "    SUM(aaaa.Federal) AS Federal, SUM(aaaa.Social) AS Social, SUM(aaaa.Medicare) AS Medicare, SUM(aaaa.StateTax) AS StateTax,  " & _
        '                "    SUM(aaaa.UnEmpTax) AS UnEmpTax, SUM(dbo.pay_main_employee.gross_pay) AS gross_pay, SUM(dbo.View_EmployeeNetPay.NetPay)  " & _
        '                "    AS NetPAy ,1 as flag" & _
        '      " FROM         dbo.pay_main_employee INNER JOIN " & _
        '                "    dbo.employee ON dbo.pay_main_employee.employee_code = dbo.employee.employee_code INNER JOIN " & _
        '                "    dbo.bank_check ON dbo.pay_main_employee.id_check = dbo.bank_check.id_check INNER JOIN " & _
        '                "    dbo.View_EmployeeNetPay ON dbo.pay_main_employee.PayrollDate = dbo.View_EmployeeNetPay.PayrollDate AND  " & _
        '                "    dbo.pay_main_employee.employee_code = dbo.View_EmployeeNetPay.employee_code INNER JOIN " & _
        '                "  dbo.View_PayrollEmployee_" & ComName & " aaaa ON dbo.pay_main_employee.id_pay_period = aaaa.id_pay_period " & _
        '    IIf(StrWhere.Trim.Length = 0, "", " WHERE" & StrWhere) & _
        '    " GROUP BY dbo.employee.employee_code, dbo.employee.l_name, dbo.employee.m_name, dbo.employee.f_name "

        ''''
        '''net pay az rooye view bood hala khodam mohasebeh mikonam(chon duplicate mishod)

        DAGeneral.SelectCommand.CommandText = " SELECT     dbo.employee.employee_code, dbo.employee.l_name + ' ' + dbo.employee.m_name + ' ' + dbo.employee.f_name AS name,null as PayrollDate, SUM(aaaa.loan)  " & _
                               "    AS loan, SUM(aaaa.saving) AS saving, SUM(aaaa.Advance) AS Advance, SUM(aaaa.Gurnish) AS Gurnish, SUM(aaaa.Other) AS Other,  " & _
                               "    SUM(aaaa.Federal) AS Federal, SUM(aaaa.Social) AS Social, SUM(aaaa.Medicare) AS Medicare, SUM(aaaa.StateTax) AS StateTax,  " & _
                               "    SUM(aaaa.UnEmpTax) AS UnEmpTax, SUM(dbo.pay_main_employee.gross_pay) AS gross_pay, SUM( ISNULL(pay_main_employee.gross_pay, 0)- isnull(aaaa.amount_deduction_employee,0) )  " & _
                               "    AS NetPAy ,1 as flag" & _
                    " FROM         pay_main_employee INNER JOIN " & _
"                       employee ON pay_main_employee.employee_code = employee.employee_code INNER JOIN " & _
"                       bank_check ON pay_main_employee.id_check = bank_check.id_check INNER JOIN " & _
"  dbo.View_PayrollEmployee_" & ComName & " aaaa ON pay_main_employee.id_pay_period = aaaa.id_pay_period " & _
                   IIf(StrWhere.Trim.Length = 0, "", " WHERE" & StrWhere) & _
                   " GROUP BY dbo.employee.employee_code, dbo.employee.l_name, dbo.employee.m_name, dbo.employee.f_name "



        Try
            DAGeneral.Fill(DsFrmPrint1.Payroll)
        Catch ex As Exception

        End Try




        Try
            CmdGeneral.CommandText = " drop view [dbo].[View_PayrollEmployee_" & ComName & "] "
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception

        End Try
        GrdPayroll.RootTable.Columns.RemoveAt(14)
        GrdPayroll.RootTable.Columns.RemoveAt(2)
        GrdPayroll.RootTable.Groups.RemoveAt(0)
        GrdPayroll.GroupTotals = GroupTotals.Never
        GrdPayroll.BringToFront()
    End Sub
    Private Sub FillFutaReport()

        DAGeneral.SelectCommand.CommandText = " SELECT     employee.employee_code, employee.l_name + ' ' + employee.m_name + ' ' + employee.f_name AS name, employee.social_security_no,  " & _
                      "   SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2)) AS gross_pay, 70000 AS FUTA,  " & _
                      "  CASE WHEN SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2))  " & _
                      "  - 70000 < 0 THEN 0 ELSE SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2)) - 70000 END AS EXCEED,  " & _
                      "   CASE WHEN SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2)) - 70000 < 0 THEN SUM(ROUND(ISNULL(pay_main_employee.gross_pay,  " & _
                      "    0), 2)) ELSE 70000 END AS Taxable ,1 as flag" & _
                      " FROM         pay_main_employee INNER JOIN " & _
                      "  employee ON pay_main_employee.employee_code = employee.employee_code " & _
                      " GROUP BY employee.employee_code, employee.l_name, employee.m_name, employee.f_name, employee.social_security_no "
        DAGeneral.Fill(DsFrmPrint1.FUTA)


    End Sub
    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case KindOfReport
            Case KindReport.TechnicianDetail
                For i As Integer = 0 To DsFrmPrint1.service_center_dtl.Count - 1
                    DsFrmPrint1.service_center_dtl_Header(i).flag = False
                Next
            Case KindReport.TechnicianSummery
                For i As Integer = 0 To DsFrmPrint1.service_center_head.Count - 1
                    DsFrmPrint1.service_center_head(i).flag = False
                Next
            Case KindReport.SaleDetail, KindReport.SaleSummery

                For i As Integer = 0 To DsFrmPrint1.SaleDetail.Count - 1
                    DsFrmPrint1.SaleDetail(i).flag = False
                Next
            Case KindReport.PayrollDetail, KindReport.PayrollDetail
                For i As Integer = 0 To DsFrmPrint1.Payroll.Count - 1
                    DsFrmPrint1.Payroll(i).flag = False
                Next
        End Select
        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case KindOfReport
            Case KindReport.TechnicianDetail
                For i As Integer = 0 To DsFrmPrint1.service_center_dtl.Count - 1
                    DsFrmPrint1.service_center_dtl_Header(i).flag = True
                Next
            Case KindReport.TechnicianSummery
                For i As Integer = 0 To DsFrmPrint1.service_center_head.Count - 1
                    DsFrmPrint1.service_center_head(i).flag = True
                Next
            Case KindReport.SaleDetail, KindReport.SaleSummery
                For i As Integer = 0 To DsFrmPrint1.SaleDetail.Count - 1
                    DsFrmPrint1.SaleDetail(i).flag = True
                Next
            Case KindReport.PayrollDetail, KindReport.PayrollDetail
                For i As Integer = 0 To DsFrmPrint1.Payroll.Count - 1
                    DsFrmPrint1.Payroll(i).flag = True
                Next

        End Select
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub


    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    End Sub

    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        Select Case KindOfReport
            Case KindReport.TechnicianDetail
                GridEXPrintDocument1.GridEX = GrdTechnicianDtl
                GridEXPrintDocument1.PrintHierarchical = True
            Case KindReport.TechnicianSummery
                GridEXPrintDocument1.GridEX = GrdTechnicianSummer
            Case KindReport.SaleDetail, KindReport.SaleSummery
                GridEXPrintDocument1.GridEX = GrdSale
            Case KindReport.PayrollDetail, KindReport.PAyrollSummery
                GridEXPrintDocument1.GridEX = GrdPayroll
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
            Case KindReport.TechnicianDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdTechnicianDtl)
            Case KindReport.TechnicianSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdTechnicianSummer)
            Case KindReport.SaleDetail, KindReport.SaleSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdSale)
            Case KindReport.PayrollDetail, KindReport.PAyrollSummery
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdPayroll)
        End Select
    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case KindOfReport
            Case KindReport.TechnicianDetail
                Me.GrdTechnicianDtl.ShowFieldChooser(Me)
            Case KindReport.TechnicianSummery
                Me.GrdTechnicianSummer.ShowFieldChooser(Me)
            Case KindReport.SaleDetail, KindReport.SaleSummery
                Me.GrdSale.ShowFieldChooser(Me)
            Case KindReport.PayrollDetail, KindReport.PAyrollSummery
                Me.GrdPayroll.ShowFieldChooser(Me)
        End Select

    End Sub


    Private Sub GrdTechnicianDtl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdTechnicianDtl.DoubleClick
        If GrdTechnicianDtl.RowCount > 0 Then
            Try
                Dim Currentrow As GridEXRow = GrdTechnicianDtl.GetRow
                Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                Select Case Mid(Currentrow.Cells("id_service_center").Value, 1, 2)
                    Case "IN"
                        MyFrmShowWorkOrder.TypeOfForm = "IN"
                    Case "RT"

                        MyFrmShowWorkOrder.TypeOfForm = "RT"
                    Case Else
                        Exit Sub
                End Select
                MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
                MyFrmShowWorkOrder.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub CmbChildLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChild.Click
        If CmbChild.Text = "Expand" Then
            CmbChild.Text = "Collapse"
            GrdTechnicianDtl.ExpandRecords(GrdTechnicianDtl.RootTable.ChildTables(0))
        Else
            CmbChild.Text = "Expand"
            GrdTechnicianDtl.CollapseRecords(GrdTechnicianDtl.RootTable.ChildTables(0))
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

    Private Sub GrdSale_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdSale.FormattingRow

    End Sub

    Private Sub GrdSale_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdSale.DoubleClick
        If GrdSale.RowCount > 0 Then
            Try
                Dim Currentrow As GridEXRow = GrdSale.GetRow
                Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                Select Case Mid(Currentrow.Cells("id_service_center").Value, 1, 2)
                    Case "IN"
                        MyFrmShowWorkOrder.TypeOfForm = "IN"
                    Case "RT"

                        MyFrmShowWorkOrder.TypeOfForm = "RT"
                    Case Else
                        Exit Sub
                End Select
                MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
                MyFrmShowWorkOrder.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class
