Imports CommonClass
Public Class FrmUpdateDatabase
    Inherits FrmBase
    Private temp As Integer = 0
    Private Check_NodesFlag As Boolean = True
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents GL_account_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmUpdateDatabase1 As Utility.DSFrmUpdateDatabase
    Friend WithEvents DAGL_payment_depositBedehi As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_depositPardakht As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAGL_payment_depositBedehiCustomer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAView_Adjustment_Balance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UiProgressBar1 As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_debit_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAUpdatePaidAmount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_vehicle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdGeneralLock As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnLock As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_out_purchases_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAService_out_purchases_Dtl_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
   

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUpdateDatabase))
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnOk = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.GL_account_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_depositBedehi = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmUpdateDatabase1 = New Utility.DSFrmUpdateDatabase
        Me.DAGL_payment_depositPardakht = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_depositBedehiCustomer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAView_Adjustment_Balance = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.UiProgressBar1 = New Janus.Windows.EditControls.UIProgressBar
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_debit_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAUpdatePaidAmount = New System.Data.SqlClient.SqlDataAdapter
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_vehicle = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneralLock = New System.Data.SqlClient.SqlCommand
        Me.CnnLock = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAService_out_purchases_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.DAService_out_purchases_Dtl_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand

        Me.Panel2.SuspendLayout()
        CType(Me.DsFrmUpdateDatabase1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(19, 379)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(160, 32)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 48)
        Me.Panel2.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 46)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Update Database"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Location = New System.Drawing.Point(299, 379)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(160, 32)
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "Update"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=sa;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_02"
        '
        'GL_account_adjustment_dtl
        '
        Me.GL_account_adjustment_dtl.SelectCommand = Me.SqlSelectCommand7
        Me.GL_account_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT GL_account_adjustment_dtl.refrence_no, SUM(ROUND(GL_account_adjustment_dtl" & _
        ".amount_adjustment, 2)) AS sum1 FROM GL_account_adjustment_dtl INNER JOIN GL_acc" & _
        "ount_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjus" & _
        "tment_head.refrence_no WHERE (GL_account_adjustment_head.finance_charge_flag = 1" & _
        ") GROUP BY GL_account_adjustment_dtl.refrence_no"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'UiButton1
        '
        Me.UiButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UiButton1.Enabled = False
        Me.UiButton1.Location = New System.Drawing.Point(129, 52)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(199, 24)
        Me.UiButton1.TabIndex = 11
        Me.UiButton1.Text = "Update Old Receive Payments"
        Me.UiButton1.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID_payment, id_service_center, refrence_no, refer_type, payment_type, ROUN" & _
        "D(payment_amount, 2) AS payment_amount, flag_deposit_bank, id_GL_journal, Paid_a" & _
        "mount, Discount, refrence_no_Adjustment, refrence_no_Gl_receive_payment, Downpay" & _
        "ment_Wo_No FROM GL_payment_deposit WHERE (refer_type = '1') AND (payment_type = " & _
        "'4') AND (id_service_center = @id_service_center) ORDER BY refrence_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'DAGL_payment_depositBedehi
        '
        Me.DAGL_payment_depositBedehi.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_payment_depositBedehi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("refrence_no_Gl_receive_payment", "refrence_no_Gl_receive_payment"), New System.Data.Common.DataColumnMapping("Downpayment_Wo_No", "Downpayment_Wo_No")})})
        '
        'DsFrmUpdateDatabase1
        '
        Me.DsFrmUpdateDatabase1.DataSetName = "DSFrmUpdateDatabase"
        Me.DsFrmUpdateDatabase1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAGL_payment_depositPardakht
        '
        Me.DAGL_payment_depositPardakht.SelectCommand = Me.SqlCommand1
        Me.DAGL_payment_depositPardakht.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("refrence_no_Gl_receive_payment", "refrence_no_Gl_receive_payment"), New System.Data.Common.DataColumnMapping("Downpayment_Wo_No", "Downpayment_Wo_No")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT ID_payment, id_service_center, refrence_no, refer_type, payment_type, ROUN" & _
        "D(payment_amount, 2) AS payment_amount, flag_deposit_bank, id_GL_journal, Paid_a" & _
        "mount, Discount, refrence_no_Adjustment, refrence_no_Gl_receive_payment, Downpay" & _
        "ment_Wo_No FROM GL_payment_deposit WHERE (refer_type = '2')"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'DAGL_payment_depositBedehiCustomer
        '
        Me.DAGL_payment_depositBedehiCustomer.SelectCommand = Me.SqlCommand2
        Me.DAGL_payment_depositBedehiCustomer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("refrence_no_Gl_receive_payment", "refrence_no_Gl_receive_payment"), New System.Data.Common.DataColumnMapping("Downpayment_Wo_No", "Downpayment_Wo_No")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, ROUND(GL_payment_deposit.payment_amount, 2) AS payment_amount, GL_pay" & _
        "ment_deposit.flag_deposit_bank, GL_payment_deposit.id_GL_journal, GL_payment_dep" & _
        "osit.Paid_amount, GL_payment_deposit.Discount, GL_payment_deposit.refrence_no_Ad" & _
        "justment, GL_payment_deposit.refrence_no_Gl_receive_payment, GL_payment_deposit." & _
        "Downpayment_Wo_No FROM GL_payment_deposit INNER JOIN service_center_head ON GL_p" & _
        "ayment_deposit.id_service_center = service_center_head.id_service_center WHERE (" & _
        "GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4')" & _
        " AND (service_center_head.cod_customer = @cod_customer)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAView_Adjustment_Balance
        '
        Me.DAView_Adjustment_Balance.SelectCommand = Me.SqlCommand3
        Me.DAView_Adjustment_Balance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("refrence_no_Gl_receive_payment", "refrence_no_Gl_receive_payment"), New System.Data.Common.DataColumnMapping("Downpayment_Wo_No", "Downpayment_Wo_No")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT IDGL_account_adjustment_dtl, refrence_no_due, id_service_center_due, amoun" & _
        "t_adjustment, AR_Paid_amount, Adj_Paid_Amount, BalanceAmount, cod_customer, AR_d" & _
        "ue_date FROM View_Adjustment_Balance WHERE (id_service_center_due = @id_service_" & _
        "center_due)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_due", System.Data.SqlDbType.VarChar, 10, "id_service_center_due"))
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 83)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(456, 266)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = ""
        '
        'UiProgressBar1
        '
        Me.UiProgressBar1.Location = New System.Drawing.Point(12, 353)
        Me.UiProgressBar1.Name = "UiProgressBar1"
        Me.UiProgressBar1.Size = New System.Drawing.Size(455, 23)
        Me.UiProgressBar1.TabIndex = 13
        Me.UiProgressBar1.Text = "UiProgressBar1"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_debit_deposit, id_debit_deposit_head, type_transaction, ID_payment, id_" & _
        "check, id_transfer, id_external_cash, id_ATM, id_adjustment_no, debit_amount, de" & _
        "posit_amount, GL_account, Cleared_bank, Memo FROM GL_debit_deposit WHERE (ID_pay" & _
        "ment = @ID_payment)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'DAGL_debit_deposit
        '
        Me.DAGL_debit_deposit.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_debit_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit", "id_debit_deposit"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_external_cash", "id_external_cash"), New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("id_adjustment_no", "id_adjustment_no"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Cleared_bank", "Cleared_bank"), New System.Data.Common.DataColumnMapping("Memo", "Memo")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT ID_payment, Paid_amount, payment_amount FROM GL_payment_deposit WHERE (ref" & _
        "er_type = '1') AND (payment_type = '4')"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAUpdatePaidAmount
        '
        Me.DAUpdatePaidAmount.SelectCommand = Me.SqlSelectCommand3
        Me.DAUpdatePaidAmount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("refrence_no_Gl_receive_payment", "refrence_no_Gl_receive_payment"), New System.Data.Common.DataColumnMapping("Downpayment_Wo_No", "Downpayment_Wo_No")})})
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbCommand1
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME,0 as Amount  FROM STORE_SETUP ORDER BY STORE" & _
        "NO"
        Me.OleDbCommand1.Connection = Me.CnnMdbSetup
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT refrence_no, id_service_center, amount_adjustment, Old_Amount_adjustment F" & _
        "ROM GL_account_adjustment_dtl"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DaGeneral
        '
        Me.DaGeneral.SelectCommand = Me.SqlSelectCommand4
        Me.DaGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("Old_Amount_adjustment", "Old_Amount_adjustment")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_vehicle, cod_make, cod_model, make_year, options FROM bas_vehicle ORDE" & _
        "R BY cod_vehicle"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAbas_vehicle
        '
        Me.DAbas_vehicle.SelectCommand = Me.SqlSelectCommand5
        Me.DAbas_vehicle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("cod_model", "cod_model"), New System.Data.Common.DataColumnMapping("make_year", "make_year"), New System.Data.Common.DataColumnMapping("options", "options")})})
        '
        'CmdGeneralLock
        '
        Me.CmdGeneralLock.Connection = Me.CnnLock
        '
        'CnnLock
        '
        Me.CnnLock.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_01;password=sa"
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Service_out_purchases_Dtl.IDService_out_purchases_dtl, Service_out_purchas" & _
        "es_Dtl.id_service_center, Service_out_purchases_Dtl.radif, service_out_purchases" & _
        ".cost * service_center_dtl.qty AS Cost, service_out_purchases.AR_terms, service_" & _
        "out_purchases.due_date, Service_out_purchases_Dtl.Due_Date AS Due_Date_dtl FROM " & _
        "Service_out_purchases_Dtl INNER JOIN service_out_purchases ON Service_out_purcha" & _
        "ses_Dtl.id_service_center = service_out_purchases.id_service_center AND Service_" & _
        "out_purchases_Dtl.radif = service_out_purchases.radif LEFT OUTER JOIN service_ce" & _
        "nter_dtl ON service_out_purchases.radif = service_center_dtl.radif AND service_o" & _
        "ut_purchases.id_service_center = service_center_dtl.id_service_center ORDER BY S" & _
        "ervice_out_purchases_Dtl.id_service_center, Service_out_purchases_Dtl.radif"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DAService_out_purchases_Dtl
        '
        Me.DAService_out_purchases_Dtl.SelectCommand = Me.SqlSelectCommand6
        Me.DAService_out_purchases_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Service_out_purchases_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IDService_out_purchases_dtl", "IDService_out_purchases_dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("Due_Date", "Due_Date"), New System.Data.Common.DataColumnMapping("Cost", "Cost")})})
        '
        'DAService_out_purchases_Dtl_dtl
        '
        Me.DAService_out_purchases_Dtl_dtl.SelectCommand = Me.SqlCommand4
        Me.DAService_out_purchases_Dtl_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Service_out_purchases_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IDService_out_purchases_dtl", "IDService_out_purchases_dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("Due_Date", "Due_Date"), New System.Data.Common.DataColumnMapping("Cost", "Cost")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT Service_out_purchases_Dtl.IDService_out_purchases_dtl, Service_out_purchas" & _
        "es_Dtl.id_service_center, Service_out_purchases_Dtl.radif, Service_out_purchases" & _
        "_Dtl.Due_Date, service_out_purchases.cost * service_center_dtl.qty AS Cost, serv" & _
        "ice_out_purchases.AR_terms FROM Service_out_purchases_Dtl INNER JOIN service_out" & _
        "_purchases ON Service_out_purchases_Dtl.id_service_center = service_out_purchase" & _
        "s.id_service_center AND Service_out_purchases_Dtl.radif = service_out_purchases." & _
        "radif LEFT OUTER JOIN service_center_dtl ON service_out_purchases.radif = servic" & _
        "e_center_dtl.radif AND service_out_purchases.id_service_center = service_center_" & _
        "dtl.id_service_center WHERE (Service_out_purchases_Dtl.id_service_center = @id_s" & _
        "ervice_center) AND (Service_out_purchases_Dtl.radif = @radif)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        '
    
        '
        'FrmUpdateDatabase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(478, 415)
        Me.Controls.Add(Me.UiProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UiButton1)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "FrmUpdateDatabase"
        Me.Text = "Update Database"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsFrmUpdateDatabase1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCleanDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        CnnLock.ConnectionString = PConnectionString
        Me.CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables

        DsFrmUpdateDatabase1.Store_Setup.Clear()
        DASTORE_SETUP.Fill(DsFrmUpdateDatabase1, "Store_Setup")
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Dim StoreCounterVar As Integer
        Dim ThisConnectionStringVar As String
        For StoreCounterVar = 0 To DsFrmUpdateDatabase1.Store_Setup.Rows.Count - 1
            ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmUpdateDatabase1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
            If ThisConnectionStringVar.Trim.Length > 0 Then
                If Cnn.State = ConnectionState.Open Then
                    Cnn.Close()
                End If
                Cnn.ConnectionString = ThisConnectionStringVar
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If

                If CnnLock.State = ConnectionState.Open Then
                    CnnLock.Close()
                End If
                CnnLock.ConnectionString = ThisConnectionStringVar
                If CnnLock.State <> ConnectionState.Open Then
                    CnnLock.Open()
                End If

                'Call Fix1()
                'Call fix2()
                'Call fix3()
                'Call fix4()
                'Call fix5()
                'Call Fix6()
                'Call Fix7()
                'Call Fix8()
                'Call Fix9()
                'Call Fix10()
                'Call Fix11()
                'Call Fix12()
                'Call fix13()
                'Call fix14()
                'Call fix15()
                'Call Fix16() ' 
                'Call Fix17()
                'Call Fix18()
                'Call fix19()
                'Call Fix20()
                'Call Fix21()
                'Call Fix22()
                Call Fix23()
                Call Fix24()
            End If
        Next
        If Cnn.State = ConnectionState.Open Then
            Cnn.Close()
        End If
        Cnn.ConnectionString = PConnectionString

        MsgBox("Update Successfully Completed", MsgBoxStyle.Information)
    End Sub
    Private Sub Fix1()
        execit(" CREATE VIEW dbo.View_AllUnPaidService_out_purchase " & _
" AS " & _
" SELECT     TOP 100 PERCENT ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2) AS sumoriginalamount, " & _
"                      ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment, dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif, " & _
"                      dbo.service_out_purchases.due_date " & _
" FROM         dbo.service_out_purchases INNER JOIN " & _
"                      dbo.service_center_dtl ON dbo.service_out_purchases.id_service_center = dbo.service_center_dtl.id_service_center AND  " & _
"                      dbo.service_out_purchases.radif = dbo.service_center_dtl.radif LEFT OUTER JOIN " & _
"                      dbo.GL_AP_payment ON dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
"                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
" GROUP BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif,  " & _
"                      ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2), dbo.service_out_purchases.due_date " & _
" ORDER BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif ", CmdGeneral, False, True, "View_AllUnPaidService_out_purchase")


        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_tab_federal_tax_head ALTER COLUMN social_sec_employee decimal(18, 2) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_tab_federal_tax_head ALTER COLUMN social_sec_employer decimal(18, 2)  "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_tab_federal_tax_head ALTER COLUMN medi_employee decimal(18, 2) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_tab_federal_tax_head ALTER COLUMN medi_employer decimal(18, 2) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_tab_federal_tax_head ALTER COLUMN unemplyment_employee decimal(18, 2) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_tab_federal_tax_head ALTER COLUMN unemplyment_employer decimal(18, 2) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = "INSERT INTO bas_vehicle_company  (cod_make, desc_make, EnterByUser) VALUES     ('0', '', 0)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = "INSERT INTO bas_vehicle_company  (cod_make, desc_make, EnterByUser) VALUES     ('0', '', 0)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = "INSERT INTO bas_vehicle_model (cod_make, cod_model, desc_model, EnterByUser) VALUES     ('0', '0', '', 0)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = "INSERT INTO inv_tab_kind_engine (cod_kind_engine, desc_kind_engine, size_liters, size_cubic_cm) VALUES     ('0', '', '0', '0')"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_vendor_credit ADD id_receive_ref char(6)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        execit(" CREATE VIEW dbo.View_Vendor_Balance " & _
" AS " & _
" SELECT     cod_vendor, " & _
"                          (SELECT     isnull(SUM(isnull(service_out_purchases.cost, 0) + isnull(service_out_purchases.fet, 0)), 0) AS Amount " & _
"                             FROM         service_out_purchases INNER JOIN " & _
"                                                   service_center_head ON service_out_purchases.id_service_center = service_center_head.id_service_center " & _
"                             WHERE     service_center_head.type_of_form = 'IN' AND A.cod_vendor = dbo.service_out_purchases.cod_vendor) + " & _
"                          (SELECT     isnull(SUM(isnull(Inv_Receive_product_Ap_Dtl.amount, 0)), 0) " & _
"                             FROM         Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                                                   Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
"                             WHERE     Inv_Receive_Products_head.bill_credit = 1 AND A.cod_vendor = dbo.Inv_Receive_Products_head.cod_vendor) + " & _
"                          (SELECT     isnull(SUM(isnull(GL_AP_bill_Dtl_Dtl.amount, 0)), 0) AS Sum_Amount " & _
"                             FROM         GL_AP_bill_Dtl_Dtl INNER JOIN " & _
"                                                   GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
"                                                   GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head " & _
"                             WHERE     A.cod_vendor = dbo.GL_AP_Bill_Head.cod_vendor) - " & _
"                          (SELECT     ISNULL(SUM(ROUND(ISNULL(amount_credit, 0), 2)), 0) AS Sum_amount_credit " & _
"                             FROM         GL_vendor_credit " & _
"                             WHERE     A.cod_vendor = dbo.GL_vendor_credit.cod_vendor) - " & _
"                          (SELECT     Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)), 0) " & _
"                             FROM         GL_AP_payment INNER JOIN " & _
"                                                   service_out_purchases ON GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND  " & _
"                                                   GL_AP_payment.radif = service_out_purchases.radif " & _
"                             WHERE     GL_AP_payment.id_check IS NOT NULL AND A.cod_vendor = dbo.service_out_purchases.cod_vendor) - " & _
"                          (SELECT     Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)), 0) " & _
"                             FROM         GL_AP_payment INNER JOIN " & _
"                                                   Inv_Receive_product_Ap_Dtl ON  " & _
"                                                   GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                                                   Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
"                             WHERE     GL_AP_payment.id_check IS NOT NULL AND A.cod_vendor = dbo.Inv_Receive_Products_head.cod_vendor) - " & _
"                          (SELECT     Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)), 0) " & _
"                             FROM         GL_AP_payment INNER JOIN " & _
"                                                   GL_AP_bill_Dtl_Dtl ON GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl INNER JOIN " & _
"                                                   GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
"                                                   GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head " & _
"                             WHERE     GL_AP_payment.id_check IS NOT NULL AND A.cod_vendor = dbo.GL_AP_Bill_Head.cod_vendor) AS BalanceAmount " & _
" FROM         dbo.inv_vendor A " & _
" GROUP BY cod_vendor ", CmdGeneral, False, True, "View_Vendor_Balance")

        Try
            CmdGeneral.CommandText = " ALTER TABLE service_out_purchases ADD PaidFlag bit default 0"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " Update service_out_purchases set PaidFlag=0 where PaidFlag is null"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        execit(" CREATE VIEW dbo.View_Is_chasier_Enterd " & _
" AS " & _
" SELECT     ISNULL(ROUND(SUM(payment_amount), 2), 0) AS sum_amount_pay, id_service_center FROM  dbo.GL_payment_deposit " & _
" GROUP BY id_service_center ", CmdGeneral, False, True, "View_Is_chasier_Enterd")


    End Sub
    Sub fix2()
        Try
            CmdGeneral.CommandText = " ALTER TABLE Inv_Receive_Products_head ADD Prepaid bit default 0"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " Update Inv_Receive_Products_head set Prepaid=0 where  Prepaid is null"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        execit(" CREATE VIEW dbo.View_AllUnPaidGl_Ap_Bill_Dtl_Dtl As  SELECT     dbo.GL_AP_bill_Dtl_Dtl.amount AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment, " & _
        "                      dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, dbo.GL_AP_bill_Dtl_Dtl.due_date, dbo.GL_AP_Bill_Head.cod_vendor " & _
        "FROM         dbo.GL_AP_bill_Dtl INNER JOIN " & _
        "                      dbo.GL_AP_bill_Dtl_Dtl ON dbo.GL_AP_bill_Dtl.Id_AP_bill_dtl = dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl INNER JOIN " & _
        "                      dbo.GL_AP_Bill_Head ON dbo.GL_AP_bill_Dtl.Id_AP_bill_Head = dbo.GL_AP_Bill_Head.Id_AP_bill_Head LEFT OUTER JOIN " & _
        "                      dbo.GL_AP_payment ON dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = dbo.GL_AP_payment.Id_AP_bill_dtl_dtl " & _
        "GROUP BY dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, dbo.GL_AP_bill_Dtl_Dtl.amount, dbo.GL_AP_bill_Dtl_Dtl.due_date, dbo.GL_AP_Bill_Head.cod_vendor ", CmdGeneral, False, True, "View_AllUnPaidGl_Ap_Bill_Dtl_Dtl")


        execit(" CREATE VIEW dbo.View_AllUnPaidService_out_purchase  As SELECT     TOP 100 PERCENT ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2) AS sumoriginalamount, " & _
        "                      ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment, dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif, " & _
        "                      dbo.service_out_purchases.due_date, dbo.service_out_purchases.cod_vendor " & _
        "FROM         dbo.service_out_purchases INNER JOIN " & _
        "                      dbo.service_center_dtl ON dbo.service_out_purchases.id_service_center = dbo.service_center_dtl.id_service_center AND  " & _
        "                      dbo.service_out_purchases.radif = dbo.service_center_dtl.radif LEFT OUTER JOIN " & _
        "                      dbo.GL_AP_payment ON dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
        "                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
        "GROUP BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif,  " & _
        "                      ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2), dbo.service_out_purchases.due_date,  " & _
        "                      dbo.service_out_purchases.cod_vendor " & _
        "ORDER BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif ", CmdGeneral, False, True, "View_AllUnPaidService_out_purchase")


    End Sub


    Sub fix3()
        execit("CREATE VIEW dbo.View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl " & _
"AS " & _
"SELECT     dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl, dbo.GL_AP_bill_Dtl_Dtl.amount, dbo.GL_AP_bill_Dtl_Dtl.due_date, " & _
"                      dbo.GL_AP_Bill_Head.Date_Bill AS DateTransaction, dbo.GL_AP_Bill_Head.Id_AP_bill_Head, dbo.View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment, " & _
"                      dbo.View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount, dbo.GL_AP_bill_Dtl.ref_no AS vendorrefno, dbo.GL_AP_Bill_Head.cod_vendor, " & _
"                      dbo.GL_AP_payment.ID_AP_payment, dbo.GL_AP_payment.Id_AP_bill_dtl_dtl, dbo.GL_AP_payment.id_service_center, " & _
"                      dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl, dbo.GL_AP_payment.radif, dbo.GL_AP_payment.amount_pay, dbo.GL_AP_payment.remark, " & _
"                      dbo.GL_AP_payment.date_prepare, dbo.GL_AP_payment.id_check, dbo.GL_AP_payment.id_vendor_credit_head " & _
"FROM         dbo.GL_AP_bill_Dtl_Dtl INNER JOIN " & _
"                      dbo.GL_AP_bill_Dtl ON dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = dbo.GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
"                      dbo.GL_AP_Bill_Head ON dbo.GL_AP_bill_Dtl.Id_AP_bill_Head = dbo.GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
"                      dbo.View_AllUnPaidGl_Ap_Bill_Dtl_Dtl ON  " & _
"                      dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = dbo.View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.Id_AP_bill_dtl_dtl RIGHT OUTER JOIN " & _
"                      dbo.GL_AP_payment ON dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = dbo.GL_AP_payment.Id_AP_bill_dtl_dtl " & _
"WHERE     (dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl IN " & _
"                          (SELECT     id_ap_bill_dtl_dtl " & _
"                             FROM         View_AllUnPaidGl_Ap_Bill_Dtl_Dtl)) AND (NOT (dbo.GL_AP_bill_Dtl_Dtl.due_date IS NULL)) AND  " & _
"                      (LTRIM(RTRIM(dbo.GL_AP_bill_Dtl_Dtl.due_date)) <> '') ", CmdGeneral, False, True, "View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl")


        execit("CREATE VIEW dbo.View_AllPreAndPaidReceive_product_ap_Dtl  " & _
        "AS  " & _
        "SELECT     dbo.Inv_Receive_product_Ap_Dtl.id_receive_ref, dbo.Inv_Receive_product_Ap_Dtl.amount, dbo.Inv_Receive_product_Ap_Dtl.due_date,   " & _
        "                      dbo.Inv_Receive_Products_head.date_receive AS DateTransaction, dbo.View_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount,   " & _
        "                      dbo.View_AllUnPaidReceive_product_ap_Dtl.sumpayment, dbo.Inv_Receive_Products_head.vendor_ref_no AS vendorrefno,   " & _
        "                      dbo.GL_AP_payment.date_prepare, dbo.GL_AP_payment.id_check, dbo.GL_AP_payment.id_vendor_credit_head, dbo.GL_AP_payment.amount_pay,   " & _
        "                      dbo.GL_AP_payment.remark, dbo.GL_AP_payment.radif, dbo.GL_AP_payment.id_service_center,   " & _
        "                      dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl, dbo.GL_AP_payment.Id_AP_bill_dtl_dtl, dbo.Inv_Receive_Products_head.cod_vendor  " & _
        "FROM         dbo.Inv_Receive_product_Ap_Dtl INNER JOIN  " & _
        "                      dbo.Inv_Receive_Products_head ON dbo.Inv_Receive_product_Ap_Dtl.id_receive_ref = dbo.Inv_Receive_Products_head.id_receive_ref INNER JOIN  " & _
        "                      dbo.View_AllUnPaidReceive_product_ap_Dtl ON   " & _
        "                      dbo.Inv_Receive_Products_head.id_receive_ref = dbo.View_AllUnPaidReceive_product_ap_Dtl.id_receive_ref AND   " & _
        "                      dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = dbo.View_AllUnPaidReceive_product_ap_Dtl.ID_Inv_Receive_product_Ap_Dtl RIGHT  " & _
        "                       OUTER JOIN  " & _
        "                      dbo.GL_AP_payment ON   " & _
        "                      dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl  " & _
        "WHERE     (dbo.Inv_Receive_product_Ap_Dtl.id_receive_ref IN  " & _
        "                          (SELECT     id_receive_ref  " & _
        "                             FROM         View_AllUnPaidReceive_product_ap_Dtl))  ", CmdGeneral, False, True, "View_AllPreAndPaidReceive_product_ap_Dtl")


        execit("CREATE VIEW dbo.View_AllPreAndPaidService_out_purchase " & _
        "AS " & _
        "SELECT     dbo.service_out_purchases.cost AS amount, dbo.service_out_purchases.due_date, dbo.service_center_head.date_refer AS DateTransaction,  " & _
        "                      dbo.View_AllUnPaidService_out_purchase.sumoriginalamount, dbo.View_AllUnPaidService_out_purchase.sumpayment,  " & _
        "                      dbo.service_out_purchases.invoice_no AS vendorrefno, dbo.GL_AP_payment.ID_AP_payment, dbo.GL_AP_payment.Id_AP_bill_dtl_dtl,  " & _
        "                      dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl, dbo.GL_AP_payment.id_service_center, dbo.GL_AP_payment.radif,  " & _
        "                      dbo.GL_AP_payment.amount_pay, dbo.GL_AP_payment.remark, dbo.GL_AP_payment.date_prepare, dbo.GL_AP_payment.id_check,  " & _
        "                      dbo.GL_AP_payment.id_vendor_credit_head, dbo.service_out_purchases.cod_vendor " & _
        "FROM         dbo.service_out_purchases INNER JOIN " & _
        "                      dbo.service_center_head ON dbo.service_out_purchases.id_service_center = dbo.service_center_head.id_service_center INNER JOIN " & _
        "                      dbo.View_AllUnPaidService_out_purchase ON  " & _
        "                      dbo.service_out_purchases.id_service_center = dbo.View_AllUnPaidService_out_purchase.id_service_center AND  " & _
        "                      dbo.service_out_purchases.radif = dbo.View_AllUnPaidService_out_purchase.radif RIGHT OUTER JOIN " & _
        "                      dbo.GL_AP_payment ON dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
        "                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
        "WHERE     ((dbo.service_out_purchases.id_service_center + STR(dbo.service_out_purchases.radif)) IN " & _
        "                          (SELECT     id_service_center + str(radif) " & _
        "                             FROM         View_AllUnPaidService_out_purchase)) AND (dbo.service_center_head.type_of_form = 'IN') AND  " & _
        "                      (NOT (dbo.service_out_purchases.due_date IS NULL)) AND (LTRIM(RTRIM(dbo.service_out_purchases.due_date)) <> '') AND  " & _
        "                      (dbo.service_out_purchases.PaidFlag = 0)", CmdGeneral, False, True, "View_AllPreAndPaidService_out_purchase")



    End Sub
    Sub fix4()
        Try
            CmdGeneral.CommandText = " ALTER TABLE inv_adjustment_head ADD DeliveryReciept Char(10)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE inv_adjustment_head ADD NationalAccount Char(10)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE inv_adjustment_head ADD cod_vendor Char(6)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub
    Sub fix5()
        execit("CREATE VIEW dbo.View_RecieveReturnTotal " & _
" AS " & _
" SELECT     sum(Inv_Receive_product_dtl.qty) as TotalQty,ROUND(SUM(Inv_Receive_product_dtl.qty * (Inv_Receive_product_dtl.cost + Inv_Receive_product_dtl.fet)) - Inv_Receive_Products_head.Discount, 2)  " & _
"                      AS TotalPrice, Inv_Receive_Products_head.id_receive_ref " & _
" FROM         Inv_Receive_product_dtl INNER JOIN " & _
"                      Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
" GROUP BY Inv_Receive_Products_head.Discount, Inv_Receive_Products_head.id_receive_ref ", CmdGeneral, False, True, "View_RecieveReturnTotal")
    End Sub

    Sub Fix6()
        execit("CREATE VIEW dbo.View_AllVendorPaid " & _
 " AS " & _
"SELECT     GL_AP_payment.date_prepare, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_credit_head, inv_vendor.cod_vendor, " & _
"                      inv_vendor.desc_vendor, GL_AP_payment.amount_pay, GL_AP_payment.id_check " & _
"FROM         GL_AP_payment INNER JOIN " & _
"                      service_out_purchases ON GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND  " & _
"                      GL_AP_payment.radif = service_out_purchases.radif INNER JOIN " & _
"                      inv_vendor ON service_out_purchases.cod_vendor = inv_vendor.cod_vendor " & _
"UNION ALL " & _
"SELECT     GL_AP_payment.date_prepare, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_credit_head, inv_vendor.cod_vendor,  " & _
"                      inv_vendor.desc_vendor, GL_AP_payment.amount_pay, GL_AP_payment.id_check " & _
"FROM         GL_AP_bill_Dtl_Dtl INNER JOIN " & _
"                      GL_AP_payment ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_AP_payment.Id_AP_bill_dtl_dtl INNER JOIN " & _
"                      GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
"                      GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
"                      inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor " & _
"UNION ALL " & _
"SELECT     GL_AP_payment.date_prepare, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_credit_head, inv_vendor.cod_vendor,  " & _
"                      inv_vendor.desc_vendor, GL_AP_payment.amount_pay, GL_AP_payment.id_check " & _
"FROM         GL_AP_payment INNER JOIN " & _
"                      Inv_Receive_product_Ap_Dtl ON  " & _
"                      GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                      Inv_Receive_product_dtl ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_product_dtl.id_receive_ref INNER JOIN " & _
"                      Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref AND  " & _
"                      Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref INNER JOIN " & _
"                      inv_vendor ON Inv_Receive_Products_head.cod_vendor = inv_vendor.cod_vendor " & _
"GROUP BY GL_AP_payment.date_prepare, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_credit_head, inv_vendor.cod_vendor,  " & _
"                      inv_vendor.desc_vendor, GL_AP_payment.amount_pay, GL_AP_payment.id_check " & _
 " ", CmdGeneral, False, True, "View_AllVendorPaid")
    End Sub

    Sub Fix7()
        Try
            CmdGeneral.CommandText = " ALTER TABLE Inv_Receive_Products_head ADD Tax decimal(18, 2) default 0"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub
    Sub Fix8()
        Try
            CmdGeneral.CommandText = " ALTER TABLE service_out_purchases ADD AR_terms char(10)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE [dbo].[service_out_purchases] ADD  CONSTRAINT [FK_service_out_purchases_GL_TAB_AR_TERM] FOREIGN KEY ([AR_terms]) REFERENCES [dbo].[GL_TAB_AR_TERM] ([AR_terms])"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " CREATE TABLE [dbo].[Service_out_purchases_Dtl] ( " & _
