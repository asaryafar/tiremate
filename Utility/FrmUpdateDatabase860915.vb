Imports CommonClass
Public Class FrmUpdateDatabase860915
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUpdateDatabase860915))
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
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_01;password=sa"
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
        'FrmUpdateDatabase860915
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(478, 415)
        Me.Controls.Add(Me.UiProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UiButton1)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "FrmUpdateDatabase860915"
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
                Call BehFixedDataBase()

                Call AryafarFixedDataBase()

                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                Call FixedAddFields()
                Call Fixed860428()
                Call Fixed860505()
                Call Fixed860509()
                Call Fixed860518()
                Call Fixed860520()
                Call Fixed860528()
                Call Fixed860601()
                Call FixeFaraji860631()
                Call FixedAfterUpdate1()
                Call okadjustmentdtldtl()
                Call Fixed_bas_vehicle()
                Call FixAp()
                'Call FixAdjLength()
                Call Employee_timeTrack()
                Call Fixed860908()
            End If
        Next
        If Cnn.State = ConnectionState.Open Then
            Cnn.Close()
        End If
        Cnn.ConnectionString = PConnectionString

        MsgBox("Update Successfully Completed", MsgBoxStyle.Information)
    End Sub
    Private Sub Fixed860908()
        execit(" CREATE VIEW dbo.View_Sum_Of_Invoice_OutsidePurchade_ReplacementCost " & _
" AS " & _
"SELECT     dbo.service_center_dtl.id_service_center,  " & _
"                      ISNULL(ROUND(SUM(dbo.service_center_dtl.qty * (dbo.service_out_purchases.cost + dbo.service_out_purchases.fet)), 2), 0)  " & _
"                       AS ReplacementCost " & _
" FROM         dbo.service_center_dtl LEFT OUTER JOIN " & _
"                     dbo.service_out_purchases ON dbo.service_center_dtl.id_service_center = dbo.service_out_purchases.id_service_center AND  " & _
"                       dbo.service_center_dtl.radif = dbo.service_out_purchases.radif " & _
" WHERE     (dbo.service_center_dtl.type_select = 'O') " & _
" GROUP BY dbo.service_center_dtl.id_service_center", CmdGeneral, False, True, "View_Sum_Of_Invoice_OutsidePurchade_ReplacementCost")

        execit(" CREATE VIEW dbo.View_Sum_Of_Invoice_ReplacementCost " & _
" AS " & _
" SELECT     dbo.service_center_dtl.id_service_center,  " & _
"                      ROUND(SUM(dbo.service_center_dtl.qty * (dbo.inv_item_cost_transaction.cost + dbo.inv_item_cost_transaction.fet)), 2) AS ReplacementCost " & _
" FROM         dbo.inv_item_cost_transaction INNER JOIN " & _
"                       dbo.inv_item ON dbo.inv_item_cost_transaction.item_no = dbo.inv_item.item_no RIGHT OUTER JOIN " & _
"                       dbo.service_center_dtl ON dbo.inv_item.item_no = dbo.service_center_dtl.cod_select " & _
" WHERE     (dbo.inv_item_cost_transaction.last_flag = 1) AND (dbo.service_center_dtl.type_select = 'I') " & _
" GROUP BY dbo.service_center_dtl.id_service_center", CmdGeneral, False, True, "View_Sum_Of_Invoice_ReplacementCost")

        execit(" CREATE VIEW dbo.View_Sum_Of_I_AND_O_ReplacementCost " & _
" AS " & _
" SELECT     CASE rtrim(ltrim(ISNULL(dbo.View_Sum_Of_Invoice_OutsidePurchade_ReplacementCost.id_service_center, '')))  " & _
"                       WHEN '' THEN dbo.View_Sum_Of_Invoice_ReplacementCost.id_service_center ELSE dbo.View_Sum_Of_Invoice_OutsidePurchade_ReplacementCost.id_service_center " & _
"                        END AS id_service_center, ISNULL(dbo.View_Sum_Of_Invoice_OutsidePurchade_ReplacementCost.ReplacementCost, 0)  " & _
"                       + ISNULL(dbo.View_Sum_Of_Invoice_ReplacementCost.ReplacementCost, 0) AS ReplacementCost " & _
" FROM         dbo.View_Sum_Of_Invoice_OutsidePurchade_ReplacementCost FULL OUTER JOIN " & _
"                       dbo.View_Sum_Of_Invoice_ReplacementCost ON  " & _
"                       dbo.View_Sum_Of_Invoice_OutsidePurchade_ReplacementCost.id_service_center = dbo.View_Sum_Of_Invoice_ReplacementCost.id_service_center ", CmdGeneral, False, True, "View_Sum_Of_I_AND_O_ReplacementCost")



    End Sub
    Private Sub Employee_timeTrack()
        Try
            CmdGeneral.CommandText = " ALTER TABLE employee ADD StoreNo char(2)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE employee ADD UsePunchClock bit Default 0"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " Update employee Set UsePunchClock=0 Where UsePunchClock is null"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " Update employee Set StoreNo= " & PubStoreNO & " Where StoreNo is null"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FixAdjLength()


        'Dim tran1 As SqlClient.SqlTransaction
        'tran1 = CnnLock.BeginTransaction()
        'CmdGeneralLock.Transaction = tran1



        Try
            CmdGeneralLock.CommandText = "SELECT * INTO BehTemp FROM GL_account_adjustment_head"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "UPDATE BehTemp SET refrence_no =substring(refrence_no,1,2) +'00'+substring(refrence_no,3,4) where len(ltrim(rtrim(refrence_no)))=6"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "INSERT INTO GL_account_adjustment_head SELECT  *  FROM  BehTemp"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "Drop Table BehTemp"
            CmdGeneralLock.ExecuteNonQuery()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            CmdGeneralLock.CommandText = "SELECT * INTO BehTemp FROM GL_account_adjustment_dtl"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "UPDATE BehTemp SET refrence_no =substring(refrence_no,1,2) +'00'+substring(refrence_no,3,4) where len(ltrim(rtrim(refrence_no)))=6"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "INSERT INTO GL_account_adjustment_dtl SELECT  *  FROM  BehTemp"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "Drop Table BehTemp"
            CmdGeneralLock.ExecuteNonQuery()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            CmdGeneralLock.CommandText = "SELECT * INTO BehTemp FROM GL_account_adjustment_dtl_dtl"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "UPDATE BehTemp SET refrence_no_due =substring(refrence_no_due,1,2) +'00'+substring(refrence_no_due,3,4) where len(ltrim(rtrim(refrence_no_due)))=6"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "INSERT INTO GL_account_adjustment_dtl_dtl SELECT  *  FROM  BehTemp"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "Drop Table BehTemp"
            CmdGeneralLock.ExecuteNonQuery()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'CmdGeneralLock.CommandText = "UPDATE GL_payment_deposit SET refrence_no_Adjustment  =substring(refrence_no,1,2) +'00'+substring(refrence_no,3,4) where len(ltrim(rtrim(refrence_no_Adjustment)))=6"
            'CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "Delete From GL_account_adjustment_head Where len(ltrim(rtrim(refrence_no)))=6"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "Delete From GL_account_adjustment_Dtl Where len(ltrim(rtrim(refrence_no)))=6"
            CmdGeneralLock.ExecuteNonQuery()

            CmdGeneralLock.CommandText = "Delete From GL_account_adjustment_Dtl_dtl Where len(ltrim(rtrim(refrence_no_due)))=6"
            CmdGeneralLock.ExecuteNonQuery()

            'tran1.Commit()
            MsgBox("ÊÛííÑ ßÏ ÈÇ ãæÝÞíÊ ÇäÌÇã ÔÏ")
        Catch ex As Exception
            'tran1.Rollback()
            MsgBox("ÇÔ˜Çá ÏÑ ÊÛííÑ ˜Ï")
        End Try

    End Sub

    '    Private Sub FixAp()

    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_AP_Bill_Head] ( " & _
    '"	[Id_AP_bill_Head] [char] (10) NOT NULL , " & _
    '"	[cod_vendor] [char] (6) NOT NULL , " & _
    '"	[Date_Bill] [char] (10) NULL , " & _
    '"	[Remark] [varchar] (200) NULL  " & _
    '") ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_Bill_Head] WITH NOCHECK ADD  " & _
    '"	CONSTRAINT [PK_GL_AP_Bill_Head] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[Id_AP_bill_Head] " & _
    '"	)  ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_AP_bill_Dtl] ( " & _
    '"	[Id_AP_bill_dtl] [int] IDENTITY (1, 1) NOT NULL , " & _
    '"	[Id_AP_bill_Head] [char] (10)  NULL , " & _
    '"	[ref_no] [char] (10) NULL , " & _
    '"	[AR_terms] [char] (10) NULL , " & _
    '"	[amount] [money] NULL , " & _
    '"	[Discount] [money] NULL , " & _
    '"	[id_GL_journal] [int] NULL , " & _
    '"	[Ref_date] [char] (10) NULL , " & _
    '"	[Desc_Bill] [varchar] (100) NULL  " & _
    '") ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = " ALTER TABLE [dbo].[GL_AP_bill_Dtl] WITH NOCHECK ADD  " & _
    '"	CONSTRAINT [PK_GL_AP_bill] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[Id_AP_bill_dtl] " & _
    '"	)  ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_bill_Dtl] ADD " & _
    '    "	CONSTRAINT [FK_GL_AP_bill_Dtl_GL_AP_Bill_Head] FOREIGN KEY  " & _
    '    "	( " & _
    '    "		[Id_AP_bill_Head] " & _
    '    "	) REFERENCES [dbo].[GL_AP_Bill_Head] ( " & _
    '    "		[Id_AP_bill_Head] " & _
    '    "	) ON DELETE CASCADE  ON UPDATE CASCADE , " & _
    '    "	CONSTRAINT [FK_GL_AP_bill_GL_TAB_AR_TERM] FOREIGN KEY  " & _
    '    "	( " & _
    '    "		[AR_terms] " & _
    '    "	) REFERENCES [dbo].[GL_TAB_AR_TERM] ( " & _
    '    "		[AR_terms] " & _
    '    "	) ON UPDATE CASCADE "
    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_AP_bill_Dtl_Dtl] ( " & _
    '"	[Id_AP_bill_dtl_dtl] [int] IDENTITY (1, 1) NOT NULL , " & _
    '"	[Id_AP_bill_dtl] [int] NULL , " & _
    '"	[amount] [money] NULL , " & _
    '"	[due_date] [char] (10) NULL  " & _
    '" ) ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_bill_Dtl_Dtl] WITH NOCHECK ADD  " & _
    '"	CONSTRAINT [PK_GL_AP_bill_Dtl] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[Id_AP_bill_dtl_dtl] " & _
    '"	)  ON [PRIMARY]  "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_bill_Dtl_Dtl] ADD  " & _
    '"	CONSTRAINT [FK_GL_AP_bill_Dtl_GL_AP_bill] FOREIGN KEY  " & _
    '"	( " & _
    '"		[Id_AP_bill_dtl] " & _
    '"	) REFERENCES [dbo].[GL_AP_bill_Dtl] ( " & _
    '"		[Id_AP_bill_dtl] " & _
    '"	) ON DELETE CASCADE  ON UPDATE CASCADE  "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_payment_bill] ( " & _
    '"	[Id_payment_bill] [int] IDENTITY (1, 1) NOT NULL , " & _
    '"	[date_payment_bill] [char] (10) NULL , " & _
    '"	[amount_pay] [money] NULL , " & _
    '"	[id_receive_ref] [char] (6) NULL , " & _
    '"	[id_service_center] [char] (10) NULL , " & _
    '"	[radif] [smallint] NULL , " & _
    '"	[Id_AP_bill_dtl_dtl] [int] NULL , " & _
    '"	[id_check] [int] NULL  " & _
    '" ) ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_bill] WITH NOCHECK ADD  " & _
    '"	CONSTRAINT [PK_GL_payment_bill] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[Id_payment_bill] " & _
    '"	)  ON [PRIMARY]  "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_bill] ADD  " & _
    '"	CONSTRAINT [FK_GL_payment_bill_GL_AP_bill_Dtl] FOREIGN KEY  " & _
    '"	( " & _
    '"		[Id_AP_bill_dtl_dtl] " & _
    '"	) REFERENCES [dbo].[GL_AP_bill_Dtl_Dtl] ( " & _
    '"		[Id_AP_bill_dtl_dtl] " & _
    '"	), " & _
    '"	CONSTRAINT [FK_GL_payment_bill_Inv_Receive_Products_head] FOREIGN KEY  " & _
    '"	( " & _
    '"		[id_receive_ref] " & _
    '"	) REFERENCES [dbo].[Inv_Receive_Products_head] ( " & _
    '"		[id_receive_ref] " & _
    '"	), " & _
    '"	CONSTRAINT [FK_GL_payment_bill_service_out_purchases] FOREIGN KEY  " & _
    '"	( " & _
    '"		[id_service_center], " & _
    '"		[radif] " & _
    '"	) REFERENCES [dbo].[service_out_purchases] ( " & _
    '"		[id_service_center], " & _
    '"		[radif] " & _
    '"	) "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_payment_bill_COA] ( " & _
    '"	[Id_AP_bill_dtl] [int] NOT NULL , " & _
    '"	[GL_account] [varchar] (10) NOT NULL , " & _
    '"	[Amount] [money] NULL , " & _
    '"	[Memo] [varchar] (100) NULL  " & _
    '") ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_bill_COA] WITH NOCHECK ADD  " & _
    '"	CONSTRAINT [PK_GL_payment_bill_COA] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[Id_AP_bill_dtl], " & _
    '"		[GL_account] " & _
    '"	)  ON [PRIMARY]  "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_bill_COA] ADD  " & _
    '"	CONSTRAINT [FK_GL_payment_bill_COA_GL_account] FOREIGN KEY  " & _
    '"	( " & _
    '"		[GL_account] " & _
    '"	) REFERENCES [dbo].[GL_account] ( " & _
    '"		[GL_account] " & _
    '"	) ON UPDATE CASCADE , " & _
    '"	CONSTRAINT [FK_GL_payment_bill_COA_GL_AP_bill] FOREIGN KEY  " & _
    '"	( " & _
    '"		[Id_AP_bill_dtl] " & _
    '"	) REFERENCES [dbo].[GL_AP_bill_Dtl] ( " & _
    '"		[Id_AP_bill_dtl] " & _
    '"	) ON DELETE CASCADE  ON UPDATE CASCADE  "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_AP_payment] ( " & _
    '"	[ID_AP_payment] [int] IDENTITY (1, 1) NOT NULL , " & _
    '"	[Id_AP_bill_dtl_dtl] [int] NULL , " & _
    '"	[ID_Inv_Receive_product_Ap_Dtl] [int] NULL , " & _
    '"	[id_service_center] [char] (10) NULL , " & _
    '"	[radif] [smallint] NULL , " & _
    '"	[amount_pay] [money] NOT NULL , " & _
    '"	[remark] [varchar] (50) NULL , " & _
    '"	[date_prepare] [char] (10) NOT NULL , " & _
    '"	[id_check] [int] NULL , " & _
    '"	[radif1] [smallint] NULL , " & _
    '"	[id_vendor_credit] [int] NULL " & _
    '" ) ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_payment] WITH NOCHECK ADD  " & _
    '"	CONSTRAINT [PK_GL_AP_payment] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[ID_AP_payment] " & _
    '"	)  ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_payment] ADD " & _
    '"	CONSTRAINT [FK_GL_AP_payment_bank_check_dtl] FOREIGN KEY " & _
    '"	(" & _
    '"		[id_check]," & _
    '"		[radif]" & _
    '"	) REFERENCES [dbo].[bank_check_dtl] (" & _
    '"		[id_check]," & _
    '"		[radif]" & _
    '"	)," & _
    '"	CONSTRAINT [FK_GL_AP_payment_GL_AP_bill_Dtl_Dtl] FOREIGN KEY " & _
    '"	(" & _
    '"		[Id_AP_bill_dtl_dtl]" & _
    '"	) REFERENCES [dbo].[GL_AP_bill_Dtl_Dtl] (" & _
    '"		[Id_AP_bill_dtl_dtl]" & _
    '"	)," & _
    '"	CONSTRAINT [FK_GL_AP_payment_GL_vendor_credit] FOREIGN KEY " & _
    '"	(" & _
    '"		[id_vendor_credit]" & _
    '"	) REFERENCES [dbo].[GL_vendor_credit] (" & _
    '"		[id_vendor_credit]" & _
    '"	)," & _
    '"	CONSTRAINT [FK_GL_AP_payment_Inv_Receive_product_Ap_Dtl] FOREIGN KEY " & _
    '"	(" & _
    '"		[ID_Inv_Receive_product_Ap_Dtl]" & _
    '"	) REFERENCES [dbo].[Inv_Receive_product_Ap_Dtl] (" & _
    '"		[ID_Inv_Receive_product_Ap_Dtl]" & _
    '"	)," & _
    '"	CONSTRAINT [FK_GL_AP_payment_service_out_purchases] FOREIGN KEY " & _
    '"	(" & _
    '"		[id_service_center]," & _
    '"		[radif]" & _
    '"	) REFERENCES [dbo].[service_out_purchases] (" & _
    '"		[id_service_center]," & _
    '"		[radif] " & _
    '"	) "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_vendor_credit] ( " & _
    '"	[id_vendor_credit] [int] IDENTITY (1, 1) NOT NULL , " & _
    '"	[cod_vendor] [char] (6) NOT NULL , " & _
    '"	[date_credit] [char] (10) NULL , " & _
    '"	[amount_credit] [money] NOT NULL , " & _
    '"	[Remark] [varchar] (100) NULL  " & _
    '" ) ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_vendor_credit] WITH NOCHECK ADD  " & _
    '"	CONSTRAINT [PK_GL_vendor_credit] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[id_vendor_credit] " & _
    '"	)  ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_vendor_credit] ADD " & _
    '"	CONSTRAINT [DF_GL_vendor_credit_amount_credit] DEFAULT (0) FOR [amount_credit]"

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_vendor_credit] ADD  " & _
    '"	CONSTRAINT [FK_GL_vendor_credit_inv_vendor] FOREIGN KEY  " & _
    '"	( " & _
    '"		[cod_vendor] " & _
    '"	) REFERENCES [dbo].[inv_vendor] ( " & _
    '"		[cod_vendor] " & _
    '"	) ON UPDATE CASCADE "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "CREATE TABLE [dbo].[Inv_Receive_product_Ap_Dtl] ( " & _
    '"	[ID_Inv_Receive_product_Ap_Dtl] [int] IDENTITY (1, 1) NOT NULL , " & _
    '"	[id_receive_ref] [char] (6) NOT NULL , " & _
    '"	[amount] [money] NOT NULL , " & _
    '"	[due_date] [char] (10) NOT NULL  " & _
    '") ON [PRIMARY] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[Inv_Receive_product_Ap_Dtl] WITH NOCHECK ADD " & _
    '"	CONSTRAINT [PK_Inv_Receive_product_Ap_Dtl] PRIMARY KEY  CLUSTERED  " & _
    '"	( " & _
    '"		[ID_Inv_Receive_product_Ap_Dtl] " & _
    '"	)  ON [PRIMARY]  "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[Inv_Receive_product_Ap_Dtl] ADD  " & _
    '"	CONSTRAINT [DF_Inv_Receive_product_Ap_Dtl_amount] DEFAULT (0) FOR [amount] "

    '            CmdGeneral.ExecuteNonQuery()

    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[Inv_Receive_product_Ap_Dtl] ADD  " & _
    '"	CONSTRAINT [FK_Inv_Receive_product_Ap_Dtl_Inv_Receive_Products_head] FOREIGN KEY  " & _
    '"	( " & _
    '"		[id_receive_ref] " & _
    '"	) REFERENCES [dbo].[Inv_Receive_Products_head] ( " & _
    '"		[id_receive_ref] " & _
    '"	) ON DELETE CASCADE  ON UPDATE CASCADE  "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "CREATE VIEW dbo.View_AllUnPaidGl_Ap_Bill_Dtl_Dtl AS " & _
    '" SELECT     dbo.GL_AP_bill_Dtl_Dtl.amount AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment,dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl " & _
    '" FROM         dbo.GL_AP_bill_Dtl_Dtl LEFT OUTER JOIN dbo.GL_AP_payment ON dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = dbo.GL_AP_payment.Id_AP_bill_dtl_dtl " & _
    '" GROUP BY dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, dbo.GL_AP_bill_Dtl_Dtl.amount "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "CREATE VIEW dbo.View_AllUnPaidReceive_product_ap_Dtl AS " & _
    '" SELECT     dbo.Inv_Receive_product_Ap_Dtl.amount AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment, " & _
    '"                     dbo.Inv_Receive_Products_head.id_receive_ref, dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl  " & _
    '" FROM         dbo.Inv_Receive_product_Ap_Dtl INNER JOIN  " & _
    '"                      dbo.Inv_Receive_Products_head ON  " & _
    '"                      dbo.Inv_Receive_product_Ap_Dtl.id_receive_ref = dbo.Inv_Receive_Products_head.id_receive_ref LEFT OUTER JOIN " & _
    '"                      dbo.GL_AP_payment ON  " & _
    '"                      dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
    '" GROUP BY dbo.Inv_Receive_Products_head.id_receive_ref, dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl,  " & _
    '"                      dbo.Inv_Receive_product_Ap_Dtl.amount "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "CREATE VIEW dbo.View_AllUnPaidService_out_purchase AS " & _
    '" SELECT     TOP 100 PERCENT ROUND(ISNULL(dbo.service_out_purchases.cost, 0), 2) AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay),  " & _
    '"                      0) AS sumpayment, dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif " & _
    '" FROM         dbo.service_out_purchases LEFT OUTER JOIN " & _
    '"                      dbo.GL_AP_payment ON dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
    '"                      dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
    '" GROUP BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif, ROUND(ISNULL(dbo.service_out_purchases.cost, 0), 2) " & _
    '" ORDER BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AP_Bill_Dtl_Min_due_date]') and OBJECTPROPERTY(id, N'IsView') = 1) " & _
    '" drop view [dbo].[View_AP_Bill_Dtl_Min_due_date] "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = " CREATE VIEW dbo.View_AP_Bill_Dtl_Min_due_date " & _
    '" AS  " & _
    '" SELECT     MIN(dbo.ChangeDate(due_date)) AS Min_due_date, Id_AP_bill_dtl  " & _
    '" FROM         dbo.GL_AP_bill_Dtl_Dtl  " & _
    '" GROUP BY Id_AP_bill_dtl "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = " create view View_GL_vendor_creditReminder as SELECT     dbo.GL_vendor_credit.cod_vendor, ISNULL(dbo.GL_vendor_credit.amount_credit, 0) AS SumCreadit, ISNULL(SUM(dbo.GL_AP_payment.amount_pay),0) AS SumPayment, ISNULL(dbo.GL_vendor_credit.amount_credit, 0) - ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS Reminder, dbo.GL_vendor_credit.id_vendor_credit " & _
    '" FROM         dbo.GL_vendor_credit LEFT OUTER JOIN " & _
    '"                      dbo.GL_AP_payment ON dbo.GL_vendor_credit.id_vendor_credit = dbo.GL_AP_payment.id_vendor_credit " & _
    '" GROUP BY dbo.GL_vendor_credit.cod_vendor, dbo.GL_vendor_credit.id_vendor_credit, dbo.GL_vendor_credit.amount_credit " & _
    '" HAVING      (ISNULL(dbo.GL_vendor_credit.amount_credit, 0) - ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) > 0) "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_payment] ADD " & _
    '                                    "	CONSTRAINT [FK_GL_AP_payment_GL_AP_bill_Dtl_Dtl] FOREIGN KEY " & _
    '                                    "	(" & _
    '                                    "		[Id_AP_bill_dtl_dtl]" & _
    '                                    "	) REFERENCES [dbo].[GL_AP_bill_Dtl_Dtl] (" & _
    '                                    "		[Id_AP_bill_dtl_dtl]" & _
    '                                    "	)," & _
    '                                    "	CONSTRAINT [FK_GL_AP_payment_GL_vendor_credit] FOREIGN KEY " & _
    '                                    "	(" & _
    '                                    "		[id_vendor_credit]" & _
    '                                    "	) REFERENCES [dbo].[GL_vendor_credit] (" & _
    '                                    "		[id_vendor_credit]" & _
    '                                    "	)," & _
    '                                    "	CONSTRAINT [FK_GL_AP_payment_Inv_Receive_product_Ap_Dtl] FOREIGN KEY " & _
    '                                    "	(" & _
    '                                    "		[ID_Inv_Receive_product_Ap_Dtl]" & _
    '                                    "	) REFERENCES [dbo].[Inv_Receive_product_Ap_Dtl] (" & _
    '                                    "		[ID_Inv_Receive_product_Ap_Dtl]" & _
    '                                    "	)," & _
    '                                    "	CONSTRAINT [FK_GL_AP_payment_service_out_purchases] FOREIGN KEY " & _
    '                                    "	(" & _
    '                                    "		[id_service_center]," & _
    '                                    "		[radif]" & _
    '                                    "	) REFERENCES [dbo].[service_out_purchases] (" & _
    '                                    "		[id_service_center]," & _
    '                                    "		[radif]" & _
    '                                    "	)"

    '        Try
    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try

    '    End Sub
    Private Sub Fixed_bas_vehicle()
        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[bas_vehicle_size] Drop CONSTRAINT [FK_bas_vehicle_size_bas_vehicle]"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[bas_vehicle_size] ADD CONSTRAINT [FK_bas_vehicle_size_bas_vehicle] FOREIGN KEY ([cod_vehicle]) REFERENCES [dbo].[bas_vehicle] ([cod_vehicle])  ON DELETE CASCADE  ON UPDATE CASCADE "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        DsFrmUpdateDatabase1.bas_vehicle.Clear()
        DAbas_vehicle.Fill(DsFrmUpdateDatabase1.bas_vehicle)
        Dim i As Integer
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim TempVar As Decimal
        For i = 0 To DsFrmUpdateDatabase1.bas_vehicle.Rows.Count - 1
            CmdGeneral.CommandText = "UPDATE bas_vehicle SET cod_vehicle=" & Qt(Getcod(i + 1, 4)) & " WHERE cod_vehicle=" & Qt(DsFrmUpdateDatabase1.bas_vehicle.Rows(i).Item("cod_vehicle"))
            CmdGeneral.ExecuteNonQuery()
        Next
    End Sub
    Private Sub FixedAfterUpdate1()
        Try
            CmdGeneral.CommandText = " UPDATE Gl_receive_payment SET FromStoreNo ='01' Where FromStoreNo='04' "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " UPDATE Gl_receive_payment SET FromStoreNo ='02' Where FromStoreNo='05' "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " UPDATE Gl_receive_payment SET FromStoreNo ='03' Where FromStoreNo='06' "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE bas_banks ADD WWW Varchar(50)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = "UPDATE inv_vendor SET vendor_since ='09/01/2007' WHERE vendor_since ='Oct  1 200'"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "insert into  service_out_purchases (id_service_center,radif,fet,cost) select id_service_center,radif,round(fet,2) as fet,round(price,2)  as cost from service_center_dtl where type_select='O' and  id_service_center+str(radif) not in ( select id_service_center+str(radif) from service_out_purchases)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        CmdGeneral.CommandText = "alter table GL_TAB_AR_TERM add MP_First_PAYMENT smallint DEFAULT 0"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "Update GL_TAB_AR_TERM set MP_First_PAYMENT =0 where MP_First_PAYMENT is null"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "delete from inv_tab_tire_specification where item_no not in ( select item_no from inv_item)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "insert into inv_tab_tire_specification (item_no,tire_size) select item_no,'0' as tire_size from inv_item where cod_item_type='01' and item_no not in (select item_no  from inv_tab_tire_specification) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "delete from inv_item_vendor where item_no not in ( select item_no from inv_item)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[inv_item_vendor] ADD CONSTRAINT [FK_inv_item_vendor_inv_item] FOREIGN KEY ([item_no]) REFERENCES [dbo].[inv_item] ([item_no])  ON DELETE CASCADE  ON UPDATE CASCADE "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[inv_tab_tire_specification] ADD CONSTRAINT [FK_inv_tab_tire_specification_inv_item] FOREIGN KEY ([item_no]) REFERENCES [dbo].[inv_item] ([item_no])   ON UPDATE CASCADE "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = "UPDATE service_center_head SET add_user = 1 WHERE add_user IS NULL "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " DELETE FROM GL_payment_deposit WHERE     (SUBSTRING(id_service_center, 1, 2) = 'WO') "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Customer_Balance]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Customer_Balance] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Customer_Balance AS SELECT     cod_customer, " & _
                            " (SELECT   isnull(SUM(round(dbo.GL_payment_deposit.payment_amount, 2) - round(dbo.GL_payment_deposit.paid_amount, 2)), 0) AS Customer_AR_Bedehy1 " & _
                            "  FROM  dbo.service_center_head INNER JOIN dbo.GL_payment_deposit ON dbo.service_center_head.id_service_center = dbo.GL_payment_deposit.id_service_center LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                            "  WHERE     (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.cod_customer = dbo.service_center_head.cod_customer) - " & _
                            " (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS payment_amount FROM GL_payment_deposit INNER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
                            " WHERE     (GL_payment_deposit.refrence_no_Adjustment IS NOT NULL) AND A.cod_customer = dbo.Gl_receive_payment.cod_customer)  + " & _
                            " (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Pardakht2 " & _
                            "  FROM         dbo.GL_account_adjustment_head " & _
                            "  WHERE     A.cod_customer = GL_account_adjustment_head.cod_customer) - " & _
                            " (SELECT     BalanceOverPaymentAmount FROM View_Balance_OverPayment_Amount WHERE A.cod_customer = View_Balance_overPayment_Amount.cod_customer)  " & _
                            " AS BalanceAmount " & _
                            " FROM         dbo.cust_trtab_main A GROUP BY cod_customer  "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Paid_Amount_BySumOfDetail]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Paid_Amount_BySumOfDetail] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Paid_Amount_BySumOfDetail AS  " & _
                            " SELECT     ISNULL(SUM(ROUND(dbo.GL_payment_deposit.payment_amount, 2)), 0) AS Paid_amount, dbo.GL_payment_deposit_Detail.ID_payment_due " & _
                            " FROM         dbo.GL_payment_deposit_Detail INNER JOIN dbo.GL_payment_deposit ON dbo.GL_payment_deposit_Detail.ID_payment_Paid = dbo.GL_payment_deposit.ID_payment " & _
                            " GROUP BY dbo.GL_payment_deposit_Detail.ID_payment_due  "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerBalance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerBalance]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE PROCEDURE SP_CustomerBalance  " & _
