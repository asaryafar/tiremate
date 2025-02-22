Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmBankTransfer
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public Id_TransferForShow As Decimal = 0
    Friend Id_TransferTempVar As Decimal = 0
    Dim PnlSearchHeight As Integer
    Private CM As CurrencyManager
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents CnnTemp As System.Data.SqlClient.SqlConnection
    Friend WithEvents PnlKartAmvalField As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Command2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Command21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SortByType1 As Janus.Windows.UI.CommandBars.UICommand
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
    Friend WithEvents DsFrmBankTransfer1 As UCBankAccount.DSFrmBankTransfer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumAmount_transfer As CalcUtils.UcCalcText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbTransferFundsTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbTransferFundsFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TxtMemo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbDate_transfer As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_transfer_amount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents NumTransferFundsToAccountBalance As CalcUtils.UcCalcText
    Friend WithEvents NumTransferFundsFromAccountBalance As CalcUtils.UcCalcText
    Friend WithEvents DteDate_transfer As CalendarCombo.CalendarCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBankTransfer))
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
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.CmbDate_transfer = New System.Windows.Forms.ComboBox
        Me.DsFrmBankTransfer1 = New UCBankAccount.DSFrmBankTransfer
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.TxtMemo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DteDate_transfer = New CalendarCombo.CalendarCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.NumAmount_transfer = New CalcUtils.UcCalcText
        Me.NumTransferFundsToAccountBalance = New CalcUtils.UcCalcText
        Me.NumTransferFundsFromAccountBalance = New CalcUtils.UcCalcText
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbTransferFundsTo = New System.Windows.Forms.ComboBox
        Me.CmbTransferFundsFrom = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_transfer_amount = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmBankTransfer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.CmbDate_transfer)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(540, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'CmbDate_transfer
        '
        Me.CmbDate_transfer.DataSource = Me.DsFrmBankTransfer1.GL_transfer_amount
        Me.CmbDate_transfer.DisplayMember = "date_transfer"
        Me.CmbDate_transfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDate_transfer.Location = New System.Drawing.Point(53, 1)
        Me.CmbDate_transfer.Name = "CmbDate_transfer"
        Me.CmbDate_transfer.Size = New System.Drawing.Size(105, 21)
        Me.CmbDate_transfer.TabIndex = 189
        Me.CmbDate_transfer.ValueMember = "id_transfer"
        '
        'DsFrmBankTransfer1
        '
        Me.DsFrmBankTransfer1.DataSetName = "DSFrmBankTransfer"
        Me.DsFrmBankTransfer1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.TxtMemo)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(540, 246)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'TxtMemo
        '
        Me.TxtMemo.Location = New System.Drawing.Point(47, 219)
        Me.TxtMemo.MaxLength = 100
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.Size = New System.Drawing.Size(475, 21)
        Me.TxtMemo.TabIndex = 2
        Me.TxtMemo.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(4, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 21)
        Me.Label7.TabIndex = 364
        Me.Label7.Text = "Memo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DteDate_transfer)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NumAmount_transfer)
        Me.Panel1.Controls.Add(Me.NumTransferFundsToAccountBalance)
        Me.Panel1.Controls.Add(Me.NumTransferFundsFromAccountBalance)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CmbTransferFundsTo)
        Me.Panel1.Controls.Add(Me.CmbTransferFundsFrom)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(11, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 205)
        Me.Panel1.TabIndex = 1
        '
        'DteDate_transfer
        '
        Me.DteDate_transfer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_transfer.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_transfer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_transfer.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_transfer.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_transfer.EditableSal = True
        Me.DteDate_transfer.Image = CType(resources.GetObject("DteDate_transfer.Image"), System.Drawing.Image)
        Me.DteDate_transfer.Location = New System.Drawing.Point(47, 44)
        Me.DteDate_transfer.MaxValue = CType(2500, Short)
        Me.DteDate_transfer.MinValue = CType(1800, Short)
        Me.DteDate_transfer.Name = "DteDate_transfer"
        Me.DteDate_transfer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_transfer.Sal_Mali = Nothing
        Me.DteDate_transfer.ShowButton = True
        Me.DteDate_transfer.Size = New System.Drawing.Size(102, 23)
        Me.DteDate_transfer.TabIndex = 0
        Me.DteDate_transfer.VisualStyle = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(505, 23)
        Me.Label5.TabIndex = 372
        Me.Label5.Text = "Transfer Funds"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(299, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 371
        Me.Label3.Text = "Transfer Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumAmount_transfer
        '
        Me.NumAmount_transfer.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount_transfer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmount_transfer.DecimalDigits = 2
        Me.NumAmount_transfer.DefaultSendValue = False
        Me.NumAmount_transfer.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmount_transfer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumAmount_transfer.ForeColor = System.Drawing.Color.Black
        Me.NumAmount_transfer.Image = CType(resources.GetObject("NumAmount_transfer.Image"), System.Drawing.Image)
        Me.NumAmount_transfer.Location = New System.Drawing.Point(400, 172)
        Me.NumAmount_transfer.Maxlength = 10
        Me.NumAmount_transfer.MinusColor = System.Drawing.Color.Empty
        Me.NumAmount_transfer.Name = "NumAmount_transfer"
        Me.NumAmount_transfer.Size = New System.Drawing.Size(114, 22)
        Me.NumAmount_transfer.TabIndex = 3
        Me.NumAmount_transfer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmount_transfer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumTransferFundsToAccountBalance
        '
        Me.NumTransferFundsToAccountBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumTransferFundsToAccountBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumTransferFundsToAccountBalance.DecimalDigits = 2
        Me.NumTransferFundsToAccountBalance.DefaultSendValue = False
        Me.NumTransferFundsToAccountBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumTransferFundsToAccountBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumTransferFundsToAccountBalance.ForeColor = System.Drawing.Color.Red
        Me.NumTransferFundsToAccountBalance.Image = CType(resources.GetObject("NumTransferFundsToAccountBalance.Image"), System.Drawing.Image)
        Me.NumTransferFundsToAccountBalance.Location = New System.Drawing.Point(400, 135)
        Me.NumTransferFundsToAccountBalance.Maxlength = 10
        Me.NumTransferFundsToAccountBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumTransferFundsToAccountBalance.Name = "NumTransferFundsToAccountBalance"
        Me.NumTransferFundsToAccountBalance.ReadOnly = True
        Me.NumTransferFundsToAccountBalance.Size = New System.Drawing.Size(114, 21)
        Me.NumTransferFundsToAccountBalance.TabIndex = 368
        Me.NumTransferFundsToAccountBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumTransferFundsToAccountBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumTransferFundsFromAccountBalance
        '
        Me.NumTransferFundsFromAccountBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumTransferFundsFromAccountBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumTransferFundsFromAccountBalance.DecimalDigits = 2
        Me.NumTransferFundsFromAccountBalance.DefaultSendValue = False
        Me.NumTransferFundsFromAccountBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumTransferFundsFromAccountBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumTransferFundsFromAccountBalance.ForeColor = System.Drawing.Color.Black
        Me.NumTransferFundsFromAccountBalance.Image = CType(resources.GetObject("NumTransferFundsFromAccountBalance.Image"), System.Drawing.Image)
        Me.NumTransferFundsFromAccountBalance.Location = New System.Drawing.Point(400, 99)
        Me.NumTransferFundsFromAccountBalance.Maxlength = 10
        Me.NumTransferFundsFromAccountBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumTransferFundsFromAccountBalance.Name = "NumTransferFundsFromAccountBalance"
        Me.NumTransferFundsFromAccountBalance.ReadOnly = True
        Me.NumTransferFundsFromAccountBalance.Size = New System.Drawing.Size(114, 21)
        Me.NumTransferFundsFromAccountBalance.TabIndex = 366
        Me.NumTransferFundsFromAccountBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumTransferFundsFromAccountBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 365
        Me.Label1.Text = "Transfer Funds To"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbTransferFundsTo
        '
        Me.CmbTransferFundsTo.DataSource = Me.DsFrmBankTransfer1.bas_banks1
        Me.CmbTransferFundsTo.DisplayMember = "name_bank"
        Me.CmbTransferFundsTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTransferFundsTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbTransferFundsTo.ItemHeight = 13
        Me.CmbTransferFundsTo.Location = New System.Drawing.Point(114, 133)
        Me.CmbTransferFundsTo.Name = "CmbTransferFundsTo"
        Me.CmbTransferFundsTo.Size = New System.Drawing.Size(189, 21)
        Me.CmbTransferFundsTo.TabIndex = 2
        Me.CmbTransferFundsTo.ValueMember = "id_bank"
        '
        'CmbTransferFundsFrom
        '
        Me.CmbTransferFundsFrom.DataSource = Me.DsFrmBankTransfer1.bas_banks
        Me.CmbTransferFundsFrom.DisplayMember = "name_bank"
        Me.CmbTransferFundsFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTransferFundsFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbTransferFundsFrom.ItemHeight = 13
        Me.CmbTransferFundsFrom.Location = New System.Drawing.Point(114, 97)
        Me.CmbTransferFundsFrom.Name = "CmbTransferFundsFrom"
        Me.CmbTransferFundsFrom.Size = New System.Drawing.Size(189, 21)
        Me.CmbTransferFundsFrom.TabIndex = 1
        Me.CmbTransferFundsFrom.ValueMember = "id_bank"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(4, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 21)
        Me.Label13.TabIndex = 361
        Me.Label13.Text = "Date "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 363
        Me.Label6.Text = "Transfer Funds From"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(299, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Account Balance"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(299, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 367
        Me.Label8.Text = "Account Balance"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.CnnTemp
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
        Me.Panel9.Size = New System.Drawing.Size(540, 45)
        Me.Panel9.TabIndex = 143
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(470, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(424, 32)
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
        Me.BtnPrint.Location = New System.Drawing.Point(470, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 198
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(432, 3)
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_transfer, id_bank_from_transfer, id_bank_to_transfer, date_transfer, am" & _
        "ount_transfer FROM GL_transfer_amount"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_transfer_amount(id_bank_from_transfer, id_bank_to_transfer, date_t" & _
        "ransfer, amount_transfer) VALUES (@id_bank_from_transfer, @id_bank_to_transfer, " & _
        "@date_transfer, @amount_transfer); SELECT id_transfer, id_bank_from_transfer, id" & _
        "_bank_to_transfer, date_transfer, amount_transfer FROM GL_transfer_amount WHERE " & _
        "(id_transfer = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_from_transfer", System.Data.SqlDbType.Int, 4, "id_bank_from_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_to_transfer", System.Data.SqlDbType.Int, 4, "id_bank_to_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_transfer", System.Data.SqlDbType.VarChar, 10, "date_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_transfer", System.Data.SqlDbType.Money, 8, "amount_transfer"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_transfer_amount SET id_bank_from_transfer = @id_bank_from_transfer, id_" & _
        "bank_to_transfer = @id_bank_to_transfer, date_transfer = @date_transfer, amount_" & _
        "transfer = @amount_transfer WHERE (id_transfer = @Original_id_transfer) AND (amo" & _
        "unt_transfer = @Original_amount_transfer OR @Original_amount_transfer IS NULL AN" & _
        "D amount_transfer IS NULL) AND (date_transfer = @Original_date_transfer OR @Orig" & _
        "inal_date_transfer IS NULL AND date_transfer IS NULL) AND (id_bank_from_transfer" & _
        " = @Original_id_bank_from_transfer OR @Original_id_bank_from_transfer IS NULL AN" & _
        "D id_bank_from_transfer IS NULL) AND (id_bank_to_transfer = @Original_id_bank_to" & _
        "_transfer OR @Original_id_bank_to_transfer IS NULL AND id_bank_to_transfer IS NU" & _
        "LL); SELECT id_transfer, id_bank_from_transfer, id_bank_to_transfer, date_transf" & _
        "er, amount_transfer FROM GL_transfer_amount WHERE (id_transfer = @id_transfer)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_from_transfer", System.Data.SqlDbType.Int, 4, "id_bank_from_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank_to_transfer", System.Data.SqlDbType.Int, 4, "id_bank_to_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_transfer", System.Data.SqlDbType.VarChar, 10, "date_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_transfer", System.Data.SqlDbType.Money, 8, "amount_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_transfer", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_from_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_from_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_to_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_to_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_transfer", System.Data.SqlDbType.Int, 4, "id_transfer"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_transfer_amount WHERE (id_transfer = @Original_id_transfer) AND (a" & _
        "mount_transfer = @Original_amount_transfer OR @Original_amount_transfer IS NULL " & _
        "AND amount_transfer IS NULL) AND (date_transfer = @Original_date_transfer OR @Or" & _
        "iginal_date_transfer IS NULL AND date_transfer IS NULL) AND (id_bank_from_transf" & _
        "er = @Original_id_bank_from_transfer OR @Original_id_bank_from_transfer IS NULL " & _
        "AND id_bank_from_transfer IS NULL) AND (id_bank_to_transfer = @Original_id_bank_" & _
        "to_transfer OR @Original_id_bank_to_transfer IS NULL AND id_bank_to_transfer IS " & _
        "NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_transfer", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_from_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_from_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank_to_transfer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank_to_transfer", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_transfer_amount
        '
        Me.DAGL_transfer_amount.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_transfer_amount.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_transfer_amount.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_transfer_amount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_transfer_amount", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_bank_from_transfer", "id_bank_from_transfer"), New System.Data.Common.DataColumnMapping("id_bank_to_transfer", "id_bank_to_transfer"), New System.Data.Common.DataColumnMapping("date_transfer", "date_transfer"), New System.Data.Common.DataColumnMapping("amount_transfer", "amount_transfer")})})
        Me.DAGL_transfer_amount.UpdateCommand = Me.SqlUpdateCommand1
        '
        'FrmBankTransfer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(540, 318)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmBankTransfer"
        Me.Text = "Bank Transfer"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmBankTransfer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmReceivePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        Call FillDataSets()
        CM = CType(Me.BindingContext(DsFrmBankTransfer1.GL_transfer_amount), CurrencyManager)
        If Id_TransferForShow > 0 Then
            CmbDate_transfer.SelectedValue = Id_TransferForShow
        Else
            Call PFirstRecord(False)
            Try
                Call FillFields(CmbDate_transfer.SelectedValue)
            Catch ex As Exception
            End Try
        End If
        Call AfterSaveOrCancel()
        CmbDate_transfer.Focus()
    End Sub
    Private Sub FillDataSets()
        DsFrmBankTransfer1.GL_transfer_amount.Clear()
        DAGL_transfer_amount.Fill(DsFrmBankTransfer1, "GL_transfer_amount")

        DsFrmBankTransfer1.bas_banks.Clear()
        DAbas_banks.Fill(DsFrmBankTransfer1, "bas_banks")
        If DsFrmBankTransfer1.bas_banks.Rows.Count < 1 Then
            MsgFar("Please Fill The Bank Account Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmBankTransfer1.bas_banks1.Clear()
        DAbas_banks.Fill(DsFrmBankTransfer1, "bas_banks1")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        Id_TransferTempVar = CmbDate_transfer.SelectedValue
        Call ClearField()

        DteDate_transfer.Focus()

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
        Id_TransferTempVar = CmbDate_transfer.SelectedValue
        DteDate_transfer.Focus()

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
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PDelete()
        If Mid(CmbDate_transfer.Text, 1, 4).Trim.Length = 0 Then
            Exit Sub
        End If
        Dim IdGL_debit_deposit_headTemp As Decimal
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Dim Thisid_transfer As Decimal = CmbDate_transfer.SelectedValue
                CmdGeneral.CommandText = "Delete From GL_transfer_amount Where id_transfer=" & Thisid_transfer
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "Select id_debit_deposit_head FROM GL_debit_deposit WHERE debit_amount>0 AND id_transfer = " & Thisid_transfer
                IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
                CmdGeneral.CommandText = "Delete From GL_debit_deposit_head Where id_debit_deposit_head=" & IdGL_debit_deposit_headTemp
                IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
                CmdGeneral.CommandText = "Select id_debit_deposit_head FROM GL_debit_deposit WHERE deposit_amount>0 AND id_transfer = " & Thisid_transfer
                IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
                CmdGeneral.CommandText = "Delete From GL_debit_deposit_head Where id_debit_deposit_head=" & IdGL_debit_deposit_headTemp
                IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
                CmdGeneral.CommandText = "Delete From GL_debit_deposit Where id_transfer=" & Thisid_transfer
                IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
                Id_TransferTempVar = 0
                DsFrmBankTransfer1.GL_transfer_amount.Clear()
                DAGL_transfer_amount.Fill(DsFrmBankTransfer1, "GL_transfer_amount")
                Call PNextRecord(False)
                If Id_TransferTempVar = 0 Then
                    Call PPreviousRecord(False)
                    If Id_TransferTempVar = 0 Then
                        Call ClearField()
                    End If
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            End Try
            Call AfterSaveOrCancel()
        Else
            CmbDate_transfer.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                Id_TransferTempVar = PInsert()
                ChangeOK = IIf(Id_TransferTempVar = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(Id_TransferTempVar)
        End Select
        If ChangeOK Then
            DsFrmBankTransfer1.GL_transfer_amount.Clear()
            DAGL_transfer_amount.Fill(DsFrmBankTransfer1, "GL_transfer_amount")
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            CmbDate_transfer.SelectedValue = Id_TransferTempVar
            CmbDate_transfer.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbDate_transfer.SelectedValue = Id_TransferTempVar
        'Call FillFields(CmbGL_accountHead.Text)
        Call AfterSaveOrCancel()
        CmbDate_transfer.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If CmbDate_transfer.Text.Trim.Length = 0 Then
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
    Private Sub DteDate_transfer_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteDate_transfer.TextChanged, NumAmount_transfer.TextChanged, CmbDate_transfer.SelectedIndexChanged, TxtMemo.TextChanged, NumTransferFundsFromAccountBalance.TextChanged, NumTransferFundsToAccountBalance.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If NumAmount_transfer.Text > 0 And CmbTransferFundsFrom.Text.Trim.Length > 0 And CmbTransferFundsTo.Text.Trim.Length > 0 And Mid(DteDate_transfer.Text, 1, 4).Trim.Length > 0 Then
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
            Call FillFields(CmbDate_transfer.SelectedValue)
        End If
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CM.Position = CM.Position - 1
            Call FillFields(CmbDate_transfer.SelectedValue)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmBankTransfer1.GL_transfer_amount.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = CM.Position + 1
            Call FillFields(CmbDate_transfer.SelectedValue)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmBankTransfer1.GL_transfer_amount.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = DsFrmBankTransfer1.GL_transfer_amount.Rows.Count - 1
            Call FillFields(CmbDate_transfer.SelectedValue)
        End If
    End Sub
    Private Sub CmbDate_transfer_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDate_transfer.SelectionChangeCommitted
        Call FillFields(CmbDate_transfer.SelectedValue)
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
            CmbDate_transfer.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub PPrintMasterInformation()
        'If CmbGL_accountHead.Text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@refrence_no").Value = CmbGL_accountHead.Text
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
            'DteDate_transfer.Enabled = instatus
        Else
            'DteDate_transfer.Enabled = False
        End If
        DteDate_transfer.Enabled = instatus
        CmbTransferFundsFrom.Enabled = instatus
        CmbTransferFundsTo.Enabled = instatus
        TxtMemo.Enabled = instatus
        NumAmount_transfer.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        TxtMemo.Text = ""
        Try
            CmbTransferFundsFrom.SelectedValue = 0
            CmbTransferFundsTo.SelectedValue = 0
        Catch ex As Exception
        End Try
        NumAmount_transfer.Text = 0
        NumTransferFundsFromAccountBalance.Text = 0
        NumTransferFundsToAccountBalance.Text = 0
        DteDate_transfer.Text = Format(Now.Date, PubDateFormat)
    End Sub
    Friend Function PInsert() As Decimal
        Dim thisrow As DataRow
        PInsert = 0
        Dim IdGL_debit_deposit_headTemp As Decimal
        Dim Id_transferTemp As Decimal
        Dim GL_accountTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "INSERT INTO GL_transfer_amount " _
                                   & "(id_bank_from_transfer, id_bank_to_transfer, date_transfer, amount_transfer, Memo) " _
                                   & "VALUES (" & CmbTransferFundsFrom.SelectedValue & "," & CmbTransferFundsTo.SelectedValue & "," & Qt(DteDate_transfer.Text) & "," & NumAmount_transfer.Text & "," & Qt(TxtMemo.Text) & "); " _
                                   & "Select id_transfer FROM GL_transfer_amount WHERE (id_transfer = @@IDENTITY)"
            Id_transferTemp = CmdGeneral.ExecuteScalar()
            ' Bank From --- Debit
            CmdGeneral.CommandText = "Select GL_Account FROM bas_banks WHERE id_bank = " & CmbTransferFundsFrom.SelectedValue
            GL_accountTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit_head " _
                                   & "(id_bank, date_doc,Memo) " _
                                   & "VALUES (" & CmbTransferFundsFrom.SelectedValue & "," & Qt(DteDate_transfer.Text) & "," & Qt(TxtMemo.Text) & "); " _
                                   & "Select id_debit_deposit_head FROM GL_debit_deposit_head WHERE (id_debit_deposit_head = @@IDENTITY)"
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                   & "(id_debit_deposit_head,type_transaction,id_transfer,debit_amount,GL_account) " _
                                   & "VALUES (" & IdGL_debit_deposit_headTemp & ",'4'," & Id_transferTemp & "," & NumAmount_transfer.Text & "," & Qt(GL_accountTemp) & ")"
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            ' Bank To --- Deposit
            CmdGeneral.CommandText = "Select GL_Account FROM bas_banks WHERE id_bank = " & CmbTransferFundsTo.SelectedValue
            GL_accountTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit_head " _
                       & "(id_bank, date_doc,Memo) " _
                       & "VALUES (" & CmbTransferFundsTo.SelectedValue & "," & Qt(DteDate_transfer.Text) & "," & Qt(TxtMemo.Text) & "); " _
                       & "Select id_debit_deposit_head FROM GL_debit_deposit_head WHERE (id_debit_deposit_head = @@IDENTITY)"
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "INSERT INTO GL_debit_deposit " _
                                   & "(id_debit_deposit_head,type_transaction,id_transfer,deposit_amount,GL_account) " _
                                   & "VALUES (" & IdGL_debit_deposit_headTemp & ",'4'," & Id_transferTemp & "," & NumAmount_transfer.Text & "," & Qt(GL_accountTemp) & ")"
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            PInsert = Id_transferTemp
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = 0
        End Try
    End Function
    Friend Function PUpdate(ByVal Thisid_transfer As Decimal) As Boolean
        Dim GL_accountTemp As String
        Dim IdGL_debit_deposit_headTemp As Decimal
        PUpdate = True
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Update GL_transfer_amount Set " _
                                   & "id_bank_from_transfer=" & CmbTransferFundsFrom.SelectedValue & ", id_bank_to_transfer=" & CmbTransferFundsTo.SelectedValue & ", date_transfer=" & Qt(DteDate_transfer.Text) & ", amount_transfer=" & NumAmount_transfer.Text & ", Memo=" & Qt(TxtMemo.Text) & " Where id_transfer=" & Thisid_transfer
            CmdGeneral.ExecuteNonQuery()
            ' Bank From --- Debit
            CmdGeneral.CommandText = "Select GL_Account FROM bas_banks WHERE id_bank = " & CmbTransferFundsFrom.SelectedValue
            GL_accountTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "Select id_debit_deposit_head FROM GL_debit_deposit WHERE debit_amount>0 AND id_transfer = " & Thisid_transfer
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "Update GL_debit_deposit_head SET " _
                                   & " id_bank=" & CmbTransferFundsFrom.SelectedValue & ", date_doc =" & Qt(DteDate_transfer.Text) & ",Memo=" & Qt(TxtMemo.Text) & " " _
                                   & " Where id_debit_deposit_head=" & IdGL_debit_deposit_headTemp
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "Update GL_debit_deposit SET debit_amount=" & NumAmount_transfer.Text & " WHERE debit_amount>0 AND id_transfer = " & Thisid_transfer
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            ' Bank To --- Deposit
            CmdGeneral.CommandText = "Select GL_Account FROM bas_banks WHERE id_bank = " & CmbTransferFundsTo.SelectedValue
            GL_accountTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "Select id_debit_deposit_head FROM GL_debit_deposit WHERE deposit_amount>0 AND id_transfer = " & Thisid_transfer
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "Update GL_debit_deposit_head SET " _
                                   & " id_bank=" & CmbTransferFundsTo.SelectedValue & ", date_doc =" & Qt(DteDate_transfer.Text) & ",Memo=" & Qt(TxtMemo.Text) & " " _
                                   & " Where id_debit_deposit_head=" & IdGL_debit_deposit_headTemp
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = "Update GL_debit_deposit SET deposit_amount=" & NumAmount_transfer.Text & " WHERE deposit_amount>0 AND id_transfer = " & Thisid_transfer
            IdGL_debit_deposit_headTemp = CmdGeneral.ExecuteScalar()
            PUpdate = True
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal Thisid_transfer As String) As Boolean
        FillFields = False
        If Thisid_transfer = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from GL_transfer_amount where id_transfer=" & Thisid_transfer
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                CmbTransferFundsFrom.SelectedValue = SQLReader.Item("id_bank_from_transfer")
                CmbTransferFundsTo.SelectedValue = SQLReader.Item("id_bank_to_transfer")
                NumAmount_transfer.Text = SQLReader.Item("amount_transfer")
                TxtMemo.Text = SQLReader.Item("memo") & ""
                DteDate_transfer.Text = SQLReader.Item("Date_transfer") & ""
                FillFields = True
            Else
                Call ClearField()
            End If
            SQLReader.Close()
            Call TotalFundsFrom()
            Call TotalFundsTO()
        Catch ex As Exception
            MsgBox("Error in loading data")
        End Try
        Try
            CmdGeneral.Connection.Close()
        Catch ex As Exception
        End Try
    End Function
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
    Private Function SayAccountBalance(ByVal ThisAccountNo As String) As Double
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT sum(amount_transfer) as Sum_amount_transfer from GL_transfer_amount where id_transfer=" & ThisAccountNo
        SayAccountBalance = CmdGeneral.ExecuteScalar




    End Function
    Private Sub TotalFundsFrom()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim Thisid_transfer As Decimal = CmbDate_transfer.SelectedValue
        CmdGeneral.CommandText = "select sum(deposit_amount-debit_amount) FROM GL_debit_deposit INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head Where GL_debit_deposit_head.id_bank=" & CmbTransferFundsFrom.SelectedValue
        Try
            NumTransferFundsFromAccountBalance.Text = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            NumTransferFundsFromAccountBalance.Text = 0
        End Try
    End Sub
    Private Sub TotalFundsTO()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim Thisid_transfer As Decimal = CmbDate_transfer.SelectedValue
        CmdGeneral.CommandText = "select sum(deposit_amount-debit_amount) FROM GL_debit_deposit INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head Where GL_debit_deposit_head.id_bank=" & CmbTransferFundsTo.SelectedValue
        Try
            NumTransferFundsToAccountBalance.Text = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            NumTransferFundsToAccountBalance.Text = 0
        End Try
    End Sub
    Private Sub CmbTransferFundsFrom_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbTransferFundsFrom.Leave
        Call TotalFundsFrom()
    End Sub
    Private Sub CmbTransferFundsTo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbTransferFundsTo.Leave
        Call TotalFundsTO()
    End Sub
End Class
