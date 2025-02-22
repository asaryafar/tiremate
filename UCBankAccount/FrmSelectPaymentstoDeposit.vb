Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSelectPaymentstoDeposit
    Inherits FrmBase
    Public FlagOK As Boolean
    Public FilterDate As String
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSelectPaymentstoDeposit1 As UCBankAccount.DSFrmSelectPaymentstoDeposit
    Friend WithEvents BtnOK As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSelectAllCreditCards As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSelectAllCashAndCheck As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSelectNone As Janus.Windows.EditControls.UIButton
    Friend WithEvents DAGL_payment_depositForEdit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DtePaymentDate As CalendarCombo.CalendarCombo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSelectPaymentstoDeposit))
        Me.BtnOK = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnSelectAllCreditCards = New Janus.Windows.EditControls.UIButton
        Me.BtnSelectAllCashAndCheck = New Janus.Windows.EditControls.UIButton
        Me.BtnSelectNone = New Janus.Windows.EditControls.UIButton
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmSelectPaymentstoDeposit1 = New UCBankAccount.DSFrmSelectPaymentstoDeposit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.DAGL_payment_depositForEdit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DtePaymentDate = New CalendarCombo.CalendarCombo
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSelectPaymentstoDeposit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnOK.Location = New System.Drawing.Point(4, 361)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(65, 26)
        Me.BtnOK.TabIndex = 344
        Me.BtnOK.TabStop = False
        Me.BtnOK.Text = "OK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCancel.Location = New System.Drawing.Point(523, 361)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 26)
        Me.BtnCancel.TabIndex = 345
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSelectAllCreditCards
        '
        Me.BtnSelectAllCreditCards.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnSelectAllCreditCards.Location = New System.Drawing.Point(73, 361)
        Me.BtnSelectAllCreditCards.Name = "BtnSelectAllCreditCards"
        Me.BtnSelectAllCreditCards.Size = New System.Drawing.Size(146, 26)
        Me.BtnSelectAllCreditCards.TabIndex = 347
        Me.BtnSelectAllCreditCards.TabStop = False
        Me.BtnSelectAllCreditCards.Text = "Select All Credit Cards"
        '
        'BtnSelectAllCashAndCheck
        '
        Me.BtnSelectAllCashAndCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnSelectAllCashAndCheck.Location = New System.Drawing.Point(223, 361)
        Me.BtnSelectAllCashAndCheck.Name = "BtnSelectAllCashAndCheck"
        Me.BtnSelectAllCashAndCheck.Size = New System.Drawing.Size(146, 26)
        Me.BtnSelectAllCashAndCheck.TabIndex = 348
        Me.BtnSelectAllCashAndCheck.TabStop = False
        Me.BtnSelectAllCashAndCheck.Text = "Select All Cash And Check"
        '
        'BtnSelectNone
        '
        Me.BtnSelectNone.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnSelectNone.Location = New System.Drawing.Point(373, 361)
        Me.BtnSelectNone.Name = "BtnSelectNone"
        Me.BtnSelectNone.Size = New System.Drawing.Size(146, 26)
        Me.BtnSelectNone.TabIndex = 349
        Me.BtnSelectNone.TabStop = False
        Me.BtnSelectNone.Text = "Select None"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = Nothing
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_deposit</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""flag_deposit_bank""><ColumnType>CheckBox</ColumnType><Da" & _
        "taMember>flag_deposit_bank</DataMember><EditType>CheckBox</EditType><Key>flag_de" & _
        "posit_bank</Key><Position>0</Position><Width>22</Width></Column0><Column1 ID=""da" & _
        "te_refer""><Caption>Date</Caption><DataMember>date_refer</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>TextBox</FilterEditType><Key>date_refer</Key><Pos" & _
        "ition>1</Position><Selectable>False</Selectable><Width>79</Width></Column1><Colu" & _
        "mn2 ID=""PaymenyDepositType""><Caption>Type</Caption><DataMember>PaymenyDepositTyp" & _
        "e</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType" & _
        "><Key>PaymenyDepositType</Key><Position>2</Position><Selectable>False</Selectabl" & _
        "e><Width>34</Width></Column2><Column3 ID=""check_no""><Caption>Check No</Caption><" & _
        "DataMember>check_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>check_no</Key><Position>3</Position><Selectable>False</S" & _
        "electable><Width>78</Width></Column3><Column4 ID=""cc_type""><Caption>CC Type</Cap" & _
        "tion><DataMember>cc_type</DataMember><DefaultGroupInterval>Text</DefaultGroupInt" & _
        "erval><EditType>NoEdit</EditType><FilterEditType>DropDownList</FilterEditType><K" & _
        "ey>cc_type</Key><Position>4</Position><Selectable>False</Selectable><CompareTarg" & _
        "et>Text</CompareTarget><Width>58</Width><DropDownIndex>0</DropDownIndex></Column" & _
        "4><Column5 ID=""PmtMethod""><Caption>Pmt Meth</Caption><DataMember>PmtMethod</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>P" & _
        "mtMethod</Key><Position>5</Position><Selectable>False</Selectable><Width>57</Wid" & _
        "th></Column5><Column6 ID=""CustomerFullName""><Caption>Name</Caption><DataMember>C" & _
        "ustomerFullName</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</" & _
        "FilterEditType><Key>CustomerFullName</Key><Position>6</Position><Selectable>Fals" & _
        "e</Selectable><Width>157</Width></Column6><Column7 ID=""payment_amount""><Caption>" & _
        "Amount</Caption><DataMember>payment_amount</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><FormatString>c</FormatString><Key>pay" & _
        "ment_amount</Key><Position>7</Position><Selectable>False</Selectable><TextAlignm" & _
        "ent>Far</TextAlignment><Width>95</Width></Column7><Column8 ID=""ID_payment""><Capt" & _
        "ion>ID_payment</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue" & _
        "><EmptyStringValue /><DataMember>ID_payment</DataMember><EditType>NoEdit</EditTy" & _
        "pe><Key>ID_payment</Key><Position>8</Position><Visible>False</Visible></Column8>" & _
        "<Column9 ID=""id_service_center""><Caption>id_service_center</Caption><DataMember>" & _
        "id_service_center</DataMember><Key>id_service_center</Key><Position>9</Position>" & _
        "<Visible>False</Visible></Column9><Column10 ID=""refrence_no""><Caption>refrence_n" & _
        "o</Caption><DataMember>refrence_no</DataMember><Key>refrence_no</Key><Position>1" & _
        "0</Position><Visible>False</Visible></Column10><Column11 ID=""refer_type""><Captio" & _
        "n>refer_type</Caption><DataMember>refer_type</DataMember><Key>refer_type</Key><P" & _
        "osition>11</Position><Visible>False</Visible></Column11><Column12 ID=""payment_ty" & _
        "pe""><Caption>payment_type</Caption><DataMember>payment_type</DataMember><Key>pay" & _
        "ment_type</Key><Position>12</Position><Visible>False</Visible></Column12><Column" & _
        "13 ID=""deposit_to_id_bank""><Caption>deposit_to_id_bank</Caption><DataMember>depo" & _
        "sit_to_id_bank</DataMember><Key>deposit_to_id_bank</Key><Position>13</Position><" & _
        "Visible>False</Visible></Column13></Columns><GroupCondition ID="""" /><Key>GL_paym" & _
        "ent_deposit</Key></RootTable><DropDowns Collection=""true""><DropDown0><RootTable>" & _
        "<Columns Collection=""true""><Column0 ID=""cc_type""><Caption>cc_type</Caption><Type" & _
        "NameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /" & _
        "><DataMember>cc_type</DataMember><Key>cc_type</Key><Position>0</Position></Colum" & _
        "n0><Column1 ID=""cc_type_desc""><Caption>cc_type_desc</Caption><DataMember>cc_type" & _
        "_desc</DataMember><Key>cc_type_desc</Key><Position>1</Position></Column1></Colum" & _
        "ns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans Se" & _
        "rif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><ExpandableGroups>" & _
        "False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelecti" & _
        "on>Highlight</HideSelection><Key>cc_type</Key><DisplayMember>cc_type_desc</Displ" & _
        "ayMember><ValueMember>cc_type</ValueMember></DropDown0></DropDowns></GridEXLayou" & _
        "tData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(1, 29)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(601, 328)
        Me.GrdDetail.TabIndex = 350
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmSelectPaymentstoDeposit1.GL_payment_deposit
        '
        'DsFrmSelectPaymentstoDeposit1
        '
        Me.DsFrmSelectPaymentstoDeposit1.DataSetName = "DSFrmSelectPaymentstoDeposit"
        Me.DsFrmSelectPaymentstoDeposit1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 21)
        Me.Label1.TabIndex = 351
        Me.Label1.Text = "Select the payments you want to deposit, and then click OK."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_02;password=2191110"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, CASE WHEN refer_type = '3' THEN - GL_payment_deposit.payment_amount E" & _
        "LSE GL_payment_deposit.payment_amount END AS payment_amount, GL_payment_deposit." & _
        "flag_deposit_bank, service_center_head.date_refer, CASE WHEN refer_type = '1' TH" & _
        "EN 'PMT' ELSE 'ROA' END AS PaymenyDepositType, CASE payment_type WHEN '1' THEN '" & _
        "Cash' WHEN '2' THEN 'CHECK' WHEN '3' THEN 'Credit' END AS PmtMethod, CASE WHEN (" & _
        "cust_company.complete_name IS NULL OR cust_company.complete_name = '') THEN rtri" & _
        "m(ltrim(cust_trtab_main.f_name)) + ' ' + rtrim(ltrim(cust_trtab_main.m_name)) + " & _
        "' ' + rtrim(ltrim(cust_trtab_main.l_name)) ELSE cust_company.complete_name END A" & _
        "S CustomerFullName, GL_debit_deposit_head.id_bank, GL_debit_deposit.GL_account, " & _
        "CASE WHEN refer_type = '1' THEN Gl_payment_credit.cc_type ELSE Gl_receive_paymen" & _
        "t.cc_type END AS cc_type, CASE WHEN refer_type = '1' THEN GL_payment_check.check" & _
        "_no ELSE Gl_receive_payment.check_no END AS check_no, service_center_head.cod_cu" & _
        "stomer, dbo.ChangeDate(service_center_head.date_refer) AS date_referYYYYMMDD, Gl" & _
        "_receive_payment.date_receive_payment FROM GL_payment_deposit LEFT OUTER JOIN GL" & _
        "_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
        "LEFT OUTER JOIN service_center_head ON GL_payment_deposit.id_service_center = se" & _
        "rvice_center_head.id_service_center LEFT OUTER JOIN cust_trtab_main ON service_c" & _
        "enter_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_comp" & _
        "any ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN Gl" & _
        "_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence" & _
        "_no LEFT OUTER JOIN GL_debit_deposit ON GL_payment_deposit.ID_payment = GL_debit" & _
        "_deposit.ID_payment LEFT OUTER JOIN GL_debit_deposit_head ON GL_debit_deposit.id" & _
        "_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head LEFT OUTER JOI" & _
        "N GL_payment_check ON GL_payment_deposit.ID_payment = GL_payment_check.ID_paymen" & _
        "t WHERE (GL_payment_deposit.flag_deposit_bank = 0) AND (GL_payment_deposit.payme" & _
        "nt_type <> 4) AND (service_center_head.type_of_form = 'IN') AND (GL_payment_depo" & _
        "sit.refer_type = 1 OR GL_payment_deposit.refer_type = 2) AND (GL_payment_deposit" & _
        ".payment_type <> 6)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("deposit_to_id_bank", "deposit_to_id_bank")})})
        '
        'DAGL_payment_depositForEdit
        '
        Me.DAGL_payment_depositForEdit.DeleteCommand = Me.SqlCommand1
        Me.DAGL_payment_depositForEdit.InsertCommand = Me.SqlCommand2
        Me.DAGL_payment_depositForEdit.SelectCommand = Me.SqlCommand3
        Me.DAGL_payment_depositForEdit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("deposit_to_id_bank", "deposit_to_id_bank")})})
        Me.DAGL_payment_depositForEdit.UpdateCommand = Me.SqlCommand4
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM GL_payment_deposit WHERE (ID_payment = @Original_ID_payment) AND (dep" & _
        "osit_to_id_bank = @Original_deposit_to_id_bank OR @Original_deposit_to_id_bank I" & _
        "S NULL AND deposit_to_id_bank IS NULL) AND (flag_deposit_bank = @Original_flag_d" & _
        "eposit_bank OR @Original_flag_deposit_bank IS NULL AND flag_deposit_bank IS NULL" & _
        ") AND (id_service_center = @Original_id_service_center OR @Original_id_service_c" & _
        "enter IS NULL AND id_service_center IS NULL) AND (payment_amount = @Original_pay" & _
        "ment_amount OR @Original_payment_amount IS NULL AND payment_amount IS NULL) AND " & _
        "(payment_type = @Original_payment_type OR @Original_payment_type IS NULL AND pay" & _
        "ment_type IS NULL) AND (refer_type = @Original_refer_type OR @Original_refer_typ" & _
        "e IS NULL AND refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @O" & _
        "riginal_refrence_no IS NULL AND refrence_no IS NULL)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deposit_to_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deposit_to_id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_flag_deposit_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "flag_deposit_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount, flag_deposit_bank, deposit_to_id_bank) VALUES (@id_servi" & _
        "ce_center, @refrence_no, @refer_type, @payment_type, @payment_amount, @flag_depo" & _
        "sit_bank, @deposit_to_id_bank); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount, flag_deposit_bank, deposit_to_id_ba" & _
        "nk FROM GL_payment_deposit WHERE (ID_payment = @@IDENTITY)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@flag_deposit_bank", System.Data.SqlDbType.Bit, 1, "flag_deposit_bank"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_to_id_bank", System.Data.SqlDbType.SmallInt, 2, "deposit_to_id_bank"))
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_deposit.flag_deposit_ba" & _
        "nk, service_center_head.date_refer, CASE WHEN refer_type = '1' THEN 'PMT' ELSE '" & _
        "ROA' END AS PaymenyDepositType, CASE payment_type WHEN '1' THEN 'Cash' WHEN '2' " & _
        "THEN 'CHECK' WHEN '3' THEN 'Credit' END AS PmtMethod, CASE WHEN (cust_company.co" & _
        "mplete_name IS NULL OR cust_company.complete_name = '') THEN rtrim(ltrim(cust_tr" & _
        "tab_main.f_name)) + ' ' + rtrim(ltrim(cust_trtab_main.m_name)) + ' ' + rtrim(ltr" & _
        "im(cust_trtab_main.l_name)) ELSE cust_company.complete_name END AS CustomerFullN" & _
        "ame, GL_debit_deposit_head.id_bank, GL_debit_deposit.GL_account, Gl_receive_paym" & _
        "ent.cc_type, CASE WHEN refer_type = '1' THEN GL_payment_check.check_no ELSE Gl_r" & _
        "eceive_payment.check_no END AS check_no, service_center_head.cod_customer, bas_c" & _
        "c_type.cc_type_desc FROM GL_debit_deposit_head RIGHT OUTER JOIN GL_debit_deposit" & _
        " ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_depo" & _
        "sit_head AND GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_d" & _
        "ebit_deposit_head RIGHT OUTER JOIN GL_payment_deposit LEFT OUTER JOIN service_ce" & _
        "nter_head ON GL_payment_deposit.id_service_center = service_center_head.id_servi" & _
        "ce_center LEFT OUTER JOIN cust_trtab_main ON service_center_head.cod_customer = " & _
        "cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod" & _
        "_company = cust_company.cod_company LEFT OUTER JOIN Gl_receive_payment ON GL_pay" & _
        "ment_deposit.refrence_no = Gl_receive_payment.refrence_no ON GL_debit_deposit.ID" & _
        "_payment = GL_payment_deposit.ID_payment LEFT OUTER JOIN GL_payment_check ON GL_" & _
        "payment_deposit.ID_payment = GL_payment_check.ID_payment LEFT OUTER JOIN bas_cc_" & _
        "type ON Gl_receive_payment.cc_type = bas_cc_type.cc_type WHERE (GL_payment_depos" & _
        "it.flag_deposit_bank = 1) AND (GL_debit_deposit_head.id_debit_deposit_head = @id" & _
        "_debit_deposit_head)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount, flag_deposit_bank = @flag_deposit_bank, deposit_to_id" & _
        "_bank = @deposit_to_id_bank WHERE (ID_payment = @Original_ID_payment) AND (depos" & _
        "it_to_id_bank = @Original_deposit_to_id_bank OR @Original_deposit_to_id_bank IS " & _
        "NULL AND deposit_to_id_bank IS NULL) AND (flag_deposit_bank = @Original_flag_dep" & _
        "osit_bank OR @Original_flag_deposit_bank IS NULL AND flag_deposit_bank IS NULL) " & _
        "AND (id_service_center = @Original_id_service_center OR @Original_id_service_cen" & _
        "ter IS NULL AND id_service_center IS NULL) AND (payment_amount = @Original_payme" & _
        "nt_amount OR @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (p" & _
        "ayment_type = @Original_payment_type OR @Original_payment_type IS NULL AND payme" & _
        "nt_type IS NULL) AND (refer_type = @Original_refer_type OR @Original_refer_type " & _
        "IS NULL AND refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Ori" & _
        "ginal_refrence_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_servic" & _
        "e_center, refrence_no, refer_type, payment_type, payment_amount, flag_deposit_ba" & _
        "nk, deposit_to_id_bank FROM GL_payment_deposit WHERE (ID_payment = @ID_payment)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@flag_deposit_bank", System.Data.SqlDbType.Bit, 1, "flag_deposit_bank"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_to_id_bank", System.Data.SqlDbType.SmallInt, 2, "deposit_to_id_bank"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deposit_to_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deposit_to_id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_flag_deposit_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "flag_deposit_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'DAbas_cc_type
        '
        Me.DAbas_cc_type.DeleteCommand = Me.SqlDeleteCommand6
        Me.DAbas_cc_type.InsertCommand = Me.SqlInsertCommand6
        Me.DAbas_cc_type.SelectCommand = Me.SqlSelectCommand6
        Me.DAbas_cc_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_cc_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_type_desc", "cc_type_desc")})})
        Me.DAbas_cc_type.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM bas_cc_type WHERE (cc_type = @Original_cc_type) AND (cc_type_desc = @" & _
        "Original_cc_type_desc OR @Original_cc_type_desc IS NULL AND cc_type_desc IS NULL" & _
        ")"
        Me.SqlDeleteCommand6.Connection = Me.Cnn
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO bas_cc_type(cc_type, cc_type_desc) VALUES (@cc_type, @cc_type_desc); " & _
        "SELECT cc_type, cc_type_desc FROM bas_cc_type WHERE (cc_type = @cc_type)"
        Me.SqlInsertCommand6.Connection = Me.Cnn
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type_desc", System.Data.SqlDbType.VarChar, 50, "cc_type_desc"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cc_type, cc_type_desc FROM bas_cc_type"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE bas_cc_type SET cc_type = @cc_type, cc_type_desc = @cc_type_desc WHERE (cc" & _
        "_type = @Original_cc_type) AND (cc_type_desc = @Original_cc_type_desc OR @Origin" & _
        "al_cc_type_desc IS NULL AND cc_type_desc IS NULL); SELECT cc_type, cc_type_desc " & _
        "FROM bas_cc_type WHERE (cc_type = @cc_type)"
        Me.SqlUpdateCommand6.Connection = Me.Cnn
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type_desc", System.Data.SqlDbType.VarChar, 50, "cc_type_desc"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DtePaymentDate
        '
        Me.DtePaymentDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DtePaymentDate.BorderColor = System.Drawing.Color.Empty
        Me.DtePaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtePaymentDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DtePaymentDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DtePaymentDate.EditableSal = True
        Me.DtePaymentDate.Image = CType(resources.GetObject("DtePaymentDate.Image"), System.Drawing.Image)
        Me.DtePaymentDate.Location = New System.Drawing.Point(494, 2)
        Me.DtePaymentDate.MaxValue = CType(2500, Short)
        Me.DtePaymentDate.MinValue = CType(1800, Short)
        Me.DtePaymentDate.Name = "DtePaymentDate"
        Me.DtePaymentDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DtePaymentDate.Sal_Mali = Nothing
        Me.DtePaymentDate.ShowButton = True
        Me.DtePaymentDate.Size = New System.Drawing.Size(102, 23)
        Me.DtePaymentDate.TabIndex = 353
        Me.DtePaymentDate.VisualStyle = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(397, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 21)
        Me.Label14.TabIndex = 352
        Me.Label14.Text = "Up To This Date"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSelectPaymentstoDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(602, 389)
        Me.Controls.Add(Me.DtePaymentDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.BtnSelectNone)
        Me.Controls.Add(Me.BtnSelectAllCashAndCheck)
        Me.Controls.Add(Me.BtnSelectAllCreditCards)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Name = "FrmSelectPaymentstoDeposit"
        Me.Text = "Select Payments to Deposit"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSelectPaymentstoDeposit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSelectPaymentstoDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString

        DsFrmSelectPaymentstoDeposit1.bas_cc_type.Clear()
        DAbas_cc_type.Fill(DsFrmSelectPaymentstoDeposit1, "bas_cc_type")

        GrdDetail.DropDowns("cc_type").SetDataBinding(DsFrmSelectPaymentstoDeposit1, "BAS_cc_type")

        If Mid(DtePaymentDate.Text, 1, 2).Trim.Length = 0 Then
            DtePaymentDate.Text = FilterDate
        End If

        Call FilterRecords()

    End Sub
    Friend Sub FillDataSet(Optional ByVal id_debit_deposit_headParam As Decimal = 0)
        DsFrmSelectPaymentstoDeposit1.Clear()
        DAGL_payment_deposit.Fill(DsFrmSelectPaymentstoDeposit1, "GL_payment_deposit")
        If id_debit_deposit_headParam > 0 Then
            DAGL_payment_depositForEdit.SelectCommand.Parameters("@id_debit_deposit_head").Value = id_debit_deposit_headParam
            DAGL_payment_depositForEdit.Fill(DsFrmSelectPaymentstoDeposit1, "GL_payment_deposit")
        End If
        If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count - 1
                If Trim(DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_receive_payment") & "").Length > 0 Then
                    DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_refer") = DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_receive_payment")
                End If
                DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_referYYYYMMDD") = ChangeDateToYYYYMMDD(DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_refer") & "")
            Next
        End If
    End Sub
    Private Sub BtnSelectAllCreditCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectAllCreditCards.Click
        If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count - 1
                If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("payment_type") = "3" And DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_referYYYYMMDD") <= ChangeDateToYYYYMMDD(DtePaymentDate.Text) Then
                    DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("flag_deposit_bank") = True
                End If
            Next
        End If
    End Sub
    Private Sub BtnSelectAllCashAndCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectAllCashAndCheck.Click
        If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count - 1
                If (DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("payment_type") = "1" Or DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("payment_type") = "2") And DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_referYYYYMMDD") <= ChangeDateToYYYYMMDD(DtePaymentDate.Text) Then
                    DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("flag_deposit_bank") = True
                End If
            Next
        End If
    End Sub
    Private Sub BtnSelectNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectNone.Click
        If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count - 1
                DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("flag_deposit_bank") = False
            Next
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        FlagOK = False
        Me.Close()
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        FlagOK = True
        Me.Close()
    End Sub
    Private Sub DtePaymentDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtePaymentDate.Leave
        If ChangeDateToYYYYMMDD(DtePaymentDate.Text) > ChangeDateToYYYYMMDD(FilterDate) Then
            DtePaymentDate.Text = FilterDate
        End If
        Call FilterRecords()
    End Sub
    Private Sub FilterRecords()
        DataView1.RowFilter = "date_referYYYYMMDD<=" & Qt(ChangeDateToYYYYMMDD(DtePaymentDate.Text))
        Dim i As Integer
        If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count > 0 Then
            For i = 0 To DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count - 1
                If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("date_referYYYYMMDD") > ChangeDateToYYYYMMDD(DtePaymentDate.Text) Then
                    DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("flag_deposit_bank") = False
                End If
            Next
        End If
    End Sub
    Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        Select Case e.Column.Index
            Case 0
                Dim ThisReference_no As String = CurrentRow.Cells("refrence_no").Value() & ""
                Dim ThisFlagVar As Boolean = Not CurrentRow.Cells(0).Value
                If ThisReference_no.Trim.Length > 0 Then
                    If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count > 0 Then
                        Dim i As Integer
                        For i = 0 To DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count - 1
                            If DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("refrence_no") & "" = ThisReference_no Then
                                DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("flag_deposit_bank") = ThisFlagVar
                            End If
                        Next
                    End If
                End If
        End Select
    End Sub
End Class