"   @ThisDate  as char(10),@ThisCustomer  as char(10) =NULL ,@Flag  as Char(1) = NULL AS IF @Flag IS NULL  IF @ThisCustomer IS NULL " & _
"      SELECT    Cod_customer , " & _
" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2) ), 0)  " & _
"                       AS Customer_AR_Bedehy1 " & _
" FROM         service_center_head INNER JOIN " & _
"                       GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
"                       GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment  WHERE    (dbo.ChangeDate(dbo.service_center_head.date_refer)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.cod_customer = dbo.service_center_head.cod_customer) - " & _
" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Paid1 " & _
" FROM         GL_payment_deposit INNER JOIN " & _
"                       Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
" WHERE    (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '2' OR dbo.GL_payment_deposit.refer_type = '3' )   AND A.cod_customer = dbo.Gl_receive_payment.cod_customer)  " & _
" +  (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2    FROM         dbo.GL_account_adjustment_head  WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment)<=dbo.ChangeDate(@ThisDate)) AND A.cod_customer = GL_account_adjustment_head.cod_customer)   AS BalanceAmount  FROM         dbo.cust_trtab_main A  " & _
" else " & _
"      SELECT    " & _
" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2) ), 0)  " & _
"                       AS Customer_AR_Bedehy1 " & _
" FROM         service_center_head INNER JOIN " & _
"                       GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
"                       GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment  WHERE    (dbo.ChangeDate(dbo.service_center_head.date_refer)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.cod_customer = dbo.service_center_head.cod_customer) - " & _
" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Paid1 " & _
" FROM         GL_payment_deposit INNER JOIN " & _
"                       Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
" WHERE    (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '2' OR dbo.GL_payment_deposit.refer_type = '3' )   AND A.cod_customer = dbo.Gl_receive_payment.cod_customer)  " & _
" +  (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2    FROM         dbo.GL_account_adjustment_head  WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment)<=dbo.ChangeDate(@ThisDate)) AND A.cod_customer = GL_account_adjustment_head.cod_customer)   AS BalanceAmount  FROM         dbo.cust_trtab_main A Where cod_customer=@ThisCustomer " & _
" else  " & _
" SELECT     * FROM   ( " & _
"      SELECT    Cod_customer , " & _
" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2) ), 0)  " & _
"                       AS Customer_AR_Bedehy1 " & _
" FROM         service_center_head INNER JOIN " & _
"                       GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
"                       GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment  WHERE    (dbo.ChangeDate(dbo.service_center_head.date_refer)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.cod_customer = dbo.service_center_head.cod_customer) - " & _
" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Paid1 " & _
" FROM         GL_payment_deposit INNER JOIN " & _
"                       Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
" WHERE    (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '2' OR dbo.GL_payment_deposit.refer_type = '3' )   AND A.cod_customer = dbo.Gl_receive_payment.cod_customer)  " & _
" +  (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2    FROM         dbo.GL_account_adjustment_head  WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment)<=dbo.ChangeDate(@ThisDate)) AND A.cod_customer = GL_account_adjustment_head.cod_customer)   AS BalanceAmount  FROM         dbo.cust_trtab_main A  " & _
" ) DERIVEDTBL WHERE     (BalanceAmount <> 0)"
            CmdGeneral.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerBalanceForStatement]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerBalanceForStatement]"
            CmdGeneral.ExecuteNonQuery()
            '        CmdGeneral.CommandText = " CREATE PROCEDURE SP_CustomerBalanceForStatement  " & _
            '"@ThisDate AS char(10), @StoreCode AS Char(2) , @StoreName AS Char(50) , @descript AS Char(50) AS  " & _
            '" SELECT     * FROM   ( " & _
            '"      SELECT    Cod_customer ,@storeCode as StoreCode,@storeName as StoreName,@descript as Descript,@ThisDate as Date, " & _
            '" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2) ), 0)  " & _
            '"                       AS Customer_AR_Bedehy1 " & _
            '" FROM         service_center_head INNER JOIN " & _
            '"                       GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN " & _
            '"                       GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment  WHERE    (dbo.ChangeDate(dbo.service_center_head.date_refer)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.cod_customer = dbo.service_center_head.cod_customer) - " & _
            '" (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Paid1 " & _
            '" FROM         GL_payment_deposit INNER JOIN " & _
            '"                       Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
            '" WHERE    (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '2' OR dbo.GL_payment_deposit.refer_type = '3' )   AND A.cod_customer = dbo.Gl_receive_payment.cod_customer)  " & _
            '" +  (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2    FROM         dbo.GL_account_adjustment_head  WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment)<=dbo.ChangeDate(@ThisDate)) AND A.cod_customer = GL_account_adjustment_head.cod_customer)   AS BalanceAmount  FROM         dbo.cust_trtab_main A  " & _
            '" ) DERIVEDTBL WHERE  Cod_customer in  (SELECT     cod_customer  FROM         View_Customer_Balance WHERE     (BalanceAmount <> 0))  AND   (BalanceAmount <> 0)"







            CmdGeneral.CommandText = " CREATE PROCEDURE SP_CustomerBalanceForStatement  @ThisDate AS char(10), @StoreCode AS Char(2) , @StoreName AS Char(50) , @descript AS Char(50),@Todate as char(10) AS SELECT     * "
            CmdGeneral.CommandText += " FROM         (SELECT     Cod_customer, @storeCode AS StoreCode, @storeName AS StoreName, @descript AS Descript, @ThisDate AS Date, "
            CmdGeneral.CommandText += "                                                  (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Bedehy1 "
            CmdGeneral.CommandText += "                                                     FROM         service_center_head INNER JOIN "
            CmdGeneral.CommandText += "                                                                           GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN "
            CmdGeneral.CommandText += "                                                                           GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment "
            CmdGeneral.CommandText += "                                                     WHERE     (dbo.ChangeDate(dbo.service_center_head.date_refer) < dbo.ChangeDate(@ThisDate)) AND  "
            CmdGeneral.CommandText += "                                                                           (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND "
            CmdGeneral.CommandText += "                                                                           (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND  "
            CmdGeneral.CommandText += "                                                                           A.cod_customer = dbo.service_center_head.cod_customer) - "
            CmdGeneral.CommandText += "                                                  (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Paid1 "
            CmdGeneral.CommandText += "                                                     FROM         GL_payment_deposit INNER JOIN "
            CmdGeneral.CommandText += "                                                                           Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no "
            CmdGeneral.CommandText += "                                                     WHERE     (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment) < dbo.ChangeDate(@ThisDate)) AND  "
            CmdGeneral.CommandText += "                                                                           (dbo.GL_payment_deposit.refer_type = '2' OR "
            CmdGeneral.CommandText += "                                                                           dbo.GL_payment_deposit.refer_type = '3') AND A.cod_customer = dbo.Gl_receive_payment.cod_customer) + "
            CmdGeneral.CommandText += "                                                  (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2 "
            CmdGeneral.CommandText += "                                                     FROM         dbo.GL_account_adjustment_head "
            CmdGeneral.CommandText += "                                                     WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment) < dbo.ChangeDate(@ThisDate)) AND  "
            CmdGeneral.CommandText += "                                                                           A.cod_customer = GL_account_adjustment_head.cod_customer) AS BalanceAmount "
            CmdGeneral.CommandText += "                        FROM         dbo.cust_trtab_main A) DERIVEDTBL "
            CmdGeneral.CommandText += " WHERE     Cod_customer IN "
            CmdGeneral.CommandText += "                          (SELECT     cod_customer "
            CmdGeneral.CommandText += "                             FROM        (SELECT     Cod_customer, "
            CmdGeneral.CommandText += "                                                  (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Bedehy1 "
            CmdGeneral.CommandText += "                                                     FROM         service_center_head INNER JOIN "
            CmdGeneral.CommandText += "                                                                           GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN "
            CmdGeneral.CommandText += "                                                                           GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment "
            CmdGeneral.CommandText += "                                                     WHERE     (dbo.ChangeDate(dbo.service_center_head.date_refer) < dbo.ChangeDate(@ToDate)) AND  "
            CmdGeneral.CommandText += "                                                                           (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND  "
            CmdGeneral.CommandText += "                                                                           (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND  "
            CmdGeneral.CommandText += "                                                                           b.cod_customer = dbo.service_center_head.cod_customer) - "
            CmdGeneral.CommandText += "                                                  (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Customer_AR_Paid1 "
            CmdGeneral.CommandText += "                                                     FROM         GL_payment_deposit INNER JOIN "
            CmdGeneral.CommandText += "                                                                           Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no "
            CmdGeneral.CommandText += "                                                     WHERE     (dbo.ChangeDate(dbo.Gl_receive_payment.date_receive_payment) < dbo.ChangeDate(@ToDate)) AND  "
            CmdGeneral.CommandText += "                                                                           (dbo.GL_payment_deposit.refer_type = '2' OR "
            CmdGeneral.CommandText += "                                                                           dbo.GL_payment_deposit.refer_type = '3') AND b.cod_customer = dbo.Gl_receive_payment.cod_customer) + "
            CmdGeneral.CommandText += "                                                  (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2 "
            CmdGeneral.CommandText += "                                                     FROM         dbo.GL_account_adjustment_head "
            CmdGeneral.CommandText += "                                                     WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment) < dbo.ChangeDate(@ToDate)) AND  "
            CmdGeneral.CommandText += "                                                                           b.cod_customer = GL_account_adjustment_head.cod_customer) AS BalanceAmount "
            CmdGeneral.CommandText += "                        FROM         dbo.cust_trtab_main b ) DERIVEDTBL where balanceamount <> 0 ) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            CmdGeneral.CommandText = " ALTER TABLE cust_trtab_main ADD PrintStatementDetailFlag bit DEFAULT  0"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " UPDATE cust_trtab_main  SET PrintStatementDetailFlag = 1 WHERE  PrintStatementDetailFlag IS NULL"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try



        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_account_adjustment_dtl_dtl ADD old_amount_adjustment money DEFAULT  0 "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " update GL_account_adjustment_head set Old_Amount_adjustment=0 where Old_Amount_adjustment is null "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Try
            CmdGeneral.CommandText = " update gl_account_adjustment_dtl_dtl set old_amount_adjustment=amount_adjustment where refrence_no_due in (select GL_account_adjustment_head.refrence_no " & _
                       " FROM GL_account_adjustment_head INNER JOIN GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no INNER JOIN " & _
                       " GL_account_adjustment_dtl_dtl ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_dtl_dtl.refrence_no_due AND GL_account_adjustment_dtl.id_service_center = GL_account_adjustment_dtl_dtl.id_service_center_due " & _
                       " WHERE     (GL_account_adjustment_head.finance_charge_flag = 1) AND (GL_account_adjustment_dtl_dtl.amount_adjustment <> 0) AND (GL_account_adjustment_head.amount_adjustment = 0)) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            CmdGeneral.CommandText = " update gl_account_adjustment_dtl_dtl set amount_adjustment=0 where refrence_no_due in (select  GL_account_adjustment_head.refrence_no " & _
                       " FROM         GL_account_adjustment_head INNER JOIN GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no INNER JOIN" & _
                       " GL_account_adjustment_dtl_dtl ON GL_account_adjustment_dtl.refrence_no = GL_account_adjustment_dtl_dtl.refrence_no_due AND GL_account_adjustment_dtl.id_service_center = GL_account_adjustment_dtl_dtl.id_service_center_due " & _
                       " WHERE     (GL_account_adjustment_head.finance_charge_flag = 1) AND (GL_account_adjustment_dtl_dtl.amount_adjustment <> 0) AND (GL_account_adjustment_head.amount_adjustment = 0)) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        DsFrmUpdateDatabase1.UpdatePaidAmount.Clear()
        DAUpdatePaidAmount.Fill(DsFrmUpdateDatabase1.UpdatePaidAmount)
        Dim i As Integer
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim TempVar As Decimal
        For i = 0 To DsFrmUpdateDatabase1.UpdatePaidAmount.Rows.Count - 1
            CmdGeneral.CommandText = "SELECT     isnull(SUM(ROUND(GL_payment_deposit.payment_amount, 2)),0) AS Expr1 FROM         GL_payment_deposit_Detail INNER JOIN GL_payment_deposit ON GL_payment_deposit_Detail.ID_payment_Paid = GL_payment_deposit.ID_payment WHERE  GL_payment_deposit_Detail.ID_payment_due=" & DsFrmUpdateDatabase1.UpdatePaidAmount.Rows(i).Item("ID_payment")
            TempVar = CmdGeneral.ExecuteScalar
            If TempVar <> Math.Round(DsFrmUpdateDatabase1.UpdatePaidAmount.Rows(i).Item("Paid_amount"), 2) Then
                TextBox1.Text = TextBox1.Text & " ID PAYMENT : " & DsFrmUpdateDatabase1.UpdatePaidAmount.Rows(i).Item("ID_payment") & vbCrLf
                CmdGeneral.CommandText = "Update GL_payment_deposit Set Paid_amount= " & TempVar & " WHERE  ID_payment=" & DsFrmUpdateDatabase1.UpdatePaidAmount.Rows(i).Item("ID_payment")
                CmdGeneral.ExecuteNonQuery()
            End If
        Next



    End Sub
    Private Sub Fixed860601()

        Try
            CmdGeneral.CommandText = " UPDATE cust_trtab_main SET AR_charge = 1, AR_credit_hold = 1 WHERE (cod_customer IN  " & _
               " (SELECT DISTINCT service_center_head.cod_customer FROM   GL_payment_deposit INNER JOIN " & _
               " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
               " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer " & _
               " WHERE     (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND (cust_trtab_main.AR_charge = 0))) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Fixed860528()
        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Balance_OtherStore]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Balance_OtherStore] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Balance_OtherStore AS SELECT     cod_customer, SUM(ROUND(ISNULL(OtherStoreAmount, 0), 2)) AS OtherStore " & _
              " FROM         dbo.Gl_receive_payment " & _
               " GROUP BY cod_customer "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Customer_Total_Charge_Credit_adj]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Customer_Total_Charge_Credit_adj] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Customer_Total_Charge_Credit_adj AS  SELECT     dbo.cust_trtab_main.cod_customer, ISNULL(dbo.View_Total_Balance_ForEach_ARDue.AR_Amount, 0) AS Charge,  " & _
