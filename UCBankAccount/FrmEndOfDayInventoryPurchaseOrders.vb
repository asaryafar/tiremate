Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayInventoryPurchaseOrders
    Inherits FrmBase
    Public WhereClauseVar As String
    Public KindOfForm As Integer = 1
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_purchase_order_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayInventoryPurchaseOrders1 As UCBankAccount.DSFrmEndOfDayInventoryPurchaseOrders
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayInventoryPurchaseOrders))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayInventoryPurchaseOrders1 = New UCBankAccount.DSFrmEndOfDayInventoryPurchaseOrders
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_purchase_order_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayInventoryPurchaseOrders1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "Inv_purchase_order_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayInventoryPurchaseOrders1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Inv_purchase_order_dtl</Caption><Columns Co" & _
        "llection=""true""><Column0 ID=""po_no""><Caption>Reference No</Caption><TypeNameEmpt" & _
        "yStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMe" & _
        "mber>po_no</DataMember><Key>po_no</Key><Position>0</Position><Width>81</Width></" & _
        "Column0><Column1 ID=""item_no""><Caption>Item No.</Caption><TypeNameEmptyStringVal" & _
        "ue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>item_" & _
        "no</DataMember><Key>item_no</Key><Position>1</Position><Width>80</Width></Column" & _
        "1><Column2 ID=""desc_item""><Caption>Description</Caption><DataMember>desc_item</D" & _
        "ataMember><Key>desc_item</Key><Position>2</Position><Width>195</Width></Column2>" & _
        "<Column3 ID=""qty""><Caption>Qty Ord.</Caption><DataMember>qty</DataMember><Key>qt" & _
        "y</Key><Position>3</Position><TextAlignment>Center</TextAlignment><Width>52</Wid" & _
        "th></Column3><Column4 ID=""ReplCost""><Caption>Repl. Cost</Caption><DataMember>Rep" & _
        "lCost</DataMember><EditType>NoEdit</EditType><FormatString>c2</FormatString><Key" & _
        ">ReplCost</Key><Position>4</Position><Width>82</Width></Column4><Column5 ID=""fet" & _
        """><Caption>FET</Caption><DataMember>fet</DataMember><FormatString>c2</FormatStri" & _
        "ng><Key>fet</Key><Position>5</Position><Width>77</Width></Column5><Column6 ID=""E" & _
        "xtCost""><Caption>Ext. Cost</Caption><DataMember>ExtCost</DataMember><EditType>No" & _
        "Edit</EditType><FormatString>c2</FormatString><Key>ExtCost</Key><Position>6</Pos" & _
        "ition><Width>80</Width></Column6><Column7 ID=""cod_vendor""><Caption>Vendor</Capti" & _
        "on><DataMember>cod_vendor</DataMember><Key>cod_vendor</Key><Position>7</Position" & _
        "><TextAlignment>Center</TextAlignment><Width>47</Width></Column7></Columns><Grou" & _
        "pCondition ID="""" /><Key>Inv_purchase_order_dtl</Key></RootTable></GridEXLayoutDa" & _
        "ta>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 352)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayInventoryPurchaseOrders1
        '
        Me.DsFrmEndOfDayInventoryPurchaseOrders1.DataSetName = "DSFrmEndOfDayInventoryPurchaseOrders"
        Me.DsFrmEndOfDayInventoryPurchaseOrders1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Inv_purchase_order_dtl.po_no, Inv_purchase_order_dtl.item_no, Inv_purchase" & _
        "_order_dtl.qty, inv_item.desc_item, inv_item_cost_transaction.cost + inv_item_co" & _
        "st_transaction.delivery + inv_item_cost_transaction.frieght AS ReplCost, inv_ite" & _
        "m_cost_transaction.fet, Inv_purchase_order_head.cod_vendor, (Inv_purchase_order_" & _
        "dtl.fet + Inv_purchase_order_dtl.cost) * Inv_purchase_order_dtl.qty AS ExtCost F" & _
        "ROM Inv_purchase_order_dtl LEFT OUTER JOIN Inv_purchase_order_head ON Inv_purcha" & _
        "se_order_dtl.po_no = Inv_purchase_order_head.po_no LEFT OUTER JOIN inv_item ON I" & _
        "nv_purchase_order_dtl.item_no = inv_item.item_no LEFT OUTER JOIN inv_item_cost_t" & _
        "ransaction ON inv_item.item_no = inv_item_cost_transaction.item_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAInv_purchase_order_dtl
        '
        Me.DAInv_purchase_order_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAInv_purchase_order_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_purchase_order_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcPrintGrid1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(718, 45)
        Me.Panel4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 43)
        Me.Label1.TabIndex = 207
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
        Me.PictureBox2.Size = New System.Drawing.Size(64, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(513, 11)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
        '
        'FrmEndOfDayInventoryPurchaseOrders
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 397)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayInventoryPurchaseOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Orders"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayInventoryPurchaseOrders1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAInv_purchase_order_dtl.SelectCommand.CommandText = DAInv_purchase_order_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY Inv_purchase_order_dtl.po_no"
        DAInv_purchase_order_dtl.Fill(DsFrmEndOfDayInventoryPurchaseOrders1.Inv_purchase_order_dtl)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmPurchaseOrder As New UcPurchaseOrder.FrmPurchaseOrder
            MyFrmPurchaseOrder.ShowPnlHead = False
            MyFrmPurchaseOrder.CodPurchaseOrder = Currentrow.Cells("po_no").Value & ""
            MyFrmPurchaseOrder.StartPosition = FormStartPosition.CenterScreen
            MyFrmPurchaseOrder.ShowDialog()
        End If
    End Sub
End Class
