Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayAdjustmentsSales
    Inherits FrmBase
    Public WhereClauseVar As String
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
    Friend WithEvents DsFrmEndOfDayAdjustmentsSales1 As UCBankAccount.DSFrmEndOfDayAdjustmentsSales
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayAdjustmentsSales))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayAdjustmentsSales1 = New UCBankAccount.DSFrmEndOfDayAdjustmentsSales
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayAdjustmentsSales1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayAdjustmentsSales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><Type" & _
        "NameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /" & _
        "><DataMember>id_service_center</DataMember><Key>id_service_center</Key><Position" & _
        ">0</Position><Width>80</Width></Column0><Column1 ID=""cod_select""><Caption>Item N" & _
        "o</Caption><DataMember>cod_select</DataMember><Key>cod_select</Key><Position>1</" & _
        "Position><Width>64</Width></Column1><Column2 ID=""desc_item""><Caption>Description" & _
        "</Caption><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</Pos" & _
        "ition><Width>144</Width></Column2><Column3 ID=""qty""><Caption>Qty</Caption><TypeN" & _
        "ameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>qty</DataMember><InputMask>Number0</InputMask><Key>qty</Key><MaskPrompt>&#x0;" & _
        "</MaskPrompt><Position>3</Position><TextAlignment>Far</TextAlignment><Width>46</" & _
        "Width></Column3><Column4 ID=""Ext_Price""><Caption>Adj. Price</Caption><DataMember" & _
        ">Ext_Price</DataMember><FormatString>c2</FormatString><Key>Ext_Price</Key><Posit" & _
        "ion>4</Position><Width>72</Width></Column4><Column5 ID=""cost""><Caption>Item Cost" & _
        "</Caption><DataMember>Cost</DataMember><FormatString>c2</FormatString><Key>cost<" & _
        "/Key><Position>5</Position><Width>72</Width></Column5><Column6 ID=""supplier_perc" & _
        "ent""><Caption>supp %</Caption><DataMember>supplier_percent</DataMember><Key>supp" & _
        "lier_percent</Key><Position>6</Position><Width>50</Width></Column6><Column7 ID=""" & _
        "measured_tread_depth""><Caption>Meas. Tread</Caption><DataMember>measured_tread_d" & _
        "epth</DataMember><Key>measured_tread_depth</Key><Position>7</Position><Width>96<" & _
        "/Width></Column7><Column8 ID=""DOT_serial_no""><Caption>DOT S/N</Caption><DataMemb" & _
        "er>DOT_serial_no</DataMember><Key>DOT_serial_no</Key><Position>8</Position><Widt" & _
        "h>97</Width></Column8></Columns><GroupCondition ID="""" /><Key>service_center_dtl<" & _
        "/Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(742, 321)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayAdjustmentsSales1
        '
        Me.DsFrmEndOfDayAdjustmentsSales1.DataSetName = "DSFrmEndOfDayAdjustmentsSales"
        Me.DsFrmEndOfDayAdjustmentsSales1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_dtl.id_service_center, service_center_dtl.qty, service_cent" & _
        "er_dtl.qty * (service_center_dtl.price + service_center_dtl.fet) AS Ext_Price, s" & _
        "ervice_center_dtl.cod_select, inv_item.desc_item, service_tire_adjustment.suppli" & _
        "er_percent, service_tire_adjustment.measured_tread_depth, service_tire_adjustmen" & _
        "t.DOT_serial_no, (inv_item_cost_transaction.cost + inv_item_cost_transaction.fet" & _
        ") * service_center_dtl.qty AS Cost FROM service_center_dtl LEFT OUTER JOIN servi" & _
        "ce_tire_adjustment ON service_center_dtl.id_service_center = service_tire_adjust" & _
        "ment.id_service_center LEFT OUTER JOIN service_center_head ON service_center_dtl" & _
        ".id_service_center = service_center_head.id_service_center LEFT OUTER JOIN inv_i" & _
        "tem ON service_center_dtl.cod_select = inv_item.item_no LEFT OUTER JOIN inv_item" & _
        "_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no"
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
        Me.Panel4.Size = New System.Drawing.Size(742, 45)
        Me.Panel4.TabIndex = 4
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(536, 8)
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
        'FrmEndOfDayAdjustmentsSales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(742, 366)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayAdjustmentsSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjustments Sales"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayAdjustmentsSales1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_dtl.SelectCommand.CommandText = DAservice_center_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY service_center_head.id_service_center"
        DAservice_center_dtl.Fill(DsFrmEndOfDayAdjustmentsSales1.service_center_dtl)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
            MyFrmShowWorkOrder.TypeOfForm = "IN"
            MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
            MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
            MyFrmShowWorkOrder.Show()
        End If
    End Sub
End Class
