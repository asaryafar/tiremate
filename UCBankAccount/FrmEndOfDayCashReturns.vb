Imports CommonClass
Public Class FrmEndOfDayCashReturns
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_Paid_received As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayCashReturns1 As UCBankAccount.DSFrmEndOfDayCashReturns
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayCashReturns))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayCashReturns1 = New UCBankAccount.DSFrmEndOfDayCashReturns
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_Paid_received = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayCashReturns1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_Paid_received"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayCashReturns1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_Paid_received</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""refrence_code""><Caption>Refrence No</Caption><TypeNameEmp" & _
        "tyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataM" & _
        "ember>refrence_code</DataMember><Key>refrence_code</Key><Position>0</Position><W" & _
        "idth>80</Width></Column0><Column1 ID=""action_date""><Caption>Date</Caption><DataM" & _
        "ember>action_date</DataMember><Key>action_date</Key><Position>1</Position><Width" & _
        ">78</Width></Column1><Column2 ID=""Total""><Caption>Total Amount</Caption><DataMem" & _
        "ber>Total</DataMember><FormatString>c</FormatString><Key>Total</Key><Position>2<" & _
        "/Position><TextAlignment>Far</TextAlignment><Width>92</Width></Column2><Column3 " & _
        "ID=""amount""><Caption>Cash Returned</Caption><DataMember>amount</DataMember><Form" & _
        "atString>c</FormatString><Key>amount</Key><Position>3</Position><TextAlignment>F" & _
        "ar</TextAlignment><Width>91</Width></Column3><Column4 ID=""fullname""><Caption>Cus" & _
        "tomer Name</Caption><DataMember>fullname</DataMember><EditType>NoEdit</EditType>" & _
        "<Key>fullname</Key><Position>4</Position><Width>212</Width></Column4><Column5 ID" & _
        "=""abbreviation_name""><Caption>Company</Caption><DataMember>abbreviation_name</Da" & _
        "taMember><Key>abbreviation_name</Key><Position>5</Position><Width>140</Width></C" & _
        "olumn5></Columns><GroupCondition ID="""" /><Key>GL_Paid_received</Key></RootTable>" & _
        "</GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 40)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayCashReturns1
        '
        Me.DsFrmEndOfDayCashReturns1.DataSetName = "DSFrmEndOfDayCashReturns"
        Me.DsFrmEndOfDayCashReturns1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.Total, GL_Paid_received.refrence_code, GL_Paid_receive" & _
        "d.action_date, GL_Paid_received.amount, cust_trtab_main.f_name + ' ' + cust_trta" & _
        "b_main.m_name + ' ' + cust_trtab_main.l_name AS fullname, cust_company.abbreviat" & _
        "ion_name FROM GL_Paid_received INNER JOIN service_center_head ON GL_Paid_receive" & _
        "d.id_service_center = service_center_head.id_service_center INNER JOIN cust_trta" & _
        "b_main ON GL_Paid_received.customer_code = cust_trtab_main.cod_customer LEFT OUT" & _
        "ER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_Paid_received(refrence_code, tran_type, action_date, customer_code" & _
        ", vendor_code, amount, GL_account, memo, Id_GL_journal, OtherReceipType, Id_debi" & _
        "t_deposit_head, id_service_center) VALUES (@refrence_code, @tran_type, @action_d" & _
        "ate, @customer_code, @vendor_code, @amount, @GL_account, @memo, @Id_GL_journal, " & _
        "@OtherReceipType, @Id_debit_deposit_head, @id_service_center); SELECT refrence_c" & _
        "ode, tran_type, action_date, customer_code, vendor_code, amount, GL_account, mem" & _
        "o, Id_GL_journal, OtherReceipType, Id_debit_deposit_head, id_service_center FROM" & _
        " GL_Paid_received WHERE (refrence_code = @refrence_code)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_code", System.Data.SqlDbType.VarChar, 8, "refrence_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tran_type", System.Data.SqlDbType.VarChar, 1, "tran_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_date", System.Data.SqlDbType.VarChar, 10, "action_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_code", System.Data.SqlDbType.VarChar, 10, "customer_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_code", System.Data.SqlDbType.VarChar, 6, "vendor_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_GL_journal", System.Data.SqlDbType.Int, 4, "Id_GL_journal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherReceipType", System.Data.SqlDbType.VarChar, 1, "OtherReceipType"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "Id_debit_deposit_head"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_Paid_received SET refrence_code = @refrence_code, tran_type = @tran_typ" & _
        "e, action_date = @action_date, customer_code = @customer_code, vendor_code = @ve" & _
        "ndor_code, amount = @amount, GL_account = @GL_account, memo = @memo, Id_GL_journ" & _
        "al = @Id_GL_journal, OtherReceipType = @OtherReceipType, Id_debit_deposit_head =" & _
        " @Id_debit_deposit_head, id_service_center = @id_service_center WHERE (refrence_" & _
        "code = @Original_refrence_code) AND (GL_account = @Original_GL_account OR @Origi" & _
        "nal_GL_account IS NULL AND GL_account IS NULL) AND (Id_GL_journal = @Original_Id" & _
        "_GL_journal OR @Original_Id_GL_journal IS NULL AND Id_GL_journal IS NULL) AND (I" & _
        "d_debit_deposit_head = @Original_Id_debit_deposit_head OR @Original_Id_debit_dep" & _
        "osit_head IS NULL AND Id_debit_deposit_head IS NULL) AND (OtherReceipType = @Ori" & _
        "ginal_OtherReceipType OR @Original_OtherReceipType IS NULL AND OtherReceipType I" & _
        "S NULL) AND (action_date = @Original_action_date OR @Original_action_date IS NUL" & _
        "L AND action_date IS NULL) AND (amount = @Original_amount OR @Original_amount IS" & _
        " NULL AND amount IS NULL) AND (customer_code = @Original_customer_code OR @Origi" & _
        "nal_customer_code IS NULL AND customer_code IS NULL) AND (id_service_center = @O" & _
        "riginal_id_service_center OR @Original_id_service_center IS NULL AND id_service_" & _
        "center IS NULL) AND (memo = @Original_memo OR @Original_memo IS NULL AND memo IS" & _
        " NULL) AND (tran_type = @Original_tran_type OR @Original_tran_type IS NULL AND t" & _
        "ran_type IS NULL) AND (vendor_code = @Original_vendor_code OR @Original_vendor_c" & _
        "ode IS NULL AND vendor_code IS NULL); SELECT refrence_code, tran_type, action_da" & _
        "te, customer_code, vendor_code, amount, GL_account, memo, Id_GL_journal, OtherRe" & _
        "ceipType, Id_debit_deposit_head, id_service_center FROM GL_Paid_received WHERE (" & _
        "refrence_code = @refrence_code)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_code", System.Data.SqlDbType.VarChar, 8, "refrence_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tran_type", System.Data.SqlDbType.VarChar, 1, "tran_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_date", System.Data.SqlDbType.VarChar, 10, "action_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_code", System.Data.SqlDbType.VarChar, 10, "customer_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_code", System.Data.SqlDbType.VarChar, 6, "vendor_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_GL_journal", System.Data.SqlDbType.Int, 4, "Id_GL_journal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherReceipType", System.Data.SqlDbType.VarChar, 1, "OtherReceipType"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "Id_debit_deposit_head"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_code", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtherReceipType", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtherReceipType", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tran_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tran_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_code", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_Paid_received WHERE (refrence_code = @Original_refrence_code) AND " & _
        "(GL_account = @Original_GL_account OR @Original_GL_account IS NULL AND GL_accoun" & _
        "t IS NULL) AND (Id_GL_journal = @Original_Id_GL_journal OR @Original_Id_GL_journ" & _
        "al IS NULL AND Id_GL_journal IS NULL) AND (Id_debit_deposit_head = @Original_Id_" & _
        "debit_deposit_head OR @Original_Id_debit_deposit_head IS NULL AND Id_debit_depos" & _
        "it_head IS NULL) AND (OtherReceipType = @Original_OtherReceipType OR @Original_O" & _
        "therReceipType IS NULL AND OtherReceipType IS NULL) AND (action_date = @Original" & _
        "_action_date OR @Original_action_date IS NULL AND action_date IS NULL) AND (amou" & _
        "nt = @Original_amount OR @Original_amount IS NULL AND amount IS NULL) AND (custo" & _
        "mer_code = @Original_customer_code OR @Original_customer_code IS NULL AND custom" & _
        "er_code IS NULL) AND (id_service_center = @Original_id_service_center OR @Origin" & _
        "al_id_service_center IS NULL AND id_service_center IS NULL) AND (memo = @Origina" & _
        "l_memo OR @Original_memo IS NULL AND memo IS NULL) AND (tran_type = @Original_tr" & _
        "an_type OR @Original_tran_type IS NULL AND tran_type IS NULL) AND (vendor_code =" & _
        " @Original_vendor_code OR @Original_vendor_code IS NULL AND vendor_code IS NULL)" & _
        ""
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_code", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtherReceipType", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtherReceipType", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tran_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tran_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_code", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_Paid_received
        '
        Me.DAGL_Paid_received.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_Paid_received.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_Paid_received.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_Paid_received.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("Id_GL_journal", "Id_GL_journal"), New System.Data.Common.DataColumnMapping("OtherReceipType", "OtherReceipType"), New System.Data.Common.DataColumnMapping("Id_debit_deposit_head", "Id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center")})})
        Me.DAGL_Paid_received.UpdateCommand = Me.SqlUpdateCommand1
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
        Me.Panel4.TabIndex = 8
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
        'FrmEndOfDayCashReturns
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 388)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayCashReturns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Returns"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayCashReturns1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_Paid_received.SelectCommand.CommandText = DAGL_Paid_received.SelectCommand.CommandText & WhereClauseVar & " ORDER BY GL_Paid_received.refrence_code"
        DAGL_Paid_received.Fill(DsFrmEndOfDayCashReturns1.GL_Paid_received)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
End Class
