Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayProductsReport
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
    Friend WithEvents DsFrmEndOfDayProductsReport1 As UCBankAccount.DSFrmEndOfDayProductsReport
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_sales_transfer_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Receive_product_dtl As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayProductsReport))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayProductsReport1 = New UCBankAccount.DSFrmEndOfDayProductsReport
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.DAinv_sales_transfer_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Receive_product_dtl = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayProductsReport1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayProductsReport1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""Type""><Caption>Type</Caption><DataMember>Type</DataMem" & _
        "ber><Key>Type</Key><Position>0</Position><Visible>False</Visible></Column0><Colu" & _
        "mn1 ID=""flag""><ColumnType>CheckBox</ColumnType><DataMember>flag</DataMember><Edi" & _
        "tType>CheckBox</EditType><Key>flag</Key><Position>1</Position><Visible>False</Vi" & _
        "sible><Width>43</Width></Column1><Column2 ID=""id_service_center""><Caption>Ref. N" & _
        "o.</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><E" & _
        "mptyStringValue /><DataMember>id_service_center</DataMember><Key>id_service_cent" & _
        "er</Key><Position>2</Position><Width>72</Width></Column2><Column3 ID=""date_refer" & _
        """><Caption>Date</Caption><DataMember>date_refer</DataMember><Key>date_refer</Key" & _
        "><Position>3</Position><Width>75</Width></Column3><Column4 ID=""cod_select""><Capt" & _
        "ion>Item No</Caption><DataMember>cod_select</DataMember><Key>cod_select</Key><Po" & _
        "sition>4</Position><Width>64</Width></Column4><Column5 ID=""desc_item""><Caption>D" & _
        "escription</Caption><DataMember>desc_item</DataMember><Key>desc_item</Key><Posit" & _
        "ion>5</Position><Width>195</Width></Column5><Column6 ID=""qty""><AggregateFunction" & _
        ">Sum</AggregateFunction><Caption>Qty</Caption><TypeNameEmptyStringValue>NULL</Ty" & _
        "peNameEmptyStringValue><EmptyStringValue /><DataMember>qty</DataMember><FormatSt" & _
        "ring>#####</FormatString><Key>qty</Key><Position>6</Position><TextAlignment>Far<" & _
        "/TextAlignment><Width>51</Width><TotalFormatString>#######</TotalFormatString></" & _
        "Column6><Column7 ID=""price""><Caption>Price</Caption><TypeNameEmptyStringValue>NU" & _
        "LL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>price</DataMember><" & _
        "FormatString>c2</FormatString><Key>price</Key><Position>7</Position><TextAlignme" & _
        "nt>Far</TextAlignment><Width>69</Width></Column7><Column8 ID=""fet""><Caption>Fet<" & _
        "/Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringVa" & _
        "lue /><DataMember>fet</DataMember><FormatString>c2</FormatString><Key>fet</Key><" & _
        "Position>8</Position><TextAlignment>Far</TextAlignment><Width>59</Width></Column" & _
        "8><Column9 ID=""ExtPrice""><AggregateFunction>Sum</AggregateFunction><Caption>Ext." & _
        " Price</Caption><DataMember>ExtPrice</DataMember><EditType>NoEdit</EditType><For" & _
        "matString>c2</FormatString><Key>ExtPrice</Key><Position>9</Position><TextAlignme" & _
        "nt>Far</TextAlignment><Width>79</Width><TotalFormatString>c2</TotalFormatString>" & _
        "</Column9><Column10 ID=""ExtCost""><AggregateFunction>Sum</AggregateFunction><Capt" & _
        "ion>Ext. Cost</Caption><DataMember>ExtCost</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FormatString>c2</FormatString><Key>ExtCost</Key><Position>10</Position><TextA" & _
        "lignment>Far</TextAlignment><Width>76</Width><TotalFormatString>C2</TotalFormatS" & _
        "tring></Column10><Column11 ID=""cod_vendor""><Caption>Vendor</Caption><DataMember>" & _
        "cod_vendor</DataMember><Key>cod_vendor</Key><Position>11</Position><Width>66</Wi" & _
        "dth></Column11><Column12 ID=""desc_vendor""><Caption>Vendor Ref.</Caption><DataMem" & _
        "ber>desc_vendor</DataMember><Key>desc_vendor</Key><Position>12</Position><Width>" & _
        "71</Width></Column12><Column13 ID=""desc_item_type""><Caption>Item Type</Caption><" & _
        "DataMember>desc_item_type</DataMember><Key>desc_item_type</Key><Position>13</Pos" & _
        "ition><Width>78</Width></Column13><Column14 ID=""StoreNo""><Caption>Store</Caption" & _
        "><DataMember>StoreNo</DataMember><EditType>NoEdit</EditType><Key>StoreNo</Key><P" & _
        "osition>14</Position><Width>37</Width></Column14></Columns><GroupCondition ID=""""" & _
        " /><Groups Collection=""true""><Group0 ID=""Group0""><ColIndex>0</ColIndex><GroupInt" & _
        "erval>Value</GroupInterval></Group0></Groups><Key>service_center_head</Key><Sort" & _
        "Keys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>2</ColIndex></SortKey0>" & _
        "</SortKeys></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GridEX1.Location = New System.Drawing.Point(0, 64)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(716, 340)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        '
        'DsFrmEndOfDayProductsReport1
        '
        Me.DsFrmEndOfDayProductsReport1.DataSetName = "DSFrmEndOfDayProductsReport"
        Me.DsFrmEndOfDayProductsReport1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT 1 AS flag, service_center_dtl.id_service_center, service_center_head.date_" & _
        "refer, service_center_dtl.cod_select, inv_item.desc_item, ISNULL(service_center_" & _
        "dtl.qty, 0) AS qty, ISNULL(service_center_dtl.price, 0) AS price, ISNULL(service" & _
        "_center_dtl.fet, 0) AS fet, ISNULL(service_center_dtl.qty * (service_center_dtl." & _
        "price + service_center_dtl.fet), 0) AS ExtPrice, ISNULL(service_center_dtl.qty *" & _
        " (inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item" & _
        "_cost_transaction.frieght), 0) AS ExtCost, inv_tab_type_item.desc_item_type, @St" & _
        "oreNo AS StoreNo, @Type AS Type FROM service_center_dtl LEFT OUTER JOIN service_" & _
        "center_head ON service_center_dtl.id_service_center = service_center_head.id_ser" & _
        "vice_center LEFT OUTER JOIN inv_item ON service_center_dtl.cod_select = inv_item" & _
        ".item_no LEFT OUTER JOIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_t" & _
        "ype_item.cod_item_type LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.ite" & _
        "m_no = inv_item_cost_transaction.item_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Variant))
        '
        'DAservice_center_dtl
        '
        Me.DAservice_center_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT 1 AS flag, inv_adjustment_dtl.referID_adjustment AS id_service_center, inv" & _
        "_adjustment_head.date_adjustment AS date_refer, inv_adjustment_dtl.item_no AS co" & _
        "d_select, inv_item.desc_item, ISNULL(inv_adjustment_dtl.QTY, 0) AS qty, ISNULL(i" & _
        "nv_adjustment_dtl.Cost, 0) AS price, ISNULL(inv_adjustment_dtl.fet, 0) AS fet, I" & _
        "SNULL(inv_adjustment_dtl.QTY * (inv_adjustment_dtl.Cost + inv_adjustment_dtl.fet" & _
        "), 0) AS ExtPrice, inv_tab_type_item.desc_item_type, @StoreNo AS StoreNo, @Type " & _
        "AS Type FROM inv_adjustment_dtl LEFT OUTER JOIN inv_adjustment_head ON inv_adjus" & _
        "tment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment LEFT OUTER" & _
        " JOIN inv_item ON inv_adjustment_dtl.item_no = inv_item.item_no LEFT OUTER JOIN " & _
        "inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Variant))
        '
        'DAinv_adjustment_dtl
        '
        Me.DAinv_adjustment_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("QTY", "QTY"), New System.Data.Common.DataColumnMapping("Cost", "Cost"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'DAinv_sales_transfer_dtl
        '
        Me.DAinv_sales_transfer_dtl.SelectCommand = Me.SqlCommand1
        Me.DAinv_sales_transfer_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_sales_transfer_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT 1 AS flag, inv_sales_transfer_dtl.ID_sales_transfer AS id_service_center, " & _
        "inv_salse_transfer_head.date_action AS date_refer, inv_sales_transfer_dtl.item_n" & _
        "o AS cod_select, inv_item.desc_item, ISNULL(inv_sales_transfer_dtl.qty, 0) AS qt" & _
        "y, ISNULL(inv_sales_transfer_dtl.price, 0) AS price, ISNULL(inv_sales_transfer_d" & _
        "tl.fet, 0) AS fet, ISNULL(inv_sales_transfer_dtl.qty * (inv_sales_transfer_dtl.p" & _
        "rice + inv_sales_transfer_dtl.fet), 0) AS ExtPrice, inv_tab_type_item.desc_item_" & _
        "type, @StoreNo AS StoreNo, @Type AS Type FROM inv_sales_transfer_dtl LEFT OUTER " & _
        "JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_s" & _
        "alse_transfer_head.ID_sales_transfer LEFT OUTER JOIN inv_item ON inv_sales_trans" & _
        "fer_dtl.item_no = inv_item.item_no LEFT OUTER JOIN inv_tab_type_item ON inv_item" & _
        ".cod_item_type = inv_tab_type_item.cod_item_type"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Variant))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT 1 AS flag, Inv_Receive_product_dtl.id_receive_ref AS id_service_center, In" & _
        "v_Receive_Products_head.date_receive AS date_refer, Inv_Receive_product_dtl.item" & _
        "_no AS cod_select, inv_item.desc_item, ISNULL(Inv_Receive_product_dtl.qty, 0) AS" & _
        " qty, ISNULL(Inv_Receive_product_dtl.cost, 0) AS price, ISNULL(Inv_Receive_produ" & _
        "ct_dtl.fet, 0) AS fet, ISNULL(Inv_Receive_product_dtl.qty * (Inv_Receive_product" & _
        "_dtl.cost + Inv_Receive_product_dtl.fet), 0) AS ExtPrice, inv_tab_type_item.desc" & _
        "_item_type, @StoreNo AS StoreNo, @Type AS Type, inv_vendor.cod_vendor, inv_vendo" & _
        "r.desc_vendor FROM Inv_Receive_product_dtl LEFT OUTER JOIN Inv_Receive_Products_" & _
        "head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_re" & _
        "ceive_ref LEFT OUTER JOIN inv_vendor ON Inv_Receive_Products_head.cod_vendor = i" & _
        "nv_vendor.cod_vendor LEFT OUTER JOIN inv_item ON Inv_Receive_product_dtl.item_no" & _
        " = inv_item.item_no LEFT OUTER JOIN inv_tab_type_item ON inv_item.cod_item_type " & _
        "= inv_tab_type_item.cod_item_type"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Variant))
        '
        'DAInv_Receive_product_dtl
        '
        Me.DAInv_Receive_product_dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DAInv_Receive_product_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'FrmEndOfDayProductsReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(716, 404)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.MaximizeBox = True
        Me.Name = "FrmEndOfDayProductsReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "End Of Day Products Report"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayProductsReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        Dim OriginalSelectCommand As String


        OriginalSelectCommand = DAservice_center_dtl.SelectCommand.CommandText
        DAservice_center_dtl.SelectCommand.CommandText = OriginalSelectCommand & " Where dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) & " AND inv_item_cost_transaction.last_flag=1 AND (service_center_head.type_of_form='IN' ) AND (service_center_dtl.type_select='I' OR service_center_dtl.type_select='A' OR service_center_dtl.type_select='T')"
        DAservice_center_dtl.SelectCommand.Parameters("@StoreNo").Value = PubStoreNO
        DAservice_center_dtl.SelectCommand.Parameters("@Type").Value = "INVOICES"
        DAservice_center_dtl.Fill(DsFrmEndOfDayProductsReport1.service_center_dtl)

        DAservice_center_dtl.SelectCommand.CommandText = OriginalSelectCommand & " Where dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) & " AND (service_center_head.type_of_form='RT' ) AND (service_center_dtl.type_select='I' OR service_center_dtl.type_select='A' OR service_center_dtl.type_select='T')"
        DAservice_center_dtl.SelectCommand.Parameters("@StoreNo").Value = PubStoreNO
        DAservice_center_dtl.SelectCommand.Parameters("@Type").Value = "CUSTOMER RETURNS"
        DAservice_center_dtl.Fill(DsFrmEndOfDayProductsReport1.service_center_dtl)

        DAinv_adjustment_dtl.SelectCommand.CommandText = DAinv_adjustment_dtl.SelectCommand.CommandText & " Where dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAinv_adjustment_dtl.SelectCommand.Parameters("@StoreNo").Value = PubStoreNO
        DAinv_adjustment_dtl.SelectCommand.Parameters("@Type").Value = "INVENTORY ADJUSTMENT"
        DAinv_adjustment_dtl.Fill(DsFrmEndOfDayProductsReport1.service_center_dtl)

        OriginalSelectCommand = DAinv_sales_transfer_dtl.SelectCommand.CommandText
        DAinv_sales_transfer_dtl.SelectCommand.CommandText = OriginalSelectCommand & " Where inv_salse_transfer_head.type_sales_transfer='1' AND dbo.changedate(date_action)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_action)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAinv_sales_transfer_dtl.SelectCommand.Parameters("@StoreNo").Value = PubStoreNO
        DAinv_sales_transfer_dtl.SelectCommand.Parameters("@Type").Value = "INTER-STORE SALES"
        DAinv_sales_transfer_dtl.Fill(DsFrmEndOfDayProductsReport1.service_center_dtl)

        DAinv_sales_transfer_dtl.SelectCommand.CommandText = OriginalSelectCommand & " Where inv_salse_transfer_head.type_sales_transfer='2' AND dbo.changedate(date_action)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_action)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAinv_sales_transfer_dtl.SelectCommand.Parameters("@StoreNo").Value = PubStoreNO
        DAinv_sales_transfer_dtl.SelectCommand.Parameters("@Type").Value = "INVENTORY TRANSFERS"
        DAinv_sales_transfer_dtl.Fill(DsFrmEndOfDayProductsReport1.service_center_dtl)

        OriginalSelectCommand = DAInv_Receive_product_dtl.SelectCommand.CommandText
        DAInv_Receive_product_dtl.SelectCommand.CommandText = OriginalSelectCommand & " Where Inv_Receive_Products_head.Bill_Credit='1' AND dbo.changedate(date_receive)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_receive)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAInv_Receive_product_dtl.SelectCommand.Parameters("@StoreNo").Value = PubStoreNO
        DAInv_Receive_product_dtl.SelectCommand.Parameters("@Type").Value = "INVENTORY RECEIPTS"
        DAInv_Receive_product_dtl.Fill(DsFrmEndOfDayProductsReport1.service_center_dtl)

        DAInv_Receive_product_dtl.SelectCommand.CommandText = OriginalSelectCommand & " Where Inv_Receive_Products_head.Bill_Credit='2' AND dbo.changedate(date_receive)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_receive)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar))
        DAInv_Receive_product_dtl.SelectCommand.Parameters("@StoreNo").Value = PubStoreNO
        DAInv_Receive_product_dtl.SelectCommand.Parameters("@Type").Value = "INVENTORY RETURNS"
        DAInv_Receive_product_dtl.Fill(DsFrmEndOfDayProductsReport1.service_center_dtl)

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
        For i As Integer = 0 To DsFrmEndOfDayProductsReport1.service_center_dtl.Count - 1
            DsFrmEndOfDayProductsReport1.service_center_dtl(i).flag = False
        Next
        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        For i As Integer = 0 To DsFrmEndOfDayProductsReport1.service_center_dtl.Count - 1
            DsFrmEndOfDayProductsReport1.service_center_dtl(i).flag = True
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
