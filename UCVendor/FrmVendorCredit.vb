Imports Janus.Windows.GridEX
Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmVendorCredit
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim ReceivePaymentOrderFieldName As String = "id_vendor_credit"
    Dim ReceivePaymentOrderVar1 As String = "id_vendor_credit"
    Dim ReceivePaymentOrderVar2 As String = ""
    Friend ReferenceNoTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public id_vendor_creditVar As String = ""
    Public id_vendor_creditForShowReadOnly As String = ""
    Dim MyClsReceivePayment As New ClsVendorReferenceNo
    Dim ID_paymentVar As Decimal
    Dim OldReferenceNo As String = ""
    Dim LenVendorBillReferenceNo As Integer = 10
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Command2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Command21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SortByType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UIContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
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
    Friend WithEvents Reference_NoVendorCredit1 As Reference_NoVendorCredit
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
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents PnlKartAmvalField As System.Windows.Forms.Panel
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents LblBalance As CalcUtils.UcCalcText
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents TxtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblVendorName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_vendor_credit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmVendorCredit1 As UCVendor.DSFrmVendorCredit
    Friend WithEvents NumAmount As CalcUtils.UcCalcText
    Friend WithEvents DteDate_Credit As CalendarCombo.CalendarCombo
    Public WithEvents Txtid_vendor_credit As System.Windows.Forms.TextBox
    Friend WithEvents BtnVendorBalance As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Dtedue_date As CalendarCombo.CalendarCombo
    Public WithEvents TxtRef_no As System.Windows.Forms.TextBox
    Friend WithEvents LblApplied As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVendorCredit))
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
        Me.Reference_NoVendorCredit1 = New UCVendor.Reference_NoVendorCredit
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
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
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.TxtRef_no = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Dtedue_date = New CalendarCombo.CalendarCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumAmount = New CalcUtils.UcCalcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.BtnVendorBalance = New System.Windows.Forms.Button
        Me.LblBalance = New CalcUtils.UcCalcText
        Me.Txtid_vendor_credit = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtRemark = New System.Windows.Forms.TextBox
        Me.DteDate_Credit = New CalendarCombo.CalendarCombo
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblVendorName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_vendor_credit = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmVendorCredit1 = New UCVendor.DSFrmVendorCredit
        Me.LblApplied = New System.Windows.Forms.Label
        Me.PnlSearch.SuspendLayout()
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlHead.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        CType(Me.DsFrmVendorCredit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.LblApplied)
        Me.PnlSearch.Controls.Add(Me.Reference_NoVendorCredit1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(610, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'Reference_NoVendorCredit1
        '
        Me.Reference_NoVendorCredit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reference_NoVendorCredit1.Connection = Me.Cnn
        Me.Reference_NoVendorCredit1.Location = New System.Drawing.Point(78, 1)
        Me.Reference_NoVendorCredit1.Name = "Reference_NoVendorCredit1"
        Me.Reference_NoVendorCredit1.NotExitIfNotFound = False
        Me.Reference_NoVendorCredit1.ReferenceNoLen = 6
        Me.Reference_NoVendorCredit1.ReferencNo = ""
        Me.Reference_NoVendorCredit1.ReleaseIfNotFoundReferenceNo = False
        Me.Reference_NoVendorCredit1.Size = New System.Drawing.Size(101, 20)
        Me.Reference_NoVendorCredit1.TabIndex = 189
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
        Me.Sort2.Text = "Order By Vendor Code"
        '
        'Sort32
        '
        Me.Sort32.Key = "Sort3"
        Me.Sort32.Name = "Sort32"
        Me.Sort32.Text = "Order By Enter Bill Date"
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
        Me.PnlHead.Size = New System.Drawing.Size(610, 45)
        Me.PnlHead.TabIndex = 143
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(567, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 10)
        Me.Label31.TabIndex = 204
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label31.Visible = False
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
        Me.Label30.Visible = False
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
        Me.Label29.Visible = False
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
        Me.Label28.Visible = False
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(567, 3)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 200
        Me.BtnEmail.Visible = False
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(532, 3)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 199
        Me.BtnFax.Visible = False
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(497, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 198
        Me.BtnPrint.Visible = False
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(462, 3)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 197
        Me.BtnPreview.Visible = False
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
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.TxtRef_no)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Controls.Add(Me.Dtedue_date)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.NumAmount)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.Vendor_Cod1)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnVendorBalance)
        Me.PnlKartAmvalField.Controls.Add(Me.LblBalance)
        Me.PnlKartAmvalField.Controls.Add(Me.Txtid_vendor_credit)
        Me.PnlKartAmvalField.Controls.Add(Me.Label12)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtRemark)
        Me.PnlKartAmvalField.Controls.Add(Me.DteDate_Credit)
        Me.PnlKartAmvalField.Controls.Add(Me.Label13)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.LblVendorName)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.ForeColor = System.Drawing.Color.Black
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(610, 197)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'TxtRef_no
        '
        Me.TxtRef_no.Location = New System.Drawing.Point(90, 60)
        Me.TxtRef_no.MaxLength = 20
        Me.TxtRef_no.Name = "TxtRef_no"
        Me.TxtRef_no.Size = New System.Drawing.Size(184, 21)
        Me.TxtRef_no.TabIndex = 2
        Me.TxtRef_no.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(7, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 469
        Me.Label6.Text = "Vendor Ref."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dtedue_date
        '
        Me.Dtedue_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtedue_date.BorderColor = System.Drawing.Color.Empty
        Me.Dtedue_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtedue_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtedue_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtedue_date.EditableSal = True
        Me.Dtedue_date.Image = CType(resources.GetObject("Dtedue_date.Image"), System.Drawing.Image)
        Me.Dtedue_date.Location = New System.Drawing.Point(89, 85)
        Me.Dtedue_date.MaxValue = CType(2500, Short)
        Me.Dtedue_date.MinValue = CType(1800, Short)
        Me.Dtedue_date.Name = "Dtedue_date"
        Me.Dtedue_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtedue_date.Sal_Mali = Nothing
        Me.Dtedue_date.ShowButton = True
        Me.Dtedue_date.Size = New System.Drawing.Size(102, 23)
        Me.Dtedue_date.TabIndex = 3
        Me.Dtedue_date.VisualStyle = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(25, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 21)
        Me.Label1.TabIndex = 467
        Me.Label1.Text = "Due Date "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumAmount
        '
        Me.NumAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumAmount.DecimalDigits = 2
        Me.NumAmount.DefaultSendValue = False
        Me.NumAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmount.FireTabAfterEnter = True
        Me.NumAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NumAmount.Image = CType(resources.GetObject("NumAmount.Image"), System.Drawing.Image)
        Me.NumAmount.Location = New System.Drawing.Point(89, 111)
        Me.NumAmount.Maxlength = 10
        Me.NumAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumAmount.Name = "NumAmount"
        Me.NumAmount.Size = New System.Drawing.Size(120, 22)
        Me.NumAmount.TabIndex = 4
        Me.NumAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-3, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 465
        Me.Label3.Text = "Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(89, 7)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Vendor_Cod1.TabIndex = 0
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'BtnVendorBalance
        '
        Me.BtnVendorBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnVendorBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnVendorBalance.Location = New System.Drawing.Point(420, 32)
        Me.BtnVendorBalance.Name = "BtnVendorBalance"
        Me.BtnVendorBalance.Size = New System.Drawing.Size(88, 21)
        Me.BtnVendorBalance.TabIndex = 6
        Me.BtnVendorBalance.TabStop = False
        Me.BtnVendorBalance.Text = "Balance"
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
        Me.LblBalance.Location = New System.Drawing.Point(511, 32)
        Me.LblBalance.Maxlength = 12
        Me.LblBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.ReadOnly = True
        Me.LblBalance.Size = New System.Drawing.Size(89, 21)
        Me.LblBalance.TabIndex = 6
        Me.LblBalance.TabStop = False
        Me.LblBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Txtid_vendor_credit
        '
        Me.Txtid_vendor_credit.Location = New System.Drawing.Point(304, 33)
        Me.Txtid_vendor_credit.MaxLength = 6
        Me.Txtid_vendor_credit.Name = "Txtid_vendor_credit"
        Me.Txtid_vendor_credit.ReadOnly = True
        Me.Txtid_vendor_credit.Size = New System.Drawing.Size(104, 21)
        Me.Txtid_vendor_credit.TabIndex = 0
        Me.Txtid_vendor_credit.TabStop = False
        Me.Txtid_vendor_credit.Text = ""
        Me.Txtid_vendor_credit.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(211, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 21)
        Me.Label12.TabIndex = 463
        Me.Label12.Text = "Reference No."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(88, 137)
        Me.TxtRemark.MaxLength = 100
        Me.TxtRemark.Multiline = True
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(514, 55)
        Me.TxtRemark.TabIndex = 5
        Me.TxtRemark.Text = ""
        '
        'DteDate_Credit
        '
        Me.DteDate_Credit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_Credit.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_Credit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_Credit.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_Credit.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_Credit.EditableSal = True
        Me.DteDate_Credit.Image = CType(resources.GetObject("DteDate_Credit.Image"), System.Drawing.Image)
        Me.DteDate_Credit.Location = New System.Drawing.Point(89, 31)
        Me.DteDate_Credit.MaxValue = CType(2500, Short)
        Me.DteDate_Credit.MinValue = CType(1800, Short)
        Me.DteDate_Credit.Name = "DteDate_Credit"
        Me.DteDate_Credit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_Credit.Sal_Mali = Nothing
        Me.DteDate_Credit.ShowButton = True
        Me.DteDate_Credit.Size = New System.Drawing.Size(102, 23)
        Me.DteDate_Credit.TabIndex = 1
        Me.DteDate_Credit.VisualStyle = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(44, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 21)
        Me.Label13.TabIndex = 462
        Me.Label13.Text = "Date "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(11, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 461
        Me.Label5.Text = "Memo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblVendorName
        '
        Me.LblVendorName.BackColor = System.Drawing.Color.Gold
        Me.LblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVendorName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblVendorName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblVendorName.Location = New System.Drawing.Point(235, 7)
        Me.LblVendorName.Name = "LblVendorName"
        Me.LblVendorName.Size = New System.Drawing.Size(369, 20)
        Me.LblVendorName.TabIndex = 459
        Me.LblVendorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(11, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 458
        Me.Label7.Text = "Vendor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(199, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 22)
        Me.Label2.TabIndex = 460
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_vendor_credit, cod_vendor, date_credit, amount_credit, Remark, ref_no, " & _
        "due_date, GL_vendor_credit, id_receive_ref FROM GL_vendor_credit"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_vendor_credit
        '
        Me.DAGL_vendor_credit.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_vendor_credit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_vendor_credit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vendor_credit", "id_vendor_credit"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("date_credit", "date_credit"), New System.Data.Common.DataColumnMapping("amount_credit", "amount_credit"), New System.Data.Common.DataColumnMapping("Remark", "Remark")})})
        '
        'DsFrmVendorCredit1
        '
        Me.DsFrmVendorCredit1.DataSetName = "DSFrmVendorCredit"
        Me.DsFrmVendorCredit1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'LblApplied
        '
        Me.LblApplied.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblApplied.ForeColor = System.Drawing.Color.Red
        Me.LblApplied.Location = New System.Drawing.Point(372, 0)
        Me.LblApplied.Name = "LblApplied"
        Me.LblApplied.Size = New System.Drawing.Size(177, 23)
        Me.LblApplied.TabIndex = 190
        Me.LblApplied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmVendorCredit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(610, 269)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.PnlHead)
        Me.Name = "FrmVendorCredit"
        Me.Text = "Vendor Credit"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.UIContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlHead.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        CType(Me.DsFrmVendorCredit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmReceivePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Vendor_Cod1.CanAddNewCod = False
        Reference_NoVendorCredit1.CanAddNewCod = False
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        Me.CnnForReader.ConnectionString = PConnectionString

        MyClsReceivePayment.Connection = Cnn
        PnlSearchHeight = PnlSearch.Height


        Dtedate_credit.Text = Format(Now.Date, PubDateFormat)

        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        Call FillDataSets()
        Txtid_vendor_credit.MaxLength = LenVendorBillReferenceNo

        If id_vendor_creditVar.Trim.Length > 0 Then
            Call PAddNew()
            Txtid_vendor_credit.Text = id_vendor_creditVar
            Vendor_Cod1.Focus()
        Else
            If id_vendor_creditForShowReadOnly.Trim.Length = 0 Then
                Call PFirstRecord(False)
            Else
                Reference_NoVendorCredit1.Text = id_vendor_creditForShowReadOnly
                PnlHead.Enabled = False
                PnlSearch.Enabled = False
                PnlHead.Height = 0
                PnlSearch.Height = 0
                'Call FillFields(Reference_NoVendorCredit1.Text)
            End If
            Call AfterSaveOrCancel()
            Reference_NoVendorCredit1.Focus()
        End If
    End Sub
    Private Sub FillDataSets()
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        ReferenceNoTempVar = Reference_NoVendorCredit1.Text
        Reference_NoVendorCredit1.Text = ""
        Call ClearField()

        Txtid_vendor_credit.Text = MakeNewReferenceNo()
        OldReferenceNo = Txtid_vendor_credit.Text
        Vendor_Cod1.Focus()

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
        Dim CanChangeHeadFlag As Boolean = True
        If CanChangeOrDelete(False) = False Then
            Exit Sub
        End If

        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True, CanChangeHeadFlag)
        ReferenceNoTempVar = Reference_NoVendorCredit1.Text

        Vendor_Cod1.Focus()

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
        If CanChangeOrDelete(True) = False Then
            Exit Sub
        End If

        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try

                CmdGeneral.CommandText = "Delete From GL_vendor_credit WHERE id_vendor_credit = " & Qt(Txtid_vendor_credit.Text)
                CmdGeneral.ExecuteNonQuery()

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
            End Try
            Status = MainModule.WorkStates._ReadOnly
            Call AfterSaveOrCancel()
        Else
            Reference_NoVendorCredit1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Private Function CanSave(ByVal IsAddNew As Boolean) As Boolean
        CanSave = True
        If NumAmount.Numbervalue < 0 Then
            MsgBox("Amount Must be Positive")
            CanSave = False
            Exit Function
        End If
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        If IsAddNew Then
            'CmdGeneral.CommandText = "SELECT isnull(SumCredit,0) FROM View_GL_vendor_creditReminder WHERE cod_vendor=" & Qt(Vendor_Cod1.cod_vendor)
            'If CmdGeneral.ExecuteScalar > 0 Then
            '    MsgBox("This Vendor Has a Credit With Reminder", MsgBoxStyle.Critical)
            '    CanSave = False
            '    Exit Function
            'End If
        Else
            CmdGeneral.CommandText = "SELECT id_vendor_credit_head FROM GL_vendor_credit WHERE id_vendor_credit=" & Qt(Txtid_vendor_credit.Text)
            Dim id_vendor_creditHeadTemp As String = Trim(CmdGeneral.ExecuteScalar & "")
            If id_vendor_creditHeadTemp.Length > 0 Then
                MsgBox("You Can't Change This Credit.It Was Passed", MsgBoxStyle.Critical)
                CanSave = False
                Exit Function
            End If
        End If
    End Function
    Sub PSave()

        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                If Not CanSave(True) Then
                    Exit Sub
                End If
                ReferenceNoTempVar = PInsert()
                ChangeOK = IIf(ReferenceNoTempVar.Trim.Length = 0, False, True)
                If id_vendor_creditVar.Trim.Length > 0 Then
                    id_vendor_creditVar = Txtid_vendor_credit.Text
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                If Not CanSave(False) Then
                    Exit Sub
                End If
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(ReferenceNoTempVar)
        End Select
        If ChangeOK Then
            Status = MainModule.WorkStates._ReadOnly
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            Reference_NoVendorCredit1.Text = ""
            Reference_NoVendorCredit1.Text = ReferenceNoTempVar
            Reference_NoVendorCredit1.Focus()
        Else
            MsgBox("Error in Save.Please Try Again")
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        Reference_NoVendorCredit1.Text = ReferenceNoTempVar
        If Reference_NoVendorCredit1.Text.Trim.Length = 0 Then
            Call ClearField()
        End If
        Call AfterSaveOrCancel()
        Reference_NoVendorCredit1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If Txtid_vendor_credit.Text.Trim.Length = 0 Then
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
        Call FillFields(Reference_NoVendorCredit1.Text)
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
    Private Sub Txtid_vendor_credit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtid_vendor_credit.TextChanged, TxtRemark.TextChanged, LblVendorName.TextChanged, NumAmount.TextChanged, TxtRef_no.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub Dtedate_credit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteDate_Credit.Leave, Dtedue_date.Leave
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If Vendor_Cod1.VendorCod.Trim.Length > 0 And LblVendorName.Text.Trim.Length > 0 And NumAmount.Numbervalue > 0 And Mid(DteDate_Credit.Text, 1, 2).Trim.Length > 0 And TxtRef_no.Text.Trim.Length > 0 And Mid(Dtedue_date.Text, 1, 2).Trim.Length > 0 Then
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
            Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
                Case "id_vendor_credit".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit Order BY " & ReceivePaymentOrderVar1 & " ASC"
                Case "Cod_Vendor".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC "
                Case "date_credit".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC "
            End Select
            TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
            If IsNothing(TXTSearchReferenceNoTemp) Then
                TXTSearchReferenceNoTemp = ""
            End If
            If TXTSearchReferenceNoTemp = Reference_NoVendorCredit1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                Reference_NoVendorCredit1.Text = TXTSearchReferenceNoTemp
                'Call FillFields(Reference_NoVendorCredit1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
            Case "id_vendor_credit".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit where cast(id_vendor_credit as Char(8))<" & Qt(Txtid_vendor_credit.Text) & " Order BY " & ReceivePaymentOrderVar1 & " DESC"
            Case "Cod_Vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit where (CAST(cod_Vendor AS char(" & LenVendorCod & ")))+cast(id_vendor_credit as Char(8))<" & Qt(InsertSpaceAfter(Vendor_Cod1.VendorCod, LenVendorCod) & InsertSpaceAfter(Txtid_vendor_credit.Text, Txtid_vendor_credit.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC"
            Case "date_credit".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit where date_credit+cast(id_vendor_credit as Char(8))<" & Qt(DteDate_Credit.Text & InsertSpaceAfter(Txtid_vendor_credit.Text, Txtid_vendor_credit.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC"
        End Select
        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
        If IsNothing(TXTSearchReferenceNoTemp) Then
            TXTSearchReferenceNoTemp = ""
        End If
        If TXTSearchReferenceNoTemp = Reference_NoVendorCredit1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            Reference_NoVendorCredit1.Text = TXTSearchReferenceNoTemp
            ReferenceNoTempVar = TXTSearchReferenceNoTemp
            'Call FillFields(Reference_NoVendorCredit1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
            Case "id_vendor_credit".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit where cast(id_vendor_credit as Char(8))>" & Qt(Txtid_vendor_credit.Text) & " Order BY " & ReceivePaymentOrderVar1 & " ASC"
            Case "Cod_Vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit where (CAST(Cod_Vendor AS char(" & LenVendorCod & ")))+cast(id_vendor_credit as Char(8))>" & Qt(InsertSpaceAfter(Vendor_Cod1.VendorCod, LenVendorCod) & InsertSpaceAfter(Txtid_vendor_credit.Text, Txtid_vendor_credit.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC"
            Case "date_credit".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit where date_credit+cast(id_vendor_credit as Char(8))>" & Qt(DteDate_Credit.Text & InsertSpaceAfter(Txtid_vendor_credit.Text, Txtid_vendor_credit.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC"
        End Select
        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
        If IsNothing(TXTSearchReferenceNoTemp) Then
            TXTSearchReferenceNoTemp = ""
        End If
        If TXTSearchReferenceNoTemp = Reference_NoVendorCredit1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            Reference_NoVendorCredit1.Text = TXTSearchReferenceNoTemp
            ReferenceNoTempVar = TXTSearchReferenceNoTemp
            'Call FillFields(Reference_NoVendorCredit1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
                Case "id_vendor_credit".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit Order BY " & ReceivePaymentOrderVar1 & " DESC"
                Case "Cod_Vendor".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC "
                Case "date_credit".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 id_vendor_credit from GL_vendor_credit Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC "
            End Select
            TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
            If IsNothing(TXTSearchReferenceNoTemp) Then
                TXTSearchReferenceNoTemp = ""
            End If
            If TXTSearchReferenceNoTemp = Reference_NoVendorCredit1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                Reference_NoVendorCredit1.Text = TXTSearchReferenceNoTemp
                'Call FillFields(Reference_NoVendorCredit1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Reference_NoVendorCredit1_FindReferenceNo() Handles Reference_NoVendorCredit1.FindReferenceNo
        Call FillFields(Reference_NoVendorCredit1.Text)
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
            Reference_NoVendorCredit1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmGL_AP_bill_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If BtnNew.Enabled Or PnlHead.Enabled = False Then
            Reference_NoVendorCredit1.Text = ""
        Else
            MsgBox("First You Should Save or Cancel Information")
            e.Cancel = True
        End If
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean, Optional ByVal HeaderStatus As Boolean = True)
        If Status = MainModule.WorkStates.AddNew Then
            Txtid_vendor_credit.Enabled = instatus
        Else
            Txtid_vendor_credit.Enabled = False
        End If
        Vendor_Cod1.Enabled = instatus And HeaderStatus
        TxtRemark.Enabled = instatus
        DteDate_Credit.Enabled = instatus And HeaderStatus
        NumAmount.Enabled = instatus
        TxtRef_no.Enabled = instatus
        Dtedue_date.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        Txtid_vendor_credit.Text = ""
        TxtRemark.Text = ""
        DteDate_Credit.Text = Format(Now.Date, PubDateFormat)
        Vendor_Cod1.VendorCod = ""
        LblBalance.Text = 0
        NumAmount.Text = 0
        TxtRef_no.Text = ""
        Dtedue_date.Text = ""
        LblApplied.Text = ""
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        If Cnn.State <> ConnectionState.Open Then
            Cnn.Open()
        End If
        Try
            If Not SetParametersForInsertAndUpdate(True) Then
                PInsert = ""
                MsgBox("Please try again")
                Exit Function
            End If
            PInsert = Txtid_vendor_credit.Text
        Catch ex As System.Data.SqlClient.SqlException
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal Thisid_vendor_credit As String) As Boolean
        PUpdate = True
        If Cnn.State <> ConnectionState.Open Then
            Cnn.Open()
        End If
        Try
            If Not SetParametersForInsertAndUpdate(False) Then
                PUpdate = False
                MsgBox("Please try again")
                Exit Function
            End If
            PUpdate = True
        Catch ex As System.Data.SqlClient.SqlException
            PUpdate = False
        End Try
    End Function
    Private Function SetParametersForInsertAndUpdate(ByVal InsertFlag As Boolean) As Boolean
        SetParametersForInsertAndUpdate = True
        If InsertFlag Then
            Dim iii As Integer = 0
            For iii = 0 To 10
                CmdGeneral.CommandText = "INSERT INTO GL_vendor_credit (cod_vendor, date_credit, Remark,amount_credit,ref_no,due_date) VALUES (" & Qt(Vendor_Cod1.VendorCod) & "," & Qt(DteDate_Credit.Text) & "," & Qt(TxtRemark.Text) & "," & NumAmount.Text & "," & Qt(TxtRef_no.Text) & "," & Qt(Dtedue_date.Text) & ");Select @@Identity from GL_vendor_credit"
                Try
                    CmdGeneral.ExecuteNonQuery()
                    Exit For
                Catch ex As Exception
                    Txtid_vendor_credit.Text = MakeNewReferenceNo()
                End Try
            Next
            If iii = 11 Then
                SetParametersForInsertAndUpdate = False
            Else
                SetParametersForInsertAndUpdate = True
                '''''''If OldReferenceNo <> Txtid_vendor_credit.Text And Status = MainModule.WorkStates.AddNew Then
                '''''''    Dim MyFrmShowChangedNo As New FrmShowChangedNo
                '''''''    MyFrmShowChangedNo.LblNewNo.Text = Txtid_vendor_credit.Text
                '''''''    MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
                '''''''    MyFrmShowChangedNo.ShowDialog()
                '''''''End If
            End If
        Else
            CmdGeneral.CommandText = "UPDATE GL_vendor_credit SET cod_vendor = " & Qt(Vendor_Cod1.VendorCod) & ", date_credit = " & Qt(DteDate_Credit.Text) & " , Remark = " & Qt(TxtRemark.Text) & " , amount_credit = " & NumAmount.Text & "  , Ref_no = " & Qt(TxtRef_no.Text) & "  , due_date = " & Qt(Dtedue_date.Text) & " WHERE id_vendor_credit = " & Qt(Txtid_vendor_credit.Text)
            Try
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                SetParametersForInsertAndUpdate = False
            End Try
        End If
    End Function
    Friend Function FillFields(ByVal Thisid_vendor_credit As String) As Boolean
        FillFields = False
        If Thisid_vendor_credit.Trim.Length = 0 Then
            Exit Function
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT isnull(BalanceAmount,0) FROM View_Vendor_Balance WHERE cod_vendor=" & Qt(Vendor_Cod1.cod_vendor)
        LblBalance.Text = CmdGeneral.ExecuteScalar()

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from GL_vendor_credit where id_vendor_credit=" & Qt(Thisid_vendor_credit)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                Txtid_vendor_credit.Text = Trim(SQLReader.Item("id_vendor_credit") & "")
                DteDate_Credit.Text = Trim(SQLReader.Item("date_credit") & "")
                TxtRemark.Text = Trim(SQLReader.Item("remark") & "")
                NumAmount.Text = SQLReader.Item("amount_credit")
                Dtedue_date.Text = Trim(SQLReader.Item("due_date") & "")
                TxtRef_no.Text = Trim(SQLReader.Item("Ref_no") & "")
                If Trim(SQLReader.Item("id_vendor_credit_head") & "").Length = 0 Then
                    LblApplied.Text = "Un-Applied"
                Else
                    LblApplied.Text = "Applied"
                End If
                Dim Vendor_CodVar As String = Trim(SQLReader.Item("cod_vendor") & "")
                SQLReader.Close()
                Vendor_Cod1.VendorCod = Vendor_CodVar
                FillFields = True
            Else
                Call ClearField()
                SQLReader.Close()
            End If
        Catch ex As Exception
            MsgBox("Error in loading data")
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
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UIContextMenu1.CommandClick
        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UIContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                ReceivePaymentOrderFieldName = "id_vendor_credit"
                ReceivePaymentOrderVar1 = "id_vendor_credit"
                ReceivePaymentOrderVar2 = ""
            Case "SORT2"
                ReceivePaymentOrderFieldName = "cod_Vendor"
                ReceivePaymentOrderVar1 = "cod_Vendor"
                ReceivePaymentOrderVar2 = "id_vendor_credit"
            Case "SORT3"
                ReceivePaymentOrderFieldName = "date_credit"
                ReceivePaymentOrderVar1 = "date_credit"
                ReceivePaymentOrderVar2 = "id_vendor_credit"
        End Select
    End Sub
    Private Sub Txtid_vendor_credit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtid_vendor_credit.Leave
        Try
            MyClsReceivePayment.Connection = Cnn
        Catch ex As Exception
        End Try
        If MyClsReceivePayment.FindDesc(Txtid_vendor_credit.Text) Then
            MsgBox("This Reference No already axist.Try a new Code")
            Txtid_vendor_credit.Clear()
            Txtid_vendor_credit.Focus()
        End If
        OldReferenceNo = Txtid_vendor_credit.Text
    End Sub
    Private Function MakeNewReferenceNo() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(id_vendor_credit) as Max_cod from GL_vendor_credit "
            MakeNewReferenceNo = CmdGeneral.ExecuteScalar
            ValMakeNewcod = GetVal(MakeNewReferenceNo, LenVendorBillReferenceNo)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
        Catch ex As Exception
            MakeNewReferenceNo = "1"
        End Try
    End Function
    Private Sub Vendor_Cod1_FindVendor_Cod() Handles Vendor_Cod1.FindVendorCod
        LblVendorName.Text = Vendor_Cod1.Desc_Vendor
    End Sub
    Private Sub Vendor_Cod1_NotFindVendor_Cod() Handles Vendor_Cod1.NotFindVendorCod
        LblVendorName.Text = ""
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Reference_NoVendorCredit1.BtnSearch_Click(sender, e)
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("PRINT")
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("PREVIEW")
    End Sub

    Private Sub BtnFax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFax.Click
        Call pprint("FAX")
    End Sub
    Private Sub pprint(ByVal PrintType As String)

        'If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '    CmdGeneral.Connection.Open()
        'End If
        'CmdGeneral.CommandText = "SELECT count(*) FROM GL_vendor_credit where id_vendor_credit=" & Qt(Txtid_vendor_credit.Text)

        'If CmdGeneral.ExecuteScalar <> 1 Then
        '    MsgBox("Please Save Befor " & PrintType)
        '    Exit Sub
        'End If

        'If DsFrmReceivePayment1.GridRecord.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'Dim rpt As New RepReceivePayment
        'Dim prn As New FrmRepView

        'rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

        'Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        'OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        'rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        'rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")


        'rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        'rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
        'rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

        'DsFrmReceivePayment1.LOGO.Clear()
        'Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
        'OleDbReaderForCompany = RetrieveCompanySetupTable()
        'Try
        '    DsFrmReceivePayment1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))
        'rpt.SetParameterValue("ParCusName", Vendor_Cod1.CustomerDesc)
        'rpt.SetParameterValue("ParCusAddress", Vendor_Cod1.Address)
        'rpt.SetParameterValue("ParCusPhone", Vendor_Cod1.CustomerPhone)
        'rpt.SetParameterValue("Parkindrep", "Payement Reciept")
        'rpt.SetParameterValue("parcusno", Vendor_Cod1.Text)
        'rpt.SetParameterValue("pardate", Dtedate_credit.Text)
        'rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))
        'rpt.SetParameterValue("parno", Txtid_vendor_credit.Text)
        'If DsFrmReceivePayment1.service_center_dtl.Rows.Count > 0 Then
        '    If RdoCash.Checked Then
        '        rpt.SetParameterValue("parcash", lblApplied.Text)
        '        rpt.SetParameterValue("parcheck", "")
        '        rpt.SetParameterValue("parcheckno", "")
        '        rpt.SetParameterValue("parcrcard", "")
        '        rpt.SetParameterValue("parcctype", "") ''''''''''''
        '        rpt.SetParameterValue("parauthcode", "")
        '    Else
        '        If RdoCheck.Checked Then
        '            rpt.SetParameterValue("parcash", "")
        '            rpt.SetParameterValue("parcheck", lblApplied.Text)
        '            rpt.SetParameterValue("parcheckno", TxtCheck_no.Text)
        '            rpt.SetParameterValue("parcrcard", "")
        '            rpt.SetParameterValue("parcctype", "") ''''''''''''
        '            rpt.SetParameterValue("parauthcode", "")
        '        Else
        '            rpt.SetParameterValue("parcash", "")
        '            rpt.SetParameterValue("parcheck", "")
        '            rpt.SetParameterValue("parcheckno", "")
        '            rpt.SetParameterValue("parcrcard", lblApplied.Text)
        '            rpt.SetParameterValue("parcctype", CmbCc_type.Text) ''''''''''''
        '            rpt.SetParameterValue("parauthcode", TxtAuthNo.Text)
        '        End If
        '    End If
        'End If
        'rpt.SetParameterValue("parpayamount", NumAmount_Receive.Text)
        'rpt.SetParameterValue("parpribalanse", LblBalance.Text)
        'rpt.SetParameterValue("parnewbalance", lblAmountDue.Text)
        'rpt.SetParameterValue("parmemo", TxtRemark.Text)


        'rpt.SetParameterValue("Store1Amount", 0)
        'rpt.SetParameterValue("Store2Amount", 0)
        'rpt.SetParameterValue("Store3Amount", 0)

        'rpt.SetDataSource(DsFrmReceivePayment1)
        'Select Case PrintType.ToUpper
        '    Case "print".ToUpper
        '        rpt.PrintToPrinter(1, True, 0, 0)
        '    Case "preview".ToUpper
        '        prn.CrViewer.ReportSource = rpt
        '        prn.ShowDialog()
        '    Case "fax".ToUpper
        '        Try
        '            rpt.PrintOptions.PrinterName = "Fax"
        '            rpt.PrintToPrinter(1, True, 0, 0)
        '        Catch ex As Exception
        '            MsgBox("Add The FAX in (Printers and Faxes)")
        '        End Try
        'End Select

    End Sub
    Private Function CanChangeOrDelete(ByVal DeleteStatusFlag As Boolean) As Boolean
        CanChangeOrDelete = True
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT id_receive_ref FROM GL_vendor_credit WHERE id_vendor_credit=" & Qt(Txtid_vendor_credit.Text)
        Dim id_receive_refTemp As String = Trim(CmdGeneral.ExecuteScalar & "")
        If id_receive_refTemp.Length > 0 Then
            MsgBox("You Can't Change Or Delete This Credit.It Was Created by Inventory Return", MsgBoxStyle.Critical)
            CanChangeOrDelete = False
            Exit Function
        End If
        If DeleteStatusFlag Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT id_vendor_credit_head FROM GL_vendor_credit WHERE id_vendor_credit=" & Qt(Txtid_vendor_credit.Text)
            Dim id_vendor_creditHeadTemp As String = Trim(CmdGeneral.ExecuteScalar & "")
            If id_vendor_creditHeadTemp.Length > 0 Then
                MsgBox("You Can't Change Or Delete This Credit.It Was Passed", MsgBoxStyle.Critical)
                CanChangeOrDelete = False
                Exit Function
            End If
        End If
    End Function
    Private Sub BtnVendorBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVendorBalance.Click
        Dim MyFrmVendorBalance As New FrmVendorBalance
        MyFrmVendorBalance.cod_vendorParameter = Vendor_Cod1.VendorCod
        MyFrmVendorBalance.LblVendor.Text = Vendor_Cod1.VendorCod
        MyFrmVendorBalance.LblName.Text = Vendor_Cod1.Desc_Vendor
        MyFrmVendorBalance.ShowDialog()
    End Sub
    Private Sub GrdDetail_Error(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ErrorEventArgs)
        'MsgBox(e.ErrorMessage)
    End Sub
End Class
