Imports CommonClass
Public Class FrmVehicle
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim VehicleOrderFieldName As String = "license_no_vehicle"
    Dim VehicleOrderFieldName2 = "id_vehicle"
    Friend LicenseNoTempVar As Decimal = 0
    Dim PnlSearchHeight As Integer
    Dim MyFrmItemComments As CommonClass.FrmItemComments
    Public VehicleNoteVar As String
    Dim MyFrmEngineScreen As New FrmEngineScreen
    Dim TxtCod_vehicleVar As String = ""
    Public LicenceNoForQuickAdd As String = ""
    Public QuickAddFlag As Boolean = False
    Public CustomerNoForQuickAdd As String = ""
    Public Id_VehicleForShow As Decimal = 0
    Dim WithEvents MyFrmSearchLicenseNo As New UCVehicle.FrmSearchLicenseNo
    Dim WithEvents MyFrmChangeServiceRecords As FrmChangeServiceRecords
    Dim WithEvents MyFrmChangeServiceRecords2 As FrmChangeServiceRecords2
    Dim WithEvents MyFrmVehicle2 As FrmVehicle
    Public ExitAfterSaveOrCancel As Boolean = False
    Public Event AfterLoad()
    Public Event AfterSave(ByVal Idload)
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
    Friend WithEvents DAbas_vehicle_company As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmVehicle1 As UCVehicle.DSFrmVehicle
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents BtnNotes As System.Windows.Forms.Button
    Friend WithEvents BtnChange As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents DAbas_color As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_tab_oil_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_tab_kind_engine As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAbas_zipcode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_tab_vehicle_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_tab_quarts As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbState As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_color As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_make As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVin As System.Windows.Forms.TextBox
    Friend WithEvents Cmbquarts As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_oil_type As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_vehicle_type As System.Windows.Forms.ComboBox
    Friend WithEvents NumYear As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Cmbcod_kind_engine As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_model As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAverageMileage As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartingMileage As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreviousMileage As System.Windows.Forms.TextBox
    Friend WithEvents TxtCurrentMileage As System.Windows.Forms.TextBox
    Friend WithEvents ChkVehicleOutOfService As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents TxtSalvagedDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtChangeDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtCreatedDate As System.Windows.Forms.TextBox
    Friend WithEvents Lable25 As System.Windows.Forms.Label
    Friend WithEvents TxtBrakeMileage As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlignmentMileage As System.Windows.Forms.TextBox
    Friend WithEvents TxtRotationMileage As System.Windows.Forms.TextBox
    Friend WithEvents TxtOilChangeMileage As System.Windows.Forms.TextBox
    Friend WithEvents CHKCustomerNew As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKVehicleNew As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKLicenseNew As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKVehicleSame As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKCustomerSame As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CHKLicenseSame As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents TXTLicenseNo As System.Windows.Forms.TextBox
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort32 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort33 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort34 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort35 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort36 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort37 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents BtnSortOrder As Janus.Windows.EditControls.UIButton
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents DAbas_vehicle_model As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnEngine As System.Windows.Forms.Button
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents DteCurrentDate As CalendarCombo.CalendarCombo
    Friend WithEvents DtePreviousDate As CalendarCombo.CalendarCombo
    Friend WithEvents DteAverageDate As CalendarCombo.CalendarCombo
    Friend WithEvents DteOilChangeDate As CalendarCombo.CalendarCombo
    Friend WithEvents DteRotationDate As CalendarCombo.CalendarCombo
    Friend WithEvents DteAlignmentDate As CalendarCombo.CalendarCombo
    Friend WithEvents DteBrakeDate As CalendarCombo.CalendarCombo
    Friend WithEvents DteStartingDate As CalendarCombo.CalendarCombo
    Friend WithEvents License_No1 As UCVehicle.License_No
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents TxtUnitNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddMake As System.Windows.Forms.Button
    Friend WithEvents BtnAddModel As System.Windows.Forms.Button
    Friend WithEvents BtnAddEngine As System.Windows.Forms.Button
    Friend WithEvents BtnAddColor As System.Windows.Forms.Button
    Friend WithEvents DataViewForModel As System.Data.DataView
    Friend WithEvents LblSold As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVehicle))
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
        Me.LblSold = New System.Windows.Forms.Label
        Me.License_No1 = New UCVehicle.License_No
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.BtnAddColor = New System.Windows.Forms.Button
        Me.BtnAddEngine = New System.Windows.Forms.Button
        Me.BtnAddModel = New System.Windows.Forms.Button
        Me.BtnAddMake = New System.Windows.Forms.Button
        Me.TxtUnitNo = New System.Windows.Forms.TextBox
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.BtnEngine = New System.Windows.Forms.Button
        Me.Cmbcod_color = New System.Windows.Forms.ComboBox
        Me.DsFrmVehicle1 = New UCVehicle.DSFrmVehicle
        Me.Cmbcod_make = New System.Windows.Forms.ComboBox
        Me.TxtVin = New System.Windows.Forms.TextBox
        Me.Cmbquarts = New System.Windows.Forms.ComboBox
        Me.Cmbcod_oil_type = New System.Windows.Forms.ComboBox
        Me.Cmbcod_vehicle_type = New System.Windows.Forms.ComboBox
        Me.CmbState = New System.Windows.Forms.ComboBox
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DteBrakeDate = New CalendarCombo.CalendarCombo
        Me.DteAlignmentDate = New CalendarCombo.CalendarCombo
        Me.DteRotationDate = New CalendarCombo.CalendarCombo
        Me.DteOilChangeDate = New CalendarCombo.CalendarCombo
        Me.DteAverageDate = New CalendarCombo.CalendarCombo
        Me.DteStartingDate = New CalendarCombo.CalendarCombo
        Me.DtePreviousDate = New CalendarCombo.CalendarCombo
        Me.DteCurrentDate = New CalendarCombo.CalendarCombo
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.BtnChange = New System.Windows.Forms.Button
        Me.BtnNotes = New System.Windows.Forms.Button
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ChkVehicleOutOfService = New Janus.Windows.EditControls.UICheckBox
        Me.TxtSalvagedDate = New System.Windows.Forms.TextBox
        Me.TxtChangeDate = New System.Windows.Forms.TextBox
        Me.TxtCreatedDate = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Lable25 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.TxtBrakeMileage = New System.Windows.Forms.TextBox
        Me.TxtAlignmentMileage = New System.Windows.Forms.TextBox
        Me.TxtRotationMileage = New System.Windows.Forms.TextBox
        Me.TxtOilChangeMileage = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.TxtAverageMileage = New System.Windows.Forms.TextBox
        Me.TxtStartingMileage = New System.Windows.Forms.TextBox
        Me.TxtPreviousMileage = New System.Windows.Forms.TextBox
        Me.TxtCurrentMileage = New System.Windows.Forms.TextBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.CHKCustomerNew = New Janus.Windows.EditControls.UICheckBox
        Me.CHKVehicleNew = New Janus.Windows.EditControls.UICheckBox
        Me.CHKLicenseNew = New Janus.Windows.EditControls.UICheckBox
        Me.CHKVehicleSame = New Janus.Windows.EditControls.UICheckBox
        Me.CHKCustomerSame = New Janus.Windows.EditControls.UICheckBox
        Me.CHKLicenseSame = New Janus.Windows.EditControls.UICheckBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.NumYear = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Cmbcod_kind_engine = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXTLicenseNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cmbcod_model = New System.Windows.Forms.ComboBox
        Me.DataViewForModel = New System.Data.DataView
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DAbas_vehicle_company = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
        Me.UiContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort1 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort2 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort36 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort11 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort21 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort37 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Label44 = New System.Windows.Forms.Label
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
        Me.DAbas_color = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_oil_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_kind_engine = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_zipcode = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_vehicle_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_quarts = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort31 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort32 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort33 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort34 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.Sort35 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.DAbas_vehicle_model = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        CType(Me.DsFrmVehicle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataViewForModel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CmdDelete.CommandText = "DELETE FROM ser_tr_vehicle WHERE (id_vehicle = @id_vehicle)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=SA;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_01"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.LblSold)
        Me.PnlSearch.Controls.Add(Me.License_No1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(646, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'LblSold
        '
        Me.LblSold.BackColor = System.Drawing.Color.Transparent
        Me.LblSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSold.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.LblSold.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSold.Location = New System.Drawing.Point(390, 2)
        Me.LblSold.Name = "LblSold"
        Me.LblSold.Size = New System.Drawing.Size(117, 19)
        Me.LblSold.TabIndex = 328
        Me.LblSold.Text = "Sold"
        Me.LblSold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblSold.Visible = False
        '
        'License_No1
        '
        Me.License_No1.Cnn = Me.Cnn
        Me.License_No1.FieldCodValue = CType(0, Long)
        Me.License_No1.LicenseNoLen = 20
        Me.License_No1.Location = New System.Drawing.Point(70, 1)
        Me.License_No1.Name = "License_No1"
        Me.License_No1.Size = New System.Drawing.Size(146, 20)
        Me.License_No1.TabIndex = 0
        Me.License_No1.TxtBackColor = System.Drawing.Color.YellowGreen
        Me.License_No1.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.License_No1.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(8, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "License No."
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=SA;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_01"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.BtnAddColor)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnAddEngine)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnAddModel)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnAddMake)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtUnitNo)
        Me.PnlKartAmvalField.Controls.Add(Me.CustomerCod1)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnEngine)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbcod_color)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbcod_make)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtVin)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbquarts)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbcod_oil_type)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbcod_vehicle_type)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbState)
        Me.PnlKartAmvalField.Controls.Add(Me.LblCustomerName)
        Me.PnlKartAmvalField.Controls.Add(Me.Label36)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel2)
        Me.PnlKartAmvalField.Controls.Add(Me.NumYear)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbcod_kind_engine)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Controls.Add(Me.Label12)
        Me.PnlKartAmvalField.Controls.Add(Me.Label13)
        Me.PnlKartAmvalField.Controls.Add(Me.Label10)
        Me.PnlKartAmvalField.Controls.Add(Me.Label9)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Controls.Add(Me.TXTLicenseNo)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbcod_model)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(646, 282)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'BtnAddColor
        '
        Me.BtnAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddColor.Image = CType(resources.GetObject("BtnAddColor.Image"), System.Drawing.Image)
        Me.BtnAddColor.Location = New System.Drawing.Point(12, 131)
        Me.BtnAddColor.Name = "BtnAddColor"
        Me.BtnAddColor.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddColor.TabIndex = 448
        '
        'BtnAddEngine
        '
        Me.BtnAddEngine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddEngine.Image = CType(resources.GetObject("BtnAddEngine.Image"), System.Drawing.Image)
        Me.BtnAddEngine.Location = New System.Drawing.Point(12, 107)
        Me.BtnAddEngine.Name = "BtnAddEngine"
        Me.BtnAddEngine.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddEngine.TabIndex = 447
        '
        'BtnAddModel
        '
        Me.BtnAddModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddModel.Image = CType(resources.GetObject("BtnAddModel.Image"), System.Drawing.Image)
        Me.BtnAddModel.Location = New System.Drawing.Point(12, 83)
        Me.BtnAddModel.Name = "BtnAddModel"
        Me.BtnAddModel.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddModel.TabIndex = 446
        '
        'BtnAddMake
        '
        Me.BtnAddMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddMake.Image = CType(resources.GetObject("BtnAddMake.Image"), System.Drawing.Image)
        Me.BtnAddMake.Location = New System.Drawing.Point(12, 59)
        Me.BtnAddMake.Name = "BtnAddMake"
        Me.BtnAddMake.Size = New System.Drawing.Size(24, 21)
        Me.BtnAddMake.TabIndex = 445
        '
        'TxtUnitNo
        '
        Me.TxtUnitNo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUnitNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtUnitNo.Location = New System.Drawing.Point(79, 181)
        Me.TxtUnitNo.MaxLength = 10
        Me.TxtUnitNo.Name = "TxtUnitNo"
        Me.TxtUnitNo.Size = New System.Drawing.Size(120, 20)
        Me.TxtUnitNo.TabIndex = 9
        Me.TxtUnitNo.Text = ""
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CustomerCod1.Location = New System.Drawing.Point(316, 6)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(128, 21)
        Me.CustomerCod1.TabIndex = 2
        '
        'BtnEngine
        '
        Me.BtnEngine.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEngine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnEngine.Image = CType(resources.GetObject("BtnEngine.Image"), System.Drawing.Image)
        Me.BtnEngine.Location = New System.Drawing.Point(227, 108)
        Me.BtnEngine.Name = "BtnEngine"
        Me.BtnEngine.Size = New System.Drawing.Size(23, 19)
        Me.BtnEngine.TabIndex = 444
        Me.BtnEngine.TabStop = False
        '
        'Cmbcod_color
        '
        Me.Cmbcod_color.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_color.DataSource = Me.DsFrmVehicle1.bas_color
        Me.Cmbcod_color.DisplayMember = "desc_color"
        Me.Cmbcod_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_color.ItemHeight = 13
        Me.Cmbcod_color.Location = New System.Drawing.Point(78, 134)
        Me.Cmbcod_color.Name = "Cmbcod_color"
        Me.Cmbcod_color.Size = New System.Drawing.Size(142, 21)
        Me.Cmbcod_color.TabIndex = 7
        Me.Cmbcod_color.ValueMember = "cod_color"
        '
        'DsFrmVehicle1
        '
        Me.DsFrmVehicle1.DataSetName = "DSFrmVehicle"
        Me.DsFrmVehicle1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cmbcod_make
        '
        Me.Cmbcod_make.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_make.DataSource = Me.DsFrmVehicle1.bas_vehicle_company
        Me.Cmbcod_make.DisplayMember = "desc_make"
        Me.Cmbcod_make.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_make.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_make.ItemHeight = 13
        Me.Cmbcod_make.Location = New System.Drawing.Point(78, 59)
        Me.Cmbcod_make.Name = "Cmbcod_make"
        Me.Cmbcod_make.Size = New System.Drawing.Size(150, 21)
        Me.Cmbcod_make.TabIndex = 4
        Me.Cmbcod_make.ValueMember = "cod_make"
        '
        'TxtVin
        '
        Me.TxtVin.BackColor = System.Drawing.SystemColors.Window
        Me.TxtVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtVin.Location = New System.Drawing.Point(78, 156)
        Me.TxtVin.MaxLength = 17
        Me.TxtVin.Name = "TxtVin"
        Me.TxtVin.Size = New System.Drawing.Size(165, 20)
        Me.TxtVin.TabIndex = 8
        Me.TxtVin.Text = ""
        '
        'Cmbquarts
        '
        Me.Cmbquarts.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbquarts.DataSource = Me.DsFrmVehicle1.inv_tab_quarts
        Me.Cmbquarts.DisplayMember = "desc_quarts"
        Me.Cmbquarts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbquarts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbquarts.ItemHeight = 13
        Me.Cmbquarts.Location = New System.Drawing.Point(78, 258)
        Me.Cmbquarts.Name = "Cmbquarts"
        Me.Cmbquarts.Size = New System.Drawing.Size(105, 21)
        Me.Cmbquarts.TabIndex = 12
        Me.Cmbquarts.ValueMember = "Cod_quarts"
        '
        'Cmbcod_oil_type
        '
        Me.Cmbcod_oil_type.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_oil_type.DataSource = Me.DsFrmVehicle1.inv_tab_oil_type
        Me.Cmbcod_oil_type.DisplayMember = "desc_oil_type"
        Me.Cmbcod_oil_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_oil_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_oil_type.ItemHeight = 13
        Me.Cmbcod_oil_type.Location = New System.Drawing.Point(78, 233)
        Me.Cmbcod_oil_type.Name = "Cmbcod_oil_type"
        Me.Cmbcod_oil_type.Size = New System.Drawing.Size(105, 21)
        Me.Cmbcod_oil_type.TabIndex = 11
        Me.Cmbcod_oil_type.ValueMember = "cod_oil_type"
        '
        'Cmbcod_vehicle_type
        '
        Me.Cmbcod_vehicle_type.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_vehicle_type.DataSource = Me.DsFrmVehicle1.inv_tab_vehicle_type
        Me.Cmbcod_vehicle_type.DisplayMember = "desc_vehicle_type"
        Me.Cmbcod_vehicle_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_vehicle_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_vehicle_type.ItemHeight = 13
        Me.Cmbcod_vehicle_type.Location = New System.Drawing.Point(78, 207)
        Me.Cmbcod_vehicle_type.Name = "Cmbcod_vehicle_type"
        Me.Cmbcod_vehicle_type.Size = New System.Drawing.Size(128, 21)
        Me.Cmbcod_vehicle_type.TabIndex = 10
        Me.Cmbcod_vehicle_type.ValueMember = "cod_vehicle_type"
        '
        'CmbState
        '
        Me.CmbState.BackColor = System.Drawing.SystemColors.Window
        Me.CmbState.DataSource = Me.DsFrmVehicle1.bas_zipcode
        Me.CmbState.DisplayMember = "state"
        Me.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbState.ItemHeight = 13
        Me.CmbState.Location = New System.Drawing.Point(218, 5)
        Me.CmbState.Name = "CmbState"
        Me.CmbState.Size = New System.Drawing.Size(47, 21)
        Me.CmbState.TabIndex = 1
        Me.CmbState.ValueMember = "state"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.LblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCustomerName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCustomerName.Location = New System.Drawing.Point(445, 6)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(201, 19)
        Me.LblCustomerName.TabIndex = 327
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(261, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 14)
        Me.Label36.TabIndex = 326
        Me.Label36.Text = "Customer"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DteBrakeDate)
        Me.Panel2.Controls.Add(Me.DteAlignmentDate)
        Me.Panel2.Controls.Add(Me.DteRotationDate)
        Me.Panel2.Controls.Add(Me.DteOilChangeDate)
        Me.Panel2.Controls.Add(Me.DteAverageDate)
        Me.Panel2.Controls.Add(Me.DteStartingDate)
        Me.Panel2.Controls.Add(Me.DtePreviousDate)
        Me.Panel2.Controls.Add(Me.DteCurrentDate)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.BtnChange)
        Me.Panel2.Controls.Add(Me.BtnNotes)
        Me.Panel2.Controls.Add(Me.BtnHistory)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.ChkVehicleOutOfService)
        Me.Panel2.Controls.Add(Me.TxtSalvagedDate)
        Me.Panel2.Controls.Add(Me.TxtChangeDate)
        Me.Panel2.Controls.Add(Me.TxtCreatedDate)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.Lable25)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.TxtBrakeMileage)
        Me.Panel2.Controls.Add(Me.TxtAlignmentMileage)
        Me.Panel2.Controls.Add(Me.TxtRotationMileage)
        Me.Panel2.Controls.Add(Me.TxtOilChangeMileage)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.TxtAverageMileage)
        Me.Panel2.Controls.Add(Me.TxtStartingMileage)
        Me.Panel2.Controls.Add(Me.TxtPreviousMileage)
        Me.Panel2.Controls.Add(Me.TxtCurrentMileage)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.CHKCustomerNew)
        Me.Panel2.Controls.Add(Me.CHKVehicleNew)
        Me.Panel2.Controls.Add(Me.CHKLicenseNew)
        Me.Panel2.Controls.Add(Me.CHKVehicleSame)
        Me.Panel2.Controls.Add(Me.CHKCustomerSame)
        Me.Panel2.Controls.Add(Me.CHKLicenseSame)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(254, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 254)
        Me.Panel2.TabIndex = 13
        '
        'DteBrakeDate
        '
        Me.DteBrakeDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DteBrakeDate.BorderColor = System.Drawing.Color.Empty
        Me.DteBrakeDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteBrakeDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteBrakeDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteBrakeDate.EditableSal = True
        Me.DteBrakeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteBrakeDate.Image = CType(resources.GetObject("DteBrakeDate.Image"), System.Drawing.Image)
        Me.DteBrakeDate.Location = New System.Drawing.Point(157, 229)
        Me.DteBrakeDate.MaxValue = CType(2500, Short)
        Me.DteBrakeDate.MinValue = CType(1800, Short)
        Me.DteBrakeDate.Name = "DteBrakeDate"
        Me.DteBrakeDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteBrakeDate.Sal_Mali = Nothing
        Me.DteBrakeDate.ShowButton = True
        Me.DteBrakeDate.Size = New System.Drawing.Size(104, 23)
        Me.DteBrakeDate.TabIndex = 463
        Me.DteBrakeDate.VisualStyle = False
        '
        'DteAlignmentDate
        '
        Me.DteAlignmentDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DteAlignmentDate.BorderColor = System.Drawing.Color.Empty
        Me.DteAlignmentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteAlignmentDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteAlignmentDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteAlignmentDate.EditableSal = True
        Me.DteAlignmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteAlignmentDate.Image = CType(resources.GetObject("DteAlignmentDate.Image"), System.Drawing.Image)
        Me.DteAlignmentDate.Location = New System.Drawing.Point(157, 204)
        Me.DteAlignmentDate.MaxValue = CType(2500, Short)
        Me.DteAlignmentDate.MinValue = CType(1800, Short)
        Me.DteAlignmentDate.Name = "DteAlignmentDate"
        Me.DteAlignmentDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteAlignmentDate.Sal_Mali = Nothing
        Me.DteAlignmentDate.ShowButton = True
        Me.DteAlignmentDate.Size = New System.Drawing.Size(104, 23)
        Me.DteAlignmentDate.TabIndex = 462
        Me.DteAlignmentDate.VisualStyle = False
        '
        'DteRotationDate
        '
        Me.DteRotationDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DteRotationDate.BorderColor = System.Drawing.Color.Empty
        Me.DteRotationDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteRotationDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteRotationDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteRotationDate.EditableSal = True
        Me.DteRotationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteRotationDate.Image = CType(resources.GetObject("DteRotationDate.Image"), System.Drawing.Image)
        Me.DteRotationDate.Location = New System.Drawing.Point(157, 179)
        Me.DteRotationDate.MaxValue = CType(2500, Short)
        Me.DteRotationDate.MinValue = CType(1800, Short)
        Me.DteRotationDate.Name = "DteRotationDate"
        Me.DteRotationDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteRotationDate.Sal_Mali = Nothing
        Me.DteRotationDate.ShowButton = True
        Me.DteRotationDate.Size = New System.Drawing.Size(104, 23)
        Me.DteRotationDate.TabIndex = 461
        Me.DteRotationDate.VisualStyle = False
        '
        'DteOilChangeDate
        '
        Me.DteOilChangeDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DteOilChangeDate.BorderColor = System.Drawing.Color.Empty
        Me.DteOilChangeDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteOilChangeDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteOilChangeDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteOilChangeDate.EditableSal = True
        Me.DteOilChangeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteOilChangeDate.Image = CType(resources.GetObject("DteOilChangeDate.Image"), System.Drawing.Image)
        Me.DteOilChangeDate.Location = New System.Drawing.Point(157, 154)
        Me.DteOilChangeDate.MaxValue = CType(2500, Short)
        Me.DteOilChangeDate.MinValue = CType(1800, Short)
        Me.DteOilChangeDate.Name = "DteOilChangeDate"
        Me.DteOilChangeDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteOilChangeDate.Sal_Mali = Nothing
        Me.DteOilChangeDate.ShowButton = True
        Me.DteOilChangeDate.Size = New System.Drawing.Size(104, 23)
        Me.DteOilChangeDate.TabIndex = 460
        Me.DteOilChangeDate.VisualStyle = False
        '
        'DteAverageDate
        '
        Me.DteAverageDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DteAverageDate.BorderColor = System.Drawing.Color.Empty
        Me.DteAverageDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteAverageDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteAverageDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteAverageDate.EditableSal = True
        Me.DteAverageDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteAverageDate.Image = CType(resources.GetObject("DteAverageDate.Image"), System.Drawing.Image)
        Me.DteAverageDate.Location = New System.Drawing.Point(157, 100)
        Me.DteAverageDate.MaxValue = CType(2500, Short)
        Me.DteAverageDate.MinValue = CType(1800, Short)
        Me.DteAverageDate.Name = "DteAverageDate"
        Me.DteAverageDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteAverageDate.Sal_Mali = Nothing
        Me.DteAverageDate.ShowButton = True
        Me.DteAverageDate.Size = New System.Drawing.Size(104, 23)
        Me.DteAverageDate.TabIndex = 459
        Me.DteAverageDate.VisualStyle = False
        '
        'DteStartingDate
        '
        Me.DteStartingDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DteStartingDate.BorderColor = System.Drawing.Color.Empty
        Me.DteStartingDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteStartingDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteStartingDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteStartingDate.EditableSal = True
        Me.DteStartingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteStartingDate.Image = CType(resources.GetObject("DteStartingDate.Image"), System.Drawing.Image)
        Me.DteStartingDate.Location = New System.Drawing.Point(157, 75)
        Me.DteStartingDate.MaxValue = CType(2500, Short)
        Me.DteStartingDate.MinValue = CType(1800, Short)
        Me.DteStartingDate.Name = "DteStartingDate"
        Me.DteStartingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteStartingDate.Sal_Mali = Nothing
        Me.DteStartingDate.ShowButton = True
        Me.DteStartingDate.Size = New System.Drawing.Size(104, 23)
        Me.DteStartingDate.TabIndex = 458
        Me.DteStartingDate.VisualStyle = False
        '
        'DtePreviousDate
        '
        Me.DtePreviousDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DtePreviousDate.BorderColor = System.Drawing.Color.Empty
        Me.DtePreviousDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtePreviousDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DtePreviousDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DtePreviousDate.EditableSal = True
        Me.DtePreviousDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtePreviousDate.Image = CType(resources.GetObject("DtePreviousDate.Image"), System.Drawing.Image)
        Me.DtePreviousDate.Location = New System.Drawing.Point(157, 50)
        Me.DtePreviousDate.MaxValue = CType(2500, Short)
        Me.DtePreviousDate.MinValue = CType(1800, Short)
        Me.DtePreviousDate.Name = "DtePreviousDate"
        Me.DtePreviousDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DtePreviousDate.Sal_Mali = Nothing
        Me.DtePreviousDate.ShowButton = True
        Me.DtePreviousDate.Size = New System.Drawing.Size(104, 23)
        Me.DtePreviousDate.TabIndex = 457
        Me.DtePreviousDate.VisualStyle = False
        '
        'DteCurrentDate
        '
        Me.DteCurrentDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.DteCurrentDate.BorderColor = System.Drawing.Color.Empty
        Me.DteCurrentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteCurrentDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteCurrentDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteCurrentDate.EditableSal = True
        Me.DteCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteCurrentDate.Image = CType(resources.GetObject("DteCurrentDate.Image"), System.Drawing.Image)
        Me.DteCurrentDate.Location = New System.Drawing.Point(157, 25)
        Me.DteCurrentDate.MaxValue = CType(2500, Short)
        Me.DteCurrentDate.MinValue = CType(1800, Short)
        Me.DteCurrentDate.Name = "DteCurrentDate"
        Me.DteCurrentDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteCurrentDate.Sal_Mali = Nothing
        Me.DteCurrentDate.ShowButton = True
        Me.DteCurrentDate.Size = New System.Drawing.Size(104, 23)
        Me.DteCurrentDate.TabIndex = 456
        Me.DteCurrentDate.VisualStyle = False
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Location = New System.Drawing.Point(73, 126)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 24)
        Me.Panel10.TabIndex = 4
        '
        'BtnChange
        '
        Me.BtnChange.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnChange.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnChange.Location = New System.Drawing.Point(262, 2)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(56, 19)
        Me.BtnChange.TabIndex = 55
        Me.BtnChange.TabStop = False
        Me.BtnChange.Text = "Change"
        '
        'BtnNotes
        '
        Me.BtnNotes.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnNotes.Location = New System.Drawing.Point(2, 128)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(69, 20)
        Me.BtnNotes.TabIndex = 56
        Me.BtnNotes.TabStop = False
        Me.BtnNotes.Text = "Notes"
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnHistory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnHistory.Location = New System.Drawing.Point(2, 2)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(69, 19)
        Me.BtnHistory.TabIndex = 54
        Me.BtnHistory.TabStop = False
        Me.BtnHistory.Text = "History"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(73, -45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 68)
        Me.Panel1.TabIndex = 374
        '
        'ChkVehicleOutOfService
        '
        Me.ChkVehicleOutOfService.Location = New System.Drawing.Point(263, 233)
        Me.ChkVehicleOutOfService.Name = "ChkVehicleOutOfService"
        Me.ChkVehicleOutOfService.Size = New System.Drawing.Size(131, 15)
        Me.ChkVehicleOutOfService.TabIndex = 53
        Me.ChkVehicleOutOfService.Text = "Vehicle OutOf Service"
        '
        'TxtSalvagedDate
        '
        Me.TxtSalvagedDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtSalvagedDate.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSalvagedDate.Location = New System.Drawing.Point(317, 206)
        Me.TxtSalvagedDate.MaxLength = 50
        Me.TxtSalvagedDate.Name = "TxtSalvagedDate"
        Me.TxtSalvagedDate.ReadOnly = True
        Me.TxtSalvagedDate.Size = New System.Drawing.Size(71, 21)
        Me.TxtSalvagedDate.TabIndex = 52
        Me.TxtSalvagedDate.TabStop = False
        Me.TxtSalvagedDate.Text = ""
        '
        'TxtChangeDate
        '
        Me.TxtChangeDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtChangeDate.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtChangeDate.Location = New System.Drawing.Point(317, 181)
        Me.TxtChangeDate.MaxLength = 50
        Me.TxtChangeDate.Name = "TxtChangeDate"
        Me.TxtChangeDate.ReadOnly = True
        Me.TxtChangeDate.Size = New System.Drawing.Size(71, 21)
        Me.TxtChangeDate.TabIndex = 51
        Me.TxtChangeDate.TabStop = False
        Me.TxtChangeDate.Text = ""
        '
        'TxtCreatedDate
        '
        Me.TxtCreatedDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtCreatedDate.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtCreatedDate.Location = New System.Drawing.Point(317, 155)
        Me.TxtCreatedDate.MaxLength = 50
        Me.TxtCreatedDate.Name = "TxtCreatedDate"
        Me.TxtCreatedDate.ReadOnly = True
        Me.TxtCreatedDate.Size = New System.Drawing.Size(71, 21)
        Me.TxtCreatedDate.TabIndex = 50
        Me.TxtCreatedDate.TabStop = False
        Me.TxtCreatedDate.Text = ""
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(265, 210)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(49, 14)
        Me.Label37.TabIndex = 368
        Me.Label37.Text = "Salvaged"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(265, 185)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(49, 14)
        Me.Label38.TabIndex = 367
        Me.Label38.Text = "Changed"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lable25
        '
        Me.Lable25.BackColor = System.Drawing.Color.Transparent
        Me.Lable25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Lable25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lable25.Location = New System.Drawing.Point(265, 160)
        Me.Lable25.Name = "Lable25"
        Me.Lable25.Size = New System.Drawing.Size(49, 14)
        Me.Lable25.TabIndex = 366
        Me.Lable25.Text = "Created"
        Me.Lable25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(326, 129)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(58, 20)
        Me.Label35.TabIndex = 365
        Me.Label35.Text = "Date"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(-155, 149)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(417, 1)
        Me.Panel8.TabIndex = 364
        '
        'TxtBrakeMileage
        '
        Me.TxtBrakeMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtBrakeMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtBrakeMileage.Location = New System.Drawing.Point(72, 230)
        Me.TxtBrakeMileage.MaxLength = 50
        Me.TxtBrakeMileage.Name = "TxtBrakeMileage"
        Me.TxtBrakeMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtBrakeMileage.TabIndex = 42
        Me.TxtBrakeMileage.TabStop = False
        Me.TxtBrakeMileage.Text = ""
        '
        'TxtAlignmentMileage
        '
        Me.TxtAlignmentMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtAlignmentMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtAlignmentMileage.Location = New System.Drawing.Point(72, 205)
        Me.TxtAlignmentMileage.MaxLength = 50
        Me.TxtAlignmentMileage.Name = "TxtAlignmentMileage"
        Me.TxtAlignmentMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtAlignmentMileage.TabIndex = 40
        Me.TxtAlignmentMileage.TabStop = False
        Me.TxtAlignmentMileage.Text = ""
        '
        'TxtRotationMileage
        '
        Me.TxtRotationMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtRotationMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtRotationMileage.Location = New System.Drawing.Point(72, 180)
        Me.TxtRotationMileage.MaxLength = 50
        Me.TxtRotationMileage.Name = "TxtRotationMileage"
        Me.TxtRotationMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtRotationMileage.TabIndex = 38
        Me.TxtRotationMileage.TabStop = False
        Me.TxtRotationMileage.Text = ""
        '
        'TxtOilChangeMileage
        '
        Me.TxtOilChangeMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtOilChangeMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtOilChangeMileage.Location = New System.Drawing.Point(72, 155)
        Me.TxtOilChangeMileage.MaxLength = 50
        Me.TxtOilChangeMileage.Name = "TxtOilChangeMileage"
        Me.TxtOilChangeMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtOilChangeMileage.TabIndex = 36
        Me.TxtOilChangeMileage.TabStop = False
        Me.TxtOilChangeMileage.Text = ""
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(4, 232)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 14)
        Me.Label31.TabIndex = 355
        Me.Label31.Text = "Brake"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(5, 207)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 14)
        Me.Label32.TabIndex = 354
        Me.Label32.Text = "Alignment"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(4, 182)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 14)
        Me.Label33.TabIndex = 353
        Me.Label33.Text = "Rotation"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(4, 157)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 14)
        Me.Label34.TabIndex = 352
        Me.Label34.Text = "Oil Change"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAverageMileage
        '
        Me.TxtAverageMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtAverageMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtAverageMileage.Location = New System.Drawing.Point(72, 101)
        Me.TxtAverageMileage.MaxLength = 50
        Me.TxtAverageMileage.Name = "TxtAverageMileage"
        Me.TxtAverageMileage.ReadOnly = True
        Me.TxtAverageMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtAverageMileage.TabIndex = 34
        Me.TxtAverageMileage.TabStop = False
        Me.TxtAverageMileage.Text = ""
        '
        'TxtStartingMileage
        '
        Me.TxtStartingMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtStartingMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStartingMileage.Location = New System.Drawing.Point(72, 76)
        Me.TxtStartingMileage.MaxLength = 50
        Me.TxtStartingMileage.Name = "TxtStartingMileage"
        Me.TxtStartingMileage.ReadOnly = True
        Me.TxtStartingMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtStartingMileage.TabIndex = 32
        Me.TxtStartingMileage.TabStop = False
        Me.TxtStartingMileage.Text = ""
        '
        'TxtPreviousMileage
        '
        Me.TxtPreviousMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtPreviousMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPreviousMileage.Location = New System.Drawing.Point(72, 51)
        Me.TxtPreviousMileage.MaxLength = 50
        Me.TxtPreviousMileage.Name = "TxtPreviousMileage"
        Me.TxtPreviousMileage.ReadOnly = True
        Me.TxtPreviousMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtPreviousMileage.TabIndex = 30
        Me.TxtPreviousMileage.TabStop = False
        Me.TxtPreviousMileage.Text = ""
        '
        'TxtCurrentMileage
        '
        Me.TxtCurrentMileage.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtCurrentMileage.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtCurrentMileage.Location = New System.Drawing.Point(72, 26)
        Me.TxtCurrentMileage.MaxLength = 50
        Me.TxtCurrentMileage.Name = "TxtCurrentMileage"
        Me.TxtCurrentMileage.ReadOnly = True
        Me.TxtCurrentMileage.Size = New System.Drawing.Size(81, 21)
        Me.TxtCurrentMileage.TabIndex = 0
        Me.TxtCurrentMileage.TabStop = False
        Me.TxtCurrentMileage.Text = ""
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(320, -149)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 275)
        Me.Panel7.TabIndex = 343
        '
        'CHKCustomerNew
        '
        Me.CHKCustomerNew.Location = New System.Drawing.Point(368, 103)
        Me.CHKCustomerNew.Name = "CHKCustomerNew"
        Me.CHKCustomerNew.Size = New System.Drawing.Size(14, 15)
        Me.CHKCustomerNew.TabIndex = 49
        '
        'CHKVehicleNew
        '
        Me.CHKVehicleNew.Location = New System.Drawing.Point(368, 78)
        Me.CHKVehicleNew.Name = "CHKVehicleNew"
        Me.CHKVehicleNew.Size = New System.Drawing.Size(14, 15)
        Me.CHKVehicleNew.TabIndex = 47
        '
        'CHKLicenseNew
        '
        Me.CHKLicenseNew.Location = New System.Drawing.Point(368, 53)
        Me.CHKLicenseNew.Name = "CHKLicenseNew"
        Me.CHKLicenseNew.Size = New System.Drawing.Size(14, 15)
        Me.CHKLicenseNew.TabIndex = 45
        '
        'CHKVehicleSame
        '
        Me.CHKVehicleSame.Location = New System.Drawing.Point(336, 78)
        Me.CHKVehicleSame.Name = "CHKVehicleSame"
        Me.CHKVehicleSame.Size = New System.Drawing.Size(14, 15)
        Me.CHKVehicleSame.TabIndex = 46
        '
        'CHKCustomerSame
        '
        Me.CHKCustomerSame.Location = New System.Drawing.Point(336, 103)
        Me.CHKCustomerSame.Name = "CHKCustomerSame"
        Me.CHKCustomerSame.Size = New System.Drawing.Size(14, 15)
        Me.CHKCustomerSame.TabIndex = 48
        '
        'CHKLicenseSame
        '
        Me.CHKLicenseSame.Location = New System.Drawing.Point(336, 53)
        Me.CHKLicenseSame.Name = "CHKLicenseSame"
        Me.CHKLicenseSame.Size = New System.Drawing.Size(14, 15)
        Me.CHKLicenseSame.TabIndex = 44
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(355, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 19)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "New"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(323, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 19)
        Me.Label26.TabIndex = 331
        Me.Label26.Text = "Same"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(155, -1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1, 275)
        Me.Panel6.TabIndex = 330
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(180, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 20)
        Me.Label23.TabIndex = 329
        Me.Label23.Text = "Date"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(82, 129)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 20)
        Me.Label24.TabIndex = 328
        Me.Label24.Text = "Next Service"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(-2, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(455, 1)
        Me.Panel5.TabIndex = 326
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(321, 2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 19)
        Me.Label21.TabIndex = 325
        Me.Label21.Text = "Status"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(-2, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(464, 1)
        Me.Panel4.TabIndex = 323
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(4, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 14)
        Me.Label17.TabIndex = 322
        Me.Label17.Text = "Average"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(4, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 14)
        Me.Label18.TabIndex = 321
        Me.Label18.Text = "Starting"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(4, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 14)
        Me.Label19.TabIndex = 320
        Me.Label19.Text = "Previous"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(4, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 14)
        Me.Label20.TabIndex = 319
        Me.Label20.Text = "Current"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(176, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 19)
        Me.Label16.TabIndex = 312
        Me.Label16.Text = "Date"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(80, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 311
        Me.Label15.Text = "Mileage"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(261, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 275)
        Me.Panel3.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(264, 103)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 14)
        Me.Label28.TabIndex = 342
        Me.Label28.Text = "Customer"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(267, 78)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 14)
        Me.Label29.TabIndex = 341
        Me.Label29.Text = "Vehicle"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(269, 53)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 14)
        Me.Label30.TabIndex = 340
        Me.Label30.Text = "License"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumYear
        '
        Me.NumYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumYear.DecimalDigits = 0
        Me.NumYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumYear.FormatString = "####"
        Me.NumYear.Location = New System.Drawing.Point(78, 32)
        Me.NumYear.MaxLength = 4
        Me.NumYear.Name = "NumYear"
        Me.NumYear.Size = New System.Drawing.Size(55, 20)
        Me.NumYear.TabIndex = 3
        Me.NumYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumYear.Value = CType(0, Short)
        Me.NumYear.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Cmbcod_kind_engine
        '
        Me.Cmbcod_kind_engine.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_kind_engine.DataSource = Me.DsFrmVehicle1.inv_tab_kind_engine
        Me.Cmbcod_kind_engine.DisplayMember = "desc_kind_engine"
        Me.Cmbcod_kind_engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_kind_engine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_kind_engine.ItemHeight = 13
        Me.Cmbcod_kind_engine.Location = New System.Drawing.Point(78, 108)
        Me.Cmbcod_kind_engine.Name = "Cmbcod_kind_engine"
        Me.Cmbcod_kind_engine.Size = New System.Drawing.Size(150, 21)
        Me.Cmbcod_kind_engine.TabIndex = 6
        Me.Cmbcod_kind_engine.ValueMember = "cod_kind_engine"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(8, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 14)
        Me.Label11.TabIndex = 320
        Me.Label11.Text = "Quarts"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(8, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 14)
        Me.Label12.TabIndex = 319
        Me.Label12.Text = "Oil Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(6, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 14)
        Me.Label13.TabIndex = 318
        Me.Label13.Text = "Vehicle Type"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(8, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 14)
        Me.Label10.TabIndex = 317
        Me.Label10.Text = "Unit No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(5, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 14)
        Me.Label9.TabIndex = 316
        Me.Label9.Text = "VIN"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(6, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 14)
        Me.Label8.TabIndex = 315
        Me.Label8.Text = "Color"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(6, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 14)
        Me.Label7.TabIndex = 314
        Me.Label7.Text = "Engine"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 313
        Me.Label5.Text = "Model"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(5, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 312
        Me.Label3.Text = "Make"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(5, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 311
        Me.Label2.Text = "Year"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTLicenseNo
        '
        Me.TXTLicenseNo.BackColor = System.Drawing.SystemColors.Window
        Me.TXTLicenseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTLicenseNo.Location = New System.Drawing.Point(78, 5)
        Me.TXTLicenseNo.MaxLength = 20
        Me.TXTLicenseNo.Name = "TXTLicenseNo"
        Me.TXTLicenseNo.Size = New System.Drawing.Size(110, 20)
        Me.TXTLicenseNo.TabIndex = 0
        Me.TXTLicenseNo.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 309
        Me.Label1.Text = "License No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbcod_model
        '
        Me.Cmbcod_model.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_model.DataSource = Me.DataViewForModel
        Me.Cmbcod_model.DisplayMember = "desc_model"
        Me.Cmbcod_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_model.ItemHeight = 13
        Me.Cmbcod_model.Location = New System.Drawing.Point(78, 84)
        Me.Cmbcod_model.Name = "Cmbcod_model"
        Me.Cmbcod_model.Size = New System.Drawing.Size(160, 21)
        Me.Cmbcod_model.TabIndex = 5
        Me.Cmbcod_model.ValueMember = "cod_model"
        '
        'DataViewForModel
        '
        Me.DataViewForModel.Table = Me.DsFrmVehicle1.bas_vehicle_model
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(187, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.TabIndex = 325
        Me.Label6.Text = "State"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO ser_tr_vehicle (license_no_vehicle, cod_customer, cod_vehicle, cod_ki" & _
        "nd_engine, cod_color, unit_no, engin_designatoin_code, engine_vin, aa_id, creat_" & _
        "date, change_date, salvage_date, vehicle_active, vehicle_out_service, cod_quarts" & _
        ", cod_oil_type, state, notes, vin) VALUES (@license_no_vehicle, @cod_customer, @" & _
        "cod_vehicle, @cod_kind_engine, @cod_color, @unit_no, @engin_designatoin_code, @e" & _
        "ngine_vin, @aa_id, @creat_date, @change_date, @salvage_date, @vehicle_active, @v" & _
        "ehicle_out_service, @Cod_quarts, @cod_oil_type, @State, @Notes, @Vin); SELECT @@" & _
        "Identity FROM ser_tr_vehicle"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@license_no_vehicle", System.Data.SqlDbType.VarChar, 20, "license_no_vehicle"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vehicle", System.Data.SqlDbType.VarChar, 4, "cod_vehicle"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_kind_engine", System.Data.SqlDbType.VarChar, 2, "cod_kind_engine"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_color", System.Data.SqlDbType.VarChar, 3, "cod_color"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unit_no", System.Data.SqlDbType.VarChar, 10, "unit_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@engin_designatoin_code", System.Data.SqlDbType.VarChar, 10, "engin_designatoin_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@engine_vin", System.Data.SqlDbType.VarChar, 10, "engine_vin"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@aa_id", System.Data.SqlDbType.VarChar, 10, "aa_id"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@creat_date", System.Data.SqlDbType.VarChar, 10, "creat_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@change_date", System.Data.SqlDbType.VarChar, 10, "change_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salvage_date", System.Data.SqlDbType.VarChar, 10, "salvage_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vehicle_active", System.Data.SqlDbType.Bit, 1, "vehicle_active"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vehicle_out_service", System.Data.SqlDbType.Bit, 1, "vehicle_out_service"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_quarts", System.Data.SqlDbType.VarChar, 1, "cod_quarts"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_oil_type", System.Data.SqlDbType.VarChar, 2, "cod_oil_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@State", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vin", System.Data.SqlDbType.VarChar, 20, "vin"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE ser_tr_vehicle SET license_no_vehicle = @license_no_vehicle, cod_customer " & _
        "= @cod_customer, cod_vehicle = @cod_vehicle, cod_kind_engine = @cod_kind_engine," & _
        " cod_color = @cod_color, unit_no = @unit_no, engin_designatoin_code = @engin_des" & _
        "ignatoin_code, engine_vin = @engine_vin, aa_id = @aa_id, creat_date = @creat_dat" & _
        "e, change_date = @change_date, salvage_date = @salvage_date, vehicle_out_service" & _
        " = @vehicle_out_service, cod_quarts = @Cod_quarts, cod_oil_type = @cod_oil_type," & _
        " state = @State, notes = @Notes, vin = @Vin WHERE (license_no_vehicle = @license" & _
        "_no_vehicle)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@license_no_vehicle", System.Data.SqlDbType.VarChar, 20, "license_no_vehicle"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vehicle", System.Data.SqlDbType.VarChar, 4, "cod_vehicle"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_kind_engine", System.Data.SqlDbType.VarChar, 2, "cod_kind_engine"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_color", System.Data.SqlDbType.VarChar, 3, "cod_color"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@unit_no", System.Data.SqlDbType.VarChar, 10, "unit_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@engin_designatoin_code", System.Data.SqlDbType.VarChar, 10, "engin_designatoin_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@engine_vin", System.Data.SqlDbType.VarChar, 10, "engine_vin"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@aa_id", System.Data.SqlDbType.VarChar, 10, "aa_id"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@creat_date", System.Data.SqlDbType.VarChar, 10, "creat_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@change_date", System.Data.SqlDbType.VarChar, 10, "change_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salvage_date", System.Data.SqlDbType.VarChar, 10, "salvage_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vehicle_out_service", System.Data.SqlDbType.Bit, 1, "vehicle_out_service"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_quarts", System.Data.SqlDbType.VarChar, 1, "cod_quarts"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_oil_type", System.Data.SqlDbType.VarChar, 2, "cod_oil_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@State", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vin", System.Data.SqlDbType.VarChar, 20, "vin"))
        '
        'DAbas_vehicle_company
        '
        Me.DAbas_vehicle_company.SelectCommand = Me.SqlCommand1
        Me.DAbas_vehicle_company.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_company", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("desc_make", "desc_make")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT desc_make, cod_make FROM bas_vehicle_company ORDER BY desc_make"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.BtnSortOrder)
        Me.Panel9.Controls.Add(Me.Label44)
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
        Me.Panel9.Size = New System.Drawing.Size(646, 45)
        Me.Panel9.TabIndex = 2
        '
        'BtnSortOrder
        '
        Me.BtnSortOrder.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.BtnSortOrder.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnSortOrder.Image = CType(resources.GetObject("BtnSortOrder.Image"), System.Drawing.Image)
        Me.BtnSortOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSortOrder.Location = New System.Drawing.Point(494, 2)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 27)
        Me.BtnSortOrder.TabIndex = 197
        '
        'UiContextMenu1
        '
        Me.UiContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UiContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort11, Me.Sort21, Me.Sort37})
        Me.UiContextMenu1.Key = "ContextMenu1"
        Me.UiContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UiContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort1, Me.Sort2, Me.Sort36})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("a2ea6436-bf31-4bcb-b7fe-12ef7f48298c")
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
        Me.Sort1.Text = "Order By License No"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Customer Cod"
        '
        'Sort36
        '
        Me.Sort36.Key = "Sort3"
        Me.Sort36.Name = "Sort36"
        Me.Sort36.Text = "Order By Vin"
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
        'Sort37
        '
        Me.Sort37.Key = "Sort3"
        Me.Sort37.Name = "Sort37"
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
        'DAbas_color
        '
        Me.DAbas_color.SelectCommand = Me.SqlCommand3
        Me.DAbas_color.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_color", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_color", "cod_color"), New System.Data.Common.DataColumnMapping("desc_color", "desc_color")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT cod_color, desc_color FROM bas_color ORDER BY desc_color"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'DAinv_tab_oil_type
        '
        Me.DAinv_tab_oil_type.SelectCommand = Me.SqlCommand4
        Me.DAinv_tab_oil_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_oil_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_oil_type", "cod_oil_type"), New System.Data.Common.DataColumnMapping("desc_oil_type", "desc_oil_type")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT cod_oil_type, desc_oil_type FROM inv_tab_oil_type"
        Me.SqlCommand4.Connection = Me.Cnn
        '
        'DAinv_tab_kind_engine
        '
        Me.DAinv_tab_kind_engine.SelectCommand = Me.SqlCommand5
        Me.DAinv_tab_kind_engine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_kind_engine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kind_engine", "cod_kind_engine"), New System.Data.Common.DataColumnMapping("desc_kind_engine", "desc_kind_engine"), New System.Data.Common.DataColumnMapping("size_liters", "size_liters"), New System.Data.Common.DataColumnMapping("size_cubic_cm", "size_cubic_cm"), New System.Data.Common.DataColumnMapping("cub_indisplacement", "cub_indisplacement"), New System.Data.Common.DataColumnMapping("fuel_type", "fuel_type"), New System.Data.Common.DataColumnMapping("fuel_delivery", "fuel_delivery"), New System.Data.Common.DataColumnMapping("aspiration", "aspiration")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT cod_kind_engine, desc_kind_engine FROM inv_tab_kind_engine ORDER BY desc_k" & _
        "ind_engine"
        Me.SqlCommand5.Connection = Me.Cnn
        '
        'DAbas_zipcode
        '
        Me.DAbas_zipcode.SelectCommand = Me.SqlCommand8
        Me.DAbas_zipcode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_zipcode", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("county", "county"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("ariacode", "ariacode"), New System.Data.Common.DataColumnMapping("fips_code", "fips_code"), New System.Data.Common.DataColumnMapping("time_zone", "time_zone"), New System.Data.Common.DataColumnMapping("dst", "dst")})})
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "SELECT DISTINCT state FROM bas_zipcode"
        Me.SqlCommand8.Connection = Me.Cnn
        '
        'DAinv_tab_vehicle_type
        '
        Me.DAinv_tab_vehicle_type.SelectCommand = Me.SqlCommand7
        Me.DAinv_tab_vehicle_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vehicle_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle_type", "cod_vehicle_type"), New System.Data.Common.DataColumnMapping("desc_vehicle_type", "desc_vehicle_type")})})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "SELECT cod_vehicle_type, desc_vehicle_type FROM inv_tab_vehicle_type"
        Me.SqlCommand7.Connection = Me.Cnn
        '
        'DAinv_tab_quarts
        '
        Me.DAinv_tab_quarts.SelectCommand = Me.SqlCommand6
        Me.DAinv_tab_quarts.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_quarts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("quarts", "quarts"), New System.Data.Common.DataColumnMapping("desc_quarts", "desc_quarts")})})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "SELECT Cod_quarts, desc_quarts FROM inv_tab_quarts"
        Me.SqlCommand6.Connection = Me.Cnn
        '
        'Sort3
        '
        Me.Sort3.Key = "Sort3"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Order By Vehicle Type"
        '
        'Sort31
        '
        Me.Sort31.Key = "Sort3"
        Me.Sort31.Name = "Sort31"
        '
        'Sort32
        '
        Me.Sort32.Key = "Sort3"
        Me.Sort32.Name = "Sort32"
        Me.Sort32.Text = "Order By Vehicle Type"
        '
        'Sort33
        '
        Me.Sort33.Key = "Sort3"
        Me.Sort33.Name = "Sort33"
        '
        'Sort34
        '
        Me.Sort34.Key = "Sort3"
        Me.Sort34.Name = "Sort34"
        Me.Sort34.Text = "Order By Vehicle Code"
        '
        'Sort35
        '
        Me.Sort35.Key = "Sort3"
        Me.Sort35.Name = "Sort35"
        '
        'DAbas_vehicle_model
        '
        Me.DAbas_vehicle_model.SelectCommand = Me.SqlCommand2
        Me.DAbas_vehicle_model.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_company", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("desc_make", "desc_make")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT cod_model, desc_model, cod_make FROM bas_vehicle_model ORDER BY desc_model" & _
        ""
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnTemp
        '
        'FrmVehicle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(646, 354)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmVehicle"
        Me.Text = "Vehicle"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        CType(Me.DsFrmVehicle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataViewForModel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub FrmVehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        License_No1.CanAddNewCod = False
        Try
            Me.Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        Try
            Me.CnnTemp.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try

        PnlSearchHeight = PnlSearch.Height

        DteCurrentDate.Text = Now

        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        If DsFrmVehicle1.bas_vehicle_company.Rows.Count = 0 Then
            Call FillDataSets()
        End If

        '''''''''' come form setup table ''''''''''''
        'CmbState

        TXTLicenseNo.MaxLength = LenLicenseNo

        If Id_VehicleForShow > 0 Then
            License_No1.FieldCodValue = Id_VehicleForShow
            Call AfterSaveOrCancel()
            CustomerCod1.Focus()
        Else
            If QuickAddFlag Then
                Call PAddNew()
                TXTLicenseNo.Text = LicenceNoForQuickAdd
                'TXTLicenseNo.Text = ""
                CustomerCod1.CustomerCod = CustomerNoForQuickAdd
                TXTLicenseNo.Focus()
                SendKeys.Send("{TAB}")
            Else
                If LicenseNoTempVar = 0 Then
                    Call PFirstRecord(False)
                Else
                    License_No1.FieldCodValue = LicenseNoTempVar
                    Call FillFields(License_No1.Text)
                End If
                Call AfterSaveOrCancel()
                License_No1.Focus()
            End If
        End If
        'Call AfterSaveOrCancel()
        RaiseEvent AfterLoad()
    End Sub
    Private Sub FillDataSets()
        DsFrmVehicle1.bas_color.Clear()
        DAbas_color.Fill(DsFrmVehicle1, "bas_color")
        If DsFrmVehicle1.bas_color.Rows.Count < 1 Then
            MsgFar("Please Fill The Vehicle Color Table")
            'Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmVehicle1.bas_vehicle_company.Clear()
        DAbas_vehicle_company.Fill(DsFrmVehicle1, "bas_vehicle_company")
        If DsFrmVehicle1.bas_vehicle_company.Rows.Count < 1 Then
            MsgFar("Please Fill The Vehicle Company Table")
            'Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmVehicle1.bas_vehicle_model.Clear()
        DAbas_vehicle_model.Fill(DsFrmVehicle1, "bas_vehicle_model")

        ''''''''''''''''''''''Call FillDAbas_vehicle_model()

        DsFrmVehicle1.bas_zipcode.Clear()
        DAbas_zipcode.Fill(DsFrmVehicle1, "bas_zipcode")
        If DsFrmVehicle1.bas_zipcode.Rows.Count < 1 Then
            MsgFar("Please Fill The ZipCode Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmVehicle1.inv_tab_kind_engine.Clear()
        DAinv_tab_kind_engine.Fill(DsFrmVehicle1, "inv_tab_kind_engine")
        If DsFrmVehicle1.inv_tab_kind_engine.Rows.Count < 1 Then
            MsgFar("Please Fill The Engine Kind Table")
            'Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmVehicle1.inv_tab_oil_type.Clear()
        DAinv_tab_oil_type.Fill(DsFrmVehicle1, "inv_tab_oil_type")
        If DsFrmVehicle1.inv_tab_oil_type.Rows.Count < 1 Then
            MsgFar("Please Fill The Oil Type Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmVehicle1.inv_tab_quarts.Clear()
        DAinv_tab_quarts.Fill(DsFrmVehicle1, "inv_tab_quarts")
        If DsFrmVehicle1.inv_tab_quarts.Rows.Count < 1 Then
            MsgFar("Please Fill The Quarts model Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmVehicle1.inv_tab_vehicle_type.Clear()
        DAinv_tab_vehicle_type.Fill(DsFrmVehicle1, "inv_tab_vehicle_type")
        If DsFrmVehicle1.inv_tab_vehicle_type.Rows.Count < 1 Then
            MsgFar("Please Fill The Vehicle Type Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        LicenseNoTempVar = License_No1.FieldCodValue
        License_No1.Text = ""
        Call ClearField()

        TXTLicenseNo.Focus()

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
        LicenseNoTempVar = License_No1.FieldCodValue
        TXTLicenseNo.Focus()

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
                CmdDelete.Parameters("@id_vehicle").Value = License_No1.FieldCodValue
                CmdDelete.ExecuteNonQuery()
                LicenseNoTempVar = 0
                Call PNextRecord(False)
                If LicenseNoTempVar = 0 Then
                    Call PPreviousRecord(False)
                    If LicenseNoTempVar = 0 Then
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
            License_No1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        If NumYear.Text.Trim.Length < 4 And NumYear.Text.Trim.Length > 0 Then
            MsgBox("Please Fill The Year Completely (4 Digit)")
            Exit Sub
        End If
        Select Case Status
            Case MainModule.WorkStates.AddNew
                LicenseNoTempVar = PInsert()
                ChangeOK = IIf(LicenseNoTempVar = 0, False, True)
                If ChangeOK Then
                    RaiseEvent AfterSave(LicenseNoTempVar)
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(LicenseNoTempVar)
        End Select
        If ChangeOK Then
            If QuickAddFlag = True Then
                Id_VehicleForShow = LicenseNoTempVar
                Me.Close()
            End If
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()
            License_No1.FieldCodValue = LicenseNoTempVar

            License_No1.Focus()
            If ExitAfterSaveOrCancel Then
                Me.Close()
            End If

        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        License_No1.FieldCodValue = LicenseNoTempVar
        Call FillFields(License_No1.Text)
        Call AfterSaveOrCancel()
        License_No1.Focus()
        If ExitAfterSaveOrCancel Then
            Me.Close()
        End If
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TXTLicenseNo.Text.Trim.Length = 0 Then
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
    Private Sub TXTLicenseNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAlignmentMileage.TextChanged, TxtAverageMileage.TextChanged, TxtBrakeMileage.TextChanged, TxtChangeDate.TextChanged, TxtCreatedDate.TextChanged, TxtCurrentMileage.TextChanged, TXTLicenseNo.TextChanged, TxtOilChangeMileage.TextChanged, TxtPreviousMileage.TextChanged, TxtRotationMileage.TextChanged, TxtSalvagedDate.TextChanged, TxtStartingMileage.TextChanged, TxtVin.TextChanged, NumYear.TextChanged, Cmbcod_color.SelectedIndexChanged, Cmbcod_kind_engine.SelectedIndexChanged, Cmbcod_make.SelectedIndexChanged, Cmbcod_model.SelectedIndexChanged, Cmbcod_oil_type.SelectedIndexChanged, Cmbcod_vehicle_type.SelectedIndexChanged, Cmbquarts.SelectedIndexChanged, CmbState.SelectedIndexChanged, CHKCustomerNew.CheckedChanged, CHKCustomerSame.CheckedChanged, CHKLicenseNew.CheckedChanged, CHKLicenseSame.CheckedChanged, CHKVehicleNew.CheckedChanged, CHKVehicleSame.CheckedChanged, CustomerCod1.TextChanged, TxtUnitNo.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            ' Khode hamid goft in kar o bekonim
            'If CustomerCod1.Text.Trim.Length > 0 And TXTLicenseNo.Text.Trim.Length > 0 And Cmbcod_make.Text.Trim.Length > 0 And Cmbcod_model.Text.Trim.Length > 0 Then
            If CustomerCod1.Text.Trim.Length > 0 And TXTLicenseNo.Text.Trim.Length > 0 Then
                'And NumYear.Text.Trim.Length = 4 
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
            Dim TXTSearchLicenseNoTemp As Decimal
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle Order BY " & VehicleOrderFieldName & " ASC ," & VehicleOrderFieldName2 & " ASC"
            TXTSearchLicenseNoTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If CInt("0" & TXTSearchLicenseNoTemp) = 0 Then
                TXTSearchLicenseNoTemp = 0
            End If
            If TXTSearchLicenseNoTemp = License_No1.FieldCodValue Or TXTSearchLicenseNoTemp = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                'License_No1.Text = TXTSearchLicenseNoTemp
                License_No1.FieldCodValue = TXTSearchLicenseNoTemp
                Call FillFields(License_No1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchLicenseNoTemp As Decimal
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case VehicleOrderFieldName.ToUpper.Trim
            Case "license_no_vehicle".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle where license_no_vehicle+cast( id_vehicle as char(20)) < " & Qt(TXTLicenseNo.Text + InsertSpaceAfter(Trim(Str(License_No1.FieldCodValue)), 20)) & " Order BY " & VehicleOrderFieldName & " DESC ," & VehicleOrderFieldName2 & " DESC"
            Case "cod_customer".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle where cod_customer<" & Qt(CustomerCod1.Text) & " Order BY " & VehicleOrderFieldName & " DESC ," & VehicleOrderFieldName2 & " DESC"
            Case "Vin".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle where Vin<" & Qt(TxtVin.Text) & " Order BY " & VehicleOrderFieldName & " DESC ," & VehicleOrderFieldName2 & " DESC"
        End Select
        TXTSearchLicenseNoTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchLicenseNoTemp) Then
            TXTSearchLicenseNoTemp = 0
        End If
        If TXTSearchLicenseNoTemp = License_No1.FieldCodValue Or TXTSearchLicenseNoTemp = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            License_No1.FieldCodValue = TXTSearchLicenseNoTemp
            LicenseNoTempVar = TXTSearchLicenseNoTemp
            Call FillFields(License_No1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchLicenseNoTemp As Integer
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case VehicleOrderFieldName.ToUpper.Trim
            Case "license_no_vehicle".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle where license_no_vehicle+cast( id_vehicle as char(20)) > " & Qt(TXTLicenseNo.Text + InsertSpaceAfter(Trim(Str(License_No1.FieldCodValue)), 20)) & " Order BY " & VehicleOrderFieldName & " ASC ," & VehicleOrderFieldName2 & " ASC"
            Case "cod_customer".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle where cod_customer >" & Qt(CustomerCod1.Text) & " Order BY " & VehicleOrderFieldName & " ASC ," & VehicleOrderFieldName2 & " ASC"
            Case "Vin".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle where Vin > " & Qt(TxtVin.Text) & " Order BY " & VehicleOrderFieldName & " ASC ," & VehicleOrderFieldName2 & " ASC"
        End Select
        TXTSearchLicenseNoTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchLicenseNoTemp) Then
            TXTSearchLicenseNoTemp = 0
        End If
        If TXTSearchLicenseNoTemp = License_No1.FieldCodValue Or TXTSearchLicenseNoTemp = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            License_No1.FieldCodValue = TXTSearchLicenseNoTemp
            LicenseNoTempVar = TXTSearchLicenseNoTemp
            Call FillFields(License_No1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchLicenseNoTemp As Integer = 0
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 id_vehicle from ser_tr_vehicle  Order BY " & VehicleOrderFieldName & " Desc ," & VehicleOrderFieldName2 & " DESC"
            TXTSearchLicenseNoTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchLicenseNoTemp) Then
                TXTSearchLicenseNoTemp = 0
            End If
            If TXTSearchLicenseNoTemp = License_No1.FieldCodValue Or TXTSearchLicenseNoTemp = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                License_No1.FieldCodValue = TXTSearchLicenseNoTemp
                Call FillFields(License_No1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub License_No1_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles License_No1.AfterFieldCodValueFind
        Call FillFields(License_No1.Text)
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
            License_No1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmVehicle_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        CustomerCod1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If License_No1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@license_no_vehicle").Value = License_No1.text
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
            TXTLicenseNo.ReadOnly = False
        Else
            TXTLicenseNo.ReadOnly = True
        End If
        TXTLicenseNo.Enabled = instatus
        DteAlignmentDate.Enabled = False
        TxtAlignmentMileage.Enabled = instatus
        DteAverageDate.Enabled = False
        TxtAverageMileage.Enabled = instatus
        DteBrakeDate.Enabled = False
        TxtBrakeMileage.Enabled = instatus
        TxtChangeDate.Enabled = instatus
        TxtCreatedDate.Enabled = instatus
        DteCurrentDate.Enabled = False
        TxtCurrentMileage.Enabled = instatus
        DteOilChangeDate.Enabled = False
        TxtOilChangeMileage.Enabled = instatus
        DtePreviousDate.Enabled = False
        TxtPreviousMileage.Enabled = instatus
        DteRotationDate.Enabled = False
        TxtRotationMileage.Enabled = instatus
        TxtSalvagedDate.Enabled = instatus
        DteStartingDate.Enabled = False
        TxtStartingMileage.Enabled = instatus
        TxtVin.Enabled = instatus
        Cmbcod_color.Enabled = instatus
        Cmbcod_kind_engine.Enabled = instatus
        Cmbcod_make.Enabled = instatus
        Cmbcod_model.Enabled = instatus
        Cmbcod_oil_type.Enabled = instatus
        Cmbcod_vehicle_type.Enabled = instatus
        Cmbquarts.Enabled = instatus
        CmbState.Enabled = instatus
        CustomerCod1.Enabled = instatus
        CHKCustomerNew.Enabled = instatus
        CHKCustomerSame.Enabled = instatus
        CHKLicenseNew.Enabled = instatus
        CHKLicenseSame.Enabled = instatus
        CHKVehicleNew.Enabled = instatus
        CHKVehicleSame.Enabled = instatus
        ChkVehicleOutOfService.Enabled = instatus
        TxtUnitNo.Enabled = instatus
        NumYear.Enabled = instatus
        BtnChange.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        TXTLicenseNo.Text = LicenceNoForQuickAdd

        DteAlignmentDate.Text = ""
        TxtAlignmentMileage.Text = ""
        DteAverageDate.Text = ""
        TxtAverageMileage.Text = ""
        DteBrakeDate.Text = ""
        TxtBrakeMileage.Text = ""
        TxtChangeDate.Text = ""

        TxtCreatedDate.Text = Now.Date
        DteCurrentDate.Text = Now.Date
        TxtCurrentMileage.Text = ""
        DteOilChangeDate.Text = ""
        TxtOilChangeMileage.Text = ""
        DtePreviousDate.Text = ""
        TxtPreviousMileage.Text = ""
        DteRotationDate.Text = ""
        TxtRotationMileage.Text = ""
        TxtSalvagedDate.Text = ""
        DteStartingDate.Text = ""
        TxtStartingMileage.Text = ""
        TxtVin.Text = ""
        TxtUnitNo.Text = ""
        NumYear.Text = ""
        VehicleNoteVar = ""
        CustomerCod1.Text = ""
        Try
            Cmbcod_color.SelectedValue = "0"
        Catch ex As Exception
        End Try
        Try
            Cmbcod_kind_engine.SelectedValue = "0"
        Catch ex As Exception
        End Try
        Try
            Cmbcod_make.SelectedValue = "0"
        Catch ex As Exception
        End Try
        Try
            Cmbcod_model.SelectedValue = "0"
        Catch ex As Exception
        End Try

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveServiceSetupTable(PubStoreNO)
        Try
            CmbState.SelectedValue = OleDbReaderForStore.Item("VEHICLE_STATE") & ""
        Catch ex As Exception
            CmbState.Text = ""
        End Try
        Try
            Cmbcod_oil_type.SelectedValue = OleDbReaderForStore.Item("VEHICLE_OIL_TYPE") & ""
        Catch ex As Exception
            Cmbcod_oil_type.SelectedValue = "0"
        End Try
        Try
            Cmbcod_vehicle_type.SelectedValue = OleDbReaderForStore.Item("VEHICLE_VEHICLE_TYPE") & ""
        Catch ex As Exception
            Cmbcod_vehicle_type.SelectedValue = "0"
        End Try
        Try
            Cmbquarts.SelectedValue = OleDbReaderForStore.Item("VEHICLE_QUARTS") & ""
        Catch ex As Exception
            Cmbquarts.SelectedValue = "0"
        End Try

        ChkVehicleOutOfService.Checked = False
    End Sub
    Private Sub GetTxtCod_vehicleVar()
        If Cmbcod_make.Text.Trim.Length = 0 Then
            TxtCod_vehicleVar = ""
        Else
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT cod_vehicle from bas_vehicle Where cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND cod_model=" & Qt(Cmbcod_model.SelectedValue) & " AND make_year=" & Qt(NumYear.Text)
            TxtCod_vehicleVar = CmdGeneral.ExecuteScalar()
            If IsNothing(TxtCod_vehicleVar) Then
                TxtCod_vehicleVar = MakeNewCod_Vehicle()
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Count(*) FROM bas_vehicle_model Where cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND cod_model=" & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.SelectedValue, 0))
                If CmdGeneral.ExecuteScalar() = 0 Then
                    CmdGeneral.CommandText = "INSERT INTO bas_vehicle_model (cod_make, cod_model, desc_model) values(" & Qt(Cmbcod_make.SelectedValue) & "," & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.SelectedValue, 0)) & "," & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.Text, "Model")) & ")"
                    CmdGeneral.ExecuteNonQuery()
                End If
                CmdGeneral.CommandText = "Insert Into bas_vehicle (cod_vehicle,cod_make,cod_model,make_year,options) values(" & Qt(TxtCod_vehicleVar) & "," & Qt(Cmbcod_make.SelectedValue) & "," & Qt(IIf(Cmbcod_model.Text.Trim.Length > 0, Cmbcod_model.SelectedValue, 0)) & "," & Qt(NumYear.Text) & "," & Qt(Cmbcod_vehicle_type.SelectedValue) & ")"
                CmdGeneral.ExecuteNonQuery()
            End If
            CmdGeneral.Connection.Close()
        End If
    End Sub
    Friend Function PInsert() As Decimal
        PInsert = 0
        Call GetTxtCod_vehicleVar()
        Call UpdateBeforVehicleFlag(TXTLicenseNo.Text)
        Try
            With CmdInsert
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@license_no_vehicle").Value = TXTLicenseNo.Text & ""
                .Parameters("@state").Value = IIf(IsNothing(CmbState.SelectedValue), System.DBNull.Value, CmbState.SelectedValue)
                .Parameters("@cod_customer").Value = CustomerCod1.CustomerCod & ""
                .Parameters("@cod_vehicle").Value = IIf((TxtCod_vehicleVar & "").Trim.Length > 0, TxtCod_vehicleVar, System.DBNull.Value)
                .Parameters("@cod_kind_engine").Value = ChkCombo(Cmbcod_kind_engine.SelectedValue)
                .Parameters("@cod_color").Value = ChkCombo(Cmbcod_color.SelectedValue)
                .Parameters("@engine_vin").Value = MyFrmEngineScreen.TxtEngineVin.Text & ""
                .Parameters("@unit_no").Value = TxtUnitNo.Text
                .Parameters("@cod_oil_type").Value = ChkCombo(Cmbcod_oil_type.SelectedValue)
                .Parameters("@Cod_quarts").Value = ChkCombo(Cmbquarts.SelectedValue)
                .Parameters("@Vin").Value = TxtVin.Text & ""
                .Parameters("@engin_designatoin_code").Value = MyFrmEngineScreen.TxtEngDesignationCode.Text & ""
                .Parameters("@aa_id").Value = MyFrmEngineScreen.TxtAAAID.Text & ""
                .Parameters("@creat_date").Value = TxtCreatedDate.Text & ""
                .Parameters("@Change_Date").Value = TxtChangeDate.Text & ""
                .Parameters("@salvage_date").Value = TxtSalvagedDate.Text & ""
                .Parameters("@vehicle_out_service").Value = IIf(ChkVehicleOutOfService.Checked, 1, 0)
                .Parameters("@Notes").Value = VehicleNoteVar & ""
                .Parameters("@vehicle_active").Value = 1
                PInsert = .ExecuteScalar
                'PInsert = TXTLicenseNo.Text
                .Connection.Close()
            End With
        Catch ex As Exception
            MsgBox("This license_no_vehicle Is Exist")
            PInsert = 0
        End Try
    End Function
    Friend Function PUpdate(ByVal Thislicense_no_vehicle As String) As Boolean
        PUpdate = True
        Call GetTxtCod_vehicleVar()
        Try
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@license_no_vehicle").Value = TXTLicenseNo.Text & ""
                .Parameters("@state").Value = IIf(IsNothing(CmbState.SelectedValue), System.DBNull.Value, CmbState.SelectedValue)
                .Parameters("@cod_customer").Value = CustomerCod1.CustomerCod & ""
                .Parameters("@cod_vehicle").Value = IIf((TxtCod_vehicleVar & "").Trim.Length > 0, TxtCod_vehicleVar, System.DBNull.Value)
                .Parameters("@cod_kind_engine").Value = ChkCombo(Cmbcod_kind_engine.SelectedValue)
                .Parameters("@cod_color").Value = ChkCombo(Cmbcod_color.SelectedValue)
                .Parameters("@engine_vin").Value = MyFrmEngineScreen.TxtEngineVin.Text & ""
                .Parameters("@unit_no").Value = TxtUnitNo.Text
                .Parameters("@cod_oil_type").Value = ChkCombo(Cmbcod_oil_type.SelectedValue)
                .Parameters("@Cod_quarts").Value = ChkCombo(Cmbquarts.SelectedValue)
                .Parameters("@Vin").Value = TxtVin.Text & ""
                .Parameters("@engin_designatoin_code").Value = MyFrmEngineScreen.TxtEngDesignationCode.Text & ""
                .Parameters("@aa_id").Value = MyFrmEngineScreen.TxtAAAID.Text & ""
                .Parameters("@creat_date").Value = TxtCreatedDate.Text & ""
                .Parameters("@Change_Date").Value = TxtChangeDate.Text & ""
                .Parameters("@salvage_date").Value = TxtSalvagedDate.Text & ""
                .Parameters("@vehicle_out_service").Value = IIf(ChkVehicleOutOfService.Checked, 1, 0)
                .Parameters("@Notes").Value = VehicleNoteVar & ""
                .ExecuteNonQuery()
                PUpdate = True
                .Connection.Close()
            End With
        Catch ex As Exception
            MsgBox("This license_no_vehicle Is Exist")
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal Thislicense_no_vehicle As String) As Boolean
        FillFields = False
        If Thislicense_no_vehicle.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        CmdGeneralForReader.CommandText = "SELECT ser_tr_vehicle.id_vehicle, ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.cod_customer, ser_tr_vehicle.cod_vehicle, " _
                      & " ser_tr_vehicle.cod_kind_engine, ser_tr_vehicle.cod_color, ser_tr_vehicle.unit_no, bas_vehicle.Options as cod_vehicle_type, " _
                      & " ser_tr_vehicle.engin_designatoin_code, ser_tr_vehicle.engine_vin, ser_tr_vehicle.aa_id, bas_vehicle.cod_make, bas_vehicle.cod_model, " _
                      & " ser_tr_vehicle.creat_date, ser_tr_vehicle.change_date, ser_tr_vehicle.salvage_date, " _
                      & " ser_tr_vehicle.vehicle_active, ser_tr_vehicle.vehicle_out_service, ser_tr_vehicle.Cod_quarts, ser_tr_vehicle.cod_oil_type, ser_tr_vehicle.State, ser_tr_vehicle.Notes, " _
                      & " ser_tr_vehicle.vin, bas_vehicle.make_year " _
                      & " FROM ser_tr_vehicle LEFT OUTER JOIN " _
                      & " bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle where ser_tr_vehicle.id_vehicle = " & License_No1.FieldCodValue 'license_no_vehicle= " & Qt(Thislicense_no_vehicle) & " and
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            Dim Cmbcod_kind_engineVar As String
            SQLReader.Read()
            TXTLicenseNo.Text = Thislicense_no_vehicle & ""
            CmbState.SelectedValue = SQLReader.Item("State") & ""
            Cmbcod_make.SelectedValue = SQLReader.Item("cod_make") & ""
            Cmbcod_model.SelectedValue = SQLReader.Item("cod_model") & ""
            NumYear.Value = Trim(SQLReader.Item("make_year") & "")
            Cmbcod_kind_engineVar = Trim(SQLReader.Item("cod_kind_engine") & "")
            Cmbcod_color.SelectedValue = Trim(SQLReader.Item("cod_color") & "")
            MyFrmEngineScreen.TxtEngineVin.Text = Trim(SQLReader.Item("engine_vin") & "")
            MyFrmEngineScreen.TxtEngDesignationCode.Text = Trim(SQLReader.Item("engin_designatoin_code") & "")
            MyFrmEngineScreen.TxtAAAID.Text = Trim(SQLReader.Item("aa_id") & "")
            TxtUnitNo.Text = Trim(SQLReader.Item("unit_no") & "")
            Cmbcod_vehicle_type.SelectedValue = Trim(SQLReader.Item("cod_vehicle_type") & "")
            Cmbcod_oil_type.SelectedValue = Trim(SQLReader.Item("cod_oil_type") & "")
            Cmbquarts.SelectedValue = Trim(SQLReader.Item("cod_quarts") & "")
            TxtCreatedDate.Text = Trim(SQLReader.Item("creat_date") & "")
            TxtChangeDate.Text = Trim(SQLReader.Item("Change_date") & "")
            TxtSalvagedDate.Text = Trim(SQLReader.Item("Salvage_date") & "")
            ChkVehicleOutOfService.Checked = Trim(SQLReader.Item("vehicle_out_service") & "")
            TxtVin.Text = SQLReader.Item("Vin") & ""
            VehicleNoteVar = SQLReader.Item("Notes") & ""
            CustomerCod1.Text = Trim(SQLReader.Item("cod_customer") & "")
            Try
                LblSold.Visible = Not SQLReader.Item("vehicle_active")
            Catch ex As Exception
                LblSold.Visible = False
            End Try

            CmdGeneralForReader.Connection.Close()
            SQLReader.Close()
            Cmbcod_kind_engine.SelectedValue = Cmbcod_kind_engineVar
            Call FillMyFrmEngineScreen()
            '''''''''''''''''''''''''''''''''''''''
            Call FillOtherFields()
            FillFields = True
        Else
            Call ClearField()
        End If
        CmdGeneralForReader.Connection.Close()
        SQLReader.Close()
        Call AfterSaveOrCancel()
    End Function
    Private Sub FillOtherFields()
        If TXTLicenseNo.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader

        Try
            If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
                CmdGeneralForReader.Connection.Open()
            End If
            CmdGeneralForReader.CommandText = "SELECT ser_tr_vehicle_dtl.current_mileage, service_center_head.date_refer " _
                          & " FROM ser_tr_vehicle INNER JOIN " _
                          & " bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle INNER JOIN " _
                          & " service_center_head ON ser_tr_vehicle.id_vehicle = service_center_head.id_vehicle INNER JOIN " _
                          & " ser_tr_vehicle_dtl ON service_center_head.id_service_center = ser_tr_vehicle_dtl.id_service_center " _
                          & " Where license_no_vehicle=" & Qt(TXTLicenseNo.Text) & " AND service_center_head.type_of_form='IN' Order By dbo.ChangeDate(service_center_head.date_refer) Desc"
            SQLReader = CmdGeneralForReader.ExecuteReader

            TxtCurrentMileage.Text = ""
            DteCurrentDate.Text = ""
            TxtPreviousMileage.Text = ""
            DtePreviousDate.Text = ""
            TxtStartingMileage.Text = ""
            DteStartingDate.Text = ""

            If SQLReader.HasRows Then
                SQLReader.Read()
                TxtCurrentMileage.Text = Trim(SQLReader.Item("current_mileage"))
                'DteCurrentDate.Text = DateFormatChange(SQLReader.Item("date_refer") & "")
                DteCurrentDate.Text = SQLReader.Item("date_refer") & ""
                If SQLReader.Read Then
                    TxtPreviousMileage.Text = Trim(SQLReader.Item("current_mileage"))
                    'DtePreviousDate.Text = DateFormatChange(SQLReader.Item("date_refer") & "")
                    DtePreviousDate.Text = SQLReader.Item("date_refer") & ""
                Else
                    TxtPreviousMileage.Text = ""
                    DtePreviousDate.Text = ""
                End If
            End If
            SQLReader.Close()
            If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
                CmdGeneralForReader.Connection.Open()
            End If
            CmdGeneralForReader.CommandText = "SELECT ser_tr_vehicle_dtl.current_mileage, service_center_head.date_refer " _
                          & " FROM ser_tr_vehicle INNER JOIN " _
                          & " bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle INNER JOIN " _
                          & " service_center_head ON ser_tr_vehicle.id_vehicle = service_center_head.id_vehicle INNER JOIN " _
                          & " ser_tr_vehicle_dtl ON service_center_head.id_service_center = ser_tr_vehicle_dtl.id_service_center " _
                          & " Where license_no_vehicle=" & Qt(TXTLicenseNo.Text) & " AND service_center_head.type_of_form='IN' Order By dbo.ChangeDate(service_center_head.date_refer) Asc"
            SQLReader = CmdGeneralForReader.ExecuteReader

            If SQLReader.HasRows Then
                SQLReader.Read()
                TxtStartingMileage.Text = Trim(SQLReader.Item("current_mileage"))
                'DteStartingDate.Text = DateFormatChange(SQLReader.Item("date_refer") & "")
                DteStartingDate.Text = SQLReader.Item("date_refer") & ""
            End If
        Catch ex As Exception
        Finally
            SQLReader.Close()
            CmdGeneralForReader.Connection.Close()
        End Try

        Try
            Dim a As Double, b As Double, c As Double
            If (CType(DteCurrentDate.Text, Date).Subtract(CType(DtePreviousDate.Text, Date)).Days) > 0 Then
                a = (Val(TxtCurrentMileage.Text) - Val(TxtPreviousMileage.Text)) / (CType(DteCurrentDate.Text, Date).Subtract(CType(DtePreviousDate.Text, Date)).Days)
            Else
                a = 0
            End If
            If (CType(DteCurrentDate.Text, Date).Subtract(CType(DteStartingDate.Text, Date)).Days) > 0 Then
                b = (Val(TxtCurrentMileage.Text) - Val(TxtStartingMileage.Text)) / (CType(DteCurrentDate.Text, Date).Subtract(CType(DteStartingDate.Text, Date)).Days)
            Else
                b = 0
            End If
            If (CType(DtePreviousDate.Text, Date).Subtract(CType(DteStartingDate.Text, Date)).Days) > 0 Then
                c = (Val(TxtPreviousMileage.Text) - Val(TxtStartingMileage.Text)) / (CType(DtePreviousDate.Text, Date).Subtract(CType(DteStartingDate.Text, Date)).Days)
            Else
                c = 0
            End If
            TxtAverageMileage.Text = (a + b + c) / 3
            DteAverageDate.Text = Format(Now.Date, PubDateFormat)

            TxtOilChangeMileage.Text = Val(TxtCurrentMileage.Text) + 3000
            TxtRotationMileage.Text = Val(TxtCurrentMileage.Text) + 5000
            TxtAlignmentMileage.Text = Val(TxtCurrentMileage.Text) + 12000
            TxtBrakeMileage.Text = Val(TxtCurrentMileage.Text) + 20000

            DteOilChangeDate.Text = CType(DteCurrentDate.Text, Date).AddDays(90)
            DteRotationDate.Text = CType(DteCurrentDate.Text, Date).AddDays(150)
            DteAlignmentDate.Text = CType(DteCurrentDate.Text, Date).AddDays(360)
            DteBrakeDate.Text = CType(DteCurrentDate.Text, Date).AddDays(600)
        Catch ex As Exception
        End Try
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
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        LblCustomerName.Text = CustomerCod1.CustomerDesc
    End Sub
    Private Sub CustomerCod1_NotFindCustomerCod() Handles CustomerCod1.NotFindCustomerCod
        LblCustomerName.Text = ""
    End Sub
    Private Sub Cmbcod_make_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_make.SelectedIndexChanged
        Call FillDAbas_vehicle_model()
    End Sub
    Private Sub FillDAbas_vehicle_model()
        Try
            '''''DsFrmVehicle1.bas_vehicle_model.Clear()
            '''''DAbas_vehicle_model.SelectCommand.Parameters("@cod_make").Value = Cmbcod_make.SelectedValue
            '''''DAbas_vehicle_model.Fill(DsFrmVehicle1, "bas_vehicle_model")
            If Cmbcod_make.Text.Trim.Length > 0 Then
                DataViewForModel.RowFilter = "cod_make=" & Qt(Cmbcod_make.SelectedValue)
            Else
                Cmbcod_model.SelectedValue = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotes.Click
        MyFrmItemComments = New CommonClass.FrmItemComments
        MyFrmItemComments.TxtComments.Text = VehicleNoteVar & ""
        Call FitToScreen(BtnNotes, MyFrmItemComments)
        MyFrmItemComments.TxtComments.MaxLength = 300
        MyFrmItemComments.ThisFormStatus = Status
        MyFrmItemComments.ShowDialog()
        VehicleNoteVar = MyFrmItemComments.TxtCommentvar
        Call SaveButtonControl()
    End Sub
    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        Dim MyFrmVehicleHistory As New FrmVehicleHistory
        MyFrmVehicleHistory.Id_VehicleParameter = License_No1.FieldCodValue
        MyFrmVehicleHistory.LblCompany.Text = CustomerCod1.abbreviation_name
        MyFrmVehicleHistory.LblLicenceNo.Text = License_No1.Text
        MyFrmVehicleHistory.LblMake.Text = Cmbcod_make.Text
        MyFrmVehicleHistory.LblModel.Text = Cmbcod_model.Text
        MyFrmVehicleHistory.LblName.Text = CustomerCod1.F_Name & " " & CustomerCod1.M_Name & " " & CustomerCod1.L_Name
        MyFrmVehicleHistory.ShowDialog()
    End Sub
    Private Sub BtnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChange.Click
        Dim case1 As Boolean = CHKLicenseNew.Checked And CHKVehicleSame.Checked And CHKCustomerNew.Checked
        Dim case2 As Boolean = CHKLicenseNew.Checked And CHKVehicleSame.Checked And CHKCustomerSame.Checked
        Dim case3 As Boolean = CHKLicenseSame.Checked And CHKVehicleNew.Checked And CHKCustomerSame.Checked
        If case1 Then
            'MyFrmChangeServiceRecords = FrmChangeServiceRecords
            MyFrmChangeServiceRecords = New FrmChangeServiceRecords
            'MyFrmChangeServiceRecords.TXTLicenseNo.Text = TXTLicenseNo.Text
            'MyFrmChangeServiceRecords.CustomerCod1.Text = CustomerCod1.Text
            MyFrmChangeServiceRecords.ChangeDateVar = TxtChangeDate.Text
            MyFrmChangeServiceRecords.ShowDialog()
            TxtChangeDate.Text = MyFrmChangeServiceRecords.ChangeDateVar
        End If
        If case2 Then
            MyFrmChangeServiceRecords2 = New FrmChangeServiceRecords2
            MyFrmChangeServiceRecords2.ChangeDateVar = TxtChangeDate.Text
            MyFrmChangeServiceRecords2.ShowDialog()
            TxtChangeDate.Text = MyFrmChangeServiceRecords2.ChangeDateVar
        End If
        If case3 Then
            MyFrmVehicle2 = New FrmVehicle
            'MyFrmVehicle2.QuickAddFlag = True
            'MyFrmVehicle2.LicenceNoForQuickAdd = TXTLicenseNo.Text
            'TXTLicenseNo.Text = ""
            'MyFrmVehicle2.CustomerNoForQuickAdd = CustomerCod1.CustomerCod
            MyFrmVehicle2.ShowDialog()
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Count(*) from ser_tr_vehicle Where license_no_vehicle=" & Qt(TXTLicenseNo.Text)
            If CmdGeneral.ExecuteScalar() > 1 Then
                CmdGeneral.CommandText = "SELECT top 1 id_vehicle from ser_tr_vehicle Where license_no_vehicle=" & Qt(TXTLicenseNo.Text) & " Order by id_vehicle Asc"
                Try
                    Dim IdVehicleVar As Int32 = CmdGeneral.ExecuteScalar
                    Dim NewLicenceNoVar As String = "SOLD_" & Mid(TXTLicenseNo.Text, 1, 15)
                    CmdGeneral.CommandText = "Update ser_tr_vehicle SET license_no_vehicle=" & Qt(NewLicenceNoVar) & " Where id_vehicle=" & IdVehicleVar
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If
        End If


        'If CHKLicenseNew.Checked Then
        'End If
        'If CHKVehicleNew.Checked Then
        'End If
        'If CHKCustomerNew.Checked Then
        'End If
        'If CHKLicenseSame.Checked Then
        'End If
        'If CHKVehicleSame.Checked Then
        'End If
        'If CHKCustomerSame.Checked Then
        'End If
    End Sub
    Private Sub CHKLicenseNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKLicenseNew.CheckedChanged, CHKCustomerNew.CheckedChanged, CHKVehicleNew.CheckedChanged
        If CHKLicenseNew.Checked Then CHKLicenseSame.Checked = False
        If CHKVehicleNew.Checked Then CHKVehicleSame.Checked = False
        If CHKCustomerNew.Checked Then CHKCustomerSame.Checked = False
    End Sub
    Private Sub CHKLicenseSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKCustomerSame.CheckedChanged, CHKLicenseSame.CheckedChanged, CHKVehicleSame.CheckedChanged
        If CHKLicenseSame.Checked Then CHKLicenseNew.Checked = False
        If CHKVehicleSame.Checked Then CHKVehicleNew.Checked = False
        If CHKCustomerSame.Checked Then CHKCustomerNew.Checked = False
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                VehicleOrderFieldName = "license_no_vehicle"
            Case "SORT2"
                VehicleOrderFieldName = "cod_customer"
            Case "SORT3"
                VehicleOrderFieldName = "Vin"
        End Select
    End Sub
    Private Sub BtnEngine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEngine.Click
        If Cmbcod_kind_engine.Text.Trim.Length > 0 Then
            Call FitToScreen(BtnEngine, MyFrmEngineScreen)
            If Cmbcod_kind_engine.Enabled Then
                MyFrmEngineScreen.ThisFormStatus = MainModule.WorkStates.AddNew
                'If BtnSave.Enabled Then
                'Call PSave()
                'End If
            Else
                MyFrmEngineScreen.ThisFormStatus = MainModule.WorkStates._ReadOnly
            End If
            MyFrmEngineScreen.TxtName.Text = TXTLicenseNo.Text
            MyFrmEngineScreen.ShowDialog()
        Else
            MsgBox("Please Fill Engine Type")
        End If
        Call SaveButtonControl()
    End Sub
    Private Sub ChkVehicleOutOfService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkVehicleOutOfService.CheckedChanged
        Call SaveButtonControl()
        If ChkVehicleOutOfService.Checked Then
            TxtSalvagedDate.Text = Format(Today.Now, PubDateFormat)
        Else
            TxtSalvagedDate.Text = ""
        End If
    End Sub
    Private Sub Cmbcod_kind_engine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_kind_engine.SelectedIndexChanged
        Call FillMyFrmEngineScreen()
    End Sub
    Private Sub FillMyFrmEngineScreen()
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
                CmdGeneralForReader.Connection.Open()
            End If
            CmdGeneralForReader.CommandText = "SELECT * FROM inv_tab_kind_engine where cod_kind_engine=" & Qt(Cmbcod_kind_engine.SelectedValue)
            SQLReader = CmdGeneralForReader.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                MyFrmEngineScreen.TxtAspiration.Text = Trim(SQLReader.Item("Aspiration") & "")
                MyFrmEngineScreen.TxtCubInDisplaceMent.Text = Trim(SQLReader.Item("cub_indisplacement") & "")
                MyFrmEngineScreen.TxtEngineType.Text = Cmbcod_kind_engine.Text
                MyFrmEngineScreen.TxtFuelDelivery.Text = Trim(SQLReader.Item("fuel_delivery") & "")
                MyFrmEngineScreen.TxtFuelType.Text = Trim(SQLReader.Item("fuel_type") & "")
                MyFrmEngineScreen.TxtSizeCubicCM.Text = Trim(SQLReader.Item("size_cubic_cm") & "")
                MyFrmEngineScreen.TxtSizeLiters.Text = Trim(SQLReader.Item("size_liters") & "")
            End If
        Catch ex As Exception
        Finally
            SQLReader.Close()
        End Try
    End Sub
    Friend Function MakeNewCod_Vehicle() As String
        Dim i As Integer
        Dim ValMakeNewcod_Vehicle As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_Vehicle) as Max_cod_Vehicle from bas_vehicle"
            MakeNewCod_Vehicle = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod_Vehicle = GetVal(MakeNewCod_Vehicle, LenVehicleCod)
            If ValMakeNewcod_Vehicle = MakeNewCod_Vehicle Then
                If MakeNewCod_Vehicle < 9999 Then
                    MakeNewCod_Vehicle = ValMakeNewcod_Vehicle + 1
                Else
                    MakeNewCod_Vehicle = "A001"
                End If

            Else
                If Val(ValMakeNewcod_Vehicle) > 0 Then
                    i = Len(ValMakeNewcod_Vehicle)
                Else
                    i = 0
                End If

                Dim FirstPartVehicle As String = Mid(MakeNewCod_Vehicle, 1, Len(MakeNewCod_Vehicle) - i)

                If ValMakeNewcod_Vehicle > 998 Then
                    FirstPartVehicle = Chr(Asc(FirstPartVehicle) + 1)
                    ValMakeNewcod_Vehicle = "000"

                End If
                If MakeNewCod_Vehicle.Length >= i Then
                    MakeNewCod_Vehicle = FirstPartVehicle + Getcod(Str((Int(Val(ValMakeNewcod_Vehicle)) + 1)).Trim, Len(ValMakeNewcod_Vehicle))
                End If
                If MakeNewCod_Vehicle.Trim.Length > LenVehicleCod Then
                    MakeNewCod_Vehicle = "A" + Getcod("1", LenVehicleCod - 1)
                End If
            End If
        Catch ex As Exception
            MakeNewCod_Vehicle = Getcod("1", LenVehicleCod)
        End Try
    End Function
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmSearchLicenseNo.ShowDialog()
    End Sub
    Private Sub MyFrmSearchLicenseNo_VehicleFind(ByVal ThisVehicleID As Double, ByVal ThisCodVehicle As String, ByVal ThisVehicleMake As String, ByVal ThisVehicleModel As String, ByVal ThisVehicleVin As String, ByVal ThisVehicleYear As String) Handles MyFrmSearchLicenseNo.VehicleFind
        License_No1.FieldCodValue = ThisVehicleID
    End Sub
    Private Sub TXTLicenseNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTLicenseNo.GotFocus
        TXTLicenseNo.SelectionLength = TXTLicenseNo.MaxLength
        TXTLicenseNo.SelectionStart = 0
    End Sub

    Private Sub BtnAddMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMake.Click
        Dim ar(0) As Object
        ar(0) = "305090400" ' Vehicle Make
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_make.SelectedValue
            DsFrmVehicle1.bas_vehicle_company.Clear()
            DAbas_vehicle_company.Fill(DsFrmVehicle1, "bas_vehicle_company")
            If DsFrmVehicle1.bas_vehicle_company.Rows.Count < 1 Then
                MsgFar("Please Fill The Vehicle Company Table")
                'Call DisableAllComponet(Me)
            End If
            ''''''''''''''''''''''''''Call FillDAbas_vehicle_model()
            Cmbcod_make.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAddModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddModel.Click
        Dim ar(0) As Object
        ar(0) = "305090500" ' Vehicle Model
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_model.SelectedValue
            ''''''''''''''''''Call FillDAbas_vehicle_model()
            DsFrmVehicle1.bas_vehicle_model.Clear()
            DAbas_vehicle_model.Fill(DsFrmVehicle1, "bas_vehicle_model")

            Cmbcod_model.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAddEngine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEngine.Click
        Dim ar(0) As Object
        ar(0) = "305090700" ' Vehicle Engine
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_kind_engine.SelectedValue
            DsFrmVehicle1.inv_tab_kind_engine.Clear()
            DAinv_tab_kind_engine.Fill(DsFrmVehicle1, "inv_tab_kind_engine")
            If DsFrmVehicle1.inv_tab_kind_engine.Rows.Count < 1 Then
                MsgFar("Please Fill The Engine Kind Table")
                'Call DisableAllComponet(Me)
            End If
            Cmbcod_kind_engine.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAddColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddColor.Click
        Dim ar(0) As Object
        ar(0) = "305090600" ' Vehicle color
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Try
            Dim TempVar As String = Cmbcod_color.SelectedValue
            DsFrmVehicle1.bas_color.Clear()
            DAbas_color.Fill(DsFrmVehicle1, "bas_color")
            If DsFrmVehicle1.bas_color.Rows.Count < 1 Then
                MsgFar("Please Fill The Vehicle Color Table")
                'Call DisableAllComponet(Me)
            End If
            Cmbcod_color.SelectedValue = TempVar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MyFrmChangeServiceRecords_SaveThis(ByVal LicenceNo As String, ByVal customercod As String, ByVal ChangeDate As String) Handles MyFrmChangeServiceRecords.SaveThis
        CmdGeneral.CommandText = "select max(radif) from ser_tr_vehicle_change_dtl where id_vehicle =" & License_No1.FieldCodValue
        Try
            CmdGeneral.Connection.Open()
        Catch ex As Exception
        End Try
        Dim LastRadif As Integer = CInt("0" & CmdGeneral.ExecuteScalar)
        If LastRadif = 0 Then
            LastRadif = 1
        Else
            LastRadif += 1
        End If
        Try
            CmdGeneral.CommandText = "Insert into ser_tr_vehicle_change_dtl (id_vehicle,radif,license_no_vehicle,cod_customer) values (" & License_No1.FieldCodValue & " , " & LastRadif & " , " & Qt(TXTLicenseNo.Text) & "," & Qt(CustomerCod1.Text) & " )"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "update ser_tr_vehicle set license_no_vehicle = " & Qt(LicenceNo) & " , cod_customer = " & Qt(customercod) & " , change_date = " & Qt(ChangeDate) & " Where id_vehicle= " & License_No1.FieldCodValue
            CmdGeneral.ExecuteNonQuery()
            Call PCancel()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub MyFrmChangeServiceRecords2_SaveThis(ByVal LicenceNo As String, ByVal ChangeDate As String) Handles MyFrmChangeServiceRecords2.SaveThis
        CmdGeneral.CommandText = "select max(radif) from ser_tr_vehicle_change_dtl where id_vehicle =" & License_No1.FieldCodValue
        Try
            CmdGeneral.Connection.Open()
        Catch ex As Exception
        End Try
        Dim LastRadif As Integer = CInt("0" & CmdGeneral.ExecuteScalar)
        If LastRadif = 0 Then
            LastRadif = 1
        Else
            LastRadif += 1
        End If
        Try
            CmdGeneral.CommandText = "Insert into ser_tr_vehicle_change_dtl (id_vehicle,radif,license_no_vehicle,cod_customer) values (" & License_No1.FieldCodValue & " , " & LastRadif & " , " & Qt(TXTLicenseNo.Text) & "," & Qt(CustomerCod1.Text) & " )"
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "update ser_tr_vehicle set license_no_vehicle = " & Qt(LicenceNo) & "  , change_date = " & Qt(ChangeDate) & " Where id_vehicle= " & License_No1.FieldCodValue
            CmdGeneral.ExecuteNonQuery()
            Call PCancel()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub MyFrmVehicle2_AfterLoad() Handles MyFrmVehicle2.AfterLoad
        MyFrmVehicle2.BtnChange.Enabled = False
        MyFrmVehicle2.PAddNew()
        MyFrmVehicle2.TXTLicenseNo.Text = TXTLicenseNo.Text
        MyFrmVehicle2.CustomerCod1.CustomerCod = CustomerCod1.CustomerCod
        MyFrmVehicle2.BtnChange.Enabled = False
        MyFrmVehicle2.ExitAfterSaveOrCancel = True
    End Sub
    Sub UpdateBeforVehicleFlag(ByVal TXTLicenseNo As String)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = "update  ser_tr_vehicle set vehicle_active=0 where license_no_vehicle=" & Qt(TXTLicenseNo)
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MyFrmVehicle2_AfterSave(ByVal Idload As Object) Handles MyFrmVehicle2.AfterSave
        Call PCancel()
        License_No1.FieldCodValue = Idload
    End Sub
End Class
