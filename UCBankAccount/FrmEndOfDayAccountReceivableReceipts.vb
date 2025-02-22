Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayAccountReceivableReceipts
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
    Friend WithEvents DAGl_receive_payment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayAccountReceivableReceipts1 As UCBankAccount.DSFrmEndOfDayAccountReceivableReceipts
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayAccountReceivableReceipts))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayAccountReceivableReceipts1 = New UCBankAccount.DSFrmEndOfDayAccountReceivableReceipts
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGl_receive_payment = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayAccountReceivableReceipts1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "Gl_receive_payment"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayAccountReceivableReceipts1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Gl_receive_payment</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""refrence_no""><Caption>Refrence No</Caption><TypeNameEmp" & _
        "tyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataM" & _
        "ember>refrence_no</DataMember><Key>refrence_no</Key><Position>0</Position><Width" & _
        ">78</Width></Column0><Column1 ID=""date_receive_payment""><Caption>Date</Caption><" & _
        "DataMember>date_receive_payment</DataMember><Key>date_receive_payment</Key><Posi" & _
        "tion>1</Position><Width>71</Width></Column1><Column2 ID=""amount_receive""><Aggreg" & _
        "ateFunction>Sum</AggregateFunction><Caption>Amount Rcvd.</Caption><DataMember>am" & _
        "ount_receive</DataMember><EditType>NoEdit</EditType><FormatString>c</FormatStrin" & _
        "g><Key>amount_receive</Key><Position>2</Position><TextAlignment>Far</TextAlignme" & _
        "nt><Width>80</Width><TotalFormatString>c2</TotalFormatString></Column2><Column3 " & _
        "ID=""pmt_method""><Caption>pmt_method</Caption><DataMember>pmt_method</DataMember>" & _
        "<Key>pmt_method</Key><Position>3</Position></Column3><Column4 ID=""fullname""><Cap" & _
        "tion>Customer Name</Caption><DataMember>fullname</DataMember><EditType>NoEdit</E" & _
        "ditType><Key>fullname</Key><Position>4</Position><Width>166</Width></Column4><Co" & _
        "lumn5 ID=""abbreviation_name""><Caption>Company</Caption><DataMember>abbreviation_" & _
        "name</DataMember><Key>abbreviation_name</Key><Position>5</Position><Width>193</W" & _
        "idth></Column5></Columns><GroupCondition ID="""" /><Key>Gl_receive_payment</Key></" & _
        "RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 44)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 304)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmEndOfDayAccountReceivableReceipts1
        '
        Me.DsFrmEndOfDayAccountReceivableReceipts1.DataSetName = "DSFrmEndOfDayAccountReceivableReceipts"
        Me.DsFrmEndOfDayAccountReceivableReceipts1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Gl_receive_payment.refrence_no, cust_trtab_main.f_name + ' ' + cust_trtab_" & _
        "main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cust_company.abbreviatio" & _
        "n_name, Gl_receive_payment.amount_receive, Gl_receive_payment.date_receive_payme" & _
        "nt, CASE Pmt_Method WHEN '1' THEN 'Cash' WHEN '2' THEN 'CHECK' WHEN '3' THEN 'Cr" & _
        "edit' END AS Pmt_Method FROM Gl_receive_payment LEFT OUTER JOIN cust_trtab_main " & _
        "ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOI" & _
        "N cust_company ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGl_receive_payment
        '
        Me.DAGl_receive_payment.SelectCommand = Me.SqlSelectCommand2
        Me.DAGl_receive_payment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Gl_receive_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_receive", "amount_receive"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("pmt_method", "pmt_method"), New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_no", "cc_no"), New System.Data.Common.DataColumnMapping("Gl_account", "Gl_account"), New System.Data.Common.DataColumnMapping("date_receive_payment", "date_receive_payment"), New System.Data.Common.DataColumnMapping("check_no", "check_no"), New System.Data.Common.DataColumnMapping("expir_date_year", "expir_date_year"), New System.Data.Common.DataColumnMapping("expir_date_month", "expir_date_month")})})
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
        Me.UcPrintGrid1.Location = New System.Drawing.Point(512, 8)
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
        'FrmEndOfDayAccountReceivableReceipts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 348)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayAccountReceivableReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Receivable Receipts"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayAccountReceivableReceipts1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGl_receive_payment.SelectCommand.CommandText = DAGl_receive_payment.SelectCommand.CommandText & WhereClauseVar & " ORDER BY Gl_receive_payment.refrence_no"
        DAGl_receive_payment.Fill(DsFrmEndOfDayAccountReceivableReceipts1.Gl_receive_payment)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmReceivePayment As New UCCustomer.FrmReceivePayment
            MyFrmReceivePayment.Refrence_NoForShowReadOnly = Currentrow.Cells("refrence_no").Value & ""
            MyFrmReceivePayment.StartPosition = FormStartPosition.CenterScreen
            MyFrmReceivePayment.Show()
        End If
    End Sub
End Class
