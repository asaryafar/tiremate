Imports CommonClass
Public Class FrmEndOfDayCheckOtherReceipts
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
    Friend WithEvents DAGL_Paid_received As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayCashOtherReceipts1 As UCBankAccount.DSFrmEndOfDayCashOtherReceipts
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayCheckOtherReceipts))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayCashOtherReceipts1 = New UCBankAccount.DSFrmEndOfDayCashOtherReceipts
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_Paid_received = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayCashOtherReceipts1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_Paid_received"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayCashOtherReceipts1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_Paid_received</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""refrence_code""><Caption>Refrence No</Caption><TypeNameEmp" & _
        "tyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataM" & _
        "ember>refrence_code</DataMember><Key>refrence_code</Key><Position>0</Position><W" & _
        "idth>83</Width></Column0><Column1 ID=""action_date""><Caption>Date</Caption><DataM" & _
        "ember>action_date</DataMember><Key>action_date</Key><Position>1</Position><Width" & _
        ">73</Width></Column1><Column2 ID=""amount""><Caption>Cash Other Rec.</Caption><Dat" & _
        "aMember>amount</DataMember><FormatString>c</FormatString><Key>amount</Key><Posit" & _
        "ion>2</Position><TextAlignment>Far</TextAlignment></Column2><Column3 ID=""fullnam" & _
        "e""><Caption>Customer Name</Caption><DataMember>fullname</DataMember><EditType>No" & _
        "Edit</EditType><Key>fullname</Key><Position>3</Position><Width>206</Width></Colu" & _
        "mn3><Column4 ID=""abbreviation_name""><Caption>Company</Caption><DataMember>abbrev" & _
        "iation_name</DataMember><Key>abbreviation_name</Key><Position>4</Position><Width" & _
        ">167</Width></Column4></Columns><GroupCondition ID="""" /><Key>GL_Paid_received</K" & _
        "ey></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 40)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(654, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayCashOtherReceipts1
        '
        Me.DsFrmEndOfDayCashOtherReceipts1.DataSetName = "DSFrmEndOfDayCashOtherReceipts"
        Me.DsFrmEndOfDayCashOtherReceipts1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_m" & _
        "ain.l_name AS fullname, cust_company.abbreviation_name, GL_Paid_received.refrenc" & _
        "e_code, GL_Paid_received.action_date, GL_Paid_received.amount FROM GL_Paid_recei" & _
        "ved INNER JOIN cust_trtab_main ON GL_Paid_received.customer_code = cust_trtab_ma" & _
        "in.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cu" & _
        "st_company.cod_company"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_Paid_received
        '
        Me.DAGL_Paid_received.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_Paid_received.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("Id_GL_journal", "Id_GL_journal"), New System.Data.Common.DataColumnMapping("OtherReceipType", "OtherReceipType"), New System.Data.Common.DataColumnMapping("Id_debit_deposit_head", "Id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center")})})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcPrintGrid1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(654, 45)
        Me.Panel4.TabIndex = 8
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(452, 8)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
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
        'FrmEndOfDayCheckOtherReceipts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(654, 388)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayCheckOtherReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Other Receipts"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayCashOtherReceipts1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCheckInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_Paid_received.SelectCommand.CommandText = DAGL_Paid_received.SelectCommand.CommandText & WhereClauseVar & " ORDER BY GL_Paid_received.refrence_code"
        DAGL_Paid_received.Fill(DsFrmEndOfDayCashOtherReceipts1.GL_Paid_received)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
End Class
