Imports System.Web.Mail
Imports Janus.Windows.GridEX
Imports CommonClass
Imports UCCommentButton
Public Class FrmWorkOrders
    Inherits FrmBase
    Dim MyFrmItemComments As CommonClass.FrmItemComments
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
    Dim WithEvents MyFrmSearchcod_pakage As New UCInv_Package.FrmSearchcod_pakage
    Dim WithEvents MyFrmSearchItemCode As New UCInv_Item.FrmSearchItemCode
    Dim WithEvents MyFrmSearchServiceCode As New UCLabor_Service.FrmSearchLabor_ServiceCod
    Dim WithEvents MyFrmFindServiceRecords As New FrmFindServiceRecords
    Dim WithEvents MyFrmSearchReadyComments As New UCInv_Package.FrmSearchReadyComments
    Dim WithEvents MyFrmGetStyle As New FrmGetStyle

    Dim Mylabor_service As UCLabor_Service.ClsLabor_ServiceCod
    Dim WithEvents MyItem As UCInv_Item.Clsitem_no
    Dim WithEvents MyReadyComment As UCInv_Package.ClsCod_pakage
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Dim WithEvents MyPackage As UCInv_Package.ClsCod_pakage
    Public MTypeOfForm As String

    Dim RowNoToAdd As Double = 25
    Dim MaxRowNo As Double = RowNoToAdd

    Dim Invoice_NO_Default_For_Outside_Purchase As String = ""
    Dim Invoice_Date_Default_For_Outside_Purchase As String = ""
    Dim Po_No_Default_For_Outside_Purchase As String = ""
    Dim Due_Date_Default_For_Outside_Purchase As String = ""
    Dim Markup_Default_For_Outside_Purchase As Decimal = 0
    Dim Vendor_Default_For_Outside_Purchase As String = ""
    Dim Line_Default_For_Outside_Purchase As String = ""
    Dim CanChangeCustomerNameFlag As Boolean = True

    Dim InvoiceNoForReturnVar As String = ""
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property
    Dim FlagResetTaxVar As Boolean = False
    Dim VehicleColorVar As String
    Dim UnitNoVar As String
    Dim Desc_kind_engineVar As String
    Dim PreviousMileageVar As String
    Dim FlgInShowOutsidePurchase As Boolean = True
    Dim FlgInShowTireAdjustment As Boolean = True
    Dim DefaultTax_AmountVar As Decimal = 0
    Dim CHKRULES_USE_CREDIT_LIMITEDVar As Boolean = False
    Dim CHKRULES_For_Warn_Qty_Var As Boolean = False
    Dim CHKItemDescriptionFlagVar As Boolean = False
    Dim CHKServiceDescriptionFlagVar As Boolean = False
    Dim ReturnWasSavedFlag As Boolean = False
    Dim FirstPrint As Boolean = True
    Dim OldReferenceNo As String = ""
    Dim DownPaymentVar As Decimal = 0

    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Dim emailPath As String = CType(configurationAppSettings.GetValue("EmailPath", GetType(System.String)), String).Trim & "\"

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
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents CmbType As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents LblType As System.Windows.Forms.TextBox
    Friend WithEvents DsFrmWorkOrders1 As ServiceCenterScreen.DSFrmWorkOrders
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents TxtDate As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents LblCustomerCompanyname As System.Windows.Forms.Label
    Friend WithEvents CommentButton_Customer As UCCommentButton.CommentButton
    Friend WithEvents CommentButton_House As UCCommentButton.CommentButton
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnFax As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents BtnCashier As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnPriceTires As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCashierCopy As System.Windows.Forms.Button
    Friend WithEvents BtnPriceTiresCopy As System.Windows.Forms.Button
    Friend WithEvents BtnCustomerBalance As System.Windows.Forms.Button
    Friend WithEvents BtnCustomerHistory As System.Windows.Forms.Button
    Friend WithEvents BtnCustomerDetail As System.Windows.Forms.Button
    Friend WithEvents BtnVehicleDetail As System.Windows.Forms.Button
    Friend WithEvents BtnVehicleHistory As System.Windows.Forms.Button
    Friend WithEvents BtnLaborGuide As System.Windows.Forms.Button
    Friend WithEvents LblVehicleYear As System.Windows.Forms.Label
    Friend WithEvents LblVehicleVin As System.Windows.Forms.Label
    Friend WithEvents LblVehicleModel As System.Windows.Forms.Label
    Friend WithEvents LblVehicleMake As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtPo_No As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtCustomerFName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerLName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerMName As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents BtnConvert As System.Windows.Forms.Button
    Friend WithEvents DsFrmCashier1 As ServiceCenterScreen.DSFrmCashier
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_Center_Head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CnnReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents License_No1 As UCVehicle.License_No
    Friend WithEvents PhoneNoMain As UCPhone.PhoneNo
    Friend WithEvents PhoneButton1 As UCPhone.PhoneButton
    Friend WithEvents BtnFindSize As System.Windows.Forms.Button
    Friend WithEvents NumCurrent_mileage As CalcUtils.UcCalcText
    Friend WithEvents NumTax As CalcUtils.UcCalcText
    Friend WithEvents NumDiscount As CalcUtils.UcCalcText
    Friend WithEvents LblTotal As CalcUtils.UcCalcText
    Friend WithEvents LblSubtotal As CalcUtils.UcCalcText
    Friend WithEvents LblFET As CalcUtils.UcCalcText
    Friend WithEvents LblFees As CalcUtils.UcCalcText
    Friend WithEvents LblLabor As CalcUtils.UcCalcText
    Friend WithEvents LblParts As CalcUtils.UcCalcText
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_style As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_pakage As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_out_purchases As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItemDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInsert As System.Windows.Forms.MenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_Center_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_tire_adjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbAddUser As System.Windows.Forms.ComboBox
    Friend WithEvents DaUsers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CmbChgUser As System.Windows.Forms.ComboBox
    Friend WithEvents LblStoreName As System.Windows.Forms.Label
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnDownPayment As System.Windows.Forms.Button
    Friend WithEvents CmdGeneralLock As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnLock As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGeneralLock As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BtnResetTax As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmWorkOrders))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItemDelete = New System.Windows.Forms.MenuItem
        Me.MenuItemInsert = New System.Windows.Forms.MenuItem
        Me.DsFrmWorkOrders1 = New ServiceCenterScreen.DSFrmWorkOrders
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblStoreName = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbType = New Janus.Windows.EditControls.UIComboBox
        Me.LblType = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnResetTax = New System.Windows.Forms.Button
        Me.PhoneNoMain = New UCPhone.PhoneNo
        Me.CmbChgUser = New System.Windows.Forms.ComboBox
        Me.CmbAddUser = New System.Windows.Forms.ComboBox
        Me.PhoneButton1 = New UCPhone.PhoneButton
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.TxtCustomerLName = New System.Windows.Forms.TextBox
        Me.TxtCustomerFName = New System.Windows.Forms.TextBox
        Me.BtnDownPayment = New System.Windows.Forms.Button
        Me.LblCustomerCompanyname = New System.Windows.Forms.Label
        Me.BtnCashierCopy = New System.Windows.Forms.Button
        Me.BtnPriceTiresCopy = New System.Windows.Forms.Button
        Me.TxtPo_No = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CommentButton_Customer = New UCCommentButton.CommentButton
        Me.CommentButton_House = New UCCommentButton.CommentButton
        Me.BtnCustomerBalance = New System.Windows.Forms.Button
        Me.BtnCustomerHistory = New System.Windows.Forms.Button
        Me.BtnCustomerDetail = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtCustomerMName = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.NumCurrent_mileage = New CalcUtils.UcCalcText
        Me.License_No1 = New UCVehicle.License_No
        Me.LblVehicleYear = New System.Windows.Forms.Label
        Me.LblVehicleVin = New System.Windows.Forms.Label
        Me.LblVehicleModel = New System.Windows.Forms.Label
        Me.LblVehicleMake = New System.Windows.Forms.Label
        Me.BtnVehicleDetail = New System.Windows.Forms.Button
        Me.BtnVehicleHistory = New System.Windows.Forms.Button
        Me.BtnFindSize = New System.Windows.Forms.Button
        Me.BtnLaborGuide = New System.Windows.Forms.Button
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LblTotal = New CalcUtils.UcCalcText
        Me.NumDiscount = New CalcUtils.UcCalcText
        Me.NumTax = New CalcUtils.UcCalcText
        Me.LblSubtotal = New CalcUtils.UcCalcText
        Me.LblFET = New CalcUtils.UcCalcText
        Me.LblFees = New CalcUtils.UcCalcText
        Me.LblLabor = New CalcUtils.UcCalcText
        Me.LblParts = New CalcUtils.UcCalcText
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtDate = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label38 = New System.Windows.Forms.Label
        Me.BtnConvert = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnFax = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.BtnCashier = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnPriceTires = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmCashier1 = New ServiceCenterScreen.DSFrmCashier
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAService_Center_Head = New System.Data.SqlClient.SqlDataAdapter
        Me.CnnReader = New System.Data.SqlClient.SqlConnection
        Me.CmdReader = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_style = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_pakage = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_out_purchases = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAService_Center_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAService_tire_adjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.DaUsers = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdGeneralLock = New System.Data.SqlClient.SqlCommand
        Me.CnnLock = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGeneralLock = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmWorkOrders1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmCashier1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.ContextMenu = Me.ContextMenu1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "service_center_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmWorkOrders1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""type_select""><Caption>Type</Caption><DataMember>type_se" & _
        "lect</DataMember><DefaultGroupInterval>Text</DefaultGroupInterval><EditType>Mult" & _
        "iColumnDropDown</EditType><Key>type_select</Key><Position>0</Position><CompareTa" & _
        "rget>Text</CompareTarget><Width>34</Width><DropDownIndex>1</DropDownIndex></Colu" & _
        "mn0><Column1 ID=""Hst""><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><" & _
        "Caption>Hst</Caption><DataMember>Hst</DataMember><EditType>NoEdit</EditType><Key" & _
        ">Hst</Key><Position>1</Position><Selectable>False</Selectable><Width>27</Width><" & _
        "/Column1><Column2 ID=""Cm""><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonSty" & _
        "le><Caption>Cm</Caption><EditType>NoEdit</EditType><Key>Cm</Key><Position>2</Pos" & _
        "ition><Selectable>False</Selectable><Width>27</Width></Column2><Column3 ID=""Det""" & _
        "><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><Caption>Det</Caption>" & _
        "<EditType>NoEdit</EditType><Key>Det</Key><Position>3</Position><Selectable>False" & _
        "</Selectable><Width>27</Width></Column3><Column4 ID=""cod_select""><Caption>Item N" & _
        "o</Caption><DataMember>cod_select</DataMember><Key>cod_select</Key><MaxLength>20" & _
        "</MaxLength><Position>4</Position><Width>76</Width><CellStyle><BackColor>Silver<" & _
        "/BackColor></CellStyle></Column4><Column5 ID=""desc_radif""><Caption>Description</" & _
        "Caption><DataMember>desc_radif</DataMember><Key>desc_radif</Key><MaxLength>100</" & _
        "MaxLength><Position>5</Position><Width>173</Width></Column5><Column6 ID=""qty""><C" & _
        "aption>Qty</Caption><DataMember>qty</DataMember><InputMask>Number2</InputMask><K" & _
        "ey>qty</Key><MaskPrompt>&#x0;</MaskPrompt><Position>6</Position><Width>36</Width" & _
        "><CellStyle><BackColor>Silver</BackColor></CellStyle></Column6><Column7 ID=""pric" & _
        "e""><Caption>Price</Caption><DataMember>price</DataMember><FormatString>c2</Forma" & _
        "tString><InputMask>Currency2</InputMask><Key>price</Key><MaskPrompt>&#x0;</MaskP" & _
        "rompt><Position>7</Position><Width>60</Width></Column7><Column8 ID=""fet""><Captio" & _
        "n>FET</Caption><DataMember>fet</DataMember><FormatString>c2</FormatString><Input" & _
        "Mask>Currency2</InputMask><Key>fet</Key><Position>8</Position><Width>40</Width><" & _
        "CellStyle><BackColor>Silver</BackColor></CellStyle></Column8><Column9 ID=""taxabl" & _
        "e""><Caption>T</Caption><ColumnType>CheckBox</ColumnType><DataMember>taxable</Dat" & _
        "aMember><EditType>CheckBox</EditType><Key>taxable</Key><Position>9</Position><Wi" & _
        "dth>16</Width></Column9><Column10 ID=""Ext_Price""><Caption>Ext_Price</Caption><Da" & _
        "taMember>Ext_Price</DataMember><FormatString>c</FormatString><InputMask>Currency" & _
        "2</InputMask><Key>Ext_Price</Key><MaskPrompt>&#x0;</MaskPrompt><Position>10</Pos" & _
        "ition><Selectable>False</Selectable><Width>66</Width></Column10><Column11 ID=""co" & _
        "d_technician""><Caption>Tech</Caption><DataMember>cod_technician</DataMember><Def" & _
        "aultGroupInterval>Text</DefaultGroupInterval><EditType>MultiColumnCombo</EditTyp" & _
        "e><Key>cod_technician</Key><Position>11</Position><CompareTarget>Text</CompareTa" & _
        "rget><Width>41</Width><DropDownIndex>0</DropDownIndex></Column11><Column12 ID=""i" & _
        "d_service_center""><Caption>id_service_center</Caption><TypeNameEmptyStringValue>" & _
        "NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>id_service_center" & _
        "</DataMember><Key>id_service_center</Key><Position>12</Position><Visible>False</" & _
        "Visible></Column12><Column13 ID=""radif""><Caption>radif</Caption><TypeNameEmptySt" & _
        "ringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>radif</" & _
        "DataMember><Key>radif</Key><Position>13</Position><Visible>False</Visible></Colu" & _
        "mn13><Column14 ID=""FlagIsPackage""><Caption>FlagIsPackage</Caption><DataMember>Fl" & _
        "agIsPackage</DataMember><EditType>NoEdit</EditType><Key>FlagIsPackage</Key><Posi" & _
        "tion>14</Position><Visible>False</Visible></Column14><Column15 ID=""PricePlusFet""" & _
        "><Caption>PricePlusFet</Caption><DataMember>PricePlusFet</DataMember><Key>PriceP" & _
        "lusFet</Key><Position>15</Position><Visible>False</Visible></Column15></Columns>" & _
        "<GroupCondition ID="""" /><Key>service_center_dtl</Key><RowHeight>19</RowHeight><S" & _
        "ortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>13</ColIndex></SortK" & _
        "ey0></SortKeys></RootTable><DropDowns Collection=""true""><DropDown0><RootTable><C" & _
        "olumns Collection=""true""><Column0 ID=""employee_code""><Caption>Code</Caption><Typ" & _
        "eNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue " & _
        "/><DataMember>employee_code</DataMember><Key>employee_code</Key><Position>0</Pos" & _
        "ition><Width>40</Width></Column0><Column1 ID=""employee_Name""><Caption>Name</Capt" & _
        "ion><DataMember>employee_Name</DataMember><EditType>NoEdit</EditType><Key>employ" & _
        "ee_Name</Key><Position>1</Position><Width>220</Width></Column1></Columns><GroupC" & _
        "ondition ID="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans Serif, 8.25p" & _
        "t</Font><ControlStyle /><AllowEdit>False</AllowEdit><ExpandableGroups>False</Exp" & _
        "andableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlig" & _
        "ht</HideSelection><Key>DropDownTechnician</Key><DisplayMember>employee_code</Dis" & _
        "playMember><ValueMember>employee_code</ValueMember></DropDown0><DropDown1><RootT" & _
        "able><Columns Collection=""true""><Column0 ID=""Code""><Caption>Type</Caption><DataM" & _
        "ember>Code</DataMember><Key>Code</Key><Position>0</Position><Width>40</Width></C" & _
        "olumn0><Column1 ID=""Desc""><Caption>Description</Caption><DataMember>Desc</DataMe" & _
        "mber><Key>Desc</Key><Position>1</Position></Column1></Columns><GroupCondition ID" & _
        "="""" /></RootTable><WatermarkImage /><Font>Microsoft Sans Serif, 8.25pt</Font><Co" & _
        "ntrolStyle /><AllowEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGrou" & _
        "ps><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</HideSel" & _
        "ection><Key>DropDownTypeSelect</Key><DisplayMember>Code</DisplayMember><ValueMem" & _
        "ber>Code</ValueMember></DropDown1></DropDowns></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 193)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(647, 256)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemDelete, Me.MenuItemInsert})
        '
        'MenuItemDelete
        '
        Me.MenuItemDelete.Index = 0
        Me.MenuItemDelete.Text = "Delete This Record"
        '
        'MenuItemInsert
        '
        Me.MenuItemInsert.Index = 1
        Me.MenuItemInsert.Text = "Insert A Record"
        '
        'DsFrmWorkOrders1
        '
        Me.DsFrmWorkOrders1.DataSetName = "DSFrmWorkOrders"
        Me.DsFrmWorkOrders1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'LblCompanyName
        '
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Location = New System.Drawing.Point(0, 45)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(147, 25)
        Me.LblCompanyName.TabIndex = 123
        Me.LblCompanyName.Text = "LblCompanyName"
        Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(148, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 25)
        Me.Label2.TabIndex = 124
        '
        'LblStoreName
        '
        Me.LblStoreName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreName.Location = New System.Drawing.Point(546, 45)
        Me.LblStoreName.Name = "LblStoreName"
        Me.LblStoreName.Size = New System.Drawing.Size(101, 25)
        Me.LblStoreName.TabIndex = 125
        Me.LblStoreName.Text = "Store Name"
        Me.LblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(319, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(425, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 22)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Ref"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtRef
        '
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Enabled = False
        Me.TxtRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(449, 47)
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.Size = New System.Drawing.Size(92, 21)
        Me.TxtRef.TabIndex = 129
        Me.TxtRef.Text = ""
        Me.TxtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(151, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 20)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Type"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbType
        '
        Me.CmbType.BorderStyle = Janus.Windows.UI.BorderStyle.Flat
        Me.CmbType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.CmbType.Enabled = False
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.Text = "WO"
        UiComboBoxItem1.Value = "Work Order"
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.Text = "ES"
        UiComboBoxItem2.Value = "Estimates"
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.Text = "IN"
        UiComboBoxItem3.Value = "Invoices"
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.Text = "RT"
        UiComboBoxItem4.Value = "Returns"
        Me.CmbType.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2, UiComboBoxItem3, UiComboBoxItem4})
        Me.CmbType.Location = New System.Drawing.Point(180, 47)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(48, 20)
        Me.CmbType.TabIndex = 131
        Me.CmbType.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'LblType
        '
        Me.LblType.BackColor = System.Drawing.Color.MediumTurquoise
        Me.LblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblType.Location = New System.Drawing.Point(228, 47)
        Me.LblType.Name = "LblType"
        Me.LblType.ReadOnly = True
        Me.LblType.Size = New System.Drawing.Size(91, 21)
        Me.LblType.TabIndex = 132
        Me.LblType.Text = "Work Order"
        Me.LblType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnResetTax)
        Me.Panel1.Controls.Add(Me.PhoneNoMain)
        Me.Panel1.Controls.Add(Me.CmbChgUser)
        Me.Panel1.Controls.Add(Me.CmbAddUser)
        Me.Panel1.Controls.Add(Me.PhoneButton1)
        Me.Panel1.Controls.Add(Me.CustomerCod1)
        Me.Panel1.Controls.Add(Me.TxtCustomerLName)
        Me.Panel1.Controls.Add(Me.TxtCustomerFName)
        Me.Panel1.Controls.Add(Me.BtnDownPayment)
        Me.Panel1.Controls.Add(Me.LblCustomerCompanyname)
        Me.Panel1.Controls.Add(Me.BtnCashierCopy)
        Me.Panel1.Controls.Add(Me.BtnPriceTiresCopy)
        Me.Panel1.Controls.Add(Me.TxtPo_No)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CommentButton_Customer)
        Me.Panel1.Controls.Add(Me.CommentButton_House)
        Me.Panel1.Controls.Add(Me.BtnCustomerBalance)
        Me.Panel1.Controls.Add(Me.BtnCustomerHistory)
        Me.Panel1.Controls.Add(Me.BtnCustomerDetail)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtCustomerMName)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 122)
        Me.Panel1.TabIndex = 0
        '
        'BtnResetTax
        '
        Me.BtnResetTax.BackColor = System.Drawing.SystemColors.Control
        Me.BtnResetTax.Location = New System.Drawing.Point(223, 71)
        Me.BtnResetTax.Name = "BtnResetTax"
        Me.BtnResetTax.Size = New System.Drawing.Size(106, 19)
        Me.BtnResetTax.TabIndex = 176
        Me.BtnResetTax.Text = "Reset Tax"
        '
        'PhoneNoMain
        '
        Me.PhoneNoMain.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNoMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNoMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNoMain.Location = New System.Drawing.Point(216, 24)
        Me.PhoneNoMain.Name = "PhoneNoMain"
        Me.PhoneNoMain.Size = New System.Drawing.Size(92, 22)
        Me.PhoneNoMain.TabIndex = 5
        '
        'CmbChgUser
        '
        Me.CmbChgUser.DataSource = Me.DsFrmWorkOrders1.ChgUsers
        Me.CmbChgUser.DisplayMember = "UserLogin"
        Me.CmbChgUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbChgUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbChgUser.ItemHeight = 13
        Me.CmbChgUser.Location = New System.Drawing.Point(155, 74)
        Me.CmbChgUser.Name = "CmbChgUser"
        Me.CmbChgUser.Size = New System.Drawing.Size(66, 21)
        Me.CmbChgUser.TabIndex = 7
        Me.CmbChgUser.ValueMember = "UserId"
        '
        'CmbAddUser
        '
        Me.CmbAddUser.DataSource = Me.DsFrmWorkOrders1.AddUsers
        Me.CmbAddUser.DisplayMember = "UserLogin"
        Me.CmbAddUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAddUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbAddUser.ItemHeight = 13
        Me.CmbAddUser.Location = New System.Drawing.Point(48, 73)
        Me.CmbAddUser.Name = "CmbAddUser"
        Me.CmbAddUser.Size = New System.Drawing.Size(66, 21)
        Me.CmbAddUser.TabIndex = 6
        Me.CmbAddUser.ValueMember = "UserId"
        '
        'PhoneButton1
        '
        Me.PhoneButton1.Location = New System.Drawing.Point(308, 23)
        Me.PhoneButton1.Name = "PhoneButton1"
        Me.PhoneButton1.Size = New System.Drawing.Size(23, 23)
        Me.PhoneButton1.TabIndex = 174
        Me.PhoneButton1.TabStop = False
        Me.PhoneButton1.ZEnabled = False
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BackColor = System.Drawing.Color.YellowGreen
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Location = New System.Drawing.Point(52, 3)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(103, 21)
        Me.CustomerCod1.TabIndex = 0
        '
        'TxtCustomerLName
        '
        Me.TxtCustomerLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerLName.Enabled = False
        Me.TxtCustomerLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerLName.Location = New System.Drawing.Point(109, 25)
        Me.TxtCustomerLName.MaxLength = 15
        Me.TxtCustomerLName.Name = "TxtCustomerLName"
        Me.TxtCustomerLName.Size = New System.Drawing.Size(104, 20)
        Me.TxtCustomerLName.TabIndex = 3
        Me.TxtCustomerLName.Text = ""
        '
        'TxtCustomerFName
        '
        Me.TxtCustomerFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerFName.Enabled = False
        Me.TxtCustomerFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerFName.Location = New System.Drawing.Point(31, 25)
        Me.TxtCustomerFName.MaxLength = 15
        Me.TxtCustomerFName.Name = "TxtCustomerFName"
        Me.TxtCustomerFName.Size = New System.Drawing.Size(79, 20)
        Me.TxtCustomerFName.TabIndex = 1
        Me.TxtCustomerFName.Text = ""
        '
        'BtnDownPayment
        '
        Me.BtnDownPayment.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnDownPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownPayment.Location = New System.Drawing.Point(296, 90)
        Me.BtnDownPayment.Name = "BtnDownPayment"
        Me.BtnDownPayment.Size = New System.Drawing.Size(33, 29)
        Me.BtnDownPayment.TabIndex = 171
        Me.BtnDownPayment.TabStop = False
        Me.BtnDownPayment.Text = "DP"
        Me.ToolTip1.SetToolTip(Me.BtnDownPayment, "Down Payment")
        '
        'LblCustomerCompanyname
        '
        Me.LblCustomerCompanyname.BackColor = System.Drawing.SystemColors.Window
        Me.LblCustomerCompanyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomerCompanyname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCustomerCompanyname.Location = New System.Drawing.Point(51, 46)
        Me.LblCustomerCompanyname.Name = "LblCustomerCompanyname"
        Me.LblCustomerCompanyname.Size = New System.Drawing.Size(165, 26)
        Me.LblCustomerCompanyname.TabIndex = 4
        Me.LblCustomerCompanyname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCashierCopy
        '
        Me.BtnCashierCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCashierCopy.Image = CType(resources.GetObject("BtnCashierCopy.Image"), System.Drawing.Image)
        Me.BtnCashierCopy.Location = New System.Drawing.Point(259, 90)
        Me.BtnCashierCopy.Name = "BtnCashierCopy"
        Me.BtnCashierCopy.Size = New System.Drawing.Size(33, 29)
        Me.BtnCashierCopy.TabIndex = 168
        Me.BtnCashierCopy.TabStop = False
        '
        'BtnPriceTiresCopy
        '
        Me.BtnPriceTiresCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPriceTiresCopy.Image = CType(resources.GetObject("BtnPriceTiresCopy.Image"), System.Drawing.Image)
        Me.BtnPriceTiresCopy.Location = New System.Drawing.Point(222, 90)
        Me.BtnPriceTiresCopy.Name = "BtnPriceTiresCopy"
        Me.BtnPriceTiresCopy.Size = New System.Drawing.Size(33, 29)
        Me.BtnPriceTiresCopy.TabIndex = 167
        Me.BtnPriceTiresCopy.TabStop = False
        '
        'TxtPo_No
        '
        Me.TxtPo_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPo_No.Location = New System.Drawing.Point(261, 49)
        Me.TxtPo_No.MaxLength = 10
        Me.TxtPo_No.Name = "TxtPo_No"
        Me.TxtPo_No.Size = New System.Drawing.Size(70, 20)
        Me.TxtPo_No.TabIndex = 5
        Me.TxtPo_No.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(216, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 22)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Cust PO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(115, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 22)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "Changed"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CommentButton_Customer
        '
        Me.CommentButton_Customer.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentButton_Customer.Location = New System.Drawing.Point(113, 96)
        Me.CommentButton_Customer.Name = "CommentButton_Customer"
        Me.CommentButton_Customer.Size = New System.Drawing.Size(104, 23)
        Me.CommentButton_Customer.TabIndex = 7
        Me.CommentButton_Customer.TabStop = False
        Me.CommentButton_Customer.ZButtonText = "Cust. Comments"
        Me.CommentButton_Customer.ZCommentFormheight = 0
        Me.CommentButton_Customer.ZCommentFormWidth = 0
        Me.CommentButton_Customer.ZCommentText = ""
        Me.CommentButton_Customer.ZEnabled = True
        Me.CommentButton_Customer.ZMaxCommentLength = 200
        Me.CommentButton_Customer.ZShowInLeft = False
        Me.CommentButton_Customer.ZShowInTop = False
        '
        'CommentButton_House
        '
        Me.CommentButton_House.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentButton_House.ForeColor = System.Drawing.Color.Black
        Me.CommentButton_House.Location = New System.Drawing.Point(1, 96)
        Me.CommentButton_House.Name = "CommentButton_House"
        Me.CommentButton_House.Size = New System.Drawing.Size(110, 23)
        Me.CommentButton_House.TabIndex = 6
        Me.CommentButton_House.TabStop = False
        Me.CommentButton_House.ZButtonText = "House Comments"
        Me.CommentButton_House.ZCommentFormheight = 0
        Me.CommentButton_House.ZCommentFormWidth = 0
        Me.CommentButton_House.ZCommentText = Nothing
        Me.CommentButton_House.ZEnabled = True
        Me.CommentButton_House.ZMaxCommentLength = 200
        Me.CommentButton_House.ZShowInLeft = False
        Me.CommentButton_House.ZShowInTop = False
        '
        'BtnCustomerBalance
        '
        Me.BtnCustomerBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnCustomerBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCustomerBalance.Location = New System.Drawing.Point(274, 2)
        Me.BtnCustomerBalance.Name = "BtnCustomerBalance"
        Me.BtnCustomerBalance.Size = New System.Drawing.Size(57, 21)
        Me.BtnCustomerBalance.TabIndex = 4
        Me.BtnCustomerBalance.TabStop = False
        Me.BtnCustomerBalance.Text = "Balance"
        '
        'BtnCustomerHistory
        '
        Me.BtnCustomerHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnCustomerHistory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCustomerHistory.Location = New System.Drawing.Point(215, 2)
        Me.BtnCustomerHistory.Name = "BtnCustomerHistory"
        Me.BtnCustomerHistory.Size = New System.Drawing.Size(57, 21)
        Me.BtnCustomerHistory.TabIndex = 3
        Me.BtnCustomerHistory.TabStop = False
        Me.BtnCustomerHistory.Text = "History"
        '
        'BtnCustomerDetail
        '
        Me.BtnCustomerDetail.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnCustomerDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCustomerDetail.Location = New System.Drawing.Point(156, 2)
        Me.BtnCustomerDetail.Name = "BtnCustomerDetail"
        Me.BtnCustomerDetail.Size = New System.Drawing.Size(57, 21)
        Me.BtnCustomerDetail.TabIndex = 2
        Me.BtnCustomerDetail.TabStop = False
        Me.BtnCustomerDetail.Text = "Detail"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 22)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Written By"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(0, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 22)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Company"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(-1, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 21)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(0, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 21)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Customer"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCustomerMName
        '
        Me.TxtCustomerMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerMName.Enabled = False
        Me.TxtCustomerMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerMName.Location = New System.Drawing.Point(115, 25)
        Me.TxtCustomerMName.MaxLength = 15
        Me.TxtCustomerMName.Name = "TxtCustomerMName"
        Me.TxtCustomerMName.Size = New System.Drawing.Size(12, 20)
        Me.TxtCustomerMName.TabIndex = 2
        Me.TxtCustomerMName.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.NumCurrent_mileage)
        Me.Panel2.Controls.Add(Me.License_No1)
        Me.Panel2.Controls.Add(Me.LblVehicleYear)
        Me.Panel2.Controls.Add(Me.LblVehicleVin)
        Me.Panel2.Controls.Add(Me.LblVehicleModel)
        Me.Panel2.Controls.Add(Me.LblVehicleMake)
        Me.Panel2.Controls.Add(Me.BtnVehicleDetail)
        Me.Panel2.Controls.Add(Me.BtnVehicleHistory)
        Me.Panel2.Controls.Add(Me.BtnFindSize)
        Me.Panel2.Controls.Add(Me.BtnLaborGuide)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Location = New System.Drawing.Point(455, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 122)
        Me.Panel2.TabIndex = 1
        '
        'NumCurrent_mileage
        '
        Me.NumCurrent_mileage.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCurrent_mileage.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumCurrent_mileage.DecimalDigits = 0
        Me.NumCurrent_mileage.DefaultSendValue = False
        Me.NumCurrent_mileage.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCurrent_mileage.FireTabAfterEnter = True
        Me.NumCurrent_mileage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCurrent_mileage.Image = CType(resources.GetObject("NumCurrent_mileage.Image"), System.Drawing.Image)
        Me.NumCurrent_mileage.Location = New System.Drawing.Point(42, 96)
        Me.NumCurrent_mileage.Maxlength = 7
        Me.NumCurrent_mileage.MinusColor = System.Drawing.Color.Empty
        Me.NumCurrent_mileage.Name = "NumCurrent_mileage"
        Me.NumCurrent_mileage.Size = New System.Drawing.Size(49, 21)
        Me.NumCurrent_mileage.TabIndex = 153
        Me.NumCurrent_mileage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCurrent_mileage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'License_No1
        '
        Me.License_No1.Cnn = Me.Cnn
        Me.License_No1.FieldCodValue = CType(0, Long)
        Me.License_No1.LicenseNoLen = 20
        Me.License_No1.Location = New System.Drawing.Point(46, 25)
        Me.License_No1.Name = "License_No1"
        Me.License_No1.Size = New System.Drawing.Size(97, 21)
        Me.License_No1.TabIndex = 0
        Me.License_No1.TxtBackColor = System.Drawing.Color.YellowGreen
        Me.License_No1.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.License_No1.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'LblVehicleYear
        '
        Me.LblVehicleYear.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblVehicleYear.Location = New System.Drawing.Point(148, 73)
        Me.LblVehicleYear.Name = "LblVehicleYear"
        Me.LblVehicleYear.Size = New System.Drawing.Size(40, 22)
        Me.LblVehicleYear.TabIndex = 152
        Me.LblVehicleYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVehicleVin
        '
        Me.LblVehicleVin.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleVin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleVin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblVehicleVin.Location = New System.Drawing.Point(1, 73)
        Me.LblVehicleVin.Name = "LblVehicleVin"
        Me.LblVehicleVin.Size = New System.Drawing.Size(148, 22)
        Me.LblVehicleVin.TabIndex = 151
        Me.LblVehicleVin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVehicleModel
        '
        Me.LblVehicleModel.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleModel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblVehicleModel.Location = New System.Drawing.Point(94, 47)
        Me.LblVehicleModel.Name = "LblVehicleModel"
        Me.LblVehicleModel.Size = New System.Drawing.Size(94, 25)
        Me.LblVehicleModel.TabIndex = 150
        Me.LblVehicleModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVehicleMake
        '
        Me.LblVehicleMake.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleMake.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblVehicleMake.Location = New System.Drawing.Point(1, 47)
        Me.LblVehicleMake.Name = "LblVehicleMake"
        Me.LblVehicleMake.Size = New System.Drawing.Size(94, 25)
        Me.LblVehicleMake.TabIndex = 149
        Me.LblVehicleMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnVehicleDetail
        '
        Me.BtnVehicleDetail.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnVehicleDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnVehicleDetail.Location = New System.Drawing.Point(143, 25)
        Me.BtnVehicleDetail.Name = "BtnVehicleDetail"
        Me.BtnVehicleDetail.Size = New System.Drawing.Size(46, 21)
        Me.BtnVehicleDetail.TabIndex = 145
        Me.BtnVehicleDetail.TabStop = False
        Me.BtnVehicleDetail.Text = "Detail"
        '
        'BtnVehicleHistory
        '
        Me.BtnVehicleHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnVehicleHistory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnVehicleHistory.Location = New System.Drawing.Point(91, 96)
        Me.BtnVehicleHistory.Name = "BtnVehicleHistory"
        Me.BtnVehicleHistory.Size = New System.Drawing.Size(98, 21)
        Me.BtnVehicleHistory.TabIndex = 2
        Me.BtnVehicleHistory.TabStop = False
        Me.BtnVehicleHistory.Text = "Vehicle History"
        '
        'BtnFindSize
        '
        Me.BtnFindSize.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnFindSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnFindSize.Location = New System.Drawing.Point(1, 2)
        Me.BtnFindSize.Name = "BtnFindSize"
        Me.BtnFindSize.Size = New System.Drawing.Size(90, 21)
        Me.BtnFindSize.TabIndex = 3
        Me.BtnFindSize.TabStop = False
        Me.BtnFindSize.Text = "Find Size"
        '
        'BtnLaborGuide
        '
        Me.BtnLaborGuide.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnLaborGuide.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnLaborGuide.Location = New System.Drawing.Point(98, 2)
        Me.BtnLaborGuide.Name = "BtnLaborGuide"
        Me.BtnLaborGuide.Size = New System.Drawing.Size(91, 21)
        Me.BtnLaborGuide.TabIndex = 4
        Me.BtnLaborGuide.TabStop = False
        Me.BtnLaborGuide.Text = "Labor Guide"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Silver
        Me.Label35.Location = New System.Drawing.Point(0, 96)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 21)
        Me.Label35.TabIndex = 139
        Me.Label35.Text = "Mileage"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Silver
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label34.Location = New System.Drawing.Point(1, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 21)
        Me.Label34.TabIndex = 138
        Me.Label34.Text = "Vehicle"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.NumDiscount)
        Me.Panel3.Controls.Add(Me.NumTax)
        Me.Panel3.Controls.Add(Me.LblSubtotal)
        Me.Panel3.Controls.Add(Me.LblFET)
        Me.Panel3.Controls.Add(Me.LblFees)
        Me.Panel3.Controls.Add(Me.LblLabor)
        Me.Panel3.Controls.Add(Me.LblParts)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Location = New System.Drawing.Point(334, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(120, 122)
        Me.Panel3.TabIndex = 135
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Location = New System.Drawing.Point(49, 58)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(75, 1)
        Me.Panel11.TabIndex = 176
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Location = New System.Drawing.Point(48, 73)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(75, 1)
        Me.Panel10.TabIndex = 175
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Location = New System.Drawing.Point(51, 88)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(75, 1)
        Me.Panel9.TabIndex = 174
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(46, 104)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(75, 1)
        Me.Panel8.TabIndex = 173
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(46, 44)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(75, 1)
        Me.Panel7.TabIndex = 172
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(44, 29)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(75, 1)
        Me.Panel6.TabIndex = 171
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(44, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(75, 1)
        Me.Panel5.TabIndex = 170
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotal.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblTotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblTotal.DecimalDigits = 2
        Me.LblTotal.DefaultSendValue = False
        Me.LblTotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotal.FireTabAfterEnter = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Image = CType(resources.GetObject("LblTotal.Image"), System.Drawing.Image)
        Me.LblTotal.Location = New System.Drawing.Point(58, 104)
        Me.LblTotal.Maxlength = 10
        Me.LblTotal.MinusColor = System.Drawing.Color.Empty
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.ReadOnly = True
        Me.LblTotal.Size = New System.Drawing.Size(63, 21)
        Me.LblTotal.TabIndex = 164
        Me.LblTotal.TabStop = False
        Me.LblTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDiscount
        '
        Me.NumDiscount.BackColor = System.Drawing.SystemColors.Window
        Me.NumDiscount.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.NumDiscount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDiscount.DecimalDigits = 2
        Me.NumDiscount.DefaultSendValue = False
        Me.NumDiscount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDiscount.FireTabAfterEnter = True
        Me.NumDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumDiscount.Image = CType(resources.GetObject("NumDiscount.Image"), System.Drawing.Image)
        Me.NumDiscount.Location = New System.Drawing.Point(58, 88)
        Me.NumDiscount.Maxlength = 10
        Me.NumDiscount.MinusColor = System.Drawing.Color.Empty
        Me.NumDiscount.Name = "NumDiscount"
        Me.NumDiscount.Size = New System.Drawing.Size(60, 21)
        Me.NumDiscount.TabIndex = 163
        Me.NumDiscount.TabStop = False
        Me.NumDiscount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDiscount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumTax
        '
        Me.NumTax.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.NumTax.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.NumTax.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumTax.DecimalDigits = 2
        Me.NumTax.DefaultSendValue = False
        Me.NumTax.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumTax.FireTabAfterEnter = True
        Me.NumTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumTax.Image = CType(resources.GetObject("NumTax.Image"), System.Drawing.Image)
        Me.NumTax.Location = New System.Drawing.Point(58, 73)
        Me.NumTax.Maxlength = 10
        Me.NumTax.MinusColor = System.Drawing.Color.Empty
        Me.NumTax.Name = "NumTax"
        Me.NumTax.ReadOnly = True
        Me.NumTax.Size = New System.Drawing.Size(59, 21)
        Me.NumTax.TabIndex = 162
        Me.NumTax.TabStop = False
        Me.NumTax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumTax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblSubtotal
        '
        Me.LblSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblSubtotal.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblSubtotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblSubtotal.DecimalDigits = 2
        Me.LblSubtotal.DefaultSendValue = False
        Me.LblSubtotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblSubtotal.FireTabAfterEnter = True
        Me.LblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtotal.Image = CType(resources.GetObject("LblSubtotal.Image"), System.Drawing.Image)
        Me.LblSubtotal.Location = New System.Drawing.Point(58, 58)
        Me.LblSubtotal.Maxlength = 10
        Me.LblSubtotal.MinusColor = System.Drawing.Color.Empty
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.ReadOnly = True
        Me.LblSubtotal.Size = New System.Drawing.Size(60, 21)
        Me.LblSubtotal.TabIndex = 167
        Me.LblSubtotal.TabStop = False
        Me.LblSubtotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblSubtotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblFET
        '
        Me.LblFET.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFET.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblFET.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblFET.DecimalDigits = 2
        Me.LblFET.DefaultSendValue = False
        Me.LblFET.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblFET.FireTabAfterEnter = True
        Me.LblFET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFET.Image = CType(resources.GetObject("LblFET.Image"), System.Drawing.Image)
        Me.LblFET.Location = New System.Drawing.Point(58, 43)
        Me.LblFET.Maxlength = 10
        Me.LblFET.MinusColor = System.Drawing.Color.Empty
        Me.LblFET.Name = "LblFET"
        Me.LblFET.ReadOnly = True
        Me.LblFET.Size = New System.Drawing.Size(59, 21)
        Me.LblFET.TabIndex = 166
        Me.LblFET.TabStop = False
        Me.LblFET.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblFET.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblFees
        '
        Me.LblFees.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFees.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblFees.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblFees.DecimalDigits = 2
        Me.LblFees.DefaultSendValue = False
        Me.LblFees.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblFees.FireTabAfterEnter = True
        Me.LblFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFees.Image = CType(resources.GetObject("LblFees.Image"), System.Drawing.Image)
        Me.LblFees.Location = New System.Drawing.Point(58, 28)
        Me.LblFees.Maxlength = 10
        Me.LblFees.MinusColor = System.Drawing.Color.Empty
        Me.LblFees.Name = "LblFees"
        Me.LblFees.ReadOnly = True
        Me.LblFees.Size = New System.Drawing.Size(59, 21)
        Me.LblFees.TabIndex = 165
        Me.LblFees.TabStop = False
        Me.LblFees.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblFees.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblLabor
        '
        Me.LblLabor.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblLabor.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblLabor.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblLabor.DecimalDigits = 2
        Me.LblLabor.DefaultSendValue = False
        Me.LblLabor.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblLabor.FireTabAfterEnter = True
        Me.LblLabor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLabor.Image = CType(resources.GetObject("LblLabor.Image"), System.Drawing.Image)
        Me.LblLabor.Location = New System.Drawing.Point(58, 13)
        Me.LblLabor.Maxlength = 10
        Me.LblLabor.MinusColor = System.Drawing.Color.Empty
        Me.LblLabor.Name = "LblLabor"
        Me.LblLabor.ReadOnly = True
        Me.LblLabor.Size = New System.Drawing.Size(59, 21)
        Me.LblLabor.TabIndex = 169
        Me.LblLabor.TabStop = False
        Me.LblLabor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblLabor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblParts
        '
        Me.LblParts.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblParts.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblParts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblParts.DecimalDigits = 2
        Me.LblParts.DefaultSendValue = False
        Me.LblParts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblParts.FireTabAfterEnter = True
        Me.LblParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblParts.Image = CType(resources.GetObject("LblParts.Image"), System.Drawing.Image)
        Me.LblParts.Location = New System.Drawing.Point(58, -2)
        Me.LblParts.Maxlength = 10
        Me.LblParts.MinusColor = System.Drawing.Color.Empty
        Me.LblParts.Name = "LblParts"
        Me.LblParts.ReadOnly = True
        Me.LblParts.Size = New System.Drawing.Size(59, 21)
        Me.LblParts.TabIndex = 168
        Me.LblParts.TabStop = False
        Me.LblParts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblParts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(-1, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 17)
        Me.Label23.TabIndex = 144
        Me.Label23.Text = "Total"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(-1, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 142
        Me.Label21.Text = "Tax"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.Location = New System.Drawing.Point(-1, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 16)
        Me.Label20.TabIndex = 141
        Me.Label20.Text = "Subtotal"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(-1, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 15)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "FET"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(-1, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 16)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "Fees"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(-1, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 16)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Labor"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(-1, -1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 16)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Parts"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(-8, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Discount%"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDate
        '
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Enabled = False
        Me.TxtDate.Location = New System.Drawing.Point(347, 47)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(77, 20)
        Me.TxtDate.TabIndex = 138
        Me.TxtDate.Text = ""
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label38)
        Me.Panel4.Controls.Add(Me.BtnConvert)
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.BtnFirst)
        Me.Panel4.Controls.Add(Me.Label37)
        Me.Panel4.Controls.Add(Me.BtnLast)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.BtnEmail)
        Me.Panel4.Controls.Add(Me.BtnFax)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Controls.Add(Me.BtnCashier)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.BtnNew)
        Me.Panel4.Controls.Add(Me.BtnFind)
        Me.Panel4.Controls.Add(Me.BtnNext)
        Me.Panel4.Controls.Add(Me.BtnPrev)
        Me.Panel4.Controls.Add(Me.BtnPriceTires)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(647, 45)
        Me.Panel4.TabIndex = 3
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Location = New System.Drawing.Point(601, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(44, 10)
        Me.Label38.TabIndex = 194
        Me.Label38.Text = "Convert"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnConvert
        '
        Me.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConvert.Image = CType(resources.GetObject("BtnConvert.Image"), System.Drawing.Image)
        Me.BtnConvert.Location = New System.Drawing.Point(606, 2)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(33, 27)
        Me.BtnConvert.TabIndex = 193
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(1, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 10)
        Me.Label36.TabIndex = 192
        Me.Label36.Text = "First"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(2, 2)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(108, 31)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(33, 10)
        Me.Label37.TabIndex = 189
        Me.Label37.Text = "Last"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(107, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(325, 31)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 10)
        Me.Label33.TabIndex = 186
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(328, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(224, 31)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 10)
        Me.Label32.TabIndex = 184
        Me.Label32.Text = "Edit"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(223, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(567, 31)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 10)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(530, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 10)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Fax"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(495, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(453, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(412, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 10)
        Me.Label27.TabIndex = 178
        Me.Label27.Text = "Cashier"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(361, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 10)
        Me.Label26.TabIndex = 177
        Me.Label26.Text = "PriceTires"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(293, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(256, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 10)
        Me.Label24.TabIndex = 175
        Me.Label24.Text = "Delete"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(187, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 10)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "New"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(148, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(36, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(73, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 10)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Next"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(565, 2)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(530, 2)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(495, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(460, 2)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'BtnCashier
        '
        Me.BtnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCashier.Image = CType(resources.GetObject("BtnCashier.Image"), System.Drawing.Image)
        Me.BtnCashier.Location = New System.Drawing.Point(415, 2)
        Me.BtnCashier.Name = "BtnCashier"
        Me.BtnCashier.Size = New System.Drawing.Size(33, 27)
        Me.BtnCashier.TabIndex = 9
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(258, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(188, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(147, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(72, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(37, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnPriceTires
        '
        Me.BtnPriceTires.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPriceTires.Image = CType(resources.GetObject("BtnPriceTires.Image"), System.Drawing.Image)
        Me.BtnPriceTires.Location = New System.Drawing.Point(372, 2)
        Me.BtnPriceTires.Name = "BtnPriceTires"
        Me.BtnPriceTires.Size = New System.Drawing.Size(33, 27)
        Me.BtnPriceTires.TabIndex = 8
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(293, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT employee_code, f_name + ' ' + m_name + ' ' + l_name AS employee_Name FROM " & _
        "employee WHERE (technecian = 1) AND (Terminated = 0)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand3
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_main", "phone_main"), New System.Data.Common.DataColumnMapping("phone_work", "phone_work"), New System.Data.Common.DataColumnMapping("phone_cell", "phone_cell"), New System.Data.Common.DataColumnMapping("phome_other", "phome_other"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("deduction_cod1", "deduction_cod1"), New System.Data.Common.DataColumnMapping("deduction_amount1", "deduction_amount1"), New System.Data.Common.DataColumnMapping("deduction_cod2", "deduction_cod2"), New System.Data.Common.DataColumnMapping("deduction_amount2", "deduction_amount2"), New System.Data.Common.DataColumnMapping("deduction_cod3", "deduction_cod3"), New System.Data.Common.DataColumnMapping("deduction_amount3", "deduction_amount3"), New System.Data.Common.DataColumnMapping("deduction_cod4", "deduction_cod4"), New System.Data.Common.DataColumnMapping("deduction_amount4", "deduction_amount4"), New System.Data.Common.DataColumnMapping("deduction_cod5", "deduction_cod5"), New System.Data.Common.DataColumnMapping("deduction_amount5", "deduction_amount5"), New System.Data.Common.DataColumnMapping("deduction_cod6", "deduction_cod6"), New System.Data.Common.DataColumnMapping("deduction_amount6", "deduction_amount6")})})
        '
        'DsFrmCashier1
        '
        Me.DsFrmCashier1.DataSetName = "DSFrmCashier"
        Me.DsFrmCashier1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT service_center_head.id_service_center, service_center_head.type_of_form, s" & _
        "ervice_center_head.cod_customer, service_center_head.date_refer, service_center_" & _
        "head.discount, service_center_head.tax, service_center_head.house_comment, servi" & _
        "ce_center_head.cust_comment, service_center_head.add_user, service_center_head.p" & _
        "o_no, cust_company.complete_name, cust_company.abbreviation_name, service_center" & _
        "_head.chg_user, service_center_head.id_vehicle, service_center_head.id_service_c" & _
        "enter_before, ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle_dtl.current_mile" & _
        "age, service_center_head.Total, service_center_head.id_GL_journal FROM service_c" & _
        "enter_head LEFT OUTER JOIN ser_tr_vehicle ON service_center_head.id_vehicle = se" & _
        "r_tr_vehicle.id_vehicle LEFT OUTER JOIN cust_company INNER JOIN cust_trtab_main " & _
        "ON cust_company.cod_company = cust_trtab_main.cod_company ON service_center_head" & _
        ".cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN ser_tr_vehicle_dtl " & _
        "ON service_center_head.id_service_center = ser_tr_vehicle_dtl.id_service_center " & _
        "WHERE (service_center_head.id_service_center = @id_service_center)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO service_center_head(id_service_center, type_of_form, cod_customer, id" & _
        "_vehicle, date_refer, discount, tax, house_comment, cust_comment, add_user, chg_" & _
        "user, po_no, id_service_center_before, id_GL_journal, Total) VALUES (@id_service" & _
        "_center, @type_of_form, @cod_customer, @id_vehicle, @date_refer, @discount, @tax" & _
        ", @house_comment, @cust_comment, @add_user, @chg_user, @po_no, @id_service_cente" & _
        "r_before, @id_GL_journal, @Total); SELECT id_service_center, type_of_form, cod_c" & _
        "ustomer, id_vehicle, date_refer, discount, tax, house_comment, cust_comment, add" & _
        "_user, chg_user, po_no, id_service_center_before, id_GL_journal, Total FROM serv" & _
        "ice_center_head WHERE (id_service_center = @id_service_center)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE service_center_head SET id_service_center = @id_service_center, type_of_fo" & _
        "rm = @type_of_form, cod_customer = @cod_customer, id_vehicle = @id_vehicle, date" & _
        "_refer = @date_refer, discount = @discount, tax = @tax, house_comment = @house_c" & _
        "omment, cust_comment = @cust_comment, add_user = @add_user, chg_user = @chg_user" & _
        ", po_no = @po_no, id_service_center_before = @id_service_center_before, id_GL_jo" & _
        "urnal = @id_GL_journal, Total = @Total WHERE (id_service_center = @Original_id_s" & _
        "ervice_center) AND (Total = @Original_Total OR @Original_Total IS NULL AND Total" & _
        " IS NULL) AND (add_user = @Original_add_user OR @Original_add_user IS NULL AND a" & _
        "dd_user IS NULL) AND (chg_user = @Original_chg_user OR @Original_chg_user IS NUL" & _
        "L AND chg_user IS NULL) AND (cod_customer = @Original_cod_customer OR @Original_" & _
        "cod_customer IS NULL AND cod_customer IS NULL) AND (cust_comment = @Original_cus" & _
        "t_comment OR @Original_cust_comment IS NULL AND cust_comment IS NULL) AND (date_" & _
        "refer = @Original_date_refer OR @Original_date_refer IS NULL AND date_refer IS N" & _
        "ULL) AND (discount = @Original_discount OR @Original_discount IS NULL AND discou" & _
        "nt IS NULL) AND (house_comment = @Original_house_comment OR @Original_house_comm" & _
        "ent IS NULL AND house_comment IS NULL) AND (id_GL_journal = @Original_id_GL_jour" & _
        "nal OR @Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_servic" & _
        "e_center_before = @Original_id_service_center_before OR @Original_id_service_cen" & _
        "ter_before IS NULL AND id_service_center_before IS NULL) AND (id_vehicle = @Orig" & _
        "inal_id_vehicle OR @Original_id_vehicle IS NULL AND id_vehicle IS NULL) AND (po_" & _
        "no = @Original_po_no OR @Original_po_no IS NULL AND po_no IS NULL) AND (tax = @O" & _
        "riginal_tax OR @Original_tax IS NULL AND tax IS NULL) AND (type_of_form = @Origi" & _
        "nal_type_of_form OR @Original_type_of_form IS NULL AND type_of_form IS NULL); SE" & _
        "LECT id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, disc" & _
        "ount, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_ce" & _
        "nter_before, id_GL_journal, Total FROM service_center_head WHERE (id_service_cen" & _
        "ter = @id_service_center)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM service_center_head WHERE (id_service_center = @Original_id_service_c" & _
        "enter) AND (Total = @Original_Total OR @Original_Total IS NULL AND Total IS NULL" & _
        ") AND (add_user = @Original_add_user OR @Original_add_user IS NULL AND add_user " & _
        "IS NULL) AND (chg_user = @Original_chg_user OR @Original_chg_user IS NULL AND ch" & _
        "g_user IS NULL) AND (cod_customer = @Original_cod_customer OR @Original_cod_cust" & _
        "omer IS NULL AND cod_customer IS NULL) AND (cust_comment = @Original_cust_commen" & _
        "t OR @Original_cust_comment IS NULL AND cust_comment IS NULL) AND (date_refer = " & _
        "@Original_date_refer OR @Original_date_refer IS NULL AND date_refer IS NULL) AND" & _
        " (discount = @Original_discount OR @Original_discount IS NULL AND discount IS NU" & _
        "LL) AND (house_comment = @Original_house_comment OR @Original_house_comment IS N" & _
        "ULL AND house_comment IS NULL) AND (id_GL_journal = @Original_id_GL_journal OR @" & _
        "Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_service_center" & _
        "_before = @Original_id_service_center_before OR @Original_id_service_center_befo" & _
        "re IS NULL AND id_service_center_before IS NULL) AND (id_vehicle = @Original_id_" & _
        "vehicle OR @Original_id_vehicle IS NULL AND id_vehicle IS NULL) AND (po_no = @Or" & _
        "iginal_po_no OR @Original_po_no IS NULL AND po_no IS NULL) AND (tax = @Original_" & _
        "tax OR @Original_tax IS NULL AND tax IS NULL) AND (type_of_form = @Original_type" & _
        "_of_form OR @Original_type_of_form IS NULL AND type_of_form IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAService_Center_Head
        '
        Me.DAService_Center_Head.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAService_Center_Head.InsertCommand = Me.SqlInsertCommand3
        Me.DAService_Center_Head.SelectCommand = Me.SqlSelectCommand4
        Me.DAService_Center_Head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        Me.DAService_Center_Head.UpdateCommand = Me.SqlUpdateCommand3
        '
        'CnnReader
        '
        Me.CnnReader.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=KETABIE;persist se" & _
        "curity info=True;initial catalog=TireMate_01;password=sa"
        '
        'CmdReader
        '
        Me.CmdReader.Connection = Me.CnnReader
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM GL_payment_deposit WHERE (ID_payment = @Original_ID_payment) AND (id_" & _
        "service_center = @Original_id_service_center OR @Original_id_service_center IS N" & _
        "ULL AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amoun" & _
        "t OR @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_t" & _
        "ype = @Original_payment_type OR @Original_payment_type IS NULL AND payment_type " & _
        "IS NULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL " & _
        "AND refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_re" & _
        "frence_no IS NULL AND refrence_no IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no, bas_cc_type.cc_type_de" & _
        "sc FROM GL_payment_deposit LEFT OUTER JOIN GL_payment_credit ON GL_payment_depos" & _
        "it.ID_payment = GL_payment_credit.ID_payment LEFT OUTER JOIN bas_cc_type ON GL_p" & _
        "ayment_credit.cc_type = bas_cc_type.cc_type LEFT OUTER JOIN GL_payment_AR ON GL_" & _
        "payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment" & _
        "_check ON GL_payment_deposit.ID_payment = GL_payment_check.ID_payment LEFT OUTER" & _
        " JOIN GL_payment_cash ON GL_payment_deposit.ID_payment = GL_payment_cash.ID_paym" & _
        "ent WHERE (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.id_servi" & _
        "ce_center = @id_service_center)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no FROM GL_payment_deposit" & _
        " LEFT OUTER JOIN GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment" & _
        "_credit.ID_payment LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_paymen" & _
        "t = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment_check ON GL_payment_depo" & _
        "sit.ID_payment = GL_payment_check.ID_payment LEFT OUTER JOIN GL_payment_cash ON " & _
        "GL_payment_deposit.ID_payment = GL_payment_cash.ID_payment WHERE (GL_payment_dep" & _
        "osit.refer_type = '1') AND (GL_payment_deposit.id_service_center = @id_service_c" & _
        "enter)"
        Me.SqlCommand6.Connection = Me.Cnn
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 8, "refrence_no"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlCommand9
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount")})})
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no FROM GL_payment_deposit" & _
        " LEFT OUTER JOIN GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment" & _
        "_credit.ID_payment LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_paymen" & _
        "t = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment_check ON GL_payment_depo" & _
        "sit.ID_payment = GL_payment_check.ID_payment LEFT OUTER JOIN GL_payment_cash ON " & _
        "GL_payment_deposit.ID_payment = GL_payment_cash.ID_payment WHERE (GL_payment_dep" & _
        "osit.refer_type = '1') AND (GL_payment_deposit.id_service_center = @id_service_c" & _
        "enter)"
        Me.SqlCommand9.Connection = Me.Cnn
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT style, desc_style FROM inv_tab_style"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAinv_tab_style
        '
        Me.DAinv_tab_style.SelectCommand = Me.SqlSelectCommand5
        Me.DAinv_tab_style.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_pakage, radif, type_select, cod_select, desc_radif, qty, price FROM in" & _
        "v_tab_pakage"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAinv_tab_pakage
        '
        Me.DAinv_tab_pakage.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_pakage.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_pakage", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_pakage", "cod_pakage"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT service_out_purchases.id_service_center, service_out_purchases.radif, serv" & _
        "ice_out_purchases.cost, service_out_purchases.fet, service_out_purchases.markup," & _
        " service_out_purchases.cod_vendor, service_out_purchases.po_no, service_out_purc" & _
        "hases.invoice_no, service_out_purchases.invoice_date, service_out_purchases.due_" & _
        "date, service_out_purchases.tracking_warranty, service_out_purchases.in_day, ser" & _
        "vice_out_purchases.in_mile, service_out_purchases.tracking_core, service_out_pur" & _
        "chases.core_value, service_out_purchases.Line, service_center_dtl.price, service" & _
        "_center_dtl.cod_select AS part_no, service_center_dtl.desc_radif AS description," & _
        " service_out_purchases.PaidFlag, service_out_purchases.AR_terms FROM service_out" & _
        "_purchases INNER JOIN service_center_dtl ON service_out_purchases.id_service_cen" & _
        "ter = service_center_dtl.id_service_center AND service_out_purchases.radif = ser" & _
        "vice_center_dtl.radif WHERE (service_out_purchases.id_service_center = @id_servi" & _
        "ce_center)"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'DAservice_out_purchases
        '
        Me.DAservice_out_purchases.SelectCommand = Me.SqlSelectCommand6
        Me.DAservice_out_purchases.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("part_no", "part_no"), New System.Data.Common.DataColumnMapping("description", "description"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT service_center_dtl.id_service_center, service_center_dtl.radif, service_ce" & _
        "nter_dtl.type_select, service_center_dtl.cod_select, service_center_dtl.desc_rad" & _
        "if, service_center_dtl.qty, service_center_dtl.price, service_center_dtl.fet, se" & _
        "rvice_center_dtl.taxable, service_center_dtl.cod_technician, service_center_dtl." & _
        "COMMENT_ARTICLE, inv_item.item_no FROM service_center_dtl LEFT OUTER JOIN inv_it" & _
        "em ON service_center_dtl.cod_select = inv_item.item_no WHERE (service_center_dtl" & _
        ".id_service_center = @id_service_center) ORDER BY service_center_dtl.radif"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO service_center_dtl(id_service_center, radif, type_select, cod_select," & _
        " desc_radif, qty, price, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_" & _
        "COST) VALUES (@id_service_center, @radif, @type_select, @cod_select, @desc_radif" & _
        ", @qty, @price, @fet, @taxable, @cod_technician, @COMMENT_ARTICLE, @AVERAGE_COST" & _
        "); SELECT id_service_center, radif, type_select, cod_select, desc_radif, qty, pr" & _
        "ice, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_ce" & _
        "nter_dtl WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlInsertCommand8.Connection = Me.Cnn
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE service_center_dtl SET id_service_center = @id_service_center, radif = @ra" & _
        "dif, type_select = @type_select, cod_select = @cod_select, desc_radif = @desc_ra" & _
        "dif, qty = @qty, price = @price, fet = @fet, taxable = @taxable, cod_technician " & _
        "= @cod_technician, COMMENT_ARTICLE = @COMMENT_ARTICLE, AVERAGE_COST = @AVERAGE_C" & _
        "OST WHERE (id_service_center = @Original_id_service_center) AND (radif = @Origin" & _
        "al_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST OR @Original_AVERAGE_COST I" & _
        "S NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE = @Original_COMMENT_ARTICL" & _
        "E OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ARTICLE IS NULL) AND (cod_sel" & _
        "ect = @Original_cod_select OR @Original_cod_select IS NULL AND cod_select IS NUL" & _
        "L) AND (cod_technician = @Original_cod_technician OR @Original_cod_technician IS" & _
        " NULL AND cod_technician IS NULL) AND (desc_radif = @Original_desc_radif OR @Ori" & _
        "ginal_desc_radif IS NULL AND desc_radif IS NULL) AND (fet = @Original_fet) AND (" & _
        "price = @Original_price) AND (qty = @Original_qty) AND (taxable = @Original_taxa" & _
        "ble OR @Original_taxable IS NULL AND taxable IS NULL) AND (type_select = @Origin" & _
        "al_type_select OR @Original_type_select IS NULL AND type_select IS NULL); SELECT" & _
        " id_service_center, radif, type_select, cod_select, desc_radif, qty, price, fet," & _
        " taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_center_dtl " & _
        "WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlUpdateCommand8.Connection = Me.Cnn
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM service_center_dtl WHERE (id_service_center = @Original_id_service_ce" & _
        "nter) AND (radif = @Original_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST O" & _
        "R @Original_AVERAGE_COST IS NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE " & _
        "= @Original_COMMENT_ARTICLE OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ART" & _
        "ICLE IS NULL) AND (cod_select = @Original_cod_select OR @Original_cod_select IS " & _
        "NULL AND cod_select IS NULL) AND (cod_technician = @Original_cod_technician OR @" & _
        "Original_cod_technician IS NULL AND cod_technician IS NULL) AND (desc_radif = @O" & _
        "riginal_desc_radif OR @Original_desc_radif IS NULL AND desc_radif IS NULL) AND (" & _
        "fet = @Original_fet) AND (price = @Original_price) AND (qty = @Original_qty) AND" & _
        " (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable IS NULL) " & _
        "AND (type_select = @Original_type_select OR @Original_type_select IS NULL AND ty" & _
        "pe_select IS NULL)"
        Me.SqlDeleteCommand8.Connection = Me.Cnn
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAService_Center_Dtl
        '
        Me.DAService_Center_Dtl.DeleteCommand = Me.SqlDeleteCommand8
        Me.DAService_Center_Dtl.InsertCommand = Me.SqlInsertCommand8
        Me.DAService_Center_Dtl.SelectCommand = Me.SqlSelectCommand8
        Me.DAService_Center_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        Me.DAService_Center_Dtl.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT id_service_center, radif, DOT_safety_code, DOT_serial_no, measured_tread_d" & _
        "epth, condition_code, supplier_percent, costomer_portion FROM service_tire_adjus" & _
        "tment WHERE (id_service_center = @id_service_center)"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'DAService_tire_adjustment
        '
        Me.DAService_tire_adjustment.SelectCommand = Me.SqlSelectCommand7
        Me.DAService_tire_adjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_tire_adjustment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("DOT_safety_code", "DOT_safety_code"), New System.Data.Common.DataColumnMapping("DOT_serial_no", "DOT_serial_no"), New System.Data.Common.DataColumnMapping("measured_tread_depth", "measured_tread_depth"), New System.Data.Common.DataColumnMapping("condition_code", "condition_code"), New System.Data.Common.DataColumnMapping("supplier_percent", "supplier_percent"), New System.Data.Common.DataColumnMapping("costomer_portion", "costomer_portion")})})
        '
        'DaUsers
        '
        Me.DaUsers.SelectCommand = Me.OleDbSelectCommand2
        Me.DaUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DefaultStoreNo", "DefaultStoreNo"), New System.Data.Common.DataColumnMapping("DefaultYear", "DefaultYear"), New System.Data.Common.DataColumnMapping("UserActiveFalg", "UserActiveFalg"), New System.Data.Common.DataColumnMapping("UserFamily", "UserFamily"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserLogin", "UserLogin"), New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("UserPassword", "UserPassword")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Users.UserId, Users.UserLogin FROM (Users INNER JOIN UserGroup ON Users.Us" & _
        "erGroupId = UserGroup.UserGroupId) WHERE (Users.UserActiveFalg <> 0) AND (UserGr" & _
        "oup.GroupActiveFlag <> 0)"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMate.mdb;Persist Sec" & _
        "urity Info=True;Jet OLEDB:Database Password=5332"
        '
        'CmdGeneralLock
        '
        Me.CmdGeneralLock.Connection = Me.CnnLock
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_color, desc_color FROM bas_color"
        Me.SqlSelectCommand1.Connection = Me.CnnLock
        '
        'DAGeneralLock
        '
        Me.DAGeneralLock.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneralLock.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_color", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_color", "cod_color"), New System.Data.Common.DataColumnMapping("desc_color", "desc_color")})})
        '
        'FrmWorkOrders
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(647, 449)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.LblType)
        Me.Controls.Add(Me.TxtRef)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmbType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblStoreName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCompanyName)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmWorkOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Service Center"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmWorkOrders1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmCashier1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CnnReader.ConnectionString = PConnectionString
        CnnLock.ConnectionString = PConnectionString

        CnnUserMDB.ConnectionString = PConnectionStringForUserMdb

        HelpProvider1.HelpNamespace = PubMainImagePath & "\TireMate.Chm"
        HelpProvider1.SetHelpKeyword(Me, " ⁄„Ì—« ")

        CmdGeneral.CommandText = "DELETE FROM service_center_head WHERE (RTRIM(LTRIM(id_service_center)) = '')"
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        Try
            Dim SALES_TAXTempVar As String
            SALES_TAXTempVar = OleDbReaderForStore.Item("SALES_TAX") & ""
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT  Amount  FROM  cust_sales_tax Where cod_sales_tax=" & Qt(SALES_TAXTempVar)
            DefaultTax_AmountVar = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            DefaultTax_AmountVar = 0
        End Try
        CHKRULES_For_Warn_Qty_Var = OleDbReaderForStore.Item("RULES4") & ""
        OleDbReaderForStore.Close()

        Dim OleDbReaderForAccountsReceivable As System.Data.OleDb.OleDbDataReader
        OleDbReaderForAccountsReceivable = RetrieveAccountsReceivableSetupTable()
        CHKRULES_USE_CREDIT_LIMITEDVar = OleDbReaderForAccountsReceivable.Item("RULES_USE_CREDIT_LIMITED") & ""
        OleDbReaderForAccountsReceivable.Close()

        Dim OleDbReaderForServiceSetup As System.Data.OleDb.OleDbDataReader
        OleDbReaderForServiceSetup = RetrieveServiceSetupTable(PubStoreNO)
        Try
            CHKServiceDescriptionFlagVar = OleDbReaderForServiceSetup.Item("ServiceDescriptionEditFlag") ' True
        Catch ex As Exception
            CHKServiceDescriptionFlagVar = False
        End Try
        Try
            CHKItemDescriptionFlagVar = OleDbReaderForServiceSetup.Item("ItemDescriptionEditFlag") ' True
        Catch ex As Exception
            CHKItemDescriptionFlagVar = False
        End Try
        OleDbReaderForServiceSetup.Close()

        DsFrmWorkOrders1.service_center_dtl.Columns("PricePlusFet").Expression = "Price + Fet"
        DsFrmWorkOrders1.service_center_dtl.Columns("Ext_Price").Expression = "PricePlusFet * Qty"

        License_No1.Cnn = Cnn

        Mylabor_service = New UCLabor_Service.ClsLabor_ServiceCod
        Mylabor_service.Connection = Me.Cnn

        MyItem = New UCInv_Item.Clsitem_no
        MyItem.Connection = Me.Cnn

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn

        MyPackage = New UCInv_Package.ClsCod_pakage
        MyPackage.Connection = Me.Cnn

        MyReadyComment = New UCInv_Package.ClsCod_pakage
        MyReadyComment.Connection = Me.Cnn

        DsFrmWorkOrders1.employee.Clear()
        DAEmployee.Fill(DsFrmWorkOrders1.employee)

        DsFrmWorkOrders1.AddUsers.Clear()
        DaUsers.Fill(DsFrmWorkOrders1.AddUsers)
        DsFrmWorkOrders1.AddUsers.AddAddUsersRow("", 0)
        DsFrmWorkOrders1.ChgUsers.Clear()
        DaUsers.Fill(DsFrmWorkOrders1.ChgUsers)
        DsFrmWorkOrders1.ChgUsers.AddChgUsersRow("", 0)

        MyFrmGetStyle.Cnn.ConnectionString = PConnectionString

        Call FillTechnicianCombo()
        Call FillServiceKindCombo()

        LblCompanyName.Text = PubCompanyName
        LblStoreName.Text = PubStoreName
        Try
            CmbAddUser.SelectedValue = PUserCod
        Catch ex As Exception
            CmbAddUser.SelectedValue = 0
        End Try

        CmbType.SelectedValue = TypeOfForm
        LblType.Text = CmbType.SelectedItem.Value
        Me.Text = TypeOfForm & " - " & LblType.Text
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        TxtRef.Text = TakeLastRef(TypeOfForm)

        Call LoadAWotkOrder(TxtRef.Text)
        Call EnableDisableField(False)

        ThisFormStatus = MainModule.WorkStates._ReadOnly

    End Sub
    Private Sub FillServiceKindCombo()
        Dim dr As DataRow
        dr = DsFrmWorkOrders1.Type_select.NewRow
        dr("Code") = " "
        dr("Desc") = " "
        DsFrmWorkOrders1.Type_select.Rows.Add(dr)
        Dim i As Double
        For i = 0 To TypeOfWorkOrderItemCount - 1
            dr = DsFrmWorkOrders1.Type_select.NewRow
            dr("Code") = TypeOfWorkOrderItem(i)
            dr("Desc") = DescOfWorkOrderItem(i)
            DsFrmWorkOrders1.Type_select.Rows.Add(dr)
        Next
        GrdDetail.DropDowns("DropDownTypeSelect").SetDataBinding(DsFrmWorkOrders1, "Type_select")
    End Sub
    Private Sub FillTechnicianCombo()
        'Dim Types As GridEXColumn = GrdDetail.RootTable.Columns("cod_technician")
        'Types.HasValueList = True
        'Types.ColumnType = ColumnType.Text
        'Types.EditType = EditType.DropDownList
        'Dim valueList As GridEXValueListItemCollection = Types.ValueList
        'Dim row As DSFrmWorkOrders.service_center_dtlRow
        'Dim item As GridEXValueListItem
        'item = New GridEXValueListItem(" ", " ")
        'valueList.Add(item)
        'Dim i As Double
        'For i = 0 To DsFrmWorkOrders1.employee.Rows.Count - 1
        '    item = New GridEXValueListItem(DsFrmWorkOrders1.employee.Rows(i).Item("employee_code"), DsFrmWorkOrders1.employee.Rows(i).Item("employee_code"))
        '    valueList.Add(item)
        'Next

        'Dim dr As DataRow
        'dr = DsFrmWorkOrders1.employee.NewRow
        'dr("employee_code") = " "
        'dr("employee_Name") = " "
        'DsFrmWorkOrders1.Type_select.Rows.Add(dr)
        GrdDetail.DropDowns("DropDownTechnician").SetDataBinding(DsFrmWorkOrders1, "Employee")
    End Sub
    Private Sub AddEmptyRecordToDetail(ByVal ThisId_service_center As String, ByVal ThisRadif As Integer)
        Try
            Dim dr As DataRow
            dr = DsFrmWorkOrders1.service_center_dtl.NewRow
            dr("id_service_center") = ThisId_service_center
            dr("radif") = ThisRadif
            dr("type_select") = " "
            dr("cod_select") = ""
            dr("desc_radif") = ""
            dr("qty") = 0
            dr("price") = 0
            dr("fet") = 0
            dr("taxable") = 1
            dr("cod_technician") = ""
            DsFrmWorkOrders1.service_center_dtl.Rows.Add(dr)
        Catch ex As Exception
        End Try
    End Sub
    Private Function MakeNewRef(ByVal InType As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select Max(id_service_center) as Max_id_service_center from service_center_head Where type_of_form=" & Qt(InType)
        Try
            MakeNewRef = Getcod(Str(Val(Mid(CmdGeneral.ExecuteScalar, 3, 6)) + 1).Trim, 6)
        Catch ex As Exception
            MakeNewRef = PubStartWorkOrderNo
        End Try
        MakeNewRef = InType & MakeNewRef
        'CmdGeneral.Connection.Close()
    End Function
    Private Function TakeLastRef(ByVal InType As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 id_service_center as Max_id_service_center from service_center_head Where type_of_form=" & Qt(InType) & "  ORDER BY id_service_center DESC"
        Try
            TakeLastRef = Trim(CmdGeneral.ExecuteScalar & "")
        Catch ex As Exception
            TakeLastRef = ""
        End Try

        If IsNothing(TakeLastRef) Then
            TakeLastRef = ""
        End If
        CmdGeneral.Connection.Close()
    End Function
    Private Sub GrdDetail_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdDetail.FormattingRow
        If e.Row.RowType = RowType.Record Then
            Select Case e.Row.Cells("type_select").Value
                Case "I"
                    e.Row.Cells("type_select").ToolTipText = "Items (Products)"
                Case "L"
                    e.Row.Cells("type_select").ToolTipText = "Labor (Services)"
                Case "F"
                    e.Row.Cells("type_select").ToolTipText = "Fees"
                Case "P"
                    e.Row.Cells("type_select").ToolTipText = "Package"
                Case "C"
                    e.Row.Cells("type_select").ToolTipText = "Comments"
                Case "A"
                    e.Row.Cells("type_select").ToolTipText = "Adjustment For Tires"
                Case "T"
                    e.Row.Cells("type_select").ToolTipText = "Trade_In"
                Case "S"
                    e.Row.Cells("type_select").ToolTipText = "Shop Supplies"
                Case "O"
                    e.Row.Cells("type_select").ToolTipText = "Outside Purchases"
            End Select

            'If e.Row.Cells("type_select").Value = "I" Then
            '    e.Row.Cells("type_select"). = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
            '    e.Row.Cells("type_select").ToolTipText = "Items"
            'ElseIf CType(e.Row.Cells("OnSale").Value, Boolean) Then
            '    e.Row.Cells("StatusIcon").ImageIndex = imageIndexOnSale
            '    e.Row.Cells("StatusIcon").ToolTipText = "Product is on sale"
            'End If
        End If
    End Sub
    Private Sub CmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged
        LblType.Text = CmbType.SelectedItem.Value
        Me.Text = TypeOfForm & " - " & LblType.Text
    End Sub

    'Private Sub GrdDetail_InitCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.InitCustomEditEventArgs) Handles GrdDetail.InitCustomEdit
    '    'For the sample, we will allow to edit the CustomerID field
    '    'only in new rows. So, we set the ReadOnly property to false
    '    'if rows with RowType seet to Record.
    '    If e.Row.RowType = RowType.NewRecord Then
    '        txtCustom.ReadOnly = False
    '    Else
    '        txtCustom.ReadOnly = True
    '    End If

    '    'When the user start edition by pressing a key, the EditChar
    '    'property holds the char that started the edition. If edition
    '    'was started because the user clicked in the cell the EditChar
    '    'returns (char)0
    '    If e.EditChar <> "" AndAlso Not txtCustom.ReadOnly Then
    '        txtCustom.Text = e.EditChar.ToString()
    '        txtCustom.SelectionStart = txtCustom.Text.Length
    '    Else
    '        If e.Value Is Nothing Then
    '            txtCustom.Text = ""
    '        Else
    '            txtCustom.Text = e.Value.ToString()
    '        End If
    '        txtCustom.SelectionLength = txtCustom.Text.Length
    '    End If
    '    'Set the EditControl property to let the GridEX control
    '    'know which control to position in the cell.
    '    e.EditControl = txtCustom
    'End Sub

    'Private Sub GrdDetail_EndCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EndCustomEditEventArgs) Handles GrdDetail.EndCustomEdit
    '    'Compare the original value with the value in the control.
    '    If txtCustom.Text.CompareTo(e.Value) <> 0 Then
    '        'If the value is different, set the DataChanged property to true
    '        'to indicate the control that it has to update the cell value.
    '        e.DataChanged = True
    '        e.Value = txtCustom.Text
    '    End If
    'End Sub
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        License_No1.CodCustomerForAdd = CustomerCod1.Text
        If CanChangeCustomerNameFlag Then
            LblCustomerCompanyname.Text = CustomerCod1.abbreviation_name
            TxtCustomerFName.Text = CustomerCod1.F_Name
            TxtCustomerMName.Text = CustomerCod1.M_Name
            TxtCustomerLName.Text = CustomerCod1.L_Name
        End If
        If FlagResetTaxVar = False Then
            Call CalcTax()
        End If

        License_No1.CodCustomerForFilter = CustomerCod1.Text

        PhoneButton1.FillDataSet("cust_trtab_main", "cod_customer=" & Qt(CustomerCod1.Text))
        PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()

        If False Then
            Dim c1 As New FrmWhatDoForMenu
            If 1 Then
                c1.BtnCenterText = "Cancel Work"
            Else
                c1.BtnLeftText = "Cancel Work"
                c1.BtnRightText = "Continue"
            End If
            c1.ShowFarMsg("The Customer is past due over 90 days")
            If c1.DialogResult = DialogResult.OK Then
            Else
                CustomerCod1.CustomerCod = ""
                CustomerCod1.Focus()
            End If
        End If
        'If CustomerCod1.Enabled Then
        '    TxtPo_No.Enabled = CustomerCod1.PoIsRequired
        '    TxtPo_No.TabStop = TxtPo_No.Enabled
        'End If

        If CustomerCod1.Text.Trim.ToUpper = "CASH" And CustomerCod1.Enabled Then
            TxtCustomerFName.Enabled = True
            TxtCustomerMName.Enabled = True
            TxtCustomerLName.Enabled = True
            PhoneNoMain.Enabled = True
        Else
            TxtCustomerFName.Enabled = False
            TxtCustomerMName.Enabled = False
            TxtCustomerLName.Enabled = False
            PhoneNoMain.Enabled = False
        End If

        ''''''''''''''If License_No1.Enabled And CustomerCod1.Focus = True Then
        ''''''''''''''    License_No1.Focus()
        ''''''''''''''End If
    End Sub
    Private Sub CustomerCod1_NotFindCustomerCod() Handles CustomerCod1.NotFindCustomerCod
        License_No1.CodCustomerForAdd = ""
        License_No1.CodCustomerForFilter = ""
        License_No1.FieldCodValue = 0
        LblVehicleMake.Text = ""
        LblVehicleModel.Text = ""
        LblVehicleVin.Text = ""
        LblVehicleYear.Text = ""

        TxtCustomerFName.Clear()
        TxtCustomerMName.Clear()
        TxtCustomerLName.Clear()
        LblCustomerCompanyname.Text = ""
        PhoneNoMain.Text = ""
        Call PhoneButton1.ClearPhoneScreen()
        'TxtPo_No.Clear()
        'TxtPo_No.Enabled = False
        'TxtPo_No.TabStop = TxtPo_No.Enabled
        NumTax.Text = 0
    End Sub
    Private Sub BtnCustomerDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerDetail.Click
        Dim MyFrmCustomer As New UCCustomer.FrmCustomer
        MyFrmCustomer.CustomerCodTempVar = CustomerCod1.CustomerCod
        MyFrmCustomer.StartPosition = FormStartPosition.CenterScreen
        MyFrmCustomer.ThisFormStatus = MainModule.WorkStates._ReadOnly
        MyFrmCustomer.ShowDialog()
    End Sub
    Private Sub BtnCustomerHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerHistory.Click
        Dim MyFrmCustomerHistory As New UCCustomer.FrmCustomerHistory
        MyFrmCustomerHistory.Cod_customerParameter = CustomerCod1.CustomerCod
        MyFrmCustomerHistory.LblCompany.Text = LblCustomerCompanyname.Text
        MyFrmCustomerHistory.LblName.Text = CustomerCod1.CustomerDesc
        MyFrmCustomerHistory.ShowDialog()
    End Sub
    Private Sub BtnCustomerBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerBalance.Click
        Dim MyFrmCustomerBalance As New UCCustomer.FrmCustomerBalance
        MyFrmCustomerBalance.Cod_customerParameter = CustomerCod1.CustomerCod
        MyFrmCustomerBalance.LblCustomer.Text = CustomerCod1.CustomerCod
        MyFrmCustomerBalance.LblCompany.Text = LblCustomerCompanyname.Text
        MyFrmCustomerBalance.LblName.Text = CustomerCod1.F_Name & " " & CustomerCod1.M_Name & " " & CustomerCod1.L_Name
        MyFrmCustomerBalance.ShowDialog()
    End Sub
    Private Function CheckCanEdit() As Boolean
        CheckCanEdit = True
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        CmdGeneral.CommandText = "SELECT Count(*) FROM GL_AP_payment WHERE id_service_center= " & Qt(TxtRef.Text)
        If CmdGeneral.ExecuteScalar() > 0 Then
            CheckCanEdit = False
            MsgFar("The Outside Purchases of This Invoice has related Payment.System can't Delete This Record.")
            Exit Function
        End If

        CmdGeneral.CommandText = "SELECT  count(*) FROM  GL_account_adjustment_dtl where id_service_center = " & Qt(TxtRef.Text)
        If CmdGeneral.ExecuteScalar() > 0 Then
            CheckCanEdit = False
            CmdGeneral.CommandText = "SELECT top 1 refrence_no FROM  GL_account_adjustment_dtl where id_service_center = " & Qt(TxtRef.Text)
            MsgFar("This" & LblType.Text.Trim & " has related Adjustment.System can't Delete This Record.(" & CmdGeneral.ExecuteScalar & ")")
            Exit Function
        End If

        CmdGeneral.CommandText = "SELECT  Count(*) FROM  GL_payment_deposit INNER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no WHERE Refer_Type='2' AND GL_payment_deposit.id_service_center = " & Qt(TxtRef.Text)
        If CmdGeneral.ExecuteScalar() > 0 Then
            CheckCanEdit = False
            CmdGeneral.CommandText = "SELECT top 1 GL_payment_deposit.refrence_no FROM  GL_payment_deposit INNER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receive_payment.refrence_no WHERE Refer_Type='2' AND GL_payment_deposit.id_service_center = " & Qt(TxtRef.Text)
            MsgBox("This invoive has Payment In Receive Payment.(" & CmdGeneral.ExecuteScalar & ")")
        End If

        CmdGeneral.CommandText = "SELECT  COUNT(*) FROM  GL_payment_deposit WHERE  (ID_payment IN (SELECT ID_Payment FROM  GL_debit_deposit WHERE GL_payment_deposit.Id_Service_center=" & Qt(TxtRef.Text) & " )) "
        If CmdGeneral.ExecuteScalar() > 0 Then
            CheckCanEdit = False
            MsgBox("Payment for this invoice was deposited , and may not be edited.")
        End If

        CmdGeneral.CommandText = "SELECT count(*)  FROM  GL_AP_payment WHERE id_service_center= " & Qt(TxtRef.Text)
        If CmdGeneral.ExecuteScalar() > 0 Then
            CheckCanEdit = False
            MsgFar("The Outside Purchases of This Invoice has Prepared for payment.System can't Change This Record.")
            Exit Function
        End If

        CmdGeneral.CommandText = "SELECT Count(*) FROM GL_payment_deposit WHERE  Downpayment_Wo_No= " & Qt(TxtRef.Text)
        If CmdGeneral.ExecuteScalar() > 0 Then
            CheckCanEdit = False
            MsgBox("Down Payment for this invoice was used , and may not be edited or deleted.")
            Exit Function
        End If

    End Function
    Private Function CheckIsThisOrderConvert() As Boolean
        CheckIsThisOrderConvert = False
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select type_of_form from service_center_head where id_service_center_Before=" & Qt(TxtRef.Text)
        Dim TypeVar As String = CmdGeneral.ExecuteScalar() & ""
        If Trim(TypeVar).Length > 0 Then
            Select Case Trim(TypeVar)
                Case "IN"
                    MsgFar("This Work Order is converted to an Invoice " & vbCrLf & "And cannot be deleted or edited any more.")
                Case "WO"
                    MsgFar("This Estimate is converted to a Work Order " & vbCrLf & "And cannot be deleted or edited any more.")
                Case "ES"
                    MsgFar("This Form is converted to a Estimate " & vbCrLf & "And cannot be deleted or edited any more.")
                Case "RT"
                    MsgFar("This Invoice has a Returned " & vbCrLf & "And cannot be deleted or edited any more.")
            End Select
            CheckIsThisOrderConvert = True
            Exit Function
        End If
    End Function
    Private Sub BtnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConvert.Click
        Dim TypeOFConvert As String = "IN"
        If ThisFormStatus = MainModule.WorkStates._ReadOnly And TxtRef.Text.Trim.Length > 0 Then
            If CheckIsThisOrderConvert() Then
                Exit Sub
            End If
            If CmbType.Text = "RT" Then
                MsgFar("Return can not change to other form")
                Exit Sub
            End If
            If CmbType.Text = "IN" Then
                MsgFar("Invoice can not change to other form")
                Exit Sub
            End If
            If CmbType.Text = "WO" And DsFrmWorkOrders1.service_center_dtl.Rows(0).Item(0) = "B" Then
                MsgFar("Can not change to other form")
                Exit Sub
            End If

            If CmbType.Text = "ES" Then
                Dim c1 As New FrmWhatDoForMenu
                c1.BtnLeftText = "Cancel"
                c1.BtnCenterText = "Work Order"
                c1.BtnRightText = "Invoice"
                c1.ShowFarMsg("Convert Estimate to :")
                Select Case c1.DialogResult
                    Case DialogResult.Yes ' Work Order
                        TypeOFConvert = "WO"
                    Case DialogResult.OK ' Invoice
                        TypeOFConvert = "IN"
                    Case Else 'Cancel
                        Exit Sub
                End Select
            End If
            If CheckCanChangeToInvocie() Then
                Exit Sub
            End If
            If ChangeTypeOfForm(TypeOFConvert).Trim.Length = 0 Then
                MsgBox("System can't Convert This " & LblType.Text & ".Please Try Again.", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub BtnCashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCashier.Click, BtnCashierCopy.Click
        ''''If LblTotal.Numbervalue = 0 Then
        ''''    MsgBox("Total Amount is Zero !!!!!!")
        ''''Else
        Call CalcSumOfExt_price()
        If ThisFormStatus = MainModule.WorkStates._ReadOnly And TxtRef.Text.Trim.Length > 0 Then
            If CheckIsThisOrderConvert() Then
                Exit Sub
            End If
        End If
        If CmbType.Text = "RT" Then
            If BtnNew.Enabled = False Then
                Call EnableDisableSave()
                If BtnSave.Enabled Then
                    'If ThisFormStatus = MainModule.WorkStates.AddNew Then
                    If Not psave(False) Then
                        Exit Sub
                    End If
                    'End If
                Else
                    Exit Sub
                End If
            End If
            If TxtRef.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            Dim MyFrmCashierForReturn As New FrmCashierForReturn
            MyFrmCashierForReturn.TxtRefvar = TxtRef.Text
            MyFrmCashierForReturn.Datevar = TxtDate.Text
            MyFrmCashierForReturn.CustomerCodvar = CustomerCod1.CustomerCod
            MyFrmCashierForReturn.ThisFormStatus = ThisFormStatus
            MyFrmCashierForReturn.InvoiceNoForReturnVar = InvoiceNoForReturnVar & ""
            MyFrmCashierForReturn.TotalAmountOfReturnVar = LblTotal.Text
            MyFrmCashierForReturn.ShowDialog()
            If MyFrmCashierForReturn.IsOK Then
                Call CashierReturnSave(MyFrmCashierForReturn)
                'Call BtnCancel_Click(sender, e)
                Call CancelAndLoadAWorkOrder(TxtRef.Text)
            Else
                If ThisFormStatus = MainModule.WorkStates.AddNew Then
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "DELETE FROM service_center_head Where id_service_center=" & Qt(TxtRef.Text)
                    CmdGeneral.ExecuteNonQuery()
                    ReturnWasSavedFlag = False
                End If
            End If
        Else
            'If CheckIsThisOrderConvert() Then
            '    Exit Sub
            'End If
            If BtnNew.Enabled = False Then
                Call EnableDisableSave()
                If BtnSave.Enabled Then
                    If ThisFormStatus = MainModule.WorkStates.AddNew Then
                        If Not psave(False) Then
                            Exit Sub
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End If
            If TxtRef.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            If CheckCanChangeToInvocie() Then
                Exit Sub
            End If
            Dim MyFrmCashier As New FrmCashier
            MyFrmCashier.ChargeFlagVar = CustomerCod1.ARCharge
            MyFrmCashier.CheckFlagVar = CustomerCod1.AcceptCheck
            MyFrmCashier.CreditHoldFlagVar = CustomerCod1.ARCreditHold
            MyFrmCashier.TxtRef.Text = TxtRef.Text
            MyFrmCashier.TxtDate.Text = TxtDate.Text
            MyFrmCashier.NumAmount.Text = LblTotal.Text
            MyFrmCashier.CustomerCod1.CustomerCod = CustomerCod1.CustomerCod
            MyFrmCashier.ThisFormStatus = ThisFormStatus
            MyFrmCashier.ShowDialog()
            Dim NewIdInserted As String = ""
            If MyFrmCashier.IsOK Then
                If Not psave(False, True) Then
                    Exit Sub
                End If
                ''''''''''''Call CashierSave(MyFrmCashier)
            End If
            If MyFrmCashier.IsOK Then
                If CmbType.Text <> "IN" Then
                    NewIdInserted = ChangeTypeOfForm()
                    If NewIdInserted.Trim.Length = 0 Then
                        'MsgBox("Error In Save Cashier Information.")
                        Exit Sub
                    End If
                Else
                    NewIdInserted = TxtRef.Text
                End If
            End If
            If MyFrmCashier.IsOK And NewIdInserted.Trim.Length > 0 Then
                Call CashierSave(MyFrmCashier, NewIdInserted)
            End If
            If MyFrmCashier.IsPrintFlag Then
                Call pprint("print", "IN", NewIdInserted, True)
            End If
            If MyFrmCashier.IsOK Then
                ''''''''''''''''''''khode hamid goft in karo konam Call BtnNew_Click(sender, e)
                'Call BtnCancel_Click(sender, e)
                Call CancelAndLoadAWorkOrder(TxtRef.Text)
            End If
        End If
        '''''End If
    End Sub
    Private Function CashierReturnSave(ByRef MyFrmCashierForReturn As FrmCashierForReturn) As Boolean
        Dim ID_paymentVar As Double

        CashierReturnSave = True

        If MyFrmCashierForReturn.NumBalance.Numbervalue <> 0 Then
            MsgBox("The Balance is not Zero." & vbCrLf & "Cash Amount + Charge Amount + A/R Remainder Amount  :  Should be Equal to the Total Price of Return.")
            CashierReturnSave = False
            Exit Function
        End If

        If MyFrmCashierForReturn.NumCashAmount.Numbervalue > 0 Then 'CASH
            If MyFrmCashierForReturn.CmbGL_account.Text.Trim.Length = 0 Then
                MsgBox("Please set the Account")
                CashierReturnSave = False
                Exit Function
            End If
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select refrence_code FROM GL_Paid_received where tran_type='3' AND id_service_center=" & Qt(TxtRef.Text)
            If Trim(CmdGeneral.ExecuteScalar & "").Trim.Length > 0 Then
                CmdGeneral.CommandText = "UPDATE GL_Paid_received SET amount=" & MyFrmCashierForReturn.NumCashAmount.Text & ",GL_account=" & Qt(MyFrmCashierForReturn.CmbGL_account.SelectedValue) & " where tran_type='3' AND id_service_center=" & Qt(TxtRef.Text)
                CmdGeneral.ExecuteNonQuery()
            Else
                CmdGeneral.CommandText = "INSERT INTO GL_Paid_received (refrence_code, tran_type, action_date, customer_code, amount, GL_account, OtherReceipType, id_service_center) values (" & Qt(MakeNewRef("RT")) & ",'3'," & Qt(MyFrmCashierForReturn.Datevar) & "," & Qt(MyFrmCashierForReturn.CustomerCodvar) & "," & MyFrmCashierForReturn.NumCashAmount.Text & "," & Qt(MyFrmCashierForReturn.CmbGL_account.SelectedValue) & ",1," & Qt(TxtRef.Text) & ")"
                CmdGeneral.ExecuteNonQuery()
            End If
        Else
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "DELETE FROM GL_Paid_received where tran_type='3' AND id_service_center=" & Qt(TxtRef.Text)
            CmdGeneral.ExecuteNonQuery()
        End If

        If MyFrmCashierForReturn.NumChargeAmount.Numbervalue > 0 Then ' CREDIT
            If MyFrmCashierForReturn.CmbCCType.Text.Trim.Length = 0 Then
                MsgBox("Please set the C.C. Type")
                CashierReturnSave = False
                Exit Function
            End If

            CmdGeneral.CommandText = "Select ID_payment FROM GL_payment_deposit where Refer_type='3' AND payment_type='3' AND id_service_center=" & Qt(TxtRef.Text)
            Try
                ID_paymentVar = CmdGeneral.ExecuteScalar
            Catch ex As Exception
                ID_paymentVar = 0
            End Try
            If ID_paymentVar > 0 Then
                CmdGeneral.CommandText = "UPDATE GL_payment_deposit SET payment_amount=" & MyFrmCashierForReturn.NumChargeAmount.Numbervalue & " WHERE ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "UPDATE GL_payment_credit SET cc_type=" & Qt(MyFrmCashierForReturn.CmbCCType.SelectedValue) & ",cc_card_no=" & Qt(MyFrmCashierForReturn.TXTCardNo.Text) & " WHERE ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
            Else
                CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount) values (" & Qt(TxtRef.Text) & ",NULL,'3','3'," & MyFrmCashierForReturn.NumChargeAmount.Numbervalue & ");Select @@Identity from GL_payment_deposit"
                ID_paymentVar = CmdGeneral.ExecuteScalar()
                CmdGeneral.CommandText = "Insert Into GL_payment_credit (ID_payment,cc_type,cc_card_no,cc_expire_date_year,cc_expire_date_month,cc_auth_no) values (" & ID_paymentVar & "," & Qt(MyFrmCashierForReturn.CmbCCType.SelectedValue) & "," & Qt(MyFrmCashierForReturn.TXTCardNo.Text) & ",'2099','12','')"
                CmdGeneral.ExecuteNonQuery()
            End If
        Else
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select ID_payment FROM GL_payment_deposit where Refer_type='3' AND payment_type='3' AND id_service_center=" & Qt(TxtRef.Text)
            Try
                ID_paymentVar = CmdGeneral.ExecuteScalar
            Catch ex As Exception
                ID_paymentVar = 0
            End Try
            If ID_paymentVar > 0 Then
                CmdGeneral.CommandText = "DELETE FROM GL_payment_deposit WHERE ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "DELETE FROM GL_payment_credit WHERE ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
            End If
        End If

        If MyFrmCashierForReturn.DsFrmCashierForReturn1.GL_payment_deposit.Rows.Count > 0 Then 'AR
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Dim i As Integer
            For i = 0 To MyFrmCashierForReturn.DsFrmCashierForReturn1.GL_payment_deposit.Rows.Count - 1
                If MyFrmCashierForReturn.DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("amount_Paid") < MyFrmCashierForReturn.DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("payment_amount") Then
                    CmdGeneral.CommandText = "update GL_payment_AR Set Cancel_Flag=1 where ID_payment=" & MyFrmCashierForReturn.DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("ID_payment")
                    CmdGeneral.ExecuteNonQuery()
                Else
                    CmdGeneral.CommandText = "update GL_payment_AR Set Cancel_Flag=0 where ID_payment=" & MyFrmCashierForReturn.DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("ID_payment")
                    CmdGeneral.ExecuteNonQuery()
                End If
            Next


            CmdGeneral.CommandText = "Select count(*) FROM GL_payment_deposit WHERE id_service_center=" & Qt(TxtRef.Text) & " AND refer_type='3' AND payment_type='4' "
            If CmdGeneral.ExecuteScalar > 0 Then
                CmdGeneral.CommandText = "UPDATE GL_payment_deposit SET payment_amount=" & MyFrmCashierForReturn.NumAmountReminder.Numbervalue & " WHERE id_service_center=" & Qt(TxtRef.Text) & " AND refer_type='3' AND payment_type='4' "
                CmdGeneral.ExecuteNonQuery()
            Else
                CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount) values (" & Qt(TxtRef.Text) & ",NULL,'3','4'," & MyFrmCashierForReturn.NumAmountReminder.Numbervalue & ");Select @@Identity from GL_payment_deposit"
                ID_paymentVar = CmdGeneral.ExecuteScalar()
            End If
        End If
    End Function
    Private Sub CashierSave(ByRef MyFrmCashier As FrmCashier, ByVal ThisRefNo As String)
        Dim ID_paymentVar As Decimal

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdReader.Connection.State <> ConnectionState.Open Then
            CmdReader.Connection.Open()
        End If
        CmdReader.CommandText = "Select ID_payment From GL_payment_deposit where refer_type='1' AND id_service_center=" & Qt(ThisRefNo)
        SQLReader = CmdReader.ExecuteReader
        If SQLReader.HasRows Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Do While SQLReader.Read()
                ID_paymentVar = SQLReader.Item("ID_payment")
                CmdGeneral.CommandText = "Delete FROM GL_payment_cash where ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "Delete FROM GL_payment_check where ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "Delete FROM GL_payment_Credit where ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "Delete FROM GL_payment_AR where ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "Delete FROM GL_payment_deposit where ID_payment=" & ID_paymentVar
                CmdGeneral.ExecuteNonQuery()
            Loop
        End If
        SQLReader.Close()
        CnnReader.Close()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim i As Integer
        Dim AmountVar As Decimal
        For i = 1 To 6
            Select Case i
                Case 1
                    AmountVar = MyFrmCashier.NumCashRendered.Text - MyFrmCashier.NumChangeDue.Text
                Case 2
                    AmountVar = MyFrmCashier.NumCheckAmount.Text
                Case 3
                    AmountVar = MyFrmCashier.NumChargeAmount.Text
                Case 4
                    AmountVar = MyFrmCashier.NumARAmount.Text
                Case 5
                    AmountVar = MyFrmCashier.NumOverPayment.Text
                Case 6
                    AmountVar = MyFrmCashier.NumDownPayment.Text
            End Select
            If AmountVar > 0 Then
                Select Case i
                    Case 1
                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount) values (" & Qt(ThisRefNo) & ",NULL,'1'," & Qt(Str(i).Trim) & "," & AmountVar & ");Select @@Identity from GL_payment_deposit"
                        ID_paymentVar = CmdGeneral.ExecuteScalar()

                        CmdGeneral.CommandText = "Insert Into GL_payment_cash (ID_payment,cash_rendered,change_due) values (" & ID_paymentVar & "," & MyFrmCashier.NumCashRendered.Text & "," & MyFrmCashier.NumChangeDue.Text & ")"
                        CmdGeneral.ExecuteNonQuery()
                    Case 2
                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount) values (" & Qt(ThisRefNo) & ",NULL,'1'," & Qt(Str(i).Trim) & "," & AmountVar & ");Select @@Identity from GL_payment_deposit"
                        ID_paymentVar = CmdGeneral.ExecuteScalar()

                        CmdGeneral.CommandText = "Insert Into GL_payment_check (ID_payment,check_no,check_Date) values (" & ID_paymentVar & "," & Qt(MyFrmCashier.TxtCheckNo.Text) & ",'')"
                        CmdGeneral.ExecuteNonQuery()
                    Case 3
                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount) values (" & Qt(ThisRefNo) & ",NULL,'1'," & Qt(Str(i).Trim) & "," & AmountVar & ");Select @@Identity from GL_payment_deposit"
                        ID_paymentVar = CmdGeneral.ExecuteScalar()

                        CmdGeneral.CommandText = "Insert Into GL_payment_credit (ID_payment,cc_type,cc_card_no,cc_expire_date_year,cc_expire_date_month,cc_auth_no) values (" & ID_paymentVar & "," & Qt(MyFrmCashier.CmbCCType.SelectedValue) & "," & Qt(MyFrmCashier.TXTCardNo.Text) & "," & Qt(MyFrmCashier.NumYear.Text) & "," & Qt(MyFrmCashier.NumMonth.Text) & "," & Qt(MyFrmCashier.TxtAuthNo.Text) & ")"
                        CmdGeneral.ExecuteNonQuery()
                    Case 4
                        If CmdReader.Connection.State <> ConnectionState.Open Then
                            CmdReader.Connection.Open()
                        End If
                        CmdReader.CommandText = "Select top 1 * From GL_TAB_AR_TERM where AR_terms=" & Qt(MyFrmCashier.CmbARTerms.SelectedValue)
                        SQLReader = CmdReader.ExecuteReader
                        If SQLReader.HasRows Then
                            SQLReader.Read()
                            If SQLReader.Item("KIND_AR") = 3 And SQLReader.Item("MP_NO_OF_PAYMENT") > 0 Then
                                Dim NO_OF_PAYMENTCounter As Integer
                                Dim EachPayvar As Decimal
                                EachPayvar = Math.Round(AmountVar / SQLReader.Item("MP_NO_OF_PAYMENT"), 2)
                                For NO_OF_PAYMENTCounter = 1 To SQLReader.Item("MP_NO_OF_PAYMENT")
                                    If NO_OF_PAYMENTCounter = SQLReader.Item("MP_NO_OF_PAYMENT") Then
                                        EachPayvar = AmountVar - (EachPayvar * (NO_OF_PAYMENTCounter - 1))
                                    End If
                                    CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount) values (" & Qt(ThisRefNo) & ",NULL,'1'," & Qt(Str(i).Trim) & "," & EachPayvar & ");Select @@Identity from GL_payment_deposit"
                                    ID_paymentVar = CmdGeneral.ExecuteScalar()
                                    CmdGeneral.CommandText = "Insert Into GL_payment_AR (ID_payment,AR_terms,AR_due_date) values (" & ID_paymentVar & "," & Qt(MyFrmCashier.CmbARTerms.SelectedValue) & "," & Qt(Format(CType(MyFrmCashier.DteDueDate.Text, Date).AddMonths(NO_OF_PAYMENTCounter), PubDateFormat)) & ")"
                                    CmdGeneral.ExecuteNonQuery()
                                Next
                            Else
                                CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount) values (" & Qt(ThisRefNo) & ",NULL,'1'," & Qt(Str(i).Trim) & "," & AmountVar & ");Select @@Identity from GL_payment_deposit"
                                ID_paymentVar = CmdGeneral.ExecuteScalar()
                                CmdGeneral.CommandText = "Insert Into GL_payment_AR (ID_payment,AR_terms,AR_due_date) values (" & ID_paymentVar & "," & Qt(MyFrmCashier.CmbARTerms.SelectedValue) & "," & Qt(MyFrmCashier.DteDueDate.Text) & ")"
                                CmdGeneral.ExecuteNonQuery()
                            End If
                            SQLReader.Close()
                        End If
                    Case 5
                        Dim refrence_no_Gl_receive_paymentVar As String
                        CmdGeneral.CommandText = " SELECT top 1 refrence_no FROM View_Balance_For_Each_OverPayment Where BalanceOverPaymentAmount>0 AND cod_customer=" & Qt(CustomerCod1.CustomerCod)
                        refrence_no_Gl_receive_paymentVar = CmdGeneral.ExecuteScalar() & ""

                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount,refrence_no_Gl_receive_payment) values (" & Qt(ThisRefNo) & ",NULL,'1'," & Qt(Str(i).Trim) & "," & AmountVar & "," & Qt(refrence_no_Gl_receive_paymentVar) & ")"
                        ID_paymentVar = CmdGeneral.ExecuteNonQuery
                    Case 6
                        Dim Downpayment_Wo_NoVar As String
                        CmdGeneral.CommandText = " SELECT top 1 Downpayment_Wo_No FROM View_Balance_For_Each_DownPayment Where BalanceDownPaymentAmount>0 AND customer_code=" & Qt(CustomerCod1.CustomerCod)
                        Downpayment_Wo_NoVar = CmdGeneral.ExecuteScalar() & ""

                        CmdGeneral.CommandText = "Insert Into GL_payment_deposit (id_service_center,refrence_no,refer_type,payment_type,payment_amount,Downpayment_Wo_No) values (" & Qt(ThisRefNo) & ",NULL,'1'," & Qt(Str(i).Trim) & "," & AmountVar & "," & Qt(Downpayment_Wo_NoVar) & ")"
                        ID_paymentVar = CmdGeneral.ExecuteNonQuery
                End Select
            End If
        Next
        CmdGeneral.Connection.Close()
    End Sub
    Private Function CheckCanChangeToInvocie() As Boolean
        CheckCanChangeToInvocie = False
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        Dim IsMileageMandatory As Boolean = OleDbReaderForStore.Item("RULES2")
        Dim IsTechnicianMandatory As Boolean = OleDbReaderForStore.Item("RULES3")
        OleDbReaderForStore.Close()
        If IsMileageMandatory And NumCurrent_mileage.Numbervalue = 0 And License_No1.FieldCodValue > 0 And License_No1.Enabled Then



            ' çò ò‰„ «ê— òÌ·Ê„ — ÃœÌœ ‰“œÂ ‰ Ê‰Â –ŒÌ—Â ò‰Â



            CheckCanChangeToInvocie = True
            MsgBox("Please enter new mileage for this vehicle before saving the invoice.")
            Exit Function
        End If
        If IsTechnicianMandatory Then
            Dim i As Integer
            For i = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
                If DsFrmWorkOrders1.service_center_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                    If Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")) = "F" Or Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")) = "L" Then
                        Mylabor_service.cod_Service = DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select")
                        Mylabor_service.FindDesc(Mylabor_service.cod_Service)
                        If Mylabor_service.Require_technician And Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_technician") & "").Length = 0 Then
                            CheckCanChangeToInvocie = True
                            MsgBox("Please enter the Technician(s) for the line item no " & Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Cod_select")))
                            Exit Function
                        End If
                    End If
                End If
            Next
        End If

        If CustomerCod1.PoIsRequired And TxtPo_No.Text.Trim.Length = 0 Then
            CheckCanChangeToInvocie = True
            MsgBox("Please enter PO for this customer before saving the invoice.")
            TxtPo_No.Focus()
            Exit Function
        End If






        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        ' oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        If False Then ' CHKRULES_USE_CREDIT_LIMITED
            Dim BalanceTemp As Decimal
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT BalanceAmount FROM View_Customer_Balance WHERE cod_customer= " & Qt(CustomerCod1.CustomerCod)
                BalanceTemp = CmdGeneral.ExecuteScalar
            Catch ex As Exception
                BalanceTemp = 0
            End Try
            If BalanceTemp > CustomerCod1.CreditLimit Then

























                MsgBox("Over Credit Limit")
            End If
        End If
    End Function
    Private Function ChangeTypeOfForm(Optional ByVal TypeInParam As String = "IN") As String
        ChangeTypeOfForm = ""
        Dim Newid_service_center As String = ""
        Dim IDENTITYVar As Decimal
        Dim iii As Integer = 0
        Dim TodayDateVar As String = Format(Now.Date, PubDateFormat)
        'Dim tran1 As SqlClient.SqlTransaction
        'tran1 = Cnn.BeginTransaction()
        'CmdGeneral.Transaction = tran1

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select id_service_center From service_center_head Where id_service_center_Before=" & Qt(TxtRef.Text)
        Dim id_service_centerTempVar As String = ""
        id_service_centerTempVar = CmdGeneral.ExecuteScalar & ""
        If id_service_centerTempVar.Trim.Length > 0 Then
            MsgBox("This Form Was Converted to " & IIf(TypeInParam = "IN", "Invoice", "Work Order : " & id_service_centerTempVar), MsgBoxStyle.Critical)
            Exit Function
        End If

        For iii = 0 To 10
            Newid_service_center = MakeNewRef(TypeInParam) ' "IN" & Mid(TxtRef.Text, 3, 8)
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "INSERT INTO service_center_head (id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, discount, tax, house_comment, cust_comment, Po_no, add_user,Total,id_service_center_Before) " _
                                   & " VALUES ( " & Qt(Newid_service_center) & ", " & Qt(TypeInParam) & "," & Qt(CustomerCod1.CustomerCod) & "," & IIf(License_No1.FieldCodValue > 0, License_No1.FieldCodValue, "NULL") & "," & Qt(TodayDateVar) & "," & NumDiscount.Text & "," & NumTax.Text & "," & Qt(CommentButton_House.ZCommentText) & "," & Qt(CommentButton_Customer.ZCommentText) & "," & Qt(TxtPo_No.Text) & "," & CmbAddUser.SelectedValue & "," & LblTotal.Text & "," & Qt(TxtRef.Text) & ")"
            Try
                CmdGeneral.ExecuteNonQuery()
                Exit For
            Catch ex As Exception
            End Try
        Next
        If iii = 11 Then
            MsgBox("Please try again")
            'tran1.Rollback()
            Exit Function
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Update GL_payment_deposit set id_service_center=" & Qt(Newid_service_center) & " Where refer_type='1' AND id_service_center=" & Qt(TxtRef.Text)
        CmdGeneral.ExecuteNonQuery()
        Dim i As Double
        For i = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
            If DsFrmWorkOrders1.service_center_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                If Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")).Length > 0 And Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")) <> "P" Then
                    With DsFrmWorkOrders1.service_center_dtl.Rows(i)
                        CmdGeneral.CommandText = "INSERT INTO service_center_dtl (id_service_center, radif, type_select, cod_select, desc_radif, qty, price, fet, taxable, cod_technician, COMMENT_ARTICLE) " _
                                               & " VALUES ( " & Qt(Newid_service_center) & "," & .Item("radif") & "," & Qt(.Item("type_select")) & "," & Qt(.Item("cod_select")) & "," & Qt(.Item("desc_radif")) & "," & .Item("qty") & "," & .Item("price") & "," & .Item("fet") & "," & IIf(.Item("taxable"), 1, 0) & "," & Qt(.Item("cod_technician")) & "," & Qt(.Item("COMMENT_ARTICLE")) & ")"
                        CmdGeneral.ExecuteNonQuery()
                        Select Case Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select"))
                            Case "O"
                                Dim dr As DataRow
                                dr = DsFrmWorkOrders1.service_out_purchases.FindByradif(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("radif"))
                                If Not IsNothing(dr) Then
                                    CmdGeneral.CommandText = "INSERT INTO service_out_purchases " & _
                                          " (id_service_center, radif, cost, fet, markup, cod_vendor, po_no, invoice_no, invoice_date, due_date, tracking_warranty, in_day, in_mile, tracking_core,core_value,line,PaidFlag,AR_terms) Values " & _
                                          " (" & Qt(Newid_service_center) & "," & dr("radif") & "," & dr("cost") & "," & dr("fet") & "," & dr("markup") & "," & IIf(Trim(dr("cod_vendor") & "").Length > 0, Qt(dr("cod_vendor")), "NULL") & "," & Qt(dr("po_no") & "") & "," & Qt(dr("invoice_no") & "") & "," & Qt(dr("invoice_date") & "") & "," & Qt(dr("due_date") & "") & "," & IIf(dr("tracking_warranty"), 1, 0) & "," & dr("in_day") & "," & dr("in_mile") & "," & IIf(dr("tracking_core"), 1, 0) & "," & dr("core_value") & "," & IIf(Trim(dr("Line") & "").Length > 0, Qt(dr("Line")), "NULL") & "," & IIf(dr("PaidFlag"), 1, 0) & "," & IIf(Trim(dr("AR_terms") & "").Length > 0, Qt(dr("AR_terms")), "NULL") & ")"
                                    CmdGeneral.ExecuteNonQuery()
                                    DsFrmWorkOrders1.Service_out_purchases_Dtl.Clear()
                                    If CalcDueDetail(dr("AR_terms"), DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Qty") * dr("cost"), dr("invoice_date"), DsFrmWorkOrders1.Service_out_purchases_Dtl) Then
                                        If DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows.Count > 0 Then
                                            Dim Service_out_purchases_DtlCounter As Integer
                                            For Service_out_purchases_DtlCounter = 0 To DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows.Count - 1
                                                CmdGeneral.CommandText = "INSERT INTO service_out_purchases_Dtl " & _
                                                      " (id_service_center, radif, cost, Due_Date) Values " & _
                                                      " (" & Qt(Newid_service_center) & "," & dr("radif") & "," & DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows(Service_out_purchases_DtlCounter).Item("cost") & "," & Qt(DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows(Service_out_purchases_DtlCounter).Item("Due_Date")) & ")"
                                                CmdGeneral.ExecuteNonQuery()
                                            Next
                                        End If
                                    End If
                                End If
                            Case "A"
                                Dim dr As DataRow
                                dr = DsFrmWorkOrders1.service_tire_adjustment.FindByradif(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("radif"))
                                If Not IsNothing(dr) Then
                                    CmdGeneral.CommandText = "INSERT INTO service_tire_adjustment " & _
                                         "(id_service_center, radif, DOT_safety_code, DOT_serial_no, measured_tread_depth, condition_code, supplier_percent, costomer_portion) Values " & _
                                         "(" & Qt(Newid_service_center) & "," & dr("radif") & "," & Qt(dr("DOT_safety_code") & "") & "," & Qt(dr("DOT_serial_no") & "") & "," & Qt(dr("measured_tread_depth") & "") & "," & Qt(dr("condition_code") & "") & "," & dr("supplier_percent") & "," & dr("costomer_portion") & ")"
                                    CmdGeneral.ExecuteNonQuery()
                                End If
                        End Select
                        Call SetMojoodiAfterSave(TypeInParam, .Item("type_select") & "", .Item("cod_select") & "", .Item("qty"))
                    End With
                End If
            End If
        Next

        CmdGeneral.CommandText = "Insert Into ser_tr_vehicle_dtl (id_service_center,current_mileage) Values(" & Qt(Newid_service_center) & "," & NumCurrent_mileage.Text & ")"
        CmdGeneral.ExecuteNonQuery()

        Call SetPrevMojoodi(TxtRef.Text)

        CmdGeneral.Connection.Close()

        ChangeTypeOfForm = Newid_service_center

        '' MsgBox("This Form Converted to " & IIf(TypeInParam = "IN", "Invoice", "Work Order : " & ChangeTypeOfForm))
    End Function
    Private Sub BtnDownPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownPayment.Click
        If CustomerCod1.Text.Trim.Length > 0 Then
            If CmbType.Text = "WO" Then
                Dim MyFrmGetDownPayment As New FrmGetDownPayment
                MyFrmGetDownPayment.ThisFormStatus = Me.ThisFormStatus
                MyFrmGetDownPayment.id_service_centerVar = Me.TxtRef.Text
                MyFrmGetDownPayment.CustomerCodVar = Me.CustomerCod1.CustomerCod
                MyFrmGetDownPayment.DateVar = Me.TxtDate.Text
                MyFrmGetDownPayment.ShowDialog()
                If MyFrmGetDownPayment.OkFlagVar Then
                    Call psave()
                End If
            Else
                MsgBox("Down Payment is only for Work Ordes", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Please Select The Customer", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnVehicleDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehicleDetail.Click
        If License_No1.FieldCodValue > 0 Then
            Dim MyFrmVehicle As New UCVehicle.FrmVehicle
            MyFrmVehicle.StartPosition = FormStartPosition.CenterScreen
            MyFrmVehicle.Id_VehicleForShow = License_No1.FieldCodValue
            MyFrmVehicle.ShowDialog()
        End If
    End Sub
    Private Sub BtnVehicleHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehicleHistory.Click
        Dim MyFrmVehicleHistory As New UCVehicle.FrmVehicleHistory
        MyFrmVehicleHistory.Id_VehicleParameter = License_No1.FieldCodValue
        MyFrmVehicleHistory.LblCompany.Text = LblCustomerCompanyname.Text
        MyFrmVehicleHistory.LblLicenceNo.Text = License_No1.Text
        MyFrmVehicleHistory.LblMake.Text = LblVehicleMake.Text
        MyFrmVehicleHistory.LblModel.Text = LblVehicleModel.Text
        MyFrmVehicleHistory.LblName.Text = TxtCustomerFName.Text & " " & TxtCustomerMName.Text & " " & TxtCustomerLName.Text
        MyFrmVehicleHistory.ShowDialog()
    End Sub
    Private Sub BtnFindSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindSize.Click
        Dim MyFrmFindSize As New UCInv_Item.FrmFindSize
        Call FitToScreen(BtnFindSize, MyFrmFindSize)
        MyFrmFindSize.ShowDialog()
    End Sub
    Private Sub BtnLaborGuide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaborGuide.Click
        MsgBox("Labor Guide Form")
    End Sub
    'Private Sub License_No1_FindVehicleCod() Handles 
    '    LblVehicleMake.Text = License_No1.VehicleMake
    '    LblVehicleModel.Text = License_No1.VehicleModel
    '    LblVehicleVin.Text = License_No1.VehicleVin
    '    LblVehicleYear.Text = License_No1.VehicleYear
    'End Sub
    'Private Sub License_No1_NotFindVehicleCod()
    '    LblVehicleMake.Text = ""
    '    LblVehicleModel.Text = ""
    '    LblVehicleVin.Text = ""
    '    LblVehicleYear.Text = ""
    'End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CmbType.Text = "RT" Then
            Dim SumOfPaymentVar As Double = 0
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT ISNULL(ROUND(SUM(payment_amount), 2), 0) AS sum_amount_pay FROM GL_payment_deposit WHERE refer_type='3' AND id_service_center = " & Qt(TxtRef.Text)
            SumOfPaymentVar = CmdGeneral.ExecuteScalar
            CmdGeneral.CommandText = "SELECT ISNULL(ROUND(SUM(amount), 2), 0) AS sum_amount_pay FROM GL_Paid_received WHERE tran_type='3' AND OtherReceipType='1' AND id_service_center = " & Qt(TxtRef.Text)
            SumOfPaymentVar = SumOfPaymentVar + CmdGeneral.ExecuteScalar
            If -LblTotal.Text <> SumOfPaymentVar Then
                MsgBox("Please click on Cashier Button and Select a Method of Payment")
                Exit Sub
            End If
        End If
        Call psave()
    End Sub
    Private Function psave(Optional ByVal ThisChangeStatus As Boolean = True, Optional ByVal CalledBeforeCashierFlag As Boolean = False) As Boolean
        psave = False
        Call CalcSumOfExt_price()
        'If LblTotal.Numbervalue = 0 Then
        '    MsgBox("Total Price is Zero.You can't save this information.")
        '    psave = False
        '    Exit Function
        'End If

        If CustomerCod1.ARCharge = False Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Count(*) From GL_payment_deposit Where id_service_center=" & Qt(TxtRef.Text) & " AND refer_type='1' AND payment_type='4'"
            If CmdGeneral.ExecuteScalar() > 0 Then
                MsgBox("Before saving these changes you must do one of the following: " & vbCrLf & _
                       "Change Cashier screen to correct payment method." & vbCrLf & _
                       "OR Change Customer Detail to allow charging to AR.", MsgBoxStyle.Exclamation)
                Exit Function
            End If
        End If

        If CmbType.Text = "RT" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Try
                CmdGeneral.CommandText = "SELECT COUNT(*) FROM GL_payment_deposit WHERE refer_type = '2' AND id_service_center = " & Qt(InvoiceNoForReturnVar)
                If CmdGeneral.ExecuteScalar() > 0 Then
                    MsgBox("The Selected Invoice Has Receive Payments.System Can not Return It.")
                    Exit Function
                End If
            Catch ex As Exception
            End Try
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim BeginingBalanceFlag As Boolean = False
        Dim BeginingBalanceRowCount As Integer = 0
        Dim i As Integer
        Dim ZeroQtyCheckFlagVar As Boolean = True
        For i = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
            If DsFrmWorkOrders1.service_center_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                If Trim(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")).Length > 0 Then
                    BeginingBalanceRowCount = BeginingBalanceRowCount + 1

                    Select Case DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")
                        Case "B"
                            BeginingBalanceFlag = True
                            If Not CustomerCod1.ARCharge Then
                                MsgBox("Only A/R customers may have Beginig balance")
                                Exit Function
                            End If
                        Case "I", "A"
                            CmdGeneral.CommandText = "select count(*) from inv_item where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select")) & ""
                            If CmdGeneral.ExecuteScalar < 1 Then
                                MsgBox("Item no : " & DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select") & " is invalid.")
                                Exit Function
                            End If
                        Case "L"
                            CmdGeneral.CommandText = "select count(*) from inv_tab_labor_service where service_type='01' AND cod_service=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select")) & ""
                            If CmdGeneral.ExecuteScalar < 1 Then
                                MsgBox("Labor ( " & DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select") & " ) is invalid.")
                                Exit Function
                            End If
                        Case "F"
                            CmdGeneral.CommandText = "select count(*) from inv_tab_labor_service where service_type='02' AND cod_service=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select")) & ""
                            If CmdGeneral.ExecuteScalar < 1 Then
                                MsgBox("Fees ( " & DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select") & " ) is invalid.")
                                Exit Function
                            End If
                        Case "S"
                            CmdGeneral.CommandText = "select count(*) from inv_tab_labor_service where service_type='03' AND cod_service=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select")) & ""
                            If CmdGeneral.ExecuteScalar < 1 Then
                                MsgBox("Shop Supply ( " & DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("cod_select") & " ) is invalid.")
                                Exit Function
                            End If
                        Case "O"
                            If IsNothing(DsFrmWorkOrders1.service_out_purchases.FindByradif(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Radif"))) Then
                                MsgBox("Outside Purchase has no detail.Please Enter Outside Purchase Detail")
                                Exit Function
                            Else
                                If Math.Round(Val(DsFrmWorkOrders1.service_out_purchases.FindByradif(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Radif")).Item("Price")), 2) <> Math.Round(Val(DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price")), 2) Then
                                    MsgBox("Outside Purchase Amount is not equal with detail.Please correct it.")
                                    Exit Function
                                End If
                            End If
                    End Select

                    If DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price") < 0 Then
                        MsgBox("You Should Enter Positive Value For Price")
                        Exit Function
                    End If
                    If DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Fet") < 0 Then
                        MsgBox("You Should Enter Positive Value For Fet")
                        Exit Function
                    End If
                    If CmbType.Text = "RT" Then
                        If DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Qty") > 0 Then
                            MsgBox("You Should Enter Negative Value For Qty")
                            Exit Function
                        End If
                    Else
                        If DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Qty") < 0 And DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select") <> "T" Then
                            MsgBox("You Should Enter Positive Value For Qty")
                            psave = False
                            Exit Function
                        End If
                        If ZeroQtyCheckFlagVar Then
                            If DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select") <> "C" And DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Qty") = 0 Then
                                Dim c1 As New FrmWhatDoForMenu
                                c1.BtnLeftText = "Cancel"
                                c1.BtnRightText = "Save"
                                c1.ShowFarMsg("This " & LblType.Text & " has Zero quantity.Do you want to save it anyway?")
                                If c1.DialogResult = DialogResult.Cancel Then
                                    Exit Function
                                ElseIf c1.DialogResult = DialogResult.OK Then
                                    ZeroQtyCheckFlagVar = False
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next
        If BeginingBalanceFlag And BeginingBalanceRowCount > 1 Then
            MsgBox("You can enter only one record for beginig balance.")
            Exit Function
        End If

        If ThisFormStatus = MainModule.WorkStates.Edit And Not CalledBeforeCashierFlag Then
            Dim SumOfPaymentVar As Double = 0
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT  ISNULL(ROUND(SUM(payment_amount), 2), 0) AS sum_amount_pay FROM GL_payment_deposit WHERE refer_type='1' AND id_service_center = " & Qt(TxtRef.Text)
            SumOfPaymentVar = CmdGeneral.ExecuteScalar

            If LblTotal.Text <> SumOfPaymentVar And CmbType.Text = "IN" And SumOfPaymentVar > 0 Then
                MsgBox("Please Enter Cashier Information Before Saving")
                Exit Function
            End If
        End If

        Dim dr As DataRow, flg As Boolean
        If CustomerCod1.Text.Trim = "CASH" And (TxtCustomerFName.Text.Trim.Length > 0 Or TxtCustomerMName.Text.Trim.Length > 0 Or TxtCustomerLName.Text.Trim.Length > 0 Or PhoneNoMain.Text.Trim.Length > 0) And TxtCustomerFName.Enabled = True Then
            Dim ThisCodCustomer As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select count(*) from cust_trtab_main Where cod_customer='CASH' AND f_name=" & Qt(TxtCustomerFName.Text) & " AND m_name=" & Qt(TxtCustomerMName.Text) & " AND l_name=" & Qt(TxtCustomerLName.Text)
            If CmdGeneral.ExecuteScalar = 0 Then
                CmdGeneral.CommandText = "Select top 1 cod_customer as Max_cod_customer from cust_trtab_main Where substring(cod_customer,1,4)='CASH' AND ((substring(cod_customer,5,1) between '0' AND '9') OR substring(cod_customer,5,1)=' ')  ORDER BY cod_customer DESC"
                Try
                    ThisCodCustomer = Trim(CmdGeneral.ExecuteScalar & "")
                    If ThisCodCustomer.Trim.Length = 0 Then
                        ThisCodCustomer = "CASH"
                    Else
                        ThisCodCustomer = "CASH" & Getcod(Str(Val(Mid(ThisCodCustomer, 5, 6)) + 1).Trim, 6)
                    End If
                Catch ex As Exception
                    ThisCodCustomer = "CASH"
                End Try
                Try
                    CmdGeneral.CommandText = "Insert Into cust_trtab_main (cod_customer,Vip_Code,F_name,M_Name,L_name,Phone_1,phone_main_1,cod_sales_tax) Values(" & Qt(ThisCodCustomer) & ",'CASH'," & Qt(TxtCustomerFName.Text) & "," & Qt(TxtCustomerMName.Text) & "," & Qt(TxtCustomerLName.Text) & "," & Qt(PhoneNoMain.Text) & ",1,'01')"
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Cannot Insert Customer Information")
                    MsgBox("Please see the cust_sales_tax Table.Code 01 is mandatory.")
                    ThisCodCustomer = "CASH"
                End Try
                CustomerCod1.Text = ThisCodCustomer
            End If
        End If
        If DsFrmWorkOrders1.service_center_head.Rows.Count > 0 Then
            dr = DsFrmWorkOrders1.service_center_head.Rows(0)
            flg = False
        Else
            dr = DsFrmWorkOrders1.service_center_head.NewRow
            flg = True
        End If
        dr("id_service_center") = TxtRef.Text
        dr("type_of_form") = CmbType.Text
        dr("cod_customer") = CustomerCod1.Text
        dr("id_vehicle") = IIf(License_No1.FieldCodValue > 0, License_No1.FieldCodValue, System.DBNull.Value)
        dr("date_refer") = TxtDate.Text
        dr("Po_No") = TxtPo_No.Text
        dr("house_comment") = CommentButton_House.ZCommentText
        dr("cust_comment") = CommentButton_Customer.ZCommentText
        dr("Tax") = NumTax.Text
        dr("Discount") = NumDiscount.Text
        dr("Total") = LblTotal.Text
        Try
            dr("add_user") = CmbAddUser.SelectedValue
        Catch ex As Exception
            dr("add_user") = 0
        End Try
        Try
            dr("Chg_user") = CmbChgUser.SelectedValue
        Catch ex As Exception
            dr("Chg_user") = 0
        End Try
        If flg Then
            DsFrmWorkOrders1.service_center_head.Rows.Add(dr)
        End If
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Dim TxtRefTempVar As String
            TxtRefTempVar = TxtRef.Text
            Dim iii As Integer = 0
            If ThisFormStatus = MainModule.WorkStates.AddNew And CmbType.Text.Trim = "RT" And InvoiceNoForReturnVar.Trim.Length > 0 Then
                For iii = 0 To 10
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    If ReturnWasSavedFlag Then
                        CmdGeneral.CommandText = "Update service_center_head set cod_customer=" & Qt(CustomerCod1.Text) & ", id_vehicle=" & IIf(License_No1.FieldCodValue > 0, Qt(License_No1.FieldCodValue), "Null") & ", discount=" & NumDiscount.Text & ", tax=" & NumTax.Text & ", house_comment=" & Qt(CommentButton_House.ZCommentText) & ", cust_comment=" & Qt(CommentButton_Customer.ZCommentText) & ", chg_user=" & Qt(CmbChgUser.SelectedValue) & ", po_no=" & Qt(TxtPo_No.Text) & ", Total=" & LblTotal.Text & " Where id_service_center=" & Qt(TxtRefTempVar)
                    Else
                        CmdGeneral.CommandText = "INSERT INTO service_center_head (id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, discount, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_center_before, Total) VALUES " & _
                                               "(" & Qt(TxtRefTempVar) & "," & Qt(CmbType.Text) & "," & Qt(CustomerCod1.Text) & "," & IIf(License_No1.FieldCodValue > 0, Qt(License_No1.FieldCodValue), "Null") & "," & Qt(TxtDate.Text) & "," & NumDiscount.Text & "," & NumTax.Text & "," & Qt(CommentButton_House.ZCommentText) & "," & Qt(CommentButton_Customer.ZCommentText) & "," & Qt(CmbAddUser.SelectedValue) & "," & Qt(CmbChgUser.SelectedValue) & "," & Qt(TxtPo_No.Text) & "," & Qt(InvoiceNoForReturnVar) & "," & LblTotal.Text & ")"
                    End If
                    Try
                        CmdGeneral.ExecuteNonQuery()
                        ReturnWasSavedFlag = True
                        Exit For
                    Catch ex As Exception
                        TxtRefTempVar = MakeNewRef(CmbType.Text) ' "IN" & Mid(TxtRef.Text, 3, 8)
                    End Try
                Next
            Else
                For iii = 0 To 10
                    Try
                        DAService_Center_Head.Update(DsFrmWorkOrders1.service_center_head)
                        Exit For
                    Catch ex As Exception
                        TxtRefTempVar = MakeNewRef(CmbType.Text) ' "IN" & Mid(TxtRef.Text, 3, 8)
                        DsFrmWorkOrders1.service_center_head.Rows(0).Item("id_service_center") = TxtRefTempVar
                    End Try
                Next
            End If
            If iii = 11 Then
                MsgBox("Please try again")
                Exit Function
            End If
            If TxtRef.Text <> TxtRefTempVar Then
                TxtRef.Text = TxtRefTempVar
                Dim MyFrmShowChangedNo As New FrmShowChangedNo
                MyFrmShowChangedNo.LblNewNo.Text = TxtRef.Text
                MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
                MyFrmShowChangedNo.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("System Can't Save Information")
            Exit Function
        End Try

        ' «» œ«  ⁄œ« ﬁ»·Ì ﬂ„ „Ìê—œœ Êœ— «œ«„Â  ⁄œ«œ ÃœÌœ »Â „ÊÃÊœÌ «÷«›Â „Ìê—œœ
        'If ThisFormStatus = MainModule.WorkStates.Edit Then

        Call SetPrevMojoodi(TxtRef.Text)
        'End If


        DsFrmWorkOrders1.service_center_dtl.DefaultView.Sort = "Radif"
        Dim RadifCounter As Integer = 1
        If DsFrmWorkOrders1.service_center_dtl.DefaultView.Count > 0 Then
            Dim CounterForSaving As Integer
            For CounterForSaving = 0 To DsFrmWorkOrders1.service_center_dtl.DefaultView.Count - 1
                If CounterForSaving >= DsFrmWorkOrders1.service_center_dtl.DefaultView.Count Then
                    Exit For
                End If

                ''''If DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).RowState <> DataRowState.Deleted Then
                If Trim(DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("type_select")).Length > 0 And Trim(DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("type_select")) <> "P" Then
                    DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("id_service_center") = DsFrmWorkOrders1.service_center_head.Rows(0).Item("id_service_center")
                    Select Case Trim(DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("type_select"))
                        Case "O"
                            Dim service_out_purchasesFoundRow As DataRow
                            service_out_purchasesFoundRow = DsFrmWorkOrders1.service_out_purchases.FindByradif(DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("Radif"))
                            If Not (service_out_purchasesFoundRow Is Nothing) Then
                                service_out_purchasesFoundRow.Item("Radif") = RadifCounter
                            End If
                        Case "A"
                            Dim Service_tire_adjustmentFoundRow As DataRow
                            Service_tire_adjustmentFoundRow = DsFrmWorkOrders1.service_tire_adjustment.FindByradif(DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("Radif"))
                            If Not (Service_tire_adjustmentFoundRow Is Nothing) Then
                                Service_tire_adjustmentFoundRow.Item("Radif") = RadifCounter
                            End If
                    End Select
                    DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("Radif") = RadifCounter
                    If IsDBNull(DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("AVERAGE_COST")) Then
                        DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("AVERAGE_COST") = 0
                    End If

                    ' ‘—Ê⁄ »Â —Ê“ —”«‰Ì „ÊÃÊœÌÂ«
                    Call SetMojoodiAfterSave(CmbType.Text.ToUpper, DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("type_select") & "", DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("cod_select") & "", DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Item("Qty"))
                    ' « „«„ »Â —Ê“ —”«‰Ì „ÊÃÊœÌÂ«

                    RadifCounter = RadifCounter + 1
                Else
                    DsFrmWorkOrders1.service_center_dtl.DefaultView(CounterForSaving).Delete()
                    CounterForSaving = CounterForSaving - 1
                End If
                ''''End If
            Next
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "DELETE FROM service_center_dtl Where id_service_center=" & Qt(TxtRef.Text)
        CmdGeneral.ExecuteNonQuery()
        If DsFrmWorkOrders1.service_center_dtl.Rows.Count > 0 Then
            Dim CounterForSaving As Integer
            With DsFrmWorkOrders1.service_center_dtl
                For CounterForSaving = 0 To .Count - 1
                    If .Rows(CounterForSaving).RowState <> DataRowState.Deleted Then
                        If Trim(.Rows(CounterForSaving).Item("type_select")).Length > 0 And Trim(.Rows(CounterForSaving).Item("type_select")) <> "P" Then
                            CmdGeneral.CommandText = "INSERT INTO service_center_dtl (id_service_center, radif, type_select, cod_select, desc_radif, qty, price, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST) VALUES " & _
                                                     "(" & Qt(TxtRef.Text) & _
                                                     "," & .Rows(CounterForSaving).Item("Radif") & _
                                                     "," & Qt(.Rows(CounterForSaving).Item("type_select")) & _
                                                     "," & Qt(.Rows(CounterForSaving).Item("cod_select")) & _
                                                     "," & Qt(.Rows(CounterForSaving).Item("desc_radif")) & _
                                                     "," & .Rows(CounterForSaving).Item("qty") & _
                                                     "," & .Rows(CounterForSaving).Item("price") & _
                                                     "," & .Rows(CounterForSaving).Item("fet") & _
                                                     "," & IIf(.Rows(CounterForSaving).Item("taxable"), 1, 0) & _
                                                     "," & IIf(Trim(.Rows(CounterForSaving).Item("cod_technician") & "").Length > 0, Qt(.Rows(CounterForSaving).Item("cod_technician")), "Null") & _
                                                     "," & Qt(.Rows(CounterForSaving).Item("COMMENT_ARTICLE") & "") & _
                                                     "," & .Rows(CounterForSaving).Item("AVERAGE_COST") & _
                                                     ")"
                            Try
                                CmdGeneral.ExecuteNonQuery()
                            Catch ex As Exception
                                'MsgBox("The Row No : " & .Rows(CounterForSaving).Item("Radif") + " can not be saved" + vbCrLf + "It may contain illegal character." + vbCrLf + "Click Ok snd System will SAVE other rows" + vbCrLf + "Click CANCEL and make corrections.")
                                MsgBox("The Row No : " & .Rows(CounterForSaving).Item("Radif").tostring + " can not be saved" + vbCrLf + "It may contain illegal character.(such as ' )" + vbCrLf + "Click Ok and System will SAVE other rows.")
                            End Try
                        End If
                    End If
                Next
            End With
        End If

        Try
            ''''''''''''''''''''''''

            'Outside Purchase "O"
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "DELETE FROM service_out_purchases_dtl Where id_service_center=" & Qt(TxtRef.Text)
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "DELETE FROM service_out_purchases Where id_service_center=" & Qt(TxtRef.Text)
            CmdGeneral.ExecuteNonQuery()
            If DsFrmWorkOrders1.service_center_dtl.Rows.Count > 0 Then
                Dim CounterForSaving As Integer
                For CounterForSaving = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
                    If DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).RowState <> DataRowState.Deleted Then
                        If Trim(DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).Item("type_select")) = "O" Then
                            Dim service_out_purchasesdr As DataRow
                            service_out_purchasesdr = DsFrmWorkOrders1.service_out_purchases.FindByradif(DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).Item("radif"))
                            If Not IsNothing(service_out_purchasesdr) Then
                                CmdGeneral.CommandText = "INSERT INTO service_out_purchases " & _
                                      " (id_service_center, radif, cost, fet, markup, cod_vendor, po_no, invoice_no, invoice_date, due_date, tracking_warranty, in_day, in_mile, tracking_core,core_value,line,paidflag,AR_terms) Values " & _
                                      " (" & Qt(TxtRef.Text) & "," & service_out_purchasesdr("radif") & "," & service_out_purchasesdr("cost") & "," & service_out_purchasesdr("fet") & "," & service_out_purchasesdr("markup") & "," & IIf(Trim(service_out_purchasesdr("cod_vendor") & "").Length > 0, Qt(service_out_purchasesdr("cod_vendor")), "Null") & "," & Qt(service_out_purchasesdr("po_no") & "") & "," & Qt(service_out_purchasesdr("invoice_no") & "") & "," & Qt(service_out_purchasesdr("invoice_date") & "") & "," & Qt(service_out_purchasesdr("due_date") & "") & "," & IIf(service_out_purchasesdr("tracking_warranty"), 1, 0) & "," & service_out_purchasesdr("in_day") & "," & service_out_purchasesdr("in_mile") & "," & IIf(service_out_purchasesdr("tracking_core"), 1, 0) & "," & service_out_purchasesdr("core_value") & "," & IIf(Trim(service_out_purchasesdr("Line") & "").Length > 0, Qt(service_out_purchasesdr("Line")), "NULL") & "," & IIf(service_out_purchasesdr("PaidFlag"), 1, 0) & "," & IIf(Trim(service_out_purchasesdr("AR_terms") & "").Length > 0, Qt(service_out_purchasesdr("AR_terms")), "NULL") & ")"
                                CmdGeneral.ExecuteNonQuery()
                                DsFrmWorkOrders1.Service_out_purchases_Dtl.Clear()
                                If CalcDueDetail(service_out_purchasesdr("AR_terms") & "", DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).Item("Qty") * service_out_purchasesdr("cost"), service_out_purchasesdr("invoice_date"), DsFrmWorkOrders1.Service_out_purchases_Dtl) Then
                                    If DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows.Count > 0 Then
                                        Dim Service_out_purchases_DtlCounter As Integer
                                        For Service_out_purchases_DtlCounter = 0 To DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows.Count - 1
                                            CmdGeneral.CommandText = "INSERT INTO service_out_purchases_Dtl " & _
                                                  " (id_service_center, radif, cost, Due_Date) Values " & _
                                                  " (" & Qt(TxtRef.Text) & "," & service_out_purchasesdr("radif") & "," & DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows(Service_out_purchases_DtlCounter).Item("cost") & "," & Qt(DsFrmWorkOrders1.Service_out_purchases_Dtl.Rows(Service_out_purchases_DtlCounter).Item("Due_Date")) & ")"
                                            CmdGeneral.ExecuteNonQuery()
                                        Next
                                    End If
                                End If
                            End If
                        End If
                    End If
                Next
            End If
            ''''''''''''''''''''''''
            'Tire Adjustment "A"
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "DELETE FROM service_tire_adjustment Where id_service_center=" & Qt(TxtRef.Text)
            CmdGeneral.ExecuteNonQuery()
            If DsFrmWorkOrders1.service_center_dtl.Rows.Count > 0 Then
                Dim CounterForSaving As Integer
                For CounterForSaving = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
                    If DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).RowState <> DataRowState.Deleted Then
                        If Trim(DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).Item("type_select")) = "A" Then
                            Dim Service_tire_adjustmentDr As DataRow
                            Service_tire_adjustmentDr = DsFrmWorkOrders1.service_tire_adjustment.FindByradif(DsFrmWorkOrders1.service_center_dtl.Rows(CounterForSaving).Item("radif"))
                            If Not IsNothing(Service_tire_adjustmentDr) Then
                                CmdGeneral.CommandText = "INSERT INTO service_tire_adjustment " & _
                                     "(id_service_center, radif, DOT_safety_code, DOT_serial_no, measured_tread_depth, condition_code, supplier_percent, costomer_portion) Values " & _
                                     "(" & Qt(TxtRef.Text) & "," & Service_tire_adjustmentDr("radif") & "," & Qt(Service_tire_adjustmentDr("DOT_safety_code") & "") & "," & Qt(Service_tire_adjustmentDr("DOT_serial_no") & "") & "," & Qt(Service_tire_adjustmentDr("measured_tread_depth") & "") & "," & Qt(Service_tire_adjustmentDr("condition_code") & "") & "," & Service_tire_adjustmentDr("supplier_percent") & "," & Service_tire_adjustmentDr("costomer_portion") & ")"
                                CmdGeneral.ExecuteNonQuery()
                            End If
                        End If
                    End If
                Next
            End If

            '''''If ThisFormStatus = MainModule.WorkStates.AddNew Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select count(*) as countVar from ser_tr_vehicle_dtl where id_service_center=" & Qt(TxtRef.Text)
            If CmdGeneral.ExecuteScalar = 1 Then
                CmdGeneral.CommandText = "Update ser_tr_vehicle_dtl Set current_mileage=" & NumCurrent_mileage.Text & " Where id_service_center=" & Qt(TxtRef.Text)
            Else
                CmdGeneral.CommandText = "Insert Into ser_tr_vehicle_dtl (id_service_center,current_mileage) Values(" & Qt(TxtRef.Text) & "," & NumCurrent_mileage.Text & ")"
            End If
            CmdGeneral.ExecuteNonQuery()

            ''''End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If CmbType.Text.Trim = "RT" Then
            ReturnWasSavedFlag = True
        End If

        psave = True

        If ThisChangeStatus Then
            Call LoadAWotkOrder(TxtRef.Text)
            ThisFormStatus = MainModule.WorkStates._ReadOnly
            Call EnableDisableField(False)
            Call EnableDisableBtn()
        Else
            Dim IFirstCount As Integer = DsFrmWorkOrders1.service_center_dtl.Rows.Count()
            Dim AddEmptyRecordToDetailCount As Integer
            MaxRowNo = RowNoToAdd + IFirstCount
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To MaxRowNo
                Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
            Next
        End If
    End Function
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Select Case e.Column.Key.ToUpper
            Case "HST"
                MsgBox("Item Sales History Screen For Row : " & e.Column.GridEX.Row())
            Case "CM"
                MyFrmItemComments = New CommonClass.FrmItemComments
                MyFrmItemComments.TxtComments.Text = DsFrmWorkOrders1.service_center_dtl.Rows(e.Column.GridEX.Row()).Item("COMMENT_ARTICLE") & ""

                Dim PntForm As Point
                Dim PntLocation As Point
                Dim OControl As Control
                Dim SizeForm As Size
                OControl = GrdDetail

                SizeForm.Width = MyFrmItemComments.Width
                SizeForm.Height = MyFrmItemComments.Height
                PntLocation.X = OControl.Location.X '+ oControl.Size.Width - sizeForm.Width
                PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2 + ((e.Column.GridEX.Row() + 2) * GrdDetail.RootTable.RowHeight) - OControl.Size.Height - 1


                PntForm = OControl.Parent.PointToScreen(PntLocation)
                If PntForm.Y + SizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
                    PntForm.Y = PntForm.Y - SizeForm.Height - GrdDetail.RootTable.RowHeight
                End If
                If (PntForm.X < 0) Then PntForm.X = 0
                MyFrmItemComments.SetDesktopLocation(PntForm.X, PntForm.Y)
                MyFrmItemComments.Left = PntForm.X
                MyFrmItemComments.Top = PntForm.Y
                MyFrmItemComments.ThisFormStatus = ThisFormStatus
                MyFrmItemComments.ShowDialog()
                If MyFrmItemComments.ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
                    DsFrmWorkOrders1.service_center_dtl.Rows(e.Column.GridEX.Row()).Item("COMMENT_ARTICLE") = MyFrmItemComments.TxtCommentvar
                End If
            Case "DET"
                Select Case ThisRowGrid.Cells(0).Value
                    Case "I"
                        If Trim(ThisRowGrid.Cells(4).Value).Length > 0 Then
                            Dim MyFrmItemProduct As New UCInv_Item.FrmItemProduct
                            MyFrmItemProduct.StartPosition = FormStartPosition.CenterScreen
                            MyFrmItemProduct.ThisFormStatus = MainModule.WorkStates._ReadOnly
                            MyFrmItemProduct.Item_noTempVar = ThisRowGrid.Cells(4).Value
                            MyFrmItemProduct.ShowDialog()
                        End If
                    Case "A"
                        'If Trim(ThisRowGrid.Cells(4).Value).Length > 0 Then
                        Call ShowTireAdjustment()
                        'End If
                    Case "O"
                        Call ShowOutsidePurchase()
                End Select
        End Select
    End Sub
    Private Sub EnableDisableBtn()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew, MainModule.WorkStates.Edit
                BtnFirst.Enabled = False
                BtnPrev.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
                BtnEdit.Enabled = False
                BtnDelete.Enabled = False
                BtnFind.Enabled = False
                BtnNew.Enabled = False
                BtnCancel.Enabled = True
                BtnSave.Enabled = False
                BtnConvert.Enabled = False
                BtnCashier.Enabled = True
            Case MainModule.WorkStates._ReadOnly
                If TxtRef.Text.Trim.Length > 0 Then
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                    BtnEdit.Enabled = True
                    BtnDelete.Enabled = True
                    BtnFind.Enabled = True
                    BtnConvert.Enabled = True
                    BtnCashier.Enabled = True
                Else
                    BtnFirst.Enabled = False
                    BtnPrev.Enabled = False
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                    BtnEdit.Enabled = False
                    BtnDelete.Enabled = False
                    BtnFind.Enabled = False
                    BtnConvert.Enabled = False
                    BtnCashier.Enabled = False
                End If
                BtnNew.Enabled = True
                BtnCancel.Enabled = False
                BtnSave.Enabled = False
        End Select
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        FirstPrint = True
        ReturnWasSavedFlag = False
        ThisFormStatus = MainModule.WorkStates.AddNew

        Call EnableDisableField(True)
        Call EnableDisableBtn()
        DsFrmWorkOrders1.service_center_head.Clear()
        DsFrmWorkOrders1.service_center_dtl.Clear()
        DsFrmWorkOrders1.service_out_purchases.Clear()
        DsFrmWorkOrders1.service_tire_adjustment.Clear()
        Call ClearAllField()
        'TxtRef.Text = MakeNewRef(TypeOfForm)
        Dim IFirstCount As Integer = DsFrmWorkOrders1.service_center_dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        MaxRowNo = RowNoToAdd + IFirstCount
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To MaxRowNo
            Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
        Next
        If CmbType.Text.Trim = "RT" Then
            MyFrmFindServiceRecords.MainSearchTypeVar = "IN"
            MyFrmFindServiceRecords.ShowDialog()
            CmbType.Text = "RT"
            InvoiceNoForReturnVar = TxtRef.Text
            If DsFrmWorkOrders1.service_center_dtl.Rows.Count > 0 Then
                Dim TempCounter As Integer
                For TempCounter = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
                    DsFrmWorkOrders1.service_center_dtl(TempCounter).qty = -DsFrmWorkOrders1.service_center_dtl(TempCounter).qty
                Next
            End If
            TxtDate.Text = Format(Now.Date, PubDateFormat)
        Else
            InvoiceNoForReturnVar = ""
        End If
        TxtRef.Text = MakeNewRef(TypeOfForm)
        OldReferenceNo = TxtRef.Text
        If CmbType.Text.Trim = "RT" Then
            GrdDetail.Focus()
        End If
        CustomerCod1.Focus()
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
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 id_service_center From service_center_head WHERE type_of_form=" & Qt(CmbType.Text.Trim) & " Order BY id_service_center ASC"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadAWotkOrder(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 id_service_center From service_center_head WHERE type_of_form=" & Qt(CmbType.Text.Trim) & " AND id_service_center < " & Qt(TxtRef.Text) & " Order BY id_service_center Desc"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadAWotkOrder(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PNextRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 id_service_center From service_center_head WHERE type_of_form=" & Qt(CmbType.Text.Trim) & " AND id_service_center > " & Qt(TxtRef.Text) & " Order BY id_service_center Asc"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadAWotkOrder(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PLastRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 id_service_center From service_center_head WHERE type_of_form=" & Qt(CmbType.Text.Trim) & " Order BY id_service_center DESC"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadAWotkOrder(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LoadAWotkOrder(ByVal ThisRefNo As String)
        DsFrmWorkOrders1.service_center_head.Clear()
        DsFrmWorkOrders1.service_center_dtl.Clear()
        DAService_Center_Head.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
        DAService_Center_Head.Fill(DsFrmWorkOrders1.service_center_head)
        Try
            DAService_Center_Dtl.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
            DAService_Center_Dtl.Fill(DsFrmWorkOrders1.service_center_dtl)
        Catch ex As Exception
            MsgBox("Error in loading Service Information,try again or call to your vendor")
        End Try
        DsFrmWorkOrders1.service_out_purchases.Clear()
        Try
            DAservice_out_purchases.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
            DAservice_out_purchases.Fill(DsFrmWorkOrders1.service_out_purchases)
        Catch ex As Exception
            MsgBox("Error in loading out purchases Information,try again or call to your vendor")
        End Try
        DsFrmWorkOrders1.service_tire_adjustment.Clear()
        Try
            DAService_tire_adjustment.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
            DAService_tire_adjustment.Fill(DsFrmWorkOrders1.service_tire_adjustment)
        Catch ex As Exception
            MsgBox("Error in loading out Tire Adjustment Information,try again or call to your vendor")
        End Try
        Call ClearAllField()
        Call FillDataInScreen()
        Call CalcSumOfExt_price(False)
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmWorkOrders1.service_center_head
            If .Rows.Count > 0 Then
                CmbType.SelectedValue = .Rows(0).Item("type_of_form") & ""

                NumCurrent_mileage.Text = IIf(IsDBNull(.Rows(0).Item("Current_mileage")), 0, .Rows(0).Item("Current_mileage"))
                CustomerCod1.Text = .Rows(0).Item("cod_customer") & ""
                'License_No1.CodCustomerForFilter = CustomerCod1.Text
                Call CustomerCod1_FindCustomerCod()
                License_No1.FieldCodValue = IIf(IsDBNull(.Rows(0).Item("id_vehicle")), 0, .Rows(0).Item("id_vehicle"))
                TxtPo_No.Text = Trim(.Rows(0).Item("Po_No") & "")
                TxtDate.Text = .Rows(0).Item("date_refer") & ""
                NumDiscount.Text = .Rows(0).Item("discount")
                LblTotal.Text = .Rows(0).Item("Total")
                NumTax.Text = .Rows(0).Item("Tax")
                If NumTax.Text = 0 And LblSubtotal.Numbervalue > 0 Then
                    FlagResetTaxVar = True
                Else
                    FlagResetTaxVar = False
                End If
                Call SetBtnResetTaxText()

                TxtRef.Text = .Rows(0).Item("id_service_center") & ""
                LblCustomerCompanyname.Text = .Rows(0).Item("complete_name") & ""

                Try
                    CmbAddUser.SelectedValue = .Rows(0).Item("add_user")
                Catch ex As Exception
                    CmbAddUser.SelectedValue = 0
                End Try
                Try
                    CmbChgUser.SelectedValue = .Rows(0).Item("Chg_user")
                Catch ex As Exception
                    CmbChgUser.SelectedValue = 0
                End Try

                LblFees.Text = 0
                LblFET.Text = 0
                LblLabor.Text = 0
                LblParts.Text = 0
                LblSubtotal.Text = 0
                LblTotal.Text = 0
                CmbType.SelectedValue = .Rows(0).Item("type_of_form") & ""
                'LblVehicleMake.Text = License_No1.VehicleMake & ""
                'LblVehicleModel.Text = License_No1.VehicleModel & ""
                'LblVehicleVin.Text = License_No1.VehicleVin & ""
                'LblVehicleYear.Text = License_No1.VehicleYear & ""
                CommentButton_Customer.ZCommentText = .Rows(0).Item("cust_comment") & ""
                If CommentButton_Customer.ZCommentText.Trim.Length > 0 Then
                    CommentButton_Customer.ForeColor = Color.Red
                Else
                    CommentButton_Customer.ForeColor = Color.Black
                End If
                CommentButton_House.ZCommentText = .Rows(0).Item("house_comment") & ""
                If CommentButton_House.ZCommentText.Trim.Length > 0 Then
                    CommentButton_House.ForeColor = Color.Red
                Else
                    CommentButton_House.ForeColor = Color.Black
                End If

                'PhoneNoMain.Text = CustomerCod1.CustomerPhone & ""
            End If
            PhoneButton1.FillDataSet("cust_trtab_main", "cod_customer=" & Qt(CustomerCod1.Text))
            PhoneButton1.HeaderName = CustomerCod1.CustomerDesc.Trim
            PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
        End With

        If CmbType.Text = "RT" Then
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(TxtRef.Text)
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Try
                InvoiceNoForReturnVar = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                InvoiceNoForReturnVar = ""
            End Try
        End If

        If CmbType.Text = "WO" Then
            CmdGeneral.CommandText = "Select amount from GL_Paid_received where tran_type='4' AND id_service_center=" & Qt(TxtRef.Text)
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Try
                DownPaymentVar = CmdGeneral.ExecuteScalar
            Catch ex As Exception
                DownPaymentVar = 0
            End Try
        End If

    End Sub
    Private Sub ClearAllField()
        LblVehicleMake.Text = ""
        LblVehicleModel.Text = ""
        LblVehicleVin.Text = ""
        LblVehicleYear.Text = ""
        VehicleColorVar = ""
        UnitNoVar = ""
        Desc_kind_engineVar = ""

        FlagResetTaxVar = False
        Call SetBtnResetTaxText()
        TxtRef.Text = TakeLastRef(TypeOfForm)
        NumCurrent_mileage.Text = 0
        CustomerCod1.Text = ""
        License_No1.Text = ""
        TxtCustomerFName.Clear()
        TxtCustomerMName.Clear()
        TxtCustomerLName.Clear()
        TxtPo_No.Clear()
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        NumDiscount.Text = 0
        NumTax.Text = 0
        TxtRef.Clear()
        LblCustomerCompanyname.Text = ""
        CmbChgUser.SelectedValue = 0
        LblFees.Text = 0
        LblFET.Text = 0
        LblLabor.Text = 0
        LblParts.Text = 0
        LblSubtotal.Text = 0
        LblTotal.Text = 0
        LblVehicleMake.Text = ""
        LblVehicleModel.Text = ""
        LblVehicleVin.Text = ""
        LblVehicleYear.Text = ""
        CommentButton_Customer.ZCommentText = ""
        CommentButton_House.ZCommentText = ""
        CommentButton_Customer.ForeColor = Color.Black
        CommentButton_House.ForeColor = Color.Black

        PhoneNoMain.Text = ""
        Call PhoneButton1.ClearPhoneScreen()

        Invoice_NO_Default_For_Outside_Purchase = ""
        Invoice_Date_Default_For_Outside_Purchase = ""
        Po_No_Default_For_Outside_Purchase = ""
        Due_Date_Default_For_Outside_Purchase = Format(Now.Date, PubDateFormat)
        Markup_Default_For_Outside_Purchase = 0
        Vendor_Default_For_Outside_Purchase = ""
        Line_Default_For_Outside_Purchase = ""

        DownPaymentVar = 0

        If CmbAddUser.Text.Trim.Length = 0 Then
            Try
                CmbAddUser.SelectedValue = PUserCod
            Catch ex As Exception
                CmbAddUser.SelectedValue = 0
            End Try
        End If

    End Sub
    Private Sub EnableDisableSave()
        'If CustomerCod1.Text.Trim.Length > 0 And License_No1.Text.Trim.Length > 0 And BtnNew.Enabled = False Then
        If CustomerCod1.Text.Trim.Length > 0 And BtnNew.Enabled = False Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
            'TxtCustomerFName.Enabled = False
            'TxtCustomerMName.Enabled = False
            'TxtCustomerLName.Enabled = False
        End If
    End Sub
    Private Sub License_No1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumCurrent_mileage.TextChanged, NumDiscount.TextChanged, TxtCustomerFName.TextChanged, CmbAddUser.SelectedIndexChanged, TxtPo_No.TextChanged
        Call EnableDisableSave()
    End Sub
    Private Sub CustomerCod1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerCod1.TextChanged
        Call EnableDisableSave()
        If CustomerCod1.CustomerCod.Trim.Length > 0 Then
            License_No1.CodCustomerForFilter = CustomerCod1.CustomerCod.Trim
        Else
            License_No1.CodCustomerForFilter = ""
        End If
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If TxtRef.Text.Trim.Length > 0 Then
            If CheckIsThisOrderConvert() Then
                Exit Sub
            End If
            If Not CheckCanEdit() Then
                Exit Sub
            End If

            ThisFormStatus = MainModule.WorkStates.Delete

            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                Dim TxtRefTemp As String = TxtRef.Text
                If DeleteThisWorkOrder(TxtRef.Text) Then
                    Call PPreviousRecord(False)
                    If TxtRefTemp = TxtRef.Text Then
                        Call PNextRecord(False)
                        If TxtRefTemp = TxtRef.Text Then
                            Call BtnCancel_Click(sender, e)
                        End If
                    End If
                End If
            Else
                CustomerCod1.Focus()
            End If
            ThisFormStatus = MainModule.WorkStates._ReadOnly
        End If
    End Sub
    Private Function DeleteThisWorkOrder(ByVal ThisRef_no As String) As Boolean
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select Count(*) From GL_payment_deposit Where id_service_center=" & Qt(ThisRef_no)
        If CmdGeneral.ExecuteScalar > 0 Then
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("This " & LblType.Text.Trim & " has Cash information.Are you sure ?")
            If c1.DialogResult = DialogResult.OK Then

                CmdGeneral.CommandText = "SELECT  count(*) FROM  GL_account_adjustment_dtl  where id_service_center = " & Qt(ThisRef_no)
                If CmdGeneral.ExecuteScalar() > 0 Then
                    CmdGeneral.CommandText = "SELECT  top 1 refrence_no FROM  GL_account_adjustment_dtl  where id_service_center = " & Qt(ThisRef_no)
                    MsgFar("This" & LblType.Text.Trim & " has related Adjustment.System can't Delete This Record.(" & CmdGeneral.ExecuteScalar & ")")
                    Exit Function
                End If

                CmdGeneral.CommandText = "SELECT Count(*) FROM GL_payment_deposit WHERE refer_type = '2' AND id_service_center = " & Qt(ThisRef_no)
                If CmdGeneral.ExecuteScalar() > 0 Then
                    CmdGeneral.CommandText = "SELECT top 1 refrence_no FROM GL_payment_deposit WHERE refer_type = '2' AND id_service_center = " & Qt(ThisRef_no)
                    MsgFar("This" & LblType.Text.Trim & " has related information.System can't Delete This Record.(" & CmdGeneral.ExecuteScalar & ")")
                    Exit Function
                End If

                Dim SQLReader As System.Data.SqlClient.SqlDataReader
                If CmdReader.Connection.State <> ConnectionState.Open Then
                    CmdReader.Connection.Open()
                End If
                Dim ThisReturnInvoiceNoVar As String
                CmdGeneral.CommandText = "SELECT id_service_center_before FROM service_center_head WHERE id_service_center = " & Qt(ThisRef_no)
                ThisReturnInvoiceNoVar = CmdGeneral.ExecuteScalar() & ""

                CmdReader.CommandText = "SELECT ID_payment FROM GL_payment_deposit WHERE refer_type = '1' AND payment_type='4' AND id_service_center = " & Qt(ThisReturnInvoiceNoVar)
                SQLReader = CmdReader.ExecuteReader

                CmdGeneral.CommandText = "Delete From GL_payment_deposit Where id_service_center=" & Qt(ThisRef_no)
                Try
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    MsgFar("This" & LblType.Text.Trim & " has related information.System can't Delete This Record")
                    Exit Function
                End Try

                If SQLReader.HasRows Then
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    Do While SQLReader.Read
                        CmdGeneral.CommandText = "update GL_payment_AR Set Cancel_Flag=0 where ID_payment=" & SQLReader.Item("ID_payment")
                        CmdGeneral.ExecuteNonQuery()
                    Loop
                End If
                SQLReader.Close()

                If CmbType.Text.ToUpper = "RT" Then
                    CmdGeneral.CommandText = "Delete From  GL_Paid_received Where tran_type='3' AND id_service_center=" & Qt(ThisRef_no)
                    CmdGeneral.ExecuteNonQuery()
                End If

            Else
                Exit Function
            End If
        End If

        Call SetPrevMojoodi(ThisRef_no)

        Call SetPrevMojoodiForBefore_ID_Service_Center(ThisRef_no)

        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If

            If CmbType.Text.ToUpper = "WO" Then
                CmdGeneral.CommandText = "Delete From  GL_Paid_received Where tran_type='4' AND id_service_center=" & Qt(ThisRef_no)
                CmdGeneral.ExecuteNonQuery()
            End If

            CmdGeneral.CommandText = "DELETE FROM service_out_purchases_dtl Where id_service_center=" & Qt(ThisRef_no)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "DELETE FROM service_out_purchases Where id_service_center=" & Qt(ThisRef_no)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "Delete From service_center_head Where id_service_center=" & Qt(ThisRef_no)
            CmdGeneral.ExecuteNonQuery()

            DeleteThisWorkOrder = True
            MsgFar("The selected record was deleted")
        Catch ex As Exception
            DeleteThisWorkOrder = False
            MsgFar("Can't Delete This Record")
        Finally
            CmdGeneral.Connection.Close()
        End Try
        CustomerCod1.Focus()
    End Function
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        FirstPrint = False
        Call pprint("preview", CmbType.Text, TxtRef.Text)
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        FirstPrint = False
        Call pprint("print", CmbType.Text, TxtRef.Text, False, True)
    End Sub
    Private Sub BtnFax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFax.Click
        Call pprint("Fax", CmbType.Text, TxtRef.Text)
    End Sub
    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Call pprint("Email", CmbType.Text, TxtRef.Text)
        MsgBox("Your invoice was saved successfully", MsgBoxStyle.Information)
        ''Call SendMail()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        FirstPrint = False
        If TxtRef.Text.Trim.Length > 0 Then
            If CheckIsThisOrderConvert() Then
                Exit Sub
            End If
            If Not CheckCanEdit() Then
                Exit Sub
            End If
            ThisFormStatus = MainModule.WorkStates.Edit
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            Dim AddEmptyRecordToDetailCount As Integer
            Dim IFirstCount As Integer = DsFrmWorkOrders1.service_center_dtl.Rows.Count()
            MaxRowNo = RowNoToAdd + IFirstCount
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To MaxRowNo
                Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
            Next

            If CmbType.Text = "RT" Then
                CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(TxtRef.Text)
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Try
                    InvoiceNoForReturnVar = CmdGeneral.ExecuteScalar & ""
                Catch ex As Exception
                    InvoiceNoForReturnVar = ""
                End Try
            End If

            CustomerCod1.Focus()
        End If
    End Sub
    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        BtnResetTax.Enabled = InStatus
        TxtCustomerFName.Enabled = InStatus
        TxtCustomerMName.Enabled = InStatus
        TxtCustomerLName.Enabled = InStatus
        TxtPo_No.Enabled = InStatus
        'TxtPo_No.TabStop = TxtPo_No.Enabled
        NumDiscount.Enabled = InStatus
        NumTax.Enabled = InStatus
        CustomerCod1.Enabled = InStatus
        License_No1.Enabled = InStatus
        CommentButton_House.ZEnabled = InStatus
        CommentButton_Customer.ZEnabled = InStatus
        PhoneNoMain.Enabled = InStatus
        'PhoneButton1.ZEnabled = InStatus
        NumCurrent_mileage.Enabled = InStatus
        CmbAddUser.Enabled = False
        CmbChgUser.Enabled = False
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            CmbAddUser.Enabled = True And InStatus
        ElseIf ThisFormStatus = MainModule.WorkStates.Edit Then
            CmbChgUser.Enabled = True And InStatus
        End If
        'GrdDetail.Enabled = InStatus
        If InStatus Then
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        Else
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call CancelAndLoadAWorkOrder()
    End Sub
    Private Sub CancelAndLoadAWorkOrder(Optional ByVal ThisRef As String = "")
        If ThisRef.Trim.Length = 0 Then
            ThisRef = TakeLastRef(TypeOfForm)
        End If
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        FlagResetTaxVar = False
        Call SetBtnResetTaxText()
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        Call LoadAWotkOrder(ThisRef)
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
        'Dim BeforeCelTemp As Integer = BeforeCel
        'Dim BeforeRowTemp As Integer = BeforeRow
        'Dim BeforeRowExTemp As GridEXRow = BeforeRowEx
        'GrdDetail.UpdateData()
        'BeforeCel = BeforeCelTemp
        'BeforeRow = BeforeRowTemp
        'BeforeRowEx = BeforeRowExTemp
    End Sub
    Private Sub EnableDisableDescription(ByVal ThisValue As String)
        Try
            Select Case ThisValue
                Case "I"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = CHKItemDescriptionFlagVar
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
                Case "L"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = CHKServiceDescriptionFlagVar
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
                Case "F"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = False
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
                Case "P"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = False
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
                Case "O"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = False
                    GrdDetail.RootTable.Columns("cod_select").Selectable = False
                Case "B"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = True
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
                    Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
                    If Trim(CurrentRow.Cells(4).Value).Length = 0 Then
                        CurrentRow.Cells(4).Value = "Beg Bal"
                        CurrentRow.Cells(5).Value = "Beginning Balance"
                        CurrentRow.Cells(6).Value = 1
                        CurrentRow.Cells(7).Value = 0
                        CurrentRow.Cells(8).Value = 0
                        CurrentRow.Cells(9).Value = 0
                        'CurrentRow.Cells(10).Value = 0
                        CurrentRow.Cells(11).Value = ""
                        Call SelectRow(GrdDetail.Row, 7)
                    End If
                Case "S"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = False
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
                    Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
                    OleDbReaderForStore = RetrieveServiceSetupTable(PubStoreNO)

                    Dim ShopSupplyPriceTempVar As Double = 0
                    Try
                        If OleDbReaderForStore.Item("Shop_Supply_ON_Labor_Flag") Then
                            ShopSupplyPriceTempVar = ShopSupplyPriceTempVar + (OleDbReaderForStore.Item("Shop_Supply_ON_Labor") * LblLabor.Text)
                        End If
                        If OleDbReaderForStore.Item("Shop_Supply_ON_Parts_Flag") Then
                            ShopSupplyPriceTempVar = ShopSupplyPriceTempVar + (OleDbReaderForStore.Item("Shop_Supply_ON_Parts") * LblParts.Text)
                        End If
                    Catch ex As Exception
                        ShopSupplyPriceTempVar = 0
                    End Try
                    OleDbReaderForStore.Close()

                    Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
                    If Trim(CurrentRow.Cells(4).Value).Length = 0 Then
                        CurrentRow.Cells(4).Value = "SS"
                        CurrentRow.Cells(5).Value = "Shop Supply"
                        CurrentRow.Cells(6).Value = 1
                        CurrentRow.Cells(7).Value = ShopSupplyPriceTempVar / 100
                        CurrentRow.Cells(8).Value = 0
                        CurrentRow.Cells(9).Value = 0
                        'CurrentRow.Cells(10).Value = 0
                        CurrentRow.Cells(11).Value = ""
                        Call SelectRow(GrdDetail.Row, 7)
                    End If
                Case "T"
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = True
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
                    Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
                    If Trim(CurrentRow.Cells(4).Value).Length = 0 Then
                        CurrentRow.Cells(4).Value = "T"
                        CurrentRow.Cells(5).Value = "Item Trade"
                        CurrentRow.Cells(6).Value = 1
                        CurrentRow.Cells(7).Value = 0
                        CurrentRow.Cells(8).Value = 0
                        CurrentRow.Cells(9).Value = 1
                        'CurrentRow.Cells(10).Value = 0
                        CurrentRow.Cells(11).Value = ""
                        Call SelectRow(GrdDetail.Row, 6)
                    End If
                Case Else
                    GrdDetail.RootTable.Columns("desc_radif").Selectable = True
                    GrdDetail.RootTable.Columns("cod_select").Selectable = True
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        Try
            Call EnableDisableDescription(CurrentRow.Cells("type_select").Value)
        Catch ex As Exception
        End Try
        Select Case e.Column.Index
            Case 0
                CurrentRow.Cells(4).Value = ""
                CurrentRow.Cells(5).Value = ""
                CurrentRow.Cells(6).Value = 0
                CurrentRow.Cells(7).Value = 0
                CurrentRow.Cells(8).Value = 0
                CurrentRow.Cells(9).Value = 1
                'CurrentRow.Cells(10).Value = 0
                CurrentRow.Cells(11).Value = ""
                CurrentRow.Cells("FlagIsPackage").Value = 0
                Call SelectRow(GrdDetail.Row, 4)
        End Select
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        'Try
        '    Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        '    If CurrentRow.Cells("type_select").Value <> 1 Then
        '        If e.Column.DataMember.ToUpper = "type_select".ToUpper Then

        '        End If
        '    End If
        'Catch ex As Exception
        'End Try
        Call EnableDisableSave()
        Call InitBeforeRow()
        'Try
        '    Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        '    Call EnableDisableDescription(BeforeRowEx.Cells("type_select").Value)
        'Catch ex As Exception
        'End Try
        Call CalcSumOfExt_price()
    End Sub
    Private Sub CalcSumOfExt_price(Optional ByVal FlagForCalcTax As Boolean = True)
        'Dim BeforeCelTemp As Integer = BeforeCel
        'Dim BeforeRowTemp As Integer = BeforeRow
        'GrdDetail.UpdateData()
        'BeforeCel = BeforeCelTemp
        'BeforeRow = BeforeRowTemp

        LblParts.Text = 0
        Dim TaxablePrice As Double = 0
        Dim TaxPercent As Double = 0

        LblParts.Text = 0
        LblFET.Text = 0
        LblLabor.Text = 0
        LblFees.Text = 0
        LblSubtotal.Text = 0
        LblTotal.Text = 0

        Dim BalanceVar As Double = 0
        Dim i As Double
        For i = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
            If DsFrmWorkOrders1.service_center_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                Select Case DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")
                    Case "I", "O", "A", "T"
                        Try
                            LblParts.Text = LblParts.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price")) + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Fet"))
                            LblFET.Text = LblFET.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Fet"))
                        Catch ex As Exception
                        End Try
                    Case "L"
                        Try
                            LblLabor.Text = LblLabor.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price"))
                        Catch ex As Exception
                        End Try
                    Case "F", "S"
                        Try
                            LblFees.Text = LblFees.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price"))
                        Catch ex As Exception
                        End Try
                    Case "B"
                        Try
                            BalanceVar = (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price"))
                        Catch ex As Exception
                        End Try
                End Select
                'LblSubtotal.Text = LblSubtotal.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price"))
                LblSubtotal.Text = LblParts.Numbervalue + LblLabor.Numbervalue + LblFees.Numbervalue + BalanceVar
                'If DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("taxable") Then ' ‘—ÿ »—«Ì œ«‘ ‰ „«·Ì« 
                '    TaxablePrice = TaxablePrice + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price"))
                'End If
                Try
                    TaxablePrice = DsFrmWorkOrders1.service_center_dtl.Compute("sum(Ext_Price)", "taxable=1")
                Catch ex As Exception
                    TaxablePrice = 0
                End Try
            End If
        Next
        If FlagForCalcTax And Not FlagResetTaxVar Then
            Call CalcTax()
        End If
        'LblTotal.Text = Math.Round(LblSubtotal.Text + NumTax.Text - ((LblSubtotal.Text * NumDiscount.Text) / 100), 2)
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim ValueString As String = ""
            Dim CurrentRowGrid As Long = GrdDetail.Row
            If BeforeRowEx Is Nothing Or BeforeCel < 0 Or BeforeRow < 0 Then
                Exit Sub
            End If

            Try
                Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
                Call EnableDisableDescription(CurrentRow.Cells("type_select").Value)
            Catch ex As Exception
            End Try
            'Call EnableDisableDescription(BeforeRowEx.Cells("type_select").Value)

            Try
                ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
                Call CalcSumOfExt_price()
                Select Case BeforeCel
                    Case 0
                        'Call EnableDisableDescription(BeforeRowEx.Cells("type_select").Value)
                        If GrdDetail.Row = BeforeRow And BeforeRowEx.Cells("type_select").Value = "O" Then
                            Call ShowOutsidePurchase()
                        ElseIf GrdDetail.Row = BeforeRow And BeforeRowEx.Cells("type_select").Value = "A" Then
                            'Call ShowTireAdjustment()
                        End If
                    Case 4
                        If Not SayItemName() Then
                            MsgFar("Cod is invalid")
                            Call SelectRow(CurrentRowGrid)
                        Else
                            If GrdDetail.Row = BeforeRow And BeforeRowEx.Cells("type_select").Value = "A" Then
                                Call ShowTireAdjustment()
                            End If
                        End If
                    Case 6
                        'Try
                        '    If BeforeRowEx.Cells("qty").Value = 0 And Trim(BeforeRowEx.Cells("type_select").Value).Length > 0 And Trim(BeforeRowEx.Cells("cod_select").Value).Length > 0 Then
                        '        MsgBox("Please enter a quantity for this item.Zero quantity not acceptable")
                        '        SelectRow(BeforeRow, BeforeCel)
                        '    End If
                        'Catch ex As Exception
                        'End Try
                        'SelectRow(GrdDetail.Row + 1, 0)
                    Case 8, 9
                        'Call CalcSumOfExt_price()
                End Select
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub ShowOutsidePurchase()
        If FlgInShowOutsidePurchase Then
            FlgInShowOutsidePurchase = False
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            Dim MYFrmOutsidePurchase As New FrmOutsidePurchase
            MYFrmOutsidePurchase.ThisFormStatus = ThisFormStatus

            Dim dr As DataRow
            dr = DsFrmWorkOrders1.service_out_purchases.FindByradif(CurrentRow.Cells("radif").Value)
            MYFrmOutsidePurchase.TypeOfForm = CmbType.Text
            If Not IsNothing(dr) Then
                MYFrmOutsidePurchase.Txtpart_no.Text = dr("part_no") & ""
                MYFrmOutsidePurchase.TxtDescription.Text = dr("Description") & ""
                MYFrmOutsidePurchase.NumCost.Text = dr("Cost")
                MYFrmOutsidePurchase.NumFet.Text = dr("Fet")
                MYFrmOutsidePurchase.NumMarkup.Text = dr("Markup")
                MYFrmOutsidePurchase.NumPrice.Text = dr("Price")
                MYFrmOutsidePurchase.Vendor_Cod1.VendorCod = dr("cod_vendor") & ""
                MYFrmOutsidePurchase.Txtpo_no.Text = dr("po_no") & ""
                MYFrmOutsidePurchase.LineVar = dr("Line") & ""
                MYFrmOutsidePurchase.ApTermVar = dr("AR_terms") & ""
                MYFrmOutsidePurchase.Txtinvoice_no.Text = dr("invoice_no") & ""
                MYFrmOutsidePurchase.Dteinvoice_date.Text = dr("invoice_date") & ""
                MYFrmOutsidePurchase.Dtedue_date.Text = dr("due_date") & ""
                MYFrmOutsidePurchase.Chktracking_warranty.Checked = dr("tracking_warranty")
                Try
                    MYFrmOutsidePurchase.Numin_day.Text = dr("in_day")
                Catch ex As Exception
                    MYFrmOutsidePurchase.Numin_day.Text = 0
                End Try
                Try
                    MYFrmOutsidePurchase.Numin_mile.Text = dr("in_mile")
                Catch ex As Exception
                    MYFrmOutsidePurchase.Numin_mile.Text = 0
                End Try
                Try
                    MYFrmOutsidePurchase.Chktracking_core.Checked = dr("tracking_core")
                Catch ex As Exception
                    MYFrmOutsidePurchase.Chktracking_core.Checked = 0
                End Try
                Try
                    MYFrmOutsidePurchase.Numcore_value.Text = dr("core_value")
                Catch ex As Exception
                    MYFrmOutsidePurchase.Numcore_value.Text = 0
                End Try
                Try
                    MYFrmOutsidePurchase.ChkPrepaid.Checked = dr("PaidFlag")
                Catch ex As Exception
                    MYFrmOutsidePurchase.ChkPrepaid.Checked = False
                End Try
            Else
                Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
                OleDbReaderForStore = RetrieveServiceSetupTable(PubStoreNO)

                Try
                    If Markup_Default_For_Outside_Purchase = 0 Then
                        MYFrmOutsidePurchase.NumMarkup.Text = OleDbReaderForStore.Item("OUTSIDE_PURCHASES_MARKUP")
                    Else
                        MYFrmOutsidePurchase.NumMarkup.Text = Markup_Default_For_Outside_Purchase
                    End If
                Catch ex As Exception
                    MYFrmOutsidePurchase.NumMarkup.Text = 0
                End Try
                If Vendor_Default_For_Outside_Purchase.Trim.Length = 0 Then
                    MYFrmOutsidePurchase.Vendor_Cod1.VendorCod = OleDbReaderForStore.Item("OUTSIDE_PURCHASES_VENDOR") & ""
                Else
                    MYFrmOutsidePurchase.Vendor_Cod1.VendorCod = Vendor_Default_For_Outside_Purchase
                End If
                If Line_Default_For_Outside_Purchase.Trim.Length = 0 Then
                    MYFrmOutsidePurchase.LineVar = OleDbReaderForStore.Item("OUTSIDE_PURCHASES_LINE") & ""
                Else
                    MYFrmOutsidePurchase.LineVar = Line_Default_For_Outside_Purchase & ""
                End If
                If Mid(Invoice_Date_Default_For_Outside_Purchase, 1, 2).Trim.Length = 0 Then
                    MYFrmOutsidePurchase.Dteinvoice_date.Text = Format(Now.Date, PubDateFormat)
                Else
                    MYFrmOutsidePurchase.Dteinvoice_date.Text = Invoice_Date_Default_For_Outside_Purchase
                End If
                OleDbReaderForStore.Close()
                MYFrmOutsidePurchase.Txtinvoice_no.Text = Invoice_NO_Default_For_Outside_Purchase
                MYFrmOutsidePurchase.Dtedue_date.Text = Due_Date_Default_For_Outside_Purchase
                MYFrmOutsidePurchase.Txtpo_no.Text = Po_No_Default_For_Outside_Purchase
            End If
            MYFrmOutsidePurchase.ShowDialog()
            If MYFrmOutsidePurchase.IsOK Then
                If IsNothing(dr) Then
                    dr = DsFrmWorkOrders1.service_out_purchases.NewRow
                    dr("radif") = CurrentRow.Cells("radif").Value
                    dr("id_service_center") = TxtRef.Text
                    dr("part_no") = MYFrmOutsidePurchase.Txtpart_no.Text
                    dr("Description") = MYFrmOutsidePurchase.TxtDescription.Text
                    dr("Cost") = MYFrmOutsidePurchase.NumCost.Text
                    dr("Fet") = MYFrmOutsidePurchase.NumFet.Text
                    dr("Price") = MYFrmOutsidePurchase.NumPrice.Text
                    dr("Markup") = MYFrmOutsidePurchase.NumMarkup.Text
                    dr("cod_vendor") = MYFrmOutsidePurchase.Vendor_Cod1.VendorCod
                    dr("po_no") = MYFrmOutsidePurchase.Txtpo_no.Text
                    dr("Line") = MYFrmOutsidePurchase.CmbLine.SelectedValue & ""
                    dr("AR_terms") = MYFrmOutsidePurchase.cmbAR_term.SelectedValue & ""
                    dr("invoice_no") = MYFrmOutsidePurchase.Txtinvoice_no.Text
                    dr("due_date") = MYFrmOutsidePurchase.Dtedue_date.Text
                    dr("invoice_date") = MYFrmOutsidePurchase.Dteinvoice_date.Text
                    dr("tracking_warranty") = MYFrmOutsidePurchase.Chktracking_warranty.Checked
                    dr("in_day") = MYFrmOutsidePurchase.Numin_day.Text
                    dr("in_mile") = MYFrmOutsidePurchase.Numin_mile.Text
                    dr("tracking_core") = MYFrmOutsidePurchase.Chktracking_core.Checked
                    dr("core_value") = MYFrmOutsidePurchase.Numcore_value.Text
                    dr("PaidFlag") = MYFrmOutsidePurchase.ChkPrepaid.Checked
                    DsFrmWorkOrders1.service_out_purchases.Rows.Add(dr)
                Else
                    Dim Out_purchasesDataRow As DSFrmWorkOrders.service_out_purchasesRow
                    Out_purchasesDataRow = DsFrmWorkOrders1.service_out_purchases.FindByradif(CurrentRow.Cells("radif").Value)
                    Out_purchasesDataRow.Item("radif") = CurrentRow.Cells("radif").Value
                    Out_purchasesDataRow.Item("id_service_center") = TxtRef.Text
                    Out_purchasesDataRow.Item("part_no") = MYFrmOutsidePurchase.Txtpart_no.Text
                    Out_purchasesDataRow.Item("Description") = MYFrmOutsidePurchase.TxtDescription.Text
                    Out_purchasesDataRow.Item("Cost") = MYFrmOutsidePurchase.NumCost.Text
                    Out_purchasesDataRow.Item("Fet") = MYFrmOutsidePurchase.NumFet.Text
                    Out_purchasesDataRow.Item("Price") = MYFrmOutsidePurchase.NumPrice.Text
                    Out_purchasesDataRow.Item("Markup") = MYFrmOutsidePurchase.NumMarkup.Text
                    Out_purchasesDataRow.Item("cod_vendor") = MYFrmOutsidePurchase.Vendor_Cod1.VendorCod
                    Out_purchasesDataRow.Item("po_no") = MYFrmOutsidePurchase.Txtpo_no.Text
                    Out_purchasesDataRow.Item("Line") = MYFrmOutsidePurchase.CmbLine.SelectedValue & ""
                    Out_purchasesDataRow.Item("AR_terms") = MYFrmOutsidePurchase.cmbAR_term.SelectedValue & ""
                    Out_purchasesDataRow.Item("invoice_no") = MYFrmOutsidePurchase.Txtinvoice_no.Text
                    Out_purchasesDataRow.Item("due_date") = MYFrmOutsidePurchase.Dtedue_date.Text
                    Out_purchasesDataRow.Item("invoice_date") = MYFrmOutsidePurchase.Dteinvoice_date.Text
                    Out_purchasesDataRow.Item("tracking_warranty") = MYFrmOutsidePurchase.Chktracking_warranty.Checked
                    Out_purchasesDataRow.Item("in_day") = MYFrmOutsidePurchase.Numin_day.Text
                    Out_purchasesDataRow.Item("in_mile") = MYFrmOutsidePurchase.Numin_mile.Text
                    Out_purchasesDataRow.Item("tracking_core") = MYFrmOutsidePurchase.Chktracking_core.Checked
                    Out_purchasesDataRow.Item("core_value") = MYFrmOutsidePurchase.Numcore_value.Text
                    Out_purchasesDataRow.Item("PaidFlag") = MYFrmOutsidePurchase.ChkPrepaid.Checked
                End If
                Dim ThisTempDataRow As DataRow
                dr = DsFrmWorkOrders1.service_center_dtl.FindByradif(CurrentRow.Cells("radif").Value)
                If Not IsNothing(dr) Then
                    dr("cod_select") = MYFrmOutsidePurchase.Txtpart_no.Text
                    dr("desc_radif") = MYFrmOutsidePurchase.TxtDescription.Text
                    If dr("qty") = 0 Then
                        dr("qty") = 1
                    End If
                    dr("Price") = MYFrmOutsidePurchase.NumPrice.Numbervalue
                    dr("Fet") = MYFrmOutsidePurchase.NumFet.Numbervalue
                End If
                CurrentRow.Cells("cod_select").Value = MYFrmOutsidePurchase.Txtpart_no.Text
                CurrentRow.Cells("desc_radif").Value = MYFrmOutsidePurchase.TxtDescription.Text
                If CurrentRow.Cells("qty").Value = 0 Then
                    CurrentRow.Cells("qty").Value = 1
                End If
                CurrentRow.Cells("Price").Value = MYFrmOutsidePurchase.NumPrice.Numbervalue
                CurrentRow.Cells("Fet").Value = MYFrmOutsidePurchase.NumFet.Numbervalue

                Invoice_NO_Default_For_Outside_Purchase = MYFrmOutsidePurchase.Txtinvoice_no.Text
                If Mid(MYFrmOutsidePurchase.Dteinvoice_date.Text, 1, 2).Trim.Length = 0 Then
                    Invoice_Date_Default_For_Outside_Purchase = ""
                Else
                    Invoice_Date_Default_For_Outside_Purchase = MYFrmOutsidePurchase.Dteinvoice_date.Text
                End If
                Po_No_Default_For_Outside_Purchase = MYFrmOutsidePurchase.Txtpo_no.Text
                If Mid(MYFrmOutsidePurchase.Dtedue_date.Text, 1, 2).Trim.Length = 0 Then
                    Due_Date_Default_For_Outside_Purchase = Format(Now.Date, PubDateFormat)
                Else
                    Due_Date_Default_For_Outside_Purchase = MYFrmOutsidePurchase.Dtedue_date.Text
                End If
                Markup_Default_For_Outside_Purchase = MYFrmOutsidePurchase.NumMarkup.Text
                Vendor_Default_For_Outside_Purchase = MYFrmOutsidePurchase.Vendor_Cod1.Text
                Line_Default_For_Outside_Purchase = MYFrmOutsidePurchase.CmbLine.SelectedValue & ""
            End If
            Call SelectRow(GrdDetail.Row, 6)
            'GrdDetail.UpdateData()
            'Call SelectRow(GrdDetail.Row, 6)
        End If
        FlgInShowOutsidePurchase = True
    End Sub
    Private Sub ShowTireAdjustment()
        If FlgInShowTireAdjustment Then
            FlgInShowTireAdjustment = False
            '''GrdDetail.UpdateData()
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            Dim MYFrmTireAdjustment As New FrmTireAdjustment
            MYFrmTireAdjustment.ThisFormStatus = ThisFormStatus

            MYFrmTireAdjustment.lblDescription.Text = CurrentRow.Cells("desc_radif").Value
            MYFrmTireAdjustment.lblCustomer.Text = CustomerCod1.CustomerDesc
            MYFrmTireAdjustment.lblDate.Text = TxtDate.Text
            MYFrmTireAdjustment.lblItemNo.Text = CurrentRow.Cells("cod_select").Value
            MYFrmTireAdjustment.lblLine.Text = ""
            MYFrmTireAdjustment.lblSize.Text = ""

            Dim dr As DataRow
            dr = DsFrmWorkOrders1.service_tire_adjustment.FindByradif(CurrentRow.Cells("radif").Value)
            If Not IsNothing(dr) Then
                MYFrmTireAdjustment.Txtcondition_code.Text = dr("condition_code") & ""
                MYFrmTireAdjustment.TxtDOT_safety_code.Text = dr("DOT_safety_code") & ""
                MYFrmTireAdjustment.TXTDOT_serial_no.Text = dr("DOT_serial_no") & ""
                MYFrmTireAdjustment.Txtmeasured_tread_depth.Text = dr("measured_tread_depth") & ""
                MYFrmTireAdjustment.Numsupplier_percent.Text = dr("supplier_percent")
                MYFrmTireAdjustment.Numcostomer_portion.Text = dr("costomer_portion")
            End If
            MYFrmTireAdjustment.ItemPriceVar = CurrentRow.Cells("Price").Value
            MYFrmTireAdjustment.ShowDialog()
            If MYFrmTireAdjustment.IsOK Then
                If IsNothing(dr) Then
                    dr = DsFrmWorkOrders1.service_tire_adjustment.NewRow
                    dr("radif") = CurrentRow.Cells("radif").Value
                    dr("id_service_center") = TxtRef.Text
                    dr("condition_code") = MYFrmTireAdjustment.Txtcondition_code.Text
                    dr("DOT_safety_code") = MYFrmTireAdjustment.TxtDOT_safety_code.Text
                    dr("DOT_serial_no") = MYFrmTireAdjustment.TXTDOT_serial_no.Text
                    dr("measured_tread_depth") = MYFrmTireAdjustment.Txtmeasured_tread_depth.Text
                    dr("costomer_portion") = MYFrmTireAdjustment.Numcostomer_portion.Text
                    dr("supplier_percent") = MYFrmTireAdjustment.Numsupplier_percent.Text
                    DsFrmWorkOrders1.service_tire_adjustment.Rows.Add(dr)
                Else
                    Dim service_tire_adjustmentDataRow As DSFrmWorkOrders.service_tire_adjustmentRow
                    service_tire_adjustmentDataRow = DsFrmWorkOrders1.service_tire_adjustment.FindByradif(CurrentRow.Cells("radif").Value)
                    service_tire_adjustmentDataRow.Item("radif") = CurrentRow.Cells("radif").Value
                    service_tire_adjustmentDataRow.Item("id_service_center") = TxtRef.Text
                    service_tire_adjustmentDataRow.Item("condition_code") = MYFrmTireAdjustment.Txtcondition_code.Text
                    service_tire_adjustmentDataRow.Item("DOT_safety_code") = MYFrmTireAdjustment.TxtDOT_safety_code.Text
                    service_tire_adjustmentDataRow.Item("DOT_serial_no") = MYFrmTireAdjustment.TXTDOT_serial_no.Text
                    service_tire_adjustmentDataRow.Item("measured_tread_depth") = MYFrmTireAdjustment.Txtmeasured_tread_depth.Text
                    service_tire_adjustmentDataRow.Item("costomer_portion") = MYFrmTireAdjustment.Numcostomer_portion.Text
                    service_tire_adjustmentDataRow.Item("supplier_percent") = MYFrmTireAdjustment.Numsupplier_percent.Text
                End If
                CurrentRow.Cells("Price").Value = MYFrmTireAdjustment.Numcostomer_portion.Numbervalue
            End If
            Call SelectRow(GrdDetail.Row, 6)
        End If
        FlgInShowTireAdjustment = True
    End Sub
    Private Sub GrdDetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdDetail.KeyDown
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            Dim CurrentRowGrid As Long = 2
            Dim flg2 As Boolean = False

            Dim row As Integer = GrdDetail.Row
            Dim col As Integer = GrdDetail.Col
            '-------------------------------------------------------------
            'If CurrentRow.Cells(0).Value = "O" Then
            '    Call ShowOutsidePurchase()
            '    Exit Sub
            'End If
            Try
                Call EnableDisableDescription(BeforeRowEx.Cells("type_select").Value)
            Catch ex As Exception
            End Try

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
                                    Case 4 ' ItemCode
                                        Select Case CurrentRow.Cells(0).Value
                                            Case "I", "A"
                                                FlgInShowTireAdjustment = False
                                                Call FndItemCode()
                                                FlgInShowTireAdjustment = True
                                                Call SelectRow(row, 6)
                                            Case "L"
                                                Call FndServiceCode("L")
                                                Call SelectRow(row, 6)
                                            Case "F"
                                                Call FndServiceCode("F")
                                                Call SelectRow(row, 6)
                                            Case "S"
                                                Call FndServiceCode("S")
                                                Call SelectRow(row, 6)
                                            Case "P"
                                                Call FndPackageCode()
                                                Call SelectRow(row, 0)
                                                'SendKeys.Send(vbTab)
                                            Case "O"
                                                Call ShowOutsidePurchase()
                                            Case "C"
                                                Call FndReadyComment()
                                                Call SelectRow(row, 6)
                                        End Select
                                        'SendKeys.Send(vbTab)
                                End Select
                            Case Keys.Enter
                                Select Case GrdDetail.Col
                                    Case 7 '6
                                        SelectRow(GrdDetail.Row, 11)
                                End Select
                            Case Keys.Tab
                                Select Case GrdDetail.Col
                                    Case 7 '6
                                        SelectRow(GrdDetail.Row, 9)
                                End Select
                                ' ItemCode
                                'If GrdDetail.Col = Sequence.TranQty Then
                                '    SendKeys.Send(vbTab)
                                'End If
                                'IssueFlagSave = True
                            Case Keys.F9
                                'Dim MyFrmKardexKala As New FrmKardexKala
                                'MyFrmKardexKala.TopLevel = False
                                'MyFrmKardexKala.Parent = Me.Parent
                                'MyFrmKardexKala.ThisFormStatus = MainModule.WorkStates._ReadOnly
                                'MyFrmKardexKala.InvCodeParam = InvCode1.Text
                                'MyFrmKardexKala.ItemCodeParam = CurrentRow.Cells(1).Value
                                'MyFrmKardexKala.Show()
                                'MyFrmKardexKala.BringToFront()
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
    Private Function FndItemCode() As String
        'MyFrmSearchItemCode.FrmSearchInv_anbar_kalaCodAnbar = InvCode1.Text
        Try
            CanChangeCustomerNameFlag = False
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            MyFrmSearchItemCode.Pricelevel = Val(CustomerCod1.Price_Level & "")
            MyFrmSearchItemCode.ShowDialog()
            GrdDetail.Focus()
            SelectRow(CurrentRow.RowIndex, 6)
        Catch ex As Exception
        End Try
        CanChangeCustomerNameFlag = True
        Try
            'DsFrmWorkOrders1.inv
        Catch ex As Exception
        End Try
    End Function
    Private Sub MyFrmSearchItemCode_Item_noFind(ByVal ThisItemCode As String, ByVal ThisItemDesc As String) Handles MyFrmSearchItemCode.Item_noFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            If CurrentRow Is Nothing Then Exit Sub
            If CurrentRow.Cells(0).Value = " " Then CurrentRow.Cells(0).Value = "I"
            If CurrentRow.Cells(0).Value = "I" Or CurrentRow.Cells(0).Value = "A" Then

                SelectRow(GrdDetail.Row, 6)
                SelectRow(GrdDetail.Row, 4)
                CurrentRow.Cells(4).Value = ThisItemCode
                CurrentRow.Cells(5).Value = ThisItemDesc
                SelectRow(GrdDetail.Row, 4)
                GrdDetail.Focus()
            End If
        End If
    End Sub
    Private Function FndPackageCode() As String
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        MyFrmSearchcod_pakage.ShowDialog()
        GrdDetail.Focus()
        SelectRow(CurrentRow.RowIndex, 6)
    End Function
    Private Function FndServiceCode(ByVal ServiceKind As String) As String
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        MyFrmSearchServiceCode.KindService = ServiceKind
        MyFrmSearchServiceCode.ShowDialog()
        GrdDetail.Focus()
        SelectRow(CurrentRow.RowIndex, 6)
    End Function
    Private Function FndReadyComment() As String
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        MyFrmSearchReadyComments.ShowDialog()
        GrdDetail.Focus()
        SelectRow(CurrentRow.RowIndex, 6)
    End Function
    Private Sub MyFrmSearchReadyComments_ReadyCommentFind(ByVal ThisReadyCommentDesc As String, ByVal ThisReadyCommentCode As String) Handles MyFrmSearchReadyComments.ReadyCommentFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        'Dim flg2 As Boolean = False
        If CurrentRow Is Nothing Then Exit Sub
        'If CurrentRow.RowType <> RowType.NewRecord Then
        '    CurrentRow.BeginEdit()
        '    flg2 = True
        'End If
        CurrentRow.Cells(4).Value = ThisReadyCommentCode
        CurrentRow.Cells(5).Value = ThisReadyCommentDesc
        'If flg2 Then CurrentRow.EndEdit()
        SelectRow(GrdDetail.Row, 5)
    End Sub
    Private Sub MyFrmSearchServiceCode_Labor_ServiceFind(ByVal ThisLabor_ServiceCod As String, ByVal Thisdesc_Service As String) Handles MyFrmSearchServiceCode.Labor_ServiceFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        'Dim flg2 As Boolean = False
        If CurrentRow Is Nothing Then Exit Sub
        'If CurrentRow.RowType <> RowType.NewRecord Then
        '    CurrentRow.BeginEdit()
        '    flg2 = True
        'End If
        CurrentRow.Cells(4).Value = ThisLabor_ServiceCod
        CurrentRow.Cells(5).Value = Thisdesc_Service
        'If flg2 Then CurrentRow.EndEdit()
        SelectRow(GrdDetail.Row, 6)
    End Sub
    Private Sub MyFrmSearchcod_pakage_Cod_PakageFind(ByVal ThisCod_Pakage As String, ByVal ThisDesc_Pakage As String, ByVal ThisPakageDataTable As DataTable) Handles MyFrmSearchcod_pakage.Cod_PakageFind
        Try
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            If CurrentRow Is Nothing Then Exit Sub
            Dim i As Integer, j As Integer = CurrentRow.Cells("radif").Value
            If ThisPakageDataTable.Rows.Count > 0 Then
                For i = 0 To ThisPakageDataTable.Rows.Count - 1
                    Dim dr As DataRow
                    'dr = DsFrmWorkOrders1.service_center_dtl.Rows(i + j - 1)
                    dr = DsFrmWorkOrders1.service_center_dtl.Rows.Find(i + j)
                    If i = 0 Then
                        CurrentRow.Cells("type_select").Value() = ThisPakageDataTable.Rows(i).Item("type_select")
                        CurrentRow.Cells("cod_select").Value() = ThisPakageDataTable.Rows(i).Item("cod_select")
                    End If
                    dr("id_service_center") = TxtRef.Text
                    ''''''''dr("radif") = j + i
                    dr("type_select") = ThisPakageDataTable.Rows(i).Item("type_select")
                    dr("cod_select") = ThisPakageDataTable.Rows(i).Item("cod_select")
                    dr("desc_radif") = ThisPakageDataTable.Rows(i).Item("desc_radif")
                    dr("qty") = ThisPakageDataTable.Rows(i).Item("qty")
                    dr("price") = ThisPakageDataTable.Rows(i).Item("price")
                    '''''''''''''''dr("Ext_Price") = ThisPakageDataTable.Rows(i).Item("qty") * (ThisPakageDataTable.Rows(i).Item("price") + ThisPakageDataTable.Rows(i).Item("Fet"))
                    dr("fet") = 0

                    Select Case ThisPakageDataTable.Rows(i).Item("type_select")
                        Case "I", "A"
                            MyItem.Item_no = ThisPakageDataTable.Rows(i).Item("cod_select")
                            MyItem.FindDesc(MyItem.Item_no)
                            dr("taxable") = MyItem.Taxable
                        Case "F", "L"
                            Mylabor_service.cod_Service = ThisPakageDataTable.Rows(i).Item("cod_select")
                            Mylabor_service.FindDesc(Mylabor_service.cod_Service)
                            dr("taxable") = Mylabor_service.Taxable
                        Case Else
                            dr("taxable") = 1
                    End Select

                    dr("cod_technician") = ""
                    dr("FlagIsPackage") = 1
                    ''     SendKeys.Send("{DOWN}")
                Next
            End If
            CurrentRow = GrdDetail.GetRow()
            SelectRow(GrdDetail.Row, 0)
        Catch ex As Exception
            MsgBox("Error In Inserting Package.Please Try Again")
        End Try
    End Sub
    'Private Sub MyFrmSearchcod_pakage_Cod_PakageFind(ByVal ThisCod_Pakage As String, ByVal ThisDesc_Pakage As String, ByVal ThisPakageDataTable As DataTable) Handles MyFrmSearchcod_pakage.Cod_PakageFind
    '    Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
    '    If CurrentRow Is Nothing Then Exit Sub
    '    Dim i As Integer, j As Integer = CurrentRow.Cells(13).Value
    '    If ThisPakageDataTable.Rows.Count > 0 Then
    '        For i = DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1 To j Step -1
    '            Dim dr As DataRow
    '            dr = DsFrmWorkOrders1.service_center_dtl.Rows(i)
    '            dr("radif") = i + ThisPakageDataTable.Rows.Count
    '        Next
    '        For i = 0 To ThisPakageDataTable.Rows.Count - 1
    '            Dim dr As DataRow
    '            If i > 0 Then
    '                dr = DsFrmWorkOrders1.service_center_dtl.NewRow
    '            Else
    '                dr = DsFrmWorkOrders1.service_center_dtl.Rows(j - 1)
    '                CurrentRow.Cells("type_select").Value() = ThisPakageDataTable.Rows(i).Item("type_select")
    '                CurrentRow.Cells("cod_select").Value() = ThisPakageDataTable.Rows(i).Item("cod_select")
    '            End If
    '            dr("id_service_center") = TxtRef.Text
    '            dr("radif") = j + i
    '            dr("type_select") = ThisPakageDataTable.Rows(i).Item("type_select")
    '            dr("cod_select") = ThisPakageDataTable.Rows(i).Item("cod_select")
    '            dr("desc_radif") = ThisPakageDataTable.Rows(i).Item("desc_radif")
    '            dr("qty") = ThisPakageDataTable.Rows(i).Item("qty")
    '            dr("price") = ThisPakageDataTable.Rows(i).Item("price")
    '            dr("fet") = 0
    '            dr("taxable") = 1
    '            dr("cod_technician") = ""
    '            If i > 0 Then
    '                DsFrmWorkOrders1.service_center_dtl.Rows.Add(dr)
    '            End If
    '            SendKeys.Send("{DOWN}")
    '        Next
    '    End If
    '    'For i = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
    '    '    Dim dr As DataRow
    '    '    dr = DsFrmWorkOrders1.service_center_dtl.Rows(i)
    '    '    dr("radif") = i + 1
    '    'Next
    '    CurrentRow = GrdDetail.GetRow()
    '    SelectRow(GrdDetail.Row, False)
    'End Sub
    Private Sub GrdDetail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.GotFocus
        SelectRow(GrdDetail.Row, 0)
    End Sub
    Private Function SayItemName() As Boolean
        SayItemName = True
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Try
            Select Case ThisRowGrid.Cells(0).Value
                Case "I", "A"
                    MyItem.Item_no = ThisRowGrid.Cells(4).Value
                    MyItem.FindDesc(MyItem.Item_no)
                    ThisRowGrid.Cells(5).Value = MyItem.desc_Item
                    Dim FetOdThisItem As Decimal = 0
                    If ThisRowGrid.Cells("FlagIsPackage").Value <> 1 Then
                        ThisRowGrid.Cells(7).Value = MyItem.CalculatePriceCode(MyItem.Item_no, CustomerCod1.Price_Level, FetOdThisItem)
                    End If
                    ThisRowGrid.Cells(8).Value = FetOdThisItem
                    ThisRowGrid.Cells(9).Value = MyItem.Taxable

                    GrdDetail.Focus()

                Case "F", "L"
                    Mylabor_service.cod_Service = ThisRowGrid.Cells(4).Value
                    If ThisRowGrid.Cells(0).Value = "L" Then
                        Mylabor_service.FindDesc(Mylabor_service.cod_Service, "01")
                    Else
                        Mylabor_service.FindDesc(Mylabor_service.cod_Service, "02")
                    End If
                    ThisRowGrid.Cells(5).Value = Mylabor_service.desc_Service
                    ThisRowGrid.Cells(9).Value = Mylabor_service.Taxable
                    If Trim(ThisRowGrid.Cells(5).Value).Length = 0 Then
                        SayItemName = False
                        Exit Function
                    End If
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "Select bas_vehicle_size.cod_size_main FROM ser_tr_vehicle INNER JOIN bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle INNER JOIN bas_vehicle_size ON bas_vehicle.cod_vehicle = bas_vehicle_size.cod_vehicle Where cod_vehicle=" & Qt(License_No1.CodVehicle)
                    Dim ThisVehicleSize As String = ""
                    Try
                        ThisVehicleSize = CmdGeneral.ExecuteScalar & ""
                    Catch ex As Exception
                        ThisVehicleSize = ""
                    End Try
                    Dim StyleOfVehicle As String = ""
                    If ThisVehicleSize.Trim.Length > 0 Then
                        If CmdGeneral.Connection.State <> ConnectionState.Open Then
                            CmdGeneral.Connection.Open()
                        End If
                        CmdGeneral.CommandText = "SELECT inv_item.Style FROM inv_tab_tire_specification INNER JOIN inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public INNER JOIN inv_item ON inv_tab_tire_specification.item_no = inv_item.item_no WHERE (inv_tab_public.cod_table_main = '01') AND inv_tab_tire_specification.tire_size = " & Qt(ThisVehicleSize)
                        Try
                            StyleOfVehicle = CmdGeneral.ExecuteScalar & ""
                        Catch ex As Exception
                            StyleOfVehicle = ""
                        End Try
                    End If
                    If StyleOfVehicle.Trim.Length = 0 Then
                        MyFrmGetStyle.CmbStyle.SelectedValue = "0"
                        MyFrmGetStyle.DsFrmGetStyle1.Clear()
                        MyFrmGetStyle.DAinv_tab_style.SelectCommand.Parameters("@cod_Service").Value = Mylabor_service.cod_Service
                        MyFrmGetStyle.DAinv_tab_style.Fill(MyFrmGetStyle.DsFrmGetStyle1.inv_tab_style)
                        Select Case MyFrmGetStyle.DsFrmGetStyle1.inv_tab_style.Rows.Count
                            Case Is = 0
                                MsgBox("This Service Has No Price")
                            Case Is = 1
                                StyleOfVehicle = MyFrmGetStyle.DsFrmGetStyle1.inv_tab_style.Rows(0).Item("style")
                            Case Else
                                MyFrmGetStyle.ShowDialog()
                                If MyFrmGetStyle.OkVar Then
                                    StyleOfVehicle = MyFrmGetStyle.CmbStyle.SelectedValue
                                End If
                        End Select
                    End If
                    If ThisRowGrid.Cells("FlagIsPackage").Value <> 1 Then
                        ThisRowGrid.Cells(7).Value = Mylabor_service.CalculatePriceCode(Mylabor_service.cod_Service, CustomerCod1.Price_Level, StyleOfVehicle)
                    End If
                    ThisRowGrid.Cells(8).Value = 0
                    'Case "S"
                    '    Mylabor_service.cod_Service = ThisRowGrid.Cells(4).Value
                    '    Mylabor_service.FindDesc(Mylabor_service.cod_Service, "03")
                    '    ThisRowGrid.Cells(5).Value = Mylabor_service.desc_Service
                    '    ThisRowGrid.Cells(9).Value = Mylabor_service.Taxable
                Case "P"
                    MyPackage.Cod_pakage = ThisRowGrid.Cells(4).Value
                    MyPackage.FindDesc(MyPackage.Cod_pakage)
                    DsFrmWorkOrders1.inv_tab_pakage.Clear()
                    DAinv_tab_pakage.SelectCommand.CommandText = "SELECT * FROM inv_tab_pakage where cod_pakage=" & Qt(MyPackage.Cod_pakage) & " Order by radif"
                    DAinv_tab_pakage.Fill(DsFrmWorkOrders1, "inv_tab_pakage")
                    MyFrmSearchcod_pakage_Cod_PakageFind(MyPackage.Cod_pakage, MyPackage.Desc_pakage, DsFrmWorkOrders1.inv_tab_pakage)
                Case "C"
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "SELECT CommentDesc FROM  Bas_Ready_Comment WHERE CommentCode =" & Qt(ThisRowGrid.Cells(4).Value & "")
                    MyFrmSearchReadyComments_ReadyCommentFind(CmdGeneral.ExecuteScalar() & "", ThisRowGrid.Cells(4).Value & "")
            End Select
        Catch ex As Exception
            SayItemName = True
        End Try
    End Function
    Private Sub MyItem_AfterFindCalculatePricrCode(ByVal ThisDatatRow As System.Data.DataRow, ByVal ThisItemPrice As Decimal) Handles MyItem.AfterFindCalculatePricrCode
        'ThisRowGrid.Cells(7).Value = MyItem.CalculatePriceCode(MyItem.Item_no, 1)
    End Sub
    Private Sub FrmWorkOrders_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If BtnNew.Enabled Then
            CustomerCod1.Text = ""
            License_No1.Text = ""
        Else
            MsgBox("First You Should Save or Cancel The " & LblType.Text)
            e.Cancel = True
        End If
    End Sub
    Private Sub License_No1_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles License_No1.AfterFieldCodValueFind
        Try
            LblVehicleMake.Text = ""
            LblVehicleModel.Text = ""
            LblVehicleVin.Text = ""
            LblVehicleYear.Text = ""
            VehicleColorVar = ""
            UnitNoVar = ""
            Desc_kind_engineVar = ""

            LblVehicleMake.Text = ThisRow.Item("desc_make") & ""
            LblVehicleModel.Text = ThisRow.Item("desc_model") & ""
            LblVehicleVin.Text = ThisRow.Item("vin") & ""
            LblVehicleYear.Text = ThisRow.Item("make_year") & ""
            VehicleColorVar = ThisRow.Item("desc_color") & ""
            UnitNoVar = ThisRow.Item("Unit_No") & ""
            Desc_kind_engineVar = ThisRow.Item("desc_kind_engine") & ""
            If CustomerCod1.Text.Trim <> Trim((ThisRow.Item("cod_customer") & "")) Then
                CustomerCod1.Text = ThisRow.Item("cod_customer") & ""
            End If
        Catch ex As Exception
            LblVehicleMake.Text = ""
            LblVehicleModel.Text = ""
            LblVehicleVin.Text = ""
            LblVehicleYear.Text = ""
            VehicleColorVar = ""
            UnitNoVar = ""
            Desc_kind_engineVar = ""
        End Try
    End Sub







    Private Sub SetMojoodiAfterSave(ByVal TypeParam As String, ByVal ThisTypeSelect As String, ByVal ThisCodeSelect As String, ByVal ThisQty As Double)
        If ThisTypeSelect = "I" Or ThisTypeSelect = "A" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case TypeParam
                Case "WO"
                    CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set comitted=comitted + " & ThisQty & " Where item_no=" & Qt(ThisCodeSelect) & " AND cod_warehouse=" & Qt(PWareHouse)
                    CmdGeneral.ExecuteNonQuery()
                    CmdGeneral.CommandText = "Select on_hand-comitted From inv_tab_item_warehouse Where item_no=" & Qt(ThisCodeSelect) & " AND cod_warehouse=" & Qt(PWareHouse)
                    Dim QtyTempVar As Int16
                    QtyTempVar = CmdGeneral.ExecuteScalar
                    If QtyTempVar < 0 And CHKRULES_For_Warn_Qty_Var Then
                        MsgBox("Item No : " & Qt(ThisCodeSelect) & "The COMMITED qty is bigger than ON HAND qty.", MsgBoxStyle.Information)
                    End If
                Case "IN"
                    CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand - " & ThisQty & " Where item_no=" & Qt(ThisCodeSelect) & " AND cod_warehouse=" & Qt(PWareHouse)
                    CmdGeneral.ExecuteNonQuery()
                    CmdGeneral.CommandText = "Select on_hand From inv_tab_item_warehouse Where item_no=" & Qt(ThisCodeSelect) & " AND cod_warehouse=" & Qt(PWareHouse)
                    Dim QtyTempVar As Int16
                    QtyTempVar = CmdGeneral.ExecuteScalar
                    If QtyTempVar < 0 And CHKRULES_For_Warn_Qty_Var Then
                        MsgBox("Qty of " & Qt(ThisCodeSelect) & " : " & Qt(QtyTempVar), MsgBoxStyle.Information)
                    End If
                Case "RT"
                    CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand - " & ThisQty & " Where item_no=" & Qt(ThisCodeSelect) & " AND cod_warehouse=" & Qt(PWareHouse)
                    CmdGeneral.ExecuteNonQuery()
                Case "ES"
            End Select
        End If





        'If DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("type_select") = "I" Or DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("type_select") = "A" Then
        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '        CmdGeneral.Connection.Open()
        '    End If
        '    Select Case TypeParam
        '        Case "WO"
        '            CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set comitted=comitted + " & DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("qty") & " Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
        '            CmdGeneral.ExecuteNonQuery()
        '            CmdGeneral.CommandText = "Select on_hand-comitted From inv_tab_item_warehouse Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
        '            Dim QtyTempVar As Int16
        '            QtyTempVar = CmdGeneral.ExecuteScalar
        '            If QtyTempVar < 0 And CHKRULES_For_Warn_Qty_Var Then
        '                MsgBox("Item No : " & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("cod_select")) & "The COMMITED qty is bigger than ON HAND qty.", MsgBoxStyle.Information)
        '            End If
        '        Case "IN"
        '            CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand - " & DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("qty") & " Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
        '            CmdGeneral.ExecuteNonQuery()
        '            CmdGeneral.CommandText = "Select on_hand From inv_tab_item_warehouse Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
        '            Dim QtyTempVar As Int16
        '            QtyTempVar = CmdGeneral.ExecuteScalar
        '            If QtyTempVar < 0 And CHKRULES_For_Warn_Qty_Var Then
        '                MsgBox("Qty of " & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("cod_select")) & " : " & Qt(QtyTempVar), MsgBoxStyle.Information)
        '            End If
        '        Case "RT"
        '            CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand - " & DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("qty") & " Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl.Rows(service_center_dtl_RowVar).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
        '            CmdGeneral.ExecuteNonQuery()
        '        Case "ES"
        '    End Select
        'End If
    End Sub










    Private Sub SetPrevMojoodiForBefore_ID_Service_Center(ByVal Id_service_centerParam As String)
        Dim WorkOrderIdVar As String = ""
        Select Case CmbType.Text.ToUpper
            Case "IN"
                WorkOrderIdVar = FindWorkOrderNo(Id_service_centerParam)
            Case "RT"
                WorkOrderIdVar = FindInvoiceNo(Id_service_centerParam)
        End Select
        If WorkOrderIdVar.Trim.Length > 0 Then
            Dim SQLReader As System.Data.SqlClient.SqlDataReader
            If CmdReader.Connection.State <> ConnectionState.Open Then
                CmdReader.Connection.Open()
            End If
            CmdReader.CommandText = "SELECT * from service_center_dtl where id_service_center=" & Qt(WorkOrderIdVar) & " AND type_select='I'"
            SQLReader = CmdReader.ExecuteReader
            If SQLReader.HasRows Then
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Do While SQLReader.Read()
                    Select Case CmbType.Text.ToUpper
                        Case "IN" ' - that means "WO"
                            CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set comitted=comitted + " & SQLReader.Item("qty") & " Where item_no=" & Qt(SQLReader.Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                            CmdGeneral.ExecuteNonQuery()
                        Case "RT" ' - that means "IN"
                            CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand - " & SQLReader.Item("qty") & " Where item_no=" & Qt(SQLReader.Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                            CmdGeneral.ExecuteNonQuery()
                    End Select
                Loop
                CmdGeneral.Connection.Close()
            End If
            SQLReader.Close()
        End If
    End Sub
    Private Sub SetPrevMojoodi(ByVal Id_service_centerParam As String)
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdReader.Connection.State <> ConnectionState.Open Then
            CmdReader.Connection.Open()
        End If
        CmdReader.CommandText = "SELECT * from service_center_dtl where id_service_center=" & Qt(Id_service_centerParam) & " AND (type_select='I' OR type_select='A')"
        SQLReader = CmdReader.ExecuteReader
        If SQLReader.HasRows Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Do While SQLReader.Read()
                Select Case CmbType.Text.ToUpper
                    Case "WO"
                        CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set comitted=comitted - " & SQLReader.Item("qty") & " Where item_no=" & Qt(SQLReader.Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                        CmdGeneral.ExecuteNonQuery()
                    Case "IN"
                        CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand + " & SQLReader.Item("qty") & " Where item_no=" & Qt(SQLReader.Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                        CmdGeneral.ExecuteNonQuery()
                    Case "RT"
                        CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand + " & SQLReader.Item("qty") & " Where item_no=" & Qt(SQLReader.Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                        CmdGeneral.ExecuteNonQuery()
                    Case "ES"
                End Select
            Loop
            CmdGeneral.Connection.Close()
        End If
        SQLReader.Close()

        'CmdReader.Connection.Close()
    End Sub
    Private Sub SetPrevMojoodiT(ByVal Id_service_centerParam As String)
        DAGeneralLock.SelectCommand.CommandText = "SELECT  cod_select,qty from service_center_dtl where id_service_center=" & Qt(Id_service_centerParam) & " AND type_select='I'"
        DAGeneralLock.Fill(DsFrmWorkOrders1.service_center_dtl_Temp)
        If DsFrmWorkOrders1.service_center_dtl_Temp.Rows.Count > 0 Then
            Dim SetPrevMojoodiCounter As Integer
            For SetPrevMojoodiCounter = 0 To DsFrmWorkOrders1.service_center_dtl_Temp.Rows.Count - 1
                Select Case CmbType.Text.ToUpper
                    Case "WO"
                        CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set comitted=comitted - " & DsFrmWorkOrders1.service_center_dtl_Temp.Rows(SetPrevMojoodiCounter).Item("qty") & " Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl_Temp.Rows(SetPrevMojoodiCounter).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                        CmdGeneral.ExecuteNonQuery()
                    Case "IN"
                        CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand + " & DsFrmWorkOrders1.service_center_dtl_Temp.Rows(SetPrevMojoodiCounter).Item("qty") & " Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl_Temp.Rows(SetPrevMojoodiCounter).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                        CmdGeneral.ExecuteNonQuery()
                    Case "RT"
                        CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand + " & DsFrmWorkOrders1.service_center_dtl_Temp.Rows(SetPrevMojoodiCounter).Item("qty") & " Where item_no=" & Qt(DsFrmWorkOrders1.service_center_dtl_Temp.Rows(SetPrevMojoodiCounter).Item("cod_select")) & " AND cod_warehouse=" & Qt(PWareHouse)
                        CmdGeneral.ExecuteNonQuery()
                    Case "ES"
                End Select
            Next
        End If
    End Sub
    Private Sub GrdDetail_Error(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ErrorEventArgs) Handles GrdDetail.Error
        MsgBox(e.ErrorMessage)
    End Sub
    Private Sub SendMail()
        
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveCompanySetupTable()
        'OleDbReader = RetrieveStoreSetupTable(PubStoreNO)
        Dim StoreEmailAddressVar As String = OleDbReader.Item("EMAIL") & ""
        OleDbReader.Close()
        If StoreEmailAddressVar.Trim.Length = 0 Then
            MsgBox("please fill Company Email Address in setup tables and try again")
            Exit Sub
        End If

        'TODO System.Web.Mail should be replaced by importing System.Web.Mail
        Dim MyFrmSendMailInformation As New CommonClass.FrmSendMailInformation
        MyFrmSendMailInformation.txtTo.Text = CustomerCod1.EmAilAddress & ""
        MyFrmSendMailInformation.TxtSubject.Text = "Subject Test"
        MyFrmSendMailInformation.TxtBody.Text = "Body Test"
        MyFrmSendMailInformation.ShowDialog()
        If MyFrmSendMailInformation.IsOkFlag Then
            If MyFrmSendMailInformation.txtTo.Text.Trim.Length = 0 Then
                MsgBox("please fill Customer Mail Address and try again")
                Exit Sub
            End If
            If MyFrmSendMailInformation.TxtSubject.Text.Trim.Length = 0 Then
                MsgBox("please fill Subject and try again")
                Exit Sub
            End If
            If MyFrmSendMailInformation.TxtBody.Text.Trim.Length = 0 Then
                MsgBox("please fill Body and try again")
                Exit Sub
            End If
            Dim mail As System.Web.Mail.MailMessage = New System.Web.Mail.MailMessage
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "invoice@tiremate.net")
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "invoice")
            ''            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "TiremateRocks123")
            mail.To = MyFrmSendMailInformation.txtTo.Text '"ketabie@yahoo.com;kamran_faraji@yahoo.com;mhz_home@yahoo.com"
            mail.From = StoreEmailAddressVar
            mail.Subject = MyFrmSendMailInformation.TxtSubject.Text
            mail.Body = MyFrmSendMailInformation.TxtBody.Text
           
            mail.Attachments.Add(New System.Web.Mail.MailAttachment(emailPath & "Invoice" & TxtRef.Text.Trim & ".Doc"))
            System.Web.Mail.SmtpMail.SmtpServer = "smtp.1and1.com"
            'TODO Try-Catch for exception
            Try
                System.Web.Mail.SmtpMail.Send(mail)
                MsgBox("Job Successfully Performed", MsgBoxStyle.Information)
            Catch ex As Exception
                ''  MsgBox("Please connect to internet and try again", MsgBoxStyle.Exclamation)
                MsgBox("Your invoice was saved successfully", MsgBoxStyle.Information)
            End Try
        End If




        '1-
        'Dim mailMessage As MailMessage = New MailMessage
        'mailMessage.From = "ketabie@yahoo.com"
        'mailMessage.To = "ketabie@yahoo.com"
        'mailMessage.Subject = "Hello World"
        'mailMessage.BodyFormat = System.Web.Mail.MailFormat.Text
        'mailMessage.Attachments.Add(New MailAttachment("c:\Tmp.Jpeg"))
        'mailMessage.Body = "Hello World aaa"
        ''SmtpMail.SmtpServer = "smtpServer" // 's address
        'SmtpMail.Send(mailMessage)



        '2-
        'Dim mailMsg As New MailMessage
        'With mailMsg
        '    .From = "Ketabie@yahoo.com"  ' The from address source 
        '    .To = "Ketabie@yahoo.com" ' The to address source
        '    .Cc = "" ' the CC Address(es) source 
        '    .Bcc = "" ' The BCC Address(es) source 
        '    .Subject = "Test Subject" ' The subject source 
        '    .Body = "Salam.Baba to dige hasti" ' The body source 
        '    '''.Priority = CType(cboPriority.SelectedIndex, MailPriority) ' The message priority 
        '    ' The original code uses an array list to add different attachments, so I'm not 100% certain this would work 
        '    ' But after examining all of it, I see no reason it should not. 
        '    .Attachments.Add("c:\Tmp.Jpeg") ' where "c:\log.txt" is the location of the log(s) that you need to send 
        'End With



        '3-
        '' Create a mailman to send email.
        'Dim mailman As New Chilkat.MailMan
        'mailman.UnlockComponent("UnlockCode")

        '' Set your SMTP server hostname.
        'mailman.SmtpHost = "smtp.earthlink.net"

        '' You may need these depending on your SMTP server.
        ''mailman.SmtpUsername = "username"
        ''mailman.SmtpPassword = "password"

        '' Create the email.
        'Dim email As New Chilkat.Email
        'email.Subject = "This is a test"
        'email.Body = "This is a test"
        'email.AddTo("Chilkat Support", "support@chilkatsoft.com")
        'email.AddCC("Bill Johnson", "bill@mjapanese.com")
        'email.FromAddress = "matt@chilkatsoft.com"
        'email.FromName = "Matt"

        '' Add an attachment
        'If (email.AddFileAttachment("dude.gif") Is Nothing) Then
        '    MsgBox(email.LastErrorText)
        'End If

        '' Send email.
        'If (Not mailman.SendEmail(email)) Then
        '    MsgBox(mailman.LastErrorText)
        'Else
        '    MsgBox("Email Sent!")
        'End If


        '4-
        'Dim sTo As String, sFrom As String, sSubject As String, sBody As String
        'Dim sAttach As String, sCc As String, sBcc As String, sBodyEncoding As String
        'Dim sBodyFormat As String, sMailServer As String, sPriority As String
        'Dim sUrlContentBase As String, sUrlContentLocation As String
        'Dim iLoop1 As Integer

        'sTo = "Ketabie@yahoo.com"
        'sFrom = "Ketabie@yahoo.com"
        'sSubject = "HI"
        'sBody = "This is a test message."
        'sAttach = "c:\Tmp.Jpeg"
        'sCc = "Kamran_faraji@yahoo.com"
        'sBcc = "Majid_armandeh@yahoo.com"
        'sBodyFormat = "HTML"
        ''sBodyEncoding = Encoding.ASCII.EncodingName
        'sPriority = "Normal"
        'sUrlContentBase = "http://www.contoso.com/images"
        'sUrlContentLocation = "http://www.contoso.com/images"
        'sMailServer = "smarthost"

        'Dim MyMail As MailMessage = New MailMessage
        'MyMail.From = sFrom
        'MyMail.To = sTo
        'MyMail.Subject = sSubject
        'MyMail.Body = sBody
        'MyMail.Cc = sCc
        'MyMail.Bcc = sBcc
        'MyMail.UrlContentBase = sUrlContentBase
        'MyMail.UrlContentLocation = sUrlContentLocation

        'Select Case sBodyEncoding
        '    Case Encoding.UTF7.EncodingName : MyMail.BodyEncoding = Encoding.UTF7
        '    Case Encoding.UTF8.EncodingName : MyMail.BodyEncoding = Encoding.UTF8
        '    Case Else : MyMail.BodyEncoding = Encoding.ASCII
        'End Select

        'Select Case UCase(sBodyFormat)
        '    Case "HTML" : MyMail.BodyFormat = MailFormat.Html
        '    Case Else : MyMail.BodyFormat = MailFormat.Text
        'End Select

        'Select Case UCase(sPriority)
        '    Case "HIGH" : MyMail.Priority = MailPriority.High
        '    Case "LOW" : MyMail.Priority = MailPriority.Low
        '    Case Else : MyMail.Priority = MailPriority.Normal
        'End Select

        '' Build an IList of mail attachments.
        'If sAttach <> "" Then
        '    Dim delim As Char = ","
        '    Dim sSubstr As String
        '    For Each sSubstr In sAttach.Split(delim)
        '        Dim myAttachment As MailAttachment = New MailAttachment(sSubstr)
        '        MyMail.Attachments.Add(myAttachment)
        '    Next
        'End If

        'SmtpMail.SmtpServer = sMailServer
        'SmtpMail.Send(MyMail)

        'MsgBox("VB Message sent to " & MyMail.To)


        '5- with outlook
        'Dim oApp As Microsoft.Office.Interop.Outlook.Application
        'oApp = New Microsoft.Office.Interop.Outlook.Application
        '' Create a new MailItem.
        'Dim oMsg As Microsoft.Office.Interop.Outlook.MailItem
        'oMsg = CType(oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)()
        'oMsg.Subject = "Hello!!!"
        'oMsg.Body = "Hello World"
        'oMsg.To = "emailladdress"
        'oMsg.Send()




        ''6-
        '' Variable which will send the mail
        'Dim obj As System.Web.Mail.SmtpMail

        ''Variable to store the attachments 
        'Dim Attachment As System.Web.Mail.MailAttachment

        ''Variable to create the message to send
        'Dim Mailmsg As New System.Web.Mail.MailMessage


        ''Show open dialogue box to select the files to attach
        'Dim Counter As Integer
        ''OFD.CheckFileExists = True
        ''OFD.Title = "Select file(s) to attach"
        ''OFD.ShowDialog()

        ''For Counter = 0 To UBound(OFD.FileNames)
        ''    lstAttachment.Items.Add(OFD.FileNames(Counter))
        ''Next


        ''Remove the attachments
        ''If lstAttachment.SelectedIndex > -1 Then
        ''    lstAttachment.Items.RemoveAt(lstAttachment.SelectedIndex)
        ''End If



        ''Set the properties
        ''Assign the SMTP server
        'obj.SmtpServer = "Smtp(Server)"
        ''Multiple recepients can be specified using ; as the delimeter
        ''Address of the recipient
        'Mailmsg.To = "ketabie@yahoo.com"


        ''Your From Address
        ''You can also use a custom header Reply-To for a different replyto address
        'Mailmsg.From = "\ketabie@yahoo.com\ <ketabie@yahoo.com>"


        ''Specify the body format
        'Mailmsg.BodyFormat = MailFormat.Text

        ''If you want you can add a reply to header 
        ''Mailmsg.Headers.Add("Reply-To", "Manoj@geinetech.net")
        ''custom headersare added like this
        ''Mailmsg.Headers.Add("Manoj", "TestHeader")

        ''Mail Subject
        'Mailmsg.Subject = "Hi"

        ''Attach the files one by one
        ''For Counter = 0 To lstAttachment.Items.Count - 1
        ''    Attachment = New MailAttachment(lstAttachment.Items(Counter))
        ''    'Add it to the mail message
        ''    Mailmsg.Attachments.Add(Attachment)
        ''Next

        ''Mail Body
        'Mailmsg.Body = "this is a test"
        ''Call the send method to send the mail
        'obj.Send(Mailmsg)


        '7-
        '     Quiksoft.FreeSMTP.SMTP.QuickSend( _
        '"mail.yourdomain.com", _
        '"recipient@domain.com", _
        '"sender@domain.com", _
        '"Subject...", _
        '"Message text.", _
        'Quiksoft.FreeSMTP.BodyPartFormat.Plain)
    End Sub
    Private Sub sendMail2()
        Dim oMsg As MailMessage = New MailMessage

        ' TODO: Replace with sender e-mail address.
        oMsg.From = "sender@somewhere.com"
        ' TODO: Replace with recipient e-mail address.
        oMsg.To = "recipient@somewhere.com"
        oMsg.Subject = "Send using Web Mail"

        ' SEND IN HTML FORMAT (comment this line to send plain text).
        oMsg.BodyFormat = MailFormat.Html

        'HTML Body (remove HTML tags for plain text).
        oMsg.Body = "<HTML><BODY><B>Hello World!</B></BODY></HTML>"

        ' ADD AN ATTACHMENT.
        ' TODO: Replace with path to attachment.
        Dim sFile As String = "C:\temp\Hello.txt"
        Dim oAttch As MailAttachment = New MailAttachment(sFile, MailEncoding.Base64)

        oMsg.Attachments.Add(oAttch)

        ' TODO: Replace with the name of your remote SMTP server.
        SmtpMail.SmtpServer = "MySMTPServer"
        SmtpMail.Send(oMsg)

        oMsg = Nothing
        oAttch = Nothing
    End Sub
    Private Sub PhoneButton1_PhoneScreenAfterClose() Handles PhoneButton1.PhoneScreenAfterClose
        PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
    End Sub
    Private Sub PhoneNoMain_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneNoMain.TextChanged
        Call PhoneButton1.GetPhoneNoMain(PhoneNoMain.Text)
        Call EnableDisableSave()
    End Sub
    Private Sub PhoneButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneButton1.Click
        PhoneButton1.HeaderName = CustomerCod1.CustomerDesc.Trim
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmFindServiceRecords.MainSearchTypeVar = CmbType.Text
        MyFrmFindServiceRecords.ShowDialog()
    End Sub
    Private Sub MyFrmFindServiceRecords_ServiceRecordFind(ByVal ThisId_service_center As String) Handles MyFrmFindServiceRecords.ServiceRecordFind
        Call LoadAWotkOrder(ThisId_service_center)
    End Sub
    Private Sub BtnPriceTires_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPriceTires.Click, BtnPriceTiresCopy.Click
        Call FndItemCode()
        'MyFrmSearchItemCode.ShowDialog()
    End Sub
    Private Sub BtnResetTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResetTax.Click
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "OK"
        c1.ShowFarMsg("YOU HAVE JUST CLICKED ON" + vbCrLf + "(RESET TAX) OR (SET TAX) BUTTON." + vbCrLf + "THIS OPTION ALTERS TAX CALCULATION" + vbCrLf + "FOR THIS SERVICE RECORD.")
        If c1.DialogResult = DialogResult.OK Then
            NumTax.Text = 0
            FlagResetTaxVar = Not FlagResetTaxVar
            Call SetBtnResetTaxText()
            If FlagResetTaxVar = False Then
                Call CalcTax()
            End If
        End If
    End Sub
    Private Sub SetBtnResetTaxText()
        If FlagResetTaxVar Then
            BtnResetTax.Text = "Set Tax"
            BtnResetTax.BackColor = System.Drawing.Color.Red
        Else
            BtnResetTax.Text = "Reset Tax"
            BtnResetTax.BackColor = System.Drawing.SystemColors.Control
        End If
    End Sub

    Private Sub pprint(ByVal PrintType As String, ByVal ServiceCenterType As String, ByVal ThisTxtRef As String, Optional ByVal ForcePrint As Boolean = False, Optional ByVal OnePrintFlag As Boolean = False)

        If ThisTxtRef.Trim.Length = 0 Then
            ThisTxtRef = TxtRef.Text
        End If

        'If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '    CmdGeneral.Connection.Open()
        'End If
        'CmdGeneral.CommandText = "SELECT count(*) FROM service_center_head  where id_service_center=" & Qt(ThisTxtRef)
        'If CmdGeneral.ExecuteScalar <> 1 Then
        '    MsgBox("Please Save Befor " & PrintType)
        '    Exit Sub
        'End If

        If (ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Or BtnNew.Enabled = False) And Not ForcePrint Then
            MsgBox("Please Save Befor " & PrintType)
            Exit Sub
        End If

        'If BtnSave.Enabled Then
        '    If Not psave(False) Then
        '        Exit Sub
        '    End If
        'Else
        '    If Not BtnNew.Enabled Then
        '        Exit Sub
        '    End If
        'End If

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        PreviousMileageVar = ""
        Try
            If CmdReader.Connection.State <> ConnectionState.Open Then
                CmdReader.Connection.Open()
            End If
            CmdReader.CommandText = "SELECT ser_tr_vehicle_dtl.current_mileage, service_center_head.date_refer " _
                          & " FROM ser_tr_vehicle INNER JOIN " _
                          & " bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle INNER JOIN " _
                          & " service_center_head ON ser_tr_vehicle.id_vehicle = service_center_head.id_vehicle INNER JOIN " _
                          & " ser_tr_vehicle_dtl ON service_center_head.id_service_center = ser_tr_vehicle_dtl.id_service_center " _
                          & " Where license_no_vehicle=" & Qt(License_No1.Text) & " AND service_center_head.type_of_form='IN' Order By dbo.ChangeDate(service_center_head.date_refer) desc"
            SQLReader = CmdReader.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                If SQLReader.Read Then
                    PreviousMileageVar = SQLReader.Item("current_mileage")
                End If
            End If
        Catch ex As Exception
        Finally
            SQLReader.Close()
            'CmdReader.Connection.Close()
        End Try

        Dim rpt As New RepWorkOrder
        Dim prn As New FrmRepView

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        DsFrmWorkOrders1.TempTable.Clear()
        Select Case ServiceCenterType
            Case "ES"
                DsFrmWorkOrders1.TempTable.AddTempTableRow(OleDbReaderForStore.Item("WARRANTY_FOR_ES") & "")
                Try
                    If OleDbReaderForStore.Item("EstimatesShading") = 0 Then
                        rpt.SetParameterValue("ShadingParam", True)
                    Else
                        rpt.SetParameterValue("ShadingParam", False)
                    End If
                Catch ex As Exception
                    rpt.SetParameterValue("ShadingParam", False)
                End Try
            Case "WO"
                DsFrmWorkOrders1.TempTable.AddTempTableRow(OleDbReaderForStore.Item("DISCLAIMER_FOR_WO") & "")
                Try
                    If OleDbReaderForStore.Item("WorkOrdersShading") = 0 Then
                        rpt.SetParameterValue("ShadingParam", True)
                    Else
                        rpt.SetParameterValue("ShadingParam", False)
                    End If
                Catch ex As Exception
                    rpt.SetParameterValue("ShadingParam", False)
                End Try
            Case "IN"
                DsFrmWorkOrders1.TempTable.AddTempTableRow(OleDbReaderForStore.Item("WARRANTY_FOR_IN") & "")
                Try
                    If OleDbReaderForStore.Item("InvoicesShading") = 0 Then
                        rpt.SetParameterValue("ShadingParam", True)
                    Else
                        rpt.SetParameterValue("ShadingParam", False)
                    End If
                Catch ex As Exception
                    rpt.SetParameterValue("ShadingParam", False)
                End Try
            Case "RT"
                DsFrmWorkOrders1.TempTable.AddTempTableRow("")
                Try
                    If OleDbReaderForStore.Item("CustomerReturnsShading") = 0 Then
                        rpt.SetParameterValue("ShadingParam", True)
                    Else
                        rpt.SetParameterValue("ShadingParam", False)
                    End If
                Catch ex As Exception
                    rpt.SetParameterValue("ShadingParam", False)
                End Try
            Case Else
                DsFrmWorkOrders1.TempTable.AddTempTableRow("")
                rpt.SetParameterValue("ShadingParam", False)
        End Select

        rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

        rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

        MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
        MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
        rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

        rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
        rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

        DsFrmWorkOrders1.LOGO.Clear()
        Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
        OleDbReaderForCompany = RetrieveCompanySetupTable()
        Try
            DsFrmWorkOrders1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
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
        rpt.SetParameterValue("ParVeMake", LblVehicleMake.Text)
        rpt.SetParameterValue("ParVeModel", LblVehicleModel.Text)
        rpt.SetParameterValue("ParVeYear", LblVehicleYear.Text)
        rpt.SetParameterValue("ParVeVIN", LblVehicleVin.Text)
        rpt.SetParameterValue("ParVecolor", VehicleColorVar & "")
        rpt.SetParameterValue("ParVeengine", Desc_kind_engineVar & "")
        rpt.SetParameterValue("ParVepremile", PreviousMileageVar & "")
        rpt.SetParameterValue("ParVeunit", UnitNoVar & "")
        rpt.SetParameterValue("ParVelicense", License_No1.Text)

        rpt.SetParameterValue("ParVeCurMile", NumCurrent_mileage.Text)
        rpt.SetParameterValue("Parwritten", CmbAddUser.Text)
        rpt.SetParameterValue("Parchanged", CmbChgUser.Text)
        rpt.SetParameterValue("Parsumparts", LblParts.Text)
        rpt.SetParameterValue("Parsumfet", LblFET.Text)
        rpt.SetParameterValue("Parsumlabor", LblLabor.Text)
        rpt.SetParameterValue("Parsumfees", LblFees.Text)
        rpt.SetParameterValue("Parsumsubtotal", LblSubtotal.Text)
        rpt.SetParameterValue("Parsumdiscount", NumDiscount.Text)
        rpt.SetParameterValue("Parsumtax", NumTax.Text)
        rpt.SetParameterValue("Parsumtotal", LblTotal.Text)
        rpt.SetParameterValue("Partype", ServiceCenterType & "")

        rpt.SetParameterValue("parcusno", CustomerCod1.Text)


        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim ThisDateTempVar As String
        CmdGeneral.CommandText = "Select date_refer from service_center_head where id_service_center=" & Qt(ThisTxtRef)
        ThisDateTempVar = CmdGeneral.ExecuteScalar & ""

        rpt.SetParameterValue("pardate", ThisDateTempVar)
        rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))

        rpt.SetParameterValue("parno", ThisTxtRef)

        rpt.SetParameterValue("parincash", 0)
        rpt.SetParameterValue("parincheck", 0)
        rpt.SetParameterValue("parincheckno", "")
        rpt.SetParameterValue("parincrcard", 0)
        rpt.SetParameterValue("parincctype", "")
        rpt.SetParameterValue("parinauthcode", "")
        rpt.SetParameterValue("parinonacount", 0)
        rpt.SetParameterValue("parinterms", "")
        rpt.SetParameterValue("parinduedate", "")

        DAGL_payment_deposit.SelectCommand.Parameters("@id_service_center").Value = ThisTxtRef
        DsFrmCashier1.GL_payment_deposit.Clear()
        DAGL_payment_deposit.Fill(DsFrmCashier1, "GL_payment_deposit")
        If DsFrmCashier1.GL_payment_deposit.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DsFrmCashier1.GL_payment_deposit.Rows.Count - 1
                Select Case DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_type") & ""
                    Case "1" 'cash
                        rpt.SetParameterValue("parincash", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cash_rendered") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cash_rendered")))
                    Case "2" 'check

                        rpt.SetParameterValue("parincheck", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")))
                        rpt.SetParameterValue("parincheckno", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("check_no") & "")
                    Case "3" 'credit
                        rpt.SetParameterValue("parincrcard", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")))
                        rpt.SetParameterValue("parincctype", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_type") & "") ''''''''''''
                        rpt.SetParameterValue("parinauthcode", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_auth_no") & "")
                    Case "4" 'AR
                        rpt.SetParameterValue("parinonacount", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") & "")

                        Try
                            rpt.SetParameterValue("parinterms", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_terms") & "")   '''''''''''''
                        Catch ex As Exception
                            rpt.SetParameterValue("parinterms", "")  '''''''''''''
                        End Try


                        'rpt.SetParameterValue("parinterms", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_terms") & "")  '''''''''''''
                        rpt.SetParameterValue("parinduedate", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_due_date") & "")
                End Select
            Next
        End If

        Select Case ServiceCenterType
            Case "WO"
                rpt.SetParameterValue("parnoh", "WORK ORDER NO")
                rpt.SetParameterValue("ParKindRep", "WORK ORDER")
                rpt.SetParameterValue("ParwkStnod", FindEstimateNo(ThisTxtRef))
                rpt.SetParameterValue("parcomments", CommentButton_House.ZCommentText)
            Case "ES"
                rpt.SetParameterValue("parnoh", "ESTIMATE NO")
                rpt.SetParameterValue("ParwkStnod", "")
                rpt.SetParameterValue("parcomments", "")
                rpt.SetParameterValue("ParKindRep", "ESTIMATE")
            Case "IN"
                rpt.SetParameterValue("parnoh", "INVOICE NO")
                rpt.SetParameterValue("ParwkStnod", FindEstimateNo(ThisTxtRef))
                Try
                    rpt.SetParameterValue("parcomments", CommentButton_Customer.ZCommentText)
                Catch ex As Exception
                    rpt.SetParameterValue("parcomments", "")
                End Try
                rpt.SetParameterValue("ParKindRep", "INVOICE")
            Case "RT"
                rpt.SetParameterValue("parnoh", "RETURN NO")

                Try
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "Select amount From GL_Paid_received where tran_type='3' AND id_service_center=" & Qt(TxtRef.Text)
                    rpt.SetParameterValue("ParwkStnod", Math.Round(CmdGeneral.ExecuteScalar, 2))
                Catch ex As Exception
                    rpt.SetParameterValue("ParwkStnod", 0)
                End Try

                Try
                    rpt.SetParameterValue("parcomments", CommentButton_Customer.ZCommentText)
                Catch ex As Exception
                    rpt.SetParameterValue("parcomments", "")
                End Try
                rpt.SetParameterValue("ParKindRep", "CUSTOMER RETURN")
        End Select
        'Dim margins As PageMargins

        '' Get the PageMargins structure and set the 
        '' margins for the report.
        'margins = Report.PrintOptions.PageMargins

        'margins.bottomMargin = 350
        'margins.leftMargin = 350
        'margins.rightMargin = 350
        'margins.topMargin = 350


        rpt.SetDataSource(DsFrmWorkOrders1)

        rpt.SetParameterValue("CustomerSigniture", "")
        Select Case ServiceCenterType
            Case "ES"
                rpt.SetParameterValue("ParaLblHead1", "")
                rpt.SetParameterValue("ParaLblHead2", "")
                rpt.SetParameterValue("ParaLblHead3", "")
                rpt.SetParameterValue("Parwkponumberd", "")
                rpt.SetParameterValue("Parwkstatusd", "")
                '''''rpt.SetParameterValue("CustomerSigniture", OleDbReaderForStore.Item("WARRANTY_FOR_ES") & "")
            Case "WO"
                rpt.SetParameterValue("ParaLblHead1", "ESTIMATE NO")
                rpt.SetParameterValue("ParaLblHead2", "DOWN PAYMENT")
                rpt.SetParameterValue("ParaLblHead3", "PO NUMBER")
                rpt.SetParameterValue("Parwkponumberd", TxtPo_No.Text)

                Dim DownPaymentTempVar As Decimal = 0
                Try
                    CmdGeneral.CommandText = "Select amount from GL_Paid_received where tran_type='4' AND id_service_center=" & Qt(TxtRef.Text)
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    DownPaymentTempVar = Math.Round(CmdGeneral.ExecuteScalar, 2)
                Catch ex As Exception
                    DownPaymentTempVar = 0
                End Try
                rpt.SetParameterValue("Parwkstatusd", Str(DownPaymentTempVar).Trim)
                '''''rpt.SetParameterValue("CustomerSigniture", OleDbReaderForStore.Item("DISCLAIMER_FOR_WO") & "")
            Case "IN"
                rpt.SetParameterValue("ParaLblHead1", "ESTIMATE NO")
                rpt.SetParameterValue("ParaLblHead2", "WORK ORDER NO")
                rpt.SetParameterValue("ParaLblHead3", "PO NUMBER")
                rpt.SetParameterValue("Parwkponumberd", TxtPo_No.Text)
                rpt.SetParameterValue("Parwkstatusd", FindWorkOrderNo(ThisTxtRef))
                ''''rpt.SetParameterValue("CustomerSigniture", OleDbReaderForStore.Item("WARRANTY_FOR_IN") & "")
            Case "RT"
                rpt.SetParameterValue("ParaLblHead1", "CASH REFUND")
                rpt.SetParameterValue("ParaLblHead2", "C.C. CREDIT")
                rpt.SetParameterValue("ParaLblHead3", "AR CREDIT")
                Dim AR_CreditTempVar As Decimal = 0
                Try
                    CmdGeneral.CommandText = "SELECT  payment_amount  FROM   GL_payment_deposit WHERE  (refer_type = '1') AND (payment_type = '4') and id_service_center =" & Qt(InvoiceNoForReturnVar)
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    AR_CreditTempVar = Math.Round(CmdGeneral.ExecuteScalar, 2)
                Catch ex As Exception
                    AR_CreditTempVar = 0
                End Try

                rpt.SetParameterValue("Parwkponumberd", AR_CreditTempVar)
                rpt.SetParameterValue("Parwkstatusd", "")
                rpt.SetParameterValue("CustomerSigniture", "")
        End Select

        Try
            Select Case PrintType.ToUpper
                Case "print".ToUpper
                    Select Case ServiceCenterType
                        Case "ES"
                            rpt.SetParameterValue("paroriginal", "")
                            rpt.SetParameterValue("parcopylabel", "")
                            If OnePrintFlag Then
                                rpt.PrintToPrinter(1, True, 0, 0)
                            Else
                                rpt.PrintToPrinter(OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_ES"), True, 0, 0)
                            End If
                        Case "WO"
                            rpt.SetParameterValue("paroriginal", "")
                            rpt.SetParameterValue("parcopylabel", "")
                            If OnePrintFlag Then
                                rpt.PrintToPrinter(1, True, 0, 0)
                            Else
                                rpt.PrintToPrinter(OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_WO"), True, 0, 0)
                            End If
                        Case "IN"
                            If FirstPrint Then
                                rpt.SetParameterValue("paroriginal", "ORIGINAL")
                            Else
                                rpt.SetParameterValue("paroriginal", "REPRINT")
                            End If
                            rpt.SetParameterValue("parcopylabel", OleDbReaderForStore.Item("LABEL_INVOICE_COPY1"))
                            rpt.PrintToPrinter(1, True, 0, 0)
                            If Not OnePrintFlag Then
                                If OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_IN") > 1 Then
                                    rpt.SetParameterValue("parcopylabel", OleDbReaderForStore.Item("LABEL_INVOICE_COPY2"))
                                    rpt.PrintToPrinter(1, True, 0, 0)
                                End If
                                If OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_IN") > 2 Then
                                    rpt.SetParameterValue("parcopylabel", OleDbReaderForStore.Item("LABEL_INVOICE_COPY3"))
                                    rpt.PrintToPrinter(1, True, 0, 0)
                                End If
                            End If
                        Case "RT"
                            rpt.SetParameterValue("paroriginal", "")
                            rpt.SetParameterValue("parcopylabel", "")
                            rpt.PrintToPrinter(1, True, 0, 0)
                    End Select
                Case "preview".ToUpper
                    rpt.SetParameterValue("paroriginal", "")
                    rpt.SetParameterValue("parcopylabel", "")
                    prn.CrViewer.ReportSource = rpt
                    prn.Show()
                Case "Fax".ToUpper
                    Try
                        rpt.PrintOptions.PrinterName = "Fax"
                        rpt.PrintToPrinter(1, True, 0, 0)
                    Catch ex As Exception
                        MsgBox("Add The FAX in (Printers and Faxes)")
                    End Try
                Case "Email".ToUpper
                    rpt.SetParameterValue("paroriginal", "")
                    rpt.SetParameterValue("parcopylabel", "")
                    rpt.ExportToDisk(CrystalDecisions.[Shared].ExportFormatType.WordForWindows, emailPath & "Invoice" & TxtRef.Text.Trim & ".Doc")
            End Select
        Catch ex As Exception
        End Try

    End Sub
    Private Function FindEstimateNo(ByVal ThisId_service_center As String) As String
        FindEstimateNo = ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim FindId_service_center As String = ThisId_service_center
        Do While True
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(FindId_service_center)
            Try
                FindId_service_center = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                FindId_service_center = ""
            End Try
            If Mid(FindId_service_center, 1, 2) = "ES" Or FindId_service_center = "" Then
                FindEstimateNo = FindId_service_center
                Exit Do
            End If
        Loop
    End Function
    Private Function FindWorkOrderNo(ByVal ThisId_service_center As String) As String
        FindWorkOrderNo = ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim FindId_service_center As String = ThisId_service_center
        Do While True
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(FindId_service_center)
            Try
                FindId_service_center = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                FindId_service_center = ""
            End Try
            If Mid(FindId_service_center, 1, 2) = "WO" Or FindId_service_center = "" Then
                FindWorkOrderNo = FindId_service_center
                Exit Do
            End If
        Loop
    End Function
    Private Function FindInvoiceNo(ByVal ThisId_service_center As String) As String
        FindInvoiceNo = ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim FindId_service_center As String = ThisId_service_center
        Do While True
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(FindId_service_center)
            Try
                FindId_service_center = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                FindId_service_center = ""
            End Try
            If Mid(FindId_service_center, 1, 2) = "IN" Or FindId_service_center = "" Then
                FindInvoiceNo = FindId_service_center
                Exit Do
            End If
        Loop
    End Function
    Private Sub MenuItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDelete.Click
        If BtnNew.Enabled = False Then
            Dim CurrentRowGrid As Long = GrdDetail.Row
            Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
            Dim i As Integer
            Dim NewRowRadif As Integer = ThisRowGrid.Cells("Radif").Value
            Dim foundRow As DataRow
            foundRow = DsFrmWorkOrders1.service_center_dtl.FindByradif(NewRowRadif)
            Try
                DsFrmWorkOrders1.service_out_purchases.FindByradif(NewRowRadif).Delete()
            Catch ex As Exception
            End Try
            Try
                DsFrmWorkOrders1.service_tire_adjustment.FindByradif(NewRowRadif).Delete()
            Catch ex As Exception
            End Try
            If Not (foundRow Is Nothing) Then
                foundRow.Item("Radif") = MaxRowNo + 1
                ''If Not (foundRow Is Nothing) Then
                foundRow.Item("type_select") = ""
                foundRow.Item("cod_select") = ""
                foundRow.Item("qty") = 0
                foundRow.Item("desc_radif") = ""
                foundRow.Item("price") = 0
                '''''''''foundRow.Item("Ext_Price") = 0
                foundRow.Item("fet") = 0
                foundRow.Item("taxable") = 1
                foundRow.Item("cod_technician") = ""
                foundRow.Item("FlagIsPackage") = 1
                ''End If
            End If
            DsFrmWorkOrders1.service_center_dtl.AcceptChanges()
            Try
                For i = NewRowRadif + 1 To MaxRowNo
                    foundRow = DsFrmWorkOrders1.service_center_dtl.FindByradif(i)
                    If Not (foundRow Is Nothing) Then
                        foundRow.Item("Radif") = foundRow.Item("Radif") - 1
                        Try
                            Select Case foundRow.Item("type_select")
                                Case "O"
                                    Dim service_out_purchasesFoundRow As DataRow
                                    service_out_purchasesFoundRow = DsFrmWorkOrders1.service_out_purchases.FindByradif(i)
                                    If Not (service_out_purchasesFoundRow Is Nothing) Then
                                        service_out_purchasesFoundRow.Item("Radif") = service_out_purchasesFoundRow.Item("Radif") - 1
                                    End If
                                Case "A"
                                    Dim service_tire_adjustmentFoundRow As DataRow
                                    service_tire_adjustmentFoundRow = DsFrmWorkOrders1.service_tire_adjustment.FindByradif(i)
                                    If Not (service_tire_adjustmentFoundRow Is Nothing) Then
                                        service_tire_adjustmentFoundRow.Item("Radif") = service_tire_adjustmentFoundRow.Item("Radif") - 1
                                    End If
                            End Select
                        Catch ex As Exception
                        End Try
                    End If
                Next
            Catch ex As Exception
                MsgBox("Try Again")
                Exit Sub
            End Try
            Try
                foundRow = DsFrmWorkOrders1.service_center_dtl.FindByradif(MaxRowNo + 1)
                If Not (foundRow Is Nothing) Then
                    foundRow.Item("Radif") = MaxRowNo
                End If
            Catch ex As Exception
                MsgBox("Can not Add a Record,please try later")
            End Try

            Call CalcSumOfExt_price()
            Call SelectRow(CurrentRowGrid)

        End If
    End Sub
    Private Sub MenuItemInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInsert.Click
        If BtnNew.Enabled = False Then
            Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
            Dim i As Integer
            Dim NewRowRadif As Integer = ThisRowGrid.Cells("Radif").Value
            Dim foundRow As DataRow
            Try
                For i = MaxRowNo To NewRowRadif Step -1
                    foundRow = DsFrmWorkOrders1.service_center_dtl.FindByradif(i)
                    If Not (foundRow Is Nothing) Then
                        foundRow.Item("Radif") = foundRow.Item("Radif") + 1
                        Select Case foundRow.Item("type_select")
                            Case "O"
                                Dim service_out_purchasesFoundRow As DataRow
                                service_out_purchasesFoundRow = DsFrmWorkOrders1.service_out_purchases.FindByradif(i)
                                If Not (service_out_purchasesFoundRow Is Nothing) Then
                                    service_out_purchasesFoundRow.Item("Radif") = service_out_purchasesFoundRow.Item("Radif") + 1
                                End If
                            Case "A"
                                Dim service_tire_adjustmentFoundRow As DataRow
                                service_tire_adjustmentFoundRow = DsFrmWorkOrders1.service_tire_adjustment.FindByradif(i)
                                If Not (service_tire_adjustmentFoundRow Is Nothing) Then
                                    service_tire_adjustmentFoundRow.Item("Radif") = service_tire_adjustmentFoundRow.Item("Radif") + 1
                                End If
                        End Select
                    End If
                Next
            Catch ex As Exception
            End Try
            Try
                Call AddEmptyRecordToDetail(TxtRef.Text, NewRowRadif)
                MaxRowNo = MaxRowNo + 1
            Catch ex As Exception
                MsgBox("Can not Add a Record,please try later")
            End Try
        End If
    End Sub
    Private Sub CalcTax()
        Try
            Dim CalcTaxTax_AmountVar As Decimal
            If CustomerCod1.CustomerCod.Trim.Length = 0 Then
                CalcTaxTax_AmountVar = DefaultTax_AmountVar
            Else
                CalcTaxTax_AmountVar = CustomerCod1.Tax_Amount
            End If
            NumTax.Text = Math.Round((Math.Round(DsFrmWorkOrders1.service_center_dtl.Compute("Sum(Ext_Price)", "taxable=1"), 2) * CalcTaxTax_AmountVar) / 100, 2)
        Catch ex As Exception
            NumTax.Text = 0
        End Try
        If LblTotal.Numbervalue = 0 Then
            NumTax.Text = 0
        End If
        '''''''''''NumTax.Text = Math.Round((LblSubtotal.Text * CustomerCod1.Tax_Amount) / 100, 2)
    End Sub
    Private Sub NumDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumDiscount.TextChanged, LblSubtotal.TextChanged, NumTax.TextChanged
        LblTotal.Text = Math.Round(LblSubtotal.Text - ((LblSubtotal.Text * NumDiscount.Text) / 100) + NumTax.Text, 2)
    End Sub
    Private Sub TxtPo_No_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPo_No.GotFocus
        TxtPo_No.SelectionStart = 0
        TxtPo_No.SelectionLength = TxtPo_No.MaxLength
    End Sub
    Private Sub CustomerCod1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerCod1.Leave
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT  count(*) FROM ser_tr_vehicle where id_vehicle=" & Qt(License_No1.FieldCodValue) & " AND cod_customer=" & Qt(CustomerCod1.CustomerCod)
        If CmdGeneral.ExecuteScalar() = 0 Then
            License_No1.FieldCodValue = 0
        End If
        If CustomerCod1.CreditHold Then
            MsgBox("Customer is on Credit Hold" & vbCrLf & "No Charge is allowed", MsgBoxStyle.OKOnly)
        End If
    End Sub
End Class
