Imports CommonClass
Public Class FrmItemHistory
    Inherits CommonClass.FrmBase
    Public item As String
    Public Desc As String
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GrdLedger As Janus.Windows.GridEX.GridEX
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel

    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RdoAdj As System.Windows.Forms.RadioButton
    Friend WithEvents RdoRec As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSale As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAll As System.Windows.Forms.RadioButton

    Friend WithEvents TxtDesc As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents DsFrmItemHistory1 As UCInv_Item.DSFrmItemHistory
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmItemHistory))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GrdLedger = New Janus.Windows.GridEX.GridEX
        Me.DsFrmItemHistory1 = New UCInv_Item.DSFrmItemHistory
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.TxtItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtDesc = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RdoAdj = New System.Windows.Forms.RadioButton
        Me.RdoRec = New System.Windows.Forms.RadioButton
        Me.RdoSale = New System.Windows.Forms.RadioButton
        Me.RdoAll = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX
        Me.Panel4.SuspendLayout()
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmItemHistory1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSearch.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item.item_no, inv_item.desc_item, inv_adjustment_dtl.referID_adjustmen" & _
        "t AS refno, inv_adjustment_head.date_adjustment AS date, CASE WHEN isnull(inv_ad" & _
        "justment_dtl.QTY, 0) > 0 THEN isnull(inv_adjustment_dtl.QTY, 0) ELSE 0 END AS qt" & _
        "yin, CASE WHEN isnull(inv_adjustment_dtl.QTY, 0) < 0 THEN - (isnull(inv_adjustme" & _
        "nt_dtl.QTY, 0)) ELSE 0 END AS qtyout, '' AS customer, 1 AS flag, '' AS vendor, '" & _
        "' AS bill_credit, 0 AS Begining FROM inv_item INNER JOIN inv_adjustment_dtl ON i" & _
        "nv_item.item_no = inv_adjustment_dtl.item_no INNER JOIN inv_adjustment_head ON i" & _
        "nv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR_H;packet size=4096;user id=sa;data source=ARYAFAR_H;persis" & _
        "t security info=False;initial catalog=TireMate_01"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(624, 40)
        Me.Panel4.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Click on the buttons below to view related transaction"
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
        Me.PictureBox2.Size = New System.Drawing.Size(64, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'GrdLedger
        '
        Me.GrdLedger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLedger.DataSource = Me.DsFrmItemHistory1.Ledger
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""refno""><Capt" & _
        "ion>Ref. No</Caption><DataMember>refno</DataMember><Key>refno</Key><Position>0</" & _
        "Position></Column0><Column1 ID=""date""><AllowSort>False</AllowSort><Caption>Date<" & _
        "/Caption><DataMember>date</DataMember><EditType>NoEdit</EditType><Key>date</Key>" & _
        "<Position>1</Position></Column1><Column2 ID=""qtyout""><AggregateFunction>Sum</Agg" & _
        "regateFunction><Caption>Qty Out</Caption><DataMember>qtyout</DataMember><EditTyp" & _
        "e>NoEdit</EditType><Key>qtyout</Key><Position>2</Position><TextAlignment>Far</Te" & _
        "xtAlignment></Column2><Column3 ID=""qtyin""><AggregateFunction>Sum</AggregateFunct" & _
        "ion><Caption>Qty In</Caption><DataMember>qtyin</DataMember><EditType>NoEdit</Edi" & _
        "tType><Key>qtyin</Key><Position>3</Position><TextAlignment>Far</TextAlignment></" & _
        "Column3><Column4 ID=""customer""><Caption>Customer</Caption><DataMember>customer</" & _
        "DataMember><EditType>NoEdit</EditType><Key>customer</Key><Position>4</Position><" & _
        "/Column4><Column5 ID=""vendor""><Caption>Vendor</Caption><DataMember>vendor</DataM" & _
        "ember><EditType>NoEdit</EditType><Key>vendor</Key><Position>5</Position></Column" & _
        "5><Column6 ID=""OrderDate""><Caption>OrderDate</Caption><DataMember>OrderDate</Dat" & _
        "aMember><Key>OrderDate</Key><Position>6</Position><Visible>False</Visible></Colu" & _
        "mn6></Columns><DataMember>BiginQty</DataMember><GroupCondition ID="""" /><SortKeys" & _
        " Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>6</ColIndex></SortKey0></So" & _
        "rtKeys></RootTable></GridEXLayoutData>"
        Me.GrdLedger.DesignTimeLayout = GridEXLayout1
        Me.GrdLedger.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdLedger.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdLedger.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdLedger.Hierarchical = True
        Me.GrdLedger.Location = New System.Drawing.Point(0, 173)
        Me.GrdLedger.Name = "GrdLedger"
        Me.GrdLedger.RowWithErrorsFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GrdLedger.Size = New System.Drawing.Size(626, 323)
        Me.GrdLedger.TabIndex = 19
        Me.GrdLedger.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmItemHistory1
        '
        Me.DsFrmItemHistory1.DataSetName = "DSFrmItemHistory"
        Me.DsFrmItemHistory1.Locale = New System.Globalization.CultureInfo("en-GB")
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.TxtItem)
        Me.PnlSearch.Controls.Add(Me.TxtDesc)
        Me.PnlSearch.Controls.Add(Me.Label10)
        Me.PnlSearch.Controls.Add(Me.Label2)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.ForeColor = System.Drawing.Color.Black
        Me.PnlSearch.Location = New System.Drawing.Point(0, 96)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(624, 40)
        Me.PnlSearch.TabIndex = 17
        '
        'TxtItem
        '
        Me.TxtItem.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtItem.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtItem.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtItem.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtItem.Enabled = False
        Me.TxtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtItem.IncludeLiterals = False
        Me.TxtItem.Location = New System.Drawing.Point(64, 8)
        Me.TxtItem.MaxLength = 15
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtItem.ReadOnly = True
        Me.TxtItem.Size = New System.Drawing.Size(96, 22)
        Me.TxtItem.TabIndex = 62
        Me.TxtItem.TabStop = False
        Me.TxtItem.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtDesc
        '
        Me.TxtDesc.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtDesc.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtDesc.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtDesc.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDesc.Enabled = False
        Me.TxtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDesc.IncludeLiterals = False
        Me.TxtDesc.Location = New System.Drawing.Point(248, 8)
        Me.TxtDesc.MaxLength = 15
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtDesc.ReadOnly = True
        Me.TxtDesc.Size = New System.Drawing.Size(368, 22)
        Me.TxtDesc.TabIndex = 61
        Me.TxtDesc.TabStop = False
        Me.TxtDesc.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(176, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 23)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Description"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Item No"
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RdoAdj)
        Me.Panel1.Controls.Add(Me.RdoRec)
        Me.Panel1.Controls.Add(Me.RdoSale)
        Me.Panel1.Controls.Add(Me.RdoAll)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 56)
        Me.Panel1.TabIndex = 18
        '
        'RdoAdj
        '
        Me.RdoAdj.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdoAdj.Location = New System.Drawing.Point(488, 16)
        Me.RdoAdj.Name = "RdoAdj"
        Me.RdoAdj.TabIndex = 3
        Me.RdoAdj.Text = "Adjustments"
        Me.RdoAdj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RdoRec
        '
        Me.RdoRec.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdoRec.Location = New System.Drawing.Point(336, 16)
        Me.RdoRec.Name = "RdoRec"
        Me.RdoRec.TabIndex = 2
        Me.RdoRec.Text = "Receipts/Returns"
        Me.RdoRec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RdoSale
        '
        Me.RdoSale.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdoSale.Location = New System.Drawing.Point(184, 16)
        Me.RdoSale.Name = "RdoSale"
        Me.RdoSale.TabIndex = 1
        Me.RdoSale.Text = "Sales / Returns"
        Me.RdoSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RdoAll
        '
        Me.RdoAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdoAll.Location = New System.Drawing.Point(32, 16)
        Me.RdoAll.Name = "RdoAll"
        Me.RdoAll.TabIndex = 0
        Me.RdoAll.Text = "All Transactions"
        Me.RdoAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridEX2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 37)
        Me.Panel2.TabIndex = 20
        '
        'GridEX2
        '
        Me.GridEX2.DataSource = Me.DsFrmItemHistory1.BiginQty
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""BeginingQty""" & _
        "><Caption>Begin Qty</Caption><DataMember>BeginingQty</DataMember><EditType>NoEdi" & _
        "t</EditType><Key>BeginingQty</Key><Position>0</Position></Column0><Column1 ID=""Q" & _
        "tyOut""><Caption>Qty Out</Caption><DataMember>QtyOut</DataMember><EditType>NoEdit" & _
        "</EditType><Key>QtyOut</Key><Position>1</Position></Column1><Column2 ID=""QtyIn"">" & _
        "<Caption>Qty In</Caption><DataMember>QtyIn</DataMember><EditType>NoEdit</EditTyp" & _
        "e><Key>QtyIn</Key><Position>2</Position></Column2><Column3 ID=""OnHand""><Caption>" & _
        "On Hand</Caption><DataMember>OnHand</DataMember><EditType>NoEdit</EditType><Key>" & _
        "OnHand</Key><Position>3</Position></Column3></Columns><GroupCondition ID="""" /></" & _
        "RootTable></GridEXLayoutData>"
        Me.GridEX2.DesignTimeLayout = GridEXLayout2
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.Location = New System.Drawing.Point(0, 0)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.Size = New System.Drawing.Size(408, 56)
        Me.GridEX2.TabIndex = 1
        '
        'FrmItemHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 492)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdLedger)
        Me.Name = "FrmItemHistory"
        Me.Text = "Item History"
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmItemHistory1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSearch.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim FlagFill As Boolean = False
    Private Sub FrmItemHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cnn.ConnectionString = PConnectionString
        TxtItem.Text = item
        TxtDesc.Text = Desc

    End Sub
    Private Sub FillDataset()

        DAGeneral.SelectCommand.CommandText = " SELECT     dbo.inv_tab_item_warehouse.item_no, dbo.inv_tab_item_warehouse.Begining_Balance_Qty AS BeginingQty , 1 as flag,inv_item.desc_item " & _
                              " , dbo.inv_tab_type_item.desc_item_type ,dbo.inv_tab_line.line,    dbo.inv_tab_brand.complete_desc_brand, dbo.inv_tab_style.desc_style, 0 AS store_no " & _
                             " FROM         dbo.inv_item INNER JOIN " & _
                             " dbo.inv_tab_line ON dbo.inv_item.line = dbo.inv_tab_line.line INNER JOIN " & _
                             " dbo.inv_tab_style ON dbo.inv_tab_line.style = dbo.inv_tab_style.style INNER JOIN " & _
                             " dbo.inv_tab_brand ON dbo.inv_tab_line.cod_brand = dbo.inv_tab_brand.cod_brand INNER JOIN " & _
                             " dbo.inv_tab_type_item ON dbo.inv_item.cod_item_type = dbo.inv_tab_type_item.cod_item_type INNER JOIN " & _
                             " dbo.inv_tab_item_warehouse ON dbo.inv_item.item_no = dbo.inv_tab_item_warehouse.item_no " & _
                  " where inv_item.item_no = " & Qt(item)

        Try
            DAGeneral.Fill(DsFrmItemHistory1.BiginQty)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item,inv_adjustment_dtl.referID_adjustment AS refno, inv_adjustment_head.date_adjustment AS date, " & _
                 "  CASE WHEN isnull(inv_adjustment_dtl.QTY, 0)> 0 THEN isnull(inv_adjustment_dtl.QTY, 0) else 0 END AS qtyin, CASE WHEN isnull(inv_adjustment_dtl.QTY, 0) < 0 THEN - (isnull(inv_adjustment_dtl.QTY,0)) else 0 END AS qtyout " & _
                 " ,'' as customer, 1 AS flag,'' as vendor,'' as bill_credit,0 as Begining ,dbo.ChangeDate(inv_adjustment_head.date_adjustment) as OrderDate ,'3' as kind " & _
                 " FROM         inv_item INNER JOIN " & _
                 " inv_adjustment_dtl ON inv_item.item_no = inv_adjustment_dtl.item_no INNER JOIN " & _
                 " inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment " & _
                " Where  inv_item.item_no = " & Qt(item)

        Try
            DAGeneral.Fill(DsFrmItemHistory1.Ledger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'For i = 0 To DsFrmItemHistory1.Ledger.Rows.Count - 1
        '    If DsFrmItemHistory1.Ledger(i).qtyin < 0 Then
        '        DsFrmItemHistory1.Ledger(i).qtyout = -(DsFrmItemHistory1.Ledger(i).qtyin)
        '        DsFrmItemHistory1.Ledger(i).qtyin = 0
        '    End If
        'Next

        DsFrmItemHistory1.Ledger.AcceptChanges()

        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, service_center_dtl.id_service_center as refno,service_center_head.date_refer as date,isnull(service_center_dtl.qty,0) as qtyout," & _
                             " service_center_head.cod_customer as customer, 1 AS flag,dbo.ChangeDate(service_center_head.date_refer ) as OrderDate ,'1' as kind  " & _
                       " FROM         service_center_dtl INNER JOIN " & _
                             " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                             " inv_item  ON service_center_dtl.cod_select = inv_item.item_no  " & _
                        "WHERE     (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A')  and inv_item.item_no = " & Qt(item)

        Try
            DAGeneral.Fill(DsFrmItemHistory1.Ledger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item, Inv_Receive_product_dtl.id_receive_ref AS RefNo,Inv_Receive_Products_head.date_receive AS date, isnull(Inv_Receive_product_dtl.qty,0) AS qtyin ,0 as qtyout," & _
                          " Inv_Receive_Products_head.cod_vendor AS vendor , 1 AS flag,Inv_Receive_Products_head.bill_credit,dbo.ChangeDate(Inv_Receive_Products_head.date_receive ) as OrderDate ,'2' as kind  " & _
                       " FROM         inv_item INNER JOIN " & _
                            " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                            " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                            " where Inv_Receive_Products_head.bill_credit ='1' and  inv_item.item_no = " & Qt(item)



        Try
            DAGeneral.Fill(DsFrmItemHistory1.Ledger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DAGeneral.SelectCommand.CommandText = "SELECT     inv_item.item_no, inv_item.desc_item, Inv_Receive_product_dtl.id_receive_ref AS RefNo,  " & _
                    " Inv_Receive_Products_head.date_receive AS date,0 as qtyin, isnull(Inv_Receive_product_dtl.qty,0) AS qtyout, " & _
                  " Inv_Receive_Products_head.cod_vendor AS vendor , 1 AS flag,Inv_Receive_Products_head.bill_credit ,dbo.ChangeDate(Inv_Receive_Products_head.date_receive ) as OrderDate ,'2' as kind  " & _
               " FROM         inv_item INNER JOIN " & _
                    " Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no INNER JOIN " & _
                    " Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                    " where Inv_Receive_Products_head.bill_credit ='2' and  inv_item.item_no = " & Qt(item)


        DAGeneral.Fill(DsFrmItemHistory1.Ledger)


        DAGeneral.SelectCommand.CommandText = " SELECT     inv_item.item_no, inv_item.desc_item,service_center_dtl.id_service_center AS RefNo, service_center_head.date_refer AS date, -(isnull(service_center_dtl.qty,0)) AS qtyin,0 as qtyout, " & _
         " service_center_head.cod_customer as customer , 1 AS flag,dbo.ChangeDate(service_center_head.date_refer ) as OrderDate ,'1' as kind  " & _
                      " FROM         service_center_head INNER JOIN " & _
                      " service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center INNER JOIN " & _
                      " inv_item  ON service_center_dtl.cod_select = inv_item.item_no " & _
                      " WHERE     (service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select = 'I' or service_center_dtl.type_select = 'A') and  inv_item.item_no = " & Qt(item)

        Try
            DAGeneral.Fill(DsFrmItemHistory1.Ledger)
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

        'DAGeneral.Fill(DsFrmItemHistory1.Ledger)

        DAGeneral.SelectCommand.CommandText = " SELECT     inv_sales_transfer_dtl.item_no, inv_item.desc_item, inv_sales_transfer_dtl.ID_sales_transfer AS RefNo, inv_salse_transfer_head.date_action as date , 1 AS flag, " & _
                      " 0 as qtyin,inv_sales_transfer_dtl.qty AS qtyout,type_sales_transfer as bill_credit,dbo.ChangeDate( inv_salse_transfer_head.date_action ) as OrderDate ,'' as kind  " & _
                      " FROM         inv_salse_transfer_head INNER JOIN " & _
                      " inv_sales_transfer_dtl ON inv_salse_transfer_head.ID_sales_transfer = inv_sales_transfer_dtl.ID_sales_transfer INNER JOIN " & _
                      " inv_item ON inv_sales_transfer_dtl.item_no = inv_item.item_no " & _
                        " Where  inv_item.item_no = " & Qt(item)

        DAGeneral.Fill(DsFrmItemHistory1.Ledger)
        ''''********************


        'Dim dr() As DataRow
        Dim j As Integer
        If DsFrmItemHistory1.Ledger.Count = 0 Then
            DsFrmItemHistory1.BiginQty(0).QtyIn = 0
            DsFrmItemHistory1.BiginQty(0).QtyOut = 0
            DsFrmItemHistory1.BiginQty(0).OnHand = DsFrmItemHistory1.BiginQty(0).BeginingQty
        Else

            'For i As Integer = 0 To DsFrmItemHistory1.BiginQty.Count - 1
            '    dr = DsFrmItemHistory1.Ledger.Select("item_no =" & Qt(DsFrmItemHistory1.BiginQty(i).item_no))
            '    If dr.Length > 0 Then
            '        DsFrmItemHistory1.BiginQty(i).flagshow = True
            '    Else
            '        DsFrmItemHistory1.BiginQty(i).flagshow = False
            '    End If
            For j = 0 To DsFrmItemHistory1.Ledger.Count - 1
                DsFrmItemHistory1.BiginQty(0).QtyIn = DsFrmItemHistory1.BiginQty(0).QtyIn + IIf(DsFrmItemHistory1.Ledger(j).Item("qtyin") Is DBNull.Value, 0, DsFrmItemHistory1.Ledger(j).Item("qtyin"))
                DsFrmItemHistory1.BiginQty(0).QtyOut = DsFrmItemHistory1.BiginQty(0).QtyOut + IIf(DsFrmItemHistory1.Ledger(j).Item("qtyout") Is DBNull.Value, 0, DsFrmItemHistory1.Ledger(j).Item("qtyout"))
            Next
            DsFrmItemHistory1.BiginQty(0).OnHand = DsFrmItemHistory1.BiginQty(0).BeginingQty + DsFrmItemHistory1.BiginQty(0).QtyIn - DsFrmItemHistory1.BiginQty(0).QtyOut
            '    DsFrmItemHistory1.BiginQty(i).store_no = PubStoreNO
            'Next

        End If





        GrdLedger.BringToFront()
        'GridEXPrintDocument1.GridEX = GrdLedger
        'GridEXPrintDocument1.PrintHierarchical = True

        FlagFill = True
    End Sub

    Private Sub RdoAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAll.CheckedChanged, RdoRec.CheckedChanged, RdoSale.CheckedChanged, RdoAdj.CheckedChanged
        If Not FlagFill Then
            FillDataset()
        End If

        If RdoAll.Checked Then
            DsFrmItemHistory1.Ledger.DefaultView.RowFilter = " "
            GrdLedger.SetDataBinding(DsFrmItemHistory1.Ledger.DefaultView, "")
        End If
        If RdoSale.Checked Then

            DsFrmItemHistory1.Ledger.DefaultView.RowFilter = "  kind='1' "
            GrdLedger.SetDataBinding(DsFrmItemHistory1.Ledger.DefaultView, "")
        End If
        If RdoRec.Checked Then

            DsFrmItemHistory1.Ledger.DefaultView.RowFilter = "  kind='2' "
            GrdLedger.SetDataBinding(DsFrmItemHistory1.Ledger.DefaultView, "")
        End If
        If RdoAdj.Checked Then

            DsFrmItemHistory1.Ledger.DefaultView.RowFilter = "  kind='3' "
            GrdLedger.SetDataBinding(DsFrmItemHistory1.Ledger.DefaultView, "")
        End If
    End Sub
End Class
