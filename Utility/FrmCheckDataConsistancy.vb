Imports CommonClass
Public Class FrmCheckDataConsistancy
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtHeadAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents TxtDtlAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents TxtDtlDtlAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents adjbut As System.Windows.Forms.Button
    Friend WithEvents cmd1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daglrecpay1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dageneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaCoustomerbalanceview As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaSP_CustomerAgingNotDueYet As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging1to30 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging61to90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAgingOver90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging31to60 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Pb1 As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents GridEX3 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GridEX4 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_adjustment_dtl_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaSP_CustomerBalance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmCheckDataConsistancy1 As DsFrmCheckDataConsistancy1
    Friend WithEvents DAGL_account_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAGL_account_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAService_center_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GridEX5 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GridEX6 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GridEX7 As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGL_account_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmCheckDataConsistancy1 = New Utility.DsFrmCheckDataConsistancy1
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAService_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.adjbut = New System.Windows.Forms.Button
        Me.TxtDtlDtlAdjustment = New System.Windows.Forms.TextBox
        Me.TxtDtlAdjustment = New System.Windows.Forms.TextBox
        Me.TxtHeadAdjustment = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmd1 = New System.Data.SqlClient.SqlCommand
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daglrecpay1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Button3 = New System.Windows.Forms.Button
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Dageneral = New System.Data.SqlClient.SqlDataAdapter
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GridEX3 = New Janus.Windows.GridEX.GridEX
        Me.Pb1 = New Janus.Windows.EditControls.UIProgressBar
        Me.Button5 = New System.Windows.Forms.Button
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaCoustomerbalanceview = New System.Data.SqlClient.SqlDataAdapter
        Me.DaSP_CustomerAgingNotDueYet = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging1to30 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging61to90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAgingOver90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging31to60 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Button6 = New System.Windows.Forms.Button
        Me.GridEX4 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_dtl_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.DaSP_CustomerBalance = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button7 = New System.Windows.Forms.Button
        Me.GridEX5 = New Janus.Windows.GridEX.GridEX
        Me.Button8 = New System.Windows.Forms.Button
        Me.GridEX6 = New Janus.Windows.GridEX.GridEX
        Me.Button9 = New System.Windows.Forms.Button
        Me.GridEX7 = New Janus.Windows.GridEX.GridEX
        CType(Me.DsFrmCheckDataConsistancy1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT refrence_no, cod_customer, amount_adjustment, date_adjustment, Remark, GL_" & _
        "account, id_GL_journal, Gl_receive_payment_Refrence_no, finance_charge_flag, Old" & _
        "_Amount_adjustment, FromStoreNo FROM GL_account_adjustment_head"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHSERVER;packet size=4096;user id=sa;data source=ARMANDEHSER" & _
        "VER;persist security info=True;initial catalog=TireMate_01;password="
        '
        'DAGL_account_adjustment_head
        '
        Me.DAGL_account_adjustment_head.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_account_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Gl_receive_payment_Refrence_no", "Gl_receive_payment_Refrence_no"), New System.Data.Common.DataColumnMapping("finance_charge_flag", "finance_charge_flag"), New System.Data.Common.DataColumnMapping("Old_Amount_adjustment", "Old_Amount_adjustment"), New System.Data.Common.DataColumnMapping("FromStoreNo", "FromStoreNo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT refrence_no, SUM(amount_adjustment) AS sumdtl FROM GL_account_adjustment_d" & _
        "tl GROUP BY refrence_no"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_account_adjustment_dtl
        '
        Me.DAGL_account_adjustment_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("Old_Amount_adjustment", "Old_Amount_adjustment")})})
        '
        'DsFrmCheckDataConsistancy1
        '
        Me.DsFrmCheckDataConsistancy1.DataSetName = "FrmCheckDataConsistancy1"
        Me.DsFrmCheckDataConsistancy1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check Adjustment 1"
        Me.ToolTip1.SetToolTip(Me.Button1, "The header amount isn't Equl to sum of Detail Amount")
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(8, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(301, 134)
        Me.ListBox1.TabIndex = 1
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_service_center, SUM(ROUND(payment_amount, 2)) AS sumpayment FROM GL_pay" & _
        "ment_deposit WHERE (refer_type = '1') GROUP BY id_service_center"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("refrence_no_Gl_receive_payment", "refrence_no_Gl_receive_payment"), New System.Data.Common.DataColumnMapping("Downpayment_Wo_No", "Downpayment_Wo_No")})})
        '
        'ListBox2
        '
        Me.ListBox2.Location = New System.Drawing.Point(316, 25)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(301, 134)
        Me.ListBox2.TabIndex = 4
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, dis" & _
        "count, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_c" & _
        "enter_before, id_GL_journal, Total FROM service_center_head"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAService_center_head
        '
        Me.DAService_center_head.SelectCommand = Me.SqlSelectCommand4
        Me.DAService_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(373, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Check Service Center Records"
        Me.ToolTip1.SetToolTip(Me.Button2, "Total Amount Of These Invoice  isn't  Equal To Cashier Amount")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.adjbut)
        Me.Panel1.Controls.Add(Me.TxtDtlDtlAdjustment)
        Me.Panel1.Controls.Add(Me.TxtDtlAdjustment)
        Me.Panel1.Controls.Add(Me.TxtHeadAdjustment)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(315, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 106)
        Me.Panel1.TabIndex = 7
        '
        'adjbut
        '
        Me.adjbut.Location = New System.Drawing.Point(16, 80)
        Me.adjbut.Name = "adjbut"
        Me.adjbut.Size = New System.Drawing.Size(166, 23)
        Me.adjbut.TabIndex = 13
        Me.adjbut.Text = "claculate"
        '
        'TxtDtlDtlAdjustment
        '
        Me.TxtDtlDtlAdjustment.Location = New System.Drawing.Point(81, 57)
        Me.TxtDtlDtlAdjustment.Name = "TxtDtlDtlAdjustment"
        Me.TxtDtlDtlAdjustment.Size = New System.Drawing.Size(126, 20)
        Me.TxtDtlDtlAdjustment.TabIndex = 12
        Me.TxtDtlDtlAdjustment.Text = ""
        '
        'TxtDtlAdjustment
        '
        Me.TxtDtlAdjustment.Location = New System.Drawing.Point(81, 33)
        Me.TxtDtlAdjustment.Name = "TxtDtlAdjustment"
        Me.TxtDtlAdjustment.Size = New System.Drawing.Size(126, 20)
        Me.TxtDtlAdjustment.TabIndex = 11
        Me.TxtDtlAdjustment.Text = ""
        '
        'TxtHeadAdjustment
        '
        Me.TxtHeadAdjustment.Location = New System.Drawing.Point(81, 9)
        Me.TxtHeadAdjustment.Name = "TxtHeadAdjustment"
        Me.TxtHeadAdjustment.Size = New System.Drawing.Size(126, 20)
        Me.TxtHeadAdjustment.TabIndex = 10
        Me.TxtHeadAdjustment.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dtl_Dtl Adj"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Detail Adj"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Head Adj"
        '
        'cmd1
        '
        Me.cmd1.Connection = Me.Cnn
        '
        'GridEX1
        '
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(624, 25)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(301, 136)
        Me.GridEX1.TabIndex = 8
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Gl_receive_payment.refrence_no, Gl_receive_payment.amount_receive AS Head_" & _
        "Amount, a.sumpay AS Detail_Amount FROM Gl_receive_payment INNER JOIN (SELECT ref" & _
        "rence_no AS refrence_noglpayment, SUM(round(isnull(payment_amount, 0), 2)) AS su" & _
        "mpay FROM GL_payment_deposit WHERE (NOT (refrence_no IS NULL)) GROUP BY refrence" & _
        "_no) a ON Gl_receive_payment.refrence_no = a.refrence_noglpayment AND Gl_receive" & _
        "_payment.amount_receive <> a.sumpay ORDER BY Gl_receive_payment.refrence_no"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'daglrecpay1
        '
        Me.daglrecpay1.SelectCommand = Me.SqlSelectCommand5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(686, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Check Receive Payment"
        Me.ToolTip1.SetToolTip(Me.Button3, "Receive Payment Amount isn't Equal To Sum of Detail Amount")
        '
        'GridEX2
        '
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.Location = New System.Drawing.Point(6, 190)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.Size = New System.Drawing.Size(301, 84)
        Me.GridEX2.TabIndex = 11
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_vehicle, cod_main, cod_size_main, cod_size_option FROM bas_vehicle_siz" & _
        "e"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'Dageneral
        '
        Me.Dageneral.SelectCommand = Me.SqlSelectCommand6
        Me.Dageneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_size", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_size_main", "cod_size_main"), New System.Data.Common.DataColumnMapping("cod_size_option", "cod_size_option")})})
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(60, 162)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(193, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Check Adjustment 2"
        Me.ToolTip1.SetToolTip(Me.Button4, "Sum Of Adjustment  in GL_account_adjustment_dtl isn't Equal to GL_account_adjustm" & _
        "ent_dtl_dtl")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridEX3)
        Me.Panel2.Controls.Add(Me.Pb1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(539, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 222)
        Me.Panel2.TabIndex = 15
        '
        'GridEX3
        '
        Me.GridEX3.DataMember = "View_Customer_Balance"
        Me.GridEX3.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>View_Customer_Balance</Caption><Columns Col" & _
        "lection=""true""><Column0 ID=""cod_customer""><Caption>cod_customer</Caption><TypeNa" & _
        "meEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><" & _
        "DataMember>cod_customer</DataMember><Key>cod_customer</Key><Position>0</Position" & _
        "><Width>95</Width></Column0><Column1 ID=""BalanceSP""><Caption>BalanceSP</Caption>" & _
        "<DataMember>BalanceSP</DataMember><Key>BalanceSP</Key><Position>1</Position><Wid" & _
        "th>78</Width></Column1><Column2 ID=""BalanceAmount""><Caption>BalanceAmount</Capti" & _
        "on><DataMember>BalanceAmount</DataMember><FormatString>c</FormatString><Key>Bala" & _
        "nceAmount</Key><Position>2</Position><TextAlignment>Far</TextAlignment><Width>92" & _
        "</Width></Column2><Column3 ID=""sumall1""><Caption>sumall1</Caption><DataMember>su" & _
        "mall1</DataMember><FormatString>c</FormatString><Key>sumall1</Key><Position>3</P" & _
        "osition><TextAlignment>Far</TextAlignment><Width>87</Width></Column3><Column4 ID" & _
        "=""notdue""><Caption>notdue</Caption><DataMember>notdue</DataMember><FormatString>" & _
        "c</FormatString><Key>notdue</Key><Position>4</Position><TextAlignment>Far</TextA" & _
        "lignment></Column4><Column5 ID=""a1to30""><Caption>a1to30</Caption><DataMember>a1t" & _
        "o30</DataMember><FormatString>c</FormatString><Key>a1to30</Key><Position>5</Posi" & _
        "tion><TextAlignment>Far</TextAlignment></Column5><Column6 ID=""a31to60""><Caption>" & _
        "a31to60</Caption><DataMember>a31to60</DataMember><FormatString>c</FormatString><" & _
        "Key>a31to60</Key><Position>6</Position><TextAlignment>Far</TextAlignment></Colum" & _
        "n6><Column7 ID=""a61to90""><Caption>a61to90</Caption><DataMember>a61to90</DataMemb" & _
        "er><FormatString>c</FormatString><Key>a61to90</Key><Position>7</Position><TextAl" & _
        "ignment>Far</TextAlignment></Column7><Column8 ID=""over90""><Caption>over90</Capti" & _
        "on><DataMember>over90</DataMember><FormatString>c</FormatString><Key>over90</Key" & _
        "><Position>8</Position><TextAlignment>Far</TextAlignment></Column8></Columns><Gr" & _
        "oupCondition ID="""" /><Key>View_Customer_Balance</Key></RootTable></GridEXLayoutD" & _
        "ata>"
        Me.GridEX3.DesignTimeLayout = GridEXLayout1
        Me.GridEX3.GroupByBoxVisible = False
        Me.GridEX3.Location = New System.Drawing.Point(4, 4)
        Me.GridEX3.Name = "GridEX3"
        Me.GridEX3.Size = New System.Drawing.Size(378, 160)
        Me.GridEX3.TabIndex = 17
        '
        'Pb1
        '
        Me.Pb1.Location = New System.Drawing.Point(2, 169)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Size = New System.Drawing.Size(378, 16)
        Me.Pb1.TabIndex = 16
        Me.Pb1.Text = "UiProgressBar1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(120, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "customer balance conflict"
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cod_customer, BalanceAmount FROM View_Customer_Balance"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO View_Customer_Balance(cod_customer, BalanceAmount) VALUES (@cod_custo" & _
        "mer, @BalanceAmount); SELECT cod_customer, BalanceAmount FROM View_Customer_Bala" & _
        "nce"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BalanceAmount", System.Data.SqlDbType.Money, 8, "BalanceAmount"))
        '
        'DaCoustomerbalanceview
        '
        Me.DaCoustomerbalanceview.InsertCommand = Me.SqlInsertCommand3
        Me.DaCoustomerbalanceview.SelectCommand = Me.SqlSelectCommand7
        Me.DaCoustomerbalanceview.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_Customer_Balance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'DaSP_CustomerAgingNotDueYet
        '
        Me.DaSP_CustomerAgingNotDueYet.SelectCommand = Me.SqlCommand3
        Me.DaSP_CustomerAgingNotDueYet.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAgingNotDueYet", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "[SP_CustomerAgingNotDueYet]"
        Me.SqlCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAging1to30
        '
        Me.DaSP_CustomerAging1to30.SelectCommand = Me.SqlCommand1
        Me.DaSP_CustomerAging1to30.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging1to30", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "[SP_CustomerAging1to30]"
        Me.SqlCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAging61to90
        '
        Me.DaSP_CustomerAging61to90.SelectCommand = Me.SqlCommand2
        Me.DaSP_CustomerAging61to90.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging61to90", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "[SP_CustomerAging61to90]"
        Me.SqlCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAgingOver90
        '
        Me.DaSP_CustomerAgingOver90.SelectCommand = Me.SqlCommand4
        Me.DaSP_CustomerAgingOver90.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAgingOver90", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "[SP_CustomerAgingOver90]"
        Me.SqlCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAging31to60
        '
        Me.DaSP_CustomerAging31to60.SelectCommand = Me.SqlCommand5
        Me.DaSP_CustomerAging31to60.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging31to60", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "[SP_CustomerAging31to60]"
        Me.SqlCommand5.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(60, 278)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(193, 23)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Check Adjustment 3"
        '
        'GridEX4
        '
        Me.GridEX4.GroupByBoxVisible = False
        Me.GridEX4.Location = New System.Drawing.Point(6, 304)
        Me.GridEX4.Name = "GridEX4"
        Me.GridEX4.Size = New System.Drawing.Size(301, 85)
        Me.GridEX4.TabIndex = 16
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT * FROM GL_account_adjustment_dtl_dtl WHERE (IDGL_account_adjustment_dtl_Du" & _
        "e NOT IN (SELECT IDGL_account_adjustment_dtl FROM GL_account_adjustment_dtl_dtl)" & _
        ")"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        '
        'DAGL_account_adjustment_dtl_dtl
        '
        Me.DAGL_account_adjustment_dtl_dtl.SelectCommand = Me.SqlSelectCommand8
        Me.DAGL_account_adjustment_dtl_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IDGL_account_adjustment_dtl", "IDGL_account_adjustment_dtl"), New System.Data.Common.DataColumnMapping("refrence_no_due", "refrence_no_due"), New System.Data.Common.DataColumnMapping("id_service_center_due", "id_service_center_due"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("IDGL_account_adjustment_dtl_Due", "IDGL_account_adjustment_dtl_Due"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("old_amount_adjustment", "old_amount_adjustment")})})
        '
        'DaSP_CustomerBalance
        '
        Me.DaSP_CustomerBalance.SelectCommand = Me.SqlSelectCommand9
        Me.DaSP_CustomerBalance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerBalance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "[SP_CustomerBalance]"
        Me.SqlSelectCommand9.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand9.Connection = Me.Cnn
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(391, 395)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(158, 23)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "claculate"
        '
        'GridEX5
        '
        Me.GridEX5.GroupByBoxVisible = False
        Me.GridEX5.Location = New System.Drawing.Point(318, 421)
        Me.GridEX5.Name = "GridEX5"
        Me.GridEX5.Size = New System.Drawing.Size(299, 71)
        Me.GridEX5.TabIndex = 19
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(59, 394)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(193, 23)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Check Adjustment 4"
        '
        'GridEX6
        '
        Me.GridEX6.GroupByBoxVisible = False
        Me.GridEX6.Location = New System.Drawing.Point(5, 419)
        Me.GridEX6.Name = "GridEX6"
        Me.GridEX6.Size = New System.Drawing.Size(301, 78)
        Me.GridEX6.TabIndex = 21
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(620, 395)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(295, 23)
        Me.Button9.TabIndex = 24
        Me.Button9.Text = "Rece payment adjustment error"
        '
        'GridEX7
        '
        Me.GridEX7.GroupByBoxVisible = False
        Me.GridEX7.Location = New System.Drawing.Point(621, 421)
        Me.GridEX7.Name = "GridEX7"
        Me.GridEX7.Size = New System.Drawing.Size(299, 71)
        Me.GridEX7.TabIndex = 23
        '
        'FrmCheckDataConsistancy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(927, 494)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GridEX7)
        Me.Controls.Add(Me.GridEX6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GridEX5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GridEX4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GridEX2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Name = "FrmCheckDataConsistancy"
        Me.Text = "Form1"
        CType(Me.DsFrmCheckDataConsistancy1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        cmd1.Connection = Cnn
        cmd1.Connection.Open()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Clear()
        DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl.Clear()
        DAGL_account_adjustment_head.Fill(DsFrmCheckDataConsistancy1.GL_account_adjustment_head)
        DAGL_account_adjustment_dtl.Fill(DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl)
        Dim i As Integer = 0
        ListBox1.Items.Clear()
        For i = 0 To DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows.Count - 1
            Dim dr1 As DsFrmCheckDataConsistancy1.GL_account_adjustment_dtlRow = DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl.FindByrefrence_no(DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows(i).Item("refrence_no"))
            If Not dr1 Is Nothing Then
                If Math.Round(dr1.sumdtl, 2) = DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows(i).Item("amount_adjustment") Then
                Else
                    ListBox1.Items.Add(DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows(i).Item("refrence_no") & " not equal ")
                End If
            Else
                ListBox1.Items.Add(DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows(i).Item("refrence_no") & " Not found in detail")
            End If
        Next
    End Sub
    '-----------------------------------'
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DsFrmCheckDataConsistancy1.GL_payment_deposit.Clear()
        DsFrmCheckDataConsistancy1.service_center_head.Clear()
        Dim i As Integer = 0
        ListBox2.Items.Clear()
        DAGL_payment_deposit.Fill(DsFrmCheckDataConsistancy1.GL_payment_deposit)
        DAService_center_head.Fill(DsFrmCheckDataConsistancy1.service_center_head)
        For i = 0 To DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows.Count - 1
            Dim dr1 As DsFrmCheckDataConsistancy1.service_center_headRow = DsFrmCheckDataConsistancy1.service_center_head.FindByid_service_center(DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("Id_service_center"))
            If Not dr1 Is Nothing Then
                If Math.Round(dr1.Total, 2) <> DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("sumpayment") Then
                    ListBox2.Items.Add(DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("Id_service_center") & " Total amount:" & dr1.Total & " - Cashier Amount:" & DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("sumpayment"))
                End If
            Else
                ListBox2.Items.Add(DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("Id_service_center") & " !!!!!!!!!!!!!!!")
            End If
        Next
    End Sub
    Private Sub adjbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjbut.Click
        Try
            cmd1.CommandText = " SELECT     SUM(ROUND(amount_adjustment, 2)) AS SumHead FROM  GL_account_adjustment_head"
            TxtHeadAdjustment.Text = cmd1.ExecuteScalar & ""

            cmd1.CommandText = " SELECT     SUM(ROUND(amount_adjustment, 2)) AS SumHead FROM  GL_account_adjustment_dtl"
            TxtDtlAdjustment.Text = cmd1.ExecuteScalar & ""

            cmd1.CommandText = " SELECT     SUM(ROUND(amount_adjustment, 2)) AS SumHead FROM  GL_account_adjustment_dtl_dtl"
            TxtDtlDtlAdjustment.Text = cmd1.ExecuteScalar & ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim aa As New DataSet
        Dageneral.SelectCommand.CommandText = " SELECT     *   FROM         (SELECT     GL_account_adjustment_dtl.refrence_no, SUM(ROUND(GL_account_adjustment_dtl.amount_adjustment, 2)) AS sumdtl, a.refrence_no_due,  a.sumdtldtl  FROM         GL_account_adjustment_dtl INNER JOIN  (SELECT     refrence_no_due, SUM(round(amount_adjustment, 2)) AS sumdtldtl   FROM         gl_account_adjustment_dtl_dtl    GROUP BY refrence_no_due) a ON GL_account_adjustment_dtl.refrence_no = a.refrence_no_due COLLATE Arabic_CI_AS    GROUP BY GL_account_adjustment_dtl.refrence_no, a.refrence_no_due, a.sumdtldtl) DERIVEDTBL WHERE     (sumdtl <> sumdtldtl) "
        daglrecpay1.Fill(aa, "t1")
        GridEX1.DataSource = aa
        GridEX1.DataMember = "t1"
        GridEX1.RetrieveStructure()
        GridEX1.Refetch()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim bb As New DataSet
        'Dageneral.SelectCommand.CommandText = " SELECT     *   FROM         (SELECT     GL_account_adjustment_dtl.refrence_no, SUM(ROUND(GL_account_adjustment_dtl.amount_adjustment, 2)) AS sumdtl, a.refrence_no_due,  a.sumdtldtl  FROM         GL_account_adjustment_dtl INNER JOIN  (SELECT     refrence_no_due, SUM(round(amount_adjustment, 2)) AS sumdtldtl   FROM         gl_account_adjustment_dtl_dtl    GROUP BY refrence_no_due) a ON GL_account_adjustment_dtl.refrence_no = a.refrence_no_due COLLATE Arabic_CI_AS    GROUP BY GL_account_adjustment_dtl.refrence_no, a.refrence_no_due, a.sumdtldtl) DERIVEDTBL WHERE     (sumdtl <> sumdtldtl) "
        Dageneral.SelectCommand.CommandText = " SELECT     *   FROM         (SELECT     GL_account_adjustment_dtl.refrence_no, SUM(ROUND(GL_account_adjustment_dtl.amount_adjustment, 2)) AS Adj_dtl,  a.Adj_Dtl_Dtl  FROM GL_account_adjustment_dtl INNER JOIN  (SELECT     refrence_no_due, SUM(round(amount_adjustment, 2)) AS Adj_Dtl_Dtl   FROM         gl_account_adjustment_dtl_dtl    GROUP BY refrence_no_due) a ON GL_account_adjustment_dtl.refrence_no = a.refrence_no_due COLLATE Arabic_CI_AS    GROUP BY GL_account_adjustment_dtl.refrence_no, a.refrence_no_due, a.Adj_Dtl_Dtl) DERIVEDTBL WHERE     (Adj_dtl <> Adj_Dtl_Dtl) "
        Dageneral.Fill(bb, "t2")
        With GridEX2
            .DataSource = bb
            .DataMember = "t2"
            .RetrieveStructure()
            .Refetch()
        End With
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DsFrmCheckDataConsistancy1.View_Customer_Balance.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAging1to30.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAging31to60.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAging61to90.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAgingOver90.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerBalance.Clear()

        DaCoustomerbalanceview.Fill(DsFrmCheckDataConsistancy1.View_Customer_Balance)
        With DaSP_CustomerAging1to30
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAging1to30)
        End With


        With DaSP_CustomerAging31to60
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAging31to60)
        End With


        With DaSP_CustomerAging61to90
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAging61to90)
        End With


        With DaSP_CustomerAgingNotDueYet
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet)
        End With


        With DaSP_CustomerAgingOver90
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAgingOver90)
        End With

        With DaSP_CustomerBalance
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerBalance)
        End With

        Dim i As Long
        Pb1.Maximum = DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows.Count + 1
        Pb1.Value = 0
        For i = 0 To DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows.Count - 1
            Pb1.Value = i
            Application.DoEvents()
            With DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows(i)
                .Item("BalanceSP") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerBalance.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("notdue") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("a1to30") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAging1to30.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("a31to60") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAging31to60.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("a61to90") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAging61to90.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("over90") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAgingOver90.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("sumall1") = .Item("notdue") + .Item("a1to30") + .Item("a31to60") + .Item("a61to90") + .Item("over90") 'Math.Round(CDec("0" & DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
            End With
        Next
        For i = 0 To DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows.Count - 1
            With DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows(i)
                If .Item("sumall1") = .Item("BalanceAmount") And .Item("BalanceSP") = .Item("BalanceAmount") Then
                    .Delete()
                End If
            End With
        Next

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim aa As New DataSet
        DAGL_account_adjustment_dtl_dtl.Fill(aa, "t1")
        GridEX4.DataSource = aa
        GridEX4.DataMember = "t1"
        GridEX4.RetrieveStructure()
        GridEX4.Refetch()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim aa As New DataSet
        Dageneral.SelectCommand.CommandText = " SELECT     * " & _
 " FROM         (SELECT     ROUND(A.payment_amount, 2) AS payment_amount1, A.ID_payment, " & _
 " (SELECT     SUM(ROUND(GL_payment_deposit.payment_amount, 2)) AS Expr1  FROM GL_payment_deposit_Detail INNER JOIN GL_payment_deposit ON GL_payment_deposit_Detail.ID_payment_Paid = GL_payment_deposit.ID_payment WHERE     A.ID_payment = GL_payment_deposit_Detail.ID_payment_Paid) AS payment_amount2, A.refrence_no " & _
 " FROM         GL_payment_deposit A INNER JOIN Gl_receive_payment ON A.refrence_no = Gl_receive_payment.refrence_no " & _
 " WHERE     (A.refer_type = '2') OR(A.refer_type = '3')) DERIVEDTBL WHERE     (payment_amount1 <> payment_amount2) "
        Dageneral.Fill(aa, "t1")
        GridEX5.DataSource = aa
        GridEX5.DataMember = "t1"
        GridEX5.RetrieveStructure()
        GridEX5.Refetch()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim aa As New DataSet
        Dageneral.SelectCommand.CommandText = "SELECT refrence_no  FROM   GL_payment_deposit_Detail " & _
                  " WHERE     (ID_payment_due NOT IN (SELECT ID_payment  FROM   gl_payment_deposit)) "
        Dageneral.Fill(aa, "t1")
        GridEX6.DataSource = aa
        GridEX6.DataMember = "t1"
        GridEX6.RetrieveStructure()
        GridEX6.Refetch()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim aa As New DataSet

        Dageneral.SelectCommand.CommandText = " SELECT     view1.refrence_no_Adjustment, view1.sumpayment, GL_account_adjustment_head.amount_adjustment, GL_payment_deposit.refrence_no" & _
                                                    " FROM         (SELECT     refrence_no_Adjustment, SUM(payment_amount) AS sumpayment " & _
                                                    "                        FROM         dbo.GL_payment_deposit " & _
                                                    "                        WHERE     (NOT (refrence_no_Adjustment IS NULL)) " & _
                                                    "                        GROUP BY refrence_no_Adjustment) view1 INNER JOIN " & _
                                                    "                      GL_account_adjustment_head ON view1.refrence_no_Adjustment = GL_account_adjustment_head.refrence_no AND " & _
                                                    "                      view1.sumpayment > GL_account_adjustment_head.amount_adjustment INNER JOIN " & _
                                                    "                      GL_payment_deposit ON GL_account_adjustment_head.refrence_no = GL_payment_deposit.refrence_no_Adjustment"

        Dageneral.Fill(aa, "t1")
        GridEX7.DataSource = aa
        GridEX7.DataMember = "t1"
        GridEX7.RetrieveStructure()
        GridEX7.Refetch()
    End Sub

End Class
