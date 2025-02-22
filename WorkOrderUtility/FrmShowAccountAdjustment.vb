Imports Janus.Windows.GridEX
Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmShowAccountAdjustment
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim AccountAdjustmentOrderFieldName As String = "Refrence_No"
    Friend ReferenceNoTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public Refrence_NoVar As String = ""
    Dim Finance_Charge_flagVar As Boolean = False
    Dim flagupdateall As Boolean = False
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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents CnnTemp As System.Data.SqlClient.SqlConnection
    Friend WithEvents PnlKartAmvalField As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
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
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DsFrmAccountAdjustment1 As DSFrmAccountAdjustment
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaView_Total_Balance_ForEach_ARDue As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaView_Adjustment_Balance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdGeneraldeleteNoTransaction As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtCustomerCod As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmShowAccountAdjustment))
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
        Me.LblFinanceCharge = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtCustomerCod = New System.Windows.Forms.Label
        Me.LblBalance = New CalcUtils.UcCalcText
        Me.TxtRefrence_no = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NumAmount_adjustment = New CalcUtils.UcCalcText
        Me.TxtRemark = New System.Windows.Forms.TextBox
        Me.Dtedate_adjustment = New CalendarCombo.CalendarCombo
        Me.CmbGl_account = New System.Windows.Forms.ComboBox
        Me.DsFrmAccountAdjustment1 = New WorkOrderUtility.DSFrmAccountAdjustment
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
        Me.DAService_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaView_Total_Balance_ForEach_ARDue = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaView_Adjustment_Balance = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneraldeleteNoTransaction = New System.Data.SqlClient.SqlCommand
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
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'LblFinanceCharge
        '
        Me.LblFinanceCharge.BackColor = System.Drawing.Color.Transparent
        Me.LblFinanceCharge.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblFinanceCharge.ForeColor = System.Drawing.Color.Red
        Me.LblFinanceCharge.Location = New System.Drawing.Point(194, 2)
        Me.LblFinanceCharge.Name = "LblFinanceCharge"
        Me.LblFinanceCharge.Size = New System.Drawing.Size(124, 22)
        Me.LblFinanceCharge.TabIndex = 337
        Me.LblFinanceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.GrdDetail)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 0)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(603, 425)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtCustomerCod)
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
        Me.Panel1.Controls.Add(Me.LblFinanceCharge)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 100)
        Me.Panel1.TabIndex = 0
        '
        'TxtCustomerCod
        '
        Me.TxtCustomerCod.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCustomerCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerCod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerCod.Location = New System.Drawing.Point(74, 25)
        Me.TxtCustomerCod.Name = "TxtCustomerCod"
        Me.TxtCustomerCod.Size = New System.Drawing.Size(116, 22)
        Me.TxtCustomerCod.TabIndex = 453
        Me.TxtCustomerCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TxtRefrence_no.Location = New System.Drawing.Point(73, 3)
        Me.TxtRefrence_no.MaxLength = 8
        Me.TxtRefrence_no.Name = "TxtRefrence_no"
        Me.TxtRefrence_no.ReadOnly = True
        Me.TxtRefrence_no.Size = New System.Drawing.Size(117, 20)
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
        Me.NumAmount_adjustment.ReadOnly = True
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
        Me.TxtRemark.ReadOnly = True
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
        Me.Dtedate_adjustment.Enabled = False
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
        Me.CmbGl_account.Enabled = False
        Me.CmbGl_account.Location = New System.Drawing.Point(392, 2)
        Me.CmbGl_account.Name = "CmbGl_account"
        Me.CmbGl_account.Size = New System.Drawing.Size(199, 21)
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
        Me.Label17.Location = New System.Drawing.Point(322, 3)
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
        "ember><EditType>NoEdit</EditType><Key>Check</Key><Position>0</Position><Width>23" & _
        "</Width><CellStyle><BackColor>Info</BackColor></CellStyle></Column0><Column1 ID=" & _
        """Date""><Caption>Date</Caption><DataMember>InvoiceDate</DataMember><EditType>NoEd" & _
        "it</EditType><Key>Date</Key><Position>1</Position><Selectable>False</Selectable>" & _
        "<Width>95</Width></Column1><Column2 ID=""InvoiceNo""><Caption>Invoice No</Caption>" & _
        "<DataMember>InvoiceNo</DataMember><EditType>NoEdit</EditType><Key>InvoiceNo</Key" & _
        "><Position>2</Position><Selectable>False</Selectable><Width>104</Width></Column2" & _
        "><Column3 ID=""OriginalAmount""><Caption>Original Amount</Caption><DataMember>Orig" & _
        "inalAmount</DataMember><FormatString>c</FormatString><InputMask>Currency2</Input" & _
        "Mask><Key>OriginalAmount</Key><MaskPrompt>&#x0;</MaskPrompt><Position>3</Positio" & _
        "n><Selectable>False</Selectable><Width>120</Width></Column3><Column4 ID=""AmountD" & _
        "ue""><Caption>Amount Due</Caption><DataMember>AmountDue</DataMember><EditType>NoE" & _
        "dit</EditType><FormatString>c</FormatString><InputMask>Currency2</InputMask><Key" & _
        ">AmountDue</Key><MaskPrompt>&#x0;</MaskPrompt><Position>4</Position><Selectable>" & _
        "False</Selectable><Width>120</Width></Column4><Column5 ID=""Payment""><Caption>Adj" & _
        "ustment(+/-)</Caption><DataMember>Payment</DataMember><EditType>NoEdit</EditType" & _
        "><FormatString>c2</FormatString><InputMask>Currency2</InputMask><Key>Payment</Ke" & _
        "y><MaskPrompt>&#x0;</MaskPrompt><Position>5</Position><Width>120</Width><CellSty" & _
        "le><BackColor>Info</BackColor></CellStyle></Column5><Column6 ID=""ThisTableID""><C" & _
        "aption>ThisTableID</Caption><DataMember>ThisTableID</DataMember><EditType>NoEdit" & _
        "</EditType><Key>ThisTableID</Key><Position>6</Position><Visible>False</Visible><" & _
        "/Column6></Columns><GroupCondition ID="""" /><Key>Invoices</Key></RootTable></Grid" & _
        "EXLayoutData>"
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
        Me.GrdDetail.Size = New System.Drawing.Size(603, 325)
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
        'FrmShowAccountAdjustment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(603, 425)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Name = "FrmShowAccountAdjustment"
        Me.Text = "Account Adjustment"
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
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmAccountAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString

        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        Call FillDataSets()
        TxtRefrence_no.MaxLength = LenAccountAdjustmentReferenceNo

        Call FillFields(Refrence_NoVar)
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
                Else
                    LblFinanceCharge.Text = ""
                End If
                TxtRefrence_no.Text = Trim(SQLReader.Item("Refrence_No") & "")
                NumAmount_adjustment.Text = SQLReader.Item("amount_adjustment")
                TxtRemark.Text = Trim(SQLReader.Item("remark") & "")
                CmbGl_account.SelectedValue = Trim(SQLReader.Item("Gl_account") & "")
                Dtedate_adjustment.Text = Trim(SQLReader.Item("date_adjustment") & "")
                Dim CustomerCodVar As String = Trim(SQLReader.Item("cod_customer") & "")
                SQLReader.Close()

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT     cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.abbreviation_name FROM         cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company where cust_trtab_main.cod_customer=" & Qt(TxtCustomerCod.Text)
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    If Trim(SQLReader.Item("abbreviation_name") & "").Length > 0 Then
                        LblCustomerName.Text = SQLReader.Item("abbreviation_name") & ""
                    Else
                        LblCustomerName.Text = SQLReader.Item("f_name") & " " & SQLReader.Item("m_name") & " " & SQLReader.Item("l_name")
                    End If
                Else
                    LblCustomerName.Text = ""
                End If
                SQLReader.Close()

                TxtCustomerCod.Text = CustomerCodVar
                FillFields = True
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
    Private Sub FillGridInformation()
        DsFrmAccountAdjustment1.service_center_dtl.Clear()
        If TxtCustomerCod.Text.Trim.Length <> 0 Then
            DAService_center_dtl.SelectCommand.Parameters("@Cod_Customer").Value = TxtCustomerCod.Text
            DAService_center_dtl.Fill(DsFrmAccountAdjustment1, "service_center_dtl")
        End If

        Call FillAmountDue()
    End Sub
    Private Sub SetDataViewFilter(ByVal ThisFlag As Boolean)
        If ThisFlag Then
            DataView1.RowFilter = "Payment<>0"
        Else
            DataView1.RowFilter = "AmountDue<>0 OR Payment<>0"
        End If
    End Sub
    Private Sub FillAmountDue()

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
        End If
    End Sub
    Private Sub CalculateCreditRemaining()
        Try
            'LblBalance.Text = DsFrmAccountAdjustment1.service_center_dtl.Compute("Sum(AmountDue)", "AmountDue>0")
            CmdGeneral.CommandText = "SELECT BalanceAmount FROM  View_Customer_Balance Where COD_CUSTOMER =" & Qt(TxtCustomerCod.Text)
            LblBalance.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            LblBalance.Text = 0
        End Try
    End Sub
End Class
