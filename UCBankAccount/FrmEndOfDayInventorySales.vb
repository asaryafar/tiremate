Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayInventorySales
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
    Friend WithEvents DAservice_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayInventorySales1 As UCBankAccount.DSFrmEndOfDayInventorySales
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayInventorySales))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayInventorySales1 = New UCBankAccount.DSFrmEndOfDayInventorySales
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayInventorySales1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayInventorySales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><Type" & _
        "NameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /" & _
        "><DataMember>id_service_center</DataMember><Key>id_service_center</Key><Position" & _
        ">0</Position><Width>80</Width></Column0><Column1 ID=""cod_select""><Caption>Item N" & _
        "o</Caption><DataMember>cod_select</DataMember><Key>cod_select</Key><Position>1</" & _
        "Position><Width>76</Width></Column1><Column2 ID=""desc_item""><Caption>Description" & _
        "</Caption><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</Pos" & _
        "ition><Width>242</Width></Column2><Column3 ID=""qty""><Caption>Qty Sold</Caption><" & _
        "TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><Dat" & _
        "aMember>qty</DataMember><FormatString>####</FormatString><Key>qty</Key><MaskProm" & _
        "pt>&#x0;</MaskPrompt><Position>3</Position><TextAlignment>Center</TextAlignment>" & _
        "<Width>53</Width></Column3><Column4 ID=""ReplCost""><Caption>Repl.Cost</Caption><D" & _
        "ataMember>ReplCost</DataMember><FormatString>c2</FormatString><Key>ReplCost</Key" & _
        "><Position>4</Position><Width>78</Width></Column4><Column5 ID=""fet""><Caption>FET" & _
        "</Caption><DataMember>fet</DataMember><FormatString>c2</FormatString><Key>fet</K" & _
        "ey><Position>5</Position><Width>60</Width></Column5><Column6 ID=""Ext_Cost""><Aggr" & _
        "egateFunction>Sum</AggregateFunction><Caption>Ext.Cost</Caption><DataMember>Ext_" & _
        "Cost</DataMember><FormatString>c2</FormatString><Key>Ext_Cost</Key><Position>6</" & _
        "Position><Width>79</Width><TotalFormatString>c2</TotalFormatString></Column6><Co" & _
        "lumn7 ID=""min_stock""><Caption>Min Stock</Caption><DataMember>min_stock</DataMemb" & _
        "er><Key>min_stock</Key><Position>7</Position><TextAlignment>Center</TextAlignmen" & _
        "t><Width>63</Width></Column7><Column8 ID=""Type""><Caption>Type</Caption><DataMemb" & _
        "er>Type</DataMember><Key>Type</Key><Position>8</Position><Width>89</Width></Colu" & _
        "mn8></Columns><GroupCondition ID="""" /><Key>service_center_dtl</Key></RootTable><" & _
        "/GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 359)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmEndOfDayInventorySales1
        '
        Me.DsFrmEndOfDayInventorySales1.DataSetName = "DSFrmEndOfDayInventorySales"
        Me.DsFrmEndOfDayInventorySales1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_dtl.id_service_center, inv_item.desc_item, service_center_d" & _
        "tl.qty, ISNULL(service_center_dtl.qty * (inv_item_cost_transaction.fet + inv_ite" & _
        "m_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cost_tra" & _
        "nsaction.frieght), 0) AS Ext_Cost, CASE inv_item.cod_item_type WHEN '01' THEN 'T" & _
        "ire' WHEN '02' THEN 'Wheel' ELSE 'Auto Part' END AS Type, service_center_dtl.cod" & _
        "_select, inv_item_cost_transaction.fet, ISNULL(inv_item_cost_transaction.cost + " & _
        "inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght, 0) AS Re" & _
        "plCost, ISNULL(inv_tab_item_warehouse.min_stock, 0) AS min_stock FROM service_ce" & _
        "nter_dtl LEFT OUTER JOIN service_center_head ON service_center_dtl.id_service_ce" & _
        "nter = service_center_head.id_service_center LEFT OUTER JOIN inv_item ON service" & _
        "_center_dtl.cod_select = inv_item.item_no LEFT OUTER JOIN inv_item_cost_transact" & _
        "ion ON inv_item.item_no = inv_item_cost_transaction.item_no LEFT OUTER JOIN inv_" & _
        "tab_item_warehouse ON inv_item.item_no = inv_tab_item_warehouse.item_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAservice_center_dtl
        '
        Me.DAservice_center_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
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
        Me.Panel4.TabIndex = 6
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(509, 11)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
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
        'FrmEndOfDayInventorySales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 404)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayInventorySales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Sales"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayInventorySales1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_dtl.SelectCommand.CommandText = DAservice_center_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY service_center_head.id_service_center"
        DAservice_center_dtl.Fill(DsFrmEndOfDayInventorySales1.service_center_dtl)
        If KindOfForm = 1 Then ' IN
            Me.Text = "Inventory Sales"
            GridEX1.RootTable.Columns("min_stock").Visible = True
            GridEX1.RootTable.Columns("Qty").Caption = "Qty Sold"
        Else ' RT
            Me.Text = "Customer Inventory Returns"
            GridEX1.RootTable.Columns("min_stock").Visible = False
            GridEX1.RootTable.Columns("Qty").Caption = "Qty Rtnd"
            GridEX1.RootTable.Columns("desc_item").Width = GridEX1.RootTable.Columns("desc_item").Width + GridEX1.RootTable.Columns("min_stock").Width
        End If

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
            If KindOfForm = 1 Then ' IN
                MyFrmShowWorkOrder.TypeOfForm = "IN"
            Else
                MyFrmShowWorkOrder.TypeOfForm = "RT"
            End If
            MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
            MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
            MyFrmShowWorkOrder.Show()
        End If
    End Sub
End Class
