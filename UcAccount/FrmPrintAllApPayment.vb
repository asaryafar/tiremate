Imports CommonClass
Public Class FrmPrintAllApPayment
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbDate As System.Windows.Forms.ComboBox
    Friend WithEvents DaAllDate As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmPrintAllApPayment1 As UcAccount.DsFrmPrintAllApPayment
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dAView_AllPreAndPaidReceive_product_ap_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaView_AllPreAndPaidService_out_purchase As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaView_AllVendorPaid As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ButOk As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrintAllApPayment))
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPrintAllApPayment1 = New UcAccount.DsFrmPrintAllApPayment
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbDate = New System.Windows.Forms.ComboBox
        Me.DaAllDate = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.ButOk = New System.Windows.Forms.Button
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.dAView_AllPreAndPaidReceive_product_ap_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaView_AllPreAndPaidService_out_purchase = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaView_AllVendorPaid = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPrintAllApPayment1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.GrdDetail.DataMember = "View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl"
        Me.GrdDetail.DataSource = Me.DsFrmPrintAllApPayment1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl</Capti" & _
        "on><Columns Collection=""true""><Column0 ID=""vendorrefno""><Caption>Vendor Ref.</Ca" & _
        "ption><DataMember>vendorrefno</DataMember><EditTarget>Text</EditTarget><EditType" & _
        ">NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>vendorrefno</Key>" & _
        "<Position>0</Position><Width>94</Width></Column0><Column1 ID=""preparedate""><Capt" & _
        "ion>Prepare Date</Caption><DataMember>preparedate</DataMember><EditType>NoEdit</" & _
        "EditType><FilterEditType>TextBox</FilterEditType><Key>preparedate</Key><Position" & _
        ">1</Position><Width>77</Width></Column1><Column2 ID=""due_date""><Caption>Due Date" & _
        "</Caption><DataMember>due_date</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>due_date</Key><Position>2</Position><Width>74" & _
        "</Width></Column2><Column3 ID=""amount_pay""><AggregateFunction>Sum</AggregateFunc" & _
        "tion><Caption>Amount Paid</Caption><DataMember>amount_pay</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</Forma" & _
        "tString><Key>amount_pay</Key><Position>3</Position><TextAlignment>Far</TextAlign" & _
        "ment><Width>106</Width><TotalFormatString>c2</TotalFormatString></Column3><Colum" & _
        "n4 ID=""sumoriginalamount""><AggregateFunction>Sum</AggregateFunction><Caption>Amo" & _
        "unt Due</Caption><DataMember>sumoriginalamount</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Ke" & _
        "y>sumoriginalamount</Key><Position>4</Position><TextAlignment>Far</TextAlignment" & _
        "><Width>103</Width><TotalFormatString>c2</TotalFormatString></Column4><Column5 I" & _
        "D=""desc_vendor""><Caption>Vendor Company</Caption><DataMember>desc_vendor</DataMe" & _
        "mber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>des" & _
        "c_vendor</Key><Position>5</Position><Visible>False</Visible></Column5><Column6 I" & _
        "D=""cod_vendor""><Caption>cod_vendor</Caption><DataMember>cod_vendor</DataMember><" & _
        "Key>cod_vendor</Key><Position>6</Position><Visible>False</Visible></Column6><Col" & _
        "umn7 ID=""amount_check""><Caption>Check Amount</Caption><DataMember>amount_check</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><F" & _
        "ormatString>c2</FormatString><Key>amount_check</Key><Position>7</Position></Colu" & _
        "mn7><Column8 ID=""no_of_check""><Caption>Check No</Caption><DataMember>no_of_check" & _
        "</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType>" & _
        "<Key>no_of_check</Key><Position>8</Position><Width>91</Width></Column8><Column9 " & _
        "ID=""date_of_check""><Caption>Check Date</Caption><DataMember>date_of_check</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>da" & _
        "te_of_check</Key><Position>9</Position></Column9><Column10 ID=""name_bank""><Capti" & _
        "on>Bank Name</Caption><DataMember>name_bank</DataMember><EditType>NoEdit</EditTy" & _
        "pe><FilterEditType>TextBox</FilterEditType><Key>name_bank</Key><Position>10</Pos" & _
        "ition></Column10></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Gr" & _
        "oup0 ID=""Group0""><ColIndex>5</ColIndex><GroupInterval>Value</GroupInterval></Gro" & _
        "up0></Groups><Key>View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl</Key><SortKeys Collection" & _
        "=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex></SortKey0></SortKeys></Ro" & _
        "otTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ErrorImageIndex = -1
        Me.GrdDetail.EventErrorHandling = False
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 112)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(896, 432)
        Me.GrdDetail.TabIndex = 10
        Me.GrdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmPrintAllApPayment1
        '
        Me.DsFrmPrintAllApPayment1.DataSetName = "DsFrmPrintAllApPayment"
        Me.DsFrmPrintAllApPayment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_01;password=sa"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "Prepare  Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDate
        '
        Me.CmbDate.DataSource = Me.DsFrmPrintAllApPayment1.AllDate
        Me.CmbDate.DisplayMember = "date_prepare"
        Me.CmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDate.Location = New System.Drawing.Point(114, 80)
        Me.CmbDate.Name = "CmbDate"
        Me.CmbDate.Size = New System.Drawing.Size(154, 21)
        Me.CmbDate.TabIndex = 206
        Me.CmbDate.ValueMember = "date_prepare"
        '
        'DaAllDate
        '
        Me.DaAllDate.SelectCommand = Me.SqlCommand3
        Me.DaAllDate.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AllDate", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT date_prepare FROM View_AllVendorPaid GROUP BY date_prepare ORDER BY date_p" & _
        "repare"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.vendorrefno, View_AllPreAndPaidGl_Ap_" & _
        "Bill_Dtl_Dtl.date_prepare AS preparedate, View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.d" & _
        "ue_date, View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.cod_vendor, View_AllPreAndPaidGl_A" & _
        "p_Bill_Dtl_Dtl.amount_pay, View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamoun" & _
        "t - View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.sumpayment AS sumoriginalamount, View_A" & _
        "llPreAndPaidGl_Ap_Bill_Dtl_Dtl.sumpayment, inv_vendor.desc_vendor, View_AllPreAn" & _
        "dPaidGl_Ap_Bill_Dtl_Dtl.DateTransaction, View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.id" & _
        "_check, View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.id_vendor_credit_head, bas_banks.na" & _
        "me_bank, bank_check.no_of_check, bank_check.amount_check, bank_check.date_of_che" & _
        "ck FROM bas_banks INNER JOIN bank_check ON bas_banks.id_bank = bank_check.id_ban" & _
        "k RIGHT OUTER JOIN View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl INNER JOIN inv_vendor ON" & _
        " View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.cod_vendor = inv_vendor.cod_vendor ON bank" & _
        "_check.cod_vendor = inv_vendor.cod_vendor AND bank_check.id_check = View_AllPreA" & _
        "ndPaidGl_Ap_Bill_Dtl_Dtl.id_check WHERE (View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.da" & _
        "te_prepare = @date1)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date1", System.Data.SqlDbType.VarChar, 10, "preparedate"))
        '
        'DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl
        '
        Me.DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.MissingSchemaAction = System.Data.MissingSchemaAction.Ignore
        Me.DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("DateTransaction", "DateTransaction"), New System.Data.Common.DataColumnMapping("Id_AP_bill_Head", "Id_AP_bill_Head"), New System.Data.Common.DataColumnMapping("sumpayment", "sumpayment"), New System.Data.Common.DataColumnMapping("sumoriginalamount", "sumoriginalamount"), New System.Data.Common.DataColumnMapping("vendorrefno", "vendorrefno"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head")})})
        '
        'ButOk
        '
        Me.ButOk.Location = New System.Drawing.Point(283, 80)
        Me.ButOk.Name = "ButOk"
        Me.ButOk.TabIndex = 208
        Me.ButOk.Text = "Fill "
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT View_AllPreAndPaidReceive_product_ap_Dtl.due_date, View_AllPreAndPaidRecei" & _
        "ve_product_ap_Dtl.sumoriginalamount - View_AllPreAndPaidReceive_product_ap_Dtl.s" & _
        "umpayment AS sumoriginalamount, View_AllPreAndPaidReceive_product_ap_Dtl.sumpaym" & _
        "ent, View_AllPreAndPaidReceive_product_ap_Dtl.vendorrefno, View_AllPreAndPaidRec" & _
        "eive_product_ap_Dtl.date_prepare AS preparedate, View_AllPreAndPaidReceive_produ" & _
        "ct_ap_Dtl.amount_pay, View_AllPreAndPaidReceive_product_ap_Dtl.cod_vendor, inv_v" & _
        "endor.desc_vendor, View_AllPreAndPaidReceive_product_ap_Dtl.id_check, View_AllPr" & _
        "eAndPaidReceive_product_ap_Dtl.id_vendor_credit_head, bas_banks.name_bank, bank_" & _
        "check.no_of_check, bank_check.amount_check, bank_check.date_of_check FROM bas_ba" & _
        "nks INNER JOIN bank_check ON bas_banks.id_bank = bank_check.id_bank RIGHT OUTER " & _
        "JOIN View_AllPreAndPaidReceive_product_ap_Dtl INNER JOIN inv_vendor ON View_AllP" & _
        "reAndPaidReceive_product_ap_Dtl.cod_vendor = inv_vendor.cod_vendor ON bank_check" & _
        ".cod_vendor = inv_vendor.cod_vendor AND bank_check.id_check = View_AllPreAndPaid" & _
        "Receive_product_ap_Dtl.id_check WHERE (View_AllPreAndPaidReceive_product_ap_Dtl." & _
        "date_prepare = @Date1)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date1", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        '
        'dAView_AllPreAndPaidReceive_product_ap_Dtl
        '
        Me.dAView_AllPreAndPaidReceive_product_ap_Dtl.MissingSchemaAction = System.Data.MissingSchemaAction.Ignore
        Me.dAView_AllPreAndPaidReceive_product_ap_Dtl.SelectCommand = Me.SqlSelectCommand2
        Me.dAView_AllPreAndPaidReceive_product_ap_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_AllPreAndPaidReceive_product_ap_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("DateTransaction", "DateTransaction"), New System.Data.Common.DataColumnMapping("sumoriginalamount", "sumoriginalamount"), New System.Data.Common.DataColumnMapping("sumpayment", "sumpayment"), New System.Data.Common.DataColumnMapping("vendorrefno", "vendorrefno"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT View_AllPreAndPaidService_out_purchase.amount, View_AllPreAndPaidService_o" & _
        "ut_purchase.Due_Date, View_AllPreAndPaidService_out_purchase.DateTransaction, Vi" & _
        "ew_AllPreAndPaidService_out_purchase.amount - View_AllPreAndPaidService_out_purc" & _
        "hase.sumpayment AS sumoriginalamount, View_AllPreAndPaidService_out_purchase.sum" & _
        "payment, View_AllPreAndPaidService_out_purchase.vendorrefno, View_AllPreAndPaidS" & _
        "ervice_out_purchase.ID_AP_payment, View_AllPreAndPaidService_out_purchase.Id_AP_" & _
        "bill_dtl_dtl, View_AllPreAndPaidService_out_purchase.ID_Inv_Receive_product_Ap_D" & _
        "tl, View_AllPreAndPaidService_out_purchase.id_service_center, View_AllPreAndPaid" & _
        "Service_out_purchase.radif, View_AllPreAndPaidService_out_purchase.amount_pay, V" & _
        "iew_AllPreAndPaidService_out_purchase.remark, View_AllPreAndPaidService_out_purc" & _
        "hase.date_prepare AS preparedate, View_AllPreAndPaidService_out_purchase.id_chec" & _
        "k, View_AllPreAndPaidService_out_purchase.id_vendor_credit_head, View_AllPreAndP" & _
        "aidService_out_purchase.cod_vendor, inv_vendor.desc_vendor, bas_banks.name_bank," & _
        " bank_check.no_of_check, bank_check.amount_check, bank_check.date_of_check FROM " & _
        "bas_banks INNER JOIN bank_check ON bas_banks.id_bank = bank_check.id_bank RIGHT " & _
        "OUTER JOIN View_AllPreAndPaidService_out_purchase INNER JOIN inv_vendor ON View_" & _
        "AllPreAndPaidService_out_purchase.cod_vendor = inv_vendor.cod_vendor ON bank_che" & _
        "ck.cod_vendor = inv_vendor.cod_vendor AND bank_check.id_check = View_AllPreAndPa" & _
        "idService_out_purchase.id_check WHERE (View_AllPreAndPaidService_out_purchase.da" & _
        "te_prepare = @date1)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date1", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        '
        'DaView_AllPreAndPaidService_out_purchase
        '
        Me.DaView_AllPreAndPaidService_out_purchase.MissingSchemaAction = System.Data.MissingSchemaAction.Ignore
        Me.DaView_AllPreAndPaidService_out_purchase.SelectCommand = Me.SqlSelectCommand3
        Me.DaView_AllPreAndPaidService_out_purchase.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_AllPreAndPaidService_out_purchase", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("DateTransaction", "DateTransaction"), New System.Data.Common.DataColumnMapping("sumoriginalamount", "sumoriginalamount"), New System.Data.Common.DataColumnMapping("sumpayment", "sumpayment"), New System.Data.Common.DataColumnMapping("vendorrefno", "vendorrefno"), New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor")})})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnEmail)
        Me.Panel4.Controls.Add(Me.BtnJPrint)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(894, 64)
        Me.Panel4.TabIndex = 209
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 62)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "Vendor Bills Prepared  For Payment Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(834, 3)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(826, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(778, 34)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(730, 34)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(674, 37)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(618, 37)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(786, 3)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(730, 3)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(682, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(626, 3)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(180, 91)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GrdDetail
        Me.GridEXPrintDocument1.PageHeaderCenter = "Vendor Bills Prepared  For Payment Report"
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT View_AllVendorPaid.date_prepare, View_AllVendorPaid.ID_AP_payment, View_Al" & _
        "lVendorPaid.id_vendor_credit_head, View_AllVendorPaid.cod_vendor, View_AllVendor" & _
        "Paid.desc_vendor, View_AllVendorPaid.amount_pay, View_AllVendorPaid.id_check, GL" & _
        "_vendor_credit.date_credit, GL_vendor_credit.amount_credit, GL_vendor_credit.ref" & _
        "_no, GL_vendor_credit.due_date FROM GL_vendor_credit_head INNER JOIN GL_vendor_c" & _
        "redit ON GL_vendor_credit_head.id_vendor_credit_head = GL_vendor_credit.id_vendo" & _
        "r_credit_head INNER JOIN View_AllVendorPaid ON GL_vendor_credit_head.id_vendor_c" & _
        "redit_head = View_AllVendorPaid.id_vendor_credit_head WHERE (View_AllVendorPaid." & _
        "date_prepare = @date1)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date1", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        '
        'DaView_AllVendorPaid
        '
        Me.DaView_AllVendorPaid.SelectCommand = Me.SqlSelectCommand4
        Me.DaView_AllVendorPaid.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_AllVendorPaid", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("id_check", "id_check")})})
        '
        'FrmPrintAllApPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(894, 550)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ButOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbDate)
        Me.Controls.Add(Me.GrdDetail)
        Me.Name = "FrmPrintAllApPayment"
        Me.Text = "Vendor Bills Prepared  For Payment Report"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPrintAllApPayment1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public flag As Boolean = True
    Dim x As Integer = 0
    Public dateshow As String = ""
    Private Sub FrmPrintAllApPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        If flag Then
            Call FillDate()
        Else
            If dateshow.Trim <> "" Then
                CmbDate.Text = dateshow
            End If

            ButOk.Enabled = False
            CmbDate.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButOk.Click
        Try
            Call fillall()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Me.GrdDetail.ShowFieldChooser(Me)
    End Sub
    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim FileName As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = "reportApPAyment.CSV"
        Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdDetail)
    End Sub
    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Public Sub FillDate()
        Cnn.ConnectionString = PConnectionString
        DsFrmPrintAllApPayment1.Clear()
        DaAllDate.Fill(DsFrmPrintAllApPayment1)
    End Sub
    Public Sub fillall(Optional ByVal thisdate As String = "")
        Try
            DsFrmPrintAllApPayment1.View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.Clear()
            DsFrmPrintAllApPayment1.View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.Clear()
            DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.SelectCommand.Parameters(0).Value = IIf(thisdate.Trim = "", CmbDate.Text, thisdate)
            DaView_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl.Fill(DsFrmPrintAllApPayment1.View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl)
            dAView_AllPreAndPaidReceive_product_ap_Dtl.SelectCommand.Parameters(0).Value = IIf(thisdate.Trim = "", CmbDate.Text, thisdate)
            dAView_AllPreAndPaidReceive_product_ap_Dtl.Fill(DsFrmPrintAllApPayment1.View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl)
            DaView_AllPreAndPaidService_out_purchase.SelectCommand.Parameters(0).Value = IIf(thisdate.Trim = "", CmbDate.Text, thisdate)
            DaView_AllPreAndPaidService_out_purchase.Fill(DsFrmPrintAllApPayment1.View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl)
            'DaView_AllVendorPaid.SelectCommand.Parameters(0).Value = CmbDate.Text
            'DaView_AllVendorPaid.Fill(DsFrmPrintAllApPayment1.View_AllVendorPaid)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("priv")
    End Sub

    Private Sub pprint(ByVal type As String)

        Dim rpt As New RptPrintAllApPayment
        Dim prn As New FrmRepView

        rpt.SetParameterValue("Parstorename", PubCompanyName & "")
        ' rpt.SetParameterValue("Parstorno", PubStoreName & "")

        rpt.SetParameterValue("pardate", Format(Now(), PubDateFormat))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", "Paid Bills Report")
        rpt.SetDataSource(DsFrmPrintAllApPayment1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception
                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select

        'Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("print")
    End Sub

    Private Sub GridEXPrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles GridEXPrintDocument1.PrintPage
        x = x + 1
        GridEXPrintDocument1.PageFooterRight = x
    End Sub
    Private Sub GridEXPrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GridEXPrintDocument1.EndPrint
        x = 0
    End Sub

End Class
