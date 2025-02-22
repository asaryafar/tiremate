Imports CommonClass
Public Class FrmShowPaymentDetail
    Inherits FrmBase
    Public Id_service_centerVar As String
    Public Refer_typeVar As String
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DsFrmShowPaymentDetail1 As DSFrmShowPaymentDetail
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmShowPaymentDetail1 = New WorkOrderUtility.DSFrmShowPaymentDetail
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmShowPaymentDetail1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_payment_deposit.refrence_no, GL_payment_deposit.payment_type, GL_paymen" & _
        "t_deposit.payment_amount, GL_payment_deposit.flag_deposit_bank, GL_payment_depos" & _
        "it.id_GL_journal, GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date FROM GL_paym" & _
        "ent_deposit INNER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payme" & _
        "nt_AR.ID_payment WHERE (GL_payment_deposit.id_service_center = @id_service_cente" & _
        "r) AND (GL_payment_deposit.payment_type = '4') AND (GL_payment_deposit.refer_typ" & _
        "e = '1') ORDER BY dbo.ChangeDate(GL_payment_AR.AR_due_date)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=armandehxp;persi" & _
        "st security info=True;initial catalog=TireMate_04"
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "GL_payment_deposit"
        Me.GridEX1.DataSource = Me.DsFrmShowPaymentDetail1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_deposit</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""AR_due_date""><Caption>Due Date</Caption><DataMember>AR_" & _
        "due_date</DataMember><Key>AR_due_date</Key><Position>0</Position><Selectable>Fal" & _
        "se</Selectable></Column0><Column1 ID=""payment_amount""><Caption>Amount</Caption><" & _
        "DataMember>payment_amount</DataMember><FormatString>c2</FormatString><Key>paymen" & _
        "t_amount</Key><Position>1</Position><Selectable>False</Selectable><TextAlignment" & _
        ">Far</TextAlignment><Width>91</Width></Column1></Columns><GroupCondition ID="""" /" & _
        "><Key>GL_payment_deposit</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(214, 266)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmShowPaymentDetail1
        '
        Me.DsFrmShowPaymentDetail1.DataSetName = "DSFrmShowPaymentDetail"
        Me.DsFrmShowPaymentDetail1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'FrmShowPaymentDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(214, 266)
        Me.Controls.Add(Me.GridEX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmShowPaymentDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Detail"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmShowPaymentDetail1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmShowPaymentDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DsFrmShowPaymentDetail1.Clear()
        DAGL_payment_deposit.SelectCommand.Parameters("@Id_service_center").Value = Id_service_centerVar
        DAGL_payment_deposit.Fill(DsFrmShowPaymentDetail1, "GL_payment_deposit")
    End Sub
End Class
