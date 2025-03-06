Imports CommonClass
Imports Janus.Windows.GridEX

Public Class FrmPrintLaborAndFees
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
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents DsFrmPrintLaborAndFees1 As Report.DSFrmPrintLaborAndFees
    Friend WithEvents DAservice_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmPrint1 As Report.DSFrmPrint
    Friend WithEvents GrdList As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrintLaborAndFees))
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPrintLaborAndFees1 = New Report.DSFrmPrintLaborAndFees
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GrdSummery = New Janus.Windows.GridEX.GridEX
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GrdList = New Janus.Windows.GridEX.GridEX
        Me.Panel4.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPrintLaborAndFees1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Size = New System.Drawing.Size(606, 64)
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
        Me.Label1.Size = New System.Drawing.Size(150, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the Item That you want to print"
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
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GrdDetail
        '
        'GrdDetail
        '
        Me.GrdDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.DataMember = "Detail"
        Me.GrdDetail.DataSource = Me.DsFrmPrintLaborAndFees1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Detail</Caption><Columns Collection=""true"">" & _
        "<Column0 ID=""Flag""><ColumnType>CheckBox</ColumnType><DataMember>Flag</DataMember" & _
        "><EditType>CheckBox</EditType><Key>Flag</Key><Position>0</Position><Width>22</Wi" & _
        "dth></Column0><Column1 ID=""id_service_center""><Caption>id_service_center</Captio" & _
        "n><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyString" & _
        "Value /><DataMember>id_service_center</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><Key>id_service_center</Key><Position>1</Po" & _
        "sition><Visible>False</Visible></Column1><Column2 ID=""cod_select""><Caption>Code<" & _
        "/Caption><DataMember>cod_select</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>TextBox</FilterEditType><Key>cod_select</Key><Position>2</Position><Width" & _
        ">59</Width></Column2><Column3 ID=""desc_service""><Caption>Description</Caption><D" & _
        "ataMember>desc_service</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><Key>desc_service</Key><Position>3</Position><Width>166</W" & _
        "idth></Column3><Column4 ID=""qty""><AggregateFunction>Sum</AggregateFunction><Capt" & _
        "ion>Qty</Caption><DataMember>qty</DataMember><EditType>NoEdit</EditType><FilterE" & _
        "ditType>TextBox</FilterEditType><FormatString>####.##</FormatString><Key>qty</Ke" & _
        "y><Position>4</Position><TextAlignment>Far</TextAlignment><Width>54</Width></Col" & _
        "umn4><Column5 ID=""UnitPrice""><AggregateFunction>Sum</AggregateFunction><Caption>" & _
        "Unit Price</Caption><DataMember>UnitPrice</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Uni" & _
        "tPrice</Key><Position>5</Position><TextAlignment>Far</TextAlignment><Width>66</W" & _
        "idth><TotalFormatString>c2</TotalFormatString></Column5><Column6 ID=""Ext_Price"">" & _
        "<AggregateFunction>Sum</AggregateFunction><Caption>Ext. Price</Caption><DataMemb" & _
        "er>Ext_Price</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fil" & _
        "terEditType><FormatString>c2</FormatString><Key>Ext_Price</Key><Position>6</Posi" & _
        "tion><TextAlignment>Far</TextAlignment><Width>70</Width><TotalFormatString>C2</T" & _
        "otalFormatString></Column6><Column7 ID=""Cost""><AggregateFunction>Sum</AggregateF" & _
        "unction><Caption>Ext. Cost</Caption><DataMember>Cost</DataMember><EditType>NoEdi" & _
        "t</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStri" & _
        "ng><Key>Cost</Key><Position>7</Position><TextAlignment>Far</TextAlignment><Width" & _
        ">73</Width><TotalFormatString>c2</TotalFormatString></Column7><Column8 ID=""GrPro" & _
        "fAmount""><AggregateFunction>Sum</AggregateFunction><Caption>Gr. Prof $</Caption>" & _
        "<DataMember>GrProfAmount</DataMember><EditType>NoEdit</EditType><FilterEditType>" & _
        "TextBox</FilterEditType><FormatString>c2</FormatString><Key>GrProfAmount</Key><P" & _
        "osition>8</Position><TextAlignment>Far</TextAlignment><Width>72</Width><TotalFor" & _
        "matString>c2</TotalFormatString></Column8><Column9 ID=""GrProfPercent""><Caption>G" & _
        "r. Prof %</Caption><DataMember>GrProfPercent</DataMember><EditType>NoEdit</EditT" & _
        "ype><FilterEditType>TextBox</FilterEditType><Key>GrProfPercent</Key><Position>9<" & _
        "/Position><TextAlignment>Far</TextAlignment><Width>69</Width></Column9><Column10" & _
        " ID=""Type""><Caption>Type</Caption><DataMember>Type</DataMember><EditType>NoEdit<" & _
        "/EditType><FilterEditType>TextBox</FilterEditType><Key>Type</Key><Position>10</P" & _
        "osition><Width>83</Width></Column10><Column11 ID=""desc_srvice_category""><Caption" & _
        ">Category</Caption><DataMember>desc_srvice_category</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_srvice_category</Ke" & _
        "y><Position>11</Position><Width>135</Width></Column11></Columns><GroupCondition " & _
        "ID="""" /><Key>Detail</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><Co" & _
        "lIndex>2</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(608, 392)
        Me.GrdDetail.TabIndex = 11
        Me.GrdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmPrintLaborAndFees1
        '
        Me.DsFrmPrintLaborAndFees1.DataSetName = "DSFrmPrintLaborAndFees"
        Me.DsFrmPrintLaborAndFees1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(182, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT SUM(ISNULL(service_center_dtl.qty, 0)) AS qty, SUM(ISNULL(service_center_d" & _
        "tl.qty * (service_center_dtl.price + service_center_dtl.fet), 0)) AS ExtPrice, s" & _
        "ervice_center_dtl.cod_select, inv_tab_labor_service.desc_service, 0 AS Flag FROM" & _
        " service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_serv" & _
        "ice_center = service_center_head.id_service_center LEFT OUTER JOIN inv_tab_labor" & _
        "_service ON service_center_dtl.cod_select = inv_tab_labor_service.cod_service LE" & _
        "FT OUTER JOIN inv_tab_service_type ON inv_tab_labor_service.service_type = inv_t" & _
        "ab_service_type.service_type WHERE (service_center_dtl.type_select = 'L') OR (se" & _
        "rvice_center_dtl.type_select = 'F') OR (service_center_dtl.type_select = 'S') GR" & _
        "OUP BY service_center_dtl.cod_select, inv_tab_labor_service.desc_service"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'GrdSummery
        '
        Me.GrdSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSummery.DataMember = "Summary"
        Me.GrdSummery.DataSource = Me.DsFrmPrintLaborAndFees1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>Summary</Caption><Columns Collection=""true""" & _
        "><Column0 ID=""Flag""><ColumnType>CheckBox</ColumnType><DataMember>Flag</DataMembe" & _
        "r><EditType>CheckBox</EditType><Key>Flag</Key><Position>0</Position><Width>26</W" & _
        "idth></Column0><Column1 ID=""cod_service""><Caption>Service</Caption><TypeNameEmpt" & _
        "yStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMe" & _
        "mber>cod_select</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</" & _
        "FilterEditType><Key>cod_service</Key><Position>1</Position><Width>80</Width></Co" & _
        "lumn1><Column2 ID=""desc_service""><Caption>Description</Caption><DataMember>desc_" & _
        "service</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>desc_service</Key><Position>2</Position><Width>290</Width></Column2>" & _
        "<Column3 ID=""Qty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty</Captio" & _
        "n><DataMember>Qty</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>Qty</Key><Position>3</Position><TextAlignment>Far</TextAli" & _
        "gnment><Width>77</Width></Column3><Column4 ID=""ExtPrice""><AggregateFunction>Sum<" & _
        "/AggregateFunction><Caption>Ext Price</Caption><DataMember>ExtPrice</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString" & _
        ">c2</FormatString><Key>ExtPrice</Key><Position>4</Position><TextAlignment>Far</T" & _
        "extAlignment><Width>99</Width><TotalFormatString>c2</TotalFormatString></Column4" & _
        "></Columns><GroupCondition ID="""" /><Key>Summary</Key><SortKeys Collection=""true""" & _
        "><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex></SortKey0></SortKeys></RootTable" & _
        "></GridEXLayoutData>"
        Me.GrdSummery.DesignTimeLayout = GridEXLayout2
        Me.GrdSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdSummery.Name = "GrdSummery"
        Me.GrdSummery.Size = New System.Drawing.Size(608, 392)
        Me.GrdSummery.TabIndex = 8
        Me.GrdSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DAservice_center_dtl
        '
        Me.DAservice_center_dtl.SelectCommand = Me.SqlCommand1
        Me.DAservice_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT service_center_dtl.id_service_center, ISNULL(service_center_dtl.qty, 0) AS" & _
        " qty, service_center_dtl.price + service_center_dtl.fet AS UnitPrice, ISNULL(ser" & _
        "vice_center_dtl.qty * (service_center_dtl.price + service_center_dtl.fet), 0) AS" & _
        " Ext_Price, service_center_dtl.cod_select, inv_tab_labor_service.desc_service, I" & _
        "SNULL(service_center_dtl.qty * inv_tab_labor_service.cost, 0) AS Cost, inv_tab_s" & _
        "ervice_type.service_type_desc AS Type, ISNULL(service_center_dtl.qty * (service_" & _
        "center_dtl.price + service_center_dtl.fet), 0) - ISNULL(service_center_dtl.qty *" & _
        " inv_tab_labor_service.cost, 0) AS GrProfAmount, (CASE ISNULL(service_center_dtl" & _
        ".qty * (service_center_dtl.price + service_center_dtl.fet), 0) WHEN 0 THEN 0 ELS" & _
        "E (((ISNULL(service_center_dtl.qty * (service_center_dtl.price + service_center_" & _
        "dtl.fet), 0)) - ISNULL(service_center_dtl.qty * inv_tab_labor_service.cost, 0)) " & _
        "/ (ISNULL(service_center_dtl.qty * (service_center_dtl.price + service_center_dt" & _
        "l.fet), 0))) END) * 100 AS GrProfPercent, inv_tab_service_category.desc_srvice_c" & _
        "ategory, 1 AS flag FROM inv_tab_labor_service LEFT OUTER JOIN inv_tab_service_ca" & _
        "tegory ON inv_tab_labor_service.service_category = inv_tab_service_category.serv" & _
        "ice_category RIGHT OUTER JOIN service_center_dtl INNER JOIN service_center_head " & _
        "ON service_center_dtl.id_service_center = service_center_head.id_service_center " & _
        "ON inv_tab_labor_service.cod_service = service_center_dtl.cod_select LEFT OUTER " & _
        "JOIN inv_tab_service_type ON inv_tab_labor_service.service_type = inv_tab_servic" & _
        "e_type.service_type"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'GrdList
        '
        Me.GrdList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdList.DataMember = "List"
        Me.GrdList.DataSource = Me.DsFrmPrintLaborAndFees1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Caption>Detail</Caption><Columns Collection=""true"">" & _
        "<Column0 ID=""Flag""><ColumnType>CheckBox</ColumnType><DataMember>Flag</DataMember" & _
        "><EditType>CheckBox</EditType><Key>Flag</Key><Position>0</Position><Width>22</Wi" & _
        "dth></Column0><Column1 ID=""cod_service""><Caption>Service</Caption><DataMember>co" & _
        "d_service</DataMember><FilterEditType>NoEdit</FilterEditType><Key>cod_service</K" & _
        "ey><Position>1</Position></Column1><Column2 ID=""desc_service""><Caption>Descripti" & _
        "on</Caption><DataMember>desc_service</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><Key>desc_service</Key><Position>2</Position" & _
        "></Column2><Column3 ID=""price_level1""><AggregateFunction>Sum</AggregateFunction>" & _
        "<Caption>c1</Caption><DataMember>price_level1</DataMember><EditType>NoEdit</Edit" & _
        "Type><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key" & _
        ">price_level1</Key><Position>3</Position><TotalFormatString>c2</TotalFormatStrin" & _
        "g></Column3><Column4 ID=""price_level2""><AggregateFunction>Sum</AggregateFunction" & _
        "><Caption>c2</Caption><DataMember>price_level2</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Ke" & _
        "y>price_level2</Key><Position>4</Position><TotalFormatString>c2</TotalFormatStri" & _
        "ng></Column4><Column5 ID=""price_level3""><AggregateFunction>Sum</AggregateFunctio" & _
        "n><Caption>c3</Caption><DataMember>price_level3</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><K" & _
        "ey>price_level3</Key><Position>5</Position><TotalFormatString>c2</TotalFormatStr" & _
        "ing></Column5><Column6 ID=""price_level4""><AggregateFunction>Sum</AggregateFuncti" & _
        "on><Caption>c4</Caption><DataMember>price_level4</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><" & _
        "Key>price_level4</Key><Position>6</Position><TotalFormatString>c2</TotalFormatSt" & _
        "ring></Column6><Column7 ID=""price_level5""><AggregateFunction>Sum</AggregateFunct" & _
        "ion><Caption>c5</Caption><DataMember>price_level5</DataMember><EditType>NoEdit</" & _
        "EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString>" & _
        "<Key>price_level5</Key><Position>7</Position><TotalFormatString>c2</TotalFormatS" & _
        "tring></Column7><Column8 ID=""price_level6""><AggregateFunction>Sum</AggregateFunc" & _
        "tion><Caption>c6</Caption><DataMember>price_level6</DataMember><EditType>NoEdit<" & _
        "/EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString" & _
        "><Key>price_level6</Key><Position>8</Position><TotalFormatString>c2</TotalFormat" & _
        "String></Column8><Column9 ID=""service_type_desc""><Caption>Type</Caption><DataMem" & _
        "ber>service_type_desc</DataMember><FilterEditType>TextBox</FilterEditType><Key>s" & _
        "ervice_type_desc</Key><Position>9</Position></Column9><Column10 ID=""desc_srvice_" & _
        "category""><Caption>Category</Caption><DataMember>desc_srvice_category</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_s" & _
        "rvice_category</Key><Position>10</Position></Column10></Columns><GroupCondition " & _
        "ID="""" /><Key>Detail</Key></RootTable></GridEXLayoutData>"
        Me.GrdList.DesignTimeLayout = GridEXLayout3
        Me.GrdList.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdList.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdList.Location = New System.Drawing.Point(-1, 64)
        Me.GrdList.Name = "GrdList"
        Me.GrdList.Size = New System.Drawing.Size(608, 392)
        Me.GrdList.TabIndex = 12
        Me.GrdList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.Default
        '
        'FrmPrintLaborAndFees
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(606, 452)
        Me.Controls.Add(Me.GrdList)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.GrdSummery)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "FrmPrintLaborAndFees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPrintLaborAndFees1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim i As Integer
    Public StrWhere As String
    Public ServiceType As String
    Public ServiceTypeName As String
    Dim flagselect As String = "all"
    Public TypeForm As kindform
    Public StrFilter As String
    Public Date1 As String
    Public Date2 As String
    Public DSMAIN As New DataSet
    Public FService As Boolean
    Public FCategory As Boolean
    Public fromtodate As String = ""
    Public FlagDate As Boolean
    Public Enum KindForm As Integer
        SalesDetail = 1
        Salesummery = 2
        List = 3

    End Enum
    Private Sub FrmPrintInvItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        Select Case TypeForm
            Case KindForm.SalesDetail
                Call FillSalesDetail()
            Case KindForm.Salesummery
                Call SalesSummery()
            Case KindForm.List
                Call ListReport()
        End Select
        If Date1.Trim.Length > 0 Then
            GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
        Else
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End If
        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
        If Not ServiceTypeName Is Nothing Then
            If ServiceTypeName.Trim.Length > 0 Then
                GridEXPrintDocument1.PageHeaderLeft = " Type : " & ServiceTypeName
            End If
        End If

    End Sub
    Private Sub FillSalesDetail()
        DAGeneral.SelectCommand.CommandText = DAservice_center_dtl.SelectCommand.CommandText & _
        " WHERE  (service_center_dtl.type_select = 'L' OR service_center_dtl.type_select = 'F' OR service_center_dtl.type_select = 'S') " & _
        " AND (service_center_head.type_of_form = 'IN') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2))
        DAGeneral.Fill(DsFrmPrintLaborAndFees1.Detail)
        GrdDetail.BringToFront()
        GridEXPrintDocument1.GridEX = GrdDetail
    End Sub
    Private Sub SalesSummery()
        DAGeneral.SelectCommand.CommandText = " SELECT     SUM(ISNULL(service_center_dtl.qty, 0)) AS qty, SUM(ISNULL(service_center_dtl.qty * (service_center_dtl.price + service_center_dtl.fet), 0)) " & _
"                      AS ExtPrice, service_center_dtl.cod_select, inv_tab_labor_service.desc_service, 1 AS Flag  " & _
" FROM         service_center_dtl INNER JOIN " & _
                      " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN " & _
                      " inv_tab_labor_service ON service_center_dtl.cod_select = inv_tab_labor_service.cod_service LEFT OUTER JOIN " & _
                      " inv_tab_service_type ON inv_tab_labor_service.service_type = inv_tab_service_type.service_type " & _
" WHERE  (service_center_dtl.type_select = 'L' OR service_center_dtl.type_select = 'F' OR service_center_dtl.type_select = 'S') " & _
" AND (service_center_head.type_of_form = 'IN')  " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2)) & _
" GROUP BY service_center_dtl.cod_select, inv_tab_labor_service.desc_service "

        Try
            DAGeneral.Fill(DsFrmPrintLaborAndFees1.Summary)
        Catch ex As Exception

        End Try

        GrdSummery.BringToFront()
        GridEXPrintDocument1.GridEX = GrdSummery

    End Sub
    Private Sub ListReport()

        GrdList.RootTable.Columns(3).Caption = PriceLevelsLabels(1)
        GrdList.RootTable.Columns(4).Caption = PriceLevelsLabels(2)
        GrdList.RootTable.Columns(5).Caption = PriceLevelsLabels(3)
        GrdList.RootTable.Columns(6).Caption = PriceLevelsLabels(4)
        GrdList.RootTable.Columns(7).Caption = PriceLevelsLabels(5)
        GrdList.RootTable.Columns(8).Caption = PriceLevelsLabels(6)


        DAGeneral.SelectCommand.CommandText = " SELECT     inv_tab_labor_service.cod_service, inv_tab_labor_service.desc_service, inv_tab_labor_service_price.price_level1,  " & _
                     "   inv_tab_labor_service_price.price_level2, inv_tab_labor_service_price.price_level3, inv_tab_labor_service_price.price_level4,  " & _
                     "   inv_tab_labor_service_price.price_level5, inv_tab_labor_service_price.price_level6, inv_tab_service_type.service_type_desc,  " & _
                     "   inv_tab_service_category.desc_srvice_category,1 as flag " & _
" FROM         inv_tab_labor_service INNER JOIN  " & _
                     "   inv_tab_labor_service_price ON inv_tab_labor_service.cod_service = inv_tab_labor_service_price.cod_service INNER JOIN " & _
                     "   inv_tab_style ON inv_tab_labor_service_price.style = inv_tab_style.style INNER JOIN " & _
                     "   inv_tab_service_category ON inv_tab_labor_service.service_category = inv_tab_service_category.service_category INNER JOIN " & _
                     "   inv_tab_service_type ON inv_tab_labor_service.service_type = inv_tab_service_type.service_type " & _
" WHERE     (inv_tab_labor_service.cod_service NOT IN ('1', '2', '3', '4', '5')) " & IIf(StrWhere.Trim.Length > 0, " AND  " & StrWhere, "")


        Try
            DAGeneral.Fill(DsFrmPrintLaborAndFees1.List)
        Catch ex As Exception

        End Try

        GrdList.BringToFront()
        GridEXPrintDocument1.GridEX = GrdList

    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case TypeForm
            Case KindForm.SalesDetail
                For i As Integer = 0 To DsFrmPrintLaborAndFees1.Detail.Count - 1
                    DsFrmPrintLaborAndFees1.Detail(i).flag = True
                Next
            Case KindForm.Salesummery
                For i As Integer = 0 To DsFrmPrintLaborAndFees1.Summary.Count - 1
                    DsFrmPrintLaborAndFees1.Summary(i).flag = True
                Next
            Case KindForm.List
                For i As Integer = 0 To DsFrmPrintLaborAndFees1.List.Count - 1
                    DsFrmPrintLaborAndFees1.List(i).flag = True
                Next
        End Select
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub
    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        SaveFileDialog1.Title = "Save CSV File"
        SaveFileDialog1.DefaultExt = "csv"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.FileName = "report"

        Dim FileName As String
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = SaveFileDialog1.FileName
        If System.IO.Path.GetExtension(FileName) <> ".csv" Then
            FileName = FileName.Replace(System.IO.Path.GetExtension(FileName), ".csv")

        End If

        Select Case TypeForm
            Case KindForm.SalesDetail
                Call GridToExcel2(FileName, GrdDetail)
            Case KindForm.Salesummery
                Call GridToExcel2(FileName, GrdSummery)
            Case KindForm.List
                Call GridToExcel2(FileName, GrdList)
        End Select

    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case TypeForm
            Case KindForm.SalesDetail
                Me.GrdDetail.ShowFieldChooser(Me)
            Case KindForm.Salesummery
                Me.GrdSummery.ShowFieldChooser(Me)
            Case KindForm.List
                Me.GrdList.ShowFieldChooser(Me)
        End Select
    End Sub
    Private Sub BtnJprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        DsFrmPrintLaborAndFees1.AcceptChanges()
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

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case TypeForm
            Case KindForm.SalesDetail
                For i As Integer = 0 To DsFrmPrintLaborAndFees1.Detail.Count - 1
                    DsFrmPrintLaborAndFees1.Detail(i).flag = False
                Next
            Case KindForm.Salesummery
                For i As Integer = 0 To DsFrmPrintLaborAndFees1.Summary.Count - 1
                    DsFrmPrintLaborAndFees1.Summary(i).flag = False
                Next
            Case KindForm.List
                For i As Integer = 0 To DsFrmPrintLaborAndFees1.List.Count - 1
                    DsFrmPrintLaborAndFees1.List(i).flag = False
                Next
        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Select Case TypeForm
            Case KindForm.SalesDetail
                Call pprint1("print")
            Case KindForm.Salesummery
                Call pprint2("print")
        End Select

    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click

        Select Case TypeForm
            Case KindForm.SalesDetail
                Call pprint1("priv")
            Case KindForm.Salesummery
                Call pprint2("priv")
        End Select

    End Sub
    Private Sub pprint1(ByVal type As String)

        Dim rpt As New RepSoldDetail
        Dim prn As New FrmRepView
        rpt.SetParameterValue("Fromtodate", IIf(FlagDate, fromtodate, ""))
        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)


        rpt.SetDataSource(DsFrmPrintLaborAndFees1)
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

        Dim rpt As New RepDetail
        Dim prn As New FrmRepView



        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))

        rpt.SetParameterValue("Fromtodate", IIf(FlagDate, fromtodate, ""))
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("ParStore", OleDbReaderForStore.Item("STORENAME") & "")

        rpt.SetParameterValue("Parrepname", Me.Text)

        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintLaborAndFees1)
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
    Private Sub GrdDetail_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GrdDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdDetail.GetRow

            Select Case Mid(Currentrow.Cells("RefNo").Value, 1, 2)
                Case "IN"
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("RefNo").Value & ""
                    MyFrmShowWorkOrder.Show()
                Case "RT"
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "RT"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("RefNo").Value & ""
                    MyFrmShowWorkOrder.Show()
                Case Else
                    Exit Sub
            End Select
        End If
    End Sub


    Private Sub GrdSoldDetail_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
End Class
