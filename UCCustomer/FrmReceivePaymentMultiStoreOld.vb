Imports Janus.Windows.GridEX
Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmReceivePaymentMultiStoreOld
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim ReceivePaymentOrderFieldName As String = "Refrence_No"
    Dim ReceivePaymentOrderVar1 As String = "Refrence_No"
    Dim ReceivePaymentOrderVar2 As String = ""
    Friend ReferenceNoTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public Refrence_NoVar As String = ""
    Public Refrence_NoForShowReadOnly As String = ""
    Dim MyClsReceivePayment As New ClsReceivePayment
    Dim ID_paymentVar As Decimal
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Dim OldReferenceNo As String = ""
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
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Command2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Command21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SortByType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UIContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RdoCash As System.Windows.Forms.RadioButton
    Public WithEvents TxtCc_no As System.Windows.Forms.TextBox
    Friend WithEvents CmbCc_type As System.Windows.Forms.ComboBox
    Friend WithEvents NumAmount_Receive As CalcUtils.UcCalcText
    Public WithEvents TxtRemark As System.Windows.Forms.TextBox
    Public WithEvents TxtCheck_no As System.Windows.Forms.TextBox
    Friend WithEvents CmbGl_account As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents TxtRefrence_no As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents NumYear As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents NumMonth As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RdoCreditCard As System.Windows.Forms.RadioButton
    Friend WithEvents RdoCheck As System.Windows.Forms.RadioButton
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort32 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Reference_No1 As Reference_No
    Friend WithEvents BtnUnApplyPayment As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAutoApply As Janus.Windows.EditControls.UIButton
    Friend WithEvents DsFrmReceivePayment1 As DSFrmReceivePayment
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnFax As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents BtnSortOrder As Janus.Windows.EditControls.UIButton
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
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents Dtedate_receive_payment As CalendarCombo.CalendarCombo
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents LblBalance As CalcUtils.UcCalcText
    Friend WithEvents lblTotalPayment As CalcUtils.UcCalcText
    Friend WithEvents lblAmountDue As CalcUtils.UcCalcText
    Friend WithEvents lblApplied As CalcUtils.UcCalcText
    Friend WithEvents LblTotalOriginalAmount As CalcUtils.UcCalcText
    Friend WithEvents LblTotalAmountDue As CalcUtils.UcCalcText
    Friend WithEvents TxtAuthNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents BtnCustomerBalance As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NumAmountForOtherStore As CalcUtils.UcCalcText
    Friend WithEvents BtnOtherStorePayment As System.Windows.Forms.Button
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents GrdOtherStorePayment As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdDeleteOtherStore As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_depositOtherStore As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit_Detail As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmReceivePaymentMultiStoreOld))
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
        Me.Reference_No1 = New UCCustomer.Reference_No
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GrdOtherStorePayment = New Janus.Windows.GridEX.GridEX
        Me.DsFrmReceivePayment1 = New UCCustomer.DSFrmReceivePayment
        Me.BtnOtherStorePayment = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.NumAmountForOtherStore = New CalcUtils.UcCalcText
        Me.BtnCustomerBalance = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtAuthNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.LblBalance = New CalcUtils.UcCalcText
        Me.NumMonth = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.NumYear = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.TxtRefrence_no = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtCc_no = New System.Windows.Forms.TextBox
        Me.CmbCc_type = New System.Windows.Forms.ComboBox
        Me.NumAmount_Receive = New CalcUtils.UcCalcText
        Me.TxtRemark = New System.Windows.Forms.TextBox
        Me.TxtCheck_no = New System.Windows.Forms.TextBox
        Me.Dtedate_receive_payment = New CalendarCombo.CalendarCombo
        Me.CmbGl_account = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RdoCreditCard = New System.Windows.Forms.RadioButton
        Me.RdoCheck = New System.Windows.Forms.RadioButton
        Me.RdoCash = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblApplied = New CalcUtils.UcCalcText
        Me.lblAmountDue = New CalcUtils.UcCalcText
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LblTotalAmountDue = New CalcUtils.UcCalcText
        Me.lblTotalPayment = New CalcUtils.UcCalcText
        Me.LblTotalOriginalAmount = New CalcUtils.UcCalcText
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.BtnUnApplyPayment = New Janus.Windows.EditControls.UIButton
        Me.BtnAutoApply = New Janus.Windows.EditControls.UIButton
        Me.Label18 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.SortByType1 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.Command2 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Command21 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAService_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlHead = New System.Windows.Forms.Panel
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnFax = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
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
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.CnnForReader = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.CmdDeleteOtherStore = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_depositOtherStore = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit_Detail = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdOtherStorePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmReceivePayment1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlHead.SuspendLayout()
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
        Me.CmdDelete.CommandText = "DELETE FROM Gl_receive_payment WHERE (refrence_no = @refrence_no)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.Reference_No1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(634, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'Reference_No1
        '
        Me.Reference_No1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reference_No1.Connection = Me.Cnn
        Me.Reference_No1.Location = New System.Drawing.Point(78, 1)
        Me.Reference_No1.Name = "Reference_No1"
        Me.Reference_No1.NotExitIfNotFound = False
        Me.Reference_No1.ReferenceNoLen = 8
        Me.Reference_No1.ReferencNo = ""
        Me.Reference_No1.ReleaseIfNotFoundReferenceNo = False
        Me.Reference_No1.Size = New System.Drawing.Size(101, 20)
        Me.Reference_No1.TabIndex = 189
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(5, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Reference No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.GrdDetail)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel5)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(634, 366)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GrdOtherStorePayment)
        Me.Panel1.Controls.Add(Me.BtnOtherStorePayment)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.NumAmountForOtherStore)
        Me.Panel1.Controls.Add(Me.BtnCustomerBalance)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtAuthNo)
        Me.Panel1.Controls.Add(Me.LblBalance)
        Me.Panel1.Controls.Add(Me.NumMonth)
        Me.Panel1.Controls.Add(Me.NumYear)
        Me.Panel1.Controls.Add(Me.CustomerCod1)
        Me.Panel1.Controls.Add(Me.TxtRefrence_no)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtCc_no)
        Me.Panel1.Controls.Add(Me.CmbCc_type)
        Me.Panel1.Controls.Add(Me.NumAmount_Receive)
        Me.Panel1.Controls.Add(Me.TxtRemark)
        Me.Panel1.Controls.Add(Me.TxtCheck_no)
        Me.Panel1.Controls.Add(Me.Dtedate_receive_payment)
        Me.Panel1.Controls.Add(Me.CmbGl_account)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblCustomerName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RdoCreditCard)
        Me.Panel1.Controls.Add(Me.RdoCheck)
        Me.Panel1.Controls.Add(Me.RdoCash)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 165)
        Me.Panel1.TabIndex = 0
        '
        'GrdOtherStorePayment
        '
        Me.GrdOtherStorePayment.DataMember = "Store_Setup"
        Me.GrdOtherStorePayment.DataSource = Me.DsFrmReceivePayment1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Store_Setup</Caption><Columns Collection=""t" & _
        "rue""><Column0 ID=""STORE""><Caption>No</Caption><TypeNameEmptyStringValue>System.S" & _
        "tring</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>STORENO</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>NoEdit</FilterEditType><Key>STORE" & _
        "</Key><Position>0</Position><Width>28</Width></Column0><Column1 ID=""STORENAME""><" & _
        "Caption>STORENAME</Caption><DataMember>STORENAME</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>NoEdit</FilterEditType><Key>STORENAME</Key><Position>1</" & _
        "Position><Visible>False</Visible></Column1><Column2 ID=""SHORTNAME""><Caption>NAME" & _
        "</Caption><DataMember>SHORTNAME</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>NoEdit</FilterEditType><Key>SHORTNAME</Key><Position>2</Position><Visible" & _
        ">False</Visible></Column2><Column3 ID=""Amount""><Caption>Amount</Caption><DataMem" & _
        "ber>Amount</DataMember><EditType>NoEdit</EditType><FilterEditType>NoEdit</Filter" & _
        "EditType><FormatString>c2</FormatString><Key>Amount</Key><Position>3</Position><" & _
        "TextAlignment>Far</TextAlignment><Width>88</Width></Column3></Columns><GroupCond" & _
        "ition ID="""" /><Key>Store_Setup</Key></RootTable></GridEXLayoutData>"
        Me.GrdOtherStorePayment.DesignTimeLayout = GridEXLayout1
        Me.GrdOtherStorePayment.GroupByBoxVisible = False
        Me.GrdOtherStorePayment.Location = New System.Drawing.Point(491, 47)
        Me.GrdOtherStorePayment.Name = "GrdOtherStorePayment"
        Me.GrdOtherStorePayment.Size = New System.Drawing.Size(141, 115)
        Me.GrdOtherStorePayment.TabIndex = 457
        Me.GrdOtherStorePayment.Visible = False
        '
        'DsFrmReceivePayment1
        '
        Me.DsFrmReceivePayment1.DataSetName = "DSFrmReceivePayment"
        Me.DsFrmReceivePayment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'BtnOtherStorePayment
        '
        Me.BtnOtherStorePayment.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnOtherStorePayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnOtherStorePayment.Location = New System.Drawing.Point(434, 47)
        Me.BtnOtherStorePayment.Name = "BtnOtherStorePayment"
        Me.BtnOtherStorePayment.Size = New System.Drawing.Size(56, 21)
        Me.BtnOtherStorePayment.TabIndex = 456
        Me.BtnOtherStorePayment.TabStop = False
        Me.BtnOtherStorePayment.Text = "Detail"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(207, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 22)
        Me.Label15.TabIndex = 455
        Me.Label15.Text = "Total Other Store Pay"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumAmountForOtherStore
        '
        Me.NumAmountForOtherStore.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmountForOtherStore.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmountForOtherStore.DecimalDigits = 2
        Me.NumAmountForOtherStore.DefaultSendValue = False
        Me.NumAmountForOtherStore.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmountForOtherStore.FireTabAfterEnter = True
        Me.NumAmountForOtherStore.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumAmountForOtherStore.Image = CType(resources.GetObject("NumAmountForOtherStore.Image"), System.Drawing.Image)
        Me.NumAmountForOtherStore.Location = New System.Drawing.Point(321, 47)
        Me.NumAmountForOtherStore.Maxlength = 10
        Me.NumAmountForOtherStore.MinusColor = System.Drawing.Color.Empty
        Me.NumAmountForOtherStore.Name = "NumAmountForOtherStore"
        Me.NumAmountForOtherStore.ReadOnly = True
        Me.NumAmountForOtherStore.Size = New System.Drawing.Size(109, 22)
        Me.NumAmountForOtherStore.TabIndex = 454
        Me.NumAmountForOtherStore.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmountForOtherStore.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'BtnCustomerBalance
        '
        Me.BtnCustomerBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnCustomerBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCustomerBalance.Location = New System.Drawing.Point(511, 3)
        Me.BtnCustomerBalance.Name = "BtnCustomerBalance"
        Me.BtnCustomerBalance.Size = New System.Drawing.Size(89, 21)
        Me.BtnCustomerBalance.TabIndex = 453
        Me.BtnCustomerBalance.TabStop = False
        Me.BtnCustomerBalance.Text = "Balance"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(315, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 21)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Authorization code"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAuthNo
        '
        Me.TxtAuthNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAuthNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAuthNo.Enabled = False
        Me.TxtAuthNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtAuthNo.Location = New System.Drawing.Point(428, 140)
        Me.TxtAuthNo.MaxLength = 12
        Me.TxtAuthNo.Name = "TxtAuthNo"
        Me.TxtAuthNo.Size = New System.Drawing.Size(144, 20)
        Me.TxtAuthNo.TabIndex = 15
        Me.TxtAuthNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LblBalance
        '
        Me.LblBalance.BackColor = System.Drawing.Color.Gold
        Me.LblBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblBalance.DecimalDigits = 2
        Me.LblBalance.DefaultSendValue = False
        Me.LblBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblBalance.FireTabAfterEnter = True
        Me.LblBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBalance.Image = CType(resources.GetObject("LblBalance.Image"), System.Drawing.Image)
        Me.LblBalance.Location = New System.Drawing.Point(511, 25)
        Me.LblBalance.Maxlength = 12
        Me.LblBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.ReadOnly = True
        Me.LblBalance.Size = New System.Drawing.Size(89, 21)
        Me.LblBalance.TabIndex = 452
        Me.LblBalance.TabStop = False
        Me.LblBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumMonth
        '
        Me.NumMonth.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumMonth.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumMonth.DecimalDigits = 0
        Me.NumMonth.FormatString = "##"
        Me.NumMonth.Location = New System.Drawing.Point(428, 117)
        Me.NumMonth.MaxLength = 2
        Me.NumMonth.Name = "NumMonth"
        Me.NumMonth.Size = New System.Drawing.Size(29, 20)
        Me.NumMonth.TabIndex = 11
        Me.NumMonth.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumMonth.Value = CType(0, Short)
        Me.NumMonth.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'NumYear
        '
        Me.NumYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumYear.DecimalDigits = 0
        Me.NumYear.FormatString = "####"
        Me.NumYear.Location = New System.Drawing.Point(470, 117)
        Me.NumYear.MaxLength = 4
        Me.NumYear.Name = "NumYear"
        Me.NumYear.Size = New System.Drawing.Size(55, 20)
        Me.NumYear.TabIndex = 13
        Me.NumYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumYear.Value = CType(0, Short)
        Me.NumYear.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.CnnTemp
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Location = New System.Drawing.Point(73, 25)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(128, 20)
        Me.CustomerCod1.TabIndex = 1
        '
        'TxtRefrence_no
        '
        Me.TxtRefrence_no.Location = New System.Drawing.Point(73, 2)
        Me.TxtRefrence_no.MaxLength = 8
        Me.TxtRefrence_no.Name = "TxtRefrence_no"
        Me.TxtRefrence_no.Size = New System.Drawing.Size(117, 20)
        Me.TxtRefrence_no.TabIndex = 0
        Me.TxtRefrence_no.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(-20, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 21)
        Me.Label12.TabIndex = 342
        Me.Label12.Text = "Reference No."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCc_no
        '
        Me.TxtCc_no.Location = New System.Drawing.Point(73, 140)
        Me.TxtCc_no.MaxLength = 25
        Me.TxtCc_no.Name = "TxtCc_no"
        Me.TxtCc_no.Size = New System.Drawing.Size(162, 20)
        Me.TxtCc_no.TabIndex = 14
        Me.TxtCc_no.Text = ""
        '
        'CmbCc_type
        '
        Me.CmbCc_type.DataSource = Me.DsFrmReceivePayment1.bas_cc_type
        Me.CmbCc_type.DisplayMember = "cc_type_desc"
        Me.CmbCc_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCc_type.Location = New System.Drawing.Point(73, 118)
        Me.CmbCc_type.Name = "CmbCc_type"
        Me.CmbCc_type.Size = New System.Drawing.Size(162, 21)
        Me.CmbCc_type.TabIndex = 10
        Me.CmbCc_type.ValueMember = "cc_type"
        '
        'NumAmount_Receive
        '
        Me.NumAmount_Receive.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount_Receive.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmount_Receive.DecimalDigits = 2
        Me.NumAmount_Receive.DefaultSendValue = False
        Me.NumAmount_Receive.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmount_Receive.FireTabAfterEnter = True
        Me.NumAmount_Receive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumAmount_Receive.Image = CType(resources.GetObject("NumAmount_Receive.Image"), System.Drawing.Image)
        Me.NumAmount_Receive.Location = New System.Drawing.Point(73, 48)
        Me.NumAmount_Receive.Maxlength = 10
        Me.NumAmount_Receive.MinusColor = System.Drawing.Color.Empty
        Me.NumAmount_Receive.Name = "NumAmount_Receive"
        Me.NumAmount_Receive.Size = New System.Drawing.Size(109, 22)
        Me.NumAmount_Receive.TabIndex = 3
        Me.NumAmount_Receive.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmount_Receive.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(73, 71)
        Me.TxtRemark.MaxLength = 100
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(254, 20)
        Me.TxtRemark.TabIndex = 4
        Me.TxtRemark.Text = ""
        '
        'TxtCheck_no
        '
        Me.TxtCheck_no.Location = New System.Drawing.Point(427, 94)
        Me.TxtCheck_no.MaxLength = 20
        Me.TxtCheck_no.Name = "TxtCheck_no"
        Me.TxtCheck_no.Size = New System.Drawing.Size(162, 20)
        Me.TxtCheck_no.TabIndex = 9
        Me.TxtCheck_no.Text = ""
        '
        'Dtedate_receive_payment
        '
        Me.Dtedate_receive_payment.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtedate_receive_payment.BorderColor = System.Drawing.Color.Empty
        Me.Dtedate_receive_payment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtedate_receive_payment.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtedate_receive_payment.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtedate_receive_payment.EditableSal = True
        Me.Dtedate_receive_payment.Image = CType(resources.GetObject("Dtedate_receive_payment.Image"), System.Drawing.Image)
        Me.Dtedate_receive_payment.Location = New System.Drawing.Point(427, 70)
        Me.Dtedate_receive_payment.MaxValue = CType(2500, Short)
        Me.Dtedate_receive_payment.MinValue = CType(1800, Short)
        Me.Dtedate_receive_payment.Name = "Dtedate_receive_payment"
        Me.Dtedate_receive_payment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtedate_receive_payment.Sal_Mali = Nothing
        Me.Dtedate_receive_payment.ShowButton = True
        Me.Dtedate_receive_payment.Size = New System.Drawing.Size(102, 23)
        Me.Dtedate_receive_payment.TabIndex = 5
        Me.Dtedate_receive_payment.VisualStyle = False
        '
        'CmbGl_account
        '
        Me.CmbGl_account.DataSource = Me.DsFrmReceivePayment1.GL_account
        Me.CmbGl_account.DisplayMember = "desc_GL_account"
        Me.CmbGl_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGl_account.Location = New System.Drawing.Point(262, 2)
        Me.CmbGl_account.Name = "CmbGl_account"
        Me.CmbGl_account.Size = New System.Drawing.Size(247, 21)
        Me.CmbGl_account.TabIndex = 2
        Me.CmbGl_account.ValueMember = "GL_account"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(331, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 21)
        Me.Label10.TabIndex = 340
        Me.Label10.Text = "Exp. Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(333, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 21)
        Me.Label11.TabIndex = 339
        Me.Label11.Text = "Check No."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(330, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 21)
        Me.Label13.TabIndex = 337
        Me.Label13.Text = "Date "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(192, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 21)
        Me.Label17.TabIndex = 335
        Me.Label17.Text = " G/L Account  "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(-3, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 22)
        Me.Label9.TabIndex = 334
        Me.Label9.Text = "Card No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(-3, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 21)
        Me.Label8.TabIndex = 333
        Me.Label8.Text = "Card Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(-3, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 331
        Me.Label5.Text = "Memo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 330
        Me.Label1.Text = "Amount Rcvd."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCustomerName
        '
        Me.LblCustomerName.BackColor = System.Drawing.Color.Gold
        Me.LblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomerName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblCustomerName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCustomerName.Location = New System.Drawing.Point(246, 25)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(212, 20)
        Me.LblCustomerName.TabIndex = 328
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(-4, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Customer"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(456, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 19)
        Me.Label3.TabIndex = 346
        Me.Label3.Text = "/"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(210, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 22)
        Me.Label2.TabIndex = 329
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RdoCreditCard
        '
        Me.RdoCreditCard.Location = New System.Drawing.Point(198, 93)
        Me.RdoCreditCard.Name = "RdoCreditCard"
        Me.RdoCreditCard.Size = New System.Drawing.Size(83, 22)
        Me.RdoCreditCard.TabIndex = 8
        Me.RdoCreditCard.Text = "Credit Card"
        '
        'RdoCheck
        '
        Me.RdoCheck.Location = New System.Drawing.Point(135, 93)
        Me.RdoCheck.Name = "RdoCheck"
        Me.RdoCheck.Size = New System.Drawing.Size(58, 22)
        Me.RdoCheck.TabIndex = 7
        Me.RdoCheck.Text = "Check"
        '
        'RdoCash
        '
        Me.RdoCash.Checked = True
        Me.RdoCash.Location = New System.Drawing.Point(74, 93)
        Me.RdoCash.Name = "RdoCash"
        Me.RdoCash.Size = New System.Drawing.Size(58, 22)
        Me.RdoCash.TabIndex = 6
        Me.RdoCash.TabStop = True
        Me.RdoCash.Text = "Cash"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(-3, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 21)
        Me.Label6.TabIndex = 332
        Me.Label6.Text = "Pmt. Method"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(455, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 22)
        Me.Label16.TabIndex = 336
        Me.Label16.Text = "Balance"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>Invoices</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Check""><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><" & _
        "EmptyStringValue /><ColumnType>CheckBox</ColumnType><DataMember>CheckFlag</DataM" & _
        "ember><EditType>CheckBox</EditType><Key>Check</Key><Position>0</Position><Width>" & _
        "23</Width><CellStyle><BackColor>Info</BackColor></CellStyle></Column0><Column1 I" & _
        "D=""Date""><Caption>Date</Caption><DataMember>InvoiceDate</DataMember><Key>Date</K" & _
        "ey><Position>1</Position><Selectable>False</Selectable><Width>79</Width></Column" & _
        "1><Column2 ID=""InvoiceNo""><Caption>Invoice No</Caption><DataMember>InvoiceNo</Da" & _
        "taMember><Key>InvoiceNo</Key><Position>2</Position><Selectable>False</Selectable" & _
        "><Width>85</Width></Column2><Column3 ID=""OriginalAmount""><Caption>Original Amoun" & _
        "t</Caption><DataMember>OriginalAmount</DataMember><FormatString>c</FormatString>" & _
        "<InputMask>Currency2</InputMask><Key>OriginalAmount</Key><MaskPrompt>&#x0;</Mask" & _
        "Prompt><Position>3</Position><Selectable>False</Selectable><Width>95</Width></Co" & _
        "lumn3><Column4 ID=""AmountDue""><Caption>Amount Due</Caption><DataMember>AmountDue" & _
        "</DataMember><FormatString>c</FormatString><InputMask>Currency2</InputMask><Key>" & _
        "AmountDue</Key><MaskPrompt>&#x0;</MaskPrompt><Position>4</Position><Selectable>F" & _
        "alse</Selectable><Width>94</Width></Column4><Column5 ID=""Payment""><Caption>Payme" & _
        "nt</Caption><DataMember>Payment</DataMember><FormatString>c2</FormatString><Inpu" & _
        "tMask>Currency2</InputMask><Key>Payment</Key><MaskPrompt>&#x0;</MaskPrompt><Posi" & _
        "tion>5</Position><Width>95</Width><CellStyle><BackColor>Info</BackColor></CellSt" & _
        "yle></Column5><Column6 ID=""Discount""><Caption>Discount %</Caption><DataMember>Di" & _
        "scount</DataMember><FormatString>###.##</FormatString><InputMask>Number2</InputM" & _
        "ask><Key>Discount</Key><MaskPrompt>&#x0;</MaskPrompt><Position>6</Position><Widt" & _
        "h>71</Width></Column6><Column7 ID=""AR_terms""><Caption>AR_terms</Caption><DataMem" & _
        "ber>AR_terms</DataMember><Key>AR_terms</Key><Position>7</Position><Visible>False" & _
        "</Visible></Column7><Column8 ID=""ThisTableID""><Caption>ThisTableID</Caption><Dat" & _
        "aMember>ThisTableID</DataMember><Key>ThisTableID</Key><Position>8</Position><Vis" & _
        "ible>False</Visible></Column8><Column9 ID=""StoreNo""><Caption>Store No</Caption><" & _
        "DataMember>StoreNo</DataMember><EditType>NoEdit</EditType><Key>StoreNo</Key><Pos" & _
        "ition>9</Position><Width>61</Width></Column9></Columns><GroupCondition ID="""" /><" & _
        "Key>Invoices</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout2
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 165)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(634, 114)
        Me.GrdDetail.TabIndex = 2
        '
        'DataView1
        '
        Me.DataView1.RowFilter = "AmountDue>0"
        Me.DataView1.Sort = "DateForSort,InvoiceNo"
        Me.DataView1.Table = Me.DsFrmReceivePayment1.service_center_dtl
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblApplied)
        Me.Panel5.Controls.Add(Me.lblAmountDue)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.BtnUnApplyPayment)
        Me.Panel5.Controls.Add(Me.BtnAutoApply)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Location = New System.Drawing.Point(0, 279)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(637, 87)
        Me.Panel5.TabIndex = 1
        '
        'lblApplied
        '
        Me.lblApplied.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.lblApplied.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.lblApplied.DecimalDigits = 2
        Me.lblApplied.DefaultSendValue = False
        Me.lblApplied.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.lblApplied.FireTabAfterEnter = True
        Me.lblApplied.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblApplied.Image = CType(resources.GetObject("lblApplied.Image"), System.Drawing.Image)
        Me.lblApplied.Location = New System.Drawing.Point(454, 64)
        Me.lblApplied.Maxlength = 10
        Me.lblApplied.MinusColor = System.Drawing.Color.Empty
        Me.lblApplied.Name = "lblApplied"
        Me.lblApplied.ReadOnly = True
        Me.lblApplied.Size = New System.Drawing.Size(131, 21)
        Me.lblApplied.TabIndex = 456
        Me.lblApplied.TabStop = False
        Me.lblApplied.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.lblApplied.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'lblAmountDue
        '
        Me.lblAmountDue.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.lblAmountDue.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.lblAmountDue.DecimalDigits = 2
        Me.lblAmountDue.DefaultSendValue = False
        Me.lblAmountDue.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.lblAmountDue.FireTabAfterEnter = True
        Me.lblAmountDue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblAmountDue.Image = CType(resources.GetObject("lblAmountDue.Image"), System.Drawing.Image)
        Me.lblAmountDue.Location = New System.Drawing.Point(454, 41)
        Me.lblAmountDue.Maxlength = 10
        Me.lblAmountDue.MinusColor = System.Drawing.Color.Empty
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.ReadOnly = True
        Me.lblAmountDue.Size = New System.Drawing.Size(131, 21)
        Me.lblAmountDue.TabIndex = 455
        Me.lblAmountDue.TabStop = False
        Me.lblAmountDue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.lblAmountDue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LblTotalAmountDue)
        Me.Panel2.Controls.Add(Me.lblTotalPayment)
        Me.Panel2.Controls.Add(Me.LblTotalOriginalAmount)
        Me.Panel2.Location = New System.Drawing.Point(-1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 23)
        Me.Panel2.TabIndex = 0
        '
        'LblTotalAmountDue
        '
        Me.LblTotalAmountDue.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblTotalAmountDue.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblTotalAmountDue.DecimalDigits = 2
        Me.LblTotalAmountDue.DefaultSendValue = False
        Me.LblTotalAmountDue.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotalAmountDue.FireTabAfterEnter = True
        Me.LblTotalAmountDue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotalAmountDue.Image = CType(resources.GetObject("LblTotalAmountDue.Image"), System.Drawing.Image)
        Me.LblTotalAmountDue.Location = New System.Drawing.Point(272, 0)
        Me.LblTotalAmountDue.Maxlength = 10
        Me.LblTotalAmountDue.MinusColor = System.Drawing.Color.Empty
        Me.LblTotalAmountDue.Name = "LblTotalAmountDue"
        Me.LblTotalAmountDue.ReadOnly = True
        Me.LblTotalAmountDue.Size = New System.Drawing.Size(98, 21)
        Me.LblTotalAmountDue.TabIndex = 456
        Me.LblTotalAmountDue.TabStop = False
        Me.LblTotalAmountDue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotalAmountDue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.lblTotalPayment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.lblTotalPayment.DecimalDigits = 2
        Me.lblTotalPayment.DefaultSendValue = False
        Me.lblTotalPayment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.lblTotalPayment.FireTabAfterEnter = True
        Me.lblTotalPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblTotalPayment.Image = CType(resources.GetObject("lblTotalPayment.Image"), System.Drawing.Image)
        Me.lblTotalPayment.Location = New System.Drawing.Point(370, 0)
        Me.lblTotalPayment.Maxlength = 10
        Me.lblTotalPayment.MinusColor = System.Drawing.Color.Empty
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.ReadOnly = True
        Me.lblTotalPayment.Size = New System.Drawing.Size(98, 21)
        Me.lblTotalPayment.TabIndex = 455
        Me.lblTotalPayment.TabStop = False
        Me.lblTotalPayment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.lblTotalPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblTotalOriginalAmount
        '
        Me.LblTotalOriginalAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblTotalOriginalAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblTotalOriginalAmount.DecimalDigits = 2
        Me.LblTotalOriginalAmount.DefaultSendValue = False
        Me.LblTotalOriginalAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotalOriginalAmount.FireTabAfterEnter = True
        Me.LblTotalOriginalAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotalOriginalAmount.Image = CType(resources.GetObject("LblTotalOriginalAmount.Image"), System.Drawing.Image)
        Me.LblTotalOriginalAmount.Location = New System.Drawing.Point(174, 0)
        Me.LblTotalOriginalAmount.Maxlength = 10
        Me.LblTotalOriginalAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblTotalOriginalAmount.Name = "LblTotalOriginalAmount"
        Me.LblTotalOriginalAmount.ReadOnly = True
        Me.LblTotalOriginalAmount.Size = New System.Drawing.Size(98, 21)
        Me.LblTotalOriginalAmount.TabIndex = 454
        Me.LblTotalOriginalAmount.TabStop = False
        Me.LblTotalOriginalAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotalOriginalAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label23.Location = New System.Drawing.Point(404, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(157, 22)
        Me.Label23.TabIndex = 348
        Me.Label23.Text = "Amounts for selected Invoices"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(380, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 21)
        Me.Label20.TabIndex = 345
        Me.Label20.Text = "Applied"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(380, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 21)
        Me.Label19.TabIndex = 344
        Me.Label19.Text = "Amount Due"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnUnApplyPayment
        '
        Me.BtnUnApplyPayment.Location = New System.Drawing.Point(232, 59)
        Me.BtnUnApplyPayment.Name = "BtnUnApplyPayment"
        Me.BtnUnApplyPayment.Size = New System.Drawing.Size(126, 21)
        Me.BtnUnApplyPayment.TabIndex = 1
        Me.BtnUnApplyPayment.TabStop = False
        Me.BtnUnApplyPayment.Text = "Un-Apply Payment"
        '
        'BtnAutoApply
        '
        Me.BtnAutoApply.Location = New System.Drawing.Point(232, 35)
        Me.BtnAutoApply.Name = "BtnAutoApply"
        Me.BtnAutoApply.Size = New System.Drawing.Size(126, 21)
        Me.BtnAutoApply.TabIndex = 0
        Me.BtnAutoApply.TabStop = False
        Me.BtnAutoApply.Text = "Auto Apply"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(195, 28)
        Me.Label18.TabIndex = 337
        Me.Label18.Text = "Customer Payment"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO Gl_receive_payment (refrence_no, cod_customer, amount_receive, remark" & _
        ", pmt_method, cc_type, cc_no, Gl_account, date_receive_payment, check_no, expir_" & _
        "date_year, expir_date_month, AuthorizationCode, FromStoreNo, OtherStorerefrence_" & _
        "no, OtherStoreAmount) VALUES (@refrence_no, @cod_customer, @amount_receive, @rem" & _
        "ark, @pmt_method, @cc_type, @cc_no, @Gl_account, @date_receive_payment, @check_n" & _
        "o, @expir_date_year, @expir_date_month, @AuthorizationCode, @FromStoreNo, @Other" & _
        "Storerefrence_no, @OtherStoreAmount)"
        Me.CmdInsert.Connection = Me.CnnTemp
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_receive", System.Data.SqlDbType.Real, 4, "amount_receive"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 100, "remark"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pmt_method", System.Data.SqlDbType.VarChar, 1, "pmt_method"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_no", System.Data.SqlDbType.VarChar, 20, "cc_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account", System.Data.SqlDbType.VarChar, 10, "Gl_account"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_receive_payment", System.Data.SqlDbType.VarChar, 10, "date_receive_payment"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_no", System.Data.SqlDbType.VarChar, 20, "check_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expir_date_year", System.Data.SqlDbType.VarChar, 4, "expir_date_year"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expir_date_month", System.Data.SqlDbType.VarChar, 2, "expir_date_month"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AuthorizationCode", System.Data.SqlDbType.VarChar, 12, "AuthorizationCode"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromStoreNo", System.Data.SqlDbType.VarChar, 2, "FromStoreNo"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherStorerefrence_no", System.Data.SqlDbType.VarChar, 8, "OtherStorerefrence_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherStoreAmount", System.Data.SqlDbType.Money, 8, "OtherStoreAmount"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE Gl_receive_payment SET cod_customer = @cod_customer, amount_receive = @amo" & _
        "unt_receive, remark = @remark, pmt_method = @pmt_method, cc_type = @cc_type, cc_" & _
        "no = @cc_no, Gl_account = @Gl_account, date_receive_payment = @date_receive_paym" & _
        "ent, check_no = @check_no, expir_date_year = @expir_date_year, expir_date_month " & _
        "= @expir_date_month, AuthorizationCode = @AuthorizationCode, OtherStoreAmount = " & _
        "@OtherStoreAmount WHERE (refrence_no = @refrence_no)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_receive", System.Data.SqlDbType.Real, 4, "amount_receive"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 100, "remark"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pmt_method", System.Data.SqlDbType.VarChar, 1, "pmt_method"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_no", System.Data.SqlDbType.VarChar, 20, "cc_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account", System.Data.SqlDbType.VarChar, 10, "Gl_account"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_receive_payment", System.Data.SqlDbType.VarChar, 10, "date_receive_payment"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_no", System.Data.SqlDbType.VarChar, 20, "check_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expir_date_year", System.Data.SqlDbType.VarChar, 4, "expir_date_year"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expir_date_month", System.Data.SqlDbType.VarChar, 2, "expir_date_month"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AuthorizationCode", System.Data.SqlDbType.VarChar, 12, "AuthorizationCode"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherStoreAmount", System.Data.SqlDbType.Money, 8, "OtherStoreAmount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
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
        Me.Sort1.Text = "Order By Reference No"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Customer Code"
        '
        'Sort32
        '
        Me.Sort32.Key = "Sort3"
        Me.Sort32.Name = "Sort32"
        Me.Sort32.Text = "Order By Payement Date"
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cc_type, cc_type_desc FROM bas_cc_type"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAbas_cc_type
        '
        Me.DAbas_cc_type.SelectCommand = Me.SqlSelectCommand1
        Me.DAbas_cc_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_cc_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_type_desc", "cc_type_desc")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account, desc_GL_account, GL_account_master, group_GL_account, remark F" & _
        "ROM GL_account"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_account
        '
        Me.DAGL_account.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT service_center_head.id_service_center AS InvoiceNo, service_cente" & _
        "r_head.date_refer AS InvoiceDate, GL_payment_deposit.payment_amount AS OriginalA" & _
        "mount, 0.0 AS Payment, 0 AS CheckFlag, View_Invoice_Balance_ForEach_ARDue.Balanc" & _
        "eAmount AS AmountDue, dbo.ChangeDate(service_center_head.date_refer) AS DateForS" & _
        "ort, GL_payment_AR.AR_terms, GL_TAB_AR_TERM.ST_DISCOUNT_PERCENTAGE AS Discount, " & _
        "GL_payment_AR.AR_due_date, GL_payment_deposit.ID_payment, ISNULL(GL_payment_depo" & _
        "sit.Discount, 0) AS Discount, @StoreNo AS StoreNo FROM GL_payment_deposit INNER " & _
        "JOIN GL_TAB_AR_TERM INNER JOIN GL_payment_AR ON GL_TAB_AR_TERM.AR_terms = GL_pay" & _
        "ment_AR.AR_terms ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment INN" & _
        "ER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_ce" & _
        "nter_head.id_service_center INNER JOIN View_Invoice_Balance_ForEach_ARDue ON GL_" & _
        "payment_deposit.ID_payment = View_Invoice_Balance_ForEach_ARDue.ID_payment WHERE" & _
        " (service_center_head.cod_customer = @Cod_customer) AND (service_center_head.typ" & _
        "e_of_form = 'IN') AND (GL_payment_deposit.refer_type = '1') AND (GL_payment_depo" & _
        "sit.payment_type = '4') AND (GL_payment_AR.Cancel_flag = 0) ORDER BY DateForSort" & _
        ", InvoiceNo"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAService_center_dtl
        '
        Me.DAService_center_dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DAService_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE")})})
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHead.Controls.Add(Me.Label31)
        Me.PnlHead.Controls.Add(Me.Label30)
        Me.PnlHead.Controls.Add(Me.Label29)
        Me.PnlHead.Controls.Add(Me.Label28)
        Me.PnlHead.Controls.Add(Me.BtnEmail)
        Me.PnlHead.Controls.Add(Me.BtnFax)
        Me.PnlHead.Controls.Add(Me.BtnPrint)
        Me.PnlHead.Controls.Add(Me.BtnPreview)
        Me.PnlHead.Controls.Add(Me.Label44)
        Me.PnlHead.Controls.Add(Me.BtnSortOrder)
        Me.PnlHead.Controls.Add(Me.Label40)
        Me.PnlHead.Controls.Add(Me.BtnFirst)
        Me.PnlHead.Controls.Add(Me.Label41)
        Me.PnlHead.Controls.Add(Me.BtnLast)
        Me.PnlHead.Controls.Add(Me.Label42)
        Me.PnlHead.Controls.Add(Me.BtnCancel)
        Me.PnlHead.Controls.Add(Me.Label43)
        Me.PnlHead.Controls.Add(Me.BtnEdit)
        Me.PnlHead.Controls.Add(Me.Label50)
        Me.PnlHead.Controls.Add(Me.Label51)
        Me.PnlHead.Controls.Add(Me.Label52)
        Me.PnlHead.Controls.Add(Me.Label53)
        Me.PnlHead.Controls.Add(Me.Label54)
        Me.PnlHead.Controls.Add(Me.Label55)
        Me.PnlHead.Controls.Add(Me.BtnDelete)
        Me.PnlHead.Controls.Add(Me.BtnNew)
        Me.PnlHead.Controls.Add(Me.BtnFind)
        Me.PnlHead.Controls.Add(Me.BtnNext)
        Me.PnlHead.Controls.Add(Me.BtnPrev)
        Me.PnlHead.Controls.Add(Me.BtnSave)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(0, 0)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(634, 45)
        Me.PnlHead.TabIndex = 143
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(572, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(31, 10)
        Me.Label31.TabIndex = 204
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(532, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 10)
        Me.Label30.TabIndex = 203
        Me.Label30.Text = "Fax"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(497, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(455, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 201
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(567, 3)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 200
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(532, 3)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 199
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(497, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 198
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(462, 3)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 197
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label44.Location = New System.Drawing.Point(404, 31)
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
        Me.BtnSortOrder.Location = New System.Drawing.Point(402, 2)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 27)
        Me.BtnSortOrder.TabIndex = 195
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(3, 31)
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
        Me.Label41.Location = New System.Drawing.Point(113, 31)
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
        Me.BtnLast.Location = New System.Drawing.Point(113, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(358, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(42, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(359, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(246, 31)
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
        Me.BtnEdit.Location = New System.Drawing.Point(245, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(320, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(282, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(38, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(207, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(162, 31)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 10)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(39, 31)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 10)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(76, 31)
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
        Me.BtnDelete.Location = New System.Drawing.Point(282, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(208, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(160, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(77, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(39, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(320, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnForReader
        '
        'CnnForReader
        '
        Me.CnnForReader.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=KETABIE;persist se" & _
        "curity info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT GL_payment_deposit.id_service_center, GL_payment_deposit.refer_type, GL_pa" & _
        "yment_deposit.payment_type, GL_payment_deposit.payment_amount, GL_payment_deposi" & _
        "t.flag_deposit_bank, GL_payment_deposit.id_GL_journal, GL_payment_deposit.Paid_a" & _
        "mount, GL_payment_deposit.ID_payment, ISNULL(GL_payment_deposit_Detail.ID_paymen" & _
        "t_due, 0) AS ID_payment_due, ISNULL(GL_payment_deposit.Discount, 0) AS Discount," & _
        " @StoreNo AS StoreNo FROM GL_payment_deposit LEFT OUTER JOIN GL_payment_deposit_" & _
        "Detail ON GL_payment_deposit.ID_payment = GL_payment_deposit_Detail.ID_payment_P" & _
        "aid WHERE (GL_payment_deposit.refrence_no = @refrence_no)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount")})})
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbCommand1
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Me.OleDbCommand1.Connection = Me.CnnMdbSetup
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'CmdDeleteOtherStore
        '
        Me.CmdDeleteOtherStore.CommandText = "DELETE FROM Gl_receive_payment WHERE (OtherStorerefrence_no = @OtherStorerefrence" & _
        "_no) AND (FromStoreNo = @FromStoreNo)"
        Me.CmdDeleteOtherStore.Connection = Me.Cnn
        Me.CmdDeleteOtherStore.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherStorerefrence_no", System.Data.SqlDbType.Variant, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
        Me.CmdDeleteOtherStore.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromStoreNo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FromStoreNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_payment_depositOtherStore
        '
        Me.DAGL_payment_depositOtherStore.SelectCommand = Me.SqlCommand1
        Me.DAGL_payment_depositOtherStore.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_payment_deposit.id_service_center, GL_payment_deposit.refer_type, GL_pa" & _
        "yment_deposit.payment_type, GL_payment_deposit.payment_amount, GL_payment_deposi" & _
        "t.flag_deposit_bank, GL_payment_deposit.id_GL_journal, GL_payment_deposit.Paid_a" & _
        "mount, GL_payment_deposit.ID_payment, ISNULL(GL_payment_deposit_Detail.ID_paymen" & _
        "t_due, 0) AS ID_payment_due, ISNULL(GL_payment_deposit.Discount, 0) AS Discount," & _
        " @StoreNo AS StoreNo FROM GL_payment_deposit LEFT OUTER JOIN GL_payment_deposit_" & _
        "Detail ON GL_payment_deposit.ID_payment = GL_payment_deposit_Detail.ID_payment_P" & _
        "aid WHERE (GL_payment_deposit.refrence_no = @refrence_no)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT ID_payment_due, ID_payment_Paid, refrence_no FROM GL_payment_deposit_Detai" & _
        "l WHERE (refrence_no = @refrence_no)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        '
        'DAGL_payment_deposit_Detail
        '
        Me.DAGL_payment_deposit_Detail.SelectCommand = Me.SqlSelectCommand5
        Me.DAGL_payment_deposit_Detail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit_Detail", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment_due", "ID_payment_due"), New System.Data.Common.DataColumnMapping("ID_payment_Paid", "ID_payment_Paid"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no")})})
        '
        'FrmReceivePaymentMultiStoreOld
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(634, 438)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.PnlHead)
        Me.Name = "FrmReceivePaymentMultiStoreOld"
        Me.Text = "Multi Store Receive Payment"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdOtherStorePayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmReceivePayment1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlHead.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Private Sub FrmReceivePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    CustomerCod1.CanAddNewCod = False
    '    Reference_No1.CanAddNewCod = False
    '    Me.Cnn.ConnectionString = PConnectionString
    '    Me.CnnTemp.ConnectionString = PConnectionString
    '    Me.CnnForReader.ConnectionString = PConnectionString
    '    Me.CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables

    '    MyClsReceivePayment.Connection = Cnn
    '    PnlSearchHeight = PnlSearch.Height

    '    MyZipCode = New UCZipCode.ClsZipCode
    '    MyZipCode.Connection = Me.Cnn

    '    Dtedate_receive_payment.Text = Format(Now.Date, PubDateFormat)

    '    UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

    '    Call FillDataSets()
    '    TxtRefrence_no.MaxLength = LenReceivePaymentReferenceNo

    '    If Refrence_NoVar.Trim.Length > 0 Then
    '        Call PAddNew()
    '        TxtRefrence_no.Text = Refrence_NoVar
    '        TxtRefrence_no.Focus()
    '    Else
    '        If Refrence_NoForShowReadOnly.Trim.Length = 0 Then
    '            Call PFirstRecord(False)
    '        Else
    '            Reference_No1.Text = Refrence_NoForShowReadOnly
    '            PnlHead.Enabled = False
    '            PnlSearch.Enabled = False
    '            PnlHead.Height = 0
    '            PnlSearch.Height = 0
    '            'Call FillFields(Reference_No1.Text)
    '        End If
    '        Call AfterSaveOrCancel()
    '        Reference_No1.Focus()
    '    End If
    'End Sub
    'Private Sub FillDataSets()
    '    DsFrmReceivePayment1.GL_account.Clear()
    '    DAGL_account.Fill(DsFrmReceivePayment1, "GL_account")
    '    If DsFrmReceivePayment1.GL_account.Rows.Count < 1 Then
    '        MsgFar("Please Fill The GL_account Table")
    '        Call DisableAllComponet(Me)
    '        Exit Sub
    '    End If

    '    DsFrmReceivePayment1.bas_cc_type.Clear()
    '    DAbas_cc_type.Fill(DsFrmReceivePayment1, "bas_cc_type")
    '    If DsFrmReceivePayment1.bas_cc_type.Rows.Count < 1 Then
    '        MsgFar("Please Fill The Credit Card Table")
    '        Call DisableAllComponet(Me)
    '        Exit Sub
    '    End If
    'End Sub
    'Sub PAddNew()
    '    Status = MainModule.WorkStates.AddNew

    '    'PnlSearch.Visible = False
    '    Call ShowFilterProcPanel()

    '    Call EnableField(True)
    '    ReferenceNoTempVar = Reference_No1.Text
    '    Reference_No1.Text = ""
    '    Call ClearField()

    '    TxtRefrence_no.Text = MakeNewReferenceNo(PConnectionString)
    '    OldReferenceNo = TxtRefrence_no.Text
    '    TxtRefrence_no.Focus()

    '    BtnNew.Enabled = False
    '    BtnDelete.Enabled = False
    '    BtnEdit.Enabled = False
    '    BtnCancel.Enabled = True
    '    MAddNew.Enabled = False
    '    MDelete.Enabled = False
    '    MEdit.Enabled = False
    '    MCancel.Enabled = True
    '    BtnPrev.Enabled = False
    '    BtnNext.Enabled = False
    '    BtnFirst.Enabled = False
    '    BtnLast.Enabled = False
    '    BtnSortOrder.Enabled = False
    '    MPreviousRecord.Enabled = False
    '    MNextRecord.Enabled = False
    '    MFirstRecord.Enabled = False
    '    MLastRecord.Enabled = False
    'End Sub
    'Sub PEdit()
    '    If CanChangeOrDelete() = False Then
    '        MsgBox("You Can't Edit This Information.Some of This Records Was Deposited")
    '        Exit Sub
    '    End If

    '    Status = MainModule.WorkStates.Edit

    '    'PnlSearch.Visible = False
    '    Call ShowFilterProcPanel()

    '    EnableField(True)
    '    ReferenceNoTempVar = Reference_No1.Text
    '    TxtRefrence_no.Focus()

    '    BtnNew.Enabled = False
    '    BtnDelete.Enabled = False
    '    BtnEdit.Enabled = False
    '    BtnCancel.Enabled = True
    '    MAddNew.Enabled = False
    '    MDelete.Enabled = False
    '    MEdit.Enabled = False
    '    MCancel.Enabled = True
    '    BtnPrev.Enabled = False
    '    BtnNext.Enabled = False
    '    BtnFirst.Enabled = False
    '    BtnLast.Enabled = False
    '    BtnSortOrder.Enabled = False
    '    MPreviousRecord.Enabled = False
    '    MNextRecord.Enabled = False
    '    MFirstRecord.Enabled = False
    '    MLastRecord.Enabled = False
    'End Sub
    'Sub PDelete()
    '    Dim c1 As New FrmWhatDoForMenu
    '    c1.BtnLeftText = "Cancel"
    '    c1.BtnRightText = "Delete"
    '    c1.ShowFarMsg("Are you sure?")
    '    If c1.DialogResult = DialogResult.OK Then
    '        Try
    '            If CanChangeOrDelete() = False Then
    '                MsgBox("You Can't Delete This Information.Some of This Records Was Deposited")
    '                Exit Sub
    '            End If

    '            Call UpdateAndDelete(True)

    '            ReferenceNoTempVar = ""
    '            Call PNextRecord(False)
    '            If ReferenceNoTempVar.Trim.Length = 0 Then
    '                Call PPreviousRecord(False)
    '                If ReferenceNoTempVar.Trim.Length = 0 Then
    '                    Call ClearField()
    '                End If
    '            End If
    '        Catch ex As System.Data.SqlClient.SqlException
    '            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
    '            Call PubErrHandle(myErrors.Item(0).Number)
    '        End Try
    '        Call AfterSaveOrCancel()
    '    Else
    '        Reference_No1.Focus()
    '    End If
    '    Status = MainModule.WorkStates._ReadOnly
    'End Sub
    'Private Sub UpdateAndDelete(ByVal Gl_receive_paymentDeleteFlag As Boolean)

    '    Call ChangePaid_amountToOriginalValue()

    '    Dim StoreCounterVar As Integer
    '    Dim ThisConnectionStringVar As String
    '    For StoreCounterVar = 0 To DsFrmReceivePayment1.Store_Setup.Rows.Count - 1
    '        ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
    '        Try
    '            If Cnn.State = ConnectionState.Open Then
    '                Cnn.Close()
    '            End If
    '            Cnn.ConnectionString = ThisConnectionStringVar
    '            If Cnn.State <> ConnectionState.Open Then
    '                Cnn.Open()
    '            End If
    '            If CnnForReader.State = ConnectionState.Open Then
    '                CnnForReader.Close()
    '            End If
    '            CnnForReader.ConnectionString = ThisConnectionStringVar
    '            If CnnForReader.State <> ConnectionState.Open Then
    '                CnnForReader.Open()
    '            End If

    '            If PubStoreNO = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo") Then
    '                If Gl_receive_paymentDeleteFlag Then
    '                    CmdDelete.Parameters("@refrence_no").Value = TxtRefrence_no.Text
    '                    CmdDelete.ExecuteNonQuery()
    '                End If
    '                CmdGeneral.CommandText = "Delete From GL_account_adjustment_head Where Gl_receive_payment_Refrence_no=" & Qt(TxtRefrence_no.Text)
    '                CmdGeneral.ExecuteNonQuery()
    '                CmdGeneral.CommandText = "Delete From GL_payment_deposit_Detail Where Refrence_no=" & Qt(TxtRefrence_no.Text)
    '                CmdGeneral.ExecuteNonQuery()
    '            Else
    '                Dim SQLReader As System.Data.SqlClient.SqlDataReader
    '                If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
    '                    CmdGeneralForReader.Connection.Open()
    '                End If
    '                CmdGeneralForReader.CommandText = "SELECT refrence_no from Gl_receive_payment Where OtherStoreRefrence_no=" & Qt(TxtRefrence_no.Text) & " AND FromStoreNo=" & Qt(PubStoreNO)
    '                SQLReader = CmdGeneralForReader.ExecuteReader
    '                If SQLReader.HasRows Then
    '                    Do While SQLReader.Read()
    '                        CmdGeneral.CommandText = "Delete From GL_account_adjustment_head Where Gl_receive_payment_Refrence_no=" & Qt(SQLReader.Item("refrence_no"))
    '                        CmdGeneral.ExecuteNonQuery()
    '                        CmdGeneral.CommandText = "Delete From GL_payment_deposit_Detail Where Refrence_no=" & Qt(SQLReader.Item("refrence_no"))
    '                        CmdGeneral.ExecuteNonQuery()
    '                    Loop
    '                End If
    '                If Gl_receive_paymentDeleteFlag Then
    '                    CmdDeleteOtherStore.Parameters("@OtherStoreRefrence_no").Value = Reference_No1.Text
    '                    CmdDeleteOtherStore.Parameters("@FromStoreNo").Value = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
    '                    CmdDeleteOtherStore.ExecuteNonQuery()
    '                End If
    '            End If

    '        Catch ex As Exception
    '            MsgBox("Please Call to Your Vendor.Error In Setup Files")
    '        End Try
    '    Next
    '    If Cnn.State = ConnectionState.Open Then
    '        Cnn.Close()
    '    End If
    '    Cnn.ConnectionString = PConnectionString
    '    If CnnForReader.State = ConnectionState.Open Then
    '        CnnForReader.Close()
    '    End If
    '    CnnForReader.ConnectionString = PConnectionString
    'End Sub
    'Sub PSave()
    '    If Not CustomerCod1.ARCharge Then
    '        MsgBox("This Option only available to AR Customers.")
    '        Exit Sub
    '    End If
    '    If NumAmount_Receive.Numbervalue <> lblTotalPayment.Numbervalue Then
    '        MsgBox("Amount Received should be equal to sum of payment Details.")
    '        Exit Sub
    '    End If

    '    'If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '    '    Dim i As Integer
    '    '    For i = 0 To DsFrmReceivePayment1.service_center_dtl.Rows.Count - 1
    '    '        If Dtedate_receive_payment.Text < (DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("InvoiceDate") & "") Then
    '    '            MsgBox("Receive payment date should greater than invoice date.")
    '    '            Exit Sub
    '    '        End If
    '    '    Next
    '    'End If

    '    Dim ChangeOK As Boolean = False
    '    Select Case Status
    '        Case MainModule.WorkStates.AddNew
    '            ReferenceNoTempVar = PInsert()
    '            ChangeOK = IIf(ReferenceNoTempVar.Trim.Length = 0, False, True)
    '            If Refrence_NoVar.Trim.Length > 0 Then
    '                Refrence_NoVar = TxtRefrence_no.Text
    '                Me.Close()
    '            End If
    '        Case MainModule.WorkStates.Edit
    '            Dim thisrow As DataRow, ThisPosition As Integer
    '            ChangeOK = PUpdate(ReferenceNoTempVar)
    '    End Select
    '    If ChangeOK Then
    '        Call AfterSaveOrCancel()
    '        'If Status = mainmodule.WorkStates.AddNew Then
    '        '    Call PAddNew()
    '        'Else
    '        Status = MainModule.WorkStates._ReadOnly
    '        'PnlSearch.Visible = True
    '        Call ShowFilterProcPanel()

    '        Reference_No1.Text = ReferenceNoTempVar
    '        Reference_No1.Focus()
    '    End If
    'End Sub
    'Sub PCancel()
    '    Status = MainModule.WorkStates._ReadOnly
    '    'PnlSearch.Visible = True
    '    Call ShowFilterProcPanel()

    '    Reference_No1.Text = ReferenceNoTempVar
    '    If Reference_No1.Text.Trim.Length = 0 Then
    '        Call ClearField()
    '    End If
    '    Call AfterSaveOrCancel()
    '    Reference_No1.Focus()
    'End Sub
    'Sub AfterSaveOrCancel()
    '    MSave.Enabled = False
    '    BtnSave.Enabled = False
    '    MCancel.Enabled = False
    '    BtnCancel.Enabled = False
    '    BtnNew.Enabled = True
    '    MAddNew.Enabled = True
    '    If TxtRefrence_no.Text.Trim.Length = 0 Then
    '        BtnDelete.Enabled = False
    '        MDelete.Enabled = False
    '        BtnEdit.Enabled = False
    '        MEdit.Enabled = False
    '        BtnPrev.Enabled = False
    '        BtnNext.Enabled = False
    '        BtnFirst.Enabled = False
    '        BtnLast.Enabled = False
    '        BtnSortOrder.Enabled = False
    '        MPreviousRecord.Enabled = False
    '        MNextRecord.Enabled = False
    '        MFirstRecord.Enabled = False
    '        MLastRecord.Enabled = False
    '    Else
    '        BtnDelete.Enabled = True
    '        MDelete.Enabled = True
    '        BtnEdit.Enabled = True
    '        MEdit.Enabled = True
    '        BtnPrev.Enabled = True
    '        BtnNext.Enabled = True
    '        BtnFirst.Enabled = True
    '        BtnLast.Enabled = True
    '        BtnSortOrder.Enabled = True
    '        MPreviousRecord.Enabled = True
    '        MNextRecord.Enabled = True
    '        MFirstRecord.Enabled = True
    '        MLastRecord.Enabled = True
    '    End If
    '    Call EnableField(False)
    '    Call FillFields(Reference_No1.Text)
    'End Sub
    'Private Sub MAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAddNew.Click
    '    Call PAddNew()
    'End Sub
    'Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEdit.Click
    '    Call PEdit()
    'End Sub
    'Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDelete.Click
    '    Call PDelete()
    'End Sub
    'Private Sub MSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSave.Click
    '    Call PSave()
    'End Sub
    'Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
    '    Call PCancel()
    'End Sub
    'Private Sub TxtRefrence_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCc_no.TextChanged, TxtAuthNo.TextChanged, TxtCheck_no.TextChanged, TxtRefrence_no.TextChanged, TxtRemark.TextChanged, CmbCc_type.SelectedValueChanged, CmbGl_account.SelectedValueChanged, NumAmount_Receive.TextChanged
    '    Call SaveButtonControl()
    'End Sub
    'Private Sub SaveButtonControl()
    '    If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
    '        If TxtRefrence_no.Text.Trim.Length > 0 And CustomerCod1.CustomerCod.Trim.Length > 0 And Val(NumAmount_Receive.Text) > 0 And (RdoCash.Checked Or (RdoCheck.Checked And TxtCheck_no.Text.Trim.Length > 0) Or (RdoCreditCard.Checked And CmbCc_type.Text.Trim.Length > 0)) And Mid(Dtedate_receive_payment.Text, 1, 2).Trim.Length > 0 Then
    '            BtnSave.Enabled = True
    '            MSave.Enabled = True
    '        Else
    '            BtnSave.Enabled = False
    '            MSave.Enabled = False
    '        End If
    '    End If
    'End Sub
    'Private Sub MFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFirstRecord.Click
    '    Call PFirstRecord()
    'End Sub
    'Private Sub MPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPreviousRecord.Click
    '    Call PPreviousRecord()
    'End Sub
    'Private Sub MNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNextRecord.Click
    '    Call PNextRecord()
    'End Sub
    'Private Sub MLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MLastRecord.Click
    '    Call PLastRecord()
    'End Sub
    'Private Sub PFirstRecord(Optional ByVal MsgShowFlag As Boolean = True)
    '    Dim TXTSearchReferenceNoTemp As String
    '    Try
    '        If CmdGeneral.Connection.State = ConnectionState.Open Then
    '            CmdGeneral.Connection.Close()
    '        End If
    '        CmdGeneral.Connection.ConnectionString = PConnectionString
    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
    '            Case "Refrence_No".ToUpper
    '                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment Order BY " & ReceivePaymentOrderVar1 & " ASC"
    '            Case "cod_customer".ToUpper
    '                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC "
    '            Case "date_receive_payment".ToUpper
    '                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC "
    '        End Select
    '        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
    '        If IsNothing(TXTSearchReferenceNoTemp) Then
    '            TXTSearchReferenceNoTemp = ""
    '        End If
    '        If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
    '            If MsgShowFlag Then MsgFar("This is the First record of this table.")
    '        Else
    '            Reference_No1.Text = TXTSearchReferenceNoTemp
    '            'Call FillFields(Reference_No1.Text)
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
    '    Dim TXTSearchReferenceNoTemp As String
    '    If CmdGeneral.Connection.State = ConnectionState.Open Then
    '        CmdGeneral.Connection.Close()
    '    End If
    '    CmdGeneral.Connection.ConnectionString = PConnectionString
    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
    '        Case "Refrence_No".ToUpper
    '            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment where Refrence_No<" & Qt(TxtRefrence_no.Text) & " Order BY " & ReceivePaymentOrderVar1 & " DESC"
    '        Case "cod_customer".ToUpper
    '            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment where (CAST(cod_customer AS char(" & LenCustomerCod & ")))+Refrence_No<" & Qt(InsertSpaceAfter(CustomerCod1.CustomerCod, LenCustomerCod) & InsertSpaceAfter(TxtRefrence_no.Text, TxtRefrence_no.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC"
    '        Case "date_receive_payment".ToUpper
    '            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment where date_receive_payment+Refrence_No<" & Qt(Dtedate_receive_payment.Text & InsertSpaceAfter(TxtRefrence_no.Text, TxtRefrence_no.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC"
    '    End Select
    '    TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
    '    If IsNothing(TXTSearchReferenceNoTemp) Then
    '        TXTSearchReferenceNoTemp = ""
    '    End If
    '    If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
    '        If MsgShowFlag Then MsgFar("This is the First record of this table.")
    '    Else
    '        Reference_No1.Text = TXTSearchReferenceNoTemp
    '        ReferenceNoTempVar = TXTSearchReferenceNoTemp
    '        'Call FillFields(Reference_No1.Text)
    '    End If
    'End Sub
    'Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
    '    Dim TXTSearchReferenceNoTemp As String
    '    If CmdGeneral.Connection.State = ConnectionState.Open Then
    '        CmdGeneral.Connection.Close()
    '    End If
    '    CmdGeneral.Connection.ConnectionString = PConnectionString
    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
    '        Case "Refrence_No".ToUpper
    '            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment where Refrence_No>" & Qt(TxtRefrence_no.Text) & " Order BY " & ReceivePaymentOrderVar1 & " ASC"
    '        Case "cod_customer".ToUpper
    '            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment where (CAST(cod_customer AS char(" & LenCustomerCod & ")))+Refrence_No>" & Qt(InsertSpaceAfter(CustomerCod1.CustomerCod, LenCustomerCod) & InsertSpaceAfter(TxtRefrence_no.Text, TxtRefrence_no.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC"
    '        Case "date_receive_payment".ToUpper
    '            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment where date_receive_payment+Refrence_No>" & Qt(Dtedate_receive_payment.Text & InsertSpaceAfter(TxtRefrence_no.Text, TxtRefrence_no.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC"
    '    End Select
    '    TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
    '    If IsNothing(TXTSearchReferenceNoTemp) Then
    '        TXTSearchReferenceNoTemp = ""
    '    End If
    '    If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
    '        If MsgShowFlag Then MsgFar("This is the Last record of this table.")
    '    Else
    '        Reference_No1.Text = TXTSearchReferenceNoTemp
    '        ReferenceNoTempVar = TXTSearchReferenceNoTemp
    '        'Call FillFields(Reference_No1.Text)
    '    End If
    'End Sub
    'Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
    '    Dim TXTSearchReferenceNoTemp As String
    '    Try
    '        If CmdGeneral.Connection.State = ConnectionState.Open Then
    '            CmdGeneral.Connection.Close()
    '        End If
    '        CmdGeneral.Connection.ConnectionString = PConnectionString
    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
    '            Case "Refrence_No".ToUpper
    '                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment Order BY " & ReceivePaymentOrderVar1 & " DESC"
    '            Case "cod_customer".ToUpper
    '                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC "
    '            Case "date_receive_payment".ToUpper
    '                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from Gl_receive_payment Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC "
    '        End Select
    '        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
    '        If IsNothing(TXTSearchReferenceNoTemp) Then
    '            TXTSearchReferenceNoTemp = ""
    '        End If
    '        If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
    '            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
    '        Else
    '            Reference_No1.Text = TXTSearchReferenceNoTemp
    '            'Call FillFields(Reference_No1.Text)
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub Reference_No1_FindReferenceNo() Handles Reference_No1.FindReferenceNo
    '    Call FillFields(Reference_No1.Text)
    '    'Call AfterSaveOrCancel()
    'End Sub
    'Private Sub SetNoRecordFind()
    '    BtnDelete.Enabled = False
    '    BtnEdit.Enabled = False
    '    BtnCancel.Enabled = True
    '    MDelete.Enabled = False
    '    MEdit.Enabled = False
    '    MCancel.Enabled = True
    '    BtnPrev.Enabled = False
    '    BtnNext.Enabled = False
    '    BtnFirst.Enabled = False
    '    BtnLast.Enabled = False
    '    BtnSortOrder.Enabled = False
    '    MPreviousRecord.Enabled = False
    '    MNextRecord.Enabled = False
    '    MFirstRecord.Enabled = False
    '    MLastRecord.Enabled = False
    'End Sub
    'Private Sub ShowFilterProcPanel()
    '    Dim I As Integer, k As Integer
    '    If PnlSearch.Height = 0 Then
    '        k = -1
    '    Else
    '        k = 1
    '    End If
    '    Try
    '        For I = 1 To PnlSearchHeight
    '            PnlSearch.Height = PnlSearch.Height - k
    '            Me.Height = Me.Height - k
    '        Next I
    '    Catch
    '        '                    PanelSearch.Visible = Not PanelSearch.Visible
    '    End Try
    '    'Me.Height = Me.Height - (k * PnlSearchHeight)
    '    If PnlSearch.Height <> 0 Then
    '        'GRDFWG.Height = PanelKartabl.Height - SBKartabl.Height
    '        Reference_No1.Focus()
    '    Else
    '        'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
    '    End If
    'End Sub
    'Private Sub FrmReceivePayment_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    If BtnNew.Enabled Or PnlHead.Enabled = False Then
    '        Reference_No1.Text = ""
    '    Else
    '        MsgBox("First You Should Save or Cancel The Receive Payment")
    '        e.Cancel = True
    '    End If
    'End Sub
    'Private Sub PPrintMasterInformation()
    '    'If Reference_No1.text > 0 Then
    '    '    Dim Orpt As New RptInspectionMasterInformation
    '    '    DsFrmInspectionMaster1.Clear()
    '    '    DAInspectionMaster.SelectCommand.Parameters("@refrence_no").Value = Reference_No1.text
    '    '    DAInspectionMaster.Fill(DsFrmInspectionMaster1, "InspectionMaster")
    '    '    Prn = New FrmRepView
    '    '    Prn.MdiParent = PubMFrmMain
    '    '    Orpt.SetParameterValue("CompanyName", PubCompanyName)
    '    '    Orpt.SetDataSource(DsFrmInspectionMaster1)
    '    '    Prn.CrViewer.ReportSource = Orpt
    '    '    Prn.Show()
    '    'End If
    'End Sub
    'Friend Sub EnableField(ByVal instatus As Boolean)
    '    If Status = MainModule.WorkStates.AddNew Then
    '        TxtRefrence_no.Enabled = instatus
    '    Else
    '        TxtRefrence_no.Enabled = False
    '    End If
    '    CustomerCod1.Enabled = instatus
    '    TxtRemark.Enabled = instatus
    '    CmbGl_account.Enabled = instatus
    '    NumAmount_Receive.Enabled = instatus
    '    Dtedate_receive_payment.Enabled = instatus
    '    RdoCash.Enabled = instatus
    '    RdoCheck.Enabled = instatus
    '    RdoCreditCard.Enabled = instatus
    '    If instatus Then
    '        GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
    '    Else
    '        GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
    '    End If
    '    Call CheckRdoControls()
    '    BtnAutoApply.Enabled = instatus
    '    BtnUnApplyPayment.Enabled = instatus
    'End Sub
    'Friend Sub ClearField()
    '    TxtCc_no.Text = ""
    '    TxtAuthNo.Text = ""
    '    TxtCheck_no.Text = ""
    '    TxtRefrence_no.Text = ""
    '    TxtRemark.Text = ""
    '    Try
    '        CmbCc_type.SelectedValue = 0
    '    Catch ex As Exception
    '    End Try

    '    Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
    '    OleDbReaderForStore = RetrieveAccountsReceivableSetupTable()
    '    Try
    '        CmbGl_account.SelectedValue = OleDbReaderForStore.Item("Default_AR_GL_account") & ""
    '    Catch ex As Exception
    '    End Try
    '    NumMonth.Text = "0"
    '    NumYear.Text = "0"
    '    NumAmount_Receive.Text = "0"
    '    Dtedate_receive_payment.Text = Format(Now.Date, PubDateFormat)
    '    CustomerCod1.CustomerCod = ""

    '    RdoCash.Checked = True
    '    RdoCheck.Checked = False
    '    RdoCreditCard.Checked = False

    '    lblAmountDue.Text = "0"
    '    lblApplied.Text = "0"
    '    LblBalance.Text = 0
    '    LblCustomerName.Text = ""

    '    LblTotalOriginalAmount.Text = ""
    '    LblTotalAmountDue.Text = ""
    '    lblTotalPayment.Text = ""
    '    DsFrmReceivePayment1.service_center_dtl.Clear()
    '    DsFrmReceivePayment1.GL_payment_deposit.Clear()
    'End Sub
    'Friend Function PInsert() As String
    '    Dim thisrow As DataRow
    '    PInsert = ""
    '    Try
    '        With CmdInsert
    '            If Not SetParametersForInsertAndUpdate(CmdInsert, True) Then
    '                PInsert = ""
    '                MsgBox("Please try again")
    '                Exit Function
    '            End If
    '            PInsert = TxtRefrence_no.Text
    '            Call SaveGL_payment_deposit()
    '            '.Connection.Close()
    '        End With
    '    Catch ex As System.Data.SqlClient.SqlException
    '        'Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
    '        'Call PubErrHandle(myErrors.Item(0).Number)
    '        PInsert = ""
    '    End Try
    'End Function
    'Friend Function PUpdate(ByVal ThisRefrence_No As String) As Boolean
    '    PUpdate = True
    '    Try
    '        With CmdUpdate
    '            If Not SetParametersForInsertAndUpdate(CmdUpdate, False) Then
    '                PUpdate = False
    '                MsgBox("Please try again")
    '                Exit Function
    '            End If
    '            PUpdate = True
    '            Call SaveGL_payment_deposit()
    '            '.Connection.Close()
    '        End With
    '    Catch ex As System.Data.SqlClient.SqlException
    '        'Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
    '        'Call PubErrHandle(myErrors.Item(0).Number)
    '        PUpdate = False
    '    End Try
    'End Function
    'Private Function SetParametersForInsertAndUpdate(ByRef CmdParameter As SqlCommand, ByVal IsInsertFlag As Boolean) As Boolean
    '    Dim FlagForShowNewRefNo As Boolean = False
    '    Dim StoreCounterVar As Integer
    '    Dim ThisConnectionStringVar As String
    '    Dim ThisTxtRefrence_noTempVar As String
    '    For StoreCounterVar = 0 To DsFrmReceivePayment1.Store_Setup.Rows.Count - 1
    '        ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
    '        If ThisConnectionStringVar.Trim.Length > 0 And DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("Amount") <> 0 Then
    '            Try
    '                If CmdParameter.Connection.State = ConnectionState.Open Then
    '                    CmdParameter.Connection.Close()
    '                End If
    '                CmdParameter.Connection.ConnectionString = ThisConnectionStringVar
    '                If CmdParameter.Connection.State = ConnectionState.Closed Then
    '                    CmdParameter.Connection.Open()
    '                End If

    '                Dim iii As Integer = 0
    '                For iii = 0 To 10
    '                    With CmdParameter
    '                        If .Connection.State <> ConnectionState.Open Then
    '                            .Connection.Open()
    '                        End If

    '                        If DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo") = PubStoreNO Then
    '                            ThisTxtRefrence_noTempVar = TxtRefrence_no.Text
    '                            .Parameters("@amount_receive").Value = NumAmount_Receive.Numbervalue
    '                            .Parameters("@OtherStoreAmount").Value = NumAmountForOtherStore.Numbervalue
    '                        Else
    '                            ThisTxtRefrence_noTempVar = MakeNewReferenceNo(ThisConnectionStringVar)
    '                            .Parameters("@amount_receive").Value = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("Amount")
    '                            .Parameters("@OtherStoreAmount").Value = 0
    '                        End If

    '                        .Parameters("@refrence_no").Value = ThisTxtRefrence_noTempVar
    '                        .Parameters("@cod_customer").Value = CustomerCod1.CustomerCod
    '                        .Parameters("@remark").Value = TxtRemark.Text
    '                        If RdoCash.Checked Then
    '                            .Parameters("@pmt_method").Value = "1"
    '                            .Parameters("@cc_type").Value = System.DBNull.Value
    '                            .Parameters("@cc_no").Value = ""
    '                            .Parameters("@AuthorizationCode").Value = ""
    '                            .Parameters("@expir_date_year").Value = 0
    '                            .Parameters("@expir_date_month").Value = 0
    '                            .Parameters("@check_no").Value = ""
    '                        ElseIf RdoCheck.Checked Then
    '                            .Parameters("@pmt_method").Value = "2"
    '                            .Parameters("@cc_type").Value = System.DBNull.Value
    '                            .Parameters("@cc_no").Value = ""
    '                            .Parameters("@AuthorizationCode").Value = TxtAuthNo.Text
    '                            .Parameters("@expir_date_year").Value = 0
    '                            .Parameters("@expir_date_month").Value = 0
    '                            .Parameters("@check_no").Value = TxtCheck_no.Text
    '                        ElseIf RdoCreditCard.Checked Then
    '                            .Parameters("@pmt_method").Value = "3"
    '                            .Parameters("@cc_type").Value = CmbCc_type.SelectedValue
    '                            .Parameters("@cc_no").Value = TxtCc_no.Text
    '                            .Parameters("@AuthorizationCode").Value = TxtAuthNo.Text
    '                            .Parameters("@expir_date_year").Value = NumYear.Text
    '                            .Parameters("@expir_date_month").Value = NumMonth.Text
    '                            .Parameters("@check_no").Value = ""
    '                        End If
    '                        .Parameters("@Gl_account").Value = CmbGl_account.SelectedValue
    '                        .Parameters("@date_receive_payment").Value = Dtedate_receive_payment.Text
    '                        If IsInsertFlag Then
    '                            .Parameters("@FromStoreNo").Value = PubStoreNO
    '                            If DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo") = PubStoreNO Then
    '                                .Parameters("@OtherStoreRefrence_no").Value = ""
    '                            Else
    '                                .Parameters("@OtherStoreRefrence_no").Value = TxtRefrence_no.Text
    '                            End If
    '                        End If
    '                        Try
    '                            .ExecuteNonQuery()
    '                            Exit For
    '                        Catch ex As Exception
    '                            ThisTxtRefrence_noTempVar = MakeNewReferenceNo(ThisConnectionStringVar)
    '                            If DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo") = PubStoreNO Then
    '                                TxtRefrence_no.Text = ThisTxtRefrence_noTempVar
    '                            End If
    '                        End Try
    '                    End With
    '                Next
    '                If iii = 11 Then
    '                    SetParametersForInsertAndUpdate = False
    '                    Exit For
    '                Else
    '                    DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("Refrence_no") = ThisTxtRefrence_noTempVar
    '                    SetParametersForInsertAndUpdate = True
    '                    If OldReferenceNo <> TxtRefrence_no.Text And Status = MainModule.WorkStates.AddNew And PubStoreNO = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo") Then
    '                        FlagForShowNewRefNo = True
    '                    End If
    '                End If
    '            Catch ex As Exception
    '                MsgBox("Please Call to Your Vendor.Error In Setup Files")
    '            End Try
    '        End If
    '    Next
    '    If CmdParameter.Connection.State = ConnectionState.Open Then
    '        CmdParameter.Connection.Close()
    '    End If
    '    CmdParameter.Connection.ConnectionString = PConnectionString

    '    If FlagForShowNewRefNo Then
    '        Dim MyFrmShowChangedNo As New FrmShowChangedNo
    '        MyFrmShowChangedNo.LblNewNo.Text = TxtRefrence_no.Text
    '        MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
    '        MyFrmShowChangedNo.ShowDialog()
    '    End If

    'End Function
    'Friend Function FillFields(ByVal ThisRefrence_No As String) As Boolean
    '    FillFields = False
    '    If ThisRefrence_No.Trim.Length = 0 Then
    '        Exit Function
    '    End If
    '    Dim SQLReader As System.Data.SqlClient.SqlDataReader
    '    Try
    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        CmdGeneral.CommandText = "SELECT * from Gl_receive_payment where Refrence_No=" & Qt(ThisRefrence_No)
    '        SQLReader = CmdGeneral.ExecuteReader
    '        If SQLReader.HasRows Then
    '            SQLReader.Read()
    '            TxtRefrence_no.Text = Trim(SQLReader.Item("Refrence_No") & "")
    '            NumAmount_Receive.Text = SQLReader.Item("amount_receive")
    '            TxtRemark.Text = Trim(SQLReader.Item("remark") & "")
    '            Select Case Trim(SQLReader.Item("pmt_method") & "")
    '                Case "1"
    '                    RdoCash.Checked = True
    '                Case "2"
    '                    RdoCheck.Checked = True
    '                Case "3"
    '                    RdoCreditCard.Checked = True
    '                Case Else
    '                    RdoCash.Checked = True
    '            End Select
    '            CmbCc_type.SelectedValue = Trim(SQLReader.Item("cc_type") & "")
    '            CmbGl_account.SelectedValue = Trim(SQLReader.Item("Gl_account") & "")
    '            Dtedate_receive_payment.Text = Trim(SQLReader.Item("date_receive_payment") & "")
    '            TxtCheck_no.Text = Trim(SQLReader.Item("check_no") & "")
    '            NumYear.Text = SQLReader.Item("expir_date_year")
    '            TxtCheck_no.Text = Trim(SQLReader.Item("check_no") & "")
    '            TxtCc_no.Text = Trim(SQLReader.Item("Cc_no") & "")
    '            TxtAuthNo.Text = Trim(SQLReader.Item("AuthorizationCode") & "")
    '            NumMonth.Text = SQLReader.Item("expir_date_month")
    '            Dim CustomerCodVar As String = Trim(SQLReader.Item("cod_customer") & "")
    '            SQLReader.Close()
    '            CustomerCod1.CustomerCod = CustomerCodVar
    '            FillFields = True
    '        Else
    '            Call ClearField()
    '            SQLReader.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error in loading data")
    '    End Try
    '    DsFrmReceivePayment1.GL_payment_deposit.Clear()
    '    Dim StoreCounterVar As Integer
    '    Dim ThisConnectionStringVar As String
    '    Dim ThisRefrence_noVar As String
    '    For StoreCounterVar = 0 To DsFrmReceivePayment1.Store_Setup.Rows.Count - 1
    '        ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
    '        If Cnn.State = ConnectionState.Open Then
    '            Cnn.Close()
    '        End If
    '        Cnn.ConnectionString = ThisConnectionStringVar
    '        If DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo") = PubStoreNO Then
    '            DAGL_payment_deposit.SelectCommand.Parameters("@refrence_no").Value = Reference_No1.Text
    '            DAGL_payment_deposit.SelectCommand.Parameters("@StoreNo").Value = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
    '            DAGL_payment_deposit.Fill(DsFrmReceivePayment1.GL_payment_deposit)
    '        Else
    '            If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '                CmdGeneral.Connection.Open()
    '            End If
    '            CmdGeneral.CommandText = "SELECT refrence_no from Gl_receive_payment where OtherStorerefrence_no=" & Qt(Reference_No1.Text)
    '            Try
    '                ThisRefrence_noVar = CmdGeneral.ExecuteScalar & ""
    '            Catch ex As Exception
    '                ThisRefrence_noVar = ""
    '            End Try
    '            If ThisRefrence_noVar.Trim.Length > 0 Then
    '                DAGL_payment_depositOtherStore.SelectCommand.Parameters("@Refrence_no").Value = ThisRefrence_noVar
    '                DAGL_payment_depositOtherStore.SelectCommand.Parameters("@StoreNo").Value = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
    '                DAGL_payment_depositOtherStore.Fill(DsFrmReceivePayment1.GL_payment_deposit)
    '            End If
    '        End If
    '    Next
    '    If Cnn.State = ConnectionState.Open Then
    '        Cnn.Close()
    '    End If
    '    Cnn.ConnectionString = PConnectionString

    '    Call FillGridInformation()
    '    Call CalculateCreditRemaining()
    'End Function
    'Private Sub FillOtherFields()
    '    If TxtRefrence_no.Text.Trim.Length = 0 Then
    '        Exit Sub
    '    End If
    '    Dim SQLReader As System.Data.SqlClient.SqlDataReader

    '    If CmdGeneral.Connection.State = ConnectionState.Open Then
    '        CmdGeneral.Connection.Close()
    '    End If
    '    CmdGeneral.Connection.ConnectionString = PConnectionString
    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    CmdGeneral.CommandText = "SELECT * from Gl_receive_payment where Refrence_No=" & TxtRefrence_no.Text '& " Order by "
    '    SQLReader = CmdGeneral.ExecuteReader
    '    If SQLReader.HasRows Then
    '        SQLReader.Read()
    '        'TXTLastPurchaseDate.Text = Trim(SQLReader.Item("current_mileage"))
    '    Else
    '        'LblLastPurchaseAmount.Text = ""
    '    End If
    '    SQLReader.Close()
    'End Sub
    'Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
    '    Dim i As Integer
    '    For i = 0 To MyForm.Controls.Count - 1
    '        MyForm.Controls(i).Enabled = MyStat
    '    Next i
    'End Sub
    'Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
    '    Call PAddNew()
    'End Sub
    'Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
    '    Call PEdit()
    'End Sub
    'Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
    '    Call PDelete()
    'End Sub
    'Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
    '    Call PSave()
    'End Sub
    'Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
    '    Call PCancel()
    'End Sub
    'Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
    '    Call PFirstRecord()
    'End Sub
    'Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
    '    Call PPreviousRecord()
    'End Sub
    'Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
    '    Call PNextRecord()
    'End Sub
    'Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
    '    Call PLastRecord()
    'End Sub
    'Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UIContextMenu1.CommandClick
    '    UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
    '    UIContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
    '    UIContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
    '    UIContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
    '    Select Case e.Command.Key.ToUpper
    '        Case "SORT1"
    '            ReceivePaymentOrderFieldName = "Refrence_No"
    '            ReceivePaymentOrderVar1 = "Refrence_No"
    '            ReceivePaymentOrderVar2 = ""
    '        Case "SORT2"
    '            ReceivePaymentOrderFieldName = "cod_customer"
    '            ReceivePaymentOrderVar1 = "cod_customer"
    '            ReceivePaymentOrderVar2 = "Refrence_No"
    '        Case "SORT3"
    '            ReceivePaymentOrderFieldName = "date_receive_payment"
    '            ReceivePaymentOrderVar1 = "date_receive_payment"
    '            ReceivePaymentOrderVar2 = "Refrence_No"
    '    End Select
    'End Sub
    'Private Sub TxtRefrence_no_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRefrence_no.Leave
    '    Try
    '        MyClsReceivePayment.Connection = Cnn
    '    Catch ex As Exception
    '    End Try
    '    If MyClsReceivePayment.FindDesc(TxtRefrence_no.Text) Then
    '        MsgBox("This Reference No already axist.Try a new Code")
    '        TxtRefrence_no.Clear()
    '        TxtRefrence_no.Focus()
    '    End If
    '    OldReferenceNo = TxtRefrence_no.Text
    'End Sub
    'Private Function MakeNewReferenceNo(ByVal ThisConnectionStringVar As String) As String
    '    Dim i As Integer
    '    Dim ValMakeNewcod As String
    '    Try
    '        If CmdGeneral.Connection.State = ConnectionState.Open Then
    '            CmdGeneral.Connection.Close()
    '        End If
    '        CmdGeneral.Connection.ConnectionString = ThisConnectionStringVar

    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        CmdGeneral.CommandText = "Select Max(Refrence_No) as Max_cod from Gl_receive_payment WHERE substring(Refrence_No,1,2)='RA'"
    '        MakeNewReferenceNo = Trim(CmdGeneral.ExecuteScalar)
    '        ValMakeNewcod = GetVal(MakeNewReferenceNo, LenReceivePaymentReferenceNo)
    '        If ValMakeNewcod > 0 Then
    '            i = Len(ValMakeNewcod)
    '        Else
    '            i = 0
    '        End If
    '        If MakeNewReferenceNo.Length >= i Then
    '            MakeNewReferenceNo = Mid(MakeNewReferenceNo, 1, Len(MakeNewReferenceNo) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
    '        End If
    '        If MakeNewReferenceNo.Trim.Length > LenReceivePaymentReferenceNo Then
    '            MakeNewReferenceNo = "RA000001"
    '        End If
    '    Catch ex As Exception
    '        MakeNewReferenceNo = "RA000001"
    '    End Try
    '    If CmdGeneral.Connection.State = ConnectionState.Open Then
    '        CmdGeneral.Connection.Close()
    '    End If
    '    CmdGeneral.Connection.ConnectionString = PConnectionString
    'End Function
    'Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
    '    LblCustomerName.Text = CustomerCod1.CustomerDesc
    'End Sub
    'Private Sub CustomerCod1_NotFindCustomerCod() Handles CustomerCod1.NotFindCustomerCod
    '    LblCustomerName.Text = ""
    'End Sub
    'Private Sub CustomerCod1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerCod1.Leave
    '    If (Status = MainModule.WorkStates.AddNew Or Status = MainModule.WorkStates.Edit) And Not CustomerCod1.ARCharge Then
    '        MsgBox("This Option only available to AR Customers.")
    '    End If
    '    Call FillGridInformation()
    '    Call CalculateCreditRemaining()
    'End Sub
    'Private Sub FillGridInformation()
    '    DsFrmReceivePayment1.service_center_dtl.Clear()
    '    If CustomerCod1.CustomerCod.Trim.Length > 0 Then
    '        DsFrmReceivePayment1.service_center_dtl.Clear()

    '        DsFrmReceivePayment1.Store_Setup.Clear()
    '        DASTORE_SETUP.Fill(DsFrmReceivePayment1, "Store_Setup")
    '        Dim StoreCounterVar As Integer
    '        Dim ThisConnectionStringVar As String
    '        For StoreCounterVar = 0 To DsFrmReceivePayment1.Store_Setup.Rows.Count - 1
    '            ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
    '            If ThisConnectionStringVar.Trim.Length > 0 Then
    '                Try
    '                    If Cnn.State = ConnectionState.Open Then
    '                        Cnn.Close()
    '                    End If
    '                    Cnn.ConnectionString = ThisConnectionStringVar

    '                    DAService_center_dtl.SelectCommand.Parameters("@Cod_Customer").Value = CustomerCod1.CustomerCod
    '                    DAService_center_dtl.SelectCommand.Parameters("@STORENO").Value = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
    '                    DAService_center_dtl.Fill(DsFrmReceivePayment1, "service_center_dtl")

    '                Catch ex As Exception
    '                    MsgBox("Please Call to Your Vendor.Error In Setup Files")
    '                End Try
    '            End If
    '        Next
    '        If Cnn.State = ConnectionState.Open Then
    '            Cnn.Close()
    '        End If
    '        Cnn.ConnectionString = PConnectionString
    '        If CnnTemp.State = ConnectionState.Open Then
    '            CnnTemp.Close()
    '        End If
    '        CnnTemp.ConnectionString = PConnectionString
    '    End If

    '    Call CalcDiscountAndAmountDue(True)
    '    'DsFrmReceivePayment1.Tables("service_center_dtl").DefaultView.RowFilter = "AmountDue>0" 'FilterField & " like '*" & TxtSearch.Text.Trim & "*'"
    '    'DsFrmReceivePayment1.Tables("service_center_dtl").DefaultView.Sort = "DateForSort"
    '    'GrdDetail.DataSource = DsFrmReceivePayment1.Tables("service_center_dtl")

    '    Call SayTotals()
    'End Sub
    'Private Function CalculateDiscount(ByVal InvoiceParam As String, ByVal InvoiceDate As String, ByVal ARTermParam As String) As Decimal
    '    CalculateDiscount = 0
    '    If InvoiceDate.Trim.Length > 0 And ARTermParam.Trim.Length > 0 And Dtedate_receive_payment.Text.Trim.Length > 0 Then
    '        Dim SQLReader As System.Data.SqlClient.SqlDataReader
    '        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
    '            CmdGeneralForReader.Connection.Open()
    '        End If
    '        CmdGeneralForReader.CommandText = "Select top 1 * From GL_TAB_AR_TERM where AR_terms=" & Qt(ARTermParam)
    '        SQLReader = CmdGeneralForReader.ExecuteReader
    '        If SQLReader.HasRows Then
    '            SQLReader.Read()
    '            Select Case SQLReader.Item("KIND_AR")
    '                Case 1
    '                    If CType(Dtedate_receive_payment.Text, Date).Subtract(CType(InvoiceDate, Date)).TotalDays <= SQLReader.Item("ST_IF_PAY_WITHIN_DAYS") Then
    '                        CalculateDiscount = SQLReader.Item("ST_DISCOUNT_PERCENTAGE")
    '                    End If
    '                Case 2
    '                    If CType(Dtedate_receive_payment.Text, Date).Subtract(CType(InvoiceDate, Date)).TotalDays <= SQLReader.Item("DD_IF_PAY_WITHIN_DAYS") Then
    '                        CalculateDiscount = SQLReader.Item("DD_DISCOUNT_PERCENTAGE")
    '                    End If
    '            End Select
    '        End If
    '        SQLReader.Close()
    '    End If
    'End Function
    'Private Sub BtnUnApplyPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnApplyPayment.Click
    '    If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '        Dim i As Integer
    '        For i = 0 To GrdDetail.RowCount - 1
    '            GrdDetail.Row = i
    '            If GrdDetail.GetRow().Cells("AmountDue").Value > 0 Then
    '                GrdDetail.GetRow().Cells("Payment").Value = 0
    '                GrdDetail.GetRow().Cells(0).Value = 0
    '            End If
    '        Next
    '        For i = 0 To DsFrmReceivePayment1.service_center_dtl.Rows.Count - 1
    '            If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("AmountDue") > 0 Then
    '                DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment") = 0
    '                DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("CheckFlag") = False
    '            End If
    '        Next
    '        Call SayTotals()
    '        GrdDetail.Row = 0
    '        GrdDetail.Focus()
    '        'SendKeys.Send("{PGUP}")
    '    End If
    'End Sub
    'Private Sub BtnAutoApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAutoApply.Click
    '    Call AutoApply()
    'End Sub
    'Private Sub AutoApply()
    '    If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '        Dim i As Integer
    '        Dim Amount_ReceiveVar As Decimal = 0
    '        Amount_ReceiveVar = NumAmount_Receive.Numbervalue
    '        For i = 0 To GrdDetail.RowCount - 1
    '            GrdDetail.Row = i
    '            If GrdDetail.GetRow().Cells("AmountDue").Value > 0 Then
    '                If Amount_ReceiveVar = 0 Then
    '                    GrdDetail.GetRow().Cells("Payment").Value = 0
    '                    GrdDetail.GetRow().Cells(0).Value = 0
    '                Else
    '                    If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("AmountDue") <= Amount_ReceiveVar Then
    '                        GrdDetail.GetRow().Cells("Payment").Value = GrdDetail.GetRow().Cells("AmountDue").Value
    '                    Else
    '                        GrdDetail.GetRow().Cells("Payment").Value = Amount_ReceiveVar
    '                    End If
    '                    Amount_ReceiveVar = Amount_ReceiveVar - GrdDetail.GetRow().Cells("Payment").Value
    '                    GrdDetail.GetRow().Cells(0).Value = 1
    '                End If
    '            End If
    '        Next

    '        Amount_ReceiveVar = NumAmount_Receive.Numbervalue
    '        For i = 0 To DsFrmReceivePayment1.service_center_dtl.Rows.Count - 1
    '            If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("AmountDue") > 0 Then
    '                If Amount_ReceiveVar = 0 Then
    '                    DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment") = 0
    '                    DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("CheckFlag") = False
    '                Else
    '                    If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("AmountDue") <= Amount_ReceiveVar Then
    '                        DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment") = DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("AmountDue")
    '                    Else
    '                        DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment") = Amount_ReceiveVar
    '                    End If
    '                    Amount_ReceiveVar = Amount_ReceiveVar - DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment")
    '                    DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("CheckFlag") = True
    '                End If
    '            End If
    '        Next
    '        Call SayTotals()
    '        GrdDetail.Row = 0
    '        GrdDetail.Focus()
    '        'SendKeys.Send("{PGUP}")
    '        'NumAmount_Receive.Focus()
    '    End If
    'End Sub
    'Private Sub SayTotals()
    '    If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '        Try
    '            LblTotalOriginalAmount.Text = Math.Round(DsFrmReceivePayment1.service_center_dtl.Compute("Sum(OriginalAmount)", "AmountDue>0"), 2)
    '        Catch ex As Exception
    '            LblTotalOriginalAmount.Text = 0
    '        End Try
    '        Try
    '            LblTotalAmountDue.Text = Math.Round(DsFrmReceivePayment1.service_center_dtl.Compute("Sum(AmountDue)", "AmountDue>0"), 2)
    '        Catch ex As Exception
    '            LblTotalAmountDue.Text = 0
    '        End Try
    '        Try
    '            lblTotalPayment.Text = Math.Round(DsFrmReceivePayment1.service_center_dtl.Compute("Sum(Payment)", "AmountDue>0 AND CheckFlag=1"), 2)
    '        Catch ex As Exception
    '            lblTotalPayment.Text = 0
    '        End Try

    '        Dim StoreCounterVar As Integer
    '        Dim TempVar As String
    '        For StoreCounterVar = 0 To DsFrmReceivePayment1.Store_Setup.Rows.Count - 1
    '            Try
    '                TempVar = Math.Round(DsFrmReceivePayment1.service_center_dtl.Compute("Sum(Payment)", "AmountDue>0 AND CheckFlag=1 AND StoreNo=" & Qt(DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))), 2)
    '            Catch ex As Exception
    '                TempVar = 0
    '            End Try
    '            DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("Amount") = TempVar
    '        Next
    '        Try
    '            NumAmountForOtherStore.Text = Math.Round(DsFrmReceivePayment1.service_center_dtl.Compute("Sum(Payment)", "AmountDue>0 AND CheckFlag=1 AND StoreNo<>" & Qt(PubStoreNO)), 2)
    '        Catch ex As Exception
    '            NumAmountForOtherStore.Text = 0
    '        End Try

    '    End If
    '    Call SaySelectedRowsTotals()
    'End Sub
    'Private Sub SaySelectedRowsTotals()
    '    Try
    '        If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '            Try
    '                lblAmountDue.Text = LblTotalAmountDue.Text - lblTotalPayment.Text
    '            Catch ex As Exception
    '                lblAmountDue.Text = 0
    '            End Try
    '            Try
    '                lblApplied.Text = Math.Round(DsFrmReceivePayment1.service_center_dtl.Compute("Sum(Payment)", "CheckFlag=1 AND AmountDue>0"), 2)
    '            Catch ex As Exception
    '                lblApplied.Text = 0
    '            End Try
    '        End If
    '    Catch ex As Exception
    '        lblAmountDue.Text = 0
    '        lblApplied.Text = 0
    '    End Try
    'End Sub
    'Private Sub NumMonth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NumMonth.Validating
    '    If NumMonth.Text < 0 Or NumMonth.Text > 12 Then
    '        NumMonth.Text = 0
    '        MsgBox("Please Fill Month Correctly")
    '        e.Cancel = True
    '    End If
    'End Sub
    'Private Sub NumYear_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NumYear.Validating
    '    If NumYear.Text < 1950 Or NumYear.Text > 2050 Then
    '        MsgBox("Please Fill Year Correctly")
    '        NumYear.Text = 0
    '        e.Cancel = True
    '    End If
    'End Sub
    'Private Sub ChangePaid_amountToOriginalValue()
    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    If DsFrmReceivePayment1.GL_payment_deposit.Rows.Count > 0 Then
    '        Dim i As Integer
    '        Dim ThisConnectionStringVar As String
    '        For i = 0 To DsFrmReceivePayment1.GL_payment_deposit.Rows.Count - 1
    '            ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.GL_payment_deposit.Rows(i).Item("StoreNo"))
    '            If ThisConnectionStringVar.Trim.Length > 0 Then
    '                Try
    '                    If Cnn.State = ConnectionState.Open Then
    '                        Cnn.Close()
    '                    End If
    '                    Cnn.ConnectionString = ThisConnectionStringVar

    '                    If DsFrmReceivePayment1.GL_payment_deposit.Rows(i).Item("ID_payment_due") > 0 Then
    '                        CmdGeneral.CommandText = "Update GL_payment_deposit set Paid_amount=Paid_amount-" & DsFrmReceivePayment1.GL_payment_deposit.Rows(i).Item("payment_amount") & " where ID_payment=" & DsFrmReceivePayment1.GL_payment_deposit.Rows(i).Item("ID_payment_due") & " AND  Paid_amount>=" & DsFrmReceivePayment1.GL_payment_deposit.Rows(i).Item("payment_amount")
    '                        CmdGeneral.ExecuteNonQuery()
    '                    End If
    '                Catch ex As Exception
    '                    MsgBox("Please Call to Your Vendor.Error In Setup Files")
    '                End Try
    '            End If
    '        Next
    '        If Cnn.State = ConnectionState.Open Then
    '            Cnn.Close()
    '        End If
    '        Cnn.ConnectionString = PConnectionString
    '    End If

    'End Sub
    'Private Sub SaveGL_payment_deposit()

    '    Call UpdateAndDelete(False)

    '    Try
    '        If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '            Dim Flag_GL_account_adjustment_head_Inserted As Boolean = False
    '            Dim iii As Integer = 0
    '            Dim i As Integer
    '            Dim Gl_receive_payment_Refrence_noVar As String = ""
    '            Dim Amount_ReceiveVar As Double = NumAmount_Receive.Numbervalue
    '            Dim TotalAccountAdjustmentVar As Decimal = 0
    '            Dim AccountAdjustmentVar As Decimal = 0
    '            Dim ID_payment_PaidVar As Int16 = 0
    '            Dim ThisConnectionStringVar As String
    '            Dim ThisTxtRefrence_noTempVar As String
    '            For i = 0 To DsFrmReceivePayment1.service_center_dtl.Rows.Count - 1
    '                If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("AmountDue") > 0 Then
    '                    If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("CheckFlag") Then
    '                        If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("StoreNo") = PubStoreNO Then
    '                            ThisTxtRefrence_noTempVar = TxtRefrence_no.Text
    '                        Else
    '                            ThisTxtRefrence_noTempVar = DsFrmReceivePayment1.Store_Setup.FindBySTORENO(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("StoreNo")).Item("Refrence_no")
    '                        End If
    '                        ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("StoreNo"))
    '                        If Cnn.State = ConnectionState.Open Then
    '                            Cnn.Close()
    '                        End If
    '                        Cnn.ConnectionString = ThisConnectionStringVar
    '                        If Cnn.State <> ConnectionState.Open Then
    '                            Cnn.Open()
    '                        End If
    '                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount,discount) values (" & Qt(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("InvoiceNo")) & "," & Qt(ThisTxtRefrence_noTempVar) & ",'3'," & Qt(IIf(RdoCash.Checked, 1, IIf(RdoCheck.Checked, 2, IIf(RdoCreditCard.Checked, 3, 0)))) & "," & DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment") & "," & DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Discount") & ");Select @@Identity from GL_payment_deposit"
    '                        ID_payment_PaidVar = CmdGeneral.ExecuteScalar()
    '                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit_Detail (ID_payment_due,ID_payment_Paid,refrence_no) values (" & Qt(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("ID_payment")) & "," & ID_payment_PaidVar & "," & Qt(ThisTxtRefrence_noTempVar) & ")"
    '                        CmdGeneral.ExecuteNonQuery()
    '                        CmdGeneral.CommandText = "Update GL_payment_deposit set Paid_amount=Paid_amount+" & DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment") & " where ID_payment=" & DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("ID_payment")
    '                        CmdGeneral.ExecuteNonQuery()
    '                        If DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Discount") > 0 Then
    '                            If Not Flag_GL_account_adjustment_head_Inserted Then
    '                                Flag_GL_account_adjustment_head_Inserted = True
    '                                Gl_receive_payment_Refrence_noVar = MakeNewGL_account_adjustment_headReferenceNo(ThisConnectionStringVar)
    '                                If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '                                    CmdGeneral.Connection.Open()
    '                                End If
    '                                For iii = 0 To 10
    '                                    CmdGeneral.CommandText = "INSERT INTO GL_account_adjustment_head (refrence_no, cod_customer, amount_adjustment, date_adjustment, Remark, GL_account, Gl_receive_payment_Refrence_no) Values " & _
    '                                     "(" & Qt(Gl_receive_payment_Refrence_noVar) & "," & Qt(CustomerCod1.CustomerCod) & "," & -NumAmount_Receive.Numbervalue & "," & Qt(Dtedate_receive_payment.Text) & "," & Qt(TxtRemark.Text) & "," & Qt(CmbGl_account.SelectedValue) & "," & Qt(TxtRefrence_no.Text) & ")"
    '                                    Try
    '                                        CmdGeneral.ExecuteNonQuery()
    '                                        Exit For
    '                                    Catch ex As Exception
    '                                        Gl_receive_payment_Refrence_noVar = MakeNewGL_account_adjustment_headReferenceNo(ThisConnectionStringVar)
    '                                    End Try
    '                                Next
    '                                If iii = 11 Then
    '                                    MsgBox("Please try again")
    '                                    Exit Sub
    '                                End If
    '                            End If
    '                            'AccountAdjustmentVar = Math.Round(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("OriginalAmount") - IIf(IsDBNull(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("OldPayment")), 0, DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("OldPayment")), 2) - DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("AmountDue")
    '                            AccountAdjustmentVar = Math.Round((DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Payment") * DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("Discount")) / 100, 2)
    '                            If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '                                CmdGeneral.Connection.Open()
    '                            End If
    '                            If AccountAdjustmentVar <> 0 Then
    '                                CmdGeneral.CommandText = "SELECT COUNT(*) FROM GL_account_adjustment_dtl WHERE id_service_center= " & Qt(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("InvoiceNo")) & " AND refrence_no=" & Qt(Gl_receive_payment_Refrence_noVar)
    '                                If CmdGeneral.ExecuteScalar > 0 Then
    '                                    CmdGeneral.CommandText = "Update GL_account_adjustment_dtl set amount_adjustment=amount_adjustment+" & -AccountAdjustmentVar & " WHERE id_service_center= " & Qt(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("InvoiceNo")) & " AND refrence_no=" & Qt(Gl_receive_payment_Refrence_noVar)
    '                                Else
    '                                    CmdGeneral.CommandText = "Insert Into GL_account_adjustment_dtl  (id_service_center,refrence_no,amount_adjustment) values (" & Qt(DsFrmReceivePayment1.service_center_dtl.Rows(i).Item("InvoiceNo")) & "," & Qt(Gl_receive_payment_Refrence_noVar) & "," & -AccountAdjustmentVar & ")"
    '                                End If
    '                                CmdGeneral.ExecuteNonQuery()
    '                                TotalAccountAdjustmentVar = TotalAccountAdjustmentVar + AccountAdjustmentVar
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            Next
    '            If Flag_GL_account_adjustment_head_Inserted Then
    '                Dim StoreCounterVar As Integer
    '                Dim TempVar As String
    '                For StoreCounterVar = 0 To DsFrmReceivePayment1.Store_Setup.Rows.Count - 1
    '                    ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.GL_payment_deposit.Rows(i).Item("StoreNo"))
    '                    If Cnn.State = ConnectionState.Open Then
    '                        Cnn.Close()
    '                    End If
    '                    Cnn.ConnectionString = ThisConnectionStringVar
    '                    If Cnn.State <> ConnectionState.Open Then
    '                        Cnn.Open()
    '                    End If
    '                    CmdGeneral.CommandText = "Select isnull(sum(round(isnull(amount_adjustment,0),2)),0) FROM GL_account_adjustment_dtl WHERE refrence_no = " & Qt(Gl_receive_payment_Refrence_noVar)
    '                    TempVar = CmdGeneral.ExecuteScalar
    '                    If TempVar <> 0 Then
    '                        CmdGeneral.CommandText = "Update GL_account_adjustment_head Set amount_adjustment= " & TempVar & " WHERE refrence_no = " & Qt(Gl_receive_payment_Refrence_noVar)
    '                        CmdGeneral.ExecuteNonQuery()
    '                    Else
    '                        CmdGeneral.CommandText = "Delete From GL_account_adjustment_head WHERE refrence_no = " & Qt(Gl_receive_payment_Refrence_noVar)
    '                        CmdGeneral.ExecuteNonQuery()
    '                    End If

    '                Next
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Call RoleBackRecords()
    '        MsgBox("Error In Save")
    '    End Try

    '    If Cnn.State = ConnectionState.Open Then
    '        Cnn.Close()
    '    End If
    '    Cnn.ConnectionString = PConnectionString
    'End Sub
    'Private Sub CalculateCreditRemaining()
    '    Try
    '        LblBalance.Text = DsFrmReceivePayment1.service_center_dtl.Compute("Sum(AmountDue)", "AmountDue>0")
    '    Catch ex As Exception
    '        LblBalance.Text = 0
    '    End Try
    'End Sub
    'Private Sub NumAmount_Receive_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumAmount_Receive.Leave
    '    'Call AutoApply()
    'End Sub
    'Private Sub RdoCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoCash.CheckedChanged, RdoCheck.CheckedChanged, RdoCreditCard.CheckedChanged
    '    Call CheckRdoControls()
    '    Call SaveButtonControl()
    'End Sub
    'Private Sub CheckRdoControls()
    '    If RdoCash.Checked Then
    '        TxtCheck_no.Enabled = False
    '        TxtCc_no.Enabled = False
    '        TxtAuthNo.Enabled = False
    '        CmbCc_type.Enabled = False
    '        NumYear.Enabled = False
    '        NumMonth.Enabled = False
    '    End If
    '    If RdoCheck.Checked Then
    '        TxtCheck_no.Enabled = NumAmount_Receive.Enabled
    '        TxtCc_no.Enabled = False
    '        TxtAuthNo.Enabled = False
    '        CmbCc_type.Enabled = False
    '        NumYear.Enabled = False
    '        NumMonth.Enabled = False
    '    End If
    '    If RdoCreditCard.Checked Then
    '        TxtCheck_no.Enabled = False
    '        TxtCc_no.Enabled = NumAmount_Receive.Enabled
    '        TxtAuthNo.Enabled = NumAmount_Receive.Enabled
    '        CmbCc_type.Enabled = NumAmount_Receive.Enabled
    '        NumYear.Enabled = NumAmount_Receive.Enabled
    '        NumMonth.Enabled = NumAmount_Receive.Enabled
    '    End If
    'End Sub
    'Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
    '    Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
    '    Dim ThisTableIDVar As Integer = CurrentRow.Cells("ThisTableID").Value
    '    Select Case e.Column.Index
    '        Case 0
    '            If CurrentRow.Cells(0).Value = True Then
    '                DsFrmReceivePayment1.service_center_dtl.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 0
    '                CurrentRow.Cells(5).Value = 0
    '            Else
    '                DsFrmReceivePayment1.service_center_dtl.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 1
    '                CurrentRow.Cells(5).Value = IIf(NumAmount_Receive.Numbervalue - lblTotalPayment.Numbervalue <= CurrentRow.Cells(4).Value, NumAmount_Receive.Numbervalue - lblTotalPayment.Numbervalue, CurrentRow.Cells(4).Value)
    '                DsFrmReceivePayment1.service_center_dtl.Rows.Find(ThisTableIDVar).Item("Payment") = CurrentRow.Cells(5).Value
    '            End If
    '            'TxtRemark.Focus()

    '            'Call SelectRow(GrdDetail.Row, 4)
    '    End Select
    '    Call SayTotals()
    '    'GrdDetail.UpdateData()
    '    'Call SaySelectedRowsTotals()
    'End Sub
    'Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
    '    Reference_No1.BtnSearch_Click(sender, e)
    'End Sub
    'Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
    '    GrdDetail.UpdateData()
    '    Call SaySelectedRowsTotals()
    '    Call SaveButtonControl()
    '    Try
    '        lblTotalPayment.Text = Math.Round(DsFrmReceivePayment1.service_center_dtl.Compute("Sum(Payment)", "AmountDue>0 AND CheckFlag=1"), 2)
    '    Catch ex As Exception
    '        lblTotalPayment.Text = 0
    '    End Try

    '    'Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
    '    'If CurrentRow.Cells(5).Value > 0 Then
    '    '    CurrentRow.Cells(0).Value = True
    '    '    DsFrmReceivePayment1.service_center_dtl.Rows.Find(CurrentRow.Cells("ThisTableID").Value).Item("CheckFlag") = 1
    '    'End If
    'End Sub
    'Private Sub CalcDiscountAndAmountDue(ByVal SetAmountDueFlag As Boolean)
    '    If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '        Dim i As Integer
    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        Dim Amount_payTempVar As Double = 0
    '        Dim AmountAdjustmentVar As Double = 0
    '        Dim InvoiceTempVar As String = ""
    '        Dim StoreTempVar As String = ""
    '        Dim ThisConnectionStringVar As String
    '        For i = 0 To DsFrmReceivePayment1.service_center_dtl.DefaultView.Sort = "StoreNo,Invoiceno"

    '        Next
    '        For i = 0 To DsFrmReceivePayment1.service_center_dtl.DefaultView.Count - 1
    '            ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("StoreNo"))
    '            Try
    '                If Cnn.State = ConnectionState.Open Then
    '                    Cnn.Close()
    '                End If
    '                Cnn.ConnectionString = ThisConnectionStringVar
    '                If Cnn.State <> ConnectionState.Open Then
    '                    Cnn.Open()
    '                End If

    '                If InvoiceTempVar <> DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("InvoiceNo") Or StoreTempVar <> DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("StoreNo") Then
    '                    InvoiceTempVar = DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("InvoiceNo")
    '                    StoreTempVar = DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("StoreNo")
    '                    CmdGeneral.CommandText = "SELECT isnull(amount_adjustment,0) FROM  GL_account_adjustment_dtl where  id_service_center=" & Qt(InvoiceTempVar)
    '                    Try
    '                        AmountAdjustmentVar = CmdGeneral.ExecuteScalar()
    '                    Catch ex As Exception
    '                        AmountAdjustmentVar = 0
    '                    End Try
    '                End If

    '                DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("AmountDue") = DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("AmountDue") + AmountAdjustmentVar
    '                AmountAdjustmentVar = 0

    '                If SetAmountDueFlag Then
    '                    Try
    '                        Amount_payTempVar = DsFrmReceivePayment1.GL_payment_deposit.FindByID_payment_due(DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("ID_payment")).Item("payment_amount")
    '                    Catch ex As Exception
    '                        Amount_payTempVar = 0
    '                    End Try
    '                    DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("AmountDue") = DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("AmountDue") + Amount_payTempVar
    '                End If
    '                Try
    '                    If DsFrmReceivePayment1.GL_payment_deposit.FindByID_payment_due(DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("ID_payment")) Is Nothing Then
    '                        DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("Discount") = CalculateDiscount(DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("InvoiceNo") & "", DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("InvoiceDate") & "", DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("AR_terms") & "")
    '                    Else
    '                        DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("Discount") = DsFrmReceivePayment1.GL_payment_deposit.FindByID_payment_due(DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("ID_payment")).Item("Discount")
    '                    End If
    '                Catch ex As Exception
    '                    DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("Discount") = CalculateDiscount(DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("InvoiceNo") & "", DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("InvoiceDate") & "", DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("AR_terms") & "")
    '                End Try

    '                If SetAmountDueFlag Then
    '                    DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("Payment") = Amount_payTempVar
    '                    If Amount_payTempVar = 0 Then
    '                        DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("CheckFlag") = False
    '                    Else
    '                        DsFrmReceivePayment1.service_center_dtl.DefaultView(i).Item("CheckFlag") = True
    '                    End If
    '                End If
    '            Catch ex As Exception
    '                MsgBox("Please Call to Your Vendor.Error In Setup Files")
    '            End Try
    '        Next
    '    End If

    '    ''''''''If Status = MainModule.WorkStates.AddNew Then
    '    ''''''''    Call AutoApply()
    '    ''''''''End If
    'End Sub
    'Private Sub Dtedate_receive_payment_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtedate_receive_payment.Leave
    '    Call CalcDiscountAndAmountDue(False)
    'End Sub
    'Private Function MakeNewGL_account_adjustment_headReferenceNo(ByVal ThisConnectionStringVar As String) As String
    '    Dim i As Integer
    '    Dim ValMakeNewcod As String
    '    Try
    '        If CmdGeneral.Connection.State = ConnectionState.Open Then
    '            CmdGeneral.Connection.Close()
    '        End If
    '        CmdGeneral.Connection.ConnectionString = ThisConnectionStringVar

    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        CmdGeneral.CommandText = "Select Max(Refrence_No) as Max_cod from GL_account_adjustment_head WHERE substring(Refrence_No,1,2)='AA'"
    '        MakeNewGL_account_adjustment_headReferenceNo = Trim(CmdGeneral.ExecuteScalar)
    '        ValMakeNewcod = GetVal(MakeNewGL_account_adjustment_headReferenceNo, LenAccountAdjustmentReferenceNo)
    '        If ValMakeNewcod > 0 Then
    '            i = Len(ValMakeNewcod)
    '        Else
    '            i = 0
    '        End If
    '        If MakeNewGL_account_adjustment_headReferenceNo.Length >= i Then
    '            MakeNewGL_account_adjustment_headReferenceNo = Mid(MakeNewGL_account_adjustment_headReferenceNo, 1, Len(MakeNewReferenceNo(ThisConnectionStringVar)) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
    '        End If
    '        If MakeNewGL_account_adjustment_headReferenceNo.Trim.Length > LenAccountAdjustmentReferenceNo Then
    '            MakeNewGL_account_adjustment_headReferenceNo = "AA000001"
    '        End If
    '    Catch ex As Exception
    '        MakeNewGL_account_adjustment_headReferenceNo = "AA000001"
    '    End Try
    '    If CmdGeneral.Connection.State = ConnectionState.Open Then
    '        CmdGeneral.Connection.Close()
    '    End If
    '    CmdGeneral.Connection.ConnectionString = PConnectionString
    'End Function
    'Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    '    Call pprint("print")
    'End Sub

    'Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
    '    Call pprint("priv")
    'End Sub

    'Private Sub BtnFax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFax.Click
    '    Call pprint("fax")
    'End Sub
    'Private Sub pprint(ByVal PrintType As String)

    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    CmdGeneral.CommandText = "SELECT count(*) FROM Gl_receive_payment where refrence_no=" & Qt(TxtRefrence_no.Text)
    '    If CmdGeneral.ExecuteScalar <> 1 Then
    '        MsgBox("Please First Save the Adjustment")
    '        Exit Sub
    '    End If

    '    If DsFrmReceivePayment1.service_center_dtl.Rows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    Dim rpt As New RepReceivePayment
    '    Dim prn As New FrmRepView

    '    rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

    '    Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
    '    OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

    '    rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
    '    rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

    '    MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
    '    MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
    '    rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

    '    rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
    '    rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
    '    rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

    '    DsFrmReceivePayment1.LOGO.Clear()
    '    Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
    '    OleDbReaderForCompany = RetrieveCompanySetupTable()
    '    Try
    '        DsFrmReceivePayment1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))
    '    MyZipCode.ZipCode = CustomerCod1.ZipCode
    '    MyZipCode.FindDesc(CustomerCod1.ZipCode)
    '    rpt.SetParameterValue("ParCusName", CustomerCod1.CustomerDesc)
    '    rpt.SetParameterValue("ParCusAddress", CustomerCod1.Address)
    '    rpt.SetParameterValue("Parcusaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
    '    rpt.SetParameterValue("ParCusPhone", CustomerCod1.CustomerPhone)
    '    rpt.SetParameterValue("Parkindrep", "Payement Receipt")
    '    rpt.SetParameterValue("parcusno", CustomerCod1.Text)
    '    rpt.SetParameterValue("pardate", Dtedate_receive_payment.Text)
    '    rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))
    '    rpt.SetParameterValue("parno", TxtRefrence_no.Text)
    '    If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
    '        If RdoCash.Checked Then
    '            rpt.SetParameterValue("parcash", lblApplied.Text)
    '            rpt.SetParameterValue("parcheck", "")
    '            rpt.SetParameterValue("parcheckno", "")
    '            rpt.SetParameterValue("parcrcard", "")
    '            rpt.SetParameterValue("parcctype", "") ''''''''''''
    '            rpt.SetParameterValue("parauthcode", "")
    '        Else
    '            If RdoCheck.Checked Then
    '                rpt.SetParameterValue("parcash", "")
    '                rpt.SetParameterValue("parcheck", lblApplied.Text)
    '                rpt.SetParameterValue("parcheckno", TxtCheck_no.Text)
    '                rpt.SetParameterValue("parcrcard", "")
    '                rpt.SetParameterValue("parcctype", "") ''''''''''''
    '                rpt.SetParameterValue("parauthcode", "")
    '            Else
    '                rpt.SetParameterValue("parcash", "")
    '                rpt.SetParameterValue("parcheck", "")
    '                rpt.SetParameterValue("parcheckno", "")
    '                rpt.SetParameterValue("parcrcard", lblApplied.Text)
    '                rpt.SetParameterValue("parcctype", CmbCc_type.Text) ''''''''''''
    '                rpt.SetParameterValue("parauthcode", TxtAuthNo.Text)
    '            End If
    '        End If
    '    End If
    '    rpt.SetParameterValue("parpayamount", NumAmount_Receive.Text)
    '    rpt.SetParameterValue("parpribalanse", LblBalance.Text)
    '    rpt.SetParameterValue("parnewbalance", lblAmountDue.Text)
    '    rpt.SetParameterValue("parmemo", TxtRemark.Text)
    '    rpt.SetDataSource(DsFrmReceivePayment1)
    '    Select Case PrintType
    '        Case "print"
    '            rpt.PrintToPrinter(1, True, 0, 0)
    '        Case "priv"
    '            prn.CrViewer.ReportSource = rpt
    '            prn.ShowDialog()
    '        Case "fax"
    '            Try
    '                rpt.PrintOptions.PrinterName = "Fax"
    '                rpt.PrintToPrinter(1, True, 0, 0)
    '            Catch ex As Exception
    '                MsgBox("Add The FAX in (Printers and Faxes)")
    '            End Try
    '    End Select

    'End Sub
    'Private Function CanChangeOrDelete() As Boolean
    '    CanChangeOrDelete = True
    '    If DsFrmReceivePayment1.GL_payment_deposit.Rows.Count > 0 Then
    '        Dim i As Integer
    '        For i = 0 To DsFrmReceivePayment1.GL_payment_deposit.Rows.Count - 1
    '            If DsFrmReceivePayment1.GL_payment_deposit.Rows(i).Item("flag_deposit_bank") = True Then
    '                CanChangeOrDelete = False
    '                Exit For
    '            End If
    '        Next
    '    End If
    'End Function
    'Private Sub BtnOtherStorePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOtherStorePayment.Click
    '    GrdOtherStorePayment.Visible = Not GrdOtherStorePayment.Visible
    'End Sub
    'Private Sub BtnCustomerBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerBalance.Click
    '    Dim MyFrmCustomerBalance As New UCCustomer.FrmCustomerBalance
    '    MyFrmCustomerBalance.Cod_customerParameter = CustomerCod1.CustomerCod
    '    MyFrmCustomerBalance.LblCustomer.Text = CustomerCod1.CustomerCod
    '    MyFrmCustomerBalance.LblCompany.Text = LblCustomerName.Text
    '    MyFrmCustomerBalance.LblName.Text = CustomerCod1.F_Name & " " & CustomerCod1.M_Name & " " & CustomerCod1.L_Name
    '    MyFrmCustomerBalance.ShowDialog()
    'End Sub
    'Private Sub RoleBackRecords()
    '    Dim StoreCounterVar As Integer
    '    Dim ThisConnectionStringVar As String
    '    For StoreCounterVar = 0 To DsFrmReceivePayment1.Store_Setup.Rows.Count - 1
    '        ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
    '        Try
    '            If Cnn.State = ConnectionState.Open Then
    '                Cnn.Close()
    '            End If
    '            Cnn.ConnectionString = ThisConnectionStringVar
    '            If Cnn.State <> ConnectionState.Open Then
    '                Cnn.Open()
    '            End If

    '            If CnnForReader.State = ConnectionState.Open Then
    '                CnnForReader.Close()
    '            End If
    '            CnnForReader.ConnectionString = ThisConnectionStringVar
    '            If CnnForReader.State <> ConnectionState.Open Then
    '                CnnForReader.Open()
    '            End If

    '            If PubStoreNO = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo") Then
    '                DsFrmReceivePayment1.GL_payment_deposit_Detail.Clear()
    '                DAGL_payment_deposit_Detail.SelectCommand.Parameters("@refrence_no").Value = TxtRefrence_no
    '                DAGL_payment_deposit_Detail.Fill(DsFrmReceivePayment1.GL_payment_deposit_Detail)

    '                CmdDelete.Parameters("@refrence_no").Value = TxtRefrence_no.Text
    '                CmdDelete.ExecuteNonQuery()
    '                CmdGeneral.CommandText = "Delete From GL_account_adjustment_head Where Gl_receive_payment_Refrence_no=" & Qt(TxtRefrence_no.Text)
    '                CmdGeneral.ExecuteNonQuery()
    '                CmdGeneral.CommandText = "Delete From GL_payment_deposit_Detail Where Refrence_no=" & Qt(TxtRefrence_no.Text)
    '                CmdGeneral.ExecuteNonQuery()
    '            Else
    '                DsFrmReceivePayment1.GL_payment_deposit_Detail.Clear()

    '                Dim SQLReader As System.Data.SqlClient.SqlDataReader
    '                If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
    '                    CmdGeneralForReader.Connection.Open()
    '                End If
    '                CmdGeneralForReader.CommandText = "SELECT refrence_no from Gl_receive_payment Where OtherStoreRefrence_no=" & Qt(TxtRefrence_no.Text) & " AND FromStoreNo=" & Qt(PubStoreNO)
    '                SQLReader = CmdGeneralForReader.ExecuteReader
    '                If SQLReader.HasRows Then
    '                    Do While SQLReader.Read()
    '                        DAGL_payment_deposit_Detail.SelectCommand.Parameters("@refrence_no").Value = SQLReader.Item("refrence_no")
    '                        DAGL_payment_deposit_Detail.Fill(DsFrmReceivePayment1.GL_payment_deposit_Detail)

    '                        CmdGeneral.CommandText = "Delete From GL_account_adjustment_head Where Gl_receive_payment_Refrence_no=" & Qt(SQLReader.Item("refrence_no"))
    '                        CmdGeneral.ExecuteNonQuery()
    '                        CmdGeneral.CommandText = "Delete From GL_payment_deposit_Detail Where Refrence_no=" & Qt(SQLReader.Item("refrence_no"))
    '                        CmdGeneral.ExecuteNonQuery()
    '                    Loop
    '                End If
    '                CmdDeleteOtherStore.Parameters("@OtherStoreRefrence_no").Value = Reference_No1.Text
    '                CmdDeleteOtherStore.Parameters("@FromStoreNo").Value = DsFrmReceivePayment1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
    '                CmdDeleteOtherStore.ExecuteNonQuery()
    '            End If
    '            If DsFrmReceivePayment1.GL_payment_deposit_Detail.Rows.Count > 0 Then
    '                Dim GL_payment_deposit_DetailCounterVar As Integer
    '                For GL_payment_deposit_DetailCounterVar = 0 To DsFrmReceivePayment1.GL_payment_deposit_Detail.Rows.Count - 1
    '                    CmdGeneral.CommandText = "Update GL_payment_deposit set Paid_amount=Paid_amount-" & DsFrmReceivePayment1.GL_payment_deposit_Detail.Rows(GL_payment_deposit_DetailCounterVar).Item("payment_amount") & " where ID_payment=" & DsFrmReceivePayment1.GL_payment_deposit_Detail.Rows(GL_payment_deposit_DetailCounterVar).Item("ID_payment_due") & " AND  Paid_amount>=" & DsFrmReceivePayment1.GL_payment_deposit_Detail.Rows(GL_payment_deposit_DetailCounterVar).Item("payment_amount")
    '                    CmdGeneral.ExecuteNonQuery()
    '                Next
    '            End If
    '        Catch ex As Exception
    '            MsgBox("Please Call to Your Vendor.Error In Setup Files")
    '        End Try
    '    Next
    '    If Cnn.State = ConnectionState.Open Then
    '        Cnn.Close()
    '    End If
    '    Cnn.ConnectionString = PConnectionString
    '    If CnnForReader.State = ConnectionState.Open Then
    '        CnnForReader.Close()
    '    End If
    '    CnnForReader.ConnectionString = PConnectionString
    'End Sub
End Class
