Imports CommonClass
Public Class ItemsConvert
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
    Friend WithEvents txtPath As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents CnnExcelFile As System.Data.Odbc.OdbcConnection
    Friend WithEvents CnnSql As System.Data.SqlClient.SqlConnection
    Friend WithEvents daCusTrTabMain As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Friend WithEvents CnnXlsInConnection As System.Data.Odbc.OdbcConnection
    Friend WithEvents dsItems1 As Convert.dsItems
    Friend WithEvents daServiceCenterHead As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daArBalance_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents daServiceCenterDtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daGlPaymentAr As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daInvTabBrand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daBrand_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents daInvTabLine As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabStyle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daStyle_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents daLine_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand2 As System.Data.Odbc.OdbcCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabPublic As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daItemListing_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand3 As System.Data.Odbc.OdbcCommand
    Friend WithEvents daInvVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabVendorClass As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabVendorType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendor_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand4 As System.Data.Odbc.OdbcCommand
    Friend WithEvents daZipCode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvItemQuickRefrence As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabTypeItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvItemVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvItemCostTransaction As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvPriceCode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daInvDiscountItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPriceCode_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand5 As System.Data.Odbc.OdbcCommand
    Friend WithEvents SqlSelectCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daITQty_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand6 As System.Data.Odbc.OdbcCommand
    Friend WithEvents daService_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand7 As System.Data.Odbc.OdbcCommand
    Friend WithEvents daInvTabLaborService As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabLaborServicePrice As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabServiceType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daGlPaymentDeposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cmdpublic As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvTabItemWarehouse As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPath = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnConvert = New System.Windows.Forms.Button
        Me.CnnExcelFile = New System.Data.Odbc.OdbcConnection
        Me.CnnSql = New System.Data.SqlClient.SqlConnection
        Me.daCusTrTabMain = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.lblWait = New System.Windows.Forms.Label
        Me.daArBalance_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.CnnXlsInConnection = New System.Data.Odbc.OdbcConnection
        Me.dsItems1 = New Convert.dsItems
        Me.daServiceCenterHead = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.daServiceCenterDtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daGlPaymentAr = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabBrand = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.daBrand_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.daInvTabLine = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabStyle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.daStyle_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand1 = New System.Data.Odbc.OdbcCommand
        Me.daLine_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand2 = New System.Data.Odbc.OdbcCommand
        Me.daInvTabPublic = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.daItemListing_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand3 = New System.Data.Odbc.OdbcCommand
        Me.daInvVendor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabVendorClass = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabVendorType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand12 = New System.Data.SqlClient.SqlCommand
        Me.daVendor_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand4 = New System.Data.Odbc.OdbcCommand
        Me.daZipCode = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.daInvItemQuickRefrence = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand13 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand13 = New System.Data.SqlClient.SqlCommand
        Me.daInvItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand13 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand14 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabTypeItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand15 = New System.Data.SqlClient.SqlCommand
        Me.daInvItemVendor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand17 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand18 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand17 = New System.Data.SqlClient.SqlCommand
        Me.daInvItemCostTransaction = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand17 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand18 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand19 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand18 = New System.Data.SqlClient.SqlCommand
        Me.daInvPriceCode = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand18 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand19 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand20 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand19 = New System.Data.SqlClient.SqlCommand
        Me.daInvDiscountItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand19 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand20 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand21 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand20 = New System.Data.SqlClient.SqlCommand
        Me.daPriceCode_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand5 = New System.Data.Odbc.OdbcCommand
        Me.daITQty_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand6 = New System.Data.Odbc.OdbcCommand
        Me.daService_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand7 = New System.Data.Odbc.OdbcCommand
        Me.daInvTabLaborService = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand20 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand21 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand22 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand21 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabLaborServicePrice = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand21 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand22 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand23 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand22 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabServiceType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand24 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand25 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand23 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand23 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand22 = New System.Data.SqlClient.SqlCommand
        Me.daGlPaymentDeposit = New System.Data.SqlClient.SqlDataAdapter
        Me.Cmdpublic = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daInvTabItemWarehouse = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.dsItems1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtPath.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtPath.ButtonFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
        Me.txtPath.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.Location = New System.Drawing.Point(104, 15)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPath.Size = New System.Drawing.Size(456, 25)
        Me.txtPath.TabIndex = 215
        Me.txtPath.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 24)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Path :"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(8, 56)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(56, 24)
        Me.btnConvert.TabIndex = 217
        Me.btnConvert.Text = "Convert"
        '
        'CnnSql
        '
        Me.CnnSql.ConnectionString = "workstation id=ARMANDEHSERVER;packet size=4096;user id=sa;data source=""."";persist" & _
        " security info=False;initial catalog=TireMate_05"
        '
        'daCusTrTabMain
        '
        Me.daCusTrTabMain.DeleteCommand = Me.SqlDeleteCommand7
        Me.daCusTrTabMain.InsertCommand = Me.SqlInsertCommand7
        Me.daCusTrTabMain.SelectCommand = Me.SqlSelectCommand7
        Me.daCusTrTabMain.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        Me.daCusTrTabMain.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM cust_trtab_main WHERE (cod_customer = @Original_cod_customer) AND (AR" & _
        "_accept_check = @Original_AR_accept_check OR @Original_AR_accept_check IS NULL A" & _
        "ND AR_accept_check IS NULL) AND (AR_charge = @Original_AR_charge OR @Original_AR" & _
        "_charge IS NULL AND AR_charge IS NULL) AND (AR_credit_hold = @Original_AR_credit" & _
        "_hold OR @Original_AR_credit_hold IS NULL AND AR_credit_hold IS NULL) AND (AR_fi" & _
        "nance_charge = @Original_AR_finance_charge OR @Original_AR_finance_charge IS NUL" & _
        "L AND AR_finance_charge IS NULL) AND (AR_require_PO = @Original_AR_require_PO OR" & _
        " @Original_AR_require_PO IS NULL AND AR_require_PO IS NULL) AND (AR_send_copy = " & _
        "@Original_AR_send_copy OR @Original_AR_send_copy IS NULL AND AR_send_copy IS NUL" & _
        "L) AND (AR_statement = @Original_AR_statement OR @Original_AR_statement IS NULL " & _
        "AND AR_statement IS NULL) AND (AR_term = @Original_AR_term OR @Original_AR_term " & _
        "IS NULL AND AR_term IS NULL) AND (DriverLicense = @Original_DriverLicense OR @Or" & _
        "iginal_DriverLicense IS NULL AND DriverLicense IS NULL) AND (Taxable = @Original" & _
        "_Taxable OR @Original_Taxable IS NULL AND Taxable IS NULL) AND (address = @Origi" & _
        "nal_address OR @Original_address IS NULL AND address IS NULL) AND (cod_class = @" & _
        "Original_cod_class OR @Original_cod_class IS NULL AND cod_class IS NULL) AND (co" & _
        "d_company = @Original_cod_company OR @Original_cod_company IS NULL AND cod_compa" & _
        "ny IS NULL) AND (cod_price = @Original_cod_price OR @Original_cod_price IS NULL " & _
        "AND cod_price IS NULL) AND (cod_sales_rep = @Original_cod_sales_rep OR @Original" & _
        "_cod_sales_rep IS NULL AND cod_sales_rep IS NULL) AND (cod_sales_tax = @Original" & _
        "_cod_sales_tax OR @Original_cod_sales_tax IS NULL AND cod_sales_tax IS NULL) AND" & _
        " (cod_source = @Original_cod_source OR @Original_cod_source IS NULL AND cod_sour" & _
        "ce IS NULL) AND (cod_territory = @Original_cod_territory OR @Original_cod_territ" & _
        "ory IS NULL AND cod_territory IS NULL) AND (cod_type = @Original_cod_type OR @Or" & _
        "iginal_cod_type IS NULL AND cod_type IS NULL) AND (credit_card_no = @Original_cr" & _
        "edit_card_no OR @Original_credit_card_no IS NULL AND credit_card_no IS NULL) AND" & _
        " (credit_limited = @Original_credit_limited OR @Original_credit_limited IS NULL " & _
        "AND credit_limited IS NULL) AND (cust_exempt_tax = @Original_cust_exempt_tax OR " & _
        "@Original_cust_exempt_tax IS NULL AND cust_exempt_tax IS NULL) AND (cust_notes =" & _
        " @Original_cust_notes OR @Original_cust_notes IS NULL AND cust_notes IS NULL) AN" & _
        "D (customer_no = @Original_customer_no OR @Original_customer_no IS NULL AND cust" & _
        "omer_no IS NULL) AND (desc_sales_report = @Original_desc_sales_report OR @Origin" & _
        "al_desc_sales_report IS NULL AND desc_sales_report IS NULL) AND (discount = @Ori" & _
        "ginal_discount OR @Original_discount IS NULL AND discount IS NULL) AND (driver_n" & _
        "ame1 = @Original_driver_name1 OR @Original_driver_name1 IS NULL AND driver_name1" & _
        " IS NULL) AND (driver_name2 = @Original_driver_name2 OR @Original_driver_name2 I" & _
        "S NULL AND driver_name2 IS NULL) AND (driver_name3 = @Original_driver_name3 OR @" & _
        "Original_driver_name3 IS NULL AND driver_name3 IS NULL) AND (driver_name4 = @Ori" & _
        "ginal_driver_name4 OR @Original_driver_name4 IS NULL AND driver_name4 IS NULL) A" & _
        "ND (email = @Original_email OR @Original_email IS NULL AND email IS NULL) AND (e" & _
        "xpiration_credit_date = @Original_expiration_credit_date OR @Original_expiration" & _
        "_credit_date IS NULL AND expiration_credit_date IS NULL) AND (extension_1 = @Ori" & _
        "ginal_extension_1 OR @Original_extension_1 IS NULL AND extension_1 IS NULL) AND " & _
        "(extension_2 = @Original_extension_2 OR @Original_extension_2 IS NULL AND extens" & _
        "ion_2 IS NULL) AND (extension_3 = @Original_extension_3 OR @Original_extension_3" & _
        " IS NULL AND extension_3 IS NULL) AND (extension_4 = @Original_extension_4 OR @O" & _
        "riginal_extension_4 IS NULL AND extension_4 IS NULL) AND (extension_5 = @Origina" & _
        "l_extension_5 OR @Original_extension_5 IS NULL AND extension_5 IS NULL) AND (f_n" & _
        "ame = @Original_f_name OR @Original_f_name IS NULL AND f_name IS NULL) AND (inac" & _
        "tive = @Original_inactive OR @Original_inactive IS NULL AND inactive IS NULL) AN" & _
        "D (l_name = @Original_l_name OR @Original_l_name IS NULL AND l_name IS NULL) AND" & _
        " (m_name = @Original_m_name OR @Original_m_name IS NULL AND m_name IS NULL) AND " & _
        "(phone_1 = @Original_phone_1 OR @Original_phone_1 IS NULL AND phone_1 IS NULL) A" & _
        "ND (phone_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AND phone_2 IS NULL" & _
        ") AND (phone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL AND phone_3 IS N" & _
        "ULL) AND (phone_4 = @Original_phone_4 OR @Original_phone_4 IS NULL AND phone_4 I" & _
        "S NULL) AND (phone_5 = @Original_phone_5 OR @Original_phone_5 IS NULL AND phone_" & _
        "5 IS NULL) AND (phone_main_1 = @Original_phone_main_1 OR @Original_phone_main_1 " & _
        "IS NULL AND phone_main_1 IS NULL) AND (phone_main_2 = @Original_phone_main_2 OR " & _
        "@Original_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (phone_main_3 = @Or" & _
        "iginal_phone_main_3 OR @Original_phone_main_3 IS NULL AND phone_main_3 IS NULL) " & _
        "AND (phone_main_4 = @Original_phone_main_4 OR @Original_phone_main_4 IS NULL AND" & _
        " phone_main_4 IS NULL) AND (phone_main_5 = @Original_phone_main_5 OR @Original_p" & _
        "hone_main_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1 = @Original_phon" & _
        "e_type_1 OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NULL) AND (phone_" & _
        "type_2 = @Original_phone_type_2 OR @Original_phone_type_2 IS NULL AND phone_type" & _
        "_2 IS NULL) AND (phone_type_3 = @Original_phone_type_3 OR @Original_phone_type_3" & _
        " IS NULL AND phone_type_3 IS NULL) AND (phone_type_4 = @Original_phone_type_4 OR" & _
        " @Original_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (phone_type_5 = @O" & _
        "riginal_phone_type_5 OR @Original_phone_type_5 IS NULL AND phone_type_5 IS NULL)" & _
        " AND (scrap_check = @Original_scrap_check OR @Original_scrap_check IS NULL AND s" & _
        "crap_check IS NULL) AND (scrap_value = @Original_scrap_value OR @Original_scrap_" & _
        "value IS NULL AND scrap_value IS NULL) AND (social_security_no = @Original_socia" & _
        "l_security_no OR @Original_social_security_no IS NULL AND social_security_no IS " & _
        "NULL) AND (user_id = @Original_user_id OR @Original_user_id IS NULL AND user_id " & _
        "IS NULL) AND (user_password = @Original_user_password OR @Original_user_password" & _
        " IS NULL AND user_password IS NULL) AND (vip_code = @Original_vip_code OR @Origi" & _
        "nal_vip_code IS NULL AND vip_code IS NULL) AND (zip = @Original_zip OR @Original" & _
        "_zip IS NULL AND zip IS NULL)"
        Me.SqlDeleteCommand7.Connection = Me.CnnSql
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_accept_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_accept_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_credit_hold", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_credit_hold", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_finance_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_finance_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_require_PO", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_require_PO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_send_copy", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_send_copy", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_statement", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_statement", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_term", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DriverLicense", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DriverLicense", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_price", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_rep", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_rep", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_card_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_card_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_limited", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_limited", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_exempt_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_exempt_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_report", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_report", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name3", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name4", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_expiration_credit_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "expiration_credit_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_value", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_value", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_id", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vip_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vip_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO cust_trtab_main(cod_customer, vip_code, cod_company, f_name, m_name, " & _
        "l_name, address, phone_1, extension_1, phone_type_1, phone_main_1, phone_2, exte" & _
        "nsion_2, phone_type_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_m" & _
        "ain_3, phone_4, extension_4, phone_type_4, phone_main_4, phone_5, extension_5, p" & _
        "hone_type_5, phone_main_5, driver_name1, driver_name2, driver_name3, driver_name" & _
        "4, DriverLicense, zip, email, cod_sales_rep, social_security_no, cust_exempt_tax" & _
        ", scrap_check, scrap_value, credit_card_no, expiration_credit_date, credit_limit" & _
        "ed, AR_charge, AR_term, cod_sales_tax, cod_price, discount, cod_type, cod_source" & _
        ", cod_class, cod_territory, desc_sales_report, user_id, user_password, AR_statem" & _
        "ent, AR_send_copy, AR_finance_charge, AR_require_PO, AR_credit_hold, AR_accept_c" & _
        "heck, cust_notes, Taxable, inactive, customer_no) VALUES (@cod_customer, @vip_co" & _
        "de, @cod_company, @f_name, @m_name, @l_name, @address, @phone_1, @extension_1, @" & _
        "phone_type_1, @phone_main_1, @phone_2, @extension_2, @phone_type_2, @phone_main_" & _
        "2, @phone_3, @extension_3, @phone_type_3, @phone_main_3, @phone_4, @extension_4," & _
        " @phone_type_4, @phone_main_4, @phone_5, @extension_5, @phone_type_5, @phone_mai" & _
        "n_5, @driver_name1, @driver_name2, @driver_name3, @driver_name4, @DriverLicense," & _
        " @zip, @email, @cod_sales_rep, @social_security_no, @cust_exempt_tax, @scrap_che" & _
        "ck, @scrap_value, @credit_card_no, @expiration_credit_date, @credit_limited, @AR" & _
        "_charge, @AR_term, @cod_sales_tax, @cod_price, @discount, @cod_type, @cod_source" & _
        ", @cod_class, @cod_territory, @desc_sales_report, @user_id, @user_password, @AR_" & _
        "statement, @AR_send_copy, @AR_finance_charge, @AR_require_PO, @AR_credit_hold, @" & _
        "AR_accept_check, @cust_notes, @Taxable, @inactive, @customer_no); SELECT cod_cus" & _
        "tomer, vip_code, cod_company, f_name, m_name, l_name, address, phone_1, extensio" & _
        "n_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_" & _
        "2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone" & _
        "_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, driver_" & _
        "name1, driver_name2, driver_name3, driver_name4, DriverLicense, zip, email, cod_" & _
        "sales_rep, social_security_no, cust_exempt_tax, scrap_check, scrap_value, credit" & _
        "_card_no, expiration_credit_date, credit_limited, AR_charge, AR_term, cod_sales_" & _
        "tax, cod_price, discount, cod_type, cod_source, cod_class, cod_territory, desc_s" & _
        "ales_report, user_id, user_password, AR_statement, AR_send_copy, AR_finance_char" & _
        "ge, AR_require_PO, AR_credit_hold, AR_accept_check, cust_notes, Taxable, inactiv" & _
        "e, customer_no FROM cust_trtab_main WHERE (cod_customer = @cod_customer)"
        Me.SqlInsertCommand7.Connection = Me.CnnSql
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DriverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.Real, 4, "cust_exempt_tax"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 10, "AR_term"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_no", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cod_customer, vip_code, cod_company, f_name, m_name, l_name, address, phon" & _
        "e_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2" & _
        ", phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, exten" & _
        "sion_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_ma" & _
        "in_5, driver_name1, driver_name2, driver_name3, driver_name4, DriverLicense, zip" & _
        ", email, cod_sales_rep, social_security_no, cust_exempt_tax, scrap_check, scrap_" & _
        "value, credit_card_no, expiration_credit_date, credit_limited, AR_charge, AR_ter" & _
        "m, cod_sales_tax, cod_price, discount, cod_type, cod_source, cod_class, cod_terr" & _
        "itory, desc_sales_report, user_id, user_password, AR_statement, AR_send_copy, AR" & _
        "_finance_charge, AR_require_PO, AR_credit_hold, AR_accept_check, cust_notes, Tax" & _
        "able, inactive, customer_no FROM cust_trtab_main"
        Me.SqlSelectCommand7.Connection = Me.CnnSql
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE cust_trtab_main SET cod_customer = @cod_customer, vip_code = @vip_code, co" & _
        "d_company = @cod_company, f_name = @f_name, m_name = @m_name, l_name = @l_name, " & _
        "address = @address, phone_1 = @phone_1, extension_1 = @extension_1, phone_type_1" & _
        " = @phone_type_1, phone_main_1 = @phone_main_1, phone_2 = @phone_2, extension_2 " & _
        "= @extension_2, phone_type_2 = @phone_type_2, phone_main_2 = @phone_main_2, phon" & _
        "e_3 = @phone_3, extension_3 = @extension_3, phone_type_3 = @phone_type_3, phone_" & _
        "main_3 = @phone_main_3, phone_4 = @phone_4, extension_4 = @extension_4, phone_ty" & _
        "pe_4 = @phone_type_4, phone_main_4 = @phone_main_4, phone_5 = @phone_5, extensio" & _
        "n_5 = @extension_5, phone_type_5 = @phone_type_5, phone_main_5 = @phone_main_5, " & _
        "driver_name1 = @driver_name1, driver_name2 = @driver_name2, driver_name3 = @driv" & _
        "er_name3, driver_name4 = @driver_name4, DriverLicense = @DriverLicense, zip = @z" & _
        "ip, email = @email, cod_sales_rep = @cod_sales_rep, social_security_no = @social" & _
        "_security_no, cust_exempt_tax = @cust_exempt_tax, scrap_check = @scrap_check, sc" & _
        "rap_value = @scrap_value, credit_card_no = @credit_card_no, expiration_credit_da" & _
        "te = @expiration_credit_date, credit_limited = @credit_limited, AR_charge = @AR_" & _
        "charge, AR_term = @AR_term, cod_sales_tax = @cod_sales_tax, cod_price = @cod_pri" & _
        "ce, discount = @discount, cod_type = @cod_type, cod_source = @cod_source, cod_cl" & _
        "ass = @cod_class, cod_territory = @cod_territory, desc_sales_report = @desc_sale" & _
        "s_report, user_id = @user_id, user_password = @user_password, AR_statement = @AR" & _
        "_statement, AR_send_copy = @AR_send_copy, AR_finance_charge = @AR_finance_charge" & _
        ", AR_require_PO = @AR_require_PO, AR_credit_hold = @AR_credit_hold, AR_accept_ch" & _
        "eck = @AR_accept_check, cust_notes = @cust_notes, Taxable = @Taxable, inactive =" & _
        " @inactive, customer_no = @customer_no WHERE (cod_customer = @Original_cod_custo" & _
        "mer) AND (AR_accept_check = @Original_AR_accept_check OR @Original_AR_accept_che" & _
        "ck IS NULL AND AR_accept_check IS NULL) AND (AR_charge = @Original_AR_charge OR " & _
        "@Original_AR_charge IS NULL AND AR_charge IS NULL) AND (AR_credit_hold = @Origin" & _
        "al_AR_credit_hold OR @Original_AR_credit_hold IS NULL AND AR_credit_hold IS NULL" & _
        ") AND (AR_finance_charge = @Original_AR_finance_charge OR @Original_AR_finance_c" & _
        "harge IS NULL AND AR_finance_charge IS NULL) AND (AR_require_PO = @Original_AR_r" & _
        "equire_PO OR @Original_AR_require_PO IS NULL AND AR_require_PO IS NULL) AND (AR_" & _
        "send_copy = @Original_AR_send_copy OR @Original_AR_send_copy IS NULL AND AR_send" & _
        "_copy IS NULL) AND (AR_statement = @Original_AR_statement OR @Original_AR_statem" & _
        "ent IS NULL AND AR_statement IS NULL) AND (AR_term = @Original_AR_term OR @Origi" & _
        "nal_AR_term IS NULL AND AR_term IS NULL) AND (DriverLicense = @Original_DriverLi" & _
        "cense OR @Original_DriverLicense IS NULL AND DriverLicense IS NULL) AND (Taxable" & _
        " = @Original_Taxable OR @Original_Taxable IS NULL AND Taxable IS NULL) AND (addr" & _
        "ess = @Original_address OR @Original_address IS NULL AND address IS NULL) AND (c" & _
        "od_class = @Original_cod_class OR @Original_cod_class IS NULL AND cod_class IS N" & _
        "ULL) AND (cod_company = @Original_cod_company OR @Original_cod_company IS NULL A" & _
        "ND cod_company IS NULL) AND (cod_price = @Original_cod_price OR @Original_cod_pr" & _
        "ice IS NULL AND cod_price IS NULL) AND (cod_sales_rep = @Original_cod_sales_rep " & _
        "OR @Original_cod_sales_rep IS NULL AND cod_sales_rep IS NULL) AND (cod_sales_tax" & _
        " = @Original_cod_sales_tax OR @Original_cod_sales_tax IS NULL AND cod_sales_tax " & _
        "IS NULL) AND (cod_source = @Original_cod_source OR @Original_cod_source IS NULL " & _
        "AND cod_source IS NULL) AND (cod_territory = @Original_cod_territory OR @Origina" & _
        "l_cod_territory IS NULL AND cod_territory IS NULL) AND (cod_type = @Original_cod" & _
        "_type OR @Original_cod_type IS NULL AND cod_type IS NULL) AND (credit_card_no = " & _
        "@Original_credit_card_no OR @Original_credit_card_no IS NULL AND credit_card_no " & _
        "IS NULL) AND (credit_limited = @Original_credit_limited OR @Original_credit_limi" & _
        "ted IS NULL AND credit_limited IS NULL) AND (cust_exempt_tax = @Original_cust_ex" & _
        "empt_tax OR @Original_cust_exempt_tax IS NULL AND cust_exempt_tax IS NULL) AND (" & _
        "cust_notes = @Original_cust_notes OR @Original_cust_notes IS NULL AND cust_notes" & _
        " IS NULL) AND (customer_no = @Original_customer_no OR @Original_customer_no IS N" & _
        "ULL AND customer_no IS NULL) AND (desc_sales_report = @Original_desc_sales_repor" & _
        "t OR @Original_desc_sales_report IS NULL AND desc_sales_report IS NULL) AND (dis" & _
        "count = @Original_discount OR @Original_discount IS NULL AND discount IS NULL) A" & _
        "ND (driver_name1 = @Original_driver_name1 OR @Original_driver_name1 IS NULL AND " & _
        "driver_name1 IS NULL) AND (driver_name2 = @Original_driver_name2 OR @Original_dr" & _
        "iver_name2 IS NULL AND driver_name2 IS NULL) AND (driver_name3 = @Original_drive" & _
        "r_name3 OR @Original_driver_name3 IS NULL AND driver_name3 IS NULL) AND (driver_" & _
        "name4 = @Original_driver_name4 OR @Original_driver_name4 IS NULL AND driver_name" & _
        "4 IS NULL) AND (email = @Original_email OR @Original_email IS NULL AND email IS " & _
        "NULL) AND (expiration_credit_date = @Original_expiration_credit_date OR @Origina" & _
        "l_expiration_credit_date IS NULL AND expiration_credit_date IS NULL) AND (extens" & _
        "ion_1 = @Original_extension_1 OR @Original_extension_1 IS NULL AND extension_1 I" & _
        "S NULL) AND (extension_2 = @Original_extension_2 OR @Original_extension_2 IS NUL" & _
        "L AND extension_2 IS NULL) AND (extension_3 = @Original_extension_3 OR @Original" & _
        "_extension_3 IS NULL AND extension_3 IS NULL) AND (extension_4 = @Original_exten" & _
        "sion_4 OR @Original_extension_4 IS NULL AND extension_4 IS NULL) AND (extension_" & _
        "5 = @Original_extension_5 OR @Original_extension_5 IS NULL AND extension_5 IS NU" & _
        "LL) AND (f_name = @Original_f_name OR @Original_f_name IS NULL AND f_name IS NUL" & _
        "L) AND (inactive = @Original_inactive OR @Original_inactive IS NULL AND inactive" & _
        " IS NULL) AND (l_name = @Original_l_name OR @Original_l_name IS NULL AND l_name " & _
        "IS NULL) AND (m_name = @Original_m_name OR @Original_m_name IS NULL AND m_name I" & _
        "S NULL) AND (phone_1 = @Original_phone_1 OR @Original_phone_1 IS NULL AND phone_" & _
        "1 IS NULL) AND (phone_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AND pho" & _
        "ne_2 IS NULL) AND (phone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL AND " & _
        "phone_3 IS NULL) AND (phone_4 = @Original_phone_4 OR @Original_phone_4 IS NULL A" & _
        "ND phone_4 IS NULL) AND (phone_5 = @Original_phone_5 OR @Original_phone_5 IS NUL" & _
        "L AND phone_5 IS NULL) AND (phone_main_1 = @Original_phone_main_1 OR @Original_p" & _
        "hone_main_1 IS NULL AND phone_main_1 IS NULL) AND (phone_main_2 = @Original_phon" & _
        "e_main_2 OR @Original_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (phone_" & _
        "main_3 = @Original_phone_main_3 OR @Original_phone_main_3 IS NULL AND phone_main" & _
        "_3 IS NULL) AND (phone_main_4 = @Original_phone_main_4 OR @Original_phone_main_4" & _
        " IS NULL AND phone_main_4 IS NULL) AND (phone_main_5 = @Original_phone_main_5 OR" & _
        " @Original_phone_main_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1 = @O" & _
        "riginal_phone_type_1 OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NULL)" & _
        " AND (phone_type_2 = @Original_phone_type_2 OR @Original_phone_type_2 IS NULL AN" & _
        "D phone_type_2 IS NULL) AND (phone_type_3 = @Original_phone_type_3 OR @Original_" & _
        "phone_type_3 IS NULL AND phone_type_3 IS NULL) AND (phone_type_4 = @Original_pho" & _
        "ne_type_4 OR @Original_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (phone" & _
        "_type_5 = @Original_phone_type_5 OR @Original_phone_type_5 IS NULL AND phone_typ" & _
        "e_5 IS NULL) AND (scrap_check = @Original_scrap_check OR @Original_scrap_check I" & _
        "S NULL AND scrap_check IS NULL) AND (scrap_value = @Original_scrap_value OR @Ori" & _
        "ginal_scrap_value IS NULL AND scrap_value IS NULL) AND (social_security_no = @Or" & _
        "iginal_social_security_no OR @Original_social_security_no IS NULL AND social_sec" & _
        "urity_no IS NULL) AND (user_id = @Original_user_id OR @Original_user_id IS NULL " & _
        "AND user_id IS NULL) AND (user_password = @Original_user_password OR @Original_u" & _
        "ser_password IS NULL AND user_password IS NULL) AND (vip_code = @Original_vip_co" & _
        "de OR @Original_vip_code IS NULL AND vip_code IS NULL) AND (zip = @Original_zip " & _
        "OR @Original_zip IS NULL AND zip IS NULL); SELECT cod_customer, vip_code, cod_co" & _
        "mpany, f_name, m_name, l_name, address, phone_1, extension_1, phone_type_1, phon" & _
        "e_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_3, extension_3" & _
        ", phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, phone_main_4, " & _
        "phone_5, extension_5, phone_type_5, phone_main_5, driver_name1, driver_name2, dr" & _
        "iver_name3, driver_name4, DriverLicense, zip, email, cod_sales_rep, social_secur" & _
        "ity_no, cust_exempt_tax, scrap_check, scrap_value, credit_card_no, expiration_cr" & _
        "edit_date, credit_limited, AR_charge, AR_term, cod_sales_tax, cod_price, discoun" & _
        "t, cod_type, cod_source, cod_class, cod_territory, desc_sales_report, user_id, u" & _
        "ser_password, AR_statement, AR_send_copy, AR_finance_charge, AR_require_PO, AR_c" & _
        "redit_hold, AR_accept_check, cust_notes, Taxable, inactive, customer_no FROM cus" & _
        "t_trtab_main WHERE (cod_customer = @cod_customer)"
        Me.SqlUpdateCommand7.Connection = Me.CnnSql
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DriverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.Real, 4, "cust_exempt_tax"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 10, "AR_term"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_no", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_accept_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_accept_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_credit_hold", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_credit_hold", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_finance_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_finance_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_require_PO", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_require_PO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_send_copy", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_send_copy", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_statement", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_statement", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_term", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DriverLicense", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DriverLicense", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_price", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_rep", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_rep", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_card_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_card_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_limited", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_limited", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_exempt_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_exempt_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_report", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_report", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name3", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name4", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_expiration_credit_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "expiration_credit_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_value", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_value", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_id", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vip_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vip_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'lblWait
        '
        Me.lblWait.BackColor = System.Drawing.Color.Transparent
        Me.lblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Red
        Me.lblWait.Location = New System.Drawing.Point(72, 62)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(104, 16)
        Me.lblWait.TabIndex = 219
        Me.lblWait.Text = "Please wait ....."
        Me.lblWait.Visible = False
        '
        'daArBalance_xls
        '
        Me.daArBalance_xls.SelectCommand = Me.OdbcSelectCommand2
        Me.daArBalance_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArBalance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CUSTOMER", "CUSTOMER"), New System.Data.Common.DataColumnMapping("Customer Name", "Customer Name"), New System.Data.Common.DataColumnMapping("Net Due", "Net Due"), New System.Data.Common.DataColumnMapping("DUE DATE", "DUE DATE")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.Connection = Me.CnnExcelFile
        '
        'CnnXlsInConnection
        '
        Me.CnnXlsInConnection.ConnectionString = "MaxBufferSize=2048;FIL=excel 8.0;DSN=MyCnnExcel;PageTimeout=5;DefaultDir=C:\Docum" & _
        "ents and Settings\fe\Desktop\Ar\convert data;DBQ=C:\Documents and Settings\fe\De" & _
        "sktop\Ar\convert data\BRANDS Duncan Tire.xls;DriverId=790"
        '
        'dsItems1
        '
        Me.dsItems1.DataSetName = "dsItems"
        Me.dsItems1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'daServiceCenterHead
        '
        Me.daServiceCenterHead.DeleteCommand = Me.SqlDeleteCommand9
        Me.daServiceCenterHead.InsertCommand = Me.SqlInsertCommand9
        Me.daServiceCenterHead.SelectCommand = Me.SqlSelectCommand9
        Me.daServiceCenterHead.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        Me.daServiceCenterHead.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = "DELETE FROM service_center_head WHERE (id_service_center = @Original_id_service_c" & _
        "enter) AND (Total = @Original_Total OR @Original_Total IS NULL AND Total IS NULL" & _
        ") AND (add_user = @Original_add_user OR @Original_add_user IS NULL AND add_user " & _
        "IS NULL) AND (chg_user = @Original_chg_user OR @Original_chg_user IS NULL AND ch" & _
        "g_user IS NULL) AND (cod_customer = @Original_cod_customer OR @Original_cod_cust" & _
        "omer IS NULL AND cod_customer IS NULL) AND (cust_comment = @Original_cust_commen" & _
        "t OR @Original_cust_comment IS NULL AND cust_comment IS NULL) AND (date_refer = " & _
        "@Original_date_refer OR @Original_date_refer IS NULL AND date_refer IS NULL) AND" & _
        " (discount = @Original_discount OR @Original_discount IS NULL AND discount IS NU" & _
        "LL) AND (house_comment = @Original_house_comment OR @Original_house_comment IS N" & _
        "ULL AND house_comment IS NULL) AND (id_GL_journal = @Original_id_GL_journal OR @" & _
        "Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_service_center" & _
        "_before = @Original_id_service_center_before OR @Original_id_service_center_befo" & _
        "re IS NULL AND id_service_center_before IS NULL) AND (id_vehicle = @Original_id_" & _
        "vehicle OR @Original_id_vehicle IS NULL AND id_vehicle IS NULL) AND (po_no = @Or" & _
        "iginal_po_no OR @Original_po_no IS NULL AND po_no IS NULL) AND (tax = @Original_" & _
        "tax OR @Original_tax IS NULL AND tax IS NULL) AND (type_of_form = @Original_type" & _
        "_of_form OR @Original_type_of_form IS NULL AND type_of_form IS NULL)"
        Me.SqlDeleteCommand9.Connection = Me.CnnSql
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = "INSERT INTO service_center_head(id_service_center, type_of_form, cod_customer, id" & _
        "_vehicle, date_refer, discount, tax, house_comment, cust_comment, add_user, chg_" & _
        "user, po_no, id_service_center_before, id_GL_journal, Total) VALUES (@id_service" & _
        "_center, @type_of_form, @cod_customer, @id_vehicle, @date_refer, @discount, @tax" & _
        ", @house_comment, @cust_comment, @add_user, @chg_user, @po_no, @id_service_cente" & _
        "r_before, @id_GL_journal, @Total); SELECT id_service_center, type_of_form, cod_c" & _
        "ustomer, id_vehicle, date_refer, discount, tax, house_comment, cust_comment, add" & _
        "_user, chg_user, po_no, id_service_center_before, id_GL_journal, Total FROM serv" & _
        "ice_center_head WHERE (id_service_center = @id_service_center)"
        Me.SqlInsertCommand9.Connection = Me.CnnSql
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, dis" & _
        "count, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_c" & _
        "enter_before, id_GL_journal, Total FROM service_center_head"
        Me.SqlSelectCommand9.Connection = Me.CnnSql
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = "UPDATE service_center_head SET id_service_center = @id_service_center, type_of_fo" & _
        "rm = @type_of_form, cod_customer = @cod_customer, id_vehicle = @id_vehicle, date" & _
        "_refer = @date_refer, discount = @discount, tax = @tax, house_comment = @house_c" & _
        "omment, cust_comment = @cust_comment, add_user = @add_user, chg_user = @chg_user" & _
        ", po_no = @po_no, id_service_center_before = @id_service_center_before, id_GL_jo" & _
        "urnal = @id_GL_journal, Total = @Total WHERE (id_service_center = @Original_id_s" & _
        "ervice_center) AND (Total = @Original_Total OR @Original_Total IS NULL AND Total" & _
        " IS NULL) AND (add_user = @Original_add_user OR @Original_add_user IS NULL AND a" & _
        "dd_user IS NULL) AND (chg_user = @Original_chg_user OR @Original_chg_user IS NUL" & _
        "L AND chg_user IS NULL) AND (cod_customer = @Original_cod_customer OR @Original_" & _
        "cod_customer IS NULL AND cod_customer IS NULL) AND (cust_comment = @Original_cus" & _
        "t_comment OR @Original_cust_comment IS NULL AND cust_comment IS NULL) AND (date_" & _
        "refer = @Original_date_refer OR @Original_date_refer IS NULL AND date_refer IS N" & _
        "ULL) AND (discount = @Original_discount OR @Original_discount IS NULL AND discou" & _
        "nt IS NULL) AND (house_comment = @Original_house_comment OR @Original_house_comm" & _
        "ent IS NULL AND house_comment IS NULL) AND (id_GL_journal = @Original_id_GL_jour" & _
        "nal OR @Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_servic" & _
        "e_center_before = @Original_id_service_center_before OR @Original_id_service_cen" & _
        "ter_before IS NULL AND id_service_center_before IS NULL) AND (id_vehicle = @Orig" & _
        "inal_id_vehicle OR @Original_id_vehicle IS NULL AND id_vehicle IS NULL) AND (po_" & _
        "no = @Original_po_no OR @Original_po_no IS NULL AND po_no IS NULL) AND (tax = @O" & _
        "riginal_tax OR @Original_tax IS NULL AND tax IS NULL) AND (type_of_form = @Origi" & _
        "nal_type_of_form OR @Original_type_of_form IS NULL AND type_of_form IS NULL); SE" & _
        "LECT id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, disc" & _
        "ount, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_ce" & _
        "nter_before, id_GL_journal, Total FROM service_center_head WHERE (id_service_cen" & _
        "ter = @id_service_center)"
        Me.SqlUpdateCommand9.Connection = Me.CnnSql
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Please select the path of Excel Files ...."
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'daServiceCenterDtl
        '
        Me.daServiceCenterDtl.DeleteCommand = Me.SqlDeleteCommand1
        Me.daServiceCenterDtl.InsertCommand = Me.SqlInsertCommand1
        Me.daServiceCenterDtl.SelectCommand = Me.SqlSelectCommand1
        Me.daServiceCenterDtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        Me.daServiceCenterDtl.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM service_center_dtl WHERE (id_service_center = @Original_id_service_ce" & _
        "nter) AND (radif = @Original_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST O" & _
        "R @Original_AVERAGE_COST IS NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE " & _
        "= @Original_COMMENT_ARTICLE OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ART" & _
        "ICLE IS NULL) AND (cod_select = @Original_cod_select OR @Original_cod_select IS " & _
        "NULL AND cod_select IS NULL) AND (cod_technician = @Original_cod_technician OR @" & _
        "Original_cod_technician IS NULL AND cod_technician IS NULL) AND (desc_radif = @O" & _
        "riginal_desc_radif OR @Original_desc_radif IS NULL AND desc_radif IS NULL) AND (" & _
        "fet = @Original_fet) AND (price = @Original_price) AND (qty = @Original_qty) AND" & _
        " (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable IS NULL) " & _
        "AND (type_select = @Original_type_select OR @Original_type_select IS NULL AND ty" & _
        "pe_select IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.CnnSql
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO service_center_dtl(id_service_center, radif, type_select, cod_select," & _
        " desc_radif, qty, price, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_" & _
        "COST) VALUES (@id_service_center, @radif, @type_select, @cod_select, @desc_radif" & _
        ", @qty, @price, @fet, @taxable, @cod_technician, @COMMENT_ARTICLE, @AVERAGE_COST" & _
        "); SELECT id_service_center, radif, type_select, cod_select, desc_radif, qty, pr" & _
        "ice, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_ce" & _
        "nter_dtl WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlInsertCommand1.Connection = Me.CnnSql
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_service_center, radif, type_select, cod_select, desc_radif, qty, price," & _
        " fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_center" & _
        "_dtl"
        Me.SqlSelectCommand1.Connection = Me.CnnSql
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE service_center_dtl SET id_service_center = @id_service_center, radif = @ra" & _
        "dif, type_select = @type_select, cod_select = @cod_select, desc_radif = @desc_ra" & _
        "dif, qty = @qty, price = @price, fet = @fet, taxable = @taxable, cod_technician " & _
        "= @cod_technician, COMMENT_ARTICLE = @COMMENT_ARTICLE, AVERAGE_COST = @AVERAGE_C" & _
        "OST WHERE (id_service_center = @Original_id_service_center) AND (radif = @Origin" & _
        "al_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST OR @Original_AVERAGE_COST I" & _
        "S NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE = @Original_COMMENT_ARTICL" & _
        "E OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ARTICLE IS NULL) AND (cod_sel" & _
        "ect = @Original_cod_select OR @Original_cod_select IS NULL AND cod_select IS NUL" & _
        "L) AND (cod_technician = @Original_cod_technician OR @Original_cod_technician IS" & _
        " NULL AND cod_technician IS NULL) AND (desc_radif = @Original_desc_radif OR @Ori" & _
        "ginal_desc_radif IS NULL AND desc_radif IS NULL) AND (fet = @Original_fet) AND (" & _
        "price = @Original_price) AND (qty = @Original_qty) AND (taxable = @Original_taxa" & _
        "ble OR @Original_taxable IS NULL AND taxable IS NULL) AND (type_select = @Origin" & _
        "al_type_select OR @Original_type_select IS NULL AND type_select IS NULL); SELECT" & _
        " id_service_center, radif, type_select, cod_select, desc_radif, qty, price, fet," & _
        " taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_center_dtl " & _
        "WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlUpdateCommand1.Connection = Me.CnnSql
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'daGlPaymentAr
        '
        Me.daGlPaymentAr.DeleteCommand = Me.SqlDeleteCommand3
        Me.daGlPaymentAr.InsertCommand = Me.SqlInsertCommand3
        Me.daGlPaymentAr.SelectCommand = Me.SqlSelectCommand3
        Me.daGlPaymentAr.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_AR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("AR_due_date", "AR_due_date"), New System.Data.Common.DataColumnMapping("Cancel_flag", "Cancel_flag")})})
        Me.daGlPaymentAr.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM GL_payment_AR WHERE (ID_payment = @Original_ID_payment) AND (AR_due_d" & _
        "ate = @Original_AR_due_date OR @Original_AR_due_date IS NULL AND AR_due_date IS " & _
        "NULL) AND (AR_terms = @Original_AR_terms OR @Original_AR_terms IS NULL AND AR_te" & _
        "rms IS NULL) AND (Cancel_flag = @Original_Cancel_flag OR @Original_Cancel_flag I" & _
        "S NULL AND Cancel_flag IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.CnnSql
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cancel_flag", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cancel_flag", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO GL_payment_AR(ID_payment, AR_terms, AR_due_date, Cancel_flag) VALUES " & _
        "(@ID_payment, @AR_terms, @AR_due_date, @Cancel_flag); SELECT ID_payment, AR_term" & _
        "s, AR_due_date, Cancel_flag FROM GL_payment_AR WHERE (ID_payment = @ID_payment)"
        Me.SqlInsertCommand3.Connection = Me.CnnSql
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_due_date", System.Data.SqlDbType.VarChar, 10, "AR_due_date"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cancel_flag", System.Data.SqlDbType.Bit, 1, "Cancel_flag"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT ID_payment, AR_terms, AR_due_date, Cancel_flag FROM GL_payment_AR"
        Me.SqlSelectCommand3.Connection = Me.CnnSql
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE GL_payment_AR SET ID_payment = @ID_payment, AR_terms = @AR_terms, AR_due_d" & _
        "ate = @AR_due_date, Cancel_flag = @Cancel_flag WHERE (ID_payment = @Original_ID_" & _
        "payment) AND (AR_due_date = @Original_AR_due_date OR @Original_AR_due_date IS NU" & _
        "LL AND AR_due_date IS NULL) AND (AR_terms = @Original_AR_terms OR @Original_AR_t" & _
        "erms IS NULL AND AR_terms IS NULL) AND (Cancel_flag = @Original_Cancel_flag OR @" & _
        "Original_Cancel_flag IS NULL AND Cancel_flag IS NULL); SELECT ID_payment, AR_ter" & _
        "ms, AR_due_date, Cancel_flag FROM GL_payment_AR WHERE (ID_payment = @ID_payment)" & _
        ""
        Me.SqlUpdateCommand3.Connection = Me.CnnSql
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_due_date", System.Data.SqlDbType.VarChar, 10, "AR_due_date"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cancel_flag", System.Data.SqlDbType.Bit, 1, "Cancel_flag"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cancel_flag", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cancel_flag", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvTabBrand
        '
        Me.daInvTabBrand.DeleteCommand = Me.SqlDeleteCommand4
        Me.daInvTabBrand.InsertCommand = Me.SqlInsertCommand4
        Me.daInvTabBrand.SelectCommand = Me.SqlSelectCommand4
        Me.daInvTabBrand.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("complete_desc_brand", "complete_desc_brand"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("tel", "tel"), New System.Data.Common.DataColumnMapping("conect_personal", "conect_personal"), New System.Data.Common.DataColumnMapping("icon_brand", "icon_brand")})})
        Me.daInvTabBrand.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM inv_tab_brand WHERE (cod_brand = @Original_cod_brand) AND (abbreviati" & _
        "on_desc_brand = @Original_abbreviation_desc_brand OR @Original_abbreviation_desc" & _
        "_brand IS NULL AND abbreviation_desc_brand IS NULL) AND (address = @Original_add" & _
        "ress OR @Original_address IS NULL AND address IS NULL) AND (complete_desc_brand " & _
        "= @Original_complete_desc_brand OR @Original_complete_desc_brand IS NULL AND com" & _
        "plete_desc_brand IS NULL) AND (conect_personal = @Original_conect_personal OR @O" & _
        "riginal_conect_personal IS NULL AND conect_personal IS NULL) AND (tel = @Origina" & _
        "l_tel OR @Original_tel IS NULL AND tel IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.CnnSql
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_brand", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abbreviation_desc_brand", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abbreviation_desc_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_complete_desc_brand", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "complete_desc_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_conect_personal", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "conect_personal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tel", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tel", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO inv_tab_brand(cod_brand, complete_desc_brand, abbreviation_desc_brand" & _
        ", address, tel, conect_personal, icon_brand) VALUES (@cod_brand, @complete_desc_" & _
        "brand, @abbreviation_desc_brand, @address, @tel, @conect_personal, @icon_brand);" & _
        " SELECT cod_brand, complete_desc_brand, abbreviation_desc_brand, address, tel, c" & _
        "onect_personal, icon_brand FROM inv_tab_brand WHERE (cod_brand = @cod_brand)"
        Me.SqlInsertCommand4.Connection = Me.CnnSql
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_brand", System.Data.SqlDbType.VarChar, 2, "cod_brand"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@complete_desc_brand", System.Data.SqlDbType.VarChar, 50, "complete_desc_brand"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abbreviation_desc_brand", System.Data.SqlDbType.VarChar, 20, "abbreviation_desc_brand"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tel", System.Data.SqlDbType.VarChar, 50, "tel"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@conect_personal", System.Data.SqlDbType.VarChar, 50, "conect_personal"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@icon_brand", System.Data.SqlDbType.VarBinary, 2147483647, "icon_brand"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_brand, complete_desc_brand, abbreviation_desc_brand, address, tel, con" & _
        "ect_personal, icon_brand FROM inv_tab_brand"
        Me.SqlSelectCommand4.Connection = Me.CnnSql
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE inv_tab_brand SET cod_brand = @cod_brand, complete_desc_brand = @complete_" & _
        "desc_brand, abbreviation_desc_brand = @abbreviation_desc_brand, address = @addre" & _
        "ss, tel = @tel, conect_personal = @conect_personal, icon_brand = @icon_brand WHE" & _
        "RE (cod_brand = @Original_cod_brand) AND (abbreviation_desc_brand = @Original_ab" & _
        "breviation_desc_brand OR @Original_abbreviation_desc_brand IS NULL AND abbreviat" & _
        "ion_desc_brand IS NULL) AND (address = @Original_address OR @Original_address IS" & _
        " NULL AND address IS NULL) AND (complete_desc_brand = @Original_complete_desc_br" & _
        "and OR @Original_complete_desc_brand IS NULL AND complete_desc_brand IS NULL) AN" & _
        "D (conect_personal = @Original_conect_personal OR @Original_conect_personal IS N" & _
        "ULL AND conect_personal IS NULL) AND (tel = @Original_tel OR @Original_tel IS NU" & _
        "LL AND tel IS NULL); SELECT cod_brand, complete_desc_brand, abbreviation_desc_br" & _
        "and, address, tel, conect_personal, icon_brand FROM inv_tab_brand WHERE (cod_bra" & _
        "nd = @cod_brand)"
        Me.SqlUpdateCommand4.Connection = Me.CnnSql
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_brand", System.Data.SqlDbType.VarChar, 2, "cod_brand"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@complete_desc_brand", System.Data.SqlDbType.VarChar, 50, "complete_desc_brand"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abbreviation_desc_brand", System.Data.SqlDbType.VarChar, 20, "abbreviation_desc_brand"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tel", System.Data.SqlDbType.VarChar, 50, "tel"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@conect_personal", System.Data.SqlDbType.VarChar, 50, "conect_personal"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@icon_brand", System.Data.SqlDbType.VarBinary, 2147483647, "icon_brand"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_brand", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abbreviation_desc_brand", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abbreviation_desc_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_complete_desc_brand", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "complete_desc_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_conect_personal", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "conect_personal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tel", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tel", System.Data.DataRowVersion.Original, Nothing))
        '
        'daBrand_xls
        '
        Me.daBrand_xls.SelectCommand = Me.OdbcSelectCommand1
        Me.daBrand_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.Connection = Me.CnnExcelFile
        '
        'daInvTabLine
        '
        Me.daInvTabLine.DeleteCommand = Me.SqlDeleteCommand5
        Me.daInvTabLine.InsertCommand = Me.SqlInsertCommand5
        Me.daInvTabLine.SelectCommand = Me.SqlSelectCommand5
        Me.daInvTabLine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("features", "features"), New System.Data.Common.DataColumnMapping("benefits", "benefits"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("limit_warranty", "limit_warranty"), New System.Data.Common.DataColumnMapping("construction", "construction"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark"), New System.Data.Common.DataColumnMapping("tread_life", "tread_life"), New System.Data.Common.DataColumnMapping("wet_traction", "wet_traction"), New System.Data.Common.DataColumnMapping("quiet_ride", "quiet_ride"), New System.Data.Common.DataColumnMapping("handling", "handling"), New System.Data.Common.DataColumnMapping("winter_traction", "winter_traction"), New System.Data.Common.DataColumnMapping("nud_traction", "nud_traction"), New System.Data.Common.DataColumnMapping("overall_score", "overall_score"), New System.Data.Common.DataColumnMapping("dry_traction", "dry_traction"), New System.Data.Common.DataColumnMapping("ride_comfort", "ride_comfort")})})
        Me.daInvTabLine.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM inv_tab_line WHERE (line = @Original_line) AND (benefits = @Original_" & _
        "benefits OR @Original_benefits IS NULL AND benefits IS NULL) AND (cod_brand = @O" & _
        "riginal_cod_brand) AND (construction = @Original_construction OR @Original_const" & _
        "ruction IS NULL AND construction IS NULL) AND (dry_traction = @Original_dry_trac" & _
        "tion OR @Original_dry_traction IS NULL AND dry_traction IS NULL) AND (features =" & _
        " @Original_features OR @Original_features IS NULL AND features IS NULL) AND (han" & _
        "dling = @Original_handling OR @Original_handling IS NULL AND handling IS NULL) A" & _
        "ND (limit_warranty = @Original_limit_warranty OR @Original_limit_warranty IS NUL" & _
        "L AND limit_warranty IS NULL) AND (nud_traction = @Original_nud_traction OR @Ori" & _
        "ginal_nud_traction IS NULL AND nud_traction IS NULL) AND (overall_score = @Origi" & _
        "nal_overall_score OR @Original_overall_score IS NULL AND overall_score IS NULL) " & _
        "AND (quiet_ride = @Original_quiet_ride OR @Original_quiet_ride IS NULL AND quiet" & _
        "_ride IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AND re" & _
        "mark IS NULL) AND (ride_comfort = @Original_ride_comfort OR @Original_ride_comfo" & _
        "rt IS NULL AND ride_comfort IS NULL) AND (style = @Original_style) AND (temperat" & _
        "ure = @Original_temperature OR @Original_temperature IS NULL AND temperature IS " & _
        "NULL) AND (traction = @Original_traction OR @Original_traction IS NULL AND tract" & _
        "ion IS NULL) AND (tread_life = @Original_tread_life OR @Original_tread_life IS N" & _
        "ULL AND tread_life IS NULL) AND (treadwear = @Original_treadwear OR @Original_tr" & _
        "eadwear IS NULL AND treadwear IS NULL) AND (wet_traction = @Original_wet_tractio" & _
        "n OR @Original_wet_traction IS NULL AND wet_traction IS NULL) AND (winter_tracti" & _
        "on = @Original_winter_traction OR @Original_winter_traction IS NULL AND winter_t" & _
        "raction IS NULL)"
        Me.SqlDeleteCommand5.Connection = Me.CnnSql
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_benefits", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "benefits", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_brand", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_construction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "construction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dry_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dry_traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_features", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "features", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_handling", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "handling", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_limit_warranty", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "limit_warranty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nud_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nud_traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_overall_score", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "overall_score", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_quiet_ride", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quiet_ride", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ride_comfort", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ride_comfort", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_style", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_temperature", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "temperature", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tread_life", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tread_life", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_treadwear", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "treadwear", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_wet_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "wet_traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_winter_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "winter_traction", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO inv_tab_line(cod_brand, style, line, features, benefits, treadwear, t" & _
        "raction, temperature, limit_warranty, construction, remark, image_remark, tread_" & _
        "life, wet_traction, quiet_ride, handling, winter_traction, nud_traction, overall" & _
        "_score, dry_traction, ride_comfort) VALUES (@cod_brand, @style, @line, @features" & _
        ", @benefits, @treadwear, @traction, @temperature, @limit_warranty, @construction" & _
        ", @remark, @image_remark, @tread_life, @wet_traction, @quiet_ride, @handling, @w" & _
        "inter_traction, @nud_traction, @overall_score, @dry_traction, @ride_comfort); SE" & _
        "LECT cod_brand, style, line, features, benefits, treadwear, traction, temperatur" & _
        "e, limit_warranty, construction, remark, image_remark, tread_life, wet_traction," & _
        " quiet_ride, handling, winter_traction, nud_traction, overall_score, dry_tractio" & _
        "n, ride_comfort FROM inv_tab_line WHERE (line = @line)"
        Me.SqlInsertCommand5.Connection = Me.CnnSql
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_brand", System.Data.SqlDbType.VarChar, 2, "cod_brand"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 2, "style"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@features", System.Data.SqlDbType.VarChar, 75, "features"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@benefits", System.Data.SqlDbType.VarChar, 75, "benefits"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@treadwear", System.Data.SqlDbType.VarChar, 3, "treadwear"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@traction", System.Data.SqlDbType.VarChar, 3, "traction"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temperature", System.Data.SqlDbType.VarChar, 3, "temperature"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@limit_warranty", System.Data.SqlDbType.VarChar, 20, "limit_warranty"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@construction", System.Data.SqlDbType.VarChar, 3, "construction"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 2147483647, "image_remark"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_life", System.Data.SqlDbType.VarChar, 3, "tread_life"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wet_traction", System.Data.SqlDbType.VarChar, 3, "wet_traction"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@quiet_ride", System.Data.SqlDbType.VarChar, 3, "quiet_ride"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@handling", System.Data.SqlDbType.VarChar, 3, "handling"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@winter_traction", System.Data.SqlDbType.VarChar, 3, "winter_traction"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nud_traction", System.Data.SqlDbType.VarChar, 3, "nud_traction"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@overall_score", System.Data.SqlDbType.VarChar, 3, "overall_score"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dry_traction", System.Data.SqlDbType.VarChar, 3, "dry_traction"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ride_comfort", System.Data.SqlDbType.VarChar, 3, "ride_comfort"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_brand, style, line, features, benefits, treadwear, traction, temperatu" & _
        "re, limit_warranty, construction, remark, image_remark, tread_life, wet_traction" & _
        ", quiet_ride, handling, winter_traction, nud_traction, overall_score, dry_tracti" & _
        "on, ride_comfort FROM inv_tab_line"
        Me.SqlSelectCommand5.Connection = Me.CnnSql
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE inv_tab_line SET cod_brand = @cod_brand, style = @style, line = @line, fea" & _
        "tures = @features, benefits = @benefits, treadwear = @treadwear, traction = @tra" & _
        "ction, temperature = @temperature, limit_warranty = @limit_warranty, constructio" & _
        "n = @construction, remark = @remark, image_remark = @image_remark, tread_life = " & _
        "@tread_life, wet_traction = @wet_traction, quiet_ride = @quiet_ride, handling = " & _
        "@handling, winter_traction = @winter_traction, nud_traction = @nud_traction, ove" & _
        "rall_score = @overall_score, dry_traction = @dry_traction, ride_comfort = @ride_" & _
        "comfort WHERE (line = @Original_line) AND (benefits = @Original_benefits OR @Ori" & _
        "ginal_benefits IS NULL AND benefits IS NULL) AND (cod_brand = @Original_cod_bran" & _
        "d) AND (construction = @Original_construction OR @Original_construction IS NULL " & _
        "AND construction IS NULL) AND (dry_traction = @Original_dry_traction OR @Origina" & _
        "l_dry_traction IS NULL AND dry_traction IS NULL) AND (features = @Original_featu" & _
        "res OR @Original_features IS NULL AND features IS NULL) AND (handling = @Origina" & _
        "l_handling OR @Original_handling IS NULL AND handling IS NULL) AND (limit_warran" & _
        "ty = @Original_limit_warranty OR @Original_limit_warranty IS NULL AND limit_warr" & _
        "anty IS NULL) AND (nud_traction = @Original_nud_traction OR @Original_nud_tracti" & _
        "on IS NULL AND nud_traction IS NULL) AND (overall_score = @Original_overall_scor" & _
        "e OR @Original_overall_score IS NULL AND overall_score IS NULL) AND (quiet_ride " & _
        "= @Original_quiet_ride OR @Original_quiet_ride IS NULL AND quiet_ride IS NULL) A" & _
        "ND (remark = @Original_remark OR @Original_remark IS NULL AND remark IS NULL) AN" & _
        "D (ride_comfort = @Original_ride_comfort OR @Original_ride_comfort IS NULL AND r" & _
        "ide_comfort IS NULL) AND (style = @Original_style) AND (temperature = @Original_" & _
        "temperature OR @Original_temperature IS NULL AND temperature IS NULL) AND (tract" & _
        "ion = @Original_traction OR @Original_traction IS NULL AND traction IS NULL) AND" & _
        " (tread_life = @Original_tread_life OR @Original_tread_life IS NULL AND tread_li" & _
        "fe IS NULL) AND (treadwear = @Original_treadwear OR @Original_treadwear IS NULL " & _
        "AND treadwear IS NULL) AND (wet_traction = @Original_wet_traction OR @Original_w" & _
        "et_traction IS NULL AND wet_traction IS NULL) AND (winter_traction = @Original_w" & _
        "inter_traction OR @Original_winter_traction IS NULL AND winter_traction IS NULL)" & _
        "; SELECT cod_brand, style, line, features, benefits, treadwear, traction, temper" & _
        "ature, limit_warranty, construction, remark, image_remark, tread_life, wet_tract" & _
        "ion, quiet_ride, handling, winter_traction, nud_traction, overall_score, dry_tra" & _
        "ction, ride_comfort FROM inv_tab_line WHERE (line = @line)"
        Me.SqlUpdateCommand5.Connection = Me.CnnSql
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_brand", System.Data.SqlDbType.VarChar, 2, "cod_brand"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 2, "style"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@features", System.Data.SqlDbType.VarChar, 75, "features"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@benefits", System.Data.SqlDbType.VarChar, 75, "benefits"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@treadwear", System.Data.SqlDbType.VarChar, 3, "treadwear"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@traction", System.Data.SqlDbType.VarChar, 3, "traction"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temperature", System.Data.SqlDbType.VarChar, 3, "temperature"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@limit_warranty", System.Data.SqlDbType.VarChar, 20, "limit_warranty"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@construction", System.Data.SqlDbType.VarChar, 3, "construction"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 2147483647, "image_remark"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_life", System.Data.SqlDbType.VarChar, 3, "tread_life"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wet_traction", System.Data.SqlDbType.VarChar, 3, "wet_traction"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@quiet_ride", System.Data.SqlDbType.VarChar, 3, "quiet_ride"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@handling", System.Data.SqlDbType.VarChar, 3, "handling"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@winter_traction", System.Data.SqlDbType.VarChar, 3, "winter_traction"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nud_traction", System.Data.SqlDbType.VarChar, 3, "nud_traction"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@overall_score", System.Data.SqlDbType.VarChar, 3, "overall_score"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dry_traction", System.Data.SqlDbType.VarChar, 3, "dry_traction"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ride_comfort", System.Data.SqlDbType.VarChar, 3, "ride_comfort"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_benefits", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "benefits", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_brand", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_brand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_construction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "construction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dry_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dry_traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_features", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "features", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_handling", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "handling", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_limit_warranty", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "limit_warranty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nud_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nud_traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_overall_score", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "overall_score", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_quiet_ride", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quiet_ride", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ride_comfort", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ride_comfort", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_style", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_temperature", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "temperature", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tread_life", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tread_life", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_treadwear", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "treadwear", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_wet_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "wet_traction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_winter_traction", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "winter_traction", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvTabStyle
        '
        Me.daInvTabStyle.DeleteCommand = Me.SqlDeleteCommand6
        Me.daInvTabStyle.InsertCommand = Me.SqlInsertCommand6
        Me.daInvTabStyle.SelectCommand = Me.SqlSelectCommand6
        Me.daInvTabStyle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        Me.daInvTabStyle.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM inv_tab_style WHERE (style = @Original_style) AND (desc_style = @Orig" & _
        "inal_desc_style OR @Original_desc_style IS NULL AND desc_style IS NULL) AND (rem" & _
        "ark = @Original_remark OR @Original_remark IS NULL AND remark IS NULL)"
        Me.SqlDeleteCommand6.Connection = Me.CnnSql
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_style", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_style", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_style", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO inv_tab_style(style, desc_style, remark, image_remark) VALUES (@style" & _
        ", @desc_style, @remark, @image_remark); SELECT style, desc_style, remark, image_" & _
        "remark FROM inv_tab_style WHERE (style = @style)"
        Me.SqlInsertCommand6.Connection = Me.CnnSql
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 2, "style"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_style", System.Data.SqlDbType.VarChar, 50, "desc_style"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 2147483647, "image_remark"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT style, desc_style, remark, image_remark FROM inv_tab_style"
        Me.SqlSelectCommand6.Connection = Me.CnnSql
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE inv_tab_style SET style = @style, desc_style = @desc_style, remark = @rema" & _
        "rk, image_remark = @image_remark WHERE (style = @Original_style) AND (desc_style" & _
        " = @Original_desc_style OR @Original_desc_style IS NULL AND desc_style IS NULL) " & _
        "AND (remark = @Original_remark OR @Original_remark IS NULL AND remark IS NULL); " & _
        "SELECT style, desc_style, remark, image_remark FROM inv_tab_style WHERE (style =" & _
        " @style)"
        Me.SqlUpdateCommand6.Connection = Me.CnnSql
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 2, "style"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_style", System.Data.SqlDbType.VarChar, 50, "desc_style"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 2147483647, "image_remark"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_style", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_style", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_style", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'daStyle_xls
        '
        Me.daStyle_xls.SelectCommand = Me.OdbcCommand1
        Me.daStyle_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand1
        '
        Me.OdbcCommand1.Connection = Me.CnnExcelFile
        '
        'daLine_xls
        '
        Me.daLine_xls.SelectCommand = Me.OdbcCommand2
        Me.daLine_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand2
        '
        Me.OdbcCommand2.Connection = Me.CnnExcelFile
        '
        'daInvTabPublic
        '
        Me.daInvTabPublic.InsertCommand = Me.SqlInsertCommand8
        Me.daInvTabPublic.SelectCommand = Me.SqlSelectCommand8
        Me.daInvTabPublic.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_public", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_table_public", "cod_table_public"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table")})})
        Me.daInvTabPublic.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO inv_tab_public(cod_main, cod_table_public, desc_table) VALUES (@cod_m" & _
        "ain, @cod_table_public, @desc_table); SELECT cod_main, cod_table_public, desc_ta" & _
        "ble FROM inv_tab_public WHERE (cod_main = @cod_main) AND (cod_table_public = @co" & _
        "d_table_public)"
        Me.SqlInsertCommand8.Connection = Me.CnnSql
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_main", System.Data.SqlDbType.VarChar, 2, "cod_main"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_table_public", System.Data.SqlDbType.VarChar, 3, "cod_table_public"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_table", System.Data.SqlDbType.VarChar, 50, "desc_table"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT cod_main, cod_table_public, desc_table FROM inv_tab_public WHERE (cod_main" & _
        " = '01')"
        Me.SqlSelectCommand8.Connection = Me.CnnSql
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE inv_tab_public SET cod_main = @cod_main, cod_table_public = @cod_table_pub" & _
        "lic, desc_table = @desc_table WHERE (cod_main = @Original_cod_main) AND (cod_tab" & _
        "le_public = @Original_cod_table_public) AND (desc_table = @Original_desc_table O" & _
        "R @Original_desc_table IS NULL AND desc_table IS NULL); SELECT cod_main, cod_tab" & _
        "le_public, desc_table FROM inv_tab_public WHERE (cod_main = @cod_main) AND (cod_" & _
        "table_public = @cod_table_public)"
        Me.SqlUpdateCommand8.Connection = Me.CnnSql
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_main", System.Data.SqlDbType.VarChar, 2, "cod_main"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_table_public", System.Data.SqlDbType.VarChar, 3, "cod_table_public"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_table", System.Data.SqlDbType.VarChar, 50, "desc_table"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_main", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_main", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_table_public", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_table_public", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_table", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_table", System.Data.DataRowVersion.Original, Nothing))
        '
        'daItemListing_xls
        '
        Me.daItemListing_xls.SelectCommand = Me.OdbcCommand3
        Me.daItemListing_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand3
        '
        Me.OdbcCommand3.Connection = Me.CnnExcelFile
        '
        'daInvVendor
        '
        Me.daInvVendor.DeleteCommand = Me.SqlDeleteCommand8
        Me.daInvVendor.InsertCommand = Me.SqlInsertCommand10
        Me.daInvVendor.SelectCommand = Me.SqlSelectCommand10
        Me.daInvVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("vendor_since", "vendor_since"), New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor")})})
        Me.daInvVendor.UpdateCommand = Me.SqlUpdateCommand10
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM inv_vendor WHERE (cod_vendor = @Original_cod_vendor) AND (address = @" & _
        "Original_address OR @Original_address IS NULL AND address IS NULL) AND (class_ve" & _
        "ndor = @Original_class_vendor OR @Original_class_vendor IS NULL AND class_vendor" & _
        " IS NULL) AND (desc_vendor = @Original_desc_vendor OR @Original_desc_vendor IS N" & _
        "ULL AND desc_vendor IS NULL) AND (extension_1 = @Original_extension_1 OR @Origin" & _
        "al_extension_1 IS NULL AND extension_1 IS NULL) AND (phone_1 = @Original_phone_1" & _
        " OR @Original_phone_1 IS NULL AND phone_1 IS NULL) AND (phone_main_1 = @Original" & _
        "_phone_main_1 OR @Original_phone_main_1 IS NULL AND phone_main_1 IS NULL) AND (p" & _
        "hone_type_1 = @Original_phone_type_1 OR @Original_phone_type_1 IS NULL AND phone" & _
        "_type_1 IS NULL) AND (vendor_since = @Original_vendor_since OR @Original_vendor_" & _
        "since IS NULL AND vendor_since IS NULL) AND (vendor_type = @Original_vendor_type" & _
        " OR @Original_vendor_type IS NULL AND vendor_type IS NULL) AND (zipcode = @Origi" & _
        "nal_zipcode OR @Original_zipcode IS NULL AND zipcode IS NULL)"
        Me.SqlDeleteCommand8.Connection = Me.CnnSql
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_since", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_since", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = "INSERT INTO inv_vendor(cod_vendor, desc_vendor, address, zipcode, phone_1, extens" & _
        "ion_1, phone_type_1, phone_main_1, vendor_since, vendor_type, class_vendor) VALU" & _
        "ES (@cod_vendor, @desc_vendor, @address, @zipcode, @phone_1, @extension_1, @phon" & _
        "e_type_1, @phone_main_1, @vendor_since, @vendor_type, @class_vendor); SELECT cod" & _
        "_vendor, desc_vendor, address, zipcode, phone_1, extension_1, phone_type_1, phon" & _
        "e_main_1, vendor_since, vendor_type, class_vendor FROM inv_vendor WHERE (cod_ven" & _
        "dor = @cod_vendor)"
        Me.SqlInsertCommand10.Connection = Me.CnnSql
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor", System.Data.SqlDbType.VarChar, 50, "desc_vendor"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_since", System.Data.SqlDbType.VarChar, 10, "vendor_since"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT cod_vendor, desc_vendor, address, zipcode, phone_1, extension_1, phone_typ" & _
        "e_1, phone_main_1, vendor_since, vendor_type, class_vendor FROM inv_vendor"
        Me.SqlSelectCommand10.Connection = Me.CnnSql
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = "UPDATE inv_vendor SET cod_vendor = @cod_vendor, desc_vendor = @desc_vendor, addre" & _
        "ss = @address, zipcode = @zipcode, phone_1 = @phone_1, extension_1 = @extension_" & _
        "1, phone_type_1 = @phone_type_1, phone_main_1 = @phone_main_1, vendor_since = @v" & _
        "endor_since, vendor_type = @vendor_type, class_vendor = @class_vendor WHERE (cod" & _
        "_vendor = @Original_cod_vendor) AND (address = @Original_address OR @Original_ad" & _
        "dress IS NULL AND address IS NULL) AND (class_vendor = @Original_class_vendor OR" & _
        " @Original_class_vendor IS NULL AND class_vendor IS NULL) AND (desc_vendor = @Or" & _
        "iginal_desc_vendor OR @Original_desc_vendor IS NULL AND desc_vendor IS NULL) AND" & _
        " (extension_1 = @Original_extension_1 OR @Original_extension_1 IS NULL AND exten" & _
        "sion_1 IS NULL) AND (phone_1 = @Original_phone_1 OR @Original_phone_1 IS NULL AN" & _
        "D phone_1 IS NULL) AND (phone_main_1 = @Original_phone_main_1 OR @Original_phone" & _
        "_main_1 IS NULL AND phone_main_1 IS NULL) AND (phone_type_1 = @Original_phone_ty" & _
        "pe_1 OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NULL) AND (vendor_sin" & _
        "ce = @Original_vendor_since OR @Original_vendor_since IS NULL AND vendor_since I" & _
        "S NULL) AND (vendor_type = @Original_vendor_type OR @Original_vendor_type IS NUL" & _
        "L AND vendor_type IS NULL) AND (zipcode = @Original_zipcode OR @Original_zipcode" & _
        " IS NULL AND zipcode IS NULL); SELECT cod_vendor, desc_vendor, address, zipcode," & _
        " phone_1, extension_1, phone_type_1, phone_main_1, vendor_since, vendor_type, cl" & _
        "ass_vendor FROM inv_vendor WHERE (cod_vendor = @cod_vendor)"
        Me.SqlUpdateCommand10.Connection = Me.CnnSql
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor", System.Data.SqlDbType.VarChar, 50, "desc_vendor"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_since", System.Data.SqlDbType.VarChar, 10, "vendor_since"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_since", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_since", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvTabVendorClass
        '
        Me.daInvTabVendorClass.DeleteCommand = Me.SqlDeleteCommand10
        Me.daInvTabVendorClass.InsertCommand = Me.SqlInsertCommand11
        Me.daInvTabVendorClass.SelectCommand = Me.SqlSelectCommand11
        Me.daInvTabVendorClass.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        Me.daInvTabVendorClass.UpdateCommand = Me.SqlUpdateCommand11
        '
        'SqlDeleteCommand10
        '
        Me.SqlDeleteCommand10.CommandText = "DELETE FROM inv_tab_vendor_class WHERE (class_vendor = @Original_class_vendor) AN" & _
        "D (desc_class = @Original_desc_class OR @Original_desc_class IS NULL AND desc_cl" & _
        "ass IS NULL)"
        Me.SqlDeleteCommand10.Connection = Me.CnnSql
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand11
        '
        Me.SqlInsertCommand11.CommandText = "INSERT INTO inv_tab_vendor_class(class_vendor, desc_class) VALUES (@class_vendor," & _
        " @desc_class); SELECT class_vendor, desc_class FROM inv_tab_vendor_class WHERE (" & _
        "class_vendor = @class_vendor)"
        Me.SqlInsertCommand11.Connection = Me.CnnSql
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT class_vendor, desc_class FROM inv_tab_vendor_class"
        Me.SqlSelectCommand11.Connection = Me.CnnSql
        '
        'SqlUpdateCommand11
        '
        Me.SqlUpdateCommand11.CommandText = "UPDATE inv_tab_vendor_class SET class_vendor = @class_vendor, desc_class = @desc_" & _
        "class WHERE (class_vendor = @Original_class_vendor) AND (desc_class = @Original_" & _
        "desc_class OR @Original_desc_class IS NULL AND desc_class IS NULL); SELECT class" & _
        "_vendor, desc_class FROM inv_tab_vendor_class WHERE (class_vendor = @class_vendo" & _
        "r)"
        Me.SqlUpdateCommand11.Connection = Me.CnnSql
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvTabVendorType
        '
        Me.daInvTabVendorType.DeleteCommand = Me.SqlDeleteCommand11
        Me.daInvTabVendorType.InsertCommand = Me.SqlInsertCommand12
        Me.daInvTabVendorType.SelectCommand = Me.SqlSelectCommand12
        Me.daInvTabVendorType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("desc_vendor_type", "desc_vendor_type"), New System.Data.Common.DataColumnMapping("GL_expense_account", "GL_expense_account")})})
        Me.daInvTabVendorType.UpdateCommand = Me.SqlUpdateCommand12
        '
        'SqlDeleteCommand11
        '
        Me.SqlDeleteCommand11.CommandText = "DELETE FROM inv_tab_vendor_type WHERE (vendor_type = @Original_vendor_type) AND (" & _
        "GL_expense_account = @Original_GL_expense_account OR @Original_GL_expense_accoun" & _
        "t IS NULL AND GL_expense_account IS NULL) AND (desc_vendor_type = @Original_desc" & _
        "_vendor_type OR @Original_desc_vendor_type IS NULL AND desc_vendor_type IS NULL)" & _
        ""
        Me.SqlDeleteCommand11.Connection = Me.CnnSql
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand12
        '
        Me.SqlInsertCommand12.CommandText = "INSERT INTO inv_tab_vendor_type(vendor_type, desc_vendor_type, GL_expense_account" & _
        ") VALUES (@vendor_type, @desc_vendor_type, @GL_expense_account); SELECT vendor_t" & _
        "ype, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type WHERE (vendor" & _
        "_type = @vendor_type)"
        Me.SqlInsertCommand12.Connection = Me.CnnSql
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor_type", System.Data.SqlDbType.VarChar, 50, "desc_vendor_type"))
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT vendor_type, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type" & _
        ""
        Me.SqlSelectCommand12.Connection = Me.CnnSql
        '
        'SqlUpdateCommand12
        '
        Me.SqlUpdateCommand12.CommandText = "UPDATE inv_tab_vendor_type SET vendor_type = @vendor_type, desc_vendor_type = @de" & _
        "sc_vendor_type, GL_expense_account = @GL_expense_account WHERE (vendor_type = @O" & _
        "riginal_vendor_type) AND (GL_expense_account = @Original_GL_expense_account OR @" & _
        "Original_GL_expense_account IS NULL AND GL_expense_account IS NULL) AND (desc_ve" & _
        "ndor_type = @Original_desc_vendor_type OR @Original_desc_vendor_type IS NULL AND" & _
        " desc_vendor_type IS NULL); SELECT vendor_type, desc_vendor_type, GL_expense_acc" & _
        "ount FROM inv_tab_vendor_type WHERE (vendor_type = @vendor_type)"
        Me.SqlUpdateCommand12.Connection = Me.CnnSql
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor_type", System.Data.SqlDbType.VarChar, 50, "desc_vendor_type"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'daVendor_xls
        '
        Me.daVendor_xls.SelectCommand = Me.OdbcCommand4
        Me.daVendor_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand4
        '
        Me.OdbcCommand4.Connection = Me.CnnExcelFile
        '
        'daZipCode
        '
        Me.daZipCode.SelectCommand = Me.SqlSelectCommand13
        Me.daZipCode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_zipcode", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("county", "county"), New System.Data.Common.DataColumnMapping("state", "state")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT zipcode, city, county, state FROM bas_zipcode"
        Me.SqlSelectCommand13.Connection = Me.CnnSql
        '
        'daInvItemQuickRefrence
        '
        Me.daInvItemQuickRefrence.DeleteCommand = Me.SqlDeleteCommand12
        Me.daInvItemQuickRefrence.InsertCommand = Me.SqlInsertCommand13
        Me.daInvItemQuickRefrence.SelectCommand = Me.SqlSelectCommand14
        Me.daInvItemQuickRefrence.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_quick_refrence", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence")})})
        Me.daInvItemQuickRefrence.UpdateCommand = Me.SqlUpdateCommand13
        '
        'SqlDeleteCommand12
        '
        Me.SqlDeleteCommand12.CommandText = "DELETE FROM inv_item_quick_refrence WHERE (cod_quick_refrence = @Original_cod_qui" & _
        "ck_refrence) AND (desc_quick_refrence = @Original_desc_quick_refrence OR @Origin" & _
        "al_desc_quick_refrence IS NULL AND desc_quick_refrence IS NULL)"
        Me.SqlDeleteCommand12.Connection = Me.CnnSql
        Me.SqlDeleteCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand13
        '
        Me.SqlInsertCommand13.CommandText = "INSERT INTO inv_item_quick_refrence(cod_quick_refrence, desc_quick_refrence) VALU" & _
        "ES (@cod_quick_refrence, @desc_quick_refrence); SELECT cod_quick_refrence, desc_" & _
        "quick_refrence FROM inv_item_quick_refrence WHERE (cod_quick_refrence = @cod_qui" & _
        "ck_refrence)"
        Me.SqlInsertCommand13.Connection = Me.CnnSql
        Me.SqlInsertCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlInsertCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, "desc_quick_refrence"))
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT cod_quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence"
        Me.SqlSelectCommand14.Connection = Me.CnnSql
        '
        'SqlUpdateCommand13
        '
        Me.SqlUpdateCommand13.CommandText = "UPDATE inv_item_quick_refrence SET cod_quick_refrence = @cod_quick_refrence, desc" & _
        "_quick_refrence = @desc_quick_refrence WHERE (cod_quick_refrence = @Original_cod" & _
        "_quick_refrence) AND (desc_quick_refrence = @Original_desc_quick_refrence OR @Or" & _
        "iginal_desc_quick_refrence IS NULL AND desc_quick_refrence IS NULL); SELECT cod_" & _
        "quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence WHERE (cod_quic" & _
        "k_refrence = @cod_quick_refrence)"
        Me.SqlUpdateCommand13.Connection = Me.CnnSql
        Me.SqlUpdateCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlUpdateCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, "desc_quick_refrence"))
        Me.SqlUpdateCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvItem
        '
        Me.daInvItem.DeleteCommand = Me.SqlDeleteCommand13
        Me.daInvItem.InsertCommand = Me.SqlInsertCommand14
        Me.daInvItem.SelectCommand = Me.SqlSelectCommand15
        Me.daInvItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("consignment", "consignment"), New System.Data.Common.DataColumnMapping("discontinued", "discontinued"), New System.Data.Common.DataColumnMapping("discontinued_date", "discontinued_date"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        Me.daInvItem.UpdateCommand = Me.SqlUpdateCommand14
        '
        'SqlDeleteCommand13
        '
        Me.SqlDeleteCommand13.CommandText = "DELETE FROM inv_item WHERE (item_no = @Original_item_no) AND (cod_item_type = @Or" & _
        "iginal_cod_item_type OR @Original_cod_item_type IS NULL AND cod_item_type IS NUL" & _
        "L) AND (cod_quick_refrence = @Original_cod_quick_refrence OR @Original_cod_quick" & _
        "_refrence IS NULL AND cod_quick_refrence IS NULL) AND (consignment = @Original_c" & _
        "onsignment OR @Original_consignment IS NULL AND consignment IS NULL) AND (desc_i" & _
        "tem = @Original_desc_item OR @Original_desc_item IS NULL AND desc_item IS NULL) " & _
        "AND (discontinued = @Original_discontinued OR @Original_discontinued IS NULL AND" & _
        " discontinued IS NULL) AND (discontinued_date = @Original_discontinued_date OR @" & _
        "Original_discontinued_date IS NULL AND discontinued_date IS NULL) AND (line = @O" & _
        "riginal_line OR @Original_line IS NULL AND line IS NULL) AND (note = @Original_n" & _
        "ote OR @Original_note IS NULL AND note IS NULL) AND (special_notice = @Original_" & _
        "special_notice OR @Original_special_notice IS NULL AND special_notice IS NULL) A" & _
        "ND (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable IS NULL" & _
        ") AND (upc = @Original_upc OR @Original_upc IS NULL AND upc IS NULL)"
        Me.SqlDeleteCommand13.Connection = Me.CnnSql
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_item_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_item_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_consignment", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "consignment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_item", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_item", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_upc", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "upc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand14
        '
        Me.SqlInsertCommand14.CommandText = "INSERT INTO inv_item(item_no, cod_item_type, desc_item, cod_quick_refrence, taxab" & _
        "le, line, note, picture, upc, consignment, discontinued, discontinued_date, spec" & _
        "ial_notice) VALUES (@item_no, @cod_item_type, @desc_item, @cod_quick_refrence, @" & _
        "taxable, @line, @note, @picture, @upc, @consignment, @discontinued, @discontinue" & _
        "d_date, @special_notice); SELECT item_no, cod_item_type, desc_item, cod_quick_re" & _
        "frence, taxable, line, note, picture, upc, consignment, discontinued, discontinu" & _
        "ed_date, special_notice FROM inv_item WHERE (item_no = @item_no)"
        Me.SqlInsertCommand14.Connection = Me.CnnSql
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item", System.Data.SqlDbType.VarChar, 50, "desc_item"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 300, "note"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 2147483647, "picture"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@upc", System.Data.SqlDbType.VarChar, 30, "upc"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@consignment", System.Data.SqlDbType.Bit, 1, "consignment"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued", System.Data.SqlDbType.Bit, 1, "discontinued"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued_date", System.Data.SqlDbType.VarChar, 10, "discontinued_date"))
        Me.SqlInsertCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT item_no, cod_item_type, desc_item, cod_quick_refrence, taxable, line, note" & _
        ", picture, upc, consignment, discontinued, discontinued_date, special_notice FRO" & _
        "M inv_item"
        Me.SqlSelectCommand15.Connection = Me.CnnSql
        '
        'SqlUpdateCommand14
        '
        Me.SqlUpdateCommand14.CommandText = "UPDATE inv_item SET item_no = @item_no, cod_item_type = @cod_item_type, desc_item" & _
        " = @desc_item, cod_quick_refrence = @cod_quick_refrence, taxable = @taxable, lin" & _
        "e = @line, note = @note, picture = @picture, upc = @upc, consignment = @consignm" & _
        "ent, discontinued = @discontinued, discontinued_date = @discontinued_date, speci" & _
        "al_notice = @special_notice WHERE (item_no = @Original_item_no) AND (cod_item_ty" & _
        "pe = @Original_cod_item_type OR @Original_cod_item_type IS NULL AND cod_item_typ" & _
        "e IS NULL) AND (cod_quick_refrence = @Original_cod_quick_refrence OR @Original_c" & _
        "od_quick_refrence IS NULL AND cod_quick_refrence IS NULL) AND (consignment = @Or" & _
        "iginal_consignment OR @Original_consignment IS NULL AND consignment IS NULL) AND" & _
        " (desc_item = @Original_desc_item OR @Original_desc_item IS NULL AND desc_item I" & _
        "S NULL) AND (discontinued = @Original_discontinued OR @Original_discontinued IS " & _
        "NULL AND discontinued IS NULL) AND (discontinued_date = @Original_discontinued_d" & _
        "ate OR @Original_discontinued_date IS NULL AND discontinued_date IS NULL) AND (l" & _
        "ine = @Original_line OR @Original_line IS NULL AND line IS NULL) AND (note = @Or" & _
        "iginal_note OR @Original_note IS NULL AND note IS NULL) AND (special_notice = @O" & _
        "riginal_special_notice OR @Original_special_notice IS NULL AND special_notice IS" & _
        " NULL) AND (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable" & _
        " IS NULL) AND (upc = @Original_upc OR @Original_upc IS NULL AND upc IS NULL); SE" & _
        "LECT item_no, cod_item_type, desc_item, cod_quick_refrence, taxable, line, note," & _
        " picture, upc, consignment, discontinued, discontinued_date, special_notice FROM" & _
        " inv_item WHERE (item_no = @item_no)"
        Me.SqlUpdateCommand14.Connection = Me.CnnSql
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item", System.Data.SqlDbType.VarChar, 50, "desc_item"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 300, "note"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 2147483647, "picture"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@upc", System.Data.SqlDbType.VarChar, 30, "upc"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@consignment", System.Data.SqlDbType.Bit, 1, "consignment"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued", System.Data.SqlDbType.Bit, 1, "discontinued"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued_date", System.Data.SqlDbType.VarChar, 10, "discontinued_date"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_item_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_item_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_consignment", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "consignment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_item", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_item", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_upc", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "upc", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvTabTypeItem
        '
        Me.daInvTabTypeItem.DeleteCommand = Me.SqlDeleteCommand14
        Me.daInvTabTypeItem.InsertCommand = Me.SqlInsertCommand15
        Me.daInvTabTypeItem.SelectCommand = Me.SqlSelectCommand16
        Me.daInvTabTypeItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_type_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item_type", "desc_item_type")})})
        Me.daInvTabTypeItem.UpdateCommand = Me.SqlUpdateCommand15
        '
        'SqlDeleteCommand14
        '
        Me.SqlDeleteCommand14.CommandText = "DELETE FROM inv_tab_type_item WHERE (cod_item_type = @Original_cod_item_type) AND" & _
        " (desc_item_type = @Original_desc_item_type OR @Original_desc_item_type IS NULL " & _
        "AND desc_item_type IS NULL)"
        Me.SqlDeleteCommand14.Connection = Me.CnnSql
        Me.SqlDeleteCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_item_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_item_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_item_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_item_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand15
        '
        Me.SqlInsertCommand15.CommandText = "INSERT INTO inv_tab_type_item(cod_item_type, desc_item_type) VALUES (@cod_item_ty" & _
        "pe, @desc_item_type); SELECT cod_item_type, desc_item_type FROM inv_tab_type_ite" & _
        "m WHERE (cod_item_type = @cod_item_type)"
        Me.SqlInsertCommand15.Connection = Me.CnnSql
        Me.SqlInsertCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.SqlInsertCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item_type", System.Data.SqlDbType.VarChar, 50, "desc_item_type"))
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = "SELECT cod_item_type, desc_item_type FROM inv_tab_type_item"
        Me.SqlSelectCommand16.Connection = Me.CnnSql
        '
        'SqlUpdateCommand15
        '
        Me.SqlUpdateCommand15.CommandText = "UPDATE inv_tab_type_item SET cod_item_type = @cod_item_type, desc_item_type = @de" & _
        "sc_item_type WHERE (cod_item_type = @Original_cod_item_type) AND (desc_item_type" & _
        " = @Original_desc_item_type OR @Original_desc_item_type IS NULL AND desc_item_ty" & _
        "pe IS NULL); SELECT cod_item_type, desc_item_type FROM inv_tab_type_item WHERE (" & _
        "cod_item_type = @cod_item_type)"
        Me.SqlUpdateCommand15.Connection = Me.CnnSql
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item_type", System.Data.SqlDbType.VarChar, 50, "desc_item_type"))
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_item_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_item_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_item_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_item_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvItemVendor
        '
        Me.daInvItemVendor.DeleteCommand = Me.SqlDeleteCommand16
        Me.daInvItemVendor.InsertCommand = Me.SqlInsertCommand17
        Me.daInvItemVendor.SelectCommand = Me.SqlSelectCommand18
        Me.daInvItemVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("ven_part_no", "ven_part_no"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        Me.daInvItemVendor.UpdateCommand = Me.SqlUpdateCommand17
        '
        'SqlDeleteCommand16
        '
        Me.SqlDeleteCommand16.CommandText = "DELETE FROM inv_item_vendor WHERE (cod_vendor = @Original_cod_vendor) AND (item_n" & _
        "o = @Original_item_no) AND (remark = @Original_remark OR @Original_remark IS NUL" & _
        "L AND remark IS NULL) AND (ven_part_no = @Original_ven_part_no OR @Original_ven_" & _
        "part_no IS NULL AND ven_part_no IS NULL)"
        Me.SqlDeleteCommand16.Connection = Me.CnnSql
        Me.SqlDeleteCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ven_part_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ven_part_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand17
        '
        Me.SqlInsertCommand17.CommandText = "INSERT INTO inv_item_vendor(item_no, cod_vendor, ven_part_no, remark) VALUES (@it" & _
        "em_no, @cod_vendor, @ven_part_no, @remark); SELECT item_no, cod_vendor, ven_part" & _
        "_no, remark FROM inv_item_vendor WHERE (cod_vendor = @cod_vendor) AND (item_no =" & _
        " @item_no)"
        Me.SqlInsertCommand17.Connection = Me.CnnSql
        Me.SqlInsertCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ven_part_no", System.Data.SqlDbType.VarChar, 30, "ven_part_no"))
        Me.SqlInsertCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'SqlSelectCommand18
        '
        Me.SqlSelectCommand18.CommandText = "SELECT item_no, cod_vendor, ven_part_no, remark FROM inv_item_vendor"
        Me.SqlSelectCommand18.Connection = Me.CnnSql
        '
        'SqlUpdateCommand17
        '
        Me.SqlUpdateCommand17.CommandText = "UPDATE inv_item_vendor SET item_no = @item_no, cod_vendor = @cod_vendor, ven_part" & _
        "_no = @ven_part_no, remark = @remark WHERE (cod_vendor = @Original_cod_vendor) A" & _
        "ND (item_no = @Original_item_no) AND (remark = @Original_remark OR @Original_rem" & _
        "ark IS NULL AND remark IS NULL) AND (ven_part_no = @Original_ven_part_no OR @Ori" & _
        "ginal_ven_part_no IS NULL AND ven_part_no IS NULL); SELECT item_no, cod_vendor, " & _
        "ven_part_no, remark FROM inv_item_vendor WHERE (cod_vendor = @cod_vendor) AND (i" & _
        "tem_no = @item_no)"
        Me.SqlUpdateCommand17.Connection = Me.CnnSql
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ven_part_no", System.Data.SqlDbType.VarChar, 30, "ven_part_no"))
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ven_part_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ven_part_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvItemCostTransaction
        '
        Me.daInvItemCostTransaction.DeleteCommand = Me.SqlDeleteCommand17
        Me.daInvItemCostTransaction.InsertCommand = Me.SqlInsertCommand18
        Me.daInvItemCostTransaction.SelectCommand = Me.SqlSelectCommand19
        Me.daInvItemCostTransaction.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_cost_transaction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("date_cost_change", "date_cost_change"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("list_price", "list_price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("delivery", "delivery"), New System.Data.Common.DataColumnMapping("frieght", "frieght"), New System.Data.Common.DataColumnMapping("price_code", "price_code")})})
        Me.daInvItemCostTransaction.UpdateCommand = Me.SqlUpdateCommand18
        '
        'SqlDeleteCommand17
        '
        Me.SqlDeleteCommand17.CommandText = "DELETE FROM inv_item_cost_transaction WHERE (date_cost_change = @Original_date_co" & _
        "st_change) AND (item_no = @Original_item_no) AND (cost = @Original_cost) AND (de" & _
        "livery = @Original_delivery OR @Original_delivery IS NULL AND delivery IS NULL) " & _
        "AND (fet = @Original_fet OR @Original_fet IS NULL AND fet IS NULL) AND (frieght " & _
        "= @Original_frieght OR @Original_frieght IS NULL AND frieght IS NULL) AND (list_" & _
        "price = @Original_list_price OR @Original_list_price IS NULL AND list_price IS N" & _
        "ULL) AND (price_code = @Original_price_code OR @Original_price_code IS NULL AND " & _
        "price_code IS NULL)"
        Me.SqlDeleteCommand17.Connection = Me.CnnSql
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_cost_change", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_cost_change", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_delivery", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "delivery", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_frieght", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "frieght", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_list_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "list_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand18
        '
        Me.SqlInsertCommand18.CommandText = "INSERT INTO inv_item_cost_transaction(item_no, date_cost_change, cost, list_price" & _
        ", fet, delivery, frieght, price_code) VALUES (@item_no, @date_cost_change, @cost" & _
        ", @list_price, @fet, @delivery, @frieght, @price_code); SELECT item_no, date_cos" & _
        "t_change, cost, list_price, fet, delivery, frieght, price_code FROM inv_item_cos" & _
        "t_transaction WHERE (date_cost_change = @date_cost_change) AND (item_no = @item_" & _
        "no)"
        Me.SqlInsertCommand18.Connection = Me.CnnSql
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_cost_change", System.Data.SqlDbType.VarChar, 10, "date_cost_change"))
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@list_price", System.Data.SqlDbType.Real, 4, "list_price"))
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Real, 4, "fet"))
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@delivery", System.Data.SqlDbType.Real, 4, "delivery"))
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@frieght", System.Data.SqlDbType.Real, 4, "frieght"))
        Me.SqlInsertCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        '
        'SqlSelectCommand19
        '
        Me.SqlSelectCommand19.CommandText = "SELECT item_no, date_cost_change, cost, list_price, fet, delivery, frieght, price" & _
        "_code FROM inv_item_cost_transaction"
        Me.SqlSelectCommand19.Connection = Me.CnnSql
        '
        'SqlUpdateCommand18
        '
        Me.SqlUpdateCommand18.CommandText = "UPDATE inv_item_cost_transaction SET item_no = @item_no, date_cost_change = @date" & _
        "_cost_change, cost = @cost, list_price = @list_price, fet = @fet, delivery = @de" & _
        "livery, frieght = @frieght, price_code = @price_code WHERE (date_cost_change = @" & _
        "Original_date_cost_change) AND (item_no = @Original_item_no) AND (cost = @Origin" & _
        "al_cost) AND (delivery = @Original_delivery OR @Original_delivery IS NULL AND de" & _
        "livery IS NULL) AND (fet = @Original_fet OR @Original_fet IS NULL AND fet IS NUL" & _
        "L) AND (frieght = @Original_frieght OR @Original_frieght IS NULL AND frieght IS " & _
        "NULL) AND (list_price = @Original_list_price OR @Original_list_price IS NULL AND" & _
        " list_price IS NULL) AND (price_code = @Original_price_code OR @Original_price_c" & _
        "ode IS NULL AND price_code IS NULL); SELECT item_no, date_cost_change, cost, lis" & _
        "t_price, fet, delivery, frieght, price_code FROM inv_item_cost_transaction WHERE" & _
        " (date_cost_change = @date_cost_change) AND (item_no = @item_no)"
        Me.SqlUpdateCommand18.Connection = Me.CnnSql
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_cost_change", System.Data.SqlDbType.VarChar, 10, "date_cost_change"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@list_price", System.Data.SqlDbType.Real, 4, "list_price"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Real, 4, "fet"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@delivery", System.Data.SqlDbType.Real, 4, "delivery"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@frieght", System.Data.SqlDbType.Real, 4, "frieght"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_cost_change", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_cost_change", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_delivery", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "delivery", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_frieght", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "frieght", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_list_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "list_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvPriceCode
        '
        Me.daInvPriceCode.DeleteCommand = Me.SqlDeleteCommand18
        Me.daInvPriceCode.InsertCommand = Me.SqlInsertCommand19
        Me.daInvPriceCode.SelectCommand = Me.SqlSelectCommand20
        Me.daInvPriceCode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_price_code", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("price_code", "price_code"), New System.Data.Common.DataColumnMapping("desc_price_code", "desc_price_code"), New System.Data.Common.DataColumnMapping("price1_c_l_a_p", "price1_c_l_a_p"), New System.Data.Common.DataColumnMapping("price1_operator", "price1_operator"), New System.Data.Common.DataColumnMapping("price1_d_persent", "price1_d_persent"), New System.Data.Common.DataColumnMapping("price1_amount", "price1_amount"), New System.Data.Common.DataColumnMapping("price1_odd_price", "price1_odd_price"), New System.Data.Common.DataColumnMapping("price1_price_level", "price1_price_level"), New System.Data.Common.DataColumnMapping("price2_c_l_a_p", "price2_c_l_a_p"), New System.Data.Common.DataColumnMapping("price2_operator", "price2_operator"), New System.Data.Common.DataColumnMapping("price2_d_persent", "price2_d_persent"), New System.Data.Common.DataColumnMapping("price2_amount", "price2_amount"), New System.Data.Common.DataColumnMapping("price2_odd_price", "price2_odd_price"), New System.Data.Common.DataColumnMapping("price2_price_level", "price2_price_level"), New System.Data.Common.DataColumnMapping("price3_c_l_a_p", "price3_c_l_a_p"), New System.Data.Common.DataColumnMapping("price3_operator", "price3_operator"), New System.Data.Common.DataColumnMapping("price3_d_persent", "price3_d_persent"), New System.Data.Common.DataColumnMapping("price3_amount", "price3_amount"), New System.Data.Common.DataColumnMapping("price3_odd_price", "price3_odd_price"), New System.Data.Common.DataColumnMapping("price3_price_level", "price3_price_level"), New System.Data.Common.DataColumnMapping("price4_c_l_a_p", "price4_c_l_a_p"), New System.Data.Common.DataColumnMapping("price4_operator", "price4_operator"), New System.Data.Common.DataColumnMapping("price4_d_persent", "price4_d_persent"), New System.Data.Common.DataColumnMapping("price4_amount", "price4_amount"), New System.Data.Common.DataColumnMapping("price4_odd_price", "price4_odd_price"), New System.Data.Common.DataColumnMapping("price4_price_level", "price4_price_level"), New System.Data.Common.DataColumnMapping("price5_c_l_a_p", "price5_c_l_a_p"), New System.Data.Common.DataColumnMapping("price5_operator", "price5_operator"), New System.Data.Common.DataColumnMapping("price5_d_persent", "price5_d_persent"), New System.Data.Common.DataColumnMapping("price5_amount", "price5_amount"), New System.Data.Common.DataColumnMapping("price5_odd_price", "price5_odd_price"), New System.Data.Common.DataColumnMapping("price5_price_level", "price5_price_level"), New System.Data.Common.DataColumnMapping("price6_c_l_a_p", "price6_c_l_a_p"), New System.Data.Common.DataColumnMapping("price6_operator", "price6_operator"), New System.Data.Common.DataColumnMapping("price6_d_persent", "price6_d_persent"), New System.Data.Common.DataColumnMapping("price6_amount", "price6_amount"), New System.Data.Common.DataColumnMapping("price6_odd_price", "price6_odd_price"), New System.Data.Common.DataColumnMapping("price6_price_level", "price6_price_level"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        Me.daInvPriceCode.UpdateCommand = Me.SqlUpdateCommand19
        '
        'SqlDeleteCommand18
        '
        Me.SqlDeleteCommand18.CommandText = "DELETE FROM inv_price_code WHERE (price_code = @Original_price_code) AND (desc_pr" & _
        "ice_code = @Original_desc_price_code OR @Original_desc_price_code IS NULL AND de" & _
        "sc_price_code IS NULL) AND (price1_amount = @Original_price1_amount OR @Original" & _
        "_price1_amount IS NULL AND price1_amount IS NULL) AND (price1_c_l_a_p = @Origina" & _
        "l_price1_c_l_a_p OR @Original_price1_c_l_a_p IS NULL AND price1_c_l_a_p IS NULL)" & _
        " AND (price1_d_persent = @Original_price1_d_persent OR @Original_price1_d_persen" & _
        "t IS NULL AND price1_d_persent IS NULL) AND (price1_odd_price = @Original_price1" & _
        "_odd_price OR @Original_price1_odd_price IS NULL AND price1_odd_price IS NULL) A" & _
        "ND (price1_operator = @Original_price1_operator OR @Original_price1_operator IS " & _
        "NULL AND price1_operator IS NULL) AND (price1_price_level = @Original_price1_pri" & _
        "ce_level OR @Original_price1_price_level IS NULL AND price1_price_level IS NULL)" & _
        " AND (price2_amount = @Original_price2_amount OR @Original_price2_amount IS NULL" & _
        " AND price2_amount IS NULL) AND (price2_c_l_a_p = @Original_price2_c_l_a_p OR @O" & _
        "riginal_price2_c_l_a_p IS NULL AND price2_c_l_a_p IS NULL) AND (price2_d_persent" & _
        " = @Original_price2_d_persent OR @Original_price2_d_persent IS NULL AND price2_d" & _
        "_persent IS NULL) AND (price2_odd_price = @Original_price2_odd_price OR @Origina" & _
        "l_price2_odd_price IS NULL AND price2_odd_price IS NULL) AND (price2_operator = " & _
        "@Original_price2_operator OR @Original_price2_operator IS NULL AND price2_operat" & _
        "or IS NULL) AND (price2_price_level = @Original_price2_price_level OR @Original_" & _
        "price2_price_level IS NULL AND price2_price_level IS NULL) AND (price3_amount = " & _
        "@Original_price3_amount OR @Original_price3_amount IS NULL AND price3_amount IS " & _
        "NULL) AND (price3_c_l_a_p = @Original_price3_c_l_a_p OR @Original_price3_c_l_a_p" & _
        " IS NULL AND price3_c_l_a_p IS NULL) AND (price3_d_persent = @Original_price3_d_" & _
        "persent OR @Original_price3_d_persent IS NULL AND price3_d_persent IS NULL) AND " & _
        "(price3_odd_price = @Original_price3_odd_price OR @Original_price3_odd_price IS " & _
        "NULL AND price3_odd_price IS NULL) AND (price3_operator = @Original_price3_opera" & _
        "tor OR @Original_price3_operator IS NULL AND price3_operator IS NULL) AND (price" & _
        "3_price_level = @Original_price3_price_level OR @Original_price3_price_level IS " & _
        "NULL AND price3_price_level IS NULL) AND (price4_amount = @Original_price4_amoun" & _
        "t OR @Original_price4_amount IS NULL AND price4_amount IS NULL) AND (price4_c_l_" & _
        "a_p = @Original_price4_c_l_a_p OR @Original_price4_c_l_a_p IS NULL AND price4_c_" & _
        "l_a_p IS NULL) AND (price4_d_persent = @Original_price4_d_persent OR @Original_p" & _
        "rice4_d_persent IS NULL AND price4_d_persent IS NULL) AND (price4_odd_price = @O" & _
        "riginal_price4_odd_price OR @Original_price4_odd_price IS NULL AND price4_odd_pr" & _
        "ice IS NULL) AND (price4_operator = @Original_price4_operator OR @Original_price" & _
        "4_operator IS NULL AND price4_operator IS NULL) AND (price4_price_level = @Origi" & _
        "nal_price4_price_level OR @Original_price4_price_level IS NULL AND price4_price_" & _
        "level IS NULL) AND (price5_amount = @Original_price5_amount OR @Original_price5_" & _
        "amount IS NULL AND price5_amount IS NULL) AND (price5_c_l_a_p = @Original_price5" & _
        "_c_l_a_p OR @Original_price5_c_l_a_p IS NULL AND price5_c_l_a_p IS NULL) AND (pr" & _
        "ice5_d_persent = @Original_price5_d_persent OR @Original_price5_d_persent IS NUL" & _
        "L AND price5_d_persent IS NULL) AND (price5_odd_price = @Original_price5_odd_pri" & _
        "ce OR @Original_price5_odd_price IS NULL AND price5_odd_price IS NULL) AND (pric" & _
        "e5_operator = @Original_price5_operator OR @Original_price5_operator IS NULL AND" & _
        " price5_operator IS NULL) AND (price5_price_level = @Original_price5_price_level" & _
        " OR @Original_price5_price_level IS NULL AND price5_price_level IS NULL) AND (pr" & _
        "ice6_amount = @Original_price6_amount OR @Original_price6_amount IS NULL AND pri" & _
        "ce6_amount IS NULL) AND (price6_c_l_a_p = @Original_price6_c_l_a_p OR @Original_" & _
        "price6_c_l_a_p IS NULL AND price6_c_l_a_p IS NULL) AND (price6_d_persent = @Orig" & _
        "inal_price6_d_persent OR @Original_price6_d_persent IS NULL AND price6_d_persent" & _
        " IS NULL) AND (price6_odd_price = @Original_price6_odd_price OR @Original_price6" & _
        "_odd_price IS NULL AND price6_odd_price IS NULL) AND (price6_operator = @Origina" & _
        "l_price6_operator OR @Original_price6_operator IS NULL AND price6_operator IS NU" & _
        "LL) AND (price6_price_level = @Original_price6_price_level OR @Original_price6_p" & _
        "rice_level IS NULL AND price6_price_level IS NULL) AND (special_notice = @Origin" & _
        "al_special_notice OR @Original_special_notice IS NULL AND special_notice IS NULL" & _
        ")"
        Me.SqlDeleteCommand18.Connection = Me.CnnSql
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_price_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand19
        '
        Me.SqlInsertCommand19.CommandText = "INSERT INTO inv_price_code(price_code, desc_price_code, price1_c_l_a_p, price1_op" & _
        "erator, price1_d_persent, price1_amount, price1_odd_price, price1_price_level, p" & _
        "rice2_c_l_a_p, price2_operator, price2_d_persent, price2_amount, price2_odd_pric" & _
        "e, price2_price_level, price3_c_l_a_p, price3_operator, price3_d_persent, price3" & _
        "_amount, price3_odd_price, price3_price_level, price4_c_l_a_p, price4_operator, " & _
        "price4_d_persent, price4_amount, price4_odd_price, price4_price_level, price5_c_" & _
        "l_a_p, price5_operator, price5_d_persent, price5_amount, price5_odd_price, price" & _
        "5_price_level, price6_c_l_a_p, price6_operator, price6_d_persent, price6_amount," & _
        " price6_odd_price, price6_price_level, special_notice) VALUES (@price_code, @des" & _
        "c_price_code, @price1_c_l_a_p, @price1_operator, @price1_d_persent, @price1_amou" & _
        "nt, @price1_odd_price, @price1_price_level, @price2_c_l_a_p, @price2_operator, @" & _
        "price2_d_persent, @price2_amount, @price2_odd_price, @price2_price_level, @price" & _
        "3_c_l_a_p, @price3_operator, @price3_d_persent, @price3_amount, @price3_odd_pric" & _
        "e, @price3_price_level, @price4_c_l_a_p, @price4_operator, @price4_d_persent, @p" & _
        "rice4_amount, @price4_odd_price, @price4_price_level, @price5_c_l_a_p, @price5_o" & _
        "perator, @price5_d_persent, @price5_amount, @price5_odd_price, @price5_price_lev" & _
        "el, @price6_c_l_a_p, @price6_operator, @price6_d_persent, @price6_amount, @price" & _
        "6_odd_price, @price6_price_level, @special_notice); SELECT price_code, desc_pric" & _
        "e_code, price1_c_l_a_p, price1_operator, price1_d_persent, price1_amount, price1" & _
        "_odd_price, price1_price_level, price2_c_l_a_p, price2_operator, price2_d_persen" & _
        "t, price2_amount, price2_odd_price, price2_price_level, price3_c_l_a_p, price3_o" & _
        "perator, price3_d_persent, price3_amount, price3_odd_price, price3_price_level, " & _
        "price4_c_l_a_p, price4_operator, price4_d_persent, price4_amount, price4_odd_pri" & _
        "ce, price4_price_level, price5_c_l_a_p, price5_operator, price5_d_persent, price" & _
        "5_amount, price5_odd_price, price5_price_level, price6_c_l_a_p, price6_operator," & _
        " price6_d_persent, price6_amount, price6_odd_price, price6_price_level, special_" & _
        "notice FROM inv_price_code WHERE (price_code = @price_code)"
        Me.SqlInsertCommand19.Connection = Me.CnnSql
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.SqlInsertCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        '
        'SqlSelectCommand20
        '
        Me.SqlSelectCommand20.CommandText = "SELECT price_code, desc_price_code, price1_c_l_a_p, price1_operator, price1_d_per" & _
        "sent, price1_amount, price1_odd_price, price1_price_level, price2_c_l_a_p, price" & _
        "2_operator, price2_d_persent, price2_amount, price2_odd_price, price2_price_leve" & _
        "l, price3_c_l_a_p, price3_operator, price3_d_persent, price3_amount, price3_odd_" & _
        "price, price3_price_level, price4_c_l_a_p, price4_operator, price4_d_persent, pr" & _
        "ice4_amount, price4_odd_price, price4_price_level, price5_c_l_a_p, price5_operat" & _
        "or, price5_d_persent, price5_amount, price5_odd_price, price5_price_level, price" & _
        "6_c_l_a_p, price6_operator, price6_d_persent, price6_amount, price6_odd_price, p" & _
        "rice6_price_level, special_notice FROM inv_price_code"
        Me.SqlSelectCommand20.Connection = Me.CnnSql
        '
        'SqlUpdateCommand19
        '
        Me.SqlUpdateCommand19.CommandText = "UPDATE inv_price_code SET price_code = @price_code, desc_price_code = @desc_price" & _
        "_code, price1_c_l_a_p = @price1_c_l_a_p, price1_operator = @price1_operator, pri" & _
        "ce1_d_persent = @price1_d_persent, price1_amount = @price1_amount, price1_odd_pr" & _
        "ice = @price1_odd_price, price1_price_level = @price1_price_level, price2_c_l_a_" & _
        "p = @price2_c_l_a_p, price2_operator = @price2_operator, price2_d_persent = @pri" & _
        "ce2_d_persent, price2_amount = @price2_amount, price2_odd_price = @price2_odd_pr" & _
        "ice, price2_price_level = @price2_price_level, price3_c_l_a_p = @price3_c_l_a_p," & _
        " price3_operator = @price3_operator, price3_d_persent = @price3_d_persent, price" & _
        "3_amount = @price3_amount, price3_odd_price = @price3_odd_price, price3_price_le" & _
        "vel = @price3_price_level, price4_c_l_a_p = @price4_c_l_a_p, price4_operator = @" & _
        "price4_operator, price4_d_persent = @price4_d_persent, price4_amount = @price4_a" & _
        "mount, price4_odd_price = @price4_odd_price, price4_price_level = @price4_price_" & _
        "level, price5_c_l_a_p = @price5_c_l_a_p, price5_operator = @price5_operator, pri" & _
        "ce5_d_persent = @price5_d_persent, price5_amount = @price5_amount, price5_odd_pr" & _
        "ice = @price5_odd_price, price5_price_level = @price5_price_level, price6_c_l_a_" & _
        "p = @price6_c_l_a_p, price6_operator = @price6_operator, price6_d_persent = @pri" & _
        "ce6_d_persent, price6_amount = @price6_amount, price6_odd_price = @price6_odd_pr" & _
        "ice, price6_price_level = @price6_price_level, special_notice = @special_notice " & _
        "WHERE (price_code = @Original_price_code) AND (desc_price_code = @Original_desc_" & _
        "price_code OR @Original_desc_price_code IS NULL AND desc_price_code IS NULL) AND" & _
        " (price1_amount = @Original_price1_amount OR @Original_price1_amount IS NULL AND" & _
        " price1_amount IS NULL) AND (price1_c_l_a_p = @Original_price1_c_l_a_p OR @Origi" & _
        "nal_price1_c_l_a_p IS NULL AND price1_c_l_a_p IS NULL) AND (price1_d_persent = @" & _
        "Original_price1_d_persent OR @Original_price1_d_persent IS NULL AND price1_d_per" & _
        "sent IS NULL) AND (price1_odd_price = @Original_price1_odd_price OR @Original_pr" & _
        "ice1_odd_price IS NULL AND price1_odd_price IS NULL) AND (price1_operator = @Ori" & _
        "ginal_price1_operator OR @Original_price1_operator IS NULL AND price1_operator I" & _
        "S NULL) AND (price1_price_level = @Original_price1_price_level OR @Original_pric" & _
        "e1_price_level IS NULL AND price1_price_level IS NULL) AND (price2_amount = @Ori" & _
        "ginal_price2_amount OR @Original_price2_amount IS NULL AND price2_amount IS NULL" & _
        ") AND (price2_c_l_a_p = @Original_price2_c_l_a_p OR @Original_price2_c_l_a_p IS " & _
        "NULL AND price2_c_l_a_p IS NULL) AND (price2_d_persent = @Original_price2_d_pers" & _
        "ent OR @Original_price2_d_persent IS NULL AND price2_d_persent IS NULL) AND (pri" & _
        "ce2_odd_price = @Original_price2_odd_price OR @Original_price2_odd_price IS NULL" & _
        " AND price2_odd_price IS NULL) AND (price2_operator = @Original_price2_operator " & _
        "OR @Original_price2_operator IS NULL AND price2_operator IS NULL) AND (price2_pr" & _
        "ice_level = @Original_price2_price_level OR @Original_price2_price_level IS NULL" & _
        " AND price2_price_level IS NULL) AND (price3_amount = @Original_price3_amount OR" & _
        " @Original_price3_amount IS NULL AND price3_amount IS NULL) AND (price3_c_l_a_p " & _
        "= @Original_price3_c_l_a_p OR @Original_price3_c_l_a_p IS NULL AND price3_c_l_a_" & _
        "p IS NULL) AND (price3_d_persent = @Original_price3_d_persent OR @Original_price" & _
        "3_d_persent IS NULL AND price3_d_persent IS NULL) AND (price3_odd_price = @Origi" & _
        "nal_price3_odd_price OR @Original_price3_odd_price IS NULL AND price3_odd_price " & _
        "IS NULL) AND (price3_operator = @Original_price3_operator OR @Original_price3_op" & _
        "erator IS NULL AND price3_operator IS NULL) AND (price3_price_level = @Original_" & _
        "price3_price_level OR @Original_price3_price_level IS NULL AND price3_price_leve" & _
        "l IS NULL) AND (price4_amount = @Original_price4_amount OR @Original_price4_amou" & _
        "nt IS NULL AND price4_amount IS NULL) AND (price4_c_l_a_p = @Original_price4_c_l" & _
        "_a_p OR @Original_price4_c_l_a_p IS NULL AND price4_c_l_a_p IS NULL) AND (price4" & _
        "_d_persent = @Original_price4_d_persent OR @Original_price4_d_persent IS NULL AN" & _
        "D price4_d_persent IS NULL) AND (price4_odd_price = @Original_price4_odd_price O" & _
        "R @Original_price4_odd_price IS NULL AND price4_odd_price IS NULL) AND (price4_o" & _
        "perator = @Original_price4_operator OR @Original_price4_operator IS NULL AND pri" & _
        "ce4_operator IS NULL) AND (price4_price_level = @Original_price4_price_level OR " & _
        "@Original_price4_price_level IS NULL AND price4_price_level IS NULL) AND (price5" & _
        "_amount = @Original_price5_amount OR @Original_price5_amount IS NULL AND price5_" & _
        "amount IS NULL) AND (price5_c_l_a_p = @Original_price5_c_l_a_p OR @Original_pric" & _
        "e5_c_l_a_p IS NULL AND price5_c_l_a_p IS NULL) AND (price5_d_persent = @Original" & _
        "_price5_d_persent OR @Original_price5_d_persent IS NULL AND price5_d_persent IS " & _
        "NULL) AND (price5_odd_price = @Original_price5_odd_price OR @Original_price5_odd" & _
        "_price IS NULL AND price5_odd_price IS NULL) AND (price5_operator = @Original_pr" & _
        "ice5_operator OR @Original_price5_operator IS NULL AND price5_operator IS NULL) " & _
        "AND (price5_price_level = @Original_price5_price_level OR @Original_price5_price" & _
        "_level IS NULL AND price5_price_level IS NULL) AND (price6_amount = @Original_pr" & _
        "ice6_amount OR @Original_price6_amount IS NULL AND price6_amount IS NULL) AND (p" & _
        "rice6_c_l_a_p = @Original_price6_c_l_a_p OR @Original_price6_c_l_a_p IS NULL AND" & _
        " price6_c_l_a_p IS NULL) AND (price6_d_persent = @Original_price6_d_persent OR @" & _
        "Original_price6_d_persent IS NULL AND price6_d_persent IS NULL) AND (price6_odd_" & _
        "price = @Original_price6_odd_price OR @Original_price6_odd_price IS NULL AND pri" & _
        "ce6_odd_price IS NULL) AND (price6_operator = @Original_price6_operator OR @Orig" & _
        "inal_price6_operator IS NULL AND price6_operator IS NULL) AND (price6_price_leve" & _
        "l = @Original_price6_price_level OR @Original_price6_price_level IS NULL AND pri" & _
        "ce6_price_level IS NULL) AND (special_notice = @Original_special_notice OR @Orig" & _
        "inal_special_notice IS NULL AND special_notice IS NULL); SELECT price_code, desc" & _
        "_price_code, price1_c_l_a_p, price1_operator, price1_d_persent, price1_amount, p" & _
        "rice1_odd_price, price1_price_level, price2_c_l_a_p, price2_operator, price2_d_p" & _
        "ersent, price2_amount, price2_odd_price, price2_price_level, price3_c_l_a_p, pri" & _
        "ce3_operator, price3_d_persent, price3_amount, price3_odd_price, price3_price_le" & _
        "vel, price4_c_l_a_p, price4_operator, price4_d_persent, price4_amount, price4_od" & _
        "d_price, price4_price_level, price5_c_l_a_p, price5_operator, price5_d_persent, " & _
        "price5_amount, price5_odd_price, price5_price_level, price6_c_l_a_p, price6_oper" & _
        "ator, price6_d_persent, price6_amount, price6_odd_price, price6_price_level, spe" & _
        "cial_notice FROM inv_price_code WHERE (price_code = @price_code)"
        Me.SqlUpdateCommand19.Connection = Me.CnnSql
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_price_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvDiscountItem
        '
        Me.daInvDiscountItem.DeleteCommand = Me.SqlDeleteCommand19
        Me.daInvDiscountItem.InsertCommand = Me.SqlInsertCommand20
        Me.daInvDiscountItem.SelectCommand = Me.SqlSelectCommand21
        Me.daInvDiscountItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_discount_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("counter", "counter"), New System.Data.Common.DataColumnMapping("item_no", "item_no")})})
        Me.daInvDiscountItem.UpdateCommand = Me.SqlUpdateCommand20
        '
        'SqlDeleteCommand19
        '
        Me.SqlDeleteCommand19.CommandText = "DELETE FROM inv_discount_item WHERE (counter = @Original_counter) AND (item_no = " & _
        "@Original_item_no OR @Original_item_no IS NULL AND item_no IS NULL)"
        Me.SqlDeleteCommand19.Connection = Me.CnnSql
        Me.SqlDeleteCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_counter", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "counter", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand20
        '
        Me.SqlInsertCommand20.CommandText = "INSERT INTO inv_discount_item(item_no) VALUES (@item_no); SELECT counter, item_no" & _
        " FROM inv_discount_item WHERE (counter = @@IDENTITY)"
        Me.SqlInsertCommand20.Connection = Me.CnnSql
        Me.SqlInsertCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'SqlSelectCommand21
        '
        Me.SqlSelectCommand21.CommandText = "SELECT counter, item_no FROM inv_discount_item"
        Me.SqlSelectCommand21.Connection = Me.CnnSql
        '
        'SqlUpdateCommand20
        '
        Me.SqlUpdateCommand20.CommandText = "UPDATE inv_discount_item SET item_no = @item_no WHERE (counter = @Original_counte" & _
        "r) AND (item_no = @Original_item_no OR @Original_item_no IS NULL AND item_no IS " & _
        "NULL); SELECT counter, item_no FROM inv_discount_item WHERE (counter = @counter)" & _
        ""
        Me.SqlUpdateCommand20.Connection = Me.CnnSql
        Me.SqlUpdateCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_counter", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "counter", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@counter", System.Data.SqlDbType.SmallInt, 2, "counter"))
        '
        'daPriceCode_xls
        '
        Me.daPriceCode_xls.SelectCommand = Me.OdbcCommand5
        Me.daPriceCode_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand5
        '
        Me.OdbcCommand5.Connection = Me.CnnExcelFile
        '
        'daITQty_xls
        '
        Me.daITQty_xls.SelectCommand = Me.OdbcCommand6
        Me.daITQty_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand6
        '
        Me.OdbcCommand6.Connection = Me.CnnExcelFile
        '
        'daService_xls
        '
        Me.daService_xls.SelectCommand = Me.OdbcCommand7
        Me.daService_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand7
        '
        Me.OdbcCommand7.Connection = Me.CnnExcelFile
        '
        'daInvTabLaborService
        '
        Me.daInvTabLaborService.DeleteCommand = Me.SqlDeleteCommand20
        Me.daInvTabLaborService.InsertCommand = Me.SqlInsertCommand21
        Me.daInvTabLaborService.SelectCommand = Me.SqlSelectCommand22
        Me.daInvTabLaborService.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("desc_service", "desc_service"), New System.Data.Common.DataColumnMapping("ext_desc", "ext_desc"), New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("use_cost", "use_cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("require_technician", "require_technician"), New System.Data.Common.DataColumnMapping("charge_shop_supply", "charge_shop_supply"), New System.Data.Common.DataColumnMapping("schedule", "schedule"), New System.Data.Common.DataColumnMapping("avg_time", "avg_time"), New System.Data.Common.DataColumnMapping("use_avg_time", "use_avg_time"), New System.Data.Common.DataColumnMapping("bay_no", "bay_no"), New System.Data.Common.DataColumnMapping("use_bay_no", "use_bay_no"), New System.Data.Common.DataColumnMapping("reminder", "reminder"), New System.Data.Common.DataColumnMapping("miles", "miles"), New System.Data.Common.DataColumnMapping("days", "days"), New System.Data.Common.DataColumnMapping("type_b_t_d_v_r", "type_b_t_d_v_r")})})
        Me.daInvTabLaborService.UpdateCommand = Me.SqlUpdateCommand21
        '
        'SqlDeleteCommand20
        '
        Me.SqlDeleteCommand20.CommandText = "DELETE FROM inv_tab_labor_service WHERE (cod_service = @Original_cod_service) AND" & _
        " (avg_time = @Original_avg_time OR @Original_avg_time IS NULL AND avg_time IS NU" & _
        "LL) AND (bay_no = @Original_bay_no OR @Original_bay_no IS NULL AND bay_no IS NUL" & _
        "L) AND (charge_shop_supply = @Original_charge_shop_supply OR @Original_charge_sh" & _
        "op_supply IS NULL AND charge_shop_supply IS NULL) AND (cost = @Original_cost OR " & _
        "@Original_cost IS NULL AND cost IS NULL) AND (days = @Original_days OR @Original" & _
        "_days IS NULL AND days IS NULL) AND (desc_service = @Original_desc_service OR @O" & _
        "riginal_desc_service IS NULL AND desc_service IS NULL) AND (ext_desc = @Original" & _
        "_ext_desc OR @Original_ext_desc IS NULL AND ext_desc IS NULL) AND (miles = @Orig" & _
        "inal_miles OR @Original_miles IS NULL AND miles IS NULL) AND (reminder = @Origin" & _
        "al_reminder OR @Original_reminder IS NULL AND reminder IS NULL) AND (require_tec" & _
        "hnician = @Original_require_technician OR @Original_require_technician IS NULL A" & _
        "ND require_technician IS NULL) AND (schedule = @Original_schedule OR @Original_s" & _
        "chedule IS NULL AND schedule IS NULL) AND (service_category = @Original_service_" & _
        "category OR @Original_service_category IS NULL AND service_category IS NULL) AND" & _
        " (service_type = @Original_service_type OR @Original_service_type IS NULL AND se" & _
        "rvice_type IS NULL) AND (taxable = @Original_taxable OR @Original_taxable IS NUL" & _
        "L AND taxable IS NULL) AND (type_b_t_d_v_r = @Original_type_b_t_d_v_r OR @Origin" & _
        "al_type_b_t_d_v_r IS NULL AND type_b_t_d_v_r IS NULL) AND (use_avg_time = @Origi" & _
        "nal_use_avg_time OR @Original_use_avg_time IS NULL AND use_avg_time IS NULL) AND" & _
        " (use_bay_no = @Original_use_bay_no OR @Original_use_bay_no IS NULL AND use_bay_" & _
        "no IS NULL) AND (use_cost = @Original_use_cost OR @Original_use_cost IS NULL AND" & _
        " use_cost IS NULL)"
        Me.SqlDeleteCommand20.Connection = Me.CnnSql
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_avg_time", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "avg_time", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bay_no", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bay_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_charge_shop_supply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "charge_shop_supply", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_days", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "days", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_service", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ext_desc", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ext_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_miles", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "miles", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reminder", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reminder", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_require_technician", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "require_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_schedule", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "schedule", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_category", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_category", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_b_t_d_v_r", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_b_t_d_v_r", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_use_avg_time", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "use_avg_time", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_use_bay_no", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "use_bay_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_use_cost", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "use_cost", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand21
        '
        Me.SqlInsertCommand21.CommandText = "INSERT INTO inv_tab_labor_service(cod_service, desc_service, ext_desc, service_ty" & _
        "pe, service_category, cost, use_cost, taxable, require_technician, charge_shop_s" & _
        "upply, schedule, avg_time, use_avg_time, bay_no, use_bay_no, reminder, miles, da" & _
        "ys, type_b_t_d_v_r) VALUES (@cod_service, @desc_service, @ext_desc, @service_typ" & _
        "e, @service_category, @cost, @use_cost, @taxable, @require_technician, @charge_s" & _
        "hop_supply, @schedule, @avg_time, @use_avg_time, @bay_no, @use_bay_no, @reminder" & _
        ", @miles, @days, @type_b_t_d_v_r); SELECT cod_service, desc_service, ext_desc, s" & _
        "ervice_type, service_category, cost, use_cost, taxable, require_technician, char" & _
        "ge_shop_supply, schedule, avg_time, use_avg_time, bay_no, use_bay_no, reminder, " & _
        "miles, days, type_b_t_d_v_r FROM inv_tab_labor_service WHERE (cod_service = @cod" & _
        "_service)"
        Me.SqlInsertCommand21.Connection = Me.CnnSql
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_service", System.Data.SqlDbType.VarChar, 50, "desc_service"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ext_desc", System.Data.SqlDbType.VarChar, 100, "ext_desc"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_cost", System.Data.SqlDbType.Bit, 1, "use_cost"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@require_technician", System.Data.SqlDbType.Bit, 1, "require_technician"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@charge_shop_supply", System.Data.SqlDbType.Bit, 1, "charge_shop_supply"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@schedule", System.Data.SqlDbType.Bit, 1, "schedule"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@avg_time", System.Data.SqlDbType.Real, 4, "avg_time"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_avg_time", System.Data.SqlDbType.Bit, 1, "use_avg_time"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bay_no", System.Data.SqlDbType.SmallInt, 2, "bay_no"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_bay_no", System.Data.SqlDbType.Bit, 1, "use_bay_no"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reminder", System.Data.SqlDbType.Bit, 1, "reminder"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@miles", System.Data.SqlDbType.Real, 4, "miles"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@days", System.Data.SqlDbType.Real, 4, "days"))
        Me.SqlInsertCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_b_t_d_v_r", System.Data.SqlDbType.VarChar, 1, "type_b_t_d_v_r"))
        '
        'SqlSelectCommand22
        '
        Me.SqlSelectCommand22.CommandText = "SELECT cod_service, desc_service, ext_desc, service_type, service_category, cost," & _
        " use_cost, taxable, require_technician, charge_shop_supply, schedule, avg_time, " & _
        "use_avg_time, bay_no, use_bay_no, reminder, miles, days, type_b_t_d_v_r FROM inv" & _
        "_tab_labor_service"
        Me.SqlSelectCommand22.Connection = Me.CnnSql
        '
        'SqlUpdateCommand21
        '
        Me.SqlUpdateCommand21.CommandText = "UPDATE inv_tab_labor_service SET cod_service = @cod_service, desc_service = @desc" & _
        "_service, ext_desc = @ext_desc, service_type = @service_type, service_category =" & _
        " @service_category, cost = @cost, use_cost = @use_cost, taxable = @taxable, requ" & _
        "ire_technician = @require_technician, charge_shop_supply = @charge_shop_supply, " & _
        "schedule = @schedule, avg_time = @avg_time, use_avg_time = @use_avg_time, bay_no" & _
        " = @bay_no, use_bay_no = @use_bay_no, reminder = @reminder, miles = @miles, days" & _
        " = @days, type_b_t_d_v_r = @type_b_t_d_v_r WHERE (cod_service = @Original_cod_se" & _
        "rvice) AND (avg_time = @Original_avg_time OR @Original_avg_time IS NULL AND avg_" & _
        "time IS NULL) AND (bay_no = @Original_bay_no OR @Original_bay_no IS NULL AND bay" & _
        "_no IS NULL) AND (charge_shop_supply = @Original_charge_shop_supply OR @Original" & _
        "_charge_shop_supply IS NULL AND charge_shop_supply IS NULL) AND (cost = @Origina" & _
        "l_cost OR @Original_cost IS NULL AND cost IS NULL) AND (days = @Original_days OR" & _
        " @Original_days IS NULL AND days IS NULL) AND (desc_service = @Original_desc_ser" & _
        "vice OR @Original_desc_service IS NULL AND desc_service IS NULL) AND (ext_desc =" & _
        " @Original_ext_desc OR @Original_ext_desc IS NULL AND ext_desc IS NULL) AND (mil" & _
        "es = @Original_miles OR @Original_miles IS NULL AND miles IS NULL) AND (reminder" & _
        " = @Original_reminder OR @Original_reminder IS NULL AND reminder IS NULL) AND (r" & _
        "equire_technician = @Original_require_technician OR @Original_require_technician" & _
        " IS NULL AND require_technician IS NULL) AND (schedule = @Original_schedule OR @" & _
        "Original_schedule IS NULL AND schedule IS NULL) AND (service_category = @Origina" & _
        "l_service_category OR @Original_service_category IS NULL AND service_category IS" & _
        " NULL) AND (service_type = @Original_service_type OR @Original_service_type IS N" & _
        "ULL AND service_type IS NULL) AND (taxable = @Original_taxable OR @Original_taxa" & _
        "ble IS NULL AND taxable IS NULL) AND (type_b_t_d_v_r = @Original_type_b_t_d_v_r " & _
        "OR @Original_type_b_t_d_v_r IS NULL AND type_b_t_d_v_r IS NULL) AND (use_avg_tim" & _
        "e = @Original_use_avg_time OR @Original_use_avg_time IS NULL AND use_avg_time IS" & _
        " NULL) AND (use_bay_no = @Original_use_bay_no OR @Original_use_bay_no IS NULL AN" & _
        "D use_bay_no IS NULL) AND (use_cost = @Original_use_cost OR @Original_use_cost I" & _
        "S NULL AND use_cost IS NULL); SELECT cod_service, desc_service, ext_desc, servic" & _
        "e_type, service_category, cost, use_cost, taxable, require_technician, charge_sh" & _
        "op_supply, schedule, avg_time, use_avg_time, bay_no, use_bay_no, reminder, miles" & _
        ", days, type_b_t_d_v_r FROM inv_tab_labor_service WHERE (cod_service = @cod_serv" & _
        "ice)"
        Me.SqlUpdateCommand21.Connection = Me.CnnSql
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_service", System.Data.SqlDbType.VarChar, 50, "desc_service"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ext_desc", System.Data.SqlDbType.VarChar, 100, "ext_desc"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_cost", System.Data.SqlDbType.Bit, 1, "use_cost"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@require_technician", System.Data.SqlDbType.Bit, 1, "require_technician"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@charge_shop_supply", System.Data.SqlDbType.Bit, 1, "charge_shop_supply"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@schedule", System.Data.SqlDbType.Bit, 1, "schedule"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@avg_time", System.Data.SqlDbType.Real, 4, "avg_time"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_avg_time", System.Data.SqlDbType.Bit, 1, "use_avg_time"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bay_no", System.Data.SqlDbType.SmallInt, 2, "bay_no"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_bay_no", System.Data.SqlDbType.Bit, 1, "use_bay_no"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reminder", System.Data.SqlDbType.Bit, 1, "reminder"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@miles", System.Data.SqlDbType.Real, 4, "miles"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@days", System.Data.SqlDbType.Real, 4, "days"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_b_t_d_v_r", System.Data.SqlDbType.VarChar, 1, "type_b_t_d_v_r"))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_avg_time", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "avg_time", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bay_no", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bay_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_charge_shop_supply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "charge_shop_supply", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_days", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "days", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_service", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ext_desc", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ext_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_miles", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "miles", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reminder", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reminder", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_require_technician", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "require_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_schedule", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "schedule", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_category", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_category", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_b_t_d_v_r", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_b_t_d_v_r", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_use_avg_time", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "use_avg_time", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_use_bay_no", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "use_bay_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_use_cost", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "use_cost", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvTabLaborServicePrice
        '
        Me.daInvTabLaborServicePrice.DeleteCommand = Me.SqlDeleteCommand21
        Me.daInvTabLaborServicePrice.InsertCommand = Me.SqlInsertCommand22
        Me.daInvTabLaborServicePrice.SelectCommand = Me.SqlSelectCommand23
        Me.daInvTabLaborServicePrice.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service_price", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_price_labor_service", "id_price_labor_service"), New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("price_rate", "price_rate"), New System.Data.Common.DataColumnMapping("price_level1", "price_level1"), New System.Data.Common.DataColumnMapping("price_level2", "price_level2"), New System.Data.Common.DataColumnMapping("price_level3", "price_level3"), New System.Data.Common.DataColumnMapping("price_level4", "price_level4"), New System.Data.Common.DataColumnMapping("price_level5", "price_level5"), New System.Data.Common.DataColumnMapping("price_level6", "price_level6")})})
        Me.daInvTabLaborServicePrice.UpdateCommand = Me.SqlUpdateCommand22
        '
        'SqlDeleteCommand21
        '
        Me.SqlDeleteCommand21.CommandText = "DELETE FROM inv_tab_labor_service_price WHERE (id_price_labor_service = @Original" & _
        "_id_price_labor_service) AND (cod_service = @Original_cod_service) AND (price_le" & _
        "vel1 = @Original_price_level1 OR @Original_price_level1 IS NULL AND price_level1" & _
        " IS NULL) AND (price_level2 = @Original_price_level2 OR @Original_price_level2 I" & _
        "S NULL AND price_level2 IS NULL) AND (price_level3 = @Original_price_level3 OR @" & _
        "Original_price_level3 IS NULL AND price_level3 IS NULL) AND (price_level4 = @Ori" & _
        "ginal_price_level4 OR @Original_price_level4 IS NULL AND price_level4 IS NULL) A" & _
        "ND (price_level5 = @Original_price_level5 OR @Original_price_level5 IS NULL AND " & _
        "price_level5 IS NULL) AND (price_level6 = @Original_price_level6 OR @Original_pr" & _
        "ice_level6 IS NULL AND price_level6 IS NULL) AND (price_rate = @Original_price_r" & _
        "ate OR @Original_price_rate IS NULL AND price_rate IS NULL) AND (style = @Origin" & _
        "al_style OR @Original_style IS NULL AND style IS NULL)"
        Me.SqlDeleteCommand21.Connection = Me.CnnSql
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_price_labor_service", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_price_labor_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level1", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level2", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level3", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level4", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level5", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level6", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_rate", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_rate", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_style", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand22
        '
        Me.SqlInsertCommand22.CommandText = "INSERT INTO inv_tab_labor_service_price(cod_service, style, price_rate, price_lev" & _
        "el1, price_level2, price_level3, price_level4, price_level5, price_level6) VALUE" & _
        "S (@cod_service, @style, @price_rate, @price_level1, @price_level2, @price_level" & _
        "3, @price_level4, @price_level5, @price_level6); SELECT id_price_labor_service, " & _
        "cod_service, style, price_rate, price_level1, price_level2, price_level3, price_" & _
        "level4, price_level5, price_level6 FROM inv_tab_labor_service_price WHERE (id_pr" & _
        "ice_labor_service = @@IDENTITY)"
        Me.SqlInsertCommand22.Connection = Me.CnnSql
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 2, "style"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_rate", System.Data.SqlDbType.Money, 8, "price_rate"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level1", System.Data.SqlDbType.Money, 8, "price_level1"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level2", System.Data.SqlDbType.Money, 8, "price_level2"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level3", System.Data.SqlDbType.Money, 8, "price_level3"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level4", System.Data.SqlDbType.Money, 8, "price_level4"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level5", System.Data.SqlDbType.Money, 8, "price_level5"))
        Me.SqlInsertCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level6", System.Data.SqlDbType.Money, 8, "price_level6"))
        '
        'SqlSelectCommand23
        '
        Me.SqlSelectCommand23.CommandText = "SELECT id_price_labor_service, cod_service, style, price_rate, price_level1, pric" & _
        "e_level2, price_level3, price_level4, price_level5, price_level6 FROM inv_tab_la" & _
        "bor_service_price"
        Me.SqlSelectCommand23.Connection = Me.CnnSql
        '
        'SqlUpdateCommand22
        '
        Me.SqlUpdateCommand22.CommandText = "UPDATE inv_tab_labor_service_price SET cod_service = @cod_service, style = @style" & _
        ", price_rate = @price_rate, price_level1 = @price_level1, price_level2 = @price_" & _
        "level2, price_level3 = @price_level3, price_level4 = @price_level4, price_level5" & _
        " = @price_level5, price_level6 = @price_level6 WHERE (id_price_labor_service = @" & _
        "Original_id_price_labor_service) AND (cod_service = @Original_cod_service) AND (" & _
        "price_level1 = @Original_price_level1 OR @Original_price_level1 IS NULL AND pric" & _
        "e_level1 IS NULL) AND (price_level2 = @Original_price_level2 OR @Original_price_" & _
        "level2 IS NULL AND price_level2 IS NULL) AND (price_level3 = @Original_price_lev" & _
        "el3 OR @Original_price_level3 IS NULL AND price_level3 IS NULL) AND (price_level" & _
        "4 = @Original_price_level4 OR @Original_price_level4 IS NULL AND price_level4 IS" & _
        " NULL) AND (price_level5 = @Original_price_level5 OR @Original_price_level5 IS N" & _
        "ULL AND price_level5 IS NULL) AND (price_level6 = @Original_price_level6 OR @Ori" & _
        "ginal_price_level6 IS NULL AND price_level6 IS NULL) AND (price_rate = @Original" & _
        "_price_rate OR @Original_price_rate IS NULL AND price_rate IS NULL) AND (style =" & _
        " @Original_style OR @Original_style IS NULL AND style IS NULL); SELECT id_price_" & _
        "labor_service, cod_service, style, price_rate, price_level1, price_level2, price" & _
        "_level3, price_level4, price_level5, price_level6 FROM inv_tab_labor_service_pri" & _
        "ce WHERE (id_price_labor_service = @id_price_labor_service)"
        Me.SqlUpdateCommand22.Connection = Me.CnnSql
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 2, "style"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_rate", System.Data.SqlDbType.Money, 8, "price_rate"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level1", System.Data.SqlDbType.Money, 8, "price_level1"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level2", System.Data.SqlDbType.Money, 8, "price_level2"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level3", System.Data.SqlDbType.Money, 8, "price_level3"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level4", System.Data.SqlDbType.Money, 8, "price_level4"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level5", System.Data.SqlDbType.Money, 8, "price_level5"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level6", System.Data.SqlDbType.Money, 8, "price_level6"))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_price_labor_service", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_price_labor_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level1", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level2", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level3", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level4", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level5", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_level6", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_level6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_rate", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_rate", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_style", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_price_labor_service", System.Data.SqlDbType.SmallInt, 2, "id_price_labor_service"))
        '
        'daInvTabServiceType
        '
        Me.daInvTabServiceType.SelectCommand = Me.SqlSelectCommand24
        Me.daInvTabServiceType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_service_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_type_desc", "service_type_desc")})})
        '
        'SqlSelectCommand24
        '
        Me.SqlSelectCommand24.CommandText = "SELECT service_type, service_type_desc FROM inv_tab_service_type"
        Me.SqlSelectCommand24.Connection = Me.CnnSql
        '
        'SqlSelectCommand25
        '
        Me.SqlSelectCommand25.CommandText = "SELECT ID_payment, id_service_center, refrence_no, refer_type, payment_type, paym" & _
        "ent_amount, flag_deposit_bank, id_GL_journal FROM GL_payment_deposit"
        Me.SqlSelectCommand25.Connection = Me.CnnSql
        '
        'SqlInsertCommand23
        '
        Me.SqlInsertCommand23.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount, flag_deposit_bank, id_GL_journal) VALUES (@id_service_ce" & _
        "nter, @refrence_no, @refer_type, @payment_type, @payment_amount, @flag_deposit_b" & _
        "ank, @id_GL_journal); SELECT ID_payment, id_service_center, refrence_no, refer_t" & _
        "ype, payment_type, payment_amount, flag_deposit_bank, id_GL_journal FROM GL_paym" & _
        "ent_deposit WHERE (ID_payment = @@IDENTITY)"
        Me.SqlInsertCommand23.Connection = Me.CnnSql
        Me.SqlInsertCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlInsertCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlInsertCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlInsertCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlInsertCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@flag_deposit_bank", System.Data.SqlDbType.Bit, 1, "flag_deposit_bank"))
        Me.SqlInsertCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        '
        'SqlUpdateCommand23
        '
        Me.SqlUpdateCommand23.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
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
        Me.SqlUpdateCommand23.Connection = Me.CnnSql
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@flag_deposit_bank", System.Data.SqlDbType.Bit, 1, "flag_deposit_bank"))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_flag_deposit_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "flag_deposit_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand23.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlDeleteCommand22
        '
        Me.SqlDeleteCommand22.CommandText = "DELETE FROM GL_payment_deposit WHERE (ID_payment = @Original_ID_payment) AND (fla" & _
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
        Me.SqlDeleteCommand22.Connection = Me.CnnSql
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_flag_deposit_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "flag_deposit_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand22.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'daGlPaymentDeposit
        '
        Me.daGlPaymentDeposit.DeleteCommand = Me.SqlDeleteCommand22
        Me.daGlPaymentDeposit.InsertCommand = Me.SqlInsertCommand23
        Me.daGlPaymentDeposit.SelectCommand = Me.SqlSelectCommand25
        Me.daGlPaymentDeposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        Me.daGlPaymentDeposit.UpdateCommand = Me.SqlUpdateCommand23
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT item_no, cod_warehouse, cod_location, on_hand, comitted, on_order, min_sto" & _
        "ck, max_stock, reorde, Begining_Balance_Qty FROM inv_tab_item_warehouse"
        Me.SqlSelectCommand2.Connection = Me.CnnSql
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO inv_tab_item_warehouse(item_no, cod_warehouse, cod_location, on_hand," & _
        " comitted, on_order, min_stock, max_stock, reorde, Begining_Balance_Qty) VALUES " & _
        "(@item_no, @cod_warehouse, @cod_location, @on_hand, @comitted, @on_order, @min_s" & _
        "tock, @max_stock, @reorde, @Begining_Balance_Qty); SELECT item_no, cod_warehouse" & _
        ", cod_location, on_hand, comitted, on_order, min_stock, max_stock, reorde, Begin" & _
        "ing_Balance_Qty FROM inv_tab_item_warehouse WHERE (cod_warehouse = @cod_warehous" & _
        "e) AND (item_no = @item_no)"
        Me.SqlInsertCommand2.Connection = Me.CnnSql
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_warehouse", System.Data.SqlDbType.VarChar, 1, "cod_warehouse"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 6, "cod_location"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hand", System.Data.SqlDbType.Real, 4, "on_hand"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comitted", System.Data.SqlDbType.Real, 4, "comitted"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_order", System.Data.SqlDbType.Real, 4, "on_order"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, "Begining_Balance_Qty"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE inv_tab_item_warehouse SET item_no = @item_no, cod_warehouse = @cod_wareho" & _
        "use, cod_location = @cod_location, on_hand = @on_hand, comitted = @comitted, on_" & _
        "order = @on_order, min_stock = @min_stock, max_stock = @max_stock, reorde = @reo" & _
        "rde, Begining_Balance_Qty = @Begining_Balance_Qty WHERE (cod_warehouse = @Origin" & _
        "al_cod_warehouse) AND (item_no = @Original_item_no) AND (Begining_Balance_Qty = " & _
        "@Original_Begining_Balance_Qty OR @Original_Begining_Balance_Qty IS NULL AND Beg" & _
        "ining_Balance_Qty IS NULL) AND (cod_location = @Original_cod_location OR @Origin" & _
        "al_cod_location IS NULL AND cod_location IS NULL) AND (comitted = @Original_comi" & _
        "tted OR @Original_comitted IS NULL AND comitted IS NULL) AND (max_stock = @Origi" & _
        "nal_max_stock OR @Original_max_stock IS NULL AND max_stock IS NULL) AND (min_sto" & _
        "ck = @Original_min_stock OR @Original_min_stock IS NULL AND min_stock IS NULL) A" & _
        "ND (on_hand = @Original_on_hand OR @Original_on_hand IS NULL AND on_hand IS NULL" & _
        ") AND (on_order = @Original_on_order OR @Original_on_order IS NULL AND on_order " & _
        "IS NULL) AND (reorde = @Original_reorde OR @Original_reorde IS NULL AND reorde I" & _
        "S NULL); SELECT item_no, cod_warehouse, cod_location, on_hand, comitted, on_orde" & _
        "r, min_stock, max_stock, reorde, Begining_Balance_Qty FROM inv_tab_item_warehous" & _
        "e WHERE (cod_warehouse = @cod_warehouse) AND (item_no = @item_no)"
        Me.SqlUpdateCommand2.Connection = Me.CnnSql
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_warehouse", System.Data.SqlDbType.VarChar, 1, "cod_warehouse"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 6, "cod_location"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hand", System.Data.SqlDbType.Real, 4, "on_hand"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comitted", System.Data.SqlDbType.Real, 4, "comitted"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_order", System.Data.SqlDbType.Real, 4, "on_order"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, "Begining_Balance_Qty"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_warehouse", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_warehouse", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Begining_Balance_Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_location", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_location", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comitted", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comitted", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_hand", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_hand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_order", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_order", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reorde", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reorde", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM inv_tab_item_warehouse WHERE (cod_warehouse = @Original_cod_warehouse" & _
        ") AND (item_no = @Original_item_no) AND (Begining_Balance_Qty = @Original_Begini" & _
        "ng_Balance_Qty OR @Original_Begining_Balance_Qty IS NULL AND Begining_Balance_Qt" & _
        "y IS NULL) AND (cod_location = @Original_cod_location OR @Original_cod_location " & _
        "IS NULL AND cod_location IS NULL) AND (comitted = @Original_comitted OR @Origina" & _
        "l_comitted IS NULL AND comitted IS NULL) AND (max_stock = @Original_max_stock OR" & _
        " @Original_max_stock IS NULL AND max_stock IS NULL) AND (min_stock = @Original_m" & _
        "in_stock OR @Original_min_stock IS NULL AND min_stock IS NULL) AND (on_hand = @O" & _
        "riginal_on_hand OR @Original_on_hand IS NULL AND on_hand IS NULL) AND (on_order " & _
        "= @Original_on_order OR @Original_on_order IS NULL AND on_order IS NULL) AND (re" & _
        "orde = @Original_reorde OR @Original_reorde IS NULL AND reorde IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.CnnSql
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_warehouse", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_warehouse", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Begining_Balance_Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_location", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_location", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comitted", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comitted", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_hand", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_hand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_order", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_order", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reorde", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reorde", System.Data.DataRowVersion.Original, Nothing))
        '
        'daInvTabItemWarehouse
        '
        Me.daInvTabItemWarehouse.DeleteCommand = Me.SqlDeleteCommand2
        Me.daInvTabItemWarehouse.InsertCommand = Me.SqlInsertCommand2
        Me.daInvTabItemWarehouse.SelectCommand = Me.SqlSelectCommand2
        Me.daInvTabItemWarehouse.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_item_warehouse", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("cod_location", "cod_location"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("comitted", "comitted"), New System.Data.Common.DataColumnMapping("on_order", "on_order"), New System.Data.Common.DataColumnMapping("min_stock", "min_stock"), New System.Data.Common.DataColumnMapping("max_stock", "max_stock"), New System.Data.Common.DataColumnMapping("reorde", "reorde"), New System.Data.Common.DataColumnMapping("Begining_Balance_Qty", "Begining_Balance_Qty")})})
        Me.daInvTabItemWarehouse.UpdateCommand = Me.SqlUpdateCommand2
        '
        'ItemsConvert
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(578, 88)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ItemsConvert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items Convert"
        CType(Me.dsItems1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FilePath As String
    Dim ODBCSelect As New System.Data.Odbc.OdbcCommand
    Dim dsitem2 As New dsItems
    Private Sub ItemsConvert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CnnSql.ConnectionString = PConnectionString
        Cmdpublic.Connection = CnnSql
        FixthisDatabase()
    End Sub
    Private Sub txtPath_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPath.ButtonClick
        FolderBrowserDialog1.ShowDialog()
        txtPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim ZipCode As Object
        FilePath = txtPath.Text.Trim
        If FilePath = "" Then
            MsgBox("Please select path of your exel Files")
            Exit Sub
        End If
        lblWait.Visible = True
        Me.Refresh()
        Try
            Try
                CnnExcelFile.ConnectionString = "DRIVER=Microsoft Excel Driver (*.xls); DBQ=" & FilePath & "\ARBALANCE.xls"
                daArBalance_xls.SelectCommand = ODBCSelect
                ODBCSelect.Connection = CnnExcelFile
                dsItems1.ArBalance.Clear()
                ODBCSelect.CommandText = "SELECT Customer, `Customer Name`, `Net Due`, `DUE DATE` " & _
                                         "FROM Arbalance WHERE Customer Is Not Null"
                daArBalance_xls.Fill(dsItems1.ArBalance)
            Catch ex As Exception
                MsgBox("error in file " & FilePath & "\ARBALANCE.xls" & vbCrLf & "Please check it")
            End Try



            'From Excel File ITQTY01.xls
            Try
                CnnExcelFile.ConnectionString = "DRIVER=Microsoft Excel Driver (*.xls); DBQ=" & FilePath & "\ITQTY01.xls"
                daITQty_xls.SelectCommand = ODBCSelect
                ODBCSelect.Connection = CnnExcelFile
                dsItems1.ITQty.Clear()
                ODBCSelect.CommandText = "SELECT `Item No`, DESCRIPTION, LOCATION, QTY FROM ITQty WHERE `Item No` Is Not Null"
                daITQty_xls.Fill(dsItems1.ITQty)
            Catch ex As Exception
                MsgBox("error in file " & FilePath & "\ITQTY01.xls" & vbCrLf & "Please check it")
            End Try



            dsItems1.Temp.Clear()
            dsItems1.cust_trtab_main.Clear()
            dsItems1.GL_payment_AR.Clear()
            dsItems1.GL_payment_deposit.Clear()
            dsItems1.service_center_dtl.Clear()
            dsItems1.service_center_head.Clear()
            dsItems1.inv_item_cost_transaction.Clear()
            dsItems1.inv_price_code.Clear()
            dsItems1.inv_item_vendor.Clear()
            dsItems1.inv_tab_item_warehouse.Clear()
            dsItems1.inv_discount_item.Clear()
            dsItems1.inv_item.Clear()
            dsItems1.inv_tab_type_item.Clear()
            dsItems1.inv_tab_line.Clear()
            dsItems1.inv_tab_brand.Clear()
            dsItems1.inv_tab_style.Clear()
            dsItems1.inv_tab_public.Clear()
            dsItems1.inv_vendor.Clear()
            dsItems1.inv_tab_vendor_class.Clear()
            dsItems1.inv_tab_vendor_type.Clear()
            dsItems1.inv_item_quick_refrence.Clear()
            dsItems1.bas_zipcode.Clear()
            dsItems1.inv_tab_labor_service_price.Clear()
            dsItems1.inv_tab_labor_service.Clear()
            dsItems1.inv_tab_service_type.Clear()
            dsItems1.inv_itemtemp.Clear()

            '
            daInvItemQuickRefrence.Fill(dsItems1.inv_item_quick_refrence)
            daZipCode.Fill(dsItems1.bas_zipcode)
            daServiceCenterHead.Fill(dsItems1.service_center_head)
            daServiceCenterDtl.Fill(dsItems1.service_center_dtl)
            daGlPaymentDeposit.Fill(dsItems1.GL_payment_deposit)
            daGlPaymentAr.Fill(dsItems1.GL_payment_AR)
            daInvTabPublic.Fill(dsItems1.inv_tab_public)
            daInvTabBrand.Fill(dsItems1.inv_tab_brand)
            daInvTabStyle.Fill(dsItems1.inv_tab_style)
            daInvTabLine.Fill(dsItems1.inv_tab_line)
            daInvTabVendorClass.Fill(dsItems1.inv_tab_vendor_class)
            daInvTabVendorType.Fill(dsItems1.inv_tab_vendor_type)
            daInvVendor.Fill(dsItems1.inv_vendor)
            daInvTabTypeItem.Fill(dsItems1.inv_tab_type_item)
            daInvItem.Fill(dsItems1.inv_item)
            daInvDiscountItem.Fill(dsItems1.inv_discount_item)
            daInvTabItemWarehouse.Fill(dsItems1.inv_tab_item_warehouse)
            daInvItemVendor.Fill(dsItems1.inv_item_vendor)
            daInvPriceCode.Fill(dsItems1.inv_price_code)
            daInvItemCostTransaction.Fill(dsItems1.inv_item_cost_transaction)
            daCusTrTabMain.Fill(dsItems1.cust_trtab_main)
            daInvTabServiceType.Fill(dsItems1.inv_tab_service_type)
            daInvTabLaborService.Fill(dsItems1.inv_tab_labor_service)
            daInvTabLaborServicePrice.Fill(dsItems1.inv_tab_labor_service_price)
            '
            If dsItems1.cust_trtab_main.Count = 0 Then
                MsgBox("Please Convert Customers First ...")
                Exit Sub
            End If
            'Add service_center_head
            Dim DueDate As String = dsItems1.ArBalance.Rows(0).Item("DUE DATE")
            Dim SCH, SchCount As Integer
            Dim CusCode As String
            SchCount = dsItems1.ArBalance.Count
            Dim ID As Integer = 0
            Dim Counter As Integer
            Counter = Math.Ceiling(SchCount * 2 / 100)
            Dim customerfindinbeginbalance As Boolean = False
            '----------------------
            Cmdpublic.Connection = CnnSql
            Cmdpublic.CommandText = "Select max(id_service_center) as max1  from service_center_head Where substring(id_service_center,1,2)='IN'"
            If Cmdpublic.Connection.State <> ConnectionState.Open Then
                Cmdpublic.Connection.Open()
            End If
            Dim max1 As String
            Dim maxidpayment As Long
            Dim Beginnumber As Long

            max1 = Cmdpublic.ExecuteScalar() & ""
            If max1 = "" Then
                Beginnumber = 0
            Else
                Beginnumber = Val(max1.Replace("IN", ""))
            End If

            Cmdpublic.CommandText = "Select max(ID_payment) as max1  from GL_payment_deposit Where substring(id_service_center,1,2)='IN'"

            maxidpayment = Val(Cmdpublic.ExecuteScalar() & "")
            '--------------
            ID = Beginnumber
            '-------------------
            Dim Amount_NetDue As Decimal
            For SCH = 0 To SchCount - 1
                Me.Refresh()
                customerfindinbeginbalance = False
                CusCode = dsItems1.ArBalance.Rows(SCH).Item("Customer")
                Try
                    Amount_NetDue = dsItems1.ArBalance.Rows(SCH).Item("Net Due")
                Catch ex As Exception
                    Amount_NetDue = 0
                End Try
                Dim CusRow As dsItems.cust_trtab_mainRow
                CusRow = dsItems1.cust_trtab_main.FindBycod_customer(CusCode)


                If CusRow Is Nothing Then
                    Dim drTemp As DataRow
                    drTemp = dsItems1.Temp.NewRow
                    drTemp("CusCode") = CusCode
                    drTemp("Name") = dsItems1.ArBalance.Rows(SCH).Item("Customer Name")
                    drTemp("Description") = "Not Found"
                    drtemp("balance") = CDec(Val(Amount_NetDue & ""))
                    dsItems1.Temp.Rows.Add(drTemp)
                Else
                    If Amount_NetDue <= 0 Then
                        Dim drTemp As DataRow
                        drTemp = dsItems1.Temp.NewRow
                        drTemp("CusCode") = CusCode
                        drTemp("Name") = dsItems1.ArBalance.Rows(SCH).Item("Customer Name")
                        drTemp("Description") = "Amount Is Negative or zero"
                        drtemp("balance") = CDec(Val(Amount_NetDue & ""))
                        dsItems1.Temp.Rows.Add(drTemp)
                    Else
                        Dim drSch As dsItems.service_center_headRow '= dsItems1.service_center_head.FindByid_service_center("IN" & Getcod(Str(ID).Trim, 8))    'DataRow
                        Dim dr1() As dsItems.service_center_headRow = dsItems1.service_center_head.Select("cod_customer = " & "'" & CusCode & "' and type_of_form ='IN'  and add_user = 1 and  cust_comment ='Begin Balance'")
                        If dr1.LongLength > 0 Then
                            customerfindinbeginbalance = True
                        Else
                            customerfindinbeginbalance = False
                            ID = ID + 1 '+ Beginnumber
                        End If
                        If Not customerfindinbeginbalance Then
                            drSch = dsItems1.service_center_head.NewRow
                            drSch("id_service_center") = "IN" & Getcod(Str(ID).Trim, 6)
                            drSch("type_of_form") = "IN"
                            drSch("cod_customer") = CusCode
                            drSch("id_vehicle") = System.DBNull.Value
                            drSch("date_refer") = Format(CDate(Calendar.DateUtils.EnToDay), PubDateFormat)
                            drSch("discount") = 0
                            drSch("tax") = 0
                            drSch("house_comment") = System.DBNull.Value
                            drSch("cust_comment") = "Begin Balance"
                            drSch("add_user") = 1
                            drSch("chg_user") = 0
                            drSch("po_no") = System.DBNull.Value
                            drSch("id_service_center_before") = System.DBNull.Value
                            drSch("id_GL_journal") = System.DBNull.Value
                            drSch("Total") = dsItems1.ArBalance.Rows(SCH).Item("Net Due")
                            dsItems1.service_center_head.Rows.Add(drSch)
                        End If
                    End If
                End If
            Next

            'Add service_center_Dtl, GL_Payment_Deposit, GL_payment_AR
            Dim SCD, ScdCount As Integer
            Dim ID_Payment As Integer
            ScdCount = dsItems1.service_center_head.Count
            ' ScdCount = dsItems1.ArBalance.Count
            '----------------------------------------------------
            ID_Payment = maxidpayment
            Dim AddDeposit As Boolean
            For SCD = 0 To ScdCount - 1
                If SCD Mod Counter = 0 Then
                    Me.Refresh()
                End If
                Dim drScd As DataRow
                Dim dr2() As dsItems.service_center_dtlRow = dsItems1.service_center_dtl.Select("id_service_center ='" & dsItems1.service_center_head.Rows(SCD).Item("id_service_center") & "' and radif=1")

                'If Not customerfindinbeginbalance Then
                If dr2.LongLength > 0 Then
                    drScd = dr2(0)  'dsItems1.service_center_dtl.Rows(SCD)
                Else
                    drScd = dsItems1.service_center_dtl.NewRow
                    drScd("id_service_center") = dsItems1.service_center_head.Rows(SCD).Item("id_service_center")
                    drScd("radif") = 1
                End If
                drScd("type_select") = "B"
                drScd("cod_select") = System.DBNull.Value
                drScd("desc_radif") = "Begin Balance Customer"
                drScd("qty") = 1
                drScd("price") = dsItems1.service_center_head.Rows(SCD).Item("Total")
                drScd("fet") = 0
                drScd("taxable") = 0
                drScd("cod_technician") = System.DBNull.Value
                drScd("COMMENT_ARTICLE") = System.DBNull.Value
                drScd("AVERAGE_COST") = 0
                If dr2.LongLength <= 0 Then
                    dsItems1.service_center_dtl.Rows.Add(drScd)
                End If

                'End If
                'GL_Payment_Deposit
                ID_Payment = ID_Payment + 1
                Dim drGld As DataRow
                Dim dr3() As dsItems.GL_payment_depositRow = dsItems1.GL_payment_deposit.Select("id_service_center = '" & dsItems1.service_center_head.Rows(SCD).Item("id_service_center") & "' and payment_type='4'")

                'If Not customerfindinbeginbalance Then
                If dr3.LongLength <= 0 Then
                    drGld = dsItems1.GL_payment_deposit.NewRow
                    drGld("id_service_center") = dsItems1.service_center_head.Rows(SCD).Item("id_service_center")
                    drGld("ID_payment") = ID_Payment
                Else
                    drGld = dr3(0)
                End If
                drGld("refrence_no") = System.DBNull.Value
                drGld("refer_type") = "1"
                drGld("payment_type") = "4"
                drGld("payment_amount") = dsItems1.service_center_head.Rows(SCD).Item("Total")
                drGld("flag_deposit_bank") = 1
                drGld("id_GL_journal") = System.DBNull.Value
                If dr3.LongLength <= 0 Then
                    dsItems1.GL_payment_deposit.Rows.Add(drGld)
                    AddDeposit = True
                End If
                'End If

                'GL_payment_AR
                Dim drGla As dsItems.GL_payment_ARRow = dsItems1.GL_payment_AR.FindByID_payment(ID_Payment)   'DataRow
                Dim flagadd2 As Boolean = False
                '                If Not customerfindinbeginbalance Then
                If drGla Is Nothing Then
                    drGla = dsItems1.GL_payment_AR.NewRow
                    flagadd2 = True
                    drGla("ID_payment") = ID_Payment
                End If
                drGla("AR_terms") = "Net 30    "
                drGla("AR_due_date") = Format(CDate(DueDate), PubDateFormat)
                drGla("Cancel_flag") = 0
                If flagadd2 = True And AddDeposit = True Then
                    dsItems1.GL_payment_AR.Rows.Add(drGla)
                    AddDeposit = False
                    '               End If
                End If
                'End If
            Next
            '--------------------------------------------------------------------------------
            Dim Ven, VenCount As Integer
            VenCount = dsItems1.Vendor.Count
            Dim PhoneNo As Object
            Dim VendorClass, VendorType As Object
            Dim TypeID, ClassID As String
            Dim VendorZip As Object
            Dim drType, drClass As DataRow
            Dim Counter5 As Integer

            Dim TP, TPCount As Integer
            TPCount = dsItems1.ItemsListing.Count
            Dim ID_P As Integer = Val(dsItems1.inv_tab_public.Compute("Max(cod_table_public)", ""))
            Dim SizeFind As Integer
            Dim Counter6 As Integer
            'Add inv_item_quick_refrence
            'From Excel File, Items Listing Duncan Tire.xls
            Dim QF, QFCount, ID_Q As Integer
            'Add inv_Price_Code
            'From Excel File, Price Codes Duncan Tire.xls
            Dim drPrCode As DataRow
            Dim PrCodeCount, I_Pr As Integer
            PrCodeCount = dsItems1.PriceCode.Count
            'Add inv_item
            'From Excel File, Items Listing Duncan Tire.xls

            Dim IT, ITCount
            'ITCount = dsItems1.ItemsListing.Count
            Dim Counter8 As Integer
            Dim ItemNo As String
            Dim FindITQty As Int16
            Dim OnHand As Double
            Dim cod_item_type As Object
            Dim ItemType As Object
            Dim cod_quick_refrence As Object
            Dim QuickRef As Object
            Dim taxable As Object
            Dim line As Object
            Dim DR4 As dsItems.ITQtyRow
            'dsItems1.inv_tab_type_item.DefaultView.Sort = "desc_item_type"
            'dsItems1.inv_item_quick_refrence.DefaultView.Sort = "desc_quick_refrence"
            dsItems1.ITQty.DefaultView.Sort = "Item No"
            Dim TypeRowFind As Int16
            Dim QuickRowFind As Int16
            Dim UpdatedOnHand As Boolean
            Counter8 = Math.Ceiling(ITCount / 100)
            daInvItem.Fill(dsItems1, "a")
            ITCount = dsItems1.Tables("a").Rows.Count
            For IT = 0 To ITCount - 1
                '------------------------------------------------------------------'
                'Add inv_tab_item_warehouse
                'From Excel File, Items Listing Duncan Tire.xls
                UpdatedOnHand = True
                ItemNo = dsItems1.Tables("a").Rows(IT).Item("item_no")
                DR4 = dsItems1.ITQty.FindByItem_No(ItemNo)
                FindITQty = dsItems1.ITQty.DefaultView.Find(ItemNo)

                If DR4 Is Nothing Then
                    OnHand = 0
                    UpdatedOnHand = False
                Else
                    OnHand = DR4.Item("QTY")
                    If OnHand < 0 Then
                        OnHand = 0
                    End If
                End If
                'Dim drIW As DataRow
                Dim drIW As dsItems.inv_tab_item_warehouseRow = dsItems1.inv_tab_item_warehouse.FindByitem_nocod_warehouse(ItemNo, "1")
                Dim flgadditem As Boolean = False
                If drIW Is Nothing Then
                    drIW = dsItems1.inv_tab_item_warehouse.NewRow
                    flgadditem = True
                Else
                    flgadditem = False
                End If
                drIW("item_no") = ItemNo
                drIW("cod_warehouse") = "1"
                If UpdatedOnHand = True Then
                    drIW("on_hand") = OnHand
                    drIW("Begining_Balance_Qty") = OnHand
                End If
                If flgadditem Then
                    dsItems1.inv_tab_item_warehouse.Rows.Add(drIW)
                End If
            Next

            ITCount = dsItems1.ITQty.Rows.Count
            Dim DR5 As DataRow()
            For IT = 0 To ITCount - 1
                ItemNo = dsItems1.ITQty.Rows(IT).Item("item no")
                DR5 = Nothing
                DR5 = dsItems1.Tables("A").Select("Item_No = '" & ItemNo & "'")
                If DR5.LongLength <= 0 Then
                    Dim drTemp As DataRow
                    drTemp = dsItems1.inv_itemtemp.NewRow
                    drTemp("ITEM_NO") = ItemNo
                    drTemp("desc_item") = dsItems1.ITQty.Rows(IT).Item("DESCRIPTION")
                    drTemp("BeginQty") = OnHand
                    dsItems1.inv_itemtemp.Rows.Add(drTemp)
                End If
            Next

            'Update Tables, After Insert Record
            daServiceCenterHead.Update(dsItems1.service_center_head)
            daServiceCenterDtl.Update(dsItems1.service_center_dtl)
            daGlPaymentDeposit.Update(dsItems1.GL_payment_deposit)
            daGlPaymentAr.Update(dsItems1.GL_payment_AR)
            daInvTabItemWarehouse.Update(dsItems1.inv_tab_item_warehouse)

            MsgBox("The convert process has been completed successfully.", MsgBoxStyle.Information, "Convert System")

            If dsItems1.Temp.Count > 0 Then
                Dim frmNoConvert As New frmShowNoConvert
                frmNoConvert.grdShow.DataSource = dsItems1.Temp
                frmNoConvert.LabelText = "Customers List that no convert "
                frmNoConvert.Left = 100
                frmNoConvert.Show()
            End If

            If dsItems1.inv_itemtemp.Count > 0 Then
                Dim frmNoConvert1 As New frmShowNoConvert
                frmNoConvert1.grdShow.DataSource = dsItems1.inv_itemtemp
                frmNoConvert1.grdShow.RetrieveStructure()
                frmNoConvert1.LabelText = "Item List that no convert "
                frmNoConvert1.Left = 200
                frmNoConvert1.Show()
            End If



        Catch ex As System.Data.Odbc.OdbcException
            MsgBox("Path or file name is wrong, Try again ...", MsgBoxStyle.Exclamation, "Error")
        Catch ex As Exception
            MsgBox(ex.ToString + "    " + ex.GetType.ToString + "   ", , "btn Convert")
        Finally
            lblWait.Visible = False
            CnnSql.Close()
        End Try
    End Sub
    Sub FixthisDatabase()
        Cmdpublic.CommandText = "alter  table inv_tab_item_warehouse add Begining_Balance_Qty Real "
        If Cmdpublic.Connection.State <> ConnectionState.Open Then
            Cmdpublic.Connection.Open()
        End If
        Try
            Cmdpublic.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Cmdpublic.CommandText = " update inv_tab_item_warehouse set Begining_Balance_Qty =0 where  Begining_Balance_Qty is null "
        Try
            Cmdpublic.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cmdpublic.Connection.Close()
        End Try


    End Sub
End Class
