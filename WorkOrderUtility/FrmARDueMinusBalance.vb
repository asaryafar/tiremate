Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmARDueMinusBalance
    Inherits FrmBase
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DsFrmARDueMinusBalance1 As WorkOrderUtility.DSFrmARDueMinusBalance
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmARDueMinusBalance))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmARDueMinusBalance1 = New WorkOrderUtility.DSFrmARDueMinusBalance
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmARDueMinusBalance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmARDueMinusBalance1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Reference No.</Caption><Typ" & _
        "eNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue " & _
        "/><DataMember>id_service_center</DataMember><Key>id_service_center</Key><Positio" & _
        "n>0</Position><Width>85</Width></Column0><Column1 ID=""date_refer""><Caption>Date<" & _
        "/Caption><DataMember>date_refer</DataMember><Key>date_refer</Key><Position>1</Po" & _
        "sition><Width>73</Width></Column1><Column2 ID=""cod_customer""><Caption>Customer</" & _
        "Caption><DataMember>cod_customer</DataMember><Key>cod_customer</Key><Position>2<" & _
        "/Position><Width>75</Width></Column2><Column3 ID=""fullname""><Caption>Name</Capti" & _
        "on><DataMember>fullname</DataMember><EditType>NoEdit</EditType><Key>fullname</Ke" & _
        "y><Position>3</Position><Width>92</Width></Column3><Column4 ID=""abbreviation_nam" & _
        "e""><Caption>Company</Caption><DataMember>abbreviation_name</DataMember><EditType" & _
        ">NoEdit</EditType><Key>abbreviation_name</Key><Position>4</Position><Width>118</" & _
        "Width></Column4><Column5 ID=""Total""><AggregateFunction>Sum</AggregateFunction><C" & _
        "aption>Original Amount</Caption><DataMember>Total</DataMember><FormatString>c2</" & _
        "FormatString><Key>Total</Key><Position>5</Position><TextAlignment>Far</TextAlign" & _
        "ment><Width>93</Width><TotalFormatString>c2</TotalFormatString></Column5><Column" & _
        "6 ID=""AmountDue""><Caption>Amount Due</Caption><DataMember>AmountDue</DataMember>" & _
        "<EditType>NoEdit</EditType><FormatString>c2</FormatString><Key>AmountDue</Key><P" & _
        "osition>6</Position><Width>81</Width></Column6><Column7 ID=""AR_due_date""><Captio" & _
        "n>Due Date</Caption><DataMember>AR_due_date</DataMember><EditType>NoEdit</EditTy" & _
        "pe><Key>AR_due_date</Key><Position>7</Position><Width>75</Width></Column7></Colu" & _
        "mns><GroupCondition ID="""" /><Key>service_center_dtl</Key></RootTable></GridEXLay" & _
        "outData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 45)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 359)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmARDueMinusBalance1
        '
        Me.DsFrmARDueMinusBalance1.DataSetName = "DSFrmARDueMinusBalance"
        Me.DsFrmARDueMinusBalance1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=TireMate_04;password=2191110"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT service_center_head.id_service_center, service_center_head.date_r" & _
        "efer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_m" & _
        "ain.l_name AS fullname, cust_company.abbreviation_name, GL_payment_deposit.payme" & _
        "nt_amount AS Total, View_Invoice_Balance_ForEach_ARDue.BalanceAmount AS AmountDu" & _
        "e, GL_payment_AR.AR_due_date, GL_payment_deposit.ID_payment, dbo.ChangeDate(GL_p" & _
        "ayment_AR.AR_due_date) AS orderDate, service_center_head.cod_customer FROM GL_pa" & _
        "yment_deposit INNER JOIN GL_TAB_AR_TERM INNER JOIN GL_payment_AR ON GL_TAB_AR_TE" & _
        "RM.AR_terms = GL_payment_AR.AR_terms ON GL_payment_deposit.ID_payment = GL_payme" & _
        "nt_AR.ID_payment INNER JOIN service_center_head ON GL_payment_deposit.id_service" & _
        "_center = service_center_head.id_service_center INNER JOIN View_Invoice_Balance_" & _
        "ForEach_ARDue ON GL_payment_deposit.ID_payment = View_Invoice_Balance_ForEach_AR" & _
        "Due.ID_payment INNER JOIN cust_trtab_main ON service_center_head.cod_customer = " & _
        "cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod" & _
        "_company = cust_company.cod_company WHERE (service_center_head.type_of_form = 'I" & _
        "N') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_ty" & _
        "pe = '4') AND (GL_payment_AR.Cancel_flag = 0) AND (View_Invoice_Balance_ForEach_" & _
        "ARDue.BalanceAmount < 0) ORDER BY service_center_head.id_service_center, orderDa" & _
        "te"
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
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(718, 45)
        Me.Panel4.TabIndex = 6
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
        'FrmARDueMinusBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 404)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmARDueMinusBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AR Due With Minus Balance"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmARDueMinusBalance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_dtl.SelectCommand.CommandText = DAservice_center_dtl.SelectCommand.CommandText
        DAservice_center_dtl.Fill(DsFrmARDueMinusBalance1.service_center_dtl)
    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
            MyFrmShowWorkOrder.TypeOfForm = "IN"
            MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
            MyFrmShowWorkOrder.Show()
        End If
    End Sub
End Class
