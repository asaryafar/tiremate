Imports CommonClass
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Public Class FrmBankDeposits
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public BankDepositHeadTempVar As Decimal = 0
    Dim PnlSearchHeight As Integer
    Public BankDepositVar As String = ""
    Dim ID_paymentVar As Decimal
    Dim Default_cash_overVar As String = ""
    Dim RowNoToAdd As Double = 25
    Dim MyFrmSelectPaymentstoDeposit As New FrmSelectPaymentstoDeposit
    Private CM As CurrencyManager
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Dim WithEvents MyFrmSearchBankDeposit As FrmSearchBankDeposit
    Dim CashPaidOut_OtherReceiptFlag As Boolean = False
    Dim FilterDateVar As String = ""
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Sort32 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
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
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_banks As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmBankDeposits1 As UCBankAccount.DSFrmBankDeposits
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BtnSelectPayments As Janus.Windows.EditControls.UIButton
    Public WithEvents TxtMemo As System.Windows.Forms.TextBox
    Friend WithEvents DteDate_document As CalendarCombo.CalendarCombo
    Friend WithEvents DAGL_debit_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Public WithEvents TxtCashBackMemo As System.Windows.Forms.TextBox
    Friend WithEvents CmbCashbackgoesto As System.Windows.Forms.ComboBox
    Friend WithEvents NumCashbackAmount As CalcUtils.UcCalcText
    Friend WithEvents LblDepositSubtotal As CalcUtils.UcCalcText
    Friend WithEvents LblDepositTotal As CalcUtils.UcCalcText
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_debit_deposit_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbBankDepositHead As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAcust_trtab_main As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblAvailableToDeposit As CalcUtils.UcCalcText
    Friend WithEvents LblCashPaidOuts As CalcUtils.UcCalcText
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblOtherReceiptsCheck As CalcUtils.UcCalcText
    Friend WithEvents LblOtherReceiptsCash As CalcUtils.UcCalcText
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LblOverPaymentCash As CalcUtils.UcCalcText
    Friend WithEvents LblPaymentForOtherStoreCash As CalcUtils.UcCalcText
    Friend WithEvents LblDownPaymentCash As CalcUtils.UcCalcText
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents LblOverPaymentCheck As CalcUtils.UcCalcText
    Friend WithEvents LblPaymentForOtherStoreCheck As CalcUtils.UcCalcText
    Friend WithEvents LblDownPaymentCheck As CalcUtils.UcCalcText
    Friend WithEvents LblOverPaymentCredit As CalcUtils.UcCalcText
    Friend WithEvents LblPaymentForOtherStoreCredit As CalcUtils.UcCalcText
    Friend WithEvents LblDownPaymentCredit As CalcUtils.UcCalcText
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LblDepositNo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBankDeposits))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
        Me.LblDepositNo = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.CmbBankDepositHead = New System.Windows.Forms.ComboBox
        Me.DsFrmBankDeposits1 = New UCBankAccount.DSFrmBankDeposits
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSelectPayments = New Janus.Windows.EditControls.UIButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtMemo = New System.Windows.Forms.TextBox
        Me.DteDate_document = New CalendarCombo.CalendarCombo
        Me.CmbBank = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LblOverPaymentCredit = New CalcUtils.UcCalcText
        Me.LblPaymentForOtherStoreCredit = New CalcUtils.UcCalcText
        Me.LblDownPaymentCredit = New CalcUtils.UcCalcText
        Me.LblOverPaymentCheck = New CalcUtils.UcCalcText
        Me.LblPaymentForOtherStoreCheck = New CalcUtils.UcCalcText
        Me.LblDownPaymentCheck = New CalcUtils.UcCalcText
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblOverPaymentCash = New CalcUtils.UcCalcText
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblPaymentForOtherStoreCash = New CalcUtils.UcCalcText
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblDownPaymentCash = New CalcUtils.UcCalcText
        Me.Label33 = New System.Windows.Forms.Label
        Me.LblOtherReceiptsCash = New CalcUtils.UcCalcText
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblCashPaidOuts = New CalcUtils.UcCalcText
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblOtherReceiptsCheck = New CalcUtils.UcCalcText
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblAvailableToDeposit = New CalcUtils.UcCalcText
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblDepositTotal = New CalcUtils.UcCalcText
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LblDepositSubtotal = New CalcUtils.UcCalcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.NumCashbackAmount = New CalcUtils.UcCalcText
        Me.TxtCashBackMemo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbCashbackgoesto = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Sort32 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort31 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.SortByType1 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.Command2 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Command21 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
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
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_banks = New System.Data.SqlClient.SqlDataAdapter
        Me.DAGL_debit_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_debit_deposit_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAcust_trtab_main = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmBankDeposits1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
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
        Me.CmdDelete.CommandText = "DELETE FROM GL_debit_deposit_head WHERE (id_debit_deposit_head = @id_debit_deposi" & _
        "t_head)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.LblDepositNo)
        Me.PnlSearch.Controls.Add(Me.Label21)
        Me.PnlSearch.Controls.Add(Me.CmbBankDepositHead)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(603, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'LblDepositNo
        '
        Me.LblDepositNo.BackColor = System.Drawing.Color.Transparent
        Me.LblDepositNo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblDepositNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblDepositNo.Location = New System.Drawing.Point(461, 5)
        Me.LblDepositNo.Name = "LblDepositNo"
        Me.LblDepositNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDepositNo.Size = New System.Drawing.Size(75, 12)
        Me.LblDepositNo.TabIndex = 191
        Me.LblDepositNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(382, 4)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 12)
        Me.Label21.TabIndex = 190
        Me.Label21.Text = "Deposit No : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbBankDepositHead
        '
        Me.CmbBankDepositHead.DataSource = Me.DsFrmBankDeposits1.GL_debit_deposit_head
        Me.CmbBankDepositHead.DisplayMember = "Expr1"
        Me.CmbBankDepositHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBankDepositHead.Location = New System.Drawing.Point(80, 1)
        Me.CmbBankDepositHead.Name = "CmbBankDepositHead"
        Me.CmbBankDepositHead.Size = New System.Drawing.Size(216, 21)
        Me.CmbBankDepositHead.TabIndex = 189
        Me.CmbBankDepositHead.ValueMember = "id_debit_deposit_head"
        '
        'DsFrmBankDeposits1
        '
        Me.DsFrmBankDeposits1.DataSetName = "DSFrmBankDeposits"
        Me.DsFrmBankDeposits1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        Me.Label4.Text = "Deposit To"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
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
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(603, 387)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnSelectPayments)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtMemo)
        Me.Panel1.Controls.Add(Me.DteDate_document)
        Me.Panel1.Controls.Add(Me.CmbBank)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 86)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(61, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 29)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "To select customer payments and receipts for Deposit click ""Select Payments"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSelectPayments
        '
        Me.BtnSelectPayments.Location = New System.Drawing.Point(473, 53)
        Me.BtnSelectPayments.Name = "BtnSelectPayments"
        Me.BtnSelectPayments.Size = New System.Drawing.Size(115, 26)
        Me.BtnSelectPayments.TabIndex = 3
        Me.BtnSelectPayments.TabStop = False
        Me.BtnSelectPayments.Text = "Select Payments"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(-19, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 21)
        Me.Label12.TabIndex = 342
        Me.Label12.Text = "Deposit To"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtMemo
        '
        Me.TxtMemo.Location = New System.Drawing.Point(63, 26)
        Me.TxtMemo.MaxLength = 100
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.Size = New System.Drawing.Size(530, 20)
        Me.TxtMemo.TabIndex = 2
        Me.TxtMemo.Text = ""
        '
        'DteDate_document
        '
        Me.DteDate_document.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_document.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_document.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_document.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_document.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_document.EditableSal = True
        Me.DteDate_document.Image = CType(resources.GetObject("DteDate_document.Image"), System.Drawing.Image)
        Me.DteDate_document.Location = New System.Drawing.Point(410, 2)
        Me.DteDate_document.MaxValue = CType(2500, Short)
        Me.DteDate_document.MinValue = CType(1800, Short)
        Me.DteDate_document.Name = "DteDate_document"
        Me.DteDate_document.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_document.Sal_Mali = Nothing
        Me.DteDate_document.ShowButton = True
        Me.DteDate_document.Size = New System.Drawing.Size(102, 23)
        Me.DteDate_document.TabIndex = 1
        Me.DteDate_document.VisualStyle = False
        '
        'CmbBank
        '
        Me.CmbBank.DataSource = Me.DsFrmBankDeposits1.bas_banks
        Me.CmbBank.DisplayMember = "name_bank"
        Me.CmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBank.Location = New System.Drawing.Point(63, 3)
        Me.CmbBank.Name = "CmbBank"
        Me.CmbBank.Size = New System.Drawing.Size(211, 21)
        Me.CmbBank.TabIndex = 0
        Me.CmbBank.ValueMember = "id_bank"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(312, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 21)
        Me.Label13.TabIndex = 337
        Me.Label13.Text = "Deposit Date "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(0, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 331
        Me.Label5.Text = "Memo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GL_debit_deposit"
        Me.GrdDetail.DataSource = Me.DsFrmBankDeposits1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_debit_deposit</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""cod_customer""><Caption>Received From</Caption><DataMember" & _
        ">cod_customer</DataMember><EditType>MultiColumnDropDown</EditType><Key>cod_custo" & _
        "mer</Key><Position>0</Position><DropDownIndex>2</DropDownIndex></Column0><Column" & _
        "1 ID=""CustomerFullName""><Caption>Received From</Caption><DataMember>CustomerFull" & _
        "Name</DataMember><DefaultGroupInterval>Text</DefaultGroupInterval><EditType>Mult" & _
        "iColumnDropDown</EditType><Key>CustomerFullName</Key><Position>1</Position><Comp" & _
        "areTarget>Text</CompareTarget><Visible>False</Visible><Width>134</Width><DropDow" & _
        "nIndex>2</DropDownIndex></Column1><Column2 ID=""GL_account""><Caption>From Account" & _
        "</Caption><DataMember>GL_account</DataMember><DefaultGroupInterval>Text</Default" & _
        "GroupInterval><EditType>MultiColumnDropDown</EditType><Key>GL_account</Key><Posi" & _
        "tion>2</Position><CompareTarget>Text</CompareTarget><Width>87</Width><DropDownIn" & _
        "dex>0</DropDownIndex></Column2><Column3 ID=""Memo""><Caption>Memo</Caption><DataMe" & _
        "mber>Memo</DataMember><Key>Memo</Key><Position>3</Position><Width>81</Width></Co" & _
        "lumn3><Column4 ID=""check_no""><Caption>Chk No.</Caption><DataMember>check_no</Dat" & _
        "aMember><Key>check_no</Key><MaskPrompt>&#x0;</MaskPrompt><MaxLength>20</MaxLengt" & _
        "h><Position>4</Position><Width>79</Width></Column4><Column5 ID=""payment_type""><C" & _
        "aption>Pmt Meth.</Caption><DataMember>payment_type</DataMember><DefaultGroupInte" & _
        "rval>Text</DefaultGroupInterval><EditType>MultiColumnDropDown</EditType><Key>pay" & _
        "ment_type</Key><Position>5</Position><CompareTarget>Text</CompareTarget><Width>6" & _
        "8</Width><DropDownIndex>3</DropDownIndex></Column5><Column6 ID=""cc_type""><Captio" & _
        "n>CC Type</Caption><DataMember>cc_type</DataMember><DefaultGroupInterval>Text</D" & _
        "efaultGroupInterval><EditType>MultiColumnDropDown</EditType><Key>cc_type</Key><P" & _
        "osition>6</Position><CompareTarget>Text</CompareTarget><Width>64</Width><DropDow" & _
        "nIndex>1</DropDownIndex></Column6><Column7 ID=""deposit_amount""><Caption>Amount</" & _
        "Caption><DataMember>deposit_amount</DataMember><FormatString>c2</FormatString><I" & _
        "nputMask>Currency2</InputMask><Key>deposit_amount</Key><MaxLength>10</MaxLength>" & _
        "<Position>7</Position><Width>98</Width></Column7><Column8 ID=""ID_payment""><Capti" & _
        "on>ID_payment</Caption><DataMember>ID_payment</DataMember><Key>ID_payment</Key><" & _
        "Position>8</Position><Visible>False</Visible></Column8><Column9 ID=""refer_type"">" & _
        "<Caption>refer_type</Caption><DataMember>refer_type</DataMember><Key>refer_type<" & _
        "/Key><Position>9</Position><Visible>False</Visible></Column9><Column10 ID=""type_" & _
        "transaction""><Caption>type_transaction</Caption><DataMember>type_transaction</Da" & _
        "taMember><Key>type_transaction</Key><Position>10</Position><Visible>False</Visib" & _
        "le></Column10><Column11 ID=""FlagCanEdit""><Caption>FlagCanEdit</Caption><DataMemb" & _
        "er>FlagCanEdit</DataMember><EditType>NoEdit</EditType><Key>FlagCanEdit</Key><Pos" & _
        "ition>11</Position><Visible>False</Visible></Column11></Columns><GroupCondition " & _
        "ID="""" /><Key>GL_debit_deposit</Key></RootTable><DropDowns Collection=""true""><Dro" & _
        "pDown0><RootTable><Columns Collection=""true""><Column0 ID=""GL_account""><Caption>G" & _
        "L_account</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringV" & _
        "alue><EmptyStringValue /><DataMember>GL_account</DataMember><Key>GL_account</Key" & _
        "><Position>0</Position><Width>80</Width></Column0><Column1 ID=""desc_GL_account"">" & _
        "<Caption>desc_GL_account</Caption><DataMember>desc_GL_account</DataMember><Key>d" & _
        "esc_GL_account</Key><Position>1</Position><Width>200</Width></Column1></Columns>" & _
        "<GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans Serif" & _
        ", 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><ExpandableGroups>Fal" & _
        "se</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>" & _
        "Highlight</HideSelection><Key>Gl_Account</Key><DisplayMember>desc_GL_account</Di" & _
        "splayMember><ValueMember>GL_account</ValueMember></DropDown0><DropDown1><RootTab" & _
        "le><Columns Collection=""true""><Column0 ID=""cc_type""><Caption>cc_type</Caption><T" & _
        "ypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValu" & _
        "e /><DataMember>cc_type</DataMember><Key>cc_type</Key><Position>0</Position><Wid" & _
        "th>70</Width></Column0><Column1 ID=""cc_type_desc""><Caption>cc_type_desc</Caption" & _
        "><DataMember>cc_type_desc</DataMember><Key>cc_type_desc</Key><Position>1</Positi" & _
        "on></Column1></Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Fo" & _
        "nt>Microsoft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdi" & _
        "t><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBox" & _
        "Visible><HideSelection>Highlight</HideSelection><Key>CC_Type</Key><DisplayMember" & _
        ">cc_type_desc</DisplayMember><ValueMember>cc_type</ValueMember></DropDown1><Drop" & _
        "Down2><RootTable><Columns Collection=""true""><Column0 ID=""cod_customer""><Caption>" & _
        "cod_customer</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStri" & _
        "ngValue><EmptyStringValue /><DataMember>cod_customer</DataMember><Key>cod_custom" & _
        "er</Key><Position>0</Position></Column0><Column1 ID=""CustomerFullName""><Caption>" & _
        "CustomerFullName</Caption><DataMember>CustomerFullName</DataMember><EditType>NoE" & _
        "dit</EditType><Key>CustomerFullName</Key><Position>1</Position><Width>300</Width" & _
        "></Column1></Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font" & _
        ">Microsoft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit>" & _
        "<ExpandableGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVi" & _
        "sible><HideSelection>Highlight</HideSelection><Key>cust_trtab_main</Key><Display" & _
        "Member>CustomerFullName</DisplayMember><ValueMember>cod_customer</ValueMember></" & _
        "DropDown2><DropDown3><RootTable><Columns Collection=""true""><Column0 ID=""Payment_" & _
        "type""><Caption>Payment_type</Caption><TypeNameEmptyStringValue>System.String</Ty" & _
        "peNameEmptyStringValue><EmptyStringValue /><DataMember>Payment_type</DataMember>" & _
        "<Key>Payment_type</Key><Position>0</Position><Width>80</Width></Column0><Column1" & _
        " ID=""Payment_desc""><Caption>Payment_desc</Caption><DataMember>Payment_desc</Data" & _
        "Member><Key>Payment_desc</Key><Position>1</Position><Width>120</Width></Column1>" & _
        "</Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft " & _
        "Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><Expandable" & _
        "Groups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><Hide" & _
        "Selection>Highlight</HideSelection><Key>Pmt_Type</Key><DisplayMember>Payment_des" & _
        "c</DisplayMember><ValueMember>Payment_type</ValueMember></DropDown3></DropDowns>" & _
        "</GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(3, 86)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(598, 115)
        Me.GrdDetail.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LblOverPaymentCredit)
        Me.Panel5.Controls.Add(Me.LblPaymentForOtherStoreCredit)
        Me.Panel5.Controls.Add(Me.LblDownPaymentCredit)
        Me.Panel5.Controls.Add(Me.LblOverPaymentCheck)
        Me.Panel5.Controls.Add(Me.LblPaymentForOtherStoreCheck)
        Me.Panel5.Controls.Add(Me.LblDownPaymentCheck)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.LblOverPaymentCash)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.LblPaymentForOtherStoreCash)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.LblDownPaymentCash)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.LblOtherReceiptsCash)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.LblCashPaidOuts)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.LblOtherReceiptsCheck)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.LblAvailableToDeposit)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.LblDepositTotal)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.NumCashbackAmount)
        Me.Panel5.Controls.Add(Me.TxtCashBackMemo)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.CmbCashbackgoesto)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Location = New System.Drawing.Point(0, 201)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(637, 190)
        Me.Panel5.TabIndex = 2
        '
        'LblOverPaymentCredit
        '
        Me.LblOverPaymentCredit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOverPaymentCredit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOverPaymentCredit.DecimalDigits = 2
        Me.LblOverPaymentCredit.DefaultSendValue = False
        Me.LblOverPaymentCredit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOverPaymentCredit.FireTabAfterEnter = True
        Me.LblOverPaymentCredit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOverPaymentCredit.Image = CType(resources.GetObject("LblOverPaymentCredit.Image"), System.Drawing.Image)
        Me.LblOverPaymentCredit.Location = New System.Drawing.Point(294, 64)
        Me.LblOverPaymentCredit.Maxlength = 10
        Me.LblOverPaymentCredit.MinusColor = System.Drawing.Color.Empty
        Me.LblOverPaymentCredit.Name = "LblOverPaymentCredit"
        Me.LblOverPaymentCredit.ReadOnly = True
        Me.LblOverPaymentCredit.Size = New System.Drawing.Size(78, 21)
        Me.LblOverPaymentCredit.TabIndex = 377
        Me.LblOverPaymentCredit.TabStop = False
        Me.LblOverPaymentCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOverPaymentCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblPaymentForOtherStoreCredit
        '
        Me.LblPaymentForOtherStoreCredit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblPaymentForOtherStoreCredit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblPaymentForOtherStoreCredit.DecimalDigits = 2
        Me.LblPaymentForOtherStoreCredit.DefaultSendValue = False
        Me.LblPaymentForOtherStoreCredit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblPaymentForOtherStoreCredit.FireTabAfterEnter = True
        Me.LblPaymentForOtherStoreCredit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblPaymentForOtherStoreCredit.Image = CType(resources.GetObject("LblPaymentForOtherStoreCredit.Image"), System.Drawing.Image)
        Me.LblPaymentForOtherStoreCredit.Location = New System.Drawing.Point(294, 41)
        Me.LblPaymentForOtherStoreCredit.Maxlength = 10
        Me.LblPaymentForOtherStoreCredit.MinusColor = System.Drawing.Color.Empty
        Me.LblPaymentForOtherStoreCredit.Name = "LblPaymentForOtherStoreCredit"
        Me.LblPaymentForOtherStoreCredit.ReadOnly = True
        Me.LblPaymentForOtherStoreCredit.Size = New System.Drawing.Size(78, 21)
        Me.LblPaymentForOtherStoreCredit.TabIndex = 376
        Me.LblPaymentForOtherStoreCredit.TabStop = False
        Me.LblPaymentForOtherStoreCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblPaymentForOtherStoreCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblDownPaymentCredit
        '
        Me.LblDownPaymentCredit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblDownPaymentCredit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblDownPaymentCredit.DecimalDigits = 2
        Me.LblDownPaymentCredit.DefaultSendValue = False
        Me.LblDownPaymentCredit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblDownPaymentCredit.FireTabAfterEnter = True
        Me.LblDownPaymentCredit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDownPaymentCredit.Image = CType(resources.GetObject("LblDownPaymentCredit.Image"), System.Drawing.Image)
        Me.LblDownPaymentCredit.Location = New System.Drawing.Point(294, 87)
        Me.LblDownPaymentCredit.Maxlength = 10
        Me.LblDownPaymentCredit.MinusColor = System.Drawing.Color.Empty
        Me.LblDownPaymentCredit.Name = "LblDownPaymentCredit"
        Me.LblDownPaymentCredit.ReadOnly = True
        Me.LblDownPaymentCredit.Size = New System.Drawing.Size(78, 21)
        Me.LblDownPaymentCredit.TabIndex = 375
        Me.LblDownPaymentCredit.TabStop = False
        Me.LblDownPaymentCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblDownPaymentCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblOverPaymentCheck
        '
        Me.LblOverPaymentCheck.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOverPaymentCheck.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOverPaymentCheck.DecimalDigits = 2
        Me.LblOverPaymentCheck.DefaultSendValue = False
        Me.LblOverPaymentCheck.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOverPaymentCheck.FireTabAfterEnter = True
        Me.LblOverPaymentCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOverPaymentCheck.Image = CType(resources.GetObject("LblOverPaymentCheck.Image"), System.Drawing.Image)
        Me.LblOverPaymentCheck.Location = New System.Drawing.Point(214, 64)
        Me.LblOverPaymentCheck.Maxlength = 10
        Me.LblOverPaymentCheck.MinusColor = System.Drawing.Color.Empty
        Me.LblOverPaymentCheck.Name = "LblOverPaymentCheck"
        Me.LblOverPaymentCheck.ReadOnly = True
        Me.LblOverPaymentCheck.Size = New System.Drawing.Size(78, 21)
        Me.LblOverPaymentCheck.TabIndex = 374
        Me.LblOverPaymentCheck.TabStop = False
        Me.LblOverPaymentCheck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOverPaymentCheck.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblPaymentForOtherStoreCheck
        '
        Me.LblPaymentForOtherStoreCheck.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblPaymentForOtherStoreCheck.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblPaymentForOtherStoreCheck.DecimalDigits = 2
        Me.LblPaymentForOtherStoreCheck.DefaultSendValue = False
        Me.LblPaymentForOtherStoreCheck.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblPaymentForOtherStoreCheck.FireTabAfterEnter = True
        Me.LblPaymentForOtherStoreCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblPaymentForOtherStoreCheck.Image = CType(resources.GetObject("LblPaymentForOtherStoreCheck.Image"), System.Drawing.Image)
        Me.LblPaymentForOtherStoreCheck.Location = New System.Drawing.Point(214, 41)
        Me.LblPaymentForOtherStoreCheck.Maxlength = 10
        Me.LblPaymentForOtherStoreCheck.MinusColor = System.Drawing.Color.Empty
        Me.LblPaymentForOtherStoreCheck.Name = "LblPaymentForOtherStoreCheck"
        Me.LblPaymentForOtherStoreCheck.ReadOnly = True
        Me.LblPaymentForOtherStoreCheck.Size = New System.Drawing.Size(78, 21)
        Me.LblPaymentForOtherStoreCheck.TabIndex = 373
        Me.LblPaymentForOtherStoreCheck.TabStop = False
        Me.LblPaymentForOtherStoreCheck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblPaymentForOtherStoreCheck.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblDownPaymentCheck
        '
        Me.LblDownPaymentCheck.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblDownPaymentCheck.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblDownPaymentCheck.DecimalDigits = 2
        Me.LblDownPaymentCheck.DefaultSendValue = False
        Me.LblDownPaymentCheck.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblDownPaymentCheck.FireTabAfterEnter = True
        Me.LblDownPaymentCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDownPaymentCheck.Image = CType(resources.GetObject("LblDownPaymentCheck.Image"), System.Drawing.Image)
        Me.LblDownPaymentCheck.Location = New System.Drawing.Point(214, 87)
        Me.LblDownPaymentCheck.Maxlength = 10
        Me.LblDownPaymentCheck.MinusColor = System.Drawing.Color.Empty
        Me.LblDownPaymentCheck.Name = "LblDownPaymentCheck"
        Me.LblDownPaymentCheck.ReadOnly = True
        Me.LblDownPaymentCheck.Size = New System.Drawing.Size(78, 21)
        Me.LblDownPaymentCheck.TabIndex = 372
        Me.LblDownPaymentCheck.TabStop = False
        Me.LblDownPaymentCheck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblDownPaymentCheck.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(471, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 3)
        Me.GroupBox1.TabIndex = 371
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'LblOverPaymentCash
        '
        Me.LblOverPaymentCash.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOverPaymentCash.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOverPaymentCash.DecimalDigits = 2
        Me.LblOverPaymentCash.DefaultSendValue = False
        Me.LblOverPaymentCash.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOverPaymentCash.FireTabAfterEnter = True
        Me.LblOverPaymentCash.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOverPaymentCash.Image = CType(resources.GetObject("LblOverPaymentCash.Image"), System.Drawing.Image)
        Me.LblOverPaymentCash.Location = New System.Drawing.Point(133, 64)
        Me.LblOverPaymentCash.Maxlength = 10
        Me.LblOverPaymentCash.MinusColor = System.Drawing.Color.Empty
        Me.LblOverPaymentCash.Name = "LblOverPaymentCash"
        Me.LblOverPaymentCash.ReadOnly = True
        Me.LblOverPaymentCash.Size = New System.Drawing.Size(78, 21)
        Me.LblOverPaymentCash.TabIndex = 370
        Me.LblOverPaymentCash.TabStop = False
        Me.LblOverPaymentCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOverPaymentCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(43, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 21)
        Me.Label14.TabIndex = 369
        Me.Label14.Text = "Over Payment"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPaymentForOtherStoreCash
        '
        Me.LblPaymentForOtherStoreCash.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblPaymentForOtherStoreCash.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblPaymentForOtherStoreCash.DecimalDigits = 2
        Me.LblPaymentForOtherStoreCash.DefaultSendValue = False
        Me.LblPaymentForOtherStoreCash.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblPaymentForOtherStoreCash.FireTabAfterEnter = True
        Me.LblPaymentForOtherStoreCash.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblPaymentForOtherStoreCash.Image = CType(resources.GetObject("LblPaymentForOtherStoreCash.Image"), System.Drawing.Image)
        Me.LblPaymentForOtherStoreCash.Location = New System.Drawing.Point(133, 41)
        Me.LblPaymentForOtherStoreCash.Maxlength = 10
        Me.LblPaymentForOtherStoreCash.MinusColor = System.Drawing.Color.Empty
        Me.LblPaymentForOtherStoreCash.Name = "LblPaymentForOtherStoreCash"
        Me.LblPaymentForOtherStoreCash.ReadOnly = True
        Me.LblPaymentForOtherStoreCash.Size = New System.Drawing.Size(78, 21)
        Me.LblPaymentForOtherStoreCash.TabIndex = 368
        Me.LblPaymentForOtherStoreCash.TabStop = False
        Me.LblPaymentForOtherStoreCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblPaymentForOtherStoreCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(-13, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 21)
        Me.Label15.TabIndex = 367
        Me.Label15.Text = "Payment For Other Store "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDownPaymentCash
        '
        Me.LblDownPaymentCash.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblDownPaymentCash.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblDownPaymentCash.DecimalDigits = 2
        Me.LblDownPaymentCash.DefaultSendValue = False
        Me.LblDownPaymentCash.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblDownPaymentCash.FireTabAfterEnter = True
        Me.LblDownPaymentCash.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDownPaymentCash.Image = CType(resources.GetObject("LblDownPaymentCash.Image"), System.Drawing.Image)
        Me.LblDownPaymentCash.Location = New System.Drawing.Point(133, 87)
        Me.LblDownPaymentCash.Maxlength = 10
        Me.LblDownPaymentCash.MinusColor = System.Drawing.Color.Empty
        Me.LblDownPaymentCash.Name = "LblDownPaymentCash"
        Me.LblDownPaymentCash.ReadOnly = True
        Me.LblDownPaymentCash.Size = New System.Drawing.Size(78, 21)
        Me.LblDownPaymentCash.TabIndex = 366
        Me.LblDownPaymentCash.TabStop = False
        Me.LblDownPaymentCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblDownPaymentCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Location = New System.Drawing.Point(43, 86)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(85, 21)
        Me.Label33.TabIndex = 365
        Me.Label33.Text = "Down Payment"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblOtherReceiptsCash
        '
        Me.LblOtherReceiptsCash.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOtherReceiptsCash.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOtherReceiptsCash.DecimalDigits = 2
        Me.LblOtherReceiptsCash.DefaultSendValue = False
        Me.LblOtherReceiptsCash.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOtherReceiptsCash.FireTabAfterEnter = True
        Me.LblOtherReceiptsCash.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOtherReceiptsCash.Image = CType(resources.GetObject("LblOtherReceiptsCash.Image"), System.Drawing.Image)
        Me.LblOtherReceiptsCash.Location = New System.Drawing.Point(515, 55)
        Me.LblOtherReceiptsCash.Maxlength = 10
        Me.LblOtherReceiptsCash.MinusColor = System.Drawing.Color.Empty
        Me.LblOtherReceiptsCash.Name = "LblOtherReceiptsCash"
        Me.LblOtherReceiptsCash.ReadOnly = True
        Me.LblOtherReceiptsCash.Size = New System.Drawing.Size(78, 21)
        Me.LblOtherReceiptsCash.TabIndex = 364
        Me.LblOtherReceiptsCash.TabStop = False
        Me.LblOtherReceiptsCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOtherReceiptsCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(391, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 21)
        Me.Label11.TabIndex = 363
        Me.Label11.Text = "Other Receipts -  Cash "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCashPaidOuts
        '
        Me.LblCashPaidOuts.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCashPaidOuts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCashPaidOuts.DecimalDigits = 2
        Me.LblCashPaidOuts.DefaultSendValue = False
        Me.LblCashPaidOuts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCashPaidOuts.FireTabAfterEnter = True
        Me.LblCashPaidOuts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCashPaidOuts.Image = CType(resources.GetObject("LblCashPaidOuts.Image"), System.Drawing.Image)
        Me.LblCashPaidOuts.Location = New System.Drawing.Point(515, 32)
        Me.LblCashPaidOuts.Maxlength = 10
        Me.LblCashPaidOuts.MinusColor = System.Drawing.Color.Empty
        Me.LblCashPaidOuts.Name = "LblCashPaidOuts"
        Me.LblCashPaidOuts.ReadOnly = True
        Me.LblCashPaidOuts.Size = New System.Drawing.Size(78, 21)
        Me.LblCashPaidOuts.TabIndex = 362
        Me.LblCashPaidOuts.TabStop = False
        Me.LblCashPaidOuts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCashPaidOuts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(415, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 21)
        Me.Label10.TabIndex = 361
        Me.Label10.Text = "Cash Paid Outs"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblOtherReceiptsCheck
        '
        Me.LblOtherReceiptsCheck.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOtherReceiptsCheck.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOtherReceiptsCheck.DecimalDigits = 2
        Me.LblOtherReceiptsCheck.DefaultSendValue = False
        Me.LblOtherReceiptsCheck.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOtherReceiptsCheck.FireTabAfterEnter = True
        Me.LblOtherReceiptsCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOtherReceiptsCheck.Image = CType(resources.GetObject("LblOtherReceiptsCheck.Image"), System.Drawing.Image)
        Me.LblOtherReceiptsCheck.Location = New System.Drawing.Point(515, 78)
        Me.LblOtherReceiptsCheck.Maxlength = 10
        Me.LblOtherReceiptsCheck.MinusColor = System.Drawing.Color.Empty
        Me.LblOtherReceiptsCheck.Name = "LblOtherReceiptsCheck"
        Me.LblOtherReceiptsCheck.ReadOnly = True
        Me.LblOtherReceiptsCheck.Size = New System.Drawing.Size(78, 21)
        Me.LblOtherReceiptsCheck.TabIndex = 360
        Me.LblOtherReceiptsCheck.TabStop = False
        Me.LblOtherReceiptsCheck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOtherReceiptsCheck.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(391, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 21)
        Me.Label9.TabIndex = 359
        Me.Label9.Text = "Other Receipts - Check"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAvailableToDeposit
        '
        Me.LblAvailableToDeposit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblAvailableToDeposit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblAvailableToDeposit.DecimalDigits = 2
        Me.LblAvailableToDeposit.DefaultSendValue = False
        Me.LblAvailableToDeposit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblAvailableToDeposit.FireTabAfterEnter = True
        Me.LblAvailableToDeposit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblAvailableToDeposit.Image = CType(resources.GetObject("LblAvailableToDeposit.Image"), System.Drawing.Image)
        Me.LblAvailableToDeposit.Location = New System.Drawing.Point(515, 101)
        Me.LblAvailableToDeposit.Maxlength = 10
        Me.LblAvailableToDeposit.MinusColor = System.Drawing.Color.Empty
        Me.LblAvailableToDeposit.Name = "LblAvailableToDeposit"
        Me.LblAvailableToDeposit.ReadOnly = True
        Me.LblAvailableToDeposit.Size = New System.Drawing.Size(78, 21)
        Me.LblAvailableToDeposit.TabIndex = 358
        Me.LblAvailableToDeposit.TabStop = False
        Me.LblAvailableToDeposit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblAvailableToDeposit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(405, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 357
        Me.Label2.Text = "Available To Deposit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDepositTotal
        '
        Me.LblDepositTotal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblDepositTotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblDepositTotal.DecimalDigits = 2
        Me.LblDepositTotal.DefaultSendValue = False
        Me.LblDepositTotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblDepositTotal.FireTabAfterEnter = True
        Me.LblDepositTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDepositTotal.Image = CType(resources.GetObject("LblDepositTotal.Image"), System.Drawing.Image)
        Me.LblDepositTotal.Location = New System.Drawing.Point(481, 159)
        Me.LblDepositTotal.Maxlength = 10
        Me.LblDepositTotal.MinusColor = System.Drawing.Color.Empty
        Me.LblDepositTotal.Name = "LblDepositTotal"
        Me.LblDepositTotal.ReadOnly = True
        Me.LblDepositTotal.Size = New System.Drawing.Size(114, 21)
        Me.LblDepositTotal.TabIndex = 356
        Me.LblDepositTotal.TabStop = False
        Me.LblDepositTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblDepositTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LblDepositSubtotal)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 23)
        Me.Panel2.TabIndex = 0
        '
        'LblDepositSubtotal
        '
        Me.LblDepositSubtotal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblDepositSubtotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblDepositSubtotal.DecimalDigits = 2
        Me.LblDepositSubtotal.DefaultSendValue = False
        Me.LblDepositSubtotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblDepositSubtotal.FireTabAfterEnter = True
        Me.LblDepositSubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDepositSubtotal.Image = CType(resources.GetObject("LblDepositSubtotal.Image"), System.Drawing.Image)
        Me.LblDepositSubtotal.Location = New System.Drawing.Point(345, 0)
        Me.LblDepositSubtotal.Maxlength = 10
        Me.LblDepositSubtotal.MinusColor = System.Drawing.Color.Empty
        Me.LblDepositSubtotal.Name = "LblDepositSubtotal"
        Me.LblDepositSubtotal.ReadOnly = True
        Me.LblDepositSubtotal.Size = New System.Drawing.Size(114, 21)
        Me.LblDepositSubtotal.TabIndex = 353
        Me.LblDepositSubtotal.TabStop = False
        Me.LblDepositSubtotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblDepositSubtotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(250, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
        Me.Label3.TabIndex = 349
        Me.Label3.Text = "Deposit Subtotal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(414, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 21)
        Me.Label20.TabIndex = 354
        Me.Label20.Text = "Net Deposit"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(380, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 353
        Me.Label8.Text = "Cash back Amount"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumCashbackAmount
        '
        Me.NumCashbackAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCashbackAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCashbackAmount.DecimalDigits = 2
        Me.NumCashbackAmount.DefaultSendValue = False
        Me.NumCashbackAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCashbackAmount.FireTabAfterEnter = True
        Me.NumCashbackAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCashbackAmount.Image = CType(resources.GetObject("NumCashbackAmount.Image"), System.Drawing.Image)
        Me.NumCashbackAmount.Location = New System.Drawing.Point(481, 124)
        Me.NumCashbackAmount.Maxlength = 10
        Me.NumCashbackAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumCashbackAmount.Name = "NumCashbackAmount"
        Me.NumCashbackAmount.Size = New System.Drawing.Size(114, 22)
        Me.NumCashbackAmount.TabIndex = 1
        Me.NumCashbackAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCashbackAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtCashBackMemo
        '
        Me.TxtCashBackMemo.Location = New System.Drawing.Point(110, 165)
        Me.TxtCashBackMemo.MaxLength = 100
        Me.TxtCashBackMemo.Name = "TxtCashBackMemo"
        Me.TxtCashBackMemo.Size = New System.Drawing.Size(242, 21)
        Me.TxtCashBackMemo.TabIndex = 2
        Me.TxtCashBackMemo.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(13, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 21)
        Me.Label7.TabIndex = 351
        Me.Label7.Text = "Cash back memo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(9, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 349
        Me.Label6.Text = "Cash back goes to"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCashbackgoesto
        '
        Me.CmbCashbackgoesto.DataSource = Me.DsFrmBankDeposits1.GL_account
        Me.CmbCashbackgoesto.DisplayMember = "desc_GL_account"
        Me.CmbCashbackgoesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCashbackgoesto.Location = New System.Drawing.Point(110, 145)
        Me.CmbCashbackgoesto.Name = "CmbCashbackgoesto"
        Me.CmbCashbackgoesto.Size = New System.Drawing.Size(227, 21)
        Me.CmbCashbackgoesto.TabIndex = 0
        Me.CmbCashbackgoesto.ValueMember = "GL_account"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(14, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(307, 32)
        Me.Label19.TabIndex = 344
        Me.Label19.Text = "To get cash back from this deposit, enter the amount below and select GL Account " & _
        "this cash back is applied to. "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(133, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 21)
        Me.Label16.TabIndex = 378
        Me.Label16.Text = "Cash"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.Location = New System.Drawing.Point(294, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 21)
        Me.Label18.TabIndex = 380
        Me.Label18.Text = "Credit"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(214, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 21)
        Me.Label17.TabIndex = 379
        Me.Label17.Text = "Check"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO GL_debit_deposit"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@flag_deposit_bank", System.Data.SqlDbType.Bit, 1, "flag_deposit_bank"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_to_id_bank", System.Data.SqlDbType.SmallInt, 2, "deposit_to_id_bank"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE GL_debit_deposit SET type_transaction = @type_transaction, ID_payment = @I" & _
        "D_payment, id_check = @id_check, id_transfer = @id_transfer, debit_amount = @deb" & _
        "it_amount, deposit_amount = @deposit_amount, GL_account = @GL_account, cod_custo" & _
        "mer = @cod_customer, refer_type = @refer_type, memo = @memo, check_no = @check_n" & _
        "o, cc_type = @cc_type, payment_type = @payment_type, date_document = @date_docum" & _
        "ent WHERE (id_debit_deposit = @id_debit_deposit)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_transaction", System.Data.SqlDbType.VarChar, 1, "type_transaction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_transfer", System.Data.SqlDbType.Int, 4, "id_transfer"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@debit_amount", System.Data.SqlDbType.Money, 8, "debit_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_amount", System.Data.SqlDbType.Money, 8, "deposit_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 10, "refer_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_no", System.Data.SqlDbType.VarChar, 20, "check_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_document", System.Data.SqlDbType.VarChar, 10, "date_document"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit", System.Data.DataRowVersion.Original, Nothing))
        '
        'Sort32
        '
        Me.Sort32.Key = "Sort3"
        Me.Sort32.Name = "Sort32"
        Me.Sort32.Text = "Order By A Customer Payements"
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
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label29)
        Me.Panel9.Controls.Add(Me.Label28)
        Me.Panel9.Controls.Add(Me.BtnPrint)
        Me.Panel9.Controls.Add(Me.BtnPreview)
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
        Me.Panel9.Size = New System.Drawing.Size(603, 45)
        Me.Panel9.TabIndex = 143
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(512, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(466, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 201
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(512, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 198
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(472, 3)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 197
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
        Me.Label42.Location = New System.Drawing.Point(354, 31)
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
        Me.Label51.Location = New System.Drawing.Point(280, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(38, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(206, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(159, 31)
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
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_bank, name_bank FROM bas_banks"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bas_banks(name_bank, share_all_store, store_no, account_no, address, " & _
        "zip, phone_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, pho" & _
        "ne_type_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone" & _
        "_4, extension_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5," & _
        " phone_main_5, email, contact_name, GL_Account, start_check_no, next_check_no, d" & _
        "efault_bank, inactive, cod_account_type, routing_numbers, Bank_ID, Web_Page, Use" & _
        "r_ID, Password, Security_code, online_banking) VALUES (@name_bank, @share_all_st" & _
        "ore, @store_no, @account_no, @address, @zip, @phone_1, @extension_1, @phone_type" & _
        "_1, @phone_main_1, @phone_2, @extension_2, @phone_type_2, @phone_main_2, @phone_" & _
        "3, @extension_3, @phone_type_3, @phone_main_3, @phone_4, @extension_4, @phone_ty" & _
        "pe_4, @phone_main_4, @phone_5, @extension_5, @phone_type_5, @phone_main_5, @emai" & _
        "l, @contact_name, @GL_Account, @start_check_no, @next_check_no, @default_bank, @" & _
        "inactive, @cod_account_type, @routing_numbers, @Bank_ID, @Web_Page, @User_ID, @P" & _
        "assword, @Security_code, @online_banking); SELECT id_bank, name_bank, share_all_" & _
        "store, store_no, account_no, address, zip, phone_1, extension_1, phone_type_1, p" & _
        "hone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_3, extensio" & _
        "n_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, phone_main_" & _
        "4, phone_5, extension_5, phone_type_5, phone_main_5, email, contact_name, GL_Acc" & _
        "ount, start_check_no, next_check_no, default_bank, inactive, cod_account_type, r" & _
        "outing_numbers, Bank_ID, Web_Page, User_ID, Password, Security_code, online_bank" & _
        "ing FROM bas_banks WHERE (id_bank = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.CnnTemp
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@name_bank", System.Data.SqlDbType.VarChar, 50, "name_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@share_all_store", System.Data.SqlDbType.Bit, 1, "share_all_store"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_no", System.Data.SqlDbType.VarChar, 2, "store_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@account_no", System.Data.SqlDbType.VarChar, 25, "account_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 100, "email"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact_name", System.Data.SqlDbType.VarChar, 50, "contact_name"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_check_no", System.Data.SqlDbType.VarChar, 20, "start_check_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@next_check_no", System.Data.SqlDbType.VarChar, 20, "next_check_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@default_bank", System.Data.SqlDbType.Bit, 1, "default_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_account_type", System.Data.SqlDbType.VarChar, 1, "cod_account_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@routing_numbers", System.Data.SqlDbType.VarChar, 25, "routing_numbers"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank_ID", System.Data.SqlDbType.VarChar, 25, "Bank_ID"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Web_Page", System.Data.SqlDbType.VarChar, 100, "Web_Page"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User_ID", System.Data.SqlDbType.VarChar, 25, "User_ID"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 25, "Password"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Security_code", System.Data.SqlDbType.VarChar, 25, "Security_code"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@online_banking", System.Data.SqlDbType.Bit, 1, "online_banking"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bas_banks SET name_bank = @name_bank, share_all_store = @share_all_store, " & _
        "store_no = @store_no, account_no = @account_no, address = @address, zip = @zip, " & _
        "phone_1 = @phone_1, extension_1 = @extension_1, phone_type_1 = @phone_type_1, ph" & _
        "one_main_1 = @phone_main_1, phone_2 = @phone_2, extension_2 = @extension_2, phon" & _
        "e_type_2 = @phone_type_2, phone_main_2 = @phone_main_2, phone_3 = @phone_3, exte" & _
        "nsion_3 = @extension_3, phone_type_3 = @phone_type_3, phone_main_3 = @phone_main" & _
        "_3, phone_4 = @phone_4, extension_4 = @extension_4, phone_type_4 = @phone_type_4" & _
        ", phone_main_4 = @phone_main_4, phone_5 = @phone_5, extension_5 = @extension_5, " & _
        "phone_type_5 = @phone_type_5, phone_main_5 = @phone_main_5, email = @email, cont" & _
        "act_name = @contact_name, GL_Account = @GL_Account, start_check_no = @start_chec" & _
        "k_no, next_check_no = @next_check_no, default_bank = @default_bank, inactive = @" & _
        "inactive, cod_account_type = @cod_account_type, routing_numbers = @routing_numbe" & _
        "rs, Bank_ID = @Bank_ID, Web_Page = @Web_Page, User_ID = @User_ID, Password = @Pa" & _
        "ssword, Security_code = @Security_code, online_banking = @online_banking WHERE (" & _
        "id_bank = @Original_id_bank) AND (Bank_ID = @Original_Bank_ID OR @Original_Bank_" & _
        "ID IS NULL AND Bank_ID IS NULL) AND (GL_Account = @Original_GL_Account OR @Origi" & _
        "nal_GL_Account IS NULL AND GL_Account IS NULL) AND (Password = @Original_Passwor" & _
        "d OR @Original_Password IS NULL AND Password IS NULL) AND (Security_code = @Orig" & _
        "inal_Security_code OR @Original_Security_code IS NULL AND Security_code IS NULL)" & _
        " AND (User_ID = @Original_User_ID OR @Original_User_ID IS NULL AND User_ID IS NU" & _
        "LL) AND (Web_Page = @Original_Web_Page OR @Original_Web_Page IS NULL AND Web_Pag" & _
        "e IS NULL) AND (account_no = @Original_account_no OR @Original_account_no IS NUL" & _
        "L AND account_no IS NULL) AND (address = @Original_address OR @Original_address " & _
        "IS NULL AND address IS NULL) AND (cod_account_type = @Original_cod_account_type " & _
        "OR @Original_cod_account_type IS NULL AND cod_account_type IS NULL) AND (contact" & _
        "_name = @Original_contact_name OR @Original_contact_name IS NULL AND contact_nam" & _
        "e IS NULL) AND (default_bank = @Original_default_bank OR @Original_default_bank " & _
        "IS NULL AND default_bank IS NULL) AND (email = @Original_email OR @Original_emai" & _
        "l IS NULL AND email IS NULL) AND (extension_1 = @Original_extension_1 OR @Origin" & _
        "al_extension_1 IS NULL AND extension_1 IS NULL) AND (extension_2 = @Original_ext" & _
        "ension_2 OR @Original_extension_2 IS NULL AND extension_2 IS NULL) AND (extensio" & _
        "n_3 = @Original_extension_3 OR @Original_extension_3 IS NULL AND extension_3 IS " & _
        "NULL) AND (extension_4 = @Original_extension_4 OR @Original_extension_4 IS NULL " & _
        "AND extension_4 IS NULL) AND (extension_5 = @Original_extension_5 OR @Original_e" & _
        "xtension_5 IS NULL AND extension_5 IS NULL) AND (inactive = @Original_inactive O" & _
        "R @Original_inactive IS NULL AND inactive IS NULL) AND (name_bank = @Original_na" & _
        "me_bank OR @Original_name_bank IS NULL AND name_bank IS NULL) AND (next_check_no" & _
        " = @Original_next_check_no OR @Original_next_check_no IS NULL AND next_check_no " & _
        "IS NULL) AND (online_banking = @Original_online_banking OR @Original_online_bank" & _
        "ing IS NULL AND online_banking IS NULL) AND (phone_1 = @Original_phone_1 OR @Ori" & _
        "ginal_phone_1 IS NULL AND phone_1 IS NULL) AND (phone_2 = @Original_phone_2 OR @" & _
        "Original_phone_2 IS NULL AND phone_2 IS NULL) AND (phone_3 = @Original_phone_3 O" & _
        "R @Original_phone_3 IS NULL AND phone_3 IS NULL) AND (phone_4 = @Original_phone_" & _
        "4 OR @Original_phone_4 IS NULL AND phone_4 IS NULL) AND (phone_5 = @Original_pho" & _
        "ne_5 OR @Original_phone_5 IS NULL AND phone_5 IS NULL) AND (phone_main_1 = @Orig" & _
        "inal_phone_main_1 OR @Original_phone_main_1 IS NULL AND phone_main_1 IS NULL) AN" & _
        "D (phone_main_2 = @Original_phone_main_2 OR @Original_phone_main_2 IS NULL AND p" & _
        "hone_main_2 IS NULL) AND (phone_main_3 = @Original_phone_main_3 OR @Original_pho" & _
        "ne_main_3 IS NULL AND phone_main_3 IS NULL) AND (phone_main_4 = @Original_phone_" & _
        "main_4 OR @Original_phone_main_4 IS NULL AND phone_main_4 IS NULL) AND (phone_ma" & _
        "in_5 = @Original_phone_main_5 OR @Original_phone_main_5 IS NULL AND phone_main_5" & _
        " IS NULL) AND (phone_type_1 = @Original_phone_type_1 OR @Original_phone_type_1 I" & _
        "S NULL AND phone_type_1 IS NULL) AND (phone_type_2 = @Original_phone_type_2 OR @" & _
        "Original_phone_type_2 IS NULL AND phone_type_2 IS NULL) AND (phone_type_3 = @Ori" & _
        "ginal_phone_type_3 OR @Original_phone_type_3 IS NULL AND phone_type_3 IS NULL) A" & _
        "ND (phone_type_4 = @Original_phone_type_4 OR @Original_phone_type_4 IS NULL AND " & _
        "phone_type_4 IS NULL) AND (phone_type_5 = @Original_phone_type_5 OR @Original_ph" & _
        "one_type_5 IS NULL AND phone_type_5 IS NULL) AND (routing_numbers = @Original_ro" & _
        "uting_numbers OR @Original_routing_numbers IS NULL AND routing_numbers IS NULL) " & _
        "AND (share_all_store = @Original_share_all_store OR @Original_share_all_store IS" & _
        " NULL AND share_all_store IS NULL) AND (start_check_no = @Original_start_check_n" & _
        "o OR @Original_start_check_no IS NULL AND start_check_no IS NULL) AND (store_no " & _
        "= @Original_store_no OR @Original_store_no IS NULL AND store_no IS NULL) AND (zi" & _
        "p = @Original_zip OR @Original_zip IS NULL AND zip IS NULL); SELECT id_bank, nam" & _
        "e_bank, share_all_store, store_no, account_no, address, zip, phone_1, extension_" & _
        "1, phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2," & _
        " phone_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_t" & _
        "ype_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, co" & _
        "ntact_name, GL_Account, start_check_no, next_check_no, default_bank, inactive, c" & _
        "od_account_type, routing_numbers, Bank_ID, Web_Page, User_ID, Password, Security" & _
        "_code, online_banking FROM bas_banks WHERE (id_bank = @id_bank)"
        Me.SqlUpdateCommand2.Connection = Me.CnnTemp
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@name_bank", System.Data.SqlDbType.VarChar, 50, "name_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@share_all_store", System.Data.SqlDbType.Bit, 1, "share_all_store"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_no", System.Data.SqlDbType.VarChar, 2, "store_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@account_no", System.Data.SqlDbType.VarChar, 25, "account_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 100, "email"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact_name", System.Data.SqlDbType.VarChar, 50, "contact_name"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_check_no", System.Data.SqlDbType.VarChar, 20, "start_check_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@next_check_no", System.Data.SqlDbType.VarChar, 20, "next_check_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@default_bank", System.Data.SqlDbType.Bit, 1, "default_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_account_type", System.Data.SqlDbType.VarChar, 1, "cod_account_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@routing_numbers", System.Data.SqlDbType.VarChar, 25, "routing_numbers"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank_ID", System.Data.SqlDbType.VarChar, 25, "Bank_ID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Web_Page", System.Data.SqlDbType.VarChar, 100, "Web_Page"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User_ID", System.Data.SqlDbType.VarChar, 25, "User_ID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 25, "Password"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Security_code", System.Data.SqlDbType.VarChar, 25, "Security_code"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@online_banking", System.Data.SqlDbType.Bit, 1, "online_banking"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bank_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Security_code", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Security_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_User_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Web_Page", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Web_Page", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_account_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "account_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_account_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_account_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contact_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contact_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_default_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "default_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_name_bank", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "name_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_next_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "next_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_online_banking", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "online_banking", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_routing_numbers", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "routing_numbers", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_share_all_store", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "share_all_store", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_start_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "start_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_no", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bas_banks WHERE (id_bank = @Original_id_bank) AND (Bank_ID = @Origina" & _
        "l_Bank_ID OR @Original_Bank_ID IS NULL AND Bank_ID IS NULL) AND (GL_Account = @O" & _
        "riginal_GL_Account OR @Original_GL_Account IS NULL AND GL_Account IS NULL) AND (" & _
        "Password = @Original_Password OR @Original_Password IS NULL AND Password IS NULL" & _
        ") AND (Security_code = @Original_Security_code OR @Original_Security_code IS NUL" & _
        "L AND Security_code IS NULL) AND (User_ID = @Original_User_ID OR @Original_User_" & _
        "ID IS NULL AND User_ID IS NULL) AND (Web_Page = @Original_Web_Page OR @Original_" & _
        "Web_Page IS NULL AND Web_Page IS NULL) AND (account_no = @Original_account_no OR" & _
        " @Original_account_no IS NULL AND account_no IS NULL) AND (address = @Original_a" & _
        "ddress OR @Original_address IS NULL AND address IS NULL) AND (cod_account_type =" & _
        " @Original_cod_account_type OR @Original_cod_account_type IS NULL AND cod_accoun" & _
        "t_type IS NULL) AND (contact_name = @Original_contact_name OR @Original_contact_" & _
        "name IS NULL AND contact_name IS NULL) AND (default_bank = @Original_default_ban" & _
        "k OR @Original_default_bank IS NULL AND default_bank IS NULL) AND (email = @Orig" & _
        "inal_email OR @Original_email IS NULL AND email IS NULL) AND (extension_1 = @Ori" & _
        "ginal_extension_1 OR @Original_extension_1 IS NULL AND extension_1 IS NULL) AND " & _
        "(extension_2 = @Original_extension_2 OR @Original_extension_2 IS NULL AND extens" & _
        "ion_2 IS NULL) AND (extension_3 = @Original_extension_3 OR @Original_extension_3" & _
        " IS NULL AND extension_3 IS NULL) AND (extension_4 = @Original_extension_4 OR @O" & _
        "riginal_extension_4 IS NULL AND extension_4 IS NULL) AND (extension_5 = @Origina" & _
        "l_extension_5 OR @Original_extension_5 IS NULL AND extension_5 IS NULL) AND (ina" & _
        "ctive = @Original_inactive OR @Original_inactive IS NULL AND inactive IS NULL) A" & _
        "ND (name_bank = @Original_name_bank OR @Original_name_bank IS NULL AND name_bank" & _
        " IS NULL) AND (next_check_no = @Original_next_check_no OR @Original_next_check_n" & _
        "o IS NULL AND next_check_no IS NULL) AND (online_banking = @Original_online_bank" & _
        "ing OR @Original_online_banking IS NULL AND online_banking IS NULL) AND (phone_1" & _
        " = @Original_phone_1 OR @Original_phone_1 IS NULL AND phone_1 IS NULL) AND (phon" & _
        "e_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AND phone_2 IS NULL) AND (p" & _
        "hone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL AND phone_3 IS NULL) AND" & _
        " (phone_4 = @Original_phone_4 OR @Original_phone_4 IS NULL AND phone_4 IS NULL) " & _
        "AND (phone_5 = @Original_phone_5 OR @Original_phone_5 IS NULL AND phone_5 IS NUL" & _
        "L) AND (phone_main_1 = @Original_phone_main_1 OR @Original_phone_main_1 IS NULL " & _
        "AND phone_main_1 IS NULL) AND (phone_main_2 = @Original_phone_main_2 OR @Origina" & _
        "l_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (phone_main_3 = @Original_p" & _
        "hone_main_3 OR @Original_phone_main_3 IS NULL AND phone_main_3 IS NULL) AND (pho" & _
        "ne_main_4 = @Original_phone_main_4 OR @Original_phone_main_4 IS NULL AND phone_m" & _
        "ain_4 IS NULL) AND (phone_main_5 = @Original_phone_main_5 OR @Original_phone_mai" & _
        "n_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1 = @Original_phone_type_1" & _
        " OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NULL) AND (phone_type_2 =" & _
        " @Original_phone_type_2 OR @Original_phone_type_2 IS NULL AND phone_type_2 IS NU" & _
        "LL) AND (phone_type_3 = @Original_phone_type_3 OR @Original_phone_type_3 IS NULL" & _
        " AND phone_type_3 IS NULL) AND (phone_type_4 = @Original_phone_type_4 OR @Origin" & _
        "al_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (phone_type_5 = @Original_" & _
        "phone_type_5 OR @Original_phone_type_5 IS NULL AND phone_type_5 IS NULL) AND (ro" & _
        "uting_numbers = @Original_routing_numbers OR @Original_routing_numbers IS NULL A" & _
        "ND routing_numbers IS NULL) AND (share_all_store = @Original_share_all_store OR " & _
        "@Original_share_all_store IS NULL AND share_all_store IS NULL) AND (start_check_" & _
        "no = @Original_start_check_no OR @Original_start_check_no IS NULL AND start_chec" & _
        "k_no IS NULL) AND (store_no = @Original_store_no OR @Original_store_no IS NULL A" & _
        "ND store_no IS NULL) AND (zip = @Original_zip OR @Original_zip IS NULL AND zip I" & _
        "S NULL)"
        Me.SqlDeleteCommand2.Connection = Me.CnnTemp
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bank_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Security_code", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Security_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_User_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Web_Page", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Web_Page", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_account_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "account_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_account_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_account_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contact_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contact_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_default_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "default_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_name_bank", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "name_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_next_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "next_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_online_banking", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "online_banking", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_routing_numbers", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "routing_numbers", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_share_all_store", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "share_all_store", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_start_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "start_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_no", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_banks
        '
        Me.DAbas_banks.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAbas_banks.InsertCommand = Me.SqlInsertCommand2
        Me.DAbas_banks.SelectCommand = Me.SqlSelectCommand4
        Me.DAbas_banks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        Me.DAbas_banks.UpdateCommand = Me.SqlUpdateCommand2
        '
        'DAGL_debit_deposit
        '
        Me.DAGL_debit_deposit.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_debit_deposit.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_debit_deposit.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_debit_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit", "id_debit_deposit"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("check_no", "check_no"), New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("date_document", "date_document")})})
        Me.DAGL_debit_deposit.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_debit_deposit WHERE (id_debit_deposit = @Original_id_debit_deposit" & _
        ") AND (GL_account = @Original_GL_account OR @Original_GL_account IS NULL AND GL_" & _
        "account IS NULL) AND (ID_payment = @Original_ID_payment OR @Original_ID_payment " & _
        "IS NULL AND ID_payment IS NULL) AND (cc_type = @Original_cc_type OR @Original_cc" & _
        "_type IS NULL AND cc_type IS NULL) AND (check_no = @Original_check_no OR @Origin" & _
        "al_check_no IS NULL AND check_no IS NULL) AND (cod_customer = @Original_cod_cust" & _
        "omer OR @Original_cod_customer IS NULL AND cod_customer IS NULL) AND (date_docum" & _
        "ent = @Original_date_document OR @Original_date_document IS NULL AND date_docume" & _
        "nt IS NULL) AND (debit_amount = @Original_debit_amount OR @Original_debit_amount" & _
        " IS NULL AND debit_amount IS NULL) AND (deposit_amount = @Original_deposit_amoun" & _
        "t OR @Original_deposit_amount IS NULL AND deposit_amount IS NULL) AND (id_check " & _
        "= @Original_id_check OR @Original_id_check IS NULL AND id_check IS NULL) AND (id" & _
        "_transfer = @Original_id_transfer OR @Original_id_transfer IS NULL AND id_transf" & _
        "er IS NULL) AND (memo = @Original_memo OR @Original_memo IS NULL AND memo IS NUL" & _
        "L) AND (payment_type = @Original_payment_type OR @Original_payment_type IS NULL " & _
        "AND payment_type IS NULL) AND (refer_type = @Original_refer_type OR @Original_re" & _
        "fer_type IS NULL AND refer_type IS NULL) AND (type_transaction = @Original_type_" & _
        "transaction OR @Original_type_transaction IS NULL AND type_transaction IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_document", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_document", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_debit_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "debit_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deposit_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deposit_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_transaction", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_transaction", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_debit_deposit(type_transaction, ID_payment, id_check, id_transfer," & _
        " debit_amount, deposit_amount, GL_account, cod_customer, refer_type, memo, check" & _
        "_no, cc_type, payment_type, date_document) VALUES (@type_transaction, @ID_paymen" & _
        "t, @id_check, @id_transfer, @debit_amount, @deposit_amount, @GL_account, @cod_cu" & _
        "stomer, @refer_type, @memo, @check_no, @cc_type, @payment_type, @date_document);" & _
        " SELECT id_debit_deposit, type_transaction, ID_payment, id_check, id_transfer, d" & _
        "ebit_amount, deposit_amount, GL_account, cod_customer, refer_type, memo, check_n" & _
        "o, cc_type, payment_type, date_document FROM GL_debit_deposit WHERE (id_debit_de" & _
        "posit = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_transaction", System.Data.SqlDbType.VarChar, 1, "type_transaction"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_transfer", System.Data.SqlDbType.Int, 4, "id_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@debit_amount", System.Data.SqlDbType.Money, 8, "debit_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_amount", System.Data.SqlDbType.Money, 8, "deposit_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 10, "refer_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_no", System.Data.SqlDbType.VarChar, 20, "check_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_document", System.Data.SqlDbType.VarChar, 10, "date_document"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_debit_deposit.type_transaction, CASE WHEN (cust_company.complete_name I" & _
        "S NULL OR cust_company.complete_name = '') THEN rtrim(ltrim(cust_trtab_main.f_na" & _
        "me)) + ' ' + rtrim(ltrim(cust_trtab_main.m_name)) + ' ' + rtrim(ltrim(cust_trtab" & _
        "_main.l_name)) ELSE cust_company.complete_name END AS CustomerFullName, GL_debit" & _
        "_deposit.GL_account, GL_debit_deposit.deposit_amount, GL_debit_deposit.ID_paymen" & _
        "t, CASE WHEN type_transaction = '5' THEN GL_External_Cash.payment_type ELSE GL_p" & _
        "ayment_deposit.payment_type END AS payment_type, CASE WHEN type_transaction = '5" & _
        "' THEN GL_External_Cash.cod_customer ELSE service_center_head.cod_customer END A" & _
        "S cod_customer, CASE WHEN type_transaction = '5' THEN GL_External_Cash.check_no " & _
        "ELSE (CASE WHEN refer_type = '1' THEN GL_payment_check.check_no ELSE Gl_receive_" & _
        "payment.check_no END) END AS check_no, CASE WHEN type_transaction = '5' THEN GL_" & _
        "External_Cash.cc_type ELSE Gl_receive_payment.cc_type END AS cc_type, GL_payment" & _
        "_deposit.refer_type, GL_debit_deposit.Memo, CASE WHEN type_transaction + '' = '5" & _
        "' THEN 0 ELSE 1 END AS FlagCanEdit, GL_debit_deposit.id_external_cash, service_c" & _
        "enter_head.date_refer FROM GL_debit_deposit LEFT OUTER JOIN GL_payment_deposit O" & _
        "N GL_debit_deposit.ID_payment = GL_payment_deposit.ID_payment LEFT OUTER JOIN se" & _
        "rvice_center_head ON GL_payment_deposit.id_service_center = service_center_head." & _
        "id_service_center LEFT OUTER JOIN cust_company RIGHT OUTER JOIN cust_trtab_main " & _
        "ON cust_company.cod_company = cust_trtab_main.cod_company ON service_center_head" & _
        ".cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN GL_External_Cash ON" & _
        " GL_debit_deposit.id_external_cash = GL_External_Cash.id_external_cash LEFT OUTE" & _
        "R JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment" & _
        ".refrence_no LEFT OUTER JOIN GL_payment_check ON GL_payment_deposit.ID_payment =" & _
        " GL_payment_check.ID_payment LEFT OUTER JOIN GL_payment_credit ON GL_payment_dep" & _
        "osit.ID_payment = GL_payment_credit.ID_payment WHERE (GL_debit_deposit.id_debit_" & _
        "deposit_head = @id_debit_deposit_head) AND (GL_debit_deposit.type_transaction IN" & _
        " ('1', '2', '4', '5', '6', '7'))"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_debit_deposit SET type_transaction = @type_transaction, ID_payment = @I" & _
        "D_payment, id_check = @id_check, id_transfer = @id_transfer, debit_amount = @deb" & _
        "it_amount, deposit_amount = @deposit_amount, GL_account = @GL_account, cod_custo" & _
        "mer = @cod_customer, refer_type = @refer_type, memo = @memo, check_no = @check_n" & _
        "o, cc_type = @cc_type, payment_type = @payment_type, date_document = @date_docum" & _
        "ent WHERE (id_debit_deposit = @Original_id_debit_deposit) AND (GL_account = @Ori" & _
        "ginal_GL_account OR @Original_GL_account IS NULL AND GL_account IS NULL) AND (ID" & _
        "_payment = @Original_ID_payment OR @Original_ID_payment IS NULL AND ID_payment I" & _
        "S NULL) AND (cc_type = @Original_cc_type OR @Original_cc_type IS NULL AND cc_typ" & _
        "e IS NULL) AND (check_no = @Original_check_no OR @Original_check_no IS NULL AND " & _
        "check_no IS NULL) AND (cod_customer = @Original_cod_customer OR @Original_cod_cu" & _
        "stomer IS NULL AND cod_customer IS NULL) AND (date_document = @Original_date_doc" & _
        "ument OR @Original_date_document IS NULL AND date_document IS NULL) AND (debit_a" & _
        "mount = @Original_debit_amount OR @Original_debit_amount IS NULL AND debit_amoun" & _
        "t IS NULL) AND (deposit_amount = @Original_deposit_amount OR @Original_deposit_a" & _
        "mount IS NULL AND deposit_amount IS NULL) AND (id_check = @Original_id_check OR " & _
        "@Original_id_check IS NULL AND id_check IS NULL) AND (id_transfer = @Original_id" & _
        "_transfer OR @Original_id_transfer IS NULL AND id_transfer IS NULL) AND (memo = " & _
        "@Original_memo OR @Original_memo IS NULL AND memo IS NULL) AND (payment_type = @" & _
        "Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS NULL" & _
        ") AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND ref" & _
        "er_type IS NULL) AND (type_transaction = @Original_type_transaction OR @Original" & _
        "_type_transaction IS NULL AND type_transaction IS NULL); SELECT id_debit_deposit" & _
        ", type_transaction, ID_payment, id_check, id_transfer, debit_amount, deposit_amo" & _
        "unt, GL_account, cod_customer, refer_type, memo, check_no, cc_type, payment_type" & _
        ", date_document FROM GL_debit_deposit WHERE (id_debit_deposit = @id_debit_deposi" & _
        "t)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_transaction", System.Data.SqlDbType.VarChar, 1, "type_transaction"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_transfer", System.Data.SqlDbType.Int, 4, "id_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@debit_amount", System.Data.SqlDbType.Money, 8, "debit_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_amount", System.Data.SqlDbType.Money, 8, "deposit_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 10, "refer_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_no", System.Data.SqlDbType.VarChar, 20, "check_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_document", System.Data.SqlDbType.VarChar, 10, "date_document"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_document", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_document", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_debit_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "debit_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deposit_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deposit_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_transaction", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_transaction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit", System.Data.SqlDbType.Int, 4, "id_debit_deposit"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_debit_deposit_head.id_debit_deposit_head, GL_debit_deposit_head.date_do" & _
        "c + ' - ' + bas_banks.name_bank AS Expr1 FROM GL_debit_deposit_head INNER JOIN b" & _
        "as_banks ON GL_debit_deposit_head.id_bank = bas_banks.id_bank WHERE (GL_debit_de" & _
        "posit_head.id_debit_deposit_head IN (SELECT DISTINCT id_debit_deposit_head FROM " & _
        "GL_debit_deposit WHERE (type_transaction = '1'))) ORDER BY GL_debit_deposit_head" & _
        ".date_doc + ' - ' + bas_banks.name_bank"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO GL_debit_deposit_head(id_bank, date_doc, memo) VALUES (@id_bank, @dat" & _
        "e_doc, @memo); SELECT id_debit_deposit_head, id_bank, date_doc, memo FROM GL_deb" & _
        "it_deposit_head WHERE (id_debit_deposit_head = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_doc", System.Data.SqlDbType.VarChar, 10, "date_doc"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE GL_debit_deposit_head SET id_bank = @id_bank, date_doc = @date_doc, memo =" & _
        " @memo WHERE (id_debit_deposit_head = @Original_id_debit_deposit_head) AND (date" & _
        "_doc = @Original_date_doc OR @Original_date_doc IS NULL AND date_doc IS NULL) AN" & _
        "D (id_bank = @Original_id_bank OR @Original_id_bank IS NULL AND id_bank IS NULL)" & _
        " AND (memo = @Original_memo OR @Original_memo IS NULL AND memo IS NULL); SELECT " & _
        "id_debit_deposit_head, id_bank, date_doc, memo FROM GL_debit_deposit_head WHERE " & _
        "(id_debit_deposit_head = @id_debit_deposit_head)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_doc", System.Data.SqlDbType.VarChar, 10, "date_doc"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo", System.Data.SqlDbType.VarChar, 100, "memo"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_doc", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_doc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM GL_debit_deposit_head WHERE (id_debit_deposit_head = @Original_id_deb" & _
        "it_deposit_head) AND (date_doc = @Original_date_doc OR @Original_date_doc IS NUL" & _
        "L AND date_doc IS NULL) AND (id_bank = @Original_id_bank OR @Original_id_bank IS" & _
        " NULL AND id_bank IS NULL) AND (memo = @Original_memo OR @Original_memo IS NULL " & _
        "AND memo IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_doc", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_doc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_debit_deposit_head
        '
        Me.DAGL_debit_deposit_head.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAGL_debit_deposit_head.InsertCommand = Me.SqlInsertCommand4
        Me.DAGL_debit_deposit_head.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_debit_deposit_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo")})})
        Me.DAGL_debit_deposit_head.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account, desc_GL_account, GL_account_master, group_GL_account, remark F" & _
        "ROM GL_account"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO GL_account(GL_account, desc_GL_account, GL_account_master, group_GL_a" & _
        "ccount, remark) VALUES (@GL_account, @desc_GL_account, @GL_account_master, @grou" & _
        "p_GL_account, @remark); SELECT GL_account, desc_GL_account, GL_account_master, g" & _
        "roup_GL_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE GL_account SET GL_account = @GL_account, desc_GL_account = @desc_GL_accoun" & _
        "t, GL_account_master = @GL_account_master, group_GL_account = @group_GL_account," & _
        " remark = @remark WHERE (GL_account = @Original_GL_account) AND (GL_account_mast" & _
        "er = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND GL_a" & _
        "ccount_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @Orig" & _
        "inal_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_account " & _
        "= @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group_GL_" & _
        "account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AND " & _
        "remark IS NULL); SELECT GL_account, desc_GL_account, GL_account_master, group_GL" & _
        "_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM GL_account WHERE (GL_account = @Original_GL_account) AND (GL_account_" & _
        "master = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND " & _
        "GL_account_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @" & _
        "Original_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_acco" & _
        "unt = @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group" & _
        "_GL_account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL " & _
        "AND remark IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_account
        '
        Me.DAGL_account.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAGL_account.InsertCommand = Me.SqlInsertCommand3
        Me.DAGL_account.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        Me.DAGL_account.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cust_trtab_main.cod_customer AS cod_customer, CASE WHEN cust_company.compl" & _
        "ete_name IS NULL THEN rtrim(ltrim(cust_trtab_main.f_name)) + ' ' + rtrim(ltrim(c" & _
        "ust_trtab_main.m_name)) + ' ' + rtrim(ltrim(cust_trtab_main.l_name)) ELSE cust_c" & _
        "ompany.complete_name + ' ' END AS CustomerFullName FROM cust_trtab_main LEFT OUT" & _
        "ER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO cust_trtab_main(cod_customer, vip_code, cod_company, f_name, m_name, " & _
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
        Me.SqlInsertCommand5.Connection = Me.Cnn
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DriverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.Real, 4, "cust_exempt_tax"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 2, "AR_term"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_no", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE cust_trtab_main SET cod_customer = @cod_customer, vip_code = @vip_code, co" & _
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
        Me.SqlUpdateCommand5.Connection = Me.Cnn
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DriverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.Real, 4, "cust_exempt_tax"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 2, "AR_term"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_no", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_accept_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_accept_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_credit_hold", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_credit_hold", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_finance_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_finance_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_require_PO", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_require_PO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_send_copy", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_send_copy", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_statement", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_statement", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_term", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DriverLicense", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DriverLicense", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_price", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_rep", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_rep", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_card_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_card_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_limited", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_limited", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_exempt_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_exempt_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_report", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_report", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name3", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name4", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_expiration_credit_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "expiration_credit_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_value", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_value", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_id", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vip_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vip_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM cust_trtab_main WHERE (cod_customer = @Original_cod_customer) AND (AR" & _
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
        Me.SqlDeleteCommand5.Connection = Me.Cnn
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_accept_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_accept_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_credit_hold", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_credit_hold", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_finance_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_finance_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_require_PO", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_require_PO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_send_copy", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_send_copy", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_statement", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_statement", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_term", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DriverLicense", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DriverLicense", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_price", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_rep", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_rep", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_card_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_card_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_limited", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_limited", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_exempt_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_exempt_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_report", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_report", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name3", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name4", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_expiration_credit_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "expiration_credit_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_value", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_value", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_id", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vip_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vip_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAcust_trtab_main
        '
        Me.DAcust_trtab_main.DeleteCommand = Me.SqlDeleteCommand5
        Me.DAcust_trtab_main.InsertCommand = Me.SqlInsertCommand5
        Me.DAcust_trtab_main.SelectCommand = Me.SqlSelectCommand5
        Me.DAcust_trtab_main.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        Me.DAcust_trtab_main.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cc_type, cc_type_desc FROM bas_cc_type"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO bas_cc_type(cc_type, cc_type_desc) VALUES (@cc_type, @cc_type_desc); " & _
        "SELECT cc_type, cc_type_desc FROM bas_cc_type WHERE (cc_type = @cc_type)"
        Me.SqlInsertCommand6.Connection = Me.Cnn
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type_desc", System.Data.SqlDbType.VarChar, 50, "cc_type_desc"))
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
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM bas_cc_type WHERE (cc_type = @Original_cc_type) AND (cc_type_desc = @" & _
        "Original_cc_type_desc OR @Original_cc_type_desc IS NULL AND cc_type_desc IS NULL" & _
        ")"
        Me.SqlDeleteCommand6.Connection = Me.Cnn
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_cc_type
        '
        Me.DAbas_cc_type.DeleteCommand = Me.SqlDeleteCommand6
        Me.DAbas_cc_type.InsertCommand = Me.SqlInsertCommand6
        Me.DAbas_cc_type.SelectCommand = Me.SqlSelectCommand6
        Me.DAbas_cc_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_cc_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_type_desc", "cc_type_desc")})})
        Me.DAbas_cc_type.UpdateCommand = Me.SqlUpdateCommand6
        '
        'FrmBankDeposits
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(603, 459)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmBankDeposits"
        Me.Text = "Bank Deposits"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmBankDeposits1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmReceivePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        AddConditionalFormatting()

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveGeneralLedgerSetupTable()
        Try
            Default_cash_overVar = OleDbReaderForStore.Item("Default_cash_over")
        Catch ex As Exception
            Default_cash_overVar = ""
        End Try


        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn

        Call FillDataSets()
        CM = CType(Me.BindingContext(DsFrmBankDeposits1.GL_debit_deposit_head), CurrencyManager)

        GrdDetail.DropDowns("GL_account").SetDataBinding(DsFrmBankDeposits1, "GL_account")
        GrdDetail.DropDowns("cust_trtab_main").SetDataBinding(DsFrmBankDeposits1, "cust_trtab_main")
        GrdDetail.DropDowns("cc_type").SetDataBinding(DsFrmBankDeposits1, "BAS_cc_type")
        GrdDetail.DropDowns("Pmt_type").SetDataBinding(DsFrmBankDeposits1, "Pmt_type")

        If BankDepositVar.Trim.Length > 0 Then
            Call PAddNew()
            CmbBank.Focus()
        Else
            If BankDepositHeadTempVar = 0 Then
                Call PFirstRecord(False)
            Else
                CmbBankDepositHead.SelectedValue = BankDepositHeadTempVar
            End If
            Try
                Call FillFields(CmbBankDepositHead.SelectedValue)
            Catch ex As Exception
            End Try
            Call AfterSaveOrCancel()
            CmbBank.Focus()
        End If
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "select count(*) from GL_account Where GL_account=" & Qt(Default_cash_overVar)
        If CmdGeneral.ExecuteScalar = 0 Then
            MsgBox("Please Fill the Default value of Cash Over Account in General Ledger Setup")
            Call DisableAllComponet(Me, False)
        End If

    End Sub
    Private Sub FillDataSets()
        DsFrmBankDeposits1.bas_banks.Clear()
        DAbas_banks.Fill(DsFrmBankDeposits1, "bas_banks")
        If DsFrmBankDeposits1.bas_banks.Rows.Count < 1 Then
            MsgFar("Please Fill The Bank Account Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmBankDeposits1.bas_cc_type.Clear()
        DAbas_cc_type.Fill(DsFrmBankDeposits1, "bas_cc_type")

        DsFrmBankDeposits1.GL_account.Clear()
        DAGL_account.Fill(DsFrmBankDeposits1, "GL_account")

        DsFrmBankDeposits1.cust_trtab_main.Clear()
        DAcust_trtab_main.Fill(DsFrmBankDeposits1, "cust_trtab_main")

        Call FillGL_debit_deposit_head()

        Dim dr As DataRow
        dr = DsFrmBankDeposits1.Pmt_type.NewRow
        dr("Payment_Type") = ""
        dr("Payment_Desc") = ""
        DsFrmBankDeposits1.Pmt_type.Rows.Add(dr)
        dr = DsFrmBankDeposits1.Pmt_type.NewRow
        dr("Payment_Type") = "1"
        dr("Payment_Desc") = "Cash"
        DsFrmBankDeposits1.Pmt_type.Rows.Add(dr)
        dr = DsFrmBankDeposits1.Pmt_type.NewRow
        dr("Payment_Type") = "2"
        dr("Payment_Desc") = "Check"
        DsFrmBankDeposits1.Pmt_type.Rows.Add(dr)
        dr = DsFrmBankDeposits1.Pmt_type.NewRow
        dr("Payment_Type") = "3"
        dr("Payment_Desc") = "Credit"
        DsFrmBankDeposits1.Pmt_type.Rows.Add(dr)
        dr = DsFrmBankDeposits1.Pmt_type.NewRow
        dr("Payment_Type") = "4"
        dr("Payment_Desc") = "AR"
        DsFrmBankDeposits1.Pmt_type.Rows.Add(dr)

    End Sub
    Private Sub FillGL_debit_deposit_head()
        DsFrmBankDeposits1.GL_debit_deposit_head.Clear()
        'DsFrmBankDeposits1.GL_debit_deposit_head.AddGL_debit_deposit_headRow(0, "")
        DAGL_debit_deposit_head.Fill(DsFrmBankDeposits1, "GL_debit_deposit_head")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew
        CashPaidOut_OtherReceiptFlag = False
        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        BankDepositHeadTempVar = CmbBankDepositHead.SelectedValue
        Call ClearField()

        Call AddEmptyRecordToGrid()

        Try
            MyFrmSelectPaymentstoDeposit.Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        MyFrmSelectPaymentstoDeposit.FillDataSet()

        DteDate_document.Text = Format(Now.Date, PubDateFormat)
        FilterDateVar = DteDate_document.Text

        Call FillTotals(0)

        CmbBank.Focus()

        BtnNew.Enabled = False
        BtnFind.Enabled = False
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
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Private Sub FillTotals(ByVal Id_debit_deposit_headParam As Decimal)
        LblCashPaidOuts.Text = 0
        LblOtherReceiptsCash.Text = 0
        LblOtherReceiptsCheck.Text = 0
        LblAvailableToDeposit.Text = 0
        LblDownPaymentCash.Text = 0
        LblOverPaymentCash.Text = 0
        LblPaymentForOtherStoreCash.Text = 0
        LblDownPaymentCheck.Text = 0
        LblOverPaymentCheck.Text = 0
        LblPaymentForOtherStoreCheck.Text = 0
        LblDownPaymentCredit.Text = 0
        LblOverPaymentCredit.Text = 0
        LblPaymentForOtherStoreCredit.Text = 0
        If GrdDetail.RowCount > 0 Then
            If Id_debit_deposit_headParam > 0 Then
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "select debit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='8'"
                Try
                    LblCashPaidOuts.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblCashPaidOuts.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='9'"
                Try
                    LblOtherReceiptsCash.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblOtherReceiptsCash.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='A'"
                Try
                    LblOtherReceiptsCheck.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblOtherReceiptsCheck.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='B' "
                Try
                    LblPaymentForOtherStoreCash.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblPaymentForOtherStoreCash.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='C' "
                Try
                    LblPaymentForOtherStoreCheck.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblPaymentForOtherStoreCheck.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='D' "
                Try
                    LblPaymentForOtherStoreCredit.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblPaymentForOtherStoreCredit.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='E' "
                Try
                    LblOverPaymentCash.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblOverPaymentCash.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='F' "
                Try
                    LblOverPaymentCheck.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblOverPaymentCheck.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='G' "
                Try
                    LblOverPaymentCredit.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblOverPaymentCredit.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='H' "
                Try
                    LblDownPaymentCash.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblDownPaymentCash.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='I' "
                Try
                    LblDownPaymentCheck.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblDownPaymentCheck.Text = 0
                End Try

                CmdGeneral.CommandText = "select deposit_amount from GL_debit_deposit Where id_debit_deposit_head=" & Id_debit_deposit_headParam & " AND type_transaction='J' "
                Try
                    LblDownPaymentCredit.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblDownPaymentCredit.Text = 0
                End Try

            Else
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                If CashPaidOut_OtherReceiptFlag Then
                    CmdGeneral.CommandText = "select  Sum(round(amount,2)) from GL_Paid_received Where dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND (tran_type='1' OR tran_type='3') AND Id_debit_deposit_head=0 "
                    Try
                        LblCashPaidOuts.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblCashPaidOuts.Text = 0
                    End Try

                    CmdGeneral.CommandText = "select  Sum(round(amount,2)) from GL_Paid_received Where dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & "  AND tran_type='2' and OtherReceipType='1' AND Id_debit_deposit_head=0 "
                    Try
                        LblOtherReceiptsCash.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblOtherReceiptsCash.Text = 0
                    End Try

                    CmdGeneral.CommandText = "select  Sum(round(amount,2)) from GL_Paid_received Where dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND tran_type='2' and OtherReceipType<>'1' AND Id_debit_deposit_head=0 "
                    Try
                        LblOtherReceiptsCheck.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblOtherReceiptsCheck.Text = 0

                    End Try

                    CmdGeneral.CommandText = " SELECT Sum(round(OtherStoreAmount,2)) FROM Gl_receive_payment  Where dbo.ChangeDate(date_receive_payment)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND pmt_method='1' AND Id_debit_deposit_head=0 AND OtherStoreAmount>0"
                    Try
                        LblPaymentForOtherStoreCash.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblPaymentForOtherStoreCash.Text = 0
                    End Try

                    CmdGeneral.CommandText = " SELECT Sum(round(OtherStoreAmount,2)) FROM Gl_receive_payment  Where dbo.ChangeDate(date_receive_payment)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND pmt_method='2' AND Id_debit_deposit_head=0 AND OtherStoreAmount>0"
                    Try
                        LblPaymentForOtherStoreCheck.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblPaymentForOtherStoreCheck.Text = 0
                    End Try

                    CmdGeneral.CommandText = " SELECT Sum(round(amount_over,2)) FROM Gl_receive_payment  Where dbo.ChangeDate(date_receive_payment)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND pmt_method='1' AND Id_debit_deposit_head=0 AND amount_over>0"
                    Try
                        LblOverPaymentCash.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblOverPaymentCash.Text = 0
                    End Try

                    CmdGeneral.CommandText = " SELECT Sum(round(amount_over,2)) FROM Gl_receive_payment  Where dbo.ChangeDate(date_receive_payment)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND pmt_method='2' AND Id_debit_deposit_head=0 AND amount_over>0"
                    Try
                        LblOverPaymentCheck.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblOverPaymentCheck.Text = 0
                    End Try

                    CmdGeneral.CommandText = "SELECT  Sum(round(amount,2)) FROM GL_Paid_received WHERE dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND tran_type='4' and Id_debit_deposit_head=0 AND OtherReceipType='1' AND id_service_center not in (SELECT     service_center_dtl.id_service_center FROM         service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center WHERE     (service_center_dtl.type_select = 'B') AND (service_center_head.type_of_form = 'WO'))"
                    Try
                        LblDownPaymentCash.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblDownPaymentCash.Text = 0
                    End Try

                    CmdGeneral.CommandText = "SELECT  Sum(round(amount,2)) FROM GL_Paid_received WHERE dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND tran_type='4' and Id_debit_deposit_head=0 AND OtherReceipType='2'  AND id_service_center not in (SELECT     service_center_dtl.id_service_center FROM         service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center WHERE     (service_center_dtl.type_select = 'B') AND (service_center_head.type_of_form = 'WO'))"
                    Try
                        LblDownPaymentCheck.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblDownPaymentCheck.Text = 0
                    End Try

                    CmdGeneral.CommandText = "SELECT  Sum(round(amount,2)) FROM GL_Paid_received WHERE dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND tran_type='4' and Id_debit_deposit_head=0 AND OtherReceipType='3'  AND id_service_center not in (SELECT     service_center_dtl.id_service_center FROM         service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center WHERE     (service_center_dtl.type_select = 'B') AND (service_center_head.type_of_form = 'WO'))"
                    Try
                        LblDownPaymentCredit.Text = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        LblDownPaymentCredit.Text = 0
                    End Try

                End If

                CmdGeneral.CommandText = " SELECT Sum(round(OtherStoreAmount,2)) FROM Gl_receive_payment  Where dbo.ChangeDate(date_receive_payment)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND pmt_method='3' AND Id_debit_deposit_head=0 AND OtherStoreAmount>0"
                Try
                    LblPaymentForOtherStoreCredit.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblPaymentForOtherStoreCredit.Text = 0
                End Try
                CmdGeneral.CommandText = " SELECT Sum(round(amount_over,2)) FROM Gl_receive_payment  Where dbo.ChangeDate(date_receive_payment)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND pmt_method='3' AND Id_debit_deposit_head=0 AND amount_over>0"
                Try
                    LblOverPaymentCredit.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    LblOverPaymentCredit.Text = 0
                End Try

            End If

            LblAvailableToDeposit.Text = LblDepositSubtotal.Numbervalue - LblCashPaidOuts.Numbervalue + LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue
            LblAvailableToDeposit.Text = LblAvailableToDeposit.Numbervalue + LblPaymentForOtherStoreCash.Numbervalue + LblPaymentForOtherStoreCheck.Numbervalue + LblPaymentForOtherStoreCredit.Numbervalue
            LblAvailableToDeposit.Text = LblAvailableToDeposit.Numbervalue + LblOverPaymentCash.Numbervalue + LblOverPaymentCheck.Numbervalue + LblOverPaymentCredit.Numbervalue
            LblAvailableToDeposit.Text = LblAvailableToDeposit.Numbervalue + LblDownPaymentCash.Numbervalue + LblDownPaymentCheck.Numbervalue + LblDownPaymentCredit.Numbervalue
        End If

        LblDepositTotal.Text = LblAvailableToDeposit.Numbervalue - NumCashbackAmount.Numbervalue

    End Sub
    Sub PEdit()
        If CheckifInformationWasChanged() Then
            Exit Sub
        End If

        If CmbBankDepositHead.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Try
            Call FillFields(CmbBankDepositHead.SelectedValue)
        Catch ex As Exception
        End Try

        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True)
        BankDepositHeadTempVar = CmbBankDepositHead.SelectedValue
        CmbBank.Focus()

        BtnNew.Enabled = False
        BtnFind.Enabled = False
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
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PDelete()
        If CmbBankDepositHead.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdDelete.Connection.State <> ConnectionState.Open Then
                    CmdDelete.Connection.Open()
                End If
                CmdDelete.Parameters("@id_debit_deposit_head").Value = CmbBankDepositHead.SelectedValue
                CmdDelete.ExecuteNonQuery()
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                If DsFrmBankDeposits1.GL_debit_deposit.Rows.Count > 0 Then
                    CmdGeneral.CommandText = "update GL_Paid_received Set Id_debit_deposit_head=0 Where Id_debit_deposit_head=" & CmbBankDepositHead.SelectedValue
                    CmdGeneral.ExecuteNonQuery()
                    CmdGeneral.CommandText = "update Gl_receive_payment Set Id_debit_deposit_head=0 Where Id_debit_deposit_head=" & CmbBankDepositHead.SelectedValue
                    CmdGeneral.ExecuteNonQuery()
                    Dim i As Integer
                    For i = 0 To DsFrmBankDeposits1.GL_debit_deposit.Rows.Count - 1
                        Select Case DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("type_transaction") & ""
                            Case "1"
                                CmdGeneral.CommandText = "update GL_payment_deposit Set flag_deposit_bank=0 Where ID_payment=" & DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("Id_Payment")
                                CmdGeneral.ExecuteNonQuery()
                            Case "5"
                                CmdGeneral.CommandText = "Delete From GL_External_Cash WHERE id_external_cash = " & DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("id_external_cash")
                                CmdGeneral.ExecuteNonQuery()
                        End Select
                    Next
                End If
                BankDepositHeadTempVar = 0
                Call FillGL_debit_deposit_head()

                Call PNextRecord(False)
                If BankDepositHeadTempVar = 0 Then
                    Call PPreviousRecord(False)
                End If
                If BankDepositHeadTempVar = 0 Then
                    Call ClearField()
                Else
                    Call FillFields(BankDepositHeadTempVar)
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            Finally
                CmdDelete.Connection.Close()
            End Try
            Call AfterSaveOrCancel()
        Else
            CmbBank.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        If LblDepositTotal.Text <= 0 Then
            MsgFar("Total Of Deposit is 0 OR Negative !!!!!!!!!!")
            Exit Sub
        End If
        Select Case Status
            Case MainModule.WorkStates.AddNew
                BankDepositHeadTempVar = PInsert()
                ChangeOK = IIf(BankDepositHeadTempVar = 0, False, True)
                If BankDepositVar.Trim.Length > 0 Then
                    BankDepositVar = BankDepositHeadTempVar
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(BankDepositHeadTempVar)
        End Select
        If ChangeOK Then
            Call FillGL_debit_deposit_head()
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            CmbBankDepositHead.SelectedValue = BankDepositHeadTempVar
            Call FillFields(CmbBankDepositHead.SelectedValue)
            CmbBankDepositHead.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbBankDepositHead.SelectedValue = BankDepositHeadTempVar
        Call FillFields(CmbBankDepositHead.SelectedValue)
        Call AfterSaveOrCancel()
        CmbBankDepositHead.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        BtnFind.Enabled = True
        MAddNew.Enabled = True
        If CmbBankDepositHead.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False
            MDelete.Enabled = False
            BtnEdit.Enabled = False
            MEdit.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnFirst.Enabled = False
            BtnLast.Enabled = False
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
    Private Sub TxtRefrence_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMemo.TextChanged, CmbBank.SelectedValueChanged, NumCashbackAmount.TextChanged, CmbCashbackgoesto.SelectedIndexChanged, TxtCashBackMemo.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If CmbBank.Text.Trim.Length > 0 And Mid(DteDate_document.Text, 1, 4).Trim.Length > 0 Then
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
        If CM.Position = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CM.Position = 0
            Call FillFields(CmbBankDepositHead.SelectedValue)
        End If
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CM.Position = CM.Position - 1
            Call FillFields(CmbBankDepositHead.SelectedValue)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmBankDeposits1.GL_debit_deposit_head.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = CM.Position + 1
            Call FillFields(CmbBankDepositHead.SelectedValue)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmBankDeposits1.GL_debit_deposit_head.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = DsFrmBankDeposits1.GL_debit_deposit_head.Rows.Count - 1
            Call FillFields(CmbBankDepositHead.SelectedValue)
        End If
    End Sub
    Private Sub CmbBankDepositHead_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBankDepositHead.SelectionChangeCommitted
        Call FillFields(CmbBankDepositHead.SelectedValue)
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
            CmbBankDepositHead.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub PPrintMasterInformation()
        'If CmbBankDepositHead.Text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@refrence_no").Value = CmbBankDepositHead.Text
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
            CmbBank.Enabled = instatus
            DteDate_document.Enabled = instatus
        Else
            CmbBank.Enabled = False
            DteDate_document.Enabled = False
        End If
        '''GrdDetail.Enabled = instatus
        If instatus Then
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        Else
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        End If
        CmbCashbackgoesto.Enabled = instatus
        TxtCashBackMemo.Enabled = instatus
        TxtMemo.Enabled = instatus
        NumCashbackAmount.Enabled = instatus
        If instatus Then
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        Else
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        End If
        BtnSelectPayments.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "select Top 1 id_bank from bas_banks Where default_bank=1"
        Try
            CmbBank.SelectedValue = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            CmbBank.SelectedValue = 0
        End Try

        Try
            CmbCashbackgoesto.SelectedValue = 0
        Catch ex As Exception
        End Try

        TxtMemo.Text = ""
        TxtCashBackMemo.Text = ""

        NumCashbackAmount.Text = 0
        DteDate_document.Text = Format(Now.Date, PubDateFormat)
        FilterDateVar = DteDate_document.Text

        LblDepositSubtotal.Text = "0"
        LblDepositTotal.Text = "0"
        LblAvailableToDeposit.Text = "0"
        LblCashPaidOuts.Text = "0"
        LblOtherReceiptsCash.Text = "0"
        LblOtherReceiptsCheck.Text = "0"
        LblPaymentForOtherStoreCash.Text = "0"
        LblPaymentForOtherStoreCheck.Text = "0"
        LblPaymentForOtherStoreCredit.Text = "0"
        LblOverPaymentCash.Text = "0"
        LblOverPaymentCheck.Text = "0"
        LblOverPaymentCredit.Text = "0"
        LblDownPaymentCash.Text = "0"
        LblDownPaymentCheck.Text = "0"
        LblDownPaymentCredit.Text = "0"

        DsFrmBankDeposits1.GL_debit_deposit.Clear()
    End Sub
    Friend Function PInsert() As Decimal
        Dim thisrow As DataRow
        PInsert = 0
        Try
            If DoInsertAndUpdate(False) > 0 Then
                PInsert = CmbBank.SelectedValue
            Else
                PInsert = 0
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = 0
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisRefrence_No As String) As Boolean
        PUpdate = True
        Try
            If DoInsertAndUpdate(True) > 0 Then
                PUpdate = True
            Else
                PUpdate = False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Private Function DoInsertAndUpdate(ByVal IsEditFlag As Boolean) As Decimal
        Dim Id_debit_deposit_headVar As Decimal
        Dim Id_external_cashVar As Decimal
        If NumCashbackAmount.Text > 0 Then
            If CmbCashbackgoesto.Text.Trim.Length = 0 Then
                MsgBox("Please set the (Cash back goes to) Account")
                DoInsertAndUpdate = 0
                Exit Function
            End If
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim tran1 As SqlClient.SqlTransaction
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1

        Try

            If IsEditFlag Then
                CmdGeneral.CommandText = "DELETE FROM GL_debit_deposit_head WHERE id_debit_deposit_head = " & CmbBankDepositHead.SelectedValue
                CmdGeneral.ExecuteNonQuery()
                If DsFrmBankDeposits1.GL_debit_depositForEdit.Rows.Count > 0 Then
                    CmdGeneral.CommandText = "update GL_Paid_received Set Id_debit_deposit_head=0 Where Id_debit_deposit_head= " & CmbBankDepositHead.SelectedValue
                    CmdGeneral.ExecuteNonQuery()
                    CmdGeneral.CommandText = "update Gl_receive_payment Set Id_debit_deposit_head=0 Where Id_debit_deposit_head=" & CmbBankDepositHead.SelectedValue
                    CmdGeneral.ExecuteNonQuery()
                    Dim i As Integer
                    For i = 0 To DsFrmBankDeposits1.GL_debit_depositForEdit.Rows.Count - 1
                        Select Case DsFrmBankDeposits1.GL_debit_depositForEdit.Rows(i).Item("type_transaction")
                            Case 1
                                CmdGeneral.CommandText = "update GL_payment_deposit Set flag_deposit_bank=0 Where ID_payment=" & DsFrmBankDeposits1.GL_debit_depositForEdit.Rows(i).Item("Id_Payment")
                                CmdGeneral.ExecuteNonQuery()
                            Case 5
                                CmdGeneral.CommandText = "Delete From GL_External_Cash WHERE id_external_cash = " & DsFrmBankDeposits1.GL_debit_depositForEdit.Rows(i).Item("id_external_cash")
                                CmdGeneral.ExecuteNonQuery()
                        End Select
                    Next
                End If
            End If
            If DsFrmBankDeposits1.GL_debit_deposit.Rows.Count > 0 Then
                Dim i As Integer
                CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit_head " _
                                       & "(id_bank, date_doc, memo, cash_back_memo) VALUES " _
                                       & "(" & Qt(CmbBank.SelectedValue) & "," & Qt(DteDate_document.Text) & "," & Qt(TxtMemo.Text) & "," & Qt(TxtCashBackMemo.Text) & "); " _
                                       & " SELECT id_debit_deposit_head FROM GL_debit_deposit_head WHERE id_debit_deposit_head = @@IDENTITY"
                Id_debit_deposit_headVar = CmdGeneral.ExecuteScalar()
                For i = 0 To DsFrmBankDeposits1.GL_debit_deposit.Rows.Count - 1
                    With DsFrmBankDeposits1.GL_debit_deposit.Rows(i)
                        If Trim(.Item("cod_customer") & "").Length > 0 And Trim(.Item("payment_type") & "").Length > 0 Then
                            If .Item("FlagCanEdit") = 1 Then
                                CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                                       & "(id_debit_deposit_head,type_transaction, ID_payment, deposit_amount, GL_account,  memo) VALUES " _
                                                       & "(" & Id_debit_deposit_headVar & ",'1'," & .Item("Id_Payment") & "," & .Item("deposit_amount") & "," & Qt(Default_cash_overVar) & "," & Qt(.Item("Memo")) & ")"
                                CmdGeneral.ExecuteNonQuery()
                                CmdGeneral.CommandText = "update GL_payment_deposit Set flag_deposit_bank=1 Where ID_payment=" & .Item("Id_Payment")
                                CmdGeneral.ExecuteNonQuery()
                            Else
                                CmdGeneral.CommandText = "INSERT INTO GL_External_Cash " _
                                                       & "(cod_customer,memo, payment_type, cc_type, check_no) VALUES " _
                                                       & "(" & Qt(.Item("cod_customer")) & "," & Qt(.Item("Memo")) & "," & Qt(.Item("payment_type")) & "," & IIf(Trim(.Item("cc_type") & "").Length = 0, "Null", Qt(.Item("cc_type"))) & "," & Qt(.Item("check_no") & "") & "); " _
                                                       & " SELECT id_external_cash FROM GL_External_Cash WHERE id_external_cash = @@IDENTITY"
                                Id_external_cashVar = CmdGeneral.ExecuteScalar
                                CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                                       & "(id_debit_deposit_head,id_external_cash,type_transaction, deposit_amount, GL_account,  memo) VALUES " _
                                                       & "(" & Id_debit_deposit_headVar & "," & Id_external_cashVar & ",'5'," & .Item("deposit_amount") & "," & Qt(Default_cash_overVar) & "," & Qt(.Item("Memo") & "") & ")"
                                CmdGeneral.ExecuteNonQuery()
                            End If
                        End If
                    End With
                Next
                If CmbCashbackgoesto.Text.Trim.Length > 0 And NumCashbackAmount.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, debit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'3'," & NumCashbackAmount.Text & "," & Qt(CmbCashbackgoesto.SelectedValue) & "," & Qt(TxtCashBackMemo.Text) & ")"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblCashPaidOuts.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, debit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'8'," & LblCashPaidOuts.Text & "," & Qt(Default_cash_overVar) & ",'Cash Paid Outs')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblOtherReceiptsCash.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'9'," & LblOtherReceiptsCash.Text & "," & Qt(Default_cash_overVar) & ",'Other Receipts Cash')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblOtherReceiptsCheck.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'A'," & LblOtherReceiptsCheck.Text & "," & Qt(Default_cash_overVar) & ",'Other Receipts Check')"
                    CmdGeneral.ExecuteNonQuery()
                End If

                If LblPaymentForOtherStoreCash.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'B'," & LblPaymentForOtherStoreCash.Text & "," & Qt(Default_cash_overVar) & ",'Payment For Other Store - Cash')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblPaymentForOtherStoreCheck.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'C'," & LblPaymentForOtherStoreCheck.Text & "," & Qt(Default_cash_overVar) & ",'Payment For Other Store - Check')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblPaymentForOtherStoreCredit.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'D'," & LblPaymentForOtherStoreCredit.Text & "," & Qt(Default_cash_overVar) & ",'Payment For Other Store - Credit')"
                    CmdGeneral.ExecuteNonQuery()
                End If

                If LblOverPaymentCash.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'E'," & LblOverPaymentCash.Text & "," & Qt(Default_cash_overVar) & ",'Over Payment - Cash')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblOverPaymentCheck.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'F'," & LblOverPaymentCheck.Text & "," & Qt(Default_cash_overVar) & ",'Over Payment - Check')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblOverPaymentCredit.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'G'," & LblOverPaymentCredit.Text & "," & Qt(Default_cash_overVar) & ",'Over Payment - Credit')"
                    CmdGeneral.ExecuteNonQuery()
                End If

                If LblDownPaymentCash.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'H'," & LblDownPaymentCash.Text & "," & Qt(Default_cash_overVar) & ",'Down Payment - Cash')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblDownPaymentCheck.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'I'," & LblDownPaymentCheck.Text & "," & Qt(Default_cash_overVar) & ",'Down Payment - Check')"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If LblDownPaymentCredit.Text > 0 Then
                    CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                           & "(id_debit_deposit_head,type_transaction, deposit_amount, GL_account, Memo) VALUES " _
                                           & "(" & Id_debit_deposit_headVar & ",'J'," & LblDownPaymentCredit.Text & "," & Qt(Default_cash_overVar) & ",'Down Payment - Credit')"
                    CmdGeneral.ExecuteNonQuery()
                End If

                If CashPaidOut_OtherReceiptFlag Then
                    CmdGeneral.CommandText = "update GL_Paid_received Set Id_debit_deposit_head=" & Id_debit_deposit_headVar & " Where dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND Id_debit_deposit_head=0  AND id_service_center not in (SELECT     service_center_dtl.id_service_center FROM         service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center WHERE     (service_center_dtl.type_select = 'B') AND (service_center_head.type_of_form = 'WO'))"
                    CmdGeneral.ExecuteNonQuery()
                End If
                If CashPaidOut_OtherReceiptFlag Then
                    CmdGeneral.CommandText = "update Gl_receive_payment Set Id_debit_deposit_head=" & Id_debit_deposit_headVar & " Where dbo.ChangeDate(date_receive_payment)<= " & Qt(ChangeDateToYYYYMMDD(FilterDateVar)) & " AND Id_debit_deposit_head=0 "
                    CmdGeneral.ExecuteNonQuery()
                End If
            End If
            tran1.Commit()
            DoInsertAndUpdate = Id_debit_deposit_headVar
        Catch ex As Exception
            tran1.Rollback()
            DoInsertAndUpdate = 0
            MsgBox("Can't Save Information,Try Again")
        End Try
    End Function
    Friend Function FillFields(ByVal ThisId_debit_deposit_head As Decimal) As Boolean
        FillFields = False
        If ThisId_debit_deposit_head = 0 Then
            Exit Function
        End If
        LblDepositNo.Text = ThisId_debit_deposit_head
        Try
            MyFrmSelectPaymentstoDeposit.Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        MyFrmSelectPaymentstoDeposit.FillDataSet(ThisId_debit_deposit_head)
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from GL_debit_deposit where type_transaction='3' AND id_debit_deposit_head=" & ThisId_debit_deposit_head
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                CmbCashbackgoesto.SelectedValue = Trim(SQLReader.Item("Gl_account") & "")
                NumCashbackAmount.Text = SQLReader.Item("debit_amount")
                FillFields = True
            Else
                CmbCashbackgoesto.SelectedValue = 0
                NumCashbackAmount.Text = 0
            End If
            SQLReader.Close()
            CmdGeneral.CommandText = "SELECT * from GL_debit_deposit_head where id_debit_deposit_head=" & ThisId_debit_deposit_head
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                CmbBank.SelectedValue = Trim(SQLReader.Item("id_bank") & "")
                DteDate_document.Text = SQLReader.Item("date_doc") & ""
                FilterDateVar = DteDate_document.Text
                TxtMemo.Text = SQLReader.Item("memo") & ""
                TxtCashBackMemo.Text = SQLReader.Item("cash_back_memo") & ""
                FillFields = True
            Else
                CmbBank.SelectedValue = 0
                DteDate_document.Text = ""
                FilterDateVar = ""
                TxtMemo.Text = ""
                TxtCashBackMemo.Text = ""
            End If
            SQLReader.Close()
            Call FillGL_debit_deposit(ThisId_debit_deposit_head)
            BankDepositHeadTempVar = ThisId_debit_deposit_head
            Call SayTotals()
        Catch ex As Exception
            MsgBox("Error in loading data")
        End Try
        Try
            CmdGeneral.Connection.Close()
        Catch ex As Exception
        End Try
        Call FillTotals(ThisId_debit_deposit_head)
        AfterSaveOrCancel()
    End Function
    Private Sub FillGL_debit_deposit(ByVal ThisId_debit_deposit_head As Decimal)
        DsFrmBankDeposits1.GL_debit_deposit.Clear()
        DsFrmBankDeposits1.GL_debit_depositForEdit.Clear()
        DAGL_debit_deposit.SelectCommand.Parameters("@id_debit_deposit_head").Value = ThisId_debit_deposit_head
        DAGL_debit_deposit.Fill(DsFrmBankDeposits1, "GL_debit_deposit")
        DAGL_debit_deposit.Fill(DsFrmBankDeposits1, "GL_debit_depositForEdit")
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
    'Private Sub TxtRefrence_no_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) ha
    '    Try
    '        MyClsReceivePayment.Connection = Cnn
    '    Catch ex As Exception
    '    End Try
    '    If MyClsReceivePayment.FindDesc(TxtRefrence_no.Text) Then
    '        MsgBox("This Code Is Exist.Please Try With a New Code")
    '        TxtRefrence_no.Clear()
    '        TxtRefrence_no.Focus()
    '    End If
    'End Sub
    Private Sub SayTotals()
        If DsFrmBankDeposits1.GL_debit_deposit.Rows.Count > 0 Then
            LblDepositSubtotal.Text = DsFrmBankDeposits1.GL_debit_deposit.Compute("Sum(deposit_amount)", "")
        Else
            LblDepositSubtotal.Text = 0
        End If
    End Sub
    Private Sub BtnSelectPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectPayments.Click
        MyFrmSelectPaymentstoDeposit.FilterDate = DteDate_document.Text
        MyFrmSelectPaymentstoDeposit.StartPosition = FormStartPosition.CenterScreen
        MyFrmSelectPaymentstoDeposit.ShowDialog()
        CashPaidOut_OtherReceiptFlag = False
        If MyFrmSelectPaymentstoDeposit.FlagOK And MyFrmSelectPaymentstoDeposit.DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count > 0 Then
            FilterDateVar = MyFrmSelectPaymentstoDeposit.DtePaymentDate.Text
            DsFrmBankDeposits1.GL_debit_deposit.Clear()
            Dim i As Integer
            For i = 0 To MyFrmSelectPaymentstoDeposit.DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows.Count - 1
                Dim dr As DataRow, flg As Boolean
                If MyFrmSelectPaymentstoDeposit.DsFrmSelectPaymentstoDeposit1.GL_payment_deposit.Rows(i).Item("flag_deposit_bank") Then
                    dr = DsFrmBankDeposits1.GL_debit_deposit.NewRow
                    With MyFrmSelectPaymentstoDeposit.DsFrmSelectPaymentstoDeposit1.GL_payment_deposit
                        dr("ID_Payment") = .Rows(i).Item("ID_Payment")
                        dr("Cod_Customer") = .Rows(i).Item("Cod_Customer") & ""
                        dr("CustomerFullName") = .Rows(i).Item("CustomerFullName") & ""
                        dr("GL_account") = Default_cash_overVar
                        dr("deposit_amount") = .Rows(i).Item("payment_amount")
                        dr("check_no") = .Rows(i).Item("check_no") & ""
                        Select Case .Rows(i).Item("payment_type") & ""
                            Case 1
                                dr("payment_type") = "Cash"
                                CashPaidOut_OtherReceiptFlag = True
                            Case 2
                                dr("payment_type") = "Check"
                                CashPaidOut_OtherReceiptFlag = True
                            Case 3
                                dr("payment_type") = "Credit"
                            Case Else
                                dr("payment_type") = "  -  "
                                CashPaidOut_OtherReceiptFlag = True
                        End Select
                        dr("cc_type") = .Rows(i).Item("cc_type") & ""
                        dr("Refer_type") = .Rows(i).Item("Refer_type") & ""
                        dr("Payment_type") = .Rows(i).Item("Payment_type") & ""
                        dr("FlagCanEdit") = 1
                    End With
                    DsFrmBankDeposits1.GL_debit_deposit.Rows.Add(dr)
                End If
            Next
            Call FillTotals(0)
            Call SayTotals()
            Call AddEmptyRecordToGrid()
            Call SaveButtonControl()
        End If
    End Sub
    Private Sub NumCashbackAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumCashbackAmount.TextChanged, LblDepositSubtotal.TextChanged, LblCashPaidOuts.TextChanged, LblOtherReceiptsCash.TextChanged, LblOtherReceiptsCheck.TextChanged
        LblAvailableToDeposit.Text = LblDepositSubtotal.Numbervalue - LblCashPaidOuts.Numbervalue + LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue
        LblAvailableToDeposit.Text = LblAvailableToDeposit.Numbervalue + LblPaymentForOtherStoreCash.Numbervalue + LblPaymentForOtherStoreCheck.Numbervalue + LblPaymentForOtherStoreCredit.Numbervalue
        LblAvailableToDeposit.Text = LblAvailableToDeposit.Numbervalue + LblOverPaymentCash.Numbervalue + LblOverPaymentCheck.Numbervalue + LblOverPaymentCredit.Numbervalue
        LblAvailableToDeposit.Text = LblAvailableToDeposit.Numbervalue + LblDownPaymentCash.Numbervalue + LblDownPaymentCheck.Numbervalue + LblDownPaymentCredit.Numbervalue

        LblDepositTotal.Text = LblAvailableToDeposit.Numbervalue - NumCashbackAmount.Numbervalue
    End Sub
    Private Sub EnableDisableEditRow(ByVal ThisValue As String)
        Try
            If ThisValue = 1 Then
                GrdDetail.RootTable.AllowEdit = InheritableBoolean.False
                'GrdDetail.RootTable.Columns("CustomerFullName").Selectable = False
                'GrdDetail.RootTable.Columns("GL_account").Selectable = False
                'GrdDetail.RootTable.Columns("deposit_amount").Selectable = False
                'GrdDetail.RootTable.Columns("check_no").Selectable = False
                'GrdDetail.RootTable.Columns("payment_type").Selectable = False
                'GrdDetail.RootTable.Columns("cc_type").Selectable = False
            Else
                GrdDetail.RootTable.AllowEdit = InheritableBoolean.True
                'GrdDetail.RootTable.Columns("CustomerFullName").Selectable = True
                'GrdDetail.RootTable.Columns("GL_account").Selectable = True
                'GrdDetail.RootTable.Columns("deposit_amount").Selectable = True
                'GrdDetail.RootTable.Columns("check_no").Selectable = True
                'GrdDetail.RootTable.Columns("payment_type").Selectable = True
                'GrdDetail.RootTable.Columns("cc_type").Selectable = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Try
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            Call EnableDisableEditRow(CurrentRow.Cells("FlagCanEdit").Value)
            GrdDetail.UpdateData()
            Call SayTotals()
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
    '    GrdDetail.UpdateData()
    '    Call SayTotals()
    'End Sub
    Private Sub AddEmptyRecordToGrid()
        Dim IFirstCount As Integer = DsFrmBankDeposits1.GL_debit_deposit.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
            Call AddEmptyRecordToDetail()
        Next
    End Sub
    Private Sub AddEmptyRecordToDetail()
        Dim dr As DataRow
        dr = DsFrmBankDeposits1.GL_debit_deposit.NewRow
        'dr("ID_Payment") = 0
        'dr("Cod_Customer") = ""
        'dr("CustomerFullName") = ""
        dr("GL_account") = "0"
        dr("deposit_amount") = 0
        'dr("check_no") = ""
        dr("payment_type") = ""
        dr("cc_type") = 0
        dr("Refer_type") = 0
        dr("FlagCanEdit") = 0
        DsFrmBankDeposits1.GL_debit_deposit.Rows.Add(dr)
    End Sub
    Private Sub AddConditionalFormatting()
        'Imports Janus.Windows.GridEX is used in this module
        'adding a format condition to use font bold when OnSale field is true
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("FlagCanEdit"), ConditionOperator.Equal, 1)
        fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
        fc.FormatStyle.ForeColor = Color.Red
        GrdDetail.RootTable.FormatConditions.Add(fc)

        Call AddEmptyRecordToGrid()
    End Sub
    Private Sub DteDate_document_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteDate_document.Leave
        Call FillTotals(0)
    End Sub
    Private Function CheckifInformationWasChanged() As Boolean


        ' IN TIKE CHECK SHAVAD va mavarede jadid ejafeh shavad


        CheckifInformationWasChanged = False
        CmdGeneral.CommandText = "select Sum(amount) from GL_Paid_received Where (tran_type='1' OR tran_type='3') AND Id_debit_deposit_head=" & CmbBankDepositHead.SelectedValue
        Try
            If LblCashPaidOuts.Text <> CmdGeneral.ExecuteScalar() Then
                MsgBox("There are some Cash Paid Outs For This Day Or Before!")
                If LblCashPaidOuts.Text <> 0 Then
                    CheckifInformationWasChanged = True
                End If
                Exit Function
            End If
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "select  Sum(amount) from GL_Paid_received Where tran_type='2' AND Id_debit_deposit_head=" & CmbBankDepositHead.SelectedValue
        Try
            If LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue <> CmdGeneral.ExecuteScalar() Then
                MsgBox("There are some Other Receipts For This Day Or Before!")
                If LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue <> 0 Then
                    CheckifInformationWasChanged = True
                End If
                Exit Function
            End If
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "select Sum(amount) from GL_Paid_received Where dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(DteDate_document.Text)) & " AND (tran_type='1' OR tran_type='3') AND Id_debit_deposit_head=0"
        Try
            If LblCashPaidOuts.Text <> CmdGeneral.ExecuteScalar() Then
                MsgBox("There are some Cash Paid Outs For This Day Or Before!")
                If LblCashPaidOuts.Text <> 0 Then
                    CheckifInformationWasChanged = True
                End If
                Exit Function
            End If
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "select  Sum(amount) from GL_Paid_received Where dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(DteDate_document.Text)) & " AND tran_type='2' AND Id_debit_deposit_head=0"
        Try
            If LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue <> CmdGeneral.ExecuteScalar() Then
                MsgBox("There are some Other Receipts For This Day Or Before!")
                If LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue <> 0 Then
                    CheckifInformationWasChanged = True
                End If
                Exit Function
            End If
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "select  Sum(amount) from GL_Paid_received Where dbo.ChangeDate(action_date)<= " & Qt(ChangeDateToYYYYMMDD(DteDate_document.Text)) & " AND tran_type='2' AND Id_debit_deposit_head=0"
        Try
            If LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue <> CmdGeneral.ExecuteScalar() Then
                MsgBox("There are some Other Receipts For This Day Or Before!")
                If LblOtherReceiptsCash.Numbervalue + LblOtherReceiptsCheck.Numbervalue <> 0 Then
                    CheckifInformationWasChanged = True
                End If
                Exit Function
            End If
        Catch ex As Exception
        End Try

    End Function
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("priv")
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("print")
    End Sub
    Private Sub pprint(ByVal PrintType As String)
        If DsFrmBankDeposits1.GL_debit_deposit.Rows.Count = 0 Then
            Exit Sub
        Else
            Dim MablaghTemp As Double
            Dim i As Integer
            MablaghTemp = DsFrmBankDeposits1.GL_debit_deposit.Rows(0).Item("deposit_amount")
            For i = 0 To DsFrmBankDeposits1.GL_debit_deposit.Rows.Count - 1
                If i = DsFrmBankDeposits1.GL_debit_deposit.Rows.Count - 1 Then
                    DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("deposit_amountForPrint") = MablaghTemp
                Else
                    If Trim(DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("cod_customer") & "").Length > 0 And Trim(DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("check_no") & "").Length > 0 And (DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("check_no") & "") = (DsFrmBankDeposits1.GL_debit_deposit.Rows(i + 1).Item("check_no") & "") Then
                        MablaghTemp = MablaghTemp + DsFrmBankDeposits1.GL_debit_deposit.Rows(i + 1).Item("deposit_amount")
                        DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("deposit_amountForPrint") = 0
                    Else
                        DsFrmBankDeposits1.GL_debit_deposit.Rows(i).Item("deposit_amountForPrint") = MablaghTemp
                        MablaghTemp = DsFrmBankDeposits1.GL_debit_deposit.Rows(i + 1).Item("deposit_amount")
                    End If
                End If
            Next
        End If
        Dim rpt As New FrmRepBankDeposit
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

        MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
        MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
        rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

        rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from bas_banks where name_bank=" & Qt(CmbBank.Text)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()

                Dim Ziptemp As String = Trim(SQLReader.Item("Zip") & "")
                MyZipCode.ZipCode = Ziptemp

                rpt.SetParameterValue("Parbankname", CmbBank.Text)
                rpt.SetParameterValue("ParbankAddress", Trim(SQLReader.Item("Address") & ""))
                rpt.SetParameterValue("Parbankzip", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode)
                rpt.SetParameterValue("paracountno", Trim(SQLReader.Item("account_no") & ""))
            Else
                rpt.SetParameterValue("Parbankname", CmbBank.Text)
                rpt.SetParameterValue("ParbankAddress", "")
                rpt.SetParameterValue("Parbankzip", "")
                rpt.SetParameterValue("paracountno", "")
            End If
        Catch ex As Exception
            rpt.SetParameterValue("Parbankname", "")
            rpt.SetParameterValue("ParbankAddress", "")
            rpt.SetParameterValue("Parbankzip", "")
            rpt.SetParameterValue("paracountno", "")
        End Try
        Try
            SQLReader.Close()
            CmdGeneral.Connection.Close()
        Catch ex As Exception
        End Try


        rpt.SetParameterValue("ParamAvailableToDeposit", LblAvailableToDeposit.Text)
        rpt.SetParameterValue("ParamCashbackAmount", NumCashbackAmount.Text)
        rpt.SetParameterValue("ParamNetDeposit", LblDepositTotal.Text)
        rpt.SetParameterValue("Parkindrep", "Bank Deposit")
        rpt.SetParameterValue("pardepositdate", DteDate_document.Text)
        rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))
        rpt.SetParameterValue("pardepositno", CmbBankDepositHead.Text)

        rpt.SetDataSource(DsFrmBankDeposits1)
        Select Case PrintType
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try

            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
                'Case "fax"
                '    Try
                '        rpt.PrintOptions.PrinterName = "Fax"
                '        rpt.PrintToPrinter(1, True, 0, 0)
                '    Catch ex As Exception
                '        MsgBox("Add The FAX in (Printers and Faxes)")
                '    End Try
        End Select


    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmSearchBankDeposit = New FrmSearchBankDeposit
        MyFrmSearchBankDeposit.ShowDialog()
    End Sub
    Private Sub MyFrmSearchBankDeposit_BankDepositFind(ByVal ThisId_debit_deposit_head As Int64) Handles MyFrmSearchBankDeposit.BankDepositFind
        Try
            CmbBankDepositHead.SelectedValue = ThisId_debit_deposit_head
            Call FillFields(ThisId_debit_deposit_head)
        Catch ex As Exception
        End Try
    End Sub
End Class
