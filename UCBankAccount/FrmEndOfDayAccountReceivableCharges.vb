Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEndOfDayAccountReceivableCharges
    Inherits FrmBase
    Public WhereClauseVar As String
    Public FormHeaderVar As String
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
    Friend WithEvents DAGL_payment_AR As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayAccountReceivableCharges1 As UCBankAccount.DSFrmEndOfDayAccountReceivableCharges
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayAccountReceivableCharges))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayAccountReceivableCharges1 = New UCBankAccount.DSFrmEndOfDayAccountReceivableCharges
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_AR = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayAccountReceivableCharges1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_payment_AR"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayAccountReceivableCharges1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_AR</Caption><Columns Collection=" & _
        """true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><TypeNameE" & _
        "mptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Dat" & _
        "aMember>id_service_center</DataMember><Key>id_service_center</Key><Position>0</P" & _
        "osition><Width>87</Width></Column0><Column1 ID=""date_refer""><Caption>Date</Capti" & _
        "on><DataMember>date_refer</DataMember><Key>date_refer</Key><Position>1</Position" & _
        "><Width>74</Width></Column1><Column2 ID=""Total""><Caption>Total Amount</Caption><" & _
        "DataMember>Total</DataMember><FormatString>c</FormatString><Key>Total</Key><Posi" & _
        "tion>2</Position><TextAlignment>Far</TextAlignment><Width>86</Width></Column2><C" & _
        "olumn3 ID=""payment_amount""><Caption>A/R Amount</Caption><DataMember>payment_amou" & _
        "nt</DataMember><FormatString>c</FormatString><Key>payment_amount</Key><Position>" & _
        "3</Position><TextAlignment>Far</TextAlignment><Width>79</Width></Column3><Column" & _
        "4 ID=""AR_due_date""><Caption>Due Date</Caption><DataMember>AR_due_date</DataMembe" & _
        "r><Key>AR_due_date</Key><Position>4</Position><Width>76</Width></Column4><Column" & _
        "5 ID=""fullname""><Caption>Customer Name</Caption><DataMember>fullname</DataMember" & _
        "><EditType>NoEdit</EditType><Key>fullname</Key><Position>5</Position><Width>162<" & _
        "/Width></Column5><Column6 ID=""abbreviation_name""><Caption>Company</Caption><Data" & _
        "Member>abbreviation_name</DataMember><Key>abbreviation_name</Key><Position>6</Po" & _
        "sition><Width>130</Width></Column6></Columns><GroupCondition ID="""" /><Key>GL_pay" & _
        "ment_AR</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 44)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 304)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayAccountReceivableCharges1
        '
        Me.DsFrmEndOfDayAccountReceivableCharges1.DataSetName = "DSFrmEndOfDayAccountReceivableCharges"
        Me.DsFrmEndOfDayAccountReceivableCharges1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_payment_AR.AR_due_date, service_center_head.id_service_center, service_" & _
        "center_head.date_refer, service_center_head.Total, GL_payment_deposit.payment_am" & _
        "ount, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_m" & _
        "ain.l_name AS fullname, cust_company.abbreviation_name FROM GL_payment_AR INNER " & _
        "JOIN GL_payment_deposit ON GL_payment_AR.ID_payment = GL_payment_deposit.ID_paym" & _
        "ent INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = ser" & _
        "vice_center_head.id_service_center LEFT OUTER JOIN cust_trtab_main ON service_ce" & _
        "nter_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_compa" & _
        "ny ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAGL_payment_AR
        '
        Me.DAGL_payment_AR.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_payment_AR.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_AR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("AR_due_date", "AR_due_date")})})
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
        'FrmEndOfDayAccountReceivableCharges
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 348)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayAccountReceivableCharges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Receivable Charges"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayAccountReceivableCharges1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_payment_AR.SelectCommand.CommandText = DAGL_payment_AR.SelectCommand.CommandText & WhereClauseVar & " ORDER BY service_center_head.id_service_center"
        DAGL_payment_AR.Fill(DsFrmEndOfDayAccountReceivableCharges1.GL_payment_AR)
        Me.Text = FormHeaderVar

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