"	[IDService_out_purchases_dtl] [numeric](18, 0) IDENTITY (1, 1) NOT NULL , " & _
"	[id_service_center] [char] (10) NOT NULL , " & _
"	[radif] [smallint] NOT NULL , " & _
"	[Due_Date] [char] (10) NOT NULL , " & _
"	[Cost] [money] NOT NULL  " & _
") ON [PRIMARY] "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE [dbo].[Service_out_purchases_Dtl] WITH NOCHECK ADD " & _
            "	CONSTRAINT [PK_Service_out_purchases_Dtl] PRIMARY KEY  CLUSTERED ([IDService_out_purchases_dtl]) ON [PRIMARY] "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[Service_out_purchases_Dtl] ADD CONSTRAINT [DF_Service_out_purchases_Dtl_Cost] DEFAULT (0) FOR [Cost] "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[Service_out_purchases_Dtl] ADD CONSTRAINT [FK_Service_out_purchases_Dtl_service_out_purchases] " & _
            " FOREIGN KEY ([id_service_center],[radif]) REFERENCES [dbo].[service_out_purchases] ([id_service_center],[radif]) " & _
            " ON DELETE CASCADE  ON UPDATE CASCADE "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try


    End Sub

    Sub Fix9()

        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_AP_payment ADD IDService_out_purchases_dtl decimal(18, 2)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        execit("CREATE VIEW dbo.View_AllUnPaidService_out_purchase " & _
                "AS " & _
                "SELECT     TOP 100 PERCENT ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2) AS sumoriginalamount,  " & _
                "                      ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment, dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif,  " & _
                "                      dbo.service_out_purchases.cod_vendor, dbo.Service_out_purchases_Dtl.Due_Date, dbo.Service_out_purchases_Dtl.Cost,  " & _
                "                      dbo.Service_out_purchases_Dtl.IDService_out_purchases_dtl " & _
                "FROM         dbo.service_out_purchases INNER JOIN " & _
                "                      dbo.service_center_dtl ON dbo.service_out_purchases.id_service_center = dbo.service_center_dtl.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.service_center_dtl.radif INNER JOIN " & _
                "                      dbo.Service_out_purchases_Dtl ON dbo.service_out_purchases.id_service_center = dbo.Service_out_purchases_Dtl.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.Service_out_purchases_Dtl.radif LEFT OUTER JOIN " & _
                "                      dbo.GL_AP_payment ON dbo.Service_out_purchases_Dtl.IDService_out_purchases_dtl = dbo.GL_AP_payment.IDService_out_purchases_dtl AND  " & _
                "                      dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
                "GROUP BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif,  " & _
                "                      ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2), dbo.service_out_purchases.cod_vendor,  " & _
                "                      dbo.Service_out_purchases_Dtl.Due_Date, dbo.Service_out_purchases_Dtl.Cost,  " & _
                "                      dbo.Service_out_purchases_Dtl.IDService_out_purchases_dtl " & _
                "ORDER BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif ", CmdGeneral, False, True, "View_AllUnPaidService_out_purchase")




        execit("CREATE VIEW dbo.View_AllPreAndPaidService_out_purchase " & _
"AS " & _
"SELECT DISTINCT  " & _
"                      dbo.View_AllUnPaidService_out_purchase.Cost AS amount, dbo.View_AllUnPaidService_out_purchase.Due_Date,  " & _
"                      dbo.service_center_head.date_refer AS DateTransaction, dbo.View_AllUnPaidService_out_purchase.sumoriginalamount,  " & _
"                      dbo.View_AllUnPaidService_out_purchase.sumpayment, dbo.service_out_purchases.invoice_no AS vendorrefno,  " & _
"                      dbo.GL_AP_payment.ID_AP_payment, dbo.GL_AP_payment.Id_AP_bill_dtl_dtl, dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl,  " & _
"                      dbo.GL_AP_payment.id_service_center, dbo.GL_AP_payment.radif, dbo.GL_AP_payment.amount_pay, dbo.GL_AP_payment.remark,  " & _
"                      dbo.GL_AP_payment.date_prepare, dbo.GL_AP_payment.id_check, dbo.GL_AP_payment.id_vendor_credit_head,  " & _
"                      dbo.service_out_purchases.cod_vendor, dbo.View_AllUnPaidService_out_purchase.IDService_out_purchases_dtl " & _
"FROM         dbo.service_out_purchases INNER JOIN " & _
"                      dbo.service_center_head ON dbo.service_out_purchases.id_service_center = dbo.service_center_head.id_service_center INNER JOIN " & _
"                      dbo.View_AllUnPaidService_out_purchase ON  " & _
"                      dbo.service_out_purchases.id_service_center = dbo.View_AllUnPaidService_out_purchase.id_service_center AND  " & _
"                      dbo.service_out_purchases.radif = dbo.View_AllUnPaidService_out_purchase.radif AND  " & _
"                      dbo.service_center_head.id_service_center = dbo.View_AllUnPaidService_out_purchase.id_service_center RIGHT OUTER JOIN " & _
"                      dbo.GL_AP_payment ON  " & _
"                      dbo.View_AllUnPaidService_out_purchase.IDService_out_purchases_dtl = dbo.GL_AP_payment.IDService_out_purchases_dtl AND  " & _
"                      dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
"                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
"WHERE     ((dbo.service_out_purchases.id_service_center + STR(dbo.service_out_purchases.radif)) IN " & _
"                          (SELECT     id_service_center + str(radif) " & _
"                             FROM         View_AllUnPaidService_out_purchase)) AND (dbo.service_center_head.type_of_form = 'IN') AND  " & _
"                      (NOT (dbo.service_out_purchases.due_date IS NULL)) AND (LTRIM(RTRIM(dbo.service_out_purchases.due_date)) <> '') AND  " & _
"                      (dbo.service_out_purchases.PaidFlag = 0)  ", CmdGeneral, False, True, "View_AllPreAndPaidService_out_purchase")


       

    End Sub

    Sub Fix10()

        Try
            CmdGeneral.CommandText = " ALTER TABLE cust_trtab_main ADD Customer_Birth_Date Char(10)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        execit("CREATE VIEW dbo.View_Employee_Max_PayrollDate " & _
                "AS " & _
