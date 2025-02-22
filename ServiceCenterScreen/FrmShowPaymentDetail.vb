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
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DsFrmShowPaymentDetail1 As ServiceCenterScreen.DSFrmShowPaymentDetail
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmShowPaymentDetail1 = New ServiceCenterScreen.DSFrmShowPaymentDetail
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
        "r) AND (GL_payment_deposit.payment_type = '4') ORDER BY dbo.ChangeDate(GL_paymen" & _
        "t_AR.AR_due_date)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=KETABIE;persist se" & _
        "curity info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount, flag_deposit_bank, id_GL_journal) VALUES (@id_service_ce" & _
        "nter, @refrence_no, @refer_type, @payment_type, @payment_amount, @flag_deposit_b" & _
        "ank, @id_GL_journal); SELECT ID_payment, id_service_center, refrence_no, refer_t" & _
        "ype, payment_type, payment_amount, flag_deposit_bank, id_GL_journal FROM GL_paym" & _
        "ent_deposit WHERE (ID_payment = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@flag_deposit_bank", System.Data.SqlDbType.Bit, 1, "flag_deposit_bank"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount, flag_deposit_bank = @flag_deposit_bank, id_GL_journal" & _
        " = @id_GL_journal WHERE (ID_payment = @Original_ID_payment) AND (flag_deposit_ba" & _
        "nk = @Original_flag_deposit_bank OR @Original_flag_deposit_bank IS NULL AND flag" & _
        "_deposit_bank IS NULL) AND (id_GL_journal = @Original_id_GL_journal OR @Original" & _
        "_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_service_center = @Orig" & _
        "inal_id_service_center OR @Original_id_service_center IS NULL AND id_service_cen" & _
        "ter IS NULL) AND (payment_amount = @Original_payment_amount OR @Original_payment" & _
        "_amount IS NULL AND payment_amount IS NULL) AND (payment_type = @Original_paymen" & _
        "t_type OR @Original_payment_type IS NULL AND payment_type IS NULL) AND (refer_ty" & _
        "pe = @Original_refer_type OR @Original_refer_type IS NULL AND refer_type IS NULL" & _
        ") AND (refrence_no = @Original_refrence_no OR @Original_refrence_no IS NULL AND " & _
        "refrence_no IS NULL); SELECT ID_payment, id_service_center, refrence_no, refer_t" & _
        "ype, payment_type, payment_amount, flag_deposit_bank, id_GL_journal FROM GL_paym" & _
        "ent_deposit WHERE (ID_payment = @ID_payment)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@flag_deposit_bank", System.Data.SqlDbType.Bit, 1, "flag_deposit_bank"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_flag_deposit_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "flag_deposit_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_payment_deposit WHERE (ID_payment = @Original_ID_payment) AND (fla" & _
        "g_deposit_bank = @Original_flag_deposit_bank OR @Original_flag_deposit_bank IS N" & _
        "ULL AND flag_deposit_bank IS NULL) AND (id_GL_journal = @Original_id_GL_journal " & _
        "OR @Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_service_ce" & _
        "nter = @Original_id_service_center OR @Original_id_service_center IS NULL AND id" & _
        "_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR @Orig" & _
        "inal_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type = @Ori" & _
        "ginal_payment_type OR @Original_payment_type IS NULL AND payment_type IS NULL) A" & _
        "ND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND refer_" & _
        "type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refrence_no " & _
        "IS NULL AND refrence_no IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_flag_deposit_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "flag_deposit_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_payment_deposit.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        Me.DAGL_payment_deposit.UpdateCommand = Me.SqlUpdateCommand1
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
