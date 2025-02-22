Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayInventoryAdjustment
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
    Friend WithEvents DAinv_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayInventoryAdjustment1 As UCBankAccount.DSFrmEndOfDayInventoryAdjustment
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayInventoryAdjustment))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayInventoryAdjustment1 = New UCBankAccount.DSFrmEndOfDayInventoryAdjustment
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayInventoryAdjustment1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "inv_adjustment_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayInventoryAdjustment1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_adjustment_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""referID_adjustment""><Caption>Reference No</Caption><Typ" & _
        "eNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue " & _
        "/><DataMember>referID_adjustment</DataMember><Key>referID_adjustment</Key><Posit" & _
        "ion>0</Position><Width>84</Width></Column0><Column1 ID=""item_no""><Caption>Item N" & _
        "o</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><Em" & _
        "ptyStringValue /><DataMember>item_no</DataMember><Key>item_no</Key><Position>1</" & _
        "Position><Width>84</Width></Column1><Column2 ID=""desc_item""><Caption>Description" & _
        "</Caption><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</Pos" & _
        "ition><Width>197</Width></Column2><Column3 ID=""QTY""><Caption>Qty Adj.</Caption><" & _
        "DataMember>QTY</DataMember><Key>QTY</Key><Position>3</Position><TextAlignment>Ce" & _
        "nter</TextAlignment><Width>49</Width></Column3><Column4 ID=""ReplCost""><Caption>R" & _
        "epl. Cost</Caption><DataMember>ReplCost</DataMember><EditType>NoEdit</EditType><" & _
        "FormatString>c2</FormatString><Key>ReplCost</Key><Position>4</Position><Width>83" & _
        "</Width></Column4><Column5 ID=""fet""><Caption>FET</Caption><DataMember>fet</DataM" & _
        "ember><FormatString>c2</FormatString><Key>fet</Key><Position>5</Position><Width>" & _
        "60</Width></Column5><Column6 ID=""ExtCost""><Caption>Ext. Cost</Caption><DataMembe" & _
        "r>ExtCost</DataMember><EditType>NoEdit</EditType><FormatString>c2</FormatString>" & _
        "<Key>ExtCost</Key><Position>6</Position><TextAlignment>Far</TextAlignment><Width" & _
        ">81</Width></Column6><Column7 ID=""authorized_by""><Caption>Auth. by</Caption><Dat" & _
        "aMember>authorized_by</DataMember><Key>authorized_by</Key><Position>7</Position>" & _
        "<Width>57</Width></Column7></Columns><GroupCondition ID="""" /><Key>inv_adjustment" & _
        "_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 311)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayInventoryAdjustment1
        '
        Me.DsFrmEndOfDayInventoryAdjustment1.DataSetName = "DSFrmEndOfDayInventoryAdjustment"
        Me.DsFrmEndOfDayInventoryAdjustment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABI;packet size=4096;user id=sa;integrated security=SSPI;data s" & _
        "ource=""."";persist security info=False;initial catalog=TireMate_01"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_adjustment_dtl.referID_adjustment, inv_adjustment_dtl.item_no, inv_adj" & _
        "ustment_dtl.QTY, inv_item.desc_item, inv_item_cost_transaction.cost + inv_item_c" & _
        "ost_transaction.delivery + inv_item_cost_transaction.frieght AS ReplCost, inv_it" & _
        "em_cost_transaction.fet, inv_adjustment_head.authorized_by, inv_adjustment_dtl.Q" & _
        "TY * (inv_adjustment_dtl.Cost + inv_adjustment_dtl.Fet) AS ExtCost FROM inv_adju" & _
        "stment_dtl LEFT OUTER JOIN inv_adjustment_head ON inv_adjustment_dtl.referID_adj" & _
        "ustment = inv_adjustment_head.referID_adjustment LEFT OUTER JOIN inv_item ON inv" & _
        "_adjustment_dtl.item_no = inv_item.item_no LEFT OUTER JOIN inv_item_cost_transac" & _
        "tion ON inv_item.item_no = inv_item_cost_transaction.item_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAinv_adjustment_dtl
        '
        Me.DAinv_adjustment_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAinv_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("QTY", "QTY"), New System.Data.Common.DataColumnMapping("Cost", "Cost")})})
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
        Me.UcPrintGrid1.Location = New System.Drawing.Point(529, 10)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
        '
        'FrmEndOfDayInventoryAdjustment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 356)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayInventoryAdjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Adjustment"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayInventoryAdjustment1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAinv_adjustment_dtl.SelectCommand.CommandText = DAinv_adjustment_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY inv_adjustment_dtl.referID_adjustment"
        DAinv_adjustment_dtl.Fill(DsFrmEndOfDayInventoryAdjustment1.inv_adjustment_dtl)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmInventoryAdjustment As New UCInv_Item.FrmInventoryAdjustment
            MyFrmInventoryAdjustment.ShowPnlHead = False
            MyFrmInventoryAdjustment.CodInventoryAdjustment = Currentrow.Cells("referID_adjustment").Value & ""
            MyFrmInventoryAdjustment.StartPosition = FormStartPosition.CenterScreen
            MyFrmInventoryAdjustment.ShowDialog()
        End If
    End Sub
End Class