" SELECT     ISNULL(dbo.ChangeDateToNormal(MAX(dbo.ChangeDate(dbo.pay_main_employee.PayrollDate))), '') AS Max_PayrollDate,dbo.employee.employee_code " & _
" FROM         dbo.pay_main_employee RIGHT OUTER JOIN dbo.employee ON dbo.pay_main_employee.employee_code = dbo.employee.employee_code " & _
" GROUP BY dbo.employee.employee_code ", CmdGeneral, False, True, "View_Employee_Max_PayrollDate")

        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_Garnishment_employee ADD BeforeTax  bit default 0 "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

    End Sub
    Sub Fix11()
        Try
            CmdGeneral.CommandText = "ALTER PROCEDURE SP_CustomerBalanceForStatement @ThisDate AS char(10), @StoreCode AS Char(2), @StoreName AS Char(50), @descript AS Char(50),  " & _
                    "@Todate AS char(10) AS SELECT     * " & _
                    "                                                      FROM         (SELECT     Cod_customer, @storeCode AS StoreCode, @storeName AS StoreName, @descript AS Descript,  " & _
                    "                                                                                                    @ThisDate AS Date, " & _
                    "                                                                                                        (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0)  " & _
                    "                                                                                                                                 AS Customer_AR_Bedehy1 " & _
                    "                                                                                                           FROM         service_center_head INNER JOIN " & _
                    "                                                                                                                                 GL_payment_deposit ON  " & _
                    "                                                                                                                                 service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
                    "                                                                                                                                 GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                    "                                                                                                           WHERE     (dbo.ChangeDate(dbo.service_center_head.date_refer) < dbo.ChangeDate(@ThisDate)) AND  " & _
                    "                                                                                                                                 (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND  " & _
                    "                                                                                                                                 (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND  " & _
                    "                                                                                                                                 A.cod_customer = dbo.service_center_head.cod_customer) - " & _
                    "                                                                                                        (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Paid1 " & _
                    "                                                                                                           FROM         GL_payment_deposit INNER JOIN " & _
                    "                                                                                                                                 Gl_receive_payment ON  " & _
                    "                                                                                                                                 GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
                    "                                                                                                           WHERE     (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment) < dbo.ChangeDate(@ThisDate))  " & _
                    "                                                                                                                                 AND (dbo.GL_payment_deposit.refer_type = '2' OR " & _
                    "                                                                                                                                 dbo.GL_payment_deposit.refer_type = '3') AND  " & _
                    "                                                                                                                                 A.cod_customer = dbo.Gl_receive_payment.cod_customer) + " & _
                    "                                                                                                        (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2 " & _
                    "                                                                                                           FROM         dbo.GL_account_adjustment_head " & _
                    "                                                                                                           WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment)  " & _
                    "                                                                                                                                 < dbo.ChangeDate(@ThisDate)) AND A.cod_customer = GL_account_adjustment_head.cod_customer)  " & _
                    "                                                                                                    -isnull( " & _
                    "                                                                                                        (SELECT     SUM(round(isnull(amount_over, 0), 2)) AS overpayment " & _
                    "                                                                                                           FROM         gl_receive_payment " & _
                    "                                                                                                           WHERE     A.cod_customer = gl_receive_payment.cod_customer AND  " & _
                    "                                                                                                                                 (dbo.ChangeDate(dbo.gl_receive_payment.date_receive_payment) < dbo.ChangeDate(@ThisDate))) ,0) " & _
                    "                                                                                                    +isnull( " & _
                    "                                                                                                        (SELECT     SUM(Payment_amount) AS SumPaid " & _
                    "                                                                                                           FROM         (SELECT     service_center_head.date_refer, GL_payment_deposit.Payment_amount,  " & _
                    "                                                                                                                                                         service_center_head.cod_customer " & _
                    "                                                                                                                                   FROM         GL_payment_deposit INNER JOIN " & _
                    "                                                                                                                                                         service_center_head ON  " & _
                    "                                                                                                                                                         GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                    "                                                                                                                                   WHERE     (GL_payment_deposit.payment_type = '5') AND (GL_payment_deposit.refer_type = '1')  " & _
                    "                                                                                                                                                         AND (GL_payment_deposit.Payment_amount <> 0)) DERIVEDTBL " & _
                    "                                                                                                           WHERE     cod_customer = a.cod_customer AND (dbo.ChangeDate(date_refer) < dbo.ChangeDate(@ThisDate)) " & _
                    "                                                                                                           GROUP BY cod_customer),0) " & _
                    "                                                                                                            AS BalanceAmount " & _
                    "                                                                              FROM         dbo.cust_trtab_main A) DERIVEDTBL " & _
                    "                                                      WHERE     Cod_customer IN " & _
                    "                                                                                (SELECT     cod_customer " & _
                    "                                                                                   FROM         (SELECT     Cod_customer, " & _
                    "                       (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0)  " & _
                    "                                                                                                                                                              AS Customer_AR_Bedehy1 " & _
                    "                                                                                                                                        FROM         service_center_head INNER JOIN " & _
                    "                                                                                                                                                              GL_payment_deposit ON  " & _
                    "                                                                                                                                                              service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER " & _
                    "                                                                                                                                                               JOIN " & _
                    "                                                                                                                                                              GL_payment_AR ON  " & _
                    "                                                                                                                                                              GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                    "                                                                                                                                        WHERE     (dbo.ChangeDate(dbo.service_center_head.date_refer) < dbo.ChangeDate(@ToDate))  " & _
                    "                                                                                                                                                              AND (dbo.GL_payment_deposit.refer_type = '1') AND  " & _
                    "                                                                                                                                                              (dbo.GL_payment_deposit.payment_type = '4') AND  " & _
                    "                                                                                                                                                              (dbo.GL_payment_AR.Cancel_flag <> 1) AND  " & _
                    "                                                                                                                                                              (dbo.service_center_head.type_of_form = 'IN') AND  " & _
                    "                                                                                                                                                              b.cod_customer = dbo.service_center_head.cod_customer) - " & _
                    "                                                                                                                                     (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0)  " & _
                    "                                                                                                                                                              AS Customer_AR_Paid1 " & _
                    "                                                                                                                                        FROM         GL_payment_deposit INNER JOIN " & _
                    "                                                                                                                                                              Gl_receive_payment ON  " & _
                    "                                                                                                                                                              GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
                    "                                                                                                                                        WHERE     (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment)  " & _
                    "             < dbo.ChangeDate(@ToDate)) AND (dbo.GL_payment_deposit.refer_type = '2' OR " & _
                    "                                                                                                                                                              dbo.GL_payment_deposit.refer_type = '3') AND  " & _
                    "                                                                                                                                                              b.cod_customer = dbo.Gl_receive_payment.cod_customer) + " & _
                    "                                                                                                                                     (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0)  " & _
                    "                                                                                                                                                              AS Customer_AR_Bedehy2 " & _
                    "                                                                                                                                        FROM         dbo.GL_account_adjustment_head " & _
                    "                                                                                                                                        WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment)  " & _
                    "                                                                                                                                                              < dbo.ChangeDate(@ToDate)) AND  " & _
                    "                                                                                                                                                              b.cod_customer = GL_account_adjustment_head.cod_customer) " & _
                    "                                                                                                                                      -isnull( " & _
                    "                                                                                                                                     (SELECT     SUM(round(isnull(amount_over, 0), 2)) AS overpayment " & _
                    "                                                                                                                                        FROM         gl_receive_payment " & _
                    "                                                                                                                                        WHERE     b.cod_customer = gl_receive_payment.cod_customer AND  " & _
                    "                                                                                                                                                              (dbo.ChangeDate(dbo.gl_receive_payment.date_receive_payment)  " & _
                    "                                                                                                                                                              < dbo.ChangeDate(@ToDate))),0) " & _
                    "                                                                                                                                      +isnull( " & _
                    "                                                                                                                                     (SELECT     SUM(Payment_amount) AS SumPaid " & _
                    "                                                                                                                                        FROM         (SELECT     service_center_head.date_refer, GL_payment_deposit.Payment_amount,  " & _
                    "                                                                                                                                                                                      service_center_head.cod_customer " & _
                    "                                                                                                                                                                FROM         GL_payment_deposit INNER JOIN " & _
                    "                                                                                                                                                                                      service_center_head ON  " & _
                    "                                                                                                                                                                            GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                    "																		 			    WHERE     (GL_payment_deposit.payment_type = '5') AND " & _
                    "                                                                                                                                                                                      (GL_payment_deposit.refer_type = '1') AND  " & _
                    "                                                                                                                                                                                      (GL_payment_deposit.Payment_amount <> 0)) DERIVEDTBL " & _
                    "                                                                                                                                        WHERE     cod_customer = b.cod_customer AND (dbo.ChangeDate(date_refer)  " & _
                    "                                                                                                                                                              < dbo.ChangeDate(@ToDate)) " & _
                    "                                                                                                                                        GROUP BY cod_customer),0) " & _
                    "                                                                                                                                         AS BalanceAmount " & _
                    "                                                                                                           FROM         dbo.cust_trtab_main b) DERIVEDTBL " & _
                    "                                                                                   WHERE     balanceamount <> 0) "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub
    Sub Fix12()

        Try
            CmdGeneral.CommandText = " UPDATE    service_out_purchases SET AR_terms = 'Net 30' WHERE AR_terms Is NULL "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " UPDATE    service_out_purchases SET invoice_date = (SELECT     date_refer FROM         service_center_head WHERE     service_center_head.id_service_center = service_out_purchases.id_service_center)  WHERE     (RTRIM(LTRIM(invoice_date)) = '') "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " UPDATE    service_out_purchases SET due_date = invoice_date WHERE     (RTRIM(LTRIM(due_date)) = '') "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " UPDATE    service_out_purchases_dtl SET              due_date = (SELECT     due_date FROM         service_out_purchases WHERE     service_out_purchases.id_service_center = service_out_purchases_dtl.id_service_center AND service_out_purchases.radif = service_out_purchases_dtl.radif) WHERE     (RTRIM(LTRIM(due_date)) = '') "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " INSERT INTO Service_out_purchases_Dtl (id_service_center, radif, Due_Date, Cost) " & _
