Imports CommonClass
Public Class FrmCustomer
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim CustomerOrderFieldName As String = "Cod_Customer"
    Public CustomerCodTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Dim MyFrmItemComments As CommonClass.FrmItemComments
    Public CustomerNoteVar As String
    Dim MyFrmDriverName As New FrmDriverName
    Public Cod_customerVar As String = ""
    Dim MyClsCustomerCod As New ClsCustomerCod
    Dim WithEvents MyFrmFindCustomer As New UCCustomer.FrmSearchCustomerCode
    Dim AreaCodVar As String
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
    Friend WithEvents CmdDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents CnnTemp As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdate As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtvip_code As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAR_charge As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPriceLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSales_tax As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAR_term As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCreditCardNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnBalance As System.Windows.Forms.Button
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkStatement As System.Windows.Forms.CheckBox
    Friend WithEvents chkSendCopies As System.Windows.Forms.CheckBox
    Friend WithEvents chkFinCharge As System.Windows.Forms.CheckBox
    Friend WithEvents chkRequirePO As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreditHold As System.Windows.Forms.CheckBox
    Friend WithEvents chkAcceptCheck As System.Windows.Forms.CheckBox
    Friend WithEvents chkInactive As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cmbSaleRep As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmbTerritory As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmbSource As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents BtnVehicles As System.Windows.Forms.Button
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents btnNotes As System.Windows.Forms.Button
    Friend WithEvents TxtCustomerCod As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACust_sales_tax As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmCustomer1 As UCCustomer.DSUCCustomer
    Friend WithEvents CompanyName1 As UCCompany.CompanyName
    Friend WithEvents BtnDriver As System.Windows.Forms.Button
    Friend WithEvents DAcust_tab_source As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_territory As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_class As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_trtab_main As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_tab_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As EmailAndWebAddress.EmailAddress
    Friend WithEvents PhoneNoMain As UCPhone.PhoneNo
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LblLastVisit As System.Windows.Forms.TextBox
    Friend WithEvents LblCustmerSince As System.Windows.Forms.TextBox
    Friend WithEvents LblLastPaymentDate As System.Windows.Forms.TextBox
    Friend WithEvents LblSalesActivityDate As System.Windows.Forms.TextBox
    Friend WithEvents LblFinanceCharges As System.Windows.Forms.TextBox
    Friend WithEvents LblNextPaymentDate As System.Windows.Forms.TextBox
    Friend WithEvents SocialSecurityNoNo1 As UCEmployee.SocialSecurityNoNo
    Friend WithEvents NumDiscount As CalcUtils.UcCalcText
    Friend WithEvents chkScrapTireLicense As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTaxable As System.Windows.Forms.CheckBox
    Friend WithEvents TxtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSt As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtCity As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents NumScrapTireLicense As CalcUtils.UcCalcText
    Friend WithEvents NumCreditLimit As CalcUtils.UcCalcText
    Friend WithEvents txtDriverLicense As System.Windows.Forms.TextBox
    Friend WithEvents DteExpDate As CalendarCombo.CalendarCombo
    Friend WithEvents PhoneButton1 As UCPhone.PhoneButton
    Friend WithEvents LblSalesActivityAmount As CalcUtils.UcCalcText
    Friend WithEvents LblSalesActivityThisYear As CalcUtils.UcCalcText
    Friend WithEvents LblNextPaymentAmount As CalcUtils.UcCalcText
    Friend WithEvents LblLastPaymentAmount As CalcUtils.UcCalcText
    Friend WithEvents LblCreditBalance As CalcUtils.UcCalcText
    Friend WithEvents LblCreditRemaining As CalcUtils.UcCalcText
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LblSalesActivityThisMonth As CalcUtils.UcCalcText
    Friend WithEvents ChkPrintstatementDetailFlag As System.Windows.Forms.CheckBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents DteCustomer_Birth_Date As CalendarCombo.CalendarCombo
    Friend WithEvents NumTaxExemptID As Janus.Windows.GridEX.EditControls.MaskedEditBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCustomer))
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
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.DteCustomer_Birth_Date = New CalendarCombo.CalendarCombo
        Me.Label49 = New System.Windows.Forms.Label
        Me.PhoneButton1 = New UCPhone.PhoneButton
        Me.NumDiscount = New CalcUtils.UcCalcText
        Me.txtEmail = New EmailAndWebAddress.EmailAddress
        Me.BtnDriver = New System.Windows.Forms.Button
        Me.CompanyName1 = New UCCompany.CompanyName
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.PhoneNoMain = New UCPhone.PhoneNo
        Me.BtnVehicles = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ChkPrintstatementDetailFlag = New System.Windows.Forms.CheckBox
        Me.TxtCustomerNo = New System.Windows.Forms.TextBox
        Me.chkStatement = New System.Windows.Forms.CheckBox
        Me.chkSendCopies = New System.Windows.Forms.CheckBox
        Me.chkFinCharge = New System.Windows.Forms.CheckBox
        Me.chkRequirePO = New System.Windows.Forms.CheckBox
        Me.chkCreditHold = New System.Windows.Forms.CheckBox
        Me.chkAcceptCheck = New System.Windows.Forms.CheckBox
        Me.chkInactive = New System.Windows.Forms.CheckBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.LblLastVisit = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.LblCustmerSince = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.cmbSaleRep = New System.Windows.Forms.ComboBox
        Me.DsFrmCustomer1 = New UCCustomer.DSUCCustomer
        Me.Label35 = New System.Windows.Forms.Label
        Me.cmbTerritory = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.cmbClass = New System.Windows.Forms.ComboBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.cmbSource = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.BtnBalance = New System.Windows.Forms.Button
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.NumTaxExemptID = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LblCreditRemaining = New CalcUtils.UcCalcText
        Me.LblCreditBalance = New CalcUtils.UcCalcText
        Me.LblLastPaymentAmount = New CalcUtils.UcCalcText
        Me.LblSalesActivityThisMonth = New CalcUtils.UcCalcText
        Me.LblSalesActivityThisYear = New CalcUtils.UcCalcText
        Me.LblNextPaymentAmount = New CalcUtils.UcCalcText
        Me.LblSalesActivityAmount = New CalcUtils.UcCalcText
        Me.DteExpDate = New CalendarCombo.CalendarCombo
        Me.NumCreditLimit = New CalcUtils.UcCalcText
        Me.NumScrapTireLicense = New CalcUtils.UcCalcText
        Me.SocialSecurityNoNo1 = New UCEmployee.SocialSecurityNoNo
        Me.btnNotes = New System.Windows.Forms.Button
        Me.txtDriverLicense = New System.Windows.Forms.TextBox
        Me.txtCreditCardNo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblLastPaymentDate = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.LblSalesActivityDate = New System.Windows.Forms.TextBox
        Me.LblFinanceCharges = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.LblNextPaymentDate = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.chkScrapTireLicense = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPriceLevel = New System.Windows.Forms.ComboBox
        Me.cmbSales_tax = New System.Windows.Forms.ComboBox
        Me.cmbAR_term = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDriver = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.label = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtvip_code = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TxtCustomerCod = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtSt = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtCity = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ChkTaxable = New System.Windows.Forms.CheckBox
        Me.chkAR_charge = New System.Windows.Forms.CheckBox
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label44 = New System.Windows.Forms.Label
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
        Me.UiContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort1 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort2 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DACust_sales_tax = New System.Data.SqlClient.SqlDataAdapter
        Me.DAcust_tab_source = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_territory = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_class = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_trtab_main = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_tab_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsFrmCustomer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM cust_trtab_main WHERE (cod_customer = @cod_Customer)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_Customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.CustomerCod1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(669, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Location = New System.Drawing.Point(57, 1)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(128, 21)
        Me.CustomerCod1.TabIndex = 189
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Customer"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.DteCustomer_Birth_Date)
        Me.PnlKartAmvalField.Controls.Add(Me.Label49)
        Me.PnlKartAmvalField.Controls.Add(Me.PhoneButton1)
        Me.PnlKartAmvalField.Controls.Add(Me.NumDiscount)
        Me.PnlKartAmvalField.Controls.Add(Me.txtEmail)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnDriver)
        Me.PnlKartAmvalField.Controls.Add(Me.CompanyName1)
        Me.PnlKartAmvalField.Controls.Add(Me.ZipCode1)
        Me.PnlKartAmvalField.Controls.Add(Me.PhoneNoMain)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnVehicles)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel2)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnBalance)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnHistory)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.cmbPriceLevel)
        Me.PnlKartAmvalField.Controls.Add(Me.cmbSales_tax)
        Me.PnlKartAmvalField.Controls.Add(Me.cmbAR_term)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.txtMName)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Controls.Add(Me.txtLName)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Controls.Add(Me.txtAddress)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.txtFName)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.txtDriver)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Controls.Add(Me.Label9)
        Me.PnlKartAmvalField.Controls.Add(Me.Label10)
        Me.PnlKartAmvalField.Controls.Add(Me.label)
        Me.PnlKartAmvalField.Controls.Add(Me.Label13)
        Me.PnlKartAmvalField.Controls.Add(Me.Label14)
        Me.PnlKartAmvalField.Controls.Add(Me.txtvip_code)
        Me.PnlKartAmvalField.Controls.Add(Me.Label26)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtCustomerCod)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtSt)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtCity)
        Me.PnlKartAmvalField.Controls.Add(Me.Label12)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkTaxable)
        Me.PnlKartAmvalField.Controls.Add(Me.chkAR_charge)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(669, 330)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'DteCustomer_Birth_Date
        '
        Me.DteCustomer_Birth_Date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteCustomer_Birth_Date.BorderColor = System.Drawing.Color.Empty
        Me.DteCustomer_Birth_Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteCustomer_Birth_Date.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteCustomer_Birth_Date.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteCustomer_Birth_Date.EditableSal = True
        Me.DteCustomer_Birth_Date.Image = CType(resources.GetObject("DteCustomer_Birth_Date.Image"), System.Drawing.Image)
        Me.DteCustomer_Birth_Date.Location = New System.Drawing.Point(519, 5)
        Me.DteCustomer_Birth_Date.MaxValue = CType(2500, Short)
        Me.DteCustomer_Birth_Date.MinValue = CType(1800, Short)
        Me.DteCustomer_Birth_Date.Name = "DteCustomer_Birth_Date"
        Me.DteCustomer_Birth_Date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteCustomer_Birth_Date.Sal_Mali = Nothing
        Me.DteCustomer_Birth_Date.ShowButton = True
        Me.DteCustomer_Birth_Date.Size = New System.Drawing.Size(102, 23)
        Me.DteCustomer_Birth_Date.TabIndex = 451
        Me.DteCustomer_Birth_Date.VisualStyle = False
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(425, 5)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 21)
        Me.Label49.TabIndex = 450
        Me.Label49.Text = "Birth Date"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneButton1
        '
        Me.PhoneButton1.Location = New System.Drawing.Point(389, 59)
        Me.PhoneButton1.Name = "PhoneButton1"
        Me.PhoneButton1.Size = New System.Drawing.Size(23, 23)
        Me.PhoneButton1.TabIndex = 449
        Me.PhoneButton1.ZEnabled = True
        '
        'NumDiscount
        '
        Me.NumDiscount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDiscount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDiscount.DecimalDigits = 0
        Me.NumDiscount.DefaultSendValue = False
        Me.NumDiscount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDiscount.FireTabAfterEnter = True
        Me.NumDiscount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDiscount.Image = CType(resources.GetObject("NumDiscount.Image"), System.Drawing.Image)
        Me.NumDiscount.Location = New System.Drawing.Point(628, 107)
        Me.NumDiscount.Maxlength = 3
        Me.NumDiscount.MinusColor = System.Drawing.Color.Empty
        Me.NumDiscount.Name = "NumDiscount"
        Me.NumDiscount.Size = New System.Drawing.Size(38, 21)
        Me.NumDiscount.TabIndex = 18
        Me.NumDiscount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDiscount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'txtEmail
        '
        Me.txtEmail.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtEmail.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtEmail.ErrorColor = System.Drawing.Color.Red
        Me.txtEmail.ErrorMessage = "abc@microsoft.com ¬œ—” Å”  «·ò —Ê‰ÌòÌ »«Ì” Ì »Â «Ì‰ ’Ê—  »«‘œ"
        Me.txtEmail.Location = New System.Drawing.Point(296, 83)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(116, 21)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtEmail.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0" & _
        "-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-" & _
        "9][0-9]|[1-9][0-9]|[0-9])\])$"
        '
        'BtnDriver
        '
        Me.BtnDriver.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDriver.Image = CType(resources.GetObject("BtnDriver.Image"), System.Drawing.Image)
        Me.BtnDriver.Location = New System.Drawing.Point(401, 107)
        Me.BtnDriver.Name = "BtnDriver"
        Me.BtnDriver.Size = New System.Drawing.Size(23, 23)
        Me.BtnDriver.TabIndex = 443
        Me.BtnDriver.TabStop = False
        '
        'CompanyName1
        '
        Me.CompanyName1.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D
        Me.CompanyName1.CompanyCod = ""
        Me.CompanyName1.CompanyCodForFind = ""
        Me.CompanyName1.CompanyComplete_Name = ""
        Me.CompanyName1.Connection = Me.Cnn
        Me.CompanyName1.Location = New System.Drawing.Point(76, 58)
        Me.CompanyName1.Name = "CompanyName1"
        Me.CompanyName1.NotExitIfNotFound = False
        Me.CompanyName1.ReleaseIfNotFoundCompanyName = False
        Me.CompanyName1.Size = New System.Drawing.Size(178, 22)
        Me.CompanyName1.TabIndex = 5
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Location = New System.Drawing.Point(184, 106)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(59, 21)
        Me.ZipCode1.TabIndex = 9
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'PhoneNoMain
        '
        Me.PhoneNoMain.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNoMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNoMain.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNoMain.Location = New System.Drawing.Point(295, 59)
        Me.PhoneNoMain.Name = "PhoneNoMain"
        Me.PhoneNoMain.Size = New System.Drawing.Size(94, 22)
        Me.PhoneNoMain.TabIndex = 6
        '
        'BtnVehicles
        '
        Me.BtnVehicles.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnVehicles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVehicles.Location = New System.Drawing.Point(496, 33)
        Me.BtnVehicles.Name = "BtnVehicles"
        Me.BtnVehicles.Size = New System.Drawing.Size(71, 20)
        Me.BtnVehicles.TabIndex = 436
        Me.BtnVehicles.TabStop = False
        Me.BtnVehicles.Text = "Vehicles"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ChkPrintstatementDetailFlag)
        Me.Panel2.Controls.Add(Me.TxtCustomerNo)
        Me.Panel2.Controls.Add(Me.chkStatement)
        Me.Panel2.Controls.Add(Me.chkSendCopies)
        Me.Panel2.Controls.Add(Me.chkFinCharge)
        Me.Panel2.Controls.Add(Me.chkRequirePO)
        Me.Panel2.Controls.Add(Me.chkCreditHold)
        Me.Panel2.Controls.Add(Me.chkAcceptCheck)
        Me.Panel2.Controls.Add(Me.chkInactive)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.txtUserID)
        Me.Panel2.Controls.Add(Me.LblLastVisit)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.LblCustmerSince)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.cmbSaleRep)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.cmbTerritory)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.cmbClass)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.cmbSource)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.cmbType)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.Label45)
        Me.Panel2.Controls.Add(Me.Label47)
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Location = New System.Drawing.Point(392, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 198)
        Me.Panel2.TabIndex = 21
        '
        'ChkPrintstatementDetailFlag
        '
        Me.ChkPrintstatementDetailFlag.BackColor = System.Drawing.SystemColors.Control
        Me.ChkPrintstatementDetailFlag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkPrintstatementDetailFlag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkPrintstatementDetailFlag.Location = New System.Drawing.Point(185, 134)
        Me.ChkPrintstatementDetailFlag.Name = "ChkPrintstatementDetailFlag"
        Me.ChkPrintstatementDetailFlag.Size = New System.Drawing.Size(92, 40)
        Me.ChkPrintstatementDetailFlag.TabIndex = 14
        Me.ChkPrintstatementDetailFlag.Text = "Print Statement Detail"
        '
        'TxtCustomerNo
        '
        Me.TxtCustomerNo.Location = New System.Drawing.Point(67, 107)
        Me.TxtCustomerNo.MaxLength = 10
        Me.TxtCustomerNo.Name = "TxtCustomerNo"
        Me.TxtCustomerNo.Size = New System.Drawing.Size(115, 21)
        Me.TxtCustomerNo.TabIndex = 5
        Me.TxtCustomerNo.Text = ""
        Me.TxtCustomerNo.Visible = False
        '
        'chkStatement
        '
        Me.chkStatement.BackColor = System.Drawing.SystemColors.Control
        Me.chkStatement.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkStatement.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkStatement.Location = New System.Drawing.Point(186, 6)
        Me.chkStatement.Name = "chkStatement"
        Me.chkStatement.Size = New System.Drawing.Size(90, 15)
        Me.chkStatement.TabIndex = 7
        Me.chkStatement.Text = "Statement"
        '
        'chkSendCopies
        '
        Me.chkSendCopies.BackColor = System.Drawing.SystemColors.Control
        Me.chkSendCopies.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkSendCopies.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSendCopies.Location = New System.Drawing.Point(186, 23)
        Me.chkSendCopies.Name = "chkSendCopies"
        Me.chkSendCopies.Size = New System.Drawing.Size(90, 17)
        Me.chkSendCopies.TabIndex = 8
        Me.chkSendCopies.Text = "Send Copies"
        '
        'chkFinCharge
        '
        Me.chkFinCharge.BackColor = System.Drawing.SystemColors.Control
        Me.chkFinCharge.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkFinCharge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFinCharge.Location = New System.Drawing.Point(186, 42)
        Me.chkFinCharge.Name = "chkFinCharge"
        Me.chkFinCharge.Size = New System.Drawing.Size(90, 16)
        Me.chkFinCharge.TabIndex = 9
        Me.chkFinCharge.Text = "Fin. Charge"
        '
        'chkRequirePO
        '
        Me.chkRequirePO.BackColor = System.Drawing.SystemColors.Control
        Me.chkRequirePO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkRequirePO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRequirePO.Location = New System.Drawing.Point(186, 60)
        Me.chkRequirePO.Name = "chkRequirePO"
        Me.chkRequirePO.Size = New System.Drawing.Size(90, 16)
        Me.chkRequirePO.TabIndex = 10
        Me.chkRequirePO.Text = "Require PO"
        '
        'chkCreditHold
        '
        Me.chkCreditHold.BackColor = System.Drawing.SystemColors.Control
        Me.chkCreditHold.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkCreditHold.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCreditHold.Location = New System.Drawing.Point(186, 78)
        Me.chkCreditHold.Name = "chkCreditHold"
        Me.chkCreditHold.Size = New System.Drawing.Size(90, 16)
        Me.chkCreditHold.TabIndex = 11
        Me.chkCreditHold.Text = "Credit Hold"
        '
        'chkAcceptCheck
        '
        Me.chkAcceptCheck.BackColor = System.Drawing.SystemColors.Control
        Me.chkAcceptCheck.Checked = True
        Me.chkAcceptCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAcceptCheck.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkAcceptCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAcceptCheck.Location = New System.Drawing.Point(186, 96)
        Me.chkAcceptCheck.Name = "chkAcceptCheck"
        Me.chkAcceptCheck.Size = New System.Drawing.Size(90, 16)
        Me.chkAcceptCheck.TabIndex = 12
        Me.chkAcceptCheck.Text = "Accept Check"
        '
        'chkInactive
        '
        Me.chkInactive.BackColor = System.Drawing.SystemColors.Control
        Me.chkInactive.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkInactive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkInactive.Location = New System.Drawing.Point(186, 114)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(75, 17)
        Me.chkInactive.TabIndex = 13
        Me.chkInactive.Text = "Inactive"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(167, 175)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(99, 21)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.Text = ""
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(50, 175)
        Me.txtUserID.MaxLength = 30
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(58, 21)
        Me.txtUserID.TabIndex = 450
        Me.txtUserID.Text = ""
        '
        'LblLastVisit
        '
        Me.LblLastVisit.BackColor = System.Drawing.Color.Gold
        Me.LblLastVisit.Location = New System.Drawing.Point(92, 151)
        Me.LblLastVisit.Name = "LblLastVisit"
        Me.LblLastVisit.ReadOnly = True
        Me.LblLastVisit.Size = New System.Drawing.Size(91, 21)
        Me.LblLastVisit.TabIndex = 454
        Me.LblLastVisit.Text = ""
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(8, 151)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(82, 20)
        Me.Label37.TabIndex = 448
        Me.Label37.Text = "Last Visit"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCustmerSince
        '
        Me.LblCustmerSince.BackColor = System.Drawing.Color.Gold
        Me.LblCustmerSince.Location = New System.Drawing.Point(92, 129)
        Me.LblCustmerSince.Name = "LblCustmerSince"
        Me.LblCustmerSince.ReadOnly = True
        Me.LblCustmerSince.Size = New System.Drawing.Size(92, 21)
        Me.LblCustmerSince.TabIndex = 453
        Me.LblCustmerSince.Text = ""
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(8, 129)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(82, 20)
        Me.Label36.TabIndex = 447
        Me.Label36.Text = "Customer Since"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSaleRep
        '
        Me.cmbSaleRep.DataSource = Me.DsFrmCustomer1.employee
        Me.cmbSaleRep.DisplayMember = "employee_name"
        Me.cmbSaleRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSaleRep.ItemHeight = 13
        Me.cmbSaleRep.Location = New System.Drawing.Point(67, 85)
        Me.cmbSaleRep.Name = "cmbSaleRep"
        Me.cmbSaleRep.Size = New System.Drawing.Size(117, 21)
        Me.cmbSaleRep.TabIndex = 4
        Me.cmbSaleRep.ValueMember = "employee_code"
        '
        'DsFrmCustomer1
        '
        Me.DsFrmCustomer1.DataSetName = "DSFrmCustomer"
        Me.DsFrmCustomer1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(10, 85)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 21)
        Me.Label35.TabIndex = 435
        Me.Label35.Text = "Sales Rep"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTerritory
        '
        Me.cmbTerritory.DataSource = Me.DsFrmCustomer1.cust_tab_territory
        Me.cmbTerritory.DisplayMember = "desc_territory"
        Me.cmbTerritory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerritory.Location = New System.Drawing.Point(67, 65)
        Me.cmbTerritory.Name = "cmbTerritory"
        Me.cmbTerritory.Size = New System.Drawing.Size(117, 21)
        Me.cmbTerritory.TabIndex = 3
        Me.cmbTerritory.ValueMember = "cod_territory"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(9, 66)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 20)
        Me.Label34.TabIndex = 433
        Me.Label34.Text = "Territory"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbClass
        '
        Me.cmbClass.DataSource = Me.DsFrmCustomer1.cust_tab_class
        Me.cmbClass.DisplayMember = "desc_class"
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.Location = New System.Drawing.Point(67, 45)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(117, 21)
        Me.cmbClass.TabIndex = 2
        Me.cmbClass.ValueMember = "cod_class"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(9, 45)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 22)
        Me.Label33.TabIndex = 432
        Me.Label33.Text = "Class"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSource
        '
        Me.cmbSource.DataSource = Me.DsFrmCustomer1.cust_tab_source
        Me.cmbSource.DisplayMember = "desc_source"
        Me.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSource.Location = New System.Drawing.Point(67, 24)
        Me.cmbSource.Name = "cmbSource"
        Me.cmbSource.Size = New System.Drawing.Size(117, 21)
        Me.cmbSource.TabIndex = 1
        Me.cmbSource.ValueMember = "cod_source"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(9, 25)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(53, 21)
        Me.Label38.TabIndex = 431
        Me.Label38.Text = "Source"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbType
        '
        Me.cmbType.DataSource = Me.DsFrmCustomer1.cust_tab_type
        Me.cmbType.DisplayMember = "desc_type"
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Location = New System.Drawing.Point(67, 4)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(117, 21)
        Me.cmbType.TabIndex = 0
        Me.cmbType.ValueMember = "cod_type"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(9, 3)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(53, 21)
        Me.Label39.TabIndex = 430
        Me.Label39.Text = "Type"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(116, 174)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(51, 20)
        Me.Label45.TabIndex = 451
        Me.Label45.Text = "Password"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(5, 174)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(46, 19)
        Me.Label47.TabIndex = 449
        Me.Label47.Text = "User ID"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(-5, 108)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 20)
        Me.Label48.TabIndex = 456
        Me.Label48.Text = "CustomerNo"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label48.Visible = False
        '
        'BtnBalance
        '
        Me.BtnBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBalance.Location = New System.Drawing.Point(416, 33)
        Me.BtnBalance.Name = "BtnBalance"
        Me.BtnBalance.Size = New System.Drawing.Size(71, 20)
        Me.BtnBalance.TabIndex = 434
        Me.BtnBalance.TabStop = False
        Me.BtnBalance.Text = "Balance"
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHistory.Location = New System.Drawing.Point(576, 33)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(71, 20)
        Me.BtnHistory.TabIndex = 432
        Me.BtnHistory.TabStop = False
        Me.BtnHistory.Text = "History"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NumTaxExemptID)
        Me.Panel1.Controls.Add(Me.LblCreditRemaining)
        Me.Panel1.Controls.Add(Me.LblCreditBalance)
        Me.Panel1.Controls.Add(Me.LblLastPaymentAmount)
        Me.Panel1.Controls.Add(Me.LblSalesActivityThisMonth)
        Me.Panel1.Controls.Add(Me.LblSalesActivityThisYear)
        Me.Panel1.Controls.Add(Me.LblNextPaymentAmount)
        Me.Panel1.Controls.Add(Me.LblSalesActivityAmount)
        Me.Panel1.Controls.Add(Me.DteExpDate)
        Me.Panel1.Controls.Add(Me.NumCreditLimit)
        Me.Panel1.Controls.Add(Me.NumScrapTireLicense)
        Me.Panel1.Controls.Add(Me.SocialSecurityNoNo1)
        Me.Panel1.Controls.Add(Me.btnNotes)
        Me.Panel1.Controls.Add(Me.txtDriverLicense)
        Me.Panel1.Controls.Add(Me.txtCreditCardNo)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.LblLastPaymentDate)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.LblSalesActivityDate)
        Me.Panel1.Controls.Add(Me.LblFinanceCharges)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.LblNextPaymentDate)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.Label46)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.chkScrapTireLicense)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Location = New System.Drawing.Point(1, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 198)
        Me.Panel1.TabIndex = 20
        '
        'NumTaxExemptID
        '
        Me.NumTaxExemptID.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumTaxExemptID.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumTaxExemptID.Location = New System.Drawing.Point(89, 30)
        Me.NumTaxExemptID.Mask = "############"
        Me.NumTaxExemptID.MaxLength = 12
        Me.NumTaxExemptID.Name = "NumTaxExemptID"
        Me.NumTaxExemptID.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.NumTaxExemptID.Size = New System.Drawing.Size(104, 21)
        Me.NumTaxExemptID.TabIndex = 1
        Me.NumTaxExemptID.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LblCreditRemaining
        '
        Me.LblCreditRemaining.BackColor = System.Drawing.Color.Gold
        Me.LblCreditRemaining.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCreditRemaining.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCreditRemaining.DecimalDigits = 2
        Me.LblCreditRemaining.DefaultSendValue = False
        Me.LblCreditRemaining.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCreditRemaining.FireTabAfterEnter = True
        Me.LblCreditRemaining.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCreditRemaining.Image = CType(resources.GetObject("LblCreditRemaining.Image"), System.Drawing.Image)
        Me.LblCreditRemaining.Location = New System.Drawing.Point(238, 92)
        Me.LblCreditRemaining.Maxlength = 12
        Me.LblCreditRemaining.MinusColor = System.Drawing.Color.Empty
        Me.LblCreditRemaining.Name = "LblCreditRemaining"
        Me.LblCreditRemaining.ReadOnly = True
        Me.LblCreditRemaining.Size = New System.Drawing.Size(76, 21)
        Me.LblCreditRemaining.TabIndex = 449
        Me.LblCreditRemaining.TabStop = False
        Me.LblCreditRemaining.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCreditRemaining.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblCreditBalance
        '
        Me.LblCreditBalance.BackColor = System.Drawing.Color.Gold
        Me.LblCreditBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCreditBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCreditBalance.DecimalDigits = 2
        Me.LblCreditBalance.DefaultSendValue = False
        Me.LblCreditBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCreditBalance.FireTabAfterEnter = True
        Me.LblCreditBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCreditBalance.Image = CType(resources.GetObject("LblCreditBalance.Image"), System.Drawing.Image)
        Me.LblCreditBalance.Location = New System.Drawing.Point(158, 92)
        Me.LblCreditBalance.Maxlength = 12
        Me.LblCreditBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblCreditBalance.Name = "LblCreditBalance"
        Me.LblCreditBalance.ReadOnly = True
        Me.LblCreditBalance.Size = New System.Drawing.Size(79, 21)
        Me.LblCreditBalance.TabIndex = 448
        Me.LblCreditBalance.TabStop = False
        Me.LblCreditBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCreditBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblLastPaymentAmount
        '
        Me.LblLastPaymentAmount.BackColor = System.Drawing.Color.Gold
        Me.LblLastPaymentAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblLastPaymentAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblLastPaymentAmount.DecimalDigits = 2
        Me.LblLastPaymentAmount.DefaultSendValue = False
        Me.LblLastPaymentAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblLastPaymentAmount.FireTabAfterEnter = True
        Me.LblLastPaymentAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblLastPaymentAmount.Image = CType(resources.GetObject("LblLastPaymentAmount.Image"), System.Drawing.Image)
        Me.LblLastPaymentAmount.Location = New System.Drawing.Point(79, 152)
        Me.LblLastPaymentAmount.Maxlength = 12
        Me.LblLastPaymentAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblLastPaymentAmount.Name = "LblLastPaymentAmount"
        Me.LblLastPaymentAmount.ReadOnly = True
        Me.LblLastPaymentAmount.Size = New System.Drawing.Size(76, 21)
        Me.LblLastPaymentAmount.TabIndex = 447
        Me.LblLastPaymentAmount.TabStop = False
        Me.LblLastPaymentAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblLastPaymentAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblSalesActivityThisMonth
        '
        Me.LblSalesActivityThisMonth.BackColor = System.Drawing.Color.Gold
        Me.LblSalesActivityThisMonth.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblSalesActivityThisMonth.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblSalesActivityThisMonth.DecimalDigits = 2
        Me.LblSalesActivityThisMonth.DefaultSendValue = False
        Me.LblSalesActivityThisMonth.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblSalesActivityThisMonth.FireTabAfterEnter = True
        Me.LblSalesActivityThisMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSalesActivityThisMonth.Image = CType(resources.GetObject("LblSalesActivityThisMonth.Image"), System.Drawing.Image)
        Me.LblSalesActivityThisMonth.Location = New System.Drawing.Point(236, 130)
        Me.LblSalesActivityThisMonth.Maxlength = 12
        Me.LblSalesActivityThisMonth.MinusColor = System.Drawing.Color.Empty
        Me.LblSalesActivityThisMonth.Name = "LblSalesActivityThisMonth"
        Me.LblSalesActivityThisMonth.ReadOnly = True
        Me.LblSalesActivityThisMonth.Size = New System.Drawing.Size(76, 21)
        Me.LblSalesActivityThisMonth.TabIndex = 446
        Me.LblSalesActivityThisMonth.TabStop = False
        Me.LblSalesActivityThisMonth.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblSalesActivityThisMonth.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblSalesActivityThisYear
        '
        Me.LblSalesActivityThisYear.BackColor = System.Drawing.Color.Gold
        Me.LblSalesActivityThisYear.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblSalesActivityThisYear.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblSalesActivityThisYear.DecimalDigits = 2
        Me.LblSalesActivityThisYear.DefaultSendValue = False
        Me.LblSalesActivityThisYear.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblSalesActivityThisYear.FireTabAfterEnter = True
        Me.LblSalesActivityThisYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSalesActivityThisYear.Image = CType(resources.GetObject("LblSalesActivityThisYear.Image"), System.Drawing.Image)
        Me.LblSalesActivityThisYear.Location = New System.Drawing.Point(313, 130)
        Me.LblSalesActivityThisYear.Maxlength = 12
        Me.LblSalesActivityThisYear.MinusColor = System.Drawing.Color.Empty
        Me.LblSalesActivityThisYear.Name = "LblSalesActivityThisYear"
        Me.LblSalesActivityThisYear.ReadOnly = True
        Me.LblSalesActivityThisYear.Size = New System.Drawing.Size(76, 21)
        Me.LblSalesActivityThisYear.TabIndex = 445
        Me.LblSalesActivityThisYear.TabStop = False
        Me.LblSalesActivityThisYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblSalesActivityThisYear.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblNextPaymentAmount
        '
        Me.LblNextPaymentAmount.BackColor = System.Drawing.Color.Gold
        Me.LblNextPaymentAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblNextPaymentAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblNextPaymentAmount.DecimalDigits = 2
        Me.LblNextPaymentAmount.DefaultSendValue = False
        Me.LblNextPaymentAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblNextPaymentAmount.FireTabAfterEnter = True
        Me.LblNextPaymentAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblNextPaymentAmount.Image = CType(resources.GetObject("LblNextPaymentAmount.Image"), System.Drawing.Image)
        Me.LblNextPaymentAmount.Location = New System.Drawing.Point(79, 175)
        Me.LblNextPaymentAmount.Maxlength = 12
        Me.LblNextPaymentAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblNextPaymentAmount.Name = "LblNextPaymentAmount"
        Me.LblNextPaymentAmount.ReadOnly = True
        Me.LblNextPaymentAmount.Size = New System.Drawing.Size(76, 21)
        Me.LblNextPaymentAmount.TabIndex = 444
        Me.LblNextPaymentAmount.TabStop = False
        Me.LblNextPaymentAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblNextPaymentAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblSalesActivityAmount
        '
        Me.LblSalesActivityAmount.BackColor = System.Drawing.Color.Gold
        Me.LblSalesActivityAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblSalesActivityAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblSalesActivityAmount.DecimalDigits = 2
        Me.LblSalesActivityAmount.DefaultSendValue = False
        Me.LblSalesActivityAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblSalesActivityAmount.FireTabAfterEnter = True
        Me.LblSalesActivityAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSalesActivityAmount.Image = CType(resources.GetObject("LblSalesActivityAmount.Image"), System.Drawing.Image)
        Me.LblSalesActivityAmount.Location = New System.Drawing.Point(79, 130)
        Me.LblSalesActivityAmount.Maxlength = 12
        Me.LblSalesActivityAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblSalesActivityAmount.Name = "LblSalesActivityAmount"
        Me.LblSalesActivityAmount.ReadOnly = True
        Me.LblSalesActivityAmount.Size = New System.Drawing.Size(76, 21)
        Me.LblSalesActivityAmount.TabIndex = 443
        Me.LblSalesActivityAmount.TabStop = False
        Me.LblSalesActivityAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblSalesActivityAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'DteExpDate
        '
        Me.DteExpDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteExpDate.BorderColor = System.Drawing.Color.Empty
        Me.DteExpDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteExpDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteExpDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteExpDate.EditableSal = True
        Me.DteExpDate.Image = CType(resources.GetObject("DteExpDate.Image"), System.Drawing.Image)
        Me.DteExpDate.Location = New System.Drawing.Point(288, 51)
        Me.DteExpDate.MaxValue = CType(2500, Short)
        Me.DteExpDate.MinValue = CType(1800, Short)
        Me.DteExpDate.Name = "DteExpDate"
        Me.DteExpDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteExpDate.Sal_Mali = Nothing
        Me.DteExpDate.ShowButton = True
        Me.DteExpDate.Size = New System.Drawing.Size(102, 23)
        Me.DteExpDate.TabIndex = 5
        Me.DteExpDate.VisualStyle = False
        '
        'NumCreditLimit
        '
        Me.NumCreditLimit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCreditLimit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumCreditLimit.DecimalDigits = 2
        Me.NumCreditLimit.DefaultSendValue = False
        Me.NumCreditLimit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCreditLimit.FireTabAfterEnter = True
        Me.NumCreditLimit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCreditLimit.Image = CType(resources.GetObject("NumCreditLimit.Image"), System.Drawing.Image)
        Me.NumCreditLimit.Location = New System.Drawing.Point(81, 92)
        Me.NumCreditLimit.Maxlength = 10
        Me.NumCreditLimit.MinusColor = System.Drawing.Color.Empty
        Me.NumCreditLimit.Name = "NumCreditLimit"
        Me.NumCreditLimit.Size = New System.Drawing.Size(76, 21)
        Me.NumCreditLimit.TabIndex = 6
        Me.NumCreditLimit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCreditLimit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumScrapTireLicense
        '
        Me.NumScrapTireLicense.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumScrapTireLicense.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumScrapTireLicense.DecimalDigits = 0
        Me.NumScrapTireLicense.DefaultSendValue = False
        Me.NumScrapTireLicense.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumScrapTireLicense.FireTabAfterEnter = True
        Me.NumScrapTireLicense.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumScrapTireLicense.Image = CType(resources.GetObject("NumScrapTireLicense.Image"), System.Drawing.Image)
        Me.NumScrapTireLicense.Location = New System.Drawing.Point(287, 28)
        Me.NumScrapTireLicense.Maxlength = 10
        Me.NumScrapTireLicense.MinusColor = System.Drawing.Color.Empty
        Me.NumScrapTireLicense.Name = "NumScrapTireLicense"
        Me.NumScrapTireLicense.Size = New System.Drawing.Size(87, 21)
        Me.NumScrapTireLicense.TabIndex = 4
        Me.NumScrapTireLicense.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumScrapTireLicense.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'SocialSecurityNoNo1
        '
        Me.SocialSecurityNoNo1.BackColor = System.Drawing.SystemColors.Window
        Me.SocialSecurityNoNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SocialSecurityNoNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.SocialSecurityNoNo1.Location = New System.Drawing.Point(287, 6)
        Me.SocialSecurityNoNo1.Name = "SocialSecurityNoNo1"
        Me.SocialSecurityNoNo1.Size = New System.Drawing.Size(94, 16)
        Me.SocialSecurityNoNo1.TabIndex = 3
        '
        'btnNotes
        '
        Me.btnNotes.BackColor = System.Drawing.Color.YellowGreen
        Me.btnNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNotes.Location = New System.Drawing.Point(237, 174)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(74, 20)
        Me.btnNotes.TabIndex = 442
        Me.btnNotes.TabStop = False
        Me.btnNotes.Text = "Notes"
        '
        'txtDriverLicense
        '
        Me.txtDriverLicense.Location = New System.Drawing.Point(89, 5)
        Me.txtDriverLicense.MaxLength = 10
        Me.txtDriverLicense.Name = "txtDriverLicense"
        Me.txtDriverLicense.Size = New System.Drawing.Size(96, 21)
        Me.txtDriverLicense.TabIndex = 0
        Me.txtDriverLicense.Text = ""
        '
        'txtCreditCardNo
        '
        Me.txtCreditCardNo.Location = New System.Drawing.Point(89, 53)
        Me.txtCreditCardNo.MaxLength = 20
        Me.txtCreditCardNo.Name = "txtCreditCardNo"
        Me.txtCreditCardNo.Size = New System.Drawing.Size(114, 21)
        Me.txtCreditCardNo.TabIndex = 2
        Me.txtCreditCardNo.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(5, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 20)
        Me.Label15.TabIndex = 412
        Me.Label15.Text = "Driver's License"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(192, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 20)
        Me.Label16.TabIndex = 413
        Me.Label16.Text = "Social Security No"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblLastPaymentDate
        '
        Me.LblLastPaymentDate.BackColor = System.Drawing.Color.Gold
        Me.LblLastPaymentDate.Location = New System.Drawing.Point(156, 152)
        Me.LblLastPaymentDate.Name = "LblLastPaymentDate"
        Me.LblLastPaymentDate.ReadOnly = True
        Me.LblLastPaymentDate.Size = New System.Drawing.Size(79, 21)
        Me.LblLastPaymentDate.TabIndex = 429
        Me.LblLastPaymentDate.Text = ""
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(-2, 152)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 21)
        Me.Label28.TabIndex = 439
        Me.Label28.Text = "Last Payment"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSalesActivityDate
        '
        Me.LblSalesActivityDate.BackColor = System.Drawing.Color.Gold
        Me.LblSalesActivityDate.Location = New System.Drawing.Point(156, 130)
        Me.LblSalesActivityDate.Name = "LblSalesActivityDate"
        Me.LblSalesActivityDate.ReadOnly = True
        Me.LblSalesActivityDate.Size = New System.Drawing.Size(79, 21)
        Me.LblSalesActivityDate.TabIndex = 423
        Me.LblSalesActivityDate.Text = ""
        '
        'LblFinanceCharges
        '
        Me.LblFinanceCharges.BackColor = System.Drawing.Color.Gold
        Me.LblFinanceCharges.Location = New System.Drawing.Point(313, 175)
        Me.LblFinanceCharges.Name = "LblFinanceCharges"
        Me.LblFinanceCharges.ReadOnly = True
        Me.LblFinanceCharges.Size = New System.Drawing.Size(76, 21)
        Me.LblFinanceCharges.TabIndex = 433
        Me.LblFinanceCharges.Text = ""
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(304, 160)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 14)
        Me.Label30.TabIndex = 441
        Me.Label30.Text = "Finance Charges"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(5, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 20)
        Me.Label17.TabIndex = 414
        Me.Label17.Text = "Tax Excempt ID"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(-2, 130)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 20)
        Me.Label27.TabIndex = 438
        Me.Label27.Text = "Sales Activity"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(5, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 21)
        Me.Label18.TabIndex = 416
        Me.Label18.Text = "Credit Card No"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(43, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 20)
        Me.Label19.TabIndex = 422
        Me.Label19.Text = "Credit"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(-2, 175)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 19)
        Me.Label29.TabIndex = 440
        Me.Label29.Text = "Next Payment"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNextPaymentDate
        '
        Me.LblNextPaymentDate.BackColor = System.Drawing.Color.Gold
        Me.LblNextPaymentDate.Location = New System.Drawing.Point(156, 175)
        Me.LblNextPaymentDate.Name = "LblNextPaymentDate"
        Me.LblNextPaymentDate.ReadOnly = True
        Me.LblNextPaymentDate.Size = New System.Drawing.Size(79, 21)
        Me.LblNextPaymentDate.TabIndex = 432
        Me.LblNextPaymentDate.Text = ""
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(192, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 20)
        Me.Label24.TabIndex = 415
        Me.Label24.Text = "Scrap Tire License"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(179, 115)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(28, 16)
        Me.Label25.TabIndex = 435
        Me.Label25.Text = "Date"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(236, 115)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 16)
        Me.Label31.TabIndex = 436
        Me.Label31.Text = "This Month"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.Control
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label46.Location = New System.Drawing.Point(321, 115)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(53, 16)
        Me.Label46.TabIndex = 437
        Me.Label46.Text = "This Year"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(205, 51)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 21)
        Me.Label32.TabIndex = 418
        Me.Label32.Text = "Expiration Date"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkScrapTireLicense
        '
        Me.chkScrapTireLicense.BackColor = System.Drawing.SystemColors.Control
        Me.chkScrapTireLicense.Location = New System.Drawing.Point(375, 28)
        Me.chkScrapTireLicense.Name = "chkScrapTireLicense"
        Me.chkScrapTireLicense.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkScrapTireLicense.Size = New System.Drawing.Size(13, 20)
        Me.chkScrapTireLicense.TabIndex = 421
        Me.chkScrapTireLicense.Text = "CheckBox10"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(105, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 16)
        Me.Label20.TabIndex = 425
        Me.Label20.Text = "Limit"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(242, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 431
        Me.Label22.Text = "Remaining"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(177, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 16)
        Me.Label21.TabIndex = 428
        Me.Label21.Text = "Balance"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(91, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 16)
        Me.Label23.TabIndex = 434
        Me.Label23.Text = "Amount"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(588, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Disc %"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPriceLevel
        '
        Me.cmbPriceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbPriceLevel.Location = New System.Drawing.Point(486, 106)
        Me.cmbPriceLevel.Name = "cmbPriceLevel"
        Me.cmbPriceLevel.Size = New System.Drawing.Size(45, 21)
        Me.cmbPriceLevel.TabIndex = 15
        '
        'cmbSales_tax
        '
        Me.cmbSales_tax.DataSource = Me.DsFrmCustomer1.cust_sales_tax
        Me.cmbSales_tax.DisplayMember = "desc_sales_tax"
        Me.cmbSales_tax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSales_tax.Location = New System.Drawing.Point(470, 83)
        Me.cmbSales_tax.Name = "cmbSales_tax"
        Me.cmbSales_tax.Size = New System.Drawing.Size(125, 21)
        Me.cmbSales_tax.TabIndex = 14
        Me.cmbSales_tax.ValueMember = "cod_sales_tax"
        '
        'cmbAR_term
        '
        Me.cmbAR_term.DataSource = Me.DsFrmCustomer1.GL_TAB_AR_TERM
        Me.cmbAR_term.DisplayMember = "AR_terms"
        Me.cmbAR_term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAR_term.Location = New System.Drawing.Point(470, 58)
        Me.cmbAR_term.Name = "cmbAR_term"
        Me.cmbAR_term.Size = New System.Drawing.Size(125, 21)
        Me.cmbAR_term.TabIndex = 13
        Me.cmbAR_term.ValueMember = "AR_terms"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(3, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Company"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(203, 34)
        Me.txtMName.MaxLength = 15
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(48, 21)
        Me.txtMName.TabIndex = 3
        Me.txtMName.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(175, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 21)
        Me.Label2.TabIndex = 341
        Me.Label2.Text = "M.I."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(279, 34)
        Me.txtLName.MaxLength = 50
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(128, 21)
        Me.txtLName.TabIndex = 4
        Me.txtLName.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(247, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Last"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(76, 83)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 21)
        Me.txtAddress.TabIndex = 7
        Me.txtAddress.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(3, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 345
        Me.Label8.Text = "Address"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(76, 34)
        Me.txtFName.MaxLength = 20
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(104, 21)
        Me.txtFName.TabIndex = 2
        Me.txtFName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "FirstName"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(295, 107)
        Me.txtDriver.MaxLength = 25
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(106, 21)
        Me.txtDriver.TabIndex = 10
        Me.txtDriver.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(247, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 19)
        Me.Label11.TabIndex = 352
        Me.Label11.Text = "Driver"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(247, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 21)
        Me.Label9.TabIndex = 347
        Me.Label9.Text = "Phone"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(247, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 351
        Me.Label10.Text = "Email"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label
        '
        Me.label.BackColor = System.Drawing.SystemColors.Control
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label.Location = New System.Drawing.Point(425, 107)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(60, 19)
        Me.label.TabIndex = 359
        Me.label.Text = "Price Level"
        Me.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(411, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 19)
        Me.Label13.TabIndex = 355
        Me.Label13.Text = "Sales Tax"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(411, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 21)
        Me.Label14.TabIndex = 354
        Me.Label14.Text = "AR Terms"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtvip_code
        '
        Me.txtvip_code.BackColor = System.Drawing.SystemColors.Window
        Me.txtvip_code.Location = New System.Drawing.Point(238, 6)
        Me.txtvip_code.MaxLength = 10
        Me.txtvip_code.Name = "txtvip_code"
        Me.txtvip_code.Size = New System.Drawing.Size(56, 21)
        Me.txtvip_code.TabIndex = 1
        Me.txtvip_code.Text = ""
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(214, 6)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(22, 20)
        Me.Label26.TabIndex = 332
        Me.Label26.Text = "VIP"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCustomerCod
        '
        Me.TxtCustomerCod.Location = New System.Drawing.Point(62, 6)
        Me.TxtCustomerCod.MaxLength = 10
        Me.TxtCustomerCod.Name = "TxtCustomerCod"
        Me.TxtCustomerCod.Size = New System.Drawing.Size(106, 21)
        Me.TxtCustomerCod.TabIndex = 0
        Me.TxtCustomerCod.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "Customer"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSt
        '
        Me.TxtSt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSt.Location = New System.Drawing.Point(152, 106)
        Me.TxtSt.MaxLength = 20
        Me.TxtSt.Name = "TxtSt"
        Me.TxtSt.ReadOnly = True
        Me.TxtSt.Size = New System.Drawing.Size(33, 21)
        Me.TxtSt.TabIndex = 448
        Me.TxtSt.TabStop = False
        Me.TxtSt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtCity
        '
        Me.TxtCity.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtCity.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtCity.Location = New System.Drawing.Point(76, 106)
        Me.TxtCity.MaxLength = 50
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.ReadOnly = True
        Me.TxtCity.Size = New System.Drawing.Size(77, 21)
        Me.TxtCity.TabIndex = 11
        Me.TxtCity.TabStop = False
        Me.TxtCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(3, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 19)
        Me.Label12.TabIndex = 353
        Me.Label12.Text = "City. St. ZIP"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkTaxable
        '
        Me.ChkTaxable.BackColor = System.Drawing.SystemColors.Control
        Me.ChkTaxable.Checked = True
        Me.ChkTaxable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTaxable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTaxable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTaxable.Location = New System.Drawing.Point(592, 83)
        Me.ChkTaxable.Name = "ChkTaxable"
        Me.ChkTaxable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkTaxable.Size = New System.Drawing.Size(66, 21)
        Me.ChkTaxable.TabIndex = 17
        Me.ChkTaxable.Text = "Taxable"
        '
        'chkAR_charge
        '
        Me.chkAR_charge.BackColor = System.Drawing.SystemColors.Control
        Me.chkAR_charge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAR_charge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAR_charge.Location = New System.Drawing.Point(592, 58)
        Me.chkAR_charge.Name = "chkAR_charge"
        Me.chkAR_charge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkAR_charge.Size = New System.Drawing.Size(66, 22)
        Me.chkAR_charge.TabIndex = 16
        Me.chkAR_charge.Text = "Charge"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO cust_trtab_main (cod_customer, vip_code, cod_company, f_name, m_name," & _
        " l_name, address, phone_1, extension_1, phone_type_1, phone_main_1, phone_2, ext" & _
        "ension_2, phone_type_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_" & _
        "main_3, phone_4, extension_4, phone_type_4, phone_main_4, phone_5, extension_5, " & _
        "phone_type_5, phone_main_5, zip, email, cod_sales_rep, social_security_no, cust_" & _
        "exempt_tax, scrap_check, scrap_value, credit_card_no, expiration_credit_date, cr" & _
        "edit_limited, cod_sales_tax, cod_price, discount, cod_type, cod_source, cod_clas" & _
        "s, cod_territory, desc_sales_report, user_id, user_password, AR_statement, AR_se" & _
        "nd_copy, AR_finance_charge, AR_require_PO, AR_credit_hold, AR_accept_check, cust" & _
        "_notes, Taxable, inactive, customer_no, driver_name1, driver_name2, driver_name3" & _
        ", driver_name4, DriverLicense, AR_charge, AR_term, PrintStatementDetailFlag, Cus" & _
        "tomer_Birth_Date) VALUES (@cod_customer, @vip_code, @cod_company, @f_name, @m_na" & _
        "me, @l_name, @address, @phone_1, @extension_1, @phone_type_1, @phone_main_1, @ph" & _
        "one_2, @extension_2, @phone_type_2, @phone_main_2, @phone_3, @extension_3, @phon" & _
        "e_type_3, @phone_main_3, @phone_4, @extension_4, @phone_type_4, @phone_main_4, @" & _
        "phone_5, @extension_5, @phone_type_5, @phone_main_5, @zip, @email, @cod_sales_re" & _
        "p, @social_security_no, @cust_exempt_tax, @scrap_check, @scrap_value, @credit_ca" & _
        "rd_no, @expiration_credit_date, @credit_limited, @cod_sales_tax, @cod_price, @di" & _
        "scount, @cod_type, @cod_source, @cod_class, @cod_territory, @desc_sales_report, " & _
        "@user_id, @user_password, @AR_statement, @AR_send_copy, @AR_finance_charge, @AR_" & _
        "require_PO, @AR_credit_hold, @AR_accept_check, @cust_notes, @Taxable, @Inactive," & _
        " @Customer_No, @driver_name1, @driver_name2, @driver_name3, @driver_name4, @driv" & _
        "erLicense, @AR_charge, @AR_term, @PrintstatementDetailFlag, @Customer_Birth_Date" & _
        ")"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 4, "extension_1"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 4, "extension_2"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 4, "extension_3"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 4, "extension_4"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 4, "extension_5"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.BigInt, 8, "cust_exempt_tax"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Customer_No", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 10, "AR_term"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrintstatementDetailFlag", System.Data.SqlDbType.Bit, 1, "PrintStatementDetailFlag"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Customer_Birth_Date", System.Data.SqlDbType.VarChar, 10, "Customer_Birth_Date"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE cust_trtab_main SET vip_code = @vip_code, cod_company = @cod_company, f_na" & _
        "me = @f_name, m_name = @m_name, l_name = @l_name, address = @address, phone_1 = " & _
        "@phone_1, extension_1 = @extension_1, phone_type_1 = @phone_type_1, phone_main_1" & _
        " = @phone_main_1, phone_2 = @phone_2, extension_2 = @extension_2, phone_type_2 =" & _
        " @phone_type_2, phone_main_2 = @phone_main_2, phone_3 = @phone_3, extension_3 = " & _
        "@extension_3, phone_type_3 = @phone_type_3, phone_main_3 = @phone_main_3, phone_" & _
        "4 = @phone_4, extension_4 = @extension_4, phone_type_4 = @phone_type_4, phone_ma" & _
        "in_4 = @phone_main_4, phone_5 = @phone_5, extension_5 = @extension_5, phone_type" & _
        "_5 = @phone_type_5, phone_main_5 = @phone_main_5, zip = @zip, email = @email, co" & _
        "d_sales_rep = @cod_sales_rep, social_security_no = @social_security_no, cust_exe" & _
        "mpt_tax = @cust_exempt_tax, scrap_check = @scrap_check, scrap_value = @scrap_val" & _
        "ue, credit_card_no = @credit_card_no, expiration_credit_date = @expiration_credi" & _
        "t_date, credit_limited = @credit_limited, AR_charge = @AR_charge, AR_term = @AR_" & _
        "term, cod_sales_tax = @cod_sales_tax, cod_price = @cod_price, discount = @discou" & _
        "nt, cod_type = @cod_type, cod_source = @cod_source, cod_class = @cod_class, cod_" & _
        "territory = @cod_territory, desc_sales_report = @desc_sales_report, user_id = @u" & _
        "ser_id, user_password = @user_password, AR_statement = @AR_statement, AR_send_co" & _
        "py = @AR_send_copy, AR_finance_charge = @AR_finance_charge, AR_require_PO = @AR_" & _
        "require_PO, AR_credit_hold = @AR_credit_hold, AR_accept_check = @AR_accept_check" & _
        ", cust_notes = @cust_notes, Taxable = @Taxable, inactive = @Inactive, customer_n" & _
        "o = @Customer_No, driver_name1 = @driver_name1, driver_name2 = @driver_name2, dr" & _
        "iver_name3 = @driver_name3, driver_name4 = @driver_name4, DriverLicense = @drive" & _
        "rLicense, PrintStatementDetailFlag = @PrintstatementDetailFlag, Customer_Birth_D" & _
        "ate = @Customer_Birth_Date WHERE (cod_customer = @cod_Customer)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 4, "extension_1"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 4, "extension_2"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 4, "extension_3"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 4, "extension_4"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 4, "extension_5"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.BigInt, 4, "cust_exempt_tax"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 10, "AR_term"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Customer_No", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrintstatementDetailFlag", System.Data.SqlDbType.Bit, 1, "PrintStatementDetailFlag"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Customer_Birth_Date", System.Data.SqlDbType.VarChar, 10, "Customer_Birth_Date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_Customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
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
        Me.Panel9.Size = New System.Drawing.Size(669, 45)
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
        Me.BtnSortOrder.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnSortOrder.Image = CType(resources.GetObject("BtnSortOrder.Image"), System.Drawing.Image)
        Me.BtnSortOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSortOrder.Location = New System.Drawing.Point(497, 2)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 27)
        Me.BtnSortOrder.TabIndex = 195
        '
        'UiContextMenu1
        '
        Me.UiContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UiContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort11, Me.Sort21, Me.Sort31})
        Me.UiContextMenu1.Key = "ContextMenu1"
        Me.UiContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UiContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort1, Me.Sort2, Me.Sort3})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("96d93b63-443d-453c-8d08-90e913be349e")
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
        Me.Sort1.Text = "Order By Customer Code"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Company Name"
        '
        'Sort3
        '
        Me.Sort3.Key = "Sort3"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Order By Customer Last Name"
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
        Me.Label51.Location = New System.Drawing.Point(342, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 10)
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_sales_tax, desc_sales_tax FROM cust_sales_tax"
        Me.SqlSelectCommand1.Connection = Me.CnnTemp
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cust_sales_tax(cod_sales_tax, desc_sales_tax) VALUES (@cod_sales_tax," & _
        " @desc_sales_tax); SELECT cod_sales_tax, desc_sales_tax FROM cust_sales_tax WHER" & _
        "E (cod_sales_tax = @cod_sales_tax)"
        Me.SqlInsertCommand1.Connection = Me.CnnTemp
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_tax", System.Data.SqlDbType.VarChar, 50, "desc_sales_tax"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cust_sales_tax SET cod_sales_tax = @cod_sales_tax, desc_sales_tax = @desc_" & _
        "sales_tax WHERE (cod_sales_tax = @Original_cod_sales_tax) AND (desc_sales_tax = " & _
        "@Original_desc_sales_tax OR @Original_desc_sales_tax IS NULL AND desc_sales_tax " & _
        "IS NULL); SELECT cod_sales_tax, desc_sales_tax FROM cust_sales_tax WHERE (cod_sa" & _
        "les_tax = @cod_sales_tax)"
        Me.SqlUpdateCommand1.Connection = Me.CnnTemp
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_tax", System.Data.SqlDbType.VarChar, 50, "desc_sales_tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_tax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cust_sales_tax WHERE (cod_sales_tax = @Original_cod_sales_tax) AND (d" & _
        "esc_sales_tax = @Original_desc_sales_tax OR @Original_desc_sales_tax IS NULL AND" & _
        " desc_sales_tax IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.CnnTemp
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_tax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'DACust_sales_tax
        '
        Me.DACust_sales_tax.DeleteCommand = Me.SqlDeleteCommand1
        Me.DACust_sales_tax.InsertCommand = Me.SqlInsertCommand1
        Me.DACust_sales_tax.SelectCommand = Me.SqlSelectCommand1
        Me.DACust_sales_tax.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_sales_tax", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("desc_sales_tax", "desc_sales_tax")})})
        Me.DACust_sales_tax.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DAcust_tab_source
        '
        Me.DAcust_tab_source.SelectCommand = Me.SqlSelectCommand3
        Me.DAcust_tab_source.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_source", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("desc_source", "desc_source")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_source, desc_source FROM cust_tab_source"
        Me.SqlSelectCommand3.Connection = Me.Cnn
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
        'DAcust_tab_territory
        '
        Me.DAcust_tab_territory.SelectCommand = Me.SqlSelectCommand6
        Me.DAcust_tab_territory.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_territory", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_territory", "desc_territory")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_territory, desc_territory FROM cust_tab_territory"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DAcust_tab_class
        '
        Me.DAcust_tab_class.SelectCommand = Me.SqlSelectCommand5
        Me.DAcust_tab_class.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_class, desc_class FROM cust_tab_class"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAcust_trtab_main
        '
        Me.DAcust_trtab_main.SelectCommand = Me.SqlCommand1
        Me.DAcust_trtab_main.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_main", "phone_main"), New System.Data.Common.DataColumnMapping("phone_work", "phone_work"), New System.Data.Common.DataColumnMapping("phone_cell", "phone_cell"), New System.Data.Common.DataColumnMapping("phone_other", "phone_other"), New System.Data.Common.DataColumnMapping("cod_city", "cod_city"), New System.Data.Common.DataColumnMapping("st", "st"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT cust_trtab_main.*, cust_company.complete_name FROM cust_trtab_main INNER J" & _
        "OIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHERE" & _
        " (cust_trtab_main.cod_customer = @cod_customer)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAcust_tab_type
        '
        Me.DAcust_tab_type.SelectCommand = Me.SqlSelectCommand2
        Me.DAcust_tab_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("desc_type", "desc_type")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_type, desc_type FROM cust_tab_type"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT AR_terms FROM GL_TAB_AR_TERM"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        '
        'FrmCustomer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(669, 402)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmCustomer"
        Me.Text = "Customer"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsFrmCustomer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CustomerCod1.CanAddNewCod = False
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = " ALTER TABLE service_out_purchases ALTER COLUMN cust_exempt_tax varchar(30) "
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Call FillDataSets()
        TxtCustomerCod.MaxLength = LenCustomerCod

        If Cod_customerVar.Trim.Length > 0 Then
            Call PAddNew()
            TxtCustomerCod.Text = Cod_customerVar
            TxtCustomerCod.Focus()
        Else
            If CustomerCodTempVar.Trim.Length = 0 Then
                Call PFirstRecord(False)
            Else
                CustomerCod1.Text = CustomerCodTempVar
                '''''''''''''Call FillFields(CustomerCod1.Text)
            End If
            Call AfterSaveOrCancel()
            CustomerCod1.Focus()
        End If
    End Sub
    Private Sub FillDataSets()
        DsFrmCustomer1.cust_sales_tax.Clear()
        DACust_sales_tax.Fill(DsFrmCustomer1, "cust_sales_tax")
        If DsFrmCustomer1.cust_sales_tax.Rows.Count < 1 Then
            MsgFar("Please Fill The Sales Tax Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmCustomer1.GL_TAB_AR_TERM.Clear()
        DsFrmCustomer1.GL_TAB_AR_TERM.AddGL_TAB_AR_TERMRow("")
        DAGL_TAB_AR_TERM.Fill(DsFrmCustomer1, "GL_TAB_AR_TERM")
        If DsFrmCustomer1.GL_TAB_AR_TERM.Rows.Count < 1 Then
            MsgFar("Please Fill The AR Terms Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmCustomer1.cust_tab_class.Clear()
        DAcust_tab_class.Fill(DsFrmCustomer1, "cust_tab_class")
        If DsFrmCustomer1.cust_tab_class.Rows.Count < 1 Then
            MsgFar("Please Fill The Customer Class Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmCustomer1.cust_tab_source.Clear()
        DAcust_tab_source.Fill(DsFrmCustomer1, "cust_tab_source")
        If DsFrmCustomer1.cust_tab_source.Rows.Count < 1 Then
            MsgFar("Please Fill The Source Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmCustomer1.cust_tab_territory.Clear()
        DAcust_tab_territory.Fill(DsFrmCustomer1, "cust_tab_territory")
        If DsFrmCustomer1.cust_tab_territory.Rows.Count < 1 Then
            MsgFar("Please Fill The Territory Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmCustomer1.cust_tab_type.Clear()
        DAcust_tab_type.Fill(DsFrmCustomer1, "cust_tab_type")
        If DsFrmCustomer1.cust_tab_type.Rows.Count < 1 Then
            MsgFar("Please Fill The Customer Type Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmCustomer1.employee.Clear()
        DAEmployee.Fill(DsFrmCustomer1, "Employee")
        'If DsFrmCustomer1.employee.Rows.Count < 1 Then
        '    MsgFar("Please Fill The Employee Table")
        '    Call DisableAllComponet(Me)
        '    Exit Sub
        'End If

    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        CustomerCodTempVar = CustomerCod1.Text
        CustomerCod1.Text = ""
        Call ClearField()

        TxtCustomerCod.Text = MakeNewCustomerCod()
        TxtCustomerCod.Focus()

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
        CustomerCodTempVar = CustomerCod1.Text
        TxtCustomerCod.Focus()

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
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdDelete.Connection.State <> ConnectionState.Open Then
                    CmdDelete.Connection.Open()
                End If
                CmdDelete.Parameters("@Cod_Customer").Value = CustomerCod1.Text
                CmdDelete.ExecuteNonQuery()
                CustomerCodTempVar = ""
                Call PNextRecord(False)
                If CustomerCodTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If CustomerCodTempVar.Trim.Length = 0 Then
                        Call ClearField()
                    End If
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            Finally
                CmdDelete.Connection.Close()
            End Try
            Call AfterSaveOrCancel()
        Else
            CustomerCod1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        If Not chkAR_charge.Checked Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Count(*) FROM GL_payment_deposit INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center WHERE payment_type = '4' AND Refer_Type='1' AND cod_customer= " & Qt(TxtCustomerCod.Text)
            If CmdGeneral.ExecuteScalar() > 0 Then
                'MsgFar("Customer has current AR Transaction , therefore" + vbCrLf + "changing it to CASH BASIS is not Allowed." + vbCrLf + "You may use CREDIT HOLD for not allowing " + vbCrLf + "any more charges to Account Receivable.", MsgBoxStyle.Critical)
                MsgFar("Customer has current AR Transaction , therefore changing it to CASH BASIS is not Allowed.You may use CREDIT HOLD for not allowing any more charges to Account Receivable.")
                Exit Sub
            End If
        End If
        If ChkTaxable.Checked And cmbSales_tax.Text.Trim.Length = 0 Then
            MsgBox("Please set Sales Tax")
            Exit Sub
        End If
        If chkAR_charge.Checked And cmbAR_term.Text.Trim.Length = 0 Then
            MsgBox("Please set AR Terms")
            Exit Sub
        End If
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                CustomerCodTempVar = PInsert()
                ChangeOK = IIf(CustomerCodTempVar.Trim.Length = 0, False, True)
                If Cod_customerVar.Trim.Length > 0 Then
                    Cod_customerVar = TxtCustomerCod.Text
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(CustomerCodTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            CustomerCod1.Text = CustomerCodTempVar
            CustomerCod1.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CustomerCod1.Text = CustomerCodTempVar
        '''''''''''''Call FillFields(CustomerCod1.Text)
        Call AfterSaveOrCancel()
        CustomerCod1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtCustomerCod.Text.Trim.Length = 0 Then
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
    Private Sub TXTCustomerCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCod.TextChanged, txtAddress.TextChanged, txtCreditCardNo.TextChanged, TxtCustomerNo.TextChanged, txtDriver.TextChanged, txtMName.TextChanged, txtPassword.TextChanged, txtUserID.TextChanged, txtvip_code.TextChanged, ZipCode1.TextChanged, SocialSecurityNoNo1.TextChanged, cmbAR_term.SelectedIndexChanged, cmbClass.SelectedIndexChanged, cmbPriceLevel.SelectedIndexChanged, cmbSaleRep.SelectedIndexChanged, cmbSales_tax.SelectedIndexChanged, cmbSource.SelectedIndexChanged, cmbTerritory.SelectedIndexChanged, cmbType.SelectedIndexChanged, NumDiscount.TextChanged, chkAcceptCheck.CheckedChanged, chkCreditHold.CheckedChanged, chkFinCharge.CheckedChanged, chkInactive.CheckedChanged, chkRequirePO.CheckedChanged, chkScrapTireLicense.CheckedChanged, chkSendCopies.CheckedChanged, chkStatement.CheckedChanged, ChkTaxable.CheckedChanged, CompanyName1.TextChanged, NumScrapTireLicense.TextChanged, NumCreditLimit.TextChanged, txtDriverLicense.TextChanged, ChkPrintstatementDetailFlag.CheckedChanged, DteCustomer_Birth_Date.Leave, DteCustomer_Birth_Date.Leave, NumTaxExemptID.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub TxtFName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFName.TextChanged, txtLName.TextChanged
        Call SaveButtonControl()
        If txtDriver.Text.Trim.Length = 0 Or txtDriver.Text.Trim = txtDriver.Text.Trim Then
            txtDriver.Text = txtFName.Text.Trim & " " & txtLName.Text.Trim
        End If
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            'If TxtCustomerCod.Text.Trim.Length > 0 And txtFName.Text.Trim.Length > 0 And txtLName.Text.Trim.Length > 0 And (Not chkScrapTireLicense.Checked Or Val(NumScrapTireLicense.Text) > 0) And cmbPriceLevel.Text.Trim.Length > 0 Then
            If TxtCustomerCod.Text.Trim.Length > 0 And ((txtFName.Text.Trim.Length > 0 And txtLName.Text.Trim.Length > 0) Or (CompanyName1.Text.Trim.Length > 0)) And (Not chkScrapTireLicense.Checked Or Val(NumScrapTireLicense.Text) > 0) And cmbPriceLevel.Text.Trim.Length > 0 Then
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
        Try
            Dim TXTSearchCustomerCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main Order BY " & CustomerOrderFieldName & " ASC"
            TXTSearchCustomerCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchCustomerCodTemp) Then
                TXTSearchCustomerCodTemp = ""
            End If
            If TXTSearchCustomerCodTemp = CustomerCod1.Text Or TXTSearchCustomerCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                CustomerCod1.Text = TXTSearchCustomerCodTemp
                '''''''''''''Call FillFields(CustomerCod1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchCustomerCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case CustomerOrderFieldName.ToUpper.Trim
            Case "Cod_Customer".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main where Cod_Customer<" & Qt(TxtCustomerCod.Text) & " Order BY " & CustomerOrderFieldName & " DESC"
            Case "cod_company".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main where cod_company<" & Qt(CompanyName1.CompanyCod) & " Order BY " & CustomerOrderFieldName & " DESC"
            Case "l_name".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main where l_name<" & Qt(txtLName.Text) & " Order BY " & CustomerOrderFieldName & " DESC"
        End Select
        TXTSearchCustomerCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchCustomerCodTemp) Then
            TXTSearchCustomerCodTemp = ""
        End If
        If TXTSearchCustomerCodTemp = CustomerCod1.Text Or TXTSearchCustomerCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CustomerCod1.Text = TXTSearchCustomerCodTemp
            CustomerCodTempVar = TXTSearchCustomerCodTemp
            '''''''''''''Call FillFields(CustomerCod1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchCustomerCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case CustomerOrderFieldName.ToUpper.Trim
            Case "Cod_Customer".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main where Cod_Customer>" & Qt(TxtCustomerCod.Text) & " Order BY " & CustomerOrderFieldName & " ASC"
            Case "cod_company".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main where cod_company>" & Qt(CompanyName1.CompanyCod) & " Order BY " & CustomerOrderFieldName & " ASC"
            Case "l_name".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main where l_name>" & Qt(txtLName.Text) & " Order BY " & CustomerOrderFieldName & " ASC"
        End Select
        TXTSearchCustomerCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchCustomerCodTemp) Then
            TXTSearchCustomerCodTemp = ""
        End If
        If TXTSearchCustomerCodTemp = CustomerCod1.Text Or TXTSearchCustomerCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CustomerCod1.Text = TXTSearchCustomerCodTemp
            CustomerCodTempVar = TXTSearchCustomerCodTemp
            '''''''''''''Call FillFields(CustomerCod1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchCustomerCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Cod_Customer from cust_trtab_main Order BY " & CustomerOrderFieldName & " DESC"
            TXTSearchCustomerCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchCustomerCodTemp) Then
                TXTSearchCustomerCodTemp = ""
            End If
            If TXTSearchCustomerCodTemp = CustomerCod1.Text Or TXTSearchCustomerCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                CustomerCod1.Text = TXTSearchCustomerCodTemp
                '''''''''''''Call FillFields(CustomerCod1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        Call FillFields(CustomerCod1.Text)
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
            CustomerCod1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmCustomer_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        CustomerCod1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If CustomerCod1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@Cod_Customer").Value = CustomerCod1.text
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
            TxtCustomerCod.Enabled = instatus
        Else
            TxtCustomerCod.Enabled = False
        End If
        CompanyName1.Enabled = instatus
        txtAddress.Enabled = instatus
        txtCreditCardNo.Enabled = instatus
        NumCreditLimit.Enabled = instatus
        TxtCustomerNo.Enabled = instatus
        txtDriver.Enabled = instatus
        txtEmail.Enabled = instatus
        DteExpDate.Enabled = instatus
        DteCustomer_Birth_Date.Enabled = instatus
        txtFName.Enabled = instatus
        txtDriverLicense.Enabled = instatus
        txtLName.Enabled = instatus
        txtMName.Enabled = instatus
        txtPassword.Enabled = instatus
        NumScrapTireLicense.Enabled = instatus
        SocialSecurityNoNo1.Enabled = instatus
        NumTaxExemptID.Enabled = instatus
        txtUserID.Enabled = instatus
        txtvip_code.Enabled = instatus
        NumDiscount.Enabled = instatus
        cmbAR_term.Enabled = instatus
        cmbClass.Enabled = instatus
        cmbPriceLevel.Enabled = instatus
        cmbSaleRep.Enabled = instatus
        cmbSales_tax.Enabled = instatus
        cmbSource.Enabled = instatus
        cmbTerritory.Enabled = instatus
        cmbType.Enabled = instatus
        chkAcceptCheck.Enabled = instatus
        chkAR_charge.Enabled = instatus
        chkCreditHold.Enabled = instatus
        chkFinCharge.Enabled = instatus
        ChkPrintstatementDetailFlag.Enabled = instatus
        chkInactive.Enabled = instatus
        chkRequirePO.Enabled = instatus
        chkScrapTireLicense.Enabled = instatus
        chkSendCopies.Enabled = instatus
        chkStatement.Enabled = instatus
        ChkTaxable.Enabled = instatus
        ZipCode1.Enabled = instatus
        PhoneNoMain.Enabled = instatus
        PhoneButton1.ZEnabled = instatus
    End Sub
    Friend Sub ClearField()
        CustomerNoteVar = ""
        btnNotes.ForeColor = Color.Black

        CompanyName1.Text = ""
        CompanyName1.CompanyCod = ""
        TxtCustomerNo.Text = ""
        TxtCustomerCod.Text = ""
        txtAddress.Text = ""
        txtCreditCardNo.Text = ""
        NumCreditLimit.Text = ""
        NumDiscount.Text = ""
        txtDriver.Text = ""
        MyFrmDriverName.txtdriver_name1.Text = ""
        MyFrmDriverName.txtdriver_name2.Text = ""
        MyFrmDriverName.txtdriver_name3.Text = ""
        MyFrmDriverName.txtdriver_name4.Text = ""
        txtEmail.Text = ""
        DteExpDate.Text = ""
        DteCustomer_Birth_Date.Text = ""
        txtFName.Text = ""
        txtDriverLicense.Text = ""
        txtLName.Text = ""
        txtMName.Text = ""
        txtPassword.Text = ""
        NumScrapTireLicense.Text = 0
        SocialSecurityNoNo1.Text = ""
        NumTaxExemptID.Text = ""
        txtUserID.Text = ""
        txtvip_code.Text = ""
        'cmbAR_term.SelectedValue = "0"

        chkAcceptCheck.Checked = True
        chkCreditHold.Checked = False
        '''chkFinCharge.Checked = False
        ChkPrintstatementDetailFlag.Checked = True
        chkInactive.Checked = False
        chkRequirePO.Checked = False
        chkScrapTireLicense.Checked = False
        chkSendCopies.Checked = False
        '''chkStatement.Checked = False
        ZipCode1.Text = ""
        PhoneNoMain.Text = ""
        Call PhoneButton1.ClearPhoneScreen()

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        Try
            AreaCodVar = OleDbReaderForStore.Item("AREACODE") & ""
        Catch ex As Exception
            AreaCodVar = ""
        End Try
        Try
            cmbSales_tax.SelectedValue = OleDbReaderForStore.Item("SALES_TAX") & ""
        Catch ex As Exception
        End Try
        Try
            cmbSaleRep.SelectedValue = OleDbReaderForStore.Item("SALESPERSON") & ""
        Catch ex As Exception
        End Try
        OleDbReaderForStore.Close()

        Dim OleDbReaderForAccountsReceivable As System.Data.OleDb.OleDbDataReader
        OleDbReaderForAccountsReceivable = RetrieveAccountsReceivableSetupTable()
        Try
            cmbAR_term.SelectedValue = OleDbReaderForAccountsReceivable.Item("Default_AR_terms")
        Catch ex As Exception
            cmbAR_term.Text = ""
        End Try
        chkStatement.Checked = OleDbReaderForAccountsReceivable.Item("Default_statements")
        chkSendCopies.Checked = OleDbReaderForAccountsReceivable.Item("Default_SEND_COPY")
        chkFinCharge.Checked = OleDbReaderForAccountsReceivable.Item("Default_FIN_CHARGE")
        OleDbReaderForAccountsReceivable.Close()

        OleDbReaderForStore = RetrieveServiceSetupTable(PubStoreNO)
        Try
            cmbType.SelectedValue = OleDbReaderForStore.Item("CUSTOMER_TYPE") & ""
        Catch ex As Exception
        End Try
        Try
            cmbSource.SelectedValue = OleDbReaderForStore.Item("CUSTOMER_SOURCE") & ""
        Catch ex As Exception
        End Try
        Try
            cmbClass.SelectedValue = OleDbReaderForStore.Item("CUSTOMER_CLASS") & ""
        Catch ex As Exception
        End Try
        Try
            cmbTerritory.SelectedValue = OleDbReaderForStore.Item("CUSTOMER_TERRITORY") & ""
        Catch ex As Exception
        End Try
        Try
            cmbPriceLevel.Text = OleDbReaderForStore.Item("CUSTOMER_PRICE_LEVEL") & ""  ' 1
        Catch ex As Exception
        End Try
        ChkTaxable.Checked = OleDbReaderForStore.Item("CUSTOMER_TAXABLE") ' True
        chkAcceptCheck.Checked = OleDbReaderForStore.Item("CUSTOMER_ACCEPT_CHECK") ' False
        chkAR_charge.Checked = OleDbReaderForStore.Item("CUSTOMER_CHARGE") ' False
        chkFinCharge.Checked = chkAR_charge.Checked
        chkStatement.Checked = chkAR_charge.Checked
        chkAR_charge.Checked = OleDbReaderForStore.Item("CUSTOMER_CHARGE") ' False
        ChkPrintstatementDetailFlag.Checked = True

        Call ChkAR_chargeDisableEnableAndShowDefaults()

        LblCreditBalance.Text = ""
        LblCreditRemaining.Text = ""
        LblCustmerSince.Text = ""
        LblFinanceCharges.Text = ""
        LblLastPaymentAmount.Text = ""
        LblLastPaymentDate.Text = ""
        LblLastVisit.Text = ""
        LblNextPaymentAmount.Text = ""
        LblNextPaymentDate.Text = ""
        LblSalesActivityAmount.Text = ""
        LblSalesActivityDate.Text = ""
        LblSalesActivityThisMonth.Text = ""
        LblSalesActivityThisYear.Text = ""

    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            Call AddNewCompany()
            With CmdInsert
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@cod_customer").Value = TxtCustomerCod.Text
                .Parameters("@vip_code").Value = txtvip_code.Text
                .Parameters("@cod_company").Value = IIf(Trim(CompanyName1.CompanyCod).Length = 0, System.DBNull.Value, CompanyName1.CompanyCod)
                .Parameters("@Customer_No").Value = TxtCustomerNo.Text
                .Parameters("@f_name").Value = txtFName.Text
                .Parameters("@m_name").Value = txtMName.Text
                .Parameters("@l_name").Value = txtLName.Text
                .Parameters("@address").Value = txtAddress.Text
                .Parameters("@phone_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_1")
                .Parameters("@extension_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_1")
                .Parameters("@phone_type_1").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_1"))
                .Parameters("@phone_main_1").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_1"))
                .Parameters("@phone_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_2")
                .Parameters("@extension_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_2")
                .Parameters("@phone_type_2").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_2"))
                .Parameters("@phone_main_2").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_2"))
                .Parameters("@phone_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_3")
                .Parameters("@extension_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_3")
                .Parameters("@phone_type_3").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_3"))
                .Parameters("@phone_main_3").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_3"))
                .Parameters("@phone_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_4")
                .Parameters("@extension_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_4")
                .Parameters("@phone_type_4").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_4"))
                .Parameters("@phone_main_4").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_4"))
                .Parameters("@phone_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_5")
                .Parameters("@extension_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_5")
                .Parameters("@phone_type_5").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_5"))
                .Parameters("@phone_main_5").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_5"))
                .Parameters("@driver_name1").Value = txtDriver.Text
                .Parameters("@driver_name2").Value = MyFrmDriverName.txtdriver_name2.Text
                .Parameters("@driver_name3").Value = MyFrmDriverName.txtdriver_name3.Text
                .Parameters("@driver_name4").Value = MyFrmDriverName.txtdriver_name4.Text
                .Parameters("@DriverLicense").Value = txtDriverLicense.Text
                .Parameters("@zip").Value = IIf(ZipCode1.Text.Trim.Length > 0, ZipCode1.Text, System.DBNull.Value)
                .Parameters("@email").Value = txtEmail.Text
                .Parameters("@social_security_no").Value = SocialSecurityNoNo1.Text
                .Parameters("@cust_exempt_tax").Value = Val(NumTaxExemptID.Text)
                .Parameters("@scrap_value").Value = NumScrapTireLicense.Text
                .Parameters("@credit_card_no").Value = txtCreditCardNo.Text
                .Parameters("@expiration_credit_date").Value = DteExpDate.Text
                .Parameters("@Customer_Birth_Date").Value = DteCustomer_Birth_Date.Text
                .Parameters("@credit_limited").Value = NumCreditLimit.Text
                .Parameters("@discount").Value = NumDiscount.Text
                .Parameters("@AR_term").Value = ChkCombo(cmbAR_term.SelectedValue)
                .Parameters("@cod_sales_tax").Value = ChkCombo(cmbSales_tax.SelectedValue)
                .Parameters("@cod_price").Value = ChkCombo(cmbPriceLevel.Text)
                .Parameters("@cod_type").Value = ChkCombo(cmbType.SelectedValue)
                .Parameters("@cod_source").Value = ChkCombo(cmbSource.SelectedValue)
                .Parameters("@cod_class").Value = ChkCombo(cmbClass.SelectedValue)
                .Parameters("@cod_territory").Value = ChkCombo(cmbTerritory.SelectedValue)
                .Parameters("@cod_sales_rep").Value = ChkCombo(cmbSaleRep.SelectedValue)
                ' ********************************************** '
                .Parameters("@desc_sales_report").Value = ""
                ' ********************************************** '
                .Parameters("@user_id").Value = txtUserID.Text
                .Parameters("@user_password").Value = txtPassword.Text
                .Parameters("@scrap_check").Value = DecodeCheckBox(chkScrapTireLicense.Checked)
                .Parameters("@AR_charge").Value = DecodeCheckBox(chkAR_charge.Checked)
                .Parameters("@AR_statement").Value = DecodeCheckBox(chkStatement.Checked)
                .Parameters("@AR_send_copy").Value = DecodeCheckBox(chkSendCopies.Checked)
                .Parameters("@AR_finance_charge").Value = DecodeCheckBox(chkFinCharge.Checked)
                .Parameters("@PrintstatementDetailFlag").Value = DecodeCheckBox(ChkPrintstatementDetailFlag.Checked)
                .Parameters("@AR_require_PO").Value = DecodeCheckBox(chkRequirePO.Checked)
                .Parameters("@AR_credit_hold").Value = DecodeCheckBox(chkCreditHold.Checked)
                .Parameters("@AR_accept_check").Value = DecodeCheckBox(chkAcceptCheck.Checked)
                .Parameters("@Taxable").Value = DecodeCheckBox(ChkTaxable.Checked)
                .Parameters("@Inactive").Value = DecodeCheckBox(chkInactive.Checked)
                .Parameters("@cust_notes").Value = CustomerNoteVar
                .ExecuteNonQuery()
                PInsert = TxtCustomerCod.Text
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisCod_Customer As String) As Boolean
        PUpdate = True
        Try
            Call AddNewCompany()
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@cod_customer").Value = TxtCustomerCod.Text
                .Parameters("@vip_code").Value = txtvip_code.Text
                .Parameters("@cod_company").Value = IIf(Trim(CompanyName1.CompanyCod).Length = 0, System.DBNull.Value, CompanyName1.CompanyCod)
                .Parameters("@Customer_No").Value = TxtCustomerNo.Text
                .Parameters("@f_name").Value = txtFName.Text
                .Parameters("@m_name").Value = txtMName.Text
                .Parameters("@l_name").Value = txtLName.Text
                .Parameters("@address").Value = txtAddress.Text
                .Parameters("@phone_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_1")
                .Parameters("@extension_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_1")
                .Parameters("@phone_type_1").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_1"))
                .Parameters("@phone_main_1").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_1"))
                .Parameters("@phone_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_2")
                .Parameters("@extension_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_2")
                .Parameters("@phone_type_2").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_2"))
                .Parameters("@phone_main_2").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_2"))
                .Parameters("@phone_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_3")
                .Parameters("@extension_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_3")
                .Parameters("@phone_type_3").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_3"))
                .Parameters("@phone_main_3").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_3"))
                .Parameters("@phone_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_4")
                .Parameters("@extension_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_4")
                .Parameters("@phone_type_4").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_4"))
                .Parameters("@phone_main_4").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_4"))
                .Parameters("@phone_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_5")
                .Parameters("@extension_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_5")
                .Parameters("@phone_type_5").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_5"))
                .Parameters("@phone_main_5").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_5"))
                .Parameters("@driver_name1").Value = txtDriver.Text
                .Parameters("@driver_name2").Value = MyFrmDriverName.txtdriver_name2.Text
                .Parameters("@driver_name3").Value = MyFrmDriverName.txtdriver_name3.Text
                .Parameters("@driver_name4").Value = MyFrmDriverName.txtdriver_name4.Text
                .Parameters("@DriverLicense").Value = txtDriverLicense.Text
                .Parameters("@zip").Value = IIf(ZipCode1.Text.Trim.Length > 0, ZipCode1.Text, System.DBNull.Value)
                .Parameters("@email").Value = txtEmail.Text
                .Parameters("@social_security_no").Value = SocialSecurityNoNo1.Text
                .Parameters("@cust_exempt_tax").Value = NumTaxExemptID.Text
                .Parameters("@scrap_value").Value = NumScrapTireLicense.Text
                .Parameters("@credit_card_no").Value = txtCreditCardNo.Text
                .Parameters("@expiration_credit_date").Value = DteExpDate.Text
                .Parameters("@Customer_Birth_Date").Value = DteCustomer_Birth_Date.Text
                .Parameters("@credit_limited").Value = NumCreditLimit.Text
                .Parameters("@discount").Value = NumDiscount.Text
                .Parameters("@AR_term").Value = ChkCombo(cmbAR_term.SelectedValue)
                .Parameters("@cod_sales_tax").Value = ChkCombo(cmbSales_tax.SelectedValue)
                .Parameters("@cod_price").Value = ChkCombo(cmbPriceLevel.Text)
                .Parameters("@cod_type").Value = ChkCombo(cmbType.SelectedValue)
                .Parameters("@cod_source").Value = ChkCombo(cmbSource.SelectedValue)
                .Parameters("@cod_class").Value = ChkCombo(cmbClass.SelectedValue)
                .Parameters("@cod_territory").Value = ChkCombo(cmbTerritory.SelectedValue)
                .Parameters("@cod_sales_rep").Value = ChkCombo(cmbSaleRep.SelectedValue)
                ' ********************************************** '
                .Parameters("@desc_sales_report").Value = ""
                ' ********************************************** '
                .Parameters("@user_id").Value = txtUserID.Text
                .Parameters("@user_password").Value = txtPassword.Text
                .Parameters("@scrap_check").Value = DecodeCheckBox(chkScrapTireLicense.Checked)
                .Parameters("@AR_charge").Value = DecodeCheckBox(chkAR_charge.Checked)
                .Parameters("@AR_statement").Value = DecodeCheckBox(chkStatement.Checked)
                .Parameters("@AR_send_copy").Value = DecodeCheckBox(chkSendCopies.Checked)
                .Parameters("@AR_finance_charge").Value = DecodeCheckBox(chkFinCharge.Checked)
                .Parameters("@PrintstatementDetailFlag").Value = DecodeCheckBox(ChkPrintstatementDetailFlag.Checked)
                .Parameters("@AR_require_PO").Value = DecodeCheckBox(chkRequirePO.Checked)
                .Parameters("@AR_credit_hold").Value = DecodeCheckBox(chkCreditHold.Checked)
                .Parameters("@AR_accept_check").Value = DecodeCheckBox(chkAcceptCheck.Checked)
                .Parameters("@Taxable").Value = DecodeCheckBox(ChkTaxable.Checked)
                .Parameters("@Inactive").Value = DecodeCheckBox(chkInactive.Checked)
                .Parameters("@cust_notes").Value = CustomerNoteVar
                .ExecuteNonQuery()
                PUpdate = True
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal ThisCod_Customer As String) As Boolean
        FillFields = False
        If ThisCod_Customer.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * from cust_trtab_main where Cod_Customer=" & Qt(ThisCod_Customer)
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            TxtCustomerCod.Text = Trim(SQLReader.Item("cod_customer") & "")
            TxtCustomerNo.Text = Trim(SQLReader.Item("Customer_No") & "")
            txtvip_code.Text = Trim(SQLReader.Item("vip_code") & "")
            txtFName.Text = Trim(SQLReader.Item("f_name") & "")
            txtMName.Text = Trim(SQLReader.Item("m_name") & "")
            txtLName.Text = Trim(SQLReader.Item("l_name") & "")
            txtAddress.Text = Trim(SQLReader.Item("Address") & "")
            PhoneButton1.FillDataSet("Cust_trtab_main", "Cod_Customer=" & Qt(ThisCod_Customer))
            PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
            txtEmail.Text = Trim(SQLReader.Item("Email") & "")
            SocialSecurityNoNo1.Text = Trim(SQLReader.Item("social_security_no") & "")
            Try
                NumTaxExemptID.Text = SQLReader.Item("cust_exempt_tax")
            Catch ex As Exception
                NumTaxExemptID.Text = 0
            End Try
            Try
                NumScrapTireLicense.Text = Trim(SQLReader.Item("scrap_value"))
            Catch ex As Exception
                NumScrapTireLicense.Text = 0
            End Try
            NumScrapTireLicense.Text = Trim(SQLReader.Item("scrap_value") & "")
            txtCreditCardNo.Text = Trim(SQLReader.Item("credit_card_no") & "")
            DteExpDate.Text = Trim(SQLReader.Item("expiration_credit_date") & "")
            DteCustomer_Birth_Date.Text = Trim(SQLReader.Item("Customer_Birth_Date") & "")
            Try
                NumCreditLimit.Text = SQLReader.Item("credit_limited")
            Catch ex As Exception
                NumCreditLimit.Text = 0
            End Try
            NumDiscount.Text = Trim(SQLReader.Item("discount") & "")
            cmbAR_term.SelectedValue = Trim(SQLReader.Item("AR_term") & "")
            cmbSales_tax.SelectedValue = Trim(SQLReader.Item("cod_sales_tax") & "")
            cmbPriceLevel.Text = Trim(SQLReader.Item("cod_price") & "")
            cmbType.SelectedValue = Trim(SQLReader.Item("cod_type") & "")
            cmbSource.SelectedValue = Trim(SQLReader.Item("cod_Source") & "")
            cmbClass.SelectedValue = Trim(SQLReader.Item("cod_Class") & "")
            cmbTerritory.SelectedValue = Trim(SQLReader.Item("cod_territory") & "")
            cmbSaleRep.SelectedValue = Trim(SQLReader.Item("cod_sales_rep") & "")

            ' ********************************************** '
            '.Parameters("@desc_sales_report").Value = ""
            ' ********************************************** '
            txtUserID.Text = Trim(SQLReader.Item("user_id") & "")
            txtPassword.Text = Trim(SQLReader.Item("user_password") & "")
            chkScrapTireLicense.Checked = SQLReader.Item("scrap_check")
            chkAR_charge.Checked = SQLReader.Item("AR_charge")
            chkStatement.Checked = SQLReader.Item("AR_statement")
            chkSendCopies.Checked = SQLReader.Item("AR_send_copy")
            chkFinCharge.Checked = SQLReader.Item("AR_finance_charge")
            ChkPrintstatementDetailFlag.Checked = SQLReader.Item("PrintstatementDetailFlag")
            chkRequirePO.Checked = SQLReader.Item("AR_require_PO")
            chkCreditHold.Checked = SQLReader.Item("AR_credit_hold")
            chkAcceptCheck.Checked = SQLReader.Item("AR_accept_check")
            ChkTaxable.Checked = SQLReader.Item("Taxable")
            chkInactive.Checked = SQLReader.Item("Inactive")
            CustomerNoteVar = Trim(SQLReader.Item("cust_notes") & "")
            If CustomerNoteVar.Trim.Length > 0 Then
                btnNotes.ForeColor = Color.Red
            Else
                btnNotes.ForeColor = Color.Black
            End If

            txtDriverLicense.Text = Trim(SQLReader.Item("driverLicense") & "")
            txtDriver.Text = Trim(SQLReader.Item("driver_name1") & "")
            MyFrmDriverName.txtdriver_name1.Text = Trim(SQLReader.Item("driver_name1") & "")
            MyFrmDriverName.txtdriver_name2.Text = Trim(SQLReader.Item("driver_name2") & "")
            MyFrmDriverName.txtdriver_name3.Text = Trim(SQLReader.Item("driver_name3") & "")
            MyFrmDriverName.txtdriver_name4.Text = Trim(SQLReader.Item("driver_name4") & "")
            Dim Ziptemp1 As String = Trim(SQLReader.Item("Zip") & "")
            CompanyName1.CompanyCodForFind = Trim(SQLReader.Item("cod_company") & "")
            SQLReader.Close()
            CmdGeneral.Connection.Close()
            ZipCode1.Text = Ziptemp1
            Call FillOtherFields()
            '''''''''''''''''''''''''''''''''''''''
            FillFields = True
        Else
            Call ClearField()
        End If
        SQLReader.Close()
        CmdGeneral.Connection.Close()
    End Function
    Private Sub FillOtherFields()
        If TxtCustomerCod.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim Id_service_centerTemp As String
        Dim CurrentMonthVar As String = Getcod(Date.Today.Month.ToString, 2)
        Dim CurrentYearVar As String = Date.Today.Year.ToString
        Try
            LblSalesActivityDate.Text = ""
            LblSalesActivityAmount.Text = 0
            LblSalesActivityThisMonth.Text = 0
            LblSalesActivityThisYear.Text = 0
            LblLastVisit.Text = ""
            LblCustmerSince.Text = ""
            LblLastPaymentAmount.Text = ""
            LblLastPaymentDate.Text = ""

            LblCreditBalance.Text = ""
            LblCreditRemaining.Text = ""

            LblFinanceCharges.Text = ""
            LblNextPaymentAmount.Text = ""
            LblNextPaymentDate.Text = ""


            CmdGeneral.CommandText = "SELECT top 1 id_service_center,Date_Refer from service_center_head where type_of_form='IN' AND Cod_Customer=" & Qt(TxtCustomerCod.Text) & " Order by dbo.ChangeDate(date_refer) Desc"
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                Id_service_centerTemp = SQLReader.Item("Id_service_center")
                LblSalesActivityDate.Text = SQLReader.Item("Date_Refer") & ""
                SQLReader.Close()
                CmdGeneral.CommandText = "SELECT Total as SumPrice from service_center_head where type_of_form='IN' AND Id_service_center=" & Qt(Id_service_centerTemp)
                Try
                    LblSalesActivityAmount.Text = CmdGeneral.ExecuteScalar
                Catch ex As Exception
                    LblSalesActivityAmount.Text = 0
                End Try
                CmdGeneral.CommandText = "SELECT Total as SumPrice " _
                                       & "FROM service_center_head " _
                                       & " Where type_of_form='IN' AND  Cod_Customer=" & Qt(TxtCustomerCod.Text) & " AND substring(service_center_Head.Date_Refer,1,2)=" & Qt(CurrentMonthVar) & " AND substring(service_center_Head.Date_Refer,7,4)=" & Qt(CurrentYearVar)
                Try
                    LblSalesActivityThisMonth.Text = CmdGeneral.ExecuteScalar
                Catch ex As Exception
                    LblSalesActivityThisMonth.Text = 0
                End Try

                CmdGeneral.CommandText = "SELECT Total as SumPrice " _
                                       & "FROM service_center_head " _
                                       & " Where type_of_form='IN' AND Cod_Customer=" & Qt(TxtCustomerCod.Text) & " AND substring(service_center_Head.Date_Refer,7,4)=" & Qt(CurrentYearVar)
                Try
                    LblSalesActivityThisYear.Text = CmdGeneral.ExecuteScalar
                Catch ex As Exception
                    LblSalesActivityThisYear.Text = 0
                End Try

                LblLastVisit.Text = LblSalesActivityDate.Text
                CmdGeneral.CommandText = "SELECT top 1 Date_Refer from service_center_head where type_of_form='IN' AND Cod_Customer=" & Qt(TxtCustomerCod.Text) & " Order by dbo.ChangeDate(date_refer) Asc"
                LblCustmerSince.Text = CmdGeneral.ExecuteScalar & ""

                CmdGeneral.CommandText = "SELECT top 1 amount_receive from Gl_receive_payment where Cod_Customer=" & Qt(TxtCustomerCod.Text) & " Order by dbo.ChangeDate(date_receive_payment) Asc"
                LblLastPaymentAmount.Text = CmdGeneral.ExecuteScalar & ""
                CmdGeneral.CommandText = "SELECT top 1 date_receive_payment from Gl_receive_payment where Cod_Customer=" & Qt(TxtCustomerCod.Text) & " Order by dbo.ChangeDate(date_receive_payment) Asc"
                LblLastPaymentDate.Text = CmdGeneral.ExecuteScalar & ""

                CmdGeneral.CommandText = "SELECT isnull(BalanceAmount,0) FROM View_Customer_Balance WHERE cod_customer= " & Qt(TxtCustomerCod.Text)
                LblCreditBalance.Text = CmdGeneral.ExecuteScalar()
                LblCreditRemaining.Text = NumCreditLimit.Numbervalue - LblCreditBalance.Numbervalue

                CmdGeneral.CommandText = "SELECT isnull(sum(amount_adjustment),0) FROM GL_account_adjustment_head WHERE finance_charge_flag=1 AND cod_customer= " & Qt(TxtCustomerCod.Text)
                LblFinanceCharges.Text = CmdGeneral.ExecuteScalar()

                CmdGeneral.CommandText = "SELECT isnull(sum(amount_adjustment),0) FROM GL_account_adjustment_head WHERE finance_charge_flag=1 AND cod_customer= " & Qt(TxtCustomerCod.Text)
                LblFinanceCharges.Text = CmdGeneral.ExecuteScalar()

                CmdGeneral.CommandText = " SELECT TOP 1 ISNULL(GL_payment_deposit.payment_amount - GL_payment_deposit.Paid_amount, 0) AS Amount " & _
" FROM         GL_payment_deposit INNER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
" WHERE     (GL_payment_deposit.payment_amount - GL_payment_deposit.Paid_amount > 0) AND Cod_Customer=" & Qt(TxtCustomerCod.Text) & _
" ORDER BY dbo.ChangeDate(GL_payment_AR.AR_due_date) ASC "
                LblNextPaymentAmount.Text = CmdGeneral.ExecuteScalar

                CmdGeneral.CommandText = " SELECT TOP 1 GL_payment_AR.AR_due_date " & _
" FROM         GL_payment_deposit INNER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
" WHERE     (GL_payment_deposit.payment_amount - GL_payment_deposit.Paid_amount > 0) AND Cod_Customer=" & Qt(TxtCustomerCod.Text) & _
" ORDER BY dbo.ChangeDate(GL_payment_AR.AR_due_date) ASC "
                LblNextPaymentDate.Text = CmdGeneral.ExecuteScalar & ""

            End If
        Catch ex As Exception
        End Try
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
    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotes.Click
        MyFrmItemComments = New CommonClass.FrmItemComments
        MyFrmItemComments.TxtComments.Text = CustomerNoteVar & ""
        Call FitToScreen(btnNotes, MyFrmItemComments)
        MyFrmItemComments.ThisFormStatus = Status
        MyFrmItemComments.TxtComments.MaxLength = 300
        MyFrmItemComments.ShowDialog()
        CustomerNoteVar = MyFrmItemComments.TxtCommentvar
        If CustomerNoteVar.Trim.Length > 0 Then
            btnNotes.ForeColor = Color.Red
        Else
            btnNotes.ForeColor = Color.Black
        End If
        Call SaveButtonControl()
    End Sub
    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        Dim MyFrmCustomerHistory As New UCCustomer.FrmCustomerHistory
        MyFrmCustomerHistory.Cod_customerParameter = CustomerCod1.CustomerCod
        MyFrmCustomerHistory.LblCompany.Text = CompanyName1.CompanyComplete_Name
        MyFrmCustomerHistory.LblName.Text = CustomerCod1.CustomerDesc
        MyFrmCustomerHistory.ShowDialog()
    End Sub
    Private Sub BtnBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBalance.Click
        Dim MyFrmCustomerBalance As New FrmCustomerBalance
        MyFrmCustomerBalance.Cod_customerParameter = CustomerCod1.CustomerCod
        MyFrmCustomerBalance.LblCustomer.Text = CustomerCod1.CustomerCod
        MyFrmCustomerBalance.LblCompany.Text = CompanyName1.CompanyComplete_Name
        MyFrmCustomerBalance.LblName.Text = CustomerCod1.F_Name & " " & CustomerCod1.M_Name & " " & CustomerCod1.L_Name
        MyFrmCustomerBalance.ShowDialog()
    End Sub
    Private Function MakeNewcod_company() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_company) as Max_cod_company from cust_company WHERE substring(cod_company,1,1)='C'"
            MakeNewcod_company = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewcod_company, LenCompanyCod)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewcod_company.Length >= i Then
                MakeNewcod_company = Mid(MakeNewcod_company, 1, Len(MakeNewcod_company) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewcod_company.Trim.Length > LenCompanyCod Then
                MakeNewcod_company = "C0001"
            End If
        Catch ex As Exception
            MakeNewcod_company = "C0001"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                CustomerOrderFieldName = "Cod_Customer"
            Case "SORT2"
                CustomerOrderFieldName = "Cod_Company"
            Case "SORT3"
                CustomerOrderFieldName = "l_name"
        End Select
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        TxtCity.Text = ZipCode1.City
        TxtSt.Text = ZipCode1.State
    End Sub
    Private Sub ZipCode1_NotFindZipCode() Handles ZipCode1.NotFindZipCode
        TxtCity.Text = ""
        TxtSt.Text = ""
    End Sub
    Private Sub AddNewCompany()
        Dim ThisCodCompanyVar As String = CompanyName1.CompanyCod
        If CompanyName1.Text.Trim.Length > 0 And CompanyName1.CompanyCod.Trim.Length = 0 Then
            ThisCodCompanyVar = MakeNewcod_company()
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Insert Into cust_company (cod_company,abbreviation_name,complete_name,address,zip_code,remark) Values(" & Qt(ThisCodCompanyVar) & "," & Qt(Mid(CompanyName1.Text, 1, 25)) & "," & Qt(CompanyName1.Text) & "," & Qt(txtAddress.Text) & "," & IIf(ZipCode1.Text.Trim.Length > 0, Qt(ZipCode1.Text), "NULL") & ",'This Compnay Was Created In Customer Quick Add Form.')"
                CmdGeneral.ExecuteNonQuery()
                CompanyName1.CompanyCod = ThisCodCompanyVar
            Catch ex As Exception
                MsgFar("Can not insert company in company table")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub TxtCustomerCod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCustomerCod.LostFocus
        Try
            MyClsCustomerCod.Connection = Cnn
        Catch ex As Exception
        End Try
        If MyClsCustomerCod.FindDesc(TxtCustomerCod.Text) Then
            MsgBox("This Customer Code already axist.Try a new Code")
            TxtCustomerCod.Clear()
            TxtCustomerCod.Focus()
        End If
    End Sub
    Private Function MakeNewCustomerCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_customer) as Max_cod from cust_trtab_main where substring(cod_customer,1,1)='C' AND substring(cod_customer,2,1) IN ('0','1','2','3','4','5','6','7','8','9') "
            MakeNewCustomerCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewCustomerCod, LenCustomerCod)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewCustomerCod.Length >= i Then
                MakeNewCustomerCod = Mid(MakeNewCustomerCod, 1, Len(MakeNewCustomerCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewCustomerCod.Trim.Length > LenCustomerCod Then
                MakeNewCustomerCod = "C000001"
            End If
        Catch ex As Exception
            MakeNewCustomerCod = "C000001"
        Finally
            'CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Sub BtnDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDriver.Click
        Call FitToScreen(BtnDriver, MyFrmDriverName)
        MyFrmDriverName.ThisFormStatus = Status
        MyFrmDriverName.TxtName.Text = IIf(CompanyName1.Text.Trim.Length > 0, CompanyName1.Text, txtFName.Text.Trim & " " & txtMName.Text.Trim & " " & txtLName.Text.Trim)
        MyFrmDriverName.txtdriver_name1.Text = txtDriver.Text.Trim
        MyFrmDriverName.ShowDialog()
        txtDriver.Text = MyFrmDriverName.txtdriver_name1.Text.Trim
        'Call SaveButtonControl()
    End Sub
    Private Sub PhoneButton1_PhoneScreenAfterClose() Handles PhoneButton1.PhoneScreenAfterClose
        PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
        Call SaveButtonControl()
    End Sub
    Private Sub PhoneNoMain_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneNoMain.TextChanged
        Call PhoneButton1.GetPhoneNoMain(PhoneNoMain.Text)
        Call SaveButtonControl()
    End Sub
    'Private Sub PhoneNoMain_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneNoMain.Leave
    '    Call PhoneButton1.GetPhoneNoMain(PhoneNoMain.Text)
    '    Call SaveButtonControl()
    'End Sub
    Private Sub PhoneButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneButton1.Click
        PhoneButton1.HeaderName = IIf(CompanyName1.Text.Trim.Length > 0, CompanyName1.Text, txtFName.Text.Trim & " " & txtMName.Text.Trim & " " & txtLName.Text.Trim)
        Call SaveButtonControl()
    End Sub
    Private Sub chkAR_charge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAR_charge.CheckedChanged
        Call ChkAR_chargeDisableEnableAndShowDefaults()
        Call SaveButtonControl()
    End Sub
    Private Sub ChkAR_chargeDisableEnableAndShowDefaults()
        cmbAR_term.Enabled = chkAR_charge.Checked And chkAR_charge.Enabled
        chkStatement.Enabled = chkAR_charge.Checked And chkAR_charge.Enabled
        chkSendCopies.Enabled = chkAR_charge.Checked And chkAR_charge.Enabled
        chkFinCharge.Enabled = chkAR_charge.Checked And chkAR_charge.Enabled
        chkRequirePO.Enabled = chkAR_charge.Checked And chkAR_charge.Enabled
        chkCreditHold.Enabled = chkAR_charge.Checked And chkAR_charge.Enabled
        If chkAR_charge.Enabled Then
            If chkAR_charge.Checked Then
                Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
                OleDbReaderForStore = RetrieveAccountsReceivableSetupTable()
                Try
                    cmbAR_term.SelectedValue = OleDbReaderForStore.Item("Default_AR_terms")
                Catch ex As Exception
                End Try
                chkStatement.Checked = OleDbReaderForStore.Item("Default_statements")
                chkSendCopies.Checked = OleDbReaderForStore.Item("Default_SEND_COPY")
                chkFinCharge.Checked = OleDbReaderForStore.Item("Default_FIN_CHARGE")
                'chkRequirePO.Checked = OleDbReaderForStore.Item("")
                'chkCreditHold.Checked = OleDbReaderForStore.Item("")
            Else
                Try
                    cmbAR_term.SelectedValue = ""
                Catch ex As Exception
                End Try
                chkStatement.Checked = False
                chkSendCopies.Checked = False
                chkFinCharge.Checked = False
                chkRequirePO.Checked = False
                chkCreditHold.Checked = False
            End If
        End If
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        CustomerCod1.BtnSearch_Click(sender, e)
    End Sub
    Private Sub PhoneNoMain_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneNoMain.GotFocus
        If Mid(PhoneNoMain.Text, 1, 3).Trim.Length = 0 Then
            PhoneNoMain.Text = AreaCodVar & ""
        End If
    End Sub
    Private Sub BtnVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehicles.Click
        Dim MyFrmCustomerVehicles As New UCCustomer.FrmCustomerVehicles
        MyFrmCustomerVehicles.Cod_customerParameter = CustomerCod1.CustomerCod
        MyFrmCustomerVehicles.LblCompany.Text = CompanyName1.CompanyComplete_Name
        MyFrmCustomerVehicles.LblName.Text = CustomerCod1.F_Name & " " & CustomerCod1.M_Name & " " & CustomerCod1.L_Name
        MyFrmCustomerVehicles.ShowDialog()
    End Sub
End Class
