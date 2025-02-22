Imports CommonClass
Public Class FrmEndOfDayAccountReceivableCredits
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
    Friend WithEvents DsFrmEndOfDayAccountReceivableCredits1 As UCBankAccount.DSFrmEndOfDayAccountReceivableCredits
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayAccountReceivableCredits))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayAccountReceivableCredits1 = New UCBankAccount.DSFrmEndOfDayAccountReceivableCredits
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayAccountReceivableCredits1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_payment_deposit"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayAccountReceivableCredits1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_Paid_received</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""refrence_code""><Caption>Refrence No</Caption><TypeNameEmp" & _
        "tyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataM" & _
        "ember>id_service_center</DataMember><Key>refrence_code</Key><Position>0</Positio" & _
        "n><Width>80</Width></Column0><Column1 ID=""action_date""><Caption>Date</Caption><D" & _
        "ataMember>date_refer</DataMember><Key>action_date</Key><Position>1</Position><Wi" & _
        "dth>78</Width></Column1><Column2 ID=""Total""><Caption>Total Amount</Caption><Data" & _
        "Member>Total</DataMember><FormatString>c</FormatString><Key>Total</Key><Position" & _
        ">2</Position><TextAlignment>Far</TextAlignment><Width>92</Width></Column2><Colum" & _
        "n3 ID=""amount""><Caption>Credit Returned</Caption><DataMember>payment_amount</Dat" & _
        "aMember><FormatString>c</FormatString><Key>amount</Key><Position>3</Position><Te" & _
        "xtAlignment>Far</TextAlignment><Width>91</Width></Column3><Column4 ID=""fullname""" & _
        "><Caption>Customer Name</Caption><DataMember>fullname</DataMember><EditType>NoEd" & _
        "it</EditType><Key>fullname</Key><Position>4</Position><Width>212</Width></Column" & _
        "4><Column5 ID=""abbreviation_name""><Caption>Company</Caption><DataMember>abbrevia" & _
        "tion_name</DataMember><Key>abbreviation_name</Key><Position>5</Position><Width>1" & _
        "40</Width></Column5></Columns><GroupCondition ID="""" /><Key>GL_Paid_received</Key" & _
        "></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 40)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayAccountReceivableCredits1
        '
        Me.DsFrmEndOfDayAccountReceivableCredits1.DataSetName = "DSFrmEndOfDayAccountReceivableCredits"
        Me.DsFrmEndOfDayAccountReceivableCredits1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_payment_deposit.id_service_center, GL_payment_deposit.payment_amount, c" & _
        "ust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_n" & _
        "ame AS fullname, cust_company.abbreviation_name, service_center_head.Total, serv" & _
        "ice_center_head.date_refer FROM GL_payment_deposit INNER JOIN service_center_hea" & _
        "d ON GL_payment_deposit.id_service_center = service_center_head.id_service_cente" & _
        "r INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_ma" & _
        "in.cod_customer INNER JOIN cust_company ON cust_trtab_main.cod_company = cust_co" & _
        "mpany.cod_company"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
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
        Me.Panel4.Size = New System.Drawing.Size(718, 45)
        Me.Panel4.TabIndex = 10
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(513, 8)
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
        'FrmEndOfDayAccountReceivableCredits
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 388)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayAccountReceivableCredits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Receivable Credits"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayAccountReceivableCredits1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_payment_deposit.SelectCommand.CommandText = DAGL_payment_deposit.SelectCommand.CommandText & WhereClauseVar & " ORDER BY GL_payment_deposit.id_service_center "
        DAGL_payment_deposit.Fill(DsFrmEndOfDayAccountReceivableCredits1.GL_payment_deposit)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
End Class
