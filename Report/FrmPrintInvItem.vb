Imports CommonClass
Imports Janus.Windows.GridEX

Public Class FrmPrintInvItem
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
    Friend WithEvents DsFrmPrintInvItem1 As Report.DSFrmPrintInvItem
    Friend WithEvents GrdSoldDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdLedger2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdLedger As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmbChildLedger As Janus.Windows.EditControls.UIButton
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents GrdTransfer As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrintInvItem))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout5 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout6 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.CmbChildLedger = New Janus.Windows.EditControls.UIButton
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
        Me.GrdLedger = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPrintInvItem1 = New Report.DSFrmPrintInvItem
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GrdSoldDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdSummery = New Janus.Windows.GridEX.GridEX
        Me.GrdLedger2 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.GrdTransfer = New Janus.Windows.GridEX.GridEX
        Me.Panel4.SuspendLayout()
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPrintInvItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSoldDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdLedger2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CmbChildLedger)
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
        'CmbChildLedger
        '
        Me.CmbChildLedger.Location = New System.Drawing.Point(223, 5)
        Me.CmbChildLedger.Name = "CmbChildLedger"
        Me.CmbChildLedger.Size = New System.Drawing.Size(50, 27)
        Me.CmbChildLedger.TabIndex = 194
        Me.CmbChildLedger.Text = "Expand"
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
        Me.GridEXPrintDocument1.GridEX = Me.GrdLedger
        '
        'GrdLedger
        '
        Me.GrdLedger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLedger.DataSource = Me.DsFrmPrintInvItem1.BiginQty
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><ChildTables Collection=""true""><Table0 ID=""Table1""><" & _
        "Columns Collection=""true""><Column0 ID=""flag""><ColumnType>CheckBox</ColumnType><D" & _
        "ataMember>flag</DataMember><EditType>CheckBox</EditType><Key>flag</Key><Position" & _
        ">0</Position><Visible>False</Visible><Width>19</Width></Column0><Column1 ID=""ite" & _
        "m_no""><Caption>Item</Caption><DataMember>item_no</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>item_no</Key><Position>1</P" & _
        "osition><Width>60</Width></Column1><Column2 ID=""desc_item""><Caption>Description<" & _
        "/Caption><DataMember>desc_item</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>desc_item</Key><Position>2</Position><Visible" & _
        ">False</Visible><Width>207</Width></Column2><Column3 ID=""RefNo""><Caption>Ref. No" & _
        "</Caption><DataMember>RefNo</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><Key>RefNo</Key><Position>3</Position><Width>77</Widt" & _
        "h></Column3><Column4 ID=""date""><Caption>Date</Caption><DataMember>date</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStr" & _
        "ing>MM/dd/yyyy</FormatString><Key>date</Key><Position>4</Position><Width>77</Wid" & _
        "th></Column4><Column5 ID=""qtyout""><AggregateFunction>Sum</AggregateFunction><Cap" & _
        "tion>Qty Out</Caption><DataMember>qtyout</DataMember><EditType>NoEdit</EditType>" & _
        "<FilterEditType>TextBox</FilterEditType><FormatString>#####,##</FormatString><Ke" & _
        "y>qtyout</Key><Position>5</Position><TextAlignment>Far</TextAlignment><Width>74<" & _
        "/Width></Column5><Column6 ID=""qtyin""><AggregateFunction>Sum</AggregateFunction><" & _
        "Caption>Qty In</Caption><DataMember>qtyin</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><FormatString>#####,##</FormatString><K" & _
        "ey>qtyin</Key><Position>6</Position><TextAlignment>Far</TextAlignment><Width>59<" & _
        "/Width></Column6><Column7 ID=""customer""><Caption>Customer</Caption><DataMember>c" & _
        "ustomer</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>customer</Key><Position>7</Position></Column7><Column8 ID=""vendor""><" & _
        "Caption>Vendor</Caption><DataMember>vendor</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><Key>vendor</Key><Position>8</Position" & _
        "><Width>86</Width></Column8><Column9 ID=""bill_credit""><Caption>bill_credit</Capt" & _
        "ion><DataMember>bill_credit</DataMember><FilterEditType>TextBox</FilterEditType>" & _
        "<Key>bill_credit</Key><Position>9</Position><Visible>False</Visible></Column9></" & _
        "Columns><DataMember>BiginQtybank_check</DataMember><GroupCondition ID="""" /><Key>" & _
        "Table1</Key></Table0></ChildTables><Columns Collection=""true""><Column0 ID=""flag""" & _
        "><ColumnType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBo" & _
        "x</EditType><Key>flag</Key><Position>0</Position><Width>19</Width></Column0><Col" & _
        "umn1 ID=""flagshow""><ColumnType>CheckBox</ColumnType><DataMember>flagshow</DataMe" & _
        "mber><EditType>CheckBox</EditType><Key>flagshow</Key><Position>1</Position><Visi" & _
        "ble>False</Visible><Width>19</Width></Column1><Column2 ID=""item_no""><Caption>Ite" & _
        "m</Caption><DataMember>item_no</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>item_no</Key><Position>2</Position><Width>58<" & _
        "/Width></Column2><Column3 ID=""desc_item""><Caption>Description</Caption><DataMemb" & _
        "er>desc_item</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fil" & _
        "terEditType><Key>desc_item</Key><Position>3</Position><Width>155</Width></Column" & _
        "3><Column4 ID=""BeginingQty""><AggregateFunction>Sum</AggregateFunction><Caption>B" & _
        "egin Qty</Caption><DataMember>BeginingQty</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><Key>BeginingQty</Key><Position>4</Posi" & _
        "tion><TextAlignment>Far</TextAlignment><Width>61</Width></Column4><Column5 ID=""Q" & _
        "tyOut""><AggregateFunction>Sum</AggregateFunction><Caption>QtyOut</Caption><DataM" & _
        "ember>QtyOut</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fil" & _
        "terEditType><Key>QtyOut</Key><Position>5</Position><TextAlignment>Far</TextAlign" & _
        "ment><Width>52</Width></Column5><Column6 ID=""QtyIn""><AggregateFunction>Sum</Aggr" & _
        "egateFunction><Caption>QtyIn</Caption><DataMember>QtyIn</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>TextBox</FilterEditType><Key>QtyIn</Key><Position" & _
        ">6</Position><TextAlignment>Far</TextAlignment><Width>53</Width></Column6><Colum" & _
        "n7 ID=""OnHand""><AggregateFunction>Sum</AggregateFunction><Caption>On Hand</Capti" & _
        "on><DataMember>OnHand</DataMember><EditType>NoEdit</EditType><FilterEditType>Tex" & _
        "tBox</FilterEditType><Key>OnHand</Key><Position>7</Position><TextAlignment>Far</" & _
        "TextAlignment><Width>73</Width></Column7><Column8 ID=""desc_item_type""><Caption>T" & _
        "ype</Caption><DataMember>desc_item_type</DataMember><EditType>NoEdit</EditType><" & _
        "FilterEditType>TextBox</FilterEditType><Key>desc_item_type</Key><Position>8</Pos" & _
        "ition><Width>78</Width></Column8><Column9 ID=""line""><Caption>Line</Caption><Data" & _
        "Member>line</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><Key>line</Key><Position>9</Position><Width>85</Width></Column9><Colu" & _
        "mn10 ID=""complete_desc_brand""><Caption>Brand</Caption><DataMember>complete_desc_" & _
        "brand</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdit" & _
        "Type><Key>complete_desc_brand</Key><Position>10</Position><Width>83</Width></Col" & _
        "umn10><Column11 ID=""desc_style""><Caption>Style</Caption><DataMember>desc_style</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><K" & _
        "ey>desc_style</Key><Position>11</Position><Width>81</Width></Column11></Columns>" & _
        "<DataMember>BiginQty</DataMember><GroupCondition ID="""" /></RootTable></GridEXLay" & _
        "outData>"
        Me.GrdLedger.DesignTimeLayout = GridEXLayout1
        Me.GrdLedger.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdLedger.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdLedger.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdLedger.Hierarchical = True
        Me.GrdLedger.Location = New System.Drawing.Point(0, 64)
        Me.GrdLedger.Name = "GrdLedger"
        Me.GrdLedger.RowWithErrorsFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GrdLedger.Size = New System.Drawing.Size(608, 392)
        Me.GrdLedger.TabIndex = 10
        Me.GrdLedger.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmPrintInvItem1
        '
        Me.DsFrmPrintInvItem1.DataSetName = "DSFrmPrintInvItem"
        Me.DsFrmPrintInvItem1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(169, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=sa;data source=armandehserver;" & _
        "persist security info=True;initial catalog=TireMate_03"
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item.item_no, inv_item.desc_item, service_center_dtl.id_service_center" & _
        " AS refno, service_center_head.date_refer AS date, 0 AS qtyin, ISNULL(service_ce" & _
        "nter_dtl.qty, 0) AS qtyout, inv_tab_type_item.desc_item_type, service_center_hea" & _
        "d.cod_customer AS customer, inv_tab_line.line, inv_tab_brand.complete_desc_brand" & _
        ", inv_tab_style.desc_style, 0 AS store_no, 1 AS flag, '' AS vendor, '' AS bill_c" & _
        "redit, 0 AS Begining FROM service_center_dtl INNER JOIN service_center_head ON s" & _
        "ervice_center_dtl.id_service_center = service_center_head.id_service_center INNE" & _
        "R JOIN inv_item INNER JOIN inv_tab_line ON inv_item.line = inv_tab_line.line INN" & _
        "ER JOIN inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN inv" & _
        "_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON service_center" & _
        "_dtl.cod_select = inv_item.item_no INNER JOIN inv_tab_type_item ON inv_item.cod_" & _
        "item_type = inv_tab_type_item.cod_item_type WHERE (service_center_head.type_of_f" & _
        "orm = 'IN') AND (service_center_dtl.type_select = 'I' OR service_center_dtl.type" & _
        "_select = 'A') AND (inv_item.cod_item_type = 01)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'GrdSoldDetail
        '
        Me.GrdSoldDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSoldDetail.DataMember = "SoldReport"
        Me.GrdSoldDetail.DataSource = Me.DsFrmPrintInvItem1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>17</Width></Column0><Column1 ID" & _
        "=""item_no""><Caption>Item</Caption><DataMember>item_no</DataMember><EditType>NoEd" & _
        "it</EditType><FilterEditType>TextBox</FilterEditType><Key>item_no</Key><Position" & _
        ">1</Position><Width>57</Width></Column1><Column2 ID=""desc_item""><AggregateFuncti" & _
        "on>StdDeviation</AggregateFunction><Caption>Description</Caption><DataMember>des" & _
        "c_item</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><Key>desc_item</Key><Position>2</Position><Width>156</Width></Column2><Col" & _
        "umn3 ID=""qty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty</Caption><D" & _
        "ataMember>qty</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fi" & _
        "lterEditType><FormatString>#####.##</FormatString><Key>qty</Key><Position>3</Pos" & _
        "ition><TextAlignment>Far</TextAlignment><Width>40</Width></Column3><Column4 ID=""" & _
        "unit_price""><AggregateFunction>Sum</AggregateFunction><Caption>Unit Price</Capti" & _
        "on><DataMember>unit_price</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><FormatString>c2</FormatString><Key>unit_price</Key><Po" & _
        "sition>4</Position><TextAlignment>Far</TextAlignment><Width>78</Width><TotalForm" & _
        "atString>C2</TotalFormatString></Column4><Column5 ID=""fet""><Caption>Fet</Caption" & _
        "><DataMember>fet</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><FormatString>c2</FormatString><Key>fet</Key><Position>5</Positi" & _
        "on><TextAlignment>Far</TextAlignment><Width>29</Width></Column5><Column6 ID=""ext" & _
        "_price""><AggregateFunction>Sum</AggregateFunction><Caption>Ext. Price</Caption><" & _
        "DataMember>ext_price</DataMember><EditType>NoEdit</EditType><FilterEditType>Text" & _
        "Box</FilterEditType><FormatString>c2</FormatString><Key>ext_price</Key><Position" & _
        ">6</Position><TextAlignment>Far</TextAlignment><Width>75</Width><TotalFormatStri" & _
        "ng>C2</TotalFormatString></Column6><Column7 ID=""ext_cost""><AggregateFunction>Sum" & _
        "</AggregateFunction><Caption>Ext. Cost</Caption><DataMember>ext_cost</DataMember" & _
        "><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStrin" & _
        "g>c2</FormatString><Key>ext_cost</Key><Position>7</Position><TextAlignment>Far</" & _
        "TextAlignment><Width>79</Width><TotalFormatString>C2</TotalFormatString></Column" & _
        "7><Column8 ID=""unit_cost""><AggregateFunction>Sum</AggregateFunction><Caption>Uni" & _
        "t Cost</Caption><DataMember>unit_cost</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>unit_co" & _
        "st</Key><Position>8</Position><TextAlignment>Far</TextAlignment><Width>80</Width" & _
        "><TotalFormatString>C2</TotalFormatString></Column8><Column9 ID=""id_service_cent" & _
        "er""><Caption>Ref. No</Caption><DataMember>id_service_center</DataMember><EditTyp" & _
        "e>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>id_service_cente" & _
        "r</Key><Position>9</Position><Width>77</Width></Column9><Column10 ID=""date_refer" & _
        """><Caption>Date</Caption><DataMember>date_refer</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatS" & _
        "tring><Key>date_refer</Key><Position>10</Position><Width>77</Width></Column10><C" & _
        "olumn11 ID=""desc_item_type""><Caption>Type</Caption><DataMember>desc_item_type</D" & _
        "ataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Ke" & _
        "y>desc_item_type</Key><Position>11</Position><Width>72</Width></Column11><Column" & _
        "12 ID=""line""><Caption>Line</Caption><DataMember>line</DataMember><EditType>NoEdi" & _
        "t</EditType><FilterEditType>TextBox</FilterEditType><Key>line</Key><Position>12<" & _
        "/Position><Width>79</Width></Column12><Column13 ID=""complete_desc_brand""><Captio" & _
        "n>Brand</Caption><DataMember>complete_desc_brand</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>complete_desc_brand</Key><P" & _
        "osition>13</Position><Width>78</Width></Column13><Column14 ID=""desc_style""><Capt" & _
        "ion>Style</Caption><DataMember>desc_style</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><Key>desc_style</Key><Position>14</Posi" & _
        "tion><Width>72</Width></Column14><Column15 ID=""store_no""><Caption>Store</Caption" & _
        "><DataMember>store_no</DataMember><EditType>NoEdit</EditType><FilterEditType>Tex" & _
        "tBox</FilterEditType><Key>store_no</Key><Position>15</Position><Width>41</Width>" & _
        "</Column15><Column16 ID=""name""><Caption>Name</Caption><DataMember>name</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name<" & _
        "/Key><Position>16</Position><Width>120</Width></Column16><Column17 ID=""complete_" & _
        "name""><Caption>Company</Caption><DataMember>complete_name</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_name</Key" & _
        "><Position>17</Position><Width>152</Width></Column17></Columns><GroupCondition I" & _
        "D="""" /></RootTable></GridEXLayoutData>"
        Me.GrdSoldDetail.DesignTimeLayout = GridEXLayout2
        Me.GrdSoldDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSoldDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdSoldDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdSoldDetail.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdSoldDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdSoldDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdSoldDetail.Name = "GrdSoldDetail"
        Me.GrdSoldDetail.Size = New System.Drawing.Size(608, 392)
        Me.GrdSoldDetail.TabIndex = 6
        Me.GrdSoldDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdDetail
        '
        Me.GrdDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.DataMember = "Detail"
        Me.GrdDetail.DataSource = Me.DsFrmPrintInvItem1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>19</Width></Column0><Column1 ID" & _
        "=""item_no""><Caption>Item</Caption><DataMember>item_no</DataMember><EditType>NoEd" & _
        "it</EditType><FilterEditType>TextBox</FilterEditType><Key>item_no</Key><Position" & _
        ">1</Position><Width>67</Width></Column1><Column2 ID=""desc_item""><Caption>Descrip" & _
        "tion</Caption><DataMember>desc_item</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><Key>desc_item</Key><Position>2</Position><Wi" & _
        "dth>127</Width></Column2><Column3 ID=""qty""><AggregateFunction>Sum</AggregateFunc" & _
        "tion><Caption>Qty</Caption><DataMember>qty</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><FormatString>#####.##</FormatString><" & _
        "Key>qty</Key><Position>3</Position><TextAlignment>Far</TextAlignment><Width>35</" & _
        "Width></Column3><Column4 ID=""unit_cost""><AggregateFunction>Sum</AggregateFunctio" & _
        "n><Caption>Unit Cost</Caption><DataMember>unit_cost</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStrin" & _
        "g><Key>unit_cost</Key><Position>4</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>74</Width><TotalFormatString>c2</TotalFormatString></Column4><Column5 ID=""f" & _
        "et""><AggregateFunction>Sum</AggregateFunction><Caption>Fet</Caption><DataMember>" & _
        "fet</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><FormatString>c2</FormatString><Key>fet</Key><Position>5</Position><TextAlign" & _
        "ment>Far</TextAlignment><Width>27</Width><TotalFormatString>c2</TotalFormatStrin" & _
        "g></Column5><Column6 ID=""ext_cost""><AggregateFunction>Sum</AggregateFunction><Ca" & _
        "ption>Ext. Cost</Caption><DataMember>ext_cost</DataMember><EditType>NoEdit</Edit" & _
        "Type><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key" & _
        ">ext_cost</Key><Position>6</Position><TextAlignment>Far</TextAlignment><Width>82" & _
        "</Width><TotalFormatString>C2</TotalFormatString></Column6><Column7 ID=""vendor"">" & _
        "<Caption>Vendor</Caption><DataMember>cod_vendor</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><Key>vendor</Key><Position>7</Pos" & _
        "ition><Width>67</Width></Column7><Column8 ID=""DeliveryReciept""><Caption>DR #</Ca" & _
        "ption><DataMember>DeliveryReciept</DataMember><EditType>NoEdit</EditType><Filter" & _
        "EditType>TextBox</FilterEditType><Key>DeliveryReciept</Key><Position>8</Position" & _
        "></Column8><Column9 ID=""NationalAccount""><Caption>NA #</Caption><DataMember>Nati" & _
        "onalAccount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><Key>NationalAccount</Key><Position>9</Position></Column9><Column10 I" & _
        "D=""RefNo""><Caption>Ref. No</Caption><DataMember>RefNo</DataMember><EditType>NoEd" & _
        "it</EditType><FilterEditType>TextBox</FilterEditType><Key>RefNo</Key><Position>1" & _
        "0</Position><Width>77</Width></Column10><Column11 ID=""date""><Caption>Date</Capti" & _
        "on><DataMember>date</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>date</Key><Positi" & _
        "on>11</Position><Width>66</Width></Column11><Column12 ID=""desc_item_type""><Capti" & _
        "on>Type</Caption><DataMember>desc_item_type</DataMember><EditType>NoEdit</EditTy" & _
        "pe><FilterEditType>TextBox</FilterEditType><Key>desc_item_type</Key><Position>12" & _
        "</Position><Width>73</Width></Column12><Column13 ID=""line""><Caption>Line</Captio" & _
        "n><DataMember>line</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBo" & _
        "x</FilterEditType><Key>line</Key><Position>13</Position><Width>75</Width></Colum" & _
        "n13><Column14 ID=""complete_desc_brand""><Caption>Brand</Caption><DataMember>compl" & _
        "ete_desc_brand</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</F" & _
        "ilterEditType><Key>complete_desc_brand</Key><Position>14</Position><Width>71</Wi" & _
        "dth></Column14><Column15 ID=""desc_style""><Caption>Style</Caption><DataMember>des" & _
        "c_style</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>desc_style</Key><Position>15</Position><Width>86</Width></Column15><" & _
        "Column16 ID=""store_no""><Caption>Store</Caption><DataMember>store_no</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>store_no" & _
        "</Key><Position>16</Position><Width>37</Width></Column16><Column17 ID=""bill_cred" & _
        "it""><Caption>bill_credit</Caption><DataMember>bill_credit</DataMember><Key>bill_" & _
        "credit</Key><Position>17</Position><Visible>False</Visible></Column17><Column18 " & _
        "ID=""explanation""><Caption>explanation</Caption><DataMember>explanation</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>expla" & _
        "nation</Key><Position>18</Position></Column18></Columns><GroupCondition ID="""" />" & _
        "</RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout3
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(608, 392)
        Me.GrdDetail.TabIndex = 7
        Me.GrdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdSummery
        '
        Me.GrdSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSummery.DataSource = Me.DsFrmPrintInvItem1.summery
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""store_no""><Caption>Store</Caption><DataMember>store_no</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>store_no</Key><Posi" & _
        "tion>1</Position><Width>45</Width></Column1><Column2 ID=""date""><Caption>Date</Ca" & _
        "ption><DataMember>date</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>date</Key><Pos" & _
        "ition>2</Position><Width>87</Width></Column2><Column3 ID=""type""><Caption>Type</C" & _
        "aption><DataMember>type</DataMember><EditType>NoEdit</EditType><FilterEditType>T" & _
        "extBox</FilterEditType><Key>type</Key><Position>3</Position><Width>96</Width></C" & _
        "olumn3><Column4 ID=""qty""><AggregateFunction>Sum</AggregateFunction><Caption>Qty<" & _
        "/Caption><DataMember>qty</DataMember><EditType>NoEdit</EditType><FilterEditType>" & _
        "TextBox</FilterEditType><FormatString>#####.##</FormatString><Key>qty</Key><Posi" & _
        "tion>4</Position><TextAlignment>Far</TextAlignment><Width>46</Width></Column4><C" & _
        "olumn5 ID=""ext_price""><AggregateFunction>Sum</AggregateFunction><Caption>Total P" & _
        "rice</Caption><DataMember>ext_price</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>ext_price" & _
        "</Key><Position>5</Position><TextAlignment>Far</TextAlignment><TotalFormatString" & _
        ">c2</TotalFormatString></Column5><Column6 ID=""ext_cost""><AggregateFunction>Sum</" & _
        "AggregateFunction><Caption>Total Cost</Caption><DataMember>ext_cost</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString" & _
        ">c2</FormatString><Key>ext_cost</Key><Position>6</Position><TextAlignment>Far</T" & _
        "extAlignment><TotalFormatString>c2</TotalFormatString></Column6></Columns><Group" & _
        "Condition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdSummery.DesignTimeLayout = GridEXLayout4
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
        'GrdLedger2
        '
        Me.GrdLedger2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLedger2.DataSource = Me.DsFrmPrintInvItem1.Ledger
        GridEXLayout5.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>18</Width></Column0><Column1 ID" & _
        "=""item_no""><Caption>Item</Caption><DataMember>item_no</DataMember><EditType>NoEd" & _
        "it</EditType><FilterEditType>TextBox</FilterEditType><Key>item_no</Key><Position" & _
        ">1</Position><Width>57</Width></Column1><Column2 ID=""desc_item""><Caption>Descrip" & _
        "tion</Caption><DataMember>desc_item</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><Key>desc_item</Key><Position>2</Position><Wi" & _
        "dth>107</Width></Column2><Column3 ID=""refno""><Caption>Ref. No</Caption><DataMemb" & _
        "er>refno</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><Key>refno</Key><Position>3</Position><Width>77</Width></Column3><Column" & _
        "4 ID=""date""><Caption>Date</Caption><DataMember>date</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><Key>date</Key><Position>4</P" & _
        "osition><Width>66</Width></Column4><Column5 ID=""qtyout""><AggregateFunction>Sum</" & _
        "AggregateFunction><Caption>Qty Out</Caption><DataMember>qtyout</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>####" & _
        "#.##</FormatString><Key>qtyout</Key><Position>5</Position><Width>51</Width></Col" & _
        "umn5><Column6 ID=""qtyin""><AggregateFunction>Sum</AggregateFunction><Caption>Qty " & _
        "In</Caption><DataMember>qtyin</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><FormatString>#####.##</FormatString><Key>qtyin</Ke" & _
        "y><Position>6</Position><Width>47</Width></Column6><Column7 ID=""desc_item_type"">" & _
        "<Caption>Type</Caption><DataMember>desc_item_type</DataMember><EditType>NoEdit</" & _
        "EditType><FilterEditType>TextBox</FilterEditType><Key>desc_item_type</Key><Posit" & _
        "ion>7</Position><Width>75</Width></Column7><Column8 ID=""customer""><Caption>custo" & _
        "mer</Caption><DataMember>customer</DataMember><EditType>NoEdit</EditType><Filter" & _
        "EditType>TextBox</FilterEditType><Key>customer</Key><Position>8</Position><Width" & _
        ">89</Width></Column8><Column9 ID=""vendor""><Caption>vendor</Caption><DataMember>v" & _
        "endor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdit" & _
        "Type><Key>vendor</Key><Position>9</Position><Width>81</Width></Column9><Column10" & _
        " ID=""line""><Caption>Line</Caption><DataMember>line</DataMember><EditType>NoEdit<" & _
        "/EditType><FilterEditType>TextBox</FilterEditType><Key>line</Key><Position>10</P" & _
        "osition><Width>90</Width></Column10><Column11 ID=""complete_desc_brand""><Caption>" & _
        "Brand</Caption><DataMember>complete_desc_brand</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>complete_desc_brand</Key><Pos" & _
        "ition>11</Position><Width>76</Width></Column11><Column12 ID=""desc_style""><Captio" & _
        "n>Style</Caption><DataMember>desc_style</DataMember><EditType>NoEdit</EditType><" & _
        "FilterEditType>TextBox</FilterEditType><Key>desc_style</Key><Position>12</Positi" & _
        "on><Width>78</Width></Column12><Column13 ID=""store_no""><Caption>Store</Caption><" & _
        "DataMember>store_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>store_no</Key><Position>13</Position><Width>63</Width></" & _
        "Column13><Column14 ID=""bill_credit""><Caption>bill_credit</Caption><DataMember>bi" & _
        "ll_credit</DataMember><Key>bill_credit</Key><Position>14</Position><Visible>Fals" & _
        "e</Visible></Column14><Column15 ID=""Begining""><AggregateFunction>Average</Aggreg" & _
        "ateFunction><Caption>Begining Qty</Caption><DataMember>Begining</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>###" & _
        "##.##</FormatString><Key>Begining</Key><Position>15</Position><Visible>False</Vi" & _
        "sible><TotalFormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>Begin" & _
        "ingQty({0})</TotalFormatString></Column15></Columns><GroupCondition ID="""" /><Gro" & _
        "ups Collection=""true""><Group0 ID=""Group0""><ColIndex>1</ColIndex></Group0></Group" & _
        "s></RootTable></GridEXLayoutData>"
        Me.GrdLedger2.DesignTimeLayout = GridEXLayout5
        Me.GrdLedger2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdLedger2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdLedger2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdLedger2.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdLedger2.Location = New System.Drawing.Point(0, 64)
        Me.GrdLedger2.Name = "GrdLedger2"
        Me.GrdLedger2.RowWithErrorsFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GrdLedger2.Size = New System.Drawing.Size(608, 392)
        Me.GrdLedger2.TabIndex = 9
        Me.GrdLedger2.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_item.item_no, inv_item.desc_item, service_center_dtl.id_service_center" & _
        " AS RefNo, service_center_head.date_refer AS date, service_center_dtl.qty AS qty" & _
        "in, inv_tab_type_item.desc_item_type, service_center_head.cod_customer AS custom" & _
        "er, inv_tab_line.line, inv_tab_brand.complete_desc_brand, inv_tab_style.desc_sty" & _
        "le, 0 AS store_no, 1 AS flag FROM service_center_head INNER JOIN service_center_" & _
        "dtl ON service_center_head.id_service_center = service_center_dtl.id_service_cen" & _
        "ter INNER JOIN inv_item INNER JOIN inv_tab_line ON inv_item.line = inv_tab_line." & _
        "line INNER JOIN inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER " & _
        "JOIN inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOI" & _
        "N inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type " & _
        "ON service_center_dtl.cod_select = inv_item.item_no WHERE (service_center_head.t" & _
        "ype_of_form = 'RT')"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbCommand1
        Me.DASTORE_SETUP.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "STORE_SETUP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("STORENO", "STORENO"), New System.Data.Common.DataColumnMapping("STORENAME", "STORENAME"), New System.Data.Common.DataColumnMapping("SHORTNAME", "SHORTNAME")})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Me.OleDbCommand1.Connection = Me.CnnMdbSetup
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'GrdTransfer
        '
        Me.GrdTransfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdTransfer.DataMember = "sales_transfer"
        Me.GrdTransfer.DataSource = Me.DsFrmPrintInvItem1
        GridEXLayout6.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>19</Width></Column0><Column1 ID" & _
        "=""item_no""><Caption>Item</Caption><DataMember>item_no</DataMember><EditType>NoEd" & _
        "it</EditType><FilterEditType>TextBox</FilterEditType><Key>item_no</Key><Position" & _
        ">1</Position><Width>61</Width></Column1><Column2 ID=""desc_item""><Caption>Descrip" & _
        "tion</Caption><DataMember>desc_item</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><Key>desc_item</Key><Position>2</Position><Wi" & _
        "dth>127</Width></Column2><Column3 ID=""qty""><AggregateFunction>Sum</AggregateFunc" & _
        "tion><Caption>Qty</Caption><DataMember>qty</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><FormatString>#####.##</FormatString><" & _
        "Key>qty</Key><Position>3</Position><Width>35</Width></Column3><Column4 ID=""unit_" & _
        "price""><AggregateFunction>Sum</AggregateFunction><Caption>Unit Price</Caption><D" & _
        "ataMember>unit_price</DataMember><EditType>NoEdit</EditType><FilterEditType>Text" & _
        "Box</FilterEditType><FormatString>c2</FormatString><Key>unit_price</Key><Positio" & _
        "n>4</Position><TextAlignment>Far</TextAlignment><Width>74</Width><TotalFormatStr" & _
        "ing>c2</TotalFormatString></Column4><Column5 ID=""fet""><AggregateFunction>Sum</Ag" & _
        "gregateFunction><Caption>Fet</Caption><DataMember>fet</DataMember><EditType>NoEd" & _
        "it</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStr" & _
        "ing><Key>fet</Key><Position>5</Position><TextAlignment>Far</TextAlignment><Width" & _
        ">27</Width><TotalFormatString>c2</TotalFormatString></Column5><Column6 ID=""unit_" & _
        "cost""><AggregateFunction>Sum</AggregateFunction><Caption>Ext. Price</Caption><Da" & _
        "taMember>ext_cost</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><FormatString>c2</FormatString><Key>unit_cost</Key><Position>6<" & _
        "/Position><TextAlignment>Far</TextAlignment><Width>82</Width><TotalFormatString>" & _
        "C2</TotalFormatString></Column6><Column7 ID=""store_to""><Caption>Sold To</Caption" & _
        "><DataMember>store_to</DataMember><EditType>NoEdit</EditType><FilterEditType>Tex" & _
        "tBox</FilterEditType><Key>store_to</Key><Position>7</Position><Width>67</Width><" & _
        "/Column7><Column8 ID=""ID_sales_transfer""><Caption>Ref. No</Caption><DataMember>I" & _
        "D_sales_transfer</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>ID_sales_transfer</Key><Position>8</Position><Width>77</Wid" & _
        "th></Column8><Column9 ID=""date_action""><Caption>Date</Caption><DataMember>date_a" & _
        "ction</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdit" & _
        "Type><FormatString>MM/dd/yyyy</FormatString><Key>date_action</Key><Position>9</P" & _
        "osition><Width>66</Width></Column9><Column10 ID=""desc_item_type""><Caption>Type</" & _
        "Caption><DataMember>desc_item_type</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><Key>desc_item_type</Key><Position>10</Positio" & _
        "n><Width>73</Width></Column10><Column11 ID=""line""><Caption>Line</Caption><DataMe" & _
        "mber>line</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><Key>line</Key><Position>11</Position><Width>75</Width></Column11><Colu" & _
        "mn12 ID=""complete_desc_brand""><Caption>Brand</Caption><DataMember>complete_desc_" & _
        "brand</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdit" & _
        "Type><Key>complete_desc_brand</Key><Position>12</Position><Width>71</Width></Col" & _
        "umn12><Column13 ID=""desc_style""><Caption>Style</Caption><DataMember>desc_style</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><K" & _
        "ey>desc_style</Key><Position>13</Position><Width>62</Width></Column13><Column14 " & _
        "ID=""store_from""><Caption>Sold By</Caption><DataMember>store_from</DataMember><Ed" & _
        "itType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>store_from<" & _
        "/Key><Position>14</Position><Width>51</Width></Column14><Column15 ID=""note""><Cap" & _
        "tion>Note</Caption><DataMember>note</DataMember><Key>note</Key><Position>15</Pos" & _
        "ition></Column15></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutDat" & _
        "a>"
        Me.GrdTransfer.DesignTimeLayout = GridEXLayout6
        Me.GrdTransfer.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdTransfer.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdTransfer.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdTransfer.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdTransfer.Location = New System.Drawing.Point(0, 64)
        Me.GrdTransfer.Name = "GrdTransfer"
        Me.GrdTransfer.Size = New System.Drawing.Size(608, 392)
        Me.GrdTransfer.TabIndex = 11
        Me.GrdTransfer.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'FrmPrintInvItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(606, 452)
        Me.Controls.Add(Me.GrdLedger)
        Me.Controls.Add(Me.GrdSoldDetail)
        Me.Controls.Add(Me.GrdTransfer)
        Me.Controls.Add(Me.GrdSummery)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.GrdLedger2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "FrmPrintInvItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPrintInvItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSoldDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdLedger2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim i As Integer
    Public StrWhere As String
    Public ItemType As String
    Public ItemTypeName As String
    Dim flagselect As String = "all"
    Public TypeForm As kindform
    Public StrFilter As String
    Public Date1 As String
    Public Date2 As String
    Public DSMAIN As New DataSet
    Public FItem As Boolean
    Public FLine As Boolean
    Public FBrand As Boolean
    Public FStyle As Boolean
    Public fromtodate As String = ""
    Public FlagDate As Boolean
    Public Enum KindForm As Integer
        SoldDetail = 1
        SoldSummery = 2
        RecieveDetail = 3
        RecieveSummery = 4
        ReturnDetail = 5
        ReturnSummery = 6
        OrderDetail = 7
        OrderSummery = 8
        AdjDetail = 9
        AdjSummery = 10
        Ledger = 11
        TransferDetail = 12
        TransferSummery = 13
        InterSaleDetail = 14
        InterSaleSummery = 15

    End Enum
    Private Sub FrmPrintInvItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        If Not (TypeForm = KindForm.Ledger) Then
            CmbChildLedger.Visible = False
        End If
        Select Case TypeForm
            Case KindForm.SoldDetail
                Call FillSoldDetail()
            Case KindForm.SoldSummery
                Call SoldSummery()
            Case KindForm.RecieveDetail
                Call ReceiveDetail()
            Case KindForm.RecieveSummery
                Call ReceiveSummery()
            Case KindForm.ReturnDetail
                Call ReturnDetail()
            Case KindForm.ReturnSummery
                Call ReturnSummery()
            Case KindForm.OrderDetail
                Call OrderDetail()
            Case KindForm.OrderSummery
                Call OrderSummery()
            Case KindForm.AdjDetail
                Call AdjustDetail()
            Case KindForm.AdjSummery
                Call AdjustSummery()
            Case KindForm.Ledger
                'Call FillLedgerDetail()
                Call FillLedger2()
            Case KindForm.TransferDetail
                Call FillSales_Transfer("2")
            Case KindForm.TransferSummery
                Call FillSales_TransferSummery("2")
            Case KindForm.InterSaleDetail
                Call FillSales_Transfer("1")
            Case KindForm.InterSaleSummery
                Call FillSales_TransferSummery("1")
        End Select
        '''
        'If GrdLedger.RootTable.Groups(0).HeaderCaption = "Item" Then
        '    GrdLedger.RootTable.Columns(5).Visible = False
        'End If

        '
        If Date1.Trim.Length > 0 Then
            GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
        Else
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End If
        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
        If Not ItemTypeName Is Nothing Then
            If ItemTypeName.Trim.Length > 0 Then
                GridEXPrintDocument1.PageHeaderLeft = " Item Type : " & ItemTypeName
            End If
        End If

    End Sub
    Private Sub FillSoldDetail()
        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, ISNULL(service_center_dtl.qty, 0) AS qty, ISNULL(service_center_dtl.price, 0) AS unit_price, " & _
                      " ISNULL(service_center_dtl.fet, 0) AS fet, 0 AS ext_price, 0 AS ext_cost, ISNULL(inv_item_cost_transaction.cost, 0) AS unit_cost,  " & _
                      " service_center_dtl.id_service_center, service_center_head.date_refer, inv_tab_type_item.desc_item_type, inv_tab_line.line,  " & _
                      " inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style, 0 AS store_no, 1 AS flag,  " & _
                      " cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.cod_customer, cust_company.complete_name " & _
                      " FROM         service_center_dtl INNER JOIN " & _
                      " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON service_center_dtl.cod_select = inv_item.item_no INNER JOIN " & _
                      " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type  LEFT OUTER JOIN " & _
                      " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
                      " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                      " WHERE     (service_center_head.type_of_form = 'IN') and (inv_item_cost_transaction.last_flag=1) AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2)) & _
                      " ORDER BY dbo.ChangeDate(service_center_head.date_refer),inv_tab_brand.complete_desc_brand "

        DAGeneral.Fill(DsFrmPrintInvItem1.SoldReport)
        For i = 0 To DsFrmPrintInvItem1.SoldReport.Count - 1
            DsFrmPrintInvItem1.SoldReport(i).ext_cost = DsFrmPrintInvItem1.SoldReport(i).qty * (DsFrmPrintInvItem1.SoldReport(i).unit_cost + DsFrmPrintInvItem1.SoldReport(i).fet)
            DsFrmPrintInvItem1.SoldReport(i).ext_price = DsFrmPrintInvItem1.SoldReport(i).qty * (DsFrmPrintInvItem1.SoldReport(i).unit_price + DsFrmPrintInvItem1.SoldReport(i).fet)
            DsFrmPrintInvItem1.SoldReport(i).store_no = PubStoreNO
        Next
        DsFrmPrintInvItem1.SoldReport.AcceptChanges()
        GrdSoldDetail.BringToFront()
        GridEXPrintDocument1.GridEX = GrdSoldDetail

    End Sub
    Private Sub SoldSummery()
        DAGeneral.SelectCommand.CommandText = "SELECT     0 AS store_no, service_center_head.date_refer AS date, inv_tab_type_item.desc_item_type AS type, isnull(SUM(service_center_dtl.qty),0) AS qty, " & _
                      " isnull(SUM(service_center_dtl.price),0) AS unit_price, isnull(sum(service_center_dtl.fet),0) AS fet,SUM(ISNULL(service_center_dtl.qty, 0) " & _
                      "* (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_price, SUM(ISNULL(service_center_dtl.qty, 0) " & _
                      "* (ISNULL(inv_item_cost_transaction.cost, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_cost, isnull(SUM(inv_item_cost_transaction.cost),0) " & _
                      " AS unit_cost, 1 AS flag " & _
                 " FROM         service_center_dtl INNER JOIN " & _
                      " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON service_center_dtl.cod_select = inv_item.item_no INNER JOIN " & _
                      " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type " & _
                 " WHERE     (service_center_head.type_of_form = 'IN')  AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A')  " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2)) & _
                 " GROUP BY service_center_head.date_refer, inv_tab_type_item.desc_item_type "


        DAGeneral.Fill(DsFrmPrintInvItem1.summery)

        For i = 0 To DsFrmPrintInvItem1.summery.Count - 1
            'DsFrmPrintInvItem1.summery(i).ext_cost = DsFrmPrintInvItem1.summery(i).qty * (DsFrmPrintInvItem1.summery(i).unit_cost + DsFrmPrintInvItem1.summery(i).fet)
            'DsFrmPrintInvItem1.summery(i).ext_price = DsFrmPrintInvItem1.summery(i).qty * (DsFrmPrintInvItem1.summery(i).unit_price + DsFrmPrintInvItem1.summery(i).fet)
            DsFrmPrintInvItem1.summery(i).store_no = PubStoreNO
        Next
        DsFrmPrintInvItem1.summery.AcceptChanges()
        GrdSummery.BringToFront()
        GridEXPrintDocument1.GridEX = GrdSummery

    End Sub

    Private Sub ReceiveDetail()
        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, 0 AS ext_cost, inv_tab_type_item.desc_item_type, inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                      " inv_tab_style.desc_style, 0 AS store_no, 1 AS flag, isnull(Inv_Receive_product_dtl.qty,0) AS qty, isnull(Inv_Receive_product_dtl.cost,0) AS unit_cost, " & _
                      " isnull(Inv_Receive_product_dtl.fet,0) as fet,Inv_Receive_Products_head.cod_vendor AS vendor, Inv_Receive_product_dtl.id_receive_ref AS RefNo,  " & _
                      " Inv_Receive_Products_head.date_receive AS date,Inv_Receive_Products_head.bill_credit " & _
                      " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                      " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                      " where Inv_Receive_Products_head.bill_credit ='1' " & _
                      IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2)) & _
                      " order by   dbo.ChangeDate(Inv_Receive_Products_head.date_receive) , inv_tab_brand.complete_desc_brand , inv_item.item_no "

        DAGeneral.Fill(DsFrmPrintInvItem1.Detail)

        For i = 0 To DsFrmPrintInvItem1.Detail.Count - 1
            DsFrmPrintInvItem1.Detail(i).store_no = PubStoreNO
            DsFrmPrintInvItem1.Detail(i).ext_cost = DsFrmPrintInvItem1.Detail(i).qty * (DsFrmPrintInvItem1.Detail(i).unit_cost + DsFrmPrintInvItem1.Detail(i).fet)
        Next
        GrdDetail.BringToFront()
        GridEXPrintDocument1.GridEX = GrdDetail
    End Sub
    Private Sub ReceiveSummery()
        DAGeneral.SelectCommand.CommandText = "SELECT     0 AS store_no, Inv_Receive_Products_head.date_receive AS date, inv_tab_type_item.desc_item_type AS type, isnull(SUM(Inv_Receive_product_dtl.qty),0) " & _
                      " AS qty, SUM(ISNULL(Inv_Receive_product_dtl.qty, 0) " & _
                      "* (ISNULL(Inv_Receive_product_dtl.cost, 0) + ISNULL(Inv_Receive_product_dtl.fet, 0)))  AS ext_cost,0 AS store_no, isnull(sum(Inv_Receive_product_dtl.fet),0) as fet, isnull(SUM(Inv_Receive_product_dtl.cost),0) AS unit_cost, 1 AS flag,Inv_Receive_Products_head.bill_credit " & _
                      " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                      " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref  " & _
                      " where Inv_Receive_Products_head.bill_credit ='1'" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2)) & _
                " GROUP BY Inv_Receive_Products_head.date_receive, inv_tab_type_item.desc_item_type,Inv_Receive_Products_head.bill_credit "

        DAGeneral.Fill(DsFrmPrintInvItem1.summery)

        For i = 0 To DsFrmPrintInvItem1.summery.Count - 1
            'DsFrmPrintInvItem1.summery(i).ext_cost = DsFrmPrintInvItem1.summery(i).qty * (DsFrmPrintInvItem1.summery(i).unit_cost + DsFrmPrintInvItem1.summery(i).fet)
            DsFrmPrintInvItem1.summery(i).store_no = PubStoreNO
        Next
        DsFrmPrintInvItem1.summery.AcceptChanges()
        GrdSummery.RootTable.Columns.RemoveAt(5)
        GrdSummery.BringToFront()
        GridEXPrintDocument1.GridEX = GrdSummery

    End Sub
    Private Sub ReturnDetail()
        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, 0 AS ext_cost, inv_tab_type_item.desc_item_type, inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                  " inv_tab_style.desc_style, 0 AS store_no, 1 AS flag,isnull(Inv_Receive_product_dtl.qty,0) AS qty, isnull(Inv_Receive_product_dtl.cost,0) AS unit_cost, " & _
                  " isnull(Inv_Receive_product_dtl.fet,0) as fet,Inv_Receive_Products_head.cod_vendor AS vendor, Inv_Receive_product_dtl.id_receive_ref AS RefNo,  " & _
                  " Inv_Receive_Products_head.date_receive AS date,Inv_Receive_Products_head.bill_credit " & _
             " FROM         inv_item INNER JOIN " & _
                  " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                  " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                  " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                  " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                  " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                  " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                  " where Inv_Receive_Products_head.bill_credit ='2'" & _
                    IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2))
        DAGeneral.Fill(DsFrmPrintInvItem1.Detail)


        'DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, 0 AS ext_cost, inv_tab_type_item.desc_item_type, inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
        '              " inv_tab_style.desc_style,0 AS store_no, 1 AS flag, isnull(service_center_dtl.qty,0) AS qty, isnull(service_center_dtl.price,0) AS unit_cost, isnull(service_center_dtl.fet,0) AS fet,  " & _
        '              " service_center_dtl.id_service_center AS refno, service_center_head.date_refer AS date " & _
        '          " FROM         service_center_head INNER JOIN " & _
        '              " service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center INNER JOIN " & _
        '              " inv_item INNER JOIN " & _
        '              " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
        '              " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
        '              " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
        '              " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type ON service_center_dtl.cod_select = inv_item.item_no " & _
        '             " WHERE     (service_center_head.type_of_form = 'RT') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2))
        'Try
        '    DAGeneral.Fill(DsFrmPrintInvItem1.Detail)
        'Catch ex As Exception

        'End Try


        For i = 0 To DsFrmPrintInvItem1.Detail.Count - 1
            DsFrmPrintInvItem1.Detail(i).store_no = PubStoreNO

            DsFrmPrintInvItem1.Detail(i).ext_cost = DsFrmPrintInvItem1.Detail(i).qty * (DsFrmPrintInvItem1.Detail(i).unit_cost + DsFrmPrintInvItem1.Detail(i).fet)


        Next
        GrdDetail.BringToFront()
        GridEXPrintDocument1.GridEX = GrdDetail

    End Sub
    Private Sub ReturnSummery()
        'DAGeneral.SelectCommand.CommandText = "SELECT     0 AS store_no, service_center_head.date_refer AS date, inv_tab_type_item.desc_item_type AS type, isnull(SUM(service_center_dtl.fet),0) AS fet, SUM(ISNULL(service_center_dtl.qty, 0) " & _
        '              "* (ISNULL(service_center_dtl.price, 0) + ISNULL(service_center_dtl.fet, 0))) AS ext_cost, " & _
        '              " isnull(SUM(service_center_dtl.qty),0) AS qty, isnull(SUM(service_center_dtl.price),0) AS unit_cost, 1 AS flag " & _
        '        " FROM         service_center_head INNER JOIN " & _
        '              " service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center INNER JOIN " & _
        '              " inv_item INNER JOIN " & _
        '              " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
        '              " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
        '              " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
        '              " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type ON service_center_dtl.cod_select = inv_item.item_no " & _
        '       " WHERE     (service_center_head.type_of_form = 'RT') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2)) & _
        '       " GROUP BY service_center_head.date_refer, inv_tab_type_item.desc_item_type "

        'DAGeneral.Fill(DsFrmPrintInvItem1.summery)

        DAGeneral.SelectCommand.CommandText = "SELECT     0 AS store_no, Inv_Receive_Products_head.date_receive AS date, inv_tab_type_item.desc_item_type AS type, isnull(SUM(Inv_Receive_product_dtl.qty),0) " & _
                      " AS qty, SUM(ISNULL(Inv_Receive_product_dtl.qty, 0) " & _
                      "* (ISNULL(Inv_Receive_product_dtl.cost, 0) - ISNULL(Inv_Receive_product_dtl.fet, 0))) AS ext_cost,0 AS store_no,isnull(-(sum(Inv_Receive_product_dtl.fet)),0) as fet, isnull(-(SUM(Inv_Receive_product_dtl.cost)),0) AS unit_cost, 1 AS flag " & _
                " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                      " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                      " where Inv_Receive_Products_head.bill_credit ='2'" & IIf(StrWhere.Trim.Length > 0, " AND " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2)) & _
                " GROUP BY Inv_Receive_Products_head.date_receive, inv_tab_type_item.desc_item_type "

        DAGeneral.Fill(DsFrmPrintInvItem1.summery)

        For i = 0 To DsFrmPrintInvItem1.summery.Count - 1
            'DsFrmPrintInvItem1.summery(i).ext_cost = DsFrmPrintInvItem1.summery(i).qty * (DsFrmPrintInvItem1.summery(i).unit_cost + DsFrmPrintInvItem1.summery(i).fet)
            DsFrmPrintInvItem1.summery(i).store_no = PubStoreNO
        Next
        DsFrmPrintInvItem1.summery.AcceptChanges()
        GrdSummery.RootTable.Columns.RemoveAt(5)
        GrdSummery.BringToFront()
        GridEXPrintDocument1.GridEX = GrdSummery
    End Sub
    Private Sub OrderDetail()
        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, 0 AS ext_cost, inv_tab_type_item.desc_item_type, inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                      " inv_tab_style.desc_style,0 AS store_no, 1 AS flag, isnull(Inv_purchase_order_dtl.qty,0) AS qty, isnull(Inv_purchase_order_dtl.cost,0) AS unit_cost,  " & _
                      " isnull(Inv_purchase_order_dtl.fet,0) as fet,Inv_purchase_order_head.cod_vendor as vendor,Inv_purchase_order_dtl.po_no AS RefNo, Inv_purchase_order_head.date_po as date " & _
                      " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " Inv_purchase_order_dtl ON inv_item.item_no = Inv_purchase_order_dtl.item_no INNER JOIN " & _
                      " Inv_purchase_order_head ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_head.po_no " & _
                      IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2)))
        DAGeneral.Fill(DsFrmPrintInvItem1.Detail)

        For i = 0 To DsFrmPrintInvItem1.Detail.Count - 1
            DsFrmPrintInvItem1.Detail(i).store_no = PubStoreNO
            DsFrmPrintInvItem1.Detail(i).ext_cost = DsFrmPrintInvItem1.Detail(i).qty * (DsFrmPrintInvItem1.Detail(i).unit_cost + DsFrmPrintInvItem1.Detail(i).fet)
        Next
        GrdDetail.BringToFront()
        GridEXPrintDocument1.GridEX = GrdDetail
    End Sub
    Private Sub OrderSummery()
        DAGeneral.SelectCommand.CommandText = "SELECT     0 AS store_no, Inv_purchase_order_head.date_po AS date, inv_tab_type_item.desc_item_type as type,isnull(sum( Inv_purchase_order_dtl.qty),0)  AS qty,isnull(sum(Inv_purchase_order_dtl.fet),0) as fet, SUM(ISNULL(Inv_purchase_order_dtl.qty, 0) " & _
                      "* (ISNULL(Inv_purchase_order_dtl.cost, 0) + ISNULL(Inv_purchase_order_dtl.fet, 0))) AS ext_cost, " & _
                      " isnull(sum(Inv_purchase_order_dtl.cost),0) AS unit_cost, 1 AS flag " & _
                  " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " Inv_purchase_order_dtl ON inv_item.item_no = Inv_purchase_order_dtl.item_no INNER JOIN " & _
                      " Inv_purchase_order_head ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_head.po_no " & IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2))) & _
                  " GROUP BY Inv_purchase_order_head.date_po, inv_tab_type_item.desc_item_type "

        DAGeneral.Fill(DsFrmPrintInvItem1.summery)

        For i = 0 To DsFrmPrintInvItem1.summery.Count - 1
            'DsFrmPrintInvItem1.summery(i).ext_cost = DsFrmPrintInvItem1.summery(i).qty * (DsFrmPrintInvItem1.summery(i).unit_cost )
            DsFrmPrintInvItem1.summery(i).store_no = PubStoreNO
        Next
        DsFrmPrintInvItem1.summery.AcceptChanges()
        GrdSummery.RootTable.Columns.RemoveAt(5)
        GrdSummery.BringToFront()
        GridEXPrintDocument1.GridEX = GrdSummery

    End Sub

    Private Sub AdjustDetail()
        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, 0 AS ext_cost, inv_tab_type_item.desc_item_type, inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                      " inv_tab_style.desc_style,0 AS store_no, 1 AS flag, isnull(inv_adjustment_dtl.QTY,0) AS qty, isnull(inv_adjustment_dtl.Cost,0) AS unit_cost,  " & _
                      " inv_adjustment_head.explanation as vendor,inv_adjustment_dtl.referID_adjustment AS RefNo, inv_adjustment_head.date_adjustment AS date, " & _
                      " inv_adjustment_head.DeliveryReciept,inv_adjustment_head.NationalAccount,inv_adjustment_head.cod_vendor,inv_adjustment_head.explanation " & _
                 " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " inv_adjustment_dtl ON inv_item.item_no = inv_adjustment_dtl.item_no INNER JOIN " & _
                      " inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment " & _
        IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(inv_adjustment_head.date_adjustment) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(inv_adjustment_head.date_adjustment) between" & Qt(Date1) & " and " & Qt(Date2))) & _
                      " order by  dbo.ChangeDate(inv_adjustment_head.date_adjustment),inv_adjustment_dtl.referID_adjustment , inv_item.item_no"

        DAGeneral.Fill(DsFrmPrintInvItem1.Detail)

        For i = 0 To DsFrmPrintInvItem1.Detail.Count - 1
            DsFrmPrintInvItem1.Detail(i).store_no = PubStoreNO
            DsFrmPrintInvItem1.Detail(i).ext_cost = DsFrmPrintInvItem1.Detail(i).qty * (DsFrmPrintInvItem1.Detail(i).unit_cost)
        Next
        GrdDetail.RootTable.Columns(6).Caption = "Extension"
        GrdDetail.BringToFront()
        GridEXPrintDocument1.GridEX = GrdDetail


    End Sub
    Private Sub AdjustSummery()
        DAGeneral.SelectCommand.CommandText = "SELECT     0 AS store_no, inv_adjustment_head.date_adjustment AS date, inv_tab_type_item.desc_item_type AS type, isnull(SUM(inv_adjustment_dtl.QTY),0) AS qty, " & _
                      " SUM(ISNULL(inv_adjustment_dtl.QTY, 0) " & _
                      "* (ISNULL(inv_adjustment_dtl.Cost, 0) ))  AS ext_cost, isnull(SUM(inv_adjustment_dtl.Cost),0) AS unit_cost, 1 AS flag " & _
                   " FROM         inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " inv_adjustment_dtl ON inv_item.item_no = inv_adjustment_dtl.item_no INNER JOIN " & _
                      " inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment " & IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(inv_adjustment_head.date_adjustment) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(inv_adjustment_head.date_adjustment) between" & Qt(Date1) & " and " & Qt(Date2))) & _
                  " GROUP BY inv_adjustment_head.date_adjustment, inv_tab_type_item.desc_item_type "

        DAGeneral.Fill(DsFrmPrintInvItem1.summery)

        For i = 0 To DsFrmPrintInvItem1.summery.Count - 1
            'DsFrmPrintInvItem1.summery(i).ext_cost = DsFrmPrintInvItem1.summery(i).qty * (DsFrmPrintInvItem1.summery(i).unit_cost)
            DsFrmPrintInvItem1.summery(i).store_no = PubStoreNO
        Next
        DsFrmPrintInvItem1.summery.AcceptChanges()
        GrdSummery.RootTable.Columns.RemoveAt(5)
        GrdSummery.BringToFront()
        GridEXPrintDocument1.GridEX = GrdSummery
    End Sub
    Private Sub FillLedger2()
        If Date1.Trim.Length > 0 Then

            DAGeneral.SelectCommand.CommandText = " select inv_item.item_no,isnull(sum(qtyin)-sum(qtyout),0) as BeginingQty,0 as QtyOut,0 as Qtyin, 1 as flag,inv_item.desc_item " & _
                      " , dbo.inv_tab_type_item.desc_item_type ,dbo.inv_tab_line.line,    dbo.inv_tab_brand.complete_desc_brand, dbo.inv_tab_style.desc_style, 0 AS store_no,0 as OnHand " & _
               " FROM         dbo.inv_item INNER JOIN " & _
                      " dbo.inv_tab_line ON dbo.inv_item.line = dbo.inv_tab_line.line INNER JOIN " & _
                      " dbo.inv_tab_style ON dbo.inv_tab_line.style = dbo.inv_tab_style.style INNER JOIN " & _
                      " dbo.inv_tab_brand ON dbo.inv_tab_line.cod_brand = dbo.inv_tab_brand.cod_brand INNER JOIN " & _
                      " dbo.inv_tab_type_item ON dbo.inv_item.cod_item_type = dbo.inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " dbo.v_BeginingQty ON dbo.inv_item.item_no = dbo.v_BeginingQty.item_no " & _
               " where dbo.ChangeDate(date1) < " & Qt(Date1) & _
               " group by inv_item.item_no,inv_item.desc_item , dbo.inv_tab_type_item.desc_item_type ,dbo.inv_tab_line.line,    dbo.inv_tab_brand.complete_desc_brand, dbo.inv_tab_style.desc_style "
            Try
                DAGeneral.Fill(DsFrmPrintInvItem1.BiginQty)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            DAGeneral.SelectCommand.CommandText = " SELECT     dbo.inv_tab_item_warehouse.item_no, dbo.inv_tab_item_warehouse.Begining_Balance_Qty AS BeginingQty,0 as QtyOut,0 as Qtyin , 1 as flag,inv_item.desc_item " & _
                       " , dbo.inv_tab_type_item.desc_item_type ,dbo.inv_tab_line.line,    dbo.inv_tab_brand.complete_desc_brand, dbo.inv_tab_style.desc_style, 0 AS store_no ,0 as OnHand" & _
                      " FROM         dbo.inv_item INNER JOIN " & _
                      " dbo.inv_tab_line ON dbo.inv_item.line = dbo.inv_tab_line.line INNER JOIN " & _
                      " dbo.inv_tab_style ON dbo.inv_tab_line.style = dbo.inv_tab_style.style INNER JOIN " & _
                      " dbo.inv_tab_brand ON dbo.inv_tab_line.cod_brand = dbo.inv_tab_brand.cod_brand INNER JOIN " & _
                      " dbo.inv_tab_type_item ON dbo.inv_item.cod_item_type = dbo.inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " dbo.inv_tab_item_warehouse ON dbo.inv_item.item_no = dbo.inv_tab_item_warehouse.item_no "
            Try
                DAGeneral.Fill(DsFrmPrintInvItem1.BiginQty)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,inv_adjustment_dtl.referID_adjustment AS refno, inv_adjustment_head.date_adjustment AS date, " & _
                 "  CASE WHEN isnull(inv_adjustment_dtl.QTY, 0)> 0 THEN isnull(inv_adjustment_dtl.QTY, 0) else 0 END AS qtyin, CASE WHEN isnull(inv_adjustment_dtl.QTY, 0) < 0 THEN - (isnull(inv_adjustment_dtl.QTY,0)) else 0 END AS qtyout " & _
                 " ,'' as customer, 1 AS flag,'' as vendor,'' as bill_credit,0 as Begining  " & _
                 " FROM         inv_item INNER JOIN " & _
                 " inv_adjustment_dtl ON inv_item.item_no = inv_adjustment_dtl.item_no INNER JOIN " & _
                 " inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment " & _
                  IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(inv_adjustment_head.date_adjustment) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(inv_adjustment_head.date_adjustment) between" & Qt(Date1) & " and " & Qt(Date2)))
        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'For i = 0 To DsFrmPrintInvItem1.Ledger.Rows.Count - 1
        '    If DsFrmPrintInvItem1.Ledger(i).qtyin < 0 Then
        '        DsFrmPrintInvItem1.Ledger(i).qtyout = -(DsFrmPrintInvItem1.Ledger(i).qtyin)
        '        DsFrmPrintInvItem1.Ledger(i).qtyin = 0
        '    End If
        'Next

        DsFrmPrintInvItem1.Ledger.AcceptChanges()

        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, service_center_dtl.id_service_center as refno,service_center_head.date_refer as date,isnull(service_center_dtl.qty,0) as qtyout," & _
                             " service_center_head.cod_customer as customer, 1 AS flag " & _
                       " FROM         service_center_dtl INNER JOIN " & _
                             " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                             " inv_item  ON service_center_dtl.cod_select = inv_item.item_no  " & _
                        "WHERE     (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2))

        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, Inv_Receive_product_dtl.id_receive_ref AS RefNo,Inv_Receive_Products_head.date_receive AS date, isnull(Inv_Receive_product_dtl.qty,0) AS qtyin ,0 as qtyout," & _
                          " Inv_Receive_Products_head.cod_vendor AS vendor , 1 AS flag,Inv_Receive_Products_head.bill_credit " & _
                       " FROM         inv_item INNER JOIN " & _
                            " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                            " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                            " where Inv_Receive_Products_head.bill_credit ='1' " & _
                            IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2))


        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, Inv_Receive_product_dtl.id_receive_ref AS RefNo,  " & _
                    " Inv_Receive_Products_head.date_receive AS date,0 as qtyin, isnull(Inv_Receive_product_dtl.qty,0) AS qtyout, " & _
                  " Inv_Receive_Products_head.cod_vendor AS vendor , 1 AS flag,Inv_Receive_Products_head.bill_credit " & _
               " FROM         inv_item INNER JOIN " & _
                    " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                    " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                    " where Inv_Receive_Products_head.bill_credit ='2'" & _
                      IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2))

        DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)


        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,service_center_dtl.id_service_center AS RefNo, service_center_head.date_refer AS date, -(isnull(service_center_dtl.qty,0)) AS qtyin,0 as qtyout, " & _
         " service_center_head.cod_customer as customer , 1 AS flag " & _
                      " FROM         service_center_head INNER JOIN " & _
                      " service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center INNER JOIN " & _
                      " inv_item  ON service_center_dtl.cod_select = inv_item.item_no " & _
                      " WHERE     (service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2))

        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
             MsgBox(ex.Message)
        End Try


        'DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,Inv_purchase_order_dtl.po_no AS RefNo, Inv_purchase_order_head.date_po as date, " & _
        '              " isnull(Inv_purchase_order_dtl.qty,0) AS qtyin,inv_tab_type_item.desc_item_type,Inv_purchase_order_head.cod_vendor as vendor , inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
        '              " inv_tab_style.desc_style,0 AS store_no, 1 AS flag " & _
        '              " FROM         inv_item INNER JOIN " & _
        '              " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
        '              " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
        '              " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
        '              " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
        '              " Inv_purchase_order_dtl ON inv_item.item_no = Inv_purchase_order_dtl.item_no INNER JOIN " & _
        '              " Inv_purchase_order_head ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_head.po_no " & _
        '              IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2)))

        'DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)

        DAGeneral.SelectCommand.CommandText = " SELECT     inv_sales_transfer_dtl.item_no, inv_item.desc_item, inv_sales_transfer_dtl.ID_sales_transfer AS RefNo, inv_salse_transfer_head.date_action as date , 1 AS flag, " & _
                      " 0 as qtyin,inv_sales_transfer_dtl.qty AS qtyout,type_sales_transfer as bill_credit " & _
                      " FROM         inv_salse_transfer_head INNER JOIN " & _
                      " inv_sales_transfer_dtl ON inv_salse_transfer_head.ID_sales_transfer = inv_sales_transfer_dtl.ID_sales_transfer INNER JOIN " & _
                      " inv_item ON inv_sales_transfer_dtl.item_no = inv_item.item_no " & _
                        IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2)))
        DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        ''''********************


        Dim dr() As DataRow
        Dim j As Integer
        For i = 0 To DsFrmPrintInvItem1.BiginQty.Count - 1
            dr = DsFrmPrintInvItem1.Ledger.Select("item_no =" & Qt(DsFrmPrintInvItem1.BiginQty(i).item_no))
            If dr.Length > 0 Then
                DsFrmPrintInvItem1.BiginQty(i).flagshow = True
            Else
                DsFrmPrintInvItem1.BiginQty(i).flagshow = False
            End If
            For j = 0 To dr.Length - 1
                DsFrmPrintInvItem1.BiginQty(i).QtyIn = DsFrmPrintInvItem1.BiginQty(i).QtyIn + IIf(dr(j).Item("qtyin") Is DBNull.Value, 0, dr(j).Item("qtyin"))
                DsFrmPrintInvItem1.BiginQty(i).QtyOut = DsFrmPrintInvItem1.BiginQty(i).QtyOut + IIf(dr(j).Item("qtyout") Is DBNull.Value, 0, dr(j).Item("qtyout"))
                DsFrmPrintInvItem1.BiginQty(i).OnHand = DsFrmPrintInvItem1.BiginQty(i).BeginingQty + DsFrmPrintInvItem1.BiginQty(i).QtyIn - DsFrmPrintInvItem1.BiginQty(i).QtyOut
            Next
            '''''''''''''''' ezafe shodeh tavasote ketabi '''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''' baraye in ke oonhaee ke ashari nadareh , integer biareh '''''''''''''''
            If DsFrmPrintInvItem1.BiginQty(i).QtyIn = Int(DsFrmPrintInvItem1.BiginQty(i).QtyIn) Then
                DsFrmPrintInvItem1.BiginQty(i).QtyIn = Int(DsFrmPrintInvItem1.BiginQty(i).QtyIn)
            End If
            If DsFrmPrintInvItem1.BiginQty(i).QtyOut = Int(DsFrmPrintInvItem1.BiginQty(i).QtyOut) Then
                DsFrmPrintInvItem1.BiginQty(i).QtyOut = Int(DsFrmPrintInvItem1.BiginQty(i).QtyOut)
            End If
            If DsFrmPrintInvItem1.BiginQty(i).OnHand = Int(DsFrmPrintInvItem1.BiginQty(i).OnHand) Then
                DsFrmPrintInvItem1.BiginQty(i).OnHand = Int(DsFrmPrintInvItem1.BiginQty(i).OnHand)
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DsFrmPrintInvItem1.BiginQty(i).store_no = PubStoreNO
        Next

        DsFrmPrintInvItem1.BiginQty.AcceptChanges()




        DsFrmPrintInvItem1.BiginQty.DefaultView.RowFilter = "  flagshow = true "
        GrdLedger.SetDataBinding(DsFrmPrintInvItem1.BiginQty, "")

        GrdLedger.BringToFront()
        GridEXPrintDocument1.GridEX = GrdLedger
        GridEXPrintDocument1.PrintHierarchical = True



    End Sub
    Private Sub FillLedgerDetail()

        If Date1.Trim.Length > 0 Then

            DAGeneral.SelectCommand.CommandText = " select inv_item.item_no,isnull(sum(qtyin)-sum(qtyout),0) as BeginingQty, 1 as flag,inv_item.desc_item " & _
               " from dbo.v_BeginingQty INNER JOIN " & _
               " dbo.inv_item ON dbo.v_BeginingQty.item_no = dbo.inv_item.item_no " & _
               " where dbo.ChangeDate(date1) < " & Qt(Date1) & _
               " group by inv_item.item_no,inv_item.desc_item "
            Try
                DAGeneral.Fill(DsFrmPrintInvItem1.BiginQty)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            DAGeneral.SelectCommand.CommandText = " SELECT     dbo.inv_tab_item_warehouse.item_no, dbo.inv_tab_item_warehouse.Begining_Balance_Qty AS BeginingQty , 1 as flag,inv_item.desc_item " & _
                      " FROM         dbo.inv_tab_item_warehouse RIGHT OUTER JOIN " & _
                      " dbo.inv_item ON dbo.inv_tab_item_warehouse.item_no = dbo.inv_item.item_no "
            Try
                DAGeneral.Fill(DsFrmPrintInvItem1.BiginQty)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,inv_adjustment_dtl.referID_adjustment AS refno, inv_adjustment_head.date_adjustment AS date, " & _
                  "  CASE WHEN isnull(inv_adjustment_dtl.QTY, 0)> 0 THEN isnull(inv_adjustment_dtl.QTY, 0) else 0 END AS qtyin, CASE WHEN isnull(inv_adjustment_dtl.QTY, 0) < 0 THEN - (isnull(inv_adjustment_dtl.QTY,0)) else 0 END AS qtyout " & _
                  " ,inv_tab_type_item.desc_item_type,'' as customer,inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                  " inv_tab_style.desc_style,0 AS store_no, 1 AS flag,'' as vendor,'' as bill_credit,0 as Begining  " & _
                  " FROM         inv_item INNER JOIN " & _
                  " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                  " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                  " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                  " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                  " inv_adjustment_dtl ON inv_item.item_no = inv_adjustment_dtl.item_no INNER JOIN " & _
                  " inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment " & _
                   IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(inv_adjustment_head.date_adjustment) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(inv_adjustment_head.date_adjustment) between" & Qt(Date1) & " and " & Qt(Date2)))
        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
            MsgBox("")

        End Try
        'For i = 0 To DsFrmPrintInvItem1.Ledger.Rows.Count - 1
        '    If DsFrmPrintInvItem1.Ledger(i).qtyin < 0 Then
        '        DsFrmPrintInvItem1.Ledger(i).qtyout = -(DsFrmPrintInvItem1.Ledger(i).qtyin)
        '        DsFrmPrintInvItem1.Ledger(i).qtyin = 0
        '    End If
        'Next

        DsFrmPrintInvItem1.Ledger.AcceptChanges()

        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, service_center_dtl.id_service_center as refno,service_center_head.date_refer as date,isnull(service_center_dtl.qty,0) as qtyout," & _
                             " inv_tab_type_item.desc_item_type,service_center_head.cod_customer as customer, " & _
                             "  inv_tab_line.line, inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style, 0 AS store_no, 1 AS flag " & _
                       " FROM         service_center_dtl INNER JOIN " & _
                             " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                             " inv_item INNER JOIN " & _
                             " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                             " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                             " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand ON service_center_dtl.cod_select = inv_item.item_no INNER JOIN " & _
                             " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type " & _
                        "WHERE     (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2))

        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try



        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, Inv_Receive_product_dtl.id_receive_ref AS RefNo,Inv_Receive_Products_head.date_receive AS date, isnull(Inv_Receive_product_dtl.qty,0) AS qtyin ,0 as qtyout," & _
                            " inv_tab_type_item.desc_item_type, Inv_Receive_Products_head.cod_vendor AS vendor , inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                            " inv_tab_style.desc_style, 0 AS store_no, 1 AS flag,Inv_Receive_Products_head.bill_credit " & _
                       " FROM         inv_item INNER JOIN " & _
                            " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                            " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                            " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                            " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                            " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                            " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                            " where Inv_Receive_Products_head.bill_credit ='1' " & _
                            IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2))


        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, Inv_Receive_product_dtl.id_receive_ref AS RefNo,  " & _
                    " Inv_Receive_Products_head.date_receive AS date,0 as qtyin, isnull(Inv_Receive_product_dtl.qty,0) AS qtyout, " & _
                    " inv_tab_type_item.desc_item_type,Inv_Receive_Products_head.cod_vendor AS vendor ,inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                    " inv_tab_style.desc_style, 0 AS store_no, 1 AS flag,Inv_Receive_Products_head.bill_credit " & _
               " FROM         inv_item INNER JOIN " & _
                    " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                    " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                    " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                    " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                    " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                    " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                    " where Inv_Receive_Products_head.bill_credit ='2'" & _
                      IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(Inv_Receive_Products_head.date_receive) between " & Qt(Date1) & " and " & Qt(Date2))

        DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)


        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,service_center_dtl.id_service_center AS RefNo, service_center_head.date_refer AS date, -(isnull(service_center_dtl.qty,0)) AS qtyin,0 as qtyout, " & _
                      " inv_tab_type_item.desc_item_type,service_center_head.cod_customer as customer , inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
                      " inv_tab_style.desc_style,0 AS store_no, 1 AS flag " & _
                      " FROM         service_center_head INNER JOIN " & _
                      " service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center INNER JOIN " & _
                      " inv_item INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type ON service_center_dtl.cod_select = inv_item.item_no " & _
                      " WHERE     (service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(Date1) & " and " & Qt(Date2))

        Try
            DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        Catch ex As Exception
            MsgBox("ss")

        End Try


        'DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,Inv_purchase_order_dtl.po_no AS RefNo, Inv_purchase_order_head.date_po as date, " & _
        '              " isnull(Inv_purchase_order_dtl.qty,0) AS qtyin,inv_tab_type_item.desc_item_type,Inv_purchase_order_head.cod_vendor as vendor , inv_tab_line.line, inv_tab_brand.complete_desc_brand, " & _
        '              " inv_tab_style.desc_style,0 AS store_no, 1 AS flag " & _
        '              " FROM         inv_item INNER JOIN " & _
        '              " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
        '              " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
        '              " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
        '              " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
        '              " Inv_purchase_order_dtl ON inv_item.item_no = Inv_purchase_order_dtl.item_no INNER JOIN " & _
        '              " Inv_purchase_order_head ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_head.po_no " & _
        '              IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(Inv_purchase_order_head.date_po) between " & Qt(Date1) & " and " & Qt(Date2)))

        'DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)

        DAGeneral.SelectCommand.CommandText = " SELECT     inv_sales_transfer_dtl.item_no, inv_item.desc_item, inv_sales_transfer_dtl.ID_sales_transfer AS RefNo, inv_salse_transfer_head.date_action as date,  " & _
                      " inv_tab_type_item.desc_item_type, inv_tab_line.line, inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style, 0 AS store_no, 1 AS flag, " & _
                      " 0 as qtyin,inv_sales_transfer_dtl.qty AS qtyout,type_sales_transfer as bill_credit " & _
                      " FROM         inv_salse_transfer_head INNER JOIN " & _
                      " inv_sales_transfer_dtl ON inv_salse_transfer_head.ID_sales_transfer = inv_sales_transfer_dtl.ID_sales_transfer INNER JOIN " & _
                      " inv_item ON inv_sales_transfer_dtl.item_no = inv_item.item_no INNER JOIN " & _
                      " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
                      " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
                      " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
                      " inv_tab_style ON inv_tab_line.style = inv_tab_style.style " & _
                        IIf(StrWhere.Trim.Length > 0, " where " & StrWhere, "") & IIf(Date1 = "", "", IIf(StrWhere.Trim.Length > 0, " and dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2), " where dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2)))
        DAGeneral.Fill(DsFrmPrintInvItem1.Ledger)
        ''''********************


        Dim dr() As DataRow
        Dim j As Integer
        For i = 0 To DsFrmPrintInvItem1.BiginQty.Count - 1
            dr = DsFrmPrintInvItem1.Ledger.Select("item_no =" & Qt(DsFrmPrintInvItem1.BiginQty(i).item_no))
            If dr.Length > 0 Then
                DsFrmPrintInvItem1.BiginQty(i).flagshow = True
            Else
                DsFrmPrintInvItem1.BiginQty(i).flagshow = False
            End If
            For j = 0 To dr.Length - 1
                DsFrmPrintInvItem1.BiginQty(i).QtyIn = DsFrmPrintInvItem1.BiginQty(i).QtyIn + IIf(dr(j).Item("qtyin") Is DBNull.Value, 0, dr(j).Item("qtyin"))
                DsFrmPrintInvItem1.BiginQty(i).QtyOut = DsFrmPrintInvItem1.BiginQty(i).QtyOut + IIf(dr(j).Item("qtyout") Is DBNull.Value, 0, dr(j).Item("qtyout"))
                DsFrmPrintInvItem1.BiginQty(i).OnHand = DsFrmPrintInvItem1.BiginQty(i).BeginingQty + DsFrmPrintInvItem1.BiginQty(i).QtyIn - DsFrmPrintInvItem1.BiginQty(i).QtyOut
            Next
            '''''''''''''''' ezafe shodeh tavasote ketabi '''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''' baraye in ke oonhaee ke ashari nadareh , integer biareh '''''''''''''''
            If DsFrmPrintInvItem1.BiginQty(i).QtyIn = Int(DsFrmPrintInvItem1.BiginQty(i).QtyIn) Then
                DsFrmPrintInvItem1.BiginQty(i).QtyIn = Int(DsFrmPrintInvItem1.BiginQty(i).QtyIn)
            End If
            If DsFrmPrintInvItem1.BiginQty(i).QtyOut = Int(DsFrmPrintInvItem1.BiginQty(i).QtyOut) Then
                DsFrmPrintInvItem1.BiginQty(i).QtyOut = Int(DsFrmPrintInvItem1.BiginQty(i).QtyOut)
            End If
            If DsFrmPrintInvItem1.BiginQty(i).OnHand = Int(DsFrmPrintInvItem1.BiginQty(i).OnHand) Then
                DsFrmPrintInvItem1.BiginQty(i).OnHand = Int(DsFrmPrintInvItem1.BiginQty(i).OnHand)
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Next

        For i = 0 To DsFrmPrintInvItem1.Ledger.Count - 1
            'Try
            '    DsFrmPrintInvItem1.Ledger(i).Begining = DsFrmPrintInvItem1.BiginQty.FindByitem_no(DsFrmPrintInvItem1.Ledger(i).item_no).BeginingQty
            'Catch ex As Exception
            '    DsFrmPrintInvItem1.Ledger(i).Begining = 0
            'End Try
            DsFrmPrintInvItem1.Ledger(i).store_no = PubStoreNO

        Next
        'If Date1 = "" Then
        '    Dim Dte As String = Mid(Date1, 6, 2) & "/" & Mid(Date1, 9, 2) & "/" & Mid(Date1, 1, 4)
        '    GrdLedger.RootTable.Columns(15).TotalFormatString = "BeginingQty In " & Dte & "({0})"
        'Else
        '    GrdLedger.RootTable.Columns(15).TotalFormatString = "BeginingQty({0})"
        'End If



        DsFrmPrintInvItem1.BiginQty.DefaultView.RowFilter = "  flagshow = true "
        GrdLedger.SetDataBinding(DsFrmPrintInvItem1.BiginQty, "")

        GrdLedger.BringToFront()
        GridEXPrintDocument1.GridEX = GrdLedger
        GridEXPrintDocument1.PrintHierarchical = True


    End Sub
    Private Sub FillSales_Transfer(ByVal st As String)
        If st = "1" Then
            DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, ISNULL(inv_sales_transfer_dtl.qty, 0) AS qty, ISNULL(inv_sales_transfer_dtl.price, 0) AS unit_price,  " & _
          " ISNULL(inv_sales_transfer_dtl.fet, 0) AS fet, ISNULL(inv_sales_transfer_dtl.qty, 0) * (ISNULL(inv_sales_transfer_dtl.price, 0)  " & _
          " + ISNULL(inv_sales_transfer_dtl.fet, 0)) AS ext_cost,  " & _
          " inv_sales_transfer_dtl.ID_sales_transfer, inv_salse_transfer_head.date_action, inv_tab_type_item.desc_item_type, inv_tab_line.line,  " & _
          " inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style,1 AS flag, inv_salse_transfer_head.store_to,  " & _
          " inv_salse_transfer_head.store_from, inv_salse_transfer_head.note,'' as to_name,'' as from_name " & _
          " FROM         inv_item INNER JOIN " & _
          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
          " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
          " inv_sales_transfer_dtl ON inv_item.item_no = inv_sales_transfer_dtl.item_no INNER JOIN " & _
          " inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer " & _
          " WHERE      (inv_salse_transfer_head.type_sales_transfer = " & Qt(st) & ")" & _
            IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2)) & _
          " ORDER BY inv_item.item_no "
        Else
            DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, ISNULL(inv_sales_transfer_dtl.qty, 0) AS qty, ISNULL(inv_sales_transfer_dtl.price, 0) AS unit_price,  " & _
          " ISNULL(inv_sales_transfer_dtl.fet, 0) AS fet, ISNULL(inv_sales_transfer_dtl.qty, 0) * (ISNULL(inv_item_cost_transaction.cost, 0)  " & _
          " + ISNULL(inv_sales_transfer_dtl.fet, 0)) AS ext_cost, ISNULL(inv_item_cost_transaction.cost, 0) AS unit_cost,  " & _
          " inv_sales_transfer_dtl.ID_sales_transfer, inv_salse_transfer_head.date_action, inv_tab_type_item.desc_item_type, inv_tab_line.line,  " & _
          " inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style,1 AS flag, inv_salse_transfer_head.store_to,  " & _
          " inv_salse_transfer_head.store_from, inv_salse_transfer_head.note,'' as to_name,'' as from_name " & _
          " FROM         inv_item INNER JOIN " & _
          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
          " inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN " & _
          " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
          " inv_sales_transfer_dtl ON inv_item.item_no = inv_sales_transfer_dtl.item_no INNER JOIN " & _
          " inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer " & _
          " WHERE     (inv_item_cost_transaction.last_flag = 1) and (inv_salse_transfer_head.type_sales_transfer = " & Qt(st) & ")" & _
            IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2)) & _
          " ORDER BY inv_item.item_no "
        End If

        'If st = "1" Then
        '    DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, ISNULL(inv_sales_transfer_dtl.qty, 0) AS qty, ISNULL(inv_sales_transfer_dtl.price, 0) AS unit_price,  " & _
        '  " ISNULL(inv_sales_transfer_dtl.fet, 0) AS fet, ISNULL(inv_sales_transfer_dtl.qty, 0) * (ISNULL(inv_sales_transfer_dtl.price, 0)  " & _
        '  " + ISNULL(inv_sales_transfer_dtl.fet, 0)) AS ext_cost,  " & _
        '  " inv_sales_transfer_dtl.ID_sales_transfer, inv_salse_transfer_head.date_action, inv_tab_type_item.desc_item_type, inv_tab_line.line,  " & _
        '  " inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style,1 AS flag, inv_salse_transfer_head.store_to,  " & _
        '  " inv_salse_transfer_head.store_from, inv_salse_transfer_head.note,'' as to_name,'' as from_name " & _
        '  " FROM         inv_item INNER JOIN " & _
        '  " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
        '  " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
        '  " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
        '  " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
        '  " inv_sales_transfer_dtl ON inv_item.item_no = inv_sales_transfer_dtl.item_no INNER JOIN " & _
        '  " inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer " & _
        '  " WHERE      (inv_salse_transfer_head.type_sales_transfer = " & Qt(st) & ")" & _
        '    IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2)) & _
        '  " ORDER BY inv_item.item_no "

        'Else

        '    DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, ISNULL(inv_sales_transfer_dtl.qty, 0) AS qty, ISNULL(inv_sales_transfer_dtl.price, 0) AS unit_price,  " & _
        '  " ISNULL(inv_sales_transfer_dtl.fet, 0) AS fet, ISNULL(inv_sales_transfer_dtl.qty, 0) * (ISNULL(inv_sales_transfer_dtl.price, 0)  " & _
        '  " + ISNULL(inv_sales_transfer_dtl.fet, 0)) AS ext_cost,   " & _
        '  " inv_sales_transfer_dtl.ID_sales_transfer, inv_salse_transfer_head.date_action, inv_tab_type_item.desc_item_type, inv_tab_line.line,  " & _
        '  " inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style,1 AS flag, inv_salse_transfer_head.store_to,  " & _
        '  " inv_salse_transfer_head.store_from, inv_salse_transfer_head.note,'' as to_name,'' as from_name " & _
        '  " FROM         inv_item INNER JOIN " & _
        '  " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
        '  " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
        '  " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand  INNER JOIN " & _
        '  " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
        '  " inv_sales_transfer_dtl ON inv_item.item_no = inv_sales_transfer_dtl.item_no INNER JOIN " & _
        '  " inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer " & _
        '  " WHERE    (inv_salse_transfer_head.type_sales_transfer = " & Qt(st) & ")" & _
        '    IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2)) & _
        '  " ORDER BY inv_item.item_no "
        'End If



        CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables
        DAGeneral.Fill(DsFrmPrintInvItem1.sales_transfer)
        DASTORE_SETUP.Fill(DsFrmPrintInvItem1.STORE_SETUP)

        'For i As Integer = 0 To DsFrmPrintInvItem1.sales_transfer.Count - 1
        '    DsFrmPrintInvItem1.sales_transfer(i).to_name = DsFrmPrintInvItem1.STORE_SETUP.FindBySTORENO(DsFrmPrintInvItem1.sales_transfer(i).store_to).STORENAME
        '    DsFrmPrintInvItem1.sales_transfer(i).from_name = DsFrmPrintInvItem1.STORE_SETUP.FindBySTORENO(DsFrmPrintInvItem1.sales_transfer(i).store_from).STORENAME
        'Next
        If st = "2" Then
            GrdTransfer.RootTable.Columns(7).Caption = "Transfer To"
            GrdTransfer.RootTable.Columns(14).Caption = "Transfer By"
            GrdTransfer.RootTable.Columns(4).Caption = "Unit Cost"
            GrdTransfer.RootTable.Columns(6).Caption = "Ext. Cost"
            GrdTransfer.RootTable.Columns(4).DataMember = "unit_cost"
        End If
        GrdTransfer.BringToFront()

        GridEXPrintDocument1.GridEX = GrdTransfer
    End Sub
    Private Sub FillSales_TransferSummery(ByVal st As String)
        DAGeneral.SelectCommand.CommandText = "SELECT  inv_salse_transfer_head.store_from AS store_no, inv_salse_transfer_head.date_action AS date, inv_tab_type_item.desc_item_type AS type, " & _
          " SUM(ISNULL(inv_sales_transfer_dtl.qty, 0)) AS qty, SUM(ISNULL(inv_sales_transfer_dtl.fet, 0)) AS fet, SUM(ISNULL(inv_sales_transfer_dtl.qty, 0)  " & _
          " * (ISNULL(inv_sales_transfer_dtl.price, 0) + ISNULL(inv_sales_transfer_dtl.fet, 0))) AS ext_price, SUM(ISNULL(inv_sales_transfer_dtl.price, 0))  " & _
          " AS unit_cost, 1 AS flag " & _
          " FROM         inv_item INNER JOIN " & _
          " inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN " & _
          " inv_tab_style ON inv_tab_line.style = inv_tab_style.style INNER JOIN " & _
          " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " & _
          " inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN " & _
          " inv_sales_transfer_dtl ON inv_item.item_no = inv_sales_transfer_dtl.item_no INNER JOIN " & _
          " inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer " & _
          " WHERE      (inv_salse_transfer_head.type_sales_transfer = " & Qt(st) & ")" & _
            IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "") & IIf(Date1 = "", "", " and dbo.ChangeDate(inv_salse_transfer_head.date_action) between " & Qt(Date1) & " and " & Qt(Date2)) & _
         " GROUP BY inv_salse_transfer_head.date_action, inv_tab_type_item.desc_item_type, inv_salse_transfer_head.store_from "

        DAGeneral.Fill(DsFrmPrintInvItem1.summery)

        GrdSummery.RootTable.Columns.RemoveAt(6)
        GrdSummery.BringToFront()

        GridEXPrintDocument1.GridEX = GrdSummery

    End Sub




    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case TypeForm
            Case KindForm.SoldDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.SoldReport.Count - 1
                    DsFrmPrintInvItem1.SoldReport(i).flag = True
                Next
            Case KindForm.ReturnDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = True
                Next
            Case KindForm.RecieveDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = True
                Next
            Case KindForm.AdjDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = True
                Next
            Case KindForm.OrderDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = True
                Next
            Case KindForm.Ledger
                For i As Integer = 0 To DsFrmPrintInvItem1.BiginQty.Count - 1
                    DsFrmPrintInvItem1.BiginQty(i).flag = True
                Next
            Case KindForm.InterSaleDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.sales_transfer.Count - 1
                    DsFrmPrintInvItem1.sales_transfer(i).flag = True
                Next
            Case KindForm.TransferDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.sales_transfer.Count - 1
                    DsFrmPrintInvItem1.sales_transfer(i).flag = True
                Next
            Case Else
                For i As Integer = 0 To DsFrmPrintInvItem1.summery.Count - 1
                    DsFrmPrintInvItem1.summery(i).flag = True
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
            Case KindForm.SoldDetail
                Call GridToExcel2(FileName, GrdSoldDetail)
            Case KindForm.ReturnDetail
                'Me.Gr.ShowFieldChooser(Me)
            Case KindForm.RecieveDetail
                Call GridToExcel2(FileName, GrdDetail)
            Case KindForm.AdjDetail
                Call GridToExcel2(FileName, GrdDetail)
            Case KindForm.OrderDetail
                Call GridToExcel2(FileName, GrdDetail)
            Case KindForm.Ledger
                Call GridToExcel2(FileName, GrdLedger)
            Case KindForm.InterSaleDetail
                Call GridToExcel2(FileName, GrdTransfer)
            Case KindForm.TransferDetail
                Call GridToExcel2(FileName, GrdTransfer)
            Case Else
                Call GridToExcel2(FileName, GrdSummery)
        End Select

    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click

        Select Case TypeForm
            Case KindForm.SoldDetail
                Me.GrdSoldDetail.ShowFieldChooser(Me)
            Case KindForm.ReturnDetail
                Me.GrdDetail.ShowFieldChooser(Me)
            Case KindForm.RecieveDetail
                Me.GrdDetail.ShowFieldChooser(Me)
            Case KindForm.AdjDetail
                Me.GrdDetail.ShowFieldChooser(Me)
            Case KindForm.OrderDetail
                Me.GrdDetail.ShowFieldChooser(Me)
            Case KindForm.Ledger
                Me.GrdLedger.ShowFieldChooser(Me)
            Case KindForm.InterSaleDetail
                Me.GrdTransfer.ShowFieldChooser(Me)
            Case KindForm.TransferDetail
                Me.GrdTransfer.ShowFieldChooser(Me)
            Case Else
                Me.GrdSummery.ShowFieldChooser(Me)

        End Select
    End Sub

    Private Sub BtnJprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        DsFrmPrintInvItem1.AcceptChanges()
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
            Case KindForm.SoldDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.SoldReport.Count - 1
                    DsFrmPrintInvItem1.SoldReport(i).flag = False
                Next
            Case KindForm.ReturnDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = False
                Next
            Case KindForm.RecieveDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = False
                Next
            Case KindForm.AdjDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = False
                Next
            Case KindForm.OrderDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.Detail.Count - 1
                    DsFrmPrintInvItem1.Detail(i).flag = False
                Next
            Case KindForm.Ledger
                For i As Integer = 0 To DsFrmPrintInvItem1.BiginQty.Count - 1
                    DsFrmPrintInvItem1.BiginQty(i).flag = False
                Next
            Case KindForm.InterSaleDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.sales_transfer.Count - 1
                    DsFrmPrintInvItem1.sales_transfer(i).flag = False
                Next
            Case KindForm.TransferDetail
                For i As Integer = 0 To DsFrmPrintInvItem1.sales_transfer.Count - 1
                    DsFrmPrintInvItem1.sales_transfer(i).flag = False
                Next
            Case Else
                For i As Integer = 0 To DsFrmPrintInvItem1.summery.Count - 1
                    DsFrmPrintInvItem1.summery(i).flag = False
                Next

        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Select Case TypeForm
            Case KindForm.SoldDetail
                Call pprint1("print")
            Case KindForm.ReturnDetail
                Call pprint2("print")
            Case KindForm.RecieveDetail
                Call pprint2("print")
            Case KindForm.AdjDetail
                Call pprint2("print")
            Case KindForm.OrderDetail
                Call pprint2("print")
            Case KindForm.Ledger
                Call pprint3("print")
            Case KindForm.TransferDetail, KindForm.InterSaleDetail
                Call pprint5("print")
            Case Else
                Call pprint4("priv")

        End Select

    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click

        Select Case TypeForm
            Case KindForm.SoldDetail
                Call pprint1("priv")
            Case KindForm.ReturnDetail
                Call pprint2("priv")
            Case KindForm.RecieveDetail
                Call pprint2("priv")
            Case KindForm.AdjDetail
                Call pprint2("priv")
            Case KindForm.OrderDetail
                Call pprint2("priv")
            Case KindForm.Ledger
                Call pprint3("priv")
            Case KindForm.TransferDetail, KindForm.InterSaleDetail
                Call pprint5("priv")
            Case Else
                Call pprint4("priv")
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


        rpt.SetDataSource(DsFrmPrintInvItem1)
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
        Select Case TypeForm
            Case KindForm.AdjDetail
                rpt.SetParameterValue("ParVendorExplan", "Explanation")
            Case Else
                rpt.SetParameterValue("ParVendorExplan", "Vendor")
        End Select

        rpt.SetParameterValue("Fromtodate", IIf(FlagDate, fromtodate, ""))
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("ParStore", OleDbReaderForStore.Item("STORENAME") & "")

        rpt.SetParameterValue("Parrepname", Me.Text)

        rpt.SetParameterValue("Parfilter", StrFilter)



        rpt.SetDataSource(DsFrmPrintInvItem1)
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

        Dim rpt As New RepLedgerDetail2
        Dim prn As New FrmRepView


        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))


        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrintInvItem1)
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

        Dim rpt As New RepSummery
        Dim prn As New FrmRepView

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        Select Case TypeForm
            Case KindForm.SoldSummery
                rpt.SetParameterValue("ParTotalprice", "TotalPrice")
            Case Else
                rpt.SetParameterValue("ParTotalprice", "")
        End Select
        rpt.SetParameterValue("Fromtodate", IIf(FlagDate, fromtodate, ""))

        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)


        rpt.SetDataSource(DsFrmPrintInvItem1)
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

        Dim rpt As New RepTransfer
        Dim prn As New FrmRepView
        rpt.SetParameterValue("Fromtodate", IIf(FlagDate, fromtodate, ""))
        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        If TypeForm = KindForm.TransferDetail Then
            rpt.SetParameterValue("ParKind", "T")
        ElseIf TypeForm = KindForm.InterSaleDetail Then
            rpt.SetParameterValue("ParKind", "S")
        End If


        rpt.SetDataSource(DsFrmPrintInvItem1)
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
                Case "IR"
                    Dim MyFrmReceiveReturnProduct As New UcReceiveReturnProduct.FrmReceiveReturnProduct
                    MyFrmReceiveReturnProduct.ShowPnlHead = False
                    MyFrmReceiveReturnProduct.CodReceiveReturnProduct = Currentrow.Cells("RefNo").Value & ""
                    MyFrmReceiveReturnProduct.BillCredit = Currentrow.Cells("bill_credit").Value & ""
                    MyFrmReceiveReturnProduct.ShowDialog()
                Case "IA"
                    Dim MyFrmInventoryAdjustment As New UCInv_Item.FrmInventoryAdjustment
                    MyFrmInventoryAdjustment.ShowPnlHead = False
                    MyFrmInventoryAdjustment.CodInventoryAdjustment = Currentrow.Cells("RefNo").Value & ""
                    MyFrmInventoryAdjustment.ShowDialog()
                Case "IT"
                    Dim MyFrmInterStoreSale As New UcInterStoreSale.FrmInterStoreSale
                    MyFrmInterStoreSale.ShowPnlHead = False
                    MyFrmInterStoreSale.TypeOfForm = Currentrow.Cells("bill_credit").Value & ""
                    MyFrmInterStoreSale.CodInterStoreSale = Currentrow.Cells("RefNo").Value & ""
                    MyFrmInterStoreSale.ShowDialog()
                Case "PO"
                    Dim MyFrmPurchaseOrder As New UcPurchaseOrder.FrmPurchaseOrder
                    MyFrmPurchaseOrder.ShowPnlHead = False
                    MyFrmPurchaseOrder.CodPurchaseOrder = Currentrow.Cells("RefNo").Value & ""
                    MyFrmPurchaseOrder.ShowDialog()
                Case Else
                    Exit Sub
            End Select

        End If
    End Sub

    Private Sub GrdLedger_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdLedger.DoubleClick
        Try
            If GrdLedger.RowCount > 0 Then
                Dim Currentrow As GridEXRow = GrdLedger.GetRow

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
                    Case "IR"
                        Dim MyFrmReceiveReturnProduct As New UcReceiveReturnProduct.FrmReceiveReturnProduct
                        MyFrmReceiveReturnProduct.ShowPnlHead = False
                        MyFrmReceiveReturnProduct.CodReceiveReturnProduct = Currentrow.Cells("RefNo").Value & ""
                        MyFrmReceiveReturnProduct.BillCredit = Currentrow.Cells("bill_credit").Value & ""
                        MyFrmReceiveReturnProduct.ShowDialog()
                    Case "IA"
                        Dim MyFrmInventoryAdjustment As New UCInv_Item.FrmInventoryAdjustment
                        MyFrmInventoryAdjustment.ShowPnlHead = False
                        MyFrmInventoryAdjustment.CodInventoryAdjustment = Currentrow.Cells("RefNo").Value & ""
                        MyFrmInventoryAdjustment.ShowDialog()
                    Case "IT"
                        Dim MyFrmInterStoreSale As New UcInterStoreSale.FrmInterStoreSale
                        MyFrmInterStoreSale.ShowPnlHead = False
                        MyFrmInterStoreSale.TypeOfForm = Currentrow.Cells("bill_credit").Value & ""
                        MyFrmInterStoreSale.CodInterStoreSale = Currentrow.Cells("RefNo").Value & ""
                        MyFrmInterStoreSale.ShowDialog()
                    Case "PO"
                        Dim MyFrmPurchaseOrder As New UcPurchaseOrder.FrmPurchaseOrder
                        MyFrmPurchaseOrder.ShowPnlHead = False
                        MyFrmPurchaseOrder.CodPurchaseOrder = Currentrow.Cells("RefNo").Value & ""
                        MyFrmPurchaseOrder.ShowDialog()
                    Case Else
                        Exit Sub
                End Select

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GrdSoldDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdSoldDetail.DoubleClick
        If GrdSoldDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdSoldDetail.GetRow

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


    'Private Sub GrdLedger_GroupsChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GroupsChangedEventArgs) Handles GrdLedger.GroupsChanged
    '    Dim i As Integer = GrdLedger.RootTable.Groups.Count
    '    For j As Integer = 0 To i - 1
    '        If GrdLedger.RootTable.Groups(j).HeaderCaption = "Item" Then
    '            GrdLedger.RootTable.Columns(5).Visible = False
    '            Exit Sub
    '        End If
    '    Next
    '    GrdLedger.RootTable.Columns(5).Visible = True

    'End Sub



    Private Sub CmbChildLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChildLedger.Click
        If CmbChildLedger.Text = "Expand" Then
            CmbChildLedger.Text = "Collaps"
            GrdLedger.ExpandRecords(GrdLedger.RootTable.ChildTables(0))
        Else
            CmbChildLedger.Text = "Expand"
            GrdLedger.CollapseRecords(GrdLedger.RootTable.ChildTables(0))
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