"  ISNULL(dbo.View_Total_Balance_ForEach_ARDue.AR_Amount, 0) - ISNULL(dbo.View_Total_Balance_ForEach_ARDue.BalanceAmount, 0) AS Credit,  " & _
"  ISNULL(dbo.View_Total_Balance_ForEach_ARDue.AR_Adj_Amount, 0) AS Adjustment,  " & _
"  ISNULL(dbo.View_Balance_DownPayment_Amount.BalanceDownPaymentAmount, 0) AS DownPayment,  " & _
"  ISNULL(dbo.View_Balance_For_Each_OverPayment.BalanceOverPaymentAmount, 0) AS OverPayment,  " & _
"  ISNULL(dbo.View_Balance_OtherStore.OtherStore, 0) AS OtherStore " & _
"  FROM         dbo.cust_trtab_main LEFT OUTER JOIN " & _
"  dbo.View_Balance_OtherStore ON dbo.cust_trtab_main.cod_customer = dbo.View_Balance_OtherStore.cod_customer LEFT OUTER JOIN " & _
"  dbo.View_Balance_For_Each_OverPayment ON  " & _
"  dbo.cust_trtab_main.cod_customer = dbo.View_Balance_For_Each_OverPayment.cod_customer LEFT OUTER JOIN " & _
"  dbo.View_Total_Balance_ForEach_ARDue ON  " & _
"  dbo.cust_trtab_main.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer LEFT OUTER JOIN " & _
"  dbo.View_Balance_DownPayment_Amount ON dbo.cust_trtab_main.cod_customer = dbo.View_Balance_DownPayment_Amount.cod_customer "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit] ADD  CONSTRAINT [FK_GL_payment_deposit_GL_account_adjustment_head] FOREIGN KEY 	( [refrence_no_Adjustment] ) REFERENCES [dbo].[GL_account_adjustment_head] ( [refrence_no]	)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Fixed860520()
        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_account_adjustment_head] ADD CONSTRAINT [FK_GL_account_adjustment_head_Gl_receive_payment] FOREIGN KEY ( [Gl_receive_payment_Refrence_no] ) REFERENCES [dbo].[Gl_receive_payment] ([refrence_no]) ON DELETE CASCADE "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit_Detail] ADD CONSTRAINT [FK_GL_payment_deposit_Detail_GL_payment_deposit] FOREIGN KEY ([ID_payment_Paid] ) REFERENCES [dbo].[GL_payment_deposit] ([ID_payment]) ON DELETE CASCADE"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit_Detail] ADD 	CONSTRAINT [FK_GL_payment_deposit_Detail_GL_payment_deposit] FOREIGN KEY ([ID_payment_Paid]) REFERENCES [dbo].[GL_payment_deposit] ([ID_payment] ) ON DELETE CASCADE"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAgingNotDueYet]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAgingNotDueYet]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE  PROCEDURE SP_CustomerAgingNotDueYet   @ThisDate  as char(10) " & _
                "   ,@ThisCustomer  as char(10) =NULL  ,@Flag  as Char(1) = NULL AS IF @Flag IS NULL " & _
                "     IF @ThisCustomer IS NULL   " & _
                "        SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 0)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 0)) AS BalanceAmount  FROM         dbo.cust_trtab_main A   " & _
                  "          else    " & _
              "       SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 0)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 0)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer  " & _
               "          else  " & _
              "          SELECT     COD_CUSTOMER, (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 0)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) <= 0)) AS BalanceAmount FROM         dbo.cust_trtab_main A WHERE     (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 0)) + (SELECT     isnull(SUM(BalanceAmount), 0) " & _
                  "                              FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) <= 0)) <> 0 "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAging1to30]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAging1to30]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "CREATE  PROCEDURE SP_CustomerAging1to30  @ThisDate  as char(10) , " & _
              " @ThisCustomer  as char(10) = NULL ,@Flag  as Char(1) = NULL AS IF @Flag IS NULL " & _
              "  IF @ThisCustomer IS NULL    " & _
              " SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)       FROM         View_Total_Balance_ForEach_ARDue             WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND  (DATEDIFF(day, dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 30))  +(SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance            WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 30)) AS BalanceAmount  FROM         dbo.cust_trtab_main A    " & _
              "               else     " & _
              " SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)  FROM         View_Total_Balance_ForEach_ARDue   WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND  (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 0)  AND (DATEDIFF(day, dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 30)) + (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 30)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer  " & _
              "               else " & _
              " SELECT     COD_CUSTOMER, (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 30)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) > 0) AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 30)) AS BalanceAmount FROM         dbo.cust_trtab_main A WHERE     (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND  " & _
               " (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,   dbo. View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 30)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 30)) <> 0 "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAging31to60]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAging31to60]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "CREATE  PROCEDURE SP_CustomerAging31to60  @ThisDate  as char(10)  " & _
              " ,@ThisCustomer  as char(10) =NULL   ,@Flag  as Char(1) = NULL AS IF @Flag IS NULL " & _
              "  IF @ThisCustomer IS NULL         " & _
              "  SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 30) AND  " & _
              " (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 60)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 60)) AS BalanceAmount  FROM         dbo.cust_trtab_main A    " & _
              "  else   " & _
              "  SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND  " & _
              " (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 60)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 60)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer  " & _
              "  else " & _
              "  SELECT     COD_CUSTOMER, (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 60)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) > 30) AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 60)) AS BalanceAmount FROM         dbo.cust_trtab_main A WHERE     (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue  " & _
              " WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 60)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) > 30) AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 60)) <> 0 "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAging61to90]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAging61to90]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "CREATE  PROCEDURE SP_CustomerAging61to90  @ThisDate  as char(10) " & _
                " ,@ThisCustomer  as char(10) =NULL  ,@Flag  as Char(1) = NULL AS IF @Flag IS NULL " & _
                "  IF @ThisCustomer IS NULL    " & _
                "      SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND  " & _
                " (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A    " & _
                "      else       " & _
                "      SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND  " & _
                " (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer  " & _
                "      else " & _
                "    SELECT     COD_CUSTOMER, (SELECT     isnull(SUM(TotalArBalanceAmount), 0)  FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 90)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) > 60) AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 90)) AS BalanceAmount FROM         dbo.cust_trtab_main A WHERE     (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue  " & _
                " WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 90)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) > 60) AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 90)) <> 0 "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAgingOver90]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAgingOver90]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "CREATE PROCEDURE SP_CustomerAgingOver90  @ThisDate  as char(10)  " & _
                " ,@ThisCustomer  as char(10) =NULL ,@Flag  as Char(1) = NULL  AS  " & _
                "  IF @Flag IS NULL " & _
                "     IF @ThisCustomer IS NULL      " & _
                "   SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)    FROM         View_Total_Balance_ForEach_ARDue   WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,             dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) >90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)       FROM         View_Adjustment_Balance               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,       dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) >90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A   " & _
                "           else    " & _
                "  SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)  FROM         View_Total_Balance_ForEach_ARDue         WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,      dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) >90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)       FROM         View_Adjustment_Balance      WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,    dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) >90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer  " & _
                "  else " & _
                "  SELECT     COD_CUSTOMER, (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 90)) + (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) > 90)) AS BalanceAmount FROM         dbo.cust_trtab_main A where  (SELECT     isnull(SUM(TotalArBalanceAmount), 0) FROM         View_Total_Balance_ForEach_ARDue WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,  dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 90)) + " & _
                "  (SELECT     isnull(SUM(BalanceAmount), 0) FROM         View_Adjustment_Balance WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day, dbo.View_Adjustment_Balance.AR_due_date,  @ThisDate) > 90))  <>0 "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    '    Private Sub Fixed860520()
    '        Try
    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_account_adjustment_head] ADD CONSTRAINT [FK_GL_account_adjustment_head_Gl_receive_payment] FOREIGN KEY ( [Gl_receive_payment_Refrence_no] ) REFERENCES [dbo].[Gl_receive_payment] ([refrence_no]) ON DELETE CASCADE "
    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit_Detail] ADD CONSTRAINT [FK_GL_payment_deposit_Detail_GL_payment_deposit] FOREIGN KEY ([ID_payment_Paid] ) REFERENCES [dbo].[GL_payment_deposit] ([ID_payment]) ON DELETE CASCADE"
    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit_Detail] ADD 	CONSTRAINT [FK_GL_payment_deposit_Detail_GL_payment_deposit] FOREIGN KEY ([ID_payment_Paid]) REFERENCES [dbo].[GL_payment_deposit] ([ID_payment] ) ON DELETE CASCADE"
    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try


    '        Try
    '            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAgingNotDueYet]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAgingNotDueYet]"
    '            CmdGeneral.ExecuteNonQuery()
    '            CmdGeneral.CommandText = " CREATE PROCEDURE SP_CustomerAgingNotDueYet  " & _
    '" @ThisDate  as char(10) ,@ThisCustomer  as char(10) =NULL  AS  " & _
    '" IF @ThisCustomer IS NULL " & _
    '"      SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 0)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 0)) AS BalanceAmount  FROM         dbo.cust_trtab_main A   " & _
    '" else " & _
    '"      SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 0)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 0)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer "
    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAging1to30]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAging1to30]"
    '            CmdGeneral.ExecuteNonQuery()
    '            CmdGeneral.CommandText = "CREATE PROCEDURE SP_CustomerAging1to30 " & _
    '" @ThisDate  as char(10) ,@ThisCustomer  as char(10) =NULL  AS  " & _
    '" IF @ThisCustomer IS NULL " & _
    '"      SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 30)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 30)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  " & _
    '" else " & _
    '"      SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 30)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 0) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 30)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAging31to60]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAging31to60]"
    '            CmdGeneral.ExecuteNonQuery()
    '            CmdGeneral.CommandText = "CREATE PROCEDURE SP_CustomerAging31to60 " & _
    '" @ThisDate  as char(10) ,@ThisCustomer  as char(10) =NULL  AS   " & _
    '" IF @ThisCustomer IS NULL " & _
    '"      SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 60)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 60)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  " & _
    '" else " & _
    '"      SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 60)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 30) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 60)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAging61to90]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAging61to90]"
    '            CmdGeneral.ExecuteNonQuery()
    '            CmdGeneral.CommandText = "CREATE PROCEDURE SP_CustomerAging61to90 " & _
    '" @ThisDate  as char(10) ,@ThisCustomer  as char(10) =NULL  AS   " & _
    '" IF @ThisCustomer IS NULL " & _
    '"      SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  " & _
    '" else " & _
    '"      SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) <= 90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) > 60) AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) <= 90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '        Try
    '            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerAgingOver90]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerAgingOver90]"
    '            CmdGeneral.ExecuteNonQuery()
    '            CmdGeneral.CommandText = "CREATE PROCEDURE SP_CustomerAgingOver90 " & _
    '" @ThisDate  as char(10) ,@ThisCustomer  as char(10) =NULL  AS   " & _
    '" IF @ThisCustomer IS NULL " & _
    '"      SELECT     COD_CUSTOMER,(SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) >90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) >90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  " & _
    '" else " & _
    '"     SELECT     (SELECT     isnull(SUM(TotalArBalanceAmount), 0)                          FROM         View_Total_Balance_ForEach_ARDue                          WHERE     A.cod_customer = dbo.View_Total_Balance_ForEach_ARDue.cod_customer  AND (DATEDIFF(day,                                                 dbo.View_Total_Balance_ForEach_ARDue.AR_due_date, @ThisDate) >90)) +                            (SELECT     isnull(SUM(BalanceAmount), 0)                               FROM         View_Adjustment_Balance                               WHERE     A.cod_customer = dbo.View_Adjustment_Balance.cod_customer  AND (DATEDIFF(day,                                                      dbo.View_Adjustment_Balance.AR_due_date, @ThisDate) >90)) AS BalanceAmount  FROM         dbo.cust_trtab_main A  WHERE A.cod_customer =@ThisCustomer "

    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try



    '    End Sub
    Private Sub Fixed860518()
        Try
            CmdGeneral.CommandText = " ALTER TABLE Gl_receive_payment ADD Id_debit_deposit_head int DEFAULT  0"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Customer_Balance]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Customer_Balance] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Customer_Balance AS SELECT     cod_customer, " & _
                            " (SELECT   isnull(SUM(round(dbo.GL_payment_deposit.payment_amount, 2) - round(dbo.GL_payment_deposit.paid_amount, 2)), 0) AS Customer_AR_Bedehy1 " & _
                            "  FROM  dbo.service_center_head INNER JOIN dbo.GL_payment_deposit ON dbo.service_center_head.id_service_center = dbo.GL_payment_deposit.id_service_center LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                            "  WHERE     (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.cod_customer = dbo.service_center_head.cod_customer) - " & _
                            " (SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS payment_amount FROM GL_payment_deposit INNER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no " & _
                            " WHERE     (GL_payment_deposit.refrence_no_Adjustment IS NOT NULL) AND A.cod_customer = dbo.Gl_receive_payment.cod_customer)  + " & _
                            " (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Pardakht2 " & _
                            "  FROM         dbo.GL_account_adjustment_head " & _
                            "  WHERE     A.cod_customer = GL_account_adjustment_head.cod_customer) - " & _
                            " (SELECT     BalanceOverPaymentAmount FROM View_Balance_OverPayment_Amount WHERE A.cod_customer = View_Balance_overPayment_Amount.cod_customer)  " & _
                            " AS BalanceAmount " & _
                            " FROM         dbo.cust_trtab_main A GROUP BY cod_customer  "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_account_adjustment_head ADD FromStoreNo char(2)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_account_adjustment_head ADD FromStoreNo char(2)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub FixedAddFields()

        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_Paid_received ADD cc_type Char(2)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_Paid_received ADD cc_card_no VarChar(20)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_Paid_received ADD cc_expire_date_year Char(4)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_Paid_received ADD cc_expire_date_month Char(2)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_Paid_received ADD cc_auth_no VarChar(20)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_Paid_received ADD check_no VarChar(20)"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = " ALTER TABLE GL_payment_deposit ADD refrence_no_Gl_receive_payment char(6)"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = " ALTER TABLE GL_payment_deposit ADD Downpayment_Wo_No char(10)"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Fixed860509()

        Try
            CmdGeneral.CommandText = " ALTER TABLE Gl_receive_payment ADD amount_over money DEFAULT  0 "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            CmdGeneral.CommandText = " update Gl_receive_payment set amount_over=0 where amount_over is null "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Balance_OverPayment_Amount]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Balance_OverPayment_Amount]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Balance_OverPayment_Amount AS " & _
                            " SELECT     cod_customer,(SELECT     isnull(SUM(round(isnull(amount_over, 0), 2)), 0) Total_Amount_over FROM         Gl_receive_payment " & _
                            " WHERE     A.cod_customer = dbo.Gl_receive_payment.cod_customer) - " & _
                            " (SELECT     isnull(SUM(round(isnull(payment_amount, 0), 2)), 0) Total_over_paid FROM         GL_payment_deposit INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                            " WHERE     (refer_type = '1') AND (payment_type = '5') AND A.cod_customer = dbo.service_center_head.cod_customer)  AS BalanceOverPaymentAmount " & _
                            " FROM         dbo.cust_trtab_main A GROUP BY cod_customer "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Balance_DownPayment_Amount]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Balance_DownPayment_Amount]"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Balance_DownPayment_Amount AS " & _
                            " SELECT     cod_customer,(SELECT     isnull(SUM(round(isnull(amount, 0), 2)), 0) Total_Amount_Down FROM         GL_Paid_received " & _
                            " WHERE     tran_type = '4' AND  A.cod_customer = dbo.GL_Paid_received.customer_code) - " & _
                            " (SELECT     isnull(SUM(round(isnull(payment_amount, 0), 2)), 0) Total_Down_paid FROM         GL_payment_deposit INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                            " WHERE     (refer_type = '1') AND (payment_type = '6') AND A.cod_customer = dbo.service_center_head.cod_customer)  AS BalanceDownPaymentAmount " & _
                            " FROM         dbo.cust_trtab_main A GROUP BY cod_customer "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try


        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Balance_For_Each_DownPayment]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Balance_For_Each_DownPayment] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Balance_For_Each_DownPayment AS " & _
                            " SELECT     id_service_center AS Downpayment_Wo_No, customer_code, " & _
                            " (SELECT     isnull(SUM(round(amount, 2)), 0) AS Amount1 FROM  GL_Paid_received WHERE  A.id_service_center = dbo.GL_Paid_received.id_service_center) - " & _
                            " (SELECT     isnull(SUM(round(isnull(payment_amount, 0), 2)), 0) Total_Down_paid FROM  GL_payment_deposit  WHERE     (refer_type = '1') AND (payment_type = '6') AND A.id_service_center = dbo.GL_payment_deposit.DownPayment_Wo_No) " & _
                            " AS BalanceDownPaymentAmount " & _
                            " FROM  dbo.GL_Paid_received A WHERE  (amount > 0) AND (tran_type = '4') " & _
                            " GROUP BY id_service_center, customer_code "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.ToString, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Balance_For_Each_OverPayment]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Balance_For_Each_OverPayment] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Balance_For_Each_OverPayment AS " & _
                            " SELECT     refrence_no, cod_customer," & _
                            " (SELECT     amount_over FROM         Gl_receive_payment WHERE     A.refrence_no = dbo.Gl_receive_payment.refrence_no) - " & _
                            " (SELECT     isnull(SUM(round(isnull(payment_amount, 0), 2)), 0) Total_over_paid FROM         GL_payment_deposit WHERE     (refer_type = '1') AND (payment_type = '5') AND A.refrence_no =  dbo.GL_payment_deposit.refrence_no_Gl_receive_payment) " & _
                            "  AS BalanceOverPaymentAmount FROM         dbo.Gl_receive_payment A WHERE     (amount_over > 0) " & _
                            " GROUP BY refrence_no, cod_customer "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

    End Sub
    Private Sub Fixed860505()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        Try
            CmdGeneral.CommandText = " CREATE TABLE [dbo].[GL_account_adjustment_dtl_dtl] ([IDGL_account_adjustment_dtl] [int] IDENTITY (1, 1) NOT NULL ,[refrence_no_due] [char] (6) NOT NULL , " & _
                            " [id_service_center_due] [char] (10) NOT NULL ,[ID_payment] [int] NULL ,[IDGL_account_adjustment_dtl_Due] [int] NULL ,[amount_adjustment] [money] NOT NULL ) ON [PRIMARY] "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            CmdGeneral.CommandText = " ALTER TABLE [dbo].[GL_account_adjustment_dtl_dtl] ADD CONSTRAINT [PK_GL_account_adjustment_dtl_dtl] PRIMARY KEY  CLUSTERED ([IDGL_account_adjustment_dtl]) ON [PRIMARY] "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " ALTER TABLE [dbo].[GL_account_adjustment_dtl_dtl] ADD CONSTRAINT [FK_GL_account_adjustment_dtl_dtl_GL_account_adjustment_dtl] FOREIGN KEY ([refrence_no_due],[id_service_center_due]) REFERENCES [dbo].[GL_account_adjustment_dtl] ([refrence_no],[id_service_center]) ON DELETE CASCADE "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Invoice_Balance_ForEach_ARDue]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Invoice_Balance_ForEach_ARDue] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Invoice_Balance_ForEach_ARDue AS " & _
