Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayOutsidePurchasesSales
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
    Friend WithEvents DsFrmEndOfDayOutsidePurchasesSales1 As UCBankAccount.DSFrmEndOfDayOutsidePurchasesSales
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayOutsidePurchasesSales))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayOutsidePurchasesSales1 = New UCBankAccount.DSFrmEndOfDayOutsidePurchasesSales
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayOutsidePurchasesSales1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayOutsidePurchasesSales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Invoice No</Caption><TypeNa" & _
        "meEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><" & _
        "DataMember>id_service_center</DataMember><Key>id_service_center</Key><Position>0" & _
        "</Position><Width>71</Width></Column0><Column1 ID=""date_refer""><Caption>Date</Ca" & _
        "ption><DataMember>date_refer</DataMember><EditType>NoEdit</EditType><FilterEditT" & _
        "ype>TextBox</FilterEditType><Key>date_refer</Key><Position>1</Position><Width>81" & _
        "</Width></Column1><Column2 ID=""cod_customer""><Caption>Customer</Caption><DataMem" & _
        "ber>cod_customer</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>cod_customer</Key><Position>2</Position><Width>93</Width></" & _
        "Column2><Column3 ID=""cod_select""><Caption>Item No</Caption><DataMember>cod_selec" & _
        "t</DataMember><Key>cod_select</Key><Position>3</Position><Width>58</Width></Colu" & _
        "mn3><Column4 ID=""desc_item""><Caption>Description</Caption><DataMember>desc_item<" & _
        "/DataMember><Key>desc_item</Key><Position>4</Position><Width>154</Width></Column" & _
        "4><Column5 ID=""qty""><Caption>Qty</Caption><TypeNameEmptyStringValue>NULL</TypeNa" & _
        "meEmptyStringValue><EmptyStringValue /><DataMember>qty</DataMember><FormatString" & _
        ">####</FormatString><Key>qty</Key><MaskPrompt>&#x0;</MaskPrompt><Position>5</Pos" & _
        "ition><TextAlignment>Center</TextAlignment><Width>32</Width></Column5><Column6 I" & _
        "D=""Ext_Price""><Caption>Ext. Price</Caption><DataMember>Ext_Price</DataMember><Fo" & _
        "rmatString>c2</FormatString><Key>Ext_Price</Key><Position>6</Position><Width>67<" & _
        "/Width></Column6><Column7 ID=""ExtCost""><Caption>Ext. Cost</Caption><DataMember>E" & _
        "xtCost</DataMember><FormatString>c2</FormatString><Key>ExtCost</Key><Position>7<" & _
        "/Position><Width>68</Width></Column7><Column8 ID=""GrProfAmount""><Caption>Gr. Pro" & _
        "f. $</Caption><DataMember>GrProfitAmount</DataMember><FormatString>c2</FormatStr" & _
        "ing><Key>GrProfAmount</Key><Position>8</Position><Width>62</Width></Column8><Col" & _
        "umn9 ID=""GrProfPercent""><Caption>Gr.Prof.%</Caption><DataMember>GrProfitPercent<" & _
        "/DataMember><InputMask>Percent0</InputMask><Key>GrProfPercent</Key><MaskPrompt>&" & _
        "#x0;</MaskPrompt><Position>9</Position><TextAlignment>Center</TextAlignment><Wid" & _
        "th>61</Width><FormatMode>UseInputMask</FormatMode></Column9><Column10 ID=""cod_ve" & _
        "ndor""><Caption>Vendor</Caption><DataMember>cod_vendor</DataMember><Key>cod_vendo" & _
        "r</Key><Position>10</Position><Width>47</Width></Column10><Column11 ID=""invoice_" & _
        "no""><Caption>Vendor Ref.</Caption><DataMember>invoice_no</DataMember><Key>invoic" & _
        "e_no</Key><Position>11</Position><Width>74</Width></Column11><Column12 ID=""id_se" & _
        "rvice_center_before""><Caption>Work Order</Caption><DataMember>id_service_center_" & _
        "before</DataMember><EditType>NoEdit</EditType><Key>id_service_center_before</Key" & _
        "><Position>12</Position><Width>69</Width></Column12></Columns><GroupCondition ID" & _
        "="""" /><Key>service_center_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 44)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(952, 366)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayOutsidePurchasesSales1
        '
        Me.DsFrmEndOfDayOutsidePurchasesSales1.DataSetName = "DSFrmEndOfDayOutsidePurchasesSales"
        Me.DsFrmEndOfDayOutsidePurchasesSales1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHSERVER;packet size=4096;user id=sa;data source=ARMANDEHSER" & _
        "VER;persist security info=True;initial catalog=TireMate_01;password="
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_dtl.id_service_center, service_center_dtl.qty, ISNULL(servi" & _
        "ce_center_dtl.qty * (service_center_dtl.price + service_center_dtl.fet), 0) AS E" & _
        "xt_Price, service_center_dtl.cod_select, service_out_purchases.cod_vendor, servi" & _
        "ce_out_purchases.invoice_no, ISNULL(service_out_purchases.cost + service_out_pur" & _
        "chases.fet, 0) * service_center_dtl.qty AS ExtCost, service_center_dtl.desc_radi" & _
        "f AS desc_item, service_center_head.id_service_center_before, CASE ISNULL(servic" & _
        "e_center_dtl.qty * (service_center_dtl.price + service_center_dtl.fet), 0) WHEN " & _
        "0 THEN 0 ELSE round(((ISNULL(service_center_dtl.qty * (service_center_dtl.price " & _
        "+ service_center_dtl.fet), 0) - ISNULL(ISNULL(service_out_purchases.cost + servi" & _
        "ce_out_purchases.fet, 0) * service_center_dtl.qty, 0)) / ISNULL(service_center_d" & _
        "tl.qty * (service_center_dtl.price + service_center_dtl.fet), 0) * 100), 2) END " & _
        "AS GrProfitPercent, service_center_head.date_refer, service_center_head.cod_cust" & _
        "omer FROM inv_item RIGHT OUTER JOIN service_center_dtl LEFT OUTER JOIN service_c" & _
        "enter_head ON service_center_dtl.id_service_center = service_center_head.id_serv" & _
        "ice_center LEFT OUTER JOIN service_out_purchases ON service_center_dtl.id_servic" & _
        "e_center = service_out_purchases.id_service_center AND service_center_dtl.radif " & _
        "= service_out_purchases.radif ON inv_item.item_no = service_center_dtl.cod_selec" & _
        "t"
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
        Me.Panel4.Size = New System.Drawing.Size(952, 45)
        Me.Panel4.TabIndex = 9
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(752, 8)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 210
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
        'FrmEndOfDayOutsidePurchasesSales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(952, 410)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayOutsidePurchasesSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outside Purchases Sales"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayOutsidePurchasesSales1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_dtl.SelectCommand.CommandText = DAservice_center_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY service_center_head.id_service_center"
        DAservice_center_dtl.Fill(DsFrmEndOfDayOutsidePurchasesSales1.service_center_dtl)
        DsFrmEndOfDayOutsidePurchasesSales1.service_center_dtl.Columns("GrProfitAmount").Expression = "Ext_Price - ExtCost"
        'DsFrmEndOfDayOutsidePurchasesSales1.service_center_dtl.Columns("GrProfitPercent").Expression = "(GrProfitAmount/Ext_Price)*100"

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

    'Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
    '    Dim prn1 As New CommonClass.ClsPrintGrid
    '    prn1.PrintThisGrid(GridEX1)
    'End Sub
End Class
