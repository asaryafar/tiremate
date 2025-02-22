Imports CommonClass
Public Class FrmSTORESETUP
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim StoreOrderFieldName As String = "StoreNo"
    Friend StoreNoTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public StoreNoVar As String = ""
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
    Friend WithEvents CmGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MSave As System.Windows.Forms.MenuItem
    Friend WithEvents MCancel As System.Windows.Forms.MenuItem
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents PnlKartAmvalField As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents BtnSortOrder As Janus.Windows.EditControls.UIButton
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents License_No1 As UCVehicle.License_No
    Friend WithEvents Command2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Command21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SortByType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UIContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort32 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents LblShortName As System.Windows.Forms.Label
    Friend WithEvents LblStoreName As System.Windows.Forms.Label
    Friend WithEvents CmbStores As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TxtSALES_TAX_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtSTATE_TAX_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtFEDERAL_TAX_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PhoneNo2 As UCPhone.PhoneNo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents EmailAddress1 As EmailAndWebAddress.EmailAddress
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TxtADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents TXTSTORENAME As System.Windows.Forms.TextBox
    Friend WithEvents TxtSTORENO As System.Windows.Forms.TextBox
    Friend WithEvents LblSt As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents LblCity As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents CHKRULES1 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES2 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES3 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES4 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES5 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES6 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES7 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES8 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES9 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES10 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES11 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKRULES12 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents TxtCOUNTY As System.Windows.Forms.TextBox
    Friend WithEvents TxtAREACODE As System.Windows.Forms.TextBox
    Friend WithEvents TxtCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtTECHNISIAN As System.Windows.Forms.TextBox
    Friend WithEvents TxtCASH_CUSTOMER As System.Windows.Forms.TextBox
    Friend WithEvents ChkPRINT_STORENAME_IN As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents NumNO_OF_COPY_INPRINT_IN As CalcUtils.UcCalcText
    Friend WithEvents NumNO_OF_COPY_INPRINT_WO As CalcUtils.UcCalcText
    Friend WithEvents NumNO_OF_COPY_INPRINT_ES As CalcUtils.UcCalcText
    Friend WithEvents NumNO_OF_COPY_INPRINT_ROA As CalcUtils.UcCalcText
    Friend WithEvents NumNO_OF_COPY_INPRINT_PO As CalcUtils.UcCalcText
    Friend WithEvents TxtLABEL_INVOICE_COPY1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDISCLAIMER_FOR_IN As System.Windows.Forms.TextBox
    Friend WithEvents TxtDISCLAIMER_FOR_WO As System.Windows.Forms.TextBox
    Friend WithEvents TxtDISCLAIMER_FOR_ES As System.Windows.Forms.TextBox
    Friend WithEvents TxtWARRANTY_FOR_ES As System.Windows.Forms.TextBox
    Friend WithEvents TxtWARRANTY_FOR_WO As System.Windows.Forms.TextBox
    Friend WithEvents TxtWARRANTY_FOR_IN As System.Windows.Forms.TextBox
    Friend WithEvents TxtLABEL_INVOICE_COPY3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLABEL_INVOICE_COPY2 As System.Windows.Forms.TextBox
    Friend WithEvents CHKFUNCTIONS17 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS16 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS15 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS14 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS13 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS12 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS11 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS10 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS9 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS8 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS7 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS6 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS5 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS4 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS3 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS2 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKFUNCTIONS1 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsFrmSTORESETUP1 As SetupTables.DSFrmSTORESETUP
    Friend WithEvents CmdGeneral As System.Data.OleDb.OleDbCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents ChkPRINT_COMPANYSALESMOTTO_Checks As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYSALESMOTTO_PO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYSALESMOTTO_ROA As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYSALESMOTTO_ES As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYSALESMOTTO_WO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYSALESMOTTO_IN As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYLOGO_Checks As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYLOGO_PO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYLOGO_ROA As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYLOGO_ES As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYLOGO_WO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_COMPANYLOGO_IN As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STOREADDRESS_Checks As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STOREADDRESS_PO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STOREADDRESS_ROA As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STOREADDRESS_ES As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STOREADDRESS_WO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STOREADDRESS_IN As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STORENAME_Checks As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STORENAME_PO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STORENAME_ROA As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STORENAME_ES As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkPRINT_STORENAME_WO As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACust_sales_tax As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmbSALESPERSON As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSALES_TAX As System.Windows.Forms.ComboBox
    Friend WithEvents DAbas_zipcode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmbState As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents CmbInterStorePayableAccount As System.Windows.Forms.ComboBox
    Friend WithEvents CmbInterStoreReceivableAccount As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TxtSqlServerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSqlUserName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSqlUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkEstimatesShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkEstimatesShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkWorkOrdersShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkWorkOrdersShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCustomerReturnsShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCustomerReturnsShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkAccountAdjustmentsShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkAccountAdjustmentsShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInventoryReceiptsShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInventoryReceiptsShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCustomerPaymentsShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCustomerPaymentsShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInventoryReturnsShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInventoryReturnsShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInventoryAdjustmentsShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInventoryAdjustmentsShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkPurchasesOrdersShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkPurchasesOrdersShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInvoicesShadingNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkInvoicesShadingYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneralForMDB As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSTORESETUP))
        Me.CmGeneral = New System.Windows.Forms.ContextMenu
        Me.MAddNew = New System.Windows.Forms.MenuItem
        Me.MEdit = New System.Windows.Forms.MenuItem
        Me.MDelete = New System.Windows.Forms.MenuItem
        Me.MSave = New System.Windows.Forms.MenuItem
        Me.MCancel = New System.Windows.Forms.MenuItem
        Me.MFirstRecord = New System.Windows.Forms.MenuItem
        Me.MPreviousRecord = New System.Windows.Forms.MenuItem
        Me.MNextRecord = New System.Windows.Forms.MenuItem
        Me.MLastRecord = New System.Windows.Forms.MenuItem
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.LblShortName = New System.Windows.Forms.Label
        Me.LblStoreName = New System.Windows.Forms.Label
        Me.CmbStores = New System.Windows.Forms.ComboBox
        Me.DsFrmSTORESETUP1 = New SetupTables.DSFrmSTORESETUP
        Me.Label17 = New System.Windows.Forms.Label
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TxtShortName = New System.Windows.Forms.TextBox
        Me.TxtSALES_TAX_ID = New System.Windows.Forms.TextBox
        Me.TxtSTATE_TAX_ID = New System.Windows.Forms.TextBox
        Me.TxtFEDERAL_TAX_ID = New System.Windows.Forms.TextBox
        Me.TxtADDRESS = New System.Windows.Forms.TextBox
        Me.TXTSTORENAME = New System.Windows.Forms.TextBox
        Me.TxtSTORENO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PhoneNo2 = New UCPhone.PhoneNo
        Me.Label1 = New System.Windows.Forms.Label
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.LblSt = New Janus.Windows.GridEX.EditControls.EditBox
        Me.LblCity = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.EmailAddress1 = New EmailAndWebAddress.EmailAddress
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CHKRULES12 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES11 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES10 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES9 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES8 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES7 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES6 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES5 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES4 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES3 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES2 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKRULES1 = New Janus.Windows.EditControls.UICheckBox
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.TxtWARRANTY_FOR_ES = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.TxtWARRANTY_FOR_WO = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.TxtWARRANTY_FOR_IN = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.TxtDISCLAIMER_FOR_ES = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.TxtDISCLAIMER_FOR_WO = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.TxtDISCLAIMER_FOR_IN = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CHKFUNCTIONS17 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS16 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS15 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS14 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS13 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS12 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS11 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS10 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS9 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS8 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS7 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS6 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS5 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS4 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS3 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS2 = New Janus.Windows.EditControls.UICheckBox
        Me.CHKFUNCTIONS1 = New Janus.Windows.EditControls.UICheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.CmbInterStorePayableAccount = New System.Windows.Forms.ComboBox
        Me.CmbInterStoreReceivableAccount = New System.Windows.Forms.ComboBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.CmbState = New System.Windows.Forms.ComboBox
        Me.cmbSALESPERSON = New System.Windows.Forms.ComboBox
        Me.cmbSALES_TAX = New System.Windows.Forms.ComboBox
        Me.TxtCASH_CUSTOMER = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtTECHNISIAN = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtCity = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtAREACODE = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtCOUNTY = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.TxtSqlUserPassword = New System.Windows.Forms.TextBox
        Me.TxtSqlUserName = New System.Windows.Forms.TextBox
        Me.TxtSqlServerName = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.ChkInvoicesShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkInvoicesShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.ChkPurchasesOrdersShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkPurchasesOrdersShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.ChkInventoryAdjustmentsShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkInventoryAdjustmentsShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.ChkInventoryReturnsShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkInventoryReturnsShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ChkCustomerPaymentsShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkCustomerPaymentsShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ChkInventoryReceiptsShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkInventoryReceiptsShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ChkAccountAdjustmentsShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkAccountAdjustmentsShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ChkCustomerReturnsShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkCustomerReturnsShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChkWorkOrdersShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkWorkOrdersShadingYes = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChkEstimatesShadingNo = New System.Windows.Forms.RadioButton
        Me.ChkEstimatesShadingYes = New System.Windows.Forms.RadioButton
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.TxtLABEL_INVOICE_COPY3 = New System.Windows.Forms.TextBox
        Me.TxtLABEL_INVOICE_COPY2 = New System.Windows.Forms.TextBox
        Me.TxtLABEL_INVOICE_COPY1 = New System.Windows.Forms.TextBox
        Me.NumNO_OF_COPY_INPRINT_PO = New CalcUtils.UcCalcText
        Me.NumNO_OF_COPY_INPRINT_ROA = New CalcUtils.UcCalcText
        Me.NumNO_OF_COPY_INPRINT_ES = New CalcUtils.UcCalcText
        Me.NumNO_OF_COPY_INPRINT_WO = New CalcUtils.UcCalcText
        Me.NumNO_OF_COPY_INPRINT_IN = New CalcUtils.UcCalcText
        Me.ChkPRINT_COMPANYSALESMOTTO_Checks = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYSALESMOTTO_PO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYSALESMOTTO_ROA = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYSALESMOTTO_ES = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYSALESMOTTO_WO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYSALESMOTTO_IN = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYLOGO_Checks = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYLOGO_PO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYLOGO_ROA = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYLOGO_ES = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYLOGO_WO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_COMPANYLOGO_IN = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STOREADDRESS_Checks = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STOREADDRESS_PO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STOREADDRESS_ROA = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STOREADDRESS_ES = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STOREADDRESS_WO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STOREADDRESS_IN = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STORENAME_Checks = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STORENAME_PO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STORENAME_ROA = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STORENAME_ES = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STORENAME_WO = New Janus.Windows.EditControls.UICheckBox
        Me.ChkPRINT_STORENAME_IN = New Janus.Windows.EditControls.UICheckBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label44 = New System.Windows.Forms.Label
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
        Me.UIContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort1 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort2 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort32 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort11 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort21 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort31 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Label40 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label41 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.SortByType1 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.Command2 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Command21 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMDB = New System.Data.OleDb.OleDbConnection
        Me.CmdGeneral = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DACust_sales_tax = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_zipcode = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneralForMDB = New System.Data.OleDb.OleDbCommand
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmSTORESETUP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmGeneral
        '
        Me.CmGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MAddNew, Me.MEdit, Me.MDelete, Me.MSave, Me.MCancel, Me.MFirstRecord, Me.MPreviousRecord, Me.MNextRecord, Me.MLastRecord})
        Me.CmGeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'MAddNew
        '
        Me.MAddNew.Index = 0
        Me.MAddNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MAddNew.Text = "«ÌÃ«œ"
        '
        'MEdit
        '
        Me.MEdit.Index = 1
        Me.MEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MEdit.Text = "«’·«Õ"
        '
        'MDelete
        '
        Me.MDelete.Index = 2
        Me.MDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MDelete.Text = "Õ–›"
        '
        'MSave
        '
        Me.MSave.Enabled = False
        Me.MSave.Index = 3
        Me.MSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MSave.Text = "À» "
        '
        'MCancel
        '
        Me.MCancel.Enabled = False
        Me.MCancel.Index = 4
        Me.MCancel.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MCancel.Text = "·€Ê"
        '
        'MFirstRecord
        '
        Me.MFirstRecord.Index = 5
        Me.MFirstRecord.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV
        Me.MFirstRecord.Text = "«» œ«"
        '
        'MPreviousRecord
        '
        Me.MPreviousRecord.Index = 6
        Me.MPreviousRecord.Text = "ﬁ»·Ì"
        '
        'MNextRecord
        '
        Me.MNextRecord.Index = 7
        Me.MNextRecord.Text = "»⁄œÌ"
        '
        'MLastRecord
        '
        Me.MLastRecord.Index = 8
        Me.MLastRecord.Text = "«‰ Â«"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.LblShortName)
        Me.PnlSearch.Controls.Add(Me.LblStoreName)
        Me.PnlSearch.Controls.Add(Me.CmbStores)
        Me.PnlSearch.Controls.Add(Me.Label17)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(599, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'LblShortName
        '
        Me.LblShortName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblShortName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblShortName.Location = New System.Drawing.Point(458, 1)
        Me.LblShortName.Name = "LblShortName"
        Me.LblShortName.Size = New System.Drawing.Size(133, 21)
        Me.LblShortName.TabIndex = 388
        Me.LblShortName.Text = "LblShortName"
        Me.LblShortName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStoreName
        '
        Me.LblStoreName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblStoreName.Location = New System.Drawing.Point(111, 1)
        Me.LblStoreName.Name = "LblStoreName"
        Me.LblStoreName.Size = New System.Drawing.Size(344, 21)
        Me.LblStoreName.TabIndex = 387
        Me.LblStoreName.Text = "LblCompanyName"
        Me.LblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbStores
        '
        Me.CmbStores.DataSource = Me.DsFrmSTORESETUP1.Store_Setup
        Me.CmbStores.DisplayMember = "STORENO"
        Me.CmbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbStores.Location = New System.Drawing.Point(55, 2)
        Me.CmbStores.Name = "CmbStores"
        Me.CmbStores.Size = New System.Drawing.Size(53, 21)
        Me.CmbStores.TabIndex = 0
        Me.CmbStores.TabStop = False
        Me.CmbStores.ValueMember = "STORENO"
        '
        'DsFrmSTORESETUP1
        '
        Me.DsFrmSTORESETUP1.DataSetName = "DSFrmSTORESETUP"
        Me.DsFrmSTORESETUP1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(4, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 19)
        Me.Label17.TabIndex = 386
        Me.Label17.Text = "Store No"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.TabControl1)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(599, 298)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(9, 18)
        Me.TabControl1.Location = New System.Drawing.Point(7, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(585, 288)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxtShortName)
        Me.TabPage1.Controls.Add(Me.TxtSALES_TAX_ID)
        Me.TabPage1.Controls.Add(Me.TxtSTATE_TAX_ID)
        Me.TabPage1.Controls.Add(Me.TxtFEDERAL_TAX_ID)
        Me.TabPage1.Controls.Add(Me.TxtADDRESS)
        Me.TabPage1.Controls.Add(Me.TXTSTORENAME)
        Me.TabPage1.Controls.Add(Me.TxtSTORENO)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.PhoneNo2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ZipCode1)
        Me.TabPage1.Controls.Add(Me.LblSt)
        Me.TabPage1.Controls.Add(Me.LblCity)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.PhoneNo1)
        Me.TabPage1.Controls.Add(Me.EmailAddress1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(577, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'TxtShortName
        '
        Me.TxtShortName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtShortName.Location = New System.Drawing.Point(269, 8)
        Me.TxtShortName.MaxLength = 20
        Me.TxtShortName.Name = "TxtShortName"
        Me.TxtShortName.Size = New System.Drawing.Size(172, 20)
        Me.TxtShortName.TabIndex = 1
        Me.TxtShortName.Text = ""
        '
        'TxtSALES_TAX_ID
        '
        Me.TxtSALES_TAX_ID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSALES_TAX_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSALES_TAX_ID.Location = New System.Drawing.Point(91, 218)
        Me.TxtSALES_TAX_ID.MaxLength = 20
        Me.TxtSALES_TAX_ID.Name = "TxtSALES_TAX_ID"
        Me.TxtSALES_TAX_ID.Size = New System.Drawing.Size(234, 20)
        Me.TxtSALES_TAX_ID.TabIndex = 10
        Me.TxtSALES_TAX_ID.Text = ""
        '
        'TxtSTATE_TAX_ID
        '
        Me.TxtSTATE_TAX_ID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSTATE_TAX_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSTATE_TAX_ID.Location = New System.Drawing.Point(91, 192)
        Me.TxtSTATE_TAX_ID.MaxLength = 20
        Me.TxtSTATE_TAX_ID.Name = "TxtSTATE_TAX_ID"
        Me.TxtSTATE_TAX_ID.Size = New System.Drawing.Size(234, 20)
        Me.TxtSTATE_TAX_ID.TabIndex = 9
        Me.TxtSTATE_TAX_ID.Text = ""
        '
        'TxtFEDERAL_TAX_ID
        '
        Me.TxtFEDERAL_TAX_ID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFEDERAL_TAX_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtFEDERAL_TAX_ID.Location = New System.Drawing.Point(91, 166)
        Me.TxtFEDERAL_TAX_ID.MaxLength = 20
        Me.TxtFEDERAL_TAX_ID.Name = "TxtFEDERAL_TAX_ID"
        Me.TxtFEDERAL_TAX_ID.Size = New System.Drawing.Size(234, 20)
        Me.TxtFEDERAL_TAX_ID.TabIndex = 8
        Me.TxtFEDERAL_TAX_ID.Text = ""
        '
        'TxtADDRESS
        '
        Me.TxtADDRESS.BackColor = System.Drawing.SystemColors.Window
        Me.TxtADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtADDRESS.Location = New System.Drawing.Point(91, 64)
        Me.TxtADDRESS.MaxLength = 100
        Me.TxtADDRESS.Name = "TxtADDRESS"
        Me.TxtADDRESS.Size = New System.Drawing.Size(475, 20)
        Me.TxtADDRESS.TabIndex = 3
        Me.TxtADDRESS.Text = ""
        '
        'TXTSTORENAME
        '
        Me.TXTSTORENAME.BackColor = System.Drawing.SystemColors.Window
        Me.TXTSTORENAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTSTORENAME.Location = New System.Drawing.Point(91, 38)
        Me.TXTSTORENAME.MaxLength = 50
        Me.TXTSTORENAME.Name = "TXTSTORENAME"
        Me.TXTSTORENAME.Size = New System.Drawing.Size(411, 20)
        Me.TXTSTORENAME.TabIndex = 2
        Me.TXTSTORENAME.Text = ""
        '
        'TxtSTORENO
        '
        Me.TxtSTORENO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSTORENO.Location = New System.Drawing.Point(91, 8)
        Me.TxtSTORENO.MaxLength = 2
        Me.TxtSTORENO.Name = "TxtSTORENO"
        Me.TxtSTORENO.Size = New System.Drawing.Size(40, 20)
        Me.TxtSTORENO.TabIndex = 0
        Me.TxtSTORENO.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(187, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 476
        Me.Label4.Text = "Short Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneNo2
        '
        Me.PhoneNo2.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PhoneNo2.Location = New System.Drawing.Point(224, 116)
        Me.PhoneNo2.Name = "PhoneNo2"
        Me.PhoneNo2.Size = New System.Drawing.Size(94, 20)
        Me.PhoneNo2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(198, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 20)
        Me.Label1.TabIndex = 474
        Me.Label1.Text = "Fax"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ZipCode1.Location = New System.Drawing.Point(255, 91)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(59, 20)
        Me.ZipCode1.TabIndex = 4
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'LblSt
        '
        Me.LblSt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LblSt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LblSt.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblSt.Location = New System.Drawing.Point(222, 91)
        Me.LblSt.MaxLength = 20
        Me.LblSt.Name = "LblSt"
        Me.LblSt.ReadOnly = True
        Me.LblSt.Size = New System.Drawing.Size(33, 20)
        Me.LblSt.TabIndex = 472
        Me.LblSt.TabStop = False
        Me.LblSt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LblCity
        '
        Me.LblCity.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LblCity.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LblCity.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCity.Location = New System.Drawing.Point(91, 91)
        Me.LblCity.MaxLength = 5
        Me.LblCity.Name = "LblCity"
        Me.LblCity.ReadOnly = True
        Me.LblCity.Size = New System.Drawing.Size(131, 20)
        Me.LblCity.TabIndex = 471
        Me.LblCity.TabStop = False
        Me.LblCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(9, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 19)
        Me.Label15.TabIndex = 473
        Me.Label15.Text = "City, St. ZIP"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneNo1
        '
        Me.PhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PhoneNo1.Location = New System.Drawing.Point(91, 116)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(94, 20)
        Me.PhoneNo1.TabIndex = 5
        '
        'EmailAddress1
        '
        Me.EmailAddress1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.EmailAddress1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.EmailAddress1.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.EmailAddress1.ErrorColor = System.Drawing.Color.Red
        Me.EmailAddress1.ErrorMessage = "abc@microsoft.com ¬œ—” Å”  «·ò —Ê‰ÌòÌ »«Ì” Ì »Â «Ì‰ ’Ê—  »«‘œ"
        Me.EmailAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EmailAddress1.Location = New System.Drawing.Point(91, 141)
        Me.EmailAddress1.MaxLength = 50
        Me.EmailAddress1.Name = "EmailAddress1"
        Me.EmailAddress1.Size = New System.Drawing.Size(286, 20)
        Me.EmailAddress1.TabIndex = 7
        Me.EmailAddress1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.EmailAddress1.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0" & _
        "-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-" & _
        "9][0-9]|[1-9][0-9]|[0-9])\])$"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(6, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 20)
        Me.Label13.TabIndex = 470
        Me.Label13.Text = "Sales Tax ID"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(6, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 20)
        Me.Label11.TabIndex = 469
        Me.Label11.Text = "States Tax ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(6, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 468
        Me.Label8.Text = "Federal Tax ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(6, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 467
        Me.Label7.Text = "Address"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(6, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 466
        Me.Label3.Text = "Email"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(6, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 20)
        Me.Label12.TabIndex = 465
        Me.Label12.Text = "Phone"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(6, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 20)
        Me.Label14.TabIndex = 464
        Me.Label14.Text = "Store Name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 21)
        Me.Label5.TabIndex = 454
        Me.Label5.Text = "Store No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CHKRULES12)
        Me.TabPage2.Controls.Add(Me.CHKRULES11)
        Me.TabPage2.Controls.Add(Me.CHKRULES10)
        Me.TabPage2.Controls.Add(Me.CHKRULES9)
        Me.TabPage2.Controls.Add(Me.CHKRULES8)
        Me.TabPage2.Controls.Add(Me.CHKRULES7)
        Me.TabPage2.Controls.Add(Me.CHKRULES6)
        Me.TabPage2.Controls.Add(Me.CHKRULES5)
        Me.TabPage2.Controls.Add(Me.CHKRULES4)
        Me.TabPage2.Controls.Add(Me.CHKRULES3)
        Me.TabPage2.Controls.Add(Me.CHKRULES2)
        Me.TabPage2.Controls.Add(Me.CHKRULES1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(577, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rules"
        Me.TabPage2.Visible = False
        '
        'CHKRULES12
        '
        Me.CHKRULES12.Location = New System.Drawing.Point(13, 239)
        Me.CHKRULES12.Name = "CHKRULES12"
        Me.CHKRULES12.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES12.TabIndex = 11
        Me.CHKRULES12.Text = "Require Vendor Invoice Number when entering outside purchase items on invoices"
        '
        'CHKRULES11
        '
        Me.CHKRULES11.Location = New System.Drawing.Point(13, 217)
        Me.CHKRULES11.Name = "CHKRULES11"
        Me.CHKRULES11.Size = New System.Drawing.Size(528, 22)
        Me.CHKRULES11.TabIndex = 10
        Me.CHKRULES11.Text = "Require cost when entering outside purchase items on Invoices"
        '
        'CHKRULES10
        '
        Me.CHKRULES10.Location = New System.Drawing.Point(13, 196)
        Me.CHKRULES10.Name = "CHKRULES10"
        Me.CHKRULES10.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES10.TabIndex = 9
        Me.CHKRULES10.Text = "Warn if selling price of items are less than cost of that item when saving estima" & _
        "tes or work Orders"
        '
        'CHKRULES9
        '
        Me.CHKRULES9.Location = New System.Drawing.Point(13, 175)
        Me.CHKRULES9.Name = "CHKRULES9"
        Me.CHKRULES9.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES9.TabIndex = 8
        Me.CHKRULES9.Text = "Track Price Overrides on When saving Invoices"
        '
        'CHKRULES8
        '
        Me.CHKRULES8.Location = New System.Drawing.Point(13, 153)
        Me.CHKRULES8.Name = "CHKRULES8"
        Me.CHKRULES8.Size = New System.Drawing.Size(528, 22)
        Me.CHKRULES8.TabIndex = 7
        Me.CHKRULES8.Text = "Require VIN No when saving new vehicles"
        '
        'CHKRULES7
        '
        Me.CHKRULES7.Location = New System.Drawing.Point(13, 132)
        Me.CHKRULES7.Name = "CHKRULES7"
        Me.CHKRULES7.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES7.TabIndex = 6
        Me.CHKRULES7.Text = "Require Make, Model, Year when saving new vehicles"
        '
        'CHKRULES6
        '
        Me.CHKRULES6.Location = New System.Drawing.Point(13, 110)
        Me.CHKRULES6.Name = "CHKRULES6"
        Me.CHKRULES6.Size = New System.Drawing.Size(528, 22)
        Me.CHKRULES6.TabIndex = 5
        Me.CHKRULES6.Text = "Require Vehicle Licence No for New Vehicles on When saving Invoices"
        '
        'CHKRULES5
        '
        Me.CHKRULES5.Location = New System.Drawing.Point(13, 89)
        Me.CHKRULES5.Name = "CHKRULES5"
        Me.CHKRULES5.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES5.TabIndex = 4
        Me.CHKRULES5.Text = "Require last and first name for new customers when saving Work Orders and Invoice" & _
        "s"
        '
        'CHKRULES4
        '
        Me.CHKRULES4.Location = New System.Drawing.Point(13, 68)
        Me.CHKRULES4.Name = "CHKRULES4"
        Me.CHKRULES4.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES4.TabIndex = 3
        Me.CHKRULES4.Text = "Warn if insufficient quantity for the item when saving Work Orders and Invocies"
        '
        'CHKRULES3
        '
        Me.CHKRULES3.Location = New System.Drawing.Point(13, 46)
        Me.CHKRULES3.Name = "CHKRULES3"
        Me.CHKRULES3.Size = New System.Drawing.Size(528, 22)
        Me.CHKRULES3.TabIndex = 2
        Me.CHKRULES3.Text = "Require technician for designated services when saving invoices"
        '
        'CHKRULES2
        '
        Me.CHKRULES2.Location = New System.Drawing.Point(13, 25)
        Me.CHKRULES2.Name = "CHKRULES2"
        Me.CHKRULES2.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES2.TabIndex = 1
        Me.CHKRULES2.Text = "Warn if new mileage for vehicle not entered when saving invoices"
        '
        'CHKRULES1
        '
        Me.CHKRULES1.Location = New System.Drawing.Point(13, 4)
        Me.CHKRULES1.Name = "CHKRULES1"
        Me.CHKRULES1.Size = New System.Drawing.Size(528, 21)
        Me.CHKRULES1.TabIndex = 0
        Me.CHKRULES1.Text = "Do not print quantity or Labor hour for services on work order"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.TxtWARRANTY_FOR_ES)
        Me.TabPage7.Controls.Add(Me.Label39)
        Me.TabPage7.Controls.Add(Me.TxtWARRANTY_FOR_WO)
        Me.TabPage7.Controls.Add(Me.Label45)
        Me.TabPage7.Controls.Add(Me.TxtWARRANTY_FOR_IN)
        Me.TabPage7.Controls.Add(Me.Label46)
        Me.TabPage7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(577, 262)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Warranty"
        '
        'TxtWARRANTY_FOR_ES
        '
        Me.TxtWARRANTY_FOR_ES.BackColor = System.Drawing.SystemColors.Window
        Me.TxtWARRANTY_FOR_ES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtWARRANTY_FOR_ES.Location = New System.Drawing.Point(98, 177)
        Me.TxtWARRANTY_FOR_ES.MaxLength = 1000
        Me.TxtWARRANTY_FOR_ES.Multiline = True
        Me.TxtWARRANTY_FOR_ES.Name = "TxtWARRANTY_FOR_ES"
        Me.TxtWARRANTY_FOR_ES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtWARRANTY_FOR_ES.Size = New System.Drawing.Size(470, 79)
        Me.TxtWARRANTY_FOR_ES.TabIndex = 2
        Me.TxtWARRANTY_FOR_ES.Text = ""
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label39.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label39.Location = New System.Drawing.Point(8, 205)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(89, 20)
        Me.Label39.TabIndex = 484
        Me.Label39.Text = "For Estimates"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWARRANTY_FOR_WO
        '
        Me.TxtWARRANTY_FOR_WO.BackColor = System.Drawing.SystemColors.Window
        Me.TxtWARRANTY_FOR_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtWARRANTY_FOR_WO.Location = New System.Drawing.Point(98, 93)
        Me.TxtWARRANTY_FOR_WO.MaxLength = 1000
        Me.TxtWARRANTY_FOR_WO.Multiline = True
        Me.TxtWARRANTY_FOR_WO.Name = "TxtWARRANTY_FOR_WO"
        Me.TxtWARRANTY_FOR_WO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtWARRANTY_FOR_WO.Size = New System.Drawing.Size(470, 79)
        Me.TxtWARRANTY_FOR_WO.TabIndex = 1
        Me.TxtWARRANTY_FOR_WO.Text = ""
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(8, 121)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(89, 19)
        Me.Label45.TabIndex = 482
        Me.Label45.Text = "For Work Orders"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWARRANTY_FOR_IN
        '
        Me.TxtWARRANTY_FOR_IN.BackColor = System.Drawing.SystemColors.Window
        Me.TxtWARRANTY_FOR_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtWARRANTY_FOR_IN.Location = New System.Drawing.Point(98, 8)
        Me.TxtWARRANTY_FOR_IN.MaxLength = 1000
        Me.TxtWARRANTY_FOR_IN.Multiline = True
        Me.TxtWARRANTY_FOR_IN.Name = "TxtWARRANTY_FOR_IN"
        Me.TxtWARRANTY_FOR_IN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtWARRANTY_FOR_IN.Size = New System.Drawing.Size(470, 79)
        Me.TxtWARRANTY_FOR_IN.TabIndex = 0
        Me.TxtWARRANTY_FOR_IN.Text = ""
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(8, 37)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(89, 20)
        Me.Label46.TabIndex = 480
        Me.Label46.Text = "For Invoices"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.TxtDISCLAIMER_FOR_ES)
        Me.TabPage6.Controls.Add(Me.Label37)
        Me.TabPage6.Controls.Add(Me.TxtDISCLAIMER_FOR_WO)
        Me.TabPage6.Controls.Add(Me.Label36)
        Me.TabPage6.Controls.Add(Me.TxtDISCLAIMER_FOR_IN)
        Me.TabPage6.Controls.Add(Me.Label38)
        Me.TabPage6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(577, 262)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Disclaimer"
        '
        'TxtDISCLAIMER_FOR_ES
        '
        Me.TxtDISCLAIMER_FOR_ES.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDISCLAIMER_FOR_ES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDISCLAIMER_FOR_ES.Location = New System.Drawing.Point(96, 178)
        Me.TxtDISCLAIMER_FOR_ES.MaxLength = 1000
        Me.TxtDISCLAIMER_FOR_ES.Multiline = True
        Me.TxtDISCLAIMER_FOR_ES.Name = "TxtDISCLAIMER_FOR_ES"
        Me.TxtDISCLAIMER_FOR_ES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDISCLAIMER_FOR_ES.Size = New System.Drawing.Size(470, 79)
        Me.TxtDISCLAIMER_FOR_ES.TabIndex = 2
        Me.TxtDISCLAIMER_FOR_ES.Text = ""
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(6, 206)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(89, 20)
        Me.Label37.TabIndex = 478
        Me.Label37.Text = "For Estimates"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDISCLAIMER_FOR_WO
        '
        Me.TxtDISCLAIMER_FOR_WO.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDISCLAIMER_FOR_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDISCLAIMER_FOR_WO.Location = New System.Drawing.Point(96, 94)
        Me.TxtDISCLAIMER_FOR_WO.MaxLength = 1000
        Me.TxtDISCLAIMER_FOR_WO.Multiline = True
        Me.TxtDISCLAIMER_FOR_WO.Name = "TxtDISCLAIMER_FOR_WO"
        Me.TxtDISCLAIMER_FOR_WO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDISCLAIMER_FOR_WO.Size = New System.Drawing.Size(470, 79)
        Me.TxtDISCLAIMER_FOR_WO.TabIndex = 1
        Me.TxtDISCLAIMER_FOR_WO.Text = ""
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(6, 122)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(89, 19)
        Me.Label36.TabIndex = 476
        Me.Label36.Text = "For Work Orders"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDISCLAIMER_FOR_IN
        '
        Me.TxtDISCLAIMER_FOR_IN.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDISCLAIMER_FOR_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDISCLAIMER_FOR_IN.Location = New System.Drawing.Point(96, 9)
        Me.TxtDISCLAIMER_FOR_IN.MaxLength = 1000
        Me.TxtDISCLAIMER_FOR_IN.Multiline = True
        Me.TxtDISCLAIMER_FOR_IN.Name = "TxtDISCLAIMER_FOR_IN"
        Me.TxtDISCLAIMER_FOR_IN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDISCLAIMER_FOR_IN.Size = New System.Drawing.Size(470, 79)
        Me.TxtDISCLAIMER_FOR_IN.TabIndex = 0
        Me.TxtDISCLAIMER_FOR_IN.Text = ""
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(6, 38)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(89, 20)
        Me.Label38.TabIndex = 474
        Me.Label38.Text = "For Invoices"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS17)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS16)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS15)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS14)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS13)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS12)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS11)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS10)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS9)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS8)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS7)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS6)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS5)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS4)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS3)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS2)
        Me.TabPage3.Controls.Add(Me.CHKFUNCTIONS1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(577, 262)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Functions"
        Me.TabPage3.Visible = False
        '
        'CHKFUNCTIONS17
        '
        Me.CHKFUNCTIONS17.Location = New System.Drawing.Point(312, 209)
        Me.CHKFUNCTIONS17.Name = "CHKFUNCTIONS17"
        Me.CHKFUNCTIONS17.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS17.TabIndex = 16
        Me.CHKFUNCTIONS17.Text = "Use ALLDATA Labor Guide"
        '
        'CHKFUNCTIONS16
        '
        Me.CHKFUNCTIONS16.Location = New System.Drawing.Point(312, 180)
        Me.CHKFUNCTIONS16.Name = "CHKFUNCTIONS16"
        Me.CHKFUNCTIONS16.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS16.TabIndex = 15
        Me.CHKFUNCTIONS16.Text = "Use Mitchell Labor Guide"
        '
        'CHKFUNCTIONS15
        '
        Me.CHKFUNCTIONS15.Location = New System.Drawing.Point(312, 151)
        Me.CHKFUNCTIONS15.Name = "CHKFUNCTIONS15"
        Me.CHKFUNCTIONS15.Size = New System.Drawing.Size(229, 22)
        Me.CHKFUNCTIONS15.TabIndex = 14
        Me.CHKFUNCTIONS15.Text = "Use Microsoft Office"
        '
        'CHKFUNCTIONS14
        '
        Me.CHKFUNCTIONS14.Location = New System.Drawing.Point(312, 123)
        Me.CHKFUNCTIONS14.Name = "CHKFUNCTIONS14"
        Me.CHKFUNCTIONS14.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS14.TabIndex = 13
        Me.CHKFUNCTIONS14.Text = "Use Address Verification"
        '
        'CHKFUNCTIONS13
        '
        Me.CHKFUNCTIONS13.Location = New System.Drawing.Point(312, 94)
        Me.CHKFUNCTIONS13.Name = "CHKFUNCTIONS13"
        Me.CHKFUNCTIONS13.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS13.TabIndex = 12
        Me.CHKFUNCTIONS13.Text = "Use Digital Signiture"
        '
        'CHKFUNCTIONS12
        '
        Me.CHKFUNCTIONS12.Location = New System.Drawing.Point(312, 65)
        Me.CHKFUNCTIONS12.Name = "CHKFUNCTIONS12"
        Me.CHKFUNCTIONS12.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS12.TabIndex = 11
        Me.CHKFUNCTIONS12.Text = "Use Store On-line"
        '
        'CHKFUNCTIONS11
        '
        Me.CHKFUNCTIONS11.Location = New System.Drawing.Point(312, 36)
        Me.CHKFUNCTIONS11.Name = "CHKFUNCTIONS11"
        Me.CHKFUNCTIONS11.Size = New System.Drawing.Size(229, 22)
        Me.CHKFUNCTIONS11.TabIndex = 10
        Me.CHKFUNCTIONS11.Text = "Use Tire Guide"
        '
        'CHKFUNCTIONS10
        '
        Me.CHKFUNCTIONS10.Location = New System.Drawing.Point(312, 7)
        Me.CHKFUNCTIONS10.Name = "CHKFUNCTIONS10"
        Me.CHKFUNCTIONS10.Size = New System.Drawing.Size(229, 22)
        Me.CHKFUNCTIONS10.TabIndex = 9
        Me.CHKFUNCTIONS10.Text = "Use TIREBASE"
        '
        'CHKFUNCTIONS9
        '
        Me.CHKFUNCTIONS9.Location = New System.Drawing.Point(11, 238)
        Me.CHKFUNCTIONS9.Name = "CHKFUNCTIONS9"
        Me.CHKFUNCTIONS9.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS9.TabIndex = 8
        Me.CHKFUNCTIONS9.Text = "Use Service Reminders"
        '
        'CHKFUNCTIONS8
        '
        Me.CHKFUNCTIONS8.Location = New System.Drawing.Point(11, 209)
        Me.CHKFUNCTIONS8.Name = "CHKFUNCTIONS8"
        Me.CHKFUNCTIONS8.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS8.TabIndex = 7
        Me.CHKFUNCTIONS8.Text = "Use On-line Ordering"
        '
        'CHKFUNCTIONS7
        '
        Me.CHKFUNCTIONS7.Location = New System.Drawing.Point(11, 180)
        Me.CHKFUNCTIONS7.Name = "CHKFUNCTIONS7"
        Me.CHKFUNCTIONS7.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS7.TabIndex = 6
        Me.CHKFUNCTIONS7.Text = "Use Appointment Scheduling"
        '
        'CHKFUNCTIONS6
        '
        Me.CHKFUNCTIONS6.Location = New System.Drawing.Point(11, 151)
        Me.CHKFUNCTIONS6.Name = "CHKFUNCTIONS6"
        Me.CHKFUNCTIONS6.Size = New System.Drawing.Size(229, 22)
        Me.CHKFUNCTIONS6.TabIndex = 5
        Me.CHKFUNCTIONS6.Text = "Use Employee Time Tracking"
        '
        'CHKFUNCTIONS5
        '
        Me.CHKFUNCTIONS5.Location = New System.Drawing.Point(11, 123)
        Me.CHKFUNCTIONS5.Name = "CHKFUNCTIONS5"
        Me.CHKFUNCTIONS5.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS5.TabIndex = 4
        Me.CHKFUNCTIONS5.Text = "Use Bar Code Label Printing"
        '
        'CHKFUNCTIONS4
        '
        Me.CHKFUNCTIONS4.Location = New System.Drawing.Point(11, 94)
        Me.CHKFUNCTIONS4.Name = "CHKFUNCTIONS4"
        Me.CHKFUNCTIONS4.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS4.TabIndex = 3
        Me.CHKFUNCTIONS4.Text = "Use Scanners to receive and sell items"
        '
        'CHKFUNCTIONS3
        '
        Me.CHKFUNCTIONS3.Location = New System.Drawing.Point(11, 65)
        Me.CHKFUNCTIONS3.Name = "CHKFUNCTIONS3"
        Me.CHKFUNCTIONS3.Size = New System.Drawing.Size(229, 21)
        Me.CHKFUNCTIONS3.TabIndex = 2
        Me.CHKFUNCTIONS3.Text = "Use integrated Email"
        '
        'CHKFUNCTIONS2
        '
        Me.CHKFUNCTIONS2.Location = New System.Drawing.Point(11, 36)
        Me.CHKFUNCTIONS2.Name = "CHKFUNCTIONS2"
        Me.CHKFUNCTIONS2.Size = New System.Drawing.Size(229, 22)
        Me.CHKFUNCTIONS2.TabIndex = 1
        Me.CHKFUNCTIONS2.Text = "Use integrated Fax"
        '
        'CHKFUNCTIONS1
        '
        Me.CHKFUNCTIONS1.Location = New System.Drawing.Point(11, 7)
        Me.CHKFUNCTIONS1.Name = "CHKFUNCTIONS1"
        Me.CHKFUNCTIONS1.Size = New System.Drawing.Size(229, 22)
        Me.CHKFUNCTIONS1.TabIndex = 0
        Me.CHKFUNCTIONS1.Text = "Use Credit Card Processing"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CmbInterStorePayableAccount)
        Me.TabPage4.Controls.Add(Me.CmbInterStoreReceivableAccount)
        Me.TabPage4.Controls.Add(Me.Label47)
        Me.TabPage4.Controls.Add(Me.Label48)
        Me.TabPage4.Controls.Add(Me.CmbState)
        Me.TabPage4.Controls.Add(Me.cmbSALESPERSON)
        Me.TabPage4.Controls.Add(Me.cmbSALES_TAX)
        Me.TabPage4.Controls.Add(Me.TxtCASH_CUSTOMER)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.TxtTECHNISIAN)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.TxtCity)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.TxtAREACODE)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.TxtCOUNTY)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(577, 262)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Defaults"
        '
        'CmbInterStorePayableAccount
        '
        Me.CmbInterStorePayableAccount.DataSource = Me.DsFrmSTORESETUP1.GL_account1
        Me.CmbInterStorePayableAccount.DisplayMember = "desc_GL_account"
        Me.CmbInterStorePayableAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInterStorePayableAccount.Location = New System.Drawing.Point(242, 236)
        Me.CmbInterStorePayableAccount.Name = "CmbInterStorePayableAccount"
        Me.CmbInterStorePayableAccount.Size = New System.Drawing.Size(152, 21)
        Me.CmbInterStorePayableAccount.TabIndex = 10
        Me.CmbInterStorePayableAccount.ValueMember = "GL_account"
        '
        'CmbInterStoreReceivableAccount
        '
        Me.CmbInterStoreReceivableAccount.DataSource = Me.DsFrmSTORESETUP1.GL_account
        Me.CmbInterStoreReceivableAccount.DisplayMember = "desc_GL_account"
        Me.CmbInterStoreReceivableAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInterStoreReceivableAccount.Location = New System.Drawing.Point(242, 211)
        Me.CmbInterStoreReceivableAccount.Name = "CmbInterStoreReceivableAccount"
        Me.CmbInterStoreReceivableAccount.Size = New System.Drawing.Size(152, 21)
        Me.CmbInterStoreReceivableAccount.TabIndex = 8
        Me.CmbInterStoreReceivableAccount.ValueMember = "GL_account"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label47.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label47.Location = New System.Drawing.Point(16, 237)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(226, 20)
        Me.Label47.TabIndex = 490
        Me.Label47.Text = "Inter-Store Accounts Payable Gl Account"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label48.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label48.Location = New System.Drawing.Point(16, 212)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(226, 20)
        Me.Label48.TabIndex = 489
        Me.Label48.Text = "Inter-Store Accounts Receivable Gl Account"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbState
        '
        Me.CmbState.BackColor = System.Drawing.SystemColors.Window
        Me.CmbState.DataSource = Me.DsFrmSTORESETUP1.bas_zipcode
        Me.CmbState.DisplayMember = "state"
        Me.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbState.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbState.ItemHeight = 13
        Me.CmbState.Location = New System.Drawing.Point(92, 105)
        Me.CmbState.Name = "CmbState"
        Me.CmbState.Size = New System.Drawing.Size(47, 21)
        Me.CmbState.TabIndex = 4
        Me.CmbState.ValueMember = "state"
        '
        'cmbSALESPERSON
        '
        Me.cmbSALESPERSON.DataSource = Me.DsFrmSTORESETUP1.employee
        Me.cmbSALESPERSON.DisplayMember = "employee_name"
        Me.cmbSALESPERSON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSALESPERSON.ItemHeight = 13
        Me.cmbSALESPERSON.Location = New System.Drawing.Point(92, 130)
        Me.cmbSALESPERSON.Name = "cmbSALESPERSON"
        Me.cmbSALESPERSON.Size = New System.Drawing.Size(224, 21)
        Me.cmbSALESPERSON.TabIndex = 5
        Me.cmbSALESPERSON.ValueMember = "employee_code"
        '
        'cmbSALES_TAX
        '
        Me.cmbSALES_TAX.DataSource = Me.DsFrmSTORESETUP1.cust_sales_tax
        Me.cmbSALES_TAX.DisplayMember = "desc_sales_tax"
        Me.cmbSALES_TAX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSALES_TAX.Location = New System.Drawing.Point(92, 10)
        Me.cmbSALES_TAX.Name = "cmbSALES_TAX"
        Me.cmbSALES_TAX.Size = New System.Drawing.Size(225, 21)
        Me.cmbSALES_TAX.TabIndex = 0
        Me.cmbSALES_TAX.ValueMember = "cod_sales_tax"
        '
        'TxtCASH_CUSTOMER
        '
        Me.TxtCASH_CUSTOMER.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCASH_CUSTOMER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtCASH_CUSTOMER.Location = New System.Drawing.Point(92, 184)
        Me.TxtCASH_CUSTOMER.MaxLength = 30
        Me.TxtCASH_CUSTOMER.Name = "TxtCASH_CUSTOMER"
        Me.TxtCASH_CUSTOMER.Size = New System.Drawing.Size(234, 20)
        Me.TxtCASH_CUSTOMER.TabIndex = 7
        Me.TxtCASH_CUSTOMER.Text = ""
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(3, 184)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 19)
        Me.Label20.TabIndex = 486
        Me.Label20.Text = "Cash Customer"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTECHNISIAN
        '
        Me.TxtTECHNISIAN.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTECHNISIAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTECHNISIAN.Location = New System.Drawing.Point(92, 157)
        Me.TxtTECHNISIAN.MaxLength = 30
        Me.TxtTECHNISIAN.Name = "TxtTECHNISIAN"
        Me.TxtTECHNISIAN.Size = New System.Drawing.Size(234, 20)
        Me.TxtTECHNISIAN.TabIndex = 6
        Me.TxtTECHNISIAN.Text = ""
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(7, 157)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 19)
        Me.Label19.TabIndex = 484
        Me.Label19.Text = "Technician"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(7, 131)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 20)
        Me.Label18.TabIndex = 482
        Me.Label18.Text = "Sales Person"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(7, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 20)
        Me.Label16.TabIndex = 480
        Me.Label16.Text = "State"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCity
        '
        Me.TxtCity.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtCity.Location = New System.Drawing.Point(92, 81)
        Me.TxtCity.MaxLength = 30
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(234, 20)
        Me.TxtCity.TabIndex = 3
        Me.TxtCity.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(7, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 19)
        Me.Label10.TabIndex = 478
        Me.Label10.Text = "City"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAREACODE
        '
        Me.TxtAREACODE.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAREACODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtAREACODE.Location = New System.Drawing.Point(92, 58)
        Me.TxtAREACODE.MaxLength = 3
        Me.TxtAREACODE.Name = "TxtAREACODE"
        Me.TxtAREACODE.Size = New System.Drawing.Size(50, 20)
        Me.TxtAREACODE.TabIndex = 2
        Me.TxtAREACODE.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(7, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 19)
        Me.Label9.TabIndex = 476
        Me.Label9.Text = "Area Code"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCOUNTY
        '
        Me.TxtCOUNTY.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCOUNTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtCOUNTY.Location = New System.Drawing.Point(92, 34)
        Me.TxtCOUNTY.MaxLength = 30
        Me.TxtCOUNTY.Name = "TxtCOUNTY"
        Me.TxtCOUNTY.Size = New System.Drawing.Size(234, 20)
        Me.TxtCOUNTY.TabIndex = 1
        Me.TxtCOUNTY.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(7, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 474
        Me.Label6.Text = "County"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 472
        Me.Label2.Text = "Sales Tax %"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.TxtSqlUserPassword)
        Me.TabPage8.Controls.Add(Me.TxtSqlUserName)
        Me.TabPage8.Controls.Add(Me.TxtSqlServerName)
        Me.TabPage8.Controls.Add(Me.Label57)
        Me.TabPage8.Controls.Add(Me.Label56)
        Me.TabPage8.Controls.Add(Me.Label49)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(577, 262)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "SQL Server Properties"
        '
        'TxtSqlUserPassword
        '
        Me.TxtSqlUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSqlUserPassword.Location = New System.Drawing.Point(120, 85)
        Me.TxtSqlUserPassword.MaxLength = 25
        Me.TxtSqlUserPassword.Name = "TxtSqlUserPassword"
        Me.TxtSqlUserPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtSqlUserPassword.Size = New System.Drawing.Size(151, 20)
        Me.TxtSqlUserPassword.TabIndex = 5
        Me.TxtSqlUserPassword.Text = ""
        '
        'TxtSqlUserName
        '
        Me.TxtSqlUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSqlUserName.Location = New System.Drawing.Point(120, 51)
        Me.TxtSqlUserName.MaxLength = 25
        Me.TxtSqlUserName.Name = "TxtSqlUserName"
        Me.TxtSqlUserName.Size = New System.Drawing.Size(151, 20)
        Me.TxtSqlUserName.TabIndex = 4
        Me.TxtSqlUserName.Text = ""
        '
        'TxtSqlServerName
        '
        Me.TxtSqlServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSqlServerName.Location = New System.Drawing.Point(120, 17)
        Me.TxtSqlServerName.MaxLength = 25
        Me.TxtSqlServerName.Name = "TxtSqlServerName"
        Me.TxtSqlServerName.Size = New System.Drawing.Size(196, 20)
        Me.TxtSqlServerName.TabIndex = 3
        Me.TxtSqlServerName.Text = ""
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(16, 83)
        Me.Label57.Name = "Label57"
        Me.Label57.TabIndex = 2
        Me.Label57.Text = "Password"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(16, 49)
        Me.Label56.Name = "Label56"
        Me.Label56.TabIndex = 1
        Me.Label56.Text = "User Name"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(16, 15)
        Me.Label49.Name = "Label49"
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "Server Name"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.Label68)
        Me.TabPage9.Controls.Add(Me.Label67)
        Me.TabPage9.Controls.Add(Me.GroupBox10)
        Me.TabPage9.Controls.Add(Me.GroupBox9)
        Me.TabPage9.Controls.Add(Me.GroupBox8)
        Me.TabPage9.Controls.Add(Me.GroupBox7)
        Me.TabPage9.Controls.Add(Me.GroupBox6)
        Me.TabPage9.Controls.Add(Me.GroupBox5)
        Me.TabPage9.Controls.Add(Me.GroupBox4)
        Me.TabPage9.Controls.Add(Me.GroupBox3)
        Me.TabPage9.Controls.Add(Me.GroupBox2)
        Me.TabPage9.Controls.Add(Me.GroupBox1)
        Me.TabPage9.Controls.Add(Me.Label69)
        Me.TabPage9.Controls.Add(Me.Label70)
        Me.TabPage9.Controls.Add(Me.Label71)
        Me.TabPage9.Controls.Add(Me.Label72)
        Me.TabPage9.Controls.Add(Me.Label66)
        Me.TabPage9.Controls.Add(Me.Label58)
        Me.TabPage9.Controls.Add(Me.Label59)
        Me.TabPage9.Controls.Add(Me.Label60)
        Me.TabPage9.Controls.Add(Me.Label61)
        Me.TabPage9.Controls.Add(Me.Label62)
        Me.TabPage9.Controls.Add(Me.Label63)
        Me.TabPage9.Controls.Add(Me.Label64)
        Me.TabPage9.Controls.Add(Me.Label65)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(577, 262)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Forms Options"
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label68.Location = New System.Drawing.Point(438, 124)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(116, 118)
        Me.Label68.TabIndex = 516
        Me.Label68.Text = "Selecting no shadings will also remove the store logo from the forms that are use" & _
        "d internally , such as work orders , Inventory receipts and Acoount adjustments." & _
        ""
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label67.Location = New System.Drawing.Point(437, 20)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(116, 90)
        Me.Label67.TabIndex = 515
        Me.Label67.Text = "No Shadings Options are used to make the toner cartridges last longer and print m" & _
        "ore pages before being replaced."
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.ChkInvoicesShadingNo)
        Me.GroupBox10.Controls.Add(Me.ChkInvoicesShadingYes)
        Me.GroupBox10.Location = New System.Drawing.Point(208, 69)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox10.TabIndex = 514
        Me.GroupBox10.TabStop = False
        '
        'ChkInvoicesShadingNo
        '
        Me.ChkInvoicesShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkInvoicesShadingNo.Name = "ChkInvoicesShadingNo"
        Me.ChkInvoicesShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkInvoicesShadingNo.TabIndex = 506
        '
        'ChkInvoicesShadingYes
        '
        Me.ChkInvoicesShadingYes.Checked = True
        Me.ChkInvoicesShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkInvoicesShadingYes.Name = "ChkInvoicesShadingYes"
        Me.ChkInvoicesShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkInvoicesShadingYes.TabIndex = 505
        Me.ChkInvoicesShadingYes.TabStop = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.ChkPurchasesOrdersShadingNo)
        Me.GroupBox9.Controls.Add(Me.ChkPurchasesOrdersShadingYes)
        Me.GroupBox9.Location = New System.Drawing.Point(208, 233)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox9.TabIndex = 513
        Me.GroupBox9.TabStop = False
        '
        'ChkPurchasesOrdersShadingNo
        '
        Me.ChkPurchasesOrdersShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkPurchasesOrdersShadingNo.Name = "ChkPurchasesOrdersShadingNo"
        Me.ChkPurchasesOrdersShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkPurchasesOrdersShadingNo.TabIndex = 506
        '
        'ChkPurchasesOrdersShadingYes
        '
        Me.ChkPurchasesOrdersShadingYes.Checked = True
        Me.ChkPurchasesOrdersShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkPurchasesOrdersShadingYes.Name = "ChkPurchasesOrdersShadingYes"
        Me.ChkPurchasesOrdersShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkPurchasesOrdersShadingYes.TabIndex = 505
        Me.ChkPurchasesOrdersShadingYes.TabStop = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ChkInventoryAdjustmentsShadingNo)
        Me.GroupBox8.Controls.Add(Me.ChkInventoryAdjustmentsShadingYes)
        Me.GroupBox8.Location = New System.Drawing.Point(208, 210)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox8.TabIndex = 512
        Me.GroupBox8.TabStop = False
        '
        'ChkInventoryAdjustmentsShadingNo
        '
        Me.ChkInventoryAdjustmentsShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkInventoryAdjustmentsShadingNo.Name = "ChkInventoryAdjustmentsShadingNo"
        Me.ChkInventoryAdjustmentsShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkInventoryAdjustmentsShadingNo.TabIndex = 506
        '
        'ChkInventoryAdjustmentsShadingYes
        '
        Me.ChkInventoryAdjustmentsShadingYes.Checked = True
        Me.ChkInventoryAdjustmentsShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkInventoryAdjustmentsShadingYes.Name = "ChkInventoryAdjustmentsShadingYes"
        Me.ChkInventoryAdjustmentsShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkInventoryAdjustmentsShadingYes.TabIndex = 505
        Me.ChkInventoryAdjustmentsShadingYes.TabStop = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ChkInventoryReturnsShadingNo)
        Me.GroupBox7.Controls.Add(Me.ChkInventoryReturnsShadingYes)
        Me.GroupBox7.Location = New System.Drawing.Point(208, 187)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox7.TabIndex = 511
        Me.GroupBox7.TabStop = False
        '
        'ChkInventoryReturnsShadingNo
        '
        Me.ChkInventoryReturnsShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkInventoryReturnsShadingNo.Name = "ChkInventoryReturnsShadingNo"
        Me.ChkInventoryReturnsShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkInventoryReturnsShadingNo.TabIndex = 506
        '
        'ChkInventoryReturnsShadingYes
        '
        Me.ChkInventoryReturnsShadingYes.Checked = True
        Me.ChkInventoryReturnsShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkInventoryReturnsShadingYes.Name = "ChkInventoryReturnsShadingYes"
        Me.ChkInventoryReturnsShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkInventoryReturnsShadingYes.TabIndex = 505
        Me.ChkInventoryReturnsShadingYes.TabStop = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ChkCustomerPaymentsShadingNo)
        Me.GroupBox6.Controls.Add(Me.ChkCustomerPaymentsShadingYes)
        Me.GroupBox6.Location = New System.Drawing.Point(208, 116)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox6.TabIndex = 510
        Me.GroupBox6.TabStop = False
        '
        'ChkCustomerPaymentsShadingNo
        '
        Me.ChkCustomerPaymentsShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkCustomerPaymentsShadingNo.Name = "ChkCustomerPaymentsShadingNo"
        Me.ChkCustomerPaymentsShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkCustomerPaymentsShadingNo.TabIndex = 506
        '
        'ChkCustomerPaymentsShadingYes
        '
        Me.ChkCustomerPaymentsShadingYes.Checked = True
        Me.ChkCustomerPaymentsShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkCustomerPaymentsShadingYes.Name = "ChkCustomerPaymentsShadingYes"
        Me.ChkCustomerPaymentsShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkCustomerPaymentsShadingYes.TabIndex = 505
        Me.ChkCustomerPaymentsShadingYes.TabStop = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ChkInventoryReceiptsShadingNo)
        Me.GroupBox5.Controls.Add(Me.ChkInventoryReceiptsShadingYes)
        Me.GroupBox5.Location = New System.Drawing.Point(208, 163)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox5.TabIndex = 509
        Me.GroupBox5.TabStop = False
        '
        'ChkInventoryReceiptsShadingNo
        '
        Me.ChkInventoryReceiptsShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkInventoryReceiptsShadingNo.Name = "ChkInventoryReceiptsShadingNo"
        Me.ChkInventoryReceiptsShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkInventoryReceiptsShadingNo.TabIndex = 506
        '
        'ChkInventoryReceiptsShadingYes
        '
        Me.ChkInventoryReceiptsShadingYes.Checked = True
        Me.ChkInventoryReceiptsShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkInventoryReceiptsShadingYes.Name = "ChkInventoryReceiptsShadingYes"
        Me.ChkInventoryReceiptsShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkInventoryReceiptsShadingYes.TabIndex = 505
        Me.ChkInventoryReceiptsShadingYes.TabStop = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ChkAccountAdjustmentsShadingNo)
        Me.GroupBox4.Controls.Add(Me.ChkAccountAdjustmentsShadingYes)
        Me.GroupBox4.Location = New System.Drawing.Point(208, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox4.TabIndex = 508
        Me.GroupBox4.TabStop = False
        '
        'ChkAccountAdjustmentsShadingNo
        '
        Me.ChkAccountAdjustmentsShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkAccountAdjustmentsShadingNo.Name = "ChkAccountAdjustmentsShadingNo"
        Me.ChkAccountAdjustmentsShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkAccountAdjustmentsShadingNo.TabIndex = 506
        '
        'ChkAccountAdjustmentsShadingYes
        '
        Me.ChkAccountAdjustmentsShadingYes.Checked = True
        Me.ChkAccountAdjustmentsShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkAccountAdjustmentsShadingYes.Name = "ChkAccountAdjustmentsShadingYes"
        Me.ChkAccountAdjustmentsShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkAccountAdjustmentsShadingYes.TabIndex = 505
        Me.ChkAccountAdjustmentsShadingYes.TabStop = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkCustomerReturnsShadingNo)
        Me.GroupBox3.Controls.Add(Me.ChkCustomerReturnsShadingYes)
        Me.GroupBox3.Location = New System.Drawing.Point(208, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox3.TabIndex = 507
        Me.GroupBox3.TabStop = False
        '
        'ChkCustomerReturnsShadingNo
        '
        Me.ChkCustomerReturnsShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkCustomerReturnsShadingNo.Name = "ChkCustomerReturnsShadingNo"
        Me.ChkCustomerReturnsShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkCustomerReturnsShadingNo.TabIndex = 506
        '
        'ChkCustomerReturnsShadingYes
        '
        Me.ChkCustomerReturnsShadingYes.Checked = True
        Me.ChkCustomerReturnsShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkCustomerReturnsShadingYes.Name = "ChkCustomerReturnsShadingYes"
        Me.ChkCustomerReturnsShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkCustomerReturnsShadingYes.TabIndex = 505
        Me.ChkCustomerReturnsShadingYes.TabStop = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkWorkOrdersShadingNo)
        Me.GroupBox2.Controls.Add(Me.ChkWorkOrdersShadingYes)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox2.TabIndex = 506
        Me.GroupBox2.TabStop = False
        '
        'ChkWorkOrdersShadingNo
        '
        Me.ChkWorkOrdersShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkWorkOrdersShadingNo.Name = "ChkWorkOrdersShadingNo"
        Me.ChkWorkOrdersShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkWorkOrdersShadingNo.TabIndex = 506
        '
        'ChkWorkOrdersShadingYes
        '
        Me.ChkWorkOrdersShadingYes.Checked = True
        Me.ChkWorkOrdersShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkWorkOrdersShadingYes.Name = "ChkWorkOrdersShadingYes"
        Me.ChkWorkOrdersShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkWorkOrdersShadingYes.TabIndex = 505
        Me.ChkWorkOrdersShadingYes.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkEstimatesShadingNo)
        Me.GroupBox1.Controls.Add(Me.ChkEstimatesShadingYes)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 24)
        Me.GroupBox1.TabIndex = 505
        Me.GroupBox1.TabStop = False
        '
        'ChkEstimatesShadingNo
        '
        Me.ChkEstimatesShadingNo.Location = New System.Drawing.Point(139, 8)
        Me.ChkEstimatesShadingNo.Name = "ChkEstimatesShadingNo"
        Me.ChkEstimatesShadingNo.Size = New System.Drawing.Size(13, 14)
        Me.ChkEstimatesShadingNo.TabIndex = 506
        '
        'ChkEstimatesShadingYes
        '
        Me.ChkEstimatesShadingYes.Checked = True
        Me.ChkEstimatesShadingYes.Location = New System.Drawing.Point(29, 8)
        Me.ChkEstimatesShadingYes.Name = "ChkEstimatesShadingYes"
        Me.ChkEstimatesShadingYes.Size = New System.Drawing.Size(13, 14)
        Me.ChkEstimatesShadingYes.TabIndex = 505
        Me.ChkEstimatesShadingYes.TabStop = True
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label69.Location = New System.Drawing.Point(13, 233)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(142, 20)
        Me.Label69.TabIndex = 503
        Me.Label69.Text = "Purchases Orders"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label70.Location = New System.Drawing.Point(13, 210)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(142, 19)
        Me.Label70.TabIndex = 502
        Me.Label70.Text = "Inventory Adjustments"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label71.Location = New System.Drawing.Point(13, 187)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(142, 19)
        Me.Label71.TabIndex = 501
        Me.Label71.Text = "Inventory Returns"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label72.Location = New System.Drawing.Point(13, 163)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(142, 20)
        Me.Label72.TabIndex = 500
        Me.Label72.Text = "Inventory Receipts"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label66.Location = New System.Drawing.Point(310, 3)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(96, 19)
        Me.Label66.TabIndex = 499
        Me.Label66.Text = "No Shadings"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label58.Location = New System.Drawing.Point(199, 3)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(96, 19)
        Me.Label58.TabIndex = 498
        Me.Label58.Text = "Shadings"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label59.Location = New System.Drawing.Point(46, 3)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(96, 19)
        Me.Label59.TabIndex = 497
        Me.Label59.Text = "Form Name"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label60.Location = New System.Drawing.Point(13, 140)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(142, 19)
        Me.Label60.TabIndex = 496
        Me.Label60.Text = "Account Adjustments"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label61.Location = New System.Drawing.Point(13, 116)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(142, 20)
        Me.Label61.TabIndex = 495
        Me.Label61.Text = "Customer Payments"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label62.Location = New System.Drawing.Point(13, 92)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(142, 20)
        Me.Label62.TabIndex = 494
        Me.Label62.Text = "Customer Returns"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label63.Location = New System.Drawing.Point(13, 69)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(142, 19)
        Me.Label63.TabIndex = 493
        Me.Label63.Text = "Invoices"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label64.Location = New System.Drawing.Point(13, 46)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(142, 19)
        Me.Label64.TabIndex = 492
        Me.Label64.Text = "Work Orders"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label65.Location = New System.Drawing.Point(13, 22)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(142, 20)
        Me.Label65.TabIndex = 491
        Me.Label65.Text = "Estimates"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TxtLABEL_INVOICE_COPY3)
        Me.TabPage5.Controls.Add(Me.TxtLABEL_INVOICE_COPY2)
        Me.TabPage5.Controls.Add(Me.TxtLABEL_INVOICE_COPY1)
        Me.TabPage5.Controls.Add(Me.NumNO_OF_COPY_INPRINT_PO)
        Me.TabPage5.Controls.Add(Me.NumNO_OF_COPY_INPRINT_ROA)
        Me.TabPage5.Controls.Add(Me.NumNO_OF_COPY_INPRINT_ES)
        Me.TabPage5.Controls.Add(Me.NumNO_OF_COPY_INPRINT_WO)
        Me.TabPage5.Controls.Add(Me.NumNO_OF_COPY_INPRINT_IN)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYSALESMOTTO_Checks)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYSALESMOTTO_PO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYSALESMOTTO_ROA)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYSALESMOTTO_ES)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYSALESMOTTO_WO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYSALESMOTTO_IN)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYLOGO_Checks)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYLOGO_PO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYLOGO_ROA)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYLOGO_ES)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYLOGO_WO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_COMPANYLOGO_IN)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STOREADDRESS_Checks)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STOREADDRESS_PO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STOREADDRESS_ROA)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STOREADDRESS_ES)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STOREADDRESS_WO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STOREADDRESS_IN)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STORENAME_Checks)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STORENAME_PO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STORENAME_ROA)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STORENAME_ES)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STORENAME_WO)
        Me.TabPage5.Controls.Add(Me.ChkPRINT_STORENAME_IN)
        Me.TabPage5.Controls.Add(Me.Label32)
        Me.TabPage5.Controls.Add(Me.Label31)
        Me.TabPage5.Controls.Add(Me.Label30)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.Label25)
        Me.TabPage5.Controls.Add(Me.Label26)
        Me.TabPage5.Controls.Add(Me.Label35)
        Me.TabPage5.Controls.Add(Me.Label34)
        Me.TabPage5.Controls.Add(Me.Label33)
        Me.TabPage5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(577, 262)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Forms"
        '
        'TxtLABEL_INVOICE_COPY3
        '
        Me.TxtLABEL_INVOICE_COPY3.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLABEL_INVOICE_COPY3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtLABEL_INVOICE_COPY3.Location = New System.Drawing.Point(167, 228)
        Me.TxtLABEL_INVOICE_COPY3.MaxLength = 50
        Me.TxtLABEL_INVOICE_COPY3.Name = "TxtLABEL_INVOICE_COPY3"
        Me.TxtLABEL_INVOICE_COPY3.Size = New System.Drawing.Size(335, 20)
        Me.TxtLABEL_INVOICE_COPY3.TabIndex = 33
        Me.TxtLABEL_INVOICE_COPY3.Text = ""
        '
        'TxtLABEL_INVOICE_COPY2
        '
        Me.TxtLABEL_INVOICE_COPY2.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLABEL_INVOICE_COPY2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtLABEL_INVOICE_COPY2.Location = New System.Drawing.Point(167, 206)
        Me.TxtLABEL_INVOICE_COPY2.MaxLength = 50
        Me.TxtLABEL_INVOICE_COPY2.Name = "TxtLABEL_INVOICE_COPY2"
        Me.TxtLABEL_INVOICE_COPY2.Size = New System.Drawing.Size(335, 20)
        Me.TxtLABEL_INVOICE_COPY2.TabIndex = 32
        Me.TxtLABEL_INVOICE_COPY2.Text = ""
        '
        'TxtLABEL_INVOICE_COPY1
        '
        Me.TxtLABEL_INVOICE_COPY1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLABEL_INVOICE_COPY1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtLABEL_INVOICE_COPY1.Location = New System.Drawing.Point(167, 184)
        Me.TxtLABEL_INVOICE_COPY1.MaxLength = 50
        Me.TxtLABEL_INVOICE_COPY1.Name = "TxtLABEL_INVOICE_COPY1"
        Me.TxtLABEL_INVOICE_COPY1.Size = New System.Drawing.Size(335, 20)
        Me.TxtLABEL_INVOICE_COPY1.TabIndex = 29
        Me.TxtLABEL_INVOICE_COPY1.Text = ""
        '
        'NumNO_OF_COPY_INPRINT_PO
        '
        Me.NumNO_OF_COPY_INPRINT_PO.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNO_OF_COPY_INPRINT_PO.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNO_OF_COPY_INPRINT_PO.DecimalDigits = 0
        Me.NumNO_OF_COPY_INPRINT_PO.DefaultSendValue = False
        Me.NumNO_OF_COPY_INPRINT_PO.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNO_OF_COPY_INPRINT_PO.FireTabAfterEnter = True
        Me.NumNO_OF_COPY_INPRINT_PO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumNO_OF_COPY_INPRINT_PO.Image = CType(resources.GetObject("NumNO_OF_COPY_INPRINT_PO.Image"), System.Drawing.Image)
        Me.NumNO_OF_COPY_INPRINT_PO.Location = New System.Drawing.Point(405, 154)
        Me.NumNO_OF_COPY_INPRINT_PO.Maxlength = 2
        Me.NumNO_OF_COPY_INPRINT_PO.MinusColor = System.Drawing.Color.Empty
        Me.NumNO_OF_COPY_INPRINT_PO.Name = "NumNO_OF_COPY_INPRINT_PO"
        Me.NumNO_OF_COPY_INPRINT_PO.Size = New System.Drawing.Size(33, 20)
        Me.NumNO_OF_COPY_INPRINT_PO.TabIndex = 28
        Me.NumNO_OF_COPY_INPRINT_PO.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNO_OF_COPY_INPRINT_PO.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumNO_OF_COPY_INPRINT_ROA
        '
        Me.NumNO_OF_COPY_INPRINT_ROA.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNO_OF_COPY_INPRINT_ROA.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNO_OF_COPY_INPRINT_ROA.DecimalDigits = 0
        Me.NumNO_OF_COPY_INPRINT_ROA.DefaultSendValue = False
        Me.NumNO_OF_COPY_INPRINT_ROA.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNO_OF_COPY_INPRINT_ROA.FireTabAfterEnter = True
        Me.NumNO_OF_COPY_INPRINT_ROA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumNO_OF_COPY_INPRINT_ROA.Image = CType(resources.GetObject("NumNO_OF_COPY_INPRINT_ROA.Image"), System.Drawing.Image)
        Me.NumNO_OF_COPY_INPRINT_ROA.Location = New System.Drawing.Point(346, 154)
        Me.NumNO_OF_COPY_INPRINT_ROA.Maxlength = 2
        Me.NumNO_OF_COPY_INPRINT_ROA.MinusColor = System.Drawing.Color.Empty
        Me.NumNO_OF_COPY_INPRINT_ROA.Name = "NumNO_OF_COPY_INPRINT_ROA"
        Me.NumNO_OF_COPY_INPRINT_ROA.Size = New System.Drawing.Size(33, 20)
        Me.NumNO_OF_COPY_INPRINT_ROA.TabIndex = 27
        Me.NumNO_OF_COPY_INPRINT_ROA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNO_OF_COPY_INPRINT_ROA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumNO_OF_COPY_INPRINT_ES
        '
        Me.NumNO_OF_COPY_INPRINT_ES.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNO_OF_COPY_INPRINT_ES.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNO_OF_COPY_INPRINT_ES.DecimalDigits = 0
        Me.NumNO_OF_COPY_INPRINT_ES.DefaultSendValue = False
        Me.NumNO_OF_COPY_INPRINT_ES.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNO_OF_COPY_INPRINT_ES.FireTabAfterEnter = True
        Me.NumNO_OF_COPY_INPRINT_ES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumNO_OF_COPY_INPRINT_ES.Image = CType(resources.GetObject("NumNO_OF_COPY_INPRINT_ES.Image"), System.Drawing.Image)
        Me.NumNO_OF_COPY_INPRINT_ES.Location = New System.Drawing.Point(283, 154)
        Me.NumNO_OF_COPY_INPRINT_ES.Maxlength = 2
        Me.NumNO_OF_COPY_INPRINT_ES.MinusColor = System.Drawing.Color.Empty
        Me.NumNO_OF_COPY_INPRINT_ES.Name = "NumNO_OF_COPY_INPRINT_ES"
        Me.NumNO_OF_COPY_INPRINT_ES.Size = New System.Drawing.Size(33, 20)
        Me.NumNO_OF_COPY_INPRINT_ES.TabIndex = 26
        Me.NumNO_OF_COPY_INPRINT_ES.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNO_OF_COPY_INPRINT_ES.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumNO_OF_COPY_INPRINT_WO
        '
        Me.NumNO_OF_COPY_INPRINT_WO.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNO_OF_COPY_INPRINT_WO.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNO_OF_COPY_INPRINT_WO.DecimalDigits = 0
        Me.NumNO_OF_COPY_INPRINT_WO.DefaultSendValue = False
        Me.NumNO_OF_COPY_INPRINT_WO.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNO_OF_COPY_INPRINT_WO.FireTabAfterEnter = True
        Me.NumNO_OF_COPY_INPRINT_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumNO_OF_COPY_INPRINT_WO.Image = CType(resources.GetObject("NumNO_OF_COPY_INPRINT_WO.Image"), System.Drawing.Image)
        Me.NumNO_OF_COPY_INPRINT_WO.Location = New System.Drawing.Point(225, 154)
        Me.NumNO_OF_COPY_INPRINT_WO.Maxlength = 2
        Me.NumNO_OF_COPY_INPRINT_WO.MinusColor = System.Drawing.Color.Empty
        Me.NumNO_OF_COPY_INPRINT_WO.Name = "NumNO_OF_COPY_INPRINT_WO"
        Me.NumNO_OF_COPY_INPRINT_WO.Size = New System.Drawing.Size(33, 20)
        Me.NumNO_OF_COPY_INPRINT_WO.TabIndex = 25
        Me.NumNO_OF_COPY_INPRINT_WO.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNO_OF_COPY_INPRINT_WO.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumNO_OF_COPY_INPRINT_IN
        '
        Me.NumNO_OF_COPY_INPRINT_IN.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNO_OF_COPY_INPRINT_IN.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNO_OF_COPY_INPRINT_IN.DecimalDigits = 0
        Me.NumNO_OF_COPY_INPRINT_IN.DefaultSendValue = False
        Me.NumNO_OF_COPY_INPRINT_IN.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNO_OF_COPY_INPRINT_IN.FireTabAfterEnter = True
        Me.NumNO_OF_COPY_INPRINT_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumNO_OF_COPY_INPRINT_IN.Image = CType(resources.GetObject("NumNO_OF_COPY_INPRINT_IN.Image"), System.Drawing.Image)
        Me.NumNO_OF_COPY_INPRINT_IN.Location = New System.Drawing.Point(168, 154)
        Me.NumNO_OF_COPY_INPRINT_IN.Maxlength = 2
        Me.NumNO_OF_COPY_INPRINT_IN.MinusColor = System.Drawing.Color.Empty
        Me.NumNO_OF_COPY_INPRINT_IN.Name = "NumNO_OF_COPY_INPRINT_IN"
        Me.NumNO_OF_COPY_INPRINT_IN.Size = New System.Drawing.Size(33, 20)
        Me.NumNO_OF_COPY_INPRINT_IN.TabIndex = 24
        Me.NumNO_OF_COPY_INPRINT_IN.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNO_OF_COPY_INPRINT_IN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkPRINT_COMPANYSALESMOTTO_Checks
        '
        Me.ChkPRINT_COMPANYSALESMOTTO_Checks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYSALESMOTTO_Checks.Location = New System.Drawing.Point(481, 124)
        Me.ChkPRINT_COMPANYSALESMOTTO_Checks.Name = "ChkPRINT_COMPANYSALESMOTTO_Checks"
        Me.ChkPRINT_COMPANYSALESMOTTO_Checks.Size = New System.Drawing.Size(13, 22)
        Me.ChkPRINT_COMPANYSALESMOTTO_Checks.TabIndex = 23
        '
        'ChkPRINT_COMPANYSALESMOTTO_PO
        '
        Me.ChkPRINT_COMPANYSALESMOTTO_PO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYSALESMOTTO_PO.Location = New System.Drawing.Point(414, 124)
        Me.ChkPRINT_COMPANYSALESMOTTO_PO.Name = "ChkPRINT_COMPANYSALESMOTTO_PO"
        Me.ChkPRINT_COMPANYSALESMOTTO_PO.Size = New System.Drawing.Size(13, 22)
        Me.ChkPRINT_COMPANYSALESMOTTO_PO.TabIndex = 22
        '
        'ChkPRINT_COMPANYSALESMOTTO_ROA
        '
        Me.ChkPRINT_COMPANYSALESMOTTO_ROA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYSALESMOTTO_ROA.Location = New System.Drawing.Point(357, 124)
        Me.ChkPRINT_COMPANYSALESMOTTO_ROA.Name = "ChkPRINT_COMPANYSALESMOTTO_ROA"
        Me.ChkPRINT_COMPANYSALESMOTTO_ROA.Size = New System.Drawing.Size(13, 22)
        Me.ChkPRINT_COMPANYSALESMOTTO_ROA.TabIndex = 21
        '
        'ChkPRINT_COMPANYSALESMOTTO_ES
        '
        Me.ChkPRINT_COMPANYSALESMOTTO_ES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYSALESMOTTO_ES.Location = New System.Drawing.Point(295, 124)
        Me.ChkPRINT_COMPANYSALESMOTTO_ES.Name = "ChkPRINT_COMPANYSALESMOTTO_ES"
        Me.ChkPRINT_COMPANYSALESMOTTO_ES.Size = New System.Drawing.Size(13, 22)
        Me.ChkPRINT_COMPANYSALESMOTTO_ES.TabIndex = 20
        '
        'ChkPRINT_COMPANYSALESMOTTO_WO
        '
        Me.ChkPRINT_COMPANYSALESMOTTO_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYSALESMOTTO_WO.Location = New System.Drawing.Point(236, 124)
        Me.ChkPRINT_COMPANYSALESMOTTO_WO.Name = "ChkPRINT_COMPANYSALESMOTTO_WO"
        Me.ChkPRINT_COMPANYSALESMOTTO_WO.Size = New System.Drawing.Size(13, 22)
        Me.ChkPRINT_COMPANYSALESMOTTO_WO.TabIndex = 19
        '
        'ChkPRINT_COMPANYSALESMOTTO_IN
        '
        Me.ChkPRINT_COMPANYSALESMOTTO_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYSALESMOTTO_IN.Location = New System.Drawing.Point(177, 124)
        Me.ChkPRINT_COMPANYSALESMOTTO_IN.Name = "ChkPRINT_COMPANYSALESMOTTO_IN"
        Me.ChkPRINT_COMPANYSALESMOTTO_IN.Size = New System.Drawing.Size(13, 22)
        Me.ChkPRINT_COMPANYSALESMOTTO_IN.TabIndex = 18
        '
        'ChkPRINT_COMPANYLOGO_Checks
        '
        Me.ChkPRINT_COMPANYLOGO_Checks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYLOGO_Checks.Location = New System.Drawing.Point(481, 96)
        Me.ChkPRINT_COMPANYLOGO_Checks.Name = "ChkPRINT_COMPANYLOGO_Checks"
        Me.ChkPRINT_COMPANYLOGO_Checks.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_COMPANYLOGO_Checks.TabIndex = 17
        '
        'ChkPRINT_COMPANYLOGO_PO
        '
        Me.ChkPRINT_COMPANYLOGO_PO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYLOGO_PO.Location = New System.Drawing.Point(414, 96)
        Me.ChkPRINT_COMPANYLOGO_PO.Name = "ChkPRINT_COMPANYLOGO_PO"
        Me.ChkPRINT_COMPANYLOGO_PO.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_COMPANYLOGO_PO.TabIndex = 16
        '
        'ChkPRINT_COMPANYLOGO_ROA
        '
        Me.ChkPRINT_COMPANYLOGO_ROA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYLOGO_ROA.Location = New System.Drawing.Point(357, 96)
        Me.ChkPRINT_COMPANYLOGO_ROA.Name = "ChkPRINT_COMPANYLOGO_ROA"
        Me.ChkPRINT_COMPANYLOGO_ROA.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_COMPANYLOGO_ROA.TabIndex = 15
        '
        'ChkPRINT_COMPANYLOGO_ES
        '
        Me.ChkPRINT_COMPANYLOGO_ES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYLOGO_ES.Location = New System.Drawing.Point(295, 96)
        Me.ChkPRINT_COMPANYLOGO_ES.Name = "ChkPRINT_COMPANYLOGO_ES"
        Me.ChkPRINT_COMPANYLOGO_ES.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_COMPANYLOGO_ES.TabIndex = 14
        '
        'ChkPRINT_COMPANYLOGO_WO
        '
        Me.ChkPRINT_COMPANYLOGO_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYLOGO_WO.Location = New System.Drawing.Point(236, 96)
        Me.ChkPRINT_COMPANYLOGO_WO.Name = "ChkPRINT_COMPANYLOGO_WO"
        Me.ChkPRINT_COMPANYLOGO_WO.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_COMPANYLOGO_WO.TabIndex = 13
        '
        'ChkPRINT_COMPANYLOGO_IN
        '
        Me.ChkPRINT_COMPANYLOGO_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_COMPANYLOGO_IN.Location = New System.Drawing.Point(177, 96)
        Me.ChkPRINT_COMPANYLOGO_IN.Name = "ChkPRINT_COMPANYLOGO_IN"
        Me.ChkPRINT_COMPANYLOGO_IN.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_COMPANYLOGO_IN.TabIndex = 12
        '
        'ChkPRINT_STOREADDRESS_Checks
        '
        Me.ChkPRINT_STOREADDRESS_Checks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STOREADDRESS_Checks.Location = New System.Drawing.Point(481, 66)
        Me.ChkPRINT_STOREADDRESS_Checks.Name = "ChkPRINT_STOREADDRESS_Checks"
        Me.ChkPRINT_STOREADDRESS_Checks.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STOREADDRESS_Checks.TabIndex = 11
        '
        'ChkPRINT_STOREADDRESS_PO
        '
        Me.ChkPRINT_STOREADDRESS_PO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STOREADDRESS_PO.Location = New System.Drawing.Point(414, 66)
        Me.ChkPRINT_STOREADDRESS_PO.Name = "ChkPRINT_STOREADDRESS_PO"
        Me.ChkPRINT_STOREADDRESS_PO.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STOREADDRESS_PO.TabIndex = 10
        '
        'ChkPRINT_STOREADDRESS_ROA
        '
        Me.ChkPRINT_STOREADDRESS_ROA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STOREADDRESS_ROA.Location = New System.Drawing.Point(357, 66)
        Me.ChkPRINT_STOREADDRESS_ROA.Name = "ChkPRINT_STOREADDRESS_ROA"
        Me.ChkPRINT_STOREADDRESS_ROA.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STOREADDRESS_ROA.TabIndex = 9
        '
        'ChkPRINT_STOREADDRESS_ES
        '
        Me.ChkPRINT_STOREADDRESS_ES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STOREADDRESS_ES.Location = New System.Drawing.Point(295, 66)
        Me.ChkPRINT_STOREADDRESS_ES.Name = "ChkPRINT_STOREADDRESS_ES"
        Me.ChkPRINT_STOREADDRESS_ES.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STOREADDRESS_ES.TabIndex = 8
        '
        'ChkPRINT_STOREADDRESS_WO
        '
        Me.ChkPRINT_STOREADDRESS_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STOREADDRESS_WO.Location = New System.Drawing.Point(236, 66)
        Me.ChkPRINT_STOREADDRESS_WO.Name = "ChkPRINT_STOREADDRESS_WO"
        Me.ChkPRINT_STOREADDRESS_WO.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STOREADDRESS_WO.TabIndex = 7
        '
        'ChkPRINT_STOREADDRESS_IN
        '
        Me.ChkPRINT_STOREADDRESS_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STOREADDRESS_IN.Location = New System.Drawing.Point(177, 66)
        Me.ChkPRINT_STOREADDRESS_IN.Name = "ChkPRINT_STOREADDRESS_IN"
        Me.ChkPRINT_STOREADDRESS_IN.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STOREADDRESS_IN.TabIndex = 6
        '
        'ChkPRINT_STORENAME_Checks
        '
        Me.ChkPRINT_STORENAME_Checks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STORENAME_Checks.Location = New System.Drawing.Point(481, 38)
        Me.ChkPRINT_STORENAME_Checks.Name = "ChkPRINT_STORENAME_Checks"
        Me.ChkPRINT_STORENAME_Checks.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STORENAME_Checks.TabIndex = 5
        '
        'ChkPRINT_STORENAME_PO
        '
        Me.ChkPRINT_STORENAME_PO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STORENAME_PO.Location = New System.Drawing.Point(414, 38)
        Me.ChkPRINT_STORENAME_PO.Name = "ChkPRINT_STORENAME_PO"
        Me.ChkPRINT_STORENAME_PO.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STORENAME_PO.TabIndex = 4
        '
        'ChkPRINT_STORENAME_ROA
        '
        Me.ChkPRINT_STORENAME_ROA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STORENAME_ROA.Location = New System.Drawing.Point(357, 38)
        Me.ChkPRINT_STORENAME_ROA.Name = "ChkPRINT_STORENAME_ROA"
        Me.ChkPRINT_STORENAME_ROA.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STORENAME_ROA.TabIndex = 3
        '
        'ChkPRINT_STORENAME_ES
        '
        Me.ChkPRINT_STORENAME_ES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STORENAME_ES.Location = New System.Drawing.Point(295, 38)
        Me.ChkPRINT_STORENAME_ES.Name = "ChkPRINT_STORENAME_ES"
        Me.ChkPRINT_STORENAME_ES.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STORENAME_ES.TabIndex = 2
        '
        'ChkPRINT_STORENAME_WO
        '
        Me.ChkPRINT_STORENAME_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STORENAME_WO.Location = New System.Drawing.Point(236, 38)
        Me.ChkPRINT_STORENAME_WO.Name = "ChkPRINT_STORENAME_WO"
        Me.ChkPRINT_STORENAME_WO.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STORENAME_WO.TabIndex = 1
        '
        'ChkPRINT_STORENAME_IN
        '
        Me.ChkPRINT_STORENAME_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPRINT_STORENAME_IN.Location = New System.Drawing.Point(177, 38)
        Me.ChkPRINT_STORENAME_IN.Name = "ChkPRINT_STORENAME_IN"
        Me.ChkPRINT_STORENAME_IN.Size = New System.Drawing.Size(13, 21)
        Me.ChkPRINT_STORENAME_IN.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(466, 15)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(46, 19)
        Me.Label32.TabIndex = 494
        Me.Label32.Text = "Checks"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(407, 15)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(29, 19)
        Me.Label31.TabIndex = 493
        Me.Label31.Text = "PO"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(348, 15)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(29, 19)
        Me.Label30.TabIndex = 492
        Me.Label30.Text = "ROA"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(289, 15)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(29, 19)
        Me.Label29.TabIndex = 491
        Me.Label29.Text = "ES"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(230, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 19)
        Me.Label28.TabIndex = 490
        Me.Label28.Text = "WO"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(171, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 19)
        Me.Label27.TabIndex = 489
        Me.Label27.Text = "IN"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(15, 182)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(142, 19)
        Me.Label21.TabIndex = 488
        Me.Label21.Text = "Labels For Invoice Copies"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(15, 153)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 20)
        Me.Label22.TabIndex = 487
        Me.Label22.Text = "No Of Copies To Print"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(15, 124)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(142, 20)
        Me.Label23.TabIndex = 486
        Me.Label23.Text = "Print Company Sales Motto"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(15, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(142, 19)
        Me.Label24.TabIndex = 485
        Me.Label24.Text = "Print Company LOGO"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(15, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(142, 19)
        Me.Label25.TabIndex = 484
        Me.Label25.Text = "Print Store Address"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(15, 38)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(142, 20)
        Me.Label26.TabIndex = 483
        Me.Label26.Text = "Print Store Name"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(153, 228)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 20)
        Me.Label35.TabIndex = 31
        Me.Label35.Text = "3"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(153, 206)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 20)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "2"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(153, 184)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(16, 19)
        Me.Label33.TabIndex = 34
        Me.Label33.Text = "1"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label44)
        Me.Panel9.Controls.Add(Me.BtnSortOrder)
        Me.Panel9.Controls.Add(Me.Label40)
        Me.Panel9.Controls.Add(Me.BtnFirst)
        Me.Panel9.Controls.Add(Me.Label41)
        Me.Panel9.Controls.Add(Me.BtnLast)
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label43)
        Me.Panel9.Controls.Add(Me.BtnEdit)
        Me.Panel9.Controls.Add(Me.Label50)
        Me.Panel9.Controls.Add(Me.Label51)
        Me.Panel9.Controls.Add(Me.Label52)
        Me.Panel9.Controls.Add(Me.Label53)
        Me.Panel9.Controls.Add(Me.Label54)
        Me.Panel9.Controls.Add(Me.Label55)
        Me.Panel9.Controls.Add(Me.BtnDelete)
        Me.Panel9.Controls.Add(Me.BtnNew)
        Me.Panel9.Controls.Add(Me.BtnFind)
        Me.Panel9.Controls.Add(Me.BtnNext)
        Me.Panel9.Controls.Add(Me.BtnPrev)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(599, 45)
        Me.Panel9.TabIndex = 2
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label44.Location = New System.Drawing.Point(499, 31)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(43, 10)
        Me.Label44.TabIndex = 196
        Me.Label44.Text = "Order"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSortOrder
        '
        Me.BtnSortOrder.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.BtnSortOrder.DropDownContextMenu = Me.UIContextMenu1
        Me.BtnSortOrder.Image = CType(resources.GetObject("BtnSortOrder.Image"), System.Drawing.Image)
        Me.BtnSortOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSortOrder.Location = New System.Drawing.Point(497, 2)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 27)
        Me.BtnSortOrder.TabIndex = 195
        '
        'UIContextMenu1
        '
        Me.UIContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UIContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort11, Me.Sort21, Me.Sort31})
        Me.UIContextMenu1.Key = "UiContextMenu1"
        Me.UIContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UIContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort1, Me.Sort2, Me.Sort32})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UIContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("a83a6ad4-a65a-4d31-ba54-dfb24cc8c29e")
        Me.UiCommandManager1.LeftRebar = Me.LeftRebar1
        Me.UiCommandManager1.RightRebar = Me.RightRebar1
        Me.UiCommandManager1.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UiCommandManager1
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.TabIndex = 0
        '
        'Sort1
        '
        Me.Sort1.Key = "Sort1"
        Me.Sort1.Name = "Sort1"
        Me.Sort1.Text = "Order By Store No"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Store Name"
        '
        'Sort32
        '
        Me.Sort32.Key = "Sort3"
        Me.Sort32.Name = "Sort32"
        Me.Sort32.Text = "Order By Short Name"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UiCommandManager1
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.TabIndex = 0
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UiCommandManager1
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.TabIndex = 0
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.UiCommandManager1
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.TabIndex = 0
        '
        'Sort11
        '
        Me.Sort11.Checked = Janus.Windows.UI.InheritableBoolean.True
        Me.Sort11.Key = "Sort1"
        Me.Sort11.Name = "Sort11"
        '
        'Sort21
        '
        Me.Sort21.Key = "Sort2"
        Me.Sort21.Name = "Sort21"
        '
        'Sort31
        '
        Me.Sort31.Key = "Sort3"
        Me.Sort31.Name = "Sort31"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(6, 31)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 10)
        Me.Label40.TabIndex = 192
        Me.Label40.Text = "First"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(3, 2)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(133, 31)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(33, 10)
        Me.Label41.TabIndex = 189
        Me.Label41.Text = "Last"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(132, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(425, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(428, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(303, 31)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 10)
        Me.Label43.TabIndex = 184
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(300, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(384, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(342, 30)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 11)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(259, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(197, 31)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 10)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(46, 31)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 10)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(91, 31)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(33, 10)
        Me.Label55.TabIndex = 171
        Me.Label55.Text = "Next"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(342, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(260, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(196, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(89, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(46, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(384, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'Sort3
        '
        Me.Sort3.Key = "SortByType"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Sort By Type"
        '
        'SortByType1
        '
        Me.SortByType1.Key = "SortByType"
        Me.SortByType1.Name = "SortByType1"
        '
        'Command2
        '
        Me.Command2.Key = "Command2"
        Me.Command2.Name = "Command2"
        Me.Command2.Text = "2222222"
        '
        'Command21
        '
        Me.Command21.Key = "Command2"
        Me.Command21.Name = "Command21"
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbSelectCommand1
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Me.OleDbSelectCommand1.Connection = Me.CnnMDB
        '
        'CnnMDB
        '
        Me.CnnMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.CnnMDB
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "INSERT INTO STORE_SETUP (ADDRESS, AREACODE, CASH_CUSTOMER, CITY, COUNTY, DISCLAIM" & _
        "ER_FOR_ES, DISCLAIMER_FOR_IN, DISCLAIMER_FOR_WO, EMAIL, FAX, FEDERAL_TAX_ID, FUN" & _
        "CTIONS1, FUNCTIONS10, FUNCTIONS11, FUNCTIONS12, FUNCTIONS13, FUNCTIONS14, FUNCTI" & _
        "ONS15, FUNCTIONS16, FUNCTIONS17, FUNCTIONS2, FUNCTIONS3, FUNCTIONS4, FUNCTIONS5," & _
        " FUNCTIONS6, FUNCTIONS7, FUNCTIONS8, FUNCTIONS9, LABEL_INVOICE_COPY1, LABEL_INVO" & _
        "ICE_COPY2, LABEL_INVOICE_COPY3, NO_OF_COPY_INPRINT_CHECKS, NO_OF_COPY_INPRINT_ES" & _
        ", NO_OF_COPY_INPRINT_IN, NO_OF_COPY_INPRINT_PO, NO_OF_COPY_INPRINT_ROA, NO_OF_CO" & _
        "PY_INPRINT_WO, PHONE, PRINT_COMPANYLOGO_CHECKS, PRINT_COMPANYLOGO_ES, PRINT_COMP" & _
        "ANYLOGO_IN, PRINT_COMPANYLOGO_PO, PRINT_COMPANYLOGO_ROA, PRINT_COMPANYLOGO_WO, P" & _
        "RINT_COMPANYSALESMOTTO_CHECKS, PRINT_COMPANYSALESMOTTO_ES, PRINT_COMPANYSALESMOT" & _
        "TO_IN, PRINT_COMPANYSALESMOTTO_PO, PRINT_COMPANYSALESMOTTO_ROA, PRINT_COMPANYSAL" & _
        "ESMOTTO_WO, PRINT_STOREADDRESS_CHECKS, PRINT_STOREADDRESS_ES, PRINT_STOREADDRESS" & _
        "_IN, PRINT_STOREADDRESS_PO, PRINT_STOREADDRESS_ROA, PRINT_STOREADDRESS_WO, PRINT" & _
        "_STORENAME_CHECKS, PRINT_STORENAME_ES, PRINT_STORENAME_IN, PRINT_STORENAME_PO, P" & _
        "RINT_STORENAME_ROA, PRINT_STORENAME_WO, RULES1, RULES10, RULES11, RULES12, RULES" & _
        "2, RULES3, RULES4, RULES5, RULES6, RULES7, RULES8, RULES9, SALES_TAX, SALES_TAX_" & _
        "ID, SALESPERSON, SHORTNAME, STATE, STATE_TAX_ID, STORENAME, STORENO, TECHNISIAN," & _
        " WARRANTY_FOR_ES, WARRANTY_FOR_IN, WARRANTY_FOR_WO, ZIPCODE) VALUES (ADDRESS, AR" & _
        "EACODE, CASH_CUSTOMER, CITY, COUNTY, DISCLAIMER_FOR_ES, DISCLAIMER_FOR_IN, DISCL" & _
        "AIMER_FOR_WO, EMAIL, FAX, FEDERAL_TAX_ID, FUNCTIONS1, FUNCTIONS10, FUNCTIONS11, " & _
        "FUNCTIONS12, FUNCTIONS13, FUNCTIONS14, FUNCTIONS15, FUNCTIONS16, FUNCTIONS17, FU" & _
        "NCTIONS2, FUNCTIONS3, FUNCTIONS4, FUNCTIONS5, FUNCTIONS6, FUNCTIONS7, FUNCTIONS8" & _
        ", FUNCTIONS9, LABEL_INVOICE_COPY1, LABEL_INVOICE_COPY2, LABEL_INVOICE_COPY3, NO_" & _
        "OF_COPY_INPRINT_CHECKS, NO_OF_COPY_INPRINT_ES, NO_OF_COPY_INPRINT_IN, NO_OF_COPY" & _
        "_INPRINT_PO, NO_OF_COPY_INPRINT_ROA, NO_OF_COPY_INPRINT_WO, PHONE, PRINT_COMPANY" & _
        "LOGO_CHECKS, PRINT_COMPANYLOGO_ES, PRINT_COMPANYLOGO_IN, PRINT_COMPANYLOGO_PO, P" & _
        "RINT_COMPANYLOGO_ROA, PRINT_COMPANYLOGO_WO, PRINT_COMPANYSALESMOTTO_CHECKS, PRIN" & _
        "T_COMPANYSALESMOTTO_ES, PRINT_COMPANYSALESMOTTO_IN, PRINT_COMPANYSALESMOTTO_PO, " & _
        "PRINT_COMPANYSALESMOTTO_ROA, PRINT_COMPANYSALESMOTTO_WO, PRINT_STOREADDRESS_CHEC" & _
        "KS, PRINT_STOREADDRESS_ES, PRINT_STOREADDRESS_IN, PRINT_STOREADDRESS_PO, PRINT_S" & _
        "TOREADDRESS_ROA, PRINT_STOREADDRESS_WO, PRINT_STORENAME_CHECKS, PRINT_STORENAME_" & _
        "ES, PRINT_STORENAME_IN, PRINT_STORENAME_PO, PRINT_STORENAME_ROA, PRINT_STORENAME" & _
        "_WO, RULES1, RULES10, RULES11, RULES12, RULES2, RULES3, RULES4, RULES5, RULES6, " & _
        "RULES7, RULES8, RULES9, SALES_TAX, SALES_TAX_ID, SALESPERSON, SHORTNAME, STATE, " & _
        "STATE_TAX_ID, STORENAME, STORENO, TECHNISIAN, WARRANTY_FOR_ES, WARRANTY_FOR_IN, " & _
        "WARRANTY_FOR_WO, ZIPCODE)"
        Me.OleDbCommand1.Connection = Me.CnnMDB
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand9
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_main", "phone_main"), New System.Data.Common.DataColumnMapping("phone_work", "phone_work"), New System.Data.Common.DataColumnMapping("phone_cell", "phone_cell"), New System.Data.Common.DataColumnMapping("phome_other", "phome_other"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("deduction_cod1", "deduction_cod1"), New System.Data.Common.DataColumnMapping("deduction_amount1", "deduction_amount1"), New System.Data.Common.DataColumnMapping("deduction_cod2", "deduction_cod2"), New System.Data.Common.DataColumnMapping("deduction_amount2", "deduction_amount2"), New System.Data.Common.DataColumnMapping("deduction_cod3", "deduction_cod3"), New System.Data.Common.DataColumnMapping("deduction_amount3", "deduction_amount3"), New System.Data.Common.DataColumnMapping("deduction_cod4", "deduction_cod4"), New System.Data.Common.DataColumnMapping("deduction_amount4", "deduction_amount4"), New System.Data.Common.DataColumnMapping("deduction_cod5", "deduction_cod5"), New System.Data.Common.DataColumnMapping("deduction_amount5", "deduction_amount5"), New System.Data.Common.DataColumnMapping("deduction_cod6", "deduction_cod6"), New System.Data.Common.DataColumnMapping("deduction_amount6", "deduction_amount6")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT employee_code, f_name + ' ' + m_name + ' ' + l_name AS employee_name FROM " & _
        "employee"
        Me.SqlSelectCommand9.Connection = Me.Cnn
        '
        'DACust_sales_tax
        '
        Me.DACust_sales_tax.DeleteCommand = Me.SqlDeleteCommand1
        Me.DACust_sales_tax.InsertCommand = Me.SqlInsertCommand1
        Me.DACust_sales_tax.SelectCommand = Me.SqlSelectCommand1
        Me.DACust_sales_tax.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_sales_tax", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("desc_sales_tax", "desc_sales_tax")})})
        Me.DACust_sales_tax.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cust_sales_tax WHERE (cod_sales_tax = @Original_cod_sales_tax) AND (d" & _
        "esc_sales_tax = @Original_desc_sales_tax OR @Original_desc_sales_tax IS NULL AND" & _
        " desc_sales_tax IS NULL)"
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_tax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cust_sales_tax(cod_sales_tax, desc_sales_tax) VALUES (@cod_sales_tax," & _
        " @desc_sales_tax); SELECT cod_sales_tax, desc_sales_tax FROM cust_sales_tax WHER" & _
        "E (cod_sales_tax = @cod_sales_tax)"
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_tax", System.Data.SqlDbType.VarChar, 50, "desc_sales_tax"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_sales_tax, desc_sales_tax FROM cust_sales_tax"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cust_sales_tax SET cod_sales_tax = @cod_sales_tax, desc_sales_tax = @desc_" & _
        "sales_tax WHERE (cod_sales_tax = @Original_cod_sales_tax) AND (desc_sales_tax = " & _
        "@Original_desc_sales_tax OR @Original_desc_sales_tax IS NULL AND desc_sales_tax " & _
        "IS NULL); SELECT cod_sales_tax, desc_sales_tax FROM cust_sales_tax WHERE (cod_sa" & _
        "les_tax = @cod_sales_tax)"
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_tax", System.Data.SqlDbType.VarChar, 50, "desc_sales_tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_tax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_zipcode
        '
        Me.DAbas_zipcode.SelectCommand = Me.SqlCommand8
        Me.DAbas_zipcode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_zipcode", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("county", "county"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("ariacode", "ariacode"), New System.Data.Common.DataColumnMapping("fips_code", "fips_code"), New System.Data.Common.DataColumnMapping("time_zone", "time_zone"), New System.Data.Common.DataColumnMapping("dst", "dst")})})
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "SELECT DISTINCT state FROM bas_zipcode"
        Me.SqlCommand8.Connection = Me.Cnn
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account, desc_GL_account FROM GL_account"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_account
        '
        Me.DAGL_account.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'CmdGeneralForMDB
        '
        Me.CmdGeneralForMDB.Connection = Me.CnnMDB
        '
        'FrmSTORESETUP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(599, 370)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmSTORESETUP"
        Me.Text = "STORE SETUP"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmSTORESETUP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmStoreSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables
        PnlSearchHeight = PnlSearch.Height

        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDB.Connection.Open()
        End If
        Try
            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD EstimatesShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set EstimatesShading=0 where EstimatesShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD WorkOrdersShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set WorkOrdersShading=0 where WorkOrdersShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD InvoicesShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set InvoicesShading=0 where InvoicesShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD CustomerReturnsShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set CustomerReturnsShading=0 where CustomerReturnsShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD CustomerPaymentsShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set CustomerPaymentsShading=0 where CustomerPaymentsShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD AccountAdjustmentsShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set AccountAdjustmentsShading=0 where AccountAdjustmentsShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD InventoryReceiptsShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set InventoryReceiptsShading=0 where InventoryReceiptsShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD InventoryReturnsShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set InventoryReturnsShading=0 where InventoryReturnsShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD InventoryAdjustmentsShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set InventoryAdjustmentsShading=0 where InventoryAdjustmentsShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()

            CmdGeneralForMDB.CommandText = "ALTER TABLE STORE_SETUP ADD PurchasesOrdersShading Number "
            CmdGeneralForMDB.ExecuteNonQuery()
            CmdGeneralForMDB.CommandText = "Update STORE_SETUP Set PurchasesOrdersShading=0 where PurchasesOrdersShading is null"
            CmdGeneralForMDB.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Call FillDataSets()
        TxtSTORENO.MaxLength = LenStoreCod

        If StoreNoVar.Trim.Length > 0 Then
            Call PAddNew()
            TxtSTORENO.Text = StoreNoVar
            TxtSTORENO.Focus()
        Else
            If StoreNoTempVar.Trim.Length = 0 Then
                'Call PFirstRecord(False)
                CmbStores.SelectedValue = PubStoreNO
                Call FillFields(CmbStores.SelectedValue)
            Else
                'Store_Cod1.Text = StoreNoTempVar
                CmbStores.Text = StoreNoTempVar
                Call FillFields(CmbStores.Text)
            End If
            Call AfterSaveOrCancel()
            CmbStores.Focus()
        End If
    End Sub
    Private Sub FillDataSets()
        DsFrmSTORESETUP1.Store_Setup.Clear()
        DASTORE_SETUP.Fill(DsFrmSTORESETUP1, "Store_Setup")
        'DsFrmSTORESETUP1.Store_Setup.AddStore_SetupRow("  ", " ", " ")
        CmbStores.Text = vbNullString

        If DsFrmSTORESETUP1.cust_sales_tax.Rows.Count = 0 Then
            DACust_sales_tax.Fill(DsFrmSTORESETUP1, "cust_sales_tax")
        End If

        If DsFrmSTORESETUP1.employee.Rows.Count = 0 Then
            DAEmployee.Fill(DsFrmSTORESETUP1, "employee")
        End If
        If DsFrmSTORESETUP1.bas_zipcode.Rows.Count = 0 Then
            DAbas_zipcode.Fill(DsFrmSTORESETUP1, "bas_zipcode")
        End If

        If DsFrmSTORESETUP1.GL_account.Rows.Count = 0 Then
            DAGL_account.Fill(DsFrmSTORESETUP1, "GL_account")
        End If
        If DsFrmSTORESETUP1.GL_account1.Rows.Count = 0 Then
            DAGL_account.Fill(DsFrmSTORESETUP1, "GL_account1")
        End If
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        StoreNoTempVar = CmbStores.Text
        CmbStores.SelectedValue = ""
        Call ClearField()

        TxtSTORENO.Text = MakeNewStoreCod()
        TxtSTORENO.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnSortOrder.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PEdit()
        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True)
        StoreNoTempVar = CmbStores.Text
        TxtSTORENO.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnSortOrder.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PDelete()
        If CmbStores.Text = "01" Then
            MsgBox("You can not delete store 01.This is the main store of system.")
            Exit Sub
        End If
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Delete From Store_Setup Where STORENO=" & Qt(CmbStores.Text)
                CmdGeneral.ExecuteNonQuery()
                Call FillDataSets()
                StoreNoTempVar = ""
                Call PNextRecord(False)
                If StoreNoTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If StoreNoTempVar.Trim.Length = 0 Then
                        Call ClearField()
                    End If
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            End Try
            Call AfterSaveOrCancel()
        Else
            CmbStores.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                StoreNoTempVar = PInsert()
                ChangeOK = IIf(StoreNoTempVar.Trim.Length = 0, False, True)
                If StoreNoVar.Trim.Length > 0 Then
                    StoreNoVar = TxtSTORENO.Text
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(StoreNoTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            Call FillDataSets()
            CmbStores.SelectedValue = StoreNoTempVar
            Call SayStoreName()
            CmbStores.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbStores.SelectedValue = StoreNoTempVar
        Call FillFields(CmbStores.Text)
        Call AfterSaveOrCancel()
        CmbStores.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtSTORENO.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False
            MDelete.Enabled = False
            BtnEdit.Enabled = False
            MEdit.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnFirst.Enabled = False
            BtnLast.Enabled = False
            BtnSortOrder.Enabled = False
            MPreviousRecord.Enabled = False
            MNextRecord.Enabled = False
            MFirstRecord.Enabled = False
            MLastRecord.Enabled = False
        Else
            BtnDelete.Enabled = True
            MDelete.Enabled = True
            BtnEdit.Enabled = True
            MEdit.Enabled = True
            BtnPrev.Enabled = True
            BtnNext.Enabled = True
            BtnFirst.Enabled = True
            BtnLast.Enabled = True
            BtnSortOrder.Enabled = True
            MPreviousRecord.Enabled = True
            MNextRecord.Enabled = True
            MFirstRecord.Enabled = True
            MLastRecord.Enabled = True
        End If
        Call EnableField(False)
    End Sub
    Private Sub MAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAddNew.Click
        Call PAddNew()
    End Sub
    Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEdit.Click
        Call PEdit()
    End Sub
    Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDelete.Click
        Call PDelete()
    End Sub
    Private Sub MSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSave.Click
        Call PSave()
    End Sub
    Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
        Call PCancel()
    End Sub
    Private Sub Txtstoreno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtADDRESS.TextChanged, TxtAREACODE.TextChanged, TxtCASH_CUSTOMER.TextChanged, TxtCity.TextChanged, TxtCOUNTY.TextChanged, TxtDISCLAIMER_FOR_ES.TextChanged, TxtDISCLAIMER_FOR_IN.TextChanged, TxtDISCLAIMER_FOR_WO.TextChanged, TxtFEDERAL_TAX_ID.TextChanged, TxtLABEL_INVOICE_COPY1.TextChanged, TxtLABEL_INVOICE_COPY2.TextChanged, TxtLABEL_INVOICE_COPY3.TextChanged, TxtSALES_TAX_ID.TextChanged, TxtShortName.TextChanged, TxtSTATE_TAX_ID.TextChanged, TXTSTORENAME.TextChanged, TxtSTORENO.TextChanged, TxtTECHNISIAN.TextChanged, TxtWARRANTY_FOR_ES.TextChanged, TxtWARRANTY_FOR_IN.TextChanged, TxtWARRANTY_FOR_WO.TextChanged, cmbSALES_TAX.SelectedIndexChanged, cmbSALESPERSON.SelectedIndexChanged, CmbState.SelectedIndexChanged, CmbInterStorePayableAccount.SelectedIndexChanged, CmbInterStoreReceivableAccount.SelectedIndexChanged, CHKFUNCTIONS1.CheckedChanged, CHKFUNCTIONS10.CheckedChanged, CHKFUNCTIONS11.CheckedChanged, CHKFUNCTIONS12.CheckedChanged, CHKFUNCTIONS13.CheckedChanged, CHKFUNCTIONS14.CheckedChanged, CHKFUNCTIONS15.CheckedChanged, CHKFUNCTIONS16.CheckedChanged, CHKFUNCTIONS17.CheckedChanged, CHKFUNCTIONS2.CheckedChanged, CHKFUNCTIONS3.CheckedChanged, CHKFUNCTIONS4.CheckedChanged, CHKFUNCTIONS5.CheckedChanged, CHKFUNCTIONS6.CheckedChanged, CHKFUNCTIONS7.CheckedChanged, CHKFUNCTIONS8.CheckedChanged, CHKFUNCTIONS9.CheckedChanged, ChkPRINT_COMPANYLOGO_Checks.CheckedChanged, ChkPRINT_COMPANYLOGO_ES.CheckedChanged, ChkPRINT_COMPANYLOGO_IN.CheckedChanged, ChkPRINT_COMPANYLOGO_PO.CheckedChanged, ChkPRINT_COMPANYLOGO_ROA.CheckedChanged, ChkPRINT_COMPANYLOGO_WO.CheckedChanged, ChkPRINT_COMPANYSALESMOTTO_Checks.CheckedChanged, ChkPRINT_COMPANYSALESMOTTO_ES.CheckedChanged, ChkPRINT_COMPANYSALESMOTTO_IN.CheckedChanged, ChkPRINT_COMPANYSALESMOTTO_PO.CheckedChanged, ChkPRINT_COMPANYSALESMOTTO_ROA.CheckedChanged, ChkPRINT_COMPANYSALESMOTTO_WO.CheckedChanged, ChkPRINT_STOREADDRESS_Checks.CheckedChanged, ChkPRINT_STOREADDRESS_ES.CheckedChanged, ChkPRINT_STOREADDRESS_IN.CheckedChanged, ChkPRINT_STOREADDRESS_PO.CheckedChanged, ChkPRINT_STOREADDRESS_ROA.CheckedChanged, ChkPRINT_STOREADDRESS_WO.CheckedChanged, ChkPRINT_STORENAME_Checks.CheckedChanged, ChkPRINT_STORENAME_ES.CheckedChanged, ChkPRINT_STORENAME_IN.CheckedChanged, ChkPRINT_STORENAME_PO.CheckedChanged, ChkPRINT_STORENAME_ROA.CheckedChanged, ChkPRINT_STORENAME_WO.CheckedChanged, CHKRULES1.CheckedChanged, CHKRULES10.CheckedChanged, CHKRULES11.CheckedChanged, CHKRULES12.CheckedChanged, CHKRULES2.CheckedChanged, CHKRULES3.CheckedChanged, CHKRULES4.CheckedChanged, CHKRULES5.CheckedChanged, CHKRULES6.CheckedChanged, CHKRULES7.CheckedChanged, CHKRULES8.CheckedChanged, CHKRULES9.CheckedChanged, TxtSqlServerName.TextChanged, TxtSqlUserName.TextChanged, TxtSqlUserPassword.TextChanged, ChkAccountAdjustmentsShadingYes.CheckedChanged, ChkCustomerPaymentsShadingYes.CheckedChanged, ChkCustomerReturnsShadingYes.CheckedChanged, ChkEstimatesShadingYes.CheckedChanged, ChkInventoryAdjustmentsShadingYes.CheckedChanged, ChkInventoryReceiptsShadingYes.CheckedChanged, ChkInventoryReturnsShadingYes.CheckedChanged, ChkInvoicesShadingYes.CheckedChanged, ChkPurchasesOrdersShadingYes.CheckedChanged, ChkWorkOrdersShadingYes.CheckedChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtSTORENO.Text.Trim.Length > 0 And TXTSTORENAME.Text.Trim.Length > 0 And TxtShortName.Text.Trim.Length > 0 Then
                BtnSave.Enabled = True
                MSave.Enabled = True
            Else
                BtnSave.Enabled = False
                MSave.Enabled = False
            End If
        End If
    End Sub
    Private Sub MFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFirstRecord.Click
        Call PFirstRecord()
    End Sub
    Private Sub MPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPreviousRecord.Click
        Call PPreviousRecord()
    End Sub
    Private Sub MNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNextRecord.Click
        Call PNextRecord()
    End Sub
    Private Sub MLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MLastRecord.Click
        Call PLastRecord()
    End Sub
    Private Sub PFirstRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchStoreCodTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup Order BY " & StoreOrderFieldName & " ASC"
            TXTSearchStoreCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchStoreCodTemp) Then
                TXTSearchStoreCodTemp = ""
            End If
            If TXTSearchStoreCodTemp = CmbStores.Text Or TXTSearchStoreCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                CmbStores.SelectedValue = TXTSearchStoreCodTemp
                Call FillFields(CmbStores.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchStoreCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case StoreOrderFieldName.ToUpper.Trim
            Case "StoreNo".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup where StoreNo<" & Qt(TxtSTORENO.Text) & " Order BY " & StoreOrderFieldName & " DESC"
            Case "StoreName".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup where StoreName<" & Qt(TXTSTORENAME.Text) & " Order BY " & StoreOrderFieldName & " DESC"
            Case "ShortName".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup where ShortName<" & Qt(TxtShortName.Text) & " Order BY " & StoreOrderFieldName & " DESC"
        End Select
        TXTSearchStoreCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchStoreCodTemp) Then
            TXTSearchStoreCodTemp = ""
        End If
        If TXTSearchStoreCodTemp = CmbStores.Text Or TXTSearchStoreCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CmbStores.SelectedValue = TXTSearchStoreCodTemp
            StoreNoTempVar = TXTSearchStoreCodTemp
            Call FillFields(CmbStores.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchStoreCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case StoreOrderFieldName.ToUpper.Trim
            Case "StoreNo".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup where StoreNo>" & Qt(TxtSTORENO.Text) & " Order BY " & StoreOrderFieldName & " ASC"
            Case "StoreName".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup where StoreName>" & Qt(TXTSTORENAME.Text) & " Order BY " & StoreOrderFieldName & " ASC"
            Case "ShortName".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup where ShortName>" & Qt(TxtShortName.Text) & " Order BY " & StoreOrderFieldName & " ASC"
        End Select
        TXTSearchStoreCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchStoreCodTemp) Then
            TXTSearchStoreCodTemp = ""
        End If
        If TXTSearchStoreCodTemp = CmbStores.Text Or TXTSearchStoreCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CmbStores.SelectedValue = TXTSearchStoreCodTemp
            StoreNoTempVar = TXTSearchStoreCodTemp
            Call FillFields(CmbStores.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchStoreCodTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 StoreNo from Store_Setup Order BY " & StoreOrderFieldName & " DESC"
            TXTSearchStoreCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchStoreCodTemp) Then
                TXTSearchStoreCodTemp = ""
            End If
            If TXTSearchStoreCodTemp = CmbStores.Text Or TXTSearchStoreCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                CmbStores.SelectedValue = TXTSearchStoreCodTemp
                Call FillFields(CmbStores.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmbStores_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbStores.SelectionChangeCommitted
        Call FillFields(CmbStores.Text)
        'Call AfterSaveOrCancel()
    End Sub
    Private Sub SetNoRecordFind()
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnSortOrder.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Private Sub ShowFilterProcPanel()
        Dim I As Integer, k As Integer
        If PnlSearch.Height = 0 Then
            k = -1
        Else
            k = 1
        End If
        Try
            For I = 1 To PnlSearchHeight
                PnlSearch.Height = PnlSearch.Height - k
                Me.Height = Me.Height - k
            Next I
        Catch
            '                    PanelSearch.Visible = Not PanelSearch.Visible
        End Try
        'Me.Height = Me.Height - (k * PnlSearchHeight)
        If PnlSearch.Height <> 0 Then
            'GRDFWG.Height = PanelKartabl.Height - SBKartabl.Height
            CmbStores.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmStoreSetup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'CmbStores.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If Vendor_Cod1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@StoreNo").Value = Vendor_Cod1.text
        '    DAInspectionMaster.Fill(DsFrmInspectionMaster1, "InspectionMaster")
        '    Prn = New FrmRepView
        '    Prn.MdiParent = PubMFrmMain
        '    Orpt.SetParameterValue("CompanyName", PubCompanyName)
        '    Orpt.SetDataSource(DsFrmInspectionMaster1)
        '    Prn.CrViewer.ReportSource = Orpt
        '    Prn.Show()
        'End If
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean)
        If Status = MainModule.WorkStates.AddNew Then
            TxtSTORENO.Enabled = instatus
        Else
            TxtSTORENO.Enabled = False
        End If
        TxtADDRESS.Enabled = instatus
        TxtAREACODE.Enabled = instatus
        TxtCASH_CUSTOMER.Enabled = instatus
        TxtCity.Enabled = instatus
        TxtCOUNTY.Enabled = instatus
        TxtDISCLAIMER_FOR_ES.Enabled = instatus
        TxtDISCLAIMER_FOR_IN.Enabled = instatus
        TxtDISCLAIMER_FOR_WO.Enabled = instatus
        TxtFEDERAL_TAX_ID.Enabled = instatus
        TxtLABEL_INVOICE_COPY1.Enabled = instatus
        TxtLABEL_INVOICE_COPY2.Enabled = instatus
        TxtLABEL_INVOICE_COPY3.Enabled = instatus
        TxtSALES_TAX_ID.Enabled = instatus
        TxtShortName.Enabled = instatus
        CmbState.Enabled = instatus
        TxtSTATE_TAX_ID.Enabled = instatus
        TXTSTORENAME.Enabled = instatus
        TxtTECHNISIAN.Enabled = instatus
        TxtWARRANTY_FOR_ES.Enabled = instatus
        TxtWARRANTY_FOR_IN.Enabled = instatus
        TxtWARRANTY_FOR_WO.Enabled = instatus
        TxtSqlServerName.Enabled = instatus
        TxtSqlUserName.Enabled = instatus
        TxtSqlUserPassword.Enabled = instatus

        cmbSALESPERSON.Enabled = instatus
        cmbSALES_TAX.Enabled = instatus

        NumNO_OF_COPY_INPRINT_ES.Enabled = instatus
        NumNO_OF_COPY_INPRINT_IN.Enabled = instatus
        NumNO_OF_COPY_INPRINT_PO.Enabled = instatus
        NumNO_OF_COPY_INPRINT_ROA.Enabled = instatus
        NumNO_OF_COPY_INPRINT_WO.Enabled = instatus

        ChkPRINT_STORENAME_IN.Enabled = instatus
        ChkPRINT_COMPANYLOGO_Checks.Enabled = instatus
        ChkPRINT_COMPANYLOGO_ES.Enabled = instatus
        ChkPRINT_COMPANYLOGO_IN.Enabled = instatus
        ChkPRINT_COMPANYLOGO_PO.Enabled = instatus
        ChkPRINT_COMPANYLOGO_ROA.Enabled = instatus
        ChkPRINT_COMPANYLOGO_WO.Enabled = instatus
        ChkPRINT_COMPANYSALESMOTTO_Checks.Enabled = instatus
        ChkPRINT_COMPANYSALESMOTTO_ES.Enabled = instatus
        ChkPRINT_COMPANYSALESMOTTO_IN.Enabled = instatus
        ChkPRINT_COMPANYSALESMOTTO_PO.Enabled = instatus
        ChkPRINT_COMPANYSALESMOTTO_ROA.Enabled = instatus
        ChkPRINT_COMPANYSALESMOTTO_WO.Enabled = instatus
        ChkPRINT_STOREADDRESS_Checks.Enabled = instatus
        ChkPRINT_STOREADDRESS_ES.Enabled = instatus
        ChkPRINT_STOREADDRESS_IN.Enabled = instatus
        ChkPRINT_STOREADDRESS_PO.Enabled = instatus
        ChkPRINT_STOREADDRESS_ROA.Enabled = instatus
        ChkPRINT_STOREADDRESS_WO.Enabled = instatus
        ChkPRINT_STORENAME_Checks.Enabled = instatus
        ChkPRINT_STORENAME_ES.Enabled = instatus
        ChkPRINT_STORENAME_IN.Enabled = instatus
        ChkPRINT_STORENAME_PO.Enabled = instatus
        ChkPRINT_STORENAME_ROA.Enabled = instatus
        ChkPRINT_STORENAME_WO.Enabled = instatus

        CHKRULES1.Enabled = instatus
        CHKRULES2.Enabled = instatus
        CHKRULES3.Enabled = instatus
        CHKRULES4.Enabled = instatus
        CHKRULES5.Enabled = instatus
        CHKRULES6.Enabled = instatus
        CHKRULES7.Enabled = instatus
        CHKRULES8.Enabled = instatus
        CHKRULES9.Enabled = instatus
        CHKRULES10.Enabled = instatus
        CHKRULES11.Enabled = instatus
        CHKRULES12.Enabled = instatus
        CHKFUNCTIONS1.Enabled = instatus
        CHKFUNCTIONS2.Enabled = instatus
        CHKFUNCTIONS3.Enabled = instatus
        CHKFUNCTIONS4.Enabled = instatus
        CHKFUNCTIONS5.Enabled = instatus
        CHKFUNCTIONS6.Enabled = instatus
        CHKFUNCTIONS7.Enabled = instatus
        CHKFUNCTIONS8.Enabled = instatus
        CHKFUNCTIONS9.Enabled = instatus
        CHKFUNCTIONS10.Enabled = instatus
        CHKFUNCTIONS11.Enabled = instatus
        CHKFUNCTIONS12.Enabled = instatus
        CHKFUNCTIONS13.Enabled = instatus
        CHKFUNCTIONS14.Enabled = instatus
        CHKFUNCTIONS15.Enabled = instatus
        CHKFUNCTIONS16.Enabled = instatus
        CHKFUNCTIONS17.Enabled = instatus

        GroupBox1.Enabled = instatus
        GroupBox2.Enabled = instatus
        GroupBox3.Enabled = instatus
        GroupBox4.Enabled = instatus
        GroupBox5.Enabled = instatus
        GroupBox6.Enabled = instatus
        GroupBox7.Enabled = instatus
        GroupBox8.Enabled = instatus
        GroupBox9.Enabled = instatus
        GroupBox10.Enabled = instatus

        ZipCode1.Enabled = instatus

        PhoneNo1.Enabled = instatus
        PhoneNo2.Enabled = instatus

        EmailAddress1.Enabled = instatus

        CmbInterStorePayableAccount.Enabled = instatus
        CmbInterStoreReceivableAccount.Enabled = instatus

    End Sub
    Friend Sub ClearField()

        TxtSTORENO.Text = ""
        TxtADDRESS.Text = ""
        TxtAREACODE.Text = ""
        TxtCASH_CUSTOMER.Text = ""
        TxtCity.Text = ""
        TxtCOUNTY.Text = ""
        TxtDISCLAIMER_FOR_ES.Text = ""
        TxtDISCLAIMER_FOR_IN.Text = ""
        TxtDISCLAIMER_FOR_WO.Text = ""
        TxtFEDERAL_TAX_ID.Text = ""
        TxtLABEL_INVOICE_COPY1.Text = ""
        TxtLABEL_INVOICE_COPY2.Text = ""
        TxtLABEL_INVOICE_COPY3.Text = ""
        TxtSALES_TAX_ID.Text = ""
        TxtShortName.Text = ""
        CmbState.Text = ""
        TxtSTATE_TAX_ID.Text = ""
        TXTSTORENAME.Text = ""
        TxtTECHNISIAN.Text = ""
        TxtWARRANTY_FOR_ES.Text = ""
        TxtWARRANTY_FOR_IN.Text = ""
        TxtWARRANTY_FOR_WO.Text = ""
        TxtSqlServerName.Text = ""
        TxtSqlUserName.Text = ""
        TxtSqlUserPassword.Text = ""

        NumNO_OF_COPY_INPRINT_ES.Text = 0
        NumNO_OF_COPY_INPRINT_IN.Text = 0
        NumNO_OF_COPY_INPRINT_PO.Text = 0
        NumNO_OF_COPY_INPRINT_ROA.Text = 0
        NumNO_OF_COPY_INPRINT_WO.Text = 0

        cmbSALESPERSON.Text = ""
        cmbSALES_TAX.Text = ""

        ChkPRINT_COMPANYLOGO_Checks.Checked = False
        ChkPRINT_COMPANYLOGO_ES.Checked = False
        ChkPRINT_COMPANYLOGO_IN.Checked = False
        ChkPRINT_COMPANYLOGO_PO.Checked = False
        ChkPRINT_COMPANYLOGO_ROA.Checked = False
        ChkPRINT_COMPANYLOGO_WO.Checked = False
        ChkPRINT_COMPANYSALESMOTTO_Checks.Checked = False
        ChkPRINT_COMPANYSALESMOTTO_ES.Checked = False
        ChkPRINT_COMPANYSALESMOTTO_IN.Checked = False
        ChkPRINT_COMPANYSALESMOTTO_PO.Checked = False
        ChkPRINT_COMPANYSALESMOTTO_ROA.Checked = False
        ChkPRINT_COMPANYSALESMOTTO_WO.Checked = False
        ChkPRINT_STOREADDRESS_Checks.Checked = False
        ChkPRINT_STOREADDRESS_ES.Checked = False
        ChkPRINT_STOREADDRESS_IN.Checked = False
        ChkPRINT_STOREADDRESS_PO.Checked = False
        ChkPRINT_STOREADDRESS_ROA.Checked = False
        ChkPRINT_STOREADDRESS_WO.Checked = False
        ChkPRINT_STORENAME_Checks.Checked = False
        ChkPRINT_STORENAME_ES.Checked = False
        ChkPRINT_STORENAME_IN.Checked = False
        ChkPRINT_STORENAME_PO.Checked = False
        ChkPRINT_STORENAME_ROA.Checked = False
        ChkPRINT_STORENAME_WO.Checked = False

        CHKRULES1.Checked = False
        CHKRULES2.Checked = False
        CHKRULES3.Checked = False
        CHKRULES4.Checked = False
        CHKRULES5.Checked = False
        CHKRULES6.Checked = False
        CHKRULES7.Checked = False
        CHKRULES8.Checked = False
        CHKRULES9.Checked = False
        CHKRULES10.Checked = False
        CHKRULES11.Checked = False
        CHKRULES12.Checked = False
        CHKFUNCTIONS1.Checked = False
        CHKFUNCTIONS2.Checked = False
        CHKFUNCTIONS3.Checked = False
        CHKFUNCTIONS4.Checked = False
        CHKFUNCTIONS5.Checked = False
        CHKFUNCTIONS6.Checked = False
        CHKFUNCTIONS7.Checked = False
        CHKFUNCTIONS8.Checked = False
        CHKFUNCTIONS9.Checked = False
        CHKFUNCTIONS10.Checked = False
        CHKFUNCTIONS11.Checked = False
        CHKFUNCTIONS12.Checked = False
        CHKFUNCTIONS13.Checked = False
        CHKFUNCTIONS14.Checked = False
        CHKFUNCTIONS15.Checked = False
        CHKFUNCTIONS16.Checked = False
        CHKFUNCTIONS17.Checked = False

        ChkAccountAdjustmentsShadingYes.Checked = True
        ChkCustomerPaymentsShadingYes.Checked = True
        ChkCustomerReturnsShadingYes.Checked = True
        ChkEstimatesShadingYes.Checked = True
        ChkInventoryAdjustmentsShadingYes.Checked = True
        ChkInventoryReceiptsShadingYes.Checked = True
        ChkInventoryReturnsShadingYes.Checked = True
        ChkInvoicesShadingYes.Checked = True
        ChkPurchasesOrdersShadingYes.Checked = True
        ChkWorkOrdersShadingYes.Checked = True

        ZipCode1.Text = ""

        PhoneNo1.Text = ""
        PhoneNo2.Text = ""

        EmailAddress1.Text = ""

        CmbInterStorePayableAccount.SelectedValue = 0
        CmbInterStoreReceivableAccount.SelectedValue = 0

    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Insert Into Store_Setup (STORENO, ADDRESS, AREACODE, CASH_CUSTOMER,City,COUNTY,DISCLAIMER_FOR_ES,DISCLAIMER_FOR_IN,DISCLAIMER_FOR_WO,FEDERAL_TAX_ID,LABEL_INVOICE_COPY1,LABEL_INVOICE_COPY2,LABEL_INVOICE_COPY3,SALES_TAX_ID,SALESPERSON,ShortName,State,STATE_TAX_ID,STORENAME,TECHNISIAN,WARRANTY_FOR_ES,WARRANTY_FOR_IN,WARRANTY_FOR_WO,NO_OF_COPY_INPRINT_ES,NO_OF_COPY_INPRINT_IN,NO_OF_COPY_INPRINT_PO,NO_OF_COPY_INPRINT_ROA,NO_OF_COPY_INPRINT_WO,SALES_TAX,PRINT_COMPANYLOGO_Checks,PRINT_COMPANYLOGO_ES,PRINT_COMPANYLOGO_IN,PRINT_COMPANYLOGO_PO,PRINT_COMPANYLOGO_ROA,PRINT_COMPANYLOGO_WO,PRINT_COMPANYSALESMOTTO_Checks,PRINT_COMPANYSALESMOTTO_ES,PRINT_COMPANYSALESMOTTO_IN,PRINT_COMPANYSALESMOTTO_PO,PRINT_COMPANYSALESMOTTO_ROA,PRINT_COMPANYSALESMOTTO_WO,PRINT_STOREADDRESS_Checks,PRINT_STOREADDRESS_ES,PRINT_STOREADDRESS_IN,PRINT_STOREADDRESS_PO,PRINT_STOREADDRESS_ROA,PRINT_STOREADDRESS_WO,PRINT_STORENAME_Checks,PRINT_STORENAME_ES,PRINT_STORENAME_IN,PRINT_STORENAME_PO,PRINT_STORENAME_ROA,PRINT_STORENAME_WO ,RULES1,RULES2,RULES3,RULES4,RULES5,RULES6,RULES7,RULES8,RULES9,RULES10,RULES11,RULES12,FUNCTIONS1,FUNCTIONS2,FUNCTIONS3,FUNCTIONS4,FUNCTIONS5,FUNCTIONS6,FUNCTIONS7,FUNCTIONS8,FUNCTIONS9,FUNCTIONS10,FUNCTIONS11,FUNCTIONS12,FUNCTIONS13,FUNCTIONS14,FUNCTIONS15,FUNCTIONS16,FUNCTIONS17,ZipCode,Phone,Fax,Email,InterStorePayableAccount,InterStoreReceivableAccount,SqlServerName,SqlUserName,SqlUserPassword) Values " _
                                   & "(" & Qt(TxtSTORENO.Text) & "," & Qt(TxtADDRESS.Text) & "," & Qt(TxtAREACODE.Text) & "," & Qt(TxtCASH_CUSTOMER.Text) & "," & Qt(TxtCity.Text) & "," & Qt(TxtCOUNTY.Text) & "," & Qt(TxtDISCLAIMER_FOR_ES.Text) & "," & Qt(TxtDISCLAIMER_FOR_IN.Text) & "," & Qt(TxtDISCLAIMER_FOR_WO.Text) & "," & Qt(TxtFEDERAL_TAX_ID.Text) & "," & Qt(TxtLABEL_INVOICE_COPY1.Text) & "," & Qt(TxtLABEL_INVOICE_COPY2.Text) & "," & Qt(TxtLABEL_INVOICE_COPY3.Text) & "," & Qt(TxtSALES_TAX_ID.Text) & "," & Qt(cmbSALESPERSON.SelectedValue) & "," & Qt(TxtShortName.Text) & "," & Qt(CmbState.SelectedValue) & "," & Qt(TxtSTATE_TAX_ID.Text) & "," & Qt(TXTSTORENAME.Text) & "," & Qt(TxtTECHNISIAN.Text) & "," & Qt(TxtWARRANTY_FOR_ES.Text) & "," & Qt(TxtWARRANTY_FOR_IN.Text) & "," & Qt(TxtWARRANTY_FOR_WO.Text) & "," & NumNO_OF_COPY_INPRINT_ES.Text & "," & NumNO_OF_COPY_INPRINT_IN.Text & "," & NumNO_OF_COPY_INPRINT_PO.Text & "," & NumNO_OF_COPY_INPRINT_ROA.Text & "," & NumNO_OF_COPY_INPRINT_WO.Text & "," & Qt(cmbSALES_TAX.SelectedValue) & "," & DecodeCheckBox(ChkPRINT_COMPANYLOGO_Checks.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYLOGO_ES.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYLOGO_IN.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYLOGO_PO.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYLOGO_ROA.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYLOGO_WO.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYSALESMOTTO_Checks.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYSALESMOTTO_ES.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYSALESMOTTO_IN.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYSALESMOTTO_PO.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYSALESMOTTO_ROA.Checked) & "," & DecodeCheckBox(ChkPRINT_COMPANYSALESMOTTO_WO.Checked) & "," & DecodeCheckBox(ChkPRINT_STOREADDRESS_Checks.Checked) & "," & DecodeCheckBox(ChkPRINT_STOREADDRESS_ES.Checked) & "," & DecodeCheckBox(ChkPRINT_STOREADDRESS_IN.Checked) & "," & DecodeCheckBox(ChkPRINT_STOREADDRESS_PO.Checked) & "," & DecodeCheckBox(ChkPRINT_STOREADDRESS_ROA.Checked) & "," & DecodeCheckBox(ChkPRINT_STOREADDRESS_WO.Checked) & "," & DecodeCheckBox(ChkPRINT_STORENAME_Checks.Checked) & "," & DecodeCheckBox(ChkPRINT_STORENAME_ES.Checked) & "," & DecodeCheckBox(ChkPRINT_STORENAME_IN.Checked) & "," & DecodeCheckBox(ChkPRINT_STORENAME_PO.Checked) & "," & DecodeCheckBox(ChkPRINT_STORENAME_ROA.Checked) & "," & DecodeCheckBox(ChkPRINT_STORENAME_WO.Checked) & "," & DecodeCheckBox(CHKRULES1.Checked) & "," & DecodeCheckBox(CHKRULES2.Checked) & "," & DecodeCheckBox(CHKRULES3.Checked) & "," & DecodeCheckBox(CHKRULES4.Checked) & "," & DecodeCheckBox(CHKRULES5.Checked) & "," & DecodeCheckBox(CHKRULES6.Checked) & "," & DecodeCheckBox(CHKRULES7.Checked) & "," & DecodeCheckBox(CHKRULES8.Checked) & "," & DecodeCheckBox(CHKRULES9.Checked) & "," & DecodeCheckBox(CHKRULES10.Checked) & "," & DecodeCheckBox(CHKRULES11.Checked) & "," & DecodeCheckBox(CHKRULES12.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS1.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS2.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS3.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS4.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS5.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS6.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS7.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS8.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS9.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS10.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS11.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS12.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS13.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS14.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS15.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS16.Checked) & "," & DecodeCheckBox(CHKFUNCTIONS17.Checked) & "," & Qt(ZipCode1.Text) & "," & Qt(PhoneNo1.Text) & "," & Qt(PhoneNo2.Text) & "," & Qt(EmailAddress1.Text) & "," & Qt(CmbInterStorePayableAccount.SelectedValue) & "," & Qt(CmbInterStoreReceivableAccount.SelectedValue) & "," & Qt(TxtSqlServerName.Text) & "," & Qt(TxtSqlUserName.Text) & "," & Qt(EncryptPassword(TxtSqlUserPassword.Text)) & ")"
            CmdGeneral.ExecuteNonQuery()
            Call OtherUpdates()
            PInsert = TxtSTORENO.Text
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisStoreNo As String) As Boolean
        PUpdate = True
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Update Store_Setup Set STORENO=" & Qt(TxtSTORENO.Text) & ", ADDRESS=" & Qt(TxtADDRESS.Text) & ", AREACODE=" & Qt(TxtAREACODE.Text) & ", CASH_CUSTOMER=" & Qt(TxtCASH_CUSTOMER.Text) & ",City=" & Qt(TxtCity.Text) & ",COUNTY=" & Qt(TxtCOUNTY.Text) & ",DISCLAIMER_FOR_ES=" & Qt(TxtDISCLAIMER_FOR_ES.Text) & ",DISCLAIMER_FOR_IN=" & Qt(TxtDISCLAIMER_FOR_IN.Text) & ",DISCLAIMER_FOR_WO=" & Qt(TxtDISCLAIMER_FOR_WO.Text) & ",FEDERAL_TAX_ID=" & Qt(TxtFEDERAL_TAX_ID.Text) & ",LABEL_INVOICE_COPY1=" & Qt(TxtLABEL_INVOICE_COPY1.Text) & ",LABEL_INVOICE_COPY2=" & Qt(TxtLABEL_INVOICE_COPY2.Text) & ",LABEL_INVOICE_COPY3=" & Qt(TxtLABEL_INVOICE_COPY3.Text) & ",SALES_TAX_ID=" & Qt(TxtSALES_TAX_ID.Text) & ",SALESPERSON=" & Qt(cmbSALESPERSON.SelectedValue) & ",ShortName=" & Qt(TxtShortName.Text) & ",State=" & Qt(CmbState.SelectedValue) & ",STATE_TAX_ID=" & Qt(TxtSTATE_TAX_ID.Text) & ",STORENAME=" & Qt(TXTSTORENAME.Text) & ",TECHNISIAN=" & Qt(TxtTECHNISIAN.Text) & ",WARRANTY_FOR_ES=" & Qt(TxtWARRANTY_FOR_ES.Text) & ",WARRANTY_FOR_IN=" & Qt(TxtWARRANTY_FOR_IN.Text) & ",WARRANTY_FOR_WO=" & Qt(TxtWARRANTY_FOR_WO.Text) & ",NO_OF_COPY_INPRINT_ES=" & NumNO_OF_COPY_INPRINT_ES.Text & ",NO_OF_COPY_INPRINT_IN=" & NumNO_OF_COPY_INPRINT_IN.Text & ",NO_OF_COPY_INPRINT_PO=" & NumNO_OF_COPY_INPRINT_PO.Text & ",NO_OF_COPY_INPRINT_ROA=" & NumNO_OF_COPY_INPRINT_ROA.Text & ",NO_OF_COPY_INPRINT_WO=" & NumNO_OF_COPY_INPRINT_WO.Text & ",SALES_TAX=" & Qt(cmbSALES_TAX.SelectedValue) & ",PRINT_COMPANYLOGO_Checks=" & ChkPRINT_COMPANYLOGO_Checks.Checked & ",PRINT_COMPANYLOGO_ES=" & ChkPRINT_COMPANYLOGO_ES.Checked & ",PRINT_COMPANYLOGO_IN=" & ChkPRINT_COMPANYLOGO_IN.Checked & ",PRINT_COMPANYLOGO_PO=" & ChkPRINT_COMPANYLOGO_PO.Checked & ",PRINT_COMPANYLOGO_ROA=" & ChkPRINT_COMPANYLOGO_ROA.Checked & ",PRINT_COMPANYLOGO_WO=" & ChkPRINT_COMPANYLOGO_WO.Checked & ",PRINT_COMPANYSALESMOTTO_Checks=" & ChkPRINT_COMPANYSALESMOTTO_Checks.Checked & ",PRINT_COMPANYSALESMOTTO_ES=" & ChkPRINT_COMPANYSALESMOTTO_ES.Checked & ",PRINT_COMPANYSALESMOTTO_IN=" & ChkPRINT_COMPANYSALESMOTTO_IN.Checked & ",PRINT_COMPANYSALESMOTTO_PO=" & ChkPRINT_COMPANYSALESMOTTO_PO.Checked & ",PRINT_COMPANYSALESMOTTO_ROA=" & ChkPRINT_COMPANYSALESMOTTO_ROA.Checked & ",PRINT_COMPANYSALESMOTTO_WO=" & ChkPRINT_COMPANYSALESMOTTO_WO.Checked & ",PRINT_STOREADDRESS_Checks=" & ChkPRINT_STOREADDRESS_Checks.Checked & ",PRINT_STOREADDRESS_ES=" & ChkPRINT_STOREADDRESS_ES.Checked & ",PRINT_STOREADDRESS_IN=" & ChkPRINT_STOREADDRESS_IN.Checked & ",PRINT_STOREADDRESS_PO=" & ChkPRINT_STOREADDRESS_PO.Checked & ",PRINT_STOREADDRESS_ROA=" & ChkPRINT_STOREADDRESS_ROA.Checked & ",PRINT_STOREADDRESS_WO=" & ChkPRINT_STOREADDRESS_WO.Checked & ",PRINT_STORENAME_Checks=" & ChkPRINT_STORENAME_Checks.Checked & ",PRINT_STORENAME_ES=" & ChkPRINT_STORENAME_ES.Checked & ",PRINT_STORENAME_IN=" & ChkPRINT_STORENAME_IN.Checked & ",PRINT_STORENAME_PO=" & ChkPRINT_STORENAME_PO.Checked & ",PRINT_STORENAME_ROA=" & ChkPRINT_STORENAME_ROA.Checked & ",PRINT_STORENAME_WO =" & ChkPRINT_STORENAME_WO.Checked & ",RULES1=" & DecodeCheckBox(CHKRULES1.Checked) & ",RULES2=" & DecodeCheckBox(CHKRULES2.Checked) & ",RULES3=" & DecodeCheckBox(CHKRULES3.Checked) & ",RULES4=" & DecodeCheckBox(CHKRULES4.Checked) & ",RULES5=" & DecodeCheckBox(CHKRULES5.Checked) & ",RULES6=" & DecodeCheckBox(CHKRULES6.Checked) & ",RULES7=" & DecodeCheckBox(CHKRULES7.Checked) & ",RULES8=" & DecodeCheckBox(CHKRULES8.Checked) & ",RULES9=" & DecodeCheckBox(CHKRULES9.Checked) & ",RULES10=" & DecodeCheckBox(CHKRULES10.Checked) & ",RULES11=" & DecodeCheckBox(CHKRULES11.Checked) & ",RULES12=" & DecodeCheckBox(CHKRULES12.Checked) & ",FUNCTIONS1=" & DecodeCheckBox(CHKFUNCTIONS1.Checked) & ",FUNCTIONS2=" & DecodeCheckBox(CHKFUNCTIONS2.Checked) & ",FUNCTIONS3=" & DecodeCheckBox(CHKFUNCTIONS3.Checked) & ",FUNCTIONS4=" & DecodeCheckBox(CHKFUNCTIONS4.Checked) & ",FUNCTIONS5=" & DecodeCheckBox(CHKFUNCTIONS5.Checked) & ",FUNCTIONS6=" & DecodeCheckBox(CHKFUNCTIONS6.Checked) & ",FUNCTIONS7=" & DecodeCheckBox(CHKFUNCTIONS7.Checked) & ",FUNCTIONS8=" & DecodeCheckBox(CHKFUNCTIONS8.Checked) & ",FUNCTIONS9=" & DecodeCheckBox(CHKFUNCTIONS9.Checked) & ",FUNCTIONS10=" & DecodeCheckBox(CHKFUNCTIONS10.Checked) & ",FUNCTIONS11=" & DecodeCheckBox(CHKFUNCTIONS11.Checked) & ",FUNCTIONS12=" & DecodeCheckBox(CHKFUNCTIONS12.Checked) & ",FUNCTIONS13=" & DecodeCheckBox(CHKFUNCTIONS13.Checked) & ",FUNCTIONS14=" & DecodeCheckBox(CHKFUNCTIONS14.Checked) & ",FUNCTIONS15=" & DecodeCheckBox(CHKFUNCTIONS15.Checked) & ",FUNCTIONS16=" & DecodeCheckBox(CHKFUNCTIONS16.Checked) & ",FUNCTIONS17=" & DecodeCheckBox(CHKFUNCTIONS17.Checked) & ",ZipCode=" & Qt(ZipCode1.Text) & ",Phone=" & Qt(PhoneNo1.Text) & ",Fax=" & Qt(PhoneNo2.Text) & ",Email=" & Qt(EmailAddress1.Text) & ",InterStorePayableAccount=" & Qt(CmbInterStorePayableAccount.SelectedValue) & ",InterStoreReceivableAccount=" & Qt(CmbInterStoreReceivableAccount.SelectedValue) & ",SqlServerName=" & Qt(TxtSqlServerName.Text) & ",SqlUserName=" & Qt(TxtSqlUserName.Text) & ",SqlUserPassword=" & Qt(EncryptPassword(TxtSqlUserPassword.Text)) & " Where StoreNo=" & Qt(CmbStores.Text)
            CmdGeneral.ExecuteNonQuery()
            Call OtherUpdates()
        Catch ex As System.Data.SqlClient.SqlException
            'Dim myErrors As System.Data.OleDb.OleDbErrorCollection = ex.Errors
            Call PubErrHandle("Error In save")
            PUpdate = False
        End Try
    End Function
    Private Sub OtherUpdates()
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If

            CmdGeneral.CommandText = "Update Store_Setup Set AccountAdjustmentsShading=" & IIf(ChkAccountAdjustmentsShadingYes.Checked, 1, 0) & ", CustomerPaymentsShading=" & IIf(ChkCustomerPaymentsShadingYes.Checked, 1, 0) & ", CustomerReturnsShading=" & IIf(ChkCustomerReturnsShadingYes.Checked, 1, 0) & ", EstimatesShading=" & IIf(ChkEstimatesShadingYes.Checked, 1, 0) & ",InventoryAdjustmentsShading=" & IIf(ChkInventoryAdjustmentsShadingYes.Checked, 1, 0) & ",InventoryReceiptsShading=" & IIf(ChkInventoryReceiptsShadingYes.Checked, 1, 0) & ",InventoryReturnsShading=" & IIf(ChkInventoryReturnsShadingYes.Checked, 1, 0) & ",InvoicesShading=" & IIf(ChkInvoicesShadingYes.Checked, 1, 0) & ",PurchasesOrdersShading=" & IIf(ChkPurchasesOrdersShadingYes.Checked, 1, 0) & ",WorkOrdersShading=" & IIf(ChkWorkOrdersShadingYes.Checked, 1, 0) & " Where StoreNo=" & Qt(CmbStores.Text)
            CmdGeneral.ExecuteNonQuery()
        Catch ex As System.Data.OleDb.OleDbException

        End Try
    End Sub
    Friend Function FillFields(ByVal ThisStoreNo As String) As Boolean
        FillFields = False
        If ThisStoreNo.Trim.Length = 0 Then
            Call ClearField()
            Exit Function
        End If

        Call SayStoreName()

        Dim SQLReader As System.Data.OleDb.OleDbDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from Store_Setup where StoreNo=" & Qt(ThisStoreNo)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                TxtSTORENO.Text = Trim(SQLReader.Item("STORENO") & "")
                TxtADDRESS.Text = Trim(SQLReader.Item("ADDRESS") & "")
                TxtAREACODE.Text = Trim(SQLReader.Item("AREACODE") & "")
                TxtCASH_CUSTOMER.Text = Trim(SQLReader.Item("CASH_CUSTOMER") & "")
                TxtCity.Text = Trim(SQLReader.Item("City") & "")
                TxtCOUNTY.Text = Trim(SQLReader.Item("COUNTY") & "")
                TxtDISCLAIMER_FOR_ES.Text = Trim(SQLReader.Item("DISCLAIMER_FOR_ES") & "")
                TxtDISCLAIMER_FOR_IN.Text = Trim(SQLReader.Item("DISCLAIMER_FOR_IN") & "")
                TxtDISCLAIMER_FOR_WO.Text = Trim(SQLReader.Item("DISCLAIMER_FOR_WO") & "")
                TxtFEDERAL_TAX_ID.Text = Trim(SQLReader.Item("FEDERAL_TAX_ID") & "")
                TxtLABEL_INVOICE_COPY1.Text = Trim(SQLReader.Item("LABEL_INVOICE_COPY1") & "")
                TxtLABEL_INVOICE_COPY2.Text = Trim(SQLReader.Item("LABEL_INVOICE_COPY2") & "")
                TxtLABEL_INVOICE_COPY3.Text = Trim(SQLReader.Item("LABEL_INVOICE_COPY3") & "")
                TxtSALES_TAX_ID.Text = Trim(SQLReader.Item("SALES_TAX_ID") & "")
                TxtShortName.Text = Trim(SQLReader.Item("ShortName") & "")
                CmbState.SelectedValue = Trim(SQLReader.Item("State") & "")
                TxtSTATE_TAX_ID.Text = Trim(SQLReader.Item("STATE_TAX_ID") & "")
                TXTSTORENAME.Text = Trim(SQLReader.Item("STORENAME") & "")
                TxtTECHNISIAN.Text = Trim(SQLReader.Item("TECHNISIAN") & "")
                TxtWARRANTY_FOR_ES.Text = Trim(SQLReader.Item("WARRANTY_FOR_ES") & "")
                TxtWARRANTY_FOR_IN.Text = Trim(SQLReader.Item("WARRANTY_FOR_IN") & "")
                TxtWARRANTY_FOR_WO.Text = Trim(SQLReader.Item("WARRANTY_FOR_WO") & "")
                TxtSqlServerName.Text = Trim(SQLReader.Item("SqlServerName") & "")
                TxtSqlUserName.Text = Trim(SQLReader.Item("SqlUserName") & "")
                TxtSqlUserPassword.Text = PassDecode(Trim(SQLReader.Item("SqlUserPassword") & ""))

                NumNO_OF_COPY_INPRINT_ES.Text = SQLReader.Item("NO_OF_COPY_INPRINT_ES")
                NumNO_OF_COPY_INPRINT_IN.Text = SQLReader.Item("NO_OF_COPY_INPRINT_IN")
                NumNO_OF_COPY_INPRINT_PO.Text = SQLReader.Item("NO_OF_COPY_INPRINT_PO")
                NumNO_OF_COPY_INPRINT_ROA.Text = SQLReader.Item("NO_OF_COPY_INPRINT_ROA")
                NumNO_OF_COPY_INPRINT_WO.Text = SQLReader.Item("NO_OF_COPY_INPRINT_WO")

                cmbSALESPERSON.SelectedValue = Trim(SQLReader.Item("SALESPERSON") & "")
                cmbSALES_TAX.SelectedValue = SQLReader.Item("SALES_TAX") & ""

                ChkPRINT_COMPANYLOGO_Checks.Checked = SQLReader.Item("PRINT_COMPANYLOGO_Checks")
                ChkPRINT_COMPANYLOGO_ES.Checked = SQLReader.Item("PRINT_COMPANYLOGO_ES")
                ChkPRINT_COMPANYLOGO_IN.Checked = SQLReader.Item("PRINT_COMPANYLOGO_IN")
                ChkPRINT_COMPANYLOGO_PO.Checked = SQLReader.Item("PRINT_COMPANYLOGO_PO")
                ChkPRINT_COMPANYLOGO_ROA.Checked = SQLReader.Item("PRINT_COMPANYLOGO_ROA")
                ChkPRINT_COMPANYLOGO_WO.Checked = SQLReader.Item("PRINT_COMPANYLOGO_WO")
                ChkPRINT_COMPANYSALESMOTTO_Checks.Checked = SQLReader.Item("PRINT_COMPANYSALESMOTTO_Checks")
                ChkPRINT_COMPANYSALESMOTTO_ES.Checked = SQLReader.Item("PRINT_COMPANYSALESMOTTO_ES")
                ChkPRINT_COMPANYSALESMOTTO_IN.Checked = SQLReader.Item("PRINT_COMPANYSALESMOTTO_IN")
                ChkPRINT_COMPANYSALESMOTTO_PO.Checked = SQLReader.Item("PRINT_COMPANYSALESMOTTO_PO")
                ChkPRINT_COMPANYSALESMOTTO_ROA.Checked = SQLReader.Item("PRINT_COMPANYSALESMOTTO_ROA")
                ChkPRINT_COMPANYSALESMOTTO_WO.Checked = SQLReader.Item("PRINT_COMPANYSALESMOTTO_WO")
                ChkPRINT_STOREADDRESS_Checks.Checked = SQLReader.Item("PRINT_STOREADDRESS_Checks")
                ChkPRINT_STOREADDRESS_ES.Checked = SQLReader.Item("PRINT_STOREADDRESS_ES")
                ChkPRINT_STOREADDRESS_IN.Checked = SQLReader.Item("PRINT_STOREADDRESS_IN")
                ChkPRINT_STOREADDRESS_PO.Checked = SQLReader.Item("PRINT_STOREADDRESS_PO")
                ChkPRINT_STOREADDRESS_ROA.Checked = SQLReader.Item("PRINT_STOREADDRESS_ROA")
                ChkPRINT_STOREADDRESS_WO.Checked = SQLReader.Item("PRINT_STOREADDRESS_ROA")
                ChkPRINT_STORENAME_Checks.Checked = SQLReader.Item("PRINT_STORENAME_Checks")
                ChkPRINT_STORENAME_ES.Checked = SQLReader.Item("PRINT_STORENAME_ES")
                ChkPRINT_STORENAME_IN.Checked = SQLReader.Item("PRINT_STORENAME_IN")
                ChkPRINT_STORENAME_PO.Checked = SQLReader.Item("PRINT_STORENAME_PO")
                ChkPRINT_STORENAME_ROA.Checked = SQLReader.Item("PRINT_STORENAME_ROA")
                ChkPRINT_STORENAME_WO.Checked = SQLReader.Item("PRINT_STORENAME_WO")

                CHKRULES1.Checked = SQLReader.Item("RULES1")
                CHKRULES2.Checked = SQLReader.Item("RULES2")
                CHKRULES3.Checked = SQLReader.Item("RULES3")
                CHKRULES4.Checked = SQLReader.Item("RULES4")
                CHKRULES5.Checked = SQLReader.Item("RULES5")
                CHKRULES6.Checked = SQLReader.Item("RULES6")
                CHKRULES7.Checked = SQLReader.Item("RULES7")
                CHKRULES8.Checked = SQLReader.Item("RULES8")
                CHKRULES9.Checked = SQLReader.Item("RULES9")
                CHKRULES10.Checked = SQLReader.Item("RULES10")
                CHKRULES11.Checked = SQLReader.Item("RULES11")
                CHKRULES12.Checked = SQLReader.Item("RULES12")
                CHKFUNCTIONS1.Checked = SQLReader.Item("FUNCTIONS1")
                CHKFUNCTIONS2.Checked = SQLReader.Item("FUNCTIONS2")
                CHKFUNCTIONS3.Checked = SQLReader.Item("FUNCTIONS3")
                CHKFUNCTIONS4.Checked = SQLReader.Item("FUNCTIONS4")
                CHKFUNCTIONS5.Checked = SQLReader.Item("FUNCTIONS5")
                CHKFUNCTIONS6.Checked = SQLReader.Item("FUNCTIONS6")
                CHKFUNCTIONS7.Checked = SQLReader.Item("FUNCTIONS7")
                CHKFUNCTIONS8.Checked = SQLReader.Item("FUNCTIONS8")
                CHKFUNCTIONS9.Checked = SQLReader.Item("FUNCTIONS9")
                CHKFUNCTIONS10.Checked = SQLReader.Item("FUNCTIONS10")
                CHKFUNCTIONS11.Checked = SQLReader.Item("FUNCTIONS11")
                CHKFUNCTIONS12.Checked = SQLReader.Item("FUNCTIONS12")
                CHKFUNCTIONS13.Checked = SQLReader.Item("FUNCTIONS13")
                CHKFUNCTIONS14.Checked = SQLReader.Item("FUNCTIONS14")
                CHKFUNCTIONS15.Checked = SQLReader.Item("FUNCTIONS15")
                CHKFUNCTIONS16.Checked = SQLReader.Item("FUNCTIONS16")
                CHKFUNCTIONS17.Checked = SQLReader.Item("FUNCTIONS17")

                ChkAccountAdjustmentsShadingYes.Checked = IIf(SQLReader.Item("AccountAdjustmentsShading") = 1, True, False)
                ChkCustomerPaymentsShadingYes.Checked = IIf(SQLReader.Item("CustomerPaymentsShading") = 1, True, False)
                ChkCustomerReturnsShadingYes.Checked = IIf(SQLReader.Item("CustomerReturnsShading") = 1, True, False)
                ChkEstimatesShadingYes.Checked = IIf(SQLReader.Item("EstimatesShading") = 1, True, False)
                ChkInventoryAdjustmentsShadingYes.Checked = IIf(SQLReader.Item("InventoryAdjustmentsShading") = 1, True, False)
                ChkInventoryReceiptsShadingYes.Checked = IIf(SQLReader.Item("InventoryReceiptsShading") = 1, True, False)
                ChkInventoryReturnsShadingYes.Checked = IIf(SQLReader.Item("InventoryReturnsShading") = 1, True, False)
                ChkInvoicesShadingYes.Checked = IIf(SQLReader.Item("InvoicesShading") = 1, True, False)
                ChkPurchasesOrdersShadingYes.Checked = IIf(SQLReader.Item("PurchasesOrdersShading") = 1, True, False)
                ChkWorkOrdersShadingYes.Checked = IIf(SQLReader.Item("WorkOrdersShading") = 1, True, False)

                ChkAccountAdjustmentsShadingNo.Checked = IIf(SQLReader.Item("AccountAdjustmentsShading") = 0, True, False)
                ChkCustomerPaymentsShadingNo.Checked = IIf(SQLReader.Item("CustomerPaymentsShading") = 0, True, False)
                ChkCustomerReturnsShadingNo.Checked = IIf(SQLReader.Item("CustomerReturnsShading") = 0, True, False)
                ChkEstimatesShadingNo.Checked = IIf(SQLReader.Item("EstimatesShading") = 0, True, False)
                ChkInventoryAdjustmentsShadingNo.Checked = IIf(SQLReader.Item("InventoryAdjustmentsShading") = 0, True, False)
                ChkInventoryReceiptsShadingNo.Checked = IIf(SQLReader.Item("InventoryReceiptsShading") = 0, True, False)
                ChkInventoryReturnsShadingNo.Checked = IIf(SQLReader.Item("InventoryReturnsShading") = 0, True, False)
                ChkInvoicesShadingNo.Checked = IIf(SQLReader.Item("InvoicesShading") = 0, True, False)
                ChkPurchasesOrdersShadingNo.Checked = IIf(SQLReader.Item("PurchasesOrdersShading") = 0, True, False)
                ChkWorkOrdersShadingNo.Checked = IIf(SQLReader.Item("WorkOrdersShading") = 0, True, False)

                PhoneNo1.Text = SQLReader.Item("PHONE") & ""
                PhoneNo2.Text = SQLReader.Item("FAX") & ""

                EmailAddress1.Text = SQLReader.Item("EMAIL") & ""

                CmbInterStorePayableAccount.SelectedValue = SQLReader.Item("InterStorePayableAccount") & ""
                CmbInterStoreReceivableAccount.SelectedValue = SQLReader.Item("InterStoreReceivableAccount") & ""

                Dim Ziptemp1 As String = Trim(SQLReader.Item("ZIPCODE") & "")
                ZipCode1.Text = Ziptemp1
                '''''''''''''''''''''''''''''''''''''''
                FillFields = True
            Else
                Call ClearField()
            End If
        Catch ex As Exception
        End Try
        Try
            SQLReader.Close()
            CmdGeneral.Connection.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub FillOtherFields()
        If TxtSTORENO.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.OleDb.OleDbDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * from Store_Setup where StoreNo=" & TxtSTORENO.Text '& " Order by "
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            'TXTLastPurchaseAmount.Text = Trim(SQLReader.Item("current_mileage"))
        Else
            'LblCredit_Remaining.Text = ""
        End If
        SQLReader.Close()
        CmdGeneral.Connection.Close()
    End Sub
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call PAddNew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call PEdit()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Call PDelete()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call PSave()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call PCancel()
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Call PFirstRecord()
    End Sub
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Call PPreviousRecord()
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Call PNextRecord()
    End Sub
    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Call PLastRecord()
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        LblCity.Text = ZipCode1.City
        LblSt.Text = ZipCode1.State
    End Sub
    Private Sub ZipCode1_NotFindZipCode() Handles ZipCode1.NotFindZipCode
        LblCity.Text = ""
        LblSt.Text = ""
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UIContextMenu1.CommandClick
        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                StoreOrderFieldName = "StoreNo"
            Case "SORT2"
                StoreOrderFieldName = "StoreName"
            Case "SORT3"
                StoreOrderFieldName = "ShortName"
        End Select
    End Sub
    Private Sub Txtstoreno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSTORENO.LostFocus
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT count(*) from Store_Setup where StoreNo=" & Qt(TxtSTORENO.Text) '& " Order by "
        If CmdGeneral.ExecuteScalar() > 0 Then
            MsgBox("This Store No already axist.Try a new Code")
            TxtSTORENO.Clear()
            TxtSTORENO.Focus()
        End If
    End Sub
    Private Function MakeNewStoreCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(StoreNo) as Max_cod from Store_Setup"
            MakeNewStoreCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewStoreCod, LenStoreCod)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewStoreCod.Length >= i Then
                MakeNewStoreCod = Mid(MakeNewStoreCod, 1, Len(MakeNewStoreCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewStoreCod.Trim.Length > LenStoreCod Then
                MakeNewStoreCod = "01"
            End If
        Catch ex As Exception
            MakeNewStoreCod = "01"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Sub SayStoreName()
        If CmbStores.Text.Trim.Length > 0 Then
            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrieveStoreSetupTable(CmbStores.Text)
            CmbStores.SelectedValue = OleDbReaderForStore.Item("Storeno") & ""
            LblStoreName.Text = OleDbReaderForStore.Item("StoreName") & ""
            LblShortName.Text = OleDbReaderForStore.Item("ShortName") & ""
            OleDbReaderForStore.Close()
        Else
            LblStoreName.Text = ""
            LblShortName.Text = ""
        End If
    End Sub
End Class
