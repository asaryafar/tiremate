Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayTotalReturns
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
    Friend WithEvents DAservice_center_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayTotalSales1 As UCBankAccount.DSFrmEndOfDayTotalSales
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayTotalReturns))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayTotalSales1 = New UCBankAccount.DSFrmEndOfDayTotalSales
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayTotalSales1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "service_center_head"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayTotalSales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><Typ" & _
        "eNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue " & _
        "/><DataMember>id_service_center</DataMember><Key>id_service_center</Key><Positio" & _
        "n>0</Position><Width>92</Width></Column0><Column1 ID=""date_refer""><Caption>Date<" & _
        "/Caption><DataMember>date_refer</DataMember><Key>date_refer</Key><Position>1</Po" & _
        "sition><Width>75</Width></Column1><Column2 ID=""tax""><Caption>Sales Tax</Caption>" & _
        "<DataMember>tax</DataMember><FormatString>c2</FormatString><Key>tax</Key><Positi" & _
        "on>2</Position><Width>79</Width></Column2><Column3 ID=""Total""><Caption>Total Amo" & _
        "unt</Caption><DataMember>Total</DataMember><FormatString>c</FormatString><Key>To" & _
        "tal</Key><Position>3</Position><TextAlignment>Far</TextAlignment><Width>87</Widt" & _
        "h></Column3><Column4 ID=""fullname""><Caption>Customer Name</Caption><DataMember>f" & _
        "ullname</DataMember><EditType>NoEdit</EditType><Key>fullname</Key><Position>4</P" & _
        "osition><Width>170</Width></Column4><Column5 ID=""abbreviation_name""><Caption>Com" & _
        "pany</Caption><DataMember>abbreviation_name</DataMember><Key>abbreviation_name</" & _
        "Key><Position>5</Position><Width>125</Width></Column5><Column6 ID=""discount""><Ca" & _
        "ption>Discount %</Caption><DataMember>discount</DataMember><InputMask>Percent2</" & _
        "InputMask><Key>discount</Key><MaskPrompt>&#x0;</MaskPrompt><Position>6</Position" & _
        "><Width>67</Width></Column6></Columns><GroupCondition ID="""" /><Key>service_cente" & _
        "r_head</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayTotalSales1
        '
        Me.DsFrmEndOfDayTotalSales1.DataSetName = "DSFrmEndOfDayTotalSales"
        Me.DsFrmEndOfDayTotalSales1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, ser" & _
        "vice_center_head.tax, service_center_head.Total, service_center_head.discount, c" & _
        "ust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_n" & _
        "ame AS fullname, cust_company.abbreviation_name FROM service_center_head INNER J" & _
        "OIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_cu" & _
        "stomer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_compan" & _
        "y.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAservice_center_head
        '
        Me.DAservice_center_head.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
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
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(520, 8)
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
        'FrmEndOfDayTotalReturns
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 393)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayTotalReturns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Returns"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayTotalSales1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_head.SelectCommand.CommandText = DAservice_center_head.SelectCommand.CommandText & WhereClauseVar & " ORDER BY service_center_head.id_service_center"
        DAservice_center_head.Fill(DsFrmEndOfDayTotalSales1.service_center_head)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
            MyFrmShowWorkOrder.TypeOfForm = "RT"
            MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
            MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
            MyFrmShowWorkOrder.Show()
        End If
    End Sub
End Class
