Imports Janus.Windows.GridEX
Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmGL_AP_bill
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim ReceivePaymentOrderFieldName As String = "Id_AP_bill_Head"
    Dim ReceivePaymentOrderVar1 As String = "Id_AP_bill_Head"
    Dim ReceivePaymentOrderVar2 As String = ""
    Friend ReferenceNoTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public Id_AP_bill_HeadVar As String = ""
    Public Id_AP_bill_HeadForShowReadOnly As String = ""
    Dim MyClsReceivePayment As New ClsVendorReferenceNo
    Dim ID_paymentVar As Decimal
    Dim OldReferenceNo As String = ""
    Dim LenVendorBillReferenceNo As Integer = 10
    Dim RowNoToAdd As Double = 25
    Dim MaxRowNo As Double = RowNoToAdd
    Dim MyFrmGL_AP_billCOA As FrmGL_AP_billCOA
    Dim MyFrmShowPaymentDetail As FrmShowPaymentDetail
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
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
    Friend WithEvents Reference_No1 As Reference_No
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
    Friend WithEvents LblBalance As CalcUtils.UcCalcText
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_AP_bill_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmGL_AP_bill1 As UCVendor.DSFrmGL_AP_bill
    Friend WithEvents LblVendorName As System.Windows.Forms.Label
    Friend WithEvents DteDate_Bill As CalendarCombo.CalendarCombo
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Public WithEvents TxtId_AP_bill_Head As System.Windows.Forms.TextBox
    Friend WithEvents DteDateForGrid As CalendarCombo.CalendarCombo
    Friend WithEvents CmbAR_terms As System.Windows.Forms.ComboBox
    Friend WithEvents DAGL_payment_bill_COA As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnLock As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralLock As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_AP_bill_Dtl_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BtnVendorBalance As System.Windows.Forms.Button
    Friend WithEvents LblTotalAmount As CalcUtils.UcCalcText
    Friend WithEvents lblTotalDiscount As CalcUtils.UcCalcText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DteDueDateForGrid As CalendarCombo.CalendarCombo
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItemDelete As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGL_AP_bill))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.Reference_No1 = New UCVendor.Reference_No
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.BtnVendorBalance = New System.Windows.Forms.Button
        Me.LblBalance = New CalcUtils.UcCalcText
        Me.TxtId_AP_bill_Head = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtRemark = New System.Windows.Forms.TextBox
        Me.DteDate_Bill = New CalendarCombo.CalendarCombo
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblVendorName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItemDelete = New System.Windows.Forms.MenuItem
        Me.DsFrmGL_AP_bill1 = New UCVendor.DSFrmGL_AP_bill
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblTotalAmount = New CalcUtils.UcCalcText
        Me.lblTotalDiscount = New CalcUtils.UcCalcText
        Me.DteDateForGrid = New CalendarCombo.CalendarCombo
        Me.CmbAR_terms = New System.Windows.Forms.ComboBox
        Me.DteDueDateForGrid = New CalendarCombo.CalendarCombo
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_AP_bill_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.DAGL_payment_bill_COA = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.CnnLock = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneralLock = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_AP_bill_Dtl_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmGL_AP_bill1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.PnlSearch.Size = New System.Drawing.Size(803, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'Reference_No1
        '
        Me.Reference_No1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reference_No1.Connection = Me.Cnn
        Me.Reference_No1.Location = New System.Drawing.Point(78, 1)
        Me.Reference_No1.Name = "Reference_No1"
        Me.Reference_No1.NotExitIfNotFound = False
        Me.Reference_No1.ReferenceNoLen = 6
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
        Me.PnlKartAmvalField.Controls.Add(Me.DteDateForGrid)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbAR_terms)
        Me.PnlKartAmvalField.Controls.Add(Me.DteDueDateForGrid)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(803, 368)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Vendor_Cod1)
        Me.Panel1.Controls.Add(Me.BtnVendorBalance)
        Me.Panel1.Controls.Add(Me.LblBalance)
        Me.Panel1.Controls.Add(Me.TxtId_AP_bill_Head)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtRemark)
        Me.Panel1.Controls.Add(Me.DteDate_Bill)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblVendorName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 76)
        Me.Panel1.TabIndex = 0
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(74, 25)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Vendor_Cod1.TabIndex = 1
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'BtnVendorBalance
        '
        Me.BtnVendorBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnVendorBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnVendorBalance.Location = New System.Drawing.Point(613, 0)
        Me.BtnVendorBalance.Name = "BtnVendorBalance"
        Me.BtnVendorBalance.Size = New System.Drawing.Size(88, 21)
        Me.BtnVendorBalance.TabIndex = 4
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
        Me.LblBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBalance.Image = CType(resources.GetObject("LblBalance.Image"), System.Drawing.Image)
        Me.LblBalance.Location = New System.Drawing.Point(704, 0)
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
        'TxtId_AP_bill_Head
        '
        Me.TxtId_AP_bill_Head.Location = New System.Drawing.Point(73, 2)
        Me.TxtId_AP_bill_Head.MaxLength = 6
        Me.TxtId_AP_bill_Head.Name = "TxtId_AP_bill_Head"
        Me.TxtId_AP_bill_Head.ReadOnly = True
        Me.TxtId_AP_bill_Head.Size = New System.Drawing.Size(104, 20)
        Me.TxtId_AP_bill_Head.TabIndex = 0
        Me.TxtId_AP_bill_Head.Text = ""
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
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(73, 51)
        Me.TxtRemark.MaxLength = 100
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(715, 20)
        Me.TxtRemark.TabIndex = 3
        Me.TxtRemark.Text = ""
        '
        'DteDate_Bill
        '
        Me.DteDate_Bill.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_Bill.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_Bill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_Bill.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_Bill.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_Bill.EditableSal = True
        Me.DteDate_Bill.Image = CType(resources.GetObject("DteDate_Bill.Image"), System.Drawing.Image)
        Me.DteDate_Bill.Location = New System.Drawing.Point(659, 23)
        Me.DteDate_Bill.MaxValue = CType(2500, Short)
        Me.DteDate_Bill.MinValue = CType(1800, Short)
        Me.DteDate_Bill.Name = "DteDate_Bill"
        Me.DteDate_Bill.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_Bill.Sal_Mali = Nothing
        Me.DteDate_Bill.ShowButton = True
        Me.DteDate_Bill.Size = New System.Drawing.Size(102, 23)
        Me.DteDate_Bill.TabIndex = 2
        Me.DteDate_Bill.VisualStyle = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(617, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 21)
        Me.Label13.TabIndex = 337
        Me.Label13.Text = "Date "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(-3, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 331
        Me.Label5.Text = "Memo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblVendorName
        '
        Me.LblVendorName.BackColor = System.Drawing.Color.Gold
        Me.LblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVendorName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblVendorName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblVendorName.Location = New System.Drawing.Point(220, 25)
        Me.LblVendorName.Name = "LblVendorName"
        Me.LblVendorName.Size = New System.Drawing.Size(380, 20)
        Me.LblVendorName.TabIndex = 328
        Me.LblVendorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(-4, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Vendor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(184, 24)
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
        Me.GrdDetail.ContextMenu = Me.ContextMenu1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DsFrmGL_AP_bill1.GL_AP_bill_Dtl
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_AP_bill_Dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""Id_AP_bill_dtl""><Caption>Id_AP_bill_dtl</Caption><TypeNameE" & _
        "mptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>I" & _
        "d_AP_bill_dtl</DataMember><EditType>NoEdit</EditType><Key>Id_AP_bill_dtl</Key><P" & _
        "osition>0</Position><Visible>False</Visible></Column0><Column1 ID=""ref_no""><Capt" & _
        "ion>Ref. No</Caption><DataMember>ref_no</DataMember><Key>ref_no</Key><MaxLength>" & _
        "10</MaxLength><Position>1</Position><Width>78</Width></Column1><Column2 ID=""Ref_" & _
        "date""><Caption>Date</Caption><DataMember>Ref_date</DataMember><EditType>Custom</" & _
        "EditType><Key>Ref_date</Key><Position>2</Position><Width>104</Width><DefaultValu" & _
        "e /></Column2><Column3 ID=""Desc_Bill""><Caption>Description</Caption><DataMember>" & _
        "Desc_Bill</DataMember><Key>Desc_Bill</Key><MaxLength>100</MaxLength><Position>3<" & _
        "/Position><Width>188</Width></Column3><Column4 ID=""amount""><Caption>Amount</Capt" & _
        "ion><DataMember>amount</DataMember><FormatString>c2</FormatString><InputMask>Cur" & _
        "rency2</InputMask><Key>amount</Key><MaskPrompt>&#x0;</MaskPrompt><MaxLength>10</" & _
        "MaxLength><Position>4</Position><TextAlignment>Far</TextAlignment><Width>78</Wid" & _
        "th></Column4><Column5 ID=""AR_terms""><Caption>AP Terms</Caption><DataMember>AR_te" & _
        "rms</DataMember><EditType>Custom</EditType><Key>AR_terms</Key><Position>5</Posit" & _
        "ion><DefaultValue /></Column5><Column6 ID=""Min_due_date""><Caption>Due Date</Capt" & _
        "ion><DataMember>Min_due_date</DataMember><EditType>NoEdit</EditType><Key>Min_due" & _
        "_date</Key><Position>6</Position><Width>104</Width><DefaultValue /></Column6><Co" & _
        "lumn7 ID=""Discount""><Caption>Discount</Caption><DataMember>Discount</DataMember>" & _
        "<FormatString>c2</FormatString><InputMask>Currency2</InputMask><Key>Discount</Ke" & _
        "y><MaskPrompt>&#x0;</MaskPrompt><MaxLength>10</MaxLength><Position>7</Position><" & _
        "TextAlignment>Far</TextAlignment><Width>69</Width></Column7><Column8 ID=""BtnCOA""" & _
        "><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><Caption>COA</Caption>" & _
        "<Key>BtnCOA</Key><Position>8</Position><Selectable>False</Selectable><Width>31</" & _
        "Width></Column8><Column9 ID=""BtnDetail""><Bound>False</Bound><ButtonStyle>ButtonC" & _
        "ell</ButtonStyle><Caption>Det</Caption><Key>BtnDetail</Key><Position>9</Position" & _
        "><Selectable>False</Selectable><Width>29</Width></Column9></Columns><GroupCondit" & _
        "ion ID="""" /><Key>GL_AP_bill_Dtl</Key><RowHeight>22</RowHeight></RootTable></Grid" & _
        "EXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(1, 77)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(801, 260)
        Me.GrdDetail.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemDelete})
        '
        'MenuItemDelete
        '
        Me.MenuItemDelete.Index = 0
        Me.MenuItemDelete.Text = "Delete This Record"
        '
        'DsFrmGL_AP_bill1
        '
        Me.DsFrmGL_AP_bill1.DataSetName = "DSFrmGL_AP_bill"
        Me.DsFrmGL_AP_bill1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.LblTotalAmount)
        Me.Panel5.Controls.Add(Me.lblTotalDiscount)
        Me.Panel5.Location = New System.Drawing.Point(0, 337)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(804, 29)
        Me.Panel5.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(128, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 460
        Me.Label3.Text = "Total Amount :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(407, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 459
        Me.Label1.Text = "Total Discount :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalAmount
        '
        Me.LblTotalAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblTotalAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblTotalAmount.DecimalDigits = 2
        Me.LblTotalAmount.DefaultSendValue = False
        Me.LblTotalAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotalAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTotalAmount.Image = CType(resources.GetObject("LblTotalAmount.Image"), System.Drawing.Image)
        Me.LblTotalAmount.Location = New System.Drawing.Point(217, 4)
        Me.LblTotalAmount.Maxlength = 10
        Me.LblTotalAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblTotalAmount.Name = "LblTotalAmount"
        Me.LblTotalAmount.ReadOnly = True
        Me.LblTotalAmount.Size = New System.Drawing.Size(120, 21)
        Me.LblTotalAmount.TabIndex = 458
        Me.LblTotalAmount.TabStop = False
        Me.LblTotalAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotalAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'lblTotalDiscount
        '
        Me.lblTotalDiscount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.lblTotalDiscount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.lblTotalDiscount.DecimalDigits = 2
        Me.lblTotalDiscount.DefaultSendValue = False
        Me.lblTotalDiscount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.lblTotalDiscount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblTotalDiscount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalDiscount.Image = CType(resources.GetObject("lblTotalDiscount.Image"), System.Drawing.Image)
        Me.lblTotalDiscount.Location = New System.Drawing.Point(505, 4)
        Me.lblTotalDiscount.Maxlength = 10
        Me.lblTotalDiscount.MinusColor = System.Drawing.Color.Empty
        Me.lblTotalDiscount.Name = "lblTotalDiscount"
        Me.lblTotalDiscount.ReadOnly = True
        Me.lblTotalDiscount.Size = New System.Drawing.Size(120, 21)
        Me.lblTotalDiscount.TabIndex = 457
        Me.lblTotalDiscount.TabStop = False
        Me.lblTotalDiscount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.lblTotalDiscount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'DteDateForGrid
        '
        Me.DteDateForGrid.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDateForGrid.BorderColor = System.Drawing.Color.Empty
        Me.DteDateForGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDateForGrid.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDateForGrid.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDateForGrid.EditableSal = True
        Me.DteDateForGrid.Image = CType(resources.GetObject("DteDateForGrid.Image"), System.Drawing.Image)
        Me.DteDateForGrid.Location = New System.Drawing.Point(310, 200)
        Me.DteDateForGrid.MaxValue = CType(2500, Short)
        Me.DteDateForGrid.MinValue = CType(1800, Short)
        Me.DteDateForGrid.Name = "DteDateForGrid"
        Me.DteDateForGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDateForGrid.Sal_Mali = Nothing
        Me.DteDateForGrid.ShowButton = True
        Me.DteDateForGrid.Size = New System.Drawing.Size(110, 23)
        Me.DteDateForGrid.TabIndex = 2
        Me.DteDateForGrid.VisualStyle = False
        '
        'CmbAR_terms
        '
        Me.CmbAR_terms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbAR_terms.DataSource = Me.DsFrmGL_AP_bill1.GL_TAB_AR_TERM
        Me.CmbAR_terms.DisplayMember = "AR_terms"
        Me.CmbAR_terms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAR_terms.Location = New System.Drawing.Point(352, 174)
        Me.CmbAR_terms.Name = "CmbAR_terms"
        Me.CmbAR_terms.Size = New System.Drawing.Size(114, 21)
        Me.CmbAR_terms.TabIndex = 13
        Me.CmbAR_terms.ValueMember = "AR_terms"
        '
        'DteDueDateForGrid
        '
        Me.DteDueDateForGrid.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDueDateForGrid.BorderColor = System.Drawing.Color.Empty
        Me.DteDueDateForGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDueDateForGrid.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDueDateForGrid.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDueDateForGrid.EditableSal = True
        Me.DteDueDateForGrid.Image = CType(resources.GetObject("DteDueDateForGrid.Image"), System.Drawing.Image)
        Me.DteDueDateForGrid.Location = New System.Drawing.Point(520, 198)
        Me.DteDueDateForGrid.MaxValue = CType(2500, Short)
        Me.DteDueDateForGrid.MinValue = CType(1800, Short)
        Me.DteDueDateForGrid.Name = "DteDueDateForGrid"
        Me.DteDueDateForGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDueDateForGrid.Sal_Mali = Nothing
        Me.DteDueDateForGrid.ShowButton = True
        Me.DteDueDateForGrid.Size = New System.Drawing.Size(110, 23)
        Me.DteDueDateForGrid.TabIndex = 14
        Me.DteDueDateForGrid.VisualStyle = False
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
        Me.PnlHead.Size = New System.Drawing.Size(803, 45)
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_AP_bill_Dtl.Id_AP_bill_dtl, GL_AP_bill_Dtl.ref_no, GL_AP_bill_Dtl.AR_te" & _
        "rms, GL_AP_bill_Dtl.amount, GL_AP_bill_Dtl.Discount, GL_AP_bill_Dtl.id_GL_journa" & _
        "l, GL_AP_bill_Dtl.Ref_date, View_AP_Bill_Dtl_Min_due_date.Min_due_date, GL_AP_bi" & _
        "ll_Dtl.Desc_Bill FROM GL_AP_bill_Dtl LEFT OUTER JOIN View_AP_Bill_Dtl_Min_due_da" & _
        "te ON GL_AP_bill_Dtl.Id_AP_bill_dtl = View_AP_Bill_Dtl_Min_due_date.Id_AP_bill_d" & _
        "tl WHERE (GL_AP_bill_Dtl.Id_AP_bill_Head = @Id_AP_bill_Head)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_Head", System.Data.SqlDbType.VarChar, 10, "Id_AP_bill_Head"))
        '
        'DAGL_AP_bill_Dtl
        '
        Me.DAGL_AP_bill_Dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_AP_bill_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_Head", "Id_AP_bill_Head"), New System.Data.Common.DataColumnMapping("ref_no", "ref_no"), New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT AR_terms FROM GL_TAB_AR_TERM"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        '
        'DAGL_payment_bill_COA
        '
        Me.DAGL_payment_bill_COA.SelectCommand = Me.SqlCommand1
        Me.DAGL_payment_bill_COA.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_bill_COA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Amount", "Amount"), New System.Data.Common.DataColumnMapping("Memo", "Memo")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_payment_bill_COA.Id_AP_bill_dtl, GL_payment_bill_COA.GL_account, GL_pay" & _
        "ment_bill_COA.Amount, GL_payment_bill_COA.Memo, GL_account.desc_GL_account FROM " & _
        "GL_payment_bill_COA LEFT OUTER JOIN GL_AP_bill_Dtl ON GL_payment_bill_COA.Id_AP_" & _
        "bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl LEFT OUTER JOIN GL_account ON GL_paymen" & _
        "t_bill_COA.GL_account = GL_account.GL_account WHERE (GL_AP_bill_Dtl.Id_AP_bill_H" & _
        "ead = @Id_AP_bill_Head)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_Head", System.Data.SqlDbType.VarChar, 10, "Id_AP_bill_Head"))
        '
        'CmdGeneralLock
        '
        Me.CmdGeneralLock.Connection = Me.CnnLock
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl, " & _
        "GL_AP_bill_Dtl_Dtl.amount, GL_AP_bill_Dtl_Dtl.due_date, GL_AP_bill_Dtl.Id_AP_bil" & _
        "l_Head FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.I" & _
        "d_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl WHERE (GL_AP_bill_Dtl.Id_AP_bill_H" & _
        "ead = @Id_AP_bill_Head)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_Head", System.Data.SqlDbType.VarChar, 10, "Id_AP_bill_Head"))
        '
        'DAGL_AP_bill_Dtl_Dtl
        '
        Me.DAGL_AP_bill_Dtl_Dtl.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_AP_bill_Dtl_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'FrmGL_AP_bill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(803, 440)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.PnlHead)
        Me.Name = "FrmGL_AP_bill"
        Me.Text = "AP Bills"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmGL_AP_bill1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
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
    Private Sub FrmReceivePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Vendor_Cod1.CanAddNewCod = False
        Reference_No1.CanAddNewCod = False
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        Me.CnnForReader.ConnectionString = PConnectionString
        Me.CnnLock.ConnectionString = PConnectionString

        MyClsReceivePayment.Connection = Cnn
        PnlSearchHeight = PnlSearch.Height

        DteDate_Bill.Text = Format(Now.Date, PubDateFormat)

        UIContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        Call FillDataSets()
        TxtId_AP_bill_Head.MaxLength = LenVendorBillReferenceNo

        If Id_AP_bill_HeadVar.Trim.Length > 0 Then
            Call PAddNew()
            TxtId_AP_bill_Head.Text = Id_AP_bill_HeadVar
            Vendor_Cod1.Focus()
        Else
            If Id_AP_bill_HeadForShowReadOnly.Trim.Length = 0 Then
                Call PFirstRecord(False)
            Else
                Reference_No1.Text = Id_AP_bill_HeadForShowReadOnly
                PnlHead.Enabled = False
                PnlSearch.Enabled = False
                PnlHead.Height = 0
                PnlSearch.Height = 0
                'Call FillFields(Reference_No1.Text)
            End If
            Call AfterSaveOrCancel()
            Reference_No1.Focus()
        End If
    End Sub
    Private Sub FillDataSets()
        DsFrmGL_AP_bill1.GL_account.Clear()
        DAGL_account.Fill(DsFrmGL_AP_bill1, "GL_account")
        If DsFrmGL_AP_bill1.GL_account.Rows.Count < 1 Then
            MsgFar("Please Fill The GL_account Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmGL_AP_bill1.GL_TAB_AR_TERM.Clear()
        DAGL_TAB_AR_TERM.Fill(DsFrmGL_AP_bill1, "GL_TAB_AR_TERM")
        If DsFrmGL_AP_bill1.GL_TAB_AR_TERM.Rows.Count < 1 Then
            MsgFar("Please Fill The Credit Card Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If
        DsFrmGL_AP_bill1.GL_TAB_AR_TERM.AddGL_TAB_AR_TERMRow("")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        ReferenceNoTempVar = Reference_No1.Text
        Reference_No1.Text = ""
        Call ClearField()
        Dim IFirstCount As Integer = DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        MaxRowNo = RowNoToAdd + IFirstCount
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To MaxRowNo
            Call AddEmptyRecordToDetail(TxtId_AP_bill_Head.Text, AddEmptyRecordToDetailCount)
        Next

        TxtId_AP_bill_Head.Text = MakeNewReferenceNo()
        OldReferenceNo = TxtId_AP_bill_Head.Text
        Vendor_Cod1.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnSortOrder.Enabled = False
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
        ReferenceNoTempVar = Reference_No1.Text

        Dim AddEmptyRecordToDetailCount As Integer
        Dim IFirstCount As Integer = DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count()
        MaxRowNo = RowNoToAdd + IFirstCount
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To MaxRowNo
            Call AddEmptyRecordToDetail(TxtId_AP_bill_Head.Text, AddEmptyRecordToDetailCount)
        Next

        Vendor_Cod1.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnSortOrder.Enabled = False
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

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Delete From GL_AP_Bill_Head WHERE Id_AP_bill_Head = " & Qt(TxtId_AP_bill_Head.Text)
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
            Reference_No1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Private Function CanSave() As Boolean
        CanSave = True
        If LblTotalAmount.Numbervalue < 0 Then
            MsgBox("Amount Must be Positive")
            CanSave = False
            Exit Function
        End If
        Dim i As Integer
        Dim AmountTemp As Decimal = 0
        With DsFrmGL_AP_bill1.GL_AP_bill_Dtl
            For i = 0 To .Rows.Count - 1
                If DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).RowState <> DataRowState.Deleted Then
                    If Trim(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("ref_no") & "").Length > 0 Then
                        If .Rows(i).Item("Amount") <= 0 Then
                            MsgBox("Amount Should be Grater than Zero")
                            CanSave = False
                            Exit Function
                        End If
                        If .Rows(i).Item("Discount") < 0 Then
                            MsgBox("Discount Should be Positive")
                            CanSave = False
                            Exit Function
                        End If
                        If Trim(.Rows(i).Item("AR_terms") & "").Length = 0 Then
                            MsgBox("Please Fill AP Terms")
                            CanSave = False
                            Exit Function
                        End If
                        If .Rows(i).Item("Discount") > .Rows(i).Item("Amount") Then
                            MsgBox("Discout Should be Less than Amount")
                            CanSave = False
                            Exit Function
                        End If
                        Try
                            AmountTemp = Math.Round(DsFrmGL_AP_bill1.GL_payment_bill_COA.Compute("Sum(Amount)", "Id_AP_bill_dtl=" & .Rows(i).Item("Id_AP_bill_dtl")), 2)
                        Catch ex As Exception
                            AmountTemp = 0
                        End Try
                        If AmountTemp <> .Rows(i).Item("Amount") - .Rows(i).Item("Discount") Then
                            MsgBox("Please make sure SUM of the AMOUNT of Gl distribution " & vbCrLf & "is equal to the Bill Amount before saving this record.")
                            CanSave = False
                            Exit Function
                        End If
                    End If
                End If
            Next
        End With
    End Function
    Sub PSave()
        If Not CanSave() Then
            Exit Sub
        End If

        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                ReferenceNoTempVar = PInsert()
                ChangeOK = IIf(ReferenceNoTempVar.Trim.Length = 0, False, True)
                If Id_AP_bill_HeadVar.Trim.Length > 0 Then
                    Id_AP_bill_HeadVar = TxtId_AP_bill_Head.Text
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
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

            Reference_No1.Text = ""
            Reference_No1.Text = ReferenceNoTempVar
            Reference_No1.Focus()
        Else
            Dim IFirstCount As Integer = DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count()
            Dim AddEmptyRecordToDetailCount As Integer
            MaxRowNo = RowNoToAdd + IFirstCount
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To MaxRowNo
                Call AddEmptyRecordToDetail(TxtId_AP_bill_Head.Text, AddEmptyRecordToDetailCount)
            Next
        End If
    End Sub
    Private Sub AddEmptyRecordToDetail(ByVal ThisSerialNo As String, ByVal ThisRadif As Integer)
        Try
            Dim dr As DataRow
            dr = DsFrmGL_AP_bill1.GL_AP_bill_Dtl.NewRow
            'dr("") = ThisSerialNo
            dr("ref_no") = ""
            dr("amount") = 0
            dr("Desc_Bill") = "Purchases"
            dr("Discount") = 0
            dr("Ref_date") = DteDate_Bill.Text
            dr("Min_due_date") = ""
            dr("id_GL_journal") = 0
            dr("AR_terms") = Vendor_Cod1.Ap_terms
            DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Add(dr)
        Catch ex As Exception
        End Try
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        Reference_No1.Text = ReferenceNoTempVar
        If Reference_No1.Text.Trim.Length = 0 Then
            Call ClearField()
        End If
        Call AfterSaveOrCancel()
        Reference_No1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        If TxtId_AP_bill_Head.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False
            BtnEdit.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnFirst.Enabled = False
            BtnLast.Enabled = False
            BtnSortOrder.Enabled = False
        Else
            BtnDelete.Enabled = True
            BtnEdit.Enabled = True
            BtnPrev.Enabled = True
            BtnNext.Enabled = True
            BtnFirst.Enabled = True
            BtnLast.Enabled = True
            BtnSortOrder.Enabled = True
        End If
        Call EnableField(False)
        Call FillFields(Reference_No1.Text)
    End Sub
    Private Sub MAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PAddNew()
    End Sub
    Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PEdit()
    End Sub
    Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PDelete()
    End Sub
    Private Sub MSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PSave()
    End Sub
    Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PCancel()
    End Sub
    Private Sub TxtId_AP_bill_Head_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId_AP_bill_Head.TextChanged, TxtRemark.TextChanged, LblVendorName.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub DteDate_Bill_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteDate_Bill.Leave
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtId_AP_bill_Head.Text.Trim.Length > 0 And Vendor_Cod1.VendorCod.Trim.Length > 0 And LblVendorName.Text.Trim.Length > 0 And Val(LblTotalAmount.Text) > 0 And Mid(DteDate_Bill.Text, 1, 2).Trim.Length > 0 Then
                BtnSave.Enabled = True
            Else
                BtnSave.Enabled = False
            End If
        End If
    End Sub
    Private Sub MFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PFirstRecord()
    End Sub
    Private Sub MPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PPreviousRecord()
    End Sub
    Private Sub MNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PNextRecord()
    End Sub
    Private Sub MLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PLastRecord()
    End Sub
    Private Sub PFirstRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
                Case "Id_AP_bill_Head".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head Order BY " & ReceivePaymentOrderVar1 & " ASC"
                Case "Cod_Vendor".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC "
                Case "Date_Bill".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC "
            End Select
            TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
            If IsNothing(TXTSearchReferenceNoTemp) Then
                TXTSearchReferenceNoTemp = ""
            End If
            If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                Reference_No1.Text = TXTSearchReferenceNoTemp
                'Call FillFields(Reference_No1.Text)
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
            Case "Id_AP_bill_Head".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head where Id_AP_bill_Head<" & Qt(TxtId_AP_bill_Head.Text) & " Order BY " & ReceivePaymentOrderVar1 & " DESC"
            Case "Cod_Vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head where (CAST(cod_Vendor AS char(" & LenVendorCod & ")))+Id_AP_bill_Head<" & Qt(InsertSpaceAfter(Vendor_Cod1.VendorCod, LenVendorCod) & InsertSpaceAfter(TxtId_AP_bill_Head.Text, TxtId_AP_bill_Head.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC"
            Case "Date_Bill".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head where Date_Bill+Id_AP_bill_Head<" & Qt(DteDate_Bill.Text & InsertSpaceAfter(TxtId_AP_bill_Head.Text, TxtId_AP_bill_Head.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC"
        End Select
        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
        If IsNothing(TXTSearchReferenceNoTemp) Then
            TXTSearchReferenceNoTemp = ""
        End If
        If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            Reference_No1.Text = TXTSearchReferenceNoTemp
            ReferenceNoTempVar = TXTSearchReferenceNoTemp
            'Call FillFields(Reference_No1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
            Case "Id_AP_bill_Head".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head where Id_AP_bill_Head>" & Qt(TxtId_AP_bill_Head.Text) & " Order BY " & ReceivePaymentOrderVar1 & " ASC"
            Case "Cod_Vendor".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head where (CAST(Cod_Vendor AS char(" & LenVendorCod & ")))+Id_AP_bill_Head>" & Qt(InsertSpaceAfter(Vendor_Cod1.VendorCod, LenVendorCod) & InsertSpaceAfter(TxtId_AP_bill_Head.Text, TxtId_AP_bill_Head.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC"
            Case "Date_Bill".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head where Date_Bill+Id_AP_bill_Head>" & Qt(DteDate_Bill.Text & InsertSpaceAfter(TxtId_AP_bill_Head.Text, TxtId_AP_bill_Head.MaxLength)) & " Order BY " & ReceivePaymentOrderVar1 & " ASC , " & ReceivePaymentOrderVar2 & " ASC"
        End Select
        TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
        If IsNothing(TXTSearchReferenceNoTemp) Then
            TXTSearchReferenceNoTemp = ""
        End If
        If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            Reference_No1.Text = TXTSearchReferenceNoTemp
            ReferenceNoTempVar = TXTSearchReferenceNoTemp
            'Call FillFields(Reference_No1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchReferenceNoTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case ReceivePaymentOrderFieldName.ToUpper.Trim
                Case "Id_AP_bill_Head".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head Order BY " & ReceivePaymentOrderVar1 & " DESC"
                Case "Cod_Vendor".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC "
                Case "Date_Bill".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Id_AP_bill_Head from GL_AP_Bill_Head Order BY " & ReceivePaymentOrderVar1 & " DESC , " & ReceivePaymentOrderVar2 & " DESC "
            End Select
            TXTSearchReferenceNoTemp = CmdGeneral.ExecuteScalar()
            If IsNothing(TXTSearchReferenceNoTemp) Then
                TXTSearchReferenceNoTemp = ""
            End If
            If TXTSearchReferenceNoTemp = Reference_No1.Text Or TXTSearchReferenceNoTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                Reference_No1.Text = TXTSearchReferenceNoTemp
                'Call FillFields(Reference_No1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Reference_No1_FindReferenceNo() Handles Reference_No1.FindReferenceNo
        Call FillFields(Reference_No1.Text)
        'Call AfterSaveOrCancel()
    End Sub
    Private Sub SetNoRecordFind()
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnSortOrder.Enabled = False
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
            Reference_No1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmGL_AP_bill_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If BtnNew.Enabled Or PnlHead.Enabled = False Then
            Reference_No1.Text = ""
        Else
            MsgBox("First You Should Save or Cancel Information")
            e.Cancel = True
        End If
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean, Optional ByVal HeaderStatus As Boolean = True)
        If Status = MainModule.WorkStates.AddNew Then
            TxtId_AP_bill_Head.Enabled = instatus
        Else
            TxtId_AP_bill_Head.Enabled = False
        End If
        Vendor_Cod1.Enabled = instatus And HeaderStatus
        TxtRemark.Enabled = instatus
        DteDate_Bill.Enabled = instatus And HeaderStatus
        If instatus Then
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        Else
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        End If
    End Sub
    Friend Sub ClearField()
        TxtId_AP_bill_Head.Text = ""
        TxtRemark.Text = ""
        DteDate_Bill.Text = Format(Now.Date, PubDateFormat)
        Vendor_Cod1.VendorCod = ""

        LblBalance.Text = 0
        LblTotalAmount.Text = 0
        lblTotalDiscount.Text = 0

        DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Clear()
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        If CnnLock.State <> ConnectionState.Open Then
            CnnLock.Open()
        End If
        Dim tran1 As SqlClient.SqlTransaction
        Try
            tran1 = CnnLock.BeginTransaction()
            CmdGeneralLock.Transaction = tran1
            If Not SetParametersForInsertAndUpdate(True) Then
                tran1.Rollback()
                PInsert = ""
                MsgBox("Please try again")
                Exit Function
            End If
            PInsert = TxtId_AP_bill_Head.Text
            If SaveGL_AP_bill_Dtl_Dtl(TxtId_AP_bill_Head.Text) Then
                tran1.Commit()
            Else
                tran1.Rollback()
                MsgBox("Please make sure SUM of the AMOUNT of Gl distribution " & vbCrLf & "is equal to the Bill Amount before saving this record.")
                PInsert = ""
            End If
        Catch ex As System.Data.SqlClient.SqlException
            tran1.Rollback()
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisId_AP_bill_Head As String) As Boolean
        PUpdate = True
        If CnnLock.State <> ConnectionState.Open Then
            CnnLock.Open()
        End If
        Dim tran1 As SqlClient.SqlTransaction
        Try
            tran1 = CnnLock.BeginTransaction()
            CmdGeneralLock.Transaction = tran1
            If Not SetParametersForInsertAndUpdate(False) Then
                tran1.Rollback()
                PUpdate = False
                MsgBox("Please try again")
                Exit Function
            End If
            PUpdate = True
            If SaveGL_AP_bill_Dtl_Dtl(TxtId_AP_bill_Head.Text) Then
                tran1.Commit()
            Else
                tran1.Rollback()
                MsgBox("Please make sure SUM of the AMOUNT of Gl distribution " & vbCrLf & "is equal to the Bill Amount before saving this record.")
                PUpdate = False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            tran1.Rollback()
            PUpdate = False
        End Try
    End Function
    Private Function SetParametersForInsertAndUpdate(ByVal InsertFlag As Boolean) As Boolean
        SetParametersForInsertAndUpdate = True
        If InsertFlag Then
            Dim iii As Integer = 0
            For iii = 0 To 10
                CmdGeneralLock.CommandText = "INSERT INTO GL_AP_Bill_Head (Id_AP_bill_Head, cod_vendor, Date_Bill, Remark) VALUES (" & Qt(TxtId_AP_bill_Head.Text) & "," & Qt(Vendor_Cod1.VendorCod) & "," & Qt(DteDate_Bill.Text) & "," & Qt(TxtRemark.Text) & ")"
                Try
                    CmdGeneralLock.ExecuteNonQuery()
                    Exit For
                Catch ex As Exception
                    TxtId_AP_bill_Head.Text = MakeNewReferenceNo()
                End Try
            Next
            If iii = 11 Then
                SetParametersForInsertAndUpdate = False
            Else
                SetParametersForInsertAndUpdate = True
                If OldReferenceNo <> TxtId_AP_bill_Head.Text And Status = MainModule.WorkStates.AddNew Then
                    Dim MyFrmShowChangedNo As New FrmShowChangedNo
                    MyFrmShowChangedNo.LblNewNo.Text = TxtId_AP_bill_Head.Text
                    MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
                    MyFrmShowChangedNo.ShowDialog()
                End If
            End If
        Else
            CmdGeneralLock.CommandText = "UPDATE GL_AP_Bill_Head SET cod_vendor = " & Qt(Vendor_Cod1.VendorCod) & ", Date_Bill = " & Qt(DteDate_Bill.Text) & " , Remark = " & Qt(TxtRemark.Text) & " WHERE Id_AP_bill_Head = " & Qt(TxtId_AP_bill_Head.Text)
            Try
                CmdGeneralLock.ExecuteNonQuery()
            Catch ex As Exception
                SetParametersForInsertAndUpdate = False
            End Try
        End If
    End Function
    Friend Function FillFields(ByVal ThisId_AP_bill_Head As String) As Boolean
        FillFields = False
        If ThisId_AP_bill_Head.Trim.Length = 0 Then
            Exit Function
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from GL_AP_Bill_Head where Id_AP_bill_Head=" & Qt(ThisId_AP_bill_Head)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                TxtId_AP_bill_Head.Text = Trim(SQLReader.Item("Id_AP_bill_Head") & "")
                DteDate_Bill.Text = Trim(SQLReader.Item("Date_Bill") & "")
                TxtRemark.Text = Trim(SQLReader.Item("remark") & "")
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

        DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Clear()
        DAGL_AP_bill_Dtl.SelectCommand.Parameters("@Id_AP_bill_Head").Value = Reference_No1.Text
        DAGL_AP_bill_Dtl.Fill(DsFrmGL_AP_bill1.GL_AP_bill_Dtl)

        DsFrmGL_AP_bill1.GL_payment_bill_COA.Clear()
        DAGL_payment_bill_COA.SelectCommand.Parameters("@Id_AP_bill_Head").Value = Reference_No1.Text
        DAGL_payment_bill_COA.Fill(DsFrmGL_AP_bill1.GL_payment_bill_COA)

        DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Clear()
        DAGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@Id_AP_bill_Head").Value = Reference_No1.Text
        DAGL_AP_bill_Dtl_Dtl.Fill(DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl)

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT isnull(BalanceAmount,0) FROM View_Vendor_Balance WHERE cod_vendor=" & Qt(Vendor_Cod1.cod_vendor)
        LblBalance.Text = CmdGeneral.ExecuteScalar()

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
                ReceivePaymentOrderFieldName = "Id_AP_bill_Head"
                ReceivePaymentOrderVar1 = "Id_AP_bill_Head"
                ReceivePaymentOrderVar2 = ""
            Case "SORT2"
                ReceivePaymentOrderFieldName = "cod_Vendor"
                ReceivePaymentOrderVar1 = "cod_Vendor"
                ReceivePaymentOrderVar2 = "Id_AP_bill_Head"
            Case "SORT3"
                ReceivePaymentOrderFieldName = "Date_Bill"
                ReceivePaymentOrderVar1 = "Date_Bill"
                ReceivePaymentOrderVar2 = "Id_AP_bill_Head"
        End Select
    End Sub
    Private Sub TxtId_AP_bill_Head_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtId_AP_bill_Head.Leave
        Try
            MyClsReceivePayment.Connection = Cnn
        Catch ex As Exception
        End Try
        If MyClsReceivePayment.FindDesc(TxtId_AP_bill_Head.Text) Then
            MsgBox("This Reference No already axist.Try a new Code")
            TxtId_AP_bill_Head.Clear()
            TxtId_AP_bill_Head.Focus()
        End If
        OldReferenceNo = TxtId_AP_bill_Head.Text
    End Sub
    Private Function MakeNewReferenceNo() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(Id_AP_bill_Head) as Max_cod from GL_AP_Bill_Head WHERE substring(Id_AP_bill_Head,1,2)='BI'"
            MakeNewReferenceNo = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewReferenceNo, LenVendorBillReferenceNo)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewReferenceNo.Length >= i Then
                MakeNewReferenceNo = Mid(MakeNewReferenceNo, 1, Len(MakeNewReferenceNo) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewReferenceNo.Trim.Length > LenVendorBillReferenceNo Then
                MakeNewReferenceNo = "BI00000001"
            End If
        Catch ex As Exception
            MakeNewReferenceNo = "BI00000001"
        End Try
    End Function
    Private Sub Vendor_Cod1_FindVendor_Cod() Handles Vendor_Cod1.FindVendorCod
        LblVendorName.Text = Vendor_Cod1.Desc_Vendor
    End Sub
    Private Sub Vendor_Cod1_NotFindVendor_Cod() Handles Vendor_Cod1.NotFindVendorCod
        LblVendorName.Text = ""
    End Sub
    Private Sub SayTotals()
        If DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count > 0 Then
            Try
                LblTotalAmount.Text = Math.Round(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Compute("Sum(Amount)", ""), 2)
            Catch ex As Exception
                LblTotalAmount.Text = 0
            End Try
            Try
                lblTotalDiscount.Text = Math.Round(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Compute("Sum(Discount)", ""), 2)
            Catch ex As Exception
                lblTotalDiscount.Text = 0
            End Try

        End If
    End Sub
    Private Function SaveGL_AP_bill_Dtl_Dtl(ByVal ThisGL_payment_deposit_Id_AP_bill_Head As String) As Boolean
        SaveGL_AP_bill_Dtl_Dtl = True
        Try
            CmdGeneralLock.CommandText = "Delete From GL_AP_bill_Dtl Where Id_AP_bill_Head=" & Qt(ThisGL_payment_deposit_Id_AP_bill_Head)
            CmdGeneralLock.ExecuteNonQuery()

            Dim Flag_GL_account_adjustment_head_Inserted As Boolean = False
            Dim Id_AP_bill_dtlVar As Double = 0
            If DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count > 0 Then
                Dim iii As Integer = 0
                Dim i As Integer
                Dim GL_account_adjustment_head_Id_AP_bill_HeadVar As String = ""
                Dim TotalAccountAdjustmentVar As Decimal = 0
                For i = 0 To DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count - 1
                    If DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        If Trim(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("ref_no") & "").Length > 0 And DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Amount") > 0 And Trim(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("AR_terms") & "").Length > 0 Then
                            CmdGeneralLock.CommandText = "INSERT INTO GL_AP_bill_Dtl (Id_AP_bill_Head, ref_no, AR_terms, amount, Discount, Ref_date, Desc_Bill) VALUES (" & Qt(ThisGL_payment_deposit_Id_AP_bill_Head) & "," & Qt(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("ref_no")) & "," & Qt(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("AR_terms")) & "," & DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Amount") & "," & DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Discount") & "," & Qt(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Ref_Date")) & "," & Qt(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Desc_Bill")) & ");Select @@Identity from GL_AP_bill_Dtl"
                            Id_AP_bill_dtlVar = CmdGeneralLock.ExecuteScalar()
                            DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView.RowFilter = "Id_AP_bill_dtl=" & DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Id_AP_bill_dtl")
                            If DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView.Count = 0 Then
                                SaveGL_AP_bill_Dtl_Dtl = False
                                Exit For
                            End If
                            Dim GL_payment_bill_COACounter As Integer
                            For GL_payment_bill_COACounter = 0 To DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView.Count - 1
                                If DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView(GL_payment_bill_COACounter).Row.RowState <> DataRowState.Deleted Then
                                    If Trim((DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView(GL_payment_bill_COACounter).Item("GL_account") & "")).Length > 0 And Trim((DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView(GL_payment_bill_COACounter).Item("desc_GL_account") & "")).Length > 0 And DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView(GL_payment_bill_COACounter).Item("Amount") > 0 Then
                                        CmdGeneralLock.CommandText = "INSERT INTO GL_payment_bill_COA (Id_AP_bill_dtl,GL_account, Amount, Memo) VALUES (" & Id_AP_bill_dtlVar & "," & Qt(DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView(GL_payment_bill_COACounter).Item("GL_account")) & "," & DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView(GL_payment_bill_COACounter).Item("Amount") & "," & Qt(DsFrmGL_AP_bill1.GL_payment_bill_COA.DefaultView(GL_payment_bill_COACounter).Item("Memo")) & ")"
                                        CmdGeneralLock.ExecuteNonQuery()
                                    End If
                                End If
                            Next
                            If Not CalcDueDetail(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("AR_terms"), DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Amount") - DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Discount"), DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("Ref_date"), DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl) Then
                                SaveGL_AP_bill_Dtl_Dtl = False
                                Exit For
                            End If
                            Dim Due_DetailCounter As Integer
                            For Due_DetailCounter = 0 To DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Rows.Count - 1
                                If DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl(Due_DetailCounter).RowState <> DataRowState.Deleted Then
                                    CmdGeneralLock.CommandText = "INSERT INTO GL_AP_bill_Dtl_Dtl (Id_AP_bill_dtl, amount, due_date) VALUES (" & Id_AP_bill_dtlVar & "," & DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Rows(Due_DetailCounter).Item("Amount") & "," & Qt(DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Rows(Due_DetailCounter).Item("due_date")) & ")"
                                    CmdGeneralLock.ExecuteNonQuery()
                                End If
                            Next
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            SaveGL_AP_bill_Dtl_Dtl = False
        End Try

    End Function
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Reference_No1.BtnSearch_Click(sender, e)
    End Sub
    Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
        'GrdDetail.UpdateData()
        'Call SayTotals()
        'Call SaveButtonControl()

        Try
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            Select Case e.Column.Index
                Case 1
                    'GrdDetail.UpdateData()
                    Dim ThisdueDateTempVar As String = ""
                    If CalcDueDetail(CurrentRow.Cells("AR_terms").Value, CurrentRow.Cells.Item("Amount").Value - CurrentRow.Cells.Item("Discount").Value, CurrentRow.Cells("Ref_date").Value, DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                        CurrentRow.BeginEdit()
                        CurrentRow.Cells("Min_due_date").Value = ThisdueDateTempVar
                        CurrentRow.EndEdit()
                    End If
                Case 2
                    'GrdDetail.UpdateData()
                    Dim ThisdueDateTempVar As String = ""
                    'If CalcDueDetail(BeforeRowEx.Cells("AR_terms").Value, BeforeRowEx.Cells.Item("Amount").Value - BeforeRowEx.Cells.Item("Discount").Value, BeforeRowEx.Cells("Ref_date").Value, DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                    'If CalcDueDetail(CurrentRow.Cells("AR_terms").Value, CurrentRow.Cells.Item("Amount").Value - CurrentRow.Cells.Item("Discount").Value, CurrentRow.Cells("Ref_date").Value, DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                    If CalcDueDetail(CurrentRow.Cells("AR_terms").Value, CurrentRow.Cells.Item("Amount").Value - CurrentRow.Cells.Item("Discount").Value, DteDateForGrid.Text & "", DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                        CurrentRow.BeginEdit()
                        CurrentRow.Cells("Min_due_date").Value = ThisdueDateTempVar
                        CurrentRow.EndEdit()
                    End If
                Case 5
                    'GrdDetail.UpdateData()
                    Dim ThisdueDateTempVar As String = ""
                    'If CalcDueDetail(BeforeRowEx.Cells("AR_terms").Value, BeforeRowEx.Cells.Item("Amount").Value - BeforeRowEx.Cells.Item("Discount").Value, BeforeRowEx.Cells("Ref_date").Value, DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                    'If CalcDueDetail(CurrentRow.Cells("AR_terms").Value, CurrentRow.Cells.Item("Amount").Value - CurrentRow.Cells.Item("Discount").Value, CurrentRow.Cells("Ref_date").Value, DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                    If CalcDueDetail(CmbAR_terms.Text, CurrentRow.Cells.Item("Amount").Value - CurrentRow.Cells.Item("Discount").Value, CurrentRow.Cells("Ref_date").Value, DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                        CurrentRow.BeginEdit()
                        CurrentRow.Cells("Min_due_date").Value = ThisdueDateTempVar
                        CurrentRow.EndEdit()
                    End If
            End Select
        Catch ex As Exception
        End Try


    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        GrdDetail.UpdateData()
        Call SayTotals()
        Call SaveButtonControl()
        'Try
        '    lblTotalPayment.Text = Math.Round(DsFrmReceivePayment1.GridRecord.Compute("Sum(Payment)", "AmountDue>0 AND CheckFlag=1"), 2)
        'Catch ex As Exception
        '    lblTotalPayment.Text = 0
        'End Try
        Dim ValueString As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        If BeforeRowEx Is Nothing Or BeforeCel < 0 Or BeforeRow < 0 Then
            Exit Sub
        End If

        Try
            'ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
            'Call CalcSumOfExt_price()
            Select Case BeforeCel
                Case 1
                    Dim ThisdueDateTempVar As String = ""
                    If CalcDueDetail(BeforeRowEx.Cells("AR_terms").Value, BeforeRowEx.Cells.Item("Amount").Value - BeforeRowEx.Cells.Item("Discount").Value, BeforeRowEx.Cells("Ref_date").Value, DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl, True, ThisdueDateTempVar) Then
                        BeforeRowEx.Cells("Min_due_date").Value = ThisdueDateTempVar
                    End If
            End Select
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        'Call EnableDisableSave()
        Call InitBeforeRow()
        'Call CalcSumOfExt_price()
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
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

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT count(*) FROM GL_AP_Bill_Head where Id_AP_bill_Head=" & Qt(TxtId_AP_bill_Head.Text)

        If CmdGeneral.ExecuteScalar <> 1 Then
            MsgBox("Please Save Befor " & PrintType)
            Exit Sub
        End If

        If DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim rpt As New RepApBill
        Dim prn As New FrmRepView

        rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")
        rpt.SetParameterValue("ParDate", DteDate_Bill.Text & "")
        rpt.SetParameterValue("ParVendorName", LblVendorName.Text & "")
        rpt.SetDataSource(DsFrmGL_AP_bill1)
        Select Case PrintType.ToUpper
            Case "print".ToUpper
                rpt.PrintToPrinter(1, True, 0, 0)
            Case "preview".ToUpper
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
            Case "fax".ToUpper
                Try
                    rpt.PrintOptions.PrinterName = "Fax"
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception
                    MsgBox("Add The FAX in (Printers and Faxes)")
                End Try
        End Select
    End Sub
    Private Function CanChangeOrDelete(ByVal DeleteStatusFlag As Boolean) As Boolean
        CanChangeOrDelete = True
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT COUNT(*) FROM GL_AP_payment WHERE (Id_AP_bill_dtl_dtl IN (SELECT GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl FROM   GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl WHERE  GL_AP_bill_Dtl.Id_AP_bill_Head = " & Qt(TxtId_AP_bill_Head.Text) & "))"
        If CmdGeneral.ExecuteScalar > 0 Then
            CanChangeOrDelete = False
            MsgBox("This Payment Was Passed")
        End If
    End Function
    Private Sub BtnVendorBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVendorBalance.Click
        Dim MyFrmVendorBalance As New FrmVendorBalance
        MyFrmVendorBalance.cod_vendorParameter = Vendor_Cod1.VendorCod
        MyFrmVendorBalance.LblVendor.Text = Vendor_Cod1.VendorCod
        MyFrmVendorBalance.LblName.Text = Vendor_Cod1.Desc_Vendor
        MyFrmVendorBalance.ShowDialog()
    End Sub
    Private Sub CmbAR_terms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAR_terms.Enter
        Dim row As GridEXRow = GrdDetail.GetRow
        CmbAR_terms.Focus()
        ' nothing
    End Sub
    Private Sub GrdDetail_InitCustomEdit(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.InitCustomEditEventArgs) Handles GrdDetail.InitCustomEdit
        Select Case sender.CurrentColumn.Key
            Case "Ref_date"
                If e.EditChar <> Nothing Then
                    DteDateForGrid.Text = e.Value.ToString()
                Else
                    If e.Value Is Nothing Then
                        DteDateForGrid.Text = ""
                    Else

                        DteDateForGrid.Text = e.Value.ToString()
                    End If
                End If
                e.EditControl = DteDateForGrid
                'SendKeys.Send("{Space}")
            Case "AR_terms"
                If e.EditChar <> Nothing Then
                    CmbAR_terms.Text = e.Value.ToString()
                Else
                    If e.Value Is Nothing Then
                        CmbAR_terms.Text = ""
                    Else
                        CmbAR_terms.Text = e.Value.ToString()
                    End If
                End If
                e.EditControl = CmbAR_terms
                'SendKeys.Send("{Space}")
            Case "Min_due_date"
                If e.EditChar <> Nothing Then
                    DteDueDateForGrid.Text = e.Value.ToString()
                Else
                    If e.Value Is Nothing Then
                        DteDueDateForGrid.Text = ""
                    Else

                        DteDueDateForGrid.Text = e.Value.ToString()
                    End If
                End If
                e.EditControl = DteDueDateForGrid
                'SendKeys.Send("{Space}")
        End Select
    End Sub
    Private Sub GrdDetail_EndCustomEdit(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EndCustomEditEventArgs) Handles GrdDetail.EndCustomEdit
        Select Case sender.CurrentColumn.Key
            Case "Ref_date"
                Try
                    If DteDateForGrid.Text.CompareTo(e.Value.ToString) <> False Then
                        e.DataChanged = True
                        e.Value = DteDateForGrid.Text
                    End If
                Catch ex As System.ArgumentException
                Catch ex As Exception
                    MsgBox(ex.Message() + "    " + ex.GetType.ToString + "   ")
                End Try
            Case "AR_terms"
                Try
                    If CmbAR_terms.Text.CompareTo(e.Value.ToString) <> False Then
                        e.DataChanged = True
                        e.Value = CmbAR_terms.Text
                    End If
                Catch ex As System.ArgumentException
                Catch ex As Exception
                    MsgBox(ex.Message() + "    " + ex.GetType.ToString + "   ")
                End Try
            Case "Min_due_date"
                Try
                    If DteDueDateForGrid.Text.CompareTo(e.Value.ToString) <> False Then
                        e.DataChanged = True
                        e.Value = DteDueDateForGrid.Text
                    End If
                Catch ex As System.ArgumentException
                Catch ex As Exception
                    MsgBox(ex.Message() + "    " + ex.GetType.ToString + "   ")
                End Try
        End Select
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        GrdDetail.UpdateData()
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Select Case e.Column.Key.ToUpper
            Case "BTNCOA"
                MyFrmGL_AP_billCOA = New FrmGL_AP_billCOA
                If TxtRemark.Enabled = False Then
                    MyFrmGL_AP_billCOA.ThisFormStatus = MainModule.WorkStates._ReadOnly
                End If
                MyFrmGL_AP_billCOA.OriginalDS = DsFrmGL_AP_bill1
                MyFrmGL_AP_billCOA.Id_AP_bill_dtlVar = ThisRowGrid.Cells("Id_AP_bill_dtl").Value

                Dim PntForm As Point
                Dim PntLocation As Point
                Dim OControl As Control
                Dim SizeForm As Size
                OControl = GrdDetail

                SizeForm.Width = MyFrmGL_AP_billCOA.Width
                SizeForm.Height = MyFrmGL_AP_billCOA.Height
                PntLocation.X = OControl.Location.X + 180
                PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2 + ((e.Column.GridEX.Row() + 2) * GrdDetail.RootTable.RowHeight) - OControl.Size.Height - 1


                PntForm = OControl.Parent.PointToScreen(PntLocation)
                If PntForm.Y + SizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
                    PntForm.Y = PntForm.Y - SizeForm.Height - GrdDetail.RootTable.RowHeight
                End If
                If (PntForm.X < 0) Then PntForm.X = 0
                MyFrmGL_AP_billCOA.SetDesktopLocation(PntForm.X, PntForm.Y)
                MyFrmGL_AP_billCOA.Left = PntForm.X
                MyFrmGL_AP_billCOA.Top = PntForm.Y

                MyFrmGL_AP_billCOA.TotalVar = ThisRowGrid.Cells("Amount").Value - ThisRowGrid.Cells("Discount").Value
                MyFrmGL_AP_billCOA.ShowDialog()
            Case "BTNDETAIL"
                MyFrmShowPaymentDetail = New FrmShowPaymentDetail
                MyFrmShowPaymentDetail.AR_termsVar = ThisRowGrid.Cells("AR_terms").Value
                MyFrmShowPaymentDetail.AmountVar = ThisRowGrid.Cells("Amount").Value - ThisRowGrid.Cells("Discount").Value
                MyFrmShowPaymentDetail.Ref_dateVar = ThisRowGrid.Cells("Ref_date").Value
                MyFrmShowPaymentDetail.Id_AP_bill_dtlVar = ThisRowGrid.Cells("Id_AP_bill_dtl").Value
                MyFrmShowPaymentDetail.OriginalDS = DsFrmGL_AP_bill1

                Dim PntForm As Point
                Dim PntLocation As Point
                Dim OControl As Control
                Dim SizeForm As Size
                OControl = GrdDetail

                SizeForm.Width = MyFrmShowPaymentDetail.Width
                SizeForm.Height = MyFrmShowPaymentDetail.Height
                PntLocation.X = OControl.Location.X + 550
                PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2 + ((e.Column.GridEX.Row() + 2) * GrdDetail.RootTable.RowHeight) - OControl.Size.Height - 1


                PntForm = OControl.Parent.PointToScreen(PntLocation)
                If PntForm.Y + SizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
                    PntForm.Y = PntForm.Y - SizeForm.Height - GrdDetail.RootTable.RowHeight
                End If
                If (PntForm.X < 0) Then PntForm.X = 0
                MyFrmShowPaymentDetail.SetDesktopLocation(PntForm.X, PntForm.Y)
                MyFrmShowPaymentDetail.Left = PntForm.X
                MyFrmShowPaymentDetail.Top = PntForm.Y
                MyFrmShowPaymentDetail.ShowDialog()
                'DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(e.Column.GridEX.Row()).Item("Min_due_date") = MyFrmGL_AP_billCOA.Id_AP_bill_dtlVar
        End Select
    End Sub

    Private Sub GrdDetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdDetail.KeyDown
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            '-------------------------------------------------------------
            Select Case e.Control
                Case True
                    'Select Case e.KeyCode
                    '    Case Keys.Delete
                    '        Call DeleteThisRecord()
                    '    Case Keys.Insert
                    '        Call InsertThisRecord()
                    'End Select
                Case False
                    If e.Shift = False And e.Control = False And e.Alt = False Then
                        Select Case e.KeyCode
                            Case Keys.F2
                                Select Case GrdDetail.Col
                                    Case 1
                                End Select
                            Case Keys.Enter
                                Select Case GrdDetail.Col
                                    Case 3
                                        'SelectRow(GrdDetail.Row, 4)
                                End Select
                            Case Keys.Tab
                                Select Case GrdDetail.Col
                                    Case 3
                                        'SelectRow(GrdDetail.Row, 4)
                                End Select
                        End Select
                    End If
            End Select
        End If
    End Sub
    Sub SelectRow(ByVal ThisRow As Integer, Optional ByVal ThisItemCodeFocus As Integer = 4)
        GrdDetail.Focus()
        GrdDetail.Row = ThisRow
        GrdDetail.Col = ThisItemCodeFocus
        GrdDetail.SelectCurrentCellText()
    End Sub
    Private Sub Vendor_Cod1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Vendor_Cod1.Leave
        Dim i As Integer
        For i = 0 To DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows.Count - 1
            If DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).RowState <> DataRowState.Deleted Then
                If Trim(DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("AR_terms") & "").Length = 0 Then
                    DsFrmGL_AP_bill1.GL_AP_bill_Dtl.Rows(i).Item("AR_terms") = Vendor_Cod1.Ap_terms
                End If
            End If
        Next
    End Sub
    Private Sub GrdDetail_Error(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ErrorEventArgs) Handles GrdDetail.Error
        'MsgBox(e.ErrorMessage)
    End Sub
    Private Sub MenuItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDelete.Click
        If BtnNew.Enabled = False Then
            Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow

            Dim i As Integer
            For i = 0 To DsFrmGL_AP_bill1.GL_payment_bill_COA.Count - 1
                If DsFrmGL_AP_bill1.GL_payment_bill_COA.Rows(i).Item("Id_AP_bill_dtl") = ThisRowGrid.Cells("Id_AP_bill_dtl").Value Then
                    DsFrmGL_AP_bill1.GL_payment_bill_COA.Rows(i).Item("Id_AP_bill_dtl") = 0
                    DsFrmGL_AP_bill1.GL_payment_bill_COA.Rows(i).Item("GL_account") = ""
                    DsFrmGL_AP_bill1.GL_payment_bill_COA.Rows(i).Item("Amount") = 0
                    DsFrmGL_AP_bill1.GL_payment_bill_COA.Rows(i).Item("Memo") = ""
                    DsFrmGL_AP_bill1.GL_payment_bill_COA.Rows(i).Item("desc_GL_account") = ""
                End If
            Next
            For i = 0 To DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Count - 1
                If DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Rows(i).Item("Id_AP_bill_dtl") = ThisRowGrid.Cells("Id_AP_bill_dtl").Value Then
                    DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Rows(i).Item("Id_AP_bill_dtl") = 0
                    DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Rows(i).Item("due_date") = ""
                    DsFrmGL_AP_bill1.GL_AP_bill_Dtl_Dtl.Rows(i).Item("Amount") = 0
                End If
            Next

            Dim foundRow As DataRow
            foundRow = DsFrmGL_AP_bill1.GL_AP_bill_Dtl.FindById_AP_bill_dtl(ThisRowGrid.Cells("Id_AP_bill_dtl").Value)
            If Not (foundRow Is Nothing) Then
                foundRow("ref_no") = ""
                foundRow("amount") = 0
                foundRow("Desc_Bill") = "Purchases"
                foundRow("Discount") = 0
                foundRow("Ref_date") = DteDate_Bill.Text
                foundRow("Min_due_date") = ""
                foundRow("id_GL_journal") = 0
                foundRow("AR_terms") = Vendor_Cod1.Ap_terms
            End If
            Call SayTotals()
        End If
    End Sub
End Class
