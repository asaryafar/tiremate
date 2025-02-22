Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayTirePartsSales
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
    Friend WithEvents DsFrmEndOfDayTirePartsSales1 As UCBankAccount.DSFrmEndOfDayTirePartsSales
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayTirePartsSales))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayTirePartsSales1 = New UCBankAccount.DSFrmEndOfDayTirePartsSales
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayTirePartsSales1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayTirePartsSales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><Type" & _
        "NameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /" & _
        "><DataMember>id_service_center</DataMember><Key>id_service_center</Key><Position" & _
        ">0</Position><Width>79</Width></Column0><Column1 ID=""cod_select""><Caption>Item N" & _
        "o</Caption><DataMember>cod_select</DataMember><Key>cod_select</Key><Position>1</" & _
        "Position><Width>72</Width></Column1><Column2 ID=""desc_item""><Caption>Description" & _
        "</Caption><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</Pos" & _
        "ition><Width>180</Width></Column2><Column3 ID=""qty""><Caption>Qty</Caption><TypeN" & _
        "ameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>qty</DataMember><FormatString>####</FormatString><Key>qty</Key><MaskPrompt>&#" & _
        "x0;</MaskPrompt><Position>3</Position><TextAlignment>Center</TextAlignment><Widt" & _
        "h>27</Width></Column3><Column4 ID=""Ext_Price""><Caption>Ext. Price</Caption><Data" & _
        "Member>Ext_Price</DataMember><FormatString>c2</FormatString><Key>Ext_Price</Key>" & _
        "<Position>4</Position><Width>68</Width></Column4><Column5 ID=""ExtCost""><Caption>" & _
        "ExtCost</Caption><DataMember>ExtCost</DataMember><EditType>NoEdit</EditType><For" & _
        "matString>C2</FormatString><Key>ExtCost</Key><Position>5</Position><Width>66</Wi" & _
        "dth></Column5><Column6 ID=""GrProfitAmount""><Caption>Gr.Prof.$</Caption><DataMemb" & _
        "er>GrProfitAmount</DataMember><EditType>NoEdit</EditType><FormatString>C2</Forma" & _
        "tString><Key>GrProfitAmount</Key><Position>6</Position><Width>64</Width></Column" & _
        "6><Column7 ID=""GrProfitPercent""><Caption>Gr.Prof.%</Caption><DataMember>GrProfit" & _
        "Percent</DataMember><EditType>NoEdit</EditType><InputMask>###</InputMask><Key>Gr" & _
        "ProfitPercent</Key><MaskPrompt>&#x0;</MaskPrompt><Position>7</Position><TextAlig" & _
        "nment>Center</TextAlignment><Width>60</Width><FormatMode>UseInputMask</FormatMod" & _
        "e></Column7><Column8 ID=""Type""><Caption>Type</Caption><DataMember>Type</DataMemb" & _
        "er><Key>Type</Key><Position>8</Position><Width>78</Width></Column8><Column9 ID=""" & _
        "CustomerCompleteName""><Caption>Name</Caption><DataMember>CustomerCompleteName</D" & _
        "ataMember><EditType>NoEdit</EditType><Key>CustomerCompleteName</Key><Position>9<" & _
        "/Position><Width>115</Width></Column9><Column10 ID=""CompanyName""><Caption>Compan" & _
        "y</Caption><DataMember>CompanyName</DataMember><EditType>NoEdit</EditType><Key>C" & _
        "ompanyName</Key><Position>10</Position><Width>162</Width></Column10></Columns><G" & _
        "roupCondition ID="""" /><Key>service_center_dtl</Key></RootTable></GridEXLayoutDat" & _
        "a>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(731, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayTirePartsSales1
        '
        Me.DsFrmEndOfDayTirePartsSales1.DataSetName = "DSFrmEndOfDayTirePartsSales"
        Me.DsFrmEndOfDayTirePartsSales1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_dtl.id_service_center, inv_item.desc_item, service_center_d" & _
        "tl.qty, service_center_dtl.qty * (service_center_dtl.price + service_center_dtl." & _
        "fet) AS Ext_Price, CASE inv_item.cod_item_type WHEN '01' THEN 'Tire' WHEN '02' T" & _
        "HEN 'Wheel' ELSE 'Auto Part' END AS Type, service_center_dtl.cod_select, ISNULL(" & _
        "service_center_dtl.qty * (inv_item_cost_transaction.cost + inv_item_cost_transac" & _
        "tion.delivery + inv_item_cost_transaction.frieght + inv_item_cost_transaction.fe" & _
        "t), 0) AS ExtCost, CASE ISNULL(service_center_dtl.qty * (service_center_dtl.pric" & _
        "e + service_center_dtl.fet), 0) WHEN 0 THEN 0 ELSE round((isnull(service_center_" & _
        "dtl.qty * (service_center_dtl.price + service_center_dtl.fet), 0) - ISNULL(servi" & _
        "ce_center_dtl.qty * (inv_item_cost_transaction.cost + inv_item_cost_transaction." & _
        "delivery + inv_item_cost_transaction.frieght + inv_item_cost_transaction.fet), 0" & _
        ")) / ISNULL(service_center_dtl.qty * (service_center_dtl.price + service_center_" & _
        "dtl.fet), 0) * 100, 2) END AS GrProfitPercent, cust_trtab_main.f_name + ' ' + cu" & _
        "st_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS CustomerCompleteName, cus" & _
        "t_company.complete_name AS CompanyName, ROUND(service_center_dtl.qty * (service_" & _
        "center_dtl.price + service_center_dtl.fet) - ISNULL(service_center_dtl.qty * (in" & _
        "v_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cos" & _
        "t_transaction.frieght + inv_item_cost_transaction.fet), 0), 2) AS GrProfitAmount" & _
        " FROM service_center_dtl LEFT OUTER JOIN service_center_head ON service_center_d" & _
        "tl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN cus" & _
        "t_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer " & _
        "LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_c" & _
        "ompany LEFT OUTER JOIN inv_item ON service_center_dtl.cod_select = inv_item.item" & _
        "_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cos" & _
        "t_transaction.item_no"
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
        Me.Panel4.Size = New System.Drawing.Size(731, 45)
        Me.Panel4.TabIndex = 10
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
        Me.Label1.Size = New System.Drawing.Size(320, 43)
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
        'FrmEndOfDayTirePartsSales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(731, 393)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayTirePartsSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tire And Parts Sales"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayTirePartsSales1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_dtl.SelectCommand.CommandText = DAservice_center_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY service_center_head.id_service_center"
        DAservice_center_dtl.Fill(DsFrmEndOfDayTirePartsSales1.service_center_dtl)
        'DsFrmEndOfDayTirePartsSales1.service_center_dtl.Columns("GrProfitAmount").Expression = "Ext_Price - ExtCost"
        'DsFrmEndOfDayTirePartsSales1.service_center_dtl.Columns("GrProfitPercent").Expression = "(GrProfitAmount/Ext_Price)*100"

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
    Private Sub GridEX1_Error(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ErrorEventArgs) Handles GridEX1.Error

    End Sub
End Class
