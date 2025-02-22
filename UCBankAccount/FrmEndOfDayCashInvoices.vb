Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayCashInvoices
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
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_cash As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayCashInvoices1 As UCBankAccount.DSFrmEndOfDayCashInvoices
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayCashInvoices))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayCashInvoices1 = New UCBankAccount.DSFrmEndOfDayCashInvoices
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_cash = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayCashInvoices1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_payment_cash"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayCashInvoices1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_cash</Caption><Columns Collectio" & _
        "n=""true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><DataMem" & _
        "ber>id_service_center</DataMember><Key>id_service_center</Key><Position>0</Posit" & _
        "ion><Width>88</Width></Column0><Column1 ID=""date_refer""><Caption>Date</Caption><" & _
        "DataMember>date_refer</DataMember><Key>date_refer</Key><Position>1</Position><Wi" & _
        "dth>72</Width></Column1><Column2 ID=""Total""><Caption>Total Amount</Caption><Data" & _
        "Member>Total</DataMember><FormatString>c</FormatString><Key>Total</Key><Position" & _
        ">2</Position><TextAlignment>Far</TextAlignment><Width>83</Width></Column2><Colum" & _
        "n3 ID=""cash_rendered""><Caption>Cash Rendered</Caption><DataMember>cash_rendered<" & _
        "/DataMember><FormatString>c</FormatString><Key>cash_rendered</Key><Position>3</P" & _
        "osition><TextAlignment>Far</TextAlignment><Width>88</Width></Column3><Column4 ID" & _
        "=""change_due""><Caption>Change Due</Caption><DataMember>change_due</DataMember><F" & _
        "ormatString>c</FormatString><Key>change_due</Key><Position>4</Position><TextAlig" & _
        "nment>Far</TextAlignment><Width>74</Width></Column4><Column5 ID=""fullname""><Capt" & _
        "ion>Customr Name</Caption><DataMember>fullname</DataMember><EditType>NoEdit</Edi" & _
        "tType><Key>fullname</Key><Position>5</Position><Width>186</Width></Column5><Colu" & _
        "mn6 ID=""abbreviation_name""><Caption>Company</Caption><DataMember>abbreviation_na" & _
        "me</DataMember><Key>abbreviation_name</Key><Position>6</Position></Column6></Col" & _
        "umns><GroupCondition ID="""" /><Key>GL_payment_cash</Key></RootTable></GridEXLayou" & _
        "tData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 319)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayCashInvoices1
        '
        Me.DsFrmEndOfDayCashInvoices1.DataSetName = "DSFrmEndOfDayCashInvoices"
        Me.DsFrmEndOfDayCashInvoices1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABI;packet size=4096;user id=sa;integrated security=SSPI;data s" & _
        "ource=""."";persist security info=False;initial catalog=TireMate_01"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, ser" & _
        "vice_center_head.Total, GL_payment_cash.cash_rendered, GL_payment_cash.change_du" & _
        "e, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main" & _
        ".l_name AS fullname, cust_company.abbreviation_name FROM GL_payment_cash INNER J" & _
        "OIN GL_payment_deposit ON GL_payment_cash.ID_payment = GL_payment_deposit.ID_pay" & _
        "ment INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = se" & _
        "rvice_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center" & _
        "_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company O" & _
        "N cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_payment_cash
        '
        Me.DAGL_payment_cash.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_payment_cash.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_cash", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("cash_rendered", "cash_rendered"), New System.Data.Common.DataColumnMapping("change_due", "change_due")})})
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
        Me.Panel4.TabIndex = 5
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(512, 7)
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
        'FrmEndOfDayCashInvoices
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 364)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayCashInvoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Invoices"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayCashInvoices1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_payment_cash.SelectCommand.CommandText = DAGL_payment_cash.SelectCommand.CommandText & WhereClauseVar & " ORDER BY service_center_head.id_service_center"
        DAGL_payment_cash.Fill(DsFrmEndOfDayCashInvoices1.GL_payment_cash)

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
