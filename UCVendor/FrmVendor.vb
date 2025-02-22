Imports CommonClass
Public Class FrmVendor
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim VendorOrderFieldName As String = "Cod_Vendor"
    Public VendorCodTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Dim MyFrmItemComments As CommonClass.FrmItemComments
    Dim WithEvents MyFrmSearchVendorCod As New FrmSearchvendorCod
    Public VendorNoteVar As String
    Public Cod_VendorVar As String = ""
    Dim MyClsVendorCod As New ClsVendorCod
    Public IsCancelForExitFlag As Boolean = False
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNotes As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    Friend WithEvents TXTSocial_Security_No As System.Windows.Forms.TextBox
    Friend WithEvents TXTFederal_tax_id As System.Windows.Forms.TextBox
    Friend WithEvents TxtContact2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtContact1 As System.Windows.Forms.TextBox
    Friend WithEvents CmbBuyer As System.Windows.Forms.ComboBox
    Friend WithEvents CmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents CmbAp_terms As System.Windows.Forms.ComboBox
    Friend WithEvents CHKInactive As System.Windows.Forms.CheckBox
    Friend WithEvents CHKONHold As System.Windows.Forms.CheckBox
    Friend WithEvents Chk1099 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents DsFrmVendor1 As UCVendor.DSFrmVendor
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents TxtVendorCod As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Buyer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_vendor_class As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_vendor_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents TxtSt As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TXTCity As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents ZipCode2 As UCZipCode.ZipCode
    Friend WithEvents TxtRemitSt As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TXTRemitCity As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtRemit_address As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemit_company As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As EmailAndWebAddress.EmailAddress
    Friend WithEvents TxtWWW As EmailAndWebAddress.WebSiteAddress
    Friend WithEvents PhoneNoMain As UCPhone.PhoneNo
    Friend WithEvents Command2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Command21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SortByType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UIContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort32 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents LblLastPaymentCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents LblLastPurchaseInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents LblLastPaymentDate As System.Windows.Forms.TextBox
    Friend WithEvents LblNextPaymentDate As System.Windows.Forms.TextBox
    Friend WithEvents LblLastPurchaseDate As System.Windows.Forms.TextBox
    Friend WithEvents LblVendor_since As System.Windows.Forms.TextBox
    Friend WithEvents PhoneButton1 As UCPhone.PhoneButton
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdate As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnVendorBalance As System.Windows.Forms.Button
    Friend WithEvents LblCredit_Balance As CalcUtils.UcCalcText
    Friend WithEvents LblCredit_Remaining As CalcUtils.UcCalcText
    Friend WithEvents NumCredit_limit As CalcUtils.UcCalcText
    Friend WithEvents LblNextPaymentAmount As CalcUtils.UcCalcText
    Friend WithEvents LblLastPurchaseAmount As CalcUtils.UcCalcText
    Friend WithEvents UcCalcText2 As CalcUtils.UcCalcText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblLastPaymentAmount As CalcUtils.UcCalcText
    Friend WithEvents CnnReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVendor))
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
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.LblLastPurchaseAmount = New CalcUtils.UcCalcText
        Me.LblNextPaymentAmount = New CalcUtils.UcCalcText
        Me.LblLastPaymentAmount = New CalcUtils.UcCalcText
        Me.NumCredit_limit = New CalcUtils.UcCalcText
        Me.LblCredit_Remaining = New CalcUtils.UcCalcText
        Me.LblCredit_Balance = New CalcUtils.UcCalcText
        Me.PhoneButton1 = New UCPhone.PhoneButton
        Me.TxtWWW = New EmailAndWebAddress.WebSiteAddress
        Me.TxtEmail = New EmailAndWebAddress.EmailAddress
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.TxtSt = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TXTCity = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ZipCode2 = New UCZipCode.ZipCode
        Me.TxtRemitSt = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TXTRemitCity = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.TxtRemit_address = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.TxtRemit_company = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.PhoneNoMain = New UCPhone.PhoneNo
        Me.BtnVendorBalance = New System.Windows.Forms.Button
        Me.btnNotes = New System.Windows.Forms.Button
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.LblLastPaymentCheckNo = New System.Windows.Forms.TextBox
        Me.LblLastPurchaseInvoiceNo = New System.Windows.Forms.TextBox
        Me.LblLastPaymentDate = New System.Windows.Forms.TextBox
        Me.LblNextPaymentDate = New System.Windows.Forms.TextBox
        Me.LblLastPurchaseDate = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TXTSocial_Security_No = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TXTFederal_tax_id = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtContact2 = New System.Windows.Forms.TextBox
        Me.TxtContact1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LblVendor_since = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbBuyer = New System.Windows.Forms.ComboBox
        Me.DsFrmVendor1 = New UCVendor.DSFrmVendor
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbClass = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbAp_terms = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.CHKInactive = New System.Windows.Forms.CheckBox
        Me.CHKONHold = New System.Windows.Forms.CheckBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Chk1099 = New System.Windows.Forms.CheckBox
        Me.TxtVendorCod = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.UcCalcText2 = New CalcUtils.UcCalcText
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
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
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Buyer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_vendor_class = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_vendor_type = New System.Data.SqlClient.SqlDataAdapter
        Me.Command2 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Command21 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.CnnReader = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsFrmVendor1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MAddNew.Text = "ÇíÌÇÏ"
        '
        'MEdit
        '
        Me.MEdit.Index = 1
        Me.MEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MEdit.Text = "ÇÕáÇÍ"
        '
        'MDelete
        '
        Me.MDelete.Index = 2
        Me.MDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MDelete.Text = "ÍÐÝ"
        '
        'MSave
        '
        Me.MSave.Enabled = False
        Me.MSave.Index = 3
        Me.MSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MSave.Text = "ËÈÊ"
        '
        'MCancel
        '
        Me.MCancel.Enabled = False
        Me.MCancel.Index = 4
        Me.MCancel.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MCancel.Text = "áÛæ"
        '
        'MFirstRecord
        '
        Me.MFirstRecord.Index = 5
        Me.MFirstRecord.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV
        Me.MFirstRecord.Text = "ÇÈÊÏÇ"
        '
        'MPreviousRecord
        '
        Me.MPreviousRecord.Index = 6
        Me.MPreviousRecord.Text = "ÞÈáí"
        '
        'MNextRecord
        '
        Me.MNextRecord.Index = 7
        Me.MNextRecord.Text = "ÈÚÏí"
        '
        'MLastRecord
        '
        Me.MLastRecord.Index = 8
        Me.MLastRecord.Text = "ÇäÊåÇ"
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM inv_vendor WHERE (cod_vendor = @cod_vendor)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.Vendor_Cod1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(637, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(56, 0)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Vendor_Cod1.TabIndex = 0
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(8, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Vendor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_03;password=sa"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.LblLastPurchaseAmount)
        Me.PnlKartAmvalField.Controls.Add(Me.LblNextPaymentAmount)
        Me.PnlKartAmvalField.Controls.Add(Me.LblLastPaymentAmount)
        Me.PnlKartAmvalField.Controls.Add(Me.NumCredit_limit)
        Me.PnlKartAmvalField.Controls.Add(Me.LblCredit_Remaining)
        Me.PnlKartAmvalField.Controls.Add(Me.LblCredit_Balance)
        Me.PnlKartAmvalField.Controls.Add(Me.PhoneButton1)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtWWW)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtEmail)
        Me.PnlKartAmvalField.Controls.Add(Me.ZipCode1)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtSt)
        Me.PnlKartAmvalField.Controls.Add(Me.TXTCity)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel2)
        Me.PnlKartAmvalField.Controls.Add(Me.PhoneNoMain)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnVendorBalance)
        Me.PnlKartAmvalField.Controls.Add(Me.btnNotes)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnHistory)
        Me.PnlKartAmvalField.Controls.Add(Me.Label29)
        Me.PnlKartAmvalField.Controls.Add(Me.Label28)
        Me.PnlKartAmvalField.Controls.Add(Me.Label27)
        Me.PnlKartAmvalField.Controls.Add(Me.Label22)
        Me.PnlKartAmvalField.Controls.Add(Me.LblLastPaymentCheckNo)
        Me.PnlKartAmvalField.Controls.Add(Me.LblLastPurchaseInvoiceNo)
        Me.PnlKartAmvalField.Controls.Add(Me.LblLastPaymentDate)
        Me.PnlKartAmvalField.Controls.Add(Me.LblNextPaymentDate)
        Me.PnlKartAmvalField.Controls.Add(Me.LblLastPurchaseDate)
        Me.PnlKartAmvalField.Controls.Add(Me.Label21)
        Me.PnlKartAmvalField.Controls.Add(Me.Label20)
        Me.PnlKartAmvalField.Controls.Add(Me.Label18)
        Me.PnlKartAmvalField.Controls.Add(Me.TXTSocial_Security_No)
        Me.PnlKartAmvalField.Controls.Add(Me.Label17)
        Me.PnlKartAmvalField.Controls.Add(Me.TXTFederal_tax_id)
        Me.PnlKartAmvalField.Controls.Add(Me.Label16)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtContact2)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtContact1)
        Me.PnlKartAmvalField.Controls.Add(Me.Label14)
        Me.PnlKartAmvalField.Controls.Add(Me.Label13)
        Me.PnlKartAmvalField.Controls.Add(Me.LblVendor_since)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbBuyer)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbClass)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbType)
        Me.PnlKartAmvalField.Controls.Add(Me.Label9)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbAp_terms)
        Me.PnlKartAmvalField.Controls.Add(Me.Label19)
        Me.PnlKartAmvalField.Controls.Add(Me.CHKInactive)
        Me.PnlKartAmvalField.Controls.Add(Me.CHKONHold)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAddress)
        Me.PnlKartAmvalField.Controls.Add(Me.Label10)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtCompany)
        Me.PnlKartAmvalField.Controls.Add(Me.Label38)
        Me.PnlKartAmvalField.Controls.Add(Me.Chk1099)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtVendorCod)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.Label12)
        Me.PnlKartAmvalField.Controls.Add(Me.Label15)
        Me.PnlKartAmvalField.Controls.Add(Me.Label26)
        Me.PnlKartAmvalField.Controls.Add(Me.Label25)
        Me.PnlKartAmvalField.Controls.Add(Me.Label24)
        Me.PnlKartAmvalField.Controls.Add(Me.Label23)
        Me.PnlKartAmvalField.Controls.Add(Me.UcCalcText2)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(637, 295)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'LblLastPurchaseAmount
        '
        Me.LblLastPurchaseAmount.BackColor = System.Drawing.Color.Gold
        Me.LblLastPurchaseAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblLastPurchaseAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblLastPurchaseAmount.DecimalDigits = 2
        Me.LblLastPurchaseAmount.DefaultSendValue = False
        Me.LblLastPurchaseAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblLastPurchaseAmount.FireTabAfterEnter = True
        Me.LblLastPurchaseAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblLastPurchaseAmount.Image = CType(resources.GetObject("LblLastPurchaseAmount.Image"), System.Drawing.Image)
        Me.LblLastPurchaseAmount.Location = New System.Drawing.Point(80, 217)
        Me.LblLastPurchaseAmount.Maxlength = 12
        Me.LblLastPurchaseAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblLastPurchaseAmount.Name = "LblLastPurchaseAmount"
        Me.LblLastPurchaseAmount.ReadOnly = True
        Me.LblLastPurchaseAmount.Size = New System.Drawing.Size(64, 21)
        Me.LblLastPurchaseAmount.TabIndex = 462
        Me.LblLastPurchaseAmount.TabStop = False
        Me.LblLastPurchaseAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblLastPurchaseAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.LblNextPaymentAmount.Location = New System.Drawing.Point(80, 242)
        Me.LblNextPaymentAmount.Maxlength = 12
        Me.LblNextPaymentAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblNextPaymentAmount.Name = "LblNextPaymentAmount"
        Me.LblNextPaymentAmount.ReadOnly = True
        Me.LblNextPaymentAmount.Size = New System.Drawing.Size(64, 21)
        Me.LblNextPaymentAmount.TabIndex = 461
        Me.LblNextPaymentAmount.TabStop = False
        Me.LblNextPaymentAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblNextPaymentAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.LblLastPaymentAmount.Location = New System.Drawing.Point(80, 270)
        Me.LblLastPaymentAmount.Maxlength = 12
        Me.LblLastPaymentAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblLastPaymentAmount.Name = "LblLastPaymentAmount"
        Me.LblLastPaymentAmount.ReadOnly = True
        Me.LblLastPaymentAmount.Size = New System.Drawing.Size(64, 21)
        Me.LblLastPaymentAmount.TabIndex = 460
        Me.LblLastPaymentAmount.TabStop = False
        Me.LblLastPaymentAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblLastPaymentAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumCredit_limit
        '
        Me.NumCredit_limit.BackColor = System.Drawing.SystemColors.Window
        Me.NumCredit_limit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCredit_limit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumCredit_limit.DecimalDigits = 2
        Me.NumCredit_limit.DefaultSendValue = False
        Me.NumCredit_limit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCredit_limit.FireTabAfterEnter = True
        Me.NumCredit_limit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCredit_limit.Image = CType(resources.GetObject("NumCredit_limit.Image"), System.Drawing.Image)
        Me.NumCredit_limit.Location = New System.Drawing.Point(80, 174)
        Me.NumCredit_limit.Maxlength = 12
        Me.NumCredit_limit.MinusColor = System.Drawing.Color.Empty
        Me.NumCredit_limit.Name = "NumCredit_limit"
        Me.NumCredit_limit.Size = New System.Drawing.Size(69, 21)
        Me.NumCredit_limit.TabIndex = 18
        Me.NumCredit_limit.TabStop = False
        Me.NumCredit_limit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCredit_limit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblCredit_Remaining
        '
        Me.LblCredit_Remaining.BackColor = System.Drawing.Color.Gold
        Me.LblCredit_Remaining.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCredit_Remaining.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCredit_Remaining.DecimalDigits = 2
        Me.LblCredit_Remaining.DefaultSendValue = False
        Me.LblCredit_Remaining.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCredit_Remaining.FireTabAfterEnter = True
        Me.LblCredit_Remaining.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCredit_Remaining.Image = CType(resources.GetObject("LblCredit_Remaining.Image"), System.Drawing.Image)
        Me.LblCredit_Remaining.Location = New System.Drawing.Point(222, 174)
        Me.LblCredit_Remaining.Maxlength = 12
        Me.LblCredit_Remaining.MinusColor = System.Drawing.Color.Empty
        Me.LblCredit_Remaining.Name = "LblCredit_Remaining"
        Me.LblCredit_Remaining.ReadOnly = True
        Me.LblCredit_Remaining.Size = New System.Drawing.Size(69, 21)
        Me.LblCredit_Remaining.TabIndex = 458
        Me.LblCredit_Remaining.TabStop = False
        Me.LblCredit_Remaining.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCredit_Remaining.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblCredit_Balance
        '
        Me.LblCredit_Balance.BackColor = System.Drawing.Color.Gold
        Me.LblCredit_Balance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCredit_Balance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCredit_Balance.DecimalDigits = 2
        Me.LblCredit_Balance.DefaultSendValue = False
        Me.LblCredit_Balance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCredit_Balance.FireTabAfterEnter = True
        Me.LblCredit_Balance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCredit_Balance.Image = CType(resources.GetObject("LblCredit_Balance.Image"), System.Drawing.Image)
        Me.LblCredit_Balance.Location = New System.Drawing.Point(151, 174)
        Me.LblCredit_Balance.Maxlength = 12
        Me.LblCredit_Balance.MinusColor = System.Drawing.Color.Empty
        Me.LblCredit_Balance.Name = "LblCredit_Balance"
        Me.LblCredit_Balance.ReadOnly = True
        Me.LblCredit_Balance.Size = New System.Drawing.Size(69, 21)
        Me.LblCredit_Balance.TabIndex = 457
        Me.LblCredit_Balance.TabStop = False
        Me.LblCredit_Balance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCredit_Balance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'PhoneButton1
        '
        Me.PhoneButton1.Location = New System.Drawing.Point(379, 32)
        Me.PhoneButton1.Name = "PhoneButton1"
        Me.PhoneButton1.Size = New System.Drawing.Size(23, 23)
        Me.PhoneButton1.TabIndex = 417
        Me.PhoneButton1.ZEnabled = True
        '
        'TxtWWW
        '
        Me.TxtWWW.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtWWW.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtWWW.ErrorColor = System.Drawing.Color.Red
        Me.TxtWWW.ErrorMessage = "www.microsoft.com ÂÏÑÓ æÈ ÓÇíÊ ÈÇíÓÊí Èå Çíä ÕæÑÊ ÈÇÔÏ"
        Me.TxtWWW.Location = New System.Drawing.Point(285, 81)
        Me.TxtWWW.Name = "TxtWWW"
        Me.TxtWWW.Size = New System.Drawing.Size(122, 21)
        Me.TxtWWW.TabIndex = 8
        Me.TxtWWW.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtWWW.ValidationExpression = "([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"
        '
        'TxtEmail
        '
        Me.TxtEmail.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtEmail.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtEmail.ErrorColor = System.Drawing.Color.Red
        Me.TxtEmail.ErrorMessage = "abc@microsoft.com ÂÏÑÓ ÓÊ Çá˜ÊÑæäí˜í ÈÇíÓÊí Èå Çíä ÕæÑÊ ÈÇÔÏ"
        Me.TxtEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(285, 57)
        Me.TxtEmail.MaxLength = 30
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(122, 21)
        Me.TxtEmail.TabIndex = 7
        Me.TxtEmail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtEmail.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0" & _
        "-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-" & _
        "9][0-9]|[1-9][0-9]|[0-9])\])$"
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Location = New System.Drawing.Point(180, 81)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(59, 21)
        Me.ZipCode1.TabIndex = 3
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'TxtSt
        '
        Me.TxtSt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSt.Location = New System.Drawing.Point(147, 81)
        Me.TxtSt.MaxLength = 20
        Me.TxtSt.Name = "TxtSt"
        Me.TxtSt.ReadOnly = True
        Me.TxtSt.Size = New System.Drawing.Size(33, 21)
        Me.TxtSt.TabIndex = 13
        Me.TxtSt.TabStop = False
        Me.TxtSt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TXTCity
        '
        Me.TXTCity.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTCity.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTCity.Location = New System.Drawing.Point(80, 81)
        Me.TXTCity.MaxLength = 50
        Me.TXTCity.Name = "TXTCity"
        Me.TXTCity.ReadOnly = True
        Me.TXTCity.Size = New System.Drawing.Size(67, 21)
        Me.TXTCity.TabIndex = 5
        Me.TXTCity.TabStop = False
        Me.TXTCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ZipCode2)
        Me.Panel2.Controls.Add(Me.TxtRemitSt)
        Me.Panel2.Controls.Add(Me.TXTRemitCity)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.TxtRemit_address)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.TxtRemit_company)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Location = New System.Drawing.Point(299, 214)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 73)
        Me.Panel2.TabIndex = 19
        '
        'ZipCode2
        '
        Me.ZipCode2.Connection = Me.Cnn
        Me.ZipCode2.Location = New System.Drawing.Point(264, 49)
        Me.ZipCode2.Name = "ZipCode2"
        Me.ZipCode2.NotExitIfNotFound = False
        Me.ZipCode2.ReleaseIfNotFoundZipCode = False
        Me.ZipCode2.Size = New System.Drawing.Size(59, 22)
        Me.ZipCode2.TabIndex = 2
        Me.ZipCode2.ZipCode = ""
        Me.ZipCode2.ZipCodeLen = 5
        '
        'TxtRemitSt
        '
        Me.TxtRemitSt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtRemitSt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtRemitSt.Location = New System.Drawing.Point(231, 49)
        Me.TxtRemitSt.MaxLength = 20
        Me.TxtRemitSt.Name = "TxtRemitSt"
        Me.TxtRemitSt.ReadOnly = True
        Me.TxtRemitSt.Size = New System.Drawing.Size(33, 21)
        Me.TxtRemitSt.TabIndex = 3
        Me.TxtRemitSt.TabStop = False
        Me.TxtRemitSt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TXTRemitCity
        '
        Me.TXTRemitCity.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTRemitCity.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTRemitCity.Location = New System.Drawing.Point(125, 49)
        Me.TXTRemitCity.MaxLength = 50
        Me.TXTRemitCity.Name = "TXTRemitCity"
        Me.TXTRemitCity.ReadOnly = True
        Me.TXTRemitCity.Size = New System.Drawing.Size(106, 21)
        Me.TXTRemitCity.TabIndex = 2
        Me.TXTRemitCity.TabStop = False
        Me.TXTRemitCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(2, 3)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 21)
        Me.Label37.TabIndex = 413
        Me.Label37.Tag = ""
        Me.Label37.Text = "Remit to"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(60, 50)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(62, 19)
        Me.Label34.TabIndex = 412
        Me.Label34.Text = "City,St. ZIP"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtRemit_address
        '
        Me.TxtRemit_address.Location = New System.Drawing.Point(123, 27)
        Me.TxtRemit_address.MaxLength = 100
        Me.TxtRemit_address.Name = "TxtRemit_address"
        Me.TxtRemit_address.Size = New System.Drawing.Size(200, 21)
        Me.TxtRemit_address.TabIndex = 1
        Me.TxtRemit_address.Text = ""
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(57, 28)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 19)
        Me.Label35.TabIndex = 411
        Me.Label35.Text = "Address"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtRemit_company
        '
        Me.TxtRemit_company.Location = New System.Drawing.Point(123, 4)
        Me.TxtRemit_company.MaxLength = 50
        Me.TxtRemit_company.Name = "TxtRemit_company"
        Me.TxtRemit_company.Size = New System.Drawing.Size(200, 21)
        Me.TxtRemit_company.TabIndex = 0
        Me.TxtRemit_company.Text = ""
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(59, 4)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(62, 21)
        Me.Label36.TabIndex = 410
        Me.Label36.Text = "Company"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneNoMain
        '
        Me.PhoneNoMain.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNoMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNoMain.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNoMain.Location = New System.Drawing.Point(285, 33)
        Me.PhoneNoMain.Name = "PhoneNoMain"
        Me.PhoneNoMain.Size = New System.Drawing.Size(94, 22)
        Me.PhoneNoMain.TabIndex = 6
        '
        'BtnVendorBalance
        '
        Me.BtnVendorBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnVendorBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVendorBalance.Location = New System.Drawing.Point(293, 174)
        Me.BtnVendorBalance.Name = "BtnVendorBalance"
        Me.BtnVendorBalance.Size = New System.Drawing.Size(73, 19)
        Me.BtnVendorBalance.TabIndex = 411
        Me.BtnVendorBalance.TabStop = False
        Me.BtnVendorBalance.Text = "Balance"
        '
        'btnNotes
        '
        Me.btnNotes.BackColor = System.Drawing.Color.YellowGreen
        Me.btnNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNotes.Location = New System.Drawing.Point(547, 29)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(80, 20)
        Me.btnNotes.TabIndex = 410
        Me.btnNotes.TabStop = False
        Me.btnNotes.Text = "Notes"
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHistory.Location = New System.Drawing.Point(443, 29)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(80, 20)
        Me.BtnHistory.TabIndex = 409
        Me.BtnHistory.TabStop = False
        Me.BtnHistory.Text = "History"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(226, 155)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 21)
        Me.Label29.TabIndex = 399
        Me.Label29.Tag = ""
        Me.Label29.Text = "Remaining"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(154, 155)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 21)
        Me.Label28.TabIndex = 398
        Me.Label28.Tag = ""
        Me.Label28.Text = "Balance"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(83, 151)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 21)
        Me.Label27.TabIndex = 397
        Me.Label27.Tag = ""
        Me.Label27.Text = "Limit"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(-11, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 19)
        Me.Label22.TabIndex = 392
        Me.Label22.Text = "Credit"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblLastPaymentCheckNo
        '
        Me.LblLastPaymentCheckNo.BackColor = System.Drawing.Color.Gold
        Me.LblLastPaymentCheckNo.Location = New System.Drawing.Point(224, 270)
        Me.LblLastPaymentCheckNo.MaxLength = 5
        Me.LblLastPaymentCheckNo.Name = "LblLastPaymentCheckNo"
        Me.LblLastPaymentCheckNo.ReadOnly = True
        Me.LblLastPaymentCheckNo.Size = New System.Drawing.Size(64, 21)
        Me.LblLastPaymentCheckNo.TabIndex = 365
        Me.LblLastPaymentCheckNo.TabStop = False
        Me.LblLastPaymentCheckNo.Text = ""
        '
        'LblLastPurchaseInvoiceNo
        '
        Me.LblLastPurchaseInvoiceNo.BackColor = System.Drawing.Color.Gold
        Me.LblLastPurchaseInvoiceNo.Location = New System.Drawing.Point(224, 217)
        Me.LblLastPurchaseInvoiceNo.MaxLength = 5
        Me.LblLastPurchaseInvoiceNo.Name = "LblLastPurchaseInvoiceNo"
        Me.LblLastPurchaseInvoiceNo.ReadOnly = True
        Me.LblLastPurchaseInvoiceNo.Size = New System.Drawing.Size(64, 21)
        Me.LblLastPurchaseInvoiceNo.TabIndex = 362
        Me.LblLastPurchaseInvoiceNo.TabStop = False
        Me.LblLastPurchaseInvoiceNo.Text = ""
        '
        'LblLastPaymentDate
        '
        Me.LblLastPaymentDate.BackColor = System.Drawing.Color.Gold
        Me.LblLastPaymentDate.Location = New System.Drawing.Point(144, 270)
        Me.LblLastPaymentDate.MaxLength = 5
        Me.LblLastPaymentDate.Name = "LblLastPaymentDate"
        Me.LblLastPaymentDate.ReadOnly = True
        Me.LblLastPaymentDate.Size = New System.Drawing.Size(80, 21)
        Me.LblLastPaymentDate.TabIndex = 338
        Me.LblLastPaymentDate.TabStop = False
        Me.LblLastPaymentDate.Text = ""
        '
        'LblNextPaymentDate
        '
        Me.LblNextPaymentDate.BackColor = System.Drawing.Color.Gold
        Me.LblNextPaymentDate.Location = New System.Drawing.Point(144, 242)
        Me.LblNextPaymentDate.MaxLength = 5
        Me.LblNextPaymentDate.Name = "LblNextPaymentDate"
        Me.LblNextPaymentDate.ReadOnly = True
        Me.LblNextPaymentDate.Size = New System.Drawing.Size(80, 21)
        Me.LblNextPaymentDate.TabIndex = 364
        Me.LblNextPaymentDate.TabStop = False
        Me.LblNextPaymentDate.Text = ""
        '
        'LblLastPurchaseDate
        '
        Me.LblLastPurchaseDate.BackColor = System.Drawing.Color.Gold
        Me.LblLastPurchaseDate.Location = New System.Drawing.Point(144, 217)
        Me.LblLastPurchaseDate.MaxLength = 5
        Me.LblLastPurchaseDate.Name = "LblLastPurchaseDate"
        Me.LblLastPurchaseDate.ReadOnly = True
        Me.LblLastPurchaseDate.Size = New System.Drawing.Size(80, 21)
        Me.LblLastPurchaseDate.TabIndex = 361
        Me.LblLastPurchaseDate.TabStop = False
        Me.LblLastPurchaseDate.Text = ""
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(-11, 270)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 19)
        Me.Label21.TabIndex = 391
        Me.Label21.Text = "Last Payment"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(-11, 243)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 20)
        Me.Label20.TabIndex = 390
        Me.Label20.Text = "Next Payment"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(-11, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 21)
        Me.Label18.TabIndex = 389
        Me.Label18.Text = "Last Purchase"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTSocial_Security_No
        '
        Me.TXTSocial_Security_No.Location = New System.Drawing.Point(285, 128)
        Me.TXTSocial_Security_No.MaxLength = 25
        Me.TXTSocial_Security_No.Name = "TXTSocial_Security_No"
        Me.TXTSocial_Security_No.Size = New System.Drawing.Size(123, 21)
        Me.TXTSocial_Security_No.TabIndex = 10
        Me.TXTSocial_Security_No.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(185, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 21)
        Me.Label17.TabIndex = 388
        Me.Label17.Text = "Social Security No"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTFederal_tax_id
        '
        Me.TXTFederal_tax_id.Location = New System.Drawing.Point(78, 128)
        Me.TXTFederal_tax_id.MaxLength = 25
        Me.TXTFederal_tax_id.Name = "TXTFederal_tax_id"
        Me.TXTFederal_tax_id.Size = New System.Drawing.Size(112, 21)
        Me.TXTFederal_tax_id.TabIndex = 5
        Me.TXTFederal_tax_id.Text = ""
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(-9, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 21)
        Me.Label16.TabIndex = 387
        Me.Label16.Text = "Federal Tax ID"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtContact2
        '
        Me.TxtContact2.Location = New System.Drawing.Point(285, 104)
        Me.TxtContact2.MaxLength = 20
        Me.TxtContact2.Name = "TxtContact2"
        Me.TxtContact2.Size = New System.Drawing.Size(123, 21)
        Me.TxtContact2.TabIndex = 9
        Me.TxtContact2.Text = ""
        '
        'TxtContact1
        '
        Me.TxtContact1.Location = New System.Drawing.Point(78, 104)
        Me.TxtContact1.MaxLength = 20
        Me.TxtContact1.Name = "TxtContact1"
        Me.TxtContact1.Size = New System.Drawing.Size(139, 21)
        Me.TxtContact1.TabIndex = 4
        Me.TxtContact1.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(-13, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 20)
        Me.Label14.TabIndex = 385
        Me.Label14.Text = "Contact 1"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(-12, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 19)
        Me.Label13.TabIndex = 384
        Me.Label13.Text = "City, St. ZIP"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblVendor_since
        '
        Me.LblVendor_since.BackColor = System.Drawing.Color.Gold
        Me.LblVendor_since.Location = New System.Drawing.Point(469, 152)
        Me.LblVendor_since.MaxLength = 10
        Me.LblVendor_since.Name = "LblVendor_since"
        Me.LblVendor_since.ReadOnly = True
        Me.LblVendor_since.Size = New System.Drawing.Size(94, 21)
        Me.LblVendor_since.TabIndex = 353
        Me.LblVendor_since.TabStop = False
        Me.LblVendor_since.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(387, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 380
        Me.Label7.Text = "Vendor Since"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbBuyer
        '
        Me.CmbBuyer.DataSource = Me.DsFrmVendor1.inv_buyer
        Me.CmbBuyer.DisplayMember = "desc_buyer"
        Me.CmbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBuyer.Location = New System.Drawing.Point(469, 128)
        Me.CmbBuyer.MaxLength = 4
        Me.CmbBuyer.Name = "CmbBuyer"
        Me.CmbBuyer.Size = New System.Drawing.Size(96, 21)
        Me.CmbBuyer.TabIndex = 14
        Me.CmbBuyer.ValueMember = "buyer_id"
        '
        'DsFrmVendor1
        '
        Me.DsFrmVendor1.DataSetName = "DSFrmVendor"
        Me.DsFrmVendor1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(402, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 379
        Me.Label1.Tag = ""
        Me.Label1.Text = "Buyer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbClass
        '
        Me.CmbClass.DataSource = Me.DsFrmVendor1.inv_tab_vendor_class
        Me.CmbClass.DisplayMember = "desc_class"
        Me.CmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClass.Location = New System.Drawing.Point(469, 104)
        Me.CmbClass.MaxLength = 3
        Me.CmbClass.Name = "CmbClass"
        Me.CmbClass.Size = New System.Drawing.Size(96, 21)
        Me.CmbClass.TabIndex = 13
        Me.CmbClass.ValueMember = "class_vendor"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(403, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 378
        Me.Label6.Tag = ""
        Me.Label6.Text = "Class"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbType
        '
        Me.CmbType.DataSource = Me.DsFrmVendor1.inv_tab_vendor_type
        Me.CmbType.DisplayMember = "desc_vendor_type"
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.Location = New System.Drawing.Point(469, 81)
        Me.CmbType.MaxLength = 3
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(96, 21)
        Me.CmbType.TabIndex = 12
        Me.CmbType.ValueMember = "vendor_type"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(403, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 377
        Me.Label9.Tag = ""
        Me.Label9.Text = "Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbAp_terms
        '
        Me.CmbAp_terms.DataSource = Me.DsFrmVendor1.GL_TAB_AR_TERM
        Me.CmbAp_terms.DisplayMember = "AR_terms"
        Me.CmbAp_terms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAp_terms.Location = New System.Drawing.Point(469, 57)
        Me.CmbAp_terms.MaxLength = 10
        Me.CmbAp_terms.Name = "CmbAp_terms"
        Me.CmbAp_terms.Size = New System.Drawing.Size(96, 21)
        Me.CmbAp_terms.TabIndex = 11
        Me.CmbAp_terms.ValueMember = "AR_terms"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(403, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 20)
        Me.Label19.TabIndex = 376
        Me.Label19.Tag = ""
        Me.Label19.Text = "AP Terms"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CHKInactive
        '
        Me.CHKInactive.BackColor = System.Drawing.SystemColors.Control
        Me.CHKInactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CHKInactive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CHKInactive.Location = New System.Drawing.Point(568, 104)
        Me.CHKInactive.Name = "CHKInactive"
        Me.CHKInactive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKInactive.Size = New System.Drawing.Size(65, 20)
        Me.CHKInactive.TabIndex = 17
        Me.CHKInactive.Text = "Inactive"
        '
        'CHKONHold
        '
        Me.CHKONHold.BackColor = System.Drawing.SystemColors.Control
        Me.CHKONHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CHKONHold.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CHKONHold.Location = New System.Drawing.Point(568, 81)
        Me.CHKONHold.Name = "CHKONHold"
        Me.CHKONHold.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKONHold.Size = New System.Drawing.Size(65, 19)
        Me.CHKONHold.TabIndex = 16
        Me.CHKONHold.Text = "On Hold"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(78, 57)
        Me.TxtAddress.MaxLength = 100
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(155, 21)
        Me.TxtAddress.TabIndex = 2
        Me.TxtAddress.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(-15, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 19)
        Me.Label10.TabIndex = 375
        Me.Label10.Text = "Address"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCompany
        '
        Me.TxtCompany.Location = New System.Drawing.Point(78, 31)
        Me.TxtCompany.MaxLength = 50
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(155, 21)
        Me.TxtCompany.TabIndex = 1
        Me.TxtCompany.Text = ""
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(-14, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(88, 19)
        Me.Label38.TabIndex = 374
        Me.Label38.Text = "Company"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk1099
        '
        Me.Chk1099.BackColor = System.Drawing.SystemColors.Control
        Me.Chk1099.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Chk1099.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk1099.Location = New System.Drawing.Point(568, 57)
        Me.Chk1099.Name = "Chk1099"
        Me.Chk1099.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chk1099.Size = New System.Drawing.Size(65, 19)
        Me.Chk1099.TabIndex = 15
        Me.Chk1099.Text = "1099"
        '
        'TxtVendorCod
        '
        Me.TxtVendorCod.Location = New System.Drawing.Point(79, 3)
        Me.TxtVendorCod.MaxLength = 6
        Me.TxtVendorCod.Name = "TxtVendorCod"
        Me.TxtVendorCod.Size = New System.Drawing.Size(88, 21)
        Me.TxtVendorCod.TabIndex = 0
        Me.TxtVendorCod.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(20, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "Vendor"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(208, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 381
        Me.Label11.Text = "Phone"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(207, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 382
        Me.Label8.Text = "Email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(240, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 19)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "URL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(208, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 20)
        Me.Label15.TabIndex = 386
        Me.Label15.Text = "Contact 2"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(224, 199)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 20)
        Me.Label26.TabIndex = 396
        Me.Label26.Tag = ""
        Me.Label26.Text = "Invoice No"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(152, 199)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 20)
        Me.Label25.TabIndex = 395
        Me.Label25.Tag = ""
        Me.Label25.Text = "Date"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(80, 198)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 20)
        Me.Label24.TabIndex = 394
        Me.Label24.Tag = ""
        Me.Label24.Text = "Amount"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(224, 250)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 21)
        Me.Label23.TabIndex = 393
        Me.Label23.Tag = ""
        Me.Label23.Text = "Check No"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcCalcText2
        '
        Me.UcCalcText2.BackColor = System.Drawing.Color.Gold
        Me.UcCalcText2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.UcCalcText2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.UcCalcText2.DecimalDigits = 2
        Me.UcCalcText2.DefaultSendValue = False
        Me.UcCalcText2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.UcCalcText2.FireTabAfterEnter = True
        Me.UcCalcText2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcCalcText2.Image = CType(resources.GetObject("UcCalcText2.Image"), System.Drawing.Image)
        Me.UcCalcText2.Location = New System.Drawing.Point(83, 217)
        Me.UcCalcText2.Maxlength = 12
        Me.UcCalcText2.MinusColor = System.Drawing.Color.Empty
        Me.UcCalcText2.Name = "UcCalcText2"
        Me.UcCalcText2.ReadOnly = True
        Me.UcCalcText2.Size = New System.Drawing.Size(69, 21)
        Me.UcCalcText2.TabIndex = 462
        Me.UcCalcText2.TabStop = False
        Me.UcCalcText2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.UcCalcText2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(-8, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 390
        Me.Label2.Text = "Next Payment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
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
        Me.Panel9.Size = New System.Drawing.Size(637, 45)
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
        Me.Sort1.Text = "Order By Vendor Code"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Vendor Name"
        '
        'Sort32
        '
        Me.Sort32.Key = "Sort3"
        Me.Sort32.Name = "Sort32"
        Me.Sort32.Text = "Order By Vendor ZipCode"
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
        Me.Label40.Location = New System.Drawing.Point(4, 31)
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
        Me.Label41.Location = New System.Drawing.Point(132, 31)
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
        Me.Label43.Location = New System.Drawing.Point(301, 31)
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
        Me.Label51.Location = New System.Drawing.Point(340, 31)
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
        Me.Label53.Location = New System.Drawing.Point(195, 31)
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
        Me.Label55.Location = New System.Drawing.Point(89, 31)
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
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT buyer_id, desc_buyer FROM inv_buyer"
        Me.SqlSelectCommand2.Connection = Me.CnnTemp
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO inv_buyer(buyer_id, desc_buyer) VALUES (@buyer_id, @desc_buyer); SELE" & _
        "CT buyer_id, desc_buyer FROM inv_buyer WHERE (buyer_id = @buyer_id)"
        Me.SqlInsertCommand2.Connection = Me.CnnTemp
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_buyer", System.Data.SqlDbType.VarChar, 50, "desc_buyer"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE inv_buyer SET buyer_id = @buyer_id, desc_buyer = @desc_buyer WHERE (buyer_" & _
        "id = @Original_buyer_id) AND (desc_buyer = @Original_desc_buyer OR @Original_des" & _
        "c_buyer IS NULL AND desc_buyer IS NULL); SELECT buyer_id, desc_buyer FROM inv_bu" & _
        "yer WHERE (buyer_id = @buyer_id)"
        Me.SqlUpdateCommand2.Connection = Me.CnnTemp
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_buyer", System.Data.SqlDbType.VarChar, 50, "desc_buyer"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_buyer_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "buyer_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_buyer", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_buyer", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM inv_buyer WHERE (buyer_id = @Original_buyer_id) AND (desc_buyer = @Or" & _
        "iginal_desc_buyer OR @Original_desc_buyer IS NULL AND desc_buyer IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.CnnTemp
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_buyer_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "buyer_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_buyer", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_buyer", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_Buyer
        '
        Me.DAInv_Buyer.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAInv_Buyer.InsertCommand = Me.SqlInsertCommand2
        Me.DAInv_Buyer.SelectCommand = Me.SqlSelectCommand2
        Me.DAInv_Buyer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_buyer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("desc_buyer", "desc_buyer")})})
        Me.DAInv_Buyer.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT class_vendor, desc_class FROM inv_tab_vendor_class"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO inv_tab_vendor_class(class_vendor, desc_class) VALUES (@class_vendor," & _
        " @desc_class); SELECT class_vendor, desc_class FROM inv_tab_vendor_class WHERE (" & _
        "class_vendor = @class_vendor)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE inv_tab_vendor_class SET class_vendor = @class_vendor, desc_class = @desc_" & _
        "class WHERE (class_vendor = @Original_class_vendor) AND (desc_class = @Original_" & _
        "desc_class OR @Original_desc_class IS NULL AND desc_class IS NULL); SELECT class" & _
        "_vendor, desc_class FROM inv_tab_vendor_class WHERE (class_vendor = @class_vendo" & _
        "r)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM inv_tab_vendor_class WHERE (class_vendor = @Original_class_vendor) AN" & _
        "D (desc_class = @Original_desc_class OR @Original_desc_class IS NULL AND desc_cl" & _
        "ass IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_class_vendor", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "class_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_vendor_class
        '
        Me.DAinv_tab_vendor_class.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAinv_tab_vendor_class.InsertCommand = Me.SqlInsertCommand4
        Me.DAinv_tab_vendor_class.SelectCommand = Me.SqlSelectCommand4
        Me.DAinv_tab_vendor_class.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        Me.DAinv_tab_vendor_class.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT vendor_type, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type" & _
        ""
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO inv_tab_vendor_type(vendor_type, desc_vendor_type, GL_expense_account" & _
        ") VALUES (@vendor_type, @desc_vendor_type, @GL_expense_account); SELECT vendor_t" & _
        "ype, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type WHERE (vendor" & _
        "_type = @vendor_type)"
        Me.SqlInsertCommand5.Connection = Me.Cnn
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor_type", System.Data.SqlDbType.VarChar, 50, "desc_vendor_type"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE inv_tab_vendor_type SET vendor_type = @vendor_type, desc_vendor_type = @de" & _
        "sc_vendor_type, GL_expense_account = @GL_expense_account WHERE (vendor_type = @O" & _
        "riginal_vendor_type) AND (GL_expense_account = @Original_GL_expense_account OR @" & _
        "Original_GL_expense_account IS NULL AND GL_expense_account IS NULL) AND (desc_ve" & _
        "ndor_type = @Original_desc_vendor_type OR @Original_desc_vendor_type IS NULL AND" & _
        " desc_vendor_type IS NULL); SELECT vendor_type, desc_vendor_type, GL_expense_acc" & _
        "ount FROM inv_tab_vendor_type WHERE (vendor_type = @vendor_type)"
        Me.SqlUpdateCommand5.Connection = Me.Cnn
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor_type", System.Data.SqlDbType.VarChar, 50, "desc_vendor_type"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM inv_tab_vendor_type WHERE (vendor_type = @Original_vendor_type) AND (" & _
        "GL_expense_account = @Original_GL_expense_account OR @Original_GL_expense_accoun" & _
        "t IS NULL AND GL_expense_account IS NULL) AND (desc_vendor_type = @Original_desc" & _
        "_vendor_type OR @Original_desc_vendor_type IS NULL AND desc_vendor_type IS NULL)" & _
        ""
        Me.SqlDeleteCommand5.Connection = Me.Cnn
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_type", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_vendor_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_vendor_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_vendor_type
        '
        Me.DAinv_tab_vendor_type.DeleteCommand = Me.SqlDeleteCommand5
        Me.DAinv_tab_vendor_type.InsertCommand = Me.SqlInsertCommand5
        Me.DAinv_tab_vendor_type.SelectCommand = Me.SqlSelectCommand5
        Me.DAinv_tab_vendor_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("desc_vendor_type", "desc_vendor_type"), New System.Data.Common.DataColumnMapping("GL_expense_account", "GL_expense_account")})})
        Me.DAinv_tab_vendor_type.UpdateCommand = Me.SqlUpdateCommand5
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
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_TAB_AR_TERM.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlCommand1
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        Me.DAGL_TAB_AR_TERM.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_TAB_AR_TERM WHERE (AR_terms = @Original_AR_terms) AND (DD_DISCOUNT" & _
        "_PERCENTAGE = @Original_DD_DISCOUNT_PERCENTAGE OR @Original_DD_DISCOUNT_PERCENTA" & _
        "GE IS NULL AND DD_DISCOUNT_PERCENTAGE IS NULL) AND (DD_IF_ISSUED_WITHIN_DAYS = @" & _
        "Original_DD_IF_ISSUED_WITHIN_DAYS OR @Original_DD_IF_ISSUED_WITHIN_DAYS IS NULL " & _
        "AND DD_IF_ISSUED_WITHIN_DAYS IS NULL) AND (DD_IF_PAY_WITHIN_DAYS = @Original_DD_" & _
        "IF_PAY_WITHIN_DAYS OR @Original_DD_IF_PAY_WITHIN_DAYS IS NULL AND DD_IF_PAY_WITH" & _
        "IN_DAYS IS NULL) AND (DD_NET_DUE_BEFORE = @Original_DD_NET_DUE_BEFORE OR @Origin" & _
        "al_DD_NET_DUE_BEFORE IS NULL AND DD_NET_DUE_BEFORE IS NULL) AND (KIND_AR = @Orig" & _
        "inal_KIND_AR OR @Original_KIND_AR IS NULL AND KIND_AR IS NULL) AND (MP_BEFORE_DA" & _
        "Y = @Original_MP_BEFORE_DAY OR @Original_MP_BEFORE_DAY IS NULL AND MP_BEFORE_DAY" & _
        " IS NULL) AND (MP_NO_OF_PAYMENT = @Original_MP_NO_OF_PAYMENT OR @Original_MP_NO_" & _
        "OF_PAYMENT IS NULL AND MP_NO_OF_PAYMENT IS NULL) AND (ST_DISCOUNT_PERCENTAGE = @" & _
        "Original_ST_DISCOUNT_PERCENTAGE OR @Original_ST_DISCOUNT_PERCENTAGE IS NULL AND " & _
        "ST_DISCOUNT_PERCENTAGE IS NULL) AND (ST_IF_PAY_WITHIN_DAYS = @Original_ST_IF_PAY" & _
        "_WITHIN_DAYS OR @Original_ST_IF_PAY_WITHIN_DAYS IS NULL AND ST_IF_PAY_WITHIN_DAY" & _
        "S IS NULL) AND (ST_NET_DUE_IN = @Original_ST_NET_DUE_IN OR @Original_ST_NET_DUE_" & _
        "IN IS NULL AND ST_NET_DUE_IN IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_TAB_AR_TERM(AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTA" & _
        "GE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCO" & _
        "UNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY) VALUES (" & _
        "@AR_terms, @KIND_AR, @ST_NET_DUE_IN, @ST_DISCOUNT_PERCENTAGE, @ST_IF_PAY_WITHIN_" & _
        "DAYS, @DD_NET_DUE_BEFORE, @DD_IF_ISSUED_WITHIN_DAYS, @DD_DISCOUNT_PERCENTAGE, @D" & _
        "D_IF_PAY_WITHIN_DAYS, @MP_NO_OF_PAYMENT, @MP_BEFORE_DAY); SELECT AR_terms, KIND_" & _
        "AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEF" & _
        "ORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP" & _
        "_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms = @AR_terms)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN" & _
        "_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_I" & _
        "F_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_TAB_AR_TERM SET AR_terms = @AR_terms, KIND_AR = @KIND_AR, ST_NET_DUE_IN" & _
        " = @ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE = @ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_W" & _
        "ITHIN_DAYS = @ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE = @DD_NET_DUE_BEFORE, DD_" & _
        "IF_ISSUED_WITHIN_DAYS = @DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE = @DD_" & _
        "DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS = @DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PA" & _
        "YMENT = @MP_NO_OF_PAYMENT, MP_BEFORE_DAY = @MP_BEFORE_DAY WHERE (AR_terms = @Ori" & _
        "ginal_AR_terms) AND (DD_DISCOUNT_PERCENTAGE = @Original_DD_DISCOUNT_PERCENTAGE O" & _
        "R @Original_DD_DISCOUNT_PERCENTAGE IS NULL AND DD_DISCOUNT_PERCENTAGE IS NULL) A" & _
        "ND (DD_IF_ISSUED_WITHIN_DAYS = @Original_DD_IF_ISSUED_WITHIN_DAYS OR @Original_D" & _
        "D_IF_ISSUED_WITHIN_DAYS IS NULL AND DD_IF_ISSUED_WITHIN_DAYS IS NULL) AND (DD_IF" & _
        "_PAY_WITHIN_DAYS = @Original_DD_IF_PAY_WITHIN_DAYS OR @Original_DD_IF_PAY_WITHIN" & _
        "_DAYS IS NULL AND DD_IF_PAY_WITHIN_DAYS IS NULL) AND (DD_NET_DUE_BEFORE = @Origi" & _
        "nal_DD_NET_DUE_BEFORE OR @Original_DD_NET_DUE_BEFORE IS NULL AND DD_NET_DUE_BEFO" & _
        "RE IS NULL) AND (KIND_AR = @Original_KIND_AR OR @Original_KIND_AR IS NULL AND KI" & _
        "ND_AR IS NULL) AND (MP_BEFORE_DAY = @Original_MP_BEFORE_DAY OR @Original_MP_BEFO" & _
        "RE_DAY IS NULL AND MP_BEFORE_DAY IS NULL) AND (MP_NO_OF_PAYMENT = @Original_MP_N" & _
        "O_OF_PAYMENT OR @Original_MP_NO_OF_PAYMENT IS NULL AND MP_NO_OF_PAYMENT IS NULL)" & _
        " AND (ST_DISCOUNT_PERCENTAGE = @Original_ST_DISCOUNT_PERCENTAGE OR @Original_ST_" & _
        "DISCOUNT_PERCENTAGE IS NULL AND ST_DISCOUNT_PERCENTAGE IS NULL) AND (ST_IF_PAY_W" & _
        "ITHIN_DAYS = @Original_ST_IF_PAY_WITHIN_DAYS OR @Original_ST_IF_PAY_WITHIN_DAYS " & _
        "IS NULL AND ST_IF_PAY_WITHIN_DAYS IS NULL) AND (ST_NET_DUE_IN = @Original_ST_NET" & _
        "_DUE_IN OR @Original_ST_NET_DUE_IN IS NULL AND ST_NET_DUE_IN IS NULL); SELECT AR" & _
        "_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, D" & _
        "D_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WI" & _
        "THIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms =" & _
        " @AR_terms)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO inv_vendor (cod_vendor, desc_vendor, address, zipcode, phone_1, exten" & _
        "sion_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_ma" & _
        "in_2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, ph" & _
        "one_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, emai" & _
        "l, www, federal_tax_id, social_security_no, vendor_type, class_vendor, buyer_id," & _
        " vendor_since, f_1099, on_hold, inactive, notes, credit_limited, remit_to_compan" & _
        "y, remit_to_address, remit_to_zipcode, contact1, contact2, ap_terms) VALUES (@co" & _
        "d_vendor, @desc_vendor, @address, @zipcode, @phone_1, @extension_1, @phone_type_" & _
        "1, @phone_main_1, @phone_2, @extension_2, @phone_type_2, @phone_main_2, @phone_3" & _
        ", @extension_3, @phone_type_3, @phone_main_3, @phone_4, @extension_4, @phone_typ" & _
        "e_4, @phone_main_4, @phone_5, @extension_5, @phone_type_5, @phone_main_5, @email" & _
        ", @www, @federal_tax_id, @social_security_no, @vendor_type, @class_vendor, @buye" & _
        "r_id, @vendor_since, @f_1099, @on_hold, @inactive, @notes, @credit_limited, @rem" & _
        "it_to_company, @remit_to_address, @remit_to_zipcode, @contact1, @contact2, @ap_t" & _
        "erms)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor", System.Data.SqlDbType.VarChar, 50, "desc_vendor"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
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
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@www", System.Data.SqlDbType.VarChar, 50, "www"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@federal_tax_id", System.Data.SqlDbType.VarChar, 25, "federal_tax_id"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_since", System.Data.SqlDbType.VarChar, 10, "vendor_since"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_1099", System.Data.SqlDbType.Bit, 1, "f_1099"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hold", System.Data.SqlDbType.Bit, 1, "on_hold"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remit_to_company", System.Data.SqlDbType.VarChar, 50, "remit_to_company"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remit_to_address", System.Data.SqlDbType.VarChar, 100, "remit_to_address"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remit_to_zipcode", System.Data.SqlDbType.VarChar, 5, "remit_to_zipcode"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact1", System.Data.SqlDbType.VarChar, 25, "contact1"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact2", System.Data.SqlDbType.VarChar, 25, "contact2"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ap_terms", System.Data.SqlDbType.VarChar, 10, "ap_terms"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE inv_vendor SET cod_vendor = @cod_vendor, desc_vendor = @desc_vendor, addre" & _
        "ss = @address, zipcode = @zipcode, phone_1 = @phone_1, extension_1 = @extension_" & _
        "1, phone_type_1 = @phone_type_1, phone_main_1 = @phone_main_1, phone_2 = @phone_" & _
        "2, extension_2 = @extension_2, phone_type_2 = @phone_type_2, phone_main_2 = @pho" & _
        "ne_main_2, phone_3 = @phone_3, extension_3 = @extension_3, phone_type_3 = @phone" & _
        "_type_3, phone_main_3 = @phone_main_3, phone_4 = @phone_4, extension_4 = @extens" & _
        "ion_4, phone_type_4 = @phone_type_4, phone_main_4 = @phone_main_4, phone_5 = @ph" & _
        "one_5, extension_5 = @extension_5, phone_type_5 = @phone_type_5, phone_main_5 = " & _
        "@phone_main_5, email = @email, www = @www, federal_tax_id = @federal_tax_id, soc" & _
        "ial_security_no = @social_security_no, vendor_type = @vendor_type, class_vendor " & _
        "= @class_vendor, buyer_id = @buyer_id, vendor_since = @vendor_since, f_1099 = @f" & _
        "_1099, on_hold = @on_hold, inactive = @inactive, notes = @notes, credit_limited " & _
        "= @credit_limited, remit_to_company = @remit_to_company, remit_to_address = @rem" & _
        "it_to_address, remit_to_zipcode = @remit_to_zipcode, contact1 = @contact1, conta" & _
        "ct2 = @contact2, ap_terms = @ap_terms WHERE (cod_vendor = @cod_vendor)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor", System.Data.SqlDbType.VarChar, 50, "desc_vendor"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
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
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@www", System.Data.SqlDbType.VarChar, 50, "www"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@federal_tax_id", System.Data.SqlDbType.VarChar, 25, "federal_tax_id"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@class_vendor", System.Data.SqlDbType.VarChar, 3, "class_vendor"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_since", System.Data.SqlDbType.VarChar, 10, "vendor_since"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_1099", System.Data.SqlDbType.Bit, 1, "f_1099"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hold", System.Data.SqlDbType.Bit, 1, "on_hold"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remit_to_company", System.Data.SqlDbType.VarChar, 50, "remit_to_company"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remit_to_address", System.Data.SqlDbType.VarChar, 100, "remit_to_address"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remit_to_zipcode", System.Data.SqlDbType.VarChar, 5, "remit_to_zipcode"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact1", System.Data.SqlDbType.VarChar, 25, "contact1"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact2", System.Data.SqlDbType.VarChar, 25, "contact2"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ap_terms", System.Data.SqlDbType.VarChar, 10, "ap_terms"))
        '
        'CnnReader
        '
        Me.CnnReader.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_03;password=sa"
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnReader
        '
        'FrmVendor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(637, 367)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmVendor"
        Me.Text = "Vendor Information"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsFrmVendor1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub FrmVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Vendor_Cod1.CanAddNewCod = False
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnReader.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        Call FillDataSets()
        TxtVendorCod.MaxLength = LenVendorCod

        If Cod_VendorVar.Trim.Length > 0 Then
            Call PAddNew()
            TxtVendorCod.Text = Cod_VendorVar
            TxtVendorCod.Focus()
        Else
            If VendorCodTempVar.Trim.Length = 0 Then
                Call PFirstRecord(False)
            Else
                Vendor_Cod1.Text = VendorCodTempVar
                Call FillFields(Vendor_Cod1.Text)
            End If
            Call AfterSaveOrCancel()
            Vendor_Cod1.Focus()
        End If
    End Sub
    Private Sub FillDataSets()
        DsFrmVendor1.GL_TAB_AR_TERM.Clear()
        DAGL_TAB_AR_TERM.Fill(DsFrmVendor1, "GL_TAB_AR_TERM")

        DsFrmVendor1.inv_buyer.Clear()
        DAInv_Buyer.Fill(DsFrmVendor1, "inv_buyer")
        If DsFrmVendor1.inv_buyer.Rows.Count < 1 Then
            MsgFar("Please Fill The Buyer Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmVendor1.inv_tab_vendor_class.Clear()
        DAinv_tab_vendor_class.Fill(DsFrmVendor1, "inv_tab_vendor_class")

        DsFrmVendor1.inv_tab_vendor_type.Clear()
        DAinv_tab_vendor_type.Fill(DsFrmVendor1, "inv_tab_vendor_type")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        VendorCodTempVar = Vendor_Cod1.Text
        Vendor_Cod1.Text = ""
        Call ClearField()

        TxtVendorCod.Text = MakeNewVendorCod()
        TxtVendorCod.Focus()

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
        VendorCodTempVar = Vendor_Cod1.Text
        TxtVendorCod.Focus()

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
                CmdDelete.Parameters("@Cod_Vendor").Value = Vendor_Cod1.Text
                CmdDelete.ExecuteNonQuery()
                VendorCodTempVar = ""
                Call PNextRecord(False)
                If VendorCodTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If VendorCodTempVar.Trim.Length = 0 Then
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
            Vendor_Cod1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                VendorCodTempVar = PInsert()
                ChangeOK = IIf(VendorCodTempVar.Trim.Length = 0, False, True)
                If Cod_VendorVar.Trim.Length > 0 Then
                    Cod_VendorVar = TxtVendorCod.Text
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(VendorCodTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            Vendor_Cod1.Text = VendorCodTempVar
            Vendor_Cod1.Focus()
        End If
    End Sub
    Sub PCancel()
        If IsCancelForExitFlag Then
            Cod_VendorVar = TxtVendorCod.Text
            Me.Close()
        End If

        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        Vendor_Cod1.Text = VendorCodTempVar
        Call FillFields(Vendor_Cod1.Text)
        Call AfterSaveOrCancel()
        Vendor_Cod1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtVendorCod.Text.Trim.Length = 0 Then
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
    Private Sub TXTVendorCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVendorCod.TextChanged, TXTCity.TextChanged, TxtContact1.TextChanged, TxtContact2.TextChanged, TxtEmail.TextChanged, TXTFederal_tax_id.TextChanged, TxtRemit_address.TextChanged, TxtRemit_company.TextChanged, TXTSocial_Security_No.TextChanged, TxtVendorCod.TextChanged, TxtWWW.BackColorChanged, Chk1099.CheckedChanged, CHKInactive.CheckedChanged, CHKONHold.CheckedChanged, CmbAp_terms.SelectedIndexChanged, CmbBuyer.SelectedIndexChanged, CmbClass.SelectedIndexChanged, CmbType.SelectedIndexChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtVendorCod.Text.Trim.Length > 0 And TxtCompany.Text.Trim.Length > 0 Then
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
        Dim TXTSearchVendorCodTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor Order BY " & VendorOrderFieldName & " ASC"
            TXTSearchVendorCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchVendorCodTemp) Then
                TXTSearchVendorCodTemp = ""
            End If
            If TXTSearchVendorCodTemp = Vendor_Cod1.Text Or TXTSearchVendorCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                Vendor_Cod1.Text = TXTSearchVendorCodTemp
                Call FillFields(Vendor_Cod1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchVendorCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case VendorOrderFieldName.ToUpper.Trim
            Case "Cod_Vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor where Cod_Vendor<" & Qt(TxtVendorCod.Text) & " Order BY " & VendorOrderFieldName & " DESC"
            Case "desc_vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor where desc_vendor<" & Qt(TxtCompany.Text) & " Order BY " & VendorOrderFieldName & " DESC"
            Case "ZipCode".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor where ZipCode<" & Qt(ZipCode1.Text) & " Order BY " & VendorOrderFieldName & " DESC"
        End Select
        TXTSearchVendorCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchVendorCodTemp) Then
            TXTSearchVendorCodTemp = ""
        End If
        If TXTSearchVendorCodTemp = Vendor_Cod1.Text Or TXTSearchVendorCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            Vendor_Cod1.Text = TXTSearchVendorCodTemp
            VendorCodTempVar = TXTSearchVendorCodTemp
            Call FillFields(Vendor_Cod1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchVendorCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case VendorOrderFieldName.ToUpper.Trim
            Case "Cod_Vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor where Cod_Vendor>" & Qt(TxtVendorCod.Text) & " Order BY " & VendorOrderFieldName & " ASC"
            Case "desc_vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor where desc_vendor>" & Qt(TxtCompany.Text) & " Order BY " & VendorOrderFieldName & " ASC"
            Case "ZipCode".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor where ZipCode>" & Qt(ZipCode1.Text) & " Order BY " & VendorOrderFieldName & " ASC"
        End Select
        TXTSearchVendorCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchVendorCodTemp) Then
            TXTSearchVendorCodTemp = ""
        End If
        If TXTSearchVendorCodTemp = Vendor_Cod1.Text Or TXTSearchVendorCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            Vendor_Cod1.Text = TXTSearchVendorCodTemp
            VendorCodTempVar = TXTSearchVendorCodTemp
            Call FillFields(Vendor_Cod1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchVendorCodTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Cod_Vendor from Inv_Vendor Order BY " & VendorOrderFieldName & " DESC"
            TXTSearchVendorCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchVendorCodTemp) Then
                TXTSearchVendorCodTemp = ""
            End If
            If TXTSearchVendorCodTemp = Vendor_Cod1.Text Or TXTSearchVendorCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                Vendor_Cod1.Text = TXTSearchVendorCodTemp
                Call FillFields(Vendor_Cod1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Vendor_Cod1_FindVendorCod() Handles Vendor_Cod1.FindVendorCod
        Call FillFields(Vendor_Cod1.Text)
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
            Vendor_Cod1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmVendor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Vendor_Cod1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If Vendor_Cod1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@Cod_Vendor").Value = Vendor_Cod1.text
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
            TxtVendorCod.Enabled = instatus
        Else
            TxtVendorCod.Enabled = False
        End If
        TxtAddress.Enabled = instatus
        TXTCity.Enabled = instatus
        TxtCompany.Enabled = instatus
        TxtContact1.Enabled = instatus
        TxtContact2.Enabled = instatus
        NumCredit_limit.Enabled = instatus
        TxtEmail.Enabled = instatus
        TXTFederal_tax_id.Enabled = instatus
        TxtRemit_address.Enabled = instatus
        TxtRemit_company.Enabled = instatus
        TXTRemitCity.Enabled = instatus
        TxtRemitSt.Enabled = instatus
        TXTSocial_Security_No.Enabled = instatus
        TxtSt.Enabled = instatus
        TxtWWW.Enabled = instatus
        ZipCode1.Enabled = instatus
        ZipCode2.Enabled = instatus
        CmbAp_terms.Enabled = instatus
        CmbBuyer.Enabled = instatus
        CmbClass.Enabled = instatus
        CmbType.Enabled = instatus
        Chk1099.Enabled = instatus
        CHKInactive.Enabled = instatus
        CHKONHold.Enabled = instatus
        PhoneNoMain.Enabled = instatus
        PhoneButton1.ZEnabled = instatus
    End Sub
    Friend Sub ClearField()
        TxtAddress.Text = ""
        TXTCity.Text = ""
        TxtCompany.Text = ""
        TxtContact1.Text = ""
        TxtContact2.Text = ""
        LblCredit_Balance.Text = ""
        NumCredit_limit.Text = 0
        LblCredit_Remaining.Text = ""
        TxtEmail.Text = ""
        TXTFederal_tax_id.Text = ""
        LblLastPaymentAmount.Text = ""
        LblLastPaymentCheckNo.Text = ""
        LblLastPaymentDate.Text = ""
        LblLastPurchaseAmount.Text = ""
        LblLastPurchaseDate.Text = ""
        LblLastPurchaseInvoiceNo.Text = ""
        LblNextPaymentAmount.Text = ""
        LblNextPaymentDate.Text = ""
        TxtRemit_address.Text = ""
        TxtRemit_company.Text = ""
        TXTRemitCity.Text = ""
        TxtRemitSt.Text = ""
        TXTSocial_Security_No.Text = ""
        TxtSt.Text = ""
        TxtVendorCod.Text = ""
        TxtVendorCod.Text = ""
        TxtWWW.Text = ""
        ZipCode1.Text = ""
        ZipCode2.Text = ""
        VendorNoteVar = ""
        LblVendor_since.Text = Format(Now.Date, PubDateFormat)
        Chk1099.Checked = False
        CHKInactive.Checked = False
        CHKONHold.Checked = False
        PhoneNoMain.Text = ""
        Call PhoneButton1.ClearPhoneScreen()
        Try
            CmbAp_terms.SelectedValue = "0"
            CmbBuyer.SelectedValue = "0"
            CmbClass.SelectedValue = "0"
            CmbType.SelectedValue = "0"
        Catch ex As Exception
        End Try

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveServiceSetupTable(PubStoreNO)
        Try
            CmbAp_terms.SelectedValue = OleDbReaderForStore.Item("VENDOR_AP_TERM") & ""
        Catch ex As Exception
            CmbAp_terms.SelectedValue = 0
        End Try
        Try
            CmbType.SelectedValue = OleDbReaderForStore.Item("VENDOR_TYPE") & ""
        Catch ex As Exception
            CmbType.SelectedValue = 0
        End Try
        Try
            CmbClass.SelectedValue = OleDbReaderForStore.Item("VENDOR_CLASS") & ""
        Catch ex As Exception
            CmbClass.SelectedValue = 0
        End Try
        Try
            CmbBuyer.SelectedValue = OleDbReaderForStore.Item("VENDOR_BUYER") & ""
        Catch ex As Exception
            CmbBuyer.SelectedValue = 0
        End Try
        OleDbReaderForStore.Close()

    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            If CmdInsert.Connection.State <> ConnectionState.Open Then
                CmdInsert.Connection.Open()
            End If
            CmdInsert.Parameters("@address").Value = TxtAddress.Text
            CmdInsert.Parameters("@desc_vendor").Value = TxtCompany.Text
            CmdInsert.Parameters("@Contact1").Value = TxtContact1.Text
            CmdInsert.Parameters("@Contact2").Value = TxtContact2.Text
            CmdInsert.Parameters("@phone_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_1")
            CmdInsert.Parameters("@extension_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_1")
            CmdInsert.Parameters("@phone_type_1").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_1"))
            CmdInsert.Parameters("@phone_main_1").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_1"))
            CmdInsert.Parameters("@phone_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_2")
            CmdInsert.Parameters("@extension_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_2")
            CmdInsert.Parameters("@phone_type_2").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_2"))
            CmdInsert.Parameters("@phone_main_2").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_2"))
            CmdInsert.Parameters("@phone_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_3")
            CmdInsert.Parameters("@extension_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_3")
            CmdInsert.Parameters("@phone_type_3").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_3"))
            CmdInsert.Parameters("@phone_main_3").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_3"))
            CmdInsert.Parameters("@phone_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_4")
            CmdInsert.Parameters("@extension_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_4")
            CmdInsert.Parameters("@phone_type_4").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_4"))
            CmdInsert.Parameters("@phone_main_4").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_4"))
            CmdInsert.Parameters("@phone_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_5")
            CmdInsert.Parameters("@extension_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_5")
            CmdInsert.Parameters("@phone_type_5").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_5"))
            CmdInsert.Parameters("@phone_main_5").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_5"))
            CmdInsert.Parameters("@credit_limited").Value = Val(NumCredit_limit.Text)
            CmdInsert.Parameters("@email").Value = TxtEmail.Text
            CmdInsert.Parameters("@federal_tax_id").Value = TXTFederal_tax_id.Text
            CmdInsert.Parameters("@remit_to_address").Value = TxtRemit_address.Text
            CmdInsert.Parameters("@remit_to_company").Value = TxtRemit_company.Text
            CmdInsert.Parameters("@social_security_no").Value = TXTSocial_Security_No.Text
            CmdInsert.Parameters("@vendor_since").Value = LblVendor_since.Text
            CmdInsert.Parameters("@cod_vendor").Value = TxtVendorCod.Text
            CmdInsert.Parameters("@WWW").Value = TxtWWW.Text
            CmdInsert.Parameters("@f_1099").Value = IIf(Chk1099.Checked, 1, 0)
            CmdInsert.Parameters("@inactive").Value = IIf(CHKInactive.Checked, 1, 0)
            CmdInsert.Parameters("@on_hold").Value = IIf(CHKONHold.Checked, 1, 0)
            CmdInsert.Parameters("@Ap_terms").Value = ChkCombo(CmbAp_terms.SelectedValue)
            CmdInsert.Parameters("@buyer_id").Value = ChkCombo(CmbBuyer.SelectedValue)
            CmdInsert.Parameters("@class_vendor").Value = ChkCombo(CmbClass.SelectedValue)
            CmdInsert.Parameters("@vendor_type").Value = ChkCombo(CmbType.SelectedValue)
            CmdInsert.Parameters("@ZipCode").Value = IIf(ZipCode1.Text.Trim.Length > 0, ZipCode1.Text, System.DBNull.Value)
            CmdInsert.Parameters("@remit_to_ZipCode").Value = IIf(ZipCode2.Text.Trim.Length > 0, ZipCode2.Text, System.DBNull.Value)
            CmdInsert.Parameters("@notes").Value = VendorNoteVar
            CmdInsert.ExecuteNonQuery()
            PInsert = TxtVendorCod.Text
            CmdInsert.Connection.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisCod_Vendor As String) As Boolean
        PUpdate = True
        Try
            If CmdUpdate.Connection.State <> ConnectionState.Open Then
                CmdUpdate.Connection.Open()
            End If
            CmdUpdate.Parameters("@address").Value = TxtAddress.Text
            CmdUpdate.Parameters("@desc_vendor").Value = TxtCompany.Text
            CmdUpdate.Parameters("@Contact1").Value = TxtContact1.Text
            CmdUpdate.Parameters("@Contact2").Value = TxtContact2.Text
            CmdUpdate.Parameters("@phone_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_1")
            CmdUpdate.Parameters("@extension_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_1")
            CmdUpdate.Parameters("@phone_type_1").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_1"))
            CmdUpdate.Parameters("@phone_main_1").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_1"))
            CmdUpdate.Parameters("@phone_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_2")
            CmdUpdate.Parameters("@extension_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_2")
            CmdUpdate.Parameters("@phone_type_2").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_2"))
            CmdUpdate.Parameters("@phone_main_2").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_2"))
            CmdUpdate.Parameters("@phone_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_3")
            CmdUpdate.Parameters("@extension_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_3")
            CmdUpdate.Parameters("@phone_type_3").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_3"))
            CmdUpdate.Parameters("@phone_main_3").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_3"))
            CmdUpdate.Parameters("@phone_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_4")
            CmdUpdate.Parameters("@extension_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_4")
            CmdUpdate.Parameters("@phone_type_4").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_4"))
            CmdUpdate.Parameters("@phone_main_4").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_4"))
            CmdUpdate.Parameters("@phone_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_5")
            CmdUpdate.Parameters("@extension_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_5")
            CmdUpdate.Parameters("@phone_type_5").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_5"))
            CmdUpdate.Parameters("@phone_main_5").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_5"))
            CmdUpdate.Parameters("@credit_limited").Value = Val(NumCredit_limit.Text)
            CmdUpdate.Parameters("@email").Value = TxtEmail.Text
            CmdUpdate.Parameters("@federal_tax_id").Value = TXTFederal_tax_id.Text
            CmdUpdate.Parameters("@remit_to_address").Value = TxtRemit_address.Text
            CmdUpdate.Parameters("@remit_to_company").Value = TxtRemit_company.Text
            CmdUpdate.Parameters("@social_security_no").Value = TXTSocial_Security_No.Text
            CmdUpdate.Parameters("@vendor_since").Value = LblVendor_since.Text
            CmdUpdate.Parameters("@cod_vendor").Value = TxtVendorCod.Text
            CmdUpdate.Parameters("@WWW").Value = TxtWWW.Text
            CmdUpdate.Parameters("@f_1099").Value = IIf(Chk1099.Checked, 1, 0)
            CmdUpdate.Parameters("@inactive").Value = IIf(CHKInactive.Checked, 1, 0)
            CmdUpdate.Parameters("@on_hold").Value = IIf(CHKONHold.Checked, 1, 0)
            CmdUpdate.Parameters("@Ap_terms").Value = ChkCombo(CmbAp_terms.SelectedValue)
            CmdUpdate.Parameters("@buyer_id").Value = ChkCombo(CmbBuyer.SelectedValue)
            CmdUpdate.Parameters("@class_vendor").Value = ChkCombo(CmbClass.SelectedValue)
            CmdUpdate.Parameters("@vendor_type").Value = ChkCombo(CmbType.SelectedValue)
            CmdUpdate.Parameters("@ZipCode").Value = IIf(ZipCode1.Text.Trim.Length > 0, ZipCode1.Text, System.DBNull.Value)
            CmdUpdate.Parameters("@remit_to_ZipCode").Value = IIf(ZipCode2.Text.Trim.Length > 0, ZipCode2.Text, System.DBNull.Value)
            CmdUpdate.Parameters("@notes").Value = VendorNoteVar
            CmdUpdate.ExecuteNonQuery()
            CmdUpdate.Connection.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal ThisCod_Vendor As String) As Boolean
        FillFields = False
        If ThisCod_Vendor.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from Inv_Vendor where Cod_Vendor=" & Qt(ThisCod_Vendor)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                TxtAddress.Text = Trim(SQLReader.Item("address") & "")
                TxtCompany.Text = Trim(SQLReader.Item("desc_vendor") & "")
                TxtContact1.Text = Trim(SQLReader.Item("Contact1") & "")
                TxtContact2.Text = Trim(SQLReader.Item("Contact2") & "")
                NumCredit_limit.Text = SQLReader.Item("credit_limited")
                TxtEmail.Text = Trim(SQLReader.Item("email") & "")
                TXTFederal_tax_id.Text = Trim(SQLReader.Item("federal_tax_id") & "")
                TxtRemit_address.Text = Trim(SQLReader.Item("remit_to_address") & "")
                TxtRemit_company.Text = Trim(SQLReader.Item("remit_to_company") & "")
                TXTSocial_Security_No.Text = Trim(SQLReader.Item("social_security_no") & "")
                LblVendor_since.Text = Trim(SQLReader.Item("vendor_since") & "")
                TxtVendorCod.Text = Trim(SQLReader.Item("cod_vendor") & "")
                TxtWWW.Text = Trim(SQLReader.Item("WWW") & "")
                Chk1099.Checked = Trim(SQLReader.Item("f_1099") & "")
                CHKInactive.Checked = Trim(SQLReader.Item("inactive") & "")
                CHKONHold.Checked = Trim(SQLReader.Item("on_hold") & "")
                CmbAp_terms.SelectedValue = Trim(SQLReader.Item("Ap_terms") & "")
                CmbBuyer.SelectedValue = Trim(SQLReader.Item("buyer_id") & "")
                CmbClass.SelectedValue = Trim(SQLReader.Item("class_vendor") & "")
                CmbType.SelectedValue = Trim(SQLReader.Item("vendor_type") & "")
                VendorNoteVar = Trim(SQLReader.Item("Notes") & "")
                Dim Ziptemp1 As String = Trim(SQLReader.Item("ZipCode") & "")
                Dim Ziptemp2 As String = Trim(SQLReader.Item("remit_to_ZipCode") & "")
                ZipCode1.Text = Ziptemp1
                ZipCode2.Text = Ziptemp2
                '''''''''''''''''''''''''''''''''''''''
                PhoneButton1.FillDataSet("Inv_Vendor", "Cod_Vendor=" & Qt(ThisCod_Vendor))
                PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
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
        Try
            Call FillOtherFields()
        Catch ex As Exception
        End Try
    End Function
    Private Sub FillOtherFields()
        If TxtVendorCod.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        CmdGeneralForReader.CommandText = "SELECT top 1 Inv_Receive_Products_head.date_receive, Inv_Receive_Products_head.vendor_ref_no, View_RecieveReturnTotal.TotalPrice FROM  Inv_Receive_Products_head INNER JOIN View_RecieveReturnTotal ON Inv_Receive_Products_head.id_receive_ref = View_RecieveReturnTotal.id_receive_ref Where Inv_Receive_Products_head.bill_credit='1' AND Inv_Receive_Products_head.cod_vendor=" & Qt(TxtVendorCod.Text) & " Order by dbo.changedate(Inv_Receive_Products_head.date_receive) Desc"
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            Try
                LblLastPurchaseAmount.Text = SQLReader.Item("TotalPrice")
            Catch ex As Exception
                LblLastPurchaseAmount.Text = 0
            End Try
            LblLastPurchaseDate.Text = Trim(SQLReader.Item("date_receive") & "")
            LblLastPurchaseInvoiceNo.Text = Trim(SQLReader.Item("vendor_ref_no") & "")
        Else
            LblLastPurchaseAmount.Text = ""
            LblLastPurchaseDate.Text = ""
            LblLastPurchaseInvoiceNo.Text = ""
        End If
        SQLReader.Close()

        CmdGeneralForReader.CommandText = "SELECT sum(GL_AP_payment.amount_pay) as amount_pay, GL_AP_payment.date_prepare FROM View_AllVendorPaid INNER JOIN GL_AP_payment ON View_AllVendorPaid.ID_AP_payment = GL_AP_payment.ID_AP_payment Where View_AllVendorPaid.cod_vendor=" & Qt(TxtVendorCod.Text) & " GROUP BY GL_AP_payment.date_prepare "
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            Try
                LblNextPaymentAmount.Text = SQLReader.Item("amount_pay")
            Catch ex As Exception
                LblNextPaymentAmount.Text = 0
            End Try
            LblNextPaymentDate.Text = Trim(SQLReader.Item("date_prepare") & "")
        Else
            LblNextPaymentAmount.Text = ""
            LblNextPaymentDate.Text = ""
        End If
        SQLReader.Close()

        CmdGeneralForReader.CommandText = "SELECT  Top 1 amount_check , date_of_check , no_of_check FROM bank_check Where cod_vendor=" & Qt(TxtVendorCod.Text) & " Order by dbo.changedate(date_of_check) Desc"
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            Try
                LblLastPaymentAmount.Text = SQLReader.Item("amount_check")
            Catch ex As Exception
                LblLastPaymentAmount.Text = 0
            End Try
            LblLastPaymentCheckNo.Text = Trim(SQLReader.Item("no_of_check") & "")
            LblLastPaymentDate.Text = Trim(SQLReader.Item("date_of_check") & "")
        Else
            LblLastPaymentAmount.Text = ""
            LblLastPaymentCheckNo.Text = ""
            LblLastPaymentDate.Text = ""
        End If
        SQLReader.Close()

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT isnull(BalanceAmount,0) FROM View_Vendor_Balance WHERE cod_vendor=" & Qt(Vendor_Cod1.cod_vendor)
        LblCredit_Balance.Text = CmdGeneral.ExecuteScalar()

        LblCredit_Remaining.Text = NumCredit_limit.Numbervalue - LblCredit_Balance.Numbervalue
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
        MyFrmItemComments.TxtComments.Text = VendorNoteVar & ""
        Call FitToScreen(btnNotes, MyFrmItemComments)
        MyFrmItemComments.TxtComments.MaxLength = 300
        MyFrmItemComments.ThisFormStatus = Status
        MyFrmItemComments.ShowDialog()
        VendorNoteVar = MyFrmItemComments.TxtCommentvar
        Call SaveButtonControl()
    End Sub
    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        Dim MyFrmVendorHistory As New FrmVendorHistory
        MyFrmVendorHistory.cod_vendorParameter = TxtVendorCod.Text
        MyFrmVendorHistory.LblCompany.Text = Vendor_Cod1.Desc_Vendor
        MyFrmVendorHistory.ShowDialog()
    End Sub
    Private Sub BtnVendorBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVendorBalance.Click
        Dim MyFrmVendorBalance As New FrmVendorBalance
        MyFrmVendorBalance.cod_vendorParameter = Vendor_Cod1.VendorCod
        MyFrmVendorBalance.LblVendor.Text = Vendor_Cod1.VendorCod
        MyFrmVendorBalance.LblName.Text = Vendor_Cod1.Desc_Vendor
        MyFrmVendorBalance.ShowDialog()
    End Sub
    Private Sub NumCredit_limit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumCredit_limit.TextChanged, LblCredit_Balance.TextChanged
        LblCredit_Remaining.Text = Val(NumCredit_limit.Text) - Val(LblCredit_Balance.Text)
        Call SaveButtonControl()
    End Sub
    Private Sub TxtCompany_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCompany.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub TxtCompany_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCompany.LostFocus
        If TxtRemit_company.Text.Trim.Length = 0 Then
            TxtRemit_company.Text = TxtCompany.Text
        End If
    End Sub
    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub TxtAddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAddress.LostFocus
        If TxtRemit_address.Text.Trim.Length = 0 Then
            TxtRemit_address.Text = TxtAddress.Text
        End If
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        TXTCity.Text = ZipCode1.City
        TxtSt.Text = ZipCode1.State
        Call SaveButtonControl()
    End Sub
    Private Sub ZipCode1_NotFindZipCode() Handles ZipCode1.NotFindZipCode
        TXTCity.Text = ""
        TxtSt.Text = ""
        Call SaveButtonControl()
    End Sub
    Private Sub ZipCode1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZipCode1.LostFocus
        If TXTRemitCity.Text.Trim.Length = 0 Then
            ZipCode2.Text = ZipCode1.Text
        End If
    End Sub
    Private Sub ZipCode2_FindZipCode() Handles ZipCode2.FindZipCode
        TXTRemitCity.Text = ZipCode2.City
        TxtRemitSt.Text = ZipCode2.State
        Call SaveButtonControl()
    End Sub
    Private Sub ZipCode2_NotFindZipCode() Handles ZipCode2.NotFindZipCode
        TXTRemitCity.Text = ""
        TxtRemitSt.Text = ""
        Call SaveButtonControl()
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UIContextMenu1.CommandClick
        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                VendorOrderFieldName = "Cod_Vendor"
            Case "SORT2"
                VendorOrderFieldName = "desc_vendor"
            Case "SORT3"
                VendorOrderFieldName = "ZipCode"
        End Select
    End Sub
    Private Sub TxtVendorCod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtVendorCod.LostFocus
        Try
            MyClsVendorCod.Connection = Cnn
        Catch ex As Exception
        End Try
        If MyClsVendorCod.FindDesc(TxtVendorCod.Text) Then
            MsgBox("This Vendor Code already axist.Try a new Code")
            TxtVendorCod.Clear()
            TxtVendorCod.Focus()
        End If
    End Sub
    Public Function MakeNewVendorCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_vendor) as Max_cod from inv_vendor where substring(cod_vendor,1,1)='V' AND substring(cod_vendor,2,1)>='0' AND substring(cod_vendor,2,1)<='9'"
            MakeNewVendorCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewVendorCod, LenVendorCod)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewVendorCod.Length >= i Then
                MakeNewVendorCod = Mid(MakeNewVendorCod, 1, Len(MakeNewVendorCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewVendorCod.Trim.Length > LenVendorCod Then
                MakeNewVendorCod = "V00001"
            End If
        Catch ex As Exception
            MakeNewVendorCod = "V00001"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Sub PhoneButton1_PhoneScreenAfterClose() Handles PhoneButton1.PhoneScreenAfterClose
        PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
    End Sub
    Private Sub PhoneNoMain_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneNoMain.TextChanged
        Call PhoneButton1.GetPhoneNoMain(PhoneNoMain.Text)
        Call SaveButtonControl()
    End Sub
    Private Sub PhoneButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneButton1.Click
        PhoneButton1.HeaderName = TxtCompany.Text.Trim
        Call SaveButtonControl()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmSearchVendorCod.ShowDialog()
    End Sub
    Private Sub MyFrmSearchVendorCod_VendorCodFind(ByVal ThisVendorCod As String, ByVal ThisDesc_Vendor As String) Handles MyFrmSearchVendorCod.vendorFind
        Vendor_Cod1.VendorCod = ThisVendorCod
    End Sub
End Class
