Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayInventoryInterStoreSales
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
    Friend WithEvents DAinv_sales_transfer_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayInventoryInterStoreSales1 As UCBankAccount.DSFrmEndOfDayInventoryInterStoreSales
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayInventoryInterStoreSales))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayInventoryInterStoreSales1 = New UCBankAccount.DSFrmEndOfDayInventoryInterStoreSales
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_sales_transfer_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayInventoryInterStoreSales1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "inv_sales_transfer_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayInventoryInterStoreSales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_sales_transfer_dtl</Caption><Columns Co" & _
        "llection=""true""><Column0 ID=""ID_sales_transfer""><Caption>Reference No</Caption><" & _
        "TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringVal" & _
        "ue /><DataMember>ID_sales_transfer</DataMember><Key>ID_sales_transfer</Key><Posi" & _
        "tion>0</Position><Width>79</Width></Column0><Column1 ID=""item_no""><Caption>Item " & _
        "No.</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><" & _
        "EmptyStringValue /><DataMember>item_no</DataMember><Key>item_no</Key><Position>1" & _
        "</Position><Width>63</Width></Column1><Column2 ID=""desc_item""><Caption>Descripti" & _
        "on</Caption><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</P" & _
        "osition><Width>155</Width></Column2><Column3 ID=""qty""><Caption>Qty Sold</Caption" & _
        "><DataMember>qty</DataMember><Key>qty</Key><Position>3</Position><TextAlignment>" & _
        "Center</TextAlignment><Width>53</Width></Column3><Column4 ID=""ReplCost""><Caption" & _
        ">Repl. Cost</Caption><DataMember>ReplCost</DataMember><EditType>NoEdit</EditType" & _
        "><FormatString>C2</FormatString><Key>ReplCost</Key><Position>4</Position><Width>" & _
        "73</Width></Column4><Column5 ID=""fet""><Caption>FET</Caption><DataMember>fet</Dat" & _
        "aMember><FormatString>c2</FormatString><Key>fet</Key><Position>5</Position><Widt" & _
        "h>69</Width></Column5><Column6 ID=""ExtCost""><Caption>Ext. Cost</Caption><DataMem" & _
        "ber>ExtCost</DataMember><FormatString>c2</FormatString><Key>ExtCost</Key><Positi" & _
        "on>6</Position><Width>78</Width></Column6><Column7 ID=""ExtPrice""><Caption>Ext. P" & _
        "rice</Caption><DataMember>ExtPrice</DataMember><FormatString>c2</FormatString><K" & _
        "ey>ExtPrice</Key><Position>7</Position><Width>78</Width></Column7><Column8 ID=""s" & _
        "tore_to""><Caption>To Store</Caption><DataMember>store_to</DataMember><Key>store_" & _
        "to</Key><Position>8</Position><Width>53</Width></Column8></Columns><GroupConditi" & _
        "on ID="""" /><Key>inv_sales_transfer_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 303)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayInventoryInterStoreSales1
        '
        Me.DsFrmEndOfDayInventoryInterStoreSales1.DataSetName = "DSFrmEndOfDayInventoryInterStoreSales"
        Me.DsFrmEndOfDayInventoryInterStoreSales1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_sales_transfer_dtl.ID_sales_transfer, inv_sales_transfer_dtl.item_no, " & _
        "inv_sales_transfer_dtl.qty * (inv_sales_transfer_dtl.price + inv_sales_transfer_" & _
        "dtl.fet) AS ExtPrice, inv_item.desc_item, inv_item_cost_transaction.cost + inv_i" & _
        "tem_cost_transaction.delivery + inv_item_cost_transaction.frieght AS ReplCost, i" & _
        "nv_salse_transfer_head.store_to, inv_sales_transfer_dtl.qty, inv_sales_transfer_" & _
        "dtl.qty * (inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery +" & _
        " inv_item_cost_transaction.frieght + inv_item_cost_transaction.fet) AS ExtCost, " & _
        "inv_item_cost_transaction.fet FROM inv_sales_transfer_dtl LEFT OUTER JOIN inv_it" & _
        "em ON inv_sales_transfer_dtl.item_no = inv_item.item_no LEFT OUTER JOIN inv_item" & _
        "_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no LEFT O" & _
        "UTER JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = " & _
        "inv_salse_transfer_head.ID_sales_transfer"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAinv_sales_transfer_dtl
        '
        Me.DAinv_sales_transfer_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAinv_sales_transfer_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_sales_transfer_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
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
        Me.Panel4.TabIndex = 10
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
        Me.UcPrintGrid1.Location = New System.Drawing.Point(520, 10)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
        '
        'FrmEndOfDayInventoryInterStoreSales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 348)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayInventoryInterStoreSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inter-Store Sales"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayInventoryInterStoreSales1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAinv_sales_transfer_dtl.SelectCommand.CommandText = DAinv_sales_transfer_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY inv_sales_transfer_dtl.ID_sales_transfer"
        DAinv_sales_transfer_dtl.Fill(DsFrmEndOfDayInventoryInterStoreSales1.inv_sales_transfer_dtl)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmInterStoreSale As New UcInterStoreSale.FrmInterStoreSale
            MyFrmInterStoreSale.ShowPnlHead = False
            MyFrmInterStoreSale.TypeOfForm = 1
            MyFrmInterStoreSale.CodInterStoreSale = Currentrow.Cells("ID_sales_transfer").Value & ""
            MyFrmInterStoreSale.StartPosition = FormStartPosition.CenterScreen
            MyFrmInterStoreSale.ShowDialog()
        End If
    End Sub
End Class
