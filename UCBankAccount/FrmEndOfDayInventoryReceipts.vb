Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayInventoryReceipts
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
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Receive_product_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayInventoryReceipts1 As UCBankAccount.DSFrmEndOfDayInventoryReceipts
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayInventoryReceipts))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayInventoryReceipts1 = New UCBankAccount.DSFrmEndOfDayInventoryReceipts
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Receive_product_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayInventoryReceipts1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "Inv_Receive_product_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayInventoryReceipts1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Inv_Receive_product_dtl</Caption><Columns C" & _
        "ollection=""true""><Column0 ID=""id_receive_ref""><Caption>Reference No</Caption><Ty" & _
        "peNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue" & _
        " /><DataMember>id_receive_ref</DataMember><Key>id_receive_ref</Key><Position>0</" & _
        "Position><Width>81</Width></Column0><Column1 ID=""item_no""><Caption>Item No.</Cap" & _
        "tion><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStr" & _
        "ingValue /><DataMember>item_no</DataMember><Key>item_no</Key><Position>1</Positi" & _
        "on><Width>89</Width></Column1><Column2 ID=""desc_item""><Caption>Description</Capt" & _
        "ion><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</Position>" & _
        "<Width>176</Width></Column2><Column3 ID=""qty""><Caption>Qty Rcvd</Caption><DataMe" & _
        "mber>qty</DataMember><Key>qty</Key><Position>3</Position><TextAlignment>Center</" & _
        "TextAlignment><Width>60</Width></Column3><Column4 ID=""ReplCost""><Caption>Repl. C" & _
        "ost</Caption><DataMember>ReplCost</DataMember><EditType>NoEdit</EditType><Format" & _
        "String>c2</FormatString><Key>ReplCost</Key><Position>4</Position><Width>84</Widt" & _
        "h></Column4><Column5 ID=""fet""><Caption>FET</Caption><DataMember>fet</DataMember>" & _
        "<FormatString>c2</FormatString><Key>fet</Key><Position>5</Position><Width>63</Wi" & _
        "dth></Column5><Column6 ID=""ExtCost""><Caption>Ext. Cost</Caption><DataMember>ExtC" & _
        "ost</DataMember><EditType>NoEdit</EditType><FormatString>c2</FormatString><Key>E" & _
        "xtCost</Key><Position>6</Position><Width>85</Width></Column6><Column7 ID=""cod_ve" & _
        "ndor""><Caption>Vendor</Caption><DataMember>cod_vendor</DataMember><Key>cod_vendo" & _
        "r</Key><Position>7</Position><Width>51</Width></Column7></Columns><GroupConditio" & _
        "n ID="""" /><Key>Inv_Receive_product_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 312)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayInventoryReceipts1
        '
        Me.DsFrmEndOfDayInventoryReceipts1.DataSetName = "DSFrmEndOfDayInventoryReceipts"
        Me.DsFrmEndOfDayInventoryReceipts1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=True;initial catalog=TireMate_02;password=2191110"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Inv_Receive_product_dtl.id_receive_ref, Inv_Receive_product_dtl.item_no, I" & _
        "nv_Receive_product_dtl.qty * (Inv_Receive_product_dtl.cost + Inv_Receive_product" & _
        "_dtl.Fet) AS ExtCost, inv_item.desc_item, inv_item_cost_transaction.cost + inv_i" & _
        "tem_cost_transaction.delivery + inv_item_cost_transaction.frieght AS ReplCost, i" & _
        "nv_item_cost_transaction.fet, Inv_Receive_Products_head.cod_vendor, Inv_Receive_" & _
        "product_dtl.qty FROM Inv_Receive_product_dtl LEFT OUTER JOIN inv_item ON Inv_Rec" & _
        "eive_product_dtl.item_no = inv_item.item_no LEFT OUTER JOIN Inv_Receive_Products" & _
        "_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_r" & _
        "eceive_ref LEFT OUTER JOIN inv_vendor ON Inv_Receive_Products_head.cod_vendor = " & _
        "inv_vendor.cod_vendor LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item" & _
        "_no = inv_item_cost_transaction.item_no"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAInv_Receive_product_dtl
        '
        Me.DAInv_Receive_product_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DAInv_Receive_product_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable")})})
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
        Me.Panel4.TabIndex = 8
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
        Me.UcPrintGrid1.Location = New System.Drawing.Point(526, 12)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
        '
        'FrmEndOfDayInventoryReceipts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 357)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayInventoryReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Receipts"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayInventoryReceipts1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAInv_Receive_product_dtl.SelectCommand.CommandText = DAInv_Receive_product_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY Inv_Receive_product_dtl.id_receive_ref"
        DAInv_Receive_product_dtl.Fill(DsFrmEndOfDayInventoryReceipts1.Inv_Receive_product_dtl)
        If KindOfForm = 1 Then ' IN
            GridEX1.RootTable.Columns("Qty").Caption = "Qty Rcvd"
            Me.Text = "Inventory Receipts"
        Else ' RT
            Me.Text = "Inventory Returns To Supplier"
            GridEX1.RootTable.Columns("Qty").Caption = "Qty Rtnd"
        End If

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmReceiveReturnProduct As New UcReceiveReturnProduct.FrmReceiveReturnProduct
            MyFrmReceiveReturnProduct.ShowPnlHead = False
            MyFrmReceiveReturnProduct.CodReceiveReturnProduct = Currentrow.Cells("id_receive_ref").Value & ""
            MyFrmReceiveReturnProduct.BillCredit = KindOfForm
            MyFrmReceiveReturnProduct.StartPosition = FormStartPosition.CenterScreen
            MyFrmReceiveReturnProduct.ShowDialog()
        End If
    End Sub
End Class