" SELECT     service_out_purchases.id_service_center, service_out_purchases.radif, service_out_purchases.due_date,  " & _
"                       ROUND(service_out_purchases.cost * service_center_dtl.qty, 2) AS cost " & _
" FROM         service_out_purchases INNER JOIN " & _
"                       service_center_dtl ON service_out_purchases.id_service_center = service_center_dtl.id_service_center AND  " & _
"                       service_out_purchases.radif = service_center_dtl.radif " & _
" WHERE     (service_out_purchases.id_service_center+str(service_out_purchases.radif) NOT IN " & _
"                           (SELECT     id_service_center+str(radif) " & _
"                              FROM         service_out_purchases_dtl)) "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " DELETE FROM service_out_purchases WHERE     (RTRIM(LTRIM(id_service_center)) = '') "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " DELETE FROM service_out_purchases WHERE     (id_service_center NOT IN (SELECT     id_service_center FROM         service_center_head)) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Clear()
        DAService_out_purchases_Dtl.Fill(DsFrmUpdateDatabase1.Service_out_purchases_Dtl)
        Try
            Dim i As Integer
            Dim a1 As Decimal = 0
            Dim a2 As Decimal = 0
            Dim a3 As Decimal = 0
            For i = 0 To DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows.Count - 1
                If DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("AR_terms") = "3 Payments" Then
                    DsFrmUpdateDatabase1.Service_out_purchases_Dtl_dtl.Clear()
                    DAService_out_purchases_Dtl_dtl.SelectCommand.Parameters("@id_service_center").Value = DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("id_service_center")
                    DAService_out_purchases_Dtl_dtl.SelectCommand.Parameters("@radif").Value = DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("radif")
                    DAService_out_purchases_Dtl_dtl.Fill(DsFrmUpdateDatabase1.Service_out_purchases_Dtl_dtl)
                    a1 = Math.Round(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("Cost") / 3, 2)
                    a2 = Math.Round(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("Cost") / 3, 2)
                    a3 = Math.Round(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("Cost"), 2) - a1 - a2
                    If DsFrmUpdateDatabase1.Service_out_purchases_Dtl_dtl.Rows.Count <> 3 Then
                        MsgBox("Error in update outside purchases")
                    Else
                        CmdGeneral.CommandText = " Update Service_out_purchases_Dtl Set Cost=" & Math.Round(a1, 2) & _
                                   " Where IDService_out_purchases_dtl= " & DsFrmUpdateDatabase1.Service_out_purchases_Dtl_dtl.Rows(0).Item("IDService_out_purchases_dtl")
                        CmdGeneral.ExecuteNonQuery()
                        CmdGeneral.CommandText = " Update Service_out_purchases_Dtl Set Cost=" & Math.Round(a2, 2) & _
                                   " Where IDService_out_purchases_dtl= " & DsFrmUpdateDatabase1.Service_out_purchases_Dtl_dtl.Rows(1).Item("IDService_out_purchases_dtl")
                        CmdGeneral.ExecuteNonQuery()
                        CmdGeneral.CommandText = " Update Service_out_purchases_Dtl Set Cost=" & Math.Round(a3, 2) & _
                                   " Where IDService_out_purchases_dtl= " & DsFrmUpdateDatabase1.Service_out_purchases_Dtl_dtl.Rows(2).Item("IDService_out_purchases_dtl")
                        CmdGeneral.ExecuteNonQuery()
                    End If
                Else
                    CmdGeneral.CommandText = " Update Service_out_purchases_Dtl Set Cost=" & Math.Round(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("Cost"), 2) & _
                               " Where id_service_center= " & Qt(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("id_service_center")) & " AND radif=" & DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("radif")
                    CmdGeneral.ExecuteNonQuery()
                    If Trim(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("Due_date_dtl")).Length = 0 Then
                        CmdGeneral.CommandText = " Update Service_out_purchases_Dtl Set Due_date='" & DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("Due_date") & "' " & _
                                   " Where id_service_center= " & Qt(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("id_service_center")) & " AND radif=" & DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("radif")
                    End If

                    CmdGeneral.CommandText = " Update Service_out_purchases_Dtl Set Cost=" & Math.Round(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("Cost"), 2) & _
                               " Where id_service_center= " & Qt(DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("id_service_center")) & " AND radif=" & DsFrmUpdateDatabase1.Service_out_purchases_Dtl.Rows(i).Item("radif")
                    CmdGeneral.ExecuteNonQuery()

                End If
            Next
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE service_out_purchases ALTER COLUMN Line varchar(30) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

    End Sub
    Sub fix13()
        execit("create view View_AllUnPaidService_out_purchase as " & _
                "SELECT     TOP 100 PERCENT ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2) AS sumoriginalamount,  " & _
                "                      ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment, dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif,  " & _
                "                      dbo.service_out_purchases.cod_vendor, dbo.Service_out_purchases_Dtl.Due_Date, dbo.Service_out_purchases_Dtl.Cost,  " & _
                "                      dbo.Service_out_purchases_Dtl.IDService_out_purchases_dtl " & _
                "FROM         dbo.service_out_purchases INNER JOIN " & _
                "                      dbo.service_center_dtl ON dbo.service_out_purchases.id_service_center = dbo.service_center_dtl.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.service_center_dtl.radif INNER JOIN " & _
                "                      dbo.Service_out_purchases_Dtl ON dbo.service_out_purchases.id_service_center = dbo.Service_out_purchases_Dtl.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.Service_out_purchases_Dtl.radif LEFT OUTER JOIN " & _
                "                      dbo.GL_AP_payment ON dbo.Service_out_purchases_Dtl.IDService_out_purchases_dtl = dbo.GL_AP_payment.IDService_out_purchases_dtl AND  " & _
                "                      dbo.Service_out_purchases_Dtl.radif = dbo.GL_AP_payment.radif AND  " & _
                "                      dbo.Service_out_purchases_Dtl.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
                "                      dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
                "GROUP BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif,  " & _
                "                      ROUND(dbo.service_center_dtl.qty * dbo.service_out_purchases.cost, 2), dbo.service_out_purchases.cod_vendor,  " & _
                "                      dbo.Service_out_purchases_Dtl.Due_Date, dbo.Service_out_purchases_Dtl.Cost,  " & _
                "                      dbo.Service_out_purchases_Dtl.IDService_out_purchases_dtl " & _
                "ORDER BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif ", CmdGeneral, False, True, "View_AllUnPaidService_out_purchase")



        execit("create view View_AllPreAndPaidService_out_purchase as  " & _
                "SELECT DISTINCT  " & _
                "                      TOP 100 PERCENT dbo.View_AllUnPaidService_out_purchase.Cost AS amount, dbo.View_AllUnPaidService_out_purchase.Due_Date,  " & _
                "                      dbo.service_center_head.date_refer AS DateTransaction, dbo.View_AllUnPaidService_out_purchase.sumoriginalamount,  " & _
                "                      dbo.View_AllUnPaidService_out_purchase.sumpayment, dbo.service_out_purchases.invoice_no AS vendorrefno,  " & _
                "                      dbo.GL_AP_payment.ID_AP_payment, dbo.GL_AP_payment.Id_AP_bill_dtl_dtl, dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl,  " & _
                "                      dbo.GL_AP_payment.id_service_center, dbo.GL_AP_payment.radif, dbo.GL_AP_payment.amount_pay, dbo.GL_AP_payment.remark,  " & _
                "                      dbo.GL_AP_payment.date_prepare, dbo.GL_AP_payment.id_check, dbo.GL_AP_payment.id_vendor_credit_head,  " & _
                "                      dbo.service_out_purchases.cod_vendor, dbo.View_AllUnPaidService_out_purchase.IDService_out_purchases_dtl " & _
                "FROM         dbo.service_out_purchases INNER JOIN " & _
                "                      dbo.service_center_head ON dbo.service_out_purchases.id_service_center = dbo.service_center_head.id_service_center INNER JOIN " & _
                "                      dbo.View_AllUnPaidService_out_purchase ON  " & _
                "                      dbo.service_out_purchases.id_service_center = dbo.View_AllUnPaidService_out_purchase.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.View_AllUnPaidService_out_purchase.radif AND  " & _
                "                      dbo.service_center_head.id_service_center = dbo.View_AllUnPaidService_out_purchase.id_service_center RIGHT OUTER JOIN " & _
                "                      dbo.GL_AP_payment ON  " & _
                "                      dbo.View_AllUnPaidService_out_purchase.IDService_out_purchases_dtl = dbo.GL_AP_payment.IDService_out_purchases_dtl AND  " & _
                "                      dbo.View_AllUnPaidService_out_purchase.radif = dbo.GL_AP_payment.radif AND  " & _
                "                      dbo.View_AllUnPaidService_out_purchase.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
                "                      dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
                "                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
                "WHERE     ((dbo.service_out_purchases.id_service_center + STR(dbo.service_out_purchases.radif)) IN " & _
                "                          (SELECT     id_service_center + str(radif) " & _
                "                             FROM         View_AllUnPaidService_out_purchase)) AND (dbo.service_center_head.type_of_form = 'IN') AND  " & _
                "                      (NOT (dbo.service_out_purchases.due_date IS NULL)) AND (LTRIM(RTRIM(dbo.service_out_purchases.due_date)) <> '') AND  " & _
                "                      (dbo.service_out_purchases.PaidFlag = 0)", CmdGeneral, False, True, "View_AllPreAndPaidService_out_purchase")

    End Sub
    Sub fix14()

        Try
            CmdGeneral.CommandText = " ALTER TABLE employee ALTER COLUMN last_hourly decimal(18, 2) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE employee ALTER COLUMN last_overtime decimal(18, 2) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

    End Sub

    Sub fix15()
        execit(" CREATE VIEW dbo.View_EmployeeNetPay as " & _
                " SELECT     employee_code, PayrollDate, ISNULL(gross_pay, 0) - " & _
                " (SELECT     ISNULL(SUM(pay_deductin_main_dtl.amount_deduction_employee), 0) " & _
                " FROM         pay_deductin_main_dtl " & _
                " WHERE     pay_deductin_main_dtl.id_pay_period = A.id_pay_period) AS NetPay " & _
                " FROM         pay_main_employee A " & _
                "  ", CmdGeneral, False, True, "View_EmployeeNetPay")

    End Sub
    Sub Fix16()
        CmdGeneral.CommandText = "UPDATE    inv_tab_item_warehouse   SET        on_order = 0 WHERE     (on_order IS NULL)"
        CmdGeneral.ExecuteNonQuery()
    End Sub

    Sub Fix17()
        execit(" CREATE VIEW dbo.View_BankNetDeposit as " & _
                " SELECT     id_debit_deposit_head, " & _
" (SELECT     isnull(SUM(deposit_amount), 0) AS deposit_amount FROM GL_debit_deposit " & _
"  WHERE     GL_debit_deposit.id_debit_deposit_head = A.id_debit_deposit_head AND (type_transaction IN ('1', '5', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H','I', 'J', 'K'))) -  " & _
" (SELECT     isnull(SUM(debit_amount), 0) AS deposit_amount FROM GL_debit_deposit " & _
"  WHERE     GL_debit_deposit.id_debit_deposit_head = A.id_debit_deposit_head AND (type_transaction IN ('3', '8'))) AS NetDeposit " & _
" FROM         GL_debit_deposit_head A " & _
" WHERE     (id_debit_deposit_head IN (SELECT DISTINCT id_debit_deposit_head FROM         GL_debit_deposit WHERE     type_transaction = '1')) " & _
                "  ", CmdGeneral, False, True, "View_BankNetDeposit")
    End Sub

    Sub Fix18()
        execit(" CREATE VIEW dbo.View_Invoice_SubTotal as " & _
               " SELECT     id_service_center, SUM(ROUND(qty * (ROUND(price, 2) + ROUND(fet, 2)), 2)) AS Subtotal " & _
               " FROM         dbo.service_center_dtl GROUP BY id_service_center " & _
               "  ", CmdGeneral, False, True, "View_Invoice_SubTotal")
    End Sub

    Sub fix19()

        Try
            CmdGeneral.CommandText = " ALTER TABLE pay_main_employee ADD Payment_Type Char(1) DEFAULT  0"
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = " Update pay_main_employee set Payment_Type='0' Where Payment_Type is null "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

    End Sub


    Sub Fix20()
        execit("alter table gl_account_adjustment_dtl_dtl drop constraint FK_GL_account_adjustment_dtl_dtl_GL_account_adjustment_dtl ", CmdGeneral, True)
        execit("alter table gl_account_adjustment_dtl  drop constraint FK_GL_account_adjustment_dtl_service_center_head", CmdGeneral, True)

        execit("alter table gl_account_adjustment_dtl  drop constraint PK_GL_account_adjustment_dtl", CmdGeneral, True)

        execit("alter table GL_payment_deposit drop constraint FK_GL_payment_deposit_GL_account_adjustment_head", CmdGeneral, True)

        execit("alter table gl_account_adjustment_dtl  drop constraint FK_GL_account_adjustment_dtl_GL_account_adjustment_head", CmdGeneral, True)

        execit("alter table gl_account_adjustment_head drop constraint  PK_GL_account_adjustment_head", CmdGeneral, True)

        execit("alter table gl_account_adjustment_dtl_dtl  alter column refrence_no_due char(8) NOT NULL ", CmdGeneral, True)

        execit("alter table gl_account_adjustment_dtl  alter column refrence_no char(8) NOT NULL ", CmdGeneral, True)

        execit("alter table gl_account_adjustment_head  alter column refrence_no char(8) NOT NULL ", CmdGeneral, True)

        execit("alter table gl_payment_deposit  alter column refrence_no_Adjustment  char(8) ", CmdGeneral, True)

        execit("UPDATE gl_account_adjustment_head SET REFRENCE_NO = SUBSTRING(REFRENCE_NO,1,2)+'00'+SUBSTRING(REFRENCE_NO,3,4) WHERE LEN(RTRIM(LTRIM(REFRENCE_NO)))=6", CmdGeneral, True)

        execit("UPDATE gl_account_adjustment_Dtl SET REFRENCE_NO = SUBSTRING(REFRENCE_NO,1,2)+'00'+SUBSTRING(REFRENCE_NO,3,4) WHERE LEN(RTRIM(LTRIM(REFRENCE_NO)))=6", CmdGeneral, True)
        execit("UPDATE gl_account_adjustment_Dtl_Dtl SET refrence_no_due = SUBSTRING(refrence_no_due,1,2)+'00'+SUBSTRING(refrence_no_due,3,4) WHERE LEN(RTRIM(LTRIM(refrence_no_due)))=6", CmdGeneral, True)
        execit("UPDATE gl_payment_deposit SET refrence_no_Adjustment = SUBSTRING(refrence_no_Adjustment,1,2)+'00'+SUBSTRING(refrence_no_Adjustment,3,4) WHERE LEN(RTRIM(LTRIM(refrence_no_Adjustment)))=6", CmdGeneral, True)

        execit("ALTER TABLE [dbo].[GL_account_adjustment_dtl] WITH NOCHECK ADD " & _
                "	CONSTRAINT [PK_GL_account_adjustment_dtl] PRIMARY KEY  CLUSTERED " & _
                "	( " & _
                "		[refrence_no], " & _
                "		[id_service_center] " & _
                "	)  ON [PRIMARY] ", CmdGeneral, True)



        execit("ALTER TABLE [dbo].[GL_account_adjustment_head] WITH NOCHECK ADD  " & _
        "	CONSTRAINT [PK_GL_account_adjustment_head] PRIMARY KEY  CLUSTERED " & _
        "	( " & _
        "		[refrence_no] " & _
        "	)  ON [PRIMARY] ", CmdGeneral, True)



        execit("ALTER TABLE [dbo].[GL_account_adjustment_dtl] ADD " & _
        "	CONSTRAINT [FK_GL_account_adjustment_dtl_GL_account_adjustment_head] FOREIGN KEY " & _
        "	( " & _
        "		[refrence_no] " & _
        "	) REFERENCES [dbo].[GL_account_adjustment_head] ( " & _
        "		[refrence_no] " & _
        "	) ON DELETE CASCADE  ON UPDATE CASCADE , " & _
        "	CONSTRAINT [FK_GL_account_adjustment_dtl_service_center_head] FOREIGN KEY " & _
        "	( " & _
        "		[id_service_center] " & _
        "	) REFERENCES [dbo].[service_center_head] ( " & _
        "		[id_service_center] " & _
        "	)", CmdGeneral, True)


        execit("ALTER TABLE [dbo].[GL_account_adjustment_dtl_dtl] ADD " & _
        "	CONSTRAINT [FK_GL_account_adjustment_dtl_dtl_GL_account_adjustment_dtl] FOREIGN KEY " & _
        "	( " & _
        "		[refrence_no_due], " & _
        "		[id_service_center_due] " & _
        "	) REFERENCES [dbo].[GL_account_adjustment_dtl] ( " & _
        "		[refrence_no], " & _
        "		[id_service_center] " & _
        "	) ON DELETE CASCADE ", CmdGeneral, True)


        execit(" ALTER TABLE [dbo].[GL_payment_deposit] ADD " & _
        "	CONSTRAINT [FK_GL_payment_deposit_GL_account_adjustment_head] FOREIGN KEY " & _
        "	( " & _
        "		[refrence_no_Adjustment] " & _
        "	) REFERENCES [dbo].[GL_account_adjustment_head] ( " & _
        "		[refrence_no] " & _
        "	)", CmdGeneral, True)

    End Sub

    Sub Fix21()
        execit("alter table GL_payment_deposit drop constraint FK_GL_payment_deposit_Gl_receive_payment", CmdGeneral, True)
        execit("alter table  GL_account_adjustment_head drop constraint FK_GL_account_adjustment_head_Gl_receive_payment", CmdGeneral, True)
        execit("alter table Gl_receive_payment  drop constraint PK_Gl_receive_payment", CmdGeneral, True)
        execit("alter table Gl_receive_payment  alter column refrence_no char(8) NOT NULL", CmdGeneral, True)
        execit("alter table  GL_account_adjustment_head alter column Gl_receive_payment_Refrence_no char(8)", CmdGeneral, True)
        execit("alter table  GL_payment_deposit alter column refrence_no char(8)", CmdGeneral, True)
        execit("alter table  GL_payment_deposit alter column refrence_no_Gl_receive_payment char(8)", CmdGeneral, True)
        execit("alter table GL_payment_deposit_Detail alter column refrence_no char(8)", CmdGeneral, True)
        execit("UPDATE Gl_receive_payment SET refrence_no = SUBSTRING(refrence_no,1,2)+'00'+SUBSTRING(refrence_no,3,4) WHERE LEN(RTRIM(LTRIM(refrence_no)))=6", CmdGeneral, True)
        execit("UPDATE GL_account_adjustment_head SET Gl_receive_payment_Refrence_no = SUBSTRING(Gl_receive_payment_Refrence_no,1,2)+'00'+SUBSTRING(Gl_receive_payment_Refrence_no,3,4) WHERE LEN(RTRIM(LTRIM(Gl_receive_payment_Refrence_no)))=6", CmdGeneral, True)
        execit("UPDATE GL_payment_deposit SET  refrence_no = SUBSTRING(refrence_no,1,2)+'00'+SUBSTRING(refrence_no,3,4) WHERE LEN(RTRIM(LTRIM(refrence_no)))=6", CmdGeneral, True)
        execit("UPDATE GL_payment_deposit SET  refrence_no_Gl_receive_payment = SUBSTRING(refrence_no_Gl_receive_payment,1,2)+'00'+SUBSTRING(refrence_no_Gl_receive_payment,3,4) WHERE LEN(RTRIM(LTRIM(refrence_no_Gl_receive_payment)))=6", CmdGeneral, True)
        execit("UPDATE GL_payment_deposit_Detail SET  refrence_no = SUBSTRING(refrence_no,1,2)+'00'+SUBSTRING(refrence_no,3,4) WHERE LEN(RTRIM(LTRIM(refrence_no)))=6", CmdGeneral, True)
        execit("ALTER TABLE [dbo].[Gl_receive_payment] WITH NOCHECK ADD CONSTRAINT [PK_Gl_receive_payment] PRIMARY KEY  CLUSTERED 	([refrence_no]) ON [PRIMARY]  ", CmdGeneral, True)
        execit("ALTER TABLE [dbo].[GL_payment_deposit] ADD CONSTRAINT [FK_GL_payment_deposit_Gl_receive_payment] FOREIGN KEY (	[refrence_no]) REFERENCES [dbo].[Gl_receive_payment] ([refrence_no]) ON DELETE CASCADE  ON UPDATE CASCADE ", CmdGeneral, True)
        execit("ALTER TABLE [dbo].[GL_account_adjustment_head] ADD CONSTRAINT [FK_GL_account_adjustment_head_Gl_receive_payment] FOREIGN KEY ([Gl_receive_payment_Refrence_no]	) REFERENCES [dbo].[Gl_receive_payment] ([refrence_no]) ON DELETE CASCADE ", CmdGeneral, True)
        'execit("", CmdGeneral, True)
        'execit("", CmdGeneral, True)
        'execit("", CmdGeneral, True)
        'execit("", CmdGeneral, True)


    End Sub

    Sub Fix22()
        execit("alter table GL_payment_deposit drop constraint    FK_GL_payment_deposit_service_center_head", CmdGeneral, True)
        execit("alter table GL_account_adjustment_dtl drop constraint    FK_GL_account_adjustment_dtl_service_center_head ", CmdGeneral, True)
        execit("alter table service_center_head drop constraint  FK_service_center_head_service_center_head ", CmdGeneral, True)
        execit("UPDATE    service_center_head SET id_service_center = SUBSTRING(id_service_center, 1, 2)+SUBSTRING(id_service_center, 5, 6) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'ES') ", CmdGeneral, True)
        execit("UPDATE    service_center_head SET id_service_center_before = SUBSTRING(id_service_center_before, 1, 2)+SUBSTRING(id_service_center_before, 5, 6) where (LEN(id_service_center_before) =10) AND (SUBSTRING(id_service_center_before, 1, 2) = 'ES') ", CmdGeneral, True)
        execit("update service_center_head set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update service_center_head set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)
        execit("update service_center_head set id_service_center_before=SUBSTRING(id_service_center_before, 1, 4) + '6' + SUBSTRING(id_service_center_before, 8, 3) where (LEN(id_service_center_before) =10) AND (SUBSTRING(id_service_center_before, 1, 2) = 'IN')", CmdGeneral, True)
        execit("update service_center_head set id_service_center_before=SUBSTRING(id_service_center_before, 1, 2) + SUBSTRING(id_service_center_before, 5, 2) + '7' + SUBSTRING(id_service_center_before, 8, 3)  where (LEN(id_service_center_before) =10) AND (SUBSTRING(id_service_center_before, 1, 2) = 'WO') ", CmdGeneral, True)
        execit("update GL_payment_deposit set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update GL_payment_deposit set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)
        execit("update service_out_purchases set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update service_out_purchases set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)
        execit("ALTER TABLE [dbo].[GL_payment_deposit] ADD     CONSTRAINT [FK_GL_payment_deposit_service_center_head] FOREIGN KEY      (        [id_service_center]    ) REFERENCES [dbo].[service_center_head] (        [id_service_center]    )", CmdGeneral, True)
        execit("ALTER TABLE [dbo].[GL_account_adjustment_dtl] ADD      CONSTRAINT [FK_GL_account_adjustment_dtl_service_center_head] FOREIGN KEY    ( [id_service_center] ) REFERENCES [dbo].[service_center_head] (  [id_service_center]  )", CmdGeneral, True)
        execit("ALTER TABLE [dbo].[service_center_head] ADD   CONSTRAINT [FK_service_center_head_service_center_head] FOREIGN KEY  ( [id_service_center_before]  ) REFERENCES [dbo].[service_center_head] (  [id_service_center]  )", CmdGeneral, True)

        execit("update GL_AP_payment set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update GL_AP_payment set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        execit("update GL_Paid_received set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update GL_Paid_received set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        'execit("update GL_account_adjustment_dtl set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        'execit("update GL_account_adjustment_dtl set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        execit("update GL_account_adjustment_dtl_dtl set id_service_center_due=SUBSTRING(id_service_center_due, 1, 4) + '6' + SUBSTRING(id_service_center_due, 8, 3) where (LEN(id_service_center_due) =10) AND (SUBSTRING(id_service_center_due, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update GL_account_adjustment_dtl_dtl set id_service_center_due=SUBSTRING(id_service_center_due, 1, 2) + SUBSTRING(id_service_center_due, 5, 2) + '7' + SUBSTRING(id_service_center_due, 8, 3)  where (LEN(id_service_center_due) =10) AND (SUBSTRING(id_service_center_due, 1, 2) = 'WO') ", CmdGeneral, True)

        execit("update GL_payment_bill set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update GL_payment_bill set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        'execit("update GL_payment_deposit set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        'execit("update GL_payment_deposit set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        execit("update service_out_purchases set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update service_out_purchases set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        execit("update Service_out_purchases_Dtl set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update Service_out_purchases_Dtl set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        'execit("update ser_tr_vehicle_dtl set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        'execit("update ser_tr_vehicle_dtl set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        execit("update service_out_purchases set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update service_out_purchases set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)

        execit("update service_tire_adjustment set id_service_center=SUBSTRING(id_service_center, 1, 4) + '6' + SUBSTRING(id_service_center, 8, 3) where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'IN') ", CmdGeneral, True)
        execit("update service_tire_adjustment set id_service_center=SUBSTRING(id_service_center, 1, 2) + SUBSTRING(id_service_center, 5, 2) + '7' + SUBSTRING(id_service_center, 8, 3)  where (LEN(id_service_center) =10) AND (SUBSTRING(id_service_center, 1, 2) = 'WO') ", CmdGeneral, True)
    End Sub
    Sub Fix23()
        execit(" alter table cust_trtab_main  ALTER COLUMN email varchar(50) ", CmdGeneral, True)



    End Sub

    Sub Fix24()
        Try
            Dim CmdMenu As New System.Data.OleDb.OleDbCommand
            Dim CnnMenuMDB As New System.Data.OleDb.OleDbConnection
            CnnMenuMDB.ConnectionString = PConnectionStringForMenuMdb
            CmdMenu.Connection = CnnMenuMDB
            CmdMenu.CommandText = " INSERT INTO items ( ItemKey, Itemdesc, Item_small_icon, ItemKind, FormName, MasterItem )" & _
                                 " values (504080000,'Export Customer Email',0,3,'ReportCustomer.FrmRepCusEmail',504000000)"

            If CnnMenuMDB.State <> ConnectionState.Open Then
                CnnMenuMDB.Open()
            End If
            CmdMenu.ExecuteNonQuery()
        Catch ex As Exception

        End Try
  
    End Sub

    Sub execit(ByVal thisst As String, ByRef thiscmd As System.Data.SqlClient.SqlCommand, Optional ByVal showerror As Boolean = False, Optional ByVal IsViewFlag As Boolean = False, Optional ByVal ViewName As String = "")
        If IsViewFlag Then
            Try
                CmdGeneral.CommandText = " drop view [dbo].[" & ViewName.Trim & "]"
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
        End If
        Try
            thiscmd.CommandText = thisst
            thiscmd.ExecuteNonQuery()
        Catch ex As Exception
            If showerror Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

End Class