" SELECT     dbo.GL_payment_deposit.ID_payment, ISNULL(SUM(ROUND(dbo.GL_payment_deposit.payment_amount, 2)), 0) AS AR_Amount,  " & _
"                       ISNULL(SUM(ROUND(dbo.GL_payment_deposit.payment_amount, 2) - ROUND(dbo.GL_payment_deposit.Paid_amount, 2)), 0) AS BalanceAmount,  " & _
"                       dbo.GL_payment_deposit.id_service_center, dbo.GL_payment_AR.AR_due_date, dbo.service_center_head.cod_customer " & _
" FROM         dbo.GL_payment_deposit LEFT OUTER JOIN " & _
"                       dbo.service_center_head ON dbo.GL_payment_deposit.id_service_center = dbo.service_center_head.id_service_center LEFT OUTER JOIN " & _
"                       dbo.GL_payment_AR ON dbo.GL_payment_deposit.ID_payment = dbo.GL_payment_AR.ID_payment " & _
" WHERE     (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) " & _
" GROUP BY dbo.GL_payment_deposit.ID_payment, dbo.GL_payment_deposit.id_service_center, dbo.GL_payment_AR.AR_due_date,  " & _
"                       dbo.service_center_head.cod_customer "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Adj_Balance_ForEach_ARDue]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Adj_Balance_ForEach_ARDue] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Adj_Balance_ForEach_ARDue AS " & _
                            " SELECT     id_service_center_due AS id_service_center_due1, ID_payment AS ID_payment1, SUM(round(amount_adjustment,2)) AS AR_Adj_Amount " & _
                            " FROM         dbo.GL_account_adjustment_dtl_dtl " & _
                            " WHERE     (ID_payment IS NOT NULL) AND (ROUND(amount_adjustment, 2) < 0) " & _
                            " GROUP BY id_service_center_due, ID_payment "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Adj_Paid_ForEach_Adj]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Adj_Paid_ForEach_Adj] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Adj_Paid_ForEach_Adj AS " & _
                            " SELECT     SUM(round(amount_adjustment,2)) AS Adj_Paid_Amount, IDGL_account_adjustment_dtl_Due " & _
                            " FROM         dbo.GL_account_adjustment_dtl_dtl " & _
                            " WHERE     (IDGL_account_adjustment_dtl_Due IS NOT NULL) " & _
                            " GROUP BY IDGL_account_adjustment_dtl_Due "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AR_Paid_ForEach_Adj]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_AR_Paid_ForEach_Adj] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_AR_Paid_ForEach_Adj AS " & _
                            " SELECT     id_service_center, refrence_no_Adjustment, SUM(round(payment_amount,2)) AS AR_Paid_amount " & _
                            " FROM         dbo.GL_payment_deposit " & _
                            " WHERE     (refrence_no_Adjustment IS NOT NULL) AND (LTRIM(RTRIM(refrence_no_Adjustment)) > '') " & _
                            " GROUP BY id_service_center, refrence_no_Adjustment "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Adjustment_Balance]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Adjustment_Balance] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Adjustment_Balance AS " & _
