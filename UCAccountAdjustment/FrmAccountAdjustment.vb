Imports Janus.Windows.GridEX
Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmAccountAdjustment
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim AccountAdjustmentOrderFieldName As String = "Refrence_No"
    Friend ReferenceNoTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public Refrence_NoVar As String = ""
    Dim MyClsAccountAdjustment As New ClsAccountAdjustment
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Dim Finance_Charge_flagVar As Boolean = False
    Dim flagupdateall As Boolean = False
    Dim FlagForTerekmooneFarajioooooooooooo As Boolean = True
    'Dim trans1 As SqlClient.SqlTransaction
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
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UIContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents TxtRemark As System.Windows.Forms.TextBox
    Friend WithEvents CmbGl_account As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Public WithEvents TxtRefrence_no As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort32 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
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
    Friend WithEvents DsFrmAccountAdjustment1 As UCAccountAdjustment.DSFrmAccountAdjustment
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents Reference_NoAA1 As UCAccountAdjustment.Reference_NoAA
    Friend WithEvents Dtedate_adjustment As CalendarCombo.CalendarCombo
    Friend WithEvents NumAmount_adjustment As CalcUtils.UcCalcText
    Friend WithEvents DAService_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LblBalance As CalcUtils.UcCalcText
    Friend WithEvents LblFinanceCharge As System.Windows.Forms.Label
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents CmdChg As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaView_Total_Balance_ForEach_ARDue As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaView_Adjustment_Balance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdGeneraldeleteNoTransaction As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdate As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAccountAdjustment))
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
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.CmdChg = New Janus.Windows.EditControls.UIButton
        Me.LblFinanceCharge = New System.Windows.Forms.Label
        Me.Reference_NoAA1 = New UCAccountAdjustment.Reference_NoAA
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.LblBalance = New CalcUtils.UcCalcText
        Me.TxtRefrence_no = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NumAmount_adjustment = New CalcUtils.UcCalcText
        Me.TxtRemark = New System.Windows.Forms.TextBox
        Me.Dtedate_adjustment = New CalendarCombo.CalendarCombo
        Me.CmbGl_account = New System.Windows.Forms.ComboBox
        Me.DsFrmAccountAdjustment1 = New UCAccountAdjustment.DSFrmAccountAdjustment
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
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
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel9 = New System.Windows.Forms.Panel
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
        Me.DAService_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaView_Total_Balance_ForEach_ARDue = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaView_Adjustment_Balance = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneraldeleteNoTransaction = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmAccountAdjustment1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_01;password=2191110"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.CmdChg)
        Me.PnlSearch.Controls.Add(Me.LblFinanceCharge)
        Me.PnlSearch.Controls.Add(Me.Reference_NoAA1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(603, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'CmdChg
        '
        Me.CmdChg.Location = New System.Drawing.Point(517, 0)
        Me.CmdChg.Name = "CmdChg"
        Me.CmdChg.Size = New System.Drawing.Size(76, 23)
        Me.CmdChg.TabIndex = 338
        Me.CmdChg.Text = "Change"
        Me.ToolTip1.SetToolTip(Me.CmdChg, "change finance charge amount to 0 or refetch  before amount")
        Me.CmdChg.Visible = False
        '
        'LblFinanceCharge
        '
        Me.LblFinanceCharge.BackColor = System.Drawing.Color.Transparent
        Me.LblFinanceCharge.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblFinanceCharge.ForeColor = System.Drawing.Color.Gold
        Me.LblFinanceCharge.Location = New System.Drawing.Point(304, 0)
        Me.LblFinanceCharge.Name = "LblFinanceCharge"
        Me.LblFinanceCharge.Size = New System.Drawing.Size(194, 22)
        Me.LblFinanceCharge.TabIndex = 337
        Me.LblFinanceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reference_NoAA1
        '
        Me.Reference_NoAA1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reference_NoAA1.Connection = Me.Cnn
        Me.Reference_NoAA1.Location = New System.Drawing.Point(79, 1)
        Me.Reference_NoAA1.Name = "Reference_NoAA1"
        Me.Reference_NoAA1.NotExitIfNotFound = False
        Me.Reference_NoAA1.ReferenceNoLen = 8
        Me.Reference_NoAA1.ReferencNo = ""
        Me.Reference_NoAA1.ReleaseIfNotFoundReferenceNo = False
        Me.Reference_NoAA1.Size = New System.Drawing.Size(101, 20)
        Me.Reference_NoAA1.TabIndex = 189
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
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_01;password=2191110"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.GrdDetail)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(603, 353)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CustomerCod1)
        Me.Panel1.Controls.Add(Me.LblBalance)
        Me.Panel1.Controls.Add(Me.TxtRefrence_no)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.NumAmount_adjustment)
        Me.Panel1.Controls.Add(Me.TxtRemark)
        Me.Panel1.Controls.Add(Me.Dtedate_adjustment)
        Me.Panel1.Controls.Add(Me.CmbGl_account)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblCustomerName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 100)
        Me.Panel1.TabIndex = 0
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Location = New System.Drawing.Point(73, 26)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(128, 21)
        Me.CustomerCod1.TabIndex = 1
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
        Me.LblBalance.Location = New System.Drawing.Point(427, 47)
        Me.LblBalance.Maxlength = 12
        Me.LblBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.ReadOnly = True
        Me.LblBalance.Size = New System.Drawing.Size(100, 21)
        Me.LblBalance.TabIndex = 452
        Me.LblBalance.TabStop = False
        Me.LblBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtRefrence_no
        '
        Me.TxtRefrence_no.Location = New System.Drawing.Point(73, 4)
        Me.TxtRefrence_no.MaxLength = 8
        Me.TxtRefrence_no.Name = "TxtRefrence_no"
        Me.TxtRefrence_no.Size = New System.Drawing.Size(93, 20)
        Me.TxtRefrence_no.TabIndex = 0
        Me.TxtRefrence_no.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(-19, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 21)
        Me.Label12.TabIndex = 342
        Me.Label12.Text = "Reference No."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumAmount_adjustment
        '
        Me.NumAmount_adjustment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount_adjustment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmount_adjustment.DecimalDigits = 2
        Me.NumAmount_adjustment.DefaultSendValue = False
        Me.NumAmount_adjustment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmount_adjustment.FireTabAfterEnter = True
        Me.NumAmount_adjustment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumAmount_adjustment.Image = CType(resources.GetObject("NumAmount_adjustment.Image"), System.Drawing.Image)
        Me.NumAmount_adjustment.Location = New System.Drawing.Point(73, 48)
        Me.NumAmount_adjustment.Maxlength = 10
        Me.NumAmount_adjustment.MinusColor = System.Drawing.Color.Empty
        Me.NumAmount_adjustment.Name = "NumAmount_adjustment"
        Me.NumAmount_adjustment.Size = New System.Drawing.Size(109, 22)
        Me.NumAmount_adjustment.TabIndex = 3
        Me.NumAmount_adjustment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmount_adjustment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        'Dtedate_adjustment
        '
        Me.Dtedate_adjustment.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtedate_adjustment.BorderColor = System.Drawing.Color.Empty
        Me.Dtedate_adjustment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtedate_adjustment.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtedate_adjustment.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtedate_adjustment.EditableSal = True
        Me.Dtedate_adjustment.Image = CType(resources.GetObject("Dtedate_adjustment.Image"), System.Drawing.Image)
        Me.Dtedate_adjustment.Location = New System.Drawing.Point(427, 70)
        Me.Dtedate_adjustment.MaxValue = CType(2500, Short)
        Me.Dtedate_adjustment.MinValue = CType(1800, Short)
        Me.Dtedate_adjustment.Name = "Dtedate_adjustment"
        Me.Dtedate_adjustment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtedate_adjustment.Sal_Mali = Nothing
        Me.Dtedate_adjustment.ShowButton = True
        Me.Dtedate_adjustment.Size = New System.Drawing.Size(102, 23)
        Me.Dtedate_adjustment.TabIndex = 5
        Me.Dtedate_adjustment.VisualStyle = False
        '
        'CmbGl_account
        '
        Me.CmbGl_account.DataSource = Me.DsFrmAccountAdjustment1.GL_account
        Me.CmbGl_account.DisplayMember = "desc_GL_account"
        Me.CmbGl_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGl_account.Location = New System.Drawing.Point(344, 2)
        Me.CmbGl_account.Name = "CmbGl_account"
        Me.CmbGl_account.Size = New System.Drawing.Size(247, 21)
        Me.CmbGl_account.TabIndex = 2
        Me.CmbGl_account.ValueMember = "GL_account"
        '
        'DsFrmAccountAdjustment1
        '
        Me.DsFrmAccountAdjustment1.DataSetName = "DSFrmAccountAdjustment"
        Me.DsFrmAccountAdjustment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(331, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 21)
        Me.Label13.TabIndex = 337
        Me.Label13.Text = "Date "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(331, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 22)
        Me.Label16.TabIndex = 336
        Me.Label16.Text = "Customer Balance"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(274, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 21)
        Me.Label17.TabIndex = 335
        Me.Label17.Text = " G/L Account  "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(0, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 331
        Me.Label5.Text = "Memo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-1, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 330
        Me.Label1.Text = "Adj. Amount"
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
        Me.LblCustomerName.Size = New System.Drawing.Size(344, 20)
        Me.LblCustomerName.TabIndex = 328
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(-3, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Customer"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Invoices</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Check""><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><" & _
        "EmptyStringValue /><ColumnType>CheckBox</ColumnType><DataMember>CheckFlag</DataM" & _
        "ember><EditType>CheckBox</EditType><Key>Check</Key><Position>0</Position><Width>" & _
        "23</Width><CellStyle><BackColor>Info</BackColor></CellStyle></Column0><Column1 I" & _
        "D=""Date""><Caption>Date</Caption><DataMember>InvoiceDate</DataMember><Key>Date</K" & _
        "ey><Position>1</Position><Selectable>False</Selectable><Width>95</Width></Column" & _
        "1><Column2 ID=""InvoiceNo""><Caption>Invoice No</Caption><DataMember>InvoiceNo</Da" & _
        "taMember><Key>InvoiceNo</Key><Position>2</Position><Selectable>False</Selectable" & _
        "><Width>104</Width></Column2><Column3 ID=""OriginalAmount""><Caption>Original Amou" & _
        "nt</Caption><DataMember>OriginalAmount</DataMember><FormatString>c</FormatString" & _
        "><InputMask>Currency2</InputMask><Key>OriginalAmount</Key><MaskPrompt>&#x0;</Mas" & _
        "kPrompt><Position>3</Position><Selectable>False</Selectable><Width>120</Width></" & _
        "Column3><Column4 ID=""AmountDue""><Caption>Amount Due</Caption><DataMember>AmountD" & _
        "ue</DataMember><FormatString>c</FormatString><InputMask>Currency2</InputMask><Ke" & _
        "y>AmountDue</Key><MaskPrompt>&#x0;</MaskPrompt><Position>4</Position><Selectable" & _
        ">False</Selectable><Width>120</Width></Column4><Column5 ID=""Payment""><Caption>Ad" & _
        "justment(+/-)</Caption><DataMember>Payment</DataMember><FormatString>c2</FormatS" & _
        "tring><InputMask>Currency2</InputMask><Key>Payment</Key><MaskPrompt>&#x0;</MaskP" & _
        "rompt><Position>5</Position><Width>120</Width><CellStyle><BackColor>Info</BackCo" & _
        "lor></CellStyle></Column5><Column6 ID=""ThisTableID""><Caption>ThisTableID</Captio" & _
        "n><DataMember>ThisTableID</DataMember><Key>ThisTableID</Key><Position>6</Positio" & _
        "n><Visible>False</Visible></Column6></Columns><GroupCondition ID="""" /><Key>Invoi" & _
        "ces</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 100)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(603, 253)
        Me.GrdDetail.TabIndex = 1
        '
        'DataView1
        '
        Me.DataView1.RowFilter = "AmountDue>0"
        Me.DataView1.Sort = "DateForSort,InvoiceNo"
        Me.DataView1.Table = Me.DsFrmAccountAdjustment1.service_center_dtl
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
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
        Me.Sort32.Text = "Order By A Customer Payements"
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
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Controls.Add(Me.Label30)
        Me.Panel9.Controls.Add(Me.Label29)
        Me.Panel9.Controls.Add(Me.Label28)
        Me.Panel9.Controls.Add(Me.BtnEmail)
        Me.Panel9.Controls.Add(Me.BtnFax)
        Me.Panel9.Controls.Add(Me.BtnPrint)
        Me.Panel9.Controls.Add(Me.BtnPreview)
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
        Me.Panel9.Size = New System.Drawing.Size(603, 45)
        Me.Panel9.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(566, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 10)
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
        'DAService_center_dtl
        '
        Me.DAService_center_dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DAService_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT service_center_head.id_service_center AS InvoiceNo, service_cente" & _
        "r_head.date_refer AS InvoiceDate, service_center_head.Total AS OriginalAmount, 0" & _
        " AS Payment, 0 AS CheckFlag, View_Invoice_Balance.BalanceAmount AS AmountDue, se" & _
        "rvice_center_head.Total - View_Invoice_Balance.BalanceAmount AS OldPayment, dbo." & _
        "ChangeDate(service_center_head.date_refer) AS DateForSort FROM service_center_he" & _
        "ad INNER JOIN View_Invoice_Balance ON service_center_head.id_service_center = Vi" & _
        "ew_Invoice_Balance.id_service_center LEFT OUTER JOIN GL_payment_deposit ON servi" & _
        "ce_center_head.id_service_center = GL_payment_deposit.id_service_center WHERE (s" & _
        "ervice_center_head.cod_customer = @Cod_customer) AND (service_center_head.type_o" & _
        "f_form = 'IN') ORDER BY DateForSort, InvoiceNo"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_service_center, ID_payment, BalanceAmount, AR_Adj_Amount, TotalArBalanc" & _
        "eAmount FROM View_Total_Balance_ForEach_ARDue WHERE (id_service_center = @id_ser" & _
        "vice_center) AND (TotalArBalanceAmount > 0)"
        Me.SqlSelectCommand1.Connection = Me.CnnTemp
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'DaView_Total_Balance_ForEach_ARDue
        '
        Me.DaView_Total_Balance_ForEach_ARDue.SelectCommand = Me.SqlSelectCommand1
        Me.DaView_Total_Balance_ForEach_ARDue.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_Total_Balance_ForEach_ARDue", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount"), New System.Data.Common.DataColumnMapping("AR_Adj_Amount", "AR_Adj_Amount"), New System.Data.Common.DataColumnMapping("TotalArBalanceAmount", "TotalArBalanceAmount")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT refrence_no_due, id_service_center_due, amount_adjustment, AR_Paid_amount," & _
        " Adj_Paid_Amount, BalanceAmount, IDGL_account_adjustment_dtl FROM View_Adjustmen" & _
        "t_Balance WHERE (id_service_center_due = @id_service_center_due) AND (BalanceAmo" & _
        "unt > 0)"
        Me.SqlSelectCommand5.Connection = Me.CnnTemp
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_due", System.Data.SqlDbType.VarChar, 10, "id_service_center_due"))
        '
        'DaView_Adjustment_Balance
        '
        Me.DaView_Adjustment_Balance.SelectCommand = Me.SqlSelectCommand5
        Me.DaView_Adjustment_Balance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_Adjustment_Balance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no_due", "refrence_no_due"), New System.Data.Common.DataColumnMapping("id_service_center_due", "id_service_center_due"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("AR_Paid_amount", "AR_Paid_amount"), New System.Data.Common.DataColumnMapping("Adj_Paid_Amount", "Adj_Paid_Amount"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount"), New System.Data.Common.DataColumnMapping("IDGL_account_adjustment_dtl", "IDGL_account_adjustment_dtl")})})
        '
        'CmdGeneraldeleteNoTransaction
        '
        Me.CmdGeneraldeleteNoTransaction.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO GL_account_adjustment_head (refrence_no, cod_customer, amount_adjustm" & _
        "ent, date_adjustment, GL_account, Remark) VALUES (@refrence_no, @cod_customer, @" & _
        "amount_adjustment, @date_adjustment, @GL_account, @remark)"
        Me.CmdInsert.Connection = Me.CnnTemp
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_adjustment", System.Data.SqlDbType.Money, 8, "amount_adjustment"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 100, "Remark"))
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM GL_account_adjustment_head WHERE (refrence_no = @refrence_no)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE GL_account_adjustment_head SET cod_customer = @cod_customer, amount_adjust" & _
        "ment = @amount_adjustment, date_adjustment = @date_adjustment, Remark = @Remark," & _
        " GL_account = @GL_account WHERE (refrence_no = @refrence_no)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_adjustment", System.Data.SqlDbType.Money, 8, "amount_adjustment"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remark", System.Data.SqlDbType.VarChar, 100, "Remark"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmAccountAdjustment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(603, 425)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmAccountAdjustment"
        Me.Text = "AA - Account Adjustment"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsFrmAccountAdjustment1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmAccountAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CustomerCod1.CanAddNewCod = False
        Reference_NoAA1.CanAddNewCod = False
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        MyClsAccountAdjustment.Connection = Cnn
        PnlSearchHeight = PnlSearch.Height

        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = " ALTER TABLE GL_account_adjustment_dtl_dtl ADD old_amount_adjustment money DEFAULT  0 "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " Update GL_account_adjustment_dtl_dtl set old_amount_adjustment=0 where old_amount_adjustment is null"
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Call FillDataSets()
        TxtRefrence_no.MaxLength = LenAccountAdjustmentReferenceNo

        If Refrence_NoVar.Trim.Length > 0 Then
            Call PAddNew()
            TxtRefrence_no.Text = Refrence_NoVar
            CustomerCod1.Focus()
        Else
            If ReferenceNoTempVar.Trim.Length = 0 Then
                Call PFirstRecord(False)
            Else
                Reference_NoAA1.Text = ReferenceNoTempVar
                'Call FillFields(Reference_NoAA1.Text)
            End If
            Call AfterSaveOrCancel()
            Reference_NoAA1.Focus()
        End If

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn
    End Sub
    Private Sub FillDataSets()
        DsFrmAccountAdjustment1.GL_account.Clear()
        DAGL_account.Fill(DsFrmAccountAdjustment1, "GL_account")
        If DsFrmAccountAdjustment1.GL_account.Rows.Count < 1 Then
            MsgFar("Please Fill The GL_account Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        ReferenceNoTempVar = Reference_NoAA1.Text
        Reference_NoAA1.Text = ""
        Call ClearField()

        TxtRefrence_no.Text = MakeNewReferenceNo()
        CustomerCod1.Focus()

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
    Friend Sub PEdit()
        If Finance_Charge_flagVar Then
            MsgBox("You can't change this information.")
            Exit Sub
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Gl_receive_payment_Refrence_no from GL_account_adjustment_head Where refrence_no=" & Qt(Reference_NoAA1.Text)
        Dim Tempvar As String
        Tempvar = CmdGeneral.ExecuteScalar() & ""
        If Tempvar.Trim.Length > 0 And flagupdateall = False Then
            MsgBox("This adjustment was created By system.(Discount For recieve payment : " & Tempvar & ")")
            Exit Sub
        End If
        If Not CanChangeOrEdit Then
            MsgBox("This adjustment was Passed by some payment or adjustment.")
            Exit Sub
        End If

        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True)
        ReferenceNoTempVar = Reference_NoAA1.Text
        CustomerCod1.Focus()

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
        If Finance_Charge_flagVar Then
            MsgBox("You can't delete this information.")
            Exit Sub
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Gl_receive_payment_Refrence_no from GL_account_adjustment_head Where refrence_no=" & Qt(Reference_NoAA1.Text)
        Dim Tempvar As String
        Tempvar = CmdGeneral.ExecuteScalar() & ""
        If Tempvar.Trim.Length > 0 Then
            MsgBox("This adjustment was created By system.(Discount For recieve payment : " & Tempvar & ")")
            Exit Sub
        End If

        If Not CanChangeOrEdit Then
            MsgBox("This adjustment was Passed by some payment or adjustment.")
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
                CmdDelete.Parameters("@refrence_no").Value = Reference_NoAA1.Text
                CmdDelete.ExecuteNonQuery()
                ReferenceNoTempVar = ""
                Call PNextRecord(False)
                If ReferenceNoTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If ReferenceNoTempVar.Trim.Length = 0 Then
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
            Reference_NoAA1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Friend Sub PSave()
        If Not CustomerCod1.ARCharge And FlagForTerekmooneFarajioooooooooooo Then
            MsgBox("This Option only available to AR Customers.")
            Exit Sub
        End If
        If NumAmount_adjustment.Numbervalue = 0 Then
            MsgBox("Please set the adjustment amount.")
            Exit Sub
        End If

        'If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
        '    Dim i As Integer
        '    For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
        '        If Dtedate_adjustment.Text < (DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("InvoiceDate") & "") Then
        '            MsgBox("Adjastment date should greater than invoice date.")
        '            Exit Sub
        '        End If
        '    Next
        'End If

        Dim SumOfAdjustmentVar As Decimal
        Dim SumOfPositiveAdjustmentVar As Decimal
        Dim SumOfNegativeAdjustmentVar As Decimal
        Try
            SumOfPositiveAdjustmentVar = Math.Round(DsFrmAccountAdjustment1.service_center_dtl.Compute("Sum(Payment)", "Payment>0 AND CheckFlag=1"), 2)
        Catch ex As Exception
            SumOfPositiveAdjustmentVar = 0
        End Try
        Try
            SumOfNegativeAdjustmentVar = Math.Round(DsFrmAccountAdjustment1.service_center_dtl.Compute("Sum(Payment)", "Payment<0 AND CheckFlag=1"), 2)
        Catch ex As Exception
            SumOfNegativeAdjustmentVar = 0
        End Try
        If SumOfNegativeAdjustmentVar <> 0 And SumOfPositiveAdjustmentVar <> 0 Then
            MsgBox("Please enter all adjustment positive or negative.")
            Exit Sub
        End If
        SumOfAdjustmentVar = SumOfNegativeAdjustmentVar + SumOfPositiveAdjustmentVar
        If NumAmount_adjustment.Numbervalue <> SumOfAdjustmentVar And flagupdateall = False Then
            MsgBox("Adjustment Amount should be equal to sum of adjustment Details.")
            Exit Sub
        End If

        'Dim tran1 As SqlClient.SqlTransaction
        'CmdGeneral.Connection = CnnTemp
        'CmdInsert.Connection = CnnTemp
        'CmdUpdate.Connection = CnnTemp
        'CmdDelete.Connection = CnnTemp
        'Try
        '    CnnTemp.Close()
        'Catch ex As Exception
        'End Try
        'CnnTemp.Open()
        'tran1 = CnnTemp.BeginTransaction()
        'CmdGeneral.Transaction = tran1
        'CmdInsert.Transaction = tran1
        'CmdUpdate.Transaction = tran1
        'CmdDelete.Transaction = trans1
        'DaView_Adjustment_Balance.SelectCommand.Connection = CnnTemp
        'DaView_Total_Balance_ForEach_ARDue.SelectCommand.Connection = CnnTemp
        'DaView_Adjustment_Balance.SelectCommand.Transaction = trans1
        'DaView_Total_Balance_ForEach_ARDue.SelectCommand.Transaction = trans1
        '---------------------------------------'
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                ReferenceNoTempVar = PInsert()
                If ReferenceNoTempVar = "" Then
                    ' tran1.Rollback()
                Else
                    ' tran1.Commit()
                End If
                ChangeOK = IIf(ReferenceNoTempVar.Trim.Length = 0, False, True)
                If Refrence_NoVar.Trim.Length > 0 Then
                    Refrence_NoVar = TxtRefrence_no.Text
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(ReferenceNoTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            Reference_NoAA1.Text = ReferenceNoTempVar
            Reference_NoAA1.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()
        If Reference_NoAA1.Text = ReferenceNoTempVar Then
            Call FillFields(Reference_NoAA1.Text)
        Else
            Reference_NoAA1.Text = ReferenceNoTempVar
        End If
        If Reference_NoAA1.Text.Trim.Length = 0 Then
            Call ClearField()
        End If
        Call AfterSaveOrCancel()
        Reference_NoAA1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtRefrence_no.Text.Trim.Length = 0 Then
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
    Private Sub TxtRefrence_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRefrence_no.TextChanged, TxtRemark.TextChanged, CmbGl_account.SelectedValueChanged, NumAmount_adjustment.TextChanged, Dtedate_adjustment.Leave
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtRefrence_no.Text.Trim.Length > 0 And CustomerCod1.CustomerCod.Trim.Length > 0 And NumAmount_adjustment.Text <> 0 And Mid(Dtedate_adjustment.Text, 1, 2).Trim.Length > 0 Then
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
        Dim TXTSearchReferenceNoTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head Order BY " & AccountAdjustmentOrderFieldName & " ASC"
            TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchReferenceNoTemp) Then
                TXTSearchReferenceNoTemp = ""
            End If
            If TXTSearchReferenceNoTemp = Reference_NoAA1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                Reference_NoAA1.Text = TXTSearchReferenceNoTemp
                'Call FillFields(Reference_NoAA1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case AccountAdjustmentOrderFieldName.ToUpper.Trim
            Case "Refrence_No".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head where Refrence_No<" & Qt(TxtRefrence_no.Text) & " Order BY " & AccountAdjustmentOrderFieldName & " DESC"
            Case "cod_customer".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head where cod_customer<" & Qt(CustomerCod1.CustomerCod) & " Order BY " & AccountAdjustmentOrderFieldName & " DESC"
            Case "cod_customer,Refrence_No".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head where cod_customer=" & Qt(CustomerCod1.CustomerCod) & " AND Refrence_No<" & Qt(TxtRefrence_no.Text) & " Order BY " & AccountAdjustmentOrderFieldName & " DESC"
        End Select
        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchReferenceNoTemp) Then
            TXTSearchReferenceNoTemp = ""
        End If
        If TXTSearchReferenceNoTemp = Reference_NoAA1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            Reference_NoAA1.Text = TXTSearchReferenceNoTemp
            ReferenceNoTempVar = TXTSearchReferenceNoTemp
            'Call FillFields(Reference_NoAA1.Text)
        End If
    End Sub
    Friend Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case AccountAdjustmentOrderFieldName.ToUpper.Trim
            Case "Refrence_No".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head where Refrence_No>" & Qt(TxtRefrence_no.Text) & " Order BY " & AccountAdjustmentOrderFieldName & " ASC"
            Case "cod_customer".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head where cod_customer>" & Qt(TxtRefrence_no.Text) & " Order BY " & AccountAdjustmentOrderFieldName & " ASC"
            Case "cod_customer,Refrence_No".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head where cod_customer=" & Qt(CustomerCod1.CustomerCod) & " AND Refrence_No>" & Qt(TxtRefrence_no.Text) & " Order BY " & AccountAdjustmentOrderFieldName & " ASC"
        End Select
        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchReferenceNoTemp) Then
            TXTSearchReferenceNoTemp = ""
        End If
        If TXTSearchReferenceNoTemp = Reference_NoAA1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            Reference_NoAA1.Text = TXTSearchReferenceNoTemp
            ReferenceNoTempVar = TXTSearchReferenceNoTemp
            'Call FillFields(Reference_NoAA1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Refrence_No from GL_account_adjustment_head Order BY " & AccountAdjustmentOrderFieldName & " DESC"
            TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchReferenceNoTemp) Then
                TXTSearchReferenceNoTemp = ""
            End If
            If TXTSearchReferenceNoTemp = Reference_NoAA1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                Reference_NoAA1.Text = TXTSearchReferenceNoTemp
                'Call FillFields(Reference_NoAA1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Reference_NoAA1_FindReferenceNo() Handles Reference_NoAA1.FindReferenceNo
        Call FillFields(Reference_NoAA1.Text)
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
        If flagupdateall Then
            Exit Sub
        End If
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
            Reference_NoAA1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmAccountAdjustment_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Reference_NoAA1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If Reference_NoAA1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@refrence_no").Value = Reference_NoAA1.text
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
            TxtRefrence_no.Enabled = instatus
        Else
            TxtRefrence_no.Enabled = False
        End If
        CustomerCod1.Enabled = instatus
        TxtRemark.Enabled = instatus
        CmbGl_account.Enabled = instatus
        NumAmount_adjustment.Enabled = instatus
        Dtedate_adjustment.Enabled = instatus
        If instatus Then
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        Else
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        End If
    End Sub
    Friend Sub ClearField()
        TxtRefrence_no.Text = ""
        TxtRemark.Text = ""

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveAccountsReceivableSetupTable()
        Try
            CmbGl_account.SelectedValue = OleDbReaderForStore.Item("Default_AR_GL_account") & ""
        Catch ex As Exception
        End Try
        NumAmount_adjustment.Text = "0"
        Dtedate_adjustment.Text = Format(Now.Date, PubDateFormat)
        CustomerCod1.CustomerCod = ""

        LblBalance.Text = 0
        LblCustomerName.Text = ""

        DsFrmAccountAdjustment1.service_center_dtl.Clear()
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            With CmdInsert
                If SetParametersForInsertAndUpdate(CmdInsert) Then
                    PInsert = TxtRefrence_no.Text
                    If Not SaveGL_account_adjustment_dtl() Then
                        PInsert = ""
                    End If
                End If
                '.Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisRefrence_No As String) As Boolean
        PUpdate = True
        Try
            With CmdUpdate
                'Call SetParametersForInsertAndUpdate(CmdUpdate)
                PUpdate = SetParametersForInsertAndUpdate(CmdUpdate)
                If PUpdate Then
                    PUpdate = SaveGL_account_adjustment_dtl()
                End If
                '.Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Private Function SetParametersForInsertAndUpdate(ByRef CmdParameter As SqlCommand) As Boolean
        With CmdParameter
            If .Connection.State <> ConnectionState.Open Then
                .Connection.Open()
            End If
            .Parameters("@refrence_no").Value = TxtRefrence_no.Text
            .Parameters("@cod_customer").Value = CustomerCod1.CustomerCod
            .Parameters("@amount_adjustment").Value = NumAmount_adjustment.Text
            .Parameters("@remark").Value = TxtRemark.Text
            .Parameters("@Gl_account").Value = CmbGl_account.SelectedValue
            .Parameters("@date_adjustment").Value = Dtedate_adjustment.Text
            Try
                .ExecuteNonQuery()
                SetParametersForInsertAndUpdate = True
            Catch ex As Exception
                SetParametersForInsertAndUpdate = False
            End Try

        End With
    End Function
    Friend Function FillFields(ByVal ThisRefrence_No As String) As Boolean
        FillFields = False
        If ThisRefrence_No.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from GL_account_adjustment_head where Refrence_No=" & Qt(ThisRefrence_No)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                Try
                    Finance_Charge_flagVar = SQLReader.Item("Finance_Charge_flag")
                Catch ex As Exception
                    Finance_Charge_flagVar = False
                End Try
                If Finance_Charge_flagVar Then
                    LblFinanceCharge.Text = "Finance Charge"
                    CmdChg.Visible = True
                Else
                    LblFinanceCharge.Text = ""
                    CmdChg.Visible = False
                End If
                TxtRefrence_no.Text = Trim(SQLReader.Item("Refrence_No") & "")
                NumAmount_adjustment.Text = SQLReader.Item("amount_adjustment")
                TxtRemark.Text = Trim(SQLReader.Item("remark") & "")
                CmbGl_account.SelectedValue = Trim(SQLReader.Item("Gl_account") & "")
                Dtedate_adjustment.Text = Trim(SQLReader.Item("date_adjustment") & "")
                Dim CustomerCodVar As String = Trim(SQLReader.Item("cod_customer") & "")
                SQLReader.Close()
                CustomerCod1.CustomerCod = CustomerCodVar
                FillFields = True
            Else
                Call ClearField()
                SQLReader.Close()
            End If
        Catch ex As Exception
            MsgBox("Error in loading data")
        End Try
        Try
            CmdGeneral.Connection.Close()
        Catch ex As Exception
        End Try
        Call FillGridInformation()
        Call SetDataViewFilter(Finance_Charge_flagVar)
        Call CalculateCreditRemaining()
    End Function
    Private Sub FillOtherFields()
        If TxtRefrence_no.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * from GL_account_adjustment_head where Refrence_No=" & TxtRefrence_no.Text '& " Order by "
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            'TXTLastPurchaseDate.Text = Trim(SQLReader.Item("current_mileage"))
        Else
            'LblLastPurchaseAmount.Text = ""
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
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UIContextMenu1.CommandClick
        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                AccountAdjustmentOrderFieldName = "Refrence_No"
            Case "SORT2"
                AccountAdjustmentOrderFieldName = "cod_customer"
            Case "SORT3"
                AccountAdjustmentOrderFieldName = "cod_customer,Refrence_No"
        End Select
    End Sub
    Private Sub TxtRefrence_no_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRefrence_no.LostFocus
        Try
            MyClsAccountAdjustment.Connection = Cnn
        Catch ex As Exception
        End Try
        If MyClsAccountAdjustment.FindDesc(TxtRefrence_no.Text) Then
            MsgBox("This Reference No already axist.Try a new Code")
            TxtRefrence_no.Clear()
            TxtRefrence_no.Focus()
        End If
    End Sub
    Private Function MakeNewReferenceNo() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(Refrence_No) as Max_cod from GL_account_adjustment_head WHERE substring(Refrence_No,1,2)='AA'"
            MakeNewReferenceNo = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewReferenceNo, LenAccountAdjustmentReferenceNo)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewReferenceNo.Length >= i Then
                MakeNewReferenceNo = Mid(MakeNewReferenceNo, 1, Len(MakeNewReferenceNo) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewReferenceNo.Trim.Length > LenAccountAdjustmentReferenceNo Then
                MakeNewReferenceNo = "AA000001"
            End If
        Catch ex As Exception
            MakeNewReferenceNo = "AA000001"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        LblCustomerName.Text = CustomerCod1.CustomerDesc
    End Sub
    Private Sub CustomerCod1_NotFindCustomerCod() Handles CustomerCod1.NotFindCustomerCod
        LblCustomerName.Text = ""
    End Sub
    Private Sub CustomerCod1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerCod1.Leave
        If (Status = MainModule.WorkStates.AddNew Or Status = MainModule.WorkStates.Edit) And Not CustomerCod1.ARCharge And FlagForTerekmooneFarajioooooooooooo And LblCustomerName.Text.Trim.Length > 0 Then
            MsgBox("This Option only available to AR Customers.")
        End If
        Call FillGridInformation()
        Call SetDataViewFilter(False)

        Call CalculateCreditRemaining()
    End Sub
    Private Sub FillGridInformation()
        DsFrmAccountAdjustment1.service_center_dtl.Clear()
        If CustomerCod1.CustomerCod.Trim.Length <> 0 Then
            DAService_center_dtl.SelectCommand.Parameters("@Cod_Customer").Value = CustomerCod1.CustomerCod
            DAService_center_dtl.SelectCommand.CommandTimeout = 30
            DAService_center_dtl.Fill(DsFrmAccountAdjustment1, "service_center_dtl")
        End If

        Call FillAmountDue()
        'DsFrmAccountAdjustment1.Tables("service_center_dtl").DefaultView.RowFilter = "AmountDue>0" 'FilterField & " like '*" & TxtSearch.Text.Trim & "*'"
        'DsFrmAccountAdjustment1.Tables("service_center_dtl").DefaultView.Sort = "DateForSort"
        'GrdDetail.DataSource = DsFrmAccountAdjustment1.Tables("service_center_dtl")
    End Sub
    Private Sub SetDataViewFilter(ByVal ThisFlag As Boolean)
        If ThisFlag Then
            DataView1.RowFilter = "Payment<>0"
        Else
            DataView1.RowFilter = "AmountDue<>0 OR Payment<>0"
        End If
    End Sub
    Private Sub FillAmountDue()
        '''If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
        '''    Dim i As Integer
        '''    For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
        '''        DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") = DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("OriginalAmount") - IIf(IsDBNull(DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("OldPayment")), 0, DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("OldPayment"))
        '''    Next
        '''End If

        If Status <> MainModule.WorkStates.AddNew Then
            If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
                Dim i As Integer
                Dim Amount_payTempVar As Double
                For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "Select amount_adjustment From GL_account_adjustment_dtl Where Refrence_no=" & Qt(TxtRefrence_no.Text) & " And id_service_center=" & Qt(DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("InvoiceNo"))
                    Try
                        Amount_payTempVar = CmdGeneral.ExecuteScalar()
                    Catch ex As Exception
                        Amount_payTempVar = 0
                    End Try
                    DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") = DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") - Amount_payTempVar
                    DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = Amount_payTempVar

                    If Amount_payTempVar = 0 Then
                        DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("CheckFlag") = False
                    Else
                        'If DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") <= Amount_ReceiveVar Then
                        '    DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue")
                        'Else
                        '    DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = Amount_ReceiveVar
                        'End If
                        'Amount_ReceiveVar = Amount_ReceiveVar - DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment")
                        DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("CheckFlag") = True
                    End If

                Next
            End If
        Else
            Call AutoApply()
        End If
    End Sub
    Private Sub BtnUnApplyPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                If DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") <> 0 Then
                    DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = 0
                    DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("CheckFlag") = False
                End If
            Next
        End If
    End Sub
    Private Sub BtnAutoApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call AutoApply()
    End Sub
    Private Sub AutoApply()
        If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
            Dim i As Integer
            Dim Amount_adjustmentVar As Decimal = NumAmount_adjustment.Text
            For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                If DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") <> 0 Or Not FlagForTerekmooneFarajioooooooooooo Then
                    If Amount_adjustmentVar = 0 Then
                        DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = 0
                        DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("CheckFlag") = False
                    Else
                        If Math.Abs(DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue")) <= Math.Abs(Amount_adjustmentVar) Then
                            'DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = Math.Sign(Amount_adjustmentVar) * DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") * (Amount_adjustmentVar / Amount_adjustmentVar)
                            DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = Math.Sign(Amount_adjustmentVar) * Math.Abs(DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue"))
                        Else
                            DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") = Amount_adjustmentVar
                        End If
                        Amount_adjustmentVar = Amount_adjustmentVar - (DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment"))
                        DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("CheckFlag") = True
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub BtnFindACustomerInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Find Service Record Grid")
    End Sub
    Private Function SaveGL_account_adjustment_dtl() As Boolean
        SaveGL_account_adjustment_dtl = True
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If

            If CmdGeneraldeleteNoTransaction.Connection.State <> ConnectionState.Open Then
                CmdGeneraldeleteNoTransaction.Connection.Open()
            End If

            CmdGeneraldeleteNoTransaction.CommandText = "Delete From GL_account_adjustment_dtl_Dtl Where refrence_no_due=" & Qt(TxtRefrence_no.Text)
            CmdGeneraldeleteNoTransaction.ExecuteNonQuery()

            CmdGeneraldeleteNoTransaction.CommandText = "Delete From GL_account_adjustment_dtl Where Refrence_no=" & Qt(TxtRefrence_no.Text)
            CmdGeneraldeleteNoTransaction.ExecuteNonQuery()
            If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
                Dim i As Integer
                For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                    If DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("AmountDue") <> 0 Or Not FlagForTerekmooneFarajioooooooooooo Then
                        If DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("CheckFlag") And DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") <> 0 Then
                            CmdGeneral.CommandText = "Insert Into GL_account_adjustment_dtl  (id_service_center,refrence_no,amount_adjustment) values (" & Qt(DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("InvoiceNo")) & "," & Qt(TxtRefrence_no.Text) & "," & DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Payment") & ")"
                            Try
                                CmdGeneral.ExecuteNonQuery()
                            Catch ex As Exception
                                SaveGL_account_adjustment_dtl = False
                            End Try

                        End If
                    End If
                Next
            End If
            If NumAmount_adjustment.Numbervalue > 0 Then
                If Not SaveGL_account_adjustment_dtl_DtlP() Then
                    SaveGL_account_adjustment_dtl = False
                End If
            Else
                If Not SaveGL_account_adjustment_dtl_DtlN() Then
                    SaveGL_account_adjustment_dtl = False
                End If
            End If
        Catch ex As Exception
            SaveGL_account_adjustment_dtl = False
        End Try
    End Function
    Private Sub CalculateCreditRemaining()
        Try
            'LblBalance.Text = DsFrmAccountAdjustment1.service_center_dtl.Compute("Sum(AmountDue)", "AmountDue>0")
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT BalanceAmount FROM  View_Customer_Balance Where COD_CUSTOMER =" & Qt(CustomerCod1.CustomerCod)
            LblBalance.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            LblBalance.Text = 0
        End Try
    End Sub
    Private Sub NumAmount_adjustment_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumAmount_adjustment.Leave
        Call AutoApply()
    End Sub
    Private Sub RdoCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call SaveButtonControl()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Reference_NoAA1.BtnSearch_Click(sender, e)
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        'GrdDetail.UpdateData()
        Call SaveButtonControl()
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("print")
    End Sub

    Private Sub BtnFax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFax.Click
        Call pprint("fax")
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("priv")
    End Sub
    Private Sub pprint(ByVal PrintType As String)
        If Status = MainModule.WorkStates.AddNew Or Status = MainModule.WorkStates.Edit Then
            MsgFar("Please Save Before Printing")
            Exit Sub
        End If
        If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
            For i As Integer = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                If DsFrmAccountAdjustment1.service_center_dtl(i).CheckFlag Then
                    Exit For
                Else
                    If i = DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1 Then
                        MsgBox("First check the row that you want to print.")
                        Exit Sub
                    End If
                End If
            Next
            Dim rpt As New RepAcountAdjusment
            Dim prn As New FrmRepView
            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

            Try
                If OleDbReaderForStore.Item("AccountAdjustmentsShading") = 0 Then
                    rpt.SetParameterValue("ShadingParam", True)
                Else
                    rpt.SetParameterValue("ShadingParam", False)
                End If
            Catch ex As Exception
                rpt.SetParameterValue("ShadingParam", False)
            End Try

            rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
            rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

            MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
            MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
            rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

            rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
            rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
            rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")
            rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

            DsFrmAccountAdjustment1.LOGO.Clear()
            Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
            OleDbReaderForCompany = RetrieveCompanySetupTable()
            Try
                DsFrmAccountAdjustment1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))
            MyZipCode.ZipCode = CustomerCod1.ZipCode
            MyZipCode.FindDesc(CustomerCod1.ZipCode)
            rpt.SetParameterValue("ParCusName", CustomerCod1.CustomerDesc)
            rpt.SetParameterValue("ParCusAddress", CustomerCod1.Address)
            rpt.SetParameterValue("Parcusaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
            rpt.SetParameterValue("ParCusPhone", CustomerCod1.CustomerPhone)
            rpt.SetParameterValue("Parkindrep", "Account Adjustment")
            rpt.SetParameterValue("parcusno", CustomerCod1.Text)
            rpt.SetParameterValue("pardate", Dtedate_adjustment.Text)
            rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))
            rpt.SetParameterValue("parno", TxtRefrence_no.Text)


            rpt.SetParameterValue("paradjamount", NumAmount_adjustment.Text)
            rpt.SetParameterValue("parpribalanse", LblBalance.Numbervalue - NumAmount_adjustment.Numbervalue)
            'rpt.SetParameterValue("parnewbalance", LblAmountDue.Text)
            rpt.SetParameterValue("parmemo", TxtRemark.Text)
            rpt.SetDataSource(DsFrmAccountAdjustment1)
            Select Case PrintType
                Case "print"
                    rpt.PrintToPrinter(1, True, 0, 0)
                Case "priv"
                    prn.CrViewer.ReportSource = rpt
                    prn.ShowDialog()
                Case "fax"
                    Try
                        rpt.PrintOptions.PrinterName = "Fax"
                        rpt.PrintToPrinter(1, True, 0, 0)
                    Catch ex As Exception
                        MsgBox("Add The FAX in (Printers and Faxes)")
                    End Try
            End Select
        End If

    End Sub
    Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        Dim ThisTableIDVar As Integer = CurrentRow.Cells("ThisTableID").Value
        Dim TotalAdjustmentVar As Decimal
        Select Case e.Column.Index
            Case 0
                If CurrentRow.Cells(0).Value = True Then
                    DsFrmAccountAdjustment1.service_center_dtl.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 0
                    CurrentRow.Cells(5).Value = 0
                Else
                    Try
                        TotalAdjustmentVar = Math.Round(DsFrmAccountAdjustment1.service_center_dtl.Compute("Sum(Payment)", "AmountDue>0 AND CheckFlag=1"), 2)
                    Catch ex As Exception
                        TotalAdjustmentVar = 0
                    End Try
                    DsFrmAccountAdjustment1.service_center_dtl.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 1
                    Dim adjustprice As Decimal = IIf(NumAmount_adjustment.Numbervalue - TotalAdjustmentVar <= CurrentRow.Cells(4).Value, NumAmount_adjustment.Numbervalue - TotalAdjustmentVar, CurrentRow.Cells(4).Value)
                    DsFrmAccountAdjustment1.service_center_dtl.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 1
                    CurrentRow.Cells(5).Value = IIf(Math.Abs(adjustprice) > Math.Abs(CurrentRow.Cells(4).Value), Math.Sign(NumAmount_adjustment.Numbervalue) * Math.Abs(CurrentRow.Cells(4).Value), adjustprice)
                    DsFrmAccountAdjustment1.service_center_dtl.Rows.Find(ThisTableIDVar).Item("Payment") = CurrentRow.Cells(5).Value
                End If
        End Select

    End Sub
    Private Sub CmdChg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdChg.Click
        If Finance_Charge_flagVar Then

            If Not CanChangeOrEdit() Then
                MsgBox("This adjustment was Passed by some payment or adjustment.")
                Exit Sub
            End If

            If NumAmount_adjustment.Numbervalue = 0 Then

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Try
                    CmdGeneral.CommandText = " Update GL_account_adjustment_head SET  Remark='Finance Charges' ,  amount_adjustment=old_amount_adjustment where refrence_no=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()

                    CmdGeneral.CommandText = " Update GL_account_adjustment_dtl set amount_adjustment=old_amount_adjustment where refrence_no=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()


                    CmdGeneral.CommandText = " Update GL_account_adjustment_dtl_dtl set amount_adjustment=old_amount_adjustment where refrence_no_due=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()

                    Dim TXTSearchReferenceNoTemp As String = Reference_NoAA1.Text
                    Reference_NoAA1.Text = ""
                    Reference_NoAA1.Text = TXTSearchReferenceNoTemp
                Catch ex As Exception

                End Try

            Else

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Try
                    CmdGeneral.CommandText = " Update GL_account_adjustment_head set   Remark='Finance Charges Waived', old_amount_adjustment = amount_adjustment where refrence_no=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()

                    CmdGeneral.CommandText = " Update GL_account_adjustment_dtl set old_amount_adjustment = amount_adjustment where refrence_no=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()


                    CmdGeneral.CommandText = " Update GL_account_adjustment_dtl_Dtl set old_amount_adjustment = amount_adjustment where refrence_no_due=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()


                    CmdGeneral.CommandText = " Update GL_account_adjustment_head set  amount_adjustment=0 where refrence_no=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()

                    CmdGeneral.CommandText = " Update GL_account_adjustment_dtl set  amount_adjustment=0 where refrence_no=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()


                    CmdGeneral.CommandText = " Update GL_account_adjustment_dtl_Dtl set  amount_adjustment=0 where refrence_no_due=" & Qt(Reference_NoAA1.Text)
                    CmdGeneral.ExecuteNonQuery()


                    Dim TXTSearchReferenceNoTemp As String = Reference_NoAA1.Text
                    Reference_NoAA1.Text = ""
                    Reference_NoAA1.Text = TXTSearchReferenceNoTemp
                Catch ex As Exception

                End Try



            End If

        End If
    End Sub
    Sub OkAdjustment()
        Dim i As Int64 = 0
        For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
            Try
                With DsFrmAccountAdjustment1.service_center_dtl.Rows(i)
                    If .Item("CheckFlag") = True Then
                        If Math.Abs(.Item("AmountDue")) < Math.Abs(.Item("Payment")) Then
                            .Item("Payment") = Math.Abs(.Item("AmountDue")) * Math.Sign(NumAmount_adjustment.Numbervalue)
                        End If
                    End If
                End With
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub GrdDetail_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellEdited
        'Call OkAdjustment()
        GrdDetail.Refresh()
    End Sub

    Private Sub GrdDetail_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.RecordUpdated
        Call OkAdjustment()
        GrdDetail.Refresh()
    End Sub
    'positive
    Private Function SaveGL_account_adjustment_dtl_DtlP() As Boolean
        SaveGL_account_adjustment_dtl_DtlP = True
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Dim _TopId As Decimal = 0
            If NumAmount_adjustment.Numbervalue > 0 Then
                If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
                    Dim i As Integer
                    For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                        With DsFrmAccountAdjustment1.service_center_dtl.Rows(i)
                            If .Item("AmountDue") <> 0 Or Not FlagForTerekmooneFarajioooooooooooo Then
                                If .Item("CheckFlag") And .Item("Payment") > 0 Then
                                    CmdGeneral.CommandText = "SELECT  top 1   ID_payment   FROM GL_payment_deposit   WHERE   (payment_type = '4') AND (refer_type = '1') AND (id_service_center= " & Qt(.Item("InvoiceNo")) & ")"
                                    Try
                                        _TopId = CmdGeneral.ExecuteScalar
                                        CmdGeneral.CommandText = "Insert Into GL_account_adjustment_dtl_dtl  (refrence_no_due,id_service_center_due,ID_payment,IDGL_account_adjustment_dtl_Due,amount_adjustment) values (" & _
                                                                            Qt(TxtRefrence_no.Text) & " , " & Qt(.Item("InvoiceNo")) & " , " & _TopId & ", null ," & .Item("Payment") & " )"
                                        CmdGeneral.ExecuteNonQuery()
                                    Catch ex As Exception
                                        SaveGL_account_adjustment_dtl_DtlP = False
                                    End Try

                                End If
                            End If
                        End With
                    Next
                End If
            End If
        Catch ex As Exception
            SaveGL_account_adjustment_dtl_DtlP = False
        End Try
    End Function
    'negativ
    Private Function SaveGL_account_adjustment_dtl_DtlN() As Boolean
        SaveGL_account_adjustment_dtl_DtlN = True
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Dim _TopId As Decimal = 0
            Dim Payment As Decimal = 0
            Dim DsNew As New DataSet
            Dim i As Integer, j As Integer, k As Integer
            If NumAmount_adjustment.Numbervalue < 0 Then
                If DsFrmAccountAdjustment1.service_center_dtl.Rows.Count > 0 Then
                    For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                        With DsFrmAccountAdjustment1.service_center_dtl.Rows(i)
                            If .Item("AmountDue") <> 0 Or Not FlagForTerekmooneFarajioooooooooooo Then
                                If .Item("CheckFlag") And .Item("Payment") < 0 Then
                                    Payment = .Item("Payment") ' is negative
                                    DaView_Adjustment_Balance.SelectCommand.Parameters("@id_service_center_due").Value = .Item("InvoiceNo")
                                    DaView_Adjustment_Balance.Fill(DsNew, "t1")
                                    DaView_Total_Balance_ForEach_ARDue.SelectCommand.Parameters("@id_service_center").Value = .Item("InvoiceNo")
                                    DaView_Total_Balance_ForEach_ARDue.Fill(DsNew, "t2")
                                    If DsNew.Tables("t1").Rows.Count > 0 Then
                                        Dim amount_adjustment As Decimal = 0
                                        For j = 0 To DsNew.Tables("t1").Rows.Count - 1 '»—Ì„ «œÃ«”„‰ «Ì „À» Ê »ŒÊ—Ì„
                                            If Payment < 0 Then
                                                Dim balanceamount As Decimal = DsNew.Tables("t1").Rows(j).Item("balanceamount")
                                                If Payment + balanceamount < 0 Then
                                                    amount_adjustment = -balanceamount
                                                    Payment = Payment + balanceamount
                                                Else
                                                    amount_adjustment = Payment
                                                    Payment = 0
                                                End If
                                                CmdGeneral.CommandText = "Insert Into GL_account_adjustment_dtl_dtl  (refrence_no_due,id_service_center_due,ID_payment,IDGL_account_adjustment_dtl_Due,amount_adjustment) values (" & _
                                                Qt(TxtRefrence_no.Text) & " , " & Qt(.Item("InvoiceNo")) & " , Null" & ", " & DsNew.Tables("t1").Rows(j).Item("IDGL_account_adjustment_dtl") & " ," & amount_adjustment & " )"
                                                Try
                                                    CmdGeneral.ExecuteNonQuery()
                                                Catch ex As Exception
                                                    SaveGL_account_adjustment_dtl_DtlN = False
                                                End Try

                                            End If
                                        Next
                                    End If
                                    'ar s

                                    If DsNew.Tables("t2").Rows.Count > 0 Then
                                        Dim amount_adjustment As Decimal = 0
                                        For j = 0 To DsNew.Tables("t2").Rows.Count - 1 '»—Ì„ «œÃ«”„‰ «Ì „À» Ê »ŒÊ—Ì„
                                            If Payment < 0 Then
                                                Dim balanceamount As Decimal = DsNew.Tables("t2").Rows(j).Item("TotalArBalanceAmount")
                                                If Payment + balanceamount < 0 Then
                                                    amount_adjustment = -balanceamount
                                                    Payment = Payment + balanceamount
                                                Else
                                                    amount_adjustment = Payment
                                                    Payment = 0
                                                End If
                                                CmdGeneral.CommandText = "Insert Into GL_account_adjustment_dtl_dtl  (refrence_no_due,id_service_center_due,ID_payment,IDGL_account_adjustment_dtl_Due,amount_adjustment) values (" & _
                                                Qt(TxtRefrence_no.Text) & " , " & Qt(.Item("InvoiceNo")) & "," & DsNew.Tables("t2").Rows(j).Item("Id_payment") & " , Null ," & amount_adjustment & " )"
                                                Try
                                                    CmdGeneral.ExecuteNonQuery()
                                                Catch ex As Exception
                                                    SaveGL_account_adjustment_dtl_DtlN = False
                                                End Try

                                            End If
                                        Next
                                    End If
                                    DsNew.Clear()
                                End If
                            End If
                        End With
                    Next
                End If
            End If
        Catch ex As Exception
            SaveGL_account_adjustment_dtl_DtlN = False
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call OkDtlDtl()
    End Sub
    Friend Sub OkDtlDtl()
        FlagForTerekmooneFarajioooooooooooo = False
        Me.SuspendLayout()
        Call PLastRecord()
        Dim Last As String = Reference_NoAA1.Text
        Call PFirstRecord()
        Dim first As String = Reference_NoAA1.Text
        Dim aa As String = first
        Do While True
            Finance_Charge_flagVar = False
            flagupdateall = True
            Call PEdit()
            Dim ii As Integer
            Dim Total As Decimal
            Try
                Total = Math.Round(DsFrmAccountAdjustment1.service_center_dtl.Compute("Sum(Payment)", "CheckFlag=1"), 2)
            Catch ex As Exception
                Total = 0
            End Try
            If Total <> NumAmount_adjustment.Numbervalue Then
                Call AutoApply()
            End If
            Call PSave()
            Call PNextRecord()
            If Last = Reference_NoAA1.Text Then
                Exit Do
            End If
        Loop
        Me.ResumeLayout()
        flagupdateall = False
        FlagForTerekmooneFarajioooooooooooo = True
    End Sub
    Private Function CanChangeOrEdit() As Boolean
        CanChangeOrEdit = True
        If NumAmount_adjustment.Numbervalue > 0 Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = " Select count(*) From GL_payment_deposit where refrence_no_Adjustment=" & Qt(Reference_NoAA1.Text)
            If CmdGeneral.ExecuteScalar() > 0 Then
                CanChangeOrEdit = False
            End If
            Dim i As Integer
            Dim TempIDGL_account_adjustment_dtl As Integer
            For i = 0 To DsFrmAccountAdjustment1.service_center_dtl.Rows.Count - 1
                CmdGeneral.CommandText = " Select isnull(IDGL_account_adjustment_dtl,0) From GL_account_adjustment_dtl_dtl where refrence_no_due=" & Qt(Reference_NoAA1.Text) & " AND id_service_center_due=" & Qt(DsFrmAccountAdjustment1.service_center_dtl.Rows(i).Item("Invoiceno"))
                TempIDGL_account_adjustment_dtl = CmdGeneral.ExecuteScalar
                CmdGeneral.CommandText = " Select Count(*) From GL_account_adjustment_dtl_dtl where IDGL_account_adjustment_dtl_Due=" & TempIDGL_account_adjustment_dtl
                If CmdGeneral.ExecuteScalar > 0 Then
                    CanChangeOrEdit = False
                    Exit For
                End If
            Next
        End If
    End Function
End Class
