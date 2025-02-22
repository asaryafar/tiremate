Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDaySalesReport
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
    Friend WithEvents DsFrmEndOfDaySalesReport1 As UCBankAccount.DSFrmEndOfDaySalesReport
    Friend WithEvents DAservice_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_center_dtlOld As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDaySalesReport))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.DsFrmEndOfDaySalesReport1 = New UCBankAccount.DSFrmEndOfDaySalesReport
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
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_dtlOld = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsFrmEndOfDaySalesReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsFrmEndOfDaySalesReport1
        '
        Me.DsFrmEndOfDaySalesReport1.DataSetName = "DSFrmEndOfDaySalesReport"
        Me.DsFrmEndOfDaySalesReport1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        'DAservice_center_dtl
        '
        Me.DAservice_center_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, ser" & _
        "vice_center_head.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_" & _
        "name + ' ' + cust_trtab_main.l_name AS fullname, cust_company.abbreviation_name," & _
        " service_center_head.tax, View_Invoice_SubTotal.Subtotal * service_center_head.d" & _
        "iscount / 100 AS Discount, service_center_head.Total, 1 AS flag, View_Invoice_Su" & _
        "bTotal.Subtotal, ROUND(ISNULL(View_Invoice_SubTotal.Subtotal, 0) - ISNULL(View_I" & _
        "nvoice_SubTotal.Subtotal * service_center_head.discount / 100, 0) - ISNULL(View_" & _
        "Sum_Of_I_AND_O_ReplacementCost.ReplacementCost, 0), 2) AS GrProfAmount, CASE isn" & _
        "ull(View_Invoice_SubTotal.Subtotal, 0) WHEN 0 THEN 0 ELSE round(((ISNULL(View_In" & _
        "voice_SubTotal.Subtotal, 0) - ISNULL(View_Invoice_SubTotal.Subtotal * service_ce" & _
        "nter_head.discount / 100, 0) - ISNULL(View_Sum_Of_I_AND_O_ReplacementCost.Replac" & _
        "ementCost, 0)) / (ISNULL(View_Invoice_SubTotal.Subtotal, 0) - ISNULL(View_Invoic" & _
        "e_SubTotal.Subtotal * service_center_head.discount / 100, 0))) * 100, 2) END AS " & _
        "GrProfPercent, View_Sum_Of_I_AND_O_ReplacementCost.ReplacementCost AS cost FROM " & _
        "service_center_head LEFT OUTER JOIN View_Sum_Of_I_AND_O_ReplacementCost ON servi" & _
        "ce_center_head.id_service_center = View_Sum_Of_I_AND_O_ReplacementCost.id_servic" & _
        "e_center LEFT OUTER JOIN View_Invoice_SubTotal ON service_center_head.id_service" & _
        "_center = View_Invoice_SubTotal.id_service_center LEFT OUTER JOIN cust_trtab_mai" & _
        "n ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER " & _
        "JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDaySalesReport1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""flag""><Caption>flag</Caption><ColumnType>CheckBox</Colu" & _
        "mnType><DataMember>flag</DataMember><EditType>CheckBox</EditType><Key>flag</Key>" & _
        "<Position>0</Position><Visible>False</Visible></Column0><Column1 ID=""id_service_" & _
        "center""><Caption>Ref. No</Caption><TypeNameEmptyStringValue>System.String</TypeN" & _
        "ameEmptyStringValue><EmptyStringValue /><DataMember>id_service_center</DataMembe" & _
        "r><Key>id_service_center</Key><Position>1</Position><Width>60</Width></Column1><" & _
        "Column2 ID=""date_refer""><Caption>Date</Caption><DataMember>date_refer</DataMembe" & _
        "r><Key>date_refer</Key><Position>2</Position><Width>68</Width></Column2><Column3" & _
        " ID=""cod_customer""><Caption>Customer</Caption><DataMember>cod_customer</DataMemb" & _
        "er><Key>cod_customer</Key><Position>3</Position><Width>64</Width></Column3><Colu" & _
        "mn4 ID=""fullname""><Caption>Name</Caption><DataMember>fullname</DataMember><Key>f" & _
        "ullname</Key><Position>4</Position><Width>127</Width></Column4><Column5 ID=""abbr" & _
        "eviation_name""><Caption>Company</Caption><DataMember>abbreviation_name</DataMemb" & _
        "er><Key>abbreviation_name</Key><Position>5</Position><Width>141</Width></Column5" & _
        "><Column6 ID=""SUBTOTAL""><AggregateFunction>Sum</AggregateFunction><Caption>Subto" & _
        "tal</Caption><DataMember>SUBTOTAL</DataMember><FormatString>c2</FormatString><Ke" & _
        "y>SUBTOTAL</Key><Position>6</Position><Width>74</Width><TotalFormatString>c2</To" & _
        "talFormatString></Column6><Column7 ID=""tax""><AggregateFunction>Sum</AggregateFun" & _
        "ction><Caption>Tax</Caption><DataMember>tax</DataMember><FormatString>c2</Format" & _
        "String><Key>tax</Key><Position>7</Position><Width>62</Width><TotalFormatString>c" & _
        "2</TotalFormatString></Column7><Column8 ID=""discount""><AggregateFunction>Sum</Ag" & _
        "gregateFunction><Caption>Discount</Caption><DataMember>discount</DataMember><For" & _
        "matString>c2</FormatString><Key>discount</Key><Position>8</Position><Width>57</W" & _
        "idth><TotalFormatString>c2</TotalFormatString></Column8><Column9 ID=""Total""><Agg" & _
        "regateFunction>Sum</AggregateFunction><Caption>Total</Caption><DataMember>Total<" & _
        "/DataMember><FormatString>c2</FormatString><Key>Total</Key><Position>9</Position" & _
        "><Width>80</Width><TotalFormatString>c2</TotalFormatString></Column9><Column10 I" & _
        "D=""cost""><AggregateFunction>Sum</AggregateFunction><Caption>Cost</Caption><DataM" & _
        "ember>cost</DataMember><FormatString>c2</FormatString><Key>cost</Key><Position>1" & _
        "0</Position><Width>76</Width><TotalFormatString>c2</TotalFormatString></Column10" & _
        "><Column11 ID=""GrProfAmount""><AggregateFunction>Sum</AggregateFunction><Caption>" & _
        "Gr. Prof. $</Caption><DataMember>GrProfAmount</DataMember><FormatString>c2</Form" & _
        "atString><Key>GrProfAmount</Key><Position>11</Position><Width>66</Width><TotalFo" & _
        "rmatString>c2</TotalFormatString></Column11><Column12 ID=""GrProfPercent""><Captio" & _
        "n>Gr. Prof. %</Caption><DataMember>GrProfPercent</DataMember><FormatString>###.#" & _
        "#</FormatString><InputMask>Percent1</InputMask><Key>GrProfPercent</Key><MaskProm" & _
        "pt>&#x0;</MaskPrompt><Position>12</Position><Width>66</Width><TotalFormatString>" & _
        "###.##</TotalFormatString></Column12></Columns><GroupCondition ID="""" /><Key>serv" & _
        "ice_center_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 64)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(716, 340)
        Me.GridEX1.TabIndex = 5
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DAservice_center_dtlOld
        '
        Me.DAservice_center_dtlOld.SelectCommand = Me.SqlCommand1
        Me.DAservice_center_dtlOld.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, ser" & _
        "vice_center_head.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_" & _
        "name + ' ' + cust_trtab_main.l_name AS fullname, cust_company.abbreviation_name," & _
        " service_center_head.tax, View_Invoice_SubTotal.Subtotal * service_center_head.d" & _
        "iscount / 100 AS Discount, service_center_head.Total, View_Sum_Of_Invoice_Replac" & _
        "ementCost.ReplacementCost AS cost, 1 AS flag, View_Invoice_SubTotal.Subtotal, RO" & _
        "UND(ISNULL(View_Invoice_SubTotal.Subtotal, 0) - ISNULL(View_Invoice_SubTotal.Sub" & _
        "total * service_center_head.discount / 100, 0) - ISNULL(View_Sum_Of_Invoice_Repl" & _
        "acementCost.ReplacementCost, 0), 2) AS GrProfAmount, CASE isnull(View_Invoice_Su" & _
        "bTotal.Subtotal, 0) WHEN 0 THEN 0 ELSE round(((ISNULL(View_Invoice_SubTotal.Subt" & _
        "otal, 0) - ISNULL(View_Invoice_SubTotal.Subtotal * service_center_head.discount " & _
        "/ 100, 0) - ISNULL(View_Sum_Of_Invoice_ReplacementCost.ReplacementCost, 0)) / is" & _
        "null(View_Invoice_SubTotal.Subtotal, 0)) * 100, 2) END AS GrProfPercent FROM ser" & _
        "vice_center_head LEFT OUTER JOIN View_Invoice_SubTotal ON service_center_head.id" & _
        "_service_center = View_Invoice_SubTotal.id_service_center LEFT OUTER JOIN cust_t" & _
        "rtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEF" & _
        "T OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_comp" & _
        "any FULL OUTER JOIN View_Sum_Of_Invoice_ReplacementCost ON service_center_head.i" & _
        "d_service_center = View_Sum_Of_Invoice_ReplacementCost.id_service_center"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'FrmEndOfDaySalesReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(716, 404)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = True
        Me.Name = "FrmEndOfDaySalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "End Of Day Sales Report"
        CType(Me.DsFrmEndOfDaySalesReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_dtl.SelectCommand.CommandText = DAservice_center_dtl.SelectCommand.CommandText & " Where dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(FromDateVar)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(ToDateVar)) & " AND (service_center_head.type_of_form='IN' OR service_center_head.type_of_form='RT' ) AND (service_center_head.id_service_center not in (SELECT id_service_center FROM service_center_dtl WHERE (type_select = 'B')))"
        DAservice_center_dtl.Fill(DsFrmEndOfDaySalesReport1.service_center_dtl)
        'DsFrmEndOfDaySalesReport1.service_center_dtl.Columns("GrProfAmount").Expression = "(subtotal-discount-Cost)"
        'DsFrmEndOfDaySalesReport1.service_center_dtl.Columns("GrProfPercent").Expression = "((subtotal-discount-Cost)/subtotal)*100"

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
        For i As Integer = 0 To DsFrmEndOfDaySalesReport1.service_center_dtl.Count - 1
            DsFrmEndOfDaySalesReport1.service_center_dtl(i).flag = False
        Next
        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        For i As Integer = 0 To DsFrmEndOfDaySalesReport1.service_center_dtl.Count - 1
            DsFrmEndOfDaySalesReport1.service_center_dtl(i).flag = True
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