" SELECT     dbo.GL_account_adjustment_dtl_dtl.IDGL_account_adjustment_dtl, dbo.GL_account_adjustment_dtl_dtl.refrence_no_due,  " & _
"                      dbo.GL_account_adjustment_dtl_dtl.id_service_center_due, ROUND(dbo.GL_account_adjustment_dtl_dtl.amount_adjustment, 2) " & _
"                      AS amount_adjustment, ISNULL(dbo.View_AR_Paid_ForEach_Adj.AR_Paid_amount, 0) AS AR_Paid_amount, " & _
"                        ISNULL(dbo.View_Adj_Paid_ForEach_Adj.Adj_Paid_Amount, 0) AS Adj_Paid_Amount, ROUND(dbo.GL_account_adjustment_dtl_dtl.amount_adjustment, " & _
"                        2) - ISNULL(dbo.View_AR_Paid_ForEach_Adj.AR_Paid_amount, 0) + ISNULL(dbo.View_Adj_Paid_ForEach_Adj.Adj_Paid_Amount, 0) AS BalanceAmount, " & _
"                        dbo.GL_account_adjustment_head.cod_customer, dbo.GL_account_adjustment_head.date_adjustment AS AR_due_date" & _
"  FROM         dbo.GL_account_adjustment_dtl_dtl INNER JOIN" & _
"                        dbo.GL_account_adjustment_head ON " & _
"                        dbo.GL_account_adjustment_dtl_dtl.refrence_no_due = dbo.GL_account_adjustment_head.refrence_no LEFT OUTER JOIN " & _
"                        dbo.View_Adj_Paid_ForEach_Adj ON " & _
"                        dbo.GL_account_adjustment_dtl_dtl.IDGL_account_adjustment_dtl = dbo.View_Adj_Paid_ForEach_Adj.IDGL_account_adjustment_dtl_Due LEFT OUTER JOIN " & _
"                        dbo.View_AR_Paid_ForEach_Adj ON  " & _
"                        dbo.GL_account_adjustment_dtl_dtl.id_service_center_due = dbo.View_AR_Paid_ForEach_Adj.id_service_center AND  " & _
"                        dbo.GL_account_adjustment_dtl_dtl.refrence_no_due = dbo.View_AR_Paid_ForEach_Adj.refrence_no_Adjustment " & _
"  WHERE     (dbo.GL_account_adjustment_dtl_dtl.amount_adjustment > 0) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Total_Balance_ForEach_ARDue]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Total_Balance_ForEach_ARDue] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Total_Balance_ForEach_ARDue AS " & _
" SELECT     dbo.View_Invoice_Balance_ForEach_ARDue.id_service_center, dbo.View_Invoice_Balance_ForEach_ARDue.ID_payment,  " & _
"                       ISNULL(dbo.View_Invoice_Balance_ForEach_ARDue.BalanceAmount, 0) AS BalanceAmount,  " & _
"                       ISNULL(dbo.View_Adj_Balance_ForEach_ARDue.AR_Adj_Amount, 0) AS AR_Adj_Amount,  " & _
"                       ISNULL(dbo.View_Invoice_Balance_ForEach_ARDue.BalanceAmount, 0) + ISNULL(dbo.View_Adj_Balance_ForEach_ARDue.AR_Adj_Amount, 0)  " & _
"                       AS TotalArBalanceAmount, dbo.View_Invoice_Balance_ForEach_ARDue.AR_due_date,  " & _
"                       dbo.View_Invoice_Balance_ForEach_ARDue.cod_customer ,ISNULL(dbo.View_Invoice_Balance_ForEach_ARDue.AR_Amount,2) AS AR_Amount" & _
" FROM         dbo.View_Invoice_Balance_ForEach_ARDue LEFT OUTER JOIN " & _
"                       dbo.View_Adj_Balance_ForEach_ARDue ON  " & _
"                       dbo.View_Invoice_Balance_ForEach_ARDue.ID_payment = dbo.View_Adj_Balance_ForEach_ARDue.ID_payment1 AND  " & _
"                       dbo.View_Invoice_Balance_ForEach_ARDue.id_service_center = dbo.View_Adj_Balance_ForEach_ARDue.id_service_center_due1 "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
    End Sub
    Private Sub Fixed860428()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = " ALTER TABLE Gl_receive_payment ADD FromStoreNo char(2)"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " update Gl_receive_payment set FromStoreNo=" & Qt(PubStoreNO) & " where FromStoreNo is null "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " ALTER TABLE Gl_receive_payment ADD OtherStorerefrence_no char(6)"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " update Gl_receive_payment set OtherStoreRefrence_no='' where OtherStorerefrence_no is null "
            CmdGeneral.ExecuteNonQuery()


            CmdGeneral.CommandText = " ALTER TABLE Gl_receive_payment ADD OtherStoreAmount money DEFAULT  0 "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " update Gl_receive_payment set OtherStoreAmount=0 where OtherStoreAmount is null "
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = " ALTER TABLE GL_account_adjustment_head ADD Old_Amount_adjustment money DEFAULT  0 "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " update GL_account_adjustment_head set Old_Amount_adjustment=0 where Old_Amount_adjustment is null "
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = " ALTER TABLE GL_account_adjustment_dtl ADD Old_Amount_adjustment money DEFAULT  0 "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " update GL_account_adjustment_dtl set Old_Amount_adjustment=0 where Old_Amount_adjustment is null "
            CmdGeneral.ExecuteNonQuery()

            Try
                CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Adjustment_Balance]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Adjustment_Balance] "
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = " CREATE VIEW dbo.View_Adjustment_Balance AS " & _
                                " SELECT     ISNULL(SUM(ROUND(payment_amount, 2)), 0) AS payment_amount, id_service_center, refrence_no_Adjustment " & _
                                " FROM         dbo.GL_payment_deposit WHERE     (refer_type = '2') OR (refer_type = '4') GROUP BY id_service_center, refrence_no_Adjustment "
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(EX.TOSTRING, MsgBoxStyle.Exclamation)
                Exit Sub
            End Try

        Catch ex As Exception
        End Try
    End Sub
    Private Sub BehFixedDataBase()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        CmdGeneral.CommandText = " ALTER TABLE GL_payment_deposit ADD refrence_no_Adjustment char(8)"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "alter table Gl_receive_payment add AuthorizationCode char(12) "
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "alter table GL_payment_deposit add Paid_amount money DEFAULT 0"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "alter table GL_payment_deposit add Discount money DEFAULT 0"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_payment_deposit_Detail] ([ID_payment_due] [int] NOT NULL ,[ID_payment_Paid] [int] NOT NULL ,	[refrence_no] [char] (6)  NULL ) ON [PRIMARY]"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit_Detail] WITH NOCHECK ADD 	CONSTRAINT [PK_GL_payment_deposit_Detail] PRIMARY KEY  CLUSTERED (	[ID_payment_due],[ID_payment_Paid]	)  ON [PRIMARY] "
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "update  Gl_receive_payment set AuthorizationCode = '' Where  AuthorizationCode is null"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "UPDATE    GL_payment_deposit SET Paid_amount =0 where Paid_amount is null"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "UPDATE    GL_payment_deposit SET Discount = 0 WHERE  Discount IS NULL"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GL_payment_deposit_Due_Date_For_AR]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[GL_payment_deposit_Due_Date_For_AR] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "  CREATE VIEW dbo.GL_payment_deposit_Due_Date_For_AR AS " & _
            " SELECT     dbo.GL_payment_AR.AR_due_date, dbo.GL_payment_deposit.id_service_center, dbo.GL_payment_deposit.ID_payment, dbo.GL_payment_AR.Cancel_flag " & _
            " FROM         dbo.GL_payment_deposit INNER JOIN dbo.GL_payment_AR ON dbo.GL_payment_deposit.ID_payment = dbo.GL_payment_AR.ID_payment " & _
            " WHERE     (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Sum_Of_Invoice_ReplacementCost]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Sum_Of_Invoice_ReplacementCost] "
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Sum_Of_Invoice_ReplacementCost AS " & _
            " SELECT     dbo.service_center_dtl.id_service_center, round(sum(dbo.service_center_dtl.qty * (dbo.inv_item_cost_transaction.cost + dbo.inv_item_cost_transaction.fet)),2) AS ReplacementCost " & _
            " FROM         dbo.inv_item_cost_transaction INNER JOIN dbo.inv_item ON dbo.inv_item_cost_transaction.item_no = dbo.inv_item.item_no INNER JOIN dbo.service_center_dtl ON dbo.inv_item.item_no = dbo.service_center_dtl.cod_select " & _
            " WHERE     (dbo.inv_item_cost_transaction.last_flag = 1) AND (dbo.service_center_dtl.type_select = 'I') GROUP BY dbo.service_center_dtl.id_service_center "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Return_AR_Remaining]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Return_AR_Remaining] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Return_AR_Remaining AS " & _
            " SELECT     id_service_center, " & _
            " ROUND((SELECT     ROUND(ISNULL(SUM(GL_payment_deposit.payment_amount), 0), 2) AS Customer_AR_Bedehy1 FROM          service_center_head LEFT OUTER JOIN " & _
            " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
            " WHERE      (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND (GL_payment_AR.Cancel_flag = 0) AND A.id_service_center_before = GL_payment_deposit.id_service_center) - " & _
            " (SELECT     ROUND(ISNULL(SUM(Gl_receive_payment.amount_receive), 0), 2) AS Customer_AR_Pardakht1 FROM Gl_receive_payment INNER JOIN " & _
            " GL_payment_deposit ON Gl_receive_payment.refrence_no = GL_payment_deposit.refrence_no " & _
            " WHERE     (GL_payment_deposit.refer_type = '2') AND A.id_service_center_before = GL_payment_deposit.id_service_center), 2) AS Expr1, " & _
            " id_service_center_before FROM         service_center_head A WHERE     (type_of_form = 'RT') " & _
            " GROUP BY id_service_center, id_service_center_before "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " alter table inv_tab_item_warehouse add Begining_Balance_Qty Real "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = " update inv_tab_item_warehouse set Begining_Balance_Qty =0 where  Begining_Balance_Qty is null "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[v_BeginingQty]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[v_BeginingQty] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "CREATE VIEW dbo.v_BeginingQty AS " & _
                                     " SELECT     inv_adjustment_dtl.item_no, inv_adjustment_head.date_adjustment AS date1, CASE WHEN isnull(inv_adjustment_dtl.QTY, 0)> 0 THEN isnull(inv_adjustment_dtl.QTY, 0) else 0 END AS qtyin, CASE WHEN isnull(inv_adjustment_dtl.QTY, 0) < 0 THEN - (isnull(inv_adjustment_dtl.QTY,0)) else 0 END AS qtyout " & _
                                     " FROM         inv_adjustment_dtl INNER JOIN inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment " & _
                                     " UNION " & _
                                     " SELECT     service_center_dtl.cod_select AS item_no, service_center_head.date_refer AS date1, CASE WHEN service_center_head.type_of_form = 'RT' THEN -(isnull(service_center_dtl.qty, 0)) else 0 END AS qtyin, CASE WHEN service_center_head.type_of_form = 'IN' THEN isnull(service_center_dtl.qty, 0) else 0 END AS qtyout " & _
                                     " FROM         service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center " & _
                                     " WHERE    ( service_center_head.type_of_form = 'RT' OR service_center_head.type_of_form = 'IN') AND ( service_center_dtl.type_select = 'I' or  service_center_dtl.type_select = 'A') " & _
                                     " UNION " & _
                                     " SELECT     Inv_Receive_product_dtl.item_no, Inv_Receive_Products_head.date_receive AS date1,  CASE WHEN Inv_Receive_Products_head.bill_credit = '1' THEN isnull(Inv_Receive_product_dtl.qty, 0) else 0 END AS qtyin,  CASE WHEN Inv_Receive_Products_head.bill_credit = '1' THEN isnull(Inv_Receive_product_dtl.qty, 0) else 0 END AS qtyout " & _
                                     " FROM         Inv_Receive_product_dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref " & _
                                     " UNION " & _
                                     " SELECT     inv_sales_transfer_dtl.item_no, inv_salse_transfer_head.date_action AS date1, 0 AS qtyin, inv_sales_transfer_dtl.qty AS qtyout FROM         inv_salse_transfer_head INNER JOIN inv_sales_transfer_dtl ON inv_salse_transfer_head.ID_sales_transfer = inv_sales_transfer_dtl.ID_sales_transfer " & _
                                     " UNION " & _
                                     " SELECT     inv_tab_item_warehouse.item_no, '0' AS date1, Begining_Balance_Qty AS qtyin, 0 AS qtyout FROM         inv_tab_item_warehouse "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            CmdGeneral.CommandText = " if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_Invoice_Balance]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [dbo].[View_Invoice_Balance] "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " CREATE VIEW dbo.View_Invoice_Balance AS SELECT     id_service_center,date_refer, " & _
                            " (SELECT   isnull(SUM(round(dbo.GL_payment_deposit.payment_amount, 2) - round(dbo.GL_payment_deposit.paid_amount, 2)), 0) AS Customer_AR_Bedehy1 " & _
                            "  FROM  dbo.service_center_head INNER JOIN dbo.GL_payment_deposit ON dbo.service_center_head.id_service_center = dbo.GL_payment_deposit.id_service_center LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                            "  WHERE     (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.id_service_center = dbo.service_center_head.id_service_center) - " & _
                            " (SELECT     ISNULL(SUM(ROUND(payment_amount, 2)), 0) AS payment_amount FROM         GL_payment_deposit " & _
                            "  WHERE     (refrence_no_Adjustment IS NOT NULL) AND A.id_service_center = GL_payment_deposit.id_service_center) + " & _
                            " (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Pardakht2  " & _
                            "  FROM         dbo.GL_account_adjustment_dtl " & _
                            "  WHERE     A.id_service_center = GL_account_adjustment_dtl.id_service_center) AS BalanceAmount " & _
                            "  FROM         dbo.service_center_head A WHERE     (type_of_form = 'IN') GROUP BY id_service_center,date_refer "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            CmdGeneral.CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SP_CustomerBalance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SP_CustomerBalance]"
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "CREATE PROCEDURE SP_CustomerBalance " & _
                 " @ThisDate  as char(10),@ThisCustomer as char(10) AS SELECT  " & _
                 " (SELECT   isnull(SUM(round(dbo.GL_payment_deposit.payment_amount, 2) - round(dbo.GL_payment_deposit.paid_amount, 2)), 0) AS Customer_AR_Bedehy1 " & _
                 "  FROM  dbo.service_center_head INNER JOIN dbo.GL_payment_deposit ON dbo.service_center_head.id_service_center = dbo.GL_payment_deposit.id_service_center LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                 " WHERE    (dbo.ChangeDate(dbo.service_center_head.date_refer)<=dbo.ChangeDate(@ThisDate)) AND (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.GL_payment_AR.Cancel_flag <> 1) AND (dbo.service_center_head.type_of_form = 'IN') AND A.cod_customer = dbo.service_center_head.cod_customer) + " & _
                 " (SELECT     isnull(SUM(round(isnull(amount_adjustment, 0), 2)), 0) AS Customer_AR_Bedehy2  " & _
                 "  FROM         dbo.GL_account_adjustment_head " & _
                 " WHERE     (dbo.ChangeDate(dbo.GL_account_adjustment_head.date_adjustment)<=dbo.ChangeDate(@ThisDate)) AND A.cod_customer = GL_account_adjustment_head.cod_customer) " & _
                 "  AS BalanceAmount " & _
                 " FROM         dbo.cust_trtab_main A Where cod_customer=@ThisCustomer"

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            'fix adjustment
            Dim ds As New DataSet
            Dim i As Int64 = 0
            Dim OleDbReader As System.Data.OleDb.OleDbDataReader = RetrieveAccountsReceivableSetupTable()
            Dim MinimumFinanaceCharge As Decimal = Val("0" & OleDbReader.Item("Default_minimum_finance_charge"))
            If MinimumFinanaceCharge > 0 Then

                CmdGeneral.CommandText = " Update GL_account_adjustment_dtl set amount_adjustment = " & MinimumFinanaceCharge
                CmdGeneral.CommandText = CmdGeneral.CommandText + "  WHERE  amount_adjustment < " & MinimumFinanaceCharge & "  AND refrence_no IN"
                CmdGeneral.CommandText = CmdGeneral.CommandText + " (SELECT     refrence_no    FROM  GL_account_adjustment_head  WHERE     finance_charge_flag = 1)"
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            GL_account_adjustment_dtl.Fill(ds, "t1")
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            If ds.Tables("t1").Rows.Count > 0 Then
                For i = 0 To ds.Tables("t1").Rows.Count - 1
                    CmdGeneral.CommandText = " Update GL_account_adjustment_head  set amount_adjustment =  " & Math.Round(ds.Tables("t1").Rows(i).Item("sum1"), 2) & "  Where refrence_no = " & Qt(ds.Tables("t1").Rows(i).Item("refrence_no"))
                    CmdGeneral.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception

        End Try

        '-----fix zip code
        Call AlterTable("cust_company", "FK_cust_company_bas_zipcode", "zip_code", False)
        Call AlterTable("cust_trtab_main", "FK_cust_trtab_main_bas_zipcode", "zip", False)
        Call AlterTable("employee", "FK_employee_bas_zipcode", "zipcode", False)
        Call AlterTable("inv_vendor", "FK_inv_vendor_bas_zipcode", "zipcode", False)
        CmdGeneral.CommandText = "UPDATE    bas_zipcode   SET    zipcode = '0' + zipcode    WHERE     (LEN(zipcode) = 4)"

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "UPDATE    bas_zipcode   SET    zipcode = '00' + zipcode    WHERE     (LEN(zipcode) = 3)"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub AryafarFixedDataBase()
        Dim Cmd As New SqlClient.SqlCommand
        Cmd.Connection = Cnn
        Cmd.CommandText = "if exists(select  dbo.ChangeDateToNormal('1111111111')) " & _
             " drop function  ChangeDateToNormal "
        '" go "
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()
        Cmd.CommandText = " CREATE FUNCTION ChangeDateToNormal (@ThisDate as Char(10))   " & _
             " RETURNS Char(10)  AS  " & _
             " BEGIN " & _
             " DECLARE @ChangedDate1 char(10) " & _
             " set @ChangedDate1=SUBSTRING(@ThisDate, 6, 2)+'/' + SUBSTRING(@ThisDate, 9, 2) + '/' + SUBSTRING(@ThisDate, 1, 4) " & _
             " RETURN @ChangedDate1 " & _
             " End "
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()
        '''''''''''''''''''''''''''''

        Cmd.CommandText = "if exists (select * from v_lastadj)" & _
            " drop view  v_lastadj "
        ' " GO " & _
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()

        Cmd.CommandText = " CREATE VIEW dbo.V_Lastadj " & _
            " AS " & _
            " SELECT     dbo.ChangeDateToNormal(MAX(dbo.ChangeDate(dbo.inv_adjustment_head.date_adjustment))) AS date_adj, dbo.inv_adjustment_dtl.item_no " & _
            " FROM         dbo.inv_adjustment_dtl INNER JOIN " & _
            " dbo.inv_adjustment_head ON dbo.inv_adjustment_dtl.referID_adjustment = dbo.inv_adjustment_head.referID_adjustment " & _
            " GROUP BY dbo.inv_adjustment_dtl.item_no "
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()
        ''''''''''''''''''''''''''''
        Cmd.CommandText = " if exists (select * from v_lastrcv) " & _
             " drop view  v_lastrcv "
        '" GO " & _
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()

        Cmd.CommandText = " CREATE VIEW dbo.v_lastrcv " & _
             " AS " & _
             " SELECT    dbo.ChangeDateToNormal( MAX(dbo.ChangeDate(dbo.Inv_Receive_Products_head.date_receive))) AS date_Rcv, dbo.Inv_Receive_product_dtl.item_no " & _
             " FROM         dbo.Inv_Receive_product_dtl INNER JOIN " & _
             " dbo.Inv_Receive_Products_head ON dbo.Inv_Receive_product_dtl.id_receive_ref = dbo.Inv_Receive_Products_head.id_receive_ref " & _
             " GROUP BY dbo.Inv_Receive_product_dtl.item_no "
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()
        ''''''''''''''''''''''''''''
        Cmd.CommandText = "if exists (select * from v_lastsold) " & _
            " drop view  v_lastsold "
        '" GO " & _
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()

        Cmd.CommandText = " CREATE VIEW dbo.v_lastsold " & _
            " AS " & _
            " SELECT     dbo.ChangeDateToNormal(MAX(dbo.ChangeDate(dbo.service_center_head.date_refer))) AS datesold, dbo.service_center_dtl.cod_select " & _
            " FROM         dbo.service_center_head INNER JOIN " & _
            " dbo.service_center_dtl ON dbo.service_center_head.id_service_center = dbo.service_center_dtl.id_service_center " & _
            " WHERE     (dbo.service_center_dtl.type_select = 'I') AND (dbo.service_center_head.type_of_form = 'IN') " & _
            " GROUP BY dbo.service_center_dtl.cod_select "
        If Cmd.Connection.State = ConnectionState.Closed Then
            Cmd.Connection.Open()
        End If
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        Cmd.Connection.Close()

    End Sub

    Sub AlterTable(ByVal ThisTableName As String, ByVal ThisConstrantName As String, ByVal fieldname As String, ByVal OnDeleteCasCade As Boolean)
        Dim Str1 As String = " ALTER TABLE [dbo].[" & ThisTableName.Trim & "] Drop CONSTRAINT [" & ThisConstrantName.Trim & "]"
        Dim Str2 As String = "ALTER TABLE [dbo].[" & ThisTableName.Trim & "] ADD CONSTRAINT [" & ThisConstrantName.Trim & "] FOREIGN KEY ([" & fieldname & "]) REFERENCES [dbo].[bas_zipcode] ([zipcode]) " & IIf(OnDeleteCasCade, " ON DELETE CASCADE ", " ") & " ON UPDATE CASCADE "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Try
                CmdGeneral.CommandText = Str1
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
            '-------------------------
            CmdGeneral.CommandText = Str2
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Me.Enabled = False

        DsFrmUpdateDatabase1.Clear()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = " UPDATE  GL_payment_deposit SET Paid_amount =0"
        CmdGeneral.ExecuteNonQuery()
        CmdGeneral.CommandText = " DELETE FROM GL_payment_deposit_Detail"
        CmdGeneral.ExecuteNonQuery()
        CmdGeneral.CommandText = " DELETE FROM GL_payment_deposit where refrence_no_Adjustment is not null and rtrim(ltrim(refrence_no_Adjustment))<>''"
        CmdGeneral.ExecuteNonQuery()
        TextBox1.Clear()

        DAGL_payment_depositPardakht.Fill(DsFrmUpdateDatabase1, "GL_payment_deposit_Pardakht")
        Dim i As Integer
        Dim j As Integer
        Dim IdPayment As Integer
        Dim InvoiceNo As String
        Dim Reference_no As String
        Dim Customer As String
        Dim IdPaid As Integer
        Dim Amount As Decimal
        Dim AmountForUpdate As Decimal
        Dim Cash_Check_Credit As String = ""
        Dim Refrence_no_Adjustment As String
        Dim BankDepositId As Integer


        UiProgressBar1.Minimum = 0
        UiProgressBar1.Maximum = DsFrmUpdateDatabase1.GL_payment_deposit_Pardakht.Rows.Count - 1
        For i = 0 To DsFrmUpdateDatabase1.GL_payment_deposit_Pardakht.Rows.Count - 1
            UiProgressBar1.Value = i
            System.Windows.Forms.Application.DoEvents()
            InvoiceNo = DsFrmUpdateDatabase1.GL_payment_deposit_Pardakht.Rows(i).Item("id_service_center")
            Reference_no = DsFrmUpdateDatabase1.GL_payment_deposit_Pardakht.Rows(i).Item("refrence_no")
            IdPaid = DsFrmUpdateDatabase1.GL_payment_deposit_Pardakht.Rows(i).Item("ID_payment")
            Amount = DsFrmUpdateDatabase1.GL_payment_deposit_Pardakht.Rows(i).Item("payment_amount")
            Cash_Check_Credit = Trim(DsFrmUpdateDatabase1.GL_payment_deposit_Pardakht.Rows(i).Item("payment_type"))

            DsFrmUpdateDatabase1.GL_debit_deposit.Clear()
            DAGL_debit_deposit.SelectCommand.Parameters("@ID_payment").Value = IdPaid
            DAGL_debit_deposit.Fill(DsFrmUpdateDatabase1, "GL_debit_deposit")
            If DsFrmUpdateDatabase1.GL_debit_deposit.Rows.Count > 1 Then
                TextBox1.Text = "Bank Deposit Problem , ID_payment : " & IdPaid & vbCrLf
            End If

            DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Clear()
            DAGL_payment_depositBedehi.SelectCommand.Parameters("@id_service_center").Value = InvoiceNo
            DAGL_payment_depositBedehi.Fill(DsFrmUpdateDatabase1, "GL_payment_deposit_Bedehi")

            DsFrmUpdateDatabase1.GL_payment_deposit_adj.Clear()
            DAView_Adjustment_Balance.SelectCommand.Parameters("@id_service_center_due").Value = InvoiceNo
            DAView_Adjustment_Balance.Fill(DsFrmUpdateDatabase1, "GL_payment_deposit_adj")

            If DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows.Count > 0 Then

                Dim tran1 As SqlClient.SqlTransaction
                tran1 = Cnn.BeginTransaction()
                CmdGeneral.Transaction = tran1

                For j = 0 To DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows.Count - 1
                    If DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("payment_amount") - DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("Paid_amount") > 0 Then
                        IdPayment = DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("ID_payment")
                        If Amount > DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("payment_amount") - DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("Paid_amount") Then
                            AmountForUpdate = DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("payment_amount") - DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("Paid_amount")
                        Else
                            AmountForUpdate = Amount
                        End If
                        Amount = Amount - AmountForUpdate
                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit_Detail (ID_payment_due,ID_payment_Paid,refrence_no) values (" & IdPayment & "," & IdPaid & "," & Qt(Reference_no) & ")"
                        CmdGeneral.ExecuteNonQuery()
                        CmdGeneral.CommandText = "Update GL_payment_deposit set Paid_amount=Paid_amount+" & AmountForUpdate & " where ID_payment=" & IdPayment
                        CmdGeneral.ExecuteNonQuery()
                    End If
                    If Amount = 0 Then
                        Exit For
                    End If
                Next

                If Amount > 0 Then
                    If DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows.Count > 0 Then
                        For j = 0 To DsFrmUpdateDatabase1.GL_payment_deposit_adj.Rows.Count - 1
                            If DsFrmUpdateDatabase1.GL_payment_deposit_adj.Rows(j).Item("BalanceAmount") > 0 Then
                                Refrence_no_Adjustment = Trim(DsFrmUpdateDatabase1.GL_payment_deposit_adj.Rows(j).Item("refrence_no_due"))
                                If Amount > DsFrmUpdateDatabase1.GL_payment_deposit_adj.Rows(j).Item("BalanceAmount") Then
                                    AmountForUpdate = DsFrmUpdateDatabase1.GL_payment_deposit_adj.Rows(j).Item("BalanceAmount")
                                Else
                                    AmountForUpdate = Amount
                                End If
                                Amount = Amount - AmountForUpdate
                                CmdGeneral.CommandText = "Update GL_payment_deposit set payment_amount=payment_amount - " & AmountForUpdate & " WHERE ID_payment= " & IdPaid
                                CmdGeneral.ExecuteNonQuery()
                                Dim flag_deposit_bank As Integer = 0
                                If DsFrmUpdateDatabase1.GL_debit_deposit.Rows.Count > 0 Then
                                    flag_deposit_bank = 1
                                End If
                                CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount,discount,refrence_no_Adjustment,flag_deposit_bank) values (" & Qt(InvoiceNo) & "," & Qt(Reference_no) & ",'2'," & Qt(Cash_Check_Credit) & "," & AmountForUpdate & ",0, " & Qt(Refrence_no_Adjustment) & " ," & flag_deposit_bank & " );Select @@Identity from GL_payment_deposit"
                                IdPayment = CmdGeneral.ExecuteScalar()
                                If DsFrmUpdateDatabase1.GL_debit_deposit.Rows.Count > 0 Then
                                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                                           & "(id_debit_deposit_head,type_transaction, ID_payment, deposit_amount, GL_account,  memo) VALUES " _
                                                           & "(" & DsFrmUpdateDatabase1.GL_debit_deposit.Rows(0).Item("id_debit_deposit_head") & "," & DsFrmUpdateDatabase1.GL_debit_deposit.Rows(0).Item("type_transaction") & "," & IdPayment & "," & AmountForUpdate & "," & Qt(DsFrmUpdateDatabase1.GL_debit_deposit.Rows(0).Item("GL_account")) & "," & Qt(DsFrmUpdateDatabase1.GL_debit_deposit.Rows(0).Item("memo")) & ")"
                                    CmdGeneral.ExecuteNonQuery()
                                End If

                            End If
                            If Amount = 0 Then
                                Exit For
                            End If
                        Next
                    End If
                End If

                If Amount = 0 Then
                    tran1.Commit()
                Else
                    tran1.Rollback()
                    CmdGeneral.CommandText = "SELECT cod_customer FROM service_center_head WHERE  id_service_center = " & Qt(InvoiceNo)
                    Customer = CmdGeneral.ExecuteScalar
                    TextBox1.Text = TextBox1.Text & " Customer Code : " & Customer & "  Invoice No : " & InvoiceNo & " Ref. No : " & Reference_no & " Amount: " & " " & Math.Round(Amount, 2) & vbCrLf
                End If


                'If Amount > 0 Then
                '    CmdGeneral.CommandText = "SELECT cod_customer FROM service_center_head WHERE  id_service_center = " & Qt(InvoiceNo)
                '    Customer = CmdGeneral.ExecuteScalar
                '    DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Clear()
                '    DAGL_payment_depositBedehiCustomer.SelectCommand.Parameters("@cod_customer").Value = Customer
                '    DAGL_payment_depositBedehiCustomer.Fill(DsFrmUpdateDatabase1, "GL_payment_deposit_Bedehi")
                '    If DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows.Count > 0 Then
                '        For j = 0 To DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows.Count - 1
                '            If DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("payment_amount") - DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("Paid_amount") > 0 Then
                '                IdPayment = DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("ID_payment")
                '                If Amount > DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("payment_amount") - DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("Paid_amount") Then
                '                    AmountForUpdate = DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("payment_amount") - DsFrmUpdateDatabase1.GL_payment_deposit_Bedehi.Rows(j).Item("Paid_amount")
                '                Else
                '                    AmountForUpdate = Amount
                '                End If
                '                Amount = Amount - AmountForUpdate
                '                CmdGeneral.CommandText = "Insert Into GL_payment_deposit_Detail (ID_payment_due,ID_payment_Paid,refrence_no) values (" & IdPayment & "," & IdPaid & "," & Qt(Reference_no) & ")"
                '                CmdGeneral.ExecuteNonQuery()
                '                CmdGeneral.CommandText = "Update GL_payment_deposit set Paid_amount=Paid_amount+" & AmountForUpdate & " where ID_payment=" & IdPayment
                '                CmdGeneral.ExecuteNonQuery()
                '            End If
                '            If Amount = 0 Then
                '                Exit For
                '            End If
                '        Next
                '    End If
                'End If


            End If
        Next
        Me.Enabled = True
    End Sub
    Sub okadjustmentdtldtl()
        Dim i As Int64 = 0
        Dim j As Int64 = 0
        Dim ds1 As New DataSet
        DaGeneral.SelectCommand.CommandText = " SELECT     *   FROM         (SELECT     GL_account_adjustment_dtl.refrence_no, SUM(ROUND(GL_account_adjustment_dtl.amount_adjustment, 2)) AS Adj_dtl,  a.Adj_Dtl_Dtl  FROM GL_account_adjustment_dtl INNER JOIN  (SELECT     refrence_no_due, SUM(round(amount_adjustment, 2)) AS Adj_Dtl_Dtl   FROM         gl_account_adjustment_dtl_dtl    GROUP BY refrence_no_due) a ON GL_account_adjustment_dtl.refrence_no = a.refrence_no_due COLLATE Arabic_CI_AS    GROUP BY GL_account_adjustment_dtl.refrence_no, a.refrence_no_due, a.Adj_Dtl_Dtl) DERIVEDTBL WHERE     (Adj_dtl <> Adj_Dtl_Dtl) and Adj_dtl > 0 "
        DaGeneral.Fill(ds1, "a")
        If ds1.Tables("a").Rows.Count > 0 Then
            For i = 0 To ds1.Tables("a").Rows.Count - 1
                With ds1.Tables("a").Rows(i)
                    Dim RefNo As String = .Item("refrence_no")
                    DaGeneral.SelectCommand.CommandText = " Select * from GL_account_adjustment_dtl where refrence_no=" & Qt(RefNo)
                    DaGeneral.Fill(ds1, "b")
                    For j = 0 To ds1.Tables("b").Rows.Count - 1
                        CmdGeneral.CommandText = "Update GL_account_adjustment_dtl_dtl set amount_adjustment =" & ds1.Tables("b").Rows(j).Item("amount_adjustment") & " where refrence_no_due = " & Qt(RefNo) & " And id_service_center_due =" & Qt(ds1.Tables("b").Rows(j).Item("id_service_center"))
                        CmdGeneral.ExecuteNonQuery()
                    Next



                End With
            Next
        End If

    End Sub


    Sub FixeFaraji860631()
        Call AlterTable1("inv_item_cost_transaction", "FK_inv_item_cost_transaction_inv_item", True)
        Call AlterTable1("inv_item_vendor", "FK_inv_item_vendor_inv_item", True)
        Call AlterTable1("inv_sales_transfer_dtl", "FK_inv_sales_transfer_dtl_inv_item", False)
        Call AlterTable1("inv_tab_autopart_specification", "FK_inv_tab_autopart_specification_inv_item", False)
        Call AlterTable1("inv_tab_item_warehouse", "FK_inv_tab_item_warehouse_inv_item", True)
        Call AlterTable1("Inv_Receive_product_dtl", "FK_Inv_Receive_product_dtl_inv_item", False)
        Call AlterTable1("inv_adjustment_dtl", "FK_inv_adjustment_dtl_inv_item", False)
        Call AlterTable1("Inv_purchase_order_dtl", "FK_Inv_purchase_order_dtl_inv_item", False)
        Call AlterTable1("inv_dtl_item", "FK_inv_dtl_item_inv_item", True)
        Call AlterTable1("inv_tab_tire_specification", "FK_inv_tab_tire_specification_inv_item", False)
        Call AlterTable1("inv_tab_wheels_specification", "FK_inv_tab_wheels_specification_inv_item", False)
        Call AlterTable1("inv_discount_item", "FK_inv_discount_item_inv_item", True)
    End Sub

    Sub AlterTable1(ByVal ThisTableName As String, ByVal ThisConstrantName As String, ByVal OnDeleteCasCade As Boolean)
        Dim Str1 As String = " ALTER TABLE [dbo].[" & ThisTableName.Trim & "] Drop CONSTRAINT [" & ThisConstrantName.Trim & "]"
        Dim Str2 As String = "ALTER TABLE [dbo].[" & ThisTableName.Trim & "] ADD CONSTRAINT [" & ThisConstrantName.Trim & "] FOREIGN KEY ([item_no]) REFERENCES [dbo].[inv_item] ([item_no]) " & IIf(OnDeleteCasCade, " ON DELETE CASCADE ", " ") & " ON UPDATE CASCADE "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Try
                CmdGeneral.CommandText = Str1
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
            '-------------------------
            CmdGeneral.CommandText = Str2
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub FixAp()

        'GL_AP_Bill_Head
        'GL_AP_bill_Dtl
        'GL_payment_bill
        'GL_payment_bill_COA
        'GL_AP_payment
        'GL_vendor_credit
        'GL_vendor_credit_head
        'Inv_Receive_product_Ap_Dtl
        'View_AllUnPaidGl_Ap_Bill_Dtl_Dtl
        'View_AllUnPaidReceive_product_ap_Dtl
        'View_AllUnPaidService_out_purchase
        'View_AllVendorCredit
        'View_AP_Bill_Dtl_Min_due_date
        'View_GL_vendor_creditReminder
        'With CmdGeneral
        '    .CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AllUnPaidGl_Ap_Bill_Dtl_Dtl]') and OBJECTPROPERTY(id, N'IsView') = 1)" & _
        '        " drop view [dbo].[View_AllUnPaidGl_Ap_Bill_Dtl_Dtl]"
        '    Try
        '        .ExecuteNonQuery()
        '    Catch ex As Exception

        '    End Try
        'End With



        'With CmdGeneral
        '    .CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AllUnPaidGl_Ap_Bill_Dtl_Dtl]') and OBJECTPROPERTY(id, N'IsView') = 1)" & _
        '        " drop view [dbo].[View_AllUnPaidGl_Ap_Bill_Dtl_Dtl]"
        '    Try
        '        .ExecuteNonQuery()
        '    Catch ex As Exception

        '    End Try
        'End With




        'With CmdGeneral
        '    .CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AllUnPaidReceive_product_ap_Dtl]') and OBJECTPROPERTY(id, N'IsView') = 1)" & _
        '    " drop view [dbo].[View_AllUnPaidReceive_product_ap_Dtl]"
        '    Try
        '        .ExecuteNonQuery()
        '    Catch ex As Exception

        '    End Try
        'End With


        'With CmdGeneral
        '    .CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AllUnPaidService_out_purchase]') and OBJECTPROPERTY(id, N'IsView') = 1)" & _
        '        " drop view [dbo].[View_AllUnPaidService_out_purchase]"
        '    Try
        '        .ExecuteNonQuery()
        '    Catch ex As Exception

        '    End Try
        'End With



        'With CmdGeneral
        '    .CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AllVendorCreadit]') and OBJECTPROPERTY(id, N'IsView') = 1)" & _
        '        " drop view [dbo].[View_AllVendorCreadit]"
        '    Try
        '        .ExecuteNonQuery()
        '    Catch ex As Exception

        '    End Try
        'End With



        'With CmdGeneral
        '    .CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_GL_vendor_creditReminder]') and OBJECTPROPERTY(id, N'IsView') = 1)" & _
        '                    " drop view [dbo].[View_GL_vendor_creditReminder]"
        '    Try
        '        .ExecuteNonQuery()
        '    Catch ex As Exception

        '    End Try
        'End With


        'With CmdGeneral
        '    .CommandText = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[View_AP_Bill_Dtl_Min_due_date]') and OBJECTPROPERTY(id, N'IsView') = 1)" & _
        '                    " drop view [dbo].[View_AP_Bill_Dtl_Min_due_date]"
        '    Try
        '        .ExecuteNonQuery()
        '    Catch ex As Exception

        '    End Try
        'End With

        With CmdGeneral
            .CommandText = "CREATE TABLE [dbo].[GL_AP_Bill_Head] ( " & _
                            "	[Id_AP_bill_Head] [char] (10)   NOT NULL ," & _
                            "	[cod_vendor] [char] (6)   NOT NULL ," & _
                            "	[Date_Bill] [char] (10)   NULL ," & _
                            "	[Remark] [varchar] (200)   NULL " & _
                            " ) ON [PRIMARY]"
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With



        With CmdGeneral
            .CommandText = "CREATE TABLE [dbo].[GL_AP_bill_Dtl] ( " & _
                            "	[Id_AP_bill_dtl] [int] IDENTITY (1, 1) NOT NULL ," & _
                            "	[Id_AP_bill_Head] [char] (10)   NULL ," & _
                            "	[ref_no] [char] (10)   NULL ," & _
                            "	[AR_terms] [char] (10)   NULL ," & _
                            "	[amount] [money] NULL ," & _
                            "	[Discount] [money] NULL ," & _
                            "	[id_GL_journal] [int] NULL ," & _
                            "	[Ref_date] [char] (10)   NULL ," & _
                            "	[Desc_Bill] [varchar] (100)   NULL " & _
                            ") ON [PRIMARY] "

            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        Try
            CmdGeneral.CommandText = "CREATE TABLE [dbo].[GL_AP_bill_Dtl_Dtl] ( " & _
    "	[Id_AP_bill_dtl_dtl] [int] IDENTITY (1, 1) NOT NULL , " & _
    "	[Id_AP_bill_dtl] [int] NULL , " & _
    "	[amount] [money] NULL , " & _
    "	[due_date] [char] (10) NULL  " & _
    " ) ON [PRIMARY] "

            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        With CmdGeneral
            .CommandText = " CREATE TABLE [dbo].[GL_payment_bill] ( " & _
                            "	[Id_payment_bill] [int] IDENTITY (1, 1) NOT NULL ," & _
                            "	[date_payment_bill] [char] (10)   NULL ," & _
                            "	[amount_pay] [money] NULL ," & _
                            "	[id_receive_ref] [char] (6)   NULL ," & _
                            "	[id_service_center] [char] (10)   NULL ," & _
                            "	[radif] [smallint] NULL ," & _
                            "	[Id_AP_bill_dtl_dtl] [int] NULL ," & _
                            "	[id_check] [int] NULL " & _
                            " ) ON [PRIMARY]"

            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With



        With CmdGeneral
            .CommandText = "CREATE TABLE [dbo].[GL_payment_bill_COA] ( " & _
                            "	[Id_AP_bill_dtl] [int] NOT NULL ," & _
                            "	[GL_account] [varchar] (10)   NOT NULL ," & _
                            "	[Amount] [money] NULL ," & _
                            "	[Memo] [varchar] (100)   NULL " & _
                            ") ON [PRIMARY]"
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        With CmdGeneral
            .CommandText = "CREATE TABLE [dbo].[GL_AP_payment] ( " & _
                            "	[ID_AP_payment] [int] IDENTITY (1, 1) NOT NULL ," & _
                            "	[Id_AP_bill_dtl_dtl] [int] NULL ," & _
                            "	[ID_Inv_Receive_product_Ap_Dtl] [int] NULL ," & _
                            "	[id_service_center] [char] (10)   NULL ," & _
                            "	[radif] [smallint] NULL ," & _
                            "	[amount_pay] [money] NOT NULL ," & _
                            "	[remark] [varchar] (50)   NULL ," & _
                            "	[date_prepare] [char] (10)   NOT NULL ," & _
                            "	[id_check] [int] NULL ," & _
                            "	[radif1] [smallint] NULL ," & _
                            "	[id_vendor_credit_head] [int] NULL " & _
                            ") ON [PRIMARY]"
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        With CmdGeneral
            .CommandText = "CREATE TABLE [dbo].[GL_vendor_credit] ( " & _
                            "	[id_vendor_credit] [int] IDENTITY (1, 1) NOT NULL , " & _
                            "	[cod_vendor] [char] (6)   NOT NULL , " & _
                            "	[date_credit] [char] (10)   NULL , " & _
                            "	[amount_credit] [money] NOT NULL , " & _
                            "	[Remark] [varchar] (100)   NULL , " & _
                            "	[ref_no] [varchar] (20)   NULL , " & _
                            "	[due_date] [char] (10)   NULL , " & _
                            "	[id_vendor_credit_head] [int] NULL " & _
                            ") ON [PRIMARY]"
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With



        With CmdGeneral
            .CommandText = "CREATE TABLE [dbo].[GL_vendor_credit_head] ( " & _
                            "	[id_vendor_credit_head] [int] IDENTITY (1, 1) NOT NULL , " & _
                            "	[desc_vendor_credit_head1] [int] NULL , " & _
                            "	[date_pass] [char] (10)   NULL  " & _
                            ") ON [PRIMARY] "

            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        With CmdGeneral
            .CommandText = "CREATE TABLE [dbo].[Inv_Receive_product_Ap_Dtl] ( " & _
                            "	[ID_Inv_Receive_product_Ap_Dtl] [int] IDENTITY (1, 1) NOT NULL , " & _
                            "	[id_receive_ref] [char] (6)   NOT NULL , " & _
                            "	[amount] [money] NOT NULL , " & _
                            "	[due_date] [char] (10)   NOT NULL  " & _
                            ") ON [PRIMARY]"
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With



        With CmdGeneral
            .CommandText = "ALTER TABLE [dbo].[GL_AP_Bill_Head] WITH NOCHECK ADD  " & _
                            "	CONSTRAINT [PK_GL_AP_Bill_Head] PRIMARY KEY  CLUSTERED  " & _
                            "	( " & _
                            "		[Id_AP_bill_Head] " & _
                            "	)  ON [PRIMARY] "
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        With CmdGeneral
            .CommandText = "ALTER TABLE [dbo].[GL_AP_bill_Dtl] WITH NOCHECK ADD  " & _
                            "	CONSTRAINT [PK_GL_AP_bill] PRIMARY KEY  CLUSTERED  " & _
                            "	( " & _
                            "		[Id_AP_bill_dtl] " & _
                            "	)  ON [PRIMARY] "
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        With CmdGeneral
            .CommandText = "ALTER TABLE [dbo].[GL_payment_bill] WITH NOCHECK ADD  " & _
                            "	CONSTRAINT [PK_GL_payment_bill] PRIMARY KEY  CLUSTERED  " & _
                            "	( " & _
                            "		[Id_payment_bill] " & _
                            "	)  ON [PRIMARY]  "
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        With CmdGeneral
            .CommandText = "ALTER TABLE [dbo].[GL_payment_bill_COA] WITH NOCHECK ADD  " & _
                            "	CONSTRAINT [PK_GL_payment_bill_COA] PRIMARY KEY  CLUSTERED  " & _
                            "	( " & _
                            "		[Id_AP_bill_dtl], " & _
                            "		[GL_account] " & _
                            "	)  ON [PRIMARY] "
            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With


        With CmdGeneral
            .CommandText = "ALTER TABLE [dbo].[GL_AP_payment] WITH NOCHECK ADD  " & _
                            "	CONSTRAINT [PK_GL_AP_payment] PRIMARY KEY  CLUSTERED  " & _
                            "	( " & _
                            "		[ID_AP_payment] " & _
                            "	)  ON [PRIMARY] "

            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With

        With CmdGeneral
            .CommandText = "ALTER TABLE [dbo].[GL_vendor_credit] WITH NOCHECK ADD  " & _
                            "	CONSTRAINT [PK_GL_vendor_credit] PRIMARY KEY  CLUSTERED  " & _
                            "	( " & _
                            "		[id_vendor_credit] " & _
                            "	)  ON [PRIMARY] "

            Try
                .ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End With






        execit("ALTER TABLE [dbo].[GL_vendor_credit_head] WITH NOCHECK ADD  " & _
        "	CONSTRAINT [PK_GL_vendor_credit_head] PRIMARY KEY  CLUSTERED  " & _
        "	( " & _
        "		[id_vendor_credit_head] " & _
        "	)  ON [PRIMARY]  ", CmdGeneral)


        execit("ALTER TABLE [dbo].[Inv_Receive_product_Ap_Dtl] WITH NOCHECK ADD  " & _
        "	CONSTRAINT [PK_Inv_Receive_product_Ap_Dtl] PRIMARY KEY  CLUSTERED  " & _
        "	( " & _
        "		[ID_Inv_Receive_product_Ap_Dtl] " & _
        "	)  ON [PRIMARY] ", CmdGeneral)


        execit("ALTER TABLE [dbo].[GL_vendor_credit] ADD  " & _
        "	CONSTRAINT [DF_GL_vendor_credit_amount_credit] DEFAULT (0) FOR [amount_credit]", CmdGeneral)


        execit("ALTER TABLE [dbo].[Inv_Receive_product_Ap_Dtl] ADD  " & _
        "	CONSTRAINT [DF_Inv_Receive_product_Ap_Dtl_amount] DEFAULT (0) FOR [amount]", CmdGeneral)


        execit("ALTER TABLE [dbo].[GL_AP_bill_Dtl] ADD  " & _
        "	CONSTRAINT [FK_GL_AP_bill_Dtl_GL_AP_Bill_Head] FOREIGN KEY  " & _
        "	( " & _
        "		[Id_AP_bill_Head] " & _
        "	) REFERENCES [dbo].[GL_AP_Bill_Head] ( " & _
        "		[Id_AP_bill_Head] " & _
        "	) ON DELETE CASCADE  ON UPDATE CASCADE , " & _
        "	CONSTRAINT [FK_GL_AP_bill_GL_TAB_AR_TERM] FOREIGN KEY  " & _
        "	( " & _
        "		[AR_terms] " & _
        "	) REFERENCES [dbo].[GL_TAB_AR_TERM] ( " & _
        "		[AR_terms] " & _
        "	) ON UPDATE CASCADE ", CmdGeneral)


        execit("ALTER TABLE [dbo].[GL_payment_bill] ADD  " & _
        "	CONSTRAINT [FK_GL_payment_bill_GL_AP_bill_Dtl] FOREIGN KEY  " & _
        "	( " & _
        "		[Id_AP_bill_dtl_dtl] " & _
        "	) REFERENCES [dbo].[GL_AP_bill_Dtl_Dtl] ( " & _
        "		[Id_AP_bill_dtl_dtl] " & _
        "	), " & _
        "	CONSTRAINT [FK_GL_payment_bill_Inv_Receive_Products_head] FOREIGN KEY  " & _
        "	( " & _
        "		[id_receive_ref] " & _
        "	) REFERENCES [dbo].[Inv_Receive_Products_head] ( " & _
        "		[id_receive_ref] " & _
        "	), " & _
        "	CONSTRAINT [FK_GL_payment_bill_service_out_purchases] FOREIGN KEY  " & _
        "	( " & _
        "		[id_service_center], " & _
        "		[radif] " & _
        "	) REFERENCES [dbo].[service_out_purchases] ( " & _
        "		[id_service_center], " & _
        "		[radif] " & _
        "	)", CmdGeneral)


        execit("ALTER TABLE [dbo].[GL_payment_bill_COA] ADD  " & _
        "	CONSTRAINT [FK_GL_payment_bill_COA_GL_account] FOREIGN KEY  " & _
        "	( " & _
        "		[GL_account] " & _
        "	) REFERENCES [dbo].[GL_account] ( " & _
        "		[GL_account] " & _
        "	) ON UPDATE CASCADE , " & _
        "	CONSTRAINT [FK_GL_payment_bill_COA_GL_AP_bill] FOREIGN KEY  " & _
        "	( " & _
        "		[Id_AP_bill_dtl] " & _
        "	) REFERENCES [dbo].[GL_AP_bill_Dtl] ( " & _
        "		[Id_AP_bill_dtl] " & _
        "	) ON DELETE CASCADE  ON UPDATE CASCADE ", CmdGeneral)


        execit("ALTER TABLE [dbo].[GL_AP_payment] ADD  " & _
        "	CONSTRAINT [FK_GL_AP_payment_GL_AP_bill_Dtl_Dtl] FOREIGN KEY  " & _
        "	( " & _
        "		[Id_AP_bill_dtl_dtl] " & _
        "	) REFERENCES [dbo].[GL_AP_bill_Dtl_Dtl] ( " & _
        "		[Id_AP_bill_dtl_dtl] " & _
        "	), " & _
        "	CONSTRAINT [FK_GL_AP_payment_GL_vendor_credit_head] FOREIGN KEY  " & _
        "	( " & _
        "		[id_vendor_credit_head] " & _
        "	) REFERENCES [dbo].[GL_vendor_credit_head] ( " & _
        "		[id_vendor_credit_head] " & _
        "	), " & _
        "	CONSTRAINT [FK_GL_AP_payment_Inv_Receive_product_Ap_Dtl] FOREIGN KEY  " & _
        "	( " & _
        "		[ID_Inv_Receive_product_Ap_Dtl] " & _
        "	) REFERENCES [dbo].[Inv_Receive_product_Ap_Dtl] ( " & _
        "		[ID_Inv_Receive_product_Ap_Dtl] " & _
        "	), " & _
        "	CONSTRAINT [FK_GL_AP_payment_service_out_purchases] FOREIGN KEY  " & _
        "	( " & _
        "		[id_service_center], " & _
        "		[radif] " & _
        "	) REFERENCES [dbo].[service_out_purchases] ( " & _
        "		[id_service_center], " & _
        "		[radif] " & _
        "	)", CmdGeneral)


        execit("alter table [dbo].[GL_AP_payment] nocheck constraint [FK_GL_AP_payment_GL_vendor_credit_head]", CmdGeneral)


        execit("ALTER TABLE [dbo].[GL_vendor_credit] ADD  " & _
        "	CONSTRAINT [FK_GL_vendor_credit_GL_vendor_credit_head] FOREIGN KEY  " & _
        "	( " & _
        "		[id_vendor_credit_head] " & _
        "	) REFERENCES [dbo].[GL_vendor_credit_head] ( " & _
        "		[id_vendor_credit_head] " & _
        "	), " & _
        "	CONSTRAINT [FK_GL_vendor_credit_inv_vendor] FOREIGN KEY  " & _
        "	( " & _
        "		[cod_vendor] " & _
        "	) REFERENCES [dbo].[inv_vendor] ( " & _
        "		[cod_vendor] " & _
        "	) ON UPDATE CASCADE ", CmdGeneral)


        execit("alter table [dbo].[GL_vendor_credit] nocheck constraint [FK_GL_vendor_credit_GL_vendor_credit_head]", CmdGeneral)


        execit("ALTER TABLE [dbo].[Inv_Receive_product_Ap_Dtl] ADD  " & _
        "	CONSTRAINT [FK_Inv_Receive_product_Ap_Dtl_Inv_Receive_Products_head] FOREIGN KEY  " & _
        "	( " & _
        "		[id_receive_ref] " & _
        "	) REFERENCES [dbo].[Inv_Receive_Products_head] ( " & _
        "		[id_receive_ref] " & _
        "	) ON DELETE CASCADE  ON UPDATE CASCADE ", CmdGeneral)



        execit(" CREATE VIEW dbo.View_AP_Bill_Dtl_Min_due_date  AS   SELECT     dbo.ChangeDateToNormal(MIN(dbo.ChangeDate(due_date))) AS Min_due_date, Id_AP_bill_dtl   FROM         dbo.GL_AP_bill_Dtl_Dtl   GROUP BY Id_AP_bill_dtl ", CmdGeneral, False, True, "View_AP_Bill_Dtl_Min_due_date")


        execit(" CREATE VIEW dbo.View_AllUnPaidService_out_purchase " & _
" AS " & _
" SELECT     TOP 100 PERCENT ROUND(ISNULL(dbo.service_out_purchases.cost, 0), 2) AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay),  " & _
"                       0) AS sumpayment, dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif, dbo.service_out_purchases.due_date " & _
" FROM         dbo.service_out_purchases LEFT OUTER JOIN " & _
"                       dbo.GL_AP_payment ON dbo.service_out_purchases.id_service_center = dbo.GL_AP_payment.id_service_center AND  " & _
"                       dbo.service_out_purchases.radif = dbo.GL_AP_payment.radif " & _
" GROUP BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif, ROUND(ISNULL(dbo.service_out_purchases.cost, 0), 2),  " & _
"                       dbo.service_out_purchases.due_date " & _
" ORDER BY dbo.service_out_purchases.id_service_center, dbo.service_out_purchases.radif ", CmdGeneral, False, True, "View_AllUnPaidService_out_purchase")


        execit(" CREATE VIEW dbo.View_AllVendorCreadit " & _
" AS " & _
" SELECT      0 AS selected, dbo.inv_vendor.cod_vendor, dbo.inv_vendor.desc_vendor, SUM(dbo.GL_vendor_credit.amount_credit) AS sumamount_credit,  " & _
"                       dbo.GL_vendor_credit.due_date " & _
" FROM         dbo.GL_vendor_credit INNER JOIN " & _
"                       dbo.inv_vendor ON dbo.GL_vendor_credit.cod_vendor = dbo.inv_vendor.cod_vendor " & _
" WHERE     (dbo.GL_vendor_credit.id_vendor_credit_head IS NULL) " & _
" GROUP BY dbo.inv_vendor.cod_vendor, dbo.inv_vendor.desc_vendor, dbo.GL_vendor_credit.due_date ", CmdGeneral, False, True, "View_AllVendorCreadit")



        execit(" CREATE VIEW dbo.View_GL_vendor_creditReminder AS SELECT     cod_vendor, ISNULL(SUM(ROUND(ISNULL(amount_credit, 0), 2)), 0) AS SumCredit FROM         dbo.GL_vendor_credit WHERE     (id_vendor_credit_head IS NULL) GROUP BY cod_vendor, id_vendor_credit_head ", CmdGeneral, False, True, "View_GL_vendor_creditReminder")


        execit(" CREATE VIEW dbo.View_AllUnPaidGl_Ap_Bill_Dtl_Dtl " & _
" AS " & _
" SELECT     dbo.GL_AP_bill_Dtl_Dtl.amount AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment,  " & _
"                       dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, dbo.GL_AP_bill_Dtl_Dtl.due_date " & _
" FROM         dbo.GL_AP_bill_Dtl_Dtl LEFT OUTER JOIN " & _
"                       dbo.GL_AP_payment ON dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = dbo.GL_AP_payment.Id_AP_bill_dtl_dtl " & _
" GROUP BY dbo.GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, dbo.GL_AP_bill_Dtl_Dtl.amount, dbo.GL_AP_bill_Dtl_Dtl.due_date ", CmdGeneral, False, True, "View_AllUnPaidGl_Ap_Bill_Dtl_Dtl")



        execit(" CREATE VIEW dbo.View_AllUnPaidReceive_product_ap_Dtl " & _
" AS " & _
" SELECT     dbo.Inv_Receive_product_Ap_Dtl.amount AS sumoriginalamount, ISNULL(SUM(dbo.GL_AP_payment.amount_pay), 0) AS sumpayment,  " & _
"                       dbo.Inv_Receive_Products_head.id_receive_ref, dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl,  " & _
"                       dbo.Inv_Receive_Products_head.cod_vendor, dbo.Inv_Receive_product_Ap_Dtl.due_date " & _
" FROM         dbo.Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                       dbo.Inv_Receive_Products_head ON  " & _
"                       dbo.Inv_Receive_product_Ap_Dtl.id_receive_ref = dbo.Inv_Receive_Products_head.id_receive_ref LEFT OUTER JOIN " & _
"                       dbo.GL_AP_payment ON  " & _
"                       dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = dbo.GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl " & _
" GROUP BY dbo.Inv_Receive_Products_head.id_receive_ref, dbo.Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl,  " & _
"                       dbo.Inv_Receive_product_Ap_Dtl.amount, dbo.Inv_Receive_Products_head.cod_vendor, dbo.Inv_Receive_product_Ap_Dtl.due_date ", CmdGeneral, False, True, "View_AllUnPaidReceive_product_ap_Dtl")


        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_bill_Dtl_Dtl] WITH NOCHECK ADD  " & _
    "	CONSTRAINT [PK_GL_AP_bill_Dtl] PRIMARY KEY  CLUSTERED  " & _
    "	( " & _
    "		[Id_AP_bill_dtl_dtl] " & _
    "	)  ON [PRIMARY]  "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            CmdGeneral.CommandText = "ALTER TABLE [dbo].[GL_AP_bill_Dtl_Dtl] ADD  " & _
    "	CONSTRAINT [FK_GL_AP_bill_Dtl_GL_AP_bill] FOREIGN KEY  " & _
    "	( " & _
    "		[Id_AP_bill_dtl] " & _
    "	) REFERENCES [dbo].[GL_AP_bill_Dtl] ( " & _
    "		[Id_AP_bill_dtl] " & _
    "	) ON DELETE CASCADE  ON UPDATE CASCADE  "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        execit("CREATE VIEW dbo.View_AllVendorPaid  " & _
"AS " & _
" SELECT     GL_AP_payment.date_prepare, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_credit_head, inv_vendor.cod_vendor,  " & _
"                      inv_vendor.desc_vendor, GL_AP_payment.amount_pay, GL_AP_payment.id_check " & _
" FROM         GL_AP_payment INNER JOIN " & _
"                      service_out_purchases ON GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND  " & _
"                      GL_AP_payment.radif = service_out_purchases.radif INNER JOIN " & _
"                      inv_vendor ON service_out_purchases.cod_vendor = inv_vendor.cod_vendor " & _
"UNION ALL " & _
" SELECT     GL_AP_payment.date_prepare, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_credit_head, inv_vendor.cod_vendor,  " & _
"                      inv_vendor.desc_vendor, GL_AP_payment.amount_pay, GL_AP_payment.id_check " & _
" FROM         GL_AP_bill_Dtl_Dtl INNER JOIN " & _
"                      GL_AP_payment ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_AP_payment.Id_AP_bill_dtl_dtl INNER JOIN " & _
"                      GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN " & _
"                      GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER JOIN " & _
"                      inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor " & _
" UNION ALL " & _
" SELECT     GL_AP_payment.date_prepare, GL_AP_payment.ID_AP_payment, GL_AP_payment.id_vendor_credit_head, inv_vendor.cod_vendor,  " & _
"                      inv_vendor.desc_vendor, GL_AP_payment.amount_pay, GL_AP_payment.id_check " & _
" FROM         GL_AP_payment INNER JOIN " & _
"                       Inv_Receive_product_Ap_Dtl ON  " & _
"                       GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl INNER JOIN " & _
"                       Inv_Receive_product_dtl ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_product_dtl.id_receive_ref INNER JOIN " & _
"                       Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref AND  " & _
"                       Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref INNER JOIN " & _
"                       inv_vendor ON Inv_Receive_Products_head.cod_vendor = inv_vendor.cod_vendor ", CmdGeneral, False, True, "View_AllVendorPaid")

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
