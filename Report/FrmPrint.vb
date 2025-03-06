Imports CommonClass
Imports Janus.Windows.GridEX

Public Class FrmPrint
    Inherits CommonClass.FrmBase
    Public StrWhere As String
    Public ItemType As String
    Public ItemTypeName As String
    Dim flagselect As String = "all"
    Public TypeForm As kindform
    Public StrFilter As String
    Public FItem As Boolean
    Public FLine As Boolean
    Public FBrand As Boolean
    Public FStyle As Boolean
    Public DSMAIN As New DataSet
    Public FlagDate As Boolean
    '    Public FromTodate As String = ""
    Public Enum KindForm As Integer
        ILR = 1
        PPL = 2
        IVR = 3
        ISR = 4
        SMR = 5
        ICS = 6
        IVRSummery = 7

    End Enum
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
    Friend WithEvents DAInvListReport As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmPrint1 As Report.DSFrmPrint
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents Grd2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Grd1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInventory As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Grd3 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtExt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrdIVRSummery As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrint))
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAInvListReport = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmPrint1 = New Report.DSFrmPrint
        Me.Grd1 = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Grd2 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAInventory = New System.Data.SqlClient.SqlDataAdapter
        Me.Grd3 = New Janus.Windows.GridEX.GridEX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.TxtExt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GrdIVRSummery = New Janus.Windows.GridEX.GridEX
        CType(Me.DsFrmPrint1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdIVRSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item.item_no, inv_item.desc_item, 0 AS size, inv_tab_brand.complete_de" & _
        "sc_brand, inv_tab_line.line, inv_tab_style.desc_style, inv_item_quick_refrence.d" & _
        "esc_quick_refrence, inv_tab_location_warehouse.desc_location FROM inv_item INNER" & _
        " JOIN inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN inv_tab_style" & _
        " ON inv_tab_line.style = inv_tab_style.style INNER JOIN inv_tab_brand ON inv_tab" & _
        "_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN inv_item_quick_refrence ON " & _
        "inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence INNER J" & _
        "OIN inv_tab_item_warehouse ON inv_item.item_no = inv_tab_item_warehouse.item_no " & _
        "INNER JOIN inv_tab_wharehouse ON inv_tab_item_warehouse.cod_warehouse = inv_tab_" & _
        "wharehouse.cod_warehouse INNER JOIN (SELECT TOP 1 cod_location, cod_warehouse, d" & _
        "esc_location FROM inv_tab_location_warehouse ORDER BY cod_location) inv_tab_loca" & _
        "tion_warehouse ON inv_tab_wharehouse.cod_warehouse = inv_tab_location_warehouse." & _
        "cod_warehouse WHERE (NOT (inv_item.cod_item_type = '01' OR inv_item.cod_item_typ" & _
        "e = '04'))"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=TireMate_01_db"
        '
        'DAInvListReport
        '
        Me.DAInvListReport.SelectCommand = Me.SqlSelectCommand1
        Me.DAInvListReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("line", "line")})})
        '
        'DsFrmPrint1
        '
        Me.DsFrmPrint1.DataSetName = "DSFrmPrint"
        Me.DsFrmPrint1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Grd1
        '
        Me.Grd1.AlternatingColors = True
        Me.Grd1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd1.DataMember = "inv_item"
        Me.Grd1.DataSource = Me.DsFrmPrint1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Allow" & _
        "Sort>False</AllowSort><ColumnType>CheckBox</ColumnType><DataMember>flag</DataMem" & _
        "ber><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><Width>22<" & _
        "/Width></Column0><Column1 ID=""item_no""><Caption>Item No</Caption><DataMember>ite" & _
        "m_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditT" & _
        "ype><Key>item_no</Key><Position>1</Position><Width>55</Width></Column1><Column2 " & _
        "ID=""desc_item""><Caption>Description</Caption><DataMember>desc_item</DataMember><" & _
        "EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_item" & _
        "</Key><Position>2</Position><Width>132</Width></Column2><Column3 ID=""size""><Capt" & _
        "ion>Size</Caption><DataMember>size</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>Combo</FilterEditType><Key>size</Key><Position>3</Position><Width>88</" & _
        "Width></Column3><Column4 ID=""five""><Caption>Bin Location</Caption><DataMember>fi" & _
        "ve</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><Key>five</Key><Position>4</Position><Width>82</Width></Column4><Column5 ID=""l" & _
        "ine""><Caption>Line</Caption><DataMember>line</DataMember><EditType>NoEdit</EditT" & _
        "ype><FilterEditType>Combo</FilterEditType><Key>line</Key><Position>5</Position><" & _
        "Width>42</Width></Column5><Column6 ID=""complete_desc_brand""><AggregateFunction>S" & _
        "um</AggregateFunction><Caption>Brand</Caption><DataMember>one</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>Combo</FilterEditType><Key>complete_desc_br" & _
        "and</Key><Position>6</Position><Width>62</Width></Column6><Column7 ID=""desc_styl" & _
        "e""><Caption>Style</Caption><DataMember>two</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>Combo</FilterEditType><Key>desc_style</Key><Position>7</Positi" & _
        "on><Width>57</Width></Column7><Column8 ID=""desc_quick_refrence""><Caption>Quick R" & _
        "efrence</Caption><DataMember>three</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><Key>desc_quick_refrence</Key><Position>8</Pos" & _
        "ition><Width>89</Width></Column8><Column9 ID=""location""><AggregateFunction>Sum</" & _
        "AggregateFunction><Caption>Bin Location</Caption><DataMember>four</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>Combo</FilterEditType><Key>location</Ke" & _
        "y><Position>9</Position><Width>75</Width><TotalFormatString>c2</TotalFormatStrin" & _
        "g></Column9><Column10 ID=""desc_price_code""><Caption>Price Code</Caption><DataMem" & _
        "ber>desc_price_code</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>desc_price_code</Key><Position>10</Position></Column10><" & _
        "/Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grd1.DesignTimeLayout = GridEXLayout1
        Me.Grd1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grd1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Grd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grd1.Location = New System.Drawing.Point(0, 64)
        Me.Grd1.Name = "Grd1"
        Me.Grd1.Size = New System.Drawing.Size(608, 344)
        Me.Grd1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the Item That you want to print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BtnDeselect)
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label3)
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
        Me.Panel4.TabIndex = 4
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
        Me.GridEXPrintDocument1.GridEX = Me.Grd1
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(66, 87)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'Grd2
        '
        Me.Grd2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd2.DataMember = "ProductPriceList"
        Me.Grd2.DataSource = Me.DsFrmPrint1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>16</Width></Column0><Column1 ID" & _
        "=""item_no""><Caption>ItemNo</Caption><TypeNameEmptyStringValue>System.String</Typ" & _
        "eNameEmptyStringValue><EmptyStringValue /><DataMember>item_no</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>item_no</Key><" & _
        "Position>1</Position><Width>51</Width></Column1><Column2 ID=""desc_item""><Caption" & _
        ">Description</Caption><DataMember>desc_item</DataMember><EditType>NoEdit</EditTy" & _
        "pe><FilterEditType>TextBox</FilterEditType><Key>desc_item</Key><Position>2</Posi" & _
        "tion><Width>148</Width></Column2><Column3 ID=""size""><Caption>size</Caption><Data" & _
        "Member>size</DataMember><EditType>NoEdit</EditType><FilterEditType>Combo</Filter" & _
        "EditType><Key>size</Key><Position>3</Position><Width>86</Width></Column3><Column" & _
        "4 ID=""line""><Caption>line</Caption><TypeNameEmptyStringValue>System.String</Type" & _
        "NameEmptyStringValue><EmptyStringValue /><DataMember>line</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>Combo</FilterEditType><Key>line</Key><Position>" & _
        "4</Position><Width>46</Width></Column4><Column5 ID=""cost""><AggregateFunction>Sum" & _
        "</AggregateFunction><Caption>Cost</Caption><DataMember>cost</DataMember><EditTyp" & _
        "e>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</For" & _
        "matString><Key>cost</Key><Position>5</Position><TextAlignment>Far</TextAlignment" & _
        "><Width>66</Width><TotalFormatString>c2</TotalFormatString></Column5><Column6 ID" & _
        "=""price_code""><Caption>Price Code</Caption><DataMember>price_code</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>price_code" & _
        "</Key><Position>6</Position><Width>75</Width></Column6><Column7 ID=""amount_price" & _
        "1""><AggregateFunction>Sum</AggregateFunction><Caption>Price 1</Caption><DataMemb" & _
        "er>amount_price1</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><FormatString>c2</FormatString><Key>amount_price1</Key><Position" & _
        ">7</Position><TextAlignment>Far</TextAlignment><Width>79</Width><TotalFormatStri" & _
        "ng>c2</TotalFormatString></Column7><Column8 ID=""amount_price2""><AggregateFunctio" & _
        "n>Sum</AggregateFunction><Caption>Price 2</Caption><DataMember>amount_price2</Da" & _
        "taMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><For" & _
        "matString>c2</FormatString><Key>amount_price2</Key><Position>8</Position><TextAl" & _
        "ignment>Far</TextAlignment><Width>74</Width><TotalFormatString>c2</TotalFormatSt" & _
        "ring></Column8><Column9 ID=""amount_price3""><AggregateFunction>Sum</AggregateFunc" & _
        "tion><Caption>Price 3</Caption><DataMember>amount_price3</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</Format" & _
        "String><Key>amount_price3</Key><Position>9</Position><TextAlignment>Far</TextAli" & _
        "gnment><Width>70</Width><TotalFormatString>c2</TotalFormatString></Column9><Colu" & _
        "mn10 ID=""amount_price4""><AggregateFunction>Sum</AggregateFunction><Caption>Price" & _
        " 4</Caption><DataMember>amount_price4</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>amount_" & _
        "price4</Key><Position>10</Position><TextAlignment>Far</TextAlignment><Width>69</" & _
        "Width><TotalFormatString>c2</TotalFormatString></Column10><Column11 ID=""amount_p" & _
        "rice5""><AggregateFunction>Sum</AggregateFunction><Caption>Price 5</Caption><Data" & _
        "Member>amount_price5</DataMember><EditType>NoEdit</EditType><FilterEditType>Text" & _
        "Box</FilterEditType><FormatString>C2</FormatString><Key>amount_price5</Key><Posi" & _
        "tion>11</Position><TextAlignment>Far</TextAlignment><Width>64</Width><TotalForma" & _
        "tString>c2</TotalFormatString></Column11><Column12 ID=""amount_price6""><Aggregate" & _
        "Function>Sum</AggregateFunction><Caption>Price6</Caption><DataMember>amount_pric" & _
        "e6</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><FormatString>C2</FormatString><Key>amount_price6</Key><Position>12</Position>" & _
        "<TextAlignment>Far</TextAlignment><Width>61</Width><TotalFormatString>c2</TotalF" & _
        "ormatString></Column12><Column13 ID=""service_description""><Caption>Service</Capt" & _
        "ion><DataMember>service_description</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><Key>service_description</Key><Position>13</P" & _
        "osition><TextAlignment>Far</TextAlignment><Width>75</Width></Column13><Column14 " & _
        "ID=""list_price""><AggregateFunction>Sum</AggregateFunction><Caption>list price</C" & _
        "aption><DataMember>list_price</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><FormatString>C2</FormatString><Key>list_price</Key" & _
        "><Position>14</Position><TextAlignment>Far</TextAlignment><Width>76</Width><Tota" & _
        "lFormatString>c2</TotalFormatString></Column14><Column15 ID=""fet""><Caption>fet</" & _
        "Caption><DataMember>fet</DataMember><EditType>NoEdit</EditType><FilterEditType>T" & _
        "extBox</FilterEditType><FormatString>c2</FormatString><Key>fet</Key><Position>15" & _
        "</Position><TextAlignment>Far</TextAlignment><Width>40</Width></Column15></Colum" & _
        "ns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grd2.DesignTimeLayout = GridEXLayout2
        Me.Grd2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grd2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Grd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grd2.Location = New System.Drawing.Point(0, 64)
        Me.Grd2.Name = "Grd2"
        Me.Grd2.Size = New System.Drawing.Size(608, 344)
        Me.Grd2.TabIndex = 5
        Me.Grd2.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, i" & _
        "nv_tab_line.line, 1 AS flag, V_Location.on_hand, V_Location.comitted FROM inv_it" & _
        "em INNER JOIN inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN inv_t" & _
        "ab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN inv_tab_brand ON" & _
        " inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN inv_tab_tire_specif" & _
        "ication ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN (SEL" & _
        "ECT cod_table_public, desc_table FROM inv_tab_public WHERE cod_main = '01') inv_" & _
        "tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_pu" & _
        "blic INNER JOIN V_Location ON inv_item.item_no = V_Location.item_no WHERE (inv_i" & _
        "tem.cod_item_type = '01')"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAInventory
        '
        Me.DAInventory.SelectCommand = Me.SqlSelectCommand2
        Me.DAInventory.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_item_warehouse", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("cod_location", "cod_location"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("comitted", "comitted"), New System.Data.Common.DataColumnMapping("on_order", "on_order"), New System.Data.Common.DataColumnMapping("min_stock", "min_stock"), New System.Data.Common.DataColumnMapping("max_stock", "max_stock"), New System.Data.Common.DataColumnMapping("reorde", "reorde")})})
        '
        'Grd3
        '
        Me.Grd3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd3.DataMember = "InventoryCountSheet"
        Me.Grd3.DataSource = Me.DsFrmPrint1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Allow" & _
        "Drag>False</AllowDrag><AllowSort>False</AllowSort><ColumnType>CheckBox</ColumnTy" & _
        "pe><DataMember>flag</DataMember><EditType>CheckBox</EditType><Key>flag</Key><Pos" & _
        "ition>0</Position><Width>16</Width></Column0><Column1 ID=""item_no""><Caption>Item" & _
        " No</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><" & _
        "EmptyStringValue /><DataMember>item_no</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>item_no</Key><Position>1</Position><W" & _
        "idth>60</Width></Column1><Column2 ID=""Remarks""><Caption>Brand</Caption><DataMemb" & _
        "er>Remarks</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><Key>Remarks</Key><Position>2</Position><Width>88</Width></Column2><Co" & _
        "lumn3 ID=""line""><Caption>line</Caption><DataMember>line</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>TextBox</FilterEditType><Key>line</Key><Position>" & _
        "3</Position></Column3><Column4 ID=""desc_item""><Caption>Description</Caption><Dat" & _
        "aMember>desc_item</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>desc_item</Key><Position>4</Position><Width>120</Width></C" & _
        "olumn4><Column5 ID=""QOH""><AggregateFunction>Sum</AggregateFunction><Caption>QOH<" & _
        "/Caption><DataMember>QOH</DataMember><EditType>NoEdit</EditType><FilterEditType>" & _
        "TextBox</FilterEditType><FormatString>#####.##</FormatString><Key>QOH</Key><Posi" & _
        "tion>5</Position><TextAlignment>Far</TextAlignment><Width>70</Width></Column5><C" & _
        "olumn6 ID=""QCounted""><Caption>QCounted</Caption><DataMember>QCounted</DataMember" & _
        "><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStrin" & _
        "g>#####.##</FormatString><Key>QCounted</Key><Position>6</Position><TextAlignment" & _
        ">Far</TextAlignment><Width>87</Width></Column6><Column7 ID=""Bin""><Caption>Bin</C" & _
        "aption><DataMember>Bin</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><Key>Bin</Key><Position>7</Position></Column7><Column8 ID=" & _
        """desc_quick_refrence""><Caption>Quick Ref.</Caption><DataMember>desc_quick_refren" & _
        "ce</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><Key>desc_quick_refrence</Key><Position>8</Position></Column8></Columns><Group" & _
        "Condition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grd3.DesignTimeLayout = GridEXLayout3
        Me.Grd3.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grd3.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Grd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grd3.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.Grd3.Location = New System.Drawing.Point(0, 64)
        Me.Grd3.Name = "Grd3"
        Me.Grd3.Size = New System.Drawing.Size(608, 344)
        Me.Grd3.TabIndex = 6
        Me.Grd3.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtQty)
        Me.Panel1.Controls.Add(Me.TxtExt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 40)
        Me.Panel1.TabIndex = 7
        '
        'TxtQty
        '
        Me.TxtQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtQty.Location = New System.Drawing.Point(112, 8)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.ReadOnly = True
        Me.TxtQty.TabIndex = 18
        Me.TxtQty.Text = ""
        '
        'TxtExt
        '
        Me.TxtExt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtExt.Location = New System.Drawing.Point(312, 8)
        Me.TxtExt.Name = "TxtExt"
        Me.TxtExt.ReadOnly = True
        Me.TxtExt.TabIndex = 17
        Me.TxtExt.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Location = New System.Drawing.Point(224, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total Extension :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Location = New System.Drawing.Point(56, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 31)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total Qty :"
        '
        'GrdIVRSummery
        '
        Me.GrdIVRSummery.AlternatingColors = True
        Me.GrdIVRSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdIVRSummery.DataMember = "IVRSummery"
        Me.GrdIVRSummery.DataSource = Me.DsFrmPrint1
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Allow" & _
        "Sort>False</AllowSort><ColumnType>CheckBox</ColumnType><DataMember>flag</DataMem" & _
        "ber><EditType>CheckBox</EditType><Key>flag</Key><Position>0</Position><Width>22<" & _
        "/Width></Column0><Column1 ID=""desc_item_type""><Caption>Item Type</Caption><DataM" & _
        "ember>desc_item_type</DataMember><EditType>NoEdit</EditType><FilterEditType>Text" & _
        "Box</FilterEditType><Key>desc_item_type</Key><Position>1</Position></Column1><Co" & _
        "lumn2 ID=""CostFet""><AggregateFunction>Sum</AggregateFunction><Caption>Total Cost" & _
        "</Caption><DataMember>CostFet</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><FormatString>c2</FormatString><Key>CostFet</Key><P" & _
        "osition>2</Position><TextAlignment>Far</TextAlignment><TotalFormatString>c2</Tot" & _
        "alFormatString></Column2></Columns><GroupCondition ID="""" /></RootTable></GridEXL" & _
        "ayoutData>"
        Me.GrdIVRSummery.DesignTimeLayout = GridEXLayout4
        Me.GrdIVRSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdIVRSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdIVRSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdIVRSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdIVRSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdIVRSummery.Name = "GrdIVRSummery"
        Me.GrdIVRSummery.Size = New System.Drawing.Size(608, 344)
        Me.GrdIVRSummery.TabIndex = 8
        Me.GrdIVRSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'FrmPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(606, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Grd3)
        Me.Controls.Add(Me.Grd1)
        Me.Controls.Add(Me.Grd2)
        Me.Controls.Add(Me.GrdIVRSummery)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "FrmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DsFrmPrint1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdIVRSummery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString

        'Call MakeFunctionAndView()
        Call FillDataset()
        GridEXPrintDocument1.PageHeaderCenter = Me.Text

    End Sub
    'Private Sub MakeFunctionAndView()
    '    Dim Cmd As New SqlClient.SqlCommand
    '    Cmd.Connection = Cnn
    '    Cmd.CommandText = "if exists(select  dbo.ChangeDateToNormal('1111111111')) " & _
    '         " drop function  ChangeDateToNormal "
    '         '" go "
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()
    '    Cmd.CommandText = " CREATE FUNCTION ChangeDateToNormal (@ThisDate as Char(10))   " & _
    '         " RETURNS Char(10)  AS  " & _
    '         " BEGIN " & _
    '         " DECLARE @ChangedDate1 char(10) " & _
    '         " set @ChangedDate1=SUBSTRING(@ThisDate, 6, 2)+'/' + SUBSTRING(@ThisDate, 9, 2) + '/' + SUBSTRING(@ThisDate, 1, 4) " & _
    '         " RETURN @ChangedDate1 " & _
    '         " End "
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()
    '    '''''''''''''''''''''''''''''

    '    Cmd.CommandText = "if exists (select * from v_lastadj)" & _
    '        " drop view  v_lastadj "
    '    ' " GO " & _
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()

    '    Cmd.CommandText = " CREATE VIEW dbo.V_Lastadj " & _
    '        " AS " & _
    '        " SELECT     dbo.ChangeDateToNormal(MAX(dbo.ChangeDate(dbo.inv_adjustment_head.date_adjustment))) AS date_adj, dbo.inv_adjustment_dtl.item_no " & _
    '        " FROM         dbo.inv_adjustment_dtl INNER JOIN " & _
    '        " dbo.inv_adjustment_head ON dbo.inv_adjustment_dtl.referID_adjustment = dbo.inv_adjustment_head.referID_adjustment " & _
    '        " GROUP BY dbo.inv_adjustment_dtl.item_no "
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()
    '    ''''''''''''''''''''''''''''
    '    Cmd.CommandText = " if exists (select * from v_lastrcv) " & _
    '         " drop view  v_lastrcv "
    '    '" GO " & _
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        ' MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()

    '    Cmd.CommandText = " CREATE VIEW dbo.v_lastrcv " & _
    '         " AS " & _
    '         " SELECT    dbo.ChangeDateToNormal( MAX(dbo.ChangeDate(dbo.Inv_Receive_Products_head.date_receive))) AS date_Rcv, dbo.Inv_Receive_product_dtl.item_no " & _
    '         " FROM         dbo.Inv_Receive_product_dtl INNER JOIN " & _
    '         " dbo.Inv_Receive_Products_head ON dbo.Inv_Receive_product_dtl.id_receive_ref = dbo.Inv_Receive_Products_head.id_receive_ref " & _
    '         " GROUP BY dbo.Inv_Receive_product_dtl.item_no "
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()
    '    ''''''''''''''''''''''''''''
    '    Cmd.CommandText = "if exists (select * from v_lastsold) " & _
    '        " drop view  v_lastsold "
    '    '" GO " & _
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()

    '    Cmd.CommandText = " CREATE VIEW dbo.v_lastsold " & _
    '        " AS " & _
    '        " SELECT     dbo.ChangeDateToNormal(MAX(dbo.ChangeDate(dbo.service_center_head.date_refer))) AS datesold, dbo.service_center_dtl.cod_select " & _
    '        " FROM         dbo.service_center_head INNER JOIN " & _
    '        " dbo.service_center_dtl ON dbo.service_center_head.id_service_center = dbo.service_center_dtl.id_service_center " & _
    '        " WHERE     (dbo.service_center_dtl.type_select = 'I') AND (dbo.service_center_head.type_of_form = 'IN') " & _
    '        " GROUP BY dbo.service_center_dtl.cod_select "
    '    If Cmd.Connection.State = ConnectionState.Closed Then
    '        Cmd.Connection.Open()
    '    End If
    '    Try
    '        Cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        ' MsgBox(ex.Message)
    '    End Try
    '    Cmd.Connection.Close()
    'End Sub
    Private Sub FillDataset()
        Select Case TypeForm
            Case KindForm.ILR
                Call FillDataSet1()
            Case KindForm.PPL
                Call FillDataSet2()
            Case KindForm.IVR
                Call FillDataSet3()
            Case KindForm.ISR
                Call FillDataSet4()
            Case KindForm.SMR
                Call FillDataSet5()
            Case KindForm.ICS
                Call FillDataSet6()
            Case KindForm.IVRSummery
                FillIVLSummery()

        End Select

       
        GridEXPrintDocument1.PageHeaderCenter = vbNewLine & Me.Text

        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
        If Not ItemTypeName Is Nothing Then
            If ItemTypeName.Trim.Length > 0 Then
                GridEXPrintDocument1.PageHeaderLeft = " Item Type : " & ItemTypeName
            End If
        End If
    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Select Case TypeForm
            Case KindForm.PPL
                Call pprint2("privew")
            Case KindForm.ICS
                Call pprint3("privew")
            Case KindForm.IVR
                Call pprint4("privew")
            Case Else
                Call pprint1("privew")
        End Select
    End Sub

    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case TypeForm
            Case KindForm.PPL
                For i As Integer = 0 To DsFrmPrint1.ProductPriceList.Count - 1
                    DsFrmPrint1.ProductPriceList(i).flag = True
                Next
            Case KindForm.ICS
                For i As Integer = 0 To DsFrmPrint1.InventoryCountSheet.Count - 1
                    DsFrmPrint1.InventoryCountSheet(i).flag = True
                Next
            Case KindForm.IVRSummery
                For i As Integer = 0 To DsFrmPrint1.IVRSummery.Count - 1
                    DsFrmPrint1.IVRSummery(i).flag = True
                Next
            Case Else
                For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
                    DsFrmPrint1.inv_item(i).flag = True
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
            Case KindForm.PPL
                Call GridToExcel2(FileName, Grd2)
            Case KindForm.ICS
                Call GridToExcel2(FileName, Grd3)
            Case KindForm.IVRSummery
                Call GridToExcel2(FileName, GrdIVRSummery)

            Case Else
                Call GridToExcel2(FileName, Grd1)

        End Select

    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case TypeForm
            Case KindForm.PPL
                Me.Grd2.ShowFieldChooser(Me)
            Case KindForm.ICS
                Me.Grd3.ShowFieldChooser(Me)
            Case KindForm.IVRSummery
                Me.GrdIVRSummery.ShowFieldChooser(Me)
            Case Else
                Me.Grd1.ShowFieldChooser(Me)
        End Select

    End Sub

    Private Sub BtnJprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
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
            Case KindForm.PPL
                For i As Integer = 0 To DsFrmPrint1.ProductPriceList.Count - 1
                    DsFrmPrint1.ProductPriceList(i).flag = False
                Next
            Case KindForm.ICS
                For i As Integer = 0 To DsFrmPrint1.InventoryCountSheet.Count - 1
                    DsFrmPrint1.InventoryCountSheet(i).flag = False
                Next
            Case KindForm.IVRSummery
                For i As Integer = 0 To DsFrmPrint1.IVRSummery.Count - 1
                    DsFrmPrint1.IVRSummery(i).flag = False
                Next
            Case Else
                For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
                    DsFrmPrint1.inv_item(i).flag = False
                Next
        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Select Case TypeForm
            Case KindForm.PPL
                Call pprint2("print")
            Case KindForm.ICS
                Call pprint3("print")
            Case KindForm.IVR
                Call pprint4("print")
            Case Else
                Call pprint1("print")
        End Select

    End Sub
    Private Sub FillDataSet1()
        'Dim st As String
        'st = IIf(FItem, ",0 as FlagItem ", ",1 as FlagItem ")
        'st = st & IIf(FLine, ", 0 as flagLine ", ", 1 as flagLine")
        'st = st & IIf(FBrand, ", 0 as flagBrand ", ", 1 as flagBrand")
        'st = st & IIf(FStyle, ", 0 as flagStyle ", ", 1 as flagStyle")

        If ItemType = "" Then

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,0 as size,inv_tab_line.line, inv_tab_brand.complete_desc_brand as one,  inv_tab_style.desc_style as two, " & _
         " inv_item_quick_refrence.desc_quick_refrence as three,V_Location.cod_location as four,1 as repno,1 as flag ,inv_tab_brand.cod_brand, inv_tab_style.style ,inv_price_code.desc_price_code " & _
         " FROM         inv_item INNER JOIN " & _
         " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
         " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
         " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
         " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence LEFT OUTER JOIN " & _
         " V_Location ON inv_item.item_no = V_Location.item_no  LEFT OUTER JOIN " & _
         " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
         " inv_price_code ON inv_price_code.price_code = inv_item_cost_transaction.price_code " & _
         " WHERE     inv_item.cod_item_type not in('01','04')" & _
           IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
         " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_item_quick_refrence.desc_quick_refrence"
            DAInvListReport.Fill(DsFrmPrint1.inv_item)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table as size, inv_tab_line.line, inv_tab_brand.complete_desc_brand as one, inv_tab_style.desc_style as two, " & _
                         " inv_item_quick_refrence.desc_quick_refrence as three, V_Location.cod_location AS four,1 as repno,1 as flag,inv_tab_brand.cod_brand, inv_tab_style.style ,inv_price_code.desc_price_code " & _
                         " FROM         inv_item INNER JOIN " & _
                         " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                         " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                         " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                         " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence INNER JOIN " & _
                         " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                         " (SELECT     cod_table_public, desc_table " & _
                         " FROM inv_tab_public " & _
                         " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                         " V_Location ON inv_item.item_no = V_Location.item_no  LEFT OUTER JOIN " & _
                         " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                         " inv_price_code ON inv_price_code.price_code = inv_item_cost_transaction.price_code " & _
                         " WHERE     (inv_item.cod_item_type = '04') " & _
                         IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                             " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_item_quick_refrence.desc_quick_refrence "
            DAInvListReport.Fill(DsFrmPrint1.inv_item)

            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table as size, inv_tab_line.line, inv_tab_brand.complete_desc_brand as one, inv_tab_style.desc_style as two, " & _
                           " inv_item_quick_refrence.desc_quick_refrence as three, V_Location.cod_location as four,1 as repno,1 as flag,inv_tab_brand.cod_brand, inv_tab_style.style,inv_price_code.desc_price_code " & _
                           " FROM         inv_item INNER JOIN " & _
                           " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                           " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                           " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                           " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                           " (SELECT     cod_table_public, desc_table " & _
                           " FROM inv_tab_public " & _
                           " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public INNER JOIN " & _
                           " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence LEFT OUTER JOIN " & _
                           " V_Location ON inv_item.item_no = V_Location.item_no  LEFT OUTER JOIN " & _
                           " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                           " inv_price_code ON inv_price_code.price_code = inv_item_cost_transaction.price_code " & _
                           " where inv_item.cod_item_type = '01' " & _
                           IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                            " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_item_quick_refrence.desc_quick_refrence "

            DAInvListReport.Fill(DsFrmPrint1.inv_item)

        Else


            If ItemType = "01" Then
                'DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table as size, inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_tab_style.desc_style, " & _
                '              " inv_item_quick_refrence.desc_quick_refrence, inv_tab_location_warehouse.cod_location AS location,1 as flag " & _
                '              " FROM         inv_item INNER JOIN " & _
                '          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                '          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                '          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                '          " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                '              " (SELECT     cod_table_public, desc_table " & _
                '" FROM inv_tab_public " & _
                '                 " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public INNER JOIN " & _
                '          " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence INNER JOIN " & _
                '          " inv_tab_item_warehouse ON inv_item.item_no = inv_tab_item_warehouse.item_no INNER JOIN " & _
                '          " inv_tab_wharehouse ON inv_tab_item_warehouse.cod_warehouse = inv_tab_wharehouse.cod_warehouse INNER JOIN " & _
                '              " (SELECT     TOP 1 cod_location, cod_warehouse, cod_location " & _
                '" FROM inv_tab_location_warehouse " & _
                '                 " ORDER BY cod_location) inv_tab_location_warehouse ON inv_tab_wharehouse.cod_warehouse = inv_tab_location_warehouse.cod_warehouse " & _
                '               " where inv_item.cod_item_type = '01' " & _
                '                       IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere)
                DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table as size, inv_tab_line.line, inv_tab_brand.complete_desc_brand as one, inv_tab_style.desc_style as two, " & _
                  " inv_item_quick_refrence.desc_quick_refrence as three, V_Location.cod_location as four,1 as repno,1 as flag,inv_tab_brand.cod_brand, inv_tab_style.style,inv_price_code.desc_price_code " & _
                  " FROM         inv_item INNER JOIN " & _
                  " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                  " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                  " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                  " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                  " (SELECT     cod_table_public, desc_table " & _
                  " FROM inv_tab_public " & _
                  " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public INNER JOIN " & _
                  " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence LEFT OUTER JOIN " & _
                  " V_Location ON inv_item.item_no = V_Location.item_no  LEFT OUTER JOIN " & _
                  " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                  " inv_price_code ON inv_price_code.price_code = inv_item_cost_transaction.price_code " & _
                  " where inv_item.cod_item_type = '01' " & _
                  IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_item_quick_refrence.desc_quick_refrence "
            Else
                If ItemType = "04" Then
                    'DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table as size, inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_tab_style.desc_style, " & _
                    '" inv_item_quick_refrence.desc_quick_refrence, inv_tab_location_warehouse.cod_location AS location,1 as flag " & _
                    '        " FROM         inv_item INNER JOIN " & _
                    '      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                    '      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                    '      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                    '      " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence INNER JOIN " & _
                    '      " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                    '      " (SELECT     cod_table_public, desc_table " & _
                    '      " FROM inv_tab_public " & _
                    '      " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public INNER JOIN " & _
                    '      " inv_tab_item_warehouse ON inv_item.item_no = inv_tab_item_warehouse.item_no INNER JOIN " & _
                    '      " inv_tab_wharehouse ON inv_tab_item_warehouse.cod_warehouse = inv_tab_wharehouse.cod_warehouse INNER JOIN " & _
                    '      " (SELECT     TOP 1 cod_location, cod_warehouse, cod_location " & _
                    '      " FROM inv_tab_location_warehouse " & _
                    '      " ORDER BY cod_location) inv_tab_location_warehouse ON " & _
                    '      " inv_tab_wharehouse.cod_warehouse = inv_tab_location_warehouse.cod_warehouse " & _
                    '      " WHERE     (inv_item.cod_item_type = '04') " & _
                    '                   IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere)
                    DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table as size, inv_tab_line.line, inv_tab_brand.complete_desc_brand as one, inv_tab_style.desc_style as two, " & _
               " inv_item_quick_refrence.desc_quick_refrence as three, V_Location.cod_location AS four,1 as repno,1 as flag,inv_tab_brand.cod_brand, inv_tab_style.style ,inv_price_code.desc_price_code " & _
               " FROM         inv_item INNER JOIN " & _
               " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
               " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
               " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
               " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence INNER JOIN " & _
               " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
               " (SELECT     cod_table_public, desc_table " & _
               " FROM inv_tab_public " & _
               " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
               " V_Location ON inv_item.item_no = V_Location.item_no  LEFT OUTER JOIN " & _
               " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
               " inv_price_code ON inv_price_code.price_code = inv_item_cost_transaction.price_code " & _
               " WHERE     (inv_item.cod_item_type = '04') " & _
               IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_item_quick_refrence.desc_quick_refrence "

                Else
                    'DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,0 as size, inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_tab_style.desc_style, " & _
                    '              " inv_item_quick_refrence.desc_quick_refrence,1 as flag " & _
                    '           " FROM         inv_item INNER JOIN " & _
                    '           " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                    '           " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                    '           " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                    '           " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence INNER JOIN " & _
                    '           " inv_tab_item_warehouse ON inv_item.item_no = inv_tab_item_warehouse.item_no INNER JOIN " & _
                    '           " inv_tab_wharehouse ON inv_tab_item_warehouse.cod_warehouse = inv_tab_wharehouse.cod_warehouse INNER JOIN " & _
                    '           " (SELECT     TOP 1 cod_location, cod_warehouse, cod_location " & _
                    '           " FROM inv_tab_location_warehouse " & _
                    '           " ORDER BY cod_location) inv_tab_location_warehouse ON " & _
                    '           " inv_tab_wharehouse.cod_warehouse = inv_tab_location_warehouse.cod_warehouse " & _
                    '           " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                    '           IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere)
                    'IIf(StrWhere.Trim.Length = 0, "", "where " & StrWhere)
                    DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,0 as size,inv_tab_line.line, inv_tab_brand.complete_desc_brand as one,  inv_tab_style.desc_style as two, " & _
                      " inv_item_quick_refrence.desc_quick_refrence as three,V_Location.cod_location as four,1 as repno,1 as flag ,inv_tab_brand.cod_brand, inv_tab_style.style ,inv_price_code.desc_price_code " & _
                      " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence LEFT OUTER JOIN " & _
                      " V_Location ON inv_item.item_no = V_Location.item_no  LEFT OUTER JOIN " & _
                      " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                      " inv_price_code ON inv_price_code.price_code = inv_item_cost_transaction.price_code " & _
                      " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                      " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_item_quick_refrence.desc_quick_refrence"

                End If
            End If
            DsFrmPrint1.inv_item.Clear()
            DAInvListReport.Fill(DsFrmPrint1.inv_item)
        End If

        If DsFrmPrint1.inv_item.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If

        'If FItem Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("item").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).item_no)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagitem = 1
        '        End If
        '    Next
        'End If
        'If FLine Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("line").Select("flag=1 and name = " & Qt(DsFrmPrint1.inv_item(i).line)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagline = 1
        '        End If
        '    Next
        'End If
        'If FBrand Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("brand").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).cod_brand)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagbrand = 1
        '        End If
        '    Next
        'End If
        'If FStyle Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("style").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).style)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagstyle = 1
        '        End If
        '    Next
        'End If
        Panel1.Visible = False
        Grd1.Height = 384

        'DsFrmPrint1.inv_item.DefaultView.RowFilter = "  flagstyle=true and  flagbrand=true and  flagline=true and  flagitem = true"
        Grd1.SetDataBinding(DsFrmPrint1.inv_item, "")

        Grd1.RootTable.Columns.Item(4).Visible = False
        Grd1.BringToFront()

    End Sub
    Private Sub FillDataSet2()
        'Dim st As String
        'st = IIf(FItem, ",0 as FlagItem ", ",1 as FlagItem ")
        'st = st & IIf(FLine, ", 0 as flagLine ", ", 1 as flagLine")
        'st = st & IIf(FBrand, ", 0 as flagBrand ", ", 1 as flagBrand")
        'st = st & IIf(FStyle, ", 0 as flagStyle ", ", 1 as flagStyle")
        If ItemType = "" Then
            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_line.line, 0 AS service_description, inv_item_cost_transaction.list_price as list_price, inv_item_cost_transaction.fet, " & _
                                  " inv_item.picture, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style, " & _
                                  " inv_item_cost_transaction.cost, inv_item_cost_transaction.price_code, inv_item_cost_transaction.amount_price1, " & _
                                  " inv_item_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_item_cost_transaction.amount_price4 , inv_item_cost_transaction.amount_price5, inv_item_cost_transaction.amount_price6,inv_tab_brand.complete_desc_brand " & _
                                  " FROM         inv_item INNER JOIN " & _
                                  " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                                  " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                                  " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                                 " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                                  "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                                  " WHERE     inv_item.cod_item_type NOT IN ('01','04') " & _
                                   IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                              " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "

            DAInvListReport.Fill(DsFrmPrint1.ProductPriceList)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, 0 AS service_description, " & _
                      " inv_item_cost_transaction.list_price as list_price, inv_item_cost_transaction.fet, inv_item.picture, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style ," & _
               " inv_item_cost_transaction.cost, inv_item_cost_transaction.price_code, inv_item_cost_transaction.amount_price1, " & _
               " inv_item_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_item_cost_transaction.amount_price4 , inv_item_cost_transaction.amount_price5, inv_item_cost_transaction.amount_price6,inv_tab_brand.complete_desc_brand " & _
                      " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                      " (SELECT     cod_table_public, desc_table " & _
                      " FROM inv_tab_public " & _
                      " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public INNER JOIN " & _
                      " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                        "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                      " WHERE     inv_item.cod_item_type = '04' " & _
                       IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                  " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "

            DAInvListReport.Fill(DsFrmPrint1.ProductPriceList)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, inv_tab_tire_specification.service_description, " & _
                          "   inv_item_cost_transaction.list_price as list_price, inv_item_cost_transaction.fet, inv_item.picture, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style ," & _
                          " inv_item_cost_transaction.cost, inv_item_cost_transaction.price_code, inv_item_cost_transaction.amount_price1, " & _
                          " inv_item_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_item_cost_transaction.amount_price4, inv_item_cost_transaction.amount_price5, inv_item_cost_transaction.amount_price6,inv_tab_brand.complete_desc_brand " & _
                          " FROM         inv_item INNER JOIN " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                          " (SELECT     cod_table_public, desc_table " & _
                          " FROM inv_tab_public " & _
                          " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public INNER JOIN " & _
                          " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                                   "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                          " WHERE     inv_item.cod_item_type = '01' " & _
                          IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                           " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "

            DAInvListReport.Fill(DsFrmPrint1.ProductPriceList)

        Else
            If ItemType = "01" Then
                DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, inv_tab_tire_specification.service_description, " & _
                "   inv_item_cost_transaction.list_price as list_price, inv_item_cost_transaction.fet, inv_item.picture, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style ," & _
                " inv_item_cost_transaction.cost, inv_item_cost_transaction.price_code, inv_item_cost_transaction.amount_price1, " & _
                " inv_item_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_item_cost_transaction.amount_price4, inv_item_cost_transaction.amount_price5, inv_item_cost_transaction.amount_price6,inv_tab_brand.complete_desc_brand " & _
                " FROM         inv_item INNER JOIN " & _
                " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                " (SELECT     cod_table_public, desc_table " & _
                " FROM inv_tab_public " & _
                " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public INNER JOIN " & _
                " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                         "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                 " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "

            Else
                If ItemType = "04" Then
                    DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, 0 AS service_description, " & _
                       " inv_item_cost_transaction.list_price as list_price, inv_item_cost_transaction.fet, inv_item.picture, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style ," & _
                " inv_item_cost_transaction.cost, inv_item_cost_transaction.price_code, inv_item_cost_transaction.amount_price1, " & _
                " inv_item_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_item_cost_transaction.amount_price4 , inv_item_cost_transaction.amount_price5, inv_item_cost_transaction.amount_price6,inv_tab_brand.complete_desc_brand " & _
                       " FROM         inv_item INNER JOIN " & _
                       " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                       " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                       " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                       " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                       " (SELECT     cod_table_public, desc_table " & _
                       " FROM inv_tab_public " & _
                       " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public INNER JOIN " & _
                       " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                         "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                       " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
                Else
                    DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_line.line, 0 AS service_description, inv_item_cost_transaction.list_price as list_price, inv_item_cost_transaction.fet, " & _
                       " inv_item.picture, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style, " & _
                       " inv_item_cost_transaction.cost, inv_item_cost_transaction.price_code, inv_item_cost_transaction.amount_price1, " & _
                       " inv_item_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_item_cost_transaction.amount_price4 , inv_item_cost_transaction.amount_price5, inv_item_cost_transaction.amount_price6,inv_tab_brand.complete_desc_brand " & _
                       " FROM         inv_item INNER JOIN " & _
                       " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                       " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                       " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                       "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                       " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
                End If
            End If

            DsFrmPrint1.ProductPriceList.Clear()
            DAInvListReport.Fill(DsFrmPrint1.ProductPriceList)

        End If

        If DsFrmPrint1.ProductPriceList.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If



        'If FItem Then
        '    For i As Integer = 0 To DsFrmPrint1.ProductPriceList.Count - 1
        '        If DSMAIN.Tables("item").Select("flag=1 and code = " & Qt(DsFrmPrint1.ProductPriceList(i).item_no)).Length > 0 Then
        '            DsFrmPrint1.ProductPriceList(i).flagitem = 1
        '        End If
        '    Next
        'End If
        'If FLine Then
        '    For i As Integer = 0 To DsFrmPrint1.ProductPriceList.Count - 1
        '        If DSMAIN.Tables("line").Select("flag=1 and name = " & Qt(DsFrmPrint1.ProductPriceList(i).line)).Length > 0 Then
        '            DsFrmPrint1.ProductPriceList(i).flagline = 1
        '        End If
        '    Next
        'End If
        'If FBrand Then
        '    For i As Integer = 0 To DsFrmPrint1.ProductPriceList.Count - 1
        '        If DSMAIN.Tables("brand").Select("flag=1 and code = " & Qt(DsFrmPrint1.ProductPriceList(i).cod_brand)).Length > 0 Then
        '            DsFrmPrint1.ProductPriceList(i).flagbrand = 1
        '        End If
        '    Next
        'End If
        'If FStyle Then
        '    For i As Integer = 0 To DsFrmPrint1.ProductPriceList.Count - 1
        '        If DSMAIN.Tables("style").Select("flag=1 and code = " & Qt(DsFrmPrint1.ProductPriceList(i).style)).Length > 0 Then
        '            DsFrmPrint1.ProductPriceList(i).flagstyle = 1
        '        End If
        '    Next
        'End If



        'DsFrmPrint1.ProductPriceList.DefaultView.RowFilter = "  flagstyle=true and  flagbrand=true and  flagline=true and  flagitem = true"
        Grd2.SetDataBinding(DsFrmPrint1.ProductPriceList, "")

        Panel1.Visible = False
        Grd2.Height = 384

        Grd2.BringToFront()
        GridEXPrintDocument1.GridEX = Grd2
    End Sub
    Private Sub FillDataSet3()
        'Dim st As String
        'st = IIf(FItem, ",0 as FlagItem ", ",1 as FlagItem ")
        'st = st & IIf(FLine, ", 0 as flagLine ", ", 1 as flagLine")
        'st = st & IIf(FBrand, ", 0 as flagBrand ", ", 1 as flagBrand")
        'st = st & IIf(FStyle, ", 0 as flagStyle ", ", 1 as flagStyle")
        If ItemType = "" Then
            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand as one, inv_item_cost_transaction.cost as two, " & _
                                    " inv_item_cost_transaction.fet as three,V_Location.on_hand*(inv_item_cost_transaction.cost+inv_item_cost_transaction.fet) as four,3 as repno,1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                                    " FROM         inv_item_cost_transaction INNER JOIN " & _
"                       inv_item ON inv_item_cost_transaction.item_no = inv_item.item_no LEFT OUTER JOIN " & _
"                       inv_tab_style INNER JOIN " & _
"                       inv_tab_line ON inv_tab_style.style = inv_tab_line.style INNER JOIN " & _
"                       inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON inv_item.line = inv_tab_line.line LEFT OUTER JOIN  " & _
"                       V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
"                       inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                                    " WHERE     inv_item.cod_item_type NOT IN ('01','04') " & _
                                  IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                             " order by   inv_tab_brand.complete_desc_brand, inv_item_quick_refrence.desc_quick_refrence "

            DAInvListReport.Fill(DsFrmPrint1.inv_value)
            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand as one, inv_item_cost_transaction.cost as two, " & _
                        " inv_item_cost_transaction.fet as three,V_Location.on_hand*(inv_item_cost_transaction.cost+inv_item_cost_transaction.fet) as four,3 as repno, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                        " FROM         inv_item_cost_transaction INNER JOIN " & _
"                       inv_item ON inv_item_cost_transaction.item_no = inv_item.item_no LEFT OUTER JOIN " & _
"                       inv_tab_wheels_specification INNER JOIN " & _
"                           (SELECT     cod_table_public, desc_table " & _
"                              FROM         inv_tab_public " & _
"                              WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public ON  " & _
"                       inv_item.item_no = inv_tab_wheels_specification.item_no LEFT OUTER JOIN " & _
"                       inv_tab_style INNER JOIN " & _
"                       inv_tab_line ON inv_tab_style.style = inv_tab_line.style INNER JOIN " & _
"                       inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON inv_item.line = inv_tab_line.line LEFT OUTER JOIN " & _
"                       V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
"                       inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                         " WHERE     inv_item.cod_item_type = '04' " & _
                      IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                 " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
            DAInvListReport.Fill(DsFrmPrint1.inv_value)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand as one, inv_item_cost_transaction.cost as two, " & _
                                   " inv_item_cost_transaction.fet as three,V_Location.on_hand*(inv_item_cost_transaction.cost+inv_item_cost_transaction.fet) as four,3 as repno, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                                   " FROM         V_Location INNER JOIN " & _
"                       inv_item_cost_transaction INNER JOIN " & _
"                       inv_item ON inv_item_cost_transaction.item_no = inv_item.item_no ON V_Location.item_no = inv_item.item_no LEFT OUTER JOIN " & _
"                       inv_tab_style INNER JOIN " & _
"                       inv_tab_line ON inv_tab_style.style = inv_tab_line.style INNER JOIN " & _
"                       inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON inv_item.line = inv_tab_line.line LEFT OUTER JOIN " & _
"                       inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence LEFT OUTER JOIN " & _
"                           (SELECT     cod_table_public, desc_table " & _
"                              FROM         inv_tab_public " & _
"                              WHERE     cod_main = '01') inv_tab_public INNER JOIN " & _
"                       inv_tab_tire_specification ON inv_tab_public.cod_table_public = inv_tab_tire_specification.tire_size ON  " & _
"                       inv_item.item_no = inv_tab_tire_specification.item_no " & _
                                    " WHERE     inv_item.cod_item_type = '01' " & _
                                 IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                            " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
            DAInvListReport.Fill(DsFrmPrint1.inv_value)

        Else
            If ItemType = "01" Then
                DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand as one, inv_item_cost_transaction.cost as two, " & _
                          " inv_item_cost_transaction.fet as three,V_Location.on_hand*(inv_item_cost_transaction.cost+inv_item_cost_transaction.fet) as four,3 as repno, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         V_Location INNER JOIN " & _
"                       inv_item_cost_transaction INNER JOIN " & _
"                       inv_item ON inv_item_cost_transaction.item_no = inv_item.item_no ON V_Location.item_no = inv_item.item_no LEFT OUTER JOIN " & _
"                       inv_tab_style INNER JOIN " & _
"                       inv_tab_line ON inv_tab_style.style = inv_tab_line.style INNER JOIN " & _
"                       inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON inv_item.line = inv_tab_line.line LEFT OUTER JOIN " & _
"                       inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence LEFT OUTER JOIN " & _
"                           (SELECT     cod_table_public, desc_table " & _
"                              FROM         inv_tab_public " & _
"                              WHERE     cod_main = '01') inv_tab_public INNER JOIN " & _
"                       inv_tab_tire_specification ON inv_tab_public.cod_table_public = inv_tab_tire_specification.tire_size ON  " & _
"                       inv_item.item_no = inv_tab_tire_specification.item_no " & _
                           " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "

            Else
                If ItemType = "04" Then
                    DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand as one, inv_item_cost_transaction.cost as two, " & _
                          " inv_item_cost_transaction.fet as three,V_Location.on_hand*(inv_item_cost_transaction.cost+inv_item_cost_transaction.fet) as four,3 as repno, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         inv_item_cost_transaction INNER JOIN " & _
"                       inv_item ON inv_item_cost_transaction.item_no = inv_item.item_no LEFT OUTER JOIN " & _
"                       inv_tab_wheels_specification INNER JOIN " & _
"                           (SELECT     cod_table_public, desc_table " & _
"                              FROM         inv_tab_public " & _
"                              WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public ON  " & _
"                       inv_item.item_no = inv_tab_wheels_specification.item_no LEFT OUTER JOIN " & _
"                       inv_tab_style INNER JOIN " & _
"                       inv_tab_line ON inv_tab_style.style = inv_tab_line.style INNER JOIN " & _
"                       inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON inv_item.line = inv_tab_line.line LEFT OUTER JOIN " & _
"                       V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
"                       inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                           " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
                Else
                    DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand as one, inv_item_cost_transaction.cost as two, " & _
                          " inv_item_cost_transaction.fet as three,V_Location.on_hand*(inv_item_cost_transaction.cost+inv_item_cost_transaction.fet) as four,3 as repno,1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         inv_item_cost_transaction INNER JOIN " & _
"                       inv_item ON inv_item_cost_transaction.item_no = inv_item.item_no LEFT OUTER JOIN " & _
"                       inv_tab_style INNER JOIN " & _
"                       inv_tab_line ON inv_tab_style.style = inv_tab_line.style INNER JOIN " & _
"                       inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON inv_item.line = inv_tab_line.line LEFT OUTER JOIN  " & _
"                       V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
"                       inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                          " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_item_quick_refrence.desc_quick_refrence "
                End If
            End If
            DsFrmPrint1.inv_value.Clear()
            DAInvListReport.Fill(DsFrmPrint1.inv_value)

        End If

        If DsFrmPrint1.inv_value.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If
        Grd1.RootTable.Columns.Item(3).Caption = "Brand"
        Grd1.RootTable.Columns.Item(9).FormatString = "c2"
        Grd1.RootTable.Columns.Item(9).Caption = "Extension"
        Grd1.RootTable.Columns.Item(6).Caption = "Qty"
        Grd1.RootTable.Columns.Item(7).Caption = "Cost"

        Grd1.RootTable.Columns.Item(8).Caption = "Fet"
        Grd1.RootTable.Columns.Item(8).Width = 40
        Grd1.RootTable.Columns.Item(4).Visible = False

        Grd1.RootTable.Columns.RemoveAt(10)

        'Grd1.RootTable.Columns.Item(7).AggregateFunction = AggregateFunction.Sum
        'Grd1.RootTable.Columns.Item(7).TotalFormatString = "c2"

        Grd1.RootTable.Columns.Item(9).TextAlignment = TextAlignment.Far
        Grd1.RootTable.Columns.Item(6).TextAlignment = TextAlignment.Far
        Grd1.RootTable.Columns.Item(7).TextAlignment = TextAlignment.Far
        Grd1.RootTable.Columns.Item(8).TextAlignment = TextAlignment.Far
        Grd1.RootTable.Columns.Item(7).FormatString = "c2"

        Grd1.SetDataBinding(DsFrmPrint1, "inv_value")
        'If DsFrmPrint1.inv_item.Count = 0 Then
        '    MsgBox("there is no item for this report")
        '    Me.Close()
        'End If

        'If FItem Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("item").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).item_no)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagitem = 1
        '        End If
        '    Next
        'End If
        'If FLine Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("line").Select("flag=1 and name = " & Qt(DsFrmPrint1.inv_item(i).line)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagline = 1
        '        End If
        '    Next
        'End If
        'If FBrand Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("brand").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).cod_brand)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagbrand = 1
        '        End If
        '    Next
        'End If
        'If FStyle Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("style").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).style)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagstyle = 1
        '        End If
        '    Next
        'End If
        Dim qty As Decimal = 0
        Dim ext As Decimal = 0

        For i As Integer = 0 To DsFrmPrint1.inv_value.Count - 1
            qty = DsFrmPrint1.inv_value(i).one + qty
            ext = DsFrmPrint1.inv_value(i).four + ext
        Next
        TxtQty.Text = qty
        TxtExt.Text = ext


        'DsFrmPrint1.inv_item.DefaultView.RowFilter = "  flagstyle=true and  flagbrand=true and  flagline=true and  flagitem = true"
        'Grd1.SetDataBinding(DsFrmPrint1.inv_item, "")
        Grd1.TotalRow = InheritableBoolean.True

        Grd1.BringToFront()

    End Sub
    Private Sub FillDataSet4()
        'Dim st As String
        'st = IIf(FItem, ",0 as FlagItem ", ",1 as FlagItem ")
        'st = st & IIf(FLine, ", 0 as flagLine ", ", 1 as flagLine")
        'st = st & IIf(FBrand, ", 0 as flagBrand ", ", 1 as flagBrand")
        'st = st & IIf(FStyle, ", 0 as flagStyle ", ", 1 as flagStyle")
        If ItemType = "" Then
            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,  inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand AS one, v_lastsold.datesold AS two, " & _
                                  " v_lastrcv.date_Rcv AS three, v_lastadj.date_adj AS four,V_Location.cod_location as five, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                                  " FROM         inv_item INNER JOIN " & _
                                  " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                                  " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                                  " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand LEFT OUTER JOIN " & _
                                  " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                                  " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                                  " v_lastrcv  ON inv_item.item_no = v_lastrcv.item_no LEFT OUTER JOIN " & _
                                  " v_lastadj ON inv_item.item_no = v_lastadj.item_no INNER JOIN " & _
                                  "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                                  " WHERE     inv_item.cod_item_type NOT IN('01','04')" & _
                                IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                           " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "

            DAInvListReport.Fill(DsFrmPrint1.InventoryStatusReport)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,  inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand AS one, " & _
                     " v_lastsold.datesold AS two, v_lastrcv.date_Rcv AS three, v_lastadj.date_adj AS four,V_Location.cod_location as five, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                     " FROM         inv_item INNER JOIN " & _
                     " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                     " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                     " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                     " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                     " (SELECT     cod_table_public, desc_table " & _
                     " FROM inv_tab_public  " & _
                     " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                     " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                     " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                     " v_lastadj ON inv_item.item_no = v_lastadj.item_no LEFT OUTER JOIN " & _
                     " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no INNER JOIN " & _
                     "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                     " WHERE     inv_item.cod_item_type = '04' " & _
                     IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
              " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
            DAInvListReport.Fill(DsFrmPrint1.InventoryStatusReport)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,  inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand AS one, " & _
                          " v_lastsold.datesold AS two, v_lastrcv.date_Rcv AS three, v_lastadj.date_adj AS four,V_Location.cod_location as five, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         inv_item INNER JOIN " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                          " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN  " & _
                          " (SELECT     cod_table_public, desc_table " & _
                          " FROM inv_tab_public  " & _
                          " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                          " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                          " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                          " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no LEFT OUTER JOIN " & _
                          " v_lastadj ON inv_item.item_no = v_lastadj.item_no INNER JOIN " & _
                          "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                          " WHERE     inv_item.cod_item_type = '01' " & _
                          IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                         " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
            DAInvListReport.Fill(DsFrmPrint1.InventoryStatusReport)

        Else
            If ItemType = "01" Then
                DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,  inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand AS one, " & _
                    " v_lastsold.datesold AS two, v_lastrcv.date_Rcv AS three, v_lastadj.date_adj AS four,V_Location.cod_location as five, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                    " FROM         inv_item INNER JOIN " & _
                    " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                    " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                    " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                    " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN  " & _
                    " (SELECT     cod_table_public, desc_table " & _
                    " FROM inv_tab_public  " & _
                    " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                    " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                    " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                    " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no LEFT OUTER JOIN " & _
                    " v_lastadj ON inv_item.item_no = v_lastadj.item_no INNER JOIN " & _
                    "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                    " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                    IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "

            Else
                If ItemType = "04" Then
                    DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,  inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand AS one, " & _
                          " v_lastsold.datesold AS two, v_lastrcv.date_Rcv AS three, v_lastadj.date_adj AS four,V_Location.cod_location as five, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         inv_item INNER JOIN " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                          " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                          " (SELECT     cod_table_public, desc_table " & _
                          " FROM inv_tab_public  " & _
                          " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                          " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                          " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                          " v_lastadj ON inv_item.item_no = v_lastadj.item_no LEFT OUTER JOIN " & _
                          " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no INNER JOIN " & _
                          "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                          " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                          IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
                Else
                    DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,  inv_tab_brand.complete_desc_brand AS size, inv_tab_line.line, V_Location.on_hand AS one, v_lastsold.datesold AS two, " & _
                          " v_lastrcv.date_Rcv AS three, v_lastadj.date_adj AS four,V_Location.cod_location as five, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         inv_item INNER JOIN " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand LEFT OUTER JOIN " & _
                          " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                          " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                          " v_lastrcv  ON inv_item.item_no = v_lastrcv.item_no LEFT OUTER JOIN " & _
                          " v_lastadj ON inv_item.item_no = v_lastadj.item_no INNER JOIN " & _
                          "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                          " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_item_quick_refrence.desc_quick_refrence "
                End If
            End If
            DsFrmPrint1.InventoryStatusReport.Clear()
            DAInvListReport.Fill(DsFrmPrint1.InventoryStatusReport)
        End If


        If DsFrmPrint1.InventoryStatusReport.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If
        Grd1.RootTable.Columns.Item(3).Caption = "Brand"
        Grd1.RootTable.Columns.Item(9).Caption = "Last Adj"
        Grd1.RootTable.Columns.Item(6).Caption = "Qty"
        Grd1.RootTable.Columns.Item(7).Caption = "Last Sold"
        Grd1.RootTable.Columns.Item(8).Caption = "Last Rcvd"
        Grd1.RootTable.Columns.Item(7).FormatString = "MM/dd/yyyy"
        Grd1.RootTable.Columns.Item(8).FormatString = "MM/dd/yyyy"
        Grd1.RootTable.Columns.Item(9).FormatString = "MM/dd/yyyy"
        Grd1.RootTable.Columns.Item(6).TextAlignment = TextAlignment.Far
        Grd1.RootTable.Columns.RemoveAt(10)
        If DsFrmPrint1.InventoryStatusReport.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If

        'If FItem Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryStatusReport.Count - 1
        '        If DSMAIN.Tables("item").Select("flag=1 and code = " & Qt(DsFrmPrint1.InventoryStatusReport(i).item_no)).Length > 0 Then
        '            DsFrmPrint1.InventoryStatusReport(i).flagitem = 1
        '        End If
        '    Next
        'End If
        'If FLine Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryStatusReport.Count - 1
        '        If DSMAIN.Tables("line").Select("flag=1 and name = " & Qt(DsFrmPrint1.InventoryStatusReport(i).line)).Length > 0 Then
        '            DsFrmPrint1.InventoryStatusReport(i).flagline = 1
        '        End If
        '    Next
        'End If
        'If FBrand Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryStatusReport.Count - 1
        '        If DSMAIN.Tables("brand").Select("flag=1 and code = " & Qt(DsFrmPrint1.InventoryStatusReport(i).cod_brand)).Length > 0 Then
        '            DsFrmPrint1.InventoryStatusReport(i).flagbrand = 1
        '        End If
        '    Next
        'End If
        'If FStyle Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryStatusReport.Count - 1
        '        If DSMAIN.Tables("style").Select("flag=1 and code = " & Qt(DsFrmPrint1.InventoryStatusReport(i).style)).Length > 0 Then
        '            DsFrmPrint1.InventoryStatusReport(i).flagstyle = 1
        '        End If
        '    Next
        'End If
        Grd1.RootTable.Columns.Item(6).AggregateFunction = AggregateFunction.Sum
        Grd1.RootTable.Columns.Item(9).AggregateFunction = AggregateFunction.None
        Grd1.TotalRow = InheritableBoolean.True


        Panel1.Visible = False
        Grd1.Height = 384

        'DsFrmPrint1.InventoryStatusReport.DefaultView.RowFilter = "  flagstyle=true and  flagbrand=true and  flagline=true and  flagitem = true"
        Grd1.SetDataBinding(DsFrmPrint1.InventoryStatusReport, "")

        Grd1.BringToFront()

    End Sub
    Private Sub FillDataSet5()
        'Dim st As String
        'st = IIf(FItem, ",0 as FlagItem ", ",1 as FlagItem ")
        'st = st & IIf(FLine, ", 0 as flagLine ", ", 1 as flagLine")
        'st = st & IIf(FBrand, ", 0 as flagBrand ", ", 1 as flagBrand")
        'st = st & IIf(FStyle, ", 0 as flagStyle ", ", 1 as flagStyle")
        If ItemType = "" Then
            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, 0 AS size, inv_tab_line.line,v_lastsold.datesold as two, V_Location.on_hand AS one,DATEDIFF(day,v_lastsold.datesold, " & Qt(Format(Now.Date, PubDateFormat)) & ") AS three, " & _
                         " v_lastrcv.date_Rcv AS four, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                         " FROM         inv_item INNER JOIN " & _
                         " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                         " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                         " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand LEFT OUTER JOIN " & _
                         " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                         " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                         " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no " & _
                         " WHERE     inv_item.cod_item_type NOT IN ('01','04') " & _
                       IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                  " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line "
            DAInvListReport.Fill(DsFrmPrint1.SlowMoving)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, V_Location.on_hand AS one,v_lastsold.datesold as two, " & _
                    "  DATEDIFF(day,v_lastsold.datesold, " & Qt(Format(Now.Date, PubDateFormat)) & ") AS three, v_lastrcv.date_Rcv AS four, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                    " FROM         inv_item INNER JOIN  " & _
                    " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                    " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                    " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                    " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                    " (SELECT     cod_table_public, desc_table " & _
                    " FROM inv_tab_public " & _
                    " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                    " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                    " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                    " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no " & _
                    " WHERE     inv_item.cod_item_type = '04' " & _
                    IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                    " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_tab_public.desc_table "
            DAInvListReport.Fill(DsFrmPrint1.SlowMoving)

            DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, V_Location.on_hand AS one,v_lastsold.datesold as two, " & _
                             "  DATEDIFF(day,v_lastsold.datesold, " & Qt(Format(Now.Date, PubDateFormat)) & ") AS three, v_lastrcv.date_Rcv AS four, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                             " FROM         inv_item INNER JOIN " & _
                             " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                             " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                             " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                             " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                             " (SELECT     cod_table_public, desc_table " & _
                             " FROM inv_tab_public " & _
                             " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                             " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                             " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                             " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no  " & _
                             " WHERE     inv_item.cod_item_type = '01' " & _
                              IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                             " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_tab_public.desc_table "

            DAInvListReport.Fill(DsFrmPrint1.SlowMoving)

        Else

            If ItemType = "01" Then

                DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, V_Location.on_hand AS one,v_lastsold.datesold as two, " & _
                       "  DATEDIFF(day,v_lastsold.datesold, " & Qt(Format(Now.Date, PubDateFormat)) & ") AS three, v_lastrcv.date_Rcv AS four, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                       " FROM         inv_item INNER JOIN " & _
                       " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                       " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                       " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                       " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                       " (SELECT     cod_table_public, desc_table " & _
                       " FROM inv_tab_public " & _
                       " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                       " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                       " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                       " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no  " & _
                       " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                       " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_tab_public.desc_table "

            Else
                If ItemType = "04" Then
                    DAInvListReport.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, inv_tab_public.desc_table AS size, inv_tab_line.line, V_Location.on_hand AS one,v_lastsold.datesold as two, " & _
                          "  DATEDIFF(day,v_lastsold.datesold, " & Qt(Format(Now.Date, PubDateFormat)) & ") AS three, v_lastrcv.date_Rcv AS four, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         inv_item INNER JOIN  " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                          " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                          " (SELECT     cod_table_public, desc_table " & _
                          " FROM inv_tab_public " & _
                          " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                          " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                          " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                          " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no " & _
                          " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                          IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                          " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line,inv_tab_public.desc_table "

                Else
                    DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, 0 AS size, inv_tab_line.line,v_lastsold.datesold as two, V_Location.on_hand AS one,DATEDIFF(day,v_lastsold.datesold, " & Qt(Format(Now.Date, PubDateFormat)) & ") AS three, " & _
                          " v_lastrcv.date_Rcv AS four, 1 AS flag ,inv_tab_brand.cod_brand, inv_tab_style.style " & _
                          " FROM         inv_item INNER JOIN " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand LEFT OUTER JOIN " & _
                          " V_Location ON inv_item.item_no = V_Location.item_no LEFT OUTER JOIN " & _
                          " v_lastsold ON inv_item.item_no = v_lastsold.cod_select LEFT OUTER JOIN " & _
                          " v_lastrcv ON inv_item.item_no = v_lastrcv.item_no " & _
                          " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                        IIf(StrWhere.Trim.Length = 0, "", "and " & StrWhere) & _
                   " order by   inv_tab_brand.complete_desc_brand, inv_tab_line.line "
                End If
            End If
            DsFrmPrint1.inv_item.Clear()
            DAInvListReport.Fill(DsFrmPrint1.SlowMoving)

        End If


        If DsFrmPrint1.SlowMoving.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If

        Grd1.RootTable.Columns.Item(9).Caption = "Last Rcvd"
        Grd1.RootTable.Columns.Item(6).Caption = "Qty"
        Grd1.RootTable.Columns.Item(7).Caption = "Last Sold"
        Grd1.RootTable.Columns.Item(8).Caption = "No Of Day"
        Grd1.RootTable.Columns.Item(7).FormatString = "MM/dd/yyyy"
        Grd1.RootTable.Columns.Item(9).FormatString = "MM/dd/yyyy"
        Grd1.RootTable.Columns.Item(4).Visible = False

        Grd1.RootTable.Columns.Item(6).TextAlignment = TextAlignment.Far
        Grd1.RootTable.Columns.RemoveAt(10)

        'If DsFrmPrint1.inv_item.Count = 0 Then
        '    MsgBox("there is no item for this report")
        '    Me.Close()
        'End If

        'If FItem Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("item").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).item_no)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagitem = 1
        '        End If
        '    Next
        'End If
        'If FLine Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("line").Select("flag=1 and name = " & Qt(DsFrmPrint1.inv_item(i).line)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagline = 1
        '        End If
        '    Next
        'End If
        'If FBrand Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("brand").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).cod_brand)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagbrand = 1
        '        End If
        '    Next
        'End If
        'If FStyle Then
        '    For i As Integer = 0 To DsFrmPrint1.inv_item.Count - 1
        '        If DSMAIN.Tables("style").Select("flag=1 and code = " & Qt(DsFrmPrint1.inv_item(i).style)).Length > 0 Then
        '            DsFrmPrint1.inv_item(i).flagstyle = 1
        '        End If
        '    Next
        'End If

        Panel1.Visible = False
        Grd1.Height = 384
        'DsFrmPrint1.inv_item.DefaultView.RowFilter = "  flagstyle=true and  flagbrand=true and  flagline=true and  flagitem = true"
        Grd1.SetDataBinding(DsFrmPrint1.SlowMoving, "")

        Grd1.BringToFront()
    End Sub
    Private Sub FillDataSet6()
        'Dim st As String
        'st = IIf(FItem, ",0 as FlagItem ", ",1 as FlagItem ")
        'st = st & IIf(FLine, ", 0 as flagLine ", ", 1 as flagLine")
        'st = st & IIf(FBrand, ", 0 as flagBrand ", ", 1 as flagBrand")
        'st = st & IIf(FStyle, ", 0 as flagStyle ", ", 1 as flagStyle")
        If ItemType = "" Then
            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,v_location.cod_location as bin, V_Location.on_hand AS qoh, V_Location.comitted AS qcounted,inv_tab_brand.complete_desc_brand as remarks, 1 AS flag ,inv_tab_line.line, inv_tab_brand.cod_brand, inv_tab_style.style,inv_item_quick_refrence.desc_quick_refrence " & _
                                 " FROM         inv_item INNER JOIN " & _
                                 " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                                 " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                                 " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand LEFT OUTER JOIN " & _
                                 " V_Location ON inv_item.item_no = V_Location.item_no INNER JOIN " & _
                                 "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                                 " WHERE     inv_item.cod_item_type NOT IN ('01','04') " & _
                                 IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                                 " order by    inv_item_quick_refrence.desc_quick_refrence,inv_tab_brand.complete_desc_brand, inv_tab_line.line "

            DAInvListReport.Fill(DsFrmPrint1.InventoryCountSheet)

            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,v_location.cod_location as bin, V_Location.on_hand AS qoh, V_Location.comitted AS QCounted,inv_tab_brand.complete_desc_brand as remarks, 1 AS flag ,inv_tab_line.line, inv_tab_brand.cod_brand, inv_tab_style.style,inv_item_quick_refrence.desc_quick_refrence " & _
                   " FROM         inv_item INNER JOIN " & _
                   " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                   " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                   " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                   " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                   " (SELECT     cod_table_public, desc_table " & _
                   " FROM inv_tab_public  " & _
                   " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                   " V_Location ON inv_item.item_no = V_Location.item_no INNER JOIN " & _
                   "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                   " WHERE     inv_item.cod_item_type = '04' " & _
                   IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                   " order by    inv_item_quick_refrence.desc_quick_refrence,inv_tab_brand.complete_desc_brand, inv_tab_line.line  "
            DAInvListReport.Fill(DsFrmPrint1.InventoryCountSheet)

            DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,v_location.cod_location as bin, V_Location.on_hand AS qoh,inv_tab_brand.complete_desc_brand as remarks, 1 AS flag ,inv_tab_line.line, inv_tab_brand.cod_brand, inv_tab_style.style,inv_item_quick_refrence.desc_quick_refrence " & _
                              " fROM         inv_item INNER JOIN " & _
                              " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                              " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                              " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                              " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                              " (SELECT     cod_table_public, desc_table " & _
                              " FROM inv_tab_public " & _
                              " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                              " V_Location ON inv_item.item_no = V_Location.item_no INNER JOIN " & _
                              "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                              " WHERE     inv_item.cod_item_type = '01' " & _
                              IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                          " order by    inv_item_quick_refrence.desc_quick_refrence,inv_tab_brand.complete_desc_brand, inv_tab_line.line "

            DAInvListReport.Fill(DsFrmPrint1.InventoryCountSheet)

        Else
            If ItemType = "01" Then
                DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,v_location.cod_location as bin, V_Location.on_hand AS qoh,inv_tab_brand.complete_desc_brand as remarks, 1 AS flag ,inv_tab_line.line, inv_tab_brand.cod_brand, inv_tab_style.style,inv_item_quick_refrence.desc_quick_refrence " & _
                       " fROM         inv_item INNER JOIN " & _
                       " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                       " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                       " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                       " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no INNER JOIN " & _
                       " (SELECT     cod_table_public, desc_table " & _
                       " FROM inv_tab_public " & _
                       " WHERE     cod_main = '01') inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                       " V_Location ON inv_item.item_no = V_Location.item_no INNER JOIN " & _
                       "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                       " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                       IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                   " order by    inv_item_quick_refrence.desc_quick_refrence,inv_tab_brand.complete_desc_brand, inv_tab_line.line "
            Else
                If ItemType = "04" Then
                    DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,v_location.cod_location as bin, V_Location.on_hand AS qoh, V_Location.comitted AS QCounted,inv_tab_brand.complete_desc_brand as remarks, 1 AS flag ,inv_tab_line.line, inv_tab_brand.cod_brand, inv_tab_style.style,inv_item_quick_refrence.desc_quick_refrence " & _
                          " FROM         inv_item INNER JOIN " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                          " inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification.item_no INNER JOIN " & _
                          " (SELECT     cod_table_public, desc_table " & _
                          " FROM inv_tab_public  " & _
                          " WHERE     cod_main = '01') inv_tab_public ON inv_tab_wheels_specification.wheel_size = inv_tab_public.cod_table_public LEFT OUTER JOIN " & _
                          " V_Location ON inv_item.item_no = V_Location.item_no INNER JOIN " & _
                          "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                          " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                          IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                          " order by    inv_item_quick_refrence.desc_quick_refrence,inv_tab_brand.complete_desc_brand, inv_tab_line.line  "
                Else
                    DAInvListReport.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,v_location.cod_location as bin, V_Location.on_hand AS qoh, V_Location.comitted AS qcounted,inv_tab_brand.complete_desc_brand as remarks, 1 AS flag ,inv_tab_line.line, inv_tab_brand.cod_brand, inv_tab_style.style,inv_item_quick_refrence.desc_quick_refrence " & _
                          " FROM         inv_item INNER JOIN " & _
                          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand LEFT OUTER JOIN " & _
                          " V_Location ON inv_item.item_no = V_Location.item_no INNER JOIN " & _
                          "  inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence " & _
                          " WHERE     inv_item.cod_item_type = " & Qt(ItemType) & _
                          IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
                          " order by    inv_item_quick_refrence.desc_quick_refrence,inv_tab_brand.complete_desc_brand, inv_tab_line.line "
                End If
            End If
            DsFrmPrint1.InventoryCountSheet.Clear()
            DAInvListReport.Fill(DsFrmPrint1.InventoryCountSheet)

        End If


        If DsFrmPrint1.InventoryCountSheet.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If


        'If FItem Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryCountSheet.Count - 1
        '        If DSMAIN.Tables("item").Select("flag=1 and code = " & Qt(DsFrmPrint1.InventoryCountSheet(i).item_no)).Length > 0 Then
        '            DsFrmPrint1.InventoryCountSheet(i).flagitem = 1
        '        End If
        '    Next
        'End If
        'If FLine Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryCountSheet.Count - 1
        '        If DSMAIN.Tables("line").Select("flag=1 and name = " & Qt(DsFrmPrint1.InventoryCountSheet(i).line)).Length > 0 Then
        '            DsFrmPrint1.InventoryCountSheet(i).flagline = 1
        '        End If
        '    Next
        'End If
        'If FBrand Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryCountSheet.Count - 1
        '        If DSMAIN.Tables("brand").Select("flag=1 and code = " & Qt(DsFrmPrint1.InventoryCountSheet(i).cod_brand)).Length > 0 Then
        '            DsFrmPrint1.InventoryCountSheet(i).flagbrand = 1
        '        End If
        '    Next
        'End If
        'If FStyle Then
        '    For i As Integer = 0 To DsFrmPrint1.InventoryCountSheet.Count - 1
        '        If DSMAIN.Tables("style").Select("flag=1 and code = " & Qt(DsFrmPrint1.InventoryCountSheet(i).style)).Length > 0 Then
        '            DsFrmPrint1.InventoryCountSheet(i).flagstyle = 1
        '        End If
        '    Next
        'End If

        'DsFrmPrint1.InventoryCountSheet.DefaultView.RowFilter = "  flagstyle=true and  flagbrand=true and  flagline=true and  flagitem = true"
        Grd3.SetDataBinding(DsFrmPrint1.InventoryCountSheet, "")

        Panel1.Visible = False
        Grd3.Height = 384

        Grd3.BringToFront()
        GridEXPrintDocument1.GridEX = Grd3
    End Sub
    Private Sub FillIVLSummery()

        DAInvListReport.SelectCommand.CommandText = " SELECT     inv_tab_type_item.cod_item_type, inv_tab_type_item.desc_item_type, SUM(ROUND(ISNULL(inv_item_cost_transaction.cost, 0), 2)) AS cost,  " & _
"                       SUM(ROUND(ISNULL(inv_item_cost_transaction.fet, 0), 2)) AS fet,  " & _
"                      SUM(ROUND(ISNULL(V_Location.on_hand,0),2)*(ROUND(ISNULL(inv_item_cost_transaction.cost, 0), 2)+ROUND(ISNULL(inv_item_cost_transaction.fet, 0), 2))) AS CostFet, 1 AS flag " & _
" FROM         inv_item INNER JOIN " & _
"                       inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
"                       inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
"                       V_Location ON inv_item.item_no = V_Location.item_no INNER JOIN " & _
"                       inv_tab_line ON inv_item.line = inv_tab_line.line " & IIf(StrWhere.Trim.Length = 0, "", " and " & StrWhere) & _
"  GROUP BY inv_tab_type_item.cod_item_type, inv_tab_type_item.desc_item_type " & _
" ORDER BY inv_tab_type_item.cod_item_type "

        DAInvListReport.Fill(DsFrmPrint1.IVRSummery)

        If DsFrmPrint1.IVRSummery.Count = 0 Then
            MsgBox("there is no item for this report")
            Me.Close()
        End If
        Panel1.Visible = False
        GrdIVRSummery.Height = 384

        GrdIVRSummery.BringToFront()
        GridEXPrintDocument1.GridEX = GrdIVRSummery

    End Sub
    Private Sub pprint1(ByVal type As String)
        Dim flagcount As Boolean = False
        For i As Int32 = 0 To DsFrmPrint1.inv_item.Count - 1
            If DsFrmPrint1.inv_item(i).flag Then
                flagcount = True
                Exit For
            End If
        Next
        If Not (flagcount) Then
            MsgBox("First Select The item You Want to print")
            Exit Sub
        End If

        'Dim strOrder As String = ""
        'For i As Integer = 0 To Grd1.CurrentTable.SortKeys.Count - 1
        '    strOrder = strOrder & Grd1.CurrentTable.SortKeys(i).Column.Caption & ", "
        'Next
        'If strOrder.Trim.Length > 0 Then strOrder = Mid(strOrder, 1, strOrder.Length - 2)

        Dim rpt As New RepInvList
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("Parorder", "Brand/Line/Quick Ref.")
        rpt.SetParameterValue("Parfilter", StrFilter)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")
        rpt.SetParameterValue("Paritemtype", ItemTypeName & "")
        'rpt.SetParameterValue("fromtodate", FromTodate & "")


        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        Select Case TypeForm
            Case 1
                rpt.SetParameterValue("parone", "Brand")
                rpt.SetParameterValue("partwo", "Style")
                rpt.SetParameterValue("parthree", "Quick Ref")
                rpt.SetParameterValue("parFour", "Location")
                rpt.SetParameterValue("Parrepname", "Inventory Listing Report")
                rpt.SetParameterValue("parB", "Size")
            Case 4
                rpt.SetParameterValue("parone", "Qty")
                rpt.SetParameterValue("partwo", "Last Sold")
                rpt.SetParameterValue("parthree", "Last Rcvd")
                rpt.SetParameterValue("parFour", "Last Adj")
                rpt.SetParameterValue("Parrepname", "Inventory Status Report")
                rpt.SetParameterValue("parB", "Brand")
            Case 5
                rpt.SetParameterValue("parone", "Qty")
                rpt.SetParameterValue("partwo", "Last Sold")
                rpt.SetParameterValue("parthree", "No Of Day")
                rpt.SetParameterValue("parFour", "Last Rcvd")
                rpt.SetParameterValue("Parrepname", "Slow Moving Report")
                rpt.SetParameterValue("parB", "Size")

        End Select

        rpt.SetDataSource(DsFrmPrint1)
        Select Case type.ToUpper

            Case "Print".ToUpper
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try

            Case "privew".ToUpper
                prn.CrViewer.ReportSource = rpt
                prn.Show()
        End Select
    End Sub
    Private Sub pprint2(ByVal type As String)
        Dim flagcount As Boolean = False
        For i As Integer = 0 To DsFrmPrint1.ProductPriceList.Count - 1
            If DsFrmPrint1.ProductPriceList(i).flag Then
                flagcount = True
                Exit For
            End If
        Next
        'Dim strOrder As String = ""
        'For i As Integer = 0 To Grd2.CurrentTable.SortKeys.Count - 1
        '    strOrder = strOrder & Grd2.CurrentTable.SortKeys(i).Column.Caption & ", "
        'Next
        'If strOrder.Trim.Length > 0 Then strOrder = Mid(strOrder, 1, strOrder.Length - 2)

        Dim rpt As New RepProductPriceList
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("Parorder", "Brand/Line/Quick Ref.")
        rpt.SetParameterValue("Parfilter", StrFilter)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")
        rpt.SetParameterValue("Paritemtype", ItemTypeName & "")
        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", "Product Price List")
        rpt.SetDataSource(DsFrmPrint1.ProductPriceList)

        Select Case type.ToUpper
            Case "Print".ToUpper
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try

            Case "privew".ToUpper
                prn.CrViewer.ReportSource = rpt
                prn.Show()
        End Select
    End Sub
    Private Sub pprint3(ByVal type As String)
        Dim flagcount As Boolean = False
        For i As Integer = 0 To DsFrmPrint1.InventoryCountSheet.Count - 1
            If DsFrmPrint1.InventoryCountSheet(i).flag Then
                flagcount = True
                Exit For
            End If
        Next
        'Dim strOrder As String = ""
        'For i As Integer = 0 To Grd3.CurrentTable.SortKeys.Count - 1
        '    strOrder = strOrder & Grd3.CurrentTable.SortKeys(i).Column.Caption & ", "
        'Next
        'If strOrder.Trim.Length > 0 Then strOrder = Mid(strOrder, 1, strOrder.Length - 2)

        Dim rpt As New RepInventoryCountSheet
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("Parorder", "Brand/Line/Quick Ref.")
        rpt.SetParameterValue("Parfilter", StrFilter)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")
        rpt.SetParameterValue("Paritemtype", ItemTypeName & "")
        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", "Inventory Count Sheet")
        rpt.SetDataSource(DsFrmPrint1.InventoryCountSheet)

        Select Case type.ToUpper
            Case "Print".ToUpper
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try

            Case "privew".ToUpper
                prn.CrViewer.ReportSource = rpt
                prn.Show()
        End Select
    End Sub

    Private Sub pprint4(ByVal type As String)
        Dim flagcount As Boolean = False
        For i As Int32 = 0 To DsFrmPrint1.inv_value.Count - 1
            If DsFrmPrint1.inv_value(i).flag Then
                flagcount = True
                Exit For
            End If
        Next
        If Not (flagcount) Then
            MsgBox("First Select The item You Want to print")
            Exit Sub
        End If

        'Dim strOrder As String = ""
        'For i As Integer = 0 To Grd1.CurrentTable.SortKeys.Count - 1
        '    strOrder = strOrder & Grd1.CurrentTable.SortKeys(i).Column.Caption & ", "
        'Next
        'If strOrder.Trim.Length > 0 Then strOrder = Mid(strOrder, 1, strOrder.Length - 2)

        Dim rpt As New RepInvValue
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("Parorder", "Brand/Line/Quick Ref.")
        rpt.SetParameterValue("Parfilter", StrFilter)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")
        rpt.SetParameterValue("Paritemtype", ItemTypeName & "")


        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", "Inventory Valuation Report")

        rpt.SetDataSource(DsFrmPrint1.inv_value)
        Select Case type.ToUpper

            Case "Print".ToUpper
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try

            Case "privew".ToUpper
                prn.CrViewer.ReportSource = rpt
                prn.Show()
        End Select
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
