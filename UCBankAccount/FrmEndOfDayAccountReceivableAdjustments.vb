Imports CommonClass
Public Class FrmEndOfDayAccountReceivableAdjustments
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
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayAccountReceivableAdjustments1 As UCBankAccount.DSFrmEndOfDayAccountReceivableAdjustments
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayAccountReceivableAdjustments))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayAccountReceivableAdjustments1 = New UCBankAccount.DSFrmEndOfDayAccountReceivableAdjustments
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayAccountReceivableAdjustments1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_account_adjustment_dtl"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayAccountReceivableAdjustments1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_AR</Caption><Columns Collection=" & _
        """true""><Column0 ID=""refrence_no""><Caption>Reference No</Caption><DataMember>refr" & _
        "ence_no</DataMember><EditType>NoEdit</EditType><Key>refrence_no</Key><Position>0" & _
        "</Position></Column0><Column1 ID=""id_service_center""><Caption>Invoice No</Captio" & _
        "n><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyString" & _
        "Value /><DataMember>id_service_center</DataMember><Key>id_service_center</Key><P" & _
        "osition>1</Position><Width>87</Width></Column1><Column2 ID=""date_refer""><Caption" & _
        ">Date</Caption><DataMember>date_adjustment</DataMember><Key>date_refer</Key><Pos" & _
        "ition>2</Position><Width>74</Width></Column2><Column3 ID=""Total""><Caption>Adj. A" & _
        "mount</Caption><DataMember>amount_adjustment</DataMember><FormatString>c</Format" & _
        "String><Key>Total</Key><Position>3</Position><TextAlignment>Far</TextAlignment><" & _
        "Width>93</Width></Column3><Column4 ID=""fullname""><Caption>Customer Name</Caption" & _
        "><DataMember>fullname</DataMember><EditType>NoEdit</EditType><Key>fullname</Key>" & _
        "<Position>4</Position><Width>189</Width></Column4><Column5 ID=""abbreviation_name" & _
        """><Caption>Company</Caption><DataMember>abbreviation_name</DataMember><Key>abbre" & _
        "viation_name</Key><Position>5</Position><Width>150</Width></Column5></Columns><G" & _
        "roupCondition ID="""" /><Key>GL_payment_AR</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 44)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 344)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayAccountReceivableAdjustments1
        '
        Me.DsFrmEndOfDayAccountReceivableAdjustments1.DataSetName = "DSFrmEndOfDayAccountReceivableAdjustments"
        Me.DsFrmEndOfDayAccountReceivableAdjustments1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_account_adjustment_dtl.refrence_no, GL_account_adjustment_dtl.id_servic" & _
        "e_center, GL_account_adjustment_dtl.amount_adjustment, GL_account_adjustment_hea" & _
        "d.date_adjustment, GL_account_adjustment_head.cod_customer, cust_trtab_main.f_na" & _
        "me + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cu" & _
        "st_company.abbreviation_name FROM GL_account_adjustment_dtl LEFT OUTER JOIN GL_a" & _
        "ccount_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adj" & _
        "ustment_head.refrence_no LEFT OUTER JOIN cust_trtab_main ON GL_account_adjustmen" & _
        "t_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company " & _
        "ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAGL_account_adjustment_dtl
        '
        Me.DAGL_account_adjustment_dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_account_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment")})})
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
        Me.Panel4.TabIndex = 9
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
        'FrmEndOfDayAccountReceivableAdjustments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 388)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayAccountReceivableAdjustments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Receivable Adjustments"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayAccountReceivableAdjustments1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_account_adjustment_dtl.SelectCommand.CommandText = DAGL_account_adjustment_dtl.SelectCommand.CommandText & WhereClauseVar & " ORDER BY GL_account_adjustment_dtl.refrence_no"
        DAGL_account_adjustment_dtl.Fill(DsFrmEndOfDayAccountReceivableAdjustments1.GL_account_adjustment_dtl)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
End Class
